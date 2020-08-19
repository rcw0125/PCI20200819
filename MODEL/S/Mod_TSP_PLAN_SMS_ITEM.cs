using System;
namespace MODEL
{
    /// <summary>
    /// 炼钢计划拆分表
    /// </summary>
    [Serializable]
    public partial class Mod_TSP_PLAN_SMS_ITEM
    {
        public Mod_TSP_PLAN_SMS_ITEM()
        { }
        #region Model
        private string _c_id;
        private string _c_production_plan_id;
        private string _c_plan_sms_id;
        private decimal? _n_wgt;
        private decimal _n_status = 1M;
        private string _c_remark;
        private string _c_emp_id;
        private DateTime _d_mod_dt = Convert.ToDateTime(DateTime.Now);
        /// <summary>
        /// 主键
        /// </summary>
        public string C_ID
        {
            set { _c_id = value; }
            get { return _c_id; }
        }
        /// <summary>
        /// tpp_production_plan主键
        /// </summary>
        public string C_PRODUCTION_PLAN_ID
        {
            set { _c_production_plan_id = value; }
            get { return _c_production_plan_id; }
        }
        /// <summary>
        /// tsp_plan_sms计划号
        /// </summary>
        public string C_PLAN_SMS_ID
        {
            set { _c_plan_sms_id = value; }
            get { return _c_plan_sms_id; }
        }
        /// <summary>
        /// 计划重量
        /// </summary>
        public decimal? N_WGT
        {
            set { _n_wgt = value; }
            get { return _n_wgt; }
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
        #endregion Model

    }
}

