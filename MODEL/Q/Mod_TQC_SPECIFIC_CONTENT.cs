using System;
namespace MODEL
{
    /// <summary>
    /// 特殊信息
    /// </summary>
    [Serializable]
	public partial class Mod_TQC_SPECIFIC_CONTENT
	{
		public Mod_TQC_SPECIFIC_CONTENT()
		{}
		#region Model
		private string _c_id ;
		private string _c_lr_bm;
		private string _c_content;
		private string _c_qx_bm;
		private decimal _n_status=1 ;
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
		/// 录入部门
		/// </summary>
		public string C_LR_BM
		{
			set{ _c_lr_bm=value;}
			get{return _c_lr_bm;}
		}
		/// <summary>
		/// 内容
		/// </summary>
		public string C_CONTENT
		{
			set{ _c_content=value;}
			get{return _c_content;}
		}
		/// <summary>
		/// 取消部门
		/// </summary>
		public string C_QX_BM
		{
			set{ _c_qx_bm=value;}
			get{return _c_qx_bm;}
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
		/// 维护人员
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

