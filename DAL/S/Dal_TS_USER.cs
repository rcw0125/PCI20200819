using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;
namespace DAL
{
    /// <summary>
    /// 数据访问类:TS_USER
    /// </summary>
    public partial class Dal_TS_USER
    {
        public Dal_TS_USER()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string C_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TS_USER");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)            };
            parameters[0].Value = C_ID;

            return DbHelperOra.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Mod_TS_USER model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TS_USER(");
            strSql.Append("C_NAME,C_ACCOUNT,C_PASSWORD,C_EMAIL,C_MOBILE,N_TYPE,N_STATUS,C_DESC,D_LASTLOGINTIME,C_EMP_ID,C_EMP_NAME,D_MOD_DT,C_MOBILE2,C_PHONE,C_SHORTNAME,C_CUST_ID,C_TOKEN_ID,C_CJNAME,C_CJINTRO,C_STL_GRD,C_LEGALREPRES,C_CGJCR,C_JOB,C_JCTEL,C_ADDRESS,C_AREA,C_MANAGER)");
            strSql.Append(" values (");
            strSql.Append(":C_NAME,:C_ACCOUNT,:C_PASSWORD,:C_EMAIL,:C_MOBILE,:N_TYPE,:N_STATUS,:C_DESC,:D_LASTLOGINTIME,:C_EMP_ID,:C_EMP_NAME,:D_MOD_DT,:C_MOBILE2,:C_PHONE,:C_SHORTNAME,:C_CUST_ID,:C_TOKEN_ID,:C_CJNAME,:C_CJINTRO,:C_STL_GRD,:C_LEGALREPRES,:C_CGJCR,:C_JOB,:C_JCTEL,:C_ADDRESS,:C_AREA,:C_MANAGER)");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ACCOUNT", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PASSWORD", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_EMAIL", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MOBILE", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_TYPE", OracleDbType.Int16,1),
                    new OracleParameter(":N_STATUS", OracleDbType.Int16,1),
                    new OracleParameter(":C_DESC", OracleDbType.Varchar2,200),
                    new OracleParameter(":D_LASTLOGINTIME", OracleDbType.Date),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_EMP_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":C_MOBILE2", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PHONE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SHORTNAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CUST_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_TOKEN_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CJNAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CJINTRO", OracleDbType.Varchar2,200),
                    new OracleParameter(":C_STL_GRD", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_LEGALREPRES", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CGJCR", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_JOB", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_JCTEL", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ADDRESS", OracleDbType.Varchar2,200),
                    new OracleParameter(":C_AREA", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MANAGER", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.C_ID;
            parameters[1].Value = model.C_NAME;
            parameters[2].Value = model.C_ACCOUNT;
            parameters[3].Value = model.C_PASSWORD;
            parameters[4].Value = model.C_EMAIL;
            parameters[5].Value = model.C_MOBILE;
            parameters[6].Value = model.N_TYPE;
            parameters[7].Value = model.N_STATUS;
            parameters[8].Value = model.C_DESC;
            parameters[9].Value = model.D_LASTLOGINTIME;
            parameters[10].Value = model.C_EMP_ID;
            parameters[11].Value = model.C_EMP_NAME;
            parameters[12].Value = model.D_MOD_DT;
            parameters[13].Value = model.C_MOBILE2;
            parameters[14].Value = model.C_PHONE;
            parameters[15].Value = model.C_SHORTNAME;
            parameters[16].Value = model.C_CUST_ID;
            parameters[17].Value = model.C_TOKEN_ID;
            parameters[18].Value = model.C_CJNAME;
            parameters[19].Value = model.C_CJINTRO;
            parameters[20].Value = model.C_STL_GRD;
            parameters[21].Value = model.C_LEGALREPRES;
            parameters[22].Value = model.C_CGJCR;
            parameters[23].Value = model.C_JOB;
            parameters[24].Value = model.C_JCTEL;
            parameters[25].Value = model.C_ADDRESS;
            parameters[26].Value = model.C_AREA;
            parameters[27].Value = model.C_MANAGER;

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
        public bool Update(Mod_TS_USER model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TS_USER set ");
            strSql.Append("C_NAME=:C_NAME,");
            strSql.Append("C_ACCOUNT=:C_ACCOUNT,");
            strSql.Append("C_PASSWORD=:C_PASSWORD,");
            strSql.Append("C_EMAIL=:C_EMAIL,");
            strSql.Append("C_MOBILE=:C_MOBILE,");
            strSql.Append("N_TYPE=:N_TYPE,");
            strSql.Append("N_STATUS=:N_STATUS,");
            strSql.Append("C_DESC=:C_DESC,");
            strSql.Append("D_LASTLOGINTIME=:D_LASTLOGINTIME,");
            strSql.Append("C_EMP_ID=:C_EMP_ID,");
            strSql.Append("C_EMP_NAME=:C_EMP_NAME,");
            strSql.Append("D_MOD_DT=:D_MOD_DT,");
            strSql.Append("C_MOBILE2=:C_MOBILE2,");
            strSql.Append("C_PHONE=:C_PHONE,");
            strSql.Append("C_SHORTNAME=:C_SHORTNAME,");
            strSql.Append("C_CUST_ID=:C_CUST_ID,");
            strSql.Append("C_TOKEN_ID=:C_TOKEN_ID,");
            strSql.Append("C_CJNAME=:C_CJNAME,");
            strSql.Append("C_CJINTRO=:C_CJINTRO,");
            strSql.Append("C_STL_GRD=:C_STL_GRD,");
            strSql.Append("C_LEGALREPRES=:C_LEGALREPRES,");
            strSql.Append("C_CGJCR=:C_CGJCR,");
            strSql.Append("C_JOB=:C_JOB,");
            strSql.Append("C_JCTEL=:C_JCTEL,");
            strSql.Append("C_ADDRESS=:C_ADDRESS,");
            strSql.Append("C_AREA=:C_AREA,");
            strSql.Append("C_MANAGER=:C_MANAGER");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ACCOUNT", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PASSWORD", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_EMAIL", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MOBILE", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_TYPE", OracleDbType.Int16,1),
                    new OracleParameter(":N_STATUS", OracleDbType.Int16,1),
                    new OracleParameter(":C_DESC", OracleDbType.Varchar2,200),
                    new OracleParameter(":D_LASTLOGINTIME", OracleDbType.Date),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_EMP_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":C_MOBILE2", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PHONE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SHORTNAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CUST_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_TOKEN_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CJNAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CJINTRO", OracleDbType.Varchar2,200),
                    new OracleParameter(":C_STL_GRD", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_LEGALREPRES", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CGJCR", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_JOB", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_JCTEL", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ADDRESS", OracleDbType.Varchar2,200),
                    new OracleParameter(":C_AREA", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MANAGER", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.C_NAME;
            parameters[1].Value = model.C_ACCOUNT;
            parameters[2].Value = model.C_PASSWORD;
            parameters[3].Value = model.C_EMAIL;
            parameters[4].Value = model.C_MOBILE;
            parameters[5].Value = model.N_TYPE;
            parameters[6].Value = model.N_STATUS;
            parameters[7].Value = model.C_DESC;
            parameters[8].Value = model.D_LASTLOGINTIME;
            parameters[9].Value = model.C_EMP_ID;
            parameters[10].Value = model.C_EMP_NAME;
            parameters[11].Value = model.D_MOD_DT;
            parameters[12].Value = model.C_MOBILE2;
            parameters[13].Value = model.C_PHONE;
            parameters[14].Value = model.C_SHORTNAME;
            parameters[15].Value = model.C_CUST_ID;
            parameters[16].Value = model.C_TOKEN_ID;
            parameters[17].Value = model.C_CJNAME;
            parameters[18].Value = model.C_CJINTRO;
            parameters[19].Value = model.C_STL_GRD;
            parameters[20].Value = model.C_LEGALREPRES;
            parameters[21].Value = model.C_CGJCR;
            parameters[22].Value = model.C_JOB;
            parameters[23].Value = model.C_JCTEL;
            parameters[24].Value = model.C_ADDRESS;
            parameters[25].Value = model.C_AREA;
            parameters[26].Value = model.C_MANAGER;
            parameters[27].Value = model.C_ID;

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
            strSql.Append("delete from TS_USER ");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)            };
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
            strSql.Append("delete from TS_USER ");
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
        public Mod_TS_USER GetModel(string C_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_NAME,C_ACCOUNT,C_PASSWORD,C_EMAIL,C_MOBILE,N_TYPE,N_STATUS,C_DESC,D_LASTLOGINTIME,C_EMP_ID,C_EMP_NAME,D_MOD_DT,C_MOBILE2,C_PHONE,C_SHORTNAME,C_CUST_ID,C_TOKEN_ID,C_CJNAME,C_CJINTRO,C_STL_GRD,C_LEGALREPRES,C_CGJCR,C_JOB,C_JCTEL,C_ADDRESS,C_AREA,C_MANAGER from TS_USER ");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)            };
            parameters[0].Value = C_ID;

            Mod_TS_USER model = new Mod_TS_USER();
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
        public Mod_TS_USER GetModel_Interface_Trans(string C_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_NAME,C_ACCOUNT,C_PASSWORD,C_EMAIL,C_MOBILE,N_TYPE,N_STATUS,C_DESC,D_LASTLOGINTIME,C_EMP_ID,C_EMP_NAME,D_MOD_DT,C_MOBILE2,C_PHONE,C_SHORTNAME,C_CUST_ID,C_TOKEN_ID,C_CJNAME,C_CJINTRO,C_STL_GRD,C_LEGALREPRES,C_CGJCR,C_JOB,C_JCTEL,C_ADDRESS,C_AREA,C_MANAGER from TS_USER ");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)            };
            parameters[0].Value = C_ID;

            Mod_TS_USER model = new Mod_TS_USER();
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
        public Mod_TS_USER DataRowToModel(DataRow row)
        {
            Mod_TS_USER model = new Mod_TS_USER();
            if (row != null)
            {
                if (row["C_ID"] != null)
                {
                    model.C_ID = row["C_ID"].ToString();
                }
                if (row["C_NAME"] != null)
                {
                    model.C_NAME = row["C_NAME"].ToString();
                }
                if (row["C_ACCOUNT"] != null)
                {
                    model.C_ACCOUNT = row["C_ACCOUNT"].ToString();
                }
                if (row["C_PASSWORD"] != null)
                {
                    model.C_PASSWORD = row["C_PASSWORD"].ToString();
                }
                if (row["C_EMAIL"] != null)
                {
                    model.C_EMAIL = row["C_EMAIL"].ToString();
                }
                if (row["C_MOBILE"] != null)
                {
                    model.C_MOBILE = row["C_MOBILE"].ToString();
                }
                if (row["N_TYPE"] != null && row["N_TYPE"].ToString() != "")
                {
                    model.N_TYPE = decimal.Parse(row["N_TYPE"].ToString());
                }
                if (row["N_STATUS"] != null && row["N_STATUS"].ToString() != "")
                {
                    model.N_STATUS = decimal.Parse(row["N_STATUS"].ToString());
                }
                if (row["C_DESC"] != null)
                {
                    model.C_DESC = row["C_DESC"].ToString();
                }
                if (row["D_LASTLOGINTIME"] != null && row["D_LASTLOGINTIME"].ToString() != "")
                {
                    model.D_LASTLOGINTIME = DateTime.Parse(row["D_LASTLOGINTIME"].ToString());
                }
                if (row["C_EMP_ID"] != null)
                {
                    model.C_EMP_ID = row["C_EMP_ID"].ToString();
                }
                if (row["C_EMP_NAME"] != null)
                {
                    model.C_EMP_NAME = row["C_EMP_NAME"].ToString();
                }
                if (row["D_MOD_DT"] != null && row["D_MOD_DT"].ToString() != "")
                {
                    model.D_MOD_DT = DateTime.Parse(row["D_MOD_DT"].ToString());
                }
                if (row["C_MOBILE2"] != null)
                {
                    model.C_MOBILE2 = row["C_MOBILE2"].ToString();
                }
                if (row["C_PHONE"] != null)
                {
                    model.C_PHONE = row["C_PHONE"].ToString();
                }
                if (row["C_SHORTNAME"] != null)
                {
                    model.C_SHORTNAME = row["C_SHORTNAME"].ToString();
                }
                if (row["C_CUST_ID"] != null)
                {
                    model.C_CUST_ID = row["C_CUST_ID"].ToString();
                }
                if (row["C_TOKEN_ID"] != null)
                {
                    model.C_TOKEN_ID = row["C_TOKEN_ID"].ToString();
                }
                if (row["C_CJNAME"] != null)
                {
                    model.C_CJNAME = row["C_CJNAME"].ToString();
                }
                if (row["C_CJINTRO"] != null)
                {
                    model.C_CJINTRO = row["C_CJINTRO"].ToString();
                }
                if (row["C_STL_GRD"] != null)
                {
                    model.C_STL_GRD = row["C_STL_GRD"].ToString();
                }
                if (row["C_LEGALREPRES"] != null)
                {
                    model.C_LEGALREPRES = row["C_LEGALREPRES"].ToString();
                }
                if (row["C_CGJCR"] != null)
                {
                    model.C_CGJCR = row["C_CGJCR"].ToString();
                }
                if (row["C_JOB"] != null)
                {
                    model.C_JOB = row["C_JOB"].ToString();
                }
                if (row["C_JCTEL"] != null)
                {
                    model.C_JCTEL = row["C_JCTEL"].ToString();
                }
                if (row["C_ADDRESS"] != null)
                {
                    model.C_ADDRESS = row["C_ADDRESS"].ToString();
                }
                if (row["C_AREA"] != null)
                {
                    model.C_AREA = row["C_AREA"].ToString();
                }
                if (row["C_MANAGER"] != null)
                {
                    model.C_MANAGER = row["C_MANAGER"].ToString();
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
            strSql.Append("select C_ID,C_NAME,C_ACCOUNT,C_PASSWORD,C_EMAIL,C_MOBILE,N_TYPE,N_STATUS,C_DESC,D_LASTLOGINTIME,C_EMP_ID,C_EMP_NAME,D_MOD_DT,C_MOBILE2,C_PHONE,C_SHORTNAME,C_CUST_ID,C_TOKEN_ID,C_CJNAME,C_CJINTRO,C_STL_GRD,C_LEGALREPRES,C_CGJCR,C_JOB,C_JCTEL,C_ADDRESS,C_AREA,C_MANAGER ");
            strSql.Append(" FROM TS_USER ");
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
            strSql.Append("select count(1) FROM TS_USER ");
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
            strSql.Append(")AS Row, T.*  from TS_USER T ");
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
        /// 获取用户编号
        /// </summary>
        /// <returns></returns>
        public object GetAccount(string id)
        {
            string sql = @"SELECT TU.C_ACCOUNT FROM TS_USER TU 
                                    WHERE TU.C_ID='" + id + "'";
            return DbHelperOra.GetSingle(sql);
        }

        #endregion  ExtensionMethod
    }
}
