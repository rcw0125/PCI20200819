using System;
namespace MODEL
{
    /// <summary>
    /// 钢坯异常操作日志表
    /// </summary>
    [Serializable]
	public partial class Mod_TQC_SLAB_YC_LOG
	{
		public Mod_TQC_SLAB_YC_LOG()
		{}
		#region Model
		private string _c_id;
		private string _c_stove;
		private string _c_stl_grd;
		private string _c_std_code;
		private string _c_mat_code;
		private string _c_mat_name;
		private string _c_spec;
		private decimal? _n_len;
		private string _c_reason;
		private string _c_type;
		private decimal _n_status=1 ;
		private string _c_emp_id;
		private DateTime _d_mod_dt= Convert.ToDateTime(DateTime.Now);
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
		/// 执行标准
		/// </summary>
		public string C_STD_CODE
		{
			set{ _c_std_code=value;}
			get{return _c_std_code;}
		}
		/// <summary>
		/// 物料编码
		/// </summary>
		public string C_MAT_CODE
		{
			set{ _c_mat_code=value;}
			get{return _c_mat_code;}
		}
		/// <summary>
		/// 物料名称
		/// </summary>
		public string C_MAT_NAME
		{
			set{ _c_mat_name=value;}
			get{return _c_mat_name;}
		}
		/// <summary>
		/// 断面
		/// </summary>
		public string C_SPEC
		{
			set{ _c_spec=value;}
			get{return _c_spec;}
		}
		/// <summary>
		/// 定尺
		/// </summary>
		public decimal? N_LEN
		{
			set{ _n_len=value;}
			get{return _n_len;}
		}
		/// <summary>
		/// 原因
		/// </summary>
		public string C_REASON
		{
			set{ _c_reason=value;}
			get{return _c_reason;}
		}
		/// <summary>
		/// 操作类型（添加/取消）
		/// </summary>
		public string C_TYPE
		{
			set{ _c_type=value;}
			get{return _c_type;}
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

