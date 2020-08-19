using System;
using System.Data;
using System.Collections.Generic;
using MODEL;
using DAL;
using System.Collections;

namespace BLL
{
    /// <summary>
    /// 物理性能结果主表
    /// </summary>
    public partial class Bll_TQC_PHYSICS_RESULT_MAIN
    {
        private readonly Dal_TQC_PHYSICS_RESULT_MAIN dal = new Dal_TQC_PHYSICS_RESULT_MAIN();
        public Bll_TQC_PHYSICS_RESULT_MAIN()
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
        public bool Add(Mod_TQC_PHYSICS_RESULT_MAIN model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Mod_TQC_PHYSICS_RESULT_MAIN model)
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
        public Mod_TQC_PHYSICS_RESULT_MAIN GetModel(string C_ID)
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
        public List<Mod_TQC_PHYSICS_RESULT_MAIN> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Mod_TQC_PHYSICS_RESULT_MAIN> DataTableToList(DataTable dt)
        {
            List<Mod_TQC_PHYSICS_RESULT_MAIN> modelList = new List<Mod_TQC_PHYSICS_RESULT_MAIN>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Mod_TQC_PHYSICS_RESULT_MAIN model;
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
        /// 检测是否已录入性能结果
        /// </summary>
        /// <param name="c_present_samples_id">取样主表主键（tqc_present_samples）</param>
        /// <param name="strState">是否已录入性能结果；0-未录入；1-已录入；</param>
        /// <returns></returns>
        public int Get_Count(string c_present_samples_id, string n_is_lr)
        {
            return dal.Get_Count(c_present_samples_id, n_is_lr);
        }

        #endregion  BasicMethod
        #region  ExtensionMethod

        #endregion  ExtensionMethod
    }
}

