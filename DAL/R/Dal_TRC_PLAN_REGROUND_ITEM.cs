using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;
using System.Collections.Generic;

namespace DAL
{
    /// <summary>
    /// 数据访问类:TRC_PLAN_REGROUND_ITEM
    /// </summary>
    public partial class Dal_TRC_PLAN_REGROUND_ITEM
    {
        public Dal_TRC_PLAN_REGROUND_ITEM()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string C_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TRC_PLAN_REGROUND_ITEM");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)            };
            parameters[0].Value = C_ID;

            return DbHelperOra.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Mod_TRC_PLAN_REGROUND_ITEM model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TRC_PLAN_REGROUND_ITEM(");
            strSql.Append("C_PLAN_REGROUND_ID,C_SLAB_MAIN_ID,C_REMARK,N_STEP,N_TOTALSTEP,N_STEPNAME,N_STATUS,C_EMP_ID,D_MOD_DT,C_STA_ID)");
            strSql.Append(" values (");
            strSql.Append(":C_PLAN_REGROUND_ID,:C_SLAB_MAIN_ID,:C_REMARK,:N_STEP,:N_TOTALSTEP,:N_STEPNAME,:N_STATUS,:C_EMP_ID,:D_MOD_DT,:C_STA_ID)");
            OracleParameter[] parameters = {

                    new OracleParameter(":C_PLAN_REGROUND_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SLAB_MAIN_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
                    new OracleParameter(":N_STEP", OracleDbType.Decimal,2),
                    new OracleParameter(":N_TOTALSTEP", OracleDbType.Decimal,2),
                    new OracleParameter(":N_STEPNAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,2),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":C_STA_ID", OracleDbType.Varchar2,100)
            };
            parameters[0].Value = model.C_PLAN_REGROUND_ID;
            parameters[1].Value = model.C_SLAB_MAIN_ID;
            parameters[2].Value = model.C_REMARK;
            parameters[3].Value = model.N_STEP;
            parameters[4].Value = model.N_TOTALSTEP;
            parameters[5].Value = model.N_STEPNAME;
            parameters[6].Value = model.N_STATUS;
            parameters[7].Value = model.C_EMP_ID;
            parameters[8].Value = model.D_MOD_DT;
            parameters[9].Value = model.C_STA_ID;


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
        public bool Update(Mod_TRC_PLAN_REGROUND_ITEM model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TRC_PLAN_REGROUND_ITEM set ");
            strSql.Append("C_PLAN_REGROUND_ID=:C_PLAN_REGROUND_ID,");
            strSql.Append("C_SLAB_MAIN_ID=:C_SLAB_MAIN_ID,");
            strSql.Append("C_REMARK=:C_REMARK,");
            strSql.Append("N_STEP=:N_STEP,");
            strSql.Append("N_TOTALSTEP=:N_TOTALSTEP,");
            strSql.Append("N_STEPNAME=:N_STEPNAME,");
            strSql.Append("N_STATUS=:N_STATUS,");
            strSql.Append("C_EMP_ID=:C_EMP_ID,");
            strSql.Append("D_MOD_DT=:D_MOD_DT");
            strSql.Append("C_STA_ID=:C_STA_ID");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_PLAN_REGROUND_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SLAB_MAIN_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
                    new OracleParameter(":N_STEP", OracleDbType.Decimal,2),
                    new OracleParameter(":N_TOTALSTEP", OracleDbType.Decimal,2),
                    new OracleParameter(":N_STEPNAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,2),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":C_STA_ID",OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.C_PLAN_REGROUND_ID;
            parameters[1].Value = model.C_SLAB_MAIN_ID;
            parameters[2].Value = model.C_REMARK;
            parameters[3].Value = model.N_STEP;
            parameters[4].Value = model.N_TOTALSTEP;
            parameters[5].Value = model.N_STEPNAME;
            parameters[6].Value = model.N_STATUS;
            parameters[7].Value = model.C_EMP_ID;
            parameters[8].Value = model.D_MOD_DT;
            parameters[9].Value = model.C_STA_ID;
            parameters[10].Value = model.C_ID;

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
            strSql.Append("delete from TRC_PLAN_REGROUND_ITEM ");
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
            strSql.Append("delete from TRC_PLAN_REGROUND_ITEM ");
            strSql.Append(" where C_PLAN_REGROUND_ID=:C_ID ");
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
            strSql.Append("delete from TRC_PLAN_REGROUND_ITEM ");
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
        public Mod_TRC_PLAN_REGROUND_ITEM GetModel(string C_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_PLAN_REGROUND_ID,C_SLAB_MAIN_ID,C_REMARK,N_STEP,N_TOTALSTEP,N_STEPNAME,N_STATUS,C_EMP_ID,D_MOD_DT,C_STA_ID from TRC_PLAN_REGROUND_ITEM ");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)            };
            parameters[0].Value = C_ID;

            Mod_TRC_PLAN_REGROUND_ITEM model = new Mod_TRC_PLAN_REGROUND_ITEM();
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
        public Mod_TRC_PLAN_REGROUND_ITEM DataRowToModel(DataRow row)
        {
            Mod_TRC_PLAN_REGROUND_ITEM model = new Mod_TRC_PLAN_REGROUND_ITEM();
            if (row != null)
            {
                if (row["C_ID"] != null)
                {
                    model.C_ID = row["C_ID"].ToString();
                }
                if (row["C_PLAN_REGROUND_ID"] != null)
                {
                    model.C_PLAN_REGROUND_ID = row["C_PLAN_REGROUND_ID"].ToString();
                }
                if (row["C_SLAB_MAIN_ID"] != null)
                {
                    model.C_SLAB_MAIN_ID = row["C_SLAB_MAIN_ID"].ToString();
                }
                if (row["C_REMARK"] != null)
                {
                    model.C_REMARK = row["C_REMARK"].ToString();
                }
                if (row["N_STEP"] != null && row["N_STEP"].ToString() != "")
                {
                    model.N_STEP = decimal.Parse(row["N_STEP"].ToString());
                }
                if (row["N_TOTALSTEP"] != null && row["N_TOTALSTEP"].ToString() != "")
                {
                    model.N_TOTALSTEP = decimal.Parse(row["N_TOTALSTEP"].ToString());
                }
                if (row["N_STEPNAME"] != null)
                {
                    model.N_STEPNAME = row["N_STEPNAME"].ToString();
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
                if (row["C_STA_ID"] != null && row["C_STA_ID"].ToString() != "")
                {
                    model.C_STA_ID = row["C_STA_ID"].ToString();
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
            strSql.Append("select C_ID,C_PLAN_REGROUND_ID,C_SLAB_MAIN_ID,C_REMARK,N_STEP,N_TOTALSTEP,N_STEPNAME,N_STATUS,C_EMP_ID,D_MOD_DT ,C_STA_ID ");
            strSql.Append(" FROM TRC_PLAN_REGROUND_ITEM ");
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
            strSql.Append("select count(1) FROM TRC_PLAN_REGROUND_ITEM ");
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
            strSql.Append(")AS Row, T.*  from TRC_PLAN_REGROUND_ITEM T ");
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
