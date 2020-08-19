using System;
namespace MODEL
{
    /// <summary>
    /// ReZJB_PDD_Item:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
	public partial class Mod_ReZJB_PDD_Item
	{
		public Mod_ReZJB_PDD_Item()
		{}
		#region Model
		private string _ysdh;
		private string _barcode;
		private string _pch;
		private string _sx;
		private int _zcsl;
		private decimal _fzczl;
		private string _vfree0;
		private string _vfree1;
		private string _vfree2;
		private string _vfree3;
		private string _vfree4;
		private int? _zjbstatus=0;
		private string _cappk;
		private int _pk_zjb_pdd_item;
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
		public string BARCODE
		{
			set{ _barcode=value;}
			get{return _barcode;}
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
		public int ZCSL
		{
			set{ _zcsl=value;}
			get{return _zcsl;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal FZCZL
		{
			set{ _fzczl=value;}
			get{return _fzczl;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string vfree0
		{
			set{ _vfree0=value;}
			get{return _vfree0;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string vfree1
		{
			set{ _vfree1=value;}
			get{return _vfree1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string vfree2
		{
			set{ _vfree2=value;}
			get{return _vfree2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string vfree3
		{
			set{ _vfree3=value;}
			get{return _vfree3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string vfree4
		{
			set{ _vfree4=value;}
			get{return _vfree4;}
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
		public int pk_ZJB_PDD_Item
		{
			set{ _pk_zjb_pdd_item=value;}
			get{return _pk_zjb_pdd_item;}
		}
		#endregion Model

	}
}

