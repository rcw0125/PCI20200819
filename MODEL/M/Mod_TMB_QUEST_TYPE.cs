using System;
namespace MODEL
{
	/// <summary>
	/// 问题类型（技术咨询使用）
	/// </summary>
	[Serializable]
	public partial class Mod_TMB_QUEST_TYPE
	{
		public Mod_TMB_QUEST_TYPE()
		{}
		#region Model
		private string _c_id;
		private string _c_type_name;
		private string _c_remark;
		private string _c_emp_id;
		private DateTime? _d_mod_dt= Convert.ToDateTime(DateTime.Now);
		/// <summary>
		/// 主键
		/// </summary>
		public string C_ID
		{
			set{ _c_id=value;}
			get{return _c_id;}
		}
		/// <summary>
		/// 类型名称
		/// </summary>
		public string C_TYPE_NAME
		{
			set{ _c_type_name=value;}
			get{return _c_type_name;}
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
		public DateTime? D_MOD_DT
		{
			set{ _d_mod_dt=value;}
			get{return _d_mod_dt;}
		}
		#endregion Model

	}
}

