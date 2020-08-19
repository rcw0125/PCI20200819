using System;
namespace MODEL
{
    /// <summary>
    /// 排产配置表
    /// </summary>
    [Serializable]
    public partial class Mod_TPO_APS_CONFIG
    {
        public Mod_TPO_APS_CONFIG()
        { }
        #region Model
        private string _c_id = "sys_guid";
        private decimal? _n_lzdhl;
        private decimal? _n_lzkp;
        private decimal? _n_dhlkp;
        private decimal? _n_kpxhl;
        private decimal? _n_kpzg;
        private decimal? _n_xhlzg;
        private decimal? _n_5lzzs;
        private decimal? _n_7lzzs;
        private decimal? _n_3lzzs;
        private decimal? _n_4lzzs;
        private decimal? _n_6lzzs;
        private decimal? _n_5lzzl;
        private decimal? _n_7lzzl;
        private decimal? _n_3lzzl;
        private decimal? _n_4lzzl;
        private decimal? _n_6lzzl;
        private decimal? _n_rhls;
        private decimal? _n_hlgls;
        private decimal? _n_hlgsj;
        private decimal? _n_tgjscl;
        private decimal? _n_bxgjscl;
        private decimal? _n_1kpjscl;
        private decimal? _n_2kpjscl;
        private decimal? _n_kpl;
        private decimal? _n_xml;
        /// <summary>
        /// 主键
        /// </summary>
        public string C_ID
        {
            set { _c_id = value; }
            get { return _c_id; }
        }
        /// <summary>
        /// 连铸大缓冷h
        /// </summary>
        public decimal? N_LZDHL
        {
            set { _n_lzdhl = value; }
            get { return _n_lzdhl; }
        }
        /// <summary>
        /// 连铸开坯h
        /// </summary>
        public decimal? N_LZKP
        {
            set { _n_lzkp = value; }
            get { return _n_lzkp; }
        }
        /// <summary>
        /// 大缓冷开坯h
        /// </summary>
        public decimal? N_DHLKP
        {
            set { _n_dhlkp = value; }
            get { return _n_dhlkp; }
        }
        /// <summary>
        /// 开坯小缓冷h
        /// </summary>
        public decimal? N_KPXHL
        {
            set { _n_kpxhl = value; }
            get { return _n_kpxhl; }
        }
        /// <summary>
        /// 开坯轧钢h
        /// </summary>
        public decimal? N_KPZG
        {
            set { _n_kpzg = value; }
            get { return _n_kpzg; }
        }
        /// <summary>
        /// 小缓冷轧钢
        /// </summary>
        public decimal? N_XHLZG
        {
            set { _n_xhlzg = value; }
            get { return _n_xhlzg; }
        }
        /// <summary>
        /// 5#连铸支数
        /// </summary>
        public decimal? N_5LZZS
        {
            set { _n_5lzzs = value; }
            get { return _n_5lzzs; }
        }
        /// <summary>
        /// 7#连铸支数
        /// </summary>
        public decimal? N_7LZZS
        {
            set { _n_7lzzs = value; }
            get { return _n_7lzzs; }
        }
        /// <summary>
        /// 3#连铸支数
        /// </summary>
        public decimal? N_3LZZS
        {
            set { _n_3lzzs = value; }
            get { return _n_3lzzs; }
        }
        /// <summary>
        /// 4#连铸支数
        /// </summary>
        public decimal? N_4LZZS
        {
            set { _n_4lzzs = value; }
            get { return _n_4lzzs; }
        }
        /// <summary>
        /// 6#连铸支数
        /// </summary>
        public decimal? N_6LZZS
        {
            set { _n_6lzzs = value; }
            get { return _n_6lzzs; }
        }
        /// <summary>
        /// 5#连铸重量t
        /// </summary>
        public decimal? N_5LZZL
        {
            set { _n_5lzzl = value; }
            get { return _n_5lzzl; }
        }
        /// <summary>
        /// 7#连铸重量t
        /// </summary>
        public decimal? N_7LZZL
        {
            set { _n_7lzzl = value; }
            get { return _n_7lzzl; }
        }
        /// <summary>
        /// 3#连铸重量t
        /// </summary>
        public decimal? N_3LZZL
        {
            set { _n_3lzzl = value; }
            get { return _n_3lzzl; }
        }
        /// <summary>
        /// 4#连铸重量t
        /// </summary>
        public decimal? N_4LZZL
        {
            set { _n_4lzzl = value; }
            get { return _n_4lzzl; }
        }
        /// <summary>
        /// 6#连铸重量t
        /// </summary>
        public decimal? N_6LZZL
        {
            set { _n_6lzzl = value; }
            get { return _n_6lzzl; }
        }
        /// <summary>
        /// RH寿命 炉
        /// </summary>
        public decimal? N_RHLS
        {
            set { _n_rhls = value; }
            get { return _n_rhls; }
        }
        /// <summary>
        /// 化冷钢炉数
        /// </summary>
        public decimal? N_HLGLS
        {
            set { _n_hlgls = value; }
            get { return _n_hlgls; }
        }
        /// <summary>
        /// 化冷钢时间t
        /// </summary>
        public decimal? N_HLGSJ
        {
            set { _n_hlgsj = value; }
            get { return _n_hlgsj; }
        }
        /// <summary>
        /// 碳钢机时产量
        /// </summary>
        public decimal? N_TGJSCL
        {
            set { _n_tgjscl = value; }
            get { return _n_tgjscl; }
        }
        /// <summary>
        /// 不锈钢机时产量
        /// </summary>
        public decimal? N_BXGJSCL
        {
            set { _n_bxgjscl = value; }
            get { return _n_bxgjscl; }
        }
        /// <summary>
        /// 1开坯机时产量
        /// </summary>
        public decimal? N_1KPJSCL
        {
            set { _n_1kpjscl = value; }
            get { return _n_1kpjscl; }
        }
        /// <summary>
        /// 2开坯机时产量
        /// </summary>
        public decimal? N_2KPJSCL
        {
            set { _n_2kpjscl = value; }
            get { return _n_2kpjscl; }
        }
        /// <summary>
        /// 修磨量
        /// </summary>
        public decimal? N_KPL
        {
            set { _n_kpl = value; }
            get { return _n_kpl; }
        }
        /// <summary>
        /// 开坯量
        /// </summary>
        public decimal? N_XML
        {
            set { _n_xml = value; }
            get { return _n_xml; }
        }
        #endregion Model

    }
}
