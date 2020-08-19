using System;
namespace MODEL
{
    /// <summary>
    /// 产线排钩顺序表
    /// </summary>
    [Serializable]
    public partial class Mod_TPB_STA_HOOK_NO
    {
        public Mod_TPB_STA_HOOK_NO()
        { }
        #region Model
        private string _c_id = "sys_guid";
        private string _c_sta_id;
        private decimal? _n_no;
        private string _c_hook_name;
        private string _c_remark;
        private decimal _n_status = 1;
		private string _c_emp_id;
        private DateTime _d_mod_dt = Convert.ToDateTime(DateTime.Now);
        private DateTime? _d_start_date = Convert.ToDateTime(DateTime.Now);
        private DateTime? _d_end_date;
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
        /// 序号
        /// </summary>
        public decimal? N_NO
        {
            set { _n_no = value; }
            get { return _n_no; }
        }
        /// <summary>
        /// 排钩号
        /// </summary>
        public string C_HOOK_NAME
        {
            set { _c_hook_name = value; }
            get { return _c_hook_name; }
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
        #endregion Model

    }
}
