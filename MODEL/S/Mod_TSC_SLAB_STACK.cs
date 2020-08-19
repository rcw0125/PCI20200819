using System;
namespace MODEL
{
	/// <summary>
	/// 钢坯倒垛信息
	/// </summary>
	[Serializable]
	public partial class Mod_TSC_SLAB_STACK
	{
		public Mod_TSC_SLAB_STACK()
		{}
		#region Model
		private string _c_id;
		private string _c_slab_main_id;
		private string _c_sta_id;
		private string _c_stove;
		private string _c_stl_grd;
		private string _c_spec;
		private decimal? _n_len;
		private string _c_std_code;
		private string _c_mat_code;
		private string _c_mat_name;
		private decimal? _n_wgt;
		private string _c_stock_code_old;
		private string _c_area_code_old;
		private string _c_kw_code_old;
		private string _c_flood_code_old;
		private string _c_stock_code_new;
		private string _c_area_code_new;
		private string _c_kw_code_new;
		private string _c_flood_code_new;
		private decimal _n_qua=1;
		private DateTime? _d_stack_date;
		private string _c_stack_group;
		private string _c_stack_shift;
		private string _c_stack_emp_id;
		private decimal _n_status=1;
		private string _c_remark;
        private string _c_batch_no;
        /// <summary>
        /// 主键
        /// </summary>
        public string C_ID
		{
			set{ _c_id=value;}
			get{return _c_id;}
		}
		/// <summary>
		/// TSC_SLAB_MAIN主键
		/// </summary>
		public string C_SLAB_MAIN_ID
		{
			set{ _c_slab_main_id=value;}
			get{return _c_slab_main_id;}
		}
		/// <summary>
		/// 铸机
		/// </summary>
		public string C_STA_ID
		{
			set{ _c_sta_id=value;}
			get{return _c_sta_id;}
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
		/// 钢种
		/// </summary>
		public string C_STL_GRD
		{
			set{ _c_stl_grd=value;}
			get{return _c_stl_grd;}
		}
		/// <summary>
		/// 规格 
		/// </summary>
		public string C_SPEC
		{
			set{ _c_spec=value;}
			get{return _c_spec;}
		}
		/// <summary>
		/// 长度 mm
		/// </summary>
		public decimal? N_LEN
		{
			set{ _n_len=value;}
			get{return _n_len;}
		}
		/// <summary>
		/// 执行标准
		/// </summary>
		public string C_STD_CODE
		{
			set{ _c_std_code=value;}
			get{return _c_std_code;}
		}
		/// <summary>
		/// 物料编码 
		/// </summary>
		public string C_MAT_CODE
		{
			set{ _c_mat_code=value;}
			get{return _c_mat_code;}
		}
		/// <summary>
		/// 物料名称
		/// </summary>
		public string C_MAT_NAME
		{
			set{ _c_mat_name=value;}
			get{return _c_mat_name;}
		}
		/// <summary>
		/// 单重
		/// </summary>
		public decimal? N_WGT
		{
			set{ _n_wgt=value;}
			get{return _n_wgt;}
		}
		/// <summary>
		/// 原仓库
		/// </summary>
		public string C_STOCK_CODE_OLD
		{
			set{ _c_stock_code_old=value;}
			get{return _c_stock_code_old;}
		}
		/// <summary>
		/// 原区域
		/// </summary>
		public string C_AREA_CODE_OLD
		{
			set{ _c_area_code_old=value;}
			get{return _c_area_code_old;}
		}
		/// <summary>
		/// 原库位
		/// </summary>
		public string C_KW_CODE_OLD
		{
			set{ _c_kw_code_old=value;}
			get{return _c_kw_code_old;}
		}
		/// <summary>
		/// 原层
		/// </summary>
		public string C_FLOOD_CODE_OLD
		{
			set{ _c_flood_code_old=value;}
			get{return _c_flood_code_old;}
		}
		/// <summary>
		/// 新仓库
		/// </summary>
		public string C_STOCK_CODE_NEW
		{
			set{ _c_stock_code_new=value;}
			get{return _c_stock_code_new;}
		}
		/// <summary>
		/// 新区域
		/// </summary>
		public string C_AREA_CODE_NEW
		{
			set{ _c_area_code_new=value;}
			get{return _c_area_code_new;}
		}
		/// <summary>
		/// 新库位
		/// </summary>
		public string C_KW_CODE_NEW
		{
			set{ _c_kw_code_new=value;}
			get{return _c_kw_code_new;}
		}
		/// <summary>
		/// 新层
		/// </summary>
		public string C_FLOOD_CODE_NEW
		{
			set{ _c_flood_code_new=value;}
			get{return _c_flood_code_new;}
		}
		/// <summary>
		/// 支数
		/// </summary>
		public decimal N_QUA
		{
			set{ _n_qua=value;}
			get{return _n_qua;}
		}
		/// <summary>
		/// 倒垛时间
		/// </summary>
		public DateTime? D_STACK_DATE
		{
			set{ _d_stack_date=value;}
			get{return _d_stack_date;}
		}
		/// <summary>
		/// 倒垛班组
		/// </summary>
		public string C_STACK_GROUP
		{
			set{ _c_stack_group=value;}
			get{return _c_stack_group;}
		}
		/// <summary>
		/// 倒垛班次
		/// </summary>
		public string C_STACK_SHIFT
		{
			set{ _c_stack_shift=value;}
			get{return _c_stack_shift;}
		}
		/// <summary>
		/// 倒垛人
		/// </summary>
		public string C_STACK_EMP_ID
		{
			set{ _c_stack_emp_id=value;}
			get{return _c_stack_emp_id;}
		}
		/// <summary>
		/// 使用状态   1-可用；0-停用
		/// </summary>
		public decimal N_STATUS
		{
			set{ _n_status=value;}
			get{return _n_status;}
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
		/// 开坯号
		/// </summary>
		public string C_BATCH_NO
        {
            set { _c_batch_no = value; }
            get { return _c_batch_no; }
        }
        #endregion Model

    }
}

