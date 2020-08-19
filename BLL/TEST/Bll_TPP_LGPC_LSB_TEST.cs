using System;
using System.Data;
using System.Collections.Generic;
using DAL;
using MODEL;
namespace BLL
{
    /// <summary>
    /// 炼钢排产临时浇次表
    /// </summary>
    public partial class Bll_TPP_LGPC_LSB_TEST
    {
        private readonly Dal_TPP_LGPC_LSB_TEST dal = new Dal_TPP_LGPC_LSB_TEST();
        public Bll_TPP_LGPC_LSB_TEST()
        { }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Mod_TPP_LGPC_LSB_TEST> DataTableToList(DataTable dt)
        {
            List<Mod_TPP_LGPC_LSB_TEST> modelList = new List<Mod_TPP_LGPC_LSB_TEST>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Mod_TPP_LGPC_LSB_TEST model;
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

