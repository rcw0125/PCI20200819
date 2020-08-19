using System;
using System.Data;
using System.Collections.Generic;
using DAL;
using MODEL;
namespace BLL
{
    public class Bll_TRP_PLAN_ROLL_ITEM_INFO
    {
        private readonly Dal_TRP_PLAN_ROLL_ITEM_INFO dal = new Dal_TRP_PLAN_ROLL_ITEM_INFO();
        private readonly Dal_TRP_PLAN_ROLL_ITEM dalTrpPlanRollItem = new Dal_TRP_PLAN_ROLL_ITEM();
        private Dal_TRP_PLAN_ITEM dalTrpPlanItem = new Dal_TRP_PLAN_ITEM();//轧钢计划子表
        private Dal_TPB_CHANGESPEC_TIME dalChangeTime = new Dal_TPB_CHANGESPEC_TIME();//换规格时间
        private Dal_TRP_PLAN_ROLL dalTrpPlanRoll = new Dal_TRP_PLAN_ROLL();//轧钢计划

        public Bll_TRP_PLAN_ROLL_ITEM_INFO()
        { }
        #region  BasicMethod

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Mod_TRP_PLAN_ROLL_ITEM_INFO model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Mod_TRP_PLAN_ROLL_ITEM_INFO model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(string C_ID)
        {
            return dal.Delete(C_ID);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Mod_TRP_PLAN_ROLL_ITEM_INFO GetModel(string C_ID)
        {
            return dal.GetModel(C_ID);
        }


        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            return dal.GetList(strWhere);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Mod_TRP_PLAN_ROLL_ITEM_INFO> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Mod_TRP_PLAN_ROLL_ITEM_INFO> DataTableToList(DataTable dt)
        {
            List<Mod_TRP_PLAN_ROLL_ITEM_INFO> modelList = new List<Mod_TRP_PLAN_ROLL_ITEM_INFO>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Mod_TRP_PLAN_ROLL_ITEM_INFO model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = dal.DataRowToModel(dt.Rows[n]);
                    if (model != null)
                    {
                        modelList.Add(model);
                    }
                }
            }
            return modelList;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetAllList()
        {
            return GetList("");
        }

        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            return dal.GetRecordCount(strWhere);
        }
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
        {
            return dal.GetListByPage(strWhere, orderby, startIndex, endIndex);
        }


