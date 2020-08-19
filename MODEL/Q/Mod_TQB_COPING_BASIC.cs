using System;
namespace MODEL
{
	/// <summary>
	/// 修磨要求基础数据
	/// </summary>
	[Serializable]
	public partial class Mod_TQB_COPING_BASIC
	{
		public Mod_TQB_COPING_BASIC()
		{}
		#region Model
		private string _c_id= "sys_guid";
		private string _c_coping_craft;
		private string _c_craft_flow;
		private decimal _n_status=1;
		private string _c_remark;
		private string _c_emp_id;
		private DateTime _d_mod_dt= Convert.ToDateTime(DateTime.Now);
        private string _c_is_bxg;
		/// <summary>
		/// 主键
		/// </summary>
		public string C_ID
		{
			set{ _c_id=value;}
			get{return _c_id;}
		}
		/// <summary>
		/// 修磨工艺
		/// </summary>
		public string C_COPING_CRAFT
		{
			set{ _c_coping_craft=value;}
			get{return _c_coping_craft;}
		}
		/// <summary>
		/// 工艺流程
		/// </summary>
		public string C_CRAFT_FLOW
		{
			set{ _c_craft_flow=value;}
			get{return _c_craft_flow;}
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
		/// 是否为不锈钢 
		/// </summary>
		public string C_IS_BXG
        {
            set { _c_is_bxg = value; }
            get { return _c_is_bxg; }
        }
        #endregion Model

    }
}

