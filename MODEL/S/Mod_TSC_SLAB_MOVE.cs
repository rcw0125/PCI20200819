using System;
namespace MODEL
{
    /// <summary>
    /// 钢坯出入库记录
    /// </summary>
    [Serializable]
    public partial class Mod_TSC_SLAB_MOVE
    {
        public Mod_TSC_SLAB_MOVE()
        { }
        #region Model
        private string _c_id;
        private string _c_move_type;
        private string _c_slab_main_id;
        private string _c_sta_id;
        private string _c_stove;
        private string _c_stl_grd;
        private string _c_spec;
        private decimal? _n_len;
        private string _c_std_code;
        private string _c_mat_code;
        private string _c_mat_name;
        private decimal? _n_wgt;
        private string _c_stock_code;
        private string _c_stock_code_to;
        private string _c_area_code;
        private string _c_kw_code;
        private string _c_flood_code;
        private decimal _n_qua = 1M;
        private DateTime? _d_move_date;
        private string _c_move_group;
        private string _c_move_shift;
        private string _c_move_emp_id;
        private decimal _n_status = 1;
        private string _c_remark;
        private string _c_zkdh;
        private string _c_zkdhid;
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
        /// N待入库;DZ待轧;NP待开坯;R入炉;C出炉;EX消耗;M调拨中;E入库;DX待修磨;
        /// </summary>
        public string C_MOVE_TYPE
        {
            set { _c_move_type = value; }
            get { return _c_move_type; }
        }
        /// <summary>
        /// TSC_SLAB_MAIN主键
        /// </summary>
        public string C_SLAB_MAIN_ID
        {
            set { _c_slab_main_id = value; }
            get { return _c_slab_main_id; }
        }
        /// <summary>
        /// 铸机
        /// </summary>
        public string C_STA_ID
        {
            set { _c_sta_id = value; }
            get { return _c_sta_id; }
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
        /// 长度 mm
        /// </summary>
        public decimal? N_LEN
        {
            set { _n_len = value; }
            get { return _n_len; }
        }
        /// <summary>
        /// 执行标准
        /// </summary>
        public string C_STD_CODE
        {
            set { _c_std_code = value; }
            get { return _c_std_code; }
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
        /// <summary>
        /// 单重
        /// </summary>
        public decimal? N_WGT
        {
            set { _n_wgt = value; }
            get { return _n_wgt; }
        }
        /// <summary>
        /// 原仓库
        /// </summary>
        public string C_STOCK_CODE
        {
            set { _c_stock_code = value; }
            get { return _c_stock_code; }
        }
        /// <summary>
        /// 目标仓库
        /// </summary>
        public string C_STOCK_CODE_TO
        {
            set { _c_stock_code_to = value; }
            get { return _c_stock_code_to; }
        }
        /// <summary>
        /// 仓库区域代码
        /// </summary>
        public string C_AREA_CODE
        {
            set { _c_area_code = value; }
            get { return _c_area_code; }
        }
        /// <summary>
        /// 仓库库位代码
        /// </summary>
        public string C_KW_CODE
        {
            set { _c_kw_code = value; }
            get { return _c_kw_code; }
        }
        /// <summary>
        /// 层代码
        /// </summary>
        public string C_FLOOD_CODE
        {
            set { _c_flood_code = value; }
            get { return _c_flood_code; }
        }
        /// <summary>
        /// 支数
        /// </summary>
        public decimal N_QUA
        {
            set { _n_qua = value; }
            get { return _n_qua; }
        }
        /// <summary>
        /// 操作时间
        /// </summary>
        public DateTime? D_MOVE_DATE
        {
            set { _d_move_date = value; }
            get { return _d_move_date; }
        }
        /// <summary>
        /// 操作班组
        /// </summary>
        public string C_MOVE_GROUP
        {
            set { _c_move_group = value; }
            get { return _c_move_group; }
        }
        /// <summary>
        /// 操作班次
        /// </summary>
        public string C_MOVE_SHIFT
        {
            set { _c_move_shift = value; }
            get { return _c_move_shift; }
        }
        /// <summary>
        /// 操作人
        /// </summary>
        public string C_MOVE_EMP_ID
        {
            set { _c_move_emp_id = value; }
            get { return _c_move_emp_id; }
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
        /// 转库单号
        /// </summary>
        public string C_ZKDH
        {
            set { _c_zkdh = value; }
            get { return _c_zkdh; }
        }
        /// <summary>
        /// 转库单号主键
        /// </summary>
        public string C_ZKDHID
        {
            set { _c_zkdhid = value; }
            get { return _c_zkdhid; }
        }
        /// <summary>
        /// 开坯号
        /// </summary>
        public string C_BATCH_NO
        {
            set { _c_batch_no = value; }
            get { return _c_batch_no; }
        }
        #endregion Model

    }
}

