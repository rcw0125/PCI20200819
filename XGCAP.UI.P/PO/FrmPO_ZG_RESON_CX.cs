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

namespace XGCAP.UI.P.PO
{
    public partial class FrmPO_ZG_RESON_CX : Form
    {
        private Bll_TRP_PLAN_REASON bllTrpPlanReason = new Bll_TRP_PLAN_REASON();

        public FrmPO_ZG_RESON_CX()
        {
            InitializeComponent();
        }

        private void FrmPO_ZG_RESON_CX_Load(object sender, EventArgs e)
        {
            dt_Start.EditValue = DateTime.Now.AddDays(-1).ToString("yyyy-MM-dd") + DateTime.Now.ToString(" 00:00:00");
            dt_End.EditValue = DateTime.Now.ToString("yyyy-MM-dd") + DateTime.Now.ToString(" 23:59:59");
        }

        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_query_zg_Click(object sender, EventArgs e)
        {
            BindInfo();
        }

        private void BindInfo()
        {
            try
            {
                WaitingFrom.ShowWait("");

                DataTable dt = bllTrpPlanReason.Get_List(dt_Start.Text.Trim(),dt_End.Text.Trim(),txt_Grd.Text.Trim(),txt_Std.Text.Trim(),txt_Spec.Text.Trim()).Tables[0];

                gc_Log.DataSource = dt;
                SetGridViewRowNum.SetRowNum(gv_Log);

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
            OutToExcel.ToExcel(gc_Log, "线材计划不生产原因-" + System.DateTime.Now.ToString("yyyyMMddhhmmss"));
        }
    }
}
