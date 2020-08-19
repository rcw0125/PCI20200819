using System;
namespace MODEL
{
	/// <summary>
	/// 轧钢生产影响记录
	/// </summary>
	[Serializable]
	public partial class Mod_TRC_PRODUCTION_IMPACT
	{
		public Mod_TRC_PRODUCTION_IMPACT()
		{}
        #region Model
        private string _c_id = "sys_guid";
        private decimal? _n_impact;
        private string _c_shift;
        private string _c_group;
        private string _c_impact_kind;
        private DateTime? _d_impact_dt;
        private string _c_sta_code;
        private decimal _n_status=1;
        private string _c_sh_emp_id;
        private DateTime? _d_sh_mod_dt;
        private string _c_unit = "min";
        private string _c_type;
        private string _c_remark;
        private string _c_emp_id;
        private DateTime _d_mod_dt ;
        private string _c_pro_code;
        private string _c_impact_desc;
        private DateTime? _d_impact_end_dt;
        /// <summary>
        /// 主键
        /// </summary>
        public string C_ID
        {
            set { _c_id = value; }
            get { return _c_id; }
        }
        /// <summary>
        /// 影响时间
        /// </summary>
        public decimal? N_IMPACT
        {
            set { _n_impact = value; }
            get { return _n_impact; }
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
        /// 影响种类
        /// </summary>
        public string C_IMPACT_KIND
        {
            set { _c_impact_kind = value; }
            get { return _c_impact_kind; }
        }
        /// <summary>
        /// 影响开始时间
        /// </summary>
        public DateTime? D_IMPACT_DT
        {
            set { _d_impact_dt = value; }
            get { return _d_impact_dt; }
        }
        /// <summary>
        /// 影响结束时间
        /// </summary>
        public DateTime? D_IMPACT_END_DT
        {
            set { _d_impact_end_dt = value; }
            get { return _d_impact_end_dt; }
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
        /// 状态0未审核1已审核
        /// </summary>
        public decimal N_STATUS
        {
            set { _n_status = value; }
            get { return _n_status; }
        }
        /// <summary>
        /// 审核人
        /// </summary>
        public string C_SH_EMP_ID
        {
            set { _c_sh_emp_id = value; }
            get { return _c_sh_emp_id; }
        }
        /// <summary>
        /// 审核时间
        /// </summary>
        public DateTime? D_SH_MOD_DT
        {
            set { _d_sh_mod_dt = value; }
            get { return _d_sh_mod_dt; }
        }
        /// <summary>
        /// 单位
        /// </summary>
        public string C_UNIT
        {
            set { _c_unit = value; }
            get { return _c_unit; }
        }
        /// <summary>
        /// 类别：停机时间，外界影响
        /// </summary>
        public string C_TYPE
        {
            set { _c_type = value; }
            get { return _c_type; }
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
        /// 工序代码
        /// </summary>
        public string C_PRO_CODE
        {
            set { _c_pro_code = value; }
            get { return _c_pro_code; }
        }
        /// <summary>
        /// 影响描述
        /// </summary>
        public string C_IMPACT_DESC
        {
            set { _c_impact_desc = value; }
            get { return _c_impact_desc; }
        }
        #endregion Model

    }
}

