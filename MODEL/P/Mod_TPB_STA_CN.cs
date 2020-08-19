using System;
namespace MODEL
{
    /// <summary>
    /// 工位产能
    /// </summary>
    [Serializable]
    public partial class Mod_TPB_STA_CN
    {
        public Mod_TPB_STA_CN()
        { }
        #region Model
        private string _c_id;
        private string _c_date;
        private string _c_sta;
        private string _c_value;
        private string _c_remark;
        private decimal _n_status = 1;
        private string _c_emp_id;
        private DateTime _d_mod_dt = Convert.ToDateTime(DateTime.Now);
        private string _c_month;
        /// <summary>
        /// 主键
        /// </summary>
        public string C_ID
        {
            set { _c_id = value; }
            get { return _c_id; }
        }
        /// <summary>
        /// 日期
        /// </summary>
        public string C_DATE
        {
            set { _c_date = value; }
            get { return _c_date; }
        }
        /// <summary>
        /// 车间
        /// </summary>
        public string C_STA
        {
            set { _c_sta = value; }
            get { return _c_sta; }
        }
        /// <summary>
        /// 产能
        /// </summary>
        public string C_VALUE
        {
            set { _c_value = value; }
            get { return _c_value; }
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
        /// 使用状态   1-可用；0-停用
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
        /// 操作人
        /// </summary>
        public string C_MONTH
        {
            set { _c_month = value; }
            get { return _c_month; }
        }
        #endregion Model

    }
}

