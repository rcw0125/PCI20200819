using System;
using System.Data;
using System.Collections.Generic;
using System.Collections;
using DAL;
using MODEL;
namespace BLL
{
    /// <summary>
    /// 送样信息
    /// </summary>
    public partial class Bll_TQC_PRESENT_SAMPLES
    {
        private readonly Dal_TQC_PRESENT_SAMPLES dal = new Dal_TQC_PRESENT_SAMPLES();
        public Bll_TQC_PRESENT_SAMPLES()
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
        public bool Add(Mod_TQC_PRESENT_SAMPLES model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Mod_TQC_PRESENT_SAMPLES model)
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
        public Mod_TQC_PRESENT_SAMPLES GetModel(string C_ID)
        {

            return dal.GetModel(C_ID);
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList()
        {
            return dal.GetList();
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Mod_TQC_PRESENT_SAMPLES> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList();
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Mod_TQC_PRESENT_SAMPLES> DataTableToList(DataTable dt)
        {
            List<Mod_TQC_PRESENT_SAMPLES> modelList = new List<Mod_TQC_PRESENT_SAMPLES>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Mod_TQC_PRESENT_SAMPLES model;
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
        /// 制样信息
        /// </summary>
        /// <param name="time_Start">开始时间</param>
        /// <param name="time_End">结束时间</param>
        /// <param name="strBatch">批号</param>
        /// <param name="str_PHYSICS_GROUP_ID">物理性能分组ID</param>
        /// <returns></returns>
        public DataSet GetList(string time_Start, string time_End, string strBatch, string str_PHYSICS_GROUP_ID)
        {
            return dal.GetList(time_Start, time_End, strBatch, str_PHYSICS_GROUP_ID);
        }
        /// <summary>
        /// 制样信息
        /// </summary> 
        /// <param name="strBatch">批号</param> 
        /// <returns></returns>
        public DataSet GetList_Copy(string strBatch)
        {
            return dal.GetList_Copy(strBatch);
        }
        /// <summary>
        /// 制样信息
        /// </summary> 
        /// <param name="strBatchNo">批号 </param> 
        /// <returns></returns>
        public DataSet GetList_Batch(string strBatchNo)
        {
            return dal.GetList_Batch(strBatchNo);
        }
        /// <summary>
        /// 制样信息
        /// </summary> 
        /// <param name="strBatch">批号</param> 
        /// <returns></returns>
        public DataSet GetList(string strBatch)
        {
            return dal.GetList(strBatch);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        /// <param name="strBatchNo">批号</param>
        /// <param name="strStlGrd">钢种</param>
        /// <param name="strSpec">规格</param>
        /// <param name="strTickNo">钩号</param>
        /// <param name="strState">状态</param>
        /// <returns></returns>
        public DataSet Get_List(string strBatchNo, string strStlGrd, string strSpec, string strTickNo, string strState)
        {
            return dal.Get_List(strBatchNo, strStlGrd, strSpec, strTickNo, strState);
        }

        /// <summary>
		/// 保存送样信息
		/// </summary>
		public bool SaveSamp(ArrayList SQLStringList)
        {
            return dal.SaveSamp(SQLStringList);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList_CID(string c_id)
        {
            return dal.GetList_CID(c_id);
        }
        /// <summary>
        /// 检测送样状态
        /// </summary>
        /// <param name="c_id">检测主表主键</param>
        /// <param name="strState">委托状态   1-已委托；0-未委托；2-接收送样；3-制样</param>
        /// <returns></returns>
        public int Get_JS_Count(string c_id, string strState)
        {
            return dal.Get_JS_Count(c_id, strState);
        }

        /// <summary>
        /// 获取记录总数
        /// </summary>
        /// <param name="C_BATCH_NO">批号</param>
        /// <param name="C_TICK_NO">钩号</param>
        /// <returns></returns>
        public int GetCountByBatchTichNo(string C_BATCH_NO, string C_TICK_NO)
        {
            return dal.GetCountByBatchTichNo(C_BATCH_NO, C_TICK_NO);
        }

        #endregion  BasicMethod
        #region  ExtensionMethod

        #endregion  ExtensionMethod
    }
}

