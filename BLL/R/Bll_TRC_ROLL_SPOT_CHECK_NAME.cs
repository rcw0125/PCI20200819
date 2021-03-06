﻿using System;
using System.Data;
using System.Collections.Generic;
using DAL;
using MODEL;
using System.Collections;

namespace BLL
{
    /// <summary>
    /// 抽查送样信息子表（性
    /// </summary>
    public partial class Bll_TRC_ROLL_SPOT_CHECK_NAME
    {
        private readonly Dal_TRC_ROLL_SPOT_CHECK_NAME dal = new Dal_TRC_ROLL_SPOT_CHECK_NAME();
        public Bll_TRC_ROLL_SPOT_CHECK_NAME()
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
        public bool Add(Mod_TRC_ROLL_SPOT_CHECK_NAME model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Mod_TRC_ROLL_SPOT_CHECK_NAME model)
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
        /// 获得数据列表-条件查询
        /// </summary>
        /// <param name="begin">开始时间</param>
        /// <param name="end">结束时间</param>
        /// <param name="strBatchNo">批号</param>
        /// <returns></returns>
        public DataSet GetList_CCZY(DateTime begin, DateTime end, string strBatchNo)
        {
            return dal.GetList_CCZY(begin, end, strBatchNo);
        }

        /// <summary>
        /// 获得数据列表-条件查询
        /// </summary>
        /// <param name="begin">开始时间</param>
        /// <param name="end">结束时间</param>
        /// <param name="strBatchNo">批号</param>
        /// <returns></returns>
        public DataSet GetList_ZYXX(DateTime begin, DateTime end, string strBatchNo)
        {
            return dal.GetList_ZYXX(begin, end, strBatchNo);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Mod_TRC_ROLL_SPOT_CHECK_NAME GetModel(string C_ID)
        {

            return dal.GetModel(C_ID);
        }
        /// <summary>
        /// 获得数据列表-已委托
        /// </summary>
        public DataSet Get_List_Query(string strBatchNo)
        {
            return dal.Get_List_Query(strBatchNo);
        }
        /// <summary>
        /// 获得数据列表-条件查询
        /// </summary>
        /// <param name="begin">开始时间</param>
        /// <param name="end">结束时间</param>
        /// <param name="strBatchNo">批号</param>
        /// <returns></returns>
        public DataSet GetList_CCSY(DateTime begin, DateTime end, string strBatchNo)
        {
            return dal.GetList_CCSY(begin, end, strBatchNo);
        }
        /// <summary>
        /// 获得数据列表-未委托
        /// </summary>
        public DataSet Get_List(string strBatchNo)
        {
            return dal.Get_List(strBatchNo);
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
        public List<Mod_TRC_ROLL_SPOT_CHECK_NAME> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Mod_TRC_ROLL_SPOT_CHECK_NAME> DataTableToList(DataTable dt)
        {
            List<Mod_TRC_ROLL_SPOT_CHECK_NAME> modelList = new List<Mod_TRC_ROLL_SPOT_CHECK_NAME>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Mod_TRC_ROLL_SPOT_CHECK_NAME model;
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
        /// 保存送样信息
        /// </summary>
        public bool SaveSamp(ArrayList SQLStringList)
        {
            return dal.SaveSamp(SQLStringList);
        }

        #endregion  BasicMethod
        #region  ExtensionMethod

        #endregion  ExtensionMethod
    }
}

