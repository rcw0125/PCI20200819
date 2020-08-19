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
    public partial class FrmMenuManage : Form
    {
        private BllTS_MODULE bllModule = new BllTS_MODULE();

        private DataTable dt = null;

        private string strID = "0";

        public FrmMenuManage()
        {
            InitializeComponent();
        }

        private void FrmMenuManage_Load(object sender, EventArgs e)
        {
            BindTreeList();
            //string res;
            //frmWaitingBox f = new frmWaitingBox((obj, args) =>
            //{
            //    BindTreeList();
            //});
            //f.ShowDialog(this);
            //res = f.Message;
            //if (!string.IsNullOrEmpty(res))
            //    MessageBox.Show(res);
        }

        public void BindTreeList()
        {
            try
            {
                dt = bllModule.GetList("", "").Tables[0];

                tl_Module.KeyFieldName = "C_MODULEID";//主键名称  
                tl_Module.ParentFieldName = "C_PARENTMODULEID";//父级ID 

                bscTSMODULE.DataSource = dt;

                tl_Module.DataSource = bscTSMODULE;//数据源
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tl_Module_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {
            strID = e.Node.GetValue("C_MODULEID").ToString();
        }

        /// <summary>
        /// 添加根目录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            try
            {
                FrmMenuAdd frmAdd = new FrmMenuAdd("0", false);
                frmAdd.Owner = this;
                frmAdd.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 添加子目录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void simpleButton3_Click(object sender, EventArgs e)
        {
            try
            {
                FrmMenuAdd frmAdd = new FrmMenuAdd(strID, false);
                frmAdd.Owner = this;
                frmAdd.ShowDialog();
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

        private void tl_Module_DoubleClick(object sender, EventArgs e)
        {
            object item = this.bscTSMODULE.Current;
            if (item != null)
            {
                DataRowView drv = item as DataRowView;
                FrmMenuAdd frmAdd = new FrmMenuAdd(drv["C_MODULEID"].ToString(), true);
                frmAdd.Owner = this;
                frmAdd.ShowDialog();
            }
        }

        /// <summary>
        /// 上移
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void simpleButton4_Click(object sender, EventArgs e)
        {
            try
            {
                object item = this.bscTSMODULE.Current;
                if (item != null)
                {
                    DataRowView drv = item as DataRowView;

                    ModTS_MODULE mod = bllModule.GetModel(drv["C_PARENTMODULEID"].ToString(), Convert.ToInt32(drv["N_ORDER"].ToString()) - 1);
                    if (mod != null)
                    {
                        int order_up = Convert.ToInt32(mod.N_ORDER);
                        int order_down = Convert.ToInt32(drv["N_ORDER"].ToString());

                        bllModule.ResetOrder(mod.C_MODULEID, drv["C_MODULEID"].ToString(), order_up, order_down);

                        BindTreeList();

                        foreach (TreeListNode node in tl_Module.Nodes)
                        {
                            if (node.Nodes.Count > 0)
                            {
                                PRV_SetState(drv["C_MODULEID"].ToString(), node);
                            }

                            string a = node.GetValue("C_MODULEID").ToString();
                            string b = drv["C_MODULEID"].ToString();
                            if (node.GetValue("C_MODULEID").ToString() == drv["C_MODULEID"].ToString())
                            {
                                node.Selected = true;
                            }
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void PRV_SetState(string sId, TreeListNode IN_CheckedNode)
        {
            if (IN_CheckedNode.HasChildren)
            {
                foreach (TreeListNode Each_Node in IN_CheckedNode.Nodes)
                {
                    PRV_SetState(sId, Each_Node);
                }
            }
            else
            {
                if (IN_CheckedNode.GetValue("C_MODULEID").ToString() == sId)
                {
                    IN_CheckedNode.Selected = true;
                }
                
            }
        }

        /// <summary>
        /// 下移
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void simpleButton5_Click(object sender, EventArgs e)
        {
            try
            {
                object item = this.bscTSMODULE.Current;
                if (item != null)
                {
                    DataRowView drv = item as DataRowView;

                    ModTS_MODULE mod = bllModule.GetModel(drv["C_PARENTMODULEID"].ToString(), Convert.ToInt32(drv["N_ORDER"].ToString()) + 1);
                    if (mod != null)
                    {
                        int order_up = Convert.ToInt32(mod.N_ORDER);
                        int order_down = Convert.ToInt32(drv["N_ORDER"].ToString());

                        bllModule.ResetOrder(mod.C_MODULEID, drv["C_MODULEID"].ToString(), order_up, order_down);

                        BindTreeList();

                        foreach (TreeListNode node in tl_Module.Nodes)
                        {
                            if (node.Nodes.Count > 0)
                            {
                                PRV_SetState(drv["C_MODULEID"].ToString(), node);
                            }

                            string a = node.GetValue("C_MODULEID").ToString();
                            string b = drv["C_MODULEID"].ToString();
                            if (node.GetValue("C_MODULEID").ToString() == drv["C_MODULEID"].ToString())
                            {
                                node.Selected = true;
                            }
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
