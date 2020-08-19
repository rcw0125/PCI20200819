using System;
using System.Data;
using System.Collections.Generic;
using DAL;
using MODEL;
namespace BLL
{
    /// <summary>
    /// 钢坯订单计划
    /// </summary>
    public partial class Bll_TPC_PLAN_SMS
    {
        private readonly Dal_TPC_PLAN_SMS dal = new Dal_TPC_PLAN_SMS();
        public Bll_TPC_PLAN_SMS()
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
        public bool Add(Mod_TPC_PLAN_SMS model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Mod_TPC_PLAN_SMS model)
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
        public Mod_TPC_PLAN_SMS GetModel(string C_ID)
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
        public List<Mod_TPC_PLAN_SMS> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Mod_TPC_PLAN_SMS> DataTableToList(DataTable dt)
        {
            List<Mod_TPC_PLAN_SMS> modelList = new List<Mod_TPC_PLAN_SMS>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Mod_TPC_PLAN_SMS model;
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
        /// 查询待排炼钢计划分析
        /// </summary>
        ///  <param name="d_dtf">订单日期</param>
        ///   <param name="d_dte">订单日期</param>
        /// <param name="C_CCM_NO">连铸主键</param>
        /// <param name="C_STL_GRD">钢种</param>
        /// <param name="C_STD_CODE">执行标准</param>
        /// <returns>炼钢计划</returns>
        public DataTable GetLgPlan(string d_dtf, string d_dte, string C_CCM_NO, string C_STL_GRD, string C_STD_CODE, string C_BY4)
        {
            return dal.GetLgPlan(d_dtf, d_dte, C_CCM_NO, C_STL_GRD, C_STD_CODE, C_BY4);
        }

        /// <summary>
        /// 炼钢计划手动调整连铸
        /// </summary>
        /// <param name="C_STL_GRD">钢种</param>
        /// <param name="C_STD_CODE">执行标准</param>
        /// <param name="C_CCM_ID">连铸</param>
        /// <returns>执行结果</returns>
        public string GetCcm(string C_STL_GRD, string C_STD_CODE, string C_CCM_ID)
        {
            return dal.GetCcm(C_STL_GRD, C_STD_CODE, C_CCM_ID);

        }


        /// <summary>
        /// 生成浇次计划
        /// </summary>
        /// <returns>成功1失败0</returns>
        public string P_JCJH(DateTime P_DTFROM, DateTime P_DTEND)
        {
            return dal.P_JCJH(P_DTFROM, P_DTEND);
        }

        /// <summary>
        /// 按连铸机将计划进行排产
        /// </summary>
        /// <param name="strCcm">连铸机主键</param>
        public int DownPlanByCCM(string strCcm)
        {
            return dal.DownPlanByCCM(strCcm);
        }

        /// <summary>
        /// 查询开坯修磨计划时间
        /// </summary>
        /// <param name="stove">连铸机主键</param>
        public DataSet GetQuery()
        {
            return dal.GetQuery();
        }
        /// <summary>
        /// 查询炼钢计划
        /// </summary>
        /// <param name="C_CCM_NO">连铸主键</param>
        /// <param name="C_STL_GRD">钢种</param>
        /// <param name="C_STD_CODE">执行标准</param>
        /// <param name="N_STATUS">订单状态</param>
        /// <param name="Dtb">订单日期始</param>
        /// <param name="Dte">订单日期终</param>
        /// <returns></returns>
        public DataSet GetListByWhere(string C_CCM_NO, string C_STL_GRD, string C_STD_CODE, int N_STATUS, DateTime? Dtb, DateTime? Dte)
        {
            return dal.GetListByWhere(C_CCM_NO, C_STL_GRD, C_STD_CODE, N_STATUS, Dtb, Dte);
        }

        /// <summary>
        /// 查询炼钢计划
        /// </summary>
        /// <param name="C_CCM_NO">连铸主键</param>
        /// <param name="C_STL_GRD">钢种</param>
        /// <param name="C_STD_CODE">执行标准</param>
        /// <param name="N_STATUS">订单状态</param>
        /// <param name="Dtb">订单日期始</param>
        /// <param name="Dte">订单日期终</param>
        /// <returns></returns>
        public List<Mod_TPC_PLAN_SMS> GetModelListByWhere(string C_CCM_NO, string C_STL_GRD, string C_STD_CODE, int N_STATUS, DateTime? Dtb, DateTime? Dte)
        {
            return DataTableToList(GetListByWhere(C_CCM_NO, C_STL_GRD, C_STD_CODE, N_STATUS, Dtb, Dte).Tables[0]);
        }

        /// <summary>
        /// 将选中的计划重新分组
        /// </summary>
        /// <param name="N_GROUP">混浇组号</param>
        /// <param name="C_STL_GRD">钢种</param>
        /// <param name="C_STD_CODE">执行标准</param>
        /// <returns></returns>
        public int UpdateGroup(int N_GROUP, string C_STL_GRD, string C_STD_CODE)
        {
            return dal.UpdateGroup(N_GROUP, C_STL_GRD, C_STD_CODE);
        }

        /// <summary>
        /// 获取炼钢计划任务
        /// </summary>
        /// <returns></returns>
        public DataSet GetTaskPlan()
        {
            return dal.GetTaskPlan();
        }

        /// <summary>
        /// 获取炼钢计划任务
        /// </summary>
        /// <returns></returns>
        public DataSet GetTaskPlans()
        {
            return dal.GetTaskPlans();
        }

        #endregion  ExtensionMethod
    }
}

