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
    public partial class FrmPR_LGFJCJH : Form
    {
        private Bll_TSP_CAST_PLAN bllTspCastPlan = new Bll_TSP_CAST_PLAN();

        public FrmPR_LGFJCJH()
        {
            InitializeComponent();
        }

        private void FrmPR_LGJH_TJ_Load(object sender, EventArgs e)
        {
            CommonSub.BindIcbo("", "CC", icbo_lz3);

            dt_Start.EditValue = DateTime.Now.ToString("yyyy-MM-dd") + DateTime.Now.ToString(" 00:00:00");
            dt_End.EditValue = DateTime.Now.ToString("yyyy-MM-dd") + DateTime.Now.ToString(" 23:59:59");
        }

        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_query_zg_Click(object sender, EventArgs e)
        {
            BindList();
        }

        private void BindList()
        {
            try
            {
                WaitingFrom.ShowWait("");

                DataTable dt = bllTspCastPlan.GetStopPlan(icbo_lz3.Properties.Items[this.icbo_lz3.SelectedIndex].Value.ToString(), dt_Start.Text.Trim(), dt_End.Text.Trim());

                gc_Lgfx.DataSource = dt;
                gv_Lgfx.BestFitColumns();
                SetGridViewRowNum.SetRowNum(gv_Lgfx);

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
            OutToExcel.ToExcel(gc_Lgfx, "炼钢非浇次计划统计-" + System.DateTime.Now.ToString("yyyyMMddhhmmss"));
        }
    }
}
