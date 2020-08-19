using BLL;
using Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XGCAP.UI.R.RR
{
    public partial class FrmRP_WGD : Form
    {
        public FrmRP_WGD()
        {
            InitializeComponent();
        }

        Bll_TRC_ROLL_WGD bll_TRC_ROLL_WGD = new Bll_TRC_ROLL_WGD();
        Bll_TB_STA bll_TB_STA = new Bll_TB_STA();

        private void btn_QueryNC_Click(object sender, EventArgs e)
        {
            int compareDt = DateTime.Compare(this.dt_Plan.DateTime, this.dt_PlanEnd.DateTime);
            if (compareDt > 0)
            {
                MessageBox.Show("日期错误!");
                return;
            }
            BindWgd();
        }

        private void FrmRP_WGD_Load(object sender, EventArgs e)
        {
            this.dt_Plan.DateTime = DateTime.Now.AddDays(-10);
            this.dt_PlanEnd.DateTime = DateTime.Now.AddDays(1);

            CommonSub.BindIcbo("", "ZX", icbo_ZX);
            icbo_ZX.SelectedIndex = 0;
        }

        public void BindWgd()
        {
            string sqlWhere = "";

            if (!string.IsNullOrEmpty(icbo_ZX.EditValue.ToString()))
            {
                sqlWhere = "   TRW.N_SCRF=3   AND TRW.C_STA_ID='" + icbo_ZX.EditValue.ToString() + "'       ";
            }
            else
            {
                sqlWhere = "   TRW.N_SCRF=3      ";
            }

            if (this.dt_Plan.DateTime != DateTime.MinValue)
            {
                sqlWhere += " AND TRW.D_MOD_DT>to_date('" + dt_Plan.DateTime.ToString("yyyy/MM/dd") + " 00:00:00" + "','yyyy-mm-dd hh24:mi:ss') ";
                sqlWhere += " AND  TRW.D_MOD_DT<to_date('" + dt_PlanEnd.DateTime.ToString("yyyy/MM/dd") + " 23:59:59" + "','yyyy-mm-dd hh24:mi:ss') ";
            }

            this.gc_NC.DataSource = bll_TRC_ROLL_WGD.GetList(sqlWhere).Tables[0];
            this.gv_NC.OptionsView.ColumnAutoWidth = false;
            SetGridViewRowNum.SetRowNum(gv_NC);
        }

        private void btn_out_toExcel1_Click(object sender, EventArgs e)
        {
            OutToExcel.ToExcel(this.gc_NC, "完工记录" + System.DateTime.Now.ToString("yyyyMMddhhmmss"));
        }
    }
}
