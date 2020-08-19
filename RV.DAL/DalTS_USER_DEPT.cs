using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using RV.MODEL;

namespace RV.DAL
{
    /// <summary>
    /// 数据访问类:TS_USER_DEPT
    /// </summary>
    public partial class DalTS_USER_DEPT
    {
        public DalTS_USER_DEPT()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string C_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TS_USER_DEPT");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,50)          };
            parameters[0].Value = C_ID;

            return DbHelperOra.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(ModTS_USER_DEPT model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TS_USER_DEPT(");
            strSql.Append("C_USER_ID,C_DEPT_ID)");
            strSql.Append(" values (");
            strSql.Append(":C_USER_ID,:C_DEPT_ID)");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_USER_ID", OracleDbType.Varchar2,50),
                    new OracleParameter(":C_DEPT_ID", OracleDbType.Varchar2,50)};
            parameters[0].Value = model.C_USER_ID;
            parameters[1].Value = model.C_DEPT_ID;

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
        public bool Update(ModTS_USER_DEPT model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TS_USER_DEPT set ");
            strSql.Append("C_USER_ID=:C_USER_ID,");
            strSql.Append("C_DEPT_ID=:C_DEPT_ID");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_USER_ID", OracleDbType.Varchar2,50),
                    new OracleParameter(":C_DEPT_ID", OracleDbType.Varchar2,50),
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,50)};
            parameters[0].Value = model.C_USER_ID;
            parameters[1].Value = model.C_DEPT_ID;
            parameters[2].Value = model.C_ID;

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
            strSql.Append("delete from TS_USER_DEPT ");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,50)          };
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
            strSql.Append("delete from TS_USER_DEPT ");
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
        public ModTS_USER_DEPT GetModel(string C_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_USER_ID,C_DEPT_ID from TS_USER_DEPT ");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,50)          };
            parameters[0].Value = C_ID;

            ModTS_USER_DEPT model = new ModTS_USER_DEPT();
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
		public ModTS_USER_DEPT Get_Model(string C_USER_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select td.C_ID,td.C_USER_ID,td.C_DEPT_ID from TS_USER_DEPT td inner join ts_user tu on td.c_user_id=tu.c_account where tu.n_type=3   ");
            strSql.Append(" and C_USER_ID='" + C_USER_ID + "' ");

            ModTS_USER_DEPT model = new ModTS_USER_DEPT();
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
        public ModTS_USER_DEPT DataRowToModel(DataRow row)
        {
            ModTS_USER_DEPT model = new ModTS_USER_DEPT();
            if (row != null)
            {
                if (row["C_ID"] != null)
                {
                    model.C_ID = row["C_ID"].ToString();
                }
                if (row["C_USER_ID"] != null)
                {
                    model.C_USER_ID = row["C_USER_ID"].ToString();
                }
                if (row["C_DEPT_ID"] != null)
                {
                    model.C_DEPT_ID = row["C_DEPT_ID"].ToString();
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
            strSql.Append("select C_ID,C_USER_ID,C_DEPT_ID ");
            strSql.Append(" FROM TS_USER_DEPT ");
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
            strSql.Append("select count(1) FROM TS_USER_DEPT ");
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

        #endregion  BasicMethod
        #region  ExtensionMethod

        #endregion  ExtensionMethod
    }
}

