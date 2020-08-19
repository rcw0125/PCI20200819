using System;
namespace MODEL
{
	/// <summary>
	/// 钢坯定尺维护
	/// </summary>
	[Serializable]
	public partial class Mod_TQB_SLAB_LEN
	{
		public Mod_TQB_SLAB_LEN()
		{}
		#region Model
		private string _c_id;
		private string _c_slab_size;
		private string _c_type;
		private string _c_hot_len;
		private string _c_cold_len;
		private string _c_the_weight;
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
		/// 断面
		/// </summary>
		public string C_SLAB_SIZE
		{
			set{ _c_slab_size=value;}
			get{return _c_slab_size;}
		}
		/// <summary>
		/// 类型
		/// </summary>
		public string C_TYPE
		{
			set{ _c_type=value;}
			get{return _c_type;}
		}
		/// <summary>
		/// 热坯长度
		/// </summary>
		public string C_HOT_LEN
		{
			set{ _c_hot_len=value;}
			get{return _c_hot_len;}
		}
		/// <summary>
		/// 冷坯参考长度
		/// </summary>
		public string C_COLD_LEN
		{
			set{ _c_cold_len=value;}
			get{return _c_cold_len;}
		}
		/// <summary>
		/// 理论重量顿/支
		/// </summary>
		public string C_THE_WEIGHT
		{
			set{ _c_the_weight=value;}
			get{return _c_the_weight;}
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

