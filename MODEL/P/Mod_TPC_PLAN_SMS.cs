using System;
namespace MODEL
{
	/// <summary>
	/// 钢坯订单计划
	/// </summary>
	[Serializable]
	public partial class Mod_TPC_PLAN_SMS
    {
		public Mod_TPC_PLAN_SMS()
		{}
		#region Model
		private string _c_id= System.Guid.NewGuid().ToString();
		private string _c_order_no;
		private string _c_con_no;
		private string _c_stl_grd;
		private string _c_spec;
		private string _c_free1;
		private string _c_free2;
		private string _c_std_code;
		private string _c_design_no;
		private decimal? _n_wgt;
		private DateTime? _d_need_dt;
		private DateTime? _d_delivery_dt;
		private DateTime _d_dt;
		private decimal _n_status=0M;
		private decimal? _n_type;
		private string _c_emp_id;
		private string _c_emp_name;
		private DateTime _d_mod_dt= Convert.ToDateTime(System.DateTime.Now);
		private string _c_issue_emp_id;
		private string _c_prd_emp_id;
		private string _c_ccm_no;
		private string _c_rh;
		private string _c_lf;
		private string _c_kp;
		private decimal _n_hl_time=0M;
		private string _c_hl;
		private decimal _n_dfp_hl_time=0M;
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
		private decimal? _n_mach_wgt_ccm;
		private decimal? _n_zjcls=0M;
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
		private string _c_xm_yq;
		private decimal? _n_kpjrl_wd;
		private decimal? _n_kpjrl_sj;
		private decimal? _n_tsl;
		private string _c_ccm_code;
		private string _c_ccm_desc;
		private string _c_tl;
		private decimal? _n_zjcls_min=0M;
		private decimal? _n_zjcls_max=0M;
		private string _c_stl_grd_type;
		private string _c_prod_name;
		private string _c_prod_kind;
		/// <summary>
		/// 主键
		/// </summary>
		public string C_ID
		{
			set{ _c_id=value;}
			get{return _c_id;}
		}
		/// <summary>
		/// 订单号(主键)
		/// </summary>
		public string C_ORDER_NO
		{
			set{ _c_order_no=value;}
			get{return _c_order_no;}
		}
		/// <summary>
		/// 合同号(外键)
		/// </summary>
		public string C_CON_NO
		{
			set{ _c_con_no=value;}
			get{return _c_con_no;}
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
		/// 规格
		/// </summary>
		public string C_SPEC
		{
			set{ _c_spec=value;}
			get{return _c_spec;}
		}
		/// <summary>
		/// 自由项1
		/// </summary>
		public string C_FREE1
		{
			set{ _c_free1=value;}
			get{return _c_free1;}
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
		/// 执行标准
		/// </summary>
		public string C_STD_CODE
		{
			set{ _c_std_code=value;}
			get{return _c_std_code;}
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
		/// 订单重量
		/// </summary>
		public decimal? N_WGT
		{
			set{ _n_wgt=value;}
			get{return _n_wgt;}
		}
		/// <summary>
		/// 场内生产需求日期
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
		public DateTime D_DT
		{
			set{ _d_dt=value;}
			get{return _d_dt;}
		}
		/// <summary>
		/// 状态
		/// </summary>
		public decimal N_STATUS
		{
			set{ _n_status=value;}
			get{return _n_status;}
		}
		/// <summary>
		/// 订单类型: 6 钢坯，8线材
		/// </summary>
		public decimal? N_TYPE
		{
			set{ _n_type=value;}
			get{return _n_type;}
		}
		/// <summary>
		/// 系统操作人编号
		/// </summary>
		public string C_EMP_ID
		{
			set{ _c_emp_id=value;}
			get{return _c_emp_id;}
		}
		/// <summary>
		/// 系统操作人姓名
		/// </summary>
		public string C_EMP_NAME
		{
			set{ _c_emp_name=value;}
			get{return _c_emp_name;}
		}
		/// <summary>
		/// 系统操作时间
		/// </summary>
		public DateTime D_MOD_DT
		{
			set{ _d_mod_dt=value;}
			get{return _d_mod_dt;}
		}
		/// <summary>
		/// 下发人
		/// </summary>
		public string C_ISSUE_EMP_ID
		{
			set{ _c_issue_emp_id=value;}
			get{return _c_issue_emp_id;}
		}
		/// <summary>
		/// 排产人
		/// </summary>
		public string C_PRD_EMP_ID
		{
			set{ _c_prd_emp_id=value;}
			get{return _c_prd_emp_id;}
		}
		/// <summary>
		/// 连铸主键
		/// </summary>
		public string C_CCM_NO
		{
			set{ _c_ccm_no=value;}
			get{return _c_ccm_no;}
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
		public decimal N_HL_TIME
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
		public decimal N_DFP_HL_TIME
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
		/// 分组排序号
		/// </summary>
		public decimal? N_SORT
		{
			set{ _n_sort=value;}
			get{return _n_sort;}
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
		/// 修磨要求
		/// </summary>
		public string C_XM_YQ
		{
			set{ _c_xm_yq=value;}
			get{return _c_xm_yq;}
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
		/// 连铸
		/// </summary>
		public string C_CCM_CODE
		{
			set{ _c_ccm_code=value;}
			get{return _c_ccm_code;}
		}
		/// <summary>
		/// 可排连铸
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
		#endregion Model

	}
}

