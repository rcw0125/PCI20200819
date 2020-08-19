using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;
namespace DAL
{
    /// <summary>
    /// 数据访问类:TRP_PLAN_SLAB_TIME
    /// </summary>
    public partial class Dal_TRP_PLAN_SLAB_TIME
    {
        public Dal_TRP_PLAN_SLAB_TIME()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string C_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TRP_PLAN_SLAB_TIME");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)         };
            parameters[0].Value = C_ID;

            return DbHelperOra.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Mod_TRP_PLAN_SLAB_TIME model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TRP_PLAN_SLAB_TIME(");
            strSql.Append("C_PLAN_ROLL_ID,N_WGT,D_P_START_TIME,D_P_END_TIME,C_STL_GRD,C_STD_CODE,C_SPEC,C_STATE)");
            strSql.Append(" values (");
            strSql.Append(":C_PLAN_ROLL_ID,:N_WGT,:D_P_START_TIME,:D_P_END_TIME,:C_STL_GRD,:C_STD_CODE,:C_SPEC,:C_STATE)");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_PLAN_ROLL_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":D_P_START_TIME", OracleDbType.Date),
                    new OracleParameter(":D_P_END_TIME", OracleDbType.Date),
                    new OracleParameter(":C_STL_GRD", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STD_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SPEC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STATE", OracleDbType.Varchar2,10)};

            parameters[0].Value = model.C_PLAN_ROLL_ID;
            parameters[1].Value = model.N_WGT;
            parameters[2].Value = model.D_P_START_TIME;
            parameters[3].Value = model.D_P_END_TIME;
            parameters[4].Value = model.C_STL_GRD;
            parameters[5].Value = model.C_STD_CODE;
            parameters[6].Value = model.C_SPEC;
            parameters[7].Value = model.C_STATE;

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
		public bool Add_Trans(Mod_TRP_PLAN_SLAB_TIME model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TRP_PLAN_SLAB_TIME(");
            strSql.Append("C_PLAN_ROLL_ID,N_WGT,D_P_START_TIME,D_P_END_TIME,C_STL_GRD,C_STD_CODE,C_SPEC,C_STATE)");
            strSql.Append(" values (");
            strSql.Append(":C_PLAN_ROLL_ID,:N_WGT,:D_P_START_TIME,:D_P_END_TIME,:C_STL_GRD,:C_STD_CODE,:C_SPEC,:C_STATE)");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_PLAN_ROLL_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":D_P_START_TIME", OracleDbType.Date),
                    new OracleParameter(":D_P_END_TIME", OracleDbType.Date),
                    new OracleParameter(":C_STL_GRD", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STD_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SPEC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STATE", OracleDbType.Varchar2,10)};

            parameters[0].Value = model.C_PLAN_ROLL_ID;
            parameters[1].Value = model.N_WGT;
            parameters[2].Value = model.D_P_START_TIME;
            parameters[3].Value = model.D_P_END_TIME;
            parameters[4].Value = model.C_STL_GRD;
            parameters[5].Value = model.C_STD_CODE;
            parameters[6].Value = model.C_SPEC;
            parameters[7].Value = model.C_STATE;

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
        public bool Update(Mod_TRP_PLAN_SLAB_TIME model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TRP_PLAN_SLAB_TIME set ");
            strSql.Append("C_PLAN_ROLL_ID=:C_PLAN_ROLL_ID,");
            strSql.Append("N_WGT=:N_WGT,");
            strSql.Append("D_P_START_TIME=:D_P_START_TIME,");
            strSql.Append("D_P_END_TIME=:D_P_END_TIME,");
            strSql.Append("C_STL_GRD=:C_STL_GRD,");
            strSql.Append("C_STD_CODE=:C_STD_CODE,");
            strSql.Append("C_SPEC=:C_SPEC,");
            strSql.Append("C_STATE=:C_STATE");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_PLAN_ROLL_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":D_P_START_TIME", OracleDbType.Date),
                    new OracleParameter(":D_P_END_TIME", OracleDbType.Date),
                    new OracleParameter(":C_STL_GRD", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STD_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SPEC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STATE", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.C_PLAN_ROLL_ID;
            parameters[1].Value = model.N_WGT;
            parameters[2].Value = model.D_P_START_TIME;
            parameters[3].Value = model.D_P_END_TIME;
            parameters[4].Value = model.C_STL_GRD;
            parameters[5].Value = model.C_STD_CODE;
            parameters[6].Value = model.C_SPEC;
            parameters[7].Value = model.C_STATE;
            parameters[8].Value = model.C_ID;

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
        public bool Update_Trans(Mod_TRP_PLAN_SLAB_TIME model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TRP_PLAN_SLAB_TIME set ");
            strSql.Append("C_PLAN_ROLL_ID=:C_PLAN_ROLL_ID,");
            strSql.Append("N_WGT=:N_WGT,");
            strSql.Append("D_P_START_TIME=:D_P_START_TIME,");
            strSql.Append("D_P_END_TIME=:D_P_END_TIME,");
            strSql.Append("C_STL_GRD=:C_STL_GRD,");
            strSql.Append("C_STD_CODE=:C_STD_CODE,");
            strSql.Append("C_SPEC=:C_SPEC,");
            strSql.Append("C_STATE=:C_STATE");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_PLAN_ROLL_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":D_P_START_TIME", OracleDbType.Date),
                    new OracleParameter(":D_P_END_TIME", OracleDbType.Date),
                    new OracleParameter(":C_STL_GRD", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STD_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SPEC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STATE", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.C_PLAN_ROLL_ID;
            parameters[1].Value = model.N_WGT;
            parameters[2].Value = model.D_P_START_TIME;
            parameters[3].Value = model.D_P_END_TIME;
            parameters[4].Value = model.C_STL_GRD;
            parameters[5].Value = model.C_STD_CODE;
            parameters[6].Value = model.C_SPEC;
            parameters[7].Value = model.C_STATE;
            parameters[8].Value = model.C_ID;

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
        /// 删除一条数据
        /// </summary>
        public bool Delete(string C_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from TRP_PLAN_SLAB_TIME ");
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
            strSql.Append("delete from TRP_PLAN_SLAB_TIME ");
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
        public Mod_TRP_PLAN_SLAB_TIME GetModel(string C_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_PLAN_ROLL_ID,N_WGT,D_P_START_TIME,D_P_END_TIME,C_STL_GRD,C_STD_CODE,C_SPEC,C_STATE from TRP_PLAN_SLAB_TIME ");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)         };
            parameters[0].Value = C_ID;

            Mod_TRP_PLAN_SLAB_TIME model = new Mod_TRP_PLAN_SLAB_TIME();
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
		public Mod_TRP_PLAN_SLAB_TIME GetModel_Trans(string C_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_PLAN_ROLL_ID,N_WGT,D_P_START_TIME,D_P_END_TIME,C_STL_GRD,C_STD_CODE,C_SPEC,C_STATE from  TRP_PLAN_SLAB_TIME where C_STATE is null and C_ID='" + C_ID + "' ");

            Mod_TRP_PLAN_SLAB_TIME model = new Mod_TRP_PLAN_SLAB_TIME();
            DataSet ds = TransactionHelper.Query(strSql.ToString());
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
        public Mod_TRP_PLAN_SLAB_TIME DataRowToModel(DataRow row)
        {
            Mod_TRP_PLAN_SLAB_TIME model = new Mod_TRP_PLAN_SLAB_TIME();
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
                if (row["N_WGT"] != null && row["N_WGT"].ToString() != "")
                {
                    model.N_WGT = decimal.Parse(row["N_WGT"].ToString());
                }
                if (row["D_P_START_TIME"] != null && row["D_P_START_TIME"].ToString() != "")
                {
                    model.D_P_START_TIME = DateTime.Parse(row["D_P_START_TIME"].ToString());
                }
                if (row["D_P_END_TIME"] != null && row["D_P_END_TIME"].ToString() != "")
                {
                    model.D_P_END_TIME = DateTime.Parse(row["D_P_END_TIME"].ToString());
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
                if (row["C_STATE"] != null)
                {
                    model.C_STATE = row["C_STATE"].ToString();
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
            strSql.Append("select C_ID,C_PLAN_ROLL_ID,N_WGT,D_P_START_TIME,D_P_END_TIME,C_STL_GRD,C_STD_CODE,C_SPEC,C_STATE ");
            strSql.Append(" FROM TRP_PLAN_SLAB_TIME ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList_Trans()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_PLAN_ROLL_ID,N_WGT,D_P_START_TIME,D_P_END_TIME,C_STL_GRD,C_STD_CODE,C_SPEC,C_STATE ");
            strSql.Append(" FROM TRP_PLAN_SLAB_TIME where  C_STATE is null order by D_P_START_TIME asc");

            return TransactionHelper.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM TRP_PLAN_SLAB_TIME ");
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
        /// 删除一条数据
        /// </summary>
        public bool Delete_Trans()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from TRP_PLAN_SLAB_TIME ");

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
		/// 得到一个对象实体
		/// </summary>
		public Mod_TRP_PLAN_SLAB_TIME GetModel_BySpec_Trans(string c_spec, string d_p_end_time)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_PLAN_ROLL_ID,N_WGT,D_P_START_TIME,D_P_END_TIME,C_STL_GRD,C_STD_CODE,C_SPEC,C_STATE from  ( select * from trp_plan_slab_time t where t.C_STATE is null and t.c_spec='" + c_spec + "' and t.d_p_start_time<to_date('" + d_p_end_time + "','yyyy-mm-dd hh24:mi:ss') order by t.d_p_start_time asc)where rownum=1 ");

            Mod_TRP_PLAN_SLAB_TIME model = new Mod_TRP_PLAN_SLAB_TIME();
            DataSet ds = TransactionHelper.Query(strSql.ToString());
            if (ds.Tables[0].Rows.Count > 0)
            {
                return DataRowToModel(ds.Tables[0].Rows[0]);
            }
            else
            {
                return null;
            }
        }

        #endregion  BasicMethod

    }
}

