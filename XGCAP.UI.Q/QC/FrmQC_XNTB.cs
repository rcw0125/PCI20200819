using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Common;
using BLL;
using MODEL;

namespace XGCAP.UI.Q.QC
{
    public partial class FrmQC_XNTB : Form
    {
        private Bll_TRC_ROLL_PRODCUT bllTrcRollProdcut = new Bll_TRC_ROLL_PRODCUT();
        private Bll_TQC_COMPRE_ITEM_RESULT bllTqcCompreItemResult = new Bll_TQC_COMPRE_ITEM_RESULT();

        public FrmQC_XNTB()
        {
            InitializeComponent();
        }

        private void FrmQC_XNTB_Load(object sender, EventArgs e)
        {
            dt_Start.EditValue = DateTime.Now.AddDays(-1).ToString("yyyy-MM-dd") + DateTime.Now.ToString(" 00:00:00");
            dt_End.EditValue = DateTime.Now.ToString("yyyy-MM-dd") + DateTime.Now.ToString(" 23:59:59");
        }

        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Query_Click(object sender, EventArgs e)
        {
            BindBatchList();
        }

        /// <summary>
        /// 查询批号信息
        /// </summary>
        private void BindBatchList()
        {
            try
            {
                WaitingFrom.ShowWait("");

                gc_Batch.DataSource = null;

                DataTable dt = bllTrcRollProdcut.GetList_TB(dt_Start.Text.Trim(), dt_End.Text.Trim(), txt_BatchNo.Text.Trim()).Tables[0];

                gc_Batch.DataSource = dt;
                SetGridViewRowNum.SetRowNum(gv_Batch);

                WaitingFrom.CloseWait();
            }
            catch
            {

            }
        }

        /// <summary>
        /// 同步
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Tb_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_BatchNo.Text.Trim()))
            {
                if (DialogResult.No == MessageBox.Show("确认同步批号" + txt_BatchNo.Text.Trim() + "的成分性能信息？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
                {
                    return;
                }
            }
            else
            {
                MessageBox.Show("请输入要同步的批号！");
                return;
            }

            WaitingFrom.ShowWait("正在同步，请稍等...");

            string result = bllTqcCompreItemResult.Tb_NC_CfXn(txt_BatchNo.Text.Trim());

            if (result == "1")
            {
                MessageBox.Show("同步成功！");
            }
            else
            {
                MessageBox.Show(result);
            }

            WaitingFrom.CloseWait();
        }

        private void gv_Batch_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gv_Batch.GetDataRow(e.FocusedRowHandle);
            if (dr != null)
            {
                BindItem(dr["C_BATCH_NO"].ToString(), dr["C_STL_GRD"].ToString(), dr["C_STD_CODE"].ToString());
                BindItemNC(dr["C_BATCH_NO"].ToString(), dr["C_MAT_CODE"].ToString());
            }
        }

        private void BindItem(string C_BATCH_NO, string C_STL_GRD, string C_STD_CODE)
        {
            DataTable dt = bllTqcCompreItemResult.Get_Item_List(C_BATCH_NO, C_STL_GRD, C_STD_CODE).Tables[0];
            gc_Item.DataSource = dt;
            SetGridViewRowNum.SetRowNum(gv_Item);
        }

        private void BindItemNC(string C_BATCH_NO, string C_MAT_CODE)
        {
            string batch_head = C_BATCH_NO.Substring(0, 1);
            string strMATTYPE = C_MAT_CODE.Substring(0, 3);

            DataTable dt_item = new DataTable(); ;

            if (strMATTYPE == "805" && batch_head != "3")
            {
                dt_item = bllTqcCompreItemResult.Get_NC_Item_List_WW(C_BATCH_NO).Tables[0];
            }
            else if (batch_head == "3" || strMATTYPE == "807" || strMATTYPE == "806")
            {
                dt_item = bllTqcCompreItemResult.Get_NC_Item_List_PT(C_BATCH_NO).Tables[0];
            }

            gc_Item_NC.DataSource = dt_item;
            SetGridViewRowNum.SetRowNum(gv_Item_NC);
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
                DataRow dr = gv_Batch.GetDataRow(gv_Batch.FocusedRowHandle);
                if (dr != null)
                {
                    FrmQC_CFXN_ADD frm = new FrmQC_CFXN_ADD(dr["C_BATCH_NO"].ToString(), dr["C_STD_CODE"].ToString(), dr["C_STL_GRD"].ToString());
                    frm.ShowDialog();

                    BindItem(dr["C_BATCH_NO"].ToString(), dr["C_STL_GRD"].ToString(), dr["C_STD_CODE"].ToString());
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
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow dr = gv_Item.GetDataRow(gv_Item.FocusedRowHandle);
                if (dr != null)
                {
                    if (dr["C_SOURCE"].ToString() == "1")
                    {
                        if (bllTqcCompreItemResult.Delete(dr["C_ID"].ToString()))
                        {
                            MessageBox.Show("删除成功！");

                            DataRow dr_Batch = gv_Batch.GetDataRow(gv_Batch.FocusedRowHandle);
                            if (dr_Batch != null)
                            {
                                BindItem(dr_Batch["C_BATCH_NO"].ToString(), dr_Batch["C_STL_GRD"].ToString(), dr_Batch["C_STD_CODE"].ToString());
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("该数据不是手动添加的，不能删除！");
                        return;
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
