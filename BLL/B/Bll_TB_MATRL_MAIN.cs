using System;
using System.Data;
using System.Collections.Generic;
using DAL;
using MODEL;
namespace BLL
{
    /// <summary>
    /// 物料主数据表
    /// </summary>
    public partial class Bll_TB_MATRL_MAIN
    {
        private readonly Dal_TB_MATRL_MAIN dal = new Dal_TB_MATRL_MAIN();
        public Bll_TB_MATRL_MAIN()
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
        public bool Add(Mod_TB_MATRL_MAIN model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Mod_TB_MATRL_MAIN model)
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
        public Mod_TB_MATRL_MAIN GetModel(string C_ID)
        {

            return dal.GetModel(C_ID);
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList_DFPCD(string N_LTH)
        {
            return dal.GetList_DFPCD(N_LTH);
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList_RZPCD(string C_SLAB_SIZE)
        {
            return dal.GetList_RZPCD(C_SLAB_SIZE);
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
        public List<Mod_TB_MATRL_MAIN> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }


        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Mod_TB_MATRL_MAIN> GetListRZ(string C_STL_GRD)
        {
            DataSet ds = dal.GetListRZ(C_STL_GRD);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 预测订单钢坯产品查询
        /// </summary>
        /// <param name="matCode">物流编码</param>
        /// <param name="stlGrd">钢种</param> 
        /// <returns></returns>
        public DataSet GetGP_StlGrd(string matCode, string stlGrd, string std)
        {
            return dal.GetGP_StlGrd(matCode, stlGrd, std);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Mod_TB_MATRL_MAIN> GetListLZ(string C_STL_GRD)
        {
            DataSet ds = dal.GetListLZ(C_STL_GRD);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Mod_TB_MATRL_MAIN> DataTableToList(DataTable dt)
        {
            List<Mod_TB_MATRL_MAIN> modelList = new List<Mod_TB_MATRL_MAIN>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Mod_TB_MATRL_MAIN model;
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
        /// 获得所有钢种
        /// </summary>
        public DataSet GetGZList()
        {
            return dal.GetGZList();
        }
        /// <summary>
        /// 获取物料编码钢类
        /// </summary>
        /// <param name="c_mat_type">物料类别；材8/坯6</param>
        /// <returns></returns>
        public DataSet GetGl(int c_mat_type)
        {
            return dal.GetGl(c_mat_type);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        /// <param name="strMatCode">物料编码</param>
        /// <param name="strMatName">物料描述</param>
        /// <param name="strSTLGRD">钢种</param>
        /// <param name="strSpec">规格</param>
        /// <param name="strLen">定尺</param>
        /// <param name="C_MAT_TYPE">类别</param>
        /// <returns></returns>
        public DataSet GetListByWhere(string strMatCode, string strMatName, string strSTLGRD, string strSpec, string strLen, int C_MAT_TYPE)
        {
            return dal.GetListByWhere(strMatCode, strMatName, strSTLGRD, strSpec, strLen, C_MAT_TYPE);
        }
        /// <summary>
        /// 获取改判用物料信息
        /// </summary>
        /// <param name="c_mat_code">物料编码</param>
        /// <param name="stl">钢种</param>
        /// <param name="std">执行标准</param>
        /// <param name="slab_size">规格</param>
        /// <param name="lth">定尺</param>
        /// <returns></returns>
        public DataSet GetGP_WL(string c_mat_code, string stl, string std, string slab_size, string lth, string type)
        {
            return dal.GetGP_WL(c_mat_code, stl, std, slab_size, lth, type);
        }
        /// <summary>
        /// 获取所有物料编码信息
        /// </summary>
        /// <param name="C_MAT_CODE">物料编码</param>
        /// <param name="C_MAT_NAME">物料名称</param>
        /// <param name="C_STL_GRD">钢种</param>
        /// <param name="C_SPEC">规格</param>
        /// <returns></returns>
        public DataSet GetList_LCP(string C_MAT_CODE, string C_MAT_NAME, string C_STL_GRD, string C_SPEC)
        {
            return dal.GetList_LCP(C_MAT_CODE, C_MAT_NAME, C_STL_GRD, C_SPEC);
        }

        /// <summary>
        /// 获取所有物料编码信息
        /// </summary>
        /// <param name="C_MAT_CODE">物料编码</param>
        /// <param name="C_MAT_NAME">物料名称</param>
        /// <param name="C_STL_GRD">钢种</param>
        /// <param name="C_SPEC">规格</param>
        /// <returns></returns>
        public DataSet GetList_WL_BZ(string C_MAT_CODE, string C_MAT_NAME, string C_STL_GRD, string C_SPEC)
        {
            return dal.GetList_WL_BZ(C_MAT_CODE, C_MAT_NAME, C_STL_GRD, C_SPEC);
        }

        /// <summary>
        /// 获取物料编码钢种
        /// </summary>
        /// <param name="c_mat_type"></param>
        /// <returns></returns>
        public DataSet GetGZ(int c_mat_type, string C_PROD_NAME)
        {
            return dal.GetGZ(c_mat_type, C_PROD_NAME);
        }
        /// <summary>
        /// 获得数据列表_条件查询
        /// </summary>
        /// <param name="C_MAT_CODE">物料编码</param>
        /// <param name="C_MAT_NAME">物料描述</param>
        /// <param name="C_STL_GRD">钢种</param>
        /// <returns></returns>
        public DataSet GetList_Query(string C_MAT_CODE, string C_MAT_NAME, string C_STL_GRD, string C_SPEC, string mat_type)
        {
            return dal.GetList_Query(C_MAT_CODE, C_MAT_NAME, C_STL_GRD, C_SPEC, mat_type);
        }

        /// <summary>
        /// 根据钢种规格获取物料编码
        /// </summary>
        /// <param name="C_STL_GRD">钢种</param>
        /// <param name="C_SPEC">规格（无长度）</param>
        /// <param name="N_THK">长度（mm）</param>
        /// <param name="C_TYPE">物料状态(1外购坯6钢坯8线材)</param>
        /// <param name="LGLX">炼钢路线</param>
        /// <param name="GPTYPE">大方坯连铸坯；小方坯连铸坯；热轧钢坯</param>
        /// <returns></returns>
        public DataSet GetGPWL(string C_STL_GRD, string C_SPEC, int? N_THK, string C_TYPE, string LGLX, string GPTYPE)
        {
            return dal.GetGPWL(C_STL_GRD, C_SPEC, N_THK, C_TYPE, LGLX, GPTYPE);
        }



        /// <summary>
        /// 根据钢种规格获取物料编码
        /// </summary>
        /// <param name="C_STL_GRD">钢种</param>
        /// <param name="C_SPEC">规格（无长度）</param>
        /// <param name="N_THK">长度（mm）</param>
        /// <param name="C_TYPE">物料状态(1外购坯6钢坯8线材)</param>
        /// <param name="LGLX">炼钢路线</param>
        /// <param name="GPTYPE">大方坯连铸坯；小方坯连铸坯；热轧钢坯</param>
        /// <returns></returns>
        public List<Mod_TB_MATRL_MAIN> GetGPWLList(string C_STL_GRD, string C_SPEC, int? N_THK, string C_TYPE, string LGLX, string GPTYPE)
        {
            DataSet ds = dal.GetGPWL(C_STL_GRD, C_SPEC, N_THK, C_TYPE, LGLX, GPTYPE);
            return DataTableToList(ds.Tables[0]);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        /// <param name="C_PK_INVMANDOC">存货管理档案主键</param>
        /// <returns></returns>
        public Mod_TB_MATRL_MAIN GetMatModel(string C_PK_INVMANDOC)
        {
            return dal.GetMatModel(C_PK_INVMANDOC);
        }

        /// <summary>
        /// 获取物料编码，断面和定尺
        /// </summary>
        /// <param name="C_STL_GRD"></param>
        /// <returns></returns>
        public DataSet GetKPMatrlList(string C_STL_GRD)
        {
            return dal.GetKPMatrlList(C_STL_GRD);
        }
        #endregion  ExtensionMethod

        #region 获取排产用的钢坯物料编码



        /// <summary>
        /// 获取所有物料编码信息
        /// </summary>
        /// <param name="C_MAT_CODE">物料编码</param>
        /// <param name="C_MAT_NAME">物料名称</param>
        /// <param name="C_STL_GRD">钢种</param>
        /// <param name="C_SLAB_SIZE">断面</param>
        /// <returns></returns>
        public DataSet Get_Slab_List(string C_MAT_CODE, string C_MAT_NAME, string C_STL_GRD, string C_SLAB_SIZE)
        {
            return dal.Get_Slab_List(C_MAT_CODE, C_MAT_NAME, C_STL_GRD, C_SLAB_SIZE);
        }

        #endregion

        #region 获取热轧钢坯物料信息
        /// <summary>
        /// 获取热轧钢坯物料信息
        /// </summary>
        /// <param name="C_STL_GRD">钢种</param>
        /// <param name="C_SPEC">热轧坯规格</param>
        /// <param name="LX">工艺路线</param>
        /// <returns></returns>
        public DataTable GetKPMatral(string C_STL_GRD, string C_SPEC, string LX)
        {
            return dal.GetKPMatral(C_STL_GRD, C_SPEC, LX);
        }

        /// <summary>
        ///  获取连铸物料编码，断面和定尺
        /// </summary>
        /// <param name="C_STL_GRD">钢种</param>
        /// <param name="wllj">热轧坯工艺路线</param>
        /// <param name="dfp">是否大方坯</param>
        /// <returns></returns>
        public DataSet GetLZPMatrlList(string C_STL_GRD, string wllj, string dfp)
        {
            return dal.GetLZPMatrlList(C_STL_GRD, wllj, dfp);
        }

        /// <summary>
        ///  获取热轧坯物料编码，断面和定尺
        /// </summary>
        /// <param name="C_STL_GRD">钢种</param>
        /// <param name="wllj">热轧坯工艺路线</param>
        /// <returns></returns>
        public DataSet GetRZPMatrlList(string C_STL_GRD, string wllj)
        {
            return dal.GetRZPMatrlList(C_STL_GRD, wllj);
        }
        /// <summary>
        /// 同步物料编码
        /// </summary> 
        /// <returns></returns>
        public string JUDGE_MATRL()
        {
            return dal.JUDGE_MATRL();
        }
        /// <summary>
        /// 同步换算率
        /// </summary> 
        /// <returns></returns>
        public string JUDGE_MATRL_HSL()
        {
            return dal.JUDGE_MATRL_HSL();
        }
        #endregion

        /// <summary>
        /// 根据开坯断面和定尺查询连铸大方坯的物料信息
        /// </summary>
        /// <param name="C_STL_GRD">钢种</param>
        /// <param name="C_STD_CODE">执行标准</param>
        /// <param name="C_KP_SIZE">开坯断面</param>
        /// <param name="N_KP_LENTH">开坯定尺</param>
        /// <returns></returns>
        public DataTable GetCCMSlabByRZsLAB(string C_STL_GRD, string C_STD_CODE, string C_KP_SIZE, string N_KP_LENTH)
        {
            return dal.GetCCMSlabByRZsLAB(C_STL_GRD, C_STD_CODE, C_KP_SIZE, N_KP_LENTH);
        }

        /// <summary>
        /// 查询连铸坯物料信息(线材计划)
        /// </summary>
        /// <param name="C_STL_GRD">钢种</param>
        /// <param name="C_STD_CODE">执行标准</param>
        /// <param name="C_SLAB_SIZE">断面</param>
        /// <param name="C_ROUTE_DESC">工艺路线</param>
        /// <returns></returns>
        public DataTable GetCCMSlab(string C_STL_GRD, string C_STD_CODE, string C_ROUTE_DESC, string C_SLAB_SIZE)
        {
            return dal.GetCCMSlab(C_STL_GRD, C_STD_CODE, C_ROUTE_DESC, C_SLAB_SIZE);
        }

        /// <summary>
        /// 查询连铸坯物料信息(来料加工计划)
        /// </summary>
        /// <param name="C_STL_GRD">钢种</param>
        /// <param name="C_STD_CODE">执行标准</param>
        /// <param name="C_SLAB_SIZE">断面</param>
        ///  <param name="C_ROUTE_DESC">工艺路线</param>
        /// <returns></returns>
        public DataTable GetSlabLL(string C_STL_GRD, string C_STD_CODE, string C_ROUTE_DESC, string C_SLAB_SIZE)
        {
            return dal.GetSlabLL(C_STL_GRD, C_STD_CODE, C_ROUTE_DESC, C_SLAB_SIZE);
        }

        /// <summary>
        /// 根据连铸坯获取热轧坯钢坯信息
        /// </summary>
        /// <param name="C_STL_GRD">钢种</param>
        /// <param name="C_STD_CODE">执行标准</param>
        /// <param name="C_SLAB_SIZE">连铸坯断面</param>
        /// <param name="N_SLAB_LENTH">连铸坯定尺</param>
        /// <returns></returns>
        public DataTable GetRZSlab(string C_STL_GRD, string C_STD_CODE, string C_SLAB_SIZE, string N_SLAB_LENTH)
        {
            return dal.GetRZSlab(C_STL_GRD, C_STD_CODE, C_SLAB_SIZE, N_SLAB_LENTH);
        }
        /// <summary>
        /// 根据连铸坯获取热轧坯钢坯信息(来料加工)
        /// </summary>
        /// <param name="C_STL_GRD">钢种</param>
        /// <param name="C_STD_CODE">执行标准</param>
        /// <param name="C_SLAB_SIZE">连铸坯断面</param>
        /// <param name="N_SLAB_LENTH">连铸坯定尺</param>
        /// <returns></returns>
        public DataTable GetRZSlabLL(string C_STL_GRD, string C_STD_CODE, string C_SLAB_SIZE, string N_SLAB_LENTH)
        {
            return dal.GetRZSlabLL(C_STL_GRD, C_STD_CODE, C_SLAB_SIZE, N_SLAB_LENTH);
        }

        /// <summary>
        /// 验证物料是否可用
        /// </summary>
        /// <param name="C_MAT_CODE">物料编码</param>
        /// <returns></returns>
        public bool IsCanUse(string C_MAT_CODE)
        {

            return dal.IsCanUse(C_MAT_CODE);
        }
        /// <summary>
        /// 查询代维护钢种规格
        /// </summary>
        /// <param name="C_STL_GRD">钢种</param>
        /// <param name="C_IS_BXG">是否不锈钢</param>
        /// <returns></returns>
        public DataTable GetMatral(string C_STL_GRD, string C_IS_BXG)
        {
            return dal.GetMatral(C_STL_GRD, C_IS_BXG);
        }
        public DataTable GetWL(string C_STL_GRD, string C_SLAB_SIZE, string N_LTH)
        {
            return dal.GetWL(C_STL_GRD, C_SLAB_SIZE, N_LTH);
        }
    }
}


