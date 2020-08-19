using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;
namespace DAL
{
	/// <summary>
	/// 数据访问类:TRC_ENERGY_RECORD
	/// </summary>
	public partial class Dal_TRC_ENERGY_RECORD
    {
		public Dal_TRC_ENERGY_RECORD()
		{}
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string C_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TRC_ENERGY_RECORD");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)            };
            parameters[0].Value = C_ID;

            return DbHelperOra.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Mod_TRC_ENERGY_RECORD model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TRC_ENERGY_RECORD(");
            strSql.Append("N_CONSUMPTION,C_SHIFT,C_GROUP,C_ENERGY_KIND,D_RECODE_DT,C_STA_CODE,N_STATUS,C_EMP_ID,C_SH_EMP_ID,D_SH_MOD_DT,C_UNIT,C_REMARK,C_PRO_CODE)");
            strSql.Append(" values (");
            strSql.Append(":N_CONSUMPTION,:C_SHIFT,:C_GROUP,:C_ENERGY_KIND,:D_RECODE_DT,:C_STA_CODE,:N_STATUS,:C_EMP_ID,:C_SH_EMP_ID,:D_SH_MOD_DT,:C_UNIT,:C_REMARK,:C_PRO_CODE)");
            OracleParameter[] parameters = {
                    new OracleParameter(":N_CONSUMPTION", OracleDbType.Int16,15),
                    new OracleParameter(":C_SHIFT", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_GROUP", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ENERGY_KIND", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_RECODE_DT", OracleDbType.Date),
                    new OracleParameter(":C_STA_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_STATUS", OracleDbType.Int16,4),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SH_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_SH_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":C_UNIT", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_PRO_CODE", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.N_CONSUMPTION;
            parameters[1].Value = model.C_SHIFT;
            parameters[2].Value = model.C_GROUP;
            parameters[3].Value = model.C_ENERGY_KIND;
            parameters[4].Value = model.D_RECODE_DT;
            parameters[5].Value = model.C_STA_CODE;
            parameters[6].Value = model.N_STATUS;
            parameters[7].Value = model.C_EMP_ID;
            parameters[8].Value = model.C_SH_EMP_ID;
            parameters[9].Value =  model.D_SH_MOD_DT;
            parameters[10].Value = model.C_UNIT;
            parameters[11].Value = model.C_REMARK;
            parameters[12].Value = model.C_PRO_CODE;

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
        public bool Update(Mod_TRC_ENERGY_RECORD model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TRC_ENERGY_RECORD set ");
            strSql.Append("N_CONSUMPTION=:N_CONSUMPTION,");
            strSql.Append("C_SHIFT=:C_SHIFT,");
            strSql.Append("C_GROUP=:C_GROUP,");
            strSql.Append("C_ENERGY_KIND=:C_ENERGY_KIND,");
            strSql.Append("D_RECODE_DT=:D_RECODE_DT,");
            strSql.Append("C_STA_CODE=:C_STA_CODE,");
            strSql.Append("N_STATUS=:N_STATUS,");
            strSql.Append("C_EMP_ID=:C_EMP_ID,");
            strSql.Append("D_MOD_DT=:D_MOD_DT,");
            strSql.Append("C_SH_EMP_ID=:C_SH_EMP_ID,");
            strSql.Append("D_SH_MOD_DT=:D_SH_MOD_DT,");
            strSql.Append("C_UNIT=:C_UNIT,");
            strSql.Append("C_REMARK=:C_REMARK,");
            strSql.Append("C_PRO_CODE=:C_PRO_CODE");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":N_CONSUMPTION", OracleDbType.Int16,15),
                    new OracleParameter(":C_SHIFT", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_GROUP", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ENERGY_KIND", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_RECODE_DT", OracleDbType.Date),
                    new OracleParameter(":C_STA_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_STATUS", OracleDbType.Int16,4),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":C_SH_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_SH_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":C_UNIT", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_PRO_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.N_CONSUMPTION;
            parameters[1].Value = model.C_SHIFT;
            parameters[2].Value = model.C_GROUP;
            parameters[3].Value = model.C_ENERGY_KIND;
            parameters[4].Value = model.D_RECODE_DT;
            parameters[5].Value = model.C_STA_CODE;
            parameters[6].Value = model.N_STATUS;
            parameters[7].Value = model.C_EMP_ID;
            parameters[8].Value = model.D_MOD_DT;
            parameters[9].Value = model.C_SH_EMP_ID;
            parameters[10].Value = model.D_SH_MOD_DT;
            parameters[11].Value = model.C_UNIT;
            parameters[12].Value = model.C_REMARK;
            parameters[13].Value = model.C_PRO_CODE;
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
            strSql.Append("delete from TRC_ENERGY_RECORD ");
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
            strSql.Append("delete from TRC_ENERGY_RECORD ");
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
        public Mod_TRC_ENERGY_RECORD GetModel(string C_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,N_CONSUMPTION,C_SHIFT,C_GROUP,C_ENERGY_KIND,D_RECODE_DT,C_STA_CODE,N_STATUS,C_EMP_ID,D_MOD_DT,C_SH_EMP_ID,D_SH_MOD_DT,C_UNIT,C_REMARK,C_PRO_CODE from TRC_ENERGY_RECORD ");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)            };
            parameters[0].Value = C_ID;

            Mod_TRC_ENERGY_RECORD model = new Mod_TRC_ENERGY_RECORD();
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
        public Mod_TRC_ENERGY_RECORD DataRowToModel(DataRow row)
        {
            Mod_TRC_ENERGY_RECORD model = new Mod_TRC_ENERGY_RECORD();
            if (row != null)
            {
                if (row["C_ID"] != null)
                {
                    model.C_ID = row["C_ID"].ToString();
                }
                if (row["N_CONSUMPTION"] != null && row["N_CONSUMPTION"].ToString() != "")
                {
                    model.N_CONSUMPTION = decimal.Parse(row["N_CONSUMPTION"].ToString());
                }
                if (row["C_SHIFT"] != null)
                {
                    model.C_SHIFT = row["C_SHIFT"].ToString();
                }
                if (row["C_GROUP"] != null)
                {
                    model.C_GROUP = row["C_GROUP"].ToString();
                }
                if (row["C_ENERGY_KIND"] != null)
                {
                    model.C_ENERGY_KIND = row["C_ENERGY_KIND"].ToString();
                }
                if (row["D_RECODE_DT"] != null && row["D_RECODE_DT"].ToString() != "")
                {
                    model.D_RECODE_DT = DateTime.Parse(row["D_RECODE_DT"].ToString());
                }
                if (row["C_STA_CODE"] != null)
                {
                    model.C_STA_CODE = row["C_STA_CODE"].ToString();
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
                if (row["C_UNIT"] != null)
                {
                    model.C_UNIT = row["C_UNIT"].ToString();
                }
                if (row["C_REMARK"] != null)
                {
                    model.C_REMARK = row["C_REMARK"].ToString();
                }
                if (row["C_PRO_CODE"] != null)
                {
                    model.C_PRO_CODE = row["C_PRO_CODE"].ToString();
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
            strSql.Append("select C_ID,N_CONSUMPTION,C_SHIFT,C_GROUP,C_ENERGY_KIND,D_RECODE_DT,C_STA_CODE,N_STATUS,C_EMP_ID,D_MOD_DT,C_SH_EMP_ID,D_SH_MOD_DT,C_UNIT,C_REMARK,C_PRO_CODE ");
            strSql.Append(" FROM TRC_ENERGY_RECORD ");
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
            strSql.Append("select count(1) FROM TRC_ENERGY_RECORD ");
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
            strSql.Append(")AS Row, T.*  from TRC_ENERGY_RECORD T ");
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
        /// 查询能源消耗实绩记录
        /// </summary>
        /// <param name="dtFrom">开始日期</param>
        /// <param name="dtTo">结束日期</param>
        /// <param name="strpro">工序</param>
        /// <param name="strsta">工位</param>
        /// <param name="strKind">能源种类</param>
        public DataSet BindRecode(DateTime? dtFrom, DateTime? dtTo, string strpro, string strsta, string strKind)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,N_CONSUMPTION,C_SHIFT,C_GROUP,C_ENERGY_KIND,D_RECODE_DT,C_STA_CODE,N_STATUS,C_EMP_ID,D_MOD_DT,C_SH_EMP_ID,D_SH_MOD_DT,C_UNIT,C_REMARK,C_PRO_CODE  ");
            strSql.Append(" FROM TRC_ENERGY_RECORD  where N_STATUS=1 ");
            if (dtFrom!= null)
            {
                strSql.Append(" and D_RECODE_DT>=TO_DATE('" + dtFrom.ToString() + "','YYYY-MM-DD HH24:MI:SS')  ");
            }
            if (dtTo != null)
            {
                strSql.Append(" and D_RECODE_DT<=TO_DATE('" + dtTo.ToString() + "','YYYY-MM-DD HH24:MI:SS') ");
            }
            if (strpro.Trim() != "")
            {
                strSql.Append(" and C_PRO_CODE='" + strpro + "' ");
            }
            if (strsta.Trim() != "")
            {
                strSql.Append(" and C_STA_CODE='" + strsta + "' ");
            }
            if (strKind.Trim() != "")
            {
                strSql.Append(" and C_ENERGY_KIND='" + strKind + "' ");
            }

            strSql.Append(" order by D_RECODE_DT ");
           
            return DbHelperOra.Query(strSql.ToString());
        }
        #endregion  ExtensionMethod
    }
}

