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
    public partial class FrmPR_ZGJH_TJ : Form
    {
        private Bll_TRP_PLAN_ROLL bllTrpPlanRoll = new Bll_TRP_PLAN_ROLL();

        public FrmPR_ZGJH_TJ()
        {
            InitializeComponent();
        }

        private void FrmPR_ZGJH_TJ_Load(object sender, EventArgs e)
        {
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

                DataTable dt = bllTrpPlanRoll.Get_Zgfx(dt_Start.Text.Trim(), dt_End.Text.Trim()).Tables[0];

                gc_Zgfx.DataSource = dt;

                gv_Zgfx.Columns["订单计划完成率"].Caption = "订单计划完成率(%)";
                gv_Zgfx.Columns["计划量完成率"].Caption = "计划量完成率(%)";
                gv_Zgfx.Columns["订单实际完成率"].Caption = "订单实际完成率(%)";
                gv_Zgfx.Columns["实际量完成率"].Caption = "实际量完成率(%)";

                SetGridViewRowNum.SetRowNum(gv_Zgfx);

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
            OutToExcel.ToExcel(gc_Zgfx, "轧钢计划完成率统计-" + System.DateTime.Now.ToString("yyyyMMddhhmmss"));
        }
    }
}
