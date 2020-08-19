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
	public partial class Bll_TRP_PLAN_ROLL_TEST
    {
		private readonly Dal_TRP_PLAN_ROLL_TEST dal =new Dal_TRP_PLAN_ROLL_TEST();
		public Bll_TRP_PLAN_ROLL_TEST()
		{}
        

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Mod_TRP_PLAN_ROLL_TEST> DataTableToList(DataTable dt)
        {
            List<Mod_TRP_PLAN_ROLL_TEST> modelList = new List<Mod_TRP_PLAN_ROLL_TEST>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Mod_TRP_PLAN_ROLL_TEST model;
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
        /// 更新排产计划到正式表
        /// </summary>
        /// <returns></returns>
        public string Update_Plan()
        {
            return dal.Update_Plan();
        }

        /// <summary>
        /// 保存排产历史结果记录
        /// </summary>
        /// <returns></returns>
        public string Save_Plan_Log()
        {
            return dal.Save_Plan_Log();
        }
    }
}

