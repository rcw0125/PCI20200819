using System;
using System.Data;
using System.Collections.Generic;
using DAL;
using MODEL;
namespace BLL
{
    /// <summary>
    /// 钢坯分类表
    /// </summary>
    public partial class Bll_TB_SLAB_MATRAL
    {
        private readonly Dal_TB_SLAB_MATRAL dal = new Dal_TB_SLAB_MATRAL();
        public Bll_TB_SLAB_MATRAL()
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
        public bool Add(Mod_TB_SLAB_MATRAL model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Mod_TB_SLAB_MATRAL model)
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
        public Mod_TB_SLAB_MATRAL GetModel(string C_ID)
        {

            return dal.GetModel(C_ID);
        }



        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string C_STL_GRD, string C_STD_CODE, string C_ROUTE_DESC)
        {
            return dal.GetList(C_STL_GRD, C_STD_CODE,   C_ROUTE_DESC);
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Mod_TB_SLAB_MATRAL> DataTableToList(DataTable dt)
        {
            List<Mod_TB_SLAB_MATRAL> modelList = new List<Mod_TB_SLAB_MATRAL>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Mod_TB_SLAB_MATRAL model;
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
        ///// <summary>
        ///// 获取钢坯物料信息
        ///// </summary>
        ///// <param name="C_STL_GRD">钢种</param>
        ///// <param name="C_STD_CODE">执行标准</param>
        ///// <param name="C_TYPE">钢坯类型611、612小方坯连铸坯613大方坯连铸坯614热轧钢坯</param>
        ///// <param name="C_SLAB_SIZE">连铸坯断面</param>
        ///// <param name="C_KP_SIZE">热轧坯断面</param>
        ///// <returns>物料信息</returns>
        //public DataTable GetSlabMatral(string C_STL_GRD, string C_STD_CODE, string C_TYPE, string C_SLAB_SIZE, int? N_SLAB_LEN, string C_KP_SIZE, int? N_KP_LEN)
        //{
        //    return dal.GetSlabMatral(C_STL_GRD, C_STD_CODE, C_TYPE, C_SLAB_SIZE, N_SLAB_LEN, C_KP_SIZE, N_KP_LEN);
        //}

        /// <summary>
        /// 根据钢种执行标准获取连铸坯物料信息
        /// </summary>
        /// <param name="C_STL_GRD">钢种</param>
        /// <param name="C_STD_CODE">执行标准</param>
        /// <param name="C_CCM_ID">连铸机主键，6#连铸机断面为150*150，其他铸机默认为160*160或280*325</param>
        public DataTable GetCCMSlabMatral(string C_STL_GRD, string C_STD_CODE, string C_CCM_ID)
        {
            return dal.GetCCMSlabMatral(C_STL_GRD, C_STD_CODE, C_CCM_ID);
        }
        #endregion  ExtensionMethod

        /// <summary>
        /// 获取物料编码列表
        /// </summary>
        /// <param name="C_STL_GRD">钢种</param>
        /// <param name="C_STD_CODE">执行标准</param>
        /// <returns></returns>
        public DataSet Get_MatCode_List(string C_STL_GRD, string C_STD_CODE)
        {
            return dal.Get_MatCode_List(C_STL_GRD, C_STD_CODE);
        }
    }
}

