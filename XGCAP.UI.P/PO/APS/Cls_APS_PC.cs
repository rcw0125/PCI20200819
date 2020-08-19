using BLL;
using Common;
using MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;

namespace XGCAP.UI.P.PO.APS
{
    public static class Cls_APS_PC
    {

        #region 实例化功能设计对象
        private static Bll_TPC_PLAN_SMS bll_plan = new Bll_TPC_PLAN_SMS();
        private static Bll_TSP_PLAN_SMS bll_plan_sms = new Bll_TSP_PLAN_SMS();
        private static Bll_TPP_LGPC_LSB bll_jc = new Bll_TPP_LGPC_LSB();//未排产浇次计划表
        private static Bll_TPP_LGPC_LCLSB bll_lc = new Bll_TPP_LGPC_LCLSB();//未排产临时计划表
        private static Bll_TPA_DHL_PLAN bll_dhl = new Bll_TPA_DHL_PLAN();//大方坯缓冷计划表
        private static Bll_TPA_KP_PLAN bll_kp = new Bll_TPA_KP_PLAN();//开坯计划表
        private static Bll_TPA_HL_PLAN bll_hl = new Bll_TPA_HL_PLAN();//热轧坯缓冷计划表
        private static Bll_TPA_XM_PLAN bll_xm = new Bll_TPA_XM_PLAN();//修磨计划表
        private static Bll_TPA_HL_ACT bll_hl_act = new Bll_TPA_HL_ACT();//缓冷实绩
        private static Bll_TSP_CAST_PLAN bll_cast_plan = new Bll_TSP_CAST_PLAN();//浇次计划
        private static Bll_TPC_PLAN_SMS bll_tpc_plan_sms = new Bll_TPC_PLAN_SMS();//炼钢排产计划
        private static Bll_TMO_ORDER bll_order = new Bll_TMO_ORDER();//销售订单
        private static Bll_TRP_PLAN_ROLL bll_trp_plan = new Bll_TRP_PLAN_ROLL();//轧钢计划
        private static Bll_TB_PLAN_OPERATION_LOG bll_log = new Bll_TB_PLAN_OPERATION_LOG();//计划操作日志
        private static Bll_TSP_PLAN_SMS bll_sms_plan = new Bll_TSP_PLAN_SMS();//炼钢计划
        public static Bll_TPB_SCLX bll_lx = new Bll_TPB_SCLX();//生产路线
        public static Bll_TSC_SLAB_MAIN bll_slab = new Bll_TSC_SLAB_MAIN();//钢坯库存表
        public static Bll_TPP_LGPC_LCLSB bll_lclsb = new Bll_TPP_LGPC_LCLSB();//炉次计划临时表
        private static Bll_Common bll_com = new Bll_Common();//通用方法
        private static Bll_TPB_LGJH bllLgjh = new Bll_TPB_LGJH();//炼钢记号

        #endregion
        #region 计划操作日志
        /// <summary>
        /// 插入计划操作日志
        /// </summary>
        /// <param name="C_FUNCTION">操作功能</param>
        /// <param name="C_OPERATION">操作描述</param>
        ///  <param name="C_ORDER_NO">订单号</param>
        ///  <param name="C_PLAN_ID">计划表主键</param>
        public static void WritePlanLog(string C_FUNCTION, string C_OPERATION, string C_ORDER_NO, string C_PLAN_ID)
        {

            string strCPIP = "";//本机IP地址
            IPAddress[] aa = Dns.GetHostAddresses(Dns.GetHostName());
            for (int i = 0; i < aa.Length; i++)
            {
                strCPIP = strCPIP + "|" + aa[i];
            }
            string strCPName = System.Net.Dns.GetHostName(); ;//本机名称

            Mod_TB_PLAN_OPERATION_LOG mod_log = new Mod_TB_PLAN_OPERATION_LOG();
            mod_log.C_ID = System.Guid.NewGuid().ToString();
            mod_log.C_FUNCTION = C_FUNCTION;
            mod_log.C_OPERATION = C_OPERATION;
            mod_log.C_EMP_ID = RV.UI.UserInfo.UserID;
            mod_log.C_CP_IP = strCPIP;
            mod_log.C_CP_NAME = strCPName;
            mod_log.C_ORDER_NO = C_ORDER_NO;
            mod_log.C_PLAN_ID = C_PLAN_ID;
            bll_log.Add(mod_log);


        }
        #endregion

        #region 加载默认计划列表
        private static List<Mod_TPP_LGPC_LSB> jc_plan = new List<Mod_TPP_LGPC_LSB>();//待排产浇次计划
        private static List<Mod_TPP_LGPC_LCLSB> lc_plan = new List<Mod_TPP_LGPC_LCLSB>();//待排产炉次计划
        private static List<Mod_TPA_DHL_PLAN> dhl_plan = bll_dhl.GetModelList("");//已排产大方坯缓冷未完成计划
        private static List<Mod_TPA_KP_PLAN> kp_plan = bll_kp.GetModelList("");//已排产大方坯开坯未完成
        private static List<Mod_TPA_HL_PLAN> hl_plan = bll_hl.GetModelList("");//已排产热轧坯缓冷未完成计划
        private static List<Mod_TPA_XM_PLAN> xm_plan = bll_xm.GetModelList("");//已排产修磨未完成计划
        private static List<Mod_TSP_PLAN_SMS> sms_plan = bll_plan_sms.GetModelList(" N_CREAT_PLAN<3 ");//已排产未完成的计划
        private static List<Mod_TPA_HL_ACT> hl_acl = bll_hl_act.GetModelList("");//已排产未完成的计划
        #endregion

        #region 排产操作方法


        #region 初始化浇次计划
        /*
         初始化：钢种分类、
         品名、
         整浇次的重量、
         机时产量、
         连铸生产所需时间
         */
        /// <summary>
        /// 初始化待排产的浇次计划列表
        /// </summary>
        /// <param name="lst_jc_plan">浇次计划</param>
        /// <param name="lst_lc_plan">炉次计划</param>
        /// <returns>初始化后的浇次计划列表</returns>
        public static List<Mod_TPP_LGPC_LSB> Initialize_List(List<Mod_TPP_LGPC_LSB> lst_jc_plan)
        {
            #region 浇次计划初始化
            for (int i = 0; i < lst_jc_plan.Count; i++)
            {
                lst_jc_plan[i].N_STATUS = 0;//浇次计划未排产0，系统已排产1，人为排产2
                lst_jc_plan[i].N_JSCN = 114;
                lst_jc_plan[i].N_ZJCLZL = lst_jc_plan[i].N_MLZL * lst_jc_plan[i].N_ZJCLS;
                lst_jc_plan[i].N_CCM_TIME = Math.Round(Convert.ToDecimal(lst_jc_plan[i].N_MLZL * lst_jc_plan[i].N_ZJCLS / lst_jc_plan[i].N_JSCN), 2);//连铸生产需求时间

                List<Mod_TPP_LGPC_LCLSB> lst_lc_plan = bll_lc.GetModelListByJcID(lst_jc_plan[i].C_ID);

                //根据炉次计划分出浇次计划的钢种类型
                try
                {
                    #region 区分浇次计划的钢种类型
                    if (lst_lc_plan.Where(a => a.C_STL_GRD_TYPE.Contains("含硼钛废钢") || a.C_STL_GRD_TYPE.Contains("硅铝镇静钢")).ToList().Count > 0)
                    {
                        lst_jc_plan[i].C_STL_GRD_TYPE = "硅铝镇静钢";
                        if (lst_lc_plan.Where(a => a.C_PROD_NAME.Contains("轴承钢")).ToList().Count > 0)
                        {
                            lst_jc_plan[i].C_PROD_NAME = "轴承钢";
                        }
                        else if (lst_lc_plan.Where(a => a.C_PROD_NAME.Contains("弹簧钢")).ToList().Count > 0)
                        {
                            lst_jc_plan[i].C_PROD_NAME = "弹簧钢";
                        }
                        else
                        {
                            lst_jc_plan[i].C_PROD_NAME = lst_lc_plan.ToList()[0].C_PROD_NAME;
                        }


                    }
                    if (lst_lc_plan.Where(a => a.C_STL_GRD_TYPE.Contains("半沸腾钢") || a.C_STL_GRD_TYPE.Contains("超低碳钢")).ToList().Count > 0)
                    {
                        lst_jc_plan[i].C_STL_GRD_TYPE = "铝镇静钢";
                        lst_jc_plan[i].C_PROD_NAME = "超低碳钢";
                    }
                    else
                    {
                        lst_jc_plan[i].C_STL_GRD_TYPE = lst_lc_plan.ToList()[0].C_STL_GRD_TYPE;
                        if (lst_lc_plan.Where(a => a.C_PROD_NAME.Contains("轴承钢")).ToList().Count > 0)
                        {
                            lst_jc_plan[i].C_PROD_NAME = "轴承钢";
                        }
                        else if (lst_lc_plan.Where(a => a.C_PROD_NAME.Contains("弹簧钢")).ToList().Count > 0)
                        {
                            lst_jc_plan[i].C_PROD_NAME = "弹簧钢";
                        }
                        else
                        {
                            lst_jc_plan[i].C_PROD_NAME = lst_lc_plan.ToList()[0].C_PROD_NAME;
                        }
                    }
                    #endregion
                }
                catch (Exception)
                {


                }


            }
            return lst_jc_plan;
            #endregion
        }
        #endregion

        #region 将浇次计划按连铸进行排序，并初始化计划时间
        /// <summary>
        /// 将浇次计划按照排序号初始化浇次和炉次计划时间计算
        /// </summary>
        /// <param name="c_ccm">连铸机主键</param>
        /// <param name="dt_start">连铸浇次计划开始时间</param>
        /// <param name="lst">需要排序的浇次计划</param>
        /// <returns>排序后的浇次计划</returns>
        public static List<Mod_TPP_LGPC_LSB> Sort_JC_plan(string c_ccm, DateTime dt_start, List<Mod_TPP_LGPC_LSB> plan_lst)
        {
            var lst1 = plan_lst.Where(a => a.C_CCM_ID == c_ccm).OrderBy(a => a.C_CCM_ID).ThenBy(a => a.N_SORT).ToList();//获取待排序的浇次计划
            int sort = 1;
            DateTime d_start_time = dt_start;//指定开始时间
            for (int l = 0; l < lst1.Count; l++)
            {
                lst1[l].N_SORT = sort;
                lst1[l].D_P_START_TIME = d_start_time;
                //同时更新炉次计划的开始结束时间和序号
                lst1[l].D_P_END_TIME = UpdateLcPlan(lst1[l].C_ID, Convert.ToDateTime(lst1[l].D_P_START_TIME), Convert.ToDouble(lst1[l].N_PRODUCE_TIME), sort);
                sort = sort + 1;
                d_start_time = Convert.ToDateTime(lst1[l].D_P_END_TIME).AddHours(Convert.ToDouble(lst1[l].N_PRODUCE_TIME));
                foreach (var item in plan_lst)
                {
                    if (item.C_ID == lst1[l].C_ID)
                    {
                        item.N_SORT = lst1[l].N_SORT;
                        item.D_P_START_TIME = lst1[l].D_P_START_TIME;
                        item.D_P_END_TIME = lst1[l].D_P_END_TIME;

                    }
                }
            }

            return plan_lst;
        }
        #endregion

        #region 根据浇次计划更新炉次计划

        /// <summary>
        /// 根据浇次计划更新炉次计划的生产时间和顺序
        /// </summary>
        /// <param name="c_jc_id">浇次计划主键</param>
        /// <param name="dt_strat_time">浇次计划的开始时间</param>
        /// <param name="N_tjsj">停机时间</param>
        /// <param name="n_jc_sort">浇次序号</param>
        /// <returns>返回本浇次最后一炉计划结束时间</returns>
        public static DateTime UpdateLcPlan(string c_jc_id, DateTime dt_strat_time, double N_tjsj, int n_jc_sort)
        {
            DateTime dt = dt_strat_time;
            DateTime dt_end_time = dt_strat_time;//浇次结束时间
            List<Mod_TPP_LGPC_LCLSB> lst = new List<Mod_TPP_LGPC_LCLSB>();
            lst = bll_lc.GetModelListByJcID(c_jc_id).OrderBy(a => a.N_SORT).ToList();
            if (lst.Count > 0)
            {
                for (int i = 0; i < lst.Count; i++)
                {
                    if (N_tjsj > 0 && i == lst.Count - 1)
                    {
                        lst[i].N_PRODUCE_TIME = Convert.ToDecimal(N_tjsj);//如果浇次结束后需要停机的在最后一炉添加停机时间
                    }
                    else
                    {
                        lst[i].N_PRODUCE_TIME = 0;
                    }
                    lst[i].N_SORT = i + 1;
                    lst[i].N_JC_SORT = n_jc_sort;
                    lst[i].D_P_START_TIME = dt;
                    lst[i].D_P_END_TIME = Convert.ToDateTime(dt).AddHours(Convert.ToDouble(lst[i].N_SLAB_WGT / lst[i].N_JSCN));
                    bll_lc.Update(lst[i]);
                    dt = Convert.ToDateTime(lst[i].D_P_END_TIME).AddHours(Convert.ToDouble(lst[i].N_PRODUCE_TIME));//下已炉的开始时间
                    dt_end_time = Convert.ToDateTime(lst[i].D_P_END_TIME);
                }

            }

            return dt_end_time;
        }
        #endregion

