using System;
namespace MODEL
{
    /// <summary>
    /// 班次班组规则表
    /// </summary>
    [Serializable]
    public partial class Mod_TB_BCBZGZ
    {
        public Mod_TB_BCBZGZ()
        { }
        #region Model
        private string _c_id;
        private string _c_emp_id;
        private DateTime _d_mod_dt;
        private string _c_gzmc;
        private string _c_gz;
        private string _c_sfys;
        /// <summary>
        /// 主键
        /// </summary>
        public string C_ID
        {
            set { _c_id = value; }
            get { return _c_id; }
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
        /// 规则名称
        /// </summary>
        public string C_GZMC
        {
            set { _c_gzmc = value; }
            get { return _c_gzmc; }
        }
        /// <summary>
        /// 规则
        /// </summary>
        public string C_GZ
        {
            set { _c_gz = value; }
            get { return _c_gz; }
        }
        /// <summary>
        /// 是否延时
        /// </summary>
        public string C_SFYS
        {
            set { _c_sfys = value; }
            get { return _c_sfys; }
        }
        #endregion Model

    }
}
