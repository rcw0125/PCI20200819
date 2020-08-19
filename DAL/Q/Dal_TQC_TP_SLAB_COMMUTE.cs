using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;
namespace DAL
{
    /// <summary>
    /// 数据访问类:TQC_TP_SLAB_COMMUTE
    /// </summary>
    public partial class Dal_TQC_TP_SLAB_COMMUTE
	{
		public Dal_TQC_TP_SLAB_COMMUTE()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string C_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from TQC_TP_SLAB_COMMUTE");
			strSql.Append(" where C_ID=:C_ID ");
			OracleParameter[] parameters = {
					new OracleParameter(":C_ID", OracleDbType.Varchar2,100)			};
			parameters[0].Value = C_ID;

			return DbHelperOra.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Mod_TQC_TP_SLAB_COMMUTE model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into TQC_TP_SLAB_COMMUTE(");
			strSql.Append("C_SLAB_MAIN_ID,C_STA_ID,C_STOVE,C_BATCH_NO,N_WGT,N_LEN_BEFORE,N_LEN_AFTER,C_STL_GRD_BEFORE,C_STD_CODE_BEFORE,C_SPEC_BEFORE,C_MAT_CODE_BEFORE,C_MAT_DESC_BEFORE,C_STL_GRD_AFTER,C_STD_CODE_AFTER,C_SPEC_AFTER,C_MAT_CODE_AFTER,C_MAT_DESC_AFTER,C_REASON_DEPMT_ID,C_REASON_DEPMT_DESC,C_ZYX1_BEFORE,C_ZYX2_BEFORE,C_ZYX1_AFTER,C_ZYX2_AFTER,C_JUDGE_LEV_BP_BEFORE,C_JUDGE_LEV_BP_AFTER,C_EMP_ID,D_MOD_DT,C_COMMUTE_SQ,C_CHECK_ZKB,C_ZKB_EMP_ID,D_CHECK_ZKB_DATE,C_CZYJ_ZKB,C_CHECK_XC,C_XC_EMP_ID,D_CHECK_XC_DATE,C_CZYJ_XC,C_CHECK_LG,C_LG_EMP_ID,D_CHECK_LG_DATE,C_CZYJ_LG,C_CHECK_JSZX,C_JSZX_EMP_ID,D_CHECK_JSZX_DATE,C_CZYJ_JSZX,C_COMMUTE_REASON,D_COMMUTE_DATE,N_IS_SH,N_STATUS,C_REMARK,C_REMARK1,C_REMARK2,C_REMARK3)");
			strSql.Append(" values (");
			strSql.Append(":C_SLAB_MAIN_ID,:C_STA_ID,:C_STOVE,:C_BATCH_NO,:N_WGT,:N_LEN_BEFORE,:N_LEN_AFTER,:C_STL_GRD_BEFORE,:C_STD_CODE_BEFORE,:C_SPEC_BEFORE,:C_MAT_CODE_BEFORE,:C_MAT_DESC_BEFORE,:C_STL_GRD_AFTER,:C_STD_CODE_AFTER,:C_SPEC_AFTER,:C_MAT_CODE_AFTER,:C_MAT_DESC_AFTER,:C_REASON_DEPMT_ID,:C_REASON_DEPMT_DESC,:C_ZYX1_BEFORE,:C_ZYX2_BEFORE,:C_ZYX1_AFTER,:C_ZYX2_AFTER,:C_JUDGE_LEV_BP_BEFORE,:C_JUDGE_LEV_BP_AFTER,:C_EMP_ID,:D_MOD_DT,:C_COMMUTE_SQ,:C_CHECK_ZKB,:C_ZKB_EMP_ID,:D_CHECK_ZKB_DATE,:C_CZYJ_ZKB,:C_CHECK_XC,:C_XC_EMP_ID,:D_CHECK_XC_DATE,:C_CZYJ_XC,:C_CHECK_LG,:C_LG_EMP_ID,:D_CHECK_LG_DATE,:C_CZYJ_LG,:C_CHECK_JSZX,:C_JSZX_EMP_ID,:D_CHECK_JSZX_DATE,:C_CZYJ_JSZX,:C_COMMUTE_REASON,:D_COMMUTE_DATE,:N_IS_SH,:N_STATUS,:C_REMARK,:C_REMARK1,:C_REMARK2,:C_REMARK3)");
			OracleParameter[] parameters = { 
					new OracleParameter(":C_SLAB_MAIN_ID", OracleDbType.Varchar2,100),
					new OracleParameter(":C_STA_ID", OracleDbType.Varchar2,100),
					new OracleParameter(":C_STOVE", OracleDbType.Varchar2,100),
					new OracleParameter(":C_BATCH_NO", OracleDbType.Varchar2,100),
					new OracleParameter(":N_WGT", OracleDbType.Decimal,15),
					new OracleParameter(":N_LEN_BEFORE", OracleDbType.Decimal,15),
					new OracleParameter(":N_LEN_AFTER", OracleDbType.Decimal,15),
					new OracleParameter(":C_STL_GRD_BEFORE", OracleDbType.Varchar2,100),
					new OracleParameter(":C_STD_CODE_BEFORE", OracleDbType.Varchar2,100),
					new OracleParameter(":C_SPEC_BEFORE", OracleDbType.Varchar2,100),
					new OracleParameter(":C_MAT_CODE_BEFORE", OracleDbType.Varchar2,100),
					new OracleParameter(":C_MAT_DESC_BEFORE", OracleDbType.Varchar2,100),
					new OracleParameter(":C_STL_GRD_AFTER", OracleDbType.Varchar2,100),
					new OracleParameter(":C_STD_CODE_AFTER", OracleDbType.Varchar2,100),
					new OracleParameter(":C_SPEC_AFTER", OracleDbType.Varchar2,100),
					new OracleParameter(":C_MAT_CODE_AFTER", OracleDbType.Varchar2,100),
					new OracleParameter(":C_MAT_DESC_AFTER", OracleDbType.Varchar2,100),
					new OracleParameter(":C_REASON_DEPMT_ID", OracleDbType.Varchar2,100),
					new OracleParameter(":C_REASON_DEPMT_DESC", OracleDbType.Varchar2,100),
					new OracleParameter(":C_ZYX1_BEFORE", OracleDbType.Varchar2,100),
					new OracleParameter(":C_ZYX2_BEFORE", OracleDbType.Varchar2,100),
					new OracleParameter(":C_ZYX1_AFTER", OracleDbType.Varchar2,100),
					new OracleParameter(":C_ZYX2_AFTER", OracleDbType.Varchar2,100),
					new OracleParameter(":C_JUDGE_LEV_BP_BEFORE", OracleDbType.Varchar2,100),
					new OracleParameter(":C_JUDGE_LEV_BP_AFTER", OracleDbType.Varchar2,100),
					new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
					new OracleParameter(":D_MOD_DT", OracleDbType.Date),
					new OracleParameter(":C_COMMUTE_SQ", OracleDbType.Varchar2,200),
					new OracleParameter(":C_CHECK_ZKB", OracleDbType.Varchar2,100),
					new OracleParameter(":C_ZKB_EMP_ID", OracleDbType.Varchar2,100),
					new OracleParameter(":D_CHECK_ZKB_DATE", OracleDbType.Date),
					new OracleParameter(":C_CZYJ_ZKB", OracleDbType.Varchar2,200),
					new OracleParameter(":C_CHECK_XC", OracleDbType.Varchar2,100),
					new OracleParameter(":C_XC_EMP_ID", OracleDbType.Varchar2,100),
					new OracleParameter(":D_CHECK_XC_DATE", OracleDbType.Date),
					new OracleParameter(":C_CZYJ_XC", OracleDbType.Varchar2,200),
					new OracleParameter(":C_CHECK_LG", OracleDbType.Varchar2,100),
					new OracleParameter(":C_LG_EMP_ID", OracleDbType.Varchar2,100),
					new OracleParameter(":D_CHECK_LG_DATE", OracleDbType.Date),
					new OracleParameter(":C_CZYJ_LG", OracleDbType.Varchar2,200),
					new OracleParameter(":C_CHECK_JSZX", OracleDbType.Varchar2,100),
					new OracleParameter(":C_JSZX_EMP_ID", OracleDbType.Varchar2,100),
					new OracleParameter(":D_CHECK_JSZX_DATE", OracleDbType.Date),
					new OracleParameter(":C_CZYJ_JSZX", OracleDbType.Varchar2,200),
					new OracleParameter(":C_COMMUTE_REASON", OracleDbType.Varchar2,200),
					new OracleParameter(":D_COMMUTE_DATE", OracleDbType.Date),
					new OracleParameter(":N_IS_SH", OracleDbType.Decimal,1),
					new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
					new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
					new OracleParameter(":C_REMARK1", OracleDbType.Varchar2,200),
					new OracleParameter(":C_REMARK2", OracleDbType.Varchar2,200),
					new OracleParameter(":C_REMARK3", OracleDbType.Varchar2,200)}; 
			parameters[0].Value = model.C_SLAB_MAIN_ID;
			parameters[1].Value = model.C_STA_ID;
			parameters[2].Value = model.C_STOVE;
			parameters[3].Value = model.C_BATCH_NO;
			parameters[4].Value = model.N_WGT;
			parameters[5].Value = model.N_LEN_BEFORE;
			parameters[6].Value = model.N_LEN_AFTER;
			parameters[7].Value = model.C_STL_GRD_BEFORE;
			parameters[8].Value = model.C_STD_CODE_BEFORE;
			parameters[9].Value = model.C_SPEC_BEFORE;
			parameters[10].Value = model.C_MAT_CODE_BEFORE;
			parameters[11].Value = model.C_MAT_DESC_BEFORE;
			parameters[12].Value = model.C_STL_GRD_AFTER;
			parameters[13].Value = model.C_STD_CODE_AFTER;
			parameters[14].Value = model.C_SPEC_AFTER;
			parameters[15].Value = model.C_MAT_CODE_AFTER;
			parameters[16].Value = model.C_MAT_DESC_AFTER;
			parameters[17].Value = model.C_REASON_DEPMT_ID;
			parameters[18].Value = model.C_REASON_DEPMT_DESC;
			parameters[19].Value = model.C_ZYX1_BEFORE;
			parameters[20].Value = model.C_ZYX2_BEFORE;
			parameters[21].Value = model.C_ZYX1_AFTER;
			parameters[22].Value = model.C_ZYX2_AFTER;
			parameters[23].Value = model.C_JUDGE_LEV_BP_BEFORE;
			parameters[24].Value = model.C_JUDGE_LEV_BP_AFTER;
			parameters[25].Value = model.C_EMP_ID;
			parameters[26].Value = model.D_MOD_DT;
			parameters[27].Value = model.C_COMMUTE_SQ;
			parameters[28].Value = model.C_CHECK_ZKB;
			parameters[29].Value = model.C_ZKB_EMP_ID;
			parameters[30].Value = model.D_CHECK_ZKB_DATE;
			parameters[31].Value = model.C_CZYJ_ZKB;
			parameters[32].Value = model.C_CHECK_XC;
			parameters[33].Value = model.C_XC_EMP_ID;
			parameters[34].Value = model.D_CHECK_XC_DATE;
			parameters[35].Value = model.C_CZYJ_XC;
			parameters[36].Value = model.C_CHECK_LG;
			parameters[37].Value = model.C_LG_EMP_ID;
			parameters[38].Value = model.D_CHECK_LG_DATE;
			parameters[39].Value = model.C_CZYJ_LG;
			parameters[40].Value = model.C_CHECK_JSZX;
			parameters[41].Value = model.C_JSZX_EMP_ID;
			parameters[42].Value = model.D_CHECK_JSZX_DATE;
			parameters[43].Value = model.C_CZYJ_JSZX;
			parameters[44].Value = model.C_COMMUTE_REASON;
			parameters[45].Value = model.D_COMMUTE_DATE;
			parameters[46].Value = model.N_IS_SH;
			parameters[47].Value = model.N_STATUS;
			parameters[48].Value = model.C_REMARK;
			parameters[49].Value = model.C_REMARK1;
			parameters[50].Value = model.C_REMARK2;
			parameters[51].Value = model.C_REMARK3; 

            int rows =DbHelperOra.ExecuteSql(strSql.ToString(),parameters);
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
		/// 增加一条数据
		/// </summary>
		public bool Add_Trans(Mod_TQC_TP_SLAB_COMMUTE model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TQC_TP_SLAB_COMMUTE(");
            strSql.Append("C_SLAB_MAIN_ID,C_STA_ID,C_STOVE,C_BATCH_NO,N_WGT,N_LEN_BEFORE,N_LEN_AFTER,C_STL_GRD_BEFORE,C_STD_CODE_BEFORE,C_SPEC_BEFORE,C_MAT_CODE_BEFORE,C_MAT_DESC_BEFORE,C_STL_GRD_AFTER,C_STD_CODE_AFTER,C_SPEC_AFTER,C_MAT_CODE_AFTER,C_MAT_DESC_AFTER,C_REASON_DEPMT_ID,C_REASON_DEPMT_DESC,C_ZYX1_BEFORE,C_ZYX2_BEFORE,C_ZYX1_AFTER,C_ZYX2_AFTER,C_JUDGE_LEV_BP_BEFORE,C_JUDGE_LEV_BP_AFTER,C_EMP_ID,D_MOD_DT,C_COMMUTE_SQ,C_CHECK_ZKB,C_ZKB_EMP_ID,D_CHECK_ZKB_DATE,C_CZYJ_ZKB,C_CHECK_XC,C_XC_EMP_ID,D_CHECK_XC_DATE,C_CZYJ_XC,C_CHECK_LG,C_LG_EMP_ID,D_CHECK_LG_DATE,C_CZYJ_LG,C_CHECK_JSZX,C_JSZX_EMP_ID,D_CHECK_JSZX_DATE,C_CZYJ_JSZX,C_COMMUTE_REASON,D_COMMUTE_DATE,N_IS_SH,N_STATUS,C_REMARK,C_REMARK1,C_REMARK2,C_REMARK3)");
            strSql.Append(" values (");
            strSql.Append(":C_SLAB_MAIN_ID,:C_STA_ID,:C_STOVE,:C_BATCH_NO,:N_WGT,:N_LEN_BEFORE,:N_LEN_AFTER,:C_STL_GRD_BEFORE,:C_STD_CODE_BEFORE,:C_SPEC_BEFORE,:C_MAT_CODE_BEFORE,:C_MAT_DESC_BEFORE,:C_STL_GRD_AFTER,:C_STD_CODE_AFTER,:C_SPEC_AFTER,:C_MAT_CODE_AFTER,:C_MAT_DESC_AFTER,:C_REASON_DEPMT_ID,:C_REASON_DEPMT_DESC,:C_ZYX1_BEFORE,:C_ZYX2_BEFORE,:C_ZYX1_AFTER,:C_ZYX2_AFTER,:C_JUDGE_LEV_BP_BEFORE,:C_JUDGE_LEV_BP_AFTER,:C_EMP_ID,:D_MOD_DT,:C_COMMUTE_SQ,:C_CHECK_ZKB,:C_ZKB_EMP_ID,:D_CHECK_ZKB_DATE,:C_CZYJ_ZKB,:C_CHECK_XC,:C_XC_EMP_ID,:D_CHECK_XC_DATE,:C_CZYJ_XC,:C_CHECK_LG,:C_LG_EMP_ID,:D_CHECK_LG_DATE,:C_CZYJ_LG,:C_CHECK_JSZX,:C_JSZX_EMP_ID,:D_CHECK_JSZX_DATE,:C_CZYJ_JSZX,:C_COMMUTE_REASON,:D_COMMUTE_DATE,:N_IS_SH,:N_STATUS,:C_REMARK,:C_REMARK1,:C_REMARK2,:C_REMARK3)");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_SLAB_MAIN_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STA_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STOVE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_BATCH_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":N_LEN_BEFORE", OracleDbType.Decimal,15),
                    new OracleParameter(":N_LEN_AFTER", OracleDbType.Decimal,15),
                    new OracleParameter(":C_STL_GRD_BEFORE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STD_CODE_BEFORE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SPEC_BEFORE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MAT_CODE_BEFORE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MAT_DESC_BEFORE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STL_GRD_AFTER", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STD_CODE_AFTER", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SPEC_AFTER", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MAT_CODE_AFTER", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MAT_DESC_AFTER", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_REASON_DEPMT_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_REASON_DEPMT_DESC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ZYX1_BEFORE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ZYX2_BEFORE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ZYX1_AFTER", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ZYX2_AFTER", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_JUDGE_LEV_BP_BEFORE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_JUDGE_LEV_BP_AFTER", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":C_COMMUTE_SQ", OracleDbType.Varchar2,200),
                    new OracleParameter(":C_CHECK_ZKB", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ZKB_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_CHECK_ZKB_DATE", OracleDbType.Date),
                    new OracleParameter(":C_CZYJ_ZKB", OracleDbType.Varchar2,200),
                    new OracleParameter(":C_CHECK_XC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_XC_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_CHECK_XC_DATE", OracleDbType.Date),
                    new OracleParameter(":C_CZYJ_XC", OracleDbType.Varchar2,200),
                    new OracleParameter(":C_CHECK_LG", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_LG_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_CHECK_LG_DATE", OracleDbType.Date),
                    new OracleParameter(":C_CZYJ_LG", OracleDbType.Varchar2,200),
                    new OracleParameter(":C_CHECK_JSZX", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_JSZX_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_CHECK_JSZX_DATE", OracleDbType.Date),
                    new OracleParameter(":C_CZYJ_JSZX", OracleDbType.Varchar2,200),
                    new OracleParameter(":C_COMMUTE_REASON", OracleDbType.Varchar2,200),
                    new OracleParameter(":D_COMMUTE_DATE", OracleDbType.Date),
                    new OracleParameter(":N_IS_SH", OracleDbType.Decimal,1),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_REMARK1", OracleDbType.Varchar2,200),
                    new OracleParameter(":C_REMARK2", OracleDbType.Varchar2,200),
                    new OracleParameter(":C_REMARK3", OracleDbType.Varchar2,200)};
            parameters[0].Value = model.C_SLAB_MAIN_ID;
            parameters[1].Value = model.C_STA_ID;
            parameters[2].Value = model.C_STOVE;
            parameters[3].Value = model.C_BATCH_NO;
            parameters[4].Value = model.N_WGT;
            parameters[5].Value = model.N_LEN_BEFORE;
            parameters[6].Value = model.N_LEN_AFTER;
            parameters[7].Value = model.C_STL_GRD_BEFORE;
            parameters[8].Value = model.C_STD_CODE_BEFORE;
            parameters[9].Value = model.C_SPEC_BEFORE;
            parameters[10].Value = model.C_MAT_CODE_BEFORE;
            parameters[11].Value = model.C_MAT_DESC_BEFORE;
            parameters[12].Value = model.C_STL_GRD_AFTER;
            parameters[13].Value = model.C_STD_CODE_AFTER;
            parameters[14].Value = model.C_SPEC_AFTER;
            parameters[15].Value = model.C_MAT_CODE_AFTER;
            parameters[16].Value = model.C_MAT_DESC_AFTER;
            parameters[17].Value = model.C_REASON_DEPMT_ID;
            parameters[18].Value = model.C_REASON_DEPMT_DESC;
            parameters[19].Value = model.C_ZYX1_BEFORE;
            parameters[20].Value = model.C_ZYX2_BEFORE;
            parameters[21].Value = model.C_ZYX1_AFTER;
            parameters[22].Value = model.C_ZYX2_AFTER;
            parameters[23].Value = model.C_JUDGE_LEV_BP_BEFORE;
            parameters[24].Value = model.C_JUDGE_LEV_BP_AFTER;
            parameters[25].Value = model.C_EMP_ID;
            parameters[26].Value = model.D_MOD_DT;
            parameters[27].Value = model.C_COMMUTE_SQ;
            parameters[28].Value = model.C_CHECK_ZKB;
            parameters[29].Value = model.C_ZKB_EMP_ID;
            parameters[30].Value = model.D_CHECK_ZKB_DATE;
            parameters[31].Value = model.C_CZYJ_ZKB;
            parameters[32].Value = model.C_CHECK_XC;
            parameters[33].Value = model.C_XC_EMP_ID;
            parameters[34].Value = model.D_CHECK_XC_DATE;
            parameters[35].Value = model.C_CZYJ_XC;
            parameters[36].Value = model.C_CHECK_LG;
            parameters[37].Value = model.C_LG_EMP_ID;
            parameters[38].Value = model.D_CHECK_LG_DATE;
            parameters[39].Value = model.C_CZYJ_LG;
            parameters[40].Value = model.C_CHECK_JSZX;
            parameters[41].Value = model.C_JSZX_EMP_ID;
            parameters[42].Value = model.D_CHECK_JSZX_DATE;
            parameters[43].Value = model.C_CZYJ_JSZX;
            parameters[44].Value = model.C_COMMUTE_REASON;
            parameters[45].Value = model.D_COMMUTE_DATE;
            parameters[46].Value = model.N_IS_SH;
            parameters[47].Value = model.N_STATUS;
            parameters[48].Value = model.C_REMARK;
            parameters[49].Value = model.C_REMARK1;
            parameters[50].Value = model.C_REMARK2;
            parameters[51].Value = model.C_REMARK3;

            int rows = TransactionHelper.ExecuteSql(strSql.ToString(), parameters);
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
        public bool Update(Mod_TQC_TP_SLAB_COMMUTE model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update TQC_TP_SLAB_COMMUTE set ");
			strSql.Append("C_SLAB_MAIN_ID=:C_SLAB_MAIN_ID,");
			strSql.Append("C_STA_ID=:C_STA_ID,");
			strSql.Append("C_STOVE=:C_STOVE,");
			strSql.Append("C_BATCH_NO=:C_BATCH_NO,");
			strSql.Append("N_WGT=:N_WGT,");
			strSql.Append("N_LEN_BEFORE=:N_LEN_BEFORE,");
			strSql.Append("N_LEN_AFTER=:N_LEN_AFTER,");
			strSql.Append("C_STL_GRD_BEFORE=:C_STL_GRD_BEFORE,");
			strSql.Append("C_STD_CODE_BEFORE=:C_STD_CODE_BEFORE,");
			strSql.Append("C_SPEC_BEFORE=:C_SPEC_BEFORE,");
			strSql.Append("C_MAT_CODE_BEFORE=:C_MAT_CODE_BEFORE,");
			strSql.Append("C_MAT_DESC_BEFORE=:C_MAT_DESC_BEFORE,");
			strSql.Append("C_STL_GRD_AFTER=:C_STL_GRD_AFTER,");
			strSql.Append("C_STD_CODE_AFTER=:C_STD_CODE_AFTER,");
			strSql.Append("C_SPEC_AFTER=:C_SPEC_AFTER,");
			strSql.Append("C_MAT_CODE_AFTER=:C_MAT_CODE_AFTER,");
			strSql.Append("C_MAT_DESC_AFTER=:C_MAT_DESC_AFTER,");
			strSql.Append("C_REASON_DEPMT_ID=:C_REASON_DEPMT_ID,");
			strSql.Append("C_REASON_DEPMT_DESC=:C_REASON_DEPMT_DESC,");
			strSql.Append("C_ZYX1_BEFORE=:C_ZYX1_BEFORE,");
			strSql.Append("C_ZYX2_BEFORE=:C_ZYX2_BEFORE,");
			strSql.Append("C_ZYX1_AFTER=:C_ZYX1_AFTER,");
			strSql.Append("C_ZYX2_AFTER=:C_ZYX2_AFTER,");
			strSql.Append("C_JUDGE_LEV_BP_BEFORE=:C_JUDGE_LEV_BP_BEFORE,");
			strSql.Append("C_JUDGE_LEV_BP_AFTER=:C_JUDGE_LEV_BP_AFTER,");
			strSql.Append("C_EMP_ID=:C_EMP_ID,");
			strSql.Append("D_MOD_DT=:D_MOD_DT,");
			strSql.Append("C_COMMUTE_SQ=:C_COMMUTE_SQ,");
			strSql.Append("C_CHECK_ZKB=:C_CHECK_ZKB,");
			strSql.Append("C_ZKB_EMP_ID=:C_ZKB_EMP_ID,");
			strSql.Append("D_CHECK_ZKB_DATE=:D_CHECK_ZKB_DATE,");
			strSql.Append("C_CZYJ_ZKB=:C_CZYJ_ZKB,");
			strSql.Append("C_CHECK_XC=:C_CHECK_XC,");
			strSql.Append("C_XC_EMP_ID=:C_XC_EMP_ID,");
			strSql.Append("D_CHECK_XC_DATE=:D_CHECK_XC_DATE,");
			strSql.Append("C_CZYJ_XC=:C_CZYJ_XC,");
			strSql.Append("C_CHECK_LG=:C_CHECK_LG,");
			strSql.Append("C_LG_EMP_ID=:C_LG_EMP_ID,");
			strSql.Append("D_CHECK_LG_DATE=:D_CHECK_LG_DATE,");
			strSql.Append("C_CZYJ_LG=:C_CZYJ_LG,");
			strSql.Append("C_CHECK_JSZX=:C_CHECK_JSZX,");
			strSql.Append("C_JSZX_EMP_ID=:C_JSZX_EMP_ID,");
			strSql.Append("D_CHECK_JSZX_DATE=:D_CHECK_JSZX_DATE,");
			strSql.Append("C_CZYJ_JSZX=:C_CZYJ_JSZX,");
			strSql.Append("C_COMMUTE_REASON=:C_COMMUTE_REASON,");
			strSql.Append("D_COMMUTE_DATE=:D_COMMUTE_DATE,");
			strSql.Append("N_IS_SH=:N_IS_SH,");
			strSql.Append("N_STATUS=:N_STATUS,");
			strSql.Append("C_REMARK=:C_REMARK,");
			strSql.Append("C_REMARK1=:C_REMARK1,");
			strSql.Append("C_REMARK2=:C_REMARK2,");
			strSql.Append("C_REMARK3=:C_REMARK3");
			strSql.Append(" where C_ID=:C_ID ");
			OracleParameter[] parameters = {
					new OracleParameter(":C_SLAB_MAIN_ID", OracleDbType.Varchar2,100),
					new OracleParameter(":C_STA_ID", OracleDbType.Varchar2,100),
					new OracleParameter(":C_STOVE", OracleDbType.Varchar2,100),
					new OracleParameter(":C_BATCH_NO", OracleDbType.Varchar2,100),
					new OracleParameter(":N_WGT", OracleDbType.Decimal,15),
					new OracleParameter(":N_LEN_BEFORE", OracleDbType.Decimal,15),
					new OracleParameter(":N_LEN_AFTER", OracleDbType.Decimal,15),
					new OracleParameter(":C_STL_GRD_BEFORE", OracleDbType.Varchar2,100),
					new OracleParameter(":C_STD_CODE_BEFORE", OracleDbType.Varchar2,100),
					new OracleParameter(":C_SPEC_BEFORE", OracleDbType.Varchar2,100),
					new OracleParameter(":C_MAT_CODE_BEFORE", OracleDbType.Varchar2,100),
					new OracleParameter(":C_MAT_DESC_BEFORE", OracleDbType.Varchar2,100),
					new OracleParameter(":C_STL_GRD_AFTER", OracleDbType.Varchar2,100),
					new OracleParameter(":C_STD_CODE_AFTER", OracleDbType.Varchar2,100),
					new OracleParameter(":C_SPEC_AFTER", OracleDbType.Varchar2,100),
					new OracleParameter(":C_MAT_CODE_AFTER", OracleDbType.Varchar2,100),
					new OracleParameter(":C_MAT_DESC_AFTER", OracleDbType.Varchar2,100),
					new OracleParameter(":C_REASON_DEPMT_ID", OracleDbType.Varchar2,100),
					new OracleParameter(":C_REASON_DEPMT_DESC", OracleDbType.Varchar2,100),
					new OracleParameter(":C_ZYX1_BEFORE", OracleDbType.Varchar2,100),
					new OracleParameter(":C_ZYX2_BEFORE", OracleDbType.Varchar2,100),
					new OracleParameter(":C_ZYX1_AFTER", OracleDbType.Varchar2,100),
					new OracleParameter(":C_ZYX2_AFTER", OracleDbType.Varchar2,100),
					new OracleParameter(":C_JUDGE_LEV_BP_BEFORE", OracleDbType.Varchar2,100),
					new OracleParameter(":C_JUDGE_LEV_BP_AFTER", OracleDbType.Varchar2,100),
					new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
					new OracleParameter(":D_MOD_DT", OracleDbType.Date),
					new OracleParameter(":C_COMMUTE_SQ", OracleDbType.Varchar2,200),
					new OracleParameter(":C_CHECK_ZKB", OracleDbType.Varchar2,100),
					new OracleParameter(":C_ZKB_EMP_ID", OracleDbType.Varchar2,100),
					new OracleParameter(":D_CHECK_ZKB_DATE", OracleDbType.Date),
					new OracleParameter(":C_CZYJ_ZKB", OracleDbType.Varchar2,200),
					new OracleParameter(":C_CHECK_XC", OracleDbType.Varchar2,100),
					new OracleParameter(":C_XC_EMP_ID", OracleDbType.Varchar2,100),
					new OracleParameter(":D_CHECK_XC_DATE", OracleDbType.Date),
					new OracleParameter(":C_CZYJ_XC", OracleDbType.Varchar2,200),
					new OracleParameter(":C_CHECK_LG", OracleDbType.Varchar2,100),
					new OracleParameter(":C_LG_EMP_ID", OracleDbType.Varchar2,100),
					new OracleParameter(":D_CHECK_LG_DATE", OracleDbType.Date),
					new OracleParameter(":C_CZYJ_LG", OracleDbType.Varchar2,200),
					new OracleParameter(":C_CHECK_JSZX", OracleDbType.Varchar2,100),
					new OracleParameter(":C_JSZX_EMP_ID", OracleDbType.Varchar2,100),
					new OracleParameter(":D_CHECK_JSZX_DATE", OracleDbType.Date),
					new OracleParameter(":C_CZYJ_JSZX", OracleDbType.Varchar2,200),
					new OracleParameter(":C_COMMUTE_REASON", OracleDbType.Varchar2,200),
					new OracleParameter(":D_COMMUTE_DATE", OracleDbType.Date),
					new OracleParameter(":N_IS_SH", OracleDbType.Decimal,1),
					new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
					new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
					new OracleParameter(":C_REMARK1", OracleDbType.Varchar2,200),
					new OracleParameter(":C_REMARK2", OracleDbType.Varchar2,200),
					new OracleParameter(":C_REMARK3", OracleDbType.Varchar2,200),
					new OracleParameter(":C_ID", OracleDbType.Varchar2,100)};
			parameters[0].Value = model.C_SLAB_MAIN_ID;
			parameters[1].Value = model.C_STA_ID;
			parameters[2].Value = model.C_STOVE;
			parameters[3].Value = model.C_BATCH_NO;
			parameters[4].Value = model.N_WGT;
			parameters[5].Value = model.N_LEN_BEFORE;
			parameters[6].Value = model.N_LEN_AFTER;
			parameters[7].Value = model.C_STL_GRD_BEFORE;
			parameters[8].Value = model.C_STD_CODE_BEFORE;
			parameters[9].Value = model.C_SPEC_BEFORE;
			parameters[10].Value = model.C_MAT_CODE_BEFORE;
			parameters[11].Value = model.C_MAT_DESC_BEFORE;
			parameters[12].Value = model.C_STL_GRD_AFTER;
			parameters[13].Value = model.C_STD_CODE_AFTER;
			parameters[14].Value = model.C_SPEC_AFTER;
			parameters[15].Value = model.C_MAT_CODE_AFTER;
			parameters[16].Value = model.C_MAT_DESC_AFTER;
			parameters[17].Value = model.C_REASON_DEPMT_ID;
			parameters[18].Value = model.C_REASON_DEPMT_DESC;
			parameters[19].Value = model.C_ZYX1_BEFORE;
			parameters[20].Value = model.C_ZYX2_BEFORE;
			parameters[21].Value = model.C_ZYX1_AFTER;
			parameters[22].Value = model.C_ZYX2_AFTER;
			parameters[23].Value = model.C_JUDGE_LEV_BP_BEFORE;
			parameters[24].Value = model.C_JUDGE_LEV_BP_AFTER;
			parameters[25].Value = model.C_EMP_ID;
			parameters[26].Value = model.D_MOD_DT;
			parameters[27].Value = model.C_COMMUTE_SQ;
			parameters[28].Value = model.C_CHECK_ZKB;
			parameters[29].Value = model.C_ZKB_EMP_ID;
			parameters[30].Value = model.D_CHECK_ZKB_DATE;
			parameters[31].Value = model.C_CZYJ_ZKB;
			parameters[32].Value = model.C_CHECK_XC;
			parameters[33].Value = model.C_XC_EMP_ID;
			parameters[34].Value = model.D_CHECK_XC_DATE;
			parameters[35].Value = model.C_CZYJ_XC;
			parameters[36].Value = model.C_CHECK_LG;
			parameters[37].Value = model.C_LG_EMP_ID;
			parameters[38].Value = model.D_CHECK_LG_DATE;
			parameters[39].Value = model.C_CZYJ_LG;
			parameters[40].Value = model.C_CHECK_JSZX;
			parameters[41].Value = model.C_JSZX_EMP_ID;
			parameters[42].Value = model.D_CHECK_JSZX_DATE;
			parameters[43].Value = model.C_CZYJ_JSZX;
			parameters[44].Value = model.C_COMMUTE_REASON;
			parameters[45].Value = model.D_COMMUTE_DATE;
			parameters[46].Value = model.N_IS_SH;
			parameters[47].Value = model.N_STATUS;
			parameters[48].Value = model.C_REMARK;
			parameters[49].Value = model.C_REMARK1;
			parameters[50].Value = model.C_REMARK2;
			parameters[51].Value = model.C_REMARK3;
			parameters[52].Value = model.C_ID;

			int rows=DbHelperOra.ExecuteSql(strSql.ToString(),parameters);
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
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from TQC_TP_SLAB_COMMUTE ");
			strSql.Append(" where C_ID=:C_ID ");
			OracleParameter[] parameters = {
					new OracleParameter(":C_ID", OracleDbType.Varchar2,100)			};
			parameters[0].Value = C_ID;

			int rows=DbHelperOra.ExecuteSql(strSql.ToString(),parameters);
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
		public bool DeleteList(string C_IDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from TQC_TP_SLAB_COMMUTE ");
			strSql.Append(" where C_ID in ("+C_IDlist + ")  ");
			int rows=DbHelperOra.ExecuteSql(strSql.ToString());
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
		public Mod_TQC_TP_SLAB_COMMUTE GetModel(string C_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select C_ID,C_SLAB_MAIN_ID,C_STA_ID,C_STOVE,C_BATCH_NO,N_WGT,N_LEN_BEFORE,N_LEN_AFTER,C_STL_GRD_BEFORE,C_STD_CODE_BEFORE,C_SPEC_BEFORE,C_MAT_CODE_BEFORE,C_MAT_DESC_BEFORE,C_STL_GRD_AFTER,C_STD_CODE_AFTER,C_SPEC_AFTER,C_MAT_CODE_AFTER,C_MAT_DESC_AFTER,C_REASON_DEPMT_ID,C_REASON_DEPMT_DESC,C_ZYX1_BEFORE,C_ZYX2_BEFORE,C_ZYX1_AFTER,C_ZYX2_AFTER,C_JUDGE_LEV_BP_BEFORE,C_JUDGE_LEV_BP_AFTER,C_EMP_ID,D_MOD_DT,C_COMMUTE_SQ,C_CHECK_ZKB,C_ZKB_EMP_ID,D_CHECK_ZKB_DATE,C_CZYJ_ZKB,C_CHECK_XC,C_XC_EMP_ID,D_CHECK_XC_DATE,C_CZYJ_XC,C_CHECK_LG,C_LG_EMP_ID,D_CHECK_LG_DATE,C_CZYJ_LG,C_CHECK_JSZX,C_JSZX_EMP_ID,D_CHECK_JSZX_DATE,C_CZYJ_JSZX,C_COMMUTE_REASON,D_COMMUTE_DATE,N_IS_SH,N_STATUS,C_REMARK,C_REMARK1,C_REMARK2,C_REMARK3 from TQC_TP_SLAB_COMMUTE ");
			strSql.Append(" where C_ID=:C_ID ");
			OracleParameter[] parameters = {
					new OracleParameter(":C_ID", OracleDbType.Varchar2,100)			};
			parameters[0].Value = C_ID;

			Mod_TQC_TP_SLAB_COMMUTE model=new Mod_TQC_TP_SLAB_COMMUTE();
			DataSet ds=DbHelperOra.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
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
		public Mod_TQC_TP_SLAB_COMMUTE DataRowToModel(DataRow row)
		{
			Mod_TQC_TP_SLAB_COMMUTE model=new Mod_TQC_TP_SLAB_COMMUTE();
			if (row != null)
			{
				if(row["C_ID"]!=null)
				{
					model.C_ID=row["C_ID"].ToString();
				}
				if(row["C_SLAB_MAIN_ID"]!=null)
				{
					model.C_SLAB_MAIN_ID=row["C_SLAB_MAIN_ID"].ToString();
				}
				if(row["C_STA_ID"]!=null)
				{
					model.C_STA_ID=row["C_STA_ID"].ToString();
				}
				if(row["C_STOVE"]!=null)
				{
					model.C_STOVE=row["C_STOVE"].ToString();
				}
				if(row["C_BATCH_NO"]!=null)
				{
					model.C_BATCH_NO=row["C_BATCH_NO"].ToString();
				}
				if(row["N_WGT"]!=null && row["N_WGT"].ToString()!="")
				{
					model.N_WGT=decimal.Parse(row["N_WGT"].ToString());
				}
				if(row["N_LEN_BEFORE"]!=null && row["N_LEN_BEFORE"].ToString()!="")
				{
					model.N_LEN_BEFORE=decimal.Parse(row["N_LEN_BEFORE"].ToString());
				}
				if(row["N_LEN_AFTER"]!=null && row["N_LEN_AFTER"].ToString()!="")
				{
					model.N_LEN_AFTER=decimal.Parse(row["N_LEN_AFTER"].ToString());
				}
				if(row["C_STL_GRD_BEFORE"]!=null)
				{
					model.C_STL_GRD_BEFORE=row["C_STL_GRD_BEFORE"].ToString();
				}
				if(row["C_STD_CODE_BEFORE"]!=null)
				{
					model.C_STD_CODE_BEFORE=row["C_STD_CODE_BEFORE"].ToString();
				}
				if(row["C_SPEC_BEFORE"]!=null)
				{
					model.C_SPEC_BEFORE=row["C_SPEC_BEFORE"].ToString();
				}
				if(row["C_MAT_CODE_BEFORE"]!=null)
				{
					model.C_MAT_CODE_BEFORE=row["C_MAT_CODE_BEFORE"].ToString();
				}
				if(row["C_MAT_DESC_BEFORE"]!=null)
				{
					model.C_MAT_DESC_BEFORE=row["C_MAT_DESC_BEFORE"].ToString();
				}
				if(row["C_STL_GRD_AFTER"]!=null)
				{
					model.C_STL_GRD_AFTER=row["C_STL_GRD_AFTER"].ToString();
				}
				if(row["C_STD_CODE_AFTER"]!=null)
				{
					model.C_STD_CODE_AFTER=row["C_STD_CODE_AFTER"].ToString();
				}
				if(row["C_SPEC_AFTER"]!=null)
				{
					model.C_SPEC_AFTER=row["C_SPEC_AFTER"].ToString();
				}
				if(row["C_MAT_CODE_AFTER"]!=null)
				{
					model.C_MAT_CODE_AFTER=row["C_MAT_CODE_AFTER"].ToString();
				}
				if(row["C_MAT_DESC_AFTER"]!=null)
				{
					model.C_MAT_DESC_AFTER=row["C_MAT_DESC_AFTER"].ToString();
				}
				if(row["C_REASON_DEPMT_ID"]!=null)
				{
					model.C_REASON_DEPMT_ID=row["C_REASON_DEPMT_ID"].ToString();
				}
				if(row["C_REASON_DEPMT_DESC"]!=null)
				{
					model.C_REASON_DEPMT_DESC=row["C_REASON_DEPMT_DESC"].ToString();
				}
				if(row["C_ZYX1_BEFORE"]!=null)
				{
					model.C_ZYX1_BEFORE=row["C_ZYX1_BEFORE"].ToString();
				}
				if(row["C_ZYX2_BEFORE"]!=null)
				{
					model.C_ZYX2_BEFORE=row["C_ZYX2_BEFORE"].ToString();
				}
				if(row["C_ZYX1_AFTER"]!=null)
				{
					model.C_ZYX1_AFTER=row["C_ZYX1_AFTER"].ToString();
				}
				if(row["C_ZYX2_AFTER"]!=null)
				{
					model.C_ZYX2_AFTER=row["C_ZYX2_AFTER"].ToString();
				}
				if(row["C_JUDGE_LEV_BP_BEFORE"]!=null)
				{
					model.C_JUDGE_LEV_BP_BEFORE=row["C_JUDGE_LEV_BP_BEFORE"].ToString();
				}
				if(row["C_JUDGE_LEV_BP_AFTER"]!=null)
				{
					model.C_JUDGE_LEV_BP_AFTER=row["C_JUDGE_LEV_BP_AFTER"].ToString();
				}
				if(row["C_EMP_ID"]!=null)
				{
					model.C_EMP_ID=row["C_EMP_ID"].ToString();
				}
				if(row["D_MOD_DT"]!=null && row["D_MOD_DT"].ToString()!="")
				{
					model.D_MOD_DT=DateTime.Parse(row["D_MOD_DT"].ToString());
				}
				if(row["C_COMMUTE_SQ"]!=null)
				{
					model.C_COMMUTE_SQ=row["C_COMMUTE_SQ"].ToString();
				}
				if(row["C_CHECK_ZKB"]!=null)
				{
					model.C_CHECK_ZKB=row["C_CHECK_ZKB"].ToString();
				}
				if(row["C_ZKB_EMP_ID"]!=null)
				{
					model.C_ZKB_EMP_ID=row["C_ZKB_EMP_ID"].ToString();
				}
				if(row["D_CHECK_ZKB_DATE"]!=null && row["D_CHECK_ZKB_DATE"].ToString()!="")
				{
					model.D_CHECK_ZKB_DATE=DateTime.Parse(row["D_CHECK_ZKB_DATE"].ToString());
				}
				if(row["C_CZYJ_ZKB"]!=null)
				{
					model.C_CZYJ_ZKB=row["C_CZYJ_ZKB"].ToString();
				}
				if(row["C_CHECK_XC"]!=null)
				{
					model.C_CHECK_XC=row["C_CHECK_XC"].ToString();
				}
				if(row["C_XC_EMP_ID"]!=null)
				{
					model.C_XC_EMP_ID=row["C_XC_EMP_ID"].ToString();
				}
				if(row["D_CHECK_XC_DATE"]!=null && row["D_CHECK_XC_DATE"].ToString()!="")
				{
					model.D_CHECK_XC_DATE=DateTime.Parse(row["D_CHECK_XC_DATE"].ToString());
				}
				if(row["C_CZYJ_XC"]!=null)
				{
					model.C_CZYJ_XC=row["C_CZYJ_XC"].ToString();
				}
				if(row["C_CHECK_LG"]!=null)
				{
					model.C_CHECK_LG=row["C_CHECK_LG"].ToString();
				}
				if(row["C_LG_EMP_ID"]!=null)
				{
					model.C_LG_EMP_ID=row["C_LG_EMP_ID"].ToString();
				}
				if(row["D_CHECK_LG_DATE"]!=null && row["D_CHECK_LG_DATE"].ToString()!="")
				{
					model.D_CHECK_LG_DATE=DateTime.Parse(row["D_CHECK_LG_DATE"].ToString());
				}
				if(row["C_CZYJ_LG"]!=null)
				{
					model.C_CZYJ_LG=row["C_CZYJ_LG"].ToString();
				}
				if(row["C_CHECK_JSZX"]!=null)
				{
					model.C_CHECK_JSZX=row["C_CHECK_JSZX"].ToString();
				}
				if(row["C_JSZX_EMP_ID"]!=null)
				{
					model.C_JSZX_EMP_ID=row["C_JSZX_EMP_ID"].ToString();
				}
				if(row["D_CHECK_JSZX_DATE"]!=null && row["D_CHECK_JSZX_DATE"].ToString()!="")
				{
					model.D_CHECK_JSZX_DATE=DateTime.Parse(row["D_CHECK_JSZX_DATE"].ToString());
				}
				if(row["C_CZYJ_JSZX"]!=null)
				{
					model.C_CZYJ_JSZX=row["C_CZYJ_JSZX"].ToString();
				}
				if(row["C_COMMUTE_REASON"]!=null)
				{
					model.C_COMMUTE_REASON=row["C_COMMUTE_REASON"].ToString();
				}
				if(row["D_COMMUTE_DATE"]!=null && row["D_COMMUTE_DATE"].ToString()!="")
				{
					model.D_COMMUTE_DATE=DateTime.Parse(row["D_COMMUTE_DATE"].ToString());
				}
				if(row["N_IS_SH"]!=null && row["N_IS_SH"].ToString()!="")
				{
					model.N_IS_SH=decimal.Parse(row["N_IS_SH"].ToString());
				}
				if(row["N_STATUS"]!=null && row["N_STATUS"].ToString()!="")
				{
					model.N_STATUS=decimal.Parse(row["N_STATUS"].ToString());
				}
				if(row["C_REMARK"]!=null)
				{
					model.C_REMARK=row["C_REMARK"].ToString();
				}
				if(row["C_REMARK1"]!=null)
				{
					model.C_REMARK1=row["C_REMARK1"].ToString();
				}
				if(row["C_REMARK2"]!=null)
				{
					model.C_REMARK2=row["C_REMARK2"].ToString();
				}
				if(row["C_REMARK3"]!=null)
				{
					model.C_REMARK3=row["C_REMARK3"].ToString();
				}
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select C_ID,C_SLAB_MAIN_ID,C_STA_ID,C_STOVE,C_BATCH_NO,N_WGT,N_LEN_BEFORE,N_LEN_AFTER,C_STL_GRD_BEFORE,C_STD_CODE_BEFORE,C_SPEC_BEFORE,C_MAT_CODE_BEFORE,C_MAT_DESC_BEFORE,C_STL_GRD_AFTER,C_STD_CODE_AFTER,C_SPEC_AFTER,C_MAT_CODE_AFTER,C_MAT_DESC_AFTER,C_REASON_DEPMT_ID,C_REASON_DEPMT_DESC,C_ZYX1_BEFORE,C_ZYX2_BEFORE,C_ZYX1_AFTER,C_ZYX2_AFTER,C_JUDGE_LEV_BP_BEFORE,C_JUDGE_LEV_BP_AFTER,C_EMP_ID,D_MOD_DT,C_COMMUTE_SQ,C_CHECK_ZKB,C_ZKB_EMP_ID,D_CHECK_ZKB_DATE,C_CZYJ_ZKB,C_CHECK_XC,C_XC_EMP_ID,D_CHECK_XC_DATE,C_CZYJ_XC,C_CHECK_LG,C_LG_EMP_ID,D_CHECK_LG_DATE,C_CZYJ_LG,C_CHECK_JSZX,C_JSZX_EMP_ID,D_CHECK_JSZX_DATE,C_CZYJ_JSZX,C_COMMUTE_REASON,D_COMMUTE_DATE,N_IS_SH,N_STATUS,C_REMARK,C_REMARK1,C_REMARK2,C_REMARK3 ");
			strSql.Append(" FROM TQC_TP_SLAB_COMMUTE ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperOra.Query(strSql.ToString());
		}
        /// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList_Stove(string C_STOVE,string C_STL_GRD,string C_STD_CODE)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_SLAB_MAIN_ID,C_STA_ID,C_STOVE,C_BATCH_NO,N_WGT,N_LEN_BEFORE,N_LEN_AFTER,C_STL_GRD_BEFORE,C_STD_CODE_BEFORE,C_SPEC_BEFORE,C_MAT_CODE_BEFORE,C_MAT_DESC_BEFORE,C_STL_GRD_AFTER,C_STD_CODE_AFTER,C_SPEC_AFTER,C_MAT_CODE_AFTER,C_MAT_DESC_AFTER,C_REASON_DEPMT_ID,C_REASON_DEPMT_DESC,C_ZYX1_BEFORE,C_ZYX2_BEFORE,C_ZYX1_AFTER,C_ZYX2_AFTER,C_JUDGE_LEV_BP_BEFORE,C_JUDGE_LEV_BP_AFTER,C_EMP_ID,D_MOD_DT,C_COMMUTE_SQ,C_CHECK_ZKB,C_ZKB_EMP_ID,D_CHECK_ZKB_DATE,C_CZYJ_ZKB,C_CHECK_XC,C_XC_EMP_ID,D_CHECK_XC_DATE,C_CZYJ_XC,C_CHECK_LG,C_LG_EMP_ID,D_CHECK_LG_DATE,C_CZYJ_LG,C_CHECK_JSZX,C_JSZX_EMP_ID,D_CHECK_JSZX_DATE,C_CZYJ_JSZX,C_COMMUTE_REASON,D_COMMUTE_DATE,N_IS_SH,N_STATUS,C_REMARK,C_REMARK1,C_REMARK2,C_REMARK3 ");
            strSql.Append(" FROM TQC_TP_SLAB_COMMUTE ");
            strSql.Append(" where N_STATUS=1 AND N_IS_SH=1 AND C_STOVE='"+ C_STOVE + "' AND C_STL_GRD_BEFORE='"+ C_STL_GRD + "' AND C_STD_CODE_BEFORE='"+ C_STD_CODE + "' ");
            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 挑坯改判确认查询
        /// </summary>
        /// <param name="C_STOVE">炉号</param>
        /// <param name="C_BATCH_NO">批号</param>
        /// <param name="C_STL_GRD">钢种</param>
        /// <param name="C_STD_CODE">执行标准</param>
        /// <param name="C_MAT_CODE">物料编码</param>
        /// <param name="C_ZYX1_BEFORE">自由项1</param>
        /// <param name="C_ZYX2_BEFORE">自由项2</param>
        /// <param name="C_REMARK3">仓库</param>
        /// <param name="C_MAT_CODE_AFTER">改判后物料编码</param>
        /// <param name="C_STD_CODE_AFTER">改判后执行标准</param>
        /// <param name="C_ZYX1_AFTER">改判后自由项1</param>
        /// <param name="C_ZYX2_AFTER">改判后自由项2</param>
        /// <returns></returns>
        public DataSet GetList_TPGP_COU(string C_STOVE, string C_BATCH_NO, string C_STL_GRD, string C_STD_CODE, string C_MAT_CODE, string C_ZYX1_BEFORE, string C_ZYX2_BEFORE, string C_REMARK3,string C_MAT_CODE_AFTER,string C_STD_CODE_AFTER,string C_ZYX1_AFTER,string C_ZYX2_AFTER)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_SLAB_MAIN_ID,C_STA_ID,C_STOVE,C_BATCH_NO,N_WGT,N_LEN_BEFORE,N_LEN_AFTER,C_STL_GRD_BEFORE,C_STD_CODE_BEFORE,C_SPEC_BEFORE,C_MAT_CODE_BEFORE,C_MAT_DESC_BEFORE,C_STL_GRD_AFTER,C_STD_CODE_AFTER,C_SPEC_AFTER,C_MAT_CODE_AFTER,C_MAT_DESC_AFTER,C_REASON_DEPMT_ID,C_REASON_DEPMT_DESC,C_ZYX1_BEFORE,C_ZYX2_BEFORE,C_ZYX1_AFTER,C_ZYX2_AFTER,C_JUDGE_LEV_BP_BEFORE,C_JUDGE_LEV_BP_AFTER,C_EMP_ID,D_MOD_DT,C_COMMUTE_SQ,C_CHECK_ZKB,C_ZKB_EMP_ID,D_CHECK_ZKB_DATE,C_CZYJ_ZKB,C_CHECK_XC,C_XC_EMP_ID,D_CHECK_XC_DATE,C_CZYJ_XC,C_CHECK_LG,C_LG_EMP_ID,D_CHECK_LG_DATE,C_CZYJ_LG,C_CHECK_JSZX,C_JSZX_EMP_ID,D_CHECK_JSZX_DATE,C_CZYJ_JSZX,C_COMMUTE_REASON,D_COMMUTE_DATE,N_IS_SH,N_STATUS,C_REMARK,C_REMARK1,C_REMARK2,C_REMARK3 ");
            strSql.Append(" FROM TQC_TP_SLAB_COMMUTE ");
            strSql.Append(" where N_STATUS=1 and  ( C_CHECK_JSZX='Y' or  N_IS_SH=0) AND C_STOVE='" + C_STOVE + "' AND C_STL_GRD_BEFORE='" + C_STL_GRD + "' AND C_STD_CODE_BEFORE='" + C_STD_CODE + "' and C_MAT_CODE_BEFORE = '" + C_MAT_CODE + "'  AND nvl(C_BATCH_NO,' ' )=nvl('" + C_BATCH_NO + "',' ')  AND C_ZYX1_BEFORE='"+ C_ZYX1_BEFORE + "'   AND C_ZYX2_BEFORE='"+ C_ZYX2_BEFORE + "' AND C_REMARK3='"+ C_REMARK3 + "' AND C_MAT_CODE_AFTER='"+ C_MAT_CODE_AFTER + "' AND C_STD_CODE_AFTER='"+ C_STD_CODE_AFTER + "'  AND C_ZYX1_AFTER='"+ C_ZYX1_AFTER + "' AND C_ZYX2_AFTER = '"+ C_ZYX2_AFTER + "' ");
            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM TQC_TP_SLAB_COMMUTE ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
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
			StringBuilder strSql=new StringBuilder();
			strSql.Append("SELECT * FROM ( ");
			strSql.Append(" SELECT ROW_NUMBER() OVER (");
			if (!string.IsNullOrEmpty(orderby.Trim()))
			{
				strSql.Append("order by T." + orderby );
			}
			else
			{
				strSql.Append("order by T.C_ID desc");
			}
			strSql.Append(")AS Row, T.*  from TQC_TP_SLAB_COMMUTE T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DbHelperOra.Query(strSql.ToString());
		}

		/*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			OracleParameter[] parameters = {
					new OracleParameter(":tblName", OracleDbType.Varchar2, 255),
					new OracleParameter(":fldName", OracleDbType.Varchar2, 255),
					new OracleParameter(":PageSize", OracleDbType.Number),
					new OracleParameter(":PageIndex", OracleDbType.Number),
					new OracleParameter(":IsReCount", OracleDbType.Clob),
					new OracleParameter(":OrderType", OracleDbType.Clob),
					new OracleParameter(":strWhere", OracleDbType.Varchar2,1000),
					};
			parameters[0].Value = "TQC_TP_SLAB_COMMUTE";
			parameters[1].Value = "C_ID";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperOra.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  BasicMethod
		#region  ExtensionMethod
         /// <summary>
        /// 挑坯改判记录查询
        /// </summary>
        /// <param name="begin">开始时间</param>
        /// <param name="end">结束时间</param>
        /// <param name="C_STOVE">炉号/开坯号</param>
        /// <returns></returns>
        public DataSet GetList_TP(DateTime begin, DateTime end, string C_STOVE)
        {
            string sql = @"SELECT T.C_STA_ID AS 铸机号,
                           T.C_STOVE AS 炉号,
                           T.C_BATCH_NO AS 开坯号,
                           COUNT(1) AS 件数,
                           SUM(T.N_WGT) AS 重量,  T.C_REMARK3 AS 仓库,
                           T.C_EMP_ID AS 改判申请人,
                           MAX(T.D_MOD_DT) AS 改判申请时间,
                           T.C_COMMUTE_SQ AS 改判申请原因 ,
                           T.N_LEN_BEFORE AS 改判前定尺,
                           T.C_STL_GRD_BEFORE AS 改判前钢种,
                           T.C_STD_CODE_BEFORE AS 改判前标准,
                           T.C_SPEC_BEFORE AS 改判前断面,
                           T.C_MAT_CODE_BEFORE AS 改判前物料编码,
                           T.C_MAT_DESC_BEFORE AS 改判前物料描述,
                           T.C_JUDGE_LEV_BP_BEFORE AS 改判前判定等级,
                           T.C_ZYX1_BEFORE AS 改判前自由项1,
                           T.C_ZYX2_BEFORE AS 改判前自由项2,
                           T.N_LEN_AFTER AS 改判后定尺,
                           T.C_STL_GRD_AFTER AS 改判后钢种,
                           T.C_STD_CODE_AFTER AS 改判后标准,
                           T.C_SPEC_AFTER AS 改判后断面,
                           T.C_MAT_CODE_AFTER AS 改判后物料编码,
                           T.C_MAT_DESC_AFTER AS 改判后物料描述,
                           T.C_ZYX1_AFTER AS 改判后自由项1,
                           T.C_ZYX2_AFTER AS 改判后自由项2,
                           T.C_JUDGE_LEV_BP_AFTER AS 改判后判定等级,
                           T.C_REASON_DEPMT_ID AS 责任单位代码,
                           T.C_REASON_DEPMT_DESC AS 责任单位描述 
                           FROM TQC_TP_SLAB_COMMUTE T where T.N_STATUS = 1 and  t.N_IS_SH=1 and t.C_CHECK_LG IS NULL  ";

            if (begin != null && end != null)
            {
                sql += @" and T.D_MOD_DT between to_date('" + Convert.ToDateTime(begin) + "','yyyy-mm-dd hh24:mi:ss') and to_date('" + Convert.ToDateTime(end) + "','yyyy-mm-dd hh24:mi:ss') ";
            }
            if (C_STOVE.Trim() != "")
            {
                sql += @" and (C_STOVE = '" + C_STOVE + "' or C_BATCH_NO = '" + C_STOVE + "') ";
            }
                    sql += @"GROUP BY T.C_STA_ID ,
                             T.C_STOVE ,
                             T.C_BATCH_NO,
                             T.N_LEN_BEFORE,
                             T.C_STL_GRD_BEFORE,
                             T.C_STD_CODE_BEFORE ,
                             T.C_SPEC_BEFORE ,
                             T.C_MAT_CODE_BEFORE ,
                             T.C_MAT_DESC_BEFORE ,
                             T.N_LEN_AFTER ,
                             T.C_STL_GRD_AFTER ,
                             T.C_STD_CODE_AFTER ,
                             T.C_SPEC_AFTER ,
                             T.C_MAT_CODE_AFTER ,
                             T.C_MAT_DESC_AFTER ,
                             T.C_REASON_DEPMT_ID ,
                             T.C_REASON_DEPMT_DESC ,
                             T.C_ZYX1_BEFORE ,
                             T.C_ZYX2_BEFORE ,
                             T.C_ZYX1_AFTER ,
                             T.C_ZYX2_AFTER ,
                             T.C_JUDGE_LEV_BP_BEFORE ,
                             T.C_JUDGE_LEV_BP_AFTER ,
                             T.C_EMP_ID, T.C_REMARK3,
                             T.C_COMMUTE_SQ ";
            sql += @" ORDER BY T.C_STOVE ";
            return DbHelperOra.Query(sql); 
          
        }

        /// <summary>
        /// 挑坯改判记录查询
        /// </summary>
        /// <param name="begin">开始时间</param>
        /// <param name="end">结束时间</param>
        /// <param name="C_STOVE">炉号/开坯号</param>
        /// <returns></returns>
        public DataSet GetList_TP_LG(DateTime begin, DateTime end, string C_STOVE)
        {
            string sql = @"SELECT T.C_STA_ID AS 铸机号,
                           T.C_STOVE AS 炉号,
                           COUNT(1) AS 件数,
                           T.C_BATCH_NO AS 开坯号,
                           SUM(T.N_WGT) AS 重量,  T.C_REMARK3 AS 仓库,
                           T.C_EMP_ID AS 改判申请人,
                           MAX(T.D_MOD_DT) AS 改判申请时间,
                           T.C_COMMUTE_SQ AS 改判申请原因 ,
                           T.N_LEN_BEFORE AS 改判前定尺,
                           T.C_STL_GRD_BEFORE AS 改判前钢种,
                           T.C_STD_CODE_BEFORE AS 改判前标准,
                           T.C_SPEC_BEFORE AS 改判前断面,
                           T.C_MAT_CODE_BEFORE AS 改判前物料编码,
                           T.C_MAT_DESC_BEFORE AS 改判前物料描述,
                           T.C_JUDGE_LEV_BP_BEFORE AS 改判前判定等级,
                           T.C_ZYX1_BEFORE AS 改判前自由项1,
                           T.C_ZYX2_BEFORE AS 改判前自由项2,
                           T.N_LEN_AFTER AS 改判后定尺,
                           T.C_STL_GRD_AFTER AS 改判后钢种,
                           T.C_STD_CODE_AFTER AS 改判后标准,
                           T.C_SPEC_AFTER AS 改判后断面,
                           T.C_MAT_CODE_AFTER AS 改判后物料编码,
                           T.C_MAT_DESC_AFTER AS 改判后物料描述,
                           T.C_ZYX1_AFTER AS 改判后自由项1,
                           T.C_ZYX2_AFTER AS 改判后自由项2,
                           T.C_JUDGE_LEV_BP_AFTER AS 改判后判定等级,
                           T.C_REASON_DEPMT_ID AS 责任单位代码,
                           T.C_REASON_DEPMT_DESC AS 责任单位描述, 
                           T.C_LG_EMP_ID AS 炼钢厂审核人,
                           MAX(T.D_CHECK_LG_DATE) AS 炼钢审核时间,
                           T.C_CZYJ_LG AS 炼钢处置意见
                           FROM TQC_TP_SLAB_COMMUTE T where T.N_STATUS = 1 and  t.N_IS_SH=1  and t.C_CHECK_XC IS NULL  ";

            if (begin != null && end != null)
            {
                sql += @" and T.D_MOD_DT between to_date('" + Convert.ToDateTime(begin) + "','yyyy-mm-dd hh24:mi:ss') and to_date('" + Convert.ToDateTime(end) + "','yyyy-mm-dd hh24:mi:ss') ";
            }
            if (C_STOVE.Trim() != "")
            {
                sql += @" and (C_STOVE = '" + C_STOVE + "' or C_BATCH_NO = '" + C_STOVE + "') ";
            }
            sql += @"GROUP BY T.C_STA_ID ,
                             T.C_STOVE , T.C_REMARK3,
                             T.C_BATCH_NO,
                             T.N_LEN_BEFORE,
                             T.C_STL_GRD_BEFORE,
                             T.C_STD_CODE_BEFORE ,
                             T.C_SPEC_BEFORE ,
                             T.C_MAT_CODE_BEFORE ,
                             T.C_MAT_DESC_BEFORE ,
                             T.N_LEN_AFTER ,
                             T.C_STL_GRD_AFTER ,
                             T.C_STD_CODE_AFTER ,
                             T.C_SPEC_AFTER ,
                             T.C_MAT_CODE_AFTER ,
                             T.C_MAT_DESC_AFTER ,
                             T.C_REASON_DEPMT_ID ,
                             T.C_REASON_DEPMT_DESC ,
                             T.C_ZYX1_BEFORE ,
                             T.C_ZYX2_BEFORE ,
                             T.C_ZYX1_AFTER ,
                             T.C_ZYX2_AFTER ,
                             T.C_JUDGE_LEV_BP_BEFORE ,
                             T.C_JUDGE_LEV_BP_AFTER ,
                             T.C_EMP_ID,
                             T.C_COMMUTE_SQ,                              
                             T.C_LG_EMP_ID, 
                             T.C_CZYJ_LG";
            sql += @" ORDER BY T.C_STOVE ";
            return DbHelperOra.Query(sql);

        }
        /// <summary>
        /// 挑坯改判记录查询
        /// </summary>
        /// <param name="begin">开始时间</param>
        /// <param name="end">结束时间</param>
        /// <param name="C_STOVE">炉号/开坯号</param>
        /// <returns></returns>
        public DataSet GetList_TP_XC(DateTime begin, DateTime end, string C_STOVE)
        {
            string sql = @"SELECT T.C_STA_ID AS 铸机号,
                           T.C_STOVE AS 炉号,
                           T.C_BATCH_NO AS 开坯号,
                           COUNT(1) AS 件数,
                           SUM(T.N_WGT) AS 重量,  T.C_REMARK3 AS 仓库,
                           T.C_EMP_ID AS 改判申请人,
                           MAX(T.D_MOD_DT) AS 改判申请时间,
                           T.C_COMMUTE_SQ AS 改判申请原因 ,
                           T.N_LEN_BEFORE AS 改判前定尺,
                           T.C_STL_GRD_BEFORE AS 改判前钢种,
                           T.C_STD_CODE_BEFORE AS 改判前标准,
                           T.C_SPEC_BEFORE AS 改判前断面,
                           T.C_MAT_CODE_BEFORE AS 改判前物料编码,
                           T.C_MAT_DESC_BEFORE AS 改判前物料描述,
                           T.C_JUDGE_LEV_BP_BEFORE AS 改判前判定等级,
                           T.C_ZYX1_BEFORE AS 改判前自由项1,
                           T.C_ZYX2_BEFORE AS 改判前自由项2,
                           T.N_LEN_AFTER AS 改判后定尺,
                           T.C_STL_GRD_AFTER AS 改判后钢种,
                           T.C_STD_CODE_AFTER AS 改判后标准,
                           T.C_SPEC_AFTER AS 改判后断面,
                           T.C_MAT_CODE_AFTER AS 改判后物料编码,
                           T.C_MAT_DESC_AFTER AS 改判后物料描述,
                           T.C_ZYX1_AFTER AS 改判后自由项1,
                           T.C_ZYX2_AFTER AS 改判后自由项2,
                           T.C_JUDGE_LEV_BP_AFTER AS 改判后判定等级,
                           T.C_REASON_DEPMT_ID AS 责任单位代码,
                           T.C_REASON_DEPMT_DESC AS 责任单位描述, 
                           T.C_LG_EMP_ID AS 炼钢厂审核人,
                           MAX(T.D_CHECK_LG_DATE) AS 炼钢审核时间,
                           T.C_CZYJ_LG AS 炼钢处置意见, 
                           T.C_XC_EMP_ID AS 线材厂审核人,
                           MAX(T.D_CHECK_XC_DATE) AS 线材审核时间,
                           T.C_CZYJ_XC AS 线材处置意见
                           FROM TQC_TP_SLAB_COMMUTE T where T.N_STATUS = 1 and  t.N_IS_SH=1 and t.C_CHECK_ZKB IS NULL  ";

            if (begin != null && end != null)
            {
                sql += @" and T.D_MOD_DT between to_date('" + Convert.ToDateTime(begin) + "','yyyy-mm-dd hh24:mi:ss') and to_date('" + Convert.ToDateTime(end) + "','yyyy-mm-dd hh24:mi:ss') ";
            }
            if (C_STOVE.Trim() != "")
            {
                sql += @" and (C_STOVE = '" + C_STOVE + "' or C_BATCH_NO = '" + C_STOVE + "') ";
            }
            sql += @"GROUP BY T.C_STA_ID , T.C_REMARK3  ,
                             T.C_STOVE ,
                             T.C_BATCH_NO,
                             T.N_LEN_BEFORE,
                             T.C_STL_GRD_BEFORE,
                             T.C_STD_CODE_BEFORE ,
                             T.C_SPEC_BEFORE ,
                             T.C_MAT_CODE_BEFORE ,
                             T.C_MAT_DESC_BEFORE ,
                             T.N_LEN_AFTER ,
                             T.C_STL_GRD_AFTER ,
                             T.C_STD_CODE_AFTER ,
                             T.C_SPEC_AFTER ,
                             T.C_MAT_CODE_AFTER ,
                             T.C_MAT_DESC_AFTER ,
                             T.C_REASON_DEPMT_ID ,
                             T.C_REASON_DEPMT_DESC ,
                             T.C_ZYX1_BEFORE ,
                             T.C_ZYX2_BEFORE ,
                             T.C_ZYX1_AFTER ,
                             T.C_ZYX2_AFTER ,
                             T.C_JUDGE_LEV_BP_BEFORE ,
                             T.C_JUDGE_LEV_BP_AFTER ,
                             T.C_EMP_ID,
                             T.C_COMMUTE_SQ,
                             T.C_LG_EMP_ID,
                             T.C_XC_EMP_ID,
                             T.C_CZYJ_LG ,
                             T.C_CZYJ_XC";
            sql += @" ORDER BY T.C_STOVE ";
            return DbHelperOra.Query(sql);

        }

        /// <summary>
        /// 挑坯改判记录查询
        /// </summary>
        /// <param name="begin">开始时间</param>
        /// <param name="end">结束时间</param>
        /// <param name="C_STOVE">炉号/开坯号</param>
        /// <returns></returns>
        public DataSet GetList_TP_ZKB(DateTime begin, DateTime end, string C_STOVE)
        {
            string sql = @"SELECT T.C_STA_ID AS 铸机号,
                                  T.C_STOVE AS 炉号,
                                  T.C_BATCH_NO AS 开坯号,
                                  COUNT(1) AS 件数,
                                  SUM(T.N_WGT) AS 重量,
                                  T.C_REMARK3 AS 仓库,
                                  T.C_EMP_ID AS 改判申请人,
                                  MAX(T.D_MOD_DT) AS 改判申请时间,
                                  T.C_COMMUTE_SQ AS 改判申请原因,
                                  T.N_LEN_BEFORE AS 改判前定尺,
                                  T.C_STL_GRD_BEFORE AS 改判前钢种,
                                  T.C_STD_CODE_BEFORE AS 改判前标准,
                                  T.C_SPEC_BEFORE AS 改判前断面,
                                  T.C_MAT_CODE_BEFORE AS 改判前物料编码,
                                  T.C_MAT_DESC_BEFORE AS 改判前物料描述,
                                  T.C_JUDGE_LEV_BP_BEFORE AS 改判前判定等级,
                                  T.C_ZYX1_BEFORE AS 改判前自由项1,
                                  T.C_ZYX2_BEFORE AS 改判前自由项2,
                                  T.N_LEN_AFTER AS 改判后定尺,
                                  T.C_STL_GRD_AFTER AS 改判后钢种,
                                  T.C_STD_CODE_AFTER AS 改判后标准,
                                  T.C_SPEC_AFTER AS 改判后断面,
                                  T.C_MAT_CODE_AFTER AS 改判后物料编码,
                                  T.C_MAT_DESC_AFTER AS 改判后物料描述,
                                  T.C_ZYX1_AFTER AS 改判后自由项1,
                                  T.C_ZYX2_AFTER AS 改判后自由项2,
                                  T.C_JUDGE_LEV_BP_AFTER AS 改判后判定等级,
                                  T.C_REASON_DEPMT_ID AS 责任单位代码,
                                  T.C_REASON_DEPMT_DESC AS 责任单位描述,
                                  T.C_LG_EMP_ID AS 炼钢厂审核人,
                                  MAX(T.D_CHECK_LG_DATE) AS 炼钢厂审核时间,
                                  DECODE(T.C_CHECK_LG, 'Y', '审核通过', 'N', '审核驳回') AS 炼钢厂审核状态,
                                  T.C_CZYJ_LG AS 炼钢厂处置意见,
                                  T.C_XC_EMP_ID AS 线材厂审核人,
                                  MAX(T.D_CHECK_XC_DATE) AS 线材厂审核时间,
                                  DECODE(T.C_CHECK_XC, 'Y', '审核通过', 'N', '审核驳回') AS 线材厂审核状态,
                                  T.C_CZYJ_XC AS 线材厂处置意见,
                                  T.C_ZKB_EMP_ID AS 质控部审核人,
                                  MAX(T.D_CHECK_ZKB_DATE) AS 质控部审核时间,
                                  DECODE(T.C_CHECK_ZKB, 'Y', '审核通过', 'N', '审核驳回') AS 质控部审核状态,
                                  T.C_CZYJ_ZKB AS 质控部处置意见,
                                  T.C_JSZX_EMP_ID AS 技术中心审核人,
                                  MAX(T.D_CHECK_JSZX_DATE) AS 技术中心审核时间,
                                  DECODE(T.C_CHECK_JSZX, 'Y', '审核通过', 'N', '审核驳回') AS 技术中心审核状态,
                                  T.C_CZYJ_JSZX AS 技术中心处置意见 
                                  FROM TQC_TP_SLAB_COMMUTE T
                                  WHERE T.N_STATUS = 1
                                  AND T.N_IS_SH = 1
                                  AND T.C_CHECK_JSZX IS NULL  ";

            if (begin != null && end != null)
            {
                sql += @" and T.D_MOD_DT between to_date('" + Convert.ToDateTime(begin) + "','yyyy-mm-dd hh24:mi:ss') and to_date('" + Convert.ToDateTime(end) + "','yyyy-mm-dd hh24:mi:ss') ";
            }
            if (C_STOVE.Trim() != "")
            {
                sql += @" and (C_STOVE = '" + C_STOVE + "' or C_BATCH_NO = '" + C_STOVE + "') ";
            }
            sql += @"GROUP BY T.C_STA_ID,
                              T.C_REMARK3,
                              T.C_STOVE,
                              T.C_BATCH_NO,
                              T.N_LEN_BEFORE,
                              T.C_STL_GRD_BEFORE,
                              T.C_STD_CODE_BEFORE,
                              T.C_SPEC_BEFORE,
                              T.C_MAT_CODE_BEFORE,
                              T.C_MAT_DESC_BEFORE,
                              T.N_LEN_AFTER,
                              T.C_STL_GRD_AFTER,
                              T.C_STD_CODE_AFTER,
                              T.C_SPEC_AFTER,
                              T.C_MAT_CODE_AFTER,
                              T.C_MAT_DESC_AFTER,
                              T.C_REASON_DEPMT_ID,
                              T.C_REASON_DEPMT_DESC,
                              T.C_ZYX1_BEFORE,
                              T.C_ZYX2_BEFORE,
                              T.C_ZYX1_AFTER,
                              T.C_ZYX2_AFTER,
                              T.C_JUDGE_LEV_BP_BEFORE,
                              T.C_JUDGE_LEV_BP_AFTER,
                              T.C_EMP_ID,
                              T.C_COMMUTE_SQ,
                              T.C_LG_EMP_ID,
                              T.C_XC_EMP_ID,
                              T.C_CZYJ_LG,
                              T.C_CZYJ_XC,
                              T.C_ZKB_EMP_ID,
                              T.C_CZYJ_ZKB,
                              T.C_CHECK_ZKB,
                              T.C_CHECK_XC,
                              T.C_CHECK_LG,
                              T.C_JSZX_EMP_ID,
                              T.C_CHECK_JSZX,
                              T.C_CZYJ_JSZX ";

            sql += @" ORDER BY T.C_STOVE ";
            return DbHelperOra.Query(sql);

        }
        /// <summary>
        /// 挑坯改判记录查询
        /// </summary>
        /// <param name="begin">开始时间</param>
        /// <param name="end">结束时间</param>
        /// <param name="C_STOVE">炉号/开坯号</param>
        /// <returns></returns>
        public DataSet GetList_TPJL(DateTime begin, DateTime end, string C_STOVE)
        {
            string sql = @"SELECT T.C_STA_ID AS 铸机号,
                                  T.C_STOVE AS 炉号,
                                  T.C_BATCH_NO AS 开坯号,
                                  COUNT(1) AS 件数,
                                  SUM(T.N_WGT) AS 重量,
                                  T.C_REMARK3 AS 仓库,
                                  T.C_EMP_ID AS 改判申请人,
                                  MAX(T.D_MOD_DT) AS 改判申请时间,
                                  T.C_COMMUTE_SQ AS 改判申请原因,
                                  T.N_LEN_BEFORE AS 改判前定尺,
                                  T.C_STL_GRD_BEFORE AS 改判前钢种,
                                  T.C_STD_CODE_BEFORE AS 改判前标准,
                                  T.C_SPEC_BEFORE AS 改判前断面,
                                  T.C_MAT_CODE_BEFORE AS 改判前物料编码,
                                  T.C_MAT_DESC_BEFORE AS 改判前物料描述,
                                  T.C_JUDGE_LEV_BP_BEFORE AS 改判前判定等级,
                                  T.C_ZYX1_BEFORE AS 改判前自由项1,
                                  T.C_ZYX2_BEFORE AS 改判前自由项2,
                                  T.N_LEN_AFTER AS 改判后定尺,
                                  T.C_STL_GRD_AFTER AS 改判后钢种,
                                  T.C_STD_CODE_AFTER AS 改判后标准,
                                  T.C_SPEC_AFTER AS 改判后断面,
                                  T.C_MAT_CODE_AFTER AS 改判后物料编码,
                                  T.C_MAT_DESC_AFTER AS 改判后物料描述,
                                  T.C_ZYX1_AFTER AS 改判后自由项1,
                                  T.C_ZYX2_AFTER AS 改判后自由项2,
                                  T.C_JUDGE_LEV_BP_AFTER AS 改判后判定等级,
                                  T.C_REASON_DEPMT_ID AS 责任单位代码,
                                  T.C_REASON_DEPMT_DESC AS 责任单位描述,
                                  T.C_LG_EMP_ID AS 炼钢厂审核人,
                                  MAX(T.D_CHECK_LG_DATE) AS 炼钢厂审核时间,
                                  DECODE(T.C_CHECK_LG, 'Y', '审核通过', 'N', '审核驳回') AS 炼钢厂审核状态,
                                  T.C_CZYJ_LG AS 炼钢厂处置意见,
                                  T.C_XC_EMP_ID AS 线材厂审核人,
                                  MAX(T.D_CHECK_XC_DATE) AS 线材厂审核时间,
                                  DECODE(T.C_CHECK_XC, 'Y', '审核通过', 'N', '审核驳回') AS 线材厂审核状态,
                                  T.C_CZYJ_XC AS 线材厂处置意见,
                                  T.C_ZKB_EMP_ID AS 质控部审核人,
                                  MAX(T.D_CHECK_ZKB_DATE) AS 质控部审核时间,
                                  DECODE(T.C_CHECK_ZKB, 'Y', '审核通过', 'N', '审核驳回') AS 质控部审核状态,
                                  T.C_CZYJ_ZKB AS 质控部处置意见,
                                  T.C_JSZX_EMP_ID AS 技术中心审核人,
                                  MAX(T.D_CHECK_JSZX_DATE) AS 技术中心审核时间,
                                  DECODE(T.C_CHECK_JSZX, 'Y', '审核通过', 'N', '审核驳回') AS 技术中心审核状态,
                                  T.C_CZYJ_JSZX AS 技术中心处置意见,
                                  T.C_REMARK1 AS 最终改判人,
                                  MAX(T.D_COMMUTE_DATE) AS 最终改判时间， T.C_COMMUTE_REASON AS 改判原因
                                  FROM TQC_TP_SLAB_COMMUTE T
                                  WHERE  T.N_STATUS !=0  ";

            if (begin != null && end != null)
            {
                sql += @" and T.D_MOD_DT between to_date('" + Convert.ToDateTime(begin) + "','yyyy-mm-dd hh24:mi:ss') and to_date('" + Convert.ToDateTime(end) + "','yyyy-mm-dd hh24:mi:ss') ";
            }
            if (C_STOVE.Trim() != "")
            {
                sql += @" and (C_STOVE = '" + C_STOVE + "' or C_BATCH_NO = '" + C_STOVE + "') ";
            }
            sql += @"GROUP BY T.C_STA_ID,
                              T.C_REMARK3,
                              T.C_STOVE,
                              T.C_BATCH_NO,
                              T.N_LEN_BEFORE,
                              T.C_STL_GRD_BEFORE,
                              T.C_STD_CODE_BEFORE,
                              T.C_SPEC_BEFORE,
                              T.C_MAT_CODE_BEFORE,
                              T.C_MAT_DESC_BEFORE,
                              T.N_LEN_AFTER,
                              T.C_STL_GRD_AFTER,
                              T.C_STD_CODE_AFTER,
                              T.C_SPEC_AFTER,
                              T.C_MAT_CODE_AFTER,
                              T.C_MAT_DESC_AFTER,
                              T.C_REASON_DEPMT_ID,
                              T.C_REASON_DEPMT_DESC,
                              T.C_ZYX1_BEFORE,
                              T.C_ZYX2_BEFORE,
                              T.C_ZYX1_AFTER,
                              T.C_ZYX2_AFTER,
                              T.C_JUDGE_LEV_BP_BEFORE,
                              T.C_JUDGE_LEV_BP_AFTER,
                              T.C_EMP_ID,
                              T.C_COMMUTE_SQ,
                              T.C_LG_EMP_ID,
                              T.C_XC_EMP_ID,
                              T.C_CZYJ_LG,
                              T.C_CZYJ_XC,
                              T.C_ZKB_EMP_ID,
                              T.C_CZYJ_ZKB,
                              T.C_CHECK_ZKB,
                              T.C_CHECK_XC,
                              T.C_CHECK_LG,
                              T.C_JSZX_EMP_ID,
                              T.C_CHECK_JSZX,
                              T.C_CZYJ_JSZX， 
                              T.C_REMARK1,
                              T.C_COMMUTE_REASON ";

            sql += @" ORDER BY T.C_STOVE ";
            return DbHelperOra.Query(sql);

        }
        /// <summary>
        /// 挑坯改判记录查询
        /// </summary>
        /// <param name="begin">开始时间</param>
        /// <param name="end">结束时间</param>
        /// <param name="C_STOVE">炉号/开坯号</param>
        /// <returns></returns>
        public DataSet GetList_TPGP(DateTime begin, DateTime end, string C_STOVE)
        {
            string sql = @"SELECT T.C_STA_ID AS 铸机号,
                           T.C_STOVE AS 炉号,
                           T.C_BATCH_NO AS 开坯号,
                           COUNT(1) AS 件数,
                           SUM(T.N_WGT) AS 重量, 
                           T.C_REMARK3 AS 仓库编码,
                           T.C_EMP_ID AS 改判申请人,
                           MAX(T.D_MOD_DT) AS 改判申请时间,
                           T.C_COMMUTE_SQ AS 改判申请原因 ,
                           T.N_LEN_BEFORE AS 改判前定尺,
                           T.C_STL_GRD_BEFORE AS 改判前钢种,
                           T.C_STD_CODE_BEFORE AS 改判前标准,
                           T.C_SPEC_BEFORE AS 改判前断面,
                           T.C_MAT_CODE_BEFORE AS 改判前物料编码,
                           T.C_MAT_DESC_BEFORE AS 改判前物料描述,
                           T.C_JUDGE_LEV_BP_BEFORE AS 改判前判定等级,
                           T.C_ZYX1_BEFORE AS 改判前自由项1,
                           T.C_ZYX2_BEFORE AS 改判前自由项2,
                           T.N_LEN_AFTER AS 改判后定尺,
                           T.C_STL_GRD_AFTER AS 改判后钢种,
                           T.C_STD_CODE_AFTER AS 改判后标准,
                           T.C_SPEC_AFTER AS 改判后断面,
                           T.C_MAT_CODE_AFTER AS 改判后物料编码,
                           T.C_MAT_DESC_AFTER AS 改判后物料描述,
                           T.C_ZYX1_AFTER AS 改判后自由项1,
                           T.C_ZYX2_AFTER AS 改判后自由项2,
                           T.C_JUDGE_LEV_BP_AFTER AS 改判后判定等级,
                           T.C_REASON_DEPMT_ID AS 责任单位代码,
                           T.C_REASON_DEPMT_DESC AS 责任单位描述, 
                           T.C_LG_EMP_ID AS 炼钢厂审核人,
                           MAX(T.D_CHECK_LG_DATE) AS 炼钢审核时间,
                           T.C_CZYJ_LG AS 炼钢处置意见, 
                           T.C_XC_EMP_ID AS 线材厂审核人,
                           MAX(T.D_CHECK_XC_DATE) AS 线材审核时间,
                           T.C_CZYJ_XC AS 线材处置意见,
                           T.C_ZKB_EMP_ID AS 质控部审核人,
                           MAX(T.D_CHECK_ZKB_DATE) AS 线材厂审核时间,
                           T.C_CZYJ_ZKB AS 质控部处置意见,
                           T.C_JSZX_EMP_ID AS 技术中心审核人,
                           MAX(T.D_CHECK_JSZX_DATE) AS 技术中心审核时间,
                           DECODE(T.C_CHECK_JSZX, 'Y', '审核通过', 'N', '审核驳回') AS 技术中心审核状态,
                           T.C_CZYJ_JSZX AS 技术中心处置意见
                           FROM TQC_TP_SLAB_COMMUTE T where T.N_STATUS = 1 and  ( t.C_CHECK_JSZX='Y' or   t.N_IS_SH=0)  ";

            if (begin != null && end != null)
            {
                sql += @" and T.D_MOD_DT between to_date('" + Convert.ToDateTime(begin) + "','yyyy-mm-dd hh24:mi:ss') and to_date('" + Convert.ToDateTime(end) + "','yyyy-mm-dd hh24:mi:ss') ";
            }
            if (C_STOVE.Trim() != "")
            {
                sql += @" and (C_STOVE = '" + C_STOVE + "' or C_BATCH_NO = '" + C_STOVE + "') ";
            }
            sql += @"GROUP BY T.C_STA_ID ,
                             T.C_STOVE ,
                             T.C_BATCH_NO,
                             T.N_LEN_BEFORE,
                             T.C_STL_GRD_BEFORE,
                             T.C_STD_CODE_BEFORE ,
                             T.C_SPEC_BEFORE ,
                             T.C_MAT_CODE_BEFORE ,
                             T.C_MAT_DESC_BEFORE ,
                             T.N_LEN_AFTER ,
                             T.C_STL_GRD_AFTER ,
                             T.C_STD_CODE_AFTER ,
                             T.C_SPEC_AFTER ,
                             T.C_MAT_CODE_AFTER ,
                             T.C_MAT_DESC_AFTER ,
                             T.C_REASON_DEPMT_ID ,
                             T.C_REASON_DEPMT_DESC ,
                             T.C_ZYX1_BEFORE ,
                             T.C_ZYX2_BEFORE ,
                             T.C_ZYX1_AFTER ,
                             T.C_ZYX2_AFTER ,
                             T.C_JUDGE_LEV_BP_BEFORE ,
                             T.C_JUDGE_LEV_BP_AFTER ,
                             T.C_EMP_ID,
                             T.C_COMMUTE_SQ,
                             T.C_LG_EMP_ID,
                             T.C_XC_EMP_ID,
                             T.C_CZYJ_LG ,
                             T.C_CZYJ_XC,  
                             T.C_ZKB_EMP_ID,
                             T.C_CZYJ_ZKB,
                             T.C_REMARK3,
                             T.C_JSZX_EMP_ID, 
                             T.C_CHECK_JSZX, 
                             T.C_CZYJ_JSZX ";
            sql += @" ORDER BY T.C_STOVE ";
            return DbHelperOra.Query(sql);

        }
        #endregion  ExtensionMethod
    }
}

