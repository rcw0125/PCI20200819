using System;
namespace MODEL
{
	/// <summary>
	/// 物理检验项目配置-设备
	/// </summary>
	[Serializable]
	public partial class Mod_TQB_PHYSICS_EQUIPMENT
	{
		public Mod_TQB_PHYSICS_EQUIPMENT()
		{}
		#region Model
		private string _c_id= "sys_guid";
		private string _c_physics_group_id;
		private string _c_eq_name;
		private string _c_eq_number;
		private string _c_eq_code;
		private decimal _n_status=1 ;
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
		/// 物理分组表主键
		/// </summary>
		public string C_PHYSICS_GROUP_ID
		{
			set{ _c_physics_group_id=value;}
			get{return _c_physics_group_id;}
		}
		/// <summary>
		/// 设备名称
		/// </summary>
		public string C_EQ_NAME
		{
			set{ _c_eq_name=value;}
			get{return _c_eq_name;}
		}
		/// <summary>
		/// 设备型号
		/// </summary>
		public string C_EQ_NUMBER
		{
			set{ _c_eq_number=value;}
			get{return _c_eq_number;}
		}
		/// <summary>
		/// 设备编号
		/// </summary>
		public string C_EQ_CODE
		{
			set{ _c_eq_code=value;}
			get{return _c_eq_code;}
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
		/// 维护人员
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

