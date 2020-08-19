using System;
using System.Data;
using System.Collections.Generic;
using DAL;
using MODEL;
namespace BLL
{
    /// <summary>
    /// 钢种整浇次炉数
    /// </summary>
    public partial class Bll_TPB_CAST_STOVE
    {
        private readonly Dal_TPB_CAST_STOVE dal = new Dal_TPB_CAST_STOVE();
        public Bll_TPB_CAST_STOVE()
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
        public bool Add(Mod_TPB_CAST_STOVE model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Mod_TPB_CAST_STOVE model)
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
        public Mod_TPB_CAST_STOVE GetModel(string C_ID)
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
        public List<Mod_TPB_CAST_STOVE> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Mod_TPB_CAST_STOVE> DataTableToList(DataTable dt)
        {
            List<Mod_TPB_CAST_STOVE> modelList = new List<Mod_TPB_CAST_STOVE>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Mod_TPB_CAST_STOVE model;
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
        public DataSet GetAllList(string sqlwhere)
        {
            return GetList(sqlwhere);
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
        public DataSet LSGetList()
        {
            return dal.LSGetList();
        }
        /// <summary>
        /// 是否存在相同数据
        /// </summary>
        public bool ExistsDate(string C_STL_GRD, string C_STD_CODE,string C_STA_ID)
        {
            return dal.ExistsDate(C_STL_GRD, C_STD_CODE,C_STA_ID);
        }
       /// <summary>
       /// 
       /// </summary>
       /// <param name="status"></param>
       /// <param name="C_STL_GRD"></param>
       /// <param name="C_STD_CODE"></param>
       /// <param name="C_STA_ID"></param>
       /// <returns>返回</returns>
        public DataSet GetList(int status, string C_STL_GRD, string C_STD_CODE,string C_STA_ID)
        {
            return dal.GetList(status, C_STL_GRD, C_STD_CODE, C_STA_ID);
        }

        /// <summary>
        /// 获取浇次炉数
        /// </summary>
        /// <param name="C_STL_GRD"></param>
        /// <param name="C_STD_CODE"></param>
        /// <returns></returns>
        public DataSet GetList(string C_STA_ID, string C_STL_GRD, string C_STD_CODE)
        {
            return dal.GetList(C_STA_ID,C_STL_GRD, C_STD_CODE);
        }

        /// <summary>
        /// 获取浇次炉数
        /// </summary>
        /// <param name="C_STA_ID">连铸主键</param>
        /// <param name="C_STL_GRD">钢种</param>
        /// <param name="C_STD_CODE">执行标准</param>
        /// <returns></returns>
        public List<Mod_TPB_CAST_STOVE> GetZJCList(string C_STA_ID, string C_STL_GRD, string C_STD_CODE)
        {
            DataSet ds = dal.GetZJCList( C_STA_ID,  C_STL_GRD,  C_STD_CODE);
            return DataTableToList(ds.Tables[0]);
        }

        #endregion  ExtensionMethod
    }
}

