using System;
using System.Data;
using System.Collections.Generic;
using DAL;
using MODEL;
namespace BLL
{
    /// <summary>
    /// 代轧钢坯匹配
    /// </summary>
    public partial class Bll_TQB_REPLACE_SLAB
    {
        private readonly Dal_TQB_REPLACE_SLAB dal = new Dal_TQB_REPLACE_SLAB();
        public Bll_TQB_REPLACE_SLAB()
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
        public bool Add(Mod_TQB_REPLACE_SLAB model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Mod_TQB_REPLACE_SLAB model)
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
        public Mod_TQB_REPLACE_SLAB GetModel(string C_ID)
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
        public List<Mod_TQB_REPLACE_SLAB> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Mod_TQB_REPLACE_SLAB> DataTableToList(DataTable dt)
        {
            List<Mod_TQB_REPLACE_SLAB> modelList = new List<Mod_TQB_REPLACE_SLAB>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Mod_TQB_REPLACE_SLAB model;
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
        /// <param name="C_SF_BXG">是否为不锈钢</param>
        /// <param name="C_STL_GRD">钢种</param>
        /// <param name="C_STD_CODE">执行标准</param>
        /// <returns></returns>
        public DataSet GetList_Query(string C_SF_BXG, string C_STL_GRD, string C_STD_CODE)
        {
            return dal.GetList_Query(C_SF_BXG, C_STL_GRD, C_STD_CODE);
        }
        #endregion  ExtensionMethod

        #region 可代轧钢种

        
        /// <summary>
        /// 查询是否使用替代钢坯进行炼钢生产
        /// </summary>
        /// <param name="C_STL_GRD">订单钢种</param>
        /// <param name="C_STD_CODE">订单标准</param>
        /// <returns></returns>
        public DataTable GetReplaceSlab(string C_STL_GRD, string C_STD_CODE)
        {
            return dal.GetReplaceSlab(C_STL_GRD, C_STD_CODE);
        }
        #endregion
    }
}

