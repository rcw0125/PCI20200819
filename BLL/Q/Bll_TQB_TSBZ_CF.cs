using System;
using System.Data;
using System.Collections.Generic;
using DAL;
using MODEL;
namespace BLL
{
    /// <summary>
    /// 铁水条件成分信息
    /// </summary>
    public partial class Bll_TQB_TSBZ_CF
    {
        private readonly Dal_TQB_TSBZ_CF dal = new Dal_TQB_TSBZ_CF();
        public Bll_TQB_TSBZ_CF()
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
        public bool Add(Mod_TQB_TSBZ_CF model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Mod_TQB_TSBZ_CF model)
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
        public Mod_TQB_TSBZ_CF GetModel(string C_ID)
        {

            return dal.GetModel(C_ID);
        }
        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Mod_TQB_TSBZ_CF GetModel_GZ(string name, decimal values, string C_PRO_CONDITION_ID)
        {
            return dal.GetModel_GZ(name, values, C_PRO_CONDITION_ID);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList_ProID(string C_PRO_CONDITION_ID)
        {
            return dal.GetList_ProID(C_PRO_CONDITION_ID);
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            return dal.GetList(strWhere);
        }

        /// <summary>
        /// 根据主表ID获得数据列表
        /// </summary>
        /// <param name="strMainID">主表ID</param>
        ///  <param name="iStatus">状态</param>
        /// <returns></returns>
        public DataSet GetListByMainID(string strMainID, int iStatus)
        {
            return dal.GetListByMainID(strMainID, iStatus);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Mod_TQB_TSBZ_CF> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 根据钢种，执行标准获取数据列表
        /// </summary>
        /// <param name="C_STD_CODE">执行标准</param>
        /// <param name="C_STL_GRD">钢种</param>
        /// <returns></returns>
        public DataSet GetList_Query(string C_STD_CODE, string C_STL_GRD)
        {
            return dal.GetList_Query(C_STD_CODE, C_STL_GRD);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Mod_TQB_TSBZ_CF> DataTableToList(DataTable dt)
        {
            List<Mod_TQB_TSBZ_CF> modelList = new List<Mod_TQB_TSBZ_CF>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Mod_TQB_TSBZ_CF model;
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

        #endregion  BasicMethod

        /// <summary>
        /// 得到已初始化订单铁水信息
        /// </summary>
        /// <param name="strIniID">方案主键</param>
        /// <param name="strGZ">钢种</param>
        /// <param name="strBZ">标准</param>
        /// <param name="strRollID">轧线</param>
        /// <param name="strCCMID">连铸</param>
        /// <param name="rolltype">轧钢是否排产</param>
        /// <param name="ccmtype">炼钢是否排产</param>
        /// <returns>铁水信息</returns>
        public DataTable GetTSCFByOrder(string strIniID, string strGZ, string strBZ, string strRollID, string strCCMID, int? rolltype, int? ccmtype)
        {

            return dal.GetTSCFByOrder(strIniID, strGZ, strBZ, strRollID, strCCMID, rolltype, ccmtype);
        }

        /// <summary>
        /// 当前炼钢排产铁水成分要求
        /// </summary>
        /// <returns></returns>
        public DataTable GetTSCFByOrder()
        {
            return dal.GetTSCFByOrder();
        }
    }
}