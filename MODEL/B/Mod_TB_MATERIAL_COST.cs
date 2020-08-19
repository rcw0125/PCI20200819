using System;
namespace MODEL
{
	/// <summary>
	/// 原料介质成本表
	/// </summary>
	[Serializable]
	public partial class Mod_TB_MATERIAL_COST
	{
		public Mod_TB_MATERIAL_COST()
		{}
        #region Model
        private string _c_id = "sys_guid";
        private string _c_material_name;
        private DateTime? _d_start_date = Convert.ToDateTime(DateTime.Now);
        private DateTime? _d_end_date;
        private decimal _n_status = 1;
		private decimal? _n_cost;
        private string _c_emp_id;
        private DateTime _d_mod_dt = Convert.ToDateTime(DateTime.Now);
        private string _c_remark;
        private string _c_unit;
        /// <summary>
        /// 主键
        /// </summary>
        public string C_ID
        {
            set { _c_id = value; }
            get { return _c_id; }
        }
        /// <summary>
        /// 能源介质名称
        /// </summary>
        public string C_MATERIAL_NAME
        {
            set { _c_material_name = value; }
            get { return _c_material_name; }
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
        /// 状态0停用1启用
        /// </summary>
        public decimal N_STATUS
        {
            set { _n_status = value; }
            get { return _n_status; }
        }
        /// <summary>
        /// 成本/单价
        /// </summary>
        public decimal? N_COST
        {
            set { _n_cost = value; }
            get { return _n_cost; }
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
        /// 单位
        /// </summary>
        public string C_UNIT
        {
            set { _c_unit = value; }
            get { return _c_unit; }
        }
        #endregion Model

    }
}

