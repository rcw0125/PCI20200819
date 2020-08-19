using System;
namespace MODEL
{
	/// <summary>
	/// 线材表面判定信息表
	/// </summary>
	[Serializable]
	public partial class Mod_TQC_FACE_ROLL_LOG
    {
		public Mod_TQC_FACE_ROLL_LOG()
		{}
		#region Model
		private string _c_id;
		private string _c_roll_id;
		private string _c_stove;
		private string _c_batch_no;
		private string _c_tick_no;
		private string _c_stl_grd;
		private decimal _n_wgt=0;
		private string _c_std_code;
		private string _c_spec;
		private string _c_mat_code;
		private string _c_mat_name;
		private string _c_shift;
		private string _c_group;
		private string _c_judge_lev;
		private string _c_reason_name;
		private string _c_reason_code;
		private string _c_reason_depmt_id;
		private string _c_reason_depmt_desc;
		private string _c_suggestion;
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
		/// 线材实绩表主键
		/// </summary>
		public string C_ROLL_ID
		{
			set{ _c_roll_id=value;}
			get{return _c_roll_id;}
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
		/// 钢种
		/// </summary>
		public string C_STL_GRD
		{
			set{ _c_stl_grd=value;}
			get{return _c_stl_grd;}
		}
		/// <summary>
		/// 重量
		/// </summary>
		public decimal N_WGT
		{
			set{ _n_wgt=value;}
			get{return _n_wgt;}
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
		/// 规格
		/// </summary>
		public string C_SPEC
		{
			set{ _c_spec=value;}
			get{return _c_spec;}
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
		/// 物料描述
		/// </summary>
		public string C_MAT_NAME
		{
			set{ _c_mat_name=value;}
			get{return _c_mat_name;}
		}
		/// <summary>
		/// 班次
		/// </summary>
		public string C_SHIFT
		{
			set{ _c_shift=value;}
			get{return _c_shift;}
		}
		/// <summary>
		/// 班组
		/// </summary>
		public string C_GROUP
		{
			set{ _c_group=value;}
			get{return _c_group;}
		}
		/// <summary>
		/// 表面判定等级
		/// </summary>
		public string C_JUDGE_LEV
		{
			set{ _c_judge_lev=value;}
			get{return _c_judge_lev;}
		}
		/// <summary>
		/// 不合格原因名称
		/// </summary>
		public string C_REASON_NAME
		{
			set{ _c_reason_name=value;}
			get{return _c_reason_name;}
		}
		/// <summary>
		/// 不合格原因代码
		/// </summary>
		public string C_REASON_CODE
		{
			set{ _c_reason_code=value;}
			get{return _c_reason_code;}
		}
		/// <summary>
		/// 责任单位代码
		/// </summary>
		public string C_REASON_DEPMT_ID
		{
			set{ _c_reason_depmt_id=value;}
			get{return _c_reason_depmt_id;}
		}
		/// <summary>
		/// 责任单位描述
		/// </summary>
		public string C_REASON_DEPMT_DESC
		{
			set{ _c_reason_depmt_desc=value;}
			get{return _c_reason_depmt_desc;}
		}
		/// <summary>
		/// 处置意见
		/// </summary>
		public string C_SUGGESTION
		{
			set{ _c_suggestion=value;}
			get{return _c_suggestion;}
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
		/// 判定人
		/// </summary>
		public string C_EMP_ID
		{
			set{ _c_emp_id=value;}
			get{return _c_emp_id;}
		}
		/// <summary>
		/// 判定时间
		/// </summary>
		public DateTime D_MOD_DT
		{
			set{ _d_mod_dt=value;}
			get{return _d_mod_dt;}
		}
		#endregion Model

	}
}

