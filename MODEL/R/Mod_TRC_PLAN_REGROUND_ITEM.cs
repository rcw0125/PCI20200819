using System;
namespace MODEL
{
    /// <summary>
    /// 修磨计划子表
    /// </summary>
    [Serializable]
    public partial class Mod_TRC_PLAN_REGROUND_ITEM
    {
        public Mod_TRC_PLAN_REGROUND_ITEM()
        { }
        #region Model
        private string _c_id = "sys_guid";
        private string _c_plan_reground_id;
        private string _c_slab_main_id;
        private string _c_remark;
        private decimal? _n_step;
        private decimal? _n_totalstep;
        private string _n_stepname;
        private decimal _n_status = 0;
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
        /// 主表id
        /// </summary>
        public string C_PLAN_REGROUND_ID
        {
            set { _c_plan_reground_id = value; }
            get { return _c_plan_reground_id; }
        }
        /// <summary>
        /// 钢坯id
        /// </summary>
        public string C_SLAB_MAIN_ID
        {
            set { _c_slab_main_id = value; }
            get { return _c_slab_main_id; }
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
        /// 步骤
        /// </summary>
        public decimal? N_STEP
        {
            set { _n_step = value; }
            get { return _n_step; }
        }
        /// <summary>
        /// 总步骤
        /// </summary>
        public decimal? N_TOTALSTEP
        {
            set { _n_totalstep = value; }
            get { return _n_totalstep; }
        }
        /// <summary>
        /// 步骤名称
        /// </summary>
        public string N_STEPNAME
        {
            set { _n_stepname = value; }
            get { return _n_stepname; }
        }
        /// <summary>
        /// 当前状态0闲置1正在处理2已处理
        /// </summary>
        public decimal N_STATUS
        {
            set { _n_status = value; }
            get { return _n_status; }
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
