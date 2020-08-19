using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;
namespace DAL
{
    /// <summary>
    /// 数据访问类:TPP_TURNAROUND_PLAN
    /// </summary>
    public partial class Dal_TPP_TURNAROUND_PLAN
    {
        public Dal_TPP_TURNAROUND_PLAN()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string C_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TPP_TURNAROUND_PLAN");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)            };
            parameters[0].Value = C_ID;

            return DbHelperOra.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Mod_TPP_TURNAROUND_PLAN model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TPP_TURNAROUND_PLAN(");
            strSql.Append("C_STA_ID,D_START_TIME,D_END_TIME,C_PLAN_TYPE,C_REMARK,N_STATUS,C_EMP_ID,C_SH_EMP_ID,D_SH_MOD_DT,C_TYPE,C_STA_CODE,C_PRO_CODE,N_TIEM)");
            strSql.Append(" values (");
            strSql.Append(":C_STA_ID,:D_START_TIME,:D_END_TIME,:C_PLAN_TYPE,:C_REMARK,:N_STATUS,:C_EMP_ID,:C_SH_EMP_ID,:D_SH_MOD_DT,:C_TYPE,:C_STA_CODE,:C_PRO_CODE,:N_TIEM)");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_STA_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_START_TIME", OracleDbType.Date),
                    new OracleParameter(":D_END_TIME", OracleDbType.Date),
                    new OracleParameter(":C_PLAN_TYPE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
                    new OracleParameter(":N_STATUS", OracleDbType.Int16,4),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SH_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_SH_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":C_TYPE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STA_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PRO_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_TIEM", OracleDbType.Int16,5)};
            parameters[0].Value = model.C_STA_ID;
            parameters[1].Value = model.D_START_TIME;
            parameters[2].Value = model.D_END_TIME;
            parameters[3].Value = model.C_PLAN_TYPE;
            parameters[4].Value = model.C_REMARK;
            parameters[5].Value = model.N_STATUS;
            parameters[6].Value = model.C_EMP_ID;
            parameters[7].Value = model.C_SH_EMP_ID;
            parameters[8].Value = model.D_SH_MOD_DT;
            parameters[9].Value = model.C_TYPE;
            parameters[10].Value = model.C_STA_CODE;
            parameters[11].Value = model.C_PRO_CODE;
            parameters[12].Value = model.N_TIEM;

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
        public bool Update(Mod_TPP_TURNAROUND_PLAN model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TPP_TURNAROUND_PLAN set ");
            strSql.Append("C_STA_ID=:C_STA_ID,");
            strSql.Append("D_START_TIME=:D_START_TIME,");
            strSql.Append("D_END_TIME=:D_END_TIME,");
            strSql.Append("C_PLAN_TYPE=:C_PLAN_TYPE,");
            strSql.Append("C_REMARK=:C_REMARK,");
            strSql.Append("N_STATUS=:N_STATUS,");
            strSql.Append("C_EMP_ID=:C_EMP_ID,");
            strSql.Append("D_MOD_DT=:D_MOD_DT,");
            strSql.Append("C_SH_EMP_ID=:C_SH_EMP_ID,");
            strSql.Append("D_SH_MOD_DT=:D_SH_MOD_DT,");
            strSql.Append("C_TYPE=:C_TYPE,");
            strSql.Append("C_STA_CODE=:C_STA_CODE,");
            strSql.Append("C_PRO_CODE=:C_PRO_CODE,");
            strSql.Append("N_TIEM=:N_TIEM");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_STA_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_START_TIME", OracleDbType.Date),
                    new OracleParameter(":D_END_TIME", OracleDbType.Date),
                    new OracleParameter(":C_PLAN_TYPE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
                    new OracleParameter(":N_STATUS", OracleDbType.Int16,4),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":C_SH_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_SH_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":C_TYPE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STA_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PRO_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_TIEM", OracleDbType.Int16,5),
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.C_STA_ID;
            parameters[1].Value = model.D_START_TIME;
            parameters[2].Value = model.D_END_TIME;
            parameters[3].Value = model.C_PLAN_TYPE;
            parameters[4].Value = model.C_REMARK;
            parameters[5].Value = model.N_STATUS;
            parameters[6].Value = model.C_EMP_ID;
            parameters[7].Value = model.D_MOD_DT;
            parameters[8].Value = model.C_SH_EMP_ID;
            parameters[9].Value = model.D_SH_MOD_DT;
            parameters[10].Value = model.C_TYPE;
            parameters[11].Value = model.C_STA_CODE;
            parameters[12].Value = model.C_PRO_CODE;
            parameters[13].Value = model.N_TIEM;
            parameters[14].Value = model.C_ID;

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
            strSql.Append("delete from TPP_TURNAROUND_PLAN ");
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
            strSql.Append("delete from TPP_TURNAROUND_PLAN ");
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
        public Mod_TPP_TURNAROUND_PLAN GetModel(string C_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_STA_ID,D_START_TIME,D_END_TIME,C_PLAN_TYPE,C_REMARK,N_STATUS,C_EMP_ID,D_MOD_DT,C_SH_EMP_ID,D_SH_MOD_DT,C_TYPE,C_STA_CODE,C_PRO_CODE,N_TIEM from TPP_TURNAROUND_PLAN ");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)            };
            parameters[0].Value = C_ID;

            Mod_TPP_TURNAROUND_PLAN model = new Mod_TPP_TURNAROUND_PLAN();
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
        public Mod_TPP_TURNAROUND_PLAN DataRowToModel(DataRow row)
        {
            Mod_TPP_TURNAROUND_PLAN model = new Mod_TPP_TURNAROUND_PLAN();
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
                if (row["D_START_TIME"] != null && row["D_START_TIME"].ToString() != "")
                {
                    model.D_START_TIME = DateTime.Parse(row["D_START_TIME"].ToString());
                }
                if (row["D_END_TIME"] != null && row["D_END_TIME"].ToString() != "")
                {
                    model.D_END_TIME = DateTime.Parse(row["D_END_TIME"].ToString());
                }
                if (row["C_PLAN_TYPE"] != null)
                {
                    model.C_PLAN_TYPE = row["C_PLAN_TYPE"].ToString();
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
                if (row["C_SH_EMP_ID"] != null)
                {
                    model.C_SH_EMP_ID = row["C_SH_EMP_ID"].ToString();
                }
                if (row["D_SH_MOD_DT"] != null && row["D_SH_MOD_DT"].ToString() != "")
                {
                    model.D_SH_MOD_DT = DateTime.Parse(row["D_SH_MOD_DT"].ToString());
                }
                if (row["C_TYPE"] != null)
                {
                    model.C_TYPE = row["C_TYPE"].ToString();
                }
                if (row["C_STA_CODE"] != null)
                {
                    model.C_STA_CODE = row["C_STA_CODE"].ToString();
                }
                if (row["C_PRO_CODE"] != null)
                {
                    model.C_PRO_CODE = row["C_PRO_CODE"].ToString();
                }
                if (row["N_TIEM"] != null && row["N_TIEM"].ToString() != "")
                {
                    model.N_TIEM = decimal.Parse(row["N_TIEM"].ToString());
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
            strSql.Append("select C_ID,C_STA_ID,D_START_TIME,D_END_TIME,C_PLAN_TYPE,C_REMARK,N_STATUS,C_EMP_ID,D_MOD_DT,C_SH_EMP_ID,D_SH_MOD_DT,C_TYPE,C_STA_CODE,C_PRO_CODE,N_TIEM ");
            strSql.Append(" FROM TPP_TURNAROUND_PLAN ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_STA_ID,D_START_TIME,D_END_TIME,C_PLAN_TYPE,C_REMARK,N_STATUS,C_EMP_ID,D_MOD_DT,C_SH_EMP_ID,D_SH_MOD_DT,C_TYPE,C_STA_CODE,C_PRO_CODE,N_TIEM ");
            strSql.Append(" FROM TPP_TURNAROUND_PLAN ");

            strSql.Append(" where n_status=2 and d_start_time is not null and d_end_time is not null and d_end_time>sysdate ");

            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM TPP_TURNAROUND_PLAN ");
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
            strSql.Append(")AS Row, T.*  from TPP_TURNAROUND_PLAN T ");
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
        /// 查询检修计划
        /// </summary>
        /// <param name="dtFrom">检修开始时间</param>
        /// <param name="dtTo">检修结束时间</param>
        /// <param name="strSta">工位</param>
        /// <param name="strJxlb">检修类别</param>
        /// <param name="iStatus">状态</param>
        /// <param name="strpro">工序</param>
        public DataSet BindInfo(DateTime? dtFrom, DateTime? dtTo, string strSta, string strJxlb, int? iStatus, string strpro)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,D_START_TIME,D_END_TIME,C_PLAN_TYPE,C_REMARK,N_STATUS,C_EMP_ID,D_MOD_DT,C_SH_EMP_ID,D_SH_MOD_DT,C_TYPE,C_STA_CODE,C_PRO_CODE,N_TIEM ");
            strSql.Append(" FROM TPP_TURNAROUND_PLAN  where 1=1 ");
            if (dtFrom != null)
            {
                strSql.Append(" and D_START_TIME>=TO_DATE('" + dtFrom.ToString() + "','YYYY-MM-DD HH24:MI:SS') ");
            }
            if (dtTo != null)
            {
                strSql.Append(" and D_START_TIME<=TO_DATE('" + dtTo.ToString() + "','YYYY-MM-DD HH24:MI:SS')  ");
            }
            if (strSta.Trim() != "")
            {
                strSql.Append(" and C_STA_CODE='" + strSta + "' ");
            }
            if (strJxlb.Trim() != "")
            {
                strSql.Append(" and C_PLAN_TYPE='" + strJxlb + "' ");
            }
            if (iStatus != null)
            {
                strSql.Append(" and N_STATUS= " + iStatus);
            }
            if (strpro.Trim() != "")
            {
                strSql.Append(" and C_PRO_CODE='" + strpro + "' ");
            }
            strSql.Append(" order by D_START_TIME ");

            return DbHelperOra.Query(strSql.ToString());

        }
        #endregion  ExtensionMethod
    }
}

