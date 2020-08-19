using System;
using System.Data;
using System.Collections.Generic;
using DAL;
using MODEL;
namespace BLL
{
    /// <summary>
    /// 工艺路线
    /// </summary>
    public partial class Bll_TQB_ROUTE
    {
        private readonly Dal_TQB_ROUTE dal = new Dal_TQB_ROUTE();
        public Bll_TQB_ROUTE()
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
        public bool Add(Mod_TQB_ROUTE model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Mod_TQB_ROUTE model)
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
        public Mod_TQB_ROUTE GetModel(string C_ID)
        {

            return dal.GetModel(C_ID);
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        /// <param name="RH">过真空</param>
        /// <param name="DHL">大方坯缓冷</param>
        /// <param name="KP">开坯</param>
        /// <param name="HL">缓冷</param>
        /// <param name="XM">修磨</param>
        /// <param name="str_STD">执行标准</param>
        /// <param name="stl_grd">钢种</param>
        /// <param name="C_IS_BXG">是否为不锈钢</param>
        /// <returns></returns>
        public DataSet GetList(string RH, string DHL, string KP, string HL, string XM, string str_STD, string stl_grd, string C_IS_BXG)
        {
            return dal.GetList(RH, DHL, KP, HL, XM, str_STD, stl_grd, C_IS_BXG);
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Mod_TQB_ROUTE> DataTableToList(DataTable dt)
        {
            List<Mod_TQB_ROUTE> modelList = new List<Mod_TQB_ROUTE>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Mod_TQB_ROUTE model;
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

        #endregion  BasicMethod
        #region  ExtensionMethod
        /// <summary>
        /// 获取订单工艺路线
        /// </summary>
        /// <param name="C_STL_GRD">钢种</param>
        /// <param name="C_STD_CODE">执行标准</param>
        /// <returns>工艺路线</returns>
        public DataTable GetGYLX(string C_STL_GRD, string C_STD_CODE, string C_ROUTE_TYPE)
        {
            return dal.GetGYLX(C_STL_GRD, C_STD_CODE, C_ROUTE_TYPE);
        }
        #endregion  ExtensionMethod
    }
}

