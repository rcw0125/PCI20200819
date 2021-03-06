﻿using System;
namespace MODEL
{
    /// <summary>
    /// 生产工位机时产能
    /// </summary>
    [Serializable]
    public partial class Mod_TPB_STEEL_SMELT_TIME
    {
        public Mod_TPB_STEEL_SMELT_TIME()
        { }
        #region Model
        private string _c_id = "sys_guid";
        private string _c_sta_id;
        private string _c_stl_grd;
        private string _c_spec;
        private decimal? _n_smelt_time;
        private DateTime? _d_start_date = Convert.ToDateTime(DateTime.Now);
        private DateTime? _d_end_date;
        private decimal _n_status = 1;
		private string _c_emp_id;
        private DateTime _d_mod_dt = Convert.ToDateTime(DateTime.Now);
        private string _c_std_code;
        private string _c_pro_id;
        private string _c_sta_desc;
        private string _c_sta_code;
        /// <summary>
        /// 主键
        /// </summary>
        public string C_ID
        {
            set { _c_id = value; }
            get { return _c_id; }
        }
        /// <summary>
        /// 工位表主键（外键）
        /// </summary>
        public string C_STA_ID
        {
            set { _c_sta_id = value; }
            get { return _c_sta_id; }
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
        /// 规格/断面
        /// </summary>
        public string C_SPEC
        {
            set { _c_spec = value; }
            get { return _c_spec; }
        }
        /// <summary>
        /// 冶炼时间
        /// </summary>
        public decimal? N_SMELT_TIME
        {
            set { _n_smelt_time = value; }
            get { return _n_smelt_time; }
        }
        /// <summary>
        /// 启用时间
        /// </summary>
        public DateTime? D_START_DATE
        {
            set { _d_start_date = value; }
            get { return _d_start_date; }
        }
        /// <summary>
        /// 停用时间
        /// </summary>
        public DateTime? D_END_DATE
        {
            set { _d_end_date = value; }
            get { return _d_end_date; }
        }
        /// <summary>
        /// 状态0停用1启用
        /// </summary>
        public decimal N_STATUS
        {
            set { _n_status = value; }
            get { return _n_status; }
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
        /// 操作时间
        /// </summary>
        public DateTime D_MOD_DT
        {
            set { _d_mod_dt = value; }
            get { return _d_mod_dt; }
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
        /// 工序
        /// </summary>
        public string C_PRO_ID
        {
            set { _c_pro_id = value; }
            get { return _c_pro_id; }
        }
        /// <summary>
        /// 工位描述
        /// </summary>
        public string C_STA_DESC
        {
            set { _c_sta_desc = value; }
            get { return _c_sta_desc; }
        }
        /// <summary>
        /// 工位描述
        /// </summary>
        public string C_STA_CODE
        {
            set { _c_sta_code = value; }
            get { return _c_sta_code; }
        }
        #endregion Model

    }
}
