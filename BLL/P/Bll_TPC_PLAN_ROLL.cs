using System;
using System.Data;
using System.Collections.Generic;
using DAL;
using MODEL;
namespace BLL
{
    /// <summary>
    /// 线材生产计划表
    /// </summary>
    public partial class Bll_TPC_PLAN_ROLL
    {
        private readonly Dal_TPC_PLAN_ROLL dal = new Dal_TPC_PLAN_ROLL();
        public Bll_TPC_PLAN_ROLL()
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
        public bool Add(Mod_TPC_PLAN_ROLL model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Mod_TPC_PLAN_ROLL model)
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
        public Mod_TPC_PLAN_ROLL GetModel(string C_ID)
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
        public List<Mod_TPC_PLAN_ROLL> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Mod_TPC_PLAN_ROLL> DataTableToList(DataTable dt)
        {
            List<Mod_TPC_PLAN_ROLL> modelList = new List<Mod_TPC_PLAN_ROLL>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Mod_TPC_PLAN_ROLL model;
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

        /// <summary>
        /// 查询轧钢计划
        /// </summary>
        /// <param name="C_LINT_ID">产线</param>
        /// <param name="N_STATUS">是否排产</param>
        /// <param name="C_ORDER_NO">订单号</param>
        /// <param name="C_STL_GRD">钢种</param>
        /// <param name="C_STD_CODE">执行标准</param>
        /// <param name="D_SPEC_MIN">规格最小</param>
        /// <param name="D_SPEC_MAX">规格最大</param>
        /// <param name="C_CUST_NAME">客户名称</param>
        /// <param name="C_JQ_MIN">交货日期最小</param>
        /// <param name="C_JQ_MAX">交货日期最大</param>
        /// <param name="C_DD_MIN">订单日期最小</param>
        /// <param name="C_DD_MAX">订单日期最大</param>
        /// <returns>轧钢计划</returns>
        public DataSet GetZGPlan(string C_LINT_ID, int? N_STATUS, string C_ORDER_NO, string C_STL_GRD, string C_STD_CODE, double? D_SPEC_MIN, double? D_SPEC_MAX, string C_CUST_NAME, string C_JQ_MIN, string C_JQ_MAX, string C_DD_MIN, string C_DD_MAX)
        {
            return dal.GetZGPlan(C_LINT_ID, N_STATUS, C_ORDER_NO, C_STL_GRD, C_STD_CODE, D_SPEC_MIN, D_SPEC_MAX, C_CUST_NAME, C_JQ_MIN, C_JQ_MAX, C_DD_MIN, C_DD_MAX);
        }

        /// <summary>
        /// 系统对轧钢计划重新划分产线
        /// </summary>
        /// <returns></returns>
        public string GetLine()
        {

            return dal.GetLine();
        }

        /// <summary>
        /// 手动调整产线
        /// </summary>
        /// <param name="P_ID">计划主键</param>
        /// <param name="LINE_ID">产线主键</param>
        /// <returns>成功1失败0</returns>
        public string GetLineByID(string P_ID, string LINE_ID)
        {
            return dal.GetLineByID(P_ID, LINE_ID);
        }

        /// <summary>
        /// 获取轧钢计划中未维护机时产能的数据
        /// </summary>
        /// <returns></returns>
        public DataTable GetNJSCN()
        {
            return dal.GetNJSCN();
        }
        /// <summary>
        /// 维护计划轧钢机时产能
        /// </summary>
        /// <param name="P_LINT_ID">产线主键</param>
        /// <param name="P_STL_GRD">钢种</param>
        /// <param name="P_SPEC">规格</param>
        /// <param name="P_MACH_WGT">机时产能</param>
        /// <param name="P_SFGX">是否更新到机时产能基础表</param>
        /// <returns>是否成功1，0失败</returns>
        public string UpdatePlanJSCN(string P_LINT_ID, string P_STL_GRD, string P_SPEC, decimal P_MACH_WGT, string P_SFGX)
        {
            return dal.UpdatePlanJSCN(P_LINT_ID, P_STL_GRD, P_SPEC, P_MACH_WGT, P_SFGX);
        }
        #endregion  ExtensionMethod
    }
}

