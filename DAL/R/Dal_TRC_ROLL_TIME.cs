using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;
using System.Collections.Generic;

namespace DAL
{
    /// <summary>
    /// 数据访问类:TRC_ROLL_TIME
    /// </summary>
    public partial class Dal_TRC_ROLL_TIME
    {
        public Dal_TRC_ROLL_TIME()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string C_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TRC_ROLL_TIME");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)         };
            parameters[0].Value = C_ID;

            return DbHelperOra.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Mod_TRC_ROLL_TIME model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TRC_ROLL_TIME(");
            strSql.Append("C_STA_ID,C_RQ,N_NUM_GRD,N_NUM_SPEC,C_TIME_SPEC)");
            strSql.Append(" values (");
            strSql.Append(":C_STA_ID,:C_RQ,:N_NUM_GRD,:N_NUM_SPEC,:C_TIME_SPEC)");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_STA_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_RQ", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_NUM_GRD", OracleDbType.Decimal,10),
                    new OracleParameter(":N_NUM_SPEC", OracleDbType.Decimal,10),
                    new OracleParameter(":C_TIME_SPEC", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.C_STA_ID;
            parameters[1].Value = model.C_RQ;
            parameters[2].Value = model.N_NUM_GRD;
            parameters[3].Value = model.N_NUM_SPEC;
            parameters[4].Value = model.C_TIME_SPEC;

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
        /// 增加一条数据
        /// </summary>
        public bool AddTran(Mod_TRC_ROLL_TIME model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TRC_ROLL_TIME(");
            strSql.Append("C_STA_ID,C_RQ,N_NUM_GRD,N_NUM_SPEC,C_TIME_SPEC)");
            strSql.Append(" values (");
            strSql.Append(":C_STA_ID,:C_RQ,:N_NUM_GRD,:N_NUM_SPEC,:C_TIME_SPEC)");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_STA_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_RQ", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_NUM_GRD", OracleDbType.Decimal,10),
                    new OracleParameter(":N_NUM_SPEC", OracleDbType.Decimal,10),
                    new OracleParameter(":C_TIME_SPEC", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.C_STA_ID;
            parameters[1].Value = model.C_RQ;
            parameters[2].Value = model.N_NUM_GRD;
            parameters[3].Value = model.N_NUM_SPEC;
            parameters[4].Value = model.C_TIME_SPEC;

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
        /// 更新一条数据
        /// </summary>
        public bool Update(Mod_TRC_ROLL_TIME model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TRC_ROLL_TIME set ");
            strSql.Append("C_STA_ID=:C_STA_ID,");
            strSql.Append("C_RQ=:C_RQ,");
            strSql.Append("N_NUM_GRD=:N_NUM_GRD,");
            strSql.Append("N_NUM_SPEC=:N_NUM_SPEC,");
            strSql.Append("C_TIME_SPEC=:C_TIME_SPEC");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_STA_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_RQ", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_NUM_GRD", OracleDbType.Decimal,10),
                    new OracleParameter(":N_NUM_SPEC", OracleDbType.Decimal,10),
                    new OracleParameter(":C_TIME_SPEC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.C_STA_ID;
            parameters[1].Value = model.C_RQ;
            parameters[2].Value = model.N_NUM_GRD;
            parameters[3].Value = model.N_NUM_SPEC;
            parameters[4].Value = model.C_TIME_SPEC;
            parameters[5].Value = model.C_ID;

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
        public bool UpdateTran(Mod_TRC_ROLL_TIME model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TRC_ROLL_TIME set ");
            strSql.Append("C_STA_ID=:C_STA_ID,");
            strSql.Append("C_RQ=:C_RQ,");
            strSql.Append("N_NUM_GRD=:N_NUM_GRD,");
            strSql.Append("N_NUM_SPEC=:N_NUM_SPEC,");
            strSql.Append("C_TIME_SPEC=:C_TIME_SPEC");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_STA_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_RQ", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_NUM_GRD", OracleDbType.Decimal,10),
                    new OracleParameter(":N_NUM_SPEC", OracleDbType.Decimal,10),
                    new OracleParameter(":C_TIME_SPEC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.C_STA_ID;
            parameters[1].Value = model.C_RQ;
            parameters[2].Value = model.N_NUM_GRD;
            parameters[3].Value = model.N_NUM_SPEC;
            parameters[4].Value = model.C_TIME_SPEC;
            parameters[5].Value = model.C_ID;

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
            strSql.Append("delete from TRC_ROLL_TIME ");
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
            strSql.Append("delete from TRC_ROLL_TIME ");
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
        public Mod_TRC_ROLL_TIME GetModel(string C_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_STA_ID,C_RQ,N_NUM_GRD,N_NUM_SPEC,C_TIME_SPEC from TRC_ROLL_TIME ");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)         };
            parameters[0].Value = C_ID;

            Mod_TRC_ROLL_TIME model = new Mod_TRC_ROLL_TIME();
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
        public Mod_TRC_ROLL_TIME DataRowToModel(DataRow row)
        {
            Mod_TRC_ROLL_TIME model = new Mod_TRC_ROLL_TIME();
            if (row != null)
            {
                if (row["C_ID"] != null)
                {
                    model.C_ID = row["C_ID"].ToString();
                }
                if (row["C_STA_ID"] != null)
                {
                    model.C_STA_ID = row["C_STA_ID"].ToString();
                }
                if (row["C_RQ"] != null)
                {
                    model.C_RQ = row["C_RQ"].ToString();
                }
                if (row["N_NUM_GRD"] != null && row["N_NUM_GRD"].ToString() != "")
                {
                    model.N_NUM_GRD = decimal.Parse(row["N_NUM_GRD"].ToString());
                }
                if (row["N_NUM_SPEC"] != null && row["N_NUM_SPEC"].ToString() != "")
                {
                    model.N_NUM_SPEC = decimal.Parse(row["N_NUM_SPEC"].ToString());
                }
                if (row["C_TIME_SPEC"] != null)
                {
                    model.C_TIME_SPEC = row["C_TIME_SPEC"].ToString();
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
            strSql.Append("select C_ID,C_STA_ID,C_RQ,N_NUM_GRD,N_NUM_SPEC,C_TIME_SPEC ");
            strSql.Append(" FROM TRC_ROLL_TIME ");
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
            strSql.Append("select tb.c_sta_desc as 轧线, ta.C_RQ as 日期, ta.N_NUM_GRD as 换钢种次数, ta.N_NUM_SPEC as 换规格次数, ta.C_TIME_SPEC as 换规格时间  FROM TRC_ROLL_TIME ta inner join tb_sta tb on ta.c_sta_id = tb.c_id  order by tb.c_sta_code, ta.c_rq ");


            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM TRC_ROLL_TIME ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            object obj = DbHelperNC.GetSingle(strSql.ToString());
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
            strSql.Append(")AS Row, T.*  from TRC_ROLL_TIME T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取记录总数
        /// </summary>
        public Mod_TRC_ROLL_TIME Get_Model(string C_STA_ID, string RQ)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_STA_ID,C_RQ,N_NUM_GRD,N_NUM_SPEC,C_TIME_SPEC from TRC_ROLL_TIME tt ");
            strSql.Append(" WHERE TT.C_STA_ID = '" + C_STA_ID + "' AND TT.C_RQ = '" + RQ + "' ");

            Mod_TRC_ROLL_TIME model = new Mod_TRC_ROLL_TIME();
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

        #endregion  BasicMethod
        #region  ExtensionMethod

        #endregion  ExtensionMethod
    }
}

