using System;
namespace MODEL
{
	/// <summary>
	/// 标准文档管理
	/// </summary>
	[Serializable]
	public partial class Mod_TQB_STD_FILE
	{
		public Mod_TQB_STD_FILE()
		{}
		#region Model
		private string _c_id;
		private string _c_std_file_type_id;
		private string _c_std_file_code;
		private string _c_std_file_name;
        private string _c_std_file_path;
        private string _c_file_name;
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
		/// 标准文档类型表主键
		/// </summary>
		public string C_STD_FILE_TYPE_ID
		{
			set{ _c_std_file_type_id=value;}
			get{return _c_std_file_type_id;}
		}
		/// <summary>
		/// 标准文档代码
		/// </summary>
		public string C_STD_FILE_CODE
		{
			set{ _c_std_file_code=value;}
			get{return _c_std_file_code;}
		}
		/// <summary>
		/// 标准文档名称
		/// </summary>
		public string C_STD_FILE_NAME
		{
			set{ _c_std_file_name=value;}
			get{return _c_std_file_name;}
		}
        /// <summary>
		/// 文档地址
		/// </summary>
		public string C_STD_FILE_PATH
        {
            set { _c_std_file_path = value; }
            get { return _c_std_file_path; }
        }
        /// <summary>
        /// 上传的文档名称
        /// </summary>
        public string C_FILE_NAME
		{
			set{ _c_file_name=value;}
			get{return _c_file_name;}
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

