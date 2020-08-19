using System;
namespace MODEL
{
    /// <summary>
    /// SeZJB_PDD_FINISHED:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
	public partial class Mod_SeZJB_PDD_FINISHED
	{
		public Mod_SeZJB_PDD_FINISHED()
		{}
		#region Model
		private string _ysdh;
		private string _ck;
		private DateTime _pdrq;
		private string _djzt;
		private string _shuser;
		private DateTime _shdate;
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
		public string ysdh
		{
			set{ _ysdh=value;}
			get{return _ysdh;}
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
		public DateTime pdrq
		{
			set{ _pdrq=value;}
			get{return _pdrq;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string djzt
		{
			set{ _djzt=value;}
			get{return _djzt;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string shuser
		{
			set{ _shuser=value;}
			get{return _shuser;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime shdate
		{
			set{ _shdate=value;}
			get{return _shdate;}
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

