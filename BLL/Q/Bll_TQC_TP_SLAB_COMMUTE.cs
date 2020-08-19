using System;
using System.Data;
using System.Collections.Generic;
using DAL;
using MODEL;
namespace BLL
{
    /// <summary>
    /// 挑坯改判
    /// </summary>
    public partial class Bll_TQC_TP_SLAB_COMMUTE
    {
        private readonly Dal_TQC_TP_SLAB_COMMUTE dal = new Dal_TQC_TP_SLAB_COMMUTE();
        public Bll_TQC_TP_SLAB_COMMUTE()
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
        public bool Add(Mod_TQC_TP_SLAB_COMMUTE model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Mod_TQC_TP_SLAB_COMMUTE model)
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
        public Mod_TQC_TP_SLAB_COMMUTE GetModel(string C_ID)
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
        public DataSet GetList_Stove(string C_STOVE, string C_STL_GRD, string C_STD_CODE)
        {
            return dal.GetList_Stove(C_STOVE, C_STL_GRD, C_STD_CODE);
        }
        /// <summary>
        /// 挑坯改判确认查询
        /// </summary>
        /// <param name="C_STOVE">炉号</param>
        /// <param name="C_BATCH_NO">批号</param>
        /// <param name="C_STL_GRD">钢种</param>
        /// <param name="C_STD_CODE">执行标准</param>
        /// <param name="C_MAT_CODE">物料编码</param>
        /// <param name="C_ZYX1_BEFORE">自由项1</param>
        /// <param name="C_ZYX2_BEFORE">自由项2</param>
        /// <param name="C_REMARK3">仓库</param>
        /// <param name="C_MAT_CODE_AFTER">改判后物料编码</param>
        /// <param name="C_STD_CODE_AFTER">改判后执行标准</param>
        /// <param name="C_ZYX1_AFTER">改判后自由项1</param>
        /// <param name="C_ZYX2_AFTER">改判后自由项2</param>
        /// <returns></returns>
        public DataSet GetList_TPGP_COU(string C_STOVE, string C_BATCH_NO, string C_STL_GRD, string C_STD_CODE, string C_MAT_CODE, string C_ZYX1_BEFORE, string C_ZYX2_BEFORE, string C_REMARK3, string C_MAT_CODE_AFTER, string C_STD_CODE_AFTER, string C_ZYX1_AFTER, string C_ZYX2_AFTER)
        {
            return dal.GetList_TPGP_COU(C_STOVE, C_BATCH_NO, C_STL_GRD, C_STD_CODE, C_MAT_CODE, C_ZYX1_BEFORE, C_ZYX2_BEFORE, C_REMARK3, C_MAT_CODE_AFTER, C_STD_CODE_AFTER, C_ZYX1_AFTER, C_ZYX2_AFTER);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Mod_TQC_TP_SLAB_COMMUTE> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 挑坯改判记录查询
        /// </summary>
        /// <param name="begin">开始时间</param>
        /// <param name="end">结束时间</param>
        /// <param name="C_STOVE">炉号/开坯号</param>
        /// <returns></returns>
        public DataSet GetList_TP(DateTime begin, DateTime end, string C_STOVE)
        {
            return dal.GetList_TP(begin, end, C_STOVE);
        }
        /// <summary>
        /// 挑坯改判记录查询
        /// </summary>
        /// <param name="begin">开始时间</param>
        /// <param name="end">结束时间</param>
        /// <param name="C_STOVE">炉号/开坯号</param>
        /// <returns></returns>
        public DataSet GetList_TP_LG(DateTime begin, DateTime end, string C_STOVE)
        {
            return dal.GetList_TP_LG(begin, end, C_STOVE);
        }
        /// <summary>
        /// 挑坯改判记录查询
        /// </summary>
        /// <param name="begin">开始时间</param>
        /// <param name="end">结束时间</param>
        /// <param name="C_STOVE">炉号/开坯号</param>
        /// <returns></returns>
        public DataSet GetList_TP_XC(DateTime begin, DateTime end, string C_STOVE)
        {
            return dal.GetList_TP_XC(begin, end, C_STOVE);
        }
        /// <summary>
        /// 挑坯改判记录查询
        /// </summary>
        /// <param name="begin">开始时间</param>
        /// <param name="end">结束时间</param>
        /// <param name="C_STOVE">炉号/开坯号</param>
        /// <returns></returns>
        public DataSet GetList_TP_ZKB(DateTime begin, DateTime end, string C_STOVE)
        {
            return dal.GetList_TP_ZKB(begin, end, C_STOVE);
        }
        /// <summary>
        /// 挑坯改判记录查询
        /// </summary>
        /// <param name="begin">开始时间</param>
        /// <param name="end">结束时间</param>
        /// <param name="C_STOVE">炉号/开坯号</param>
        /// <returns></returns>
        public DataSet GetList_TPJL(DateTime begin, DateTime end, string C_STOVE)
        {
            return dal.GetList_TPJL(begin, end, C_STOVE);
        }
        /// <summary>
        /// 挑坯改判记录查询
        /// </summary>
        /// <param name="begin">开始时间</param>
        /// <param name="end">结束时间</param>
        /// <param name="C_STOVE">炉号/开坯号</param>
        /// <returns></returns>
        public DataSet GetList_TPGP(DateTime begin, DateTime end, string C_STOVE)
        {
            return dal.GetList_TPGP(begin, end, C_STOVE);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Mod_TQC_TP_SLAB_COMMUTE> DataTableToList(DataTable dt)
        {
            List<Mod_TQC_TP_SLAB_COMMUTE> modelList = new List<Mod_TQC_TP_SLAB_COMMUTE>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Mod_TQC_TP_SLAB_COMMUTE model;
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

