using System;
using System.Data;
using System.Collections.Generic;
using MODEL;
using DAL;

namespace BLL
{
    /// <summary>
    /// 性能检验过程量
    /// </summary>
    public partial class Bll_TQB_XN_CHECK_PROCEDURE
    {
        private readonly Dal_TQB_XN_CHECK_PROCEDURE dal = new Dal_TQB_XN_CHECK_PROCEDURE();
        public Bll_TQB_XN_CHECK_PROCEDURE()
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
        /// 获取CODE最大值
        /// </summary>
        /// <returns></returns>
        public string GetList_MAX()
        {
            return dal.GetList_MAX();
        }
        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Mod_TQB_XN_CHECK_PROCEDURE model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Mod_TQB_XN_CHECK_PROCEDURE model)
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
        public Mod_TQB_XN_CHECK_PROCEDURE GetModel(string C_ID)
        {

            return dal.GetModel(C_ID);
        }


        /// <summary>
        /// 获得数据列表-外键
        /// </summary>
        public DataSet GetList_ID(string strWhere)
        {
            return dal.GetList_ID(strWhere);
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
        public List<Mod_TQB_XN_CHECK_PROCEDURE> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Mod_TQB_XN_CHECK_PROCEDURE> DataTableToList(DataTable dt)
        {
            List<Mod_TQB_XN_CHECK_PROCEDURE> modelList = new List<Mod_TQB_XN_CHECK_PROCEDURE>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Mod_TQB_XN_CHECK_PROCEDURE model;
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

