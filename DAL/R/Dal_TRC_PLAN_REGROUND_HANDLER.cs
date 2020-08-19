using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;
namespace DAL
{
    /// <summary>
	/// 数据访问类:TRC_PLAN_REGROUND_HANDLER
	/// </summary>
    public partial class Dal_TRC_PLAN_REGROUND_HANDLER
    {
        public Dal_TRC_PLAN_REGROUND_HANDLER()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string C_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TRC_PLAN_REGROUND_HANDLER");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)            };
            parameters[0].Value = C_ID;

            return DbHelperOra.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Mod_TRC_PLAN_REGROUND_HANDLER model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TRC_PLAN_REGROUND_HANDLER(");
            strSql.Append("C_REGROUND_ID,C_REGROUND_ITEM_ID,C_EMP_NAME,D_DT,C_STA_ID,C_XMBZ,N_TOTAL_QUA,N_QUA,C_BATCH_NO,C_REMARK,C_QUALITY,C_HW,C_HG,C_CAUSE,N_NOT_QUA,C_SHIFT,C_GROUP,N_STATUS,N_STEP,C_STEPNAME,C_GRINDING_WHEEL)");
            strSql.Append(" values (");
            strSql.Append(":C_REGROUND_ID,:C_REGROUND_ITEM_ID,:C_EMP_NAME,:D_DT,:C_STA_ID,:C_XMBZ,:N_TOTAL_QUA,:N_QUA,:C_BATCH_NO,:C_REMARK,:C_QUALITY,:C_HW,:C_HG,:C_CAUSE,:N_NOT_QUA,:C_SHIFT,:C_GROUP,:N_STATUS,:N_STEP,:C_STEPNAME,:C_GRINDING_WHEEL)");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_REGROUND_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_REGROUND_ITEM_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_EMP_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_DT",OracleDbType.Date),
                    new OracleParameter(":C_STA_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_XMBZ", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_TOTAL_QUA", OracleDbType.Decimal,5),
                    new OracleParameter(":N_QUA", OracleDbType.Decimal,5),
                    new OracleParameter(":C_BATCH_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_QUALITY", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_HW", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_HG", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CAUSE", OracleDbType.Varchar2,500),
                    new OracleParameter(":N_NOT_QUA", OracleDbType.Decimal,5),
                    new OracleParameter(":C_SHIFT", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_GROUP", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,2),
                    new OracleParameter(":N_STEP", OracleDbType.Decimal,2),
                    new OracleParameter(":C_STEPNAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_GRINDING_WHEEL", OracleDbType.Varchar2,100)

            };
            parameters[0].Value = model.C_REGROUND_ID;
            parameters[1].Value = model.C_REGROUND_ITEM_ID;
            parameters[2].Value = model.C_EMP_NAME;
            parameters[3].Value = model.D_DT;
            parameters[4].Value = model.C_STA_ID;
            parameters[5].Value = model.C_XMBZ;
            parameters[6].Value = model.N_TOTAL_QUA;
            parameters[7].Value = model.N_QUA;
            parameters[8].Value = model.C_BATCH_NO;
            parameters[9].Value = model.C_REMARK;
            parameters[10].Value = model.C_QUALITY;
            parameters[11].Value = model.C_HW;
            parameters[12].Value = model.C_HG;
            parameters[13].Value = model.C_CAUSE;
            parameters[14].Value = model.N_NOT_QUA;
            parameters[15].Value = model.C_SHIFT;
            parameters[16].Value = model.C_GROUP;
            parameters[17].Value = model.N_STATUS;
            parameters[18].Value = model.N_STEP;
            parameters[19].Value = model.C_STEPNAME;
            parameters[20].Value = model.C_GRINDING_WHEEL;

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
        public bool Update(Mod_TRC_PLAN_REGROUND_HANDLER model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TRC_PLAN_REGROUND_HANDLER set ");
            strSql.Append("C_REGROUND_ID=:C_REGROUND_ID,");
            strSql.Append("C_REGROUND_ITEM_ID=:C_REGROUND_ITEM_ID,");
            strSql.Append("C_EMP_NAME=:C_EMP_NAME,");
            strSql.Append("D_DT=:D_DT,");
            strSql.Append("C_STA_ID=:C_STA_ID,");
            strSql.Append("C_XMBZ=:C_XMBZ,");
            strSql.Append("N_TOTAL_QUA=:N_TOTAL_QUA,");
            strSql.Append("N_QUA=:N_QUA,");
            strSql.Append("C_BATCH_NO=:C_BATCH_NO,");
            strSql.Append("C_REMARK=:C_REMARK,");
            strSql.Append("C_QUALITY=:C_QUALITY,");
            strSql.Append("C_HW=:C_HW,");
            strSql.Append("C_HG=:C_HG,");
            strSql.Append("C_CAUSE=:C_CAUSE,");
            strSql.Append("N_NOT_QUA=:N_NOT_QUA,");
            strSql.Append("C_SHIFT=:C_SHIFT,");
            strSql.Append("C_GROUP=:C_GROUP");
            strSql.Append("N_STATUS=:N_STATUS");
            strSql.Append("N_STEP=:N_STEP");
            strSql.Append("C_STEPNAME=:C_STEPNAME");
            strSql.Append("C_GRINDING_WHEEL=:C_GRINDING_WHEEL");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_REGROUND_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_REGROUND_ITEM_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_EMP_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_DT",OracleDbType.Date),
                    new OracleParameter(":C_STA_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_XMBZ", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_TOTAL_QUA", OracleDbType.Decimal,5),
                    new OracleParameter(":N_QUA", OracleDbType.Decimal,5),
                    new OracleParameter(":C_BATCH_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_QUALITY", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_HW", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_HG", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CAUSE", OracleDbType.Varchar2,500),
                    new OracleParameter(":N_NOT_QUA", OracleDbType.Decimal,5),
                    new OracleParameter(":C_SHIFT", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_GROUP", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,2),
                    new OracleParameter(":N_STEP", OracleDbType.Decimal,2),
                    new OracleParameter(":C_STEPNAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_GRINDING_WHEEL", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.C_REGROUND_ID;
            parameters[1].Value = model.C_REGROUND_ITEM_ID;
            parameters[2].Value = model.C_EMP_NAME;
            parameters[3].Value = model.D_DT;
            parameters[4].Value = model.C_STA_ID;
            parameters[5].Value = model.C_XMBZ;
            parameters[6].Value = model.N_TOTAL_QUA;
            parameters[7].Value = model.N_QUA;
            parameters[8].Value = model.C_BATCH_NO;
            parameters[9].Value = model.C_REMARK;
            parameters[10].Value = model.C_QUALITY;
            parameters[11].Value = model.C_HW;
            parameters[12].Value = model.C_HG;
            parameters[13].Value = model.C_CAUSE;
            parameters[14].Value = model.N_NOT_QUA;
            parameters[15].Value = model.C_SHIFT;
            parameters[16].Value = model.C_GROUP;
            parameters[17].Value = model.N_STATUS;
            parameters[18].Value = model.N_STEP;
            parameters[19].Value = model.C_STEPNAME;
            parameters[20].Value = model.C_GRINDING_WHEEL;
            parameters[21].Value = model.C_ID;

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
            strSql.Append("delete from TRC_PLAN_REGROUND_HANDLER ");
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
        /// 删除一条数据
        /// </summary>
        public bool Del(string C_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from TRC_PLAN_REGROUND_HANDLER ");
            strSql.Append(" where C_REGROUND_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)            };
            parameters[0].Value = C_ID;

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
        /// 批量删除数据
        /// </summary>
        public bool DeleteList(string C_IDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from TRC_PLAN_REGROUND_HANDLER ");
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
        public Mod_TRC_PLAN_REGROUND_HANDLER GetModel(string C_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_REGROUND_ID,C_REGROUND_ITEM_ID,C_EMP_NAME,D_DT,C_STA_ID,C_XMBZ,N_TOTAL_QUA,N_QUA,C_BATCH_NO,C_REMARK,C_QUALITY,C_HW,C_HG,C_CAUSE,N_NOT_QUA,C_SHIFT,C_GROUP,N_STATUS,N_STEP,C_STEPNAME,C_GRINDING_WHEEL  from TRC_PLAN_REGROUND_HANDLER ");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)            };
            parameters[0].Value = C_ID;

            Mod_TRC_PLAN_REGROUND_HANDLER model = new Mod_TRC_PLAN_REGROUND_HANDLER();
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
        public Mod_TRC_PLAN_REGROUND_HANDLER DataRowToModel(DataRow row)
        {
            Mod_TRC_PLAN_REGROUND_HANDLER model = new Mod_TRC_PLAN_REGROUND_HANDLER();
            if (row != null)
            {
                if (row["C_ID"] != null)
                {
                    model.C_ID = row["C_ID"].ToString();
                }
                if (row["C_REGROUND_ID"] != null)
                {
                    model.C_REGROUND_ID = row["C_REGROUND_ID"].ToString();
                }
                if (row["C_REGROUND_ITEM_ID"] != null)
                {
                    model.C_REGROUND_ITEM_ID = row["C_REGROUND_ITEM_ID"].ToString();
                }
                if (row["C_EMP_NAME"] != null)
                {
                    model.C_EMP_NAME = row["C_EMP_NAME"].ToString();
                }
                if (row["D_DT"] != null && row["D_DT"].ToString() != "")
                {
                    model.D_DT = DateTime.Parse(row["D_DT"].ToString());
                }
                if (row["C_STA_ID"] != null)
                {
                    model.C_STA_ID = row["C_STA_ID"].ToString();
                }
                if (row["C_XMBZ"] != null)
                {
                    model.C_XMBZ = row["C_XMBZ"].ToString();
                }
                if (row["N_TOTAL_QUA"] != null && row["N_TOTAL_QUA"].ToString() != "")
                {
                    model.N_TOTAL_QUA = decimal.Parse(row["N_TOTAL_QUA"].ToString());
                }
                if (row["N_QUA"] != null && row["N_QUA"].ToString() != "")
                {
                    model.N_QUA = decimal.Parse(row["N_QUA"].ToString());
                }
                if (row["C_BATCH_NO"] != null)
                {
                    model.C_BATCH_NO = row["C_BATCH_NO"].ToString();
                }
                if (row["C_REMARK"] != null)
                {
                    model.C_REMARK = row["C_REMARK"].ToString();
                }
                if (row["C_QUALITY"] != null)
                {
                    model.C_QUALITY = row["C_QUALITY"].ToString();
                }
                if (row["C_HW"] != null)
                {
                    model.C_HW = row["C_HW"].ToString();
                }
                if (row["C_HG"] != null)
                {
                    model.C_HG = row["C_HG"].ToString();
                }
                if (row["C_CAUSE"] != null)
                {
                    model.C_CAUSE = row["C_CAUSE"].ToString();
                }
                if (row["N_NOT_QUA"] != null && row["N_NOT_QUA"].ToString() != "")
                {
                    model.N_NOT_QUA = decimal.Parse(row["N_NOT_QUA"].ToString());
                }
                if (row["C_SHIFT"] != null)
                {
                    model.C_SHIFT = row["C_SHIFT"].ToString();
                }
                if (row["C_GROUP"] != null)
                {
                    model.C_GROUP = row["C_GROUP"].ToString();
                }
                if (row["N_STATUS"] != null && row["N_STATUS"].ToString() != "")
                {
                    model.N_STATUS = decimal.Parse(row["N_STATUS"].ToString());
                }
                if (row["N_STEP"] != null && row["N_STEP"].ToString() != "")
                {
                    model.N_STEP = decimal.Parse(row["N_STEP"].ToString());
                }
                if (row["C_STEPNAME"] != null)
                {
                    model.C_STEPNAME = row["C_STEPNAME"].ToString();
                }
                if (row["C_GRINDING_WHEEL"] != null)
                {
                    model.C_GRINDING_WHEEL = row["C_GRINDING_WHEEL"].ToString();
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
            strSql.Append("select C_ID,C_REGROUND_ID,C_REGROUND_ITEM_ID,C_EMP_NAME,D_DT,C_STA_ID,C_XMBZ,N_TOTAL_QUA,N_QUA,C_BATCH_NO,C_REMARK,C_QUALITY,C_HW,C_HG,C_CAUSE,N_NOT_QUA,C_SHIFT,C_GROUP,N_STATUS,N_STEP,C_STEPNAME,C_GRINDING_WHEEL ");
            strSql.Append(" FROM TRC_PLAN_REGROUND_HANDLER ");
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
            strSql.Append("select count(1) FROM TRC_PLAN_REGROUND_HANDLER ");
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
            strSql.Append(")AS Row, T.*  from TRC_PLAN_REGROUND_HANDLER T ");
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

        #endregion  ExtensionMethod
    }
}
