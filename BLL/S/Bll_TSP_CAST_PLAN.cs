using System;
using System.Data;
using System.Collections.Generic;
using DAL;
using MODEL;
namespace BLL
{
    /// <summary>
    /// 浇次计划表
    /// </summary>
    public partial class Bll_TSP_CAST_PLAN
    {
        private readonly Dal_TSP_CAST_PLAN dal = new Dal_TSP_CAST_PLAN();
        public Bll_TSP_CAST_PLAN()
        { }
        #region  BasicMethod

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Mod_TSP_CAST_PLAN model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Mod_TSP_CAST_PLAN model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(string c_id)
        {
            return dal.Delete(c_id);
        }
        /// <summary>
        /// 更新浇次计划
        /// </summary>
        /// <param name="C_ID">浇次主键</param>
        /// <param name="num">炉次数量</param>
        /// <returns></returns>
        public bool Update(string C_ID, int num)
        {
            return dal.Update(C_ID, num);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Mod_TSP_CAST_PLAN GetModel(string C_ID)
        {
            return dal.GetModel(C_ID);
        }
        /// <summary>
        /// 获取下一个浇次计划
        /// </summary>
        /// <param name="C_CCM_ID">连铸机主键</param>
        /// <param name="N_SORT">当前计划排序号</param>
        /// <returns>下一个浇次计划</returns>
        public Mod_TSP_CAST_PLAN GetNextModel(string C_CCM_ID, int N_SORT)
        {
            return dal.GetNextModel(C_CCM_ID, N_SORT);
        }

        /// <summary>
        /// 获取上一个浇次计划
        /// </summary>
        /// <param name="C_CCM_ID">连铸机主键</param>
        /// <param name="N_SORT">当前计划排序号</param>
        /// <returns>上一个浇次计划</returns>
        public Mod_TSP_CAST_PLAN GetLastModel(string C_CCM_ID, int N_SORT)
        {
            return dal.GetLastModel(C_CCM_ID, N_SORT);
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string C_CCM_ID, int N_STATUS, string dt)
        {
            return dal.GetList(C_CCM_ID, N_STATUS, dt);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Mod_TSP_CAST_PLAN> GetModelList(string C_CCM_ID, int? N_STATUS, string dt)
        {
            DataSet ds = dal.GetList(C_CCM_ID, N_STATUS, dt);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Mod_TSP_CAST_PLAN> GetModelList(string where)
        {
            DataSet ds = dal.GetList(where);
            return DataTableToList(ds.Tables[0]);
        }

         /// <summary>
            /// 获得数据列表
            /// </summary>
            public List<Mod_TSP_CAST_PLAN> GetListWWC(string C_CCM_ID)
        {
            DataSet ds = dal.GetListWWC(C_CCM_ID);
            return DataTableToList(ds.Tables[0]);
        }


        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Mod_TSP_CAST_PLAN> GetModelListBySort(string C_CCM_ID, int N_SORT)
        {
            DataSet ds = dal.GetListBySort(C_CCM_ID, N_SORT);
            return DataTableToList(ds.Tables[0]);
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Mod_TSP_CAST_PLAN> DataTableToList(DataTable dt)
        {
            List<Mod_TSP_CAST_PLAN> modelList = new List<Mod_TSP_CAST_PLAN>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Mod_TSP_CAST_PLAN model;
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
        /// 分页获取数据列表
        /// </summary>
        //public DataSet GetList(int PageSize,int PageIndex,string strWhere)
        //{
        //return dal.GetList(PageSize,PageIndex,strWhere);
        //}

        #endregion  BasicMethod
        #region  ExtensionMethod
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList_Max(string strWhere)
        {
            return dal.GetList_Max(strWhere);
        }

        /// <summary>
        /// 获取浇次最大序号
        /// </summary>
        public int Max_jc_sort(string strCcm)
        {
            return dal.Max_jc_sort(strCcm);
        }

        /// <summary>
        /// 获取已完成浇次的最大浇次序号
        /// </summary>
        /// <param name="strCcm">连铸机主键</param>
        /// <returns></returns>
        public int Max_jc_sortbywc(string strCcm)
        {
            return dal.Max_jc_sortbywc(strCcm);
        }
        /// <summary>
        /// 返回已排浇次计划的最后一条计划
        /// </summary>
        /// <param name="c_ccm">连铸主键</param>
        /// <returns></returns>
        public DataTable GetGGType(string c_ccm)
        {
            return dal.GetGGType(c_ccm);
        }
        /// <summary>
        /// 获取RH炉的使用寿命
        /// </summary>
        /// <returns></returns>
        public int GetRHSM(string c_ccm)
        {
            return dal.GetRHSM(c_ccm);
        }

        /// <summary>
        /// 获取需要下发的浇次信息
        /// </summary>
        /// <param name="c_ccm_id">连铸机主键</param>
        /// <returns></returns>
        public Mod_TSP_CAST_PLAN GetModel_XF(string c_ccm_id)
        {
            return dal.GetModel_XF(c_ccm_id);
        }

        /// <summary>
        /// 获取是最后一条下发调度的浇次
        /// </summary>
        /// <param name="c_ccm_id">连铸机主键</param>
        /// <param name="n_sort">浇次顺序号</param>
        /// <returns></returns>
        public int Get_YXF_Count(string c_ccm_id, int n_sort)
        {
            return dal.Get_YXF_Count(c_ccm_id, n_sort);
        }

        #endregion  ExtensionMethod


        #region 根据炉次计划更新浇次计划
        /// <summary>
        /// 根据炉次计划更新浇次计划
        /// </summary>
        /// <param name="C_ID">浇次计划主键</param>
        /// <returns>返回影响行</returns>
        public int UpdateJCPlan(string C_ID)
        {
            return dal.UpdateJCPlan(C_ID);
        }


        /// <summary>
        /// 查询非计划浇次
        /// </summary>
        /// <param name="C_CCM_ID">连铸机主键</param>
        /// <param name="d_dt1">开始时间</param>
        /// <param name="d_dt2">结束时间</param>
        /// <returns></returns>
        public DataTable GetStopPlan(string C_CCM_ID, string d_dt1, string d_dt2)
        {
            return dal.GetStopPlan(C_CCM_ID, d_dt1, d_dt2);
        }

        /// <summary>
        /// 炼钢计划存档日志
        /// </summary>
        /// <param name="P_IP">ip地址</param>
        /// <param name="P_OPER_CONTEXT">操作内容</param>
        /// <param name="P_EMP_ID">操作人</param>
        /// <param name="P_CCM_ID">连铸机主键</param>
        /// <param name="P_TYPE">类型 计划存档、计划调整</param>
        /// <returns></returns>
        public string P_CD_LOG(string P_IP, string P_OPER_CONTEXT, string P_EMP_ID, string P_CCM_ID, string P_TYPE)
        {

            return dal.P_CD_LOG(P_IP, P_OPER_CONTEXT, P_EMP_ID, P_CCM_ID, P_TYPE);
        }

        /// <summary>
        /// 炼钢计划存档
        /// </summary> 
        /// <returns></returns>
        public string P_LG_PLAN_CD(string C_CD_NO, string C_CD_TYPE, string C_LOG_EMP)
        {
            return dal.P_LG_PLAN_CD(C_CD_NO, C_CD_TYPE, C_LOG_EMP);
        }

        /// <summary>
        /// 记录炼钢浇次计划调整原因
        /// </summary>
        /// <param name="P_FK">浇次计划主键（终止计划时不能为空）</param>
        /// <param name="P_OPER_CONTEXT">详细说明</param>
        /// <param name="P_EMP_ID">操作人员</param>
        /// <param name="P_CCM_ID">操作时连铸主键</param>
        /// <param name="P_TYPE">类型：计划调整、终止计划</param>
        /// <param name="P_REASON">原因</param>
        /// <returns></returns>
        public string P_LG_PLAN_REMARK(string P_FK, string P_OPER_CONTEXT, string P_EMP_ID, string P_CCM_ID, string P_TYPE, string P_REASON)
        {
            return dal.P_LG_PLAN_REMARK(P_FK, P_OPER_CONTEXT, P_EMP_ID, P_CCM_ID, P_TYPE, P_REASON);
        }
        #endregion

        /// <summary>
        /// 查看终止计划原因和说明
        /// </summary>
        /// <param name="C_CCM_ID">连铸机主键</param>
        /// <param name="d_dt_b">操作开始时间</param>
        /// <param name="d_dt_e">操作结束时间</param>
        /// <returns></returns>
        public DataTable GetZZPlan(string C_CCM_ID, string d_dt_b, string d_dt_e)
        {
            return dal.GetZZPlan(C_CCM_ID, d_dt_b, d_dt_e);
        }
        /// <summary>
        /// 查看计划调整原因和说明
        /// </summary>
        /// <param name="C_CCM_ID">连铸机主键</param>
        /// <param name="d_dt_b">操作开始时间</param>
        /// <param name="d_dt_e">操作结束时间</param>
        /// <returns></returns>
        public DataTable GetTZPlan(string C_CCM_ID, string d_dt_b, string d_dt_e)
        {
            return dal.GetTZPlan(C_CCM_ID, d_dt_b, d_dt_e);
        }

    }
}

