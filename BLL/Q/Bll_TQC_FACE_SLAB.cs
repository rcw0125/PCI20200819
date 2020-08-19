﻿using System;
using System.Data;
using System.Collections.Generic;
using DAL;
using MODEL;
namespace BLL
{
    /// <summary>
    /// 钢坯表面判定信息表
    /// </summary>
    public partial class Bll_TQC_FACE_SLAB
    {
        private readonly Dal_TQC_FACE_SLAB dal = new Dal_TQC_FACE_SLAB();
        public Bll_TQC_FACE_SLAB()
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
        public bool Add(Mod_TQC_FACE_SLAB model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Mod_TQC_FACE_SLAB model)
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
        /// 获得数据列表_炉号
        /// </summary>
        /// <param name="begin">开始时间</param>
        /// <param name="end">结束时间</param>
        /// <param name="strWhere">炉号</param>
        /// <returns></returns>
		public DataSet GetList_Stove1(DateTime begin, DateTime end, string strWhere)
        {
            return dal.GetList_Stove1(begin, end, strWhere);
        }
        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Mod_TQC_FACE_SLAB GetModel(string C_ID)
        {

            return dal.GetModel(C_ID);
        }
        /// <summary>
		/// 获得数据列表_炉号
		/// </summary>w
		public DataSet GetList_Stove(DateTime begin, DateTime end, string strWhere)
        {
            return dal.GetList_Stove(begin, end,strWhere);
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
        public List<Mod_TQC_FACE_SLAB> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Mod_TQC_FACE_SLAB> DataTableToList(DataTable dt)
        {
            List<Mod_TQC_FACE_SLAB> modelList = new List<Mod_TQC_FACE_SLAB>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Mod_TQC_FACE_SLAB model;
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
    }
}

