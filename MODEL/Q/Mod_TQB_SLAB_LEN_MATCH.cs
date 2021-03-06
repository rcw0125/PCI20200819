﻿using System;
namespace MODEL
{
	/// <summary>
	/// 钢坯定尺匹配
	/// </summary>
	[Serializable]
	public partial class Mod_TQB_SLAB_LEN_MATCH
	{
		public Mod_TQB_SLAB_LEN_MATCH()
		{}
		#region Model
		private string _c_id;
		private string _c_std_id;
		private string _c_slab_id;
		private decimal _n_status=1;
		private string _c_remark;
		private string _c_emp_id;
		private DateTime _d_mod_dt= Convert.ToDateTime(DateTime.Now);
        private string _c_group;
        private string _c_order;
        private string _c_std_code;
        private string _c_stl_grd;
        /// <summary>
        /// 主键
        /// </summary>
        public string C_ID
		{
			set{ _c_id=value;}
			get{return _c_id;}
		}
		/// <summary>
		/// 执行标准外键
		/// </summary>
		public string C_STD_ID
		{
			set{ _c_std_id=value;}
			get{return _c_std_id;}
		}
		/// <summary>
		/// 钢坯定尺外键
		/// </summary>
		public string C_SLAB_ID
		{
			set{ _c_slab_id=value;}
			get{return _c_slab_id;}
		}
		/// <summary>
		/// 使用状态   1-可用；0-停用
		/// </summary>
		public decimal N_STATUS
		{
			set{ _n_status=value;}
			get{return _n_status;}
		}
		/// <summary>
		/// 备注
		/// </summary>
		public string C_REMARK
		{
			set{ _c_remark=value;}
			get{return _c_remark;}
		}
		/// <summary>
		/// 维护人
		/// </summary>
		public string C_EMP_ID
		{
			set{ _c_emp_id=value;}
			get{return _c_emp_id;}
		}
		/// <summary>
		/// 维护时间
		/// </summary>
		public DateTime D_MOD_DT
		{
			set{ _d_mod_dt=value;}
			get{return _d_mod_dt;}
		}

        /// <summary>
		/// 分组
		/// </summary>
		public string C_GROUP
        {
            set { _c_group = value; }
            get { return _c_group; }
        }
        /// <summary>
        /// 优先级
        /// </summary>
        public string C_ORDER
        {
            set { _c_order = value; }
            get { return _c_order; }
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
        /// 钢种
        /// </summary>
        public string C_STL_GRD
        {
            set { _c_stl_grd = value; }
            get { return _c_stl_grd; }
        }
        #endregion Model

    }
}

