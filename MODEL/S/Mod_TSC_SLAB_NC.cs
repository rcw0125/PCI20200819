using System;
namespace MODEL
{
    /// <summary>
    /// 钢坯实绩
    /// </summary>
    [Serializable]
    public partial class Mod_TSC_SLAB_NC
    {
        public Mod_TSC_SLAB_NC()
        { }
        #region Model
        private string _c_id = System.Guid.NewGuid().ToString();
        private string _c_plan_id;
        private string _c_batch_no;
        private string _c_ord_no;
        private string _c_stove;
        private string _c_sta_id;
        private string _c_sta_code;
        private string _c_sta_desc;
        private string _c_stl_grd;
        private string _c_stl_grd_pre;
        private string _c_mat_code;
        private string _c_mat_name;
        private string _c_spec;
        private decimal? _n_len;
        private decimal _n_qua = 1M;
        private decimal _n_wgt;
        private string _c_std_code;
        private string _c_slab_type;
        private DateTime? _d_ccm_date;
        private string _c_ccm_shift;
        private string _c_ccm_group;
        private string _c_ccm_emp_id;
        private string _c_move_type;
        private string _c_sc_state;
        private DateTime? _d_esc_date;
        private DateTime? _d_lsc_date;
        private string _c_qkp_state;
        private string _c_kp_id;
        private string _c_con_no;
        private string _c_cus_no;
        private string _c_cus_name;
        private DateTime? _d_wl_date;
        private string _c_wl_shift;
        private string _c_wl_group;
        private string _c_wl_emp_id;
        private DateTime? _d_we_date;
        private string _c_we_shift;
        private string _c_we_group;
        private string _c_we_emp_id;
        private string _c_stock_state = "W";
        private string _c_mat_type;
        private string _c_qgp_state;
        private string _c_slabwh_code;
        private string _c_slabwh_area_code;
        private string _c_slabwh_loc_code;
        private string _c_slabwh_tier_code;
        private decimal? _n_wgt_meter;
        private string _c_qf_name;
        private string _c_design_no;
        private string _c_zrbm;
        private string _c_is_depot;
        private string _c_isxm;
        private string _c_xmgx;
        private string _c_isfree;
        private string _c_judge_lev_cf;
        private string _c_judge_lev_xn;
        private string _c_judge_lev_zh;
        private string _c_judge_lev_zh_people;
        private DateTime? _d_judge_date;
        private string _c_is_qr = "N";
        private string _c_qr_user;
        private DateTime? _d_qr_date;
        private DateTime? _d_q_date;
        private string _c_scutcheon;
        private string _c_gp_type;
        private string _c_remark;
        private string _c_is_tb = "N";
        private string _c_master_id;
        private string _c_gp_before_id;
        private string _c_gp_after_id;
        private DateTime? _d_stack_date;
        private string _c_stack_user;
        private string _c_stack_shift;
        private string _c_stack_group;
        private string _c_is_pd = "N";
        private string _c_reason_name;
        private string _c_fydh;
        private string _c_slab_status = "N";
        private string _c_zkdh;
        private string _c_zkdhid;
        private string _c_lgjh;
        private string _c_mes_floor;
        private decimal? _n_jz;
        private string _c_hl;
        private decimal? _n_hl_time;
        private string _c_hlyq;
        private string _c_dfp_hl;
        private decimal _n_dfp_hl_time = 0M;
        private string _c_route;
        private string _c_zyx1;
        private string _c_zyx2;
        /// <summary>
        /// 主键
        /// </summary>
        public string C_ID
        {
            set { _c_id = value; }
            get { return _c_id; }
        }
        /// <summary>
        /// 计划ID
        /// </summary>
        public string C_PLAN_ID
        {
            set { _c_plan_id = value; }
            get { return _c_plan_id; }
        }
        /// <summary>
        /// 批次号
        /// </summary>
        public string C_BATCH_NO
        {
            set { _c_batch_no = value; }
            get { return _c_batch_no; }
        }
        /// <summary>
        /// 订单号
        /// </summary>
        public string C_ORD_NO
        {
            set { _c_ord_no = value; }
            get { return _c_ord_no; }
        }
        /// <summary>
        /// 炉号
        /// </summary>
        public string C_STOVE
        {
            set { _c_stove = value; }
            get { return _c_stove; }
        }
        /// <summary>
        /// 铸机号 
        /// </summary>
        public string C_STA_ID
        {
            set { _c_sta_id = value; }
            get { return _c_sta_id; }
        }
        /// <summary>
        /// 铸机编码
        /// </summary>
        public string C_STA_CODE
        {
            set { _c_sta_code = value; }
            get { return _c_sta_code; }
        }
        /// <summary>
        /// 铸机描述
        /// </summary>
        public string C_STA_DESC
        {
            set { _c_sta_desc = value; }
            get { return _c_sta_desc; }
        }
        /// <summary>
        /// 钢种
        /// </summary>
        public string C_STL_GRD
        {
            set { _c_stl_grd = value; }
            get { return _c_stl_grd; }
        }
        /// <summary>
        /// 改判前钢种
        /// </summary>
        public string C_STL_GRD_PRE
        {
            set { _c_stl_grd_pre = value; }
            get { return _c_stl_grd_pre; }
        }
        /// <summary>
        /// 物料编码
        /// </summary>
        public string C_MAT_CODE
        {
            set { _c_mat_code = value; }
            get { return _c_mat_code; }
        }
        /// <summary>
        /// 物料名称
        /// </summary>
        public string C_MAT_NAME
        {
            set { _c_mat_name = value; }
            get { return _c_mat_name; }
        }
        /// <summary>
        /// 规格
        /// </summary>
        public string C_SPEC
        {
            set { _c_spec = value; }
            get { return _c_spec; }
        }
        /// <summary>
        /// 长度
        /// </summary>
        public decimal? N_LEN
        {
            set { _n_len = value; }
            get { return _n_len; }
        }
        /// <summary>
        /// 支数
        /// </summary>
        public decimal N_QUA
        {
            set { _n_qua = value; }
            get { return _n_qua; }
        }
        /// <summary>
        /// 单重
        /// </summary>
        public decimal N_WGT
        {
            set { _n_wgt = value; }
            get { return _n_wgt; }
        }
        /// <summary>
        /// 执行标准
        /// </summary>
        public string C_STD_CODE
        {
            set { _c_std_code = value; }
            get { return _c_std_code; }
        }
        /// <summary>
        /// 自备坯R,销售坯S
        /// </summary>
        public string C_SLAB_TYPE
        {
            set { _c_slab_type = value; }
            get { return _c_slab_type; }
        }
        /// <summary>
        /// 连铸收料时间
        /// </summary>
        public DateTime? D_CCM_DATE
        {
            set { _d_ccm_date = value; }
            get { return _d_ccm_date; }
        }
        /// <summary>
        /// 连铸收料班次
        /// </summary>
        public string C_CCM_SHIFT
        {
            set { _c_ccm_shift = value; }
            get { return _c_ccm_shift; }
        }
        /// <summary>
        /// 连铸收料班组
        /// </summary>
        public string C_CCM_GROUP
        {
            set { _c_ccm_group = value; }
            get { return _c_ccm_group; }
        }
        /// <summary>
        /// 连铸收料员工号
        /// </summary>
        public string C_CCM_EMP_ID
        {
            set { _c_ccm_emp_id = value; }
            get { return _c_ccm_emp_id; }
        }
        /// <summary>
        /// S已销售,N待入库;DZ待轧;NP待开坯;R入炉;C出炉;EX消耗;M调拨中;E入库;DX待修磨;0销售占用,1销售实绩
        /// </summary>
        public string C_MOVE_TYPE
        {
            set { _c_move_type = value; }
            get { return _c_move_type; }
        }
        /// <summary>
        /// 入出缓冷坑 N 未入坑 E在坑内，H已缓冷
        /// </summary>
        public string C_SC_STATE
        {
            set { _c_sc_state = value; }
            get { return _c_sc_state; }
        }
        /// <summary>
        /// 入坑时间
        /// </summary>
        public DateTime? D_ESC_DATE
        {
            set { _d_esc_date = value; }
            get { return _d_esc_date; }
        }
        /// <summary>
        /// 出坑时间
        /// </summary>
        public DateTime? D_LSC_DATE
        {
            set { _d_lsc_date = value; }
            get { return _d_lsc_date; }
        }
        /// <summary>
        /// 是否开坯 Y未开坯;N已开坯;
        /// </summary>
        public string C_QKP_STATE
        {
            set { _c_qkp_state = value; }
            get { return _c_qkp_state; }
        }
        /// <summary>
        /// 开坯前坯料主键
        /// </summary>
        public string C_KP_ID
        {
            set { _c_kp_id = value; }
            get { return _c_kp_id; }
        }
        /// <summary>
        /// 合同号
        /// </summary>
        public string C_CON_NO
        {
            set { _c_con_no = value; }
            get { return _c_con_no; }
        }
        /// <summary>
        /// 客户代码
        /// </summary>
        public string C_CUS_NO
        {
            set { _c_cus_no = value; }
            get { return _c_cus_no; }
        }
        /// <summary>
        /// 客户名称
        /// </summary>
        public string C_CUS_NAME
        {
            set { _c_cus_name = value; }
            get { return _c_cus_name; }
        }
        /// <summary>
        /// 出库时间
        /// </summary>
        public DateTime? D_WL_DATE
        {
            set { _d_wl_date = value; }
            get { return _d_wl_date; }
        }
        /// <summary>
        /// 出库班次
        /// </summary>
        public string C_WL_SHIFT
        {
            set { _c_wl_shift = value; }
            get { return _c_wl_shift; }
        }
        /// <summary>
        /// 出库班组
        /// </summary>
        public string C_WL_GROUP
        {
            set { _c_wl_group = value; }
            get { return _c_wl_group; }
        }
        /// <summary>
        /// 出库员工号
        /// </summary>
        public string C_WL_EMP_ID
        {
            set { _c_wl_emp_id = value; }
            get { return _c_wl_emp_id; }
        }
        /// <summary>
        /// 入库时间
        /// </summary>
        public DateTime? D_WE_DATE
        {
            set { _d_we_date = value; }
            get { return _d_we_date; }
        }
        /// <summary>
        /// 入库班次
        /// </summary>
        public string C_WE_SHIFT
        {
            set { _c_we_shift = value; }
            get { return _c_we_shift; }
        }
        /// <summary>
        /// 入库班组
        /// </summary>
        public string C_WE_GROUP
        {
            set { _c_we_group = value; }
            get { return _c_we_group; }
        }
        /// <summary>
        /// 入库员工号
        /// </summary>
        public string C_WE_EMP_ID
        {
            set { _c_we_emp_id = value; }
            get { return _c_we_emp_id; }
        }
        /// <summary>
        /// 库存状态 W:待判/F：已判定
        /// </summary>
        public string C_STOCK_STATE
        {
            set { _c_stock_state = value; }
            get { return _c_stock_state; }
        }
        /// <summary>
        /// 判定等级:合格品/协议品/待判/不合格品
        /// </summary>
        public string C_MAT_TYPE
        {
            set { _c_mat_type = value; }
            get { return _c_mat_type; }
        }
        /// <summary>
        /// 是否改判Y
        /// </summary>
        public string C_QGP_STATE
        {
            set { _c_qgp_state = value; }
            get { return _c_qgp_state; }
        }
        /// <summary>
        /// 钢坯仓库编码
        /// </summary>
        public string C_SLABWH_CODE
        {
            set { _c_slabwh_code = value; }
            get { return _c_slabwh_code; }
        }
        /// <summary>
        /// 钢坯库区域编码
        /// </summary>
        public string C_SLABWH_AREA_CODE
        {
            set { _c_slabwh_area_code = value; }
            get { return _c_slabwh_area_code; }
        }
        /// <summary>
        /// 库位编号
        /// </summary>
        public string C_SLABWH_LOC_CODE
        {
            set { _c_slabwh_loc_code = value; }
            get { return _c_slabwh_loc_code; }
        }
        /// <summary>
        /// 层编码
        /// </summary>
        public string C_SLABWH_TIER_CODE
        {
            set { _c_slabwh_tier_code = value; }
            get { return _c_slabwh_tier_code; }
        }
        /// <summary>
        /// 米单重
        /// </summary>
        public decimal? N_WGT_METER
        {
            set { _n_wgt_meter = value; }
            get { return _n_wgt_meter; }
        }
        /// <summary>
        /// 表面判定人
        /// </summary>
        public string C_QF_NAME
        {
            set { _c_qf_name = value; }
            get { return _c_qf_name; }
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
        /// 责任部门
        /// </summary>
        public string C_ZRBM
        {
            set { _c_zrbm = value; }
            get { return _c_zrbm; }
        }
        /// <summary>
        /// 是否库检 0：是 1：否
        /// </summary>
        public string C_IS_DEPOT
        {
            set { _c_is_depot = value; }
            get { return _c_is_depot; }
        }
        /// <summary>
        /// 是否修磨 Y未修磨;N已修磨
        /// </summary>
        public string C_ISXM
        {
            set { _c_isxm = value; }
            get { return _c_isxm; }
        }
        /// <summary>
        /// 修磨工序，修磨>扒皮
        /// </summary>
        public string C_XMGX
        {
            set { _c_xmgx = value; }
            get { return _c_xmgx; }
        }
        /// <summary>
        /// 是否自由状态货
        /// </summary>
        public string C_ISFREE
        {
            set { _c_isfree = value; }
            get { return _c_isfree; }
        }
        /// <summary>
        /// 成分等级
        /// </summary>
        public string C_JUDGE_LEV_CF
        {
            set { _c_judge_lev_cf = value; }
            get { return _c_judge_lev_cf; }
        }
        /// <summary>
        /// 性能等级
        /// </summary>
        public string C_JUDGE_LEV_XN
        {
            set { _c_judge_lev_xn = value; }
            get { return _c_judge_lev_xn; }
        }
        /// <summary>
        /// 综合判定等级
        /// </summary>
        public string C_JUDGE_LEV_ZH
        {
            set { _c_judge_lev_zh = value; }
            get { return _c_judge_lev_zh; }
        }
        /// <summary>
        /// 人工判定等级
        /// </summary>
        public string C_JUDGE_LEV_ZH_PEOPLE
        {
            set { _c_judge_lev_zh_people = value; }
            get { return _c_judge_lev_zh_people; }
        }
        /// <summary>
        /// 判定时间
        /// </summary>
        public DateTime? D_JUDGE_DATE
        {
            set { _d_judge_date = value; }
            get { return _d_judge_date; }
        }
        /// <summary>
        /// 是否确认
        /// </summary>
        public string C_IS_QR
        {
            set { _c_is_qr = value; }
            get { return _c_is_qr; }
        }
        /// <summary>
        /// 确认人
        /// </summary>
        public string C_QR_USER
        {
            set { _c_qr_user = value; }
            get { return _c_qr_user; }
        }
        /// <summary>
        /// 确认时间
        /// </summary>
        public DateTime? D_QR_DATE
        {
            set { _d_qr_date = value; }
            get { return _d_qr_date; }
        }
        /// <summary>
        /// 确认时间
        /// </summary>
        public DateTime? D_Q_DATE
        {
            set { _d_q_date = value; }
            get { return _d_q_date; }
        }
        /// <summary>
        /// 标牌类型 白牌/黄牌/红牌
        /// </summary>
        public string C_SCUTCHEON
        {
            set { _c_scutcheon = value; }
            get { return _c_scutcheon; }
        }
        /// <summary>
        /// 改判类型
        /// </summary>
        public string C_GP_TYPE
        {
            set { _c_gp_type = value; }
            get { return _c_gp_type; }
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
        /// 是否同步到综合判定；Y/N
        /// </summary>
        public string C_IS_TB
        {
            set { _c_is_tb = value; }
            get { return _c_is_tb; }
        }
        /// <summary>
        /// 实绩主键
        /// </summary>
        public string C_MASTER_ID
        {
            set { _c_master_id = value; }
            get { return _c_master_id; }
        }
        /// <summary>
        /// 改变前主键
        /// </summary>
        public string C_GP_BEFORE_ID
        {
            set { _c_gp_before_id = value; }
            get { return _c_gp_before_id; }
        }
        /// <summary>
        /// 改判后主键
        /// </summary>
        public string C_GP_AFTER_ID
        {
            set { _c_gp_after_id = value; }
            get { return _c_gp_after_id; }
        }
        /// <summary>
        /// 倒垛时间
        /// </summary>
        public DateTime? D_STACK_DATE
        {
            set { _d_stack_date = value; }
            get { return _d_stack_date; }
        }
        /// <summary>
        /// 倒垛人
        /// </summary>
        public string C_STACK_USER
        {
            set { _c_stack_user = value; }
            get { return _c_stack_user; }
        }
        /// <summary>
        /// 倒垛班次
        /// </summary>
        public string C_STACK_SHIFT
        {
            set { _c_stack_shift = value; }
            get { return _c_stack_shift; }
        }
        /// <summary>
        /// 倒垛班组
        /// </summary>
        public string C_STACK_GROUP
        {
            set { _c_stack_group = value; }
            get { return _c_stack_group; }
        }
        /// <summary>
        /// 是否已自动判定
        /// </summary>
        public string C_IS_PD
        {
            set { _c_is_pd = value; }
            get { return _c_is_pd; }
        }
        /// <summary>
        /// 表判不合格原因
        /// </summary>
        public string C_REASON_NAME
        {
            set { _c_reason_name = value; }
            get { return _c_reason_name; }
        }
        /// <summary>
        /// 发运单号
        /// </summary>
        public string C_FYDH
        {
            set { _c_fydh = value; }
            get { return _c_fydh; }
        }
        /// <summary>
        /// N默认状态;Y剔除坯
        /// </summary>
        public string C_SLAB_STATUS
        {
            set { _c_slab_status = value; }
            get { return _c_slab_status; }
        }
        /// <summary>
        /// 转库单号
        /// </summary>
        public string C_ZKDH
        {
            set { _c_zkdh = value; }
            get { return _c_zkdh; }
        }
        /// <summary>
        /// 转库单号主键
        /// </summary>
        public string C_ZKDHID
        {
            set { _c_zkdhid = value; }
            get { return _c_zkdhid; }
        }
        /// <summary>
        /// 炼钢记号
        /// </summary>
        public string C_LGJH
        {
            set { _c_lgjh = value; }
            get { return _c_lgjh; }
        }
        /// <summary>
        /// MES层
        /// </summary>
        public string C_MES_FLOOR
        {
            set { _c_mes_floor = value; }
            get { return _c_mes_floor; }
        }
        /// <summary>
        /// 净重
        /// </summary>
        public decimal? N_JZ
        {
            set { _n_jz = value; }
            get { return _n_jz; }
        }
        /// <summary>
        /// 是否缓冷
        /// </summary>
        public string C_HL
        {
            set { _c_hl = value; }
            get { return _c_hl; }
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
        /// 缓冷要求
        /// </summary>
        public string C_HLYQ
        {
            set { _c_hlyq = value; }
            get { return _c_hlyq; }
        }
        /// <summary>
        /// 大方坯连铸坯是否缓冷
        /// </summary>
        public string C_DFP_HL
        {
            set { _c_dfp_hl = value; }
            get { return _c_dfp_hl; }
        }
        /// <summary>
        /// 大方坯缓冷时间
        /// </summary>
        public decimal N_DFP_HL_TIME
        {
            set { _n_dfp_hl_time = value; }
            get { return _n_dfp_hl_time; }
        }
        /// <summary>
        /// 工艺路线 O
        /// </summary>
        public string C_ROUTE
        {
            set { _c_route = value; }
            get { return _c_route; }
        }
        /// <summary>
        /// 自由项1
        /// </summary>
        public string C_ZYX1
        {
            set { _c_zyx1 = value; }
            get { return _c_zyx1; }
        }
        /// <summary>
        /// 自由项2
        /// </summary>
        public string C_ZYX2
        {
            set { _c_zyx2 = value; }
            get { return _c_zyx2; }
        }
        #endregion Model

    }
}

