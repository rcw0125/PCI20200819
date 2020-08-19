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
using MODEL;

namespace XGCAP.UI.P.PR
{
    public partial class FrmPR_ZGJH_CX : Form
    {
        private Bll_TB_ZG_PLAN_LOG bllZgPlanLog = new Bll_TB_ZG_PLAN_LOG();
        private Bll_TRP_PLAN_ITEM bllTrpPlanItem = new Bll_TRP_PLAN_ITEM();
        private Bll_TRP_PLAN_ITEM_LOG bllTrpPlanItemLog = new Bll_TRP_PLAN_ITEM_LOG();

        public FrmPR_ZGJH_CX()
        {
            InitializeComponent();
        }

        private void FrmPR_ZGJH_CX_Load(object sender, EventArgs e)
        {
            dt_Start.EditValue = DateTime.Now.AddDays(-2).ToString("yyyy-MM-dd") + DateTime.Now.ToString(" 00:00:00");
            dt_End.EditValue = DateTime.Now.ToString("yyyy-MM-dd") + DateTime.Now.ToString(" 23:59:59");

            CommonSub.BindIcbo("", "ZX", icbo_ZX);

            icbo_ZX.SelectedIndex = 0;
        }

        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Query_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(icbo_Pc_Name.Text.Trim()))
                {
                    MessageBox.Show("请选择排产名称！");
                    return;
                }

                BindPlan();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BindPlan()
        {
            try
            {
                WaitingFrom.ShowWait("");

                gc_Plan.DataSource = null;

                DataTable dt = bllZgPlanLog.Get_Plan_List(icbo_Pc_Name.Text.Trim(), txt_Stl_Grd.Text.Trim(), txt_Std_Code.Text.Trim(), icbo_ZX.EditValue.ToString().Trim()).Tables[0];

                gc_Plan.DataSource = dt;
                SetGridViewRowNum.SetRowNum(gv_Plan);

                BindPlanGroup(icbo_ZX.EditValue.ToString().Trim());

                WaitingFrom.CloseWait();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dt_Start_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(dt_Start.Text.Trim()) && !string.IsNullOrEmpty(dt_End.Text.Trim()))
                {
                    BindPcName(dt_Start.Text.Trim(), dt_End.Text.Trim());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dt_End_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(dt_Start.Text.Trim()) && !string.IsNullOrEmpty(dt_End.Text.Trim()))
                {
                    BindPcName(dt_Start.Text.Trim(), dt_End.Text.Trim());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 绑定排产名称下拉框
        /// </summary>
        /// <param name="strTime1"></param>
        /// <param name="strTime2"></param>
        private void BindPcName(string strTime1, string strTime2)
        {
            DataSet ds = bllZgPlanLog.GetList(strTime1, strTime2);
            icbo_Pc_Name.Properties.Items.Clear();
            foreach (DataRow item in ds.Tables[0].Rows)
            {
                icbo_Pc_Name.Properties.Items.Add(item["C_PLAN_NAME"].ToString(), item["C_PLAN_NAME"], -1);
            }
        }

        private void btn_out_Click(object sender, EventArgs e)
        {
            OutToExcel.ToExcel(gc_Plan, "轧钢计划-" + System.DateTime.Now.ToString("yyyyMMddhhmmss"));
        }

        private void gv_Plan_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gv_Plan.GetDataRow(e.FocusedRowHandle);

            if (dr != null)
            {
                DataTable dt = bllTrpPlanItemLog.Get_Item_List(dr["C_ID"].ToString(), icbo_Pc_Name.Text.Trim()).Tables[0];

                gc_Item.DataSource = dt;

                SetGridViewRowNum.SetRowNum(gv_Item);
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
            DataTable dt_ZX = bllTrpPlanItemLog.Get_ZX_List(strLineID, icbo_Pc_Name.Text.Trim()).Tables[0];

            if (dt_ZX.Rows.Count > 0)
            {
                DataTable dt_Plan = bllTrpPlanItemLog.Get_Plan_Item_List(strLineID, icbo_Pc_Name.Text.Trim()).Tables[0];

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
    }
}
