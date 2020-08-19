using System;
namespace MODEL
{
    /// <summary>
    /// 连铸换槽时间
    /// </summary>
    [Serializable]
    public partial class Mod_TPB_CC_CHANGE_TIME
    {
        public Mod_TPB_CC_CHANGE_TIME()
        { }
        #region Model
        private string _c_id = "sys_guid";
        private string _c_sta_id;
        private decimal? _n_time;
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
        /// 工位
        /// </summary>
        public string C_STA_ID
        {
            set { _c_sta_id = value; }
            get { return _c_sta_id; }
        }
        /// <summary>
        /// 换槽时间
        /// </summary>
        public decimal? N_TIME
        {
            set { _n_time = value; }
            get { return _n_time; }
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
