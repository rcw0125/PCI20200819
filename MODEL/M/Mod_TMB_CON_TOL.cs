using System;
namespace MODEL
{
	/// <summary>
	/// 合同公差
	/// </summary>
	[Serializable]
	public partial class Mod_TMB_CON_TOL
	{
		public Mod_TMB_CON_TOL()
		{}
		#region Model
		private string _c_id;
		private decimal? _n_min;
		private decimal? _n_max;
		private decimal? _n_num;
		private string _c_remark;
		private string _c_emp_id;
		private DateTime? _d_mod_dt= Convert.ToDateTime(DateTime.Now);
		/// <summary>
		/// 主键
		/// </summary>
		public string C_ID
		{
			set{ _c_id=value;}
			get{return _c_id;}
		}
		/// <summary>
		/// 最小值
		/// </summary>
		public decimal? N_MIN
		{
			set{ _n_min=value;}
			get{return _n_min;}
		}
		/// <summary>
		/// 最大值
		/// </summary>
		public decimal? N_MAX
		{
			set{ _n_max=value;}
			get{return _n_max;}
		}
		/// <summary>
		/// 公差值
		/// </summary>
		public decimal? N_NUM
		{
			set{ _n_num=value;}
			get{return _n_num;}
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
		public DateTime? D_MOD_DT
		{
			set{ _d_mod_dt=value;}
			get{return _d_mod_dt;}
		}
		#endregion Model

	}
}

