using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;
namespace DAL
{
    /// <summary>
    /// 数据访问类:TQC_COMPRE_ROLL
    /// </summary>
    public partial class Dal_TQC_COMPRE_ROLL
    {
        public Dal_TQC_COMPRE_ROLL()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string C_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TQC_COMPRE_ROLL");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)         };
            parameters[0].Value = C_ID;

            return DbHelperOra.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Mod_TQC_COMPRE_ROLL model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TQC_COMPRE_ROLL(");
            strSql.Append("C_ID,C_STOVE,C_BATCH_NO,C_STL_GRD,N_WGT,N_QUA,C_STD_CODE,C_SPEC,C_MAT_CODE,C_MAT_NAME,C_SHIFT,C_GROUP,C_RESULT_FACE,C_REASON_NAME,C_REASON_CODE,D_DP_DT,C_RESULT_ELE,C_RESULT_PHY,C_RESULT_ALL,D_RESALL_DT,C_RESULT_PEOPLE,D_RESPEO_DT,C_QR_STATE,C_EMP_ID,D_MOD_DT,C_RESULT_PHYSEC,C_RESULT_PHYFINAL,C_DESIGN_NO,N_STATUS,C_REMARK,C_KP_NO,C_PCINFO)");
            strSql.Append(" values (");
            strSql.Append(":C_ID,:C_STOVE,:C_BATCH_NO,:C_STL_GRD,:N_WGT,:N_QUA,:C_STD_CODE,:C_SPEC,:C_MAT_CODE,:C_MAT_NAME,:C_SHIFT,:C_GROUP,:C_RESULT_FACE,:C_REASON_NAME,:C_REASON_CODE,:D_DP_DT,:C_RESULT_ELE,:C_RESULT_PHY,:C_RESULT_ALL,:D_RESALL_DT,:C_RESULT_PEOPLE,:D_RESPEO_DT,:C_QR_STATE,:C_EMP_ID,:D_MOD_DT,:C_RESULT_PHYSEC,:C_RESULT_PHYFINAL,:C_DESIGN_NO,:N_STATUS,:C_REMARK,:C_KP_NO,:C_PCINFO)");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STOVE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_BATCH_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STL_GRD", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":N_QUA", OracleDbType.Decimal,10),
                    new OracleParameter(":C_STD_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SPEC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MAT_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MAT_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SHIFT", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_GROUP", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_RESULT_FACE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_REASON_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_REASON_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_DP_DT", OracleDbType.Date),
                    new OracleParameter(":C_RESULT_ELE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_RESULT_PHY", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_RESULT_ALL", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_RESALL_DT", OracleDbType.Date),
                    new OracleParameter(":C_RESULT_PEOPLE", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_RESPEO_DT", OracleDbType.Date),
                    new OracleParameter(":C_QR_STATE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":C_RESULT_PHYSEC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_RESULT_PHYFINAL", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_DESIGN_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_KP_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PCINFO", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.C_ID;
            parameters[1].Value = model.C_STOVE;
            parameters[2].Value = model.C_BATCH_NO;
            parameters[3].Value = model.C_STL_GRD;
            parameters[4].Value = model.N_WGT;
            parameters[5].Value = model.N_QUA;
            parameters[6].Value = model.C_STD_CODE;
            parameters[7].Value = model.C_SPEC;
            parameters[8].Value = model.C_MAT_CODE;
            parameters[9].Value = model.C_MAT_NAME;
            parameters[10].Value = model.C_SHIFT;
            parameters[11].Value = model.C_GROUP;
            parameters[12].Value = model.C_RESULT_FACE;
            parameters[13].Value = model.C_REASON_NAME;
            parameters[14].Value = model.C_REASON_CODE;
            parameters[15].Value = model.D_DP_DT;
            parameters[16].Value = model.C_RESULT_ELE;
            parameters[17].Value = model.C_RESULT_PHY;
            parameters[18].Value = model.C_RESULT_ALL;
            parameters[19].Value = model.D_RESALL_DT;
            parameters[20].Value = model.C_RESULT_PEOPLE;
            parameters[21].Value = model.D_RESPEO_DT;
            parameters[22].Value = model.C_QR_STATE;
            parameters[23].Value = model.C_EMP_ID;
            parameters[24].Value = model.D_MOD_DT;
            parameters[25].Value = model.C_RESULT_PHYSEC;
            parameters[26].Value = model.C_RESULT_PHYFINAL;
            parameters[27].Value = model.C_DESIGN_NO;
            parameters[28].Value = model.N_STATUS;
            parameters[29].Value = model.C_REMARK;
            parameters[30].Value = model.C_KP_NO;
            parameters[31].Value = model.C_PCINFO;

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
        public bool Update(Mod_TQC_COMPRE_ROLL model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TQC_COMPRE_ROLL set ");
            strSql.Append("C_STOVE=:C_STOVE,");
            strSql.Append("C_BATCH_NO=:C_BATCH_NO,");
            strSql.Append("C_STL_GRD=:C_STL_GRD,");
            strSql.Append("N_WGT=:N_WGT,");
            strSql.Append("N_QUA=:N_QUA,");
            strSql.Append("C_STD_CODE=:C_STD_CODE,");
            strSql.Append("C_SPEC=:C_SPEC,");
            strSql.Append("C_MAT_CODE=:C_MAT_CODE,");
            strSql.Append("C_MAT_NAME=:C_MAT_NAME,");
            strSql.Append("C_SHIFT=:C_SHIFT,");
            strSql.Append("C_GROUP=:C_GROUP,");
            strSql.Append("C_RESULT_FACE=:C_RESULT_FACE,");
            strSql.Append("C_REASON_NAME=:C_REASON_NAME,");
            strSql.Append("C_REASON_CODE=:C_REASON_CODE,");
            strSql.Append("D_DP_DT=:D_DP_DT,");
            strSql.Append("C_RESULT_ELE=:C_RESULT_ELE,");
            strSql.Append("C_RESULT_PHY=:C_RESULT_PHY,");
            strSql.Append("C_RESULT_ALL=:C_RESULT_ALL,");
            strSql.Append("D_RESALL_DT=:D_RESALL_DT,");
            strSql.Append("C_RESULT_PEOPLE=:C_RESULT_PEOPLE,");
            strSql.Append("D_RESPEO_DT=:D_RESPEO_DT,");
            strSql.Append("C_QR_STATE=:C_QR_STATE,");
            strSql.Append("C_EMP_ID=:C_EMP_ID,");
            strSql.Append("D_MOD_DT=:D_MOD_DT,");
            strSql.Append("C_RESULT_PHYSEC=:C_RESULT_PHYSEC,");
            strSql.Append("C_RESULT_PHYFINAL=:C_RESULT_PHYFINAL,");
            strSql.Append("C_DESIGN_NO=:C_DESIGN_NO,");
            strSql.Append("N_STATUS=:N_STATUS,");
            strSql.Append("C_REMARK=:C_REMARK,");
            strSql.Append("C_KP_NO=:C_KP_NO,");
            strSql.Append("C_PCINFO=:C_PCINFO");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_STOVE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_BATCH_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STL_GRD", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":N_QUA", OracleDbType.Decimal,10),
                    new OracleParameter(":C_STD_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SPEC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MAT_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MAT_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SHIFT", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_GROUP", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_RESULT_FACE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_REASON_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_REASON_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_DP_DT", OracleDbType.Date),
                    new OracleParameter(":C_RESULT_ELE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_RESULT_PHY", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_RESULT_ALL", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_RESALL_DT", OracleDbType.Date),
                    new OracleParameter(":C_RESULT_PEOPLE", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_RESPEO_DT", OracleDbType.Date),
                    new OracleParameter(":C_QR_STATE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":C_RESULT_PHYSEC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_RESULT_PHYFINAL", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_DESIGN_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_KP_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PCINFO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.C_STOVE;
            parameters[1].Value = model.C_BATCH_NO;
            parameters[2].Value = model.C_STL_GRD;
            parameters[3].Value = model.N_WGT;
            parameters[4].Value = model.N_QUA;
            parameters[5].Value = model.C_STD_CODE;
            parameters[6].Value = model.C_SPEC;
            parameters[7].Value = model.C_MAT_CODE;
            parameters[8].Value = model.C_MAT_NAME;
            parameters[9].Value = model.C_SHIFT;
            parameters[10].Value = model.C_GROUP;
            parameters[11].Value = model.C_RESULT_FACE;
            parameters[12].Value = model.C_REASON_NAME;
            parameters[13].Value = model.C_REASON_CODE;
            parameters[14].Value = model.D_DP_DT;
            parameters[15].Value = model.C_RESULT_ELE;
            parameters[16].Value = model.C_RESULT_PHY;
            parameters[17].Value = model.C_RESULT_ALL;
            parameters[18].Value = model.D_RESALL_DT;
            parameters[19].Value = model.C_RESULT_PEOPLE;
            parameters[20].Value = model.D_RESPEO_DT;
            parameters[21].Value = model.C_QR_STATE;
            parameters[22].Value = model.C_EMP_ID;
            parameters[23].Value = model.D_MOD_DT;
            parameters[24].Value = model.C_RESULT_PHYSEC;
            parameters[25].Value = model.C_RESULT_PHYFINAL;
            parameters[26].Value = model.C_DESIGN_NO;
            parameters[27].Value = model.N_STATUS;
            parameters[28].Value = model.C_REMARK;
            parameters[29].Value = model.C_KP_NO;
            parameters[30].Value = model.C_PCINFO;
            parameters[31].Value = model.C_ID;

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
        public bool Update_Trans(Mod_TQC_COMPRE_ROLL model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TQC_COMPRE_ROLL set ");
            strSql.Append("C_STOVE=:C_STOVE,");
            strSql.Append("C_BATCH_NO=:C_BATCH_NO,");
            strSql.Append("C_STL_GRD=:C_STL_GRD,");
            strSql.Append("N_WGT=:N_WGT,");
            strSql.Append("N_QUA=:N_QUA,");
            strSql.Append("C_STD_CODE=:C_STD_CODE,");
            strSql.Append("C_SPEC=:C_SPEC,");
            strSql.Append("C_MAT_CODE=:C_MAT_CODE,");
            strSql.Append("C_MAT_NAME=:C_MAT_NAME,");
            strSql.Append("C_SHIFT=:C_SHIFT,");
            strSql.Append("C_GROUP=:C_GROUP,");
            strSql.Append("C_RESULT_FACE=:C_RESULT_FACE,");
            strSql.Append("C_REASON_NAME=:C_REASON_NAME,");
            strSql.Append("C_REASON_CODE=:C_REASON_CODE,");
            strSql.Append("D_DP_DT=:D_DP_DT,");
            strSql.Append("C_RESULT_ELE=:C_RESULT_ELE,");
            strSql.Append("C_RESULT_PHY=:C_RESULT_PHY,");
            strSql.Append("C_RESULT_ALL=:C_RESULT_ALL,");
            strSql.Append("D_RESALL_DT=:D_RESALL_DT,");
            strSql.Append("C_RESULT_PEOPLE=:C_RESULT_PEOPLE,");
            strSql.Append("D_RESPEO_DT=:D_RESPEO_DT,");
            strSql.Append("C_QR_STATE=:C_QR_STATE,");
            strSql.Append("C_EMP_ID=:C_EMP_ID,");
            strSql.Append("D_MOD_DT=:D_MOD_DT,");
            strSql.Append("C_RESULT_PHYSEC=:C_RESULT_PHYSEC,");
            strSql.Append("C_RESULT_PHYFINAL=:C_RESULT_PHYFINAL,");
            strSql.Append("C_DESIGN_NO=:C_DESIGN_NO,");
            strSql.Append("N_STATUS=:N_STATUS,");
            strSql.Append("C_REMARK=:C_REMARK,");
            strSql.Append("C_KP_NO=:C_KP_NO,");
            strSql.Append("C_PCINFO=:C_PCINFO");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_STOVE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_BATCH_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STL_GRD", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":N_QUA", OracleDbType.Decimal,10),
                    new OracleParameter(":C_STD_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SPEC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MAT_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MAT_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SHIFT", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_GROUP", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_RESULT_FACE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_REASON_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_REASON_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_DP_DT", OracleDbType.Date),
                    new OracleParameter(":C_RESULT_ELE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_RESULT_PHY", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_RESULT_ALL", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_RESALL_DT", OracleDbType.Date),
                    new OracleParameter(":C_RESULT_PEOPLE", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_RESPEO_DT", OracleDbType.Date),
                    new OracleParameter(":C_QR_STATE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":C_RESULT_PHYSEC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_RESULT_PHYFINAL", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_DESIGN_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_KP_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PCINFO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.C_STOVE;
            parameters[1].Value = model.C_BATCH_NO;
            parameters[2].Value = model.C_STL_GRD;
            parameters[3].Value = model.N_WGT;
            parameters[4].Value = model.N_QUA;
            parameters[5].Value = model.C_STD_CODE;
            parameters[6].Value = model.C_SPEC;
            parameters[7].Value = model.C_MAT_CODE;
            parameters[8].Value = model.C_MAT_NAME;
            parameters[9].Value = model.C_SHIFT;
            parameters[10].Value = model.C_GROUP;
            parameters[11].Value = model.C_RESULT_FACE;
            parameters[12].Value = model.C_REASON_NAME;
            parameters[13].Value = model.C_REASON_CODE;
            parameters[14].Value = model.D_DP_DT;
            parameters[15].Value = model.C_RESULT_ELE;
            parameters[16].Value = model.C_RESULT_PHY;
            parameters[17].Value = model.C_RESULT_ALL;
            parameters[18].Value = model.D_RESALL_DT;
            parameters[19].Value = model.C_RESULT_PEOPLE;
            parameters[20].Value = model.D_RESPEO_DT;
            parameters[21].Value = model.C_QR_STATE;
            parameters[22].Value = model.C_EMP_ID;
            parameters[23].Value = model.D_MOD_DT;
            parameters[24].Value = model.C_RESULT_PHYSEC;
            parameters[25].Value = model.C_RESULT_PHYFINAL;
            parameters[26].Value = model.C_DESIGN_NO;
            parameters[27].Value = model.N_STATUS;
            parameters[28].Value = model.C_REMARK;
            parameters[29].Value = model.C_KP_NO;
            parameters[30].Value = model.C_PCINFO;
            parameters[31].Value = model.C_ID;

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
            strSql.Append("delete from TQC_COMPRE_ROLL ");
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
        /// 批量删除数据
        /// </summary>
        public bool DeleteList(string C_IDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from TQC_COMPRE_ROLL ");
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
        public Mod_TQC_COMPRE_ROLL GetModel(string C_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_STOVE,C_BATCH_NO,C_STL_GRD,N_WGT,N_QUA,C_STD_CODE,C_SPEC,C_MAT_CODE,C_MAT_NAME,C_SHIFT,C_GROUP,C_RESULT_FACE,C_REASON_NAME,C_REASON_CODE,D_DP_DT,C_RESULT_ELE,C_RESULT_PHY,C_RESULT_ALL,D_RESALL_DT,C_RESULT_PEOPLE,D_RESPEO_DT,C_QR_STATE,C_EMP_ID,D_MOD_DT,C_RESULT_PHYSEC,C_RESULT_PHYFINAL,C_DESIGN_NO,N_STATUS,C_REMARK,C_KP_NO,C_PCINFO from TQC_COMPRE_ROLL ");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)         };
            parameters[0].Value = C_ID;

            Mod_TQC_COMPRE_ROLL model = new Mod_TQC_COMPRE_ROLL();
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
        public Mod_TQC_COMPRE_ROLL DataRowToModel(DataRow row)
        {
            Mod_TQC_COMPRE_ROLL model = new Mod_TQC_COMPRE_ROLL();
            if (row != null)
            {
                if (row["C_ID"] != null)
                {
                    model.C_ID = row["C_ID"].ToString();
                }
                if (row["C_STOVE"] != null)
                {
                    model.C_STOVE = row["C_STOVE"].ToString();
                }
                if (row["C_BATCH_NO"] != null)
                {
                    model.C_BATCH_NO = row["C_BATCH_NO"].ToString();
                }
                if (row["C_STL_GRD"] != null)
                {
                    model.C_STL_GRD = row["C_STL_GRD"].ToString();
                }
                if (row["N_WGT"] != null && row["N_WGT"].ToString() != "")
                {
                    model.N_WGT = decimal.Parse(row["N_WGT"].ToString());
                }
                if (row["N_QUA"] != null && row["N_QUA"].ToString() != "")
                {
                    model.N_QUA = decimal.Parse(row["N_QUA"].ToString());
                }
                if (row["C_STD_CODE"] != null)
                {
                    model.C_STD_CODE = row["C_STD_CODE"].ToString();
                }
                if (row["C_SPEC"] != null)
                {
                    model.C_SPEC = row["C_SPEC"].ToString();
                }
                if (row["C_MAT_CODE"] != null)
                {
                    model.C_MAT_CODE = row["C_MAT_CODE"].ToString();
                }
                if (row["C_MAT_NAME"] != null)
                {
                    model.C_MAT_NAME = row["C_MAT_NAME"].ToString();
                }
                if (row["C_SHIFT"] != null)
                {
                    model.C_SHIFT = row["C_SHIFT"].ToString();
                }
                if (row["C_GROUP"] != null)
                {
                    model.C_GROUP = row["C_GROUP"].ToString();
                }
                if (row["C_RESULT_FACE"] != null)
                {
                    model.C_RESULT_FACE = row["C_RESULT_FACE"].ToString();
                }
                if (row["C_REASON_NAME"] != null)
                {
                    model.C_REASON_NAME = row["C_REASON_NAME"].ToString();
                }
                if (row["C_REASON_CODE"] != null)
                {
                    model.C_REASON_CODE = row["C_REASON_CODE"].ToString();
                }
                if (row["D_DP_DT"] != null && row["D_DP_DT"].ToString() != "")
                {
                    model.D_DP_DT = DateTime.Parse(row["D_DP_DT"].ToString());
                }
                if (row["C_RESULT_ELE"] != null)
                {
                    model.C_RESULT_ELE = row["C_RESULT_ELE"].ToString();
                }
                if (row["C_RESULT_PHY"] != null)
                {
                    model.C_RESULT_PHY = row["C_RESULT_PHY"].ToString();
                }
                if (row["C_RESULT_ALL"] != null)
                {
                    model.C_RESULT_ALL = row["C_RESULT_ALL"].ToString();
                }
                if (row["D_RESALL_DT"] != null && row["D_RESALL_DT"].ToString() != "")
                {
                    model.D_RESALL_DT = DateTime.Parse(row["D_RESALL_DT"].ToString());
                }
                if (row["C_RESULT_PEOPLE"] != null)
                {
                    model.C_RESULT_PEOPLE = row["C_RESULT_PEOPLE"].ToString();
                }
                if (row["D_RESPEO_DT"] != null && row["D_RESPEO_DT"].ToString() != "")
                {
                    model.D_RESPEO_DT = DateTime.Parse(row["D_RESPEO_DT"].ToString());
                }
                if (row["C_QR_STATE"] != null)
                {
                    model.C_QR_STATE = row["C_QR_STATE"].ToString();
                }
                if (row["C_EMP_ID"] != null)
                {
                    model.C_EMP_ID = row["C_EMP_ID"].ToString();
                }
                if (row["D_MOD_DT"] != null && row["D_MOD_DT"].ToString() != "")
                {
                    model.D_MOD_DT = DateTime.Parse(row["D_MOD_DT"].ToString());
                }
                if (row["C_RESULT_PHYSEC"] != null)
                {
                    model.C_RESULT_PHYSEC = row["C_RESULT_PHYSEC"].ToString();
                }
                if (row["C_RESULT_PHYFINAL"] != null)
                {
                    model.C_RESULT_PHYFINAL = row["C_RESULT_PHYFINAL"].ToString();
                }
                if (row["C_DESIGN_NO"] != null)
                {
                    model.C_DESIGN_NO = row["C_DESIGN_NO"].ToString();
                }
                if (row["N_STATUS"] != null && row["N_STATUS"].ToString() != "")
                {
                    model.N_STATUS = decimal.Parse(row["N_STATUS"].ToString());
                }
                if (row["C_REMARK"] != null)
                {
                    model.C_REMARK = row["C_REMARK"].ToString();
                }
                if (row["C_KP_NO"] != null)
                {
                    model.C_KP_NO = row["C_KP_NO"].ToString();
                }
                if (row["C_PCINFO"] != null)
                {
                    model.C_PCINFO = row["C_PCINFO"].ToString();
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
            strSql.Append("select C_ID,C_STOVE,C_BATCH_NO,C_STL_GRD,N_WGT,N_QUA,C_STD_CODE,C_SPEC,C_MAT_CODE,C_MAT_NAME,C_SHIFT,C_GROUP,C_RESULT_FACE,C_REASON_NAME,C_REASON_CODE,D_DP_DT,C_RESULT_ELE,C_RESULT_PHY,C_RESULT_ALL,D_RESALL_DT,C_RESULT_PEOPLE,D_RESPEO_DT,C_QR_STATE,C_EMP_ID,D_MOD_DT,C_RESULT_PHYSEC,C_RESULT_PHYFINAL,C_DESIGN_NO,N_STATUS,C_REMARK,C_KP_NO,C_PCINFO ");
            strSql.Append(" FROM TQC_COMPRE_ROLL ");
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
            strSql.Append("select count(1) FROM TQC_COMPRE_ROLL ");
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
        /// 查询线材综合判定数据
        /// </summary>
        /// <param name="batchNo">批号</param>
        /// <param name="stove">炉号</param>
        /// <param name="strTime1">生产开始时间</param>
        /// <param name="strTime2">生产结束时间</param>
        /// <param name="strState">全部；已确认，未确认</param>
        /// <returns></returns>
        public DataSet GetList(string batchNo, string stove, string strTime1, string strTime2, string strState)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT t.C_ID,T.C_STOVE AS 炉号, T.C_BATCH_NO AS 批号,T.C_KP_NO AS 开坯号, T.C_STL_GRD AS 钢种, T.C_SPEC AS 规格, T.C_STD_CODE AS 执行标准, T.C_MAT_CODE AS 物料编码, T.C_MAT_NAME AS 物料名称, T.N_QUA AS 件数, T.N_WGT AS 重量, T.C_RESULT_FACE AS 表判结果, T.C_REASON_NAME AS 不合格原因, T.C_RESULT_ELE AS 成分结果, T.C_RESULT_PHY AS 性能初检结果, T.C_RESULT_PHYSEC AS 性能复检结果, T.C_RESULT_PHYFINAL AS 性能评审结果, T.C_RESULT_ALL AS 综合判定结果, T.C_RESULT_PEOPLE AS 人工判定结果, T.D_RESALL_DT AS 判定时间, T.C_QR_STATE AS 是否确认, T.C_EMP_ID, T.D_MOD_DT AS 确认时间, T.D_DP_DT AS 生产时间, T.C_DESIGN_NO AS 质量设计号,T.C_REMARK AS 备注,T.C_ID  FROM TQC_COMPRE_ROLL T WHERE N_STATUS=1 ");

            if (batchNo.Trim() != "")
            {
                strSql.Append(" and T.C_BATCH_NO like '" + batchNo + "%' ");
            }

            if (stove.Trim() != "")
            {
                strSql.Append(" and T.C_STOVE like '" + stove + "%' ");
            }

            if (strState.Trim() != "全部")
            {
                strSql.Append(" and T.C_QR_STATE = '" + strState + "' ");
            }

            if (strTime1.Trim() != "" && strTime2.Trim() != "")
            {
                strSql.Append(" and T.D_DP_DT between to_date('" + strTime1 + "','yyyy-mm-dd hh24:mi:ss') and to_date('" + strTime2 + "','yyyy-mm-dd hh24:mi:ss') ");
            }

            strSql.Append(" order by T.C_BATCH_NO ");

            return DbHelperOra.Query(strSql.ToString());
        }


        /// <summary>
        /// 查询线材综合判定数据
        /// </summary>
        /// <param name="batchNo">批号</param>
        /// <param name="stove">炉号</param>
        /// <param name="strTime1">生产开始时间</param>
        /// <param name="strTime2">生产结束时间</param>
        /// <param name="strState">全部；已确认，未确认</param>
        /// <param name="strTimeType">生产时间，确认时间</param>
        /// <returns></returns>
        public DataSet GetList(string batchNo, string stove, string strTime1, string strTime2, string strState, string strTimeType)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT t.C_ID,T.C_STOVE AS 炉号, T.C_BATCH_NO AS 批号,T.C_KP_NO AS 开坯号, T.C_STL_GRD AS 钢种, T.C_SPEC AS 规格, T.C_STD_CODE AS 执行标准, T.C_MAT_CODE AS 物料编码, T.C_MAT_NAME AS 物料名称, T.N_QUA AS 件数, T.N_WGT AS 重量, T.C_RESULT_FACE AS 表判结果, T.C_REASON_NAME AS 不合格原因, T.C_RESULT_ELE AS 成分结果, T.C_RESULT_PHY AS 性能初检结果, T.C_RESULT_PHYSEC AS 性能复检结果, T.C_RESULT_PHYFINAL AS 性能评审结果, T.C_RESULT_ALL AS 综合判定结果, T.C_RESULT_PEOPLE AS 人工判定结果, T.D_RESALL_DT AS 判定时间, T.C_QR_STATE AS 是否确认, T.C_EMP_ID, T.D_MOD_DT AS 确认时间, T.D_DP_DT AS 生产时间, T.C_DESIGN_NO AS 质量设计号,T.C_REMARK AS 备注,T.C_ID,T.C_PCINFO as 特殊信息  FROM TQC_COMPRE_ROLL T WHERE N_STATUS=1 ");

            if (batchNo.Trim() != "")
            {
                strSql.Append(" and T.C_BATCH_NO like '" + batchNo + "%' ");
            }

            if (stove.Trim() != "")
            {
                strSql.Append(" and T.C_STOVE like '" + stove + "%' ");
            }

            if (strState.Trim() != "全部")
            {
                strSql.Append(" and T.C_QR_STATE = '" + strState + "' ");
            }

            if (strTime1.Trim() != "" && strTime2.Trim() != "")
            {
                if (strTimeType.Trim() == "生产时间")
                {
                    strSql.Append(" and T.D_DP_DT between to_date('" + strTime1 + "','yyyy-mm-dd hh24:mi:ss') and to_date('" + strTime2 + "','yyyy-mm-dd hh24:mi:ss') ");
                }

                if (strTimeType.Trim() == "确认时间")
                {
                    strSql.Append(" and T.D_MOD_DT between to_date('" + strTime1 + "','yyyy-mm-dd hh24:mi:ss') and to_date('" + strTime2 + "','yyyy-mm-dd hh24:mi:ss') ");
                }
            }

            strSql.Append(" order by T.C_BATCH_NO ");

            return DbHelperOra.Query(strSql.ToString());
        }


        /// <summary>
        /// 查询线材综合判定数据
        /// </summary>
        /// <param name="batchNo">批号</param>
        /// <param name="stove">炉号</param>
        /// <param name="strTime1">生产开始时间</param>
        /// <param name="strTime2">生产结束时间</param>
        /// <param name="strState">全部；已确认，未确认</param>
        /// <param name="strTimeType">生产时间，确认时间</param>
        /// <param name="strStlGrd">钢种</param>
        /// <param name="strStdCode">标准</param>
        /// <returns></returns>
        public DataSet Get_Compre_List(string batchMin, string batchMax, string stove, string strTime1, string strTime2, string strState, string strTimeType, string strStlGrd, string strStdCode)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT t.C_ID,T.C_STOVE AS 炉号, T.C_BATCH_NO AS 批号,T.C_KP_NO AS 开坯号, T.C_STL_GRD AS 钢种, T.C_SPEC AS 规格, T.C_STD_CODE AS 执行标准, T.C_MAT_CODE AS 物料编码, T.C_MAT_NAME AS 物料名称, T.N_QUA AS 件数, T.N_WGT AS 重量, T.C_RESULT_FACE AS 表判结果, T.C_REASON_NAME AS 不合格原因, T.C_RESULT_ELE AS 成分结果, T.C_RESULT_PHY AS 性能初检结果, T.C_RESULT_PHYSEC AS 性能复检结果, T.C_RESULT_PHYFINAL AS 性能评审结果, T.C_RESULT_ALL AS 综合判定结果, T.C_RESULT_PEOPLE AS 人工判定结果, T.D_RESALL_DT AS 判定时间, T.C_QR_STATE AS 是否确认, T.C_EMP_ID, T.D_MOD_DT AS 确认时间, T.D_DP_DT AS 生产时间, T.C_DESIGN_NO AS 质量设计号,T.C_REMARK AS 备注,T.C_ID,t.C_PCINFO as 特殊信息  FROM TQC_COMPRE_ROLL T WHERE N_STATUS=1 ");

            if (batchMin.Trim() != "")
            {
                strSql.Append(" and T.C_BATCH_NO >='" + batchMin + "' ");
            }

            if (batchMax.Trim() != "")
            {
                strSql.Append(" and T.C_BATCH_NO <='" + batchMax + "' ");
            }

            if (stove.Trim() != "")
            {
                strSql.Append(" and T.C_STOVE like '" + stove + "%' ");
            }

            if (strState.Trim() != "全部")
            {
                strSql.Append(" and T.C_QR_STATE = '" + strState + "' ");
            }

            if (strTime1.Trim() != "" && strTime2.Trim() != "")
            {
                if (strTimeType.Trim() == "生产时间")
                {
                    strSql.Append(" and T.D_DP_DT between to_date('" + strTime1 + "','yyyy-mm-dd hh24:mi:ss') and to_date('" + strTime2 + "','yyyy-mm-dd hh24:mi:ss') ");
                }

                if (strTimeType.Trim() == "确认时间")
                {
                    strSql.Append(" and T.D_MOD_DT between to_date('" + strTime1 + "','yyyy-mm-dd hh24:mi:ss') and to_date('" + strTime2 + "','yyyy-mm-dd hh24:mi:ss') ");
                }
            }

            if (strStlGrd.Trim() != "")
            {
                strSql.Append(" and T.C_STL_GRD like '%" + strStlGrd + "%' ");
            }

            if (strStdCode.Trim() != "")
            {
                strSql.Append(" and T.C_STD_CODE like '%" + strStdCode + "%' ");
            }

            strSql.Append(" order by T.C_BATCH_NO ");

            return DbHelperOra.Query(strSql.ToString());
        }


        /// <summary>
        /// 查询综判信息是否已上传NC
        /// </summary>
        /// <returns></returns>
        public int Get_NC_Count(string strSql)
        {
            object obj = DbHelperOra.GetSingle(strSql);
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
        /// 获得数据列表
        /// </summary>
        public DataSet Get_List(string C_BATCH_NO)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID ");
            strSql.Append(" FROM TQC_COMPRE_ROLL where C_BATCH_NO='" + C_BATCH_NO + "' and N_STATUS='1' ");

            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public string Get_State(string C_BATCH_NO)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select max(C_QR_STATE)  FROM TQC_COMPRE_ROLL  ");

            object obj = DbHelperOra.GetSingle(strSql.ToString());
            if (obj == null)
            {
                return "";
            }
            else
            {
                return obj.ToString();
            }
        }

        /// <summary>
        /// 线材综合判定
        /// </summary>
        /// <returns></returns>
        public int JUDGE_ROLL()
        {
            return DbHelperOra.RunProcedure("PKG_COMPRE_ROLL.P_JUDGE_ROLL_ZD");
        }

        /// <summary>
        /// 同步线材信息到综合判定表
        /// </summary>
        /// <returns></returns>
        public int TB_ROLL()
        {
            return DbHelperOra.RunProcedure("PKG_COMPRE_ROLL.P_TB_ROLL_ZD");
        }

        /// <summary>
        /// 线材综合判定(指定批号)
        /// </summary>
        /// <param name="P_BATCH">批号</param>
        /// <returns></returns>
        public string JUDGE_ROLL_BATCH(string P_BATCH)
        {
            OracleParameter[] parameters = {
            new OracleParameter("P_BATCH", OracleDbType.Varchar2,100),
            new OracleParameter("P_MSG", OracleDbType.Varchar2,100)};

            parameters[0].Value = P_BATCH;
            parameters[1].Value = "失败";

            return DbHelperOra.RunProcedureOut("PKG_COMPRE_ROLL.P_JUDGE_ROLL_BATCH", parameters);
        }

        /// <summary>
        /// 同步线材信息到综合判定表(指定批号)
        /// </summary>
        /// <param name="P_BATCH">批号</param>
        /// <returns></returns>
        public string TB_ROLL_BATCH(string P_BATCH)
        {
            OracleParameter[] parameters = {
            new OracleParameter("P_BATCH", OracleDbType.Varchar2,100),
            new OracleParameter("P_MSG", OracleDbType.Varchar2,100)};

            parameters[0].Value = P_BATCH;
            parameters[1].Value = "失败";

            return DbHelperOra.RunProcedureOut("PKG_COMPRE_ROLL.P_TB_ROLL_BATCH", parameters);
        }

        /// <summary>
        /// 获取条码库存信息
        /// </summary>
        /// <param name="Barcode">钢卷唯一码</param>
        /// <param name="CK">仓库</param>
        /// <param name="HW">货位</param>
        /// <param name="WGDH">完工单号</param>
        /// <param name="PH">批号</param>
        /// <param name="GH">钩号</param>
        /// <param name="GZ">钢种</param>
        /// <returns>条码库存信息</returns>
        public DataSet Get_TM_List(string PCH)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT T1.PCH, T1.GH, T1.ZL ");

            strSql.Append(" FROM WMS_BMS_INV_INFO T1 WHERE T1.PCH='" + PCH + "'  ");

            return DbHelper_SQL.Query(strSql.ToString());
        }


        /// <summary>
        /// 查询NC批次信息
        /// </summary>
        /// <returns></returns>
        public int Get_NC_Batch_Count(string strSql)
        {
            object obj = DbHelperNC.GetSingle(strSql);
            if (obj == null)
            {
                return 0;
            }
            else
            {
                return Convert.ToInt32(obj);
            }
        }

        #endregion  BasicMethod

    }
}

