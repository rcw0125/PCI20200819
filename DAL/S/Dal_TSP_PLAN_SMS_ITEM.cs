using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;
namespace DAL
{
    /// <summary>
    /// 数据访问类:TSP_PLAN_SMS_MAIN
    /// </summary>
    public partial class Dal_TSP_PLAN_SMS_ITEM
    {
        public Dal_TSP_PLAN_SMS_ITEM()
        { }
        #region  BasicMethod



        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Mod_TSP_PLAN_SMS_ITEM model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TSP_PLAN_SMS_ITEM(");
            strSql.Append("C_PRODUCTION_PLAN_ID,C_PLAN_SMS_ID,N_WGT,N_STATUS,C_REMARK,C_EMP_ID)");
            strSql.Append(" values (");
            strSql.Append(":C_PRODUCTION_PLAN_ID,:C_PLAN_SMS_ID,:N_WGT,:N_STATUS,:C_REMARK,:C_EMP_ID)");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_PRODUCTION_PLAN_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PLAN_SMS_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_WGT", OracleDbType.Double,15),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.C_PRODUCTION_PLAN_ID;
            parameters[1].Value = model.C_PLAN_SMS_ID;
            parameters[2].Value = model.N_WGT;
            parameters[3].Value = model.N_STATUS;
            parameters[4].Value = model.C_REMARK;
            parameters[5].Value = model.C_EMP_ID;

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
        public bool Update(Mod_TSP_PLAN_SMS_ITEM model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TSP_PLAN_SMS_ITEM set ");
            strSql.Append("C_ID=:C_ID,");
            strSql.Append("C_PRODUCTION_PLAN_ID=:C_PRODUCTION_PLAN_ID,");
            strSql.Append("C_PLAN_SMS_ID=:C_PLAN_SMS_ID,");
            strSql.Append("N_WGT=:N_WGT,");
            strSql.Append("N_STATUS=:N_STATUS,");
            strSql.Append("C_REMARK=:C_REMARK,");
            strSql.Append("C_EMP_ID=:C_EMP_ID,");
            strSql.Append("D_MOD_DT=:D_MOD_DT");
            strSql.Append(" where ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PRODUCTION_PLAN_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PLAN_SMS_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_WGT", OracleDbType.Double,15),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date)};
            parameters[0].Value = model.C_ID;
            parameters[1].Value = model.C_PRODUCTION_PLAN_ID;
            parameters[2].Value = model.C_PLAN_SMS_ID;
            parameters[3].Value = model.N_WGT;
            parameters[4].Value = model.N_STATUS;
            parameters[5].Value = model.C_REMARK;
            parameters[6].Value = model.C_EMP_ID;
            parameters[7].Value = model.D_MOD_DT;

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
        public bool Delete()
        {
            //该表无主键信息，请自定义主键/条件字段
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from TSP_PLAN_SMS_ITEM ");
            strSql.Append(" where ");
            OracleParameter[] parameters = {
            };

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
        /// 得到一个对象实体
        /// </summary>
        public Mod_TSP_PLAN_SMS_ITEM GetModel()
        {
            //该表无主键信息，请自定义主键/条件字段
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_PRODUCTION_PLAN_ID,C_PLAN_SMS_ID,N_WGT,N_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT from TSP_PLAN_SMS_ITEM ");
            strSql.Append(" where ");
            OracleParameter[] parameters = {
            };

            Mod_TSP_PLAN_SMS_ITEM model = new Mod_TSP_PLAN_SMS_ITEM();
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
        public Mod_TSP_PLAN_SMS_ITEM DataRowToModel(DataRow row)
        {
            Mod_TSP_PLAN_SMS_ITEM model = new Mod_TSP_PLAN_SMS_ITEM();
            if (row != null)
            {
                if (row["C_ID"] != null)
                {
                    model.C_ID = row["C_ID"].ToString();
                }
                if (row["C_PRODUCTION_PLAN_ID"] != null)
                {
                    model.C_PRODUCTION_PLAN_ID = row["C_PRODUCTION_PLAN_ID"].ToString();
                }
                if (row["C_PLAN_SMS_ID"] != null)
                {
                    model.C_PLAN_SMS_ID = row["C_PLAN_SMS_ID"].ToString();
                }
                if (row["N_WGT"] != null && row["N_WGT"].ToString() != "")
                {
                    model.N_WGT = decimal.Parse(row["N_WGT"].ToString());
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
            strSql.Append("select C_ID,C_PRODUCTION_PLAN_ID,C_PLAN_SMS_ID,N_WGT,N_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT ");
            strSql.Append(" FROM TSP_PLAN_SMS_ITEM ");
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
            strSql.Append("select count(1) FROM TSP_PLAN_SMS_ITEM ");
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
                strSql.Append("order by T. desc");
            }
            strSql.Append(")AS Row, T.*  from TSP_PLAN_SMS_ITEM T ");
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
        /// 差询炉次计划和订单中间表
        /// </summary>
        /// <param name="C_PLAN_SMS_ID">炉次计划主键</param>
        /// <returns></returns>
        public DataTable GetLc(string C_PLAN_SMS_ID)
        {
            string sql = @"SELECT T.C_ID,
       T.C_PRODUCTION_PLAN_ID,
       T.C_PLAN_SMS_ID,
       T.N_WGT,
       T.N_STATUS,
       T.C_EMP_ID,
       T.D_MOD_DT,
       T.C_REMARK
  FROM TSP_PLAN_SMS_ITEM T
 WHERE T.C_PLAN_SMS_ID = '"+ C_PLAN_SMS_ID + "'";

         return   DbHelperOra.Query(sql.ToString()).Tables[0];

        }

        /// <summary>
        ///工根据 C_PLAN_SMS_ID 删除中间表
        /// </summary>
        /// <param name="C_PLAN_SMS_ID"></param>
        /// <returns></returns>
        public bool Delete(string C_PLAN_SMS_ID)
        {
            //该表无主键信息，请自定义主键/条件字段
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from TSP_PLAN_SMS_ITEM ");
            strSql.Append(" where C_PLAN_SMS_ID='"+ C_PLAN_SMS_ID + "' ");
          
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

        #endregion  ExtensionMethod
    }
}

