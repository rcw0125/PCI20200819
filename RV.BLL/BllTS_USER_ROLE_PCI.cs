using System;
using System.Data;
using System.Collections.Generic;
using RV.MODEL;
using RV.DAL;

namespace RV.BLL
{
    /// <summary>
    /// 用户角色
    /// </summary>
    public partial class BllTS_USER_ROLE_PCI
    {
        private readonly DalTS_USER_ROLE_PCI dal = new DalTS_USER_ROLE_PCI();
        public BllTS_USER_ROLE_PCI()
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
        public bool Add(ModTS_USER_ROLE_PCI model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(ModTS_USER_ROLE_PCI model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(string C_USER_ID)
        {
            return dal.Delete(C_USER_ID);
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
        public ModTS_USER_ROLE_PCI GetModel(string C_ID)
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
        public List<ModTS_USER_ROLE_PCI> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<ModTS_USER_ROLE_PCI> DataTableToList(DataTable dt)
        {
            List<ModTS_USER_ROLE_PCI> modelList = new List<ModTS_USER_ROLE_PCI>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                ModTS_USER_ROLE_PCI model;
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
        /// 设置用户权限
        /// </summary>
        /// <param name="strRoleID">角色ID集合</param>
        /// <param name="strUserID">用户ID</param>
        /// <returns></returns>
        public bool SaveFun(string strRoleID, string strUserID)
        {
            return dal.SaveFun(strRoleID, strUserID);
        }

        #endregion  BasicMethod
        #region  ExtensionMethod

        #endregion  ExtensionMethod
    }
}

