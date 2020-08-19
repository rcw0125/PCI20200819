using System;
namespace MODEL
{
    /// <summary>
    /// 订单评价日志
    /// </summary>
    [Serializable]
	public partial class Mod_TMO_ORDER_PJ_LOG
	{
		public Mod_TMO_ORDER_PJ_LOG()
		{}
		#region Model
		private string _c_id= "sys_guid";
		private string _c_type;
		private string _c_result;
		private string _c_msg;
		private DateTime _d_mod_dt= Convert.ToDateTime(DateTime.Now);
		private string _c_order_no;
		private string _c_emp_id;
		/// <summary>
		/// 主键
		/// </summary>
		public string C_ID
		{
			set{ _c_id=value;}
			get{return _c_id;}
		}
		/// <summary>
		/// 类型：人工/系统
		/// </summary>
		public string C_TYPE
		{
			set{ _c_type=value;}
			get{return _c_type;}
		}
		/// <summary>
		/// 评价结果：成功/失败
		/// </summary>
		public string C_RESULT
		{
			set{ _c_result=value;}
			get{return _c_result;}
		}
		/// <summary>
		/// 提示信息
		/// </summary>
		public string C_MSG
		{
			set{ _c_msg=value;}
			get{return _c_msg;}
		}
		/// <summary>
		/// 系统时间
		/// </summary>
		public DateTime D_MOD_DT
		{
			set{ _d_mod_dt=value;}
			get{return _d_mod_dt;}
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
		/// 操作人
		/// </summary>
		public string C_EMP_ID
		{
			set{ _c_emp_id=value;}
			get{return _c_emp_id;}
		}
		#endregion Model

	}
}

