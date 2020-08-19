using System;
using System.Data;
using System.Collections.Generic;
using System.Collections;
using DAL;
using MODEL;
namespace BLL
{
    /// <summary>
    /// 送样信息子表（性能名
    /// </summary>
    public partial class Bll_TQC_PRESENT_SAMPLES_NAME
    {
        private readonly Dal_TQC_PRESENT_SAMPLES_NAME dal = new Dal_TQC_PRESENT_SAMPLES_NAME();
        public Bll_TQC_PRESENT_SAMPLES_NAME()
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
        public bool Add(Mod_TQC_PRESENT_SAMPLES_NAME model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Mod_TQC_PRESENT_SAMPLES_NAME model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(string C_PRESENT_SAMPLES_ID)
        {

            return dal.Delete(C_PRESENT_SAMPLES_ID);
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
        public Mod_TQC_PRESENT_SAMPLES_NAME GetModel(string C_ID)
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
        public DataSet GetZYXX(string strStart, string strEnd, string strBatchNo, string strType)
        {
            return dal.GetZYXX(strStart, strEnd, strBatchNo, strType);
        }

        /// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetZYXX(string strStart, string strEnd, string strBatchNo)
        {
            return dal.GetZYXX(strStart, strEnd, strBatchNo);
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Mod_TQC_PRESENT_SAMPLES_NAME> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Mod_TQC_PRESENT_SAMPLES_NAME> DataTableToList(DataTable dt)
        {
            List<Mod_TQC_PRESENT_SAMPLES_NAME> modelList = new List<Mod_TQC_PRESENT_SAMPLES_NAME>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Mod_TQC_PRESENT_SAMPLES_NAME model;
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

        /// <summary>
        /// 按时间和批号获取取样详细信息
        /// </summary>
        /// <param name="P_BATCH">批号</param>
        /// <param name="P_START">时间（开始）</param>
        /// <param name="P_END">时间（结束）</param>
        /// <param name="P_TYPE">类型,0查询委托信息，1查询已接收送样信息，2查询已制样信息</param>
        /// <returns></returns>
        public DataSet Get_List(string P_BATCH_MIN, string P_BATCH_MAX, string P_START, string P_END, string P_TYPE)
        {
            return dal.Get_List(P_BATCH_MIN, P_BATCH_MAX, P_START, P_END, P_TYPE);
        }

        /// <summary>
        /// 按时间和批号获取取样详细信息
        /// </summary>
        /// <param name="P_BATCH">批号</param>
        /// <param name="P_START">时间（开始）</param>
        /// <param name="P_END">时间（结束）</param>
        /// <param name="P_TYPE">类型,0未委托；1查询委托信息，2查询已接收送样信息，3查询已制样信息</param>
        /// <returns></returns>
        public DataSet Get_List_JSZX(string P_BATCH, string P_START, string P_END, string P_TYPE)
        {
            return dal.Get_List_JSZX(P_BATCH, P_START, P_END, P_TYPE);
        }

        /// <summary>
        /// 获取物理性能分组主键
        /// </summary>
        /// <param name="C_PRESENT_SAMPLES_ID">取样主表ID</param>
        /// <param name="c_check_depmt">检测部门</param>
        /// <returns></returns>
        public DataSet Get_PHYSICS_GROUP_ID(string C_PRESENT_SAMPLES_ID, string c_check_depmt)
        {
            return dal.Get_PHYSICS_GROUP_ID(C_PRESENT_SAMPLES_ID, c_check_depmt);
        }

        /// <summary>
        /// 获取物理性能分组主键
        /// </summary>
        /// <param name="C_PRESENT_SAMPLES_ID">取样主表ID</param>
        /// <param name="c_check_depmt">检测部门</param>
        /// <param name="C_STD_CODE">执行标准</param>
        /// <param name="C_STL_GRD">钢种</param>
        /// <returns></returns>
		public DataSet Get_PHYSICS_GROUP_ID(string C_PRESENT_SAMPLES_ID, string c_check_depmt, string C_STD_CODE, string C_STL_GRD)
        {
            return dal.Get_PHYSICS_GROUP_ID(C_PRESENT_SAMPLES_ID, c_check_depmt, C_STD_CODE, C_STL_GRD);
        }

        /// <summary>
        /// 获取物理性能分组主键(技术中心)
        /// </summary>
        /// <returns></returns>
        public string Get_GroupID()
        {
            return dal.Get_GroupID();
        }


        /// <summary>
        /// 按时间和批号获取取样详细信息
        /// </summary>
        /// <param name="P_STD_CODE">标准</param>
        /// <param name="P_STL_GRD">钢种</param>
        /// <returns></returns>
		public DataSet Get_Model_List(string P_STD_CODE, string P_STL_GRD)
        {
            return dal.Get_Model_List(P_STD_CODE, P_STL_GRD);
        }

        /// <summary>
        /// 按时间和批号获取取样详细信息
        /// </summary>
        /// <param name="P_STD_CODE">标准</param>
        /// <param name="P_STL_GRD">钢种</param>
        /// <returns></returns>
		public DataSet Get_Model_List_JSZX(string P_STD_CODE, string P_STL_GRD)
        {
            return dal.Get_Model_List_JSZX(P_STD_CODE, P_STL_GRD);
        }


        #endregion  BasicMethod
    }
}

