using System;
using System.Data;
using System.Collections.Generic;
using DAL;
using MODEL;
namespace BLL
{
    /// <summary>
    /// 钢种合金消耗量
    /// </summary>
    public partial class Bll_TQB_ALLOY_CONSUMPTION
    {
        private readonly Dal_TQB_ALLOY_CONSUMPTION dal = new Dal_TQB_ALLOY_CONSUMPTION();
        public Bll_TQB_ALLOY_CONSUMPTION()
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
        public bool Add(Mod_TQB_ALLOY_CONSUMPTION model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Mod_TQB_ALLOY_CONSUMPTION model)
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
        public Mod_TQB_ALLOY_CONSUMPTION GetModel(string C_ID)
        {

            return dal.GetModel(C_ID);
        }
        /// <summary>
        /// 根据钢种、执行标准、合金名称得到实体对象
        /// </summary>
        /// <param name="C_STL_GRD">钢种</param>
        /// <param name="C_STD_CODE">执行标准</param>
        /// <param name="C_ALLOYN__CODE">合金代码</param>
        /// <param name="C_ALLOYN__NAME">合金名称</param>
        /// <returns></returns>
		public Mod_TQB_ALLOY_CONSUMPTION GetModel(string C_STL_GRD, string C_STD_CODE, string C_ALLOYN__CODE)
        {
            return dal.GetModel(C_STL_GRD, C_STD_CODE, C_ALLOYN__CODE);
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
        public List<Mod_TQB_ALLOY_CONSUMPTION> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Mod_TQB_ALLOY_CONSUMPTION> DataTableToList(DataTable dt)
        {
            List<Mod_TQB_ALLOY_CONSUMPTION> modelList = new List<Mod_TQB_ALLOY_CONSUMPTION>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Mod_TQB_ALLOY_CONSUMPTION model;
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
        /// 根据钢种、执行标准获取数据列表
        /// </summary>
        /// <param name="C_STL_GRD"></param>
        /// <param name="C_STD_CODE"></param>
        /// <returns></returns>
        public DataSet GetList(string C_STL_GRD, string C_STD_CODE)
        {
            return dal.GetList(C_STL_GRD, C_STD_CODE);
        }
        /// <summary>
        /// 根据钢种、执行标准获取合金需求数量
        /// </summary>
        /// <param name="C_STL_GRD"></param>
        /// <param name="C_STD_CODE"></param>
        /// <returns></returns>
        public DataSet GetAlloy(string C_STL_GRD, string C_STD_CODE)
        {
            return dal.GetAlloy(C_STL_GRD, C_STD_CODE);
        }
        /// <summary>
        /// 根据合金代码和合金名称查询
        /// </summary>
        /// <param name="C_STL_GRD">钢种</param>
        /// <param name="C_STD_CODE">执行标准</param>
        /// <param name="C_ALLOYN__CODE">合金代码</param>
        /// <param name="C_ALLOYN__NAME">合金名称</param>
        /// <returns></returns>
        public DataSet GetAlloyByWhere(string C_STL_GRD, string C_STD_CODE, string C_ALLOYN__CODE, string C_ALLOYN__NAME)
        {
            return dal.GetAlloyByWhere(C_STL_GRD, C_STD_CODE,C_ALLOYN__CODE, C_ALLOYN__NAME);
        }
        #endregion  ExtensionMethod
    }
}

