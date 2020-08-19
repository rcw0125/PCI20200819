using System;
using System.Data;
using System.Collections.Generic;
using DAL;
using MODEL;
using System.Reflection;
using System.Linq;
using System.Net;
using System.Net.Sockets;

namespace BLL
{
    /// <summary>
    /// 钢坯出入库记录
    /// </summary>
    public partial class Bll_TPP_LG_PLAN
    {
        private Dal_TSP_PLAN_SMS dalTspPlanSms = new Dal_TSP_PLAN_SMS();
        private Dal_TMO_ORDER dalTmoOrder = new Dal_TMO_ORDER();
        private Dal_TPP_CAST_PLAN dalTppCastPlan = new Dal_TPP_CAST_PLAN();
        private Dal_TB_STA dalTbSta = new Dal_TB_STA();
        private Dal_TPB_LGJH dalLgjh = new Dal_TPB_LGJH();
        private Dal_TB_MATRL_MAIN dalMatrlMain = new Dal_TB_MATRL_MAIN();
        private Dal_TRP_PLAN_ROLL dalTrpPlanRoll = new Dal_TRP_PLAN_ROLL();
        private Dal_TRP_PLAN_ITEM dalTrpPlanItem = new Dal_TRP_PLAN_ITEM();
        private Dal_TPB_CHANGESPEC_TIME dalChangeTime = new Dal_TPB_CHANGESPEC_TIME();
        private Dal_TRP_PLAN_SLAB_TIME dalTrpPlanSlabTime = new Dal_TRP_PLAN_SLAB_TIME();
        private Bll_TSP_PLAN_SMS bllTspPlanSms = new Bll_TSP_PLAN_SMS();
        private Dal_TPP_LGPC_LSB dalTppLgpcLsb = new Dal_TPP_LGPC_LSB();
        private Dal_TPP_LGPC_LCLSB dalTppLgpcLclsb = new Dal_TPP_LGPC_LCLSB();
        private Bll_TPP_LGPC_LCLSB bllTppLgpcLclsb = new Bll_TPP_LGPC_LCLSB();
        private Dal_TSP_CAST_PLAN dalTspCastPlan = new Dal_TSP_CAST_PLAN();
        private Dal_TB_LG_PLAN_LOG dalTbLgPlanLog = new Dal_TB_LG_PLAN_LOG();
        private Dal_TB_LG_PLAN_EDIT_LOG dalTbLgPlanEditLog = new Dal_TB_LG_PLAN_EDIT_LOG();

        public Bll_TPP_LG_PLAN()
        { }

        /// <summary>
        /// 获取本机IP地址
        /// </summary>
        /// <returns></returns>
        public static string GetLocalIP()
        {
            try
            {
                string HostName = Dns.GetHostName(); //得到主机名
                IPHostEntry IpEntry = Dns.GetHostEntry(HostName);
                for (int i = 0; i < IpEntry.AddressList.Length; i++)
                {
                    //从IP地址列表中筛选出IPv4类型的IP地址
                    //AddressFamily.InterNetwork表示此IP为IPv4,
                    //AddressFamily.InterNetworkV6表示此地址为IPv6类型
                    if (IpEntry.AddressList[i].AddressFamily == AddressFamily.InterNetwork)
                    {
                        return IpEntry.AddressList[i].ToString();
                    }
                }
                return "";
            }
            catch
            {
                return "";
            }

        }

        /// <summary>
        /// 计算连铸计划时间
        /// </summary>
        /// <param name="P_START_TIME">计划开始时间</param>
        /// <param name="P_CC_ID">连铸ID</param>
        /// <returns></returns>
        public string UpdatePlanTime(string P_START_TIME, string P_CC_ID)
        {
            string result = "1";
            try
            {
                TransactionHelper.BeginTransaction();

                string strUserID = RV.UI.UserInfo.userID;
                DateTime time = RV.UI.ServerTime.timeNow();

                DataTable dt_CC = new DataTable();

                if (string.IsNullOrEmpty(P_CC_ID.Trim()))
                {
                    dt_CC = dalTbSta.GetListByGX("CC").Tables[0];//查询所有连铸工位
                }
                else
                {
                    dt_CC.Columns.Add("C_ID");
                    DataRow dr = dt_CC.NewRow();
                    dr["C_ID"] = P_CC_ID;
                    dt_CC.Rows.Add(dr);
                }

                bool flag = true;

                if (dt_CC.Rows.Count > 0)
                {
                    DateTime? V_START_TIME;//计划开始
                    DateTime? V_End_TIME;//计划结束
                    double V_TIME_YL;//冶炼时间
                    double V_CN;//产能

                    for (int i = 0; i < dt_CC.Rows.Count; i++)
                    {
                        V_START_TIME = null;
                        V_End_TIME = null;
                        V_TIME_YL = 0;
                        V_CN = 0;

                        string str_CC_ID = dt_CC.Rows[i]["C_ID"].ToString();

                        DataTable dt_Plan = dalTspPlanSms.Get_CC_Plan_List_Trans(str_CC_ID).Tables[0];

                        for (int kk = 0; kk < dt_Plan.Rows.Count; kk++)
                        {
                            V_CN = Convert.ToDouble(dt_Plan.Rows[kk]["N_MACH_WGT_CCM"].ToString());
                            if (V_CN == 0)
                            {
                                V_CN = 1;
                            }

                            DataTable dt_Time = dalTspPlanSms.Get_Time_Trans(Convert.ToInt32(dt_Plan.Rows[kk]["N_SORT"].ToString()), str_CC_ID).Tables[0];

                            if (!string.IsNullOrEmpty(P_START_TIME.Trim()) && kk == 0)
                            {
                                V_START_TIME = Convert.ToDateTime(P_START_TIME);
                            }
                            else
                            {
                                if (dt_Time.Rows.Count > 0)
                                {
                                    if (string.IsNullOrEmpty(dt_Time.Rows[0]["D_P_END_TIME"].ToString()))
                                    {
                                        V_START_TIME = time;
                                    }
                                    else
                                    {
                                        V_START_TIME = Convert.ToDateTime(dt_Time.Rows[0]["D_P_END_TIME"].ToString());
                                    }

                                    if (!string.IsNullOrEmpty(dt_Time.Rows[0]["N_PRODUCE_TIME"].ToString()))
                                    {
                                        V_START_TIME = Convert.ToDateTime(V_START_TIME).AddHours(Convert.ToDouble(dt_Time.Rows[0]["N_PRODUCE_TIME"].ToString()));
                                    }
                                }
                                else
                                {
                                    V_START_TIME = time;
                                }

                                V_TIME_YL = Convert.ToDouble(dt_Plan.Rows[kk]["N_SLAB_WGT"].ToString()) / V_CN;

                                V_End_TIME = Convert.ToDateTime(V_START_TIME).AddHours(V_TIME_YL);
                            }


                            #region 轧钢可以开始时间

                            Mod_TMO_ORDER modOrder = dalTmoOrder.GetModel(dt_Plan.Rows[kk]["C_ORDER_NO"].ToString());
                            DateTime V_ZG_TIME = Convert.ToDateTime(V_End_TIME);
                            if (!string.IsNullOrEmpty(modOrder.C_XM))
                            {
                                V_ZG_TIME = V_ZG_TIME.AddHours(72);
                            }

                            if (modOrder.N_HL_TIME == 0)
                            {
                                V_ZG_TIME = V_ZG_TIME.AddHours(2);
                            }
                            else
                            {
                                V_ZG_TIME = V_ZG_TIME.AddHours(Convert.ToDouble(modOrder.N_HL_TIME) + Convert.ToDouble(modOrder.N_DFP_HL_TIME));
                            }

                            #endregion


                            if (!dalTspPlanSms.Update_Time_Trans(dt_Plan.Rows[kk]["C_ID"].ToString(), Convert.ToDateTime(V_START_TIME), Convert.ToDateTime(V_End_TIME), Convert.ToDateTime(V_ZG_TIME)))
                            {
                                TransactionHelper.RollBack();
                                return "0";
                            }
                        }

                    }//for dt_CC

                    if (flag == false)
                    {
                        TransactionHelper.RollBack();
                        return "0";
                    }

                    TransactionHelper.Commit();
                }//dt_CC
                else
                {
                    TransactionHelper.RollBack();
                    return "0";
                }
            }
            catch (Exception ex)
            {
                TransactionHelper.RollBack();
                return "0";
            }

            return result;
        }

        /// <summary>
        /// 生成各工序计划(下发调度)
        /// </summary>
        /// <returns></returns>
        public string CreatStaPlan(string P_CC_ID, string C_FK)
        {

            try
            {
                TransactionHelper.BeginTransaction();

                string strUserID = RV.UI.UserInfo.userID;
                DateTime time = RV.UI.ServerTime.timeNow();

                DataTable dt_Plan_List = dalTspPlanSms.Get_Plan_List_Trans(P_CC_ID, C_FK).Tables[0];//未生成工序计划的连铸计划

                bool flag = true;

                if (dt_Plan_List.Rows.Count > 0)
                {
                    DateTime? V_START_ZL;
                    DateTime? V_End_ZL;
                    DateTime? V_End_ZL_LEAVE;
                    DateTime? V_START_LF;
                    DateTime? V_End_LF;
                    DateTime? V_START_RH;
                    DateTime? V_End_RH;
                    double V_TIME_YL;
                    string V_RH_ID;
                    string V_LF_ID;
                    string V_LD_ID;
                    string V_CC_ID;
                    double V_CN;
                    string V_TYPE;

                    for (int i = 0; i < dt_Plan_List.Rows.Count; i++)
                    {
                        V_START_ZL = null;
                        V_End_ZL = null;
                        V_End_ZL_LEAVE = null;
                        V_START_LF = null;
                        V_End_LF = null;
                        V_START_RH = null;
                        V_End_RH = null;
                        V_TIME_YL = 0;
                        V_RH_ID = "";
                        V_LF_ID = "";
                        V_LD_ID = "";
                        V_CC_ID = "";
                        V_CN = 0;
                        V_TYPE = "";

                        Mod_TMO_ORDER mod_Order = dalTmoOrder.GetModel(dt_Plan_List.Rows[i]["C_ORDER_NO"].ToString());

                        V_RH_ID = dt_Plan_List.Rows[i]["C_RH_ID"].ToString();
                        V_LF_ID = dt_Plan_List.Rows[i]["C_LF_ID"].ToString();
                        V_LD_ID = dt_Plan_List.Rows[i]["C_ZL_ID"].ToString();
                        V_CC_ID = dt_Plan_List.Rows[i]["C_CCM_ID"].ToString();

                        if (mod_Order != null)
                        {
                            V_CN = Convert.ToDouble(mod_Order.N_MACH_WGT_CCM);

                            if (V_CN == 0)
                            {
                                V_CN = 1;
                            }

                            V_TIME_YL = Convert.ToDouble(dt_Plan_List.Rows[i]["N_SLAB_WGT"].ToString()) / V_CN;

                            if (string.IsNullOrEmpty(V_RH_ID))
                            {
                                if (string.IsNullOrEmpty(V_LF_ID))
                                {
                                    V_End_ZL_LEAVE = Convert.ToDateTime(dt_Plan_List.Rows[i]["D_P_START_TIME"].ToString()).AddMinutes(-10);
                                    V_End_ZL = Convert.ToDateTime(V_End_ZL_LEAVE).AddMinutes(-5);
                                    V_START_ZL = Convert.ToDateTime(V_End_ZL).AddHours(-V_TIME_YL);
                                }
                                else
                                {
                                    V_End_LF = Convert.ToDateTime(dt_Plan_List.Rows[i]["D_P_START_TIME"].ToString()).AddMinutes(-10);
                                    V_START_LF = Convert.ToDateTime(V_End_LF).AddHours(-V_TIME_YL);

                                    V_End_ZL_LEAVE = Convert.ToDateTime(V_START_LF).AddMinutes(-10);
                                    V_End_ZL = Convert.ToDateTime(V_End_ZL_LEAVE).AddMinutes(-5);
                                    V_START_ZL = Convert.ToDateTime(V_End_ZL).AddHours(-V_TIME_YL);
                                }
                            }
                            else
                            {
                                V_End_RH = Convert.ToDateTime(dt_Plan_List.Rows[i]["D_P_START_TIME"].ToString()).AddMinutes(-10);
                                V_START_RH = Convert.ToDateTime(V_End_RH).AddHours(-V_TIME_YL);

                                V_End_LF = Convert.ToDateTime(V_START_RH).AddMinutes(-10);
                                V_START_LF = Convert.ToDateTime(V_End_LF).AddHours(-V_TIME_YL);

                                V_End_ZL_LEAVE = Convert.ToDateTime(V_START_LF).AddMinutes(-10);
                                V_End_ZL = Convert.ToDateTime(V_End_ZL_LEAVE).AddMinutes(-5);
                                V_START_ZL = Convert.ToDateTime(V_End_ZL).AddHours(-V_TIME_YL);

                            }

                            if (string.IsNullOrEmpty(V_LF_ID))
                            {
                                if (string.IsNullOrEmpty(V_RH_ID))
                                {
                                    V_TYPE = "0";
                                }
                                else
                                {
                                    V_TYPE = "R";
                                }
                            }
                            else
                            {
                                if (string.IsNullOrEmpty(V_RH_ID))
                                {
                                    V_TYPE = "L";
                                }
                                else
                                {
                                    V_TYPE = "LR";
                                }
                            }

                            string C_THICKNESS = "";
                            string C_W_IDTH = "";

                            string slabSize = dt_Plan_List.Rows[i]["C_SLAB_SIZE"].ToString();
                            if (slabSize.Contains("*"))
                            {
                                string[] strr = slabSize.Split('*');
                                C_W_IDTH = strr[1];
                                C_THICKNESS = strr[0];
                            }

                            if (V_START_ZL == null)
                            {
                                V_START_ZL = Convert.ToDateTime("1899/12/30 00:00:00");
                            }
                            if (V_End_ZL == null)
                            {
                                V_End_ZL = Convert.ToDateTime("1899/12/30 00:00:00");
                            }
                            if (V_End_ZL_LEAVE == null)
                            {
                                V_End_ZL_LEAVE = Convert.ToDateTime("1899/12/30 00:00:00");
                            }
                            if (V_START_LF == null)
                            {
                                V_START_LF = Convert.ToDateTime("1899/12/30 00:00:00");
                            }
                            if (V_End_LF == null)
                            {
                                V_End_LF = Convert.ToDateTime("1899/12/30 00:00:00");
                            }
                            if (V_START_RH == null)
                            {
                                V_START_RH = Convert.ToDateTime("1899/12/30 00:00:01");
                            }
                            if (V_End_RH == null)
                            {
                                V_End_RH = Convert.ToDateTime("1899/12/30 00:00:01");
                            }

                            Mod_TPP_CAST_PLAN modelCastPlan = new Mod_TPP_CAST_PLAN();
                            modelCastPlan.C_PLAN_ID = dt_Plan_List.Rows[i]["C_ID"].ToString(); //计划编号
                            modelCastPlan.C_CONTRACT_ID = mod_Order.C_CON_NO; //合同编号
                            modelCastPlan.C_PLAN_DEPT = ""; //计划部门
                            modelCastPlan.C_EXECUTE_DEPT = ""; //执行部门
                            modelCastPlan.D_PLANEXECUTE_DATE = null; //计划执行时间
                            modelCastPlan.D_ACTUALEXECUTE_DATE = null; //实际执行时间
                            modelCastPlan.C_PLANNER = strUserID; //计划人
                            modelCastPlan.C_PRE_LOTNO = ""; //炉次
                            modelCastPlan.C_PRE_HEAT_ID = ""; //预定炉号
                            modelCastPlan.C_PRE_STEELGRADEINDEX = dt_Plan_List.Rows[i]["C_LGJH"].ToString(); //预定炼钢记号
                            modelCastPlan.C_PRE_STEELGRADE = dt_Plan_List.Rows[i]["C_STL_GRD"].ToString(); //预定钢种
                            modelCastPlan.N_AIM_TAPPED_WEIGHT = Convert.ToDecimal(dt_Plan_List.Rows[i]["N_SLAB_WGT"].ToString()); //--目标出钢重量
                            modelCastPlan.C_CASTER_ID = V_CC_ID; //-铸机号
                            modelCastPlan.C_BOF_ID = V_LD_ID; //--转炉炉座
                            modelCastPlan.C_LF_ID = V_LF_ID; ////-精炼炉座
                            modelCastPlan.C_RH_ID = V_RH_ID; //---RH炉座
                            modelCastPlan.N_BOF_STATUS = "01"; //-转炉状态01未执02兑铁03吹炼开始04出钢开05出钢结束
                            modelCastPlan.N_LF_STATUS = "01"; //-精炼炉状态01未执行02进站03处理开始04处理结束05出站
                            modelCastPlan.N_RH_STATUS = "01"; //-RH炉状态01未执行02进站03处理开始04处理结束05出站
                            modelCastPlan.N_CASTER_STATUS = "01"; //--铸机状态01未执行02大包到达03大包开浇04浇铸结束
                            modelCastPlan.N_S_IDE_STATUS = "01"; //---转炉炉后状态01未执行02处理开始03处理结束
                            modelCastPlan.C_HEAT_ID = ""; //---炉次
                            modelCastPlan.C_CASTER_NO = ""; //--铸机号
                            modelCastPlan.C_CASTING_HEAT_CNT = "";
                            modelCastPlan.D_AIM_IRONPREPARED_TIME = V_START_ZL; ////-"铁水计划时间"
                            modelCastPlan.D_AIM_BOFSTART_TIME = V_START_ZL; //-"转炉开始计划时间"
                            modelCastPlan.D_AIM_BOFTAPPED_TIME = V_End_ZL; //--"转炉结束计划时间"
                            modelCastPlan.D_AIM_TAPPEDSIDEEND_TIME = V_End_ZL_LEAVE; //转炉离开计划时间"
                            modelCastPlan.D_AIM_LFARRIVAL_TIME = V_START_LF; //LF到达计划时间"
                            modelCastPlan.D_AIM_LFSTART_TIME = V_START_LF; //LF开始计划时间"
                            modelCastPlan.D_AIM_LFEND_TIME = V_End_LF; //LF结束计划时间"
                            modelCastPlan.D_AIM_LFLEAVE_TIME = V_End_LF; //LF离开计划时间"
                            modelCastPlan.D_AIM_RHARRIVAL_TIME = V_START_RH; //RH到达计划时间
                            modelCastPlan.D_AIM_RHSTART_TIME = V_START_RH; //RH开始计划时间
                            modelCastPlan.D_AIM_RHEND_TIME = V_End_RH; //RH结束计划时间
                            modelCastPlan.D_AIM_RHLEAVE_TIME = V_End_RH; //RH离开计划时间
                            modelCastPlan.D_AIM_CASTERARRIVAL_TIME = Convert.ToDateTime(dt_Plan_List.Rows[i]["D_P_START_TIME"].ToString()); //"连铸到达计划时间"
                            modelCastPlan.D_AIM_CASTINGSTART_TIME = Convert.ToDateTime(dt_Plan_List.Rows[i]["D_P_START_TIME"].ToString()); //"连铸开始计划时间"
                            modelCastPlan.D_AIM_CASTINGEND_TIME = Convert.ToDateTime(dt_Plan_List.Rows[i]["D_P_END_TIME"].ToString()); //"连铸结束计划时间"
                            modelCastPlan.C_FIR_HEAT_FLAG = "0"; ////加热炉标志
                            modelCastPlan.DIV_HEAT_ID = ""; //---加热炉
                            modelCastPlan.C_TEAM_ID = "1"; //班组
                            modelCastPlan.C_SHIFT_ID = "1"; //班别
                            modelCastPlan.STEELGRADEINDEX = ""; //---炼钢记号
                            modelCastPlan.C_PLAN_ORD__ID = mod_Order.C_ORDER_NO; //计划订单号
                            modelCastPlan.C_HOT_SEND_FLAG = "0"; //热送标志
                            modelCastPlan.C_STEEL_RETURN_FLAG = "0"; //回炉标志
                            modelCastPlan.C_STEEL_BACK_FLAG = "0"; //返送标志
                            modelCastPlan.C_TREAT_SEQ = ""; ////顺序
                            modelCastPlan.C_DESTITATION = "";
                            modelCastPlan.C_NEW_BOF_FLAG = ""; ////--转炉标记
                            modelCastPlan.C_REFINE_TYPE = V_TYPE; //-工艺路径
                            modelCastPlan.C_LENGTH = dt_Plan_List.Rows[i]["C_SLAB_LENGTH"].ToString(); //--长度
                            modelCastPlan.C_W_IDTH = C_W_IDTH; //-宽度
                            modelCastPlan.C_THICKNESS = C_THICKNESS; //厚度
                            modelCastPlan.C_AOD_ID = ""; //AOD炉炉座
                            modelCastPlan.C_DEP_ID = ""; //熔化炉炉座
                            modelCastPlan.C_RHL_ID = ""; //--转炉后
                            modelCastPlan.C_DEP_STATUS = ""; //熔化炉状态
                            modelCastPlan.C_RHL_STATUS = ""; //-转炉后状态
                            modelCastPlan.C_AOD_STATUS = ""; //AOD炉状态
                            modelCastPlan.C_INITIALIZE_ITEM = ""; //--订单方案号
                            modelCastPlan.C_IS_TO_MES = "0";//0未传mes，1已传mes
                            modelCastPlan.C_MES_PLAN_ID = "";//MES计划号
                            modelCastPlan.C_LD_DESC = dt_Plan_List.Rows[i]["C_ZL_DESC"].ToString();
                            modelCastPlan.C_LF_DESC = dt_Plan_List.Rows[i]["C_LF_DESC"].ToString();
                            modelCastPlan.C_RH_DESC = dt_Plan_List.Rows[i]["C_RH_DESC"].ToString();
                            modelCastPlan.C_CC_DESC = dt_Plan_List.Rows[i]["C_CCM_DESC"].ToString();

                            if (dalTppCastPlan.Add_Trans(modelCastPlan))
                            {
                                if (!dalTspPlanSms.Update_State_Trans(dt_Plan_List.Rows[i]["C_ID"].ToString()))
                                {
                                    TransactionHelper.RollBack();
                                    return "更新计划下发状态失败！";
                                }

                                Mod_TB_LG_PLAN_LOG modLog = new Mod_TB_LG_PLAN_LOG();
                                modLog.C_IP = GetLocalIP();
                                //modLog.C_STOVE = stove;
                                modLog.C_PLAN_ID = modelCastPlan.C_PLAN_ID;
                                modLog.C_ORDER_NO = modelCastPlan.C_PLAN_ORD__ID;
                                modLog.C_MES_PLAN_ID = modelCastPlan.C_MES_PLAN_ID;
                                modLog.C_LD_DESC = modelCastPlan.C_LD_DESC;
                                modLog.C_LF_DESC = modelCastPlan.C_LF_DESC;
                                modLog.C_RH_DESC = modelCastPlan.C_RH_DESC;
                                modLog.C_CC_DESC = modelCastPlan.C_CC_DESC;
                                modLog.C_EMP_ID = strUserID;
                                modLog.D_MOD_DT = time;
                                modLog.C_REMARK = "下发调度";

                                if (!dalTbLgPlanLog.Add_Trans(modLog))
                                {
                                    TransactionHelper.RollBack();
                                    return "添加操作日志失败！";
                                }
                            }
                            else
                            {
                                TransactionHelper.RollBack();
                                return "生产各工序计划失败！";
                            }

                        }//mod_Order
                        else
                        {
                            flag = false;
                            break;
                        }
                    }//dt_Plan_List

                    if (flag == false)
                    {
                        TransactionHelper.RollBack();
                        return "没有找到订单信息！";
                    }

                    Mod_TSP_CAST_PLAN model = dalTspCastPlan.GetModel(C_FK);
                    if (model == null)
                    {
                        TransactionHelper.RollBack();
                        return "没有找到浇次信息！";
                    }
                    else
                    {
                        model.N_STATUS = 2;//下发调度

                        if (!dalTspCastPlan.Update_Trans(model))
                        {
                            TransactionHelper.RollBack();
                            return "更新浇次计划状态失败！";
                        }
                    }

                    TransactionHelper.Commit();
                    return "1";
                }
                else
                {
                    TransactionHelper.RollBack();
                    return "未找到需要下发调度的计划！";
                }
            }
            catch (Exception ex)
            {
                TransactionHelper.RollBack();
                return ex.Message;
            }
        }