        #region 调整浇次计划整浇次炉数
        /// <summary>
        /// 调整浇次计划炉数
        /// </summary>
        /// <param name="jc_id">浇次主键</param>
        /// <param name="num">调整后的浇次炉数</param>
        /// <param name="sfcangejc">是否调整其他浇次计划</param>
        public static void ChangeJCLs(string jc_id, int num, string sfcangejc)
        {
            #region 获取当前浇次计划产品的整浇次炉数信息
            int zjcls = 20;
            int zjclsmin = 18;
            int zjclsmax = 22;
            #endregion

            decimal? fzh = null;
            List<Mod_TPP_LGPC_LCLSB> lst = bll_lc.GetModelListByJcID(jc_id);//当前浇次的炉次计划
            Mod_TPP_LGPC_LSB mod = bll_jc.GetModel(jc_id);
            int d_value = Convert.ToInt32(mod.N_ZJCLS) - num;//原来浇次数-调整后的炉数；正数减少浇次炉数，负数是增加炉次计划

            if (d_value > 0)//将该浇次炉数调少
            {
                if ((mod.N_ZJCLS - mod.N_ORDER_LS) >= d_value)//该浇次的非计划炉数比减少的炉数多
                {
                    var lst1 = lst.Where(a => a.C_STATE == "1").OrderByDescending(a => a.N_SORT).ToList();
                    for (int i = 0; i < d_value; i++)
                    {
                        bll_lc.Delete(lst1[i].C_ID);
                    }
                }
                else
                {
                    lst = lst.OrderByDescending(a => a.N_SORT).ToList();
                    for (int i = 0; i < d_value; i++)
                    {
                        if (lst[i].C_STATE == "1")
                        {
                            bll_lc.Delete(lst[i].C_ID);//非计划删除 
                        }
                        if (lst[i].C_STATE == "0")//计划炉次计划
                        {
                            List<Mod_TPP_LGPC_LCLSB> lstlc = bll_lc.GetModelList("").Where(a => a.N_GROUP == mod.N_GROUP && a.N_JC_SORT > mod.N_SORT && a.C_STL_GRD == mod.C_STL_GRD && a.C_STD_CODE == mod.C_STD_CODE && a.C_STATE == "1").OrderByDescending(a => a.N_JC_SORT).ThenBy(a => a.N_SORT).ToList();
                            if (lstlc.Count > 0)//有可替换的炉次计划
                            {
                                //替换
                                bll_lc.Delete(lst[i].C_ID);//计划删除

                                lstlc[0].C_STATE = "0";
                                bll_lc.Update(lstlc[0]);
                                mod.N_ORDER_LS = mod.N_ORDER_LS - 1;//当前浇次计划的计划炉次
                                Mod_TPP_LGPC_LSB modupdate = bll_jc.GetModel(lstlc[0].C_FK);
                                modupdate.N_ORDER_LS = modupdate.N_ORDER_LS + 1;
                                bll_jc.Update(modupdate);

                            }
                            else//没有可替换的
                            {
                                List<Mod_TPP_LGPC_LSB> lstinsert = bll_jc.GetModelList("").Where(a => a.N_GROUP == mod.N_GROUP && a.C_ID != mod.C_ID && a.N_SORT > mod.N_SORT && a.N_ZJCLS < zjcls).OrderByDescending(a => a.N_SORT).ToList();//有没有可以插入当前浇次多余的炉次计划的浇次计划,按顺序向下找

                                if (lstinsert.Count > 0)//有可转移的浇次计划
                                {
                                    bll_lc.Delete(lst[i].C_ID);//计划删除

                                    Mod_TPP_LGPC_LCLSB modadd = new Mod_TPP_LGPC_LCLSB();
                                    modadd = lst[i];
                                    modadd.C_FK = lstinsert[0].C_ID;
                                    modadd.C_ID = System.Guid.NewGuid().ToString();
                                    modadd.N_SORT = bll_lc.MaxSortBy(modadd.C_FK) + 1;
                                    modadd.N_JC_SORT = lstinsert[0].N_SORT;
                                    bll_lc.Add(modadd);

                                    lstinsert[0].N_ORDER_LS = lstinsert[0].N_ORDER_LS + 1;
                                    lstinsert[0].N_ZJCLS = lstinsert[0].N_ZJCLS + 1;
                                    lstinsert[0].N_ZJCLZL = lstinsert[0].N_ZJCLS * lstinsert[0].N_MLZL;
                                    bll_jc.Update(lstinsert[0]);
                                    //炉次计划转移到目标浇次计划
                                    mod.N_ORDER_LS = mod.N_ORDER_LS - 1;//当前浇次计划的计划炉次

                                }
                                else
                                {
                                    //新增浇次计划
                                    Mod_TPP_LGPC_LSB mod_add_jc = new Mod_TPP_LGPC_LSB();
                                    mod_add_jc.N_SORT = bll_jc.GetModelList("").Where(a => a.C_CCM_ID == mod.C_CCM_ID).ToList().Count + 1;//插入到浇次计划的最后面
                                    mod_add_jc.C_ID = System.Guid.NewGuid().ToString();
                                    mod_add_jc.C_STL_GRD = lst[i].C_STL_GRD;
                                    mod_add_jc.C_STD_CODE = lst[i].C_STD_CODE;
                                    mod_add_jc.N_ORDER_LS = 1;
                                    mod_add_jc.N_GROUP = lst[i].N_GROUP;
                                    mod_add_jc.N_ZJCLS = zjclsmin;
                                    mod_add_jc.N_ZJCLZL = mod_add_jc.N_ZJCLS * mod_add_jc.N_MLZL;
                                    mod_add_jc.C_STL_GRD_TYPE = lst[i].C_STL_GRD_TYPE;
                                    mod_add_jc.C_PROD_NAME = lst[i].C_PROD_NAME;
                                    mod_add_jc.C_CCM_ID = lst[i].C_CCM_ID;
                                    bll_jc.Add(mod_add_jc);
                                    //新增炉次计划

                                    bll_lc.Delete(lst[i].C_ID);

                                    //炉次计划转移到新增浇次计划
                                    Mod_TPP_LGPC_LCLSB mod_add_lc = new Mod_TPP_LGPC_LCLSB();
                                    mod_add_lc = lst[i];
                                    mod_add_lc.C_ID = System.Guid.NewGuid().ToString();
                                    mod_add_lc.C_FK = mod_add_jc.C_ID;
                                    mod_add_lc.N_SORT = 1;
                                    mod_add_lc.N_JC_SORT = mod_add_jc.N_SORT;
                                    mod_add_lc.C_STATE = "0";
                                    bll_lc.Add(mod_add_lc);

                                    for (int l = 1; l < mod_add_jc.N_ZJCLS; l++)
                                    {
                                        Mod_TPP_LGPC_LCLSB mod_add_lc2 = new Mod_TPP_LGPC_LCLSB();
                                        mod_add_lc2 = lst[i];
                                        mod_add_lc2.C_ID = System.Guid.NewGuid().ToString();
                                        mod_add_lc2.C_FK = mod_add_jc.C_ID;
                                        mod_add_lc2.N_SORT = l + 1;
                                        mod_add_lc2.C_STATE = "1";
                                        mod_add_lc2.N_JC_SORT = mod_add_jc.N_SORT;
                                        bll_lc.Add(mod_add_lc2);
                                    }
                                    mod.N_ORDER_LS = mod.N_ORDER_LS - 1;//当前浇次计划的计划炉次
                                }

                            }
                        }
                    }

                }
            }
            else//将该浇次炉数调大
            {
                int addls = d_value * -1;
                for (int j = 0; j < addls; j++)
                {
                    List<Mod_TPP_LGPC_LSB> lst1 = bll_jc.GetModelList("").Where(a => a.N_GROUP == mod.N_GROUP && a.N_SORT > mod.N_SORT && a.C_CCM_ID == mod.C_CCM_ID).ToList();
                    if (lst1.Count == 0)
                    {
                        Mod_TPP_LGPC_LCLSB modlc = lst[lst.Count - 1];//复制最后一条炉次计划
                        modlc.C_ID = System.Guid.NewGuid().ToString();
                        modlc.N_SORT = modlc.N_SORT + j + 1;//更新炉次计划序号
                        modlc.C_STATE = "1";//增加的计划为非计划炉次计划
                        bll_lc.Add(modlc);
                    }
                    else
                    {

                        //查找可替换的炉次计划（浇次序号在当前浇次后面的）
                        Mod_TPP_LGPC_LCLSB modlc = lst[lst.Count - 1];//复制最后一条炉次计划
                        List<Mod_TPP_LGPC_LCLSB> lstth = bll_lc.GetModelList("").Where(a => a.N_GROUP == modlc.N_GROUP && a.N_JC_SORT > modlc.N_JC_SORT && a.C_STATE == "0" && a.C_STL_GRD == modlc.C_STL_GRD && a.C_STD_CODE == modlc.C_STD_CODE).OrderByDescending(a => a.N_JC_SORT).ThenByDescending(a => a.N_SORT).ToList();
                        if (lstth.Count > 0)
                        {


                            modlc.C_ID = System.Guid.NewGuid().ToString();
                            modlc.N_SORT = modlc.N_SORT + j + 1;//更新炉次计划序号
                            modlc.C_STATE = "0";//增加的计划为非计划炉次计划
                            mod.N_ORDER_LS++;
                            bll_lc.Add(modlc);


                            lstth[0].C_STATE = "1";
                            bll_lc.Update(lstth[0]);

                            Mod_TPP_LGPC_LSB modjcth = bll_jc.GetModel(lstth[0].C_FK);
                            modjcth.N_ORDER_LS--;
                            bll_jc.Update(modjcth);
                        }
                        else
                        {
                            Mod_TPP_LGPC_LCLSB modlc1 = lst[lst.Count - 1];//复制最后一条炉次计划
                            modlc1.C_ID = System.Guid.NewGuid().ToString();
                            modlc1.N_SORT = modlc1.N_SORT + j + 1;//更新炉次计划序号
                            modlc1.C_STATE = "1";//增加的计划为非计划炉次计划
                            bll_lc.Add(modlc1);
                        }
                    }

                }



            }
            mod.N_ZJCLS = Convert.ToInt32(num);//调整后的整浇次炉数
            mod.N_ZJCLZL = mod.N_ZJCLS * mod.N_MLZL;
            fzh = mod.N_GROUP;
            bll_jc.Update(mod);
        }

        #endregion

        #region 根据已排产计划获取本次排产炼钢计划的开始时间
        /// <summary>
        /// 根据已排产炉次计划获取本次排产首条计划的开始时间
        /// </summary>
        /// <param name="c_ccm">连铸机ID</param>
        /// <returns>计划开始时间</returns>
        public static DateTime? GetStartTime(string c_ccm)
        {
            DateTime? dt = null;
            try
            {
                var sms_list = sms_plan.Where(a => a.C_CCM_ID == c_ccm).OrderByDescending(a => a.D_P_END_TIME).ToList();//已排产炉次计划并按计划时间倒序
                if (sms_list.Count > 0)
                {
                    dt = Convert.ToDateTime(sms_list[0].D_P_END_TIME).AddHours(Convert.ToDouble(sms_list[0].N_PRODUCE_TIME));
                    if (dt == null || dt <= System.DateTime.Now)
                    {
                        dt = System.DateTime.Now;

                    }
                }
                else
                {
                    dt = System.DateTime.Now;

                }
            }
            catch (Exception)
            {
                dt = System.DateTime.Now;
            }

            return dt;
        }
        #endregion

        #region 确定已排产连铸计划连续过RH的炉数
        /// <summary>
        /// 获得当前排产浇次计划连续过RH的总数
        /// </summary>
        /// <param name="c_ccm">连铸主键</param>
        /// <returns>连续RH炉数</returns>
        public static int GetRHNum(string c_ccm)
        {
            int YPRH = bll_plan_sms.GetYPRH();//已排产5#连铸计划的RH总数
            int ls = 0;
            var ypjc = jc_plan.Where(a => a.N_STATUS == 1).OrderByDescending(a => a.N_SORT).ToList();
            if (ypjc.Count > 0)
            {
                for (int i = 0; i < ypjc.Count; i++)
                {
                    if (ypjc[i].N_RH > 0)
                    {
                        ls = ls + Convert.ToInt32(ypjc[i].N_RH);
                        if (i == ypjc.Count - 1)
                        {
                            ls = ls + YPRH;
                        }
                    }
                    else
                    {
                        break;
                    }
                }
                return ls;
            }
            else
            {
                return YPRH;
            }


        }

        #endregion

        #region 从未排产的浇次计划中获取下个可排产的浇次计划列表
        /// <summary>
        /// 从未排产的浇次计划中获取下个可排产的浇次计划列表
        /// </summary>
        /// <param name="wplst">未排产浇次计划</param>
        /// <param name="strSFRH">浇次是否过RH</param>
        /// <param name="c_stl_type">钢种类型</param>
        /// <param name="c_prod_name">品名</param>
        /// <returns>返回可排产的浇次计划列表</returns>
        public static List<Mod_TPP_LGPC_LSB> GetNextJC(List<Mod_TPP_LGPC_LSB> wplst, string strSFRH, string c_stl_type, string c_prod_name)
        {
            #region 获取可排计划
            List<Mod_TPP_LGPC_LSB> kpjc = wplst;//可排产浇次计划
            if (c_stl_type == "")//系统按规则找出第一个浇次计划 能生产的浇次计划
            {
                kpjc = wplst.Where(a => a.C_RH == strSFRH).OrderByDescending(a => a.N_DFP_HL_TIME + a.N_HL_TIME + a.N_XM_TIME).ToList();//不过RH的所有5#连铸的计划
            }
            if (c_stl_type == "硅铝镇静钢" && c_prod_name == "弹簧钢")
            {
                //只能排硅铝镇静钢的非轴承钢浇次计划
                kpjc = wplst.Where(a => a.C_STL_GRD_TYPE == "硅铝镇静钢" && a.C_PROD_NAME != "轴承钢" && a.C_RH == strSFRH).OrderByDescending(a => a.N_DFP_HL_TIME + a.N_HL_TIME + a.N_XM_TIME).ToList();

            }
            if (c_stl_type == "硅铝镇静钢" && c_prod_name == "轴承钢")
            {
                //只能排硅铝镇静钢的非弹簧钢的浇次计划
                kpjc = wplst.Where(a => a.C_STL_GRD_TYPE == "硅铝镇静钢" && a.C_PROD_NAME != "弹簧钢" && a.C_RH == strSFRH).OrderByDescending(a => a.N_DFP_HL_TIME + a.N_HL_TIME + a.N_XM_TIME).ToList();
            }
            if (c_stl_type == "硅铝镇静钢" && c_prod_name != "弹簧钢" && c_prod_name != "轴承钢")
            {
                //可排所有浇次计划除超低碳（超低碳需有过渡浇次）

                kpjc = wplst.Where(a => a.C_PROD_NAME != "超低碳" && a.C_RH == strSFRH).OrderByDescending(a => a.N_DFP_HL_TIME + a.N_HL_TIME + a.N_XM_TIME).ToList();
            }
            if (c_stl_type == "铝镇静钢" && c_prod_name == "超低碳")
            {
                //超低碳
                kpjc = wplst.Where(a => a.C_PROD_NAME == "超低碳" && a.C_RH == strSFRH).OrderByDescending(a => a.N_DFP_HL_TIME + a.N_HL_TIME + a.N_XM_TIME).ToList();
            }
            if (c_stl_type == "铝镇静钢" && c_prod_name == "弹簧钢")
            {
                //只能排硅铝镇静钢的非轴承钢浇次计划或同类
                kpjc = wplst.Where(a => ((a.C_STL_GRD_TYPE == "硅铝镇静钢" && a.C_PROD_NAME != "轴承钢") || (a.C_STL_GRD_TYPE == "铝镇静钢" && a.C_PROD_NAME != "弹簧钢")) && a.C_RH == strSFRH).OrderByDescending(a => a.N_DFP_HL_TIME + a.N_HL_TIME + a.N_XM_TIME).ToList();
            }
            if (c_stl_type == "铝镇静钢" && c_prod_name == "轴承钢")
            {
                //只能排硅铝镇静钢的非弹簧钢的浇次计划或同类
                kpjc = wplst.Where(a => ((a.C_STL_GRD_TYPE == "硅铝镇静钢" && a.C_PROD_NAME != "弹簧钢") || (a.C_STL_GRD_TYPE == "铝镇静钢" && a.C_PROD_NAME != "轴承钢")) && a.C_RH == strSFRH).OrderByDescending(a => a.N_DFP_HL_TIME + a.N_HL_TIME + a.N_XM_TIME).ToList();
            }
            if (c_stl_type == "铝镇静钢" && c_prod_name != "弹簧钢" && c_prod_name != "轴承钢" && c_prod_name != "超低碳")
            {
                //只能排硅铝镇静钢的非弹簧钢的浇次计划或同类
                kpjc = wplst.Where(a => ((a.C_STL_GRD_TYPE == "硅铝镇静钢" && a.C_PROD_NAME != "弹簧钢" && a.C_PROD_NAME != "轴承钢") || (a.C_STL_GRD_TYPE == "铝镇静钢")) && a.C_RH == strSFRH).OrderByDescending(a => a.N_DFP_HL_TIME + a.N_HL_TIME + a.N_XM_TIME).ToList();
            }
            if (c_stl_type == "硅镇静钢")
            {
                //只能排硅铝镇静钢的非弹簧钢的浇次计划或同类
                kpjc = wplst.Where(a => a.C_STL_GRD_TYPE == "硅铝镇静钢" && a.C_PROD_NAME != "弹簧钢" && a.C_PROD_NAME != "轴承钢" && a.C_RH == strSFRH).OrderByDescending(a => a.N_DFP_HL_TIME + a.N_HL_TIME + a.N_XM_TIME).ToList();
            }
            #endregion

            return kpjc;

        }


        #endregion

        #region 获取当前计划缓冷坑剩余容量
        /// <summary>
        ///当前浇次计划需大方坯缓冷时缓冷坑的剩余容量
        /// </summary>
        /// <param name="dtHLB">计划开始缓冷的时间</param>
        /// <param name="plan_qua">每炉计划支数</param>
        /// <returns>剩余总容量</returns>
        public static int DHL_Left_Cap(DateTime dtHLB, int plan_qua)
        {
            #region 大方坯缓冷坑剩余容量
            int dhlrl = Convert.ToInt32(hl_acl.Where(a => a.C_SLAB_TYPE == "大方坯").Sum(a => a.N_CAP_QUA));//大方坯缓冷坑的总容量
            var dflrl = dhl_plan.Where(a => a.D_OVER_TIME > dtHLB);//当前浇次计划排产时还没有缓冷结束的缓冷计划
            var g = dflrl.GroupBy(x => x.C_WH_CODE);
            var results = g.Select(x => new
            {
                Key = x.Key,
                Name = x.First().C_WH_CODE,
                Count = x.Sum(s => s.N_QUA)
            });
            foreach (var item in results)
            {
                string key = item.Key;
                string name = item.Name;
                int cap = Convert.ToInt32(hl_acl.Where(a => a.C_WH_CODE == name).ToList()[0].N_CAP_QUA);
                int rl = Convert.ToInt32(item.Count);//已使用容量
                if ((cap - rl) < plan_qua)
                {
                    rl = cap;
                }
                dhlrl = dhlrl - rl;//大方坯缓冷坑的当前剩余容量
            }
            return dhlrl;
            #endregion

        }

        #endregion

        #region 获取当前计划可开坯剩余量
        /// <summary>
        ///获取当前时间剩余的可开坯计划量
        /// </summary>
        /// <param name="dtB">计划时间</param>
        /// <returns>剩余可开坯量</returns>
        public static double Get_KP_Left(DateTime dtB)
        {
            return Convert.ToDouble(kp_plan.Where(a => a.D_CAN_START_TIME <= dtB && a.D_START_TIME > dtB).Sum(a => a.N_WGT));//当前时间可以开坯但是没有开坯的，是开坯库存量

        }


        #endregion

        #region 获取当前计划需缓冷的大方坯总支数
        /// <summary>
        ///获取当前浇次计划的大方坯需缓冷总支数
        /// </summary>
        /// <param name="c_id">浇次计划临时表主键</param>
        /// <param name="plan_qua">每炉计划大方坯支数</param>
        /// <returns>大方坯缓冷总支数</returns>
        public static int jcjh_dhlzs(string c_id, int plan_qua)
        {

            var lc_plan_item = lc_plan.Where(a => a.C_FK == c_id).ToList();//当前浇次计划的炉次计划
            return lc_plan_item.Where(a => a.C_DFP_HL == "Y").ToList().Count * plan_qua;//当前浇次计划需入坑支数

        }
        #endregion

