using System;
namespace MODEL
{
	/// <summary>
	/// 线材生产计划明细表
	/// </summary>
	[Serializable]
	public partial class Mod_TRP_PLAN_ITEM_TEST
    {
		public Mod_TRP_PLAN_ITEM_TEST()
		{}
		#region Model
		private string _c_id;
		private string _c_plan_roll_id;
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
		private decimal? _n_issue_wgt;
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
		/// <summary>
		/// 主键
		/// </summary>
		public string C_ID
		{
			set{ _c_id=value;}
			get{return _c_id;}
		}
		/// <summary>
		/// TRP_PLAN_ROLL主键
		/// </summary>
		public string C_PLAN_ROLL_ID
		{
			set{ _c_plan_roll_id=value;}
			get{return _c_plan_roll_id;}
		}
		/// <summary>
		/// 订单状态：0未下发，1已下发，2已完成，3已关闭，5已排产完，6计划排序完成
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
		/// 计划开始时间
		/// </summary>
		public DateTime? D_P_START_TIME
		{
			set{ _d_p_start_time=value;}
			get{return _d_p_start_time;}
		}
		/// <summary>
		/// 计划结束时间
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
		/// 生产排序
		/// </summary>
		public decimal? N_SORT
		{
			set{ _n_sort=value;}
			get{return _n_sort;}
		}
		/// <summary>
		/// 轧钢排产量
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
		/// 可生产量
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
		public decimal? N_ISSUE_WGT
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
		/// 开始时间
		/// </summary>
		public DateTime? D_START_TIME
		{
			set{ _d_start_time=value;}
			get{return _d_start_time;}
		}
		/// <summary>
		/// 结束时间
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
		#endregion Model

	}
}

