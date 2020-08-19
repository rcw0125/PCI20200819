using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

using RV.MODEL;
using RV.BLL;

namespace RV.UI
{
    public partial class FrmDEPT : Form
    {
        private static string namespaceString = string.Empty;


        private BllTS_DEPT bllDept = new BllTS_DEPT();

        string max = "0";

        string name = "";
        string text = "";
        string tag = "";
        string stdCode = "0";

        private DataTable dt = null;
        public FrmDEPT()
        {
            InitializeComponent();
        }
        private void FrmDEPT_Load(object sender, EventArgs e)
        {
            try
            {
                dt = bllDept.GetChildrenList().Tables[0];

                DataTable dt_root = bllDept.GetRootList().Tables[0];

                //创建根节点
                this.treeView1.Nodes.Clear();//清空节点

                for (int i = 0; i < dt_root.Rows.Count; i++)
                {
                    TreeNode rootNode = new TreeNode();

                    rootNode.Name = dt_root.Rows[i]["C_PARENT_ID"].ToString();
                    rootNode.Text = dt_root.Rows[i]["C_NAME"].ToString();
                    rootNode.Tag = dt_root.Rows[i]["C_ID"].ToString();

                    this.treeView1.Nodes.Add(rootNode);

                    CreateChildNode(rootNode, dt_root.Rows[i]["C_ID"].ToString());
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
                        where dt.Field<string>("C_PARENT_ID") == parentId
                        select dt;
            //创建该节点子节点
            foreach (var item in nodes)
            {
                TreeNode node = new TreeNode();
                node.Name = item["C_PARENT_ID"].ToString();
                node.Text = item["C_NAME"].ToString();
                node.Tag = item["C_ID"].ToString();


                //父节点添加子节点
                parentNode.Nodes.Add(node);
                //调用自身：递归
                CreateChildNode(node, item["C_ID"].ToString());
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
                if (e.Node.Nodes.Count > 0)
                {
                    if (!string.IsNullOrEmpty(treeView1.SelectedNode.Name) && !string.IsNullOrEmpty(treeView1.SelectedNode.Tag.ToString()))
                    {
                        name = treeView1.SelectedNode.Name;
                        text = treeView1.SelectedNode.Text;
                        tag = treeView1.SelectedNode.Tag.ToString();
                        DataTable dt_ITEM = bllDept.Get_List(tag).Tables[0];
                        gc_ANXX.DataSource = dt_ITEM;
                        gv_ANXX.BestFitColumns();

                        max = bllDept.GetMaxCode(tag);

                        stdCode = bllDept.GetCode(tag);
                    }
                }
                else
                {
                    name = "";
                    text = "";
                    tag = "";

                    gc_ANXX.DataSource = null;
                    gv_ANXX.BestFitColumns();
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
                ModTS_DEPT model = new ModTS_DEPT();

                if (string.IsNullOrEmpty(txt_Name.Text.Trim()))
                {
                    MessageBox.Show("请填写部门名称！");
                    return;
                }

                model.C_NAME = txt_Name.Text.Trim();
                model.C_PARENT_ID = tag;

                if (max == "0")
                {
                    max = stdCode + "01";
                }
                else
                {
                    max = (Convert.ToInt32(max) + 1).ToString();
                }

                model.C_CODE = max;
                model.N_STATUS = 1;

                if (name == "-1")
                {
                    model.C_DEPTH = 1;
                }

                model.C_EMP_ID = UserInfo.userID;
                model.C_EMP_NAME = UserInfo.menuName;

                if (bllDept.Add(model))
                {
                    MessageBox.Show("添加成功！");

                    DataTable dt_ITEM = bllDept.Get_List(tag).Tables[0];
                    gc_ANXX.DataSource = dt_ITEM;
                    gv_ANXX.BestFitColumns();
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
                    ModTS_DEPT model = bllDept.GetModel(dr["C_ID"].ToString());
                    if (model != null)
                    {
                        model.N_STATUS = 0;
                        model.C_EMP_ID = UserInfo.userID;
                        model.C_EMP_NAME = UserInfo.userName;
                        model.D_MOD_DT = ServerTime.timeNow();
                        if (bllDept.Update(model))
                        {
                            MessageBox.Show("删除成功！");

                            DataTable dt_ITEM = bllDept.Get_List(tag).Tables[0];
                            gc_ANXX.DataSource = dt_ITEM;
                            gv_ANXX.BestFitColumns();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow dr = gv_ANXX.GetDataRow(gv_ANXX.FocusedRowHandle);
                if (dr != null)
                {
                    ModTS_DEPT model = bllDept.GetModel(dr["C_ID"].ToString());
                    if (model != null)
                    {
                        if (string.IsNullOrEmpty(gv_ANXX.GetRowCellValue(gv_ANXX.FocusedRowHandle, "C_NAME").ToString()))
                        {
                            MessageBox.Show("部门名称不能为空！");
                            return;
                        }

                        model.C_NAME = gv_ANXX.GetRowCellValue(gv_ANXX.FocusedRowHandle, "C_NAME").ToString();
                        model.C_EMP_ID = UserInfo.userID;
                        model.C_EMP_NAME = UserInfo.userName;
                        model.D_MOD_DT = ServerTime.timeNow();

                        if (bllDept.Update(model))
                        {
                            MessageBox.Show("修改成功！");

                            DataTable dt_ITEM = bllDept.Get_List(tag).Tables[0];
                            gc_ANXX.DataSource = dt_ITEM;
                            gv_ANXX.BestFitColumns();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}








