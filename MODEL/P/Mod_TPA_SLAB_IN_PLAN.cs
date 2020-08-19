using System;
namespace MODEL
{
    /// <summary>
    /// 可轧钢坯入库计划
    /// </summary>
    [Serializable]
	public partial class Mod_TPA_SLAB_IN_PLAN
    {
		public Mod_TPA_SLAB_IN_PLAN()
		{}
		#region Model
		private string _c_id= "sys_guid";
		private string _c_fk;
		private string _c_stove_no;
		private string _c_stl_grd;
		private string _c_std_code;
		private decimal? _n_wgt;
		private DateTime? _d_in_stock_time;
		private string _c_plan_cx;
		private DateTime? _d_plan_date= Convert.ToDateTime(DateTime.Now);
		private string _c_remark;
		private decimal _n_status=0;
		private decimal? _n_qua=null;
		private string _c_ccm;
		private string _c_type;
		private DateTime? _d_in_stock_time_sj;
		private decimal? _n_wgt_sj;
		private decimal? _n_qua_sj;
		private decimal? _n_wgt_plan_use;
		private decimal? _n_wgt_sj_use;
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
		/// 计划重量
		/// </summary>
		public decimal? N_WGT
		{
			set{ _n_wgt=value;}
			get{return _n_wgt;}
		}
		/// <summary>
		/// 计划入库时间
		/// </summary>
		public DateTime? D_IN_STOCK_TIME
		{
			set{ _d_in_stock_time=value;}
			get{return _d_in_stock_time;}
		}
		/// <summary>
		/// 计划使用产线
		/// </summary>
		public string C_PLAN_CX
		{
			set{ _c_plan_cx=value;}
			get{return _c_plan_cx;}
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
		/// 备注
		/// </summary>
		public string C_REMARK
		{
			set{ _c_remark=value;}
			get{return _c_remark;}
		}
		/// <summary>
		/// 0未入库1已入库2已使用
		/// </summary>
		public decimal N_STATUS
		{
			set{ _n_status=value;}
			get{return _n_status;}
		}
		/// <summary>
		/// 计划支数
		/// </summary>
		public decimal? N_QUA
		{
			set{ _n_qua=value;}
			get{return _n_qua;}
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
		/// 类型（库存坯/计划坯）
		/// </summary>
		public string C_TYPE
		{
			set{ _c_type=value;}
			get{return _c_type;}
		}
		/// <summary>
		/// 实际可用时间
		/// </summary>
		public DateTime? D_IN_STOCK_TIME_SJ
		{
			set{ _d_in_stock_time_sj=value;}
			get{return _d_in_stock_time_sj;}
		}
		/// <summary>
		/// 实际重量
		/// </summary>
		public decimal? N_WGT_SJ
		{
			set{ _n_wgt_sj=value;}
			get{return _n_wgt_sj;}
		}
		/// <summary>
		/// 实际支数
		/// </summary>
		public decimal? N_QUA_SJ
		{
			set{ _n_qua_sj=value;}
			get{return _n_qua_sj;}
		}
		/// <summary>
		/// 计划已使用重量
		/// </summary>
		public decimal? N_WGT_PLAN_USE
		{
			set{ _n_wgt_plan_use=value;}
			get{return _n_wgt_plan_use;}
		}
		/// <summary>
		/// 实际已使用重量
		/// </summary>
		public decimal? N_WGT_SJ_USE
		{
			set{ _n_wgt_sj_use=value;}
			get{return _n_wgt_sj_use;}
		}
		#endregion Model

	}
}

