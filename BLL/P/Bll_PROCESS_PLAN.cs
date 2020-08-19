using DAL;
using MODEL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;

namespace BLL
{
    /// <summary>
    /// 工序计划
    /// </summary>
    public class Bll_PROCESS_PLAN
    {
        private readonly Dal_TSP_PLAN_SMS dal_TSP_PLAN_SMS = new Dal_TSP_PLAN_SMS();
        private readonly Bll_TSP_PLAN_SMS bll_TSP_PLAN_SMS = new Bll_TSP_PLAN_SMS();
        private readonly Dal_TPA_DHL_PLAN dal_TPA_DHL_PLAN = new Dal_TPA_DHL_PLAN();
        private readonly Bll_TPA_DHL_PLAN bll_TPA_DHL_PLAN = new Bll_TPA_DHL_PLAN();
        private readonly Dal_TPA_KP_PLAN dal_TPA_KP_PLAN = new Dal_TPA_KP_PLAN();
        private readonly Dal_TPA_HL_PLAN dal_TPA_HL_PLAN = new Dal_TPA_HL_PLAN();
        private readonly Bll_TPA_HL_PLAN bll_TPA_HL_PLAN = new Bll_TPA_HL_PLAN();
        private readonly Dal_TPA_XM_PLAN dal_TPA_XM_PLAN = new Dal_TPA_XM_PLAN();
        private readonly Dal_PROCESS_PLAN dal = new Dal_PROCESS_PLAN();
        private readonly Bll_TPA_HL_ACT bll_TPA_HL_ACT = new Bll_TPA_HL_ACT();


        public void List()
        {
            DataTable usedD = dal.GetUsedLoc();
            //var loc = dal.GetOutLoc(usedD);
        }

