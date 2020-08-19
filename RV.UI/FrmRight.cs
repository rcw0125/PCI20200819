using DevExpress.XtraTreeList.Nodes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using RV.MODEL;
using RV.BLL;

namespace RV.UI
{
    public partial class FrmRight : Form
    {
        private BllTS_MODULE bllModule = new BllTS_MODULE();
        private BllTS_USER_FUN_PCI bllUserFun = new BllTS_USER_FUN_PCI();
        private BllTS_ROLE_FUN_PCI bllRollFun = new BllTS_ROLE_FUN_PCI();

        private DataTable dt = null;

        private string strID = "0";
        private string strType = "1";

        public FrmRight(string str,string stype)
        {
            InitializeComponent();

            strID = str;
            strType = stype;
        }

        private void FrmRight_Load(object sender, EventArgs e)
        {
            BindTreeList();
        }

        public void BindTreeList()
        {
            try
            {
                dt = bllModule.GetList().Tables[0];

                tl_Module.KeyFieldName = "C_MODULEID";//主键名称  
                tl_Module.ParentFieldName = "C_PARENTMODULEID";//父级ID 

                bscTSMODULE.DataSource = dt;

                tl_Module.DataSource = bscTSMODULE;//数据源

                //tl_Module.DataSource = dt;//数据源

                BindRight();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 加载已有的权限
        /// </summary>
        private void BindRight()
        {
            try
            {
                if (tl_Module.Nodes.Count > 0)
                {
                    if (strType == "1")//用户权限
                    {
                        DataTable dtMenuID = bllUserFun.GetList(" C_FUNCTION_TYPE='2' and C_USER_ID='" + strID + "' ").Tables[0];

                        for (int i = 0; i < dtMenuID.Rows.Count; i++)
                        {
                            TreeListNode node = tl_Module.FindNodeByKeyID(dtMenuID.Rows[i]["C_MODULE_ID"].ToString());
                            node.CheckState = CheckState.Checked;

                            SetCheckedParentNodes(node, node.CheckState);
                        }
                    }
                    else if (strType == "2")//角色权限
                    {
                        DataTable dtMenuID = bllRollFun.GetList(" C_FUNCTION_TYPE='2' and C_ROLE_ID='" + strID + "' ").Tables[0];

                        for (int i = 0; i < dtMenuID.Rows.Count; i++)
                        {
                            TreeListNode node = tl_Module.FindNodeByKeyID(dtMenuID.Rows[i]["C_MODULE_ID"].ToString());
                            node.CheckState = CheckState.Checked;

                            SetCheckedParentNodes(node, node.CheckState);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            //BindTreeList();
            string res;
            frmWaitingBox f = new frmWaitingBox((obj, args) =>
            {
                BindTreeList();
            });
            f.ShowDialog(this);
            res = f.Message;
            if (!string.IsNullOrEmpty(res))
                MessageBox.Show(res);
        }



        #region 节点选中前事件  
        private void tl_Module_BeforeCheckNode(object sender, DevExpress.XtraTreeList.CheckNodeEventArgs e)
        {
            if (e.PrevState == CheckState.Checked)
            {
                e.State = CheckState.Unchecked;
            }
            else
            {
                e.State = CheckState.Checked;
            }
        }
        #endregion

        #region 节点选中后事件  
        private void tl_Module_AfterCheckNode(object sender, DevExpress.XtraTreeList.NodeEventArgs e)
        {
            SetCheckedChildNodes(e.Node, e.Node.CheckState);
            SetCheckedParentNodes(e.Node, e.Node.CheckState);
        }
        #endregion

        #region 设置子节点状态  
        private void SetCheckedChildNodes(DevExpress.XtraTreeList.Nodes.TreeListNode node, CheckState check)
        {
            for (int i = 0; i < node.Nodes.Count; i++)
            {
                node.Nodes[i].CheckState = check;
                SetCheckedChildNodes(node.Nodes[i], check);
            }
        }
        #endregion

        #region 设置父节点状态  
        private void SetCheckedParentNodes(DevExpress.XtraTreeList.Nodes.TreeListNode node, CheckState check)
        {
            if (node.ParentNode != null)
            {
                bool b = false;
                CheckState state;
                for (int i = 0; i < node.ParentNode.Nodes.Count; i++)
                {
                    state = (CheckState)node.ParentNode.Nodes[i].CheckState;
                    if (!check.Equals(state))
                    {
                        b = !b;
                        break;
                    }
                }
                if (b)
                {
                    node.ParentNode.CheckState = CheckState.Indeterminate;
                }
                else
                {
                    node.ParentNode.CheckState = check;
                }
                SetCheckedParentNodes(node.ParentNode, check);
            }
        }
        #endregion

        /// <summary>
        /// 确定
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                this.lstCheckedID.Clear();

                if (tl_Module.Nodes.Count > 0)
                {
                    foreach (TreeListNode root in tl_Module.Nodes)
                    {
                        GetCheckedID(root);
                    }
                }

                string idStr = string.Empty;
                foreach (string id in lstCheckedID)
                {
                    idStr += "'" + id + "',";
                }

                if (idStr.Length > 0)
                {
                    DataTable dtMenuID = bllModule.Get_MenuID(idStr.Substring(0, idStr.Length - 1)).Tables[0];

                    if (strType == "1")//用户权限
                    {
                        if (bllUserFun.SaveFun(lstCheckedID, dtMenuID, strID))
                        {
                            MessageBox.Show("权限分配成功！");
                        }
                    }
                    else if (strType == "2")//角色权限
                    {
                        if (bllRollFun.SaveFun(lstCheckedID, dtMenuID, strID))
                        {
                            MessageBox.Show("权限分配成功！");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private List<string> lstCheckedID = new List<string>();

        /// <summary>
        /// 获取选择状态的数据主键ID集合
        /// </summary>
        /// <param name="parentNode">父级节点</param>
        private void GetCheckedID(TreeListNode parentNode)
        {
            if (parentNode.Nodes.Count == 0)
            {
                return;//递归终止
            }

            foreach (TreeListNode node in parentNode.Nodes)
            {
                if (node.CheckState == CheckState.Checked)
                {
                    if (node.Nodes.Count == 0)
                    {
                        DataRowView drv = tl_Module.GetDataRecordByNode(node) as DataRowView;
                        if (drv != null)
                        {
                            string OfficeID = drv["C_MODULEID"].ToString();
                            lstCheckedID.Add(OfficeID);
                        }
                    }
                }

                GetCheckedID(node);

            }
        }

        /// <summary>
        /// 窗体第一次显示时执行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmRight_Shown(object sender, EventArgs e)
        {
            BindRight();
        }
    }
}
