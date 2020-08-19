using System;
using System.Data;
using System.Collections.Generic;
using DAL;
using MODEL;
namespace BLL
{
    /// <summary>
    /// 钢种生成条件主表
    /// </summary>
    public partial class Bll_TPB_STEEL_PRO_CONDITION
    {
        private readonly Dal_TPB_STEEL_PRO_CONDITION dal = new Dal_TPB_STEEL_PRO_CONDITION();
        public Bll_TPB_STEEL_PRO_CONDITION()
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
        public bool Add(Mod_TPB_STEEL_PRO_CONDITION model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Mod_TPB_STEEL_PRO_CONDITION model)
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
        public Mod_TPB_STEEL_PRO_CONDITION GetModel(string C_ID)
        {

            return dal.GetModel(C_ID);
        }
        /// <summary>
        /// 获得数据列表_条件模糊查询
        /// </summary>
        /// <param name="C_STL_GRD">钢种</param>
        /// <param name="C_STD_CODE">执行标准</param>
        /// <param name="C_IS_BXG">是否为不锈钢</param>
        /// <returns></returns>
        public DataSet GetList_Query(string C_IS_BXG, string C_STL_GRD, string C_STD_CODE)
        {
            return dal.GetList_Query(C_IS_BXG, C_STL_GRD, C_STD_CODE);
        }
        /// <summary>
        /// 获得数据列表_条件模糊查询
        /// </summary>
        /// <param name="C_STL_GRD">钢种</param>
        /// <param name="C_STD_CODE">执行标准</param>
        /// <param name="C_IS_BXG">是否为不锈钢</param>
        /// <returns></returns>
        public DataSet GetList_GZSCTJ(string C_IS_BXG, string C_STL_GRD, string C_STD_CODE)
        {
            return dal.GetList_GZSCTJ(C_IS_BXG, C_STL_GRD, C_STD_CODE);
        }
        /// <summary>
        /// 根据计划钢种和标准获取对象实体
        /// </summary>
        /// <param name="C_STL_GRD">计划钢种</param>
        /// <param name="C_STD_CODE">计划标准</param>
        /// <returns></returns>
        public Mod_TPB_STEEL_PRO_CONDITION GetModel(string C_STL_GRD, string C_STD_CODE)
        {
            return dal.GetModel(C_STL_GRD, C_STD_CODE);
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
        public List<Mod_TPB_STEEL_PRO_CONDITION> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Mod_TPB_STEEL_PRO_CONDITION> DataTableToList(DataTable dt)
        {
            List<Mod_TPB_STEEL_PRO_CONDITION> modelList = new List<Mod_TPB_STEEL_PRO_CONDITION>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Mod_TPB_STEEL_PRO_CONDITION model;
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
        /// 判断钢种是否可以混浇
        /// </summary>
        /// <param name="c_stl_grd">原钢种</param>
        /// <param name="c_std_code">原执行标准</param>
        /// <param name="c_border_stl_grd">混浇钢种</param>
        /// <param name="c_border_std_code">混浇执行标准</param>
        /// <returns></returns>
        public int GetRecordCount(string c_stl_grd, string c_std_code, string c_border_stl_grd, string c_border_std_code)
        {
            return dal.GetRecordCount(c_stl_grd, c_std_code, c_border_stl_grd, c_border_std_code);
        }


        #endregion  BasicMethod


        #region 验证钢种生产条件并获取钢种大类
        /// <summary>
        /// 匹配钢种生产条件是否维护
        /// </summary>
        /// <param name="C_STL_GRD">钢种</param>
        /// <param name="C_STD_CODE">执行标准</param>
        /// <returns>返回查询结果</returns>
        public DataTable GetSCTJ(string C_STL_GRD, string C_STD_CODE)
        {
            return dal.GetSCTJ(C_STL_GRD, C_STD_CODE);
        }
        #endregion

        /// <summary>
        /// 修改混浇组号
        /// </summary>
        /// <param name="C_STL_GRD">钢种</param>
        /// <param name="C_STD_CODE"></param>
        /// <param name="N_GROUP"></param>
        /// <returns></returns>
        public bool UpdateGZ(string C_STL_GRD, string C_STD_CODE, int N_GROUP)
        {
            return dal.UpdateGZ(C_STL_GRD, C_STD_CODE, N_GROUP);

        }
        /// <summary>
        /// 根据钢种执行标准分组查询数据
        /// </summary>
        /// <param name="grd"></param>
        /// <param name="std"></param>
        /// <param name="group"></param>
        /// <returns></returns>
        public DataSet GetList(string grd, string std, string group)
        {
            return dal.GetList(grd, std, group);
        }
        /// <summary>
        /// 根据分组号查询数据
        /// </summary>
        /// <param name="group"></param>
        /// <returns></returns>
        public DataSet GetListbyGP(string group)
        {
            return dal.GetListbyGP(group);
        }
        /// <summary>
        /// 变更可混浇
        /// </summary>
        /// <param name="group"></param>
        /// <returns></returns>
        public void UPKHJ(string grd, string std, string group)
        {
            dal.UPKHJ(grd, std, group);
        }

        /// <summary>
        /// 验证可相邻生产
        /// </summary>
        /// <param name="C_STL_GRD1">上炉钢种</param>
        /// <param name="C_STD_CODE1">上炉标准</param>
        /// <param name="C_STL_GRD">本炉钢种</param>
        /// <param name="C_STD_CODE">本炉计划</param>
        /// <returns></returns>
        public DataTable GetBroder(string C_STL_GRD1, string C_STD_CODE1, string C_STL_GRD, string C_STD_CODE)
        {
            return dal.GetBroder(C_STL_GRD1,  C_STD_CODE1,  C_STL_GRD,  C_STD_CODE);
        }
        }
}

