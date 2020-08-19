using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;
namespace DAL
{
    /// <summary>
    /// 数据访问类:TPP_INITIALIZE_PRO_CAP
    /// </summary>
    public partial class Dal_TPP_INITIALIZE_PRO_CAP
    {
        public Dal_TPP_INITIALIZE_PRO_CAP()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string C_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TPP_INITIALIZE_PRO_CAP");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)         };
            parameters[0].Value = C_ID;

            return DbHelperOra.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Mod_TPP_INITIALIZE_PRO_CAP model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TPP_INITIALIZE_PRO_CAP(");
            strSql.Append("C_PRO_ID,C_PRO_CODE,C_PRO_DESC,C_INITIALIZE_ITEM_ID,N_CAPACITY,C_EMP_ID,D_MOD_DT)");
            strSql.Append(" values (");
            strSql.Append(":C_PRO_ID,:C_PRO_CODE,:C_PRO_DESC,:C_INITIALIZE_ITEM_ID,:N_CAPACITY,:C_EMP_ID,:D_MOD_DT)");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_PRO_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PRO_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PRO_DESC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_INITIALIZE_ITEM_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_CAPACITY", OracleDbType.Decimal,15),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date)};
            parameters[0].Value = model.C_PRO_ID;
            parameters[1].Value = model.C_PRO_CODE;
            parameters[2].Value = model.C_PRO_DESC;
            parameters[3].Value = model.C_INITIALIZE_ITEM_ID;
            parameters[4].Value = model.N_CAPACITY;
            parameters[5].Value = model.C_EMP_ID;
            parameters[6].Value = model.D_MOD_DT;

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
        public bool Update(Mod_TPP_INITIALIZE_PRO_CAP model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TPP_INITIALIZE_PRO_CAP set ");
            strSql.Append("C_PRO_ID=:C_PRO_ID,");
            strSql.Append("C_PRO_CODE=:C_PRO_CODE,");
            strSql.Append("C_PRO_DESC=:C_PRO_DESC,");
            strSql.Append("C_INITIALIZE_ITEM_ID=:C_INITIALIZE_ITEM_ID,");
            strSql.Append("N_CAPACITY=:N_CAPACITY,");
            strSql.Append("C_EMP_ID=:C_EMP_ID,");
            strSql.Append("D_MOD_DT=:D_MOD_DT");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_PRO_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PRO_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PRO_DESC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_INITIALIZE_ITEM_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_CAPACITY", OracleDbType.Decimal,15),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.C_PRO_ID;
            parameters[1].Value = model.C_PRO_CODE;
            parameters[2].Value = model.C_PRO_DESC;
            parameters[3].Value = model.C_INITIALIZE_ITEM_ID;
            parameters[4].Value = model.N_CAPACITY;
            parameters[5].Value = model.C_EMP_ID;
            parameters[6].Value = model.D_MOD_DT;
            parameters[7].Value = model.C_ID;

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
            strSql.Append("delete from TPP_INITIALIZE_PRO_CAP ");
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
            strSql.Append("delete from TPP_INITIALIZE_PRO_CAP ");
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
        public Mod_TPP_INITIALIZE_PRO_CAP GetModel(string C_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_PRO_ID,C_PRO_CODE,C_PRO_DESC,C_INITIALIZE_ITEM_ID,N_CAPACITY,C_EMP_ID,D_MOD_DT from TPP_INITIALIZE_PRO_CAP ");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)         };
            parameters[0].Value = C_ID;

            Mod_TPP_INITIALIZE_PRO_CAP model = new Mod_TPP_INITIALIZE_PRO_CAP();
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
        public Mod_TPP_INITIALIZE_PRO_CAP DataRowToModel(DataRow row)
        {
            Mod_TPP_INITIALIZE_PRO_CAP model = new Mod_TPP_INITIALIZE_PRO_CAP();
            if (row != null)
            {
                if (row["C_ID"] != null)
                {
                    model.C_ID = row["C_ID"].ToString();
                }
                if (row["C_PRO_ID"] != null)
                {
                    model.C_PRO_ID = row["C_PRO_ID"].ToString();
                }
                if (row["C_PRO_CODE"] != null)
                {
                    model.C_PRO_CODE = row["C_PRO_CODE"].ToString();
                }
                if (row["C_PRO_DESC"] != null)
                {
                    model.C_PRO_DESC = row["C_PRO_DESC"].ToString();
                }
                if (row["C_INITIALIZE_ITEM_ID"] != null)
                {
                    model.C_INITIALIZE_ITEM_ID = row["C_INITIALIZE_ITEM_ID"].ToString();
                }
                if (row["N_CAPACITY"] != null && row["N_CAPACITY"].ToString() != "")
                {
                    model.N_CAPACITY = decimal.Parse(row["N_CAPACITY"].ToString());
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
            strSql.Append("select C_ID,C_PRO_ID,C_PRO_CODE,C_PRO_DESC,C_INITIALIZE_ITEM_ID,N_CAPACITY,C_EMP_ID,D_MOD_DT ");
            strSql.Append(" FROM TPP_INITIALIZE_PRO_CAP ");
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
            strSql.Append("select count(1) FROM TPP_INITIALIZE_PRO_CAP ");
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
            strSql.Append(")AS Row, T.*  from TPP_INITIALIZE_PRO_CAP T ");
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
			parameters[0].Value = "TPP_INITIALIZE_PRO_CAP";
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
        /// 根据方案获得数据列表
        /// </summary>
        public DataSet GetListByFA(string C_INITIALIZE_ITEM_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_PRO_ID,C_PRO_CODE,C_PRO_DESC,C_INITIALIZE_ITEM_ID,N_CAPACITY,C_EMP_ID,D_MOD_DT ");
            strSql.Append(" FROM TPP_INITIALIZE_PRO_CAP WHERE 1=1 ");
            if (C_INITIALIZE_ITEM_ID.Trim() != "")
            {
                strSql.Append(" AND C_INITIALIZE_ITEM_ID='"+ C_INITIALIZE_ITEM_ID + "' ");
            }
            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 根据方案删除一条数据
        /// </summary>
        public bool DeleteByFA(string C_INITIALIZE_ITEM_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from TPP_INITIALIZE_PRO_CAP ");
            strSql.Append(" where C_INITIALIZE_ITEM_ID=:C_INITIALIZE_ITEM_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_INITIALIZE_ITEM_ID", OracleDbType.Varchar2,100)         };
            parameters[0].Value = C_INITIALIZE_ITEM_ID;

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
        #endregion  ExtensionMethod
    }
}
