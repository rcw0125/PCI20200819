using System;
namespace MODEL
{
    /// <summary>
    /// 修料操作记录
    /// </summary>
    [Serializable]
    public partial class Mod_TQC_UPDATE_MATERIAL_LOG
    {
        public Mod_TQC_UPDATE_MATERIAL_LOG()
        { }
        #region Model
        private string _c_id;
        private string _c_roll_product_id;
        private string _c_type;
        private decimal _n_status = 1;
        private string _c_remark;
        private string _c_emp_id;
        private DateTime _d_mod_dt = Convert.ToDateTime(DateTime.Now);
        private decimal? _n_wgt;
        private decimal? _n_wgt_difference;
        private string _c_sfhg;
        /// <summary>
        /// 主键
        /// </summary>
        public string C_ID
        {
            set { _c_id = value; }
            get { return _c_id; }
        }
        /// <summary>
        /// 线材实绩主键
        /// </summary>
        public string C_ROLL_PRODUCT_ID
        {
            set { _c_roll_product_id = value; }
            get { return _c_roll_product_id; }
        }
        /// <summary>
        /// 确认状态： 0:借料申请，1：还料申请，2：还料确认，3：质量确认,4：取样（终止流程），5：修料申请,6:修料完成
        /// </summary>
        public string C_TYPE
        {
            set { _c_type = value; }
            get { return _c_type; }
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

        /// <summary>
        /// 重量
        /// </summary>
        public decimal? N_WGT
        {
            set { _n_wgt = value; }
            get { return _n_wgt; }
        }
        /// <summary>
        /// 重量差
        /// </summary>
        public decimal? N_WGT_DIFFERENCE
        {
            set { _n_wgt_difference = value; }
            get { return _n_wgt_difference; }
        }
        /// <summary>
        /// 是否合格
        /// </summary>
        public string C_SFHG
        {
            set { _c_sfhg = value; }
            get { return _c_sfhg; }
        }
        #endregion Model

    }
}

