using System;
using System.Data;
using System.Collections.Generic;
using DAL;
using MODEL;
namespace BLL
{
    /// <summary>
    /// 物理检验项目分组维护
    /// </summary>
    public partial class Bll_TQB_PHYSICS_GROUP
    {
        private readonly Dal_TQB_PHYSICS_GROUP dal = new Dal_TQB_PHYSICS_GROUP();
        public Bll_TQB_PHYSICS_GROUP()
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
        public bool Add(Mod_TQB_PHYSICS_GROUP model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Mod_TQB_PHYSICS_GROUP model)
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
        public Mod_TQB_PHYSICS_GROUP GetModel(string C_ID)
        {

            return dal.GetModel(C_ID);
        }
        /// <summary>
        /// 获得数据列表-项目代码
        /// </summary>
        /// <param name="C_CODE">项目代码</param>
        /// <returns></returns>
		public DataSet GetList_Code(string C_CODE)
        {
            return dal.GetList_Code(C_CODE);
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
        public List<Mod_TQB_PHYSICS_GROUP> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Mod_TQB_PHYSICS_GROUP> DataTableToList(DataTable dt)
        {
            List<Mod_TQB_PHYSICS_GROUP> modelList = new List<Mod_TQB_PHYSICS_GROUP>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Mod_TQB_PHYSICS_GROUP model;
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
        /// 获得数据列表
        /// </summary>
        public DataSet Get_XN_List(string C_CHECK_DEPMT)
        {
            return dal.Get_XN_List(C_CHECK_DEPMT);
        }

        #endregion  BasicMethod
        #region  ExtensionMethod
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList_Name(string strWhere)
        {
            return dal.GetList_Name(strWhere);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList_Not_Name(string Name)
        {
            return dal.GetList_Not_Name(Name);
        }
        /// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList_Max()
        {
            return dal.GetList_Max();
        }

        /// <summary>
        /// 获取物理性能ID
        /// </summary>
        public string Get_ID(string c_code)
        {
            return dal.Get_ID(c_code);
        }

        /// <summary>
        /// 获取物理性能Code
        /// </summary>
        public string Get_Code(string c_id)
        {
            return dal.Get_Code(c_id);
        }

        /// <summary>
        /// 获取物理性能名称
        /// </summary>
        public string Get_Name(string c_code)
        {
            return dal.Get_Name(c_code);
        }

        #endregion  ExtensionMethod
    }
}

