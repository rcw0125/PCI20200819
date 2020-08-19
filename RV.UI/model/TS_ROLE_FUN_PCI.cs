﻿using System;
namespace RV.MODEL
{
	/// <summary>
	///  角色权限
	/// </summary>
	[Serializable]
	public partial class TS_ROLE_FUN_PCI : Rcw.Data.DbEntity
    {
		public TS_ROLE_FUN_PCI()
		{}
		#region Model
		private string _c_id;
		private string _c_module_id;
		private string _c_role_id;
		private string _c_function_type;
		private DateTime _d_mod_dt= Convert.ToDateTime(DateTime.Now);
		/// <summary>
		/// 主键
		/// </summary>
		public string C_ID
		{
			set{ _c_id=value;}
			get{return _c_id;}
		}
		/// <summary>
		/// 菜单表主键
		/// </summary>
		public string C_MODULE_ID
		{
			set{ _c_module_id=value;}
			get{return _c_module_id;}
		}
		/// <summary>
		/// 角色ID
		/// </summary>
		public string C_ROLE_ID
		{
			set{ _c_role_id=value;}
			get{return _c_role_id;}
		}
		/// <summary>
		/// 权限类型；1-菜单权限；2-按钮权限
		/// </summary>
		public string C_FUNCTION_TYPE
		{
			set{ _c_function_type=value;}
			get{return _c_function_type;}
		}
		/// <summary>
		/// 添加时间
		/// </summary>
		public DateTime D_MOD_DT
		{
			set{ _d_mod_dt=value;}
			get{return _d_mod_dt;}
		}
		#endregion Model

	}
}

