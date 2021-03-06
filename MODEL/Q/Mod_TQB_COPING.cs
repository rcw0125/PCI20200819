﻿using System;
namespace MODEL
{
    /// <summary>
    /// 修磨要求
    /// </summary>
    [Serializable]
    public partial class Mod_TQB_COPING
    {
        public Mod_TQB_COPING()
        { }
        #region Model
        private string _c_id = "sys_guid";
        private string _c_stl_grd;
        private string _c_std_code;
        private string _c_spcification_min;
        private string _c_spcification_max;
        private decimal _n_status = 1;
        private string _c_remark;
        private string _c_emp_id;
        private DateTime _d_mod_dt = Convert.ToDateTime(DateTime.Now);
        private string _c_coping_basic_id;
        private string _c_is_bxg;
        private string _c_custfile_name;
        /// <summary>
        /// 主键
        /// </summary>
        public string C_ID
        {
            set { _c_id = value; }
            get { return _c_id; }
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
        /// 规格最小值
        /// </summary>
        public string C_SPCIFICATION_MIN
        {
            set { _c_spcification_min = value; }
            get { return _c_spcification_min; }
        }
        /// <summary>
        /// 规格最大值
        /// </summary>
        public string C_SPCIFICATION_MAX
        {
            set { _c_spcification_max = value; }
            get { return _c_spcification_max; }
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
        /// 维护人
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
        /// 修磨要求基础数据主键
        /// </summary>
        public string C_COPING_BASIC_ID
        {
            set { _c_coping_basic_id = value; }
            get { return _c_coping_basic_id; }
        }
        /// <summary>
        /// 是否为不锈钢
        /// </summary>
        public string C_IS_BXG
        {
            set { _c_is_bxg = value; }
            get { return _c_is_bxg; }
        }
        /// <summary>
        /// 客商名称
        /// </summary>
        public string C_CUSTFILE_NAME
        {
            set { _c_custfile_name = value; }
            get { return _c_custfile_name; }
        }
        #endregion Model

    }
}

