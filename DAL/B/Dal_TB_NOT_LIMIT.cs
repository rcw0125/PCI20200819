using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;
namespace DAL
{
    public class Dal_TB_NOT_LIMIT
    {
        public Dal_TB_NOT_LIMIT()
        { }
        #region  BasicMethod



        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Mod_TB_NOT_LIMIT model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TB_NOT_LIMIT(");
            strSql.Append("C_NAME,C_MATCODE,C_TYPE,C_EMP_ID)");
            strSql.Append(" values (");
            strSql.Append(":C_NAME,:C_MATCODE,:C_TYPE,:C_EMP_ID)");
            OracleParameter[] parameters = {

                    new OracleParameter(":C_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MATCODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_TYPE", OracleDbType.Decimal,2),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.C_NAME;
            parameters[1].Value = model.C_MATCODE;
            parameters[2].Value = model.C_TYPE;
            parameters[3].Value = model.C_EMP_ID;

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
        public bool Update(Mod_TB_NOT_LIMIT model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TB_NOT_LIMIT set ");
            strSql.Append("C_ID=:C_ID,");
            strSql.Append("C_NAME=:C_NAME,");
            strSql.Append("C_MATCODE=:C_MATCODE,");
            strSql.Append("C_TYPE=:C_TYPE,");
            strSql.Append("C_EMP_ID=:C_EMP_ID");
            strSql.Append(" where ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MATCODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_TYPE", OracleDbType.Decimal,2),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.C_ID;
            parameters[1].Value = model.C_NAME;
            parameters[2].Value = model.C_MATCODE;
            parameters[3].Value = model.C_TYPE;
            parameters[4].Value = model.C_EMP_ID;

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
        public bool Delete()
        {
            //该表无主键信息，请自定义主键/条件字段
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from TB_NOT_LIMIT ");
            strSql.Append(" where ");
            OracleParameter[] parameters = {
            };

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
        /// 得到一个对象实体
        /// </summary>
        public Mod_TB_NOT_LIMIT GetModel()
        {
            //该表无主键信息，请自定义主键/条件字段
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_NAME,C_MATCODE,C_TYPE,C_EMP_ID from TB_NOT_LIMIT ");
            strSql.Append(" where ");
            OracleParameter[] parameters = {
            };

            Mod_TB_NOT_LIMIT model = new Mod_TB_NOT_LIMIT();
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
        public Mod_TB_NOT_LIMIT DataRowToModel(DataRow row)
        {
            Mod_TB_NOT_LIMIT model = new Mod_TB_NOT_LIMIT();
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
                if (row["C_MATCODE"] != null)
                {
                    model.C_MATCODE = row["C_MATCODE"].ToString();
                }
                if (row["C_TYPE"] != null && row["C_TYPE"].ToString() != "")
                {
                    model.C_TYPE = decimal.Parse(row["C_TYPE"].ToString());
                }
                if (row["C_EMP_ID"] != null)
                {
                    model.C_EMP_ID = row["C_EMP_ID"].ToString();
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
            strSql.Append("select C_ID,C_NAME,C_MATCODE,C_TYPE,C_EMP_ID ");
            strSql.Append(" FROM TB_NOT_LIMIT ");
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
            strSql.Append("select count(1) FROM TB_NOT_LIMIT ");
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
                strSql.Append("order by T. desc");
            }
            strSql.Append(")AS Row, T.*  from TB_NOT_LIMIT T ");
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
			parameters[0].Value = "TB_NOT_LIMIT";
			parameters[1].Value = "";
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
        /// 删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool Del(string id)
        {
            string sql = @"  DELETE  TB_NOT_LIMIT T WHERE T.C_ID='" + id + "' ";
            int rows = DbHelperOra.ExecuteSql(sql);
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
        /// 获取记录
        /// </summary>
        /// <param name="name"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public int GetRecord(string name, decimal type)
        {
            string sql = @"SELECT COUNT(T.C_ID) FROM  TB_NOT_LIMIT T WHERE T.C_NAME='" + name + "' AND T.C_TYPE=" + type + "";
            object obj = DbHelperOra.GetSingle(sql);
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
