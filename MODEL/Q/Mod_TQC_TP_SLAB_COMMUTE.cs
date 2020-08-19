using System;
namespace MODEL
{
    /// <summary>
    /// 挑坯改判
    /// </summary>
    [Serializable]
	public partial class Mod_TQC_TP_SLAB_COMMUTE
	{
		public Mod_TQC_TP_SLAB_COMMUTE()
		{}
		#region Model
		private string _c_id;
		private string _c_slab_main_id;
		private string _c_sta_id;
		private string _c_stove;
		private string _c_batch_no;
		private decimal? _n_wgt;
		private decimal? _n_len_before;
		private decimal? _n_len_after;
		private string _c_stl_grd_before;
		private string _c_std_code_before;
		private string _c_spec_before;
		private string _c_mat_code_before;
		private string _c_mat_desc_before;
		private string _c_stl_grd_after;
		private string _c_std_code_after;
		private string _c_spec_after;
		private string _c_mat_code_after;
		private string _c_mat_desc_after;
		private string _c_reason_depmt_id;
		private string _c_reason_depmt_desc;
		private string _c_zyx1_before;
		private string _c_zyx2_before;
		private string _c_zyx1_after;
		private string _c_zyx2_after;
		private string _c_judge_lev_bp_before;
		private string _c_judge_lev_bp_after;
		private string _c_emp_id;
		private DateTime _d_mod_dt= Convert.ToDateTime(DateTime.Now);
		private string _c_commute_sq;
		private string _c_check_zkb;
		private string _c_zkb_emp_id;
		private DateTime? _d_check_zkb_date;
		private string _c_czyj_zkb;
		private string _c_check_xc;
		private string _c_xc_emp_id;
		private DateTime? _d_check_xc_date;
		private string _c_czyj_xc;
		private string _c_check_lg;
		private string _c_lg_emp_id;
		private DateTime? _d_check_lg_date;
		private string _c_czyj_lg;
		private string _c_check_jszx;
		private string _c_jszx_emp_id;
		private DateTime? _d_check_jszx_date;
		private string _c_czyj_jszx;
		private string _c_commute_reason;
		private DateTime? _d_commute_date;
		private decimal? _n_is_sh;
		private decimal _n_status=1 ;
		private string _c_remark;
		private string _c_remark1;
		private string _c_remark2;
		private string _c_remark3;
		/// <summary>
		/// 主键
		/// </summary>
		public string C_ID
		{
			set{ _c_id=value;}
			get{return _c_id;}
		}
		/// <summary>
		/// 钢坯实绩表外键
		/// </summary>
		public string C_SLAB_MAIN_ID
		{
			set{ _c_slab_main_id=value;}
			get{return _c_slab_main_id;}
		}
		/// <summary>
		/// 铸机号
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
		/// 批号
		/// </summary>
		public string C_BATCH_NO
		{
			set{ _c_batch_no=value;}
			get{return _c_batch_no;}
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
		/// 改判前定尺
		/// </summary>
		public decimal? N_LEN_BEFORE
		{
			set{ _n_len_before=value;}
			get{return _n_len_before;}
		}
		/// <summary>
		/// 改判后定尺
		/// </summary>
		public decimal? N_LEN_AFTER
		{
			set{ _n_len_after=value;}
			get{return _n_len_after;}
		}
		/// <summary>
		/// 改判前钢种
		/// </summary>
		public string C_STL_GRD_BEFORE
		{
			set{ _c_stl_grd_before=value;}
			get{return _c_stl_grd_before;}
		}
		/// <summary>
		/// 改判前标准
		/// </summary>
		public string C_STD_CODE_BEFORE
		{
			set{ _c_std_code_before=value;}
			get{return _c_std_code_before;}
		}
		/// <summary>
		/// 改判前断面
		/// </summary>
		public string C_SPEC_BEFORE
		{
			set{ _c_spec_before=value;}
			get{return _c_spec_before;}
		}
		/// <summary>
		/// 改判前物料编码
		/// </summary>
		public string C_MAT_CODE_BEFORE
		{
			set{ _c_mat_code_before=value;}
			get{return _c_mat_code_before;}
		}
		/// <summary>
		/// 改判前物料描述
		/// </summary>
		public string C_MAT_DESC_BEFORE
		{
			set{ _c_mat_desc_before=value;}
			get{return _c_mat_desc_before;}
		}
		/// <summary>
		/// 改判后钢种
		/// </summary>
		public string C_STL_GRD_AFTER
		{
			set{ _c_stl_grd_after=value;}
			get{return _c_stl_grd_after;}
		}
		/// <summary>
		/// 改判后标准
		/// </summary>
		public string C_STD_CODE_AFTER
		{
			set{ _c_std_code_after=value;}
			get{return _c_std_code_after;}
		}
		/// <summary>
		/// 改判后断面
		/// </summary>
		public string C_SPEC_AFTER
		{
			set{ _c_spec_after=value;}
			get{return _c_spec_after;}
		}
		/// <summary>
		/// 改判后物料编码
		/// </summary>
		public string C_MAT_CODE_AFTER
		{
			set{ _c_mat_code_after=value;}
			get{return _c_mat_code_after;}
		}
		/// <summary>
		/// 改判后物料描述
		/// </summary>
		public string C_MAT_DESC_AFTER
		{
			set{ _c_mat_desc_after=value;}
			get{return _c_mat_desc_after;}
		}
		/// <summary>
		/// 责任单位代码
		/// </summary>
		public string C_REASON_DEPMT_ID
		{
			set{ _c_reason_depmt_id=value;}
			get{return _c_reason_depmt_id;}
		}
		/// <summary>
		/// 责任单位描述
		/// </summary>
		public string C_REASON_DEPMT_DESC
		{
			set{ _c_reason_depmt_desc=value;}
			get{return _c_reason_depmt_desc;}
		}
		/// <summary>
		/// 改判前自由项1
		/// </summary>
		public string C_ZYX1_BEFORE
		{
			set{ _c_zyx1_before=value;}
			get{return _c_zyx1_before;}
		}
		/// <summary>
		/// 改判前自由项2
		/// </summary>
		public string C_ZYX2_BEFORE
		{
			set{ _c_zyx2_before=value;}
			get{return _c_zyx2_before;}
		}
		/// <summary>
		/// 改判后自由项1
		/// </summary>
		public string C_ZYX1_AFTER
		{
			set{ _c_zyx1_after=value;}
			get{return _c_zyx1_after;}
		}
		/// <summary>
		/// 改判后自由项2
		/// </summary>
		public string C_ZYX2_AFTER
		{
			set{ _c_zyx2_after=value;}
			get{return _c_zyx2_after;}
		}
		/// <summary>
		/// 改判前判定等级
		/// </summary>
		public string C_JUDGE_LEV_BP_BEFORE
		{
			set{ _c_judge_lev_bp_before=value;}
			get{return _c_judge_lev_bp_before;}
		}
		/// <summary>
		/// 改判后判定等级
		/// </summary>
		public string C_JUDGE_LEV_BP_AFTER
		{
			set{ _c_judge_lev_bp_after=value;}
			get{return _c_judge_lev_bp_after;}
		}
		/// <summary>
		/// 改判申请人
		/// </summary>
		public string C_EMP_ID
		{
			set{ _c_emp_id=value;}
			get{return _c_emp_id;}
		}
		/// <summary>
		/// 改判申请时间
		/// </summary>
		public DateTime D_MOD_DT
		{
			set{ _d_mod_dt=value;}
			get{return _d_mod_dt;}
		}
		/// <summary>
		/// 改判申请原因
		/// </summary>
		public string C_COMMUTE_SQ
		{
			set{ _c_commute_sq=value;}
			get{return _c_commute_sq;}
		}
		/// <summary>
		/// 质控部审核状态 Y:确认 ，N:未确认
		/// </summary>
		public string C_CHECK_ZKB
		{
			set{ _c_check_zkb=value;}
			get{return _c_check_zkb;}
		}
		/// <summary>
		/// 质控部审核人
		/// </summary>
		public string C_ZKB_EMP_ID
		{
			set{ _c_zkb_emp_id=value;}
			get{return _c_zkb_emp_id;}
		}
		/// <summary>
		/// 质控部审核时间
		/// </summary>
		public DateTime? D_CHECK_ZKB_DATE
		{
			set{ _d_check_zkb_date=value;}
			get{return _d_check_zkb_date;}
		}
		/// <summary>
		/// 质控部处置意见
		/// </summary>
		public string C_CZYJ_ZKB
		{
			set{ _c_czyj_zkb=value;}
			get{return _c_czyj_zkb;}
		}
		/// <summary>
		/// 线材厂审核状态 Y:确认 ，N:未确认
		/// </summary>
		public string C_CHECK_XC
		{
			set{ _c_check_xc=value;}
			get{return _c_check_xc;}
		}
		/// <summary>
		/// 线材厂审核人
		/// </summary>
		public string C_XC_EMP_ID
		{
			set{ _c_xc_emp_id=value;}
			get{return _c_xc_emp_id;}
		}
		/// <summary>
		/// 线材厂审核时间
		/// </summary>
		public DateTime? D_CHECK_XC_DATE
		{
			set{ _d_check_xc_date=value;}
			get{return _d_check_xc_date;}
		}
		/// <summary>
		/// 线材厂处置意见
		/// </summary>
		public string C_CZYJ_XC
		{
			set{ _c_czyj_xc=value;}
			get{return _c_czyj_xc;}
		}
		/// <summary>
		/// 炼钢厂审核状态 Y:确认 ，N:未确认
		/// </summary>
		public string C_CHECK_LG
		{
			set{ _c_check_lg=value;}
			get{return _c_check_lg;}
		}
		/// <summary>
		/// 炼钢厂审核人
		/// </summary>
		public string C_LG_EMP_ID
		{
			set{ _c_lg_emp_id=value;}
			get{return _c_lg_emp_id;}
		}
		/// <summary>
		/// 炼钢厂审核时间
		/// </summary>
		public DateTime? D_CHECK_LG_DATE
		{
			set{ _d_check_lg_date=value;}
			get{return _d_check_lg_date;}
		}
		/// <summary>
		/// 炼钢厂处置意见
		/// </summary>
		public string C_CZYJ_LG
		{
			set{ _c_czyj_lg=value;}
			get{return _c_czyj_lg;}
		}
		/// <summary>
		/// 技术中心审核状态 Y:确认 ，N:未确认
		/// </summary>
		public string C_CHECK_JSZX
		{
			set{ _c_check_jszx=value;}
			get{return _c_check_jszx;}
		}
		/// <summary>
		/// 技术中心审核人
		/// </summary>
		public string C_JSZX_EMP_ID
		{
			set{ _c_jszx_emp_id=value;}
			get{return _c_jszx_emp_id;}
		}
		/// <summary>
		/// 技术中心审核时间
		/// </summary>
		public DateTime? D_CHECK_JSZX_DATE
		{
			set{ _d_check_jszx_date=value;}
			get{return _d_check_jszx_date;}
		}
		/// <summary>
		/// 技术中心处置意见
		/// </summary>
		public string C_CZYJ_JSZX
		{
			set{ _c_czyj_jszx=value;}
			get{return _c_czyj_jszx;}
		}
		/// <summary>
		/// 改判原因
		/// </summary>
		public string C_COMMUTE_REASON
		{
			set{ _c_commute_reason=value;}
			get{return _c_commute_reason;}
		}
		/// <summary>
		/// 改判时间
		/// </summary>
		public DateTime? D_COMMUTE_DATE
		{
			set{ _d_commute_date=value;}
			get{return _d_commute_date;}
		}
		/// <summary>
		/// 是否审核   1-审核；0-不审核
		/// </summary>
		public decimal? N_IS_SH
		{
			set{ _n_is_sh=value;}
			get{return _n_is_sh;}
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
		/// 改判人
		/// </summary>
		public string C_REMARK1
		{
			set{ _c_remark1=value;}
			get{return _c_remark1;}
		}
		/// <summary>
		/// 库存状态
		/// </summary>
		public string C_REMARK2
		{
			set{ _c_remark2=value;}
			get{return _c_remark2;}
		}
		/// <summary>
		/// 仓库
		/// </summary>
		public string C_REMARK3
		{
			set{ _c_remark3=value;}
			get{return _c_remark3;}
		}
		#endregion Model

	}
}

