using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;

namespace DAL
{
    /// <summary>
    /// 数据访问类:TRC_ROLL_PDD
    /// </summary>
    public partial class Dal_TRC_ROLL_PDD
    {
        public Dal_TRC_ROLL_PDD()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string C_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TRC_ROLL_PDD");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)         };
            parameters[0].Value = C_ID;

            return DbHelperOra.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Mod_TRC_ROLL_PDD model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TRC_ROLL_PDD(");
            strSql.Append("C_ID,C_CK,D_PDRQ,C_YSDH,D_INSERT,C_REMARK,N_STATUS)");
            strSql.Append(" values (");
            strSql.Append(":C_ID,:C_CK,:D_PDRQ,:C_YSDH,:D_INSERT,:C_REMARK,:N_STATUS)");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CK", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_PDRQ", OracleDbType.Date),
                    new OracleParameter(":C_YSDH", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_INSERT", OracleDbType.Date),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,4)};
            parameters[0].Value = model.C_ID;
            parameters[1].Value = model.C_CK;
            parameters[2].Value = model.D_PDRQ;
            parameters[3].Value = model.C_YSDH;
            parameters[4].Value = model.D_INSERT;
            parameters[5].Value = model.C_REMARK;
            parameters[6].Value = model.N_STATUS;

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
        public bool Add_Trans(Mod_TRC_ROLL_PDD model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TRC_ROLL_PDD(");
            strSql.Append("C_ID,C_CK,D_PDRQ,C_YSDH,D_INSERT,C_REMARK,N_STATUS)");
            strSql.Append(" values (");
            strSql.Append(":C_ID,:C_CK,:D_PDRQ,:C_YSDH,:D_INSERT,:C_REMARK,:N_STATUS)");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CK", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_PDRQ", OracleDbType.Date),
                    new OracleParameter(":C_YSDH", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_INSERT", OracleDbType.Date),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,4)};
            parameters[0].Value = model.C_ID;
            parameters[1].Value = model.C_CK;
            parameters[2].Value = model.D_PDRQ;
            parameters[3].Value = model.C_YSDH;
            parameters[4].Value = model.D_INSERT;
            parameters[5].Value = model.C_REMARK;
            parameters[6].Value = model.N_STATUS;

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
        public bool Update(Mod_TRC_ROLL_PDD model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TRC_ROLL_PDD set ");
            strSql.Append("C_CK=:C_CK,");
            strSql.Append("D_PDRQ=:D_PDRQ,");
            strSql.Append("C_YSDH=:C_YSDH,");
            strSql.Append("D_INSERT=:D_INSERT,");
            strSql.Append("C_REMARK=:C_REMARK,");
            strSql.Append("N_STATUS=:N_STATUS");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_CK", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_PDRQ", OracleDbType.Date),
                    new OracleParameter(":C_YSDH", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_INSERT", OracleDbType.Date),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,4),
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.C_CK;
            parameters[1].Value = model.D_PDRQ;
            parameters[2].Value = model.C_YSDH;
            parameters[3].Value = model.D_INSERT;
            parameters[4].Value = model.C_REMARK;
            parameters[5].Value = model.N_STATUS;
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
            strSql.Append("delete from TRC_ROLL_PDD ");
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
            strSql.Append("delete from TRC_ROLL_PDD ");
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
        public Mod_TRC_ROLL_PDD GetModel(string C_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_CK,D_PDRQ,C_YSDH,D_INSERT,C_REMARK,N_STATUS from TRC_ROLL_PDD ");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)         };
            parameters[0].Value = C_ID;

            Mod_TRC_ROLL_PDD model = new Mod_TRC_ROLL_PDD();
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
        public Mod_TRC_ROLL_PDD DataRowToModel(DataRow row)
        {
            Mod_TRC_ROLL_PDD model = new Mod_TRC_ROLL_PDD();
            if (row != null)
            {
                if (row["C_ID"] != null)
                {
                    model.C_ID = row["C_ID"].ToString();
                }
                if (row["C_CK"] != null)
                {
                    model.C_CK = row["C_CK"].ToString();
                }
                if (row["D_PDRQ"] != null)
                {
                    model.D_PDRQ = DateTime.Parse(row["D_PDRQ"].ToString());
                }
                if (row["C_YSDH"] != null)
                {
                    model.C_YSDH = row["C_YSDH"].ToString();
                }
                if (row["D_INSERT"] != null && row["D_INSERT"].ToString() != "")
                {
                    model.D_INSERT = DateTime.Parse(row["D_INSERT"].ToString());
                }
                if (row["C_REMARK"] != null)
                {
                    model.C_REMARK = row["C_REMARK"].ToString();
                }
                if (row["N_STATUS"] != null && row["N_STATUS"].ToString() != "")
                {
                    model.N_STATUS = decimal.Parse(row["N_STATUS"].ToString());
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
            strSql.Append("select C_ID,C_CK,D_PDRQ,C_YSDH,D_INSERT,C_REMARK,N_STATUS ");
            strSql.Append(" FROM TRC_ROLL_PDD ");
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
            strSql.Append("select count(1) FROM TRC_ROLL_PDD ");
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
            strSql.Append(")AS Row, T.*  from TRC_ROLL_PDD T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
		/// 获取盘点单号
		/// </summary>
		public string Get_PDDH(string strTime, string strCK)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select max(t.c_ysdh) from TRC_ROLL_PDD t where t.d_pdrq=to_date('" + strTime + "','yyyy-mm-dd hh24:mi:ss') and t.c_ck='" + strCK + "' ");

            object obj = TransactionHelper.GetSingle(strSql.ToString());
            if (obj == null)
            {
                return "";
            }
            else
            {
                return obj.ToString();
            }
        }

        /// <summary>
		/// 获取最大盘点单号
		/// </summary>
		public string Get_Max_PDDH(string strTime)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select max(substr(t.c_ysdh,3)) from TRC_ROLL_PDD t where to_char(t.d_pdrq,'yyyy-mm-dd')=to_char(to_date('" + strTime + "','yyyy-mm-dd hh24:mi:ss'),'yyyy-mm-dd') ");

            object obj = TransactionHelper.GetSingle(strSql.ToString());
            if (obj == null)
            {
                return "";
            }
            else
            {
                return obj.ToString();
            }
        }

        /// <summary>
		/// 获取最大盘点单号
		/// </summary>
		public string Get_Max_ID()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select max(t.C_ID) from TRC_ROLL_PDD t ");

            object obj = DbHelperOra.GetSingle(strSql.ToString());
            if (obj == null)
            {
                return "";
            }
            else
            {
                return obj.ToString();
            }
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add_RF_Trans(string strSql)
        {
            int rows = TransactionHelper_SQL.ExecuteSql(strSql.ToString());
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
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strTime1, string strTime2)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_CK,D_PDRQ,C_YSDH,D_INSERT,C_REMARK,N_STATUS ");
            strSql.Append(" FROM TRC_ROLL_PDD where D_INSERT between to_date('" + strTime1 + "','yyyy-mm-dd hh24:mi:ss') and to_date('" + strTime2 + "','yyyy-mm-dd hh24:mi:ss') ");

            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet Get_PD_List()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ysdh from SeZJB_PDD_FINISHED WHERE ZJBstatus=0 ");

            return DbHelper_SQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet Get_PD_ITEM_List(string YSDH)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT YSDH,BARCODE,PCH,SX,ZCSL,ZCZL,SPSL,SPZL,JLDW,PDCY,SHBZ,ZLDW,vfree0,vfree1,vfree2,vfree3,vfree4 FROM      WMS_CHE_PDDNC_DETAIL where YSDH = '" + YSDH + "'");

            return DbHelper_SQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update_RF_Trans(string strSql)
        {
            int rows = TransactionHelper_SQL.ExecuteSql(strSql);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        #endregion  BasicMethod
        #region  ExtensionMethod

        #endregion  ExtensionMethod
    }
}

