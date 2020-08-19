using System;
using System.Data;
using System.Collections.Generic;
using DAL;
using MODEL;
namespace BLL
{
    /// <summary>
    /// 订单池
    /// </summary>
    public partial class Bll_TMO_ORDER
    {
        private readonly Dal_TMO_ORDER dal = new Dal_TMO_ORDER();
        public Bll_TMO_ORDER()
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
        /// 验证能否修改订单计划
        /// </summary>
        /// <param name="C_ID"></param>
        /// <returns></returns>
        public bool IsCanUpdate(string C_ID)
        {
            return dal.IsCanUpdate(C_ID);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Mod_TMO_ORDER model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Mod_TMO_ORDER model)
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
        public Mod_TMO_ORDER GetModel(string C_ID)
        {

            return dal.GetModel(C_ID);
        }
        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Mod_TMO_ORDER GetModelByORDERNO(string C_ORDER_NO)
        {
            return dal.GetModelByORDERNO(C_ORDER_NO);
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
        public List<Mod_TMO_ORDER> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Mod_TMO_ORDER> DataTableToList(DataTable dt)
        {
            List<Mod_TMO_ORDER> modelList = new List<Mod_TMO_ORDER>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Mod_TMO_ORDER model;
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
        /// 获得数据列表
        /// </summary>
        public DataSet GetList_TWOrderAdd( string STLGRD, string std)
        {
            return dal.GetList_TWOrderAdd(  STLGRD, std);
        }
        #endregion  BasicMethod
        #region  ExtensionMethod
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string N_EXEC_STATUS, string N_STATUS)
        {
            return dal.GetList(N_EXEC_STATUS, N_STATUS);
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList_ByOrderNO(string c_order_no)
        {
            return dal.GetList_ByOrderNO(c_order_no);
        }
        /// <summary>
        /// 变更订单状态
        /// </summary>
        public bool UpByStatus(string N_STATUS)
        {
            return dal.UpByStatus(N_STATUS);
        }
        /// <summary>
        /// 查询该方案未初始化订单信息
        /// </summary>
        /// <param name="strIniID">方案主键</param>
        /// <param name="type">是否初始化：是/否</param>
        /// <param name="strDT">月计划/旬计划</param>
        /// <returns></returns>
        public DataTable GetWCSHOrderByIni(string strIniID, string type, string strDT)
        {
            return dal.GetWCSHOrderByIni(strIniID, type, strDT);
        }
        /// <summary>
        /// 查询该方案未初始化订单信息
        /// </summary>
        /// <param name="strIniID">方案主键</param>
        /// <param name="type">是否初始化：是/否</param>
        /// <param name="IntDT">计划类型0未分1月排产2旬排产</param>
        /// <param name="N_STATUS">是否审核 默认0，2生效</param>
        /// <param name="N_EXEC_STATUS">执行状态:0未排产，1已排产</param>
        /// <returns></returns>
        public DataTable GetWCSHOrderByIni(string strIniID, string type, string strDT, int N_STATUS, int N_EXEC_STATUS)
        {
            return dal.GetWCSHOrderByIni(strIniID, type, strDT, N_STATUS, N_EXEC_STATUS);
        }

        /// <summary>
        /// 获取订单主键
        /// </summary>
        public string Get_ID(string C_ORDER_NO, string C_CON_NO, string C_STL_GRD, string C_STD_CODE)
        {
            return dal.Get_ID(C_ORDER_NO, C_CON_NO, C_STL_GRD, C_STD_CODE);
        }

        /// <summary>
        /// 根据条件查询销售订单信息
        /// </summary>
        /// <param name="C_SFPJ">是否已经评价</param>
        /// <param name="N_STATUS">订单状态</param>
        /// <param name="N_EXEC_STATUS">订单执行状态2人工确认完成</param>
        /// <param name="N_SFPW">是否排产完0未排完1已排完 NULL未排（(N_WGT-N_ROLL_PROD_WGT-N_LINE_MATCH_WGT)=0&&(N_WGT-N_SMS_PROD_WGT-N_SLAB_MATCH_WGT)=0）</param>
        /// <param name="C_ORDER_NO">订单号</param>
        /// <param name="C_CON_NO">合同号</param>
        /// <param name="C_AREA">销售区域</param>
        /// <param name="C_STL_GRD">钢种</param>
        /// <param name="C_STD_CODE">执行标准</param>
        /// <param name="C_SPEC">规格</param>
        /// <param name="D_SPEC_MIN">规格最小</param>
        /// <param name="D_SPEC_MAX">规格最大</param>
        /// <param name="C_LINE_NO">产线号</param>
        /// <param name="C_CCM_NO">连铸号</param>
        /// <param name="C_CUST_NAME">客户名称</param>
        /// <param name="C_SALE_CHANNEL">销售类型</param>
        /// <param name="C_PRO_USE">产品用途</param>
        /// <param name="C_RH">是否真空</param>
        /// <param name="C_HL">是否缓冷</param>
        ///  <param name="C_JQ_MIN">交货日期最小值</param>
        ///  <param name="C_JQ_MAX">交货日期最大值</param>
        /// <returns>销售订单列表</returns>
        public DataSet GetListByWhere(string C_SFPJ, int? N_STATUS, int? N_EXEC_STATUS, int? N_SFPW, string C_ORDER_NO, string C_CON_NO, string C_AREA, string C_STL_GRD, string C_STD_CODE, string C_SPEC, double? D_SPEC_MIN, double? D_SPEC_MAX, string C_LINE_NO, string C_CCM_NO, string C_CUST_NAME, string C_SALE_CHANNEL, string C_PRO_USE, string C_RH, string C_HL, string C_JQ_MIN, string C_JQ_MAX)
        {
            return dal.GetListByWhere(C_SFPJ, N_STATUS, N_EXEC_STATUS, N_SFPW, C_ORDER_NO, C_CON_NO, C_AREA, C_STL_GRD, C_STD_CODE, C_SPEC, D_SPEC_MIN, D_SPEC_MAX, C_LINE_NO, C_CCM_NO, C_CUST_NAME, C_SALE_CHANNEL, C_PRO_USE, C_RH, C_HL, C_JQ_MIN, C_JQ_MAX);
        }

        /// <summary>
        /// 根据条件查询销售订单信息
        /// </summary>
        /// <param name="C_SFPJ">是否已经评价</param>
        /// <param name="N_STATUS">订单状态</param>
        /// <param name="N_EXEC_STATUS">执行状态:-2人为关闭-1刚导入，0自由状态 1生成销售订单，2销售订单上传NC</param>
        /// <param name="N_SFPW">是否排产完0未排完1已排完 null全部</param>
        /// <param name="C_ORDER_NO">订单号</param>
        /// <param name="C_CON_NO">合同号</param>

        /// <param name="C_STL_GRD">钢种</param>
        /// <param name="C_STD_CODE">执行标准</param>
        /// <param name="C_SPEC">规格</param>
        /// <param name="C_LINE_NO">产线号</param>
        /// <param name="C_CCM_NO">连铸号</param>
        /// <param name="C_CUST_NAME">客户名称</param>
        ///  <param name="C_JQ_MIN">交货日期最小值</param>
        ///  <param name="C_JQ_MAX">交货日期最大值</param>
        ///  <param name="C_DD_MIN">订单日期最小值</param>
        ///  <param name="C_DD_MAX">订单日期最大值</param>
        /// <returns>销售订单列表</returns>
        public DataSet GetOrderByWhere(int n_type, string C_SFPJ, int? N_EXEC_STATUS, int? N_SFPW, string C_ORDER_NO, string C_CON_NO, string C_STL_GRD, string C_STD_CODE, string C_SPEC, string C_CUST_NAME, string C_JQ_MIN, string C_JQ_MAX, string C_DD_MIN, string C_DD_MAX, string C_LINE_NO)
        {

            return dal.GetOrderByWhere(n_type, C_SFPJ, N_EXEC_STATUS, N_SFPW, C_ORDER_NO, C_CON_NO, C_STL_GRD, C_STD_CODE, C_SPEC, C_CUST_NAME, C_JQ_MIN, C_JQ_MAX, C_DD_MIN, C_DD_MAX, C_LINE_NO);
        }



        /// <summary>
        /// 根据条件查询销售订单信息
        /// </summary>
        /// <param name="n_type">0全部，1碳钢，2不锈钢，3钢坯</param>
        /// <param name="C_SFPJ">是否已经评价</param>
        /// <param name="N_STATUS">订单状态</param>
        /// <param name="N_EXEC_STATUS">执行状态:0未完成，1已完成</param>
        /// <param name="N_SFPW">是否排产完0未排完1已排完 null全部</param>
        /// <param name="C_ORDER_NO">订单号</param>
        /// <param name="C_CON_NO">合同号</param>
        /// <param name="C_STL_GRD">钢种</param>
        /// <param name="C_STD_CODE">执行标准</param>
        /// <param name="C_SPEC">规格</param>

        /// <param name="C_LINE_NO">产线号</param>
        /// <param name="C_CCM_NO">连铸号</param>
        /// <param name="C_CUST_NAME">客户名称</param>
        ///  <param name="C_JQ_MIN">计划日期最小值</param>
        ///  <param name="C_JQ_MAX">计划日期最大值</param>
        ///  <param name="C_DD_MIN">订单日期最小值</param>
        ///  <param name="C_DD_MAX">订单日期最大值</param>
        /// <returns>销售订单列表</returns>
        public List<Mod_TMO_ORDER> GetOrderListByWhere(int n_type, string C_SFPJ, int? N_EXEC_STATUS, int? N_SFPW, string C_ORDER_NO, string C_CON_NO, string C_STL_GRD, string C_STD_CODE, string C_SPEC, string C_CUST_NAME, string C_JQ_MIN, string C_JQ_MAX, string C_DD_MIN, string C_DD_MAX, string C_LINE_NO)
        {
            DataTable dt = dal.GetOrderByWhere(n_type, C_SFPJ, N_EXEC_STATUS, N_SFPW, C_ORDER_NO, C_CON_NO, C_STL_GRD, C_STD_CODE, C_SPEC, C_CUST_NAME, C_JQ_MIN, C_JQ_MAX, C_DD_MIN, C_DD_MAX, C_LINE_NO).Tables[0];
            return DataTableToList(dt);
        }



        /// <summary>
        /// 线材订单执行情况查询
        /// </summary>
        /// <param name="begin">开始时间</param>
        /// <param name="end">结束时间</param>
        /// <param name="strSTLGRD">钢种</param>
        /// <param name="strSTD">执行标准</param>
        /// <param name="strSpec">规格</param>
        /// <param name="strCust">工艺路线</param>
        /// <param name="strOrderNo">订单号</param>
        /// <param name="N_EXEC_STATUS">执行状态</param>
        /// <param name="N_SFPW">是否下达</param>
        /// <returns></returns>
        public DataTable GetPlanZX_Query_ZG(DateTime begin, DateTime end, string strSTLGRD, string strSTD, string strSpec, string strCust, string strOrderNo, string SFPJ, int? N_EXEC_STATUS, int? N_SFPW, string C_LINE_NO, string c_type)
        {

            return dal.GetPlanZX_Query_ZG(begin, end, strSTLGRD, strSTD, strSpec, strCust, strOrderNo, SFPJ, N_EXEC_STATUS, N_SFPW, C_LINE_NO, c_type);

        }

        /// <summary>
        /// 获取订单物料名称
        /// </summary>
        ///  <param name="C_JQ_MIN">交货日期最小值</param>
        ///  <param name="C_JQ_MAX">交货日期最大值</param>
        ///  <param name="C_DD_MIN">订单日期最小值</param>
        ///  <param name="C_DD_MAX">订单日期最大值</param>
        /// <returns></returns>
        public DataTable GetMatrelName(string C_JQ_MIN, string C_JQ_MAX, string C_DD_MIN, string C_DD_MAX)
        {
            return dal.GetMatrelName(C_JQ_MIN, C_JQ_MAX, C_DD_MIN, C_DD_MAX);
        }

        /// <summary>
        /// 根据条件查询销售订单评价失败日志列表
        /// </summary>
        /// <returns>销售订单评价失败日志列表</returns>
        public DataSet GetListPJLOG()
        {
            return dal.GetListPJLOG();
        }
        /// <summary>
        /// 炼钢浇次分组信息
        /// </summary>
        /// <param name="C_CCM_NO">连铸</param>
        /// <param name="C_STL_GRD">钢种</param>
        /// <param name="C_STD_CODE">标准</param>
        /// <param name="N_GROUP">组号</param>
        /// <returns></returns>
        public DataSet GetPCorder(string C_CCM_NO, string C_STL_GRD, string C_STD_CODE, int? N_GROUP)
        {
            return dal.GetPCorder(C_CCM_NO, C_STL_GRD, C_STD_CODE, N_GROUP);
        }
        /// <summary>
        /// 按分组后订单查询浇次信息
        /// </summary>
        /// <returns></returns>
        public DataSet GetInfoByGroup(string C_CCM_NO)
        {

            return dal.GetInfoByGroup(C_CCM_NO);
        }
        /// <summary>
        /// 获取需要排产的订单分组信息
        /// </summary>
        /// <returns></returns>
        public DataSet Get_PC_GROUP()
        {
            return dal.Get_PC_GROUP();
        }

        /// <summary>
        /// 获取分组的订单详细信息
        /// </summary>
        /// <returns></returns>
        public Mod_TMO_ORDER Get_PC_ORDER(string str_GROUP)
        {
            return dal.Get_PC_ORDER(str_GROUP);
        }

        /// <summary>
        /// 按产线统计
        /// </summary>
        /// <returns></returns>
        public DataSet Get_List_ACX(string CX)
        {
            return dal.Get_List_ACX(CX);
        }
        /// <summary>
        /// 按产线规格统计
        /// </summary>
        /// <returns></returns>
        public DataSet Get_List_ACXGG(string CX)
        {
            return dal.Get_List_ACXGG(CX);
        }
        /// <summary>
        /// 按连铸统计
        /// </summary>
        /// <returns></returns>
        public DataSet Get_List_ALZ(string LZ)
        {
            return dal.Get_List_ALZ(LZ);
        }
        /// <summary>
        /// 按连铸钢种统计
        /// </summary>
        /// <returns></returns>
        public DataSet Get_List_ALZGZ(string LZ)
        {
            return dal.Get_List_ALZGZ(LZ);
        }

        /// <summary>
        /// 根据临时表中组号获取整浇次炉数
        /// </summary>
        /// <param name="N_GROUP">组号</param>
        /// <returns>炉数</returns>
        public int GetZJCLS(int N_GROUP)
        {
            return dal.GetZJCLS(N_GROUP);
        }

        /// <summary>
        /// 获取待排炼钢计划订单
        /// </summary>
        /// <param name="strGZ">钢种</param>
        /// <param name="strBZ">执行标准</param>
        /// <param name="strCCM">连铸主键</param>
        /// <returns></returns>
        public DataTable GetLGPCOrder(string strGZ, string strBZ, string strCCM)
        {
            return dal.GetLGPCOrder(strGZ, strBZ, strCCM);
        }
        /// <summary>
        /// 得到订单主键
        /// </summary>
        /// <param name="N_GROUP">订单分组号</param>
        /// <param name="C_STL_GRD">钢种</param>
        /// <param name="C_STD_CODE">执行标准</param>
        /// <returns>订单表主键</returns>
        public string GetOrderID(string N_GROUP, string C_STL_GRD, string C_STD_CODE)
        {
            return dal.GetOrderID(N_GROUP, C_STL_GRD, C_STD_CODE);
        }

        /// <summary>
        /// 获取待排轧钢计划订单
        /// </summary>
        /// <param name="strGZ">钢种</param>
        /// <param name="strBZ">执行标准</param>
        /// <param name="C_LINE_NO">轧线主键</param>
        /// <param name="kpc">系统可判断可排产 Y 有库存钢坯或已排连铸计划的订单 排产量=（N_SMS_PROD_WGT + N_SLAB_MATCH_WGT）</param>
        /// <returns></returns>
        public DataTable GetZGPCOrder(string strGZ, string strBZ, string C_LINE_NO, string kpc)
        {
            return dal.GetZGPCOrder(strGZ, strBZ, C_LINE_NO, kpc);
        }

        /// <summary>
        /// 获取待排炼钢计划订单
        /// </summary>
        /// <param name="strGZ">钢种</param>
        /// <param name="strBZ">执行标准</param>
        /// <param name="C_LINE_NO">轧线主键</param>
        /// <param name="SFPC">系统有钢坯可排产 Y (N_WGT - N_SMS_PROD_WGT - N_SLAB_MATCH_WGT)>0</param>
        /// <returns></returns>
        public DataTable GetLGPCOrder(string strGZ, string strBZ, string C_CCM_NO, string SFPC)
        {
            return dal.GetLGPCOrder(strGZ, strBZ, C_CCM_NO, SFPC);
        }

        /// <summary>
        /// 根据订单主键返回炼钢排产的重量
        /// </summary>
        /// <param name="C_ORDER_ID">订单号</param>
        /// <param name="N_WGT">返回量</param>
        /// <returns></returns>
        public int BackLGWGT(string C_ORDER_ID, Decimal N_WGT)
        {
            return dal.BackLGWGT(C_ORDER_ID, N_WGT);
        }

        /// <summary>
        /// 根据订单主键返回轧钢排产的重量
        /// </summary>
        /// <param name="C_ORDER_ID">订单号</param>
        /// <param name="N_WGT">返回量</param>
        /// <returns></returns>
        public int BackZGWGT(string C_ORDER_ID, Decimal N_WGT)
        {
            return dal.BackZGWGT(C_ORDER_ID, N_WGT);
        }


        /// <summary>
        /// 根据条件查询销售订单信息
        /// </summary>
        /// <param name="C_SFPJ">是否已经评价</param>
        /// <param name="N_STATUS">订单状态</param>
        /// <param name="N_EXEC_STATUS">订单执行状态2人工确认完成</param>
        /// <param name="C_STL_GRD">钢种</param>
        /// <param name="C_STD_CODE">执行标准</param>
        /// <param name="C_SPEC">规格</param>
        /// <param name="D_SPEC_MIN">规格最小</param>
        /// <param name="D_SPEC_MAX">规格最大</param>
        /// <param name="C_REMARK">备注</param>
        ///  <param name="C_JQ_MIN">交货日期最小值</param>
        ///  <param name="C_JQ_MAX">交货日期最大值</param>
        /// <returns>销售订单列表</returns>
        public DataSet GetImporyOrder(string C_SFPJ, int? N_STATUS, int? N_EXEC_STATUS, string C_STL_GRD, string C_STD_CODE, double? D_SPEC_MIN, double? D_SPEC_MAX, string C_REMARK, string C_JQ_MIN, string C_JQ_MAX)
        {
            return dal.GetImporyOrder(C_SFPJ, N_STATUS, N_EXEC_STATUS, C_STL_GRD, C_STD_CODE, D_SPEC_MIN, D_SPEC_MAX, C_REMARK, C_JQ_MIN, C_JQ_MAX);
        }

        /// <summary>
        /// 按规格获取产线代码
        /// </summary>
        /// <param name="C_SPEC">规格</param>
        /// <returns>产线代码</returns>
        public string GetLine(string C_SPEC)
        {
            return dal.GetLine(C_SPEC);
        }
        /// <summary>
        /// 清除炼钢待排产订单分组号
        /// </summary>
        /// <returns>执行结果</returns>
        public bool ClearGroupNo()
        {
            return dal.ClearGroupNo();
        }
        /// <summary>
        ///查询所有炼钢待排产的订单
        /// </summary>
        /// <returns></returns>
        public DataTable GetLGWPOrder()
        {
            return dal.GetLGWPOrder();

        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Mod_TMO_ORDER> GetModelList()
        {
            DataTable dt = dal.GetLGWPOrder();
            return DataTableToList(dt);
        }
        /// <summary>
        /// 批量更新订单库存匹配量
        /// </summary>
        /// <param name="strCCM">连铸机信息</param>
        /// <returns>执行行数</returns>
        public int UpdateOrderSmsMatchWgt(string strCCM)
        {
            return dal.UpdateOrderSmsMatchWgt(strCCM);
        }

        /// <summary>
        /// 可排产订单分析
        /// </summary>
        /// <returns></returns>
        public DataTable KPC_DD_FX(string C_CCM_ID)
        {
            return dal.KPC_DD_FX(C_CCM_ID);
        }


        /// <summary>
        /// 获取待排轧钢计划订单
        /// </summary>
        /// <param name="C_CCM_NO">连铸主键</param>
        /// <returns></returns>
        public DataTable GetZGPCOrder(string C_CCM_NO)
        {
            return dal.GetZGPCOrder(C_CCM_NO);
        }

        /// <summary>
        /// 待排产订单按可混浇分组
        /// </summary>
        /// <returns></returns>
        public string GroupingOrder()
        {
            return dal.GroupingOrder();
        }

        /// <summary>
        /// 订单分析
        /// </summary>
        /// <returns></returns>
        public string ManageOrder()
        {
            return dal.ManageOrder();
        }
        /// <summary>
        /// 订单确认
        /// </summary>
        /// <returns></returns>
        public string QROrder()
        {
            return dal.QROrder();
        }

        /// <summary>
        /// 取消排产
        /// </summary>
        /// <returns></returns>
        public string qxOrder(string C_ID)
        {
            return dal.qxOrder_sms(C_ID) + dal.qxOrder_roll(C_ID);
        }

        /// <summary>
        /// 订单评价
        /// </summary>
        /// <returns></returns>
        public string PJOrder()
        {
            return dal.PJOrder();
        }

        /// <summary>
        /// 订单下发
        /// </summary>
        /// <param name="P_ID">订单主键</param>
        /// <param name="P_WGT">订单下发两</param>
        /// <returns>执行结果1成功0失败</returns>
        public string QROrder(string P_ID, decimal P_WGT)
        {
            return dal.QROrder(P_ID, P_WGT);
        }

        /// <summary>
        /// 查询待确认订单
        /// </summary>
        /// <param name="C_ORDER_NO">订单号</param>
        /// <param name="C_CON_NO">合同号</param>
        /// <param name="C_STL_GRD">钢种</param>
        /// <param name="C_STD_CODE">执行标准</param>
        /// <param name="D_SPEC_MIN">规格最小</param>
        /// <param name="D_SPEC_MAX">规格最大</param>
        /// <param name="C_LINE_NO">产线主键</param>
        /// <param name="C_CCM_NO">连铸主键</param>
        /// <param name="C_JQ_MIN">交期最小</param>
        /// <param name="C_JQ_MAX">交期最大</param>
        /// <returns>订单列表</returns>
        public DataSet GetListByWhere1(string C_ORDER_NO, string C_CON_NO, string C_STL_GRD, string C_STD_CODE, double? D_SPEC_MIN, double? D_SPEC_MAX, string C_LINE_NO, string C_CCM_NO, string C_JQ_MIN, string C_JQ_MAX)
        {
            return dal.GetListByWhere1(C_ORDER_NO, C_CON_NO, C_STL_GRD, C_STD_CODE, D_SPEC_MIN, D_SPEC_MAX, C_LINE_NO, C_CCM_NO, C_JQ_MIN, C_JQ_MAX);
        }
        /// <summary>
        /// 查找订单最大交期
        /// </summary>
        /// <returns></returns>
        public string GetMaxJQ(string sfkp)
        {
            return dal.GetMaxJQ(sfkp);
        }
        #endregion  ExtensionMethod

        #region 计划跟踪
        /// <summary>
        ///销售计划跟踪
        /// </summary>
        /// <param name="C_ORDER_NO">订单号</param>
        /// <param name="C_STL_GRD">钢种</param>
        /// <param name="C_SPEC">规格</param>
        /// <param name="C_STD_CODE">执行标准</param>
        /// <param name="D_DT_B">订单日期起</param>
        /// <param name="D_DT_E">订单日期终</param>
        ///  <param name="D_DT_jh_B">订单日期起</param>
        /// <param name="D_DT_jh_E">订单日期终</param>
        /// <param name="C_LINE_NO">轧线主键</param>
        /// <returns></returns>
        public DataTable GetPlanZX(string C_SFPJ, int? N_EXEC_STATUS, int? N_SFPW, string C_ORDER_NO, string C_CON_NO, string C_STL_GRD, string C_STD_CODE, double? D_SPEC_MIN, double? D_SPEC_MAX, string C_CUST_NAME, string C_JQ_MIN, string C_JQ_MAX, string C_DD_MIN, string C_DD_MAX, string C_LINE_NO)
        {

            return dal.GetPlanZX(C_SFPJ, N_EXEC_STATUS, N_SFPW, C_ORDER_NO, C_CON_NO, C_STL_GRD, C_STD_CODE, D_SPEC_MIN, D_SPEC_MAX, C_CUST_NAME, C_JQ_MIN, C_JQ_MAX, C_DD_MIN, C_DD_MAX, C_LINE_NO);
        }

        public bool ifcz(string order_no)
        {
            return dal.ifcz(order_no);
        }

        /// <summary>
        /// 线材计划汇总
        /// </summary>
        /// <param name="dt1">开始时间</param>
        /// <param name="dt2">结束时间</param>
        /// <returns></returns>
        public DataTable GetXCTJ(string dt1, string dt2)
        {
            return dal.GetXCTJ(dt1, dt2);
        }
        /// <summary>
        /// 销售计划跟踪
        /// </summary>
        /// <param name="begin">开始时间</param>
        /// <param name="end">结束时间</param>
        /// <param name="strSTLGRD">钢种</param>
        /// <param name="strSTD">执行标准</param>
        /// <param name="strSpec">规格</param>
        /// <param name="strCust">工艺路线</param>
        /// <param name="strOrderNo">订单号</param>
        /// <param name="N_EXEC_STATUS">执行状态</param>
        /// <param name="N_SFPW">是否下达</param>
        /// <returns></returns>
        public DataTable GetPlanZX_Query(DateTime begin, DateTime end, string strSTLGRD, string strSTD, string strSpec, string strCust, string strOrderNo, string SFPJ, int? N_EXEC_STATUS, int? N_SFPW, string C_LINE_NO, string c_type)
        {
            return dal.GetPlanZX_Query(begin, end, strSTLGRD, strSTD, strSpec, strCust, strOrderNo, SFPJ, N_EXEC_STATUS, N_SFPW, C_LINE_NO, c_type);
        }

        /// <summary>
        /// 订单线材监控按车间
        /// </summary>
        /// <returns></returns>
        public DataTable GetOrderMonitor_Roll(DateTime start, DateTime end, string roll)
        {
            return dal.GetOrderMonitor_Roll(start, end, roll);
        }

        /// <summary>
        /// 查询不锈钢未完成的计划
        /// </summary>
        /// <param name="dt1">计划查询开始时间</param>
        /// <param name="dt2">计划查询截止时间</param>
        /// <param name="C_STL_GRD">钢种</param>
        /// <param name="C_STD_CODE">执行标准</param>
        /// <param name="C_SPEC">规格</param>
        /// <param name="C_ORDER_NO">订单号</param>
        /// <returns></returns>
        public List<Mod_TMO_ORDER> GetBXGOrder(string dt1, string dt2, string C_STL_GRD, string C_STD_CODE, string C_SPEC, string C_ORDER_NO)
        {
            DataTable dt = dal.GetBXGOrder(dt1, dt2, C_STL_GRD, C_STD_CODE, C_SPEC, C_ORDER_NO);
            return DataTableToList(dt);
        }

        #endregion
    }
}
