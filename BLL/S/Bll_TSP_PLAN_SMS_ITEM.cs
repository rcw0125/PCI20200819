using System;
using System.Data;
using System.Collections.Generic;
using DAL;
using MODEL;
namespace BLL
{
    /// <summary>
    /// 炼钢计划拆分表
    /// </summary>
    public partial class Bll_TSP_PLAN_SMS_ITEM
    {
        private readonly Dal_TSP_PLAN_SMS_ITEM dal = new Dal_TSP_PLAN_SMS_ITEM();
        public Bll_TSP_PLAN_SMS_ITEM()
        { }
        #region  BasicMethod

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Mod_TSP_PLAN_SMS_ITEM model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Mod_TSP_PLAN_SMS_ITEM model)
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
        public Mod_TSP_PLAN_SMS_ITEM GetModel()
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
        public List<Mod_TSP_PLAN_SMS_ITEM> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Mod_TSP_PLAN_SMS_ITEM> DataTableToList(DataTable dt)
        {
            List<Mod_TSP_PLAN_SMS_ITEM> modelList = new List<Mod_TSP_PLAN_SMS_ITEM>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Mod_TSP_PLAN_SMS_ITEM model;
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
        /// 差询炉次计划和订单中间表
        /// </summary>
        /// <param name="C_PLAN_SMS_ID">炉次计划主键</param>
        /// <returns></returns>
        public DataTable GetLc(string C_PLAN_SMS_ID)
        {
            return dal.GetLc(C_PLAN_SMS_ID);
        }

        /// <summary>
        ///工根据 C_PLAN_SMS_ID 删除中间表
        /// </summary>
        /// <param name="C_PLAN_SMS_ID"></param>
        /// <returns></returns>
        public bool Delete(string C_PLAN_SMS_ID)
        {
            return dal.Delete(C_PLAN_SMS_ID);
        }
            #endregion  ExtensionMethod
        }
}

