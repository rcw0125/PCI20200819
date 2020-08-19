using System;
namespace MODEL
{
	/// <summary>
	/// 送样信息(技术中心)
	/// </summary>
	[Serializable]
	public partial class Mod_TQC_PRESENT_SAMPLES_JSZX
	{
		public Mod_TQC_PRESENT_SAMPLES_JSZX()
		{}
		#region Model
		private string _c_id= "sys_guid";
		private string _c_batch_no;
		private string _c_tick_no;
		private string _c_stl_grd;
		private string _c_spec;
		private decimal? _n_entrust_type;
		private decimal _n_status=1;
		private string _c_remark;
		private string _c_emp_id_sy;
		private DateTime _d_mod_dt_sy= Convert.ToDateTime(DateTime.Now);
		private string _c_emp_id_js;
		private DateTime? _d_mod_dt_js;
		private string _c_emp_id_zy;
		private DateTime? _d_mod_dt_zy;
		private string _c_eq_name;
		private string _c_eq_number;
		private string _c_eq_code;
		private decimal? _n_samples_num;
		private DateTime? _d_mod_dt;
		/// <summary>
		/// 主键
		/// </summary>
		public string C_ID
		{
			set{ _c_id=value;}
			get{return _c_id;}
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
		/// 规格
		/// </summary>
		public string C_SPEC
		{
			set{ _c_spec=value;}
			get{return _c_spec;}
		}
		/// <summary>
		/// 送样状态   0-未送样；1-已送样；2-接收送样；3-制样
		/// </summary>
		public decimal? N_ENTRUST_TYPE
		{
			set{ _n_entrust_type=value;}
			get{return _n_entrust_type;}
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
		/// 委托人员
		/// </summary>
		public string C_EMP_ID_SY
		{
			set{ _c_emp_id_sy=value;}
			get{return _c_emp_id_sy;}
		}
		/// <summary>
		/// 委托时间
		/// </summary>
		public DateTime D_MOD_DT_SY
		{
			set{ _d_mod_dt_sy=value;}
			get{return _d_mod_dt_sy;}
		}
		/// <summary>
		/// 样品接收人
		/// </summary>
		public string C_EMP_ID_JS
		{
			set{ _c_emp_id_js=value;}
			get{return _c_emp_id_js;}
		}
		/// <summary>
		/// 样品接收时间
		/// </summary>
		public DateTime? D_MOD_DT_JS
		{
			set{ _d_mod_dt_js=value;}
			get{return _d_mod_dt_js;}
		}
		/// <summary>
		/// 制样人
		/// </summary>
		public string C_EMP_ID_ZY
		{
			set{ _c_emp_id_zy=value;}
			get{return _c_emp_id_zy;}
		}
		/// <summary>
		/// 制样时间
		/// </summary>
		public DateTime? D_MOD_DT_ZY
		{
			set{ _d_mod_dt_zy=value;}
			get{return _d_mod_dt_zy;}
		}
		/// <summary>
		/// 设备名称
		/// </summary>
		public string C_EQ_NAME
		{
			set{ _c_eq_name=value;}
			get{return _c_eq_name;}
		}
		/// <summary>
		/// 设备型号
		/// </summary>
		public string C_EQ_NUMBER
		{
			set{ _c_eq_number=value;}
			get{return _c_eq_number;}
		}
		/// <summary>
		/// 设备编号
		/// </summary>
		public string C_EQ_CODE
		{
			set{ _c_eq_code=value;}
			get{return _c_eq_code;}
		}
		/// <summary>
		/// 取样数量
		/// </summary>
		public decimal? N_SAMPLES_NUM
		{
			set{ _n_samples_num=value;}
			get{return _n_samples_num;}
		}
		/// <summary>
		/// 质控部接样时间
		/// </summary>
		public DateTime? D_MOD_DT
		{
			set{ _d_mod_dt=value;}
			get{return _d_mod_dt;}
		}
		#endregion Model

	}
}

