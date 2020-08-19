using System;
namespace MODEL
{
    /// <summary>
    /// 工艺路线
    /// </summary>
    [Serializable]
    public partial class Mod_TQB_ROUTE
    {
        public Mod_TQB_ROUTE()
        { }
        #region Model
        private string _c_id;
        private string _c_std_id;
        private string _c_route_type;
        private string _c_route_desc;
        private decimal _n_status = 1;
        private string _c_remark;
        private string _c_emp_id;
        private DateTime _d_mod_dt = Convert.ToDateTime(DateTime.Now);
        private string _c_stl_grd;
        private string _c_std_code;
        private string _c_is_bxg;
        private string _c_custfile_name;
        private string _c_spec;
        /// <summary>
        /// 主键
        /// </summary>
        public string C_ID
        {
            set { _c_id = value; }
            get { return _c_id; }
        }
        /// <summary>
        /// 执行标准主键
        /// </summary>
        public string C_STD_ID
        {
            set { _c_std_id = value; }
            get { return _c_std_id; }
        }
        /// <summary>
        /// 工艺路线类型
        /// </summary>
        public string C_ROUTE_TYPE
        {
            set { _c_route_type = value; }
            get { return _c_route_type; }
        }
        /// <summary>
        /// 工艺路线描述
        /// </summary>
        public string C_ROUTE_DESC
        {
            set { _c_route_desc = value; }
            get { return _c_route_desc; }
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
        /// 钢种
        /// </summary>
        public string C_STL_GRD
        {
            set { _c_stl_grd = value; }
            get { return _c_stl_grd; }
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
        /// 是否为不锈钢
        /// </summary>
        public string C_IS_BXG
        {
            set { _c_is_bxg = value; }
            get { return _c_is_bxg; }
        }
        /// <summary>
		/// 客商名称
		/// </summary>
		public string C_CUSTFILE_NAME
        {
            set { _c_custfile_name = value; }
            get { return _c_custfile_name; }
        }
        /// <summary>
        /// 规格
        /// </summary>
        public string C_SPEC
        {
            set { _c_spec = value; }
            get { return _c_spec; }
        }
        #endregion Model

    }
}

