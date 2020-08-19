using System;
using System.Data;
using System.Collections.Generic;
using DAL;
using MODEL;
using Oracle.ManagedDataAccess.Client;

namespace BLL
{
    public class Bll_TRC_WARM_FURNACE_LOG
    {
        private readonly Dal_TRC_WARM_FURNACE_LOG dal = new Dal_TRC_WARM_FURNACE_LOG();
        public Bll_TRC_WARM_FURNACE_LOG()
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
        public bool Add(Mod_TRC_WARM_FURNACE_LOG model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Mod_TRC_WARM_FURNACE_LOG model)
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
        /// 得到一个对象实体
        /// </summary>
        public Mod_TRC_WARM_FURNACE_LOG GetModel(string C_ID)
        {

            return dal.GetModel(C_ID);
        }


        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(DateTime begin, DateTime end, string strWhere)
        {
            return dal.GetList(begin, end,strWhere);
        }
       
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Mod_TRC_WARM_FURNACE_LOG> DataTableToList(DataTable dt)
        {
            List<Mod_TRC_WARM_FURNACE_LOG> modelList = new List<Mod_TRC_WARM_FURNACE_LOG>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Mod_TRC_WARM_FURNACE_LOG model;
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

        #endregion  ExtensionMethod
    }
}
