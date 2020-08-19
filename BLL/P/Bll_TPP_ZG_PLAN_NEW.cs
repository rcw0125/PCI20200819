using System;
using System.Data;
using System.Collections.Generic;
using DAL;
using MODEL;
using System.Reflection;
using System.Linq;
using System.IO;
using System.Xml.Serialization;

namespace BLL
{
    /// <summary>
    /// 线材排产
    /// </summary>
    public partial class Bll_TPP_ZG_PLAN_NEW
    {
        private Dal_TSP_PLAN_SMS_TEST dalTspPlanSmsTest = new Dal_TSP_PLAN_SMS_TEST();//炼钢计划
        private Dal_TRP_PLAN_ROLL_TEST dalTrpPlanRollTest = new Dal_TRP_PLAN_ROLL_TEST();//轧钢计划
        private Dal_TRP_PLAN_ITEM_TEST dalTrpPlanItemTest = new Dal_TRP_PLAN_ITEM_TEST();//轧钢计划子表
        private Dal_TPB_CHANGESPEC_TIME dalChangeTime = new Dal_TPB_CHANGESPEC_TIME();//换规格时间
        private Dal_TPP_LGPC_LSB_TEST dalTppLgpcLsbTest = new Dal_TPP_LGPC_LSB_TEST();//浇次计划临时表
        private Dal_TPP_LGPC_LCLSB_TEST dalTppLgpcLclsbTest = new Dal_TPP_LGPC_LCLSB_TEST();//炉次计划临时表
        private Dal_TSP_CAST_PLAN_TEST dalTspCastPlanTest = new Dal_TSP_CAST_PLAN_TEST();//浇次计划实绩表
        private Dal_TPP_TURNAROUND_PLAN dalTjPlan = new Dal_TPP_TURNAROUND_PLAN();//停机计划表

        private Dal_TSP_PLAN_SMS dalTspPlanSms = new Dal_TSP_PLAN_SMS();
        //private Dal_TRP_PLAN_ROLL dalTrpPlanRoll = new Dal_TRP_PLAN_ROLL();//轧钢计划
        //private Dal_TRP_PLAN_ITEM dalTrpPlanItem = new Dal_TRP_PLAN_ITEM();//轧钢计划子表

        private Bll_TRP_PLAN_ROLL_TEST bllTrpPlanRollTest = new Bll_TRP_PLAN_ROLL_TEST();//轧钢计划
        private Bll_TRP_PLAN_ITEM_TEST bllTrpPlanItemTest = new Bll_TRP_PLAN_ITEM_TEST();//轧钢计划
        private Bll_TSP_PLAN_SMS_TEST bllTspPlanSmsTest = new Bll_TSP_PLAN_SMS_TEST();//炼钢计划
        private Bll_TPP_LGPC_LCLSB_TEST bllTppLgpcLclsbTest = new Bll_TPP_LGPC_LCLSB_TEST();//炉次计划临时表
        private Bll_TPP_LGPC_LSB_TEST bllTppLgpcLsbTest = new Bll_TPP_LGPC_LSB_TEST();//炉次计划临时表
        private Bll_TPP_TURNAROUND_PLAN bllTJPlan = new Bll_TPP_TURNAROUND_PLAN();//停机计划信息

        private Dal_TRP_PLAN_SLAB_TIME dalTrpSlabTime = new Dal_TRP_PLAN_SLAB_TIME();

        public Bll_TPP_ZG_PLAN_NEW()
        { }

        #region 计算轧钢计划时间

        private int faliNum = 0;//没有找到轧钢计划次数
        private List<CastInfo> lst_Cast;//按可排产订单的剩余量(按钢种、标准汇总)
        private List<CastInfo> lst_Temp;//按可排产订单的剩余量(按钢种、标准汇总)（临时）
        private List<Mod_TRP_PLAN_ROLL_TEST> lstPlanRoll;//轧钢计划信息
        private List<Mod_TSP_PLAN_SMS_TEST> lstPlanSlab;//炼钢计划信息 
        private List<Mod_TPP_LGPC_LSB_TEST> lstJCLsb;//浇次临时表信息
        private List<Mod_TPP_LGPC_LCLSB_TEST> lstLcLsb;//炉次临时表信息
        private List<Mod_TRP_PLAN_ITEM_TEST> lstPlanItem;//轧钢计划明细表
        private List<Mod_TPP_TURNAROUND_PLAN> lstTJ;//停机计划信息

        private List<LineSpec> lst_LineSpec;//可排轧钢产线规格
        private List<ZGLine> lstLine;//可排轧钢产线规格
        private List<LineSpec> lst_Spec = new List<LineSpec>();//可排轧钢产线规格
        private List<SlabPlan> lst_SlabPlan = new List<SlabPlan>();//炼钢计划临时信息        

        private string timeCC = ""; //钢坯可用时间

        /// <summary>
        /// 浇次基本信息类
        /// </summary>
        class CastInfo
        {
            private string _c_stl_grd; //钢种
            private string _c_std_code; //执行标准
            private decimal _n_wgt; //重量
            private string _c_spec;//规格
            private string _c_lind_code;//轧线

            public CastInfo(string C_STL_GRD, string C_STD_CODE, decimal N_WGT, string C_SPEC, string C_LINE_CODE)
            {
                this._c_stl_grd = C_STL_GRD;
                this._c_std_code = C_STD_CODE;
                this._n_wgt = N_WGT;
                this._c_spec = C_SPEC;
                this._c_lind_code = C_LINE_CODE;
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

            public string C_SPEC
            {
                get { return _c_spec; }
                set { _c_spec = value; }
            }

            public string C_LINE_CODE
            {
                get { return _c_lind_code; }
                set { _c_lind_code = value; }
            }
        }

        /// <summary>
        /// 浇次基本信息类
        /// </summary>
        class CastInfo_Old
        {
            private string _c_stl_grd; //钢种
            private string _c_std_code; //执行标准
            private decimal _n_wgt; //重量

            public CastInfo_Old(string C_STL_GRD, string C_STD_CODE, decimal N_WGT)
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
        /// 可排产轧线规格
        /// </summary>
        class LineSpec
        {
            private string _c_line_code; //轧线
            private string _c_spec; //规格
            private string _c_time; //可开轧时间

            public LineSpec(string C_LINE_CODE, string C_SPEC, string C_TIME)
            {
                this._c_line_code = C_LINE_CODE;
                this._c_spec = C_SPEC;
                this._c_time = C_TIME;
            }

            public string C_LINE_CODE
            {
                get { return _c_line_code; }
                set { _c_line_code = value; }
            }

            public string C_SPEC
            {
                get { return _c_spec; }
                set { _c_spec = value; }
            }

            public string C_TIME
            {
                get { return _c_time; }
                set { _c_time = value; }
            }
        }

        /// <summary>
        /// 可排产轧线规格
        /// </summary>
        class ZGLine
        {
            private string _c_line_code; //轧线

            public ZGLine(string C_LINE_CODE)
            {
                this._c_line_code = C_LINE_CODE;
            }

            public string C_LINE_CODE
            {
                get { return _c_line_code; }
                set { _c_line_code = value; }
            }
        }

        /// <summary>
        /// 可轧重量规格
        /// </summary>
        class SpecWgt
        {
            private string _c_spec; //规格
            private decimal _n_wgt; //重量
            private string _c_lind_code;//轧线
            private string _c_time; //可开轧时间

            public SpecWgt(string C_SPEC, decimal N_Wgt, string C_LINE_CODE, string C_TIME)
            {
                this._c_spec = C_SPEC;
                this._n_wgt = N_Wgt;
                this._c_lind_code = C_LINE_CODE;
                this._c_time = C_TIME;
            }

            public string C_SPEC
            {
                get { return _c_spec; }
                set { _c_spec = value; }
            }

            public decimal N_WGT
            {
                get { return _n_wgt; }
                set { _n_wgt = value; }
            }

            public string C_LINE_CODE
            {
                get { return _c_lind_code; }
                set { _c_lind_code = value; }
            }

            public string C_TIME
            {
                get { return _c_time; }
                set { _c_time = value; }
            }
        }

        /// <summary>
        /// 炼钢计划临时信息
        /// </summary>
        class SlabPlan
        {
            private decimal _n_wgt; //重量
            private string _c_plan_id;//炼钢计划ID

            public SlabPlan(decimal N_Wgt, string C_PLAN_ID)
            {
                this._n_wgt = N_Wgt;
                this._c_plan_id = C_PLAN_ID;
            }

            public decimal N_WGT
            {
                get { return _n_wgt; }
                set { _n_wgt = value; }
            }

            public string C_PLAN_ID
            {
                get { return _c_plan_id; }
                set { _c_plan_id = value; }
            }
        }

        /// <summary>
        /// 复制list
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static T CopyList<T>(T obj)
        {
            object retval;
            using (MemoryStream ms = new MemoryStream())
            {
                XmlSerializer xml = new XmlSerializer(typeof(T));
                xml.Serialize(ms, obj);
                ms.Seek(0, SeekOrigin.Begin);
                retval = xml.Deserialize(ms);
                ms.Close();
            }
            return (T)retval;
        }

