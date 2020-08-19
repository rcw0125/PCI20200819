using System;
namespace MODEL
{
    /// <summary>
	/// 钢坯记录表
	/// </summary>
	[Serializable]
    public partial class Mod_TRC_SLABWH_LOG
    {
        public Mod_TRC_SLABWH_LOG()
        { }
        #region Model
        private string _c_id = "sys_guid";
        private string _c_slab_main_id;
        private string _c_move_type;
        private string _c_shift;
        private string _c_group;
        private string _c_mat_code;
        private string _c_mat_desc;
        private string _c_slabwh_code_before;
        private string _c_slabwh_area_code_before;
        private string _c_slabwh_loc_code_before;
        private string _c_floor_before;
        private DateTime? _d_storage_dt;
        private string _c_slabwh_code_after;
        private string _c_slabwh_area_code_after;
        private string _c_floor_after;
        private string _c_sale_area;
        private string _c_transportation;
        private string _c_emp_id;
        private DateTime _d_mod_dt = Convert.ToDateTime(DateTime.Now);
        private decimal _n_status = 1 ;
		private string _c_slabwh_loc_code_after;
        private decimal? _n_order;
        private DateTime? _d_esc_date;
        private DateTime? _d_lsc_date;
        private string _c_coolpit_code;
        private string _c_coolpit_area_code;
        private string _c_coolpit_loc_code;
        private string _c_coolpit;
        /// <summary>
        /// 主键
        /// </summary>
        public string C_ID
        {
            set { _c_id = value; }
            get { return _c_id; }
        }
        /// <summary>
        /// 钢坯表主键
        /// </summary>
        public string C_SLAB_MAIN_ID
        {
            set { _c_slab_main_id = value; }
            get { return _c_slab_main_id; }
        }
        /// <summary>
        /// 钢坯状态
        /// </summary>
        public string C_MOVE_TYPE
        {
            set { _c_move_type = value; }
            get { return _c_move_type; }
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
        /// 物料编码
        /// </summary>
        public string C_MAT_CODE
        {
            set { _c_mat_code = value; }
            get { return _c_mat_code; }
        }
        /// <summary>
        /// 物料描述
        /// </summary>
        public string C_MAT_DESC
        {
            set { _c_mat_desc = value; }
            get { return _c_mat_desc; }
        }
        /// <summary>
        /// 钢坯库编码
        /// </summary>
        public string C_SLABWH_CODE_BEFORE
        {
            set { _c_slabwh_code_before = value; }
            get { return _c_slabwh_code_before; }
        }
        /// <summary>
        /// 钢坯区域编码
        /// </summary>
        public string C_SLABWH_AREA_CODE_BEFORE
        {
            set { _c_slabwh_area_code_before = value; }
            get { return _c_slabwh_area_code_before; }
        }
        /// <summary>
        /// 钢坯库位编号
        /// </summary>
        public string C_SLABWH_LOC_CODE_BEFORE
        {
            set { _c_slabwh_loc_code_before = value; }
            get { return _c_slabwh_loc_code_before; }
        }
        /// <summary>
        /// 钢坯层
        /// </summary>
        public string C_FLOOR_BEFORE
        {
            set { _c_floor_before = value; }
            get { return _c_floor_before; }
        }
        /// <summary>
        /// 转库时间
        /// </summary>
        public DateTime? D_STORAGE_DT
        {
            set { _d_storage_dt = value; }
            get { return _d_storage_dt; }
        }
        /// <summary>
        /// 转库后钢坯仓库编码
        /// </summary>
        public string C_SLABWH_CODE_AFTER
        {
            set { _c_slabwh_code_after = value; }
            get { return _c_slabwh_code_after; }
        }
        /// <summary>
        /// 转库后钢坯区域编码
        /// </summary>
        public string C_SLABWH_AREA_CODE_AFTER
        {
            set { _c_slabwh_area_code_after = value; }
            get { return _c_slabwh_area_code_after; }
        }
        /// <summary>
        /// 转库后层
        /// </summary>
        public string C_FLOOR_AFTER
        {
            set { _c_floor_after = value; }
            get { return _c_floor_after; }
        }
        /// <summary>
        /// 销售区域
        /// </summary>
        public string C_SALE_AREA
        {
            set { _c_sale_area = value; }
            get { return _c_sale_area; }
        }
        /// <summary>
        /// 运输方式
        /// </summary>
        public string C_TRANSPORTATION
        {
            set { _c_transportation = value; }
            get { return _c_transportation; }
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
        /// 状态0停用1启用
        /// </summary>
        public decimal N_STATUS
        {
            set { _n_status = value; }
            get { return _n_status; }
        }
        /// <summary>
        /// 转库后库位编号
        /// </summary>
        public string C_SLABWH_LOC_CODE_AFTER
        {
            set { _c_slabwh_loc_code_after = value; }
            get { return _c_slabwh_loc_code_after; }
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
        /// 入坑时间
        /// </summary>
        public DateTime? D_ESC_DATE
        {
            set { _d_esc_date = value; }
            get { return _d_esc_date; }
        }
        /// <summary>
        /// 出坑时间
        /// </summary>
        public DateTime? D_LSC_DATE
        {
            set { _d_lsc_date = value; }
            get { return _d_lsc_date; }
        }
        /// <summary>
        /// 缓冷坑仓库编码
        /// </summary>
        public string C_COOLPIT_CODE
        {
            set { _c_coolpit_code = value; }
            get { return _c_coolpit_code; }
        }
        /// <summary>
        /// 缓冷坑区域编码
        /// </summary>
        public string C_COOLPIT_AREA_CODE
        {
            set { _c_coolpit_area_code = value; }
            get { return _c_coolpit_area_code; }
        }
        /// <summary>
        /// 缓冷坑库位编号
        /// </summary>
        public string C_COOLPIT_LOC_CODE
        {
            set { _c_coolpit_loc_code = value; }
            get { return _c_coolpit_loc_code; }
        }
        /// <summary>
        /// 缓冷坑层
        /// </summary>
        public string C_COOLPIT
        {
            set { _c_coolpit = value; }
            get { return _c_coolpit; }
        }
        #endregion Model

    }
}
