using System;
namespace MODEL
{
    public partial class Mod_TB_NCIF_LOG
    {
        public Mod_TB_NCIF_LOG()
        { }
        #region Model
        private string _c_id = "sys_guid";
        private string _c_type;
        private DateTime _d_mod_dt = Convert.ToDateTime(DateTime.Now);
        private string _c_remark;
        private string _c_relationship_id;
        private string _c_result;
        /// <summary>
        /// 主键
        /// </summary>
        public string C_ID
        {
            set { _c_id = value; }
            get { return _c_id; }
        }
        /// <summary>
        /// 类型
        /// </summary>
        public string C_TYPE
        {
            set { _c_type = value; }
            get { return _c_type; }
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
        /// 关联id
        /// </summary>
        public string C_RELATIONSHIP_ID
        {
            set { _c_relationship_id = value; }
            get { return _c_relationship_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string C_RESULT
        {
            set { _c_result = value; }
            get { return _c_result; }
        }
        #endregion Model
    }
}
