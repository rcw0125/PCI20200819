using System;
namespace MODEL
{
    /// <summary>
    /// TRC_ROLL_LOG:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class Mod_TRC_ROLL_LOG
    {
        public Mod_TRC_ROLL_LOG()
        { }
        #region Model
        private string _c_id = "sys_guid";
        private string _c_trc_roll_main_id;
        private string _c_trc_plan_roll_id;
        private decimal _n_qua_total = 0;
        private decimal _n_wgt_total = 0;
        private string _c_shift;
        private string _c_group;
        private decimal _n_roll_state = 0;
        private string _c_remark;
        private DateTime _d_mod_dt = Convert.ToDateTime(DateTime.Now);
        private decimal _n_qua_remove = 0;
        private decimal _n_wgt_remove = 0;
        private decimal _n_qua_retrun = 0;
        private decimal _n_wgt_retrun = 0;
        private decimal _n_qua_join = 0;
        private decimal _n_wgt_join = 0;
        private decimal _n_qua_exit = 0;
        private decimal _n_wgt_exit = 0;
        private decimal _n_qua_cphalf = 0;
        private decimal _n_wgt_half = 0;
        private decimal _n_qua_cpwhole = 0;
        private decimal _n_qua_elim = 0;
        private decimal _n_wgt_elim = 0;
        private string _c_emp_id;
        private decimal _n_status = 1;
        private decimal? _n_order;
        private decimal _n_qua_sl = 0;
        private decimal _n_qua_hg = 0;
        private decimal _n_wgt_sl = 0;
        private decimal _n_wgt_hg = 0;
        private string _c_log_id;
        private string _c_batch_no;

        /// <summary>
        /// 主键
        /// </summary>
        public string C_ID
        {
            set { _c_id = value; }
            get { return _c_id; }
        }
        /// <summary>
        /// 组批表主键
        /// </summary>
        public string C_TRC_ROLL_MAIN_ID
        {
            set { _c_trc_roll_main_id = value; }
            get { return _c_trc_roll_main_id; }
        }
        /// <summary>
        /// 计划表主键
        /// </summary>
        public string C_TRC_PLAN_ROLL_ID
        {
            set { _c_trc_plan_roll_id = value; }
            get { return _c_trc_plan_roll_id; }
        }
        /// <summary>
        /// 组批支数
        /// </summary>
        public decimal N_QUA_TOTAL
        {
            set { _n_qua_total = value; }
            get { return _n_qua_total; }
        }
        /// <summary>
        /// 组批重量
        /// </summary>
        public decimal N_WGT_TOTAL
        {
            set { _n_wgt_total = value; }
            get { return _n_wgt_total; }
        }
        /// <summary>
        /// 班次
        /// </summary>
        public string C_SHIFT
        {
            set { _c_shift = value; }
            get { return _c_shift; }
        }
        /// <summary>
        /// 班组 
        /// </summary>
        public string C_GROUP
        {
            set { _c_group = value; }
            get { return _c_group; }
        }
        /// <summary>
        /// 组批状态 1组批 2撤销 3修改
        /// </summary>
        public decimal N_ROLL_STATE
        {
            set { _n_roll_state = value; }
            get { return _n_roll_state; }
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
        /// 创建时间
        /// </summary>
        public DateTime D_MOD_DT
        {
            set { _d_mod_dt = value; }
            get { return _d_mod_dt; }
        }
        /// <summary>
        /// 退库支数
        /// </summary>
        public decimal N_QUA_REMOVE
        {
            set { _n_qua_remove = value; }
            get { return _n_qua_remove; }
        }
        /// <summary>
        /// 退库重量
        /// </summary>
        public decimal N_WGT_REMOVE
        {
            set { _n_wgt_remove = value; }
            get { return _n_wgt_remove; }
        }
        /// <summary>
        /// 回炉支数
        /// </summary>
        public decimal N_QUA_RETRUN
        {
            set { _n_qua_retrun = value; }
            get { return _n_qua_retrun; }
        }
        /// <summary>
        /// 回炉重量
        /// </summary>
        public decimal N_WGT_RETRUN
        {
            set { _n_wgt_retrun = value; }
            get { return _n_wgt_retrun; }
        }
        /// <summary>
        /// 入炉支数
        /// </summary>
        public decimal N_QUA_JOIN
        {
            set { _n_qua_join = value; }
            get { return _n_qua_join; }
        }
        /// <summary>
        /// 入炉重量
        /// </summary>
        public decimal N_WGT_JOIN
        {
            set { _n_wgt_join = value; }
            get { return _n_wgt_join; }
        }
        /// <summary>
        /// 出炉支数
        /// </summary>
        public decimal N_QUA_EXIT
        {
            set { _n_qua_exit = value; }
            get { return _n_qua_exit; }
        }
        /// <summary>
        /// 出炉重量
        /// </summary>
        public decimal N_WGT_EXIT
        {
            set { _n_wgt_exit = value; }
            get { return _n_wgt_exit; }
        }
        /// <summary>
        /// 半废支数
        /// </summary>
        public decimal N_QUA_CPHALF
        {
            set { _n_qua_cphalf = value; }
            get { return _n_qua_cphalf; }
        }
        /// <summary>
        /// 半废重量
        /// </summary>
        public decimal N_WGT_HALF
        {
            set { _n_wgt_half = value; }
            get { return _n_wgt_half; }
        }
        /// <summary>
        /// 碎断支数
        /// </summary>
        public decimal N_QUA_CPWHOLE
        {
            set { _n_qua_cpwhole = value; }
            get { return _n_qua_cpwhole; }
        }
        /// <summary>
        /// 剔除支数
        /// </summary>
        public decimal N_QUA_ELIM
        {
            set { _n_qua_elim = value; }
            get { return _n_qua_elim; }
        }
        /// <summary>
        /// 剔除重量
        /// </summary>
        public decimal N_WGT_ELIM
        {
            set { _n_wgt_elim = value; }
            get { return _n_wgt_elim; }
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
        /// 状态0停用1启用
        /// </summary>
        public decimal N_STATUS
        {
            set { _n_status = value; }
            get { return _n_status; }
        }
        /// <summary>
        /// 操作顺序
        /// </summary>
        public decimal? N_ORDER
        {
            set { _n_order = value; }
            get { return _n_order; }
        }
        /// <summary>
        /// 收料支数
        /// </summary>
        public decimal N_QUA_SL
        {
            set { _n_qua_sl = value; }
            get { return _n_qua_sl; }
        }
        /// <summary>
        /// 合格支数
        /// </summary>
        public decimal N_QUA_HG
        {
            set { _n_qua_hg = value; }
            get { return _n_qua_hg; }
        }
        /// <summary>
        /// 收料重量
        /// </summary>
        public decimal N_WGT_SL
        {
            set { _n_wgt_sl = value; }
            get { return _n_wgt_sl; }
        }
        /// <summary>
        /// 合格重量
        /// </summary>
        public decimal N_WGT_HG
        {
            set { _n_wgt_hg = value; }
            get { return _n_wgt_hg; }
        }
        /// <summary>
        /// 上一个Log主键
        /// </summary>
        public string C_LOG_ID
        {
            set { _c_log_id = value; }
            get { return _c_log_id; }
        }

        /// <summary>
        /// 批号
        /// </summary>
        public string C_BATCH_NO
        {
            set { _c_batch_no = value; }
            get { return _c_batch_no; }
        }
        #endregion Model

    }

}