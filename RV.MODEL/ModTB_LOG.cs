using System;
namespace RV.MODEL
{
	/// <summary>
	/// 操作日志表
	/// </summary>
	[Serializable]
	public partial class ModTB_LOG
	{
		public ModTB_LOG()
		{}
		#region Model
		private string _c_id;
		private string _c_ip;
		private string _c_modules;
		private string _c_menu_name;
		private string _c_forms_name;
		private string _c_forms_desc;
		private string _c_oper_context;
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
		/// IP
		/// </summary>
		public string C_IP
		{
			set{ _c_ip=value;}
			get{return _c_ip;}
		}
		/// <summary>
		/// 模块
		/// </summary>
		public string C_MODULES
		{
			set{ _c_modules=value;}
			get{return _c_modules;}
		}
		/// <summary>
		/// 菜单名
		/// </summary>
		public string C_MENU_NAME
		{
			set{ _c_menu_name=value;}
			get{return _c_menu_name;}
		}
		/// <summary>
		/// 窗体名
		/// </summary>
		public string C_FORMS_NAME
		{
			set{ _c_forms_name=value;}
			get{return _c_forms_name;}
		}
		/// <summary>
		/// 窗体描述
		/// </summary>
		public string C_FORMS_DESC
		{
			set{ _c_forms_desc=value;}
			get{return _c_forms_desc;}
		}
		/// <summary>
		/// 操作内容
		/// </summary>
		public string C_OPER_CONTEXT
		{
			set{ _c_oper_context=value;}
			get{return _c_oper_context;}
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
		#endregion Model

	}
}

