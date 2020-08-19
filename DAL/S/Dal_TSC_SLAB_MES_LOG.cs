using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;

namespace DAL
{
    /// <summary>
    /// 数据访问类:TSC_SLAB_MES_LOG
    /// </summary>
    public partial class Dal_TSC_SLAB_MES_LOG
    {
        public Dal_TSC_SLAB_MES_LOG()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string C_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TSC_SLAB_MES_LOG");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)         };
            parameters[0].Value = C_ID;

            return DbHelperOra.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Mod_TSC_SLAB_MES_LOG model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TSC_SLAB_MES_LOG(");
            strSql.Append("C_STA_DESC,C_STOVE,C_STL_GRD,C_STD_CODE,C_SPEC,C_LEN,C_MAT_CODE,C_MAT_NAME,C_QUA,C_WGT,D_DEL_TIME,C_DEL_USER,C_REASON)");
            strSql.Append(" values (");
            strSql.Append(":C_STA_DESC,:C_STOVE,:C_STL_GRD,:C_STD_CODE,:C_SPEC,:C_LEN,:C_MAT_CODE,:C_MAT_NAME,:C_QUA,:C_WGT,:D_DEL_TIME,:C_DEL_USER,:C_REASON)");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_STA_DESC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STOVE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STL_GRD", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_STD_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SPEC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_LEN", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MAT_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MAT_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_QUA", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_WGT", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_DEL_TIME", OracleDbType.Date),
                    new OracleParameter(":C_DEL_USER", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_REASON", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.C_STA_DESC;
            parameters[1].Value = model.C_STOVE;
            parameters[2].Value = model.C_STL_GRD;
            parameters[3].Value = model.C_STD_CODE;
            parameters[4].Value = model.C_SPEC;
            parameters[5].Value = model.C_LEN;
            parameters[6].Value = model.C_MAT_CODE;
            parameters[7].Value = model.C_MAT_NAME;
            parameters[8].Value = model.C_QUA;
            parameters[9].Value = model.C_WGT;
            parameters[10].Value = model.D_DEL_TIME;
            parameters[11].Value = model.C_DEL_USER;
            parameters[12].Value = model.C_REASON;

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
        public bool Update(Mod_TSC_SLAB_MES_LOG model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TSC_SLAB_MES_LOG set ");
            strSql.Append("C_STA_DESC=:C_STA_DESC,");
            strSql.Append("C_STOVE=:C_STOVE,");
            strSql.Append("C_STL_GRD=:C_STL_GRD,");
            strSql.Append("C_STD_CODE=:C_STD_CODE,");
            strSql.Append("C_SPEC=:C_SPEC,");
            strSql.Append("C_LEN=:C_LEN,");
            strSql.Append("C_MAT_CODE=:C_MAT_CODE,");
            strSql.Append("C_MAT_NAME=:C_MAT_NAME,");
            strSql.Append("C_QUA=:C_QUA,");
            strSql.Append("C_WGT=:C_WGT,");
            strSql.Append("D_DEL_TIME=:D_DEL_TIME,");
            strSql.Append("C_DEL_USER=:C_DEL_USER,");
            strSql.Append("C_REASON=:C_REASON");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_STA_DESC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STOVE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STL_GRD", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_STD_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SPEC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_LEN", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MAT_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MAT_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_QUA", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_WGT", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_DEL_TIME", OracleDbType.Date),
                    new OracleParameter(":C_DEL_USER", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_REASON", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.C_STA_DESC;
            parameters[1].Value = model.C_STOVE;
            parameters[2].Value = model.C_STL_GRD;
            parameters[3].Value = model.C_STD_CODE;
            parameters[4].Value = model.C_SPEC;
            parameters[5].Value = model.C_LEN;
            parameters[6].Value = model.C_MAT_CODE;
            parameters[7].Value = model.C_MAT_NAME;
            parameters[8].Value = model.C_QUA;
            parameters[9].Value = model.C_WGT;
            parameters[10].Value = model.D_DEL_TIME;
            parameters[11].Value = model.C_DEL_USER;
            parameters[12].Value = model.C_REASON;
            parameters[13].Value = model.C_ID;

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
            strSql.Append("delete from TSC_SLAB_MES_LOG ");
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
            strSql.Append("delete from TSC_SLAB_MES_LOG ");
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
        public Mod_TSC_SLAB_MES_LOG GetModel(string C_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_STA_DESC,C_STOVE,C_STL_GRD,C_STD_CODE,C_SPEC,C_LEN,C_MAT_CODE,C_MAT_NAME,C_QUA,C_WGT,D_DEL_TIME,C_DEL_USER,C_REASON from TSC_SLAB_MES_LOG ");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)         };
            parameters[0].Value = C_ID;

            Mod_TSC_SLAB_MES_LOG model = new Mod_TSC_SLAB_MES_LOG();
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
        public Mod_TSC_SLAB_MES_LOG DataRowToModel(DataRow row)
        {
            Mod_TSC_SLAB_MES_LOG model = new Mod_TSC_SLAB_MES_LOG();
            if (row != null)
            {
                if (row["C_ID"] != null)
                {
                    model.C_ID = row["C_ID"].ToString();
                }
                if (row["C_STA_DESC"] != null)
                {
                    model.C_STA_DESC = row["C_STA_DESC"].ToString();
                }
                if (row["C_STOVE"] != null)
                {
                    model.C_STOVE = row["C_STOVE"].ToString();
                }
                if (row["C_STL_GRD"] != null)
                {
                    model.C_STL_GRD = row["C_STL_GRD"].ToString();
                }
                if (row["C_STD_CODE"] != null)
                {
                    model.C_STD_CODE = row["C_STD_CODE"].ToString();
                }
                if (row["C_SPEC"] != null)
                {
                    model.C_SPEC = row["C_SPEC"].ToString();
                }
                if (row["C_LEN"] != null)
                {
                    model.C_LEN = row["C_LEN"].ToString();
                }
                if (row["C_MAT_CODE"] != null)
                {
                    model.C_MAT_CODE = row["C_MAT_CODE"].ToString();
                }
                if (row["C_MAT_NAME"] != null)
                {
                    model.C_MAT_NAME = row["C_MAT_NAME"].ToString();
                }
                if (row["C_QUA"] != null)
                {
                    model.C_QUA = row["C_QUA"].ToString();
                }
                if (row["C_WGT"] != null)
                {
                    model.C_WGT = row["C_WGT"].ToString();
                }
                if (row["D_DEL_TIME"] != null && row["D_DEL_TIME"].ToString() != "")
                {
                    model.D_DEL_TIME = DateTime.Parse(row["D_DEL_TIME"].ToString());
                }
                if (row["C_DEL_USER"] != null)
                {
                    model.C_DEL_USER = row["C_DEL_USER"].ToString();
                }
                if (row["C_REASON"] != null)
                {
                    model.C_REASON = row["C_REASON"].ToString();
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
            strSql.Append("select C_ID,C_STA_DESC,C_STOVE,C_STL_GRD,C_STD_CODE,C_SPEC,C_LEN,C_MAT_CODE,C_MAT_NAME,C_QUA,C_WGT,D_DEL_TIME,C_DEL_USER,C_REASON ");
            strSql.Append(" FROM TSC_SLAB_MES_LOG ");
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
            strSql.Append("select count(1) FROM TSC_SLAB_MES_LOG ");
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
            strSql.Append(")AS Row, T.*  from TSC_SLAB_MES_LOG T ");
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
        public DataSet Get_List(string C_STOVE, string strTime1, string strTime2)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select T.C_ID,T.C_STA_DESC,T.C_STOVE,T.C_STL_GRD,T.C_STD_CODE,T.C_SPEC,T.C_LEN,T.C_MAT_CODE,T.C_MAT_NAME,T.C_QUA,T.C_WGT,T.D_DEL_TIME,T.C_DEL_USER,T.C_REASON,TS.C_NAME ");
            strSql.Append(" FROM TSC_SLAB_MES_LOG T INNER JOIN TS_USER TS ON T.C_DEL_USER=TS.C_ID where 1=1 ");

            if (!string.IsNullOrEmpty(C_STOVE))
            {
                strSql.Append(" AND T.C_STOVE like '%" + C_STOVE + "%' ");
            }

            if (!string.IsNullOrEmpty(strTime1) && !string.IsNullOrEmpty(strTime2))
            {
                strSql.Append(" AND T.D_DEL_TIME BETWEEN to_date('" + strTime1 + "','yyyy-mm-dd hh24:mi:ss') and to_date('" + strTime2 + "','yyyy-mm-dd hh24:mi:ss') ");
            }

            strSql.Append(" ORDER BY T.D_DEL_TIME DESC ");

            return DbHelperOra.Query(strSql.ToString());
        }

        #endregion  ExtensionMethod
    }
}

