using System;
namespace MODEL
{
	/// <summary>
	/// 不良品统计报表
	/// </summary>
	[Serializable]
	public partial class Mod_TQR_REJECTS
	{
		public Mod_TQR_REJECTS()
		{}
		#region Model
		private string _c_id;
		private string _c_stove;
		private string _c_batch_no;
		private string _c_stl_grd;
		private string _c_stl_grd_type;
		private string _c_reason_name;
		private string _c_reason_qua;
		private decimal? _n_reason_wgt=0;
		/// <summary>
		/// 主键
		/// </summary>
		public string C_ID
		{
			set{ _c_id=value;}
			get{return _c_id;}
		}
		/// <summary>
		/// 炉号
		/// </summary>
		public string C_STOVE
		{
			set{ _c_stove=value;}
			get{return _c_stove;}
		}
		/// <summary>
		/// 批号
		/// </summary>
		public string C_BATCH_NO
		{
			set{ _c_batch_no=value;}
			get{return _c_batch_no;}
		}
		/// <summary>
		/// 钢种
		/// </summary>
		public string C_STL_GRD
		{
			set{ _c_stl_grd=value;}
			get{return _c_stl_grd;}
		}
		/// <summary>
		/// 钢种类别
		/// </summary>
		public string C_STL_GRD_TYPE
		{
			set{ _c_stl_grd_type=value;}
			get{return _c_stl_grd_type;}
		}
		/// <summary>
		/// 不合格原因名称
		/// </summary>
		public string C_REASON_NAME
		{
			set{ _c_reason_name=value;}
			get{return _c_reason_name;}
		}
		/// <summary>
		/// 不合格件数
		/// </summary>
		public string C_REASON_QUA
		{
			set{ _c_reason_qua=value;}
			get{return _c_reason_qua;}
		}
		/// <summary>
		/// 不合格重量
		/// </summary>
		public decimal? N_REASON_WGT
		{
			set{ _n_reason_wgt=value;}
			get{return _n_reason_wgt;}
		}
		#endregion Model

	}
}

