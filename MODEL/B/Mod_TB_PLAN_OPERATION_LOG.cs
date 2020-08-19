using System;
namespace MODEL
{
	/// <summary>
	/// 存储过程日志表
	/// </summary>
	[Serializable]
	public partial class Mod_TB_PLAN_OPERATION_LOG
    {
		public Mod_TB_PLAN_OPERATION_LOG()
		{}
        #region Model
        private string _c_id = System.Guid.NewGuid().ToString();
		private string _c_operation;
		private string _c_function;
        private DateTime _d_mod_dt = System.DateTime.Now;
		private string _c_emp_id;
        private string _c_cp_ip;
        private string _c_cp_name;
        private string _c_order_no;
        private string _c_plan_id;
        /// <summary>
        /// 主键
        /// </summary>
        public string C_ID
		{
			set{ _c_id=value;}
			get{return _c_id;}
		}
		/// <summary>
		/// 操作描述
		/// </summary>
		public string C_OPERATION
		{
			set{ _c_operation=value;}
			get{return _c_operation;}
		}
		/// <summary>
		/// 功能描述
		/// </summary>
		public string C_FUNCTION
		{
			set{ _c_function=value;}
			get{return _c_function;}
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
		/// 操作人
		/// </summary>
		public string C_EMP_ID
		{
			set{ _c_emp_id=value;}
			get{return _c_emp_id;}
		}
        /// <summary>
		/// 更新ip
		/// </summary>
		public string C_CP_IP
        {
            set { _c_cp_ip = value; }
            get { return _c_cp_ip; }
        }
        /// <summary>
        /// 更新电脑
        /// </summary>
        public string C_CP_NAME
        {
            set { _c_cp_name = value; }
            get { return _c_cp_name; }
        }
        /// <summary>
		/// 订单号
		/// </summary>
		public string C_ORDER_NO
        {
            set { _c_order_no = value; }
            get { return _c_order_no; }
        }
        /// <summary>
		/// 计划表主键
		/// </summary>
		public string C_PLAN_ID
        {
            set { _c_plan_id = value; }
            get { return _c_plan_id; }
        }
        #endregion Model

    }
}

