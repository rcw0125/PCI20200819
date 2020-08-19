using System;
namespace MODEL
{
    public partial class Mod_TRC_COGDOWN_PRODUCT
    {
        public Mod_TRC_COGDOWN_PRODUCT()
        { }
        #region Model
        private string _c_id = "sys_guid";
        private string _c_cogdown_id;
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
        private decimal? _n_qua;
        private decimal? _n_wgt;
        private string _c_std_code;
        private string _c_slab_type;
        private string _d_ccm_date;
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
        private string _c_stock_state;
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
        private string _c_is_qr;
        private string _c_qr_user;
        private DateTime? _d_qr_date;
        private DateTime? _d_q_date;
        private string _c_scutcheon;
        private string _c_gp_type;
        private string _c_remark;
        private DateTime? _d_start_date;
        private DateTime? _d_end_date;
        private string _c_cogdown_shift;
        private string _c_cogdown_group;
        private decimal? _n_status;
        private string _c_cog_sta_id;
        private string _c_move_shift;
        private string _c_move_group;
        private string _c_move_id;
        private DateTime? _c_move_start;
        private DateTime? _c_move_end;
        private decimal? _n_if_exec_status;
        private string _n_if_exec_remark;
        private string _c_zyx1;
        private string _c_zyx2;
        private string _c_extend1;
        private string _c_extend2;
        private string _c_extend3;
        private string _c_extend4;
        private string _c_extend5;
        private string _c_extend6;
        private string _c_extend7;
        private string _c_extend8;
        private string _c_extend9;
        private string _c_extend10;
        /// <summary>
        /// 主键
        /// </summary>
        public string C_ID
        {
            set { _c_id = value; }
            get { return _c_id; }
        }
        /// <summary>
        /// 开坯组批id
        /// </summary>
        public string C_COGDOWN_ID
        {
            set { _c_cogdown_id = value; }
            get { return _c_cogdown_id; }
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
        public decimal? N_QUA
        {
            set { _n_qua = value; }
            get { return _n_qua; }
        }
        /// <summary>
        /// 单重
        /// </summary>
        public decimal? N_WGT
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
        public string D_CCM_DATE
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
        /// N炼钢接收待入库CN剔除坯待入库CE剔除坯入库MN修磨待入库ME修磨入库PN开坯待入库PE开坯入库STN销售退坯待入库STE销售退坯入库D调拨DE调拨入库DZ待轧NP待开坯NM待修磨S销售DR待入炉R入炉C出炉
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
        /// 是否开坯Y
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
        /// 是否修磨
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
        /// 开始时间
        /// </summary>
        public DateTime? D_START_DATE
        {
            set { _d_start_date = value; }
            get { return _d_start_date; }
        }
        /// <summary>
        /// 结束时间
        /// </summary>
        public DateTime? D_END_DATE
        {
            set { _d_end_date = value; }
            get { return _d_end_date; }
        }

        /// <summary>
        /// 开坯班次
        /// </summary>
        public string C_COGDOWN_SHIFT
        {
            set { _c_cogdown_shift = value; }
            get { return _c_cogdown_shift; }
        }

        /// <summary>
        /// 开坯班次
        /// </summary>
        public string C_COGDOWN_GROUP
        {
            set { _c_cogdown_group = value; }
            get { return _c_cogdown_group; }
        }
        /// <summary>
        /// 是否调拨入库1未调拨入库2已调拨入库
        /// </summary>
        public decimal? N_STATUS
        {
            set { _n_status = value; }
            get { return _n_status; }
        }
        /// <summary>
        /// 开坯工位
        /// </summary>
        public string C_COG_STA_ID
        {
            set { _c_cog_sta_id = value; }
            get { return _c_cog_sta_id; }
        }

        /// <summary>
        /// 调拨班次
        /// </summary>
        public string C_MOVE_SHIFT
        {
            set { _c_move_shift = value; }
            get { return _c_move_shift; }
        }

        /// <summary>
        /// 调拨班组
        /// </summary>
        public string C_MOVE_GROUP
        {
            set { _c_move_group = value; }
            get { return _c_move_group; }
        }
        /// <summary>
        /// 调拨人
        /// </summary>
        public string C_MOVE_ID
        {
            set { _c_move_id = value; }
            get { return _c_move_id; }
        }

        /// <summary>
        /// 调拨开始时间
        /// </summary>
        public DateTime? C_MOVE_START
        {
            set { _c_move_start = value; }
            get { return _c_move_start; }
        }

        /// <summary>
        /// 调拨开始时间
        /// </summary>
        public DateTime? C_MOVE_END
        {
            set { _c_move_end = value; }
            get { return _c_move_end; }
        }

        /// <summary>
        /// 接口推送状态1.A1 2.A2 3.A3 4.A4 5.46
        /// </summary>
        public decimal? N_IF_EXEC_STATUS
        {
            set { _n_if_exec_status = value; }
            get { return _n_if_exec_status; }
        }
        /// <summary>
        /// 接口推送备注
        /// </summary>
        public string N_IF_EXEC_REMARK
        {
            set { _n_if_exec_remark = value; }
            get { return _n_if_exec_remark; }
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
        /// <summary>
        /// 
        /// </summary>
        public string C_EXTEND1
        {
            set { _c_extend1 = value; }
            get { return _c_extend1; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string C_EXTEND2
        {
            set { _c_extend2 = value; }
            get { return _c_extend2; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string C_EXTEND3
        {
            set { _c_extend3 = value; }
            get { return _c_extend3; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string C_EXTEND4
        {
            set { _c_extend4 = value; }
            get { return _c_extend4; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string C_EXTEND5
        {
            set { _c_extend5 = value; }
            get { return _c_extend5; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string C_EXTEND6
        {
            set { _c_extend6 = value; }
            get { return _c_extend6; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string C_EXTEND7
        {
            set { _c_extend7 = value; }
            get { return _c_extend7; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string C_EXTEND8
        {
            set { _c_extend8 = value; }
            get { return _c_extend8; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string C_EXTEND9
        {
            set { _c_extend9 = value; }
            get { return _c_extend9; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string C_EXTEND10
        {
            set { _c_extend10 = value; }
            get { return _c_extend10; }
        }
        #endregion Model
    }
}
