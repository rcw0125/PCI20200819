using System;
namespace MODEL
{
    /// <summary>
    /// TB_LG_PLAN_EDIT_LOG:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class Mod_TB_LG_PLAN_EDIT_LOG
    {
        public Mod_TB_LG_PLAN_EDIT_LOG()
        { }
        #region Model
        private string _c_id;
        private string _c_stove;
        private string _c_order_id_before;
        private string _c_stl_grd_before;
        private string _c_std_code_before;
        private string _c_slab_size_before;
        private string _c_length_before;
        private string _c_mat_code_before;
        private string _c_zl_desc_before;
        private string _c_lf_desc_before;
        private string _c_rh_desc_before;
        private string _c_cc_desc_before;
        private string _c_order_id_after;
        private string _c_stl_grd_after;
        private string _c_std_code_after;
        private string _c_slab_size_after;
        private string _c_length_after;
        private string _c_mat_code_after;
        private string _c_zl_desc_after;
        private string _c_lf_desc_after;
        private string _c_rh_desc_after;
        private string _c_cc_desc_after;
        private string _c_emp_id;
        private string _c_emp_name;
        private DateTime? _d_mod_dt = DateTime.Now;
        private string _c_reason;
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
        /// 订单号（修改前）
        /// </summary>
        public string C_ORDER_ID_BEFORE
        {
            set { _c_order_id_before = value; }
            get { return _c_order_id_before; }
        }
        /// <summary>
        /// 钢种（修改前）
        /// </summary>
        public string C_STL_GRD_BEFORE
        {
            set { _c_stl_grd_before = value; }
            get { return _c_stl_grd_before; }
        }
        /// <summary>
        /// 执行标准（修改前）
        /// </summary>
        public string C_STD_CODE_BEFORE
        {
            set { _c_std_code_before = value; }
            get { return _c_std_code_before; }
        }
        /// <summary>
        /// 断面（修改前）
        /// </summary>
        public string C_SLAB_SIZE_BEFORE
        {
            set { _c_slab_size_before = value; }
            get { return _c_slab_size_before; }
        }
        /// <summary>
        /// 定尺（修改前）
        /// </summary>
        public string C_LENGTH_BEFORE
        {
            set { _c_length_before = value; }
            get { return _c_length_before; }
        }
        /// <summary>
        /// 物料编码（修改前）
        /// </summary>
        public string C_MAT_CODE_BEFORE
        {
            set { _c_mat_code_before = value; }
            get { return _c_mat_code_before; }
        }
        /// <summary>
        /// 转炉（修改前）
        /// </summary>
        public string C_ZL_DESC_BEFORE
        {
            set { _c_zl_desc_before = value; }
            get { return _c_zl_desc_before; }
        }
        /// <summary>
        /// 精炼（修改前）
        /// </summary>
        public string C_LF_DESC_BEFORE
        {
            set { _c_lf_desc_before = value; }
            get { return _c_lf_desc_before; }
        }
        /// <summary>
        /// 真空（修改前）
        /// </summary>
        public string C_RH_DESC_BEFORE
        {
            set { _c_rh_desc_before = value; }
            get { return _c_rh_desc_before; }
        }
        /// <summary>
        /// 连铸（修改前）
        /// </summary>
        public string C_CC_DESC_BEFORE
        {
            set { _c_cc_desc_before = value; }
            get { return _c_cc_desc_before; }
        }
        /// <summary>
        /// 订单号（修改后）
        /// </summary>
        public string C_ORDER_ID_AFTER
        {
            set { _c_order_id_after = value; }
            get { return _c_order_id_after; }
        }
        /// <summary>
        /// 钢种（修改后）
        /// </summary>
        public string C_STL_GRD_AFTER
        {
            set { _c_stl_grd_after = value; }
            get { return _c_stl_grd_after; }
        }
        /// <summary>
        /// 执行标准（修改后）
        /// </summary>
        public string C_STD_CODE_AFTER
        {
            set { _c_std_code_after = value; }
            get { return _c_std_code_after; }
        }
        /// <summary>
        /// 断面（修改后）
        /// </summary>
        public string C_SLAB_SIZE_AFTER
        {
            set { _c_slab_size_after = value; }
            get { return _c_slab_size_after; }
        }
        /// <summary>
        /// 定尺（修改后）
        /// </summary>
        public string C_LENGTH_AFTER
        {
            set { _c_length_after = value; }
            get { return _c_length_after; }
        }
        /// <summary>
        /// 物料编码（修改后）
        /// </summary>
        public string C_MAT_CODE_AFTER
        {
            set { _c_mat_code_after = value; }
            get { return _c_mat_code_after; }
        }
        /// <summary>
        /// 转炉（修改后）
        /// </summary>
        public string C_ZL_DESC_AFTER
        {
            set { _c_zl_desc_after = value; }
            get { return _c_zl_desc_after; }
        }
        /// <summary>
        /// 精炼（修改后）
        /// </summary>
        public string C_LF_DESC_AFTER
        {
            set { _c_lf_desc_after = value; }
            get { return _c_lf_desc_after; }
        }
        /// <summary>
        /// 真空（修改后）
        /// </summary>
        public string C_RH_DESC_AFTER
        {
            set { _c_rh_desc_after = value; }
            get { return _c_rh_desc_after; }
        }
        /// <summary>
        /// 连铸（修改后）
        /// </summary>
        public string C_CC_DESC_AFTER
        {
            set { _c_cc_desc_after = value; }
            get { return _c_cc_desc_after; }
        }
        /// <summary>
        /// 操作人ID
        /// </summary>
        public string C_EMP_ID
        {
            set { _c_emp_id = value; }
            get { return _c_emp_id; }
        }
        /// <summary>
        /// 操作人
        /// </summary>
        public string C_EMP_NAME
        {
            set { _c_emp_name = value; }
            get { return _c_emp_name; }
        }
        /// <summary>
        /// 操作时间
        /// </summary>
        public DateTime? D_MOD_DT
        {
            set { _d_mod_dt = value; }
            get { return _d_mod_dt; }
        }
        /// <summary>
		/// 修改原因
		/// </summary>
		public string C_REASON
        {
            set { _c_reason = value; }
            get { return _c_reason; }
        }
        #endregion Model

    }
}

