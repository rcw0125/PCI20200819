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
using XGCAP.UI.Q.QB;
using Common;

namespace XGCAP.UI.Q.QR
{
    public partial class FrmQR_GPGPCX : Form
    {
        public FrmQR_GPGPCX()
        {
            InitializeComponent();
        }


        Bll_TQC_SLAB_COMMUTE bll_commute = new Bll_TQC_SLAB_COMMUTE();
        /// <summary>
        /// 初始加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmQC006_Load(object sender, EventArgs e)
        {
            UserButtonRight.GetBtnFun(this, RV.UI.UserInfo.menuID);

            dte_Begin.EditValue = DateTime.Now.AddDays(-1).ToString("yyyy-MM-dd") + DateTime.Now.ToString(" 00:00:00");
            dte_End.EditValue = DateTime.Now.ToString("yyyy-MM-dd") + DateTime.Now.ToString(" 23:59:59");
        }
        /// <summary>
        /// 钢坯改判记录查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Query1_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = bll_commute.GetList_Query(dte_Begin.DateTime, dte_End.DateTime, txt_Stove1.Text).Tables[0];
                gc_GPGP.DataSource = dt;
                gv_GPGP.BestFitColumns();
                SetGridViewRowNum.SetRowNum(gv_GPGP);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_out_Click(object sender, EventArgs e)
        {
            OutToExcel.ToExcel(gc_GPGP, "钢坯改判结果" + "-" + System.DateTime.Now.ToString("yyyyMMddhhmmss"));
        }
    }

}
 
