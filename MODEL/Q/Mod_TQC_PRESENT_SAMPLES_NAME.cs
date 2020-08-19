using System;
namespace MODEL
{
    /// <summary>
    /// 送样信息子表（性能名称）
    /// </summary>
    [Serializable]
    public partial class Mod_TQC_PRESENT_SAMPLES_NAME
    {
        public Mod_TQC_PRESENT_SAMPLES_NAME()
        { }
        #region Model
        private string _c_id;
        private string _c_present_samples_id;
        private string _c_samples_id;
        private decimal? _n_sam_num;
        private decimal _n_status = 1;
        private string _c_remark;
        private string _c_emp_id;
        private DateTime _d_mod_dt = Convert.ToDateTime(DateTime.Now);
        /// <summary>
        /// 主键
        /// </summary>
        public string C_ID
        {
            set { _c_id = value; }
            get { return _c_id; }
        }
        /// <summary>
        /// 送样信息主表外键
        /// </summary>
        public string C_PRESENT_SAMPLES_ID
        {
            set { _c_present_samples_id = value; }
            get { return _c_present_samples_id; }
        }
        /// <summary>
        /// 取样表主键
        /// </summary>
        public string C_SAMPLES_ID
        {
            set { _c_samples_id = value; }
            get { return _c_samples_id; }
        }
        /// <summary>
        /// 取样数量
        /// </summary>
        public decimal? N_SAM_NUM
        {
            set { _n_sam_num = value; }
            get { return _n_sam_num; }
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
        /// 备注
        /// </summary>
        public string C_REMARK
        {
            set { _c_remark = value; }
            get { return _c_remark; }
        }
        /// <summary>
        /// 操作人员
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

