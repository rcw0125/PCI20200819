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
    public partial class FrmSetDept : Form
    {
        private BllTS_DEPT bllTsDept = new BllTS_DEPT();
        private BllTS_USER_FUN_PCI bllUserFun = new BllTS_USER_FUN_PCI();
        private BllTS_ROLE_FUN_PCI bllRollFun = new BllTS_ROLE_FUN_PCI();

        private DataTable dt = null;
        public string strDeptID = "0";
        public string strDeptName = "";

        private string strUserID = "0";

        public FrmSetDept(string str)
        {
            InitializeComponent();

            strUserID = str;
        }

        private void FrmSetDept_Load(object sender, EventArgs e)
        {
            BindTreeList();
        }

        public void BindTreeList()
        {
            try
            {
                dt = bllTsDept.GetList("").Tables[0];

                tl_Module.KeyFieldName = "C_ID";//主键名称  
                tl_Module.ParentFieldName = "C_PARENT_ID";//父级ID 

                bscTsDept.DataSource = dt;

                tl_Module.DataSource = bscTsDept;//数据源

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 确定
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                //foreach (TreeListNode root in tl_Module.Nodes)
                //{
                //    GetCheckedID(root);
                //}

                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 获取选择状态的数据主键ID集合
        /// </summary>
        /// <param name="parentNode">父级节点</param>
        private void GetCheckedID(TreeListNode parentNode)
        {
            //if (parentNode.Nodes.Count == 0)
            //{
            //    return;//递归终止
            //}

            foreach (TreeListNode node in parentNode.Nodes)
            {
                if (node.Focused == true)
                {
                    DataRowView drv = tl_Module.GetDataRecordByNode(node) as DataRowView;
                    if (drv != null)
                    {
                        strDeptID = drv["C_ID"].ToString();
                        strDeptName = drv["C_NAME"].ToString();
                        break;
                    }
                }
            }
        }

        private void tl_Module_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {
            DataRowView drv = tl_Module.GetDataRecordByNode(e.Node) as DataRowView;

            if (drv != null)
            {
                strDeptID = drv["C_ID"].ToString();
                strDeptName = drv["C_NAME"].ToString();
            }
        }
    }
}
