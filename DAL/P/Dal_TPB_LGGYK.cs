using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;
namespace DAL
{
    /// <summary>
    /// 数据访问类:TPB_LGGYK
    /// </summary>
    public partial class Dal_TPB_LGGYK
    {
        public Dal_TPB_LGGYK()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string C_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TPB_LGGYK");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,250)         };
            parameters[0].Value = C_ID;

            return DbHelperOra.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Mod_TPB_LGGYK model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TPB_LGGYK(");
            strSql.Append("C_STEELGRADEINDEX,C_LADLE_BRICK,C_LADLE_USE,C_LADLE_PRE_STEELGRADE,C_LADLE_STAY,C_BOF_TYPE,C_LADLE_TAPPED_PROC,C_LF_TYPE,C_RH_TYPE,C_CASTER_TYPE,C_HOT_SEND_FLAG,C_C_MIN,C_C_AIM,C_C_MAX,C_SI_MIN,C_SI_AIM,C_SI_MAX,C_MN_MIN,C_MN_AIM,C_MN_MAX,C_P_MIN,C_P_AIM,C_P_MAX,C_S_MIN,C_S_AIM,C_S_MAX,C_CU_MIN,C_CU_AIM,C_CU_MAX,C_NI_MIN,C_NI_AIM,C_NI_MAX,C_CR_MIN,C_CR_AIM,C_CR_MAX,C_MO_MIN,C_MO_AIM,C_MO_MAX,C_V_MIN,C_V_AIM,C_V_MAX,C_NB_MIN,C_NB_AIM,C_NB_MAX,C_AL_MIN,C_AL_AIM,C_AL_MAX,C_ALS_MIN,C_ALS_AIM,C_ALS_MAX,C_TI_MIN,C_TI_AIM,C_TI_MAX,C_B_MIN,C_B_AIM,C_B_MAX,C_SB_MIN,C_SB_AIM,C_SB_MAX,C_SN_MIN,C_SN_AIM,C_SN_MAX,C_AS_MIN,C_AS_AIM,C_AS_MAX,C_ZN_MIN,C_ZN_AIM,C_ZN_MAX,C_ZR_MIN,C_ZR_AIM,C_ZR_MAX,C_CA_MIN,C_CA_AIM,C_CA_MAX,C_W_MIN,C_W_AIM,C_W_MAX,C_PB_MIN,C_PB_AIM,C_PB_MAX,C_RE_MIN,C_RE_AIM,C_RE_MAX,C_CEQ_MIN,C_CEQ_AIM,C_CEQ_MAX,C_N_MIN,C_N_AIM,C_N_MAX,C_H_MIN,C_H_AIM,C_H_MAX,C_O_MIN,C_O_AIM,C_O_MAX,C_CRNI_MIN,C_CRNI_AIM,C_CRNI_MAX,C_CRCU_MIN,C_CRCU_AIM,C_CRCU_MAX,C_CRNICU_MIN,C_CRNICU_AIM,C_CRNICU_MAX,C_OTHER1_MIN,C_OTHER1_AIM,C_OTHER1_MAX,C_OTHER2_MIN,C_OTHER2_AIM,C_OTHER2_MAX,C_OTHER3_MIN,C_OTHER3_AIM,C_OTHER3_MAX,C_AOD_TYPE,C_NAME)");
            strSql.Append(" values (");
            strSql.Append(":C_STEELGRADEINDEX,:C_LADLE_BRICK,:C_LADLE_USE,:C_LADLE_PRE_STEELGRADE,:C_LADLE_STAY,:C_BOF_TYPE,:C_LADLE_TAPPED_PROC,:C_LF_TYPE,:C_RH_TYPE,:C_CASTER_TYPE,:C_HOT_SEND_FLAG,:C_C_MIN,:C_C_AIM,:C_C_MAX,:C_SI_MIN,:C_SI_AIM,:C_SI_MAX,:C_MN_MIN,:C_MN_AIM,:C_MN_MAX,:C_P_MIN,:C_P_AIM,:C_P_MAX,:C_S_MIN,:C_S_AIM,:C_S_MAX,:C_CU_MIN,:C_CU_AIM,:C_CU_MAX,:C_NI_MIN,:C_NI_AIM,:C_NI_MAX,:C_CR_MIN,:C_CR_AIM,:C_CR_MAX,:C_MO_MIN,:C_MO_AIM,:C_MO_MAX,:C_V_MIN,:C_V_AIM,:C_V_MAX,:C_NB_MIN,:C_NB_AIM,:C_NB_MAX,:C_AL_MIN,:C_AL_AIM,:C_AL_MAX,:C_ALS_MIN,:C_ALS_AIM,:C_ALS_MAX,:C_TI_MIN,:C_TI_AIM,:C_TI_MAX,:C_B_MIN,:C_B_AIM,:C_B_MAX,:C_SB_MIN,:C_SB_AIM,:C_SB_MAX,:C_SN_MIN,:C_SN_AIM,:C_SN_MAX,:C_AS_MIN,:C_AS_AIM,:C_AS_MAX,:C_ZN_MIN,:C_ZN_AIM,:C_ZN_MAX,:C_ZR_MIN,:C_ZR_AIM,:C_ZR_MAX,:C_CA_MIN,:C_CA_AIM,:C_CA_MAX,:C_W_MIN,:C_W_AIM,:C_W_MAX,:C_PB_MIN,:C_PB_AIM,:C_PB_MAX,:C_RE_MIN,:C_RE_AIM,:C_RE_MAX,:C_CEQ_MIN,:C_CEQ_AIM,:C_CEQ_MAX,:C_N_MIN,:C_N_AIM,:C_N_MAX,:C_H_MIN,:C_H_AIM,:C_H_MAX,:C_O_MIN,:C_O_AIM,:C_O_MAX,:C_CRNI_MIN,:C_CRNI_AIM,:C_CRNI_MAX,:C_CRCU_MIN,:C_CRCU_AIM,:C_CRCU_MAX,:C_CRNICU_MIN,:C_CRNICU_AIM,:C_CRNICU_MAX,:C_OTHER1_MIN,:C_OTHER1_AIM,:C_OTHER1_MAX,:C_OTHER2_MIN,:C_OTHER2_AIM,:C_OTHER2_MAX,:C_OTHER3_MIN,:C_OTHER3_AIM,:C_OTHER3_MAX,:C_AOD_TYPE,:C_NAME)");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_STEELGRADEINDEX", OracleDbType.Varchar2,250),
                    new OracleParameter(":C_LADLE_BRICK", OracleDbType.Varchar2,250),
                    new OracleParameter(":C_LADLE_USE", OracleDbType.Varchar2,250),
                    new OracleParameter(":C_LADLE_PRE_STEELGRADE", OracleDbType.Varchar2,250),
                    new OracleParameter(":C_LADLE_STAY", OracleDbType.Varchar2,250),
                    new OracleParameter(":C_BOF_TYPE", OracleDbType.Varchar2,250),
                    new OracleParameter(":C_LADLE_TAPPED_PROC", OracleDbType.Varchar2,250),
                    new OracleParameter(":C_LF_TYPE", OracleDbType.Varchar2,250),
                    new OracleParameter(":C_RH_TYPE", OracleDbType.Varchar2,250),
                    new OracleParameter(":C_CASTER_TYPE", OracleDbType.Varchar2,250),
                    new OracleParameter(":C_HOT_SEND_FLAG", OracleDbType.Decimal,10),
                    new OracleParameter(":C_C_MIN", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_C_AIM", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_C_MAX", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_SI_MIN", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_SI_AIM", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_SI_MAX", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_MN_MIN", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_MN_AIM", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_MN_MAX", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_P_MIN", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_P_AIM", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_P_MAX", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_S_MIN", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_S_AIM", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_S_MAX", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_CU_MIN", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_CU_AIM", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_CU_MAX", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_NI_MIN", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_NI_AIM", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_NI_MAX", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_CR_MIN", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_CR_AIM", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_CR_MAX", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_MO_MIN", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_MO_AIM", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_MO_MAX", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_V_MIN", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_V_AIM", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_V_MAX", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_NB_MIN", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_NB_AIM", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_NB_MAX", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_AL_MIN", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_AL_AIM", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_AL_MAX", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_ALS_MIN", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_ALS_AIM", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_ALS_MAX", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_TI_MIN", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_TI_AIM", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_TI_MAX", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_B_MIN", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_B_AIM", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_B_MAX", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_SB_MIN", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_SB_AIM", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_SB_MAX", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_SN_MIN", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_SN_AIM", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_SN_MAX", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_AS_MIN", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_AS_AIM", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_AS_MAX", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_ZN_MIN", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_ZN_AIM", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_ZN_MAX", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_ZR_MIN", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_ZR_AIM", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_ZR_MAX", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_CA_MIN", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_CA_AIM", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_CA_MAX", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_W_MIN", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_W_AIM", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_W_MAX", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_PB_MIN", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_PB_AIM", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_PB_MAX", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_RE_MIN", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_RE_AIM", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_RE_MAX", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_CEQ_MIN", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_CEQ_AIM", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_CEQ_MAX", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_N_MIN", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_N_AIM", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_N_MAX", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_H_MIN", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_H_AIM", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_H_MAX", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_O_MIN", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_O_AIM", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_O_MAX", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_CRNI_MIN", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_CRNI_AIM", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_CRNI_MAX", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_CRCU_MIN", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_CRCU_AIM", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_CRCU_MAX", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_CRNICU_MIN", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_CRNICU_AIM", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_CRNICU_MAX", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_OTHER1_MIN", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_OTHER1_AIM", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_OTHER1_MAX", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_OTHER2_MIN", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_OTHER2_AIM", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_OTHER2_MAX", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_OTHER3_MIN", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_OTHER3_AIM", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_OTHER3_MAX", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_AOD_TYPE", OracleDbType.Varchar2,250),
                    new OracleParameter(":C_NAME", OracleDbType.Varchar2,250)};
            parameters[0].Value = model.C_STEELGRADEINDEX;
            parameters[1].Value = model.C_LADLE_BRICK;
            parameters[2].Value = model.C_LADLE_USE;
            parameters[3].Value = model.C_LADLE_PRE_STEELGRADE;
            parameters[4].Value = model.C_LADLE_STAY;
            parameters[5].Value = model.C_BOF_TYPE;
            parameters[6].Value = model.C_LADLE_TAPPED_PROC;
            parameters[7].Value = model.C_LF_TYPE;
            parameters[8].Value = model.C_RH_TYPE;
            parameters[9].Value = model.C_CASTER_TYPE;
            parameters[10].Value = model.C_HOT_SEND_FLAG;
            parameters[11].Value = model.C_C_MIN;
            parameters[12].Value = model.C_C_AIM;
            parameters[13].Value = model.C_C_MAX;
            parameters[14].Value = model.C_SI_MIN;
            parameters[15].Value = model.C_SI_AIM;
            parameters[16].Value = model.C_SI_MAX;
            parameters[17].Value = model.C_MN_MIN;
            parameters[18].Value = model.C_MN_AIM;
            parameters[19].Value = model.C_MN_MAX;
            parameters[20].Value = model.C_P_MIN;
            parameters[21].Value = model.C_P_AIM;
            parameters[22].Value = model.C_P_MAX;
            parameters[23].Value = model.C_S_MIN;
            parameters[24].Value = model.C_S_AIM;
            parameters[25].Value = model.C_S_MAX;
            parameters[26].Value = model.C_CU_MIN;
            parameters[27].Value = model.C_CU_AIM;
            parameters[28].Value = model.C_CU_MAX;
            parameters[29].Value = model.C_NI_MIN;
            parameters[30].Value = model.C_NI_AIM;
            parameters[31].Value = model.C_NI_MAX;
            parameters[32].Value = model.C_CR_MIN;
            parameters[33].Value = model.C_CR_AIM;
            parameters[34].Value = model.C_CR_MAX;
            parameters[35].Value = model.C_MO_MIN;
            parameters[36].Value = model.C_MO_AIM;
            parameters[37].Value = model.C_MO_MAX;
            parameters[38].Value = model.C_V_MIN;
            parameters[39].Value = model.C_V_AIM;
            parameters[40].Value = model.C_V_MAX;
            parameters[41].Value = model.C_NB_MIN;
            parameters[42].Value = model.C_NB_AIM;
            parameters[43].Value = model.C_NB_MAX;
            parameters[44].Value = model.C_AL_MIN;
            parameters[45].Value = model.C_AL_AIM;
            parameters[46].Value = model.C_AL_MAX;
            parameters[47].Value = model.C_ALS_MIN;
            parameters[48].Value = model.C_ALS_AIM;
            parameters[49].Value = model.C_ALS_MAX;
            parameters[50].Value = model.C_TI_MIN;
            parameters[51].Value = model.C_TI_AIM;
            parameters[52].Value = model.C_TI_MAX;
            parameters[53].Value = model.C_B_MIN;
            parameters[54].Value = model.C_B_AIM;
            parameters[55].Value = model.C_B_MAX;
            parameters[56].Value = model.C_SB_MIN;
            parameters[57].Value = model.C_SB_AIM;
            parameters[58].Value = model.C_SB_MAX;
            parameters[59].Value = model.C_SN_MIN;
            parameters[60].Value = model.C_SN_AIM;
            parameters[61].Value = model.C_SN_MAX;
            parameters[62].Value = model.C_AS_MIN;
            parameters[63].Value = model.C_AS_AIM;
            parameters[64].Value = model.C_AS_MAX;
            parameters[65].Value = model.C_ZN_MIN;
            parameters[66].Value = model.C_ZN_AIM;
            parameters[67].Value = model.C_ZN_MAX;
            parameters[68].Value = model.C_ZR_MIN;
            parameters[69].Value = model.C_ZR_AIM;
            parameters[70].Value = model.C_ZR_MAX;
            parameters[71].Value = model.C_CA_MIN;
            parameters[72].Value = model.C_CA_AIM;
            parameters[73].Value = model.C_CA_MAX;
            parameters[74].Value = model.C_W_MIN;
            parameters[75].Value = model.C_W_AIM;
            parameters[76].Value = model.C_W_MAX;
            parameters[77].Value = model.C_PB_MIN;
            parameters[78].Value = model.C_PB_AIM;
            parameters[79].Value = model.C_PB_MAX;
            parameters[80].Value = model.C_RE_MIN;
            parameters[81].Value = model.C_RE_AIM;
            parameters[82].Value = model.C_RE_MAX;
            parameters[83].Value = model.C_CEQ_MIN;
            parameters[84].Value = model.C_CEQ_AIM;
            parameters[85].Value = model.C_CEQ_MAX;
            parameters[86].Value = model.C_N_MIN;
            parameters[87].Value = model.C_N_AIM;
            parameters[88].Value = model.C_N_MAX;
            parameters[89].Value = model.C_H_MIN;
            parameters[90].Value = model.C_H_AIM;
            parameters[91].Value = model.C_H_MAX;
            parameters[92].Value = model.C_O_MIN;
            parameters[93].Value = model.C_O_AIM;
            parameters[94].Value = model.C_O_MAX;
            parameters[95].Value = model.C_CRNI_MIN;
            parameters[96].Value = model.C_CRNI_AIM;
            parameters[97].Value = model.C_CRNI_MAX;
            parameters[98].Value = model.C_CRCU_MIN;
            parameters[99].Value = model.C_CRCU_AIM;
            parameters[100].Value = model.C_CRCU_MAX;
            parameters[101].Value = model.C_CRNICU_MIN;
            parameters[102].Value = model.C_CRNICU_AIM;
            parameters[103].Value = model.C_CRNICU_MAX;
            parameters[104].Value = model.C_OTHER1_MIN;
            parameters[105].Value = model.C_OTHER1_AIM;
            parameters[106].Value = model.C_OTHER1_MAX;
            parameters[107].Value = model.C_OTHER2_MIN;
            parameters[108].Value = model.C_OTHER2_AIM;
            parameters[109].Value = model.C_OTHER2_MAX;
            parameters[110].Value = model.C_OTHER3_MIN;
            parameters[111].Value = model.C_OTHER3_AIM;
            parameters[112].Value = model.C_OTHER3_MAX;
            parameters[113].Value = model.C_AOD_TYPE;
            parameters[114].Value = model.C_NAME;

