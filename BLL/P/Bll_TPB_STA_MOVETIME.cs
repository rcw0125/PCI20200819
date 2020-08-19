using System;
using System.Data;
using System.Collections.Generic;
using DAL;
using MODEL;
namespace BLL
{
    /// <summary>
    /// 工位转移时间
    /// </summary>
    public partial class Bll_TPB_STA_MOVETIME
    {
        private readonly Dal_TPB_STA_MOVETIME dal = new Dal_TPB_STA_MOVETIME();
        public Bll_TPB_STA_MOVETIME()
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
        public bool Add(Mod_TPB_STA_MOVETIME model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Mod_TPB_STA_MOVETIME model)
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
        public Mod_TPB_STA_MOVETIME GetModel(string C_ID)
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
        public List<Mod_TPB_STA_MOVETIME> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Mod_TPB_STA_MOVETIME> DataTableToList(DataTable dt)
        {
            List<Mod_TPB_STA_MOVETIME> modelList = new List<Mod_TPB_STA_MOVETIME>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Mod_TPB_STA_MOVETIME model;
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
        /// 获取数据列表
        /// </summary>
        /// <param name="C_STA_ID1">开始工位</param>
        /// <param name="C_STA_ID2">结束工位</param>
        /// <param name="N_STATUS">状态</param>
        /// <returns></returns>
        public DataSet GetList(string C_STA_ID1, string C_STA_ID2,string N_STATUS)
        {

            return dal.GetList(C_STA_ID1,C_STA_ID2,N_STATUS);
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        /// <param name="C_STA_ID1">工位1</param>
        /// <param name="C_STA_ID2">工位2</param>
        /// <returns></returns>
        public bool Delete(string C_STA_ID1, string C_STA_ID2)
        {
            return dal.Delete(C_STA_ID1, C_STA_ID2);

        }
        /// <summary>
        /// 根据工序/工位获取工位转移时间
        /// </summary>
        /// <param name="C_PRO_ID">开始工序</param>
        /// <param name="C_STA_ID1">开始工位</param>
        /// <param name="N_STATUS">状态</param>
        /// <returns></returns>
        public DataSet GetListByGXGW(string C_PRO_ID, string C_STA_ID1, string N_STATUS)
        {
            return dal.GetListByGXGW(C_PRO_ID, C_STA_ID1,N_STATUS);
        }
            #endregion  ExtensionMethod
        }
}
