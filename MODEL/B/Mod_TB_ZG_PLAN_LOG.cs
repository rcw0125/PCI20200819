using System;
namespace MODEL
{
    /// <summary>
    /// 轧钢排产日志表
    /// </summary>
    [Serializable]
    public partial class Mod_TB_ZG_PLAN_LOG
    {
        public Mod_TB_ZG_PLAN_LOG()
        { }
        #region Model
        private string _c_id;
        private string _c_plan_name;
        private string _c_reason;
        private string _c_emp_id;
        private string _c_emp_name;
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
        /// 排产名称
        /// </summary>
        public string C_PLAN_NAME
        {
            set { _c_plan_name = value; }
            get { return _c_plan_name; }
        }
        /// <summary>
        /// 排产原因
        /// </summary>
        public string C_REASON
        {
            set { _c_reason = value; }
            get { return _c_reason; }
        }
        /// <summary>
        /// 操作人ID
        /// </summary>
        public string C_EMP_ID
        {
            set { _c_emp_id = value; }
            get { return _c_emp_id; }
        }
        /// <summary>
        /// 操作人
        /// </summary>
        public string C_EMP_NAME
        {
            set { _c_emp_name = value; }
            get { return _c_emp_name; }
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

