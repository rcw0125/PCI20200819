using BLL;
using MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XGCAP.UI.P.PO.APS
{
    public class Cls_Tsp_GX_Plan
    {
        private static Bll_TSP_CAST_PLAN bll_cast_plan = new Bll_TSP_CAST_PLAN();//浇次计划
        private static Bll_TSP_PLAN_SMS bll_plan_sms = new Bll_TSP_PLAN_SMS();
        private static Bll_TPA_DHL_PLAN bll_dhl = new Bll_TPA_DHL_PLAN();//大方坯缓冷计划表
        private static Bll_TPA_KP_PLAN bll_kp = new Bll_TPA_KP_PLAN();//开坯计划表
        private static Bll_TPA_HL_PLAN bll_hl = new Bll_TPA_HL_PLAN();//热轧坯缓冷计划表
        private static Bll_TPA_XM_PLAN bll_xm = new Bll_TPA_XM_PLAN();//修磨计划表
        private static Bll_TPA_HL_ACT bll_hl_act = new Bll_TPA_HL_ACT();//缓冷实绩

        private static List<Mod_TSP_CAST_PLAN> jc_plan = new List<Mod_TSP_CAST_PLAN>();//待排产浇次计划
        private static List<Mod_TSP_PLAN_SMS> lc_plan = new List<Mod_TSP_PLAN_SMS>();//待排产炉次计划
        private static List<Mod_TPA_DHL_PLAN> dhl_plan = new List<Mod_TPA_DHL_PLAN>();//已排产大方坯缓冷未完成计划
        private static List<Mod_TPA_KP_PLAN> kp_plan = new List<Mod_TPA_KP_PLAN>();//已排产大方坯开坯未完成
        private static List<Mod_TPA_HL_PLAN> hl_plan = new List<Mod_TPA_HL_PLAN>();//已排产热轧坯缓冷未完成计划
        private static List<Mod_TPA_XM_PLAN> xm_plan = new List<Mod_TPA_XM_PLAN>();//已排产修磨未完成计划
        private static List<Mod_TPA_HL_ACT> hl_acl = new List<Mod_TPA_HL_ACT>();//已排产未完成的计划

        #region 更新各个工序计划LIST
        public static List<Mod_TSP_CAST_PLAN> Sort_GX_Plan(List<Mod_TSP_CAST_PLAN> lst)
        {
            #region 重新初始化各工序计划
            dhl_plan = bll_dhl.GetModelList(" AND C_STOVE_NO IS  NULL ");//已排产大方坯缓冷未完成计划
            kp_plan = bll_kp.GetModelList("  AND C_STOVE_NO IS  NULL  ");//已排产大方坯开坯未完成
            hl_plan = bll_hl.GetModelList("  AND C_STOVE_NO IS  NULL ");//已排产热轧坯缓冷未完成计划
            xm_plan = bll_xm.GetModelList("  AND C_STOVE_NO IS  NULL  ");//已排产修磨未完成计划
            lc_plan = bll_plan_sms.GetModelList(" N_CREAT_PLAN<3 ");//已排产未完成的计划
            hl_acl = bll_hl_act.GetModelList("");//已排产未完成的计划
            #endregion
            #region 在list中将待排产的浇次排产
            for (int j = 0; j < lst.Count; j++)
            {
                List<Mod_TSP_PLAN_SMS> lst_lc = bll_plan_sms.GetModelListByJcID(lst[j].C_ID);
                if (lst_lc.Count > 0)
                {
                    #region 将炉次计划的工序计划插入到工序计划list表中
                    DateTime D_P_START_TIME = (DateTime)lst[j].D_P_START_TIME;

                    for (int lc = 0; lc < lst_lc.Count; lc++)
                    {
                        #region 更新炉次计划时间
                        lst_lc[lc].N_SORT = lc + 1;
                        lst_lc[lc].N_JC_SORT = lst[j].N_SORT;
                        lst_lc[lc].N_USE_WGT = lst_lc[lc].N_SLAB_WGT;
                        lst_lc[lc].D_P_START_TIME = D_P_START_TIME;
                        lst_lc[lc].D_P_END_TIME = D_P_START_TIME.AddHours(Convert.ToDouble(lst_lc[lc].N_SLAB_WGT / lst_lc[lc].N_JSCN));
                        D_P_START_TIME = (DateTime)lst_lc[lc].D_P_END_TIME;//下一炉的开始时间
                        #endregion
                        #region 插入大方坯缓冷计划
                        if (lst_lc[lc].C_DFP_HL == "Y")
                        {
                            DateTime? D_OVER_TIME = null;//进入坑的坑的结束时间
                            Mod_TPA_DHL_PLAN mod_dhl = new Mod_TPA_DHL_PLAN();
                            mod_dhl.C_ID = System.Guid.NewGuid().ToString();
                            mod_dhl.C_FK = lst_lc[lc].C_ID;
                            mod_dhl.C_STL_GRD = lst_lc[lc].C_STL_GRD;
                            mod_dhl.C_STD_CODE = lst_lc[lc].C_STD_CODE;
                            mod_dhl.C_CCM = lst_lc[lc].C_CCM_DESC;
                            mod_dhl.C_HLYQ = lst_lc[lc].C_DFP_YQ;
                            mod_dhl.N_HL_TIME = lst_lc[lc].N_DFP_HL_TIME;
                            mod_dhl.N_QUA = 19;
                            mod_dhl.C_HLYQ = lst_lc[lc].C_DFP_YQ;
                            mod_dhl.D_START_TIME = Convert.ToDateTime(lst_lc[lc].D_P_START_TIME).AddHours(2);
                            mod_dhl.D_END_TIME = Convert.ToDateTime(lst_lc[lc].D_P_START_TIME).AddHours(2).AddHours(Convert.ToDouble(mod_dhl.N_HL_TIME));//计划缓冷结束时间
                            var lstdhl = dhl_plan.Where(a => a.D_OVER_TIME > mod_dhl.D_START_TIME && a.C_WH_CODE != "0" && a.D_START_TIME < mod_dhl.D_START_TIME).GroupBy(a => new { a.C_WH_CODE, a.N_NUM }).Select(a => new { wh = a.First().C_WH_CODE, total_qua = a.Sum(p => p.N_QUA), cap = a.Max(p => p.N_CAP), left = a.Max(p => p.N_CAP) - a.Sum(p => p.N_QUA), num = a.Max(p => p.N_NUM), over_time = a.Max(p => p.D_END_TIME) }).ToList().Where(a => a.left >= mod_dhl.N_QUA).OrderByDescending(a => a.over_time).ToList();//查找缓冷未结束的有空闲的坑按缓冷结束时间倒序;
                            if (lstdhl.Count > 0)
                            {
                                mod_dhl.C_WH_CODE = lstdhl[0].wh;
                                mod_dhl.N_TOTAL_QUA = 19 + lstdhl[0].total_qua;
                                mod_dhl.N_NUM = lstdhl[0].num;
                                mod_dhl.N_CAP = lstdhl[0].cap;
                                D_OVER_TIME = lstdhl[0].over_time;

                                if (mod_dhl.D_END_TIME > lstdhl[0].over_time)
                                {
                                    D_OVER_TIME = mod_dhl.D_END_TIME;
                                }
                                mod_dhl.D_OVER_TIME = D_OVER_TIME;
                                dhl_plan.Add(mod_dhl);
                                //跟新当前坑的结束时间
                                var lstUpdateOverTime = dhl_plan.Where(a => a.C_WH_CODE == mod_dhl.C_WH_CODE && a.N_NUM == mod_dhl.N_NUM).ToList();

                            }
                            else
                            {
                                var lstdhl2 = dhl_plan.Where(a => a.C_WH_CODE != "0").GroupBy(a => new { a.C_WH_CODE }).Select(a => new { wh = a.First().C_WH_CODE, total_qua = a.Sum(p => p.N_QUA), cap = a.Max(p => p.N_CAP), left = a.Max(p => p.N_CAP) - a.Sum(p => p.N_QUA), num = a.Max(p => p.N_NUM), over_time = a.Max(p => p.D_END_TIME) }).ToList().Where(a => a.over_time < mod_dhl.D_START_TIME).OrderBy(a => a.over_time).ToList();//查找已缓冷结束的坑
                                if (lstdhl2.Count > 0)
                                {
                                    mod_dhl.C_WH_CODE = lstdhl2[0].wh;
                                    mod_dhl.N_TOTAL_QUA = 19;
                                    mod_dhl.N_NUM = lstdhl2[0].num + 1;
                                    D_OVER_TIME = mod_dhl.D_END_TIME;
                                    mod_dhl.N_CAP = lstdhl2[0].cap;
                                    mod_dhl.D_OVER_TIME = D_OVER_TIME;
                                    dhl_plan.Add(mod_dhl);
                                    //更新当前坑的结束时间
                                }
                                else
                                {
                                    var list1 = dhl_plan.GroupBy(a => a.C_WH_CODE).Select(a => new { a.First().C_WH_CODE }).ToList();
                                    var list2 = hl_acl.Where(a => a.C_SLAB_TYPE == "大方坯" && a.N_QUA == 0).GroupBy(a => a.C_WH_CODE).Select(a => new { a.First().C_WH_CODE }).ToList();

                                    var expectedList = list2.Except(list1).ToList().OrderBy(a => a.C_WH_CODE).ToList();

                                    //从没有使用过的缓冷坑找一个坑使用
                                    var lstdhl_act = hl_acl.Where(a => a.C_WH_CODE == expectedList[0].C_WH_CODE).ToList();
                                    if (lstdhl_act.Count > 0)
                                    {
                                        foreach (var item in hl_acl)
                                        {
                                            if (item.C_ID == lstdhl_act[0].C_ID)
                                            {
                                                item.N_QUA = Convert.ToDecimal(mod_dhl.N_QUA);
                                            }
                                        }

                                        mod_dhl.C_WH_CODE = expectedList[0].C_WH_CODE;
                                        mod_dhl.N_TOTAL_QUA = 19;
                                        mod_dhl.N_CAP = lstdhl_act[0].N_CAP_QUA;
                                        mod_dhl.N_NUM = dhl_plan.Where(a => a.C_WH_CODE == mod_dhl.C_WH_CODE).Max(a => a.N_NUM) == null ? 0 : dhl_plan.Where(a => a.C_WH_CODE == mod_dhl.C_WH_CODE).Max(a => a.N_NUM) + 1;
                                        mod_dhl.D_OVER_TIME = mod_dhl.D_END_TIME;
                                        dhl_plan.Add(mod_dhl);
                                    }
                                    else
                                    {
                                        hl_acl[0].N_QUA = Convert.ToDecimal(mod_dhl.N_QUA);
                                        mod_dhl.C_WH_CODE = "0";
                                        mod_dhl.N_TOTAL_QUA = 19;
                                        mod_dhl.N_CAP = 10000;
                                        mod_dhl.N_NUM = 1;
                                        mod_dhl.D_OVER_TIME = mod_dhl.D_END_TIME;
                                        dhl_plan.Add(mod_dhl);
                                    }
                                }
                            }

                            lst_lc[lc].D_DFPHL_START_TIME = mod_dhl.D_START_TIME;
                            lst_lc[lc].D_DFPHL_END_TIME = mod_dhl.D_OVER_TIME;

                        }
                        #endregion
                        #region 插入开坯计划

                        Mod_TPA_KP_PLAN mod_kp = new Mod_TPA_KP_PLAN();
                        mod_kp.C_ID = System.Guid.NewGuid().ToString();
                        mod_kp.C_FK = lst_lc[lc].C_ID;
                        mod_kp.C_STL_GRD = lst_lc[lc].C_STL_GRD;
                        mod_kp.C_STD_CODE = lst_lc[lc].C_STD_CODE;
                        mod_kp.C_CCM = lst_lc[lc].C_CCM_DESC;
                        mod_kp.D_CAN_START_TIME = lst_lc[lc].C_DFP_HL == "Y" ? Convert.ToDateTime(lst_lc[lc].D_DFPHL_END_TIME).AddHours(1) : Convert.ToDateTime(lst_lc[lc].D_P_START_TIME).AddHours(2);//可开坯时间
                        mod_kp.N_WGT = lst_lc[lc].N_SLAB_WGT;
                        mod_kp.N_CN = 114;//机时产能
                        mod_kp.C_DHL = lst_lc[lc].C_HL;//热轧钢坯是否缓冷
                        mod_kp.C_DFP_RZ = lst_lc[lc].C_DFP_RZ;//大方坯是否热装
                        mod_kp.C_DFP_YQ = lst_lc[lc].C_DFP_YQ;//大方坯缓冷要求

                        mod_kp.C_MATRL_CODE_SLAB = lst_lc[lc].C_MATRL_NO;
                        mod_kp.C_MATRL_NAME_SLAB = lst_lc[lc].C_MATRL_NAME;
                        mod_kp.C_MATRL_CODE_KP = lst_lc[lc].C_MATRL_CODE_KP;
                        mod_kp.C_MATRL_NAME_KP = lst_lc[lc].C_MATRL_NAME_KP;
                        mod_kp.C_KP_SIZE = lst_lc[lc].C_KP_SIZE;
                        mod_kp.N_KP_LENGTH = lst_lc[lc].N_KP_LENGTH;
                        mod_kp.N_KP_PW = lst_lc[lc].N_KP_PW;

                        mod_kp.N_SLAB_LENGTH = Convert.ToDecimal(lst_lc[lc].C_SLAB_LENGTH);
                        mod_kp.C_SLAB_SIZE = lst_lc[lc].C_SLAB_SIZE;
                        mod_kp.N_SLAB_PW = lst_lc[lc].N_SLAB_PW;

                        if (mod_kp.C_DFP_RZ == "Y" || mod_kp.C_DFP_YQ.Trim() != "")
                        {
                            //必需热轧
                            DateTime? dtjhkssj = null;
                            var lstlastkp = kp_plan.Where(a => a.D_START_TIME <= Convert.ToDateTime(lst_lc[lc].D_P_START_TIME).AddHours(2)).ToList();
                            if (lstlastkp.Count > 0)
                            {
                                dtjhkssj = (DateTime)kp_plan.Where(a => a.D_START_TIME <= Convert.ToDateTime(lst_lc[lc].D_P_START_TIME).AddHours(2)).Max(a => a.D_END_TIME);
                                if (dtjhkssj < Convert.ToDateTime(lst_lc[lc].D_P_START_TIME).AddHours(2))
                                {
                                    dtjhkssj = Convert.ToDateTime(lst_lc[lc].D_P_START_TIME).AddHours(2);
                                }
                                mod_kp.N_SORT = kp_plan.Where(a => a.D_START_TIME <= Convert.ToDateTime(lst_lc[lc].D_P_START_TIME).AddHours(2)).Max(a => a.N_SORT) + 1;//开坯计划排序号
                            }
                            else
                            {
                                mod_kp.N_SORT = 1;

                            }
                            mod_kp.D_START_TIME = dtjhkssj;//开坯计划开始时间
                            mod_kp.D_END_TIME = ((DateTime)dtjhkssj).AddHours((double)(mod_kp.N_WGT / mod_kp.N_CN));//开坯计划结束时间
                                                                                                                    //将当前计划之后的计划时间全都重新计算
                            var updatelist = kp_plan.Where(a => a.N_SORT > mod_kp.N_SORT - 1).OrderBy(a => a.N_SORT).ToList();
                            if (updatelist.Count > 0)
                            {
                                DateTime dtB2 = (DateTime)mod_kp.D_END_TIME;
                                for (int m = 0; m < updatelist.Count; m++)
                                {
                                    updatelist[m].N_SORT = updatelist[m].N_SORT + 1;
                                    updatelist[m].D_START_TIME = dtB2;
                                    updatelist[m].D_END_TIME = dtB2.AddHours((double)(updatelist[m].N_WGT / updatelist[m].N_CN));
                                    dtB2 = (DateTime)updatelist[m].D_END_TIME;

                                }

                            }

                        }
                        else
                        {
                            int kpsort = 0;
                            DateTime dtjhkssj = (DateTime)mod_kp.D_CAN_START_TIME;
                            if (kp_plan.Count == 0)
                            {
                                dtjhkssj = (DateTime)mod_kp.D_CAN_START_TIME;
                            }
                            else
                            {
                                dtjhkssj = (DateTime)kp_plan.Max(a => a.D_END_TIME);
                                kpsort = (int)kp_plan.Max(a => a.N_SORT);
                            }

                            if (dtjhkssj < mod_kp.D_CAN_START_TIME)
                            {
                                dtjhkssj = (DateTime)mod_kp.D_CAN_START_TIME;

                            }
                            mod_kp.N_SORT = kpsort + 1;//开坯计划排序号
                            mod_kp.D_START_TIME = dtjhkssj;//开坯计划开始时间
                            mod_kp.D_END_TIME = dtjhkssj.AddHours((double)(mod_kp.N_WGT / mod_kp.N_CN));//开坯计划结束时间
                        }
                        kp_plan.Add(mod_kp);
                        lst_lc[lc].D_KP_START_TIME = mod_kp.D_START_TIME;
                        lst_lc[lc].D_KP_END_TIME = mod_kp.D_END_TIME;
                        if (lst_lc[lc].C_HL == "N" && lst_lc[lc].C_XM == "N")
                        {
                            lst_lc[lc].D_CAN_USE_TIME = ((DateTime)mod_kp.D_START_TIME).AddHours(2);
                        }
                        #endregion
                        #region 插入热轧坯缓冷计划
                        if (lst_lc[lc].C_HL == "Y")
                        {
                            DateTime? D_OVER_TIME = null;//进入坑的坑的结束时间
                            Mod_TPA_HL_PLAN mod_hl = new Mod_TPA_HL_PLAN();
                            mod_hl.C_ID = System.Guid.NewGuid().ToString();
                            mod_hl.C_FK = lst_lc[lc].C_ID;
                            mod_hl.C_STL_GRD = lst_lc[lc].C_STL_GRD;
                            mod_hl.C_STD_CODE = lst_lc[lc].C_STD_CODE;
                            mod_hl.C_CCM = lst_lc[lc].C_CCM_DESC;
                            mod_hl.C_HLYQ = lst_lc[lc].C_RZP_YQ;
                            mod_hl.N_HL_TIME = lst_lc[lc].N_HL_TIME;
                            mod_hl.N_QUA = 38;
                            mod_hl.C_HLYQ = lst_lc[lc].C_DFP_YQ;
                            mod_hl.D_START_TIME = Convert.ToDateTime(lst_lc[lc].D_KP_START_TIME).AddHours(2);
                            mod_hl.D_END_TIME = Convert.ToDateTime(lst_lc[lc].D_KP_START_TIME).AddHours(2).AddHours(Convert.ToDouble(mod_hl.N_HL_TIME));//计划缓冷结束时间
                            var lstdhl = hl_plan.Where(a => a.D_OVER_TIME > mod_hl.D_START_TIME && a.C_WH_CODE != "0" && a.D_START_TIME < mod_hl.D_START_TIME).GroupBy(a => new { a.C_WH_CODE, a.N_NUM }).Select(a => new { wh = a.First().C_WH_CODE, num = a.First().N_NUM, total_qua = a.Sum(p => p.N_QUA), cap = a.Max(p => p.N_CAP), left = a.Max(p => p.N_CAP) - a.Sum(p => p.N_QUA), over_time = a.Max(p => p.D_END_TIME) }).ToList().Where(a => a.left >= mod_hl.N_QUA).OrderByDescending(a => a.over_time).ToList();//查找缓冷未结束的有空闲的坑按缓冷结束时间倒序;
                            if (lstdhl.Count > 0)
                            {
                                mod_hl.C_WH_CODE = lstdhl[0].wh;
                                mod_hl.N_TOTAL_QUA = 38 + lstdhl[0].total_qua;
                                mod_hl.N_NUM = lstdhl[0].num;
                                mod_hl.N_CAP = lstdhl[0].cap;
                                D_OVER_TIME = lstdhl[0].over_time;
                                if (mod_hl.D_END_TIME > lstdhl[0].over_time)
                                {
                                    D_OVER_TIME = mod_hl.D_END_TIME;
                                }
                                mod_hl.D_OVER_TIME = D_OVER_TIME;
                                hl_plan.Add(mod_hl);
                                //跟新当前坑的结束时间
                                var lstUpdateOverTime = hl_plan.Where(a => a.C_WH_CODE == mod_hl.C_WH_CODE && a.N_NUM == mod_hl.N_NUM).ToList();

                            }
                            else
                            {
                                var lstdhl2 = hl_plan.Where(a => a.C_WH_CODE != "0").GroupBy(a => new { a.C_WH_CODE }).Select(a => new { wh = a.First().C_WH_CODE, num = a.First().N_NUM, total_qua = a.Sum(p => p.N_QUA), cap = a.Max(p => p.N_CAP), left = a.Max(p => p.N_CAP) - a.Sum(p => p.N_QUA), over_time = a.Max(p => p.D_END_TIME) }).ToList().Where(a => a.over_time < mod_hl.D_START_TIME).OrderBy(a => a.over_time).ToList();//查找缓冷坑缓冷已结束的坑
                                if (lstdhl2.Count > 0)
                                {
                                    mod_hl.C_WH_CODE = lstdhl2[0].wh;
                                    mod_hl.N_TOTAL_QUA = 38;
                                    mod_hl.N_NUM = lstdhl2[0].num + 1;
                                    D_OVER_TIME = mod_hl.D_END_TIME;
                                    mod_hl.N_CAP = lstdhl2[0].cap;
                                    mod_hl.D_OVER_TIME = D_OVER_TIME;
                                    hl_plan.Add(mod_hl);
                                    //更新当前坑的结束时间

                                }
                                else
                                {
                                    var list1 = hl_plan.GroupBy(a => a.C_WH_CODE).Select(a => new { a.First().C_WH_CODE }).ToList();
                                    var list2 = hl_acl.Where(a => a.C_SLAB_TYPE == "小方坯" && a.N_QUA == 0).GroupBy(a => a.C_WH_CODE).Select(a => new { a.First().C_WH_CODE }).ToList();
                                    var expectedList = list2.Except(list1).ToList().OrderBy(a => a.C_WH_CODE).ToList();
                                    if (expectedList.Count > 0)
                                    {
                                        //从没有使用过的缓冷坑找一个坑使用
                                        var lstdhl_act = hl_acl.Where(a => a.C_WH_CODE == expectedList[0].C_WH_CODE).ToList();
                                        if (lstdhl_act.Count > 0)
                                        {
                                            foreach (var item in hl_acl)
                                            {
                                                if (item.C_ID == lstdhl_act[0].C_ID)
                                                {
                                                    item.N_QUA = Convert.ToDecimal(mod_hl.N_QUA);
                                                }
                                            }
                                            //从没有使用过的缓冷坑找一个坑使用
                                            mod_hl.C_WH_CODE = expectedList[0].C_WH_CODE;
                                            mod_hl.N_TOTAL_QUA = 38;
                                            mod_hl.N_CAP = lstdhl_act[0].N_CAP_QUA;
                                            mod_hl.N_NUM = dhl_plan.Where(a => a.C_WH_CODE == mod_hl.C_WH_CODE).Max(a => a.N_NUM) == null ? 0 : dhl_plan.Where(a => a.C_WH_CODE == mod_hl.C_WH_CODE).Max(a => a.N_NUM) + 1;
                                            mod_hl.D_OVER_TIME = mod_hl.D_END_TIME;
                                            hl_plan.Add(mod_hl);
                                        }
                                        else
                                        {
                                            hl_acl[0].N_QUA = Convert.ToDecimal(mod_hl.N_QUA);
                                            mod_hl.C_WH_CODE = "0";
                                            mod_hl.N_TOTAL_QUA = 38;
                                            mod_hl.N_CAP = 10000;
                                            mod_hl.N_NUM = 1;
                                            mod_hl.D_OVER_TIME = mod_hl.D_END_TIME;
                                            hl_plan.Add(mod_hl);
                                        }
                                    }
                                    else
                                    {
                                        hl_acl[0].N_QUA = Convert.ToDecimal(mod_hl.N_QUA);
                                        mod_hl.C_WH_CODE = "0";
                                        mod_hl.N_TOTAL_QUA = 38;
                                        mod_hl.N_CAP = 10000;
                                        mod_hl.N_NUM = 1;
                                        mod_hl.D_OVER_TIME = mod_hl.D_END_TIME;
                                        hl_plan.Add(mod_hl);
                                    }

                                }
                            }

                            lst_lc[lc].D_HL_START_TIME = mod_hl.D_START_TIME;
                            lst_lc[lc].D_HL_END_TIME = mod_hl.D_OVER_TIME;
                            if (lst_lc[lc].C_XM == "N")
                            {
                                if (mod_hl.D_OVER_TIME == null)
                                {
                                    lst_lc[lc].D_CAN_USE_TIME = null;
                                }
                                else
                                {
                                    lst_lc[lc].D_CAN_USE_TIME = ((DateTime)mod_hl.D_OVER_TIME).AddHours(2);
                                }

                            }

                        }
                        #endregion
                        #region 插入修磨计划

                        if (lst_lc[lc].C_XM == "Y")
                        {
                            Mod_TPA_XM_PLAN mod_xm = new Mod_TPA_XM_PLAN();
                            mod_xm.C_ID = System.Guid.NewGuid().ToString();
                            mod_xm.C_FK = lst_lc[lc].C_ID;
                            mod_xm.C_STL_GRD = lst_lc[lc].C_STL_GRD;
                            mod_xm.C_STD_CODE = lst_lc[lc].C_STD_CODE;
                            mod_xm.C_CCM = lst_lc[lc].C_CCM_DESC;
                            mod_xm.D_PLAN_DATE = lst_lc[lc].C_HL == "Y" ? Convert.ToDateTime(lst_lc[lc].D_HL_END_TIME).AddHours(1) : Convert.ToDateTime(lst_lc[lc].D_KP_END_TIME).AddHours(12);//可修磨时间
                            mod_xm.N_WGT = lst_lc[lc].N_SLAB_WGT;
                            mod_xm.C_XM_TYPE = "碳钢";
                            mod_xm.N_CN = 400 / 24;//机时产能
                            DateTime maxxmtime = (DateTime)mod_xm.D_PLAN_DATE;
                            DateTime? maxsytime = xm_plan.Where(a => a.C_XM_TYPE == "碳钢").Max(a => a.D_END_TIME);//找出已排计划最大修磨结束时间
                            if (maxsytime != null && maxsytime >= maxxmtime)
                            {
                                maxxmtime = (DateTime)maxsytime;
                            }
                            mod_xm.D_START_TIME = maxxmtime;
                            mod_xm.D_END_TIME = maxxmtime.AddHours((double)(mod_xm.N_WGT / mod_xm.N_CN));
                            xm_plan.Add(mod_xm);
                            lst_lc[lc].D_XM_START_TIME = mod_xm.D_START_TIME;
                            lst_lc[lc].D_XM_END_TIME = mod_xm.D_END_TIME;
                            lst_lc[lc].D_CAN_USE_TIME = ((DateTime)mod_xm.D_END_TIME).AddHours(2);

                        }
                        #endregion
                        bll_plan_sms.Update(lst_lc[lc]);
                    }
                    #endregion
                }

                bll_cast_plan.Update(lst[j]);
            }
            #endregion

            #region 添加工序计划

            if (dhl_plan.Count > 0)
            {
                for (int i = 0; i < dhl_plan.Count; i++)
                {
                    bll_dhl.Add(dhl_plan[i]);
                }

            }


            if (kp_plan.Count > 0)
            {
                for (int i = 0; i < kp_plan.Count; i++)
                {
                    bll_kp.Add(kp_plan[i]);
                }

            }
            if (hl_plan.Count > 0)
            {
                for (int i = 0; i < hl_plan.Count; i++)
                {
                    bll_hl.Add(hl_plan[i]);
                }

            }
            if (xm_plan.Count > 0)
            {
                for (int i = 0; i < xm_plan.Count; i++)
                {
                    bll_xm.Add(xm_plan[i]);
                }

            }
            #endregion
            return lst;

        }
        #endregion


        #region 大方坯各工序排序

        #region 初始化大方坯计划
        //1、初始化大方坯连铸时间
        //2、初始化大方坯缓冷时间
        //3、初始化大方坯开坯计划时间（热开优先，不能热开找有计划的能集中生产的大方坯，工序复杂的优先，考虑开坯机的停机时间）
        //4、热轧坯的缓冷时间
        //5、热轧坯的修磨时间
        /// <summary>
        /// 派出开坯计划顺序
        /// </summary>
        /// <param name="list">所有待开坯的计划</param>
        public void Sort_Kp_plan(List<Mod_TSP_PLAN_SMS> list)
        {


        }

        #endregion 



        #endregion



    }
}