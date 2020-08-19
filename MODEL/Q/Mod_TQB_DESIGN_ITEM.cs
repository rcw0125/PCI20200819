using System;
namespace MODEL
{
    /// <summary>
    /// 质量设计明细
    /// </summary>
    [Serializable]
	public partial class Mod_TQB_DESIGN_ITEM
	{
		public Mod_TQB_DESIGN_ITEM()
		{}
		#region Model
		private string _c_id= "sys_guid";
		private string _c_design_id;
		private string _c_character_id;
		private string _c_target_min;
		private string _c_target_interval;
		private string _c_target_max;
		private string _c_prewarning_value;
		private string _c_type;
		private string _c_is_decide;
		private string _c_is_print;
		private decimal? _n_print_order;
		private decimal? _n_spec_min;
		private string _c_spec_interval;
		private decimal? _n_spec_max;
		private string _c_formula;
		private string _c_unit;
		private decimal? _n_digit;
		private string _c_quantitative;
		private string _c_test_tem;
		private string _c_test_condition;
		private decimal _n_status=1 ;
		private string _c_remark;
		private string _c_emp_id;
		private DateTime _d_mod_dt= Convert.ToDateTime(DateTime.Now);
		/// <summary>
		/// 主键
		/// </summary>
		public string C_ID
		{
			set{ _c_id=value;}
			get{return _c_id;}
		}
		/// <summary>
		/// 质量设计主键
		/// </summary>
		public string C_DESIGN_ID
		{
			set{ _c_design_id=value;}
			get{return _c_design_id;}
		}
		/// <summary>
		/// 检验基础数据外键
		/// </summary>
		public string C_CHARACTER_ID
		{
			set{ _c_character_id=value;}
			get{return _c_character_id;}
		}
		/// <summary>
		/// 目标最小值
		/// </summary>
		public string C_TARGET_MIN
		{
			set{ _c_target_min=value;}
			get{return _c_target_min;}
		}
		/// <summary>
		/// 目标值区间
		/// </summary>
		public string C_TARGET_INTERVAL
		{
			set{ _c_target_interval=value;}
			get{return _c_target_interval;}
		}
		/// <summary>
		/// 目标最大值
		/// </summary>
		public string C_TARGET_MAX
		{
			set{ _c_target_max=value;}
			get{return _c_target_max;}
		}
		/// <summary>
		/// 预警值
		/// </summary>
		public string C_PREWARNING_VALUE
		{
			set{ _c_prewarning_value=value;}
			get{return _c_prewarning_value;}
		}
		/// <summary>
		/// 项目类型
		/// </summary>
		public string C_TYPE
		{
			set{ _c_type=value;}
			get{return _c_type;}
		}
		/// <summary>
		/// 是否判定
		/// </summary>
		public string C_IS_DECIDE
		{
			set{ _c_is_decide=value;}
			get{return _c_is_decide;}
		}
		/// <summary>
		/// 是否打印
		/// </summary>
		public string C_IS_PRINT
		{
			set{ _c_is_print=value;}
			get{return _c_is_print;}
		}
		/// <summary>
		/// 打印顺序
		/// </summary>
		public decimal? N_PRINT_ORDER
		{
			set{ _n_print_order=value;}
			get{return _n_print_order;}
		}
		/// <summary>
		/// 规格最小值
		/// </summary>
		public decimal? N_SPEC_MIN
		{
			set{ _n_spec_min=value;}
			get{return _n_spec_min;}
		}
		/// <summary>
		/// 规格区间
		/// </summary>
		public string C_SPEC_INTERVAL
		{
			set{ _c_spec_interval=value;}
			get{return _c_spec_interval;}
		}
		/// <summary>
		/// 规格最大值
		/// </summary>
		public decimal? N_SPEC_MAX
		{
			set{ _n_spec_max=value;}
			get{return _n_spec_max;}
		}
		/// <summary>
		/// 计算公式
		/// </summary>
		public string C_FORMULA
		{
			set{ _c_formula=value;}
			get{return _c_formula;}
		}
		/// <summary>
		/// 单位(种类)
		/// </summary>
		public string C_UNIT
		{
			set{ _c_unit=value;}
			get{return _c_unit;}
		}
		/// <summary>
		/// 小数位数
		/// </summary>
		public decimal? N_DIGIT
		{
			set{ _n_digit=value;}
			get{return _n_digit;}
		}
		/// <summary>
		/// 定性/定量
		/// </summary>
		public string C_QUANTITATIVE
		{
			set{ _c_quantitative=value;}
			get{return _c_quantitative;}
		}
		/// <summary>
		/// 实验温度
		/// </summary>
		public string C_TEST_TEM
		{
			set{ _c_test_tem=value;}
			get{return _c_test_tem;}
		}
		/// <summary>
		/// 实验条件
		/// </summary>
		public string C_TEST_CONDITION
		{
			set{ _c_test_condition=value;}
			get{return _c_test_condition;}
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

