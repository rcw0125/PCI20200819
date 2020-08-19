using System;
namespace MODEL
{
	/// <summary>
	/// 评级报表
	/// </summary>
	[Serializable]
	public partial class Mod_TQR_GRADE
	{
		public Mod_TQR_GRADE()
		{}
		#region Model
		private string _c_id;
		private DateTime _d_rate_dt= Convert.ToDateTime(DateTime.Now);
		private string _c_batch_no;
		private string _c_batch_no_kp;
		private string _c_stove;
		private string _c_stl_grd;
		private string _c_spec;
		private string _c_qua;
		private decimal? _n_wgt;
		private string _c_lg_gx_grade;
		private string _c_lg_grade_cause;
		private string _c_xc_gx_grade;
		private string _c_xc_grade_cause;
		private string _c_cf_grade;
		private string _c_cf_grade_cause;
		private string _c_xn_grade;
		private string _c_xn_grade_cause;
		private string _c_face_grade;
		private string _c_face_grade_cause;
		private string _c_cp_zh_grade;
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
		/// 日期
		/// </summary>
		public DateTime D_RATE_DT
		{
			set{ _d_rate_dt=value;}
			get{return _d_rate_dt;}
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
		/// 开坯号
		/// </summary>
		public string C_BATCH_NO_KP
		{
			set{ _c_batch_no_kp=value;}
			get{return _c_batch_no_kp;}
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
		/// 件数
		/// </summary>
		public string C_QUA
		{
			set{ _c_qua=value;}
			get{return _c_qua;}
		}
		/// <summary>
		/// 重量
		/// </summary>
		public decimal? N_WGT
		{
			set{ _n_wgt=value;}
			get{return _n_wgt;}
		}
		/// <summary>
		/// 炼钢工序评级
		/// </summary>
		public string C_LG_GX_GRADE
		{
			set{ _c_lg_gx_grade=value;}
			get{return _c_lg_gx_grade;}
		}
		/// <summary>
		/// 炼钢原因
		/// </summary>
		public string C_LG_GRADE_CAUSE
		{
			set{ _c_lg_grade_cause=value;}
			get{return _c_lg_grade_cause;}
		}
		/// <summary>
		/// 线材工序评级
		/// </summary>
		public string C_XC_GX_GRADE
		{
			set{ _c_xc_gx_grade=value;}
			get{return _c_xc_gx_grade;}
		}
		/// <summary>
		/// 线材原因
		/// </summary>
		public string C_XC_GRADE_CAUSE
		{
			set{ _c_xc_grade_cause=value;}
			get{return _c_xc_grade_cause;}
		}
		/// <summary>
		/// 成分评级
		/// </summary>
		public string C_CF_GRADE
		{
			set{ _c_cf_grade=value;}
			get{return _c_cf_grade;}
		}
		/// <summary>
		/// 成分原因
		/// </summary>
		public string C_CF_GRADE_CAUSE
		{
			set{ _c_cf_grade_cause=value;}
			get{return _c_cf_grade_cause;}
		}
		/// <summary>
		/// 性能评级
		/// </summary>
		public string C_XN_GRADE
		{
			set{ _c_xn_grade=value;}
			get{return _c_xn_grade;}
		}
		/// <summary>
		/// 性能原因
		/// </summary>
		public string C_XN_GRADE_CAUSE
		{
			set{ _c_xn_grade_cause=value;}
			get{return _c_xn_grade_cause;}
		}
		/// <summary>
		/// 表面质量评级
		/// </summary>
		public string C_FACE_GRADE
		{
			set{ _c_face_grade=value;}
			get{return _c_face_grade;}
		}
		/// <summary>
		/// 表面质量原因
		/// </summary>
		public string C_FACE_GRADE_CAUSE
		{
			set{ _c_face_grade_cause=value;}
			get{return _c_face_grade_cause;}
		}
		/// <summary>
		/// 产品综合评级
		/// </summary>
		public string C_CP_ZH_GRADE
		{
			set{ _c_cp_zh_grade=value;}
			get{return _c_cp_zh_grade;}
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

