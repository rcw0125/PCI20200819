using System;
namespace MODEL
{
    /// <summary>
    /// 送样信息
    /// </summary>
    [Serializable]
    public partial class Mod_TQC_PRESENT_SAMPLES
    {
        public Mod_TQC_PRESENT_SAMPLES()
        { }
        #region Model
        private string _c_id;
        private string _c_batch_no;
        private string _c_tick_no;
        private string _c_stl_grd;
        private string _c_spec;
        private decimal _n_entrust_type = 0;
        private decimal _n_status = 1;
        private string _c_remark;
        private string _c_emp_id;
        private DateTime _d_mod_dt = Convert.ToDateTime(DateTime.Now);
        private string _c_emp_id_zy;
        private DateTime? _d_mod_dt_zy;
        private string _c_emp_id_js;
        private DateTime? _d_mod_dt_js;
        private string _c_eq_name;
        private string _c_eq_number;
        private string _c_eq_code;
        private decimal? _n_samples_num;
        private string _c_tick_state;
        private string _c_bc_sy;
        private string _c_bz_sy;
        private string _c_bc_jy;
        private string _c_bz_jy;
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
        /// 委托状态   1-已委托；0-未委托；2-接收送样；3-制样
        /// </summary>
        public decimal N_ENTRUST_TYPE
        {
            set { _n_entrust_type = value; }
            get { return _n_entrust_type; }
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
        /// 委托人
        /// </summary>
        public string C_EMP_ID
        {
            set { _c_emp_id = value; }
            get { return _c_emp_id; }
        }
        /// <summary>
        /// 委托时间
        /// </summary>
        public DateTime D_MOD_DT
        {
            set { _d_mod_dt = value; }
            get { return _d_mod_dt; }
        }

        /// <summary>
		/// 接受人
		/// </summary>
		public string C_EMP_ID_ZY
        {
            set { _c_emp_id_zy = value; }
            get { return _c_emp_id_zy; }
        }
        /// <summary>
        /// 接样时间
        /// </summary>
        public DateTime? D_MOD_DT_ZY
        {
            set { _d_mod_dt_zy = value; }
            get { return _d_mod_dt_zy; }
        }

        /// <summary>
		/// 样品明细保存人
		/// </summary>
		public string C_EMP_ID_JS
        {
            set { _c_emp_id_js = value; }
            get { return _c_emp_id_js; }
        }
        /// <summary>
        /// 样品明细保存时间
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
        /// 设备型号
        /// </summary>
        public string C_EQ_NUMBER
        {
            set { _c_eq_number = value; }
            get { return _c_eq_number; }
        }
        /// <summary>
        /// 设备编号
        /// </summary>
        public string C_EQ_CODE
        {
            set { _c_eq_code = value; }
            get { return _c_eq_code; }
        }

        /// <summary>
        /// 取样数量
        /// </summary>
        public decimal? N_SAMPLES_NUM
        {
            set { _n_samples_num = value; }
            get { return _n_samples_num; }
        }
        /// <summary>
        /// 钩号状态；2-首钩；1-尾钩；0其他
        /// </summary>
        public string C_TICK_STATE
        {
            set { _c_tick_state = value; }
            get { return _c_tick_state; }
        }

        /// <summary>
        /// 送样班次
        /// </summary>
        public string C_BC_SY
        {
            set { _c_bc_sy = value; }
            get { return _c_bc_sy; }
        }

        /// <summary>
        /// 送样班组
        /// </summary>
        public string C_BZ_SY
        {
            set { _c_bz_sy = value; }
            get { return _c_bz_sy; }
        }

        /// <summary>
        /// 接样班次
        /// </summary>
        public string C_BC_JY
        {
            set { _c_bc_jy = value; }
            get { return _c_bc_jy; }
        }

        /// <summary>
        /// 接样班组
        /// </summary>
        public string C_BZ_JY
        {
            set { _c_bz_jy = value; }
            get { return _c_bz_jy; }
        }

        #endregion Model

    }
}

