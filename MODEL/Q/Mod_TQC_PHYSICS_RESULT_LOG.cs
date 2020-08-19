using System;
namespace MODEL
{
    /// <summary>
    /// 性能结果表
    /// </summary>
    [Serializable]
    public partial class Mod_TQC_PHYSICS_RESULT_LOG
    {
        public Mod_TQC_PHYSICS_RESULT_LOG()
        { }
        #region Model
        private string _c_id;
        private string _c_physics_group_id;
        private string _c_present_samples_id;
        private string _c_character_id;
        private string _c_character_code;
        private string _c_character_name;
        private string _c_value;
        private decimal _n_status = 1;
        private string _c_remark;
        private string _c_emp_id;
        private DateTime _d_mod_dt = DateTime.Now;
        private decimal _n_split = 0;
        private decimal? _n_type = 0;
        private string _c_check_state;
        private string _c_tick_no;
        private string _c_group;
        private string _c_edit_num;
        /// <summary>
        /// 主键
        /// </summary>
        public string C_ID
        {
            set { _c_id = value; }
            get { return _c_id; }
        }
        /// <summary>
        /// 物理分组表主键
        /// </summary>
        public string C_PHYSICS_GROUP_ID
        {
            set { _c_physics_group_id = value; }
            get { return _c_physics_group_id; }
        }
        /// <summary>
        /// TQC_PHYSICS_RESULT_main主键
        /// </summary>
        public string C_PRESENT_SAMPLES_ID
        {
            set { _c_present_samples_id = value; }
            get { return _c_present_samples_id; }
        }
        /// <summary>
        /// 检验基础数据表主键
        /// </summary>
        public string C_CHARACTER_ID
        {
            set { _c_character_id = value; }
            get { return _c_character_id; }
        }
        /// <summary>
        /// 性能代码
        /// </summary>
        public string C_CHARACTER_CODE
        {
            set { _c_character_code = value; }
            get { return _c_character_code; }
        }
        /// <summary>
        /// 性能名称
        /// </summary>
        public string C_CHARACTER_NAME
        {
            set { _c_character_name = value; }
            get { return _c_character_name; }
        }
        /// <summary>
        /// 性能值
        /// </summary>
        public string C_VALUE
        {
            set { _c_value = value; }
            get { return _c_value; }
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
        /// 维护人员
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
        /// <summary>
        /// 是否同步到综合判定   1-已同步；0-未同步
        /// </summary>
        public decimal N_SPLIT
        {
            set { _n_split = value; }
            get { return _n_split; }
        }
        /// <summary>
        /// 0过程量；1检验量
        /// </summary>
        public decimal? N_TYPE
        {
            set { _n_type = value; }
            get { return _n_type; }
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
        /// 钩号
        /// </summary>
        public string C_TICK_NO
        {
            set { _c_tick_no = value; }
            get { return _c_tick_no; }
        }
        /// <summary>
        /// 第几组实验
        /// </summary>
        public string C_GROUP
        {
            set { _c_group = value; }
            get { return _c_group; }
        }
        /// <summary>
		/// 第几次修改
		/// </summary>
		public string C_EDIT_NUM
        {
            set { _c_edit_num = value; }
            get { return _c_edit_num; }
        }
        #endregion Model

    }
}

