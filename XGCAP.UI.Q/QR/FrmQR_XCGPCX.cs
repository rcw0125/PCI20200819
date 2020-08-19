using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MODEL;
using BLL;
using Common;
using XGCAP.UI.Q.QB;

namespace XGCAP.UI.Q.QR
{
    /// <summary>
    /// 2018-05-24 zmc
    /// </summary>
    public partial class FrmQR_XCGPCX : Form
    {
        public FrmQR_XCGPCX()
        {
            InitializeComponent();
        }

        Bll_TQC_ROLL_COMMUTE bll_commute = new Bll_TQC_ROLL_COMMUTE();

        Bll_TQB_CHECKSTATE bll_checkstate = new Bll_TQB_CHECKSTATE();
        /// <summary>
        /// 初始加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmQC005_Load(object sender, EventArgs e)
        {
            UserButtonRight.GetBtnFun(this, RV.UI.UserInfo.menuID);

            dte_Begin.EditValue = DateTime.Now.AddDays(-1).ToString("yyyy-MM-dd") + DateTime.Now.ToString(" 00:00:00");
            dte_End.EditValue = DateTime.Now.ToString("yyyy-MM-dd") + DateTime.Now.ToString(" 23:59:59");
            DataSet dt = bll_checkstate.GetList("");
            imgcbo_PDDJ.Properties.Items.Clear();
            imgcbo_PDDJ.Properties.Items.Add("", "", -1);
            foreach (DataRow item in dt.Tables[0].Rows)//判定等级下拉框
            {
                imgcbo_PDDJ.Properties.Items.Add(item["C_CHECKSTATE_NAME"].ToString(), item["C_CHECKSTATE_NAME"].ToString(), -1);
            } 
        }

        /// <summary>
        /// 线材改判记录查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Query_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = bll_commute.GetList_Query_Group(dte_Begin.DateTime, dte_End.DateTime, txt_BatchNo1.Text.Trim(),icbo_Time.Text.Trim(),icbo_GZ.Text.Trim(),icbo_PDDJ.Text.Trim(),txt_GZ.Text.Trim(),imgcbo_PDDJ.Text.ToString()).Tables[0]; 
                gc_XCGP.DataSource = dt;
                gv_XCGP.BestFitColumns();
                SetGridViewRowNum.SetRowNum(gv_XCGP);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_out_Click(object sender, EventArgs e)
        {
            OutToExcel.ToExcel(gc_XCGP, "线材改判结果" +"-" + System.DateTime.Now.ToString("yyyyMMddhhmmss"));
        }
        /// <summary>
        /// 子信息查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gv_XCGP_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = this.gv_XCGP.GetDataRow(this.gv_XCGP.FocusedRowHandle);
            if (dr == null) return;
            gc_right.DataSource = null;
            DataTable dt = bll_commute.GetList_Query_Cou(dr["C_BATCH_NO"].ToString()).Tables[0];
            gc_right.DataSource = dt;
            gv_right.BestFitColumns();
            SetGridViewRowNum.SetRowNum(gv_right);
        }
        /// <summary>
        /// 子信息导出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_right_out_Click(object sender, EventArgs e)
        {
            OutToExcel.ToExcel(gc_XCGP, "线材改判结果子信息" + "-" + System.DateTime.Now.ToString("yyyyMMddhhmmss"));
        }
    }
}


