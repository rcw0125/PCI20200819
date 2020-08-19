using System;
namespace MODEL
{

    /// <summary>
    /// 订单池
    /// </summary>
    [Serializable]
    public partial class Mod_TMO_ORDER
    {
        public Mod_TMO_ORDER()
        { }
        private bool _b_check = false;
        //private string _order_type = "线材";//线材/自备坯/外销坯

        #region Model
        private string _c_id;
        private string _c_order_no;
        private string _c_con_no;
        private string _c_con_name;
        private string _c_area;
        private string _c_cust_no;
        private string _c_cust_name;
        private string _c_sale_channel;
        private string _c_currencytypeid;
        private string _c_receiptareaid;
        private string _c_receiveaddress;
        private string _c_receiptcorpid;
        private string _c_prod_name;
        private string _c_prod_kind;
        private string _c_invbasdocid;
        private string _c_inventoryid;
        private string _c_mat_code;
        private string _c_mat_name;
        private string _c_stl_grd;
        private string _c_spec;
        private string _c_tech_prot;
        private string _c_free1;
        private string _c_free2;
        private string _c_pack;
        private string _c_std_code;
        private string _c_design_no;
        private string _c_stdid;
        private string _c_designid;
        private string _c_vdef1;
        private string _c_pro_use;
        private string _c_cust_sq;
        private string _c_funitid;
        private string _c_unitid;
        private decimal? _n_hsl;
        private decimal? _n_fnum;
        private decimal _n_wgt = 0;
        private decimal? _n_profit;
        private decimal? _n_cost;
        private decimal? _n_taxrate;
        private decimal? _n_originalcurprice;
        private decimal? _n_originalcurtaxprice;
        private decimal? _n_originalcurtaxmny;
        private decimal? _n_originalcurmny;
        private decimal? _n_originalcursummny;
        private DateTime? _d_need_dt;
        private DateTime? _d_delivery_dt;
        private DateTime? _d_dt = DateTime.Now;
        private decimal _n_status = -1M;
        private decimal? _n_type;
        private decimal? _n_flag = 0M;
        private decimal _n_exec_status = -2M;
        private decimal? _n_user_lev;
        private string _c_lev;
        private string _c_order_lev;
        private string _c_remark;
        private string _c_emp_id;
        private string _c_emp_name;
        private DateTime _d_mod_dt = DateTime.Now;
        private decimal _n_slab_match_wgt = 0M;
        private decimal _n_line_match_wgt = 0M;
        private decimal _n_prod_wgt = 0M;
        private decimal _n_ware_wgt = 0M;
        private decimal _n_ware_out_wgt = 0M;
        private decimal? _n_mach_wgt;
        private string _c_issue_emp_id;
        private string _c_prd_emp_id;
        private string _c_design_prog;
        private decimal _n_sms_prod_wgt = 0M;
        private string _c_sms_prod_emp_id;
        private DateTime? _d_sms_prod_dt;
        private decimal _n_roll_prod_wgt = 0M;
        private string _c_roll_prod_emp_id;
        private DateTime? _d_stl_rol_dt;
        private string _c_line_no;
        private string _c_ccm_no;
        private decimal? _n_issue_wgt = 0M;
        private string _c_rh;
        private string _c_lf;
        private string _c_kp;
        private decimal _n_hl_time = 0M;
        private string _c_hl;
        private decimal _n_dfp_hl_time = 0M;
        private string _c_dfp_hl;
        private string _c_xm;
        private string _c_route;
        private string _c_matrl_code_slab;
        private string _c_matrl_name_slab;
        private string _c_slab_size;
        private decimal? _n_slab_length;
        private decimal? _n_slab_pw;
        private string _c_matrl_code_kp;
        private string _c_matrl_name_kp;
        private string _c_kp_size;
        private decimal? _n_kp_length;
        private decimal? _n_kp_pw;
        private decimal? _n_group;
        private decimal? _n_sort;
        private string _c_xc;
        private string _c_sl;
        private string _c_wl;
        private string _c_sfpj = "N";
        private string _c_transmode;
        private decimal? _n_mach_wgt_ccm;
        private string _c_xgid = "1001";
        private decimal? _n_zjcls = 0M;
        private string _c_by1;
        private string _c_by2;
        private string _c_by3;
        private string _c_by4 = "0";
        private string _c_by5;
        private string _c_nc_id;
        private string _c_lgjh;
        private string _c_zldj_id;
        private string _c_zl_id;
        private string _c_lf_id;
        private string _c_rh_id;
        private decimal? _n_slab_width;
        private decimal? _n_slab_thick;
        private decimal? _n_diameter;
        private DateTime? _d_nc_date;
        private string _c_ywy;
        private string _c_nc_salecode;
        private string _c_transmodeid;
        private string _c_dfp_rz;
        private string _c_rzp_rz;
        private string _c_dfp_yq;
        private string _c_rzp_yq;
        private string _c_xm_yq;
        private decimal? _n_jrl_wd;
        private decimal? _n_jrl_sj;
        private decimal? _n_kpjrl_wd;
        private decimal? _n_kpjrl_sj;
        private decimal? _n_tsl;
        private string _c_roll_code;
        private string _c_ccm_code;
        private string _c_roll_desc;
        private string _c_ccm_desc;
        private string _c_tl;
        private decimal? _n_zjcls_min = 0M;
        private decimal? _n_zjcls_max = 0M;
        private string _c_ncstatus = "0";
        private string _c_pclx;
        private string _c_stl_grd_type;
        private DateTime? _d_ns_send_dt;
        private string _c_order_no_old;
        private string _c_stl_grd_slab;
        private string _c_std_code_slab;
        private string _c_pctbemp;
        private DateTime? _d_pctbts;
        private string _c_sfjk = "N";
        private string _c_stl_grd_class;
        private decimal? _n_length;
        private decimal? _n_hg_wgt = 0M;
		private decimal? _n_dp_wgt = 0M;
		private decimal? _n_gp_wgt = 0M;
		private decimal? _n_xy_wgt = 0M;
		private decimal? _n_tw_wgt = 0M;
		private decimal? _n_bhg_wgt = 0M;
		private decimal? _n_hg_wgt_in = 0M;
		private decimal? _n_gp_wgt_in = 0M;
		private decimal? _n_xy_wgt_in = 0M;
		private decimal? _n_tw_wgt_in = 0M;
		private decimal? _n_bhg_wgt_in = 0M;
		private decimal? _n_hg_wgt_out = 0M;
		private decimal? _n_gp_wgt_out = 0M;
		private decimal? _n_xy_wgt_out = 0M;
		private decimal? _n_tw_wgt_out = 0M;
		private decimal? _n_bhg_wgt_out = 0M;
		private DateTime? _d_sale_time_min;
        private DateTime? _d_sale_time_max;
        private DateTime? _d_produce_date_min;
        private DateTime? _d_produce_date_max;
        private decimal? _n_slab_xc_wgt = 0M;
		private decimal? _n_roll_xc_wgt = 0M;
        private DateTime? _d_old_date;
        private decimal? _n_roll_wgt;
        private string _c_remark1;
        private string _c_remark2;
        private string _c_remark3;
        private string _c_remark4;
        private string _c_remark5;
        private DateTime? _d_sc_mod_dt;

