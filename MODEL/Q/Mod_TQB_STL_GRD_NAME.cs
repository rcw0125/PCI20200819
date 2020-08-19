using System;
namespace MODEL
{
    /// <summary>
    /// 钢种品名信息
    /// </summary>
    [Serializable]
	public partial class Mod_TQB_STL_GRD_NAME
    {
		public Mod_TQB_STL_GRD_NAME()
		{}
		#region Model
		private string _c_id= "sys_guid";
		private string _c_code;
		private string _c_name;
		private decimal _n_sort=1M;
		private decimal _n_status=1M;
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
		/// 品名代码
		/// </summary>
		public string C_CODE
		{
			set{ _c_code=value;}
			get{return _c_code;}
		}
		/// <summary>
		/// 品名名称
		/// </summary>
		public string C_NAME
		{
			set{ _c_name=value;}
			get{return _c_name;}
		}
		/// <summary>
		/// 顺序号
		/// </summary>
		public decimal N_SORT
		{
			set{ _n_sort=value;}
			get{return _n_sort;}
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

