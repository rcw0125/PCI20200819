using System;
using System.Data;
using System.Collections.Generic;
using DAL;
using MODEL;
namespace BLL
{
    /// <summary>
    /// 排产初始化主表
    /// </summary>
    public partial class Bll_TPP_PROD_INITIALIZE
    {
        private readonly Dal_TPP_PROD_INITIALIZE dal = new Dal_TPP_PROD_INITIALIZE();
        public Bll_TPP_PROD_INITIALIZE()
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
        public bool Add(Mod_TPP_PROD_INITIALIZE model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Mod_TPP_PROD_INITIALIZE model)
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
        public Mod_TPP_PROD_INITIALIZE GetModel(string C_ID)
        {

            return dal.GetModel(C_ID);
        }
        /// <summary>
        /// 通过期数获得实体
        /// </summary>
        /// <param name="C_ISSUE">期数</param>
        /// <returns></returns>
        public Mod_TPP_PROD_INITIALIZE GetModelByISSUE(string C_ISSUE)
        {
            return dal.GetModelByISSUE(C_ISSUE);
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
        public List<Mod_TPP_PROD_INITIALIZE> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Mod_TPP_PROD_INITIALIZE> DataTableToList(DataTable dt)
        {
            List<Mod_TPP_PROD_INITIALIZE> modelList = new List<Mod_TPP_PROD_INITIALIZE>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Mod_TPP_PROD_INITIALIZE model;
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


        #endregion  BasicMethod

        #region  ExtensionMethod
        /// <summary>
        /// 得到一个排产方案序号
        /// </summary>
        public string GetMaxNum(string strDate)
        {

            return dal.GetMaxNum(strDate);
        }


        /// <summary>
        ///获取当前选择年月的排产方案数量
        /// </summary>
        /// <param name="YM">选择的年月</param>
        /// <param name="type">排产类型：月排产/旬排产</param>
        /// <returns>选择年月排产数量</returns>
        public int GetTheMonthNum(string YM, string type)
        {
            return dal.GetTheMonthNum(YM, type);
        }

        /// <summary>
        /// 根据年月加载档期信息
        /// </summary>
        /// <param name="YM">选择的年月</param>
        /// <param name="C_TYPE">选择的类型</param>
        public DataTable GetListByYM(string YM, string C_TYPE)
        {
            return dal.GetListByYM(YM, C_TYPE);
        }

        #endregion  ExtensionMethod
    }
}

