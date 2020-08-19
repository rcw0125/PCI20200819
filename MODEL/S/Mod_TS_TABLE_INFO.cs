using System;
namespace MODEL
{
	/// <summary>
	/// 表说明
	/// </summary>
	[Serializable]
	public partial class Mod_TS_TABLE_INFO
	{
		public Mod_TS_TABLE_INFO()
		{}
		#region Model
		private string _c_id;
		private string _c_table_name;
		private string _c_table_desc;
		private string _c_create_emp;
		private DateTime? _d_create_date= Convert.ToDateTime(DateTime.Now);
		/// <summary>
		/// 主键
		/// </summary>
		public string C_ID
		{
			set{ _c_id=value;}
			get{return _c_id;}
		}
		/// <summary>
		/// 表名
		/// </summary>
		public string C_TABLE_NAME
		{
			set{ _c_table_name=value;}
			get{return _c_table_name;}
		}
		/// <summary>
		/// 表说明
		/// </summary>
		public string C_TABLE_DESC
		{
			set{ _c_table_desc=value;}
			get{return _c_table_desc;}
		}
		/// <summary>
		/// 创建人
		/// </summary>
		public string C_CREATE_EMP
		{
			set{ _c_create_emp=value;}
			get{return _c_create_emp;}
		}
		/// <summary>
		/// 创建时间
		/// </summary>
		public DateTime? D_CREATE_DATE
		{
			set{ _d_create_date=value;}
			get{return _d_create_date;}
		}
		#endregion Model

	}
}

