using System;
namespace MODEL
{
    /// <summary>
    /// 工位转移时间
    /// </summary>
    [Serializable]
    public partial class Mod_TPB_STA_MOVETIME
    {
        public Mod_TPB_STA_MOVETIME()
        { }
        #region Model
        private string _c_id = "sys_guid";
        private string _c_sta_id1;
        private string _c_sta_id2;
        private decimal? _n_time = 0;
		private string _c_emp_id;
        private DateTime _d_mod_dt = Convert.ToDateTime(DateTime.Now);
        private string _c_remark;
        private decimal _n_status = 1;
        /// <summary>
        /// 主键
        /// </summary>
        public string C_ID
        {
            set { _c_id = value; }
            get { return _c_id; }
        }
        /// <summary>
        /// 工位1
        /// </summary>
        public string C_STA_ID1
        {
            set { _c_sta_id1 = value; }
            get { return _c_sta_id1; }
        }
        /// <summary>
        /// 工位2
        /// </summary>
        public string C_STA_ID2
        {
            set { _c_sta_id2 = value; }
            get { return _c_sta_id2; }
        }
        /// <summary>
        /// 时间
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
        /// <summary>
            /// 状态0停用1启用
            /// </summary>
        public decimal N_STATUS
        {
            set { _n_status = value; }
            get { return _n_status; }
        }
        #endregion Model

    }
}
