using System;
namespace MODEL
{
    public class Mod_TB_NOT_LIMIT
    {
        public Mod_TB_NOT_LIMIT()
        { }
        #region Model
        private string _c_id;
        private string _c_name;
        private string _c_matcode;
        private decimal? _c_type;
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
        /// 名称
        /// </summary>
        public string C_NAME
        {
            set { _c_name = value; }
            get { return _c_name; }
        }
        /// <summary>
        /// 物料编码
        /// </summary>
        public string C_MATCODE
        {
            set { _c_matcode = value; }
            get { return _c_matcode; }
        }
        /// <summary>
        /// 类型 1钢种 2物料编码 3不锈钢
        /// </summary>
        public decimal? C_TYPE
        {
            set { _c_type = value; }
            get { return _c_type; }
        }
        /// <summary>
        /// 操作人
        /// </summary>
        public string C_EMP_ID
        {
            set { _c_emp_id = value; }
            get { return _c_emp_id; }
        }
        #endregion Model
    }
}
