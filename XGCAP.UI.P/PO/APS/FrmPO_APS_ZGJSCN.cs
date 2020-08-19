using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLL;
using Common;

namespace XGCAP.UI.P.PO.APS
{
    public partial class FrmPO_APS_ZGJSCN : Form
    {
        public FrmPO_APS_ZGJSCN()
        {
            InitializeComponent();
        }
        private Bll_TPC_PLAN_ROLL bll_plan = new Bll_TPC_PLAN_ROLL();

        private void FrmPO_APS_ZGJSCN_Load(object sender, EventArgs e)
        {
            UserButtonRight.GetBtnFun(this, RV.UI.UserInfo.menuID);
            WaitingFrom.ShowWait("数据正在加载，请稍候...");
            DataTable dt = bll_plan.GetNJSCN();
            this.gridControl1.DataSource = dt;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            SetGridViewRowNum.SetRowNum(gridView1);
            this.gridView1.BestFitColumns();
            WaitingFrom.CloseWait();
        }

        private void btn_plan_xf_Click(object sender, EventArgs e)
        {
            string P_SFGX = "N";
            int a = this.gridView1.RowCount;
            if (a == 0)
            {
                MessageBox.Show("没有可维护的数据！");
                return;

            }
            if (DialogResult.Yes == MessageBox.Show("是否将数据同步到机时产能基础数据？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
            {
                P_SFGX = "Y";
            }
            WaitingFrom.ShowWait("数据正在维护，请稍候...");
            for (int i = 0; i < a; i++)
            {
                string P_LINT_ID = this.gridView1.GetRowCellValue(i, "C_STA_ID").ToString();
                string P_STL_GRD = this.gridView1.GetRowCellValue(i, "C_STL_GRD").ToString();
                string P_SPEC = this.gridView1.GetRowCellValue(i, "C_SPEC").ToString();
                decimal P_MACH_WGT = Convert.ToDecimal(this.gridView1.GetRowCellValue(i, "N_MACH_WGT").ToString());
                int res = Convert.ToInt32(bll_plan.UpdatePlanJSCN(P_LINT_ID, P_STL_GRD, P_SPEC, P_MACH_WGT, P_SFGX));
            }
            WaitingFrom.CloseWait();
        }
    }
}
