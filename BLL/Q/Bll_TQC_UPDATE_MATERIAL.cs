using System;
using System.Data;
using System.Collections.Generic;
using DAL;
using MODEL;
namespace BLL
{
    /// <summary>
    /// 修料管理
    /// </summary>
    public partial class Bll_TQC_UPDATE_MATERIAL
    {
        private readonly Dal_TQC_UPDATE_MATERIAL dal = new Dal_TQC_UPDATE_MATERIAL();
        public Bll_TQC_UPDATE_MATERIAL()
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
        public bool Add(Mod_TQC_UPDATE_MATERIAL model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Mod_TQC_UPDATE_MATERIAL model)
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
        public Mod_TQC_UPDATE_MATERIAL GetModel(string C_ID)
        {

            return dal.GetModel(C_ID);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList_CXXL(string strWhere)
        {
            return dal.GetList_CXXL(strWhere);
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList_Query(string strWhere)
        {
            return dal.GetList_Query(strWhere);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        /// <param name="begin">开始日期</param>
        /// <param name="end">结束日期</param>
        /// <param name="batchNo">批号</param>
        /// <param name="type">状态</param>
        /// <returns></returns>
        public DataSet GetList_Query_date(DateTime begin, DateTime end, string batchNo, string type,string strSta)
        {
            return dal.GetList_Query_date(begin, end, batchNo, type,strSta);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        /// <param name="begin">开始日期</param>
        /// <param name="end">结束日期</param>
        /// <param name="batchNo">批号</param>
        /// <param name="stl">钢种</param>
        /// <param name="Type">修料状态</param>
        /// <returns></returns>
        public DataSet GetList_Query_date_log(DateTime begin, DateTime end, string batchNo, string stl,string Type)
        {
            return dal.GetList_Query_date_log(begin, end, batchNo, stl,Type);
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
        public List<Mod_TQC_UPDATE_MATERIAL> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Mod_TQC_UPDATE_MATERIAL> DataTableToList(DataTable dt)
        {
            List<Mod_TQC_UPDATE_MATERIAL> modelList = new List<Mod_TQC_UPDATE_MATERIAL>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Mod_TQC_UPDATE_MATERIAL model;
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

        #endregion  ExtensionMethod
    }
}

