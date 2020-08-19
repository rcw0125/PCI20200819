using System;
using System.Data;
using System.Collections.Generic;
using DAL;
using MODEL;
namespace BLL
{
    /// <summary>
	/// 生产工位机时产能
	/// </summary>
	public partial class Bll_TPB_SLAB_CAPACITY
    {
        private readonly Dal_TPB_SLAB_CAPACITY dal = new Dal_TPB_SLAB_CAPACITY();
        public Bll_TPB_SLAB_CAPACITY()
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
        public bool Add(Mod_TPB_SLAB_CAPACITY model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Mod_TPB_SLAB_CAPACITY model)
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
        public Mod_TPB_SLAB_CAPACITY GetModel(string C_ID)
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
        public List<Mod_TPB_SLAB_CAPACITY> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Mod_TPB_SLAB_CAPACITY> DataTableToList(DataTable dt)
        {
            List<Mod_TPB_SLAB_CAPACITY> modelList = new List<Mod_TPB_SLAB_CAPACITY>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Mod_TPB_SLAB_CAPACITY model;
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
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string sta, string gl, string grd, int status, string zxbz,string type)
        {
            return dal.GetList(sta, gl, grd, status, zxbz, type);
        }

        /// <summary>
        /// 获取默认连铸机信息
        /// </summary>
        /// <param name="strGZ">钢种</param>
        /// <param name="strBZ">标准</param>
        /// <param name="strCCM">连铸</param>
        /// <param name="sfKP">是否开坯</param>
        /// <returns>订单连铸信息</returns>
        public List<Mod_TPB_SLAB_CAPACITY> GetListByCCM(string strGZ, string strBZ, string strCCM)
        {
            return DataTableToList(dal.GetListByCCM(strGZ,strBZ,strCCM));
        }

            /// <summary>
            /// 是否存在记录
            /// </summary>
            /// <param name="C_PROD_NAME"></param>
            /// <param name="C_STA_ID"></param>
            /// <param name="C_SPEC"></param>
            /// <param name="C_STL_GRD"></param>
            /// <param name="C_STD_CODE"></param>
            /// <returns></returns>
            public bool ExistsByGRD(string C_PROD_NAME, string C_STA_ID, string C_SPEC, string C_STL_GRD, string C_STD_CODE)
        {
            return dal.ExistsByGRD(C_PROD_NAME, C_STA_ID, C_SPEC, C_STL_GRD, C_STD_CODE);
        }
        /// <summary>
        /// 检验是否存在数据
        /// </summary>
        /// <param name="C_STA_ID">工位</param>
        /// <param name="C_SPEC">规格</param>
        /// <returns></returns>
        public bool Exists(string C_STA_ID, string C_SPEC)
        {
            return dal.Exists(C_STA_ID, C_SPEC);
        }

        /// <summary>
        /// 获取默认连铸机信息和机时产能
        /// </summary>
        /// <param name="strGZ">钢种</param>
        /// <param name="strBZ">标准</param>
        /// <param name="strIniID">方案主键</param>
        public DataTable GetOrderCCM(string strGZ, string strBZ, string strIniID)
        {
            return dal.GetOrderCCM(strGZ, strBZ, strIniID);
        }
        /// <summary>
        /// 获取默认连铸机信息
        /// </summary>
        /// <param name="strGZ">钢种</param>
        /// <param name="strBZ">标准</param>
        /// <param name="strCCM">连铸</param>
        /// <param name="sfKP">是否开坯</param>
        /// <returns>订单连铸信息</returns>
        public DataTable GetSteelCCM(string strGZ, string strBZ, string strCCM, string sfKP)
        {
            return dal.GetSteelCCM(strGZ, strBZ, strCCM,sfKP);
        }
        #endregion  ExtensionMethod
    }
}
