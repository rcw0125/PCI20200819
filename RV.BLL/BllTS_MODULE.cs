using System;
using System.Data;
using System.Collections.Generic;
using RV.MODEL;
using RV.DAL;

namespace RV.BLL
{
    /// <summary>
    /// PCI菜单信息表
    /// </summary>
    public partial class BllTS_MODULE
    {
        private readonly DalTS_MODULE dal = new DalTS_MODULE();
        public BllTS_MODULE()
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
        public bool Add(ModTS_MODULE model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(ModTS_MODULE model)
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
        public bool DeleteList(string C_MODULEIDlist)
        {
            return dal.DeleteList(C_MODULEIDlist);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public ModTS_MODULE GetModel(string C_MODULEID)
        {

            return dal.GetModel(C_MODULEID);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public ModTS_MODULE GetModel(string C_PARENTMODULEID, int N_ORDER)
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
        public List<ModTS_MODULE> GetModelList(string strWhere, string strType)
        {
            DataSet ds = dal.GetList(strWhere, strType);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<ModTS_MODULE> DataTableToList(DataTable dt)
        {
            List<ModTS_MODULE> modelList = new List<ModTS_MODULE>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                ModTS_MODULE model;
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
        /// 获取参数
        /// </summary>
        public string Get_CS(string C_MODULENAME, string C_MODULECLASS)
        {
            return dal.Get_CS(C_MODULENAME, C_MODULECLASS);
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
        public DataSet GetMenuList(string strWhere, string strType, string strID)
        {
            return dal.GetMenuList(strWhere, strType, strID);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(string c_parentmoduleid, string C_DISABLE)
        {
            return dal.Update(c_parentmoduleid, C_DISABLE);
        }
    }
}

