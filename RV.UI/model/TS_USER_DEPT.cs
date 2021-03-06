﻿using System;
namespace RV.MODEL
{
	/// <summary>
	/// TS_USER_DEPT:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TS_USER_DEPT : Rcw.Data.DbEntity
    {
		public TS_USER_DEPT()
		{}
		#region Model
		private string _c_id;
		private string _c_user_id;
		private string _c_dept_id;
		/// <summary>
		/// 
		/// </summary>
		public string C_ID
		{
			set{ _c_id=value;}
			get{return _c_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string C_USER_ID
		{
			set{ _c_user_id=value;}
			get{return _c_user_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string C_DEPT_ID
		{
			set{ _c_dept_id=value;}
			get{return _c_dept_id;}
		}
		#endregion Model

	}
}

