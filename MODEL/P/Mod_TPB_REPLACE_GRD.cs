using System;
namespace MODEL
{
	/// <summary>
	/// 可代轧钢种
	/// </summary>
	[Serializable]
	public partial class Mod_TPB_REPLACE_GRD
	{
		public Mod_TPB_REPLACE_GRD()
		{}
        #region Model
        private string _c_id = "sys_guid";
        private string _c_stl_grd;
        private string _c_replace_grd;
        private decimal? _n_level;
        private string _c_remark;
        private decimal? _n_status = 1;
        private string _c_emp_id;
        private DateTime? _d_mod_dt = Convert.ToDateTime(DateTime.Now);
        private DateTime? _d_start_date = Convert.ToDateTime(DateTime.Now);
        private DateTime? _d_end_date;
        private string _c_std_code;
        private string _c_replace_std_code;
        private decimal? _n_sfxm;

        private string _c_sfxm;
        private string _c_slab_type;
        private string _c_swl;
        private string _c_std_main_id;
        private string _c_std_main_kdz_id;
        private string _c_sl;

        /// <summary>
        /// 
        /// </summary>
        public string C_ID
        {
            set { _c_id = value; }
            get { return _c_id; }
        }
        /// <summary>
        /// 钢种
        /// </summary>
        public string C_STL_GRD
        {
            set { _c_stl_grd = value; }
            get { return _c_stl_grd; }
        }
        /// <summary>
        /// 可代轧钢种
        /// </summary>
        public string C_REPLACE_GRD
        {
            set { _c_replace_grd = value; }
            get { return _c_replace_grd; }
        }
        /// <summary>
        /// 优先级
        /// </summary>
        public decimal? N_LEVEL
        {
            set { _n_level = value; }
            get { return _n_level; }
        }
        /// <summary>
        /// 备注
        /// </summary>
        public string C_REMARK
        {
            set { _c_remark = value; }
            get { return _c_remark; }
        }
        /// <summary>
        /// 状态0停用1启用
        /// </summary>
        public decimal? N_STATUS
        {
            set { _n_status = value; }
            get { return _n_status; }
        }
        /// <summary>
        /// 操作人
        /// </summary>
        public string C_EMP_ID
        {
            set { _c_emp_id = value; }
            get { return _c_emp_id; }
        }
        /// <summary>
        /// 操作时间
        /// </summary>
        public DateTime? D_MOD_DT
        {
            set { _d_mod_dt = value; }
            get { return _d_mod_dt; }
        }
        /// <summary>
        /// 启用时间
        /// </summary>
        public DateTime? D_START_DATE
        {
            set { _d_start_date = value; }
            get { return _d_start_date; }
        }
        /// <summary>
        /// 停用时间
        /// </summary>
        public DateTime? D_END_DATE
        {
            set { _d_end_date = value; }
            get { return _d_end_date; }
        }
        /// <summary>
        /// 钢种执行标准
        /// </summary>
        public string C_STD_CODE
        {
            set { _c_std_code = value; }
            get { return _c_std_code; }
        }
        /// <summary>
        /// 可代轧钢种执行标准
        /// </summary>
        public string C_REPLACE_STD_CODE
        {
            set { _c_replace_std_code = value; }
            get { return _c_replace_std_code; }
        }
        /// <summary>
        /// 是否修磨
        /// </summary>
        public decimal? N_SFXM
        {
            set { _n_sfxm = value; }
            get { return _n_sfxm; }
        }
        /// <summary>
		/// 是否修磨
		/// </summary>
		public string C_SFXM
        {
            set { _c_sfxm = value; }
            get { return _c_sfxm; }
        }
        /// <summary>
        /// 钢坯类型
        /// </summary>
        public string C_SLAB_TYPE
        {
            set { _c_slab_type = value; }
            get { return _c_slab_type; }
        }
        /// <summary>
        /// 首位炉要求
        /// </summary>
        public string C_SWL
        {
            set { _c_swl = value; }
            get { return _c_swl; }
        }
        /// <summary>
        /// 标准表外键
        /// </summary>
        public string C_STD_MAIN_ID
        {
            set { _c_std_main_id = value; }
            get { return _c_std_main_id; }
        }
        /// <summary>
        /// 标准表外键
        /// </summary>
        public string C_STD_MAIN_KDZ_ID
        {
            set { _c_std_main_kdz_id = value; }
            get { return _c_std_main_kdz_id; }
        }
        /// <summary>
        /// 首炉要求
        /// </summary>
        public string C_SL
        {
            set { _c_sl = value; }
            get { return _c_sl; }
        }
        #endregion Model
    }
}

