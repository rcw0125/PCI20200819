using System;
using System.Data;
using System.Collections.Generic;
using DAL;
using MODEL;
namespace BLL
{
    /// <summary>
    /// 每炉重量
    /// </summary>
    public partial class Bll_TPB_CAST_STOVE_WGT
    {
        private readonly Dal_TPB_CAST_STOVE_WGT dal = new Dal_TPB_CAST_STOVE_WGT();
        public Bll_TPB_CAST_STOVE_WGT()
        { }
        #region  BasicMethod

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Mod_TPB_CAST_STOVE_WGT model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Mod_TPB_CAST_STOVE_WGT model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(string C_ID)
        {
            //该表无主键信息，请自定义主键/条件字段
            return dal.Delete(C_ID);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Mod_TPB_CAST_STOVE_WGT GetModel(string C_ID)
        {
            //该表无主键信息，请自定义主键/条件字段
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
        public List<Mod_TPB_CAST_STOVE_WGT> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Mod_TPB_CAST_STOVE_WGT> DataTableToList(DataTable dt)
        {
            List<Mod_TPB_CAST_STOVE_WGT> modelList = new List<Mod_TPB_CAST_STOVE_WGT>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Mod_TPB_CAST_STOVE_WGT model;
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



        #endregion  BasicMethod
        #region  ExtensionMethod
        /// <summary>
        /// 获取炉次重量
        /// </summary>
        /// <param name="str_CC_CODE">连铸描述</param>
        /// <param name="c_initialize_item">方案名称</param>
        /// <returns></returns>
        public double GetWGT(string str_CC_CODE, string c_initialize_item)
        {
            return dal.GetWGT(str_CC_CODE, c_initialize_item);
        }
        /// <summary>
        /// 获取每炉重量数据列表
        /// </summary>
        /// <param name="N_STATUS">状态</param>
        /// <param name="C_STA_ID">工位</param>
        /// <returns></returns>
        public DataSet GetList(int N_STATUS, string C_STA_ID)
        {
            return dal.GetList(N_STATUS,C_STA_ID);
        }
        /// <summary>
        /// 根据工位得到一个对象实体
        /// </summary>
        /// <param name="C_STA_ID">工位</param>
        /// <returns></returns>
        public Mod_TPB_CAST_STOVE_WGT GetModelBySTA(string C_STA_ID)
        {
            return dal.GetModelBySTA(C_STA_ID);
        }
            #endregion  ExtensionMethod
        }
}

