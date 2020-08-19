using System;
namespace MODEL
{
    /// <summary>
    /// 炼钢工艺卡
    /// </summary>
    [Serializable]
	public partial class Mod_TPB_LGGYK
	{
		public Mod_TPB_LGGYK()
		{}
		#region Model
		private string _c_id= "SYS_GUID";
		private string _c_steelgradeindex;
		private string _c_ladle_brick;
		private string _c_ladle_use;
		private string _c_ladle_pre_steelgrade;
		private string _c_ladle_stay;
		private string _c_bof_type;
		private string _c_ladle_tapped_proc;
		private string _c_lf_type;
		private string _c_rh_type;
		private string _c_caster_type;
		private decimal? _c_hot_send_flag;
		private string _c_c_min;
		private string _c_c_aim;
		private string _c_c_max;
		private string _c_si_min;
		private string _c_si_aim;
		private string _c_si_max;
		private string _c_mn_min;
		private string _c_mn_aim;
		private string _c_mn_max;
		private string _c_p_min;
		private string _c_p_aim;
		private string _c_p_max;
		private string _c_s_min;
		private string _c_s_aim;
		private string _c_s_max;
		private string _c_cu_min;
		private string _c_cu_aim;
		private string _c_cu_max;
		private string _c_ni_min;
		private string _c_ni_aim;
		private string _c_ni_max;
		private string _c_cr_min;
		private string _c_cr_aim;
		private string _c_cr_max;
		private string _c_mo_min;
		private string _c_mo_aim;
		private string _c_mo_max;
		private string _c_v_min;
		private string _c_v_aim;
		private string _c_v_max;
		private string _c_nb_min;
		private string _c_nb_aim;
		private string _c_nb_max;
		private string _c_al_min;
		private string _c_al_aim;
		private string _c_al_max;
		private string _c_als_min;
		private string _c_als_aim;
		private string _c_als_max;
		private string _c_ti_min;
		private string _c_ti_aim;
		private string _c_ti_max;
		private string _c_b_min;
		private string _c_b_aim;
		private string _c_b_max;
		private string _c_sb_min;
		private string _c_sb_aim;
		private string _c_sb_max;
		private string _c_sn_min;
		private string _c_sn_aim;
		private string _c_sn_max;
		private string _c_as_min;
		private string _c_as_aim;
		private string _c_as_max;
		private string _c_zn_min;
		private string _c_zn_aim;
		private string _c_zn_max;
		private string _c_zr_min;
		private string _c_zr_aim;
		private string _c_zr_max;
		private string _c_ca_min;
		private string _c_ca_aim;
		private string _c_ca_max;
		private string _c_w_min;
		private string _c_w_aim;
		private string _c_w_max;
		private string _c_pb_min;
		private string _c_pb_aim;
		private string _c_pb_max;
		private string _c_re_min;
		private string _c_re_aim;
		private string _c_re_max;
		private string _c_ceq_min;
		private string _c_ceq_aim;
		private string _c_ceq_max;
		private string _c_n_min;
		private string _c_n_aim;
		private string _c_n_max;
		private string _c_h_min;
		private string _c_h_aim;
		private string _c_h_max;
		private string _c_o_min;
		private string _c_o_aim;
		private string _c_o_max;
		private string _c_crni_min;
		private string _c_crni_aim;
		private string _c_crni_max;
		private string _c_crcu_min;
		private string _c_crcu_aim;
		private string _c_crcu_max;
		private string _c_crnicu_min;
		private string _c_crnicu_aim;
		private string _c_crnicu_max;
		private string _c_other1_min;
		private string _c_other1_aim;
		private string _c_other1_max;
		private string _c_other2_min;
		private string _c_other2_aim;
		private string _c_other2_max;
		private string _c_other3_min;
		private string _c_other3_aim;
		private string _c_other3_max;
		private string _c_aod_type;
		private string _c_name;
		/// <summary>
		/// 主键
		/// </summary>
		public string C_ID
		{
			set{ _c_id=value;}
			get{return _c_id;}
		}
		/// <summary>
		/// 炼钢记号
		/// </summary>
		public string C_STEELGRADEINDEX
		{
			set{ _c_steelgradeindex=value;}
			get{return _c_steelgradeindex;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string C_LADLE_BRICK
		{
			set{ _c_ladle_brick=value;}
			get{return _c_ladle_brick;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string C_LADLE_USE
		{
			set{ _c_ladle_use=value;}
			get{return _c_ladle_use;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string C_LADLE_PRE_STEELGRADE
		{
			set{ _c_ladle_pre_steelgrade=value;}
			get{return _c_ladle_pre_steelgrade;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string C_LADLE_STAY
		{
			set{ _c_ladle_stay=value;}
			get{return _c_ladle_stay;}
		}
		/// <summary>
		/// 01--1、2、3#转炉；02--4#转炉；03--AOD转炉；未知转炉
		/// </summary>
		public string C_BOF_TYPE
		{
			set{ _c_bof_type=value;}
			get{return _c_bof_type;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string C_LADLE_TAPPED_PROC
		{
			set{ _c_ladle_tapped_proc=value;}
			get{return _c_ladle_tapped_proc;}
		}
		/// <summary>
		/// 01--不经过LF；02--1、2、4、5#LF；03--3#LF；04--4#LF；未知LF路径；
		/// </summary>
		public string C_LF_TYPE
		{
			set{ _c_lf_type=value;}
			get{return _c_lf_type;}
		}
		/// <summary>
		/// 01--不经过RH；02--1#RH；未知RH；
		/// </summary>
		public string C_RH_TYPE
		{
			set{ _c_rh_type=value;}
			get{return _c_rh_type;}
		}
		/// <summary>
		/// 01--1、2#铸机；02--3、4#铸机；03--5#铸机（如果过LF，则LF为3#LF）；04--6#铸机；05--7#铸机；未知铸机；
		/// </summary>
		public string C_CASTER_TYPE
		{
			set{ _c_caster_type=value;}
			get{return _c_caster_type;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? C_HOT_SEND_FLAG
		{
			set{ _c_hot_send_flag=value;}
			get{return _c_hot_send_flag;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string C_C_MIN
		{
			set{ _c_c_min=value;}
			get{return _c_c_min;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string C_C_AIM
		{
			set{ _c_c_aim=value;}
			get{return _c_c_aim;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string C_C_MAX
		{
			set{ _c_c_max=value;}
			get{return _c_c_max;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string C_SI_MIN
		{
			set{ _c_si_min=value;}
			get{return _c_si_min;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string C_SI_AIM
		{
			set{ _c_si_aim=value;}
			get{return _c_si_aim;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string C_SI_MAX
		{
			set{ _c_si_max=value;}
			get{return _c_si_max;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string C_MN_MIN
		{
			set{ _c_mn_min=value;}
			get{return _c_mn_min;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string C_MN_AIM
		{
			set{ _c_mn_aim=value;}
			get{return _c_mn_aim;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string C_MN_MAX
		{
			set{ _c_mn_max=value;}
			get{return _c_mn_max;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string C_P_MIN
		{
			set{ _c_p_min=value;}
			get{return _c_p_min;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string C_P_AIM
		{
			set{ _c_p_aim=value;}
			get{return _c_p_aim;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string C_P_MAX
		{
			set{ _c_p_max=value;}
			get{return _c_p_max;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string C_S_MIN
		{
			set{ _c_s_min=value;}
			get{return _c_s_min;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string C_S_AIM
		{
			set{ _c_s_aim=value;}
			get{return _c_s_aim;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string C_S_MAX
		{
			set{ _c_s_max=value;}
			get{return _c_s_max;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string C_CU_MIN
		{
			set{ _c_cu_min=value;}
			get{return _c_cu_min;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string C_CU_AIM
		{
			set{ _c_cu_aim=value;}
			get{return _c_cu_aim;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string C_CU_MAX
		{
			set{ _c_cu_max=value;}
			get{return _c_cu_max;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string C_NI_MIN
		{
			set{ _c_ni_min=value;}
			get{return _c_ni_min;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string C_NI_AIM
		{
			set{ _c_ni_aim=value;}
			get{return _c_ni_aim;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string C_NI_MAX
		{
			set{ _c_ni_max=value;}
			get{return _c_ni_max;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string C_CR_MIN
		{
			set{ _c_cr_min=value;}
			get{return _c_cr_min;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string C_CR_AIM
		{
			set{ _c_cr_aim=value;}
			get{return _c_cr_aim;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string C_CR_MAX
		{
			set{ _c_cr_max=value;}
			get{return _c_cr_max;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string C_MO_MIN
		{
			set{ _c_mo_min=value;}
			get{return _c_mo_min;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string C_MO_AIM
		{
			set{ _c_mo_aim=value;}
			get{return _c_mo_aim;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string C_MO_MAX
		{
			set{ _c_mo_max=value;}
			get{return _c_mo_max;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string C_V_MIN
		{
			set{ _c_v_min=value;}
			get{return _c_v_min;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string C_V_AIM
		{
			set{ _c_v_aim=value;}
			get{return _c_v_aim;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string C_V_MAX
		{
			set{ _c_v_max=value;}
			get{return _c_v_max;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string C_NB_MIN
		{
			set{ _c_nb_min=value;}
			get{return _c_nb_min;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string C_NB_AIM
		{
			set{ _c_nb_aim=value;}
			get{return _c_nb_aim;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string C_NB_MAX
		{
			set{ _c_nb_max=value;}
			get{return _c_nb_max;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string C_AL_MIN
		{
			set{ _c_al_min=value;}
			get{return _c_al_min;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string C_AL_AIM
		{
			set{ _c_al_aim=value;}
			get{return _c_al_aim;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string C_AL_MAX
		{
			set{ _c_al_max=value;}
			get{return _c_al_max;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string C_ALS_MIN
		{
			set{ _c_als_min=value;}
			get{return _c_als_min;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string C_ALS_AIM
		{
			set{ _c_als_aim=value;}
			get{return _c_als_aim;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string C_ALS_MAX
		{
			set{ _c_als_max=value;}
			get{return _c_als_max;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string C_TI_MIN
		{
			set{ _c_ti_min=value;}
			get{return _c_ti_min;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string C_TI_AIM
		{
			set{ _c_ti_aim=value;}
			get{return _c_ti_aim;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string C_TI_MAX
		{
			set{ _c_ti_max=value;}
			get{return _c_ti_max;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string C_B_MIN
		{
			set{ _c_b_min=value;}
			get{return _c_b_min;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string C_B_AIM
		{
			set{ _c_b_aim=value;}
			get{return _c_b_aim;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string C_B_MAX
		{
			set{ _c_b_max=value;}
			get{return _c_b_max;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string C_SB_MIN
		{
			set{ _c_sb_min=value;}
			get{return _c_sb_min;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string C_SB_AIM
		{
			set{ _c_sb_aim=value;}
			get{return _c_sb_aim;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string C_SB_MAX
		{
			set{ _c_sb_max=value;}
			get{return _c_sb_max;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string C_SN_MIN
		{
			set{ _c_sn_min=value;}
			get{return _c_sn_min;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string C_SN_AIM
		{
			set{ _c_sn_aim=value;}
			get{return _c_sn_aim;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string C_SN_MAX
		{
			set{ _c_sn_max=value;}
			get{return _c_sn_max;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string C_AS_MIN
		{
			set{ _c_as_min=value;}
			get{return _c_as_min;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string C_AS_AIM
		{
			set{ _c_as_aim=value;}
			get{return _c_as_aim;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string C_AS_MAX
		{
			set{ _c_as_max=value;}
			get{return _c_as_max;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string C_ZN_MIN
		{
			set{ _c_zn_min=value;}
			get{return _c_zn_min;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string C_ZN_AIM
		{
			set{ _c_zn_aim=value;}
			get{return _c_zn_aim;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string C_ZN_MAX
		{
			set{ _c_zn_max=value;}
			get{return _c_zn_max;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string C_ZR_MIN
		{
			set{ _c_zr_min=value;}
			get{return _c_zr_min;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string C_ZR_AIM
		{
			set{ _c_zr_aim=value;}
			get{return _c_zr_aim;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string C_ZR_MAX
		{
			set{ _c_zr_max=value;}
			get{return _c_zr_max;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string C_CA_MIN
		{
			set{ _c_ca_min=value;}
			get{return _c_ca_min;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string C_CA_AIM
		{
			set{ _c_ca_aim=value;}
			get{return _c_ca_aim;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string C_CA_MAX
		{
			set{ _c_ca_max=value;}
			get{return _c_ca_max;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string C_W_MIN
		{
			set{ _c_w_min=value;}
			get{return _c_w_min;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string C_W_AIM
		{
			set{ _c_w_aim=value;}
			get{return _c_w_aim;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string C_W_MAX
		{
			set{ _c_w_max=value;}
			get{return _c_w_max;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string C_PB_MIN
		{
			set{ _c_pb_min=value;}
			get{return _c_pb_min;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string C_PB_AIM
		{
			set{ _c_pb_aim=value;}
			get{return _c_pb_aim;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string C_PB_MAX
		{
			set{ _c_pb_max=value;}
			get{return _c_pb_max;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string C_RE_MIN
		{
			set{ _c_re_min=value;}
			get{return _c_re_min;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string C_RE_AIM
		{
			set{ _c_re_aim=value;}
			get{return _c_re_aim;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string C_RE_MAX
		{
			set{ _c_re_max=value;}
			get{return _c_re_max;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string C_CEQ_MIN
		{
			set{ _c_ceq_min=value;}
			get{return _c_ceq_min;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string C_CEQ_AIM
		{
			set{ _c_ceq_aim=value;}
			get{return _c_ceq_aim;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string C_CEQ_MAX
		{
			set{ _c_ceq_max=value;}
			get{return _c_ceq_max;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string C_N_MIN
		{
			set{ _c_n_min=value;}
			get{return _c_n_min;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string C_N_AIM
		{
			set{ _c_n_aim=value;}
			get{return _c_n_aim;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string C_N_MAX
		{
			set{ _c_n_max=value;}
			get{return _c_n_max;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string C_H_MIN
		{
			set{ _c_h_min=value;}
			get{return _c_h_min;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string C_H_AIM
		{
			set{ _c_h_aim=value;}
			get{return _c_h_aim;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string C_H_MAX
		{
			set{ _c_h_max=value;}
			get{return _c_h_max;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string C_O_MIN
		{
			set{ _c_o_min=value;}
			get{return _c_o_min;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string C_O_AIM
		{
			set{ _c_o_aim=value;}
			get{return _c_o_aim;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string C_O_MAX
		{
			set{ _c_o_max=value;}
			get{return _c_o_max;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string C_CRNI_MIN
		{
			set{ _c_crni_min=value;}
			get{return _c_crni_min;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string C_CRNI_AIM
		{
			set{ _c_crni_aim=value;}
			get{return _c_crni_aim;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string C_CRNI_MAX
		{
			set{ _c_crni_max=value;}
			get{return _c_crni_max;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string C_CRCU_MIN
		{
			set{ _c_crcu_min=value;}
			get{return _c_crcu_min;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string C_CRCU_AIM
		{
			set{ _c_crcu_aim=value;}
			get{return _c_crcu_aim;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string C_CRCU_MAX
		{
			set{ _c_crcu_max=value;}
			get{return _c_crcu_max;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string C_CRNICU_MIN
		{
			set{ _c_crnicu_min=value;}
			get{return _c_crnicu_min;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string C_CRNICU_AIM
		{
			set{ _c_crnicu_aim=value;}
			get{return _c_crnicu_aim;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string C_CRNICU_MAX
		{
			set{ _c_crnicu_max=value;}
			get{return _c_crnicu_max;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string C_OTHER1_MIN
		{
			set{ _c_other1_min=value;}
			get{return _c_other1_min;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string C_OTHER1_AIM
		{
			set{ _c_other1_aim=value;}
			get{return _c_other1_aim;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string C_OTHER1_MAX
		{
			set{ _c_other1_max=value;}
			get{return _c_other1_max;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string C_OTHER2_MIN
		{
			set{ _c_other2_min=value;}
			get{return _c_other2_min;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string C_OTHER2_AIM
		{
			set{ _c_other2_aim=value;}
			get{return _c_other2_aim;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string C_OTHER2_MAX
		{
			set{ _c_other2_max=value;}
			get{return _c_other2_max;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string C_OTHER3_MIN
		{
			set{ _c_other3_min=value;}
			get{return _c_other3_min;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string C_OTHER3_AIM
		{
			set{ _c_other3_aim=value;}
			get{return _c_other3_aim;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string C_OTHER3_MAX
		{
			set{ _c_other3_max=value;}
			get{return _c_other3_max;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string C_AOD_TYPE
		{
			set{ _c_aod_type=value;}
			get{return _c_aod_type;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string C_NAME
		{
			set{ _c_name=value;}
			get{return _c_name;}
		}
		#endregion Model

	}
}

