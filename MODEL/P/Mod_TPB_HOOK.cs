using System;
namespace MODEL
{
    /// <summary>
    /// 钩号
    /// </summary>
    [Serializable]
	public partial class Mod_TPB_HOOK
	{
		public Mod_TPB_HOOK()
		{}
		#region Model
		private string _c_id= "sys_guid";
		private string _c_sta_id;
		private decimal? _n_hook_no;
		private decimal _n_status=1;
		private string _c_emp_id;
		private DateTime _d_mod_dt= Convert.ToDateTime(DateTime.Now);
		private string _c_remark;
		/// <summary>
		/// 主键
		/// </summary>
		public string C_ID
		{
			set{ _c_id=value;}
			get{return _c_id;}
		}
		/// <summary>
		/// 轧线主键
		/// </summary>
		public string C_STA_ID
		{
			set{ _c_sta_id=value;}
			get{return _c_sta_id;}
		}
		/// <summary>
		/// 钩号
		/// </summary>
		public decimal? N_HOOK_NO
		{
			set{ _n_hook_no=value;}
			get{return _n_hook_no;}
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
		/// <summary>
		/// 备注
		/// </summary>
		public string C_REMARK
		{
			set{ _c_remark=value;}
			get{return _c_remark;}
		}
		#endregion Model

	}
}