        #region 获取当前计划热轧钢坯缓冷坑剩余容量

        /// <summary>
        ///当前浇次计划需热轧坯缓冷时缓冷坑的剩余容量
        /// </summary>
        /// <param name="dtHL">计划开始缓冷的时间</param>
        /// <param name="plan_qua">每炉计划支数</param>
        /// <returns>剩余总容量</returns>
        public static int HL_Left_Cap(DateTime dtHL, int plan_qua)
        {
            #region 大方坯缓冷坑剩余容量
            int hlrl = Convert.ToInt32(hl_acl.Where(a => a.C_SLAB_TYPE == "小方坯").Sum(a => a.N_CAP_QUA));//小方坯缓冷坑的总容量
            var flrl = dhl_plan.Where(a => a.D_OVER_TIME > dtHL);//当前浇次计划排产时还没有缓冷结束的缓冷计划
            var g = flrl.GroupBy(x => x.C_WH_CODE);
            var results = g.Select(x => new
            {
                Key = x.Key,
                Name = x.First().C_WH_CODE,
                Count = x.Sum(s => s.N_QUA)
            });
            foreach (var item in results)
            {
                string key = item.Key;
                string name = item.Name;
                int cap = Convert.ToInt32(hl_acl.Where(a => a.C_WH_CODE == name).ToList()[0].N_CAP_QUA);
                int rl = Convert.ToInt32(item.Count);//已使用容量

                if ((cap - rl) < plan_qua)//坑容量不足一炉时标记已满
                {
                    rl = cap;
                }
                hlrl = hlrl - rl;//大方坯缓冷坑的当前剩余容量
            }
            return hlrl;
            #endregion

        }
        #endregion

        #region 获取当前计划需缓冷的热轧坯总支数
        /// <summary>
        ///获取当前浇次计划的大方坯需缓冷总支数
        /// </summary>
        /// <param name="c_id">浇次计划临时表主键</param>
        /// <param name="plan_qua">每炉计划热轧钢坯支数</param>
        /// <returns>大方坯缓冷总支数</returns>
        public static int jcjh_hlzs(string c_id, int plan_qua)
        {

            var lc_plan_item = lc_plan.Where(a => a.C_FK == c_id).ToList();//当前浇次计划的炉次计划
            return lc_plan_item.Where(a => a.C_HL == "Y").ToList().Count * plan_qua;//当前浇次计划需入坑支数

        }
        #endregion

        #region 获取当前浇次计划待修磨量（可修磨时间）
        /// <summary>
        /// 修磨计划剩余计划量
        /// </summary>
        /// <param name="dt_xm">当前计划时间</param>
        /// <param name="type">修磨钢坯类型，碳钢、不锈钢</param>
        /// <param name="jscn">机时产能</param>
        /// <returns>剩余计划可执行时间</returns>
        public static double xm_syl(DateTime dt_xm, string type, double jscn)
        {
            double xmjhl = Convert.ToDouble(xm_plan.Where(a => a.C_XM_TYPE == type && a.D_END_TIME >= dt_xm).Sum(a => a.N_WGT));//当前计划开始时已排计划的修磨剩余计划量
            return Math.Round(xmjhl / jscn, 2);
        }

        #endregion

        #region 获取5#连铸未排计划超低碳生产浇次数（含生产超低碳需要的过渡浇次数）

        /// <summary>
        /// 获取5#连铸未排超低碳计划连续生产的总时间（含生产超低碳需要的过渡浇次数）
        /// </summary>
        /// <param name="lst">5#连铸未排浇次计划</param>
        /// <returns>返回超低碳生产需要总时间</returns>
        public static double GetCDTJH(List<Mod_TPP_LGPC_LSB> lst)
        {
            lst = lst.Where(a => (a.C_PROD_NAME == "超低碳钢" || a.C_STL_GRD == "DT4") && a.C_RH == "Y" && a.N_STATUS == 0).ToList();//过RH炉的超低碳钢 生产时含CHIT的浇次排第一个浇次 CH1T前可生产DT4
            if (lst.Count > 0)
            {
                return Convert.ToDouble(lst.Sum(a => a.N_ZJCLS) * lst.Max(a => a.N_MLZL) / lst.Min(a => a.N_JSCN));//连续生产过RH超低碳所需要的时间
            }
            else
            {
                return 0;
            }


        }

        #endregion

        #region 5#CCM浇次计划排产
        /// <summary>
        /// 5#CCM浇次计划排产
        /// </summary>
        /// <param name="lst">待排产5#连铸计划</param>
        /// <param name="RHNUM">排产开始前已下达计划的RH炉生产炉数</param>
        /// <param name="RHSM">RH炉寿命</param>
        /// <param name="c_stl_type">排产前已下达的上一个浇次计划的钢种类型</param>
        /// <param name="c_prod_name">排产前已下达的上一个浇次计划的钢种品名</param>
        /// <returns>排序结果</returns>
        public static List<Mod_TPP_LGPC_LSB> Jc_plan_PC_5CCM(List<Mod_TPP_LGPC_LSB> lst, int RHNUM, int RHSM, DateTime dtB, string c_stl_type, string c_prod_name)
        {
            string strSFRH = "";

            //当剩余计划中超低碳钢未开始生产时优先将需缓冷和需要修磨的计划提前排产并超出生产超低碳钢生产时间后排产超低碳的钢种
            //没有需要集中生产的钢种后，为了保证订单交期，在条件满足的前提下优先排产生产周期长，混交钢种多（设计订单钢种多）的浇次计划；
            int sort = 5;
            int lxls = 0;
            for (int i = 0; i < lst.Count; i++)
            {
                Mod_TPP_LGPC_LSB modpc = new Mod_TPP_LGPC_LSB();//实例需要排产的浇次计划
                #region 判断待排产的浇次计划是否过RH炉
                if (RHNUM < RHSM)//排产过RH炉的计划
                {
                    if (RHNUM == 0)
                    {
                        int leftRH = Convert.ToInt32(lst.Where(a => a.N_STATUS == 0).Sum(a => a.N_RH));
                        if (leftRH < 100)//设定100炉以下的RH浇次计划为半连续
                        {
                            int noRH = Convert.ToInt32(lst.Where(a => a.N_STATUS == 0 && a.C_RH == "N").ToList().Count);//是否有不过RH炉的浇次计划
                            if (noRH > 0)
                            {
                                strSFRH = "N";//将半浇次计划放在最后生产
                            }
                            else
                            {
                                strSFRH = "Y";//最后生产半连续的RH炉计划
                            }
                        }
                        else
                        {
                            strSFRH = "Y";
                        }
                    }
                    else
                    {
                        strSFRH = "Y";
                    }

                }
                else
                {
                    strSFRH = "N";
                }
                string yc_remark = "";//排产异常备注
                if (strSFRH == "Y")
                {
                    //查找是否有过RH炉的浇次计划
                    var lstRH = lst.Where(a => a.C_RH == "Y" && a.N_STATUS == 0).ToList();
                    if (lstRH.Count == 0)
                    {
                        strSFRH = "N";
                        yc_remark = "RH炉计划不连续";
                    }
                }
                #endregion

                #region 下一个排产浇次选择计划池
                //下一个排产浇次选择计划池
                var nestPlanlst = GetNextJC(lst.Where(a => a.N_STATUS == 0).ToList(), strSFRH, c_stl_type, c_prod_name).OrderByDescending(a => a.N_DFP_HL_TIME + a.N_HL_TIME + a.N_XM_TIME).ToList();//从未排产lst中找可排产的浇次计划，按生产周期从长到短进行排序
                if (nestPlanlst.Count == 0)
                {
                    yc_remark = yc_remark + "~钢种不能衔接";//排产异常备注
                    nestPlanlst = lst.Where(a => a.C_RH == strSFRH && a.N_STATUS == 0).OrderByDescending(a => a.N_DFP_HL_TIME + a.N_HL_TIME + a.N_XM_TIME).ToList();//按生产周期从长到短进行排序
                }
                if (nestPlanlst.Count == 0)
                {
                    string msg = yc_remark;
                }
                #endregion

                //在nestPlanlst中找出合适的浇次计划
                //大方坯缓冷坑是否可用（优先满坑）坑满排修磨
                int leftDFPcap = DHL_Left_Cap(dtB, 19);//当前大方坯缓冷坑剩余容量 19是每炉的计划钢坯支数

                //计算开坯计划结束时间
                double kp_left = Get_KP_Left(dtB);//计划排产时可开坯剩余量,警戒线设为1000T
                                                  //计算热轧坯缓冷坑是否可用(热送热轧的量不能超过缓冷坑量)


                double cdt_pro_time = GetCDTJH(lst);//剩余过RH过RH的超低碳生产时间（超低碳连续生产5天，修磨剩余时间准备6天以上，安全时间设置1天）

                //计算修磨是否能够衔接
                double xmsysj = xm_syl(dtB, "碳钢", 400 / 24);//当前计划开始时的修磨机剩余可修磨时间，400是修磨机的日产能
                                                            //有超低碳时修磨量先攒够开超低碳的时间
                #region 选择计划
                string sfXM = "Y";//是否安排修磨计划
                string sfHL = "Y";//热轧坯能否缓冷
                string nfDHL = "Y";//大方坯能否缓冷
                string nfRZ = "Y";//大方坯能否热装热轧并缓冷

                #region 能否安排大方坯缓冷的浇次计划
                if (kp_left <= 1000)
                {
                    nfDHL = "N";//保证开坯连续
                    nestPlanlst = nestPlanlst.Where(a => a.C_DFP_HL == "N").OrderByDescending(a => a.N_DHL).ToList();//查找合适的可以大方坯缓冷的浇次计划
                }
                else
                {
                    var nlst = nestPlanlst.Where(a => a.C_DFP_HL == "Y" && a.N_DHL * 19 <= leftDFPcap).OrderByDescending(a => a.N_DHL).ToList();//查找合适的可以大方坯缓冷的浇次计划
                    if (nlst.Count == 0)
                    {
                        nfDHL = "N";//大方坯缓冷坑容量不够
                        nestPlanlst = nestPlanlst.Where(a => a.C_DFP_HL == "N").OrderByDescending(a => a.N_DHL).ToList();//查找合适的可以大方坯缓冷的浇次计划
                    }
                    else
                    {
                        nestPlanlst = nestPlanlst.Where(a => a.C_DFP_HL == "Y" && a.N_DHL * 19 <= leftDFPcap).OrderByDescending(a => a.N_DHL).ToList();//查找合适的可以大方坯缓冷的浇次计划
                    }
                }
                #endregion

                #region 排产计划时有没有预留的热轧坯缓冷坑
                int leftHLcap = 0;//当前浇次计划可用的热轧钢坯缓冷坑
                if (nfDHL == "N")
                {
                    leftHLcap = HL_Left_Cap(dtB, 38);//当前浇次计划可用的热轧钢坯缓冷坑
                }
                else
                {
                    leftHLcap = HL_Left_Cap(dtB.AddHours(72), 38);//将热轧坯入坑时间延后72小时
                }
                var dhllst2 = nestPlanlst.Where(a => a.C_HL == "Y" && a.N_DFP_RZ * 38 <= leftHLcap).OrderByDescending(a => a.N_DHL).ToList();//验证热送热轧时热轧钢坯缓冷坑是否有容量
                if (dhllst2.Count == 0)
                {
                    sfHL = "N";
                    nestPlanlst = nestPlanlst.Where(a => a.C_HL == "N").OrderByDescending(a => a.N_DHL).ToList();//验证
                }
                else
                {
                    sfHL = "Y";
                    nestPlanlst = nestPlanlst.Where(a => a.C_HL == "Y" && a.N_DFP_RZ * 38 <= leftHLcap).OrderByDescending(a => a.N_DHL).ToList();//验证
                }
                #endregion

                #region 是否安排需要修磨的计划
                if (cdt_pro_time > 0)//有过RH的超低碳钢未排
                {
                    int leftxm = Convert.ToInt32(nestPlanlst.Where(a => a.C_XM == "Y").Sum(a => a.N_XM));//剩余计划的修磨炉数
                    if (leftxm > 0)
                    {
                        if (strSFRH == "Y" && sfHL == "N" && nfDHL == "N" && xmsysj > cdt_pro_time + 150)
                        {
                            //生产超低碳
                            nestPlanlst = nestPlanlst.Where(a => a.C_PROD_NAME == "超低碳钢").ToList();
                        }
                        else
                        {
                            nestPlanlst = nestPlanlst.Where(a => a.C_XM == "Y").ToList();
                        }
                    }
                    else
                    {
                        if (strSFRH == "Y" && sfHL == "N" && nfDHL == "N")//超低碳
                        {
                            nestPlanlst = nestPlanlst.Where(a => a.C_PROD_NAME == "超低碳钢").ToList();
                        }
                    }

                }
                else//没有超低碳计划
                {
                    if (xmsysj > 150)//设定150为修磨安全警戒线，先不安排修磨计划
                    {
                        var xmlst = nestPlanlst.Where(a => a.C_XM == "N").ToList();
                        if (xmlst.Count > 0)
                        {
                            nestPlanlst = nestPlanlst.Where(a => a.C_XM == "N").ToList();
                        }
                    }
                    else//必须安排修磨计划
                    {
                        var xmlst = nestPlanlst.Where(a => a.C_XM == "Y").ToList();
                        if (xmlst.Count > 0)
                        {
                            nestPlanlst = nestPlanlst.Where(a => a.C_XM == "Y").ToList();
                        }

                    }
                }

                #endregion
                #endregion
                //if (nestPlanlst.Count > 0)
                //{
                modpc = nestPlanlst[0];
                #region 在list中将待排产的浇次排产
                for (int j = 0; j < lst.Count; j++)
                {
                    if (lst[j].C_ID == modpc.C_ID)
                    {
                        c_stl_type = modpc.C_STL_GRD_TYPE;
                        c_prod_name = modpc.C_PROD_NAME;
                        lst[j].N_STATUS = 1;
                        lst[j].N_SORT = sort;
                        lst[j].C_PROD_KIND = yc_remark;
                        lst[j].D_P_START_TIME = dtB;
                        lst[j].D_P_END_TIME = dtB.AddHours(Math.Round(Convert.ToDouble(lst[j].N_ZJCLS * lst[j].N_MLZL / lst[j].N_JSCN), 2));
                        RHNUM = RHNUM + Convert.ToInt32(lst[j].N_RH);

                        #region 将炉次计划的工序计划插入到工序计划list表中

                        List<Mod_TPP_LGPC_LCLSB> lst_lc = bll_lc.GetModelListByJcID(lst[j].C_ID);
                        if (lst_lc.Count > 0)
                        {
                            #region 插入大方坯缓冷计划
                            for (int lc = 0; lc < lst_lc.Count; lc++)
                            {
                                // var lstdhl= dhl_plan.Where();

                                //  dhl_plan.Add();
                                if (lst_lc[lc].C_DFP_HL == "Y")
                                {
                                    Mod_TPA_DHL_PLAN mod_dhl = new Mod_TPA_DHL_PLAN();
                                    mod_dhl.C_ID = System.Guid.NewGuid().ToString();
                                    mod_dhl.C_FK = lst_lc[lc].C_ID;
                                    mod_dhl.C_STL_GRD = lst_lc[lc].C_STL_GRD;
                                    mod_dhl.C_STD_CODE = lst_lc[lc].C_STD_CODE;
                                    mod_dhl.C_CCM = lst_lc[lc].C_CCM_DESC;
                                    mod_dhl.C_HLYQ = lst_lc[lc].C_DFP_YQ;
                                    mod_dhl.N_HL_TIME = lst_lc[lc].N_HL_TIME;
                                    mod_dhl.N_QUA = 19;
                                    mod_dhl.C_HLYQ = lst_lc[lc].C_DFP_YQ;
                                    mod_dhl.D_START_TIME = Convert.ToDateTime(lst_lc[lc].D_P_START_TIME).AddHours(2);
                                    mod_dhl.D_END_TIME = Convert.ToDateTime(lst_lc[lc].D_P_START_TIME).AddHours(2).AddHours(Convert.ToDouble(mod_dhl.N_HL_TIME));//计划缓冷结束时间

                                    var lstdhl = dhl_plan.Where(a => a.D_OVER_TIME > mod_dhl.D_START_TIME).GroupBy(a => a.C_WH_CODE).Select(a => new { wh = a.Key, count = a.Sum(p => p.N_QUA) }).ToList();//查找缓冷未结束的坑

                                }
                            }
                            #endregion
                            #region 插入开坯计划

                            #endregion
                            #region 插入热轧坯缓冷计划

                            #endregion

                            #region 插入修磨计划

                            #endregion

                        }

                        #endregion

                        if (lst[j].C_RH == "N")
                        {
                            RHNUM = 0;
                        }
                        sort = sort + 1;
                        if (c_prod_name != "超低碳钢")
                        {
                            lxls = lxls + Convert.ToInt32(lst[j].N_ZJCLS);
                        }
                        if (lxls >= 32)
                        {
                            lst[j].N_PRODUCE_TIME = 4;//化冷钢时间
                            lxls = 0;
                        }
                        dtB = Convert.ToDateTime(lst[j].D_P_END_TIME).AddHours(Convert.ToDouble(lst[j].N_PRODUCE_TIME));
                        break;
                    }
                }
                #endregion
                //}

            }




            return lst;
        }
        #endregion

