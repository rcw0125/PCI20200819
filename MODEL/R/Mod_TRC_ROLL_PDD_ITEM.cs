using System;

namespace MODEL
{
    /// <summary>
    /// 线材盘点明细表
    /// </summary>
    [Serializable]
    public partial class Mod_TRC_ROLL_PDD_ITEM
    {
        public Mod_TRC_ROLL_PDD_ITEM()
        { }
        #region Model
        private string _c_ysdh;
        private string _c_matcode;
        private string _c_pch;
        private string _c_sx;
        private decimal? _c_zcsl;
        private decimal? _c_fzczl;
        private string _c_free0;
        private string _c_free1;
        private string _c_free2;
        private string _c_free3;
        private string _c_free4;
        private string _c_id;
        private DateTime? _d_insert;
        private string _c_remark;
        private decimal _n_status = 1;
		private string _c_ck;
        private string _c_matdesc;
        private string _c_spec;
        private string _c_stl_grd;
        private decimal? _c_nc_sl;
        private decimal? _c_nc_zl;
        private decimal? _c_cap_sl;
        private decimal? _c_cap_zl;
        private decimal? _c_rf_sl;
        private decimal? _c_rf_zl;
        private decimal? _c_rf_sj_sl;
        private decimal? _c_rf_sj_zl;
        private decimal? _c_nc_cap_sl;
        private decimal? _c_nc_cap_zl;
        private decimal? _c_rf_cap_sl;
        private decimal? _c_rf_cap_zl;
        private decimal? _c_cap_sj_sl;
        private decimal? _c_cap_sj_zl;
        /// <summary>
        /// 单号
        /// </summary>
        public string C_YSDH
        {
            set { _c_ysdh = value; }
            get { return _c_ysdh; }
        }
        /// <summary>
        /// 物料号
        /// </summary>
        public string C_MATCODE
        {
            set { _c_matcode = value; }
            get { return _c_matcode; }
        }
        /// <summary>
        /// 批号
        /// </summary>
        public string C_PCH
        {
            set { _c_pch = value; }
            get { return _c_pch; }
        }
        /// <summary>
        /// 质量等级
        /// </summary>
        public string C_SX
        {
            set { _c_sx = value; }
            get { return _c_sx; }
        }
        /// <summary>
        /// 卷数
        /// </summary>
        public decimal? C_ZCSL
        {
            set { _c_zcsl = value; }
            get { return _c_zcsl; }
        }
        /// <summary>
        /// 重量
        /// </summary>
        public decimal? C_FZCZL
        {
            set { _c_fzczl = value; }
            get { return _c_fzczl; }
        }
        /// <summary>
        /// 自由项0
        /// </summary>
        public string C_FREE0
        {
            set { _c_free0 = value; }
            get { return _c_free0; }
        }
        /// <summary>
        /// 自由项1
        /// </summary>
        public string C_FREE1
        {
            set { _c_free1 = value; }
            get { return _c_free1; }
        }
        /// <summary>
        /// 自由项2
        /// </summary>
        public string C_FREE2
        {
            set { _c_free2 = value; }
            get { return _c_free2; }
        }
        /// <summary>
        /// 自由项3
        /// </summary>
        public string C_FREE3
        {
            set { _c_free3 = value; }
            get { return _c_free3; }
        }
        /// <summary>
        /// 自由项4
        /// </summary>
        public string C_FREE4
        {
            set { _c_free4 = value; }
            get { return _c_free4; }
        }
        /// <summary>
        /// 主键
        /// </summary>
        public string C_ID
        {
            set { _c_id = value; }
            get { return _c_id; }
        }
        /// <summary>
        /// 插入时间
        /// </summary>
        public DateTime? D_INSERT
        {
            set { _d_insert = value; }
            get { return _d_insert; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string C_REMARK
        {
            set { _c_remark = value; }
            get { return _c_remark; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal N_STATUS
        {
            set { _n_status = value; }
            get { return _n_status; }
        }
        /// <summary>
        /// 仓库
        /// </summary>
        public string C_CK
        {
            set { _c_ck = value; }
            get { return _c_ck; }
        }
        /// <summary>
        /// 物料名称
        /// </summary>
        public string C_MATDESC
        {
            set { _c_matdesc = value; }
            get { return _c_matdesc; }
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
        /// NC卷数
        /// </summary>
        public decimal? C_NC_SL
        {
            set { _c_nc_sl = value; }
            get { return _c_nc_sl; }
        }
        /// <summary>
        /// NC重量
        /// </summary>
        public decimal? C_NC_ZL
        {
            set { _c_nc_zl = value; }
            get { return _c_nc_zl; }
        }
        /// <summary>
        /// CAP卷数
        /// </summary>
        public decimal? C_CAP_SL
        {
            set { _c_cap_sl = value; }
            get { return _c_cap_sl; }
        }
        /// <summary>
        /// CAP重量
        /// </summary>
        public decimal? C_CAP_ZL
        {
            set { _c_cap_zl = value; }
            get { return _c_cap_zl; }
        }
        /// <summary>
        /// RF卷数
        /// </summary>
        public decimal? C_RF_SL
        {
            set { _c_rf_sl = value; }
            get { return _c_rf_sl; }
        }
        /// <summary>
        /// RF重量
        /// </summary>
        public decimal? C_RF_ZL
        {
            set { _c_rf_zl = value; }
            get { return _c_rf_zl; }
        }
        /// <summary>
        /// RF实盘卷数
        /// </summary>
        public decimal? C_RF_SJ_SL
        {
            set { _c_rf_sj_sl = value; }
            get { return _c_rf_sj_sl; }
        }
        /// <summary>
        /// RF实盘重量
        /// </summary>
        public decimal? C_RF_SJ_ZL
        {
            set { _c_rf_sj_zl = value; }
            get { return _c_rf_sj_zl; }
        }
        /// <summary>
        /// NC与CAP卷数账差
        /// </summary>
        public decimal? C_NC_CAP_SL
        {
            set { _c_nc_cap_sl = value; }
            get { return _c_nc_cap_sl; }
        }
        /// <summary>
        /// NC与CAP重量账差
        /// </summary>
        public decimal? C_NC_CAP_ZL
        {
            set { _c_nc_cap_zl = value; }
            get { return _c_nc_cap_zl; }
        }
        /// <summary>
        /// RF与CAP卷数账差
        /// </summary>
        public decimal? C_RF_CAP_SL
        {
            set { _c_rf_cap_sl = value; }
            get { return _c_rf_cap_sl; }
        }
        /// <summary>
        /// RF与CAP重量账差
        /// </summary>
        public decimal? C_RF_CAP_ZL
        {
            set { _c_rf_cap_zl = value; }
            get { return _c_rf_cap_zl; }
        }
        /// <summary>
        /// CAP与实盘卷数账差
        /// </summary>
        public decimal? C_CAP_SJ_SL
        {
            set { _c_cap_sj_sl = value; }
            get { return _c_cap_sj_sl; }
        }
        /// <summary>
        /// CAP与实盘重量账差
        /// </summary>
        public decimal? C_CAP_SJ_ZL
        {
            set { _c_cap_sj_zl = value; }
            get { return _c_cap_sj_zl; }
        }
        #endregion Model

    }
}

