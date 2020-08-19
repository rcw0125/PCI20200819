using System;
namespace MODEL
{
    /// <summary>
    /// 线材改判记录
    /// </summary>
    [Serializable]
    public partial class Mod_TQC_ROLL_COMMUTE
    {
        public Mod_TQC_ROLL_COMMUTE()
        { }
        #region Model
        private string _c_id = "sys_guid";
        private string _c_roll_id;
        private string _c_sta_id;
        private string _c_sta_desc;
        private string _c_stove;
        private string _c_batch_no;
        private string _c_tick_no;
        private decimal? _n_wgt;
        private string _c_stl_grd_before;
        private string _c_std_code_before;
        private string _c_spec_before;
        private string _c_mat_code_before;
        private string _c_mat_desc_before;
        private DateTime? _d_commute_date;
        private string _c_stl_grd_after;
        private string _c_std_code_after;
        private string _c_spec_after;
        private string _c_mat_code_after;
        private string _c_mat_desc_after;
        private string _c_reason_depmt_id;
        private string _c_reason_depmt_desc;
        private string _c_gp_type;
        private string _c_scutcheon;
        private decimal _n_status = 1;
        private string _c_remark;
        private string _c_emp_id;
        private DateTime _d_mod_dt = Convert.ToDateTime(DateTime.Now);
        private string _c_master_id;
        private string _c_gp_before_id;
        private string _c_gp_after_id;
        private string _c_zyx1_before;
        private string _c_zyx2_before;
        private string _c_zyx1_after;
        private string _c_zyx2_after;
        private string _c_judge_lev_bp_before;
        private string _c_judge_lev_bp_after;
        private string _c_bzyq_before;
        private string _c_bzyq_after;
        private string _c_commute_reason;
        /// <summary>
        /// 主键
        /// </summary>
        public string C_ID
        {
            set { _c_id = value; }
            get { return _c_id; }
        }
        /// <summary>
        /// 线材实绩表外键
        /// </summary>
        public string C_ROLL_ID
        {
            set { _c_roll_id = value; }
            get { return _c_roll_id; }
        }
        /// <summary>
        /// 工位代码
        /// </summary>
        public string C_STA_ID
        {
            set { _c_sta_id = value; }
            get { return _c_sta_id; }
        }
        /// <summary>
        /// 包装要求
        /// </summary>
        public string C_STA_DESC
        {
            set { _c_sta_desc = value; }
            get { return _c_sta_desc; }
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
        /// 勾号
        /// </summary>
        public string C_TICK_NO
        {
            set { _c_tick_no = value; }
            get { return _c_tick_no; }
        }
        /// <summary>
        /// 单重
        /// </summary>
        public decimal? N_WGT
        {
            set { _n_wgt = value; }
            get { return _n_wgt; }
        }
        /// <summary>
        /// 改判前钢种
        /// </summary>
        public string C_STL_GRD_BEFORE
        {
            set { _c_stl_grd_before = value; }
            get { return _c_stl_grd_before; }
        }
        /// <summary>
        /// 改判前标准
        /// </summary>
        public string C_STD_CODE_BEFORE
        {
            set { _c_std_code_before = value; }
            get { return _c_std_code_before; }
        }
        /// <summary>
        /// 改判前规格
        /// </summary>
        public string C_SPEC_BEFORE
        {
            set { _c_spec_before = value; }
            get { return _c_spec_before; }
        }
        /// <summary>
        /// 改判前物料编码
        /// </summary>
        public string C_MAT_CODE_BEFORE
        {
            set { _c_mat_code_before = value; }
            get { return _c_mat_code_before; }
        }
        /// <summary>
        /// 改判前物料描述
        /// </summary>
        public string C_MAT_DESC_BEFORE
        {
            set { _c_mat_desc_before = value; }
            get { return _c_mat_desc_before; }
        }
        /// <summary>
        /// 改判时间
        /// </summary>
        public DateTime? D_COMMUTE_DATE
        {
            set { _d_commute_date = value; }
            get { return _d_commute_date; }
        }
        /// <summary>
        /// 改判后钢种
        /// </summary>
        public string C_STL_GRD_AFTER
        {
            set { _c_stl_grd_after = value; }
            get { return _c_stl_grd_after; }
        }
        /// <summary>
        /// 改判后标准
        /// </summary>
        public string C_STD_CODE_AFTER
        {
            set { _c_std_code_after = value; }
            get { return _c_std_code_after; }
        }
        /// <summary>
        /// 改判前规格
        /// </summary>
        public string C_SPEC_AFTER
        {
            set { _c_spec_after = value; }
            get { return _c_spec_after; }
        }
        /// <summary>
        /// 改判后物料编码
        /// </summary>
        public string C_MAT_CODE_AFTER
        {
            set { _c_mat_code_after = value; }
            get { return _c_mat_code_after; }
        }
        /// <summary>
        /// 改判后物料描述
        /// </summary>
        public string C_MAT_DESC_AFTER
        {
            set { _c_mat_desc_after = value; }
            get { return _c_mat_desc_after; }
        }
        /// <summary>
        /// 责任单位代码
        /// </summary>
        public string C_REASON_DEPMT_ID
        {
            set { _c_reason_depmt_id = value; }
            get { return _c_reason_depmt_id; }
        }
        /// <summary>
        /// 责任单位描述
        /// </summary>
        public string C_REASON_DEPMT_DESC
        {
            set { _c_reason_depmt_desc = value; }
            get { return _c_reason_depmt_desc; }
        }
        /// <summary>
        /// 改判类型
        /// </summary>
        public string C_GP_TYPE
        {
            set { _c_gp_type = value; }
            get { return _c_gp_type; }
        }
        /// <summary>
        /// 标牌类型 白牌/黄牌/红牌
        /// </summary>
        public string C_SCUTCHEON
        {
            set { _c_scutcheon = value; }
            get { return _c_scutcheon; }
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
        /// 改判人
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
        /// 实绩主键
        /// </summary>
        public string C_MASTER_ID
        {
            set { _c_master_id = value; }
            get { return _c_master_id; }
        }
        /// <summary>
        /// 改变前主键
        /// </summary>
        public string C_GP_BEFORE_ID
        {
            set { _c_gp_before_id = value; }
            get { return _c_gp_before_id; }
        }
        /// <summary>
        /// 改判后主键
        /// </summary>
        public string C_GP_AFTER_ID
        {
            set { _c_gp_after_id = value; }
            get { return _c_gp_after_id; }
        }
        /// <summary>
        /// 改判前自由项1
        /// </summary>
        public string C_ZYX1_BEFORE
        {
            set { _c_zyx1_before = value; }
            get { return _c_zyx1_before; }
        }
        /// <summary>
        /// 改判前自由项2
        /// </summary>
        public string C_ZYX2_BEFORE
        {
            set { _c_zyx2_before = value; }
            get { return _c_zyx2_before; }
        }
        /// <summary>
        /// 改判后自由项1
        /// </summary>
        public string C_ZYX1_AFTER
        {
            set { _c_zyx1_after = value; }
            get { return _c_zyx1_after; }
        }
        /// <summary>
        /// 改判后自由项2
        /// </summary>
        public string C_ZYX2_AFTER
        {
            set { _c_zyx2_after = value; }
            get { return _c_zyx2_after; }
        }
        /// <summary>
        /// 改判前判定等级
        /// </summary>
        public string C_JUDGE_LEV_BP_BEFORE
        {
            set { _c_judge_lev_bp_before = value; }
            get { return _c_judge_lev_bp_before; }
        }
        /// <summary>
        /// 改判后判定等级
        /// </summary>
        public string C_JUDGE_LEV_BP_AFTER
        {
            set { _c_judge_lev_bp_after = value; }
            get { return _c_judge_lev_bp_after; }
        }
        /// <summary>
        /// 改判前包装要求
        /// </summary>
        public string C_BZYQ_BEFORE
        {
            set { _c_bzyq_before = value; }
            get { return _c_bzyq_before; }
        }
        /// <summary>
        /// 改判后包装要求
        /// </summary>
        public string C_BZYQ_AFTER
        {
            set { _c_bzyq_after = value; }
            get { return _c_bzyq_after; }
        }
        /// <summary>
        /// 改判原因
        /// </summary>
        public string C_COMMUTE_REASON
        {
            set { _c_commute_reason = value; }
            get { return _c_commute_reason; }
        }
        #endregion Model

    }
}