        /// <summary>
        /// 生成轧钢计划时间
        /// </summary>
        /// <param name="strType">0-没有指定计划；1-有指定计划</param>
        /// <param name="strLine">轧线</param>
        /// <param name="strGZ">钢种</param>
        /// <param name="strBZ">标准</param>
        /// <param name="strGG">规格</param>
        /// <param name="strPlanID">计划ID</param>
        /// <returns></returns>
        public string Update_ZG_Plan_New(string strType, string strLine, string strGG, string strGzBz)
        {
            try
            {
                string result = "成功";

                TransactionHelper.BeginTransaction();

                string strUserID = RV.UI.UserInfo.userID;

                bool IsComplete = false;

                lst_Temp = new List<CastInfo>();
                lst_Cast = new List<CastInfo>();
                lst_LineSpec = new List<LineSpec>();
                lstLine = new List<ZGLine>();

                lstPlanRoll = new List<Mod_TRP_PLAN_ROLL_TEST>();//轧钢计划信息
                lstPlanSlab = new List<Mod_TSP_PLAN_SMS_TEST>();//炼钢计划信息 
                lstJCLsb = new List<Mod_TPP_LGPC_LSB_TEST>();//浇次临时表信息
                lstLcLsb = new List<Mod_TPP_LGPC_LCLSB_TEST>();//炉次临时表信息
                lstPlanItem = new List<Mod_TRP_PLAN_ITEM_TEST>();//轧钢计划明细表
                lstTJ = new List<Mod_TPP_TURNAROUND_PLAN>();//停机计划信息

                #region 初始化

                string sms = dalTspPlanSms.TB_LG_PLAN_WGT();//初始化炼钢可用量

                if (sms == "失败")
                {
                    TransactionHelper.RollBack();
                    return "炼钢可用量初始化失败！";
                }

                #region 插入中间表

                string s_result = dalTspPlanSms.PLAN_INITIALIZE();//初始化排产数据
                if (s_result == "失败")
                {
                    TransactionHelper.RollBack();
                    return "初始化排产数据失败！";
                }

                //dalTrpPlanRollTest.Update_Trans();//将轧钢计划初始化

                #endregion

                #endregion

                lstTJ = bllTJPlan.DataTableToList(dalTjPlan.GetList().Tables[0]);//停机计划信息

                lstPlanRoll = bllTrpPlanRollTest.DataTableToList(dalTrpPlanRollTest.Get_Plan_Roll_Trans().Tables[0]);//轧钢计划信息 

                lstPlanSlab = bllTspPlanSmsTest.DataTableToList(dalTspPlanSmsTest.Get_Slab_List_Trans("", "").Tables[0]);//炼钢计划信息

                lstLcLsb = bllTppLgpcLclsbTest.DataTableToList(dalTppLgpcLclsbTest.Get_LC_List_Trans().Tables[0]);//炉次临时表信息

                lstJCLsb = bllTppLgpcLsbTest.DataTableToList(dalTppLgpcLsbTest.Get_JC_List_Trans().Tables[0]);//浇次临时表信息

                var lstSpecTemp = lstPlanRoll.GroupBy(x => new { x.C_SPEC_PC, x.C_LINE_CODE }).OrderBy(x => Convert.ToDouble(x.Key.C_SPEC_PC.Substring(1))).ToList();

                for (int i = 0; i < lstSpecTemp.Count; i++)
                {
                    LineSpec ls = new LineSpec(lstSpecTemp[i].Key.C_LINE_CODE, lstSpecTemp[i].Key.C_SPEC_PC, "");
                    lst_Spec.Add(ls);
                }

                for (int i = 0; i < lstJCLsb.Count; i++)
                {
                    lstJCLsb[i].N_SORT = 0;
                }

                if (lstPlanSlab.Count == 0)
                {
                    return "没有可排轧钢计划！";
                }

                if (lstPlanRoll.Count == 0)
                {
                    return "没有可排轧钢计划！";
                }

                #region 先排指定的计划
                if (strType == "1")
                {
                    decimal resultZD = Update_Slab_Wgt_ZD(strLine, strGG, strGzBz);

                    if (resultZD == decimal.MinValue || resultZD == 0)
                    {
                        TransactionHelper.RollBack();
                        return "计划调整失败";
                    }
                }
                else
                {
                    var lstZGTemp = lstPlanRoll.Where(x => x.N_ROLL_PROD_WGT < x.N_WGT && x.N_STATUS == 1).ToList();
                    var lstZGLine = lstZGTemp.GroupBy(x => new { x.C_LINE_CODE }).OrderBy(x => x.Key.C_LINE_CODE).ToList();

                    for (int i = 0; i < lstZGLine.Count; i++)
                    {
                        ZGLine zgline = new ZGLine(lstZGLine[i].Key.C_LINE_CODE);
                        lstLine.Add(zgline);
                    }

                    result = Check_Plan_YP(lstLine);

                    result = Update_Plan_Time();

                    if (result != "1")
                    {
                        IsComplete = true;
                    }
                    else
                    {
                        result = "成功";
                    }
                }
                #endregion

                while (!IsComplete)
                {
                    lstLine.Clear();
                    var lstZG = lstPlanRoll.Where(x => x.N_ROLL_PROD_WGT < x.N_WGT && (x.N_STATUS == 0 || x.N_STATUS == 1)).ToList();

                    var lstZGLine = lstZG.GroupBy(x => new { x.C_LINE_CODE }).OrderBy(x => x.Key.C_LINE_CODE).ToList();

                    var lstLG = lstPlanSlab.Where(x => x.N_USE_WGT > 0).ToList();

                    if (lstZG.Count == 0 || lstLG.Count == 0)
                    {
                        result = "成功";
                        IsComplete = true;
                    }
                    else
                    {
                        int count = 0;
                        for (int i = 0; i < lstZG.Count; i++)
                        {
                            //count = lstLG.Where(x => x.C_STD_CODE == lstZG[i].C_STD_CODE && x.C_STL_GRD == lstZG[i].C_STL_GRD).ToList().Count;
                            count = lstLG.Where(x => lstZG[i].C_REMARK5.Contains(x.C_STL_GRD + "|" + x.C_STD_CODE)).ToList().Count;
                            if (count > 0)
                            {
                                break;
                            }
                        }

                        if (count == 0)
                        {
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
                        }
                    }

                    for (int i = 0; i < lstZGLine.Count; i++)
                    {
                        ZGLine zgline = new ZGLine(lstZGLine[i].Key.C_LINE_CODE);
                        lstLine.Add(zgline);
                    }

                    result = Check_Plan_New(lstLine);//检测是否有可排轧钢计划（0-没有可排轧钢计划；1-有可排轧钢计划；其他-出错）

                    if (result == "0")//没有找到可轧计划
                    {
                        faliNum++;

                        if (faliNum == 1)
                        {
                            #region 计算下发3#CC、4#CC具体浇次

                            result = Get_Cast_Plan2();//0-未找到浇次;1-成功；其他-失败
                            if (result == "0")
                            {
                                faliNum++;
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

                            var lstPlanRoll_Temp = lstPlanRoll.Where(x => (x.N_STATUS == 0 || x.N_STATUS == 1) && x.N_ROLL_PROD_WGT < x.N_WGT).ToList();

                            var lstPlanSlab_Temp = lstPlanSlab.Where(X => X.N_USE_WGT > 0 && !string.IsNullOrEmpty(X.D_CAN_USE_TIME.ToString())).OrderBy(x => x.D_CAN_USE_TIME).ToList();

                            if (lstPlanSlab_Temp.Count > 0)
                            {
                                for (int i = 0; i < lstPlanSlab_Temp.Count; i++)
                                {
                                    //int count = lstPlanRoll_Temp.Where(x => x.C_STD_CODE == lstPlanSlab_Temp[i].C_STD_CODE && x.C_STL_GRD == lstPlanSlab_Temp[i].C_STL_GRD).ToList().Count;

                                    int count = lstPlanRoll_Temp.Where(x => x.C_REMARK5.Contains(lstPlanSlab_Temp[i].C_STL_GRD + "|" + lstPlanSlab_Temp[i].C_STD_CODE)).ToList().Count;

                                    if (count > 0)
                                    {
                                        timeCC = lstPlanSlab_Temp[i].D_CAN_USE_TIME.ToString();

                                        result = Check_Plan_New(lstLine);//检测是否有可排轧钢计划（0-没有可排轧钢计划；1-有可排轧钢计划；其他-出错）
                                        if (result == "0")
                                        {
                                            continue;
                                        }
                                        else if (result == "1")
                                        {
                                            num++;
                                            break;
                                        }
                                        else
                                        {
                                            IsComplete = true;
                                        }
                                    }
                                }

                                if (num == 0)
                                {
                                    #region 计算下发3#CC、4#CC具体浇次

                                    result = Get_Cast_Plan2();//0-未找到浇次;1-成功；其他-失败
                                    if (result == "0")
                                    {
                                        result = Get_Cast_Plan3();//0-未找到浇次;1-成功；其他-失败
                                        if (result == "0")
                                        {
                                            result = "成功";
                                            IsComplete = true;
                                        }
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
                                    //IsComplete = true;
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

                        result = Update_Plan_Time();

                        if (result != "1")
                        {
                            IsComplete = true;
                            //result = "成功";
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
                        //result = "成功";
                    }
                }

                if (result == "成功")
                {
                    #region 将list数据更新到数据库

                    //炉次临时表信息删除
                    for (int i = 0; i < lstLcLsb.Count; i++)
                    {
                        if (lstLcLsb[i].N_STATUS == 0)
                        {
                            if (!dalTppLgpcLclsbTest.Delete_Trans(lstLcLsb[i].C_ID))
                            {
                                TransactionHelper.RollBack();
                                return "炉次临时表信息删除失败！";
                            }
                        }
                    }

                    dalTppLgpcLsbTest.Delete_Trans();//删除浇次临时表信息

                    for (int i = 0; i < lstJCLsb.Count; i++)
                    {
                        if (lstJCLsb[i].N_STATUS == 1)
                        {
                            #region 实体赋值
                            Mod_TSP_CAST_PLAN_TEST model = new Mod_TSP_CAST_PLAN_TEST();
                            model.C_ID = lstJCLsb[i].C_ID;
                            model.C_CCM_ID = lstJCLsb[i].C_CCM_ID;
                            model.C_CCM_CODE = lstJCLsb[i].C_CCM_CODE;
                            model.N_GROUP = lstJCLsb[i].N_GROUP;
                            model.N_TOTAL_WGT = lstJCLsb[i].N_TOTAL_WGT;
                            model.N_ZJCLS = lstJCLsb[i].N_ZJCLS;
                            model.N_ZJCLZL = lstJCLsb[i].N_ZJCLZL;
                            model.N_MLZL = lstJCLsb[i].N_MLZL;
                            model.N_SORT = lstJCLsb[i].N_SORT;
                            model.C_STL_GRD = lstJCLsb[i].C_STL_GRD;
                            model.N_PRODUCE_TIME = lstJCLsb[i].N_PRODUCE_TIME;
                            model.N_JSCN = lstJCLsb[i].N_JSCN;
                            model.C_BY1 = lstJCLsb[i].C_BY1;
                            model.C_BY2 = lstJCLsb[i].C_BY2;
                            model.C_BY3 = lstJCLsb[i].C_BY3;
                            model.C_RH = lstJCLsb[i].C_RH;
                            model.C_DFP_HL = lstJCLsb[i].C_DFP_HL;
                            model.C_HL = lstJCLsb[i].C_HL;
                            model.C_XM = lstJCLsb[i].C_XM;
                            model.N_ORDER_LS = lstJCLsb[i].N_ORDER_LS;
                            model.D_DFPHL_START_TIME = lstJCLsb[i].D_DFPHL_START_TIME;
                            model.D_DFPHL_END_TIME = lstJCLsb[i].D_DFPHL_END_TIME;
                            model.D_KP_START_TIME = lstJCLsb[i].D_KP_START_TIME;
                            model.D_KP_END_TIME = lstJCLsb[i].D_KP_END_TIME;
                            model.D_HL_START_TIME = lstJCLsb[i].D_HL_START_TIME;
                            model.D_HL_END_TIME = lstJCLsb[i].D_HL_END_TIME;
                            model.D_PLAN_KY_TIME = lstJCLsb[i].D_PLAN_KY_TIME;
                            model.C_PLAN_ROLL = lstJCLsb[i].C_PLAN_ROLL;
                            model.D_ZZ_START_TIME = lstJCLsb[i].D_ZZ_START_TIME;
                            model.D_ZZ_END_TIME = lstJCLsb[i].D_ZZ_END_TIME;
                            model.D_XM_START_TIME = lstJCLsb[i].D_XM_START_TIME;
                            model.D_XM_END_TIME = lstJCLsb[i].D_XM_END_TIME;
                            model.C_STD_CODE = lstJCLsb[i].C_STD_CODE;
                            model.C_SLAB_TYPE = lstJCLsb[i].C_SLAB_TYPE;
                            model.C_STL_GRD_TYPE = lstJCLsb[i].C_STL_GRD_TYPE;
                            model.C_PROD_NAME = lstJCLsb[i].C_PROD_NAME;
                            model.C_PROD_KIND = lstJCLsb[i].C_PROD_KIND;
                            model.N_DFP_HL_TIME = lstJCLsb[i].N_DFP_HL_TIME;
                            model.N_HL_TIME = lstJCLsb[i].N_HL_TIME;
                            model.N_XM_TIME = lstJCLsb[i].N_XM_TIME;
                            model.N_GG = lstJCLsb[i].N_GG;
                            model.N_CCM_TIME = lstJCLsb[i].N_CCM_TIME;
                            model.C_TJ_REMARK = lstJCLsb[i].C_TJ_REMARK;
                            model.C_TL = lstJCLsb[i].C_TL;
                            model.N_RH = lstJCLsb[i].N_RH;
                            model.N_TL = lstJCLsb[i].N_TL;
                            model.N_GZSL = lstJCLsb[i].N_GZSL;
                            model.C_REMARK = lstJCLsb[i].C_REMARK;
                            model.N_XM = lstJCLsb[i].N_XM;
                            model.N_DHL = lstJCLsb[i].N_DHL;
                            model.N_HL = lstJCLsb[i].N_HL;
                            model.N_STATUS = 1;
                            model.D_P_START_TIME = lstJCLsb[i].D_P_START_TIME;
                            model.D_P_END_TIME = lstJCLsb[i].D_P_END_TIME;
                            model.N_DFP_RZ = lstJCLsb[i].N_DFP_RZ;
                            model.N_RZP_RZ = lstJCLsb[i].N_RZP_RZ;
                            model.C_RH_SFJS = lstJCLsb[i].C_RH_SFJS;
                            #endregion

                            if (!dalTspCastPlanTest.Add_Trans(model))
                            {
                                TransactionHelper.RollBack();
                                return "浇次信息添加失败！";
                            }
                        }
                    }

                    //轧钢计划明细表
                    for (int i = 0; i < lstPlanItem.Count; i++)
                    {
                        if (!dalTrpPlanItemTest.Add_Trans(lstPlanItem[i]))
                        {
                            TransactionHelper.RollBack();
                            return "轧钢计划明细更新失败！";
                        }
                    }

                    //轧钢计划表
                    for (int i = 0; i < lstPlanRoll.Count; i++)
                    {
                        if (!dalTrpPlanRollTest.Update_ZG_Trans(lstPlanRoll[i].C_ID, Convert.ToDecimal(lstPlanRoll[i].N_ROLL_PROD_WGT), lstPlanRoll[i].D_P_START_TIME.ToString(), lstPlanRoll[i].D_P_END_TIME.ToString()))
                        {
                            TransactionHelper.RollBack();
                            return "轧钢计划更新失败！";
                        }
                    }

                    //炼钢计划表
                    for (int i = 0; i < lstPlanSlab.Count; i++)
                    {
                        dalTspPlanSmsTest.Delete_Trans(lstPlanSlab[i].C_ID);
                    }

                    //炼钢计划表
                    for (int i = 0; i < lstPlanSlab.Count; i++)
                    {
                        if (!dalTspPlanSmsTest.Add_Trans(lstPlanSlab[i]))
                        {
                            TransactionHelper.RollBack();
                            return "炼钢计划更新失败！";
                        }
                    }

                    #endregion

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
        private string Check_Plan_New(List<ZGLine> lstLine)
        {
            try
            {
                lst_LineSpec.Clear();

                var lstSLAB = CopyList(lstPlanSlab);

                List<SpecWgt> lstSpecWgt = new List<SpecWgt>();
                List<CastInfo> lstCastTemp = new List<CastInfo>();

                string result = "0";

                decimal wgt_sd = 0;
                decimal wgt_kz = 0;
                string strSpec = "";

                lst_Cast.Clear();

                for (int i_Line = 0; i_Line < lstLine.Count; i_Line++)
                {
                    DateTime time_KZ = RV.UI.ServerTime.timeNow();
                    strSpec = "";
                    string timeSlab = lstSLAB.Where(x => x.N_USE_WGT > 0).Min(x => x.D_CAN_USE_TIME).ToString();
                    List<LineSpec> lstSpec = new List<LineSpec>();
                    string strLineCode = lstLine[i_Line].C_LINE_CODE;
                    var lst_Spec_Temp = lst_Spec.Where(x => x.C_LINE_CODE == strLineCode).ToList();
                    lst_SlabPlan.Clear();
                    lstCastTemp.Clear();
                    wgt_sd = 600;

                    #region 判断是否有前置计划

                    var lstUp = lstPlanRoll.Where(x => x.C_LINE_CODE == strLineCode && !string.IsNullOrEmpty(x.D_P_END_TIME.ToString())).ToList();

                    if (lstUp.Count > 0)
                    {
                        lstUp = lstUp.OrderByDescending(x => Convert.ToDateTime(x.D_P_END_TIME)).ToList();

                        strSpec = lstUp[0].C_SPEC;//上一个计划规格

                        if (lstUp.Count == 1)//只有一个前置计划
                        {
                            lstSpec.AddRange(lst_Spec_Temp.Where(x => Convert.ToDouble(x.C_SPEC.Substring(1)) >= Convert.ToDouble(strSpec.Substring(1))));//获取未排产的产线规格(从小到大)
                            lstSpec.AddRange(lst_Spec_Temp.Where(x => Convert.ToDouble(x.C_SPEC.Substring(1)) < Convert.ToDouble(strSpec.Substring(1))));//获取未排产的产线规格(从大到小)
                        }
                        else if (lstUp.Count >= 2)//有两个前置计划
                        {
                            if (Convert.ToDouble(lstUp[0].C_SPEC.Substring(1)) >= Convert.ToDouble(lstUp[1].C_SPEC.Substring(1)))
                            {
                                lstSpec.AddRange(lst_Spec_Temp.Where(x => Convert.ToDouble(x.C_SPEC.Substring(1)) >= Convert.ToDouble(strSpec.Substring(1))).OrderBy(a => Convert.ToDouble(a.C_SPEC.Substring(1))));//获取未排产的产线规格(从小到大)
                                lstSpec.AddRange(lst_Spec_Temp.Where(x => Convert.ToDouble(x.C_SPEC.Substring(1)) < Convert.ToDouble(strSpec.Substring(1))).OrderByDescending(a => Convert.ToDouble(a.C_SPEC.Substring(1))));//获取未排产的产线规格(从大到小)
                            }
                            else
                            {
                                lstSpec.AddRange(lst_Spec_Temp.Where(x => Convert.ToDouble(x.C_SPEC.Substring(1)) < Convert.ToDouble(strSpec.Substring(1))).OrderByDescending(a => Convert.ToDouble(a.C_SPEC.Substring(1))));//获取未排产的产线规格(从大到小)
                                lstSpec.AddRange(lst_Spec_Temp.Where(x => Convert.ToDouble(x.C_SPEC.Substring(1)) >= Convert.ToDouble(strSpec.Substring(1))).OrderBy(a => Convert.ToDouble(a.C_SPEC.Substring(1))));//获取未排产的产线规格(从小到大)
                            }
                        }
                    }
                    else if (lstUp.Count == 0)//没有前置计划
                    {
                        lstSpec = lst_Spec_Temp;

                        //if (strLineCode == "1#ZX" && !string.IsNullOrEmpty(timeStartCSH))
                        //{
                        //    time_KZ = Convert.ToDateTime(timeStartCSH);
                        //}
                    }

                    if (lstSpec.Count == 0)//没有找到可排轧钢计划的规格
                    {
                        continue;
                    }

                    #endregion


                    #region 还剩可轧规格
                    var lstPlanRoll_Temp = lstPlanRoll.Where(x => (x.N_STATUS == 0 || x.N_STATUS == 1) && x.C_LINE_CODE == strLineCode && x.N_ROLL_PROD_WGT < x.N_WGT).GroupBy(x => new { x.C_SPEC_PC }).Select(a => new { a.Key.C_SPEC_PC, N_wgt = a.Sum(b => b.N_WGT - b.N_ROLL_PROD_WGT) }).ToList();

                    if (lstPlanRoll_Temp.Count == 0)
                    {
                        continue;
                    }

                    string sSpce = "";
                    for (int i = 0; i < lstPlanRoll_Temp.Count; i++)
                    {
                        sSpce = sSpce + lstPlanRoll_Temp[i].C_SPEC_PC + ",";
                    }
                    #endregion

                    for (int i_Spec = 0; i_Spec < lstSpec.Count; i_Spec++)
                    {
                        if (!sSpce.Contains(lstSpec[i_Spec].C_SPEC))
                        {
                            continue;
                        }

                        int hggTime = dalChangeTime.Get_Time(strLineCode, strSpec, lstSpec[i_Spec].C_SPEC);//换规格时间

                        if (lstUp.Count > 0)
                        {
                            time_KZ = Convert.ToDateTime(lstUp[0].D_P_END_TIME.ToString());//上一个计划结束时间
                            time_KZ = time_KZ.AddMinutes(hggTime);
                        }

                        #region 计划检修
                        var lstJX = lstTJ.Where(x => x.C_STA_CODE == strLineCode && time_KZ >= x.D_START_TIME && time_KZ < x.D_END_TIME).ToList();
                        if (lstJX.Count > 0)
                        {
                            TimeSpan ts = Convert.ToDateTime(lstJX[0].D_END_TIME) - Convert.ToDateTime(lstJX[0].D_START_TIME);
                            //time_KZ = Convert.ToDateTime(lstJX[0].D_END_TIME);

                            time_KZ = time_KZ.AddHours(ts.Hours);
                        }
                        #endregion

                        if (!string.IsNullOrEmpty(timeCC))
                        {
                            if (time_KZ < Convert.ToDateTime(timeCC))
                            {
                                time_KZ = Convert.ToDateTime(timeCC);
                            }
                        }

                        if (Convert.ToDateTime(time_KZ) < Convert.ToDateTime(timeSlab))
                        {
                            continue;
                        }

                        lst_Temp.Clear();

                        string strError = "";
                        wgt_kz = Get_Slab_Wgt_New(strLineCode, lstSpec[i_Spec].C_SPEC, time_KZ.ToString(), out lst_Temp, lstSLAB, out strError);

                        if (strError == "正常")
                        {
                            if (wgt_kz == 0)
                            {
                                continue;
                            }
                            else
                            {
                                if (strLineCode == "3#ZX" && lstSpec[i_Spec].C_SPEC == "φ30")
                                {
                                    if (wgt_kz >= 1500)
                                    {
                                        SpecWgt sw = new SpecWgt(lstSpec[i_Spec].C_SPEC, wgt_kz, strLineCode, time_KZ.ToString());
                                        lstSpecWgt.Add(sw);
                                    }
                                    else
                                    {
                                        continue;
                                    }
                                }
                                else
                                {
                                    SpecWgt sw = new SpecWgt(lstSpec[i_Spec].C_SPEC, wgt_kz, strLineCode, time_KZ.ToString());
                                    lstSpecWgt.Add(sw);
                                }

                                bool isFind = false;
                                for (int mm = 0; mm < lst_Temp.Count; mm++)
                                {
                                    isFind = false;
                                    if (lstCastTemp.Count == 0)
                                    {
                                        lstCastTemp.Add(lst_Temp[mm]);
                                        continue;
                                    }
                                    else
                                    {
                                        for (int jcNum = 0; jcNum < lstCastTemp.Count; jcNum++)
                                        {
                                            if (lst_Temp[mm].C_STL_GRD == lstCastTemp[jcNum].C_STL_GRD && lst_Temp[mm].C_STD_CODE == lstCastTemp[jcNum].C_STD_CODE && lst_Temp[mm].C_SPEC == lstCastTemp[jcNum].C_SPEC && lst_Temp[mm].C_LINE_CODE == lstCastTemp[jcNum].C_LINE_CODE)
                                            {
                                                isFind = true;
                                                lstCastTemp[jcNum].N_WGT = lstCastTemp[jcNum].N_WGT + lst_Temp[mm].N_WGT;
                                                break;
                                            }
                                            else
                                            {
                                                continue;
                                            }
                                        }

                                        if (!isFind)
                                        {
                                            lstCastTemp.Add(lst_Temp[mm]);
                                        }
                                    }
                                }

                                if (wgt_kz > wgt_sd)
                                {
                                    break;
                                }
                            }
                        }
                        else
                        {
                            return strError;
                            //return "1";
                        }
                    }


                    #region 查找符合的计划

                    var lst = lstSpecWgt.Where(x => x.C_LINE_CODE == lstLine[i_Line].C_LINE_CODE).ToList();
                    if (lst.Count > 0)
                    {
                        result = "1";

                        lst = lst.OrderByDescending(x => x.N_WGT).ToList();

                        LineSpec lineSpec = new LineSpec(strLineCode, lst[0].C_SPEC, lst[0].C_TIME);
                        lst_LineSpec.Add(lineSpec);

                        for (int i = 0; i < lst_SlabPlan.Count; i++)
                        {
                            for (int j = 0; j < lstSLAB.Count; j++)
                            {
                                if (lst_SlabPlan[i].C_PLAN_ID == lstSLAB[j].C_ID)
                                {
                                    lstSLAB[j].N_USE_WGT = lst_SlabPlan[i].N_WGT;
                                    break;
                                }
                            }
                        }

                        bool isFind = false;
                        for (int mm = 0; mm < lstCastTemp.Count; mm++)
                        {
                            isFind = false;
                            if (lst_Cast.Count == 0)
                            {
                                lst_Cast.Add(lstCastTemp[mm]);
                                continue;
                            }
                            else
                            {
                                for (int jcNum = 0; jcNum < lst_Cast.Count; jcNum++)
                                {
                                    if (lstCastTemp[mm].C_STL_GRD == lst_Cast[jcNum].C_STL_GRD && lstCastTemp[mm].C_STD_CODE == lst_Cast[jcNum].C_STD_CODE && lstCastTemp[mm].C_SPEC == lst_Cast[jcNum].C_SPEC && lstCastTemp[mm].C_LINE_CODE == lst_Cast[jcNum].C_LINE_CODE)
                                    {
                                        isFind = true;
                                        lst_Cast[jcNum].N_WGT = lst_Cast[jcNum].N_WGT + lstCastTemp[mm].N_WGT;
                                        break;
                                    }
                                    else
                                    {
                                        continue;
                                    }
                                }

                                if (!isFind)
                                {
                                    lst_Cast.Add(lstCastTemp[mm]);
                                }
                            }
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
        /// 更新轧钢计划
        /// </summary>
        /// <param name="dt_Line">轧线</param>
        /// <returns>1-计划更新成功；其他-出错</returns>
        private string Update_Plan_Time()
        {
            #region 更新计划

            try
            {
                string result = "0";

                string strRe = "";
                lst_Cast.Clear();

                int num = 0;

                for (int i_Line = 0; i_Line < lst_LineSpec.Count; i_Line++)
                {
                    strRe = Update_Slab_Wgt(lst_LineSpec[i_Line].C_LINE_CODE, lst_LineSpec[i_Line].C_SPEC, lst_LineSpec[i_Line].C_TIME);

                    if (strRe == "1")
                    {
                        num++;
                    }
                    else if (strRe == "0")
                    {
                        return "1";
                    }
                    else
                    {
                        return strRe;
                    }
                }

                timeCC = "";
                //timeStartCSH = "";

                if (num == lst_LineSpec.Count)
                {
                    result = "1";
                }

                lst_LineSpec.Clear();

                return result;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

            #endregion
        }

        /// <summary>
        /// 计算可轧制重量
        /// </summary>
        /// <returns></returns>
        private decimal Get_Slab_Wgt_New(string c_line_code, string strSpec, string strTime, out List<CastInfo> lst_T, List<Mod_TSP_PLAN_SMS_TEST> lstSLAB, out string strError)
        {
            try
            {
                decimal dWgt = 0;//可轧重量
                decimal dPlanWgt = 0;
                decimal dSlabWgt = 0;
                decimal n_zg_wgt = 0;//轧钢排产量

                lst_T = lst_Temp;

                var lstPlanRoll_Temp = CopyList(lstPlanRoll);

                lstPlanRoll_Temp = lstPlanRoll_Temp.Where(x => x.C_LINE_CODE == c_line_code && x.C_SPEC_PC == strSpec && (x.N_STATUS == 0 || x.N_STATUS == 1) && x.N_ROLL_PROD_WGT < x.N_WGT).ToList();

                //var lstPlanRoll_StdGrd = lstPlanRoll_Temp.GroupBy(x => new { x.C_STL_GRD, x.C_STD_CODE }).ToList();//获取待轧的轧钢计划的钢种和执行标准

                lstPlanRoll_Temp = lstPlanRoll_Temp.OrderByDescending(x => x.C_SPEC).ThenByDescending(x => x.N_WGT - x.N_ROLL_PROD_WGT).ThenByDescending(x => x.C_STL_GRD).ThenByDescending(x => x.C_STD_CODE).ToList();

                List<Mod_TSP_PLAN_SMS_TEST> lstPlanSlab_Temp = new List<Mod_TSP_PLAN_SMS_TEST>();

                var lstSlabTemp = CopyList(lstSLAB);

                if (lstPlanRoll_Temp.Count == 0)
                {
                    strError = "正常";
                    return dWgt;
                }

                bool IsJX = false;

                while (true)
                {
                    int num = 0;
                    int i_index = 0;
                    for (int i_ZG = 0; i_ZG < lstPlanRoll_Temp.Count; i_ZG++)
                    {
                        dPlanWgt = Convert.ToDecimal(lstPlanRoll_Temp[i_ZG].N_WGT - lstPlanRoll_Temp[i_ZG].N_ROLL_PROD_WGT);//未排产量
                        n_zg_wgt = dPlanWgt;

                        bool IsCompleted = false;

                        while (!IsCompleted)
                        {
                            if (dPlanWgt <= 0)
                            {
                                num++;
                                break;
                            }

                            var lst = lstSlabTemp.Where(x => x.N_USE_WGT > 0 && lstPlanRoll_Temp[i_ZG].C_REMARK5.Contains(x.C_STL_GRD + "|" + x.C_STD_CODE) && x.D_CAN_USE_TIME < (Convert.ToDateTime(strTime).AddMinutes(30))).ToList();

                            //var lst = lstPlanSlab_Temp.Where(x => x.C_STL_GRD == lstPlanRoll_Temp[i_ZG].C_STL_GRD && x.C_STD_CODE == lstPlanRoll_Temp[i_ZG].C_STD_CODE && x.N_USE_WGT > 0 && x.D_CAN_USE_TIME < (Convert.ToDateTime(strTime).AddMinutes(30))).ToList();

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
                                        double cn = Convert.ToDouble(dSlabWgt / Convert.ToDecimal(lstPlanRoll_Temp[i_ZG].N_MACH_WGT.ToString()));
                                        strTime = Convert.ToDateTime(strTime).AddHours(cn).ToString();//结束时间

                                        #region 计划检修
                                        var lstJX_Time = lstTJ.Where(x => x.C_STA_CODE == c_line_code && Convert.ToDateTime(strTime) >= x.D_START_TIME && Convert.ToDateTime(strTime) < x.D_END_TIME).ToList();
                                        if (lstJX_Time.Count > 0)
                                        {
                                            IsJX = true;
                                            break;
                                        }
                                        #endregion

                                        dPlanWgt = dPlanWgt - dSlabWgt;
                                        dWgt = dWgt + dSlabWgt;

                                        #region 更新炼钢计划可用钢坯量

                                        lst[i_Slab].N_USE_WGT = 0;


                                        var lstSp = lst_SlabPlan.Where(x => x.C_PLAN_ID == lst[i_Slab].C_ID).ToList();
                                        if (lstSp.Count > 0)
                                        {
                                            lstSp[0].N_WGT = Convert.ToDecimal(lst[i_Slab].N_USE_WGT);
                                        }
                                        else
                                        {
                                            SlabPlan sp = new SlabPlan(Convert.ToDecimal(lst[i_Slab].N_USE_WGT), lst[i_Slab].C_ID);
                                            lst_SlabPlan.Add(sp);
                                        }

                                        #endregion
                                    }
                                    else
                                    {
                                        double cn = Convert.ToDouble(dPlanWgt / Convert.ToDecimal(lstPlanRoll_Temp[i_ZG].N_MACH_WGT.ToString()));
                                        strTime = Convert.ToDateTime(strTime).AddHours(cn).ToString();//结束时间

                                        #region 计划检修
                                        var lstJX_Time = lstTJ.Where(x => x.C_STA_CODE == c_line_code && Convert.ToDateTime(strTime) >= x.D_START_TIME && Convert.ToDateTime(strTime) < x.D_END_TIME).ToList();
                                        if (lstJX_Time.Count > 0)
                                        {
                                            IsJX = true;
                                            break;
                                        }
                                        #endregion

                                        dWgt = dWgt + dPlanWgt;

                                        lst[i_Slab].N_USE_WGT = lst[i_Slab].N_USE_WGT - dPlanWgt;

                                        dPlanWgt = 0;

                                        var lstSp = lst_SlabPlan.Where(x => x.C_PLAN_ID == lst[i_Slab].C_ID).ToList();
                                        if (lstSp.Count > 0)
                                        {
                                            lstSp[0].N_WGT = Convert.ToDecimal(lst[i_Slab].N_USE_WGT);
                                        }
                                        else
                                        {
                                            SlabPlan sp = new SlabPlan(Convert.ToDecimal(lst[i_Slab].N_USE_WGT), lst[i_Slab].C_ID);
                                            lst_SlabPlan.Add(sp);
                                        }

                                        break;
                                    }

                                }

                                if (IsJX)
                                {
                                    break;
                                }

                            }
                            else
                            {
                                num++;
                                IsCompleted = true;
                            }
                        }

                        if (n_zg_wgt == dPlanWgt)
                        {
                            if (IsJX)
                            {
                                break;
                            }
                            else
                            {
                                continue;
                            }
                        }
                        else
                        {
                            num = 0;
                            i_index = i_ZG;
                            break;
                        }
                    }

                    lstPlanRoll_Temp[i_index].N_ROLL_PROD_WGT = lstPlanRoll_Temp[i_index].N_ROLL_PROD_WGT + (n_zg_wgt - dPlanWgt);

                    if (IsJX)
                    {
                        break;
                    }

                    //没有找到可轧钢坯或者可轧计划
                    if (num == lstPlanRoll_Temp.Count)
                    {
                        break;
                    }
                }

                decimal KZ_Wgt = 0;

                if (dWgt > 0)
                {
                    for (int i = 0; i < lstPlanRoll_Temp.Count; i++)
                    {
                        KZ_Wgt = Convert.ToDecimal(lstPlanRoll_Temp[i].N_WGT - lstPlanRoll_Temp[i].N_ROLL_PROD_WGT);//未排产量

                        if (KZ_Wgt > 0)
                        {
                            //CastInfo cInfo = new CastInfo(lstPlanRoll_Temp[i].C_STL_GRD, lstPlanRoll_Temp[i].C_STD_CODE, KZ_Wgt);
                            CastInfo cInfo = new CastInfo(lstPlanRoll_Temp[i].C_STL_GRD, lstPlanRoll_Temp[i].C_STD_CODE, KZ_Wgt, strSpec, c_line_code);
                            lst_T.Add(cInfo);
                        }
                    }
                }

                strError = "正常";

                return dWgt;
            }
            catch (Exception ex)
            {
                lst_T = null;
                strError = ex.Message;
                return decimal.MinValue;
            }
        }

        /// <summary>
        /// 更新炼钢计划钢坯可用量
        /// </summary>
        /// <returns></returns>
        private string Update_Slab_Wgt(string c_line_code, string strSpec, string strTime)
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

                var lstPlanRoll_Temp = lstPlanRoll.Where(x => x.C_LINE_CODE == c_line_code && x.C_SPEC_PC == strSpec && (x.N_STATUS == 0 || x.N_STATUS == 1) && x.N_ROLL_PROD_WGT < x.N_WGT).ToList();

                lstPlanRoll_Temp = lstPlanRoll_Temp.OrderByDescending(x => x.C_SPEC).ThenByDescending(x => x.N_WGT - x.N_ROLL_PROD_WGT).ThenByDescending(x => x.C_STL_GRD).ThenByDescending(x => x.C_STD_CODE).ToList();//获取指定规格待轧的轧钢计划

                bool IsJX = false;

                while (true)
                {
                    int num = 0;

                    for (int i_ZG = 0; i_ZG < lstPlanRoll_Temp.Count; i_ZG++)
                    {
                        if (!string.IsNullOrEmpty(lstPlanRoll_Temp[i_ZG].D_P_START_TIME.ToString()))
                        {
                            timeStart = lstPlanRoll_Temp[i_ZG].D_P_START_TIME.ToString();
                        }
                        else
                        {
                            timeStart = strTime;
                        }

                        timeStart_sj = strTime;

                        strOrderID = lstPlanRoll_Temp[i_ZG].C_INITIALIZE_ITEM_ID.ToString();//订单主键

                        dPlanWgt = Convert.ToDecimal(lstPlanRoll_Temp[i_ZG].N_WGT - lstPlanRoll_Temp[i_ZG].N_ROLL_PROD_WGT);//未排产量
                        n_zg_wgt = dPlanWgt;

                        bool IsCompleted = false;

                        while (!IsCompleted)
                        {
                            if (dPlanWgt <= 0)
                            {
                                num++;
                                break;
                            }

                            //var lst = lstPlanSlab.Where(x => x.C_STL_GRD == lstPlanRoll_Temp[i_ZG].C_STL_GRD && x.C_STD_CODE == lstPlanRoll_Temp[i_ZG].C_STD_CODE && x.N_USE_WGT > 0 && x.D_CAN_USE_TIME < (Convert.ToDateTime(strTime).AddMinutes(30))).ToList();

                            var lst = lstPlanSlab.Where(x => lstPlanRoll_Temp[i_ZG].C_REMARK5.Contains(x.C_STL_GRD + "|" + x.C_STD_CODE) && x.N_USE_WGT > 0 && x.D_CAN_USE_TIME < (Convert.ToDateTime(strTime).AddMinutes(30))).ToList();

                            if (lst.Count > 0)
                            {
                                for (int i_Slab = 0; i_Slab < lst.Count; i_Slab++)
                                {
                                    dSlabWgt = Convert.ToDecimal(lst[i_Slab].N_USE_WGT.ToString());

                                    if (dSlabWgt <= 0)
                                    {
                                        continue;
                                    }

                                    if (dPlanWgt >= dSlabWgt)
                                    {
                                        double cn = Convert.ToDouble(dSlabWgt / Convert.ToDecimal(lstPlanRoll_Temp[i_ZG].N_MACH_WGT.ToString()));
                                        strTime = Convert.ToDateTime(strTime).AddHours(cn).ToString();//结束时间

                                        #region 计划检修
                                        var lstJX_Time = lstTJ.Where(x => x.C_STA_CODE == c_line_code && Convert.ToDateTime(strTime) >= x.D_START_TIME && Convert.ToDateTime(strTime) < x.D_END_TIME).ToList();
                                        if (lstJX_Time.Count > 0)
                                        {
                                            IsJX = true;
                                            break;
                                        }
                                        #endregion

                                        dPlanWgt = dPlanWgt - dSlabWgt;
                                        dWgt = dWgt + dSlabWgt;

                                        #region 更新炼钢计划可用钢坯量

                                        lst[i_Slab].N_USE_WGT = 0;

                                        #endregion
                                    }
                                    else
                                    {
                                        double cn = Convert.ToDouble(dPlanWgt / Convert.ToDecimal(lstPlanRoll_Temp[i_ZG].N_MACH_WGT.ToString()));
                                        strTime = Convert.ToDateTime(strTime).AddHours(cn).ToString();//结束时间

                                        #region 计划检修
                                        var lstJX_Time = lstTJ.Where(x => x.C_STA_CODE == c_line_code && Convert.ToDateTime(strTime) >= x.D_START_TIME && Convert.ToDateTime(strTime) < x.D_END_TIME).ToList();
                                        if (lstJX_Time.Count > 0)
                                        {
                                            IsJX = true;
                                            break;
                                        }
                                        #endregion

                                        dWgt = dWgt + dPlanWgt;

                                        #region 更新炼钢计划可用钢坯量

                                        lst[i_Slab].N_USE_WGT = lst[i_Slab].N_USE_WGT - dPlanWgt;

                                        #endregion

                                        dPlanWgt = 0;

                                        break;
                                    }
                                }

                                if (IsJX)
                                {
                                    break;
                                }

                            }
                            else
                            {
                                num++;
                                IsCompleted = true;
                            }
                        }

                        if (n_zg_wgt == dPlanWgt)
                        {
                            if (IsJX)
                            {
                                break;
                            }
                            else
                            {
                                continue;
                            }
                        }
                        else
                        {
                            num = 0;

                            #region 添加计划明细TRP_PLAN_ITEM

                            Mod_TRP_PLAN_ITEM_TEST modelItem = new Mod_TRP_PLAN_ITEM_TEST();
                            modelItem.C_PLAN_ROLL_ID = lstPlanRoll_Temp[i_ZG].C_ID;
                            modelItem.N_STATUS = lstPlanRoll_Temp[i_ZG].N_STATUS;
                            modelItem.C_INITIALIZE_ITEM_ID = lstPlanRoll_Temp[i_ZG].C_INITIALIZE_ITEM_ID;
                            modelItem.C_ORDER_NO = lstPlanRoll_Temp[i_ZG].C_ORDER_NO;
                            modelItem.N_WGT = lstPlanRoll_Temp[i_ZG].N_WGT;
                            modelItem.C_MAT_CODE = lstPlanRoll_Temp[i_ZG].C_MAT_CODE;
                            modelItem.C_MAT_NAME = lstPlanRoll_Temp[i_ZG].C_MAT_NAME;
                            modelItem.C_TECH_PROT = lstPlanRoll_Temp[i_ZG].C_TECH_PROT;
                            modelItem.C_SPEC = lstPlanRoll_Temp[i_ZG].C_SPEC;
                            modelItem.C_STL_GRD = lstPlanRoll_Temp[i_ZG].C_STL_GRD;
                            modelItem.C_STD_CODE = lstPlanRoll_Temp[i_ZG].C_STD_CODE;
                            modelItem.N_USER_LEV = lstPlanRoll_Temp[i_ZG].N_USER_LEV;
                            modelItem.N_STL_GRD_LEV = lstPlanRoll_Temp[i_ZG].N_STL_GRD_LEV;
                            modelItem.N_ORDER_LEV = lstPlanRoll_Temp[i_ZG].N_ORDER_LEV;
                            modelItem.C_QUALIRY_LEV = lstPlanRoll_Temp[i_ZG].C_QUALIRY_LEV;
                            modelItem.D_NEED_DT = lstPlanRoll_Temp[i_ZG].D_NEED_DT;
                            modelItem.D_DELIVERY_DT = lstPlanRoll_Temp[i_ZG].D_DELIVERY_DT;
                            modelItem.D_DT = lstPlanRoll_Temp[i_ZG].D_DT;
                            modelItem.C_LINE_DESC = lstPlanRoll_Temp[i_ZG].C_LINE_DESC;
                            modelItem.C_LINE_CODE = lstPlanRoll_Temp[i_ZG].C_LINE_CODE;
                            modelItem.D_P_START_TIME = Convert.ToDateTime(timeStart_sj);//计划开始时间
                            modelItem.D_P_END_TIME = Convert.ToDateTime(strTime);//计划结束时间
                            modelItem.N_PROD_TIME = lstPlanRoll_Temp[i_ZG].N_PROD_TIME;
                            modelItem.N_SORT = lstPlanRoll_Temp[i_ZG].N_SORT;
                            modelItem.N_ROLL_PROD_WGT = n_zg_wgt - dPlanWgt;//排产量
                            modelItem.C_ROLL_PROD_EMP_ID = lstPlanRoll_Temp[i_ZG].C_ROLL_PROD_EMP_ID;
                            modelItem.C_STL_ROL_DT = lstPlanRoll_Temp[i_ZG].C_STL_ROL_DT;
                            modelItem.N_PROD_WGT = lstPlanRoll_Temp[i_ZG].N_PROD_WGT;
                            modelItem.N_WARE_WGT = lstPlanRoll_Temp[i_ZG].N_WARE_WGT;
                            modelItem.N_WARE_OUT_WGT = lstPlanRoll_Temp[i_ZG].N_WARE_OUT_WGT;
                            modelItem.N_FLAG = lstPlanRoll_Temp[i_ZG].N_FLAG;
                            modelItem.N_ISSUE_WGT = lstPlanRoll_Temp[i_ZG].N_ISSUE_WGT;
                            modelItem.C_CUST_NO = lstPlanRoll_Temp[i_ZG].C_CUST_NO;
                            modelItem.C_CUST_NAME = lstPlanRoll_Temp[i_ZG].C_CUST_NAME;
                            modelItem.C_SALE_CHANNEL = lstPlanRoll_Temp[i_ZG].C_SALE_CHANNEL;
                            modelItem.C_PACK = lstPlanRoll_Temp[i_ZG].C_PACK;
                            modelItem.C_DESIGN_NO = lstPlanRoll_Temp[i_ZG].C_DESIGN_NO;
                            modelItem.N_GROUP_WGT = lstPlanRoll_Temp[i_ZG].N_GROUP_WGT;
                            modelItem.C_STA_ID = lstPlanRoll_Temp[i_ZG].C_STA_ID;
                            modelItem.D_START_TIME = lstPlanRoll_Temp[i_ZG].D_START_TIME;
                            modelItem.D_END_TIME = lstPlanRoll_Temp[i_ZG].D_END_TIME;
                            modelItem.C_EMP_ID = lstPlanRoll_Temp[i_ZG].C_EMP_ID;
                            modelItem.D_MOD_DT = lstPlanRoll_Temp[i_ZG].D_MOD_DT;
                            modelItem.N_ROLL_WGT = lstPlanRoll_Temp[i_ZG].N_ROLL_WGT;
                            modelItem.N_MACH_WGT = lstPlanRoll_Temp[i_ZG].N_MACH_WGT;
                            modelItem.C_CAST_NO = lstPlanRoll_Temp[i_ZG].C_CAST_NO;
                            modelItem.C_INITIALIZE_ID = lstPlanRoll_Temp[i_ZG].C_INITIALIZE_ID;
                            modelItem.C_FREE_TERM = lstPlanRoll_Temp[i_ZG].C_FREE_TERM;
                            modelItem.C_FREE_TERM2 = lstPlanRoll_Temp[i_ZG].C_FREE_TERM2;
                            modelItem.C_AREA = lstPlanRoll_Temp[i_ZG].C_AREA;
                            modelItem.C_PCLX = lstPlanRoll_Temp[i_ZG].C_PCLX;
                            modelItem.C_SFHL = lstPlanRoll_Temp[i_ZG].C_SFHL;
                            modelItem.D_HL_START_TIME = lstPlanRoll_Temp[i_ZG].D_HL_START_TIME;
                            modelItem.D_HL_END_TIME = lstPlanRoll_Temp[i_ZG].D_HL_END_TIME;
                            modelItem.C_SFHL_D = lstPlanRoll_Temp[i_ZG].C_SFHL_D;
                            modelItem.D_DHL_START_TIME = lstPlanRoll_Temp[i_ZG].D_DHL_START_TIME;
                            modelItem.D_DHL_END_TIME = lstPlanRoll_Temp[i_ZG].D_DHL_END_TIME;
                            modelItem.C_SFKP = lstPlanRoll_Temp[i_ZG].C_SFKP;
                            modelItem.D_KP_START_TIME = lstPlanRoll_Temp[i_ZG].D_KP_START_TIME;
                            modelItem.D_KP_END_TIME = lstPlanRoll_Temp[i_ZG].D_KP_END_TIME;
                            modelItem.C_SFXM = lstPlanRoll_Temp[i_ZG].C_SFXM;
                            modelItem.D_XM_START_TIME = lstPlanRoll_Temp[i_ZG].D_XM_START_TIME;
                            modelItem.D_XM_END_TIME = lstPlanRoll_Temp[i_ZG].D_XM_END_TIME;
                            //modelItem.N_UPLOADSTATUS = lstPlanRoll_Temp[i_ZG].N_UPLOADSTATUS;
                            modelItem.C_MATRL_CODE_SLAB = lstPlanRoll_Temp[i_ZG].C_MATRL_CODE_SLAB;
                            modelItem.C_MATRL_NAME_SLAB = lstPlanRoll_Temp[i_ZG].C_MATRL_NAME_SLAB;
                            modelItem.C_SLAB_SIZE = lstPlanRoll_Temp[i_ZG].C_SLAB_SIZE;
                            modelItem.N_SLAB_LENGTH = lstPlanRoll_Temp[i_ZG].N_SLAB_LENGTH;
                            modelItem.N_SLAB_PW = lstPlanRoll_Temp[i_ZG].N_SLAB_PW;
                            //modelItem.D_CAN_ROLL_TIME = lstPlanRoll_Temp[i_ZG].D_CAN_ROLL_TIME;
                            //modelItem.C_ROUTE = lstPlanRoll_Temp[i_ZG].C_ROUTE;
                            //modelItem.N_DIAMETER = lstPlanRoll_Temp[i_ZG].N_DIAMETER;
                            //modelItem.C_XM_YQ = lstPlanRoll_Temp[i_ZG].C_XM_YQ;
                            //modelItem.N_JRL_WD = lstPlanRoll_Temp[i_ZG].N_JRL_WD;
                            //modelItem.N_JRL_SJ = lstPlanRoll_Temp[i_ZG].N_JRL_SJ;

                            lstPlanItem.Add(modelItem);

                            #endregion

                            lstPlanRoll_Temp[i_ZG].N_ROLL_PROD_WGT = lstPlanRoll_Temp[i_ZG].N_ROLL_PROD_WGT + (n_zg_wgt - dPlanWgt);
                            lstPlanRoll_Temp[i_ZG].D_P_START_TIME = Convert.ToDateTime(timeStart);
                            lstPlanRoll_Temp[i_ZG].D_P_END_TIME = Convert.ToDateTime(strTime);

                            break;
                        }
                    }


                    if (IsJX)
                    {
                        break;
                    }

                    //没有找到可轧钢坯或者可轧计划
                    if (num == lstPlanRoll_Temp.Count)
                    {
                        break;
                    }
                }

                //return dWgt;

                if (dWgt > 0)
                {
                    return "1";
                }
                else
                {
                    return "0";
                }
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
            int error = 0;
            try
            {
                if (lst_Cast.Count > 0)
                {
                    lst_Cast = lst_Cast.OrderByDescending(x => x.N_WGT).ToList();

                    bool IsTL = false;

                    for (int i_CC = 0; i_CC < lst_Cast.Count; i_CC++)
                    {
                        IsTL = false;

                        var lst_FK = lstLcLsb.Where(x => x.C_STL_GRD == lst_Cast[i_CC].C_STL_GRD && x.C_STD_CODE == lst_Cast[i_CC].C_STD_CODE && x.N_STATUS == 1).GroupBy(x => new { x.C_FK }).ToList();

                        if (lst_FK.Count > 0)
                        {
                            for (int i = 0; i < lst_FK.Count; i++)
                            {
                                List<Mod_TPP_LGPC_LCLSB_TEST> lstLclsb_Temp = lstLcLsb.Where(x => x.C_FK == lst_FK[i].Key.C_FK && x.N_STATUS == 1).OrderBy(x => x.N_SORT).ToList();

                                int n_Sort = 0;
                                DateTime startTime = DateTime.Now;
                                DateTime endTime = startTime.AddMinutes(30);

                                var lstPlanSlab_Temp = lstPlanSlab.Where(x => x.C_CCM_ID == lstLclsb_Temp[0].C_CCM_ID).ToList();
                                if (lstPlanSlab_Temp.Count > 0)
                                {
                                    startTime = Convert.ToDateTime(lstPlanSlab_Temp.Max(x => x.D_P_END_TIME));
                                    n_Sort = Convert.ToInt32(lstPlanSlab_Temp.Max(x => x.N_SORT));
                                }

                                #region 计划检修
                                var lstJX_Time = lstTJ.Where(x => x.C_STA_ID == lstLclsb_Temp[0].C_CCM_ID && ((startTime >= x.D_START_TIME && startTime < x.D_END_TIME) || (startTime.AddHours(5) >= x.D_START_TIME && startTime.AddHours(5) < x.D_END_TIME))).ToList();
                                if (lstJX_Time.Count > 0)
                                {
                                    TimeSpan ts = Convert.ToDateTime(lstJX_Time[0].D_END_TIME) - Convert.ToDateTime(lstJX_Time[0].D_START_TIME);

                                    int hh = ts.Hours;

                                    lstJX_Time[0].D_START_TIME = startTime;

                                    startTime = startTime.AddHours(hh);

                                    lstJX_Time[0].D_END_TIME = startTime;
                                }
                                #endregion

                                DateTime JC_StratTime = startTime;
                                DateTime JC_EndTime;

                                #region 脱硫是否冲突
                                int count = lstLclsb_Temp.Where(x => x.C_TL == "Y").ToList().Count;
                                if (count > 0)
                                {
                                    double dCN = Convert.ToDouble(lstLclsb_Temp.Sum(x => x.N_SLAB_WGT)) / Convert.ToDouble(lstLclsb_Temp[0].N_JSCN);
                                    DateTime dtTime = startTime.AddHours(dCN);

                                    var lstTL_FK = lstPlanSlab.Where(x => x.C_CCM_DESC == "5#CC" && x.C_TL == "Y" && x.D_P_START_TIME >= startTime && x.D_P_END_TIME <= dtTime).ToList();

                                    if (lstTL_FK.Count > 0)
                                    {
                                        IsTL = true;

                                        startTime = Convert.ToDateTime(lstTL_FK.Max(x => x.D_P_END_TIME));

                                        break;
                                    }

                                }
                                #endregion                                

                                for (int i_Lclsb = 0; i_Lclsb < lstLclsb_Temp.Count; i_Lclsb++)
                                {
                                    #region 计算3#CC、4#CC连铸生产顺序和计划开始时间和计划结束时间

                                    error = n_Sort;

                                    //if (error == 1699)
                                    //{
                                    //    int aas = 0;
                                    //}

                                    n_Sort++;

                                    double cn = 0;

                                    cn = Convert.ToDouble(lstLclsb_Temp[i_Lclsb].N_SLAB_WGT) / Convert.ToDouble(lstLclsb_Temp[i_Lclsb].N_JSCN);

                                    if (i_Lclsb == 0)
                                    {
                                        endTime = startTime.AddHours(cn);
                                    }
                                    else
                                    {
                                        startTime = endTime;
                                        endTime = startTime.AddHours(cn);
                                    }

                                    #endregion

                                    #region 将炉次计划添加到lstPlanSlab中

                                    #region 实体赋值

                                    Mod_TSP_PLAN_SMS_TEST mod_Sms = new Mod_TSP_PLAN_SMS_TEST();
                                    mod_Sms.C_ID = lstLclsb_Temp[i_Lclsb].C_ID;
                                    mod_Sms.C_ORDER_NO = lstLclsb_Temp[i_Lclsb].C_ORDER_NO;
                                    mod_Sms.C_DESIGN_NO = lstLclsb_Temp[i_Lclsb].C_DESIGN_NO;
                                    mod_Sms.N_SLAB_WGT = lstLclsb_Temp[i_Lclsb].N_SLAB_WGT;
                                    mod_Sms.C_CTRL_NO = lstLclsb_Temp[i_Lclsb].C_CTRL_NO;
                                    mod_Sms.C_CCM_ID = lstLclsb_Temp[i_Lclsb].C_CCM_ID;
                                    mod_Sms.C_CCM_DESC = lstLclsb_Temp[i_Lclsb].C_CCM_DESC;
                                    mod_Sms.C_PROD_NAME = lstLclsb_Temp[i_Lclsb].C_PROD_NAME;
                                    mod_Sms.C_STL_GRD = lstLclsb_Temp[i_Lclsb].C_STL_GRD;
                                    mod_Sms.C_SPEC_CODE = lstLclsb_Temp[i_Lclsb].C_SPEC_CODE;
                                    mod_Sms.C_LENGTH = lstLclsb_Temp[i_Lclsb].C_LENGTH;
                                    mod_Sms.C_MATRL_NO = lstLclsb_Temp[i_Lclsb].C_MATRL_NO;
                                    mod_Sms.C_MATRL_NAME = lstLclsb_Temp[i_Lclsb].C_MATRL_NAME;
                                    mod_Sms.C_SLAB_SIZE = lstLclsb_Temp[i_Lclsb].C_SLAB_SIZE;
                                    mod_Sms.C_SLAB_LENGTH = lstLclsb_Temp[i_Lclsb].C_SLAB_LENGTH;
                                    mod_Sms.C_STATE = lstLclsb_Temp[i_Lclsb].C_STATE;
                                    mod_Sms.C_STD_CODE = lstLclsb_Temp[i_Lclsb].C_STD_CODE;
                                    mod_Sms.C_INITIALIZE_ITEM_ID = lstLclsb_Temp[i_Lclsb].C_INITIALIZE_ITEM_ID;
                                    mod_Sms.D_P_START_TIME = startTime;//计划开始时间
                                    mod_Sms.D_P_END_TIME = endTime;//计划结束时间
                                    mod_Sms.N_PROD_TIME = lstLclsb_Temp[i_Lclsb].N_PROD_TIME;
                                    mod_Sms.N_SORT = n_Sort;//顺序号
                                    mod_Sms.C_CAST_NO = lstLclsb_Temp[i_Lclsb].C_CAST_NO;
                                    mod_Sms.N_STATUS = lstLclsb_Temp[i_Lclsb].N_STATUS;
                                    mod_Sms.C_EMP_ID = lstLclsb_Temp[i_Lclsb].C_EMP_ID;
                                    mod_Sms.D_MOD_DT = lstLclsb_Temp[i_Lclsb].D_MOD_DT;
                                    mod_Sms.C_REMARK = lstLclsb_Temp[i_Lclsb].C_REMARK;
                                    mod_Sms.N_CREAT_PLAN = lstLclsb_Temp[i_Lclsb].N_CREAT_PLAN;
                                    mod_Sms.N_CREAT_ZG_PLAN = lstLclsb_Temp[i_Lclsb].N_CREAT_ZG_PLAN;
                                    mod_Sms.N_PRODUCE_TIME = lstLclsb_Temp[i_Lclsb].N_PRODUCE_TIME;
                                    mod_Sms.C_ZL_ID = lstLclsb_Temp[i_Lclsb].C_ZL_ID;
                                    mod_Sms.C_LF_ID = lstLclsb_Temp[i_Lclsb].C_LF_ID;
                                    mod_Sms.C_RH_ID = lstLclsb_Temp[i_Lclsb].C_RH_ID;
                                    mod_Sms.C_LGJH = lstLclsb_Temp[i_Lclsb].C_LGJH;
                                    mod_Sms.C_QUA = lstLclsb_Temp[i_Lclsb].C_QUA;
                                    mod_Sms.D_ARRIVE_ZG_TIME = lstLclsb_Temp[i_Lclsb].D_ARRIVE_ZG_TIME;
                                    mod_Sms.C_BY1 = lstLclsb_Temp[i_Lclsb].C_BY1;
                                    mod_Sms.C_BY2 = lstLclsb_Temp[i_Lclsb].C_BY2;
                                    mod_Sms.C_BY3 = lstLclsb_Temp[i_Lclsb].C_BY3;
                                    mod_Sms.C_RH = lstLclsb_Temp[i_Lclsb].C_RH;
                                    mod_Sms.C_DFP_HL = lstLclsb_Temp[i_Lclsb].C_DFP_HL;
                                    mod_Sms.C_HL = lstLclsb_Temp[i_Lclsb].C_HL;
                                    mod_Sms.C_XM = lstLclsb_Temp[i_Lclsb].C_XM;
                                    mod_Sms.D_DFPHL_START_TIME = lstLclsb_Temp[i_Lclsb].D_DFPHL_START_TIME;
                                    mod_Sms.D_DFPHL_END_TIME = lstLclsb_Temp[i_Lclsb].D_DFPHL_END_TIME;
                                    mod_Sms.D_KP_START_TIME = lstLclsb_Temp[i_Lclsb].D_KP_START_TIME;
                                    mod_Sms.D_KP_END_TIME = lstLclsb_Temp[i_Lclsb].D_KP_END_TIME;
                                    mod_Sms.D_HL_START_TIME = lstLclsb_Temp[i_Lclsb].D_HL_START_TIME;
                                    mod_Sms.D_HL_END_TIME = lstLclsb_Temp[i_Lclsb].D_HL_END_TIME;
                                    mod_Sms.D_PLAN_KY_TIME = lstLclsb_Temp[i_Lclsb].D_PLAN_KY_TIME;
                                    mod_Sms.C_PLAN_ROLL = lstLclsb_Temp[i_Lclsb].C_PLAN_ROLL;
                                    mod_Sms.D_ZZ_START_TIME = lstLclsb_Temp[i_Lclsb].D_ZZ_START_TIME;
                                    mod_Sms.D_ZZ_END_TIME = lstLclsb_Temp[i_Lclsb].D_ZZ_END_TIME;
                                    mod_Sms.D_XM_START_TIME = lstLclsb_Temp[i_Lclsb].D_XM_START_TIME;
                                    mod_Sms.D_XM_END_TIME = lstLclsb_Temp[i_Lclsb].D_XM_END_TIME;
                                    mod_Sms.C_STOVE_NO = lstLclsb_Temp[i_Lclsb].C_STOVE_NO;
                                    mod_Sms.D_DFPHL_START_TIME_SJ = lstLclsb_Temp[i_Lclsb].D_DFPHL_START_TIME_SJ;
                                    mod_Sms.D_DFPHL_END_TIME_SJ = lstLclsb_Temp[i_Lclsb].D_DFPHL_END_TIME_SJ;
                                    mod_Sms.D_KP_START_TIME_SJ = lstLclsb_Temp[i_Lclsb].D_KP_START_TIME_SJ;
                                    mod_Sms.D_KP_END_TIME_SJ = lstLclsb_Temp[i_Lclsb].D_KP_END_TIME_SJ;
                                    mod_Sms.D_HL_START_TIME_SJ = lstLclsb_Temp[i_Lclsb].D_HL_START_TIME_SJ;
                                    mod_Sms.D_HL_END_TIME_SJ = lstLclsb_Temp[i_Lclsb].D_HL_END_TIME_SJ;
                                    mod_Sms.D_XM_START_TIME_SJ = lstLclsb_Temp[i_Lclsb].D_XM_START_TIME_SJ;
                                    mod_Sms.D_XM_END_TIME_SJ = lstLclsb_Temp[i_Lclsb].D_XM_END_TIME_SJ;
                                    mod_Sms.N_SJ_WGT = lstLclsb_Temp[i_Lclsb].N_SJ_WGT;
                                    mod_Sms.D_START_TIME_SJ = lstLclsb_Temp[i_Lclsb].D_START_TIME_SJ;
                                    mod_Sms.D_END_TIME_SJ = lstLclsb_Temp[i_Lclsb].D_END_TIME_SJ;
                                    mod_Sms.N_DFP_HL_TIME = lstLclsb_Temp[i_Lclsb].N_DFP_HL_TIME;
                                    mod_Sms.N_HL_TIME = lstLclsb_Temp[i_Lclsb].N_HL_TIME;
                                    mod_Sms.C_ROUTE = lstLclsb_Temp[i_Lclsb].C_ROUTE;
                                    mod_Sms.N_SLAB_PW = lstLclsb_Temp[i_Lclsb].N_SLAB_PW;
                                    mod_Sms.C_MATRL_CODE_KP = lstLclsb_Temp[i_Lclsb].C_MATRL_CODE_KP;
                                    mod_Sms.C_MATRL_NAME_KP = lstLclsb_Temp[i_Lclsb].C_MATRL_NAME_KP;
                                    mod_Sms.C_KP_SIZE = lstLclsb_Temp[i_Lclsb].C_KP_SIZE;
                                    mod_Sms.N_KP_LENGTH = lstLclsb_Temp[i_Lclsb].N_KP_LENGTH;
                                    mod_Sms.N_KP_PW = lstLclsb_Temp[i_Lclsb].N_KP_PW;
                                    mod_Sms.N_USE_WGT = Convert.ToInt32(lstLclsb_Temp[i_Lclsb].N_USE_WGT);
                                    mod_Sms.D_USE_START_TIME_SJ = lstLclsb_Temp[i_Lclsb].D_USE_START_TIME_SJ;
                                    mod_Sms.D_USE_END_TIME_SJ = lstLclsb_Temp[i_Lclsb].D_USE_END_TIME_SJ;
                                    mod_Sms.D_CAN_USE_TIME = endTime.AddHours(2);//可用时间
                                    mod_Sms.N_RH_NUM = lstLclsb_Temp[i_Lclsb].N_RH_NUM;
                                    mod_Sms.N_KP_WGT = lstLclsb_Temp[i_Lclsb].N_KP_WGT;
                                    mod_Sms.N_XM_WGT = lstLclsb_Temp[i_Lclsb].N_XM_WGT;
                                    mod_Sms.C_DFP_RZ = string.IsNullOrEmpty(lstLclsb_Temp[i_Lclsb].C_DFP_RZ) == true ? "N" : lstLclsb_Temp[i_Lclsb].C_DFP_RZ;
                                    mod_Sms.C_RZP_RZ = string.IsNullOrEmpty(lstLclsb_Temp[i_Lclsb].C_RZP_RZ) == true ? "N" : lstLclsb_Temp[i_Lclsb].C_RZP_RZ;
                                    mod_Sms.C_DFP_YQ = lstLclsb_Temp[i_Lclsb].C_DFP_YQ;
                                    mod_Sms.C_RZP_YQ = lstLclsb_Temp[i_Lclsb].C_RZP_YQ;
                                    mod_Sms.C_STL_GRD_TYPE = lstLclsb_Temp[i_Lclsb].C_STL_GRD_TYPE;
                                    mod_Sms.C_PROD_KIND = lstLclsb_Temp[i_Lclsb].C_PROD_KIND;
                                    mod_Sms.C_TL = lstLclsb_Temp[i_Lclsb].C_TL;
                                    mod_Sms.N_JSCN = lstLclsb_Temp[i_Lclsb].N_JSCN;
                                    mod_Sms.C_FREE1 = lstLclsb_Temp[i_Lclsb].C_FREE1;
                                    mod_Sms.C_FREE2 = lstLclsb_Temp[i_Lclsb].C_FREE2;
                                    mod_Sms.N_GROUP = lstLclsb_Temp[i_Lclsb].N_GROUP;
                                    mod_Sms.C_FK = lstLclsb_Temp[i_Lclsb].C_FK;
                                    mod_Sms.N_ZJCLS = lstLclsb_Temp[i_Lclsb].N_ZJCLS;
                                    mod_Sms.N_ZJCLS_MIN = lstLclsb_Temp[i_Lclsb].N_ZJCLS_MIN;
                                    mod_Sms.N_ZJCLS_MAX = lstLclsb_Temp[i_Lclsb].N_ZJCLS_MAX;
                                    mod_Sms.C_SL = lstLclsb_Temp[i_Lclsb].C_SL;
                                    mod_Sms.C_WL = lstLclsb_Temp[i_Lclsb].C_WL;
                                    mod_Sms.C_SLAB_TYPE = lstLclsb_Temp[i_Lclsb].C_SLAB_TYPE;
                                    mod_Sms.C_LGJH = "2";//新增计划

                                    #endregion

                                    lstPlanSlab.Add(mod_Sms);

                                    #endregion

                                    #region 将TPP_LGPC_LCLSB表数据停用

                                    lstLclsb_Temp[i_Lclsb].N_STATUS = 0;

                                    #endregion
                                }

                                JC_EndTime = endTime;

                                int Sort_JC = Convert.ToInt32(lstJCLsb.Where(x => x.C_CCM_ID == lstLclsb_Temp[0].C_CCM_ID).Max(a => a.N_SORT));
                                if (Sort_JC == 0)
                                {
                                    Sort_JC = dalTspCastPlanTest.Max_jc_sort(lstLclsb_Temp[0].C_CCM_ID);
                                }

                                Sort_JC++;

                                var lstJC = lstJCLsb.Where(x => x.C_ID == lst_FK[i].Key.C_FK).ToList();
                                lstJC[0].N_SORT = Sort_JC;
                                lstJC[0].D_P_START_TIME = JC_StratTime;
                                lstJC[0].D_P_END_TIME = JC_EndTime;
                                lstJC[0].N_STATUS = 1;
                                lstJC[0].C_PLAN_ROLL = "2";
                            }

                            if (IsTL)
                            {
                                continue;
                            }
                            else
                            {
                                break;
                            }
                        }
                    }
                }

                return "1";
            }
            catch (Exception ex)
            {
                int aa = error;
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

                var lstPlanRoll_Temp = lstPlanRoll.GroupBy(x => new { x.C_STD_CODE, x.C_STL_GRD }).Select(a => new { a.Key.C_STD_CODE, a.Key.C_STL_GRD, N_wgt = a.Sum(b => b.N_WGT - b.N_ROLL_PROD_WGT) }).ToList();
                lstPlanRoll_Temp = lstPlanRoll_Temp.OrderByDescending(x => x.N_wgt).ToList();//获取待轧的轧钢计划（按钢种，执行标准，待轧量汇总）

                bool IsTL = false;

                for (int i_ZG = 0; i_ZG < lstPlanRoll_Temp.Count; i_ZG++)
                {
                    IsTL = false;

                    var lst_FK = lstLcLsb.Where(x => x.C_STL_GRD == lstPlanRoll_Temp[i_ZG].C_STL_GRD && x.C_STD_CODE == lstPlanRoll_Temp[i_ZG].C_STD_CODE && x.N_STATUS == 1).GroupBy(x => new { x.C_FK }).ToList();

                    if (lst_FK.Count > 0)
                    {
                        for (int i = 0; i < lst_FK.Count; i++)
                        {
                            List<Mod_TPP_LGPC_LCLSB_TEST> lstLclsb_Temp = lstLcLsb.Where(x => x.C_FK == lst_FK[i].Key.C_FK && x.N_STATUS == 1).OrderBy(x => x.N_SORT).ToList();

                            int n_Sort = 0;
                            DateTime startTime = DateTime.Now;
                            DateTime endTime = startTime.AddMinutes(30);

                            var lstPlanSlab_Temp = lstPlanSlab.Where(x => x.C_CCM_ID == lstLclsb_Temp[0].C_CCM_ID).ToList();
                            if (lstPlanSlab_Temp.Count > 0)
                            {
                                startTime = Convert.ToDateTime(lstPlanSlab_Temp.Max(x => x.D_P_END_TIME));
                                n_Sort = Convert.ToInt32(lstPlanSlab_Temp.Max(x => x.N_SORT));
                            }

                            #region 计划检修
                            var lstJX_Time = lstTJ.Where(x => x.C_STA_ID == lstLclsb_Temp[0].C_CCM_ID && ((startTime >= x.D_START_TIME && startTime < x.D_END_TIME) || (startTime.AddHours(5) >= x.D_START_TIME && startTime.AddHours(5) < x.D_END_TIME))).ToList();
                            if (lstJX_Time.Count > 0)
                            {
                                TimeSpan ts = Convert.ToDateTime(lstJX_Time[0].D_END_TIME) - Convert.ToDateTime(lstJX_Time[0].D_START_TIME);

                                int hh = ts.Hours;

                                lstJX_Time[0].D_START_TIME = startTime;

                                startTime = startTime.AddHours(hh);

                                lstJX_Time[0].D_END_TIME = startTime;
                            }
                            #endregion

                            DateTime JC_StratTime = startTime;
                            DateTime JC_EndTime;

                            #region 脱硫是否冲突
                            int count = lstLclsb_Temp.Where(x => x.C_TL == "Y").ToList().Count;
                            if (count > 0)
                            {
                                double dCN = Convert.ToDouble(lstLclsb_Temp.Sum(x => x.N_SLAB_WGT)) / Convert.ToDouble(lstLclsb_Temp[0].N_JSCN);
                                DateTime dtTime = startTime.AddHours(dCN);

                                var lstTL_FK = lstPlanSlab.Where(x => x.C_CCM_DESC == "5#CC" && x.C_TL == "Y" && x.D_P_START_TIME >= startTime && x.D_P_END_TIME <= dtTime).ToList();

                                if (lstTL_FK.Count > 0)
                                {
                                    IsTL = true;

                                    startTime = Convert.ToDateTime(lstTL_FK.Max(x => x.D_P_END_TIME));

                                    break;
                                }

                            }
                            #endregion

                            for (int i_Lclsb = 0; i_Lclsb < lstLclsb_Temp.Count; i_Lclsb++)
                            {
                                #region 计算3#CC、4#CC连铸生产顺序和计划开始时间和计划结束时间

                                n_Sort++;

                                double cn = 0;

                                cn = Convert.ToDouble(lstLclsb_Temp[i_Lclsb].N_SLAB_WGT) / Convert.ToDouble(lstLclsb_Temp[i_Lclsb].N_JSCN);

                                if (i_Lclsb == 0)
                                {
                                    endTime = startTime.AddHours(cn);
                                }
                                else
                                {
                                    startTime = endTime;
                                    endTime = startTime.AddHours(cn);
                                }

                                #endregion

                                #region 将炉次计划添加到lstPlanSlab中

                                #region 实体赋值

                                Mod_TSP_PLAN_SMS_TEST mod_Sms = new Mod_TSP_PLAN_SMS_TEST();
                                mod_Sms.C_ID = lstLclsb_Temp[i_Lclsb].C_ID;
                                mod_Sms.C_ORDER_NO = lstLclsb_Temp[i_Lclsb].C_ORDER_NO;
                                mod_Sms.C_DESIGN_NO = lstLclsb_Temp[i_Lclsb].C_DESIGN_NO;
                                mod_Sms.N_SLAB_WGT = lstLclsb_Temp[i_Lclsb].N_SLAB_WGT;
                                mod_Sms.C_CTRL_NO = lstLclsb_Temp[i_Lclsb].C_CTRL_NO;
                                mod_Sms.C_CCM_ID = lstLclsb_Temp[i_Lclsb].C_CCM_ID;
                                mod_Sms.C_CCM_DESC = lstLclsb_Temp[i_Lclsb].C_CCM_DESC;
                                mod_Sms.C_PROD_NAME = lstLclsb_Temp[i_Lclsb].C_PROD_NAME;
                                mod_Sms.C_STL_GRD = lstLclsb_Temp[i_Lclsb].C_STL_GRD;
                                mod_Sms.C_SPEC_CODE = lstLclsb_Temp[i_Lclsb].C_SPEC_CODE;
                                mod_Sms.C_LENGTH = lstLclsb_Temp[i_Lclsb].C_LENGTH;
                                mod_Sms.C_MATRL_NO = lstLclsb_Temp[i_Lclsb].C_MATRL_NO;
                                mod_Sms.C_MATRL_NAME = lstLclsb_Temp[i_Lclsb].C_MATRL_NAME;
                                mod_Sms.C_SLAB_SIZE = lstLclsb_Temp[i_Lclsb].C_SLAB_SIZE;
                                mod_Sms.C_SLAB_LENGTH = lstLclsb_Temp[i_Lclsb].C_SLAB_LENGTH;
                                mod_Sms.C_STATE = lstLclsb_Temp[i_Lclsb].C_STATE;
                                mod_Sms.C_STD_CODE = lstLclsb_Temp[i_Lclsb].C_STD_CODE;
                                mod_Sms.C_INITIALIZE_ITEM_ID = lstLclsb_Temp[i_Lclsb].C_INITIALIZE_ITEM_ID;
                                mod_Sms.D_P_START_TIME = startTime;//计划开始时间
                                mod_Sms.D_P_END_TIME = endTime;//计划结束时间
                                mod_Sms.N_PROD_TIME = lstLclsb_Temp[i_Lclsb].N_PROD_TIME;
                                mod_Sms.N_SORT = n_Sort;//顺序号
                                mod_Sms.C_CAST_NO = lstLclsb_Temp[i_Lclsb].C_CAST_NO;
                                mod_Sms.N_STATUS = lstLclsb_Temp[i_Lclsb].N_STATUS;
                                mod_Sms.C_EMP_ID = lstLclsb_Temp[i_Lclsb].C_EMP_ID;
                                mod_Sms.D_MOD_DT = lstLclsb_Temp[i_Lclsb].D_MOD_DT;
                                mod_Sms.C_REMARK = lstLclsb_Temp[i_Lclsb].C_REMARK;
                                mod_Sms.N_CREAT_PLAN = lstLclsb_Temp[i_Lclsb].N_CREAT_PLAN;
                                mod_Sms.N_CREAT_ZG_PLAN = lstLclsb_Temp[i_Lclsb].N_CREAT_ZG_PLAN;
                                mod_Sms.N_PRODUCE_TIME = lstLclsb_Temp[i_Lclsb].N_PRODUCE_TIME;
                                mod_Sms.C_ZL_ID = lstLclsb_Temp[i_Lclsb].C_ZL_ID;
                                mod_Sms.C_LF_ID = lstLclsb_Temp[i_Lclsb].C_LF_ID;
                                mod_Sms.C_RH_ID = lstLclsb_Temp[i_Lclsb].C_RH_ID;
                                mod_Sms.C_LGJH = lstLclsb_Temp[i_Lclsb].C_LGJH;
                                mod_Sms.C_QUA = lstLclsb_Temp[i_Lclsb].C_QUA;
                                mod_Sms.D_ARRIVE_ZG_TIME = lstLclsb_Temp[i_Lclsb].D_ARRIVE_ZG_TIME;
                                mod_Sms.C_BY1 = lstLclsb_Temp[i_Lclsb].C_BY1;
                                mod_Sms.C_BY2 = lstLclsb_Temp[i_Lclsb].C_BY2;
                                mod_Sms.C_BY3 = lstLclsb_Temp[i_Lclsb].C_BY3;
                                mod_Sms.C_RH = lstLclsb_Temp[i_Lclsb].C_RH;
                                mod_Sms.C_DFP_HL = lstLclsb_Temp[i_Lclsb].C_DFP_HL;
                                mod_Sms.C_HL = lstLclsb_Temp[i_Lclsb].C_HL;
                                mod_Sms.C_XM = lstLclsb_Temp[i_Lclsb].C_XM;
                                mod_Sms.D_DFPHL_START_TIME = lstLclsb_Temp[i_Lclsb].D_DFPHL_START_TIME;
                                mod_Sms.D_DFPHL_END_TIME = lstLclsb_Temp[i_Lclsb].D_DFPHL_END_TIME;
                                mod_Sms.D_KP_START_TIME = lstLclsb_Temp[i_Lclsb].D_KP_START_TIME;
                                mod_Sms.D_KP_END_TIME = lstLclsb_Temp[i_Lclsb].D_KP_END_TIME;
                                mod_Sms.D_HL_START_TIME = lstLclsb_Temp[i_Lclsb].D_HL_START_TIME;
                                mod_Sms.D_HL_END_TIME = lstLclsb_Temp[i_Lclsb].D_HL_END_TIME;
                                mod_Sms.D_PLAN_KY_TIME = lstLclsb_Temp[i_Lclsb].D_PLAN_KY_TIME;
                                mod_Sms.C_PLAN_ROLL = lstLclsb_Temp[i_Lclsb].C_PLAN_ROLL;
                                mod_Sms.D_ZZ_START_TIME = lstLclsb_Temp[i_Lclsb].D_ZZ_START_TIME;
                                mod_Sms.D_ZZ_END_TIME = lstLclsb_Temp[i_Lclsb].D_ZZ_END_TIME;
                                mod_Sms.D_XM_START_TIME = lstLclsb_Temp[i_Lclsb].D_XM_START_TIME;
                                mod_Sms.D_XM_END_TIME = lstLclsb_Temp[i_Lclsb].D_XM_END_TIME;
                                mod_Sms.C_STOVE_NO = lstLclsb_Temp[i_Lclsb].C_STOVE_NO;
                                mod_Sms.D_DFPHL_START_TIME_SJ = lstLclsb_Temp[i_Lclsb].D_DFPHL_START_TIME_SJ;
                                mod_Sms.D_DFPHL_END_TIME_SJ = lstLclsb_Temp[i_Lclsb].D_DFPHL_END_TIME_SJ;
                                mod_Sms.D_KP_START_TIME_SJ = lstLclsb_Temp[i_Lclsb].D_KP_START_TIME_SJ;
                                mod_Sms.D_KP_END_TIME_SJ = lstLclsb_Temp[i_Lclsb].D_KP_END_TIME_SJ;
                                mod_Sms.D_HL_START_TIME_SJ = lstLclsb_Temp[i_Lclsb].D_HL_START_TIME_SJ;
                                mod_Sms.D_HL_END_TIME_SJ = lstLclsb_Temp[i_Lclsb].D_HL_END_TIME_SJ;
                                mod_Sms.D_XM_START_TIME_SJ = lstLclsb_Temp[i_Lclsb].D_XM_START_TIME_SJ;
                                mod_Sms.D_XM_END_TIME_SJ = lstLclsb_Temp[i_Lclsb].D_XM_END_TIME_SJ;
                                mod_Sms.N_SJ_WGT = lstLclsb_Temp[i_Lclsb].N_SJ_WGT;
                                mod_Sms.D_START_TIME_SJ = lstLclsb_Temp[i_Lclsb].D_START_TIME_SJ;
                                mod_Sms.D_END_TIME_SJ = lstLclsb_Temp[i_Lclsb].D_END_TIME_SJ;
                                mod_Sms.N_DFP_HL_TIME = lstLclsb_Temp[i_Lclsb].N_DFP_HL_TIME;
                                mod_Sms.N_HL_TIME = lstLclsb_Temp[i_Lclsb].N_HL_TIME;
                                mod_Sms.C_ROUTE = lstLclsb_Temp[i_Lclsb].C_ROUTE;
                                mod_Sms.N_SLAB_PW = lstLclsb_Temp[i_Lclsb].N_SLAB_PW;
                                mod_Sms.C_MATRL_CODE_KP = lstLclsb_Temp[i_Lclsb].C_MATRL_CODE_KP;
                                mod_Sms.C_MATRL_NAME_KP = lstLclsb_Temp[i_Lclsb].C_MATRL_NAME_KP;
                                mod_Sms.C_KP_SIZE = lstLclsb_Temp[i_Lclsb].C_KP_SIZE;
                                mod_Sms.N_KP_LENGTH = lstLclsb_Temp[i_Lclsb].N_KP_LENGTH;
                                mod_Sms.N_KP_PW = lstLclsb_Temp[i_Lclsb].N_KP_PW;
                                mod_Sms.N_USE_WGT = Convert.ToInt32(lstLclsb_Temp[i_Lclsb].N_USE_WGT);
                                mod_Sms.D_USE_START_TIME_SJ = lstLclsb_Temp[i_Lclsb].D_USE_START_TIME_SJ;
                                mod_Sms.D_USE_END_TIME_SJ = lstLclsb_Temp[i_Lclsb].D_USE_END_TIME_SJ;
                                mod_Sms.D_CAN_USE_TIME = endTime.AddHours(2);//可用时间
                                mod_Sms.N_RH_NUM = lstLclsb_Temp[i_Lclsb].N_RH_NUM;
                                mod_Sms.N_KP_WGT = lstLclsb_Temp[i_Lclsb].N_KP_WGT;
                                mod_Sms.N_XM_WGT = lstLclsb_Temp[i_Lclsb].N_XM_WGT;
                                mod_Sms.C_DFP_RZ = string.IsNullOrEmpty(lstLclsb_Temp[i_Lclsb].C_DFP_RZ) == true ? "N" : lstLclsb_Temp[i_Lclsb].C_DFP_RZ;
                                mod_Sms.C_RZP_RZ = string.IsNullOrEmpty(lstLclsb_Temp[i_Lclsb].C_RZP_RZ) == true ? "N" : lstLclsb_Temp[i_Lclsb].C_RZP_RZ;
                                mod_Sms.C_DFP_YQ = lstLclsb_Temp[i_Lclsb].C_DFP_YQ;
                                mod_Sms.C_RZP_YQ = lstLclsb_Temp[i_Lclsb].C_RZP_YQ;
                                mod_Sms.C_STL_GRD_TYPE = lstLclsb_Temp[i_Lclsb].C_STL_GRD_TYPE;
                                mod_Sms.C_PROD_KIND = lstLclsb_Temp[i_Lclsb].C_PROD_KIND;
                                mod_Sms.C_TL = lstLclsb_Temp[i_Lclsb].C_TL;
                                mod_Sms.N_JSCN = lstLclsb_Temp[i_Lclsb].N_JSCN;
                                mod_Sms.C_FREE1 = lstLclsb_Temp[i_Lclsb].C_FREE1;
                                mod_Sms.C_FREE2 = lstLclsb_Temp[i_Lclsb].C_FREE2;
                                mod_Sms.N_GROUP = lstLclsb_Temp[i_Lclsb].N_GROUP;
                                mod_Sms.C_FK = lstLclsb_Temp[i_Lclsb].C_FK;
                                mod_Sms.N_ZJCLS = lstLclsb_Temp[i_Lclsb].N_ZJCLS;
                                mod_Sms.N_ZJCLS_MIN = lstLclsb_Temp[i_Lclsb].N_ZJCLS_MIN;
                                mod_Sms.N_ZJCLS_MAX = lstLclsb_Temp[i_Lclsb].N_ZJCLS_MAX;
                                mod_Sms.C_SL = lstLclsb_Temp[i_Lclsb].C_SL;
                                mod_Sms.C_WL = lstLclsb_Temp[i_Lclsb].C_WL;
                                mod_Sms.C_SLAB_TYPE = lstLclsb_Temp[i_Lclsb].C_SLAB_TYPE;
                                mod_Sms.C_LGJH = "2";//新增计划

                                #endregion                                

                                lstPlanSlab.Add(mod_Sms);

                                #endregion

                                #region 将TPP_LGPC_LCLSB表数据停用

                                lstLclsb_Temp[i_Lclsb].N_STATUS = 0;

                                #endregion
                            }

                            JC_EndTime = endTime;

                            int Sort_JC = Convert.ToInt32(lstJCLsb.Where(x => x.C_CCM_ID == lstLclsb_Temp[0].C_CCM_ID).Max(a => a.N_SORT));
                            if (Sort_JC == 0)
                            {
                                Sort_JC = dalTspCastPlanTest.Max_jc_sort(lstLclsb_Temp[0].C_CCM_ID);
                            }

                            Sort_JC++;

                            var lstJC = lstJCLsb.Where(x => x.C_ID == lst_FK[i].Key.C_FK).ToList();
                            lstJC[0].N_SORT = Sort_JC;
                            lstJC[0].D_P_START_TIME = JC_StratTime;
                            lstJC[0].D_P_END_TIME = JC_EndTime;
                            lstJC[0].N_STATUS = 1;
                            lstJC[0].C_PLAN_ROLL = "2";

                            num++;
                        }

                        if (IsTL)
                        {
                            continue;
                        }
                        else
                        {
                            break;
                        }
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
                bool IsTL = false;

                var lst_FK = lstLcLsb.Where(x => x.N_STATUS == 1 && !string.IsNullOrEmpty(x.C_FK)).GroupBy(x => new { x.C_FK }).ToList();

                if (lst_FK.Count > 0)
                {
                    int n_Sort = 0;
                    DateTime startTime = DateTime.Now;
                    DateTime endTime = startTime.AddMinutes(30);

                    for (int i_FK = 0; i_FK < lst_FK.Count; i_FK++)
                    {
                        IsTL = false;

                        string strID = lst_FK[i_FK].Key.C_FK;

                        List<Mod_TPP_LGPC_LCLSB_TEST> lstLclsb_Temp = lstLcLsb.Where(x => x.C_FK == strID && x.N_STATUS == 1).OrderBy(x => x.N_SORT).ToList();

                        var lstPlanSlab_Temp = lstPlanSlab.Where(x => x.C_CCM_ID == lstLclsb_Temp[0].C_CCM_ID).ToList();
                        if (lstPlanSlab_Temp.Count > 0)
                        {
                            startTime = Convert.ToDateTime(lstPlanSlab_Temp.Max(x => x.D_P_END_TIME));
                            n_Sort = Convert.ToInt32(lstPlanSlab_Temp.Max(x => x.N_SORT));
                        }

                        #region 计划检修
                        var lstJX_Time = lstTJ.Where(x => x.C_STA_ID == lstLclsb_Temp[0].C_CCM_ID && ((startTime >= x.D_START_TIME && startTime < x.D_END_TIME) || (startTime.AddHours(5) >= x.D_START_TIME && startTime.AddHours(5) < x.D_END_TIME))).ToList();
                        if (lstJX_Time.Count > 0)
                        {
                            TimeSpan ts = Convert.ToDateTime(lstJX_Time[0].D_END_TIME) - Convert.ToDateTime(lstJX_Time[0].D_START_TIME);

                            int hh = ts.Hours;

                            lstJX_Time[0].D_START_TIME = startTime;

                            startTime = startTime.AddHours(hh);

                            lstJX_Time[0].D_END_TIME = startTime;
                        }
                        #endregion

                        DateTime JC_StratTime = startTime;
                        DateTime JC_EndTime;

                        #region 脱硫是否冲突
                        int count = lstLclsb_Temp.Where(x => x.C_TL == "Y").ToList().Count;
                        if (count > 0)
                        {
                            double dCN = Convert.ToDouble(lstLclsb_Temp.Sum(x => x.N_SLAB_WGT)) / Convert.ToDouble(lstLclsb_Temp[0].N_JSCN);
                            DateTime dtTime = startTime.AddHours(dCN);

                            var lstTL_FK = lstPlanSlab.Where(x => x.C_CCM_DESC == "5#CC" && x.C_TL == "Y" && x.D_P_START_TIME >= startTime && x.D_P_END_TIME <= dtTime).ToList();

                            if (lstTL_FK.Count > 0)
                            {
                                IsTL = true;

                                startTime = Convert.ToDateTime(lstTL_FK.Max(x => x.D_P_END_TIME));

                                continue;
                            }

                        }
                        #endregion

                        for (int i_Lclsb = 0; i_Lclsb < lstLclsb_Temp.Count; i_Lclsb++)
                        {
                            #region 计算3#CC、4#CC连铸生产顺序和计划开始时间和计划结束时间

                            n_Sort++;

                            double cn = 0;

                            cn = Convert.ToDouble(lstLclsb_Temp[i_Lclsb].N_SLAB_WGT) / Convert.ToDouble(lstLclsb_Temp[i_Lclsb].N_JSCN);

                            if (i_Lclsb == 0)
                            {
                                endTime = startTime.AddHours(cn);
                            }
                            else
                            {
                                startTime = endTime;
                                endTime = startTime.AddHours(cn);
                            }

                            #endregion

                            #region 将炉次计划添加到lstPlanSlab中

                            #region 实体赋值

                            Mod_TSP_PLAN_SMS_TEST mod_Sms = new Mod_TSP_PLAN_SMS_TEST();
                            mod_Sms.C_ID = lstLclsb_Temp[i_Lclsb].C_ID;
                            mod_Sms.C_ORDER_NO = lstLclsb_Temp[i_Lclsb].C_ORDER_NO;
                            mod_Sms.C_DESIGN_NO = lstLclsb_Temp[i_Lclsb].C_DESIGN_NO;
                            mod_Sms.N_SLAB_WGT = lstLclsb_Temp[i_Lclsb].N_SLAB_WGT;
                            mod_Sms.C_CTRL_NO = lstLclsb_Temp[i_Lclsb].C_CTRL_NO;
                            mod_Sms.C_CCM_ID = lstLclsb_Temp[i_Lclsb].C_CCM_ID;
                            mod_Sms.C_CCM_DESC = lstLclsb_Temp[i_Lclsb].C_CCM_DESC;
                            mod_Sms.C_PROD_NAME = lstLclsb_Temp[i_Lclsb].C_PROD_NAME;
                            mod_Sms.C_STL_GRD = lstLclsb_Temp[i_Lclsb].C_STL_GRD;
                            mod_Sms.C_SPEC_CODE = lstLclsb_Temp[i_Lclsb].C_SPEC_CODE;
                            mod_Sms.C_LENGTH = lstLclsb_Temp[i_Lclsb].C_LENGTH;
                            mod_Sms.C_MATRL_NO = lstLclsb_Temp[i_Lclsb].C_MATRL_NO;
                            mod_Sms.C_MATRL_NAME = lstLclsb_Temp[i_Lclsb].C_MATRL_NAME;
                            mod_Sms.C_SLAB_SIZE = lstLclsb_Temp[i_Lclsb].C_SLAB_SIZE;
                            mod_Sms.C_SLAB_LENGTH = lstLclsb_Temp[i_Lclsb].C_SLAB_LENGTH;
                            mod_Sms.C_STATE = lstLclsb_Temp[i_Lclsb].C_STATE;
                            mod_Sms.C_STD_CODE = lstLclsb_Temp[i_Lclsb].C_STD_CODE;
                            mod_Sms.C_INITIALIZE_ITEM_ID = lstLclsb_Temp[i_Lclsb].C_INITIALIZE_ITEM_ID;
                            mod_Sms.D_P_START_TIME = startTime;//计划开始时间
                            mod_Sms.D_P_END_TIME = endTime;//计划结束时间
                            mod_Sms.N_PROD_TIME = lstLclsb_Temp[i_Lclsb].N_PROD_TIME;
                            mod_Sms.N_SORT = n_Sort;//顺序号
                            mod_Sms.C_CAST_NO = lstLclsb_Temp[i_Lclsb].C_CAST_NO;
                            mod_Sms.N_STATUS = lstLclsb_Temp[i_Lclsb].N_STATUS;
                            mod_Sms.C_EMP_ID = lstLclsb_Temp[i_Lclsb].C_EMP_ID;
                            mod_Sms.D_MOD_DT = lstLclsb_Temp[i_Lclsb].D_MOD_DT;
                            mod_Sms.C_REMARK = lstLclsb_Temp[i_Lclsb].C_REMARK;
                            mod_Sms.N_CREAT_PLAN = lstLclsb_Temp[i_Lclsb].N_CREAT_PLAN;
                            mod_Sms.N_CREAT_ZG_PLAN = lstLclsb_Temp[i_Lclsb].N_CREAT_ZG_PLAN;
                            mod_Sms.N_PRODUCE_TIME = lstLclsb_Temp[i_Lclsb].N_PRODUCE_TIME;
                            mod_Sms.C_ZL_ID = lstLclsb_Temp[i_Lclsb].C_ZL_ID;
                            mod_Sms.C_LF_ID = lstLclsb_Temp[i_Lclsb].C_LF_ID;
                            mod_Sms.C_RH_ID = lstLclsb_Temp[i_Lclsb].C_RH_ID;
                            mod_Sms.C_LGJH = lstLclsb_Temp[i_Lclsb].C_LGJH;
                            mod_Sms.C_QUA = lstLclsb_Temp[i_Lclsb].C_QUA;
                            mod_Sms.D_ARRIVE_ZG_TIME = lstLclsb_Temp[i_Lclsb].D_ARRIVE_ZG_TIME;
                            mod_Sms.C_BY1 = lstLclsb_Temp[i_Lclsb].C_BY1;
                            mod_Sms.C_BY2 = lstLclsb_Temp[i_Lclsb].C_BY2;
                            mod_Sms.C_BY3 = lstLclsb_Temp[i_Lclsb].C_BY3;
                            mod_Sms.C_RH = lstLclsb_Temp[i_Lclsb].C_RH;
                            mod_Sms.C_DFP_HL = lstLclsb_Temp[i_Lclsb].C_DFP_HL;
                            mod_Sms.C_HL = lstLclsb_Temp[i_Lclsb].C_HL;
                            mod_Sms.C_XM = lstLclsb_Temp[i_Lclsb].C_XM;
                            mod_Sms.D_DFPHL_START_TIME = lstLclsb_Temp[i_Lclsb].D_DFPHL_START_TIME;
                            mod_Sms.D_DFPHL_END_TIME = lstLclsb_Temp[i_Lclsb].D_DFPHL_END_TIME;
                            mod_Sms.D_KP_START_TIME = lstLclsb_Temp[i_Lclsb].D_KP_START_TIME;
                            mod_Sms.D_KP_END_TIME = lstLclsb_Temp[i_Lclsb].D_KP_END_TIME;
                            mod_Sms.D_HL_START_TIME = lstLclsb_Temp[i_Lclsb].D_HL_START_TIME;
                            mod_Sms.D_HL_END_TIME = lstLclsb_Temp[i_Lclsb].D_HL_END_TIME;
                            mod_Sms.D_PLAN_KY_TIME = lstLclsb_Temp[i_Lclsb].D_PLAN_KY_TIME;
                            mod_Sms.C_PLAN_ROLL = lstLclsb_Temp[i_Lclsb].C_PLAN_ROLL;
                            mod_Sms.D_ZZ_START_TIME = lstLclsb_Temp[i_Lclsb].D_ZZ_START_TIME;
                            mod_Sms.D_ZZ_END_TIME = lstLclsb_Temp[i_Lclsb].D_ZZ_END_TIME;
                            mod_Sms.D_XM_START_TIME = lstLclsb_Temp[i_Lclsb].D_XM_START_TIME;
                            mod_Sms.D_XM_END_TIME = lstLclsb_Temp[i_Lclsb].D_XM_END_TIME;
                            mod_Sms.C_STOVE_NO = lstLclsb_Temp[i_Lclsb].C_STOVE_NO;
                            mod_Sms.D_DFPHL_START_TIME_SJ = lstLclsb_Temp[i_Lclsb].D_DFPHL_START_TIME_SJ;
                            mod_Sms.D_DFPHL_END_TIME_SJ = lstLclsb_Temp[i_Lclsb].D_DFPHL_END_TIME_SJ;
                            mod_Sms.D_KP_START_TIME_SJ = lstLclsb_Temp[i_Lclsb].D_KP_START_TIME_SJ;
                            mod_Sms.D_KP_END_TIME_SJ = lstLclsb_Temp[i_Lclsb].D_KP_END_TIME_SJ;
                            mod_Sms.D_HL_START_TIME_SJ = lstLclsb_Temp[i_Lclsb].D_HL_START_TIME_SJ;
                            mod_Sms.D_HL_END_TIME_SJ = lstLclsb_Temp[i_Lclsb].D_HL_END_TIME_SJ;
                            mod_Sms.D_XM_START_TIME_SJ = lstLclsb_Temp[i_Lclsb].D_XM_START_TIME_SJ;
                            mod_Sms.D_XM_END_TIME_SJ = lstLclsb_Temp[i_Lclsb].D_XM_END_TIME_SJ;
                            mod_Sms.N_SJ_WGT = lstLclsb_Temp[i_Lclsb].N_SJ_WGT;
                            mod_Sms.D_START_TIME_SJ = lstLclsb_Temp[i_Lclsb].D_START_TIME_SJ;
                            mod_Sms.D_END_TIME_SJ = lstLclsb_Temp[i_Lclsb].D_END_TIME_SJ;
                            mod_Sms.N_DFP_HL_TIME = lstLclsb_Temp[i_Lclsb].N_DFP_HL_TIME;
                            mod_Sms.N_HL_TIME = lstLclsb_Temp[i_Lclsb].N_HL_TIME;
                            mod_Sms.C_ROUTE = lstLclsb_Temp[i_Lclsb].C_ROUTE;
                            mod_Sms.N_SLAB_PW = lstLclsb_Temp[i_Lclsb].N_SLAB_PW;
                            mod_Sms.C_MATRL_CODE_KP = lstLclsb_Temp[i_Lclsb].C_MATRL_CODE_KP;
                            mod_Sms.C_MATRL_NAME_KP = lstLclsb_Temp[i_Lclsb].C_MATRL_NAME_KP;
                            mod_Sms.C_KP_SIZE = lstLclsb_Temp[i_Lclsb].C_KP_SIZE;
                            mod_Sms.N_KP_LENGTH = lstLclsb_Temp[i_Lclsb].N_KP_LENGTH;
                            mod_Sms.N_KP_PW = lstLclsb_Temp[i_Lclsb].N_KP_PW;
                            mod_Sms.N_USE_WGT = Convert.ToInt32(lstLclsb_Temp[i_Lclsb].N_USE_WGT);
                            mod_Sms.D_USE_START_TIME_SJ = lstLclsb_Temp[i_Lclsb].D_USE_START_TIME_SJ;
                            mod_Sms.D_USE_END_TIME_SJ = lstLclsb_Temp[i_Lclsb].D_USE_END_TIME_SJ;
                            mod_Sms.D_CAN_USE_TIME = endTime.AddHours(2);//可用时间
                            mod_Sms.N_RH_NUM = lstLclsb_Temp[i_Lclsb].N_RH_NUM;
                            mod_Sms.N_KP_WGT = lstLclsb_Temp[i_Lclsb].N_KP_WGT;
                            mod_Sms.N_XM_WGT = lstLclsb_Temp[i_Lclsb].N_XM_WGT;
                            mod_Sms.C_DFP_RZ = string.IsNullOrEmpty(lstLclsb_Temp[i_Lclsb].C_DFP_RZ) == true ? "N" : lstLclsb_Temp[i_Lclsb].C_DFP_RZ;
                            mod_Sms.C_RZP_RZ = string.IsNullOrEmpty(lstLclsb_Temp[i_Lclsb].C_RZP_RZ) == true ? "N" : lstLclsb_Temp[i_Lclsb].C_RZP_RZ;
                            mod_Sms.C_DFP_YQ = lstLclsb_Temp[i_Lclsb].C_DFP_YQ;
                            mod_Sms.C_RZP_YQ = lstLclsb_Temp[i_Lclsb].C_RZP_YQ;
                            mod_Sms.C_STL_GRD_TYPE = lstLclsb_Temp[i_Lclsb].C_STL_GRD_TYPE;
                            mod_Sms.C_PROD_KIND = lstLclsb_Temp[i_Lclsb].C_PROD_KIND;
                            mod_Sms.C_TL = lstLclsb_Temp[i_Lclsb].C_TL;
                            mod_Sms.N_JSCN = lstLclsb_Temp[i_Lclsb].N_JSCN;
                            mod_Sms.C_FREE1 = lstLclsb_Temp[i_Lclsb].C_FREE1;
                            mod_Sms.C_FREE2 = lstLclsb_Temp[i_Lclsb].C_FREE2;
                            mod_Sms.N_GROUP = lstLclsb_Temp[i_Lclsb].N_GROUP;
                            mod_Sms.C_FK = lstLclsb_Temp[i_Lclsb].C_FK;
                            mod_Sms.N_ZJCLS = lstLclsb_Temp[i_Lclsb].N_ZJCLS;
                            mod_Sms.N_ZJCLS_MIN = lstLclsb_Temp[i_Lclsb].N_ZJCLS_MIN;
                            mod_Sms.N_ZJCLS_MAX = lstLclsb_Temp[i_Lclsb].N_ZJCLS_MAX;
                            mod_Sms.C_SL = lstLclsb_Temp[i_Lclsb].C_SL;
                            mod_Sms.C_WL = lstLclsb_Temp[i_Lclsb].C_WL;
                            mod_Sms.C_SLAB_TYPE = lstLclsb_Temp[i_Lclsb].C_SLAB_TYPE;
                            mod_Sms.C_LGJH = "2";//新增计划

                            #endregion

                            lstPlanSlab.Add(mod_Sms);

                            #endregion

                            #region 将TPP_LGPC_LCLSB表数据停用

                            lstLclsb_Temp[i_Lclsb].N_STATUS = 0;

                            #endregion
                        }

                        JC_EndTime = endTime;

                        int Sort_JC = Convert.ToInt32(lstJCLsb.Where(x => x.C_CCM_ID == lstLclsb_Temp[0].C_CCM_ID).Max(a => a.N_SORT));
                        if (Sort_JC == 0)
                        {
                            Sort_JC = dalTspCastPlanTest.Max_jc_sort(lstLclsb_Temp[0].C_CCM_ID);
                        }

                        Sort_JC++;

                        var lstJC = lstJCLsb.Where(x => x.C_ID == lst_FK[i_FK].Key.C_FK).ToList();
                        lstJC[0].N_SORT = Sort_JC;
                        lstJC[0].D_P_START_TIME = JC_StratTime;
                        lstJC[0].D_P_END_TIME = JC_EndTime;
                        lstJC[0].N_STATUS = 1;
                        lstJC[0].C_PLAN_ROLL = "2";
                    }

                    //脱硫冲突
                    if (IsTL)
                    {
                        List<Mod_TPP_LGPC_LCLSB_TEST> lstLclsb_Temp = lstLcLsb.Where(x => x.C_FK == lst_FK[0].Key.C_FK && x.N_STATUS == 1).OrderBy(x => x.N_SORT).ToList();

                        var lstPlanSlab_Temp = lstPlanSlab.Where(x => x.C_CCM_ID == lstLclsb_Temp[0].C_CCM_ID).ToList();
                        if (lstPlanSlab_Temp.Count > 0)
                        {
                            n_Sort = Convert.ToInt32(lstPlanSlab_Temp.Max(x => x.N_SORT));
                        }

                        for (int i_Lclsb = 0; i_Lclsb < lstLclsb_Temp.Count; i_Lclsb++)
                        {
                            #region 计算3#CC、4#CC连铸生产顺序和计划开始时间和计划结束时间

                            n_Sort++;

                            double cn = 0;

                            cn = Convert.ToDouble(lstLclsb_Temp[i_Lclsb].N_SLAB_WGT) / Convert.ToDouble(lstLclsb_Temp[i_Lclsb].N_JSCN);

                            if (i_Lclsb == 0)
                            {
                                endTime = startTime.AddHours(cn);
                            }
                            else
                            {
                                startTime = endTime;
                                endTime = startTime.AddHours(cn);
                            }

                            #endregion

                            #region 将炉次计划添加到lstPlanSlab中

                            #region 实体赋值

                            Mod_TSP_PLAN_SMS_TEST mod_Sms = new Mod_TSP_PLAN_SMS_TEST();
                            mod_Sms.C_ID = lstLclsb_Temp[i_Lclsb].C_ID;
                            mod_Sms.C_ORDER_NO = lstLclsb_Temp[i_Lclsb].C_ORDER_NO;
                            mod_Sms.C_DESIGN_NO = lstLclsb_Temp[i_Lclsb].C_DESIGN_NO;
                            mod_Sms.N_SLAB_WGT = lstLclsb_Temp[i_Lclsb].N_SLAB_WGT;
                            mod_Sms.C_CTRL_NO = lstLclsb_Temp[i_Lclsb].C_CTRL_NO;
                            mod_Sms.C_CCM_ID = lstLclsb_Temp[i_Lclsb].C_CCM_ID;
                            mod_Sms.C_CCM_DESC = lstLclsb_Temp[i_Lclsb].C_CCM_DESC;
                            mod_Sms.C_PROD_NAME = lstLclsb_Temp[i_Lclsb].C_PROD_NAME;
                            mod_Sms.C_STL_GRD = lstLclsb_Temp[i_Lclsb].C_STL_GRD;
                            mod_Sms.C_SPEC_CODE = lstLclsb_Temp[i_Lclsb].C_SPEC_CODE;
                            mod_Sms.C_LENGTH = lstLclsb_Temp[i_Lclsb].C_LENGTH;
                            mod_Sms.C_MATRL_NO = lstLclsb_Temp[i_Lclsb].C_MATRL_NO;
                            mod_Sms.C_MATRL_NAME = lstLclsb_Temp[i_Lclsb].C_MATRL_NAME;
                            mod_Sms.C_SLAB_SIZE = lstLclsb_Temp[i_Lclsb].C_SLAB_SIZE;
                            mod_Sms.C_SLAB_LENGTH = lstLclsb_Temp[i_Lclsb].C_SLAB_LENGTH;
                            mod_Sms.C_STATE = lstLclsb_Temp[i_Lclsb].C_STATE;
                            mod_Sms.C_STD_CODE = lstLclsb_Temp[i_Lclsb].C_STD_CODE;
                            mod_Sms.C_INITIALIZE_ITEM_ID = lstLclsb_Temp[i_Lclsb].C_INITIALIZE_ITEM_ID;
                            mod_Sms.D_P_START_TIME = startTime;//计划开始时间
                            mod_Sms.D_P_END_TIME = endTime;//计划结束时间
                            mod_Sms.N_PROD_TIME = lstLclsb_Temp[i_Lclsb].N_PROD_TIME;
                            mod_Sms.N_SORT = n_Sort;//顺序号
                            mod_Sms.C_CAST_NO = lstLclsb_Temp[i_Lclsb].C_CAST_NO;
                            mod_Sms.N_STATUS = lstLclsb_Temp[i_Lclsb].N_STATUS;
                            mod_Sms.C_EMP_ID = lstLclsb_Temp[i_Lclsb].C_EMP_ID;
                            mod_Sms.D_MOD_DT = lstLclsb_Temp[i_Lclsb].D_MOD_DT;
                            mod_Sms.C_REMARK = lstLclsb_Temp[i_Lclsb].C_REMARK;
                            mod_Sms.N_CREAT_PLAN = lstLclsb_Temp[i_Lclsb].N_CREAT_PLAN;
                            mod_Sms.N_CREAT_ZG_PLAN = lstLclsb_Temp[i_Lclsb].N_CREAT_ZG_PLAN;
                            mod_Sms.N_PRODUCE_TIME = lstLclsb_Temp[i_Lclsb].N_PRODUCE_TIME;
                            mod_Sms.C_ZL_ID = lstLclsb_Temp[i_Lclsb].C_ZL_ID;
                            mod_Sms.C_LF_ID = lstLclsb_Temp[i_Lclsb].C_LF_ID;
                            mod_Sms.C_RH_ID = lstLclsb_Temp[i_Lclsb].C_RH_ID;
                            mod_Sms.C_LGJH = lstLclsb_Temp[i_Lclsb].C_LGJH;
                            mod_Sms.C_QUA = lstLclsb_Temp[i_Lclsb].C_QUA;
                            mod_Sms.D_ARRIVE_ZG_TIME = lstLclsb_Temp[i_Lclsb].D_ARRIVE_ZG_TIME;
                            mod_Sms.C_BY1 = lstLclsb_Temp[i_Lclsb].C_BY1;
                            mod_Sms.C_BY2 = lstLclsb_Temp[i_Lclsb].C_BY2;
                            mod_Sms.C_BY3 = lstLclsb_Temp[i_Lclsb].C_BY3;
                            mod_Sms.C_RH = lstLclsb_Temp[i_Lclsb].C_RH;
                            mod_Sms.C_DFP_HL = lstLclsb_Temp[i_Lclsb].C_DFP_HL;
                            mod_Sms.C_HL = lstLclsb_Temp[i_Lclsb].C_HL;
                            mod_Sms.C_XM = lstLclsb_Temp[i_Lclsb].C_XM;
                            mod_Sms.D_DFPHL_START_TIME = lstLclsb_Temp[i_Lclsb].D_DFPHL_START_TIME;
                            mod_Sms.D_DFPHL_END_TIME = lstLclsb_Temp[i_Lclsb].D_DFPHL_END_TIME;
                            mod_Sms.D_KP_START_TIME = lstLclsb_Temp[i_Lclsb].D_KP_START_TIME;
                            mod_Sms.D_KP_END_TIME = lstLclsb_Temp[i_Lclsb].D_KP_END_TIME;
                            mod_Sms.D_HL_START_TIME = lstLclsb_Temp[i_Lclsb].D_HL_START_TIME;
                            mod_Sms.D_HL_END_TIME = lstLclsb_Temp[i_Lclsb].D_HL_END_TIME;
                            mod_Sms.D_PLAN_KY_TIME = lstLclsb_Temp[i_Lclsb].D_PLAN_KY_TIME;
                            mod_Sms.C_PLAN_ROLL = lstLclsb_Temp[i_Lclsb].C_PLAN_ROLL;
                            mod_Sms.D_ZZ_START_TIME = lstLclsb_Temp[i_Lclsb].D_ZZ_START_TIME;
                            mod_Sms.D_ZZ_END_TIME = lstLclsb_Temp[i_Lclsb].D_ZZ_END_TIME;
                            mod_Sms.D_XM_START_TIME = lstLclsb_Temp[i_Lclsb].D_XM_START_TIME;
                            mod_Sms.D_XM_END_TIME = lstLclsb_Temp[i_Lclsb].D_XM_END_TIME;
                            mod_Sms.C_STOVE_NO = lstLclsb_Temp[i_Lclsb].C_STOVE_NO;
                            mod_Sms.D_DFPHL_START_TIME_SJ = lstLclsb_Temp[i_Lclsb].D_DFPHL_START_TIME_SJ;
                            mod_Sms.D_DFPHL_END_TIME_SJ = lstLclsb_Temp[i_Lclsb].D_DFPHL_END_TIME_SJ;
                            mod_Sms.D_KP_START_TIME_SJ = lstLclsb_Temp[i_Lclsb].D_KP_START_TIME_SJ;
                            mod_Sms.D_KP_END_TIME_SJ = lstLclsb_Temp[i_Lclsb].D_KP_END_TIME_SJ;
                            mod_Sms.D_HL_START_TIME_SJ = lstLclsb_Temp[i_Lclsb].D_HL_START_TIME_SJ;
                            mod_Sms.D_HL_END_TIME_SJ = lstLclsb_Temp[i_Lclsb].D_HL_END_TIME_SJ;
                            mod_Sms.D_XM_START_TIME_SJ = lstLclsb_Temp[i_Lclsb].D_XM_START_TIME_SJ;
                            mod_Sms.D_XM_END_TIME_SJ = lstLclsb_Temp[i_Lclsb].D_XM_END_TIME_SJ;
                            mod_Sms.N_SJ_WGT = lstLclsb_Temp[i_Lclsb].N_SJ_WGT;
                            mod_Sms.D_START_TIME_SJ = lstLclsb_Temp[i_Lclsb].D_START_TIME_SJ;
                            mod_Sms.D_END_TIME_SJ = lstLclsb_Temp[i_Lclsb].D_END_TIME_SJ;
                            mod_Sms.N_DFP_HL_TIME = lstLclsb_Temp[i_Lclsb].N_DFP_HL_TIME;
                            mod_Sms.N_HL_TIME = lstLclsb_Temp[i_Lclsb].N_HL_TIME;
                            mod_Sms.C_ROUTE = lstLclsb_Temp[i_Lclsb].C_ROUTE;
                            mod_Sms.N_SLAB_PW = lstLclsb_Temp[i_Lclsb].N_SLAB_PW;
                            mod_Sms.C_MATRL_CODE_KP = lstLclsb_Temp[i_Lclsb].C_MATRL_CODE_KP;
                            mod_Sms.C_MATRL_NAME_KP = lstLclsb_Temp[i_Lclsb].C_MATRL_NAME_KP;
                            mod_Sms.C_KP_SIZE = lstLclsb_Temp[i_Lclsb].C_KP_SIZE;
                            mod_Sms.N_KP_LENGTH = lstLclsb_Temp[i_Lclsb].N_KP_LENGTH;
                            mod_Sms.N_KP_PW = lstLclsb_Temp[i_Lclsb].N_KP_PW;
                            mod_Sms.N_USE_WGT = lstLclsb_Temp[i_Lclsb].N_USE_WGT;
                            mod_Sms.D_USE_START_TIME_SJ = lstLclsb_Temp[i_Lclsb].D_USE_START_TIME_SJ;
                            mod_Sms.D_USE_END_TIME_SJ = lstLclsb_Temp[i_Lclsb].D_USE_END_TIME_SJ;
                            mod_Sms.D_CAN_USE_TIME = endTime.AddHours(2);//可用时间
                            mod_Sms.N_RH_NUM = lstLclsb_Temp[i_Lclsb].N_RH_NUM;
                            mod_Sms.N_KP_WGT = lstLclsb_Temp[i_Lclsb].N_KP_WGT;
                            mod_Sms.N_XM_WGT = lstLclsb_Temp[i_Lclsb].N_XM_WGT;
                            mod_Sms.C_DFP_RZ = string.IsNullOrEmpty(lstLclsb_Temp[i_Lclsb].C_DFP_RZ) == true ? "N" : lstLclsb_Temp[i_Lclsb].C_DFP_RZ;
                            mod_Sms.C_RZP_RZ = string.IsNullOrEmpty(lstLclsb_Temp[i_Lclsb].C_RZP_RZ) == true ? "N" : lstLclsb_Temp[i_Lclsb].C_RZP_RZ;
                            mod_Sms.C_DFP_YQ = lstLclsb_Temp[i_Lclsb].C_DFP_YQ;
                            mod_Sms.C_RZP_YQ = lstLclsb_Temp[i_Lclsb].C_RZP_YQ;
                            mod_Sms.C_STL_GRD_TYPE = lstLclsb_Temp[i_Lclsb].C_STL_GRD_TYPE;
                            mod_Sms.C_PROD_KIND = lstLclsb_Temp[i_Lclsb].C_PROD_KIND;
                            mod_Sms.C_TL = lstLclsb_Temp[i_Lclsb].C_TL;
                            mod_Sms.N_JSCN = lstLclsb_Temp[i_Lclsb].N_JSCN;
                            mod_Sms.C_FREE1 = lstLclsb_Temp[i_Lclsb].C_FREE1;
                            mod_Sms.C_FREE2 = lstLclsb_Temp[i_Lclsb].C_FREE2;
                            mod_Sms.N_GROUP = lstLclsb_Temp[i_Lclsb].N_GROUP;
                            mod_Sms.C_FK = lstLclsb_Temp[i_Lclsb].C_FK;
                            mod_Sms.N_ZJCLS = lstLclsb_Temp[i_Lclsb].N_ZJCLS;
                            mod_Sms.N_ZJCLS_MIN = lstLclsb_Temp[i_Lclsb].N_ZJCLS_MIN;
                            mod_Sms.N_ZJCLS_MAX = lstLclsb_Temp[i_Lclsb].N_ZJCLS_MAX;
                            mod_Sms.C_SL = lstLclsb_Temp[i_Lclsb].C_SL;
                            mod_Sms.C_WL = lstLclsb_Temp[i_Lclsb].C_WL;
                            mod_Sms.C_SLAB_TYPE = lstLclsb_Temp[i_Lclsb].C_SLAB_TYPE;
                            mod_Sms.C_LGJH = "2";//新增计划

                            #endregion

                            lstPlanSlab.Add(mod_Sms);

                            #endregion

                            #region 将TPP_LGPC_LCLSB表数据停用

                            lstLclsb_Temp[i_Lclsb].N_STATUS = 0;

                            #endregion
                        }
                    }
                }
                else
                {
                    return "0";
                }

                return "1";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

            #endregion
        }


        #region 指定轧钢计划

        /// <summary>
        /// 更新炼钢计划钢坯可用量
        /// </summary>
        /// <returns></returns>
        private decimal Update_Slab_Wgt_ZD(string c_line_code, string strSpec, string strGzBz)
        {
            try
            {
                Bll_TB_STA bllSta = new Bll_TB_STA();
                Mod_TB_STA modSta = bllSta.GetModel(c_line_code);

                c_line_code = modSta.C_STA_CODE;

                string strTime = RV.UI.ServerTime.timeNow().ToString();

                decimal dWgt = 0;//可轧重量
                decimal dPlanWgt = 0;
                decimal dSlabWgt = 0;
                string timeStart = "";
                decimal n_zg_wgt = 0;//轧钢排产量
                //string strOrderID = "";//订单主键          
                string timeStart_sj = "";
                int hggTime = 0;


                #region 获取可轧时间

                var lstUp = lstPlanRoll.Where(x => x.C_LINE_CODE == c_line_code && !string.IsNullOrEmpty(x.D_P_END_TIME.ToString())).ToList();

                if (lstUp.Count > 1)
                {
                    lstUp = lstUp.OrderByDescending(x => Convert.ToDateTime(x.D_P_END_TIME)).ToList();

                    hggTime = dalChangeTime.Get_Time(c_line_code, lstUp[0].C_SPEC, strSpec);//换规格时间

                    strTime = Convert.ToDateTime(lstUp[0].D_P_END_TIME).AddMinutes(hggTime).ToString();
                }

                string timeSlab = lstPlanSlab.Where(x => x.N_USE_WGT > 0 && (strGzBz.Contains(x.C_STL_GRD + "|" + x.C_STD_CODE))).Min(x => x.D_CAN_USE_TIME).ToString();

                //if (Convert.ToDateTime(strTime).AddHours(1) < RV.UI.ServerTime.timeNow())
                //{
                //    strTime = RV.UI.ServerTime.timeNow().ToString();
                //}

                #region 计划检修
                var lstJX = lstTJ.Where(x => x.C_STA_CODE == c_line_code && Convert.ToDateTime(strTime) >= x.D_START_TIME && Convert.ToDateTime(strTime) < x.D_END_TIME).ToList();
                if (lstJX.Count > 0)
                {
                    TimeSpan ts = Convert.ToDateTime(lstJX[0].D_END_TIME) - Convert.ToDateTime(lstJX[0].D_START_TIME);
                    //time_KZ = Convert.ToDateTime(lstJX[0].D_END_TIME);
                    strTime = Convert.ToDateTime(strTime).AddHours(ts.Hours).ToString();
                }
                #endregion

                if (Convert.ToDateTime(timeSlab) > Convert.ToDateTime(strTime))
                {
                    strTime = timeSlab;
                }

                #endregion

                var lstPlanRoll_Temp = lstPlanRoll.Where(x => x.C_LINE_CODE == c_line_code && x.C_SPEC == strSpec && (x.N_STATUS == 0 || x.N_STATUS == 1) && x.N_ROLL_PROD_WGT < x.N_WGT).ToList();

                //var lstPlanRoll_StdGrd = lstPlanRoll_Temp.GroupBy(x => new { x.C_STL_GRD, x.C_STD_CODE }).ToList();//获取待轧的轧钢计划的钢种和执行标准

                lstPlanRoll_Temp = lstPlanRoll_Temp.OrderByDescending(x => x.N_WGT - x.N_ROLL_PROD_WGT).ThenByDescending(x => x.C_STL_GRD).ThenByDescending(x => x.C_STD_CODE).ToList();//获取指定规格待轧的轧钢计划


                bool IsJX = false;

                while (true)
                {
                    int num = 0;

                    for (int i_ZG = 0; i_ZG < lstPlanRoll_Temp.Count; i_ZG++)
                    {
                        if (!string.IsNullOrEmpty(lstPlanRoll_Temp[i_ZG].D_P_START_TIME.ToString()))
                        {
                            timeStart = lstPlanRoll_Temp[i_ZG].D_P_START_TIME.ToString();
                        }
                        else
                        {
                            timeStart = strTime;
                        }

                        timeStart_sj = strTime;

                        //strOrderID = lstPlanRoll_Temp[i_ZG].C_INITIALIZE_ITEM_ID.ToString();//订单主键

                        dPlanWgt = Convert.ToDecimal(lstPlanRoll_Temp[i_ZG].N_WGT - lstPlanRoll_Temp[i_ZG].N_ROLL_PROD_WGT);//未排产量
                        n_zg_wgt = dPlanWgt;

                        bool IsCompleted = false;

                        while (!IsCompleted)
                        {
                            if (dPlanWgt <= 0)
                            {
                                num++;
                                break;
                            }

                            //var lst = lstPlanSlab.Where(x => x.C_STL_GRD == lstPlanRoll_Temp[i_ZG].C_STL_GRD && x.C_STD_CODE == lstPlanRoll_Temp[i_ZG].C_STD_CODE && x.N_USE_WGT > 0 && x.D_CAN_USE_TIME < (Convert.ToDateTime(strTime).AddMinutes(30))).ToList();

                            var lst = lstPlanSlab.Where(x => lstPlanRoll_Temp[i_ZG].C_REMARK5.Contains(x.C_STL_GRD + "|" + x.C_STD_CODE) && x.N_USE_WGT > 0 && x.D_CAN_USE_TIME < (Convert.ToDateTime(strTime).AddMinutes(30))).ToList();

                            if (lst.Count > 0)
                            {
                                for (int i_Slab = 0; i_Slab < lst.Count; i_Slab++)
                                {
                                    dSlabWgt = Convert.ToDecimal(lst[i_Slab].N_USE_WGT.ToString());

                                    if (dSlabWgt <= 0)
                                    {
                                        continue;
                                    }

                                    if (dPlanWgt >= dSlabWgt)
                                    {
                                        double cn = Convert.ToDouble(dSlabWgt / Convert.ToDecimal(lstPlanRoll_Temp[i_ZG].N_MACH_WGT.ToString()));
                                        strTime = Convert.ToDateTime(strTime).AddHours(cn).ToString();//结束时间

                                        #region 计划检修
                                        var lstJX_Time = lstTJ.Where(x => x.C_STA_CODE == c_line_code && Convert.ToDateTime(strTime) >= x.D_START_TIME && Convert.ToDateTime(strTime) < x.D_END_TIME).ToList();
                                        if (lstJX_Time.Count > 0)
                                        {
                                            IsJX = true;
                                            break;
                                        }
                                        #endregion

                                        dPlanWgt = dPlanWgt - dSlabWgt;
                                        dWgt = dWgt + dSlabWgt;

                                        #region 更新炼钢计划可用钢坯量

                                        lst[i_Slab].N_USE_WGT = 0;

                                        #endregion
                                    }
                                    else
                                    {
                                        double cn = Convert.ToDouble(dPlanWgt / Convert.ToDecimal(lstPlanRoll_Temp[i_ZG].N_MACH_WGT.ToString()));
                                        strTime = Convert.ToDateTime(strTime).AddHours(cn).ToString();//结束时间

                                        #region 计划检修
                                        var lstJX_Time = lstTJ.Where(x => x.C_STA_CODE == c_line_code && Convert.ToDateTime(strTime) >= x.D_START_TIME && Convert.ToDateTime(strTime) < x.D_END_TIME).ToList();
                                        if (lstJX_Time.Count > 0)
                                        {
                                            IsJX = true;
                                            break;
                                        }
                                        #endregion

                                        dWgt = dWgt + dPlanWgt;

                                        #region 更新炼钢计划可用钢坯量

                                        lst[i_Slab].N_USE_WGT = lst[i_Slab].N_USE_WGT - dPlanWgt;

                                        #endregion

                                        dPlanWgt = 0;

                                        break;
                                    }
                                }

                                if (IsJX)
                                {
                                    break;
                                }

                            }
                            else
                            {
                                num++;
                                IsCompleted = true;
                            }
                        }


                        if (n_zg_wgt == dPlanWgt)
                        {
                            if (IsJX)
                            {
                                break;
                            }
                            else
                            {
                                continue;
                            }
                        }
                        else
                        {
                            num = 0;

                            #region 添加计划明细TRP_PLAN_ITEM

                            Mod_TRP_PLAN_ITEM_TEST modelItem = new Mod_TRP_PLAN_ITEM_TEST();
                            modelItem.C_PLAN_ROLL_ID = lstPlanRoll_Temp[i_ZG].C_ID;
                            modelItem.N_STATUS = lstPlanRoll_Temp[i_ZG].N_STATUS;
                            modelItem.C_INITIALIZE_ITEM_ID = lstPlanRoll_Temp[i_ZG].C_INITIALIZE_ITEM_ID;
                            modelItem.C_ORDER_NO = lstPlanRoll_Temp[i_ZG].C_ORDER_NO;
                            modelItem.N_WGT = lstPlanRoll_Temp[i_ZG].N_WGT;
                            modelItem.C_MAT_CODE = lstPlanRoll_Temp[i_ZG].C_MAT_CODE;
                            modelItem.C_MAT_NAME = lstPlanRoll_Temp[i_ZG].C_MAT_NAME;
                            modelItem.C_TECH_PROT = lstPlanRoll_Temp[i_ZG].C_TECH_PROT;
                            modelItem.C_SPEC = lstPlanRoll_Temp[i_ZG].C_SPEC;
                            modelItem.C_STL_GRD = lstPlanRoll_Temp[i_ZG].C_STL_GRD;
                            modelItem.C_STD_CODE = lstPlanRoll_Temp[i_ZG].C_STD_CODE;
                            modelItem.N_USER_LEV = lstPlanRoll_Temp[i_ZG].N_USER_LEV;
                            modelItem.N_STL_GRD_LEV = lstPlanRoll_Temp[i_ZG].N_STL_GRD_LEV;
                            modelItem.N_ORDER_LEV = lstPlanRoll_Temp[i_ZG].N_ORDER_LEV;
                            modelItem.C_QUALIRY_LEV = lstPlanRoll_Temp[i_ZG].C_QUALIRY_LEV;
                            modelItem.D_NEED_DT = lstPlanRoll_Temp[i_ZG].D_NEED_DT;
                            modelItem.D_DELIVERY_DT = lstPlanRoll_Temp[i_ZG].D_DELIVERY_DT;
                            modelItem.D_DT = lstPlanRoll_Temp[i_ZG].D_DT;
                            modelItem.C_LINE_DESC = lstPlanRoll_Temp[i_ZG].C_LINE_DESC;
                            modelItem.C_LINE_CODE = lstPlanRoll_Temp[i_ZG].C_LINE_CODE;
                            modelItem.D_P_START_TIME = Convert.ToDateTime(timeStart_sj);//计划开始时间
                            modelItem.D_P_END_TIME = Convert.ToDateTime(strTime);//计划结束时间
                            modelItem.N_PROD_TIME = lstPlanRoll_Temp[i_ZG].N_PROD_TIME;
                            modelItem.N_SORT = lstPlanRoll_Temp[i_ZG].N_SORT;
                            modelItem.N_ROLL_PROD_WGT = n_zg_wgt - dPlanWgt;//排产量
                            modelItem.C_ROLL_PROD_EMP_ID = lstPlanRoll_Temp[i_ZG].C_ROLL_PROD_EMP_ID;
                            modelItem.C_STL_ROL_DT = lstPlanRoll_Temp[i_ZG].C_STL_ROL_DT;
                            modelItem.N_PROD_WGT = lstPlanRoll_Temp[i_ZG].N_PROD_WGT;
                            modelItem.N_WARE_WGT = lstPlanRoll_Temp[i_ZG].N_WARE_WGT;
                            modelItem.N_WARE_OUT_WGT = lstPlanRoll_Temp[i_ZG].N_WARE_OUT_WGT;
                            modelItem.N_FLAG = lstPlanRoll_Temp[i_ZG].N_FLAG;
                            modelItem.N_ISSUE_WGT = lstPlanRoll_Temp[i_ZG].N_ISSUE_WGT;
                            modelItem.C_CUST_NO = lstPlanRoll_Temp[i_ZG].C_CUST_NO;
                            modelItem.C_CUST_NAME = lstPlanRoll_Temp[i_ZG].C_CUST_NAME;
                            modelItem.C_SALE_CHANNEL = lstPlanRoll_Temp[i_ZG].C_SALE_CHANNEL;
                            modelItem.C_PACK = lstPlanRoll_Temp[i_ZG].C_PACK;
                            modelItem.C_DESIGN_NO = lstPlanRoll_Temp[i_ZG].C_DESIGN_NO;
                            modelItem.N_GROUP_WGT = lstPlanRoll_Temp[i_ZG].N_GROUP_WGT;
                            modelItem.C_STA_ID = lstPlanRoll_Temp[i_ZG].C_STA_ID;
                            modelItem.D_START_TIME = lstPlanRoll_Temp[i_ZG].D_START_TIME;
                            modelItem.D_END_TIME = lstPlanRoll_Temp[i_ZG].D_END_TIME;
                            modelItem.C_EMP_ID = lstPlanRoll_Temp[i_ZG].C_EMP_ID;
                            modelItem.D_MOD_DT = lstPlanRoll_Temp[i_ZG].D_MOD_DT;
                            modelItem.N_ROLL_WGT = lstPlanRoll_Temp[i_ZG].N_ROLL_WGT;
                            modelItem.N_MACH_WGT = lstPlanRoll_Temp[i_ZG].N_MACH_WGT;
                            modelItem.C_CAST_NO = lstPlanRoll_Temp[i_ZG].C_CAST_NO;
                            modelItem.C_INITIALIZE_ID = lstPlanRoll_Temp[i_ZG].C_INITIALIZE_ID;
                            modelItem.C_FREE_TERM = lstPlanRoll_Temp[i_ZG].C_FREE_TERM;
                            modelItem.C_FREE_TERM2 = lstPlanRoll_Temp[i_ZG].C_FREE_TERM2;
                            modelItem.C_AREA = lstPlanRoll_Temp[i_ZG].C_AREA;
                            modelItem.C_PCLX = lstPlanRoll_Temp[i_ZG].C_PCLX;
                            modelItem.C_SFHL = lstPlanRoll_Temp[i_ZG].C_SFHL;
                            modelItem.D_HL_START_TIME = lstPlanRoll_Temp[i_ZG].D_HL_START_TIME;
                            modelItem.D_HL_END_TIME = lstPlanRoll_Temp[i_ZG].D_HL_END_TIME;
                            modelItem.C_SFHL_D = lstPlanRoll_Temp[i_ZG].C_SFHL_D;
                            modelItem.D_DHL_START_TIME = lstPlanRoll_Temp[i_ZG].D_DHL_START_TIME;
                            modelItem.D_DHL_END_TIME = lstPlanRoll_Temp[i_ZG].D_DHL_END_TIME;
                            modelItem.C_SFKP = lstPlanRoll_Temp[i_ZG].C_SFKP;
                            modelItem.D_KP_START_TIME = lstPlanRoll_Temp[i_ZG].D_KP_START_TIME;
                            modelItem.D_KP_END_TIME = lstPlanRoll_Temp[i_ZG].D_KP_END_TIME;
                            modelItem.C_SFXM = lstPlanRoll_Temp[i_ZG].C_SFXM;
                            modelItem.D_XM_START_TIME = lstPlanRoll_Temp[i_ZG].D_XM_START_TIME;
                            modelItem.D_XM_END_TIME = lstPlanRoll_Temp[i_ZG].D_XM_END_TIME;
                            //modelItem.N_UPLOADSTATUS = lstPlanRoll_Temp[i_ZG].N_UPLOADSTATUS;
                            modelItem.C_MATRL_CODE_SLAB = lstPlanRoll_Temp[i_ZG].C_MATRL_CODE_SLAB;
                            modelItem.C_MATRL_NAME_SLAB = lstPlanRoll_Temp[i_ZG].C_MATRL_NAME_SLAB;
                            modelItem.C_SLAB_SIZE = lstPlanRoll_Temp[i_ZG].C_SLAB_SIZE;
                            modelItem.N_SLAB_LENGTH = lstPlanRoll_Temp[i_ZG].N_SLAB_LENGTH;
                            modelItem.N_SLAB_PW = lstPlanRoll_Temp[i_ZG].N_SLAB_PW;
                            //modelItem.D_CAN_ROLL_TIME = lstPlanRoll_Temp[i_ZG].D_CAN_ROLL_TIME;
                            //modelItem.C_ROUTE = lstPlanRoll_Temp[i_ZG].C_ROUTE;
                            //modelItem.N_DIAMETER = lstPlanRoll_Temp[i_ZG].N_DIAMETER;
                            //modelItem.C_XM_YQ = lstPlanRoll_Temp[i_ZG].C_XM_YQ;
                            //modelItem.N_JRL_WD = lstPlanRoll_Temp[i_ZG].N_JRL_WD;
                            //modelItem.N_JRL_SJ = lstPlanRoll_Temp[i_ZG].N_JRL_SJ;

                            lstPlanItem.Add(modelItem);

                            #endregion

                            lstPlanRoll_Temp[i_ZG].N_ROLL_PROD_WGT = lstPlanRoll_Temp[i_ZG].N_ROLL_PROD_WGT + (n_zg_wgt - dPlanWgt);
                            lstPlanRoll_Temp[i_ZG].D_P_START_TIME = Convert.ToDateTime(timeStart);
                            lstPlanRoll_Temp[i_ZG].D_P_END_TIME = Convert.ToDateTime(strTime);

                            break;
                        }
                    }


                    if (IsJX)
                    {
                        break;
                    }

                    //没有找到可轧钢坯或者可轧计划
                    if (num == lstPlanRoll_Temp.Count)
                    {
                        break;
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


        #region 先排已下发的计划

        /// <summary>
        /// 检测是否有可排轧钢计划(已下发计划)
        /// </summary>
        /// <param name="dt_Line">轧线</param>
        /// <returns>0-没有可排轧钢计划；1-有可排轧钢计划；其他-出错</returns>
        private string Check_Plan_YP(List<ZGLine> lstLine)
        {
            try
            {
                lst_LineSpec.Clear();

                var lstSLAB = CopyList(lstPlanSlab);

                List<SpecWgt> lstSpecWgt = new List<SpecWgt>();
                List<CastInfo> lstCastTemp = new List<CastInfo>();

                string result = "0";

                decimal wgt_kz = 0;
                string strSpec = "";

                lst_Cast.Clear();

                for (int i_Line = 0; i_Line < lstLine.Count; i_Line++)
                {
                    DateTime time_KZ = RV.UI.ServerTime.timeNow();
                    strSpec = "";
                    string timeSlab = lstSLAB.Where(x => x.N_USE_WGT > 0).Min(x => x.D_CAN_USE_TIME).ToString();
                    List<LineSpec> lstSpec = new List<LineSpec>();
                    string strLineCode = lstLine[i_Line].C_LINE_CODE;
                    var lst_Spec_Temp = lst_Spec.Where(x => x.C_LINE_CODE == strLineCode).ToList();
                    lst_SlabPlan.Clear();
                    lstCastTemp.Clear();

                    lstSpec = lst_Spec_Temp;

                    #region 还剩可轧规格
                    var lstPlanRoll_Temp = lstPlanRoll.Where(x => x.N_STATUS == 1 && x.C_LINE_CODE == strLineCode && x.N_ROLL_PROD_WGT < x.N_WGT).GroupBy(x => new { x.C_SPEC }).Select(a => new { a.Key.C_SPEC, N_wgt = a.Sum(b => b.N_WGT - b.N_ROLL_PROD_WGT) }).ToList();

                    if (lstPlanRoll_Temp.Count == 0)
                    {
                        continue;
                    }

                    var lstUp = lstPlanRoll.Where(x => x.C_LINE_CODE == strLineCode && !string.IsNullOrEmpty(x.D_P_END_TIME.ToString())).OrderByDescending(a => Convert.ToDateTime(a.D_P_END_TIME)).ToList();
                    if (lstUp.Count > 0)
                    {
                        time_KZ = Convert.ToDateTime(lstUp[0].D_P_END_TIME);//上一个计划结束时间

                        strSpec = lstUp[0].C_SPEC;
                    }

                    string sSpce = "";
                    for (int i = 0; i < lstPlanRoll_Temp.Count; i++)
                    {
                        sSpce = sSpce + lstPlanRoll_Temp[i].C_SPEC + ",";
                    }
                    #endregion

                    for (int i_Spec = 0; i_Spec < lstSpec.Count; i_Spec++)
                    {
                        if (!sSpce.Contains(lstSpec[i_Spec].C_SPEC))
                        {
                            continue;
                        }

                        int hggTime = dalChangeTime.Get_Time(strLineCode, strSpec, lstSpec[i_Spec].C_SPEC);//换规格时间

                        time_KZ = time_KZ.AddMinutes(hggTime);

                        #region 计划检修
                        var lstJX = lstTJ.Where(x => x.C_STA_CODE == strLineCode && time_KZ >= x.D_START_TIME && time_KZ < x.D_END_TIME).ToList();
                        if (lstJX.Count > 0)
                        {
                            TimeSpan ts = Convert.ToDateTime(lstJX[0].D_END_TIME) - Convert.ToDateTime(lstJX[0].D_START_TIME);

                            time_KZ = time_KZ.AddHours(ts.Hours);
                        }
                        #endregion

                        if (!string.IsNullOrEmpty(timeCC))
                        {
                            if (time_KZ < Convert.ToDateTime(timeCC))
                            {
                                time_KZ = Convert.ToDateTime(timeCC);
                            }
                        }

                        if (Convert.ToDateTime(time_KZ) < Convert.ToDateTime(timeSlab))
                        {
                            continue;
                        }

                        lst_Temp.Clear();

                        string strError = "";
                        wgt_kz = Get_Slab_Wgt_New(strLineCode, lstSpec[i_Spec].C_SPEC, time_KZ.ToString(), out lst_Temp, lstSLAB, out strError);

                        if (strError == "正常")
                        {
                            if (wgt_kz == 0)
                            {
                                continue;
                            }
                            else
                            {
                                SpecWgt sw = new SpecWgt(lstSpec[i_Spec].C_SPEC, wgt_kz, strLineCode, time_KZ.ToString());
                                lstSpecWgt.Add(sw);

                                bool isFind = false;
                                for (int mm = 0; mm < lst_Temp.Count; mm++)
                                {
                                    isFind = false;
                                    if (lstCastTemp.Count == 0)
                                    {
                                        lstCastTemp.Add(lst_Temp[mm]);
                                        continue;
                                    }
                                    else
                                    {
                                        for (int jcNum = 0; jcNum < lstCastTemp.Count; jcNum++)
                                        {
                                            if (lst_Temp[mm].C_STL_GRD == lstCastTemp[jcNum].C_STL_GRD && lst_Temp[mm].C_STD_CODE == lstCastTemp[jcNum].C_STD_CODE && lst_Temp[mm].C_SPEC == lstCastTemp[jcNum].C_SPEC && lst_Temp[mm].C_LINE_CODE == lstCastTemp[jcNum].C_LINE_CODE)
                                            {
                                                isFind = true;
                                                lstCastTemp[jcNum].N_WGT = lstCastTemp[jcNum].N_WGT + lst_Temp[mm].N_WGT;
                                                break;
                                            }
                                            else
                                            {
                                                continue;
                                            }
                                        }

                                        if (!isFind)
                                        {
                                            lstCastTemp.Add(lst_Temp[mm]);
                                        }
                                    }
                                }
                            }
                        }
                        else
                        {
                            return strError;
                            //return "1";
                        }
                    }


                    #region 查找符合的计划

                    var lst = lstSpecWgt.Where(x => x.C_LINE_CODE == lstLine[i_Line].C_LINE_CODE).ToList();
                    if (lst.Count > 0)
                    {
                        result = "1";

                        lst = lst.OrderByDescending(x => x.N_WGT).ToList();

                        LineSpec lineSpec = new LineSpec(strLineCode, lst[0].C_SPEC, lst[0].C_TIME);
                        lst_LineSpec.Add(lineSpec);

                        for (int i = 0; i < lst_SlabPlan.Count; i++)
                        {
                            for (int j = 0; j < lstSLAB.Count; j++)
                            {
                                if (lst_SlabPlan[i].C_PLAN_ID == lstSLAB[j].C_ID)
                                {
                                    lstSLAB[j].N_USE_WGT = lst_SlabPlan[i].N_WGT;
                                    break;
                                }
                            }
                        }

                        bool isFind = false;
                        for (int mm = 0; mm < lstCastTemp.Count; mm++)
                        {
                            isFind = false;
                            if (lst_Cast.Count == 0)
                            {
                                lst_Cast.Add(lstCastTemp[mm]);
                                continue;
                            }
                            else
                            {
                                for (int jcNum = 0; jcNum < lst_Cast.Count; jcNum++)
                                {
                                    if (lstCastTemp[mm].C_STL_GRD == lst_Cast[jcNum].C_STL_GRD && lstCastTemp[mm].C_STD_CODE == lst_Cast[jcNum].C_STD_CODE && lstCastTemp[mm].C_SPEC == lst_Cast[jcNum].C_SPEC && lstCastTemp[mm].C_LINE_CODE == lst_Cast[jcNum].C_LINE_CODE)
                                    {
                                        isFind = true;
                                        lst_Cast[jcNum].N_WGT = lst_Cast[jcNum].N_WGT + lstCastTemp[mm].N_WGT;
                                        break;
                                    }
                                    else
                                    {
                                        continue;
                                    }
                                }

                                if (!isFind)
                                {
                                    lst_Cast.Add(lstCastTemp[mm]);
                                }
                            }
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

        #endregion

        #endregion

    }
}

