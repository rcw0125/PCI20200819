using System;
namespace MODEL
{
	/// <summary>
	/// 线材生产计划表
	/// </summary>
	[Serializable]
	public partial class Mod_TRP_PLAN_ROLL_TEST
    {
		public Mod_TRP_PLAN_ROLL_TEST()
		{}
		#region Model
		private string _c_id;
		private decimal? _n_status=0;
		private string _c_initialize_item_id;
		private string _c_order_no;
		private decimal? _n_wgt=0;
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
		private decimal? _n_roll_prod_wgt=0;
		private string _c_roll_prod_emp_id;
		private string _c_stl_rol_dt;
		private decimal? _n_prod_wgt=0;
		private decimal? _n_ware_wgt=0;
		private decimal? _n_ware_out_wgt=0;
		private decimal? _n_flag=0;
		private decimal _n_issue_wgt=0;
		private string _c_cust_no;
		private string _c_cust_name;
		private string _c_sale_channel;
		private string _c_pack;
		private string _c_design_no;
		private decimal? _n_group_wgt=0;
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
		private decimal? _n_uploadstatus=0;
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
		private string _c_matrl_code_kp;
		private string _c_matrl_name_kp;
		private string _c_kp_size;
		private decimal? _n_kp_length;
		private decimal? _n_kp_pw;
		private decimal? _n_group;
		private string _c_xc;
		private string _c_sl;
		private string _c_wl;
		private decimal? _n_mach_wgt_ccm;
		private decimal? _n_zjcls=0;
		private string _c_by1;
		private string _c_by2;
		private string _c_by3;
		private string _c_by4="N";
		private string _c_by5;
		private string _c_lgjh;
		private string _c_zl_id;
		private string _c_lf_id;
		private string _c_rh_id;
		private decimal? _n_slab_width;
		private decimal? _n_slab_thick;
		private string _c_dfp_rz;
		private string _c_rzp_rz;
		private string _c_dfp_yq;
		private string _c_rzp_yq;
		private decimal? _n_kpjrl_wd;
		private decimal? _n_kpjrl_sj;
		private decimal? _n_tsl;
		private string _c_ccm_code;
		private string _c_ccm_desc;
		private string _c_tl;
		private decimal? _n_zjcls_min=0;
		private decimal? _n_zjcls_max=0;
		private string _c_stl_grd_type;
		private string _c_prod_name;
		private string _c_prod_kind;
		private decimal? _n_type;
		private string _c_rh;
		private string _c_dfp_hl;
		private string _c_hl;
		private string _c_xm;
		private string _c_ccm_id;
		private decimal _n_hl_time=0;
		private decimal _n_dfp_hl_time=0;
		private string _c_lf;
		private string _c_kp;
		private string _c_stl_grd_class;
		private string _c_pro_use;
		private string _c_cust_sq;
		private string _c_transmode;
		private string _c_remark1;
		private string _c_remark2;
		private string _c_remark3;
		private string _c_remark4;
		private string _c_remark5;
		private decimal? _n_kz_wgt;
        private string _c_spec_pc;
        /// <summary>
        /// 主键
        /// </summary>
        public string C_ID
		{
			set{ _c_id=value;}
			get{return _c_id;}
		}
		/// <summary>
		/// 订单状态：0未下发，1已下发，2已完成，3已关闭，5已排产完
		/// </summary>
		public decimal? N_STATUS
		{
			set{ _n_status=value;}
			get{return _n_status;}
		}
		/// <summary>
		/// 订单表主键
		/// </summary>
		public string C_INITIALIZE_ITEM_ID
		{
			set{ _c_initialize_item_id=value;}
			get{return _c_initialize_item_id;}
		}
		/// <summary>
		/// 订单号
		/// </summary>
		public string C_ORDER_NO
		{
			set{ _c_order_no=value;}
			get{return _c_order_no;}
		}
		/// <summary>
		/// 订单排产量
		/// </summary>
		public decimal? N_WGT
		{
			set{ _n_wgt=value;}
			get{return _n_wgt;}
		}
		/// <summary>
		/// 物料编码
		/// </summary>
		public string C_MAT_CODE
		{
			set{ _c_mat_code=value;}
			get{return _c_mat_code;}
		}
		/// <summary>
		/// 物料名称
		/// </summary>
		public string C_MAT_NAME
		{
			set{ _c_mat_name=value;}
			get{return _c_mat_name;}
		}
		/// <summary>
		/// 客户协议号
		/// </summary>
		public string C_TECH_PROT
		{
			set{ _c_tech_prot=value;}
			get{return _c_tech_prot;}
		}
		/// <summary>
		/// 规格
		/// </summary>
		public string C_SPEC
		{
			set{ _c_spec=value;}
			get{return _c_spec;}
		}
		/// <summary>
		/// 钢种
		/// </summary>
		public string C_STL_GRD
		{
			set{ _c_stl_grd=value;}
			get{return _c_stl_grd;}
		}
		/// <summary>
		/// 执行标准
		/// </summary>
		public string C_STD_CODE
		{
			set{ _c_std_code=value;}
			get{return _c_std_code;}
		}
		/// <summary>
		/// 客户等级
		/// </summary>
		public decimal? N_USER_LEV
		{
			set{ _n_user_lev=value;}
			get{return _n_user_lev;}
		}
		/// <summary>
		/// 钢种等级
		/// </summary>
		public decimal? N_STL_GRD_LEV
		{
			set{ _n_stl_grd_lev=value;}
			get{return _n_stl_grd_lev;}
		}
		/// <summary>
		/// 订单等级
		/// </summary>
		public decimal? N_ORDER_LEV
		{
			set{ _n_order_lev=value;}
			get{return _n_order_lev;}
		}
		/// <summary>
		/// 质量等级
		/// </summary>
		public string C_QUALIRY_LEV
		{
			set{ _c_qualiry_lev=value;}
			get{return _c_qualiry_lev;}
		}
		/// <summary>
		/// 需求日期
		/// </summary>
		public DateTime? D_NEED_DT
		{
			set{ _d_need_dt=value;}
			get{return _d_need_dt;}
		}
		/// <summary>
		/// 计划交货日期
		/// </summary>
		public DateTime? D_DELIVERY_DT
		{
			set{ _d_delivery_dt=value;}
			get{return _d_delivery_dt;}
		}
		/// <summary>
		/// 订单日期
		/// </summary>
		public DateTime? D_DT
		{
			set{ _d_dt=value;}
			get{return _d_dt;}
		}
		/// <summary>
		/// 轧线描述
		/// </summary>
		public string C_LINE_DESC
		{
			set{ _c_line_desc=value;}
			get{return _c_line_desc;}
		}
		/// <summary>
		/// 轧线编码
		/// </summary>
		public string C_LINE_CODE
		{
			set{ _c_line_code=value;}
			get{return _c_line_code;}
		}
		/// <summary>
		/// 连铸计划开始时间
		/// </summary>
		public DateTime? D_P_START_TIME
		{
			set{ _d_p_start_time=value;}
			get{return _d_p_start_time;}
		}
		/// <summary>
		/// 连铸计划结束时间
		/// </summary>
		public DateTime? D_P_END_TIME
		{
			set{ _d_p_end_time=value;}
			get{return _d_p_end_time;}
		}
		/// <summary>
		/// 理论生产需时
		/// </summary>
		public decimal? N_PROD_TIME
		{
			set{ _n_prod_time=value;}
			get{return _n_prod_time;}
		}
		/// <summary>
		/// 分组排序号
		/// </summary>
		public decimal? N_SORT
		{
			set{ _n_sort=value;}
			get{return _n_sort;}
		}
		/// <summary>
		/// 轧钢计划量
		/// </summary>
		public decimal? N_ROLL_PROD_WGT
		{
			set{ _n_roll_prod_wgt=value;}
			get{return _n_roll_prod_wgt;}
		}
		/// <summary>
		/// 轧钢排产人
		/// </summary>
		public string C_ROLL_PROD_EMP_ID
		{
			set{ _c_roll_prod_emp_id=value;}
			get{return _c_roll_prod_emp_id;}
		}
		/// <summary>
		/// 轧钢排产时间
		/// </summary>
		public string C_STL_ROL_DT
		{
			set{ _c_stl_rol_dt=value;}
			get{return _c_stl_rol_dt;}
		}
		/// <summary>
		/// 生产量
		/// </summary>
		public decimal? N_PROD_WGT
		{
			set{ _n_prod_wgt=value;}
			get{return _n_prod_wgt;}
		}
		/// <summary>
		/// 库存量
		/// </summary>
		public decimal? N_WARE_WGT
		{
			set{ _n_ware_wgt=value;}
			get{return _n_ware_wgt;}
		}
		/// <summary>
		/// 出库量
		/// </summary>
		public decimal? N_WARE_OUT_WGT
		{
			set{ _n_ware_out_wgt=value;}
			get{return _n_ware_out_wgt;}
		}
		/// <summary>
		/// 订单标识：0正常，1增订，2变更，3预测，4 附属品
		/// </summary>
		public decimal? N_FLAG
		{
			set{ _n_flag=value;}
			get{return _n_flag;}
		}
		/// <summary>
		/// 已下发量
		/// </summary>
		public decimal N_ISSUE_WGT
		{
			set{ _n_issue_wgt=value;}
			get{return _n_issue_wgt;}
		}
		/// <summary>
		/// 客户编码
		/// </summary>
		public string C_CUST_NO
		{
			set{ _c_cust_no=value;}
			get{return _c_cust_no;}
		}
		/// <summary>
		/// 客户名称
		/// </summary>
		public string C_CUST_NAME
		{
			set{ _c_cust_name=value;}
			get{return _c_cust_name;}
		}
		/// <summary>
		/// 分销类别（直销/经销）
		/// </summary>
		public string C_SALE_CHANNEL
		{
			set{ _c_sale_channel=value;}
			get{return _c_sale_channel;}
		}
		/// <summary>
		/// 包装要求
		/// </summary>
		public string C_PACK
		{
			set{ _c_pack=value;}
			get{return _c_pack;}
		}
		/// <summary>
		/// 质量设计号
		/// </summary>
		public string C_DESIGN_NO
		{
			set{ _c_design_no=value;}
			get{return _c_design_no;}
		}
		/// <summary>
		/// 组批量
		/// </summary>
		public decimal? N_GROUP_WGT
		{
			set{ _n_group_wgt=value;}
			get{return _n_group_wgt;}
		}
		/// <summary>
		/// 工位
		/// </summary>
		public string C_STA_ID
		{
			set{ _c_sta_id=value;}
			get{return _c_sta_id;}
		}
		/// <summary>
		/// 轧钢开始时间
		/// </summary>
		public DateTime? D_START_TIME
		{
			set{ _d_start_time=value;}
			get{return _d_start_time;}
		}
		/// <summary>
		/// 轧钢结束时间
		/// </summary>
		public DateTime? D_END_TIME
		{
			set{ _d_end_time=value;}
			get{return _d_end_time;}
		}
		/// <summary>
		/// 操作人
		/// </summary>
		public string C_EMP_ID
		{
			set{ _c_emp_id=value;}
			get{return _c_emp_id;}
		}
		/// <summary>
		/// 操作时间
		/// </summary>
		public DateTime D_MOD_DT
		{
			set{ _d_mod_dt=value;}
			get{return _d_mod_dt;}
		}
		/// <summary>
		/// 可待轧量
		/// </summary>
		public decimal? N_ROLL_WGT
		{
			set{ _n_roll_wgt=value;}
			get{return _n_roll_wgt;}
		}
		/// <summary>
		/// 轧钢机时产量
		/// </summary>
		public decimal? N_MACH_WGT
		{
			set{ _n_mach_wgt=value;}
			get{return _n_mach_wgt;}
		}
		/// <summary>
		/// 浇次号
		/// </summary>
		public string C_CAST_NO
		{
			set{ _c_cast_no=value;}
			get{return _c_cast_no;}
		}
		/// <summary>
		/// 计划标识0连铸坯1自由坯
		/// </summary>
		public string C_INITIALIZE_ID
		{
			set{ _c_initialize_id=value;}
			get{return _c_initialize_id;}
		}
		/// <summary>
		/// 自由项
		/// </summary>
		public string C_FREE_TERM
		{
			set{ _c_free_term=value;}
			get{return _c_free_term;}
		}
		/// <summary>
		/// 自由项2
		/// </summary>
		public string C_FREE_TERM2
		{
			set{ _c_free_term2=value;}
			get{return _c_free_term2;}
		}
		/// <summary>
		/// 区域
		/// </summary>
		public string C_AREA
		{
			set{ _c_area=value;}
			get{return _c_area;}
		}
		/// <summary>
		/// 批次类型0普通材，1出口材
		/// </summary>
		public string C_PCLX
		{
			set{ _c_pclx=value;}
			get{return _c_pclx;}
		}
		/// <summary>
		/// 小方坯是否缓冷
		/// </summary>
		public string C_SFHL
		{
			set{ _c_sfhl=value;}
			get{return _c_sfhl;}
		}
		/// <summary>
		/// 缓冷计划开始时间
		/// </summary>
		public DateTime? D_HL_START_TIME
		{
			set{ _d_hl_start_time=value;}
			get{return _d_hl_start_time;}
		}
		/// <summary>
		/// 缓冷计划结束时间
		/// </summary>
		public DateTime? D_HL_END_TIME
		{
			set{ _d_hl_end_time=value;}
			get{return _d_hl_end_time;}
		}
		/// <summary>
		/// 大方坯是否缓冷
		/// </summary>
		public string C_SFHL_D
		{
			set{ _c_sfhl_d=value;}
			get{return _c_sfhl_d;}
		}
		/// <summary>
		/// 缓冷计划开始时间
		/// </summary>
		public DateTime? D_DHL_START_TIME
		{
			set{ _d_dhl_start_time=value;}
			get{return _d_dhl_start_time;}
		}
		/// <summary>
		/// 缓冷计划结束时间
		/// </summary>
		public DateTime? D_DHL_END_TIME
		{
			set{ _d_dhl_end_time=value;}
			get{return _d_dhl_end_time;}
		}
		/// <summary>
		/// 大方坯是否开坯
		/// </summary>
		public string C_SFKP
		{
			set{ _c_sfkp=value;}
			get{return _c_sfkp;}
		}
		/// <summary>
		/// 开坯计划开始时间
		/// </summary>
		public DateTime? D_KP_START_TIME
		{
			set{ _d_kp_start_time=value;}
			get{return _d_kp_start_time;}
		}
		/// <summary>
		/// 开坯计划结束时间
		/// </summary>
		public DateTime? D_KP_END_TIME
		{
			set{ _d_kp_end_time=value;}
			get{return _d_kp_end_time;}
		}
		/// <summary>
		/// 是否修磨
		/// </summary>
		public string C_SFXM
		{
			set{ _c_sfxm=value;}
			get{return _c_sfxm;}
		}
		/// <summary>
		/// 修磨计划开始时间
		/// </summary>
		public DateTime? D_XM_START_TIME
		{
			set{ _d_xm_start_time=value;}
			get{return _d_xm_start_time;}
		}
		/// <summary>
		/// 修磨计划结束时间
		/// </summary>
		public DateTime? D_XM_END_TIME
		{
			set{ _d_xm_end_time=value;}
			get{return _d_xm_end_time;}
		}
		/// <summary>
		/// 上传状态0未传1已传
		/// </summary>
		public decimal? N_UPLOADSTATUS
		{
			set{ _n_uploadstatus=value;}
			get{return _n_uploadstatus;}
		}
		/// <summary>
		/// 连铸钢坯物料号
		/// </summary>
		public string C_MATRL_CODE_SLAB
		{
			set{ _c_matrl_code_slab=value;}
			get{return _c_matrl_code_slab;}
		}
		/// <summary>
		/// 连铸钢坯物料名称
		/// </summary>
		public string C_MATRL_NAME_SLAB
		{
			set{ _c_matrl_name_slab=value;}
			get{return _c_matrl_name_slab;}
		}
		/// <summary>
		/// 连铸钢坯断面
		/// </summary>
		public string C_SLAB_SIZE
		{
			set{ _c_slab_size=value;}
			get{return _c_slab_size;}
		}
		/// <summary>
		/// 连铸钢坯定尺
		/// </summary>
		public decimal? N_SLAB_LENGTH
		{
			set{ _n_slab_length=value;}
			get{return _n_slab_length;}
		}
		/// <summary>
		/// 连铸钢坯理论单重
		/// </summary>
		public decimal? N_SLAB_PW
		{
			set{ _n_slab_pw=value;}
			get{return _n_slab_pw;}
		}
		/// <summary>
		/// 轧钢可以轧制时间时间
		/// </summary>
		public DateTime? D_CAN_ROLL_TIME
		{
			set{ _d_can_roll_time=value;}
			get{return _d_can_roll_time;}
		}
		/// <summary>
		/// 工艺路线 O
		/// </summary>
		public string C_ROUTE
		{
			set{ _c_route=value;}
			get{return _c_route;}
		}
		/// <summary>
		/// 直径
		/// </summary>
		public decimal? N_DIAMETER
		{
			set{ _n_diameter=value;}
			get{return _n_diameter;}
		}
		/// <summary>
		/// 修磨要求
		/// </summary>
		public string C_XM_YQ
		{
			set{ _c_xm_yq=value;}
			get{return _c_xm_yq;}
		}
		/// <summary>
		/// 加热炉温度
		/// </summary>
		public decimal? N_JRL_WD
		{
			set{ _n_jrl_wd=value;}
			get{return _n_jrl_wd;}
		}
		/// <summary>
		/// 加热炉时间
		/// </summary>
		public decimal? N_JRL_SJ
		{
			set{ _n_jrl_sj=value;}
			get{return _n_jrl_sj;}
		}
		/// <summary>
		/// 钢坯钢种
		/// </summary>
		public string C_STL_GRD_SLAB
		{
			set{ _c_stl_grd_slab=value;}
			get{return _c_stl_grd_slab;}
		}
		/// <summary>
		/// 钢坯执行标准
		/// </summary>
		public string C_STD_CODE_SLAB
		{
			set{ _c_std_code_slab=value;}
			get{return _c_std_code_slab;}
		}
		/// <summary>
		/// 开坯钢坯物料号
		/// </summary>
		public string C_MATRL_CODE_KP
		{
			set{ _c_matrl_code_kp=value;}
			get{return _c_matrl_code_kp;}
		}
		/// <summary>
		/// 开坯钢坯物料名称
		/// </summary>
		public string C_MATRL_NAME_KP
		{
			set{ _c_matrl_name_kp=value;}
			get{return _c_matrl_name_kp;}
		}
		/// <summary>
		/// 开坯钢坯断面
		/// </summary>
		public string C_KP_SIZE
		{
			set{ _c_kp_size=value;}
			get{return _c_kp_size;}
		}
		/// <summary>
		/// 开坯钢坯定尺
		/// </summary>
		public decimal? N_KP_LENGTH
		{
			set{ _n_kp_length=value;}
			get{return _n_kp_length;}
		}
		/// <summary>
		/// 开坯钢坯理论单重
		/// </summary>
		public decimal? N_KP_PW
		{
			set{ _n_kp_pw=value;}
			get{return _n_kp_pw;}
		}
		/// <summary>
		/// 分组号
		/// </summary>
		public decimal? N_GROUP
		{
			set{ _n_group=value;}
			get{return _n_group;}
		}
		/// <summary>
		/// 能否洗槽O CODE
		/// </summary>
		public string C_XC
		{
			set{ _c_xc=value;}
			get{return _c_xc;}
		}
		/// <summary>
		/// 是否需要首炉钢种O CODE
		/// </summary>
		public string C_SL
		{
			set{ _c_sl=value;}
			get{return _c_sl;}
		}
		/// <summary>
		/// 是否需要尾炉钢种O CODE
		/// </summary>
		public string C_WL
		{
			set{ _c_wl=value;}
			get{return _c_wl;}
		}
		/// <summary>
		/// 机时产量（连铸）
		/// </summary>
		public decimal? N_MACH_WGT_CCM
		{
			set{ _n_mach_wgt_ccm=value;}
			get{return _n_mach_wgt_ccm;}
		}
		/// <summary>
		/// 整浇次炉数
		/// </summary>
		public decimal? N_ZJCLS
		{
			set{ _n_zjcls=value;}
			get{return _n_zjcls;}
		}
		/// <summary>
		/// 备用字段1:'Y'有首炉生产的订单钢种
		/// </summary>
		public string C_BY1
		{
			set{ _c_by1=value;}
			get{return _c_by1;}
		}
		/// <summary>
		/// 备用字段2:'Y'有尾炉生产的订单钢种
		/// </summary>
		public string C_BY2
		{
			set{ _c_by2=value;}
			get{return _c_by2;}
		}
		/// <summary>
		/// 备用字段3：钢种颜色
		/// </summary>
		public string C_BY3
		{
			set{ _c_by3=value;}
			get{return _c_by3;}
		}
		/// <summary>
		/// 备用字段4：是否不锈钢；Y/N
		/// </summary>
		public string C_BY4
		{
			set{ _c_by4=value;}
			get{return _c_by4;}
		}
		/// <summary>
		/// 是否排产完;Y/N
		/// </summary>
		public string C_BY5
		{
			set{ _c_by5=value;}
			get{return _c_by5;}
		}
		/// <summary>
		/// 炼钢记号
		/// </summary>
		public string C_LGJH
		{
			set{ _c_lgjh=value;}
			get{return _c_lgjh;}
		}
		/// <summary>
		/// 转炉主键
		/// </summary>
		public string C_ZL_ID
		{
			set{ _c_zl_id=value;}
			get{return _c_zl_id;}
		}
		/// <summary>
		/// 精炼主键
		/// </summary>
		public string C_LF_ID
		{
			set{ _c_lf_id=value;}
			get{return _c_lf_id;}
		}
		/// <summary>
		/// 真空主键
		/// </summary>
		public string C_RH_ID
		{
			set{ _c_rh_id=value;}
			get{return _c_rh_id;}
		}
		/// <summary>
		/// 钢坯宽度
		/// </summary>
		public decimal? N_SLAB_WIDTH
		{
			set{ _n_slab_width=value;}
			get{return _n_slab_width;}
		}
		/// <summary>
		/// 钢坯厚度
		/// </summary>
		public decimal? N_SLAB_THICK
		{
			set{ _n_slab_thick=value;}
			get{return _n_slab_thick;}
		}
		/// <summary>
		/// 大方坯能否热装
		/// </summary>
		public string C_DFP_RZ
		{
			set{ _c_dfp_rz=value;}
			get{return _c_dfp_rz;}
		}
		/// <summary>
		/// 热轧坯能否热装
		/// </summary>
		public string C_RZP_RZ
		{
			set{ _c_rzp_rz=value;}
			get{return _c_rzp_rz;}
		}
		/// <summary>
		/// 大方坯缓冷要求
		/// </summary>
		public string C_DFP_YQ
		{
			set{ _c_dfp_yq=value;}
			get{return _c_dfp_yq;}
		}
		/// <summary>
		/// 热轧坯缓冷要求
		/// </summary>
		public string C_RZP_YQ
		{
			set{ _c_rzp_yq=value;}
			get{return _c_rzp_yq;}
		}
		/// <summary>
		/// 开坯加热炉温度
		/// </summary>
		public decimal? N_KPJRL_WD
		{
			set{ _n_kpjrl_wd=value;}
			get{return _n_kpjrl_wd;}
		}
		/// <summary>
		/// 开坯加热炉时间
		/// </summary>
		public decimal? N_KPJRL_SJ
		{
			set{ _n_kpjrl_sj=value;}
			get{return _n_kpjrl_sj;}
		}
		/// <summary>
		/// 铁水硫要求
		/// </summary>
		public decimal? N_TSL
		{
			set{ _n_tsl=value;}
			get{return _n_tsl;}
		}
		/// <summary>
		/// 连铸代码
		/// </summary>
		public string C_CCM_CODE
		{
			set{ _c_ccm_code=value;}
			get{return _c_ccm_code;}
		}
		/// <summary>
		/// 连铸描述
		/// </summary>
		public string C_CCM_DESC
		{
			set{ _c_ccm_desc=value;}
			get{return _c_ccm_desc;}
		}
		/// <summary>
		/// 是否脱硫
		/// </summary>
		public string C_TL
		{
			set{ _c_tl=value;}
			get{return _c_tl;}
		}
		/// <summary>
		/// 整浇次炉数(最少)
		/// </summary>
		public decimal? N_ZJCLS_MIN
		{
			set{ _n_zjcls_min=value;}
			get{return _n_zjcls_min;}
		}
		/// <summary>
		/// 整浇次炉数(最少)
		/// </summary>
		public decimal? N_ZJCLS_MAX
		{
			set{ _n_zjcls_max=value;}
			get{return _n_zjcls_max;}
		}
		/// <summary>
		/// 钢种类别
		/// </summary>
		public string C_STL_GRD_TYPE
		{
			set{ _c_stl_grd_type=value;}
			get{return _c_stl_grd_type;}
		}
		/// <summary>
		/// 类别
		/// </summary>
		public string C_PROD_NAME
		{
			set{ _c_prod_name=value;}
			get{return _c_prod_name;}
		}
		/// <summary>
		/// 品种
		/// </summary>
		public string C_PROD_KIND
		{
			set{ _c_prod_kind=value;}
			get{return _c_prod_kind;}
		}
		/// <summary>
		/// 订单类型: 6 钢坯，8线材,851渣，841焦化，831废材,(805,806,807委外线材)
		/// </summary>
		public decimal? N_TYPE
		{
			set{ _n_type=value;}
			get{return _n_type;}
		}
		/// <summary>
		/// 是否过真空
		/// </summary>
		public string C_RH
		{
			set{ _c_rh=value;}
			get{return _c_rh;}
		}
		/// <summary>
		/// 大方坯连铸坯是否缓冷
		/// </summary>
		public string C_DFP_HL
		{
			set{ _c_dfp_hl=value;}
			get{return _c_dfp_hl;}
		}
		/// <summary>
		/// 小方坯或热轧坯是否缓冷
		/// </summary>
		public string C_HL
		{
			set{ _c_hl=value;}
			get{return _c_hl;}
		}
		/// <summary>
		/// 是否修磨
		/// </summary>
		public string C_XM
		{
			set{ _c_xm=value;}
			get{return _c_xm;}
		}
		/// <summary>
		/// 连铸主键
		/// </summary>
		public string C_CCM_ID
		{
			set{ _c_ccm_id=value;}
			get{return _c_ccm_id;}
		}
		/// <summary>
		/// 缓冷时间
		/// </summary>
		public decimal N_HL_TIME
		{
			set{ _n_hl_time=value;}
			get{return _n_hl_time;}
		}
		/// <summary>
		/// 大方坯缓冷时间
		/// </summary>
		public decimal N_DFP_HL_TIME
		{
			set{ _n_dfp_hl_time=value;}
			get{return _n_dfp_hl_time;}
		}
		/// <summary>
		/// 精炼O Y/N
		/// </summary>
		public string C_LF
		{
			set{ _c_lf=value;}
			get{return _c_lf;}
		}
		/// <summary>
		/// 开坯O Y/N
		/// </summary>
		public string C_KP
		{
			set{ _c_kp=value;}
			get{return _c_kp;}
		}
		/// <summary>
		/// 钢种大类
		/// </summary>
		public string C_STL_GRD_CLASS
		{
			set{ _c_stl_grd_class=value;}
			get{return _c_stl_grd_class;}
		}
		/// <summary>
		/// 产品用途
		/// </summary>
		public string C_PRO_USE
		{
			set{ _c_pro_use=value;}
			get{return _c_pro_use;}
		}
		/// <summary>
		/// 客户特殊要求
		/// </summary>
		public string C_CUST_SQ
		{
			set{ _c_cust_sq=value;}
			get{return _c_cust_sq;}
		}
		/// <summary>
		/// 发运方式
		/// </summary>
		public string C_TRANSMODE
		{
			set{ _c_transmode=value;}
			get{return _c_transmode;}
		}
		/// <summary>
		/// 备用1
		/// </summary>
		public string C_REMARK1
		{
			set{ _c_remark1=value;}
			get{return _c_remark1;}
		}
		/// <summary>
		/// 备用2
		/// </summary>
		public string C_REMARK2
		{
			set{ _c_remark2=value;}
			get{return _c_remark2;}
		}
		/// <summary>
		/// 备用3
		/// </summary>
		public string C_REMARK3
		{
			set{ _c_remark3=value;}
			get{return _c_remark3;}
		}
		/// <summary>
		/// 备用4
		/// </summary>
		public string C_REMARK4
		{
			set{ _c_remark4=value;}
			get{return _c_remark4;}
		}
		/// <summary>
		/// 备用5
		/// </summary>
		public string C_REMARK5
		{
			set{ _c_remark5=value;}
			get{return _c_remark5;}
		}
		/// <summary>
		/// 可轧钢坯量
		/// </summary>
		public decimal? N_KZ_WGT
		{
			set{ _n_kz_wgt=value;}
			get{return _n_kz_wgt;}
		}
        /// <summary>
		/// 规格（排产使用）
		/// </summary>
		public string C_SPEC_PC
        {
            set { _c_spec_pc = value; }
            get { return _c_spec_pc; }
        }
        #endregion Model

    }
}

