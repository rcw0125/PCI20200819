using System;
namespace MODEL
{
	/// <summary>
	/// 检修计划
	/// </summary>
	[Serializable]
	public partial class Mod_TPP_TURNAROUND_PLAN
	{
		public Mod_TPP_TURNAROUND_PLAN()
		{}
        #region Model
        private string _c_id = "sys_guid";
        private string _c_sta_id;
        private DateTime? _d_start_time;
        private DateTime? _d_end_time;
        private string _c_plan_type;
        private string _c_remark;
        private decimal _n_status=1;
        private string _c_emp_id;
        private DateTime _d_mod_dt;
        private string _c_sh_emp_id;
        private DateTime? _d_sh_mod_dt;
        private string _c_type;
        private string _c_sta_code;
        private string _c_pro_code;
        private decimal? _n_tiem;
        /// <summary>
        /// 主键
        /// </summary>
        public string C_ID
        {
            set { _c_id = value; }
            get { return _c_id; }
        }
        /// <summary>
        /// 工位外键
        /// </summary>
        public string C_STA_ID
        {
            set { _c_sta_id = value; }
            get { return _c_sta_id; }
        }
        /// <summary>
        /// 计划开始时间
        /// </summary>
        public DateTime? D_START_TIME
        {
            set { _d_start_time = value; }
            get { return _d_start_time; }
        }
        /// <summary>
        /// 计划结束时间
        /// </summary>
        public DateTime? D_END_TIME
        {
            set { _d_end_time = value; }
            get { return _d_end_time; }
        }
        /// <summary>
        /// 计划类别
        /// </summary>
        public string C_PLAN_TYPE
        {
            set { _c_plan_type = value; }
            get { return _c_plan_type; }
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
        /// 审核人
        /// </summary>
        public string C_SH_EMP_ID
        {
            set { _c_sh_emp_id = value; }
            get { return _c_sh_emp_id; }
        }
        /// <summary>
        /// 审核时间
        /// </summary>
        public DateTime? D_SH_MOD_DT
        {
            set { _d_sh_mod_dt = value; }
            get { return _d_sh_mod_dt; }
        }
        /// <summary>
        /// 分类：轧钢、炼钢
        /// </summary>
        public string C_TYPE
        {
            set { _c_type = value; }
            get { return _c_type; }
        }
        /// <summary>
        /// 工位代码
        /// </summary>
        public string C_STA_CODE
        {
            set { _c_sta_code = value; }
            get { return _c_sta_code; }
        }
        /// <summary>
        /// 工序代码
        /// </summary>
        public string C_PRO_CODE
        {
            set { _c_pro_code = value; }
            get { return _c_pro_code; }
        }
        /// <summary>
        /// 时间
        /// </summary>
        public decimal? N_TIEM
        {
            set { _n_tiem = value; }
            get { return _n_tiem; }
        }
        #endregion Model

    }
}

