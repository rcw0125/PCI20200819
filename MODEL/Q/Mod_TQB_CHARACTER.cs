using System;
namespace MODEL
{
	/// <summary>
	/// 检验基础数据
	/// </summary>
	[Serializable]
	public partial class Mod_TQB_CHARACTER
	{
		public Mod_TQB_CHARACTER()
		{}
		#region Model
		private string _c_id;
		private string _c_type_id;
		private string _c_code;
		private string _c_name;
		private string _c_unit;
		private string _c_digit;
		private string _c_book_show;
		private string _c_formula;
		private string _c_quantitative;
        private decimal _n_status = 1;
		private string _c_remark;
		private string _c_emp_id;
		private DateTime _d_mod_dt= Convert.ToDateTime(DateTime.Now);
        private decimal _n_order;
		/// <summary>
		/// 主键
		/// </summary>
		public string C_ID
		{
			set{ _c_id=value;}
			get{return _c_id;}
		}
		/// <summary>
		/// 检验类别表主键
		/// </summary>
		public string C_TYPE_ID
		{
			set{ _c_type_id=value;}
			get{return _c_type_id;}
		}
		/// <summary>
		/// 项目代码
		/// </summary>
		public string C_CODE
		{
			set{ _c_code=value;}
			get{return _c_code;}
		}
		/// <summary>
		/// 项目名称
		/// </summary>
		public string C_NAME
		{
			set{ _c_name=value;}
			get{return _c_name;}
		}
		/// <summary>
		/// 单位
		/// </summary>
		public string C_UNIT
		{
			set{ _c_unit=value;}
			get{return _c_unit;}
		}
		/// <summary>
		/// 小数位数
		/// </summary>
		public string C_DIGIT
		{
			set{ _c_digit=value;}
			get{return _c_digit;}
		}
		/// <summary>
		/// 质证书显示
		/// </summary>
		public string C_BOOK_SHOW
		{
			set{ _c_book_show=value;}
			get{return _c_book_show;}
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
		/// 定性/定量
		/// </summary>
		public string C_QUANTITATIVE
		{
			set{ _c_quantitative=value;}
			get{return _c_quantitative;}
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
        /// <summary>
		/// 顺序号
		/// </summary>
		public decimal N_ORDER
        {
            set { _n_order = value; }
            get { return _n_order; }
        }
        #endregion Model

    }
}

