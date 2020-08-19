using System;
namespace MODEL
{
    /// <summary>
    /// 取样名称配置
    /// </summary>
    [Serializable]
	public partial class Mod_TQB_SAMPLING_GROUP
	{
		public Mod_TQB_SAMPLING_GROUP()
		{}
		#region Model
		private string _c_id= "sys_guid";
		private string _c_physics_group_id;
		private string _c_sampling_id;
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
		/// 物理性能外键
		/// </summary>
		public string C_PHYSICS_GROUP_ID
		{
			set{ _c_physics_group_id=value;}
			get{return _c_physics_group_id;}
		}
		/// <summary>
		/// 取样名称外键
		/// </summary>
		public string C_SAMPLING_ID
		{
			set{ _c_sampling_id=value;}
			get{return _c_sampling_id;}
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
		/// 操作人员
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
		#endregion Model

	}
}

