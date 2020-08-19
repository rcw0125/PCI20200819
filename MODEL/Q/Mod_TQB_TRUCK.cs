using System;
namespace MODEL
{
	/// <summary>
	/// 装车检查
	/// </summary>
	[Serializable]
	public partial class Mod_TQB_TRUCK
	{
		public Mod_TQB_TRUCK()
		{}
		#region Model
		private string _c_id;
		private DateTime _d_truck_dt= Convert.ToDateTime(DateTime.Now);
		private string _c_truck_num;
		private string _c_shipment_batch;
		private string _c_stl_grd;
		private string _c_loading_quantity;
		private string _c_cre_abrade;
		private string _c_cre_abrade_tick;
		private string _c_back_abrade;
		private string _c_back_abrade_tick;
		private string _c_superintendent;
		private decimal _n_status=1;
		private string _c_remark;
		private string _c_emp_id;
		private DateTime _d_mod_dt= Convert.ToDateTime(DateTime.Now);
		/// <summary>
		/// 主键
		/// </summary>
		public string C_ID
		{
			set{ _c_id=value;}
			get{return _c_id;}
		}
		/// <summary>
		/// 装车日期
		/// </summary>
		public DateTime D_TRUCK_DT
		{
			set{ _d_truck_dt=value;}
			get{return _d_truck_dt;}
		}
		/// <summary>
		/// 车号
		/// </summary>
		public string C_TRUCK_NUM
		{
			set{ _c_truck_num=value;}
			get{return _c_truck_num;}
		}
		/// <summary>
		/// 发运批次
		/// </summary>
		public string C_SHIPMENT_BATCH
		{
			set{ _c_shipment_batch=value;}
			get{return _c_shipment_batch;}
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
		/// 装车件数
		/// </summary>
		public string C_LOADING_QUANTITY
		{
			set{ _c_loading_quantity=value;}
			get{return _c_loading_quantity;}
		}
		/// <summary>
		/// 装车前擦伤
		/// </summary>
		public string C_CRE_ABRADE
		{
			set{ _c_cre_abrade=value;}
			get{return _c_cre_abrade;}
		}
		/// <summary>
		/// 装车前擦伤钩号
		/// </summary>
		public string C_CRE_ABRADE_TICK
		{
			set{ _c_cre_abrade_tick=value;}
			get{return _c_cre_abrade_tick;}
		}
		/// <summary>
		/// 装车后擦伤
		/// </summary>
		public string C_BACK_ABRADE
		{
			set{ _c_back_abrade=value;}
			get{return _c_back_abrade;}
		}
		/// <summary>
		/// 装车后擦伤钩号
		/// </summary>
		public string C_BACK_ABRADE_TICK
		{
			set{ _c_back_abrade_tick=value;}
			get{return _c_back_abrade_tick;}
		}
		/// <summary>
		/// 监督人
		/// </summary>
		public string C_SUPERINTENDENT
		{
			set{ _c_superintendent=value;}
			get{return _c_superintendent;}
		}
		/// <summary>
		/// 使用状态   1-可用；0-停用
		/// </summary>
		public decimal N_STATUS
		{
			set{ _n_status=value;}
			get{return _n_status;}
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
		#endregion Model

	}
}

