using System;
namespace MODEL
{
    public partial class Mod_TRC_ROLL_WGD_HANDLER_LOG
    {
        public Mod_TRC_ROLL_WGD_HANDLER_LOG()
        { }
        #region Model
        private string _c_id = "sys_guid";
        private string _c_sta_id;
        private string _c_wgd_id;
        private string _c_stove;
        private string _c_batch_no;
        private string _c_plan_id;
        private DateTime _d_mod_dt = Convert.ToDateTime(DateTime.Now);
        private decimal? _n_status;
        private string _c_std_code;
        private string _c_stl_grd;
        private string _c_spec;
        private string _c_pack;
        private string _c_free_term;
        private string _c_free_term2;
        private string _c_mrsx = "A";
        private string _c_mat_code;
        private string _c_mat_desc;
        private string _c_pclx;
        private string _c_newmrsx;
        private string _c_newpclx;
        private string _c_new_std_code;
        private string _c_new_stl_grd;
        private string _c_new_spec;
        private string _c_new_pack;
        private string _c_new_free_term;
        private string _c_new_free_term2;
        private string _c_new_mat_code;
        private string _c_new_mat_desc;
        private string _c_sx;
        private string _c_new_sx;

        /// <summary>
        /// 主键
        /// </summary>
        public string C_ID
        {
            set { _c_id = value; }
            get { return _c_id; }
        }
        /// <summary>
        /// 工位主键
        /// </summary>
        public string C_STA_ID
        {
            set { _c_sta_id = value; }
            get { return _c_sta_id; }
        }
        /// <summary>
        /// 完工单主键
        /// </summary>
        public string C_WGD_ID
        {
            set { _c_wgd_id = value; }
            get { return _c_wgd_id; }
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
        /// 批号
        /// </summary>
        public string C_BATCH_NO
        {
            set { _c_batch_no = value; }
            get { return _c_batch_no; }
        }
        /// <summary>
        /// 计划号
        /// </summary>
        public string C_PLAN_ID
        {
            set { _c_plan_id = value; }
            get { return _c_plan_id; }
        }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime D_MOD_DT
        {
            set { _d_mod_dt = value; }
            get { return _d_mod_dt; }
        }
        /// <summary>
        /// 状态1完工 2改判 3撤销
        /// </summary>
        public decimal? N_STATUS
        {
            set { _n_status = value; }
            get { return _n_status; }
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
        /// 钢种
        /// </summary>
        public string C_STL_GRD
        {
            set { _c_stl_grd = value; }
            get { return _c_stl_grd; }
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
        /// 包装要求
        /// </summary>
        public string C_PACK
        {
            set { _c_pack = value; }
            get { return _c_pack; }
        }
        /// <summary>
        /// 自由项
        /// </summary>
        public string C_FREE_TERM
        {
            set { _c_free_term = value; }
            get { return _c_free_term; }
        }
        /// <summary>
        /// 自由项2
        /// </summary>
        public string C_FREE_TERM2
        {
            set { _c_free_term2 = value; }
            get { return _c_free_term2; }
        }
        /// <summary>
        /// 默认属性
        /// </summary>
        public string C_MRSX
        {
            set { _c_mrsx = value; }
            get { return _c_mrsx; }
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
        public string C_MAT_DESC
        {
            set { _c_mat_desc = value; }
            get { return _c_mat_desc; }
        }
        /// <summary>
        /// 批次类型0普通材，1出口材
        /// </summary>
        public string C_PCLX
        {
            set { _c_pclx = value; }
            get { return _c_pclx; }
        }

        /// <summary>
        /// 完工属性
        /// </summary>
        public string C_NEWMRSX
        {
            set { _c_newmrsx = value; }
            get { return _c_newmrsx; }
        }

        /// <summary>
        /// 完工类型
        /// </summary>
        public string C_NEWPCLX
        {
            set { _c_newpclx = value; }
            get { return _c_newpclx; }
        }
        /// <summary>
        /// 完工执行标准
        /// </summary>
        public string C_NEW_STD_CODE
        {
            set { _c_new_std_code = value; }
            get { return _c_new_std_code; }
        }
        /// <summary>
        /// 完工钢种
        /// </summary>
        public string C_NEW_STL_GRD
        {
            set { _c_new_stl_grd = value; }
            get { return _c_new_stl_grd; }
        }
        /// <summary>
        /// 完工规格
        /// </summary>
        public string C_NEW_SPEC
        {
            set { _c_new_spec = value; }
            get { return _c_new_spec; }
        }
        /// <summary>
        /// 完工包装要求
        /// </summary>
        public string C_NEW_PACK
        {
            set { _c_new_pack = value; }
            get { return _c_new_pack; }
        }
        /// <summary>
        /// 完工自由项
        /// </summary>
        public string C_NEW_FREE_TERM
        {
            set { _c_new_free_term = value; }
            get { return _c_new_free_term; }
        }
        /// <summary>
        /// 完工自由项2
        /// </summary>
        public string C_NEW_FREE_TERM2
        {
            set { _c_new_free_term2 = value; }
            get { return _c_new_free_term2; }
        }
        /// <summary>
        /// 完工物料编码
        /// </summary>
        public string C_NEW_MAT_CODE
        {
            set { _c_new_mat_code = value; }
            get { return _c_new_mat_code; }
        }
        /// <summary>
        /// 完工物料名称
        /// </summary>
        public string C_NEW_MAT_DESC
        {
            set { _c_new_mat_desc = value; }
            get { return _c_new_mat_desc; }
        }
        /// <summary>
        /// 属性
        /// </summary>
        public string C_SX
        {
            set { _c_sx = value; }
            get { return _c_sx; }
        }
        /// <summary>
        /// 完工属性
        /// </summary>
        public string C_NEW_SX
        {
            set { _c_new_sx = value; }
            get { return _c_new_sx; }
        }
        #endregion Model

    }
}
