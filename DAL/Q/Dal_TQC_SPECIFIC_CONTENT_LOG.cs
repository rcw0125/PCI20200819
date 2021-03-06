﻿using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;
namespace DAL
{
    /// <summary>
    /// 数据访问类:TQC_SPECIFIC_CONTENT_LOG
    /// </summary>
    public partial class Dal_TQC_SPECIFIC_CONTENT_LOG
    {
        public Dal_TQC_SPECIFIC_CONTENT_LOG()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string C_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TQC_SPECIFIC_CONTENT_LOG");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)         };
            parameters[0].Value = C_ID;

            return DbHelperOra.Exists(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Mod_TQC_SPECIFIC_CONTENT_LOG model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TQC_SPECIFIC_CONTENT_LOG(");
            strSql.Append("C_BATCH_NO,C_CONTENT,C_TICK_NO,N_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT)");
            strSql.Append(" values (");
            strSql.Append(":C_BATCH_NO,:C_CONTENT,:C_TICK_NO,:N_STATUS,:C_REMARK,:C_EMP_ID,:D_MOD_DT)");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_BATCH_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CONTENT", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_TICK_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date)};
            parameters[0].Value = model.C_BATCH_NO;
            parameters[1].Value = model.C_CONTENT;
            parameters[2].Value = model.C_TICK_NO;
            parameters[3].Value = model.N_STATUS;
            parameters[4].Value = model.C_REMARK;
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
        /// 增加一条数据
        /// </summary>
        public bool Add_Trans(Mod_TQC_SPECIFIC_CONTENT_LOG model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TQC_SPECIFIC_CONTENT_LOG(");
            strSql.Append("C_BATCH_NO,C_CONTENT,C_TICK_NO,N_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT)");
            strSql.Append(" values (");
            strSql.Append(":C_BATCH_NO,:C_CONTENT,:C_TICK_NO,:N_STATUS,:C_REMARK,:C_EMP_ID,:D_MOD_DT)");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_BATCH_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CONTENT", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_TICK_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date)};
            parameters[0].Value = model.C_BATCH_NO;
            parameters[1].Value = model.C_CONTENT;
            parameters[2].Value = model.C_TICK_NO;
            parameters[3].Value = model.N_STATUS;
            parameters[4].Value = model.C_REMARK;
            parameters[5].Value = model.C_EMP_ID;
            parameters[6].Value = model.D_MOD_DT;

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
        public bool Update(Mod_TQC_SPECIFIC_CONTENT_LOG model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TQC_SPECIFIC_CONTENT_LOG set ");
            strSql.Append("C_BATCH_NO=:C_BATCH_NO,");
            strSql.Append("C_CONTENT=:C_CONTENT,");
            strSql.Append("C_TICK_NO=:C_TICK_NO,");
            strSql.Append("N_STATUS=:N_STATUS,");
            strSql.Append("C_REMARK=:C_REMARK,");
            strSql.Append("C_EMP_ID=:C_EMP_ID,");
            strSql.Append("D_MOD_DT=:D_MOD_DT");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_BATCH_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CONTENT", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_TICK_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.C_BATCH_NO;
            parameters[1].Value = model.C_CONTENT;
            parameters[2].Value = model.C_TICK_NO;
            parameters[3].Value = model.N_STATUS;
            parameters[4].Value = model.C_REMARK;
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
            strSql.Append("delete from TQC_SPECIFIC_CONTENT_LOG ");
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
            strSql.Append("delete from TQC_SPECIFIC_CONTENT_LOG ");
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
        public Mod_TQC_SPECIFIC_CONTENT_LOG GetModel(string C_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_BATCH_NO,C_CONTENT,C_TICK_NO,N_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT from TQC_SPECIFIC_CONTENT_LOG ");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)         };
            parameters[0].Value = C_ID;

            Mod_TQC_SPECIFIC_CONTENT_LOG model = new Mod_TQC_SPECIFIC_CONTENT_LOG();
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
        public Mod_TQC_SPECIFIC_CONTENT_LOG DataRowToModel(DataRow row)
        {
            Mod_TQC_SPECIFIC_CONTENT_LOG model = new Mod_TQC_SPECIFIC_CONTENT_LOG();
            if (row != null)
            {
                if (row["C_ID"] != null)
                {
                    model.C_ID = row["C_ID"].ToString();
                }
                if (row["C_BATCH_NO"] != null)
                {
                    model.C_BATCH_NO = row["C_BATCH_NO"].ToString();
                }
                if (row["C_CONTENT"] != null)
                {
                    model.C_CONTENT = row["C_CONTENT"].ToString();
                }
                if (row["C_TICK_NO"] != null)
                {
                    model.C_TICK_NO = row["C_TICK_NO"].ToString();
                }
                if (row["N_STATUS"] != null && row["N_STATUS"].ToString() != "")
                {
                    model.N_STATUS = decimal.Parse(row["N_STATUS"].ToString());
                }
                if (row["C_REMARK"] != null)
                {
                    model.C_REMARK = row["C_REMARK"].ToString();
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
            strSql.Append("select C_ID,C_BATCH_NO,C_CONTENT,C_TICK_NO,N_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT ");
            strSql.Append(" FROM TQC_SPECIFIC_CONTENT_LOG ");
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
            strSql.Append("select count(1) FROM TQC_SPECIFIC_CONTENT_LOG ");
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
            strSql.Append(")AS Row, T.*  from TQC_SPECIFIC_CONTENT_LOG T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string C_BATCH_NO, string strTime1, string strTime2)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT TA.C_BATCH_NO,TA.C_TICK_NO,TA.C_CONTENT,TB.C_NAME,TA.D_MOD_DT FROM TQC_SPECIFIC_CONTENT_LOG TA INNER JOIN TS_USER TB ON TA.C_EMP_ID=TB.C_ID WHERE 1=1 ");

            if (!string.IsNullOrEmpty(strTime1) && !string.IsNullOrEmpty(strTime2))
            {
                strSql.Append(" AND TA.D_MOD_DT BETWEEN to_date('" + strTime1 + "','yyyy-mm-dd hh24:mi:ss') AND to_date('" + strTime2 + "','yyyy-mm-dd hh24:mi:ss') ");                
            }

            if (!string.IsNullOrEmpty(C_BATCH_NO))
            {
                strSql.Append(" and TA.C_BATCH_NO LIKE '" + C_BATCH_NO + "%' ");
            }

            return DbHelperOra.Query(strSql.ToString());
        }

        #endregion  BasicMethod
        #region  ExtensionMethod

        #endregion  ExtensionMethod
    }
}

