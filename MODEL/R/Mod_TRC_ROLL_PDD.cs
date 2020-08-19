using System;

namespace MODEL
{
	/// <summary>
	/// 线材盘点主表
	/// </summary>
	[Serializable]
	public partial class Mod_TRC_ROLL_PDD
	{
		public Mod_TRC_ROLL_PDD()
		{}
		#region Model
		private string _c_id;
		private string _c_ck;
		private DateTime? _d_pdrq;
		private string _c_ysdh;
		private DateTime? _d_insert;
		private string _c_remark;
		private decimal _n_status=1;
		/// <summary>
		/// 主键
		/// </summary>
		public string C_ID
		{
			set{ _c_id=value;}
			get{return _c_id;}
		}
		/// <summary>
		/// 仓库
		/// </summary>
		public string C_CK
		{
			set{ _c_ck=value;}
			get{return _c_ck;}
		}
		/// <summary>
		/// 盘点日期
		/// </summary>
		public DateTime? D_PDRQ
		{
			set{ _d_pdrq=value;}
			get{return _d_pdrq;}
		}
		/// <summary>
		/// 单号
		/// </summary>
		public string C_YSDH
		{
			set{ _c_ysdh=value;}
			get{return _c_ysdh;}
		}
		/// <summary>
		/// 插入时间
		/// </summary>
		public DateTime? D_INSERT
		{
			set{ _d_insert=value;}
			get{return _d_insert;}
		}
		/// <summary>
		/// 备注
		/// </summary>
		public string C_REMARK
		{
			set{ _c_remark=value;}
			get{return _c_remark;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal N_STATUS
		{
			set{ _n_status=value;}
			get{return _n_status;}
		}
		#endregion Model

	}
}

