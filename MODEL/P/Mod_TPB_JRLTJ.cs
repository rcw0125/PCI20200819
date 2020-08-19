using System;
namespace MODEL
{
    /// <summary>
    /// 加热炉条件管理
    /// </summary>
    [Serializable]
    public partial class Mod_TPB_JRLTJ
    {
        public Mod_TPB_JRLTJ()
        { }
        #region Model
        private string _c_id = "sys_guid";
        private string _c_stl_grd;
        private string _c_std_code;
        private string _c_spec_str;
        private decimal? _n_wd;
        private decimal? _n_time;
        private string _c_remark;
        private string _c_emp_id;
        private DateTime _d_mod_dt = Convert.ToDateTime(DateTime.Now);
        private string _c_sta_id;
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
        /// 规格字符串
        /// </summary>
        public string C_SPEC_STR
        {
            set { _c_spec_str = value; }
            get { return _c_spec_str; }
        }
        /// <summary>
        /// 温度
        /// </summary>
        public decimal? N_WD
        {
            set { _n_wd = value; }
            get { return _n_wd; }
        }
        /// <summary>
        /// 加热时间
        /// </summary>
        public decimal? N_TIME
        {
            set { _n_time = value; }
            get { return _n_time; }
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
        /// 工位
        /// </summary>
        public string C_STA_ID
        {
            set { _c_sta_id = value; }
            get { return _c_sta_id; }
        }
        #endregion Model

    }
}
