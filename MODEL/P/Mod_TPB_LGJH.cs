using System;
namespace MODEL
{
    /// <summary>
    /// 炼钢记号
    /// </summary>
    [Serializable]
	public partial class Mod_TPB_LGJH
	{
		public Mod_TPB_LGJH()
		{}
		#region Model
		private string _c_id= "sys_guid";
        private decimal _n_status = 1;
		private string _c_emp_id;
		private DateTime _d_mod_dt= Convert.ToDateTime(DateTime.Now);
		private string _c_remark;
		private string _c_std_code;
		private string _c_stl_grd;
		private string _c_zyx1;
		private string _c_zyx2;
		private string _c_steel_sign;
		private string _c_grade_group_code;
		private string _c_flrst_flag;
		private string _c_use_flag;
		private string _c_steelgrade_type;
		private string _c_name;
		/// <summary>
		/// 主键
		/// </summary>
		public string C_ID
		{
			set{ _c_id=value;}
			get{return _c_id;}
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
		/// <summary>
		/// 执行标准代码
		/// </summary>
		public string C_STD_CODE
		{
			set{ _c_std_code=value;}
			get{return _c_std_code;}
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
		/// 自由项1
		/// </summary>
		public string C_ZYX1
		{
			set{ _c_zyx1=value;}
			get{return _c_zyx1;}
		}
		/// <summary>
		/// 自由项2
		/// </summary>
		public string C_ZYX2
		{
			set{ _c_zyx2=value;}
			get{return _c_zyx2;}
		}
		/// <summary>
		/// 炼钢记号
		/// </summary>
		public string C_STEEL_SIGN
		{
			set{ _c_steel_sign=value;}
			get{return _c_steel_sign;}
		}
		/// <summary>
		/// 钢类分组
		/// </summary>
		public string C_GRADE_GROUP_CODE
		{
			set{ _c_grade_group_code=value;}
			get{return _c_grade_group_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string C_FLRST_FLAG
		{
			set{ _c_flrst_flag=value;}
			get{return _c_flrst_flag;}
		}
		/// <summary>
		/// 使用标识0在用；1停用
		/// </summary>
		public string C_USE_FLAG
		{
			set{ _c_use_flag=value;}
			get{return _c_use_flag;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string C_STEELGRADE_TYPE
		{
			set{ _c_steelgrade_type=value;}
			get{return _c_steelgrade_type;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string C_NAME
		{
			set{ _c_name=value;}
			get{return _c_name;}
		}
		#endregion Model

	}
}

