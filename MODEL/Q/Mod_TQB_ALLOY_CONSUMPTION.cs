using System;
namespace MODEL
{
    /// <summary>
    /// 钢种合金消耗量
    /// </summary>
    [Serializable]
	public partial class Mod_TQB_ALLOY_CONSUMPTION
    {
		public Mod_TQB_ALLOY_CONSUMPTION()
		{}
		#region Model
		private string _c_id=System.Guid.NewGuid().ToString();
		private string _c_stl_grd;
		private string _c_std_code;
		private string _c_alloyn__name;
        private string _calloyn__code;
		private decimal? _n_alloy_wgt;
		private decimal _n_status=1;
		private string _c_emp_id;
		private DateTime _d_mod_dt= System.DateTime.Now;
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
		/// 钢种
		/// </summary>
		public string C_STL_GRD
		{
			set{ _c_stl_grd=value;}
			get{return _c_stl_grd;}
		}
		/// <summary>
		/// 标准
		/// </summary>
		public string C_STD_CODE
		{
			set{ _c_std_code=value;}
			get{return _c_std_code;}
		}
        /// <summary>
		/// 合金代码
		/// </summary>
		public string C_ALLOYN__CODE
        {
            set { _calloyn__code = value; }
            get { return _calloyn__code; }
        }
        /// <summary>
        /// 合金名称
        /// </summary>
        public string C_ALLOYN__NAME
		{
			set{ _c_alloyn__name=value;}
			get{return _c_alloyn__name;}
		}
		/// <summary>
		/// 吨消耗量（kg）
		/// </summary>
		public decimal? N_ALLOY_WGT
		{
			set{ _n_alloy_wgt=value;}
			get{return _n_alloy_wgt;}
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
		#endregion Model

	}
}

