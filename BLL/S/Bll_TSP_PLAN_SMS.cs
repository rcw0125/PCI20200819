using System;
using System.Data;
using System.Collections.Generic;
using DAL;
using MODEL;
namespace BLL
{
    /// <summary>
    /// 连铸生产计划表
    /// </summary>
    public partial class Bll_TSP_PLAN_SMS
    {
        private readonly Dal_TSP_PLAN_SMS dal = new Dal_TSP_PLAN_SMS();
        public Bll_TSP_PLAN_SMS()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string C_ID)
        {
            return dal.Exists(C_ID);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Mod_TSP_PLAN_SMS model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Mod_TSP_PLAN_SMS model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 标记已下开坯计划的炉次计划
        /// </summary>
        /// <param name="C_STL_GRD">钢种</param>
        /// <param name="C_MATRL_NO">物料编码</param>
        /// <param name="C_STD_CODE">执行标准</param>
        /// <param name="C_MATRL_CODE_KP">开坯物料编码</param>
        /// <param name="N_JC_SORT">浇次序号</param>
        public int Down_KP(string C_STL_GRD, string C_MATRL_NO, string C_STD_CODE, string C_MATRL_CODE_KP, string N_JC_SORT)
        {
            return dal.Down_KP(C_STL_GRD, C_MATRL_NO, C_STD_CODE, C_MATRL_CODE_KP, N_JC_SORT);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(string C_ID)
        {

            return dal.Delete(C_ID);
        }


        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool DeleteByjcid(string C_FK)
        {
            return dal.DeleteByjcid(C_FK);
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool DeleteList(string C_IDlist)
        {
            return dal.DeleteList(C_IDlist);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Mod_TSP_PLAN_SMS GetModel(string C_ID)
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
        public DataSet Get_List()
        {
            return dal.Get_List();
        }
        /// <summary>
        /// 根据浇次临时表获取最大序号
        /// </summary>
        /// <param name="C_FK"></param>
        /// <returns></returns>
        public int MaxSortBy(string C_FK)
        {
            return dal.MaxSortBy(C_FK);
        }
        /// <summary>
        /// 获得数据列表-浇次号
        /// </summary>
        public DataSet GetList_CAST_NO(string strWhere)
        {
            return dal.GetList_CAST_NO(strWhere);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Mod_TSP_PLAN_SMS> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 根据浇次号获取炉次计划
        /// </summary>
        /// <param name="C_FK">浇次号</param>
        /// <returns></returns>
        public List<Mod_TSP_PLAN_SMS> GetModelListByJcID(string C_FK)
        {
            DataSet ds = dal.GetListByJcID(C_FK);
            return DataTableToList(ds.Tables[0]);
        }

        /// <summary>
        /// 根据混浇分组号获取炉次计划
        /// </summary>
        /// <param name="N_GROUP">浇次可混浇的组号</param>
        /// <returns></returns>
        public List<Mod_TSP_PLAN_SMS> GetListByJcGroup(int N_GROUP)
        {

            DataSet ds = dal.GetListByJcGroup(N_GROUP);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 根据浇次号获取炉次计划
        /// </summary>
        /// <param name="C_FK">浇次号</param>
        /// <returns></returns>
        public DataSet GetList_sms_group(string C_FK)
        {
            return dal.GetList_sms_group(C_FK);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Mod_TSP_PLAN_SMS> DataTableToList(DataTable dt)
        {
            List<Mod_TSP_PLAN_SMS> modelList = new List<Mod_TSP_PLAN_SMS>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Mod_TSP_PLAN_SMS model;
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
        /// <summary>
        /// 获得数据列表-浇次号
        /// </summary>
        public DataSet GetList_Number(string strWhere)
        {
            return dal.GetList_Number(strWhere);
        }
        /// <summary>
        /// 修改生产顺序
        /// </summary>
        /// <param name="c_id">主键</param>
        /// <param name="C_CAST_NO">浇次</param>         
        /// <param name="sort_new">顺序-新</param>
        /// <param name="sort_old">顺序-旧</param>
        /// <param name="stype">判断大小</param>
        /// <returns></returns>
        public bool Update_SX(string c_id, string C_CAST_NO, int sort_new, int sort_old, string stype)
        {
            return dal.Update_SX(c_id, C_CAST_NO, sort_new, sort_old, stype);

        }
        #endregion  BasicMethod
        #region  ExtensionMethod


        /// <summary>
        /// 重新计算连铸计划执行时间
        /// </summary>
        /// <param name="D_START_TIME">指定开始时间</param>
        /// <param name="C_CCM_ID">连铸id</param>
        /// <returns></returns>
        public int ResetTime(string D_START_TIME, string C_CCM_ID)
        {
            return dal.ResetTime(D_START_TIME, C_CCM_ID);
        }


        /// <summary>
        ///  获取最大计划号
        /// </summary>
        /// <returns></returns>
        public string GetMax_PlanID()
        {
            return dal.GetMax_PlanID();
        }

        /// <summary>
        ///  获取上个计划结束时间
        /// </summary>
        /// <returns></returns>
        public string Get_EndTime(string c_cast_no, string n_sort)
        {
            return dal.Get_EndTime(c_cast_no, n_sort);
        }

        /// <summary>
        /// 查询已生成的浇次计划
        /// </summary>
        /// <param name="C_CCM_ID">连铸主键</param>
        /// <param name="C_TYPE">是否已经下发mes0未下1已下</param>
        /// <param name="dt1">排产时间（开始）</param>
        /// <param name="dt2">排产时间（结束）</param>
        /// <returns>浇次计划表</returns>
        public DataTable GetJCJH(string C_CCM_ID, int C_TYPE, DateTime? dt1, DateTime? dt2)
        {

            return dal.GetJCJH(C_CCM_ID, C_TYPE, dt1, dt2);
        }

        /// <summary>
        /// 查询浇次计划
        /// </summary>
        /// <param name="c_ccm">连铸号</param>
        /// <param name="dt1">查询开始日期</param>
        /// <param name="dt2">查询截止日期</param>
        /// <returns></returns>
        public DataTable GetJCJH(string c_ccm, string dt1, string dt2)
        {
            return dal.GetJCJH(c_ccm, dt1, dt2);
        }

        /// <summary>
        /// 根据浇次号得到对应的炉次号
        /// </summary>
        /// <param name="C_CCM_ID">连铸主键</param>
        /// <param name="C_CAST_NO">浇次号</param>
        /// <returns>炉次计划</returns>
        public DataTable GetLCJH(string C_CCM_ID, string C_CAST_NO)
        {
            return dal.GetLCJH(C_CCM_ID, C_CAST_NO);

        }

        /// <summary>
        /// 获取当前连铸炉次计划最大序号
        /// </summary>
        /// <param name="C_CCM_ID">连铸</param>
        /// <returns>最大序号</returns>
        public int GetMaxSort(string C_CCM_ID)
        {
            return dal.GetMaxSort(C_CCM_ID);
        }

        /// <summary>
        /// 查询已生成炉号的计划
        /// </summary>
        /// <param name="C_CCM_ID">连铸主键</param>
        /// <param name="strType">状态；2已生成炉次计划；3-发送炼钢MES；4计划已完成</param>
        /// <returns></returns>
        public DataTable Get_Stove_JH(string C_CCM_ID, string strType)
        {
            return dal.Get_Stove_JH(C_CCM_ID, strType);
        }

        /// <summary>
        /// 查询已生成炉号的计划详细信息
        /// </summary>
        /// <param name="C_CCM_ID">连铸主键</param>
        /// <param name="C_CAST_NO">浇次主键</param>
        /// <param name="C_IS_TO_MES">0未传mes，1已传mes</param>
        /// <param name="strStartTime">计划下发时间（开始）</param>
        /// <param name="strEndTime">计划下发时间（结束）</param>
        /// <returns></returns>
        public DataTable Get_Stove_JH_ITEM(string C_CCM_ID, string C_CAST_NO, string C_IS_TO_MES, string strStartTime, string strEndTime)
        {
            return dal.Get_Stove_JH_ITEM(C_CCM_ID, C_CAST_NO, C_IS_TO_MES, strStartTime, strEndTime);
        }

        /// <summary>
        /// 查询已生成炉号的计划详细信息
        /// </summary>
        /// <param name="C_ZL_ID">转炉主键</param>
        /// <param name="C_CAST_NO">浇次主键</param>
        /// <param name="C_IS_TO_MES">0未传mes，1已传mes</param>
        /// <param name="strStartTime">计划下发时间（开始）</param>
        /// <param name="strEndTime">计划下发时间（结束）</param>
        /// <returns></returns>
        public DataTable Get_Stove_JH_YXF_ITEM(string C_ZL_ID, string C_CAST_NO, string C_IS_TO_MES, string strStartTime, string strEndTime)
        {
            return dal.Get_Stove_JH_YXF_ITEM(C_ZL_ID, C_CAST_NO, C_IS_TO_MES, strStartTime, strEndTime);
        }

        /// <summary>
        /// 根据订单主键获取该订单连铸计划生产时间段
        /// </summary>
        /// <param name="c_order_id">订单主键</param>
        /// <returns></returns>
        public DataTable GetOrderCCTime(string c_order_id)
        {
            return dal.GetOrderCCTime(c_order_id);
        }

        /// <summary>
        /// 获取计划数量
        /// </summary>
        /// <param name="c_is_to_mes">0未传mes，1已传mes</param>
        /// <returns></returns>
        public int Get_Plan_Count(string c_is_to_mes)
        {
            return dal.Get_Plan_Count(c_is_to_mes);
        }

        /// <summary>
        /// 坯量更新炉次计划序号
        /// </summary>
        /// <param name="C_CCM_ID">连铸id</param>
        /// <param name="sort">起始序号</param>
        /// <returns></returns>
        public bool UpdateSort(string C_CCM_ID, int sort)
        {

            return dal.UpdateSort(C_CCM_ID, sort);
        }

        /// <summary>
        /// 坯量更新炉次计划序号
        /// </summary>
        /// <param name="C_CCM_ID">连铸id</param>
        /// <param name="sort">起始序号</param>
        /// <returns></returns>
        public DataTable GetWPLC(string C_CCM_ID, string C_STL_GRD, string C_STD_CODE, int sort, string C_CAST_NO)
        {
            return dal.GetWPLC(C_CCM_ID, C_STL_GRD, C_STD_CODE, sort, C_CAST_NO);
        }
        /// <summary>
        /// 获取当前连铸所有未排产的炉次加护
        /// </summary>
        /// <param name="C_CCM_ID">连铸主键</param>
        /// <returns></returns>
        public DataTable GetWPC(string C_CCM_ID)
        {
            return dal.GetWPC(C_CCM_ID);
        }

        /// <summary>
        ///查询开坯计划
        /// </summary>
        /// <param name="C_STL_GRD">钢种</param>
        /// <param name="C_STD_CODE">执行标准</param>
        /// <param name="status">0未排，1已排，2已组坯</param>
        /// <returns>开坯计划</returns>
        public DataTable GetKPJH(string C_STL_GRD, string C_STD_CODE, int STATUS)
        {
            return dal.GetKPJH(C_STL_GRD, C_STD_CODE, STATUS);
        }


        /// <summary>
        ///查询开坯计划
        /// </summary>
        /// <param name="C_STL_GRD">钢种</param>
        /// <param name="C_STD_CODE">执行标准</param>
        /// <param name="status">0未排，1已排，2已组坯</param>
        /// <returns>开坯计划</returns>
        public List<Mod_TSP_PLAN_SMS> GetKPJHLIST(string C_STL_GRD, string C_STD_CODE, int STATUS)
        {
            DataTable dt = dal.GetKPJH(C_STL_GRD, C_STD_CODE, STATUS);
            return DataTableToList(dt);
        }
        /// <summary>
        ///获取最大浇次号
        /// </summary>
        /// <param name="C_CCM_ID">连铸主键</param>
        public int GetMaxCastNo(string C_CCM_ID)
        {
            return dal.GetMaxCastNo(C_CCM_ID);
        }
        /// <summary>
        /// 整浇次上移
        /// </summary>
        /// <param name="C_CAST_NO">浇次号</param>
        /// <param name="C_CTRL_NO">上个浇次的浇次序号</param>
        /// <param name="COUNT">上移炉数</param>
        public void JCSY(string C_CAST_NO, string C_CTRL_NO, int COUNT)
        {
            dal.JCSY(C_CAST_NO, C_CTRL_NO, COUNT);
        }
        /// <summary>
        /// 整浇次下移
        /// </summary>
        /// <param name="C_CAST_NO">浇次号</param>
        /// <param name="C_CTRL_NO">下个浇次的浇次序号</param>
        /// <param name="COUNT">下移炉数</param>
        public void JCXY(string C_CAST_NO, string C_CTRL_NO, int COUNT)
        {
            dal.JCXY(C_CAST_NO, C_CTRL_NO, COUNT);
        }
        /// <summary>
        /// 清除未下发浇次计划的计划时间
        /// </summary>
        /// <param name="C_CCM_ID">连铸</param>
        public void ClearTime(string C_CCM_ID)
        {
            dal.ClearTime(C_CCM_ID);
        }

        /// <summary>
        /// 获取已排连铸计划的铁水计划
        /// </summary>
        /// <param name="dt1">查询开始日期</param>
        /// <param name="dt2">查询截止日期</param>
        /// <param name="C_ZL_ID">转炉主键</param>
        /// <param name="type">是否按产品统计Y/N</param>
        /// <returns></returns>
        public DataTable GetTSPlan(string dt1, string dt2, string C_ZL_ID, string type)
        {
            return dal.GetTSPlan(dt1, dt2, C_ZL_ID, type);
        }
        /// <summary>
        /// 获取炼钢计划铁水成分要求
        /// </summary>
        /// <param name="dt1">查询开始日期</param>
        /// <param name="dt2">查询截止日期</param>
        /// <param name="C_ZL_ID">转炉主键</param>
        /// <returns></returns>
        public DataTable GetTSPlanCF(string dt1, string dt2, string C_ZL_ID)
        {
            return dal.GetTSPlanCF(dt1, dt2, C_ZL_ID);
        }

        /// <summary>
        /// 按炉获取可轧钢坯日历
        /// </summary>
        /// <param name="C_STL_GRD">钢种</param>
        /// <param name="C_STD_CODE">执行标准</param>
        /// <returns>钢坯日历数据</returns>
        public DataTable GetKZ_Slab_Calendar(string C_STL_GRD, string C_STD_CODE)
        {

            return dal.GetKZ_Slab_Calendar(C_STL_GRD, C_STD_CODE);
        }

        /// <summary>
        /// 获取已下发调度，未下发MES的炉次计划数
        /// </summary>
        public int Get_Count(string c_fk)
        {
            return dal.Get_Count(c_fk);
        }

        #endregion  ExtensionMethod
        #region APS
        /// <summary>
        /// 返回上期排产的RH炉连续生产数量
        /// </summary>
        /// <returns>连续生产数量</returns>
        public int GetYPRH()
        {
            return dal.GetYPRH();
        }

        /// <summary>
        /// 该混浇组号
        /// </summary>
        /// <param name="c_stl_grd">钢种</param>
        /// <param name="c_std_code">执行标准</param>
        /// <param name="n_group">组号</param>
        /// <returns>是否成功</returns>
        public bool ChangeGroup(string c_stl_grd, string c_std_code, int n_group)
        {
            return dal.ChangeGroup(c_stl_grd, c_std_code, n_group);
        }
        /// <summary>
        ///查询开坯计划
        /// </summary>
        /// <param name="C_STL_GRD">钢种</param>
        /// <param name="C_STD_CODE">执行标准</param>
        /// <param name="status">Y/N</param>
        /// <returns>开坯计划</returns>
        public DataTable GetKP_Plan(string C_STL_GRD, string C_STD_CODE, int STATUS)
        {
            return dal.GetKP_Plan(C_STL_GRD, C_STD_CODE, STATUS);
        }

        /// <summary>
        ///查询开坯计划
        /// </summary>
        /// <param name="C_STL_GRD">钢种</param>
        /// <param name="C_STD_CODE">执行标准</param>
        /// <param name="status">Y/N</param>
        /// <returns>开坯计划</returns>
        public List<Mod_TSP_PLAN_SMS> GetKP_PlanBySms(string C_STL_GRD, string C_STD_CODE, int STATUS, int EXCESTATUS)
        {
            return DataTableToList(dal.GetKP_PlanBySms(C_STL_GRD, C_STD_CODE, STATUS, EXCESTATUS));

        }

        #endregion


        public int GetMaxSort(int jc_sort, string c_ccmid)
        {
            return dal.GetMaxSort(jc_sort, c_ccmid);
        }
        /// <summary>
        /// 获取当前浇次计划的最小序号
        /// </summary>
        /// <param name="c_jc_id">浇次主键</param>
        /// <returns>最小序号</returns>
        public int GetMinSort(string c_jc_id)
        {
            return dal.GetMinSort(c_jc_id);
        }

        /// <summary>
        /// 获取已排产未完成的炼钢计划量
        /// </summary>
        /// <param name="C_STL_GRD">钢种</param>
        /// <param name="C_STD_CODE"></param>
        /// <param name="C_MATRL_NO"></param>
        /// <returns></returns>
        public decimal GetWWCJH(string C_STL_GRD, string C_STD_CODE, string C_MATRL_NO)
        {
            return dal.GetWWCJH(C_STL_GRD, C_STD_CODE, C_MATRL_NO);
        }

        /// <summary>
        /// 查询需要修改计划的炉号
        /// </summary>
        /// <param name="str_Stove">炉号</param>
        /// <returns></returns>
        public DataTable Get_Plan_ByStove(string str_Stove)
        {
            return dal.Get_Plan_ByStove(str_Stove);
        }

        /// <summary>
        /// 同步炼钢记号
        /// </summary>
        /// <returns></returns>
        public int P_TB_LGJH()
        {
            return dal.P_TB_LGJH();
        }
        /// <summary>
        /// 获取已下发的计划
        /// </summary>
        /// <param name="C_PLAN_ID">计划主键</param>
        /// <returns></returns>
        public DataTable GetDownPlan(string C_PLAN_ID)
        {
            return dal.GetDownPlan(C_PLAN_ID);
        }

        /// <summary>
        /// 获取当前连铸炉次计划最大序号
        /// </summary>
        /// <param name="C_CCM_ID">连铸</param>
        /// <returns>最大序号</returns>
        public int GetMaxSortYXMES(string C_CCM_ID)
        {
            return dal.GetMaxSortYXMES(C_CCM_ID);
        }

        /// <summary>
        /// 获取炉次计划
        /// </summary>
        /// <param name="C_CCM_ID">连铸主键</param>
        /// <param name="N_CREAT_PLAN">炉次计划状态</param>
        /// <returns>炉次计划列表</returns>
        public List<Mod_TSP_PLAN_SMS> GetLCPlan(string C_CCM_ID, int N_CREAT_PLAN)
        {
            return DataTableToList(dal.GetLCPlan(C_CCM_ID, N_CREAT_PLAN));
        }

        /// <summary>
        /// 获取未完成的炉次计划
        /// </summary>
        /// <param name="C_CCM_ID">连铸主键</param>
        /// <returns>炉次计划列表</returns>
        public List<Mod_TSP_PLAN_SMS> GetLCPlan(string C_CCM_ID)
        {
            return DataTableToList(dal.GetLCPlan(C_CCM_ID));
        }

        /// <summary>
        /// 获取炼钢计划完成量信息
        /// </summary>
        /// <param name="strTime1">时间1</param>
        /// <param name="strTime2">时间2</param>
        /// <returns></returns>
        public DataSet Get_Lgfx(string strTime1, string strTime2)
        {
            return dal.Get_Lgfx(strTime1, strTime2);
        }

        /// <summary>
        /// 获取指定开坯机最新的计划完成情况
        /// </summary>
        /// <param name="C_KP_ID">开坯机主键</param>
        /// <returns></returns>
        public DataTable GetNewKPPlan(string C_KP_ID)
        {
            return dal.GetNewKPPlan(C_KP_ID);
        }
        /// <summary>
        /// 获取指定开坯机最新的计划完成情况
        /// </summary>
        /// <param name="C_KP_ID">开坯机</param>
        /// <param name="sort">顺序</param>
        /// <returns></returns>
        public DataTable GetLastsort(string C_KP_ID, int sort)
        {
            return dal.GetLastsort(C_KP_ID, sort);
        }
        /// <summary>
        /// 清空开坯计划排产状态
        /// </summary>
        /// <returns></returns>
        public int UPsortstatus()
        {
            return dal.UPsortstatus();
        }
        #region 开坯计划查询
        /// <summary>
        /// 查询开坯计划
        /// </summary>
        /// <param name="sta">工位</param>
        /// <param name="stove">炉号</param>
        /// <param name="grd">钢种</param>
        /// <param name="st">连铸开始时间</param>
        /// <param name="et">连铸结束时间</param>
        /// <returns></returns>
        public DataSet GetQuery(string sta, string stove, string grd, DateTime st, DateTime et)
        {
            return dal.GetQuery(sta, stove, grd, st, et);
        }
        /// <summary>
        /// 查询开坯计划
        /// </summary>
        /// <param name="sta">开坯机</param>
        /// <param name="lzendtime">连铸结束时间</param>
        /// <param name="ddstatus">订单状态区分是否有订单</param>
        /// <param name="rzpstatus">热轧坯状态区分是否为热轧坯</param>
        /// <param name="jrstatus">加热状态区分6小时和4小时</param>
        /// <returns></returns>
        public DataSet GetQuery(string sta, DateTime lzendtime, int ddstatus, int rzpstatus, int jrstatus)
        {
            return dal.GetQuery(sta, lzendtime, ddstatus, rzpstatus, jrstatus);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Mod_TSP_PLAN_SMS> GetModelList(string sta, string stove, string grd, DateTime st, DateTime et)
        {
            return DataTableToList(GetQuery(sta, stove, grd, st, et).Tables[0]);
        }
        /// <summary>
        /// 查询开坯计划
        /// </summary>
        /// <returns></returns>
        public DataSet GetKPSTA()
        {
            return dal.GetKPSTA();
        }
        /// <summary>
        /// 查询开坯计划
        /// </summary>
        /// <param name="sta">工位</param>
        /// <returns></returns>
        public DataSet GetListByKP(string sta)
        {
            return dal.GetListByKP(sta);
        }
        /// <summary>
        /// 查询修磨计划
        /// </summary>
        /// <param name="sta">工位</param>
        /// <param name="stove">炉号</param>
        /// <param name="grd">钢种</param>
        /// <param name="st">连铸开始时间</param>
        /// <param name="et">连铸结束时间</param>
        /// <returns></returns>
        public DataSet GetXMQuery(string sta, string stove, string grd, DateTime st, DateTime et, string type)
        {
            return dal.GetXMQuery(sta, stove, grd, st, et, type);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Mod_TSP_PLAN_SMS> GetModelList1(string sta, string stove, string grd, DateTime st, DateTime et, string type)
        {
            return DataTableToList(GetXMQuery(sta, stove, grd, st, et, type).Tables[0]);
        }
        /// <summary>
        /// 查询修磨计划
        /// </summary>
        /// <param name="sta">工位</param>
        /// <returns></returns>
        public DataSet GetXMSTA()
        {
            return dal.GetXMSTA();
        }
        /// <summary>
        /// 查询修磨计划
        /// </summary>
        /// <param name="sta">工位</param>
        /// <returns></returns>
        public DataSet GetListByXM(string sta, string type)
        {
            return dal.GetListByXM(sta, type);
        }
        /// <summary>
        /// 开坯计划排产初始化
        /// </summary> 
        /// <returns></returns>
        public string P_INI_SMS()
        {
            return dal.P_INI_SMS();
        }

        /// <summary>
        /// 炼钢计划排产初始化
        /// </summary> 
        /// <returns></returns>
        public string P_INI_LGPC()
        {
            return dal.P_INI_LGPC();
        }
        /// <summary>
        /// 开坯计划排序
        /// </summary> 
        /// <returns></returns>
        public string P_KP_PLAN_SORTING()
        {
            return dal.P_KP_PLAN_SORTING();
        }
        /// <summary>
        /// 
        /// </summary> 
        /// <returns></returns>
        public string P_SLAB_CAN_USETIMEG()
        {
            return dal.P_SLAB_CAN_USETIMEG();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="c_ccm_id"></param>
        /// <returns></returns>
        public DataTable GetStartTime(string c_ccm_id)
        {
            return dal.GetStartTime(c_ccm_id);
        }
        /// <summary>
        /// 获取不锈钢修磨机时产能
        /// </summary>
        /// <param name="C_STL_GRD">钢种</param>
        /// <param name="C_SLAB_SIE">断面</param>
        /// <param name="N_LTH">定尺</param>
        /// <param name="C_GZLX">修磨标准</param>
        /// <returns></returns>
        public string GetBXGXMJSCN(string C_STL_GRD, string C_SLAB_SIE, int N_LTH, string C_GZLX)
        {
            return dal.GetBXGXMJSCN(C_STL_GRD, C_SLAB_SIE, N_LTH, C_GZLX);
        }

        /// <summary>
        /// 批量更新浇次计划开始结束时间
        /// </summary>
        /// <param name="C_CCM_ID"></param>
        public int UpdateCCMTime(string C_CCM_ID)
        {
            return dal.UpdateCCMTime(C_CCM_ID);
        }

        #endregion

        #region 调整连铸机时判断调整的浇次计划的炉次计划钢种信息
        /// <summary>
        /// 根据浇次号获取分组后的炉次计划
        /// </summary>
        /// <param name="C_FK">浇次主键</param>
        /// <returns></returns>
        public DataTable GetGroupPlan(string C_FK)
        {
            return dal.GetGroupPlan(C_FK);
        }
        #endregion
        /// <summary>
        /// 批量更新浇次计划序号
        /// </summary>
        /// <returns></returns>
        public int UpdateJcSort()
        {
            return dal.UpdateJcSort();
        }

        /// <summary>
        /// 更新炉次计划的机时产能
        /// </summary>
        /// <returns></returns>
        public int UpdateLCJSCN()
        {
            return dal.UpdateLCJSCN();
        }
    }
}

