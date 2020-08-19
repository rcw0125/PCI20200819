using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;
namespace DAL
{
    /// <summary>
    /// 数据访问类:TRP_PLAN_REASON
    /// </summary>
    public partial class Dal_TRP_PLAN_REASON
    {
        public Dal_TRP_PLAN_REASON()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string C_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TRP_PLAN_REASON");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)            };
            parameters[0].Value = C_ID;

            return DbHelperOra.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Mod_TRP_PLAN_REASON model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TRP_PLAN_REASON(");
            strSql.Append("C_PLAN_ROLL_ID,C_ORDER_NO,C_STL_GRD,C_STD_CODE,C_SPEC,C_REASON,N_STATUS,C_EMP_ID,D_MOD_DT)");
            strSql.Append(" values (");
            strSql.Append(":C_PLAN_ROLL_ID,:C_ORDER_NO,:C_STL_GRD,:C_STD_CODE,:C_SPEC,:C_REASON,:N_STATUS,:C_EMP_ID,:D_MOD_DT)");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_PLAN_ROLL_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ORDER_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STL_GRD", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STD_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SPEC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_REASON", OracleDbType.Varchar2,500),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,2),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date)};
            parameters[0].Value = model.C_PLAN_ROLL_ID;
            parameters[1].Value = model.C_ORDER_NO;
            parameters[2].Value = model.C_STL_GRD;
            parameters[3].Value = model.C_STD_CODE;
            parameters[4].Value = model.C_SPEC;
            parameters[5].Value = model.C_REASON;
            parameters[6].Value = model.N_STATUS;
            parameters[7].Value = model.C_EMP_ID;
            parameters[8].Value = model.D_MOD_DT;

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
        public bool Update(Mod_TRP_PLAN_REASON model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TRP_PLAN_REASON set ");
            strSql.Append("C_PLAN_ROLL_ID=:C_PLAN_ROLL_ID,");
            strSql.Append("C_ORDER_NO=:C_ORDER_NO,");
            strSql.Append("C_STL_GRD=:C_STL_GRD,");
            strSql.Append("C_STD_CODE=:C_STD_CODE,");
            strSql.Append("C_SPEC=:C_SPEC,");
            strSql.Append("C_REASON=:C_REASON,");
            strSql.Append("N_STATUS=:N_STATUS,");
            strSql.Append("C_EMP_ID=:C_EMP_ID,");
            strSql.Append("D_MOD_DT=:D_MOD_DT");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_PLAN_ROLL_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ORDER_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STL_GRD", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STD_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SPEC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_REASON", OracleDbType.Varchar2,500),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,2),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.C_PLAN_ROLL_ID;
            parameters[1].Value = model.C_ORDER_NO;
            parameters[2].Value = model.C_STL_GRD;
            parameters[3].Value = model.C_STD_CODE;
            parameters[4].Value = model.C_SPEC;
            parameters[5].Value = model.C_REASON;
            parameters[6].Value = model.N_STATUS;
            parameters[7].Value = model.C_EMP_ID;
            parameters[8].Value = model.D_MOD_DT;
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
            strSql.Append("delete from TRP_PLAN_REASON ");
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
            strSql.Append("delete from TRP_PLAN_REASON ");
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
        public Mod_TRP_PLAN_REASON GetModel(string C_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_PLAN_ROLL_ID,C_ORDER_NO,C_STL_GRD,C_STD_CODE,C_SPEC,C_REASON,N_STATUS,C_EMP_ID,D_MOD_DT from TRP_PLAN_REASON ");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)            };
            parameters[0].Value = C_ID;

            Mod_TRP_PLAN_REASON model = new Mod_TRP_PLAN_REASON();
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
        public Mod_TRP_PLAN_REASON DataRowToModel(DataRow row)
        {
            Mod_TRP_PLAN_REASON model = new Mod_TRP_PLAN_REASON();
            if (row != null)
            {
                if (row["C_ID"] != null)
                {
                    model.C_ID = row["C_ID"].ToString();
                }
                if (row["C_PLAN_ROLL_ID"] != null)
                {
                    model.C_PLAN_ROLL_ID = row["C_PLAN_ROLL_ID"].ToString();
                }
                if (row["C_ORDER_NO"] != null)
                {
                    model.C_ORDER_NO = row["C_ORDER_NO"].ToString();
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
                if (row["C_REASON"] != null)
                {
                    model.C_REASON = row["C_REASON"].ToString();
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
            }
            return model;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_PLAN_ROLL_ID,C_ORDER_NO,C_STL_GRD,C_STD_CODE,C_SPEC,C_REASON,N_STATUS,C_EMP_ID,D_MOD_DT ");
            strSql.Append(" FROM TRP_PLAN_REASON ");
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
            strSql.Append("select count(1) FROM TRP_PLAN_REASON ");
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
            strSql.Append(")AS Row, T.*  from TRP_PLAN_REASON T ");
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
        public DataSet Get_List(string C_PLAN_ROLL_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_PLAN_ROLL_ID,C_ORDER_NO,C_STL_GRD,C_STD_CODE,C_SPEC,C_REASON,N_STATUS,C_EMP_ID,D_MOD_DT ");
            strSql.Append(" FROM TRP_PLAN_REASON WHERE C_PLAN_ROLL_ID='" + C_PLAN_ROLL_ID + "' ");

            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet Get_List(string strTime1, string strTime2, string C_STL_GRD, string C_STD_CODE, string C_SPEC)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_PLAN_ROLL_ID,C_ORDER_NO,C_STL_GRD,C_STD_CODE,C_SPEC,C_REASON,N_STATUS,C_EMP_ID,D_MOD_DT ");
            strSql.Append(" FROM TRP_PLAN_REASON WHERE 1=1 ");

            if (!string.IsNullOrEmpty(strTime1) && !string.IsNullOrEmpty(strTime2))
            {
                strSql.Append(" AND D_MOD_DT BETWEEN TO_DATE('" + strTime1 + "','yyyy-mm-dd hh24:mi:ss') and TO_DATE('" + strTime2 + "','yyyy-mm-dd hh24:mi:ss') ");
            }

            if (!string.IsNullOrEmpty(C_STL_GRD))
            {
                strSql.Append(" and C_STL_GRD like '%" + C_STL_GRD + "%' ");
            }

            if (!string.IsNullOrEmpty(C_STD_CODE))
            {
                strSql.Append(" and C_STD_CODE like '%" + C_STD_CODE + "%' ");
            }

            if (!string.IsNullOrEmpty(C_SPEC))
            {
                strSql.Append(" and C_SPEC like '%" + C_SPEC + "%' ");
            }

            return DbHelperOra.Query(strSql.ToString());
        }

        #endregion  BasicMethod

    }
}

