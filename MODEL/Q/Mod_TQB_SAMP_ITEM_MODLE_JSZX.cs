using System;
namespace MODEL
{
	/// <summary>
	/// 取样明细模板
	/// </summary>
	[Serializable]
	public partial class Mod_TQB_SAMP_ITEM_MODLE_JSZX
	{
		public Mod_TQB_SAMP_ITEM_MODLE_JSZX()
		{}
		#region Model
		private string _c_id;
		private string _c_samp_modle_id;
		private string _c_samples_id;
		private string _c_sam_num;
		private decimal _n_status=1;
		private string _c_emp_id;
        private DateTime _d_mod_dt = DateTime.Now;
		private string _c_samples_name;
		/// <summary>
		/// 主键
		/// </summary>
		public string C_ID
		{
			set{ _c_id=value;}
			get{return _c_id;}
		}
		/// <summary>
		/// 取样模板主键
		/// </summary>
		public string C_SAMP_MODLE_ID
		{
			set{ _c_samp_modle_id=value;}
			get{return _c_samp_modle_id;}
		}
		/// <summary>
		/// 取样表主键
		/// </summary>
		public string C_SAMPLES_ID
		{
			set{ _c_samples_id=value;}
			get{return _c_samples_id;}
		}
		/// <summary>
		/// 取样数量
		/// </summary>
		public string C_SAM_NUM
		{
			set{ _c_sam_num=value;}
			get{return _c_sam_num;}
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
		/// <summary>
		/// 取样名称
		/// </summary>
		public string C_SAMPLES_NAME
		{
			set{ _c_samples_name=value;}
			get{return _c_samples_name;}
		}
		#endregion Model

	}
}

