using System;
namespace MODEL
{
    /// <summary>
    /// 质证书数据打印行数
    /// </summary>
    [Serializable]
    public partial class Mod_TQB_ZZS_PRINT_ROWNUM
    {
        public Mod_TQB_ZZS_PRINT_ROWNUM()
        { }
        #region Model
        private string _c_id;
        private string _c_stl_grd;
        private string _c_std_code;
        private DateTime? _d_mod_dt = DateTime.Now;
        private string _c_emp_id;
        private decimal? _n_status;
        private decimal? _n_rownum;
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
        /// <summary>
        /// 打印行数
        /// </summary>
        public decimal? N_ROWNUM
        {
            set { _n_rownum = value; }
            get { return _n_rownum; }
        }
        #endregion Model

    }
}

