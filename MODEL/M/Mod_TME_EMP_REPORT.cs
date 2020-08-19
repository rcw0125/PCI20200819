using System;
namespace MODEL
{
	/// <summary>
	/// 用户使用报告
	/// </summary>
	[Serializable]
	public partial class Mod_TME_EMP_REPORT
	{
		public Mod_TME_EMP_REPORT()
		{}
		#region Model
		private string _c_id;
		private string _c_company;
		private string _c_stl_grd;
		private string _c_spec;
		private string _c_use;
		private string _c_content;
		private string _c_remark;
		private DateTime? _d_crt_date= Convert.ToDateTime(DateTime.Now);
		private string _c_crt_emp;
		/// <summary>
		/// 主键
		/// </summary>
		public string C_ID
		{
			set{ _c_id=value;}
			get{return _c_id;}
		}
		/// <summary>
		/// 公司名称
		/// </summary>
		public string C_COMPANY
		{
			set{ _c_company=value;}
			get{return _c_company;}
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
		///  产品用途
		/// </summary>
		public string C_USE
		{
			set{ _c_use=value;}
			get{return _c_use;}
		}
		/// <summary>
		/// 产品使用情况
		/// </summary>
		public string C_CONTENT
		{
			set{ _c_content=value;}
			get{return _c_content;}
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
		/// 提交时间
		/// </summary>
		public DateTime? D_CRT_DATE
		{
			set{ _d_crt_date=value;}
			get{return _d_crt_date;}
		}
		/// <summary>
		/// 提交人
		/// </summary>
		public string C_CRT_EMP
		{
			set{ _c_crt_emp=value;}
			get{return _c_crt_emp;}
		}
		#endregion Model

	}
}

