using System;
using System.Data;
using System.Collections.Generic;
using DAL;
using MODEL;
namespace BLL
{
    /// <summary>
    /// 轧钢排产日志表
    /// </summary>
    public partial class Bll_TB_ZG_PLAN_LOG
    {
        private readonly Dal_TB_ZG_PLAN_LOG dal = new Dal_TB_ZG_PLAN_LOG();
        public Bll_TB_ZG_PLAN_LOG()
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
        public bool Add(Mod_TB_ZG_PLAN_LOG model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Mod_TB_ZG_PLAN_LOG model)
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
        public Mod_TB_ZG_PLAN_LOG GetModel(string C_ID)
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
        public List<Mod_TB_ZG_PLAN_LOG> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Mod_TB_ZG_PLAN_LOG> DataTableToList(DataTable dt)
        {
            List<Mod_TB_ZG_PLAN_LOG> modelList = new List<Mod_TB_ZG_PLAN_LOG>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Mod_TB_ZG_PLAN_LOG model;
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
		/// 获取排产名称
		/// </summary>
		public string Get_Pc_Name()
        {
            return dal.Get_Pc_Name();
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strTime1, string strTime2)
        {
            return dal.GetList(strTime1, strTime2);
        }

        /// <summary>
        /// 查询轧钢计划
        /// </summary>
        /// <param name="P_PC_NAME">排产名称</param>
        /// <param name="P_STL_GRD">钢种</param>
        /// <param name="P_STD_CODE">执行标准</param>
        /// <returns></returns>
        public DataSet Get_Plan_List(string P_PC_NAME, string P_STL_GRD, string P_STD_CODE, string P_STA_ID)
        {
            return dal.Get_Plan_List(P_PC_NAME, P_STL_GRD, P_STD_CODE, P_STA_ID);
        }


        #endregion  BasicMethod
        #region  ExtensionMethod

        #endregion  ExtensionMethod
    }
}

