using System;
namespace MODEL
{
    /// <summary>
    /// 钢坯缓冷实绩表
    /// </summary>
    [Serializable]
	public partial class Mod_TPA_HL_ACT
    {
		public Mod_TPA_HL_ACT()
		{}
		#region Model
		private string _c_id= "sys_guid";
		private string _c_wh_code;
		private string _c_slab_type;
		private DateTime? _d_start_time;
		private DateTime? _d_end_time;
		private string _c_remark;
		private decimal _n_status=0 ;
		private decimal _n_cap_qua=0 ;
		private decimal _n_qua=0 ;
		private decimal _n_sort=0 ;
		/// <summary>
		/// 主键
		/// </summary>
		public string C_ID
		{
			set{ _c_id=value;}
			get{return _c_id;}
		}
		/// <summary>
		/// 缓冷坑编码
		/// </summary>
		public string C_WH_CODE
		{
			set{ _c_wh_code=value;}
			get{return _c_wh_code;}
		}
		/// <summary>
		/// 缓冷钢坯类型（大方坯/热轧钢坯）
		/// </summary>
		public string C_SLAB_TYPE
		{
			set{ _c_slab_type=value;}
			get{return _c_slab_type;}
		}
		/// <summary>
		/// 最后一炉入坑时间
		/// </summary>
		public DateTime? D_START_TIME
		{
			set{ _d_start_time=value;}
			get{return _d_start_time;}
		}
		/// <summary>
		/// 计划出坑时间
		/// </summary>
		public DateTime? D_END_TIME
		{
			set{ _d_end_time=value;}
			get{return _d_end_time;}
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
		/// 状态0未出坑1已出坑
		/// </summary>
		public decimal N_STATUS
		{
			set{ _n_status=value;}
			get{return _n_status;}
		}
		/// <summary>
		/// 缓冷坑容量
		/// </summary>
		public decimal N_CAP_QUA
		{
			set{ _n_cap_qua=value;}
			get{return _n_cap_qua;}
		}
		/// <summary>
		/// 入坑支数
		/// </summary>
		public decimal N_QUA
		{
			set{ _n_qua=value;}
			get{return _n_qua;}
		}
		/// <summary>
		/// 排序号
		/// </summary>
		public decimal N_SORT
		{
			set{ _n_sort=value;}
			get{return _n_sort;}
		}
		#endregion Model

	}
}

