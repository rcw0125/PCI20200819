using System;
namespace MODEL
{
	/// <summary>
	/// 炉次计划排产临时表
	/// </summary>
	[Serializable]
	public partial class Mod_TPP_LGPC_LCLSB_TEST
    {
		public Mod_TPP_LGPC_LCLSB_TEST()
		{}
		#region Model
		private string _c_id;
		private string _c_fk;
		private string _c_order_no;
		private string _c_design_no;
		private decimal? _n_slab_wgt;
		private string _c_ctrl_no;
		private string _c_ccm_id;
		private string _c_ccm_desc;
		private string _c_prod_name;
		private string _c_stl_grd;
		private string _c_spec_code;
		private string _c_length;
		private string _c_matrl_no;
		private string _c_matrl_name;
		private string _c_slab_size;
		private string _c_slab_length;
		private string _c_state;
		private string _c_std_code;
		private string _c_initialize_item_id;
		private DateTime? _d_p_start_time;
		private DateTime? _d_p_end_time;
		private decimal? _n_prod_time=0.5M;
		private decimal? _n_sort;
		private string _c_cast_no;
		private decimal _n_status=1;
		private string _c_emp_id;
        private DateTime _d_mod_dt = DateTime.Now;
		private string _c_remark;
		private decimal _n_creat_plan=1;
		private decimal _n_creat_zg_plan=0;
		private decimal _n_produce_time=0;
		private string _c_zl_id;
		private string _c_lf_id;
		private string _c_rh_id;
		private string _c_lgjh;
		private string _c_qua;
		private DateTime? _d_arrive_zg_time;
		private string _c_by1;
		private string _c_by2;
		private string _c_by3;
		private string _c_rh;
		private string _c_dfp_hl;
		private string _c_hl;
		private string _c_xm;
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
		private string _c_stove_no;
		private DateTime? _d_dfphl_start_time_sj;
		private DateTime? _d_dfphl_end_time_sj;
		private DateTime? _d_kp_start_time_sj;
		private DateTime? _d_kp_end_time_sj;
		private DateTime? _d_hl_start_time_sj;
		private DateTime? _d_hl_end_time_sj;
		private DateTime? _d_xm_start_time_sj;
		private DateTime? _d_xm_end_time_sj;
		private decimal? _n_sj_wgt;
		private DateTime? _d_start_time_sj;
		private DateTime? _d_end_time_sj;
		private decimal _n_dfp_hl_time=0;
		private decimal _n_hl_time=0;
		private string _c_route;
		private decimal? _n_slab_pw;
		private string _c_matrl_code_kp;
		private string _c_matrl_name_kp;
		private string _c_kp_size;
		private decimal? _n_kp_length;
		private decimal? _n_kp_pw;
		private decimal? _n_use_wgt=0M;
		private DateTime? _d_use_start_time_sj;
		private DateTime? _d_use_end_time_sj;
		private DateTime? _d_can_use_time;
		private decimal? _n_rh_num;
		private decimal? _n_kp_wgt;
		private decimal? _n_xm_wgt;
		private string _c_dfp_rz;
		private string _c_rzp_rz;
		private string _c_dfp_yq;
		private string _c_rzp_yq;
		private string _c_stl_grd_type;
		private string _c_prod_kind;
		private string _c_tl;
		private decimal? _n_jscn=0M;
		private string _c_free2;
		private decimal? _n_group;
		private decimal? _n_zjcls;
		private decimal? _n_zjcls_min=0;
		private decimal? _n_zjcls_max=0;
		private string _c_sl;
		private string _c_wl;
		private string _c_slab_type;
		private decimal? _n_jc_sort;
		private string _c_free1;
		/// <summary>
		/// 主键
		/// </summary>
		public string C_ID
		{
			set{ _c_id=value;}
			get{return _c_id;}
		}
		/// <summary>
		/// 浇次临时表主键
		/// </summary>
		public string C_FK
		{
			set{ _c_fk=value;}
			get{return _c_fk;}
		}
		/// <summary>
		/// 订单号（计划订单）
		/// </summary>
		public string C_ORDER_NO
		{
			set{ _c_order_no=value;}
			get{return _c_order_no;}
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
		/// 坯料重量
		/// </summary>
		public decimal? N_SLAB_WGT
		{
			set{ _n_slab_wgt=value;}
			get{return _n_slab_wgt;}
		}
		/// <summary>
		/// 浇次号
		/// </summary>
		public string C_CTRL_NO
		{
			set{ _c_ctrl_no=value;}
			get{return _c_ctrl_no;}
		}
		/// <summary>
		/// 连铸机主键
		/// </summary>
		public string C_CCM_ID
		{
			set{ _c_ccm_id=value;}
			get{return _c_ccm_id;}
		}
		/// <summary>
		/// 连铸机描述
		/// </summary>
		public string C_CCM_DESC
		{
			set{ _c_ccm_desc=value;}
			get{return _c_ccm_desc;}
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
		/// 钢种
		/// </summary>
		public string C_STL_GRD
		{
			set{ _c_stl_grd=value;}
			get{return _c_stl_grd;}
		}
		/// <summary>
		/// 规格（保留）
		/// </summary>
		public string C_SPEC_CODE
		{
			set{ _c_spec_code=value;}
			get{return _c_spec_code;}
		}
		/// <summary>
		/// 长度（保留）
		/// </summary>
		public string C_LENGTH
		{
			set{ _c_length=value;}
			get{return _c_length;}
		}
		/// <summary>
		/// 物料编码
		/// </summary>
		public string C_MATRL_NO
		{
			set{ _c_matrl_no=value;}
			get{return _c_matrl_no;}
		}
		/// <summary>
		/// 物料名称
		/// </summary>
		public string C_MATRL_NAME
		{
			set{ _c_matrl_name=value;}
			get{return _c_matrl_name;}
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
		/// 坯料长度
		/// </summary>
		public string C_SLAB_LENGTH
		{
			set{ _c_slab_length=value;}
			get{return _c_slab_length;}
		}
		/// <summary>
		/// 0有计划1非计划
		/// </summary>
		public string C_STATE
		{
			set{ _c_state=value;}
			get{return _c_state;}
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
		/// 分组号(保留)
		/// </summary>
		public string C_INITIALIZE_ITEM_ID
		{
			set{ _c_initialize_item_id=value;}
			get{return _c_initialize_item_id;}
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
		/// 理论生产需时h
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
		/// 浇次号
		/// </summary>
		public string C_CAST_NO
		{
			set{ _c_cast_no=value;}
			get{return _c_cast_no;}
		}
		/// <summary>
		/// 使用状态   1-可用；0-停用
		/// </summary>
		public decimal N_STATUS
		{
			set{ _n_status=value;}
			get{return _n_status;}
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
		/// 备注
		/// </summary>
		public string C_REMARK
		{
			set{ _c_remark=value;}
			get{return _c_remark;}
		}
		/// <summary>
		/// 是否生成炉次计划；0未生成；1已计算时间；2已生成各工序计划；3完成
		/// </summary>
		public decimal N_CREAT_PLAN
		{
			set{ _n_creat_plan=value;}
			get{return _n_creat_plan;}
		}
		/// <summary>
		/// 是否生成轧钢计划；0未生成；1已生成
		/// </summary>
		public decimal N_CREAT_ZG_PLAN
		{
			set{ _n_creat_zg_plan=value;}
			get{return _n_creat_zg_plan;}
		}
		/// <summary>
		/// 停机时间
		/// </summary>
		public decimal N_PRODUCE_TIME
		{
			set{ _n_produce_time=value;}
			get{return _n_produce_time;}
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
		/// 炼钢记号
		/// </summary>
		public string C_LGJH
		{
			set{ _c_lgjh=value;}
			get{return _c_lgjh;}
		}
		/// <summary>
		/// 支数
		/// </summary>
		public string C_QUA
		{
			set{ _c_qua=value;}
			get{return _c_qua;}
		}
		/// <summary>
		/// 到达轧钢时间
		/// </summary>
		public DateTime? D_ARRIVE_ZG_TIME
		{
			set{ _d_arrive_zg_time=value;}
			get{return _d_arrive_zg_time;}
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
		/// 轧钢计划开始时间
		/// </summary>
		public DateTime? D_ZZ_START_TIME
		{
			set{ _d_zz_start_time=value;}
			get{return _d_zz_start_time;}
		}
		/// <summary>
		/// 轧钢计划结束时间
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
		/// 实际炉号
		/// </summary>
		public string C_STOVE_NO
		{
			set{ _c_stove_no=value;}
			get{return _c_stove_no;}
		}
		/// <summary>
		/// 大方坯缓冷实际开始时间
		/// </summary>
		public DateTime? D_DFPHL_START_TIME_SJ
		{
			set{ _d_dfphl_start_time_sj=value;}
			get{return _d_dfphl_start_time_sj;}
		}
		/// <summary>
		/// 大方坯缓冷实际结束时间
		/// </summary>
		public DateTime? D_DFPHL_END_TIME_SJ
		{
			set{ _d_dfphl_end_time_sj=value;}
			get{return _d_dfphl_end_time_sj;}
		}
		/// <summary>
		/// 开坯实际开始时间
		/// </summary>
		public DateTime? D_KP_START_TIME_SJ
		{
			set{ _d_kp_start_time_sj=value;}
			get{return _d_kp_start_time_sj;}
		}
		/// <summary>
		/// 开坯实际结束时间
		/// </summary>
		public DateTime? D_KP_END_TIME_SJ
		{
			set{ _d_kp_end_time_sj=value;}
			get{return _d_kp_end_time_sj;}
		}
		/// <summary>
		/// 热轧坯缓冷实际开始时间
		/// </summary>
		public DateTime? D_HL_START_TIME_SJ
		{
			set{ _d_hl_start_time_sj=value;}
			get{return _d_hl_start_time_sj;}
		}
		/// <summary>
		/// 热轧坯缓冷实际结束时间
		/// </summary>
		public DateTime? D_HL_END_TIME_SJ
		{
			set{ _d_hl_end_time_sj=value;}
			get{return _d_hl_end_time_sj;}
		}
		/// <summary>
		/// 修磨实际开始时间
		/// </summary>
		public DateTime? D_XM_START_TIME_SJ
		{
			set{ _d_xm_start_time_sj=value;}
			get{return _d_xm_start_time_sj;}
		}
		/// <summary>
		/// 修磨实际结束时间
		/// </summary>
		public DateTime? D_XM_END_TIME_SJ
		{
			set{ _d_xm_end_time_sj=value;}
			get{return _d_xm_end_time_sj;}
		}
		/// <summary>
		/// 钢坯实际收料量
		/// </summary>
		public decimal? N_SJ_WGT
		{
			set{ _n_sj_wgt=value;}
			get{return _n_sj_wgt;}
		}
		/// <summary>
		/// 连铸实际开始时间
		/// </summary>
		public DateTime? D_START_TIME_SJ
		{
			set{ _d_start_time_sj=value;}
			get{return _d_start_time_sj;}
		}
		/// <summary>
		/// 连铸实际结束时间
		/// </summary>
		public DateTime? D_END_TIME_SJ
		{
			set{ _d_end_time_sj=value;}
			get{return _d_end_time_sj;}
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
		/// 工艺路线 O
		/// </summary>
		public string C_ROUTE
		{
			set{ _c_route=value;}
			get{return _c_route;}
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
		/// 可使用重量
		/// </summary>
		public decimal? N_USE_WGT
		{
			set{ _n_use_wgt=value;}
			get{return _n_use_wgt;}
		}
		/// <summary>
		/// 使用开始时间
		/// </summary>
		public DateTime? D_USE_START_TIME_SJ
		{
			set{ _d_use_start_time_sj=value;}
			get{return _d_use_start_time_sj;}
		}
		/// <summary>
		/// 使用结束时间
		/// </summary>
		public DateTime? D_USE_END_TIME_SJ
		{
			set{ _d_use_end_time_sj=value;}
			get{return _d_use_end_time_sj;}
		}
		/// <summary>
		/// 该炉钢坯可使用时间
		/// </summary>
		public DateTime? D_CAN_USE_TIME
		{
			set{ _d_can_use_time=value;}
			get{return _d_can_use_time;}
		}
		/// <summary>
		/// RH炉连浇次数
		/// </summary>
		public decimal? N_RH_NUM
		{
			set{ _n_rh_num=value;}
			get{return _n_rh_num;}
		}
		/// <summary>
		/// 已开坯重量
		/// </summary>
		public decimal? N_KP_WGT
		{
			set{ _n_kp_wgt=value;}
			get{return _n_kp_wgt;}
		}
		/// <summary>
		/// 已修磨重量
		/// </summary>
		public decimal? N_XM_WGT
		{
			set{ _n_xm_wgt=value;}
			get{return _n_xm_wgt;}
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
		/// 钢种类别
		/// </summary>
		public string C_STL_GRD_TYPE
		{
			set{ _c_stl_grd_type=value;}
			get{return _c_stl_grd_type;}
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
		/// 是否脱硫
		/// </summary>
		public string C_TL
		{
			set{ _c_tl=value;}
			get{return _c_tl;}
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
		/// 自由项2
		/// </summary>
		public string C_FREE2
		{
			set{ _c_free2=value;}
			get{return _c_free2;}
		}
		/// <summary>
		/// 连铸排产时的分组号
		/// </summary>
		public decimal? N_GROUP
		{
			set{ _n_group=value;}
			get{return _n_group;}
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
		/// 整浇次炉数(最少)
		/// </summary>
		public decimal? N_ZJCLS_MIN
		{
			set{ _n_zjcls_min=value;}
			get{return _n_zjcls_min;}
		}
		/// <summary>
		/// 整浇次炉数(最大)
		/// </summary>
		public decimal? N_ZJCLS_MAX
		{
			set{ _n_zjcls_max=value;}
			get{return _n_zjcls_max;}
		}
		/// <summary>
		/// 是否需要首炉过渡
		/// </summary>
		public string C_SL
		{
			set{ _c_sl=value;}
			get{return _c_sl;}
		}
		/// <summary>
		/// 是否需要尾炉过渡
		/// </summary>
		public string C_WL
		{
			set{ _c_wl=value;}
			get{return _c_wl;}
		}
		/// <summary>
		/// 钢坯类型
		/// </summary>
		public string C_SLAB_TYPE
		{
			set{ _c_slab_type=value;}
			get{return _c_slab_type;}
		}
		/// <summary>
		/// 浇次排序
		/// </summary>
		public decimal? N_JC_SORT
		{
			set{ _n_jc_sort=value;}
			get{return _n_jc_sort;}
		}
		/// <summary>
		/// 自由项1
		/// </summary>
		public string C_FREE1
		{
			set{ _c_free1=value;}
			get{return _c_free1;}
		}
		#endregion Model

	}
}

