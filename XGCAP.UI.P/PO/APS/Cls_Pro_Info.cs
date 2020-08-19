using BLL;
using Common;
using MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;

namespace XGCAP.UI.P.PO.APS
{
    /// <summary>
    /// 炉次计划排产临时表
    /// </summary>
    [Serializable]
    public partial class Cls_Pro_Info
    {
        public Cls_Pro_Info()
        { }
        #region Model
       
        private decimal? _n_slab_wgt;
        
        private string _c_ccm_id;
        private string _c_ccm_desc;
        private string _c_prod_name;
        private string _c_stl_grd;
       
        private string _c_matrl_no;
        private string _c_matrl_name;
        private string _c_slab_size;
        private string _c_slab_length;
        private string _c_state;
        private string _c_std_code;
        private string _c_remark;
        private string _c_zl_id;
        private string _c_lf_id;
        private string _c_rh_id;
        private string _c_qua;
        private string _c_by1;
        private string _c_by2;
        private string _c_by3;
        private string _c_rh;
        private string _c_kp;
        private string _c_dfp_hl;
        private string _c_hl;
        private string _c_dfp_hl_yq;
        private string _c_hl_yq;
        private string _c_xm;
        private string _c_xmyq;
        private decimal _n_dfp_hl_time = 0M;
        private decimal _n_hl_time = 0M;
        private string _c_route;
        private decimal? _n_slab_pw;
        private string _c_matrl_code_kp;
        private string _c_matrl_name_kp;
        private string _c_kp_size;
        private decimal? _n_kp_length;
        private decimal? _n_kp_pw;
        private decimal? _n_rh_num;
        private decimal? _n_kp_wgt;
        private decimal? _n_xm_wgt;
        private string _c_dfp_rz;
        private string _c_rzp_rz;
        private string _c_dfp_yq;
        private string _c_rzp_yq;
        private string _c_stl_grd_type;
        private string _c_prod_kind;
        private string _c_tl;
        private decimal? _n_jscn = 0M;
        private string _c_free2;
        private decimal? _n_group;
        private decimal? _n_zjcls;
        private decimal? _n_zjcls_min = 0M;
        private decimal? _n_zjcls_max = 0M;
        private string _c_sl;
        private string _c_wl;
        private string _c_free1;
        private string _c_bxg;
        /// <summary>
        /// 坯料重量
        /// </summary>
        public decimal? N_SLAB_WGT
        {
            set { _n_slab_wgt = value; }
            get { return _n_slab_wgt; }
        }
        /// <summary>
        /// 是否是不锈钢
        /// </summary>
        public string C_BXG
        {
            set { _c_bxg = value; }
            get { return _c_bxg; }
        }
        /// <summary>
        /// 连铸机主键
        /// </summary>
        public string C_CCM_ID
        {
            set { _c_ccm_id = value; }
            get { return _c_ccm_id; }
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
        /// 类别
        /// </summary>
        public string C_PROD_NAME
        {
            set { _c_prod_name = value; }
            get { return _c_prod_name; }
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
        /// 连铸钢坯断面
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
        /// 0有计划1非计划
        /// </summary>
        public string C_STATE
        {
            set { _c_state = value; }
            get { return _c_state; }
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
        /// 备注
        /// </summary>
        public string C_REMARK
        {
            set { _c_remark = value; }
            get { return _c_remark; }
        }
       
       
        /// <summary>
        /// 转炉主键
        /// </summary>
        public string C_ZL_ID
        {
            set { _c_zl_id = value; }
            get { return _c_zl_id; }
        }
        /// <summary>
        /// 精炼主键
        /// </summary>
        public string C_LF_ID
        {
            set { _c_lf_id = value; }
            get { return _c_lf_id; }
        }
        /// <summary>
        /// 真空主键
        /// </summary>
        public string C_RH_ID
        {
            set { _c_rh_id = value; }
            get { return _c_rh_id; }
        }
        
        /// <summary>
        /// 支数
        /// </summary>
        public string C_QUA
        {
            set { _c_qua = value; }
            get { return _c_qua; }
        }
       
        /// <summary>
        /// 备用1
        /// </summary>
        public string C_BY1
        {
            set { _c_by1 = value; }
            get { return _c_by1; }
        }
        /// <summary>
        /// 备用2
        /// </summary>
        public string C_BY2
        {
            set { _c_by2 = value; }
            get { return _c_by2; }
        }
        /// <summary>
        /// 备用3钢种颜色
        /// </summary>
        public string C_BY3
        {
            set { _c_by3 = value; }
            get { return _c_by3; }
        }
        /// <summary>
        /// 是否过真空
        /// </summary>
        public string C_RH
        {
            set { _c_rh = value; }
            get { return _c_rh; }
        }
        /// <summary>
        /// 是否开坯
        /// </summary>
        public string C_KP
        {
            set { _c_kp = value; }
            get { return _c_kp; }
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
        /// 小方坯或热轧坯是否缓冷
        /// </summary>
        public string C_HL
        {
            set { _c_hl = value; }
            get { return _c_hl; }
        }

        /// <summary>
        /// 大方坯连铸坯缓冷要求
        /// </summary>
        public string C_DFP_HL_YQ
        {
            set { _c_dfp_hl_yq = value; }
            get { return _c_dfp_hl_yq; }
        }
        /// <summary>
        /// 小方坯或热轧坯缓冷要求
        /// </summary>
        public string C_HL_YQ
        {
            set { _c_hl_yq = value; }
            get { return _c_hl_yq; }
        }
        /// <summary>
        /// 是否修磨
        /// </summary>
        public string C_XM
        {
            set { _c_xm = value; }
            get { return _c_xm; }
        }

        /// <summary>
        /// 是否修磨
        /// </summary>
        public string C_XMYQ
        {
            set { _c_xmyq = value; }
            get { return _c_xmyq; }
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
        /// 缓冷时间
        /// </summary>
        public decimal N_HL_TIME
        {
            set { _n_hl_time = value; }
            get { return _n_hl_time; }
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
        /// RH炉连浇次数
        /// </summary>
        public decimal? N_RH_NUM
        {
            set { _n_rh_num = value; }
            get { return _n_rh_num; }
        }
        /// <summary>
        /// 已开坯重量
        /// </summary>
        public decimal? N_KP_WGT
        {
            set { _n_kp_wgt = value; }
            get { return _n_kp_wgt; }
        }
        /// <summary>
        /// 已修磨重量
        /// </summary>
        public decimal? N_XM_WGT
        {
            set { _n_xm_wgt = value; }
            get { return _n_xm_wgt; }
        }
        /// <summary>
        /// 大方坯能否热装
        /// </summary>
        public string C_DFP_RZ
        {
            set { _c_dfp_rz = value; }
            get { return _c_dfp_rz; }
        }
        /// <summary>
        /// 热轧坯能否热装
        /// </summary>
        public string C_RZP_RZ
        {
            set { _c_rzp_rz = value; }
            get { return _c_rzp_rz; }
        }
        /// <summary>
        /// 大方坯缓冷要求
        /// </summary>
        public string C_DFP_YQ
        {
            set { _c_dfp_yq = value; }
            get { return _c_dfp_yq; }
        }
        /// <summary>
        /// 热轧坯缓冷要求
        /// </summary>
        public string C_RZP_YQ
        {
            set { _c_rzp_yq = value; }
            get { return _c_rzp_yq; }
        }
        /// <summary>
        /// 钢种类别
        /// </summary>
        public string C_STL_GRD_TYPE
        {
            set { _c_stl_grd_type = value; }
            get { return _c_stl_grd_type; }
        }
        /// <summary>
        /// 品种
        /// </summary>
        public string C_PROD_KIND
        {
            set { _c_prod_kind = value; }
            get { return _c_prod_kind; }
        }
        /// <summary>
        /// 是否脱硫
        /// </summary>
        public string C_TL
        {
            set { _c_tl = value; }
            get { return _c_tl; }
        }
        /// <summary>
        /// 机时产能
        /// </summary>
        public decimal? N_JSCN
        {
            set { _n_jscn = value; }
            get { return _n_jscn; }
        }
        /// <summary>
        /// 自由项2
        /// </summary>
        public string C_FREE2
        {
            set { _c_free2 = value; }
            get { return _c_free2; }
        }
        /// <summary>
        /// 连铸排产时的分组号
        /// </summary>
        public decimal? N_GROUP
        {
            set { _n_group = value; }
            get { return _n_group; }
        }
        /// <summary>
        /// 整浇次炉数
        /// </summary>
        public decimal? N_ZJCLS
        {
            set { _n_zjcls = value; }
            get { return _n_zjcls; }
        }
        /// <summary>
        /// 整浇次炉数(最少)
        /// </summary>
        public decimal? N_ZJCLS_MIN
        {
            set { _n_zjcls_min = value; }
            get { return _n_zjcls_min; }
        }
        /// <summary>
        /// 整浇次炉数(最大)
        /// </summary>
        public decimal? N_ZJCLS_MAX
        {
            set { _n_zjcls_max = value; }
            get { return _n_zjcls_max; }
        }
        /// <summary>
        /// 是否需要首炉过渡
        /// </summary>
        public string C_SL
        {
            set { _c_sl = value; }
            get { return _c_sl; }
        }
        /// <summary>
        /// 是否需要尾炉过渡
        /// </summary>
        public string C_WL
        {
            set { _c_wl = value; }
            get { return _c_wl; }
        }
        
        /// <summary>
        /// 自由项1
        /// </summary>
        public string C_FREE1
        {
            set { _c_free1 = value; }
            get { return _c_free1; }
        }
        #endregion Model

    }
}

