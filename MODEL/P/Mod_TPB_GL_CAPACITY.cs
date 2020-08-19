using System;
namespace MODEL
{
	/// <summary>
	/// 生产工位机时产能
	/// </summary>
	[Serializable]
	public partial class Mod_TPB_GL_CAPACITY
	{
		public Mod_TPB_GL_CAPACITY()
		{}
        #region Model
        private string _c_id = System.Guid.NewGuid().ToString();
		private string _c_pro_id;
		private string _c_sta_id;
		private string _c_sta_desc;
		private string _c_sta_code;
		private decimal? _n_capacity;
		private DateTime? _d_start_date= Convert.ToDateTime(System.DateTime.Now);
		private DateTime? _d_end_date;
		private decimal _n_status=1;
		private string _c_emp_id;
		private DateTime _d_mod_dt= Convert.ToDateTime(System.DateTime.Now);
		/// <summary>
		/// 主键
		/// </summary>
		public string C_ID
		{
			set{ _c_id=value;}
			get{return _c_id;}
		}
		/// <summary>
		/// 工序
		/// </summary>
		public string C_PRO_ID
		{
			set{ _c_pro_id=value;}
			get{return _c_pro_id;}
		}
		/// <summary>
		/// 工位表主键（外键）
		/// </summary>
		public string C_STA_ID
		{
			set{ _c_sta_id=value;}
			get{return _c_sta_id;}
		}
		/// <summary>
		/// 工位描述
		/// </summary>
		public string C_STA_DESC
		{
			set{ _c_sta_desc=value;}
			get{return _c_sta_desc;}
		}
		/// <summary>
		/// 工位描述
		/// </summary>
		public string C_STA_CODE
		{
			set{ _c_sta_code=value;}
			get{return _c_sta_code;}
		}
		/// <summary>
		/// 机时产能
		/// </summary>
		public decimal? N_CAPACITY
		{
			set{ _n_capacity=value;}
			get{return _n_capacity;}
		}
		/// <summary>
		/// 启用时间
		/// </summary>
		public DateTime? D_START_DATE
		{
			set{ _d_start_date=value;}
			get{return _d_start_date;}
		}
		/// <summary>
		/// 停用时间
		/// </summary>
		public DateTime? D_END_DATE
		{
			set{ _d_end_date=value;}
			get{return _d_end_date;}
		}
		/// <summary>
		/// 状态0停用1启用
		/// </summary>
		public decimal N_STATUS
		{
			set{ _n_status=value;}
			get{return _n_status;}
		}
		/// <summary>
		/// 操作人
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
		#endregion Model

	}
}

