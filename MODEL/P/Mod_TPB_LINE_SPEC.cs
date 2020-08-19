using System;
namespace MODEL
{
	/// <summary>
	/// 产线规格对照表 
	/// </summary>
	[Serializable]
	public partial class Mod_TPB_LINE_SPEC
	{
		public Mod_TPB_LINE_SPEC()
		{}
        #region Model
        private string _c_id = "sys_guid";
        private string _c_sta_id;
        private string _c_prod_class;
        private string _c_stl_grd;
        private string _c_spec;
        private string _c_std_code;
        private decimal? _n_level;
        private string _c_remark;
        private decimal _n_status = 1;
        private string _c_emp_id;
        private DateTime _d_mod_dt = Convert.ToDateTime(DateTime.Now);
        private DateTime? _d_start_date = Convert.ToDateTime(DateTime.Now);
        private DateTime? _d_end_date;
        private string _c_prod_name;
        private string _c_prod_kind;
        private string _c_std_mian_id;
        private string _c_sta_code;
        private string _c_sta_desc;
        private string _c_level;

        /// <summary>
        /// 主键
        /// </summary>
        public string C_ID
        {
            set { _c_id = value; }
            get { return _c_id; }
        }
        /// <summary>
        /// 工位外键
        /// </summary>
        public string C_STA_ID
        {
            set { _c_sta_id = value; }
            get { return _c_sta_id; }
        }
        /// <summary>
        /// 生产类别
        /// </summary>
        public string C_PROD_CLASS
        {
            set { _c_prod_class = value; }
            get { return _c_prod_class; }
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
        /// 执行标准
        /// </summary>
        public string C_STD_CODE
        {
            set { _c_std_code = value; }
            get { return _c_std_code; }
        }
        /// <summary>
        /// 优先级
        /// </summary>
        public decimal? N_LEVEL
        {
            set { _n_level = value; }
            get { return _n_level; }
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
        /// 状态0停用1启用
        /// </summary>
        public decimal N_STATUS
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
        /// 启用时间
        /// </summary>
        public DateTime? D_START_DATE
        {
            set { _d_start_date = value; }
            get { return _d_start_date; }
        }
        /// <summary>
        /// 停用时间
        /// </summary>
        public DateTime? D_END_DATE
        {
            set { _d_end_date = value; }
            get { return _d_end_date; }
        }
        /// <summary>
        /// 品名
        /// </summary>
        public string C_PROD_NAME
        {
            set { _c_prod_name = value; }
            get { return _c_prod_name; }
        }
        /// <summary>
        /// 品种
        /// </summary>
        public string C_PROD_KIND
        {
            set { _c_prod_kind = value; }
            get { return _c_prod_kind; }
        }

        /// <summary>
		/// 执行标准主键
		/// </summary>
		public string C_STD_MIAN_ID
        {
            set { _c_std_mian_id = value; }
            get { return _c_std_mian_id; }
        }
        /// <summary>
        /// 工位代码
        /// </summary>
        public string C_STA_CODE
        {
            set { _c_sta_code = value; }
            get { return _c_sta_code; }
        }
        /// <summary>
        /// 工位描述
        /// </summary>
        public string C_STA_DESC
        {
            set { _c_sta_desc = value; }
            get { return _c_sta_desc; }
        }
        /// <summary>
        /// 优先级描述
        /// </summary>
        public string C_LEVEL
        {
            set { _c_level = value; }
            get { return _c_level; }
        }

        #endregion Model

    }
}