        /// <summary>
        /// 下发计划给MES
        /// </summary>
        /// <param name="P_CC_ID">连铸ID</param>
        /// <param name="P_ROW_COUNT">计划数</param>
        /// <returns></returns>
        public string SendPlanToMes(string P_CC_ID, int P_ROW_COUNT, string strUrl)
        {
            string result = "1";
            try
            {
                Dal_Interface_NC_SLAB_A1 dalInterface_Slab_A1 = new Dal_Interface_NC_SLAB_A1();
                Dal_Interface_NC_SLAB_A2 dalInterface_Slab_A2 = new Dal_Interface_NC_SLAB_A2();

                TransactionHelper.BeginTransaction();

                string strUserID = RV.UI.UserInfo.userID;
                DateTime time = RV.UI.ServerTime.timeNow();

                DataTable dt_Plan_List = dalTppCastPlan.Get_List(P_CC_ID, P_ROW_COUNT).Tables[0];//获取需要下发到MES的计划

                if (dt_Plan_List.Rows.Count > 0)
                {
                    for (int i = 0; i < dt_Plan_List.Rows.Count; i++)
                    {
                        Mod_TSP_PLAN_SMS mod_sms = dalTspPlanSms.GetModel(dt_Plan_List.Rows[i]["C_PLAN_ID"].ToString());
                        Mod_TMO_ORDER mod_order = dalTmoOrder.GetModel(mod_sms.C_ORDER_NO);
                        Mod_TB_MATRL_MAIN mod_Matrl_Main = dalMatrlMain.GetModel(mod_sms.C_MATRL_NO);

                        #region 生成炉号

                        string str_Is_BXG = "N";
                        if (mod_order.C_BY4 == "1")
                        {
                            str_Is_BXG = "Y";
                        }

                        string str_LD_CODE = dalTbSta.Get_STA_CODE(dt_Plan_List.Rows[i]["C_BOF_ID"].ToString());

                        string stove = dalTppCastPlan.Get_Max_Stove_Trans(dt_Plan_List.Rows[i]["C_BOF_ID"].ToString(), str_Is_BXG);

                        if (stove == "")
                        {
                            if (str_Is_BXG == "Y")
                            {
                                stove = "61" + time.Year.ToString().Substring(2, 2) + "00001";
                            }
                            else
                            {
                                stove = "2" + str_LD_CODE.Substring(0, 1) + time.Year.ToString().Substring(2, 2) + "00001";
                            }
                        }
                        else
                        {
                            stove = (Convert.ToInt32(stove) + 1).ToString();

                            if (stove.Substring(2, 2) != time.Year.ToString().Substring(2, 2))
                            {
                                if (str_Is_BXG == "Y")
                                {
                                    stove = "61" + time.Year.ToString().Substring(2, 2) + "00001";
                                }
                                else
                                {
                                    stove = "2" + str_LD_CODE.Substring(0, 1) + time.Year.ToString().Substring(2, 2) + "00001";
                                }
                            }
                        }

                        #endregion

                        #region 计算炼钢记号

                        string LGJH_LD_CODE = "";
                        string LGJH_LF_CODE = "";
                        string LGJH_RH_CODE = "";
                        string LGJH_CC_CODE = "";

                        string V_ZL_TYPE = "";
                        string V_LF_TYPE = "";
                        string V_RH_TYPE = "";
                        string V_CC_TYPE = "";

                        LGJH_LD_CODE = dalTbSta.Get_CODE(dt_Plan_List.Rows[i]["C_BOF_ID"].ToString());
                        LGJH_LF_CODE = dalTbSta.Get_CODE(dt_Plan_List.Rows[i]["C_LF_ID"].ToString());
                        LGJH_RH_CODE = dalTbSta.Get_CODE(dt_Plan_List.Rows[i]["C_RH_ID"].ToString());
                        LGJH_CC_CODE = dalTbSta.Get_CODE(dt_Plan_List.Rows[i]["C_CASTER_ID"].ToString());

                        LGJH_LD_CODE = LGJH_LD_CODE.Substring(0, 1);
                        LGJH_LF_CODE = LGJH_LF_CODE.Substring(0, 1);
                        LGJH_RH_CODE = LGJH_RH_CODE.Substring(0, 1);
                        LGJH_CC_CODE = LGJH_CC_CODE.Substring(0, 1);

                        if (LGJH_LD_CODE == "1" || LGJH_LD_CODE == "2" || LGJH_LD_CODE == "3")
                        {
                            V_ZL_TYPE = "01";
                        }
                        else
                        {
                            if (LGJH_LD_CODE == "4")
                            {
                                V_ZL_TYPE = "02";
                            }
                            else
                            {
                                if (LGJH_LD_CODE == "A")
                                {
                                    V_ZL_TYPE = "03";
                                }
                                else
                                {
                                    V_ZL_TYPE = "未知转炉";
                                }
                            }
                        }

                        if (LGJH_LF_CODE == "0")
                        {
                            V_LF_TYPE = "01";

                        }
                        else
                        {
                            if (LGJH_LF_CODE == "1" || LGJH_LF_CODE == "2" || LGJH_LF_CODE == "4" || LGJH_LF_CODE == "5")
                            {
                                V_LF_TYPE = "02";
                            }
                            else
                            {
                                if (LGJH_LF_CODE == "3")
                                {
                                    V_LF_TYPE = "03";
                                }
                                else
                                {
                                    if (LGJH_LF_CODE == "4")
                                    {
                                        V_LF_TYPE = "04";
                                    }
                                    else
                                    {
                                        V_LF_TYPE = "未知LF路径";
                                    }
                                }
                            }
                        }

                        if (LGJH_RH_CODE == "0")
                        {
                            V_RH_TYPE = "01";
                        }
                        else
                        {
                            if (LGJH_RH_CODE == "1")
                            {
                                V_RH_TYPE = "02";
                            }
                            else
                            {
                                V_RH_TYPE = "未知RH";
                            }
                        }

                        if (LGJH_CC_CODE == "1" || LGJH_CC_CODE == "2")
                        {
                            V_CC_TYPE = "01";
                        }
                        else
                        {
                            if (LGJH_CC_CODE == "3" || LGJH_CC_CODE == "4")
                            {
                                V_CC_TYPE = "02";
                            }
                            else
                            {
                                if (LGJH_CC_CODE == "5")
                                {
                                    V_CC_TYPE = "03";

                                    if (V_LF_TYPE == "02" || V_LF_TYPE == "03" || V_LF_TYPE == "04")
                                    {
                                        V_LF_TYPE = "03";
                                    }
                                }
                                else
                                {
                                    if (LGJH_CC_CODE == "6")
                                    {
                                        V_CC_TYPE = "04";
                                    }
                                    else
                                    {
                                        if (LGJH_CC_CODE == "7")
                                        {
                                            V_CC_TYPE = "05";
                                        }
                                        else
                                        {
                                            V_CC_TYPE = "未知铸机";
                                        }
                                    }
                                }
                            }
                        }

                        string str_LGJH = "";

                        //if (LGJH_LF_CODE == "4")
                        //{
                        //    str_LGJH = dalLgjh.Get_LGJH(mod_order.C_FREE1, mod_order.C_FREE2, V_ZL_TYPE, V_RH_TYPE, V_CC_TYPE);
                        //}
                        //else
                        //{
                        //    str_LGJH = dalLgjh.Get_LGJH(mod_order.C_FREE1, mod_order.C_FREE2, V_ZL_TYPE, V_LF_TYPE, V_RH_TYPE, V_CC_TYPE);
                        //}


                        //if (string.IsNullOrEmpty(str_LGJH))
                        //{
                        //    TransactionHelper.RollBack();
                        //    //Transaction_MES.RollBack();
                        //    return "自由项1：" + mod_order.C_FREE1 + "；自由项2：" + mod_order.C_FREE2 + "没有炼钢记号";
                        //}

                        string c_std_code = mod_sms.C_STD_CODE;
                        if (mod_sms.C_FREE2 == "SWRH77B~普通要求-11-16")
                        {
                            c_std_code = "普通要求-11-16";
                        }
                        if (mod_sms.C_FREE2 == "SWRH77B~普通要求-5.5-10.5")
                        {
                            c_std_code = "普通要求-5.5-10.5";
                        }

                        DataTable dtLGJH = new DataTable();
                        if (LGJH_LF_CODE == "4")
                        {
                            dtLGJH = dalLgjh.Get_LGJH_Std(c_std_code, mod_sms.C_STL_GRD, V_ZL_TYPE, V_RH_TYPE, V_CC_TYPE).Tables[0];
                        }
                        else
                        {
                            dtLGJH = dalLgjh.Get_LGJH_Std(c_std_code, mod_sms.C_STL_GRD, V_ZL_TYPE, V_LF_TYPE, V_RH_TYPE, V_CC_TYPE).Tables[0];
                        }

                        if (dtLGJH.Rows.Count > 1)
                        {
                            TransactionHelper.RollBack();
                            return "标准：" + mod_sms.C_STD_CODE + "；钢种：" + mod_sms.C_STL_GRD + "找到多个炼钢记号，请核查！";
                        }
                        else if (dtLGJH.Rows.Count == 0)
                        {
                            TransactionHelper.RollBack();
                            return "标准：" + mod_sms.C_STD_CODE + "；钢种：" + mod_sms.C_STL_GRD + "没有找到炼钢记号！";
                        }

                        str_LGJH = dtLGJH.Rows[0]["C_STEEL_SIGN"].ToString();

                        #endregion

                        if (dalTppCastPlan.Update_Stove_Trans(dt_Plan_List.Rows[i]["C_ID"].ToString(), stove, str_LGJH))
                        {
                            string strCPLAN_TAPPING = "SELECT count(1) FROM CPLAN_TAPPING@CAP_MES T where t.heatid='" + stove + "' ";
                            string strCPLAN_TAPPING_ACT = "SELECT count(1) FROM CPLAN_TAPPING_ACT@CAP_MES T where t.heatid='" + stove + "' ";

                            int StoveCount_TAPPING = dalTppCastPlan.Get_Mes_Count(strCPLAN_TAPPING);
                            int StoveCount_TAPPING_ACT = dalTppCastPlan.Get_Mes_Count(strCPLAN_TAPPING_ACT);

                            if (StoveCount_TAPPING > 0 || StoveCount_TAPPING_ACT > 0)
                            {
                                TransactionHelper.RollBack();
                                return "MES已存在炉号：" + stove + " 不能重复下发！";
                            }

                            string V_CC_CODE = dalTbSta.Get_MES_CODE(dt_Plan_List.Rows[i]["C_CASTER_ID"].ToString());
                            string V_ZL_CODE = dalTbSta.Get_MES_CODE(dt_Plan_List.Rows[i]["C_BOF_ID"].ToString());
                            string V_LF_CODE = dalTbSta.Get_MES_CODE(dt_Plan_List.Rows[i]["C_LF_ID"].ToString());
                            string V_RH_CODE = dalTbSta.Get_MES_CODE(dt_Plan_List.Rows[i]["C_RH_ID"].ToString());

                            string V_PLANID = dalTppCastPlan.Get_Max_PLANID(V_CC_CODE);

                            if (V_PLANID == "")
                            {
                                V_PLANID = time.Year.ToString().Substring(2, 2) + V_CC_CODE + "000001";
                            }
                            else
                            {
                                if (V_PLANID.Substring(0, 2) != time.Year.ToString().Substring(2, 2))
                                {
                                    V_PLANID = time.Year.ToString().Substring(2, 2) + V_CC_CODE + "000001";
                                }
                                else
                                {
                                    V_PLANID = V_PLANID.Substring(0, 3) + (Convert.ToInt32(V_PLANID.Substring(3)) + 1).ToString();
                                }
                            }

                            string V_GUID = Guid.NewGuid().ToString("B").ToUpper();

                            //Mod_TMO_ORDER mod_Order = dalTmoOrder.GetModelByORDERNO(dt_Plan_List.Rows[i]["C_PLAN_ORD__ID"].ToString());
                            string V_GZ = mod_order.C_STL_GRD;
                            string V_WGT = mod_order.N_WGT.ToString();
                            string V_ORDER_DT = mod_order.D_MOD_DT.ToString();
                            string V_DELIVERY_DT = mod_order.D_DELIVERY_DT.ToString();

                            int V_ORDER_NUM = dalTppCastPlan.Get_Order_Num(dt_Plan_List.Rows[i]["C_PLAN_ORD__ID"].ToString());

                            if (V_ORDER_NUM == 0)
                            {
                                #region   插入CPLAN_ORDER

                                string s_route = dt_Plan_List.Rows[i]["C_REFINE_TYPE"].ToString();
                                if (V_ZL_CODE == "S25")
                                {
                                    if (s_route == "0")
                                    {
                                        s_route = "AC";
                                    }
                                    else
                                    {
                                        s_route = "A" + s_route;
                                    }
                                }
                                else
                                {
                                    if (s_route == "0")
                                    {
                                        s_route = "BC";
                                    }
                                    else
                                    {
                                        s_route = "B" + s_route;
                                    }
                                }

                                string sql_CPLAN_ORDER = "INSERT INTO CPLAN_ORDER@cap_mes";
                                sql_CPLAN_ORDER += "(GUID,";
                                sql_CPLAN_ORDER += " NAME,";
                                sql_CPLAN_ORDER += " PLANID,"; //计划订单号
                                sql_CPLAN_ORDER += " CONTRACTID,";
                                sql_CPLAN_ORDER += " STATUS,"; //状态
                                sql_CPLAN_ORDER += " PLANDEPT,";
                                sql_CPLAN_ORDER += " EXECUTEDEPT,";
                                sql_CPLAN_ORDER += " CREATEDATE,";
                                sql_CPLAN_ORDER += " PLANEXECUTEDATE,";
                                sql_CPLAN_ORDER += " ACTUALEXECUTEDATE,";
                                sql_CPLAN_ORDER += " PLANNER,";
                                sql_CPLAN_ORDER += " LENGTH,";
                                sql_CPLAN_ORDER += " WIDTH,";
                                sql_CPLAN_ORDER += " THICKNESS,";
                                sql_CPLAN_ORDER += " STEELGRADE,"; //钢种
                                sql_CPLAN_ORDER += " UNIT,";
                                sql_CPLAN_ORDER += " ASSIST_UNIT,";
                                sql_CPLAN_ORDER += " WEIGHT,"; //余量
                                sql_CPLAN_ORDER += " ASSISI_WEIGHT,";
                                sql_CPLAN_ORDER += " PLANREC_DATE,";
                                sql_CPLAN_ORDER += " REQUEST_DATE,";
                                sql_CPLAN_ORDER += " CORP,"; //公司
                                sql_CPLAN_ORDER += " FACTORY,"; //工厂
                                sql_CPLAN_ORDER += " WORK_CENTER,";
                                sql_CPLAN_ORDER += " CLIENT,";
                                sql_CPLAN_ORDER += " TECH_REQUEST,";//技术要求(自由项2)
                                sql_CPLAN_ORDER += " INSIDE_NOTE,";
                                sql_CPLAN_ORDER += " IMM_FLAG,";
                                sql_CPLAN_ORDER += " CASTERID,";
                                sql_CPLAN_ORDER += " NEW_BOF_FLAG,";
                                sql_CPLAN_ORDER += " PROTOCOL,";//制造标准\协议（执行标准）
                                sql_CPLAN_ORDER += " PRODUCESTD,"; // 制造标准（自由项1）
                                sql_CPLAN_ORDER += " PK_POID,"; //计划订单主键
                                sql_CPLAN_ORDER += " ACTWEIGHT,"; //实际投入量
                                sql_CPLAN_ORDER += " SPAREWEIGHT,";//剩余量
                                sql_CPLAN_ORDER += " MATERIALCODE,";//物料编码
                                sql_CPLAN_ORDER += " MATERIALCODE_ID,"; //物料编码id
                                sql_CPLAN_ORDER += " PRODUCT_ROUTE,";//工艺路径
                                sql_CPLAN_ORDER += " OTHER_TECH_REQUEST"; //其它要求
                                sql_CPLAN_ORDER += " )";
                                sql_CPLAN_ORDER += " values";
                                sql_CPLAN_ORDER += " ('" + V_GUID + "',";
                                sql_CPLAN_ORDER += " '',";
                                sql_CPLAN_ORDER += " '" + dt_Plan_List.Rows[i]["C_PLAN_ORD__ID"].ToString() + "',";//计划订单号
                                sql_CPLAN_ORDER += " '',";
                                sql_CPLAN_ORDER += " '14',"; //状态
                                sql_CPLAN_ORDER += " '',";
                                sql_CPLAN_ORDER += " '',";
                                sql_CPLAN_ORDER += " SYSDATE,";
                                sql_CPLAN_ORDER += " TO_DATE('1899/12/30 00:00:00', 'yyyy-mm-dd hh24:mi:ss'),";
                                sql_CPLAN_ORDER += " TO_DATE('1899/12/30 00:00:00', 'yyyy-mm-dd hh24:mi:ss'),";
                                sql_CPLAN_ORDER += " '',";
                                sql_CPLAN_ORDER += " '" + dt_Plan_List.Rows[i]["C_LENGTH"].ToString() + "',";
                                sql_CPLAN_ORDER += " '" + dt_Plan_List.Rows[i]["C_W_IDTH"].ToString() + "',";
                                sql_CPLAN_ORDER += " '" + dt_Plan_List.Rows[i]["C_THICKNESS"].ToString() + "',";
                                sql_CPLAN_ORDER += " '" + V_GZ + "',";//钢种
                                sql_CPLAN_ORDER += " '吨',";
                                sql_CPLAN_ORDER += " '',";
                                sql_CPLAN_ORDER += " '" + V_WGT + "',";//余量
                                sql_CPLAN_ORDER += " '0',";
                                sql_CPLAN_ORDER += " TO_DATE('" + V_ORDER_DT + "','yyyy-mm-dd hh24:mi:ss'),";
                                sql_CPLAN_ORDER += " TO_DATE('" + V_DELIVERY_DT + "','yyyy-mm-dd hh24:mi:ss'),";
                                sql_CPLAN_ORDER += " '1001',";//公司
                                sql_CPLAN_ORDER += " '1001NC10000000000669',";//工厂
                                sql_CPLAN_ORDER += " '',";
                                sql_CPLAN_ORDER += " '',";
                                sql_CPLAN_ORDER += " '" + mod_sms.C_FREE2 + "',";//技术要求(自由项2)
                                sql_CPLAN_ORDER += " '',";
                                sql_CPLAN_ORDER += " '',";
                                sql_CPLAN_ORDER += " '',";
                                sql_CPLAN_ORDER += " '',";
                                sql_CPLAN_ORDER += " '" + mod_sms.C_STD_CODE + "',";//制造标准\协议（执行标准）
                                sql_CPLAN_ORDER += " '" + mod_sms.C_FREE1 + "',";//制造标准（自由项1）
                                sql_CPLAN_ORDER += " '" + mod_order.C_ID + "',";//计划订单主键
                                sql_CPLAN_ORDER += " '',";//实际投入量
                                sql_CPLAN_ORDER += " '',";//剩余量
                                sql_CPLAN_ORDER += " '" + mod_Matrl_Main.C_MAT_CODE + "',";//物料编码
                                sql_CPLAN_ORDER += " '" + mod_Matrl_Main.C_PK_INVBASDOC + "',";//物料编码id
                                sql_CPLAN_ORDER += " '" + s_route + "',"; //工艺路径
                                sql_CPLAN_ORDER += " ''"; //其它要求
                                sql_CPLAN_ORDER += " ) ";

                                if (!dalTppCastPlan.Insert_Mes_Trans(sql_CPLAN_ORDER))
                                {
                                    TransactionHelper.RollBack();
                                    return "下发MES系统CPLAN_ORDER表时出错！";
                                }

                                #endregion
                            }

                            string str_NEW_BOF_FLAG = "0";
                            if (LGJH_LD_CODE == "4")
                            {
                                str_NEW_BOF_FLAG = "1";
                            }

                            string strN_Qua = "22";
                            if (LGJH_CC_CODE == "5")
                            {
                                strN_Qua = "18";
                            }


                            #region 插入CPLAN_CASTING

                            string sql_CPLAN_CASTING = "INSERT INTO CPLAN_CASTING@cap_mes";
                            sql_CPLAN_CASTING += " (GUID,";
                            sql_CPLAN_CASTING += " PLANID,"; //计划_ID
                            sql_CPLAN_CASTING += " CONTRACTID,";//合同_ID
                            sql_CPLAN_CASTING += " STATUS,";//状态
                            sql_CPLAN_CASTING += " PLANDEPT,";// 计划部门
                            sql_CPLAN_CASTING += " EXECUTEDEPT,"; //执行部门
                            sql_CPLAN_CASTING += " CREATEDATE,"; //创建时间
                            sql_CPLAN_CASTING += " PLANEXECUTEDATE,"; //计划执行时间
                            sql_CPLAN_CASTING += " ACTUALEXECUTEDATE,"; //实际执行时间
                            sql_CPLAN_CASTING += " PLANNER,"; //计划人
                            sql_CPLAN_CASTING += " CASTERID,";//连铸机
                            sql_CPLAN_CASTING += " LENGTH,"; //长度
                            sql_CPLAN_CASTING += " WIDTH,";//宽度
                            sql_CPLAN_CASTING += " THICKNESS,";//厚度
                            sql_CPLAN_CASTING += " PRE_STEELGRADEINDEX,"; //预定炼钢记号
                            sql_CPLAN_CASTING += " PRE_STEELGRADE,";//预定钢种
                            sql_CPLAN_CASTING += " REFINE_TYPE,";//工艺路线
                            sql_CPLAN_CASTING += " PRE_LOTNO,";//炉次
                            sql_CPLAN_CASTING += " PREHEATID,";//炉号
                            sql_CPLAN_CASTING += " AIM_TAPPED_WEIGHT,"; //计划重量
                            sql_CPLAN_CASTING += " PROC_SEQ,";//顺序
                            sql_CPLAN_CASTING += " PLAN_ORD_ID,";//计划订单号
                            sql_CPLAN_CASTING += " BLOOM_COUNT,";//数量
                            sql_CPLAN_CASTING += " AIM_TIME_CASTINGSTART,";//计划开始时间
                            sql_CPLAN_CASTING += " NEW_BOF_FLAG,"; //转炉标记
                            sql_CPLAN_CASTING += " BOFID,"; //转炉
                            sql_CPLAN_CASTING += " LFID,";//LF
                            sql_CPLAN_CASTING += " RHID,";//RH
                            sql_CPLAN_CASTING += " ACTWEIGHT,";//实际重量
                            sql_CPLAN_CASTING += " AODID,"; //AOD
                            sql_CPLAN_CASTING += " MATERIALCODE_ID,"; //物料编码主键
                            sql_CPLAN_CASTING += " MATERIALCODE"; //物料编码
                            sql_CPLAN_CASTING += " )";
                            sql_CPLAN_CASTING += " VALUES";
                            sql_CPLAN_CASTING += " ('" + V_GUID + "',";
                            sql_CPLAN_CASTING += " '" + V_PLANID + "',";//计划_ID
                            sql_CPLAN_CASTING += " '',"; //合同_ID
                            sql_CPLAN_CASTING += " '11',";//状态
                            sql_CPLAN_CASTING += " '',"; //计划部门
                            sql_CPLAN_CASTING += " '',";//执行部门
                            sql_CPLAN_CASTING += " SYSDATE,"; //创建时间
                            sql_CPLAN_CASTING += " TO_DATE('1899/12/30 00:00:00','yyyy-mm-dd hh24:mi:ss'),"; //计划执行时间
                            sql_CPLAN_CASTING += " TO_DATE('1899/12/30 00:00:00','yyyy-mm-dd hh24:mi:ss'),"; //实际执行时间
                            sql_CPLAN_CASTING += " '14644',"; //计划人
                            sql_CPLAN_CASTING += " '" + V_CC_CODE + "',";//连铸机
                            sql_CPLAN_CASTING += " '" + dt_Plan_List.Rows[i]["C_LENGTH"].ToString() + "',"; //长度
                            sql_CPLAN_CASTING += " '" + dt_Plan_List.Rows[i]["C_W_IDTH"].ToString() + "',";//宽度
                            sql_CPLAN_CASTING += " '" + dt_Plan_List.Rows[i]["C_THICKNESS"].ToString() + "',"; //厚度
                            sql_CPLAN_CASTING += " '" + str_LGJH + "',";//预定炼钢记号
                            sql_CPLAN_CASTING += " '" + dt_Plan_List.Rows[i]["C_PRE_STEELGRADE"].ToString() + "',";//预定钢种
                            sql_CPLAN_CASTING += " '" + dt_Plan_List.Rows[i]["C_REFINE_TYPE"].ToString() + "',";//工艺路线
                            sql_CPLAN_CASTING += " '',"; //炉次
                            sql_CPLAN_CASTING += " '" + V_PLANID + "',";//炉号
                            sql_CPLAN_CASTING += " '" + dt_Plan_List.Rows[i]["N_AIM_TAPPED_WEIGHT"].ToString() + "',"; //计划重量
                            sql_CPLAN_CASTING += " '0',";//顺序
                            sql_CPLAN_CASTING += " '" + dt_Plan_List.Rows[i]["C_PLAN_ORD__ID"].ToString() + "',";//计划订单号
                            sql_CPLAN_CASTING += " '" + strN_Qua + "',";//数量
                            sql_CPLAN_CASTING += " TO_DATE('" + dt_Plan_List.Rows[i]["D_AIM_CASTERARRIVAL_TIME"].ToString() + "','yyyy-mm-dd hh24:mi:ss'),";//计划开始时间
                            sql_CPLAN_CASTING += " '" + str_NEW_BOF_FLAG + "',"; //转炉标记
                            sql_CPLAN_CASTING += " '" + V_ZL_CODE + "',"; //转炉
                            sql_CPLAN_CASTING += " '" + V_LF_CODE + "',";//LF
                            sql_CPLAN_CASTING += " '" + V_RH_CODE + "',";//RH
                            sql_CPLAN_CASTING += " '" + dt_Plan_List.Rows[i]["N_AIM_TAPPED_WEIGHT"].ToString() + "',";//实际重量
                            sql_CPLAN_CASTING += " '',";//AOD
                            sql_CPLAN_CASTING += " '" + mod_Matrl_Main.C_PK_INVBASDOC + "',"; //物料编码主键
                            sql_CPLAN_CASTING += " '" + mod_Matrl_Main.C_MAT_CODE + "'"; //物料编码
                            sql_CPLAN_CASTING += " )";

                            if (!dalTppCastPlan.Insert_Mes_Trans(sql_CPLAN_CASTING))
                            {
                                TransactionHelper.RollBack();
                                return "下发MES系统CPLAN_CASTING表时出错！";
                            }

                            #endregion


                            #region 插入CPLAN_TAPPING

                            string str_CPLAN_TAPPING = "  INSERT INTO CPLAN_TAPPING@cap_mes";
                            str_CPLAN_TAPPING += " (GUID,";
                            str_CPLAN_TAPPING += " PLANID,"; //计划编号
                            str_CPLAN_TAPPING += " CONTRACTID,"; //合同编号
                            str_CPLAN_TAPPING += " STATUS,";
                            str_CPLAN_TAPPING += " PLANDEPT,"; //计划部门
                            str_CPLAN_TAPPING += " EXECUTEDEPT,";//执行部门
                            str_CPLAN_TAPPING += " CREATEDATE,"; //创建时间
                            str_CPLAN_TAPPING += " PLANEXECUTEDATE,"; //计划执行时间
                            str_CPLAN_TAPPING += " ACTUALEXECUTEDATE,";//实际执行时间
                            str_CPLAN_TAPPING += " PLANNER,";//计划人
                            str_CPLAN_TAPPING += " PRE_LOTNO,"; //炉次
                            str_CPLAN_TAPPING += " PREHEATID,";//预定炉号
                            str_CPLAN_TAPPING += " PRE_STEELGRADEINDEX,"; //预定炼钢记号
                            str_CPLAN_TAPPING += " PRE_STEELGRADE,"; //预定钢种
                            str_CPLAN_TAPPING += " AIM_TAPPED_WEIGHT,";///目标出钢重量
                            str_CPLAN_TAPPING += " CASTERID,";//铸机号
                            str_CPLAN_TAPPING += " BOFID,"; //转炉炉座
                            str_CPLAN_TAPPING += " LFID,"; //精炼炉座
                            str_CPLAN_TAPPING += " RHID,"; //RH炉座
                            str_CPLAN_TAPPING += " BOF_STATUS,"; //转炉状态01未执02兑铁03吹炼开始04出钢开05出钢结束
                            str_CPLAN_TAPPING += " LF_STATUS,"; //精炼炉状态01未执行02进站03处理开始04处理结束05出站
                            str_CPLAN_TAPPING += " RH_STATUS,"; //RH炉状态01未执行02进站03处理开始04处理结束05出站
                            str_CPLAN_TAPPING += " CASTER_STATUS,"; //铸机状态01未执行02大包到达03大包开浇04浇铸结束
                            str_CPLAN_TAPPING += " SIDE_STATUS,";//转炉炉后状态01未执行02处理开始03处理结束
                            str_CPLAN_TAPPING += " HEATID,";//炉次
                            str_CPLAN_TAPPING += " CASTING_NO,"; //铸机号
                            str_CPLAN_TAPPING += " CASTING_HEAT_CNT,"; //？
                            str_CPLAN_TAPPING += " AIM_TIME_IRONPREPARED,"; //铁水计划时间
                            str_CPLAN_TAPPING += " AIM_TIME_BOFSTART,"; //转炉开始计划时间
                            str_CPLAN_TAPPING += " AIM_TIME_BOFTAPPED,"; //转炉结束计划时间
                            str_CPLAN_TAPPING += " AIM_TIME_TAPPEDSIDEEND,"; //转炉离开计划时间
                            str_CPLAN_TAPPING += " AIM_TIME_LFARRIVAL,"; //LF到达计划时间
                            str_CPLAN_TAPPING += " AIM_TIME_LFSTART,";//LF开始计划时间
                            str_CPLAN_TAPPING += " AIM_TIME_LFEND,";//LF结束计划时间
                            str_CPLAN_TAPPING += " AIM_TIME_LFLEAVE,";//LF离开计划时间
                            str_CPLAN_TAPPING += " AIM_TIME_RHARRIVAL,"; //RH到达计划时间
                            str_CPLAN_TAPPING += " AIM_TIME_RHSTART,"; //RH开始计划时间
                            str_CPLAN_TAPPING += " AIM_TIME_RHEND,"; //RH结束计划时间
                            str_CPLAN_TAPPING += " AIM_TIME_RHLEAVE,"; //RH离开计划时间
                            str_CPLAN_TAPPING += " AIM_TIME_CASTERARRIVAL,"; //连铸到达计划时间
                            str_CPLAN_TAPPING += " AIM_TIME_CASTINGSTART,"; //连铸开始计划时间
                            str_CPLAN_TAPPING += " AIM_TIME_CASTINGEND,"; //连铸结束计划时间
                            str_CPLAN_TAPPING += " FIR_HEAT_FLAG,"; //加热炉标志
                            str_CPLAN_TAPPING += " DIV_HEATID,"; //加热炉
                            str_CPLAN_TAPPING += " TEAMID,"; //班组
                            str_CPLAN_TAPPING += " SHIFTID,"; //班别
                            str_CPLAN_TAPPING += " STEELGRADEINDEX,"; //炼钢记号
                            str_CPLAN_TAPPING += " STEELGRADE,"; //钢种
                            str_CPLAN_TAPPING += " PLAN_ORD_ID,"; //计划订单号
                            str_CPLAN_TAPPING += " HOT_SEND_FLAG,"; //热送标志
                            str_CPLAN_TAPPING += " STEEL_RETURN_FLAG,"; //回炉标志
                            str_CPLAN_TAPPING += " STEEL_BACK_FLAG,"; //返送标志
                            str_CPLAN_TAPPING += " TREAT_SEQ,"; //顺序
                            str_CPLAN_TAPPING += " DESTITATION,"; //？
                            str_CPLAN_TAPPING += " NEW_BOF_FLAG,"; //转炉标记
                            str_CPLAN_TAPPING += " REFINE_TYPE,"; //工艺路径
                            str_CPLAN_TAPPING += " LENGTH,"; //长度
                            str_CPLAN_TAPPING += " WIDTH,"; //宽度
                            str_CPLAN_TAPPING += " THICKNESS,"; //厚度
                            str_CPLAN_TAPPING += " AODID,"; //AOD炉炉座
                            str_CPLAN_TAPPING += " DEPID,"; //熔化炉炉座
                            str_CPLAN_TAPPING += " RHLID,"; //转炉后
                            str_CPLAN_TAPPING += " DEP_STATUS,"; //熔化炉状态
                            str_CPLAN_TAPPING += " RHL_STATUS,"; //转炉后状态
                            str_CPLAN_TAPPING += " MATERIALCODE_ID,"; //物料编码主键
                            str_CPLAN_TAPPING += " AOD_STATUS"; //AOD炉状态
                            str_CPLAN_TAPPING += " )";
                            str_CPLAN_TAPPING += " VALUES";
                            str_CPLAN_TAPPING += " ('" + V_GUID + "',";
                            str_CPLAN_TAPPING += " '" + V_PLANID + "',"; //计划编号
                            str_CPLAN_TAPPING += " '',"; //合同编号
                            str_CPLAN_TAPPING += " '10',"; //
                            str_CPLAN_TAPPING += " '',"; //计划部门
                            str_CPLAN_TAPPING += " '',"; //执行部门
                            str_CPLAN_TAPPING += " SYSDATE,"; //创建时间
                            str_CPLAN_TAPPING += " to_date('1899/12/30 00:00:00', 'yyyy-mm-dd hh24:mi:ss'),"; //计划执行时间
                            str_CPLAN_TAPPING += " to_date('1899/12/30 00:00:00', 'yyyy-mm-dd hh24:mi:ss'),"; //实际执行时间
                            str_CPLAN_TAPPING += " '14644',"; //计划人
                            str_CPLAN_TAPPING += " '" + dt_Plan_List.Rows[i]["C_PRE_LOTNO"].ToString() + "',"; //炉次
                            str_CPLAN_TAPPING += " '" + V_PLANID + "',"; //预定炉号
                            str_CPLAN_TAPPING += " '" + str_LGJH + "',"; //预定炼钢记号
                            str_CPLAN_TAPPING += " '" + dt_Plan_List.Rows[i]["C_PRE_STEELGRADE"].ToString() + "',"; //预定钢种
                            str_CPLAN_TAPPING += " '" + dt_Plan_List.Rows[i]["N_AIM_TAPPED_WEIGHT"].ToString() + "',"; //目标出钢重量
                            str_CPLAN_TAPPING += " '" + V_CC_CODE + "',"; //铸机号
                            str_CPLAN_TAPPING += " '" + V_ZL_CODE + "',"; //转炉炉座
                            str_CPLAN_TAPPING += " '" + V_LF_CODE + "',"; //精炼炉座
                            str_CPLAN_TAPPING += " '" + V_RH_CODE + "',"; //RH炉座
                            str_CPLAN_TAPPING += " '" + dt_Plan_List.Rows[i]["N_BOF_STATUS"].ToString() + "',"; //转炉状态01未执02兑铁03吹炼开始04出钢开05出钢结束
                            str_CPLAN_TAPPING += " '" + dt_Plan_List.Rows[i]["N_LF_STATUS"].ToString() + "',"; //精炼炉状态01未执行02进站03处理开始04处理结束05出站
                            str_CPLAN_TAPPING += " '" + dt_Plan_List.Rows[i]["N_RH_STATUS"].ToString() + "',"; //RH炉状态01未执行02进站03处理开始04处理结束05出站
                            str_CPLAN_TAPPING += " '" + dt_Plan_List.Rows[i]["N_CASTER_STATUS"].ToString() + "',"; //铸机状态01未执行02大包到达03大包开浇04浇铸结束
                            str_CPLAN_TAPPING += " '" + dt_Plan_List.Rows[i]["N_S_IDE_STATUS"].ToString() + "',"; //转炉炉后状态01未执行02处理开始03处理结束
                            str_CPLAN_TAPPING += " '" + stove + "',"; //炉次
                            str_CPLAN_TAPPING += " '" + dt_Plan_List.Rows[i]["C_CASTER_NO"].ToString() + "',"; //铸机号
                            str_CPLAN_TAPPING += " '0',"; //？
                            str_CPLAN_TAPPING += " to_date('" + dt_Plan_List.Rows[i]["D_AIM_IRONPREPARED_TIME"].ToString() + "', 'yyyy-mm-dd hh24:mi:ss'),"; //铁水计划时间
                            str_CPLAN_TAPPING += " to_date('" + dt_Plan_List.Rows[i]["D_AIM_BOFSTART_TIME"].ToString() + "', 'yyyy-mm-dd hh24:mi:ss'),"; //转炉开始计划时间
                            str_CPLAN_TAPPING += " to_date('" + dt_Plan_List.Rows[i]["D_AIM_BOFTAPPED_TIME"].ToString() + "', 'yyyy-mm-dd hh24:mi:ss'),"; //转炉结束计划时间
                            str_CPLAN_TAPPING += " to_date('" + dt_Plan_List.Rows[i]["D_AIM_TAPPEDSIDEEND_TIME"].ToString() + "', 'yyyy-mm-dd hh24:mi:ss'),"; //转炉离开计划时间
                            str_CPLAN_TAPPING += " to_date('" + dt_Plan_List.Rows[i]["D_AIM_LFARRIVAL_TIME"].ToString() + "', 'yyyy-mm-dd hh24:mi:ss'),"; //LF到达计划时间
                            str_CPLAN_TAPPING += " to_date('" + dt_Plan_List.Rows[i]["D_AIM_LFSTART_TIME"].ToString() + "', 'yyyy-mm-dd hh24:mi:ss'),"; //LF开始计划时间
                            str_CPLAN_TAPPING += " to_date('" + dt_Plan_List.Rows[i]["D_AIM_LFEND_TIME"].ToString() + "', 'yyyy-mm-dd hh24:mi:ss'),"; //LF结束计划时间
                            str_CPLAN_TAPPING += " to_date('" + dt_Plan_List.Rows[i]["D_AIM_LFLEAVE_TIME"].ToString() + "', 'yyyy-mm-dd hh24:mi:ss'),"; //LF离开计划时间
                            str_CPLAN_TAPPING += " to_date('" + dt_Plan_List.Rows[i]["D_AIM_RHARRIVAL_TIME"].ToString() + "', 'yyyy-mm-dd hh24:mi:ss'),"; //RH到达计划时间
                            str_CPLAN_TAPPING += " to_date('" + dt_Plan_List.Rows[i]["D_AIM_RHSTART_TIME"].ToString() + "', 'yyyy-mm-dd hh24:mi:ss'),"; //RH开始计划时间
                            str_CPLAN_TAPPING += " to_date('" + dt_Plan_List.Rows[i]["D_AIM_RHEND_TIME"].ToString() + "', 'yyyy-mm-dd hh24:mi:ss'),"; //RH结束计划时间
                            str_CPLAN_TAPPING += " to_date('" + dt_Plan_List.Rows[i]["D_AIM_RHLEAVE_TIME"].ToString() + "', 'yyyy-mm-dd hh24:mi:ss'),"; //RH离开计划时间
                            str_CPLAN_TAPPING += " to_date('" + dt_Plan_List.Rows[i]["D_AIM_CASTERARRIVAL_TIME"].ToString() + "', 'yyyy-mm-dd hh24:mi:ss'),"; //连铸到达计划时间
                            str_CPLAN_TAPPING += " to_date('" + dt_Plan_List.Rows[i]["D_AIM_CASTINGSTART_TIME"].ToString() + "', 'yyyy-mm-dd hh24:mi:ss'),"; //连铸开始计划时间
                            str_CPLAN_TAPPING += " to_date('" + dt_Plan_List.Rows[i]["D_AIM_CASTINGEND_TIME"].ToString() + "', 'yyyy-mm-dd hh24:mi:ss'),"; //连铸结束计划时间
                            str_CPLAN_TAPPING += " '" + dt_Plan_List.Rows[i]["C_FIR_HEAT_FLAG"].ToString() + "',"; //加热炉标志
                            str_CPLAN_TAPPING += " '" + dt_Plan_List.Rows[i]["DIV_HEAT_ID"].ToString() + "',"; //加热炉
                            str_CPLAN_TAPPING += " '" + dt_Plan_List.Rows[i]["C_TEAM_ID"].ToString() + "',"; //班组
                            str_CPLAN_TAPPING += " '" + dt_Plan_List.Rows[i]["C_SHIFT_ID"].ToString() + "',"; //班别
                            str_CPLAN_TAPPING += " '" + str_LGJH + "',"; //炼钢记号
                            str_CPLAN_TAPPING += " '" + dt_Plan_List.Rows[i]["C_PRE_STEELGRADE"].ToString() + "',"; //钢种
                            str_CPLAN_TAPPING += " '" + dt_Plan_List.Rows[i]["C_PLAN_ORD__ID"].ToString() + "',"; //计划订单号
                            str_CPLAN_TAPPING += " '" + dt_Plan_List.Rows[i]["C_HOT_SEND_FLAG"].ToString() + "',"; //热送标志
                            str_CPLAN_TAPPING += " '" + dt_Plan_List.Rows[i]["C_STEEL_RETURN_FLAG"].ToString() + "',"; //回炉标志
                            str_CPLAN_TAPPING += " '" + dt_Plan_List.Rows[i]["C_STEEL_BACK_FLAG"].ToString() + "',"; //返送标志
                            str_CPLAN_TAPPING += " '" + dt_Plan_List.Rows[i]["C_TREAT_SEQ"].ToString() + "',"; //顺序
                            str_CPLAN_TAPPING += " '" + dt_Plan_List.Rows[i]["C_DESTITATION"].ToString() + "',"; //？
                            str_CPLAN_TAPPING += " '" + str_NEW_BOF_FLAG + "',"; //转炉标记
                            str_CPLAN_TAPPING += " '" + dt_Plan_List.Rows[i]["C_REFINE_TYPE"].ToString() + "',"; //工艺路径
                            str_CPLAN_TAPPING += " '" + dt_Plan_List.Rows[i]["C_LENGTH"].ToString() + "',"; //长度
                            str_CPLAN_TAPPING += " '" + dt_Plan_List.Rows[i]["C_W_IDTH"].ToString() + "',"; //宽度
                            str_CPLAN_TAPPING += " '" + dt_Plan_List.Rows[i]["C_THICKNESS"].ToString() + "',"; //厚度
                            str_CPLAN_TAPPING += " '',"; //AOD炉炉座
                            str_CPLAN_TAPPING += " '',"; //熔化炉炉座
                            str_CPLAN_TAPPING += " '',"; //转炉后
                            str_CPLAN_TAPPING += " '" + dt_Plan_List.Rows[i]["C_DEP_STATUS"].ToString() + "',"; //熔化炉状态
                            str_CPLAN_TAPPING += " '" + dt_Plan_List.Rows[i]["C_RHL_STATUS"].ToString() + "',"; //转炉后状态

                            str_CPLAN_TAPPING += " '" + mod_Matrl_Main.C_PK_INVBASDOC + "',"; //转炉后状态

                            str_CPLAN_TAPPING += " '" + dt_Plan_List.Rows[i]["C_AOD_STATUS"].ToString() + "'";//AOD炉状态
                            str_CPLAN_TAPPING += " )";

                            if (!dalTppCastPlan.Insert_Mes_Trans(str_CPLAN_TAPPING))
                            {
                                TransactionHelper.RollBack();
                                return "下发MES系统CPLAN_TAPPING表时出错";
                            }

                            #endregion


                            #region 插入CPLAN_TAPPING_ACT

                            string str_CPLAN_TAPPING_ACT = " INSERT INTO CPLAN_TAPPING_ACT@cap_mes";
                            str_CPLAN_TAPPING_ACT += " (GUID,";
                            str_CPLAN_TAPPING_ACT += " PREHEATID,";//预定炉号
                            str_CPLAN_TAPPING_ACT += " CASTERID,";//铸机号
                            str_CPLAN_TAPPING_ACT += " HEATID,"; //炉次
                            str_CPLAN_TAPPING_ACT += " LF_TREATNO,"; //精炼处理号
                            str_CPLAN_TAPPING_ACT += " RH_TREATNO,";//RH处理号
                            str_CPLAN_TAPPING_ACT += " CASTER_TREATNO,"; //浇铸号
                            str_CPLAN_TAPPING_ACT += " ACT_TIME_IRONPREPARED,";//铁水实际时间
                            str_CPLAN_TAPPING_ACT += " ACT_TIME_BOFSTART,"; //转炉开始实际时间
                            str_CPLAN_TAPPING_ACT += " ACT_TIME_BOFTAPPED,"; //转炉结束实际时间
                            str_CPLAN_TAPPING_ACT += " ACT_TIME_TAPPEDSIDEEND,";//转炉离开实际时间
                            str_CPLAN_TAPPING_ACT += " ACT_TIME_LFARRIVAL,";//LF到达实际时间
                            str_CPLAN_TAPPING_ACT += " ACT_TIME_LFSTART,";//LF开始实际时间
                            str_CPLAN_TAPPING_ACT += " ACT_TIME_LFEND,";//LF结束实际时间
                            str_CPLAN_TAPPING_ACT += " ACT_TIME_LFLEAVE,"; //LF离开实际时间
                            str_CPLAN_TAPPING_ACT += " ACT_TIME_RHARRIVAL,"; //RH到达实际时间
                            str_CPLAN_TAPPING_ACT += " ACT_TIME_RHSTART,";//RH开始实际时间
                            str_CPLAN_TAPPING_ACT += " ACT_TIME_RHEND,";//RH结束实际时间
                            str_CPLAN_TAPPING_ACT += " ACT_TIME_RHLEAVE,";//RH离开实际时间
                            str_CPLAN_TAPPING_ACT += " ACT_TIME_CASTERARRIVAL,"; //连铸到达实际时间
                            str_CPLAN_TAPPING_ACT += " ACT_TIME_CASTINGSTART,";//连铸开始实际时间
                            str_CPLAN_TAPPING_ACT += " ACT_TIME_CASTINGEND,";//连铸结束实际时间
                            str_CPLAN_TAPPING_ACT += " CREATEDATE,"; //创建实际时间
                            str_CPLAN_TAPPING_ACT += " BOFID,";//转炉炉座
                            str_CPLAN_TAPPING_ACT += " LFID,";//精炼炉座
                            str_CPLAN_TAPPING_ACT += " RHID,";//RH炉座
                            //str_CPLAN_TAPPING_ACT += " MARTIALCODE_ID,"; //物料编码主键
                            str_CPLAN_TAPPING_ACT += " AODID"; //AOD炉座
                            str_CPLAN_TAPPING_ACT += " )";
                            str_CPLAN_TAPPING_ACT += " VALUES";
                            str_CPLAN_TAPPING_ACT += " ('" + V_GUID + "',";
                            str_CPLAN_TAPPING_ACT += " '" + V_PLANID + "',"; //预定炉号
                            str_CPLAN_TAPPING_ACT += " '" + V_CC_CODE + "',"; //铸机号
                            str_CPLAN_TAPPING_ACT += " '" + stove + "',"; //炉次
                            str_CPLAN_TAPPING_ACT += " '',"; //精炼处理号
                            str_CPLAN_TAPPING_ACT += " '',"; //RH处理号
                            str_CPLAN_TAPPING_ACT += " '',"; //浇铸号
                            str_CPLAN_TAPPING_ACT += " to_date('1899/12/30 00:00:00','yyyy-mm-dd hh24:mi:ss'),"; //铁水实际时间
                            str_CPLAN_TAPPING_ACT += " to_date('1899/12/30 00:00:00','yyyy-mm-dd hh24:mi:ss'),"; //转炉开始实际时间
                            str_CPLAN_TAPPING_ACT += " to_date('1899/12/30 00:00:00','yyyy-mm-dd hh24:mi:ss'),"; //转炉结束实际时间
                            str_CPLAN_TAPPING_ACT += " to_date('1899/12/30 00:00:00','yyyy-mm-dd hh24:mi:ss'),"; //转炉离开实际时间
                            str_CPLAN_TAPPING_ACT += " to_date('1899/12/30 00:00:00','yyyy-mm-dd hh24:mi:ss'),"; //LF到达实际时间
                            str_CPLAN_TAPPING_ACT += " to_date('1899/12/30 00:00:00','yyyy-mm-dd hh24:mi:ss'),"; //LF开始实际时间
                            str_CPLAN_TAPPING_ACT += " to_date('1899/12/30 00:00:00','yyyy-mm-dd hh24:mi:ss'),"; //LF结束实际时间
                            str_CPLAN_TAPPING_ACT += " to_date('1899/12/30 00:00:00','yyyy-mm-dd hh24:mi:ss'),"; //LF离开实际时间
                            str_CPLAN_TAPPING_ACT += " to_date('1899/12/30 00:00:00','yyyy-mm-dd hh24:mi:ss'),"; //RH到达实际时间
                            str_CPLAN_TAPPING_ACT += " to_date('1899/12/30 00:00:00','yyyy-mm-dd hh24:mi:ss'),"; //RH开始实际时间
                            str_CPLAN_TAPPING_ACT += " to_date('1899/12/30 00:00:00','yyyy-mm-dd hh24:mi:ss'),"; //RH结束实际时间
                            str_CPLAN_TAPPING_ACT += " to_date('1899/12/30 00:00:00','yyyy-mm-dd hh24:mi:ss'),"; //RH离开实际时间
                            str_CPLAN_TAPPING_ACT += " to_date('1899/12/30 00:00:00','yyyy-mm-dd hh24:mi:ss'),"; //连铸到达实际时间
                            str_CPLAN_TAPPING_ACT += " to_date('1899/12/30 00:00:00','yyyy-mm-dd hh24:mi:ss'),"; //连铸开始实际时间
                            str_CPLAN_TAPPING_ACT += " to_date('1899/12/30 00:00:00','yyyy-mm-dd hh24:mi:ss'),"; //连铸结束实际时间
                            str_CPLAN_TAPPING_ACT += " SYSDATE,"; //创建实际时间
                            str_CPLAN_TAPPING_ACT += " '" + V_ZL_CODE + "',"; //转炉炉座
                            str_CPLAN_TAPPING_ACT += " '" + V_LF_CODE + "',"; //精炼炉座
                            str_CPLAN_TAPPING_ACT += " '" + V_RH_CODE + "',"; //RH炉座
                                                                              //  str_CPLAN_TAPPING_ACT += " '" + mod_Matrl_Main.C_PK_INVBASDOC + "',"; //物料编码主键
                            str_CPLAN_TAPPING_ACT += " ''"; //AOD炉座
                            str_CPLAN_TAPPING_ACT += " )";

                            if (!dalTppCastPlan.Insert_Mes_Trans(str_CPLAN_TAPPING_ACT))
                            {
                                TransactionHelper.RollBack();
                                return "下发MES系统CPLAN_TAPPING_ACT表时出错";
                            }

                            #endregion


                            #region 更新TPP_CAST_PLAN

                            if (!dalTppCastPlan.Update_Plan_State_Trans(dt_Plan_List.Rows[i]["C_ID"].ToString(), V_PLANID))
                            {
                                TransactionHelper.RollBack();
                                return "更新炉次计划信息表TPP_CAST_PLAN失败！";
                            }

                            #endregion

                            if (!dalTspPlanSms.Update_State_XF_Trans(dt_Plan_List.Rows[i]["C_PLAN_ID"].ToString()))
                            {
                                TransactionHelper.RollBack();
                                return "更新炼钢计划状态失败！";
                            }

                            Mod_TB_LG_PLAN_LOG modLog = new Mod_TB_LG_PLAN_LOG();
                            modLog.C_IP = GetLocalIP();
                            modLog.C_STOVE = stove;
                            modLog.C_PLAN_ID = mod_sms.C_ID;
                            modLog.C_ORDER_NO = mod_order.C_ORDER_NO;
                            modLog.C_MES_PLAN_ID = V_PLANID;
                            modLog.C_LD_DESC = dt_Plan_List.Rows[i]["C_LD_DESC"].ToString();
                            modLog.C_LF_DESC = dt_Plan_List.Rows[i]["C_LF_DESC"].ToString();
                            modLog.C_RH_DESC = dt_Plan_List.Rows[i]["C_RH_DESC"].ToString();
                            modLog.C_CC_DESC = dt_Plan_List.Rows[i]["C_CC_DESC"].ToString();
                            modLog.C_EMP_ID = strUserID;
                            modLog.D_MOD_DT = time;
                            modLog.C_REMARK = "下发";

                            if (!dalTbLgPlanLog.Add_Trans(modLog))
                            {
                                TransactionHelper.RollBack();
                                return "添加操作日志失败！";
                            }

                        }
                        else
                        {
                            TransactionHelper.RollBack();
                            return "更新炉号和炼钢记号失败！";
                        }

                        #region 上传A1给NC

                        string strSql = "select count(1) from XGERP50.mm_po@cap_erp t  where t.dr = 0 and t.zyx5 = '" + mod_order.C_ID + "' ";
                        int NC_Count = dalTppCastPlan.Get_NC_Count(strSql);

                        if (NC_Count == 0)
                        {
                            string result_A1 = dalInterface_Slab_A1.SendXml_SLAB_A1(strUrl, mod_sms.C_ID, stove);//上传A1

                            if (result_A1 != "1")
                            {
                                TransactionHelper.RollBack();
                                return result_A1;
                            }
                        }

                        #endregion
                    }

                    TransactionHelper.Commit();
                }
                else
                {
                    TransactionHelper.RollBack();
                    return "没有获取到需要下发的计划！";
                }
            }
            catch (Exception ex)
            {
                TransactionHelper.RollBack();
                return ex.Message;
            }

            return result;
        }


