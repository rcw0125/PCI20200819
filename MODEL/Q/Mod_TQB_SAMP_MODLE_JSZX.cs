using System;
namespace MODEL
{
    /// <summary>
    /// 取样模板（技术中心）
    /// </summary>
    [Serializable]
    public partial class Mod_TQB_SAMP_MODLE_JSZX
    {
        public Mod_TQB_SAMP_MODLE_JSZX()
        { }
        #region Model
        private string _c_id;
        private string _c_std_code;
        private string _c_stl_grd;
        private string _c_spec_min;
        private string _c_spec_max;
        private decimal _n_status = 1;
        private string _c_remark;
        private string _c_emp_id;
        private DateTime _d_mod_dt = DateTime.Now;
        /// <summary>
        /// 主键
        /// </summary>
        public string C_ID
        {
            set { _c_id = value; }
            get { return _c_id; }
        }
        /// <summary>
        /// 执行标准
        /// </summary>
        public string C_STD_CODE
        {
            set { _c_std_code = value; }
            get { return _c_std_code; }
        }
        /// <summary>
        /// 钢种
        /// </summary>
        public string C_STL_GRD
        {
            set { _c_stl_grd = value; }
            get { return _c_stl_grd; }
        }
        /// <summary>
        /// 规格最小值
        /// </summary>
        public string C_SPEC_MIN
        {
            set { _c_spec_min = value; }
            get { return _c_spec_min; }
        }
        /// <summary>
        /// 规格最大值
        /// </summary>
        public string C_SPEC_MAX
        {
            set { _c_spec_max = value; }
            get { return _c_spec_max; }
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
        /// 维护人员
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

