using System;
namespace MODEL
{
    /// <summary>
    /// TPP_INITIALIZE_ORDER:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
	public partial class Mod_TPP_INITIALIZE_ORDER
	{
		public Mod_TPP_INITIALIZE_ORDER()
		{}
        #region Model
        private string _c_id = "";
        private string _c_initialize_id;
        private string _c_order_id;
        private decimal? _n_wgt;
        private decimal? _n_mach_wgt;
        private string _c_design_no;
        private decimal _n_status = 0;
        private decimal _n_flag = 0;
        private string _c_rh;
        private string _c_lf;
        private string _c_kp;
        private decimal? _n_hl_time;
        private string _c_hl;
        private decimal? _n_dfp_hl_time;
        private string _c_dfp_hl;
        private string _c_xm;
        private string _c_roll_sta_id;
        private string _c_ccm_sta_id;
        private decimal? _n_mach_wgt_ccm;
        private decimal? _n_lgpc_status;
        private decimal? _n_exec_status;
        private decimal? _n_roll_prod_wgt;
        private decimal? _n_sms_prod_wgt;
        private string _c_remark;
        private string _c_emp_id;
        private string _c_emp_name;
        private DateTime _d_mod_dt = Convert.ToDateTime(System.DateTime.Now);
        private string _c_matrl_code_slab;
        private string _c_matrl_name_slab;
        private string _c_slab_size;
        private decimal? _n_slab_length;
        private decimal? _n_slab_pw;
        private string _c_matrl_code_kp;
        private string _c_matrl_name_kp;
        private string _c_kp_size;
        private decimal? _n_kp_length;
        private decimal? _n_kp_pw;
        private string _c_route;
        private decimal? _n_group;
        private decimal? _n_sort;
        private string _c_xc;
        private string _c_sl;
        private string _c_wl;
        private string _c_orderno;
        private string _c_conno;
        /// <summary>
        /// 主键
        /// </summary>
        public string C_ID
        {
            set { _c_id = value; }
            get { return _c_id; }
        }
        /// <summary>
        /// 方案表主键
        /// </summary>
        public string C_INITIALIZE_ID
        {
            set { _c_initialize_id = value; }
            get { return _c_initialize_id; }
        }
        /// <summary>
        /// 订单池表主键
        /// </summary>
        public string C_ORDER_ID
        {
            set { _c_order_id = value; }
            get { return _c_order_id; }
        }
        /// <summary>
        /// 初始化排产量
        /// </summary>
        public decimal? N_WGT
        {
            set { _n_wgt = value; }
            get { return _n_wgt; }
        }
        /// <summary>
        /// 机时产量（轧钢）
        /// </summary>
        public decimal? N_MACH_WGT
        {
            set { _n_mach_wgt = value; }
            get { return _n_mach_wgt; }
        }
        /// <summary>
        /// 质量设计号
        /// </summary>
        public string C_DESIGN_NO
        {
            set { _c_design_no = value; }
            get { return _c_design_no; }
        }
        /// <summary>
        /// 订单状态：0待生效，1已生效，2失效
        /// </summary>
        public decimal N_STATUS
        {
            set { _n_status = value; }
            get { return _n_status; }
        }
        /// <summary>
        /// 订单标识：0正常，1增订，2变更，3预测，4 附属品
        /// </summary>
        public decimal N_FLAG
        {
            set { _n_flag = value; }
            get { return _n_flag; }
        }
        /// <summary>
        /// 过真空
        /// </summary>
        public string C_RH
        {
            set { _c_rh = value; }
            get { return _c_rh; }
        }
        /// <summary>
        /// 精炼
        /// </summary>
        public string C_LF
        {
            set { _c_lf = value; }
            get { return _c_lf; }
        }
        /// <summary>
        /// 开坯
        /// </summary>
        public string C_KP
        {
            set { _c_kp = value; }
            get { return _c_kp; }
        }
        /// <summary>
        /// 缓冷时间
        /// </summary>
        public decimal? N_HL_TIME
        {
            set { _n_hl_time = value; }
            get { return _n_hl_time; }
        }
        /// <summary>
        /// 缓冷
        /// </summary>
        public string C_HL
        {
            set { _c_hl = value; }
            get { return _c_hl; }
        }
        /// <summary>
        /// 大方坯缓冷时间
        /// </summary>
        public decimal? N_DFP_HL_TIME
        {
            set { _n_dfp_hl_time = value; }
            get { return _n_dfp_hl_time; }
        }
        /// <summary>
        /// 大方坯缓冷
        /// </summary>
        public string C_DFP_HL
        {
            set { _c_dfp_hl = value; }
            get { return _c_dfp_hl; }
        }
        /// <summary>
        /// 修磨
        /// </summary>
        public string C_XM
        {
            set { _c_xm = value; }
            get { return _c_xm; }
        }
        /// <summary>
        /// 轧线工位主键
        /// </summary>
        public string C_ROLL_STA_ID
        {
            set { _c_roll_sta_id = value; }
            get { return _c_roll_sta_id; }
        }
        /// <summary>
        /// 连铸工位主键
        /// </summary>
        public string C_CCM_STA_ID
        {
            set { _c_ccm_sta_id = value; }
            get { return _c_ccm_sta_id; }
        }
        /// <summary>
        /// 机时产量（连铸）
        /// </summary>
        public decimal? N_MACH_WGT_CCM
        {
            set { _n_mach_wgt_ccm = value; }
            get { return _n_mach_wgt_ccm; }
        }
        /// <summary>
        /// 炼钢排产状态
        /// </summary>
        public decimal? N_LGPC_STATUS
        {
            set { _n_lgpc_status = value; }
            get { return _n_lgpc_status; }
        }
        /// <summary>
        /// 轧钢排产状态
        /// </summary>
        public decimal? N_EXEC_STATUS
        {
            set { _n_exec_status = value; }
            get { return _n_exec_status; }
        }
        /// <summary>
        /// 轧钢排产量
        /// </summary>
        public decimal? N_ROLL_PROD_WGT
        {
            set { _n_roll_prod_wgt = value; }
            get { return _n_roll_prod_wgt; }
        }
        /// <summary>
        /// 炼钢排产量
        /// </summary>
        public decimal? N_SMS_PROD_WGT
        {
            set { _n_sms_prod_wgt = value; }
            get { return _n_sms_prod_wgt; }
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
        /// 操作人
        /// </summary>
        public string C_EMP_ID
        {
            set { _c_emp_id = value; }
            get { return _c_emp_id; }
        }
        /// <summary>
        /// 操作人
        /// </summary>
        public string C_EMP_NAME
        {
            set { _c_emp_name = value; }
            get { return _c_emp_name; }
        }
        /// <summary>
        /// 操作时间
        /// </summary>
        public DateTime D_MOD_DT
        {
            set { _d_mod_dt = value; }
            get { return _d_mod_dt; }
        }
        /// <summary>
        /// 连铸钢坯物料号
        /// </summary>
        public string C_MATRL_CODE_SLAB
        {
            set { _c_matrl_code_slab = value; }
            get { return _c_matrl_code_slab; }
        }
        /// <summary>
        /// 连铸钢坯物料名称
        /// </summary>
        public string C_MATRL_NAME_SLAB
        {
            set { _c_matrl_name_slab = value; }
            get { return _c_matrl_name_slab; }
        }
        /// <summary>
        /// 连铸钢坯断面
        /// </summary>
        public string C_SLAB_SIZE
        {
            set { _c_slab_size = value; }
            get { return _c_slab_size; }
        }
        /// <summary>
        /// 连铸钢坯定尺
        /// </summary>
        public decimal? N_SLAB_LENGTH
        {
            set { _n_slab_length = value; }
            get { return _n_slab_length; }
        }
        /// <summary>
        /// 连铸钢坯理论单重
        /// </summary>
        public decimal? N_SLAB_PW
        {
            set { _n_slab_pw = value; }
            get { return _n_slab_pw; }
        }
        /// <summary>
        /// 开坯钢坯物料号
        /// </summary>
        public string C_MATRL_CODE_KP
        {
            set { _c_matrl_code_kp = value; }
            get { return _c_matrl_code_kp; }
        }
        /// <summary>
        /// 开坯钢坯物料名称
        /// </summary>
        public string C_MATRL_NAME_KP
        {
            set { _c_matrl_name_kp = value; }
            get { return _c_matrl_name_kp; }
        }
        /// <summary>
        /// 开坯钢坯断面
        /// </summary>
        public string C_KP_SIZE
        {
            set { _c_kp_size = value; }
            get { return _c_kp_size; }
        }
        /// <summary>
        /// 开坯钢坯定尺
        /// </summary>
        public decimal? N_KP_LENGTH
        {
            set { _n_kp_length = value; }
            get { return _n_kp_length; }
        }
        /// <summary>
        /// 开坯钢坯理论单重
        /// </summary>
        public decimal? N_KP_PW
        {
            set { _n_kp_pw = value; }
            get { return _n_kp_pw; }
        }
        /// <summary>
        /// 工艺路线
        /// </summary>
        public string C_ROUTE
        {
            set { _c_route = value; }
            get { return _c_route; }
        }
        /// <summary>
        /// 分组号
        /// </summary>
        public decimal? N_GROUP
        {
            set { _n_group = value; }
            get { return _n_group; }
        }
        /// <summary>
        /// 分组排序号
        /// </summary>
        public decimal? N_SORT
        {
            set { _n_sort = value; }
            get { return _n_sort; }
        }
        /// <summary>
        /// 能否洗槽
        /// </summary>
        public string C_XC
        {
            set { _c_xc = value; }
            get { return _c_xc; }
        }
        /// <summary>
        /// 是否需要首炉钢种
        /// </summary>
        public string C_SL
        {
            set { _c_sl = value; }
            get { return _c_sl; }
        }
        /// <summary>
        /// 是否需要尾炉钢种
        /// </summary>
        public string C_WL
        {
            set { _c_wl = value; }
            get { return _c_wl; }
        }
        /// <summary>
        /// 订单号
        /// </summary>
        public string C_ORDERNO
        {
            set { _c_orderno = value; }
            get { return _c_orderno; }
        }
        /// <summary>
        /// 合同号
        /// </summary>
        public string C_CONNO
        {
            set { _c_conno = value; }
            get { return _c_conno; }
        }
        #endregion Model

    }
}