        /// <summary>
        /// 修改工艺路线
        /// </summary>
        /// <param name="new_ld_id">新转炉id</param>
        /// <param name="new_lf_id">新精炼id</param>
        /// <param name="new_rh_id">新真空id</param>
        /// <param name="new_cc_id">新连铸id</param>
        /// <returns></returns>
        public string UpdateGYLX(string new_ld_id, string new_lf_id, string new_rh_id, string new_cc_id)
        {
            string result = "1";
            try
            {
                TransactionHelper.BeginTransaction();

                string strUserID = RV.UI.UserInfo.userID;
                DateTime time = RV.UI.ServerTime.timeNow();

                DataTable dt_List = dalTppCastPlan.Get_List(new_cc_id).Tables[0];//获取需要下发到MES的计划


                if (dt_List.Rows.Count > 0)
                {
                    for (int i = 0; i < dt_List.Rows.Count; i++)
                    {
                        if (!dalTppCastPlan.delete_CAST_PLAN_Trans(dt_List.Rows[i]["C_ID"].ToString()))
                        {
                            TransactionHelper.RollBack();
                            return "0";
                        }

                        if (!dalTspPlanSms.Update_sta_Trans(dt_List.Rows[i]["C_PLAN_ID"].ToString(), new_ld_id, new_lf_id, new_rh_id))
                        {
                            TransactionHelper.RollBack();
                            return "0";
                        }
                    }

                    #region 重新生成工序计划

                    DataTable dt_Plan_List = dalTspPlanSms.Get_Plan_List_Back_Trans(new_cc_id).Tables[0];//未生成工序计划的连铸计划

                    bool flag = true;

                    if (dt_Plan_List.Rows.Count > 0)
                    {
                        DateTime? V_START_ZL;
                        DateTime? V_End_ZL;
                        DateTime? V_End_ZL_LEAVE;
                        DateTime? V_START_LF;
                        DateTime? V_End_LF;
                        DateTime? V_START_RH;
                        DateTime? V_End_RH;
                        double V_TIME_YL;
                        string V_RH_ID;
                        string V_LF_ID;
                        string V_LD_ID;
                        string V_CC_ID;
                        double V_CN;
                        string V_TYPE;

                        for (int i = 0; i < dt_Plan_List.Rows.Count; i++)
                        {
                            V_START_ZL = null;
                            V_End_ZL = null;
                            V_End_ZL_LEAVE = null;
                            V_START_LF = null;
                            V_End_LF = null;
                            V_START_RH = null;
                            V_End_RH = null;
                            V_TIME_YL = 0;
                            V_RH_ID = "";
                            V_LF_ID = "";
                            V_LD_ID = "";
                            V_CC_ID = "";
                            V_CN = 0;
                            V_TYPE = "";

                            Mod_TMO_ORDER mod_Order = dalTmoOrder.GetModel(dt_Plan_List.Rows[i]["C_ORDER_NO"].ToString());

                            V_RH_ID = dt_Plan_List.Rows[i]["C_RH_ID"].ToString();
                            V_LF_ID = dt_Plan_List.Rows[i]["C_LF_ID"].ToString();
                            V_LD_ID = dt_Plan_List.Rows[i]["C_ZL_ID"].ToString();
                            V_CC_ID = dt_Plan_List.Rows[i]["C_CCM_ID"].ToString();

                            if (mod_Order != null)
                            {
                                V_CN = Convert.ToDouble(mod_Order.N_MACH_WGT_CCM);

                                if (V_CN == 0)
                                {
                                    V_CN = 1;
                                }

                                V_TIME_YL = Convert.ToDouble(dt_Plan_List.Rows[i]["N_SLAB_WGT"].ToString()) / V_CN;

                                if (string.IsNullOrEmpty(V_RH_ID))
                                {
                                    if (string.IsNullOrEmpty(V_LF_ID))
                                    {
                                        V_End_ZL_LEAVE = Convert.ToDateTime(dt_Plan_List.Rows[i]["D_P_START_TIME"].ToString()).AddMinutes(-10);
                                        V_End_ZL = Convert.ToDateTime(V_End_ZL_LEAVE).AddMinutes(-5);
                                        V_START_ZL = Convert.ToDateTime(V_End_ZL).AddHours(-V_TIME_YL);
                                    }
                                    else
                                    {
                                        V_End_LF = Convert.ToDateTime(dt_Plan_List.Rows[i]["D_P_START_TIME"].ToString()).AddMinutes(-10);
                                        V_START_LF = Convert.ToDateTime(V_End_LF).AddHours(-V_TIME_YL);

                                        V_End_ZL_LEAVE = Convert.ToDateTime(V_START_LF).AddMinutes(-10);
                                        V_End_ZL = Convert.ToDateTime(V_End_ZL_LEAVE).AddMinutes(-5);
                                        V_START_ZL = Convert.ToDateTime(V_End_ZL).AddHours(-V_TIME_YL);
                                    }
                                }
                                else
                                {
                                    V_End_RH = Convert.ToDateTime(dt_Plan_List.Rows[i]["D_P_START_TIME"].ToString()).AddMinutes(-10);
                                    V_START_RH = Convert.ToDateTime(V_End_RH).AddHours(-V_TIME_YL);

                                    V_End_LF = Convert.ToDateTime(V_START_RH).AddMinutes(-10);
                                    V_START_LF = Convert.ToDateTime(V_End_LF).AddHours(-V_TIME_YL);

                                    V_End_ZL_LEAVE = Convert.ToDateTime(V_START_LF).AddMinutes(-10);
                                    V_End_ZL = Convert.ToDateTime(V_End_ZL_LEAVE).AddMinutes(-5);
                                    V_START_ZL = Convert.ToDateTime(V_End_ZL).AddHours(-V_TIME_YL);

                                }

                                if (string.IsNullOrEmpty(V_LF_ID))
                                {
                                    if (string.IsNullOrEmpty(V_RH_ID))
                                    {
                                        V_TYPE = "0";
                                    }
                                    else
                                    {
                                        V_TYPE = "R";
                                    }
                                }
                                else
                                {
                                    if (string.IsNullOrEmpty(V_RH_ID))
                                    {
                                        V_TYPE = "L";
                                    }
                                    else
                                    {
                                        V_TYPE = "LR";
                                    }
                                }

                                string C_THICKNESS = "";
                                string C_W_IDTH = "";

                                string slabSize = dt_Plan_List.Rows[i]["C_SLAB_SIZE"].ToString();
                                if (slabSize.Contains("*"))
                                {
                                    string[] strr = slabSize.Split('*');
                                    C_W_IDTH = strr[1];
                                    C_THICKNESS = strr[0];
                                }

                                Mod_TPP_CAST_PLAN modelCastPlan = new Mod_TPP_CAST_PLAN();
                                modelCastPlan.C_PLAN_ID = dt_Plan_List.Rows[i]["C_ID"].ToString(); //计划编号
                                modelCastPlan.C_CONTRACT_ID = mod_Order.C_CON_NO; //合同编号
                                modelCastPlan.C_PLAN_DEPT = ""; //计划部门
                                modelCastPlan.C_EXECUTE_DEPT = ""; //执行部门
                                modelCastPlan.D_PLANEXECUTE_DATE = null; //计划执行时间
                                modelCastPlan.D_ACTUALEXECUTE_DATE = null; //实际执行时间
                                modelCastPlan.C_PLANNER = strUserID; //计划人
                                modelCastPlan.C_PRE_LOTNO = ""; //炉次
                                modelCastPlan.C_PRE_HEAT_ID = ""; //预定炉号
                                modelCastPlan.C_PRE_STEELGRADEINDEX = dt_Plan_List.Rows[i]["C_LGJH"].ToString(); //预定炼钢记号
                                modelCastPlan.C_PRE_STEELGRADE = dt_Plan_List.Rows[i]["C_STL_GRD"].ToString(); //预定钢种
                                modelCastPlan.N_AIM_TAPPED_WEIGHT = Convert.ToDecimal(dt_Plan_List.Rows[i]["N_SLAB_WGT"].ToString()); //--目标出钢重量
                                modelCastPlan.C_CASTER_ID = V_CC_ID; //-铸机号
                                modelCastPlan.C_BOF_ID = V_LD_ID; //--转炉炉座
                                modelCastPlan.C_LF_ID = V_LF_ID; ////-精炼炉座
                                modelCastPlan.C_RH_ID = V_RH_ID; //---RH炉座
                                modelCastPlan.N_BOF_STATUS = "01"; //-转炉状态01未执02兑铁03吹炼开始04出钢开05出钢结束
                                modelCastPlan.N_LF_STATUS = "01"; //-精炼炉状态01未执行02进站03处理开始04处理结束05出站
                                modelCastPlan.N_RH_STATUS = "01"; //-RH炉状态01未执行02进站03处理开始04处理结束05出站
                                modelCastPlan.N_CASTER_STATUS = "01"; //--铸机状态01未执行02大包到达03大包开浇04浇铸结束
                                modelCastPlan.N_S_IDE_STATUS = "01"; //---转炉炉后状态01未执行02处理开始03处理结束
                                modelCastPlan.C_HEAT_ID = ""; //---炉次
                                modelCastPlan.C_CASTER_NO = ""; //--铸机号
                                modelCastPlan.C_CASTING_HEAT_CNT = "";
                                modelCastPlan.D_AIM_IRONPREPARED_TIME = V_START_ZL; ////-"铁水计划时间"
                                modelCastPlan.D_AIM_BOFSTART_TIME = V_START_ZL; //-"转炉开始计划时间"
                                modelCastPlan.D_AIM_BOFTAPPED_TIME = V_End_ZL; //--"转炉结束计划时间"
                                modelCastPlan.D_AIM_TAPPEDSIDEEND_TIME = V_End_ZL_LEAVE; //转炉离开计划时间"
                                modelCastPlan.D_AIM_LFARRIVAL_TIME = V_START_LF; //LF到达计划时间"
                                modelCastPlan.D_AIM_LFSTART_TIME = V_START_LF; //LF开始计划时间"
                                modelCastPlan.D_AIM_LFEND_TIME = V_End_LF; //LF结束计划时间"
                                modelCastPlan.D_AIM_LFLEAVE_TIME = V_End_LF; //LF离开计划时间"
                                modelCastPlan.D_AIM_RHARRIVAL_TIME = V_START_RH; //RH到达计划时间
                                modelCastPlan.D_AIM_RHSTART_TIME = V_START_RH; //RH开始计划时间
                                modelCastPlan.D_AIM_RHEND_TIME = V_End_RH; //RH结束计划时间
                                modelCastPlan.D_AIM_RHLEAVE_TIME = V_End_RH; //RH离开计划时间
                                modelCastPlan.D_AIM_CASTERARRIVAL_TIME = Convert.ToDateTime(dt_Plan_List.Rows[i]["D_P_START_TIME"].ToString()); //"连铸到达计划时间"
                                modelCastPlan.D_AIM_CASTINGSTART_TIME = Convert.ToDateTime(dt_Plan_List.Rows[i]["D_P_START_TIME"].ToString()); //"连铸开始计划时间"
                                modelCastPlan.D_AIM_CASTINGEND_TIME = Convert.ToDateTime(dt_Plan_List.Rows[i]["D_P_END_TIME"].ToString()); //"连铸结束计划时间"
                                modelCastPlan.C_FIR_HEAT_FLAG = "0"; ////加热炉标志
                                modelCastPlan.DIV_HEAT_ID = ""; //---加热炉
                                modelCastPlan.C_TEAM_ID = "1"; //班组
                                modelCastPlan.C_SHIFT_ID = "1"; //班别
                                modelCastPlan.STEELGRADEINDEX = ""; //---炼钢记号
                                modelCastPlan.C_PLAN_ORD__ID = mod_Order.C_ORDER_NO; //计划订单号
                                modelCastPlan.C_HOT_SEND_FLAG = "0"; //热送标志
                                modelCastPlan.C_STEEL_RETURN_FLAG = "0"; //回炉标志
                                modelCastPlan.C_STEEL_BACK_FLAG = "0"; //返送标志
                                modelCastPlan.C_TREAT_SEQ = ""; ////顺序
                                modelCastPlan.C_DESTITATION = "";
                                modelCastPlan.C_NEW_BOF_FLAG = ""; ////--转炉标记
                                modelCastPlan.C_REFINE_TYPE = V_TYPE; //-工艺路径
                                modelCastPlan.C_LENGTH = dt_Plan_List.Rows[i]["C_SLAB_LENGTH"].ToString(); //--长度
                                modelCastPlan.C_W_IDTH = C_W_IDTH; //-宽度
                                modelCastPlan.C_THICKNESS = C_THICKNESS; //厚度
                                modelCastPlan.C_AOD_ID = ""; //AOD炉炉座
                                modelCastPlan.C_DEP_ID = ""; //熔化炉炉座
                                modelCastPlan.C_RHL_ID = ""; //--转炉后
                                modelCastPlan.C_DEP_STATUS = ""; //熔化炉状态
                                modelCastPlan.C_RHL_STATUS = ""; //-转炉后状态
                                modelCastPlan.C_AOD_STATUS = ""; //AOD炉状态
                                modelCastPlan.C_INITIALIZE_ITEM = ""; //--订单方案号
                                modelCastPlan.C_IS_TO_MES = "0";//0未传mes，1已传mes
                                modelCastPlan.C_MES_PLAN_ID = "";//MES计划号
                                modelCastPlan.C_LD_DESC = dt_Plan_List.Rows[i]["C_ZL_DESC"].ToString();
                                modelCastPlan.C_LF_DESC = dt_Plan_List.Rows[i]["C_LF_DESC"].ToString();
                                modelCastPlan.C_RH_DESC = dt_Plan_List.Rows[i]["C_RH_DESC"].ToString();
                                modelCastPlan.C_CC_DESC = dt_Plan_List.Rows[i]["C_CCM_DESC"].ToString();

                                if (dalTppCastPlan.Add_Trans(modelCastPlan))
                                {
                                    if (!dalTspPlanSms.Update_State_Trans(dt_Plan_List.Rows[i]["C_ID"].ToString()))
                                    {
                                        TransactionHelper.RollBack();
                                        return "0";
                                    }
                                }
                                else
                                {
                                    TransactionHelper.RollBack();
                                    return "0";
                                }

                            }//mod_Order
                            else
                            {
                                flag = false;
                                break;
                            }
                        }//dt_Plan_List

                        if (flag == false)
                        {
                            TransactionHelper.RollBack();
                            return "0";
                        }
                    }
                    else
                    {
                        return "0";
                    }

                    #endregion

                    TransactionHelper.Commit();
                }//dt_CC
                else
                {
                    TransactionHelper.RollBack();
                    return "0";
                }
            }
            catch (Exception ex)
            {
                TransactionHelper.RollBack();
                return "0";
            }

            return result;
        }

