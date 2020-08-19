using System;
namespace MODEL
{
	/// <summary>
	/// 线材库库位
	/// </summary>
	[Serializable]
	public partial class Mod_TPB_LINEWH_LOC
	{
		public Mod_TPB_LINEWH_LOC()
		{}
		#region Model
		private string _c_id= "sys_guid";
		private string _c_linewh_area_id;
		private string _c_linewh_loc_code;
		private string _c_linewh_loc_name;
		private DateTime _d_start_date= Convert.ToDateTime(DateTime.Now);
		private DateTime? _d_end_date;
		private decimal _n_status=1 ;
		private string _c_remark;
		private string _c_emp_id;
		private DateTime _d_mod_dt= Convert.ToDateTime(DateTime.Now);
		private string _c_isout="Y";
		private string _c_loading_mode;
		private decimal _n_qty=36  ;
		/// <summary>
		/// 主键
		/// </summary>
		public string C_ID
		{
			set{ _c_id=value;}
			get{return _c_id;}
		}
		/// <summary>
		/// 区域
		/// </summary>
		public string C_LINEWH_AREA_ID
		{
			set{ _c_linewh_area_id=value;}
			get{return _c_linewh_area_id;}
		}
		/// <summary>
		/// 库位编号
		/// </summary>
		public string C_LINEWH_LOC_CODE
		{
			set{ _c_linewh_loc_code=value;}
			get{return _c_linewh_loc_code;}
		}
		/// <summary>
		/// 库位描述
		/// </summary>
		public string C_LINEWH_LOC_NAME
		{
			set{ _c_linewh_loc_name=value;}
			get{return _c_linewh_loc_name;}
		}
		/// <summary>
		/// 启用时间
		/// </summary>
		public DateTime D_START_DATE
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
		/// <summary>
		/// 状态0停用1启用
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
		/// 是否室外
		/// </summary>
		public string C_ISOUT
		{
			set{ _c_isout=value;}
			get{return _c_isout;}
		}
		/// <summary>
		/// 装车方式
		/// </summary>
		public string C_LOADING_MODE
		{
			set{ _c_loading_mode=value;}
			get{return _c_loading_mode;}
		}
		/// <summary>
		/// 件数
		/// </summary>
		public decimal N_QTY
		{
			set{ _n_qty=value;}
			get{return _n_qty;}
		}
		#endregion Model

	}
}

