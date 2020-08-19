using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;
namespace DAL
{
    public class Dal_TB_CONFIG_LIMIT
    {
        public Dal_TB_CONFIG_LIMIT()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string C_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TB_CONFIG_LIMIT");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2)           };
            parameters[0].Value = C_ID;

            return DbHelperOra.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Mod_TB_CONFIG_LIMIT model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TB_CONFIG_LIMIT(");
            strSql.Append("C_ID,N_SECTION_MIN,N_SECTION_MAX,N_NUM,C_EMP_ID)");
            strSql.Append(" values (");
            strSql.Append(":C_ID,:N_SECTION_MIN,:N_SECTION_MAX,:N_NUM,:C_EMP_ID)");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2),
                    new OracleParameter(":N_SECTION_MIN", OracleDbType.Decimal,15),
                    new OracleParameter(":N_SECTION_MAX", OracleDbType.Decimal,15),
                    new OracleParameter(":N_NUM", OracleDbType.Decimal,15),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2)};
            parameters[0].Value = model.C_ID;
            parameters[1].Value = model.N_SECTION_MIN;
            parameters[2].Value = model.N_SECTION_MAX;
            parameters[3].Value = model.N_NUM;
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
        /// 更新一条数据
        /// </summary>
        public bool Update(Mod_TB_CONFIG_LIMIT model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TB_CONFIG_LIMIT set ");
            strSql.Append("N_SECTION_MIN=:N_SECTION_MIN,");
            strSql.Append("N_SECTION_MAX=:N_SECTION_MAX,");
            strSql.Append("N_NUM=:N_NUM,");
            strSql.Append("C_EMP_ID=:C_EMP_ID");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":N_SECTION_MIN", OracleDbType.Decimal,15),
                    new OracleParameter(":N_SECTION_MAX", OracleDbType.Decimal,15),
                    new OracleParameter(":N_NUM", OracleDbType.Decimal,15),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2),
                    new OracleParameter(":C_ID", OracleDbType.Varchar2)};
            parameters[0].Value = model.N_SECTION_MIN;
            parameters[1].Value = model.N_SECTION_MAX;
            parameters[2].Value = model.N_NUM;
            parameters[3].Value = model.C_EMP_ID;
            parameters[4].Value = model.C_ID;

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
            strSql.Append("delete from TB_CONFIG_LIMIT ");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2)           };
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
            strSql.Append("delete from TB_CONFIG_LIMIT ");
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
        public Mod_TB_CONFIG_LIMIT GetModel(string C_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,N_SECTION_MIN,N_SECTION_MAX,N_NUM,C_EMP_ID from TB_CONFIG_LIMIT ");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2)           };
            parameters[0].Value = C_ID;

            Mod_TB_CONFIG_LIMIT model = new Mod_TB_CONFIG_LIMIT();
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
        public Mod_TB_CONFIG_LIMIT DataRowToModel(DataRow row)
        {
            Mod_TB_CONFIG_LIMIT model = new Mod_TB_CONFIG_LIMIT();
            if (row != null)
            {
                if (row["C_ID"] != null)
                {
                    model.C_ID = row["C_ID"].ToString();
                }
                if (row["N_SECTION_MIN"] != null && row["N_SECTION_MIN"].ToString() != "")
                {
                    model.N_SECTION_MIN = decimal.Parse(row["N_SECTION_MIN"].ToString());
                }
                if (row["N_SECTION_MAX"] != null && row["N_SECTION_MAX"].ToString() != "")
                {
                    model.N_SECTION_MAX = decimal.Parse(row["N_SECTION_MAX"].ToString());
                }
                if (row["N_NUM"] != null && row["N_NUM"].ToString() != "")
                {
                    model.N_NUM = decimal.Parse(row["N_NUM"].ToString());
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
            strSql.Append("select C_ID,N_SECTION_MIN,N_SECTION_MAX,N_NUM,C_EMP_ID ");
            strSql.Append(" FROM TB_CONFIG_LIMIT ");
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
            strSql.Append("select count(1) FROM TB_CONFIG_LIMIT ");
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
            strSql.Append(")AS Row, T.*  from TB_CONFIG_LIMIT T ");
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
			parameters[0].Value = "TB_CONFIG_LIMIT";
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
        /// 修改限制量
        /// </summary>
        public bool UpdateNum(string id, decimal num, string userID)
        {
            string sql = @"UPDATE TB_CONFIG_LIMIT T
                            SET T.N_NUM=" + num + " ,T.C_EMP_ID='" + userID + "'  WHERE T.C_ID='" + id + "'";
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

        public bool InsertLog(decimal num, string min, string max, string userID)
        {
            string remark = "区域量小：" + min + " 区域量大：" + max + "修改量:" + num;
            string sql = @"INSERT INTO   TB_CONFIG_LIMIT_LOG (C_REMARK,C_EMP_ID)     VALUES ('" + remark + "','" + userID + "')     ";
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
        /// 获取操作记录
        /// </summary>
        /// <returns></returns>
        public DataTable GetCZJL()
        {
            string sql = @" SELECT * FROM TB_CONFIG_LIMIT_LOG ";
            return DbHelperOra.Query(sql).Tables[0];
        }

        #endregion  ExtensionMethod
    }
}
