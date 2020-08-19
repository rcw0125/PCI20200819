using System;
namespace MODEL
{
    /// <summary>
    /// 线材计划不生产原因记录表
    /// </summary>
    [Serializable]
    public partial class Mod_TRP_PLAN_REASON
    {
        public Mod_TRP_PLAN_REASON()
        { }
        #region Model
        private string _c_id;
        private string _c_plan_roll_id;
        private string _c_order_no;
        private string _c_stl_grd;
        private string _c_std_code;
        private string _c_spec;
        private string _c_reason;
        private decimal _n_status = 1;
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
        /// 计划主键（trp_plan_roll）
        /// </summary>
        public string C_PLAN_ROLL_ID
        {
            set { _c_plan_roll_id = value; }
            get { return _c_plan_roll_id; }
        }
        /// <summary>
        /// 订单号
        /// </summary>
        public string C_ORDER_NO
        {
            set { _c_order_no = value; }
            get { return _c_order_no; }
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
        /// 规格
        /// </summary>
        public string C_SPEC
        {
            set { _c_spec = value; }
            get { return _c_spec; }
        }
        /// <summary>
        /// 原因
        /// </summary>
        public string C_REASON
        {
            set { _c_reason = value; }
            get { return _c_reason; }
        }
        /// <summary>
        /// 是否停用；1正常，0停用
        /// </summary>
        public decimal N_STATUS
        {
            set { _n_status = value; }
            get { return _n_status; }
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

