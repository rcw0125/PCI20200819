using System;
namespace MODEL
{
	/// <summary>
	/// 抽查线材实绩信息
	/// </summary>
	[Serializable]
	public partial class Mod_TRC_ROLL_SPOT_CHECK
    {
		public Mod_TRC_ROLL_SPOT_CHECK()
		{}
		#region Model
		private string _c_id= "sys_guid";
		private string _c_stove;
		private string _c_batch_no;
		private string _c_tick_no;
		private string _c_std_code;
		private string _c_stl_grd;
		private string _c_spec;
		private decimal _n_status=1;
		private string _c_remark;
		private string _c_emp_id;
		private DateTime _d_mod_dt= Convert.ToDateTime(DateTime.Now);
		private decimal? _n_entrust_type;
		private string _c_emp_id_zy;
		private DateTime? _d_mod_dt_zy;
        private string _c_emp_id_js;
        private DateTime? _d_mod_dt_js;
        /// <summary>
        /// 主键
        /// </summary>
        public string C_ID
		{
			set{ _c_id=value;}
			get{return _c_id;}
		}
		/// <summary>
		/// 炉号
		/// </summary>
		public string C_STOVE
		{
			set{ _c_stove=value;}
			get{return _c_stove;}
		}
		/// <summary>
		/// 批号
		/// </summary>
		public string C_BATCH_NO
		{
			set{ _c_batch_no=value;}
			get{return _c_batch_no;}
		}
		/// <summary>
		/// 钩号
		/// </summary>
		public string C_TICK_NO
		{
			set{ _c_tick_no=value;}
			get{return _c_tick_no;}
		}
		/// <summary>
		/// 执行标准
		/// </summary>
		public string C_STD_CODE
		{
			set{ _c_std_code=value;}
			get{return _c_std_code;}
		}
		/// <summary>
		/// 钢种
		/// </summary>
		public string C_STL_GRD
		{
			set{ _c_stl_grd=value;}
			get{return _c_stl_grd;}
		}
		/// <summary>
		/// 规格
		/// </summary>
		public string C_SPEC
		{
			set{ _c_spec=value;}
			get{return _c_spec;}
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
		/// 委托人
		/// </summary>
		public string C_EMP_ID
		{
			set{ _c_emp_id=value;}
			get{return _c_emp_id;}
		}
		/// <summary>
		/// 委托时间
		/// </summary>
		public DateTime D_MOD_DT
		{
			set{ _d_mod_dt=value;}
			get{return _d_mod_dt;}
		}
		/// <summary>
		/// 委托状态   1-已委托；0-未委托；2-已制样
		/// </summary>
		public decimal? N_ENTRUST_TYPE
		{
			set{ _n_entrust_type=value;}
			get{return _n_entrust_type;}
		}
		/// <summary>
		/// 制样人
		/// </summary>
		public string C_EMP_ID_ZY
		{
			set{ _c_emp_id_zy=value;}
			get{return _c_emp_id_zy;}
		}
		/// <summary>
		/// 制样时间
		/// </summary>
		public DateTime? D_MOD_DT_ZY
		{
			set{ _d_mod_dt_zy=value;}
			get{return _d_mod_dt_zy;}
		}
        /// <summary>
		/// 样品接收人
		/// </summary>
		public string C_EMP_ID_JS
        {
            set { _c_emp_id_js = value; }
            get { return _c_emp_id_js; }
        }
        /// <summary>
        /// 样品接收时间
        /// </summary>
        public DateTime? D_MOD_DT_JS
        {
            set { _d_mod_dt_js = value; }
            get { return _d_mod_dt_js; }
        }
        #endregion Model

    }
}

