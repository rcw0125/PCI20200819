using System;
namespace MODEL
{
	/// <summary>
	/// 排产初始化主表
	/// </summary>
	[Serializable]
	public partial class Mod_TPP_PROD_INITIALIZE
    {
		public Mod_TPP_PROD_INITIALIZE()
		{}
        #region Model
        private string _c_id = "sys_guid";
        private string _c_issue;
        private DateTime? _d_start_time;
        private DateTime? _d_end_time;
        private string _c_type;
        private string _c_ym;
        private string _c_status = "待生效";
        private string _c_remark;
        private string _c_emp_id;
        private DateTime _d_mod_dt = Convert.ToDateTime(System.DateTime.Now);
        /// <summary>
        /// 主键
        /// </summary>
        public string C_ID
        {
            set { _c_id = value; }
            get { return _c_id; }
        }
        /// <summary>
        /// 期数(唯一)
        /// </summary>
        public string C_ISSUE
        {
            set { _c_issue = value; }
            get { return _c_issue; }
        }
        /// <summary>
        /// 排产周期开始时间
        /// </summary>
        public DateTime? D_START_TIME
        {
            set { _d_start_time = value; }
            get { return _d_start_time; }
        }
        /// <summary>
        /// 排产周期结束时间
        /// </summary>
        public DateTime? D_END_TIME
        {
            set { _d_end_time = value; }
            get { return _d_end_time; }
        }
        /// <summary>
        /// 档期类型（月排产、旬排产、日排产）
        /// </summary>
        public string C_TYPE
        {
            set { _c_type = value; }
            get { return _c_type; }
        }
        /// <summary>
        /// 档期年月
        /// </summary>
        public string C_YM
        {
            set { _c_ym = value; }
            get { return _c_ym; }
        }
        /// <summary>
        /// 状态0未生效1已生效-1已失效
        /// </summary>
        public string C_STATUS
        {
            set { _c_status = value; }
            get { return _c_status; }
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
        #endregion Model

    }
}

