using System;
namespace MODEL
{
	/// <summary>
	/// 能源消耗实绩记录
	/// </summary>
	[Serializable]
	public partial class Mod_TRC_ENERGY_RECORD
	{
		public Mod_TRC_ENERGY_RECORD()
		{}
        #region Model
        private string _c_id = "sys_guid";
        private decimal? _n_consumption;
        private string _c_shift;
        private string _c_group;
        private string _c_energy_kind;
        private DateTime? _d_recode_dt;
        private string _c_sta_code;
        private decimal _n_status=1;
        private string _c_emp_id;
        private DateTime _d_mod_dt ;
        private string _c_sh_emp_id;
        private DateTime? _d_sh_mod_dt;
        private string _c_unit;
        private string _c_remark;
        private string _c_pro_code;
        /// <summary>
        /// 主键
        /// </summary>
        public string C_ID
        {
            set { _c_id = value; }
            get { return _c_id; }
        }
        /// <summary>
        /// 消耗数量
        /// </summary>
        public decimal? N_CONSUMPTION
        {
            set { _n_consumption = value; }
            get { return _n_consumption; }
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
        /// 能源种类
        /// </summary>
        public string C_ENERGY_KIND
        {
            set { _c_energy_kind = value; }
            get { return _c_energy_kind; }
        }
        /// <summary>
        /// 记录日期
        /// </summary>
        public DateTime? D_RECODE_DT
        {
            set { _d_recode_dt = value; }
            get { return _d_recode_dt; }
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
        /// 状态0停用1未审核2已审核
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
        /// 备注
        /// </summary>
        public string C_REMARK
        {
            set { _c_remark = value; }
            get { return _c_remark; }
        }
        /// <summary>
        /// 工序代码
        /// </summary>
        public string C_PRO_CODE
        {
            set { _c_pro_code = value; }
            get { return _c_pro_code; }
        }
        #endregion Model

    }
}

