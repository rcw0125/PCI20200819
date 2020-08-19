using System;
using System.Data;
using System.Collections.Generic;
using DAL;
using MODEL;
namespace BLL
{
    /// <summary>
    /// 线材生产计划明细表
    /// </summary>
    public partial class Bll_TRP_PLAN_ROLL_ITEM
    {
        private readonly Dal_TRP_PLAN_ROLL_ITEM dal = new Dal_TRP_PLAN_ROLL_ITEM();
        public Bll_TRP_PLAN_ROLL_ITEM()
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
        public bool Add(Mod_TRP_PLAN_ROLL_ITEM model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Mod_TRP_PLAN_ROLL_ITEM model)
        {
            return dal.Update(model);
        }
        /// <summary>
        /// 保存排序后的计划
        /// </summary>
        /// <param name="C_ID">计划主键</param>
        /// <param name="D_P_START_TIME">开始时间</param>
        /// <param name="D_P_END_TIME">结束时间</param>
        /// <param name="N_SORT">排序号</param>
        /// <returns>是否成功</returns>
        public bool Update(string C_ID, DateTime D_P_START_TIME, DateTime D_P_END_TIME, int N_SORT)
        {
            return dal.Update(C_ID, D_P_START_TIME, D_P_END_TIME, N_SORT);
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
        public Mod_TRP_PLAN_ROLL_ITEM GetModel_Item(string C_ID)
        {
            return dal.GetModel_Item(C_ID);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Mod_TRP_PLAN_ROLL_ITEM GetModel(string C_ID)
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
        public List<Mod_TRP_PLAN_ROLL_ITEM> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Mod_TRP_PLAN_ROLL_ITEM> DataTableToList(DataTable dt)
        {
            List<Mod_TRP_PLAN_ROLL_ITEM> modelList = new List<Mod_TRP_PLAN_ROLL_ITEM>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Mod_TRP_PLAN_ROLL_ITEM model;
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
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string timeS, string timeE, string c_stl_grd, string c_std_code, string c_sta_id, string n_status)
        {
            return dal.GetList(timeS, timeE, c_stl_grd, c_std_code, c_sta_id, n_status);
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Mod_TRP_PLAN_ROLL_ITEM> GetModelList(string timeS, string timeE, string c_stl_grd, string c_std_code, string c_sta_id, string n_status)
        {
            return DataTableToList(GetList(timeS, timeE, c_stl_grd, c_std_code, c_sta_id, n_status).Tables[0]);
        }

        #endregion  BasicMethod
        #region  ExtensionMethod
        /// <summary>
        /// 获取最大上线值
        /// </summary>
        /// <returns></returns>
        public object GetLimitMax(string planID)
        {
            return dal.GetLimitMax(planID);
        }
        #endregion  ExtensionMethod

        /// <summary>
        /// 根据订单主键获取列表
        /// </summary>
        /// <param name="C_INITIALIZE_ITEM_ID">订单表主键</param>
        /// <returns></returns>
        public DataTable GetListByOrderID(string C_INITIALIZE_ITEM_ID)
        {

            return dal.GetListByOrderID(C_INITIALIZE_ITEM_ID);

        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete_Trans(string C_ID)
        {
            return dal.Delete_Trans(C_ID);
        }
        }
}