        #region 标记钢坯是否有订单

        #endregion

        #region 下达浇次计划

        /// <summary>
        /// 下发浇次计划
        /// </summary>
        /// <param name="c_id">浇次计划主键</param>
        /// <param name="max_sort">当前浇次排产时炉次计划最大排序号</param>
        /// <returns>当前浇次排产结束后的炉次计划最大序号</returns>
        public static int Down_Jc_Plan(string c_id, int max_sort)
        {
            //获取浇次计划
            Mod_TPP_LGPC_LSB mod_jc_ls = bll_jc.GetModel(c_id);
            Mod_TSP_CAST_PLAN mod_jc = CopyObject.Mapper<Mod_TSP_CAST_PLAN, Mod_TPP_LGPC_LSB>(mod_jc_ls);
            //获取当前炉次计划最大序号
            List<Mod_TPP_LGPC_LCLSB> lst_lc = bll_lc.GetModelListByJcID(c_id);
            if (lst_lc.Count > 0)
            {
                for (int i = 0; i < lst_lc.Count; i++)
                {
                    Mod_TSP_PLAN_SMS mod_sms = CopyObject.Mapper<Mod_TSP_PLAN_SMS, Mod_TPP_LGPC_LCLSB>(lst_lc[i]);
                    mod_sms.N_SORT = max_sort + 1;//
                    max_sort = max_sort + 1;
                    bll_plan_sms.Add(mod_sms);//插入炉次计划表
                    bll_lc.Delete(lst_lc[i].C_ID);//将临时炉次计划删除
                }
                bll_cast_plan.Add(mod_jc);//将临时浇次计划插入浇次计划表
                bll_jc.Delete(c_id);//删除临时浇次计划表
            }
            return max_sort;

        }



        #endregion
        #endregion

        #region 销售订单排产

        /// <summary>
        /// 销售订单排产
        /// </summary>
        /// <param name="C_ID">订单主键</param>
        /// <param name="n_down_wgt">排产量</param>
        /// <returns></returns>
        public static bool DownOrder(string C_ID, decimal n_down_wgt)
        {
            Mod_TMO_ORDER mod_order = bll_order.GetModel(C_ID);
            if (mod_order.N_TYPE==10)
            {
                WritePlanLog("销售订单排产", "头尾炉订单下达！", mod_order.C_ORDER_NO, mod_order.C_ID);
            }
            else
            {
                if (mod_order.N_STATUS != 2)
                {
                    WritePlanLog("销售订单排产", "订单合同状态未生效，排产失败！", mod_order.C_ORDER_NO, mod_order.C_ID);
                    return false;
                }
                if (mod_order.C_SFPJ != "Y")
                {
                    WritePlanLog("销售订单排产", "订单未成功评价，排产失败！" + n_down_wgt.ToString(), mod_order.C_ORDER_NO, mod_order.C_ID);
                    return false;
                }
                if (mod_order.N_WGT - mod_order.N_PROD_WGT - mod_order.N_ROLL_PROD_WGT - n_down_wgt < 0)
                {
                    WritePlanLog("销售订单排产", "排产量超出可生产计划量，排产失败！" + n_down_wgt.ToString(), mod_order.C_ORDER_NO, mod_order.C_ID);
                    return false;
                }

                if (mod_order.C_MATRL_CODE_SLAB.Trim() == "")
                {
                    WritePlanLog("销售订单排产", "没有匹配到连铸坯物料信息，排产失败！" + n_down_wgt.ToString(), mod_order.C_ORDER_NO, mod_order.C_ID);
                    return false;
                }
            }
            
            mod_order.N_ROLL_PROD_WGT = mod_order.N_ROLL_PROD_WGT + n_down_wgt;//更新订单排产量
            mod_order.C_SMS_PROD_EMP_ID = RV.UI.UserInfo.userID;//订单确认人
            mod_order.D_SC_MOD_DT = RV.UI.ServerTime.timeNow();
            bll_order.Update(mod_order);
            #region 订单排产
            Mod_TRP_PLAN_ROLL mod = new Mod_TRP_PLAN_ROLL();
            mod.C_ID = System.Guid.NewGuid().ToString();
            mod.C_EMP_ID = RV.UI.UserInfo.UserID;
            mod.D_MOD_DT = RV.UI.ServerTime.timeNow();
            mod.C_INITIALIZE_ITEM_ID = mod_order.C_ID;
            mod.C_ORDER_NO = mod_order.C_ORDER_NO;
            mod.N_WGT = n_down_wgt;
            mod.C_MAT_CODE = mod_order.C_MAT_CODE;
            mod.C_MAT_NAME = mod_order.C_MAT_NAME;
            mod.C_TECH_PROT = mod_order.C_TECH_PROT;
            mod.C_SPEC = mod_order.C_SPEC;
            mod.C_STL_GRD = mod_order.C_STL_GRD;
            mod.C_STD_CODE = mod_order.C_STD_CODE;
            mod.N_USER_LEV = mod_order.N_USER_LEV;
            //mod.N_STL_GRD_LEV = mod_order.C_LEV;
            //mod.N_ORDER_LEV = mod_order.C_ORDER_LEV;
           
            mod.D_NEED_DT = mod_order.D_NEED_DT;
            mod.D_DELIVERY_DT = mod_order.D_DELIVERY_DT;
            mod.D_DT = mod_order.D_PCTBTS;//订单提报日期
            mod.C_LINE_DESC = mod_order.C_ROLL_DESC;
            mod.C_LINE_CODE = mod_order.C_ROLL_CODE;
            mod.N_SORT = mod_order.N_SORT;
            mod.C_CUST_NO = mod_order.C_CUST_NO;
            mod.C_CUST_NAME = mod_order.C_CUST_NAME;
            mod.C_SALE_CHANNEL = mod_order.C_SALE_CHANNEL;
            mod.C_PACK = mod_order.C_PACK;
            mod.C_DESIGN_NO = mod_order.C_DESIGN_NO;
            mod.C_STA_ID = mod_order.C_LINE_NO;
            mod.N_MACH_WGT = mod_order.N_MACH_WGT;
            mod.C_FREE_TERM = mod_order.C_FREE1;
            mod.C_FREE_TERM2 = mod_order.C_FREE2;
            mod.C_AREA = mod_order.C_AREA;
            mod.C_PCLX = mod_order.C_PCLX;
            mod.C_SFHL = mod_order.C_HL;
            mod.C_SFHL_D = mod_order.C_DFP_HL;
            mod.C_SFKP = mod_order.C_KP;
            mod.C_SFXM = mod_order.C_XM;
            mod.C_MATRL_CODE_SLAB = mod_order.C_MATRL_CODE_SLAB;
            mod.C_MATRL_NAME_SLAB = mod_order.C_MATRL_NAME_SLAB;
            mod.C_SLAB_SIZE = mod_order.C_SLAB_SIZE;
            mod.N_SLAB_LENGTH = mod_order.N_SLAB_LENGTH;
            mod.N_SLAB_PW = mod_order.N_SLAB_PW;
            mod.C_ROUTE = mod_order.C_ROUTE;
            mod.N_DIAMETER = mod_order.N_DIAMETER;
            mod.C_XM_YQ = mod_order.C_XM_YQ;
            mod.N_JRL_WD = mod_order.N_JRL_WD;
            mod.N_JRL_SJ = mod_order.N_JRL_SJ;
            mod.C_STL_GRD_SLAB = mod_order.C_STL_GRD_SLAB;
            mod.C_STD_CODE_SLAB = mod_order.C_STD_CODE_SLAB;
            mod.C_MATRL_CODE_KP = mod_order.C_MATRL_CODE_KP;
            mod.C_MATRL_NAME_KP = mod_order.C_MATRL_NAME_KP;
            mod.C_KP_SIZE = mod_order.C_KP_SIZE;
            mod.N_KP_LENGTH = mod_order.N_KP_LENGTH;
            mod.N_KP_PW = mod_order.N_KP_PW;
            mod.N_GROUP = mod_order.N_GROUP;
            mod.C_XC = mod_order.C_XC;
            mod.C_SL = mod_order.C_SL;
            mod.C_WL = mod_order.C_WL;
            mod.N_MACH_WGT_CCM = mod_order.N_MACH_WGT_CCM;
            mod.N_ZJCLS = mod_order.N_ZJCLS;
            mod.C_BY1 = mod_order.C_BY1;//炼钢自由项1
            mod.C_BY2 = mod_order.C_BY2;//炼钢自由项2
           // mod.C_BY3 = mod_order.C_BY3;
            mod.C_BY4 = mod_order.C_BY4;
            mod.C_BY5 = mod_order.C_BY5;
            mod.C_LGJH = mod_order.C_LGJH;
            mod.C_ZL_ID = mod_order.C_ZL_ID;
            mod.C_LF_ID = mod_order.C_LF_ID;
            mod.C_RH_ID = mod_order.C_RH_ID;
            mod.N_SLAB_WIDTH = mod_order.N_SLAB_WIDTH;
            mod.N_SLAB_THICK = mod_order.N_SLAB_THICK;
            mod.C_DFP_RZ = mod_order.C_DFP_RZ;
            mod.C_RZP_RZ = mod_order.C_RZP_RZ;
            mod.C_DFP_YQ = mod_order.C_DFP_YQ;
            mod.C_RZP_YQ = mod_order.C_RZP_YQ;
            mod.N_KPJRL_WD = mod_order.N_KPJRL_WD;
            mod.N_KPJRL_SJ = mod_order.N_KPJRL_SJ;
            mod.N_TSL = mod_order.N_TSL;
            mod.C_CCM_CODE = mod_order.C_CCM_CODE;
            mod.C_CCM_DESC = mod_order.C_CCM_DESC;
            mod.C_TL = mod_order.C_TL;
            mod.N_ZJCLS_MIN = mod_order.N_ZJCLS_MIN;
            mod.N_ZJCLS_MAX = mod_order.N_ZJCLS_MAX;
            mod.C_STL_GRD_TYPE = mod_order.C_STL_GRD_TYPE;
            mod.C_PROD_NAME = mod_order.C_PROD_NAME;
            mod.C_PROD_KIND = mod_order.C_PROD_KIND;
            mod.N_TYPE = mod_order.N_TYPE;
            mod.C_RH = mod_order.C_RH;
            mod.C_DFP_HL = mod_order.C_DFP_HL;
            mod.C_HL = mod_order.C_HL;
            mod.C_XM = mod_order.C_XM;
            mod.C_CCM_ID = mod_order.C_CCM_NO;
            mod.N_HL_TIME = mod_order.N_HL_TIME;
            mod.N_DFP_HL_TIME = mod_order.N_DFP_HL_TIME;
            mod.C_LF = mod_order.C_LF;
            mod.C_KP = mod_order.C_KP;
            mod.C_STL_GRD_CLASS = mod_order.C_STL_GRD_CLASS;
            mod.C_PRO_USE = mod_order.C_PRO_USE;
            mod.C_CUST_SQ = mod_order.C_CUST_SQ;
            mod.C_TRANSMODE = mod_order.C_TRANSMODE;
            mod.C_REMARK1 = mod_order.C_REMARK1;
            mod.C_REMARK2 = mod_order.C_REMARK2;
            mod.C_REMARK3 = mod_order.C_REMARK3;
            mod.C_REMARK4 = mod_order.C_REMARK4;
            mod.C_REMARK5 = mod_order.C_REMARK5;
            if (mod_order.N_TYPE==10)
            {
                mod.N_TYPE = 6;
                mod.N_STATUS = 6;
            }
            bll_trp_plan.Add(mod);
            #endregion

            WritePlanLog("销售订单排产", "销售订单排产，排产量：" + n_down_wgt.ToString(), mod_order.C_ORDER_NO, mod_order.C_ID);

            return true;

        }

        #endregion

        #region 将未下发调度的轧钢计划撤回销售计划
        /// <summary>
        /// 将已下发的轧钢计划撤回
        /// </summary>
        /// <param name="C_ID">轧钢计划主键trp_plan_roll</param>
        /// <returns>撤回结果</returns>
        public static bool CancleZGPlan(string C_ID)
        {
            Mod_TRP_PLAN_ROLL mod = bll_trp_plan.GetModel(C_ID);
            if (mod.N_STATUS > 0)//订单状态：0未下发，1已下发，2已完成，3已关闭，5已排产完，6计划排序完成
            {
                return false;
            }
            else
            {
                bll_trp_plan.Delete(C_ID);
                string orderid = mod.C_INITIALIZE_ITEM_ID;//订单主键
                Mod_TMO_ORDER mod_order = bll_order.GetModel(orderid);
                mod_order.N_ROLL_PROD_WGT = mod_order.N_ROLL_PROD_WGT - Convert.ToDecimal(mod.N_WGT);
                bll_order.Update(mod_order);
                WritePlanLog("轧钢计划撤回", "轧钢计划撤回，撤回量：" + mod.N_WGT.ToString(), mod_order.C_ORDER_NO, mod_order.C_ID);
                return true;
            }
        }
        #endregion

        #region 将未下发调度的轧钢计划撤回销售计划
        /// <summary>
        /// 将已下发的生产计划撤回
        /// </summary>
        /// <param name="C_ID">订单表主键</param>
        /// <returns>撤回结果</returns>
        public static bool CancleOrder(string C_ID)
        {
            try
            {
                decimal n_yx_wgt = bll_trp_plan.GetYPwgt(C_ID);
                Mod_TMO_ORDER mod_order = bll_order.GetModel(C_ID);
                if (n_yx_wgt > 0)//订单状态：0未下发，1已下发，2已完成，3已关闭，5已排产完，6计划排序完成
                {
                    return false;
                }
                else
                {
                    bll_trp_plan.DeleteByOrderNo(C_ID);
                   
                    mod_order.N_ROLL_PROD_WGT = 0;
                    mod_order.D_SC_MOD_DT = RV.UI.ServerTime.timeNow();
                    bll_order.Update(mod_order);
                    WritePlanLog("轧钢计划撤回", "生产计划撤回，订单号：" + mod_order.C_ORDER_NO, mod_order.C_ORDER_NO, mod_order.C_ID);
                    return true;
                }
            }
            catch (Exception)
            {

                return false;
            }

        }
        #endregion
        
        #region 撤回已下发的炼钢计划，待完善
        /// <summary>
        /// 将已下发的炼钢钢计划撤回
        /// </summary>
        /// <param name="C_ID">轧钢计划主键trp_plan_roll</param>
        /// <returns>撤回结果</returns>
        public static bool CancleLGPlan(string C_ID)
        {
            Mod_TRP_PLAN_ROLL mod = bll_trp_plan.GetModel(C_ID);
            if (mod.N_STATUS > 0)//订单状态：0未下发，1已下发，2已完成，3已关闭，5已排产完，6计划排序完成
            {
                return false;
            }
            else
            {
                string c_stl_grd = mod.C_STL_GRD_SLAB;//钢坯钢种
                string c_std_code = mod.C_STD_CODE_SLAB;//钢坯标准
                string c_matrl_no = mod.C_MATRL_CODE_SLAB;//钢坯物料编码

                decimal slab_wgt = 0;//当前钢坯剩余总量
                decimal kc_slab = 0;//当前钢坯库存量
                decimal sms_wgt = 0;//当前连铸未完成量

                return true;


            }

        }
        #endregion

        #region 撤回连铸所有未下调度的炉次计划和浇次计划，连铸主键为空时撤回所有未下调度的计划
        /// <summary>
        /// 撤回所有未排产的浇次计划
        /// </summary>
        /// <param name="C_CCM_ID">连铸机主键</param>
        public static void DeleteAllLG(string C_CCM_ID)
        {
            List<Mod_TSP_CAST_PLAN> lstjc = bll_cast_plan.GetModelList(C_CCM_ID, 1,"");
            if (lstjc.Count > 0)
            {
                for (int i = 0; i < lstjc.Count; i++)
                {
                    List<Mod_TSP_PLAN_SMS> lstlc = bll_sms_plan.GetModelListByJcID(lstjc[i].C_ID).Where(a => a.N_CREAT_PLAN == 1).ToList();
                    for (int j = 0; j < lstlc.Count; j++)
                    {
                        bll_sms_plan.Delete(lstlc[j].C_ID);
                    }
                    if (bll_sms_plan.GetModelListByJcID(lstjc[i].C_ID).Where(a => a.N_CREAT_PLAN > 1).ToList().Count == 0)
                    {
                        bool res = bll_cast_plan.Delete(lstjc[i].C_ID);
                    }
                    else
                    {
                        lstjc[i].N_ZJCLS = bll_sms_plan.GetModelListByJcID(lstjc[i].C_ID).Where(a => a.N_CREAT_PLAN > 1).ToList().Count;
                        bll_cast_plan.Update(lstjc[i]);
                    }

                }
            }
        }
        #endregion

