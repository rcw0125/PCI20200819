using System;
using System.Data;
using System.Collections.Generic;
using DAL;
using MODEL;
namespace BLL
{
    public class Bll_TRC_WARM_FURNACE
    {
        private readonly Dal_TRC_WARM_FURNACE dal = new Dal_TRC_WARM_FURNACE();
        public Bll_TRC_WARM_FURNACE()
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
        public bool Add(Mod_TRC_WARM_FURNACE model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Mod_TRC_WARM_FURNACE model)
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
        /// 得到一个对象实体
        /// </summary>
        public Mod_TRC_WARM_FURNACE GetModel(string C_ID)
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
        public List<Mod_TRC_WARM_FURNACE> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Mod_TRC_WARM_FURNACE> DataTableToList(DataTable dt)
        {
            List<Mod_TRC_WARM_FURNACE> modelList = new List<Mod_TRC_WARM_FURNACE>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Mod_TRC_WARM_FURNACE model;
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
        /// 获取出炉时间
        /// </summary>
        /// <returns></returns>
        public object GetOutTime(string id)
        {
            return dal.GetOutTime(id);
        }

        /// <summary>
        /// 获取钢种信息
        /// </summary>
        public DataTable GetSlabMainInfo(string id, out DataTable consumeDt)
        {
            return dal.GetSlabMainInfo(id, out consumeDt);
        }


        /// <summary>
        /// 消耗钢坯
        /// </summary>
        /// <returns></returns>
        public bool ConsumeSlab(DataTable consumeDt)
        {
            return dal.ConsumeSlab(consumeDt);
        }
        #endregion  ExtensionMethod
    }
}
