using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;
namespace DAL
{
    public class Dal_TB_CONFIG_PERCENTAGE
    {
        public Dal_TB_CONFIG_PERCENTAGE()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string C_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TB_CONFIG_PERCENTAGE");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)            };
            parameters[0].Value = C_ID;

            return DbHelperOra.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Mod_TB_CONFIG_PERCENTAGE model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TB_CONFIG_PERCENTAGE(");
            strSql.Append("C_PROD_KIND,C_PROD_NAME,C_PERCENTAGE,C_EMP_ID,C_CONDITION,C_CONDITION2,C_ELSECON,C_ELSETYPE,N_TYPE)");
            strSql.Append(" values (");
            strSql.Append(":C_PROD_KIND,:C_PROD_NAME,:C_PERCENTAGE,:C_EMP_ID,:C_CONDITION,:C_CONDITION2,:C_ELSECON,:C_ELSETYPE,:N_TYPE)");
            OracleParameter[] parameters = {

                    new OracleParameter(":C_PROD_KIND", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PROD_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PERCENTAGE", OracleDbType.Decimal,15),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CONDITION", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CONDITION2", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ELSECON", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ELSETYPE", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_TYPE", OracleDbType.Decimal,15)};
            parameters[0].Value = model.C_PROD_KIND;
            parameters[1].Value = model.C_PROD_NAME;
            parameters[2].Value = model.C_PERCENTAGE;
            parameters[3].Value = model.C_EMP_ID;
            parameters[4].Value = model.C_CONDITION;
            parameters[5].Value = model.C_CONDITION2;
            parameters[6].Value = model.C_ELSECON;
            parameters[7].Value = model.C_ELSETYPE;
            parameters[8].Value = model.N_TYPE;

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
        public bool Update(Mod_TB_CONFIG_PERCENTAGE model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TB_CONFIG_PERCENTAGE set ");
            strSql.Append("C_PROD_KIND=:C_PROD_KIND,");
            strSql.Append("C_PROD_NAME=:C_PROD_NAME,");
            strSql.Append("C_PERCENTAGE=:C_PERCENTAGE,");
            strSql.Append("C_EMP_ID=:C_EMP_ID,");
            strSql.Append("C_CONDITION=:C_CONDITION,");
            strSql.Append("C_CONDITION2=:C_CONDITION2,");
            strSql.Append("C_ELSECON=:C_ELSECON,");
            strSql.Append("C_ELSETYPE=:C_ELSETYPE,");
            strSql.Append("N_TYPE=:N_TYPE");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_PROD_KIND", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PROD_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PERCENTAGE", OracleDbType.Decimal,15),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CONDITION", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CONDITION2", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ELSECON", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ELSETYPE", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_TYPE", OracleDbType.Decimal,15),
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.C_PROD_KIND;
            parameters[1].Value = model.C_PROD_NAME;
            parameters[2].Value = model.C_PERCENTAGE;
            parameters[3].Value = model.C_EMP_ID;
            parameters[4].Value = model.C_CONDITION;
            parameters[5].Value = model.C_CONDITION2;
            parameters[6].Value = model.C_ELSECON;
            parameters[7].Value = model.C_ELSETYPE;
            parameters[8].Value = model.N_TYPE;
            parameters[9].Value = model.C_ID;

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
            strSql.Append("delete from TB_CONFIG_PERCENTAGE ");
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
            strSql.Append("delete from TB_CONFIG_PERCENTAGE ");
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
        public Mod_TB_CONFIG_PERCENTAGE GetModel(string C_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_PROD_KIND,C_PROD_NAME,C_PERCENTAGE,C_EMP_ID,C_CONDITION,C_CONDITION2,C_ELSECON,C_ELSETYPE,N_TYPE from TB_CONFIG_PERCENTAGE ");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)            };
            parameters[0].Value = C_ID;

            Mod_TB_CONFIG_PERCENTAGE model = new Mod_TB_CONFIG_PERCENTAGE();
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
        public Mod_TB_CONFIG_PERCENTAGE DataRowToModel(DataRow row)
        {
            Mod_TB_CONFIG_PERCENTAGE model = new Mod_TB_CONFIG_PERCENTAGE();
            if (row != null)
            {
                if (row["C_ID"] != null)
                {
                    model.C_ID = row["C_ID"].ToString();
                }
                if (row["C_PROD_KIND"] != null)
                {
                    model.C_PROD_KIND = row["C_PROD_KIND"].ToString();
                }
                if (row["C_PROD_NAME"] != null)
                {
                    model.C_PROD_NAME = row["C_PROD_NAME"].ToString();
                }
                if (row["C_PERCENTAGE"] != null && row["C_PERCENTAGE"].ToString() != "")
                {
                    model.C_PERCENTAGE = decimal.Parse(row["C_PERCENTAGE"].ToString());
                }
                if (row["C_EMP_ID"] != null)
                {
                    model.C_EMP_ID = row["C_EMP_ID"].ToString();
                }
                if (row["C_CONDITION"] != null)
                {
                    model.C_CONDITION = row["C_CONDITION"].ToString();
                }
                if (row["C_CONDITION2"] != null)
                {
                    model.C_CONDITION2 = row["C_CONDITION2"].ToString();
                }
                if (row["C_ELSECON"] != null)
                {
                    model.C_ELSECON = row["C_ELSECON"].ToString();
                }
                if (row["C_ELSETYPE"] != null)
                {
                    model.C_ELSETYPE = row["C_ELSETYPE"].ToString();
                }
                if (row["N_TYPE"] != null && row["N_TYPE"].ToString() != "")
                {
                    model.N_TYPE = decimal.Parse(row["N_TYPE"].ToString());
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
            strSql.Append("select C_ID,C_PROD_KIND,C_PROD_NAME,C_PERCENTAGE,C_EMP_ID,C_CONDITION,C_CONDITION2,C_ELSECON,C_ELSETYPE,N_TYPE ");
            strSql.Append(" FROM TB_CONFIG_PERCENTAGE ");
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
            strSql.Append("select count(1) FROM TB_CONFIG_PERCENTAGE ");
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
            strSql.Append(")AS Row, T.*  from TB_CONFIG_PERCENTAGE T ");
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
			parameters[0].Value = "TB_CONFIG_PERCENTAGE";
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
