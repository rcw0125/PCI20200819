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
    public partial class FrmPR_LGJH_TJ : Form
    {
        private Bll_TSP_PLAN_SMS bllTspPlanSms = new Bll_TSP_PLAN_SMS();

        public FrmPR_LGJH_TJ()
        {
            InitializeComponent();
        }

        private void FrmPR_LGJH_TJ_Load(object sender, EventArgs e)
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

                DataTable dt = bllTspPlanSms.Get_Lgfx(dt_Start.Text.Trim(), dt_End.Text.Trim()).Tables[0];

                gc_Lgfx.DataSource = dt;

                gv_Lgfx.Columns["计划炉数完成率"].Caption = "计划炉数完成率(%)";
                gv_Lgfx.Columns["计划量完成率"].Caption = "计划量完成率(%)";
                gv_Lgfx.Columns["实际炉数完成率"].Caption = "实际炉数完成率(%)";
                gv_Lgfx.Columns["实际量完成率"].Caption = "实际量完成率(%)";

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
            OutToExcel.ToExcel(gc_Lgfx, "炼钢计划完成率统计-" + System.DateTime.Now.ToString("yyyyMMddhhmmss"));
        }
    }
}
