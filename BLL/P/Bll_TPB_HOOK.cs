using System;
using System.Data;
using System.Collections.Generic;
using DAL;
using MODEL;
namespace BLL
{
    /// <summary>
    /// 钩号
    /// </summary>
    public partial class Bll_TPB_HOOK
    {
        private readonly Dal_TPB_HOOK dal = new Dal_TPB_HOOK();
        public Bll_TPB_HOOK()
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
        public bool Add(Mod_TPB_HOOK model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Mod_TPB_HOOK model)
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
        public Mod_TPB_HOOK GetModel(string C_ID)
        {

            return dal.GetModel(C_ID);
        }



        /// <summary>
        /// 获得数据列表
        /// </summary>
        /// <param name="c_batch_no">批号</param>
        /// <param name="c_sta_id">产线</param>
        /// <returns></returns>
        public DataSet GetList(string c_batch_no, string c_sta_id)
        {
            return dal.GetList(c_batch_no, c_sta_id);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        /// <param name="N_HOOK_NO">钩号</param>
        /// <param name="c_sta_id">产线</param>
        /// <returns></returns>
        public DataSet GetList_Query(string N_HOOK_NO, string c_sta_id)
        {
            return dal.GetList_Query(N_HOOK_NO, c_sta_id);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Mod_TPB_HOOK> DataTableToList(DataTable dt)
        {
            List<Mod_TPB_HOOK> modelList = new List<Mod_TPB_HOOK>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Mod_TPB_HOOK model;
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

        #endregion  ExtensionMethod
    }
}