        public string ProcessSort(out List<Mod_TSP_PLAN_SMS> processResult)
        {
            int ccm_dfphl = int.Parse(ConfigurationManager.AppSettings.Get("ccm_dfphl"));
            int dfphl_kp = int.Parse(ConfigurationManager.AppSettings.Get("dfphl_kp"));
            int kp_hl = int.Parse(ConfigurationManager.AppSettings.Get("kp_hl"));
            int hl_xm = int.Parse(ConfigurationManager.AppSettings.Get("hl_xm"));
            int ccm_kp = int.Parse(ConfigurationManager.AppSettings.Get("ccm_kp"));
            int kp_xm = int.Parse(ConfigurationManager.AppSettings.Get("kp_xm"));
            string result = "1";
            //获取缓冷坑库位
            var strLocs = bll_TPA_HL_ACT.DataTableToList(dal.GetDfpHlStrLoc());
            var dStrLocs = strLocs.Where(x => x.C_SLAB_TYPE == "大方坯").OrderBy(x => x.C_WH_CODE).ToList();//大方坯库位
            var xStrLocs = strLocs.Where(x => x.C_SLAB_TYPE == "小方坯").OrderBy(x => x.C_WH_CODE).ToList();//小方坯库位

            //查询所有连铸计划
            var smsAllModels = bll_TSP_PLAN_SMS.DataTableToList(dal_TSP_PLAN_SMS.GetList(" C_SLAB_TYPE='大方坯' AND N_CREAT_PLAN!=3  ").Tables[0]);



            //按照连铸计划时间、热轧排序 大方坯
            var smsModels = smsAllModels.Where(x => x.C_SLAB_TYPE == "大方坯")
                                                     .OrderBy(x => x.D_P_START_TIME)
                                                     .ThenByDescending(x => x.C_DFP_RZ)
                                                     .ToList();

            //删除个子表计划
            dal.DelDfpHl_FK(smsModels);
            dal.DelKp_FK(smsModels);
            dal.DelHl_FK(smsModels);
            dal.DelXm_FK(smsModels);

            //连铸计划推出开坯计划
            List<Mod_TSP_PLAN_SMS> kpResult = new List<Mod_TSP_PLAN_SMS>();
            //缓冷计划
            List<Mod_TPA_DHL_PLAN> dhlPlans = new List<Mod_TPA_DHL_PLAN>();
            //开坯计划
            List<Mod_TPA_KP_PLAN> kpPlans = new List<Mod_TPA_KP_PLAN>();
            //缓冷计划（小方坯）
            List<Mod_TPA_HL_PLAN> hlPlans = new List<Mod_TPA_HL_PLAN>();
            //开坯计划推出修磨计划
            List<Mod_TSP_PLAN_SMS> xmResult = new List<Mod_TSP_PLAN_SMS>();
            //修磨计划
            List<Mod_TPA_XM_PLAN> xmPlans = new List<Mod_TPA_XM_PLAN>();


            try
            {
                int smsCount = smsModels.Count;
                for (int i = 0; i < smsCount; i++)
                {
                    smsModels[i].C_QUA = "19";
                    if (smsModels[i].C_DFP_HL == "Y")   //缓冷(大方坯)
                    {
                        #region 计算缓冷时间
                        //获取未用缓冷坑(所有缓冷坑-已使用过的缓冷坑)
                        DataTable usedD = dal.GetUsedLoc();
                        if (usedD.Rows.Count > 0)
                        {
                            int lCount = usedD.Rows.Count;
                            for (int l = 0; l < lCount; l++)
                            {
                                var loc = dStrLocs.FirstOrDefault(x => x.C_WH_CODE == usedD.Rows[l]["C_WH_CODE"].ToString());
                                dStrLocs.Remove(loc);
                            }
                        }
                        smsModels[i].D_DFPHL_START_TIME = smsModels[i].D_P_START_TIME.Value.AddHours(ccm_dfphl);//连铸到缓冷1小时
                        smsModels[i].D_DFPHL_END_TIME = smsModels[i].D_DFPHL_START_TIME.Value.AddHours((int)smsModels[i].N_DFP_HL_TIME);//需要缓冷时间
                                                                                                                                        //入坑记录
                        Mod_TPA_DHL_PLAN dhlM = new Mod_TPA_DHL_PLAN();
                        dhlM.C_ID = Guid.NewGuid().ToString("N");
                        dhlM.C_FK = smsModels[i].C_ID;
                        dhlM.C_STOVE_NO = smsModels[i].C_STOVE_NO;
                        dhlM.C_STL_GRD = smsModels[i].C_STL_GRD;
                        dhlM.C_STD_CODE = smsModels[i].C_STD_CODE;
                        dhlM.D_START_TIME = smsModels[i].D_DFPHL_START_TIME;
                        dhlM.D_END_TIME = smsModels[i].D_DFPHL_END_TIME;
                        dhlM.N_HL_TIME = smsModels[i].N_HL_TIME;
                        dhlM.N_STATUS = 1;
                        dhlM.N_QUA = decimal.Parse(smsModels[i].C_QUA);
                        dhlM.D_OVER_TIME = smsModels[i].D_DFPHL_END_TIME;
                        var locD = dal.GetUseLoc(usedD, (int)dhlM.N_QUA, dhlM.D_END_TIME);//可用坑位
                        var locMaster = dal.GetOutLoc(usedD, smsModels[i].D_P_START_TIME);//快要出坑明细
                        if (locD != null && locD.Rows.Count > 0)//缓冷坑余量足够 并且 当前坑中原钢坯与新入钢坯时间间隔不能超过5小时
                        {
                            dhlM.C_WH_CODE = locD.Rows[0]["C_WH_CODE"].ToString();
                            dhlM.N_TOTAL_QUA = dhlM.N_QUA + int.Parse(locD.Rows[0]["N_TOTAL_QUA"].ToString());
                            dhlM.N_NUM = int.Parse(locD.Rows[0]["N_NUM"].ToString());
                            dhlM.N_CAP = int.Parse(locD.Rows[0]["N_CAP"].ToString());
                            smsModels[i].WhCode = dhlM.C_WH_CODE;
                            smsModels[i].Num = dhlM.N_NUM;
                        }
                        else if (dStrLocs != null && dStrLocs.Count > 0)//使用没有使用过的坑位
                        {
                            dhlM.C_WH_CODE = dStrLocs[0].C_WH_CODE;
                            dhlM.N_TOTAL_QUA = dhlM.N_QUA;
                            dhlM.N_NUM = 1;
                            dhlM.N_CAP = dStrLocs[0].N_CAP_QUA;
                            smsModels[i].WhCode = dhlM.C_WH_CODE;
                            smsModels[i].Num = dhlM.N_NUM;
                        }
                        else if (locMaster != null && locMaster.Rows.Count > 0)//计划n+1次入坑
                        {
                            dhlM.C_WH_CODE = locMaster.Rows[0]["C_WH_CODE"].ToString();
                            dhlM.N_TOTAL_QUA = dhlM.N_QUA;
                            dhlM.N_NUM = int.Parse(locMaster.Rows[0]["N_NUM"].ToString()) + 1;
                            dhlM.N_CAP = int.Parse(locMaster.Rows[0]["N_CAP"].ToString());
                            smsModels[i].WhCode = dhlM.C_WH_CODE;
                            smsModels[i].Num = dhlM.N_NUM;
                        }
                        else//坑满 虚拟坑位
                        {
                            dhlM.C_WH_CODE = "0";
                            smsModels[i].N_STATUS = 0;
                            dhlM.N_TOTAL_QUA = dhlM.N_QUA + dal.GetVirtualLocMaxQua();
                            dhlM.N_NUM = 0;
                            smsModels[i].WhCode = dhlM.C_WH_CODE;
                            smsModels[i].Num = dhlM.N_NUM;
                        }
                        dal_TPA_DHL_PLAN.Add(dhlM);
                        dhlPlans.Add(dhlM);

                        #endregion

                        #region 计算开坯时间(需要缓冷钢坯)
                        smsModels[i].D_KP_START_TIME = smsModels[i].D_DFPHL_END_TIME.Value.AddHours(dfphl_kp);//缓冷坑到开坯增加一小时
                        smsModels[i].D_KP_END_TIME = smsModels[i].D_KP_START_TIME.Value.AddHours((double)smsModels[i].N_PROD_TIME);//开坯时间
                        smsModels[i].CalCulateTimeStart = smsModels[i].D_KP_START_TIME;
                        smsModels[i].C_QUA = (int.Parse(smsModels[i].C_QUA) * 2).ToString();
                        kpResult.Add(smsModels[i]);
                        #endregion
                    }
                    else//不需要缓冷(大方坯)
                    {
                        #region 计算开坯时间
                        smsModels[i].D_KP_START_TIME = smsModels[i].D_P_START_TIME.Value.AddHours(ccm_kp);//连铸到开坯2小时
                        smsModels[i].D_KP_END_TIME = smsModels[i].D_KP_START_TIME.Value.AddHours((double)smsModels[i].N_PROD_TIME);//开坯时间
                        smsModels[i].CalCulateTimeStart = smsModels[i].D_KP_START_TIME;
                        smsModels[i].C_QUA = (int.Parse(smsModels[i].C_QUA) * 2).ToString();
                        kpResult.Add(smsModels[i]);

                        #endregion
                    }
                }

                #region 计算开坯顺序
                kpResult = kpResult.OrderBy(x => x.D_KP_START_TIME)
                           .ThenByDescending(x => x.C_DFP_RZ)
                            .ToList();

                for (int j = 2; j < kpResult.Count; j++)
                {
                    //如果开坯时间互斥，重新计算开坯时间
                    if ((kpResult[j].D_KP_START_TIME < kpResult[j - 1].D_KP_END_TIME))
                    {
                        kpResult[j].D_KP_START_TIME = kpResult[j - 1].D_KP_END_TIME;
                        kpResult[j].D_KP_END_TIME = kpResult[j].D_KP_START_TIME.Value.AddHours((double)kpResult[j].N_PROD_TIME);
                    }
                }

                kpResult = kpResult.OrderBy(x => x.D_KP_START_TIME)
                       .ThenByDescending(x => x.C_DFP_RZ)
                        .ToList();

                foreach (var kp in kpResult)
                {
                    //开坯记录
                    Mod_TPA_KP_PLAN kpM = new Mod_TPA_KP_PLAN();
                    kpM.C_ID = Guid.NewGuid().ToString("N");
                    kpM.C_FK = kp.C_ID;
                    kpM.C_STOVE_NO = kp.C_STOVE_NO;
                    kpM.C_STL_GRD = kp.C_STL_GRD;
                    kpM.C_STD_CODE = kp.C_STD_CODE;
                    kpM.N_WGT = kp.N_SLAB_WGT;
                    kpM.D_START_TIME = kp.D_KP_START_TIME;
                    kpM.D_END_TIME = kp.D_KP_END_TIME;
                    kpM.N_CN = kp.N_JSCN.Value;
                    kpM.N_STATUS = 1;
                    kpM.C_CCM = kp.C_CCM_DESC;
                    kpM.D_CAN_START_TIME = kp.D_KP_START_TIME;
                    kpPlans.Add(kpM);
                }
                #endregion

                #region 计算缓冷坑最大出坑时间(大方坯)
                var useD = dal.GetUsedLoc();
                if (useD != null && useD.Rows.Count > 0)
                {
                    var uCount = useD.Rows.Count;
                    for (int i = 0; i < uCount; i++)
                    {
                        for (int j = 0; j < int.Parse(useD.Rows[i]["N_NUM"].ToString()); j++)
                        {
                            var outPitDt = dal.GetOutPitTime(useD.Rows[j]["C_WH_CODE"].ToString(), j + 1);
                            if (outPitDt != null && outPitDt.Rows.Count > 0)
                            {
                                int nCount = outPitDt.Rows.Count;
                                for (int n = 0; n < nCount; n++)
                                {
                                    string c_fk = outPitDt.Rows[n]["C_FK"].ToString();
                                    DateTime overtime = DateTime.Parse(outPitDt.Rows[n]["D_OVER_TIME"].ToString());
                                    var resetOutTimes = smsModels.Where(x => x.C_ID == c_fk).ToList();
                                    if (resetOutTimes.Count > 0)
                                        resetOutTimes[0].D_DFPHL_END_TIME = overtime;
                                }
                            }
                        }
                    }
                }
                #endregion

                kpResult.OrderBy(x => x.D_KP_END_TIME).ThenByDescending(x => x.C_RZP_RZ).ToList();
                //计算小方坯缓冷
                for (int i = 0; i < kpResult.Count; i++)
                {
                    //缓冷（小方坯）
                    if (kpResult[i].C_HL == "Y")
                    {
                        #region 小方坯缓冷
                        //获取未用缓冷坑(所有缓冷坑-已使用过的缓冷坑)
                        DataTable usedX = dal.GetUsedXLoc();
                        if (usedX.Rows.Count > 0)
                        {
                            for (int l = 0; l < usedX.Rows.Count; l++)
                            {
                                var loc = xStrLocs.FirstOrDefault(x => x.C_WH_CODE == usedX.Rows[l]["C_WH_CODE"].ToString());
                                xStrLocs.Remove(loc);
                            }
                        }

                        kpResult[i].D_HL_START_TIME = kpResult[i].D_KP_END_TIME.Value.AddHours(kp_hl);//开坯到缓冷1小时
                        kpResult[i].D_HL_END_TIME = kpResult[i].D_HL_START_TIME.Value.AddHours((int)kpResult[i].N_HL_TIME);//需要缓冷时间
                                                                                                                           //入坑记录
                        Mod_TPA_HL_PLAN xhlM = new Mod_TPA_HL_PLAN();
                        xhlM.C_ID = Guid.NewGuid().ToString("N");
                        xhlM.C_FK = kpResult[i].C_ID;
                        xhlM.C_STOVE_NO = kpResult[i].C_STOVE_NO;
                        xhlM.C_STL_GRD = kpResult[i].C_STL_GRD;
                        xhlM.C_STD_CODE = kpResult[i].C_STD_CODE;
                        xhlM.D_START_TIME = kpResult[i].D_HL_START_TIME;
                        xhlM.D_END_TIME = kpResult[i].D_HL_END_TIME;
                        xhlM.N_HL_TIME = kpResult[i].N_HL_TIME;
                        xhlM.N_STATUS = 1;
                        xhlM.N_QUA = decimal.Parse(kpResult[i].C_QUA);
                        xhlM.D_OVER_TIME = kpResult[i].D_HL_END_TIME;
                        var locD = dal.GetUseXLoc(usedX, (int)xhlM.N_QUA, xhlM.D_END_TIME);//可用坑位
                        var locMaster = dal.GetOutXLoc(usedX, kpResult[i].D_KP_END_TIME);//快要出坑明细
                        if (locD != null && locD.Rows.Count > 0)//缓冷坑余量足够 并且 当前坑中原钢坯与新入钢坯时间间隔不能超过5小时
                        {
                            xhlM.C_WH_CODE = locD.Rows[0]["C_WH_CODE"].ToString();
                            xhlM.N_TOTAL_QUA = xhlM.N_QUA + int.Parse(locD.Rows[0]["N_TOTAL_QUA"].ToString());
                            xhlM.N_NUM = int.Parse(locD.Rows[0]["N_NUM"].ToString());
                            xhlM.N_CAP = int.Parse(locD.Rows[0]["N_CAP"].ToString());
                            kpResult[i].WhCode = xhlM.C_WH_CODE;
                            kpResult[i].Num = xhlM.N_NUM;
                        }
                        else if (xStrLocs != null && xStrLocs.Count > 0)//使用没有使用过的坑位
                        {
                            xhlM.C_WH_CODE = xStrLocs[0].C_WH_CODE;
                            xhlM.N_TOTAL_QUA = xhlM.N_QUA;
                            xhlM.N_NUM = 1;
                            xhlM.N_CAP = xStrLocs[0].N_CAP_QUA;
                            kpResult[i].WhCode = xhlM.C_WH_CODE;
                            kpResult[i].Num = xhlM.N_NUM;
                        }
                        else if (locMaster != null && locMaster.Rows.Count > 0)//计划n+1次入坑
                        {
                            xhlM.C_WH_CODE = locMaster.Rows[0]["C_WH_CODE"].ToString();
                            xhlM.N_TOTAL_QUA = xhlM.N_QUA;
                            xhlM.N_NUM = int.Parse(locMaster.Rows[0]["N_NUM"].ToString()) + 1;
                            xhlM.N_CAP = int.Parse(locMaster.Rows[0]["N_CAP"].ToString());
                            kpResult[i].WhCode = xhlM.C_WH_CODE;
                            kpResult[i].Num = xhlM.N_NUM;
                        }
                        else//坑满 虚拟坑位
                        {
                            xhlM.C_WH_CODE = "0";
                            kpResult[i].N_STATUS = 0;
                            xhlM.N_TOTAL_QUA = xhlM.N_QUA + dal.GetVirtualXLocMaxQua();
                            xhlM.N_NUM = 0;
                            kpResult[i].WhCode = xhlM.C_WH_CODE;
                            kpResult[i].Num = xhlM.N_NUM;
                        }

                        dal_TPA_HL_PLAN.Add(xhlM);
                        hlPlans.Add(xhlM);
                        #endregion

                        #region 计算修磨时间（需要缓冷）
                        if (kpResult[i].C_XM == "Y")
                        {
                            kpResult[i].D_XM_START_TIME = kpResult[i].D_HL_END_TIME.Value.AddHours(kp_hl);
                            decimal? d = kpResult[i].N_SLAB_WGT / (400 / 24);
                            kpResult[i].D_XM_END_TIME = kpResult[i].D_XM_START_TIME.Value.AddHours((double)d);
                            kpResult[i].CalCulateTimeStart = kpResult[i].D_XM_END_TIME;
                            xmResult.Add(kpResult[i]);
                        }
                        #endregion
                    }
                    else if (kpResult[i].C_XM == "Y")
                    {
                        #region 计算修磨时间
                        kpResult[i].D_XM_START_TIME = kpResult[i].D_KP_END_TIME.Value.AddHours(kp_xm);
                        decimal? d = kpResult[i].N_SLAB_WGT / (400 / 24);
                        kpResult[i].D_XM_END_TIME = kpResult[i].D_XM_START_TIME.Value.AddHours((double)d);
                        kpResult[i].CalCulateTimeStart = kpResult[i].D_XM_END_TIME;
                        xmResult.Add(kpResult[i]);
                        #endregion
                    }
                }

                #region 计算修磨顺序
                xmResult = xmResult.OrderBy(x => x.D_XM_START_TIME)
                      .ToList();
                for (int j = 1; j < xmResult.Count; j++)
                {

                    //如果修磨时间互斥，重新计算修磨时间
                    if (xmResult[j].D_XM_START_TIME < xmResult[j - 1].D_XM_END_TIME)
                    {
                        xmResult[j].D_XM_START_TIME = xmResult[j - 1].D_XM_END_TIME;
                        decimal? d = xmResult[j].N_SLAB_WGT / (400 / 24);
                        xmResult[j].D_XM_END_TIME = xmResult[j].D_XM_START_TIME.Value.AddHours((double)d);
                    }
                }
                xmResult = xmResult.OrderBy(x => x.D_XM_START_TIME)
                    .ToList();

                foreach (var xm in xmResult)
                {
                    Mod_TPA_XM_PLAN xmM = new Mod_TPA_XM_PLAN();
                    xmM.C_ID = Guid.NewGuid().ToString("N");
                    xmM.C_STOVE_NO = xm.C_STOVE_NO;
                    xmM.C_STL_GRD = xm.C_STL_GRD;
                    xmM.C_STD_CODE = xm.C_STD_CODE;
                    xmM.N_WGT = xm.N_SLAB_WGT;
                    xmM.N_CN = xm.N_SLAB_WGT / (400 / 24);
                    xmM.D_PLAN_DATE = xm.D_XM_START_TIME;
                    xmM.D_START_TIME = xm.D_XM_START_TIME;
                    xmM.D_END_TIME = xm.D_XM_END_TIME;
                    xmM.N_STATUS = 0;
                    xmM.C_CCM = xm.C_CCM_DESC;
                    xmM.C_FK = xm.C_ID;
                    xmM.C_XM_TYPE = "碳钢";
                    xmPlans.Add(xmM);
                }


                #endregion

                #region 计算缓冷坑最大出坑时间(小方坯)
                var useDX = dal.GetUsedXLoc();
                if (useDX != null && useDX.Rows.Count > 0)
                {
                    var uCount = useDX.Rows.Count;
                    for (int i = 0; i < uCount; i++)
                    {
                        for (int j = 0; j < int.Parse(useDX.Rows[i]["N_NUM"].ToString()); j++)
                        {
                            var outPitDt = dal.GetOutPitXTime(useDX.Rows[j]["C_WH_CODE"].ToString(), j + 1);
                            if (outPitDt != null && outPitDt.Rows.Count > 0)
                            {
                                int nCount = outPitDt.Rows.Count;
                                for (int n = 0; n < nCount; n++)
                                {
                                    string c_fk = outPitDt.Rows[n]["C_FK"].ToString();
                                    DateTime overtime = DateTime.Parse(outPitDt.Rows[n]["D_OVER_TIME"].ToString());
                                    var resetOutTimes = smsModels.Where(x => x.C_ID == c_fk).ToList();
                                    if (resetOutTimes.Count > 0)
                                        resetOutTimes[0].D_HL_END_TIME = overtime;
                                }
                            }
                        }
                    }
                }
                #endregion
                TransactionHelper.BeginTransaction();

                foreach (var kpPlan in kpPlans)
                {
                    if (!dal_TPA_KP_PLAN.TranAdd(kpPlan))
                    {
                        TransactionHelper.RollBack();
                        dal.DelDfpHl(dhlPlans);
                        dal.DelHl(hlPlans);
                        processResult = smsModels;
                        return "0";
                    }
                }

                foreach (var xmPlan in xmPlans)
                {
                    if (!dal_TPA_XM_PLAN.TranAdd(xmPlan))
                    {
                        TransactionHelper.RollBack();
                        dal.DelDfpHl(dhlPlans);
                        dal.DelHl(hlPlans);
                        processResult = smsModels;
                        return "0";
                    }
                }

                if (!dal.DelSms(smsModels))
                {
                    TransactionHelper.RollBack();
                    dal.DelDfpHl(dhlPlans);
                    dal.DelHl(hlPlans);
                    processResult = smsModels;
                    return "0";
                }

                foreach (var sms in smsModels)
                {
                    sms.N_CREAT_PLAN = 2;
                    if (!dal_TSP_PLAN_SMS.TranAdd(sms))
                    {
                        TransactionHelper.RollBack();
                        dal.DelDfpHl(dhlPlans);
                        dal.DelHl(hlPlans);
                        processResult = smsModels;
                        return "0";
                    }
                }

                TransactionHelper.Commit();

                processResult = kpResult;
            }
            catch (Exception e)
            {
                TransactionHelper.RollBack();
                dal.DelDfpHl(dhlPlans);
                dal.DelHl(hlPlans);
                processResult = kpResult;
                return "0";
            }
            return result;

        }
    }
}
