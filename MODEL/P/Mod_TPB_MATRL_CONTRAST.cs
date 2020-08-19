using System;
namespace MODEL
{
	/// <summary>
	/// 材坯物料对照
	/// </summary>
	[Serializable]
	public partial class Mod_TPB_MATRL_CONTRAST
	{
		public Mod_TPB_MATRL_CONTRAST()
		{}
		#region Model
		private string _c_id;
		private string _c_mat_line_code;
		private string _c_mat_line_name;
		private string _c_spec_line;
		private string _c_mat_slab_code;
		private string _c_mat_slab_name;
		private string _c_spec_slab;
		private string _c_tran;
		private decimal? _n_level;
		private string _c_length_slab;
		private string _c_remark;
		private decimal _n_status=1;
		private string _c_emp_id;
		private DateTime _d_mod_dt= Convert.ToDateTime(DateTime.Now);
		private DateTime? _d_start_date= Convert.ToDateTime(DateTime.Now);
		private DateTime? _d_end_date;
		/// <summary>
		/// 主键
		/// </summary>
		public string C_ID
		{
			set{ _c_id=value;}
			get{return _c_id;}
		}
		/// <summary>
		/// 线材物料编码
		/// </summary>
		public string C_MAT_LINE_CODE
		{
			set{ _c_mat_line_code=value;}
			get{return _c_mat_line_code;}
		}
		/// <summary>
		/// 线材物料描述
		/// </summary>
		public string C_MAT_LINE_NAME
		{
			set{ _c_mat_line_name=value;}
			get{return _c_mat_line_name;}
		}
		/// <summary>
		/// 线材规格
		/// </summary>
		public string C_SPEC_LINE
		{
			set{ _c_spec_line=value;}
			get{return _c_spec_line;}
		}
		/// <summary>
		/// 钢坯物料编码
		/// </summary>
		public string C_MAT_SLAB_CODE
		{
			set{ _c_mat_slab_code=value;}
			get{return _c_mat_slab_code;}
		}
		/// <summary>
		/// 钢坯物料描述
		/// </summary>
		public string C_MAT_SLAB_NAME
		{
			set{ _c_mat_slab_name=value;}
			get{return _c_mat_slab_name;}
		}
		/// <summary>
		/// 钢坯定尺
		/// </summary>
		public string C_SPEC_SLAB
		{
			set{ _c_spec_slab=value;}
			get{return _c_spec_slab;}
		}
		/// <summary>
		/// 运输方式
		/// </summary>
		public string C_TRAN
		{
			set{ _c_tran=value;}
			get{return _c_tran;}
		}
		/// <summary>
		/// 优先级
		/// </summary>
		public decimal? N_LEVEL
		{
			set{ _n_level=value;}
			get{return _n_level;}
		}
		/// <summary>
		/// 钢坯长度
		/// </summary>
		public string C_LENGTH_SLAB
		{
			set{ _c_length_slab=value;}
			get{return _c_length_slab;}
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
		#endregion Model

	}
}