        #region 根据已排产的订单生产炉次计划
        /// <summary>
        /// 在现有的浇次计划上添加炉次计划
        /// </summary>
        /// <param name="C_STL_GRD">钢坯钢种</param>
        /// <param name="C_STD_CODE">钢坯执行标准</param>
        /// <param name="C_BY1">钢坯自由项1</param>
        /// <param name="C_BY2">钢坯自由项2</param>
        /// <param name="C_MATRL_CODE_SLAB">钢坯物料编码</param>
        /// <param name="C_JC_ID">浇次号</param>
        /// <param name="N_LS">炉数</param>
        /// <returns>添加结果</returns>
        public static string AddLCJH(string C_STL_GRD, string C_STD_CODE,string C_BY1,string C_BY2, string C_MATRL_CODE_SLAB, string C_JC_ID, int N_LS)
        {
            if (N_LS <= 0)
            {
                return "请输入正确的炉数！";
            }
            //查找是否有订单
            DataTable dt = bll_trp_plan.GetOrderLCInfo(C_STL_GRD, C_STD_CODE, C_BY1,  C_BY2, C_MATRL_CODE_SLAB);
            if (dt.Rows.Count > 0)
            {

                Mod_TSP_CAST_PLAN modjc = bll_cast_plan.GetModel(C_JC_ID);
                //获取钢坯自由项信息（如果订单材和坯的钢种执行标准一致，用订单的自由项信息）
                
                string C_FREE_TERM = dt.Rows[0]["C_FREE_TERM"].ToString();//自由项1
                string C_FREE_TERM2 = dt.Rows[0]["C_FREE_TERM2"].ToString();//自由项2
               
                string C_ID = dt.Rows[0]["C_ID"].ToString();
                string C_INITIALIZE_ITEM_ID = dt.Rows[0]["C_INITIALIZE_ITEM_ID"].ToString();
                string C_MATRL_NAME_SLAB = dt.Rows[0]["C_MATRL_NAME_SLAB"].ToString();//连铸坯物料名称
                string N_SLAB_PW = dt.Rows[0]["N_SLAB_PW"].ToString();//理论单重

                Mod_TRP_PLAN_ROLL mod_order = bll_trp_plan.GetModel(C_ID);//获取原始销售订单信息
                #region 添加新增的炉次计划
                Mod_TSP_PLAN_SMS mod = new Mod_TSP_PLAN_SMS();
                mod.C_ORDER_NO = mod_order.C_INITIALIZE_ITEM_ID;
                mod.C_DESIGN_NO = mod_order.C_DESIGN_NO;
                mod.C_ROUTE = mod_order.C_ROUTE;
                mod.N_SLAB_WGT = modjc.N_MLZL;
                mod.C_CCM_ID = modjc.C_CCM_ID;
                mod.C_CCM_DESC = modjc.C_CCM_CODE;
                mod.C_PROD_NAME = mod_order.C_PROD_NAME;
                mod.C_STL_GRD_TYPE = mod_order.C_STL_GRD_TYPE;
                mod.C_PROD_KIND = mod_order.C_PROD_KIND;
                mod.C_PROD_NAME = mod.C_PROD_NAME;

                mod.C_STL_GRD = C_STL_GRD;
                mod.C_MATRL_NO = mod_order.C_MATRL_CODE_SLAB;
                mod.C_MATRL_NAME = mod_order.C_MATRL_NAME_SLAB;
                mod.C_SLAB_SIZE = mod_order.C_SLAB_SIZE;
                mod.C_SLAB_LENGTH = mod_order.N_SLAB_LENGTH.ToString();
                mod.C_STATE = "2";
                mod.C_STD_CODE = C_STD_CODE;
                mod.C_EMP_ID = RV.UI.UserInfo.userID;
                mod.N_CREAT_PLAN = 1;
                Mod_TPB_SCLX modlx = bll_lx.GetModel(mod.C_CCM_ID);
                mod.C_ZL_ID = modlx.C_ZL;
                if (mod.C_ROUTE.Contains("LF"))
                {
                    mod.C_LF_ID = modlx.C_LF;
                }
                else
                {
                    mod.C_LF_ID = "";
                }
                if (mod.C_ROUTE.Contains("RH"))
                {
                    mod.C_RH_ID = modlx.C_RH;
                }
                else
                {
                    mod.C_RH_ID = "";
                }
                if (mod.C_CCM_DESC.Contains("5"))
                {
                    mod.C_QUA = "18";
                }
                else
                {
                    mod.C_QUA = "20";
                }
                mod.C_BY1 = mod_order.C_FREE_TERM;
                mod.C_BY2 = mod_order.C_FREE_TERM2;
                mod.C_RH = mod_order.C_RH;
                mod.C_DFP_HL = mod_order.C_DFP_HL;
                mod.C_HL = mod_order.C_HL;
                mod.C_XM = mod_order.C_XM;
                mod.N_SLAB_PW = mod_order.N_SLAB_PW;
                mod.C_MATRL_CODE_KP = mod_order.C_MATRL_CODE_KP;
                mod.C_MATRL_NAME_KP = mod_order.C_MATRL_NAME_KP;
                mod.C_KP_SIZE = mod_order.C_KP_SIZE;
                mod.N_KP_LENGTH = mod_order.N_KP_LENGTH;
                mod.N_KP_PW = mod_order.N_KP_PW;
                mod.N_USE_WGT = modjc.N_MLZL;
                mod.C_DFP_RZ = mod_order.C_DFP_RZ;
                mod.C_RZP_RZ = mod_order.C_RZP_RZ;
                mod.C_TL = mod_order.C_TL;
                mod.N_JSCN = mod_order.N_MACH_WGT_CCM == null ? 88 : mod_order.N_MACH_WGT_CCM;
                mod.C_FREE1 = C_FREE_TERM;
                mod.C_FREE2 = C_FREE_TERM2;
                mod.C_FK = C_JC_ID;
                mod.N_GROUP = modjc.N_GROUP;
                mod.N_ZJCLS = mod_order.N_ZJCLS;
                mod.C_SL = mod_order.C_SL;
                mod.C_SLAB_TYPE = mod_order.C_BY4 == "0" ? "碳钢" : "不锈钢";
                mod.N_JC_SORT = modjc.N_SORT;
               
                #endregion

                List<Mod_TSP_PLAN_SMS> lstlc = bll_plan_sms.GetModelListByJcID(C_JC_ID);
                for (int i = 0; i < N_LS; i++)
                {
                    mod.C_ID = System.Guid.NewGuid().ToString();
                    mod.N_SORT = lstlc.Max(a=>a.N_SORT)+1+i;
                    mod.D_MOD_DT = RV.UI.ServerTime.timeNow();
                    bll_plan_sms.Add(mod);
                    
                }

                return "炉次计划添加成功！";


            }
            else
            {
                return "没有获取到该炉次计划对应的订单！";
            }




        }

        static private Bll_TPP_LGPC_LSB bll_lsb = new Bll_TPP_LGPC_LSB();
        // static private bll_tpp bll_tpp_cast = new Bll_TPP_CAST_PLAN();
        /// <summary>
        /// 在现有的浇次计划上添加炉次计划
        /// </summary>
        /// <param name="C_STL_GRD">钢种</param>
        /// <param name="C_STD_CODE">执行标准</param>
        /// <param name="C_JC_ID">浇次号</param>
        /// <param name="N_LS">炉数</param>
        /// <returns>添加结果</returns>
        public static string AddLCJHLSB(string C_STL_GRD, string C_STD_CODE,string C_BY1, string C_BY2, string C_MATRL_CODE_SLAB, string C_JC_ID, int N_LS)
        {
            if (N_LS <= 0)
            {
                return "请输入正确的炉数！";
            }
            //查找是否有订单
            DataTable dt = bll_trp_plan.GetOrderLCInfo(C_STL_GRD, C_STD_CODE, C_BY1,  C_BY2, C_MATRL_CODE_SLAB);
            if (dt.Rows.Count > 0)
            {

                Mod_TPP_LGPC_LSB modjc = bll_lsb.GetModel(C_JC_ID);
                //获取钢坯自由项信息（如果订单材和坯的钢种执行标准一致，用订单的自由项信息）

                string C_FREE_TERM = dt.Rows[0]["C_FREE_TERM"].ToString();//自由项1
                string C_FREE_TERM2 = dt.Rows[0]["C_FREE_TERM2"].ToString();//自由项2

                string C_ID = dt.Rows[0]["C_ID"].ToString();
                string C_INITIALIZE_ITEM_ID = dt.Rows[0]["C_INITIALIZE_ITEM_ID"].ToString();
                //string C_MATRL_CODE_SLAB = dt.Rows[0]["C_MATRL_CODE_SLAB"].ToString();//连铸坯物料编码
                string C_MATRL_NAME_SLAB = dt.Rows[0]["C_MATRL_NAME_SLAB"].ToString();//连铸坯物料名称
                string N_SLAB_PW = dt.Rows[0]["N_SLAB_PW"].ToString();//理论单中

                Mod_TRP_PLAN_ROLL mod_order = bll_trp_plan.GetModel(C_ID);//获取原始销售订单信息
                #region 添加新增的炉次计划
                Mod_TPP_LGPC_LCLSB mod = new Mod_TPP_LGPC_LCLSB();
                mod.C_ORDER_NO = mod_order.C_INITIALIZE_ITEM_ID;
                mod.C_DESIGN_NO = mod_order.C_DESIGN_NO;
                mod.C_ROUTE = mod_order.C_ROUTE;
                mod.N_SLAB_WGT = modjc.N_MLZL;
                mod.C_CCM_ID = modjc.C_CCM_ID;
                mod.C_CCM_DESC = modjc.C_CCM_CODE;
                mod.C_PROD_NAME = mod_order.C_PROD_NAME;
                mod.C_STL_GRD_TYPE = mod_order.C_STL_GRD_TYPE;
                mod.C_PROD_KIND = mod_order.C_PROD_KIND;
                mod.C_PROD_NAME = mod.C_PROD_NAME;

                mod.C_STL_GRD = C_STL_GRD;
                mod.C_MATRL_NO = mod_order.C_MATRL_CODE_SLAB;
                mod.C_MATRL_NAME = mod_order.C_MATRL_NAME_SLAB;
                mod.C_SLAB_SIZE = mod_order.C_SLAB_SIZE;
                mod.C_SLAB_LENGTH = mod_order.N_SLAB_LENGTH.ToString();
                mod.C_STATE = "2";
                mod.C_STD_CODE = C_STD_CODE;
                mod.D_P_START_TIME = null;
                mod.D_P_END_TIME = null;
                mod.C_EMP_ID = RV.UI.UserInfo.userID;
                mod.N_CREAT_PLAN = 1;
                Mod_TPB_SCLX modlx = bll_lx.GetModel(mod.C_CCM_ID);
                mod.C_ZL_ID = modlx.C_ZL;
                if (mod.C_ROUTE.Contains("LF"))
                {
                    mod.C_LF_ID = modlx.C_LF;
                }
                else
                {
                    mod.C_LF_ID = "";
                }
                if (mod.C_ROUTE.Contains("RH"))
                {
                    mod.C_RH_ID = modlx.C_RH;
                }
                else
                {
                    mod.C_RH_ID = "";
                }
                if (mod.C_CCM_DESC.Contains("5"))
                {
                    mod.C_QUA = "18";
                }
                else
                {
                    mod.C_QUA = "20";
                }
                mod.C_BY1 = mod_order.C_FREE_TERM;
                mod.C_BY1 = mod_order.C_FREE_TERM2;
                mod.C_RH = mod_order.C_RH;
                mod.C_DFP_HL = mod_order.C_DFP_HL;
                mod.C_HL = mod_order.C_HL;
                mod.C_XM = mod_order.C_XM;
                mod.N_SLAB_PW = mod_order.N_SLAB_PW;
                mod.C_MATRL_CODE_KP = mod_order.C_MATRL_CODE_KP;
                mod.C_MATRL_NAME_KP = mod_order.C_MATRL_NAME_KP;
                mod.C_KP_SIZE = mod_order.C_KP_SIZE;
                mod.N_KP_LENGTH = mod_order.N_KP_LENGTH;
                mod.N_KP_PW = mod_order.N_KP_PW;
                mod.N_USE_WGT = modjc.N_MLZL;
                mod.C_DFP_RZ = mod_order.C_DFP_RZ;
                mod.C_RZP_RZ = mod_order.C_RZP_RZ;
                mod.C_TL = mod_order.C_TL;
                mod.N_JSCN = mod_order.N_MACH_WGT_CCM == null ? 88 : mod_order.N_MACH_WGT_CCM;
                mod.C_FREE1 = C_FREE_TERM;
                mod.C_FREE2 = C_FREE_TERM2;
                mod.C_FK = C_JC_ID;
                mod.N_GROUP = modjc.N_GROUP;
                mod.N_ZJCLS = mod_order.N_ZJCLS;
                mod.C_SL = mod_order.C_SL;
                mod.C_SLAB_TYPE = mod_order.C_BY4 == "0" ? "碳钢" : "不锈钢";
                mod.N_JC_SORT = modjc.N_SORT;
                //mod.C_LF = mod_order.C_LF;
                //mod.C_KP= mod_order.C_KP;

                int N_SORT = bll_lclsb.MaxSortBy(C_JC_ID);
                #endregion
                for (int i = 0; i < N_LS; i++)
                {
                    mod.C_ID = System.Guid.NewGuid().ToString();
                    mod.N_SORT = N_SORT+i+1;
                    mod.D_MOD_DT = RV.UI.ServerTime.timeNow();
                    bll_lclsb.Add(mod);
                }

                return "炉次计划添加成功！";


            }
            else
            {
                return "没有获取到该炉次计划对应的订单！";
            }




        }


        /// <summary>
        /// 根据组号查询可生产的炼钢计划
        /// </summary>
        /// <param name="N_GROUP">组号</param>
        /// <param name="C_CCM_ID">连铸号</param>
        /// <param name="SFWC">是否完成</param>
        /// <returns>可生产的炼钢计划</returns>
        public static DataTable GetOrderiNFO(int N_GROUP, string C_CCM_ID, int SFWC, string D_DT_B, string D_DT_E)
        {
            return bll_trp_plan.GetOrderMatInfo(N_GROUP, C_CCM_ID, SFWC, D_DT_B, D_DT_E);

        }

        #endregion

        #region 炼钢自动排产生成浇次计划和炉次计划

