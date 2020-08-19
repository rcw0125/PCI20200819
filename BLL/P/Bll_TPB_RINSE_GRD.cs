using System;
using System.Data;
using System.Collections.Generic;
using DAL;
using MODEL;
namespace BLL
{
    /// <summary>
    /// 涮槽钢种
    /// </summary>
    public partial class Bll_TPB_RINSE_GRD
    {
        private readonly Dal_TPB_RINSE_GRD dal = new Dal_TPB_RINSE_GRD();
        public Bll_TPB_RINSE_GRD()
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
        public bool Add(Mod_TPB_RINSE_GRD model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Mod_TPB_RINSE_GRD model)
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
        /// 修改大于当前删除行的优先级
        /// </summary>
        /// <param name="order">优先级</param>
        /// <param name="C_PRO_CONDITION_ID">主表外键</param>
        /// <returns></returns>
        public bool Update_Order(int order, string C_PRO_CONDITION_ID)
        {
            return dal.Update_Order(order, C_PRO_CONDITION_ID);
        }
        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Mod_TPB_RINSE_GRD GetModel(string C_ID)
        {

            return dal.GetModel(C_ID);
        }
        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Mod_TPB_RINSE_GRD GetModel_GZ(string C_RINSE_GRD, string C_RINSE_STD_CODE, string C_PRO_CONDITION_ID)
        {
            return dal.GetModel_GZ(C_RINSE_GRD, C_RINSE_STD_CODE, C_PRO_CONDITION_ID);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList_Query(string strWhere)
        {
            return dal.GetList_Query(strWhere);
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            return dal.GetList(strWhere);
        }
        /// <summary>
        /// 获取优先级的最大值
        /// </summary>
        /// <param name="C_PRO_CONDITION_ID">主表外键</param>
        /// <returns></returns>
        public DataSet GetList_Max(string C_PRO_CONDITION_ID)
        {
            return dal.GetList_Max(C_PRO_CONDITION_ID);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Mod_TPB_RINSE_GRD> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Mod_TPB_RINSE_GRD> DataTableToList(DataTable dt)
        {
            List<Mod_TPB_RINSE_GRD> modelList = new List<Mod_TPB_RINSE_GRD>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Mod_TPB_RINSE_GRD model;
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

        #endregion  ExtensionMethod
    }
}

