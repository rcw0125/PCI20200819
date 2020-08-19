using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;
namespace DAL
{
    public partial class Dal_TRC_COGDOWN_LOG
    {
        public Dal_TRC_COGDOWN_LOG()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string C_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TRC_COGDOWN_LOG");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID",  OracleDbType.Varchar2,100)           };
            parameters[0].Value = C_ID;

            return DbHelperOra.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Mod_TRC_COGDOWN_LOG model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TRC_COGDOWN_LOG(");
            strSql.Append("C_TRC_ROLL_MAIN_ID,C_TRC_PLAN_ROLL_ID,N_QUA_TOTAL,N_WGT_TOTAL,C_SHIFT,C_GROUP,N_ROLL_STATE,C_REMARK,D_MOD_DT,N_QUA_REMOVE,N_WGT_REMOVE,N_QUA_RETRUN,N_WGT_RETRUN,N_QUA_JOIN,N_WGT_JOIN,N_QUA_EXIT,N_WGT_EXIT,N_QUA_CPHALF,N_WGT_HALF,N_QUA_CPWHOLE,N_QUA_ELIM,N_WGT_ELIM,C_EMP_ID,N_STATUS,N_ORDER,N_QUA_SL,N_QUA_HG,N_WGT_SL,N_WGT_HG,C_LOG_ID,C_BATCH_NO)");
            strSql.Append(" values (");
            strSql.Append(":C_TRC_ROLL_MAIN_ID,:C_TRC_PLAN_ROLL_ID,:N_QUA_TOTAL,:N_WGT_TOTAL,:C_SHIFT,:C_GROUP,:N_ROLL_STATE,:C_REMARK,:D_MOD_DT,:N_QUA_REMOVE,:N_WGT_REMOVE,:N_QUA_RETRUN,:N_WGT_RETRUN,:N_QUA_JOIN,:N_WGT_JOIN,:N_QUA_EXIT,:N_WGT_EXIT,:N_QUA_CPHALF,:N_WGT_HALF,:N_QUA_CPWHOLE,:N_QUA_ELIM,:N_WGT_ELIM,:C_EMP_ID,:N_STATUS,:N_ORDER,:N_QUA_SL,:N_QUA_HG,:N_WGT_SL,:N_WGT_HG,:C_LOG_ID,:C_BATCH_NO)");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_TRC_ROLL_MAIN_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_TRC_PLAN_ROLL_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_QUA_TOTAL", OracleDbType.Decimal,4),
                    new OracleParameter(":N_WGT_TOTAL", OracleDbType.Decimal,4),
                    new OracleParameter(":C_SHIFT", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_GROUP", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_ROLL_STATE", OracleDbType.Decimal,4),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":N_QUA_REMOVE", OracleDbType.Decimal,4),
                    new OracleParameter(":N_WGT_REMOVE", OracleDbType.Decimal,4),
                    new OracleParameter(":N_QUA_RETRUN", OracleDbType.Decimal,4),
                    new OracleParameter(":N_WGT_RETRUN", OracleDbType.Decimal,4),
                    new OracleParameter(":N_QUA_JOIN", OracleDbType.Decimal,4),
                    new OracleParameter(":N_WGT_JOIN", OracleDbType.Decimal,4),
                    new OracleParameter(":N_QUA_EXIT", OracleDbType.Decimal,4),
                    new OracleParameter(":N_WGT_EXIT", OracleDbType.Decimal,4),
                    new OracleParameter(":N_QUA_CPHALF", OracleDbType.Decimal,4),
                    new OracleParameter(":N_WGT_HALF", OracleDbType.Decimal,4),
                    new OracleParameter(":N_QUA_CPWHOLE", OracleDbType.Decimal,4),
                    new OracleParameter(":N_QUA_ELIM", OracleDbType.Decimal,4),
                    new OracleParameter(":N_WGT_ELIM", OracleDbType.Decimal,4),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,4),
                    new OracleParameter(":N_ORDER", OracleDbType.Decimal,4),
                    new OracleParameter(":N_QUA_SL", OracleDbType.Decimal,4),
                    new OracleParameter(":N_QUA_HG", OracleDbType.Decimal,4),
                    new OracleParameter(":N_WGT_SL", OracleDbType.Decimal,4),
                    new OracleParameter(":N_WGT_HG", OracleDbType.Decimal,4),
                    new OracleParameter(":C_LOG_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_BATCH_NO", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.C_TRC_ROLL_MAIN_ID;
            parameters[1].Value = model.C_TRC_PLAN_ROLL_ID;
            parameters[2].Value = model.N_QUA_TOTAL;
            parameters[3].Value = model.N_WGT_TOTAL;
            parameters[4].Value = model.C_SHIFT;
            parameters[5].Value = model.C_GROUP;
            parameters[6].Value = model.N_ROLL_STATE;
            parameters[7].Value = model.C_REMARK;
            parameters[8].Value = model.D_MOD_DT;
            parameters[9].Value = model.N_QUA_REMOVE;
            parameters[10].Value = model.N_WGT_REMOVE;
            parameters[11].Value = model.N_QUA_RETRUN;
            parameters[12].Value = model.N_WGT_RETRUN;
            parameters[13].Value = model.N_QUA_JOIN;
            parameters[14].Value = model.N_WGT_JOIN;
            parameters[15].Value = model.N_QUA_EXIT;
            parameters[16].Value = model.N_WGT_EXIT;
            parameters[17].Value = model.N_QUA_CPHALF;
            parameters[18].Value = model.N_WGT_HALF;
            parameters[19].Value = model.N_QUA_CPWHOLE;
            parameters[20].Value = model.N_QUA_ELIM;
            parameters[21].Value = model.N_WGT_ELIM;
            parameters[22].Value = model.C_EMP_ID;
            parameters[23].Value = model.N_STATUS;
            parameters[24].Value = model.N_ORDER;
            parameters[25].Value = model.N_QUA_SL;
            parameters[26].Value = model.N_QUA_HG;
            parameters[27].Value = model.N_WGT_SL;
            parameters[28].Value = model.N_WGT_HG;
            parameters[29].Value = model.C_LOG_ID;
            parameters[30].Value = model.C_BATCH_NO;

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
        public bool Update(Mod_TRC_COGDOWN_LOG model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TRC_COGDOWN_LOG set ");
            strSql.Append("C_TRC_ROLL_MAIN_ID=:C_TRC_ROLL_MAIN_ID,");
            strSql.Append("C_TRC_PLAN_ROLL_ID=:C_TRC_PLAN_ROLL_ID,");
            strSql.Append("N_QUA_TOTAL=:N_QUA_TOTAL,");
            strSql.Append("N_WGT_TOTAL=:N_WGT_TOTAL,");
            strSql.Append("C_SHIFT=:C_SHIFT,");
            strSql.Append("C_GROUP=:C_GROUP,");
            strSql.Append("N_ROLL_STATE=:N_ROLL_STATE,");
            strSql.Append("C_REMARK=:C_REMARK,");
            strSql.Append("D_MOD_DT=:D_MOD_DT,");
            strSql.Append("N_QUA_REMOVE=:N_QUA_REMOVE,");
            strSql.Append("N_WGT_REMOVE=:N_WGT_REMOVE,");
            strSql.Append("N_QUA_RETRUN=:N_QUA_RETRUN,");
            strSql.Append("N_WGT_RETRUN=:N_WGT_RETRUN,");
            strSql.Append("N_QUA_JOIN=:N_QUA_JOIN,");
            strSql.Append("N_WGT_JOIN=:N_WGT_JOIN,");
            strSql.Append("N_QUA_EXIT=:N_QUA_EXIT,");
            strSql.Append("N_WGT_EXIT=:N_WGT_EXIT,");
            strSql.Append("N_QUA_CPHALF=:N_QUA_CPHALF,");
            strSql.Append("N_WGT_HALF=:N_WGT_HALF,");
            strSql.Append("N_QUA_CPWHOLE=:N_QUA_CPWHOLE,");
            strSql.Append("N_QUA_ELIM=:N_QUA_ELIM,");
            strSql.Append("N_WGT_ELIM=:N_WGT_ELIM,");
            strSql.Append("C_EMP_ID=:C_EMP_ID,");
            strSql.Append("N_STATUS=:N_STATUS,");
            strSql.Append("N_ORDER=:N_ORDER,");
            strSql.Append("N_QUA_SL=:N_QUA_SL,");
            strSql.Append("N_QUA_HG=:N_QUA_HG,");
            strSql.Append("N_WGT_SL=:N_WGT_SL,");
            strSql.Append("N_WGT_HG=:N_WGT_HG,");
            strSql.Append("C_LOG_ID=:C_LOG_ID,");
            strSql.Append("C_BATCH_NO=:C_BATCH_NO");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_TRC_ROLL_MAIN_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_TRC_PLAN_ROLL_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_QUA_TOTAL", OracleDbType.Decimal,4),
                    new OracleParameter(":N_WGT_TOTAL", OracleDbType.Decimal,4),
                    new OracleParameter(":C_SHIFT", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_GROUP", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_ROLL_STATE", OracleDbType.Decimal,4),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":N_QUA_REMOVE", OracleDbType.Decimal,4),
                    new OracleParameter(":N_WGT_REMOVE", OracleDbType.Decimal,4),
                    new OracleParameter(":N_QUA_RETRUN", OracleDbType.Decimal,4),
                    new OracleParameter(":N_WGT_RETRUN", OracleDbType.Decimal,4),
                    new OracleParameter(":N_QUA_JOIN", OracleDbType.Decimal,4),
                    new OracleParameter(":N_WGT_JOIN", OracleDbType.Decimal,4),
                    new OracleParameter(":N_QUA_EXIT", OracleDbType.Decimal,4),
                    new OracleParameter(":N_WGT_EXIT", OracleDbType.Decimal,4),
                    new OracleParameter(":N_QUA_CPHALF", OracleDbType.Decimal,4),
                    new OracleParameter(":N_WGT_HALF", OracleDbType.Decimal,4),
                    new OracleParameter(":N_QUA_CPWHOLE", OracleDbType.Decimal,4),
                    new OracleParameter(":N_QUA_ELIM", OracleDbType.Decimal,4),
                    new OracleParameter(":N_WGT_ELIM", OracleDbType.Decimal,4),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,4),
                    new OracleParameter(":N_ORDER", OracleDbType.Decimal,4),
                    new OracleParameter(":N_QUA_SL", OracleDbType.Decimal,4),
                    new OracleParameter(":N_QUA_HG", OracleDbType.Decimal,4),
                    new OracleParameter(":N_WGT_SL", OracleDbType.Decimal,4),
                    new OracleParameter(":N_WGT_HG", OracleDbType.Decimal,4),
                    new OracleParameter(":C_LOG_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_BATCH_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.C_TRC_ROLL_MAIN_ID;
            parameters[1].Value = model.C_TRC_PLAN_ROLL_ID;
            parameters[2].Value = model.N_QUA_TOTAL;
            parameters[3].Value = model.N_WGT_TOTAL;
            parameters[4].Value = model.C_SHIFT;
            parameters[5].Value = model.C_GROUP;
            parameters[6].Value = model.N_ROLL_STATE;
            parameters[7].Value = model.C_REMARK;
            parameters[8].Value = model.D_MOD_DT;
            parameters[9].Value = model.N_QUA_REMOVE;
            parameters[10].Value = model.N_WGT_REMOVE;
            parameters[11].Value = model.N_QUA_RETRUN;
            parameters[12].Value = model.N_WGT_RETRUN;
            parameters[13].Value = model.N_QUA_JOIN;
            parameters[14].Value = model.N_WGT_JOIN;
            parameters[15].Value = model.N_QUA_EXIT;
            parameters[16].Value = model.N_WGT_EXIT;
            parameters[17].Value = model.N_QUA_CPHALF;
            parameters[18].Value = model.N_WGT_HALF;
            parameters[19].Value = model.N_QUA_CPWHOLE;
            parameters[20].Value = model.N_QUA_ELIM;
            parameters[21].Value = model.N_WGT_ELIM;
            parameters[22].Value = model.C_EMP_ID;
            parameters[23].Value = model.N_STATUS;
            parameters[24].Value = model.N_ORDER;
            parameters[25].Value = model.N_QUA_SL;
            parameters[26].Value = model.N_QUA_HG;
            parameters[27].Value = model.N_WGT_SL;
            parameters[28].Value = model.N_WGT_HG;
            parameters[29].Value = model.C_LOG_ID;
            parameters[30].Value = model.C_BATCH_NO;
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
        /// 删除一条数据
        /// </summary>
        public bool Delete(string C_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from TRC_COGDOWN_LOG ");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID",  OracleDbType.Varchar2,100)           };
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
            strSql.Append("delete from TRC_COGDOWN_LOG ");
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
        public Mod_TRC_COGDOWN_LOG GetModel(string C_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_TRC_ROLL_MAIN_ID,C_TRC_PLAN_ROLL_ID,N_QUA_TOTAL,N_WGT_TOTAL,C_SHIFT,C_GROUP,N_ROLL_STATE,C_REMARK,D_MOD_DT,N_QUA_REMOVE,N_WGT_REMOVE,N_QUA_RETRUN,N_WGT_RETRUN,N_QUA_JOIN,N_WGT_JOIN,N_QUA_EXIT,N_WGT_EXIT,N_QUA_CPHALF,N_WGT_HALF,N_QUA_CPWHOLE,N_QUA_ELIM,N_WGT_ELIM,C_EMP_ID,N_STATUS,N_ORDER,N_QUA_SL,N_QUA_HG,N_WGT_SL,N_WGT_HG,C_LOG_ID,C_BATCH_NO from TRC_COGDOWN_LOG ");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID",  OracleDbType.Varchar2,100)           };
            parameters[0].Value = C_ID;

            Mod_TRC_COGDOWN_LOG model = new Mod_TRC_COGDOWN_LOG();
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
        public Mod_TRC_COGDOWN_LOG DataRowToModel(DataRow row)
        {
            Mod_TRC_COGDOWN_LOG model = new Mod_TRC_COGDOWN_LOG();
            if (row != null)
            {
                if (row["C_ID"] != null)
                {
                    model.C_ID = row["C_ID"].ToString();
                }
                if (row["C_TRC_ROLL_MAIN_ID"] != null)
                {
                    model.C_TRC_ROLL_MAIN_ID = row["C_TRC_ROLL_MAIN_ID"].ToString();
                }
                if (row["C_TRC_PLAN_ROLL_ID"] != null)
                {
                    model.C_TRC_PLAN_ROLL_ID = row["C_TRC_PLAN_ROLL_ID"].ToString();
                }
                if (row["N_QUA_TOTAL"] != null && row["N_QUA_TOTAL"].ToString() != "")
                {
                    model.N_QUA_TOTAL = decimal.Parse(row["N_QUA_TOTAL"].ToString());
                }
                if (row["N_WGT_TOTAL"] != null && row["N_WGT_TOTAL"].ToString() != "")
                {
                    model.N_WGT_TOTAL = decimal.Parse(row["N_WGT_TOTAL"].ToString());
                }
                if (row["C_SHIFT"] != null)
                {
                    model.C_SHIFT = row["C_SHIFT"].ToString();
                }
                if (row["C_GROUP"] != null)
                {
                    model.C_GROUP = row["C_GROUP"].ToString();
                }
                if (row["N_ROLL_STATE"] != null && row["N_ROLL_STATE"].ToString() != "")
                {
                    model.N_ROLL_STATE = decimal.Parse(row["N_ROLL_STATE"].ToString());
                }
                if (row["C_REMARK"] != null)
                {
                    model.C_REMARK = row["C_REMARK"].ToString();
                }
                if (row["D_MOD_DT"] != null && row["D_MOD_DT"].ToString() != "")
                {
                    model.D_MOD_DT = DateTime.Parse(row["D_MOD_DT"].ToString());
                }
                if (row["N_QUA_REMOVE"] != null && row["N_QUA_REMOVE"].ToString() != "")
                {
                    model.N_QUA_REMOVE = decimal.Parse(row["N_QUA_REMOVE"].ToString());
                }
                if (row["N_WGT_REMOVE"] != null && row["N_WGT_REMOVE"].ToString() != "")
                {
                    model.N_WGT_REMOVE = decimal.Parse(row["N_WGT_REMOVE"].ToString());
                }
                if (row["N_QUA_RETRUN"] != null && row["N_QUA_RETRUN"].ToString() != "")
                {
                    model.N_QUA_RETRUN = decimal.Parse(row["N_QUA_RETRUN"].ToString());
                }
                if (row["N_WGT_RETRUN"] != null && row["N_WGT_RETRUN"].ToString() != "")
                {
                    model.N_WGT_RETRUN = decimal.Parse(row["N_WGT_RETRUN"].ToString());
                }
                if (row["N_QUA_JOIN"] != null && row["N_QUA_JOIN"].ToString() != "")
                {
                    model.N_QUA_JOIN = decimal.Parse(row["N_QUA_JOIN"].ToString());
                }
                if (row["N_WGT_JOIN"] != null && row["N_WGT_JOIN"].ToString() != "")
                {
                    model.N_WGT_JOIN = decimal.Parse(row["N_WGT_JOIN"].ToString());
                }
                if (row["N_QUA_EXIT"] != null && row["N_QUA_EXIT"].ToString() != "")
                {
                    model.N_QUA_EXIT = decimal.Parse(row["N_QUA_EXIT"].ToString());
                }
                if (row["N_WGT_EXIT"] != null && row["N_WGT_EXIT"].ToString() != "")
                {
                    model.N_WGT_EXIT = decimal.Parse(row["N_WGT_EXIT"].ToString());
                }
                if (row["N_QUA_CPHALF"] != null && row["N_QUA_CPHALF"].ToString() != "")
                {
                    model.N_QUA_CPHALF = decimal.Parse(row["N_QUA_CPHALF"].ToString());
                }
                if (row["N_WGT_HALF"] != null && row["N_WGT_HALF"].ToString() != "")
                {
                    model.N_WGT_HALF = decimal.Parse(row["N_WGT_HALF"].ToString());
                }
                if (row["N_QUA_CPWHOLE"] != null && row["N_QUA_CPWHOLE"].ToString() != "")
                {
                    model.N_QUA_CPWHOLE = decimal.Parse(row["N_QUA_CPWHOLE"].ToString());
                }
                if (row["N_QUA_ELIM"] != null && row["N_QUA_ELIM"].ToString() != "")
                {
                    model.N_QUA_ELIM = decimal.Parse(row["N_QUA_ELIM"].ToString());
                }
                if (row["N_WGT_ELIM"] != null && row["N_WGT_ELIM"].ToString() != "")
                {
                    model.N_WGT_ELIM = decimal.Parse(row["N_WGT_ELIM"].ToString());
                }
                if (row["C_EMP_ID"] != null)
                {
                    model.C_EMP_ID = row["C_EMP_ID"].ToString();
                }
                if (row["N_STATUS"] != null && row["N_STATUS"].ToString() != "")
                {
                    model.N_STATUS = decimal.Parse(row["N_STATUS"].ToString());
                }
                if (row["N_ORDER"] != null && row["N_ORDER"].ToString() != "")
                {
                    model.N_ORDER = decimal.Parse(row["N_ORDER"].ToString());
                }
                if (row["N_QUA_SL"] != null && row["N_QUA_SL"].ToString() != "")
                {
                    model.N_QUA_SL = decimal.Parse(row["N_QUA_SL"].ToString());
                }
                if (row["N_QUA_HG"] != null && row["N_QUA_HG"].ToString() != "")
                {
                    model.N_QUA_HG = decimal.Parse(row["N_QUA_HG"].ToString());
                }
                if (row["N_WGT_SL"] != null && row["N_WGT_SL"].ToString() != "")
                {
                    model.N_WGT_SL = decimal.Parse(row["N_WGT_SL"].ToString());
                }
                if (row["N_WGT_HG"] != null && row["N_WGT_HG"].ToString() != "")
                {
                    model.N_WGT_HG = decimal.Parse(row["N_WGT_HG"].ToString());
                }
                if (row["C_LOG_ID"] != null)
                {
                    model.C_LOG_ID = row["C_LOG_ID"].ToString();
                }
                if (row["C_BATCH_NO"] != null)
                {
                    model.C_BATCH_NO = row["C_BATCH_NO"].ToString();
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
            strSql.Append("select C_ID,C_TRC_ROLL_MAIN_ID,C_TRC_PLAN_ROLL_ID,N_QUA_TOTAL,N_WGT_TOTAL,C_SHIFT,C_GROUP,N_ROLL_STATE,C_REMARK,D_MOD_DT,N_QUA_REMOVE,N_WGT_REMOVE,N_QUA_RETRUN,N_WGT_RETRUN,N_QUA_JOIN,N_WGT_JOIN,N_QUA_EXIT,N_WGT_EXIT,N_QUA_CPHALF,N_WGT_HALF,N_QUA_CPWHOLE,N_QUA_ELIM,N_WGT_ELIM,C_EMP_ID,N_STATUS,N_ORDER,N_QUA_SL,N_QUA_HG,N_WGT_SL,N_WGT_HG,C_LOG_ID,C_BATCH_NO ");
            strSql.Append(" FROM TRC_COGDOWN_LOG ");
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
            strSql.Append("select count(1) FROM TRC_COGDOWN_LOG ");
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
            strSql.Append(")AS Row, T.*  from TRC_COGDOWN_LOG T ");
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
					new OracleParameter(":PageSize", OracleDbType.Decimal),
					new OracleParameter(":PageIndex", OracleDbType.Decimal),
					new OracleParameter(":IsReCount", OracleType.Clob),
					new OracleParameter(":OrderType", OracleType.Clob),
					new OracleParameter(":strWhere", OracleDbType.Varchar2,1000),
					};
			parameters[0].Value = "TRC_COGDOWN_LOG";
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

        #endregion  ExtensionMethod
    }
}
