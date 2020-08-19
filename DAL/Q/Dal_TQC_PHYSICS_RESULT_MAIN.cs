using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;
using System.Collections;

namespace DAL
{
    /// <summary>
    /// 数据访问类:TQC_PHYSICS_RESULT_MAIN
    /// </summary>
    public partial class Dal_TQC_PHYSICS_RESULT_MAIN
    {
        public Dal_TQC_PHYSICS_RESULT_MAIN()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string C_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TQC_PHYSICS_RESULT_MAIN");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)         };
            parameters[0].Value = C_ID;

            return DbHelperOra.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Mod_TQC_PHYSICS_RESULT_MAIN model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TQC_PHYSICS_RESULT_MAIN(");
            strSql.Append("C_BATCH_NO,C_TICK_NO,C_STL_GRD,C_SPEC,N_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT,C_EMP_ID_ZY,D_MOD_DT_ZY,C_EMP_ID_JS,D_MOD_DT_JS,C_EQ_NAME,N_IS_LR,D_TRANST,C_PHYSICS_GROUP_ID,C_CHECK_STATE,C_PRESENT_SAMPLES_ID,C_IS_PD,C_TEMP,C_HUMIDITY,N_RECHECK,C_BC,C_BZ,C_CHECK_USER)");
            strSql.Append(" values (");
            strSql.Append(":C_BATCH_NO,:C_TICK_NO,:C_STL_GRD,:C_SPEC,:N_STATUS,:C_REMARK,:C_EMP_ID,:D_MOD_DT,:C_EMP_ID_ZY,:D_MOD_DT_ZY,:C_EMP_ID_JS,:D_MOD_DT_JS,:C_EQ_NAME,:N_IS_LR,:D_TRANST,:C_PHYSICS_GROUP_ID,:C_CHECK_STATE,:C_PRESENT_SAMPLES_ID,:C_IS_PD,:C_TEMP,:C_HUMIDITY,:N_RECHECK,:C_BC,:C_BZ,:C_CHECK_USER)");
            OracleParameter[] parameters = {
                     new OracleParameter(":C_BATCH_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_TICK_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STL_GRD", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SPEC", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":C_EMP_ID_ZY", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT_ZY", OracleDbType.Date),
                    new OracleParameter(":C_EMP_ID_JS", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT_JS", OracleDbType.Date),
                    new OracleParameter(":C_EQ_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_IS_LR", OracleDbType.Decimal,5),
                    new OracleParameter(":D_TRANST", OracleDbType.Date),
                    new OracleParameter(":C_PHYSICS_GROUP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CHECK_STATE", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_PRESENT_SAMPLES_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_IS_PD", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_TEMP", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_HUMIDITY", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_RECHECK", OracleDbType.Decimal,2),
                    new OracleParameter(":C_BC", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_BZ", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_CHECK_USER", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.C_BATCH_NO;
            parameters[1].Value = model.C_TICK_NO;
            parameters[2].Value = model.C_STL_GRD;
            parameters[3].Value = model.C_SPEC;
            parameters[4].Value = model.N_STATUS;
            parameters[5].Value = model.C_REMARK;
            parameters[6].Value = model.C_EMP_ID;
            parameters[7].Value = model.D_MOD_DT;
            parameters[8].Value = model.C_EMP_ID_ZY;
            parameters[9].Value = model.D_MOD_DT_ZY;
            parameters[10].Value = model.C_EMP_ID_JS;
            parameters[11].Value = model.D_MOD_DT_JS;
            parameters[12].Value = model.C_EQ_NAME;
            parameters[13].Value = model.N_IS_LR;
            parameters[14].Value = model.D_TRANST;
            parameters[15].Value = model.C_PHYSICS_GROUP_ID;
            parameters[16].Value = model.C_CHECK_STATE;
            parameters[17].Value = model.C_PRESENT_SAMPLES_ID;
            parameters[18].Value = model.C_IS_PD;
            parameters[19].Value = model.C_TEMP;
            parameters[20].Value = model.C_HUMIDITY;
            parameters[21].Value = model.N_RECHECK;
            parameters[22].Value = model.C_BC;
            parameters[23].Value = model.C_BZ;
            parameters[24].Value = model.C_CHECK_USER;

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
		public bool Add_Trans(Mod_TQC_PHYSICS_RESULT_MAIN model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TQC_PHYSICS_RESULT_MAIN(");
            strSql.Append("C_BATCH_NO,C_TICK_NO,C_STL_GRD,C_SPEC,N_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT,C_EMP_ID_ZY,D_MOD_DT_ZY,C_EMP_ID_JS,D_MOD_DT_JS,C_EQ_NAME,N_IS_LR,D_TRANST,C_PHYSICS_GROUP_ID,C_CHECK_STATE,C_PRESENT_SAMPLES_ID,C_IS_PD,C_TEMP,C_HUMIDITY,N_RECHECK,C_BC,C_BZ,C_CHECK_USER)");
            strSql.Append(" values (");
            strSql.Append(":C_BATCH_NO,:C_TICK_NO,:C_STL_GRD,:C_SPEC,:N_STATUS,:C_REMARK,:C_EMP_ID,:D_MOD_DT,:C_EMP_ID_ZY,:D_MOD_DT_ZY,:C_EMP_ID_JS,:D_MOD_DT_JS,:C_EQ_NAME,:N_IS_LR,:D_TRANST,:C_PHYSICS_GROUP_ID,:C_CHECK_STATE,:C_PRESENT_SAMPLES_ID,:C_IS_PD,:C_TEMP,:C_HUMIDITY,:N_RECHECK,:C_BC,:C_BZ,:C_CHECK_USER)");
            OracleParameter[] parameters = {
                     new OracleParameter(":C_BATCH_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_TICK_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STL_GRD", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SPEC", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":C_EMP_ID_ZY", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT_ZY", OracleDbType.Date),
                    new OracleParameter(":C_EMP_ID_JS", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT_JS", OracleDbType.Date),
                    new OracleParameter(":C_EQ_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_IS_LR", OracleDbType.Decimal,5),
                    new OracleParameter(":D_TRANST", OracleDbType.Date),
                    new OracleParameter(":C_PHYSICS_GROUP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CHECK_STATE", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_PRESENT_SAMPLES_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_IS_PD", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_TEMP", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_HUMIDITY", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_RECHECK", OracleDbType.Decimal,2),
                    new OracleParameter(":C_BC", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_BZ", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_CHECK_USER", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.C_BATCH_NO;
            parameters[1].Value = model.C_TICK_NO;
            parameters[2].Value = model.C_STL_GRD;
            parameters[3].Value = model.C_SPEC;
            parameters[4].Value = model.N_STATUS;
            parameters[5].Value = model.C_REMARK;
            parameters[6].Value = model.C_EMP_ID;
            parameters[7].Value = model.D_MOD_DT;
            parameters[8].Value = model.C_EMP_ID_ZY;
            parameters[9].Value = model.D_MOD_DT_ZY;
            parameters[10].Value = model.C_EMP_ID_JS;
            parameters[11].Value = model.D_MOD_DT_JS;
            parameters[12].Value = model.C_EQ_NAME;
            parameters[13].Value = model.N_IS_LR;
            parameters[14].Value = model.D_TRANST;
            parameters[15].Value = model.C_PHYSICS_GROUP_ID;
            parameters[16].Value = model.C_CHECK_STATE;
            parameters[17].Value = model.C_PRESENT_SAMPLES_ID;
            parameters[18].Value = model.C_IS_PD;
            parameters[19].Value = model.C_TEMP;
            parameters[20].Value = model.C_HUMIDITY;
            parameters[21].Value = model.N_RECHECK;
            parameters[22].Value = model.C_BC;
            parameters[23].Value = model.C_BZ;
            parameters[24].Value = model.C_CHECK_USER;

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
        public bool Update(Mod_TQC_PHYSICS_RESULT_MAIN model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TQC_PHYSICS_RESULT_MAIN set ");
            strSql.Append("C_BATCH_NO=:C_BATCH_NO,");
            strSql.Append("C_TICK_NO=:C_TICK_NO,");
            strSql.Append("C_STL_GRD=:C_STL_GRD,");
            strSql.Append("C_SPEC=:C_SPEC,");
            strSql.Append("N_STATUS=:N_STATUS,");
            strSql.Append("C_REMARK=:C_REMARK,");
            strSql.Append("C_EMP_ID=:C_EMP_ID,");
            strSql.Append("D_MOD_DT=:D_MOD_DT,");
            strSql.Append("C_EMP_ID_ZY=:C_EMP_ID_ZY,");
            strSql.Append("D_MOD_DT_ZY=:D_MOD_DT_ZY,");
            strSql.Append("C_EMP_ID_JS=:C_EMP_ID_JS,");
            strSql.Append("D_MOD_DT_JS=:D_MOD_DT_JS,");
            strSql.Append("C_EQ_NAME=:C_EQ_NAME,");
            strSql.Append("N_IS_LR=:N_IS_LR,");
            strSql.Append("D_TRANST=:D_TRANST,");
            strSql.Append("C_PHYSICS_GROUP_ID=:C_PHYSICS_GROUP_ID,");
            strSql.Append("C_CHECK_STATE=:C_CHECK_STATE,");
            strSql.Append("C_PRESENT_SAMPLES_ID=:C_PRESENT_SAMPLES_ID,");
            strSql.Append("C_IS_PD=:C_IS_PD,");
            strSql.Append("C_TEMP=:C_TEMP,");
            strSql.Append("C_HUMIDITY=:C_HUMIDITY,");
            strSql.Append("N_RECHECK=:N_RECHECK,");
            strSql.Append("C_BC=:C_BC,");
            strSql.Append("C_BZ=:C_BZ,");
            strSql.Append("C_CHECK_USER=:C_CHECK_USER");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_BATCH_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_TICK_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STL_GRD", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SPEC", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":C_EMP_ID_ZY", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT_ZY", OracleDbType.Date),
                    new OracleParameter(":C_EMP_ID_JS", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT_JS", OracleDbType.Date),
                    new OracleParameter(":C_EQ_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_IS_LR", OracleDbType.Decimal,5),
                    new OracleParameter(":D_TRANST", OracleDbType.Date),
                    new OracleParameter(":C_PHYSICS_GROUP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CHECK_STATE", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_PRESENT_SAMPLES_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_IS_PD", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_TEMP", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_HUMIDITY", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_RECHECK", OracleDbType.Decimal,2),
                    new OracleParameter(":C_BC", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_BZ", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_CHECK_USER", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)
                    };
            parameters[0].Value = model.C_BATCH_NO;
            parameters[1].Value = model.C_TICK_NO;
            parameters[2].Value = model.C_STL_GRD;
            parameters[3].Value = model.C_SPEC;
            parameters[4].Value = model.N_STATUS;
            parameters[5].Value = model.C_REMARK;
            parameters[6].Value = model.C_EMP_ID;
            parameters[7].Value = model.D_MOD_DT;
            parameters[8].Value = model.C_EMP_ID_ZY;
            parameters[9].Value = model.D_MOD_DT_ZY;
            parameters[10].Value = model.C_EMP_ID_JS;
            parameters[11].Value = model.D_MOD_DT_JS;
            parameters[12].Value = model.C_EQ_NAME;
            parameters[13].Value = model.N_IS_LR;
            parameters[14].Value = model.D_TRANST;
            parameters[15].Value = model.C_PHYSICS_GROUP_ID;
            parameters[16].Value = model.C_CHECK_STATE;
            parameters[17].Value = model.C_PRESENT_SAMPLES_ID;
            parameters[18].Value = model.C_IS_PD;
            parameters[19].Value = model.C_TEMP;
            parameters[20].Value = model.C_HUMIDITY;
            parameters[21].Value = model.N_RECHECK;
            parameters[22].Value = model.C_BC;
            parameters[23].Value = model.C_BZ;
            parameters[24].Value = model.C_CHECK_USER;
            parameters[25].Value = model.C_ID;


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
        public bool Update_Trans(Mod_TQC_PHYSICS_RESULT_MAIN model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TQC_PHYSICS_RESULT_MAIN set ");
            strSql.Append("C_BATCH_NO=:C_BATCH_NO,");
            strSql.Append("C_TICK_NO=:C_TICK_NO,");
            strSql.Append("C_STL_GRD=:C_STL_GRD,");
            strSql.Append("C_SPEC=:C_SPEC,");
            strSql.Append("N_STATUS=:N_STATUS,");
            strSql.Append("C_REMARK=:C_REMARK,");
            strSql.Append("C_EMP_ID=:C_EMP_ID,");
            strSql.Append("D_MOD_DT=:D_MOD_DT,");
            strSql.Append("C_EMP_ID_ZY=:C_EMP_ID_ZY,");
            strSql.Append("D_MOD_DT_ZY=:D_MOD_DT_ZY,");
            strSql.Append("C_EMP_ID_JS=:C_EMP_ID_JS,");
            strSql.Append("D_MOD_DT_JS=:D_MOD_DT_JS,");
            strSql.Append("C_EQ_NAME=:C_EQ_NAME,");
            strSql.Append("N_IS_LR=:N_IS_LR,");
            strSql.Append("D_TRANST=:D_TRANST,");
            strSql.Append("C_PHYSICS_GROUP_ID=:C_PHYSICS_GROUP_ID,");
            strSql.Append("C_CHECK_STATE=:C_CHECK_STATE,");
            strSql.Append("C_PRESENT_SAMPLES_ID=:C_PRESENT_SAMPLES_ID,");
            strSql.Append("C_IS_PD=:C_IS_PD,");
            strSql.Append("C_TEMP=:C_TEMP,");
            strSql.Append("C_HUMIDITY=:C_HUMIDITY,");
            strSql.Append("N_RECHECK=:N_RECHECK,");
            strSql.Append("C_BC=:C_BC,");
            strSql.Append("C_BZ=:C_BZ,");
            strSql.Append("C_CHECK_USER=:C_CHECK_USER");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_BATCH_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_TICK_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STL_GRD", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SPEC", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":C_EMP_ID_ZY", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT_ZY", OracleDbType.Date),
                    new OracleParameter(":C_EMP_ID_JS", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT_JS", OracleDbType.Date),
                    new OracleParameter(":C_EQ_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_IS_LR", OracleDbType.Decimal,5),
                    new OracleParameter(":D_TRANST", OracleDbType.Date),
                    new OracleParameter(":C_PHYSICS_GROUP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CHECK_STATE", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_PRESENT_SAMPLES_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_IS_PD", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_TEMP", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_HUMIDITY", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_RECHECK", OracleDbType.Decimal,2),
                    new OracleParameter(":C_BC", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_BZ", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_CHECK_USER", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)
                    };
            parameters[0].Value = model.C_BATCH_NO;
            parameters[1].Value = model.C_TICK_NO;
            parameters[2].Value = model.C_STL_GRD;
            parameters[3].Value = model.C_SPEC;
            parameters[4].Value = model.N_STATUS;
            parameters[5].Value = model.C_REMARK;
            parameters[6].Value = model.C_EMP_ID;
            parameters[7].Value = model.D_MOD_DT;
            parameters[8].Value = model.C_EMP_ID_ZY;
            parameters[9].Value = model.D_MOD_DT_ZY;
            parameters[10].Value = model.C_EMP_ID_JS;
            parameters[11].Value = model.D_MOD_DT_JS;
            parameters[12].Value = model.C_EQ_NAME;
            parameters[13].Value = model.N_IS_LR;
            parameters[14].Value = model.D_TRANST;
            parameters[15].Value = model.C_PHYSICS_GROUP_ID;
            parameters[16].Value = model.C_CHECK_STATE;
            parameters[17].Value = model.C_PRESENT_SAMPLES_ID;
            parameters[18].Value = model.C_IS_PD;
            parameters[19].Value = model.C_TEMP;
            parameters[20].Value = model.C_HUMIDITY;
            parameters[21].Value = model.N_RECHECK;
            parameters[22].Value = model.C_BC;
            parameters[23].Value = model.C_BZ;
            parameters[24].Value = model.C_CHECK_USER;
            parameters[25].Value = model.C_ID;

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
        /// 删除一条数据
        /// </summary>
        public bool Delete(string C_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from TQC_PHYSICS_RESULT_MAIN ");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)         };
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
        /// 删除一条数据
        /// </summary>
        public bool Delete_Trans(string C_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from TQC_PHYSICS_RESULT_MAIN ");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)         };
            parameters[0].Value = C_ID;

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
        /// 批量删除数据
        /// </summary>
        public bool DeleteList(string C_IDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from TQC_PHYSICS_RESULT_MAIN ");
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
        public Mod_TQC_PHYSICS_RESULT_MAIN GetModel(string C_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_BATCH_NO,C_TICK_NO,C_STL_GRD,C_SPEC,N_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT,C_EMP_ID_ZY,D_MOD_DT_ZY,C_EMP_ID_JS,D_MOD_DT_JS,C_EQ_NAME,N_IS_LR,D_TRANST,C_PHYSICS_GROUP_ID,C_CHECK_STATE,C_PRESENT_SAMPLES_ID,C_IS_PD,C_TEMP,C_HUMIDITY,N_RECHECK,C_BC,C_BZ,C_CHECK_USER from TQC_PHYSICS_RESULT_MAIN ");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)         };
            parameters[0].Value = C_ID;

            Mod_TQC_PHYSICS_RESULT_MAIN model = new Mod_TQC_PHYSICS_RESULT_MAIN();
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
        public Mod_TQC_PHYSICS_RESULT_MAIN GetModel_Main(string C_PRESENT_SAMPLES_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_BATCH_NO,C_TICK_NO,C_STL_GRD,C_SPEC,N_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT,C_EMP_ID_ZY,D_MOD_DT_ZY,C_EMP_ID_JS,D_MOD_DT_JS,C_EQ_NAME,N_IS_LR,D_TRANST,C_PHYSICS_GROUP_ID,C_CHECK_STATE,C_PRESENT_SAMPLES_ID,C_IS_PD,C_TEMP,C_HUMIDITY,N_RECHECK,C_BC,C_BZ,C_CHECK_USER from TQC_PHYSICS_RESULT_MAIN ");
            strSql.Append(" where C_PRESENT_SAMPLES_ID='" + C_PRESENT_SAMPLES_ID + "'  and c_physics_group_id in (select tb.c_id from tqb_physics_group tb where tb.c_check_depmt='技术中心')");

            Mod_TQC_PHYSICS_RESULT_MAIN model = new Mod_TQC_PHYSICS_RESULT_MAIN();
            DataSet ds = DbHelperOra.Query(strSql.ToString());
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
        public Mod_TQC_PHYSICS_RESULT_MAIN DataRowToModel(DataRow row)
        {
            Mod_TQC_PHYSICS_RESULT_MAIN model = new Mod_TQC_PHYSICS_RESULT_MAIN();
            if (row != null)
            {
                if (row["C_ID"] != null)
                {
                    model.C_ID = row["C_ID"].ToString();
                }
                if (row["C_BATCH_NO"] != null)
                {
                    model.C_BATCH_NO = row["C_BATCH_NO"].ToString();
                }
                if (row["C_TICK_NO"] != null)
                {
                    model.C_TICK_NO = row["C_TICK_NO"].ToString();
                }
                if (row["C_STL_GRD"] != null)
                {
                    model.C_STL_GRD = row["C_STL_GRD"].ToString();
                }
                if (row["C_SPEC"] != null)
                {
                    model.C_SPEC = row["C_SPEC"].ToString();
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
                if (row["C_EMP_ID_ZY"] != null)
                {
                    model.C_EMP_ID_ZY = row["C_EMP_ID_ZY"].ToString();
                }
                if (row["D_MOD_DT_ZY"] != null && row["D_MOD_DT_ZY"].ToString() != "")
                {
                    model.D_MOD_DT_ZY = DateTime.Parse(row["D_MOD_DT_ZY"].ToString());
                }
                if (row["C_EMP_ID_JS"] != null)
                {
                    model.C_EMP_ID_JS = row["C_EMP_ID_JS"].ToString();
                }
                if (row["D_MOD_DT_JS"] != null && row["D_MOD_DT_JS"].ToString() != "")
                {
                    model.D_MOD_DT_JS = DateTime.Parse(row["D_MOD_DT_JS"].ToString());
                }
                if (row["C_EQ_NAME"] != null)
                {
                    model.C_EQ_NAME = row["C_EQ_NAME"].ToString();
                }
                if (row["N_IS_LR"] != null && row["N_IS_LR"].ToString() != "")
                {
                    model.N_IS_LR = decimal.Parse(row["N_IS_LR"].ToString());
                }
                if (row["D_TRANST"] != null && row["D_TRANST"].ToString() != "")
                {
                    model.D_TRANST = DateTime.Parse(row["D_TRANST"].ToString());
                }
                if (row["C_PHYSICS_GROUP_ID"] != null)
                {
                    model.C_PHYSICS_GROUP_ID = row["C_PHYSICS_GROUP_ID"].ToString();
                }
                if (row["C_CHECK_STATE"] != null)
                {
                    model.C_CHECK_STATE = row["C_CHECK_STATE"].ToString();
                }
                if (row["C_PRESENT_SAMPLES_ID"] != null)
                {
                    model.C_PRESENT_SAMPLES_ID = row["C_PRESENT_SAMPLES_ID"].ToString();
                }
                if (row["C_IS_PD"] != null)
                {
                    model.C_IS_PD = row["C_IS_PD"].ToString();
                }
                if (row["C_TEMP"] != null)
                {
                    model.C_TEMP = row["C_TEMP"].ToString();
                }
                if (row["C_HUMIDITY"] != null)
                {
                    model.C_HUMIDITY = row["C_HUMIDITY"].ToString();
                }
                if (row["N_RECHECK"] != null && row["N_RECHECK"].ToString() != "")
                {
                    model.N_RECHECK = decimal.Parse(row["N_RECHECK"].ToString());
                }
                if (row["C_BC"] != null)
                {
                    model.C_BC = row["C_BC"].ToString();
                }
                if (row["C_BZ"] != null)
                {
                    model.C_BZ = row["C_BZ"].ToString();
                }
                if (row["C_CHECK_USER"] != null)
                {
                    model.C_CHECK_USER = row["C_CHECK_USER"].ToString();
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
            strSql.Append("select C_ID,C_BATCH_NO,C_TICK_NO,C_STL_GRD,C_SPEC,N_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT,C_EMP_ID_ZY,D_MOD_DT_ZY,C_EMP_ID_JS,D_MOD_DT_JS,C_EQ_NAME,N_IS_LR,D_TRANST,C_PHYSICS_GROUP_ID,C_CHECK_STATE,C_PRESENT_SAMPLES_ID,C_IS_PD,C_TEMP,C_HUMIDITY,N_RECHECK,C_BC,C_BZ,C_CHECK_USER ");
            strSql.Append(" FROM TQC_PHYSICS_RESULT_MAIN ");
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
            strSql.Append("select count(1) FROM TQC_PHYSICS_RESULT_MAIN ");
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
            strSql.Append(")AS Row, T.*  from TQC_PHYSICS_RESULT_MAIN T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            return DbHelperOra.Query(strSql.ToString());
        }


        /// <summary>
        /// 检测是否已录入性能结果
        /// </summary>
        /// <param name="c_present_samples_id">取样主表主键（tqc_present_samples）</param>
        /// <param name="strState">是否已录入性能结果；0-未录入；1-已录入；</param>
        /// <returns></returns>
        public int Get_Count(string c_present_samples_id, string n_is_lr)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM TQC_PHYSICS_RESULT_MAIN ta");

            strSql.Append(" WHERE ta.c_present_samples_id='" + c_present_samples_id + "' and ta.n_is_lr ='" + n_is_lr + "' ");

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
        /// 检测是否有数据
        /// </summary>
        /// <returns></returns>
        public int Get_Count(string c_batch_no)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM TQC_PHYSICS_RESULT_MAIN ta where ta.c_batch_no='" + c_batch_no + "' ");

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
        /// 更新一条数据
        /// </summary>
        public bool Update_PD_Trans(string c_batch_no)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update tqc_physics_result_main t set t.c_is_pd='1' where t.c_batch_no='" + c_batch_no + "' ");

            int rows = TransactionHelper.ExecuteSql(strSql.ToString());
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
        /// 获得数据列表
        /// </summary>
        public DataSet Get_DB_List(string c_batch_no, string c_physics_group_id, string c_check_state, string c_is_pd)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select t.*,t.rowid from tqc_physics_result_main t where t.c_batch_no='" + c_batch_no + "' and t.c_physics_group_id='" + c_physics_group_id + "' and t.c_check_state='" + c_check_state + "' and t.c_is_pd='" + c_is_pd + "' ");

            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet Get_DB_List(string C_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select t.*,t.rowid from tqc_physics_result_main t where t.C_ID='" + C_ID + "' ");

            return DbHelperOra.Query(strSql.ToString());
        }

        #endregion  BasicMethod
        #region  ExtensionMethod

        #endregion  ExtensionMethod
    }
}

