using System;
namespace MODEL
{
	/// <summary>
	/// 线材库存记录
	/// </summary>
	[Serializable]
	public partial class Mod_TRC_ROLL_STORAGE_LOG
	{
		public Mod_TRC_ROLL_STORAGE_LOG()
		{}
		#region Model
		private string _c_id= "sys_guid";
		private string _c_trc_roll_main_id;
		private string _c_stove;
		private string _c_batch_no;
		private string _c_tick_no;
		private string _c_stl_grd;
		private decimal _n_wgt=0;
		private string _c_std_code;
		private string _c_move_type="N";
		private string _c_spec;
		private string _c_shift;
		private string _c_group;
		private string _c_mat_code;
		private string _c_mat_desc;
		private string _c_linewh_code_before;
		private string _c_linewh_area_code_before;
		private string _c_linewh_loc_code_before;
		private string _c_floor_before;
		private DateTime? _d_storage_dt;
		private string _c_linewh_code_after;
		private string _c_linewh_area_code_after;
		private string _c_linewh_loc_code_after;
		private string _c_floor_after;
		private string _c_sale_area;
		private string _c_transportation;
		private string _c_emp_id;
		private DateTime _d_mod_dt= Convert.ToDateTime(DateTime.Now);
        private decimal _n_status = 1;
        /// <summary>
        /// 主键
        /// </summary>
        public string C_ID
		{
			set{ _c_id=value;}
			get{return _c_id;}
		}
		/// <summary>
		/// 组批表主键
		/// </summary>
		public string C_TRC_ROLL_MAIN_ID
		{
			set{ _c_trc_roll_main_id=value;}
			get{return _c_trc_roll_main_id;}
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
		/// 钩号
		/// </summary>
		public string C_TICK_NO
		{
			set{ _c_tick_no=value;}
			get{return _c_tick_no;}
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
		/// 重量
		/// </summary>
		public decimal N_WGT
		{
			set{ _n_wgt=value;}
			get{return _n_wgt;}
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
		/// 库存状态  'N'待入库， 'E'已入库 ,'S'已销售,'Z'转库
		/// </summary>
		public string C_MOVE_TYPE
		{
			set{ _c_move_type=value;}
			get{return _c_move_type;}
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
		/// 班次
		/// </summary>
		public string C_SHIFT
		{
			set{ _c_shift=value;}
			get{return _c_shift;}
		}
		/// <summary>
		/// 班组
		/// </summary>
		public string C_GROUP
		{
			set{ _c_group=value;}
			get{return _c_group;}
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
		/// 物料描述
		/// </summary>
		public string C_MAT_DESC
		{
			set{ _c_mat_desc=value;}
			get{return _c_mat_desc;}
		}
		/// <summary>
		/// 转库前线材仓库编码
		/// </summary>
		public string C_LINEWH_CODE_BEFORE
		{
			set{ _c_linewh_code_before=value;}
			get{return _c_linewh_code_before;}
		}
		/// <summary>
		/// 转库前线材区域编码
		/// </summary>
		public string C_LINEWH_AREA_CODE_BEFORE
		{
			set{ _c_linewh_area_code_before=value;}
			get{return _c_linewh_area_code_before;}
		}
		/// <summary>
		/// 转库前库位编号
		/// </summary>
		public string C_LINEWH_LOC_CODE_BEFORE
		{
			set{ _c_linewh_loc_code_before=value;}
			get{return _c_linewh_loc_code_before;}
		}
		/// <summary>
		/// 转库前层
		/// </summary>
		public string C_FLOOR_BEFORE
		{
			set{ _c_floor_before=value;}
			get{return _c_floor_before;}
		}
		/// <summary>
		/// 转库时间
		/// </summary>
		public DateTime? D_STORAGE_DT
		{
			set{ _d_storage_dt=value;}
			get{return _d_storage_dt;}
		}
		/// <summary>
		/// 转库后线材仓库编码
		/// </summary>
		public string C_LINEWH_CODE_AFTER
		{
			set{ _c_linewh_code_after=value;}
			get{return _c_linewh_code_after;}
		}
		/// <summary>
		/// 转库后线材区域编码
		/// </summary>
		public string C_LINEWH_AREA_CODE_AFTER
		{
			set{ _c_linewh_area_code_after=value;}
			get{return _c_linewh_area_code_after;}
		}
		/// <summary>
		/// 转库后库位编号
		/// </summary>
		public string C_LINEWH_LOC_CODE_AFTER
		{
			set{ _c_linewh_loc_code_after=value;}
			get{return _c_linewh_loc_code_after;}
		}
		/// <summary>
		/// 转库后层
		/// </summary>
		public string C_FLOOR_AFTER
		{
			set{ _c_floor_after=value;}
			get{return _c_floor_after;}
		}
		/// <summary>
		/// 销售区域
		/// </summary>
		public string C_SALE_AREA
		{
			set{ _c_sale_area=value;}
			get{return _c_sale_area;}
		}
		/// <summary>
		/// 运输方式
		/// </summary>
		public string C_TRANSPORTATION
		{
			set{ _c_transportation=value;}
			get{return _c_transportation;}
		}
		/// <summary>
		/// 操作人员
		/// </summary>
		public string C_EMP_ID
		{
			set{ _c_emp_id=value;}
			get{return _c_emp_id;}
		}
		/// <summary>
		/// 操作时间
		/// </summary>
		public DateTime D_MOD_DT
		{
			set{ _d_mod_dt=value;}
			get{return _d_mod_dt;}
		}

        /// <summary>
        /// 使用状态   1-可用；0-停用
        /// </summary>
        public decimal N_STATUS
        {
            set { _n_status = value; }
            get { return _n_status; }
        }
        #endregion Model

    }
}

