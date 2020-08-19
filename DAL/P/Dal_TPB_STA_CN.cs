using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;
namespace DAL
{
    /// <summary>
    /// 数据访问类:TPB_STA_CN
    /// </summary>
    public partial class Dal_TPB_STA_CN
    {
        public Dal_TPB_STA_CN()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string C_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TPB_STA_CN");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)         };
            parameters[0].Value = C_ID;

            return DbHelperOra.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Mod_TPB_STA_CN model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TPB_STA_CN(");
            strSql.Append("C_DATE,C_STA,C_VALUE,C_REMARK,N_STATUS,C_EMP_ID,D_MOD_DT,C_MONTH)");
            strSql.Append(" values (");
            strSql.Append(":C_DATE,:C_STA,:C_VALUE,:C_REMARK,:N_STATUS,:C_EMP_ID,:D_MOD_DT,:C_MONTH)");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_DATE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STA", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_VALUE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":C_MONTH", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.C_DATE;
            parameters[1].Value = model.C_STA;
            parameters[2].Value = model.C_VALUE;
            parameters[3].Value = model.C_REMARK;
            parameters[4].Value = model.N_STATUS;
            parameters[5].Value = model.C_EMP_ID;
            parameters[6].Value = model.D_MOD_DT;
            parameters[7].Value = model.C_MONTH;

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
        public bool Update(Mod_TPB_STA_CN model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TPB_STA_CN set ");
            strSql.Append("C_DATE=:C_DATE,");
            strSql.Append("C_STA=:C_STA,");
            strSql.Append("C_VALUE=:C_VALUE,");
            strSql.Append("C_REMARK=:C_REMARK,");
            strSql.Append("N_STATUS=:N_STATUS,");
            strSql.Append("C_EMP_ID=:C_EMP_ID,");
            strSql.Append("D_MOD_DT=:D_MOD_DT,");
            strSql.Append("C_MONTH=:C_MONTH");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_DATE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STA", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_VALUE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":C_MONTH", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.C_DATE;
            parameters[1].Value = model.C_STA;
            parameters[2].Value = model.C_VALUE;
            parameters[3].Value = model.C_REMARK;
            parameters[4].Value = model.N_STATUS;
            parameters[5].Value = model.C_EMP_ID;
            parameters[6].Value = model.D_MOD_DT;
            parameters[7].Value = model.C_MONTH;
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
        public bool Delete(string C_DATE, string C_REMARK, string C_MONTH)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from TPB_STA_CN ");
            strSql.Append(" where SUBSTR(C_DATE,1,7) =:C_DATE and C_REMARK=:C_REMARK AND C_MONTH=:C_MONTH ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_DATE", OracleDbType.Varchar2,100)   ,
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500)         ,
                    new OracleParameter(":C_MONTH", OracleDbType.Varchar2,100)         };
            parameters[0].Value = C_DATE;
            parameters[1].Value = C_REMARK;
            parameters[2].Value = C_MONTH;

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
            strSql.Append("delete from TPB_STA_CN ");
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
        public Mod_TPB_STA_CN GetModel(string C_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_DATE,C_STA,C_VALUE,C_REMARK,N_STATUS,C_EMP_ID,D_MOD_DT,C_MONTH from TPB_STA_CN ");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)         };
            parameters[0].Value = C_ID;

            Mod_TPB_STA_CN model = new Mod_TPB_STA_CN();
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
        public Mod_TPB_STA_CN DataRowToModel(DataRow row)
        {
            Mod_TPB_STA_CN model = new Mod_TPB_STA_CN();
            if (row != null)
            {
                if (row["C_ID"] != null)
                {
                    model.C_ID = row["C_ID"].ToString();
                }
                if (row["C_DATE"] != null)
                {
                    model.C_DATE = row["C_DATE"].ToString();
                }
                if (row["C_STA"] != null)
                {
                    model.C_STA = row["C_STA"].ToString();
                }
                if (row["C_VALUE"] != null)
                {
                    model.C_VALUE = row["C_VALUE"].ToString();
                }
                if (row["C_REMARK"] != null)
                {
                    model.C_REMARK = row["C_REMARK"].ToString();
                }
                if (row["N_STATUS"] != null && row["N_STATUS"].ToString() != "")
                {
                    model.N_STATUS = decimal.Parse(row["N_STATUS"].ToString());
                }
                if (row["C_EMP_ID"] != null)
                {
                    model.C_EMP_ID = row["C_EMP_ID"].ToString();
                }
                if (row["D_MOD_DT"] != null && row["D_MOD_DT"].ToString() != "")
                {
                    model.D_MOD_DT = DateTime.Parse(row["D_MOD_DT"].ToString());
                }
                if (row["C_MONTH"] != null)
                {
                    model.C_MONTH = row["C_MONTH"].ToString();
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
            strSql.Append("select C_ID,C_DATE,C_STA,C_VALUE,C_REMARK,N_STATUS,C_EMP_ID,D_MOD_DT,C_MONTH ");
            strSql.Append(" FROM TPB_STA_CN ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList_sta(string dat, string staID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  t.C_DATE as 日期,t.C_STA as 车间,t.C_VALUE as 产能,t.C_REMARK as 备注,t.N_STATUS,T1.C_NAME AS 操作人员,t.D_MOD_DT as 操作时间 ");
            strSql.Append(" FROM TPB_STA_CN t LEFT JOIN ts_user t1 ON  t.c_emp_id=t1.c_id where t.N_STATUS=1 and c_remark='" + staID + "' and SUBSTR(T.C_DATE,1,7)='" + dat + "' ");

            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList_sta_Item(string dat, string staID,string C_MONTH )
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT T.C_DATE   AS 日期, T.C_MONTH , T.C_REMARK AS 备注, T.N_STATUS,  T1.C_NAME AS 操作人员,  MAX( T.D_MOD_DT) as 操作时间 FROM TPB_STA_CN T  LEFT JOIN TS_USER T1  ON T.C_EMP_ID = T1.C_ID  WHERE t.N_STATUS = 1 AND t.c_remark='" + staID + "'  and   SUBSTR(T.C_DATE,1,7) ='" + dat + "' AND T.C_MONTH ='"+ C_MONTH + "' ");
            strSql.Append(" GROUP BY T.C_DATE,  T.C_REMARK,  T.N_STATUS, T1.C_NAME ,T.C_MONTH ");

            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM TPB_STA_CN ");
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
            strSql.Append(")AS Row, T.*  from TPB_STA_CN T ");
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
					new OracleParameter(":PageSize", OracleDbType.Number),
					new OracleParameter(":PageIndex", OracleDbType.Number),
					new OracleParameter(":IsReCount", OracleDbType.Clob),
					new OracleParameter(":OrderType", OracleDbType.Clob),
					new OracleParameter(":strWhere", OracleDbType.Varchar2,1000),
					};
			parameters[0].Value = "TPB_STA_CN";
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

