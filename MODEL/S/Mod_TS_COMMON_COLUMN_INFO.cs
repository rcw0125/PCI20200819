using System;
namespace MODEL
{
	/// <summary>
	/// 常用字段说明
	/// </summary>
	[Serializable]
	public partial class Mod_TS_COMMON_COLUMN_INFO
	{
		public Mod_TS_COMMON_COLUMN_INFO()
		{}
		#region Model
		private string _c_id;
		private string _c_column_name;
		private string _c_column_type;
		private string _c_column_comments;
		private DateTime? _d_mod_date= Convert.ToDateTime(DateTime.Now);
		/// <summary>
		/// 主键
		/// </summary>
		public string C_ID
		{
			set{ _c_id=value;}
			get{return _c_id;}
		}
		/// <summary>
		/// 字段名
		/// </summary>
		public string C_COLUMN_NAME
		{
			set{ _c_column_name=value;}
			get{return _c_column_name;}
		}
		/// <summary>
		/// 字段类型
		/// </summary>
		public string C_COLUMN_TYPE
		{
			set{ _c_column_type=value;}
			get{return _c_column_type;}
		}
		/// <summary>
		/// 字段描述
		/// </summary>
		public string C_COLUMN_COMMENTS
		{
			set{ _c_column_comments=value;}
			get{return _c_column_comments;}
		}
		/// <summary>
		/// 操作时间
		/// </summary>
		public DateTime? D_MOD_DATE
		{
			set{ _d_mod_date=value;}
			get{return _d_mod_date;}
		}
		#endregion Model

	}
}

