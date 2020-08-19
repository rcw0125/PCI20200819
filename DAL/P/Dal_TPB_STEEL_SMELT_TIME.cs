using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;
namespace DAL
{
    /// <summary>
	/// 数据访问类:TPB_STEEL_SMELT_TIME
	/// </summary>
	public partial class Dal_TPB_STEEL_SMELT_TIME
    {
        public Dal_TPB_STEEL_SMELT_TIME()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string C_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TPB_STEEL_SMELT_TIME");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)         };
            parameters[0].Value = C_ID;

            return DbHelperOra.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Mod_TPB_STEEL_SMELT_TIME model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TPB_STEEL_SMELT_TIME(");
            strSql.Append("C_STA_ID,C_STL_GRD,C_SPEC,N_SMELT_TIME,D_START_DATE,D_END_DATE,N_STATUS,C_EMP_ID,D_MOD_DT,C_STD_CODE,C_PRO_ID,C_STA_DESC,C_STA_CODE)");
            strSql.Append(" values (");
            strSql.Append(":C_STA_ID,:C_STL_GRD,:C_SPEC,:N_SMELT_TIME,:D_START_DATE,:D_END_DATE,:N_STATUS,:C_EMP_ID,:D_MOD_DT,:C_STD_CODE,:C_PRO_ID,:C_STA_DESC,:C_STA_CODE)");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_STA_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STL_GRD", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SPEC", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_SMELT_TIME", OracleDbType.Decimal,15),
                    new OracleParameter(":D_START_DATE", OracleDbType.Date),
                    new OracleParameter(":D_END_DATE", OracleDbType.Date),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":C_STD_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PRO_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STA_DESC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STA_CODE", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.C_STA_ID;
            parameters[1].Value = model.C_STL_GRD;
            parameters[2].Value = model.C_SPEC;
            parameters[3].Value = model.N_SMELT_TIME;
            parameters[4].Value = model.D_START_DATE;
            parameters[5].Value = model.D_END_DATE;
            parameters[6].Value = model.N_STATUS;
            parameters[7].Value = model.C_EMP_ID;
            parameters[8].Value = model.D_MOD_DT;
            parameters[9].Value = model.C_STD_CODE;
            parameters[10].Value = model.C_PRO_ID;
            parameters[11].Value = model.C_STA_DESC;
            parameters[12].Value = model.C_STA_CODE;

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
        public bool Update(Mod_TPB_STEEL_SMELT_TIME model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TPB_STEEL_SMELT_TIME set ");
            strSql.Append("C_STA_ID=:C_STA_ID,");
            strSql.Append("C_STL_GRD=:C_STL_GRD,");
            strSql.Append("C_SPEC=:C_SPEC,");
            strSql.Append("N_SMELT_TIME=:N_SMELT_TIME,");
            strSql.Append("D_START_DATE=:D_START_DATE,");
            strSql.Append("D_END_DATE=:D_END_DATE,");
            strSql.Append("N_STATUS=:N_STATUS,");
            strSql.Append("C_EMP_ID=:C_EMP_ID,");
            strSql.Append("D_MOD_DT=:D_MOD_DT,");
            strSql.Append("C_STD_CODE=:C_STD_CODE,");
            strSql.Append("C_PRO_ID=:C_PRO_ID,");
            strSql.Append("C_STA_DESC=:C_STA_DESC,");
            strSql.Append("C_STA_CODE=:C_STA_CODE");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_STA_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STL_GRD", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SPEC", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_SMELT_TIME", OracleDbType.Decimal,15),
                    new OracleParameter(":D_START_DATE", OracleDbType.Date),
                    new OracleParameter(":D_END_DATE", OracleDbType.Date),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":C_STD_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PRO_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STA_DESC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STA_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.C_STA_ID;
            parameters[1].Value = model.C_STL_GRD;
            parameters[2].Value = model.C_SPEC;
            parameters[3].Value = model.N_SMELT_TIME;
            parameters[4].Value = model.D_START_DATE;
            parameters[5].Value = model.D_END_DATE;
            parameters[6].Value = model.N_STATUS;
            parameters[7].Value = model.C_EMP_ID;
            parameters[8].Value = model.D_MOD_DT;
            parameters[9].Value = model.C_STD_CODE;
            parameters[10].Value = model.C_PRO_ID;
            parameters[11].Value = model.C_STA_DESC;
            parameters[12].Value = model.C_STA_CODE;
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
            strSql.Append("delete from TPB_STEEL_SMELT_TIME ");
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
            strSql.Append("delete from TPB_STEEL_SMELT_TIME ");
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
        public Mod_TPB_STEEL_SMELT_TIME GetModel(string C_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_STA_ID,C_STL_GRD,C_SPEC,N_SMELT_TIME,D_START_DATE,D_END_DATE,N_STATUS,C_EMP_ID,D_MOD_DT,C_STD_CODE,C_PRO_ID,C_STA_DESC,C_STA_CODE from TPB_STEEL_SMELT_TIME ");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)         };
            parameters[0].Value = C_ID;

            Mod_TPB_STEEL_SMELT_TIME model = new Mod_TPB_STEEL_SMELT_TIME();
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
        public Mod_TPB_STEEL_SMELT_TIME DataRowToModel(DataRow row)
        {
            Mod_TPB_STEEL_SMELT_TIME model = new Mod_TPB_STEEL_SMELT_TIME();
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
                if (row["C_STL_GRD"] != null)
                {
                    model.C_STL_GRD = row["C_STL_GRD"].ToString();
                }
                if (row["C_SPEC"] != null)
                {
                    model.C_SPEC = row["C_SPEC"].ToString();
                }
                if (row["N_SMELT_TIME"] != null && row["N_SMELT_TIME"].ToString() != "")
                {
                    model.N_SMELT_TIME = decimal.Parse(row["N_SMELT_TIME"].ToString());
                }
                if (row["D_START_DATE"] != null && row["D_START_DATE"].ToString() != "")
                {
                    model.D_START_DATE = DateTime.Parse(row["D_START_DATE"].ToString());
                }
                if (row["D_END_DATE"] != null && row["D_END_DATE"].ToString() != "")
                {
                    model.D_END_DATE = DateTime.Parse(row["D_END_DATE"].ToString());
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
                if (row["C_STD_CODE"] != null)
                {
                    model.C_STD_CODE = row["C_STD_CODE"].ToString();
                }
                if (row["C_PRO_ID"] != null)
                {
                    model.C_PRO_ID = row["C_PRO_ID"].ToString();
                }
                if (row["C_STA_DESC"] != null)
                {
                    model.C_STA_DESC = row["C_STA_DESC"].ToString();
                }
                if (row["C_STA_CODE"] != null)
                {
                    model.C_STA_CODE = row["C_STA_CODE"].ToString();
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
            strSql.Append("select C_ID,C_STA_ID,C_STL_GRD,C_SPEC,N_SMELT_TIME,D_START_DATE,D_END_DATE,DECODE(N_STATUS,1,'启用','停用') N_STATUS,C_EMP_ID,D_MOD_DT,C_STD_CODE,C_PRO_ID,C_STA_DESC,C_STA_CODE ");
            strSql.Append(" FROM TPB_STEEL_SMELT_TIME ");
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
            strSql.Append("select count(1) FROM TPB_STEEL_SMELT_TIME ");
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


        #endregion  BasicMethod
        #region  ExtensionMethod
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(int status, string pro, string sta, string grd, string std)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_STA_ID,C_STL_GRD,C_SPEC,N_SMELT_TIME,D_START_DATE,D_END_DATE,DECODE(N_STATUS,1,'启用','停用') N_STATUS,C_EMP_ID,D_MOD_DT,C_STD_CODE,C_PRO_ID,C_STA_DESC,C_STA_CODE ");
            strSql.Append(" FROM TPB_STEEL_SMELT_TIME WHERE N_STATUS='" + status + "' ");
            if (pro.Trim() != "")
            {
                strSql.Append(" and C_PRO_ID='" + pro + "'");
            }
            if (sta.Trim() != "")
            {
                strSql.Append(" and C_STA_ID='" + sta + "'");
            }
            if (grd.Trim() != "")
            {
                strSql.Append(" and C_STL_GRD LIKE '%" + grd + "%'");
            }
            if (std.Trim() != "")
            {
                strSql.Append(" and C_STD_CODE LIKE '%" + std + "%'");
            }
            strSql.Append(" ORDER BY C_STL_GRD");
            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 是否存在相同数据
        /// </summary>
        public bool ExistsDate(string C_PRO_ID, string C_STA_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TPB_STEEL_SMELT_TIME where N_STATUS=1 ");
            strSql.Append(" and C_PRO_ID=:C_PRO_ID  ");
            strSql.Append(" and C_STA_ID=:C_STA_ID  ");
            OracleParameter[] parameters = {
                new OracleParameter(":C_PRO_ID", OracleDbType.Varchar2,100),
                new OracleParameter(":C_STA_ID", OracleDbType.Varchar2,100)
            };
            parameters[0].Value = C_PRO_ID;
            parameters[1].Value = C_STA_ID;
            return DbHelperOra.Exists(strSql.ToString(), parameters);
        }
        #endregion  ExtensionMethod
    }
}