using System;
using System.Data;
using System.Collections.Generic;
using DAL;
using MODEL;
namespace BLL
{
    /// <summary>
    /// 标准匹配表
    /// </summary>
    public partial class Bll_TB_STD_CONFIG
    {
        private readonly Dal_TB_STD_CONFIG dal = new Dal_TB_STD_CONFIG();
        public Bll_TB_STD_CONFIG()
        { }
        #region  BasicMethod

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Mod_TB_STD_CONFIG model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Mod_TB_STD_CONFIG model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(string ID)
        {

            return dal.Delete(ID);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Mod_TB_STD_CONFIG GetModel(string ID)
        {

            return dal.GetModel(ID);
        }
        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Mod_TB_STD_CONFIG GetModel_Interface(string C_STD_CODE, string C_STL_GRD)
        {
            return dal.GetModel_Interface(C_STD_CODE, C_STL_GRD);
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
        public List<Mod_TB_STD_CONFIG> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Mod_TB_STD_CONFIG> DataTableToList(DataTable dt)
        {
            List<Mod_TB_STD_CONFIG> modelList = new List<Mod_TB_STD_CONFIG>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Mod_TB_STD_CONFIG model;
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
        /// <summary>
        /// 获取自由项列表
        /// </summary>
        /// <param name="strgz">钢种</param>
        /// <param name="iType">1：自由项1，2：自由项2</param>
        /// <returns></returns>
        public DataSet GetZYX(string strgz, int iType)
        {
            return dal.GetZYX(strgz, iType);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string grd, string xy, string zxbz, string lgjh)
        {
            return dal.GetList(grd, xy, zxbz, lgjh);
        }

        /// <summary>
        /// 通过钢种执行标准获取自由项
        /// </summary>
        /// <param name="grd"></param>
        /// <param name="std"></param>
        /// <returns></returns>
        public DataSet GetZYX(string grd, string std)
        {
            return dal.GetZYX(grd, std);
        }
        #endregion  ExtensionMethod
    }
}
