using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;
namespace DAL
{
    /// <summary>
    /// 数据访问类:TPB_WASTE_RATIO
    /// </summary>
    public partial class Dal_TPB_WASTE_RATIO
    {
        public Dal_TPB_WASTE_RATIO()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string C_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TPB_WASTE_RATIO");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)            };
            parameters[0].Value = C_ID;

            return DbHelperOra.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Mod_TPB_WASTE_RATIO model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TPB_WASTE_RATIO(");
            strSql.Append("C_STA_ID,N_WGT,N_TS_WGT,N_STATUS,C_EMP_ID,C_REMARK,N_FG_WGT,N_CG_WGT,C_STA_NAME)");
            strSql.Append(" values (");
            strSql.Append(":C_STA_ID,:N_WGT,:N_TS_WGT,:N_STATUS,:C_EMP_ID,:C_REMARK,:N_FG_WGT,:N_CG_WGT,:C_STA_NAME)");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_STA_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_WGT", OracleDbType.Int16,3),
                    new OracleParameter(":N_TS_WGT", OracleDbType.Int16,3),
                    new OracleParameter(":N_STATUS", OracleDbType.Int16,1),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
                    new OracleParameter(":N_FG_WGT", OracleDbType.Int16,3),
                    new OracleParameter(":N_CG_WGT", OracleDbType.Int16,3),
                    new OracleParameter(":C_STA_NAME", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.C_STA_ID;
            parameters[1].Value = model.N_WGT;
            parameters[2].Value = model.N_TS_WGT;
            parameters[3].Value = model.N_STATUS;
            parameters[4].Value = model.C_EMP_ID;
            parameters[5].Value = model.C_REMARK;
            parameters[6].Value = model.N_FG_WGT;
            parameters[7].Value = model.N_CG_WGT;
            parameters[8].Value =  model.C_STA_NAME;

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
        public bool Update(Mod_TPB_WASTE_RATIO model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TPB_WASTE_RATIO set ");
            strSql.Append("C_STA_ID=:C_STA_ID,");
            strSql.Append("N_WGT=:N_WGT,");
            strSql.Append("N_TS_WGT=:N_TS_WGT,");
            strSql.Append("N_STATUS=:N_STATUS,");
            strSql.Append("C_EMP_ID=:C_EMP_ID,");
            strSql.Append("D_MOD_DT=:D_MOD_DT,");
            strSql.Append("C_REMARK=:C_REMARK,");
            strSql.Append("N_FG_WGT=:N_FG_WGT,");
            strSql.Append("N_CG_WGT=:N_CG_WGT,");
            strSql.Append("C_STA_NAME=:C_STA_NAME");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_STA_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_WGT", OracleDbType.Int16,3),
                    new OracleParameter(":N_TS_WGT", OracleDbType.Int16,3),
                    new OracleParameter(":N_STATUS", OracleDbType.Int16,1),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
                    new OracleParameter(":N_FG_WGT", OracleDbType.Int16,3),
                    new OracleParameter(":N_CG_WGT", OracleDbType.Int16,3),
                    new OracleParameter(":C_STA_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.C_STA_ID;
            parameters[1].Value = model.N_WGT;
            parameters[2].Value = model.N_TS_WGT;
            parameters[3].Value = model.N_STATUS;
            parameters[4].Value = model.C_EMP_ID;
            parameters[5].Value = model.D_MOD_DT;
            parameters[6].Value = model.C_REMARK;
            parameters[7].Value = model.N_FG_WGT;
            parameters[8].Value = model.N_CG_WGT;
            parameters[9].Value = model.C_STA_NAME;
            parameters[10].Value = model.C_ID;

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
            strSql.Append("delete from TPB_WASTE_RATIO ");
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
            strSql.Append("delete from TPB_WASTE_RATIO ");
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
        public Mod_TPB_WASTE_RATIO GetModel(string C_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_STA_ID,N_WGT,N_TS_WGT,N_STATUS,C_EMP_ID,D_MOD_DT,C_REMARK,N_FG_WGT,N_CG_WGT,C_STA_NAME from TPB_WASTE_RATIO ");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)            };
            parameters[0].Value = C_ID;

            Mod_TPB_WASTE_RATIO model = new Mod_TPB_WASTE_RATIO();
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
        public Mod_TPB_WASTE_RATIO DataRowToModel(DataRow row)
        {
            Mod_TPB_WASTE_RATIO model = new Mod_TPB_WASTE_RATIO();
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
                if (row["N_WGT"] != null && row["N_WGT"].ToString() != "")
                {
                    model.N_WGT = decimal.Parse(row["N_WGT"].ToString());
                }
                if (row["N_TS_WGT"] != null && row["N_TS_WGT"].ToString() != "")
                {
                    model.N_TS_WGT = decimal.Parse(row["N_TS_WGT"].ToString());
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
                if (row["C_REMARK"] != null)
                {
                    model.C_REMARK = row["C_REMARK"].ToString();
                }
                if (row["N_FG_WGT"] != null && row["N_FG_WGT"].ToString() != "")
                {
                    model.N_FG_WGT = decimal.Parse(row["N_FG_WGT"].ToString());
                }
                if (row["N_CG_WGT"] != null && row["N_CG_WGT"].ToString() != "")
                {
                    model.N_CG_WGT = decimal.Parse(row["N_CG_WGT"].ToString());
                }
                if (row["C_STA_NAME"] != null)
                {
                    model.C_STA_NAME = row["C_STA_NAME"].ToString();
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
            strSql.Append("select C_ID,C_STA_ID,N_WGT,N_TS_WGT,N_STATUS,C_EMP_ID,D_MOD_DT,C_REMARK,N_FG_WGT,N_CG_WGT,C_STA_NAME ");
            strSql.Append(" FROM TPB_WASTE_RATIO ");
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
            strSql.Append("select count(1) FROM TPB_WASTE_RATIO ");
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
            strSql.Append(")AS Row, T.*  from TPB_WASTE_RATIO T ");
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
        /// 根据状态，工位获取数据
        /// </summary>
        /// <param name="status">状态</param>
        /// <param name="sta">工位</param>
        /// <returns></returns>
        public DataSet GetListByStatus(int status,string sta)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_STA_ID,N_WGT,N_TS_WGT,N_STATUS,C_EMP_ID,D_MOD_DT,C_REMARK,N_FG_WGT,N_CG_WGT,C_STA_NAME ");
            strSql.Append(" FROM TPB_WASTE_RATIO WHERE N_STATUS='"+status+"'");
            if (sta.Trim() != "")
            {
                strSql.Append(" AND C_STA_ID='"+ sta + "'");
            }
            return DbHelperOra.Query(strSql.ToString());
        }
        #endregion  ExtensionMethod
    }
}

