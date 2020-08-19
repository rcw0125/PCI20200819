﻿using System;
namespace MODEL
{
    /// <summary>
    /// 工位历史产能
    /// </summary>
    [Serializable]
    public partial class Mod_TPB_STA_HISTORY_CAP
    {
        public Mod_TPB_STA_HISTORY_CAP()
        { }
        #region Model
        private string _c_id = "sys_guid";
        private string _c_sta_id;
        private string _c_pro_id;
        private decimal? _n_capacity;
        private decimal _n_status = 1 ;
		private string _c_emp_id;
        private DateTime _d_mod_dt = Convert.ToDateTime(DateTime.Now);
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
        /// 工位表主键（外键）
        /// </summary>
        public string C_STA_ID
        {
            set { _c_sta_id = value; }
            get { return _c_sta_id; }
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
        /// 机时产能
        /// </summary>
        public decimal? N_CAPACITY
        {
            set { _n_capacity = value; }
            get { return _n_capacity; }
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
