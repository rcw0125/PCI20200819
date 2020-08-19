using System;
using System.Data;
using System.Collections.Generic;
using DAL;
using MODEL;
namespace BLL
{
    /// <summary>
    /// 炼钢记号
    /// </summary>
    public partial class Bll_TPB_LGJH
    {
        private readonly Dal_TPB_LGJH dal = new Dal_TPB_LGJH();
        public Bll_TPB_LGJH()
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
        public bool Add(Mod_TPB_LGJH model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Mod_TPB_LGJH model)
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
        public Mod_TPB_LGJH GetModel(string C_ID)
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
        public List<Mod_TPB_LGJH> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Mod_TPB_LGJH> DataTableToList(DataTable dt)
        {
            List<Mod_TPB_LGJH> modelList = new List<Mod_TPB_LGJH>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Mod_TPB_LGJH model;
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



        /// <summary>
        /// 获取炼钢记号
        /// </summary>
        public DataSet Get_LGJH_Std(string C_STD_CODE, string C_STL_GRD, string V_ZL_TYPE, string V_RH_TYPE, string V_CC_TYPE)
        {
            return dal.Get_LGJH_Std(C_STD_CODE, C_STL_GRD, V_ZL_TYPE, V_RH_TYPE, V_CC_TYPE);
        }

        /// <summary>
        /// 获取炼钢记号
        /// </summary>
        public DataSet Get_LGJH_Std(string C_STD_CODE, string C_STL_GRD, string V_CC_TYPE)
        {

            return dal.Get_LGJH_Std(C_STD_CODE, C_STL_GRD, V_CC_TYPE);
        }

        /// <summary>
        /// 获取炼钢记号
        /// </summary>
        public DataSet Get_LGJH_Std(string C_STD_CODE, string C_STL_GRD, string V_ZL_TYPE, string V_LF_TYPE, string V_RH_TYPE, string V_CC_TYPE)
        {
            return dal.Get_LGJH_Std(C_STD_CODE, C_STL_GRD, V_ZL_TYPE, V_LF_TYPE, V_RH_TYPE, V_CC_TYPE);
        }

    }
}