        /// <summary>
        /// 修改工艺路线
        /// </summary>
        /// <param name="dtCastPlan">需要修改路线的计划</param>
        /// <param name="new_cc_id">连铸ID</param>
        /// <returns></returns>
        public string UpdateGYLX_New(DataTable dtCastPlan, string new_cc_id)
        {
            string result = "1";
            try
            {
                TransactionHelper.BeginTransaction();

                string strUserID = RV.UI.UserInfo.userID;
                DateTime time = RV.UI.ServerTime.timeNow();

                if (dtCastPlan.Rows.Count > 0)
                {
                    for (int i = 0; i < dtCastPlan.Rows.Count; i++)
                    {
                        if (!dalTppCastPlan.delete_CAST_PLAN_Trans(dtCastPlan.Rows[i]["C_ID"].ToString()))
                        {
                            TransactionHelper.RollBack();
                            return "0";
                        }

                        if (!dalTspPlanSms.Update_sta_Trans(dtCastPlan.Rows[i]["C_PLAN_ID"].ToString(), dtCastPlan.Rows[i]["C_ZL_ID"].ToString(), dtCastPlan.Rows[i]["C_LF_ID"].ToString(), dtCastPlan.Rows[i]["C_RH_ID"].ToString()))
                        {
                            TransactionHelper.RollBack();
                            return "0";
                        }
                    }

                    #region 重新生成工序计划

                    DataTable dt_Plan_List = dalTspPlanSms.Get_Plan_List_Back_Trans(new_cc_id).Tables[0];//未生成工序计划的连铸计划

                    bool flag = true;

                    if (dt_Plan_List.Rows.Count > 0)
                    {
                        DateTime? V_START_ZL;
                        DateTime? V_End_ZL;
                        DateTime? V_End_ZL_LEAVE;
                        DateTime? V_START_LF;
                        DateTime? V_End_LF;
                        DateTime? V_START_RH;
                        DateTime? V_End_RH;
                        double V_TIME_YL;
                        string V_RH_ID;
                        string V_LF_ID;
                        string V_LD_ID;
                        string V_CC_ID;
                        double V_CN;
                        string V_TYPE;

                        for (int i = 0; i < dt_Plan_List.Rows.Count; i++)
                        {
                            V_START_ZL = null;
                            V_End_ZL = null;
                            V_End_ZL_LEAVE = null;
                            V_START_LF = null;
                            V_End_LF = null;
                            V_START_RH = null;
                            V_End_RH = null;
                            V_TIME_YL = 0;
                            V_RH_ID = "";
                            V_LF_ID = "";
                            V_LD_ID = "";
                            V_CC_ID = "";
                            V_CN = 0;
                            V_TYPE = "";

                            Mod_TMO_ORDER mod_Order = dalTmoOrder.GetModel(dt_Plan_List.Rows[i]["C_ORDER_NO"].ToString());

                            V_RH_ID = dt_Plan_List.Rows[i]["C_RH_ID"].ToString();
                            V_LF_ID = dt_Plan_List.Rows[i]["C_LF_ID"].ToString();
                            V_LD_ID = dt_Plan_List.Rows[i]["C_ZL_ID"].ToString();
                            V_CC_ID = dt_Plan_List.Rows[i]["C_CCM_ID"].ToString();

                            if (mod_Order != null)
                            {
                                V_CN = Convert.ToDouble(mod_Order.N_MACH_WGT_CCM);

                                if (V_CN == 0)
                                {
                                    V_CN = 88;
                                }

                                V_TIME_YL = Convert.ToDouble(dt_Plan_List.Rows[i]["N_SLAB_WGT"].ToString()) / V_CN;

                                if (string.IsNullOrEmpty(V_RH_ID))
                                {
                                    if (string.IsNullOrEmpty(V_LF_ID))
                                    {
                                        V_End_ZL_LEAVE = Convert.ToDateTime(dt_Plan_List.Rows[i]["D_P_START_TIME"].ToString()).AddMinutes(-10);
                                        V_End_ZL = Convert.ToDateTime(V_End_ZL_LEAVE).AddMinutes(-5);
                                        V_START_ZL = Convert.ToDateTime(V_End_ZL).AddHours(-V_TIME_YL);
                                    }
                                    else
                                    {
                                        V_End_LF = Convert.ToDateTime(dt_Plan_List.Rows[i]["D_P_START_TIME"].ToString()).AddMinutes(-10);
                                        V_START_LF = Convert.ToDateTime(V_End_LF).AddHours(-V_TIME_YL);

                                        V_End_ZL_LEAVE = Convert.ToDateTime(V_START_LF).AddMinutes(-10);
                                        V_End_ZL = Convert.ToDateTime(V_End_ZL_LEAVE).AddMinutes(-5);
                                        V_START_ZL = Convert.ToDateTime(V_End_ZL).AddHours(-V_TIME_YL);
                                    }
                                }
                                else
                                {
                                    V_End_RH = Convert.ToDateTime(dt_Plan_List.Rows[i]["D_P_START_TIME"].ToString()).AddMinutes(-10);
                                    V_START_RH = Convert.ToDateTime(V_End_RH).AddHours(-V_TIME_YL);

                                    V_End_LF = Convert.ToDateTime(V_START_RH).AddMinutes(-10);
                                    V_START_LF = Convert.ToDateTime(V_End_LF).AddHours(-V_TIME_YL);

                                    V_End_ZL_LEAVE = Convert.ToDateTime(V_START_LF).AddMinutes(-10);
                                    V_End_ZL = Convert.ToDateTime(V_End_ZL_LEAVE).AddMinutes(-5);
                                    V_START_ZL = Convert.ToDateTime(V_End_ZL).AddHours(-V_TIME_YL);

                                }

                                if (string.IsNullOrEmpty(V_LF_ID))
                                {
                                    if (string.IsNullOrEmpty(V_RH_ID))
                                    {
                                        V_TYPE = "0";
                                    }
                                    else
                                    {
                                        V_TYPE = "R";
                                    }
                                }
                                else
                                {
                                    if (string.IsNullOrEmpty(V_RH_ID))
                                    {
                                        V_TYPE = "L";
                                    }
                                    else
                                    {
                                        V_TYPE = "LR";
                                    }
                                }

                                string C_THICKNESS = "";
                                string C_W_IDTH = "";

                                string slabSize = dt_Plan_List.Rows[i]["C_SLAB_SIZE"].ToString();
                                if (slabSize.Contains("*"))
                                {
                                    string[] strr = slabSize.Split('*');
                                    C_W_IDTH = strr[1];
                                    C_THICKNESS = strr[0];
                                }

                                if (V_START_ZL == null)
                                {
                                    V_START_ZL = Convert.ToDateTime("1899/12/30 00:00:00");
                                }
                                if (V_End_ZL == null)
                                {
                                    V_End_ZL = Convert.ToDateTime("1899/12/30 00:00:00");
                                }
                                if (V_End_ZL_LEAVE == null)
                                {
                                    V_End_ZL_LEAVE = Convert.ToDateTime("1899/12/30 00:00:00");
                                }
                                if (V_START_LF == null)
                                {
                                    V_START_LF = Convert.ToDateTime("1899/12/30 00:00:00");
                                }
                                if (V_End_LF == null)
                                {
                                    V_End_LF = Convert.ToDateTime("1899/12/30 00:00:00");
                                }
                                if (V_START_RH == null)
                                {
                                    V_START_RH = Convert.ToDateTime("1899/12/30 00:00:01");
                                }
                                if (V_End_RH == null)
                                {
                                    V_End_RH = Convert.ToDateTime("1899/12/30 00:00:01");
                                }

                                Mod_TPP_CAST_PLAN modelCastPlan = new Mod_TPP_CAST_PLAN();
                                modelCastPlan.C_PLAN_ID = dt_Plan_List.Rows[i]["C_ID"].ToString(); //计划编号
                                modelCastPlan.C_CONTRACT_ID = mod_Order.C_CON_NO; //合同编号
                                modelCastPlan.C_PLAN_DEPT = ""; //计划部门
                                modelCastPlan.C_EXECUTE_DEPT = ""; //执行部门
                                modelCastPlan.D_PLANEXECUTE_DATE = null; //计划执行时间
                                modelCastPlan.D_ACTUALEXECUTE_DATE = null; //实际执行时间
                                modelCastPlan.C_PLANNER = strUserID; //计划人
                                modelCastPlan.C_PRE_LOTNO = ""; //炉次
                                modelCastPlan.C_PRE_HEAT_ID = ""; //预定炉号
                                modelCastPlan.C_PRE_STEELGRADEINDEX = dt_Plan_List.Rows[i]["C_LGJH"].ToString(); //预定炼钢记号
                                modelCastPlan.C_PRE_STEELGRADE = dt_Plan_List.Rows[i]["C_STL_GRD"].ToString(); //预定钢种
                                modelCastPlan.N_AIM_TAPPED_WEIGHT = Convert.ToDecimal(dt_Plan_List.Rows[i]["N_SLAB_WGT"].ToString()); //--目标出钢重量
                                modelCastPlan.C_CASTER_ID = V_CC_ID; //-铸机号
                                modelCastPlan.C_BOF_ID = V_LD_ID; //--转炉炉座
                                modelCastPlan.C_LF_ID = V_LF_ID; ////-精炼炉座
                                modelCastPlan.C_RH_ID = V_RH_ID; //---RH炉座
                                modelCastPlan.N_BOF_STATUS = "01"; //-转炉状态01未执02兑铁03吹炼开始04出钢开05出钢结束
                                modelCastPlan.N_LF_STATUS = "01"; //-精炼炉状态01未执行02进站03处理开始04处理结束05出站
                                modelCastPlan.N_RH_STATUS = "01"; //-RH炉状态01未执行02进站03处理开始04处理结束05出站
                                modelCastPlan.N_CASTER_STATUS = "01"; //--铸机状态01未执行02大包到达03大包开浇04浇铸结束
                                modelCastPlan.N_S_IDE_STATUS = "01"; //---转炉炉后状态01未执行02处理开始03处理结束
                                modelCastPlan.C_HEAT_ID = ""; //---炉次
                                modelCastPlan.C_CASTER_NO = ""; //--铸机号
                                modelCastPlan.C_CASTING_HEAT_CNT = "";
                                modelCastPlan.D_AIM_IRONPREPARED_TIME = V_START_ZL; ////-"铁水计划时间"
                                modelCastPlan.D_AIM_BOFSTART_TIME = V_START_ZL; //-"转炉开始计划时间"
                                modelCastPlan.D_AIM_BOFTAPPED_TIME = V_End_ZL; //--"转炉结束计划时间"
                                modelCastPlan.D_AIM_TAPPEDSIDEEND_TIME = V_End_ZL_LEAVE; //转炉离开计划时间"
                                modelCastPlan.D_AIM_LFARRIVAL_TIME = V_START_LF; //LF到达计划时间"
                                modelCastPlan.D_AIM_LFSTART_TIME = V_START_LF; //LF开始计划时间"
                                modelCastPlan.D_AIM_LFEND_TIME = V_End_LF; //LF结束计划时间"
                                modelCastPlan.D_AIM_LFLEAVE_TIME = V_End_LF; //LF离开计划时间"
                                modelCastPlan.D_AIM_RHARRIVAL_TIME = V_START_RH; //RH到达计划时间
                                modelCastPlan.D_AIM_RHSTART_TIME = V_START_RH; //RH开始计划时间
                                modelCastPlan.D_AIM_RHEND_TIME = V_End_RH; //RH结束计划时间
                                modelCastPlan.D_AIM_RHLEAVE_TIME = V_End_RH; //RH离开计划时间
                                modelCastPlan.D_AIM_CASTERARRIVAL_TIME = Convert.ToDateTime(dt_Plan_List.Rows[i]["D_P_START_TIME"].ToString()); //"连铸到达计划时间"
                                modelCastPlan.D_AIM_CASTINGSTART_TIME = Convert.ToDateTime(dt_Plan_List.Rows[i]["D_P_START_TIME"].ToString()); //"连铸开始计划时间"
                                modelCastPlan.D_AIM_CASTINGEND_TIME = Convert.ToDateTime(dt_Plan_List.Rows[i]["D_P_END_TIME"].ToString()); //"连铸结束计划时间"
                                modelCastPlan.C_FIR_HEAT_FLAG = "0"; ////加热炉标志
                                modelCastPlan.DIV_HEAT_ID = ""; //---加热炉
                                modelCastPlan.C_TEAM_ID = "1"; //班组
                                modelCastPlan.C_SHIFT_ID = "1"; //班别
                                modelCastPlan.STEELGRADEINDEX = ""; //---炼钢记号
                                modelCastPlan.C_PLAN_ORD__ID = mod_Order.C_ORDER_NO; //计划订单号
                                modelCastPlan.C_HOT_SEND_FLAG = "0"; //热送标志
                                modelCastPlan.C_STEEL_RETURN_FLAG = "0"; //回炉标志
                                modelCastPlan.C_STEEL_BACK_FLAG = "0"; //返送标志
                                modelCastPlan.C_TREAT_SEQ = ""; ////顺序
                                modelCastPlan.C_DESTITATION = "";
                                modelCastPlan.C_NEW_BOF_FLAG = ""; ////--转炉标记
                                modelCastPlan.C_REFINE_TYPE = V_TYPE; //-工艺路径
                                modelCastPlan.C_LENGTH = dt_Plan_List.Rows[i]["C_SLAB_LENGTH"].ToString(); //--长度
                                modelCastPlan.C_W_IDTH = C_W_IDTH; //-宽度
                                modelCastPlan.C_THICKNESS = C_THICKNESS; //厚度
                                modelCastPlan.C_AOD_ID = ""; //AOD炉炉座
                                modelCastPlan.C_DEP_ID = ""; //熔化炉炉座
                                modelCastPlan.C_RHL_ID = ""; //--转炉后
                                modelCastPlan.C_DEP_STATUS = ""; //熔化炉状态
                                modelCastPlan.C_RHL_STATUS = ""; //-转炉后状态
                                modelCastPlan.C_AOD_STATUS = ""; //AOD炉状态
                                modelCastPlan.C_INITIALIZE_ITEM = ""; //--订单方案号
                                modelCastPlan.C_IS_TO_MES = "0";//0未传mes，1已传mes
                                modelCastPlan.C_MES_PLAN_ID = "";//MES计划号
                                modelCastPlan.C_LD_DESC = dt_Plan_List.Rows[i]["C_ZL_DESC"].ToString();
                                modelCastPlan.C_LF_DESC = dt_Plan_List.Rows[i]["C_LF_DESC"].ToString();
                                modelCastPlan.C_RH_DESC = dt_Plan_List.Rows[i]["C_RH_DESC"].ToString();
                                modelCastPlan.C_CC_DESC = dt_Plan_List.Rows[i]["C_CCM_DESC"].ToString();

                                if (dalTppCastPlan.Add_Trans(modelCastPlan))
                                {
                                    if (!dalTspPlanSms.Update_State_Trans(dt_Plan_List.Rows[i]["C_ID"].ToString()))
                                    {
                                        TransactionHelper.RollBack();
                                        return "0";
                                    }
                                }
                                else
                                {
                                    TransactionHelper.RollBack();
                                    return "0";
                                }

                            }//mod_Order
                            else
                            {
                                flag = false;
                                break;
                            }
                        }//dt_Plan_List

                        if (flag == false)
                        {
                            TransactionHelper.RollBack();
                            return "0";
                        }
                    }
                    else
                    {
                        return "0";
                    }

                    #endregion

                    TransactionHelper.Commit();
                }//dt_CC
                else
                {
                    TransactionHelper.RollBack();
                    return "0";
                }
            }
            catch (Exception ex)
            {
                TransactionHelper.RollBack();
                return "0";
            }

            return result;
        }


