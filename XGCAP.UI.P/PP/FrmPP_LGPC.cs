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

namespace XGCAP.UI.P.PP
{
    public partial class FrmPP_LGPC : Form
    {
        Bll_TPP_INITIALIZE_ITEM bll_TPP_INITIALIZE_ITEM = new Bll_TPP_INITIALIZE_ITEM();
        Bll_TPB_SLAB_CAPACITY bll_TPB_SLAB_CAPACITY = new Bll_TPB_SLAB_CAPACITY();
        Bll_TPB_CHANGESPEC_TIME bll_TPB_CHANGESPEC_TIME = new Bll_TPB_CHANGESPEC_TIME();
        Bll_TB_PRO bll_TB_PRO = new Bll_TB_PRO();
        private Bll_TPB_STEEL_PRO_CONDITION bll_TPB_STEEL_PRO_CONDITION = new Bll_TPB_STEEL_PRO_CONDITION();
        private Bll_TPP_PROD_INITIALIZE bll_TPP_PROD_INITIALIZE = new Bll_TPP_PROD_INITIALIZE();//初始化主表（档期表）
        private Bll_TPB_CAST_STOVE bll_TPB_CAST_STOVE = new Bll_TPB_CAST_STOVE();
        Bll_TPP_INITIALIZE_STA bll_TPP_INITIALIZE_STA = new Bll_TPP_INITIALIZE_STA();
        Bll_TPB_CAST_STOVE_WGT bll_TPB_CAST_STOVE_WGT = new Bll_TPB_CAST_STOVE_WGT();
        Bll_TSP_PLAN_SMS_ITEM bll_TSP_PLAN_SMS_MAIN = new Bll_TSP_PLAN_SMS_ITEM();
        private Bll_TPP_INITIALIZE_ORDER bll_ini_order = new Bll_TPP_INITIALIZE_ORDER();//初始化订单表
        private Bll_TB_STA bll_TB_STA = new Bll_TB_STA();
        Bll_TPB_ENDTOEND_GRD bll_TPB_ENDTOEND_GRD = new Bll_TPB_ENDTOEND_GRD();
        CommonSub commonSub = new CommonSub();



        private Bll_TSP_PLAN_SMS bll_TSP_PLAN_SMS = new Bll_TSP_PLAN_SMS();
        private Bll_TMO_ORDER bll_TMO_ORDER = new Bll_TMO_ORDER();
        private Bll_TPP_CAST bll_TPP_CAST = new Bll_TPP_CAST();

        private string strMenuName;
        private DataTable dt_Group;

        public FrmPP_LGPC()
        {
            InitializeComponent();
        }

