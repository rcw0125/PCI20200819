using System;
namespace MODEL
{
	/// <summary>
	/// 线材生产计划表
	/// </summary>
	[Serializable]
	public partial class Mod_TPC_PLAN_ROLL
    {
		public Mod_TPC_PLAN_ROLL()
		{}
		#region Model
		private string _c_id= System.Guid.NewGuid().ToString();
		private decimal? _n_status=0M;
		private string _c_order_id;
		private string _c_order_no;
		private decimal? _n_wgt=0M;
		private string _c_mat_code;
		private string _c_mat_name;
		private string _c_spec;
		private string _c_stl_grd;
		private string _c_std_code;
		private decimal? _n_user_lev;
		private decimal? _n_stl_grd_lev;
		private string _c_order_lev;
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
		private decimal? _n_roll_prod_wgt=0M;
		private string _c_roll_prod_emp_id;
		private string _c_stl_rol_dt;
		private string _c_cust_no;
		private string _c_cust_name;
		private string _c_pack;
		private string _c_design_no;
		private string _c_lint_id;
		private DateTime? _d_start_time;
		private DateTime? _d_end_time;
		private string _c_emp_id;
		private DateTime _d_mod_dt= Convert.ToDateTime(System.DateTime.Now);
		private decimal? _n_mach_wgt;
		private string _c_free_term;
		private string _c_free_term2;
		private string _c_area;
		private string _c_pclx;
		private string _c_rh;
		private string _c_lf;
		private string _c_kp;
		private decimal? _n_hl_time=0M;
		private string _c_hl;
		private decimal? _n_dfp_hl_time=0M;
		private string _c_dfp_hl;
		private string _c_xm;
		private string _c_route;
		private decimal? _n_diameter;
		private string _c_xm_yq;
		private decimal? _n_jrl_wd;
		private decimal? _n_jrl_sj;
		/// <summary>
		/// 主键
		/// </summary>
		public string C_ID
		{
			set{ _c_id=value;}
			get{return _c_id;}
		}
		/// <summary>
		/// 订单状态：0未下发，1已下发
		/// </summary>
		public decimal? N_STATUS
		{
			set{ _n_status=value;}
			get{return _n_status;}
		}
		/// <summary>
		/// 订单表主键
		/// </summary>
		public string C_ORDER_ID
		{
			set{ _c_order_id=value;}
			get{return _c_order_id;}
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
		/// 订单重量
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
		public string C_ORDER_LEV
		{
			set{ _c_order_lev=value;}
			get{return _c_order_lev;}
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
		/// 产线主键
		/// </summary>
		public string C_LINT_ID
		{
			set{ _c_lint_id=value;}
			get{return _c_lint_id;}
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
		/// 轧钢机时产量
		/// </summary>
		public decimal? N_MACH_WGT
		{
			set{ _n_mach_wgt=value;}
			get{return _n_mach_wgt;}
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
		/// 过真空O Y/N
		/// </summary>
		public string C_RH
		{
			set{ _c_rh=value;}
			get{return _c_rh;}
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
		/// 缓冷时间
		/// </summary>
		public decimal? N_HL_TIME
		{
			set{ _n_hl_time=value;}
			get{return _n_hl_time;}
		}
		/// <summary>
		/// 缓冷 O CODE
		/// </summary>
		public string C_HL
		{
			set{ _c_hl=value;}
			get{return _c_hl;}
		}
		/// <summary>
		/// 大方坯缓冷时间
		/// </summary>
		public decimal? N_DFP_HL_TIME
		{
			set{ _n_dfp_hl_time=value;}
			get{return _n_dfp_hl_time;}
		}
		/// <summary>
		/// 大方坯缓冷
		/// </summary>
		public string C_DFP_HL
		{
			set{ _c_dfp_hl=value;}
			get{return _c_dfp_hl;}
		}
		/// <summary>
		/// 修磨 O -C_COPING_CRAFT
		/// </summary>
		public string C_XM
		{
			set{ _c_xm=value;}
			get{return _c_xm;}
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
		#endregion Model

	}
}

