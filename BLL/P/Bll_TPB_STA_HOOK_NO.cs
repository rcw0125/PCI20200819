using System;
using System.Data;
using System.Collections.Generic;
using DAL;
using MODEL;
namespace BLL
{
    /// <summary>
    /// 产线排钩顺序表
    /// </summary>
    public partial class Bll_TPB_STA_HOOK_NO
    {
        private readonly Dal_TPB_STA_HOOK_NO dal = new Dal_TPB_STA_HOOK_NO();
        public Bll_TPB_STA_HOOK_NO()
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
        public bool Add(Mod_TPB_STA_HOOK_NO model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Mod_TPB_STA_HOOK_NO model)
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
        public Mod_TPB_STA_HOOK_NO GetModel(string C_ID)
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
        public List<Mod_TPB_STA_HOOK_NO> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Mod_TPB_STA_HOOK_NO> DataTableToList(DataTable dt)
        {
            List<Mod_TPB_STA_HOOK_NO> modelList = new List<Mod_TPB_STA_HOOK_NO>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Mod_TPB_STA_HOOK_NO model;
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
        /// 获得数据列表
        /// </summary>
        public DataSet GetListBySTA(string sta, string gh, string no)
        {
            return dal.GetListBySTA(sta, gh, no);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList_GH(string strWhere)
        {
            return dal.GetList_GH(strWhere);
        }

        /// <summary>
        /// 获取当前工位的自由钩号
        /// </summary>
        /// <param name="StrStaID">工位主键</param>
        /// <returns></returns>
        public DataTable GetFreeNO(string StrStaID)
        {

            return dal.GetFreeNO(StrStaID);
        }
            #endregion  ExtensionMethod
        }
}