        /// <summary>
        /// 根据计划自动生成炼钢浇次计划和炉次计划
        /// </summary>
        /// <param name="D_DT_B">排产订单开始时间</param>
        /// <param name="D_DT_E">排产订单结束时间</param>
        /// <param name="C_CCM_ID">连铸主键</param>
        /// <param name="C_IS_BXG">是否不锈钢</param>
        public static void Generation_Slab_Plan(string D_DT_B, string D_DT_E, string C_CCM_ID,string C_IS_BXG)
        {
            string C_SLAB_TYPE = C_IS_BXG == "0" ? "碳钢" : "不锈钢";

            #region 清空临时表数据


            bll_jc.ClearTable(C_CCM_ID, C_SLAB_TYPE);
            bll_lc.ClearTable(C_CCM_ID, C_SLAB_TYPE);

            #endregion
            DataTable dtByGroup = bll_trp_plan.GetSlabOrder(D_DT_B, D_DT_E, C_CCM_ID, C_IS_BXG);
            if (dtByGroup.Rows.Count > 0)
            {
                //将临时表数据清除

                for (int i = 0; i < dtByGroup.Rows.Count; i++)
                {
                    int N_GROUP = Convert.ToInt32(dtByGroup.Rows[i]["N_GROUP"].ToString());
                    if (N_GROUP==10)
                    {
                        N_GROUP = Convert.ToInt32(dtByGroup.Rows[i]["N_GROUP"].ToString());
                    }
                    int N_ZJCLS = Convert.ToInt32(dtByGroup.Rows[i]["N_ZJCLS"].ToString());
                    string strC_CCM_ID = dtByGroup.Rows[i]["C_CCM_ID"].ToString();
                    DataTable dt_Order = bll_trp_plan.GetSlabOrderInfo(D_DT_B, D_DT_E, strC_CCM_ID, N_GROUP, C_IS_BXG);
                    string c_jc_id = "";//生成的浇次主键
                    int N_ORDER_LS = 0;//当前组订单应排产炉数
                    if (dt_Order.Rows.Count > 0)
                    {
                        int DQJCS = 0;
                        string jcinfo = "";//浇次钢种信息
                        for (int j = 0; j < dt_Order.Rows.Count; j++)
                        {
                            #region 计划信息
                            decimal N_WGT = Convert.ToDecimal(dt_Order.Rows[j]["N_WGT"].ToString());//钢坯需求量
                            decimal N_PROD_WGT = Convert.ToDecimal(dt_Order.Rows[j]["N_PROD_WGT"].ToString());//订单完成量
                            string C_MATRL_CODE_SLAB = dt_Order.Rows[j]["C_MATRL_CODE_SLAB"].ToString();//连铸坯物料代码
                            string C_MATRL_NAME_SLAB = dt_Order.Rows[j]["C_MATRL_NAME_SLAB"].ToString();//连铸坯物料名称
                            string C_SLAB_SIZE = dt_Order.Rows[j]["C_SLAB_SIZE"].ToString();//连铸坯断面
                            string N_SLAB_LENGTH = dt_Order.Rows[j]["N_SLAB_LENGTH"].ToString();//连铸坯定尺
                            string N_SLAB_PW = dt_Order.Rows[j]["N_SLAB_PW"].ToString();//连铸坯理论单重
                            string C_ROUTE = dt_Order.Rows[j]["C_ROUTE"].ToString();//工艺路线
                            string C_STL_GRD_SLAB = dt_Order.Rows[j]["C_STL_GRD_SLAB"].ToString();//钢坯钢种
                            string C_STD_CODE_SLAB = dt_Order.Rows[j]["C_STD_CODE_SLAB"].ToString();//钢坯执行标准
                            string C_MATRL_CODE_KP = dt_Order.Rows[j]["C_MATRL_CODE_KP"].ToString();//热轧坯物料代码
                            string C_MATRL_NAME_KP = dt_Order.Rows[j]["C_MATRL_NAME_KP"].ToString();//热轧坯物料名称
                            string C_KP_SIZE = dt_Order.Rows[j]["C_KP_SIZE"].ToString();//热轧坯断面
                            string N_KP_LENGTH = dt_Order.Rows[j]["N_KP_LENGTH"].ToString();//热轧坯定尺
                            string N_KP_PW = dt_Order.Rows[j]["N_KP_PW"].ToString();//热轧坯理论单重
                            string C_SL = dt_Order.Rows[j]["C_SL"].ToString();//首炉需排钢种
                            string C_WL = dt_Order.Rows[j]["C_WL"].ToString();//尾炉需排钢种
                            string C_BY1 = dt_Order.Rows[j]["C_BY1"].ToString();//钢坯自由项1
                            string C_BY2 = dt_Order.Rows[j]["C_BY2"].ToString();//钢坯自由项2
                            string C_CCM_CODE = dt_Order.Rows[j]["C_CCM_CODE"].ToString();//连铸机代码
                            //string C_CCM_ID = dt_Order.Rows[j]["C_CCM_ID"].ToString();//连铸机代码
                            string C_CCM_DESC = dt_Order.Rows[j]["C_CCM_DESC"].ToString();//连铸机描述
                            string C_STL_GRD_TYPE = dt_Order.Rows[j]["C_STL_GRD_TYPE"].ToString();//钢类
                            string C_PROD_NAME = dt_Order.Rows[j]["C_PROD_NAME"].ToString();//品名
                            string C_PROD_KIND = dt_Order.Rows[j]["C_PROD_KIND"].ToString();//品种
                            string N_TYPE = dt_Order.Rows[j]["N_TYPE"].ToString();//外销坯/自备坯
                            string C_BY4 = dt_Order.Rows[j]["C_BY4"].ToString();//是否不锈钢
                            #endregion
                            #region 计算排产数量
                            decimal n_wwc_wgt = 0;//炼钢计划未完成量
                            decimal n_slan_kc = 0;//钢坯现有量
                            decimal n_lclsb = 0;//已在临时表生成的计划量
                            decimal n_roll_left = 0;//之前计划剩余量
                            decimal n_mlzl = 0;//每炉重量
                            if (C_BY4 == "不锈钢")
                            {
                                n_wwc_wgt = bll_plan_sms.GetWWCJH(C_STL_GRD_SLAB, C_STD_CODE_SLAB, C_MATRL_CODE_SLAB);
                                n_slan_kc = bll_slab.GetSlabKC(C_STL_GRD_SLAB, C_STD_CODE_SLAB, C_MATRL_CODE_SLAB);
                                n_lclsb = bll_lclsb.GetWWCJH(C_STL_GRD_SLAB, C_STD_CODE_SLAB, C_MATRL_CODE_SLAB);
                                // n_roll_left = bll_trp_plan.GetLeftWgt(D_DT_B, C_STL_GRD_SLAB, C_STD_CODE_SLAB, C_MATRL_CODE_SLAB);
                                n_mlzl = 55;
                            }
                            else
                            {
                                n_wwc_wgt = bll_plan_sms.GetWWCJH(C_STL_GRD_SLAB, C_STD_CODE_SLAB, "");
                                n_slan_kc = bll_slab.GetSlabKC(C_STL_GRD_SLAB, C_STD_CODE_SLAB, "");
                                n_lclsb = bll_lclsb.GetWWCJH(C_STL_GRD_SLAB, C_STD_CODE_SLAB, "");
                                //n_roll_left = bll_trp_plan.GetLeftWgt(D_DT_B, C_STL_GRD_SLAB, C_STD_CODE_SLAB, "");
                                if (C_CCM_DESC.Contains("5#"))
                                {
                                    n_mlzl = 76;
                                }
                                else
                                {
                                    n_mlzl = 46;
                                }
                            }

                            //当前计划应排重量
                            decimal n_yp_wgt = N_WGT - N_PROD_WGT - n_wwc_wgt - n_slan_kc - n_lclsb;
                            //decimal n_yp_wgt = N_WGT;  
                            if (n_yp_wgt <= 0)
                            {
                                n_yp_wgt = 0;
                            }
                            int N_THIS_NUM = (int)Math.Ceiling(n_yp_wgt / n_mlzl);//当前计划应排产炉数
                            #endregion
                            Mod_TPP_LGPC_LCLSB mod_lc = new Mod_TPP_LGPC_LCLSB();//炉次计划临时表
                            if (N_THIS_NUM > 0)
                            {
                                for (int k = 0; k < N_THIS_NUM; k++)
                                {
                                    N_ORDER_LS = N_ORDER_LS + 1;//当前组已排炉数
                                    if (N_ORDER_LS > N_ZJCLS)
                                    {
                                        N_ORDER_LS = 1;
                                    }
                                    Mod_TPP_LGPC_LSB modjc = new Mod_TPP_LGPC_LSB();
                                    if (N_ORDER_LS == 1)
                                    {
                                        //添加浇次计划
                                        #region 添加浇次计划
                                        modjc.C_ID = System.Guid.NewGuid().ToString();
                                        c_jc_id = modjc.C_ID;
                                        modjc.C_CCM_ID = strC_CCM_ID;
                                        modjc.C_CCM_CODE = C_CCM_CODE;
                                        modjc.N_ZJCLS = N_ZJCLS;
                                        modjc.N_ZJCLZL = N_ZJCLS * n_mlzl;
                                        modjc.N_GROUP = N_GROUP;
                                        modjc.N_PRODUCE_TIME = 0;
                                        modjc.D_ZZ_START_TIME = Convert.ToDateTime(D_DT_B);
                                        modjc.D_ZZ_END_TIME = Convert.ToDateTime(D_DT_E);
                                        modjc.C_SLAB_TYPE = C_BY4;
                                        #endregion
                                    }

                                    #region 添加炉次计划信息
                                    mod_lc.C_ID = System.Guid.NewGuid().ToString();// 主键
                                    mod_lc.C_FK = c_jc_id;//浇次临时表主键                  
                                    mod_lc.N_SLAB_WGT = n_mlzl;//坯料重量
                                    mod_lc.C_CCM_ID = strC_CCM_ID;//连铸机主键
                                    mod_lc.C_CCM_DESC = C_CCM_CODE; //连铸机描述
                                    mod_lc.C_PROD_NAME = C_PROD_NAME;//类别
                                    mod_lc.C_STL_GRD = C_STL_GRD_SLAB;//钢种
                                    mod_lc.C_MATRL_NO = C_MATRL_CODE_SLAB; //物料编码
                                    mod_lc.C_MATRL_NAME = C_MATRL_NAME_SLAB;//物料名称
                                    mod_lc.C_SLAB_SIZE = C_SLAB_SIZE; //连铸钢坯断面
                                    mod_lc.C_SLAB_LENGTH = N_SLAB_LENGTH;//坯料长度
                                    mod_lc.C_STD_CODE = C_STD_CODE_SLAB; // 执行标准
                                    mod_lc.N_CREAT_PLAN = 1; //  1
                                    mod_lc.N_CREAT_ZG_PLAN = 0; //0
                                    mod_lc.N_PRODUCE_TIME = 0; // 0
                                    mod_lc.N_STATUS = 1;   //使用状态   1 - 可用；0 - 停用
                                    mod_lc.C_EMP_ID = RV.UI.UserInfo.userID; //操作人
                                    mod_lc.D_MOD_DT = RV.UI.ServerTime.timeNow(); //操作时间
                                    mod_lc.C_SLAB_TYPE = C_BY4;
                                    #endregion
                                    #region 匹配该炉次计划对应的订单
                                    DataTable dt = bll_trp_plan.GetPlanInfo(D_DT_B, D_DT_E, C_STL_GRD_SLAB, C_STD_CODE_SLAB, C_MATRL_CODE_SLAB, C_MATRL_CODE_KP, strC_CCM_ID, N_GROUP);
                                    if (dt.Rows.Count > 0)
                                    {
                                        Mod_TRP_PLAN_ROLL modtrp = bll_trp_plan.DataRowToModel(dt.Rows[0]);
                                        mod_lc.C_STATE = "0"; //0有计划1非计划
                                        #region 添加炉次计划
                                        mod_lc.N_PROD_TIME = mod_lc.N_SLAB_WGT / modtrp.N_MACH_WGT_CCM; //理论生产需时h
                                        #region 工艺路线
                                        mod_lc.C_ORDER_NO = modtrp.C_INITIALIZE_ITEM_ID; //订单号（计划订单）
                                        mod_lc.C_DESIGN_NO = modtrp.C_DESIGN_NO; //质量设计号
                                        mod_lc.C_ZL_ID = modtrp.C_ZL_ID; //转炉主键
                                        mod_lc.C_LF_ID = modtrp.C_LF_ID;//精炼主键
                                        mod_lc.C_RH_ID = modtrp.C_RH_ID; //真空主键
                                                                         // mod_lc.C_LGJH = ""; //炼钢记号
                                        #endregion
                                        int qua = 0;
                                        if (mod_lc.C_CCM_DESC.Contains("5#"))
                                        {
                                            qua = 22;

                                        }
                                        else if (mod_lc.C_CCM_DESC.Contains("7#"))
                                        {
                                            qua = 12;

                                        }
                                        else if (mod_lc.C_CCM_DESC.Contains("6#"))
                                        {
                                            if (modtrp.C_BY4 == "1")
                                            {
                                                qua = 36;
                                            }
                                            else
                                            {
                                                qua = 24;
                                            }

                                        }
                                        else
                                        {
                                            qua = 24;
                                        }
                                        mod_lc.C_QUA = qua.ToString(); //支数
                                        mod_lc.C_BY1 = modtrp.C_FREE_TERM; //线材自由项1
                                        mod_lc.C_BY2 = modtrp.C_FREE_TERM2; //线材自由项2
                                       // mod_lc.C_BY3 = modtrp.C_BY3; ; //备用3钢种颜色
                                        mod_lc.C_RH = modtrp.C_RH; //是否过真空
                                        mod_lc.C_DFP_HL = modtrp.C_DFP_HL; //大方坯连铸坯是否缓冷
                                        mod_lc.C_HL = modtrp.C_HL; //小方坯或热轧坯是否缓冷
                                        mod_lc.C_XM = modtrp.C_XM; //是否修磨
                                        mod_lc.C_PLAN_ROLL = modtrp.C_LINE_DESC; //计划轧线
                                        mod_lc.N_DFP_HL_TIME = modtrp.N_DFP_HL_TIME; //大方坯缓冷时间
                                        mod_lc.N_HL_TIME = modtrp.N_HL_TIME; //缓冷时间
                                        mod_lc.C_ROUTE = modtrp.C_ROUTE;//工艺路线 O
                                        mod_lc.N_SLAB_PW = modtrp.N_SLAB_PW;  //连铸钢坯理论单重
                                        mod_lc.C_MATRL_CODE_KP = modtrp.C_MATRL_CODE_KP;// 开坯钢坯物料号
                                        mod_lc.C_MATRL_NAME_KP = modtrp.C_MATRL_NAME_KP;// 开坯钢坯物料名称
                                        mod_lc.C_KP_SIZE = modtrp.C_KP_SIZE; // 开坯钢坯断面
                                        mod_lc.N_KP_LENGTH = modtrp.N_KP_LENGTH;// 开坯钢坯定尺
                                        mod_lc.N_KP_PW = modtrp.N_KP_PW; //开坯钢坯理论单重
                                        mod_lc.N_USE_WGT = n_mlzl; // 可使用重量
                                        mod_lc.C_DFP_RZ = modtrp.C_DFP_RZ;   //大方坯能否热装
                                        mod_lc.C_RZP_RZ = modtrp.C_DFP_RZ;    //热轧坯能否热装
                                        mod_lc.C_DFP_YQ = modtrp.C_DFP_YQ;   // 大方坯缓冷要求
                                        mod_lc.C_RZP_YQ = modtrp.C_RZP_YQ;   // 热轧坯缓冷要求
                                        mod_lc.C_STL_GRD_TYPE = modtrp.C_STL_GRD_TYPE;// 钢种类别
                                        mod_lc.C_PROD_KIND = modtrp.C_PROD_KIND;// 品种
                                        mod_lc.C_TL = modtrp.C_TL;  // 是否脱硫
                                        mod_lc.N_JSCN = modtrp.N_MACH_WGT_CCM == 0 ? 88 : modtrp.N_MACH_WGT_CCM; //机时产能
                                        mod_lc.C_FREE2 = modtrp.C_BY2;// 自由项2
                                        mod_lc.N_GROUP = N_GROUP; //连铸排产时的分组号
                                        mod_lc.N_ZJCLS = modtrp.N_ZJCLS; //整浇次炉数
                                        mod_lc.C_SL = modtrp.C_SL;  //是否需要首炉过渡
                                        mod_lc.C_WL = modtrp.C_WL;  //  是否需要尾炉过渡
                                        mod_lc.C_FREE1 = modtrp.C_BY1; //自由项1
                                        mod_lc.N_SORT = N_ORDER_LS;  //生产排序
                                        #endregion
                                        bll_lc.Add(mod_lc);

                                    }
                                    #endregion

                                    if (N_ORDER_LS == 1)
                                    {
                                        modjc.N_JSCN = mod_lc.N_JSCN;
                                        modjc.C_BY1 = mod_lc.C_BY1;
                                        modjc.C_BY2 = mod_lc.C_BY2;
                                        //modjc.C_BY3 = mod_lc.C_BY3;
                                        modjc.C_RH = mod_lc.C_RH;
                                        modjc.N_MLZL = n_mlzl;
                                        modjc.C_DFP_HL = mod_lc.C_DFP_HL;
                                        modjc.C_HL = mod_lc.C_HL;
                                        modjc.C_XM = mod_lc.C_XM;
                                        modjc.N_ORDER_LS = N_ZJCLS;
                                        modjc.C_STD_CODE = mod_lc.C_STD_CODE;
                                        modjc.C_STL_GRD_TYPE = mod_lc.C_STL_GRD_TYPE;
                                        modjc.C_PROD_NAME = mod_lc.C_PROD_NAME;
                                        modjc.C_PROD_KIND = mod_lc.C_PROD_KIND;
                                        modjc.C_TL = mod_lc.C_TL;
                                        modjc.C_REMARK = C_STL_GRD_SLAB + "【" + C_STD_CODE_SLAB + "】" + "【" + N_THIS_NUM.ToString() + "】";
                                        bll_jc.Add(modjc);
                                        modjc.N_STATUS = 0;

                                    }
                                }

                            }
                            if (j == dt_Order.Rows.Count - 1 && N_ORDER_LS > 0)//增加非计划炉次计划
                            {
                                int left = N_ZJCLS - N_ORDER_LS;
                                if (left < 10)//添加的非浇次计划小于10炉的补上
                                {
                                    for (int g = 0; g < left; g++)
                                    {
                                        #region 原方法
                                        Mod_TPP_LGPC_LCLSB mod_jc2 = bll_lc.GetModelListByJcID(c_jc_id).OrderByDescending(a => a.N_SORT).ToList()[0];
                                        mod_jc2.C_ID = System.Guid.NewGuid().ToString();// 主键
                                        mod_jc2.C_STATE = "1"; //0有计划1非计划
                                        mod_jc2.N_SORT = N_ORDER_LS + g + 1;
                                        bll_lc.Add(mod_jc2);
                                        #endregion
                                        //增加非计划炉次
                                        //Mod_TPP_LGPC_LCLSB mod_jc2 = GetZBJH(D_DT_B, D_DT_E, N_GROUP, C_CCM_ID);
                                        //mod_jc2.C_ID = System.Guid.NewGuid().ToString();// 主键
                                        //mod_jc2.C_FK = c_jc_id;
                                        //mod_jc2.C_STATE = "1"; //0有计划1非计划
                                        //mod_jc2.N_SORT = N_ORDER_LS + g + 1;
                                        //bll_lc.Add(mod_jc2);


                                    }
                                }
                            }


                        }
                    }
                }
            }
        }
        
