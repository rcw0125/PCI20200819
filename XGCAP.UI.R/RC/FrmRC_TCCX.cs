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

namespace XGCAP.UI.R.RC
{
    public partial class FrmRC_TCCX : Form
    {
        public FrmRC_TCCX()
        {
            InitializeComponent();
        }
        Bll_TRC_WARM_FURNACE_LOG bll = new Bll_TRC_WARM_FURNACE_LOG();
        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Query1_Click(object sender, EventArgs e)
        {
            try
            {

                WaitingFrom.ShowWait("");

                DataTable dt = bll.GetList(dte_Begin.DateTime, dte_End.DateTime, txt_Stove1.Text.Trim()).Tables[0];

                gc_GPGP.DataSource = dt;
                gv_GPGP.BestFitColumns();
                SetGridViewRowNum.SetRowNum(gv_GPGP);

                WaitingFrom.CloseWait();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// 导出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_out_Click(object sender, EventArgs e)
        {
            OutToExcel.ToExcel(gc_GPGP, "加热炉操作记录-" + System.DateTime.Now.ToString("yyyyMMddhhmmss"));
        }

        private void FrmRC_TCCX_Load(object sender, EventArgs e)
        {
            dte_Begin.EditValue = DateTime.Now.AddDays(-1).ToString("yyyy-MM-dd") + DateTime.Now.ToString(" 00:00:00");
            dte_End.EditValue = DateTime.Now.ToString("yyyy-MM-dd") + DateTime.Now.ToString(" 23:59:59");
        }
    }
}