        #endregion  BasicMethod
        #region  ExtensionMethod

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string timeS, string timeE, string c_stl_grd, string c_std_code, string c_sta_id, string n_status)
        {
            return dal.GetList(timeS, timeE, c_stl_grd, c_std_code, c_sta_id, n_status);
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Mod_TRP_PLAN_ROLL_ITEM_INFO> GetModelList(string timeS, string timeE, string c_stl_grd, string c_std_code, string c_sta_id, string n_status)
        {
            return DataTableToList(GetList(timeS, timeE, c_stl_grd, c_std_code, c_sta_id, n_status).Tables[0]);
        }


        #region 轧钢计划下发
        /// <summary>
        /// 下发轧钢计划（合并）
        /// </summary>
        /// <param name="strPlanID">计划实例</param>
        /// <param name="i_Wgt">重量</param>
        /// <returns></returns>
        public string DownPlans(Mod_TRP_PLAN_ROLL_ITEM_INFO itemInfo, decimal i_Wgt, List<string> ids, string area)
        {
            try
            {
                string result = "1";

                TransactionHelper.BeginTransaction();

                Dal_TB_STA dalTbSta = new Dal_TB_STA();

                DateTime dtStart;
                DateTime dtEnd;

                Mod_TB_STA modSta = dalTbSta.GetModel(itemInfo.C_STA_ID);


                Mod_TRP_PLAN_ROLL_ITEM modUp = dalTrpPlanRollItem.GetModel_Up(itemInfo.C_STA_ID);
                if (modUp == null)
                {
                    if (string.IsNullOrEmpty(modUp.D_P_START_TIME.ToString()))
                    {
                        TransactionHelper.RollBack();
                        return "系统没有已排的计划，请设置计划初始开始时间！";
                    }
                    else
                    {
                        dtStart = Convert.ToDateTime(modUp.D_P_START_TIME.ToString());
                    }
                }
                else
                {
                    int hggTime = dalChangeTime.Get_Time2(itemInfo.C_STA_ID, modUp.C_SPEC, itemInfo.C_SPEC);//换规格时间

                    dtStart = Convert.ToDateTime(modUp.D_P_END_TIME).AddMinutes(hggTime);


                }

                double cn = Convert.ToDouble(i_Wgt / Convert.ToDecimal(itemInfo.N_MACH_WGT.ToString()));
                dtEnd = dtStart.AddHours(cn);//结束时间

                #region TRP_PLAN_ROLL_ITEM赋值

                Mod_TRP_PLAN_ROLL_ITEM modItem = new Mod_TRP_PLAN_ROLL_ITEM();
                modItem.C_ID = DateTime.Now.ToString("yyyyMMddHHmmss") + new Random().Next(0, 1000);
                //modItem.C_PLAN_ROLL_ID = itemInfo.C_ID;//计划主表主键
                modItem.N_STATUS = 1;//已下发
                modItem.C_INITIALIZE_ITEM_ID = itemInfo.C_INITIALIZE_ITEM_ID;
                modItem.C_ORDER_NO = modItem.C_ID;
                modItem.N_WGT = i_Wgt;//下发量
                modItem.C_MAT_CODE = itemInfo.C_MAT_CODE;
                modItem.C_MAT_NAME = itemInfo.C_MAT_NAME;
                modItem.C_TECH_PROT = itemInfo.C_TECH_PROT;
                modItem.C_SPEC = itemInfo.C_SPEC;
                modItem.C_STL_GRD = itemInfo.C_STL_GRD;
                modItem.C_STD_CODE = itemInfo.C_STD_CODE;
                modItem.N_USER_LEV = itemInfo.N_USER_LEV;
                modItem.N_STL_GRD_LEV = itemInfo.N_STL_GRD_LEV;
                modItem.N_ORDER_LEV = itemInfo.N_ORDER_LEV;
                modItem.C_QUALIRY_LEV = itemInfo.C_QUALIRY_LEV;
                modItem.D_NEED_DT = itemInfo.D_NEED_DT;
                modItem.D_DELIVERY_DT = itemInfo.D_DELIVERY_DT;
                modItem.D_DT = itemInfo.D_DT;
                modItem.C_LINE_DESC = modSta.C_STA_DESC;
                modItem.C_LINE_CODE = modSta.C_STA_CODE;
                modItem.D_P_START_TIME = dtStart;//计划开始时间
                modItem.D_P_END_TIME = dtEnd;//计划结束时间
                modItem.N_PROD_TIME = itemInfo.N_PROD_TIME;
                modItem.N_SORT = itemInfo.N_SORT;
                modItem.N_ROLL_PROD_WGT = i_Wgt;//下发量
                modItem.C_ROLL_PROD_EMP_ID = itemInfo.C_ROLL_PROD_EMP_ID;
                modItem.C_STL_ROL_DT = itemInfo.C_STL_ROL_DT;
                modItem.N_PROD_WGT = itemInfo.N_PROD_WGT;
                modItem.N_WARE_WGT = itemInfo.N_WARE_WGT;
                modItem.N_WARE_OUT_WGT = itemInfo.N_WARE_OUT_WGT;
                modItem.N_FLAG = itemInfo.N_FLAG;
                modItem.N_ISSUE_WGT = i_Wgt;//下发量
                //modItem.C_CUST_NO = itemInfo.C_CUST_NO;
                //modItem.C_CUST_NAME = itemInfo.C_CUST_NAME;
                modItem.C_SALE_CHANNEL = itemInfo.C_SALE_CHANNEL;
                modItem.C_PACK = itemInfo.C_PACK;
                modItem.C_DESIGN_NO = itemInfo.C_DESIGN_NO;
                modItem.N_GROUP_WGT = itemInfo.N_GROUP_WGT;
                modItem.C_STA_ID = modSta.C_ID;
                modItem.D_START_TIME = itemInfo.D_START_TIME;
                modItem.D_END_TIME = itemInfo.D_END_TIME;
                modItem.C_EMP_ID = itemInfo.C_EMP_ID;
                modItem.D_MOD_DT = RV.UI.ServerTime.timeNow();
                modItem.N_ROLL_WGT = itemInfo.N_ROLL_WGT;
                modItem.N_MACH_WGT = itemInfo.N_MACH_WGT;
                modItem.C_CAST_NO = itemInfo.C_CAST_NO;
                modItem.C_INITIALIZE_ID = itemInfo.C_INITIALIZE_ID;
                modItem.C_FREE_TERM = itemInfo.C_FREE_TERM;
                modItem.C_FREE_TERM2 = itemInfo.C_FREE_TERM2;
                if (!string.IsNullOrWhiteSpace(area))
                    modItem.C_AREA = area;
                modItem.C_PCLX = itemInfo.C_PCLX;
                modItem.C_SFHL = itemInfo.C_SFHL;
                modItem.D_HL_START_TIME = itemInfo.D_HL_START_TIME;
                modItem.D_HL_END_TIME = itemInfo.D_HL_END_TIME;
                modItem.C_SFHL_D = itemInfo.C_SFHL_D;
                modItem.D_DHL_START_TIME = itemInfo.D_DHL_START_TIME;
                modItem.D_DHL_END_TIME = itemInfo.D_DHL_END_TIME;
                modItem.C_SFKP = itemInfo.C_SFKP;
                modItem.D_KP_START_TIME = itemInfo.D_KP_START_TIME;
                modItem.D_KP_END_TIME = itemInfo.D_KP_END_TIME;
                modItem.C_SFXM = itemInfo.C_SFXM;
                modItem.D_XM_START_TIME = itemInfo.D_XM_START_TIME;
                modItem.D_XM_END_TIME = itemInfo.D_XM_END_TIME;
                modItem.N_UPLOADSTATUS = itemInfo.N_UPLOADSTATUS;
                modItem.C_MATRL_CODE_SLAB = itemInfo.C_MATRL_CODE_SLAB;
                modItem.C_MATRL_NAME_SLAB = itemInfo.C_MATRL_NAME_SLAB;
                modItem.C_SLAB_SIZE = itemInfo.C_SLAB_SIZE;
                modItem.N_SLAB_LENGTH = itemInfo.N_SLAB_LENGTH;
                modItem.N_SLAB_PW = itemInfo.N_SLAB_PW;
                modItem.D_CAN_ROLL_TIME = itemInfo.D_CAN_ROLL_TIME;
                modItem.C_ROUTE = itemInfo.C_ROUTE;
                modItem.N_DIAMETER = itemInfo.N_DIAMETER;
                modItem.C_XM_YQ = itemInfo.C_XM_YQ;
                modItem.N_JRL_WD = itemInfo.N_JRL_WD;
                modItem.N_JRL_SJ = itemInfo.N_JRL_SJ;
                modItem.C_STL_GRD_SLAB = itemInfo.C_STL_GRD_SLAB;
                modItem.C_STD_CODE_SLAB = itemInfo.C_STD_CODE_SLAB;
                modItem.C_REMARK = itemInfo.C_REMARK;//换产线原因
                //modItem.C_REMARK1 = itemInfo.C_REMARK1;
                modItem.C_REMARK2 = itemInfo.C_REMARK2;
                modItem.C_REMARK3 = itemInfo.C_REMARK3;//换规格原因
                modItem.C_REMARK4 = itemInfo.C_REMARK4;
                modItem.C_REMARK5 = itemInfo.C_REMARK5;
                modItem.N_IS_MERGE = 1;

                #endregion

                if (!dalTrpPlanRollItem.Add_Tran(modItem))
                {
                    TransactionHelper.RollBack();
                    return "下发失败！";
                }

                if (ids.Count > 1)
                {
                    foreach (var id in ids)
                    {
                        var m = dal.GetModel(id);
                        m.C_ITEM_ID = modItem.C_ID;
                        m.N_STATUS = 3;
                        dal.Update(m);
                    }
                }
                //if (!dalTrpPlanRoll.Update_Trans(modelPlan))
                //{
                //    TransactionHelper.RollBack();
                //    return "下发失败！";
                //}

                TransactionHelper.Commit();

                if (ids.Count > 1)
                {

                    Dal_TRP_PLAN_ROLL_ITEM_INFO_LOG dalLog = new Dal_TRP_PLAN_ROLL_ITEM_INFO_LOG();
                    foreach (var id in ids)
                    {
                        {
                            var m = dal.GetModel(id);
                            Mod_TRP_PLAN_ROLL_ITEM_INFO_LOG log = new Mod_TRP_PLAN_ROLL_ITEM_INFO_LOG();
                            log.C_ID = m.C_ID;
                            log.C_PLAN_ROLL_ID = m.C_PLAN_ROLL_ID;
                            log.C_MAT_CODE = m.C_MAT_CODE;
                            log.C_MAT_NAME = m.C_MAT_NAME;
                            log.C_SPEC = m.C_SPEC;
                            log.C_STL_GRD = m.C_STL_GRD;
                            log.C_STD_CODE = m.C_STD_CODE;
                            log.C_MAT_NAME = m.C_MATRL_CODE_SLAB;
                            log.C_MATRL_NAME_SLAB = m.C_MATRL_NAME_SLAB;
                            log.C_SLAB_SIZE = m.C_SLAB_SIZE;
                            log.N_SLAB_LENGTH = m.N_SLAB_LENGTH;
                            log.N_SLAB_PW = m.N_SLAB_PW;
                            log.C_LINE_DESC = m.C_LINE_DESC;
                            log.C_LINE_CODE = m.C_LINE_CODE;
                            log.N_ISSUE_WGT = m.N_ISSUE_WGT;
                            log.C_ITEM_ID = m.C_ITEM_ID;
                            dalLog.Add(log);
                        }
                    }
                }

                return result;
            }
            catch
            {
                TransactionHelper.RollBack();
                return "下发失败！";
            }
        }

        /// <summary>
        /// 下发轧钢计划（单条）
        /// </summary>
        /// <param name="strPlanID">计划实例</param>
        /// <param name="i_Wgt">重量</param>
        /// <returns></returns>
        public string DownPlans(Mod_TRP_PLAN_ROLL_ITEM_INFO itemInfo)
        {
            try
            {
                string result = "1";

                TransactionHelper.BeginTransaction();

                Dal_TB_STA dalTbSta = new Dal_TB_STA();

                DateTime dtStart;
                DateTime dtEnd;

                Mod_TB_STA modSta = dalTbSta.GetModel(itemInfo.C_STA_ID);


                Mod_TRP_PLAN_ROLL_ITEM modUp = dalTrpPlanRollItem.GetModel_Up(itemInfo.C_STA_ID);
                if (modUp == null)
                {
                    if (string.IsNullOrEmpty(modUp.D_P_START_TIME.ToString()))
                    {
                        TransactionHelper.RollBack();
                        return "系统没有已排的计划，请设置计划初始开始时间！";
                    }
                    else
                    {
                        dtStart = Convert.ToDateTime(modUp.D_P_START_TIME.ToString());
                    }
                }
                else
                {
                    int hggTime = dalChangeTime.Get_Time2(itemInfo.C_STA_ID, modUp.C_SPEC, itemInfo.C_SPEC);//换规格时间

                    dtStart = Convert.ToDateTime(modUp.D_P_END_TIME).AddMinutes(hggTime);


                }

                double cn = Convert.ToDouble(itemInfo.N_ISSUE_WGT / Convert.ToDecimal(itemInfo.N_MACH_WGT.ToString()));
                dtEnd = dtStart.AddHours(cn);//结束时间

                #region TRP_PLAN_ROLL_ITEM赋值

                Mod_TRP_PLAN_ROLL_ITEM modItem = new Mod_TRP_PLAN_ROLL_ITEM();
                modItem.C_ID = itemInfo.C_ID;
                modItem.C_PLAN_ROLL_ID = itemInfo.C_PLAN_ROLL_ID;//计划主表主键
                modItem.N_STATUS = 1;//已下发
                modItem.C_INITIALIZE_ITEM_ID = itemInfo.C_INITIALIZE_ITEM_ID;
                modItem.C_ORDER_NO = itemInfo.C_ORDER_NO;
                modItem.N_WGT = itemInfo.N_WGT;//下发量
                modItem.C_MAT_CODE = itemInfo.C_MAT_CODE;
                modItem.C_MAT_NAME = itemInfo.C_MAT_NAME;
                modItem.C_TECH_PROT = itemInfo.C_TECH_PROT;
                modItem.C_SPEC = itemInfo.C_SPEC;
                modItem.C_STL_GRD = itemInfo.C_STL_GRD;
                modItem.C_STD_CODE = itemInfo.C_STD_CODE;
                modItem.N_USER_LEV = itemInfo.N_USER_LEV;
                modItem.N_STL_GRD_LEV = itemInfo.N_STL_GRD_LEV;
                modItem.N_ORDER_LEV = itemInfo.N_ORDER_LEV;
                modItem.C_QUALIRY_LEV = itemInfo.C_QUALIRY_LEV;
                modItem.D_NEED_DT = itemInfo.D_NEED_DT;
                modItem.D_DELIVERY_DT = itemInfo.D_DELIVERY_DT;
                modItem.D_DT = itemInfo.D_DT;
                modItem.C_LINE_DESC = modSta.C_STA_DESC;
                modItem.C_LINE_CODE = modSta.C_STA_CODE;
                modItem.D_P_START_TIME = dtStart;//计划开始时间
                modItem.D_P_END_TIME = dtEnd;//计划结束时间
                modItem.N_PROD_TIME = itemInfo.N_PROD_TIME;
                modItem.N_SORT = itemInfo.N_SORT;
                modItem.N_ROLL_PROD_WGT = itemInfo.N_ROLL_PROD_WGT;//下发量
                modItem.C_ROLL_PROD_EMP_ID = itemInfo.C_ROLL_PROD_EMP_ID;
                modItem.C_STL_ROL_DT = itemInfo.C_STL_ROL_DT;
                modItem.N_PROD_WGT = itemInfo.N_PROD_WGT;
                modItem.N_WARE_WGT = itemInfo.N_WARE_WGT;
                modItem.N_WARE_OUT_WGT = itemInfo.N_WARE_OUT_WGT;
                modItem.N_FLAG = itemInfo.N_FLAG;
                modItem.N_ISSUE_WGT = itemInfo.N_ISSUE_WGT;//下发量
                modItem.C_CUST_NO = itemInfo.C_CUST_NO;
                modItem.C_CUST_NAME = itemInfo.C_CUST_NAME;
                modItem.C_SALE_CHANNEL = itemInfo.C_SALE_CHANNEL;
                modItem.C_PACK = itemInfo.C_PACK;
                modItem.C_DESIGN_NO = itemInfo.C_DESIGN_NO;
                modItem.N_GROUP_WGT = itemInfo.N_GROUP_WGT;
                modItem.C_STA_ID = modSta.C_ID;
                modItem.D_START_TIME = itemInfo.D_START_TIME;
                modItem.D_END_TIME = itemInfo.D_END_TIME;
                modItem.C_EMP_ID = itemInfo.C_EMP_ID;
                modItem.D_MOD_DT = RV.UI.ServerTime.timeNow();
                modItem.N_ROLL_WGT = itemInfo.N_ROLL_WGT;
                modItem.N_MACH_WGT = itemInfo.N_MACH_WGT;
                modItem.C_CAST_NO = itemInfo.C_CAST_NO;
                modItem.C_INITIALIZE_ID = itemInfo.C_INITIALIZE_ID;
                modItem.C_FREE_TERM = itemInfo.C_FREE_TERM;
                modItem.C_FREE_TERM2 = itemInfo.C_FREE_TERM2;
                modItem.C_AREA = itemInfo.C_AREA;
                modItem.C_PCLX = itemInfo.C_PCLX;
                modItem.C_SFHL = itemInfo.C_SFHL;
                modItem.D_HL_START_TIME = itemInfo.D_HL_START_TIME;
                modItem.D_HL_END_TIME = itemInfo.D_HL_END_TIME;
                modItem.C_SFHL_D = itemInfo.C_SFHL_D;
                modItem.D_DHL_START_TIME = itemInfo.D_DHL_START_TIME;
                modItem.D_DHL_END_TIME = itemInfo.D_DHL_END_TIME;
                modItem.C_SFKP = itemInfo.C_SFKP;
                modItem.D_KP_START_TIME = itemInfo.D_KP_START_TIME;
                modItem.D_KP_END_TIME = itemInfo.D_KP_END_TIME;
                modItem.C_SFXM = itemInfo.C_SFXM;
                modItem.D_XM_START_TIME = itemInfo.D_XM_START_TIME;
                modItem.D_XM_END_TIME = itemInfo.D_XM_END_TIME;
                modItem.N_UPLOADSTATUS = itemInfo.N_UPLOADSTATUS;
                modItem.C_MATRL_CODE_SLAB = itemInfo.C_MATRL_CODE_SLAB;
                modItem.C_MATRL_NAME_SLAB = itemInfo.C_MATRL_NAME_SLAB;
                modItem.C_SLAB_SIZE = itemInfo.C_SLAB_SIZE;
                modItem.N_SLAB_LENGTH = itemInfo.N_SLAB_LENGTH;
                modItem.N_SLAB_PW = itemInfo.N_SLAB_PW;
                modItem.D_CAN_ROLL_TIME = itemInfo.D_CAN_ROLL_TIME;
                modItem.C_ROUTE = itemInfo.C_ROUTE;
                modItem.N_DIAMETER = itemInfo.N_DIAMETER;
                modItem.C_XM_YQ = itemInfo.C_XM_YQ;
                modItem.N_JRL_WD = itemInfo.N_JRL_WD;
                modItem.N_JRL_SJ = itemInfo.N_JRL_SJ;
                modItem.C_STL_GRD_SLAB = itemInfo.C_STL_GRD_SLAB;
                modItem.C_STD_CODE_SLAB = itemInfo.C_STD_CODE_SLAB;
                modItem.C_REMARK = itemInfo.C_REMARK;//换产线原因
                modItem.C_REMARK1 = itemInfo.C_REMARK1;
                modItem.C_REMARK2 = itemInfo.C_REMARK2;
                modItem.C_REMARK3 = itemInfo.C_REMARK3;//换规格原因
                modItem.C_REMARK4 = itemInfo.C_REMARK4;
                modItem.C_REMARK5 = itemInfo.C_REMARK5;


                #endregion

                if (!dalTrpPlanRollItem.Add_Tran(modItem))
                {
                    TransactionHelper.RollBack();
                    return "下发失败！";
                }

                itemInfo.N_STATUS = 2;
                if (!dal.Update(itemInfo))
                {
                    TransactionHelper.RollBack();
                    return "下发失败！";
                }


                TransactionHelper.Commit();
                return result;
            }
            catch
            {
                TransactionHelper.RollBack();
                return "下发失败！";
            }
        }

        /// <summary>
        /// 下发轧钢计划
        /// </summary>
        /// <param name="strPlanID">计划主键</param>
        /// <param name="i_Wgt">重量</param>
        /// <param name="strTime">开始时间</param>
        /// <param name="strRemark">备注</param>
        /// <param name="strLineID">轧线ID</param>
        /// <param name="strHGG">换规格原因</param>
        /// <returns></returns>
        public string DownPlan(string strPlanID, decimal i_Wgt, string strTime, string strRemark, string strLineID, string strHGG)
        {
            try
            {
                string result = "1";

                TransactionHelper.BeginTransaction();

                Dal_TB_STA dalTbSta = new Dal_TB_STA();

                DateTime dtStart;
                DateTime dtEnd;

                Mod_TB_STA modSta = dalTbSta.GetModel(strLineID);

                Mod_TRP_PLAN_ROLL modelPlan = dalTrpPlanRoll.GetModel(strPlanID);
                if (modelPlan == null)
                {
                    TransactionHelper.RollBack();
                    return "下发失败，没有找到计划信息！";
                }
                else
                {
                    modelPlan.N_ISSUE_WGT = modelPlan.N_ISSUE_WGT + i_Wgt;

                    if (modelPlan.N_ISSUE_WGT == modelPlan.N_WGT)
                    {
                        modelPlan.N_STATUS = 1;
                    }

                    Mod_TRP_PLAN_ROLL_ITEM_INFO modUp = dal.GetModel_Up(strLineID);
                    if (modUp == null)
                    {
                        if (string.IsNullOrEmpty(strTime))
                        {
                            TransactionHelper.RollBack();
                            return "系统没有已排的计划，请设置计划初始开始时间！";
                        }
                        else
                        {
                            dtStart = Convert.ToDateTime(strTime);
                        }
                    }
                    else
                    {
                        //换规格
                        if (modelPlan.C_SPEC != modUp.C_SPEC)
                        {
                            if (string.IsNullOrEmpty(strHGG))
                            {
                                TransactionHelper.RollBack();
                                return "下发的计划和上一个计划规格不同，请填写换规格原因！";
                            }
                        }

                        int hggTime = dalChangeTime.Get_Time2(strLineID, modUp.C_SPEC, modelPlan.C_SPEC);//换规格时间

                        dtStart = Convert.ToDateTime(modUp.D_P_END_TIME).AddMinutes(hggTime);

                        if (!string.IsNullOrEmpty(strTime))
                        {
                            if (dtStart < Convert.ToDateTime(strTime))
                            {
                                dtStart = Convert.ToDateTime(strTime);
                            }
                        }
                    }

                    double cn = Convert.ToDouble(i_Wgt / Convert.ToDecimal(modelPlan.N_MACH_WGT.ToString()));
                    dtEnd = dtStart.AddHours(cn);//结束时间

                    #region TRP_PLAN_ROLL_ITEM赋值

                    Mod_TRP_PLAN_ROLL_ITEM_INFO modItemInfo = new Mod_TRP_PLAN_ROLL_ITEM_INFO();
                    modItemInfo.C_PLAN_ROLL_ID = modelPlan.C_ID;//计划主表主键
                    modItemInfo.N_STATUS = 1;//已下发
                    modItemInfo.C_INITIALIZE_ITEM_ID = modelPlan.C_INITIALIZE_ITEM_ID;
                    modItemInfo.C_ORDER_NO = modelPlan.C_ORDER_NO;
                    modItemInfo.N_WGT = i_Wgt;//下发量
                    modItemInfo.C_MAT_CODE = modelPlan.C_MAT_CODE;
                    modItemInfo.C_MAT_NAME = modelPlan.C_MAT_NAME;
                    modItemInfo.C_TECH_PROT = modelPlan.C_TECH_PROT;
                    modItemInfo.C_SPEC = modelPlan.C_SPEC;
                    modItemInfo.C_STL_GRD = modelPlan.C_STL_GRD;
                    modItemInfo.C_STD_CODE = modelPlan.C_STD_CODE;
                    modItemInfo.N_USER_LEV = modelPlan.N_USER_LEV;
                    modItemInfo.N_STL_GRD_LEV = modelPlan.N_STL_GRD_LEV;
                    modItemInfo.N_ORDER_LEV = modelPlan.N_ORDER_LEV;
                    modItemInfo.C_QUALIRY_LEV = modelPlan.C_QUALIRY_LEV;
                    modItemInfo.D_NEED_DT = modelPlan.D_NEED_DT;
                    modItemInfo.D_DELIVERY_DT = modelPlan.D_DELIVERY_DT;
                    modItemInfo.D_DT = modelPlan.D_DT;
                    modItemInfo.C_LINE_DESC = modSta.C_STA_DESC;
                    modItemInfo.C_LINE_CODE = modSta.C_STA_CODE;
                    modItemInfo.D_P_START_TIME = dtStart;//计划开始时间
                    modItemInfo.D_P_END_TIME = dtEnd;//计划结束时间
                    modItemInfo.N_PROD_TIME = modelPlan.N_PROD_TIME;
                    modItemInfo.N_SORT = modelPlan.N_SORT;
                    modItemInfo.N_ROLL_PROD_WGT = i_Wgt;//下发量
                    modItemInfo.C_ROLL_PROD_EMP_ID = modelPlan.C_ROLL_PROD_EMP_ID;
                    modItemInfo.C_STL_ROL_DT = modelPlan.C_STL_ROL_DT;
                    modItemInfo.N_PROD_WGT = modelPlan.N_PROD_WGT;
                    modItemInfo.N_WARE_WGT = modelPlan.N_WARE_WGT;
                    modItemInfo.N_WARE_OUT_WGT = modelPlan.N_WARE_OUT_WGT;
                    modItemInfo.N_FLAG = modelPlan.N_FLAG;
                    modItemInfo.N_ISSUE_WGT = i_Wgt;//下发量
                    modItemInfo.C_CUST_NO = modelPlan.C_CUST_NO;
                    modItemInfo.C_CUST_NAME = modelPlan.C_CUST_NAME;
                    modItemInfo.C_SALE_CHANNEL = modelPlan.C_SALE_CHANNEL;
                    modItemInfo.C_PACK = modelPlan.C_PACK;
                    modItemInfo.C_DESIGN_NO = modelPlan.C_DESIGN_NO;
                    modItemInfo.N_GROUP_WGT = modelPlan.N_GROUP_WGT;
                    modItemInfo.C_STA_ID = modSta.C_ID;
                    modItemInfo.D_START_TIME = modelPlan.D_START_TIME;
                    modItemInfo.D_END_TIME = modelPlan.D_END_TIME;
                    modItemInfo.C_EMP_ID = modelPlan.C_EMP_ID;
                    modItemInfo.D_MOD_DT = RV.UI.ServerTime.timeNow();
                    modItemInfo.N_ROLL_WGT = modelPlan.N_ROLL_WGT;
                    modItemInfo.N_MACH_WGT = modelPlan.N_MACH_WGT;
                    modItemInfo.C_CAST_NO = modelPlan.C_CAST_NO;
                    modItemInfo.C_INITIALIZE_ID = modelPlan.C_INITIALIZE_ID;
                    modItemInfo.C_FREE_TERM = modelPlan.C_FREE_TERM;
                    modItemInfo.C_FREE_TERM2 = modelPlan.C_FREE_TERM2;
                    modItemInfo.C_AREA = modelPlan.C_AREA;
                    modItemInfo.C_PCLX = modelPlan.C_PCLX;
                    modItemInfo.C_SFHL = modelPlan.C_SFHL;
                    modItemInfo.D_HL_START_TIME = modelPlan.D_HL_START_TIME;
                    modItemInfo.D_HL_END_TIME = modelPlan.D_HL_END_TIME;
                    modItemInfo.C_SFHL_D = modelPlan.C_SFHL_D;
                    modItemInfo.D_DHL_START_TIME = modelPlan.D_DHL_START_TIME;
                    modItemInfo.D_DHL_END_TIME = modelPlan.D_DHL_END_TIME;
                    modItemInfo.C_SFKP = modelPlan.C_SFKP;
                    modItemInfo.D_KP_START_TIME = modelPlan.D_KP_START_TIME;
                    modItemInfo.D_KP_END_TIME = modelPlan.D_KP_END_TIME;
                    modItemInfo.C_SFXM = modelPlan.C_SFXM;
                    modItemInfo.D_XM_START_TIME = modelPlan.D_XM_START_TIME;
                    modItemInfo.D_XM_END_TIME = modelPlan.D_XM_END_TIME;
                    modItemInfo.N_UPLOADSTATUS = modelPlan.N_UPLOADSTATUS;
                    modItemInfo.C_MATRL_CODE_SLAB = modelPlan.C_MATRL_CODE_KP.Trim() == "" ? modelPlan.C_MATRL_CODE_SLAB : modelPlan.C_MATRL_CODE_KP;//
                    modItemInfo.C_MATRL_NAME_SLAB = modelPlan.C_MATRL_CODE_KP.Trim() == "" ? modelPlan.C_MATRL_NAME_SLAB : modelPlan.C_MATRL_NAME_KP;//
                    modItemInfo.C_SLAB_SIZE = modelPlan.C_MATRL_CODE_KP.Trim() == "" ? modelPlan.C_SLAB_SIZE : modelPlan.C_KP_SIZE;//
                    modItemInfo.N_SLAB_LENGTH = modelPlan.C_MATRL_CODE_KP.Trim() == "" ? modelPlan.N_SLAB_LENGTH : modelPlan.N_KP_LENGTH;//
                    modItemInfo.N_SLAB_PW = modelPlan.C_MATRL_CODE_KP.Trim() == "" ? modelPlan.N_SLAB_PW : modelPlan.N_KP_PW;//
                    modItemInfo.D_CAN_ROLL_TIME = modelPlan.D_CAN_ROLL_TIME;
                    modItemInfo.C_ROUTE = modelPlan.C_ROUTE;
                    modItemInfo.N_DIAMETER = modelPlan.N_DIAMETER;
                    modItemInfo.C_XM_YQ = modelPlan.C_XM_YQ;
                    modItemInfo.N_JRL_WD = modelPlan.N_JRL_WD;
                    modItemInfo.N_JRL_SJ = modelPlan.N_JRL_SJ;
                    modItemInfo.C_STL_GRD_SLAB = modelPlan.C_STL_GRD_SLAB;
                    modItemInfo.C_STD_CODE_SLAB = modelPlan.C_STD_CODE_SLAB;
                    modItemInfo.C_REMARK = strRemark;//换产线原因
                    modItemInfo.C_REMARK1 = "0";
                    modItemInfo.C_REMARK2 = modelPlan.C_REMARK2;
                    modItemInfo.C_REMARK3 = strHGG;//换规格原因
                    modItemInfo.C_REMARK4 = modelPlan.C_REMARK4;
                    modItemInfo.C_REMARK5 = modelPlan.C_REMARK5;


                    #endregion

                    if (!dal.Add_Trans(modItemInfo))
                    {
                        TransactionHelper.RollBack();
                        return "下发失败！";
                    }

                    //modelPlan.D_P_START_TIME = dtStart;
                    //modelPlan.D_P_END_TIME = dtEnd;

                    if (!dalTrpPlanRoll.Update_Trans(modelPlan))
                    {
                        TransactionHelper.RollBack();
                        return "下发失败！";
                    }
                }

                TransactionHelper.Commit();
                return result;
            }
            catch
            {
                TransactionHelper.RollBack();
                return "下发失败！";
            }
        }
        #endregion

        #region 撤销轧钢计划

        /// <summary>
        /// 撤销轧钢计划(中间表撤回)
        /// </summary>
        /// <param name="strID">trp_plan_roll_item_info表主键</param>
        public string BackPlan(string strID)
        {
            try
            {
                string result = "1";

                TransactionHelper.BeginTransaction();

                Mod_TRP_PLAN_ROLL_ITEM_INFO modItemInfo = dal.GetModel(strID);
                if (modItemInfo != null)
                {
                    if (modItemInfo.N_STATUS != 1)
                    {
                        TransactionHelper.RollBack();
                        return "撤销失败！";
                    }

                    if (!dal.Delete_Trans(strID))
                    {
                        TransactionHelper.RollBack();
                        return "撤销失败！";
                    }

                    Mod_TRP_PLAN_ROLL modPlan = dalTrpPlanRoll.GetModel(modItemInfo.C_PLAN_ROLL_ID);
                    if (modPlan == null)
                    {
                        TransactionHelper.RollBack();
                        return "撤销失败！";
                    }
                    else
                    {
                        modPlan.N_STATUS = 0;
                        modPlan.N_ISSUE_WGT = modPlan.N_ISSUE_WGT - Convert.ToDecimal(modItemInfo.N_ISSUE_WGT);

                        if (!dalTrpPlanRoll.Update_Trans(modPlan))
                        {
                            TransactionHelper.RollBack();
                            return "撤销失败！";
                        }
                    }
                }
                else
                {
                    TransactionHelper.RollBack();
                    return "撤销失败！";
                }

                TransactionHelper.Commit();

                return result;
            }
            catch
            {
                TransactionHelper.RollBack();
                return "撤销失败！";
            }
        }

        /// <summary>
        /// 撤销轧钢计划(订单计划撤回)
        /// </summary>
        /// <param name="strID">trp_plan_roll_item表主键</param>
        public string BackPlans(string strID)
        {
            try
            {
                string result = "1";

                TransactionHelper.BeginTransaction();

                Mod_TRP_PLAN_ROLL_ITEM modItem = dalTrpPlanRollItem.GetModel(strID);
                if (modItem != null)
                {
                    //撤销普通订单
                    if (modItem.N_IS_MERGE == 0)
                    {
                        if (modItem.N_GROUP_WGT > 0 || modItem.N_STATUS != 1)
                        {
                            return "已组坯，不能撤销！";
                        }
                        if (!dalTrpPlanRollItem.Delete_Trans(strID))
                        {
                            TransactionHelper.RollBack();
                            return "撤销失败！";
                        }

                        if (!dal.Delete_Trans(strID))
                        {
                            TransactionHelper.RollBack();
                            return "撤销失败！";
                        }

                        Mod_TRP_PLAN_ROLL modPlan = dalTrpPlanRoll.GetModel(modItem.C_PLAN_ROLL_ID);
                        if (modPlan == null)
                        {
                            TransactionHelper.RollBack();
                            return "撤销失败！";
                        }
                        else
                        {
                            modPlan.N_STATUS = 0;
                            modPlan.N_ISSUE_WGT = modPlan.N_ISSUE_WGT - Convert.ToDecimal(modItem.N_WGT);

                            Mod_TRP_PLAN_ROLL_ITEM modOld = dalTrpPlanRollItem.GetModel_By_PlanRollID(modItem.C_PLAN_ROLL_ID, modItem.C_ID);
                            if (modOld != null)
                            {
                                modPlan.D_P_START_TIME = modOld.D_P_START_TIME;
                                modPlan.D_P_END_TIME = modOld.D_P_END_TIME;
                            }
                            else
                            {
                                modPlan.D_P_START_TIME = null;
                                modPlan.D_P_END_TIME = null;
                            }

                            if (!dalTrpPlanRoll.Update_Trans(modPlan))
                            {
                                TransactionHelper.RollBack();
                                return "撤销失败！";
                            }
                        }
                    }
                    //撤销合并订单
                    else
                    {
                        if (modItem.N_GROUP_WGT > 0 || modItem.N_STATUS != 1)
                        {
                            return "已组坯，不能撤销！";
                        }

                        List<Mod_TRP_PLAN_ROLL_ITEM_INFO> itemInfos = new List<Mod_TRP_PLAN_ROLL_ITEM_INFO>();
                        var itemInfoDt = dal.GetList("  C_ITEM_ID='" + modItem.C_ID + "'  ").Tables[0];
                        if (itemInfoDt != null && itemInfoDt.Rows.Count > 0)
                        {
                            for (int i = 0; i < itemInfoDt.Rows.Count; i++)
                            {
                                BackPlanAdditional(itemInfoDt.Rows[i]["C_ID"].ToString());
                            }
                        }

                        if (!dalTrpPlanRollItem.Delete_Trans(strID))
                        {
                            TransactionHelper.RollBack();
                            return "撤销失败！";
                        }
                    }
                }
                else
                {
                    TransactionHelper.RollBack();
                    return "撤销失败！";
                }

                TransactionHelper.Commit();

                return result;
            }
            catch
            {
                TransactionHelper.RollBack();
                return "撤销失败！";
            }
        }


        /// <summary>
        /// 撤销轧钢计划(中间表撤回)
        /// </summary>
        /// <param name="strID">trp_plan_roll_item表主键</param>
        public string BackPlanAdditional(string strID)
        {
            try
            {
                string result = "1";

                Mod_TRP_PLAN_ROLL_ITEM_INFO modItemInfo = dal.GetModel(strID);
                if (modItemInfo != null)
                {

                    if (!dal.Delete_Trans(strID))
                    {
                        TransactionHelper.RollBack();
                        return "撤销失败！";
                    }

                    Mod_TRP_PLAN_ROLL modPlan = dalTrpPlanRoll.GetModel(modItemInfo.C_PLAN_ROLL_ID);
                    if (modPlan == null)
                    {
                        TransactionHelper.RollBack();
                        return "撤销失败！";
                    }
                    else
                    {
                        modPlan.N_STATUS = 0;
                        modPlan.N_ISSUE_WGT = modPlan.N_ISSUE_WGT - Convert.ToDecimal(modItemInfo.N_ISSUE_WGT);

                        if (!dalTrpPlanRoll.Update_Trans(modPlan))
                        {
                            TransactionHelper.RollBack();
                            return "撤销失败！";
                        }
                    }
                }
                else
                {
                    TransactionHelper.RollBack();
                    return "撤销失败！";
                }

                return result;
            }
            catch
            {
                TransactionHelper.RollBack();
                return "撤销失败！";
            }
        }

        #endregion


        /// <summary>
        /// 保存排序后的计划
        /// </summary>
        /// <param name="C_ID">计划主键</param>
        /// <param name="D_P_START_TIME">开始时间</param>
        /// <param name="D_P_END_TIME">结束时间</param>
        /// <param name="N_SORT">排序号</param>
        /// <returns>是否成功</returns>
        public bool UpdateSort(string C_ID, DateTime D_P_START_TIME, DateTime D_P_END_TIME, int N_SORT)
        {
            return dal.UpdateSort(C_ID, D_P_START_TIME, D_P_END_TIME, N_SORT);
        }

        /// <summary>
        /// 获取合并订单号
        /// </summary>
        /// <param name="id">合并ItemID</param>
        /// <returns></returns>
        public DataTable GetJoinOrder(string id)
        {
            return dal.GetJoinOrder(id);
        }


        /// <summary>
        /// 获取批次回执关联订单
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public DataTable GetRelationOrder(string id)
        {
            return dal.GetRelationOrder(id);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool DeleteItem(string C_ID)
        {
            return dal.DeleteItem(C_ID);
        }

        #endregion  ExtensionMethod
    }
}
