using System;
using System.Data;
using System.Collections.Generic;
using DAL;
using MODEL;
namespace BLL
{
	/// <summary>
	/// 线材生产计划明细表
	/// </summary>
	public partial class Bll_TRP_PLAN_ITEM_TEST
    {
		private readonly Dal_TRP_PLAN_ITEM_TEST dal =new Dal_TRP_PLAN_ITEM_TEST();
		public Bll_TRP_PLAN_ITEM_TEST()
		{}


        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Mod_TRP_PLAN_ITEM_TEST> DataTableToList(DataTable dt)
        {
            List<Mod_TRP_PLAN_ITEM_TEST> modelList = new List<Mod_TRP_PLAN_ITEM_TEST>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Mod_TRP_PLAN_ITEM_TEST model;
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

