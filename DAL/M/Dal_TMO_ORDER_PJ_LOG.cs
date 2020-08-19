﻿using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;
namespace DAL
{
    /// <summary>
    /// 数据访问类:TMO_ORDER_PJ_LOG
    /// </summary>
    public partial class Dal_TMO_ORDER_PJ_LOG
    {
        public Dal_TMO_ORDER_PJ_LOG()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string C_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TMO_ORDER_PJ_LOG");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)         };
            parameters[0].Value = C_ID;

            return DbHelperOra.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Mod_TMO_ORDER_PJ_LOG model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TMO_ORDER_PJ_LOG(");
            strSql.Append("C_TYPE,C_RESULT,C_MSG,D_MOD_DT,C_ORDER_NO,C_EMP_ID)");
            strSql.Append(" values (");
            strSql.Append(":C_TYPE,:C_RESULT,:C_MSG,:D_MOD_DT,:C_ORDER_NO,:C_EMP_ID)");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_TYPE", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_RESULT", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_MSG", OracleDbType.Varchar2,2000),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":C_ORDER_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.C_TYPE;
            parameters[1].Value = model.C_RESULT;
            parameters[2].Value = model.C_MSG;
            parameters[3].Value = model.D_MOD_DT;
            parameters[4].Value = model.C_ORDER_NO;
            parameters[5].Value = model.C_EMP_ID;

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
        public bool Update(Mod_TMO_ORDER_PJ_LOG model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TMO_ORDER_PJ_LOG set ");
            strSql.Append("C_TYPE=:C_TYPE,");
            strSql.Append("C_RESULT=:C_RESULT,");
            strSql.Append("C_MSG=:C_MSG,");
            strSql.Append("D_MOD_DT=:D_MOD_DT,");
            strSql.Append("C_ORDER_NO=:C_ORDER_NO,");
            strSql.Append("C_EMP_ID=:C_EMP_ID");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_TYPE", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_RESULT", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_MSG", OracleDbType.Varchar2,2000),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":C_ORDER_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.C_TYPE;
            parameters[1].Value = model.C_RESULT;
            parameters[2].Value = model.C_MSG;
            parameters[3].Value = model.D_MOD_DT;
            parameters[4].Value = model.C_ORDER_NO;
            parameters[5].Value = model.C_EMP_ID;
            parameters[6].Value = model.C_ID;

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
            strSql.Append("delete from TMO_ORDER_PJ_LOG ");
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
            strSql.Append("delete from TMO_ORDER_PJ_LOG ");
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
        public Mod_TMO_ORDER_PJ_LOG GetModel(string C_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_TYPE,C_RESULT,C_MSG,D_MOD_DT,C_ORDER_NO,C_EMP_ID from TMO_ORDER_PJ_LOG ");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)         };
            parameters[0].Value = C_ID;

            Mod_TMO_ORDER_PJ_LOG model = new Mod_TMO_ORDER_PJ_LOG();
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
        public Mod_TMO_ORDER_PJ_LOG DataRowToModel(DataRow row)
        {
            Mod_TMO_ORDER_PJ_LOG model = new Mod_TMO_ORDER_PJ_LOG();
            if (row != null)
            {
                if (row["C_ID"] != null)
                {
                    model.C_ID = row["C_ID"].ToString();
                }
                if (row["C_TYPE"] != null)
                {
                    model.C_TYPE = row["C_TYPE"].ToString();
                }
                if (row["C_RESULT"] != null)
                {
                    model.C_RESULT = row["C_RESULT"].ToString();
                }
                if (row["C_MSG"] != null)
                {
                    model.C_MSG = row["C_MSG"].ToString();
                }
                if (row["D_MOD_DT"] != null && row["D_MOD_DT"].ToString() != "")
                {
                    model.D_MOD_DT = DateTime.Parse(row["D_MOD_DT"].ToString());
                }
                if (row["C_ORDER_NO"] != null)
                {
                    model.C_ORDER_NO = row["C_ORDER_NO"].ToString();
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
            strSql.Append("select C_ID,C_TYPE,C_RESULT,C_MSG,D_MOD_DT,C_ORDER_NO,C_EMP_ID ");
            strSql.Append(" FROM TMO_ORDER_PJ_LOG ");
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
            strSql.Append("select count(1) FROM TMO_ORDER_PJ_LOG ");
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
            strSql.Append(")AS Row, T.*  from TMO_ORDER_PJ_LOG T ");
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
        /// 删除订单评价失败信息表
        /// </summary>
        /// <returns></returns>
        public bool DeleteLog()
        {
            string strSql = "DELETE FROM TMO_ORDER_PJ_LOG T";

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
        /// 获取未维护基础数据类型
        /// </summary>
        /// <returns>基础数据类型</returns>
        public DataSet GetLX()
        {
            string sql = "SELECT DISTINCT A.C_TYPE FROM TMO_ORDER_PJ_LOG A";
            return  DbHelperOra.Query(sql.ToString());
        }

        /// <summary>
        /// 按组统计未维护数据
        /// </summary>
        /// <param name="type">分类</param>
        /// <returns></returns>
        public DataSet GetWPJ(string type)
        {
            string sql = "";
            if (type== "钢种标准")
            {
                sql =  " SELECT T.C_STL_GRD,'' , T.C_STD_CODE, T.C_FREE1, T.C_FREE2, A.C_MSG FROM TMO_ORDER T, TMO_ORDER_PJ_LOG A WHERE T.C_ORDER_NO = A.C_ORDER_NO AND A.C_TYPE='"+ type + "' AND T.C_STD_CODE IS NULL GROUP BY T.C_STL_GRD, T.C_STD_CODE, T.C_FREE1, T.C_FREE2,  A.C_MSG ORDER BY T.C_STL_GRD, T.C_STD_CODE ";
            }
            else if (type == "钢坯定尺匹配" || type == "工艺路线" || type == "钢种铁水条件")
            {
                sql = " SELECT T.C_STL_GRD,'' , T.C_STD_CODE, T.C_FREE1, T.C_FREE2, A.C_MSG FROM TMO_ORDER T, TMO_ORDER_PJ_LOG A WHERE T.C_ORDER_NO = A.C_ORDER_NO AND A.C_TYPE='" + type + "' AND T.C_STD_CODE IS NOT NULL GROUP BY T.C_STL_GRD, T.C_STD_CODE, T.C_FREE1, T.C_FREE2,  A.C_MSG ORDER BY T.C_STL_GRD, T.C_STD_CODE ";
            }
            else
            {
                sql = "SELECT T.C_STL_GRD, T. C_SPEC, T.C_STD_CODE, T.C_FREE1, T.C_FREE2, A.C_MSG FROM TMO_ORDER T, TMO_ORDER_PJ_LOG A WHERE T.C_ORDER_NO = A.C_ORDER_NO AND A.C_TYPE = '"+ type + "' AND T.C_STD_CODE IS NOT NULL GROUP BY T.C_STL_GRD, T. C_SPEC, T.C_STD_CODE, T.C_FREE1, T.C_FREE2,  A.C_MSG ORDER BY T.C_STL_GRD, T.C_STD_CODE";
            }
            return DbHelperOra.Query(sql.ToString());

        }

        #endregion  ExtensionMethod
    }
}

