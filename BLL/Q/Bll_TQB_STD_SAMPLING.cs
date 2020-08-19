using System;
using System.Data;
using System.Collections.Generic;
using DAL;
using MODEL;
namespace BLL
{
    /// <summary>
    /// 执行标准取样信息
    /// </summary>
    public partial class Bll_TQB_STD_SAMPLING
    {
        private readonly Dal_TQB_STD_SAMPLING dal = new Dal_TQB_STD_SAMPLING();
        public Bll_TQB_STD_SAMPLING()
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
        public bool Add(Mod_TQB_STD_SAMPLING model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Mod_TQB_STD_SAMPLING model)
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
        public Mod_TQB_STD_SAMPLING GetModel(string C_ID)
        {

            return dal.GetModel(C_ID);
        }
        /// <summary>
        /// 获得数据列表-获取取样数量
        /// </summary>
        /// <param name="c_stl_grd">钢种</param>
        /// <param name="c_std_code">执行标准</param>
        /// <returns></returns>
		public DataSet GetList_Query(string c_stl_grd, string c_std_code)
        {
            return dal.GetList_Query(c_stl_grd, c_std_code);
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
        public List<Mod_TQB_STD_SAMPLING> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Mod_TQB_STD_SAMPLING> DataTableToList(DataTable dt)
        {
            List<Mod_TQB_STD_SAMPLING> modelList = new List<Mod_TQB_STD_SAMPLING>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Mod_TQB_STD_SAMPLING model;
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
        /// 获取标准取样信息（技术中心）
        /// </summary>
        /// <param name="strTime1">开始时间</param>
        /// <param name="strTime2">结束时间</param>
        /// <returns></returns>
		public DataSet GetList_JSZX(string strTime1, string strTime2)
        {
            return dal.GetList_JSZX(strTime1, strTime2);
        }

        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int Get_Count(string c_std_code, string c_stl_grd)
        {
            return dal.Get_Count(c_std_code, c_stl_grd);
        }

        #endregion  BasicMethod
        #region  ExtensionMethod

        #endregion  ExtensionMethod
    }
}

