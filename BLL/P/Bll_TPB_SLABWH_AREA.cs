using System;
using System.Data;
using System.Collections.Generic;
using DAL;
using MODEL;
namespace BLL
{
    /// <summary>
    /// 钢坯库区域信息
    /// </summary>
    public partial class Bll_TPB_SLABWH_AREA
    {
        private readonly Dal_TPB_SLABWH_AREA dal = new Dal_TPB_SLABWH_AREA();
        public Bll_TPB_SLABWH_AREA()
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
        /// <param name="strSlabWH">仓库主键</param>
        /// <returns></returns>
        public bool ExistsNOSotpBySlabWH(string strSlabWH)
        {
            return dal.ExistsNOSotpBySlabWH(strSlabWH);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Mod_TPB_SLABWH_AREA model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Mod_TPB_SLABWH_AREA model)
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
        public Mod_TPB_SLABWH_AREA GetModel(string C_ID)
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
        public List<Mod_TPB_SLABWH_AREA> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Mod_TPB_SLABWH_AREA> DataTableToList(DataTable dt)
        {
            List<Mod_TPB_SLABWH_AREA> modelList = new List<Mod_TPB_SLABWH_AREA>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Mod_TPB_SLABWH_AREA model;
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
        /// 获得数据列表
        /// </summary>
        public DataSet GetListBySlabWHID(string strLineWHID, int iStatus)
        {

            return dal.GetListBySlabWHID(strLineWHID, iStatus);
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
        /// 获得数据列表
        /// </summary>
        public DataSet GetListBySlabwhID(string SlabwhID)
        {
            return dal.GetListBySlabwhID(SlabwhID);
        }
        #endregion  BasicMethod
        #region  ExtensionMethod
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList_ID(string C_SLABWH_AREA_CODE, string C_SLABWH_AREA_NAME)
        {
            return dal.GetList_ID(C_SLABWH_AREA_CODE, C_SLABWH_AREA_NAME);

        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public string GetList_ID(string C_SLABWH_AREA_CODE)
        {
            object obj = dal.GetList_ID(C_SLABWH_AREA_CODE);
            if (obj != null)
                return obj.ToString();
            else
                return "";
        }

        #endregion  ExtensionMethod
    }
}

