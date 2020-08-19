using System;
namespace MODEL
{
    /// <summary>
    /// 轧钢执行计划表
    /// </summary>
    [Serializable]
	public partial class Mod_TPA_ROLL_ACT_PLAN
    {
		public Mod_TPA_ROLL_ACT_PLAN()
		{}
		#region Model
		private string _c_id= "sys_guid";
		private string _c_line;
		private string _c_stl_grd;
		private string _c_std_code;
		private string _c_spec;
		private decimal? _n_wgt;
		private DateTime _d_plan_date= Convert.ToDateTime(DateTime.Now);
		private DateTime? _d_need_date;
		private string _c_remark;
		private DateTime? _d_start_time;
		private DateTime? _d_end_time;
		private string _c_fk;
		/// <summary>
		/// 主键
		/// </summary>
		public string C_ID
		{
			set{ _c_id=value;}
			get{return _c_id;}
		}
		/// <summary>
		/// 产线
		/// </summary>
		public string C_LINE
		{
			set{ _c_line=value;}
			get{return _c_line;}
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
		/// 规格
		/// </summary>
		public string C_SPEC
		{
			set{ _c_spec=value;}
			get{return _c_spec;}
		}
		/// <summary>
		/// 计划重量
		/// </summary>
		public decimal? N_WGT
		{
			set{ _n_wgt=value;}
			get{return _n_wgt;}
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
		/// 需求日期
		/// </summary>
		public DateTime? D_NEED_DATE
		{
			set{ _d_need_date=value;}
			get{return _d_need_date;}
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
		/// 计划表主键
		/// </summary>
		public string C_FK
		{
			set{ _c_fk=value;}
			get{return _c_fk;}
		}
		#endregion Model

	}
}

