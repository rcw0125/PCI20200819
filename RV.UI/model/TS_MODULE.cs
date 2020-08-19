using System;
namespace RV.MODEL
{
	/// <summary>
	/// PCI菜单信息表
	/// </summary>
	[Serializable]
	public partial class TS_MODULE : Rcw.Data.DbEntity
    {
		public TS_MODULE()
		{}
		#region Model
		private string _c_moduleid;
		private string _c_parentmoduleid;
		private string _c_modulename;
		private string _c_assemblyname;
		private string _c_moduleclass;
		private string _c_disable;
		private decimal? _n_order;
		private decimal? _n_imageindex;
		private string _c_module_type="1";
		private string _c_query_str;
		private string _c_remark;
		private string _c_emp_id;
		private DateTime _d_mod_dt;
		/// <summary>
		/// 模块编码
		/// </summary>
		public string C_MODULEID
		{
			set{ _c_moduleid=value;}
			get{return _c_moduleid;}
		}
		/// <summary>
		/// 父模块编码
		/// </summary>
		public string C_PARENTMODULEID
		{
			set{ _c_parentmoduleid=value;}
			get{return _c_parentmoduleid;}
		}
		/// <summary>
		/// 模块名称
		/// </summary>
		public string C_MODULENAME
		{
			set{ _c_modulename=value;}
			get{return _c_modulename;}
		}
		/// <summary>
		/// 装配件
		/// </summary>
		public string C_ASSEMBLYNAME
		{
			set{ _c_assemblyname=value;}
			get{return _c_assemblyname;}
		}
		/// <summary>
		/// 模块类
		/// </summary>
		public string C_MODULECLASS
		{
			set{ _c_moduleclass=value;}
			get{return _c_moduleclass;}
		}
		/// <summary>
		/// 禁用
		/// </summary>
		public string C_DISABLE
		{
			set{ _c_disable=value;}
			get{return _c_disable;}
		}
		/// <summary>
		/// 顺序号
		/// </summary>
		public decimal? N_ORDER
		{
			set{ _n_order=value;}
			get{return _n_order;}
		}
		/// <summary>
		/// 图片索引
		/// </summary>
		public decimal? N_IMAGEINDEX
		{
			set{ _n_imageindex=value;}
			get{return _n_imageindex;}
		}
        /// <summary>
        /// 模块类型：1-普通模块;2-系统模块;3-按钮模块
        /// </summary>
        public string C_MODULE_TYPE
		{
			set{ _c_module_type=value;}
			get{return _c_module_type;}
		}
		/// <summary>
		/// 注入参数
		/// </summary>
		public string C_QUERY_STR
		{
			set{ _c_query_str=value;}
			get{return _c_query_str;}
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
		/// 维护人
		/// </summary>
		public string C_EMP_ID
		{
			set{ _c_emp_id=value;}
			get{return _c_emp_id;}
		}
		/// <summary>
		/// 维护时间
		/// </summary>
		public DateTime D_MOD_DT
		{
			set{ _d_mod_dt=value;}
			get{return _d_mod_dt;}
		}
		#endregion Model

	}
}

