using System;
namespace RV.MODEL
{
	/// <summary>
	/// 用户表
	/// </summary>
	[Serializable]
	public partial class ModTS_USER
	{
		public ModTS_USER()
		{}
		#region Model
		private string _c_id;
		private string _c_name;
		private string _c_account;
		private string _c_password;
		private string _c_email;
		private string _c_mobile;
		private decimal? _n_status = 1;
		private decimal? _n_type;
		private string _c_desc;
		private DateTime? _d_lastlogintime;
		private string _c_emp_id;
		private string _c_emp_name;
		private DateTime? _d_mod_dt;
		private string _c_mobile2;
		private string _c_phone;
		private string _c_shortname;
		/// <summary>
		/// 主键
		/// </summary>
		public string C_ID
		{
			set{ _c_id=value;}
			get{return _c_id;}
		}
		/// <summary>
		/// 名称
		/// </summary>
		public string C_NAME
		{
			set{ _c_name=value;}
			get{return _c_name;}
		}
		/// <summary>
		/// 用户名
		/// </summary>
		public string C_ACCOUNT
		{
			set{ _c_account=value;}
			get{return _c_account;}
		}
		/// <summary>
		/// 密码
		/// </summary>
		public string C_PASSWORD
		{
			set{ _c_password=value;}
			get{return _c_password;}
		}
		/// <summary>
		/// 邮箱
		/// </summary>
		public string C_EMAIL
		{
			set{ _c_email=value;}
			get{return _c_email;}
		}
		/// <summary>
		/// 手机
		/// </summary>
		public string C_MOBILE
		{
			set{ _c_mobile=value;}
			get{return _c_mobile;}
		}
		/// <summary>
		/// 用户状态
		/// </summary>
		public decimal? N_STATUS
        {
			set{ _n_status = value;}
			get{return _n_status; }
		}
		/// <summary>
		/// 用户类型
		/// </summary>
		public decimal? N_TYPE
		{
			set{ _n_type=value;}
			get{return _n_type;}
		}
		/// <summary>
		/// 描述
		/// </summary>
		public string C_DESC
		{
			set{ _c_desc=value;}
			get{return _c_desc;}
		}
		/// <summary>
		/// 最后登陆时间
		/// </summary>
		public DateTime? D_LASTLOGINTIME
		{
			set{ _d_lastlogintime=value;}
			get{return _d_lastlogintime;}
		}
		/// <summary>
		/// 系统操作人编号
		/// </summary>
		public string C_EMP_ID
		{
			set{ _c_emp_id=value;}
			get{return _c_emp_id;}
		}
		/// <summary>
		/// 系统操作人姓名
		/// </summary>
		public string C_EMP_NAME
		{
			set{ _c_emp_name=value;}
			get{return _c_emp_name;}
		}
		/// <summary>
		/// 系系统操作时间
		/// </summary>
		public DateTime? D_MOD_DT
		{
			set{ _d_mod_dt=value;}
			get{return _d_mod_dt;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string C_MOBILE2
		{
			set{ _c_mobile2=value;}
			get{return _c_mobile2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string C_PHONE
		{
			set{ _c_phone=value;}
			get{return _c_phone;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string C_SHORTNAME
		{
			set{ _c_shortname=value;}
			get{return _c_shortname;}
		}
		#endregion Model

	}
}

