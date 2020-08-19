using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;
namespace DAL
{
    /// <summary>
    /// 数据访问类:TB_ZG_PLAN_LOG
    /// </summary>
    public partial class Dal_TB_ZG_PLAN_LOG
    {
        public Dal_TB_ZG_PLAN_LOG()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string C_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TB_ZG_PLAN_LOG");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)         };
            parameters[0].Value = C_ID;

            return DbHelperOra.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Mod_TB_ZG_PLAN_LOG model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TB_ZG_PLAN_LOG(");
            strSql.Append("C_PLAN_NAME,C_REASON,C_EMP_ID,C_EMP_NAME,D_MOD_DT,C_REMARK)");
            strSql.Append(" values (");
            strSql.Append(":C_PLAN_NAME,:C_REASON,:C_EMP_ID,:C_EMP_NAME,:D_MOD_DT,:C_REMARK)");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_PLAN_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_REASON", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_EMP_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500)};
            parameters[0].Value = model.C_PLAN_NAME;
            parameters[1].Value = model.C_REASON;
            parameters[2].Value = model.C_EMP_ID;
            parameters[3].Value = model.C_EMP_NAME;
            parameters[4].Value = model.D_MOD_DT;
            parameters[5].Value = model.C_REMARK;

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
        public bool Update(Mod_TB_ZG_PLAN_LOG model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TB_ZG_PLAN_LOG set ");
            strSql.Append("C_PLAN_NAME=:C_PLAN_NAME,");
            strSql.Append("C_REASON=:C_REASON,");
            strSql.Append("C_EMP_ID=:C_EMP_ID,");
            strSql.Append("C_EMP_NAME=:C_EMP_NAME,");
            strSql.Append("D_MOD_DT=:D_MOD_DT,");
            strSql.Append("C_REMARK=:C_REMARK");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_PLAN_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_REASON", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_EMP_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.C_PLAN_NAME;
            parameters[1].Value = model.C_REASON;
            parameters[2].Value = model.C_EMP_ID;
            parameters[3].Value = model.C_EMP_NAME;
            parameters[4].Value = model.D_MOD_DT;
            parameters[5].Value = model.C_REMARK;
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
            strSql.Append("delete from TB_ZG_PLAN_LOG ");
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
            strSql.Append("delete from TB_ZG_PLAN_LOG ");
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
        public Mod_TB_ZG_PLAN_LOG GetModel(string C_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_PLAN_NAME,C_REASON,C_EMP_ID,C_EMP_NAME,D_MOD_DT,C_REMARK from TB_ZG_PLAN_LOG ");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)         };
            parameters[0].Value = C_ID;

            Mod_TB_ZG_PLAN_LOG model = new Mod_TB_ZG_PLAN_LOG();
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
        public Mod_TB_ZG_PLAN_LOG DataRowToModel(DataRow row)
        {
            Mod_TB_ZG_PLAN_LOG model = new Mod_TB_ZG_PLAN_LOG();
            if (row != null)
            {
                if (row["C_ID"] != null)
                {
                    model.C_ID = row["C_ID"].ToString();
                }
                if (row["C_PLAN_NAME"] != null)
                {
                    model.C_PLAN_NAME = row["C_PLAN_NAME"].ToString();
                }
                if (row["C_REASON"] != null)
                {
                    model.C_REASON = row["C_REASON"].ToString();
                }
                if (row["C_EMP_ID"] != null)
                {
                    model.C_EMP_ID = row["C_EMP_ID"].ToString();
                }
                if (row["C_EMP_NAME"] != null)
                {
                    model.C_EMP_NAME = row["C_EMP_NAME"].ToString();
                }
                if (row["D_MOD_DT"] != null && row["D_MOD_DT"].ToString() != "")
                {
                    model.D_MOD_DT = DateTime.Parse(row["D_MOD_DT"].ToString());
                }
                if (row["C_REMARK"] != null)
                {
                    model.C_REMARK = row["C_REMARK"].ToString();
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
            strSql.Append("select C_ID,C_PLAN_NAME,C_REASON,C_EMP_ID,C_EMP_NAME,D_MOD_DT,C_REMARK ");
            strSql.Append(" FROM TB_ZG_PLAN_LOG ");
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
            strSql.Append("select count(1) FROM TB_ZG_PLAN_LOG ");
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
            strSql.Append(")AS Row, T.*  from TB_ZG_PLAN_LOG T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取排产名称
        /// </summary>
        public string Get_Pc_Name()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT nvl(MAX(T.C_PLAN_NAME)+1,TO_CHAR(SYSDATE, 'YYYYMMDD')||'001')  FROM TB_ZG_PLAN_LOG T WHERE SUBSTR(T.C_PLAN_NAME, 1, 8) = TO_CHAR(SYSDATE, 'YYYYMMDD') ");

            object obj = DbHelperOra.GetSingle(strSql.ToString());
            if (obj == null)
            {
                return "0";
            }
            else
            {
                return obj.ToString();
            }
        }


        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strTime1, string strTime2)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_PLAN_NAME,C_REASON,C_EMP_ID,C_EMP_NAME,D_MOD_DT,C_REMARK ");
            strSql.Append(" FROM TB_ZG_PLAN_LOG ");
            strSql.Append(" where d_mod_dt between to_date('" + strTime1 + "','yyyy-mm-dd hh24:mi:ss') and to_date('" + strTime2 + "','yyyy-mm-dd hh24:mi:ss') ");
            strSql.Append(" order by C_PLAN_NAME desc ");

            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 查询轧钢计划
        /// </summary>
        /// <param name="P_PC_NAME">排产名称</param>
        /// <param name="P_STL_GRD">钢种</param>
        /// <param name="P_STD_CODE">执行标准</param>
        /// <returns></returns>
        public DataSet Get_Plan_List(string P_PC_NAME, string P_STL_GRD, string P_STD_CODE, string P_STA_ID)
        {
            OracleParameter[] parameters = {
                    new OracleParameter("P_PC_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter("P_STL_GRD", OracleDbType.Varchar2,100),
                    new OracleParameter("P_STD_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter("P_STA_ID", OracleDbType.Varchar2,100),
                    new OracleParameter("P_CUR", OracleDbType.RefCursor)};

            parameters[0].Value = P_PC_NAME;
            parameters[1].Value = P_STL_GRD;
            parameters[2].Value = P_STD_CODE;
            parameters[3].Value = P_STA_ID;
            parameters[4].Value = null;

            return DbHelperOra.RunProcedure("PKG_P_PLAN.P_ZG_PLAN_LOG", parameters, "ds");
        }

        #endregion  BasicMethod
        #region  ExtensionMethod

        #endregion  ExtensionMethod
    }
}

