using System;
namespace MODEL
{
    /// <summary>
    /// 方案炼钢产线
    /// </summary>
    [Serializable]
    public partial class Mod_TPP_INITIALIZE_LINE
    {
        public Mod_TPP_INITIALIZE_LINE()
        { }
        #region Model
        private string _c_id;
        private string _c_initialize_item_id;
        private string _c_remark;
        private string _c_emp_id;
        private DateTime _d_mod_dt = Convert.ToDateTime(DateTime.Now);
        private decimal? _n_capacity = 0;
        private decimal? _n_wgt = 0;
        private string _c_zl_sta_id;
        private string _c_jl_sta_id;
        private string _c_zk_sta_id;
        private string _c_lz_sta_id;
        private string _c_zl_sta_desc;
        private string _c_jl_sta_desc;
        private string _c_zk_sta_desc;
        private string _c_lz_sta_desc;
        /// <summary>
        /// 主键
        /// </summary>
        public string C_ID
        {
            set { _c_id = value; }
            get { return _c_id; }
        }
        /// <summary>
        /// 订单方案表主键
        /// </summary>
        public string C_INITIALIZE_ITEM_ID
        {
            set { _c_initialize_item_id = value; }
            get { return _c_initialize_item_id; }
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
        /// 操作人
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
        /// 产能
        /// </summary>
        public decimal? N_CAPACITY
        {
            set { _n_capacity = value; }
            get { return _n_capacity; }
        }
        /// <summary>
        /// 排产量
        /// </summary>
        public decimal? N_WGT
        {
            set { _n_wgt = value; }
            get { return _n_wgt; }
        }
        /// <summary>
        /// 转炉工位主键
        /// </summary>
        public string C_ZL_STA_ID
        {
            set { _c_zl_sta_id = value; }
            get { return _c_zl_sta_id; }
        }
        /// <summary>
        /// 精炼工位主键
        /// </summary>
        public string C_JL_STA_ID
        {
            set { _c_jl_sta_id = value; }
            get { return _c_jl_sta_id; }
        }
        /// <summary>
        /// 真空工位主键
        /// </summary>
        public string C_ZK_STA_ID
        {
            set { _c_zk_sta_id = value; }
            get { return _c_zk_sta_id; }
        }
        /// <summary>
        /// 连铸工位主键
        /// </summary>
        public string C_LZ_STA_ID
        {
            set { _c_lz_sta_id = value; }
            get { return _c_lz_sta_id; }
        }
        /// <summary>
        /// 转炉工位描述
        /// </summary>
        public string C_ZL_STA_DESC
        {
            set { _c_zl_sta_desc = value; }
            get { return _c_zl_sta_desc; }
        }
        /// <summary>
        /// 精炼工位描述
        /// </summary>
        public string C_JL_STA_DESC
        {
            set { _c_jl_sta_desc = value; }
            get { return _c_jl_sta_desc; }
        }
        /// <summary>
        /// 真空工位描述
        /// </summary>
        public string C_ZK_STA_DESC
        {
            set { _c_zk_sta_desc = value; }
            get { return _c_zk_sta_desc; }
        }
        /// <summary>
        /// 连铸工位描述
        /// </summary>
        public string C_LZ_STA_DESC
        {
            set { _c_lz_sta_desc = value; }
            get { return _c_lz_sta_desc; }
        }
        #endregion Model

    }
}
