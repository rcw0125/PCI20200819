using System;
namespace MODEL
{
    /// <summary>
    /// 浇次计划表
    /// </summary>
    [Serializable]
    public partial class Mod_TPP_CAST
    {
        public Mod_TPP_CAST()
        { }
        #region Model
        private string _c_id;
        private string _c_cast_no;
        private string _c_cast_ls;
        private decimal _n_cast_wgt = 0;
        private decimal _n_sort = 1;
        private string _c_initialize_item;
        private decimal _n_status = 1;
        private string _c_remark;
        private string _c_emp_id;
        private DateTime _d_mod_dt = Convert.ToDateTime(DateTime.Now);
        private string _c_ccm_id;
        private decimal _n_sfzjc = 0;

        /// <summary>
        /// 主键
        /// </summary>
        public string C_ID
        {
            set { _c_id = value; }
            get { return _c_id; }
        }
        /// <summary>
        /// 浇次号
        /// </summary>
        public string C_CAST_NO
        {
            set { _c_cast_no = value; }
            get { return _c_cast_no; }
        }
        /// <summary>
        /// 浇次炉数
        /// </summary>
        public string C_CAST_LS
        {
            set { _c_cast_ls = value; }
            get { return _c_cast_ls; }
        }
        /// <summary>
        /// 浇次总重量
        /// </summary>
        public decimal N_CAST_WGT
        {
            set { _n_cast_wgt = value; }
            get { return _n_cast_wgt; }
        }
        /// <summary>
        /// 生产顺序
        /// </summary>
        public decimal N_SORT
        {
            set { _n_sort = value; }
            get { return _n_sort; }
        }
        /// <summary>
        /// 订单方案号
        /// </summary>
        public string C_INITIALIZE_ITEM
        {
            set { _c_initialize_item = value; }
            get { return _c_initialize_item; }
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
        /// 维护人
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
        /// 铸机号主键
        /// </summary>
        public string C_CCM_ID
        {
            set { _c_ccm_id = value; }
            get { return _c_ccm_id; }
        }
        /// <summary>
        /// 是否整浇次排完
        /// </summary>
        public decimal N_SFZJC
        {
            set { _n_sfzjc = value; }
            get { return _n_sfzjc; }
        }

        #endregion Model

    }
}

