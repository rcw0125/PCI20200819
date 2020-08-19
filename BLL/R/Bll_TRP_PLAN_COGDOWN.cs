using DAL;
using MODEL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace BLL
{
    public partial class Bll_TRP_PLAN_COGDOWN
    {
        private readonly Dal_TRP_PLAN_COGDOWN dal = new Dal_TRP_PLAN_COGDOWN();
        public Bll_TRP_PLAN_COGDOWN()
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
        public bool Add(Mod_TRP_PLAN_COGDOWN model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Mod_TRP_PLAN_COGDOWN model)
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
        public Mod_TRP_PLAN_COGDOWN GetModel(string C_ID)
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
        public List<Mod_TRP_PLAN_COGDOWN> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Mod_TRP_PLAN_COGDOWN> DataTableToList(DataTable dt)
        {
            List<Mod_TRP_PLAN_COGDOWN> modelList = new List<Mod_TRP_PLAN_COGDOWN>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Mod_TRP_PLAN_COGDOWN model;
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
        /// 分页获取数据列表
        /// </summary>
        //public DataSet GetList(int PageSize,int PageIndex,string strWhere)
        //{
        //return dal.GetList(PageSize,PageIndex,strWhere);
        //}

        #endregion  BasicMethod
        #region  ExtensionMethod
        /// <summary>
        /// 查询下发的开坯计划
        /// </summary>
        /// <param name="C_STA_ID">开坯工位主键</param>
        /// <param name="N_STATUS">状态</param>
        /// <param name="flag">是否组坯</param>
        /// <returns>开坯计划</returns>
        public DataSet GetList(string C_STA_ID, int N_STATUS, bool flag)
        {

            return dal.GetList(C_STA_ID, N_STATUS, flag);
        }

        /// <summary>
        /// 查询下发的开坯计划
        /// </summary>
        /// <param name="C_STA_ID">开坯工位主键</param>
        /// <param name="N_STATUS">状态</param>
        /// <param name="flag">是否组坯</param>
        /// <param name="strStove">炉号</param>
        /// <returns>开坯计划</returns>
        public DataSet GetList(string C_STA_ID, int N_STATUS, bool flag, string strStove, string C_STL_GRD, string C_STD_CODE)
        {

            return dal.GetList(C_STA_ID, N_STATUS, flag, strStove, C_STL_GRD, C_STD_CODE);
        }

        /// <summary>
        /// 查询下发的开坯计划
        /// </summary>
        /// <param name="C_STA_ID">开坯工位主键</param>
        /// <param name="N_STATUS">状态</param>
        /// <param name="flag">是否组坯</param>
        /// <returns>开坯计划</returns>
        public List<Mod_TRP_PLAN_COGDOWN> GetModList(string C_STA_ID, int N_STATUS, bool flag)
        {
            return DataTableToList(dal.GetList(C_STA_ID, N_STATUS, flag).Tables[0]);
        }


        /// <summary>
        /// 获取生产顺序
        /// </summary>
        public int Get_Max_Sort()
        {
            return dal.Get_Max_Sort();
        }

        #endregion  ExtensionMethod
    }
}
