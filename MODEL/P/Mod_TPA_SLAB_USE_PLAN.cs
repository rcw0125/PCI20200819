using System;
namespace MODEL
{
    /// <summary>
    /// 可轧钢坯入库计划
    /// </summary>
    [Serializable]
	public partial class Mod_TPA_SLAB_USE_PLAN
    {
		public Mod_TPA_SLAB_USE_PLAN()
		{}
		#region Model
		private string _c_id= "sys_guid";
		private string _c_fk;
		private string _c_stove_no;
		private string _c_stl_grd;
		private string _c_std_code;
		private decimal? _n_wgt;
		private DateTime? _d_plan_date= Convert.ToDateTime(DateTime.Now);
		private string _c_remark;
		private decimal _n_status=0;
		private decimal? _n_qua;
		private string _c_ccm;
		private DateTime? _d_out_stock_time;
		private string _c_use_cx;
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
		/// 使用重量
		/// </summary>
		public decimal? N_WGT
		{
			set{ _n_wgt=value;}
			get{return _n_wgt;}
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
		/// 0未入库1已入库
		/// </summary>
		public decimal N_STATUS
		{
			set{ _n_status=value;}
			get{return _n_status;}
		}
		/// <summary>
		/// 使用支数
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
		/// 计划使用时间
		/// </summary>
		public DateTime? D_OUT_STOCK_TIME
		{
			set{ _d_out_stock_time=value;}
			get{return _d_out_stock_time;}
		}
		/// <summary>
		/// 计划使用产线
		/// </summary>
		public string C_USE_CX
		{
			set{ _c_use_cx=value;}
			get{return _c_use_cx;}
		}
		#endregion Model

	}
}

