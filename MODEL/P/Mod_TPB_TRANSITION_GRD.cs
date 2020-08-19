using System;
namespace MODEL
{
	/// <summary>
	/// 炼钢生产需过度产品钢种
	/// </summary>
	[Serializable]
	public partial class Mod_TPB_TRANSITION_GRD
	{
		public Mod_TPB_TRANSITION_GRD()
		{}
		#region Model
		private string _c_id;
		private string _c_stl_grd;
		private string _c_transition_grd;
		private decimal? _n_level;
		private string _c_remark;
		private decimal _n_status=1;
		private string _c_emp_id;
		private DateTime _d_mod_dt= Convert.ToDateTime(DateTime.Now);
		private DateTime? _d_start_date= Convert.ToDateTime(DateTime.Now);
		private DateTime? _d_end_date;
		/// <summary>
		/// 
		/// </summary>
		public string C_ID
		{
			set{ _c_id=value;}
			get{return _c_id;}
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
		/// 过渡钢种
		/// </summary>
		public string C_TRANSITION_GRD
		{
			set{ _c_transition_grd=value;}
			get{return _c_transition_grd;}
		}
		/// <summary>
		/// 优先级
		/// </summary>
		public decimal? N_LEVEL
		{
			set{ _n_level=value;}
			get{return _n_level;}
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
		/// 状态0停用1启用
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
		#endregion Model

	}
}

