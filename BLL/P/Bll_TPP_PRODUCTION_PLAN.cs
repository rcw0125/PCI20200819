using System;
using System.Data;
using System.Collections.Generic;
using DAL;
using MODEL;
namespace BLL
{
    /// <summary>
    /// 订单方案表
    /// </summary>
    public partial class Bll_TPP_PRODUCTION_PLAN
    {
        private readonly Dal_TPP_PRODUCTION_PLAN dal = new Dal_TPP_PRODUCTION_PLAN();
        public Bll_TPP_PRODUCTION_PLAN()
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
        public bool Add(Mod_TPP_PRODUCTION_PLAN model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Mod_TPP_PRODUCTION_PLAN model)
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
        public Mod_TPP_PRODUCTION_PLAN GetModel(string C_ID)
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
        public List<Mod_TPP_PRODUCTION_PLAN> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Mod_TPP_PRODUCTION_PLAN> DataTableToList(DataTable dt)
        {
            List<Mod_TPP_PRODUCTION_PLAN> modelList = new List<Mod_TPP_PRODUCTION_PLAN>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Mod_TPP_PRODUCTION_PLAN model;
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
        /// 分页获取数据列表
        /// </summary>
        //public DataSet GetList(int PageSize,int PageIndex,string strWhere)
        //{
        //return dal.GetList(PageSize,PageIndex,strWhere);
        //}

        #endregion  BasicMethod
        #region  ExtensionMethod

        public DataSet GetFADDList(string C_PRODUCTION_PLAN, string strZXBZ, string strGZ, string strGG, string N_EXEC_STATUS)
        {
            return dal.GetFADDList(C_PRODUCTION_PLAN, strZXBZ, strGZ, strGG, N_EXEC_STATUS);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetFADDList(string C_PRODUCTION_PLAN, string strZXBZ, string strGZ, string strGG1, string strGG2, string N_EXEC_STATUS)
        {
            return dal.GetFADDList(C_PRODUCTION_PLAN, strZXBZ, strGZ, strGG1, strGG2, N_EXEC_STATUS);
        }
        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Mod_TPP_PRODUCTION_PLAN GetModelByOrderID(string C_ORDER_NO, string C_PRODUCTION_PLAN)
        {
            return dal.GetModelByOrderID(C_ORDER_NO, C_PRODUCTION_PLAN);
        }
        /// <summary>
        /// 复制订单到方案表
        /// </summary>
        public bool Copy(string C_ITEM_NAME)
        {
            return dal.Copy(C_ITEM_NAME);
        }

        /// <summary>
        /// 获取数据
        /// </summary>
        /// <param name="C_PRODUCTION_PLAN">方案</param>
        /// <param name="GrdType">钢种类型</param>
        /// <param name="KHMC">客户名称</param>
        /// <returns></returns>
        public DataSet GetList(string C_PRODUCTION_PLAN, string GrdType, string KHMC)
        {
            return dal.GetList(C_PRODUCTION_PLAN, GrdType, KHMC);
        }
        public DataSet GetGrdList(string C_PRODUCTION_PLAN, string GrdType)
        {
            return dal.GetGrdList(C_PRODUCTION_PLAN, GrdType);
        }
        /// <summary>
        /// 获取该方案下规格
        /// </summary>
        /// <param name="C_PRODUCTION_PLAN"></param>
        /// <returns></returns>
        public DataSet GetGGList(string C_PRODUCTION_PLAN, string C_SPEC)
        {
            return dal.GetGGList(C_PRODUCTION_PLAN, C_SPEC);
        }
        /// <summary>
        /// 获取该方案下客户类别下客户
        /// </summary>
        /// <param name="C_PRODUCTION_PLAN"></param>
        /// <param name="N_USER_LEV"></param>
        /// <returns></returns>
        public DataSet GetKHList(string C_PRODUCTION_PLAN, string N_USER_LEV)
        {
            return dal.GetKHList(C_PRODUCTION_PLAN, N_USER_LEV);
        }

        /// <summary>
        /// 获取炼钢待排产订单信息
        /// </summary>
        /// <param name="C_PRODUCTION_PLAN">订单方案号</param>
        /// <param name="strZXBZ">执行标准</param>
        /// <param name="strGZ">钢种</param>
        /// <param name="strGG">规格</param>
        /// <param name="N_LGPC_STATUS">炼钢排产状态(0未排产，1已排产)</param>
        /// <returns></returns>
        public DataSet GetFADDList_LG(string C_PRODUCTION_PLAN, string strZXBZ, string strGZ, string strGG, string N_LGPC_STATUS)
        {
            return dal.GetFADDList_LG(C_PRODUCTION_PLAN, strZXBZ, strGZ, strGG, N_LGPC_STATUS);
        }

        #endregion  ExtensionMethod
    }

}