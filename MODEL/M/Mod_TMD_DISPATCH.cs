using System;
namespace MODEL
{
    /// <summary>
    /// 发运单
    /// </summary>
    [Serializable]
    public partial class Mod_TMD_DISPATCH
    {
        public Mod_TMD_DISPATCH()
        { }
        #region Model
        private string _c_id;
        private string _c_plan_id;
        private string _c_gps_no;
        private string _c_no;
        private string _c_con_no;
        private DateTime? _d_disp_dt;
        private string _c_shipvia;
        private string _c_comcar;
        private string _c_path;
        private string _c_path_desc;
        private string _c_send_dept;
        private string _c_business_dept;
        private string _c_business_id;
        private string _c_is_wiresale;
        private decimal? _n_is_export;
        private string _c_lic_pla_no;
        private string _c_atstation;
        private DateTime? _d_approve_dt;
        private DateTime? _d_create_dt;
        private string _c_approve_id;
        private string _c_create_id;
        private string _c_status;
        private string _c_emp_id;
        private string _c_emp_name;
        private DateTime _d_mod_dt = Convert.ToDateTime(DateTime.Now);
        private string _c_guid = "sys_guid";
        private string _c_is_wiresale_id;
        private string _c_remark;
        private string _c_remark2;
        private DateTime? _d_failure;
        /// <summary>
        /// 单据号
        /// </summary>
        public string C_ID
        {
            set { _c_id = value; }
            get { return _c_id; }
        }
        /// <summary>
        /// 日计划主键
        /// </summary>
        public string C_PLAN_ID
        {
            set { _c_plan_id = value; }
            get { return _c_plan_id; }
        }
        /// <summary>
        /// GPS设备号
        /// </summary>
        public string C_GPS_NO
        {
            set { _c_gps_no = value; }
            get { return _c_gps_no; }
        }
        /// <summary>
        /// 订单号
        /// </summary>
        public string C_NO
        {
            set { _c_no = value; }
            get { return _c_no; }
        }
        /// <summary>
        /// 备注
        /// </summary>
        public string C_CON_NO
        {
            set { _c_con_no = value; }
            get { return _c_con_no; }
        }
        /// <summary>
        /// 发运日期
        /// </summary>
        public DateTime? D_DISP_DT
        {
            set { _d_disp_dt = value; }
            get { return _d_disp_dt; }
        }
        /// <summary>
        /// 发运方式
        /// </summary>
        public string C_SHIPVIA
        {
            set { _c_shipvia = value; }
            get { return _c_shipvia; }
        }
        /// <summary>
        /// 承运商
        /// </summary>
        public string C_COMCAR
        {
            set { _c_comcar = value; }
            get { return _c_comcar; }
        }
        /// <summary>
        /// 路线
        /// </summary>
        public string C_PATH
        {
            set { _c_path = value; }
            get { return _c_path; }
        }
        /// <summary>
        /// 路线描述
        /// </summary>
        public string C_PATH_DESC
        {
            set { _c_path_desc = value; }
            get { return _c_path_desc; }
        }
        /// <summary>
        /// 发运组织
        /// </summary>
        public string C_SEND_DEPT
        {
            set { _c_send_dept = value; }
            get { return _c_send_dept; }
        }
        /// <summary>
        /// 业务部门
        /// </summary>
        public string C_BUSINESS_DEPT
        {
            set { _c_business_dept = value; }
            get { return _c_business_dept; }
        }
        /// <summary>
        /// 业务员
        /// </summary>
        public string C_BUSINESS_ID
        {
            set { _c_business_id = value; }
            get { return _c_business_id; }
        }
        /// <summary>
        /// 是否线材销售
        /// </summary>
        public string C_IS_WIRESALE
        {
            set { _c_is_wiresale = value; }
            get { return _c_is_wiresale; }
        }
        /// <summary>
        /// 是否已导出
        /// </summary>
        public decimal? N_IS_EXPORT
        {
            set { _n_is_export = value; }
            get { return _n_is_export; }
        }
        /// <summary>
        /// 车牌号
        /// </summary>
        public string C_LIC_PLA_NO
        {
            set { _c_lic_pla_no = value; }
            get { return _c_lic_pla_no; }
        }
        /// <summary>
        /// 到站
        /// </summary>
        public string C_ATSTATION
        {
            set { _c_atstation = value; }
            get { return _c_atstation; }
        }
        /// <summary>
        /// 发运单审批日期
        /// </summary>
        public DateTime? D_APPROVE_DT
        {
            set { _d_approve_dt = value; }
            get { return _d_approve_dt; }
        }
        /// <summary>
        /// 发运单制单日期
        /// </summary>
        public DateTime? D_CREATE_DT
        {
            set { _d_create_dt = value; }
            get { return _d_create_dt; }
        }
        /// <summary>
        /// 审批人
        /// </summary>
        public string C_APPROVE_ID
        {
            set { _c_approve_id = value; }
            get { return _c_approve_id; }
        }
        /// <summary>
        /// 制单人
        /// </summary>
        public string C_CREATE_ID
        {
            set { _c_create_id = value; }
            get { return _c_create_id; }
        }
        /// <summary>
        /// 发运单状态1金额不足 2上传NC 3上传条码 4上传物流
        /// </summary>
        public string C_STATUS
        {
            set { _c_status = value; }
            get { return _c_status; }
        }
        /// <summary>
        /// 系统操作人编号
        /// </summary>
        public string C_EMP_ID
        {
            set { _c_emp_id = value; }
            get { return _c_emp_id; }
        }
        /// <summary>
        /// 系统操作人姓名
        /// </summary>
        public string C_EMP_NAME
        {
            set { _c_emp_name = value; }
            get { return _c_emp_name; }
        }
        /// <summary>
        /// 系系统操作时间
        /// </summary>
        public DateTime D_MOD_DT
        {
            set { _d_mod_dt = value; }
            get { return _d_mod_dt; }
        }
        /// <summary>
        /// 主键
        /// </summary>
        public string C_GUID
        {
            set { _c_guid = value; }
            get { return _c_guid; }
        }
        /// <summary>
        /// 是否线材销售
        /// </summary>
        public string C_IS_WIRESALE_ID
        {
            set { _c_is_wiresale_id = value; }
            get { return _c_is_wiresale_id; }
        }
        /// <summary>
        /// 备注
        /// </summary>
        public string C_REMARK
        {
            set { _c_remark = value; }
            get { return _c_remark; }
        }
        /// <summary>
        /// 备注2
        /// </summary>
        public string C_REMARK2
        {
            set { _c_remark2 = value; }
            get { return _c_remark2; }
        }
        /// <summary>
        /// 失效时间
        /// </summary>
        public DateTime? D_FAILURE
        {
            set { _d_failure = value; }
            get { return _d_failure; }
        }
        #endregion Model

    }
}
