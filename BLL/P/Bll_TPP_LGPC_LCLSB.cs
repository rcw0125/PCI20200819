using System;
using System.Data;
using System.Collections.Generic;
using DAL;
using MODEL;
namespace BLL
{
    /// <summary>
    /// 炉次计划排产临时表
    /// </summary>
    public partial class Bll_TPP_LGPC_LCLSB
    {
        private readonly Dal_TPP_LGPC_LCLSB dal = new Dal_TPP_LGPC_LCLSB();
        public Bll_TPP_LGPC_LCLSB()
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
        public bool Add(Mod_TPP_LGPC_LCLSB model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Mod_TPP_LGPC_LCLSB model)
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
        public bool DeleteByCCM(string C_CCM_NO)
        {

            return dal.DeleteByCCM(C_CCM_NO);
        }

        /// <summary>
        /// 根据浇次主键删除炉次计划
        /// </summary>
        /// <param name="C_ID">浇次计划主键</param>
        /// <returns>删除结果</returns>
        public bool DeleteByJCID(string C_ID)
        {
            return dal.DeleteByJCID(C_ID);
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
        public Mod_TPP_LGPC_LCLSB GetModel(string C_ID)
        {

            return dal.GetModel(C_ID);
        }



        /// <summary>
        /// 根据浇次、连铸查询排产的炉次计划
        /// </summary>
        /// <param name="C_FK">浇次计划主键</param>
        /// <param name="C_CCM_NO">连铸</param>
        /// <returns></returns>
        public DataSet GetList(string C_FK, string C_CCM_NO)
        {
            return dal.GetList(C_FK, C_CCM_NO);
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Mod_TPP_LGPC_LCLSB> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }

        /// <summary>
        /// 根据浇次号获取炉次计划
        /// </summary>
        /// <param name="C_FK">浇次号</param>
        /// <returns></returns>
        public List<Mod_TPP_LGPC_LCLSB> GetModelListByJcID(string C_FK)
        {
            DataSet ds = dal.GetListByJcID(C_FK);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 根据浇次号获取炉次计划
        /// </summary>
        /// <param name="C_FK">浇次号</param>
        /// <returns></returns>
        public DataSet GetList_sms_group(string C_FK)
        {
            return dal.GetList_sms_group(C_FK);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Mod_TPP_LGPC_LCLSB> GetModelList(string C_FK, string C_CCM_NO)
        {
            DataSet ds = dal.GetList(C_FK, C_CCM_NO);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Mod_TPP_LGPC_LCLSB> DataTableToList(DataTable dt)
        {
            List<Mod_TPP_LGPC_LCLSB> modelList = new List<Mod_TPP_LGPC_LCLSB>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Mod_TPP_LGPC_LCLSB model;
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




        #endregion  BasicMethod
        #region  ExtensionMethod
        /// <summary>
        /// 根据浇次临时表获取最小序号
        /// </summary>
        /// <param name="C_FK"></param>
        /// <returns></returns>
        public int MinSortBy(string C_FK)
        {
            return dal.MinSortBy(C_FK);
        }

        /// <summary>
        /// 根据浇次临时表获取最大序号
        /// </summary>
        /// <param name="C_FK"></param>
        /// <returns></returns>
        public int MaxSortBy(string C_FK)
        {
            return dal.MaxSortBy(C_FK);
        }

        /// <summary>
        /// 根据钢种标准获取能否用来调整混浇炉次的计划
        /// </summary>
        /// <param name="GZ">钢种</param>
        /// <param name="BZ">标准</param>
        /// <returns></returns>
        public Mod_TPP_LGPC_LCLSB GetChangeModel(string GZ, string BZ)
        {
            return dal.GetChangeModel(GZ, BZ);

        }
        #endregion  ExtensionMethod

        /// <summary>
        /// 获取已排产未完成的炼钢计划量
        /// </summary>
        /// <param name="C_STL_GRD">钢种</param>
        /// <param name="C_STD_CODE"></param>
        /// <param name="C_MATRL_NO"></param>
        /// <returns></returns>
        public decimal GetWWCJH(string C_STL_GRD, string C_STD_CODE, string C_MATRL_NO)
        {
            return dal.GetWWCJH(C_STL_GRD, C_STD_CODE, C_MATRL_NO);
        }

        /// <summary>
        /// 清空炉次临时表数据
        /// </summary>
        /// <returns></returns>
        public bool ClearTable(string C_CCM_ID, string C_SLAB_TYPE)
        {
            return dal.ClearTable(C_CCM_ID, C_SLAB_TYPE);
        }

        /// <summary>
        /// 根据浇次号获取分组后的炉次计划
        /// </summary>
        /// <param name="C_FK">浇次主键</param>
        /// <returns></returns>
        public DataTable GetGroupPlan(string C_FK)
        {
            return dal.GetGroupPlan(C_FK);
        }
        }
}
