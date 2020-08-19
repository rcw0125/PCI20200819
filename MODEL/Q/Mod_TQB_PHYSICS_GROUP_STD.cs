using System;
namespace MODEL
{
	/// <summary>
	/// 物理性能分组匹配执行标准
	/// </summary>
	[Serializable]
	public partial class Mod_TQB_PHYSICS_GROUP_STD
	{
		public Mod_TQB_PHYSICS_GROUP_STD()
		{}
		#region Model
		private string _c_id;
		private string _c_physics_code;
		private string _c_physics_name;
		private string _c_stl_grd;
		private string _c_std_code;
		private decimal _n_status=1;
		private string _c_remark;
		private string _c_emp_id;
		private DateTime _d_mod_dt= Convert.ToDateTime(System.DateTime.Now);
		/// <summary>
		/// 主键
		/// </summary>
		public string C_ID
		{
			set{ _c_id=value;}
			get{return _c_id;}
		}
		/// <summary>
		/// 项目代码
		/// </summary>
		public string C_PHYSICS_CODE
		{
			set{ _c_physics_code=value;}
			get{return _c_physics_code;}
		}
		/// <summary>
		/// 项目名称
		/// </summary>
		public string C_PHYSICS_NAME
		{
			set{ _c_physics_name=value;}
			get{return _c_physics_name;}
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

