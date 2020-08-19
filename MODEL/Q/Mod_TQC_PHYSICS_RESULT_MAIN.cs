using System;
namespace MODEL
{
    /// <summary>
    /// 物理性能结果主表
    /// </summary>
    [Serializable]
    public partial class Mod_TQC_PHYSICS_RESULT_MAIN
    {
        public Mod_TQC_PHYSICS_RESULT_MAIN()
        { }
        #region Model
        private string _c_id = "sys_guid";
        private string _c_batch_no;
        private string _c_tick_no;
        private string _c_stl_grd;
        private string _c_spec;
        private decimal _n_status = 1;
        private string _c_remark;
        private string _c_emp_id;
        private DateTime? _d_mod_dt = Convert.ToDateTime(null);
        private string _c_emp_id_zy;
        private DateTime? _d_mod_dt_zy;
        private string _c_emp_id_js;
        private DateTime? _d_mod_dt_js;
        private string _c_eq_name;
        private decimal _n_is_lr = 0;
        private DateTime _d_transt = Convert.ToDateTime(DateTime.Now);
        private string _c_physics_group_id;
        private string _c_check_state;
        private string _c_present_samples_id;
        private string _c_is_pd = "0";
        private string _c_temp;
        private string _c_humidity;
        private decimal? _n_recheck;
        private string _c_bc;
        private string _c_bz;
        private string _c_check_user;
        /// <summary>
        /// 主键
        /// </summary>
        public string C_ID
        {
            set { _c_id = value; }
            get { return _c_id; }
        }
        /// <summary>
        /// 批号
        /// </summary>
        public string C_BATCH_NO
        {
            set { _c_batch_no = value; }
            get { return _c_batch_no; }
        }
        /// <summary>
        /// 钩号
        /// </summary>
        public string C_TICK_NO
        {
            set { _c_tick_no = value; }
            get { return _c_tick_no; }
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
        /// 送样人
        /// </summary>
        public string C_EMP_ID
        {
            set { _c_emp_id = value; }
            get { return _c_emp_id; }
        }
        /// <summary>
        /// 送样时间
        /// </summary>
        public DateTime? D_MOD_DT
        {
            set { _d_mod_dt = value; }
            get { return _d_mod_dt; }
        }
        /// <summary>
        /// 制样人
        /// </summary>
        public string C_EMP_ID_ZY
        {
            set { _c_emp_id_zy = value; }
            get { return _c_emp_id_zy; }
        }
        /// <summary>
        /// 制样时间
        /// </summary>
        public DateTime? D_MOD_DT_ZY
        {
            set { _d_mod_dt_zy = value; }
            get { return _d_mod_dt_zy; }
        }
        /// <summary>
        /// 样品接收人
        /// </summary>
        public string C_EMP_ID_JS
        {
            set { _c_emp_id_js = value; }
            get { return _c_emp_id_js; }
        }
        /// <summary>
        /// 样品接收时间
        /// </summary>
        public DateTime? D_MOD_DT_JS
        {
            set { _d_mod_dt_js = value; }
            get { return _d_mod_dt_js; }
        }
        /// <summary>
        /// 设备名称
        /// </summary>
        public string C_EQ_NAME
        {
            set { _c_eq_name = value; }
            get { return _c_eq_name; }
        }
        /// <summary>
        /// 是否已录入性能结果；0-未录入；1-已录入；
        /// </summary>
        public decimal N_IS_LR
        {
            set { _n_is_lr = value; }
            get { return _n_is_lr; }
        }
        /// <summary>
        /// 添加时间
        /// </summary>
        public DateTime D_TRANST
        {
            set { _d_transt = value; }
            get { return _d_transt; }
        }
        /// <summary>
        /// 物理性能外键
        /// </summary>
        public string C_PHYSICS_GROUP_ID
        {
            set { _c_physics_group_id = value; }
            get { return _c_physics_group_id; }
        }
        /// <summary>
        ///  状态；0-初检；1-复检；2-评审
        /// </summary>
        public string C_CHECK_STATE
        {
            set { _c_check_state = value; }
            get { return _c_check_state; }
        }
        /// <summary>
        ///  取样主表主键（tqc_present_samples）
        /// </summary>
        public string C_PRESENT_SAMPLES_ID
        {
            set { _c_present_samples_id = value; }
            get { return _c_present_samples_id; }
        }
        /// <summary>
        ///  是否已判定；0-未判定；1-已判定；
        /// </summary>
        public string C_IS_PD
        {
            set { _c_is_pd = value; }
            get { return _c_is_pd; }
        }
        /// <summary>
        /// 温度
        /// </summary>
        public string C_TEMP
        {
            set { _c_temp = value; }
            get { return _c_temp; }
        }
        /// <summary>
        /// 湿度
        /// </summary>
        public string C_HUMIDITY
        {
            set { _c_humidity = value; }
            get { return _c_humidity; }
        }

        /// <summary>
        /// 第几次复检
        /// </summary>
        public decimal? N_RECHECK
        {
            set { _n_recheck = value; }
            get { return _n_recheck; }
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
        /// 审核人
        /// </summary>
        public string C_CHECK_USER
        {
            set { _c_check_user = value; }
            get { return _c_check_user; }
        }

        #endregion Model

    }
}

