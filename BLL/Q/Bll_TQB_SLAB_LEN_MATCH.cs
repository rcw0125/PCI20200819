using System;
using System.Data;
using System.Collections.Generic;
using DAL;
using MODEL;
namespace BLL
{
    /// <summary>
    /// 钢坯定尺匹配
    /// </summary>
    public partial class Bll_TQB_SLAB_LEN_MATCH
    {
        private readonly Dal_TQB_SLAB_LEN_MATCH dal = new Dal_TQB_SLAB_LEN_MATCH();
        public Bll_TQB_SLAB_LEN_MATCH()
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
        public bool Add(Mod_TQB_SLAB_LEN_MATCH model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Mod_TQB_SLAB_LEN_MATCH model)
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
        public Mod_TQB_SLAB_LEN_MATCH GetModel(string C_ID)
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
		public DataSet GetSlabMatch(string C_STD_ID)
        {
            return dal.GetSlabMatch(C_STD_ID);
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Mod_TQB_SLAB_LEN_MATCH> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Mod_TQB_SLAB_LEN_MATCH> DataTableToList(DataTable dt)
        {
            List<Mod_TQB_SLAB_LEN_MATCH> modelList = new List<Mod_TQB_SLAB_LEN_MATCH>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Mod_TQB_SLAB_LEN_MATCH model;
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
        public DataSet GetSlabSize(string C_STD_ID)
        {
            return dal.GetSlabSize(C_STD_ID);
        }

        /// <summary>
        /// 根据钢种、执行标准获取订单生产钢坯信息
        /// </summary>
        /// <param name="C_STL_GRD">钢种</param>
        /// <param name="C_STD_CODE">执行标准</param>
        /// <returns>钢坯信息</returns>
        public DataSet GetOrderSlabSize(string C_STL_GRD, string C_STD_CODE, string C_REMARK)
        {
            return dal.GetOrderSlabSize(C_STL_GRD, C_STD_CODE, C_REMARK);
        }
        /// <summary>
        /// 根据钢坯断面和定尺获取理论单重
        /// </summary>
        /// <param name="C_SLAB_SIZE">断面</param>
        /// <param name="C_COLD_LEN">定尺</param>
        /// <returns>单重</returns>
        public decimal GetPW(string C_SLAB_SIZE, string C_COLD_LEN)
        {
            return dal.GetPW(C_SLAB_SIZE, C_COLD_LEN);
        }
            #endregion  ExtensionMethod
        }
}