        private decimal? _n_slab_xh_wgt;
        private string _c_slab_type;
        private DateTime? _d_old_need_date;
        private DateTime? _d_pj_date;
        private DateTime? _d_date_by1;
        private DateTime? _d_date_by2;
        private DateTime? _d_date_by3;
        private DateTime? _d_date_by4;
        private DateTime? _d_date_by5;
        private DateTime? _d_date_by6;
        /// <summary>
        /// 主键
        /// </summary>
        public string C_ID
        {
            set { _c_id = value; }
            get { return _c_id; }
        }
        /// <summary>
        /// 订单号(主键)
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
        /// 分销类别（2直销/1经销）
        /// </summary>
        public string C_SALE_CHANNEL
        {
            set { _c_sale_channel = value; }
            get { return _c_sale_channel; }
        }
        /// <summary>
        /// 货币主键
        /// </summary>
        public string C_CURRENCYTYPEID
        {
            set { _c_currencytypeid = value; }
            get { return _c_currencytypeid; }
        }
        /// <summary>
        /// 收货地区
        /// </summary>
        public string C_RECEIPTAREAID
        {
            set { _c_receiptareaid = value; }
            get { return _c_receiptareaid; }
        }
        /// <summary>
        /// 收货地址
        /// </summary>
        public string C_RECEIVEADDRESS
        {
            set { _c_receiveaddress = value; }
            get { return _c_receiveaddress; }
        }
        /// <summary>
        /// 收货单位
        /// </summary>
        public string C_RECEIPTCORPID
        {
            set { _c_receiptcorpid = value; }
            get { return _c_receiptcorpid; }
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
        /// 存货档案主键
        /// </summary>
        public string C_INVBASDOCID
        {
            set { _c_invbasdocid = value; }
            get { return _c_invbasdocid; }
        }
        /// <summary>
        /// 存货管理档案主键
        /// </summary>
        public string C_INVENTORYID
        {
            set { _c_inventoryid = value; }
            get { return _c_inventoryid; }
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
        /// 钢种
        /// </summary>
        public string C_STL_GRD
        {
            set { _c_stl_grd = value; }
            get { return _c_stl_grd; }
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
        /// 客户协议号
        /// </summary>
        public string C_TECH_PROT
        {
            set { _c_tech_prot = value; }
            get { return _c_tech_prot; }
        }
        /// <summary>
        /// 自由项1
        /// </summary>
        public string C_FREE1
        {
            set { _c_free1 = value; }
            get { return _c_free1; }
        }
        /// <summary>
        /// 自由项2
        /// </summary>
        public string C_FREE2
        {
            set { _c_free2 = value; }
            get { return _c_free2; }
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
        /// 执行标准主键
        /// </summary>
        public string C_STDID
        {
            set { _c_stdid = value; }
            get { return _c_stdid; }
        }
        /// <summary>
        /// 质量设计主键
        /// </summary>
        public string C_DESIGNID
        {
            set { _c_designid = value; }
            get { return _c_designid; }
        }
        /// <summary>
        /// 质量等级主键
        /// </summary>
        public string C_VDEF1
        {
            set { _c_vdef1 = value; }
            get { return _c_vdef1; }
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
        /// 客户特殊要求
        /// </summary>
        public string C_CUST_SQ
        {
            set { _c_cust_sq = value; }
            get { return _c_cust_sq; }
        }
        /// <summary>
        /// 辅单位
        /// </summary>
        public string C_FUNITID
        {
            set { _c_funitid = value; }
            get { return _c_funitid; }
        }
        /// <summary>
        /// 主计量单位
        /// </summary>
        public string C_UNITID
        {
            set { _c_unitid = value; }
            get { return _c_unitid; }
        }
        /// <summary>
        /// 换算率
        /// </summary>
        public decimal? N_HSL
        {
            set { _n_hsl = value; }
            get { return _n_hsl; }
        }
        /// <summary>
        /// 辅助量
        /// </summary>
        public decimal? N_FNUM
        {
            set { _n_fnum = value; }
            get { return _n_fnum; }
        }
        /// <summary>
        /// 数量 订单重量
        /// </summary>
        public decimal N_WGT
        {
            set { _n_wgt = value; }
            get { return _n_wgt; }
        }
        /// <summary>
        /// 利润
        /// </summary>
        public decimal? N_PROFIT
        {
            set { _n_profit = value; }
            get { return _n_profit; }
        }
        /// <summary>
        /// 成本
        /// </summary>
        public decimal? N_COST
        {
            set { _n_cost = value; }
            get { return _n_cost; }
        }
        /// <summary>
        /// 税率
        /// </summary>
        public decimal? N_TAXRATE
        {
            set { _n_taxrate = value; }
            get { return _n_taxrate; }
        }
        /// <summary>
        /// 原币无税单价
        /// </summary>
        public decimal? N_ORIGINALCURPRICE
        {
            set { _n_originalcurprice = value; }
            get { return _n_originalcurprice; }
        }
        /// <summary>
        /// 原币含税单价
        /// </summary>
        public decimal? N_ORIGINALCURTAXPRICE
        {
            set { _n_originalcurtaxprice = value; }
            get { return _n_originalcurtaxprice; }
        }
        /// <summary>
        /// 原币税额
        /// </summary>
        public decimal? N_ORIGINALCURTAXMNY
        {
            set { _n_originalcurtaxmny = value; }
            get { return _n_originalcurtaxmny; }
        }
        /// <summary>
        /// 原币无税金额
        /// </summary>
        public decimal? N_ORIGINALCURMNY
        {
            set { _n_originalcurmny = value; }
            get { return _n_originalcurmny; }
        }
        /// <summary>
        /// 原币价税合计
        /// </summary>
        public decimal? N_ORIGINALCURSUMMNY
        {
            set { _n_originalcursummny = value; }
            get { return _n_originalcursummny; }
        }
        /// <summary>
        /// 场内生产需求日期
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
        /// 合同状态：-1未提交，0待审，1审核中，2生效，3变更, 4 审核通过,5冻结,6终止
        /// </summary>
        public decimal N_STATUS
        {
            set { _n_status = value; }
            get { return _n_status; }
        }
        /// <summary>
        /// 订单类型: 6 钢坯，8线材,851渣，841焦化，831废材,(805,806,807委外线材),10 首尾炉订单，11 停用首尾炉订单
        /// </summary>
        public decimal? N_TYPE
        {
            set { _n_type = value; }
            get { return _n_type; }
        }
        /// <summary>
        /// 计划类型0正常订单，1虚拟订单
        /// </summary>
        public decimal? N_FLAG
        {
            set { _n_flag = value; }
            get { return _n_flag; }
        }
        /// <summary>
        /// 执行状态: -2各区销售未提交排产,-1销售已提交， 0正常 ，5人为关闭，6生产完成,7库存货
        /// </summary>
        public decimal N_EXEC_STATUS
        {
            set { _n_exec_status = value; }
            get { return _n_exec_status; }
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
        /// 钢种等级：普通/买断/重点钢种/重点钢种买断
        /// </summary>
        public string C_LEV
        {
            set { _c_lev = value; }
            get { return _c_lev; }
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
        /// 系统操作时间
        /// </summary>
        public DateTime D_MOD_DT
        {
            set { _d_mod_dt = value; }
            get { return _d_mod_dt; }
        }
        /// <summary>
        /// 钢坯库存匹配量
        /// </summary>
        public decimal N_SLAB_MATCH_WGT
        {
            set { _n_slab_match_wgt = value; }
            get { return _n_slab_match_wgt; }
        }
        /// <summary>
        /// 线材库存匹配量
        /// </summary>
        public decimal N_LINE_MATCH_WGT
        {
            set { _n_line_match_wgt = value; }
            get { return _n_line_match_wgt; }
        }
        /// <summary>
        /// 生产量
        /// </summary>
        public decimal N_PROD_WGT
        {
            set { _n_prod_wgt = value; }
            get { return _n_prod_wgt; }
        }
        /// <summary>
        /// 库存量
        /// </summary>
        public decimal N_WARE_WGT
        {
            set { _n_ware_wgt = value; }
            get { return _n_ware_wgt; }
        }
        /// <summary>
        /// 出库量
        /// </summary>
        public decimal N_WARE_OUT_WGT
        {
            set { _n_ware_out_wgt = value; }
            get { return _n_ware_out_wgt; }
        }
        /// <summary>
        /// 机时产量（轧钢）
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
        /// 质量设计进程
        /// </summary>
        public string C_DESIGN_PROG
        {
            set { _c_design_prog = value; }
            get { return _c_design_prog; }
        }
        /// <summary>
        /// 炼钢排产量
        /// </summary>
        public decimal N_SMS_PROD_WGT
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
        public decimal N_ROLL_PROD_WGT
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
        public DateTime? D_STL_ROL_DT
        {
            set { _d_stl_rol_dt = value; }
            get { return _d_stl_rol_dt; }
        }
        /// <summary>
        /// 轧线编号
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
        /// 已下发量
        /// </summary>
        public decimal? N_ISSUE_WGT
        {
            set { _n_issue_wgt = value; }
            get { return _n_issue_wgt; }
        }
        /// <summary>
        /// 过真空O Y/N
        /// </summary>
        public string C_RH
        {
            set { _c_rh = value; }
            get { return _c_rh; }
        }
        /// <summary>
        /// 精炼O Y/N
        /// </summary>
        public string C_LF
        {
            set { _c_lf = value; }
            get { return _c_lf; }
        }
        /// <summary>
        /// 开坯O Y/N
        /// </summary>
        public string C_KP
        {
            set { _c_kp = value; }
            get { return _c_kp; }
        }
        /// <summary>
        /// 缓冷时间
        /// </summary>
        public decimal N_HL_TIME
        {
            set { _n_hl_time = value; }
            get { return _n_hl_time; }
        }
        /// <summary>
        /// 缓冷 O CODE
        /// </summary>
        public string C_HL
        {
            set { _c_hl = value; }
            get { return _c_hl; }
        }
        /// <summary>
        /// 大方坯缓冷时间
        /// </summary>
        public decimal N_DFP_HL_TIME
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
        /// 修磨 O -C_COPING_CRAFT
        /// </summary>
        public string C_XM
        {
            set { _c_xm = value; }
            get { return _c_xm; }
        }
        /// <summary>
        /// 工艺路线 O
        /// </summary>
        public string C_ROUTE
        {
            set { _c_route = value; }
            get { return _c_route; }
        }
        /// <summary>
        /// 连铸钢坯物料号
        /// </summary>
        public string C_MATRL_CODE_SLAB
        {
            set { _c_matrl_code_slab = value; }
            get { return _c_matrl_code_slab; }
        }
        /// <summary>
        /// 连铸钢坯物料名称
        /// </summary>
        public string C_MATRL_NAME_SLAB
        {
            set { _c_matrl_name_slab = value; }
            get { return _c_matrl_name_slab; }
        }
        /// <summary>
        /// 连铸钢坯断面
        /// </summary>
        public string C_SLAB_SIZE
        {
            set { _c_slab_size = value; }
            get { return _c_slab_size; }
        }
        /// <summary>
        /// 连铸钢坯定尺
        /// </summary>
        public decimal? N_SLAB_LENGTH
        {
            set { _n_slab_length = value; }
            get { return _n_slab_length; }
        }
        /// <summary>
        /// 连铸钢坯理论单重
        /// </summary>
        public decimal? N_SLAB_PW
        {
            set { _n_slab_pw = value; }
            get { return _n_slab_pw; }
        }
        /// <summary>
        /// 开坯钢坯物料号
        /// </summary>
        public string C_MATRL_CODE_KP
        {
            set { _c_matrl_code_kp = value; }
            get { return _c_matrl_code_kp; }
        }
        /// <summary>
        /// 开坯钢坯物料名称
        /// </summary>
        public string C_MATRL_NAME_KP
        {
            set { _c_matrl_name_kp = value; }
            get { return _c_matrl_name_kp; }
        }
        /// <summary>
        /// 开坯钢坯断面
        /// </summary>
        public string C_KP_SIZE
        {
            set { _c_kp_size = value; }
            get { return _c_kp_size; }
        }
        /// <summary>
        /// 开坯钢坯定尺
        /// </summary>
        public decimal? N_KP_LENGTH
        {
            set { _n_kp_length = value; }
            get { return _n_kp_length; }
        }
        /// <summary>
        /// 开坯钢坯理论单重
        /// </summary>
        public decimal? N_KP_PW
        {
            set { _n_kp_pw = value; }
            get { return _n_kp_pw; }
        }
        /// <summary>
        /// 分组号
        /// </summary>
        public decimal? N_GROUP
        {
            set { _n_group = value; }
            get { return _n_group; }
        }
        /// <summary>
        /// 分组排序号
        /// </summary>
        public decimal? N_SORT
        {
            set { _n_sort = value; }
            get { return _n_sort; }
        }
        /// <summary>
        /// 能否洗槽O CODE
        /// </summary>
        public string C_XC
        {
            set { _c_xc = value; }
            get { return _c_xc; }
        }
        /// <summary>
        /// 是否需要首炉钢种O CODE
        /// </summary>
        public string C_SL
        {
            set { _c_sl = value; }
            get { return _c_sl; }
        }
        /// <summary>
        /// 是否需要尾炉钢种O CODE
        /// </summary>
        public string C_WL
        {
            set { _c_wl = value; }
            get { return _c_wl; }
        }
        /// <summary>
        /// 订单是否评价 N/Y
        /// </summary>
        public string C_SFPJ
        {
            set { _c_sfpj = value; }
            get { return _c_sfpj; }
        }
        /// <summary>
        /// 发运方式
        /// </summary>
        public string C_TRANSMODE
        {
            set { _c_transmode = value; }
            get { return _c_transmode; }
        }
        /// <summary>
        /// 机时产量（连铸）
        /// </summary>
        public decimal? N_MACH_WGT_CCM
        {
            set { _n_mach_wgt_ccm = value; }
            get { return _n_mach_wgt_ccm; }
        }
        /// <summary>
        /// 公司ID
        /// </summary>
        public string C_XGID
        {
            set { _c_xgid = value; }
            get { return _c_xgid; }
        }
        /// <summary>
        /// 整浇次炉数
        /// </summary>
        public decimal? N_ZJCLS
        {
            set { _n_zjcls = value; }
            get { return _n_zjcls; }
        }
        /// <summary>
        /// 钢坯自由项1
        /// </summary>
        public string C_BY1
        {
            set { _c_by1 = value; }
            get { return _c_by1; }
        }
        /// <summary>
        /// 钢坯自由项2
        /// </summary>
        public string C_BY2
        {
            set { _c_by2 = value; }
            get { return _c_by2; }
        }
        /// <summary>
        /// 备用字段3：钢种颜色
        /// </summary>
        public string C_BY3
        {
            set { _c_by3 = value; }
            get { return _c_by3; }
        }
        /// <summary>
        /// 备用字段4：是否不锈钢；1-不锈钢
        /// </summary>
        public string C_BY4
        {
            set { _c_by4 = value; }
            get { return _c_by4; }
        }
        /// <summary>
        /// 是否排产完;Y/N
        /// </summary>
        public string C_BY5
        {
            set { _c_by5 = value; }
            get { return _c_by5; }
        }
        /// <summary>
        /// NC销售订单主键
        /// </summary>
        public string C_NC_ID
        {
            set { _c_nc_id = value; }
            get { return _c_nc_id; }
        }
        /// <summary>
        /// 炼钢记号
        /// </summary>
        public string C_LGJH
        {
            set { _c_lgjh = value; }
            get { return _c_lgjh; }
        }
        /// <summary>
        /// 质量等级主键
        /// </summary>
        public string C_ZLDJ_ID
        {
            set { _c_zldj_id = value; }
            get { return _c_zldj_id; }
        }
        /// <summary>
        /// 转炉主键
        /// </summary>
        public string C_ZL_ID
        {
            set { _c_zl_id = value; }
            get { return _c_zl_id; }
        }
        /// <summary>
        /// 精炼主键
        /// </summary>
        public string C_LF_ID
        {
            set { _c_lf_id = value; }
            get { return _c_lf_id; }
        }
        /// <summary>
        /// 真空主键
        /// </summary>
        public string C_RH_ID
        {
            set { _c_rh_id = value; }
            get { return _c_rh_id; }
        }
        /// <summary>
        /// 钢坯宽度
        /// </summary>
        public decimal? N_SLAB_WIDTH
        {
            set { _n_slab_width = value; }
            get { return _n_slab_width; }
        }
        /// <summary>
        /// 钢坯厚度
        /// </summary>
        public decimal? N_SLAB_THICK
        {
            set { _n_slab_thick = value; }
            get { return _n_slab_thick; }
        }
        /// <summary>
        /// 直径
        /// </summary>
        public decimal? N_DIAMETER
        {
            set { _n_diameter = value; }
            get { return _n_diameter; }
        }
        /// <summary>
        /// NC销售单据号日期
        /// </summary>
        public DateTime? D_NC_DATE
        {
            set { _d_nc_date = value; }
            get { return _d_nc_date; }
        }
        /// <summary>
        /// 业务员
        /// </summary>
        public string C_YWY
        {
            set { _c_ywy = value; }
            get { return _c_ywy; }
        }
        /// <summary>
        /// NC销售单据号
        /// </summary>
        public string C_NC_SALECODE
        {
            set { _c_nc_salecode = value; }
            get { return _c_nc_salecode; }
        }
        /// <summary>
        /// 发运方式主键
        /// </summary>
        public string C_TRANSMODEID
        {
            set { _c_transmodeid = value; }
            get { return _c_transmodeid; }
        }
        /// <summary>
        /// 大方坯能否热装
        /// </summary>
        public string C_DFP_RZ
        {
            set { _c_dfp_rz = value; }
            get { return _c_dfp_rz; }
        }
        /// <summary>
        /// 热轧坯能否热装
        /// </summary>
        public string C_RZP_RZ
        {
            set { _c_rzp_rz = value; }
            get { return _c_rzp_rz; }
        }
        /// <summary>
        /// 大方坯缓冷要求
        /// </summary>
        public string C_DFP_YQ
        {
            set { _c_dfp_yq = value; }
            get { return _c_dfp_yq; }
        }
        /// <summary>
        /// 热轧坯缓冷要求
        /// </summary>
        public string C_RZP_YQ
        {
            set { _c_rzp_yq = value; }
            get { return _c_rzp_yq; }
        }
        /// <summary>
        /// 修磨要求
        /// </summary>
        public string C_XM_YQ
        {
            set { _c_xm_yq = value; }
            get { return _c_xm_yq; }
        }
        /// <summary>
        /// 加热炉温度
        /// </summary>
        public decimal? N_JRL_WD
        {
            set { _n_jrl_wd = value; }
            get { return _n_jrl_wd; }
        }
        /// <summary>
        /// 加热炉时间
        /// </summary>
        public decimal? N_JRL_SJ
        {
            set { _n_jrl_sj = value; }
            get { return _n_jrl_sj; }
        }
        /// <summary>
        /// 开坯加热炉温度
        /// </summary>
        public decimal? N_KPJRL_WD
        {
            set { _n_kpjrl_wd = value; }
            get { return _n_kpjrl_wd; }
        }
        /// <summary>
        /// 开坯加热炉时间
        /// </summary>
        public decimal? N_KPJRL_SJ
        {
            set { _n_kpjrl_sj = value; }
            get { return _n_kpjrl_sj; }
        }
        /// <summary>
        /// 铁水硫要求
        /// </summary>
        public decimal? N_TSL
        {
            set { _n_tsl = value; }
            get { return _n_tsl; }
        }
        /// <summary>
        /// 轧线
        /// </summary>
        public string C_ROLL_CODE
        {
            set { _c_roll_code = value; }
            get { return _c_roll_code; }
        }
        /// <summary>
        /// 连铸
        /// </summary>
        public string C_CCM_CODE
        {
            set { _c_ccm_code = value; }
            get { return _c_ccm_code; }
        }
        /// <summary>
        /// 可排轧线
        /// </summary>
        public string C_ROLL_DESC
        {
            set { _c_roll_desc = value; }
            get { return _c_roll_desc; }
        }
        /// <summary>
        /// 可排连铸
        /// </summary>
        public string C_CCM_DESC
        {
            set { _c_ccm_desc = value; }
            get { return _c_ccm_desc; }
        }
        /// <summary>
        /// 是否脱硫
        /// </summary>
        public string C_TL
        {
            set { _c_tl = value; }
            get { return _c_tl; }
        }
        /// <summary>
        /// 整浇次炉数(最少)
        /// </summary>
        public decimal? N_ZJCLS_MIN
        {
            set { _n_zjcls_min = value; }
            get { return _n_zjcls_min; }
        }
        /// <summary>
        /// 整浇次炉数(最少)
        /// </summary>
        public decimal? N_ZJCLS_MAX
        {
            set { _n_zjcls_max = value; }
            get { return _n_zjcls_max; }
        }
        /// <summary>
        /// NC状态：0自由状态，1生成销售订单，2订单已导入NC，
        /// </summary>
        public string C_NCSTATUS
        {
            set { _c_ncstatus = value; }
            get { return _c_ncstatus; }
        }
        /// <summary>
        /// 0普通材1出口材
        /// </summary>
        public string C_PCLX
        {
            set { _c_pclx = value; }
            get { return _c_pclx; }
        }
        /// <summary>
        /// 钢种类别
        /// </summary>
        public string C_STL_GRD_TYPE
        {
            set { _c_stl_grd_type = value; }
            get { return _c_stl_grd_type; }
        }
        /// <summary>
        /// 发送NC时间
        /// </summary>
        public DateTime? D_NS_SEND_DT
        {
            set { _d_ns_send_dt = value; }
            get { return _d_ns_send_dt; }
        }
        /// <summary>
        /// 原始合同订单号
        /// </summary>
        public string C_ORDER_NO_OLD
        {
            set { _c_order_no_old = value; }
            get { return _c_order_no_old; }
        }
        /// <summary>
        /// 钢坯钢种
        /// </summary>
        public string C_STL_GRD_SLAB
        {
            set { _c_stl_grd_slab = value; }
            get { return _c_stl_grd_slab; }
        }
        /// <summary>
        /// 钢坯执行标准
        /// </summary>
        public string C_STD_CODE_SLAB
        {
            set { _c_std_code_slab = value; }
            get { return _c_std_code_slab; }
        }
        /// <summary>
        /// 订单旬排产提报人
        /// </summary>
        public string C_PCTBEMP
        {
            set { _c_pctbemp = value; }
            get { return _c_pctbemp; }
        }
        /// <summary>
        /// 订单旬排产提报时间
        /// </summary>
        public DateTime? D_PCTBTS
        {
            set { _d_pctbts = value; }
            get { return _d_pctbts; }
        }
        /// <summary>
        /// 是否监控
        /// </summary>
        public string C_SFJK
        {
            set { _c_sfjk = value; }
            get { return _c_sfjk; }
        }
        /// <summary>
        /// 钢种大类
        /// </summary>
        public string C_STL_GRD_CLASS
        {
            set { _c_stl_grd_class = value; }
            get { return _c_stl_grd_class; }
        }
        /// <summary>
		/// 定尺
		/// </summary>
		public decimal? N_LENGTH
        {
            set { _n_length = value; }
            get { return _n_length; }
        }
        /// <summary>
        /// 合格量
        /// </summary>
        public decimal? N_HG_WGT
        {
            set { _n_hg_wgt = value; }
            get { return _n_hg_wgt; }
        }
        /// <summary>
        /// 待判量
        /// </summary>
        public decimal? N_DP_WGT
        {
            set { _n_dp_wgt = value; }
            get { return _n_dp_wgt; }
        }
        /// <summary>
        /// 改判量
        /// </summary>
        public decimal? N_GP_WGT
        {
            set { _n_gp_wgt = value; }
            get { return _n_gp_wgt; }
        }
        /// <summary>
        /// 协议品量
        /// </summary>
        public decimal? N_XY_WGT
        {
            set { _n_xy_wgt = value; }
            get { return _n_xy_wgt; }
        }
        /// <summary>
        /// 头尾材量
        /// </summary>
        public decimal? N_TW_WGT
        {
            set { _n_tw_wgt = value; }
            get { return _n_tw_wgt; }
        }
        /// <summary>
        /// 不合格品量
        /// </summary>
        public decimal? N_BHG_WGT
        {
            set { _n_bhg_wgt = value; }
            get { return _n_bhg_wgt; }
        }
        /// <summary>
        /// 合格入库量
        /// </summary>
        public decimal? N_HG_WGT_IN
        {
            set { _n_hg_wgt_in = value; }
            get { return _n_hg_wgt_in; }
        }
        /// <summary>
        /// 改判入库量
        /// </summary>
        public decimal? N_GP_WGT_IN
        {
            set { _n_gp_wgt_in = value; }
            get { return _n_gp_wgt_in; }
        }
        /// <summary>
        /// 协议品入库量
        /// </summary>
        public decimal? N_XY_WGT_IN
        {
            set { _n_xy_wgt_in = value; }
            get { return _n_xy_wgt_in; }
        }
        /// <summary>
        /// 头尾材入库量
        /// </summary>
        public decimal? N_TW_WGT_IN
        {
            set { _n_tw_wgt_in = value; }
            get { return _n_tw_wgt_in; }
        }
        /// <summary>
        /// 不合格品入库量
        /// </summary>
        public decimal? N_BHG_WGT_IN
        {
            set { _n_bhg_wgt_in = value; }
            get { return _n_bhg_wgt_in; }
        }
        /// <summary>
        /// 合格出库量
        /// </summary>
        public decimal? N_HG_WGT_OUT
        {
            set { _n_hg_wgt_out = value; }
            get { return _n_hg_wgt_out; }
        }
        /// <summary>
        /// 改判出库量
        /// </summary>
        public decimal? N_GP_WGT_OUT
        {
            set { _n_gp_wgt_out = value; }
            get { return _n_gp_wgt_out; }
        }
        /// <summary>
        /// 协议品出库量
        /// </summary>
        public decimal? N_XY_WGT_OUT
        {
            set { _n_xy_wgt_out = value; }
            get { return _n_xy_wgt_out; }
        }
        /// <summary>
        /// 头尾材出库量
        /// </summary>
        public decimal? N_TW_WGT_OUT
        {
            set { _n_tw_wgt_out = value; }
            get { return _n_tw_wgt_out; }
        }
        /// <summary>
        /// 不合格品出库量
        /// </summary>
        public decimal? N_BHG_WGT_OUT
        {
            set { _n_bhg_wgt_out = value; }
            get { return _n_bhg_wgt_out; }
        }
        /// <summary>
        /// 销售最小时间
        /// </summary>
        public DateTime? D_SALE_TIME_MIN
        {
            set { _d_sale_time_min = value; }
            get { return _d_sale_time_min; }
        }
        /// <summary>
        /// 销售最大时间
        /// </summary>
        public DateTime? D_SALE_TIME_MAX
        {
            set { _d_sale_time_max = value; }
            get { return _d_sale_time_max; }
        }
        /// <summary>
        /// 生产最小时间
        /// </summary>
        public DateTime? D_PRODUCE_DATE_MIN
        {
            set { _d_produce_date_min = value; }
            get { return _d_produce_date_min; }
        }
        /// <summary>
        /// 生产最大时间
        /// </summary>
        public DateTime? D_PRODUCE_DATE_MAX
        {
            set { _d_produce_date_max = value; }
            get { return _d_produce_date_max; }
        }
        /// <summary>
        /// 钢坯现存量
        /// </summary>
        public decimal? N_SLAB_XC_WGT
        {
            set { _n_slab_xc_wgt = value; }
            get { return _n_slab_xc_wgt; }
        }
        /// <summary>
        /// 线材现存量
        /// </summary>
        public decimal? N_ROLL_XC_WGT
        {
            set { _n_roll_xc_wgt = value; }
            get { return _n_roll_xc_wgt; }
        }

        /// <summary>
		/// 订单原日期
		/// </summary>
		public DateTime? D_OLD_DATE
        {
            set { _d_old_date = value; }
            get { return _d_old_date; }
        }
        /// <summary>
        /// 轧钢完工量
        /// </summary>
        public decimal? N_ROLL_WGT
        {
            set { _n_roll_wgt = value; }
            get { return _n_roll_wgt; }
        }
        /// <summary>
		/// 备注1
		/// </summary>
		public string C_REMARK1
        {
            set { _c_remark1 = value; }
            get { return _c_remark1; }
        }
        /// <summary>
        /// 备注2
        /// </summary>
        public string C_REMARK2
        {
            set { _c_remark2 = value; }
            get { return _c_remark2; }
        }
        /// <summary>
        /// 备注3
        /// </summary>
        public string C_REMARK3
        {
            set { _c_remark3 = value; }
            get { return _c_remark3; }
        }
        /// <summary>
        /// 备用4销售特殊信息
        /// </summary>
        public string C_REMARK4
        {
            set { _c_remark4 = value; }
            get { return _c_remark4; }
        }
        /// <summary>
        /// 备注5
        /// </summary>
        public string C_REMARK5
        {
            set { _c_remark5 = value; }
            get { return _c_remark5; }
        }
        /// <summary>
        /// 生产最新操作时间
        /// </summary>
        public DateTime? D_SC_MOD_DT
        {
            set { _d_sc_mod_dt = value; }
            get { return _d_sc_mod_dt; }
        }

        /// <summary>
		/// 钢坯消耗
		/// </summary>
		public decimal? N_SLAB_XH_WGT
        {
            set { _n_slab_xh_wgt = value; }
            get { return _n_slab_xh_wgt; }
        }
        /// <summary>
        /// 钢坯种类
        /// </summary>
        public string C_SLAB_TYPE
        {
            set { _c_slab_type = value; }
            get { return _c_slab_type; }
        }
        /// <summary>
        /// 原订单需求日期
        /// </summary>
        public DateTime? D_OLD_NEED_DATE
        {
            set { _d_old_need_date = value; }
            get { return _d_old_need_date; }
        }
        /// <summary>
        /// 评价日期
        /// </summary>
        public DateTime? D_PJ_DATE
        {
            set { _d_pj_date = value; }
            get { return _d_pj_date; }
        }
        /// <summary>
        /// 日期备用1
        /// </summary>
        public DateTime? D_DATE_BY1
        {
            set { _d_date_by1 = value; }
            get { return _d_date_by1; }
        }
        /// <summary>
        /// 日期备用2
        /// </summary>
        public DateTime? D_DATE_BY2
        {
            set { _d_date_by2 = value; }
            get { return _d_date_by2; }
        }
        /// <summary>
        /// 日期备用3
        /// </summary>
        public DateTime? D_DATE_BY3
        {
            set { _d_date_by3 = value; }
            get { return _d_date_by3; }
        }
        /// <summary>
        /// 日期备用4
        /// </summary>
        public DateTime? D_DATE_BY4
        {
            set { _d_date_by4 = value; }
            get { return _d_date_by4; }
        }
        /// <summary>
        /// 日期备用5
        /// </summary>
        public DateTime? D_DATE_BY5
        {
            set { _d_date_by5 = value; }
            get { return _d_date_by5; }
        }
        /// <summary>
        /// 日期备用6
        /// </summary>
        public DateTime? D_DATE_BY6
        {
            set { _d_date_by6 = value; }
            get { return _d_date_by6; }
        }
        #endregion Model

        public bool B_check { get => _b_check; set => _b_check = value; }

        /// <summary>
        /// 订单完工量
        /// </summary>
       public decimal N_WCL
        {

        get {
                return N_PROD_WGT +N_SLAB_MATCH_WGT;
            }
        }
        /// <summary>
        /// 订单执行情况
        /// </summary>
        public string C_EXEC_STATUS
        {
          get {
                string strres = "";
                if (N_ROLL_PROD_WGT==0)
                {
                    strres= "未下达";
                }
                if (N_ROLL_PROD_WGT >0)
                {
                    strres= "已下达";
                }
                //if (N_EXEC_STATUS == 0 || N_EXEC_STATUS == 2)
                //{
                //    return "未完工";
                //}
                if (N_EXEC_STATUS == 6)
                {
                    strres= "已完工";
                }
                if (N_EXEC_STATUS == 5)
                {
                    strres = "已撤回";
                }

                if (N_EXEC_STATUS == 8)
                {
                    strres = "已关闭";
                }
                return strres;



            }
        }

        public decimal N_EXEC
        {

            get {
               return N_PROD_WGT - N_WGT;
            }
        }

        /// <summary>
        /// 计划日期
        /// </summary>
        public string C_PCTBTS
        {
            get {

                return Convert.ToDateTime(D_PCTBTS).ToString("yyyy-MM-dd");
            }

        }

        /// <summary>
        /// 需求日期
        /// </summary>
        public string C_NEED_DT
        {
            get
            {

                return Convert.ToDateTime(D_NEED_DT).ToString("yyyy-MM-dd");
            }

        }

        /// <summary>
        /// 原计划日期
        /// </summary>
        public string C_OLD_DATE
        {
            get
            {

                return Convert.ToDateTime(D_OLD_DATE).ToString("yyyy-MM-dd");
            }

        }


        


        /// <summary>
        /// 订单类型
        /// </summary>
        public string ORDER_TYPE
        {
            get
            {
                if (C_CON_NO.Trim() == ""&&N_TYPE==6)
                {
                    return "自备坯";
                }
                else if (C_CON_NO.Trim() != "" && N_TYPE == 6)
                {
                    return "外销坯";
                }
                else if ( N_TYPE == 8&&C_BY4=="1")
                {
                    return "不锈钢线材";
                }
                else if (N_TYPE == 8 && C_BY4 != "1"&&C_MAT_CODE.Substring(0,3)=="802")
                {
                    return "精品线材";
                }
                else if (N_TYPE == 8 && C_BY4 != "1" && (C_MAT_CODE.Substring(0, 5) == "80101"|| C_MAT_CODE.Substring(0, 5) == "80102"))
                {
                    return "普碳钢";
                }
                else if (N_TYPE == 8 && C_BY4 != "1" && C_MAT_CODE.Substring(0, 3) == "801"&& C_MAT_CODE.Substring(0, 5) != "80101" && C_MAT_CODE.Substring(0, 5) != "80102")
                {
                    return "高速线材";
                }
                else
                {
                    return "";
                }
            }
        }


    }
}
