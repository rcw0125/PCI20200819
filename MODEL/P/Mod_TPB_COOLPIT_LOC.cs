using System;
namespace MODEL
{
	/// <summary>
	/// 缓冷坑坑位信息
	/// </summary>
	[Serializable]
	public partial class Mod_TPB_COOLPIT_LOC
	{
		public Mod_TPB_COOLPIT_LOC()
		{}
		#region Model
		private string _c_id= "sys_guid";
		private string _c_coolpit_area_id;
		private string _c_coolpit_loc_code;
		private string _c_coolpit_loc_name;
		private DateTime? _d_start_date= Convert.ToDateTime(DateTime.Now);
		private DateTime? _d_end_date;
		private decimal _n_status=1;
		private string _c_remark;
		private string _c_emp_id;
		private DateTime _d_mod_dt= Convert.ToDateTime(DateTime.Now);
		private decimal? _n_coolpit_loc_cap;
		private decimal? _n_coolpit_tier;
        private string _c_slab_type;
        /// <summary>
        /// 主键
        /// </summary>
        public string C_ID
		{
			set{ _c_id=value;}
			get{return _c_id;}
		}
		/// <summary>
		/// 区域
		/// </summary>
		public string C_COOLPIT_AREA_ID
		{
			set{ _c_coolpit_area_id=value;}
			get{return _c_coolpit_area_id;}
		}
		/// <summary>
		/// 缓冷坑坑位编号
		/// </summary>
		public string C_COOLPIT_LOC_CODE
		{
			set{ _c_coolpit_loc_code=value;}
			get{return _c_coolpit_loc_code;}
		}
		/// <summary>
		/// 缓冷坑坑位描述
		/// </summary>
		public string C_COOLPIT_LOC_NAME
		{
			set{ _c_coolpit_loc_name=value;}
			get{return _c_coolpit_loc_name;}
		}
		/// <summary>
		/// 启用时间
		/// </summary>
		public DateTime? D_START_DATE
		{
			set{ _d_start_date=value;}
			get{return _d_start_date;}
		}
		/// <summary>
		/// 停用时间
		/// </summary>
		public DateTime? D_END_DATE
		{
			set{ _d_end_date=value;}
			get{return _d_end_date;}
		}
		/// <summary>
		/// 状态0停用1启用
		/// </summary>
		public decimal N_STATUS
		{
			set{ _n_status=value;}
			get{return _n_status;}
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
		/// 库位容量
		/// </summary>
		public decimal? N_COOLPIT_LOC_CAP
		{
			set{ _n_coolpit_loc_cap=value;}
			get{return _n_coolpit_loc_cap;}
		}
		/// <summary>
		/// 层数
		/// </summary>
		public decimal? N_COOLPIT_TIER
		{
			set{ _n_coolpit_tier=value;}
			get{return _n_coolpit_tier;}
		}
        /// <summary>
		/// 钢坯类型大方坯/小方坯/圆坯
		/// </summary>
		public string C_SLAB_TYPE
        {
            set { _c_slab_type = value; }
            get { return _c_slab_type; }
        }
        #endregion Model

    }
}

