using System;
namespace MODEL
{
    [Serializable]
    public class Mod_TB_CONFIG_PERCENTAGE
    {
        public Mod_TB_CONFIG_PERCENTAGE()
        { }
        #region Model
        private string _c_id ;
        private string _c_prod_kind;
        private string _c_prod_name;
        private decimal? _c_percentage;
        private string _c_emp_id;
        private string _c_condition;
        private string _c_condition2;
        private string _c_elsecon;
        private string _c_elsetype;
        private decimal? _n_type;
        /// <summary>
        /// 主键
        /// </summary>
        public string C_ID
        {
            set { _c_id = value; }
            get { return _c_id; }
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
        /// 类别
        /// </summary>
        public string C_PROD_NAME
        {
            set { _c_prod_name = value; }
            get { return _c_prod_name; }
        }
        /// <summary>
        /// 百分比
        /// </summary>
        public decimal? C_PERCENTAGE
        {
            set { _c_percentage = value; }
            get { return _c_percentage; }
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
        /// 条件
        /// </summary>
        public string C_CONDITION
        {
            set { _c_condition = value; }
            get { return _c_condition; }
        }
        /// <summary>
        /// 条件2
        /// </summary>
        public string C_CONDITION2
        {
            set { _c_condition2 = value; }
            get { return _c_condition2; }
        }
        /// <summary>
        /// 其他条件
        /// </summary>
        public string C_ELSECON
        {
            set { _c_elsecon = value; }
            get { return _c_elsecon; }
        }
        /// <summary>
        /// 其他类别
        /// </summary>
        public string C_ELSETYPE
        {
            set { _c_elsetype = value; }
            get { return _c_elsetype; }
        }
        /// <summary>
        /// 类别1(品种)2(品种加类别)3(品种加类别+其他类别)
        /// </summary>
        public decimal? N_TYPE
        {
            set { _n_type = value; }
            get { return _n_type; }
        }
        #endregion Model
    }
}
