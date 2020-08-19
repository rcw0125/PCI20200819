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
    public partial class Bll_TRP_PLAN_ITEM
    {
        private readonly Dal_TRP_PLAN_ITEM dal = new Dal_TRP_PLAN_ITEM();
        public Bll_TRP_PLAN_ITEM()
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
        public bool Add(Mod_TRP_PLAN_ITEM model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Mod_TRP_PLAN_ITEM model)
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
        public Mod_TRP_PLAN_ITEM GetModel(string C_ID)
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
        /// 获得数据列表
        /// </summary>
        public List<Mod_TRP_PLAN_ITEM> DataTableToList(DataTable dt)
        {
            List<Mod_TRP_PLAN_ITEM> modelList = new List<Mod_TRP_PLAN_ITEM>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Mod_TRP_PLAN_ITEM model;
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
        public DataSet Get_Item_List(string c_plan_roll_id)
        {
            return dal.Get_Item_List(c_plan_roll_id);
        }

        /// <summary>
        /// 获取轧线信息
        /// </summary>
        /// <param name="C_STA_ID">工位主键</param>
        /// <returns></returns>
        public DataSet Get_ZX_List(string C_STA_ID)
        {
            return dal.Get_ZX_List(C_STA_ID);
        }

        /// <summary>
        /// 获取计划信息
        /// </summary>
        /// <param name="C_STA_ID">工位主键</param>
        /// <returns></returns>
        public DataSet Get_Plan_Item_List(string C_STA_ID)
        {
            return dal.Get_Plan_Item_List(C_STA_ID);
        }

        #endregion  BasicMethod

    }
}

