using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLL;
using MODEL;
using Common;

namespace XGCAP.UI.P.PP
{
    public partial class FrmPP_LCJH_BACK : Form
    {
        public FrmPP_LCJH_BACK()
        {
            InitializeComponent();
        }
        private Bll_TSP_PLAN_SMS bllTspPlanSms = new Bll_TSP_PLAN_SMS();
        private Bll_TPP_CAST_PLAN bllTppCastPlan = new Bll_TPP_CAST_PLAN();
        private Bll_TPP_LG_PLAN bllTppLgPlan = new Bll_TPP_LG_PLAN();

        private void FrmPP_LCJH_BACK_Load(object sender, EventArgs e)
        {
            UserButtonRight.GetBtnFun(this, RV.UI.UserInfo.menuID);

            dt_Plan_Start.EditValue = DateTime.Now.AddDays(-1).ToString("yyyy-MM-dd") + DateTime.Now.ToString(" 00:00:00");
            dt_Plan_End.EditValue = DateTime.Now.ToString("yyyy-MM-dd") + DateTime.Now.ToString(" 23:59:59");

            CommonSub.BindIcbo("", "CC", icbo_CC_WXF);
            CommonSub.BindIcbo("", "CC", icbo_CC_YXF);

        }

        private void btn_query_Click(object sender, EventArgs e)
        {
            BindWXF();
        }

        private void BindWXF()
        {
            if (string.IsNullOrEmpty(icbo_CC_WXF.Text.ToString()))
            {
                MessageBox.Show("请选择需要查看的连铸！");
                return;
            }

            WaitingFrom.ShowWait("");

            DataTable dt = bllTspPlanSms.Get_Stove_JH_ITEM(icbo_CC_WXF.EditValue.ToString(), "", "0", "", "");

            this.gc_WXF.DataSource = dt;
            SetGridViewRowNum.SetRowNum(gv_WXF);

            WaitingFrom.CloseWait();
        }

        private void btn_YXF_Click(object sender, EventArgs e)
        {
            BindYXF();
        }

        private void BindYXF()
        {
            if (string.IsNullOrEmpty(icbo_CC_YXF.Text.ToString()))
            {
                MessageBox.Show("请选择需要查看的连铸！");
                return;
            }

            WaitingFrom.ShowWait("");

            DataTable dt = bllTspPlanSms.Get_Stove_JH_ITEM(icbo_CC_YXF.EditValue.ToString(), "", "1", dt_Plan_Start.Text.Trim(), dt_Plan_End.Text.Trim());

            this.gc_YXF.DataSource = dt;
            SetGridViewRowNum.SetRowNum(gv_YXF);

            WaitingFrom.CloseWait();
        }

        /// <summary>
        /// 撤销未下发的计划
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Back_WXF_Click(object sender, EventArgs e)
        {
            DataRow dr = gv_WXF.GetDataRow(gv_WXF.FocusedRowHandle);

            if (DialogResult.No == MessageBox.Show("确认撤销选中的计划及之后的计划吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
            {
                return;
            }

            int count = bllTppCastPlan.Get_Plan_State(dr["C_ID"].ToString());
            if (count > 0)
            {
                MessageBox.Show("选中的计划已下发，不能撤销");
                return;
            }
            else
            {
                //string a = bllTppLgPlan.Back_WXF(icbo_CC_WXF.EditValue.ToString(), Convert.ToInt32(dr["N_SORT"].ToString()));
                //if (a == "1")
                //{
                //    MessageBox.Show("撤销成功！");
                //    BindWXF();
                //}
                //else
                //{
                //    MessageBox.Show("撤销失败！");
                //    return;
                //}
            }
        }

        /// <summary>
        /// 撤销已下发的计划
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Back_YXF_Click(object sender, EventArgs e)
        {
            DataRow dr = gv_YXF.GetDataRow(gv_YXF.FocusedRowHandle);

            if (dr == null)
            {
                MessageBox.Show("请选择需要撤销的数据！");
                return;
            }

            if (DialogResult.No == MessageBox.Show("确认撤销炉号：" + dr["炉号"].ToString() + "及之后的计划吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
            {
                return;
            }

            int count = bllTppCastPlan.Get_Stove_State(dr["炉号"].ToString());

            if (count > 0)
            {
                MessageBox.Show("炉号：" + dr["炉号"].ToString() + "的计划已执行，不能撤销");
                return;
            }
            else
            {
                string a = bllTppLgPlan.Back_YXF(icbo_CC_YXF.EditValue.ToString(), dr["炉号"].ToString());
                if (a == "1")
                {
                    MessageBox.Show("撤销成功！");
                    BindYXF();
                }
                else
                {
                    MessageBox.Show("撤销失败！");
                    return;
                }
            }
        }
    }
}
