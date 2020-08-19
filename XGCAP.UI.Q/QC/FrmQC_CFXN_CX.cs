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
    public partial class FrmQC_CFXN_CX : Form
    {
        private Bll_TRC_ROLL_PRODCUT bllTrcRollProdcut = new Bll_TRC_ROLL_PRODCUT();
        private Bll_TQC_COMPRE_ITEM_RESULT bllTqcCompreItemResult = new Bll_TQC_COMPRE_ITEM_RESULT();

        public FrmQC_CFXN_CX()
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



        private void gv_Batch_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            gc_Item.DataSource = null;
            DataRow dr = gv_Batch.GetDataRow(e.FocusedRowHandle);
            if (dr != null)
            {
                BindItem(dr["C_BATCH_NO"].ToString(), dr["C_STL_GRD"].ToString(), dr["C_STD_CODE"].ToString());
            }
        }

        private void BindItem(string C_BATCH_NO, string C_STL_GRD, string C_STD_CODE)
        {
            DataTable dt = bllTqcCompreItemResult.Get_Item_List(C_BATCH_NO.Substring(0,9), C_STL_GRD, C_STD_CODE).Tables[0];
            gc_Item.DataSource = dt;
            SetGridViewRowNum.SetRowNum(gv_Item);
        }


    }
}
