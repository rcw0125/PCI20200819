using System;
namespace MODEL
{
    /// <summary>
    /// 班组表
    /// </summary>
    [Serializable]
    public partial class Mod_TB_BZ
    {
        public Mod_TB_BZ()
        { }
        #region Model
        private string _c_id = "sys_guid";
        private string _c_bz_name;
        private decimal? _n_sort;
        private decimal _n_status = 1;
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
        /// 班组
        /// </summary>
        public string C_BZ_NAME
        {
            set { _c_bz_name = value; }
            get { return _c_bz_name; }
        }
        /// <summary>
        /// 排序
        /// </summary>
        public decimal? N_SORT
        {
            set { _n_sort = value; }
            get { return _n_sort; }
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
