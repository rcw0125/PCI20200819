using System;
namespace MODEL
{
	/// <summary>
	/// 浇次计划表
	/// </summary>
	[Serializable]
	public partial class Mod_TSP_CAST_PLAN_LOG
	{
		public Mod_TSP_CAST_PLAN_LOG()
		{}
		#region Model
		private string _c_id=System.Guid.NewGuid().ToString();
		private string _c_ccm_id;
		private string _c_ccm_code;
		private decimal? _n_group;
		private decimal? _n_total_wgt;
		private decimal? _n_zjcls;
		private decimal? _n_zjclzl;
		private decimal? _n_mlzl;
		private decimal? _n_sort;
		private string _c_stl_grd;
		private decimal? _n_produce_time;
		private decimal? _n_jscn;
		private string _c_by1;
		private string _c_by2;
		private string _c_by3;
		private string _c_rh;
		private string _c_dfp_hl;
		private string _c_hl;
		private string _c_xm;
		private decimal _n_order_ls;
		private DateTime? _d_dfphl_start_time;
		private DateTime? _d_dfphl_end_time;
		private DateTime? _d_kp_start_time;
		private DateTime? _d_kp_end_time;
		private DateTime? _d_hl_start_time;
		private DateTime? _d_hl_end_time;
		private DateTime? _d_plan_ky_time;
		private string _c_plan_roll;
		private DateTime? _d_zz_start_time;
		private DateTime? _d_zz_end_time;
		private DateTime? _d_xm_start_time;
		private DateTime? _d_xm_end_time;
		private string _c_std_code;
		private string _c_slab_type;
		private string _c_stl_grd_type;
		private string _c_prod_name;
		private string _c_prod_kind;
		private decimal _n_dfp_hl_time=0M;
		private decimal _n_hl_time=0M;
		private decimal _n_xm_time=0M;
		private decimal _n_gg=0M;
		private decimal _n_ccm_time=0M;
		private string _c_tj_remark;
		private string _c_tl;
		private decimal _n_rh=0M;
		private decimal _n_tl=0M;
		private decimal _n_gzsl=0M;
		private string _c_remark;
		private decimal _n_xm=0M;
		private decimal _n_dhl=0M;
		private decimal _n_hl=0M;
		private decimal _n_status=1M;
		private DateTime? _d_p_start_time;
		private DateTime? _d_p_end_time;
		private decimal _n_dfp_rz=0M;
		private decimal _n_rzp_rz=0M;
		private string _c_rh_sfjs;
		private string _c_tz_remark;
		private string _c_log_id;
		private string _c_log_remark;
		private string _c_log_emp;
		private DateTime? _d_log_dt;
		private string _c_log_ip;
		/// <summary>
		/// 主键
		/// </summary>
		public string C_ID
		{
			set{ _c_id=value;}
			get{return _c_id;}
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
		/// 连铸代码
		/// </summary>
		public string C_CCM_CODE
		{
			set{ _c_ccm_code=value;}
			get{return _c_ccm_code;}
		}
		/// <summary>
		/// 分组序号
		/// </summary>
		public decimal? N_GROUP
		{
			set{ _n_group=value;}
			get{return _n_group;}
		}
		/// <summary>
		/// 排产总量
		/// </summary>
		public decimal? N_TOTAL_WGT
		{
			set{ _n_total_wgt=value;}
			get{return _n_total_wgt;}
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
		/// 整浇次重量
		/// </summary>
		public decimal? N_ZJCLZL
		{
			set{ _n_zjclzl=value;}
			get{return _n_zjclzl;}
		}
		/// <summary>
		/// 每炉重量
		/// </summary>
		public decimal? N_MLZL
		{
			set{ _n_mlzl=value;}
			get{return _n_mlzl;}
		}
		/// <summary>
		/// 排序号
		/// </summary>
		public decimal? N_SORT
		{
			set{ _n_sort=value;}
			get{return _n_sort;}
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
		/// 停机时间
		/// </summary>
		public decimal? N_PRODUCE_TIME
		{
			set{ _n_produce_time=value;}
			get{return _n_produce_time;}
		}
		/// <summary>
		/// 机时产能
		/// </summary>
		public decimal? N_JSCN
		{
			set{ _n_jscn=value;}
			get{return _n_jscn;}
		}
		/// <summary>
		/// 备用1
		/// </summary>
		public string C_BY1
		{
			set{ _c_by1=value;}
			get{return _c_by1;}
		}
		/// <summary>
		/// 备用2
		/// </summary>
		public string C_BY2
		{
			set{ _c_by2=value;}
			get{return _c_by2;}
		}
		/// <summary>
		/// 备用3钢种颜色
		/// </summary>
		public string C_BY3
		{
			set{ _c_by3=value;}
			get{return _c_by3;}
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
		/// 订单炉数
		/// </summary>
		public decimal N_ORDER_LS
		{
			set{ _n_order_ls=value;}
			get{return _n_order_ls;}
		}
		/// <summary>
		/// 大方坯缓冷计划开始时间
		/// </summary>
		public DateTime? D_DFPHL_START_TIME
		{
			set{ _d_dfphl_start_time=value;}
			get{return _d_dfphl_start_time;}
		}
		/// <summary>
		/// 大方坯缓冷计划结束时间
		/// </summary>
		public DateTime? D_DFPHL_END_TIME
		{
			set{ _d_dfphl_end_time=value;}
			get{return _d_dfphl_end_time;}
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
		/// 热轧坯缓冷计划开始时间
		/// </summary>
		public DateTime? D_HL_START_TIME
		{
			set{ _d_hl_start_time=value;}
			get{return _d_hl_start_time;}
		}
		/// <summary>
		/// 热轧坯缓冷计划结束时间
		/// </summary>
		public DateTime? D_HL_END_TIME
		{
			set{ _d_hl_end_time=value;}
			get{return _d_hl_end_time;}
		}
		/// <summary>
		/// 计划可轧时间
		/// </summary>
		public DateTime? D_PLAN_KY_TIME
		{
			set{ _d_plan_ky_time=value;}
			get{return _d_plan_ky_time;}
		}
		/// <summary>
		/// 计划轧线
		/// </summary>
		public string C_PLAN_ROLL
		{
			set{ _c_plan_roll=value;}
			get{return _c_plan_roll;}
		}
		/// <summary>
		/// 排产计划开始时间
		/// </summary>
		public DateTime? D_ZZ_START_TIME
		{
			set{ _d_zz_start_time=value;}
			get{return _d_zz_start_time;}
		}
		/// <summary>
		/// 排产计划结束时间
		/// </summary>
		public DateTime? D_ZZ_END_TIME
		{
			set{ _d_zz_end_time=value;}
			get{return _d_zz_end_time;}
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
		/// 执行标准
		/// </summary>
		public string C_STD_CODE
		{
			set{ _c_std_code=value;}
			get{return _c_std_code;}
		}
		/// <summary>
		/// 连铸坯类型 大方坯 小方坯,不锈钢
		/// </summary>
		public string C_SLAB_TYPE
		{
			set{ _c_slab_type=value;}
			get{return _c_slab_type;}
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
		/// 大方坯缓冷时间
		/// </summary>
		public decimal N_DFP_HL_TIME
		{
			set{ _n_dfp_hl_time=value;}
			get{return _n_dfp_hl_time;}
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
		/// 修磨时间
		/// </summary>
		public decimal N_XM_TIME
		{
			set{ _n_xm_time=value;}
			get{return _n_xm_time;}
		}
		/// <summary>
		/// 轧钢计划规格数量
		/// </summary>
		public decimal N_GG
		{
			set{ _n_gg=value;}
			get{return _n_gg;}
		}
		/// <summary>
		/// 连铸浇次时间
		/// </summary>
		public decimal N_CCM_TIME
		{
			set{ _n_ccm_time=value;}
			get{return _n_ccm_time;}
		}
		/// <summary>
		/// 停机说明
		/// </summary>
		public string C_TJ_REMARK
		{
			set{ _c_tj_remark=value;}
			get{return _c_tj_remark;}
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
		/// 过真空炉数
		/// </summary>
		public decimal N_RH
		{
			set{ _n_rh=value;}
			get{return _n_rh;}
		}
		/// <summary>
		/// 脱硫炉数
		/// </summary>
		public decimal N_TL
		{
			set{ _n_tl=value;}
			get{return _n_tl;}
		}
		/// <summary>
		/// 混浇钢种数量数
		/// </summary>
		public decimal N_GZSL
		{
			set{ _n_gzsl=value;}
			get{return _n_gzsl;}
		}
		/// <summary>
		/// 备注
		/// </summary>
		public string C_REMARK
		{
			set{ _c_remark=value;}
			get{return _c_remark;}
		}
		/// <summary>
		/// 修磨炉数
		/// </summary>
		public decimal N_XM
		{
			set{ _n_xm=value;}
			get{return _n_xm;}
		}
		/// <summary>
		/// 大方坯缓冷炉数
		/// </summary>
		public decimal N_DHL
		{
			set{ _n_dhl=value;}
			get{return _n_dhl;}
		}
		/// <summary>
		/// 缓冷炉数
		/// </summary>
		public decimal N_HL
		{
			set{ _n_hl=value;}
			get{return _n_hl;}
		}
		/// <summary>
		/// 状态0已删除，1未排,2已排3完成
		/// </summary>
		public decimal N_STATUS
		{
			set{ _n_status=value;}
			get{return _n_status;}
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
		/// 大方坯需热装热轧炉数
		/// </summary>
		public decimal N_DFP_RZ
		{
			set{ _n_dfp_rz=value;}
			get{return _n_dfp_rz;}
		}
		/// <summary>
		/// 热轧坯需热装热轧炉数
		/// </summary>
		public decimal N_RZP_RZ
		{
			set{ _n_rzp_rz=value;}
			get{return _n_rzp_rz;}
		}
		/// <summary>
		/// RH炉寿命结束Y/N
		/// </summary>
		public string C_RH_SFJS
		{
			set{ _c_rh_sfjs=value;}
			get{return _c_rh_sfjs;}
		}
		/// <summary>
		/// 浇次调整说明
		/// </summary>
		public string C_TZ_REMARK
		{
			set{ _c_tz_remark=value;}
			get{return _c_tz_remark;}
		}
		/// <summary>
		/// 记录号
		/// </summary>
		public string C_LOG_ID
		{
			set{ _c_log_id=value;}
			get{return _c_log_id;}
		}
		/// <summary>
		/// 记录说明
		/// </summary>
		public string C_LOG_REMARK
		{
			set{ _c_log_remark=value;}
			get{return _c_log_remark;}
		}
		/// <summary>
		/// 记录人
		/// </summary>
		public string C_LOG_EMP
		{
			set{ _c_log_emp=value;}
			get{return _c_log_emp;}
		}
		/// <summary>
		/// 记录时间
		/// </summary>
		public DateTime? D_LOG_DT
		{
			set{ _d_log_dt=value;}
			get{return _d_log_dt;}
		}
		/// <summary>
		/// 记录电脑IP
		/// </summary>
		public string C_LOG_IP
		{
			set{ _c_log_ip=value;}
			get{return _c_log_ip;}
		}
		#endregion Model

	}
}

