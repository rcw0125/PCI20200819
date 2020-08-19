using System;
namespace MODEL
{
    /// <summary>
    /// ReZJB_WGD_Item:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
	public partial class Mod_ReZJB_WGD_Item
	{
		public Mod_ReZJB_WGD_Item()
		{}
		#region Model
		private string _wgdh;
		private string _pch;
		private string _ph;
		private string _gg;
		private string _wlh;
		private string _wlmc;
		private string _pcinfo;
		private string _zyx1;
		private string _zyx2;
		private string _zyx3;
		private string _zyx4;
		private string _zyx5;
		private int _pk_zjb_wgd_item;
		private int? _zjbstatus=0;
		private string _cappk;
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
		public string ph
		{
			set{ _ph=value;}
			get{return _ph;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string gg
		{
			set{ _gg=value;}
			get{return _gg;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string wlh
		{
			set{ _wlh=value;}
			get{return _wlh;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string wlmc
		{
			set{ _wlmc=value;}
			get{return _wlmc;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string pcinfo
		{
			set{ _pcinfo=value;}
			get{return _pcinfo;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string zyx1
		{
			set{ _zyx1=value;}
			get{return _zyx1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string zyx2
		{
			set{ _zyx2=value;}
			get{return _zyx2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string zyx3
		{
			set{ _zyx3=value;}
			get{return _zyx3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string zyx4
		{
			set{ _zyx4=value;}
			get{return _zyx4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string zyx5
		{
			set{ _zyx5=value;}
			get{return _zyx5;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int pk_ZJB_WGD_Item
		{
			set{ _pk_zjb_wgd_item=value;}
			get{return _pk_zjb_wgd_item;}
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
		#endregion Model

	}
}

