using System;
namespace MODEL
{
    /// <summary>
    /// 性能检验过程量
    /// </summary>
    [Serializable]
    public partial class Mod_TQB_XN_CHECK_PROCEDURE
    {
        public Mod_TQB_XN_CHECK_PROCEDURE()
        { }
        #region Model
        private string _c_id = "sys_guid";
        private string _c_physics_group_id;
        private string _c_name;
        private decimal _n_status = 1;
        private string _c_remark;
        private string _c_emp_id;
        private DateTime _d_mod_dt = Convert.ToDateTime(DateTime.Now);
        private string _c_code;
        private decimal _n_order;
        private string _c_desc;
        private string _c_desc_item;
        /// <summary>
        /// 主键
        /// </summary>
        public string C_ID
        {
            set { _c_id = value; }
            get { return _c_id; }
        }
        /// <summary>
        /// 物理分组表主键
        /// </summary>
        public string C_PHYSICS_GROUP_ID
        {
            set { _c_physics_group_id = value; }
            get { return _c_physics_group_id; }
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
        /// 操作人员
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
		/// 项目代码
		/// </summary>
		public string C_CODE
        {
            set { _c_code = value; }
            get { return _c_code; }
        }
        /// <summary>
		/// 顺序号
		/// </summary>
		public decimal N_ORDER
        {
            set { _n_order = value; }
            get { return _n_order; }
        }
        /// <summary>
        /// 项目明细
        /// </summary>
        public string C_DESC
        {
            set { _c_desc = value; }
            get { return _c_desc; }
        }
        /// <summary>
        /// 项目明细
        /// </summary>
        public string C_DESC_ITEM
        {
            set { _c_desc_item = value; }
            get { return _c_desc_item; }
        }
        #endregion Model

    }
}

