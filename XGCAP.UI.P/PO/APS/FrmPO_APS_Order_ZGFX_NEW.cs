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
using DevExpress.XtraEditors.Controls;

namespace XGCAP.UI.P.PO.APS
{
    public partial class FrmPO_APS_Order_ZGFX_NEW : Form
    {
        private Bll_TRP_PLAN_ROLL bllTrpPlanRoll = new Bll_TRP_PLAN_ROLL();
        private Bll_TPP_ZG_PLAN bllTppZgPlan = new Bll_TPP_ZG_PLAN();
        private Bll_TRP_PLAN_ROLL_ITEM bllTrpPlanRollItem = new Bll_TRP_PLAN_ROLL_ITEM();
        private Bll_TSP_CAST_PLAN bll_cast_plan = new Bll_TSP_CAST_PLAN();
        private Bll_TSC_SLAB_MAIN bll_slab_main = new Bll_TSC_SLAB_MAIN();
        private Bll_TPB_CHANGESPEC_TIME bll_changegg = new Bll_TPB_CHANGESPEC_TIME();
        private Bll_TRP_PLAN_ITEM bllTrpPlanItem = new Bll_TRP_PLAN_ITEM();

        private Bll_TRP_PLAN_ROLL_TEST bllTrpPlanRollTest = new Bll_TRP_PLAN_ROLL_TEST();

        private Bll_TPP_ZG_PLAN_TEST bllTppZgPlanTest = new Bll_TPP_ZG_PLAN_TEST();

        private List<Mod_TRP_PLAN_ROLL_ITEM> lst = null;

        private string strMenuName;

        public FrmPO_APS_Order_ZGFX_NEW()
        {
            InitializeComponent();
        }

        private void FrmPO_APS_Order_ZGFX_NEW_Load(object sender, EventArgs e)
        {
            try
            {
                UserButtonRight.GetBtnFun(this, RV.UI.UserInfo.menuID);

                strMenuName = RV.UI.UserInfo.menuName;

                CommonSub.BindIcbo("", "ZX", icbo_ZX_WXF);

                BindSpec();//加载线材计划查询的规格


                CommonSub.BindIcboNoAll("", "CC", icbo_lz3);
            }
            catch
            {

            }
            gv_PDJG.CustomColumnDisplayText += Gv_PDJG_CustomColumnDisplayText;


        }


        /// <summary>
        /// 加载线材计划查询的规格
        /// </summary>
        public void BindSpec()
        {
            DataTable dt = bllTrpPlanRoll.Get_Spec().Tables[0];
            this.txt_Spec.Properties.Items.Clear();

            CheckedListBoxItem[] itemListQuery = new CheckedListBoxItem[dt.Rows.Count];

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                itemListQuery[i] = new CheckedListBoxItem(dt.Rows[i]["C_SPEC"].ToString(), dt.Rows[i]["C_SPEC"].ToString());
            }
            this.txt_Spec.Properties.Items.AddRange(itemListQuery);
        }

