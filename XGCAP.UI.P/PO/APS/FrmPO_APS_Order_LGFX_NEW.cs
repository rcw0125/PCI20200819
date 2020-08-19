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
using MODEL;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraGrid.Views.Grid;
using XGCAP.UI.P.PO.ViewModel;
using System.Reflection;

namespace XGCAP.UI.P.PO.APS
{
    public partial class FrmPO_APS_Order_LGFX_NEW : Form
    {
        public FrmPO_APS_Order_LGFX_NEW()
        {
            InitializeComponent();
        }
        #region 实例化功能设计对象
        private Bll_TPC_PLAN_SMS bll_plan = new Bll_TPC_PLAN_SMS();
        private static Bll_TSP_PLAN_SMS bll_plan_sms = new Bll_TSP_PLAN_SMS();
        private static Bll_TPP_LGPC_LSB bll_jc = new Bll_TPP_LGPC_LSB();//未排产浇次计划表
        private static Bll_TPP_LGPC_LCLSB bll_lc = new Bll_TPP_LGPC_LCLSB();//未排产临时计划表
        private static Bll_TPA_DHL_PLAN bll_dhl = new Bll_TPA_DHL_PLAN();//大方坯缓冷计划表
        private static Bll_TPA_KP_PLAN bll_kp = new Bll_TPA_KP_PLAN();//开坯计划表
        private static Bll_TPA_HL_PLAN bll_hl = new Bll_TPA_HL_PLAN();//热轧坯缓冷计划表
        private static Bll_TPA_XM_PLAN bll_xm = new Bll_TPA_XM_PLAN();//修磨计划表
        private static Bll_TPA_HL_ACT bll_hl_act = new Bll_TPA_HL_ACT();//缓冷实绩
        private static Bll_TSP_CAST_PLAN bll_cast_plan = new Bll_TSP_CAST_PLAN();//浇次计划
        private Bll_TPC_PLAN_SMS bll_tpc_plan_sms = new Bll_TPC_PLAN_SMS();//炼钢排产计划

        private static Bll_TRP_PLAN_ROLL bll_trp_plan = new Bll_TRP_PLAN_ROLL();//生产计划

        private static Bll_TMO_ORDER bll_order = new Bll_TMO_ORDER();//销售订单

        private static Bll_TRP_PLAN_ROLL_ITEM bll_roll_item = new Bll_TRP_PLAN_ROLL_ITEM();//轧钢计划表

        private static Bll_TB_STA bll_sta = new Bll_TB_STA();//工位

        #endregion

        #region 加载默认计划列表
        private List<Mod_TPP_LGPC_LSB> jc_plan = new List<Mod_TPP_LGPC_LSB>();//待排产浇次计划
        private List<Mod_TPP_LGPC_LCLSB> lc_plan = new List<Mod_TPP_LGPC_LCLSB>();//待排产炉次计划
        private List<Mod_TPA_DHL_PLAN> dhl_plan = new List<Mod_TPA_DHL_PLAN>();//已排产大方坯缓冷未完成计划
        private List<Mod_TPA_KP_PLAN> kp_plan = new List<Mod_TPA_KP_PLAN>();//已排产大方坯开坯未完成
        private List<Mod_TPA_HL_PLAN> hl_plan = new List<Mod_TPA_HL_PLAN>();//已排产热轧坯缓冷未完成计划
        private List<Mod_TPA_XM_PLAN> xm_plan = new List<Mod_TPA_XM_PLAN>();//已排产修磨未完成计划
        private List<Mod_TSP_PLAN_SMS> sms_plan = new List<Mod_TSP_PLAN_SMS>();//已排产未完成的计划
        private List<Mod_TPA_HL_ACT> hl_acl = new List<Mod_TPA_HL_ACT>();//已排产未完成的计划
        private List<Mod_TPP_LGPC_LSB> jc_plan_sort = new List<Mod_TPP_LGPC_LSB>();//待排产浇次计划
        private List<Mod_TPP_LGPC_LCLSB> lc_plan_sort = new List<Mod_TPP_LGPC_LCLSB>();//待排产炉次计划
        #endregion


