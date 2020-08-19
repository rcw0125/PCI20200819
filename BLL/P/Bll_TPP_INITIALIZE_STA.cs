using System;
using System.Data;
using System.Collections.Generic;
using DAL;
using MODEL;
namespace BLL
{
    /// <summary>
    /// 初始化排产方案生产工
    /// </summary>
    public partial class Bll_TPP_INITIALIZE_STA
    {
        private readonly Dal_TPP_INITIALIZE_STA dal = new Dal_TPP_INITIALIZE_STA();
        public Bll_TPP_INITIALIZE_STA()
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
        public bool Add(Mod_TPP_INITIALIZE_STA model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Mod_TPP_INITIALIZE_STA model)
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
        public Mod_TPP_INITIALIZE_STA GetModel(string C_ID)
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
        public List<Mod_TPP_INITIALIZE_STA> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Mod_TPP_INITIALIZE_STA> DataTableToList(DataTable dt)
        {
            List<Mod_TPP_INITIALIZE_STA> modelList = new List<Mod_TPP_INITIALIZE_STA>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Mod_TPP_INITIALIZE_STA model;
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
        /// 获取方案工位
        /// </summary>
        /// <param name="C_STA_ID">工位</param>
        /// <param name="C_INITIALIZE_ITEM_ID">方案表主键</param>
        /// <returns></returns>
        public DataSet GetList(string C_PRO_ID, string C_STA_ID, string C_INITIALIZE_ITEM_ID, string type)
        {
            return dal.GetList(C_PRO_ID, C_STA_ID, C_INITIALIZE_ITEM_ID, type);
        }
        /// <summary>
        /// 删除该方案下工位数据
        /// </summary>
        /// <param name="C_INITIALIZE_ITEM_ID">方案id</param>
        /// <returns></returns>
        public bool DeleteByItemID(string C_INITIALIZE_ITEM_ID)
        {
            return dal.DeleteByItemID(C_INITIALIZE_ITEM_ID);
        }
        /// <summary>
        /// 修改该方案下工位的数据
        /// </summary>
        /// <param name="C_INITIALIZE_ITEM_ID">方案id</param>
        /// <param name="C_STA_ID">工位id</param>
        /// <returns></returns>
        public bool UpdateBySTAFID(string C_INITIALIZE_ITEM_ID, string C_STA_ID, decimal? N_WGT)
        {
            return dal.UpdateBySTAFID(C_INITIALIZE_ITEM_ID, C_STA_ID, N_WGT);
        }

        /// <summary>
        ///获取选中方案排产工位信息
        /// </summary>
        /// <param name="C_PRO_CODE">工序代码</param>
        /// <param name="C_INITIALIZE_ITEM_ID">方案主键</param>
        /// <returns></returns>
        public DataSet GetListByFaid(string C_PRO_CODE, string C_INITIALIZE_ITEM_ID)
        {

            return dal.GetListByFaid(C_PRO_CODE, C_INITIALIZE_ITEM_ID);
        }
        /// <summary>
        /// 根据方案主键，工序代码加载未匹配炼钢路线的工位信息
        /// </summary>
        /// <param name="C_INITIALIZE_ITEM_ID">方案主键</param>
        /// <param name="C_PRO_CODE">工序代码</param>
        /// <returns></returns>
        public DataTable GetLGGXGWByIniID(string C_INITIALIZE_ITEM_ID, string C_PRO_CODE)
        {
            return dal.GetLGGXGWByIniID(C_INITIALIZE_ITEM_ID, C_PRO_CODE);
        }

        /// <summary>
        /// 获取当前方案的工序工位
        /// </summary>
        /// <param name="strIniID">方案主键</param>
        /// <param name="strGX">工序代码</param>
        /// <returns>工位列表</returns>
        public DataTable GetGXGWByIni(string strIniID, string strGX)
        {

            return dal.GetGXGWByIni(strIniID, strGX);
        }

        /// <summary>
        /// 获取当前方案的工序工位
        /// </summary>
        /// <param name="strIniID">方案主键</param>
        /// <param name="strGX">工序代码</param>
        /// <returns>工位列表</returns>
        public DataTable GetGXGWByBXG(string strIniID, string strGX)
        {

            return dal.GetGXGWByBXG(strIniID, strGX);
        }

        /// <summary>
        /// 获取工位开始时间
        /// </summary>
        /// <param name="C_STA_ID">工位主键</param>
        /// <returns></returns>
        public string Get_StartTime(string C_STA_ID)
        {
            return dal.Get_StartTime(C_STA_ID);
        }

        #endregion  ExtensionMethod
    }
}
