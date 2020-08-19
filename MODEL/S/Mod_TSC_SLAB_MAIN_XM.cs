using System;
namespace MODEL
{/// <summary>
 /// 钢坯修磨表
 /// </summary>
    [Serializable]
    public partial class Mod_TSC_SLAB_MAIN_XM
    {
        public Mod_TSC_SLAB_MAIN_XM()
        { }
        #region Model
        private string _c_id = "sys_guid";
        private string _c_slab_main_plan_id;
        private string _c_sta_id;
        private string _c_xmgx;
        private decimal? _n_xmzs;
        private decimal? _n_bfzs;
        private decimal? _n_xmsj;
        private string _c_bc;
        private string _c_bz;
        private string _c_emp_id;
        private DateTime _d_mod_dt = Convert.ToDateTime(DateTime.Now);
        private string _c_remark;
        private decimal? _n_status=1;
        private DateTime? _d_act_start_time;
        private DateTime? _d_act_end_time;
        /// <summary>
        /// 主键
        /// </summary>
        public string C_ID
        {
            set { _c_id = value; }
            get { return _c_id; }
        }
        /// <summary>
        /// 钢坯修磨计划表
        /// </summary>
        public string C_SLAB_MAIN_PLAN_ID
        {
            set { _c_slab_main_plan_id = value; }
            get { return _c_slab_main_plan_id; }
        }
        /// <summary>
        /// 修磨工序
        /// </summary>
        public string C_XMGX
        {
            set { _c_xmgx = value; }
            get { return _c_xmgx; }
        }
        /// <summary>
        /// 工位(修磨线)
        /// </summary>
        public string C_STA_ID
        {
            set { _c_sta_id = value; }
            get { return _c_sta_id; }
        }
        /// <summary>
        /// 修磨支数
        /// </summary>
        public decimal? N_XMZS
        {
            set { _n_xmzs = value; }
            get { return _n_xmzs; }
        }
        /// <summary>
        /// 报废支数
        /// </summary>
        public decimal? N_BFZS
        {
            set { _n_bfzs = value; }
            get { return _n_bfzs; }
        }
        /// <summary>
        /// 修磨时间
        /// </summary>
        public decimal? N_XMSJ
        {
            set { _n_xmsj = value; }
            get { return _n_xmsj; }
        }
        /// <summary>
        /// 班次
        /// </summary>
        public string C_BC
        {
            set { _c_bc = value; }
            get { return _c_bc; }
        }
        /// <summary>
        /// 班组
        /// </summary>
        public string C_BZ
        {
            set { _c_bz = value; }
            get { return _c_bz; }
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
        /// 1正常2撤回
        /// </summary>
        public decimal? N_STATUS
        {
            set { _n_status = value; }
            get { return _n_status; }
        }
        /// <summary>
        /// 实际开始时间
        /// </summary>
        public DateTime? D_ACT_START_TIME
        {
            set { _d_act_start_time = value; }
            get { return _d_act_start_time; }
        }
        /// <summary>
        /// 实际结束时间
        /// </summary>
        public DateTime? D_ACT_END_TIME
        {
            set { _d_act_end_time = value; }
            get { return _d_act_end_time; }
        }
        #endregion Model

    }
}
