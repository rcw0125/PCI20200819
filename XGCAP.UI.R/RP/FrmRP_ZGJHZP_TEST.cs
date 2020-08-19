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

namespace XGCAP.UI.R.RP
{
    public partial class FrmRP_ZGJHZP_TEST : Form
    {
        public FrmRP_ZGJHZP_TEST()
        {
            InitializeComponent();
        }

        Bll_TRP_PLAN_ROLL bll_TRP_PLAN_ROLL = new Bll_TRP_PLAN_ROLL();
        private Bll_TPP_ZG_PLAN bllTppZgPlan = new Bll_TPP_ZG_PLAN();
        Bll_TRC_ROLL_MAIN bll_TRC_ROLL_MAIN = new Bll_TRC_ROLL_MAIN();

        private void btn_AssePlanQuery_Click(object sender, EventArgs e)
        {
            string whereSql = " TPR.N_STATUS = 9 ";
            DataTable dt = bll_TRP_PLAN_ROLL.GetList(whereSql).Tables[0];
            this.gc_ZGZPJH.DataSource = dt;
            this.gv_ZGZPJH.OptionsView.ColumnAutoWidth = false;
            SetGridViewRowNum.SetRowNum(gv_ZGZPJH);
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            if (DialogResult.No == MessageBox.Show("确认关闭计划吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
            {
                return;
            }

            string planRemark = txt_planRemark.Text.Trim();
            if (planRemark == "")
            {
                MessageBox.Show("关闭计划请填写备注");
                return;
            }

            int selectedPlanHandle = this.gv_ZGZPJH.FocusedRowHandle;//获取计划焦点行索引
            if (selectedPlanHandle < 0)
            {
                MessageBox.Show("请检查计划记录!");
                return;
            }
            string planID = this.gv_ZGZPJH.GetRowCellValue(selectedPlanHandle, "C_ID").ToString();//获取焦点主键
            string orderNo = this.gv_ZGZPJH.GetRowCellValue(selectedPlanHandle, "C_ORDER_NO").ToString();//获取焦点订单号
            string wgt = this.gv_ZGZPJH.GetRowCellValue(selectedPlanHandle, "N_GROUP_WGT").ToString();//获取焦点组批量


            string result = bll_TRC_ROLL_MAIN.ClosePlans(planID, orderNo, planRemark, RV.UI.UserInfo.UserID, RV.UI.UserInfo.UserName);
            if (result == "1")
            {
                MessageBox.Show("操作成功");
                btn_AssePlanQuery_Click(null, null);
            }
            else
            {
                MessageBox.Show("操作失败");
            }
        }
    }
}
