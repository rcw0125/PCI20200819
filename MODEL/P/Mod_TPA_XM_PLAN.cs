using System;
namespace MODEL
{
    /// <summary>
    /// 修磨计划
    /// </summary>
    [Serializable]
	public partial class Mod_TPA_XM_PLAN
	{
		public Mod_TPA_XM_PLAN()
		{}
		#region Model
		private string _c_id= "sys_guid";
		private string _c_stove_no;
		private string _c_stl_grd;
		private string _c_std_code;
		private decimal? _n_wgt;
		private decimal? _n_act_wgt;
		private DateTime? _d_start_time;
		private DateTime? _d_end_time;
		private decimal? _n_cn;
		private DateTime? _d_plan_date= Convert.ToDateTime(DateTime.Now);
		private string _c_xmyq;
		private string _c_xm_type;
		private string _c_remark;
		private decimal _n_status=0 ;
		private string _c_ccm;
		private DateTime? _d_start_time_sj;
		private DateTime? _d_end_time_sj;
		private string _c_fk;
		private decimal? _n_sort;
		/// <summary>
		/// 主键
		/// </summary>
		public string C_ID
		{
			set{ _c_id=value;}
			get{return _c_id;}
		}
		/// <summary>
		/// 计划炉号
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
		/// 完成重量
		/// </summary>
		public decimal? N_ACT_WGT
		{
			set{ _n_act_wgt=value;}
			get{return _n_act_wgt;}
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
		/// 理论产能碳钢400t/d;不锈钢100t/d
		/// </summary>
		public decimal? N_CN
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
		/// 修磨要求
		/// </summary>
		public string C_XMYQ
		{
			set{ _c_xmyq=value;}
			get{return _c_xmyq;}
		}
		/// <summary>
		/// 修磨计划类型 碳钢/不锈钢
		/// </summary>
		public string C_XM_TYPE
		{
			set{ _c_xm_type=value;}
			get{return _c_xm_type;}
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
		/// 计划主键
		/// </summary>
		public string C_FK
		{
			set{ _c_fk=value;}
			get{return _c_fk;}
		}
		/// <summary>
		/// 修磨顺序
		/// </summary>
		public decimal? N_SORT
		{
			set{ _n_sort=value;}
			get{return _n_sort;}
		}
		#endregion Model

	}
}

