using System;
namespace MODEL
{
    /// <summary>
    /// 订单钢坯物料信息
    /// </summary>
    [Serializable]
    public partial class Mod_Order_Matral
    {
        public Mod_Order_Matral()
        { }
        #region Model
        private string _c_matrl_code_slab;
        private string _c_matrl_name_slab;
        private string _c_slab_size;
        private decimal? _n_slab_length;
        private decimal? _n_slab_pw;
        private string _c_matrl_code_kp;
        private string _c_matrl_name_kp;
        private string _c_kp_size;
        private decimal? _n_kp_length;
        private decimal? _n_kp_pw;
        /// <summary>
        /// 连铸坯物料编码
        /// </summary>
        public string C_MATRL_CODE_SLAB
        {
            set { _c_matrl_code_slab = value; }
            get { return _c_matrl_code_slab; }
        }
        /// <summary>
        /// 连铸坯物料名称
        /// </summary>
        public string C_MATRL_NAME_SLAB
        {
            set { _c_matrl_name_slab = value; }
            get { return _c_matrl_name_slab; }
        }
        /// <summary>
        /// 连铸坯断面
        /// </summary>
        public string C_SLAB_SIZE
        {
            set { _c_slab_size = value; }
            get { return _c_slab_size; }
        }
        /// <summary>
        /// 连铸坯定尺
        /// </summary>
        public decimal? N_SLAB_LENGTH
        {
            set { _n_slab_length = value; }
            get { return _n_slab_length; }
        }
        /// <summary>
        /// 连铸坯单重
        /// </summary>
        public decimal? N_SLAB_PW
        {
            set { _n_slab_pw = value; }
            get { return _n_slab_pw; }
        }
        /// <summary>
        /// 热轧坯物料名称
        /// </summary>
        public string C_MATRL_CODE_KP
        {
            set { _c_matrl_code_kp = value; }
            get { return _c_matrl_code_kp; }
        }
        /// <summary>
        /// 热轧坯物料名称
        /// </summary>
        public string C_MATRL_NAME_KP
        {
            set { _c_matrl_name_kp = value; }
            get { return _c_matrl_name_kp; }
        }
        /// <summary>
        /// 热轧坯断面
        /// </summary>
        public string C_KP_SIZE
        {
            set { _c_kp_size = value; }
            get { return _c_kp_size; }
        }
        /// <summary>
        /// 热轧坯定尺
        /// </summary>
        public decimal? N_KP_LENGTH
        {
            set { _n_kp_length = value; }
            get { return _n_kp_length; }
        }
        /// <summary>
        /// 热轧坯单重
        /// </summary>
        public decimal? N_KP_PW
        {
            set { _n_kp_pw = value; }
            get { return _n_kp_pw; }
        }
        #endregion Model



    }
}
