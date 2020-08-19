using BLL;
using Common;
using MODEL;
using RV.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace XGCAP.UI.Q.QR
{
    public partial class FrmQR_ANQX : Form
    {
        private static string namespaceString = string.Empty;


        private Bll_TS_MODULE bllModule = new Bll_TS_MODULE();
        string max = "";
        string strParentID = "-1";
        string N_SORT = "";
        string strFormName = "";
        string tag = "";

        private DataTable dt = null;
        public FrmQR_ANQX()
        {
            InitializeComponent();
        }
        private void FrmQR_ANQX_Load(object sender, EventArgs e)
        {
            try
            {
                dt = bllModule.GetMenuList(" C_PARENTMODULEID !='0' ", "1").Tables[0];

                DataTable dt_root = bllModule.GetMenuList(" C_PARENTMODULEID ='0' ", "1").Tables[0];

                //创建根节点
                this.treeView1.Nodes.Clear();//清空节点

                for (int i = 0; i < dt_root.Rows.Count; i++)
                {
                    TreeNode rootNode = new TreeNode();

                    rootNode.Name = dt_root.Rows[i]["C_PARENTMODULEID"].ToString();
                    rootNode.Text = dt_root.Rows[i]["C_MODULENAME"].ToString();
                    rootNode.Tag = dt_root.Rows[i]["C_MODULEID"].ToString();

                    this.treeView1.Nodes.Add(rootNode);

                    CreateChildNode(rootNode, dt_root.Rows[i]["C_MODULEID"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void CreateChildNode(TreeNode parentNode, string parentId)
        {
            //找到该节点下的子项（父节点值等于该节点编号）
            var nodes = from dt in dt.AsEnumerable()
                        where dt.Field<string>("C_PARENTMODULEID") == parentId
                        select dt;
            //创建该节点子节点
            foreach (var item in nodes)
            {
                TreeNode node = new TreeNode();
                node.Name = item["C_PARENTMODULEID"].ToString();
                node.Text = item["C_MODULENAME"].ToString();
                node.Tag = item["C_MODULEID"].ToString();


                //父节点添加子节点
                parentNode.Nodes.Add(node);
                //调用自身：递归
                CreateChildNode(node, item["C_MODULEID"].ToString());
            }
        }
        /// <summary>
        /// 添加或修改选中菜单的按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            try
            {
                if (e.Node.Nodes.Count == 0)
                {
                    if (!string.IsNullOrEmpty(treeView1.SelectedNode.Name) && !string.IsNullOrEmpty(treeView1.SelectedNode.Tag.ToString()))
                    {
                        string name = treeView1.SelectedNode.Name;
                        string text = treeView1.SelectedNode.Text;
                        tag = treeView1.SelectedNode.Tag.ToString();
                        DataTable dt = bllModule.GetList_query(tag).Tables[0];
                        this.gc_ANXX.DataSource = dt;
                        gv_ANXX.BestFitColumns();
                        SetGridViewRowNum.SetRowNum(gv_ANXX);

                        strParentID = tag;

                        DataTable dt_max = bllModule.GetList_MAX(treeView1.SelectedNode.Tag.ToString()).Tables[0];
                        if (dt_max == null) return;
                        max = dt_max.Rows[0]["C_MODULEID"].ToString();
                        N_SORT = dt_max.Rows[0]["N_ORDER"].ToString();
                        lab_Name.Text = treeView1.SelectedNode.Text;

                        strFormName = bllModule.Get_FormName(strParentID);
                    }
                }
                else
                {
                    strParentID = "-1";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                gv_ANXX.AddNewRow();
                if (string.IsNullOrEmpty(max))
                {
                    max = tag + "001";
                }
                else
                {
                    max = (Convert.ToInt32(max) + 1).ToString();
                }

                string str = "AN" + max;

                gv_ANXX.SetFocusedRowCellValue("C_MODULEID", str);
                gv_ANXX.SetFocusedRowCellValue("C_PARENTMODULEID", tag);

                if (string.IsNullOrEmpty(N_SORT))
                {
                    N_SORT = "1";
                    gv_ANXX.SetFocusedRowCellValue("N_ORDER", N_SORT);
                }
                else
                {
                    N_SORT = (Convert.ToInt32(N_SORT) + 1).ToString();
                    gv_ANXX.SetFocusedRowCellValue("N_ORDER", N_SORT);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Del_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow dr = gv_ANXX.GetDataRow(gv_ANXX.FocusedRowHandle);
                if (dr != null)
                {
                    int a = bllModule.GetUsingCount(dr["C_MODULEID"].ToString());
                    if (a > 0)
                    {
                        if (MessageBox.Show("这个按钮分配按钮权限时已经使用，是否确认删除？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                        {
                            bllModule.Delete(dr["C_MODULEID"].ToString());
                            bllModule.Delete_UserFunction(dr["C_MODULEID"].ToString());

                            gv_ANXX.DeleteRow(gv_ANXX.FocusedRowHandle);
                        }
                    }
                    else
                    {
                        bllModule.Delete(dr["C_MODULEID"].ToString());
                        bllModule.Delete_UserFunction(dr["C_MODULEID"].ToString());

                        gv_ANXX.DeleteRow(gv_ANXX.FocusedRowHandle);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Saves_Click(object sender, EventArgs e)
        {
            try
            {
                int a = gv_ANXX.DataRowCount;
                int b = 0;

                bllModule.Delete_PID(strParentID);

                for (int i = 0; i < gv_ANXX.DataRowCount; i++)
                {
                    b++;

                    DataRow dr = this.gv_ANXX.GetDataRow(i);

                    Mod_TS_MODULE model = new Mod_TS_MODULE();
                    model.C_MODULEID = dr["C_MODULEID"].ToString();
                    model.C_PARENTMODULEID = dr["C_PARENTMODULEID"].ToString();
                    model.C_MODULENAME = dr["C_MODULENAME"].ToString();
                    model.C_MODULECLASS = dr["C_MODULECLASS"].ToString();
                    model.C_DISABLE = "1";
                    model.C_ASSEMBLYNAME = strFormName;

                    if (!string.IsNullOrEmpty(dr["N_ORDER"].ToString()))
                    {
                        model.N_ORDER = Convert.ToDecimal(dr["N_ORDER"].ToString());
                    }

                    model.C_MODULE_TYPE = "3";
                    model.C_EMP_ID = RV.UI.UserInfo.userID;

                    bllModule.Add(model);
                }

                if (a == b)
                {
                    MessageBox.Show("保存成功！");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}








