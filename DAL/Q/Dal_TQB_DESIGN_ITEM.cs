using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;
namespace DAL
{
    /// <summary>
    /// 数据访问类:TQB_DESIGN_ITEM
    /// </summary>
    public partial class Dal_TQB_DESIGN_ITEM
    {
        public Dal_TQB_DESIGN_ITEM()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string C_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TQB_DESIGN_ITEM");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)         };
            parameters[0].Value = C_ID;

            return DbHelperOra.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Mod_TQB_DESIGN_ITEM model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TQB_DESIGN_ITEM(");
            strSql.Append("C_DESIGN_ID,C_CHARACTER_ID,C_TARGET_MIN,C_TARGET_INTERVAL,C_TARGET_MAX,C_PREWARNING_VALUE,C_TYPE,C_IS_DECIDE,C_IS_PRINT,N_PRINT_ORDER,N_SPEC_MIN,C_SPEC_INTERVAL,N_SPEC_MAX,C_FORMULA,C_UNIT,N_DIGIT,C_QUANTITATIVE,C_TEST_TEM,C_TEST_CONDITION,N_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT)");
            strSql.Append(" values (");
            strSql.Append(":C_DESIGN_ID,:C_CHARACTER_ID,:C_TARGET_MIN,:C_TARGET_INTERVAL,:C_TARGET_MAX,:C_PREWARNING_VALUE,:C_TYPE,:C_IS_DECIDE,:C_IS_PRINT,:N_PRINT_ORDER,:N_SPEC_MIN,:C_SPEC_INTERVAL,:N_SPEC_MAX,:C_FORMULA,:C_UNIT,:N_DIGIT,:C_QUANTITATIVE,:C_TEST_TEM,:C_TEST_CONDITION,:N_STATUS,:C_REMARK,:C_EMP_ID,:D_MOD_DT)");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_DESIGN_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CHARACTER_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_TARGET_MIN", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_TARGET_INTERVAL", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_TARGET_MAX", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PREWARNING_VALUE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_TYPE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_IS_DECIDE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_IS_PRINT", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_PRINT_ORDER", OracleDbType.Decimal,5),
                    new OracleParameter(":N_SPEC_MIN", OracleDbType.Decimal,15),
                    new OracleParameter(":C_SPEC_INTERVAL", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_SPEC_MAX", OracleDbType.Decimal,15),
                    new OracleParameter(":C_FORMULA", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_UNIT", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_DIGIT", OracleDbType.Decimal,1),
                    new OracleParameter(":C_QUANTITATIVE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_TEST_TEM", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_TEST_CONDITION", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date)};
            parameters[0].Value = model.C_DESIGN_ID;
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
        public bool Update(Mod_TQB_DESIGN_ITEM model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TQB_DESIGN_ITEM set ");
            strSql.Append("C_DESIGN_ID=:C_DESIGN_ID,");
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
            strSql.Append("D_MOD_DT=:D_MOD_DT");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_DESIGN_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CHARACTER_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_TARGET_MIN", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_TARGET_INTERVAL", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_TARGET_MAX", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PREWARNING_VALUE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_TYPE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_IS_DECIDE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_IS_PRINT", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_PRINT_ORDER", OracleDbType.Decimal,5),
                    new OracleParameter(":N_SPEC_MIN", OracleDbType.Decimal,15),
                    new OracleParameter(":C_SPEC_INTERVAL", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_SPEC_MAX", OracleDbType.Decimal,15),
                    new OracleParameter(":C_FORMULA", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_UNIT", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_DIGIT", OracleDbType.Decimal,1),
                    new OracleParameter(":C_QUANTITATIVE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_TEST_TEM", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_TEST_CONDITION", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.C_DESIGN_ID;
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
            parameters[23].Value = model.C_ID;

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
            strSql.Append("delete from TQB_DESIGN_ITEM ");
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
            strSql.Append("delete from TQB_DESIGN_ITEM ");
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
        public Mod_TQB_DESIGN_ITEM GetModel(string C_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_DESIGN_ID,C_CHARACTER_ID,C_TARGET_MIN,C_TARGET_INTERVAL,C_TARGET_MAX,C_PREWARNING_VALUE,C_TYPE,C_IS_DECIDE,C_IS_PRINT,N_PRINT_ORDER,N_SPEC_MIN,C_SPEC_INTERVAL,N_SPEC_MAX,C_FORMULA,C_UNIT,N_DIGIT,C_QUANTITATIVE,C_TEST_TEM,C_TEST_CONDITION,N_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT from TQB_DESIGN_ITEM ");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)         };
            parameters[0].Value = C_ID;

            Mod_TQB_DESIGN_ITEM model = new Mod_TQB_DESIGN_ITEM();
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
        public Mod_TQB_DESIGN_ITEM GetModel(string c_design_no, string c_character_id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_DESIGN_ID,C_CHARACTER_ID,C_TARGET_MIN,C_TARGET_INTERVAL,C_TARGET_MAX,C_PREWARNING_VALUE,C_TYPE,C_IS_DECIDE,C_IS_PRINT,N_PRINT_ORDER,N_SPEC_MIN,C_SPEC_INTERVAL,N_SPEC_MAX,C_FORMULA,C_UNIT,N_DIGIT,C_QUANTITATIVE,C_TEST_TEM,C_TEST_CONDITION,N_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT from TQB_DESIGN_ITEM t ");
            strSql.Append(" where substr(t.c_design_id,3)='" + c_design_no + "' and t.c_character_id='" + c_character_id + "' and rownum=1 ");

            Mod_TQB_DESIGN_ITEM model = new Mod_TQB_DESIGN_ITEM();
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
        public Mod_TQB_DESIGN_ITEM DataRowToModel(DataRow row)
        {
            Mod_TQB_DESIGN_ITEM model = new Mod_TQB_DESIGN_ITEM();
            if (row != null)
            {
                if (row["C_ID"] != null)
                {
                    model.C_ID = row["C_ID"].ToString();
                }
                if (row["C_DESIGN_ID"] != null)
                {
                    model.C_DESIGN_ID = row["C_DESIGN_ID"].ToString();
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
            }
            return model;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_DESIGN_ID,C_CHARACTER_ID,C_TARGET_MIN,C_TARGET_INTERVAL,C_TARGET_MAX,C_PREWARNING_VALUE,C_TYPE,C_IS_DECIDE,C_IS_PRINT,N_PRINT_ORDER,N_SPEC_MIN,C_SPEC_INTERVAL,N_SPEC_MAX,C_FORMULA,C_UNIT,N_DIGIT,C_QUANTITATIVE,C_TEST_TEM,C_TEST_CONDITION,N_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT ");
            strSql.Append(" FROM TQB_DESIGN_ITEM ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList_Query(string C_DESIGN_NO)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  b.c_code,b.c_name,T.C_ID,t.C_DESIGN_ID,t.C_CHARACTER_ID,t.C_TARGET_MIN,t.C_TARGET_INTERVAL,t.C_TARGET_MAX,t.C_PREWARNING_VALUE,t.C_TYPE,t.C_IS_DECIDE,t.C_IS_PRINT,t.N_PRINT_ORDER,t.N_SPEC_MIN,t.C_SPEC_INTERVAL,t.N_SPEC_MAX,t.C_FORMULA,t.C_UNIT,t.N_DIGIT,t.C_QUANTITATIVE,t.C_TEST_TEM,t.C_TEST_CONDITION,t.N_STATUS,t.C_REMARK,t.C_EMP_ID,t.D_MOD_DT  ");
            strSql.Append(" FROM TQB_DESIGN_ITEM T JOIN TQB_DESIGN T1 ON T.C_DESIGN_ID=T1.C_ID  inner join tqb_character b on t.c_character_id = b.c_id inner join tqb_checktype c on b.c_type_id=c.c_id WHERE T.N_STATUS=1 and t.c_type='成分' ");
            if (C_DESIGN_NO.Trim() != "")
            {
                strSql.Append("  AND  T1.C_DESIGN_NO = '" + C_DESIGN_NO + "' ");
            }
            strSql.Append(" ORDER BY T.C_TYPE ");
            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList_CF(string C_DESIGN_NO)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  b.c_code,b.c_name,T.C_ID,t.C_DESIGN_ID,t.C_CHARACTER_ID,t.C_TARGET_MIN,t.C_TARGET_INTERVAL,t.C_TARGET_MAX,t.C_PREWARNING_VALUE,t.C_TYPE,t.C_IS_DECIDE,t.C_IS_PRINT,t.N_PRINT_ORDER,t.N_SPEC_MIN,t.C_SPEC_INTERVAL,t.N_SPEC_MAX,t.C_FORMULA,t.C_UNIT,t.N_DIGIT,t.C_QUANTITATIVE,t.C_TEST_TEM,t.C_TEST_CONDITION,t.N_STATUS,t.C_REMARK,t.C_EMP_ID,t.D_MOD_DT  ");
            strSql.Append(" FROM TQB_DESIGN_ITEM T JOIN TQB_DESIGN T1 ON T.C_DESIGN_ID=T1.C_ID  inner join tqb_character b on t.c_character_id = b.c_id inner join tqb_checktype c on b.c_type_id=c.c_id WHERE T.N_STATUS=1  ");
            if (C_DESIGN_NO.Trim() != "")
            {
                strSql.Append("  AND  T1.C_DESIGN_NO = '" + C_DESIGN_NO + "' ");
            }
            strSql.Append(" ORDER BY T.C_TYPE ");
            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM TQB_DESIGN_ITEM ");
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
            strSql.Append(")AS Row, T.*  from TQB_DESIGN_ITEM T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取质量设计明细信息
        /// </summary>
        /// <param name="c_std_code">执行标准</param>
        /// <param name="c_stl_grd">钢种</param>
        /// <returns></returns>
        public DataSet GetList(string c_std_code, string c_stl_grd)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select tc.* from tqb_std_main ta inner join tqb_design tb on ta.c_id=tb.c_std_main_id inner join tqb_design_item tc on tb.c_id=tc.c_design_id where ta.c_std_code='" + c_std_code + "' and ta.c_stl_grd='" + c_stl_grd + "' and ta.n_is_check=1 and ta.n_status=1 ");

            return DbHelperOra.Query(strSql.ToString());
        }

        #endregion  BasicMethod
        #region  ExtensionMethod

        #endregion  ExtensionMethod
    }
}

