using System;
namespace MODEL
{
	/// <summary>
	/// 物理检验项目配置
	/// </summary>
	[Serializable]
	public partial class Mod_TQB_PHYSICS_CONFIGURE
	{
		public Mod_TQB_PHYSICS_CONFIGURE()
		{}
		#region Model
		private string _c_id;
		private string _c_physics_group_id;
		private string _c_character_id;
		private decimal _n_status=1;
		private string _c_remark;
		private string _c_emp_id;
		private DateTime _d_mod_dt= Convert.ToDateTime(DateTime.Now);
        private string _c_order;
		/// <summary>
		/// 主键
		/// </summary>
		public string C_ID
		{
			set{ _c_id=value;}
			get{return _c_id;}
		}
		/// <summary>
		/// 物理分组表主键
		/// </summary>
		public string C_PHYSICS_GROUP_ID
		{
			set{ _c_physics_group_id=value;}
			get{return _c_physics_group_id;}
		}
		/// <summary>
		/// 检验基础数据表主键
		/// </summary>
		public string C_CHARACTER_ID
		{
			set{ _c_character_id=value;}
			get{return _c_character_id;}
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
		/// 维护人员
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
		/// 顺序号
		/// </summary>
		public string C_ORDER
        {
            set { _c_order = value; }
            get { return _c_order; }
        }
        #endregion Model

    }
}