            int rows = DbHelperOra.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Mod_TPB_LGGYK model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TPB_LGGYK set ");
            strSql.Append("C_STEELGRADEINDEX=:C_STEELGRADEINDEX,");
            strSql.Append("C_LADLE_BRICK=:C_LADLE_BRICK,");
            strSql.Append("C_LADLE_USE=:C_LADLE_USE,");
            strSql.Append("C_LADLE_PRE_STEELGRADE=:C_LADLE_PRE_STEELGRADE,");
            strSql.Append("C_LADLE_STAY=:C_LADLE_STAY,");
            strSql.Append("C_BOF_TYPE=:C_BOF_TYPE,");
            strSql.Append("C_LADLE_TAPPED_PROC=:C_LADLE_TAPPED_PROC,");
            strSql.Append("C_LF_TYPE=:C_LF_TYPE,");
            strSql.Append("C_RH_TYPE=:C_RH_TYPE,");
            strSql.Append("C_CASTER_TYPE=:C_CASTER_TYPE,");
            strSql.Append("C_HOT_SEND_FLAG=:C_HOT_SEND_FLAG,");
            strSql.Append("C_C_MIN=:C_C_MIN,");
            strSql.Append("C_C_AIM=:C_C_AIM,");
            strSql.Append("C_C_MAX=:C_C_MAX,");
            strSql.Append("C_SI_MIN=:C_SI_MIN,");
            strSql.Append("C_SI_AIM=:C_SI_AIM,");
            strSql.Append("C_SI_MAX=:C_SI_MAX,");
            strSql.Append("C_MN_MIN=:C_MN_MIN,");
            strSql.Append("C_MN_AIM=:C_MN_AIM,");
            strSql.Append("C_MN_MAX=:C_MN_MAX,");
            strSql.Append("C_P_MIN=:C_P_MIN,");
            strSql.Append("C_P_AIM=:C_P_AIM,");
            strSql.Append("C_P_MAX=:C_P_MAX,");
            strSql.Append("C_S_MIN=:C_S_MIN,");
            strSql.Append("C_S_AIM=:C_S_AIM,");
            strSql.Append("C_S_MAX=:C_S_MAX,");
            strSql.Append("C_CU_MIN=:C_CU_MIN,");
            strSql.Append("C_CU_AIM=:C_CU_AIM,");
            strSql.Append("C_CU_MAX=:C_CU_MAX,");
            strSql.Append("C_NI_MIN=:C_NI_MIN,");
            strSql.Append("C_NI_AIM=:C_NI_AIM,");
            strSql.Append("C_NI_MAX=:C_NI_MAX,");
            strSql.Append("C_CR_MIN=:C_CR_MIN,");
            strSql.Append("C_CR_AIM=:C_CR_AIM,");
            strSql.Append("C_CR_MAX=:C_CR_MAX,");
            strSql.Append("C_MO_MIN=:C_MO_MIN,");
            strSql.Append("C_MO_AIM=:C_MO_AIM,");
            strSql.Append("C_MO_MAX=:C_MO_MAX,");
            strSql.Append("C_V_MIN=:C_V_MIN,");
            strSql.Append("C_V_AIM=:C_V_AIM,");
            strSql.Append("C_V_MAX=:C_V_MAX,");
            strSql.Append("C_NB_MIN=:C_NB_MIN,");
            strSql.Append("C_NB_AIM=:C_NB_AIM,");
            strSql.Append("C_NB_MAX=:C_NB_MAX,");
            strSql.Append("C_AL_MIN=:C_AL_MIN,");
            strSql.Append("C_AL_AIM=:C_AL_AIM,");
            strSql.Append("C_AL_MAX=:C_AL_MAX,");
            strSql.Append("C_ALS_MIN=:C_ALS_MIN,");
            strSql.Append("C_ALS_AIM=:C_ALS_AIM,");
            strSql.Append("C_ALS_MAX=:C_ALS_MAX,");
            strSql.Append("C_TI_MIN=:C_TI_MIN,");
            strSql.Append("C_TI_AIM=:C_TI_AIM,");
            strSql.Append("C_TI_MAX=:C_TI_MAX,");
            strSql.Append("C_B_MIN=:C_B_MIN,");
            strSql.Append("C_B_AIM=:C_B_AIM,");
            strSql.Append("C_B_MAX=:C_B_MAX,");
            strSql.Append("C_SB_MIN=:C_SB_MIN,");
            strSql.Append("C_SB_AIM=:C_SB_AIM,");
            strSql.Append("C_SB_MAX=:C_SB_MAX,");
            strSql.Append("C_SN_MIN=:C_SN_MIN,");
            strSql.Append("C_SN_AIM=:C_SN_AIM,");
            strSql.Append("C_SN_MAX=:C_SN_MAX,");
            strSql.Append("C_AS_MIN=:C_AS_MIN,");
            strSql.Append("C_AS_AIM=:C_AS_AIM,");
            strSql.Append("C_AS_MAX=:C_AS_MAX,");
            strSql.Append("C_ZN_MIN=:C_ZN_MIN,");
            strSql.Append("C_ZN_AIM=:C_ZN_AIM,");
            strSql.Append("C_ZN_MAX=:C_ZN_MAX,");
            strSql.Append("C_ZR_MIN=:C_ZR_MIN,");
            strSql.Append("C_ZR_AIM=:C_ZR_AIM,");
            strSql.Append("C_ZR_MAX=:C_ZR_MAX,");
            strSql.Append("C_CA_MIN=:C_CA_MIN,");
            strSql.Append("C_CA_AIM=:C_CA_AIM,");
            strSql.Append("C_CA_MAX=:C_CA_MAX,");
            strSql.Append("C_W_MIN=:C_W_MIN,");
            strSql.Append("C_W_AIM=:C_W_AIM,");
            strSql.Append("C_W_MAX=:C_W_MAX,");
            strSql.Append("C_PB_MIN=:C_PB_MIN,");
            strSql.Append("C_PB_AIM=:C_PB_AIM,");
            strSql.Append("C_PB_MAX=:C_PB_MAX,");
            strSql.Append("C_RE_MIN=:C_RE_MIN,");
            strSql.Append("C_RE_AIM=:C_RE_AIM,");
            strSql.Append("C_RE_MAX=:C_RE_MAX,");
            strSql.Append("C_CEQ_MIN=:C_CEQ_MIN,");
            strSql.Append("C_CEQ_AIM=:C_CEQ_AIM,");
            strSql.Append("C_CEQ_MAX=:C_CEQ_MAX,");
            strSql.Append("C_N_MIN=:C_N_MIN,");
            strSql.Append("C_N_AIM=:C_N_AIM,");
            strSql.Append("C_N_MAX=:C_N_MAX,");
            strSql.Append("C_H_MIN=:C_H_MIN,");
            strSql.Append("C_H_AIM=:C_H_AIM,");
            strSql.Append("C_H_MAX=:C_H_MAX,");
            strSql.Append("C_O_MIN=:C_O_MIN,");
            strSql.Append("C_O_AIM=:C_O_AIM,");
            strSql.Append("C_O_MAX=:C_O_MAX,");
            strSql.Append("C_CRNI_MIN=:C_CRNI_MIN,");
            strSql.Append("C_CRNI_AIM=:C_CRNI_AIM,");
            strSql.Append("C_CRNI_MAX=:C_CRNI_MAX,");
            strSql.Append("C_CRCU_MIN=:C_CRCU_MIN,");
            strSql.Append("C_CRCU_AIM=:C_CRCU_AIM,");
            strSql.Append("C_CRCU_MAX=:C_CRCU_MAX,");
            strSql.Append("C_CRNICU_MIN=:C_CRNICU_MIN,");
            strSql.Append("C_CRNICU_AIM=:C_CRNICU_AIM,");
            strSql.Append("C_CRNICU_MAX=:C_CRNICU_MAX,");
            strSql.Append("C_OTHER1_MIN=:C_OTHER1_MIN,");
            strSql.Append("C_OTHER1_AIM=:C_OTHER1_AIM,");
            strSql.Append("C_OTHER1_MAX=:C_OTHER1_MAX,");
            strSql.Append("C_OTHER2_MIN=:C_OTHER2_MIN,");
            strSql.Append("C_OTHER2_AIM=:C_OTHER2_AIM,");
            strSql.Append("C_OTHER2_MAX=:C_OTHER2_MAX,");
            strSql.Append("C_OTHER3_MIN=:C_OTHER3_MIN,");
            strSql.Append("C_OTHER3_AIM=:C_OTHER3_AIM,");
            strSql.Append("C_OTHER3_MAX=:C_OTHER3_MAX,");
            strSql.Append("C_AOD_TYPE=:C_AOD_TYPE,");
            strSql.Append("C_NAME=:C_NAME");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_STEELGRADEINDEX", OracleDbType.Varchar2,250),
                    new OracleParameter(":C_LADLE_BRICK", OracleDbType.Varchar2,250),
                    new OracleParameter(":C_LADLE_USE", OracleDbType.Varchar2,250),
                    new OracleParameter(":C_LADLE_PRE_STEELGRADE", OracleDbType.Varchar2,250),
                    new OracleParameter(":C_LADLE_STAY", OracleDbType.Varchar2,250),
                    new OracleParameter(":C_BOF_TYPE", OracleDbType.Varchar2,250),
                    new OracleParameter(":C_LADLE_TAPPED_PROC", OracleDbType.Varchar2,250),
                    new OracleParameter(":C_LF_TYPE", OracleDbType.Varchar2,250),
                    new OracleParameter(":C_RH_TYPE", OracleDbType.Varchar2,250),
                    new OracleParameter(":C_CASTER_TYPE", OracleDbType.Varchar2,250),
                    new OracleParameter(":C_HOT_SEND_FLAG", OracleDbType.Decimal,10),
                    new OracleParameter(":C_C_MIN", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_C_AIM", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_C_MAX", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_SI_MIN", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_SI_AIM", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_SI_MAX", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_MN_MIN", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_MN_AIM", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_MN_MAX", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_P_MIN", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_P_AIM", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_P_MAX", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_S_MIN", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_S_AIM", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_S_MAX", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_CU_MIN", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_CU_AIM", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_CU_MAX", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_NI_MIN", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_NI_AIM", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_NI_MAX", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_CR_MIN", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_CR_AIM", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_CR_MAX", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_MO_MIN", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_MO_AIM", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_MO_MAX", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_V_MIN", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_V_AIM", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_V_MAX", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_NB_MIN", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_NB_AIM", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_NB_MAX", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_AL_MIN", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_AL_AIM", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_AL_MAX", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_ALS_MIN", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_ALS_AIM", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_ALS_MAX", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_TI_MIN", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_TI_AIM", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_TI_MAX", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_B_MIN", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_B_AIM", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_B_MAX", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_SB_MIN", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_SB_AIM", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_SB_MAX", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_SN_MIN", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_SN_AIM", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_SN_MAX", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_AS_MIN", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_AS_AIM", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_AS_MAX", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_ZN_MIN", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_ZN_AIM", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_ZN_MAX", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_ZR_MIN", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_ZR_AIM", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_ZR_MAX", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_CA_MIN", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_CA_AIM", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_CA_MAX", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_W_MIN", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_W_AIM", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_W_MAX", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_PB_MIN", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_PB_AIM", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_PB_MAX", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_RE_MIN", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_RE_AIM", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_RE_MAX", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_CEQ_MIN", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_CEQ_AIM", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_CEQ_MAX", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_N_MIN", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_N_AIM", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_N_MAX", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_H_MIN", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_H_AIM", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_H_MAX", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_O_MIN", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_O_AIM", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_O_MAX", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_CRNI_MIN", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_CRNI_AIM", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_CRNI_MAX", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_CRCU_MIN", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_CRCU_AIM", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_CRCU_MAX", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_CRNICU_MIN", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_CRNICU_AIM", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_CRNICU_MAX", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_OTHER1_MIN", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_OTHER1_AIM", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_OTHER1_MAX", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_OTHER2_MIN", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_OTHER2_AIM", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_OTHER2_MAX", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_OTHER3_MIN", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_OTHER3_AIM", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_OTHER3_MAX", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_AOD_TYPE", OracleDbType.Varchar2,250),
                    new OracleParameter(":C_NAME", OracleDbType.Varchar2,250),
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,250)};
            parameters[0].Value = model.C_STEELGRADEINDEX;
            parameters[1].Value = model.C_LADLE_BRICK;
            parameters[2].Value = model.C_LADLE_USE;
            parameters[3].Value = model.C_LADLE_PRE_STEELGRADE;
            parameters[4].Value = model.C_LADLE_STAY;
            parameters[5].Value = model.C_BOF_TYPE;
            parameters[6].Value = model.C_LADLE_TAPPED_PROC;
            parameters[7].Value = model.C_LF_TYPE;
            parameters[8].Value = model.C_RH_TYPE;
            parameters[9].Value = model.C_CASTER_TYPE;
            parameters[10].Value = model.C_HOT_SEND_FLAG;
            parameters[11].Value = model.C_C_MIN;
            parameters[12].Value = model.C_C_AIM;
            parameters[13].Value = model.C_C_MAX;
            parameters[14].Value = model.C_SI_MIN;
            parameters[15].Value = model.C_SI_AIM;
            parameters[16].Value = model.C_SI_MAX;
            parameters[17].Value = model.C_MN_MIN;
            parameters[18].Value = model.C_MN_AIM;
            parameters[19].Value = model.C_MN_MAX;
            parameters[20].Value = model.C_P_MIN;
            parameters[21].Value = model.C_P_AIM;
            parameters[22].Value = model.C_P_MAX;
            parameters[23].Value = model.C_S_MIN;
            parameters[24].Value = model.C_S_AIM;
            parameters[25].Value = model.C_S_MAX;
            parameters[26].Value = model.C_CU_MIN;
            parameters[27].Value = model.C_CU_AIM;
            parameters[28].Value = model.C_CU_MAX;
            parameters[29].Value = model.C_NI_MIN;
            parameters[30].Value = model.C_NI_AIM;
            parameters[31].Value = model.C_NI_MAX;
            parameters[32].Value = model.C_CR_MIN;
            parameters[33].Value = model.C_CR_AIM;
            parameters[34].Value = model.C_CR_MAX;
            parameters[35].Value = model.C_MO_MIN;
            parameters[36].Value = model.C_MO_AIM;
            parameters[37].Value = model.C_MO_MAX;
            parameters[38].Value = model.C_V_MIN;
            parameters[39].Value = model.C_V_AIM;
            parameters[40].Value = model.C_V_MAX;
            parameters[41].Value = model.C_NB_MIN;
            parameters[42].Value = model.C_NB_AIM;
            parameters[43].Value = model.C_NB_MAX;
            parameters[44].Value = model.C_AL_MIN;
            parameters[45].Value = model.C_AL_AIM;
            parameters[46].Value = model.C_AL_MAX;
            parameters[47].Value = model.C_ALS_MIN;
            parameters[48].Value = model.C_ALS_AIM;
            parameters[49].Value = model.C_ALS_MAX;
            parameters[50].Value = model.C_TI_MIN;
            parameters[51].Value = model.C_TI_AIM;
            parameters[52].Value = model.C_TI_MAX;
            parameters[53].Value = model.C_B_MIN;
            parameters[54].Value = model.C_B_AIM;
            parameters[55].Value = model.C_B_MAX;
            parameters[56].Value = model.C_SB_MIN;
            parameters[57].Value = model.C_SB_AIM;
            parameters[58].Value = model.C_SB_MAX;
            parameters[59].Value = model.C_SN_MIN;
            parameters[60].Value = model.C_SN_AIM;
            parameters[61].Value = model.C_SN_MAX;
            parameters[62].Value = model.C_AS_MIN;
            parameters[63].Value = model.C_AS_AIM;
            parameters[64].Value = model.C_AS_MAX;
            parameters[65].Value = model.C_ZN_MIN;
            parameters[66].Value = model.C_ZN_AIM;
            parameters[67].Value = model.C_ZN_MAX;
            parameters[68].Value = model.C_ZR_MIN;
            parameters[69].Value = model.C_ZR_AIM;
            parameters[70].Value = model.C_ZR_MAX;
            parameters[71].Value = model.C_CA_MIN;
            parameters[72].Value = model.C_CA_AIM;
            parameters[73].Value = model.C_CA_MAX;
            parameters[74].Value = model.C_W_MIN;
            parameters[75].Value = model.C_W_AIM;
            parameters[76].Value = model.C_W_MAX;
            parameters[77].Value = model.C_PB_MIN;
            parameters[78].Value = model.C_PB_AIM;
            parameters[79].Value = model.C_PB_MAX;
            parameters[80].Value = model.C_RE_MIN;
            parameters[81].Value = model.C_RE_AIM;
            parameters[82].Value = model.C_RE_MAX;
            parameters[83].Value = model.C_CEQ_MIN;
            parameters[84].Value = model.C_CEQ_AIM;
            parameters[85].Value = model.C_CEQ_MAX;
            parameters[86].Value = model.C_N_MIN;
            parameters[87].Value = model.C_N_AIM;
            parameters[88].Value = model.C_N_MAX;
            parameters[89].Value = model.C_H_MIN;
            parameters[90].Value = model.C_H_AIM;
            parameters[91].Value = model.C_H_MAX;
            parameters[92].Value = model.C_O_MIN;
            parameters[93].Value = model.C_O_AIM;
            parameters[94].Value = model.C_O_MAX;
            parameters[95].Value = model.C_CRNI_MIN;
            parameters[96].Value = model.C_CRNI_AIM;
            parameters[97].Value = model.C_CRNI_MAX;
            parameters[98].Value = model.C_CRCU_MIN;
            parameters[99].Value = model.C_CRCU_AIM;
            parameters[100].Value = model.C_CRCU_MAX;
            parameters[101].Value = model.C_CRNICU_MIN;
            parameters[102].Value = model.C_CRNICU_AIM;
            parameters[103].Value = model.C_CRNICU_MAX;
            parameters[104].Value = model.C_OTHER1_MIN;
            parameters[105].Value = model.C_OTHER1_AIM;
            parameters[106].Value = model.C_OTHER1_MAX;
            parameters[107].Value = model.C_OTHER2_MIN;
            parameters[108].Value = model.C_OTHER2_AIM;
            parameters[109].Value = model.C_OTHER2_MAX;
            parameters[110].Value = model.C_OTHER3_MIN;
            parameters[111].Value = model.C_OTHER3_AIM;
            parameters[112].Value = model.C_OTHER3_MAX;
            parameters[113].Value = model.C_AOD_TYPE;
            parameters[114].Value = model.C_NAME;
            parameters[115].Value = model.C_ID;

            int rows = DbHelperOra.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(string C_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from TPB_LGGYK ");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,250)         };
            parameters[0].Value = C_ID;

            int rows = DbHelperOra.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 批量删除数据
        /// </summary>
        public bool DeleteList(string C_IDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from TPB_LGGYK ");
            strSql.Append(" where C_ID in (" + C_IDlist + ")  ");
            int rows = DbHelperOra.ExecuteSql(strSql.ToString());
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Mod_TPB_LGGYK GetModel(string C_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_STEELGRADEINDEX,C_LADLE_BRICK,C_LADLE_USE,C_LADLE_PRE_STEELGRADE,C_LADLE_STAY,C_BOF_TYPE,C_LADLE_TAPPED_PROC,C_LF_TYPE,C_RH_TYPE,C_CASTER_TYPE,C_HOT_SEND_FLAG,C_C_MIN,C_C_AIM,C_C_MAX,C_SI_MIN,C_SI_AIM,C_SI_MAX,C_MN_MIN,C_MN_AIM,C_MN_MAX,C_P_MIN,C_P_AIM,C_P_MAX,C_S_MIN,C_S_AIM,C_S_MAX,C_CU_MIN,C_CU_AIM,C_CU_MAX,C_NI_MIN,C_NI_AIM,C_NI_MAX,C_CR_MIN,C_CR_AIM,C_CR_MAX,C_MO_MIN,C_MO_AIM,C_MO_MAX,C_V_MIN,C_V_AIM,C_V_MAX,C_NB_MIN,C_NB_AIM,C_NB_MAX,C_AL_MIN,C_AL_AIM,C_AL_MAX,C_ALS_MIN,C_ALS_AIM,C_ALS_MAX,C_TI_MIN,C_TI_AIM,C_TI_MAX,C_B_MIN,C_B_AIM,C_B_MAX,C_SB_MIN,C_SB_AIM,C_SB_MAX,C_SN_MIN,C_SN_AIM,C_SN_MAX,C_AS_MIN,C_AS_AIM,C_AS_MAX,C_ZN_MIN,C_ZN_AIM,C_ZN_MAX,C_ZR_MIN,C_ZR_AIM,C_ZR_MAX,C_CA_MIN,C_CA_AIM,C_CA_MAX,C_W_MIN,C_W_AIM,C_W_MAX,C_PB_MIN,C_PB_AIM,C_PB_MAX,C_RE_MIN,C_RE_AIM,C_RE_MAX,C_CEQ_MIN,C_CEQ_AIM,C_CEQ_MAX,C_N_MIN,C_N_AIM,C_N_MAX,C_H_MIN,C_H_AIM,C_H_MAX,C_O_MIN,C_O_AIM,C_O_MAX,C_CRNI_MIN,C_CRNI_AIM,C_CRNI_MAX,C_CRCU_MIN,C_CRCU_AIM,C_CRCU_MAX,C_CRNICU_MIN,C_CRNICU_AIM,C_CRNICU_MAX,C_OTHER1_MIN,C_OTHER1_AIM,C_OTHER1_MAX,C_OTHER2_MIN,C_OTHER2_AIM,C_OTHER2_MAX,C_OTHER3_MIN,C_OTHER3_AIM,C_OTHER3_MAX,C_AOD_TYPE,C_NAME from TPB_LGGYK ");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,250)         };
            parameters[0].Value = C_ID;

            Mod_TPB_LGGYK model = new Mod_TPB_LGGYK();
            DataSet ds = DbHelperOra.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                return DataRowToModel(ds.Tables[0].Rows[0]);
            }
            else
            {
                return null;
            }
        }

        /// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Mod_TPB_LGGYK GetModel_Trans(string C_STEELGRADEINDEX)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_STEELGRADEINDEX,C_LADLE_BRICK,C_LADLE_USE,C_LADLE_PRE_STEELGRADE,C_LADLE_STAY,C_BOF_TYPE,C_LADLE_TAPPED_PROC,C_LF_TYPE,C_RH_TYPE,C_CASTER_TYPE,C_HOT_SEND_FLAG,C_C_MIN,C_C_AIM,C_C_MAX,C_SI_MIN,C_SI_AIM,C_SI_MAX,C_MN_MIN,C_MN_AIM,C_MN_MAX,C_P_MIN,C_P_AIM,C_P_MAX,C_S_MIN,C_S_AIM,C_S_MAX,C_CU_MIN,C_CU_AIM,C_CU_MAX,C_NI_MIN,C_NI_AIM,C_NI_MAX,C_CR_MIN,C_CR_AIM,C_CR_MAX,C_MO_MIN,C_MO_AIM,C_MO_MAX,C_V_MIN,C_V_AIM,C_V_MAX,C_NB_MIN,C_NB_AIM,C_NB_MAX,C_AL_MIN,C_AL_AIM,C_AL_MAX,C_ALS_MIN,C_ALS_AIM,C_ALS_MAX,C_TI_MIN,C_TI_AIM,C_TI_MAX,C_B_MIN,C_B_AIM,C_B_MAX,C_SB_MIN,C_SB_AIM,C_SB_MAX,C_SN_MIN,C_SN_AIM,C_SN_MAX,C_AS_MIN,C_AS_AIM,C_AS_MAX,C_ZN_MIN,C_ZN_AIM,C_ZN_MAX,C_ZR_MIN,C_ZR_AIM,C_ZR_MAX,C_CA_MIN,C_CA_AIM,C_CA_MAX,C_W_MIN,C_W_AIM,C_W_MAX,C_PB_MIN,C_PB_AIM,C_PB_MAX,C_RE_MIN,C_RE_AIM,C_RE_MAX,C_CEQ_MIN,C_CEQ_AIM,C_CEQ_MAX,C_N_MIN,C_N_AIM,C_N_MAX,C_H_MIN,C_H_AIM,C_H_MAX,C_O_MIN,C_O_AIM,C_O_MAX,C_CRNI_MIN,C_CRNI_AIM,C_CRNI_MAX,C_CRCU_MIN,C_CRCU_AIM,C_CRCU_MAX,C_CRNICU_MIN,C_CRNICU_AIM,C_CRNICU_MAX,C_OTHER1_MIN,C_OTHER1_AIM,C_OTHER1_MAX,C_OTHER2_MIN,C_OTHER2_AIM,C_OTHER2_MAX,C_OTHER3_MIN,C_OTHER3_AIM,C_OTHER3_MAX,C_AOD_TYPE,C_NAME from TPB_LGGYK ");
            strSql.Append(" where C_STEELGRADEINDEX=:C_STEELGRADEINDEX ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_STEELGRADEINDEX", OracleDbType.Varchar2,250)         };
            parameters[0].Value = C_STEELGRADEINDEX;

            Mod_TPB_LGGYK model = new Mod_TPB_LGGYK();
            DataSet ds = DbHelperOra.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                return DataRowToModel(ds.Tables[0].Rows[0]);
            }
            else
            {
                return null;
            }
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Mod_TPB_LGGYK DataRowToModel(DataRow row)
        {
            Mod_TPB_LGGYK model = new Mod_TPB_LGGYK();
            if (row != null)
            {
                if (row["C_ID"] != null)
                {
                    model.C_ID = row["C_ID"].ToString();
                }
                if (row["C_STEELGRADEINDEX"] != null)
                {
                    model.C_STEELGRADEINDEX = row["C_STEELGRADEINDEX"].ToString();
                }
                if (row["C_LADLE_BRICK"] != null)
                {
                    model.C_LADLE_BRICK = row["C_LADLE_BRICK"].ToString();
                }
                if (row["C_LADLE_USE"] != null)
                {
                    model.C_LADLE_USE = row["C_LADLE_USE"].ToString();
                }
                if (row["C_LADLE_PRE_STEELGRADE"] != null)
                {
                    model.C_LADLE_PRE_STEELGRADE = row["C_LADLE_PRE_STEELGRADE"].ToString();
                }
                if (row["C_LADLE_STAY"] != null)
                {
                    model.C_LADLE_STAY = row["C_LADLE_STAY"].ToString();
                }
                if (row["C_BOF_TYPE"] != null)
                {
                    model.C_BOF_TYPE = row["C_BOF_TYPE"].ToString();
                }
                if (row["C_LADLE_TAPPED_PROC"] != null)
                {
                    model.C_LADLE_TAPPED_PROC = row["C_LADLE_TAPPED_PROC"].ToString();
                }
                if (row["C_LF_TYPE"] != null)
                {
                    model.C_LF_TYPE = row["C_LF_TYPE"].ToString();
                }
                if (row["C_RH_TYPE"] != null)
                {
                    model.C_RH_TYPE = row["C_RH_TYPE"].ToString();
                }
                if (row["C_CASTER_TYPE"] != null)
                {
                    model.C_CASTER_TYPE = row["C_CASTER_TYPE"].ToString();
                }
                if (row["C_HOT_SEND_FLAG"] != null && row["C_HOT_SEND_FLAG"].ToString() != "")
                {
                    model.C_HOT_SEND_FLAG = decimal.Parse(row["C_HOT_SEND_FLAG"].ToString());
                }
                if (row["C_C_MIN"] != null)
                {
                    model.C_C_MIN = row["C_C_MIN"].ToString();
                }
                if (row["C_C_AIM"] != null)
                {
                    model.C_C_AIM = row["C_C_AIM"].ToString();
                }
                if (row["C_C_MAX"] != null)
                {
                    model.C_C_MAX = row["C_C_MAX"].ToString();
                }
                if (row["C_SI_MIN"] != null)
                {
                    model.C_SI_MIN = row["C_SI_MIN"].ToString();
                }
                if (row["C_SI_AIM"] != null)
                {
                    model.C_SI_AIM = row["C_SI_AIM"].ToString();
                }
                if (row["C_SI_MAX"] != null)
                {
                    model.C_SI_MAX = row["C_SI_MAX"].ToString();
                }
                if (row["C_MN_MIN"] != null)
                {
                    model.C_MN_MIN = row["C_MN_MIN"].ToString();
                }
                if (row["C_MN_AIM"] != null)
                {
                    model.C_MN_AIM = row["C_MN_AIM"].ToString();
                }
                if (row["C_MN_MAX"] != null)
                {
                    model.C_MN_MAX = row["C_MN_MAX"].ToString();
                }
                if (row["C_P_MIN"] != null)
                {
                    model.C_P_MIN = row["C_P_MIN"].ToString();
                }
                if (row["C_P_AIM"] != null)
                {
                    model.C_P_AIM = row["C_P_AIM"].ToString();
                }
                if (row["C_P_MAX"] != null)
                {
                    model.C_P_MAX = row["C_P_MAX"].ToString();
                }
                if (row["C_S_MIN"] != null)
                {
                    model.C_S_MIN = row["C_S_MIN"].ToString();
                }
                if (row["C_S_AIM"] != null)
                {
                    model.C_S_AIM = row["C_S_AIM"].ToString();
                }
                if (row["C_S_MAX"] != null)
                {
                    model.C_S_MAX = row["C_S_MAX"].ToString();
                }
                if (row["C_CU_MIN"] != null)
                {
                    model.C_CU_MIN = row["C_CU_MIN"].ToString();
                }
                if (row["C_CU_AIM"] != null)
                {
                    model.C_CU_AIM = row["C_CU_AIM"].ToString();
                }
                if (row["C_CU_MAX"] != null)
                {
                    model.C_CU_MAX = row["C_CU_MAX"].ToString();
                }
                if (row["C_NI_MIN"] != null)
                {
                    model.C_NI_MIN = row["C_NI_MIN"].ToString();
                }
                if (row["C_NI_AIM"] != null)
                {
                    model.C_NI_AIM = row["C_NI_AIM"].ToString();
                }
                if (row["C_NI_MAX"] != null)
                {
                    model.C_NI_MAX = row["C_NI_MAX"].ToString();
                }
                if (row["C_CR_MIN"] != null)
                {
                    model.C_CR_MIN = row["C_CR_MIN"].ToString();
                }
                if (row["C_CR_AIM"] != null)
                {
                    model.C_CR_AIM = row["C_CR_AIM"].ToString();
                }
                if (row["C_CR_MAX"] != null)
                {
                    model.C_CR_MAX = row["C_CR_MAX"].ToString();
                }
                if (row["C_MO_MIN"] != null)
                {
                    model.C_MO_MIN = row["C_MO_MIN"].ToString();
                }
                if (row["C_MO_AIM"] != null)
                {
                    model.C_MO_AIM = row["C_MO_AIM"].ToString();
                }
                if (row["C_MO_MAX"] != null)
                {
                    model.C_MO_MAX = row["C_MO_MAX"].ToString();
                }
                if (row["C_V_MIN"] != null)
                {
                    model.C_V_MIN = row["C_V_MIN"].ToString();
                }
                if (row["C_V_AIM"] != null)
                {
                    model.C_V_AIM = row["C_V_AIM"].ToString();
                }
                if (row["C_V_MAX"] != null)
                {
                    model.C_V_MAX = row["C_V_MAX"].ToString();
                }
                if (row["C_NB_MIN"] != null)
                {
                    model.C_NB_MIN = row["C_NB_MIN"].ToString();
                }
                if (row["C_NB_AIM"] != null)
                {
                    model.C_NB_AIM = row["C_NB_AIM"].ToString();
                }
                if (row["C_NB_MAX"] != null)
                {
                    model.C_NB_MAX = row["C_NB_MAX"].ToString();
                }
                if (row["C_AL_MIN"] != null)
                {
                    model.C_AL_MIN = row["C_AL_MIN"].ToString();
                }
                if (row["C_AL_AIM"] != null)
                {
                    model.C_AL_AIM = row["C_AL_AIM"].ToString();
                }
                if (row["C_AL_MAX"] != null)
                {
                    model.C_AL_MAX = row["C_AL_MAX"].ToString();
                }
                if (row["C_ALS_MIN"] != null)
                {
                    model.C_ALS_MIN = row["C_ALS_MIN"].ToString();
                }
                if (row["C_ALS_AIM"] != null)
                {
                    model.C_ALS_AIM = row["C_ALS_AIM"].ToString();
                }
                if (row["C_ALS_MAX"] != null)
                {
                    model.C_ALS_MAX = row["C_ALS_MAX"].ToString();
                }
                if (row["C_TI_MIN"] != null)
                {
                    model.C_TI_MIN = row["C_TI_MIN"].ToString();
                }
                if (row["C_TI_AIM"] != null)
                {
                    model.C_TI_AIM = row["C_TI_AIM"].ToString();
                }
                if (row["C_TI_MAX"] != null)
                {
                    model.C_TI_MAX = row["C_TI_MAX"].ToString();
                }
                if (row["C_B_MIN"] != null)
                {
                    model.C_B_MIN = row["C_B_MIN"].ToString();
                }
                if (row["C_B_AIM"] != null)
                {
                    model.C_B_AIM = row["C_B_AIM"].ToString();
                }
                if (row["C_B_MAX"] != null)
                {
                    model.C_B_MAX = row["C_B_MAX"].ToString();
                }
                if (row["C_SB_MIN"] != null)
                {
                    model.C_SB_MIN = row["C_SB_MIN"].ToString();
                }
                if (row["C_SB_AIM"] != null)
                {
                    model.C_SB_AIM = row["C_SB_AIM"].ToString();
                }
                if (row["C_SB_MAX"] != null)
                {
                    model.C_SB_MAX = row["C_SB_MAX"].ToString();
                }
                if (row["C_SN_MIN"] != null)
                {
                    model.C_SN_MIN = row["C_SN_MIN"].ToString();
                }
                if (row["C_SN_AIM"] != null)
                {
                    model.C_SN_AIM = row["C_SN_AIM"].ToString();
                }
                if (row["C_SN_MAX"] != null)
                {
                    model.C_SN_MAX = row["C_SN_MAX"].ToString();
                }
                if (row["C_AS_MIN"] != null)
                {
                    model.C_AS_MIN = row["C_AS_MIN"].ToString();
                }
                if (row["C_AS_AIM"] != null)
                {
                    model.C_AS_AIM = row["C_AS_AIM"].ToString();
                }
                if (row["C_AS_MAX"] != null)
                {
                    model.C_AS_MAX = row["C_AS_MAX"].ToString();
                }
                if (row["C_ZN_MIN"] != null)
                {
                    model.C_ZN_MIN = row["C_ZN_MIN"].ToString();
                }
                if (row["C_ZN_AIM"] != null)
                {
                    model.C_ZN_AIM = row["C_ZN_AIM"].ToString();
                }
                if (row["C_ZN_MAX"] != null)
                {
                    model.C_ZN_MAX = row["C_ZN_MAX"].ToString();
                }
                if (row["C_ZR_MIN"] != null)
                {
                    model.C_ZR_MIN = row["C_ZR_MIN"].ToString();
                }
                if (row["C_ZR_AIM"] != null)
                {
                    model.C_ZR_AIM = row["C_ZR_AIM"].ToString();
                }
                if (row["C_ZR_MAX"] != null)
                {
                    model.C_ZR_MAX = row["C_ZR_MAX"].ToString();
                }
                if (row["C_CA_MIN"] != null)
                {
                    model.C_CA_MIN = row["C_CA_MIN"].ToString();
                }
                if (row["C_CA_AIM"] != null)
                {
                    model.C_CA_AIM = row["C_CA_AIM"].ToString();
                }
                if (row["C_CA_MAX"] != null)
                {
                    model.C_CA_MAX = row["C_CA_MAX"].ToString();
                }
                if (row["C_W_MIN"] != null)
                {
                    model.C_W_MIN = row["C_W_MIN"].ToString();
                }
                if (row["C_W_AIM"] != null)
                {
                    model.C_W_AIM = row["C_W_AIM"].ToString();
                }
                if (row["C_W_MAX"] != null)
                {
                    model.C_W_MAX = row["C_W_MAX"].ToString();
                }
                if (row["C_PB_MIN"] != null)
                {
                    model.C_PB_MIN = row["C_PB_MIN"].ToString();
                }
                if (row["C_PB_AIM"] != null)
                {
                    model.C_PB_AIM = row["C_PB_AIM"].ToString();
                }
                if (row["C_PB_MAX"] != null)
                {
                    model.C_PB_MAX = row["C_PB_MAX"].ToString();
                }
                if (row["C_RE_MIN"] != null)
                {
                    model.C_RE_MIN = row["C_RE_MIN"].ToString();
                }
                if (row["C_RE_AIM"] != null)
                {
                    model.C_RE_AIM = row["C_RE_AIM"].ToString();
                }
                if (row["C_RE_MAX"] != null)
                {
                    model.C_RE_MAX = row["C_RE_MAX"].ToString();
                }
                if (row["C_CEQ_MIN"] != null)
                {
                    model.C_CEQ_MIN = row["C_CEQ_MIN"].ToString();
                }
                if (row["C_CEQ_AIM"] != null)
                {
                    model.C_CEQ_AIM = row["C_CEQ_AIM"].ToString();
                }
                if (row["C_CEQ_MAX"] != null)
                {
                    model.C_CEQ_MAX = row["C_CEQ_MAX"].ToString();
                }
                if (row["C_N_MIN"] != null)
                {
                    model.C_N_MIN = row["C_N_MIN"].ToString();
                }
                if (row["C_N_AIM"] != null)
                {
                    model.C_N_AIM = row["C_N_AIM"].ToString();
                }
                if (row["C_N_MAX"] != null)
                {
                    model.C_N_MAX = row["C_N_MAX"].ToString();
                }
                if (row["C_H_MIN"] != null)
                {
                    model.C_H_MIN = row["C_H_MIN"].ToString();
                }
                if (row["C_H_AIM"] != null)
                {
                    model.C_H_AIM = row["C_H_AIM"].ToString();
                }
                if (row["C_H_MAX"] != null)
                {
                    model.C_H_MAX = row["C_H_MAX"].ToString();
                }
                if (row["C_O_MIN"] != null)
                {
                    model.C_O_MIN = row["C_O_MIN"].ToString();
                }
                if (row["C_O_AIM"] != null)
                {
                    model.C_O_AIM = row["C_O_AIM"].ToString();
                }
                if (row["C_O_MAX"] != null)
                {
                    model.C_O_MAX = row["C_O_MAX"].ToString();
                }
                if (row["C_CRNI_MIN"] != null)
                {
                    model.C_CRNI_MIN = row["C_CRNI_MIN"].ToString();
                }
                if (row["C_CRNI_AIM"] != null)
                {
                    model.C_CRNI_AIM = row["C_CRNI_AIM"].ToString();
                }
                if (row["C_CRNI_MAX"] != null)
                {
                    model.C_CRNI_MAX = row["C_CRNI_MAX"].ToString();
                }
                if (row["C_CRCU_MIN"] != null)
                {
                    model.C_CRCU_MIN = row["C_CRCU_MIN"].ToString();
                }
                if (row["C_CRCU_AIM"] != null)
                {
                    model.C_CRCU_AIM = row["C_CRCU_AIM"].ToString();
                }
                if (row["C_CRCU_MAX"] != null)
                {
                    model.C_CRCU_MAX = row["C_CRCU_MAX"].ToString();
                }
                if (row["C_CRNICU_MIN"] != null)
                {
                    model.C_CRNICU_MIN = row["C_CRNICU_MIN"].ToString();
                }
                if (row["C_CRNICU_AIM"] != null)
                {
                    model.C_CRNICU_AIM = row["C_CRNICU_AIM"].ToString();
                }
                if (row["C_CRNICU_MAX"] != null)
                {
                    model.C_CRNICU_MAX = row["C_CRNICU_MAX"].ToString();
                }
                if (row["C_OTHER1_MIN"] != null)
                {
                    model.C_OTHER1_MIN = row["C_OTHER1_MIN"].ToString();
                }
                if (row["C_OTHER1_AIM"] != null)
                {
                    model.C_OTHER1_AIM = row["C_OTHER1_AIM"].ToString();
                }
                if (row["C_OTHER1_MAX"] != null)
                {
                    model.C_OTHER1_MAX = row["C_OTHER1_MAX"].ToString();
                }
                if (row["C_OTHER2_MIN"] != null)
                {
                    model.C_OTHER2_MIN = row["C_OTHER2_MIN"].ToString();
                }
                if (row["C_OTHER2_AIM"] != null)
                {
                    model.C_OTHER2_AIM = row["C_OTHER2_AIM"].ToString();
                }
                if (row["C_OTHER2_MAX"] != null)
                {
                    model.C_OTHER2_MAX = row["C_OTHER2_MAX"].ToString();
                }
                if (row["C_OTHER3_MIN"] != null)
                {
                    model.C_OTHER3_MIN = row["C_OTHER3_MIN"].ToString();
                }
                if (row["C_OTHER3_AIM"] != null)
                {
                    model.C_OTHER3_AIM = row["C_OTHER3_AIM"].ToString();
                }
                if (row["C_OTHER3_MAX"] != null)
                {
                    model.C_OTHER3_MAX = row["C_OTHER3_MAX"].ToString();
                }
                if (row["C_AOD_TYPE"] != null)
                {
                    model.C_AOD_TYPE = row["C_AOD_TYPE"].ToString();
                }
                if (row["C_NAME"] != null)
                {
                    model.C_NAME = row["C_NAME"].ToString();
                }
            }
            return model;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_STEELGRADEINDEX,C_LADLE_BRICK,C_LADLE_USE,C_LADLE_PRE_STEELGRADE,C_LADLE_STAY,C_BOF_TYPE,C_LADLE_TAPPED_PROC,C_LF_TYPE,C_RH_TYPE,C_CASTER_TYPE,C_HOT_SEND_FLAG,C_C_MIN,C_C_AIM,C_C_MAX,C_SI_MIN,C_SI_AIM,C_SI_MAX,C_MN_MIN,C_MN_AIM,C_MN_MAX,C_P_MIN,C_P_AIM,C_P_MAX,C_S_MIN,C_S_AIM,C_S_MAX,C_CU_MIN,C_CU_AIM,C_CU_MAX,C_NI_MIN,C_NI_AIM,C_NI_MAX,C_CR_MIN,C_CR_AIM,C_CR_MAX,C_MO_MIN,C_MO_AIM,C_MO_MAX,C_V_MIN,C_V_AIM,C_V_MAX,C_NB_MIN,C_NB_AIM,C_NB_MAX,C_AL_MIN,C_AL_AIM,C_AL_MAX,C_ALS_MIN,C_ALS_AIM,C_ALS_MAX,C_TI_MIN,C_TI_AIM,C_TI_MAX,C_B_MIN,C_B_AIM,C_B_MAX,C_SB_MIN,C_SB_AIM,C_SB_MAX,C_SN_MIN,C_SN_AIM,C_SN_MAX,C_AS_MIN,C_AS_AIM,C_AS_MAX,C_ZN_MIN,C_ZN_AIM,C_ZN_MAX,C_ZR_MIN,C_ZR_AIM,C_ZR_MAX,C_CA_MIN,C_CA_AIM,C_CA_MAX,C_W_MIN,C_W_AIM,C_W_MAX,C_PB_MIN,C_PB_AIM,C_PB_MAX,C_RE_MIN,C_RE_AIM,C_RE_MAX,C_CEQ_MIN,C_CEQ_AIM,C_CEQ_MAX,C_N_MIN,C_N_AIM,C_N_MAX,C_H_MIN,C_H_AIM,C_H_MAX,C_O_MIN,C_O_AIM,C_O_MAX,C_CRNI_MIN,C_CRNI_AIM,C_CRNI_MAX,C_CRCU_MIN,C_CRCU_AIM,C_CRCU_MAX,C_CRNICU_MIN,C_CRNICU_AIM,C_CRNICU_MAX,C_OTHER1_MIN,C_OTHER1_AIM,C_OTHER1_MAX,C_OTHER2_MIN,C_OTHER2_AIM,C_OTHER2_MAX,C_OTHER3_MIN,C_OTHER3_AIM,C_OTHER3_MAX,C_AOD_TYPE,C_NAME ");
            strSql.Append(" FROM TPB_LGGYK ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM TPB_LGGYK ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            object obj = DbHelperOra.GetSingle(strSql.ToString());
            if (obj == null)
            {
                return 0;
            }
            else
            {
                return Convert.ToInt32(obj);
            }
        }
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT * FROM ( ");
            strSql.Append(" SELECT ROW_NUMBER() OVER (");
            if (!string.IsNullOrEmpty(orderby.Trim()))
            {
                strSql.Append("order by T." + orderby);
            }
            else
            {
                strSql.Append("order by T.C_ID desc");
            }
            strSql.Append(")AS Row, T.*  from TPB_LGGYK T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取炼钢记号
        /// </summary>
        public DataSet Get_LGJH(string c_bof_type, string c_lf_type, string c_rh_type, string c_caster_type, string c_std_code, string c_stl_grd)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ta.c_steel_sign from tpb_lgjh ta inner join tpb_lggyk tb on ta.c_steel_sign=tb.c_steelgradeindex ");

            strSql.Append("where TA.C_USE_FLAG = '0' AND tb.c_bof_type='" + c_bof_type + "' and tb.c_lf_type='" + c_lf_type + "' and tb.c_rh_type='" + c_rh_type + "' and tb.c_caster_type='" + c_caster_type + "' and ta.c_std_code='" + c_std_code + "' and ta.c_stl_grd='" + c_stl_grd + "'  ");

            return DbHelperOra.Query(strSql.ToString());
        }

        #endregion  BasicMethod
        #region  ExtensionMethod

        #endregion  ExtensionMethod
    }
}

