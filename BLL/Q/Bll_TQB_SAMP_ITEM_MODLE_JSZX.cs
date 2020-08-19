using System;
using System.Data;
using System.Collections.Generic;
using DAL;
using MODEL;
namespace BLL
{
    /// <summary>
    /// 取样明细模板
    /// </summary>
    public partial class Bll_TQB_SAMP_ITEM_MODLE_JSZX
    {
        private readonly Dal_TQB_SAMP_ITEM_MODLE_JSZX dal = new Dal_TQB_SAMP_ITEM_MODLE_JSZX();
        public Bll_TQB_SAMP_ITEM_MODLE_JSZX()
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
        public bool Add(Mod_TQB_SAMP_ITEM_MODLE_JSZX model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Mod_TQB_SAMP_ITEM_MODLE_JSZX model)
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
        public Mod_TQB_SAMP_ITEM_MODLE_JSZX GetModel(string C_ID)
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
        public List<Mod_TQB_SAMP_ITEM_MODLE_JSZX> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Mod_TQB_SAMP_ITEM_MODLE_JSZX> DataTableToList(DataTable dt)
        {
            List<Mod_TQB_SAMP_ITEM_MODLE_JSZX> modelList = new List<Mod_TQB_SAMP_ITEM_MODLE_JSZX>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Mod_TQB_SAMP_ITEM_MODLE_JSZX model;
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
        /// 按标准，钢种，规格查询取样模板信息
        /// </summary>
        /// <param name="P_STD_CODE">标准</param>
        /// <param name="P_STL_GRD">钢种</param>
        /// <param name="P_SPEC_MIN">规格最小值</param>
        /// <param name="P_SPEC_MAX">规格最大值</param>
        /// <returns></returns>
        public DataSet Get_Model_List(string P_STD_CODE, string P_STL_GRD, string P_SPEC_MIN, string P_SPEC_MAX)
        {
            return dal.Get_Model_List(P_STD_CODE, P_STL_GRD, P_SPEC_MIN, P_SPEC_MAX);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update_Trans(string C_SAMP_MODLE_ID)
        {
            return dal.Update_Trans(C_SAMP_MODLE_ID);
        }

        #endregion  BasicMethod
    }
}

