using System;
namespace MODEL
{
    /// <summary>
    /// 线材生产计划明细表
    /// </summary>
    [Serializable]
    public partial class Mod_TRP_PLAN_ROLL_ITEM
    {
        public Mod_TRP_PLAN_ROLL_ITEM()
        { }
        #region Model
        private string _c_id;
        private string _c_plan_roll_id;
        private decimal? _n_status = 0M;
        private string _c_initialize_item_id;
        private string _c_order_no;
        private decimal? _n_wgt = 0M;
        private string _c_mat_code;
        private string _c_mat_name;
        private string _c_tech_prot;
        private string _c_spec;
        private string _c_stl_grd;
        private string _c_std_code;
        private decimal? _n_user_lev;
        private decimal? _n_stl_grd_lev;
        private decimal? _n_order_lev;
        private string _c_qualiry_lev;
        private DateTime? _d_need_dt;
        private DateTime? _d_delivery_dt;
        private DateTime? _d_dt;
        private string _c_line_desc;
        private string _c_line_code;
        private DateTime? _d_p_start_time;
        private DateTime? _d_p_end_time;
        private decimal? _n_prod_time;
        private decimal? _n_sort;
        private decimal? _n_roll_prod_wgt = 0M;
        private string _c_roll_prod_emp_id;
        private string _c_stl_rol_dt;
        private decimal? _n_prod_wgt = 0M;
        private decimal? _n_ware_wgt = 0M;
        private decimal? _n_ware_out_wgt = 0M;
        private decimal? _n_flag = 0M;
        private decimal? _n_issue_wgt;
        private string _c_cust_no;
        private string _c_cust_name;
        private string _c_sale_channel;
        private string _c_pack;
        private string _c_design_no;
        private decimal? _n_group_wgt = 0M;
        private string _c_sta_id;
        private DateTime? _d_start_time;
        private DateTime? _d_end_time;
        private string _c_emp_id;
        private DateTime _d_mod_dt = DateTime.Now;
        private decimal? _n_roll_wgt;
        private decimal? _n_mach_wgt;
        private string _c_cast_no;
        private string _c_initialize_id;
        private string _c_free_term;
        private string _c_free_term2;
        private string _c_area;
        private string _c_pclx;
        private string _c_sfhl;
        private DateTime? _d_hl_start_time;
        private DateTime? _d_hl_end_time;
        private string _c_sfhl_d;
        private DateTime? _d_dhl_start_time;
        private DateTime? _d_dhl_end_time;
        private string _c_sfkp;
        private DateTime? _d_kp_start_time;
        private DateTime? _d_kp_end_time;
        private string _c_sfxm;
        private DateTime? _d_xm_start_time;
        private DateTime? _d_xm_end_time;
        private decimal? _n_uploadstatus = 0M;
        private string _c_matrl_code_slab;
        private string _c_matrl_name_slab;
        private string _c_slab_size;
        private decimal? _n_slab_length;
        private decimal? _n_slab_pw;
        private DateTime? _d_can_roll_time;
        private string _c_route;
        private decimal? _n_diameter;
        private string _c_xm_yq;
        private decimal? _n_jrl_wd;
        private decimal? _n_jrl_sj;
        private string _c_stl_grd_slab;
        private string _c_std_code_slab;
        private string _c_remark;

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
        private decimal? _n_slab_xh_wgt;
        private string _c_slab_type;
        private string _c_remark1;
        private string _c_remark2;
        private string _c_remark3;
        private string _c_remark4;
        private string _c_remark5;
        private decimal? _n_is_merge = 0M;
        /// <summary>
        /// 主键
        /// </summary>
        public string C_ID
        {
            set { _c_id = value; }
            get { return _c_id; }
        }
        /// <summary>
        /// TRP_PLAN_ROLL主键
        /// </summary>
        public string C_PLAN_ROLL_ID
        {
            set { _c_plan_roll_id = value; }
            get { return _c_plan_roll_id; }
        }
        /// <summary>
        /// 订单状态：0未下发，1已下发，2-已组批，8-已撤销
        /// </summary>
        public decimal? N_STATUS
        {
            set { _n_status = value; }
            get { return _n_status; }
        }
        /// <summary>
        /// 订单表主键
        /// </summary>
        public string C_INITIALIZE_ITEM_ID
        {
            set { _c_initialize_item_id = value; }
            get { return _c_initialize_item_id; }
        }
        /// <summary>
        /// 订单号
        /// </summary>
        public string C_ORDER_NO
        {
            set { _c_order_no = value; }
            get { return _c_order_no; }
        }
        /// <summary>
        /// 订单排产量
        /// </summary>
        public decimal? N_WGT
        {
            set { _n_wgt = value; }
            get { return _n_wgt; }
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
        /// 执行标准
        /// </summary>
        public string C_STD_CODE
        {
            set { _c_std_code = value; }
            get { return _c_std_code; }
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
        /// 轧线描述
        /// </summary>
        public string C_LINE_DESC
        {
            set { _c_line_desc = value; }
            get { return _c_line_desc; }
        }
        /// <summary>
        /// 轧线编码
        /// </summary>
        public string C_LINE_CODE
        {
            set { _c_line_code = value; }
            get { return _c_line_code; }
        }
        /// <summary>
        /// 计划开始时间
        /// </summary>
        public DateTime? D_P_START_TIME
        {
            set { _d_p_start_time = value; }
            get { return _d_p_start_time; }
        }
        /// <summary>
        /// 计划结束时间
        /// </summary>
        public DateTime? D_P_END_TIME
        {
            set { _d_p_end_time = value; }
            get { return _d_p_end_time; }
        }
        /// <summary>
        /// 理论生产需时
        /// </summary>
        public decimal? N_PROD_TIME
        {
            set { _n_prod_time = value; }
            get { return _n_prod_time; }
        }
        /// <summary>
        /// 生产排序
        /// </summary>
        public decimal? N_SORT
        {
            set { _n_sort = value; }
            get { return _n_sort; }
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
        public string C_STL_ROL_DT
        {
            set { _c_stl_rol_dt = value; }
            get { return _c_stl_rol_dt; }
        }
        /// <summary>
        /// 可生产量
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
        /// 订单标识：0正常，1增订，2变更，3预测，4 附属品
        /// </summary>
        public decimal? N_FLAG
        {
            set { _n_flag = value; }
            get { return _n_flag; }
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
        /// 包装要求
        /// </summary>
        public string C_PACK
        {
            set { _c_pack = value; }
            get { return _c_pack; }
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
        /// 组批量
        /// </summary>
        public decimal? N_GROUP_WGT
        {
            set { _n_group_wgt = value; }
            get { return _n_group_wgt; }
        }
        /// <summary>
        /// 工位
        /// </summary>
        public string C_STA_ID
        {
            set { _c_sta_id = value; }
            get { return _c_sta_id; }
        }
        /// <summary>
        /// 开始时间
        /// </summary>
        public DateTime? D_START_TIME
        {
            set { _d_start_time = value; }
            get { return _d_start_time; }
        }
        /// <summary>
        /// 结束时间
        /// </summary>
        public DateTime? D_END_TIME
        {
            set { _d_end_time = value; }
            get { return _d_end_time; }
        }
        /// <summary>
        /// 操作人
        /// </summary>
        public string C_EMP_ID
        {
            set { _c_emp_id = value; }
            get { return _c_emp_id; }
        }
        /// <summary>
        /// 操作时间
        /// </summary>
        public DateTime D_MOD_DT
        {
            set { _d_mod_dt = value; }
            get { return _d_mod_dt; }
        }
        /// <summary>
        /// 可待轧量
        /// </summary>
        public decimal? N_ROLL_WGT
        {
            set { _n_roll_wgt = value; }
            get { return _n_roll_wgt; }
        }
        /// <summary>
        /// 轧钢机时产量
        /// </summary>
        public decimal? N_MACH_WGT
        {
            set { _n_mach_wgt = value; }
            get { return _n_mach_wgt; }
        }
        /// <summary>
        /// 浇次号
        /// </summary>
        public string C_CAST_NO
        {
            set { _c_cast_no = value; }
            get { return _c_cast_no; }
        }
        /// <summary>
        /// 计划标识0连铸坯1自由坯
        /// </summary>
        public string C_INITIALIZE_ID
        {
            set { _c_initialize_id = value; }
            get { return _c_initialize_id; }
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
        /// 自由项2
        /// </summary>
        public string C_FREE_TERM2
        {
            set { _c_free_term2 = value; }
            get { return _c_free_term2; }
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
        /// 批次类型0普通材，1出口材
        /// </summary>
        public string C_PCLX
        {
            set { _c_pclx = value; }
            get { return _c_pclx; }
        }
        /// <summary>
        /// 小方坯是否缓冷
        /// </summary>
        public string C_SFHL
        {
            set { _c_sfhl = value; }
            get { return _c_sfhl; }
        }
        /// <summary>
        /// 缓冷计划开始时间
        /// </summary>
        public DateTime? D_HL_START_TIME
        {
            set { _d_hl_start_time = value; }
            get { return _d_hl_start_time; }
        }
        /// <summary>
        /// 缓冷计划结束时间
        /// </summary>
        public DateTime? D_HL_END_TIME
        {
            set { _d_hl_end_time = value; }
            get { return _d_hl_end_time; }
        }
        /// <summary>
        /// 大方坯是否缓冷
        /// </summary>
        public string C_SFHL_D
        {
            set { _c_sfhl_d = value; }
            get { return _c_sfhl_d; }
        }
        /// <summary>
        /// 缓冷计划开始时间
        /// </summary>
        public DateTime? D_DHL_START_TIME
        {
            set { _d_dhl_start_time = value; }
            get { return _d_dhl_start_time; }
        }
        /// <summary>
        /// 缓冷计划结束时间
        /// </summary>
        public DateTime? D_DHL_END_TIME
        {
            set { _d_dhl_end_time = value; }
            get { return _d_dhl_end_time; }
        }
        /// <summary>
        /// 大方坯是否开坯
        /// </summary>
        public string C_SFKP
        {
            set { _c_sfkp = value; }
            get { return _c_sfkp; }
        }
        /// <summary>
        /// 开坯计划开始时间
        /// </summary>
        public DateTime? D_KP_START_TIME
        {
            set { _d_kp_start_time = value; }
            get { return _d_kp_start_time; }
        }
        /// <summary>
        /// 开坯计划结束时间
        /// </summary>
        public DateTime? D_KP_END_TIME
        {
            set { _d_kp_end_time = value; }
            get { return _d_kp_end_time; }
        }
        /// <summary>
        /// 是否修磨
        /// </summary>
        public string C_SFXM
        {
            set { _c_sfxm = value; }
            get { return _c_sfxm; }
        }
        /// <summary>
        /// 修磨计划开始时间
        /// </summary>
        public DateTime? D_XM_START_TIME
        {
            set { _d_xm_start_time = value; }
            get { return _d_xm_start_time; }
        }
        /// <summary>
        /// 修磨计划结束时间
        /// </summary>
        public DateTime? D_XM_END_TIME
        {
            set { _d_xm_end_time = value; }
            get { return _d_xm_end_time; }
        }
        /// <summary>
        /// 上传状态0未传1已传
        /// </summary>
        public decimal? N_UPLOADSTATUS
        {
            set { _n_uploadstatus = value; }
            get { return _n_uploadstatus; }
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
        /// 轧钢可以轧制时间时间
        /// </summary>
        public DateTime? D_CAN_ROLL_TIME
        {
            set { _d_can_roll_time = value; }
            get { return _d_can_roll_time; }
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
        /// 直径
        /// </summary>
        public decimal? N_DIAMETER
        {
            set { _n_diameter = value; }
            get { return _n_diameter; }
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
        /// 备注
        /// </summary>
        public string C_REMARK
        {
            set { _c_remark = value; }
            get { return _c_remark; }
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
        /// 备注3换规格原因
        /// </summary>
        public string C_REMARK3
        {
            set { _c_remark3 = value; }
            get { return _c_remark3; }
        }
        /// <summary>
        /// 备用4销售特殊信息/不锈钢
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
        /// 是否合并订单0否1是
        /// </summary>
        public decimal? N_IS_MERGE
        {
            set { _n_is_merge = value; }
            get { return _n_is_merge; }
        }
        #endregion Model

    }
}

