using System;
namespace MODEL
{
    /// <summary>
    /// 质证书信息表
    /// </summary>
    [Serializable]
    public partial class Mod_TQC_ZZS_INFO
    {
        public Mod_TQC_ZZS_INFO()
        { }
        #region Model
        private string _c_id;
        private string _c_fydh;
        private string _c_batch_no;
        private string _c_stove;
        private string _c_spec;
        private string _c_stl_grd;
        private string _c_std_code;
        private DateTime? _d_cksj;
        private decimal? _n_jz;
        private decimal? _n_num;
        private string _c_ch;
        private string _c_pdf_name;
        private string _c_pdf_patch;
        private decimal _n_print_num = 0;
        private string _c_zsh;
        private string _c_qzr;
        private DateTime _d_qzrq = DateTime.Now;
        private string _c_by1;
        private string _c_by2;
        private string _c_by3;
        private decimal _n_status = 1;
        private string _c_remark;
        /// <summary>
        /// 主键
        /// </summary>
        public string C_ID
        {
            set { _c_id = value; }
            get { return _c_id; }
        }
        /// <summary>
        /// 发运单号
        /// </summary>
        public string C_FYDH
        {
            set { _c_fydh = value; }
            get { return _c_fydh; }
        }
        /// <summary>
        /// 批号
        /// </summary>
        public string C_BATCH_NO
        {
            set { _c_batch_no = value; }
            get { return _c_batch_no; }
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
        /// 规格
        /// </summary>
        public string C_SPEC
        {
            set { _c_spec = value; }
            get { return _c_spec; }
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
        /// 出库时间
        /// </summary>
        public DateTime? D_CKSJ
        {
            set { _d_cksj = value; }
            get { return _d_cksj; }
        }
        /// <summary>
        /// 重量
        /// </summary>
        public decimal? N_JZ
        {
            set { _n_jz = value; }
            get { return _n_jz; }
        }
        /// <summary>
        /// 件数
        /// </summary>
        public decimal? N_NUM
        {
            set { _n_num = value; }
            get { return _n_num; }
        }
        /// <summary>
        /// 车号
        /// </summary>
        public string C_CH
        {
            set { _c_ch = value; }
            get { return _c_ch; }
        }
        /// <summary>
        /// PDF文件名
        /// </summary>
        public string C_PDF_NAME
        {
            set { _c_pdf_name = value; }
            get { return _c_pdf_name; }
        }
        /// <summary>
        /// PDF文件路径
        /// </summary>
        public string C_PDF_PATCH
        {
            set { _c_pdf_patch = value; }
            get { return _c_pdf_patch; }
        }
        /// <summary>
        /// 打印次数
        /// </summary>
        public decimal N_PRINT_NUM
        {
            set { _n_print_num = value; }
            get { return _n_print_num; }
        }
        /// <summary>
        /// 证书号
        /// </summary>
        public string C_ZSH
        {
            set { _c_zsh = value; }
            get { return _c_zsh; }
        }
        /// <summary>
        /// 签证人
        /// </summary>
        public string C_QZR
        {
            set { _c_qzr = value; }
            get { return _c_qzr; }
        }
        /// <summary>
        /// 签证时间
        /// </summary>
        public DateTime D_QZRQ
        {
            set { _d_qzrq = value; }
            get { return _d_qzrq; }
        }
        /// <summary>
        /// 备用1
        /// </summary>
        public string C_BY1
        {
            set { _c_by1 = value; }
            get { return _c_by1; }
        }
        /// <summary>
        /// 备用2
        /// </summary>
        public string C_BY2
        {
            set { _c_by2 = value; }
            get { return _c_by2; }
        }
        /// <summary>
        /// 备用3
        /// </summary>
        public string C_BY3
        {
            set { _c_by3 = value; }
            get { return _c_by3; }
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
        #endregion Model

    }
}

