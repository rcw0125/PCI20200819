using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;
namespace DAL
{
    /// <summary>
    /// 数据访问类:TPB_STA_HOOK_NO
    /// </summary>
    public partial class Dal_TPB_STA_HOOK_NO
    {
        public Dal_TPB_STA_HOOK_NO()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string C_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TPB_STA_HOOK_NO");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)         };
            parameters[0].Value = C_ID;

            return DbHelperOra.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Mod_TPB_STA_HOOK_NO model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TPB_STA_HOOK_NO(");
            strSql.Append("C_STA_ID,N_NO,C_HOOK_NAME,C_REMARK,N_STATUS,C_EMP_ID,D_MOD_DT,D_START_DATE,D_END_DATE)");
            strSql.Append(" values (");
            strSql.Append(":C_STA_ID,:N_NO,:C_HOOK_NAME,:C_REMARK,:N_STATUS,:C_EMP_ID,:D_MOD_DT,:D_START_DATE,:D_END_DATE)");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_STA_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_NO", OracleDbType.Decimal,3),
                    new OracleParameter(":C_HOOK_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,200),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":D_START_DATE", OracleDbType.Date),
                    new OracleParameter(":D_END_DATE", OracleDbType.Date)};
            parameters[0].Value = model.C_STA_ID;
            parameters[1].Value = model.N_NO;
            parameters[2].Value = model.C_HOOK_NAME;
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
        public bool Update(Mod_TPB_STA_HOOK_NO model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TPB_STA_HOOK_NO set ");
            strSql.Append("C_STA_ID=:C_STA_ID,");
            strSql.Append("N_NO=:N_NO,");
            strSql.Append("C_HOOK_NAME=:C_HOOK_NAME,");
            strSql.Append("C_REMARK=:C_REMARK,");
            strSql.Append("N_STATUS=:N_STATUS,");
            strSql.Append("C_EMP_ID=:C_EMP_ID,");
            strSql.Append("D_MOD_DT=:D_MOD_DT,");
            strSql.Append("D_START_DATE=:D_START_DATE,");
            strSql.Append("D_END_DATE=:D_END_DATE");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_STA_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_NO", OracleDbType.Decimal,3),
                    new OracleParameter(":C_HOOK_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,200),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":D_START_DATE", OracleDbType.Date),
                    new OracleParameter(":D_END_DATE", OracleDbType.Date),
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.C_STA_ID;
            parameters[1].Value = model.N_NO;
            parameters[2].Value = model.C_HOOK_NAME;
            parameters[3].Value = model.C_REMARK;
            parameters[4].Value = model.N_STATUS;
            parameters[5].Value = model.C_EMP_ID;
            parameters[6].Value = model.D_MOD_DT;
            parameters[7].Value = model.D_START_DATE;
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
            strSql.Append("delete from TPB_STA_HOOK_NO ");
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
            strSql.Append("delete from TPB_STA_HOOK_NO ");
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
        public Mod_TPB_STA_HOOK_NO GetModel(string C_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_STA_ID,N_NO,C_HOOK_NAME,C_REMARK,N_STATUS,C_EMP_ID,D_MOD_DT,D_START_DATE,D_END_DATE from TPB_STA_HOOK_NO ");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)         };
            parameters[0].Value = C_ID;

            Mod_TPB_STA_HOOK_NO model = new Mod_TPB_STA_HOOK_NO();
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
        public Mod_TPB_STA_HOOK_NO DataRowToModel(DataRow row)
        {
            Mod_TPB_STA_HOOK_NO model = new Mod_TPB_STA_HOOK_NO();
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
                if (row["N_NO"] != null && row["N_NO"].ToString() != "")
                {
                    model.N_NO = decimal.Parse(row["N_NO"].ToString());
                }
                if (row["C_HOOK_NAME"] != null)
                {
                    model.C_HOOK_NAME = row["C_HOOK_NAME"].ToString();
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
            strSql.Append("select C_ID,C_STA_ID,N_NO,C_HOOK_NAME,C_REMARK,N_STATUS,C_EMP_ID,D_MOD_DT,D_START_DATE,D_END_DATE ");
            strSql.Append(" FROM TPB_STA_HOOK_NO ");
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
            strSql.Append("select count(1) FROM TPB_STA_HOOK_NO ");
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
            strSql.Append(")AS Row, T.*  from TPB_STA_HOOK_NO T ");
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
        public DataSet GetListBySTA(string sta,string gh,string no)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_STA_ID,N_NO,C_HOOK_NAME,C_REMARK,N_STATUS,C_EMP_ID,D_MOD_DT,D_START_DATE,D_END_DATE ");
            strSql.Append(" FROM TPB_STA_HOOK_NO  where N_STATUS=1 ");
            if (sta.Trim() != "")
            {
                strSql.Append("AND  C_STA_ID='"+ sta + "' ");
            }
            if (gh.Trim() != "")
            {
                strSql.Append("AND C_HOOK_NAME='" + gh + "' ");
            }
            if (no.Trim() != "")
            {
                strSql.Append("AND N_NO='" + no + "' ");
            }
            strSql.Append(" ORDER BY C_STA_ID,N_NO ");
            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList_GH(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select t.C_ID,t.C_STA_ID,t.N_NO,t.C_HOOK_NAME,t.C_REMARK,t.N_STATUS,t.C_EMP_ID,t.D_MOD_DT,t.D_START_DATE,t.D_END_DATE ");
            strSql.Append(" from TPB_STA_HOOK_NO t inner join tb_sta ts on ts.c_id=t.c_sta_id where t.N_STATUS='1' and t.c_hook_name is not null ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" and  ts.c_sta_code='"+ strWhere + "'");
            }
            strSql.Append(" order by t.n_no  ");
            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取当前工位的自由钩号
        /// </summary>
        /// <param name="StrStaID">工位主键</param>
        /// <returns></returns>
        public DataTable GetFreeNO(string StrStaID)
        {
            string strSql = @"SELECT T.N_NO FROM TPB_STA_HOOK_NO T WHERE T.N_NO NOT IN  (SELECT TO_NUMBER(A.C_HOOK_NAME)   FROM TPB_STA_HOOK_NO A   WHERE A.C_STA_ID = '"+ StrStaID + "' AND nvl(a.c_hook_name, ' ') <> ' ')  AND T.C_STA_ID = '"+StrStaID+"' ORDER BY T.N_NO";
            return DbHelperOra.Query(strSql.ToString()).Tables[0];
        }
        #endregion  ExtensionMethod
    }
}
