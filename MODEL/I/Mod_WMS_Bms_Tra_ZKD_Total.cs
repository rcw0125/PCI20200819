using System;
namespace MODEL
{
	/// <summary>
	/// WMS_Bms_Tra_ZKD_Total:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Mod_WMS_Bms_Tra_ZKD_Total
    {
		public Mod_WMS_Bms_Tra_ZKD_Total()
		{}
		#region Model
		private string _zkdh;
		private string _pch;
		private string _sx;
		private string _cph;
		private int? _cknum=0;
		private int? _rknum=0;
		private string _ckoperator;
		private DateTime? _cktime;
		private string _ykoperator;
		private DateTime? _yktime;
		/// <summary>
		/// 
		/// </summary>
		public string ZKDH
		{
			set{ _zkdh=value;}
			get{return _zkdh;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PCH
		{
			set{ _pch=value;}
			get{return _pch;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SX
		{
			set{ _sx=value;}
			get{return _sx;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CPH
		{
			set{ _cph=value;}
			get{return _cph;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? CKNUM
		{
			set{ _cknum=value;}
			get{return _cknum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? RKNUM
		{
			set{ _rknum=value;}
			get{return _rknum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CKOperator
		{
			set{ _ckoperator=value;}
			get{return _ckoperator;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? CKTime
		{
			set{ _cktime=value;}
			get{return _cktime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string YKOperator
		{
			set{ _ykoperator=value;}
			get{return _ykoperator;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? YKTime
		{
			set{ _yktime=value;}
			get{return _yktime;}
		}
		#endregion Model

	}
}

