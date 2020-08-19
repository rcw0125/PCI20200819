using System;
namespace MODEL
{
    public partial class Mod_TSC_ALLOT_CENTER
    {
        public Mod_TSC_ALLOT_CENTER()
        { }
        #region Model
        private string _c_id = "sys_guid";
        private string _c_slab_main_id;
        private decimal? _n_type;
        private DateTime? _d_mod_dt = Convert.ToDateTime(DateTime.Now);
        private string _c_emp_id;
        private string _c_sta_id;
        private string _c_slabwh_code;
        private string _c_slabwh_area_code;
        private string _c_slabwh_loc_code;
        private string _c_slabwh_tier_code;
        private string _c_stl_grd;
        private string _c_spec;
        private string _c_std_code;
        private string _c_mat_code;
        private string _c_mat_name;
        private decimal? _n_len;
        private string _c_stove;

        /// <summary>
        /// 主键
        /// </summary>
        public string C_ID
        {
            set { _c_id = value; }
            get { return _c_id; }
        }
        /// <summary>
        /// 钢坯主键
        /// </summary>
        public string C_SLAB_MAIN_ID
        {
            set { _c_slab_main_id = value; }
            get { return _c_slab_main_id; }
        }
        /// <summary>
        /// 调拨类型 1调拨中 2已入库 3调拨撤销
        /// </summary>
        public decimal? N_TYPE
        {
            set { _n_type = value; }
            get { return _n_type; }
        }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime? D_MOD_DT
        {
            set { _d_mod_dt = value; }
            get { return _d_mod_dt; }
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
        /// 工位主键
        /// </summary>
        public string C_STA_ID
        {
            set { _c_sta_id = value; }
            get { return _c_sta_id; }
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
        /// 执行标准
        /// </summary>
        public string C_STD_CODE
        {
            set { _c_std_code = value; }
            get { return _c_std_code; }
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
        /// 长度
        /// </summary>
        public decimal? N_LEN
        {
            set { _n_len = value; }
            get { return _n_len; }
        }

        /// <summary>
        /// 炉号
        /// </summary>
       public string C_STOVE
        {
            set { _c_stove = value; }
            get { return _c_stove; }
        }
        #endregion 
    }
}
