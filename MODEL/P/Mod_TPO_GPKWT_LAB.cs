using System;
namespace MODEL
{
    /// <summary>
    /// 钢坯库位图
    /// </summary>
    [Serializable]
	public partial class Mod_TPO_GPKWT_LAB
    {
		public Mod_TPO_GPKWT_LAB()
		{}
		#region Model
		private string _c_id= "sys_guid";
		private string _c_code;
		private string _c_area_code;
		private string _c_loc_code;
		private string _c_tier_code;
		private string _c_x_wire;
		private string _c_y_wire;
		private string _c_lab_height;
		private string _c_lab_width;
		private string _c_count;
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
		/// 仓库编码
		/// </summary>
		public string C_CODE
		{
			set{ _c_code=value;}
			get{return _c_code;}
		}
		/// <summary>
		/// 钢坯库区域编码
		/// </summary>
		public string C_AREA_CODE
		{
			set{ _c_area_code=value;}
			get{return _c_area_code;}
		}
        /// <summary>
        /// 钢坯库位编号
        /// </summary>
        public string C_LOC_CODE
		{
			set{ _c_loc_code=value;}
			get{return _c_loc_code;}
		}
		/// <summary>
		/// 层编码
		/// </summary>
		public string C_TIER_CODE
		{
			set{ _c_tier_code=value;}
			get{return _c_tier_code;}
		}
		/// <summary>
		/// X轴
		/// </summary>
		public string C_X_WIRE
		{
			set{ _c_x_wire=value;}
			get{return _c_x_wire;}
		}
		/// <summary>
		/// Y轴
		/// </summary>
		public string C_Y_WIRE
		{
			set{ _c_y_wire=value;}
			get{return _c_y_wire;}
		}
		/// <summary>
		/// lab高
		/// </summary>
		public string C_LAB_HEIGHT
		{
			set{ _c_lab_height=value;}
			get{return _c_lab_height;}
		}
		/// <summary>
		/// lab宽
		/// </summary>
		public string C_LAB_WIDTH
		{
			set{ _c_lab_width=value;}
			get{return _c_lab_width;}
		}
		/// <summary>
		/// 库存容量
		/// </summary>
		public string C_COUNT
		{
			set{ _c_count=value;}
			get{return _c_count;}
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

