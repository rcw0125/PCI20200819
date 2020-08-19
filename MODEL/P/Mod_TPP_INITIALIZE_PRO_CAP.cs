using System;
namespace MODEL
{
    /// <summary>
    /// 初始化排产方案生产工序产能
    /// </summary>
    [Serializable]
    public partial class Mod_TPP_INITIALIZE_PRO_CAP
    {
        public Mod_TPP_INITIALIZE_PRO_CAP()
        { }
        #region Model
        private string _c_id = "sys_guid";
        private string _c_pro_id;
        private string _c_pro_code;
        private string _c_pro_desc;
        private string _c_initialize_item_id;
        private decimal? _n_capacity = 0;
		private string _c_emp_id;
        private DateTime _d_mod_dt = Convert.ToDateTime(DateTime.Now);
        /// <summary>
        /// 主键
        /// </summary>
        public string C_ID
        {
            set { _c_id = value; }
            get { return _c_id; }
        }
        /// <summary>
        /// 工序主键
        /// </summary>
        public string C_PRO_ID
        {
            set { _c_pro_id = value; }
            get { return _c_pro_id; }
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
        /// 工序描述
        /// </summary>
        public string C_PRO_DESC
        {
            set { _c_pro_desc = value; }
            get { return _c_pro_desc; }
        }
        /// <summary>
        /// 订单方案表主键
        /// </summary>
        public string C_INITIALIZE_ITEM_ID
        {
            set { _c_initialize_item_id = value; }
            get { return _c_initialize_item_id; }
        }
        /// <summary>
        /// 产能
        /// </summary>
        public decimal? N_CAPACITY
        {
            set { _n_capacity = value; }
            get { return _n_capacity; }
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
        #endregion Model

    }
}
