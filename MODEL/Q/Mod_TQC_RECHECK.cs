using System;
namespace MODEL
{
    /// <summary>
    /// 库检申请
    /// </summary>
    [Serializable]
    public partial class Mod_TQC_RECHECK
    {
        public Mod_TQC_RECHECK()
        { }
        #region Model
        private string _c_id;
        private string _c_physics_code;
        private string _c_physics_name;
        private string _c_character_id;
        private string _c_stove;
        private string _c_batch_no;
        private string _c_stl_grd;
        private string _c_spec;
        private string _c_std_code;
        private string _c_item_name;
        private string _c_shift;
        private string _c_group;
        private string _c_sta_id;
        private string _c_disposal;
        private decimal _n_status = 1;
        private string _c_remark;
        private string _c_emp_id;
        private DateTime _d_mod_dt = Convert.ToDateTime(DateTime.Now);
        private decimal? _n_number;
        private decimal _n_is_qr = 0;
        private string _c_qr_user_id;
        private DateTime? _d_qr_mod;
        private string _c_tick_no;
        private decimal? _n_recheck;
        private string _c_zz_user_id;
        private DateTime? _d_zz_mod ;
        private string _c_zzjg;
        /// <summary>
        /// 主键
        /// </summary>
        public string C_ID
        {
            set { _c_id = value; }
            get { return _c_id; }
        }
        /// <summary>
        /// 物理检验分组代码
        /// </summary>
        public string C_PHYSICS_CODE
        {
            set { _c_physics_code = value; }
            get { return _c_physics_code; }
        }
        /// <summary>
        /// 物理检验分组名称
        /// </summary>
        public string C_PHYSICS_NAME
        {
            set { _c_physics_name = value; }
            get { return _c_physics_name; }
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
        /// 项目名称
        /// </summary>
        public string C_ITEM_NAME
        {
            set { _c_item_name = value; }
            get { return _c_item_name; }
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
        /// 生产工位（外键）
        /// </summary>
        public string C_STA_ID
        {
            set { _c_sta_id = value; }
            get { return _c_sta_id; }
        }
        /// <summary>
        /// 处置意见
        /// </summary>
        public string C_DISPOSAL
        {
            set { _c_disposal = value; }
            get { return _c_disposal; }
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
        /// 样品数量
        /// </summary>
        public decimal? N_NUMBER
        {
            set { _n_number = value; }
            get { return _n_number; }
        }
        /// <summary>
        /// 确认状态   2-确认；1-收料；0-未确认；
        /// </summary>
        public decimal N_IS_QR
        {
            set { _n_is_qr = value; }
            get { return _n_is_qr; }
        }
        /// <summary>
        /// 收样人员
        /// </summary>
        public string C_QR_USER_ID
        {
            set { _c_qr_user_id = value; }
            get { return _c_qr_user_id; }
        }
        /// <summary>
        /// 收样时间
        /// </summary>
        public DateTime? D_QR_MOD
        {
            set { _d_qr_mod = value; }
            get { return _d_qr_mod; }
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
        /// 复检次数
        /// </summary>
        public decimal? N_RECHECK
        {
            set { _n_recheck = value; }
            get { return _n_recheck; }
        }
        /// <summary>
        /// 最终确认人员
        /// </summary>
        public string C_ZZ_USER_ID
        {
            set { _c_zz_user_id = value; }
            get { return _c_zz_user_id; }
        }
        /// <summary>
        /// 最终确认时间
        /// </summary>
        public DateTime? D_ZZ_MOD
        {
            set { _d_zz_mod = value; }
            get { return _d_zz_mod; }
        }
        /// <summary>
        /// 最终结果
        /// </summary>
        public string C_ZZJG
        {
            set { _c_zzjg = value; }
            get { return _c_zzjg; }
        }
        #endregion Model

    }
}

