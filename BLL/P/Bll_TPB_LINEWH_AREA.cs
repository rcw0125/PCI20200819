using System;
using System.Data;
using System.Collections.Generic;
using DAL;
using MODEL;
namespace BLL
{
    /// <summary>
    /// 线材库区域
    /// </summary>
    public partial class Bll_TPB_LINEWH_AREA
    {
        private readonly Dal_TPB_LINEWH_AREA dal = new Dal_TPB_LINEWH_AREA();
        public Bll_TPB_LINEWH_AREA()
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
        /// 查询某仓库是否存在未停用的区域信息
        /// </summary>
        /// <param name="strLineWH">仓库主键</param>
        /// <returns></returns>
        public bool ExistsNOSotpByLineWH(string strLineWH)
        {
            return dal.ExistsNOSotpByLineWH(strLineWH);

        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Mod_TPB_LINEWH_AREA model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Mod_TPB_LINEWH_AREA model)
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
        public Mod_TPB_LINEWH_AREA GetModel(string C_ID)
        {

            return dal.GetModel(C_ID);
        }
        /// <summary>
        /// 根据仓库代码获取区域
        /// </summary>
        /// <param name="C_LINEWH_CODE">仓库代码</param>
        /// <returns></returns>
        public DataSet GetList_ID(string C_LINEWH_CODE)
        {
            return dal.GetList_ID(C_LINEWH_CODE);
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
        public DataSet GetList(string strWhere)
        {
            return dal.GetList(strWhere);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Mod_TPB_LINEWH_AREA> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Mod_TPB_LINEWH_AREA> DataTableToList(DataTable dt)
        {
            List<Mod_TPB_LINEWH_AREA> modelList = new List<Mod_TPB_LINEWH_AREA>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Mod_TPB_LINEWH_AREA model;
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
		///根据线材库ID获取区域信息列表
		/// </summary>
		public DataSet GetListByLineWHID(string strLineWHID, int iStatus)
        {

            return dal.GetListByLineWHID(strLineWHID, iStatus);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        /// <param name="C_LINEWH_AREA_CODE">仓库编码</param>
        /// <param name="C_LINEWH_AREA_NAME">仓库描述</param>
        /// <returns></returns>
        public DataSet GetList_linewh_id(string C_LINEWH_AREA_CODE, string C_LINEWH_AREA_NAME)
        {
            return dal.GetList_linewh_id(C_LINEWH_AREA_CODE, C_LINEWH_AREA_NAME);
        }


        #endregion  BasicMethod
    }
}

