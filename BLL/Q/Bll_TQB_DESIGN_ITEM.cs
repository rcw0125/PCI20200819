using System;
using System.Data;
using System.Collections.Generic;
using DAL;
using MODEL;
namespace BLL
{
    /// <summary>
    /// 质量设计明细
    /// </summary>
    public partial class Bll_TQB_DESIGN_ITEM
    {
        private readonly Dal_TQB_DESIGN_ITEM dal = new Dal_TQB_DESIGN_ITEM();
        public Bll_TQB_DESIGN_ITEM()
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
        public bool Add(Mod_TQB_DESIGN_ITEM model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Mod_TQB_DESIGN_ITEM model)
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
        public Mod_TQB_DESIGN_ITEM GetModel(string C_ID)
        {

            return dal.GetModel(C_ID);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Mod_TQB_DESIGN_ITEM GetModel(string c_design_no, string c_character_id)
        {
            return dal.GetModel(c_design_no, c_character_id);
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList_Query(string C_DESIGN_NO)
        {
            return dal.GetList_Query(C_DESIGN_NO);
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
        public List<Mod_TQB_DESIGN_ITEM> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList_CF(string C_DESIGN_NO)
        {
            return dal.GetList_CF(C_DESIGN_NO);
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Mod_TQB_DESIGN_ITEM> DataTableToList(DataTable dt)
        {
            List<Mod_TQB_DESIGN_ITEM> modelList = new List<Mod_TQB_DESIGN_ITEM>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Mod_TQB_DESIGN_ITEM model;
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
        /// 获取质量设计明细信息
        /// </summary>
        /// <param name="c_std_code">执行标准</param>
        /// <param name="c_stl_grd">钢种</param>
        /// <returns></returns>
        public DataSet GetList(string c_std_code, string c_stl_grd)
        {
            return dal.GetList(c_std_code, c_stl_grd);
        }

        #endregion  BasicMethod
        #region  ExtensionMethod

        #endregion  ExtensionMethod
    }
}

