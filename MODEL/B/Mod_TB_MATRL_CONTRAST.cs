using System;
namespace MODEL
{
    /// <summary>
    /// 物料分类表
    /// </summary>
    [Serializable]
	public partial class Mod_TB_MATRL_CONTRAST
	{
		public Mod_TB_MATRL_CONTRAST()
		{}
		#region Model
		private string _c_id;
		private string _c_slab_size;
		private decimal? _n_slab_lenth;
		private string _c_kp_size;
		private decimal? _n_kp_lenth;
		private string _c_emp_id;
		private DateTime _d_mod_dt= Convert.ToDateTime(DateTime.Now);
		private string _c_remark1;
		private string _c_remark2;
		private string _c_remark3;
		/// <summary>
		/// 主键
		/// </summary>
		public string C_ID
		{
			set{ _c_id=value;}
			get{return _c_id;}
		}
		/// <summary>
		/// 连铸坯断面
		/// </summary>
		public string C_SLAB_SIZE
		{
			set{ _c_slab_size=value;}
			get{return _c_slab_size;}
		}
		/// <summary>
		/// 连铸坯定尺
		/// </summary>
		public decimal? N_SLAB_LENTH
		{
			set{ _n_slab_lenth=value;}
			get{return _n_slab_lenth;}
		}
		/// <summary>
		/// 热轧坯断面
		/// </summary>
		public string C_KP_SIZE
		{
			set{ _c_kp_size=value;}
			get{return _c_kp_size;}
		}
		/// <summary>
		/// 热轧坯定尺
		/// </summary>
		public decimal? N_KP_LENTH
		{
			set{ _n_kp_lenth=value;}
			get{return _n_kp_lenth;}
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
		/// 备注1
		/// </summary>
		public string C_REMARK1
		{
			set{ _c_remark1=value;}
			get{return _c_remark1;}
		}
		/// <summary>
		/// 备注2
		/// </summary>
		public string C_REMARK2
		{
			set{ _c_remark2=value;}
			get{return _c_remark2;}
		}
		/// <summary>
		/// 备注3
		/// </summary>
		public string C_REMARK3
		{
			set{ _c_remark3=value;}
			get{return _c_remark3;}
		}
		#endregion Model

	}
}

