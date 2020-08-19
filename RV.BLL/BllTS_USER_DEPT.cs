using System;
using System.Data;
using System.Collections.Generic;
using RV.MODEL;
using RV.DAL;

namespace RV.BLL
{
    /// <summary>
    /// TS_USER_DEPT
    /// </summary>
    public partial class BllTS_USER_DEPT
    {
        private readonly DalTS_USER_DEPT dal = new DalTS_USER_DEPT();
        public BllTS_USER_DEPT()
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
        public bool Add(ModTS_USER_DEPT model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(ModTS_USER_DEPT model)
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
        public ModTS_USER_DEPT GetModel(string C_ID)
        {
            return dal.GetModel(C_ID);
        }

        /// <summary>
		/// 得到一个对象实体
		/// </summary>
		public ModTS_USER_DEPT Get_Model(string C_USER_ID)
        {
            return dal.Get_Model(C_USER_ID);
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
        public List<ModTS_USER_DEPT> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<ModTS_USER_DEPT> DataTableToList(DataTable dt)
        {
            List<ModTS_USER_DEPT> modelList = new List<ModTS_USER_DEPT>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                ModTS_USER_DEPT model;
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

        #endregion  BasicMethod
        #region  ExtensionMethod

        #endregion  ExtensionMethod
    }
}

