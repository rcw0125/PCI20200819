﻿using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;
namespace DAL
{
    /// <summary>
    /// 数据访问类:TPB_STA_HOOK_NUM
    /// </summary>
    public partial class Dal_TPB_STA_HOOK_NUM
    {
        public Dal_TPB_STA_HOOK_NUM()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string C_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TPB_STA_HOOK_NUM");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)         };
            parameters[0].Value = C_ID;

            return DbHelperOra.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Mod_TPB_STA_HOOK_NUM model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TPB_STA_HOOK_NUM(");
            strSql.Append("C_STA_ID,N_HOOK_NUM,N_ONLINE_NUM,C_REMARK,N_STATUS,C_EMP_ID,D_MOD_DT,D_START_DATE,D_END_DATE)");
            strSql.Append(" values (");
            strSql.Append(":C_STA_ID,:N_HOOK_NUM,:N_ONLINE_NUM,:C_REMARK,:N_STATUS,:C_EMP_ID,:D_MOD_DT,:D_START_DATE,:D_END_DATE)");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_STA_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_HOOK_NUM", OracleDbType.Decimal,5),
                     new OracleParameter(":N_ONLINE_NUM", OracleDbType.Decimal,5),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,200),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":D_START_DATE", OracleDbType.Date),
                    new OracleParameter(":D_END_DATE", OracleDbType.Date)};
            parameters[0].Value = model.C_STA_ID;
            parameters[1].Value = model.N_HOOK_NUM;
            parameters[2].Value = model.N_ONLINE_NUM;
            parameters[3].Value = model.C_REMARK;
            parameters[4].Value = model.N_STATUS;
            parameters[5].Value = model.C_EMP_ID;
            parameters[6].Value = model.D_MOD_DT;
            parameters[7].Value = model.D_START_DATE;
            parameters[8].Value = model.D_END_DATE;

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
        public bool Update(Mod_TPB_STA_HOOK_NUM model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TPB_STA_HOOK_NUM set ");
            strSql.Append("C_STA_ID=:C_STA_ID,");
            strSql.Append("N_HOOK_NUM=:N_HOOK_NUM,");
            strSql.Append("N_ONLINE_NUM=:N_ONLINE_NUM,");
            strSql.Append("C_REMARK=:C_REMARK,");
            strSql.Append("N_STATUS=:N_STATUS,");
            strSql.Append("C_EMP_ID=:C_EMP_ID,");
            strSql.Append("D_MOD_DT=:D_MOD_DT,");
            strSql.Append("D_START_DATE=:D_START_DATE,");
            strSql.Append("D_END_DATE=:D_END_DATE");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_STA_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_HOOK_NUM", OracleDbType.Decimal,5),
                     new OracleParameter(":N_ONLINE_NUM", OracleDbType.Decimal,5),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,200),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":D_START_DATE", OracleDbType.Date),
                    new OracleParameter(":D_END_DATE", OracleDbType.Date),
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.C_STA_ID;
            parameters[1].Value = model.N_HOOK_NUM;
            parameters[2].Value  = model.N_ONLINE_NUM;
            parameters[3].Value  = model.C_REMARK;
            parameters[4].Value  = model.N_STATUS;
            parameters[5].Value  = model.C_EMP_ID;
            parameters[6].Value  = model.D_MOD_DT;
            parameters[7].Value  = model.D_START_DATE;
            parameters[8].Value = model.D_END_DATE;
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
            strSql.Append("delete from TPB_STA_HOOK_NUM ");
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
            strSql.Append("delete from TPB_STA_HOOK_NUM ");
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
        public Mod_TPB_STA_HOOK_NUM GetModel(string C_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_STA_ID,N_HOOK_NUM,N_ONLINE_NUM,C_REMARK,N_STATUS,C_EMP_ID,D_MOD_DT,D_START_DATE,D_END_DATE from TPB_STA_HOOK_NUM ");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)         };
            parameters[0].Value = C_ID;

            Mod_TPB_STA_HOOK_NUM model = new Mod_TPB_STA_HOOK_NUM();
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
        public Mod_TPB_STA_HOOK_NUM DataRowToModel(DataRow row)
        {
            Mod_TPB_STA_HOOK_NUM model = new Mod_TPB_STA_HOOK_NUM();
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
                if (row["N_HOOK_NUM"] != null && row["N_HOOK_NUM"].ToString() != "")
                {
                    model.N_HOOK_NUM = decimal.Parse(row["N_HOOK_NUM"].ToString());
                }
               
                 if (row["N_ONLINE_NUM"] != null && row["N_ONLINE_NUM"].ToString() != "")
                {
                    model.N_ONLINE_NUM = decimal.Parse(row["N_ONLINE_NUM"].ToString());
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
                if (row["D_START_DATE"] != null && row["D_START_DATE"].ToString() != "")
                {
                    model.D_START_DATE = DateTime.Parse(row["D_START_DATE"].ToString());
                }
                if (row["D_END_DATE"] != null && row["D_END_DATE"].ToString() != "")
                {
                    model.D_END_DATE = DateTime.Parse(row["D_END_DATE"].ToString());
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
            strSql.Append("select C_ID,C_STA_ID,N_HOOK_NUM,N_ONLINE_NUM,C_REMARK,N_STATUS,C_EMP_ID,D_MOD_DT,D_START_DATE,D_END_DATE ");
            strSql.Append(" FROM TPB_STA_HOOK_NUM ");
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
            strSql.Append("select count(1) FROM TPB_STA_HOOK_NUM ");
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
            strSql.Append(")AS Row, T.*  from TPB_STA_HOOK_NUM T ");
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
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetListByStatus(int status, string C_STA_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_STA_ID,N_HOOK_NUM,N_ONLINE_NUM,C_REMARK,N_STATUS,C_EMP_ID,D_MOD_DT,D_START_DATE,D_END_DATE ");
            strSql.Append(" FROM TPB_STA_HOOK_NUM Where N_STATUS='" + status + "' ");
            if (C_STA_ID.Trim() != "")
            {
                strSql.Append(" AND C_STA_ID='" + C_STA_ID + "'");
            }
            strSql.Append(" ORDER BY TO_NUMBER(N_HOOK_NUM) ");
            return DbHelperOra.Query(strSql.ToString());
        }
        #endregion  ExtensionMethod
    }
}
