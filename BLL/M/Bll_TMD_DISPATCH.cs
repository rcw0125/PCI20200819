using System;
using System.Data;
using System.Collections.Generic;
using DAL;
using MODEL;
namespace BLL
{
    /// <summary>
    /// 发运单
    /// </summary>
    public partial class Bll_TMD_DISPATCH
    {
        private readonly Dal_TMD_DISPATCH dal = new Dal_TMD_DISPATCH();
        public Bll_TMD_DISPATCH()
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
        public bool Add(Mod_TMD_DISPATCH model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Mod_TMD_DISPATCH model)
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
        public Mod_TMD_DISPATCH GetModel(string C_ID)
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
        public List<Mod_TMD_DISPATCH> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Mod_TMD_DISPATCH> DataTableToList(DataTable dt)
        {
            List<Mod_TMD_DISPATCH> modelList = new List<Mod_TMD_DISPATCH>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Mod_TMD_DISPATCH model;
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
        /// 获取钢坯发运单
        /// </summary>
        /// <param name="C_ID">发运单号</param>
        /// <param name="dt1">时间1</param>
        /// <param name="dt2">时间2</param>
        /// <param name="status">状态</param>
        /// <returns></returns>
        public DataSet GetFYDList(string C_ID, DateTime dt1, DateTime dt2, string status)
        {
            return dal.GetFYDList(C_ID,dt1,dt2,status);
        }
        /// <summary>
        /// 获取钢坯出库单
        /// </summary>
        /// <param name="ckdh">出库单号</param>
        /// <param name="cph">车牌号</param>
        /// <param name="fyfs">发运方式</param>
        /// <returns></returns>
        public DataSet GetCKDList(int status, string ckdh, string cph, string fyfs)
        {
            return dal.GetCKDList(status, ckdh, cph, fyfs);
        }
        /// <summary>
        /// 通过出库单号获取数据
        /// </summary>
        /// <param name="status"></param>
        /// <param name="C_CKDH"></param>
        /// <returns></returns>
        public DataSet GetCKByCKDH(int status,string C_CKDH)
        {
            return dal.GetCKByCKDH(status,C_CKDH);
        }
        /// <summary>
        /// 根据状态和车牌号获取车牌号
        /// </summary>
        /// <param name="status">状态1钢坯2线材</param>
        /// <param name="cph">车牌号</param>
        /// <returns></returns>
        public DataSet GetCPH(int status, string cph)
        {
            return dal.GetCPH(status, cph);
        }
        #endregion  ExtensionMethod
    }
}
