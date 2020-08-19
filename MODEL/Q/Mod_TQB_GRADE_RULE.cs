using System;
namespace MODEL
{
	/// <summary>
	/// 评级准则信息表
	/// </summary>
	[Serializable]
	public partial class Mod_TQB_GRADE_RULE
	{
		public Mod_TQB_GRADE_RULE()
		{}
		#region Model
		private string _c_id;
		private string _c_rule_std_id;
		private string _c_spec_min;
		private string _c_spec_interval;
		private string _c_spec_max;
		private string _c_character_id;
		private string _c_lev;
		private string _c_target_min;
		private string _c_target_interval;
		private string _c_target_max;
		private decimal _n_status=1;
		private string _c_remark;
		private string _c_emp_id;
		private DateTime _d_mod_dt= Convert.ToDateTime(DateTime.Now);
		/// <summary>
		/// 主键
		/// </summary>
		public string C_ID
		{
			set{ _c_id=value;}
			get{return _c_id;}
		}
        /// <summary>
        /// 评级准则执行标准表主键
        /// </summary>
        public string C_RULE_STD_ID
        {
			set{ _c_rule_std_id = value;}
			get{return _c_rule_std_id; }
		}
		/// <summary>
		/// 规格最小值
		/// </summary>
		public string C_SPEC_MIN
		{
			set{ _c_spec_min=value;}
			get{return _c_spec_min;}
		}
		/// <summary>
		/// 规格区间
		/// </summary>
		public string C_SPEC_INTERVAL
		{
			set{ _c_spec_interval=value;}
			get{return _c_spec_interval;}
		}
		/// <summary>
		/// 规格最大值
		/// </summary>
		public string C_SPEC_MAX
		{
			set{ _c_spec_max=value;}
			get{return _c_spec_max;}
		}
		/// <summary>
		/// 检验基础数据表主键
		/// </summary>
		public string C_CHARACTER_ID
		{
			set{ _c_character_id=value;}
			get{return _c_character_id;}
		}
		/// <summary>
		/// 级别
		/// </summary>
		public string C_LEV
		{
			set{ _c_lev=value;}
			get{return _c_lev;}
		}
		/// <summary>
		/// 目标最小值
		/// </summary>
		public string C_TARGET_MIN
		{
			set{ _c_target_min=value;}
			get{return _c_target_min;}
		}
		/// <summary>
		/// 目标值区间
		/// </summary>
		public string C_TARGET_INTERVAL
		{
			set{ _c_target_interval=value;}
			get{return _c_target_interval;}
		}
		/// <summary>
		/// 目标最大值
		/// </summary>
		public string C_TARGET_MAX
		{
			set{ _c_target_max=value;}
			get{return _c_target_max;}
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
		/// 备注
		/// </summary>
		public string C_REMARK
		{
			set{ _c_remark=value;}
			get{return _c_remark;}
		}
		/// <summary>
		/// 维护人
		/// </summary>
		public string C_EMP_ID
		{
			set{ _c_emp_id=value;}
			get{return _c_emp_id;}
		}
		/// <summary>
		/// 维护时间
		/// </summary>
		public DateTime D_MOD_DT
		{
			set{ _d_mod_dt=value;}
			get{return _d_mod_dt;}
		}
		#endregion Model

	}
}