        /// <summary>
        /// 页面加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmPO_APS_Order_LGFX_Load(object sender, EventArgs e)
        {
            // UserButtonRight.GetBtnFun(this, RV.UI.UserInfo.menuID);
            CommonSub.BindIcbo("", "CC", icbo_lz1);
            CommonSub.BindIcbo("", "CC", icbo_lz);
            CommonSub.BindIcbo("", "CC", icbo_lz2);
            dtp_form1.Text = Cls_Order_PC.GetDXFristDay()[0];
            this.dtp_end1.Text = Cls_Order_PC.GetDXFristDay()[1];
            dtp_from.Text = Cls_Order_PC.GetDXFristDay()[0];
            this.dtp_end.Text = Cls_Order_PC.GetDXFristDay()[1];

        }



        /// <summary>
        /// 加载由销售计划生成的炼钢需求计划
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_query_Click(object sender, EventArgs e)
        {
            WaitingFrom.ShowWait("炼钢待排计划加载中，请稍候...");

            string result = bll_plan_sms.P_INI_LGPC();

            string C_CCM_NO = "";
            string C_STL_GRD = this.txt_gz.Text.Trim();
            string C_STD_CODE = this.txt_zxbz.Text.Trim();
            if (this.icbo_lz.SelectedIndex > 0)
            {
                C_CCM_NO = this.icbo_lz.Properties.Items[this.icbo_lz.SelectedIndex].Value.ToString();
            }
            string d_dtf = this.dtp_from.Text;
            string d_dte = this.dtp_end.Text;

            DataTable dt = bll_plan.GetLgPlan(d_dtf, d_dte, C_CCM_NO, C_STL_GRD, C_STD_CODE, rbtn_status.SelectedIndex.ToString());
            this.gc_lg_plan.DataSource = dt;
            this.gv_lg_plan.OptionsView.ColumnAutoWidth = false;
            this.gv_lg_plan.OptionsSelection.MultiSelect = true;
            gv_lg_plan.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            SetGridViewRowNum.SetRowNum(gv_lg_plan);
            this.gv_lg_plan.BestFitColumns();
            WaitingFrom.CloseWait();
        }

