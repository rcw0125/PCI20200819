using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;
namespace DAL
{
    /// <summary>
    /// 数据访问类:TQC_ROLL_COMMUTE
    /// </summary>
    public partial class Dal_TQC_ROLL_COMMUTE
    {
        public Dal_TQC_ROLL_COMMUTE()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string C_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TQC_ROLL_COMMUTE");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)          };
            parameters[0].Value = C_ID;

            return DbHelperOra.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Mod_TQC_ROLL_COMMUTE model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TQC_ROLL_COMMUTE(");
            strSql.Append("C_ROLL_ID,C_STA_ID,C_STA_DESC,C_STOVE,C_BATCH_NO,C_TICK_NO,N_WGT,C_STL_GRD_BEFORE,C_STD_CODE_BEFORE,C_SPEC_BEFORE,C_MAT_CODE_BEFORE,C_MAT_DESC_BEFORE,D_COMMUTE_DATE,C_STL_GRD_AFTER,C_STD_CODE_AFTER,C_SPEC_AFTER,C_MAT_CODE_AFTER,C_MAT_DESC_AFTER,C_REASON_DEPMT_ID,C_REASON_DEPMT_DESC,C_GP_TYPE,C_SCUTCHEON,N_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT,C_MASTER_ID,C_GP_BEFORE_ID,C_GP_AFTER_ID,C_ZYX1_BEFORE,C_ZYX2_BEFORE,C_ZYX1_AFTER,C_ZYX2_AFTER,C_JUDGE_LEV_BP_BEFORE,C_JUDGE_LEV_BP_AFTER,C_BZYQ_BEFORE,C_BZYQ_AFTER,C_COMMUTE_REASON)");
            strSql.Append(" values (");
            strSql.Append(":C_ROLL_ID,:C_STA_ID,:C_STA_DESC,:C_STOVE,:C_BATCH_NO,:C_TICK_NO,:N_WGT,:C_STL_GRD_BEFORE,:C_STD_CODE_BEFORE,:C_SPEC_BEFORE,:C_MAT_CODE_BEFORE,:C_MAT_DESC_BEFORE,:D_COMMUTE_DATE,:C_STL_GRD_AFTER,:C_STD_CODE_AFTER,:C_SPEC_AFTER,:C_MAT_CODE_AFTER,:C_MAT_DESC_AFTER,:C_REASON_DEPMT_ID,:C_REASON_DEPMT_DESC,:C_GP_TYPE,:C_SCUTCHEON,:N_STATUS,:C_REMARK,:C_EMP_ID,:D_MOD_DT,:C_MASTER_ID,:C_GP_BEFORE_ID,:C_GP_AFTER_ID,:C_ZYX1_BEFORE,:C_ZYX2_BEFORE,:C_ZYX1_AFTER,:C_ZYX2_AFTER,:C_JUDGE_LEV_BP_BEFORE,C_JUDGE_LEV_BP_AFTER,:C_BZYQ_BEFORE,:C_BZYQ_AFTER,:C_COMMUTE_REASON)");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ROLL_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STA_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STA_DESC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STOVE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_BATCH_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_TICK_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":C_STL_GRD_BEFORE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STD_CODE_BEFORE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SPEC_BEFORE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MAT_CODE_BEFORE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MAT_DESC_BEFORE", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_COMMUTE_DATE", OracleDbType.Date),
                    new OracleParameter(":C_STL_GRD_AFTER", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STD_CODE_AFTER", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SPEC_AFTER", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MAT_CODE_AFTER", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MAT_DESC_AFTER", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_REASON_DEPMT_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_REASON_DEPMT_DESC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_GP_TYPE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SCUTCHEON", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":C_MASTER_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_GP_BEFORE_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_GP_AFTER_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ZYX1_BEFORE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ZYX2_BEFORE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ZYX1_AFTER", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ZYX2_AFTER", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_JUDGE_LEV_BP_BEFORE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_JUDGE_LEV_BP_AFTER", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_BZYQ_BEFORE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_BZYQ_AFTER", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_COMMUTE_REASON", OracleDbType.Varchar2,200)
            };
            parameters[0].Value = model.C_ROLL_ID;
            parameters[1].Value = model.C_STA_ID;
            parameters[2].Value = model.C_STA_DESC;
            parameters[3].Value = model.C_STOVE;
            parameters[4].Value = model.C_BATCH_NO;
            parameters[5].Value = model.C_TICK_NO;
            parameters[6].Value = model.N_WGT;
            parameters[7].Value = model.C_STL_GRD_BEFORE;
            parameters[8].Value = model.C_STD_CODE_BEFORE;
            parameters[9].Value = model.C_SPEC_BEFORE;
            parameters[10].Value = model.C_MAT_CODE_BEFORE;
            parameters[11].Value = model.C_MAT_DESC_BEFORE;
            parameters[12].Value = model.D_COMMUTE_DATE;
            parameters[13].Value = model.C_STL_GRD_AFTER;
            parameters[14].Value = model.C_STD_CODE_AFTER;
            parameters[15].Value = model.C_SPEC_AFTER;
            parameters[16].Value = model.C_MAT_CODE_AFTER;
            parameters[17].Value = model.C_MAT_DESC_AFTER;
            parameters[18].Value = model.C_REASON_DEPMT_ID;
            parameters[19].Value = model.C_REASON_DEPMT_DESC;
            parameters[20].Value = model.C_GP_TYPE;
            parameters[21].Value = model.C_SCUTCHEON;
            parameters[22].Value = model.N_STATUS;
            parameters[23].Value = model.C_REMARK;
            parameters[24].Value = model.C_EMP_ID;
            parameters[25].Value = model.D_MOD_DT;
            parameters[26].Value = model.C_MASTER_ID;
            parameters[27].Value = model.C_GP_BEFORE_ID;
            parameters[28].Value = model.C_GP_AFTER_ID;
            parameters[29].Value = model.C_ZYX1_BEFORE;
            parameters[30].Value = model.C_ZYX2_BEFORE;
            parameters[31].Value = model.C_ZYX1_AFTER;
            parameters[32].Value = model.C_ZYX2_AFTER;
            parameters[33].Value = model.C_JUDGE_LEV_BP_BEFORE;
            parameters[34].Value = model.C_JUDGE_LEV_BP_AFTER;
            parameters[35].Value = model.C_BZYQ_BEFORE;
            parameters[36].Value = model.C_BZYQ_AFTER;
            parameters[37].Value = model.C_COMMUTE_REASON;

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
        /// 增加一条数据
        /// </summary>
        public bool Add_Trans(Mod_TQC_ROLL_COMMUTE model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TQC_ROLL_COMMUTE(");
            strSql.Append("C_ROLL_ID,C_STA_ID,C_STA_DESC,C_STOVE,C_BATCH_NO,C_TICK_NO,N_WGT,C_STL_GRD_BEFORE,C_STD_CODE_BEFORE,C_SPEC_BEFORE,C_MAT_CODE_BEFORE,C_MAT_DESC_BEFORE,D_COMMUTE_DATE,C_STL_GRD_AFTER,C_STD_CODE_AFTER,C_SPEC_AFTER,C_MAT_CODE_AFTER,C_MAT_DESC_AFTER,C_REASON_DEPMT_ID,C_REASON_DEPMT_DESC,C_GP_TYPE,C_SCUTCHEON,N_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT,C_MASTER_ID,C_GP_BEFORE_ID,C_GP_AFTER_ID,C_ZYX1_BEFORE,C_ZYX2_BEFORE,C_ZYX1_AFTER,C_ZYX2_AFTER,C_JUDGE_LEV_BP_BEFORE,C_JUDGE_LEV_BP_AFTER,C_BZYQ_BEFORE,C_BZYQ_AFTER,C_COMMUTE_REASON)");
            strSql.Append(" values (");
            strSql.Append(":C_ROLL_ID,:C_STA_ID,:C_STA_DESC,:C_STOVE,:C_BATCH_NO,:C_TICK_NO,:N_WGT,:C_STL_GRD_BEFORE,:C_STD_CODE_BEFORE,:C_SPEC_BEFORE,:C_MAT_CODE_BEFORE,:C_MAT_DESC_BEFORE,:D_COMMUTE_DATE,:C_STL_GRD_AFTER,:C_STD_CODE_AFTER,:C_SPEC_AFTER,:C_MAT_CODE_AFTER,:C_MAT_DESC_AFTER,:C_REASON_DEPMT_ID,:C_REASON_DEPMT_DESC,:C_GP_TYPE,:C_SCUTCHEON,:N_STATUS,:C_REMARK,:C_EMP_ID,:D_MOD_DT,:C_MASTER_ID,:C_GP_BEFORE_ID,:C_GP_AFTER_ID,:C_ZYX1_BEFORE,:C_ZYX2_BEFORE,:C_ZYX1_AFTER,:C_ZYX2_AFTER,:C_JUDGE_LEV_BP_BEFORE,:C_JUDGE_LEV_BP_AFTER,:C_BZYQ_BEFORE,:C_BZYQ_AFTER,:C_COMMUTE_REASON)");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ROLL_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STA_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STA_DESC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STOVE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_BATCH_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_TICK_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":C_STL_GRD_BEFORE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STD_CODE_BEFORE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SPEC_BEFORE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MAT_CODE_BEFORE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MAT_DESC_BEFORE", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_COMMUTE_DATE", OracleDbType.Date),
                    new OracleParameter(":C_STL_GRD_AFTER", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STD_CODE_AFTER", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SPEC_AFTER", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MAT_CODE_AFTER", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MAT_DESC_AFTER", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_REASON_DEPMT_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_REASON_DEPMT_DESC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_GP_TYPE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SCUTCHEON", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":C_MASTER_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_GP_BEFORE_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_GP_AFTER_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ZYX1_BEFORE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ZYX2_BEFORE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ZYX1_AFTER", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ZYX2_AFTER", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_JUDGE_LEV_BP_BEFORE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_JUDGE_LEV_BP_AFTER", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_BZYQ_BEFORE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_BZYQ_AFTER", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_COMMUTE_REASON", OracleDbType.Varchar2,200)
            };
            parameters[0].Value = model.C_ROLL_ID;
            parameters[1].Value = model.C_STA_ID;
            parameters[2].Value = model.C_STA_DESC;
            parameters[3].Value = model.C_STOVE;
            parameters[4].Value = model.C_BATCH_NO;
            parameters[5].Value = model.C_TICK_NO;
            parameters[6].Value = model.N_WGT;
            parameters[7].Value = model.C_STL_GRD_BEFORE;
            parameters[8].Value = model.C_STD_CODE_BEFORE;
            parameters[9].Value = model.C_SPEC_BEFORE;
            parameters[10].Value = model.C_MAT_CODE_BEFORE;
            parameters[11].Value = model.C_MAT_DESC_BEFORE;
            parameters[12].Value = model.D_COMMUTE_DATE;
            parameters[13].Value = model.C_STL_GRD_AFTER;
            parameters[14].Value = model.C_STD_CODE_AFTER;
            parameters[15].Value = model.C_SPEC_AFTER;
            parameters[16].Value = model.C_MAT_CODE_AFTER;
            parameters[17].Value = model.C_MAT_DESC_AFTER;
            parameters[18].Value = model.C_REASON_DEPMT_ID;
            parameters[19].Value = model.C_REASON_DEPMT_DESC;
            parameters[20].Value = model.C_GP_TYPE;
            parameters[21].Value = model.C_SCUTCHEON;
            parameters[22].Value = model.N_STATUS;
            parameters[23].Value = model.C_REMARK;
            parameters[24].Value = model.C_EMP_ID;
            parameters[25].Value = model.D_MOD_DT;
            parameters[26].Value = model.C_MASTER_ID;
            parameters[27].Value = model.C_GP_BEFORE_ID;
            parameters[28].Value = model.C_GP_AFTER_ID;
            parameters[29].Value = model.C_ZYX1_BEFORE;
            parameters[30].Value = model.C_ZYX2_BEFORE;
            parameters[31].Value = model.C_ZYX1_AFTER;
            parameters[32].Value = model.C_ZYX2_AFTER;
            parameters[33].Value = model.C_JUDGE_LEV_BP_BEFORE;
            parameters[34].Value = model.C_JUDGE_LEV_BP_AFTER;
            parameters[35].Value = model.C_BZYQ_BEFORE;
            parameters[36].Value = model.C_BZYQ_AFTER;
            parameters[37].Value = model.C_COMMUTE_REASON;
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
        public bool Update(Mod_TQC_ROLL_COMMUTE model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TQC_ROLL_COMMUTE set ");
            strSql.Append("C_ROLL_ID=:C_ROLL_ID,");
            strSql.Append("C_STA_ID=:C_STA_ID,");
            strSql.Append("C_STA_DESC=:C_STA_DESC,");
            strSql.Append("C_STOVE=:C_STOVE,");
            strSql.Append("C_BATCH_NO=:C_BATCH_NO,");
            strSql.Append("C_TICK_NO=:C_TICK_NO,");
            strSql.Append("N_WGT=:N_WGT,");
            strSql.Append("C_STL_GRD_BEFORE=:C_STL_GRD_BEFORE,");
            strSql.Append("C_STD_CODE_BEFORE=:C_STD_CODE_BEFORE,");
            strSql.Append("C_SPEC_BEFORE=:C_SPEC_BEFORE,");
            strSql.Append("C_MAT_CODE_BEFORE=:C_MAT_CODE_BEFORE,");
            strSql.Append("C_MAT_DESC_BEFORE=:C_MAT_DESC_BEFORE,");
            strSql.Append("D_COMMUTE_DATE=:D_COMMUTE_DATE,");
            strSql.Append("C_STL_GRD_AFTER=:C_STL_GRD_AFTER,");
            strSql.Append("C_STD_CODE_AFTER=:C_STD_CODE_AFTER,");
            strSql.Append("C_SPEC_AFTER=:C_SPEC_AFTER,");
            strSql.Append("C_MAT_CODE_AFTER=:C_MAT_CODE_AFTER,");
            strSql.Append("C_MAT_DESC_AFTER=:C_MAT_DESC_AFTER,");
            strSql.Append("C_REASON_DEPMT_ID=:C_REASON_DEPMT_ID,");
            strSql.Append("C_REASON_DEPMT_DESC=:C_REASON_DEPMT_DESC,");
            strSql.Append("C_GP_TYPE=:C_GP_TYPE,");
            strSql.Append("C_SCUTCHEON=:C_SCUTCHEON,");
            strSql.Append("N_STATUS=:N_STATUS,");
            strSql.Append("C_REMARK=:C_REMARK,");
            strSql.Append("C_EMP_ID=:C_EMP_ID,");
            strSql.Append("D_MOD_DT=:D_MOD_DT,");
            strSql.Append("C_MASTER_ID=:C_MASTER_ID,");
            strSql.Append("C_GP_BEFORE_ID=:C_GP_BEFORE_ID,");
            strSql.Append("C_GP_AFTER_ID=:C_GP_AFTER_ID,");
            strSql.Append("C_ZYX1_BEFORE=:C_ZYX1_BEFORE,");
            strSql.Append("C_ZYX2_BEFORE=:C_ZYX2_BEFORE,");
            strSql.Append("C_ZYX1_AFTER=:C_ZYX1_AFTER,");
            strSql.Append("C_ZYX2_AFTER=:C_ZYX2_AFTER,");
            strSql.Append("C_JUDGE_LEV_BP_BEFORE=:C_JUDGE_LEV_BP_BEFORE,");
            strSql.Append("C_JUDGE_LEV_BP_AFTER=:C_JUDGE_LEV_BP_AFTER,");
            strSql.Append("C_BZYQ_BEFORE=:C_BZYQ_BEFORE,");
            strSql.Append("C_BZYQ_AFTER=:C_BZYQ_AFTER,");
            strSql.Append("C_COMMUTE_REASON=:C_COMMUTE_REASON");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ROLL_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STA_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STA_DESC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STOVE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_BATCH_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_TICK_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":C_STL_GRD_BEFORE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STD_CODE_BEFORE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SPEC_BEFORE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MAT_CODE_BEFORE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MAT_DESC_BEFORE", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_COMMUTE_DATE", OracleDbType.Date),
                    new OracleParameter(":C_STL_GRD_AFTER", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STD_CODE_AFTER", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SPEC_AFTER", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MAT_CODE_AFTER", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MAT_DESC_AFTER", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_REASON_DEPMT_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_REASON_DEPMT_DESC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_GP_TYPE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SCUTCHEON", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":C_MASTER_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_GP_BEFORE_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_GP_AFTER_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ZYX1_BEFORE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ZYX2_BEFORE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ZYX1_AFTER", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ZYX2_AFTER", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_JUDGE_LEV_BP_BEFORE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_JUDGE_LEV_BP_AFTER", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_BZYQ_BEFORE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_BZYQ_AFTER", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_COMMUTE_REASON", OracleDbType.Varchar2,200),
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.C_ROLL_ID;
            parameters[1].Value = model.C_STA_ID;
            parameters[2].Value = model.C_STA_DESC;
            parameters[3].Value = model.C_STOVE;
            parameters[4].Value = model.C_BATCH_NO;
            parameters[5].Value = model.C_TICK_NO;
            parameters[6].Value = model.N_WGT;
            parameters[7].Value = model.C_STL_GRD_BEFORE;
            parameters[8].Value = model.C_STD_CODE_BEFORE;
            parameters[9].Value = model.C_SPEC_BEFORE;
            parameters[10].Value = model.C_MAT_CODE_BEFORE;
            parameters[11].Value = model.C_MAT_DESC_BEFORE;
            parameters[12].Value = model.D_COMMUTE_DATE;
            parameters[13].Value = model.C_STL_GRD_AFTER;
            parameters[14].Value = model.C_STD_CODE_AFTER;
            parameters[15].Value = model.C_SPEC_AFTER;
            parameters[16].Value = model.C_MAT_CODE_AFTER;
            parameters[17].Value = model.C_MAT_DESC_AFTER;
            parameters[18].Value = model.C_REASON_DEPMT_ID;
            parameters[19].Value = model.C_REASON_DEPMT_DESC;
            parameters[20].Value = model.C_GP_TYPE;
            parameters[21].Value = model.C_SCUTCHEON;
            parameters[22].Value = model.N_STATUS;
            parameters[23].Value = model.C_REMARK;
            parameters[24].Value = model.C_EMP_ID;
            parameters[25].Value = model.D_MOD_DT;
            parameters[26].Value = model.C_MASTER_ID;
            parameters[27].Value = model.C_GP_BEFORE_ID;
            parameters[28].Value = model.C_GP_AFTER_ID;
            parameters[29].Value = model.C_ZYX1_BEFORE;
            parameters[30].Value = model.C_ZYX2_BEFORE;
            parameters[31].Value = model.C_ZYX1_AFTER;
            parameters[32].Value = model.C_ZYX2_AFTER;
            parameters[33].Value = model.C_JUDGE_LEV_BP_BEFORE;
            parameters[34].Value = model.C_JUDGE_LEV_BP_AFTER;
            parameters[35].Value = model.C_BZYQ_BEFORE;
            parameters[36].Value = model.C_BZYQ_AFTER;
            parameters[37].Value = model.C_COMMUTE_REASON;
            parameters[38].Value = model.C_ID;

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
            strSql.Append("delete from TQC_ROLL_COMMUTE ");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)          };
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
            strSql.Append("delete from TQC_ROLL_COMMUTE ");
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
        public Mod_TQC_ROLL_COMMUTE GetModel_Interface_Trans(string C_MASTER_ID, string C_GP_BEFORE_ID, string C_GP_AFTER_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_ROLL_ID,C_STA_ID,C_STA_DESC,C_STOVE,C_BATCH_NO,C_TICK_NO,N_WGT,C_STL_GRD_BEFORE,C_STD_CODE_BEFORE,C_SPEC_BEFORE,C_MAT_CODE_BEFORE,C_MAT_DESC_BEFORE,D_COMMUTE_DATE,C_STL_GRD_AFTER,C_STD_CODE_AFTER,C_SPEC_AFTER,C_MAT_CODE_AFTER,C_MAT_DESC_AFTER,C_REASON_DEPMT_ID,C_REASON_DEPMT_DESC,C_GP_TYPE,C_SCUTCHEON,N_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT,C_MASTER_ID,C_GP_BEFORE_ID,C_GP_AFTER_ID,C_ZYX1_BEFORE,C_ZYX2_BEFORE,C_ZYX1_AFTER,C_ZYX2_AFTER,C_JUDGE_LEV_BP_BEFORE,C_JUDGE_LEV_BP_AFTER,C_BZYQ_BEFORE,C_BZYQ_AFTER,C_COMMUTE_REASON from TQC_ROLL_COMMUTE ");
            strSql.Append(" where C_MASTER_ID=:C_MASTER_ID ");
            strSql.Append(" and C_GP_BEFORE_ID=:C_GP_BEFORE_ID ");
            strSql.Append(" and C_GP_AFTER_ID=:C_GP_AFTER_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_MASTER_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_GP_BEFORE_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_GP_AFTER_ID", OracleDbType.Varchar2,100)              };
            parameters[0].Value = C_MASTER_ID;
            parameters[1].Value = C_GP_BEFORE_ID;
            parameters[2].Value = C_GP_AFTER_ID;
            Mod_TQC_ROLL_COMMUTE model = new Mod_TQC_ROLL_COMMUTE();
            DataSet ds = TransactionHelper.Query(strSql.ToString(), parameters);
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
		public Mod_TQC_ROLL_COMMUTE GetModel(string C_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_ROLL_ID,C_STA_ID,C_STA_DESC,C_STOVE,C_BATCH_NO,C_TICK_NO,N_WGT,C_STL_GRD_BEFORE,C_STD_CODE_BEFORE,C_SPEC_BEFORE,C_MAT_CODE_BEFORE,C_MAT_DESC_BEFORE,D_COMMUTE_DATE,C_STL_GRD_AFTER,C_STD_CODE_AFTER,C_SPEC_AFTER,C_MAT_CODE_AFTER,C_MAT_DESC_AFTER,C_REASON_DEPMT_ID,C_REASON_DEPMT_DESC,C_GP_TYPE,C_SCUTCHEON,N_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT,C_MASTER_ID,C_GP_BEFORE_ID,C_GP_AFTER_ID,C_ZYX1_BEFORE,C_ZYX2_BEFORE,C_ZYX1_AFTER,C_ZYX2_AFTER,C_JUDGE_LEV_BP_BEFORE,C_JUDGE_LEV_BP_AFTER,C_BZYQ_BEFORE,C_BZYQ_AFTER,C_COMMUTE_REASON from TQC_ROLL_COMMUTE ");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)            };
            parameters[0].Value = C_ID;

            Mod_TQC_ROLL_COMMUTE model = new Mod_TQC_ROLL_COMMUTE();
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
        public Mod_TQC_ROLL_COMMUTE DataRowToModel(DataRow row)
        {
            Mod_TQC_ROLL_COMMUTE model = new Mod_TQC_ROLL_COMMUTE();
            if (row != null)
            {
                if (row["C_ID"] != null)
                {
                    model.C_ID = row["C_ID"].ToString();
                }
                if (row["C_ROLL_ID"] != null)
                {
                    model.C_ROLL_ID = row["C_ROLL_ID"].ToString();
                }
                if (row["C_STA_ID"] != null)
                {
                    model.C_STA_ID = row["C_STA_ID"].ToString();
                }
                if (row["C_STA_DESC"] != null)
                {
                    model.C_STA_DESC = row["C_STA_DESC"].ToString();
                }
                if (row["C_STOVE"] != null)
                {
                    model.C_STOVE = row["C_STOVE"].ToString();
                }
                if (row["C_BATCH_NO"] != null)
                {
                    model.C_BATCH_NO = row["C_BATCH_NO"].ToString();
                }
                if (row["C_TICK_NO"] != null)
                {
                    model.C_TICK_NO = row["C_TICK_NO"].ToString();
                }
                if (row["N_WGT"] != null && row["N_WGT"].ToString() != "")
                {
                    model.N_WGT = decimal.Parse(row["N_WGT"].ToString());
                }
                if (row["C_STL_GRD_BEFORE"] != null)
                {
                    model.C_STL_GRD_BEFORE = row["C_STL_GRD_BEFORE"].ToString();
                }
                if (row["C_STD_CODE_BEFORE"] != null)
                {
                    model.C_STD_CODE_BEFORE = row["C_STD_CODE_BEFORE"].ToString();
                }
                if (row["C_SPEC_BEFORE"] != null)
                {
                    model.C_SPEC_BEFORE = row["C_SPEC_BEFORE"].ToString();
                }
                if (row["C_MAT_CODE_BEFORE"] != null)
                {
                    model.C_MAT_CODE_BEFORE = row["C_MAT_CODE_BEFORE"].ToString();
                }
                if (row["C_MAT_DESC_BEFORE"] != null)
                {
                    model.C_MAT_DESC_BEFORE = row["C_MAT_DESC_BEFORE"].ToString();
                }
                if (row["D_COMMUTE_DATE"] != null && row["D_COMMUTE_DATE"].ToString() != "")
                {
                    model.D_COMMUTE_DATE = DateTime.Parse(row["D_COMMUTE_DATE"].ToString());
                }
                if (row["C_STL_GRD_AFTER"] != null)
                {
                    model.C_STL_GRD_AFTER = row["C_STL_GRD_AFTER"].ToString();
                }
                if (row["C_STD_CODE_AFTER"] != null)
                {
                    model.C_STD_CODE_AFTER = row["C_STD_CODE_AFTER"].ToString();
                }
                if (row["C_SPEC_AFTER"] != null)
                {
                    model.C_SPEC_AFTER = row["C_SPEC_AFTER"].ToString();
                }
                if (row["C_MAT_CODE_AFTER"] != null)
                {
                    model.C_MAT_CODE_AFTER = row["C_MAT_CODE_AFTER"].ToString();
                }
                if (row["C_MAT_DESC_AFTER"] != null)
                {
                    model.C_MAT_DESC_AFTER = row["C_MAT_DESC_AFTER"].ToString();
                }
                if (row["C_REASON_DEPMT_ID"] != null)
                {
                    model.C_REASON_DEPMT_ID = row["C_REASON_DEPMT_ID"].ToString();
                }
                if (row["C_REASON_DEPMT_DESC"] != null)
                {
                    model.C_REASON_DEPMT_DESC = row["C_REASON_DEPMT_DESC"].ToString();
                }
                if (row["C_GP_TYPE"] != null)
                {
                    model.C_GP_TYPE = row["C_GP_TYPE"].ToString();
                }
                if (row["C_SCUTCHEON"] != null)
                {
                    model.C_SCUTCHEON = row["C_SCUTCHEON"].ToString();
                }
                if (row["N_STATUS"] != null && row["N_STATUS"].ToString() != "")
                {
                    model.N_STATUS = decimal.Parse(row["N_STATUS"].ToString());
                }
                if (row["C_REMARK"] != null)
                {
                    model.C_REMARK = row["C_REMARK"].ToString();
                }
                if (row["C_EMP_ID"] != null)
                {
                    model.C_EMP_ID = row["C_EMP_ID"].ToString();
                }
                if (row["D_MOD_DT"] != null && row["D_MOD_DT"].ToString() != "")
                {
                    model.D_MOD_DT = DateTime.Parse(row["D_MOD_DT"].ToString());
                }
                if (row["C_MASTER_ID"] != null)
                {
                    model.C_MASTER_ID = row["C_MASTER_ID"].ToString();
                }
                if (row["C_GP_BEFORE_ID"] != null)
                {
                    model.C_GP_BEFORE_ID = row["C_GP_BEFORE_ID"].ToString();
                }
                if (row["C_GP_AFTER_ID"] != null)
                {
                    model.C_GP_AFTER_ID = row["C_GP_AFTER_ID"].ToString();
                }
                if (row["C_ZYX1_BEFORE"] != null)
                {
                    model.C_ZYX1_BEFORE = row["C_ZYX1_BEFORE"].ToString();
                }
                if (row["C_ZYX2_BEFORE"] != null)
                {
                    model.C_ZYX2_BEFORE = row["C_ZYX2_BEFORE"].ToString();
                }
                if (row["C_ZYX1_AFTER"] != null)
                {
                    model.C_ZYX1_AFTER = row["C_ZYX1_AFTER"].ToString();
                }
                if (row["C_ZYX2_AFTER"] != null)
                {
                    model.C_ZYX2_AFTER = row["C_ZYX2_AFTER"].ToString();
                }
                if (row["C_JUDGE_LEV_BP_BEFORE"] != null)
                {
                    model.C_JUDGE_LEV_BP_BEFORE = row["C_JUDGE_LEV_BP_BEFORE"].ToString();
                }
                if (row["C_JUDGE_LEV_BP_AFTER"] != null)
                {
                    model.C_JUDGE_LEV_BP_AFTER = row["C_JUDGE_LEV_BP_AFTER"].ToString();
                }
                if (row["C_BZYQ_BEFORE"] != null)
                {
                    model.C_BZYQ_BEFORE = row["C_BZYQ_BEFORE"].ToString();
                }
                if (row["C_BZYQ_AFTER"] != null)
                {
                    model.C_BZYQ_AFTER = row["C_BZYQ_AFTER"].ToString();
                }
                if (row["C_COMMUTE_REASON"] != null)
                {
                    model.C_COMMUTE_REASON = row["C_COMMUTE_REASON"].ToString();
                }
            }
            return model;
        }
        /// <summary>
        /// 获得数据列表-条件查询
        /// </summary>
        /// <param name="begin">开始时间</param>
        /// <param name="end">结束时间</param>
        /// <param name="C_BATCH_NO">批号</param>
        /// <param name="strTime">时间条件</param>
        /// <param name="strGZ">钢种条件</param>
        /// <param name="strPDDJ">判定等级条件</param>
        /// <param name="stl_grd">钢种</param>
        /// <param name="pddj">判定等级</param>
        /// <returns></returns>
        public DataSet GetList_Query_Group(DateTime begin, DateTime end, string C_BATCH_NO, string strTime, string strGZ, string strPDDJ, string stl_grd, string pddj)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select (select max(t1.c_sta_desc) from tsc_slab_main t1 where t1.c_stove= t.c_stove )C_STA_DESC , max(t1.D_PRODUCE_DATE)SCSJ, max( t.C_ROLL_ID),count(t.c_id)cou,max(t.D_COMMUTE_DATE)pdsj,sum(t.N_WGT)wgt, t.C_STA_ID,t.C_STOVE,t.C_BATCH_NO,t.C_STL_GRD_BEFORE,t.C_STD_CODE_BEFORE,t.C_SPEC_BEFORE,t.C_MAT_CODE_BEFORE,t.C_MAT_DESC_BEFORE,t.C_STL_GRD_AFTER,t.C_STD_CODE_AFTER,t.C_SPEC_AFTER,t.C_MAT_CODE_AFTER,t.C_MAT_DESC_AFTER,t.C_REASON_DEPMT_ID,t.C_REASON_DEPMT_DESC,t.C_EMP_ID,t.C_REMARK,t.N_STATUS,t.C_SCUTCHEON,t.C_ZYX1_BEFORE,t.C_ZYX2_BEFORE,t.C_ZYX1_AFTER,t.C_ZYX2_AFTER,t.C_JUDGE_LEV_BP_AFTER,t.C_JUDGE_LEV_BP_BEFORE,t.C_BZYQ_BEFORE,t.C_BZYQ_AFTER,t.C_COMMUTE_REASON  FROM TQC_ROLL_COMMUTE t join trc_roll_prodcut t1 on t1.c_id=t.C_ROLL_ID WHERE N_STATUS=1 ");
            if (strTime.Trim() == "生产时间")
            {
                if (begin != null && end != null)
                {
                    strSql.Append(" and t1.D_PRODUCE_DATE between to_date('" + Convert.ToDateTime(begin) + "','yyyy-mm-dd hh24:mi:ss') and to_date('" + Convert.ToDateTime(end) + "','yyyy-mm-dd hh24:mi:ss') ");
                }
            }
            if (strTime.Trim() == "改判时间")
            {
                if (begin != null && end != null)
                {
                    strSql.Append(" and D_COMMUTE_DATE between to_date('" + Convert.ToDateTime(begin) + "','yyyy-mm-dd hh24:mi:ss') and to_date('" + Convert.ToDateTime(end) + "','yyyy-mm-dd hh24:mi:ss') ");
                }
            }
            if (strGZ.Trim() == "改判前钢种")
            {
                if (stl_grd.Trim() != "")
                {
                    strSql.Append(" and t.C_STL_GRD_BEFORE like '%" + stl_grd + "%' ");
                }
            }
            if (strGZ.Trim() == "改判后钢种")
            {
                if (stl_grd.Trim() != "")
                {
                    strSql.Append(" and t.C_STL_GRD_AFTER like '%" + stl_grd + "%' ");
                }
            }
            if (strPDDJ.Trim() == "改判前判定等级")
            {
                if (pddj.Trim() != "")
                {
                    strSql.Append(" and t.C_JUDGE_LEV_BP_BEFORE = '" + pddj + "' ");
                }
            }
            if (strPDDJ.Trim() == "改判后判定等级")
            {
                if (pddj.Trim() != "")
                {
                    strSql.Append(" and t.C_JUDGE_LEV_BP_AFTER = '" + pddj + "' ");
                }
            }
            if (strGZ.Trim() != "")
            {
                strSql.Append(" and t.C_BATCH_NO like '%" + C_BATCH_NO + "%' ");
            }
            strSql.Append(" group by  t.C_STA_ID,t.C_STOVE,t.C_BATCH_NO,t.C_STL_GRD_BEFORE,t.C_STD_CODE_BEFORE,t.C_SPEC_BEFORE,t.C_MAT_CODE_BEFORE,t.C_MAT_DESC_BEFORE,t.C_STL_GRD_AFTER,t.C_STD_CODE_AFTER,t.C_SPEC_AFTER,t.C_MAT_CODE_AFTER,t.C_MAT_DESC_AFTER,t.C_REASON_DEPMT_ID,t.C_REASON_DEPMT_DESC,t.C_EMP_ID,t.C_REMARK,t.N_STATUS,t.C_SCUTCHEON,t.C_ZYX1_BEFORE,t.C_ZYX2_BEFORE,t.C_ZYX1_AFTER,t.C_ZYX2_AFTER,t.C_JUDGE_LEV_BP_AFTER,t.C_JUDGE_LEV_BP_BEFORE,t.C_BZYQ_BEFORE,t.C_BZYQ_AFTER,t.C_COMMUTE_REASON  ");
            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 获得数据列表-条件查询
        /// </summary>
        /// <param name="begin">开始时间</param>
        /// <param name="end">结束时间</param>
        /// <param name="C_BATCH_NO">批号</param>
        /// <returns></returns>
		public DataSet GetList_Query(DateTime begin, DateTime end, string C_BATCH_NO)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_ROLL_ID,C_STA_ID,C_STA_DESC,C_STOVE,C_BATCH_NO,C_TICK_NO,N_WGT,C_STL_GRD_BEFORE,C_STD_CODE_BEFORE,C_SPEC_BEFORE,C_MAT_CODE_BEFORE,C_MAT_DESC_BEFORE,D_COMMUTE_DATE,C_STL_GRD_AFTER,C_STD_CODE_AFTER,C_SPEC_AFTER,C_MAT_CODE_AFTER,C_MAT_DESC_AFTER,C_REASON_DEPMT_ID,C_REASON_DEPMT_DESC,C_EMP_ID,C_REMARK,N_STATUS,C_SCUTCHEON,C_ZYX1_BEFORE,C_ZYX2_BEFORE,C_ZYX1_AFTER,C_ZYX2_AFTER,C_JUDGE_LEV_BP_AFTER,C_JUDGE_LEV_BP_BEFORE,C_BZYQ_BEFORE,C_BZYQ_AFTER,C_COMMUTE_REASON ");
            strSql.Append(" FROM TQC_ROLL_COMMUTE  WHERE N_STATUS=1 ");
            if (begin != null && end != null)
            {
                strSql.Append(" and D_COMMUTE_DATE between to_date('" + Convert.ToDateTime(begin) + "','yyyy-mm-dd hh24:mi:ss') and to_date('" + Convert.ToDateTime(end) + "','yyyy-mm-dd hh24:mi:ss') ");
            }
            if (C_BATCH_NO.Trim() != "")
            {
                strSql.Append(" and C_BATCH_NO like '%" + C_BATCH_NO + "%' ");
            }
            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 获得数据列表-条件查询
        /// </summary> 
        /// <param name="C_BATCH_NO">批号</param>
        /// <returns></returns>
		public DataSet GetList_Query_Cou( string C_BATCH_NO)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_ROLL_ID,C_STA_ID,C_STA_DESC,C_STOVE,C_BATCH_NO,C_TICK_NO,N_WGT,C_STL_GRD_BEFORE,C_STD_CODE_BEFORE,C_SPEC_BEFORE,C_MAT_CODE_BEFORE,C_MAT_DESC_BEFORE,D_COMMUTE_DATE,C_STL_GRD_AFTER,C_STD_CODE_AFTER,C_SPEC_AFTER,C_MAT_CODE_AFTER,C_MAT_DESC_AFTER,C_REASON_DEPMT_ID,C_REASON_DEPMT_DESC,C_EMP_ID,C_REMARK,N_STATUS,C_SCUTCHEON,C_ZYX1_BEFORE,C_ZYX2_BEFORE,C_ZYX1_AFTER,C_ZYX2_AFTER,C_JUDGE_LEV_BP_AFTER,C_JUDGE_LEV_BP_BEFORE,C_BZYQ_BEFORE,C_BZYQ_AFTER ");
            strSql.Append(" FROM TQC_ROLL_COMMUTE  WHERE N_STATUS=1 ");
            
            if (C_BATCH_NO.Trim() != "")
            {
                strSql.Append(" and C_BATCH_NO = '" + C_BATCH_NO + "' ");
            }
            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_ROLL_ID,C_STA_ID,C_STA_DESC,C_STOVE,C_BATCH_NO,C_TICK_NO,N_WGT,C_STL_GRD_BEFORE,C_STD_CODE_BEFORE,C_SPEC_BEFORE,C_MAT_CODE_BEFORE,C_MAT_DESC_BEFORE,D_COMMUTE_DATE,C_STL_GRD_AFTER,C_STD_CODE_AFTER,C_SPEC_AFTER,C_MAT_CODE_AFTER,C_MAT_DESC_AFTER,C_REASON_DEPMT_ID,C_REASON_DEPMT_DESC,C_EMP_ID,C_REMARK,N_STATUS,C_SCUTCHEON ,C_ZYX1_BEFORE,C_ZYX2_BEFORE,C_ZYX1_AFTER,C_ZYX2_AFTER,C_BZYQ_BEFORE,C_BZYQ_AFTER ");
            strSql.Append(" FROM TQC_ROLL_COMMUTE ");
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
            strSql.Append("select count(1) FROM TQC_ROLL_COMMUTE ");
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
            strSql.Append(")AS Row, T.*  from TQC_ROLL_COMMUTE T ");
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
			parameters[0].Value = "TQC_ROLL_COMMUTE";
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
        /// 获得数据列表
        /// </summary>
        /// <param name="c_master_id">实绩主键</param>
        /// <param name="c_gp_before_id">改判前主键</param>
        /// <param name="c_gp_after_id">改判后主键</param>
        /// <returns></returns>
        public DataSet GetList_Interface_Trans(string c_master_id, string c_gp_before_id, string c_gp_after_id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(C_ID)cou,C_STA_ID,C_STOVE,C_BATCH_NO,sum(N_WGT) wgt,C_STL_GRD_BEFORE,C_STD_CODE_BEFORE,C_SPEC_BEFORE,C_MAT_CODE_BEFORE,C_MAT_DESC_BEFORE,C_STL_GRD_AFTER,C_STD_CODE_AFTER,C_SPEC_AFTER,C_MAT_CODE_AFTER,C_MAT_DESC_AFTER,C_REASON_DEPMT_ID,C_REASON_DEPMT_DESC,C_REMARK,N_STATUS,C_SCUTCHEON ,c_master_id,c_gp_before_id,c_gp_after_id,C_BZYQ_BEFORE,C_BZYQ_AFTER  ");
            strSql.Append(" FROM TQC_ROLL_COMMUTE    where c_master_id='" + c_master_id + "' and   c_gp_before_id='" + c_gp_before_id + "' and    c_gp_after_id='" + c_gp_after_id + "'  ");
            strSql.Append(" group by  C_STA_ID,C_STOVE,C_BATCH_NO,C_STL_GRD_BEFORE,C_STD_CODE_BEFORE,C_SPEC_BEFORE,C_MAT_CODE_BEFORE,C_MAT_DESC_BEFORE,C_STL_GRD_AFTER,C_STD_CODE_AFTER,C_SPEC_AFTER,C_MAT_CODE_AFTER,C_MAT_DESC_AFTER,C_REASON_DEPMT_ID,C_REASON_DEPMT_DESC,C_REMARK,N_STATUS,C_SCUTCHEON ,c_master_id,c_gp_before_id,c_gp_after_id,C_BZYQ_BEFORE,C_BZYQ_AFTER");
            return TransactionHelper.Query(strSql.ToString());
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList_max()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  max(（substr(C_MASTER_ID,3))) as C_MASTER_ID,max(（substr(C_GP_BEFORE_ID,3))) as C_GP_BEFORE_ID,max(（substr(C_GP_AFTER_ID,3))) as C_GP_AFTER_ID");
            strSql.Append(" FROM TRC_ROLL_PRODCUT where C_GP_AFTER_ID like '%'||to_char(sysdate,'yymmdd')||'%'");


            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList_max_Trans()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  max(（substr(C_GP_AFTER_ID,3))) as C_GP_AFTER_ID");
            strSql.Append(" FROM TRC_ROLL_PRODCUT where C_GP_AFTER_ID like '%'||to_char(sysdate,'yymmdd')||'%'");


            return TransactionHelper.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList_max_MasterID_Trans()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  max(（substr(C_MASTER_ID,3))) as C_MASTER_ID,max(（substr(C_GP_BEFORE_ID,3))) as C_GP_BEFORE_ID ");
            strSql.Append(" FROM TRC_ROLL_PRODCUT where C_MASTER_ID like '%'||to_char(sysdate,'yymmdd')||'%'");


            return TransactionHelper.Query(strSql.ToString());
        }

        #endregion  ExtensionMethod
    }
}

