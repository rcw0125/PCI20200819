using System;
namespace MODEL
{
    /// <summary>
    /// SeZJB_WGD_Finished:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
	public partial class Mod_SeZJB_WGD_Finished
	{
		public Mod_SeZJB_WGD_Finished()
		{}
		#region Model
		private string _wgdh;
		private string _pch;
		private int _finished;
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
		public string wgdh
		{
			set{ _wgdh=value;}
			get{return _wgdh;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string pch
		{
			set{ _pch=value;}
			get{return _pch;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int finished
		{
			set{ _finished=value;}
			get{return _finished;}
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

