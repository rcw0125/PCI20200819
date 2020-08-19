using System;
namespace MODEL
{
    /// <summary>
    /// 生产计划接收表
    /// </summary>
    [Serializable]
    public partial class Mod_TPC_ORDER_SEQ
    {
        public Mod_TPC_ORDER_SEQ()
        { }
        #region Model
        private string _c_id = "SYS_GUID";
        private string _c_ord_id;
        private string _c_std_id;
        private decimal? _n_ord_wgt;
        private decimal? _n_remain_wgt;
        private string _c_ccm_no;
        private string _c_ccm_desc;
        private string _c_plant_id;
        private string _c_plant_desc;
        private string _c_slab_size;
        private string _c_slab_length;
        private decimal? _n_slab_wgt;
        private string _c_matrl_no;
        private string _c_matrl_name;
        private string _c_matrl_grp_id;
        private string _c_measure_type;
        private string _c_receive_type;
        private string _c_receive_emp;
        private string _c_receive_time;
        private string _c_matrl_no_slab;
        private string _c_matrl_name_slab;
        private string _c_matrl_grp_id_slab;
        private DateTime? _d_sms_start;
        private DateTime? _d_sms_end;
        private DateTime? _d_sro_start;
        private DateTime? _d_sro_end;
        private DateTime? _d_fin_start;
        private DateTime? _d_fin_end;
        private string _c_close_reason;
        private string _c_close_emp;
        private string _c_close_time;
        private decimal? _n_ord_wgt_scale;
        private decimal? _n_spec_width;
        private decimal? _n_spec_higth;
        private string _c_ctrl_no_lg;
        private string _c_ctrl_no_zg;
        private string _c_lg_ctrl_emp;
        private string _c_lg_ctrl_time;
        private string _c_zg_ctrl_emp;
        private string _c_zg_ctrl_time;
        private string _c_design_no;
        private string _c_zg_bz_emp;
        private string _c_zg_bz_time;
        private string _c_zg_sh_emp;
        private string _c_zg_sh_time;
        private decimal? _n_remain_slab_wgt;
        private string _c_pc_issh;
        private decimal? _n_zg_wgt = 0M;
        private DateTime? _d_zg_date;
        private decimal? _n_lg_wgt = 0M;
        private DateTime? _d_lg_date;
        private decimal? _n_zgddl_wgt = 0M;
        private DateTime? _d_zgddl_date;
        private decimal? _n_lgddl_wgt = 0M;
        private DateTime? _d_lgddl_date;
        private DateTime? _d_zg_date_b;
        private DateTime? _d_lg_date_b;
        private string _c_matrl_grp_name;
        private string _c_matrl_grp_name_slab;
        private DateTime? _d_plan_product_date;
        private string _c_plan_product_user;
        private DateTime? _d_plan_product_mod_time;
        private string _c_plan_product_state;
        private DateTime? _d_plan_product_sh_date;
        private string _c_plan_product_sh_user;
        private string _c_finish_type = "0";
        private decimal _n_jscl_wgt = 0;
		private decimal _n_status = 1;
		private string _c_remark;
        private string _c_emp_id;
        private DateTime _d_mod_dt = Convert.ToDateTime(DateTime.Now);
        /// <summary>
        /// 主键
        /// </summary>
        public string C_ID
        {
            set { _c_id = value; }
            get { return _c_id; }
        }
        /// <summary>
        /// 合同明细表主键
        /// </summary>
        public string C_ORD_ID
        {
            set { _c_ord_id = value; }
            get { return _c_ord_id; }
        }
        /// <summary>
        /// 执行标准表主键
        /// </summary>
        public string C_STD_ID
        {
            set { _c_std_id = value; }
            get { return _c_std_id; }
        }
        /// <summary>
        /// 订单重量
        /// </summary>
        public decimal? N_ORD_WGT
        {
            set { _n_ord_wgt = value; }
            get { return _n_ord_wgt; }
        }
        /// <summary>
        /// 订单剩余重量
        /// </summary>
        public decimal? N_REMAIN_WGT
        {
            set { _n_remain_wgt = value; }
            get { return _n_remain_wgt; }
        }
        /// <summary>
        /// 连铸机
        /// </summary>
        public string C_CCM_NO
        {
            set { _c_ccm_no = value; }
            get { return _c_ccm_no; }
        }
        /// <summary>
        /// 连铸机描述
        /// </summary>
        public string C_CCM_DESC
        {
            set { _c_ccm_desc = value; }
            get { return _c_ccm_desc; }
        }
        /// <summary>
        /// 轧线代码
        /// </summary>
        public string C_PLANT_ID
        {
            set { _c_plant_id = value; }
            get { return _c_plant_id; }
        }
        /// <summary>
        /// 轧线描述
        /// </summary>
        public string C_PLANT_DESC
        {
            set { _c_plant_desc = value; }
            get { return _c_plant_desc; }
        }
        /// <summary>
        /// 坯料断面
        /// </summary>
        public string C_SLAB_SIZE
        {
            set { _c_slab_size = value; }
            get { return _c_slab_size; }
        }
        /// <summary>
        /// 坯料长度
        /// </summary>
        public string C_SLAB_LENGTH
        {
            set { _c_slab_length = value; }
            get { return _c_slab_length; }
        }
        /// <summary>
        /// 坯料重量
        /// </summary>
        public decimal? N_SLAB_WGT
        {
            set { _n_slab_wgt = value; }
            get { return _n_slab_wgt; }
        }
        /// <summary>
        /// 物料编码
        /// </summary>
        public string C_MATRL_NO
        {
            set { _c_matrl_no = value; }
            get { return _c_matrl_no; }
        }
        /// <summary>
        /// 物料名称
        /// </summary>
        public string C_MATRL_NAME
        {
            set { _c_matrl_name = value; }
            get { return _c_matrl_name; }
        }
        /// <summary>
        /// 物料组
        /// </summary>
        public string C_MATRL_GRP_ID
        {
            set { _c_matrl_grp_id = value; }
            get { return _c_matrl_grp_id; }
        }
        /// <summary>
        /// 计量方式，0理重 1实重
        /// </summary>
        public string C_MEASURE_TYPE
        {
            set { _c_measure_type = value; }
            get { return _c_measure_type; }
        }
        /// <summary>
        /// 接收状态（0\1\2\3\4）5已撤回销售订单6生产处关闭订单
        /// </summary>
        public string C_RECEIVE_TYPE
        {
            set { _c_receive_type = value; }
            get { return _c_receive_type; }
        }
        /// <summary>
        /// 接收人员
        /// </summary>
        public string C_RECEIVE_EMP
        {
            set { _c_receive_emp = value; }
            get { return _c_receive_emp; }
        }
        /// <summary>
        /// 接收时间
        /// </summary>
        public string C_RECEIVE_TIME
        {
            set { _c_receive_time = value; }
            get { return _c_receive_time; }
        }
        /// <summary>
        /// 物料编码(炼钢)
        /// </summary>
        public string C_MATRL_NO_SLAB
        {
            set { _c_matrl_no_slab = value; }
            get { return _c_matrl_no_slab; }
        }
        /// <summary>
        /// 物料名称(炼钢)
        /// </summary>
        public string C_MATRL_NAME_SLAB
        {
            set { _c_matrl_name_slab = value; }
            get { return _c_matrl_name_slab; }
        }
        /// <summary>
        /// 物料组(炼钢)
        /// </summary>
        public string C_MATRL_GRP_ID_SLAB
        {
            set { _c_matrl_grp_id_slab = value; }
            get { return _c_matrl_grp_id_slab; }
        }
        /// <summary>
        /// 炼钢开始时间
        /// </summary>
        public DateTime? D_SMS_START
        {
            set { _d_sms_start = value; }
            get { return _d_sms_start; }
        }
        /// <summary>
        /// 炼钢结束时间
        /// </summary>
        public DateTime? D_SMS_END
        {
            set { _d_sms_end = value; }
            get { return _d_sms_end; }
        }
        /// <summary>
        /// 轧钢开始时间
        /// </summary>
        public DateTime? D_SRO_START
        {
            set { _d_sro_start = value; }
            get { return _d_sro_start; }
        }
        /// <summary>
        /// 轧钢结束时间
        /// </summary>
        public DateTime? D_SRO_END
        {
            set { _d_sro_end = value; }
            get { return _d_sro_end; }
        }
        /// <summary>
        /// 精整开始时间
        /// </summary>
        public DateTime? D_FIN_START
        {
            set { _d_fin_start = value; }
            get { return _d_fin_start; }
        }
        /// <summary>
        /// 精整结束时间
        /// </summary>
        public DateTime? D_FIN_END
        {
            set { _d_fin_end = value; }
            get { return _d_fin_end; }
        }
        /// <summary>
        /// 关闭原因
        /// </summary>
        public string C_CLOSE_REASON
        {
            set { _c_close_reason = value; }
            get { return _c_close_reason; }
        }
        /// <summary>
        /// 关闭人员
        /// </summary>
        public string C_CLOSE_EMP
        {
            set { _c_close_emp = value; }
            get { return _c_close_emp; }
        }
        /// <summary>
        /// 关闭时间
        /// </summary>
        public string C_CLOSE_TIME
        {
            set { _c_close_time = value; }
            get { return _c_close_time; }
        }
        /// <summary>
        /// 含系数重量
        /// </summary>
        public decimal? N_ORD_WGT_SCALE
        {
            set { _n_ord_wgt_scale = value; }
            get { return _n_ord_wgt_scale; }
        }
        /// <summary>
        /// 宽度
        /// </summary>
        public decimal? N_SPEC_WIDTH
        {
            set { _n_spec_width = value; }
            get { return _n_spec_width; }
        }
        /// <summary>
        /// 厚度/直径
        /// </summary>
        public decimal? N_SPEC_HIGTH
        {
            set { _n_spec_higth = value; }
            get { return _n_spec_higth; }
        }
        /// <summary>
        /// 炼钢任务号
        /// </summary>
        public string C_CTRL_NO_LG
        {
            set { _c_ctrl_no_lg = value; }
            get { return _c_ctrl_no_lg; }
        }
        /// <summary>
        /// 轧钢调度令号
        /// </summary>
        public string C_CTRL_NO_ZG
        {
            set { _c_ctrl_no_zg = value; }
            get { return _c_ctrl_no_zg; }
        }
        /// <summary>
        /// 炼钢调度令人员
        /// </summary>
        public string C_LG_CTRL_EMP
        {
            set { _c_lg_ctrl_emp = value; }
            get { return _c_lg_ctrl_emp; }
        }
        /// <summary>
        /// 炼钢调度令时间
        /// </summary>
        public string C_LG_CTRL_TIME
        {
            set { _c_lg_ctrl_time = value; }
            get { return _c_lg_ctrl_time; }
        }
        /// <summary>
        /// 轧钢调度令人员
        /// </summary>
        public string C_ZG_CTRL_EMP
        {
            set { _c_zg_ctrl_emp = value; }
            get { return _c_zg_ctrl_emp; }
        }
        /// <summary>
        /// 轧钢调度令时间
        /// </summary>
        public string C_ZG_CTRL_TIME
        {
            set { _c_zg_ctrl_time = value; }
            get { return _c_zg_ctrl_time; }
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
        /// 轧钢编制人员
        /// </summary>
        public string C_ZG_BZ_EMP
        {
            set { _c_zg_bz_emp = value; }
            get { return _c_zg_bz_emp; }
        }
        /// <summary>
        /// 轧钢编制时间
        /// </summary>
        public string C_ZG_BZ_TIME
        {
            set { _c_zg_bz_time = value; }
            get { return _c_zg_bz_time; }
        }
        /// <summary>
        /// 轧钢审核人员
        /// </summary>
        public string C_ZG_SH_EMP
        {
            set { _c_zg_sh_emp = value; }
            get { return _c_zg_sh_emp; }
        }
        /// <summary>
        /// 轧钢审核时间
        /// </summary>
        public string C_ZG_SH_TIME
        {
            set { _c_zg_sh_time = value; }
            get { return _c_zg_sh_time; }
        }
        /// <summary>
        /// 坯料剩余重量
        /// </summary>
        public decimal? N_REMAIN_SLAB_WGT
        {
            set { _n_remain_slab_wgt = value; }
            get { return _n_remain_slab_wgt; }
        }
        /// <summary>
        /// 坯长是否审核0未编制1已编制2已审核
        /// </summary>
        public string C_PC_ISSH
        {
            set { _c_pc_issh = value; }
            get { return _c_pc_issh; }
        }
        /// <summary>
        /// 轧钢收料重量
        /// </summary>
        public decimal? N_ZG_WGT
        {
            set { _n_zg_wgt = value; }
            get { return _n_zg_wgt; }
        }
        /// <summary>
        /// 轧钢收料时间
        /// </summary>
        public DateTime? D_ZG_DATE
        {
            set { _d_zg_date = value; }
            get { return _d_zg_date; }
        }
        /// <summary>
        /// 炼钢收料重量
        /// </summary>
        public decimal? N_LG_WGT
        {
            set { _n_lg_wgt = value; }
            get { return _n_lg_wgt; }
        }
        /// <summary>
        /// 炼钢收料时间
        /// </summary>
        public DateTime? D_LG_DATE
        {
            set { _d_lg_date = value; }
            get { return _d_lg_date; }
        }
        /// <summary>
        /// 调度令下发重量（轧钢）
        /// </summary>
        public decimal? N_ZGDDL_WGT
        {
            set { _n_zgddl_wgt = value; }
            get { return _n_zgddl_wgt; }
        }
        /// <summary>
        /// 轧钢调度令下发时间
        /// </summary>
        public DateTime? D_ZGDDL_DATE
        {
            set { _d_zgddl_date = value; }
            get { return _d_zgddl_date; }
        }
        /// <summary>
        /// 调度令下发重量（炼钢）
        /// </summary>
        public decimal? N_LGDDL_WGT
        {
            set { _n_lgddl_wgt = value; }
            get { return _n_lgddl_wgt; }
        }
        /// <summary>
        /// 炼钢调度令下发时间
        /// </summary>
        public DateTime? D_LGDDL_DATE
        {
            set { _d_lgddl_date = value; }
            get { return _d_lgddl_date; }
        }
        /// <summary>
        /// 轧钢收料时间(开始)
        /// </summary>
        public DateTime? D_ZG_DATE_B
        {
            set { _d_zg_date_b = value; }
            get { return _d_zg_date_b; }
        }
        /// <summary>
        /// 炼钢收料时间（开始）
        /// </summary>
        public DateTime? D_LG_DATE_B
        {
            set { _d_lg_date_b = value; }
            get { return _d_lg_date_b; }
        }
        /// <summary>
        /// 物料组名称
        /// </summary>
        public string C_MATRL_GRP_NAME
        {
            set { _c_matrl_grp_name = value; }
            get { return _c_matrl_grp_name; }
        }
        /// <summary>
        /// 物料组名称（炼钢）
        /// </summary>
        public string C_MATRL_GRP_NAME_SLAB
        {
            set { _c_matrl_grp_name_slab = value; }
            get { return _c_matrl_grp_name_slab; }
        }
        /// <summary>
        /// 销售处计划生产日期
        /// </summary>
        public DateTime? D_PLAN_PRODUCT_DATE
        {
            set { _d_plan_product_date = value; }
            get { return _d_plan_product_date; }
        }
        /// <summary>
        /// 销售处计划生产排产人
        /// </summary>
        public string C_PLAN_PRODUCT_USER
        {
            set { _c_plan_product_user = value; }
            get { return _c_plan_product_user; }
        }
        /// <summary>
        /// 操作时间
        /// </summary>
        public DateTime? D_PLAN_PRODUCT_MOD_TIME
        {
            set { _d_plan_product_mod_time = value; }
            get { return _d_plan_product_mod_time; }
        }
        /// <summary>
        /// 销售安排状态 0申请1审核通过(为空或=1时生产处可排产)
        /// </summary>
        public string C_PLAN_PRODUCT_STATE
        {
            set { _c_plan_product_state = value; }
            get { return _c_plan_product_state; }
        }
        /// <summary>
        /// 销售处计划生产审核日期
        /// </summary>
        public DateTime? D_PLAN_PRODUCT_SH_DATE
        {
            set { _d_plan_product_sh_date = value; }
            get { return _d_plan_product_sh_date; }
        }
        /// <summary>
        /// 销售处计划生产审核人
        /// </summary>
        public string C_PLAN_PRODUCT_SH_USER
        {
            set { _c_plan_product_sh_user = value; }
            get { return _c_plan_product_sh_user; }
        }
        /// <summary>
        /// 订单是否完成0正常1完成2作废
        /// </summary>
        public string C_FINISH_TYPE
        {
            set { _c_finish_type = value; }
            get { return _c_finish_type; }
        }
        /// <summary>
        /// 对应的机时产量
        /// </summary>
        public decimal N_JSCL_WGT
        {
            set { _n_jscl_wgt = value; }
            get { return _n_jscl_wgt; }
        }
        /// <summary>
        /// 使用状态   1-可用；0-停用
        /// </summary>
        public decimal N_STATUS
        {
            set { _n_status = value; }
            get { return _n_status; }
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
        /// 维护人
        /// </summary>
        public string C_EMP_ID
        {
            set { _c_emp_id = value; }
            get { return _c_emp_id; }
        }
        /// <summary>
        /// 维护时间
        /// </summary>
        public DateTime D_MOD_DT
        {
            set { _d_mod_dt = value; }
            get { return _d_mod_dt; }
        }
        #endregion Model

    }
}