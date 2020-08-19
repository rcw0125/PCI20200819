using System;
namespace MODEL
{
	/// <summary>
	/// 工序表
	/// </summary>
	[Serializable]
	public partial class Mod_TB_PRO
	{
		public Mod_TB_PRO()
		{}
		#region Model
		private string _c_id;
		private string _c_pro_code;
		private string _c_pro_desc;
		private string _c_emp_id;
		private DateTime _d_mod_dt= Convert.ToDateTime(DateTime.Now);
		private string _c_remark;
		private DateTime? _d_start_date= Convert.ToDateTime(DateTime.Now);
		private DateTime? _d_end_date;
		private decimal _n_status=1;
		private string _c_pro_erpcode;
		private string _c_pro_mescode;
        private decimal _n_sort;
        /// <summary>
        /// 主键
        /// </summary>
        public string C_ID
		{
			set{ _c_id=value;}
			get{return _c_id;}
		}
		/// <summary>
		/// 工序代码
		/// </summary>
		public string C_PRO_CODE
		{
			set{ _c_pro_code=value;}
			get{return _c_pro_code;}
		}
		/// <summary>
		/// 工序描述
		/// </summary>
		public string C_PRO_DESC
		{
			set{ _c_pro_desc=value;}
			get{return _c_pro_desc;}
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
		/// <summary>
		/// 备注
		/// </summary>
		public string C_REMARK
		{
			set{ _c_remark=value;}
			get{return _c_remark;}
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
		/// ERP工序代码
		/// </summary>
		public string C_PRO_ERPCODE
		{
			set{ _c_pro_erpcode=value;}
			get{return _c_pro_erpcode;}
		}
		/// <summary>
		/// MES工序代码
		/// </summary>
		public string C_PRO_MESCODE
		{
			set{ _c_pro_mescode=value;}
			get{return _c_pro_mescode;}
		}
        /// <summary>
		/// 排序
		/// </summary>
		public decimal N_SORT
        {
            set { _n_sort = value; }
            get { return _n_sort; }
        }
        #endregion Model

    }
}

