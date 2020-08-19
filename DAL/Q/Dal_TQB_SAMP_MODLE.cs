using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;

namespace DAL
{
    /// <summary>
    /// 数据访问类:TQB_SAMP_MODLE
    /// </summary>
    public partial class Dal_TQB_SAMP_MODLE
    {
        public Dal_TQB_SAMP_MODLE()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string C_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TQB_SAMP_MODLE");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)         };
            parameters[0].Value = C_ID;

            return DbHelperOra.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Mod_TQB_SAMP_MODLE model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TQB_SAMP_MODLE(");
            strSql.Append("C_STD_CODE,C_STL_GRD,C_SPEC_MIN,C_SPEC_MAX,N_SAM_NUM,N_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT)");
            strSql.Append(" values (");
            strSql.Append(":C_STD_CODE,:C_STL_GRD,:C_SPEC_MIN,:C_SPEC_MAX,:N_SAM_NUM,:N_STATUS,:C_REMARK,:C_EMP_ID,:D_MOD_DT)");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_STD_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STL_GRD", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SPEC_MIN", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SPEC_MAX", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_SAM_NUM", OracleDbType.Decimal,5),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date)};
            parameters[0].Value = model.C_STD_CODE;
            parameters[1].Value = model.C_STL_GRD;
            parameters[2].Value = model.C_SPEC_MIN;
            parameters[3].Value = model.C_SPEC_MAX;
            parameters[4].Value = model.N_SAM_NUM;
            parameters[5].Value = model.N_STATUS;
            parameters[6].Value = model.C_REMARK;
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
        /// 增加一条数据
        /// </summary>
        public bool Add_Trans(Mod_TQB_SAMP_MODLE model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TQB_SAMP_MODLE(");
            strSql.Append("C_ID,C_STD_CODE,C_STL_GRD,C_SPEC_MIN,C_SPEC_MAX,N_SAM_NUM,N_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT)");
            strSql.Append(" values (");
            strSql.Append(":C_ID,:C_STD_CODE,:C_STL_GRD,:C_SPEC_MIN,:C_SPEC_MAX,:N_SAM_NUM,:N_STATUS,:C_REMARK,:C_EMP_ID,:D_MOD_DT)");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STD_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STL_GRD", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SPEC_MIN", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SPEC_MAX", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_SAM_NUM", OracleDbType.Decimal,5),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date)};
            parameters[0].Value = model.C_ID;
            parameters[1].Value = model.C_STD_CODE;
            parameters[2].Value = model.C_STL_GRD;
            parameters[3].Value = model.C_SPEC_MIN;
            parameters[4].Value = model.C_SPEC_MAX;
            parameters[5].Value = model.N_SAM_NUM;
            parameters[6].Value = model.N_STATUS;
            parameters[7].Value = model.C_REMARK;
            parameters[8].Value = model.C_EMP_ID;
            parameters[9].Value = model.D_MOD_DT;

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
        public bool Update(Mod_TQB_SAMP_MODLE model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TQB_SAMP_MODLE set ");
            strSql.Append("C_STD_CODE=:C_STD_CODE,");
            strSql.Append("C_STL_GRD=:C_STL_GRD,");
            strSql.Append("C_SPEC_MIN=:C_SPEC_MIN,");
            strSql.Append("C_SPEC_MAX=:C_SPEC_MAX,");
            strSql.Append("N_SAM_NUM=:N_SAM_NUM,");
            strSql.Append("N_STATUS=:N_STATUS,");
            strSql.Append("C_REMARK=:C_REMARK,");
            strSql.Append("C_EMP_ID=:C_EMP_ID,");
            strSql.Append("D_MOD_DT=:D_MOD_DT");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_STD_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STL_GRD", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SPEC_MIN", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SPEC_MAX", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_SAM_NUM", OracleDbType.Decimal,5),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.C_STD_CODE;
            parameters[1].Value = model.C_STL_GRD;
            parameters[2].Value = model.C_SPEC_MIN;
            parameters[3].Value = model.C_SPEC_MAX;
            parameters[4].Value = model.N_SAM_NUM;
            parameters[5].Value = model.N_STATUS;
            parameters[6].Value = model.C_REMARK;
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
            strSql.Append("delete from TQB_SAMP_MODLE ");
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
            strSql.Append("delete from TQB_SAMP_MODLE ");
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
        public Mod_TQB_SAMP_MODLE GetModel(string C_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_STD_CODE,C_STL_GRD,C_SPEC_MIN,C_SPEC_MAX,N_SAM_NUM,N_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT from TQB_SAMP_MODLE ");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)         };
            parameters[0].Value = C_ID;

            Mod_TQB_SAMP_MODLE model = new Mod_TQB_SAMP_MODLE();
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
        public Mod_TQB_SAMP_MODLE DataRowToModel(DataRow row)
        {
            Mod_TQB_SAMP_MODLE model = new Mod_TQB_SAMP_MODLE();
            if (row != null)
            {
                if (row["C_ID"] != null)
                {
                    model.C_ID = row["C_ID"].ToString();
                }
                if (row["C_STD_CODE"] != null)
                {
                    model.C_STD_CODE = row["C_STD_CODE"].ToString();
                }
                if (row["C_STL_GRD"] != null)
                {
                    model.C_STL_GRD = row["C_STL_GRD"].ToString();
                }
                if (row["C_SPEC_MIN"] != null)
                {
                    model.C_SPEC_MIN = row["C_SPEC_MIN"].ToString();
                }
                if (row["C_SPEC_MAX"] != null)
                {
                    model.C_SPEC_MAX = row["C_SPEC_MAX"].ToString();
                }
                if (row["N_SAM_NUM"] != null && row["N_SAM_NUM"].ToString() != "")
                {
                    model.N_SAM_NUM = decimal.Parse(row["N_SAM_NUM"].ToString());
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
            strSql.Append("select C_ID,C_STD_CODE,C_STL_GRD,C_SPEC_MIN,C_SPEC_MAX,N_SAM_NUM,N_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT ");
            strSql.Append(" FROM TQB_SAMP_MODLE ");
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
            strSql.Append("select count(1) FROM TQB_SAMP_MODLE ");
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
            strSql.Append(")AS Row, T.*  from TQB_SAMP_MODLE T ");
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
        public DataSet GetList(string C_STD_CODE, string C_STL_GRD)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT T.C_STD_CODE AS 执行标准, T.C_STL_GRD  AS 钢种, T.C_SPEC_MIN AS 规格最小值, T.C_SPEC_MAX AS 规格最大值  FROM TQB_SAMP_MODLE T WHERE T.N_STATUS = 1   ");

            if (!string.IsNullOrEmpty(C_STD_CODE))
            {
                strSql.Append(" AND T.C_STD_CODE LIKE '%" + C_STD_CODE + "%' ");
            }

            if (!string.IsNullOrEmpty(C_STL_GRD))
            {
                strSql.Append(" AND T.C_STL_GRD LIKE '%" + C_STL_GRD + "%'  ");
            }

            strSql.Append(" GROUP BY T.C_STD_CODE, T.C_STL_GRD, T.C_SPEC_MIN, T.C_SPEC_MAX  ");

            strSql.Append(" ORDER BY T.C_STD_CODE,T.C_STL_GRD ");

            return DbHelperOra.Query(strSql.ToString());
        }


        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool update_status(string c_std_code, string c_stl_grd, string c_spec_min, string c_spec_max)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update tqb_samp_modle t set t.n_status=0 where t.c_std_code='" + c_std_code + "' and t.c_stl_grd='" + c_stl_grd + "' and nvl(t.c_spec_min,' ')=nvl('" + c_spec_min + "',' ') and nvl(t.c_spec_max,' ')=nvl('" + c_spec_max + "',' ') ");

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
        /// 更新一条数据
        /// </summary>
        public bool update_Trans(string c_std_code, string c_stl_grd, string c_spec_min, string c_spec_max)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update tqb_samp_modle t set t.n_status=0 where t.c_std_code='" + c_std_code + "' and t.c_stl_grd='" + c_stl_grd + "' and nvl(t.c_spec_min,' ')=nvl('" + c_spec_min + "',' ') and nvl(t.c_spec_max,' ')=nvl('" + c_spec_max + "',' ') ");

            int rows = TransactionHelper.ExecuteSql(strSql.ToString());
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
        /// 获取最大主键
        /// </summary>
        public Int64 Get_Max_ID_Trans()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select max(C_ID) FROM TQB_SAMP_MODLE ");

            object obj = TransactionHelper.GetSingle(strSql.ToString());
            if (obj == null)
            {
                return 0;
            }
            else
            {
                return Convert.ToInt64(obj);
            }
        }

        #endregion  BasicMethod
        #region  ExtensionMethod

        #endregion  ExtensionMethod
    }
}

