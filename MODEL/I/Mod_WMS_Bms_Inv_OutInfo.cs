using System;
namespace MODEL
{
	/// <summary>
	/// WMS_Bms_Inv_OutInfo:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Mod_WMS_Bms_Inv_OutInfo
    {
		public Mod_WMS_Bms_Inv_OutInfo()
		{}
		#region Model
		private string _barcode;
		private string _rkdh;
		private string _fydh;
		private int _ckdh;
		private string _ck;
		private string _hw;
		private string _pch;
		private string _wlh;
		private string _wlmc;
		private string _sx;
		private string _zldj;
		private string _ph;
		private string _gg;
		private string _bb;
		private int? _gh;
		private decimal? _zl;
		private string _bz;
		private DateTime? _rq= DateTime.Now;
		private string _flag;
		private string _ckry;
		private string _cxh;
		private string _khbm;
		private DateTime _weightrq= DateTime.Now;
		private int? _ckcxh=0;
		private string _producedata;
		private string _filed1;
		private string _pcinfo;
		private string _filed2;
		private string _errseason;
		private string _vfree0;
		private string _vfree1;
		private string _vfree2;
		private string _vfree3;
		private string _vfree4;
		private decimal _ysmz=0M;
		/// <summary>
		/// 
		/// </summary>
		public string Barcode
		{
			set{ _barcode=value;}
			get{return _barcode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string RKDH
		{
			set{ _rkdh=value;}
			get{return _rkdh;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FYDH
		{
			set{ _fydh=value;}
			get{return _fydh;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int CKDH
		{
			set{ _ckdh=value;}
			get{return _ckdh;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CK
		{
			set{ _ck=value;}
			get{return _ck;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string HW
		{
			set{ _hw=value;}
			get{return _hw;}
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
		public string WLH
		{
			set{ _wlh=value;}
			get{return _wlh;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string WLMC
		{
			set{ _wlmc=value;}
			get{return _wlmc;}
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
		public string ZLDJ
		{
			set{ _zldj=value;}
			get{return _zldj;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PH
		{
			set{ _ph=value;}
			get{return _ph;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GG
		{
			set{ _gg=value;}
			get{return _gg;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BB
		{
			set{ _bb=value;}
			get{return _bb;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? GH
		{
			set{ _gh=value;}
			get{return _gh;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? ZL
		{
			set{ _zl=value;}
			get{return _zl;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BZ
		{
			set{ _bz=value;}
			get{return _bz;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? RQ
		{
			set{ _rq=value;}
			get{return _rq;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Flag
		{
			set{ _flag=value;}
			get{return _flag;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CKRY
		{
			set{ _ckry=value;}
			get{return _ckry;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CXH
		{
			set{ _cxh=value;}
			get{return _cxh;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string KHBM
		{
			set{ _khbm=value;}
			get{return _khbm;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime WeightRQ
		{
			set{ _weightrq=value;}
			get{return _weightrq;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? CKCXH
		{
			set{ _ckcxh=value;}
			get{return _ckcxh;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ProduceData
		{
			set{ _producedata=value;}
			get{return _producedata;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Filed1
		{
			set{ _filed1=value;}
			get{return _filed1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PCInfo
		{
			set{ _pcinfo=value;}
			get{return _pcinfo;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Filed2
		{
			set{ _filed2=value;}
			get{return _filed2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ErrSeason
		{
			set{ _errseason=value;}
			get{return _errseason;}
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
		public decimal ysmz
		{
			set{ _ysmz=value;}
			get{return _ysmz;}
		}
		#endregion Model

	}
}

