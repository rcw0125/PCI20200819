using System;
using System.Data;
using System.Collections.Generic;
using DAL;
using MODEL;
namespace BLL
{
    /// <summary>
    /// 钢坯库位
    /// </summary>
    public partial class Bll_TPB_SLABWH_LOC
    {
        private readonly Dal_TPB_SLABWH_LOC dal = new Dal_TPB_SLABWH_LOC();
        public Bll_TPB_SLABWH_LOC()
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
        public bool Add(Mod_TPB_SLABWH_LOC model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Mod_TPB_SLABWH_LOC model)
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
        public Mod_TPB_SLABWH_LOC GetModel(string C_ID)
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
        public List<Mod_TPB_SLABWH_LOC> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Mod_TPB_SLABWH_LOC> DataTableToList(DataTable dt)
        {
            List<Mod_TPB_SLABWH_LOC> modelList = new List<Mod_TPB_SLABWH_LOC>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Mod_TPB_SLABWH_LOC model;
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
        /// 通过代码获取名称
        /// </summary>
        /// <param name="strAreaID"></param>
        /// <returns></returns>
        public Mod_TPB_SLABWH_LOC GetNameByCode(string Code)
        {
            return dal.GetNameByCode(Code);
        }

            /// <summary>
            /// 获得数据列表
            /// </summary>
            public DataSet GetListByArea(string strAreaID, int iStatus)
        {
            return dal.GetListByArea(strAreaID, iStatus);
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
        /// 通过库位编码获取数据
        /// </summary>
        /// <param name="strLOCCODE">库位编码</param>
        /// <param name="iStatus">状态</param>
        /// <returns></returns>
        public DataSet GetListByLOCCODE(string strLOCCODE, int iStatus)
        {
            return dal.GetListByLOCCODE(strLOCCODE, iStatus);
        }
        /// <summary>
        /// 通过库位编码获取数据
        /// </summary>
        /// <param name="strLOCCODE">库位编码</param> 
        /// <returns></returns>
        public DataSet GetList_LocCode(string strLOCCODE)
        {
            return dal.GetList_LocCode(strLOCCODE);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList_ID(string C_SLABWH_LOC_CODE, string C_SLABWH_LOC_NAME)
        {

            return dal.GetList_ID(C_SLABWH_LOC_CODE, C_SLABWH_LOC_NAME);
        }

        /// <summary>
        /// 通过区域获取数据列表
        /// </summary>
        /// <param name="c_slabwh_code">仓库编码</param> 
        /// <param name="C_SLABWH_LOC_CODE">区域编码</param>
        /// <returns></returns>
        public DataSet Get_List(string c_slabwh_code, string C_SLABWH_LOC_CODE)
        {
            return dal.Get_List(c_slabwh_code, C_SLABWH_LOC_CODE);
        }

        /// <summary>
        /// 获取记录总数
        /// </summary>
        public DataSet Get_CAP(string C_SLABWH_CODE)
        {
            return dal.Get_CAP(C_SLABWH_CODE);
        }

        /// <summary>
        /// 通过库位编码获取ID
        /// </summary>
        /// <param name="locCode">库位编码</param>
        /// <param name="iStatus">状态</param>
        /// <returns></returns>
        public string GetListByLocID(string locCode, int iStatus)
        {
            object obj = dal.GetListByLocID(locCode, iStatus);
            if (obj != null)
                return obj.ToString();
            else
                return "";
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        /// <param name="c_slabwh_code">仓库编码</param>
        /// <param name="c_slabwh_area_code">库位编码</param>
        /// <param name="C_SLABWH_TYPE">库位类型</param>
        /// <returns></returns>
        public DataSet GetList_count(string c_slabwh_code, string c_slabwh_area_code, string C_SLABWH_TYPE)
        {
            return dal.GetList_count(c_slabwh_code, c_slabwh_area_code, C_SLABWH_TYPE);
        }
        /// <summary>
        /// 通过库位编码获取数据
        /// </summary>
        /// <param name="strLOCCODE">库位编码</param> 
        /// <returns></returns>
        public DataSet GetLocByCODEL()
        {
            return dal.GetLocByCODEL();
        }
            #endregion  ExtensionMethod
        }
}

