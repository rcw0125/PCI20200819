using System;
using System.Data;
using System.Collections.Generic;
using DAL;
using MODEL;
namespace BLL
{
    /// <summary>
    /// 钢坯定尺维护
    /// </summary>
    public partial class Bll_TQB_SLAB_LEN
    {
        private readonly Dal_TQB_SLAB_LEN dal = new Dal_TQB_SLAB_LEN();
        public Bll_TQB_SLAB_LEN()
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
        public bool Add(Mod_TQB_SLAB_LEN model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Mod_TQB_SLAB_LEN model)
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
        public Mod_TQB_SLAB_LEN GetModel(string C_ID)
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
		public DataSet GetSLabNoMatch_Cold(string C_STD_ID, string stl, string size)
        {
            return dal.GetSLabNoMatch_Cold(C_STD_ID, stl, size);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetSLabNoMatch_Hot(string C_STD_ID, string stl, string size)
        {
            return dal.GetSLabNoMatch_Hot(C_STD_ID, stl, size);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary> 
        /// <param name="stl">钢种</param>
        /// <param name="size">规格</param>
        /// <returns></returns>
        public DataSet GetSLabNoMatch613(string stl, string size, string std)
        {
            return dal.GetSLabNoMatch613(stl, size, std);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary> 
        /// <param name="stl">钢种</param>
        /// <param name="size">规格</param>
        /// <returns></returns>
        public DataSet GetSLabNoMatch611(string stl, string size, string std)
        {
            return dal.GetSLabNoMatch611(stl, size, std);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary> 
        /// <param name="stl">钢种</param>
        /// <param name="size">规格</param>
        /// <returns></returns>
        public DataSet GetSLabNoMatch611_BXG(string stl, string size, string std)
        {
            return dal.GetSLabNoMatch611_BXG(stl, size, std);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Mod_TQB_SLAB_LEN> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Mod_TQB_SLAB_LEN> DataTableToList(DataTable dt)
        {
            List<Mod_TQB_SLAB_LEN> modelList = new List<Mod_TQB_SLAB_LEN>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Mod_TQB_SLAB_LEN model;
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

