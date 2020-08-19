using System;
using System.Data;
using System.Collections.Generic;
using DAL;
using MODEL;
namespace BLL
{
    /// <summary>
    /// 库检申请
    /// </summary>
    public partial class Bll_TQC_RECHECK
    {
        private readonly Dal_TQC_RECHECK dal = new Dal_TQC_RECHECK();
        public Bll_TQC_RECHECK()
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
        public bool Add(Mod_TQC_RECHECK model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Mod_TQC_RECHECK model)
        {
            return dal.Update(model);
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update_CX(string C_STOVE, string C_BATCH_NO, string C_STL_GRD, string C_SPEC, string C_STD_CODE, string C_PHYSICS_CODE, string strTime)
        {
            return dal.Update_CX(C_STOVE, C_BATCH_NO, C_STL_GRD, C_SPEC, C_STD_CODE, C_PHYSICS_CODE, strTime);
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
        public Mod_TQC_RECHECK GetModel(string C_ID)
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
        /// 复检修料申请
        /// </summary>
        /// <param name="begin">开始时间</param>
        /// <param name="end">结束时间</param>
        /// <param name="C_BATCH_NO">批号</param>
        /// <returns></returns>
        public DataSet GetList_XLSQ(DateTime begin, DateTime end, string C_BATCH_NO)
        {
            return dal.GetList_XLSQ(begin, end, C_BATCH_NO);
        }
        /// <summary>
        /// 库检修料申请
        /// </summary>
        /// <param name="begin">开始时间</param>
        /// <param name="end">结束时间</param>
        /// <param name="C_BATCH_NO">批号</param>
        /// <returns></returns>
        public DataSet GetList_XCKJ(DateTime begin, DateTime end, string C_BATCH_NO)
        {
            return dal.GetList_XCKJ(begin, end, C_BATCH_NO);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Mod_TQC_RECHECK> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Mod_TQC_RECHECK> DataTableToList(DataTable dt)
        {
            List<Mod_TQC_RECHECK> modelList = new List<Mod_TQC_RECHECK>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Mod_TQC_RECHECK model;
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
        /// 分组获取数据
        /// </summary>
        /// <param name="begin">开始时间</param>
        /// <param name="end">结束时间</param>
        /// <param name="c_stove">炉号</param>
        /// <param name="c_batch_no">批号</param>
        /// <param name="num">确认状态</param>
        /// <returns></returns>
        public DataSet GetList_Query(DateTime begin, DateTime end, string c_stove, string c_batch_no, int num)
        {
            return dal.GetList_Query(begin, end, c_stove, c_batch_no, num);
        }
        /// <summary>
        /// 分组获取数据
        /// </summary>
        /// <param name="begin">开始时间</param>
        /// <param name="end">结束时间</param>
        /// <param name="c_stove">炉号</param>
        /// <param name="c_batch_no">批号</param>
        /// <param name="num">确认状态</param>
        /// <returns></returns>
        public DataSet GetList_Query_Group(DateTime begin, DateTime end, string c_stove, string c_batch_no, int num)
        {
            return dal.GetList_Query_Group(begin, end, c_stove, c_batch_no, num);
        }
        #endregion  ExtensionMethod
    }
}

