using System;
namespace MODEL
{
    /// <summary>
    /// 炼钢计划
    /// </summary>
    [Serializable]
    public partial class Mod_TPP_CAST_PLAN
    {
        public Mod_TPP_CAST_PLAN()
        { }
        #region Model
        private string _c_id;
        private string _c_plan_id;
        private string _c_contract_id;
        private string _c_plan_dept;
        private string _c_execute_dept;
        private DateTime? _d_planexecute_date;
        private DateTime? _d_actualexecute_date;
        private string _c_planner;
        private string _c_pre_lotno;
        private string _c_pre_heat_id;
        private string _c_pre_steelgradeindex;
        private string _c_pre_steelgrade;
        private decimal? _n_aim_tapped_weight;
        private string _c_caster_id;
        private string _c_bof_id;
        private string _c_lf_id;
        private string _c_rh_id;
        private string _n_bof_status;
        private string _n_lf_status;
        private string _n_rh_status;
        private string _n_caster_status;
        private string _n_s_ide_status;
        private string _c_heat_id;
        private string _c_caster_no;
        private string _c_casting_heat_cnt;
        private DateTime? _d_aim_ironprepared_time;
        private DateTime? _d_aim_bofstart_time;
        private DateTime? _d_aim_boftapped_time;
        private DateTime? _d_aim_tappedsideend_time;
        private DateTime? _d_aim_lfarrival_time;
        private DateTime? _d_aim_lfstart_time;
        private DateTime? _d_aim_lfend_time;
        private DateTime? _d_aim_lfleave_time;
        private DateTime? _d_aim_rharrival_time;
        private DateTime? _d_aim_rhstart_time;
        private DateTime? _d_aim_rhend_time;
        private DateTime? _d_aim_rhleave_time;
        private DateTime? _d_aim_casterarrival_time;
        private DateTime? _d_aim_castingstart_time;
        private DateTime? _d_aim_castingend_time;
        private string _c_fir_heat_flag;
        private string _div_heat_id;
        private string _c_team_id;
        private string _c_shift_id;
        private string _steelgradeindex;
        private string _c_plan_ord__id;
        private string _c_hot_send_flag;
        private string _c_steel_return_flag;
        private string _c_steel_back_flag;
        private string _c_treat_seq;
        private string _c_destitation;
        private string _c_new_bof_flag;
        private string _c_refine_type;
        private string _c_length;
        private string _c_w_idth;
        private string _c_thickness;
        private string _c_aod_id;
        private string _c_dep_id;
        private string _c_rhl_id;
        private string _c_dep_status;
        private string _c_rhl_status;
        private string _c_aod_status;
        private string _c_initialize_item;
        private string _c_is_to_mes = "0";
        private string _c_mes_plan_id;
        private string _c_ld_desc;
        private string _c_lf_desc;
        private string _c_rh_desc;
        private string _c_cc_desc;
        private DateTime? _d_down_time;
        /// <summary>
        /// 主键
        /// </summary>
        public string C_ID
        {
            set { _c_id = value; }
            get { return _c_id; }
        }
        /// <summary>
        /// 计划编号
        /// </summary>
        public string C_PLAN_ID
        {
            set { _c_plan_id = value; }
            get { return _c_plan_id; }
        }
        /// <summary>
        /// 合同编号
        /// </summary>
        public string C_CONTRACT_ID
        {
            set { _c_contract_id = value; }
            get { return _c_contract_id; }
        }
        /// <summary>
        /// 计划部门
        /// </summary>
        public string C_PLAN_DEPT
        {
            set { _c_plan_dept = value; }
            get { return _c_plan_dept; }
        }
        /// <summary>
        /// 执行部门
        /// </summary>
        public string C_EXECUTE_DEPT
        {
            set { _c_execute_dept = value; }
            get { return _c_execute_dept; }
        }
        /// <summary>
        /// 计划执行时间
        /// </summary>
        public DateTime? D_PLANEXECUTE_DATE
        {
            set { _d_planexecute_date = value; }
            get { return _d_planexecute_date; }
        }
        /// <summary>
        /// 实际执行时间
        /// </summary>
        public DateTime? D_ACTUALEXECUTE_DATE
        {
            set { _d_actualexecute_date = value; }
            get { return _d_actualexecute_date; }
        }
        /// <summary>
        /// 计划人
        /// </summary>
        public string C_PLANNER
        {
            set { _c_planner = value; }
            get { return _c_planner; }
        }
        /// <summary>
        /// 炉次
        /// </summary>
        public string C_PRE_LOTNO
        {
            set { _c_pre_lotno = value; }
            get { return _c_pre_lotno; }
        }
        /// <summary>
        /// 预定炉号
        /// </summary>
        public string C_PRE_HEAT_ID
        {
            set { _c_pre_heat_id = value; }
            get { return _c_pre_heat_id; }
        }
        /// <summary>
        /// 预定炼钢记号
        /// </summary>
        public string C_PRE_STEELGRADEINDEX
        {
            set { _c_pre_steelgradeindex = value; }
            get { return _c_pre_steelgradeindex; }
        }
        /// <summary>
        /// 预定钢种
        /// </summary>
        public string C_PRE_STEELGRADE
        {
            set { _c_pre_steelgrade = value; }
            get { return _c_pre_steelgrade; }
        }
        /// <summary>
        /// 目标出钢重量
        /// </summary>
        public decimal? N_AIM_TAPPED_WEIGHT
        {
            set { _n_aim_tapped_weight = value; }
            get { return _n_aim_tapped_weight; }
        }
        /// <summary>
        /// 铸机号
        /// </summary>
        public string C_CASTER_ID
        {
            set { _c_caster_id = value; }
            get { return _c_caster_id; }
        }
        /// <summary>
        /// 转炉炉座
        /// </summary>
        public string C_BOF_ID
        {
            set { _c_bof_id = value; }
            get { return _c_bof_id; }
        }
        /// <summary>
        /// 精炼炉座
        /// </summary>
        public string C_LF_ID
        {
            set { _c_lf_id = value; }
            get { return _c_lf_id; }
        }
        /// <summary>
        /// RH炉座
        /// </summary>
        public string C_RH_ID
        {
            set { _c_rh_id = value; }
            get { return _c_rh_id; }
        }
        /// <summary>
        /// 转炉状态01未执02兑铁03吹炼开始04出钢开05出钢结束
        /// </summary>
        public string N_BOF_STATUS
        {
            set { _n_bof_status = value; }
            get { return _n_bof_status; }
        }
        /// <summary>
        /// 精炼炉状态01未执行02进站03处理开始04处理结束05出站
        /// </summary>
        public string N_LF_STATUS
        {
            set { _n_lf_status = value; }
            get { return _n_lf_status; }
        }
        /// <summary>
        /// RH炉状态01未执行02进站03处理开始04处理结束05出站
        /// </summary>
        public string N_RH_STATUS
        {
            set { _n_rh_status = value; }
            get { return _n_rh_status; }
        }
        /// <summary>
        /// 铸机状态01未执行02大包到达03大包开浇04浇铸结束
        /// </summary>
        public string N_CASTER_STATUS
        {
            set { _n_caster_status = value; }
            get { return _n_caster_status; }
        }
        /// <summary>
        /// 转炉炉后状态01未执行02处理开始03处理结束
        /// </summary>
        public string N_S_IDE_STATUS
        {
            set { _n_s_ide_status = value; }
            get { return _n_s_ide_status; }
        }
        /// <summary>
        /// 炉次
        /// </summary>
        public string C_HEAT_ID
        {
            set { _c_heat_id = value; }
            get { return _c_heat_id; }
        }
        /// <summary>
        /// 铸机号
        /// </summary>
        public string C_CASTER_NO
        {
            set { _c_caster_no = value; }
            get { return _c_caster_no; }
        }
        /// <summary>
        /// ？
        /// </summary>
        public string C_CASTING_HEAT_CNT
        {
            set { _c_casting_heat_cnt = value; }
            get { return _c_casting_heat_cnt; }
        }
        /// <summary>
        /// 铁水计划时间
        /// </summary>
        public DateTime? D_AIM_IRONPREPARED_TIME
        {
            set { _d_aim_ironprepared_time = value; }
            get { return _d_aim_ironprepared_time; }
        }
        /// <summary>
        /// 转炉开始计划时间
        /// </summary>
        public DateTime? D_AIM_BOFSTART_TIME
        {
            set { _d_aim_bofstart_time = value; }
            get { return _d_aim_bofstart_time; }
        }
        /// <summary>
        /// 转炉结束计划时间
        /// </summary>
        public DateTime? D_AIM_BOFTAPPED_TIME
        {
            set { _d_aim_boftapped_time = value; }
            get { return _d_aim_boftapped_time; }
        }
        /// <summary>
        /// 转炉离开计划时间
        /// </summary>
        public DateTime? D_AIM_TAPPEDSIDEEND_TIME
        {
            set { _d_aim_tappedsideend_time = value; }
            get { return _d_aim_tappedsideend_time; }
        }
        /// <summary>
        /// LF到达计划时间
        /// </summary>
        public DateTime? D_AIM_LFARRIVAL_TIME
        {
            set { _d_aim_lfarrival_time = value; }
            get { return _d_aim_lfarrival_time; }
        }
        /// <summary>
        /// LF开始计划时间
        /// </summary>
        public DateTime? D_AIM_LFSTART_TIME
        {
            set { _d_aim_lfstart_time = value; }
            get { return _d_aim_lfstart_time; }
        }
        /// <summary>
        /// LF结束计划时间
        /// </summary>
        public DateTime? D_AIM_LFEND_TIME
        {
            set { _d_aim_lfend_time = value; }
            get { return _d_aim_lfend_time; }
        }
        /// <summary>
        /// LF离开计划时间
        /// </summary>
        public DateTime? D_AIM_LFLEAVE_TIME
        {
            set { _d_aim_lfleave_time = value; }
            get { return _d_aim_lfleave_time; }
        }
        /// <summary>
        /// RH到达计划时间
        /// </summary>
        public DateTime? D_AIM_RHARRIVAL_TIME
        {
            set { _d_aim_rharrival_time = value; }
            get { return _d_aim_rharrival_time; }
        }
        /// <summary>
        /// RH开始计划时间
        /// </summary>
        public DateTime? D_AIM_RHSTART_TIME
        {
            set { _d_aim_rhstart_time = value; }
            get { return _d_aim_rhstart_time; }
        }
        /// <summary>
        /// RH结束计划时间
        /// </summary>
        public DateTime? D_AIM_RHEND_TIME
        {
            set { _d_aim_rhend_time = value; }
            get { return _d_aim_rhend_time; }
        }
        /// <summary>
        /// RH离开计划时间
        /// </summary>
        public DateTime? D_AIM_RHLEAVE_TIME
        {
            set { _d_aim_rhleave_time = value; }
            get { return _d_aim_rhleave_time; }
        }
        /// <summary>
        /// 连铸到达计划时间
        /// </summary>
        public DateTime? D_AIM_CASTERARRIVAL_TIME
        {
            set { _d_aim_casterarrival_time = value; }
            get { return _d_aim_casterarrival_time; }
        }
        /// <summary>
        /// 连铸开始计划时间
        /// </summary>
        public DateTime? D_AIM_CASTINGSTART_TIME
        {
            set { _d_aim_castingstart_time = value; }
            get { return _d_aim_castingstart_time; }
        }
        /// <summary>
        /// 连铸结束计划时间
        /// </summary>
        public DateTime? D_AIM_CASTINGEND_TIME
        {
            set { _d_aim_castingend_time = value; }
            get { return _d_aim_castingend_time; }
        }
        /// <summary>
        /// 加热炉标志
        /// </summary>
        public string C_FIR_HEAT_FLAG
        {
            set { _c_fir_heat_flag = value; }
            get { return _c_fir_heat_flag; }
        }
        /// <summary>
        /// 加热炉
        /// </summary>
        public string DIV_HEAT_ID
        {
            set { _div_heat_id = value; }
            get { return _div_heat_id; }
        }
        /// <summary>
        /// 班组
        /// </summary>
        public string C_TEAM_ID
        {
            set { _c_team_id = value; }
            get { return _c_team_id; }
        }
        /// <summary>
        /// 班别
        /// </summary>
        public string C_SHIFT_ID
        {
            set { _c_shift_id = value; }
            get { return _c_shift_id; }
        }
        /// <summary>
        /// 炼钢计划
        /// </summary>
        public string STEELGRADEINDEX
        {
            set { _steelgradeindex = value; }
            get { return _steelgradeindex; }
        }
        /// <summary>
        /// 计划订单号
        /// </summary>
        public string C_PLAN_ORD__ID
        {
            set { _c_plan_ord__id = value; }
            get { return _c_plan_ord__id; }
        }
        /// <summary>
        /// 热送标志
        /// </summary>
        public string C_HOT_SEND_FLAG
        {
            set { _c_hot_send_flag = value; }
            get { return _c_hot_send_flag; }
        }
        /// <summary>
        /// 回炉标志
        /// </summary>
        public string C_STEEL_RETURN_FLAG
        {
            set { _c_steel_return_flag = value; }
            get { return _c_steel_return_flag; }
        }
        /// <summary>
        /// 返送标志
        /// </summary>
        public string C_STEEL_BACK_FLAG
        {
            set { _c_steel_back_flag = value; }
            get { return _c_steel_back_flag; }
        }
        /// <summary>
        /// 顺序
        /// </summary>
        public string C_TREAT_SEQ
        {
            set { _c_treat_seq = value; }
            get { return _c_treat_seq; }
        }
        /// <summary>
        /// ？
        /// </summary>
        public string C_DESTITATION
        {
            set { _c_destitation = value; }
            get { return _c_destitation; }
        }
        /// <summary>
        /// 转炉标记
        /// </summary>
        public string C_NEW_BOF_FLAG
        {
            set { _c_new_bof_flag = value; }
            get { return _c_new_bof_flag; }
        }
        /// <summary>
        /// 工艺路径
        /// </summary>
        public string C_REFINE_TYPE
        {
            set { _c_refine_type = value; }
            get { return _c_refine_type; }
        }
        /// <summary>
        /// 长度
        /// </summary>
        public string C_LENGTH
        {
            set { _c_length = value; }
            get { return _c_length; }
        }
        /// <summary>
        /// 宽度
        /// </summary>
        public string C_W_IDTH
        {
            set { _c_w_idth = value; }
            get { return _c_w_idth; }
        }
        /// <summary>
        /// 厚度
        /// </summary>
        public string C_THICKNESS
        {
            set { _c_thickness = value; }
            get { return _c_thickness; }
        }
        /// <summary>
        /// AOD炉炉座
        /// </summary>
        public string C_AOD_ID
        {
            set { _c_aod_id = value; }
            get { return _c_aod_id; }
        }
        /// <summary>
        /// 熔化炉炉座
        /// </summary>
        public string C_DEP_ID
        {
            set { _c_dep_id = value; }
            get { return _c_dep_id; }
        }
        /// <summary>
        /// 转炉后
        /// </summary>
        public string C_RHL_ID
        {
            set { _c_rhl_id = value; }
            get { return _c_rhl_id; }
        }
        /// <summary>
        /// 熔化炉状态
        /// </summary>
        public string C_DEP_STATUS
        {
            set { _c_dep_status = value; }
            get { return _c_dep_status; }
        }
        /// <summary>
        /// 转炉后状态
        /// </summary>
        public string C_RHL_STATUS
        {
            set { _c_rhl_status = value; }
            get { return _c_rhl_status; }
        }
        /// <summary>
        /// AOD炉状态
        /// </summary>
        public string C_AOD_STATUS
        {
            set { _c_aod_status = value; }
            get { return _c_aod_status; }
        }
        /// <summary>
        /// 订单方案号
        /// </summary>
        public string C_INITIALIZE_ITEM
        {
            set { _c_initialize_item = value; }
            get { return _c_initialize_item; }
        }
        /// <summary>
        /// 0未传mes，1已传mes
        /// </summary>
        public string C_IS_TO_MES
        {
            set { _c_is_to_mes = value; }
            get { return _c_is_to_mes; }
        }
        /// <summary>
        /// MES计划号
        /// </summary>
        public string C_MES_PLAN_ID
        {
            set { _c_mes_plan_id = value; }
            get { return _c_mes_plan_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string C_LD_DESC
        {
            set { _c_ld_desc = value; }
            get { return _c_ld_desc; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string C_LF_DESC
        {
            set { _c_lf_desc = value; }
            get { return _c_lf_desc; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string C_RH_DESC
        {
            set { _c_rh_desc = value; }
            get { return _c_rh_desc; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string C_CC_DESC
        {
            set { _c_cc_desc = value; }
            get { return _c_cc_desc; }
        }
        /// <summary>
        /// 计划下发时间
        /// </summary>
        public DateTime? D_DOWN_TIME
        {
            set { _d_down_time = value; }
            get { return _d_down_time; }
        }
        #endregion Model

    }
}

