using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;
namespace DAL
{
    /// <summary>
    /// 数据访问类:TRC_PRODUCTION_IMPACT
    /// </summary>
    public partial class Dal_TRC_PRODUCTION_IMPACT
    {
        public Dal_TRC_PRODUCTION_IMPACT()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string C_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TRC_PRODUCTION_IMPACT");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)            };
            parameters[0].Value = C_ID;

            return DbHelperOra.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Mod_TRC_PRODUCTION_IMPACT model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TRC_PRODUCTION_IMPACT(");
            strSql.Append("N_IMPACT,C_SHIFT,C_GROUP,C_IMPACT_KIND,D_IMPACT_DT,C_STA_CODE,N_STATUS,C_SH_EMP_ID,D_SH_MOD_DT,C_UNIT,C_TYPE,C_REMARK,C_EMP_ID,C_PRO_CODE,C_IMPACT_DESC,D_IMPACT_END_DT)");
            strSql.Append(" values (");
            strSql.Append(":N_IMPACT,:C_SHIFT,:C_GROUP,:C_IMPACT_KIND,:D_IMPACT_DT,:C_STA_CODE,:N_STATUS,:C_SH_EMP_ID,:D_SH_MOD_DT,:C_UNIT,:C_TYPE,:C_REMARK,:C_EMP_ID,:C_PRO_CODE,:C_IMPACT_DESC,:D_IMPACT_END_DT)");
            OracleParameter[] parameters = {
                    new OracleParameter(":N_IMPACT", OracleDbType.Int16,15),
                    new OracleParameter(":C_SHIFT", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_GROUP", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_IMPACT_KIND", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_IMPACT_DT", OracleDbType.Date),
                    new OracleParameter(":C_STA_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_STATUS", OracleDbType.Int16,4),
                    new OracleParameter(":C_SH_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_SH_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":C_UNIT", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_TYPE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PRO_CODE", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_IMPACT_DESC", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_IMPACT_END_DT", OracleDbType.Date)};
            parameters[0].Value = model.N_IMPACT;
            parameters[1].Value = model.C_SHIFT;
            parameters[2].Value = model.C_GROUP;
            parameters[3].Value = model.C_IMPACT_KIND;
            parameters[4].Value = model.D_IMPACT_DT;
            parameters[5].Value = model.C_STA_CODE;
            parameters[6].Value = model.N_STATUS;
            parameters[7].Value = model.C_SH_EMP_ID;
            parameters[8].Value = model.D_SH_MOD_DT;
            parameters[9].Value = model.C_UNIT;
            parameters[10].Value = model.C_TYPE;
            parameters[11].Value = model.C_REMARK;
            parameters[12].Value = model.C_EMP_ID;
            parameters[13].Value = model.C_PRO_CODE;
            parameters[14].Value = model.C_IMPACT_DESC;
            parameters[15].Value = model.D_IMPACT_END_DT;
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
        public bool Update(Mod_TRC_PRODUCTION_IMPACT model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TRC_PRODUCTION_IMPACT set ");
            strSql.Append("N_IMPACT=:N_IMPACT,");
            strSql.Append("C_SHIFT=:C_SHIFT,");
            strSql.Append("C_GROUP=:C_GROUP,");
            strSql.Append("C_IMPACT_KIND=:C_IMPACT_KIND,");
            strSql.Append("D_IMPACT_DT=:D_IMPACT_DT,");
            strSql.Append("C_STA_CODE=:C_STA_CODE,");
            strSql.Append("N_STATUS=:N_STATUS,");
            strSql.Append("C_SH_EMP_ID=:C_SH_EMP_ID,");
            strSql.Append("D_SH_MOD_DT=:D_SH_MOD_DT,");
            strSql.Append("C_UNIT=:C_UNIT,");
            strSql.Append("C_TYPE=:C_TYPE,");
            strSql.Append("C_REMARK=:C_REMARK,");
            strSql.Append("C_EMP_ID=:C_EMP_ID,");
            strSql.Append("D_MOD_DT=:D_MOD_DT,");
            strSql.Append("C_PRO_CODE=:C_PRO_CODE,");
            strSql.Append("C_IMPACT_DESC=:C_IMPACT_DESC,");
            strSql.Append("D_IMPACT_END_DT=:D_IMPACT_END_DT ");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":N_IMPACT", OracleDbType.Int16,15),
                    new OracleParameter(":C_SHIFT", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_GROUP", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_IMPACT_KIND", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_IMPACT_DT", OracleDbType.Date),
                    new OracleParameter(":C_STA_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_STATUS", OracleDbType.Int16,4),
                    new OracleParameter(":C_SH_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_SH_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":C_UNIT", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_TYPE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":C_PRO_CODE", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_IMPACT_DESC", OracleDbType.Varchar2,100),
             new OracleParameter(":D_IMPACT_END_DT", OracleDbType.Date),
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)}; 
             parameters[0].Value = model.N_IMPACT;
            parameters[1].Value = model.C_SHIFT;
            parameters[2].Value = model.C_GROUP;
            parameters[3].Value = model.C_IMPACT_KIND;
            parameters[4].Value = model.D_IMPACT_DT;
            parameters[5].Value = model.C_STA_CODE;
            parameters[6].Value = model.N_STATUS;
            parameters[7].Value = model.C_SH_EMP_ID;
            parameters[8].Value = model.D_SH_MOD_DT;
            parameters[9].Value = model.C_UNIT;
            parameters[10].Value = model.C_TYPE;
            parameters[11].Value = model.C_REMARK;
            parameters[12].Value = model.C_EMP_ID;
            parameters[13].Value = model.D_MOD_DT;
            parameters[14].Value = model.C_PRO_CODE;
            parameters[15].Value = model.C_IMPACT_DESC;
            parameters[16].Value = model.D_IMPACT_END_DT;
            parameters[17].Value = model.C_ID;

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
            strSql.Append("delete from TRC_PRODUCTION_IMPACT ");
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
            strSql.Append("delete from TRC_PRODUCTION_IMPACT ");
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
        public Mod_TRC_PRODUCTION_IMPACT GetModel(string C_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,N_IMPACT,C_SHIFT,C_GROUP,C_IMPACT_KIND,D_IMPACT_DT,C_STA_CODE,N_STATUS,C_SH_EMP_ID,D_SH_MOD_DT,C_UNIT,C_TYPE,C_REMARK,C_EMP_ID,D_MOD_DT,C_PRO_CODE,C_IMPACT_DESC,D_IMPACT_END_DT from TRC_PRODUCTION_IMPACT ");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)            };
            parameters[0].Value = C_ID;

            Mod_TRC_PRODUCTION_IMPACT model = new Mod_TRC_PRODUCTION_IMPACT();
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
        public Mod_TRC_PRODUCTION_IMPACT DataRowToModel(DataRow row)
        {
            Mod_TRC_PRODUCTION_IMPACT model = new Mod_TRC_PRODUCTION_IMPACT();
            if (row != null)
            {
                if (row["C_ID"] != null)
                {
                    model.C_ID = row["C_ID"].ToString();
                }
                if (row["N_IMPACT"] != null && row["N_IMPACT"].ToString() != "")
                {
                    model.N_IMPACT = decimal.Parse(row["N_IMPACT"].ToString());
                }
                if (row["C_SHIFT"] != null)
                {
                    model.C_SHIFT = row["C_SHIFT"].ToString();
                }
                if (row["C_GROUP"] != null)
                {
                    model.C_GROUP = row["C_GROUP"].ToString();
                }
                if (row["C_IMPACT_KIND"] != null)
                {
                    model.C_IMPACT_KIND = row["C_IMPACT_KIND"].ToString();
                }
                if (row["D_IMPACT_DT"] != null && row["D_IMPACT_DT"].ToString() != "")
                {
                    model.D_IMPACT_DT = DateTime.Parse(row["D_IMPACT_DT"].ToString());
                }
                if (row["C_STA_CODE"] != null)
                {
                    model.C_STA_CODE = row["C_STA_CODE"].ToString();
                }
                if (row["N_STATUS"] != null && row["N_STATUS"].ToString() != "")
                {
                    model.N_STATUS = decimal.Parse(row["N_STATUS"].ToString());
                }
                if (row["C_SH_EMP_ID"] != null)
                {
                    model.C_SH_EMP_ID = row["C_SH_EMP_ID"].ToString();
                }
                if (row["D_SH_MOD_DT"] != null && row["D_SH_MOD_DT"].ToString() != "")
                {
                    model.D_SH_MOD_DT = DateTime.Parse(row["D_SH_MOD_DT"].ToString());
                }
                if (row["C_UNIT"] != null)
                {
                    model.C_UNIT = row["C_UNIT"].ToString();
                }
                if (row["C_TYPE"] != null)
                {
                    model.C_TYPE = row["C_TYPE"].ToString();
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
                if (row["C_PRO_CODE"] != null)
                {
                    model.C_PRO_CODE = row["C_PRO_CODE"].ToString();
                }
                if (row["C_IMPACT_DESC"] != null)
                {
                    model.C_IMPACT_DESC = row["C_IMPACT_DESC"].ToString();
                }
                if (row["D_IMPACT_END_DT"] != null && row["D_IMPACT_END_DT"].ToString() != "")
                {
                    model.D_IMPACT_END_DT = DateTime.Parse(row["D_IMPACT_END_DT"].ToString());
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
            strSql.Append("select C_ID,N_IMPACT,C_SHIFT,C_GROUP,C_IMPACT_KIND,D_IMPACT_DT,C_STA_CODE,N_STATUS,C_SH_EMP_ID,D_SH_MOD_DT,C_UNIT,C_TYPE,C_REMARK,C_EMP_ID,D_MOD_DT,C_PRO_CODE,C_IMPACT_DESC ");
            strSql.Append(" FROM TRC_PRODUCTION_IMPACT ");
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
            strSql.Append("select count(1) FROM TRC_PRODUCTION_IMPACT ");
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
            strSql.Append(")AS Row, T.*  from TRC_PRODUCTION_IMPACT T ");
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
        /// 查询生产影响记录
        /// </summary>
        /// <param name="dtFrom">开始时间</param>
        /// <param name="dtTo">结束时间</param>
        /// <param name="strSta">工位</param>
        /// <param name="strType">类别</param>
        /// <param name="strpro">工序</param>
        public DataSet BindInfo(DateTime? dtFrom, DateTime? dtTo, string strSta, string strType, string strpro)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(@"SELECT T.C_ID,
       T.N_IMPACT,
       T.C_SHIFT,
       T.C_GROUP,
       T.C_IMPACT_KIND,
       T.D_IMPACT_DT,
       TB.C_STA_DESC C_STA_CODE,
       T.N_STATUS,
       T.C_SH_EMP_ID,
       T.D_SH_MOD_DT,
       T.C_UNIT,
       T.C_REMARK,
       T.C_EMP_ID,
       T.D_MOD_DT,
       T.C_PRO_CODE,
       T.C_IMPACT_DESC,
       T.D_IMPACT_END_DT
  FROM TRC_PRODUCTION_IMPACT T
  LEFT JOIN TB_STA TB
    ON T.C_STA_CODE = TB.C_STA_CODE
 WHERE T.N_STATUS = 1 ");
           // strSql.Append(" FROM TRC_PRODUCTION_IMPACT  where N_STATUS=1 ");
            if (dtFrom != null)
            {
                strSql.Append(" and T.D_IMPACT_DT>=TO_DATE('" + dtFrom.ToString() + "','YYYY-MM-DD HH24:MI:SS') ");
            }
            if (dtTo != null)
            {
                strSql.Append(" and T.D_IMPACT_DT<=TO_DATE('" + dtTo.ToString() + "','YYYY-MM-DD HH24:MI:SS')  ");
            }
            if (strpro.Trim() != "")
            {
                strSql.Append(" and T.C_PRO_CODE='" + strpro + "' ");
            }
            if (strSta.Trim() != "")
            {
                strSql.Append(" and T.C_STA_CODE='" + strSta + "' ");
            }
            if (strType.Trim() != "")
            {
                strSql.Append(" and T.C_IMPACT_KIND='" + strType + "' ");
            }
            strSql.Append(" ORDER BY T.C_IMPACT_KIND, T.D_IMPACT_DT ");
            return DbHelperOra.Query(strSql.ToString());
        }
        #endregion  ExtensionMethod
    }
}

