using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;
namespace DAL
{
    /// <summary>
    /// 数据访问类:TS_SERVER_CONFIG
    /// </summary>
    public partial class Dal_TS_SERVER_CONFIG
    {
        public Dal_TS_SERVER_CONFIG()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string C_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TS_SERVER_CONFIG");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)         };
            parameters[0].Value = C_ID;

            return DbHelperOra.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Mod_TS_SERVER_CONFIG model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TS_SERVER_CONFIG(");
            strSql.Append("C_ID,C_URL,C_FILE,C_USERNAME,C_PASSWORD,C_TYPE,C_USE,C_REMARK,C_NO)");
            strSql.Append(" values (");
            strSql.Append(":C_ID,:C_URL,:C_FILE,:C_USERNAME,:C_PASSWORD,:C_TYPE,:C_USE,:C_REMARK,:C_NO)");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_URL", OracleDbType.Varchar2,200),
                    new OracleParameter(":C_FILE", OracleDbType.Varchar2,200),
                    new OracleParameter(":C_USERNAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PASSWORD", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_TYPE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_USE", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_NO", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.C_ID;
            parameters[1].Value = model.C_URL;
            parameters[2].Value = model.C_FILE;
            parameters[3].Value = model.C_USERNAME;
            parameters[4].Value = model.C_PASSWORD;
            parameters[5].Value = model.C_TYPE;
            parameters[6].Value = model.C_USE;
            parameters[7].Value = model.C_REMARK;
            parameters[8].Value = model.C_NO;

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
        public bool Update(Mod_TS_SERVER_CONFIG model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TS_SERVER_CONFIG set ");
            strSql.Append("C_URL=:C_URL,");
            strSql.Append("C_FILE=:C_FILE,");
            strSql.Append("C_USERNAME=:C_USERNAME,");
            strSql.Append("C_PASSWORD=:C_PASSWORD,");
            strSql.Append("C_TYPE=:C_TYPE,");
            strSql.Append("C_USE=:C_USE,");
            strSql.Append("C_REMARK=:C_REMARK,");
            strSql.Append("C_NO=:C_NO");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_URL", OracleDbType.Varchar2,200),
                    new OracleParameter(":C_FILE", OracleDbType.Varchar2,200),
                    new OracleParameter(":C_USERNAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PASSWORD", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_TYPE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_USE", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.C_URL;
            parameters[1].Value = model.C_FILE;
            parameters[2].Value = model.C_USERNAME;
            parameters[3].Value = model.C_PASSWORD;
            parameters[4].Value = model.C_TYPE;
            parameters[5].Value = model.C_USE;
            parameters[6].Value = model.C_REMARK;
            parameters[7].Value = model.C_NO;
            parameters[8].Value = model.C_ID;

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
            strSql.Append("delete from TS_SERVER_CONFIG ");
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
            strSql.Append("delete from TS_SERVER_CONFIG ");
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
        public Mod_TS_SERVER_CONFIG GetModel(string C_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_URL,C_FILE,C_USERNAME,C_PASSWORD,C_TYPE,C_USE,C_REMARK,C_NO from TS_SERVER_CONFIG ");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)         };
            parameters[0].Value = C_ID;

            Mod_TS_SERVER_CONFIG model = new Mod_TS_SERVER_CONFIG();
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
        public Mod_TS_SERVER_CONFIG GetModel_ByNo(string C_NO)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_URL,C_FILE,C_USERNAME,C_PASSWORD,C_TYPE,C_USE,C_REMARK,C_NO from TS_SERVER_CONFIG ");
            strSql.Append(" where C_NO=:C_NO ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_NO", OracleDbType.Varchar2,100)         };
            parameters[0].Value = C_NO;

            Mod_TS_SERVER_CONFIG model = new Mod_TS_SERVER_CONFIG();
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
        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Mod_TS_SERVER_CONFIG DataRowToModel(DataRow row)
        {
            Mod_TS_SERVER_CONFIG model = new Mod_TS_SERVER_CONFIG();
            if (row != null)
            {
                if (row["C_ID"] != null)
                {
                    model.C_ID = row["C_ID"].ToString();
                }
                if (row["C_URL"] != null)
                {
                    model.C_URL = row["C_URL"].ToString();
                }
                if (row["C_FILE"] != null)
                {
                    model.C_FILE = row["C_FILE"].ToString();
                }
                if (row["C_USERNAME"] != null)
                {
                    model.C_USERNAME = row["C_USERNAME"].ToString();
                }
                if (row["C_PASSWORD"] != null)
                {
                    model.C_PASSWORD = row["C_PASSWORD"].ToString();
                }
                if (row["C_TYPE"] != null)
                {
                    model.C_TYPE = row["C_TYPE"].ToString();
                }
                if (row["C_USE"] != null)
                {
                    model.C_USE = row["C_USE"].ToString();
                }
                if (row["C_REMARK"] != null)
                {
                    model.C_REMARK = row["C_REMARK"].ToString();
                }
                if (row["C_NO"] != null)
                {
                    model.C_NO = row["C_NO"].ToString();
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
            strSql.Append("select C_ID,C_URL,C_FILE,C_USERNAME,C_PASSWORD,C_TYPE,C_USE,C_REMARK,C_NO ");
            strSql.Append(" FROM TS_SERVER_CONFIG ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet Get_List()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_URL,C_FILE,C_USERNAME,C_PASSWORD,C_TYPE,C_USE,C_REMARK,C_NO ");
            strSql.Append(" FROM TS_SERVER_CONFIG where C_NO in('N04','N05','N06') order by C_NO ");

            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM TS_SERVER_CONFIG ");
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
            strSql.Append(")AS Row, T.*  from TS_SERVER_CONFIG T ");
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

        #endregion  ExtensionMethod
    }
}

