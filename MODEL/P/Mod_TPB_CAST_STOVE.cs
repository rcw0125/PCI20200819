using System;
namespace MODEL
{
	/// <summary>
	/// 钢种整浇次炉数
	/// </summary>
	[Serializable]
	public partial class Mod_TPB_CAST_STOVE
	{
		public Mod_TPB_CAST_STOVE()
		{}
        #region Model
        private string _c_id = "sys_guid";
        private string _c_stl_grd;
        private string _c_std_code;
        private decimal? _n_stove_min_num;
        private decimal? _n_stove_max_num;
        private string _c_remark;
        private decimal _n_status = 1;
		private string _c_emp_id;
        private DateTime _d_mod_dt = Convert.ToDateTime(DateTime.Now);
        private DateTime? _d_start_date = Convert.ToDateTime(DateTime.Now);
        private DateTime? _d_end_date;
        private decimal? _n_target_num;
        private string _c_sta_id;
        /// <summary>
        /// 主键
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
        /// 钢种执行标准
        /// </summary>
        public string C_STD_CODE
        {
            set { _c_std_code = value; }
            get { return _c_std_code; }
        }
        /// <summary>
        /// 钢种整浇次最小炉数
        /// </summary>
        public decimal? N_STOVE_MIN_NUM
        {
            set { _n_stove_min_num = value; }
            get { return _n_stove_min_num; }
        }
        /// <summary>
        /// 钢种整浇次最大炉数
        /// </summary>
        public decimal? N_STOVE_MAX_NUM
        {
            set { _n_stove_max_num = value; }
            get { return _n_stove_max_num; }
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
        public decimal N_STATUS
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
        public DateTime D_MOD_DT
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
        /// 目标炉数
        /// </summary>
        public decimal? N_TARGET_NUM
        {
            set { _n_target_num = value; }
            get { return _n_target_num; }
        }
        /// <summary>
        /// 工位(连铸)
        /// </summary>
        public string C_STA_ID
        {
            set { _c_sta_id = value; }
            get { return _c_sta_id; }
        }
        #endregion Model

    }
}

