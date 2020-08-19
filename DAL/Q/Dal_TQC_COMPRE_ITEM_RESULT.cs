using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;
namespace DAL
{
    /// <summary>
    /// 数据访问类:TQC_COMPRE_ITEM_RESULT
    /// </summary>
    public partial class Dal_TQC_COMPRE_ITEM_RESULT
    {
        public Dal_TQC_COMPRE_ITEM_RESULT()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string C_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TQC_COMPRE_ITEM_RESULT");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)          };
            parameters[0].Value = C_ID;

            return DbHelperOra.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Mod_TQC_COMPRE_ITEM_RESULT model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TQC_COMPRE_ITEM_RESULT(");
            strSql.Append("C_STOVE,C_BATCH_NO,C_STL_GRD,C_SPEC,C_STD_CODE,C_CHARACTER_ID,C_ITEM_NAME,C_TARGET_MIN,C_TARGET_INTERVAL,C_TARGET_MAX,C_TYPE,C_UNIT,C_QUANTITATIVE,C_VALUE,C_RESULT,C_CHECK_STATE,N_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT,C_DESIGN_NO,N_PRINT_ORDER,C_TICK_NO,C_IS_SHOW,C_IS_DECIDE,C_GROUP,C_TB,C_SOURCE)");
            strSql.Append(" values (");
            strSql.Append(":C_STOVE,:C_BATCH_NO,:C_STL_GRD,:C_SPEC,:C_STD_CODE,:C_CHARACTER_ID,:C_ITEM_NAME,:C_TARGET_MIN,:C_TARGET_INTERVAL,:C_TARGET_MAX,:C_TYPE,:C_UNIT,:C_QUANTITATIVE,:C_VALUE,:C_RESULT,:C_CHECK_STATE,:N_STATUS,:C_REMARK,:C_EMP_ID,:D_MOD_DT,:C_DESIGN_NO,:N_PRINT_ORDER,:C_TICK_NO,:C_IS_SHOW,:C_IS_DECIDE,:C_GROUP,:C_TB,:C_SOURCE)");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_STOVE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_BATCH_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STL_GRD", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SPEC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STD_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CHARACTER_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ITEM_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_TARGET_MIN", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_TARGET_INTERVAL", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_TARGET_MAX", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_TYPE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_UNIT", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_QUANTITATIVE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_VALUE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_RESULT", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CHECK_STATE", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":C_DESIGN_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_PRINT_ORDER", OracleDbType.Decimal,5),
                    new OracleParameter(":C_TICK_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_IS_SHOW", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_IS_DECIDE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_GROUP", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_TB", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_SOURCE", OracleDbType.Varchar2,10)};
            parameters[0].Value = model.C_STOVE;
            parameters[1].Value = model.C_BATCH_NO;
            parameters[2].Value = model.C_STL_GRD;
            parameters[3].Value = model.C_SPEC;
            parameters[4].Value = model.C_STD_CODE;
            parameters[5].Value = model.C_CHARACTER_ID;
            parameters[6].Value = model.C_ITEM_NAME;
            parameters[7].Value = model.C_TARGET_MIN;
            parameters[8].Value = model.C_TARGET_INTERVAL;
            parameters[9].Value = model.C_TARGET_MAX;
            parameters[10].Value = model.C_TYPE;
            parameters[11].Value = model.C_UNIT;
            parameters[12].Value = model.C_QUANTITATIVE;
            parameters[13].Value = model.C_VALUE;
            parameters[14].Value = model.C_RESULT;
            parameters[15].Value = model.C_CHECK_STATE;
            parameters[16].Value = model.N_STATUS;
            parameters[17].Value = model.C_REMARK;
            parameters[18].Value = model.C_EMP_ID;
            parameters[19].Value = model.D_MOD_DT;
            parameters[20].Value = model.C_DESIGN_NO;
            parameters[21].Value = model.N_PRINT_ORDER;
            parameters[22].Value = model.C_TICK_NO;
            parameters[23].Value = model.C_IS_SHOW;
            parameters[24].Value = model.C_IS_DECIDE;
            parameters[25].Value = model.C_GROUP;
            parameters[26].Value = model.C_TB;
            parameters[27].Value = model.C_SOURCE;

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
        public bool Add_Trans(Mod_TQC_COMPRE_ITEM_RESULT model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TQC_COMPRE_ITEM_RESULT(");
            strSql.Append("C_STOVE,C_BATCH_NO,C_STL_GRD,C_SPEC,C_STD_CODE,C_CHARACTER_ID,C_ITEM_NAME,C_TARGET_MIN,C_TARGET_INTERVAL,C_TARGET_MAX,C_TYPE,C_UNIT,C_QUANTITATIVE,C_VALUE,C_RESULT,C_CHECK_STATE,N_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT,C_DESIGN_NO,N_PRINT_ORDER,C_TICK_NO,C_IS_SHOW,C_IS_DECIDE,C_GROUP,C_TB,C_SOURCE)");
            strSql.Append(" values (");
            strSql.Append(":C_STOVE,:C_BATCH_NO,:C_STL_GRD,:C_SPEC,:C_STD_CODE,:C_CHARACTER_ID,:C_ITEM_NAME,:C_TARGET_MIN,:C_TARGET_INTERVAL,:C_TARGET_MAX,:C_TYPE,:C_UNIT,:C_QUANTITATIVE,:C_VALUE,:C_RESULT,:C_CHECK_STATE,:N_STATUS,:C_REMARK,:C_EMP_ID,:D_MOD_DT,:C_DESIGN_NO,:N_PRINT_ORDER,:C_TICK_NO,:C_IS_SHOW,:C_IS_DECIDE,:C_GROUP,:C_TB,:C_SOURCE)");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_STOVE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_BATCH_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STL_GRD", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SPEC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STD_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CHARACTER_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ITEM_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_TARGET_MIN", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_TARGET_INTERVAL", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_TARGET_MAX", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_TYPE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_UNIT", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_QUANTITATIVE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_VALUE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_RESULT", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CHECK_STATE", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":C_DESIGN_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_PRINT_ORDER", OracleDbType.Decimal,5),
                    new OracleParameter(":C_TICK_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_IS_SHOW", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_IS_DECIDE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_GROUP", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_TB", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_SOURCE", OracleDbType.Varchar2,10)};
            parameters[0].Value = model.C_STOVE;
            parameters[1].Value = model.C_BATCH_NO;
            parameters[2].Value = model.C_STL_GRD;
            parameters[3].Value = model.C_SPEC;
            parameters[4].Value = model.C_STD_CODE;
            parameters[5].Value = model.C_CHARACTER_ID;
            parameters[6].Value = model.C_ITEM_NAME;
            parameters[7].Value = model.C_TARGET_MIN;
            parameters[8].Value = model.C_TARGET_INTERVAL;
            parameters[9].Value = model.C_TARGET_MAX;
            parameters[10].Value = model.C_TYPE;
            parameters[11].Value = model.C_UNIT;
            parameters[12].Value = model.C_QUANTITATIVE;
            parameters[13].Value = model.C_VALUE;
            parameters[14].Value = model.C_RESULT;
            parameters[15].Value = model.C_CHECK_STATE;
            parameters[16].Value = model.N_STATUS;
            parameters[17].Value = model.C_REMARK;
            parameters[18].Value = model.C_EMP_ID;
            parameters[19].Value = model.D_MOD_DT;
            parameters[20].Value = model.C_DESIGN_NO;
            parameters[21].Value = model.N_PRINT_ORDER;
            parameters[22].Value = model.C_TICK_NO;
            parameters[23].Value = model.C_IS_SHOW;
            parameters[24].Value = model.C_IS_DECIDE;
            parameters[25].Value = model.C_GROUP;
            parameters[26].Value = model.C_TB;
            parameters[27].Value = model.C_SOURCE;

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
        public bool Update(Mod_TQC_COMPRE_ITEM_RESULT model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TQC_COMPRE_ITEM_RESULT set ");
            strSql.Append("C_STOVE=:C_STOVE,");
            strSql.Append("C_BATCH_NO=:C_BATCH_NO,");
            strSql.Append("C_STL_GRD=:C_STL_GRD,");
            strSql.Append("C_SPEC=:C_SPEC,");
            strSql.Append("C_STD_CODE=:C_STD_CODE,");
            strSql.Append("C_CHARACTER_ID=:C_CHARACTER_ID,");
            strSql.Append("C_ITEM_NAME=:C_ITEM_NAME,");
            strSql.Append("C_TARGET_MIN=:C_TARGET_MIN,");
            strSql.Append("C_TARGET_INTERVAL=:C_TARGET_INTERVAL,");
            strSql.Append("C_TARGET_MAX=:C_TARGET_MAX,");
            strSql.Append("C_TYPE=:C_TYPE,");
            strSql.Append("C_UNIT=:C_UNIT,");
            strSql.Append("C_QUANTITATIVE=:C_QUANTITATIVE,");
            strSql.Append("C_VALUE=:C_VALUE,");
            strSql.Append("C_RESULT=:C_RESULT,");
            strSql.Append("C_CHECK_STATE=:C_CHECK_STATE,");
            strSql.Append("N_STATUS=:N_STATUS,");
            strSql.Append("C_REMARK=:C_REMARK,");
            strSql.Append("C_EMP_ID=:C_EMP_ID,");
            strSql.Append("D_MOD_DT=:D_MOD_DT,");
            strSql.Append("C_DESIGN_NO=:C_DESIGN_NO,");
            strSql.Append("N_PRINT_ORDER=:N_PRINT_ORDER,");
            strSql.Append("C_TICK_NO=:C_TICK_NO,");
            strSql.Append("C_IS_SHOW=:C_IS_SHOW,");
            strSql.Append("C_IS_DECIDE=:C_IS_DECIDE,");
            strSql.Append("C_GROUP=:C_GROUP,");
            strSql.Append("C_TB=:C_TB,");
            strSql.Append("C_SOURCE=:C_SOURCE");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_STOVE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_BATCH_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STL_GRD", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SPEC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STD_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CHARACTER_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ITEM_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_TARGET_MIN", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_TARGET_INTERVAL", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_TARGET_MAX", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_TYPE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_UNIT", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_QUANTITATIVE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_VALUE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_RESULT", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CHECK_STATE", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":C_DESIGN_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_PRINT_ORDER", OracleDbType.Decimal,5),
                    new OracleParameter(":C_TICK_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_IS_SHOW", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_IS_DECIDE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_GROUP", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_TB", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_SOURCE", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.C_STOVE;
            parameters[1].Value = model.C_BATCH_NO;
            parameters[2].Value = model.C_STL_GRD;
            parameters[3].Value = model.C_SPEC;
            parameters[4].Value = model.C_STD_CODE;
            parameters[5].Value = model.C_CHARACTER_ID;
            parameters[6].Value = model.C_ITEM_NAME;
            parameters[7].Value = model.C_TARGET_MIN;
            parameters[8].Value = model.C_TARGET_INTERVAL;
            parameters[9].Value = model.C_TARGET_MAX;
            parameters[10].Value = model.C_TYPE;
            parameters[11].Value = model.C_UNIT;
            parameters[12].Value = model.C_QUANTITATIVE;
            parameters[13].Value = model.C_VALUE;
            parameters[14].Value = model.C_RESULT;
            parameters[15].Value = model.C_CHECK_STATE;
            parameters[16].Value = model.N_STATUS;
            parameters[17].Value = model.C_REMARK;
            parameters[18].Value = model.C_EMP_ID;
            parameters[19].Value = model.D_MOD_DT;
            parameters[20].Value = model.C_DESIGN_NO;
            parameters[21].Value = model.N_PRINT_ORDER;
            parameters[22].Value = model.C_TICK_NO;
            parameters[23].Value = model.C_IS_SHOW;
            parameters[24].Value = model.C_IS_DECIDE;
            parameters[25].Value = model.C_GROUP;
            parameters[26].Value = model.C_TB;
            parameters[27].Value = model.C_SOURCE;
            parameters[28].Value = model.C_ID;

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
            strSql.Append("delete from TQC_COMPRE_ITEM_RESULT ");
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
            strSql.Append("delete from TQC_COMPRE_ITEM_RESULT ");
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
        public Mod_TQC_COMPRE_ITEM_RESULT GetModel(string C_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_STOVE,C_BATCH_NO,C_STL_GRD,C_SPEC,C_STD_CODE,C_CHARACTER_ID,C_ITEM_NAME,C_TARGET_MIN,C_TARGET_INTERVAL,C_TARGET_MAX,C_TYPE,C_UNIT,C_QUANTITATIVE,C_VALUE,C_RESULT,C_CHECK_STATE,N_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT,C_DESIGN_NO,N_PRINT_ORDER,C_TICK_NO,C_IS_SHOW,C_IS_DECIDE,C_GROUP,C_TB,C_SOURCE from TQC_COMPRE_ITEM_RESULT ");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)          };
            parameters[0].Value = C_ID;

            Mod_TQC_COMPRE_ITEM_RESULT model = new Mod_TQC_COMPRE_ITEM_RESULT();
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
        public Mod_TQC_COMPRE_ITEM_RESULT DataRowToModel(DataRow row)
        {
            Mod_TQC_COMPRE_ITEM_RESULT model = new Mod_TQC_COMPRE_ITEM_RESULT();
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
                if (row["C_SPEC"] != null)
                {
                    model.C_SPEC = row["C_SPEC"].ToString();
                }
                if (row["C_STD_CODE"] != null)
                {
                    model.C_STD_CODE = row["C_STD_CODE"].ToString();
                }
                if (row["C_CHARACTER_ID"] != null)
                {
                    model.C_CHARACTER_ID = row["C_CHARACTER_ID"].ToString();
                }
                if (row["C_ITEM_NAME"] != null)
                {
                    model.C_ITEM_NAME = row["C_ITEM_NAME"].ToString();
                }
                if (row["C_TARGET_MIN"] != null)
                {
                    model.C_TARGET_MIN = row["C_TARGET_MIN"].ToString();
                }
                if (row["C_TARGET_INTERVAL"] != null)
                {
                    model.C_TARGET_INTERVAL = row["C_TARGET_INTERVAL"].ToString();
                }
                if (row["C_TARGET_MAX"] != null)
                {
                    model.C_TARGET_MAX = row["C_TARGET_MAX"].ToString();
                }
                if (row["C_TYPE"] != null)
                {
                    model.C_TYPE = row["C_TYPE"].ToString();
                }
                if (row["C_UNIT"] != null)
                {
                    model.C_UNIT = row["C_UNIT"].ToString();
                }
                if (row["C_QUANTITATIVE"] != null)
                {
                    model.C_QUANTITATIVE = row["C_QUANTITATIVE"].ToString();
                }
                if (row["C_VALUE"] != null)
                {
                    model.C_VALUE = row["C_VALUE"].ToString();
                }
                if (row["C_RESULT"] != null)
                {
                    model.C_RESULT = row["C_RESULT"].ToString();
                }
                if (row["C_CHECK_STATE"] != null)
                {
                    model.C_CHECK_STATE = row["C_CHECK_STATE"].ToString();
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
                if (row["C_DESIGN_NO"] != null)
                {
                    model.C_DESIGN_NO = row["C_DESIGN_NO"].ToString();
                }
                if (row["N_PRINT_ORDER"] != null && row["N_PRINT_ORDER"].ToString() != "")
                {
                    model.N_PRINT_ORDER = decimal.Parse(row["N_PRINT_ORDER"].ToString());
                }
                if (row["C_TICK_NO"] != null)
                {
                    model.C_TICK_NO = row["C_TICK_NO"].ToString();
                }
                if (row["C_IS_SHOW"] != null)
                {
                    model.C_IS_SHOW = row["C_IS_SHOW"].ToString();
                }
                if (row["C_IS_DECIDE"] != null)
                {
                    model.C_IS_DECIDE = row["C_IS_DECIDE"].ToString();
                }
                if (row["C_GROUP"] != null)
                {
                    model.C_GROUP = row["C_GROUP"].ToString();
                }
                if (row["C_TB"] != null)
                {
                    model.C_TB = row["C_TB"].ToString();
                }
                if (row["C_SOURCE"] != null)
                {
                    model.C_SOURCE = row["C_SOURCE"].ToString();
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
            strSql.Append("select C_ID,C_STOVE,C_BATCH_NO,C_STL_GRD,C_SPEC,C_STD_CODE,C_CHARACTER_ID,C_ITEM_NAME,C_TARGET_MIN,C_TARGET_INTERVAL,C_TARGET_MAX,C_TYPE,C_UNIT,C_QUANTITATIVE,C_VALUE,C_RESULT,C_CHECK_STATE,N_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT,C_DESIGN_NO,N_PRINT_ORDER,C_TICK_NO,C_IS_SHOW,C_IS_DECIDE,C_GROUP,C_TB,C_SOURCE ");
            strSql.Append(" FROM TQC_COMPRE_ITEM_RESULT ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        /// <param name="strBatchNo">批号</param>
        /// <returns></returns>
        public DataSet GetList_CFXN(string Begin, string End, string strStove, string strBatchNo, string strSTLGRD, string strSTDCode)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from( SELECT DISTINCT TB.C_NAME, TA.C_CHARACTER_ID, TB.N_ORDER,'','成分' as C_TYPE  FROM TQC_COMPRE_ITEM_RESULT TA INNER JOIN TQB_CHARACTER TB ON TB.C_ID = TA.C_CHARACTER_ID INNER JOIN TRC_ROLL_PRODCUT TC ON TC.C_BATCH_NO = TA.C_BATCH_NO  AND TC.C_STL_GRD = TC.C_STL_GRD AND TC.C_STD_CODE = TA.C_STD_CODE  WHERE TA.C_TYPE = '成分'  AND TA.C_VALUE IS NOT NULL AND TA.N_STATUS=1   AND TC.C_IS_QR='Y' AND LENGTH(TC.C_BATCH_NO)=9  ");
            if (!string.IsNullOrEmpty(Begin) && !string.IsNullOrEmpty(End))
            {
                strSql.Append("and tc.D_PRODUCE_DATE between to_date('" + Convert.ToDateTime(Begin) + "','yyyy-mm-dd hh24:mi:ss') and to_date('" + Convert.ToDateTime(End) + "','yyyy-mm-dd hh24:mi:ss') ");
            }
            if (!string.IsNullOrEmpty(strStove))
            {
                strSql.Append(" and TC.C_STOVE like '" + strStove + "%'");
            }
            if (!string.IsNullOrEmpty(strBatchNo))
            {
                strSql.Append(" and TC.C_BATCH_NO like '" + strBatchNo + "%'");
            }
            if (!string.IsNullOrEmpty(strSTLGRD))
            {
                strSql.Append(" and TC.C_STL_GRD LIKE '%" + strSTLGRD + "%'");
            }
            if (!string.IsNullOrEmpty(strSTDCode))
            {
                strSql.Append(" and TC.C_STD_CODE LIKE '%" + strSTDCode + "%'");
            }
            strSql.Append(" ORDER BY TB.N_ORDER) ");
            strSql.Append(" union all select * from( SELECT DISTINCT TB.C_NAME||TA.C_GROUP, TA.C_CHARACTER_ID, TB.N_ORDER,TA.C_GROUP,'性能'  as C_TYPE  FROM TQC_COMPRE_ITEM_RESULT TA INNER JOIN TQB_CHARACTER TB ON TB.C_ID = TA.C_CHARACTER_ID INNER JOIN TRC_ROLL_PRODCUT TC ON      TC.C_BATCH_NO = TA.C_BATCH_NO  AND TC.C_STL_GRD = TC.C_STL_GRD AND TC.C_STD_CODE = TA.C_STD_CODE WHERE TA.C_TYPE = '性能' AND TB.C_NAME NOT IN ('冷顶锻', '热顶锻试验', '冷弯试验') AND TA.C_VALUE IS NOT NULL AND TA.N_STATUS=1  AND TC.C_IS_QR='Y' AND LENGTH(TC.C_BATCH_NO)=9 ");

            if (!string.IsNullOrEmpty(Begin) && !string.IsNullOrEmpty(End))
            {
                strSql.Append("and tc.D_PRODUCE_DATE between to_date('" + Convert.ToDateTime(Begin) + "','yyyy-mm-dd hh24:mi:ss') and to_date('" + Convert.ToDateTime(End) + "','yyyy-mm-dd hh24:mi:ss') ");
            }
            if (!string.IsNullOrEmpty(strStove))
            {
                strSql.Append(" and TC.C_STOVE like '" + strStove + "%'");
            }
            if (!string.IsNullOrEmpty(strBatchNo))
            {
                strSql.Append(" and TC.C_BATCH_NO like '" + strBatchNo + "%'");
            }
            if (!string.IsNullOrEmpty(strSTLGRD))
            {
                strSql.Append(" and TC.C_STL_GRD LIKE '%" + strSTLGRD + "%'");
            }
            if (!string.IsNullOrEmpty(strSTDCode))
            {
                strSql.Append(" and TC.C_STD_CODE LIKE '%" + strSTDCode + "%'");
            }
            strSql.Append(" ORDER BY TB.N_ORDER,TO_NUMBER(TA.C_GROUP)) ");
            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        /// <param name="strBatchNo">批号</param>
        /// <returns></returns>
        public DataSet GetList_CFXN_CKC(string strBatchNo)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from( SELECT DISTINCT TB.C_NAME, TA.C_CHARACTER_ID, TB.N_ORDER,''  FROM TQC_COMPRE_ITEM_RESULT TA INNER JOIN TQB_CHARACTER TB ON TB.C_ID = TA.C_CHARACTER_ID INNER JOIN TRC_ROLL_PRODCUT TC ON TC.C_BATCH_NO = TA.C_BATCH_NO  AND TC.C_STL_GRD = TC.C_STL_GRD AND TC.C_STD_CODE = TA.C_STD_CODE  WHERE TA.C_TYPE = '成分'  AND TA.C_VALUE IS NOT NULL AND TA.N_STATUS=1   AND TC.C_IS_QR='Y'  ");

            if (!string.IsNullOrEmpty(strBatchNo))
            {
                strSql.Append(" and TC.C_BATCH_NO in(" + strBatchNo + ") ");
            }

            strSql.Append(" ORDER BY TB.N_ORDER) ");
            strSql.Append(" union all select * from( SELECT DISTINCT TB.C_NAME||TA.C_GROUP, TA.C_CHARACTER_ID, TB.N_ORDER,TA.C_GROUP  FROM TQC_COMPRE_ITEM_RESULT TA INNER JOIN TQB_CHARACTER TB ON TB.C_ID = TA.C_CHARACTER_ID INNER JOIN TRC_ROLL_PRODCUT TC ON TC.C_BATCH_NO = TA.C_BATCH_NO  AND TC.C_STL_GRD = TC.C_STL_GRD AND TC.C_STD_CODE = TA.C_STD_CODE WHERE TA.C_TYPE = '性能' AND TB.C_NAME NOT IN ('冷顶锻', '热顶锻试验', '冷弯试验') AND TA.C_VALUE IS NOT NULL AND TA.N_STATUS=1  AND TC.C_IS_QR='Y' ");


            if (!string.IsNullOrEmpty(strBatchNo))
            {
                strSql.Append(" and TC.C_BATCH_NO in (" + strBatchNo + ")");
            }

            strSql.Append(" ORDER BY TB.N_ORDER,TO_NUMBER(TA.C_GROUP)) ");
            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        /// <param name="C_STOVE">炉号</param>
        /// <returns></returns>
        public DataSet GetList_Stove(string C_HTH, string C_STOVE, string strSTLGRD, string strSTDCode)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT  T.C_CON_NO,TB.C_STOVE,TB.C_BATCH_NO,TB.C_STL_GRD,TB.C_STD_CODE,TB.C_MAT_CODE,TB.C_MAT_NAME,TB.C_SPEC,SUM(TB.N_NUM)AS N_NUM,SUM(TB.N_JZ)AS N_JZ FROM TMD_DISPATCHDETAILS T INNER JOIN TMD_DISPATCH_SJZJB TB ON T.C_DISPATCH_ID=TB.C_DISPATCH_ID WHERE TB.N_STATUS=6 AND T.C_CON_NO='" + C_HTH + "' ");

            if (!string.IsNullOrEmpty(C_STOVE))
            {
                strSql.Append(" AND (TB.C_STOVE LIKE '" + C_STOVE + "%' OR TB.C_BATCH_NO LIKE '" + C_STOVE + "%') ");
            }
            if (!string.IsNullOrEmpty(strSTLGRD))
            {
                strSql.Append(" AND TB.C_STL_GRD LIKE '%" + strSTLGRD + "%'");
            }
            if (!string.IsNullOrEmpty(strSTDCode))
            {
                strSql.Append(" and TB.C_STD_CODE LIKE '%" + strSTDCode + "%'");
            }

            strSql.Append(" group by  T.C_CON_NO,TB.C_STOVE,TB.C_BATCH_NO,TB.C_STL_GRD,TB.C_STD_CODE,TB.C_MAT_CODE,TB.C_MAT_NAME,TB.C_SPEC ");

            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        /// <param name="C_STOVE">炉号</param>
        /// <returns></returns>
        public DataSet GetList_CF(DateTime Begin, DateTime End, string C_STOVE, string strSTLGRD, string strSTDCode)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT DISTINCT TB.C_NAME, TA.C_CHARACTER_ID, TB.N_ORDER  FROM TQC_COMPRE_ITEM_RESULT TA INNER JOIN TQB_CHARACTER TB ON TB.C_ID = TA.C_CHARACTER_ID INNER JOIN TSC_SLAB_MAIN TC ON TC.C_STOVE = TA.C_STOVE AND TC.C_STL_GRD = TC.C_STL_GRD AND TC.C_STD_CODE = TA.C_STD_CODE WHERE TA.C_TYPE = '成分' AND TA.C_VALUE IS NOT NULL AND TA.C_BATCH_NO IS NULL  AND TA.N_STATUS = 1 AND TC.C_IS_QR = 'Y' ");
            if (Begin != null && Begin != null)
            {
                strSql.Append("and tc.D_CCM_DATE between to_date('" + Convert.ToDateTime(Begin) + "','yyyy-mm-dd hh24:mi:ss') and to_date('" + Convert.ToDateTime(End) + "','yyyy-mm-dd hh24:mi:ss') ");
            }
            if (!string.IsNullOrEmpty(C_STOVE))
            {
                strSql.Append(" and (TC.C_STOVE like '%" + C_STOVE + "%' OR TC.C_BATCH_NO like '%" + C_STOVE + "%') ");
            }
            if (!string.IsNullOrEmpty(strSTLGRD))
            {
                strSql.Append(" and TC.C_STL_GRD LIKE '%" + strSTLGRD + "%'");
            }
            if (!string.IsNullOrEmpty(strSTDCode))
            {
                strSql.Append(" and TC.C_STD_CODE LIKE '%" + strSTDCode + "%'");
            }

            strSql.Append(" ORDER BY TB.N_ORDER ");

            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        /// <returns></returns>
        public DataSet GetList_CF_Name()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT DISTINCT TB.C_NAME, TB.N_ORDER  FROM TQC_QUA_RESULT TA INNER JOIN TQB_CHARACTER TB ON UPPER(TA.C_ANAITEM) = UPPER(TB.C_NAME) WHERE TB.N_STATUS = 1 ORDER BY TB.N_ORDER ");

            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        /// <param name="C_STOVE">炉号</param>
        /// <returns></returns>
        public DataSet GetList_CK_CF(string C_STOVE)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT DISTINCT TB.C_NAME, TA.C_CHARACTER_ID, TB.N_ORDER  FROM TQC_COMPRE_ITEM_RESULT TA INNER JOIN TQB_CHARACTER TB ON TB.C_ID = TA.C_CHARACTER_ID WHERE TA.C_TYPE = '成分' AND TA.C_VALUE IS NOT NULL AND TA.C_BATCH_NO IS NULL AND TA.N_STATUS = 1 AND TA.C_STOVE IN (" + C_STOVE + ") ");

            strSql.Append(" ORDER BY TB.N_ORDER ");

            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        /// <param name="strBatchNo">批号</param>
        /// <returns></returns>
        public DataSet GetList_CFXN_Item_CKC(string strBatchNo, string strSTLGRD, string strSTDCode, string strHTH)
        {
            string sql = "select T.合同号 , T.生产日期, T.部门, T.线材生产批次号, T.钢种, T.执行标准, T.钢种类别, T.线材规格, T.线材物料编码, T.线材物料描述, T.钢坯炉号, T.钢坯开坯号, T.钢坯物料编码, T.钢坯物料描述, T.自由项1, T.自由项2, T.自由项3, T.总件数, T.总重量, T.合格件数, T.合格重量  from V_XC_INFO_CON  t where T.合同号='" + strHTH + "'   ";

            if (!string.IsNullOrEmpty(strBatchNo))
            {
                sql = sql + " and t.线材生产批次号 like '" + strBatchNo + "%'";
            }
            if (!string.IsNullOrEmpty(strSTLGRD))
            {
                sql = sql + " and t.钢种 LIKE '%" + strSTLGRD + "%'";
            }
            if (!string.IsNullOrEmpty(strSTDCode))
            {
                sql = sql + " and t.执行标准 LIKE '%" + strSTDCode + "%'";
            }

            sql = sql + " order by t.线材生产批次号 ";

            return DbHelperOra.Query(sql);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        /// <param name="strBatchNo">批号</param>
        /// <returns></returns>
        public DataSet GetList_CFXN_Item(string Begin, string End, string strStove, string strBatchNo, string strSTLGRD, string strSTDCode)
        {
            string sql = "select T.生产日期, T.部门, T.线材生产批次号, T.钢种, T.执行标准, T.钢种类别, T.线材规格, T.线材物料编码, T.线材物料描述, T.钢坯炉号, T.钢坯开坯号, T.钢坯物料编码, T.钢坯物料描述, T.自由项1, T.自由项2, T.自由项3, T.总件数, T.总重量, T.合格件数, T.合格重量  from V_XC_INFO t where 1=1 ";
            if (!string.IsNullOrEmpty(Begin) && !string.IsNullOrEmpty(End))
            {
                sql = sql + " and TO_DATE(t.生产日期,'yyyy-mm-dd hh24:mi:ss') between to_date('" + Convert.ToDateTime(Begin) + "','yyyy-mm-dd hh24:mi:ss') and to_date('" + Convert.ToDateTime(End) + "','yyyy-mm-dd hh24:mi:ss') ";
            }
            if (!string.IsNullOrEmpty(strStove))
            {
                sql = sql + " and t.钢坯炉号 like '" + strStove + "%'";
            }
            if (!string.IsNullOrEmpty(strBatchNo))
            {
                sql = sql + " and t.线材生产批次号 like '" + strBatchNo + "%'";
            }
            if (!string.IsNullOrEmpty(strSTLGRD))
            {
                sql = sql + " and t.钢种 LIKE '%" + strSTLGRD + "%'";
            }
            if (!string.IsNullOrEmpty(strSTDCode))
            {
                sql = sql + " and t.执行标准 LIKE '%" + strSTDCode + "%'";
            }

            sql = sql + " order by t.线材生产批次号 ";

            return DbHelperOra.Query(sql);
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        /// <param name="strStove">炉号</param>
        /// <returns></returns>
        public DataSet GetList_CF_Item(DateTime Begin, DateTime End, string strStove, string strSTLGRD, string strSTDCode)
        {
            string sql = "select T.生产日期, T.连铸机, T.钢种, T.执行标准, T.断面, T.炉号, T.开坯号, T.物料编码, T.物料描述, T.自由项1, T.自由项2, T.支数, T.重量  from V_GP_INFO t where TO_DATE(t.生产日期,'yyyy-mm-dd hh24:mi:ss') between to_date('" + Convert.ToDateTime(Begin) + "','yyyy-mm-dd hh24:mi:ss') and to_date('" + Convert.ToDateTime(End) + "','yyyy-mm-dd hh24:mi:ss') ";

            if (!string.IsNullOrEmpty(strStove))
            {
                sql = sql + " and (t.炉号 like '" + strStove + "%' or t.开坯号 like '" + strStove + "%') ";
            }
            if (!string.IsNullOrEmpty(strSTLGRD))
            {
                sql = sql + " and t.钢种 LIKE '%" + strSTLGRD + "%'";
            }
            if (!string.IsNullOrEmpty(strSTDCode))
            {
                sql = sql + " and t.执行标准 LIKE '%" + strSTDCode + "%'";
            }

            sql = sql + " order by t.炉号 ";

            return DbHelperOra.Query(sql);
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        /// <param name="strStove">炉号</param>
        /// <returns></returns>
        public DataSet GetList_XC(DateTime Begin, DateTime End, string strStove, string strSTLGRD, string strBatch)
        {
            string sql = "select t.*  from V_XC_INFO2 t where TO_DATE(t.生产日期,'yyyy-mm-dd hh24:mi:ss') between to_date('" + Convert.ToDateTime(Begin) + "','yyyy-mm-dd hh24:mi:ss') and to_date('" + Convert.ToDateTime(End) + "','yyyy-mm-dd hh24:mi:ss') ";

            if (!string.IsNullOrEmpty(strStove))
            {
                sql = sql + " and (t.炉号 like '" + strStove + "%' or t.开坯号 like '" + strStove + "%') ";
            }
            if (!string.IsNullOrEmpty(strSTLGRD))
            {
                sql = sql + " and t.线材钢种 LIKE '%" + strSTLGRD + "%'";
            }
            if (!string.IsNullOrEmpty(strBatch))
            {
                sql = sql + " and t.批号 LIKE '" + strBatch + "%'";
            }

            sql = sql + " order by t.批号 ";

            return DbHelperOra.Query(sql);
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        /// <param name="strStove">炉号</param>
        /// <returns></returns>
        public DataSet GetList_CK_CF_Item(string strStove)
        {
            string sql = "SELECT max(to_char(TC.D_CCM_DATE, 'yyyy-mm-dd')) as 生产日期, tb.c_sta_desc as 连铸机, TC.C_STL_GRD as 钢种, TC.C_STD_CODE as 执行标准, TC.C_STOVE as 炉号, tc.c_spec as 断面, tc.n_len as 定尺, tc.c_zyx1 as 自由项1, tc.c_zyx2 as 自由项2 FROM TSC_SLAB_MAIN TC  left join tb_sta tb on tc.c_sta_id = tb.c_id WHERE TC.C_BATCH_NO IS NULL AND TC.C_STOVE IN (" + strStove + ") AND TC.C_IS_QR = 'Y' group by tb.c_sta_desc, tc.c_spec, tc.n_len, tc.c_zyx1, tc.c_zyx2, TC.C_MAT_CODE, TC.C_MAT_NAME, TC.C_STOVE, TC.C_STL_GRD, TC.C_STD_CODE ";

            sql = sql + " order by TC.C_STOVE ";

            return DbHelperOra.Query(sql);
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        /// <param name="strBatchNo">批号</param>
        /// <returns></returns>
        public DataSet GetList_CFXN_Value(string Begin, string End, string strStove, string strBatchNo, string strSTLGRD, string strSTDCode)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from( SELECT DISTINCT TC.C_STOVE,TC.C_BATCH_NO as C_BATCH_NO ,TC.C_STL_GRD,TC.C_STD_CODE,TA.C_VALUE,TB.C_NAME, TA.C_CHARACTER_ID, TB.N_ORDER,''  FROM TQC_COMPRE_ITEM_RESULT TA INNER JOIN TQB_CHARACTER TB ON TB.C_ID = TA.C_CHARACTER_ID INNER JOIN TRC_ROLL_PRODCUT TC ON TC.C_BATCH_NO = TA.C_BATCH_NO  AND TC.C_STL_GRD = TC.C_STL_GRD AND TC.C_STD_CODE = TA.C_STD_CODE  WHERE TA.C_TYPE = '成分'  AND TA.C_VALUE IS NOT NULL AND TA.N_STATUS=1  AND TC.C_IS_QR='Y' AND LENGTH(TC.C_BATCH_NO)=9 ");
            if (!string.IsNullOrEmpty(Begin) && !string.IsNullOrEmpty(End))
            {
                strSql.Append("and tc.D_PRODUCE_DATE between to_date('" + Convert.ToDateTime(Begin) + "','yyyy-mm-dd hh24:mi:ss') and to_date('" + Convert.ToDateTime(End) + "','yyyy-mm-dd hh24:mi:ss') ");
            }
            if (!string.IsNullOrEmpty(strStove))
            {
                strSql.Append(" and TC.C_STOVE like '" + strStove + "%'");
            }
            if (!string.IsNullOrEmpty(strBatchNo))
            {
                strSql.Append(" and TC.C_BATCH_NO like '" + strBatchNo + "%'");
            }
            if (!string.IsNullOrEmpty(strSTLGRD))
            {
                strSql.Append(" and TC.C_STL_GRD LIKE '%" + strSTLGRD + "%'");
            }
            if (!string.IsNullOrEmpty(strSTDCode))
            {
                strSql.Append(" and TC.C_STD_CODE LIKE '%" + strSTDCode + "%'");
            }
            strSql.Append(" ) ");
            strSql.Append(" union all select * from( SELECT DISTINCT TC.C_STOVE,TC.C_BATCH_NO as C_BATCH_NO,TC.C_STL_GRD,TC.C_STD_CODE,TA.C_VALUE,TB.C_NAME||TA.C_GROUP, TA.C_CHARACTER_ID, TB.N_ORDER,TA.C_GROUP  FROM TQC_COMPRE_ITEM_RESULT TA INNER JOIN TQB_CHARACTER TB ON TB.C_ID = TA.C_CHARACTER_ID INNER JOIN TRC_ROLL_PRODCUT TC ON  TC.C_BATCH_NO = TA.C_BATCH_NO  AND TC.C_STL_GRD = TC.C_STL_GRD AND TC.C_STD_CODE = TA.C_STD_CODE WHERE TA.C_TYPE = '性能' AND TB.C_NAME NOT IN ('冷顶锻', '热顶锻试验', '冷弯试验') AND TA.C_VALUE IS NOT NULL AND TA.N_STATUS=1   AND TC.C_IS_QR='Y' AND LENGTH(TC.C_BATCH_NO)=9 ");

            if (!string.IsNullOrEmpty(Begin) && !string.IsNullOrEmpty(End))
            {
                strSql.Append("and tc.D_PRODUCE_DATE between to_date('" + Convert.ToDateTime(Begin) + "','yyyy-mm-dd hh24:mi:ss') and to_date('" + Convert.ToDateTime(End) + "','yyyy-mm-dd hh24:mi:ss') ");
            }
            if (!string.IsNullOrEmpty(strStove))
            {
                strSql.Append(" and TC.C_STOVE like '" + strStove + "%'");
            }
            if (!string.IsNullOrEmpty(strBatchNo))
            {
                strSql.Append(" and TC.C_BATCH_NO like '" + strBatchNo + "%'");
            }
            if (!string.IsNullOrEmpty(strSTLGRD))
            {
                strSql.Append(" and TC.C_STL_GRD LIKE '%" + strSTLGRD + "%'");
            }
            if (!string.IsNullOrEmpty(strSTDCode))
            {
                strSql.Append(" and TC.C_STD_CODE LIKE '%" + strSTDCode + "%'");
            }
            strSql.Append(" ) ");

            strSql.Append(" union all select * from(SELECT TC.C_STOVE,TC.C_BATCH_NO as C_BATCH_NO, TC.C_STL_GRD, TC.C_STD_CODE, max(TA.C_VALUE), TB.C_NAME, TA.C_CHARACTER_ID, MAX(TB.N_ORDER), MAX(TA.C_GROUP) FROM TQC_COMPRE_ITEM_RESULT TA INNER JOIN TQB_CHARACTER TB ON TB.C_ID = TA.C_CHARACTER_ID INNER JOIN TRC_ROLL_PRODCUT TC ON TC.C_BATCH_NO = TA.C_BATCH_NO AND TC.C_STL_GRD = TC.C_STL_GRD AND TC.C_STD_CODE = TA.C_STD_CODE WHERE TA.C_TYPE = '性能' AND TB.C_NAME IN('冷顶锻', '热顶锻试验', '冷弯试验') AND TA.C_VALUE IS NOT NULL AND TA.N_STATUS = 1 AND TC.C_IS_QR = 'Y' AND LENGTH(TC.C_BATCH_NO)=9  ");

            if (!string.IsNullOrEmpty(Begin) && !string.IsNullOrEmpty(End))
            {
                strSql.Append(" and tc.D_PRODUCE_DATE between to_date('" + Convert.ToDateTime(Begin) + "','yyyy-mm-dd hh24:mi:ss') and to_date('" + Convert.ToDateTime(End) + "','yyyy-mm-dd hh24:mi:ss') ");
            }
            if (!string.IsNullOrEmpty(strStove))
            {
                strSql.Append(" and TC.C_STOVE like '" + strStove + "%'");
            }
            if (!string.IsNullOrEmpty(strBatchNo))
            {
                strSql.Append(" and TC.C_BATCH_NO like '" + strBatchNo + "%'");
            }
            if (!string.IsNullOrEmpty(strSTLGRD))
            {
                strSql.Append(" and TC.C_STL_GRD LIKE '%" + strSTLGRD + "%'");
            }
            if (!string.IsNullOrEmpty(strSTDCode))
            {
                strSql.Append(" and TC.C_STD_CODE LIKE '%" + strSTDCode + "%'");
            }
            strSql.Append(" group by TC.C_STOVE, TC.C_BATCH_NO, TC.C_STL_GRD, TC.C_STD_CODE, TB.C_NAME, TA.C_CHARACTER_ID) ");

            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        /// <param name="strStove">炉号</param>
        /// <returns></returns>
        public DataSet GetList_CF_Value(DateTime Begin, DateTime End, string strStove, string strSTLGRD, string strSTDCode)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT TC.C_STOVE, TC.C_STL_GRD, TC.C_STD_CODE, MAX(TA.C_VALUE) AS C_VALUE, TB.C_NAME  FROM TQC_COMPRE_ITEM_RESULT TA INNER JOIN TQB_CHARACTER TB ON TB.C_ID = TA.C_CHARACTER_ID INNER JOIN tsc_slab_main TC ON tc.c_stove = TA.C_STOVE AND TC.C_STL_GRD = TC.C_STL_GRD   AND TC.C_STD_CODE = TA.C_STD_CODE WHERE TA.C_TYPE = '成分' AND TA.C_BATCH_NO IS NULL AND TA.C_VALUE IS NOT NULL AND TA.N_STATUS = 1 AND TC.C_IS_QR = 'Y' ");

            if (Begin != null && Begin != null)
            {
                strSql.Append("and tc.D_CCM_DATE between to_date('" + Convert.ToDateTime(Begin) + "','yyyy-mm-dd hh24:mi:ss') and to_date('" + Convert.ToDateTime(End) + "','yyyy-mm-dd hh24:mi:ss') ");
            }
            if (!string.IsNullOrEmpty(strStove))
            {
                strSql.Append(" and (TC.C_STOVE like '%" + strStove + "%' OR TC.C_BATCH_NO like '%" + strStove + "%') ");
            }
            if (!string.IsNullOrEmpty(strSTLGRD))
            {
                strSql.Append(" and Ta.C_STL_GRD LIKE '%" + strSTLGRD + "%'");
            }
            if (!string.IsNullOrEmpty(strSTDCode))
            {
                strSql.Append(" and Ta.C_STD_CODE LIKE '%" + strSTDCode + "%'");
            }

            strSql.Append(" GROUP BY TC.C_STOVE,TC.C_STL_GRD,TC.C_STD_CODE,TB.C_NAME ");

            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得成分原始值
        /// </summary>
        /// <param name="strStove">炉号</param>
        /// <returns></returns>
        public DataSet GetList_CF_YSZ_Value()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT TB.C_NAME, TA.N_ORIGINALVALUE, ta.c_stove  FROM TQC_QUA_RESULT TA inner join tqb_character tb    ON UPPER(TA.C_ANAITEM) = UPPER(TB.C_NAME) WHERE TA.C_IS_PD = 1 and tb.n_status=1 ");


            return DbHelperOra.Query(strSql.ToString());
        }


        /// <summary>
        /// 获得数据列表
        /// </summary>
        /// <param name="strStove">炉号</param>
        /// <returns></returns>
        public DataSet GetList_CK_CF_Value(string strStove)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT TA.C_STOVE, TA.C_STL_GRD, TA.C_STD_CODE, MAX(TA.C_VALUE) AS C_VALUE, TB.C_NAME  FROM TQC_COMPRE_ITEM_RESULT TA INNER JOIN TQB_CHARACTER TB ON TB.C_ID = TA.C_CHARACTER_ID WHERE TA.C_TYPE = '成分' AND TA.C_BATCH_NO IS NULL AND TA.C_VALUE IS NOT NULL AND TA.N_STATUS = 1 ");

            if (!string.IsNullOrEmpty(strStove))
            {
                strSql.Append(" and TA.C_STOVE IN (" + strStove + ") ");
            }

            strSql.Append(" GROUP BY TA.C_STOVE, TA.C_STL_GRD, TA.C_STD_CODE, TB.C_NAME ");

            return DbHelperOra.Query(strSql.ToString());
        }


        /// <summary>
        /// 获得数据列表
        /// </summary>
        /// <param name="strBatchNo">批号</param>
        /// <returns></returns>
        public DataSet GetList_CFXN_Value_CKC(string strBatchNo)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from( SELECT DISTINCT TC.C_STOVE,TC.C_BATCH_NO,TC.C_STL_GRD,TC.C_STD_CODE,TA.C_VALUE,TB.C_NAME, TA.C_CHARACTER_ID, TB.N_ORDER,''  FROM TQC_COMPRE_ITEM_RESULT TA INNER JOIN TQB_CHARACTER TB ON TB.C_ID = TA.C_CHARACTER_ID INNER JOIN TRC_ROLL_PRODCUT TC ON TC.C_BATCH_NO = TA.C_BATCH_NO  AND TC.C_STL_GRD = TC.C_STL_GRD AND TC.C_STD_CODE = TA.C_STD_CODE  WHERE TA.C_TYPE = '成分'  AND TA.C_VALUE IS NOT NULL AND TA.N_STATUS=1  AND TC.C_IS_QR='Y'    ");

            if (!string.IsNullOrEmpty(strBatchNo))
            {
                strSql.Append(" and TC.C_BATCH_NO in (" + strBatchNo + ") ");
            }

            strSql.Append(" ) ");
            strSql.Append(" union all select * from( SELECT DISTINCT TC.C_STOVE,TC.C_BATCH_NO,TC.C_STL_GRD,TC.C_STD_CODE,TA.C_VALUE,TB.C_NAME||TA.C_GROUP, TA.C_CHARACTER_ID, TB.N_ORDER,TA.C_GROUP  FROM TQC_COMPRE_ITEM_RESULT TA INNER JOIN TQB_CHARACTER TB ON TB.C_ID = TA.C_CHARACTER_ID INNER JOIN TRC_ROLL_PRODCUT TC ON TC.C_BATCH_NO = TA.C_BATCH_NO  AND TC.C_STL_GRD = TC.C_STL_GRD AND TC.C_STD_CODE = TA.C_STD_CODE WHERE TA.C_TYPE = '性能' AND TB.C_NAME NOT IN ('冷顶锻', '热顶锻试验', '冷弯试验') AND TA.C_VALUE IS NOT NULL AND TA.N_STATUS=1   AND TC.C_IS_QR='Y' ");


            if (!string.IsNullOrEmpty(strBatchNo))
            {
                strSql.Append(" and TC.C_BATCH_NO in( " + strBatchNo + ") ");
            }

            strSql.Append(" ) ");

            strSql.Append(" union all select * from(SELECT TC.C_STOVE,TC.C_BATCH_NO, TC.C_STL_GRD, TC.C_STD_CODE, max(TA.C_VALUE), TB.C_NAME, TA.C_CHARACTER_ID, MAX(TB.N_ORDER), MAX(TA.C_GROUP) FROM TQC_COMPRE_ITEM_RESULT TA INNER JOIN TQB_CHARACTER TB ON TB.C_ID = TA.C_CHARACTER_ID INNER JOIN TRC_ROLL_PRODCUT TC ON TC.C_BATCH_NO = TA.C_BATCH_NO AND TC.C_STL_GRD = TC.C_STL_GRD AND TC.C_STD_CODE = TA.C_STD_CODE WHERE TA.C_TYPE = '性能' AND TB.C_NAME IN('冷顶锻', '热顶锻试验', '冷弯试验') AND TA.C_VALUE IS NOT NULL AND TA.N_STATUS = 1 AND TC.C_IS_QR = 'Y'  ");


            if (!string.IsNullOrEmpty(strBatchNo))
            {
                strSql.Append(" and TC.C_BATCH_NO in (" + strBatchNo + ") ");
            }

            strSql.Append(" group by TC.C_STOVE, TC.C_BATCH_NO, TC.C_STL_GRD, TC.C_STD_CODE, TB.C_NAME, TA.C_CHARACTER_ID) ");

            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取成分列表
        /// </summary>
        /// <param name="strStove">炉号</param>
        /// <param name="strGrd">钢种</param>
        /// <param name="strSpec">规格</param>
        /// <param name="strStdCode">执行标准</param>
        /// <returns></returns>
        public DataSet GetListCF(string strStove, string strGrd, string strSpec, string strStdCode)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select tb.c_code,t.c_item_name,t.c_target_min,t.c_target_interval,t.c_target_max,t.c_value,decode(t.c_result,'Y','合格','不合格') as C_RESULT,decode(t.c_check_state,'0','初检','1','复检','评审')as C_CHECK_STATE ");
            strSql.Append(" FROM TQC_COMPRE_ITEM_RESULT t inner join tqb_character tb on t.c_character_id=tb.c_id where 1=1 AND T.C_IS_DECIDE = '是' and C_BATCH_NO is null");

            if (strStove.Trim() != "")
            {
                strSql.Append(" and C_STOVE = '" + strStove + "' ");
            }
            if (strGrd.Trim() != "")
            {
                strSql.Append(" and C_STL_GRD = '" + strGrd + "' ");
            }
            if (strSpec.Trim() != "")
            {
                strSql.Append(" and C_SPEC = '" + strSpec + "' ");
            }
            if (strStdCode.Trim() != "")
            {
                strSql.Append(" and C_STD_CODE = '" + strStdCode + "' ");
            }

            strSql.Append(" order by t.N_PRINT_ORDER ");

            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取成分列表
        /// </summary>
        /// <param name="strStove">炉号</param>
        /// <param name="strGrd">钢种</param>
        /// <param name="strSpec">规格</param>
        /// <param name="strStdCode">执行标准</param>
        /// <param name="strBatch">批号</param>
        /// <returns></returns>
        public DataSet GetListCF(string strStove, string strGrd, string strSpec, string strStdCode, string strBatch)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select tb.c_code,t.c_item_name,t.c_target_min,t.c_target_interval,t.c_target_max,t.c_value,decode(t.c_result,'Y','合格','N','不合格','E','数据有误') as C_RESULT,decode(t.c_check_state,'0','初检','1','复检','评审')as C_CHECK_STATE,T.C_IS_DECIDE,T.C_IS_SHOW ");
            strSql.Append(" FROM TQC_COMPRE_ITEM_RESULT t inner join tqb_character tb on t.c_character_id=tb.c_id where 1=1 and t.C_TYPE='成分' AND T.N_STATUS = 1 AND((T.C_IS_SHOW = '是' or t.c_is_decide = '是')) ");

            if (strStove.Trim() != "")
            {
                strSql.Append(" and C_STOVE = '" + strStove + "' ");
            }
            if (strGrd.Trim() != "")
            {
                strSql.Append(" and C_STL_GRD = '" + strGrd + "' ");
            }
            if (strSpec.Trim() != "")
            {
                strSql.Append(" and C_SPEC = '" + strSpec + "' ");
            }
            if (strStdCode.Trim() != "")
            {
                strSql.Append(" and C_STD_CODE = '" + strStdCode + "' ");
            }

            if (strBatch.Trim() != "")
            {
                strSql.Append(" and C_BATCH_NO = '" + strBatch + "' ");
            }

            strSql.Append(" order by t.N_PRINT_ORDER ");

            return DbHelperOra.Query(strSql.ToString());
        }


        /// <summary>
        /// 获取性能列表
        /// </summary>
        /// <param name="strBatch">批号</param>
        /// <param name="strGrd">钢种</param>
        /// <param name="strSpec">规格</param>
        /// <param name="strStdCode">执行标准</param>
        /// <returns></returns>
        public DataSet GetListXN(string strBatch, string strGrd, string strSpec, string strStdCode)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select tb.c_code,t.c_item_name,t.c_target_min,t.c_target_interval,t.c_target_max,t.c_value,decode(t.c_result,'Y','合格','N','不合格','E','数据有误') as C_RESULT,decode(t.c_check_state,'0','初检','1','复检','评审')as C_CHECK_STATE,T.C_IS_DECIDE,T.C_IS_SHOW ");
            strSql.Append(" FROM TQC_COMPRE_ITEM_RESULT t inner join tqb_character tb on t.c_character_id=tb.c_id where 1=1 and t.C_TYPE='性能' AND T.N_STATUS=1 AND ((T.C_IS_SHOW='是' or t.c_is_decide='是')) ");

            if (strBatch.Trim() != "")
            {
                strSql.Append(" and C_BATCH_NO = '" + strBatch + "' ");
            }
            if (strGrd.Trim() != "")
            {
                strSql.Append(" and C_STL_GRD = '" + strGrd + "' ");
            }
            if (strSpec.Trim() != "")
            {
                strSql.Append(" and C_SPEC = '" + strSpec + "' ");
            }
            if (strStdCode.Trim() != "")
            {
                strSql.Append(" and C_STD_CODE = '" + strStdCode + "' ");
            }

            strSql.Append(" order by t.c_item_name ");

            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM TQC_COMPRE_ITEM_RESULT ");
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
            strSql.Append(")AS Row, T.*  from TQC_COMPRE_ITEM_RESULT T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            return DbHelperOra.Query(strSql.ToString());
        }


        #endregion  BasicMethod
        #region  ExtensionMethod

        /// <summary>
        /// 分组获取数据
        /// </summary>
        /// <param name="begin">开始时间</param>
        /// <param name="end">结束时间</param>
        /// <param name="c_stove">炉号</param>
        /// <param name="c_batch_no">批号</param>
        /// <param name="C_IS_QR">综判是否确认</param>
        /// <returns></returns>
        public DataSet GetList_Group(DateTime begin, DateTime end, string c_stove, string c_batch_no, string C_IS_QR)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT   B.C_STA_DESC,  T.C_STOVE,  T.C_BATCH_NO, T.C_STL_GRD, T.C_SPEC, T.C_STD_CODE,  MAX(T.D_MOD_DT) DT  FROM TQC_COMPRE_ITEM_RESULT T  JOIN TRC_ROLL_PRODCUT A  ON T.C_BATCH_NO = A.C_BATCH_NO JOIN TB_STA B ON A.C_STA_ID = B.C_ID WHERE T.C_RESULT = 'N' AND T.C_BATCH_NO IS NOT NULL  AND ((T.C_TYPE = '性能') OR (T.C_ITEM_NAME IN ('O', 'N', 'H')))    ");
            if (begin != null && end != null)
            {
                strSql.Append(" and t.d_mod_dt between to_date('" + Convert.ToDateTime(begin) + "','yyyy-mm-dd hh24:mi:ss') and to_date('" + Convert.ToDateTime(end) + "','yyyy-mm-dd hh24:mi:ss') ");
            }
            if (c_stove.Trim() != "")
            {
                strSql.Append(" and t.c_stove like '%" + c_stove + "%'");
            }
            if (c_batch_no.Trim() != "")
            {
                strSql.Append(" and t.c_batch_no like '%" + c_batch_no + "%'");
            }
            if (C_IS_QR.Trim() != "")
            {
                strSql.Append("  AND A.C_IS_QR ='" + C_IS_QR + "' ");
            }
            strSql.Append(" GROUP BY  B.C_STA_DESC,  T.C_STOVE,   T.C_BATCH_NO,  T.C_STL_GRD,  T.C_SPEC,  T.C_STD_CODE  ");
            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 获取项目名称
        /// </summary>
        /// <param name="c_stove">炉号</param>
        /// <param name="c_batch_no">批号</param>
        /// <returns></returns>
        public DataSet GetList_ItemName(string c_stove, string c_batch_no)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select max(ta.c_id) as C_ID , tb.c_name ,tb.c_code");
            strSql.Append("  from TQC_COMPRE_ITEM_RESULT ta inner join tqc_physics_result_main td on ta.c_batch_no = td.c_batch_no inner join tqb_physics_group tb on tb.c_id = td.c_physics_group_id inner join tqb_physics_configure tc on tc.c_physics_group_id = td.c_physics_group_id and ta.c_character_id = tc.c_character_id where ta.c_result = 'N' ");
            if (c_stove.Trim() != "")
            {
                strSql.Append(" and ta.c_stove ='" + c_stove + "'");
            }
            if (c_batch_no.Trim() != "")
            {
                strSql.Append(" and ta.c_batch_no ='" + c_batch_no + "'");
            }

            strSql.Append(" group by tb.c_name,tb.c_code");
            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 获取项目名称
        /// </summary>
        /// <param name="c_stove">炉号</param>
        /// <param name="c_batch_no">批号</param>
        /// <returns></returns>
        public DataSet Get_Item(string c_stove, string c_batch_no, string code)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select max(ta.c_id) as C_ID , tb.c_name ,tb.c_code,ta.c_item_name,ta.c_item_name");
            strSql.Append("  from TQC_COMPRE_ITEM_RESULT ta inner join tqc_physics_result_main td on ta.c_batch_no = td.c_batch_no inner join tqb_physics_group tb on tb.c_id = td.c_physics_group_id inner join tqb_physics_configure tc on tc.c_physics_group_id = td.c_physics_group_id and ta.c_character_id = tc.c_character_id where ta.c_result = 'N' and tb.c_code='" + code + "' ");
            if (c_stove.Trim() != "")
            {
                strSql.Append(" and ta.c_stove ='" + c_stove + "'");
            }
            if (c_batch_no.Trim() != "")
            {
                strSql.Append(" and ta.c_batch_no ='" + c_batch_no + "'");
            }

            strSql.Append(" group by tb.c_name,tb.c_code,ta.c_item_name");
            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 查询成分值信息
        /// </summary>
        /// <param name="P_BATCH">批号</param>
        /// <param name="P_STD_CODE">执行标准</param>
        /// <param name="P_STL_GRD">钢种</param>
        /// <returns></returns>
		public DataSet Get_CF_List(string P_BATCH, string P_STD_CODE, string P_STL_GRD)
        {
            OracleParameter[] parameters = {
                    new OracleParameter("P_BATCH", OracleDbType.Varchar2,100),
                    new OracleParameter("P_STD_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter("P_STL_GRD", OracleDbType.Varchar2,100),
                    new OracleParameter("P_CUR", OracleDbType.RefCursor)};

            parameters[0].Value = P_BATCH;
            parameters[1].Value = P_STD_CODE;
            parameters[2].Value = P_STL_GRD;
            parameters[3].Value = null;

            return DbHelperOra.RunProcedure("PKG_ZBS.P_XC_CF_VALUE", parameters, "ds");
        }

        /// <summary>
        /// 获取需要同步的批号信息
        /// </summary>
        /// <returns></returns>
        public DataSet Get_Tb_List(string c_batch_no)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT T.C_BATCH_NO, T.C_MAT_CODE, SUBSTR(T.C_MAT_CODE, 1, 3) as MATTYPE, T.C_MAT_DESC, T.C_STL_GRD, T.C_STD_CODE, T.C_SPEC, T.C_DESIGN_NO, T.C_STOVE,T.N_SFOB  FROM TRC_ROLL_PRODCUT T WHERE 1 = 1  ");

            if (!string.IsNullOrEmpty(c_batch_no))
            {
                strSql.Append(" and t.c_batch_no = '" + c_batch_no + "' ");
            }

            strSql.Append(" GROUP BY T.C_BATCH_NO, T.C_MAT_CODE, T.C_MAT_DESC, T.C_STL_GRD, T.C_STD_CODE, T.C_SPEC, T.C_DESIGN_NO, T.C_STOVE,T.N_SFOB ");

            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取需要同步的批号信息
        /// </summary>
        /// <returns></returns>
        public DataSet Get_Tb_List_Old()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT C_BATCH_NO,C_MAT_CODE,MATTYPE,C_MAT_DESC,C_STL_GRD,C_STD_CODE,C_SPEC,C_DESIGN_NO,C_STOVE,N_SFOB  FROM(SELECT T.C_BATCH_NO,T.C_MAT_CODE,SUBSTR(T.C_MAT_CODE, 1, 3) as MATTYPE,T.C_MAT_DESC,T.C_STL_GRD,T.C_STD_CODE,T.C_SPEC, T.C_DESIGN_NO,T.C_STOVE,TB.C_BATCH_NO AS BATCHEXISTS,N_SFOB FROM TRC_ROLL_PRODCUT T LEFT JOIN TQC_COMPRE_ITEM_RESULT TB ON T.C_BATCH_NO = TB.C_BATCH_NO and tb.c_stl_grd=t.c_stl_grd and t.c_std_code=tb.c_std_code WHERE T.N_SFOB = 1 GROUP BY T.C_BATCH_NO, T.C_MAT_CODE, T.C_MAT_DESC, T.C_STL_GRD, T.C_STD_CODE, T.C_SPEC, T.C_DESIGN_NO,T.C_STOVE, TB.C_BATCH_NO,N_SFOB) WHERE BATCHEXISTS IS NULL ");

            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取NC成分性能信息（碳钢或者深加工产品编码为807、806开头）
        /// </summary>
        /// <param name="strBatch">批号</param>
        /// <returns></returns>
        public DataSet Get_NC_Item_List_PT(string strBatch)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select distinct qc_checkbill_b1.vinvbatchcode,qc_checkbill_b2.vsamplecode,qc_checkbill_b2.cresult,qc_checkitem.ccheckitemcode,qc_checkitem.ccheckitemname  from XGERP50.qc_checkbill, XGERP50.qc_checkbill_b1, XGERP50.qc_checkbill_b2, XGERP50.qc_checkitem where qc_checkbill.ccheckbillid = qc_checkbill_b2.ccheckbillid and qc_checkbill.ccheckbillid = qc_checkbill_b1.ccheckbillid and qc_checkbill_b1.vinvbatchcode = '" + strBatch + "' and qc_checkbill_b2.ccheckitemid = qc_checkitem.ccheckitemid and qc_checkbill.ccheckbillid = XGERP50.capgetfinalcheckbillid('" + strBatch + "') and qc_checkbill.dr = 0 and qc_checkbill_b1.dr = 0 and qc_checkbill_b2.dr = 0 union all select distinct qc_checkbill_b1.vinvbatchcode, qc_checkbill_b2.vsamplecode, qc_checkbill_b2.cresult, qc_checkitem.ccheckitemcode, qc_checkitem.ccheckitemname  from XGERP50.qc_checkbill, XGERP50.qc_checkbill_b1, XGERP50.qc_checkbill_b2, XGERP50.qc_checkitem where qc_checkbill.ccheckbillid = qc_checkbill_b2.ccheckbillid and qc_checkbill.ccheckbillid = qc_checkbill_b1.ccheckbillid   and qc_checkbill_b1.vinvbatchcode = XGERP50.getccmbatchcode('" + strBatch + "')   and qc_checkbill_b2.ccheckitemid = qc_checkitem.ccheckitemid and qc_checkbill.ccheckbillid = XGERP50.capgetfinalcheckbillid(XGERP50.getccmbatchcode('" + strBatch + "')) and qc_checkbill.dr = 0 and qc_checkbill_b1.dr = 0 and qc_checkbill_b2.dr = 0 ORDER BY ccheckitemcode ");

            return DbHelperNC.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取NC成分性能信息（深加工产品编码805开头）
        /// </summary>
        /// <param name="strBatch">批号</param>
        /// <returns></returns>
        public DataSet Get_NC_Item_List_WW(string strBatch)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select qc_checkbill_b1.vinvbatchcode,qc_checkbill_b2.vsamplecode,qc_checkbill_b2.cresult,qc_checkitem.ccheckitemcode,qc_checkitem.ccheckitemname  from XGERP50.qc_checkbill, XGERP50.qc_checkbill_b1, XGERP50.qc_checkbill_b2, XGERP50.qc_checkitem where qc_checkbill.ccheckbillid = qc_checkbill_b2.ccheckbillid and qc_checkbill.ccheckbillid = qc_checkbill_b1.ccheckbillid and qc_checkbill_b1.vinvbatchcode = XGERP50.get_hpc_batchcode('" + strBatch + "') and qc_checkbill_b2.ccheckitemid = qc_checkitem.ccheckitemid and qc_checkbill.ccheckbillid = XGERP50.capgetfinalcheckbillid(XGERP50.get_hpc_batchcode('" + strBatch + "'))   and qc_checkbill.dr = 0 and qc_checkbill_b1.dr = 0 and qc_checkbill_b2.dr = 0 union all select qc_checkbill_b1.vinvbatchcode, qc_checkbill_b2.vsamplecode, qc_checkbill_b2.cresult, qc_checkitem.ccheckitemcode, qc_checkitem.ccheckitemname from XGERP50.qc_checkbill, XGERP50.qc_checkbill_b1, XGERP50.qc_checkbill_b2, XGERP50.qc_checkitem where qc_checkbill.ccheckbillid = qc_checkbill_b2.ccheckbillid and qc_checkbill.ccheckbillid = qc_checkbill_b1.ccheckbillid   and qc_checkbill_b1.vinvbatchcode = XGERP50.getccmbatchcode('" + strBatch + "') and qc_checkbill_b2.ccheckitemid = qc_checkitem.ccheckitemid and qc_checkbill.ccheckbillid = XGERP50.capgetfinalcheckbillid(XGERP50.getccmbatchcode('" + strBatch + "')) and qc_checkbill.dr = 0 and qc_checkbill_b1.dr = 0 and qc_checkbill_b2.dr = 0 ORDER BY ccheckitemcode ");

            return DbHelperNC.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取已同步的成分性能信息
        /// </summary>
        /// <returns></returns>
        public DataSet Get_Item_List(string C_BATCH_NO, string C_STL_GRD, string C_STD_CODE)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select TA.C_ID,TA.C_SOURCE,TB.C_CODE,TB.C_NAME,TA.C_VALUE,TA.C_GROUP AS SAMCODE from TQC_COMPRE_ITEM_RESULT ta inner join tqb_character tb on ta.c_character_id=tb.c_id WHERE  TA.C_BATCH_NO='" + C_BATCH_NO + "' AND TA.C_STL_GRD='" + C_STL_GRD + "' AND TA.C_STD_CODE='" + C_STD_CODE + "' ORDER BY TB.C_CODE,TA.C_GROUP ");

            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete_Trans(string strBatch, string strBz, string strGz)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from TQC_COMPRE_ITEM_RESULT where C_BATCH_NO='" + strBatch + "' and C_STL_GRD='" + strGz + "' and C_STD_CODE='" + strBz + "' and C_TB='Y' ");

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
        /// 得到一个对象实体
        /// </summary>
        public Mod_TQC_COMPRE_ITEM_RESULT GetModel(string c_batch_no, string c_stl_grd, string c_std_code)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_STOVE,C_BATCH_NO,C_STL_GRD,C_SPEC,C_STD_CODE,C_CHARACTER_ID,C_ITEM_NAME,C_TARGET_MIN,C_TARGET_INTERVAL,C_TARGET_MAX,C_TYPE,C_UNIT,C_QUANTITATIVE,C_VALUE,C_RESULT,C_CHECK_STATE,N_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT,C_DESIGN_NO,N_PRINT_ORDER,C_TICK_NO,C_IS_SHOW,C_IS_DECIDE,C_GROUP,C_TB,C_SOURCE from TQC_COMPRE_ITEM_RESULT ");
            strSql.Append(" where C_BATCH_NO='" + c_batch_no + "' and C_STL_GRD='" + c_stl_grd + "' and C_STD_CODE='" + c_std_code + "' ");

            Mod_TQC_COMPRE_ITEM_RESULT model = new Mod_TQC_COMPRE_ITEM_RESULT();
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
        /// 获取记录总数
        /// </summary>
        public int Get_Max_Group(string c_batch_no, string c_stove, string c_stl_grd, string c_std_code, string c_character_id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select nvl(max(t.c_group),0) from tqc_compre_item_result t where t.c_batch_no='" + c_batch_no + "' and t.c_stove='" + c_stove + "' and t.c_stl_grd='" + c_stl_grd + "' and t.c_std_code='" + c_std_code + "' and t.c_character_id='" + c_character_id + "' ");

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

        #endregion  ExtensionMethod
    }
}

