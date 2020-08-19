using System;
namespace MODEL
{
    /// <summary>
    /// 综合判定项目结果明细表
    /// </summary>
    [Serializable]
    public partial class Mod_TQC_COMPRE_ITEM_RESULT
    {
        public Mod_TQC_COMPRE_ITEM_RESULT()
        { }
        #region Model
        private string _c_id = "sys_guid";
        private string _c_stove;
        private string _c_batch_no;
        private string _c_stl_grd;
        private string _c_spec;
        private string _c_std_code;
        private string _c_character_id;
        private string _c_item_name;
        private string _c_target_min;
        private string _c_target_interval;
        private string _c_target_max;
        private string _c_type;
        private string _c_unit;
        private string _c_quantitative;
        private string _c_value;
        private string _c_result;
        private string _c_check_state;
        private decimal _n_status = 1;
        private string _c_remark;
        private string _c_emp_id;
        private DateTime _d_mod_dt = DateTime.Now;
        private string _c_design_no;
        private decimal? _n_print_order;
        private string _c_tick_no;
        private string _c_is_show;
        private string _c_is_decide;
        private string _c_group;
        private string _c_tb = "N";
        private string _c_source = "0";
        /// <summary>
        /// 主键
        /// </summary>
        public string C_ID
        {
            set { _c_id = value; }
            get { return _c_id; }
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
        /// 批号
        /// </summary>
        public string C_BATCH_NO
        {
            set { _c_batch_no = value; }
            get { return _c_batch_no; }
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
        /// 执行标准代码
        /// </summary>
        public string C_STD_CODE
        {
            set { _c_std_code = value; }
            get { return _c_std_code; }
        }
        /// <summary>
        /// 检验基础数据外键
        /// </summary>
        public string C_CHARACTER_ID
        {
            set { _c_character_id = value; }
            get { return _c_character_id; }
        }
        /// <summary>
        /// 项目名称
        /// </summary>
        public string C_ITEM_NAME
        {
            set { _c_item_name = value; }
            get { return _c_item_name; }
        }
        /// <summary>
        /// 目标最小值
        /// </summary>
        public string C_TARGET_MIN
        {
            set { _c_target_min = value; }
            get { return _c_target_min; }
        }
        /// <summary>
        /// 目标值区间
        /// </summary>
        public string C_TARGET_INTERVAL
        {
            set { _c_target_interval = value; }
            get { return _c_target_interval; }
        }
        /// <summary>
        /// 目标最大值
        /// </summary>
        public string C_TARGET_MAX
        {
            set { _c_target_max = value; }
            get { return _c_target_max; }
        }
        /// <summary>
        /// 项目类型
        /// </summary>
        public string C_TYPE
        {
            set { _c_type = value; }
            get { return _c_type; }
        }
        /// <summary>
        /// 单位
        /// </summary>
        public string C_UNIT
        {
            set { _c_unit = value; }
            get { return _c_unit; }
        }
        /// <summary>
        /// 定性/定量
        /// </summary>
        public string C_QUANTITATIVE
        {
            set { _c_quantitative = value; }
            get { return _c_quantitative; }
        }
        /// <summary>
        /// 项目值
        /// </summary>
        public string C_VALUE
        {
            set { _c_value = value; }
            get { return _c_value; }
        }
        /// <summary>
        /// 判定结果；Y-合格；N-不合格；'null'-不需要判定;E-数据有误；
        /// </summary>
        public string C_RESULT
        {
            set { _c_result = value; }
            get { return _c_result; }
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
        /// 使用状态   1-可用；0-停用
        /// </summary>
        public decimal N_STATUS
        {
            set { _n_status = value; }
            get { return _n_status; }
        }
        /// <summary>
        /// 小数位数
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
        /// 质量设计号
        /// </summary>
        public string C_DESIGN_NO
        {
            set { _c_design_no = value; }
            get { return _c_design_no; }
        }
        /// <summary>
        /// 打印顺序
        /// </summary>
        public decimal? N_PRINT_ORDER
        {
            set { _n_print_order = value; }
            get { return _n_print_order; }
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
        /// 是否打印；是/否
        /// </summary>
        public string C_IS_SHOW
        {
            set { _c_is_show = value; }
            get { return _c_is_show; }
        }
        /// <summary>
        /// 是否判定
        /// </summary>
        public string C_IS_DECIDE
        {
            set { _c_is_decide = value; }
            get { return _c_is_decide; }
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
        /// 是否同步NC的数据;Y-NC数据；N-PCI数据；
        /// </summary>
        public string C_TB
        {
            set { _c_tb = value; }
            get { return _c_tb; }
        }
        /// <summary>
        /// 数据来源；0系统判定；1手动补入；
        /// </summary>
        public string C_SOURCE
        {
            set { _c_source = value; }
            get { return _c_source; }
        }

        #endregion Model

    }
}

