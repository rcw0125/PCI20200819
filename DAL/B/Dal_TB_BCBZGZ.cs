using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;
namespace DAL
{
    /// <summary>
    /// 数据访问类:TB_BCBZGZ
    /// </summary>
    public partial class Dal_TB_BCBZGZ
    {
        public Dal_TB_BCBZGZ()
        { }
        #region  BasicMethod



        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Mod_TB_BCBZGZ model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TB_BCBZGZ(");
            strSql.Append("C_EMP_ID,C_GZMC,C_GZ,C_SFYS)");
            strSql.Append(" values (");
            strSql.Append(":C_EMP_ID,:C_GZMC,:C_GZ,:C_SFYS)");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_GZMC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_GZ", OracleDbType.Varchar2,1000),
                    new OracleParameter(":C_SFYS", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.C_EMP_ID;
            parameters[1].Value = model.C_GZMC;
            parameters[2].Value = model.C_GZ;
            parameters[3].Value = model.C_SFYS;
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
        public bool Update(Mod_TB_BCBZGZ model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TB_BCBZGZ set ");
            strSql.Append("C_ID=:C_ID,");
            strSql.Append("C_EMP_ID=:C_EMP_ID,");
            strSql.Append("D_MOD_DT=:D_MOD_DT,");
            strSql.Append("C_GZMC=:C_GZMC,");
            strSql.Append("C_GZ=:C_GZ");
            strSql.Append(" where ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":C_GZMC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_GZ", OracleDbType.Varchar2,1000)};
            parameters[0].Value = model.C_ID;
            parameters[1].Value = model.C_EMP_ID;
            parameters[2].Value = model.D_MOD_DT;
            parameters[3].Value = model.C_GZMC;
            parameters[4].Value = model.C_GZ;

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
            strSql.Append("delete from TB_BCBZGZ ");
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
        public Mod_TB_BCBZGZ GetModel(string id)
        {
            //该表无主键信息，请自定义主键/条件字段
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_EMP_ID,D_MOD_DT,C_GZMC,C_GZ from TB_BCBZGZ ");
            strSql.Append(" where C_ID='" + id + "'");
            Mod_TB_BCBZGZ model = new Mod_TB_BCBZGZ();
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
        public Mod_TB_BCBZGZ DataRowToModel(DataRow row)
        {
            Mod_TB_BCBZGZ model = new Mod_TB_BCBZGZ();
            if (row != null)
            {
                if (row["C_ID"] != null)
                {
                    model.C_ID = row["C_ID"].ToString();
                }
                if (row["C_EMP_ID"] != null)
                {
                    model.C_EMP_ID = row["C_EMP_ID"].ToString();
                }
                if (row["D_MOD_DT"] != null && row["D_MOD_DT"].ToString() != "")
                {
                    model.D_MOD_DT = DateTime.Parse(row["D_MOD_DT"].ToString());
                }
                if (row["C_GZMC"] != null)
                {
                    model.C_GZMC = row["C_GZMC"].ToString();
                }
                if (row["C_GZ"] != null)
                {
                    model.C_GZ = row["C_GZ"].ToString();
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
            strSql.Append("select C_ID,C_EMP_ID,D_MOD_DT,C_GZMC,C_GZ ");
            strSql.Append(" FROM TB_BCBZGZ ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 根据规则获取是否延时
        /// </summary>
        public string GetSFYS(string gz)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_SFYS ");
            strSql.Append(" FROM TB_BCBZGZ ");
            strSql.Append(" where C_GZMC='"+gz+"' ");
            DataTable dt = DbHelperOra.Query(strSql.ToString()).Tables[0];
            if (dt.Rows.Count==0)
            {
                return "";
            }
            else
            {
                return dt.Rows[0]["C_SFYS"].ToString();
            }
        }

        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM TB_BCBZGZ ");
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
            strSql.Append(")AS Row, T.*  from TB_BCBZGZ T ");
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
					new OracleParameter(":PageSize", OracleType.Number),
					new OracleParameter(":PageIndex", OracleType.Number),
					new OracleParameter(":IsReCount", OracleType.Clob),
					new OracleParameter(":OrderType", OracleType.Clob),
					new OracleParameter(":strWhere", OracleDbType.Varchar2,1000),
					};
			parameters[0].Value = "TB_BCBZGZ";
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
        /// 获得数据列表
        /// </summary>
        public DataSet GetListByMC(string mc)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_EMP_ID,D_MOD_DT,C_GZMC,C_GZ,C_SFYS ");
            strSql.Append(" FROM TB_BCBZGZ where 1=1 ");
            if (mc.Trim() != "")
            {
                strSql.Append(" AND C_GZMC LIKE'%" + mc + "%'");
            }
            strSql.Append(" ORDER BY C_GZMC");
            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(string id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from TB_BCBZGZ ");
            strSql.Append(" where C_ID='" + id + "'");
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

        #endregion  ExtensionMethod
    }
}