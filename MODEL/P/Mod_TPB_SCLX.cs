using System;
namespace MODEL
{
    /// <summary>
    /// 生产路线
    /// </summary>
    [Serializable]
    public partial class Mod_TPB_SCLX
    {
        public Mod_TPB_SCLX()
        { }
        #region Model
        private string _c_id = "sys_guid";
        private string _c_cc;
        private string _c_zl;
        private string _c_lf;
        private string _c_rh;
        private string _c_emp_id;
        private DateTime _d_mod_dt;
        /// <summary>
        /// 主键
        /// </summary>
        public string C_ID
        {
            set { _c_id = value; }
            get { return _c_id; }
        }
        /// <summary>
        /// 连铸
        /// </summary>
        public string C_CC
        {
            set { _c_cc = value; }
            get { return _c_cc; }
        }
        /// <summary>
        /// 转炉
        /// </summary>
        public string C_ZL
        {
            set { _c_zl = value; }
            get { return _c_zl; }
        }
        /// <summary>
        /// 精炼
        /// </summary>
        public string C_LF
        {
            set { _c_lf = value; }
            get { return _c_lf; }
        }
        /// <summary>
        /// 真空
        /// </summary>
        public string C_RH
        {
            set { _c_rh = value; }
            get { return _c_rh; }
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
        #endregion Model

    }
}
