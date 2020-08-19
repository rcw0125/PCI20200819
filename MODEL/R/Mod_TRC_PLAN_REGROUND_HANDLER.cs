using System;
namespace MODEL
{

    /// <summary>
    /// 修磨操作
    /// </summary>
    [Serializable]
    public partial class Mod_TRC_PLAN_REGROUND_HANDLER
    {
        public Mod_TRC_PLAN_REGROUND_HANDLER()
        { }
        #region Model
        private string _c_id = "sys_guid";
        private string _c_reground_id;
        private string _c_reground_item_id;
        private string _c_emp_name;
        private DateTime _d_dt = Convert.ToDateTime(DateTime.Now);
        private string _c_sta_id;
        private string _c_xmbz;
        private decimal? _n_total_qua;
        private decimal? _n_qua;
        private string _c_batch_no;
        private string _c_remark;
        private string _c_quality;
        private string _c_hw;
        private string _c_hg;
        private string _c_cause;
        private decimal? _n_not_qua;
        private string _c_shift;
        private string _c_group;
        private decimal? _n_status;
        private decimal? _step;
        private string _c_stepname;
        private string _c_grinding_wheel;

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
        public string C_REGROUND_ID
        {
            set { _c_reground_id = value; }
            get { return _c_reground_id; }
        }
        /// <summary>
        /// 子表id
        /// </summary>
        public string C_REGROUND_ITEM_ID
        {
            set { _c_reground_item_id = value; }
            get { return _c_reground_item_id; }
        }
        /// <summary>
        /// 执行人
        /// </summary>
        public string C_EMP_NAME
        {
            set { _c_emp_name = value; }
            get { return _c_emp_name; }
        }
        /// <summary>
        /// 日期
        /// </summary>
        public DateTime D_DT
        {
            set { _d_dt = value; }
            get { return _d_dt; }
        }
        /// <summary>
        /// 工位
        /// </summary>
        public string C_STA_ID
        {
            set { _c_sta_id = value; }
            get { return _c_sta_id; }
        }
        /// <summary>
        /// (修磨|抛丸探伤)标准
        /// </summary>
        public string C_XMBZ
        {
            set { _c_xmbz = value; }
            get { return _c_xmbz; }
        }
        /// <summary>
        /// 总支数
        /// </summary>
        public decimal? N_TOTAL_QUA
        {
            set { _n_total_qua = value; }
            get { return _n_total_qua; }
        }
        /// <summary>
        /// 处理支数
        /// </summary>
        public decimal? N_QUA
        {
            set { _n_qua = value; }
            get { return _n_qua; }
        }
        /// <summary>
        /// 批次号
        /// </summary>
        public string C_BATCH_NO
        {
            set { _c_batch_no = value; }
            get { return _c_batch_no; }
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
        /// 质量
        /// </summary>
        public string C_QUALITY
        {
            set { _c_quality = value; }
            get { return _c_quality; }
        }
        /// <summary>
        /// 货位
        /// </summary>
        public string C_HW
        {
            set { _c_hw = value; }
            get { return _c_hw; }
        }
        /// <summary>
        /// 货管
        /// </summary>
        public string C_HG
        {
            set { _c_hg = value; }
            get { return _c_hg; }
        }
        /// <summary>
        /// 原因
        /// </summary>
        public string C_CAUSE
        {
            set { _c_cause = value; }
            get { return _c_cause; }
        }
        /// <summary>
        /// 未处理支数
        /// </summary>
        public decimal? N_NOT_QUA
        {
            set { _n_not_qua = value; }
            get { return _n_not_qua; }
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
        ///状态1修磨2探伤
        /// </summary>
        public decimal? N_STATUS
        {
            set { _n_status = value; }
            get { return _n_status; }
        }

        /// <summary>
        /// 步骤
        /// </summary>
        public decimal? N_STEP
        {
            set { _step = value; }
            get { return _step; }
        }

        /// <summary>
        /// 步骤名称
        /// </summary>
        public string C_STEPNAME
        {
            set { _c_stepname = value; }
            get { return _c_stepname; }
        }

        /// <summary>
        /// 砂轮
        /// </summary>
        public string C_GRINDING_WHEEL
        {
            set { _c_grinding_wheel = value; }
            get { return _c_grinding_wheel; }
        }



        #endregion Model

    }
}
