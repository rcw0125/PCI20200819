using System;
namespace MODEL
{
    /// <summary>
    /// 高炉铁水计划
    /// </summary>
    [Serializable]
	public partial class Mod_TPA_TS_PLAN
    {
		public Mod_TPA_TS_PLAN()
		{}
		#region Model
		private string _c_id= "sys_guid";
		private string _c_steel_type;
		private DateTime? _d_plan_time;
		private DateTime? _d_arrive_time;
		private decimal? _n_steel_wgt;
		private DateTime _d_plan_date= Convert.ToDateTime(DateTime.Now);
		private DateTime _d_sj_time;
		private decimal? _n_sj_wgt;
		/// <summary>
		/// 主键
		/// </summary>
		public string C_ID
		{
			set{ _c_id=value;}
			get{return _c_id;}
		}
		/// <summary>
		/// 铁水类型
		/// </summary>
		public string C_STEEL_TYPE
		{
			set{ _c_steel_type=value;}
			get{return _c_steel_type;}
		}
		/// <summary>
		/// 计划出铁时间
		/// </summary>
		public DateTime? D_PLAN_TIME
		{
			set{ _d_plan_time=value;}
			get{return _d_plan_time;}
		}
		/// <summary>
		/// 计划到达转炉时间
		/// </summary>
		public DateTime? D_ARRIVE_TIME
		{
			set{ _d_arrive_time=value;}
			get{return _d_arrive_time;}
		}
		/// <summary>
		/// 计划出铁量
		/// </summary>
		public decimal? N_STEEL_WGT
		{
			set{ _n_steel_wgt=value;}
			get{return _n_steel_wgt;}
		}
		/// <summary>
		/// 计划生成时间
		/// </summary>
		public DateTime D_PLAN_DATE
		{
			set{ _d_plan_date=value;}
			get{return _d_plan_date;}
		}
		/// <summary>
		/// 实际出铁时间
		/// </summary>
		public DateTime D_SJ_TIME
		{
			set{ _d_sj_time=value;}
			get{return _d_sj_time;}
		}
		/// <summary>
		/// 计划出铁量
		/// </summary>
		public decimal? N_SJ_WGT
		{
			set{ _n_sj_wgt=value;}
			get{return _n_sj_wgt;}
		}
		#endregion Model

	}
}

