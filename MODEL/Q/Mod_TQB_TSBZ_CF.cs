using System;
namespace MODEL
{
    /// <summary>
	/// 铁水条件成分信息
	/// </summary>
	[Serializable]
    public partial class Mod_TQB_TSBZ_CF
    {
        public Mod_TQB_TSBZ_CF()
        { }
        #region Model
        private string _c_id = "sys_guid"; 
        private string _c_character_id;
        private string _c_code;
        private string _c_name;
        private decimal? _n_target_value;
        private decimal _n_status = 1;
		private string _c_remark;
        private string _c_emp_id;
        private DateTime _d_mod_dt = Convert.ToDateTime(DateTime.Now);
        private string _c_std_code;
        private string _c_stl_grd;
        private string _c_pro_condition_id;
        /// <summary>
        /// 主键
        /// </summary>
        public string C_ID
        {
            set { _c_id = value; }
            get { return _c_id; }
        }
         
        /// <summary>
        /// 基础数据主键
        /// </summary>
        public string C_CHARACTER_ID
        {
            set { _c_character_id = value; }
            get { return _c_character_id; }
        }
        /// <summary>
        /// 项目代码
        /// </summary>
        public string C_CODE
        {
            set { _c_code = value; }
            get { return _c_code; }
        }
        /// <summary>
        /// 项目名称
        /// </summary>
        public string C_NAME
        {
            set { _c_name = value; }
            get { return _c_name; }
        }
        /// <summary>
        /// 目标值
        /// </summary>
        public decimal? N_TARGET_VALUE
        {
            set { _n_target_value = value; }
            get { return _n_target_value; }
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
		/// 执行标准代码
		/// </summary>
		public string C_STD_CODE
        {
            set { _c_std_code = value; }
            get { return _c_std_code; }
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
        /// 钢种生成条件主表外键
        /// </summary>
        public string C_PRO_CONDITION_ID
        {
            set { _c_pro_condition_id = value; }
            get { return _c_pro_condition_id; }
        }

        #endregion Model

    }
}