        private void FrmPP_LGPC_Load(object sender, EventArgs e)
        {
            try
            {
                strMenuName = RV.UI.UserInfo.menuName;
                UserButtonRight.GetBtnFun(this, RV.UI.UserInfo.menuID);

                BindIcbo("", "CC", cbo_GW1);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// 加载工位信息到ImageComboBoxEdit
        /// </summary>
        /// <param name="strIniID">方案主键</param>
        /// <param name="strGX">工序代码</param>
        /// <param name="cbo">ImageComboBoxEdit</param>
        public void BindIcbo(string strIniID, string strGX, DevExpress.XtraEditors.ImageComboBoxEdit cbo)
        {
            cbo.Properties.Items.Clear();
            DataTable dt = bll_TPP_INITIALIZE_STA.GetGXGWByIni(strIniID, strGX);
            if (dt.Rows.Count > 0)
            {
                cbo.Properties.Items.Add("", "", -1);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    cbo.Properties.Items.Add(dt.Rows[i]["C_STA_DESC"].ToString(), dt.Rows[i]["C_STA_ID"].ToString(), -1);
                }
            }
            else
            {
                cbo.Properties.Items.Clear();
            }
        }

        /// <summary>
        /// 查询订单信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Query_Click(object sender, EventArgs e)
        {
            try
            {
                dt_Group = bll_TMO_ORDER.Get_PC_GROUP().Tables[0];
                this.gc_tmo_order_pj.DataSource = dt_Group;
                this.gv_tmo_order_pj.OptionsView.ColumnAutoWidth = false;
                SetGridViewRowNum.SetRowNum(gv_tmo_order_pj);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        /// <summary>
        /// 添加炼钢计划
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Save2_Click(object sender, EventArgs e)
        {
            try
            {
                if (DialogResult.No == MessageBox.Show("是否确认添加计划？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
                {
                    return;
                }

                string user_id = RV.UI.UserInfo.userID;

                for (int i = 0; i < dt_Group.Rows.Count; i++)
                {
                    DataRow dr = dt_Group.Rows[i];

                    string strLS = dr["整浇次炉数"].ToString();//浇次炉数

                    if (string.IsNullOrEmpty(strLS))
                    {
                        MessageBox.Show("没查到符合条件的浇次炉数信息，不能安排生产计划！");
                        return;
                    }

                    double d_WGT = Convert.ToDouble(dr["整浇次重量"].ToString()) / Convert.ToDouble(strLS);//炉次重量

                    if (d_WGT <= 0)
                    {
                        MessageBox.Show("没查到符合条件的炉次重量，不能安排生产计划！");
                        return;
                    }

                    double jc_wgt = Convert.ToDouble(dr["整浇次重量"].ToString());//浇次理论总重量
                    int jc_num = Convert.ToInt32(dr["排产浇次数"].ToString());//可以排整浇次数

                    string str_CC_ID = dr["连铸主键"].ToString();

                    for (int kk = 0; kk < jc_num; kk++)
                    {
                        int sort_plan = 1;

                        int cast_sort = bll_TPP_CAST.GetMaxSort(str_CC_ID) + 1;//该方案下浇次顺序号

                        string cast_no = bll_TPP_CAST.GetMaxCastNo(str_CC_ID);//获取最大浇次号
                        if (cast_no == "0")
                        {
                            cast_no = DateTime.Now.ToString("yyyyMMdd") + bll_TB_STA.Get_STA_CODE(str_CC_ID).Substring(0, 1) + "00001";
                        }
                        else
                        {
                            cast_no = (Convert.ToInt64(cast_no) + 1).ToString();
                        }

                        #region 浇次计划主表信息

                        Mod_TPP_CAST modCast = new Mod_TPP_CAST();
                        modCast.C_CAST_NO = cast_no;//浇次号
                        modCast.C_CAST_LS = strLS;//浇次炉数
                        modCast.N_CAST_WGT = Convert.ToDecimal(jc_wgt);//浇次总重量
                        modCast.N_SORT = cast_sort;//生产顺序
                        modCast.C_CCM_ID = str_CC_ID;//铸机号主键
                        modCast.N_SFZJC = 1;
                        bll_TPP_CAST.Add(modCast);

                        #endregion

                        for (int mm = 0; mm < Convert.ToInt32(strLS); mm++)
                        {
                            Mod_TMO_ORDER mod_Order = bll_TMO_ORDER.Get_PC_ORDER(dr["组号"].ToString());
                            if (mod_Order == null)
                            {
                                break;
                            }

                            string str_PLAN_SMS_ID = bll_TSP_PLAN_SMS.GetMax_PlanID();
                            if (str_PLAN_SMS_ID == "0")
                            {
                                str_PLAN_SMS_ID = DateTime.Now.ToString("yyyyMM") + "00001";
                            }
                            else
                            {
                                str_PLAN_SMS_ID = (Convert.ToInt64(str_PLAN_SMS_ID) + 1).ToString();
                            }

                            Mod_TSP_PLAN_SMS modTspPlanSms = new Mod_TSP_PLAN_SMS();
                            //modTspPlanSms.C_PLAN_SMS_ID = str_PLAN_SMS_ID;//计划号
                            modTspPlanSms.C_CAST_NO = cast_no;
                            modTspPlanSms.N_SORT = sort_plan;
                            modTspPlanSms.C_CCM_ID = str_CC_ID;
                            modTspPlanSms.C_CCM_DESC = dr["连铸"].ToString();
                            modTspPlanSms.C_STD_CODE = dr["连铸代码"].ToString();
                            modTspPlanSms.C_STL_GRD = dr["C_STL_GRD"].ToString();
                            //modTspPlanSms.N_WGT_PROD = Convert.ToDecimal(d_WGT);
                            modTspPlanSms.C_ORDER_NO = mod_Order.C_ORDER_NO;
                            modTspPlanSms.C_EMP_ID = user_id;

                            string strEndTime = RV.UI.ServerTime.timeNow().ToString();

                            if (sort_plan == 1)
                            {
                                Mod_TPP_CAST modCastOld = bll_TPP_CAST.GetModel((cast_sort - 1).ToString(), str_CC_ID);

                                if (modCastOld != null)
                                {
                                    strEndTime = bll_TSP_PLAN_SMS.Get_EndTime(modCastOld.C_CAST_NO, modCastOld.C_CAST_LS);
                                    if (strEndTime == "0")
                                    {
                                        strEndTime = RV.UI.ServerTime.timeNow().ToString();
                                    }
                                }
                            }
                            else
                            {
                                strEndTime = bll_TSP_PLAN_SMS.Get_EndTime(cast_no, (sort_plan - 1).ToString());
                                if (strEndTime == "0")
                                {
                                    strEndTime = RV.UI.ServerTime.timeNow().ToString();
                                }
                            }

                            modTspPlanSms.D_P_START_TIME = Convert.ToDateTime(strEndTime);

                            double scTime = Convert.ToDouble(d_WGT) / Convert.ToDouble(dr["机时产能"].ToString());
                            modTspPlanSms.D_P_END_TIME = Convert.ToDateTime(modTspPlanSms.D_P_START_TIME).AddHours(scTime);

                            bll_TSP_PLAN_SMS.Add(modTspPlanSms);

                            decimal dec_Wgt = Convert.ToDecimal(mod_Order.N_WGT - mod_Order.N_SLAB_MATCH_WGT - mod_Order.N_SMS_PROD_WGT);



                            ////判断计划是否需要跨订单
                            //if (dec_Wgt >= 0)
                            //{
                            //    mod_Order.N_SMS_PROD_WGT = Convert.ToDecimal(d_WGT);
                            //    bll_TMO_ORDER.Update(mod_Order);//变更订单排产重量

                            //    #region 添加计划明细
                            //    Mod_TSP_PLAN_SMS_ITEM mod_plan_sms_item = new Mod_TSP_PLAN_SMS_ITEM();
                            //    mod_plan_sms_item.C_PRODUCTION_PLAN_ID = dr["C_ID"].ToString();
                            //    mod_plan_sms_item.C_PLAN_SMS_ID = mod_TSP_PLAN_SMS.C_PLAN_SMS_ID;//计划号
                            //    mod_plan_sms_item.N_WGT = mod_TSP_PLAN_SMS.N_WGT_PROD;//计划重量
                            //    mod_plan_sms_item.C_EMP_ID = user_id;
                            //    bll_TSP_PLAN_SMS_MAIN.Add(mod_plan_sms_item);
                            //    #endregion
                            //}
                            //else
                            //{
                            //    Mod_TPP_INITIALIZE_ORDER mod_TPPINITIALIZEORDER = bll_ini_order.GetModel(dr["C_ID"].ToString());

                            //    mod_TPPINITIALIZEORDER.N_SMS_PROD_WGT = mod_TPPINITIALIZEORDER.N_WGT;

                            //    if (mod_TPPINITIALIZEORDER.N_SMS_PROD_WGT >= 0)
                            //    {
                            //        mod_TPPINITIALIZEORDER.N_LGPC_STATUS = 1;
                            //    }

                            //    bll_ini_order.Update(mod_TPPINITIALIZEORDER);//变更方案计划表数据
                            //    #region 添加计划明细
                            //    Mod_TSP_PLAN_SMS_ITEM mod_plan_sms_item1 = new Mod_TSP_PLAN_SMS_ITEM();
                            //    mod_plan_sms_item1.C_PRODUCTION_PLAN_ID = dr["C_ID"].ToString();
                            //    mod_plan_sms_item1.C_PLAN_SMS_ID = mod_TSP_PLAN_SMS.C_PLAN_SMS_ID;//计划号
                            //    mod_plan_sms_item1.N_WGT = Convert.ToDecimal(dd_wgt + d_WGT);//计划重量
                            //    mod_plan_sms_item1.C_EMP_ID = user_id;
                            //    bll_TSP_PLAN_SMS_MAIN.Add(mod_plan_sms_item1);
                            //    #endregion

                            //    decimal dd = Convert.ToDecimal(d_WGT - (dd_wgt + d_WGT));
                            //    foreach (DataRow dr2 in orderdt.Rows)
                            //    {
                            //        Mod_TPP_INITIALIZE_ORDER mod_TPPINITIALIZEORDER2 = bll_ini_order.GetModel(dr2["C_ID"].ToString());
                            //        if (mod_TPPINITIALIZEORDER2.N_SMS_PROD_WGT == mod_TPPINITIALIZEORDER2.N_WGT)
                            //        {
                            //            continue;
                            //        }
                            //        if (mod_TPPINITIALIZEORDER2.N_WGT >= dd)
                            //        {
                            //            mod_TPPINITIALIZEORDER2.N_SMS_PROD_WGT = (mod_TPPINITIALIZEORDER2.N_SMS_PROD_WGT != null ? mod_TPPINITIALIZEORDER2.N_SMS_PROD_WGT : 0) + dd;

                            //            if (mod_TPPINITIALIZEORDER2.N_SMS_PROD_WGT >= 0)
                            //            {
                            //                mod_TPPINITIALIZEORDER2.N_LGPC_STATUS = 1;
                            //            }

                            //            bll_ini_order.Update(mod_TPPINITIALIZEORDER2);//变更方案计划表数据

                            //            #region 添加计划明细
                            //            Mod_TSP_PLAN_SMS_ITEM mod_plan_sms_item2 = new Mod_TSP_PLAN_SMS_ITEM();
                            //            mod_plan_sms_item2.C_PRODUCTION_PLAN_ID = dr2["C_ID"].ToString();
                            //            mod_plan_sms_item2.C_PLAN_SMS_ID = mod_TSP_PLAN_SMS.C_PLAN_SMS_ID;//计划号
                            //            mod_plan_sms_item2.N_WGT = dd;//计划重量
                            //            mod_plan_sms_item2.C_EMP_ID = user_id;
                            //            bll_TSP_PLAN_SMS_MAIN.Add(mod_plan_sms_item2);
                            //            #endregion

                            //            break;
                            //        }
                            //        else
                            //        {
                            //            mod_TPPINITIALIZEORDER2.N_SMS_PROD_WGT = (mod_TPPINITIALIZEORDER2.N_SMS_PROD_WGT != null ? mod_TPPINITIALIZEORDER2.N_SMS_PROD_WGT : 0) + mod_TPPINITIALIZEORDER2.N_WGT;

                            //            if (mod_TPPINITIALIZEORDER2.N_SMS_PROD_WGT >= mod_TPPINITIALIZEORDER2.N_WGT)
                            //            {
                            //                mod_TPPINITIALIZEORDER2.N_LGPC_STATUS = 1;
                            //            }

                            //            bll_ini_order.Update(mod_TPPINITIALIZEORDER2);//变更方案计划表数据

                            //            #region 添加计划明细
                            //            Mod_TSP_PLAN_SMS_ITEM mod_plan_sms_item2 = new Mod_TSP_PLAN_SMS_ITEM();
                            //            mod_plan_sms_item2.C_PRODUCTION_PLAN_ID = dr2["C_ID"].ToString();
                            //            mod_plan_sms_item2.C_PLAN_SMS_ID = mod_TSP_PLAN_SMS.C_PLAN_SMS_ID;//计划号
                            //            mod_plan_sms_item2.N_WGT = mod_TPPINITIALIZEORDER2.N_WGT;//计划重量
                            //            mod_plan_sms_item2.C_EMP_ID = user_id;
                            //            bll_TSP_PLAN_SMS_MAIN.Add(mod_plan_sms_item2);
                            //            #endregion
                            //        }

                            //        dd = Convert.ToDecimal(dd - mod_TPPINITIALIZEORDER2.N_WGT);

                            //    }


                            //}

                        }//mm
                    }//kk

                }//i

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }


    }
}
