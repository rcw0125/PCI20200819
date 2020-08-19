using System;
namespace MODEL
{
    /// <summary>
    /// 连铸重新收料记录表
    /// </summary>
    [Serializable]
    public partial class Mod_TSC_SLAB_MES_LOG
    {
        public Mod_TSC_SLAB_MES_LOG()
        { }
        #region Model
        private string _c_id;
        private string _c_sta_desc;
        private string _c_stove;
        private string _c_stl_grd;
        private string _c_std_code;
        private string _c_spec;
        private string _c_len;
        private string _c_mat_code;
        private string _c_mat_name;
        private string _c_qua;
        private string _c_wgt;
        private DateTime? _d_del_time = DateTime.Now;
        private string _c_del_user;
        private string _c_reason;
        /// <summary>
        /// 主键
        /// </summary>
        public string C_ID
        {
            set { _c_id = value; }
            get { return _c_id; }
        }
        /// <summary>
        /// 连铸机
        /// </summary>
        public string C_STA_DESC
        {
            set { _c_sta_desc = value; }
            get { return _c_sta_desc; }
        }
        /// <summary>
        /// 炉号
        /// </summary>
        public string C_STOVE
        {
            set { _c_stove = value; }
            get { return _c_stove; }
        }
        /// <summary>
        /// 钢种
        /// </summary>
        public string C_STL_GRD
        {
            set { _c_stl_grd = value; }
            get { return _c_stl_grd; }
        }
        /// <summary>
        /// 执行标准
        /// </summary>
        public string C_STD_CODE
        {
            set { _c_std_code = value; }
            get { return _c_std_code; }
        }
        /// <summary>
        /// 断面
        /// </summary>
        public string C_SPEC
        {
            set { _c_spec = value; }
            get { return _c_spec; }
        }
        /// <summary>
        /// 定尺
        /// </summary>
        public string C_LEN
        {
            set { _c_len = value; }
            get { return _c_len; }
        }
        /// <summary>
        /// 物料编码
        /// </summary>
        public string C_MAT_CODE
        {
            set { _c_mat_code = value; }
            get { return _c_mat_code; }
        }
        /// <summary>
        /// 物料名称
        /// </summary>
        public string C_MAT_NAME
        {
            set { _c_mat_name = value; }
            get { return _c_mat_name; }
        }
        /// <summary>
        /// 支数
        /// </summary>
        public string C_QUA
        {
            set { _c_qua = value; }
            get { return _c_qua; }
        }
        /// <summary>
        /// 重量
        /// </summary>
        public string C_WGT
        {
            set { _c_wgt = value; }
            get { return _c_wgt; }
        }
        /// <summary>
        /// 删除时间
        /// </summary>
        public DateTime? D_DEL_TIME
        {
            set { _d_del_time = value; }
            get { return _d_del_time; }
        }
        /// <summary>
        /// 删除人
        /// </summary>
        public string C_DEL_USER
        {
            set { _c_del_user = value; }
            get { return _c_del_user; }
        }
        /// <summary>
		/// 删除原因
		/// </summary>
		public string C_REASON
        {
            set { _c_reason = value; }
            get { return _c_reason; }
        }
        #endregion Model

    }
}

