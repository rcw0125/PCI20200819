using System;
using System.Data;
using System.Collections.Generic;
using DAL;
using MODEL;
namespace BLL
{
    /// <summary>
    /// 铁水标准信息主表
    /// </summary>
    public partial class Bll_TQB_TSBZ_MAIN
    {
        private readonly Dal_TQB_TSBZ_MAIN dal = new Dal_TQB_TSBZ_MAIN();
        public Bll_TQB_TSBZ_MAIN()
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
        public bool Add(Mod_TQB_TSBZ_MAIN model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Mod_TQB_TSBZ_MAIN model)
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
        public Mod_TQB_TSBZ_MAIN GetModel(string C_ID)
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
        public List<Mod_TQB_TSBZ_MAIN> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Mod_TQB_TSBZ_MAIN> DataTableToList(DataTable dt)
        {
            List<Mod_TQB_TSBZ_MAIN> modelList = new List<Mod_TQB_TSBZ_MAIN>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Mod_TQB_TSBZ_MAIN model;
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
        /// 加载铁水标准
        /// </summary>
        /// <param name="strGZFL">钢种分类</param>
        /// <param name="strGZ">钢种</param>
        /// <param name="strBZ">标准</param>
        /// <param name="iStatus">状态</param>
        /// <returns></returns>
        public DataSet GetListByWhere(string strGZFL, string strGZ, string strBZ, int iStatus)
        {
            return dal.GetListByWhere(strGZFL, strGZ, strBZ, iStatus);

        }

            #endregion  BasicMethod
        }
}