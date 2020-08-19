using System;
namespace MODEL
{

    /// <summary>
    /// 修磨计划表
    /// </summary>
    [Serializable]
    public partial class Mod_TPP_SLAB_PLAN_XM
    {
        public Mod_TPP_SLAB_PLAN_XM()
        { }
        #region Model
        private string _c_id = "sys_guid";
        private string _c_sta_id;
        private string _c_xm_desc;
        private string _c_plan_id;
        private string _c_stl_grd;
        private string _c_spec;
        private decimal? _n_lth = 0;
        private string _c_std_code;
        private decimal? _n_qty;
        private decimal? _n_wgt;
        private DateTime? _d_plan_dt;
        private DateTime? _d_plan_start;
        private DateTime? _d_plan_end;
        private decimal? _n_status = 1;
        private decimal? _n_act_status = 1;
        private string _c_emp_id = "同步NC";
        private DateTime _d_mod_dt = Convert.ToDateTime(DateTime.Now);
        private string _c_remark;
        private decimal? _n_act_qty;
        /// <summary>
        /// 主键
        /// </summary>
        public string C_ID
        {
            set { _c_id = value; }
            get { return _c_id; }
        }
        /// <summary>
        /// 执行工位
        /// </summary>
        public string C_STA_ID
        {
            set { _c_sta_id = value; }
            get { return _c_sta_id; }
        }
        /// <summary>
        /// 修磨要求
        /// </summary>
        public string C_XM_DESC
        {
            set { _c_xm_desc = value; }
            get { return _c_xm_desc; }
        }
        /// <summary>
        /// 计划id
        /// </summary>
        public string C_PLAN_ID
        {
            set { _c_plan_id = value; }
            get { return _c_plan_id; }
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
        /// 规格
        /// </summary>
        public string C_SPEC
        {
            set { _c_spec = value; }
            get { return _c_spec; }
        }
        /// <summary>
        /// 长度
        /// </summary>
        public decimal? N_LTH
        {
            set { _n_lth = value; }
            get { return _n_lth; }
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
        /// 计划支数
        /// </summary>
        public decimal? N_QTY
        {
            set { _n_qty = value; }
            get { return _n_qty; }
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
        /// 计划日期
        /// </summary>
        public DateTime? D_PLAN_DT
        {
            set { _d_plan_dt = value; }
            get { return _d_plan_dt; }
        }
        /// <summary>
        /// 计划开始时间
        /// </summary>
        public DateTime? D_PLAN_START
        {
            set { _d_plan_start = value; }
            get { return _d_plan_start; }
        }
        /// <summary>
        /// 计划结束时间
        /// </summary>
        public DateTime? D_PLAN_END
        {
            set { _d_plan_end = value; }
            get { return _d_plan_end; }
        }
        /// <summary>
        /// 状态0停用1启用
        /// </summary>
        public decimal? N_STATUS
        {
            set { _n_status = value; }
            get { return _n_status; }
        }
        /// <summary>
        /// 执行状态
        /// </summary>
        public decimal? N_ACT_STATUS
        {
            set { _n_act_status = value; }
            get { return _n_act_status; }
        }
        /// <summary>
        /// 操作人员
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
        /// 执行支数
        /// </summary>
        public decimal? N_ACT_QTY
        {
            set { _n_act_qty = value; }
            get { return _n_act_qty; }
        }
        #endregion Model

    }
}
