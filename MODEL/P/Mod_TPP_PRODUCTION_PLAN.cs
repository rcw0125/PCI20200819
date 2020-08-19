using System;
namespace MODEL
{
    /// <summary>
    /// 订单方案表
    /// </summary>
    [Serializable]
    public partial class Mod_TPP_PRODUCTION_PLAN
    {
        public Mod_TPP_PRODUCTION_PLAN()
        { }
        #region Model
        private string _c_id;
        private string _c_order_no;
        private string _c_con_no;
        private string _c_con_name;
        private string _c_area;
        private string _c_mat_code;
        private string _c_mat_name;
        private string _c_tech_prot;
        private string _c_spec;
        private string _c_stl_grd;
        private string _c_auxi;
        private string _c_unitis;
        private string _c_cust_sq;
        private string _c_pro_use;
        private DateTime? _d_need_dt;
        private DateTime? _d_delivery_dt;
        private DateTime? _d_dt;
        private string _c_free_term;
        private string _c_equation_factor;
        private decimal? _n_num;
        private decimal? _n_wgt;
        private decimal? _n_notax_unitprice;
        private decimal? _n_tax;
        private decimal? _n_nomoney;
        private decimal? _n_pricetax_sum;
        private decimal? _n_dis;
        private decimal? _n_amount_fax;
        private decimal? _n_item_dis;
        private decimal? _n_notax_netprice;
        private decimal? _n_inclutax_netprice;
        private string _c_cgc;
        private string _c_cgarea;
        private string _c_cgaddr;
        private string _c_atstation;
        private string _c_cgman;
        private string _c_cgmobile;
        private string _c_otc;
        private string _c_currency_type;
        private decimal? _n_celing_rate;
        private decimal? _n_dc_notax_unitprice;
        private decimal? _n_dc_inclutax_unitprice;
        private decimal? _n_dc_amount_fax;
        private decimal? _n_dc_pricetax_sum;
        private decimal? _n_delivery_allowance;
        private decimal? _n_is_delivery_close;
        private decimal? _n_is_ot_close;
        private decimal? _n_dia;
        private decimal? _n_mach_wgt;
        private string _c_issue_emp_id;
        private string _c_prd_emp_id;
        private string _c_std_code;
        private string _c_design_no;
        private string _c_design_prog;
        private decimal? _n_slab_match_wgt = 0;
		private decimal? _n_line_match_wgt = 0;
		private decimal? _n_sms_prod_wgt = 0;
		private string _c_sms_prod_emp_id;
        private DateTime? _d_sms_prod_dt;
        private decimal? _n_roll_prod_wgt = 0;
		private string _c_roll_prod_emp_id;
        private DateTime? _c_stl_rol_dt;
        private decimal? _n_prod_wgt = 0;
		private decimal? _n_ware_wgt = 0;
		private decimal? _n_ware_out_wgt = 0;
		private decimal? _n_status = 2;
        private decimal? _n_flag = 0;
        private decimal? _n_type;
        private decimal? _n_exec_status = 0;
        private string _c_pack;
        private decimal? _n_user_lev;
        private decimal? _n_stl_grd_lev;
        private decimal? _n_order_lev;
        private string _c_qualiry_lev;
        private string _c_xg_modify;
        private DateTime? _c_xg_modeify_dt;
        private string _c_line_no;
        private string _c_ccm_no;
        private string _c_remark;
        private string _c_emp_id;
        private string _c_emp_name;
        private DateTime? _d_mod_dt = Convert.ToDateTime(DateTime.Now);
        private decimal? _n_issue_wgt = 0;
		private string _c_cust_no;
        private string _c_cust_name;
        private string _c_sale_channel;
        private DateTime? _d_sys_delivery_dt;
        private string _c_free_term2;
        private string _c_shipvia;
        private string _c_prod_name;
        private string _c_prod_kind;
        private string _c_lev;
        private string _c_dept_id;
        private string _c_sale_emp;
        private string _c_order_lev;
        private string _c_rh;
        private string _c_lf;
        private string _c_kp;
        private decimal? _n_hl_time;
        private string _c_hl;
        private decimal? _n_dfp_hl_time;
        private string _c_dfp_hl;
        private string _c_xm;
        private string _c_production_plan;
        private decimal _n_lgpc_status = 0;
        /// <summary>
        /// 主键
        /// </summary>
        public string C_ID
        {
            set { _c_id = value; }
            get { return _c_id; }
        }
        /// <summary>
        /// 订单号(外键)
        /// </summary>
        public string C_ORDER_NO
        {
            set { _c_order_no = value; }
            get { return _c_order_no; }
        }
        /// <summary>
        /// 合同号(外键)
        /// </summary>
        public string C_CON_NO
        {
            set { _c_con_no = value; }
            get { return _c_con_no; }
        }
        /// <summary>
        /// 合同名称
        /// </summary>
        public string C_CON_NAME
        {
            set { _c_con_name = value; }
            get { return _c_con_name; }
        }
        /// <summary>
        /// 区域
        /// </summary>
        public string C_AREA
        {
            set { _c_area = value; }
            get { return _c_area; }
        }
        /// <summary>
        /// 物料编码
        /// </summary>
        public string C_MAT_CODE
        {
            set { _c_mat_code = value; }
            get { return _c_mat_code; }
        }
        /// <summary>
        /// 物料名称
        /// </summary>
        public string C_MAT_NAME
        {
            set { _c_mat_name = value; }
            get { return _c_mat_name; }
        }
        /// <summary>
        /// 客户协议号
        /// </summary>
        public string C_TECH_PROT
        {
            set { _c_tech_prot = value; }
            get { return _c_tech_prot; }
        }
        /// <summary>
        /// 规格
        /// </summary>
        public string C_SPEC
        {
            set { _c_spec = value; }
            get { return _c_spec; }
        }
        /// <summary>
        /// 钢种
        /// </summary>
        public string C_STL_GRD
        {
            set { _c_stl_grd = value; }
            get { return _c_stl_grd; }
        }
        /// <summary>
        /// 辅单位
        /// </summary>
        public string C_AUXI
        {
            set { _c_auxi = value; }
            get { return _c_auxi; }
        }
        /// <summary>
        /// 单位
        /// </summary>
        public string C_UNITIS
        {
            set { _c_unitis = value; }
            get { return _c_unitis; }
        }
        /// <summary>
        /// 客户特殊要求
        /// </summary>
        public string C_CUST_SQ
        {
            set { _c_cust_sq = value; }
            get { return _c_cust_sq; }
        }
        /// <summary>
        /// 产品用途
        /// </summary>
        public string C_PRO_USE
        {
            set { _c_pro_use = value; }
            get { return _c_pro_use; }
        }
        /// <summary>
        /// 需求日期
        /// </summary>
        public DateTime? D_NEED_DT
        {
            set { _d_need_dt = value; }
            get { return _d_need_dt; }
        }
        /// <summary>
        /// 计划交货日期
        /// </summary>
        public DateTime? D_DELIVERY_DT
        {
            set { _d_delivery_dt = value; }
            get { return _d_delivery_dt; }
        }
        /// <summary>
        /// 订单日期
        /// </summary>
        public DateTime? D_DT
        {
            set { _d_dt = value; }
            get { return _d_dt; }
        }
        /// <summary>
        /// 自由项
        /// </summary>
        public string C_FREE_TERM
        {
            set { _c_free_term = value; }
            get { return _c_free_term; }
        }
        /// <summary>
        /// 换算率
        /// </summary>
        public string C_EQUATION_FACTOR
        {
            set { _c_equation_factor = value; }
            get { return _c_equation_factor; }
        }
        /// <summary>
        /// 辅助量
        /// </summary>
        public decimal? N_NUM
        {
            set { _n_num = value; }
            get { return _n_num; }
        }
        /// <summary>
        /// 数量
        /// </summary>
        public decimal? N_WGT
        {
            set { _n_wgt = value; }
            get { return _n_wgt; }
        }
        /// <summary>
        /// 无税单价
        /// </summary>
        public decimal? N_NOTAX_UNITPRICE
        {
            set { _n_notax_unitprice = value; }
            get { return _n_notax_unitprice; }
        }
        /// <summary>
        /// 税率
        /// </summary>
        public decimal? N_TAX
        {
            set { _n_tax = value; }
            get { return _n_tax; }
        }
        /// <summary>
        /// 无税金额
        /// </summary>
        public decimal? N_NOMONEY
        {
            set { _n_nomoney = value; }
            get { return _n_nomoney; }
        }
        /// <summary>
        /// 价税合计
        /// </summary>
        public decimal? N_PRICETAX_SUM
        {
            set { _n_pricetax_sum = value; }
            get { return _n_pricetax_sum; }
        }
        /// <summary>
        /// 整单折扣
        /// </summary>
        public decimal? N_DIS
        {
            set { _n_dis = value; }
            get { return _n_dis; }
        }
        /// <summary>
        /// 税额
        /// </summary>
        public decimal? N_AMOUNT_FAX
        {
            set { _n_amount_fax = value; }
            get { return _n_amount_fax; }
        }
        /// <summary>
        /// 单品折扣
        /// </summary>
        public decimal? N_ITEM_DIS
        {
            set { _n_item_dis = value; }
            get { return _n_item_dis; }
        }
        /// <summary>
        /// 无税净价
        /// </summary>
        public decimal? N_NOTAX_NETPRICE
        {
            set { _n_notax_netprice = value; }
            get { return _n_notax_netprice; }
        }
        /// <summary>
        /// 含税净价
        /// </summary>
        public decimal? N_INCLUTAX_NETPRICE
        {
            set { _n_inclutax_netprice = value; }
            get { return _n_inclutax_netprice; }
        }
        /// <summary>
        /// 收货单位
        /// </summary>
        public string C_CGC
        {
            set { _c_cgc = value; }
            get { return _c_cgc; }
        }
        /// <summary>
        /// 收货地区
        /// </summary>
        public string C_CGAREA
        {
            set { _c_cgarea = value; }
            get { return _c_cgarea; }
        }
        /// <summary>
        /// 收货地址
        /// </summary>
        public string C_CGADDR
        {
            set { _c_cgaddr = value; }
            get { return _c_cgaddr; }
        }
        /// <summary>
        /// 到站
        /// </summary>
        public string C_ATSTATION
        {
            set { _c_atstation = value; }
            get { return _c_atstation; }
        }
        /// <summary>
        /// 收货人
        /// </summary>
        public string C_CGMAN
        {
            set { _c_cgman = value; }
            get { return _c_cgman; }
        }
        /// <summary>
        /// 收货电话
        /// </summary>
        public string C_CGMOBILE
        {
            set { _c_cgmobile = value; }
            get { return _c_cgmobile; }
        }
        /// <summary>
        /// 开票单位
        /// </summary>
        public string C_OTC
        {
            set { _c_otc = value; }
            get { return _c_otc; }
        }
        /// <summary>
        /// 币种
        /// </summary>
        public string C_CURRENCY_TYPE
        {
            set { _c_currency_type = value; }
            get { return _c_currency_type; }
        }
        /// <summary>
        /// 折本汇率
        /// </summary>
        public decimal? N_CELING_RATE
        {
            set { _n_celing_rate = value; }
            get { return _n_celing_rate; }
        }
        /// <summary>
        /// 本币无税单价
        /// </summary>
        public decimal? N_DC_NOTAX_UNITPRICE
        {
            set { _n_dc_notax_unitprice = value; }
            get { return _n_dc_notax_unitprice; }
        }
        /// <summary>
        /// 本币含税单价
        /// </summary>
        public decimal? N_DC_INCLUTAX_UNITPRICE
        {
            set { _n_dc_inclutax_unitprice = value; }
            get { return _n_dc_inclutax_unitprice; }
        }
        /// <summary>
        /// 本币税额
        /// </summary>
        public decimal? N_DC_AMOUNT_FAX
        {
            set { _n_dc_amount_fax = value; }
            get { return _n_dc_amount_fax; }
        }
        /// <summary>
        /// 本币价税合计
        /// </summary>
        public decimal? N_DC_PRICETAX_SUM
        {
            set { _n_dc_pricetax_sum = value; }
            get { return _n_dc_pricetax_sum; }
        }
        /// <summary>
        /// 发货上允差
        /// </summary>
        public decimal? N_DELIVERY_ALLOWANCE
        {
            set { _n_delivery_allowance = value; }
            get { return _n_delivery_allowance; }
        }
        /// <summary>
        /// 是否发货关闭
        /// </summary>
        public decimal? N_IS_DELIVERY_CLOSE
        {
            set { _n_is_delivery_close = value; }
            get { return _n_is_delivery_close; }
        }
        /// <summary>
        /// 是否开票关闭
        /// </summary>
        public decimal? N_IS_OT_CLOSE
        {
            set { _n_is_ot_close = value; }
            get { return _n_is_ot_close; }
        }
        /// <summary>
        /// 直径
        /// </summary>
        public decimal? N_DIA
        {
            set { _n_dia = value; }
            get { return _n_dia; }
        }
        /// <summary>
        /// 机时产量
        /// </summary>
        public decimal? N_MACH_WGT
        {
            set { _n_mach_wgt = value; }
            get { return _n_mach_wgt; }
        }
        /// <summary>
        /// 下发人
        /// </summary>
        public string C_ISSUE_EMP_ID
        {
            set { _c_issue_emp_id = value; }
            get { return _c_issue_emp_id; }
        }
        /// <summary>
        /// 排产人
        /// </summary>
        public string C_PRD_EMP_ID
        {
            set { _c_prd_emp_id = value; }
            get { return _c_prd_emp_id; }
        }
        /// <summary>
        /// 执行标准
        /// </summary>
        public string C_STD_CODE
        {
            set { _c_std_code = value; }
            get { return _c_std_code; }
        }
        /// <summary>
        /// 质量设计号
        /// </summary>
        public string C_DESIGN_NO
        {
            set { _c_design_no = value; }
            get { return _c_design_no; }
        }
        /// <summary>
        /// 质量设计进程
        /// </summary>
        public string C_DESIGN_PROG
        {
            set { _c_design_prog = value; }
            get { return _c_design_prog; }
        }
        /// <summary>
        /// 钢坯库存匹配量
        /// </summary>
        public decimal? N_SLAB_MATCH_WGT
        {
            set { _n_slab_match_wgt = value; }
            get { return _n_slab_match_wgt; }
        }
        /// <summary>
        /// 线材库存匹配量
        /// </summary>
        public decimal? N_LINE_MATCH_WGT
        {
            set { _n_line_match_wgt = value; }
            get { return _n_line_match_wgt; }
        }
        /// <summary>
        /// 炼钢排产量
        /// </summary>
        public decimal? N_SMS_PROD_WGT
        {
            set { _n_sms_prod_wgt = value; }
            get { return _n_sms_prod_wgt; }
        }
        /// <summary>
        /// 炼钢排产人
        /// </summary>
        public string C_SMS_PROD_EMP_ID
        {
            set { _c_sms_prod_emp_id = value; }
            get { return _c_sms_prod_emp_id; }
        }
        /// <summary>
        /// 炼钢排产时间
        /// </summary>
        public DateTime? D_SMS_PROD_DT
        {
            set { _d_sms_prod_dt = value; }
            get { return _d_sms_prod_dt; }
        }
        /// <summary>
        /// 轧钢排产量
        /// </summary>
        public decimal? N_ROLL_PROD_WGT
        {
            set { _n_roll_prod_wgt = value; }
            get { return _n_roll_prod_wgt; }
        }
        /// <summary>
        /// 轧钢排产人
        /// </summary>
        public string C_ROLL_PROD_EMP_ID
        {
            set { _c_roll_prod_emp_id = value; }
            get { return _c_roll_prod_emp_id; }
        }
        /// <summary>
        /// 轧钢排产时间
        /// </summary>
        public DateTime? C_STL_ROL_DT
        {
            set { _c_stl_rol_dt = value; }
            get { return _c_stl_rol_dt; }
        }
        /// <summary>
        /// 生产量
        /// </summary>
        public decimal? N_PROD_WGT
        {
            set { _n_prod_wgt = value; }
            get { return _n_prod_wgt; }
        }
        /// <summary>
        /// 库存量
        /// </summary>
        public decimal? N_WARE_WGT
        {
            set { _n_ware_wgt = value; }
            get { return _n_ware_wgt; }
        }
        /// <summary>
        /// 出库量
        /// </summary>
        public decimal? N_WARE_OUT_WGT
        {
            set { _n_ware_out_wgt = value; }
            get { return _n_ware_out_wgt; }
        }
        /// <summary>
        /// 订单状态：2生效
        /// </summary>
        public decimal? N_STATUS
        {
            set { _n_status = value; }
            get { return _n_status; }
        }
        /// <summary>
        /// 默认0正常
        /// </summary>
        public decimal? N_FLAG
        {
            set { _n_flag = value; }
            get { return _n_flag; }
        }
        /// <summary>
        /// 订单类型: 8 线材，6 钢坯
        /// </summary>
        public decimal? N_TYPE
        {
            set { _n_type = value; }
            get { return _n_type; }
        }
        /// <summary>
        /// 执行状态(0未排产，1已排产)
        /// </summary>
        public decimal? N_EXEC_STATUS
        {
            set { _n_exec_status = value; }
            get { return _n_exec_status; }
        }
        /// <summary>
        /// 包装要求
        /// </summary>
        public string C_PACK
        {
            set { _c_pack = value; }
            get { return _c_pack; }
        }
        /// <summary>
        /// 客户等级
        /// </summary>
        public decimal? N_USER_LEV
        {
            set { _n_user_lev = value; }
            get { return _n_user_lev; }
        }
        /// <summary>
        /// 钢种等级
        /// </summary>
        public decimal? N_STL_GRD_LEV
        {
            set { _n_stl_grd_lev = value; }
            get { return _n_stl_grd_lev; }
        }
        /// <summary>
        /// 订单等级
        /// </summary>
        public decimal? N_ORDER_LEV
        {
            set { _n_order_lev = value; }
            get { return _n_order_lev; }
        }
        /// <summary>
        /// 质量等级
        /// </summary>
        public string C_QUALIRY_LEV
        {
            set { _c_qualiry_lev = value; }
            get { return _c_qualiry_lev; }
        }
        /// <summary>
        /// 型钢修改人
        /// </summary>
        public string C_XG_MODIFY
        {
            set { _c_xg_modify = value; }
            get { return _c_xg_modify; }
        }
        /// <summary>
        /// 型钢修改日期
        /// </summary>
        public DateTime? C_XG_MODEIFY_DT
        {
            set { _c_xg_modeify_dt = value; }
            get { return _c_xg_modeify_dt; }
        }
        /// <summary>
        /// 线材编号
        /// </summary>
        public string C_LINE_NO
        {
            set { _c_line_no = value; }
            get { return _c_line_no; }
        }
        /// <summary>
        /// 连铸编号
        /// </summary>
        public string C_CCM_NO
        {
            set { _c_ccm_no = value; }
            get { return _c_ccm_no; }
        }
        /// <summary>
        /// 备注
        /// </summary>
        public string C_REMARK
        {
            set { _c_remark = value; }
            get { return _c_remark; }
        }
        /// <summary>
        /// 系统操作人编号
        /// </summary>
        public string C_EMP_ID
        {
            set { _c_emp_id = value; }
            get { return _c_emp_id; }
        }
        /// <summary>
        /// 系统操作人姓名
        /// </summary>
        public string C_EMP_NAME
        {
            set { _c_emp_name = value; }
            get { return _c_emp_name; }
        }
        /// <summary>
        /// 系系统操作时间
        /// </summary>
        public DateTime? D_MOD_DT
        {
            set { _d_mod_dt = value; }
            get { return _d_mod_dt; }
        }
        /// <summary>
        /// 已下发量
        /// </summary>
        public decimal? N_ISSUE_WGT
        {
            set { _n_issue_wgt = value; }
            get { return _n_issue_wgt; }
        }
        /// <summary>
        /// 客户编码
        /// </summary>
        public string C_CUST_NO
        {
            set { _c_cust_no = value; }
            get { return _c_cust_no; }
        }
        /// <summary>
        /// 客户名称
        /// </summary>
        public string C_CUST_NAME
        {
            set { _c_cust_name = value; }
            get { return _c_cust_name; }
        }
        /// <summary>
        /// 分销类别（直销/经销）
        /// </summary>
        public string C_SALE_CHANNEL
        {
            set { _c_sale_channel = value; }
            get { return _c_sale_channel; }
        }
        /// <summary>
        /// 系统推荐交货日期
        /// </summary>
        public DateTime? D_SYS_DELIVERY_DT
        {
            set { _d_sys_delivery_dt = value; }
            get { return _d_sys_delivery_dt; }
        }
        /// <summary>
        /// 自由项2
        /// </summary>
        public string C_FREE_TERM2
        {
            set { _c_free_term2 = value; }
            get { return _c_free_term2; }
        }
        /// <summary>
        /// 运输方式
        /// </summary>
        public string C_SHIPVIA
        {
            set { _c_shipvia = value; }
            get { return _c_shipvia; }
        }
        /// <summary>
        /// 类别
        /// </summary>
        public string C_PROD_NAME
        {
            set { _c_prod_name = value; }
            get { return _c_prod_name; }
        }
        /// <summary>
        /// 品种
        /// </summary>
        public string C_PROD_KIND
        {
            set { _c_prod_kind = value; }
            get { return _c_prod_kind; }
        }
        /// <summary>
        /// 维护等级：普通/买断/重点钢种/重点钢种买断
        /// </summary>
        public string C_LEV
        {
            set { _c_lev = value; }
            get { return _c_lev; }
        }
        /// <summary>
        /// 业务部门
        /// </summary>
        public string C_DEPT_ID
        {
            set { _c_dept_id = value; }
            get { return _c_dept_id; }
        }
        /// <summary>
        /// 业务员
        /// </summary>
        public string C_SALE_EMP
        {
            set { _c_sale_emp = value; }
            get { return _c_sale_emp; }
        }
        /// <summary>
        /// 订单等级
        /// </summary>
        public string C_ORDER_LEV
        {
            set { _c_order_lev = value; }
            get { return _c_order_lev; }
        }
        /// <summary>
        /// 过真空
        /// </summary>
        public string C_RH
        {
            set { _c_rh = value; }
            get { return _c_rh; }
        }
        /// <summary>
        /// 精炼
        /// </summary>
        public string C_LF
        {
            set { _c_lf = value; }
            get { return _c_lf; }
        }
        /// <summary>
        /// 开坯
        /// </summary>
        public string C_KP
        {
            set { _c_kp = value; }
            get { return _c_kp; }
        }
        /// <summary>
        /// 缓冷时间
        /// </summary>
        public decimal? N_HL_TIME
        {
            set { _n_hl_time = value; }
            get { return _n_hl_time; }
        }
        /// <summary>
        /// 缓冷
        /// </summary>
        public string C_HL
        {
            set { _c_hl = value; }
            get { return _c_hl; }
        }
        /// <summary>
        /// 大方坯缓冷时间
        /// </summary>
        public decimal? N_DFP_HL_TIME
        {
            set { _n_dfp_hl_time = value; }
            get { return _n_dfp_hl_time; }
        }
        /// <summary>
        /// 大方坯缓冷
        /// </summary>
        public string C_DFP_HL
        {
            set { _c_dfp_hl = value; }
            get { return _c_dfp_hl; }
        }
        /// <summary>
        /// 修磨
        /// </summary>
        public string C_XM
        {
            set { _c_xm = value; }
            get { return _c_xm; }
        }
        /// <summary>
        /// 订单方案号
        /// </summary>
        public string C_PRODUCTION_PLAN
        {
            set { _c_production_plan = value; }
            get { return _c_production_plan; }
        }
        /// <summary>
        /// 炼钢排产状态(0未排产，1已排产)
        /// </summary>
        public decimal N_LGPC_STATUS
        {
            set { _n_lgpc_status = value; }
            get { return _n_lgpc_status; }
        }
        #endregion Model
    }
}
