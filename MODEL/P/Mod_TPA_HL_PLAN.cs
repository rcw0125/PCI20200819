using System;
namespace MODEL
{
    /// <summary>
    /// 钢坯缓冷计划
    /// </summary>
    [Serializable]
	public partial class Mod_TPA_HL_PLAN
    {
		public Mod_TPA_HL_PLAN()
		{}
		#region Model
		private string _c_id= "sys_guid";
		private string _c_fk;
		private string _c_stove_no;
		private string _c_stl_grd;
		private string _c_std_code;
		private string _c_wh_code;
		private string _c_slab_type;
		private DateTime? _d_start_time;
		private DateTime? _d_end_time;
		private decimal? _n_hl_time;
		private DateTime? _d_plan_date= Convert.ToDateTime(DateTime.Now);
		private string _c_hlyq;
		private string _c_remark;
		private decimal _n_status=0;
		private string _c_ccm;
		private decimal? _n_qua;
		private decimal? _n_cap;
		private decimal? _n_total_qua;
		private DateTime? _d_start_time_sj;
		private DateTime? _d_end_time_sj;
		private decimal? _n_qua_sj;
		private string _c_wh_code_sj;
		private DateTime? _d_over_time;
		private decimal? _n_num;
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
		/// 计划缓冷坑编码
		/// </summary>
		public string C_WH_CODE
		{
			set{ _c_wh_code=value;}
			get{return _c_wh_code;}
		}
		/// <summary>
		/// 缓冷钢坯类型（大方坯/热轧钢坯）
		/// </summary>
		public string C_SLAB_TYPE
		{
			set{ _c_slab_type=value;}
			get{return _c_slab_type;}
		}
		/// <summary>
		/// 入坑时间
		/// </summary>
		public DateTime? D_START_TIME
		{
			set{ _d_start_time=value;}
			get{return _d_start_time;}
		}
		/// <summary>
		/// 出坑时间
		/// </summary>
		public DateTime? D_END_TIME
		{
			set{ _d_end_time=value;}
			get{return _d_end_time;}
		}
		/// <summary>
		/// 缓冷时间
		/// </summary>
		public decimal? N_HL_TIME
		{
			set{ _n_hl_time=value;}
			get{return _n_hl_time;}
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
		/// 缓冷要求
		/// </summary>
		public string C_HLYQ
		{
			set{ _c_hlyq=value;}
			get{return _c_hlyq;}
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
		/// 0未完成1已完成
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
		/// 入坑支数
		/// </summary>
		public decimal? N_QUA
		{
			set{ _n_qua=value;}
			get{return _n_qua;}
		}
		/// <summary>
		/// 容量
		/// </summary>
		public decimal? N_CAP
		{
			set{ _n_cap=value;}
			get{return _n_cap;}
		}
		/// <summary>
		/// 当前累计入坑支数
		/// </summary>
		public decimal? N_TOTAL_QUA
		{
			set{ _n_total_qua=value;}
			get{return _n_total_qua;}
		}
		/// <summary>
		/// 实际入坑时间
		/// </summary>
		public DateTime? D_START_TIME_SJ
		{
			set{ _d_start_time_sj=value;}
			get{return _d_start_time_sj;}
		}
		/// <summary>
		/// 实际出坑时间
		/// </summary>
		public DateTime? D_END_TIME_SJ
		{
			set{ _d_end_time_sj=value;}
			get{return _d_end_time_sj;}
		}
		/// <summary>
		/// 实际入坑支数
		/// </summary>
		public decimal? N_QUA_SJ
		{
			set{ _n_qua_sj=value;}
			get{return _n_qua_sj;}
		}
		/// <summary>
		/// 实际缓冷坑编码
		/// </summary>
		public string C_WH_CODE_SJ
		{
			set{ _c_wh_code_sj=value;}
			get{return _c_wh_code_sj;}
		}
		/// <summary>
		/// 当前坑缓冷结束时间
		/// </summary>
		public DateTime? D_OVER_TIME
		{
			set{ _d_over_time=value;}
			get{return _d_over_time;}
		}
		/// <summary>
		/// 当前坑缓冷计划次数
		/// </summary>
		public decimal? N_NUM
		{
			set{ _n_num=value;}
			get{return _n_num;}
		}
		#endregion Model

	}
}

