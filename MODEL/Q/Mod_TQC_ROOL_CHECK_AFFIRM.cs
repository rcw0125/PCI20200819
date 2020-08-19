using System;
namespace MODEL
{
	/// <summary>
	/// 线材库检确认
	/// </summary>
	[Serializable]
	public partial class Mod_TQC_ROOL_CHECK_AFFIRM
	{
		public Mod_TQC_ROOL_CHECK_AFFIRM()
		{}
		#region Model
		private string _c_id= "sys_guid";
		private string _c_we_check_rool_id;
		private string _c_suggestion;
		private decimal _n_status=1  ;
		private string _c_remark;
		private string _c_check_emp_id;
		private DateTime _d_check_dt= Convert.ToDateTime(DateTime.Now);
		/// <summary>
		/// 主键
		/// </summary>
		public string C_ID
		{
			set{ _c_id=value;}
			get{return _c_id;}
		}
		/// <summary>
		/// 线材库检信息外键
		/// </summary>
		public string C_WE_CHECK_ROOL_ID
		{
			set{ _c_we_check_rool_id=value;}
			get{return _c_we_check_rool_id;}
		}
		/// <summary>
		/// 审核意见
		/// </summary>
		public string C_SUGGESTION
		{
			set{ _c_suggestion=value;}
			get{return _c_suggestion;}
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
		/// 确认人
		/// </summary>
		public string C_CHECK_EMP_ID
		{
			set{ _c_check_emp_id=value;}
			get{return _c_check_emp_id;}
		}
		/// <summary>
		/// 确认时间
		/// </summary>
		public DateTime D_CHECK_DT
		{
			set{ _d_check_dt=value;}
			get{return _d_check_dt;}
		}
		#endregion Model

	}
}

