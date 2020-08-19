using System;
namespace MODEL
{
	/// <summary>
	/// 加热炉维护
	/// </summary>
	[Serializable]
	public partial class Mod_TB_REHEATING_FURNACE
    {
		public Mod_TB_REHEATING_FURNACE()
		{}
		#region Model
		private string _c_id = System.Guid.NewGuid().ToString();
		private string _c_type;
		private decimal? _n_hour;
		private string _c_stl_grd;
		private string _c_std_code;
		private string _c_zl_type;
        private DateTime _d_mod_dt = System.DateTime.Now;
		private string _c_emp_id;
		private string _c_by1;
		private string _c_by2;
		private string _c_by3;
		private string _c_by4;
		private string _c_by5;
		private string _c_by6;
		/// <summary>
		/// 主键
		/// </summary>
		public string C_ID
		{
			set{ _c_id=value;}
			get{return _c_id;}
		}
		/// <summary>
		/// 类型（开坯/轧线）
		/// </summary>
		public string C_TYPE
		{
			set{ _c_type=value;}
			get{return _c_type;}
		}
		/// <summary>
		/// 加热时间
		/// </summary>
		public decimal? N_HOUR
		{
			set{ _n_hour=value;}
			get{return _n_hour;}
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
		/// 装炉方式（热装/冷装）
		/// </summary>
		public string C_ZL_TYPE
		{
			set{ _c_zl_type=value;}
			get{return _c_zl_type;}
		}
		/// <summary>
		/// 系统时间
		/// </summary>
		public DateTime D_MOD_DT
		{
			set{ _d_mod_dt=value;}
			get{return _d_mod_dt;}
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
		/// 备用字段1
		/// </summary>
		public string C_BY1
		{
			set{ _c_by1=value;}
			get{return _c_by1;}
		}
		/// <summary>
		/// 备用字段2
		/// </summary>
		public string C_BY2
		{
			set{ _c_by2=value;}
			get{return _c_by2;}
		}
		/// <summary>
		/// 备用字段3
		/// </summary>
		public string C_BY3
		{
			set{ _c_by3=value;}
			get{return _c_by3;}
		}
		/// <summary>
		/// 备用字段4
		/// </summary>
		public string C_BY4
		{
			set{ _c_by4=value;}
			get{return _c_by4;}
		}
		/// <summary>
		/// 备用字段5
		/// </summary>
		public string C_BY5
		{
			set{ _c_by5=value;}
			get{return _c_by5;}
		}
		/// <summary>
		/// 备用字段6
		/// </summary>
		public string C_BY6
		{
			set{ _c_by6=value;}
			get{return _c_by6;}
		}
		#endregion Model

	}
}

