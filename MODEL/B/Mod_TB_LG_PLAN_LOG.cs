using System;
namespace MODEL
{
	/// <summary>
	/// 炼钢计划操作日志表
	/// </summary>
	[Serializable]
	public partial class Mod_TB_LG_PLAN_LOG
	{
		public Mod_TB_LG_PLAN_LOG()
		{}
		#region Model
		private string _c_id= "sys_guid";
		private string _c_ip;
		private string _c_stove;
		private string _c_plan_id;
		private string _c_order_no;
		private string _c_mes_plan_id;
		private string _c_ld_desc;
		private string _c_lf_desc;
		private string _c_rh_desc;
		private string _c_cc_desc;
		private string _c_emp_id;
		private DateTime _d_mod_dt=DateTime.Now;
		private string _c_remark;
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
		/// 炉号
		/// </summary>
		public string C_STOVE
		{
			set{ _c_stove=value;}
			get{return _c_stove;}
		}
		/// <summary>
		/// tsp_plan_sms主键
		/// </summary>
		public string C_PLAN_ID
		{
			set{ _c_plan_id=value;}
			get{return _c_plan_id;}
		}
		/// <summary>
		/// 订单号
		/// </summary>
		public string C_ORDER_NO
		{
			set{ _c_order_no=value;}
			get{return _c_order_no;}
		}
		/// <summary>
		/// MES计划号
		/// </summary>
		public string C_MES_PLAN_ID
		{
			set{ _c_mes_plan_id=value;}
			get{return _c_mes_plan_id;}
		}
		/// <summary>
		/// 转炉
		/// </summary>
		public string C_LD_DESC
		{
			set{ _c_ld_desc=value;}
			get{return _c_ld_desc;}
		}
		/// <summary>
		/// 精炼
		/// </summary>
		public string C_LF_DESC
		{
			set{ _c_lf_desc=value;}
			get{return _c_lf_desc;}
		}
		/// <summary>
		/// 真空
		/// </summary>
		public string C_RH_DESC
		{
			set{ _c_rh_desc=value;}
			get{return _c_rh_desc;}
		}
		/// <summary>
		/// 连铸
		/// </summary>
		public string C_CC_DESC
		{
			set{ _c_cc_desc=value;}
			get{return _c_cc_desc;}
		}
		/// <summary>
		/// 操作人
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
		/// 下发/撤回
		/// </summary>
		public string C_REMARK
		{
			set{ _c_remark=value;}
			get{return _c_remark;}
		}
		#endregion Model

	}
}