        /// <summary>
        /// 修改炼钢计划
        /// </summary>
        /// <param name="dr">需要修改的炼钢计划信息</param>
        /// <returns></returns>
        public string Update_Plan(DataRow dr, string strUrl, string strReason)
        {
            string result = "1";
            try
            {
                TransactionHelper.BeginTransaction();

                string strUserID = RV.UI.UserInfo.userID;
                DateTime time = RV.UI.ServerTime.timeNow();

                Dal_Interface_NC_SLAB_A1_Edit dalInterface_Slab_A1_Edit = new Dal_Interface_NC_SLAB_A1_Edit();

                if (dr != null)
                {
                    string str_Stove = dr["炉号"].ToString();

                    int count_KC = dalTppCastPlan.Get_Stove_Is_KC(str_Stove);
                    if (count_KC == 0)
                    {
                        TransactionHelper.RollBack();
                        return "该炉还没有开吹，不能修改计划！";
                    }

                    int count_Cou = dalTppCastPlan.Get_Stove_Count(str_Stove);
                    if (count_Cou > 0)
                    {
                        TransactionHelper.RollBack();
                        return "该炉MES已经甩废，不能修改计划！";
                    }

                    DataTable dt_Plan = dalTrpPlanRoll.Get_Plan(dr["C_MATRL_NO"].ToString(), dr["断面"].ToString(), dr["定尺"].ToString(), dr["钢种"].ToString(), dr["执行标准"].ToString()).Tables[0];

                    if (dt_Plan.Rows.Count == 0)
                    {
                        TransactionHelper.RollBack();
                        return "没有找到对应的钢种计划！";
                    }

                    string str_Order_ID = dt_Plan.Rows[0]["C_ORDER_ID"].ToString();

                    string str_LD_Desc = dalTbSta.Get_STA_DESC(dr["C_ZL_ID"].ToString());
                    if (str_LD_Desc == "0")
                    {
                        str_LD_Desc = "";
                    }

                    string str_LF_Desc = dalTbSta.Get_STA_DESC(dr["C_LF_ID"].ToString());
                    if (str_LF_Desc == "0")
                    {
                        str_LF_Desc = "";
                    }
                    string str_RH_Desc = dalTbSta.Get_STA_DESC(dr["C_RH_ID"].ToString());
                    if (str_RH_Desc == "0")
                    {
                        str_RH_Desc = "";
                    }
                    string str_CC_Desc = dalTbSta.Get_STA_DESC(dr["C_CCM_ID"].ToString());
                    if (str_CC_Desc == "0")
                    {
                        str_CC_Desc = "";
                    }

                    Mod_TMO_ORDER modOrder = dalTmoOrder.GetModel(str_Order_ID);
                    if (modOrder == null)
                    {
                        TransactionHelper.RollBack();
                        return "没有找到订单信息！";
                    }

                    #region 计算炼钢记号

                    string LGJH_LD_CODE = "";
                    string LGJH_LF_CODE = "";
                    string LGJH_RH_CODE = "";
                    string LGJH_CC_CODE = "";

                    string V_ZL_TYPE = "";
                    string V_LF_TYPE = "";
                    string V_RH_TYPE = "";
                    string V_CC_TYPE = "";

                    LGJH_LD_CODE = dalTbSta.Get_CODE(dr["C_ZL_ID"].ToString());
                    LGJH_LF_CODE = dalTbSta.Get_CODE(dr["C_LF_ID"].ToString());
                    LGJH_RH_CODE = dalTbSta.Get_CODE(dr["C_RH_ID"].ToString());
                    LGJH_CC_CODE = dalTbSta.Get_CODE(dr["C_CCM_ID"].ToString());

                    LGJH_LD_CODE = LGJH_LD_CODE.Substring(0, 1);
                    LGJH_LF_CODE = LGJH_LF_CODE.Substring(0, 1);
                    LGJH_RH_CODE = LGJH_RH_CODE.Substring(0, 1);
                    LGJH_CC_CODE = LGJH_CC_CODE.Substring(0, 1);

                    if (LGJH_LD_CODE == "1" || LGJH_LD_CODE == "2" || LGJH_LD_CODE == "3")
                    {
                        V_ZL_TYPE = "01";
                    }
                    else
                    {
                        if (LGJH_LD_CODE == "4")
                        {
                            V_ZL_TYPE = "02";
                        }
                        else
                        {
                            if (LGJH_LD_CODE == "A")
                            {
                                V_ZL_TYPE = "03";
                            }
                            else
                            {
                                V_ZL_TYPE = "未知转炉";
                            }
                        }
                    }

                    if (LGJH_LF_CODE == "0")
                    {
                        V_LF_TYPE = "01";

                    }
                    else
                    {
                        if (LGJH_LF_CODE == "1" || LGJH_LF_CODE == "2" || LGJH_LF_CODE == "4" || LGJH_LF_CODE == "5")
                        {
                            V_LF_TYPE = "02";
                        }
                        else
                        {
                            if (LGJH_LF_CODE == "3")
                            {
                                V_LF_TYPE = "03";
                            }
                            else
                            {
                                if (LGJH_LF_CODE == "4")
                                {
                                    V_LF_TYPE = "04";
                                }
                                else
                                {
                                    V_LF_TYPE = "未知LF路径";
                                }
                            }
                        }
                    }

                    if (LGJH_RH_CODE == "0")
                    {
                        V_RH_TYPE = "01";
                    }
                    else
                    {
                        if (LGJH_RH_CODE == "1")
                        {
                            V_RH_TYPE = "02";
                        }
                        else
                        {
                            V_RH_TYPE = "未知RH";
                        }
                    }

                    if (LGJH_CC_CODE == "1" || LGJH_CC_CODE == "2")
                    {
                        V_CC_TYPE = "01";
                    }
                    else
                    {
                        if (LGJH_CC_CODE == "3" || LGJH_CC_CODE == "4")
                        {
                            V_CC_TYPE = "02";
                        }
                        else
                        {
                            if (LGJH_CC_CODE == "5")
                            {
                                V_CC_TYPE = "03";

                                if (V_LF_TYPE == "02" || V_LF_TYPE == "03" || V_LF_TYPE == "04")
                                {
                                    V_LF_TYPE = "03";
                                }
                            }
                            else
                            {
                                if (LGJH_CC_CODE == "6")
                                {
                                    V_CC_TYPE = "04";
                                }
                                else
                                {
                                    if (LGJH_CC_CODE == "7")
                                    {
                                        V_CC_TYPE = "05";
                                    }
                                    else
                                    {
                                        V_CC_TYPE = "未知铸机";
                                    }
                                }
                            }
                        }
                    }

                    string str_LGJH = "";

                    DataTable dtLGJH = new DataTable();
                    if (LGJH_LF_CODE == "4")
                    {
                        dtLGJH = dalLgjh.Get_LGJH_Std(dr["执行标准"].ToString(), dr["钢种"].ToString(), V_ZL_TYPE, V_RH_TYPE, V_CC_TYPE).Tables[0];
                    }
                    else
                    {
                        dtLGJH = dalLgjh.Get_LGJH_Std(dr["执行标准"].ToString(), dr["钢种"].ToString(), V_ZL_TYPE, V_LF_TYPE, V_RH_TYPE, V_CC_TYPE).Tables[0];
                    }

                    if (dtLGJH.Rows.Count > 1)
                    {
                        TransactionHelper.RollBack();
                        return "标准：" + dr["执行标准"].ToString() + "；钢种：" + dr["钢种"].ToString() + "找到多个炼钢记号，请核查！";
                    }
                    else if (dtLGJH.Rows.Count == 0)
                    {
                        TransactionHelper.RollBack();
                        return "标准：" + dr["执行标准"].ToString() + "；钢种：" + dr["钢种"].ToString() + "没有找到炼钢记号！";
                    }

                    str_LGJH = dtLGJH.Rows[0]["C_STEEL_SIGN"].ToString();

                    #endregion

                    string V_TYPE = "";

                    if (string.IsNullOrEmpty(dr["C_ZL_ID"].ToString()))
                    {
                        if (string.IsNullOrEmpty(dr["C_RH_ID"].ToString()))
                        {
                            V_TYPE = "0";
                        }
                        else
                        {
                            V_TYPE = "R";
                        }
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(dr["C_RH_ID"].ToString()))
                        {
                            V_TYPE = "L";
                        }
                        else
                        {
                            V_TYPE = "LR";
                        }
                    }

                    string strSlabSize = dr["断面"].ToString();
                    string[] strs = strSlabSize.Split('*');
                    string strThickNess = strs[0];
                    string strWidth = strs[1];

                    if (!dalTppCastPlan.Update_CAST_PLAN_Trans(dr["C_ID"].ToString(), str_LGJH, modOrder.C_ORDER_NO, V_TYPE, dr["钢种"].ToString(), dr["定尺"].ToString(), strWidth, strThickNess, dr["C_CCM_ID"].ToString(), dr["C_ZL_ID"].ToString(), dr["C_LF_ID"].ToString(), dr["C_RH_ID"].ToString(), str_LD_Desc, str_LF_Desc, str_RH_Desc, str_CC_Desc))
                    {
                        TransactionHelper.RollBack();
                        return "更新CAP工序计划信息失败！";
                    }

                    if (!dalTspPlanSms.Update_Plan_Trans(dr["C_PLAN_ID"].ToString(), dr["C_ZL_ID"].ToString(), dr["C_LF_ID"].ToString(), dr["C_RH_ID"].ToString(), dr["C_CCM_ID"].ToString(), modOrder.C_ID, dr["钢种"].ToString(), dr["C_MATRL_NO"].ToString(), dr["C_MATRL_NAME"].ToString(), strSlabSize, dr["定尺"].ToString(), dr["执行标准"].ToString(), modOrder.C_BY1, modOrder.C_BY2))
                    {
                        TransactionHelper.RollBack();
                        return "更新CAP炉次计划信息失败！";
                    }


                    #region 操作MES

                    int V_ORDER_NUM = dalTppCastPlan.Get_Order_Num(modOrder.C_ORDER_NO);

                    if (V_ORDER_NUM == 0)
                    {
                        #region   插入CPLAN_ORDER

                        string V_GUID = Guid.NewGuid().ToString("B").ToUpper();

                        string V_ZL_CODE = dalTbSta.Get_MES_CODE(dr["C_ZL_ID"].ToString());

                        string s_route = V_TYPE;
                        if (V_ZL_CODE == "S25")
                        {
                            if (s_route == "0")
                            {
                                s_route = "AC";
                            }
                            else
                            {
                                s_route = "A" + s_route;
                            }
                        }
                        else
                        {
                            if (s_route == "0")
                            {
                                s_route = "BC";
                            }
                            else
                            {
                                s_route = "B" + s_route;
                            }
                        }

                        string sql_CPLAN_ORDER = "INSERT INTO CPLAN_ORDER@cap_mes";
                        sql_CPLAN_ORDER += "(GUID,";
                        sql_CPLAN_ORDER += " NAME,";
                        sql_CPLAN_ORDER += " PLANID,"; //计划订单号
                        sql_CPLAN_ORDER += " CONTRACTID,";
                        sql_CPLAN_ORDER += " STATUS,"; //状态
                        sql_CPLAN_ORDER += " PLANDEPT,";
                        sql_CPLAN_ORDER += " EXECUTEDEPT,";
                        sql_CPLAN_ORDER += " CREATEDATE,";
                        sql_CPLAN_ORDER += " PLANEXECUTEDATE,";
                        sql_CPLAN_ORDER += " ACTUALEXECUTEDATE,";
                        sql_CPLAN_ORDER += " PLANNER,";
                        sql_CPLAN_ORDER += " LENGTH,";
                        sql_CPLAN_ORDER += " WIDTH,";
                        sql_CPLAN_ORDER += " THICKNESS,";
                        sql_CPLAN_ORDER += " STEELGRADE,"; //钢种
                        sql_CPLAN_ORDER += " UNIT,";
                        sql_CPLAN_ORDER += " ASSIST_UNIT,";
                        sql_CPLAN_ORDER += " WEIGHT,"; //余量
                        sql_CPLAN_ORDER += " ASSISI_WEIGHT,";
                        sql_CPLAN_ORDER += " PLANREC_DATE,";
                        sql_CPLAN_ORDER += " REQUEST_DATE,";
                        sql_CPLAN_ORDER += " CORP,"; //公司
                        sql_CPLAN_ORDER += " FACTORY,"; //工厂
                        sql_CPLAN_ORDER += " WORK_CENTER,";
                        sql_CPLAN_ORDER += " CLIENT,";
                        sql_CPLAN_ORDER += " TECH_REQUEST,";//技术要求(自由项2)
                        sql_CPLAN_ORDER += " INSIDE_NOTE,";
                        sql_CPLAN_ORDER += " IMM_FLAG,";
                        sql_CPLAN_ORDER += " CASTERID,";
                        sql_CPLAN_ORDER += " NEW_BOF_FLAG,";
                        sql_CPLAN_ORDER += " PROTOCOL,";//制造标准\协议（执行标准）
                        sql_CPLAN_ORDER += " PRODUCESTD,"; // 制造标准（自由项1）
                        sql_CPLAN_ORDER += " PK_POID,"; //计划订单主键
                        sql_CPLAN_ORDER += " ACTWEIGHT,"; //实际投入量
                        sql_CPLAN_ORDER += " SPAREWEIGHT,";//剩余量
                        sql_CPLAN_ORDER += " MATERIALCODE,";//物料编码
                        sql_CPLAN_ORDER += " MATERIALCODE_ID,"; //物料编码id
                        sql_CPLAN_ORDER += " PRODUCT_ROUTE,";//工艺路径
                        sql_CPLAN_ORDER += " OTHER_TECH_REQUEST"; //其它要求
                        sql_CPLAN_ORDER += " )";
                        sql_CPLAN_ORDER += " values";
                        sql_CPLAN_ORDER += " ('" + V_GUID + "',";
                        sql_CPLAN_ORDER += " '',";
                        sql_CPLAN_ORDER += " '" + modOrder.C_ORDER_NO + "',";//计划订单号
                        sql_CPLAN_ORDER += " '',";
                        sql_CPLAN_ORDER += " '14',"; //状态
                        sql_CPLAN_ORDER += " '',";
                        sql_CPLAN_ORDER += " '',";
                        sql_CPLAN_ORDER += " SYSDATE,";
                        sql_CPLAN_ORDER += " TO_DATE('1899/12/30 00:00:00', 'yyyy-mm-dd hh24:mi:ss'),";
                        sql_CPLAN_ORDER += " TO_DATE('1899/12/30 00:00:00', 'yyyy-mm-dd hh24:mi:ss'),";
                        sql_CPLAN_ORDER += " '',";
                        sql_CPLAN_ORDER += " '" + dr["定尺"].ToString() + "',";
                        sql_CPLAN_ORDER += " '" + strWidth + "',";
                        sql_CPLAN_ORDER += " '" + strThickNess + "',";
                        sql_CPLAN_ORDER += " '" + dr["钢种"].ToString() + "',";//钢种
                        sql_CPLAN_ORDER += " '吨',";
                        sql_CPLAN_ORDER += " '',";
                        sql_CPLAN_ORDER += " '" + modOrder.N_WGT + "',";//余量
                        sql_CPLAN_ORDER += " '0',";
                        sql_CPLAN_ORDER += " TO_DATE('" + modOrder.D_MOD_DT + "','yyyy-mm-dd hh24:mi:ss'),";
                        sql_CPLAN_ORDER += " TO_DATE('" + modOrder.D_DELIVERY_DT + "','yyyy-mm-dd hh24:mi:ss'),";
                        sql_CPLAN_ORDER += " '1001',";//公司
                        sql_CPLAN_ORDER += " '1001NC10000000000669',";//工厂
                        sql_CPLAN_ORDER += " '',";
                        sql_CPLAN_ORDER += " '',";
                        sql_CPLAN_ORDER += " '" + modOrder.C_BY2 + "',";//技术要求(自由项2)
                        sql_CPLAN_ORDER += " '',";
                        sql_CPLAN_ORDER += " '',";
                        sql_CPLAN_ORDER += " '',";
                        sql_CPLAN_ORDER += " '',";
                        sql_CPLAN_ORDER += " '" + dr["执行标准"].ToString() + "',";//制造标准\协议（执行标准）
                        sql_CPLAN_ORDER += " '" + modOrder.C_BY1 + "',";//制造标准（自由项1）
                        sql_CPLAN_ORDER += " '" + modOrder.C_ID + "',";//计划订单主键
                        sql_CPLAN_ORDER += " '',";//实际投入量
                        sql_CPLAN_ORDER += " '',";//剩余量
                        sql_CPLAN_ORDER += " '" + dr["C_MATRL_NO"].ToString() + "',";//物料编码
                        sql_CPLAN_ORDER += " '" + dr["C_PK_INVBASDOC"].ToString() + "',";//物料编码id
                        sql_CPLAN_ORDER += " '" + s_route + "',"; //工艺路径
                        sql_CPLAN_ORDER += " ''"; //其它要求
                        sql_CPLAN_ORDER += " ) ";

                        if (!dalTppCastPlan.Insert_Mes_Trans(sql_CPLAN_ORDER))
                        {
                            TransactionHelper.RollBack();
                            //Transaction_MES.RollBack();
                            return "下发MES系统CPLAN_ORDER表时出错！";
                        }

                        #endregion
                    }

                    string preheatid = dalTppCastPlan.Get_Mes_PreHeatId(str_Stove);
                    if (string.IsNullOrEmpty(preheatid))
                    {
                        TransactionHelper.RollBack();
                        return "没有找到MES的preheatid信息！";
                    }

                    string sql = "Update CPlan_Casting@CAP_MES set Plan_Ord_ID ='" + modOrder.C_ORDER_NO + "', Pre_SteelGradeIndex='" + str_LGJH + "', Pre_SteelGrade='" + dr["钢种"].ToString() + "', Length='" + dr["定尺"].ToString() + "',WIDTH='" + strWidth + "',THICKNESS='" + strThickNess + "',MATERIALCODE_ID='" + dr["C_PK_INVBASDOC"].ToString() + "',MATERIALCODE='" + dr["C_MATRL_NO"].ToString() + "'  where PreHeatID='" + preheatid + "'";
                    if (!dalTppCastPlan.Update_Mes_Trans(sql))
                    {
                        TransactionHelper.RollBack();
                        return "更新CPlan_Casting失败！";
                    }

                    string sql1 = "Update CPlan_Tapping@CAP_MES set Plan_Ord_ID ='" + modOrder.C_ORDER_NO + "', Pre_SteelGradeIndex='" + str_LGJH + "', Pre_SteelGrade='" + dr["钢种"].ToString() + "' , SteelGradeIndex ='" + str_LGJH + "',STEELGRADE='" + dr["钢种"].ToString() + "',Length='" + dr["定尺"].ToString() + "',WIDTH='" + strWidth + "',THICKNESS='" + strThickNess + "',MATERIALCODE_ID='" + dr["C_PK_INVBASDOC"].ToString() + "' where  HeatID='" + str_Stove + "'";
                    if (!dalTppCastPlan.Update_Mes_Trans(sql1))
                    {
                        TransactionHelper.RollBack();
                        return "更新CPlan_Tapping失败！";
                    }

                    int Count_CCCM_Base_Data = dalTppCastPlan.Get_Mes_Count("select count(1) from CCCM_Base_Data@CAP_MES where HeatID='" + str_Stove + "' ");

                    if (Count_CCCM_Base_Data > 0)
                    {
                        string sql2 = "Update CCCM_Base_Data@CAP_MES set SteelGrade ='" + dr["钢种"].ToString() + "', Pre_SteelGradeIndex='" + str_LGJH + "',SteelGradeIndex ='" + str_LGJH + "',plan_SteelGrade ='" + dr["钢种"].ToString() + "' , Length='" + dr["定尺"].ToString() + "',WIDTH='" + strWidth + "',THICKNESS='" + strThickNess + "' where HeatID='" + str_Stove + "'";
                        if (!dalTppCastPlan.Update_Mes_Trans(sql2))
                        {
                            TransactionHelper.RollBack();
                            return "更新CCCM_Base_Data失败！";
                        }
                    }

                    int Count_CBOF_BASE_DATA = dalTppCastPlan.Get_Mes_Count("select count(1) from CBOF_BASE_DATA@CAP_MES where HeatID='" + str_Stove + "' ");

                    if (Count_CBOF_BASE_DATA > 0)
                    {
                        string sql9 = "Update CBOF_BASE_DATA@CAP_MES set SteelGradeIndex ='" + str_LGJH + "' ,SteelGrade ='" + dr["钢种"].ToString() + "' where HeatID='" + str_Stove + "'";
                        if (!dalTppCastPlan.Update_Mes_Trans(sql9))
                        {
                            TransactionHelper.RollBack();
                            return "更新CBOF_BASE_DATA失败！";
                        }
                    }

                    int Count_CLF_BASE_DATA = dalTppCastPlan.Get_Mes_Count("select count(1) from CLF_BASE_DATA@CAP_MES where HeatID='" + str_Stove + "' ");

                    if (Count_CLF_BASE_DATA > 0)
                    {
                        string sql10 = "Update CLF_BASE_DATA@CAP_MES set SteelGradeIndex ='" + str_LGJH + "' ,SteelGrade ='" + dr["钢种"].ToString() + "' where HeatID='" + str_Stove + "'";
                        if (!dalTppCastPlan.Update_Mes_Trans(sql10))
                        {
                            TransactionHelper.RollBack();
                            return "更新CLF_BASE_DATA失败！";
                        }
                    }

                    int Count_CRH_BASE_DATA = dalTppCastPlan.Get_Mes_Count("select count(1) from CRH_BASE_DATA@CAP_MES where HeatID='" + str_Stove + "' ");

                    if (Count_CRH_BASE_DATA > 0)
                    {
                        string sql11 = "Update CRH_BASE_DATA@CAP_MES set SteelGradeIndex ='" + str_LGJH + "' ,SteelGrade ='" + dr["钢种"].ToString() + "' where HeatID='" + str_Stove + "'";
                        if (!dalTppCastPlan.Update_Mes_Trans(sql11))
                        {
                            TransactionHelper.RollBack();
                            return "更新CRH_BASE_DATA失败！";
                        }
                    }

                    int Count_csteel_data = dalTppCastPlan.Get_Mes_Count("select count(1) from csteel_data@CAP_MES where heatid='" + str_Stove + "' ");

                    if (Count_csteel_data > 0)
                    {
                        string sql12 = "update csteel_data@CAP_MES set STEELGRADEINDEX='" + str_LGJH + "',PRE_STEELGRADEINDEX='" + str_LGJH + "' where heatid='" + str_Stove + "' ";
                        if (!dalTppCastPlan.Update_Mes_Trans(sql12))
                        {
                            TransactionHelper.RollBack();
                            return "更新csteel_data失败！";
                        }
                    }

                    int Count_caod_base_data = dalTppCastPlan.Get_Mes_Count("select count(1) from caod_base_data@CAP_MES where heatid='" + str_Stove + "' ");

                    if (Count_caod_base_data > 0)
                    {
                        string sql13 = "update caod_base_data@CAP_MES set STEELGRADEINDEX='" + str_LGJH + "',STEELGRADE='" + dr["钢种"].ToString() + "' where heatid='" + str_Stove + "' ";
                        if (!dalTppCastPlan.Update_Mes_Trans(sql13))
                        {
                            TransactionHelper.RollBack();
                            return "更新caod_base_data失败！";
                        }
                    }

                    #endregion


                    #region 上传A1给NC

                    string strSql = "select count(1) from XGERP50.mm_po@cap_erp t  where t.dr = 0 and t.zyx5 = '" + modOrder.C_ID + "' ";
                    int NC_Count = dalTppCastPlan.Get_NC_Count(strSql);

                    if (NC_Count == 0)
                    {
                        string result_A1 = dalInterface_Slab_A1_Edit.SendXml_SLAB_A1(strUrl, dr["C_PLAN_ID"].ToString(), str_Stove);//上传A1

                        if (result_A1 != "1")
                        {
                            TransactionHelper.RollBack();
                            return result_A1;
                        }
                    }

                    #endregion


                    #region 添加操作记录

                    Mod_TSP_PLAN_SMS mod_Old = dalTspPlanSms.GetModel(dr["C_PLAN_ID"].ToString());
                    Mod_TSP_PLAN_SMS mod_New = dalTspPlanSms.GetModel_Trans(dr["C_PLAN_ID"].ToString());

                    Mod_TB_LG_PLAN_EDIT_LOG modLog = new Mod_TB_LG_PLAN_EDIT_LOG();
                    modLog.C_STOVE = str_Stove;
                    modLog.C_ORDER_ID_BEFORE = mod_Old.C_ORDER_NO;
                    modLog.C_STL_GRD_BEFORE = mod_Old.C_STL_GRD;
                    modLog.C_STD_CODE_BEFORE = mod_Old.C_STD_CODE;
                    modLog.C_SLAB_SIZE_BEFORE = mod_Old.C_SLAB_SIZE;
                    modLog.C_LENGTH_BEFORE = mod_Old.C_SLAB_LENGTH;
                    modLog.C_MAT_CODE_BEFORE = mod_Old.C_MATRL_NO;
                    modLog.C_ZL_DESC_BEFORE = dalTbSta.Get_STA_DESC(mod_Old.C_ZL_ID);
                    modLog.C_LF_DESC_BEFORE = dalTbSta.Get_STA_DESC(mod_Old.C_LF_ID);
                    modLog.C_RH_DESC_BEFORE = dalTbSta.Get_STA_DESC(mod_Old.C_RH_ID);
                    modLog.C_CC_DESC_BEFORE = mod_Old.C_CCM_DESC;
                    modLog.C_ORDER_ID_AFTER = mod_New.C_ORDER_NO;
                    modLog.C_STL_GRD_AFTER = mod_New.C_STL_GRD;
                    modLog.C_STD_CODE_AFTER = mod_New.C_STD_CODE;
                    modLog.C_SLAB_SIZE_AFTER = mod_New.C_SLAB_SIZE;
                    modLog.C_LENGTH_AFTER = mod_New.C_SLAB_LENGTH;
                    modLog.C_MAT_CODE_AFTER = mod_New.C_MATRL_NO;
                    modLog.C_ZL_DESC_AFTER = str_LD_Desc;
                    modLog.C_LF_DESC_AFTER = str_LF_Desc;
                    modLog.C_RH_DESC_AFTER = str_RH_Desc;
                    modLog.C_CC_DESC_AFTER = str_CC_Desc;
                    modLog.C_EMP_ID = strUserID;
                    modLog.C_EMP_NAME = RV.UI.UserInfo.userName;
                    modLog.D_MOD_DT = time;
                    modLog.C_REASON = strReason;

                    if (!dalTbLgPlanEditLog.Add_Trans(modLog))
                    {
                        TransactionHelper.RollBack();
                        return "添加操作记录失败！";
                    }

                    #endregion

                    TransactionHelper.Commit();
                }
                else
                {
                    TransactionHelper.RollBack();
                    return "请选择需要修改的炼钢计划!";
                }
            }
            catch (Exception ex)
            {
                TransactionHelper.RollBack();
                return ex.Message;
            }

            return result;
        }


