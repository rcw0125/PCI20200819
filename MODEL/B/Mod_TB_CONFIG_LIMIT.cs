using System;
namespace MODEL
{
    /// <summary>
    /// 合同明细
    /// </summary>
    [Serializable]
    public partial class Mod_TB_CONFIG_LIMIT
    {
        #region Model
        private string _c_id = "sys_guid";
        private decimal? _n_section_min;
        private decimal? _n_section_max;
        private decimal? _n_num;
        private string _c_emp_id;
        /// <summary>
        /// 主键
        /// </summary>
        public string C_ID
        {
            set { _c_id = value; }
            get { return _c_id; }
        }
        /// <summary>
        /// 区域量小
        /// </summary>
        public decimal? N_SECTION_MIN
        {
            set { _n_section_min = value; }
            get { return _n_section_min; }
        }
        /// <summary>
        /// 区域量大
        /// </summary>
        public decimal? N_SECTION_MAX
        {
            set { _n_section_max = value; }
            get { return _n_section_max; }
        }
        /// <summary>
        /// 量
        /// </summary>
        public decimal? N_NUM
        {
            set { _n_num = value; }
            get { return _n_num; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string C_EMP_ID
        {
            set { _c_emp_id = value; }
            get { return _c_emp_id; }
        }
        #endregion Model
    }
}
