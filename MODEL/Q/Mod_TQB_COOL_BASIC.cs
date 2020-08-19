using System;
namespace MODEL
{
	/// <summary>
	/// 缓冷要求基础数据
	/// </summary>
	[Serializable]
	public partial class Mod_TQB_COOL_BASIC
	{
		public Mod_TQB_COOL_BASIC()
		{}
		#region Model
		private string _c_id= "sys_guid";
		private decimal? _n_cool_dt;
		private string _c_heat="是";
		private string _c_type;
		private string _c_cool_craft_code;
		private string _c_cool_craft;
		private string _c_hot_t;
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
		/// 缓冷时间
		/// </summary>
		public decimal? N_COOL_DT
		{
			set{ _n_cool_dt=value;}
			get{return _n_cool_dt;}
		}
		/// <summary>
		/// 是否热装   1-是；0-否
		/// </summary>
		public string C_HEAT
		{
			set{ _c_heat=value;}
			get{return _c_heat;}
		}
		/// <summary>
		/// 类型
		/// </summary>
		public string C_TYPE
		{
			set{ _c_type=value;}
			get{return _c_type;}
		}
		/// <summary>
		/// 缓冷工艺代码
		/// </summary>
		public string C_COOL_CRAFT_CODE
		{
			set{ _c_cool_craft_code=value;}
			get{return _c_cool_craft_code;}
		}
		/// <summary>
		/// 缓冷工艺
		/// </summary>
		public string C_COOL_CRAFT
		{
			set{ _c_cool_craft=value;}
			get{return _c_cool_craft;}
		}
		/// <summary>
		/// 热装温度/℃
		/// </summary>
		public string C_HOT_T
		{
			set{ _c_hot_t=value;}
			get{return _c_hot_t;}
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