        private void Gv_PDJG_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "C_MOVE_TYPE")
            {
                switch (e.DisplayText)
                {
                    case "S":
                        e.DisplayText = "已销售";
                        break;
                    case "N":
                        e.DisplayText = "待入库";
                        break;
                    case "DZ":
                        e.DisplayText = "待轧";
                        break;
                    case "NP":
                        e.DisplayText = "待开坯";
                        break;
                    case "R":
                        e.DisplayText = "入炉";
                        break;
                    case "C":
                        e.DisplayText = "出炉";
                        break;
                    case "EX":
                        e.DisplayText = "消耗";
                        break;
                    case "M":
                        e.DisplayText = "调拨中";
                        break;
                    case "E":
                        e.DisplayText = "入库";
                        break;
                    case "DX":
                        e.DisplayText = "待修磨";
                        break;
                    case "0":
                        e.DisplayText = "销售占用";
                        break;
                    case "1":
                        e.DisplayText = "销售实绩";
                        break;
                }
            }
        }


        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_query_zg_Click(object sender, EventArgs e)
        {
            BindPlan();
        }

        private void Gv_Plan_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            try
            {
                int hand = e.RowHandle;
                if (hand < 0) return;
                if (Convert.ToDecimal(gv_Plan.GetRowCellValue(hand, "N_COU").ToString()) > 0)
                {
                    e.Appearance.BackColor = Color.Yellow;// 改变行背景颜色
                }

                if (gv_Plan.GetRowCellValue(hand, "C_XM_YQ").ToString().Trim() != "")
                {
                    e.Appearance.ForeColor = Color.Red;// 改变行字体颜色
                }
            }
            catch (Exception ex)
            {

            }
        }



        /// <summary>
        /// 查询未下发的计划
        /// </summary>
        private void BindPlan()
        {
            try
            {
                WaitingFrom.ShowWait("");

                gc_Plan.DataSource = null;

                string strLineID = "";
                if (this.icbo_ZX_WXF.SelectedIndex > 0)
                {
                    strLineID = icbo_ZX_WXF.Properties.Items[this.icbo_ZX_WXF.SelectedIndex].Value.ToString();
                }


                DataTable dt = bllTrpPlanRoll.Get_Plan_WXF(strLineID, txt_gz_wxf.Text.Trim(), txt_bz_wxf.Text.Trim(), "9", txt_Spec.Text.Trim(), radioGroup1.SelectedIndex, txt_order_no.Text).Tables[0];

                //DataTable dt = bllTrpPlanRoll.Get_Plan_WXF_Test(strLineID, txt_gz_wxf.Text.Trim(), txt_bz_wxf.Text.Trim(), rbtn_state_Plan.SelectedIndex.ToString(), txt_Spec.Text.Trim(), radioGroup1.SelectedIndex, txt_order_no.Text).Tables[0];

                this.gc_Plan.DataSource = dt;
                this.gv_Plan.OptionsView.ColumnAutoWidth = false;
                this.gv_Plan.OptionsSelection.MultiSelect = true;

                SetGridViewRowNum.SetRowNum(gv_Plan);

                BindPlanGroup(strLineID);

                WaitingFrom.CloseWait();
            }
            catch
            {

            }
        }

        /// <summary>
        /// 轧钢计划汇总类
        /// </summary>
        class GroupZg
        {
            /// <summary>
            /// 可轧量
            /// </summary>
            public decimal? N_ROLL_PROD_WGT { get; set; }

            /// <summary>
            /// 轧线描述
            /// </summary>
            public string C_LINE_DESC { get; set; }

            /// <summary>
            /// 轧线代码
            /// </summary>
            public string C_LINE_CODE { get; set; }

            /// <summary>
            /// 规格
            /// </summary>
            public string C_SPEC { get; set; }

            /// <summary>
            /// 计划开始时间
            /// </summary>
            public DateTime? D_P_START_TIME { get; set; }

            /// <summary>
            /// 计划结束时间
            /// </summary>
            public DateTime? D_P_END_TIME { get; set; }

            /// <summary>
            /// 订单号集合
            /// </summary>
            public string C_ORDER_NO { get; set; }
        }

        private void BindPlanGroup(string strLineID)
        {
            DataTable dt_ZX = bllTrpPlanItem.Get_ZX_List(strLineID).Tables[0];

            if (dt_ZX.Rows.Count > 0)
            {
                DataTable dt_Plan = bllTrpPlanItem.Get_Plan_Item_List(strLineID).Tables[0];

                List<Mod_TRP_PLAN_ITEM> lst = bllTrpPlanItem.DataTableToList(dt_Plan);

                List<GroupZg> lstResult = new List<GroupZg>();

                for (int i = 0; i < dt_ZX.Rows.Count; i++)
                {
                    var lstTemp = lst.Where(x => x.C_LINE_CODE == dt_ZX.Rows[i]["C_LINE_CODE"].ToString()).ToList();

                    for (int iTemp = 0; iTemp < lstTemp.Count; iTemp++)
                    {
                        if (lstResult.Count == 0)
                        {
                            GroupZg gz = new GroupZg();
                            gz.C_LINE_DESC = lstTemp[iTemp].C_LINE_DESC;
                            gz.C_LINE_CODE = lstTemp[iTemp].C_LINE_CODE;
                            gz.D_P_START_TIME = lstTemp[iTemp].D_P_START_TIME;
                            gz.D_P_END_TIME = lstTemp[iTemp].D_P_END_TIME;
                            gz.N_ROLL_PROD_WGT = lstTemp[iTemp].N_ROLL_PROD_WGT;
                            gz.C_SPEC = lstTemp[iTemp].C_SPEC;
                            gz.C_ORDER_NO = lstTemp[iTemp].C_ORDER_NO;

                            lstResult.Add(gz);

                            continue;
                        }

                        int num = 0;

                        for (int iResult = 0; iResult < lstResult.Count; iResult++)
                        {
                            if (lstTemp[iTemp].C_SPEC == lstResult[iResult].C_SPEC && lstTemp[iTemp].D_P_START_TIME == lstResult[iResult].D_P_END_TIME && lstTemp[iTemp].C_LINE_CODE == lstResult[iResult].C_LINE_CODE)
                            {
                                lstResult[iResult].D_P_END_TIME = lstTemp[iTemp].D_P_END_TIME;
                                lstResult[iResult].N_ROLL_PROD_WGT = lstResult[iResult].N_ROLL_PROD_WGT + lstTemp[iTemp].N_ROLL_PROD_WGT;

                                lstResult[iResult].C_ORDER_NO = lstResult[iResult].C_ORDER_NO + "," + lstTemp[iTemp].C_ORDER_NO;

                                num++;

                                break;
                            }
                        }

                        if (num == 0)
                        {
                            GroupZg gz = new GroupZg();
                            gz.C_LINE_DESC = lstTemp[iTemp].C_LINE_DESC;
                            gz.C_LINE_CODE = lstTemp[iTemp].C_LINE_CODE;
                            gz.D_P_START_TIME = lstTemp[iTemp].D_P_START_TIME;
                            gz.D_P_END_TIME = lstTemp[iTemp].D_P_END_TIME;
                            gz.N_ROLL_PROD_WGT = lstTemp[iTemp].N_ROLL_PROD_WGT;
                            gz.C_SPEC = lstTemp[iTemp].C_SPEC;
                            gz.C_ORDER_NO = lstTemp[iTemp].C_ORDER_NO;

                            lstResult.Add(gz);

                            continue;
                        }
                    }
                }

                gc_Group.DataSource = lstResult;
                SetGridViewRowNum.SetRowNum(gv_Group);
            }
            else
            {
                gc_Group.DataSource = null;
            }
        }


        /// <summary>
        /// 保存排序修改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_save_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lst.Count; i++)
            {
                bllTrpPlanRollItem.Update(lst[i].C_ID, (DateTime)lst[i].D_P_START_TIME, (DateTime)lst[i].D_P_END_TIME, (int)lst[i].N_SORT);
            }

        }


        private void btn_out1_Click(object sender, EventArgs e)
        {
            OutToExcel.ToExcel(this.gc_Plan);
        }


        private void btn_AssePlanQuery_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_Grd.Text))
            {
                MessageBox.Show("请选输入钢种进行查询!");
                return;
            }
            DataTable dt = bll_slab_main.GetKZgp("", "", txt_Grd.Text, txt_Std.Text);
            // DataTable dt = bllTrpPlanRoll.GetSlabInventory(txt_Grd.Text, txt_Spec.Text, txt_Std.Text);
            this.gc_PDJG.DataSource = dt;
            this.gv_PDJG.OptionsView.ColumnAutoWidth = false;
            this.gv_PDJG.OptionsSelection.MultiSelect = true;
            SetGridViewRowNum.SetRowNum(gv_Plan);
            this.gv_PDJG.OptionsView.ColumnAutoWidth = false;
            this.gv_PDJG.BestFitColumns();
        }
        

        private void btn_cancle_pc_Click(object sender, EventArgs e)
        {

            DataRow dr = gv_Plan.GetDataRow(gv_Plan.FocusedRowHandle);
            if (dr != null)
            {
                if (DialogResult.No == MessageBox.Show("是否确认撤回选中的计划？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
                {
                    return;
                }
                bool result = Cls_APS_PC.CancleZGPlan(dr["C_ID"].ToString());
                if (result)
                {
                    MessageBox.Show("计划成功撤回！");
                    BindPlan();
                }
                else
                {
                    MessageBox.Show("撤回失败！");
                }
            }
            else
            {
                MessageBox.Show("选择要撤回的计划！");
                return;
            }

        }

        private void btn_query_jc_Click(object sender, EventArgs e)
        {
            try
            {
                string _strCCMID = "";
                if (this.icbo_lz3.SelectedIndex > 0)
                {
                    _strCCMID = this.icbo_lz3.Properties.Items[this.icbo_lz3.SelectedIndex].Value.ToString();
                }
                WaitingFrom.ShowWait("");
                BindLsbGrid(_strCCMID, this.rbtn_status.SelectedIndex + 1);
                WaitingFrom.CloseWait();
            }
            catch (Exception ex)
            {

            }
        }

        #region 查询浇次计划
        /// <summary>
        /// 查询浇次计划方法
        /// </summary>
        /// <param name="strCCMID">连铸机</param>
        private void BindLsbGrid(string strCCMID, int n_status)
        {
            var jc_cast_plan = bll_cast_plan.GetModelList(strCCMID, n_status, "").OrderBy(a => a.N_SORT).ToList();

            this.gridControl6.DataSource = jc_cast_plan;
            this.gridView6.OptionsView.ColumnAutoWidth = false;
            SetGridViewRowNum.SetRowNum(gridView6);

            //this.gridView6.RefreshData();
            this.gridView6.BestFitColumns();

        }

        #endregion

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            OutToExcel.ToExcel(this.gridControl6, "浇次计划" + System.DateTime.Now.ToString("yyyyMMddhhmmss"));
        }


        private void gv_Plan_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedHandle;
                selectedHandle = this.gv_Plan.FocusedRowHandle;
                if (selectedHandle <= 0)
                {
                    return;
                }
                string C_ID = this.gv_Plan.GetRowCellValue(selectedHandle, "C_ID").ToString();

                DataTable dt = bllTrpPlanRoll.GetOrderProInfo(C_ID);
                this.gridControl1.DataSource = dt;
                this.gridView1.OptionsView.ColumnAutoWidth = false;
                SetGridViewRowNum.SetRowNum(gridView1);
                this.gridView1.BestFitColumns();
            }
            catch (Exception)
            {


            }


        }

        private void btn_rf_order_Click(object sender, EventArgs e)
        {
            WaitingFrom.ShowWait("正在生成轧钢计划，请稍后...");

            //string result = bllTppZgPlan.Update_ZG_Plan_New("0", "", "", "", "", "");

            FrmPO_APS_ZG_PLAN_LOG frm = new FrmPO_APS_ZG_PLAN_LOG();
            if (frm.ShowDialog() == DialogResult.Yes)
            {
                string result = bllTppZgPlanTest.Update_ZG_Plan_New("0", "", "", "");

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

                Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "自动排产");//添加操作日志
            }
        }

        private void btn_Reset_Plan_Click(object sender, EventArgs e)
        {
            DataRow dr = gv_Plan.GetDataRow(gv_Plan.FocusedRowHandle);

            if (dr != null)
            {
                string strLineID = "";
                if (icbo_ZX_WXF.SelectedIndex > 0)
                {
                    strLineID = icbo_ZX_WXF.Properties.Items[this.icbo_ZX_WXF.SelectedIndex].Value.ToString();
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

                //string result = bllTppZgPlan.Update_ZG_Plan_New(strType, strLineID, strGZ, strBZ, strGG, strPlanID);

                string result = bllTppZgPlanTest.Update_ZG_Plan_New(strType, strLineID, strGG, dr["C_REMARK5"].ToString());

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

                Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "自动排产");//添加操作日志
            }
            else
            {
                MessageBox.Show("请选择需要指定的下发计划！");
                return;
            }
        }

        private void gv_Plan_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gv_Plan.GetDataRow(e.FocusedRowHandle);

            if (dr != null)
            {
                BindItem(dr["C_ID"].ToString());
            }
        }

        private void BindItem(string strID)
        {
            DataTable dt = bllTrpPlanItem.Get_Item_List(strID).Tables[0];

            gc_Item.DataSource = dt;

            SetGridViewRowNum.SetRowNum(gv_Item);
        }

        private void btn_update_plan_Click(object sender, EventArgs e)
        {
            try
            {
                string result = bllTrpPlanRollTest.Update_Plan();//更新排产计划到正式表
                string result_log = bllTrpPlanRollTest.Save_Plan_Log();//保存排产历史结果记录

                if (result == "成功" && result_log == "成功")
                {
                    MessageBox.Show("计划更新成功！");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
