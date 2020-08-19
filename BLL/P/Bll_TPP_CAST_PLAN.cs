using System;
using System.Data;
using System.Collections.Generic;
using DAL;
using MODEL;
namespace BLL
{
    /// <summary>
    /// 炼钢计划
    /// </summary>
    public partial class Bll_TPP_CAST_PLAN
    {
        private readonly Dal_TPP_CAST_PLAN dal = new Dal_TPP_CAST_PLAN();
        public Bll_TPP_CAST_PLAN()
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
        public bool Add(Mod_TPP_CAST_PLAN model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Mod_TPP_CAST_PLAN model)
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
        /// 删除一条数据
        /// </summary>
        public bool DeleteList(string C_IDlist)
        {
            return dal.DeleteList(C_IDlist);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Mod_TPP_CAST_PLAN GetModel(string C_ID)
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
        public List<Mod_TPP_CAST_PLAN> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Mod_TPP_CAST_PLAN> DataTableToList(DataTable dt)
        {
            List<Mod_TPP_CAST_PLAN> modelList = new List<Mod_TPP_CAST_PLAN>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Mod_TPP_CAST_PLAN model;
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
        /// 向炼钢MES推送炼钢计划
        /// </summary>
        /// <param name="P_CC_ID">连铸主键</param>
        /// <param name="P_ROW_COUNT">计划数</param>
        /// <returns></returns>
        public int Down_Plan_To_Mes(string P_CC_ID, int P_ROW_COUNT)
        {
            return dal.Down_Plan_To_Mes(P_CC_ID, P_ROW_COUNT);
        }

        /// <summary>
        /// 获取符合条件炉数
        /// </summary>
        /// <param name="C_CCM_ID">连铸ID</param>
        /// <param name="n_sort">顺序号</param>
        /// <returns></returns>
        public int GetStoveCount(string C_CCM_ID, int n_sort)
        {
            return dal.GetStoveCount(C_CCM_ID, n_sort);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool BackPlan(string C_CTRL_NO)
        {
            return dal.BackPlan(C_CTRL_NO);
        }

        /// <summary>
        /// 获取指定炉号计划；MES是否执行
        /// </summary>
        /// <param name="stove">炉号</param>
        /// <returns></returns>
        public int Get_Stove_State(string stove)
        {
            return dal.Get_Stove_State(stove);
        }

        /// <summary>
        /// 获取需要撤销计划的状态
        /// </summary>
        /// <param name="C_PLAN_ID">tsp_plan_sms主键</param>
        /// <returns></returns>
        public int Get_Plan_State(string C_PLAN_ID)
        {
            return dal.Get_Plan_State(C_PLAN_ID);
        }

        #endregion  BasicMethod
        #region  ExtensionMethod

        #endregion  ExtensionMethod

        /// <summary>
        /// 删除已下调度计划
        /// </summary>
        /// <param name="C_PLAN_ID">炉次计划主键</param>
        /// <returns></returns>
        public bool DeletePlan(string C_PLAN_ID)
        {
            return dal.DeletePlan(C_PLAN_ID);
        }
        }
}

