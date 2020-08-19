using System;
using System.Data;
using System.Collections.Generic;
using DAL;
using MODEL;

namespace BLL
{
    /// <summary>
    /// 评级准则执行标准信息
    /// </summary>
    public partial class Bll_TQB_GRADE_RULE_STD
    {
        private readonly Dal_TQB_GRADE_RULE_STD dal = new Dal_TQB_GRADE_RULE_STD();
        public Bll_TQB_GRADE_RULE_STD()
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
		/// 是否存在该记录
		/// </summary>
		public bool IsExists(string C_STD_ID)
        {
            return dal.IsExists(C_STD_ID);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Mod_TQB_GRADE_RULE_STD model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Mod_TQB_GRADE_RULE_STD model)
        {
            return dal.Update(model);
        }

        /// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(string C_ID, string C_EMP_ID, DateTime dtime)
        {
            return dal.Update(C_ID, C_EMP_ID, dtime);
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
        public Mod_TQB_GRADE_RULE_STD GetModel(string C_ID)
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
        /// 获取标准列表
        /// </summary>
        /// <param name="C_STD_CODE">标准代码</param>
        /// <param name="C_STL_GRD">钢种</param>
        /// <returns></returns>
		public DataSet GetList(string C_STD_CODE, string C_STL_GRD)
        {
            return dal.GetList(C_STD_CODE, C_STL_GRD);
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Mod_TQB_GRADE_RULE_STD> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Mod_TQB_GRADE_RULE_STD> DataTableToList(DataTable dt)
        {
            List<Mod_TQB_GRADE_RULE_STD> modelList = new List<Mod_TQB_GRADE_RULE_STD>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Mod_TQB_GRADE_RULE_STD model;
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

        #endregion  BasicMethod
    }
}

