using System;
namespace MODEL
{
    /// <summary>
    /// 钢坯开坯计划
    /// </summary>
    [Serializable]
	public partial class Mod_TPA_KP_PLAN
    {
		public Mod_TPA_KP_PLAN()
		{}
		#region Model
		private string _c_id= "sys_guid";
		private string _c_fk;
		private string _c_stove_no;
		private string _c_stl_grd;
		private string _c_std_code;
		private decimal? _n_wgt;
		private DateTime? _d_start_time;
		private DateTime? _d_end_time;
		private decimal _n_cn=114;
		private DateTime? _d_plan_date= Convert.ToDateTime(DateTime.Now);
		private string _c_remark;
		private decimal _n_status=0 ;
		private string _c_ccm;
		private DateTime? _d_start_time_sj;
		private DateTime? _d_end_time_sj;
		private string _c_kp_code;
		private decimal _n_sort=0 ;
		private string _c_matrl_code_slab;
		private string _c_matrl_name_slab;
		private decimal? _n_slab_length;
		private decimal? _n_slab_pw;
		private string _c_matrl_code_kp;
		private string _c_matrl_name_kp;
		private string _c_kp_size;
		private decimal? _n_kp_length;
		private decimal? _n_kp_pw;
		private string _c_dhl;
		private DateTime? _d_can_start_time;
		private string _c_dfp_rz;
		private string _c_rzp_rz;
		private string _c_dfp_yq;
		private string _c_rzp_yq;
        private string _c_slab_size;
        /// <summary>
        /// 主键
        /// </summary>
        public string C_ID
		{
			set{ _c_id=value;}
			get{return _c_id;}
		}
		/// <summary>
		/// 连铸计划主键
		/// </summary>
		public string C_FK
		{
			set{ _c_fk=value;}
			get{return _c_fk;}
		}
		/// <summary>
		/// 炉号
		/// </summary>
		public string C_STOVE_NO
		{
			set{ _c_stove_no=value;}
			get{return _c_stove_no;}
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
		/// 重量
		/// </summary>
		public decimal? N_WGT
		{
			set{ _n_wgt=value;}
			get{return _n_wgt;}
		}
		/// <summary>
		/// 计划开始时间
		/// </summary>
		public DateTime? D_START_TIME
		{
			set{ _d_start_time=value;}
			get{return _d_start_time;}
		}
		/// <summary>
		/// 计划结束时间
		/// </summary>
		public DateTime? D_END_TIME
		{
			set{ _d_end_time=value;}
			get{return _d_end_time;}
		}
		/// <summary>
		/// 开坯机时产能
		/// </summary>
		public decimal N_CN
		{
			set{ _n_cn=value;}
			get{return _n_cn;}
		}
		/// <summary>
		/// 计划生成时间
		/// </summary>
		public DateTime? D_PLAN_DATE
		{
			set{ _d_plan_date=value;}
			get{return _d_plan_date;}
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
		/// 0未排计划1已排计划2已开坯
		/// </summary>
		public decimal N_STATUS
		{
			set{ _n_status=value;}
			get{return _n_status;}
		}
		/// <summary>
		/// 连铸机
		/// </summary>
		public string C_CCM
		{
			set{ _c_ccm=value;}
			get{return _c_ccm;}
		}
		/// <summary>
		/// 实际开始时间
		/// </summary>
		public DateTime? D_START_TIME_SJ
		{
			set{ _d_start_time_sj=value;}
			get{return _d_start_time_sj;}
		}
		/// <summary>
		/// 实际结束时间
		/// </summary>
		public DateTime? D_END_TIME_SJ
		{
			set{ _d_end_time_sj=value;}
			get{return _d_end_time_sj;}
		}
		/// <summary>
		/// 开坯工位
		/// </summary>
		public string C_KP_CODE
		{
			set{ _c_kp_code=value;}
			get{return _c_kp_code;}
		}
		/// <summary>
		/// 排计划序号
		/// </summary>
		public decimal N_SORT
		{
			set{ _n_sort=value;}
			get{return _n_sort;}
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
		/// 是否缓冷
		/// </summary>
		public string C_DHL
		{
			set{ _c_dhl=value;}
			get{return _c_dhl;}
		}
		/// <summary>
		/// 计划可开坯时间
		/// </summary>
		public DateTime? D_CAN_START_TIME
		{
			set{ _d_can_start_time=value;}
			get{return _d_can_start_time;}
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
        /// 连铸钢坯断面
        /// </summary>
        public string C_SLAB_SIZE
        {
            set { _c_slab_size = value; }
            get { return _c_slab_size; }
        }
        #endregion Model

    }
}

