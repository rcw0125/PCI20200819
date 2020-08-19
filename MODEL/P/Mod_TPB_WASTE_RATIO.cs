using System;
namespace MODEL
{
    /// <summary>
    /// 转炉装料铁水与废钢比例
    /// </summary>
    [Serializable]
    public partial class Mod_TPB_WASTE_RATIO
    {
        public Mod_TPB_WASTE_RATIO()
        { }
        #region Model
        private string _c_id = "sys_guid";
        private string _c_sta_id;
        private decimal? _n_wgt;
        private decimal? _n_ts_wgt;
        private decimal? _n_status = 1;
        private string _c_emp_id;
        private DateTime _d_mod_dt;
        private string _c_remark;
        private decimal? _n_fg_wgt;
        private decimal? _n_cg_wgt;
        private string _c_sta_name;
        /// <summary>
        /// 主键
        /// </summary>
        public string C_ID
        {
            set { _c_id = value; }
            get { return _c_id; }
        }
        /// <summary>
        /// 工位（转炉）
        /// </summary>
        public string C_STA_ID
        {
            set { _c_sta_id = value; }
            get { return _c_sta_id; }
        }
        /// <summary>
        /// 每炉重量
        /// </summary>
        public decimal? N_WGT
        {
            set { _n_wgt = value; }
            get { return _n_wgt; }
        }
        /// <summary>
        /// 铁水重量
        /// </summary>
        public decimal? N_TS_WGT
        {
            set { _n_ts_wgt = value; }
            get { return _n_ts_wgt; }
        }
        /// <summary>
        /// 状态
        /// </summary>
        public decimal? N_STATUS
        {
            set { _n_status = value; }
            get { return _n_status; }
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
        /// 备注
        /// </summary>
        public string C_REMARK
        {
            set { _c_remark = value; }
            get { return _c_remark; }
        }
        /// <summary>
        /// 废钢重量
        /// </summary>
        public decimal? N_FG_WGT
        {
            set { _n_fg_wgt = value; }
            get { return _n_fg_wgt; }
        }
        /// <summary>
        /// 出钢重量
        /// </summary>
        public decimal? N_CG_WGT
        {
            set { _n_cg_wgt = value; }
            get { return _n_cg_wgt; }
        }
        /// <summary>
        /// 工位名称
        /// </summary>
        public string C_STA_NAME
        {
            set { _c_sta_name = value; }
            get { return _c_sta_name; }
        }
        #endregion Model

    }
}

