using System;
using System.Data;
using System.Collections.Generic;
using DAL;
using MODEL;
namespace BLL
{
    /// <summary>
    /// 改判依据
    /// </summary>
    public partial class Bll_TQB_GP_LCP_BASIS
    {
        private readonly Dal_TQB_GP_LCP_BASIS dal = new Dal_TQB_GP_LCP_BASIS();
        public Bll_TQB_GP_LCP_BASIS()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string C_MAT_CODE_PLAN)
        {
            return dal.Exists(C_MAT_CODE_PLAN);
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string C_MAT_CODE_PLAN, string C_MAT_CODE_GP, string C_STL_GRD, string C_STD_CODE)
        {
            return dal.Exists(C_MAT_CODE_PLAN, C_MAT_CODE_GP, C_STL_GRD, C_STD_CODE);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Mod_TQB_GP_LCP_BASIS model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Mod_TQB_GP_LCP_BASIS model)
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
        public Mod_TQB_GP_LCP_BASIS GetModel(string C_ID)
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
        public List<Mod_TQB_GP_LCP_BASIS> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Mod_TQB_GP_LCP_BASIS> DataTableToList(DataTable dt)
        {
            List<Mod_TQB_GP_LCP_BASIS> modelList = new List<Mod_TQB_GP_LCP_BASIS>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Mod_TQB_GP_LCP_BASIS model;
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
        /// 获取联产品计划信息
        /// </summary>
        /// <param name="strGZ">钢种</param>
        /// <param name="strMatName">物料名称</param>
        /// <returns></returns>
		public DataSet GetList(string strGZ, string strMatName)
        {
            return dal.GetList(strGZ, strMatName);
        }

        /// <summary>
        /// 获取联产品改判信息
        /// </summary>
        /// <param name="C_MAT_CODE_PLAN">物料编码</param>
        /// <param name="stl">钢种</param>
        /// <param name="std">执行标准</param>
        /// <param name="C_SLAB_SIZE">规格</param>
        /// <returns></returns>
        public DataSet Get_Item_List(string C_MAT_CODE_PLAN, string stl, string std, string C_SLAB_SIZE)
        {
            return dal.Get_Item_List(C_MAT_CODE_PLAN, stl, std, C_SLAB_SIZE);
        }

        /// <summary>
        /// 获取联产品改判信息
        /// </summary>
        /// <param name="C_MAT_CODE_PLAN">物料编码</param>
        /// <returns></returns>
		public DataSet Get_Gp_List(string C_MAT_CODE_PLAN)
        {
            return dal.Get_Gp_List(C_MAT_CODE_PLAN);
        }
        /// <summary>
        /// 获取来料钢坯物料信息
        /// </summary>
        /// <param name="C_MAT_CODE_PLAN">物料编码</param>
        /// <param name="stl">钢种</param>
        /// <param name="std">执行标准</param> 
        /// <returns></returns>
        public DataSet Get_Item_List_WLGP(string C_MAT_CODE, string stl, string std)
        {
            return dal.Get_Item_List_WLGP(C_MAT_CODE, stl, std);
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update_Status(string c_mat_code_plan)
        {
            return dal.Update_Status(c_mat_code_plan);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Mod_TQB_GP_LCP_BASIS Get_Model(string C_MAT_CODE_PLAN)
        {
            return dal.Get_Model(C_MAT_CODE_PLAN);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update_Status(string c_mat_code_plan, string C_MAT_CODE_GP)
        {
            return dal.Update_Status(c_mat_code_plan, C_MAT_CODE_GP);
        }

        /// <summary>
        /// 将没有添加到联产品的物料信息添加到联产品表
        /// </summary>
        /// <returns></returns>
        public string UPDATE_LCP_CODE()
        {
            return dal.UPDATE_LCP_CODE();
        }

        #endregion  BasicMethod
        #region  ExtensionMethod

        #endregion  ExtensionMethod
    }
}

