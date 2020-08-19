using System;
namespace MODEL
{
    /// <summary>
    /// 铁水标准信息主表
    /// </summary>
    [Serializable]
    public partial class Mod_TQB_TSBZ_MAIN
    {
        public Mod_TQB_TSBZ_MAIN()
        { }
        #region Model
        private string _c_id = "sys_guid";
        private string _c_xy_code;
        private string _c_xy_desc;
        private string _c_stl_grd;
        private string _c_prod_name;
        private string _c_prod_kind;
        private string _c_route;
        private string _c_edition;
        private decimal _n_is_check = 1;
        private decimal _n_status = 1;
        private string _c_remark;
        private string _c_emp_id;
        private DateTime _d_mod_dt = Convert.ToDateTime(DateTime.Now);
        private string _c_is_often;
        private string _c_remark_jb;
        private decimal? _n_edit_num = 1;
        /// <summary>
        /// 主键
        /// </summary>
        public string C_ID
        {
            set { _c_id = value; }
            get { return _c_id; }
        }
        /// <summary>
        /// 协议号
        /// </summary>
        public string C_XY_CODE
        {
            set { _c_xy_code = value; }
            get { return _c_xy_code; }
        }
        /// <summary>
        /// 协议描述
        /// </summary>
        public string C_XY_DESC
        {
            set { _c_xy_desc = value; }
            get { return _c_xy_desc; }
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
        /// 类别
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
        /// 工艺路线（转炉/电炉）
        /// </summary>
        public string C_ROUTE
        {
            set { _c_route = value; }
            get { return _c_route; }
        }
        /// <summary>
        /// 版本号
        /// </summary>
        public string C_EDITION
        {
            set { _c_edition = value; }
            get { return _c_edition; }
        }
        /// <summary>
        /// 是否审核   1-已审核；0-未审核
        /// </summary>
        public decimal N_IS_CHECK
        {
            set { _n_is_check = value; }
            get { return _n_is_check; }
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
        /// 是否常用 1常用 2不常用
        /// </summary>
        public string C_IS_OFTEN
        {
            set { _c_is_often = value; }
            get { return _c_is_often; }
        }
        /// <summary>
        /// 备注级别
        /// </summary>
        public string C_REMARK_JB
        {
            set { _c_remark_jb = value; }
            get { return _c_remark_jb; }
        }
        /// <summary>
        /// 修改次数
        /// </summary>
        public decimal? N_EDIT_NUM
        {
            set { _n_edit_num = value; }
            get { return _n_edit_num; }
        }
        #endregion Model

    }
}