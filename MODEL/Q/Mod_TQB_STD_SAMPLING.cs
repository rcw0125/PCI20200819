using System;
namespace MODEL
{
	/// <summary>
	/// 执行标准取样信息
	/// </summary>
	[Serializable]
	public partial class Mod_TQB_STD_SAMPLING
	{
		public Mod_TQB_STD_SAMPLING()
		{}
		#region Model
		private string _c_id;
		private string _c_std_main_id;
		private string _c_sampling_id; 
        private string _c_number;
		private string _c_sam_spe;
		private string _c_sam_len;
		private string _c_sam_method;
		private string _c_sam_num;
		private string _c_recheck_num;
		private string _c_num_unit;
		private string _c_sam_section;
		private string _c_test_unit;
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
		/// 执行标准主信息外键
		/// </summary>
		public string C_STD_MAIN_ID
		{
			set{ _c_std_main_id=value;}
			get{return _c_std_main_id;}
		}
        /// <summary>
        /// 取样名称信息表外键
        /// </summary>
        public string C_SAMPLING_ID
        {
			set{ _c_sampling_id = value;}
			get{return _c_sampling_id; }
		}
		/// <summary>
		/// 序号
		/// </summary>
		public string C_NUMBER
		{
			set{ _c_number=value;}
			get{return _c_number;}
		}
		/// <summary>
		/// 取样规格 直接/宽*厚
		/// </summary>
		public string C_SAM_SPE
		{
			set{ _c_sam_spe=value;}
			get{return _c_sam_spe;}
		}
		/// <summary>
		/// 取样长度
		/// </summary>
		public string C_SAM_LEN
		{
			set{ _c_sam_len=value;}
			get{return _c_sam_len;}
		}
		/// <summary>
		/// 取样方法
		/// </summary>
		public string C_SAM_METHOD
		{
			set{ _c_sam_method=value;}
			get{return _c_sam_method;}
		}
		/// <summary>
		/// 取样数量
		/// </summary>
		public string C_SAM_NUM
		{
			set{ _c_sam_num=value;}
			get{return _c_sam_num;}
		}
		/// <summary>
		/// 复检样数量
		/// </summary>
		public string C_RECHECK_NUM
		{
			set{ _c_recheck_num=value;}
			get{return _c_recheck_num;}
		}
		/// <summary>
		/// 数量单位
		/// </summary>
		public string C_NUM_UNIT
		{
			set{ _c_num_unit=value;}
			get{return _c_num_unit;}
		}
		/// <summary>
		/// 取样部门
		/// </summary>
		public string C_SAM_SECTION
		{
			set{ _c_sam_section=value;}
			get{return _c_sam_section;}
		}
		/// <summary>
		/// 实验方法
		/// </summary>
		public string C_TEST_UNIT
		{
			set{ _c_test_unit=value;}
			get{return _c_test_unit;}
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

