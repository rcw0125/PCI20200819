using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MODEL
{
    public partial class Mod_TRC_COGDOWN_PRODUCT_LOG
    {
        public Mod_TRC_COGDOWN_PRODUCT_LOG()
        { }
        #region Model
        private string _c_id = "sys_guid";
        private string _c_batch_no;
        private decimal? _n_qua;
        private decimal? _n_wgt;
        private string _c_trc_cogdown_main_id;
        private DateTime? _d_mod_dt = Convert.ToDateTime(DateTime.Now);
        private string _c_emp_id;
        private string _c_sta_id;
        private decimal? _n_type;
        private string _c_shift;
        private string _c_group;
        private string _c_remark;
        private decimal? _c_scrap;
        private string _c_slb_main_id;
        private decimal? _n_planqua;
        private decimal? _n_planwgt;
        /// <summary>
        /// 主键
        /// </summary>
        public string C_ID
        {
            set { _c_id = value; }
            get { return _c_id; }
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
        /// 开坯支数
        /// </summary>
        public decimal? N_QUA
        {
            set { _n_qua = value; }
            get { return _n_qua; }
        }
        /// <summary>
        /// 开坯重量
        /// </summary>
        public decimal? N_WGT
        {
            set { _n_wgt = value; }
            get { return _n_wgt; }
        }
        /// <summary>
        /// 组批表主键
        /// </summary>
        public string C_TRC_COGDOWN_MAIN_ID
        {
            set { _c_trc_cogdown_main_id = value; }
            get { return _c_trc_cogdown_main_id; }
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
        /// 操作类型 1操作 2撤回
        /// </summary>
        public decimal? N_TYPE
        {
            set { _n_type = value; }
            get { return _n_type; }
        }
        /// <summary>
        /// 组批班次
        /// </summary>
        public string C_SHIFT
        {
            set { _c_shift = value; }
            get { return _c_shift; }
        }
        /// <summary>
        /// 组批班组
        /// </summary>
        public string C_GROUP
        {
            set { _c_group = value; }
            get { return _c_group; }
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
        /// 报废支数
        /// </summary>
        public decimal? C_SCRAP
        {
            set { _c_scrap = value; }
            get { return _c_scrap; }
        }

        /// <summary>
        /// 钢坯id
        /// </summary>
        public string C_SLAB_MAIN_ID
        {
            set { _c_slb_main_id = value; }
            get { return _c_slb_main_id; }
        }

        /// <summary>
        /// 计划数量
        /// </summary>
        public decimal? N_PLANQUA
        {
            set { _n_planqua = value; }
            get { return _n_planqua; }
        }

        /// <summary>
        /// 计划重量
        /// </summary>
        public decimal? N_PLANWGT
        {
            set { _n_planwgt = value; }
            get { return _n_planwgt; }
        }
        #endregion Model
    }
}
