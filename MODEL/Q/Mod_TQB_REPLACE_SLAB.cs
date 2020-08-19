using System;
namespace MODEL
{
    /// <summary>
    /// 代轧钢坯匹配
    /// </summary>
    [Serializable]
	public partial class Mod_TQB_REPLACE_SLAB
	{
		public Mod_TQB_REPLACE_SLAB()
		{}
		#region Model
		private string _c_id;
		private string _c_stl_grd;
		private string _c_stl_grd_slab;
		private string _c_std_code;
		private string _c_std_code_slab;
		private decimal _n_status=1;
		private string _c_emp_id;
		private DateTime _d_mod_dt= Convert.ToDateTime(DateTime.Now);
		private string _c_remark;
		private string _c_sf_bxg;
        private string _c_xm;
        private string _c_dfp;

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
		/// 代轧钢坯钢种
		/// </summary>
		public string C_STL_GRD_SLAB
		{
			set{ _c_stl_grd_slab=value;}
			get{return _c_stl_grd_slab;}
		}
		/// <summary>
		/// 钢种执行标准
		/// </summary>
		public string C_STD_CODE
		{
			set{ _c_std_code=value;}
			get{return _c_std_code;}
		}
		/// <summary>
		/// 代轧钢坯标准
		/// </summary>
		public string C_STD_CODE_SLAB
		{
			set{ _c_std_code_slab=value;}
			get{return _c_std_code_slab;}
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
		/// <summary>
		/// 是否不锈钢
		/// </summary>
		public string C_SF_BXG
		{
			set{ _c_sf_bxg=value;}
			get{return _c_sf_bxg;}
		}
        /// <summary>
		/// 是否不锈钢
		/// </summary>
		public string C_XM
        {
            set { _c_xm = value; }
            get { return _c_xm; }
        }
        /// <summary>
		/// 是否不锈钢
		/// </summary>
		public string C_DFP
        {
            set { _c_dfp = value; }
            get { return _c_dfp; }
        }
        #endregion Model

    }
}

