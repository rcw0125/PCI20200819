using System;
using System.Data;
using System.Collections.Generic;
using DAL;
using MODEL;
namespace BLL
{
    /// <summary>
    /// 线材库库位
    /// </summary>
    public partial class Bll_TPB_LINEWH_LOC
    {
        private readonly Dal_TPB_LINEWH_LOC dal = new Dal_TPB_LINEWH_LOC();
        public Bll_TPB_LINEWH_LOC()
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
        public bool Add(Mod_TPB_LINEWH_LOC model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Mod_TPB_LINEWH_LOC model)
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
        public Mod_TPB_LINEWH_LOC GetModel(string C_ID)
        {

            return dal.GetModel(C_ID);
        }
        /// <summary>
        /// 获得数据列表-外键
        /// </summary>
        public DataSet GetList_Query(string strWhere)
        {

            return dal.GetList_Query(strWhere);
        }


        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetListByArea(string strAreaID, int iStatus)
        {
            return dal.GetListByArea(strAreaID, iStatus);
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
        public List<Mod_TPB_LINEWH_LOC> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Mod_TPB_LINEWH_LOC> DataTableToList(DataTable dt)
        {
            List<Mod_TPB_LINEWH_LOC> modelList = new List<Mod_TPB_LINEWH_LOC>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Mod_TPB_LINEWH_LOC model;
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
        /// 获得数据列表-数量总和
        /// </summary>
        /// <param name="begin">起始库位</param>
        /// <param name="end">截止日期</param>
        /// <returns></returns>
        public int GetList_SUM(string begin, string end)
        {
            return dal.GetList_SUM(begin, end);
        }


        #endregion  BasicMethod
        #region  ExtensionMethod
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList_ID(string C_LINEWH_AREA_CODE)
        {
            return dal.GetList_ID(C_LINEWH_AREA_CODE);
        }

        /// <summary>
        /// 通过区域获取数据列表
        /// </summary>
        /// <param name="c_linewh_code">仓库编码</param> 
        /// <param name="C_LINEWH_AREA_ID">库位编码</param>
        /// <returns></returns>
        public DataSet Get_List(string c_linewh_code, string C_LINEWH_AREA_ID)
        {
            return dal.Get_List(c_linewh_code, C_LINEWH_AREA_ID);

        }
        /// <summary>
        /// 获取记录总数
        /// </summary>
        public DataSet Get_CAP(string C_LINEWH_CODE)
        {
            return dal.Get_CAP(C_LINEWH_CODE);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        /// <param name="C_LINEWH_CODE">仓库编码</param>
        /// <param name="C_LINEWH_LOC_CODE">库位编码</param>
        /// <returns></returns>
        public DataSet GetList_KW(string C_LINEWH_CODE, string C_LINEWH_LOC_CODE)
        {
            return dal.GetList_KW(C_LINEWH_CODE, C_LINEWH_LOC_CODE);
        }
 
            #endregion  ExtensionMethod
        }
}


