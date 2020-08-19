using System;
using System.Data;
using System.Collections.Generic;
using DAL;
using MODEL;
using System.Linq;

namespace BLL
{
    /// <summary>
    /// 炼钢排产临时浇次表
    /// </summary>
    public partial class Bll_TPP_LGPC_LSB
    {
        private readonly Dal_TPP_LGPC_LSB dal = new Dal_TPP_LGPC_LSB();
        private readonly Dal_TPP_LGPC_LCLSB dal_lclsb = new Dal_TPP_LGPC_LCLSB();
        private readonly Bll_Common bll_com = new Bll_Common();
        Bll_TPP_LGPC_LCLSB bll_lc_olan_ls = new Bll_TPP_LGPC_LCLSB();
        public Bll_TPP_LGPC_LSB()
        { }
        #region  BasicMethod

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Mod_TPP_LGPC_LSB model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Mod_TPP_LGPC_LSB model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete()
        {
            return dal.Delete();
        }

        /// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(string C_ID)
        {
            return dal.Delete(C_ID);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Mod_TPP_LGPC_LSB GetModel(string C_ID)
        {
            //该表无主键信息，请自定义主键/条件字段
            return dal.GetModel(C_ID);
        }

        /// <summary>
        /// 根据分组号得到该组序号最大的排序号
        /// </summary>
        /// <param name="N_GROUP">分组号</param>
        /// <returns></returns>
        public Mod_TPP_LGPC_LSB GetModelByGroup(int N_GROUP)
        {
            return dal.GetModelByGroup(N_GROUP);
        }

        /// <summary>
        /// 根据连铸主键获取炼钢排产临时表
        /// </summary>
        /// <param name="strCCMID">连铸主键</param>
        /// <returns>炼钢排产临时表数据</returns>
        public DataSet GetList(string strCCMID)
        {
            return dal.GetList(strCCMID);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Mod_TPP_LGPC_LSB> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }


        /// <summary>
        /// 根据组号获取改组的浇次计划
        /// </summary>
        /// <param name="N_GROUP">组号</param>
        /// <param name="C_CCM_ID">连铸主键</param>
        /// <returns>浇次信息</returns>
        public List<Mod_TPP_LGPC_LSB> GetListByGroup(int N_GROUP, string C_CCM_ID)
        {
            DataSet ds = dal.GetListByGroup(N_GROUP, C_CCM_ID);
            return DataTableToList(ds.Tables[0]);
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Mod_TPP_LGPC_LSB> DataTableToList(DataTable dt)
        {
            List<Mod_TPP_LGPC_LSB> modelList = new List<Mod_TPP_LGPC_LSB>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Mod_TPP_LGPC_LSB model;
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
        /// 验证浇次排产，差值为负数时需要补浇次，差比为正数时并大于整浇次重量时需要删除已排的浇次
        /// </summary>
        /// <param name="N_GROUP">分组号</param>
        /// <returns>差比值</returns>
        public DataTable YZJC(int N_GROUP)
        {
            return dal.YZJC(N_GROUP);
        }

        /// <summary>
        /// 分组获取排产订单总重、应排炉数
        /// </summary>
        /// <param name="C_CCM_ID">连铸</param>
        /// <returns></returns>
        public DataSet GetListGroup(string C_CCM_ID)
        {
            return dal.GetListGroup(C_CCM_ID);
        }

        /// <summary>
        /// 根据组号，序号返回该浇次是当前分组的第几个浇次
        /// </summary>
        /// <param name="n_group">组号</param>
        /// <param name="n_sort">序号</param>
        /// <param name="C_CCM_ID">连铸主键</param>
        /// <returns>第几个浇次</returns>
        public DataTable GetXhByGroup(int n_group, decimal n_sort, string C_CCM_ID)
        {
            return dal.GetXhByGroup(n_group, n_sort, C_CCM_ID);
        }




        /// <summary>
        /// 重新刷新浇次顺序
        /// </summary>
        /// <param name="P_CCM_ID">连铸id</param>
        /// <returns></returns>
        public string ResetSort()
        {
            return dal.ResetSort();
        }

        ///// <summary>
        ///// 下发浇次计划
        ///// </summary>
        ///// <param name="c_id"></param>
        //public void Down_Jc_Plan(string c_id)
        //{
        //    //获取浇次计划
        //    Mod_TPP_LGPC_LSB mod_jc_ls = GetModel(c_id);
        //    Mod_TSP_CAST_PLAN mod_jc = bll_com.Mapper<Mod_TSP_CAST_PLAN, Mod_TPP_LGPC_LSB>(mod_jc_ls);

        //    List<Mod_TPP_LGPC_LCLSB> lst_lc = bll_lc_olan_ls.GetModelListByJcID(c_id);
        //    if (lst_lc.Count > 0)
        //    {
        //        for (int i = 0; i < lst_lc.Count; i++)
        //        {
        //            Mod_TSP_PLAN_SMS mod_sms = bll_com.Mapper<Mod_TSP_PLAN_SMS, Mod_TPP_LGPC_LCLSB>(lst_lc[i]);
        //            bll_plan_sms.Add(mod_sms);
        //        }
        //        bll_cast_plan.Add(mod_jc);
        //    }

        //}

        /// <summary>
        /// 清空炉次临时表数据
        /// </summary>
        /// <returns></returns>
        public bool ClearTable(string C_CCM_ID, string C_IS_BXG)
        {
            return dal.ClearTable( C_CCM_ID,  C_IS_BXG);
        }
        
        #endregion  ExtensionMethod

        /// <summary>
        /// 保存计划,TODO 事物控制
        /// </summary>
        /// <param name="LSBList"></param>
        /// <param name="LCLSBList"></param>
        public void SavePlan(List<Mod_TPP_LGPC_LSB> LSBList, List<Mod_TPP_LGPC_LCLSB> LCLSBList)
        {
            foreach (var item in LSBList.OrderBy(w => w.N_SORT).ThenBy(w => w.N_GROUP))
            {
                Mod_TPP_LGPC_LSB modpx = this.GetModel(item.C_ID);
                if (modpx != null)
                {
                    // 保存排序
                    modpx.N_SORT = item.N_SORT;
                    // 保存停机时间
                    modpx.N_PRODUCE_TIME = item.N_PRODUCE_TIME;
                    // 炉次数据
                    modpx.N_ZJCLS = item.N_ZJCLS;
                    modpx.N_ZJCLZL = item.N_ZJCLZL;
                    modpx.N_ORDER_LS = item.N_ORDER_LS;
                    this.Update(modpx);
                }
                else
                {
                    // 新增
                    this.Add(item);
                }
            }

            // 新增炉次计划
            foreach (var item in LCLSBList)
            {
                bool modpx = dal_lclsb.Exists(item.C_ID);
                if (modpx)
                {
                    dal_lclsb.Update(item);
                }
                else
                {
                    dal_lclsb.Add(item);
                }
            }
        }
    }
}

