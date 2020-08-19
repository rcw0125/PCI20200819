using System;
namespace MODEL
{
    /// <summary>
    /// 成分结果表
    /// </summary>
    [Serializable]
    public partial class Mod_TQC_QUA_RESULT
    {
        public Mod_TQC_QUA_RESULT()
        { }
        #region Model
        private string _c_id;
        private decimal _n_status = 1;
		private string _c_remark;
        private string _c_emp_id;
        private DateTime _d_mod_dt = DateTime.Now;
        private decimal _n_split = 0;
		private decimal _n_type = 0;
		private string _c_stove;
        private DateTime? _d_createtime;
        private decimal? _c_anano;
        private string _c_commissionid;
        private string _c_anaitem;
        private decimal? _n_originalvalue;
        private string _c_group;
        private string _c_shift;
        private DateTime? _d_shiftdate;
        private string _c_sampid;
        private string _c_sampsort;
        private string _c_is_pd = "1";
        /// <summary>
        /// 主键
        /// </summary>
        public string C_ID
        {
            set { _c_id = value; }
            get { return _c_id; }
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
        /// <summary>
        /// 维护人员
        /// </summary>
        public string C_EMP_ID
        {
            set { _c_emp_id = value; }
            get { return _c_emp_id; }
        }
        /// <summary>
        /// 维护时间
        /// </summary>
        public DateTime D_MOD_DT
        {
            set { _d_mod_dt = value; }
            get { return _d_mod_dt; }
        }
        /// <summary>
        /// 是否同步到综合判定   1-已同步；0-未同步
        /// </summary>
        public decimal N_SPLIT
        {
            set { _n_split = value; }
            get { return _n_split; }
        }
        /// <summary>
        /// 0检化验数据；1同步NC数据
        /// </summary>
        public decimal N_TYPE
        {
            set { _n_type = value; }
            get { return _n_type; }
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
        /// 
        /// </summary>
        public DateTime? D_CREATETIME
        {
            set { _d_createtime = value; }
            get { return _d_createtime; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? C_ANANO
        {
            set { _c_anano = value; }
            get { return _c_anano; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string C_COMMISSIONID
        {
            set { _c_commissionid = value; }
            get { return _c_commissionid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string C_ANAITEM
        {
            set { _c_anaitem = value; }
            get { return _c_anaitem; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? N_ORIGINALVALUE
        {
            set { _n_originalvalue = value; }
            get { return _n_originalvalue; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string C_GROUP
        {
            set { _c_group = value; }
            get { return _c_group; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string C_SHIFT
        {
            set { _c_shift = value; }
            get { return _c_shift; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? D_SHIFTDATE
        {
            set { _d_shiftdate = value; }
            get { return _d_shiftdate; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string C_SAMPID
        {
            set { _c_sampid = value; }
            get { return _c_sampid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string C_SAMPSORT
        {
            set { _c_sampsort = value; }
            get { return _c_sampsort; }
        }
        /// <summary>
        /// 是否作为判定的成分样品；1-判定；0-不判定
        /// </summary>
        public string C_IS_PD
        {
            set { _c_is_pd = value; }
            get { return _c_is_pd; }
        }
        #endregion Model

    }
}

