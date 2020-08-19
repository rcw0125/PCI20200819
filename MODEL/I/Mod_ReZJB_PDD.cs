using System;
namespace MODEL
{
    /// <summary>
    /// ReZJB_PDD:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
	public partial class Mod_ReZJB_PDD
	{
		public Mod_ReZJB_PDD()
		{}
		#region Model
		private int _pk_zjb_pdd;
		private int? _zjbstatus=0;
		private string _cappk;
		private string _ck;
		private DateTime? _pdrq;
		private string _ysdh;
		/// <summary>
		/// 
		/// </summary>
		public int pk_ZJB_PDD
		{
			set{ _pk_zjb_pdd=value;}
			get{return _pk_zjb_pdd;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ZJBstatus
		{
			set{ _zjbstatus=value;}
			get{return _zjbstatus;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CAPPK
		{
			set{ _cappk=value;}
			get{return _cappk;}
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
		public DateTime? pdrq
		{
			set{ _pdrq=value;}
			get{return _pdrq;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ysdh
		{
			set{ _ysdh=value;}
			get{return _ysdh;}
		}
		#endregion Model

	}
}

