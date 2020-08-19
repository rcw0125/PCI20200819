using System;
namespace MODEL
{
    /// <summary>
    /// 方案初始化表
    /// </summary>
    [Serializable]
    public partial class Mod_TPP_INITIALIZE_ITEM
    {
        public Mod_TPP_INITIALIZE_ITEM()
        { }
        #region Model
        private string _c_id = "sys_guid";
        private string _c_issue;
        private string _c_item_name;
        private string _c_goal;
        private DateTime? _d_end_time;
        private DateTime? _d_start_time;
        private decimal? _n_status = 0;
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
        /// 期数
        /// </summary>
        public string C_ISSUE
        {
            set { _c_issue = value; }
            get { return _c_issue; }
        }
        /// <summary>
        /// 方案号
        /// </summary>
        public string C_ITEM_NAME
        {
            set { _c_item_name = value; }
            get { return _c_item_name; }
        }
        /// <summary>
        /// 排产目标
        /// </summary>
        public string C_GOAL
        {
            set { _c_goal = value; }
            get { return _c_goal; }
        }
        /// <summary>
        /// 失效时间
        /// </summary>
        public DateTime? D_END_TIME
        {
            set { _d_end_time = value; }
            get { return _d_end_time; }
        }
        /// <summary>
        /// 生效时间
        /// </summary>
        public DateTime? D_START_TIME
        {
            set { _d_start_time = value; }
            get { return _d_start_time; }
        }
        /// <summary>
        /// 状态0待生效1已生效-1已失效
        /// </summary>
        public decimal? N_STATUS
        {
            set { _n_status = value; }
            get { return _n_status; }
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
        /// 维护人
        /// </summary>
        public string C_EMP_ID
        {
            set { _c_emp_id = value; }
            get { return _c_emp_id; }
        }
        /// <summary>
        /// 维护时间
        /// </summary>
        public DateTime D_MOD_DT
        {
            set { _d_mod_dt = value; }
            get { return _d_mod_dt; }
        }
        #endregion Model

    }
}
