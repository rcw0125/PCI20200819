using System;
namespace MODEL
{
    public class Mod_TRC_WARM_FURNACE
    {
        public Mod_TRC_WARM_FURNACE()
        { }
        #region Model
        private string _c_id = "sys_guid";
        private string _c_batch_no;
        private decimal? _n_qua_join;
        private decimal? _n_wgt_join;
        private string _c_trc_roll_main_id;
        private decimal? _n_roll_state;
        private DateTime? _d_mod_dt = Convert.ToDateTime(DateTime.Now);
        private string _c_emp_id;
        private string _c_sta_id;
        private string _c_shift;
        private string _c_group;
        private decimal? _c_qua_exit;
        private decimal? _c_wgt_exit;
        private string _c_slab_main_id;
        private string _c_stove;
        private decimal? _n_len;
        private string _c_mat_code;
        private string _c_mat_name;

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
        /// 入炉支数
        /// </summary>
        public decimal? N_QUA_JOIN
        {
            set { _n_qua_join = value; }
            get { return _n_qua_join; }
        }
        /// <summary>
        /// 入炉重量
        /// </summary>
        public decimal? N_WGT_JOIN
        {
            set { _n_wgt_join = value; }
            get { return _n_wgt_join; }
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
        /// 入炉状态 1入炉 2出炉
        /// </summary>
        public decimal? N_ROLL_STATE
        {
            set { _n_roll_state = value; }
            get { return _n_roll_state; }
        }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime? D_MOD_DT
        {
            set { _d_mod_dt = value; }
            get { return _d_mod_dt; }
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
        /// 工位主键
        /// </summary>
        public string C_STA_ID
        {
            set { _c_sta_id = value; }
            get { return _c_sta_id; }
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
        /// 出炉支数
        /// </summary>
        public decimal? N_QUA_EXIT
        {
            set { _c_qua_exit = value; }
            get { return _c_qua_exit; }
        }
        /// <summary>
        /// 出炉重量
        /// </summary>
        public decimal? N_WGT_EXIT
        {
            set { _c_wgt_exit = value; }
            get { return _c_wgt_exit; }
        }
        /// <summary>
        /// 钢坯ID
        /// </summary>
        public string C_SLAB_MAIN_ID
        {
            set { _c_slab_main_id = value; }
            get { return _c_slab_main_id; }
        }

        /// <summary>
        /// 炉号
        /// </summary>
        public string C_STOVE
        {
            set { _c_stove = value; }
            get { return _c_stove; }
        }
        /// <summary>
        /// 长度
        /// </summary>
        public decimal? N_LEN
        {
            set { _n_len = value; }
            get { return _n_len; }
        }
        /// <summary>
        /// 物料编码
        /// </summary>
        public string C_MAT_CODE
        {
            set { _c_mat_code = value; }
            get { return _c_mat_code; }
        }
        /// <summary>
        /// 物料名称
        /// </summary>
        public string C_MAT_NAME
        {
            set { _c_mat_name = value; }
            get { return _c_mat_name; }
        }
        #endregion Model
    }
}
