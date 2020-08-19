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

namespace XGCAP.UI.P.PR
{
    public partial class FrmPR_JHQTJ_MX : Form
    {
        private Bll_TMD_DISPATCHDETAILS bllTmd = new Bll_TMD_DISPATCHDETAILS();

        public FrmPR_JHQTJ_MX()
        {
            InitializeComponent();
        }

        private void FrmPR_JHQTJ_MX_Load(object sender, EventArgs e)
        {
            dt_Start.EditValue = DateTime.Now.ToString("yyyy-MM-dd") + DateTime.Now.ToString(" 00:00:00");
            dt_End.EditValue = DateTime.Now.ToString("yyyy-MM-dd") + DateTime.Now.ToString(" 23:59:59");
        }

        private void btn_query_zg_Click(object sender, EventArgs e)
        {
            BindInfo();
        }

        private void BindInfo()
        {
            try
            {
                WaitingFrom.ShowWait("");

                DataTable dt = bllTmd.GetList(dt_Start.Text.Trim(), dt_End.Text.Trim()).Tables[0];

                gc_MX.DataSource = dt;
                SetGridViewRowNum.SetRowNum(gv_MX);

                WaitingFrom.CloseWait();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_out_Click(object sender, EventArgs e)
        {
            OutToExcel.ToExcel(this.gc_MX,"交期统计明细"+System.DateTime.Now.ToString("yyyyMMddhhmmss "));
        }
    }
}
