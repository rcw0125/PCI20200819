using System;
namespace MODEL
{
    /// <summary>
	/// 不锈钢修磨规则
	/// </summary>
	[Serializable]
    public partial class Mod_TPB_BXGXMGZ
    {
        public Mod_TPB_BXGXMGZ()
        { }
        #region Model
        private string _c_id = System.Guid.NewGuid().ToString();
        private string _c_emp_id;
        private DateTime _d_mod_dt = System.DateTime.Now;
        private string _c_stl_grd;
        private string _c_slab_size;
        private string _c_gzlx;
        private decimal? _n_jscn;
        private decimal? _n_lth;
        private decimal? _n_total_cn;
        private string _c_is_bxg = "1";
        private string _c_remark;
        /// <summary>
        /// 主键
        /// </summary>
        public string C_ID
        {
            set { _c_id = value; }
            get { return _c_id; }
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
        /// 钢种
        /// </summary>
        public string C_STL_GRD
        {
            set { _c_stl_grd = value; }
            get { return _c_stl_grd; }
        }
        /// <summary>
        /// 断面
        /// </summary>
        public string C_SLAB_SIZE
        {
            set { _c_slab_size = value; }
            get { return _c_slab_size; }
        }
        /// <summary>
        /// 规则类型A;B;C:E:
        /// </summary>
        public string C_GZLX
        {
            set { _c_gzlx = value; }
            get { return _c_gzlx; }
        }
        /// <summary>
        /// 机时产能
        /// </summary>
        public decimal? N_JSCN
        {
            set { _n_jscn = value; }
            get { return _n_jscn; }
        }
        /// <summary>
        /// 定尺
        /// </summary>
        public decimal? N_LTH
        {
            set { _n_lth = value; }
            get { return _n_lth; }
        }
        /// <summary>
        /// 12小时产能
        /// </summary>
        public decimal? N_TOTAL_CN
        {
            set { _n_total_cn = value; }
            get { return _n_total_cn; }
        }
        /// <summary>
        /// 是否是不锈钢1是0否
        /// </summary>
        public string C_IS_BXG
        {
            set { _c_is_bxg = value; }
            get { return _c_is_bxg; }
        }
        /// <summary>
		/// 备注
		/// </summary>
		public string C_REMARK
        {
            set { _c_remark = value; }
            get { return _c_remark; }
        }
        #endregion Model

    }
}
