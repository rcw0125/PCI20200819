using System;
using System.Data;
using System.Collections.Generic;
using DAL;
using MODEL;
namespace BLL
{/// <summary>
 /// 方案初始化表
 /// </summary>
    public partial class Bll_TPP_INITIALIZE_ITEM
    {
        private readonly Dal_TPP_INITIALIZE_ITEM dal = new Dal_TPP_INITIALIZE_ITEM();
        public Bll_TPP_INITIALIZE_ITEM()
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
        public bool Add(Mod_TPP_INITIALIZE_ITEM model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Mod_TPP_INITIALIZE_ITEM model)
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
        public Mod_TPP_INITIALIZE_ITEM GetModel(string C_ID)
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
        public List<Mod_TPP_INITIALIZE_ITEM> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Mod_TPP_INITIALIZE_ITEM> DataTableToList(DataTable dt)
        {
            List<Mod_TPP_INITIALIZE_ITEM> modelList = new List<Mod_TPP_INITIALIZE_ITEM>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Mod_TPP_INITIALIZE_ITEM model;
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
        /// 获取方案列表
        /// </summary>
        /// <param name="N_STATUS">方案状态</param>
        /// <param name="C_ISSUE">期号</param>
        /// <param name="C_ITEM_NAME">方案名称</param>
        /// <returns>方案列表</returns>
        public DataSet GetList(int? N_STATUS, string C_ISSUE, string C_ITEM_NAME)
        {
            return dal.GetList(N_STATUS, C_ISSUE, C_ITEM_NAME);
        }
        /// <summary>
        /// 获取方案列表
        /// </summary>
        /// <param name="N_STATUS">状态</param>
        /// <param name="type">类型</param>
        /// <param name="dt1">开始日期</param>
        /// <param name="dt2">结束日期</param>
        /// <returns></returns>
        public DataSet GetList(int? N_STATUS, string type, string dt1, string dt2)
        {
            return dal.GetList(N_STATUS, type, dt1, dt2);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetListByNAME(string C_ITEM_NAME)
        {
            return dal.GetListByNAME(C_ITEM_NAME);
        }
        /// <summary>
        /// 获得期数
        /// </summary>
        public DataSet GetQSList()
        {
            return dal.GetQSList();
        }
        /// <summary>
        /// 获得当前期数
        /// </summary>
        public DataSet GetQSListByTime(DateTime dateTime)
        {
            return dal.GetQSListByTime(dateTime);
        }
        /// <summary>
        /// 根据期数获取数据
        /// </summary>
        public DataSet GetListByQS(string qs)
        {
            return dal.GetListByQS(qs);
        }

        /// <summary>
        /// 获取新的方案号
        /// </summary>
        /// <param name="C_ISSUE">档期号</param>
        /// <returns>方案号</returns>
        public string GetNewItemNameByIssue(string C_ISSUE)
        {
            return dal.GetNewItemNameByIssue(C_ISSUE);
        }
        #endregion  ExtensionMethod
    }
}
