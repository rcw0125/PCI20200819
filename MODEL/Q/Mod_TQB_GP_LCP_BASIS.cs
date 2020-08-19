using System;
namespace MODEL
{
    /// <summary>
    /// 联产品改判依据
    /// </summary>
    [Serializable]
    public partial class Mod_TQB_GP_LCP_BASIS
    {
        public Mod_TQB_GP_LCP_BASIS()
        { }
        #region Model
        private string _c_id;
        private string _c_mat_code_plan;
        private string _c_mat_code_gp;
        private decimal _n_status = 1;
        private string _c_remark;
        private string _c_emp_id;
        private DateTime _d_mod_dt = Convert.ToDateTime(DateTime.Now);
        private decimal? _n_sort;
        private string _c_stl_grd;
        private string _c_std_code;
        /// <summary>
        /// 主键
        /// </summary>
        public string C_ID
        {
            set { _c_id = value; }
            get { return _c_id; }
        }
        /// <summary>
        /// 计划物料
        /// </summary>
        public string C_MAT_CODE_PLAN
        {
            set { _c_mat_code_plan = value; }
            get { return _c_mat_code_plan; }
        }
        /// <summary>
        /// 改判物料
        /// </summary>
        public string C_MAT_CODE_GP
        {
            set { _c_mat_code_gp = value; }
            get { return _c_mat_code_gp; }
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
        /// 顺序
        /// </summary>
        public decimal? N_SORT
        {
            set { _n_sort = value; }
            get { return _n_sort; }
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
        /// 执行标准
        /// </summary>
        public string C_STD_CODE
        {
            set { _c_std_code = value; }
            get { return _c_std_code; }
        }
        #endregion Model

    }
}

