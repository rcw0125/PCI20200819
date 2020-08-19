using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;
namespace DAL
{
    /// <summary>
    /// 数据访问类:TQB_STD_CFXN
    /// </summary>
    public partial class Dal_TQB_STD_CFXN
    {
        public Dal_TQB_STD_CFXN()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string C_STD_MAIN_ID, string C_CHARACTER_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TQB_STD_CFXN");
            strSql.Append(" where C_STD_MAIN_ID='" + C_STD_MAIN_ID + "' AND C_CHARACTER_ID='" + C_CHARACTER_ID + "' ");


            return DbHelperOra.Exists(strSql.ToString());
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Mod_TQB_STD_CFXN model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TQB_STD_CFXN(");
            strSql.Append("C_STD_MAIN_ID,C_CHARACTER_ID,C_TARGET_MIN,C_TARGET_INTERVAL,C_TARGET_MAX,C_PREWARNING_VALUE,C_TYPE,C_IS_DECIDE,C_IS_PRINT,N_PRINT_ORDER,N_SPEC_MIN,C_SPEC_INTERVAL,N_SPEC_MAX,C_FORMULA,C_UNIT,N_DIGIT,C_QUANTITATIVE,C_TEST_TEM,C_TEST_CONDITION,N_STATUS,C_REMARK,C_EMP_ID,C_ITEM_NAME)");
            strSql.Append(" values (");
            strSql.Append(":C_STD_MAIN_ID,:C_CHARACTER_ID,:C_TARGET_MIN,:C_TARGET_INTERVAL,:C_TARGET_MAX,:C_PREWARNING_VALUE,:C_TYPE,:C_IS_DECIDE,:C_IS_PRINT,:N_PRINT_ORDER,:N_SPEC_MIN,:C_SPEC_INTERVAL,:N_SPEC_MAX,:C_FORMULA,:C_UNIT,:N_DIGIT,:C_QUANTITATIVE,:C_TEST_TEM,:C_TEST_CONDITION,:N_STATUS,:C_REMARK,:C_EMP_ID,:C_ITEM_NAME)");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_STD_MAIN_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CHARACTER_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_TARGET_MIN", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_TARGET_INTERVAL", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_TARGET_MAX", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PREWARNING_VALUE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_TYPE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_IS_DECIDE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_IS_PRINT", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_PRINT_ORDER", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_SPEC_MIN", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SPEC_INTERVAL", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_SPEC_MAX", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_FORMULA", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_UNIT", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_DIGIT", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_QUANTITATIVE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_TEST_TEM", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_TEST_CONDITION", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ITEM_NAME", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.C_STD_MAIN_ID;
            parameters[1].Value = model.C_CHARACTER_ID;
            parameters[2].Value = model.C_TARGET_MIN;
            parameters[3].Value = model.C_TARGET_INTERVAL;
            parameters[4].Value = model.C_TARGET_MAX;
            parameters[5].Value = model.C_PREWARNING_VALUE;
            parameters[6].Value = model.C_TYPE;
            parameters[7].Value = model.C_IS_DECIDE;
            parameters[8].Value = model.C_IS_PRINT;
            parameters[9].Value = model.N_PRINT_ORDER;
            parameters[10].Value = model.N_SPEC_MIN;
            parameters[11].Value = model.C_SPEC_INTERVAL;
            parameters[12].Value = model.N_SPEC_MAX;
            parameters[13].Value = model.C_FORMULA;
            parameters[14].Value = model.C_UNIT;
            parameters[15].Value = model.N_DIGIT;
            parameters[16].Value = model.C_QUANTITATIVE;
            parameters[17].Value = model.C_TEST_TEM;
            parameters[18].Value = model.C_TEST_CONDITION;
            parameters[19].Value = model.N_STATUS;
            parameters[20].Value = model.C_REMARK;
            parameters[21].Value = model.C_EMP_ID;
            parameters[22].Value = model.C_ITEM_NAME;

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
        public bool Update(Mod_TQB_STD_CFXN model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TQB_STD_CFXN set ");
            strSql.Append("C_STD_MAIN_ID=:C_STD_MAIN_ID,");
            strSql.Append("C_CHARACTER_ID=:C_CHARACTER_ID,");
            strSql.Append("C_TARGET_MIN=:C_TARGET_MIN,");
            strSql.Append("C_TARGET_INTERVAL=:C_TARGET_INTERVAL,");
            strSql.Append("C_TARGET_MAX=:C_TARGET_MAX,");
            strSql.Append("C_PREWARNING_VALUE=:C_PREWARNING_VALUE,");
            strSql.Append("C_TYPE=:C_TYPE,");
            strSql.Append("C_IS_DECIDE=:C_IS_DECIDE,");
            strSql.Append("C_IS_PRINT=:C_IS_PRINT,");
            strSql.Append("N_PRINT_ORDER=:N_PRINT_ORDER,");
            strSql.Append("N_SPEC_MIN=:N_SPEC_MIN,");
            strSql.Append("C_SPEC_INTERVAL=:C_SPEC_INTERVAL,");
            strSql.Append("N_SPEC_MAX=:N_SPEC_MAX,");
            strSql.Append("C_FORMULA=:C_FORMULA,");
            strSql.Append("C_UNIT=:C_UNIT,");
            strSql.Append("N_DIGIT=:N_DIGIT,");
            strSql.Append("C_QUANTITATIVE=:C_QUANTITATIVE,");
            strSql.Append("C_TEST_TEM=:C_TEST_TEM,");
            strSql.Append("C_TEST_CONDITION=:C_TEST_CONDITION,");
            strSql.Append("N_STATUS=:N_STATUS,");
            strSql.Append("C_REMARK=:C_REMARK,");
            strSql.Append("C_EMP_ID=:C_EMP_ID,");
            strSql.Append("D_MOD_DT=:D_MOD_DT,");
            strSql.Append("C_ITEM_NAME=:C_ITEM_NAME");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_STD_MAIN_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CHARACTER_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_TARGET_MIN", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_TARGET_INTERVAL", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_TARGET_MAX", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PREWARNING_VALUE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_TYPE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_IS_DECIDE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_IS_PRINT", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_PRINT_ORDER", OracleDbType.Decimal,3),
                    new OracleParameter(":N_SPEC_MIN", OracleDbType.Decimal,6),
                    new OracleParameter(":C_SPEC_INTERVAL", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_SPEC_MAX", OracleDbType.Decimal,6),
                    new OracleParameter(":C_FORMULA", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_UNIT", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_DIGIT", OracleDbType.Decimal,1),
                    new OracleParameter(":C_QUANTITATIVE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_TEST_TEM", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_TEST_CONDITION", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,3),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":C_ITEM_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.C_STD_MAIN_ID;
            parameters[1].Value = model.C_CHARACTER_ID;
            parameters[2].Value = model.C_TARGET_MIN;
            parameters[3].Value = model.C_TARGET_INTERVAL;
            parameters[4].Value = model.C_TARGET_MAX;
            parameters[5].Value = model.C_PREWARNING_VALUE;
            parameters[6].Value = model.C_TYPE;
            parameters[7].Value = model.C_IS_DECIDE;
            parameters[8].Value = model.C_IS_PRINT;
            parameters[9].Value = model.N_PRINT_ORDER;
            parameters[10].Value = model.N_SPEC_MIN;
            parameters[11].Value = model.C_SPEC_INTERVAL;
            parameters[12].Value = model.N_SPEC_MAX;
            parameters[13].Value = model.C_FORMULA;
            parameters[14].Value = model.C_UNIT;
            parameters[15].Value = model.N_DIGIT;
            parameters[16].Value = model.C_QUANTITATIVE;
            parameters[17].Value = model.C_TEST_TEM;
            parameters[18].Value = model.C_TEST_CONDITION;
            parameters[19].Value = model.N_STATUS;
            parameters[20].Value = model.C_REMARK;
            parameters[21].Value = model.C_EMP_ID;
            parameters[22].Value = model.D_MOD_DT;
            parameters[23].Value = model.C_ITEM_NAME;
            parameters[24].Value = model.C_ID;

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
            strSql.Append("delete from TQB_STD_CFXN ");
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
            strSql.Append("delete from TQB_STD_CFXN ");
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
        public Mod_TQB_STD_CFXN GetModel(string C_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_STD_MAIN_ID,C_CHARACTER_ID,C_TARGET_MIN,C_TARGET_INTERVAL,C_TARGET_MAX,C_PREWARNING_VALUE,C_TYPE,C_IS_DECIDE,C_IS_PRINT,N_PRINT_ORDER,N_SPEC_MIN,C_SPEC_INTERVAL,N_SPEC_MAX,C_FORMULA,C_UNIT,N_DIGIT,C_QUANTITATIVE,C_TEST_TEM,C_TEST_CONDITION,N_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT,C_ITEM_NAME from TQB_STD_CFXN ");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)          };
            parameters[0].Value = C_ID;

            Mod_TQB_STD_CFXN model = new Mod_TQB_STD_CFXN();
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
        public Mod_TQB_STD_CFXN DataRowToModel(DataRow row)
        {
            Mod_TQB_STD_CFXN model = new Mod_TQB_STD_CFXN();
            if (row != null)
            {
                if (row["C_ID"] != null)
                {
                    model.C_ID = row["C_ID"].ToString();
                }
                if (row["C_STD_MAIN_ID"] != null)
                {
                    model.C_STD_MAIN_ID = row["C_STD_MAIN_ID"].ToString();
                }
                if (row["C_CHARACTER_ID"] != null)
                {
                    model.C_CHARACTER_ID = row["C_CHARACTER_ID"].ToString();
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
                if (row["C_PREWARNING_VALUE"] != null)
                {
                    model.C_PREWARNING_VALUE = row["C_PREWARNING_VALUE"].ToString();
                }
                if (row["C_TYPE"] != null)
                {
                    model.C_TYPE = row["C_TYPE"].ToString();
                }
                if (row["C_IS_DECIDE"] != null)
                {
                    model.C_IS_DECIDE = row["C_IS_DECIDE"].ToString();
                }
                if (row["C_IS_PRINT"] != null)
                {
                    model.C_IS_PRINT = row["C_IS_PRINT"].ToString();
                }
                if (row["N_PRINT_ORDER"] != null && row["N_PRINT_ORDER"].ToString() != "")
                {
                    model.N_PRINT_ORDER = decimal.Parse(row["N_PRINT_ORDER"].ToString());
                }
                if (row["N_SPEC_MIN"] != null && row["N_SPEC_MIN"].ToString() != "")
                {
                    model.N_SPEC_MIN = decimal.Parse(row["N_SPEC_MIN"].ToString());
                }
                if (row["C_SPEC_INTERVAL"] != null)
                {
                    model.C_SPEC_INTERVAL = row["C_SPEC_INTERVAL"].ToString();
                }
                if (row["N_SPEC_MAX"] != null && row["N_SPEC_MAX"].ToString() != "")
                {
                    model.N_SPEC_MAX = decimal.Parse(row["N_SPEC_MAX"].ToString());
                }
                if (row["C_FORMULA"] != null)
                {
                    model.C_FORMULA = row["C_FORMULA"].ToString();
                }
                if (row["C_UNIT"] != null)
                {
                    model.C_UNIT = row["C_UNIT"].ToString();
                }
                if (row["N_DIGIT"] != null && row["N_DIGIT"].ToString() != "")
                {
                    model.N_DIGIT = decimal.Parse(row["N_DIGIT"].ToString());
                }
                if (row["C_QUANTITATIVE"] != null)
                {
                    model.C_QUANTITATIVE = row["C_QUANTITATIVE"].ToString();
                }
                if (row["C_TEST_TEM"] != null)
                {
                    model.C_TEST_TEM = row["C_TEST_TEM"].ToString();
                }
                if (row["C_TEST_CONDITION"] != null)
                {
                    model.C_TEST_CONDITION = row["C_TEST_CONDITION"].ToString();
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
                if (row["C_ITEM_NAME"] != null)
                {
                    model.C_ITEM_NAME = row["C_ITEM_NAME"].ToString();
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
            strSql.Append("select a.C_ID,b.c_code,b.c_name,a.c_quantitative,a.C_STD_MAIN_ID,a.C_CHARACTER_ID,a.C_TARGET_MIN,a.C_TARGET_INTERVAL,a.C_TARGET_MAX,a.C_PREWARNING_VALUE,a.C_TYPE,a.C_IS_DECIDE,a.C_IS_PRINT,a.N_PRINT_ORDER,a.N_SPEC_MIN,a.C_SPEC_INTERVAL,a.N_SPEC_MAX,a.C_FORMULA,a.C_UNIT,a.N_DIGIT,a.C_TEST_TEM,a.C_TEST_CONDITION,a.N_STATUS,a.C_REMARK,a.C_EMP_ID,a.D_MOD_DT");
            strSql.Append(" FROM TQB_STD_CFXN a inner join tqb_character b on a.c_character_id = b.c_id inner join tqb_checktype c on b.c_type_id=c.c_id  WHERE a.N_STATUS='1' ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" AND " + strWhere);
            }
            strSql.Append(" order by A.N_PRINT_ORDER ");
            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList_CF(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select a.C_ID,b.c_code,b.c_name,a.c_quantitative,a.C_STD_MAIN_ID,a.C_CHARACTER_ID,a.C_TARGET_MIN,a.C_TARGET_INTERVAL,a.C_TARGET_MAX,a.C_PREWARNING_VALUE,a.C_TYPE,a.C_IS_DECIDE,a.C_IS_PRINT,a.N_PRINT_ORDER,a.N_SPEC_MIN,a.C_SPEC_INTERVAL,a.N_SPEC_MAX,a.C_FORMULA,a.C_UNIT,a.N_DIGIT,a.C_TEST_TEM,a.C_TEST_CONDITION,a.N_STATUS,a.C_REMARK,a.C_EMP_ID,a.D_MOD_DT");
            strSql.Append(" FROM TQB_STD_CFXN a inner join tqb_character b on a.c_character_id = b.c_id inner join tqb_checktype c on b.c_type_id=c.c_id  WHERE a.N_STATUS='1' ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" AND " + strWhere);
            }
            return DbHelperOra.Query(strSql.ToString());
        }


        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM TQB_STD_CFXN T LEFT JOIN TQB_STD_MAIN T1 ON T.C_STD_MAIN_ID=T1.C_ID WHERE T1.N_STATUS=1 AND T.N_STATUS=1 ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" AND T.c_character_id = '" + strWhere + "'");
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
            strSql.Append(")AS Row, T.*  from TQB_STD_CFXN T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet Get_List(string C_STD_CODE, string C_STL_GRD, string C_CHARACTER_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT TA.C_IS_DECIDE,TA.C_IS_PRINT FROM TQB_STD_CFXN TA INNER JOIN TQB_STD_MAIN TB ON TA.C_STD_MAIN_ID=TB.C_ID WHERE TB.N_IS_CHECK=1 AND TB.N_STATUS=1 AND TB.C_STD_CODE='" + C_STD_CODE + "' AND TB.C_STL_GRD='" + C_STL_GRD + "' AND TA.C_CHARACTER_ID='" + C_CHARACTER_ID + "' ");

            return DbHelperOra.Query(strSql.ToString());
        }

        #endregion  BasicMethod
        #region  ExtensionMethod

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet Get_CF_List(string c_std_code, string c_stl_grd)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ta.C_ID, ta.C_STD_MAIN_ID, ta.C_CHARACTER_ID, ta.C_TARGET_MIN, ta.C_TARGET_INTERVAL, ta.C_TARGET_MAX, ta.C_PREWARNING_VALUE, ta.C_TYPE, ta.C_IS_DECIDE, ta.C_IS_PRINT, ta.N_PRINT_ORDER, ta.N_SPEC_MIN, ta.C_SPEC_INTERVAL, ta.N_SPEC_MAX, ta.C_FORMULA, ta.C_UNIT,       ta.N_DIGIT, ta.C_QUANTITATIVE, ta.C_TEST_TEM, ta.C_TEST_CONDITION, ta.N_STATUS, ta.C_REMARK, ta.C_EMP_ID, ta.D_MOD_DT, tc.c_name as C_ITEM_NAME  from tqb_std_cfxn ta inner  join tqb_std_main tb on ta.c_std_main_id = tb.c_id inner  join tqb_character tc on tc.c_id = ta.c_character_id where tb.n_is_check=1 and tb.n_status=1 and ta.c_type='成分' and tb.c_std_code='" + c_std_code + "' and tb.c_stl_grd='" + c_stl_grd + "' ");

            return DbHelperOra.Query(strSql.ToString());
        }

        #endregion  ExtensionMethod
    }
}

