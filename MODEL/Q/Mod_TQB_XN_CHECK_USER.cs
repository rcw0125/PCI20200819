using System;
namespace MODEL
{
    /// <summary>
    /// 性能录入审核人信息表
    /// </summary>
    [Serializable]
    public partial class Mod_TQB_XN_CHECK_USER
    {
        public Mod_TQB_XN_CHECK_USER()
        { }
        #region Model
        private string _c_id;
        private string _c_user_name;
        private string _c_dept;
        private decimal _n_status = 1;
        private string _c_emp_id;
        private DateTime _d_mod_dt = DateTime.Now;
        private string _c_remark;
        /// <summary>
        /// 主键
        /// </summary>
        public string C_ID
        {
            set { _c_id = value; }
            get { return _c_id; }
        }
        /// <summary>
        /// 审核人姓名
        /// </summary>
        public string C_USER_NAME
        {
            set { _c_user_name = value; }
            get { return _c_user_name; }
        }
        /// <summary>
        /// 部门
        /// </summary>
        public string C_DEPT
        {
            set { _c_dept = value; }
            get { return _c_dept; }
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
        /// 备注
        /// </summary>
        public string C_REMARK
        {
            set { _c_remark = value; }
            get { return _c_remark; }
        }
        #endregion Model

    }
}