        /// <summary>
        /// 根据计划自动生成炼钢浇次计划和炉次计划
        /// </summary>
        /// <param name="D_DT_B">排产订单开始时间</param>
        /// <param name="D_DT_E">排产订单结束时间</param>
        /// <param name="C_CCM_ID">连铸主键</param>
        /// <param name="C_IS_BXG">是否不锈钢</param>
        /// <param name="N_GROUP">分组号</param>
        public static void Generation_Slab_PlanByGroup(string D_DT_B, string D_DT_E, string C_CCM_ID, string C_IS_BXG,int N_GROUP)
        {
            string C_SLAB_TYPE = C_IS_BXG == "0" ? "碳钢" : "不锈钢";

            #region 清空临时表数据
            bll_jc.ClearTable(C_CCM_ID, C_SLAB_TYPE);
            bll_lc.ClearTable(C_CCM_ID, C_SLAB_TYPE);

            #endregion
            DataTable dtByGroup = bll_trp_plan.GetSlabOrder(D_DT_B, D_DT_E, C_CCM_ID, C_IS_BXG, N_GROUP);
            if (dtByGroup.Rows.Count > 0)
            {
                //将临时表数据清除

                for (int i = 0; i < dtByGroup.Rows.Count; i++)
                {
                    int N_ZJCLS = Convert.ToInt32(dtByGroup.Rows[i]["N_ZJCLS"].ToString());
                    string strC_CCM_ID = dtByGroup.Rows[i]["C_CCM_ID"].ToString();
                    DataTable dt_Order = bll_trp_plan.GetSlabOrderInfo(D_DT_B, D_DT_E, strC_CCM_ID, N_GROUP, C_IS_BXG);
                    string c_jc_id = "";//生成的浇次主键
                    int N_ORDER_LS = 0;//当前组订单应排产炉数
                    if (dt_Order.Rows.Count > 0)
                    {
                        int DQJCS = 0;
                        string jcinfo = "";//浇次钢种信息
                        for (int j = 0; j < dt_Order.Rows.Count; j++)
                        {
                            #region 计划信息
                            decimal N_WGT = Convert.ToDecimal(dt_Order.Rows[j]["N_WGT"].ToString());//钢坯需求量
                            decimal N_PROD_WGT = Convert.ToDecimal(dt_Order.Rows[j]["N_PROD_WGT"].ToString());//订单完成量
                            string C_MATRL_CODE_SLAB = dt_Order.Rows[j]["C_MATRL_CODE_SLAB"].ToString();//连铸坯物料代码
                            string C_MATRL_NAME_SLAB = dt_Order.Rows[j]["C_MATRL_NAME_SLAB"].ToString();//连铸坯物料名称
                            string C_SLAB_SIZE = dt_Order.Rows[j]["C_SLAB_SIZE"].ToString();//连铸坯断面
                            string N_SLAB_LENGTH = dt_Order.Rows[j]["N_SLAB_LENGTH"].ToString();//连铸坯定尺
                            string N_SLAB_PW = dt_Order.Rows[j]["N_SLAB_PW"].ToString();//连铸坯理论单重
                            string C_ROUTE = dt_Order.Rows[j]["C_ROUTE"].ToString();//工艺路线
                            string C_STL_GRD_SLAB = dt_Order.Rows[j]["C_STL_GRD_SLAB"].ToString();//钢坯钢种
                            string C_STD_CODE_SLAB = dt_Order.Rows[j]["C_STD_CODE_SLAB"].ToString();//钢坯执行标准
                            string C_MATRL_CODE_KP = dt_Order.Rows[j]["C_MATRL_CODE_KP"].ToString();//热轧坯物料代码
                            string C_MATRL_NAME_KP = dt_Order.Rows[j]["C_MATRL_NAME_KP"].ToString();//热轧坯物料名称
                            string C_KP_SIZE = dt_Order.Rows[j]["C_KP_SIZE"].ToString();//热轧坯断面
                            string N_KP_LENGTH = dt_Order.Rows[j]["N_KP_LENGTH"].ToString();//热轧坯定尺
                            string N_KP_PW = dt_Order.Rows[j]["N_KP_PW"].ToString();//热轧坯理论单重
                            string C_SL = dt_Order.Rows[j]["C_SL"].ToString();//首炉需排钢种
                            string C_WL = dt_Order.Rows[j]["C_WL"].ToString();//尾炉需排钢种
                            string C_BY1 = dt_Order.Rows[j]["C_BY1"].ToString();//钢坯自由项1
                            string C_BY2 = dt_Order.Rows[j]["C_BY2"].ToString();//钢坯自由项2
                            string C_CCM_CODE = dt_Order.Rows[j]["C_CCM_CODE"].ToString();//连铸机代码
                            //string C_CCM_ID = dt_Order.Rows[j]["C_CCM_ID"].ToString();//连铸机代码
                            string C_CCM_DESC = dt_Order.Rows[j]["C_CCM_DESC"].ToString();//连铸机描述
                            string C_STL_GRD_TYPE = dt_Order.Rows[j]["C_STL_GRD_TYPE"].ToString();//钢类
                            string C_PROD_NAME = dt_Order.Rows[j]["C_PROD_NAME"].ToString();//品名
                            string C_PROD_KIND = dt_Order.Rows[j]["C_PROD_KIND"].ToString();//品种
                            string N_TYPE = dt_Order.Rows[j]["N_TYPE"].ToString();//外销坯/自备坯
                            string C_BY4 = dt_Order.Rows[j]["C_BY4"].ToString();//是否不锈钢
                            #endregion
                            #region 计算排产数量
                            decimal n_wwc_wgt = 0;//炼钢计划未完成量
                            decimal n_slan_kc = 0;//钢坯现有量
                            decimal n_lclsb = 0;//已在临时表生成的计划量
                            decimal n_roll_left = 0;//之前计划剩余量
                            decimal n_mlzl = 0;//每炉重量
                            if (C_BY4 == "不锈钢")
                            {
                                n_wwc_wgt = bll_plan_sms.GetWWCJH(C_STL_GRD_SLAB, C_STD_CODE_SLAB, C_MATRL_CODE_SLAB);
                                n_slan_kc = bll_slab.GetSlabKC(C_STL_GRD_SLAB, C_STD_CODE_SLAB, C_MATRL_CODE_SLAB);
                                n_lclsb = bll_lclsb.GetWWCJH(C_STL_GRD_SLAB, C_STD_CODE_SLAB, C_MATRL_CODE_SLAB);
                                // n_roll_left = bll_trp_plan.GetLeftWgt(D_DT_B, C_STL_GRD_SLAB, C_STD_CODE_SLAB, C_MATRL_CODE_SLAB);
                                n_mlzl = 55;
                            }
                            else
                            {
                                n_wwc_wgt = bll_plan_sms.GetWWCJH(C_STL_GRD_SLAB, C_STD_CODE_SLAB, "");
                                n_slan_kc = bll_slab.GetSlabKC(C_STL_GRD_SLAB, C_STD_CODE_SLAB, "");
                                n_lclsb = bll_lclsb.GetWWCJH(C_STL_GRD_SLAB, C_STD_CODE_SLAB, "");
                                //n_roll_left = bll_trp_plan.GetLeftWgt(D_DT_B, C_STL_GRD_SLAB, C_STD_CODE_SLAB, "");
                                if (C_CCM_DESC.Contains("5#"))
                                {
                                    n_mlzl = 76;
                                }
                                else
                                {
                                    n_mlzl = 46;
                                }
                            }

                            //当前计划应排重量
                            decimal n_yp_wgt = N_WGT - N_PROD_WGT - n_wwc_wgt - n_slan_kc - n_lclsb;
                            //decimal n_yp_wgt = N_WGT;  
                            if (n_yp_wgt <= 0)
                            {
                                n_yp_wgt = 0;
                            }
                            int N_THIS_NUM = (int)Math.Ceiling(n_yp_wgt / n_mlzl);//当前计划应排产炉数
                            #endregion
                            Mod_TPP_LGPC_LCLSB mod_lc = new Mod_TPP_LGPC_LCLSB();//炉次计划临时表
                            if (N_THIS_NUM > 0)
                            {
                                for (int k = 0; k < N_THIS_NUM; k++)
                                {
                                    N_ORDER_LS = N_ORDER_LS + 1;//当前组已排炉数
                                    if (N_ORDER_LS > N_ZJCLS)
                                    {
                                        N_ORDER_LS = 1;
                                    }
                                    Mod_TPP_LGPC_LSB modjc = new Mod_TPP_LGPC_LSB();
                                    if (N_ORDER_LS == 1)
                                    {
                                        //添加浇次计划
                                        #region 添加浇次计划
                                        modjc.C_ID = System.Guid.NewGuid().ToString();
                                        c_jc_id = modjc.C_ID;
                                        modjc.C_CCM_ID = strC_CCM_ID;
                                        modjc.C_CCM_CODE = C_CCM_CODE;
                                        modjc.N_ZJCLS = N_ZJCLS;
                                        modjc.N_ZJCLZL = N_ZJCLS * n_mlzl;
                                        modjc.N_GROUP = N_GROUP;
                                        modjc.N_PRODUCE_TIME = 0;
                                        modjc.D_ZZ_START_TIME = Convert.ToDateTime(D_DT_B);
                                        modjc.D_ZZ_END_TIME = Convert.ToDateTime(D_DT_E);
                                        modjc.C_SLAB_TYPE = C_BY4;
                                        #endregion
                                    }

                                    #region 添加炉次计划信息
                                    mod_lc.C_ID = System.Guid.NewGuid().ToString();// 主键
                                    mod_lc.C_FK = c_jc_id;//浇次临时表主键                  
                                    mod_lc.N_SLAB_WGT = n_mlzl;//坯料重量
                                    mod_lc.C_CCM_ID = strC_CCM_ID;//连铸机主键
                                    mod_lc.C_CCM_DESC = C_CCM_CODE; //连铸机描述
                                    mod_lc.C_PROD_NAME = C_PROD_NAME;//类别
                                    mod_lc.C_STL_GRD = C_STL_GRD_SLAB;//钢种
                                    mod_lc.C_MATRL_NO = C_MATRL_CODE_SLAB; //物料编码
                                    mod_lc.C_MATRL_NAME = C_MATRL_NAME_SLAB;//物料名称
                                    mod_lc.C_SLAB_SIZE = C_SLAB_SIZE; //连铸钢坯断面
                                    mod_lc.C_SLAB_LENGTH = N_SLAB_LENGTH;//坯料长度
                                    mod_lc.C_STD_CODE = C_STD_CODE_SLAB; // 执行标准
                                    mod_lc.N_CREAT_PLAN = 1; //  1
                                    mod_lc.N_CREAT_ZG_PLAN = 0; //0
                                    mod_lc.N_PRODUCE_TIME = 0; // 0
                                    mod_lc.N_STATUS = 1;   //使用状态   1 - 可用；0 - 停用
                                    mod_lc.C_EMP_ID = RV.UI.UserInfo.userID; //操作人
                                    mod_lc.D_MOD_DT = RV.UI.ServerTime.timeNow(); //操作时间
                                    mod_lc.C_SLAB_TYPE = C_BY4;
                                    #endregion
                                    #region 匹配该炉次计划对应的订单
                                    DataTable dt = bll_trp_plan.GetPlanInfo(D_DT_B, D_DT_E, C_STL_GRD_SLAB, C_STD_CODE_SLAB, C_MATRL_CODE_SLAB, C_MATRL_CODE_KP, strC_CCM_ID, N_GROUP);
                                    if (dt.Rows.Count > 0)
                                    {
                                        Mod_TRP_PLAN_ROLL modtrp = bll_trp_plan.DataRowToModel(dt.Rows[0]);
                                        mod_lc.C_STATE = "0"; //0有计划1非计划
                                        #region 添加炉次计划
                                        mod_lc.N_PROD_TIME = mod_lc.N_SLAB_WGT / modtrp.N_MACH_WGT_CCM; //理论生产需时h
                                        #region 工艺路线
                                        mod_lc.C_ORDER_NO = modtrp.C_INITIALIZE_ITEM_ID; //订单号（计划订单）
                                        mod_lc.C_DESIGN_NO = modtrp.C_DESIGN_NO; //质量设计号
                                        mod_lc.C_ZL_ID = modtrp.C_ZL_ID; //转炉主键
                                        mod_lc.C_LF_ID = modtrp.C_LF_ID;//精炼主键
                                        mod_lc.C_RH_ID = modtrp.C_RH_ID; //真空主键
                                                                         // mod_lc.C_LGJH = ""; //炼钢记号
                                        #endregion
                                        int qua = 0;
                                        if (mod_lc.C_CCM_DESC.Contains("5#"))
                                        {
                                            qua = 22;

                                        }
                                        else if (mod_lc.C_CCM_DESC.Contains("7#"))
                                        {
                                            qua = 12;

                                        }
                                        else if (mod_lc.C_CCM_DESC.Contains("6#"))
                                        {
                                            if (modtrp.C_BY4 == "1")
                                            {
                                                qua = 36;
                                            }
                                            else
                                            {
                                                qua = 24;
                                            }

                                        }
                                        else
                                        {
                                            qua = 24;
                                        }
                                        mod_lc.C_QUA = qua.ToString(); //支数
                                        mod_lc.C_BY1 = modtrp.C_FREE_TERM; //线材自由项1
                                        mod_lc.C_BY2 = modtrp.C_FREE_TERM2; //线材自由项2
                                       // mod_lc.C_BY3 = modtrp.C_BY3; ; //备用3钢种颜色
                                        mod_lc.C_RH = modtrp.C_RH; //是否过真空
                                        mod_lc.C_DFP_HL = modtrp.C_DFP_HL; //大方坯连铸坯是否缓冷
                                        mod_lc.C_HL = modtrp.C_HL; //小方坯或热轧坯是否缓冷
                                        mod_lc.C_XM = modtrp.C_XM; //是否修磨
                                        mod_lc.C_PLAN_ROLL = modtrp.C_LINE_DESC; //计划轧线
                                        mod_lc.N_DFP_HL_TIME = modtrp.N_DFP_HL_TIME; //大方坯缓冷时间
                                        mod_lc.N_HL_TIME = modtrp.N_HL_TIME; //缓冷时间
                                        mod_lc.C_ROUTE = modtrp.C_ROUTE;//工艺路线 O
                                        mod_lc.N_SLAB_PW = modtrp.N_SLAB_PW;  //连铸钢坯理论单重
                                        mod_lc.C_MATRL_CODE_KP = modtrp.C_MATRL_CODE_KP;// 开坯钢坯物料号
                                        mod_lc.C_MATRL_NAME_KP = modtrp.C_MATRL_NAME_KP;// 开坯钢坯物料名称
                                        mod_lc.C_KP_SIZE = modtrp.C_KP_SIZE; // 开坯钢坯断面
                                        mod_lc.N_KP_LENGTH = modtrp.N_KP_LENGTH;// 开坯钢坯定尺
                                        mod_lc.N_KP_PW = modtrp.N_KP_PW; //开坯钢坯理论单重
                                        mod_lc.N_USE_WGT = n_mlzl; // 可使用重量
                                        mod_lc.C_DFP_RZ = modtrp.C_DFP_RZ;   //大方坯能否热装
                                        mod_lc.C_RZP_RZ = modtrp.C_DFP_RZ;    //热轧坯能否热装
                                        mod_lc.C_DFP_YQ = modtrp.C_DFP_YQ;   // 大方坯缓冷要求
                                        mod_lc.C_RZP_YQ = modtrp.C_RZP_YQ;   // 热轧坯缓冷要求
                                        mod_lc.C_STL_GRD_TYPE = modtrp.C_STL_GRD_TYPE;// 钢种类别
                                        mod_lc.C_PROD_KIND = modtrp.C_PROD_KIND;// 品种
                                        mod_lc.C_TL = modtrp.C_TL;  // 是否脱硫
                                        mod_lc.N_JSCN = modtrp.N_MACH_WGT_CCM == 0 ? 88 : modtrp.N_MACH_WGT_CCM; //机时产能
                                        mod_lc.C_FREE2 = modtrp.C_BY2;// 自由项2
                                        mod_lc.N_GROUP = N_GROUP; //连铸排产时的分组号
                                        mod_lc.N_ZJCLS = modtrp.N_ZJCLS; //整浇次炉数
                                        mod_lc.C_SL = modtrp.C_SL;  //是否需要首炉过渡
                                        mod_lc.C_WL = modtrp.C_WL;  //  是否需要尾炉过渡
                                        mod_lc.C_FREE1 = modtrp.C_BY1; //自由项1
                                        mod_lc.N_SORT = N_ORDER_LS;  //生产排序
                                        #endregion
                                        bll_lc.Add(mod_lc);

                                    }
                                    #endregion

                                    if (N_ORDER_LS == 1)
                                    {
                                        modjc.N_JSCN = mod_lc.N_JSCN;
                                        modjc.C_BY1 = mod_lc.C_BY1;
                                        modjc.C_BY2 = mod_lc.C_BY2;
                                       // modjc.C_BY3 = mod_lc.C_BY3;
                                        modjc.C_RH = mod_lc.C_RH;
                                        modjc.N_MLZL = n_mlzl;
                                        modjc.C_DFP_HL = mod_lc.C_DFP_HL;
                                        modjc.C_HL = mod_lc.C_HL;
                                        modjc.C_XM = mod_lc.C_XM;
                                        modjc.N_ORDER_LS = N_ZJCLS;
                                        modjc.C_STD_CODE = mod_lc.C_STD_CODE;
                                        modjc.C_STL_GRD_TYPE = mod_lc.C_STL_GRD_TYPE;
                                        modjc.C_PROD_NAME = mod_lc.C_PROD_NAME;
                                        modjc.C_PROD_KIND = mod_lc.C_PROD_KIND;
                                        modjc.C_TL = mod_lc.C_TL;
                                        modjc.C_REMARK = C_STL_GRD_SLAB + "【" + C_STD_CODE_SLAB + "】" + "【" + N_THIS_NUM.ToString() + "】";
                                        bll_jc.Add(modjc);
                                        modjc.N_STATUS = 0;

                                    }
                                }

                            }
                            if (j == dt_Order.Rows.Count - 1 && N_ORDER_LS > 0)//增加非计划炉次计划
                            {
                                int left = N_ZJCLS - N_ORDER_LS;
                                if (left > 0)
                                {
                                    for (int g = 0; g < left; g++)
                                    {
                                        #region 原方法
                                        Mod_TPP_LGPC_LCLSB mod_jc2 = bll_lc.GetModelListByJcID(c_jc_id).OrderByDescending(a => a.N_SORT).ToList()[0];
                                        mod_jc2.C_ID = System.Guid.NewGuid().ToString();// 主键
                                        mod_jc2.C_STATE = "1"; //0有计划1非计划
                                        mod_jc2.N_SORT = N_ORDER_LS + g + 1;
                                        bll_lc.Add(mod_jc2);
                                        #endregion
                                        

                                    }
                                }
                            }


                        }
                    }
                }
            }
        }
        
