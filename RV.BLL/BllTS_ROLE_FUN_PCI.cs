using System;
using System.Data;
using System.Collections.Generic;
using RV.MODEL;
using RV.DAL;

namespace RV.BLL
{
    /// <summary>
    /// 角色权限
    /// </summary>
    public partial class BllTS_ROLE_FUN_PCI
    {
        private readonly DalTS_ROLE_FUN_PCI dal = new DalTS_ROLE_FUN_PCI();
        public BllTS_ROLE_FUN_PCI()
        { }
        #region  BasicMethod

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(ModTS_ROLE_FUN_PCI model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(ModTS_ROLE_FUN_PCI model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete()
        {
            //该表无主键信息，请自定义主键/条件字段
            return dal.Delete();
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public ModTS_ROLE_FUN_PCI GetModel()
        {
            //该表无主键信息，请自定义主键/条件字段
            return dal.GetModel();
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
        public List<ModTS_ROLE_FUN_PCI> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<ModTS_ROLE_FUN_PCI> DataTableToList(DataTable dt)
        {
            List<ModTS_ROLE_FUN_PCI> modelList = new List<ModTS_ROLE_FUN_PCI>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                ModTS_ROLE_FUN_PCI model;
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
        /// 保存角色权限
        /// </summary>
        /// <param name="lstCheckedID">按钮ID集合</param>
        /// <param name="dt">菜单ID集合</param>
        /// <param name="RoleID">角色ID</param>
        /// <returns></returns>
        public bool SaveFun(List<string> lstCheckedID, DataTable dt, string RoleID)
        {
            return dal.SaveFun(lstCheckedID, dt, RoleID);
        }

        #endregion  BasicMethod
        #region  ExtensionMethod

        #endregion  ExtensionMethod
    }
}

