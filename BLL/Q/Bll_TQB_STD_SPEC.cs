using System;
using System.Data;
using System.Collections.Generic;
using DAL;
using MODEL;
namespace BLL
{
    /// <summary>
    /// 执行标准钢种规格
    /// </summary>
    public partial class Bll_TQB_STD_SPEC
    {
        private readonly Dal_TQB_STD_SPEC dal = new Dal_TQB_STD_SPEC();
        public Bll_TQB_STD_SPEC()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string C_STD_MAIN_ID, string C_SPEC)
        {
            return dal.Exists(C_STD_MAIN_ID, C_SPEC);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Mod_TQB_STD_SPEC model)
        {
            return dal.Add(model);
        }
        /// <summary>
        /// 获得所有规格
        /// </summary>
        public DataSet GetSPECList()
        {
            return dal.GetSPECList();
        }
        /// <summary>
        /// 获得所有品种
        /// </summary>
        public DataSet GetPZList()
        {
            return dal.GetPZList();
        }
        /// <summary>
        /// 获得所有品名
        /// </summary>
        public DataSet GetPMList()
        {
            return dal.GetPMList();
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Mod_TQB_STD_SPEC model)
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
        public Mod_TQB_STD_SPEC GetModel(string C_ID)
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
        public List<Mod_TQB_STD_SPEC> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Mod_TQB_STD_SPEC> DataTableToList(DataTable dt)
        {
            List<Mod_TQB_STD_SPEC> modelList = new List<Mod_TQB_STD_SPEC>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Mod_TQB_STD_SPEC model;
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
        #region  ExtensionMethod
        /// <summary>
        /// 根据执行标准获得数据列表
        /// </summary>
        public DataSet GetListBySTD(string strSTD, string staid, string stlgrd, string stdcode)
        {
            return dal.GetListBySTD(strSTD, staid, stlgrd, stdcode);
        }
        /// <summary>
        /// 根据执行标准获得规格
        /// </summary>
        public DataSet GetListBySTD(string strSTD)
        {
            return dal.GetListBySTD(strSTD);
        }

        /// <summary>
        /// 根据执行标准获得规格(钢种产线规格匹配)
        /// </summary>
        public DataSet GetListBySTDCXGG(string strSTD)
        {
            return dal.GetListBySTDCXGG(strSTD);
        }
        /// <summary>
        /// 根据执行标准获得规格(钢种产线规格匹配)
        /// </summary>
        public DataSet GetSPECListBySTA(string C_STA_ID, string C_SPEC1, string C_SPEC2)
        {
            return dal.GetSPECListBySTA(C_STA_ID, C_SPEC1, C_SPEC2);
        }
        /// <summary>
        /// 根据规格获得规格
        /// </summary>
        /// <param name="C_SPEC">规格</param>
        /// <returns></returns>
        public DataSet GetSPECListBySPEC(string C_SPEC)
        {
            return dal.GetSPECListBySPEC(C_SPEC);
        }
        #endregion  ExtensionMethod

        #region 钢种执行标准规格
        /// <summary>
        /// 查询钢种执行标准规格数据
        /// </summary>
        /// <param name="C_STL_GRD">钢种</param>
        /// <param name="C_STD_CODE">执行标准</param>
        /// <param name="C_SPEC">规格</param>
        /// <returns></returns>
        public DataTable GetGZGG(string C_STL_GRD, string C_STD_CODE, string C_SPEC)
        {
            return dal.GetGZGG(C_STL_GRD, C_STD_CODE, C_SPEC);
        }
        #endregion

    }
}

