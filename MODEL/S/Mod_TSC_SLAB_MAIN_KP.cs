using System;
namespace MODEL
{
    /// <summary>
    /// 开坯表
    /// </summary>
    [Serializable]
    public partial class Mod_TSC_SLAB_MAIN_KP
    {
        public Mod_TSC_SLAB_MAIN_KP()
        { }
        #region Model
        private string _c_id = "sys_guid";
        private string _c_slan_plan_kp_id;
        private string _c_sta_id;
        private string _c_spec;
        private decimal _n_len;
        private decimal _n_qua = 2 ;
		private decimal _n_wgt;
        private DateTime? _d_act_start_time;
        private DateTime? _d_act_end_time;
        private decimal? _n_status = 1;
		private decimal? _n_bfzs;
        private decimal? _n_kpsj;
        private string _c_bc;
        private string _c_bz;
        private string _c_emp_id;
        private DateTime _d_mod_dt = Convert.ToDateTime(DateTime.Now);
        private string _c_remark;
        /// <summary>
        /// 主键
        /// </summary>
        public string C_ID
        {
            set { _c_id = value; }
            get { return _c_id; }
        }
        /// <summary>
        /// 钢坯计划表主键
        /// </summary>
        public string C_SLAN_PLAN_KP_ID
        {
            set { _c_slan_plan_kp_id = value; }
            get { return _c_slan_plan_kp_id; }
        }
        /// <summary>
        /// 工位(开坯线)
        /// </summary>
        public string C_STA_ID
        {
            set { _c_sta_id = value; }
            get { return _c_sta_id; }
        }
        /// <summary>
        /// 1规格 
        /// </summary>
        public string C_SPEC
        {
            set { _c_spec = value; }
            get { return _c_spec; }
        }
        /// <summary>
        /// 1长度
        /// </summary>
        public decimal N_LEN
        {
            set { _n_len = value; }
            get { return _n_len; }
        }
        /// <summary>
        /// 1支数
        /// </summary>
        public decimal N_QUA
        {
            set { _n_qua = value; }
            get { return _n_qua; }
        }
        /// <summary>
        /// 1单重
        /// </summary>
        public decimal N_WGT
        {
            set { _n_wgt = value; }
            get { return _n_wgt; }
        }
        /// <summary>
        /// 实际开始时间
        /// </summary>
        public DateTime? D_ACT_START_TIME
        {
            set { _d_act_start_time = value; }
            get { return _d_act_start_time; }
        }
        /// <summary>
        /// 实际结束时间
        /// </summary>
        public DateTime? D_ACT_END_TIME
        {
            set { _d_act_end_time = value; }
            get { return _d_act_end_time; }
        }
        /// <summary>
        /// 状态0正常1撤回
        /// </summary>
        public decimal? N_STATUS
        {
            set { _n_status = value; }
            get { return _n_status; }
        }
        /// <summary>
        /// 报废支数
        /// </summary>
        public decimal? N_BFZS
        {
            set { _n_bfzs = value; }
            get { return _n_bfzs; }
        }
        /// <summary>
        /// 开坯时间
        /// </summary>
        public decimal? N_KPSJ
        {
            set { _n_kpsj = value; }
            get { return _n_kpsj; }
        }
        /// <summary>
        /// 班次
        /// </summary>
        public string C_BC
        {
            set { _c_bc = value; }
            get { return _c_bc; }
        }
        /// <summary>
        /// 班组
        /// </summary>
        public string C_BZ
        {
            set { _c_bz = value; }
            get { return _c_bz; }
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
        /// 备注
        /// </summary>
        public string C_REMARK
        {
            set { _c_remark = value; }
            get { return _c_remark; }
        }
        #endregion Model

    }
}
