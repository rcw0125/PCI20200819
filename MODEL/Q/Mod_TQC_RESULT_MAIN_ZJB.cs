using System;
namespace MODEL
{
    /// <summary>
    /// 物理性能结果中间表
    /// </summary>
    [Serializable]
	public partial class Mod_TQC_RESULT_MAIN_ZJB
	{
		public Mod_TQC_RESULT_MAIN_ZJB()
		{}
		#region Model
		private string _c_id ;
		private string _c_batch_no;
		private string _c_tick_no;
		private string _c_stl_grd;
		private string _c_spec;
		private string _c_emp_id;
		private DateTime? _d_mod_dt;
		private string _c_emp_id_zy;
		private DateTime? _d_mod_dt_zy;
		private string _c_emp_id_js;
		private DateTime? _d_mod_dt_js;
		private string _c_physics_group_id;
		private string _c_check_state;
		private decimal? _n_recheck;
		private decimal _n_status=1  ;
		private string _c_remark;
		private string _c_disposal;   
        private string _c_qrzt;
        private string _c_item_name; 
        /// <summary>
        /// 主键
        /// </summary>
        public string C_ID
		{
			set{ _c_id=value;}
			get{return _c_id;}
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
		/// 规格
		/// </summary>
		public string C_SPEC
		{
			set{ _c_spec=value;}
			get{return _c_spec;}
		}
		/// <summary>
		/// 送样人
		/// </summary>
		public string C_EMP_ID
		{
			set{ _c_emp_id=value;}
			get{return _c_emp_id;}
		}
		/// <summary>
		/// 送样时间
		/// </summary>
		public DateTime? D_MOD_DT
		{
			set{ _d_mod_dt=value;}
			get{return _d_mod_dt;}
		}
		/// <summary>
		/// 制样人
		/// </summary>
		public string C_EMP_ID_ZY
		{
			set{ _c_emp_id_zy=value;}
			get{return _c_emp_id_zy;}
		}
		/// <summary>
		/// 制样时间
		/// </summary>
		public DateTime? D_MOD_DT_ZY
		{
			set{ _d_mod_dt_zy=value;}
			get{return _d_mod_dt_zy;}
		}
		/// <summary>
		/// 样品接收人
		/// </summary>
		public string C_EMP_ID_JS
		{
			set{ _c_emp_id_js=value;}
			get{return _c_emp_id_js;}
		}
		/// <summary>
		/// 样品接收时间
		/// </summary>
		public DateTime? D_MOD_DT_JS
		{
			set{ _d_mod_dt_js=value;}
			get{return _d_mod_dt_js;}
		}
		/// <summary>
		/// 物理性能外键
		/// </summary>
		public string C_PHYSICS_GROUP_ID
		{
			set{ _c_physics_group_id=value;}
			get{return _c_physics_group_id;}
		}
		/// <summary>
		///  状态；0-初检；1-复检；2-评审
		/// </summary>
		public string C_CHECK_STATE
		{
			set{ _c_check_state=value;}
			get{return _c_check_state;}
		}
		/// <summary>
		/// 第几次复检
		/// </summary>
		public decimal? N_RECHECK
		{
			set{ _n_recheck=value;}
			get{return _n_recheck;}
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
		/// 处置意见
		/// </summary>
		public string C_DISPOSAL
        {
            set { _c_disposal = value; }
            get { return _c_disposal; }
        }
        /// <summary>
		/// 确认状态
		/// </summary>
		public string C_QRZT
        {
            set { _c_qrzt = value; }
            get { return _c_qrzt; }
        }
        /// <summary>
		/// 项目名称
		/// </summary>
		public string C_ITEM_NAME
        {
            set { _c_item_name = value; }
            get { return _c_item_name; }
        }
        #endregion Model

    }
}

