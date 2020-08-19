using System;
using System.Data;
using System.Collections.Generic;
using DAL;
using MODEL;
namespace BLL
{
    /// <summary>
    /// 客户档案
    /// </summary>
    public partial class Bll_TS_CUSTFILE
    {
        private readonly Dal_TS_CUSTFILE dal = new Dal_TS_CUSTFILE();
        public Bll_TS_CUSTFILE()
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
        public bool Add(Mod_TS_CUSTFILE model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Mod_TS_CUSTFILE model)
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
        public Mod_TS_CUSTFILE GetModel(string C_ID)
        {

            return dal.GetModel(C_ID);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Mod_TS_CUSTFILE GetCustModel(string custCode)
        {
            return dal.GetCustModel(custCode);
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
        public List<Mod_TS_CUSTFILE> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Mod_TS_CUSTFILE> DataTableToList(DataTable dt)
        {
            List<Mod_TS_CUSTFILE> modelList = new List<Mod_TS_CUSTFILE>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Mod_TS_CUSTFILE model;
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
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string C_NO, string C_NAME)
        {
            return dal.GetRecordCount(C_NO, C_NAME);
        }

        /// <summary>
        /// 获取客户信息
        /// </summary>
        /// <param name="C_NO">客户编码</param>
        /// <param name="C_NAME">客户名称</param>
        /// <param name="C_AREAMMAX">区域</param>
        /// <returns></returns>
        public DataSet GetCustomer(string C_NO, string C_NAME, string C_AREAMMAX)
        {

            return dal.GetCustomer(C_NO, C_NAME, C_AREAMMAX);
        }


        #endregion  BasicMethod

    }
}

