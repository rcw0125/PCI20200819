using System;
namespace MODEL
{
    /// <summary>
    /// 初始化排产方案生产工位
    /// </summary>
    [Serializable]
    public partial class Mod_TPP_INITIALIZE_STA
    {
        public Mod_TPP_INITIALIZE_STA()
        { }
        #region Model
        private string _c_id = "sys_guid";
        private string _c_sta_id;
        private string _c_emp_id;
        private DateTime _d_mod_dt = Convert.ToDateTime(DateTime.Now);
        private string _c_remark;
        private decimal? _n_producibility_time;
        private decimal? _n_impact_time;
        private decimal? _n_capacity = 0
;
		private string _c_pro_code;
        private string _c_initialize_item_id;
        private decimal? _n_wgt = 0
;
		private string _c_sta_desc;
        private string _c_pro_id;
        private string _c_sta_code;
        private DateTime? _d_start_time;
        private DateTime? _d_end_time;
        /// <summary>
        /// 主键
        /// </summary>
        public string C_ID
        {
            set { _c_id = value; }
            get { return _c_id; }
        }
        /// <summary>
        /// 工位主键
        /// </summary>
        public string C_STA_ID
        {
            set { _c_sta_id = value; }
            get { return _c_sta_id; }
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
        /// 备注
        /// </summary>
        public string C_REMARK
        {
            set { _c_remark = value; }
            get { return _c_remark; }
        }
        /// <summary>
        /// 可生产时间
        /// </summary>
        public decimal? N_PRODUCIBILITY_TIME
        {
            set { _n_producibility_time = value; }
            get { return _n_producibility_time; }
        }
        /// <summary>
        /// 生产影响时间
        /// </summary>
        public decimal? N_IMPACT_TIME
        {
            set { _n_impact_time = value; }
            get { return _n_impact_time; }
        }
        /// <summary>
        /// 产能
        /// </summary>
        public decimal? N_CAPACITY
        {
            set { _n_capacity = value; }
            get { return _n_capacity; }
        }
        /// <summary>
        /// 工序代码
        /// </summary>
        public string C_PRO_CODE
        {
            set { _c_pro_code = value; }
            get { return _c_pro_code; }
        }
        /// <summary>
        /// 订单方案表主键
        /// </summary>
        public string C_INITIALIZE_ITEM_ID
        {
            set { _c_initialize_item_id = value; }
            get { return _c_initialize_item_id; }
        }
        /// <summary>
        /// 排产量
        /// </summary>
        public decimal? N_WGT
        {
            set { _n_wgt = value; }
            get { return _n_wgt; }
        }
        /// <summary>
        /// 工位描述
        /// </summary>
        public string C_STA_DESC
        {
            set { _c_sta_desc = value; }
            get { return _c_sta_desc; }
        }
        /// <summary>
        /// 工序主键
        /// </summary>
        public string C_PRO_ID
        {
            set { _c_pro_id = value; }
            get { return _c_pro_id; }
        }
        /// <summary>
        /// 工位描述
        /// </summary>
        public string C_STA_CODE
        {
            set { _c_sta_code = value; }
            get { return _c_sta_code; }
        }
        /// <summary>
        /// 排产周期开始时间
        /// </summary>
        public DateTime? D_START_TIME
        {
            set { _d_start_time = value; }
            get { return _d_start_time; }
        }
        /// <summary>
        /// 排产周期结束时间
        /// </summary>
        public DateTime? D_END_TIME
        {
            set { _d_end_time = value; }
            get { return _d_end_time; }
        }
        #endregion Model

    }
}
