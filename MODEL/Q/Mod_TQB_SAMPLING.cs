using System;
namespace MODEL
{
	/// <summary>
	/// 取样名称
	/// </summary>
	[Serializable]
	public partial class Mod_TQB_SAMPLING
	{
		public Mod_TQB_SAMPLING()
		{}
		#region Model
		private string _c_id= "sys_guid";
		private string _c_sampling_code;
		private string _c_sampling_name;
		private decimal _n_status=1;
		private string _c_remark;
		private string _c_emp_id;
		private DateTime _d_mod_dt= Convert.ToDateTime(DateTime.Now);
        private decimal _n_sampling_sn;
        private string _c_check_depmt;
        /// <summary>
        /// 主键
        /// </summary>
        public string C_ID
		{
			set{ _c_id=value;}
			get{return _c_id;}
		}
		/// <summary>
		/// 项目代码
		/// </summary>
		public string C_SAMPLING_CODE
		{
			set{ _c_sampling_code=value;}
			get{return _c_sampling_code;}
		}
		/// <summary>
		/// 项目名称
		/// </summary>
		public string C_SAMPLING_NAME
		{
			set{ _c_sampling_name=value;}
			get{return _c_sampling_name;}
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

        /// <summary>
		/// 顺序号
		/// </summary>
		public decimal N_SAMPLING_SN
        {
            set { _n_sampling_sn = value; }
            get { return _n_sampling_sn; }
        }
        /// <summary>
		/// 检测部门
		/// </summary>
		public string C_CHECK_DEPMT
        {
            set { _c_check_depmt = value; }
            get { return _c_check_depmt; }
        }
        #endregion Model

    }
}

