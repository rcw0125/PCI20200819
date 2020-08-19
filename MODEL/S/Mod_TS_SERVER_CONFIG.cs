using System;
namespace MODEL
{
	/// <summary>
	/// 服务器参数配置表
	/// </summary>
	[Serializable]
	public partial class Mod_TS_SERVER_CONFIG
    {
		public Mod_TS_SERVER_CONFIG()
		{}
		#region Model
		private string _c_id;
		private string _c_url;
		private string _c_file;
		private string _c_username;
		private string _c_password;
		private string _c_type;
		private string _c_use;
		private string _c_remark;
		private string _c_no;
		/// <summary>
		/// 主键
		/// </summary>
		public string C_ID
		{
			set{ _c_id=value;}
			get{return _c_id;}
		}
		/// <summary>
		/// 地址
		/// </summary>
		public string C_URL
		{
			set{ _c_url=value;}
			get{return _c_url;}
		}
		/// <summary>
		/// 文件地址（名）
		/// </summary>
		public string C_FILE
		{
			set{ _c_file=value;}
			get{return _c_file;}
		}
		/// <summary>
		/// 用户名
		/// </summary>
		public string C_USERNAME
		{
			set{ _c_username=value;}
			get{return _c_username;}
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
		/// 类型（ftp/http/tcp/db）
		/// </summary>
		public string C_TYPE
		{
			set{ _c_type=value;}
			get{return _c_type;}
		}
		/// <summary>
		/// 用途说明
		/// </summary>
		public string C_USE
		{
			set{ _c_use=value;}
			get{return _c_use;}
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
		/// 用途代码
		/// </summary>
		public string C_NO
		{
			set{ _c_no=value;}
			get{return _c_no;}
		}
		#endregion Model

	}
}