        /// <summary>
        /// 从炼钢计划表找出可凑整浇次炉次计划订单
        /// </summary>
        /// <param name="N_GROUP"></param>
        /// <param name="C_CCM_ID"></param>
        /// <returns></returns>
        public static Mod_TPP_LGPC_LCLSB GetZBJH(string D_DT_B, string D_DT_E, int N_GROUP, string C_CCM_ID)
        {
            Mod_TPP_LGPC_LCLSB mod_lc = new Mod_TPP_LGPC_LCLSB();//炉次计划临时表
            DataTable dt_Order = bll_trp_plan.GetSlabOrderInfoDesc(C_CCM_ID, N_GROUP);
            if (dt_Order.Rows.Count > 0)
            {
                decimal N_WGT = Convert.ToDecimal(dt_Order.Rows[0]["N_WGT"].ToString());//钢坯需求量
                decimal N_PROD_WGT = Convert.ToDecimal(dt_Order.Rows[0]["N_PROD_WGT"].ToString());//订单完成量
                string C_MATRL_CODE_SLAB = dt_Order.Rows[0]["C_MATRL_CODE_SLAB"].ToString();//连铸坯物料代码
                string C_MATRL_NAME_SLAB = dt_Order.Rows[0]["C_MATRL_NAME_SLAB"].ToString();//连铸坯物料名称
                string C_SLAB_SIZE = dt_Order.Rows[0]["C_SLAB_SIZE"].ToString();//连铸坯断面
                string N_SLAB_LENGTH = dt_Order.Rows[0]["N_SLAB_LENGTH"].ToString();//连铸坯定尺
                string N_SLAB_PW = dt_Order.Rows[0]["N_SLAB_PW"].ToString();//连铸坯理论单重
                string C_ROUTE = dt_Order.Rows[0]["C_ROUTE"].ToString();//工艺路线
                string C_STL_GRD_SLAB = dt_Order.Rows[0]["C_STL_GRD_SLAB"].ToString();//钢坯钢种
                string C_STD_CODE_SLAB = dt_Order.Rows[0]["C_STD_CODE_SLAB"].ToString();//钢坯执行标准
                string C_MATRL_CODE_KP = dt_Order.Rows[0]["C_MATRL_CODE_KP"].ToString();//热轧坯物料代码
                string C_MATRL_NAME_KP = dt_Order.Rows[0]["C_MATRL_NAME_KP"].ToString();//热轧坯物料名称
                string C_KP_SIZE = dt_Order.Rows[0]["C_KP_SIZE"].ToString();//热轧坯断面
                string N_KP_LENGTH = dt_Order.Rows[0]["N_KP_LENGTH"].ToString();//热轧坯定尺
                string N_KP_PW = dt_Order.Rows[0]["N_KP_PW"].ToString();//热轧坯理论单重
                string C_SL = dt_Order.Rows[0]["C_SL"].ToString();//首炉需排钢种
                string C_WL = dt_Order.Rows[0]["C_WL"].ToString();//尾炉需排钢种
                string C_BY1 = dt_Order.Rows[0]["C_BY1"].ToString();//钢坯自由项1
                string C_BY2 = dt_Order.Rows[0]["C_BY2"].ToString();//钢坯自由项2
                string C_CCM_CODE = dt_Order.Rows[0]["C_CCM_CODE"].ToString();//连铸机代码
                string C_CCM_DESC = dt_Order.Rows[0]["C_CCM_DESC"].ToString();//连铸机描述
                string C_STL_GRD_TYPE = dt_Order.Rows[0]["C_STL_GRD_TYPE"].ToString();//钢类
                string C_PROD_NAME = dt_Order.Rows[0]["C_PROD_NAME"].ToString();//品名
                string C_PROD_KIND = dt_Order.Rows[0]["C_PROD_KIND"].ToString();//品种
                string N_TYPE = dt_Order.Rows[0]["N_TYPE"].ToString();//外销坯/自备坯
                string C_BY4 = dt_Order.Rows[0]["C_BY4"].ToString();//是否不锈钢
               
                #region 匹配该炉次计划对应的订单
                DataTable dt = bll_trp_plan.GetPlanInfo(D_DT_B, D_DT_E, C_STL_GRD_SLAB, C_STD_CODE_SLAB, C_MATRL_CODE_SLAB, C_MATRL_CODE_KP, C_CCM_ID, N_GROUP);
                if (dt.Rows.Count > 0)
                {
                    Mod_TRP_PLAN_ROLL modtrp = bll_trp_plan.DataRowToModel(dt.Rows[0]);
                    mod_lc.C_STATE = "0"; //0有计划1非计划
                    #region 添加炉次计划
                    mod_lc.N_PROD_TIME = mod_lc.N_SLAB_WGT / modtrp.N_MACH_WGT_CCM; //理论生产需时h
                    #region 工艺路线
                    mod_lc.C_ORDER_NO = modtrp.C_INITIALIZE_ITEM_ID; //订单号（计划订单）
                    mod_lc.C_DESIGN_NO = modtrp.C_DESIGN_NO; //质量设计号
                    mod_lc.C_ZL_ID = modtrp.C_ZL_ID; //转炉主键
                    mod_lc.C_LF_ID = modtrp.C_LF_ID;//精炼主键
                    mod_lc.C_RH_ID = modtrp.C_RH_ID; //真空主键
                    #endregion
                    int qua = 22;//每炉支数
                    decimal n_mlzl = 46;//每炉重量
                    if (mod_lc.C_CCM_DESC.Contains("5#"))
                    {
                        qua = 22;
                        n_mlzl = 76;


                    }
                    else if (mod_lc.C_CCM_DESC.Contains("7#"))
                    {
                        qua = 12;
                        n_mlzl = 46;

                    }
                    else if (mod_lc.C_CCM_DESC.Contains("6#"))
                    {
                        if (modtrp.C_BY4 == "1")
                        {
                            qua = 36;
                            n_mlzl = 55;
                        }
                        else
                        {
                            qua = 24;
                            n_mlzl = 46;
                        }

                    }
                    else
                    {
                        qua = 24;
                        n_mlzl = 46;
                    }
                    mod_lc.C_QUA = qua.ToString(); //支数
                    mod_lc.C_BY1 = modtrp.C_FREE_TERM; //线材自由项1
                    mod_lc.C_BY2 = modtrp.C_FREE_TERM2; //线材自由项2
                  //  mod_lc.C_BY3 = modtrp.C_BY3; ; //备用3钢种颜色
                    mod_lc.C_RH = modtrp.C_RH; //是否过真空
                    mod_lc.C_DFP_HL = modtrp.C_DFP_HL; //大方坯连铸坯是否缓冷
                    mod_lc.C_HL = modtrp.C_HL; //小方坯或热轧坯是否缓冷
                    mod_lc.C_XM = modtrp.C_XM; //是否修磨
                    mod_lc.C_PLAN_ROLL = modtrp.C_LINE_DESC; //计划轧线
                    mod_lc.N_DFP_HL_TIME = modtrp.N_DFP_HL_TIME; //大方坯缓冷时间
                    mod_lc.N_HL_TIME = modtrp.N_HL_TIME; //缓冷时间
                    mod_lc.C_ROUTE = modtrp.C_ROUTE;//工艺路线 O
                    mod_lc.N_SLAB_PW = modtrp.N_SLAB_PW;  //连铸钢坯理论单重
                    mod_lc.C_MATRL_CODE_KP = modtrp.C_MATRL_CODE_KP;// 开坯钢坯物料号
                    mod_lc.C_MATRL_NAME_KP = modtrp.C_MATRL_NAME_KP;// 开坯钢坯物料名称
                    mod_lc.C_KP_SIZE = modtrp.C_KP_SIZE; // 开坯钢坯断面
                    mod_lc.N_KP_LENGTH = modtrp.N_KP_LENGTH;// 开坯钢坯定尺
                    mod_lc.N_KP_PW = modtrp.N_KP_PW; //开坯钢坯理论单重
                    mod_lc.N_USE_WGT = n_mlzl; // 可使用重量
                    mod_lc.C_DFP_RZ = modtrp.C_DFP_RZ;   //大方坯能否热装
                    mod_lc.C_RZP_RZ = modtrp.C_DFP_RZ;    //热轧坯能否热装
                    mod_lc.C_DFP_YQ = modtrp.C_DFP_YQ;   // 大方坯缓冷要求
                    mod_lc.C_RZP_YQ = modtrp.C_RZP_YQ;   // 热轧坯缓冷要求
                    mod_lc.C_STL_GRD_TYPE = modtrp.C_STL_GRD_TYPE;// 钢种类别
                    mod_lc.C_PROD_KIND = modtrp.C_PROD_KIND;// 品种
                    mod_lc.C_TL = modtrp.C_TL;  // 是否脱硫
                    mod_lc.N_JSCN = modtrp.N_MACH_WGT_CCM == 0 ? 88 : modtrp.N_MACH_WGT_CCM; //机时产能
                    mod_lc.C_FREE2 = modtrp.C_BY2;// 自由项2
                    mod_lc.N_GROUP = N_GROUP; //连铸排产时的分组号
                    mod_lc.N_ZJCLS = modtrp.N_ZJCLS; //整浇次炉数
                    mod_lc.C_SL = modtrp.C_SL;  //是否需要首炉过渡
                    mod_lc.C_WL = modtrp.C_WL;  //  是否需要尾炉过渡
                    mod_lc.C_SLAB_TYPE = ""; //钢坯类型
                    mod_lc.C_FREE1 = modtrp.C_BY1; //自由项1
                    #endregion
                   
                }

                #endregion
            }
            return mod_lc;

        }
        

        /// <summary>
        /// 获取钢种连铸炼钢记号
        /// </summary>
        /// <param name="C_STD_CODE">执行标准</param>
        /// <param name="C_STL_GRD">钢种</param>
        /// <param name="V_CC_ID">连铸代码</param>
        /// <returns></returns>
        public static DataTable GetLGJH(string C_STD_CODE, string C_STL_GRD, string V_CC_ID)
        {
            string V_CC_TYPE = "";
            string LGJH_CC_CODE = "";
            LGJH_CC_CODE = V_CC_ID;
            LGJH_CC_CODE = LGJH_CC_CODE.Substring(0, 1);
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


            return bllLgjh.Get_LGJH_Std(C_STD_CODE, C_STL_GRD, V_CC_TYPE).Tables[0];

        }

        /// <summary>
        /// 获取炼钢记号
        /// </summary>
        /// <param name="C_BOF_ID">转炉主键</param>
        /// <param name="C_LF_ID">精炼炉主键</param>
        /// <param name="C_RH_ID">真空炉主键</param>
        /// <param name="C_CASTER_ID"></param>
        /// <param name="C_STD_CODE"></param>
        /// <param name="C_STL_GRD"></param>
        /// <returns></returns>
        public static string[] GetLGJH(string C_BOF_ID, string C_LF_ID, string C_RH_ID, string C_CASTER_ID, string C_STD_CODE, string C_STL_GRD)
        {

            string str_LGJH = "";//炼钢记号
            string strMSG = "";//消息
            #region 计算炼钢记号

            string LGJH_LD_CODE = "";
            string LGJH_LF_CODE = "";
            string LGJH_RH_CODE = "";
            string LGJH_CC_CODE = "";

            string V_ZL_TYPE = "";
            string V_LF_TYPE = "";
            string V_RH_TYPE = "";
            string V_CC_TYPE = "";

            LGJH_LD_CODE = C_BOF_ID;
            LGJH_LF_CODE = C_LF_ID;
            LGJH_RH_CODE = C_RH_ID;
            LGJH_CC_CODE = C_CASTER_ID;

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



            DataTable dtLGJH = new DataTable();
            if (LGJH_LF_CODE == "4")
            {
                dtLGJH = bllLgjh.Get_LGJH_Std(C_STD_CODE, C_STL_GRD, V_ZL_TYPE, V_RH_TYPE, V_CC_TYPE).Tables[0];
            }
            else
            {
                dtLGJH = bllLgjh.Get_LGJH_Std(C_STD_CODE, C_STL_GRD, V_ZL_TYPE, V_LF_TYPE, V_RH_TYPE, V_CC_TYPE).Tables[0];
            }

            if (dtLGJH.Rows.Count > 1)
            {

                strMSG = "标准：" + C_STD_CODE + "；钢种：" + C_STL_GRD + "找到多个炼钢记号，请核查！";
            }
            else if (dtLGJH.Rows.Count == 0)
            {

                strMSG = "标准：" + C_STD_CODE + "；钢种：" + C_STL_GRD + "没有找到炼钢记号！";
            }
            else
            {
                str_LGJH = dtLGJH.Rows[0]["C_STEEL_SIGN"].ToString();
            }

            return new string[] { str_LGJH, strMSG };
            #endregion

        }


        #endregion

        #region 验证两个产品是否能够相邻生产
        private static  Bll_TPB_STEEL_PRO_CONDITION bll_pro_con = new Bll_TPB_STEEL_PRO_CONDITION();
        /// <summary>
        /// 验证两个相邻炉次计划能否生产
        /// </summary>
        /// <param name="C_STL_GRD1">上炉计划钢种</param>
        /// <param name="C_STD_CODE1">上路计划标准</param>
        /// <param name="C_STL_GRD">本炉计划钢种</param>
        /// <param name="C_STD_CODE">本炉计划标准</param>
        /// <returns></returns>
        public static bool CheckProduceBroder(string C_STL_GRD1,string C_STD_CODE1, string C_STL_GRD, string C_STD_CODE)
        {
            //相邻钢种不含版本号
            if (C_STD_CODE1.Contains("Q/XG") || C_STD_CODE1.Contains("GB/T") || C_STD_CODE1.Contains("Q/邢钢"))
            {
                C_STD_CODE1 = C_STD_CODE1.Split('-')[0].Split('.')[0];
              
            }
            if (C_STD_CODE.Contains("Q/XG") || C_STD_CODE.Contains("GB/T") || C_STD_CODE.Contains("Q/邢钢"))
            {
                C_STD_CODE = C_STD_CODE.Split('-')[0].Split('.')[0];

            }
            if (C_STL_GRD1!= C_STL_GRD|| C_STD_CODE1!= C_STD_CODE)
            {
               DataTable dt1= bll_pro_con.GetBroder(C_STL_GRD1, C_STD_CODE1, C_STL_GRD, C_STD_CODE);
                DataTable dt2 = bll_pro_con.GetBroder(C_STL_GRD, C_STD_CODE, C_STL_GRD1, C_STD_CODE1);
                if (dt1.Rows.Count>0||dt2.Rows.Count>0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return true;
            }
           
        }

        #endregion

    }
}
