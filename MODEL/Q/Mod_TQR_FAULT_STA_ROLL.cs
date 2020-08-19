using System;
namespace MODEL
{
	/// <summary>
	/// 不合格统计明细(线材)
	/// </summary>
	[Serializable]
	public partial class Mod_TQR_FAULT_STA_ROLL
	{
		public Mod_TQR_FAULT_STA_ROLL()
		{}
		#region Model
		private string _c_id;
		private string _c_batch_no;
		private string _c_stove;
		private string _c_stl_grd;
		private string _c_spec;
		private string _c_mat_name;
		private string _c_std_code;
		private string _c_test_quantity;
		private string _c_face_fault_qua;
		private string _c_face_dis_qua;
		private string _c_face_fault_cause;
		private string _c_face_duty_dep;
		private string _c_pro_test_fault_qua;
		private string _c_pro_test_fault_name;
		private string _c_recheck_fault_name;
		private string _c_warehouse_qua;
		private string _c_war_fault_cause;
		private string _c_war_duty_dep;
		private string _c_alter_decide_num;
		private string _c_alter_decide_cause;
		private string _c_alter_decide_dep;
		private decimal _n_status=1;
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
		/// 批号
		/// </summary>
		public string C_BATCH_NO
		{
			set{ _c_batch_no=value;}
			get{return _c_batch_no;}
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
		/// 物料名称
		/// </summary>
		public string C_MAT_NAME
		{
			set{ _c_mat_name=value;}
			get{return _c_mat_name;}
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
		/// 检验量
		/// </summary>
		public string C_TEST_QUANTITY
		{
			set{ _c_test_quantity=value;}
			get{return _c_test_quantity;}
		}
		/// <summary>
		/// 表面不合格量
		/// </summary>
		public string C_FACE_FAULT_QUA
		{
			set{ _c_face_fault_qua=value;}
			get{return _c_face_fault_qua;}
		}
		/// <summary>
		/// 表面废品量
		/// </summary>
		public string C_FACE_DIS_QUA
		{
			set{ _c_face_dis_qua=value;}
			get{return _c_face_dis_qua;}
		}
		/// <summary>
		/// 表面不合格原因
		/// </summary>
		public string C_FACE_FAULT_CAUSE
		{
			set{ _c_face_fault_cause=value;}
			get{return _c_face_fault_cause;}
		}
		/// <summary>
		/// 表面责任部门
		/// </summary>
		public string C_FACE_DUTY_DEP
		{
			set{ _c_face_duty_dep=value;}
			get{return _c_face_duty_dep;}
		}
		/// <summary>
		/// 性能初检不合格量
		/// </summary>
		public string C_PRO_TEST_FAULT_QUA
		{
			set{ _c_pro_test_fault_qua=value;}
			get{return _c_pro_test_fault_qua;}
		}
		/// <summary>
		/// 性能初检不合项目
		/// </summary>
		public string C_PRO_TEST_FAULT_NAME
		{
			set{ _c_pro_test_fault_name=value;}
			get{return _c_pro_test_fault_name;}
		}
		/// <summary>
		/// 性能复检不合项目
		/// </summary>
		public string C_RECHECK_FAULT_NAME
		{
			set{ _c_recheck_fault_name=value;}
			get{return _c_recheck_fault_name;}
		}
		/// <summary>
		/// 库检量
		/// </summary>
		public string C_WAREHOUSE_QUA
		{
			set{ _c_warehouse_qua=value;}
			get{return _c_warehouse_qua;}
		}
		/// <summary>
		/// 库检不合格原因明细
		/// </summary>
		public string C_WAR_FAULT_CAUSE
		{
			set{ _c_war_fault_cause=value;}
			get{return _c_war_fault_cause;}
		}
		/// <summary>
		/// 库检责任部门
		/// </summary>
		public string C_WAR_DUTY_DEP
		{
			set{ _c_war_duty_dep=value;}
			get{return _c_war_duty_dep;}
		}
		/// <summary>
		/// 改判量
		/// </summary>
		public string C_ALTER_DECIDE_NUM
		{
			set{ _c_alter_decide_num=value;}
			get{return _c_alter_decide_num;}
		}
		/// <summary>
		/// 改判原因
		/// </summary>
		public string C_ALTER_DECIDE_CAUSE
		{
			set{ _c_alter_decide_cause=value;}
			get{return _c_alter_decide_cause;}
		}
		/// <summary>
		/// 改判责任部门
		/// </summary>
		public string C_ALTER_DECIDE_DEP
		{
			set{ _c_alter_decide_dep=value;}
			get{return _c_alter_decide_dep;}
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

