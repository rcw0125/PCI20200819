using System;
namespace MODEL
{
    /// <summary>
    /// SeZJB_Shift_Record:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
	public partial class Mod_SeZJB_Shift_Record
	{
		public Mod_SeZJB_Shift_Record()
		{}
		#region Model
		private string _ywdh;
		private string _ck;
		private string _shw;
		private string _dhw;
		private string _czry;
		private DateTime _czrq;
		private int _zjbstatus=0;
		private DateTime _ts;
		private string _by1;
		private string _by2;
		private string _by3;
		private string _by4;
		private string _by5;
		/// <summary>
		/// 
		/// </summary>
		public string ywdh
		{
			set{ _ywdh=value;}
			get{return _ywdh;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ck
		{
			set{ _ck=value;}
			get{return _ck;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string shw
		{
			set{ _shw=value;}
			get{return _shw;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string dhw
		{
			set{ _dhw=value;}
			get{return _dhw;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string czry
		{
			set{ _czry=value;}
			get{return _czry;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime czrq
		{
			set{ _czrq=value;}
			get{return _czrq;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int ZJBstatus
		{
			set{ _zjbstatus=value;}
			get{return _zjbstatus;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime ts
		{
			set{ _ts=value;}
			get{return _ts;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string by1
		{
			set{ _by1=value;}
			get{return _by1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string by2
		{
			set{ _by2=value;}
			get{return _by2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string by3
		{
			set{ _by3=value;}
			get{return _by3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string by4
		{
			set{ _by4=value;}
			get{return _by4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string by5
		{
			set{ _by5=value;}
			get{return _by5;}
		}
		#endregion Model

	}
}

