using System;
using System.Data;
using System.Collections.Generic;
using DAL;
using MODEL;
namespace BLL
{
	/// <summary>
	/// 连铸生产计划表
	/// </summary>
	public partial class Bll_TSP_PLAN_SMS_TEST
    {
		private readonly Dal_TSP_PLAN_SMS_TEST dal=new Dal_TSP_PLAN_SMS_TEST();
		public Bll_TSP_PLAN_SMS_TEST()
		{}


        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Mod_TSP_PLAN_SMS_TEST> DataTableToList(DataTable dt)
        {
            List<Mod_TSP_PLAN_SMS_TEST> modelList = new List<Mod_TSP_PLAN_SMS_TEST>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Mod_TSP_PLAN_SMS_TEST model;
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
    }
}

