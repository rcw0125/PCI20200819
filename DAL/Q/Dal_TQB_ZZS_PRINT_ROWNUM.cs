using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;
namespace DAL
{
    /// <summary>
    /// 数据访问类:TQB_ZZS_PRINT_ROWNUM
    /// </summary>
    public partial class Dal_TQB_ZZS_PRINT_ROWNUM
    {
        public Dal_TQB_ZZS_PRINT_ROWNUM()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string C_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TQB_ZZS_PRINT_ROWNUM");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)            };
            parameters[0].Value = C_ID;

            return DbHelperOra.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Mod_TQB_ZZS_PRINT_ROWNUM model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TQB_ZZS_PRINT_ROWNUM(");
            strSql.Append("C_STL_GRD,C_STD_CODE,D_MOD_DT,C_EMP_ID,N_STATUS,N_ROWNUM)");
            strSql.Append(" values (");
            strSql.Append(":C_STL_GRD,:C_STD_CODE,:D_MOD_DT,:C_EMP_ID,:N_STATUS,:N_ROWNUM)");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_STL_GRD", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_STD_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
                    new OracleParameter(":N_ROWNUM", OracleDbType.Decimal,2)};
            parameters[0].Value = model.C_STL_GRD;
            parameters[1].Value = model.C_STD_CODE;
            parameters[2].Value = model.D_MOD_DT;
            parameters[3].Value = model.C_EMP_ID;
            parameters[4].Value = model.N_STATUS;
            parameters[5].Value = model.N_ROWNUM;

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
        public bool Update(Mod_TQB_ZZS_PRINT_ROWNUM model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TQB_ZZS_PRINT_ROWNUM set ");
            strSql.Append("C_STL_GRD=:C_STL_GRD,");
            strSql.Append("C_STD_CODE=:C_STD_CODE,");
            strSql.Append("D_MOD_DT=:D_MOD_DT,");
            strSql.Append("C_EMP_ID=:C_EMP_ID,");
            strSql.Append("N_STATUS=:N_STATUS,");
            strSql.Append("N_ROWNUM=:N_ROWNUM");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_STL_GRD", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_STD_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
                    new OracleParameter(":N_ROWNUM", OracleDbType.Decimal,2),
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.C_STL_GRD;
            parameters[1].Value = model.C_STD_CODE;
            parameters[2].Value = model.D_MOD_DT;
            parameters[3].Value = model.C_EMP_ID;
            parameters[4].Value = model.N_STATUS;
            parameters[5].Value = model.N_ROWNUM;
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
            strSql.Append("delete from TQB_ZZS_PRINT_ROWNUM ");
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
            strSql.Append("delete from TQB_ZZS_PRINT_ROWNUM ");
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
        public Mod_TQB_ZZS_PRINT_ROWNUM GetModel(string C_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_STL_GRD,C_STD_CODE,D_MOD_DT,C_EMP_ID,N_STATUS,N_ROWNUM from TQB_ZZS_PRINT_ROWNUM ");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)            };
            parameters[0].Value = C_ID;

            Mod_TQB_ZZS_PRINT_ROWNUM model = new Mod_TQB_ZZS_PRINT_ROWNUM();
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
        public Mod_TQB_ZZS_PRINT_ROWNUM DataRowToModel(DataRow row)
        {
            Mod_TQB_ZZS_PRINT_ROWNUM model = new Mod_TQB_ZZS_PRINT_ROWNUM();
            if (row != null)
            {
                if (row["C_ID"] != null)
                {
                    model.C_ID = row["C_ID"].ToString();
                }
                if (row["C_STL_GRD"] != null)
                {
                    model.C_STL_GRD = row["C_STL_GRD"].ToString();
                }
                if (row["C_STD_CODE"] != null)
                {
                    model.C_STD_CODE = row["C_STD_CODE"].ToString();
                }
                if (row["D_MOD_DT"] != null && row["D_MOD_DT"].ToString() != "")
                {
                    model.D_MOD_DT = DateTime.Parse(row["D_MOD_DT"].ToString());
                }
                if (row["C_EMP_ID"] != null)
                {
                    model.C_EMP_ID = row["C_EMP_ID"].ToString();
                }
                if (row["N_STATUS"] != null && row["N_STATUS"].ToString() != "")
                {
                    model.N_STATUS = decimal.Parse(row["N_STATUS"].ToString());
                }
                if (row["N_ROWNUM"] != null && row["N_ROWNUM"].ToString() != "")
                {
                    model.N_ROWNUM = decimal.Parse(row["N_ROWNUM"].ToString());
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
            strSql.Append("select C_ID,C_STL_GRD,C_STD_CODE,D_MOD_DT,C_EMP_ID,N_STATUS,N_ROWNUM ");
            strSql.Append(" FROM TQB_ZZS_PRINT_ROWNUM ");
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
            strSql.Append("select count(1) FROM TQB_ZZS_PRINT_ROWNUM ");
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
            strSql.Append(")AS Row, T.*  from TQB_ZZS_PRINT_ROWNUM T ");
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
        public DataSet GetList(string C_STL_GRD, string C_STD_CODE)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_STL_GRD,C_STD_CODE,D_MOD_DT,C_EMP_ID,N_STATUS,N_ROWNUM FROM TQB_ZZS_PRINT_ROWNUM WHERE N_STATUS=1 ");

            if (!string.IsNullOrEmpty(C_STL_GRD))
            {
                strSql.Append(" and C_STL_GRD like '%" + C_STL_GRD + "%' ");
            }

            if (!string.IsNullOrEmpty(C_STD_CODE))
            {
                strSql.Append(" and C_STD_CODE like '%" + C_STD_CODE + "%' ");
            }

            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string C_STL_GRD, string C_STD_CODE)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TQB_ZZS_PRINT_ROWNUM");
            strSql.Append(" where N_STATUS=1 and C_STL_GRD='" + C_STL_GRD + "' and C_STD_CODE='" + C_STD_CODE + "' ");

            return DbHelperOra.Exists(strSql.ToString());
        }

        #endregion  ExtensionMethod
    }
}

