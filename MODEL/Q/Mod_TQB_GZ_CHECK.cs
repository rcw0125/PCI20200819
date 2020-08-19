using System;
namespace MODEL
{
	/// <summary>
	/// 钢种生产规则
	/// </summary>
	[Serializable]
	public partial class Mod_TQB_GZ_CHECK
	{
		public Mod_TQB_GZ_CHECK()
		{}
		 #region Model
		private string _c_id= "sys_guid";
		private string _c_std_id;
		private string _c_check;
		private string _c_remark;
		private string _c_emp_id;
		private DateTime _d_mod_dt= Convert.ToDateTime(DateTime.Now);
		private string _c_std_main_id;
		/// <summary>
		/// 主键
		/// </summary>
		public string C_ID
		{
			set{ _c_id=value;}
			get{return _c_id;}
		}
		/// <summary>
		/// 执行标准主键
		/// </summary>
		public string C_STD_ID
		{
			set{ _c_std_id=value;}
			get{return _c_std_id;}
		}
		/// <summary>
		/// 能否
		/// </summary>
		public string C_CHECK
		{
			set{ _c_check=value;}
			get{return _c_check;}
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
		/// <summary>
		/// 执行标准匹配主键
		/// </summary>
		public string C_STD_MAIN_ID
		{
			set{ _c_std_main_id=value;}
			get{return _c_std_main_id;}
		}
		#endregion Model

	}
}

