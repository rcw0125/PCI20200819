﻿using System;
namespace MODEL
{
	/// <summary>
	/// 不合格原因明细
	/// </summary>
	[Serializable]
	public partial class Mod_TQB_FAULT_REASON_DETAILS
	{
		public Mod_TQB_FAULT_REASON_DETAILS()
		{}
		#region Model
		private string _c_id;
		private string _c_reason_type_id;
		private string _c_reason_name;
		private string _c_reason_code;
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
		/// 不合格原因类型表主键
		/// </summary>
		public string C_REASON_TYPE_ID
		{
			set{ _c_reason_type_id=value;}
			get{return _c_reason_type_id;}
		}
		/// <summary>
		/// 不合格原因名称
		/// </summary>
		public string C_REASON_NAME
		{
			set{ _c_reason_name=value;}
			get{return _c_reason_name;}
		}
		/// <summary>
		/// 不合格原因代码
		/// </summary>
		public string C_REASON_CODE
		{
			set{ _c_reason_code=value;}
			get{return _c_reason_code;}
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