        /// <summary>
        /// 炼钢需求计划导出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void simpleButton4_Click(object sender, EventArgs e)
        {
            OutToExcel.ToExcel(this.gc_lg_plan, "炼钢计划排产分析-" + System.DateTime.Now.ToString("yyyyMMddhhmmss"));
        }
        /// <summary>
        /// 计划重新划分连铸
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_fp_lz_Click(object sender, EventArgs e)
        {
            if (DialogResult.No == MessageBox.Show("是否确认重新分配计划连铸信息？\r\n重新分配后浇次计划将会重新生成！", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
            {
                return;
            }
            WaitingFrom.ShowWait("系统正对炼钢计划进行连铸重新分配，请稍候...");
            if (this.icbo_lz1.SelectedIndex <= 0)
            {
                MessageBox.Show("请选择要分配的连铸！");
                icbo_lz1.Focus();
                return;
            }
            string C_CCM_ID = icbo_lz1.Properties.Items[this.icbo_lz1.SelectedIndex].Value.ToString();
            Mod_TB_STA mod_sta = bll_sta.GetModel(C_CCM_ID);

            int[] aa = this.gv_Lg_plan_Query.GetSelectedRows();
            int cou = 0;
            for (int i = 0; i < aa.Length; i++)
            {
                int selectedHandle = aa[i];
                string C_ID = this.gv_Lg_plan_Query.GetRowCellValue(selectedHandle, "C_ID").ToString();
                string C_STL_GRD = this.gv_Lg_plan_Query.GetRowCellValue(selectedHandle, "C_STL_GRD").ToString();
                string C_STD_CODE = this.gv_Lg_plan_Query.GetRowCellValue(selectedHandle, "C_STD_CODE").ToString();

               

                Mod_TRP_PLAN_ROLL mod_roll = bll_trp_plan.GetModel(C_ID);
                string C_ORDER_ID = mod_roll.C_INITIALIZE_ITEM_ID;
                Mod_TMO_ORDER mod_order = bll_order.GetModel(C_ORDER_ID);

               

                mod_order.C_CCM_NO = C_CCM_ID;
                mod_order.C_CCM_CODE = mod_sta.C_STA_CODE;
                mod_order.C_CCM_DESC = mod_sta.C_STA_DESC;
                if (bll_order.Update(mod_order))
                {
                    mod_roll.C_CCM_ID = C_CCM_ID;
                    mod_roll.C_CCM_CODE = mod_sta.C_STA_CODE;
                    mod_roll.C_CCM_DESC = mod_sta.C_STA_DESC;
                    if (bll_trp_plan.Update(mod_roll))
                    {
                        cou = cou + i;
                    }
                }

            }
            MessageBox.Show("连铸划分成功！");
            WaitingFrom.CloseWait();
            btn_query_lc_plan_Click(null, null);

        }

        private void btn_rf_order_Click(object sender, EventArgs e)
        {

            string d_dtf = this.dtp_from.Text;
            string d_dte = this.dtp_end.Text;
            string c_ccm_id = "";
            if (icbo_lz.SelectedIndex <= 0)
            {
                c_ccm_id = "";

            }
            else
            {
                c_ccm_id = icbo_lz.Properties.Items[icbo_lz.SelectedIndex].Value.ToString();
               
            }


            if (DialogResult.No == MessageBox.Show("是否确认重新重新生成浇次计划！", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
            {

            }
            else
            {
                WaitingFrom.ShowWait("浇次计划正在重新生成，请稍候...");
                // string res = bll_plan.P_JCJH(Convert.ToDateTime(d_dtf),Convert.ToDateTime(d_dte));//生产浇次计划到临时表
                // string C_IS_BXG = this.rbtn_status.SelectedIndex.ToString();
                Cls_APS_PC.Generation_Slab_Plan(d_dtf, d_dte, c_ccm_id, "0");
                MessageBox.Show("浇次计划已成功生成，请在炼钢生产顺序界面进行处理！");
                WaitingFrom.CloseWait();

            }

        }

        private Bll_TPB_STEEL_PRO_CONDITION bll_gztj = new Bll_TPB_STEEL_PRO_CONDITION();

        private void btn_zdfz_Click(object sender, EventArgs e)
        {
            if (DialogResult.No == MessageBox.Show("是否确认强行分组混浇？\r\n重新分组后浇次计划将会重新生成！", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
            {
                return;
            }
            WaitingFrom.ShowWait("系统正对计划进行处理，请稍候...");

            int[] aa = this.gv_Lg_plan_Query.GetSelectedRows();
            int cou = 0;
            for (int i = 0; i < aa.Length; i++)
            {
                int selectedHandle = aa[i];
                string C_ID = this.gv_Lg_plan_Query.GetRowCellValue(selectedHandle, "C_ID").ToString();
                string C_STL_GRD = this.gv_Lg_plan_Query.GetRowCellValue(selectedHandle, "C_STL_GRD").ToString();
                string C_STD_CODE = this.gv_Lg_plan_Query.GetRowCellValue(selectedHandle, "C_STD_CODE").ToString();
                Mod_TRP_PLAN_ROLL mod_roll = bll_trp_plan.GetModel(C_ID);
                string C_ORDER_ID = mod_roll.C_INITIALIZE_ITEM_ID;
                Mod_TMO_ORDER mod_order = bll_order.GetModel(C_ORDER_ID);
                mod_order.N_GROUP = Convert.ToInt32(this.txt_zh.Text);

                bool res = bll_gztj.UpdateGZ(C_STL_GRD, C_STD_CODE, Convert.ToInt32(this.txt_zh.Text));
                
                if (bll_order.Update(mod_order))
                {
                    mod_roll.N_GROUP = Convert.ToInt32(this.txt_zh.Text);
                    if (bll_trp_plan.Update(mod_roll))
                    {
                        cou = cou + i;
                    }
                }

            }
            MessageBox.Show("计划分组成功！");
            WaitingFrom.CloseWait();
            btn_query_lc_plan_Click(null, null);
        }

        private void btn_OutToExcel2_Click(object sender, EventArgs e)
        {
            OutToExcel.ToExcel(this.gc_Lg_plan_Query, "炼钢排产计划-" + System.DateTime.Now.ToString("yyyyMMddhhmmss"));
        }

        private void btn_query_lc_plan_Click(object sender, EventArgs e)
        {
            int? n_status = null;
            if (this.rbtn_sfqr.SelectedIndex != 2)
            {
                n_status = this.rbtn_sfqr.SelectedIndex;
            }
            else
            {
                n_status = null;
            }
            string c_ccm = "";
            if (icbo_lz2.SelectedIndex > 0)
            {
                c_ccm = icbo_lz2.Properties.Items[icbo_lz2.SelectedIndex].Value.ToString();
            }
            string Dtb = "";
            string Dte = "";
            if (dtp_form1.Text.Trim() != "")
            {
                Dtb = dtp_form1.Text.Trim();
            }
            if (dtp_end1.Text.Trim() != "")
            {
                Dte = dtp_end1.Text.Trim();
            }
            WaitingFrom.ShowWait("");
            DataTable dt = bll_trp_plan.GetLGPlan(c_ccm, n_status, "", txt_gz2.Text.Trim(), txt_zxbz2.Text.Trim(), Dtb.ToString()).Tables[0];
            this.modTRPPLANROLLBindingSource.DataSource = dt;
            this.gv_Lg_plan_Query.OptionsView.ColumnAutoWidth = false;
            this.gv_Lg_plan_Query.OptionsSelection.MultiSelect = true;
            gv_Lg_plan_Query.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            SetGridViewRowNum.SetRowNum(gv_Lg_plan_Query);
            this.gv_Lg_plan_Query.BestFitColumns();
            WaitingFrom.CloseWait();

        }

        private void btn_auto_group_Click(object sender, EventArgs e)
        {

        }

        private void btn_change_wl_Click(object sender, EventArgs e)
        {
            if (DialogResult.No == MessageBox.Show("是否确认重新修改物料编码？\r\n重新修改后浇次计划将会重新生成！", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
            {
                return;
            }
            WaitingFrom.ShowWait("系统正对计划进行处理，请稍候...");

            int[] aa = this.gv_Lg_plan_Query.GetSelectedRows();

            string C_STL_GRD1 = "";
            string C_ROUTE = "";

            for (int i = 0; i < aa.Length; i++)
            {
                int selectedHandle = aa[i];

                if (i > 0)
                {
                    if (this.gv_Lg_plan_Query.GetRowCellValue(selectedHandle, "C_STL_GRD").ToString() != C_STL_GRD1 || this.gv_Lg_plan_Query.GetRowCellValue(selectedHandle, "C_ROUTE").ToString() != C_ROUTE)
                    {
                        MessageBox.Show("只能同时修改钢种和工艺路线一样的订单的物料编码！");
                        return;
                    }
                }
                C_STL_GRD1 = this.gv_Lg_plan_Query.GetRowCellValue(selectedHandle, "C_STL_GRD").ToString();
                C_ROUTE = this.gv_Lg_plan_Query.GetRowCellValue(selectedHandle, "C_ROUTE").ToString();

            }

            int cou = 0;
            for (int i = 0; i < aa.Length; i++)
            {
                int selectedHandle = aa[i];
                string C_ID = this.gv_Lg_plan_Query.GetRowCellValue(selectedHandle, "C_ID").ToString();
                string C_STL_GRD2 = this.gv_Lg_plan_Query.GetRowCellValue(selectedHandle, "C_STL_GRD").ToString();
                string C_ROUTE2 = this.gv_Lg_plan_Query.GetRowCellValue(selectedHandle, "C_ROUTE").ToString();

                if (C_STL_GRD1 != C_STL_GRD2 || C_ROUTE != C_ROUTE2)
                {
                    MessageBox.Show("选中行和选定物料不一致，不能修改物料！");
                    return;
                }
                if (this.cbo_lzpwl.SelectedIndex < 0)
                {
                    MessageBox.Show("请选择要修改的连铸坯物料！");
                    return;
                }
                string c_matral_rz_id = "";//热轧坯物料主键

                if (C_ROUTE2.Contains("KP"))
                {
                    if (this.cbo_rzpwl.SelectedIndex < 0)
                    {
                        MessageBox.Show("请选择要修改的热轧坯物料！");
                        return;
                    }
                    c_matral_rz_id = this.cbo_rzpwl.Properties.Items[this.cbo_rzpwl.SelectedIndex].Value.ToString();
                }
                else
                {
                    c_matral_rz_id = "";
                }
                string c_matral_id = this.cbo_lzpwl.Properties.Items[this.cbo_lzpwl.SelectedIndex].Value.ToString();

                Mod_TB_MATRL_MAIN modlz = bll_wl.GetModel(c_matral_id);//连铸坯物料
                Mod_TB_MATRL_MAIN mod_rz = null;
                if (c_matral_rz_id.Trim() != "")
                {
                    mod_rz = bll_wl.GetModel(c_matral_rz_id);
                }


                Mod_TRP_PLAN_ROLL mod_roll = bll_trp_plan.GetModel(C_ID);
                string C_ORDER_ID = mod_roll.C_INITIALIZE_ITEM_ID;
                Mod_TMO_ORDER mod_order = bll_order.GetModel(C_ORDER_ID);
                mod_order.C_MATRL_CODE_SLAB = modlz.C_ID;
                mod_order.C_MATRL_NAME_SLAB = modlz.C_MAT_NAME;
                mod_order.C_SLAB_SIZE = modlz.C_SLAB_SIZE;
                mod_order.N_SLAB_LENGTH = modlz.N_LTH;
                mod_order.N_SLAB_PW = modlz.N_HSL;

                if (mod_rz != null)
                {
                    mod_order.C_MATRL_CODE_KP = mod_rz.C_ID;
                    mod_order.C_MATRL_NAME_KP = mod_rz.C_MAT_NAME;
                    mod_order.C_KP_SIZE = mod_rz.C_SLAB_SIZE;
                    mod_order.N_KP_LENGTH = mod_rz.N_LTH;
                    mod_order.N_KP_PW = mod_rz.N_HSL;
                }

                if (bll_order.Update(mod_order))
                {
                    mod_roll.C_MATRL_CODE_SLAB = modlz.C_ID;
                    mod_roll.C_MATRL_NAME_SLAB = modlz.C_MAT_NAME;
                    mod_roll.C_SLAB_SIZE = modlz.C_SLAB_SIZE;
                    mod_roll.N_SLAB_LENGTH = modlz.N_LTH;
                    mod_roll.N_SLAB_PW = modlz.N_HSL;

                    if (mod_rz != null)
                    {
                        mod_roll.C_MATRL_CODE_KP = mod_rz.C_ID;
                        mod_roll.C_MATRL_NAME_KP = mod_rz.C_MAT_NAME;
                        mod_roll.C_KP_SIZE = mod_rz.C_SLAB_SIZE;
                        mod_roll.N_KP_LENGTH = mod_rz.N_LTH;
                        mod_roll.N_KP_PW = mod_rz.N_HSL;
                    }
                    if (bll_trp_plan.Update(mod_roll))
                    {
                        cou = cou + i;
                    }
                }

            }
            MessageBox.Show("物料信息修改成功！");
            WaitingFrom.CloseWait();
            btn_query_lc_plan_Click(null, null);
        }

        private Bll_TB_MATRL_MAIN bll_wl = new Bll_TB_MATRL_MAIN();
        private void gv_Lg_plan_Query_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                //加载选中订单的物料信息
                string C_ROUT = "";
                int selectedHandle = this.gv_Lg_plan_Query.FocusedRowHandle;
                if (selectedHandle < 0)
                {
                    return;
                }
                string C_STL_GRD = this.gv_Lg_plan_Query.GetRowCellValue(selectedHandle, "C_STL_GRD").ToString();
                string C_ROUTE = this.gv_Lg_plan_Query.GetRowCellValue(selectedHandle, "C_ROUTE").ToString();
                #region 获取物料工艺路线
                string wllj = "";
                string dfp = "";
                if (C_ROUTE.Contains("KP"))
                {
                    dfp = "Y";
                    if (C_ROUTE.Contains("LF") && C_ROUTE.Contains("RH"))
                    {
                        wllj = "(BLR)";
                    }
                    if (C_ROUTE.Contains("LF") && !C_ROUTE.Contains("RH"))
                    {
                        wllj = "(BL)";
                    }
                    if (!C_ROUTE.Contains("LF") && C_ROUTE.Contains("RH"))
                    {
                        wllj = "(BR)";
                    }
                }
                else
                {
                    wllj = "";
                    dfp = "N";
                }

                DataTable dtlzp = bll_wl.GetLZPMatrlList(C_STL_GRD, wllj, dfp).Tables[0];

                if (dtlzp.Rows.Count > 0)
                {
                    cbo_lzpwl.Properties.Items.Clear();
                    cbo_lzpwl.Text = "";
                    for (int i = 0; i < dtlzp.Rows.Count; i++)
                    {
                        cbo_lzpwl.Properties.Items.Add(dtlzp.Rows[i]["WLMC"].ToString(), dtlzp.Rows[i]["C_ID"].ToString(), -1);
                    }
                }

                if (C_ROUTE.Contains("KP"))
                {
                    DataTable dtrzp = bll_wl.GetRZPMatrlList(C_STL_GRD, wllj).Tables[0];
                    if (dtrzp.Rows.Count > 0)
                    {
                        cbo_rzpwl.Properties.Items.Clear();
                        cbo_rzpwl.Text = "";
                        for (int i = 0; i < dtrzp.Rows.Count; i++)
                        {
                            cbo_rzpwl.Properties.Items.Add(dtrzp.Rows[i]["WLMC"].ToString(), dtrzp.Rows[i]["C_ID"].ToString(), -1);
                        }
                    }

                }
                else
                {
                    cbo_rzpwl.Properties.Items.Clear();
                    cbo_rzpwl.Text = "";
                }


                #endregion

            }
            catch (Exception)
            {


            }

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (DialogResult.No == MessageBox.Show("是否确认重新分配计划连铸信息？\r\n重新分配后浇次计划将会重新生成！", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
            {
                return;
            }
            WaitingFrom.ShowWait("系统正对炼钢计划进行连铸重新分配，请稍候...");
            int[] aa = this.gv_Lg_plan_Query.GetSelectedRows();
            int cou = 0;
            for (int i = 0; i < aa.Length; i++)
            {
                int selectedHandle = aa[i];
                string C_ID = this.gv_Lg_plan_Query.GetRowCellValue(selectedHandle, "C_ID").ToString();
                string C_STL_GRD = this.gv_Lg_plan_Query.GetRowCellValue(selectedHandle, "C_STL_GRD").ToString();
                string C_STD_CODE = this.gv_Lg_plan_Query.GetRowCellValue(selectedHandle, "C_STD_CODE").ToString();
                Mod_TRP_PLAN_ROLL mod_roll = bll_trp_plan.GetModel(C_ID);
               // Cls_Order_PC.UpdateRollPlanMatral(mod_roll);

            }
            // string group = bll_plan.P_LGPLAN_GROUPING();//炼钢计划重新分组

            WaitingFrom.CloseWait();
            btn_query_lc_plan_Click(null, null);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string d_dtf = this.dtp_from.Text;
            string d_dte = this.dtp_end.Text;
            string c_ccm_id = "";
            if (icbo_lz.SelectedIndex <= 0)
            {
                c_ccm_id = "";
            }
            else
            {
                c_ccm_id = icbo_lz.Properties.Items[icbo_lz.SelectedIndex].Value.ToString();
            }

            int N_GROUP = 0;

            int[] aa = this.gv_lg_plan.GetSelectedRows();
            int cou = 0;
            for (int i = 0; i < aa.Length; i++)
            {
                int selectedHandle = aa[i];
                N_GROUP = Convert.ToInt32(this.gv_lg_plan.GetRowCellValue(selectedHandle, "N_GROUP").ToString());
            }


            if (DialogResult.No == MessageBox.Show("是否确认重新重新生成浇次计划！", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
            {

            }
            else
            {
                WaitingFrom.ShowWait("浇次计划正在重新生成，请稍候...");
                string C_IS_BXG = this.rbtn_status.SelectedIndex.ToString();
                Cls_APS_PC.Generation_Slab_PlanByGroup(d_dtf, d_dte, c_ccm_id, C_IS_BXG, N_GROUP);
                MessageBox.Show("浇次计划已成功生成，请在炼钢生产顺序界面进行处理！");
                WaitingFrom.CloseWait();

            }
        }

        private void btn_bxg_plan_Click(object sender, EventArgs e)
        {
            string d_dtf = this.dtp_from.Text;
            string d_dte = this.dtp_end.Text;
            string c_ccm_id = "";
            if (icbo_lz.SelectedIndex <= 0)
            {
                c_ccm_id = "";
            }
            else
            {
                c_ccm_id = icbo_lz.Properties.Items[icbo_lz.SelectedIndex].Value.ToString();
            }


            if (DialogResult.No == MessageBox.Show("是否确认重新重新生成浇次计划！", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
            {

            }
            else
            {
                WaitingFrom.ShowWait("浇次计划正在重新生成，请稍候...");
                // string res = bll_plan.P_JCJH(Convert.ToDateTime(d_dtf),Convert.ToDateTime(d_dte));//生产浇次计划到临时表
                //  string C_IS_BXG = this.rbtn_status.SelectedIndex.ToString();
                Cls_APS_PC.Generation_Slab_Plan(d_dtf, d_dte, c_ccm_id, "1");
                MessageBox.Show("浇次计划已成功生成，请在炼钢生产顺序界面进行处理！");
                WaitingFrom.CloseWait();

            }
        }
    }
}
