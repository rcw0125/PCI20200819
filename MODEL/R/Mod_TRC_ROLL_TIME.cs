using System;
namespace MODEL
{
	/// <summary>
	/// 换钢种规格次数十时间
	/// </summary>
	[Serializable]
	public partial class Mod_TRC_ROLL_TIME
	{
		public Mod_TRC_ROLL_TIME()
		{}
		#region Model
		private string _c_id;
		private string _c_sta_id;
		private string _c_rq;
		private decimal? _n_num_grd;
		private decimal? _n_num_spec;
		private string _c_time_spec;
		/// <summary>
		/// 主键
		/// </summary>
		public string C_ID
		{
			set{ _c_id=value;}
			get{return _c_id;}
		}
		/// <summary>
		/// 工位主键
		/// </summary>
		public string C_STA_ID
		{
			set{ _c_sta_id=value;}
			get{return _c_sta_id;}
		}
		/// <summary>
		/// 日期
		/// </summary>
		public string C_RQ
		{
			set{ _c_rq=value;}
			get{return _c_rq;}
		}
		/// <summary>
		/// 换钢种次数
		/// </summary>
		public decimal? N_NUM_GRD
		{
			set{ _n_num_grd=value;}
			get{return _n_num_grd;}
		}
		/// <summary>
		/// 换规格次数
		/// </summary>
		public decimal? N_NUM_SPEC
		{
			set{ _n_num_spec=value;}
			get{return _n_num_spec;}
		}
		/// <summary>
		/// 换规格时间
		/// </summary>
		public string C_TIME_SPEC
		{
			set{ _c_time_spec=value;}
			get{return _c_time_spec;}
		}
		#endregion Model

	}
}

