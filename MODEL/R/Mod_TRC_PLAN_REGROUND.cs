using System;
namespace MODEL
{

    /// <summary>
    /// 修磨计划
    /// </summary>
    [Serializable]
    public partial class Mod_TRC_PLAN_REGROUND
    {
        public Mod_TRC_PLAN_REGROUND()
        { }
        #region Model
        private string _c_id = "sys_guid";
        private string _c_batch_no;
        private string _c_stove;
        private string _c_stl_grd;
        private string _c_mat_code;
        private string _c_mat_name;
        private string _c_spec;
        private decimal? _n_len;
        private decimal? _n_qua;
        private decimal? _n_wgt;
        private string _c_std_code;
        private string _c_slab_type;
        private decimal _n_status = 0;
        private string _c_remark;
        private string _c_xmgx;
        private decimal? _n_totalstep;
        private DateTime _d_qr_date = Convert.ToDateTime(DateTime.Now);
        private DateTime? _d_q_date;
        private decimal? _n_qua_virtual;
        private string _c_slabwh_code;
        private string _c_slabwh_area_code;
        private string _c_slabwh_loc_code;
        private string _c_slabwh_tier_code;
        private string _c_xmgx_grd;
        private decimal? _n_type;
        private string _c_extend1;
        private string _c_extend2;
        private string _c_extend3;
        private string _c_extend4;
        private string _c_extend5;
        private string _c_extend11;
        private string _c_extend16;
        private string _c_extend17;
        private string _c_extend18;
        private string _c_slabwh_xlloc_code;
        private string _c_emp_code;

        /// <summary>
        /// 主键
        /// </summary>
        public string C_ID
        {
            set { _c_id = value; }
            get { return _c_id; }
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
        /// 炉号
        /// </summary>
        public string C_STOVE
        {
            set { _c_stove = value; }
            get { return _c_stove; }
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
        /// 状态0进行中1已完成
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
        /// 修磨工序，修磨>扒皮
        /// </summary>
        public string C_XMGX
        {
            set { _c_xmgx = value; }
            get { return _c_xmgx; }
        }
        /// <summary>
        /// 总步骤
        /// </summary>
        public decimal? N_TOTALSTEP
        {
            set { _n_totalstep = value; }
            get { return _n_totalstep; }
        }
        /// <summary>
        /// 确认时间
        /// </summary>
        public DateTime D_QR_DATE
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
        /// 支数
        /// </summary>
        public decimal? N_QUA_VIRTUAL
        {
            set { _n_qua_virtual = value; }
            get { return _n_qua_virtual; }
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
        /// 钢坯（修磨工序）
        /// </summary>
        public string C_XMGX_GRD
        {
            set { _c_xmgx_grd = value; }
            get { return _c_xmgx_grd; }
        }

        /// <summary>
        /// 类型
        /// </summary>
        public decimal? N_TYPE
        {
            set { _n_type = value; }
            get { return _n_type; }
        }

        /// <summary>
        /// 全修2mm
        /// </summary>
        public string C_EXTEND1
        {
            set { _c_extend1 = value; }
            get { return _c_extend1; }
        }

        /// <summary>
        /// 全修1.5mm
        /// </summary>
        public string C_EXTEND2
        {
            set { _c_extend2 = value; }
            get { return _c_extend2; }
        }

        /// <summary>
        /// 全修1mm
        /// </summary>
        public string C_EXTEND3
        {
            set { _c_extend3 = value; }
            get { return _c_extend3; }
        }

        /// <summary>
        /// 精修0.5mm
        /// </summary>
        public string C_EXTEND4
        {
            set { _c_extend4 = value; }
            get { return _c_extend4; }
        }


        /// <summary>
        /// 修角刺
        /// </summary>
        public string C_EXTEND5
        {
            set { _c_extend5 = value; }
            get { return _c_extend5; }
        }

        /// <summary>
        /// 剔除支数
        /// </summary>
        public string C_EXTEND11
        {
            set { _c_extend11 = value; }
            get { return _c_extend11; }
        }

        /// <summary>
        /// 剔除支数
        /// </summary>
        public string C_EXTEND16
        {
            set { _c_extend16 = value; }
            get { return _c_extend16; }
        }
        /// <summary>
        /// 剔除支数
        /// </summary>
        public string C_EXTEND17
        {
            set { _c_extend17 = value; }
            get { return _c_extend17; }
        }
        /// <summary>
        /// 剔除支数
        /// </summary>
        public string C_EXTEND18
        {
            set { _c_extend18 = value; }
            get { return _c_extend18; }
        }
        /// <summary>
        /// 下料货位
        /// </summary>
        public string C_SLABWH_XLLOC_CODE
        {
            set { _c_slabwh_xlloc_code = value; }
            get { return _c_slabwh_xlloc_code; }
        }
        /// <summary>
        /// 下料货位
        /// </summary>
        public string C_EMP_CODE
        {
            set { _c_emp_code = value; }
            get { return _c_emp_code; }
        }
        #endregion Model
    }
}
