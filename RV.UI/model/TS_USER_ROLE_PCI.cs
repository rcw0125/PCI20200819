﻿using System;
using Rcw.Data;
namespace RV.MODEL
{
    /// <summary>
    /// 用户角色
    /// </summary>
    [Serializable]
    public partial class TS_USER_ROLE_PCI:DbEntity
    {
        public TS_USER_ROLE_PCI()
        { }
        #region Model
        private string _c_id;
        private string _c_role_id;
        private string _c_user_id;
        private decimal _n_status = 1;
        private string _c_remark;
        private string _c_emp_id;
        private DateTime _d_mod_dt = Convert.ToDateTime(DateTime.Now);
        /// <summary>
        /// 主键
        /// </summary>
        public string C_ID
        {
            set { _c_id = value; }
            get { return _c_id; }
        }
        /// <summary>
        /// 角色ID
        /// </summary>
        public string C_ROLE_ID
        {
            set { _c_role_id = value; }
            get { return _c_role_id; }
        }
        /// <summary>
        /// 用户ID
        /// </summary>
        public string C_USER_ID
        {
            set { _c_user_id = value; }
            get { return _c_user_id; }
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
        #endregion Model

    }
}

