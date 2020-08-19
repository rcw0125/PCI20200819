using Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLL;

namespace XGCAP.UI.P.PO.APS
{
    public partial class FrmPO_APS_Order_ZGFX : Form
    {
        public FrmPO_APS_Order_ZGFX()
        {
            InitializeComponent();
        }
        private Bll_TRP_PLAN_ROLL bll_plan = new Bll_TRP_PLAN_ROLL();
        private Bll_TSP_PLAN_SMS bll_lg_plan = new Bll_TSP_PLAN_SMS();
        private Bll_TPP_ZG_PLAN bllTppZgPlan = new Bll_TPP_ZG_PLAN();

        private Bll_TRP_PLAN_ROLL_TEST bll_plan_test = new Bll_TRP_PLAN_ROLL_TEST();
        private Bll_TPP_ZG_PLAN_TEST bllTppZgPlanTest = new Bll_TPP_ZG_PLAN_TEST();
        private Bll_TRP_PLAN_ITEM bllTrpPlanItem = new Bll_TRP_PLAN_ITEM();

        private void rbtn_sfqr_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rbtn_sfqr.SelectedIndex == 1)
            {
                this.chk_wwc.Checked = true;
                this.chk_wwc.Enabled = false;
            }

            else
            {
                this.chk_wwc.Checked = true;
                this.chk_wwc.Enabled = true;
            }
        }

        private void FrmPO_APS_Order_ZGFX_Load(object sender, EventArgs e)
        {
            UserButtonRight.GetBtnFun(this, RV.UI.UserInfo.menuID);
            this.chk_wwc.Checked = true;
            this.chk_wwc.Enabled = false;
            CommonSub.BindIcbo("", "ZX", icbo_zx);
            CommonSub.BindIcbo("", "ZX", icbo_line1, "Y");
            CommonSub.BindIcbo("", "ZX", icbo_line2);
            CommonSub.BindIcbo("", "ZX", icbo_line3, "Y");
            CommonSub.BindIcbo("", "ZX", icbo_line4);
            icbo_line1.SelectedIndex = 0;
            dtp_form1.Text = System.DateTime.Now.AddDays(-10).ToString("yyyy-MM-dd");
            this.dtp_end1.Text = System.DateTime.Now.AddDays(1).ToString("yyyy-MM-dd");
        }

        /// <summary>
        /// 查询轧钢计划
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_query_order_Click(object sender, EventArgs e)
        {
            BindPlan();
        }

        private void BindPlan()
        {
            try
            {
                WaitingFrom.ShowWait("订单正在加载，请稍后...");

                double? gg_min = null;//规格最小值
                if (this.txt_gg_min.Text.Trim() != "")
                {
                    gg_min = Convert.ToDouble(this.txt_gg_min.Text.Trim());
                }
                double? gg_max = null;//规格最大值
                if (this.txt_gg_max.Text.Trim() != "" && Convert.ToDouble(this.txt_gg_max.Text.Trim()) > 0)
                {
                    gg_max = Convert.ToDouble(this.txt_gg_max.Text.Trim());
                }
                string strJQMin = "";
                string strJQMax = "";
                string strDDMin = "";
                string strDDMax = "";
                if (cbo_date_type.Text == "交货日期")
                {
                    strJQMin = this.dtp_form1.EditValue == null ? "" : this.dtp_form1.EditValue.ToString();
                    strJQMax = this.dtp_end1.EditValue == null ? "" : this.dtp_end1.EditValue.ToString();
                    strDDMin = "";
                    strDDMax = "";
                }
                else
                {
                    strJQMin = "";
                    strJQMax = "";
                    strDDMin = this.dtp_form1.EditValue == null ? "" : this.dtp_form1.EditValue.ToString();
                    strDDMax = this.dtp_end1.EditValue == null ? "" : this.dtp_end1.EditValue.ToString();
                }
                int? sfpc = 0;
                if (rbtn_sfqr.SelectedIndex == 0)
                {
                    sfpc = 0;
                }
                else if (rbtn_sfqr.SelectedIndex == 1)
                {
                    sfpc = 1;
                }
                else
                {
                    sfpc = null;
                }

                string strZX = "";
                if (icbo_zx.SelectedIndex > 0)
                {
                    strZX = icbo_zx.Properties.Items[this.icbo_zx.SelectedIndex].Value.ToString();
                }


                DataTable dtOrder = bll_plan.GetZGPlan(strZX, sfpc, "", this.txt_gz1.Text.Trim(), this.txt_zxbz1.Text.Trim(), gg_min, gg_max, "", strJQMin, strJQMax, strJQMin, strJQMax).Tables[0];

                //DataTable dtOrder = bll_plan_test.GetZGPlan(strZX, sfpc, "", this.txt_gz1.Text.Trim(), this.txt_zxbz1.Text.Trim(), gg_min, gg_max, "", strJQMin, strJQMax, strJQMin, strJQMax).Tables[0];

                this.gc_zg_plan.DataSource = dtOrder;
                this.gv_zg_plan.OptionsView.ColumnAutoWidth = false;
                this.gv_zg_plan.OptionsSelection.MultiSelect = true;
                //gv_zg_plan.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
                SetGridViewRowNum.SetRowNum(gv_zg_plan);
                this.gv_zg_plan.BestFitColumns();

                WaitingFrom.CloseWait();
            }
            catch
            {

            }
        }

        private void btn_auto_fcx_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("是否确认将所有未排产的轧钢计划重新分配产线？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
            {
                WaitingFrom.ShowWait("系统正对轧钢计划进行产线重新分配，请稍候...");
                string res = bll_plan.GetLine();
                if (res != "成功")
                {
                    MessageBox.Show("系统自动分配轧线失败，请重新确认！");
                    WaitingFrom.CloseWait();
                    return;
                }
                MessageBox.Show("系统已对可分配产线计划重新划分产线，请核对！");

                btn_query_order_Click(null, null);
                WaitingFrom.CloseWait();
            }
        }


        private void btn_cn_wh_Click(object sender, EventArgs e)
        {
            FrmPO_APS_ZGJSCN frm = new FrmPO_APS_ZGJSCN();
            frm.ShowDialog();
        }



        /// <summary>
        /// 导出订单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_out_Click(object sender, EventArgs e)
        {
            OutToExcel.ToExcel(this.gc_zg_plan, "线材订单-" + System.DateTime.Now.ToString("yyyyMMddhhmmss"));
        }

        /// <summary>
        /// 自动排产
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_rf_order_Click(object sender, EventArgs e)
        {
            WaitingFrom.ShowWait("正在生成轧钢计划，请稍后...");

            string result = bllTppZgPlan.Update_ZG_Plan_New("0", "", "", "", "", "");
            //string result = bllTppZgPlanTest.Update_ZG_Plan_New("0", "", "", "", "", "");

            WaitingFrom.CloseWait();

            if (result == "成功")
            {
                MessageBox.Show("自动排产成功！");
            }
            else
            {
                MessageBox.Show(result);
                return;
            }
        }

        private void btn_query_byline_Click(object sender, EventArgs e)
        {
            string C_STA_ID = "";
            if (this.icbo_line1.SelectedIndex >= 0)
            {
                C_STA_ID = this.icbo_line1.Properties.Items[this.icbo_line1.SelectedIndex].Value.ToString();
            }
            string C_SPEC = this.txt_gg1.Text.Trim();
            WaitingFrom.ShowWait("订单数据正在加载，请稍候...");
            DataTable dt = bll_plan.GetNJSCN(C_STA_ID, C_SPEC);
            this.gridControl1.DataSource = dt;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsSelection.MultiSelect = true;
            gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            SetGridViewRowNum.SetRowNum(gridView1);
            this.gridView1.BestFitColumns();
            WaitingFrom.CloseWait();
        }

        private void btn_change_line_Click(object sender, EventArgs e)
        {

            if (this.icbo_line2.SelectedIndex <= 0)
            {
                MessageBox.Show("请选择要分配的产线！");
                icbo_line2.Focus();
                return;
            }
            WaitingFrom.ShowWait("系统正对轧钢计划进行产线重新分配，请稍候...");
            string strlineid = icbo_line2.Properties.Items[this.icbo_line2.SelectedIndex].Value.ToString();
            int[] aa = this.gridView1.GetSelectedRows();
            int cou = 0;
            for (int i = 0; i < aa.Length; i++)
            {
                int selectedHandle = aa[i];
                string strGZ = this.gridView1.GetRowCellValue(selectedHandle, "C_STL_GRD").ToString();
                string strGG = this.gridView1.GetRowCellValue(selectedHandle, "C_SPEC").ToString();
                string strBZ = this.gridView1.GetRowCellValue(selectedHandle, "C_STD_CODE").ToString();
                int a = Convert.ToInt32(bll_plan.ChangeLineByplan(strGZ, strGG, strBZ, strlineid));
                cou = cou + a;
            }
            MessageBox.Show("产线划分成功！");
            btn_query_order_Click(null, null);
            btn_query_byline_Click(null, null);
            WaitingFrom.CloseWait();
        }
        /// <summary>
        /// 机时产能
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_save_cap_Click(object sender, EventArgs e)
        {
            if (Convert.ToDecimal(this.txt_jscn.Text) <= 0)
            {
                MessageBox.Show("请输入正确的机时产能！");
                return;
            }
            WaitingFrom.ShowWait("系统正对轧钢计划进行产线重新分配，请稍候...");
            int[] aa = this.gridView1.GetSelectedRows();
            int cou = 0;
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

            for (int i = 0; i < aa.Length; i++)
            {
                int selectedHandle = aa[i];
                string P_LINT_ID = this.gridView1.GetRowCellValue(selectedHandle, "C_STA_ID").ToString();
                string P_STL_GRD = this.gridView1.GetRowCellValue(selectedHandle, "C_STL_GRD").ToString();
                string P_SPEC = this.gridView1.GetRowCellValue(selectedHandle, "C_SPEC").ToString();
                // decimal P_MACH_WGT = Convert.ToDecimal(this.gridView1.GetRowCellValue(selectedHandle, "N_MACH_WGT").ToString());
                decimal P_MACH_WGT = Convert.ToDecimal(this.txt_jscn.Text);
                int res = Convert.ToInt32(bll_plan.UpdatePlanJSCN(P_LINT_ID, P_STL_GRD, P_SPEC, P_MACH_WGT, P_SFGX));
                cou = cou + res;
            }
            MessageBox.Show("机时产能数据保存成功！");
            btn_query_order_Click(null, null);
            btn_query_byline_Click(null, null);
            WaitingFrom.CloseWait();
        }

        private void btn_out_toExcel1_Click(object sender, EventArgs e)
        {
            OutToExcel.ToExcel(this.gridControl1, "线材产线规格统计-" + System.DateTime.Now.ToString("yyyyMMddhhmmss"));
        }

        private void btn_query_fx3_Click(object sender, EventArgs e)
        {

            string C_STA_ID = "";
            if (this.icbo_line3.SelectedIndex >= 0)
            {
                C_STA_ID = this.icbo_line3.Properties.Items[this.icbo_line3.SelectedIndex].Value.ToString();
            }
            string C_SPEC = this.txt_gg2.Text.Trim();
            WaitingFrom.ShowWait("订单数据正在加载，请稍候...");
            DataTable dt = bll_plan.GetWgtByLineAndGG(C_STA_ID, C_SPEC);
            this.gridControl3.DataSource = dt;
            this.gridView4.OptionsView.ColumnAutoWidth = false;
            //this.gridView2.OptionsSelection.MultiSelect = true;
            //gridView2.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            SetGridViewRowNum.SetRowNum(gridView4);
            this.gridView4.BestFitColumns();
            WaitingFrom.CloseWait();

        }

        private void btn_out_toExcle2_Click(object sender, EventArgs e)
        {
            OutToExcel.ToExcel(this.gridControl3, "产线规格产能统计-" + System.DateTime.Now.ToString("yyyyMMddhhmmss"));
        }

        private void btn_query_fx4_Click(object sender, EventArgs e)
        {
            string C_STL_GRD = this.txt_GZ.Text.Trim();
            string C_STD_CODE = txt_BZ3.Text.Trim();
            WaitingFrom.ShowWait("订单数据正在加载，请稍候...");
            DataTable dt = bll_lg_plan.GetKZ_Slab_Calendar(C_STL_GRD, C_STD_CODE);
            this.gridControl4.DataSource = dt;
            this.gridView5.OptionsView.ColumnAutoWidth = false;
            //this.gridView2.OptionsSelection.MultiSelect = true;
            //gridView2.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            SetGridViewRowNum.SetRowNum(gridView5);
            this.gridView5.BestFitColumns();
            WaitingFrom.CloseWait();

        }

        private void btn_out_toExcle3_Click(object sender, EventArgs e)
        {
            OutToExcel.ToExcel(this.gridControl4, "钢坯可轧计划履历-" + System.DateTime.Now.ToString("yyyyMMddhhmmss"));
        }


        private void btn_query_line_Click(object sender, EventArgs e)
        {
            WaitingFrom.ShowWait("订单数据正在加载，请稍候...");
            DataTable dt = bll_plan.GetWgtByLine("");
            this.gridControl5.DataSource = dt;
            this.gridView6.OptionsView.ColumnAutoWidth = false;
            SetGridViewRowNum.SetRowNum(gridView6);
            this.gridView6.BestFitColumns();
            WaitingFrom.CloseWait();
        }

        private void btn_out_toExcle4_Click(object sender, EventArgs e)
        {
            OutToExcel.ToExcel(this.gridControl5, "产线计划量统计-" + System.DateTime.Now.ToString("yyyyMMddhhmmss"));
        }

        private void btn_query_bylineGZ_Click(object sender, EventArgs e)
        {
            string C_STA_ID = "";
            if (this.icbo_line4.SelectedIndex >= 0)
            {
                C_STA_ID = this.icbo_line4.Properties.Items[this.icbo_line4.SelectedIndex].Value.ToString();
            }
            WaitingFrom.ShowWait("订单数据正在加载，请稍候...");
            DataTable dt = bll_plan.GetLineGZ(C_STA_ID);
            this.gridControl6.DataSource = dt;
            this.gridView7.OptionsView.ColumnAutoWidth = false;

            SetGridViewRowNum.SetRowNum(gridView7);
            this.gridView7.BestFitColumns();
            WaitingFrom.CloseWait();
        }

        private void btn_out_toExcle5_Click(object sender, EventArgs e)
        {
            OutToExcel.ToExcel(this.gridControl6, "产线钢种计划量统计-" + System.DateTime.Now.ToString("yyyyMMddhhmmss"));
        }

        /// <summary>
        /// 指定排产
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Reset_Plan_Click(object sender, EventArgs e)
        {
            DataRow dr = gv_zg_plan.GetDataRow(gv_zg_plan.FocusedRowHandle);

            if (dr != null)
            {
                string strLineID = "";
                if (icbo_zx.SelectedIndex > 0)
                {
                    strLineID = icbo_zx.Properties.Items[this.icbo_zx.SelectedIndex].Value.ToString();
                }

                if (string.IsNullOrEmpty(strLineID))
                {
                    MessageBox.Show("请选择需要下发的轧线！");
                    return;
                }

                string strType = "1";
                string strGZ = dr["C_STL_GRD"].ToString();
                string strBZ = dr["C_STD_CODE"].ToString();
                string strGG = dr["C_SPEC"].ToString();
                string strPlanID = dr["C_ID"].ToString();

                if (DialogResult.No == MessageBox.Show("确认先生产：钢种" + strGZ + "标准" + strBZ + "规格" + strGG + "的计划？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
                {
                    return;
                }

                WaitingFrom.ShowWait("正在生成轧钢计划，请稍后...");

                string result = bllTppZgPlan.Update_ZG_Plan_New(strType, strLineID, strGZ, strBZ, strGG, strPlanID);

                if (result == "成功")
                {
                    MessageBox.Show("计划生成成功！");
                }
                else
                {
                    MessageBox.Show(result);
                    return;
                }

                WaitingFrom.CloseWait();
            }
            else
            {
                MessageBox.Show("请选择需要指定的下发计划！");
                return;
            }
        }

        private void gv_zg_plan_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                DataRow dr = gv_zg_plan.GetDataRow(e.FocusedRowHandle);

                if (dr != null)
                {
                    BindItem(dr["C_ID"].ToString());
                }
            }
            catch
            {

            }
        }

        private void BindItem(string strID)
        {
            DataTable dt = bllTrpPlanItem.Get_Item_List(strID).Tables[0];

            gc_Item.DataSource = dt;

            SetGridViewRowNum.SetRowNum(gv_Item);
        }
    }
}
