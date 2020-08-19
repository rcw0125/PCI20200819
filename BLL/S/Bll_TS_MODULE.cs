using System;
using System.Data;
using System.Collections.Generic;
using DAL;
using MODEL;
namespace BLL
{
    /// <summary>
    /// PCI菜单信息表
    /// </summary>
    public partial class Bll_TS_MODULE
    {
        private readonly Dal_TS_MODULE dal = new Dal_TS_MODULE();
        public Bll_TS_MODULE()
        { }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string C_MODULEID)
        {
            return dal.Exists(C_MODULEID);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Mod_TS_MODULE model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Mod_TS_MODULE model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(string C_MODULEID)
        {

            return dal.Delete(C_MODULEID);
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete_PID(string C_PARENTMODULEID)
        {

            return dal.Delete_PID(C_PARENTMODULEID);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete_UserFunction(string c_module_id)
        {
            return dal.Delete_UserFunction(c_module_id);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool DeleteList(string C_MODULEIDlist)
        {
            return dal.DeleteList(C_MODULEIDlist);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Mod_TS_MODULE GetModel(string C_MODULEID)
        {

            return dal.GetModel(C_MODULEID);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Mod_TS_MODULE GetModel(string C_PARENTMODULEID, int N_ORDER)
        {
            return dal.GetModel(C_PARENTMODULEID, N_ORDER);
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere, string strType)
        {
            return dal.GetList(strWhere, strType);
        }

        /// <summary>
        /// 获得权限列表
        /// </summary>
        public DataSet GetList()
        {
            return dal.GetList();
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList_MAX(string strWhere)
        {
            return dal.GetList_MAX(strWhere);
        }
        /// <summary>
        /// 获取权限菜单ID
        /// </summary>
        /// <param name="strID">子节点ID</param>
        /// <returns></returns>
        public DataSet Get_MenuID(string strID)
        {
            return dal.Get_MenuID(strID);
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Mod_TS_MODULE> GetModelList(string strWhere, string strType)
        {
            DataSet ds = dal.GetList(strWhere, strType);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Mod_TS_MODULE> DataTableToList(DataTable dt)
        {
            List<Mod_TS_MODULE> modelList = new List<Mod_TS_MODULE>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Mod_TS_MODULE model;
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
        public DataSet GetList_query(string strWhere)
        {
            return dal.GetList_query(strWhere);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetAllList()
        {
            return GetList("", "");
        }

        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            return dal.GetRecordCount(strWhere);
        }

        /// <summary>
		/// 获取最大主键
		/// </summary>
		public int GetMaxID()
        {
            return dal.GetMaxID();
        }

        /// <summary>
		/// 获取最大排序号
		/// </summary>
		public int GetOrder(string strID)
        {
            return dal.GetOrder(strID);
        }

        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
        {
            return dal.GetListByPage(strWhere, orderby, startIndex, endIndex);
        }

        /// <summary>
        /// 获取窗体名
        /// </summary>
        public string Get_FormName(string C_MODULEID)
        {
            return dal.Get_FormName(C_MODULEID);
        }

        /// <summary>
        /// 更新菜单顺序
        /// </summary>
        /// <param name="str_ID_up"></param>
        /// <param name="str_ID_down"></param>
        /// <param name="order_up"></param>
        /// <param name="order_down"></param>
        /// <returns></returns>
        public int ResetOrder(string str_ID_up, string str_ID_down, int order_up, int order_down)
        {
            return dal.ResetOrder(str_ID_up, str_ID_down, order_up, order_down);
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetMenuList(string strWhere, string strType)
        {
            return dal.GetMenuList(strWhere, strType);
        }

        /// <summary>
        /// 获取该按钮是否已被分配权限
        /// </summary>
        /// <param name="c_module_id">按钮主键</param>
        /// <returns></returns>
        public int GetUsingCount(string c_module_id)
        {
            return dal.GetUsingCount(c_module_id);
        }

        /// <summary>
        /// 获取按钮权限列表
        /// </summary>
        /// <param name="strFormName">窗体名</param>
        /// <param name="strUserID">用户ID</param>
        /// <param name="c_parentmoduleid">菜单ID</param>
        /// <returns></returns>
        public DataSet GetBtnList(string strFormName, string strUserID, string c_parentmoduleid)
        {
            return dal.GetBtnList(strFormName, strUserID, c_parentmoduleid);
        }
    }
}

