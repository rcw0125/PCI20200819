using System;
using System.Data;
using System.Collections.Generic;
using DAL;
using MODEL;
namespace BLL
{
    /// <summary>
    /// 线材生产计划表
    /// </summary>
    public partial class Bll_TRP_PLAN_ROLL
    {
        private readonly Dal_TRP_PLAN_ROLL dal = new Dal_TRP_PLAN_ROLL();
        public Bll_TRP_PLAN_ROLL()
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
        public bool Add(Mod_TRP_PLAN_ROLL model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Mod_TRP_PLAN_ROLL model)
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
        public Mod_TRP_PLAN_ROLL GetModel(string C_ID)
        {

            return dal.GetModel(C_ID);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Mod_TRP_PLAN_ROLL GetModelByOrderNo(string C_ORDER_NO)
        {

            return dal.GetModelByOrderNo(C_ORDER_NO);
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            return dal.GetList(strWhere);
        }

        /// <summary>
        /// 根据分组号和连铸主键获取可混交的钢坯信息
        /// </summary>
        /// <param name="N_GROUP">组号</param>
        /// <param name="C_CCM_ID">连铸主键</param>
        /// <returns></returns>
        public DataTable GetListByGroup(int N_GROUP, string C_CCM_ID)
        {
            return dal.GetListByGroup(N_GROUP, C_CCM_ID).Tables[0];
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Mod_TRP_PLAN_ROLL> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetListTrp(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Mod_TRP_PLAN_ROLL> DataTableToList(DataTable dt)
        {
            List<Mod_TRP_PLAN_ROLL> modelList = new List<Mod_TRP_PLAN_ROLL>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Mod_TRP_PLAN_ROLL model;
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

        public Mod_TRP_PLAN_ROLL DataRowToModel(DataRow dr)
        {
            return dal.DataRowToModel(dr);
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
        /// 获取方案记录总数
        /// </summary>
        public int GetFACount(string C_INITIALIZE_ITEM_ID, string C_STA_ID)
        {
            return dal.GetFACount(C_INITIALIZE_ITEM_ID, C_STA_ID);
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(int N_SORT, string C_INITIALIZE_ID, string C_STA_ID)
        {
            return dal.GetList(N_SORT, C_INITIALIZE_ID, C_STA_ID);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string C_INITIALIZE_ITEM_ID, string C_STA_ID)
        {
            return dal.GetList(C_INITIALIZE_ITEM_ID, C_STA_ID);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(string c_id, string C_STA_ID, string C_INITIALIZE_ITEM_ID, int sort_new, int sort_old, string stype)
        {
            return dal.Update(c_id, C_STA_ID, C_INITIALIZE_ITEM_ID, sort_new, sort_old, stype);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(string c_id, string C_STA_ID, string C_INITIALIZE_ITEM_ID, int sort_new)
        {
            return dal.Update(c_id, C_STA_ID, C_INITIALIZE_ITEM_ID, sort_new);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(string C_STA_ID, string C_INITIALIZE_ITEM_ID, int sort_old)
        {
            return dal.Update(C_STA_ID, C_INITIALIZE_ITEM_ID, sort_old);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update_CX(string c_id, string C_STA_ID, string C_INITIALIZE_ITEM_ID, int sort_new, string stype)
        {
            return dal.Update_CX(c_id, C_STA_ID, C_INITIALIZE_ITEM_ID, sort_new, stype);
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Mod_TRP_PLAN_ROLL GetModel(int N_SORT, string C_INITIALIZE_ITEM_ID, string C_STA_ID)
        {
            return dal.GetModel(N_SORT, C_INITIALIZE_ITEM_ID, C_STA_ID);
        }

        /// <summary>
        /// 重新计算轧钢计划时间
        /// </summary>
        /// <param name="P_INITIALIZE_ITEM_ID">订单方案号</param>
        /// <returns></returns>
        public int ResetTime(string P_INITIALIZE_ITEM_ID)
        {
            return dal.ResetTime(P_INITIALIZE_ITEM_ID);
        }


        /// <summary>
        /// 获得产线数据列表
        /// </summary>
        public DataSet GetCXList(decimal hours, string C_INITIALIZE_ITEM)
        {
            return dal.GetCXList(hours, C_INITIALIZE_ITEM);
        }
        /// <summary>
        /// 获得产线下钢种规格数据列表
        /// </summary>
        public DataSet GetGZList(string C_STA_ID, string C_INITIALIZE_ITEM)
        {
            return dal.GetGZList(C_STA_ID, C_INITIALIZE_ITEM);
        }
        /// <summary>
        /// 自动排产计划
        /// </summary>
        /// <param name="P_INITIALIZE_ITEM_ID">订单方案号</param>
        /// <returns></returns>
        public int Add_ZG_Plan(string P_INITIALIZE_ID)
        {
            return dal.Add_ZG_Plan(P_INITIALIZE_ID);
        }

        /// <summary>
        /// 获取用自由坯的排产量
        /// </summary>
        /// <param name="C_INITIALIZE_ITEM_ID">订单表主键</param>
        /// <param name="C_INITIALIZE_ID">自由坯标识 1 </param>
        /// <returns></returns>
        public decimal GetZYPWgt(string C_INITIALIZE_ITEM_ID, string C_INITIALIZE_ID)
        {
            return dal.GetZYPWgt(C_INITIALIZE_ITEM_ID, C_INITIALIZE_ID);
        }
        /// <summary>
        /// 查询轧钢计划
        /// </summary>
        /// <param name="C_STA_ID">轧线主键</param>
        /// <param name="N_STATUS">计划状态</param>
        /// <param name="C_STL_GRD">钢种</param>
        /// <param name="C_SPEC">规格</param>
        /// <param name="C_STD_CODE">执行标准</param>
        /// <param name="C_ISZP">是否组批Y/N</param>
        /// <returns>轧钢计划</returns>
        public DataSet GetZGJH(string C_STA_ID, int? N_STATUS, string C_STL_GRD, string C_SPEC, string C_STD_CODE, string C_ISZP)
        {
            return dal.GetZGJH(C_STA_ID, N_STATUS, C_STL_GRD, C_SPEC, C_STD_CODE, C_ISZP);
        }
        /// <summary>
        /// 返回当前产线的新的开始排序号
        /// </summary>
        /// <param name="C_STA_ID">产线主键</param>
        /// <returns>开始序号</returns>
        public int GetMaxSort(string C_STA_ID)
        {
            return dal.GetMaxSort(C_STA_ID);
        }

        /// <summary>
        /// 查询轧钢计划
        /// </summary>
        /// <param name="C_LINT_ID">产线</param>
        /// <param name="N_STATUS">是否排产</param>
        /// <param name="C_ORDER_NO">订单号</param>
        /// <param name="C_STL_GRD">钢种</param>
        /// <param name="C_STD_CODE">执行标准</param>
        /// <param name="D_SPEC_MIN">规格最小</param>
        /// <param name="D_SPEC_MAX">规格最大</param>
        /// <param name="C_CUST_NAME">客户名称</param>
        /// <param name="C_JQ_MIN">交货日期最小</param>
        /// <param name="C_JQ_MAX">交货日期最大</param>
        /// <param name="C_DD_MIN">订单日期最小</param>
        /// <param name="C_DD_MAX">订单日期最大</param>
        /// <returns>轧钢计划</returns>
        public DataSet GetZGPlan(string C_LINT_ID, int? N_STATUS, string C_ORDER_NO, string C_STL_GRD, string C_STD_CODE, double? D_SPEC_MIN, double? D_SPEC_MAX, string C_CUST_NAME, string C_JQ_MIN, string C_JQ_MAX, string C_DD_MIN, string C_DD_MAX)
        {
            return dal.GetZGPlan(C_LINT_ID, N_STATUS, C_ORDER_NO, C_STL_GRD, C_STD_CODE, D_SPEC_MIN, D_SPEC_MAX, C_CUST_NAME, C_JQ_MIN, C_JQ_MAX, C_DD_MIN, C_DD_MAX);
        }

        /// <summary>
        /// 查询炼钢钢计划
        /// </summary>
        /// <param name="C_CCM_ID">连铸</param>
        /// <param name="N_STATUS">是否排产</param>
        /// <param name="C_ORDER_NO">订单号</param>
        /// <param name="C_STL_GRD">钢种</param>
        /// <param name="C_STD_CODE">执行标准</param>
        /// <param name="D_SPEC_MIN">规格最小</param>
        /// <param name="D_SPEC_MAX">规格最大</param>
        /// <param name="C_CUST_NAME">客户名称</param>
        /// <param name="C_JQ_MIN">交货日期最小</param>
        /// <param name="C_JQ_MAX">交货日期最大</param>
        /// <param name="C_DD_MIN">订单日期最小</param>
        /// <param name="C_DD_MAX">订单日期最大</param>
        /// <returns>炼钢计划</returns>
        public DataSet GetLGPlan(string C_CCM_ID, int? n_status, string C_ORDER_NO, string C_STL_GRD, string C_STD_CODE, double? D_SPEC_MIN, double? D_SPEC_MAX, string C_CUST_NAME, string C_JQ_MIN, string C_JQ_MAX, string C_DD_MIN, string C_DD_MAX)
        {
            return dal.GetLGPlan(C_CCM_ID, n_status, C_ORDER_NO, C_STL_GRD, C_STD_CODE, D_SPEC_MIN, D_SPEC_MAX, C_CUST_NAME, C_JQ_MIN, C_JQ_MAX, C_DD_MIN, C_DD_MAX);

        }

        /// <summary>
        /// 查询炼钢钢计划
        /// </summary>
        /// <param name="C_CCM_ID">连铸</param>
        /// <param name="N_STATUS">是否排产</param>
        /// <param name="C_ORDER_NO">订单号</param>
        /// <param name="C_STL_GRD">钢种</param>
        /// <param name="C_STD_CODE">执行标准</param>
        /// <param name="C_DD_MIN">订单日期最小</param>
        /// <param name="C_DD_MAX">订单日期最大</param>
        /// <returns>炼钢计划</returns>
        public DataSet GetLGPlan(string C_CCM_ID, int? N_STATUS, string C_ORDER_NO, string C_STL_GRD, string C_STD_CODE, string C_DD_MIN)
        {
            return dal.GetLGPlan(C_CCM_ID, N_STATUS, C_ORDER_NO, C_STL_GRD, C_STD_CODE, C_DD_MIN);
        }

        /// <summary>
        /// 系统对轧钢计划重新划分产线
        /// </summary>
        /// <returns></returns>
        public string GetLine()
        {

            return dal.GetLine();
        }

        /// <summary>
        /// 手动调整产线
        /// </summary>
        /// <param name="P_ID">计划主键</param>
        /// <param name="LINE_ID">产线主键</param>
        /// <returns>成功1失败0</returns>
        public string GetLineByID(string P_ID, string LINE_ID)
        {
            return dal.GetLineByID(P_ID, LINE_ID);
        }

        /// <summary>
        /// 根据线材订单手动划分产线
        /// </summary>
        /// <param name="P_STL_GRD">钢种</param>
        /// <param name="P_SPEC">规格</param>
        /// <param name="P_STD_CODE">执行标准</param>
        /// <param name="P_LINE_NO">产线</param>
        /// <returns>划分结果</returns>
        public string ChangeLineByplan(string P_STL_GRD, string P_SPEC, string P_STD_CODE, string P_LINE_NO)
        {
            return dal.ChangeLineByplan(P_STL_GRD, P_SPEC, P_STD_CODE, P_LINE_NO);
        }

        /// <summary>
        /// 获取轧钢计划中未维护机时产能的数据
        /// </summary>
        /// <returns></returns>
        public DataTable GetNJSCN()
        {
            return dal.GetNJSCN();
        }
        /// <summary>
        /// 维护计划轧钢机时产能
        /// </summary>
        /// <param name="P_LINT_ID">产线主键</param>
        /// <param name="P_STL_GRD">钢种</param>
        /// <param name="P_SPEC">规格</param>
        /// <param name="P_MACH_WGT">机时产能</param>
        /// <param name="P_SFGX">是否更新到机时产能基础表</param>
        /// <returns>是否成功1，0失败</returns>
        public string UpdatePlanJSCN(string P_LINT_ID, string P_STL_GRD, string P_SPEC, decimal P_MACH_WGT, string P_SFGX)
        {
            return dal.UpdatePlanJSCN(P_LINT_ID, P_STL_GRD, P_SPEC, P_MACH_WGT, P_SFGX);
        }

        /// <summary>
        /// 按订单钢种规格统计轧钢计划
        /// </summary>
        /// <param name="C_STA_ID">产线主键 全部时传all</param>
        /// <param name="C_SPEC">订单规格</param>
        /// <returns>查询未排产订单</returns>
        public DataTable GetNJSCN(string C_STA_ID, string C_SPEC)
        {
            return dal.GetNJSCN(C_STA_ID, C_SPEC);
        }
        /// <summary>
        /// 按订单钢种规格统计轧钢计划
        /// </summary>
        /// <param name="C_STA_ID">产线主键 全部时传all</param>
        /// <returns>查询未排产订单</returns>
        public DataTable GetLineGZ(string C_STA_ID)
        {
            return dal.GetLineGZ(C_STA_ID);

        }

        /// <summary>
        /// 按产线规格统计订单
        /// </summary>
        /// <param name="C_STA_ID">产线主键 全部时传all</param>
        /// <param name="C_SPEC">规格</param>
        /// <returns>统计数据</returns>
        public DataTable GetWgtByLineAndGG(string C_STA_ID, string C_SPEC)
        {
            return dal.GetWgtByLineAndGG(C_STA_ID, C_SPEC);
        }

        /// <summary>
        /// 按产线规格统计订单
        /// </summary>
        /// <param name="C_STA_ID">产线主键 全部时传all</param>
        /// <returns>统计数据</returns>
        public DataTable GetWgtByLine(string C_STA_ID)
        {
            return dal.GetWgtByLine(C_STA_ID);
        }

        /// <summary>
        /// 获取要未发的轧钢计划
        /// </summary>
        /// <param name="C_STA_ID">轧线主键</param>
        /// <param name="strGZ">钢种</param>
        /// <param name="strBZ">标准</param>
        /// <param name="strState">状态；0-未下发；1-已下发</param>
        /// <param name="strBZ">规格<param>
        /// <param name="iBXG">是否不锈钢<param>
        /// <returns></returns>
        public DataSet Get_Plan_WXF(string C_STA_ID, string strGZ, string strBZ, string strState, string strGG, int iBXG, string c_order_no)
        {
            return dal.Get_Plan_WXF(C_STA_ID, strGZ, strBZ, strState, strGG, iBXG, c_order_no);
        }


        /// <summary>
        /// 获取要未发的轧钢计划
        /// </summary>
        /// <param name="C_STA_ID">轧线主键</param>
        /// <param name="strGZ">钢种</param>
        /// <param name="strBZ">标准</param>
        /// <param name="strState">未下发，已下发，已完工，全部</param>
        /// <param name="strBZ">规格<param>
        /// <param name="iBXG">是否不锈钢<param>
        ///  <param name="c_order_no">订单号<param>
        /// <returns></returns>
        public DataSet Get_Plan_WXF_Test(string C_STA_ID, string strGZ, string strBZ, string strState, string strGG, int iBXG, string c_order_no)
        {
            return dal.Get_Plan_WXF_Test(C_STA_ID, strGZ, strBZ, strState, strGG, iBXG, c_order_no);
        }


        /// <summary>
        /// 获取钢坯库存
        /// </summary>
        /// <param name="grd">钢种</param>
        /// <param name="spec">断面</param>
        /// <param name="std">执行标准</param>
        /// <param name="slabwhCode">仓库编码</param>
        /// <param name="matCode">物料编码</param>
        /// <param name="length">长度</param>
        /// <returns></returns>
        public DataTable GetSlabInventory(string grd, string spec, string std)
        {
            return dal.GetSlabInventory(grd, spec, std);
        }

        /// <summary>
        /// 重置下发量
        /// </summary>
        /// <returns></returns>
        public void ResetSendWgt(string id)
        {
            dal.ResetSendWgt(id);
        }
            #endregion  ExtensionMethod

            #region 炼钢排产

            /// <summary>
            /// 获取炼钢可生成炉次计划的生产订单信息
            /// </summary>
            /// <param name="C_STL_GRD_SLAB">炼钢钢种</param>
            /// <param name="C_STD_CODE_SLAB">炼钢标准</param>
            /// <param name="C_SLAB_SIZE">断面</param>
            /// <param name="N_SLAB_LENGTH">定尺</param>
            /// <returns>查询结果</returns>
            public DataTable GetOrderLCInfo(string C_STL_GRD_SLAB, string C_STD_CODE_SLAB,string C_BY1, string C_BY2, string C_MATRL_CODE_SLAB)
        {
            return dal.GetOrderLCInfo(C_STL_GRD_SLAB, C_STD_CODE_SLAB, C_BY1,  C_BY2, C_MATRL_CODE_SLAB);

        }

        /// <summary>
        /// 根据组号加载可以生产的产品
        /// </summary>
        /// <param name="N_GROUP">分组号</param>
        /// <param name="C_CCM_ID">连铸号</param>
        /// <param name="SFWC">是否完成</param>
        /// <param name="D_DT_B">排产计划开始日期</param>
        /// <param name="D_DT_E">排产计划截止日期</param>
        /// <returns>可加载的计划</returns>
        public DataTable GetOrderMatInfo(int N_GROUP, string C_CCM_ID, int SFWC, string D_DT_B, string D_DT_E)
        {
            return dal.GetOrderMatInfo(N_GROUP, C_CCM_ID, SFWC, D_DT_B, D_DT_E);

        }


        /// <summary>
        /// 获取炼钢排产计划数据
        /// </summary>
        /// <param name="D_DT_B">排产订单开始时间</param>
        /// <param name="D_DT_E">排产订单结束时间</param>
        /// <param name="C_CCM_ID">连铸主键</param>
        /// <returns>按组合并后的炼钢计划</returns>
        public DataTable GetSlabOrder(string D_DT_B, string D_DT_E, string C_CCM_ID, string C_IS_BXG)
        {
            return dal.GetSlabOrder(D_DT_B, D_DT_E, C_CCM_ID, C_IS_BXG);
        }
        /// <summary>
        /// 获取炼钢排产计划数据
        /// </summary>
        /// <param name="D_DT_B">排产订单开始时间</param>
        /// <param name="D_DT_E">排产订单结束时间</param>
        /// <param name="C_CCM_ID">连铸主键</param>
        /// <returns>按组合并后的炼钢计划</returns>
        public DataTable GetSlabOrder(string D_DT_B, string D_DT_E, string C_CCM_ID, string C_IS_BXG, int N_GROUP)
        {
            return dal.GetSlabOrder(D_DT_B, D_DT_E, C_CCM_ID, C_IS_BXG, N_GROUP);
        }

        /// <summary>
        /// 获取炼钢排产计划详细数据
        /// </summary>
        /// <param name="D_DT_B">排产订单开始时间</param>
        /// <param name="D_DT_E">排产订单结束时间</param>
        /// <param name="C_CCM_ID">连铸主键</param>
        ///  <param name="N_GROUP">分组号</param>
        /// <returns>按组合并后的炼钢详细计划</returns>
        public DataTable GetSlabOrderInfo(string D_DT_B, string D_DT_E, string C_CCM_ID, int N_GROUP, string C_IS_BXG)
        {
            return dal.GetSlabOrderInfo(D_DT_B, D_DT_E, C_CCM_ID, N_GROUP, C_IS_BXG);
        }

        /// <summary>
        /// 获取炼钢排产计划详细数据
        /// </summary>
        /// <param name="D_DT_B">排产订单开始时间</param>
        /// <param name="D_DT_E">排产订单结束时间</param>
        /// <param name="C_CCM_ID">连铸主键</param>
        ///  <param name="N_GROUP">分组号</param>
        /// <returns>按组合并后的炼钢详细计划</returns>
        public DataTable GetSlabOrderInfoDesc(string C_CCM_ID, int? N_GROUP)
        {
            return dal.GetSlabOrderInfoDesc(C_CCM_ID, N_GROUP);
        }

        /// <summary>
        /// 根据订单号获取已下发车间量
        /// </summary>
        /// <param name="C_INITIALIZE_ITEM_ID">订单号</param>
        /// <returns></returns>
        public decimal GetYPwgt(string C_INITIALIZE_ITEM_ID)
        {
            return dal.GetYPwgt(C_INITIALIZE_ITEM_ID);
        }

        /// <summary>
        /// 根据订单号删除数据
        /// </summary>
        public bool DeleteByOrderNo(string C_INITIALIZE_ITEM_ID)
        {
            return dal.DeleteByOrderNo(C_INITIALIZE_ITEM_ID);
        }

        /// <summary>
        /// 获取之前计划未完成的计划
        /// </summary>
        /// <param name="D_DT">截止时间</param>
        /// <param name="C_STL_GRD">钢种</param>
        /// <param name="C_STD_CODE">执行标准</param>
        /// <param name="C_MATRL_CODE">物料名称</param>
        /// <returns></returns>
        public decimal GetLeftWgt(string D_DT, string C_STL_GRD, string C_STD_CODE, string C_MATRL_CODE)
        {
            return dal.GetLeftWgt(D_DT, C_STL_GRD, C_STD_CODE, C_MATRL_CODE);
        }

        /// <summary>
        /// 获取炉次计划可对应的订单
        /// </summary>
        /// <param name="D_DT_F">计划日期起</param>
        /// <param name="D_DT_E">计划日期终</param>
        /// <param name="C_STL_GRD_SLAB">钢种</param>
        /// <param name="C_STD_CODE_SLAB">执行标准</param>
        /// <param name="C_MATRL_CODE_SLAB">连铸坯物料编码</param>
        /// <param name="C_MATRL_CODE_KP">热轧坯物料编码</param>
        /// <param name="C_CCM_ID">连铸机主键</param>
        /// <param name="N_GROUP">分组号</param>
        /// <returns>炉次计划对应的订单</returns>
        public DataTable GetPlanInfo(string D_DT_F, string D_DT_E, string C_STL_GRD_SLAB, string C_STD_CODE_SLAB, string C_MATRL_CODE_SLAB, string C_MATRL_CODE_KP, string C_CCM_ID, int N_GROUP)
        {
            return dal.GetPlanInfo(D_DT_F, D_DT_E, C_STL_GRD_SLAB, C_STD_CODE_SLAB, C_MATRL_CODE_SLAB, C_MATRL_CODE_KP, C_CCM_ID, N_GROUP);
        }


        /// <summary>
        /// 根据订单主键获取下达的计划
        /// </summary>
        /// <param name="C_INITIALIZE_ITEM_ID">订单主键</param>
        /// <returns></returns>
        public DataSet GetListByOrderID(string C_INITIALIZE_ITEM_ID)
        {
            return dal.GetListByOrderID(C_INITIALIZE_ITEM_ID);

        }

        /// <summary>
        /// 获取线材订单的规格
        /// </summary>
        public DataSet Get_Spec()
        {
            return dal.Get_Spec();
        }

        /// <summary>
        /// 根据计划号主键获取计划生产明细
        /// </summary>
        /// <param name="C_ID">计划号主键</param>
        /// <returns></returns>
        public DataTable GetOrderProInfo(string C_ID)
        {
            return dal.GetOrderProInfo(C_ID);
        }

        /// <summary>
        /// 根据订单号显示订单执行情况
        /// </summary>
        /// <param name="C_ORDER_NO"></param>
        /// <returns></returns>
        public DataTable GetOrderProInfoByOrderNo(string C_ORDER_NO)
        {
            return dal.GetOrderProInfoByOrderNo(C_ORDER_NO);
        }

        /// <summary>
        /// 获取轧钢计划完成量信息
        /// </summary>
        /// <param name="strTime1">时间1</param>
        /// <param name="strTime2">时间2</param>
        /// <returns></returns>
        public DataSet Get_Zgfx(string strTime1, string strTime2)
        {
            return dal.Get_Zgfx(strTime1, strTime2);
        }

        #endregion
    }
}