        /// <summary>
        /// 撤销未下发到MES的工序计划
        /// </summary>
        /// <param name="str_cc_id">连铸id</param>
        /// <param name="strJC_ID">浇次主键</param>
        /// <returns></returns>
        public string Back_WXF(string str_cc_id, string strJC_ID)
        {
            string result = "1";
            try
            {
                TransactionHelper.BeginTransaction();

                string strUserID = RV.UI.UserInfo.userID;
                DateTime time = RV.UI.ServerTime.timeNow();

                //DataTable dt = dalTppCastPlan.Get_Back_List_WXF(str_cc_id, n_sort).Tables[0];//获取需要撤销的计划

                DataTable dt = dalTppCastPlan.Get_Back_List_WXF(str_cc_id, strJC_ID).Tables[0];//获取需要撤销的计划

                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        if (!dalTppCastPlan.delete_CAST_PLAN_Trans(dt.Rows[i]["C_ID"].ToString()))
                        {
                            TransactionHelper.RollBack();
                            return "0";
                        }

                        if (!dalTspPlanSms.Update_plan_Trans(dt.Rows[i]["C_PLAN_ID"].ToString()))
                        {
                            TransactionHelper.RollBack();
                            return "0";
                        }

                        Mod_TB_LG_PLAN_LOG modLog = new Mod_TB_LG_PLAN_LOG();
                        modLog.C_IP = GetLocalIP();
                        //modLog.C_STOVE = stove;
                        modLog.C_PLAN_ID = dt.Rows[i]["C_PLAN_ID"].ToString();
                        modLog.C_ORDER_NO = dt.Rows[i]["C_PLAN_ORD__ID"].ToString();
                        modLog.C_MES_PLAN_ID = dt.Rows[i]["C_MES_PLAN_ID"].ToString();
                        modLog.C_LD_DESC = dt.Rows[i]["C_LD_DESC"].ToString();
                        modLog.C_LF_DESC = dt.Rows[i]["C_LF_DESC"].ToString();
                        modLog.C_RH_DESC = dt.Rows[i]["C_RH_DESC"].ToString();
                        modLog.C_CC_DESC = dt.Rows[i]["C_CC_DESC"].ToString();
                        modLog.C_EMP_ID = strUserID;
                        modLog.D_MOD_DT = time;
                        modLog.C_REMARK = "取消调度";

                        if (!dalTbLgPlanLog.Add_Trans(modLog))
                        {
                            TransactionHelper.RollBack();
                            return "添加操作日志失败！";
                        }

                    }

                    Mod_TSP_CAST_PLAN model = dalTspCastPlan.GetModel(strJC_ID);
                    if (model == null)
                    {
                        TransactionHelper.RollBack();
                        return "0";
                    }
                    else
                    {
                        // int num = dalTspPlanSms.Get_Count_XF(strJC_ID);
                        model.N_STATUS = 1;//未下发调度

                        if (!dalTspCastPlan.Update_Trans(model))
                        {
                            TransactionHelper.RollBack();
                            return "0";
                        }
                    }

                    TransactionHelper.Commit();
                }//dt_CC
                else
                {
                    TransactionHelper.RollBack();
                    return "该浇次已全部下发MES，不能撤回，如需撤回，请先撤回下发到mes的炉次计划！";
                }
            }
            catch (Exception ex)
            {
                TransactionHelper.RollBack();
                return ex.Message;
            }

            return result;
        }


        /// <summary>
        /// 撤销已下发到MES的工序计划
        /// </summary>
        /// <param name="str_ld_id">转炉ID</param>
        /// <param name="stove">炉号</param>
        /// <returns></returns>
        public string Back_YXF(string str_ld_id, string stove)
        {
            string result = "1";
            try
            {
                TransactionHelper.BeginTransaction();

                string strUserID = RV.UI.UserInfo.userID;
                DateTime time = RV.UI.ServerTime.timeNow();

                DataTable dt = dalTppCastPlan.Get_Back_List_YXF(str_ld_id, stove).Tables[0];//获取需要撤销计划

                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        int count = dalTppCastPlan.Get_Stove_State(dt.Rows[i]["C_HEAT_ID"].ToString());

                        if (count > 0)
                        {
                            TransactionHelper.RollBack();
                            return "炉号：" + dt.Rows[i]["C_HEAT_ID"].ToString() + "的计划已执行，不能撤销";
                        }

                        if (!dalTppCastPlan.Update_CAST_PLAN_Trans(dt.Rows[i]["C_ID"].ToString()))
                        {
                            TransactionHelper.RollBack();
                            return "0";
                        }

                        if (!dalTspPlanSms.Update_plan_YXF_Trans(dt.Rows[i]["C_PLAN_ID"].ToString()))
                        {
                            TransactionHelper.RollBack();
                            return "0";
                        }

                        string sql_CPLAN_CASTING = "delete from CPLAN_CASTING@cap_mes where PLANID='" + dt.Rows[i]["C_MES_PLAN_ID"].ToString() + "' ";
                        string sql_CPLAN_TAPPING = "delete from CPLAN_TAPPING@cap_mes where PLANID='" + dt.Rows[i]["C_MES_PLAN_ID"].ToString() + "' ";
                        string sql_CPLAN_TAPPING_ACT = "delete from CPLAN_TAPPING_ACT@cap_mes where PREHEATID='" + dt.Rows[i]["C_MES_PLAN_ID"].ToString() + "' ";

                        if (!dalTppCastPlan.Delete_Mes_Trans(sql_CPLAN_CASTING))
                        {
                            TransactionHelper.RollBack();
                            return "0";
                        }

                        if (!dalTppCastPlan.Delete_Mes_Trans(sql_CPLAN_TAPPING))
                        {
                            TransactionHelper.RollBack();
                            return "0";
                        }

                        if (!dalTppCastPlan.Delete_Mes_Trans(sql_CPLAN_TAPPING_ACT))
                        {
                            TransactionHelper.RollBack();
                            return "0";
                        }

                        Mod_TB_LG_PLAN_LOG modLog = new Mod_TB_LG_PLAN_LOG();
                        modLog.C_IP = GetLocalIP();
                        modLog.C_STOVE = stove;
                        modLog.C_PLAN_ID = dt.Rows[i]["C_PLAN_ID"].ToString();
                        modLog.C_ORDER_NO = dt.Rows[i]["C_PLAN_ORD__ID"].ToString();
                        modLog.C_MES_PLAN_ID = dt.Rows[i]["C_MES_PLAN_ID"].ToString();
                        modLog.C_LD_DESC = dt.Rows[i]["C_LD_DESC"].ToString();
                        modLog.C_LF_DESC = dt.Rows[i]["C_LF_DESC"].ToString();
                        modLog.C_RH_DESC = dt.Rows[i]["C_RH_DESC"].ToString();
                        modLog.C_CC_DESC = dt.Rows[i]["C_CC_DESC"].ToString();
                        modLog.C_EMP_ID = strUserID;
                        modLog.D_MOD_DT = time;
                        modLog.C_REMARK = "撤回";

                        if (!dalTbLgPlanLog.Add_Trans(modLog))
                        {
                            TransactionHelper.RollBack();
                            return "添加操作日志失败！";
                        }
                    }

                    TransactionHelper.Commit();
                }//dt_CC
                else
                {
                    TransactionHelper.RollBack();
                    return "0";
                }
            }
            catch (Exception ex)
            {
                TransactionHelper.RollBack();
                return "0";
            }

            return result;
        }



        #region 计算轧钢计划时间

        private int faliNum = 0;//没有找到轧钢计划次数
        private List<CastInfo> lst_Cast = new List<CastInfo>();//按可排产订单的剩余量(按钢种、标准汇总)
        private List<CastInfo> lst_Temp = new List<CastInfo>();//按可排产订单的剩余量(按钢种、标准汇总)（临时）
        private string timeCC = ""; //钢坯可用时间

        /// <summary>
        /// 浇次基本信息类
        /// </summary>
        class CastInfo
        {
            private string _c_stl_grd; //钢种
            private string _c_std_code; //执行标准
            private decimal _n_wgt; //重量

            public CastInfo(string C_STL_GRD, string C_STD_CODE, decimal N_WGT)
            {
                this._c_stl_grd = C_STL_GRD;
                this._c_std_code = C_STD_CODE;
                this._n_wgt = N_WGT;
            }

            public string C_STL_GRD
            {
                get { return _c_stl_grd; }
                set { _c_stl_grd = value; }
            }

            public string C_STD_CODE
            {
                get { return _c_std_code; }
                set { _c_std_code = value; }
            }

            public decimal N_WGT
            {
                get { return _n_wgt; }
                set { _n_wgt = value; }
            }
        }

        /// <summary>
        /// 计算轧钢计划时间
        /// </summary>
        /// <returns></returns>
        public string Update_ZG_Plan_New()
        {
            try
            {
                string result = "成功";

                TransactionHelper.BeginTransaction();

                string strUserID = RV.UI.UserInfo.userID;

                bool IsComplete = false;

                while (!IsComplete)
                {
                    DataTable dt_Line = dalTrpPlanRoll.Get_Line_Lsit_Trans().Tables[0];

                    if (dt_Line.Rows.Count <= 0)
                    {
                        result = "成功";
                        break;
                    }

                    result = Check_Plan(dt_Line);//检测是否有可排轧钢计划（0-没有可排轧钢计划；1-有可排轧钢计划；其他-出错）

                    if (result == "0")//没有找到可轧计划
                    {
                        faliNum++;

                        if (faliNum == 1)
                        {
                            #region 计算下发3#CC、4#CC具体浇次

                            result = Get_Cast_Plan2();
                            if (result == "0")
                            {
                                result = "成功";
                                IsComplete = true;
                            }
                            else if (result == "1")
                            {
                                result = "成功";
                            }
                            else
                            {
                                IsComplete = true;
                            }

                            #endregion
                        }

                        if (faliNum >= 2)
                        {
                            #region 以钢坯可用时间去查找是否有可排轧钢计划

                            int num = 0;

                            DataTable dt_StdCode = dalTrpPlanRoll.Get_ZG_Std_Code_Trans("", "").Tables[0];//获取待轧的轧钢计划的钢种和执行标准
                            DataTable dt = new DataTable();
                            DataTable dtSlab = new DataTable();

                            for (int i = 0; i < dt_StdCode.Rows.Count; i++)
                            {
                                if (i == 0)
                                {
                                    dtSlab = dalTspPlanSms.Get_Slab_List_Trans(dt_StdCode.Rows[i]["C_STL_GRD"].ToString(), dt_StdCode.Rows[i]["C_STD_CODE"].ToString()).Tables[0];//获取指定钢种、标准的钢坯列表
                                }
                                else
                                {
                                    dt = dalTspPlanSms.Get_Slab_List_Trans(dt_StdCode.Rows[i]["C_STL_GRD"].ToString(), dt_StdCode.Rows[i]["C_STD_CODE"].ToString()).Tables[0];//获取指定钢种、标准的钢坯列表

                                    dtSlab.Merge(dt);
                                }
                            }

                            List<Mod_TSP_PLAN_SMS> lst_Slab = bllTspPlanSms.DataTableToList(dtSlab);

                            lst_Slab = lst_Slab.OrderBy(x => x.D_CAN_USE_TIME).ToList();

                            if (lst_Slab.Count > 0)
                            {
                                for (int i = 0; i < lst_Slab.Count; i++)
                                {
                                    timeCC = lst_Slab[i].D_CAN_USE_TIME.ToString();

                                    result = Check_Plan(dt_Line);//检测是否有可排轧钢计划（0-没有可排轧钢计划；1-有可排轧钢计划；其他-出错）

                                    if (result == "1")
                                    {
                                        num++;
                                        break;
                                    }
                                    else if (result != "0")//出错
                                    {
                                        IsComplete = true;
                                    }
                                }

                                if (num == 0)
                                {
                                    #region 计算下发3#CC、4#CC具体浇次

                                    result = Get_Cast_Plan2();//0-未找到浇次;1-成功；其他-失败
                                    if (result == "0")
                                    {
                                        result = "成功";
                                        IsComplete = true;
                                    }
                                    else if (result == "1")
                                    {
                                        result = "成功";
                                    }
                                    else
                                    {
                                        IsComplete = true;
                                    }

                                    #endregion
                                }
                            }
                            else
                            {
                                #region 计算下发3#CC、4#CC具体浇次

                                result = Get_Cast_Plan3();//0-未找到浇次;1-成功；其他-失败
                                if (result == "0")
                                {
                                    result = "成功";
                                    IsComplete = true;
                                }
                                else if (result == "1")
                                {
                                    result = "成功";
                                }
                                else
                                {
                                    IsComplete = true;
                                }

                                #endregion
                            }

                            #endregion
                        }
                    }
                    else if (result == "1")//有可排轧钢计划
                    {
                        faliNum = 0;

                        #region 计算下发3#CC、4#CC具体浇次

                        result = Get_Cast_Plan();
                        if (result != "1")
                        {
                            IsComplete = true;
                        }
                        else
                        {
                            result = "成功";
                        }

                        #endregion

                        #region 更新计划时间

                        result = Update_Plan_Time(dt_Line);

                        if (result != "1")
                        {
                            IsComplete = true;
                        }
                        else
                        {
                            result = "成功";
                        }

                        #endregion
                    }
                    else
                    {
                        IsComplete = true;
                    }
                }

                if (result == "成功")
                {
                    TransactionHelper.Commit();
                    return result;
                }
                else
                {
                    TransactionHelper.RollBack();
                    return result;
                }

            }
            catch (Exception ex)
            {
                TransactionHelper.RollBack();
                return ex.Message;
            }
        }

        /// <summary>
        /// 检测是否有可排轧钢计划
        /// </summary>
        /// <param name="dt_Line">轧线</param>
        /// <returns>0-没有可排轧钢计划；1-有可排轧钢计划；其他-出错</returns>
        private string Check_Plan(DataTable dt_Line)
        {
            try
            {
                string result = "0";

                decimal wgt_sd = 0;
                decimal wgt_kz = 0;
                string strSpec = "";
                DateTime time_KZ = RV.UI.ServerTime.timeNow();

                DataTable dt_Spec = new DataTable();

                lst_Cast.Clear();

                for (int i_Line = 0; i_Line < dt_Line.Rows.Count; i_Line++)
                {
                    wgt_sd = 600;

                    DataTable dt_Up = dalTrpPlanRoll.Get_Up_Plan_Trans(dt_Line.Rows[i_Line]["C_LINE_CODE"].ToString(), 2).Tables[0];//获取前两个计划

                    bool IsBreak = false;


                    #region 判断是否有前置计划

                    if (dt_Up.Rows.Count == 0)//没有前置计划
                    {
                        strSpec = "";

                        dt_Spec = dalTrpPlanRoll.Get_Spec_Max_Trans(dt_Line.Rows[i_Line]["C_LINE_CODE"].ToString(), "").Tables[0];//获取未排产的产线规格

                        if (dt_Spec.Rows.Count == 0)
                        {
                            continue;
                        }
                    }
                    else if (dt_Up.Rows.Count == 1)//只有一个前置计划
                    {
                        strSpec = dt_Up.Rows[0]["C_SPEC"].ToString();//上一个计划规格

                        dt_Spec = dalTrpPlanRoll.Get_Spec_Max_Trans(dt_Line.Rows[i_Line]["C_LINE_CODE"].ToString(), dt_Up.Rows[0]["C_SPEC"].ToString()).Tables[0];//获取未排产的产线规格(从小到大)

                        DataTable dt_temp = dalTrpPlanRoll.Get_Spec_Min_Trans(dt_Line.Rows[i_Line]["C_LINE_CODE"].ToString(), dt_Up.Rows[0]["C_SPEC"].ToString()).Tables[0];//获取未排产的产线规格(从大到小)

                        dt_Spec.Merge(dt_temp);

                        if (dt_Spec.Rows.Count == 0)
                        {
                            continue;
                        }
                    }
                    else if (dt_Up.Rows.Count == 2)//有两个前置计划
                    {
                        strSpec = dt_Up.Rows[0]["C_SPEC"].ToString();//上一个计划规格

                        if (Convert.ToDouble(dt_Up.Rows[0]["C_SPEC"].ToString().Substring(1)) >= Convert.ToDouble(dt_Up.Rows[1]["C_SPEC"].ToString().Substring(1)))
                        {
                            dt_Spec = dalTrpPlanRoll.Get_Spec_Max_Trans(dt_Line.Rows[i_Line]["C_LINE_CODE"].ToString(), dt_Up.Rows[0]["C_SPEC"].ToString()).Tables[0];//获取未排产的产线规格(从小到大)

                            DataTable dt_temp = dalTrpPlanRoll.Get_Spec_Min_Trans(dt_Line.Rows[i_Line]["C_LINE_CODE"].ToString(), dt_Up.Rows[0]["C_SPEC"].ToString()).Tables[0];//获取未排产的产线规格(从大到小)

                            dt_Spec.Merge(dt_temp);

                            if (dt_Spec.Rows.Count == 0)
                            {
                                continue;
                            }
                        }
                        else
                        {
                            dt_Spec = dalTrpPlanRoll.Get_Spec_Min_Trans(dt_Line.Rows[i_Line]["C_LINE_CODE"].ToString(), dt_Up.Rows[0]["C_SPEC"].ToString()).Tables[0];//获取未排产的产线规格(从大到小)

                            DataTable dt_temp = dalTrpPlanRoll.Get_Spec_Max_Trans(dt_Line.Rows[i_Line]["C_LINE_CODE"].ToString(), dt_Up.Rows[0]["C_SPEC"].ToString()).Tables[0];//获取未排产的产线规格((从小到大)

                            dt_Spec.Merge(dt_temp);

                            if (dt_Spec.Rows.Count == 0)
                            {
                                continue;
                            }
                        }
                    }

                    #endregion

                    #region 查找符合条件的计划信息

                    for (int i_wgt = Convert.ToInt32(wgt_sd); i_wgt >= 0; i_wgt = i_wgt - 100)
                    {
                        for (int i_Spec = 0; i_Spec < dt_Spec.Rows.Count; i_Spec++)
                        {
                            int count = dalTrpPlanRoll.Get_Count_Trans(dt_Line.Rows[i_Line]["C_LINE_CODE"].ToString(), dt_Spec.Rows[i_Spec]["C_SPEC"].ToString(), i_wgt);//判断指定规格订单是否大于设定重量

                            if (count == 0)
                            {
                                continue;
                            }

                            int hggTime = dalChangeTime.Get_Time(dt_Line.Rows[i_Line]["C_LINE_CODE"].ToString(), strSpec, dt_Spec.Rows[i_Spec]["C_SPEC"].ToString());//换规格时间

                            if (dt_Up.Rows.Count > 0)
                            {
                                time_KZ = Convert.ToDateTime(dt_Up.Rows[0]["D_P_END_TIME"].ToString());//上一个计划结束时间
                                time_KZ = time_KZ.AddMinutes(hggTime);
                            }

                            if (!string.IsNullOrEmpty(timeCC))
                            {
                                if (time_KZ < Convert.ToDateTime(timeCC))
                                {
                                    time_KZ = Convert.ToDateTime(timeCC);
                                }
                            }

                            lst_Temp.Clear();

                            wgt_kz = Get_Slab_Wgt(dt_Line.Rows[i_Line]["C_LINE_CODE"].ToString(), dt_Spec.Rows[i_Spec]["C_SPEC"].ToString(), time_KZ.ToString(), out lst_Temp);

                            if (wgt_kz == decimal.MinValue)
                            {
                                return "重量异常";
                            }

                            if (wgt_kz > i_wgt)
                            {
                                bool isFind = false;
                                for (int mm = 0; mm < lst_Temp.Count; mm++)
                                {
                                    isFind = false;
                                    if (lst_Cast.Count == 0)
                                    {
                                        lst_Cast.Add(lst_Temp[mm]);
                                        continue;
                                    }
                                    else
                                    {
                                        for (int jcNum = 0; jcNum < lst_Cast.Count; jcNum++)
                                        {
                                            if (lst_Temp[mm].C_STL_GRD == lst_Cast[jcNum].C_STL_GRD && lst_Temp[mm].C_STD_CODE == lst_Cast[jcNum].C_STD_CODE)
                                            {
                                                isFind = true;
                                                lst_Cast[jcNum].N_WGT = lst_Cast[jcNum].N_WGT + lst_Temp[mm].N_WGT;
                                                break;
                                            }
                                            else
                                            {
                                                continue;
                                            }
                                        }

                                        if (!isFind)
                                        {
                                            lst_Cast.Add(lst_Temp[mm]);
                                        }
                                    }
                                }

                                IsBreak = true;

                                break;
                            }
                        }

                        if (IsBreak)
                        {
                            result = "1";

                            break;
                        }
                    }

                    #endregion

                }

                return result;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        /// <summary>
        /// 按可排产订单的剩余量获取浇次信息（5#CC除外）
        /// </summary>
        /// <returns>1-成功；其他-失败</returns>
        private string Get_Cast_Plan()
        {
            #region 计算下发3#CC、4#CC具体浇次

            try
            {
                if (lst_Cast.Count > 0)
                {
                    lst_Cast = lst_Cast.OrderByDescending(x => x.N_WGT).ToList();

                    DataTable dt_Cast = new DataTable();
                    for (int i_CC = 0; i_CC < lst_Cast.Count; i_CC++)
                    {
                        dt_Cast = dalTppLgpcLclsb.Get_Cast_ID_Trans(lst_Cast[i_CC].C_STL_GRD, lst_Cast[i_CC].C_STD_CODE).Tables[0];
                        if (dt_Cast.Rows.Count > 0)
                        {
                            string strID = "";
                            for (int jj = 0; jj < dt_Cast.Rows.Count; jj++)
                            {
                                strID = strID + "'" + dt_Cast.Rows[jj]["C_FK"].ToString() + "',";
                            }

                            if (strID.Length > 0)
                            {
                                strID = strID.Substring(0, strID.Length - 1);
                            }

                            List<Mod_TPP_LGPC_LCLSB> lst_Lclsb = bllTppLgpcLclsb.DataTableToList(dalTppLgpcLclsb.Get_LC_List_Trans(strID).Tables[0]);

                            DataTable dt_Sort = dalTspPlanSms.Get_Max_Sort_Trans().Tables[0];

                            for (int i_Lclsb = 0; i_Lclsb < lst_Lclsb.Count; i_Lclsb++)
                            {
                                #region 计算3#CC、4#CC连铸生产顺序和计划开始时间和计划结束时间

                                int n_Sort = 0;
                                DateTime startTime = DateTime.Now.AddDays(-2);
                                DateTime endTime = startTime.AddMinutes(30);
                                double cn = 0;

                                bool isHaving = false;

                                for (int i_Sort = 0; i_Sort < dt_Sort.Rows.Count; i_Sort++)
                                {
                                    if (lst_Lclsb[i_Lclsb].C_CCM_ID.ToString() == dt_Sort.Rows[i_Sort]["C_CCM_ID"].ToString())
                                    {
                                        isHaving = true;

                                        dt_Sort.Rows[i_Sort]["N_SORT"] = Convert.ToInt32(dt_Sort.Rows[i_Sort]["N_SORT"].ToString()) + 1;
                                        n_Sort = Convert.ToInt32(dt_Sort.Rows[i_Sort]["N_SORT"].ToString());
                                        if (!string.IsNullOrEmpty(dt_Sort.Rows[i_Sort]["D_P_END_TIME"].ToString()))
                                        {
                                            startTime = Convert.ToDateTime(dt_Sort.Rows[i_Sort]["D_P_END_TIME"].ToString());
                                        }

                                        cn = Convert.ToDouble(lst_Lclsb[i_Lclsb].N_SLAB_WGT) / Convert.ToDouble(lst_Lclsb[i_Lclsb].N_JSCN);

                                        endTime = startTime.AddHours(cn);

                                        dt_Sort.Rows[i_Sort]["D_P_END_TIME"] = endTime;

                                        break;
                                    }
                                }

                                if (!isHaving)
                                {
                                    n_Sort++;

                                    cn = Convert.ToDouble(lst_Lclsb[i_Lclsb].N_SLAB_WGT) / Convert.ToDouble(lst_Lclsb[i_Lclsb].N_JSCN);

                                    endTime = startTime.AddHours(cn);

                                    DataRow dr = dt_Sort.NewRow();
                                    dr["N_SORT"] = n_Sort;
                                    dr["C_CCM_ID"] = lst_Lclsb[i_Lclsb].C_CCM_ID;
                                    dr["D_P_END_TIME"] = endTime;
                                    dt_Sort.Rows.Add(dr);
                                }

                                #endregion

                                #region 将炉次计划添加到Tsp_Plan_Sms中

                                #region 实体赋值

                                Mod_TSP_PLAN_SMS mod_Sms = new Mod_TSP_PLAN_SMS();
                                mod_Sms.C_ID = lst_Lclsb[i_Lclsb].C_ID;
                                mod_Sms.C_ORDER_NO = lst_Lclsb[i_Lclsb].C_ORDER_NO;
                                mod_Sms.C_DESIGN_NO = lst_Lclsb[i_Lclsb].C_DESIGN_NO;
                                mod_Sms.N_SLAB_WGT = lst_Lclsb[i_Lclsb].N_SLAB_WGT;
                                mod_Sms.C_CTRL_NO = lst_Lclsb[i_Lclsb].C_CTRL_NO;
                                mod_Sms.C_CCM_ID = lst_Lclsb[i_Lclsb].C_CCM_ID;
                                mod_Sms.C_CCM_DESC = lst_Lclsb[i_Lclsb].C_CCM_DESC;
                                mod_Sms.C_PROD_NAME = lst_Lclsb[i_Lclsb].C_PROD_NAME;
                                mod_Sms.C_STL_GRD = lst_Lclsb[i_Lclsb].C_STL_GRD;
                                mod_Sms.C_SPEC_CODE = lst_Lclsb[i_Lclsb].C_SPEC_CODE;
                                mod_Sms.C_LENGTH = lst_Lclsb[i_Lclsb].C_LENGTH;
                                mod_Sms.C_MATRL_NO = lst_Lclsb[i_Lclsb].C_MATRL_NO;
                                mod_Sms.C_MATRL_NAME = lst_Lclsb[i_Lclsb].C_MATRL_NAME;
                                mod_Sms.C_SLAB_SIZE = lst_Lclsb[i_Lclsb].C_SLAB_SIZE;
                                mod_Sms.C_SLAB_LENGTH = lst_Lclsb[i_Lclsb].C_SLAB_LENGTH;
                                mod_Sms.C_STATE = lst_Lclsb[i_Lclsb].C_STATE;
                                mod_Sms.C_STD_CODE = lst_Lclsb[i_Lclsb].C_STD_CODE;
                                mod_Sms.C_INITIALIZE_ITEM_ID = lst_Lclsb[i_Lclsb].C_INITIALIZE_ITEM_ID;
                                mod_Sms.D_P_START_TIME = startTime;//计划开始时间
                                mod_Sms.D_P_END_TIME = endTime;//计划结束时间
                                mod_Sms.N_PROD_TIME = lst_Lclsb[i_Lclsb].N_PROD_TIME;
                                mod_Sms.N_SORT = n_Sort;//顺序号
                                mod_Sms.C_CAST_NO = lst_Lclsb[i_Lclsb].C_CAST_NO;
                                mod_Sms.N_STATUS = lst_Lclsb[i_Lclsb].N_STATUS;
                                mod_Sms.C_EMP_ID = lst_Lclsb[i_Lclsb].C_EMP_ID;
                                mod_Sms.D_MOD_DT = lst_Lclsb[i_Lclsb].D_MOD_DT;
                                //mod_Sms.C_REMARK = lst_Lclsb[i_Lclsb].C_REMARK;
                                mod_Sms.C_REMARK = "张明才";
                                mod_Sms.N_CREAT_PLAN = lst_Lclsb[i_Lclsb].N_CREAT_PLAN;
                                mod_Sms.N_CREAT_ZG_PLAN = lst_Lclsb[i_Lclsb].N_CREAT_ZG_PLAN;
                                mod_Sms.N_PRODUCE_TIME = lst_Lclsb[i_Lclsb].N_PRODUCE_TIME;
                                mod_Sms.C_ZL_ID = lst_Lclsb[i_Lclsb].C_ZL_ID;
                                mod_Sms.C_LF_ID = lst_Lclsb[i_Lclsb].C_LF_ID;
                                mod_Sms.C_RH_ID = lst_Lclsb[i_Lclsb].C_RH_ID;
                                mod_Sms.C_LGJH = lst_Lclsb[i_Lclsb].C_LGJH;
                                mod_Sms.C_QUA = lst_Lclsb[i_Lclsb].C_QUA;
                                mod_Sms.D_ARRIVE_ZG_TIME = lst_Lclsb[i_Lclsb].D_ARRIVE_ZG_TIME;
                                mod_Sms.C_BY1 = lst_Lclsb[i_Lclsb].C_BY1;
                                mod_Sms.C_BY2 = lst_Lclsb[i_Lclsb].C_BY2;
                                mod_Sms.C_BY3 = lst_Lclsb[i_Lclsb].C_BY3;
                                mod_Sms.C_RH = lst_Lclsb[i_Lclsb].C_RH;
                                mod_Sms.C_DFP_HL = lst_Lclsb[i_Lclsb].C_DFP_HL;
                                mod_Sms.C_HL = lst_Lclsb[i_Lclsb].C_HL;
                                mod_Sms.C_XM = lst_Lclsb[i_Lclsb].C_XM;
                                mod_Sms.D_DFPHL_START_TIME = lst_Lclsb[i_Lclsb].D_DFPHL_START_TIME;
                                mod_Sms.D_DFPHL_END_TIME = lst_Lclsb[i_Lclsb].D_DFPHL_END_TIME;
                                mod_Sms.D_KP_START_TIME = lst_Lclsb[i_Lclsb].D_KP_START_TIME;
                                mod_Sms.D_KP_END_TIME = lst_Lclsb[i_Lclsb].D_KP_END_TIME;
                                mod_Sms.D_HL_START_TIME = lst_Lclsb[i_Lclsb].D_HL_START_TIME;
                                mod_Sms.D_HL_END_TIME = lst_Lclsb[i_Lclsb].D_HL_END_TIME;
                                mod_Sms.D_PLAN_KY_TIME = lst_Lclsb[i_Lclsb].D_PLAN_KY_TIME;
                                mod_Sms.C_PLAN_ROLL = lst_Lclsb[i_Lclsb].C_PLAN_ROLL;
                                mod_Sms.D_ZZ_START_TIME = lst_Lclsb[i_Lclsb].D_ZZ_START_TIME;
                                mod_Sms.D_ZZ_END_TIME = lst_Lclsb[i_Lclsb].D_ZZ_END_TIME;
                                mod_Sms.D_XM_START_TIME = lst_Lclsb[i_Lclsb].D_XM_START_TIME;
                                mod_Sms.D_XM_END_TIME = lst_Lclsb[i_Lclsb].D_XM_END_TIME;
                                mod_Sms.C_STOVE_NO = lst_Lclsb[i_Lclsb].C_STOVE_NO;
                                mod_Sms.D_DFPHL_START_TIME_SJ = lst_Lclsb[i_Lclsb].D_DFPHL_START_TIME_SJ;
                                mod_Sms.D_DFPHL_END_TIME_SJ = lst_Lclsb[i_Lclsb].D_DFPHL_END_TIME_SJ;
                                mod_Sms.D_KP_START_TIME_SJ = lst_Lclsb[i_Lclsb].D_KP_START_TIME_SJ;
                                mod_Sms.D_KP_END_TIME_SJ = lst_Lclsb[i_Lclsb].D_KP_END_TIME_SJ;
                                mod_Sms.D_HL_START_TIME_SJ = lst_Lclsb[i_Lclsb].D_HL_START_TIME_SJ;
                                mod_Sms.D_HL_END_TIME_SJ = lst_Lclsb[i_Lclsb].D_HL_END_TIME_SJ;
                                mod_Sms.D_XM_START_TIME_SJ = lst_Lclsb[i_Lclsb].D_XM_START_TIME_SJ;
                                mod_Sms.D_XM_END_TIME_SJ = lst_Lclsb[i_Lclsb].D_XM_END_TIME_SJ;
                                mod_Sms.N_SJ_WGT = lst_Lclsb[i_Lclsb].N_SJ_WGT;
                                mod_Sms.D_START_TIME_SJ = lst_Lclsb[i_Lclsb].D_START_TIME_SJ;
                                mod_Sms.D_END_TIME_SJ = lst_Lclsb[i_Lclsb].D_END_TIME_SJ;
                                mod_Sms.N_DFP_HL_TIME = lst_Lclsb[i_Lclsb].N_DFP_HL_TIME;
                                mod_Sms.N_HL_TIME = lst_Lclsb[i_Lclsb].N_HL_TIME;
                                mod_Sms.C_ROUTE = lst_Lclsb[i_Lclsb].C_ROUTE;
                                mod_Sms.N_SLAB_PW = lst_Lclsb[i_Lclsb].N_SLAB_PW;
                                mod_Sms.C_MATRL_CODE_KP = lst_Lclsb[i_Lclsb].C_MATRL_CODE_KP;
                                mod_Sms.C_MATRL_NAME_KP = lst_Lclsb[i_Lclsb].C_MATRL_NAME_KP;
                                mod_Sms.C_KP_SIZE = lst_Lclsb[i_Lclsb].C_KP_SIZE;
                                mod_Sms.N_KP_LENGTH = lst_Lclsb[i_Lclsb].N_KP_LENGTH;
                                mod_Sms.N_KP_PW = lst_Lclsb[i_Lclsb].N_KP_PW;
                                mod_Sms.N_USE_WGT = lst_Lclsb[i_Lclsb].N_USE_WGT;
                                mod_Sms.D_USE_START_TIME_SJ = lst_Lclsb[i_Lclsb].D_USE_START_TIME_SJ;
                                mod_Sms.D_USE_END_TIME_SJ = lst_Lclsb[i_Lclsb].D_USE_END_TIME_SJ;
                                mod_Sms.D_CAN_USE_TIME = endTime.AddHours(2);//可用时间
                                mod_Sms.N_RH_NUM = lst_Lclsb[i_Lclsb].N_RH_NUM;
                                mod_Sms.N_KP_WGT = lst_Lclsb[i_Lclsb].N_KP_WGT;
                                mod_Sms.N_XM_WGT = lst_Lclsb[i_Lclsb].N_XM_WGT;
                                mod_Sms.C_DFP_RZ = string.IsNullOrEmpty(lst_Lclsb[i_Lclsb].C_DFP_RZ) == true ? "N" : lst_Lclsb[i_Lclsb].C_DFP_RZ;
                                mod_Sms.C_RZP_RZ = string.IsNullOrEmpty(lst_Lclsb[i_Lclsb].C_RZP_RZ) == true ? "N" : lst_Lclsb[i_Lclsb].C_RZP_RZ;
                                mod_Sms.C_DFP_YQ = lst_Lclsb[i_Lclsb].C_DFP_YQ;
                                mod_Sms.C_RZP_YQ = lst_Lclsb[i_Lclsb].C_RZP_YQ;
                                mod_Sms.C_STL_GRD_TYPE = lst_Lclsb[i_Lclsb].C_STL_GRD_TYPE;
                                mod_Sms.C_PROD_KIND = lst_Lclsb[i_Lclsb].C_PROD_KIND;
                                mod_Sms.C_TL = lst_Lclsb[i_Lclsb].C_TL;
                                mod_Sms.N_JSCN = lst_Lclsb[i_Lclsb].N_JSCN;
                                mod_Sms.C_FREE1 = lst_Lclsb[i_Lclsb].C_FREE1;
                                mod_Sms.C_FREE2 = lst_Lclsb[i_Lclsb].C_FREE2;
                                mod_Sms.N_GROUP = lst_Lclsb[i_Lclsb].N_GROUP;
                                mod_Sms.C_FK = lst_Lclsb[i_Lclsb].C_FK;
                                mod_Sms.N_ZJCLS = lst_Lclsb[i_Lclsb].N_ZJCLS;
                                mod_Sms.N_ZJCLS_MIN = lst_Lclsb[i_Lclsb].N_ZJCLS_MIN;
                                mod_Sms.N_ZJCLS_MAX = lst_Lclsb[i_Lclsb].N_ZJCLS_MAX;
                                mod_Sms.C_SL = lst_Lclsb[i_Lclsb].C_SL;
                                mod_Sms.C_WL = lst_Lclsb[i_Lclsb].C_WL;
                                mod_Sms.C_SLAB_TYPE = lst_Lclsb[i_Lclsb].C_SLAB_TYPE;

                                #endregion

                                if (!dalTspPlanSms.Add_Trans(mod_Sms))
                                {
                                    return "插入炉次计划失败";
                                }

                                #endregion
                            }

                            #region 将TPP_LGPC_LCLSB表数据停用

                            if (!dalTppLgpcLclsb.Update_Trans(strID))
                            {
                                return "删除炉次计划临时表失败";
                            }

                            #endregion


                            #region 将TPP_LGPC_LSB表数据停用

                            if (!dalTppLgpcLsb.Update_Trans(strID))
                            {
                                return "删除浇次计划临时表失败";
                            }

                            #endregion

                            break;
                        }
                    }
                }

                return "1";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

            #endregion
        }

        /// <summary>
        /// 按订单的剩余量获取浇次信息（5#CC除外）
        /// </summary>
        /// <returns>0-未找到浇次;1-成功；其他-失败</returns>
        private string Get_Cast_Plan2()
        {
            #region 计算下发3#CC、4#CC具体浇次

            try
            {
                int num = 0;
                DataTable dt_ZG = dalTrpPlanRoll.Get_ZG_Plan_Trans().Tables[0];
                DataTable dt_Cast = new DataTable();
                for (int i_ZG = 0; i_ZG < dt_ZG.Rows.Count; i_ZG++)
                {
                    dt_Cast = dalTppLgpcLclsb.Get_Cast_ID_Trans(dt_ZG.Rows[i_ZG]["C_STL_GRD"].ToString(), dt_ZG.Rows[i_ZG]["C_STD_CODE"].ToString()).Tables[0];
                    if (dt_Cast.Rows.Count > 0)
                    {
                        string strID = "";
                        for (int jj = 0; jj < dt_Cast.Rows.Count; jj++)
                        {
                            strID = strID + "'" + dt_Cast.Rows[jj]["C_FK"].ToString() + "',";
                        }

                        if (strID.Length > 0)
                        {
                            strID = strID.Substring(0, strID.Length - 1);
                        }

                        List<Mod_TPP_LGPC_LCLSB> lst_Lclsb = bllTppLgpcLclsb.DataTableToList(dalTppLgpcLclsb.Get_LC_List_Trans(strID).Tables[0]);

                        DataTable dt_Sort = dalTspPlanSms.Get_Max_Sort_Trans().Tables[0];

                        for (int i_Lclsb = 0; i_Lclsb < lst_Lclsb.Count; i_Lclsb++)
                        {
                            #region 计算3#CC、4#CC连铸生产顺序和计划开始时间和计划结束时间

                            int n_Sort = 0;
                            DateTime startTime = DateTime.Now.AddDays(-2);
                            DateTime endTime = startTime.AddMinutes(30);
                            double cn = 0;

                            bool isHaving = false;

                            for (int i_Sort = 0; i_Sort < dt_Sort.Rows.Count; i_Sort++)
                            {
                                if (lst_Lclsb[i_Lclsb].C_CCM_ID.ToString() == dt_Sort.Rows[i_Sort]["C_CCM_ID"].ToString())
                                {
                                    isHaving = true;

                                    dt_Sort.Rows[i_Sort]["N_SORT"] = Convert.ToInt32(dt_Sort.Rows[i_Sort]["N_SORT"].ToString()) + 1;
                                    n_Sort = Convert.ToInt32(dt_Sort.Rows[i_Sort]["N_SORT"].ToString());
                                    if (!string.IsNullOrEmpty(dt_Sort.Rows[i_Sort]["D_P_END_TIME"].ToString()))
                                    {
                                        startTime = Convert.ToDateTime(dt_Sort.Rows[i_Sort]["D_P_END_TIME"].ToString());
                                    }

                                    cn = Convert.ToDouble(lst_Lclsb[i_Lclsb].N_SLAB_WGT) / Convert.ToDouble(lst_Lclsb[i_Lclsb].N_JSCN);

                                    endTime = startTime.AddHours(cn);

                                    dt_Sort.Rows[i_Sort]["D_P_END_TIME"] = endTime;

                                    break;
                                }
                            }

                            if (!isHaving)
                            {
                                n_Sort++;

                                cn = Convert.ToDouble(lst_Lclsb[i_Lclsb].N_SLAB_WGT) / Convert.ToDouble(lst_Lclsb[i_Lclsb].N_JSCN);

                                endTime = startTime.AddHours(cn);

                                DataRow dr = dt_Sort.NewRow();
                                dr["N_SORT"] = n_Sort;
                                dr["C_CCM_ID"] = lst_Lclsb[i_Lclsb].C_CCM_ID;
                                dr["D_P_END_TIME"] = endTime;
                                dt_Sort.Rows.Add(dr);
                            }

                            #endregion

                            #region 将炉次计划添加到Tsp_Plan_Sms中

                            #region 实体赋值

                            Mod_TSP_PLAN_SMS mod_Sms = new Mod_TSP_PLAN_SMS();
                            mod_Sms.C_ID = lst_Lclsb[i_Lclsb].C_ID;
                            mod_Sms.C_ORDER_NO = lst_Lclsb[i_Lclsb].C_ORDER_NO;
                            mod_Sms.C_DESIGN_NO = lst_Lclsb[i_Lclsb].C_DESIGN_NO;
                            mod_Sms.N_SLAB_WGT = lst_Lclsb[i_Lclsb].N_SLAB_WGT;
                            mod_Sms.C_CTRL_NO = lst_Lclsb[i_Lclsb].C_CTRL_NO;
                            mod_Sms.C_CCM_ID = lst_Lclsb[i_Lclsb].C_CCM_ID;
                            mod_Sms.C_CCM_DESC = lst_Lclsb[i_Lclsb].C_CCM_DESC;
                            mod_Sms.C_PROD_NAME = lst_Lclsb[i_Lclsb].C_PROD_NAME;
                            mod_Sms.C_STL_GRD = lst_Lclsb[i_Lclsb].C_STL_GRD;
                            mod_Sms.C_SPEC_CODE = lst_Lclsb[i_Lclsb].C_SPEC_CODE;
                            mod_Sms.C_LENGTH = lst_Lclsb[i_Lclsb].C_LENGTH;
                            mod_Sms.C_MATRL_NO = lst_Lclsb[i_Lclsb].C_MATRL_NO;
                            mod_Sms.C_MATRL_NAME = lst_Lclsb[i_Lclsb].C_MATRL_NAME;
                            mod_Sms.C_SLAB_SIZE = lst_Lclsb[i_Lclsb].C_SLAB_SIZE;
                            mod_Sms.C_SLAB_LENGTH = lst_Lclsb[i_Lclsb].C_SLAB_LENGTH;
                            mod_Sms.C_STATE = lst_Lclsb[i_Lclsb].C_STATE;
                            mod_Sms.C_STD_CODE = lst_Lclsb[i_Lclsb].C_STD_CODE;
                            mod_Sms.C_INITIALIZE_ITEM_ID = lst_Lclsb[i_Lclsb].C_INITIALIZE_ITEM_ID;
                            mod_Sms.D_P_START_TIME = startTime;//计划开始时间
                            mod_Sms.D_P_END_TIME = endTime;//计划结束时间
                            mod_Sms.N_PROD_TIME = lst_Lclsb[i_Lclsb].N_PROD_TIME;
                            mod_Sms.N_SORT = n_Sort;//顺序号
                            mod_Sms.C_CAST_NO = lst_Lclsb[i_Lclsb].C_CAST_NO;
                            mod_Sms.N_STATUS = lst_Lclsb[i_Lclsb].N_STATUS;
                            mod_Sms.C_EMP_ID = lst_Lclsb[i_Lclsb].C_EMP_ID;
                            mod_Sms.D_MOD_DT = lst_Lclsb[i_Lclsb].D_MOD_DT;
                            //mod_Sms.C_REMARK = lst_Lclsb[i_Lclsb].C_REMARK;
                            mod_Sms.C_REMARK = "张明才";
                            mod_Sms.N_CREAT_PLAN = lst_Lclsb[i_Lclsb].N_CREAT_PLAN;
                            mod_Sms.N_CREAT_ZG_PLAN = lst_Lclsb[i_Lclsb].N_CREAT_ZG_PLAN;
                            mod_Sms.N_PRODUCE_TIME = lst_Lclsb[i_Lclsb].N_PRODUCE_TIME;
                            mod_Sms.C_ZL_ID = lst_Lclsb[i_Lclsb].C_ZL_ID;
                            mod_Sms.C_LF_ID = lst_Lclsb[i_Lclsb].C_LF_ID;
                            mod_Sms.C_RH_ID = lst_Lclsb[i_Lclsb].C_RH_ID;
                            mod_Sms.C_LGJH = lst_Lclsb[i_Lclsb].C_LGJH;
                            mod_Sms.C_QUA = lst_Lclsb[i_Lclsb].C_QUA;
                            mod_Sms.D_ARRIVE_ZG_TIME = lst_Lclsb[i_Lclsb].D_ARRIVE_ZG_TIME;
                            mod_Sms.C_BY1 = lst_Lclsb[i_Lclsb].C_BY1;
                            mod_Sms.C_BY2 = lst_Lclsb[i_Lclsb].C_BY2;
                            mod_Sms.C_BY3 = lst_Lclsb[i_Lclsb].C_BY3;
                            mod_Sms.C_RH = lst_Lclsb[i_Lclsb].C_RH;
                            mod_Sms.C_DFP_HL = lst_Lclsb[i_Lclsb].C_DFP_HL;
                            mod_Sms.C_HL = lst_Lclsb[i_Lclsb].C_HL;
                            mod_Sms.C_XM = lst_Lclsb[i_Lclsb].C_XM;
                            mod_Sms.D_DFPHL_START_TIME = lst_Lclsb[i_Lclsb].D_DFPHL_START_TIME;
                            mod_Sms.D_DFPHL_END_TIME = lst_Lclsb[i_Lclsb].D_DFPHL_END_TIME;
                            mod_Sms.D_KP_START_TIME = lst_Lclsb[i_Lclsb].D_KP_START_TIME;
                            mod_Sms.D_KP_END_TIME = lst_Lclsb[i_Lclsb].D_KP_END_TIME;
                            mod_Sms.D_HL_START_TIME = lst_Lclsb[i_Lclsb].D_HL_START_TIME;
                            mod_Sms.D_HL_END_TIME = lst_Lclsb[i_Lclsb].D_HL_END_TIME;
                            mod_Sms.D_PLAN_KY_TIME = lst_Lclsb[i_Lclsb].D_PLAN_KY_TIME;
                            mod_Sms.C_PLAN_ROLL = lst_Lclsb[i_Lclsb].C_PLAN_ROLL;
                            mod_Sms.D_ZZ_START_TIME = lst_Lclsb[i_Lclsb].D_ZZ_START_TIME;
                            mod_Sms.D_ZZ_END_TIME = lst_Lclsb[i_Lclsb].D_ZZ_END_TIME;
                            mod_Sms.D_XM_START_TIME = lst_Lclsb[i_Lclsb].D_XM_START_TIME;
                            mod_Sms.D_XM_END_TIME = lst_Lclsb[i_Lclsb].D_XM_END_TIME;
                            mod_Sms.C_STOVE_NO = lst_Lclsb[i_Lclsb].C_STOVE_NO;
                            mod_Sms.D_DFPHL_START_TIME_SJ = lst_Lclsb[i_Lclsb].D_DFPHL_START_TIME_SJ;
                            mod_Sms.D_DFPHL_END_TIME_SJ = lst_Lclsb[i_Lclsb].D_DFPHL_END_TIME_SJ;
                            mod_Sms.D_KP_START_TIME_SJ = lst_Lclsb[i_Lclsb].D_KP_START_TIME_SJ;
                            mod_Sms.D_KP_END_TIME_SJ = lst_Lclsb[i_Lclsb].D_KP_END_TIME_SJ;
                            mod_Sms.D_HL_START_TIME_SJ = lst_Lclsb[i_Lclsb].D_HL_START_TIME_SJ;
                            mod_Sms.D_HL_END_TIME_SJ = lst_Lclsb[i_Lclsb].D_HL_END_TIME_SJ;
                            mod_Sms.D_XM_START_TIME_SJ = lst_Lclsb[i_Lclsb].D_XM_START_TIME_SJ;
                            mod_Sms.D_XM_END_TIME_SJ = lst_Lclsb[i_Lclsb].D_XM_END_TIME_SJ;
                            mod_Sms.N_SJ_WGT = lst_Lclsb[i_Lclsb].N_SJ_WGT;
                            mod_Sms.D_START_TIME_SJ = lst_Lclsb[i_Lclsb].D_START_TIME_SJ;
                            mod_Sms.D_END_TIME_SJ = lst_Lclsb[i_Lclsb].D_END_TIME_SJ;
                            mod_Sms.N_DFP_HL_TIME = lst_Lclsb[i_Lclsb].N_DFP_HL_TIME;
                            mod_Sms.N_HL_TIME = lst_Lclsb[i_Lclsb].N_HL_TIME;
                            mod_Sms.C_ROUTE = lst_Lclsb[i_Lclsb].C_ROUTE;
                            mod_Sms.N_SLAB_PW = lst_Lclsb[i_Lclsb].N_SLAB_PW;
                            mod_Sms.C_MATRL_CODE_KP = lst_Lclsb[i_Lclsb].C_MATRL_CODE_KP;
                            mod_Sms.C_MATRL_NAME_KP = lst_Lclsb[i_Lclsb].C_MATRL_NAME_KP;
                            mod_Sms.C_KP_SIZE = lst_Lclsb[i_Lclsb].C_KP_SIZE;
                            mod_Sms.N_KP_LENGTH = lst_Lclsb[i_Lclsb].N_KP_LENGTH;
                            mod_Sms.N_KP_PW = lst_Lclsb[i_Lclsb].N_KP_PW;
                            mod_Sms.N_USE_WGT = lst_Lclsb[i_Lclsb].N_USE_WGT;
                            mod_Sms.D_USE_START_TIME_SJ = lst_Lclsb[i_Lclsb].D_USE_START_TIME_SJ;
                            mod_Sms.D_USE_END_TIME_SJ = lst_Lclsb[i_Lclsb].D_USE_END_TIME_SJ;
                            mod_Sms.D_CAN_USE_TIME = endTime.AddHours(2);//可用时间
                            mod_Sms.N_RH_NUM = lst_Lclsb[i_Lclsb].N_RH_NUM;
                            mod_Sms.N_KP_WGT = lst_Lclsb[i_Lclsb].N_KP_WGT;
                            mod_Sms.N_XM_WGT = lst_Lclsb[i_Lclsb].N_XM_WGT;
                            mod_Sms.C_DFP_RZ = string.IsNullOrEmpty(lst_Lclsb[i_Lclsb].C_DFP_RZ) == true ? "N" : lst_Lclsb[i_Lclsb].C_DFP_RZ;
                            mod_Sms.C_RZP_RZ = string.IsNullOrEmpty(lst_Lclsb[i_Lclsb].C_RZP_RZ) == true ? "N" : lst_Lclsb[i_Lclsb].C_RZP_RZ;
                            mod_Sms.C_DFP_YQ = lst_Lclsb[i_Lclsb].C_DFP_YQ;
                            mod_Sms.C_RZP_YQ = lst_Lclsb[i_Lclsb].C_RZP_YQ;
                            mod_Sms.C_STL_GRD_TYPE = lst_Lclsb[i_Lclsb].C_STL_GRD_TYPE;
                            mod_Sms.C_PROD_KIND = lst_Lclsb[i_Lclsb].C_PROD_KIND;
                            mod_Sms.C_TL = lst_Lclsb[i_Lclsb].C_TL;
                            mod_Sms.N_JSCN = lst_Lclsb[i_Lclsb].N_JSCN;
                            mod_Sms.C_FREE1 = lst_Lclsb[i_Lclsb].C_FREE1;
                            mod_Sms.C_FREE2 = lst_Lclsb[i_Lclsb].C_FREE2;
                            mod_Sms.N_GROUP = lst_Lclsb[i_Lclsb].N_GROUP;
                            mod_Sms.C_FK = lst_Lclsb[i_Lclsb].C_FK;
                            mod_Sms.N_ZJCLS = lst_Lclsb[i_Lclsb].N_ZJCLS;
                            mod_Sms.N_ZJCLS_MIN = lst_Lclsb[i_Lclsb].N_ZJCLS_MIN;
                            mod_Sms.N_ZJCLS_MAX = lst_Lclsb[i_Lclsb].N_ZJCLS_MAX;
                            mod_Sms.C_SL = lst_Lclsb[i_Lclsb].C_SL;
                            mod_Sms.C_WL = lst_Lclsb[i_Lclsb].C_WL;
                            mod_Sms.C_SLAB_TYPE = lst_Lclsb[i_Lclsb].C_SLAB_TYPE;

                            #endregion

                            if (!dalTspPlanSms.Add_Trans(mod_Sms))
                            {
                                return "插入炉次计划失败";
                            }

                            #endregion
                        }

                        #region 将TPP_LGPC_LCLSB表数据停用

                        if (!dalTppLgpcLclsb.Update_Trans(strID))
                        {
                            return "删除炉次计划临时表失败";
                        }

                        #endregion


                        #region 将TPP_LGPC_LSB表数据停用

                        if (!dalTppLgpcLsb.Update_Trans(strID))
                        {
                            return "删除浇次计划临时表失败";
                        }

                        #endregion

                        num++;

                        break;
                    }
                }

                if (num == 0)
                {
                    return "0";
                }
                else
                {
                    return "1";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

            #endregion
        }

        /// <summary>
        /// 获取剩余未排浇次信息（5#CC除外）
        /// </summary>
        /// <returns>0-未找到浇次;1-成功；其他-失败</returns>
        private string Get_Cast_Plan3()
        {
            #region 计算下发3#CC、4#CC具体浇次

            try
            {
                string strID = dalTppLgpcLclsb.Get_Cast_Id();

                if (string.IsNullOrEmpty(strID))
                {
                    return "0";
                }
                else
                {
                    strID = "'" + strID + "'";
                }

                List<Mod_TPP_LGPC_LCLSB> lst_Lclsb = bllTppLgpcLclsb.DataTableToList(dalTppLgpcLclsb.Get_LC_List_Trans(strID).Tables[0]);

                DataTable dt_Sort = dalTspPlanSms.Get_Max_Sort_Trans().Tables[0];

                for (int i_Lclsb = 0; i_Lclsb < lst_Lclsb.Count; i_Lclsb++)
                {
                    #region 计算3#CC、4#CC连铸生产顺序和计划开始时间和计划结束时间

                    int n_Sort = 0;
                    DateTime startTime = DateTime.Now.AddDays(-2);
                    DateTime endTime = startTime.AddMinutes(30);
                    double cn = 0;

                    bool isHaving = false;

                    for (int i_Sort = 0; i_Sort < dt_Sort.Rows.Count; i_Sort++)
                    {
                        if (lst_Lclsb[i_Lclsb].C_CCM_ID.ToString() == dt_Sort.Rows[i_Sort]["C_CCM_ID"].ToString())
                        {
                            isHaving = true;

                            dt_Sort.Rows[i_Sort]["N_SORT"] = Convert.ToInt32(dt_Sort.Rows[i_Sort]["N_SORT"].ToString()) + 1;
                            n_Sort = Convert.ToInt32(dt_Sort.Rows[i_Sort]["N_SORT"].ToString());
                            if (!string.IsNullOrEmpty(dt_Sort.Rows[i_Sort]["D_P_END_TIME"].ToString()))
                            {
                                startTime = Convert.ToDateTime(dt_Sort.Rows[i_Sort]["D_P_END_TIME"].ToString());
                            }

                            cn = Convert.ToDouble(lst_Lclsb[i_Lclsb].N_SLAB_WGT) / Convert.ToDouble(lst_Lclsb[i_Lclsb].N_JSCN);

                            endTime = startTime.AddHours(cn);

                            dt_Sort.Rows[i_Sort]["D_P_END_TIME"] = endTime;

                            break;
                        }
                    }

                    if (!isHaving)
                    {
                        n_Sort++;

                        cn = Convert.ToDouble(lst_Lclsb[i_Lclsb].N_SLAB_WGT) / Convert.ToDouble(lst_Lclsb[i_Lclsb].N_JSCN);

                        endTime = startTime.AddHours(cn);

                        DataRow dr = dt_Sort.NewRow();
                        dr["N_SORT"] = n_Sort;
                        dr["C_CCM_ID"] = lst_Lclsb[i_Lclsb].C_CCM_ID;
                        dr["D_P_END_TIME"] = endTime;
                        dt_Sort.Rows.Add(dr);
                    }

                    #endregion

                    #region 将炉次计划添加到Tsp_Plan_Sms中

                    #region 实体赋值

                    Mod_TSP_PLAN_SMS mod_Sms = new Mod_TSP_PLAN_SMS();
                    mod_Sms.C_ID = lst_Lclsb[i_Lclsb].C_ID;
                    mod_Sms.C_ORDER_NO = lst_Lclsb[i_Lclsb].C_ORDER_NO;
                    mod_Sms.C_DESIGN_NO = lst_Lclsb[i_Lclsb].C_DESIGN_NO;
                    mod_Sms.N_SLAB_WGT = lst_Lclsb[i_Lclsb].N_SLAB_WGT;
                    mod_Sms.C_CTRL_NO = lst_Lclsb[i_Lclsb].C_CTRL_NO;
                    mod_Sms.C_CCM_ID = lst_Lclsb[i_Lclsb].C_CCM_ID;
                    mod_Sms.C_CCM_DESC = lst_Lclsb[i_Lclsb].C_CCM_DESC;
                    mod_Sms.C_PROD_NAME = lst_Lclsb[i_Lclsb].C_PROD_NAME;
                    mod_Sms.C_STL_GRD = lst_Lclsb[i_Lclsb].C_STL_GRD;
                    mod_Sms.C_SPEC_CODE = lst_Lclsb[i_Lclsb].C_SPEC_CODE;
                    mod_Sms.C_LENGTH = lst_Lclsb[i_Lclsb].C_LENGTH;
                    mod_Sms.C_MATRL_NO = lst_Lclsb[i_Lclsb].C_MATRL_NO;
                    mod_Sms.C_MATRL_NAME = lst_Lclsb[i_Lclsb].C_MATRL_NAME;
                    mod_Sms.C_SLAB_SIZE = lst_Lclsb[i_Lclsb].C_SLAB_SIZE;
                    mod_Sms.C_SLAB_LENGTH = lst_Lclsb[i_Lclsb].C_SLAB_LENGTH;
                    mod_Sms.C_STATE = lst_Lclsb[i_Lclsb].C_STATE;
                    mod_Sms.C_STD_CODE = lst_Lclsb[i_Lclsb].C_STD_CODE;
                    mod_Sms.C_INITIALIZE_ITEM_ID = lst_Lclsb[i_Lclsb].C_INITIALIZE_ITEM_ID;
                    mod_Sms.D_P_START_TIME = startTime;//计划开始时间
                    mod_Sms.D_P_END_TIME = endTime;//计划结束时间
                    mod_Sms.N_PROD_TIME = lst_Lclsb[i_Lclsb].N_PROD_TIME;
                    mod_Sms.N_SORT = n_Sort;//顺序号
                    mod_Sms.C_CAST_NO = lst_Lclsb[i_Lclsb].C_CAST_NO;
                    mod_Sms.N_STATUS = lst_Lclsb[i_Lclsb].N_STATUS;
                    mod_Sms.C_EMP_ID = lst_Lclsb[i_Lclsb].C_EMP_ID;
                    mod_Sms.D_MOD_DT = lst_Lclsb[i_Lclsb].D_MOD_DT;
                    //mod_Sms.C_REMARK = lst_Lclsb[i_Lclsb].C_REMARK;
                    mod_Sms.C_REMARK = "张明才";
                    mod_Sms.N_CREAT_PLAN = lst_Lclsb[i_Lclsb].N_CREAT_PLAN;
                    mod_Sms.N_CREAT_ZG_PLAN = lst_Lclsb[i_Lclsb].N_CREAT_ZG_PLAN;
                    mod_Sms.N_PRODUCE_TIME = lst_Lclsb[i_Lclsb].N_PRODUCE_TIME;
                    mod_Sms.C_ZL_ID = lst_Lclsb[i_Lclsb].C_ZL_ID;
                    mod_Sms.C_LF_ID = lst_Lclsb[i_Lclsb].C_LF_ID;
                    mod_Sms.C_RH_ID = lst_Lclsb[i_Lclsb].C_RH_ID;
                    mod_Sms.C_LGJH = lst_Lclsb[i_Lclsb].C_LGJH;
                    mod_Sms.C_QUA = lst_Lclsb[i_Lclsb].C_QUA;
                    mod_Sms.D_ARRIVE_ZG_TIME = lst_Lclsb[i_Lclsb].D_ARRIVE_ZG_TIME;
                    mod_Sms.C_BY1 = lst_Lclsb[i_Lclsb].C_BY1;
                    mod_Sms.C_BY2 = lst_Lclsb[i_Lclsb].C_BY2;
                    mod_Sms.C_BY3 = lst_Lclsb[i_Lclsb].C_BY3;
                    mod_Sms.C_RH = lst_Lclsb[i_Lclsb].C_RH;
                    mod_Sms.C_DFP_HL = lst_Lclsb[i_Lclsb].C_DFP_HL;
                    mod_Sms.C_HL = lst_Lclsb[i_Lclsb].C_HL;
                    mod_Sms.C_XM = lst_Lclsb[i_Lclsb].C_XM;
                    mod_Sms.D_DFPHL_START_TIME = lst_Lclsb[i_Lclsb].D_DFPHL_START_TIME;
                    mod_Sms.D_DFPHL_END_TIME = lst_Lclsb[i_Lclsb].D_DFPHL_END_TIME;
                    mod_Sms.D_KP_START_TIME = lst_Lclsb[i_Lclsb].D_KP_START_TIME;
                    mod_Sms.D_KP_END_TIME = lst_Lclsb[i_Lclsb].D_KP_END_TIME;
                    mod_Sms.D_HL_START_TIME = lst_Lclsb[i_Lclsb].D_HL_START_TIME;
                    mod_Sms.D_HL_END_TIME = lst_Lclsb[i_Lclsb].D_HL_END_TIME;
                    mod_Sms.D_PLAN_KY_TIME = lst_Lclsb[i_Lclsb].D_PLAN_KY_TIME;
                    mod_Sms.C_PLAN_ROLL = lst_Lclsb[i_Lclsb].C_PLAN_ROLL;
                    mod_Sms.D_ZZ_START_TIME = lst_Lclsb[i_Lclsb].D_ZZ_START_TIME;
                    mod_Sms.D_ZZ_END_TIME = lst_Lclsb[i_Lclsb].D_ZZ_END_TIME;
                    mod_Sms.D_XM_START_TIME = lst_Lclsb[i_Lclsb].D_XM_START_TIME;
                    mod_Sms.D_XM_END_TIME = lst_Lclsb[i_Lclsb].D_XM_END_TIME;
                    mod_Sms.C_STOVE_NO = lst_Lclsb[i_Lclsb].C_STOVE_NO;
                    mod_Sms.D_DFPHL_START_TIME_SJ = lst_Lclsb[i_Lclsb].D_DFPHL_START_TIME_SJ;
                    mod_Sms.D_DFPHL_END_TIME_SJ = lst_Lclsb[i_Lclsb].D_DFPHL_END_TIME_SJ;
                    mod_Sms.D_KP_START_TIME_SJ = lst_Lclsb[i_Lclsb].D_KP_START_TIME_SJ;
                    mod_Sms.D_KP_END_TIME_SJ = lst_Lclsb[i_Lclsb].D_KP_END_TIME_SJ;
                    mod_Sms.D_HL_START_TIME_SJ = lst_Lclsb[i_Lclsb].D_HL_START_TIME_SJ;
                    mod_Sms.D_HL_END_TIME_SJ = lst_Lclsb[i_Lclsb].D_HL_END_TIME_SJ;
                    mod_Sms.D_XM_START_TIME_SJ = lst_Lclsb[i_Lclsb].D_XM_START_TIME_SJ;
                    mod_Sms.D_XM_END_TIME_SJ = lst_Lclsb[i_Lclsb].D_XM_END_TIME_SJ;
                    mod_Sms.N_SJ_WGT = lst_Lclsb[i_Lclsb].N_SJ_WGT;
                    mod_Sms.D_START_TIME_SJ = lst_Lclsb[i_Lclsb].D_START_TIME_SJ;
                    mod_Sms.D_END_TIME_SJ = lst_Lclsb[i_Lclsb].D_END_TIME_SJ;
                    mod_Sms.N_DFP_HL_TIME = lst_Lclsb[i_Lclsb].N_DFP_HL_TIME;
                    mod_Sms.N_HL_TIME = lst_Lclsb[i_Lclsb].N_HL_TIME;
                    mod_Sms.C_ROUTE = lst_Lclsb[i_Lclsb].C_ROUTE;
                    mod_Sms.N_SLAB_PW = lst_Lclsb[i_Lclsb].N_SLAB_PW;
                    mod_Sms.C_MATRL_CODE_KP = lst_Lclsb[i_Lclsb].C_MATRL_CODE_KP;
                    mod_Sms.C_MATRL_NAME_KP = lst_Lclsb[i_Lclsb].C_MATRL_NAME_KP;
                    mod_Sms.C_KP_SIZE = lst_Lclsb[i_Lclsb].C_KP_SIZE;
                    mod_Sms.N_KP_LENGTH = lst_Lclsb[i_Lclsb].N_KP_LENGTH;
                    mod_Sms.N_KP_PW = lst_Lclsb[i_Lclsb].N_KP_PW;
                    mod_Sms.N_USE_WGT = lst_Lclsb[i_Lclsb].N_USE_WGT;
                    mod_Sms.D_USE_START_TIME_SJ = lst_Lclsb[i_Lclsb].D_USE_START_TIME_SJ;
                    mod_Sms.D_USE_END_TIME_SJ = lst_Lclsb[i_Lclsb].D_USE_END_TIME_SJ;
                    mod_Sms.D_CAN_USE_TIME = endTime.AddHours(2);//可用时间
                    mod_Sms.N_RH_NUM = lst_Lclsb[i_Lclsb].N_RH_NUM;
                    mod_Sms.N_KP_WGT = lst_Lclsb[i_Lclsb].N_KP_WGT;
                    mod_Sms.N_XM_WGT = lst_Lclsb[i_Lclsb].N_XM_WGT;
                    mod_Sms.C_DFP_RZ = string.IsNullOrEmpty(lst_Lclsb[i_Lclsb].C_DFP_RZ) == true ? "N" : lst_Lclsb[i_Lclsb].C_DFP_RZ;
                    mod_Sms.C_RZP_RZ = string.IsNullOrEmpty(lst_Lclsb[i_Lclsb].C_RZP_RZ) == true ? "N" : lst_Lclsb[i_Lclsb].C_RZP_RZ;
                    mod_Sms.C_DFP_YQ = lst_Lclsb[i_Lclsb].C_DFP_YQ;
                    mod_Sms.C_RZP_YQ = lst_Lclsb[i_Lclsb].C_RZP_YQ;
                    mod_Sms.C_STL_GRD_TYPE = lst_Lclsb[i_Lclsb].C_STL_GRD_TYPE;
                    mod_Sms.C_PROD_KIND = lst_Lclsb[i_Lclsb].C_PROD_KIND;
                    mod_Sms.C_TL = lst_Lclsb[i_Lclsb].C_TL;
                    mod_Sms.N_JSCN = lst_Lclsb[i_Lclsb].N_JSCN;
                    mod_Sms.C_FREE1 = lst_Lclsb[i_Lclsb].C_FREE1;
                    mod_Sms.C_FREE2 = lst_Lclsb[i_Lclsb].C_FREE2;
                    mod_Sms.N_GROUP = lst_Lclsb[i_Lclsb].N_GROUP;
                    mod_Sms.C_FK = lst_Lclsb[i_Lclsb].C_FK;
                    mod_Sms.N_ZJCLS = lst_Lclsb[i_Lclsb].N_ZJCLS;
                    mod_Sms.N_ZJCLS_MIN = lst_Lclsb[i_Lclsb].N_ZJCLS_MIN;
                    mod_Sms.N_ZJCLS_MAX = lst_Lclsb[i_Lclsb].N_ZJCLS_MAX;
                    mod_Sms.C_SL = lst_Lclsb[i_Lclsb].C_SL;
                    mod_Sms.C_WL = lst_Lclsb[i_Lclsb].C_WL;
                    mod_Sms.C_SLAB_TYPE = lst_Lclsb[i_Lclsb].C_SLAB_TYPE;

                    #endregion

                    if (!dalTspPlanSms.Add_Trans(mod_Sms))
                    {
                        return "插入炉次计划失败";
                    }

                    #endregion
                }

                #region 将TPP_LGPC_LCLSB表数据停用

                if (!dalTppLgpcLclsb.Update_Trans(strID))
                {
                    return "删除炉次计划临时表失败";
                }

                #endregion


                #region 将TPP_LGPC_LSB表数据停用

                if (!dalTppLgpcLsb.Update_Trans(strID))
                {
                    return "删除浇次计划临时表失败";
                }

                #endregion

                return "1";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

            #endregion
        }

        /// <summary>
        /// 检测是否有可排轧钢计划
        /// </summary>
        /// <param name="dt_Line">轧线</param>
        /// <returns>1-计划更新成功；其他-出错</returns>
        private string Update_Plan_Time(DataTable dt_Line)
        {
            try
            {
                string result = "0";

                decimal wgt_sd = 0;
                decimal wgt_kz = 0;
                string strSpec = "";
                DateTime time_KZ = RV.UI.ServerTime.timeNow();

                DataTable dt_Spec = new DataTable();

                lst_Cast.Clear();

                for (int i_Line = 0; i_Line < dt_Line.Rows.Count; i_Line++)
                {
                    wgt_sd = 600;

                    DataTable dt_Up = dalTrpPlanRoll.Get_Up_Plan_Trans(dt_Line.Rows[i_Line]["C_LINE_CODE"].ToString(), 2).Tables[0];//获取前两个计划

                    bool IsBreak = false;


                    #region 判断是否有前置计划

                    if (dt_Up.Rows.Count == 0)//没有前置计划
                    {
                        strSpec = "";

                        dt_Spec = dalTrpPlanRoll.Get_Spec_Max_Trans(dt_Line.Rows[i_Line]["C_LINE_CODE"].ToString(), "").Tables[0];//获取未排产的产线规格

                        if (dt_Spec.Rows.Count == 0)
                        {
                            continue;
                        }
                    }
                    else if (dt_Up.Rows.Count == 1)//只有一个前置计划
                    {
                        strSpec = dt_Up.Rows[0]["C_SPEC"].ToString();//上一个计划规格

                        dt_Spec = dalTrpPlanRoll.Get_Spec_Max_Trans(dt_Line.Rows[i_Line]["C_LINE_CODE"].ToString(), dt_Up.Rows[0]["C_SPEC"].ToString()).Tables[0];//获取未排产的产线规格(从小到大)

                        DataTable dt_temp = dalTrpPlanRoll.Get_Spec_Min_Trans(dt_Line.Rows[i_Line]["C_LINE_CODE"].ToString(), dt_Up.Rows[0]["C_SPEC"].ToString()).Tables[0];//获取未排产的产线规格(从大到小)

                        dt_Spec.Merge(dt_temp);

                        if (dt_Spec.Rows.Count == 0)
                        {
                            continue;
                        }
                    }
                    else if (dt_Up.Rows.Count == 2)//有两个前置计划
                    {
                        strSpec = dt_Up.Rows[0]["C_SPEC"].ToString();//上一个计划规格

                        if (Convert.ToDouble(dt_Up.Rows[0]["C_SPEC"].ToString().Substring(1)) >= Convert.ToDouble(dt_Up.Rows[1]["C_SPEC"].ToString().Substring(1)))
                        {
                            dt_Spec = dalTrpPlanRoll.Get_Spec_Max_Trans(dt_Line.Rows[i_Line]["C_LINE_CODE"].ToString(), dt_Up.Rows[0]["C_SPEC"].ToString()).Tables[0];//获取未排产的产线规格(从小到大)

                            DataTable dt_temp = dalTrpPlanRoll.Get_Spec_Min_Trans(dt_Line.Rows[i_Line]["C_LINE_CODE"].ToString(), dt_Up.Rows[0]["C_SPEC"].ToString()).Tables[0];//获取未排产的产线规格(从大到小)

                            dt_Spec.Merge(dt_temp);

                            if (dt_Spec.Rows.Count == 0)
                            {
                                continue;
                            }
                        }
                        else
                        {
                            dt_Spec = dalTrpPlanRoll.Get_Spec_Min_Trans(dt_Line.Rows[i_Line]["C_LINE_CODE"].ToString(), dt_Up.Rows[0]["C_SPEC"].ToString()).Tables[0];//获取未排产的产线规格(从大到小)

                            DataTable dt_temp = dalTrpPlanRoll.Get_Spec_Max_Trans(dt_Line.Rows[i_Line]["C_LINE_CODE"].ToString(), dt_Up.Rows[0]["C_SPEC"].ToString()).Tables[0];//获取未排产的产线规格((从小到大)

                            dt_Spec.Merge(dt_temp);

                            if (dt_Spec.Rows.Count == 0)
                            {
                                continue;
                            }
                        }
                    }

                    #endregion

                    #region 查找符合条件的计划信息

                    for (int i_wgt = Convert.ToInt32(wgt_sd); i_wgt >= 0; i_wgt = i_wgt - 100)
                    {
                        for (int i_Spec = 0; i_Spec < dt_Spec.Rows.Count; i_Spec++)
                        {
                            int count = dalTrpPlanRoll.Get_Count_Trans(dt_Line.Rows[i_Line]["C_LINE_CODE"].ToString(), dt_Spec.Rows[i_Spec]["C_SPEC"].ToString(), i_wgt);//判断指定规格订单是否大于设定重量

                            if (count == 0)
                            {
                                continue;
                            }

                            int hggTime = dalChangeTime.Get_Time(dt_Line.Rows[i_Line]["C_LINE_CODE"].ToString(), strSpec, dt_Spec.Rows[i_Spec]["C_SPEC"].ToString());//换规格时间

                            if (dt_Up.Rows.Count > 0)
                            {
                                time_KZ = Convert.ToDateTime(dt_Up.Rows[0]["D_P_END_TIME"].ToString());//上一个计划结束时间
                                time_KZ = time_KZ.AddMinutes(hggTime);
                            }

                            if (!string.IsNullOrEmpty(timeCC))
                            {
                                if (time_KZ < Convert.ToDateTime(timeCC))
                                {
                                    time_KZ = Convert.ToDateTime(timeCC);
                                }
                            }

                            wgt_kz = Get_Slab_Wgt(dt_Line.Rows[i_Line]["C_LINE_CODE"].ToString(), dt_Spec.Rows[i_Spec]["C_SPEC"].ToString(), time_KZ.ToString());

                            if (wgt_kz == decimal.MinValue)
                            {
                                return "重量获取失败";
                            }

                            if (wgt_kz > i_wgt)
                            {
                                wgt_kz = Update_Slab_Wgt(dt_Line.Rows[i_Line]["C_LINE_CODE"].ToString(), dt_Spec.Rows[i_Spec]["C_SPEC"].ToString(), time_KZ.ToString());

                                if (wgt_kz == decimal.MinValue)
                                {
                                    return "计划更新失败";
                                }

                                IsBreak = true;

                                break;
                            }
                        }

                        if (IsBreak)
                        {
                            result = "1";

                            break;
                        }
                    }

                    #endregion

                }

                timeCC = "";

                return result;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        /// <summary>
        /// 计算可轧制重量
        /// </summary>
        /// <returns></returns>
        private decimal Get_Slab_Wgt(string c_line_code, string strSpec, string strTime, out List<CastInfo> lst_T)
        {
            try
            {
                decimal dWgt = 0;//可轧重量
                decimal dPlanWgt = 0;
                decimal dSlabWgt = 0;
                string timeStart = "";
                decimal n_zg_wgt = 0;//轧钢排产量

                lst_T = lst_Temp;

                DataTable dt_ZG = dalTrpPlanRoll.Get_ZG_Plan_Trans(c_line_code, strSpec).Tables[0];//获取指定规格待轧的轧钢计划

                DataTable dt_StdCode = dalTrpPlanRoll.Get_ZG_Std_Code_Trans(c_line_code, strSpec).Tables[0];//获取待轧的轧钢计划的钢种和执行标准
                DataTable dt = new DataTable();
                DataTable dtSlab = new DataTable();

                for (int i = 0; i < dt_StdCode.Rows.Count; i++)
                {
                    if (i == 0)
                    {
                        dtSlab = dalTspPlanSms.Get_Slab_List_Trans(dt_StdCode.Rows[i]["C_STL_GRD"].ToString(), dt_StdCode.Rows[i]["C_STD_CODE"].ToString()).Tables[0];//获取指定钢种、标准的钢坯列表
                    }
                    else
                    {
                        dt = dalTspPlanSms.Get_Slab_List_Trans(dt_StdCode.Rows[i]["C_STL_GRD"].ToString(), dt_StdCode.Rows[i]["C_STD_CODE"].ToString()).Tables[0];//获取指定钢种、标准的钢坯列表

                        dtSlab.Merge(dt);
                    }
                }

                List<Mod_TSP_PLAN_SMS> lst_Slab = bllTspPlanSms.DataTableToList(dtSlab);

                for (int i_ZG = 0; i_ZG < dt_ZG.Rows.Count; i_ZG++)
                {
                    if (!string.IsNullOrEmpty(dt_ZG.Rows[i_ZG]["D_P_START_TIME"].ToString()))
                    {
                        timeStart = dt_ZG.Rows[i_ZG]["D_P_START_TIME"].ToString();
                    }
                    else
                    {
                        timeStart = strTime;
                    }

                    dPlanWgt = Convert.ToDecimal(dt_ZG.Rows[i_ZG]["N_ZG_WGT"].ToString());//未排产量
                    n_zg_wgt = dPlanWgt;

                    bool IsCompleted = false;

                    while (!IsCompleted)
                    {
                        if (dPlanWgt <= 0)
                        {
                            break;
                        }

                        var lst = lst_Slab.Where(x => x.C_STL_GRD == dt_ZG.Rows[i_ZG]["C_STL_GRD"].ToString() && x.C_STD_CODE == dt_ZG.Rows[i_ZG]["C_STD_CODE"].ToString() && x.N_USE_WGT > 0 && x.D_CAN_USE_TIME < (Convert.ToDateTime(strTime).AddMinutes(30))).ToList();

                        if (lst.Count > 0)
                        {
                            for (int i_Slab = 0; i_Slab < lst.Count; i_Slab++)
                            {
                                dSlabWgt = Convert.ToDecimal(lst[i_Slab].N_USE_WGT);

                                if (dSlabWgt <= 0)
                                {
                                    continue;
                                }

                                if (dPlanWgt >= dSlabWgt)
                                {
                                    dPlanWgt = dPlanWgt - dSlabWgt;
                                    dWgt = dWgt + dSlabWgt;
                                    double cn = Convert.ToDouble(dSlabWgt / Convert.ToDecimal(dt_ZG.Rows[i_ZG]["N_MACH_WGT"].ToString()));
                                    strTime = Convert.ToDateTime(strTime).AddHours(cn).ToString();//结束时间

                                    #region 更新炼钢计划可用钢坯量

                                    lst[i_Slab].N_USE_WGT = 0;

                                    #endregion
                                }
                                else
                                {
                                    dWgt = dWgt + dPlanWgt;
                                    double cn = Convert.ToDouble(dPlanWgt / Convert.ToDecimal(dt_ZG.Rows[i_ZG]["N_MACH_WGT"].ToString()));
                                    strTime = Convert.ToDateTime(strTime).AddHours(cn).ToString();//结束时间

                                    dPlanWgt = 0;

                                    lst[i_Slab].N_USE_WGT = lst[i_Slab].N_USE_WGT - dPlanWgt;

                                    dPlanWgt = 0;

                                    break;
                                }
                            }

                            #region 更新炼钢计划可用钢坯量

                            for (int i = 0; i < lst.Count; i++)
                            {
                                for (int j = 0; j < lst_Slab.Count; j++)
                                {
                                    if (lst[i].C_ID == lst_Slab[j].C_ID)
                                    {
                                        lst_Slab[j].N_USE_WGT = lst[i].N_USE_WGT;
                                        break;
                                    }
                                }
                            }

                            #endregion
                        }
                        else
                        {
                            IsCompleted = true;
                        }
                    }

                    if (dPlanWgt > 0)
                    {
                        CastInfo cInfo = new CastInfo(dt_ZG.Rows[i_ZG]["C_STL_GRD"].ToString(), dt_ZG.Rows[i_ZG]["C_STD_CODE"].ToString(), dPlanWgt);

                        lst_T.Add(cInfo);
                    }
                }

                return dWgt;
            }
            catch (Exception ex)
            {
                lst_T = null;
                return decimal.MinValue;
            }
        }

        /// <summary>
        /// 计算可轧制重量
        /// </summary>
        /// <returns></returns>
        private decimal Get_Slab_Wgt(string c_line_code, string strSpec, string strTime)
        {
            try
            {
                decimal dWgt = 0;//可轧重量
                decimal dPlanWgt = 0;
                decimal dSlabWgt = 0;
                string timeStart = "";
                decimal n_zg_wgt = 0;//轧钢排产量

                DataTable dt_ZG = dalTrpPlanRoll.Get_ZG_Plan_Trans(c_line_code, strSpec).Tables[0];//获取指定规格待轧的轧钢计划

                DataTable dt_StdCode = dalTrpPlanRoll.Get_ZG_Std_Code_Trans(c_line_code, strSpec).Tables[0];//获取待轧的轧钢计划的钢种和执行标准
                DataTable dt = new DataTable();
                DataTable dtSlab = new DataTable();

                for (int i = 0; i < dt_StdCode.Rows.Count; i++)
                {
                    if (i == 0)
                    {
                        dtSlab = dalTspPlanSms.Get_Slab_List_Trans(dt_StdCode.Rows[i]["C_STL_GRD"].ToString(), dt_StdCode.Rows[i]["C_STD_CODE"].ToString()).Tables[0];//获取指定钢种、标准的钢坯列表
                    }
                    else
                    {
                        dt = dalTspPlanSms.Get_Slab_List_Trans(dt_StdCode.Rows[i]["C_STL_GRD"].ToString(), dt_StdCode.Rows[i]["C_STD_CODE"].ToString()).Tables[0];//获取指定钢种、标准的钢坯列表

                        dtSlab.Merge(dt);
                    }
                }

                List<Mod_TSP_PLAN_SMS> lst_Slab = bllTspPlanSms.DataTableToList(dtSlab);

                for (int i_ZG = 0; i_ZG < dt_ZG.Rows.Count; i_ZG++)
                {
                    if (!string.IsNullOrEmpty(dt_ZG.Rows[i_ZG]["D_P_START_TIME"].ToString()))
                    {
                        timeStart = dt_ZG.Rows[i_ZG]["D_P_START_TIME"].ToString();
                    }
                    else
                    {
                        timeStart = strTime;
                    }

                    dPlanWgt = Convert.ToDecimal(dt_ZG.Rows[i_ZG]["N_ZG_WGT"].ToString());//未排产量
                    n_zg_wgt = dPlanWgt;

                    bool IsCompleted = false;

                    while (!IsCompleted)
                    {
                        if (dPlanWgt <= 0)
                        {
                            break;
                        }

                        var lst = lst_Slab.Where(x => x.C_STL_GRD == dt_ZG.Rows[i_ZG]["C_STL_GRD"].ToString() && x.C_STD_CODE == dt_ZG.Rows[i_ZG]["C_STD_CODE"].ToString() && x.N_USE_WGT > 0 && x.D_CAN_USE_TIME < (Convert.ToDateTime(strTime).AddMinutes(30))).ToList();

                        if (lst.Count > 0)
                        {
                            for (int i_Slab = 0; i_Slab < lst.Count; i_Slab++)
                            {
                                dSlabWgt = Convert.ToDecimal(lst[i_Slab].N_USE_WGT);

                                if (dSlabWgt <= 0)
                                {
                                    continue;
                                }

                                if (dPlanWgt >= dSlabWgt)
                                {
                                    dPlanWgt = dPlanWgt - dSlabWgt;
                                    dWgt = dWgt + dSlabWgt;
                                    double cn = Convert.ToDouble(dSlabWgt / Convert.ToDecimal(dt_ZG.Rows[i_ZG]["N_MACH_WGT"].ToString()));
                                    strTime = Convert.ToDateTime(strTime).AddHours(cn).ToString();//结束时间

                                    #region 更新炼钢计划可用钢坯量

                                    lst[i_Slab].N_USE_WGT = 0;

                                    #endregion
                                }
                                else
                                {
                                    dWgt = dWgt + dPlanWgt;
                                    double cn = Convert.ToDouble(dPlanWgt / Convert.ToDecimal(dt_ZG.Rows[i_ZG]["N_MACH_WGT"].ToString()));
                                    strTime = Convert.ToDateTime(strTime).AddHours(cn).ToString();//结束时间

                                    dPlanWgt = 0;

                                    lst[i_Slab].N_USE_WGT = lst[i_Slab].N_USE_WGT - dPlanWgt;

                                    dPlanWgt = 0;

                                    break;
                                }
                            }

                            #region 更新炼钢计划可用钢坯量

                            for (int i = 0; i < lst.Count; i++)
                            {
                                for (int j = 0; j < lst_Slab.Count; j++)
                                {
                                    if (lst[i].C_ID == lst_Slab[j].C_ID)
                                    {
                                        lst_Slab[j].N_USE_WGT = lst[i].N_USE_WGT;
                                        break;
                                    }
                                }
                            }

                            #endregion
                        }
                        else
                        {
                            IsCompleted = true;
                        }
                    }
                }

                return dWgt;
            }
            catch (Exception ex)
            {
                return decimal.MinValue;
            }
        }

        /// <summary>
        /// 更新炼钢计划钢坯可用量
        /// </summary>
        /// <returns></returns>
        private decimal Update_Slab_Wgt(string c_line_code, string strSpec, string strTime)
        {
            try
            {
                decimal dWgt = 0;//可轧重量
                decimal dPlanWgt = 0;
                decimal dSlabWgt = 0;
                string timeStart = "";
                decimal n_zg_wgt = 0;//轧钢排产量
                string strOrderID = "";//订单主键

                string timeStart_sj = "";

                DataTable dt_ZG = dalTrpPlanRoll.Get_ZG_Plan_Trans(c_line_code, strSpec).Tables[0];//获取指定规格待轧的轧钢计划
                for (int i_ZG = 0; i_ZG < dt_ZG.Rows.Count; i_ZG++)
                {
                    if (!string.IsNullOrEmpty(dt_ZG.Rows[i_ZG]["D_P_START_TIME"].ToString()))
                    {
                        timeStart = dt_ZG.Rows[i_ZG]["D_P_START_TIME"].ToString();
                    }
                    else
                    {
                        timeStart = strTime;
                    }

                    timeStart_sj = strTime;

                    strOrderID = dt_ZG.Rows[i_ZG]["C_INITIALIZE_ITEM_ID"].ToString();//订单主键

                    dPlanWgt = Convert.ToDecimal(dt_ZG.Rows[i_ZG]["N_ZG_WGT"].ToString());//未排产量
                    n_zg_wgt = dPlanWgt;

                    bool IsCompleted = false;

                    while (!IsCompleted)
                    {
                        if (dPlanWgt <= 0)
                        {
                            break;
                        }

                        DataTable dt_Slab = dalTspPlanSms.Get_Slab_List_Trans(dt_ZG.Rows[i_ZG]["C_STL_GRD"].ToString(), dt_ZG.Rows[i_ZG]["C_STD_CODE"].ToString(), strTime).Tables[0];//获取指定钢种、标准的钢坯列表

                        if (dt_Slab.Rows.Count > 0)
                        {
                            for (int i_Slab = 0; i_Slab < dt_Slab.Rows.Count; i_Slab++)
                            {
                                dSlabWgt = Convert.ToDecimal(dt_Slab.Rows[i_Slab]["N_USE_WGT"].ToString());

                                if (dSlabWgt <= 0)
                                {
                                    continue;
                                }

                                if (dPlanWgt >= dSlabWgt)
                                {
                                    dPlanWgt = dPlanWgt - dSlabWgt;
                                    dWgt = dWgt + dSlabWgt;
                                    double cn = Convert.ToDouble(dSlabWgt / Convert.ToDecimal(dt_ZG.Rows[i_ZG]["N_MACH_WGT"].ToString()));
                                    strTime = Convert.ToDateTime(strTime).AddHours(cn).ToString();//结束时间

                                    #region 更新炼钢计划可用钢坯量

                                    if (string.IsNullOrEmpty(dt_Slab.Rows[i_Slab]["C_ORDER_NO"].ToString()))
                                    {
                                        if (!dalTspPlanSms.Update_Trans(dt_Slab.Rows[i_Slab]["C_ID"].ToString(), dSlabWgt, strOrderID))
                                        {
                                            return decimal.MinValue;
                                        }
                                    }
                                    else
                                    {
                                        if (!dalTspPlanSms.Update_Trans(dt_Slab.Rows[i_Slab]["C_ID"].ToString(), dSlabWgt))
                                        {
                                            return decimal.MinValue;
                                        }
                                    }

                                    #endregion
                                }
                                else
                                {
                                    dWgt = dWgt + dPlanWgt;
                                    double cn = Convert.ToDouble(dPlanWgt / Convert.ToDecimal(dt_ZG.Rows[i_ZG]["N_MACH_WGT"].ToString()));
                                    strTime = Convert.ToDateTime(strTime).AddHours(cn).ToString();//结束时间

                                    #region 更新炼钢计划可用钢坯量

                                    if (string.IsNullOrEmpty(dt_Slab.Rows[i_Slab]["C_ORDER_NO"].ToString()))
                                    {
                                        if (!dalTspPlanSms.Update_Trans(dt_Slab.Rows[i_Slab]["C_ID"].ToString(), dSlabWgt, strOrderID))
                                        {
                                            return decimal.MinValue;
                                        }
                                    }
                                    else
                                    {
                                        if (!dalTspPlanSms.Update_Trans(dt_Slab.Rows[i_Slab]["C_ID"].ToString(), dPlanWgt))
                                        {
                                            return decimal.MinValue;
                                        }
                                    }

                                    #endregion

                                    dPlanWgt = 0;

                                    break;
                                }
                            }
                        }
                        else
                        {
                            IsCompleted = true;
                        }
                    }

                    if (n_zg_wgt != dPlanWgt)
                    {
                        Mod_TRP_PLAN_ITEM modelItem = new Mod_TRP_PLAN_ITEM();
                        modelItem.C_PLAN_ROLL_ID = dt_ZG.Rows[i_ZG]["C_ID"].ToString();
                        modelItem.D_P_START_TIME = Convert.ToDateTime(timeStart_sj);
                        modelItem.D_P_END_TIME = Convert.ToDateTime(strTime);
                        modelItem.N_WGT = n_zg_wgt - dPlanWgt;

                        if (!dalTrpPlanItem.Add_Trans(modelItem))
                        {
                            return decimal.MinValue;
                        }

                        if (!dalTrpPlanRoll.Update_Trans(dt_ZG.Rows[i_ZG]["C_ID"].ToString(), n_zg_wgt - dPlanWgt, timeStart, strTime))
                        {
                            return decimal.MinValue;
                        }
                    }
                }

                return dWgt;
            }
            catch (Exception ex)
            {
                return decimal.MinValue;
            }
        }

        #endregion



        public string SendNC(string strUrl, string SMSID, string stove, string strOrderID)
        {
            Dal_Interface_NC_SLAB_A1_NEW dalInterface_Slab = new Dal_Interface_NC_SLAB_A1_NEW();
            string strSql = "select count(1) from XGERP50.mm_po@cap_erp t  where t.dr = 0 and t.zyx5 = '" + strOrderID + "' ";
            int NC_Count = dalTppCastPlan.Get_NC_Count(strSql);

            if (NC_Count == 0)
            {
                string result_A1 = dalInterface_Slab.SendXml_SLAB_A1(strUrl, SMSID, stove, strOrderID);//上传A1

                if (result_A1 != "1")
                {
                    TransactionHelper.RollBack();
                    return result_A1;
                }
                else
                {
                    return "1";
                }
            }
            else
            {
                return "1";
            }
        }
    }
}

