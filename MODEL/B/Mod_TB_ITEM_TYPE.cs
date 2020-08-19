using System;
namespace MODEL
{
	/// <summary>
	/// 项目类别
	/// </summary>
	[Serializable]
	public partial class Mod_TB_ITEM_TYPE
	{
		public Mod_TB_ITEM_TYPE()
		{}
		#region Model
		private string _c_id= "sys_guid";
		private string _c_type;
		private string _c_item_code;
		private string _c_item_name;
		private decimal _n_status=0 ;
		private string _c_emp_id="admin";
		private DateTime _d_mod_dt= Convert.ToDateTime(System.DateTime.Now);
		private DateTime? _d_end_date;
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
		/// 类别
		/// </summary>
		public string C_TYPE
		{
			set{ _c_type=value;}
			get{return _c_type;}
		}
		/// <summary>
		/// 项目代码
		/// </summary>
		public string C_ITEM_CODE
		{
			set{ _c_item_code=value;}
			get{return _c_item_code;}
		}
		/// <summary>
		/// 项目名称
		/// </summary>
		public string C_ITEM_NAME
		{
			set{ _c_item_name=value;}
			get{return _c_item_name;}
		}
		/// <summary>
		/// 状态0未审核1已审核
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
		/// 停用时间
		/// </summary>
		public DateTime? D_END_DATE
		{
			set{ _d_end_date=value;}
			get{return _d_end_date;}
		}
		/// <summary>
		/// 排序
		/// </summary>
		public decimal? N_SORT
		{
			set{ _n_sort=value;}
			get{return _n_sort;}
		}
		#endregion Model

	}
}

