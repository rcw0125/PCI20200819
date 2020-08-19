using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;

namespace DAL
{
    /// <summary>
    /// 数据访问类:TQC_RECHECK
    /// </summary>
    public partial class Dal_TQC_RECHECK
    {
        public Dal_TQC_RECHECK()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string C_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TQC_RECHECK");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)         };
            parameters[0].Value = C_ID;

            return DbHelperOra.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Mod_TQC_RECHECK model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TQC_RECHECK(");
            strSql.Append("C_PHYSICS_CODE,C_PHYSICS_NAME,C_CHARACTER_ID,C_STOVE,C_BATCH_NO,C_STL_GRD,C_SPEC,C_STD_CODE,C_ITEM_NAME,C_SHIFT,C_GROUP,C_STA_ID,C_DISPOSAL,N_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT,N_NUMBER,N_IS_QR,C_QR_USER_ID,D_QR_MOD,C_TICK_NO,N_RECHECK,C_ZZ_USER_ID,D_ZZ_MOD,C_ZZJG)");
            strSql.Append(" values (");
            strSql.Append(":C_PHYSICS_CODE,:C_PHYSICS_NAME,:C_CHARACTER_ID,:C_STOVE,:C_BATCH_NO,:C_STL_GRD,:C_SPEC,:C_STD_CODE,:C_ITEM_NAME,:C_SHIFT,:C_GROUP,:C_STA_ID,:C_DISPOSAL,:N_STATUS,:C_REMARK,:C_EMP_ID,:D_MOD_DT,:N_NUMBER,:N_IS_QR,:C_QR_USER_ID,:D_QR_MOD,:C_TICK_NO,:N_RECHECK,:C_ZZ_USER_ID,:D_ZZ_MOD,:C_ZZJG)");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_PHYSICS_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PHYSICS_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CHARACTER_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STOVE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_BATCH_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STL_GRD", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SPEC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STD_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ITEM_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SHIFT", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_GROUP", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STA_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_DISPOSAL", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":N_NUMBER", OracleDbType.Decimal,1),
                    new OracleParameter(":N_IS_QR", OracleDbType.Decimal,1),
                    new OracleParameter(":C_QR_USER_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_QR_MOD", OracleDbType.Date),
                    new OracleParameter(":C_TICK_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_RECHECK", OracleDbType.Decimal,2),
                    new OracleParameter(":C_ZZ_USER_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_ZZ_MOD", OracleDbType.Date),
                    new OracleParameter(":C_ZZJG", OracleDbType.Varchar2,500)};
            parameters[0].Value = model.C_PHYSICS_CODE;
            parameters[1].Value = model.C_PHYSICS_NAME;
            parameters[2].Value = model.C_CHARACTER_ID;
            parameters[3].Value = model.C_STOVE;
            parameters[4].Value = model.C_BATCH_NO;
            parameters[5].Value = model.C_STL_GRD;
            parameters[6].Value = model.C_SPEC;
            parameters[7].Value = model.C_STD_CODE;
            parameters[8].Value = model.C_ITEM_NAME;
            parameters[9].Value = model.C_SHIFT;
            parameters[10].Value = model.C_GROUP;
            parameters[11].Value = model.C_STA_ID;
            parameters[12].Value = model.C_DISPOSAL;
            parameters[13].Value = model.N_STATUS;
            parameters[14].Value = model.C_REMARK;
            parameters[15].Value = model.C_EMP_ID;
            parameters[16].Value = model.D_MOD_DT;
            parameters[17].Value = model.N_NUMBER;
            parameters[18].Value = model.N_IS_QR;
            parameters[19].Value = model.C_QR_USER_ID;
            parameters[20].Value = model.D_QR_MOD;
            parameters[21].Value = model.C_TICK_NO;
            parameters[22].Value = model.N_RECHECK;
            parameters[23].Value = model.C_ZZ_USER_ID;
            parameters[24].Value = model.D_ZZ_MOD;
            parameters[25].Value = model.C_ZZJG;

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
        public bool Update(Mod_TQC_RECHECK model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TQC_RECHECK set ");
            strSql.Append("C_PHYSICS_CODE=:C_PHYSICS_CODE,");
            strSql.Append("C_PHYSICS_NAME=:C_PHYSICS_NAME,");
            strSql.Append("C_CHARACTER_ID=:C_CHARACTER_ID,");
            strSql.Append("C_STOVE=:C_STOVE,");
            strSql.Append("C_BATCH_NO=:C_BATCH_NO,");
            strSql.Append("C_STL_GRD=:C_STL_GRD,");
            strSql.Append("C_SPEC=:C_SPEC,");
            strSql.Append("C_STD_CODE=:C_STD_CODE,");
            strSql.Append("C_ITEM_NAME=:C_ITEM_NAME,");
            strSql.Append("C_SHIFT=:C_SHIFT,");
            strSql.Append("C_GROUP=:C_GROUP,");
            strSql.Append("C_STA_ID=:C_STA_ID,");
            strSql.Append("C_DISPOSAL=:C_DISPOSAL,");
            strSql.Append("N_STATUS=:N_STATUS,");
            strSql.Append("C_REMARK=:C_REMARK,");
            strSql.Append("C_EMP_ID=:C_EMP_ID,");
            strSql.Append("D_MOD_DT=:D_MOD_DT,");
            strSql.Append("N_NUMBER=:N_NUMBER,");
            strSql.Append("N_IS_QR=:N_IS_QR,");
            strSql.Append("C_QR_USER_ID=:C_QR_USER_ID,");
            strSql.Append("D_QR_MOD=:D_QR_MOD,");
            strSql.Append("C_TICK_NO=:C_TICK_NO,");
            strSql.Append("N_RECHECK=:N_RECHECK,");
            strSql.Append("C_ZZ_USER_ID=:C_ZZ_USER_ID,");
            strSql.Append("D_ZZ_MOD=:D_ZZ_MOD,");
            strSql.Append("C_ZZJG=:C_ZZJG");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_PHYSICS_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PHYSICS_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CHARACTER_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STOVE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_BATCH_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STL_GRD", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SPEC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STD_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ITEM_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SHIFT", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_GROUP", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STA_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_DISPOSAL", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":N_NUMBER", OracleDbType.Decimal,1),
                    new OracleParameter(":N_IS_QR", OracleDbType.Decimal,1),
                    new OracleParameter(":C_QR_USER_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_QR_MOD", OracleDbType.Date),
                    new OracleParameter(":C_TICK_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_RECHECK", OracleDbType.Decimal,2),
                    new OracleParameter(":C_ZZ_USER_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_ZZ_MOD", OracleDbType.Date),
                    new OracleParameter(":C_ZZJG", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.C_PHYSICS_CODE;
            parameters[1].Value = model.C_PHYSICS_NAME;
            parameters[2].Value = model.C_CHARACTER_ID;
            parameters[3].Value = model.C_STOVE;
            parameters[4].Value = model.C_BATCH_NO;
            parameters[5].Value = model.C_STL_GRD;
            parameters[6].Value = model.C_SPEC;
            parameters[7].Value = model.C_STD_CODE;
            parameters[8].Value = model.C_ITEM_NAME;
            parameters[9].Value = model.C_SHIFT;
            parameters[10].Value = model.C_GROUP;
            parameters[11].Value = model.C_STA_ID;
            parameters[12].Value = model.C_DISPOSAL;
            parameters[13].Value = model.N_STATUS;
            parameters[14].Value = model.C_REMARK;
            parameters[15].Value = model.C_EMP_ID;
            parameters[16].Value = model.D_MOD_DT;
            parameters[17].Value = model.N_NUMBER;
            parameters[18].Value = model.N_IS_QR;
            parameters[19].Value = model.C_QR_USER_ID;
            parameters[20].Value = model.D_QR_MOD;
            parameters[21].Value = model.C_TICK_NO;
            parameters[22].Value = model.N_RECHECK;
            parameters[23].Value = model.C_ZZ_USER_ID;
            parameters[24].Value = model.D_ZZ_MOD;
            parameters[25].Value = model.C_ZZJG;
            parameters[26].Value = model.C_ID;

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
        public bool Update_Trans(Mod_TQC_RECHECK model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TQC_RECHECK set ");
            strSql.Append("C_PHYSICS_CODE=:C_PHYSICS_CODE,");
            strSql.Append("C_PHYSICS_NAME=:C_PHYSICS_NAME,");
            strSql.Append("C_CHARACTER_ID=:C_CHARACTER_ID,");
            strSql.Append("C_STOVE=:C_STOVE,");
            strSql.Append("C_BATCH_NO=:C_BATCH_NO,");
            strSql.Append("C_STL_GRD=:C_STL_GRD,");
            strSql.Append("C_SPEC=:C_SPEC,");
            strSql.Append("C_STD_CODE=:C_STD_CODE,");
            strSql.Append("C_ITEM_NAME=:C_ITEM_NAME,");
            strSql.Append("C_SHIFT=:C_SHIFT,");
            strSql.Append("C_GROUP=:C_GROUP,");
            strSql.Append("C_STA_ID=:C_STA_ID,");
            strSql.Append("C_DISPOSAL=:C_DISPOSAL,");
            strSql.Append("N_STATUS=:N_STATUS,");
            strSql.Append("C_REMARK=:C_REMARK,");
            strSql.Append("C_EMP_ID=:C_EMP_ID,");
            strSql.Append("D_MOD_DT=:D_MOD_DT,");
            strSql.Append("N_NUMBER=:N_NUMBER,");
            strSql.Append("N_IS_QR=:N_IS_QR,");
            strSql.Append("C_QR_USER_ID=:C_QR_USER_ID,");
            strSql.Append("D_QR_MOD=:D_QR_MOD,");
            strSql.Append("C_TICK_NO=:C_TICK_NO,");
            strSql.Append("N_RECHECK=:N_RECHECK,");
            strSql.Append("C_ZZ_USER_ID=:C_ZZ_USER_ID,");
            strSql.Append("D_ZZ_MOD=:D_ZZ_MOD,");
            strSql.Append("C_ZZJG=:C_ZZJG");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_PHYSICS_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PHYSICS_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CHARACTER_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STOVE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_BATCH_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STL_GRD", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SPEC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STD_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ITEM_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SHIFT", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_GROUP", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STA_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_DISPOSAL", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":N_NUMBER", OracleDbType.Decimal,1),
                    new OracleParameter(":N_IS_QR", OracleDbType.Decimal,1),
                    new OracleParameter(":C_QR_USER_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_QR_MOD", OracleDbType.Date),
                    new OracleParameter(":C_TICK_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_RECHECK", OracleDbType.Decimal,2),
                    new OracleParameter(":C_ZZ_USER_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_ZZ_MOD", OracleDbType.Date),
                    new OracleParameter(":C_ZZJG", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.C_PHYSICS_CODE;
            parameters[1].Value = model.C_PHYSICS_NAME;
            parameters[2].Value = model.C_CHARACTER_ID;
            parameters[3].Value = model.C_STOVE;
            parameters[4].Value = model.C_BATCH_NO;
            parameters[5].Value = model.C_STL_GRD;
            parameters[6].Value = model.C_SPEC;
            parameters[7].Value = model.C_STD_CODE;
            parameters[8].Value = model.C_ITEM_NAME;
            parameters[9].Value = model.C_SHIFT;
            parameters[10].Value = model.C_GROUP;
            parameters[11].Value = model.C_STA_ID;
            parameters[12].Value = model.C_DISPOSAL;
            parameters[13].Value = model.N_STATUS;
            parameters[14].Value = model.C_REMARK;
            parameters[15].Value = model.C_EMP_ID;
            parameters[16].Value = model.D_MOD_DT;
            parameters[17].Value = model.N_NUMBER;
            parameters[18].Value = model.N_IS_QR;
            parameters[19].Value = model.C_QR_USER_ID;
            parameters[20].Value = model.D_QR_MOD;
            parameters[21].Value = model.C_TICK_NO;
            parameters[22].Value = model.N_RECHECK;
            parameters[23].Value = model.C_ZZ_USER_ID;
            parameters[24].Value = model.D_ZZ_MOD;
            parameters[25].Value = model.C_ZZJG;
            parameters[26].Value = model.C_ID;

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
        public bool Update_CX(string C_STOVE, string C_BATCH_NO, string C_STL_GRD, string C_SPEC, string C_STD_CODE, string C_PHYSICS_CODE, string strTime)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TQC_RECHECK set ");
            strSql.Append("N_STATUS=0");
            strSql.Append(" where C_STOVE='" + C_STOVE + "' and");
            strSql.Append(" C_BATCH_NO='" + C_BATCH_NO + "' and ");
            strSql.Append(" C_STL_GRD='" + C_STL_GRD + "' and ");
            strSql.Append(" C_SPEC='" + C_SPEC + "'  and");
            strSql.Append(" C_STD_CODE='" + C_STD_CODE + "'  and ");
            strSql.Append(" C_PHYSICS_CODE='" + C_PHYSICS_CODE + "'  and n_is_qr=0 AND D_MOD_DT=TO_DATE('" + strTime + "','yyyy-mm-dd hh24:mi:ss') ");

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
        /// 删除一条数据
        /// </summary>
        public bool Delete(string C_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from TQC_RECHECK ");
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
            strSql.Append("delete from TQC_RECHECK ");
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
        public Mod_TQC_RECHECK GetModel(string C_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_PHYSICS_CODE,C_PHYSICS_NAME,C_CHARACTER_ID,C_STOVE,C_BATCH_NO,C_STL_GRD,C_SPEC,C_STD_CODE,C_ITEM_NAME,C_SHIFT,C_GROUP,C_STA_ID,C_DISPOSAL,N_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT,N_NUMBER,N_IS_QR,C_QR_USER_ID,D_QR_MOD,C_TICK_NO,N_RECHECK,C_ZZ_USER_ID,D_ZZ_MOD,C_ZZJG from TQC_RECHECK ");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)         };
            parameters[0].Value = C_ID;

            Mod_TQC_RECHECK model = new Mod_TQC_RECHECK();
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
        public Mod_TQC_RECHECK DataRowToModel(DataRow row)
        {
            Mod_TQC_RECHECK model = new Mod_TQC_RECHECK();
            if (row != null)
            {
                if (row["C_ID"] != null)
                {
                    model.C_ID = row["C_ID"].ToString();
                }
                if (row["C_PHYSICS_CODE"] != null)
                {
                    model.C_PHYSICS_CODE = row["C_PHYSICS_CODE"].ToString();
                }
                if (row["C_PHYSICS_NAME"] != null)
                {
                    model.C_PHYSICS_NAME = row["C_PHYSICS_NAME"].ToString();
                }
                if (row["C_CHARACTER_ID"] != null)
                {
                    model.C_CHARACTER_ID = row["C_CHARACTER_ID"].ToString();
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
                if (row["C_SPEC"] != null)
                {
                    model.C_SPEC = row["C_SPEC"].ToString();
                }
                if (row["C_STD_CODE"] != null)
                {
                    model.C_STD_CODE = row["C_STD_CODE"].ToString();
                }
                if (row["C_ITEM_NAME"] != null)
                {
                    model.C_ITEM_NAME = row["C_ITEM_NAME"].ToString();
                }
                if (row["C_SHIFT"] != null)
                {
                    model.C_SHIFT = row["C_SHIFT"].ToString();
                }
                if (row["C_GROUP"] != null)
                {
                    model.C_GROUP = row["C_GROUP"].ToString();
                }
                if (row["C_STA_ID"] != null)
                {
                    model.C_STA_ID = row["C_STA_ID"].ToString();
                }
                if (row["C_DISPOSAL"] != null)
                {
                    model.C_DISPOSAL = row["C_DISPOSAL"].ToString();
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
                if (row["N_NUMBER"] != null && row["N_NUMBER"].ToString() != "")
                {
                    model.N_NUMBER = decimal.Parse(row["N_NUMBER"].ToString());
                }
                if (row["N_IS_QR"] != null && row["N_IS_QR"].ToString() != "")
                {
                    model.N_IS_QR = decimal.Parse(row["N_IS_QR"].ToString());
                }
                if (row["C_QR_USER_ID"] != null)
                {
                    model.C_QR_USER_ID = row["C_QR_USER_ID"].ToString();
                }
                if (row["D_QR_MOD"] != null && row["D_QR_MOD"].ToString() != "")
                {
                    model.D_QR_MOD = DateTime.Parse(row["D_QR_MOD"].ToString());
                }
                if (row["C_TICK_NO"] != null)
                {
                    model.C_TICK_NO = row["C_TICK_NO"].ToString();
                }
                if (row["N_RECHECK"] != null && row["N_RECHECK"].ToString() != "")
                {
                    model.N_RECHECK = decimal.Parse(row["N_RECHECK"].ToString());
                }
                if (row["C_ZZ_USER_ID"] != null)
                {
                    model.C_ZZ_USER_ID = row["C_ZZ_USER_ID"].ToString();
                }
                if (row["D_ZZ_MOD"] != null && row["D_ZZ_MOD"].ToString() != "")
                {
                    model.D_ZZ_MOD = DateTime.Parse(row["D_ZZ_MOD"].ToString());
                }
                if (row["C_ZZJG"] != null)
                {
                    model.C_ZZJG = row["C_ZZJG"].ToString();
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
            strSql.Append("select C_ID,C_PHYSICS_CODE,C_PHYSICS_NAME,C_CHARACTER_ID,C_STOVE,C_BATCH_NO,C_STL_GRD,C_SPEC,C_STD_CODE,C_ITEM_NAME,C_SHIFT,C_GROUP,C_STA_ID,C_DISPOSAL,N_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT,N_NUMBER,N_IS_QR,C_QR_USER_ID,D_QR_MOD,C_TICK_NO,N_RECHECK ");
            strSql.Append(" FROM TQC_RECHECK ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 复检修料申请
        /// </summary>
        /// <param name="begin">开始时间</param>
        /// <param name="end">结束时间</param>
        /// <param name="C_BATCH_NO">批号</param>
        /// <returns></returns>
        public DataSet GetList_XLSQ(DateTime begin, DateTime end, string C_BATCH_NO)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" SELECT  (SELECT MAX(T1.C_ID)  FROM TRC_ROLL_PRODCUT T1 WHERE T.C_BATCH_NO = T1.C_BATCH_NO  AND T.C_STL_GRD = T1.C_STL_GRD  AND T.C_STD_CODE = T1.C_STD_CODE) AS C_ID , T.C_STOVE AS 炉号,  T.C_BATCH_NO AS 批号, T.C_STL_GRD AS  钢种, T.C_STD_CODE AS 执行标准, T.C_SPEC AS 规格,  T.C_DISPOSAL AS 处置意见, T.C_REMARK AS 备注,   t2.c_name as 申请人员 ,  MAX(T.D_MOD_DT) AS 申请时间   FROM TQC_RECHECK T LEFT JOIN TS_USER T2 ON T2.C_ID = T.C_EMP_ID WHERE T.N_STATUS = 1  AND N_IS_QR = 0   ");
            if (begin != null && end != null)
            {
                strSql.Append(" and t.D_MOD_DT between to_date('" + Convert.ToDateTime(begin) + "','yyyy-mm-dd hh24:mi:ss') and to_date('" + Convert.ToDateTime(end) + "','yyyy-mm-dd hh24:mi:ss') ");
            }
            if (C_BATCH_NO.Trim() != "")
            {
                strSql.Append(" and T.C_BATCH_NO like '" + C_BATCH_NO + "%' ");
            }
            strSql.Append(" GROUP BY T.C_STOVE, T.C_BATCH_NO, T.C_STL_GRD, T.C_SPEC, T.C_STD_CODE, T.C_DISPOSAL, T.N_STATUS, T.C_REMARK,  t2.c_name   ");
            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 库检修料申请
        /// </summary>
        /// <param name="begin">开始时间</param>
        /// <param name="end">结束时间</param>
        /// <param name="C_BATCH_NO">批号</param>
        /// <returns></returns>
        public DataSet GetList_XCKJ(DateTime begin, DateTime end, string C_BATCH_NO)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" SELECT T.C_ROLL_ID AS C_ID,T.C_STOVE AS 炉号, T.C_BATCH_NO AS 批号,T.C_STL_GRD AS 钢种, T.C_STD_CODE AS 执行标准, T.C_SPEC AS 规格,T.C_SUGGESTION AS 处置意见,T.C_REMARK AS 备注,T1.C_NAME AS 申请人员,MAX(T.D_MOD_DT) AS 申请时间  FROM TQC_WAREHOUSE_CHECK_ROLL T LEFT JOIN TS_USER T1 ON T1.C_ID = T.C_EMP_ID WHERE 1=1 ");
            if (begin != null && end != null)
            {
                strSql.Append(" and t.D_MOD_DT between to_date('" + Convert.ToDateTime(begin) + "','yyyy-mm-dd hh24:mi:ss') and to_date('" + Convert.ToDateTime(end) + "','yyyy-mm-dd hh24:mi:ss') ");
            }
            if (C_BATCH_NO.Trim() != "")
            {
                strSql.Append(" and T.C_BATCH_NO like '" + C_BATCH_NO + "%' ");
            }
            strSql.Append("  GROUP BY T.C_ROLL_ID,  T.C_STOVE,  T.C_BATCH_NO,  T.C_STL_GRD, T.C_STD_CODE,  T.C_SPEC, T.C_SUGGESTION,  T.C_REMARK,  T1.C_NAME  ");
            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM TQC_RECHECK where N_STATUS=1 and C_BATCH_NO='" + strWhere + "' ");

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
            strSql.Append(")AS Row, T.*  from TQC_RECHECK T ");
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
			parameters[0].Value = "TQC_RECHECK";
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
        /// 分组获取数据
        /// </summary>
        /// <param name="begin">开始时间</param>
        /// <param name="end">结束时间</param>
        /// <param name="c_stove">炉号</param>
        /// <param name="c_batch_no">批号</param>
        /// <param name="num">确认状态</param>
        /// <returns></returns>
        public DataSet GetList_Query_Group(DateTime begin, DateTime end, string c_stove, string c_batch_no, int num)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) cou,C_CHARACTER_ID,C_STOVE,C_BATCH_NO,C_PHYSICS_CODE,C_STL_GRD,C_SPEC,C_STD_CODE,C_ITEM_NAME,C_SHIFT,C_GROUP,C_STA_ID,C_DISPOSAL,N_STATUS,C_REMARK,C_EMP_ID,MAX(D_MOD_DT) DT,N_IS_QR,C_TICK_NO,N_RECHECK  ");
            strSql.Append(" FROM TQC_RECHECK where N_STATUS=1 and  N_IS_QR=" + num + " ");
            if (begin != null && end != null)
            {
                strSql.Append(" and D_MOD_DT between to_date('" + Convert.ToDateTime(begin) + "','yyyy-mm-dd hh24:mi:ss') and to_date('" + Convert.ToDateTime(end) + "','yyyy-mm-dd hh24:mi:ss') ");
            }
            if (c_stove.Trim() != "")
            {
                strSql.Append(" and c_stove like '%" + c_stove + "%'");
            }
            if (c_batch_no.Trim() != "")
            {
                strSql.Append(" and c_batch_no like '%" + c_batch_no + "%'");
            }
            strSql.Append("GROUP BY C_CHARACTER_ID,C_STOVE,C_BATCH_NO,C_PHYSICS_CODE,C_STL_GRD,C_SPEC,C_STD_CODE,C_ITEM_NAME,C_SHIFT,C_GROUP,C_STA_ID,C_DISPOSAL,N_STATUS,C_REMARK,C_EMP_ID,N_IS_QR,C_TICK_NO,N_RECHECK ");
            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取数据
        /// </summary>
        /// <param name="begin">开始时间</param>
        /// <param name="end">结束时间</param>
        /// <param name="c_stove">炉号</param>
        /// <param name="c_batch_no">批号</param>
        /// <param name="num">确认状态</param>
        /// <returns></returns>
        public DataSet GetList_Query(DateTime begin, DateTime end, string c_stove, string c_batch_no, int num)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT T.C_ID,(SELECT max(DECODE(T3.C_TYPE,'1','修料质量确认')) FROM TRC_ROLL_PRODCUT T2 LEFT JOIN TQC_UPDATE_MATERIAL_log T3 ON T2.C_ID=T3.C_ROLL_PRODUCT_ID WHERE T2.C_BATCH_NO=T.C_BATCH_NO AND T2.C_TICK_NO = T.C_TICK_NO AND T3.C_TYPE='3' AND t3.n_status=1)SFQR,T.C_PHYSICS_CODE,T.C_PHYSICS_NAME,T.C_CHARACTER_ID,T.C_STOVE,T.C_BATCH_NO,T.C_STL_GRD,T.C_SPEC,T.C_STD_CODE,T.C_ITEM_NAME,T.C_SHIFT,T.C_GROUP,T.C_STA_ID,T.C_DISPOSAL,T.N_STATUS,T.C_REMARK,T.C_EMP_ID,T.D_MOD_DT,T.N_NUMBER,T.N_IS_QR,(SELECT T1.C_NAME FROM TS_USER T1 WHERE T1.C_ID=T.C_QR_USER_ID)AS C_QR_USER_ID,T.D_QR_MOD,T.C_TICK_NO,(SELECT T1.C_NAME FROM TS_USER T1 WHERE T1.C_ID=T.C_ZZ_USER_ID)AS C_ZZ_USER_ID,T.D_ZZ_MOD,T.C_ZZJG  FROM TQC_RECHECK T   WHERE N_STATUS=1   and  t.N_IS_QR=" + num + " ");
            if (begin != null && end != null)
            {
                strSql.Append(" and t.D_MOD_DT between to_date('" + Convert.ToDateTime(begin) + "','yyyy-mm-dd hh24:mi:ss') and to_date('" + Convert.ToDateTime(end) + "','yyyy-mm-dd hh24:mi:ss') ");
            }
            if (c_stove.Trim() != "")
            {
                strSql.Append(" and t.c_stove like '%" + c_stove + "%'");
            }
            if (c_batch_no.Trim() != "")
            {
                strSql.Append(" and t.c_batch_no like '%" + c_batch_no + "%'");
            }
            return DbHelperOra.Query(strSql.ToString());
        }
        #endregion  ExtensionMethod
    }
}

