using System;
using System.Data;
using System.Collections.Generic;
using RV.MODEL;
using RV.DAL;

namespace RV.BLL
{
    /// <summary>
    /// 用户表
    /// </summary>
    public partial class BllTS_USER
    {
        private readonly DalTS_USER dal = new DalTS_USER();
        public BllTS_USER()
        { }

        /// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string C_ACCOUNT)
        {
            return dal.Exists(C_ACCOUNT);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(ModTS_USER model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(ModTS_USER model)
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
        public ModTS_USER GetModel(string C_ACCOUNT, string C_PASSWORD)
        {
            return dal.GetModel(C_ACCOUNT, C_PASSWORD);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public ModTS_USER GetModel(string C_ACCOUNT)
        {
            return dal.GetModel(C_ACCOUNT);
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
        public List<ModTS_USER> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<ModTS_USER> DataTableToList(DataTable dt)
        {
            List<ModTS_USER> modelList = new List<ModTS_USER>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                ModTS_USER model;
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
		/// 获得数据列表
		/// </summary>
		public DataSet GetUserList()
        {
            return dal.GetUserList();
        }

        /// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList()
        {
            return dal.GetList();
        }
    }
}

