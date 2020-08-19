using System;
namespace MODEL
{
    /// <summary>
    /// 线材修磨表
    /// </summary>
    [Serializable]
    public partial class Mod_TPB_ROLLXM
    {
        public Mod_TPB_ROLLXM()
        { }
        #region Model
        private string _c_id = "sys_guid";
        private string _c_stl_grd;
        private string _c_std_code;
        private string _c_xmfs;
        private decimal? _n_sfxmhpwts;
        private string _c_remark;
        private string _c_emp_id;
        private DateTime _d_mod_dt = Convert.ToDateTime(DateTime.Now);
        private string _c_spec_str;
        private decimal? _n_sfxmqpwts;
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
        /// 修磨方式
        /// </summary>
        public string C_XMFS
        {
            set { _c_xmfs = value; }
            get { return _c_xmfs; }
        }
        /// <summary>
        /// 是否修磨后抛丸探伤1是0否
        /// </summary>
        public decimal? N_SFXMHPWTS
        {
            set { _n_sfxmhpwts = value; }
            get { return _n_sfxmhpwts; }
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
        /// 规格字符串
        /// </summary>
        public string C_SPEC_STR
        {
            set { _c_spec_str = value; }
            get { return _c_spec_str; }
        }
        /// <summary>
        /// 是否修磨前抛丸探伤1是0否
        /// </summary>
        public decimal? N_SFXMQPWTS
        {
            set { _n_sfxmqpwts = value; }
            get { return _n_sfxmqpwts; }
        }
        #endregion Model

    }
}
