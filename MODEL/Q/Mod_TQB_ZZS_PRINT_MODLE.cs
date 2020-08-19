using System;
namespace MODEL
{
    /// <summary>
    /// 钢种标准对应质证书模板
    /// </summary>
    [Serializable]
    public partial class Mod_TQB_ZZS_PRINT_MODLE
    {
        public Mod_TQB_ZZS_PRINT_MODLE()
        { }
        #region Model
        private string _c_id;
        private string _c_stl_grd;
        private string _c_std_code;
        private string _c_modle_type;
        private DateTime? _d_mod_dt = DateTime.Now;
        private string _c_emp_id;
        private decimal? _n_status;
        /// <summary>
        /// 主键
        /// </summary>
        public string C_ID
        {
            set { _c_id = value; }
            get { return _c_id; }
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
        /// 执行标准
        /// </summary>
        public string C_STD_CODE
        {
            set { _c_std_code = value; }
            get { return _c_std_code; }
        }
        /// <summary>
        /// 1-普通；2-认证；3-D零件;
        /// </summary>
        public string C_MODLE_TYPE
        {
            set { _c_modle_type = value; }
            get { return _c_modle_type; }
        }
        /// <summary>
        /// 维护时间
        /// </summary>
        public DateTime? D_MOD_DT
        {
            set { _d_mod_dt = value; }
            get { return _d_mod_dt; }
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
        /// 使用状态   1-可用；0-停用
        /// </summary>
        public decimal? N_STATUS
        {
            set { _n_status = value; }
            get { return _n_status; }
        }
        #endregion Model

    }
}

