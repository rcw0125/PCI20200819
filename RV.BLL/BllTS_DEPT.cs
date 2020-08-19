using System;
using System.Data;
using System.Collections.Generic;
using RV.MODEL;
using RV.DAL;

namespace RV.BLL
{
    /// <summary>
    /// 部门表
    /// </summary>
    public partial class BllTS_DEPT
    {
        private readonly DalTS_DEPT dal = new DalTS_DEPT();
        public BllTS_DEPT()
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
        public bool Add(ModTS_DEPT model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(ModTS_DEPT model)
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
        public ModTS_DEPT GetModel(string C_ID)
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
        public List<ModTS_DEPT> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<ModTS_DEPT> DataTableToList(DataTable dt)
        {
            List<ModTS_DEPT> modelList = new List<ModTS_DEPT>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                ModTS_DEPT model;
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
		/// 获得数据列表
		/// </summary>
		public DataSet GetRootList()
        {
            return dal.GetRootList();
        }

        /// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetChildrenList()
        {
            return dal.GetChildrenList();
        }

        /// <summary>
        /// 获取最大部门代码
        /// </summary>
        public string GetMaxCode(string c_parent_id)
        {
            return dal.GetMaxCode(c_parent_id);
        }

        /// <summary>
        /// 获取部门代码
        /// </summary>
        public string GetCode(string C_ID)
        {
            return dal.GetCode(C_ID);
        }

        /// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet Get_List(string c_parent_id)
        {
            return dal.Get_List(c_parent_id);
        }

        #endregion  BasicMethod
        #region  ExtensionMethod

        #endregion  ExtensionMethod
    }
}

