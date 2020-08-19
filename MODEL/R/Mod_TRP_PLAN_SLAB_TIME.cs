using System;
namespace MODEL
{
    /// <summary>
    /// 轧钢计划钢坯时间表
    /// </summary>
    [Serializable]
    public partial class Mod_TRP_PLAN_SLAB_TIME
    {
        public Mod_TRP_PLAN_SLAB_TIME()
        { }
        #region Model
        private string _c_id;
        private string _c_plan_roll_id;
        private decimal? _n_wgt;
        private DateTime? _d_p_start_time;
        private DateTime? _d_p_end_time;
        private string _c_stl_grd;
        private string _c_std_code;
        private string _c_spec;
        private string _c_state;
        /// <summary>
        /// 主键
        /// </summary>
        public string C_ID
        {
            set { _c_id = value; }
            get { return _c_id; }
        }
        /// <summary>
        /// TRP_PLAN_ROLL主键
        /// </summary>
        public string C_PLAN_ROLL_ID
        {
            set { _c_plan_roll_id = value; }
            get { return _c_plan_roll_id; }
        }
        /// <summary>
        /// 重量
        /// </summary>
        public decimal? N_WGT
        {
            set { _n_wgt = value; }
            get { return _n_wgt; }
        }
        /// <summary>
        /// 开始时间
        /// </summary>
        public DateTime? D_P_START_TIME
        {
            set { _d_p_start_time = value; }
            get { return _d_p_start_time; }
        }
        /// <summary>
        /// 结束时间
        /// </summary>
        public DateTime? D_P_END_TIME
        {
            set { _d_p_end_time = value; }
            get { return _d_p_end_time; }
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
        /// 状态
        /// </summary>
        public string C_STATE
        {
            set { _c_state = value; }
            get { return _c_state; }
        }

        #endregion Model

    }
}

