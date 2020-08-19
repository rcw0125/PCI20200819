using System;
using System.Data;
using System.Collections.Generic;
using DAL;
using MODEL;
namespace BLL
{
    /// <summary>
    /// 产线规格对照表
    /// </summary>
    public partial class Bll_TPB_LINE_SPEC
    {
        private readonly Dal_TPB_LINE_SPEC dal = new Dal_TPB_LINE_SPEC();
        public Bll_TPB_LINE_SPEC()
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
        public bool Add(Mod_TPB_LINE_SPEC model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Mod_TPB_LINE_SPEC model)
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
        public Mod_TPB_LINE_SPEC GetModel(string C_ID)
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
        public List<Mod_TPB_LINE_SPEC> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Mod_TPB_LINE_SPEC> DataTableToList(DataTable dt)
        {
            List<Mod_TPB_LINE_SPEC> modelList = new List<Mod_TPB_LINE_SPEC>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Mod_TPB_LINE_SPEC model;
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
        /// 分页获取数据列表
        /// </summary>
        //public DataSet GetList(int PageSize,int PageIndex,string strWhere)
        //{
        //return dal.GetList(PageSize,PageIndex,strWhere);
        //}

        #endregion  BasicMethod
        #region  ExtensionMethod
        /// <summary>
        /// 根据规格获得产线优先级
        /// </summary>
        public DataSet GetListBySTD(string grd, string std, string spec)
        {
            return dal.GetListBySTD(grd, std, spec);
        }
        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string grd, string std, string spec)
        {
            return dal.GetRecordCount(grd, std, spec);
        }
        /// <summary>
        /// 查询
        /// </summary>
        public DataSet GetList(string C_STL_GRD, string C_STD_CODE, string C_SPEC)
        {
            return dal.GetList(C_STL_GRD, C_STD_CODE, C_SPEC);
        }
        /// <summary>
        /// 查询
        /// </summary>
        public DataSet GetSPECList(string C_STA_ID, string C_SPEC, string C_L_SPEC, string type)
        {
            return dal.GetSPECList(C_STA_ID, C_SPEC, C_L_SPEC, type);
        }
        /// <summary>
        /// 查询工位下规格
        /// </summary>
        /// <param name="C_STA_ID">工位</param>
        /// <param name="C_B_SPEC">已存在规格</param>
        /// <returns></returns>
        public DataSet GetSPECList(string C_STA_ID, string C_B_SPEC)
        {
            return dal.GetSPECList(C_STA_ID, C_B_SPEC);
        }

        /// <summary>
        /// 加载产线规格数据
        /// </summary>
        /// <param name="strGZ">钢种</param>
        /// <param name="strBZ">标准</param>
        /// <param name="strCX">产线</param>
        /// <param name="strLB">类型（轧线/开坯线）</param>
        /// <param name="strBZID">标准主键</param>
        public DataSet BindLineSpec(int status, string strGZ, string strBZ, string strCX, string strLB, string strBZID)
        {

            return dal.BindLineSpec(status, strGZ, strBZ, strCX, strLB, strBZID);
        }
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string C_STL_GRD, string C_STD_CODE, string C_STA_ID, string C_PROD_CLASS, string C_STD_MIAN_ID, string C_SPEC)
        {
            return dal.Exists(C_STL_GRD, C_STD_CODE, C_STA_ID, C_PROD_CLASS, C_STD_MIAN_ID, C_SPEC);
        }
        /// <summary>
        /// 加载产线规格数据
        /// </summary>
        /// <param name="N_STATUS">状态</param>
        /// <param name="C_STA_ID">工位</param>
        public DataSet GetSpecListBySTA(int N_STATUS, string C_STA_ID)
        {
            return dal.GetSpecListBySTA(N_STATUS, C_STA_ID);
        }

        /// <summary>
        /// 自动获取轧钢产线信息
        /// </summary>
        /// <param name="strSpec">规格</param>
        /// <param name="strIniID">方案主键</param>
        /// <param name="strGZ">钢种</param>
        /// <param name="strBZ">执行标准</param>
        /// <returns>产线信息表（单条数据 C_STA_ID /C_STA_CODE/C_STA_DESC）</returns>
        public DataTable GetLineByWhere(string strSpec, string strIniID, string strGZ, string strBZ)
        {
            return dal.GetLineByWhere(strSpec, strIniID, strGZ, strBZ);
        }
        /// <summary>
        /// 获取订单钢种生产产线信息
        /// </summary>
        /// <param name="strGZ">钢种</param>
        /// <param name="ZXBZ">执行标准</param>
        /// <param name="strSpec">规格</param>
        /// <param name="strCX">产线</param>
        /// <returns>生产信息</returns>
        public DataTable GetSteelLine(string strGZ, string ZXBZ, string strSpec, string strCX)
        {
            return dal.GetSteelLine(strGZ, ZXBZ, strSpec, strCX);

        }

        #endregion  ExtensionMethod
    }
}

