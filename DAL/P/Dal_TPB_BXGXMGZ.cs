using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;
namespace DAL
{
    /// <summary>
	/// 数据访问类:TPB_BXGXMGZ
	/// </summary>
	public partial class Dal_TPB_BXGXMGZ
    {
        public Dal_TPB_BXGXMGZ()
        { }
        #region  BasicMethod

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Mod_TPB_BXGXMGZ model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TPB_BXGXMGZ(");
            strSql.Append("C_EMP_ID,D_MOD_DT,C_STL_GRD,C_SLAB_SIZE,C_GZLX,N_JSCN,N_LTH,N_TOTAL_CN,C_IS_BXG,C_REMARK)");
            strSql.Append(" values (");
            strSql.Append(":C_EMP_ID,:D_MOD_DT,:C_STL_GRD,:C_SLAB_SIZE,:C_GZLX,:N_JSCN,:N_LTH,:N_TOTAL_CN,:C_IS_BXG,:C_REMARK)");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":C_STL_GRD", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SLAB_SIZE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_GZLX", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_JSCN", OracleDbType.Decimal,5),
                    new OracleParameter(":N_LTH", OracleDbType.Decimal,4),
                    new OracleParameter(":N_TOTAL_CN", OracleDbType.Decimal,4),
                    new OracleParameter(":C_IS_BXG", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,200)};
            parameters[0].Value = model.C_EMP_ID;
            parameters[1].Value = model.D_MOD_DT;
            parameters[2].Value = model.C_STL_GRD;
            parameters[3].Value = model.C_SLAB_SIZE;
            parameters[4].Value = model.C_GZLX;
            parameters[5].Value = model.N_JSCN;
            parameters[6].Value = model.N_LTH;
            parameters[7].Value = model.N_TOTAL_CN;
            parameters[8].Value = model.C_IS_BXG;
            parameters[9].Value = model.C_REMARK;
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
        public bool Update(Mod_TPB_BXGXMGZ model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TPB_BXGXMGZ set ");
            strSql.Append("C_EMP_ID=:C_EMP_ID,");
            strSql.Append("D_MOD_DT=:D_MOD_DT,");
            strSql.Append("C_STL_GRD=:C_STL_GRD,");
            strSql.Append("C_SLAB_SIZE=:C_SLAB_SIZE,");
            strSql.Append("C_GZLX=:C_GZLX,");
            strSql.Append("N_JSCN=:N_JSCN,");
            strSql.Append("N_LTH=:N_LTH,");
            strSql.Append("N_TOTAL_CN=:N_TOTAL_CN,");
            strSql.Append("C_IS_BXG=:C_IS_BXG,");
            strSql.Append("C_REMARK=:C_REMARK ");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":C_STL_GRD", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SLAB_SIZE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_GZLX", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_JSCN", OracleDbType.Decimal,5),
                    new OracleParameter(":N_LTH", OracleDbType.Decimal,4),
                    new OracleParameter(":N_TOTAL_CN", OracleDbType.Decimal,4),
                    new OracleParameter(":C_IS_BXG", OracleDbType.Varchar2,10),
                     new OracleParameter(":C_REMARK", OracleDbType.Varchar2,200),
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.C_EMP_ID;
            parameters[1].Value = model.D_MOD_DT;
            parameters[2].Value = model.C_STL_GRD;
            parameters[3].Value = model.C_SLAB_SIZE;
            parameters[4].Value = model.C_GZLX;
            parameters[5].Value = model.N_JSCN;
            parameters[6].Value = model.N_LTH;
            parameters[7].Value = model.N_TOTAL_CN;
            parameters[8].Value = model.C_IS_BXG;
            parameters[9].Value = model.C_REMARK;
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
            strSql.Append("delete from TPB_BXGXMGZ ");
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
        /// 得到一个对象实体
        /// </summary>
        public Mod_TPB_BXGXMGZ GetModel(string C_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_EMP_ID,D_MOD_DT,C_STL_GRD,C_SLAB_SIZE,C_GZLX,N_JSCN,N_LTH,N_TOTAL_CN,C_IS_BXG,C_REMARK from TPB_BXGXMGZ ");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)            };
            parameters[0].Value = C_ID;

            Mod_TPB_BXGXMGZ model = new Mod_TPB_BXGXMGZ();
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
        public Mod_TPB_BXGXMGZ GetModel(string C_STL_GRD, string C_SLAB_SIZE, decimal N_LTH, string C_GZLX)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_EMP_ID,D_MOD_DT,C_STL_GRD,C_SLAB_SIZE,C_GZLX,N_JSCN,N_LTH,N_TOTAL_CN,C_IS_BXG,C_REMARK from TPB_BXGXMGZ ");
            strSql.Append(" where C_STL_GRD=:C_STL_GRD AND C_SLAB_SIZE=:C_SLAB_SIZE AND  N_LTH=:N_LTH AND C_GZLX=:C_GZLX");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_STL_GRD", OracleDbType.Varchar2,100) ,
                    new OracleParameter(":C_SLAB_SIZE", OracleDbType.Varchar2,100)  ,
                    new OracleParameter(":N_LTH", OracleDbType.Decimal),
                    new OracleParameter(":C_GZLX", OracleDbType.Varchar2,100)};
            parameters[0].Value = C_STL_GRD;
            parameters[1].Value = C_SLAB_SIZE;
            parameters[2].Value = N_LTH;
            parameters[3].Value = C_GZLX;

            Mod_TPB_BXGXMGZ model = new Mod_TPB_BXGXMGZ();
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
        public Mod_TPB_BXGXMGZ DataRowToModel(DataRow row)
        {
            Mod_TPB_BXGXMGZ model = new Mod_TPB_BXGXMGZ();
            if (row != null)
            {
                if (row["C_ID"] != null)
                {
                    model.C_ID = row["C_ID"].ToString();
                }
                if (row["C_EMP_ID"] != null)
                {
                    model.C_EMP_ID = row["C_EMP_ID"].ToString();
                }
                if (row["D_MOD_DT"] != null && row["D_MOD_DT"].ToString() != "")
                {
                    model.D_MOD_DT = DateTime.Parse(row["D_MOD_DT"].ToString());
                }
                if (row["C_STL_GRD"] != null)
                {
                    model.C_STL_GRD = row["C_STL_GRD"].ToString();
                }
                if (row["C_SLAB_SIZE"] != null)
                {
                    model.C_SLAB_SIZE = row["C_SLAB_SIZE"].ToString();
                }
                if (row["C_GZLX"] != null)
                {
                    model.C_GZLX = row["C_GZLX"].ToString();
                }
                if (row["N_JSCN"] != null && row["N_JSCN"].ToString() != "")
                {
                    model.N_JSCN = decimal.Parse(row["N_JSCN"].ToString());
                }
                if (row["N_LTH"] != null && row["N_LTH"].ToString() != "")
                {
                    model.N_LTH = decimal.Parse(row["N_LTH"].ToString());
                }
                if (row["N_TOTAL_CN"] != null && row["N_TOTAL_CN"].ToString() != "")
                {
                    model.N_TOTAL_CN = decimal.Parse(row["N_TOTAL_CN"].ToString());
                }
                if (row["C_IS_BXG"] != null)
                {
                    model.C_IS_BXG = row["C_IS_BXG"].ToString();
                }
                if (row["C_REMARK"] != null)
                {
                    model.C_REMARK = row["C_REMARK"].ToString();
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
            strSql.Append("select C_ID,C_EMP_ID,D_MOD_DT,C_STL_GRD,C_SLAB_SIZE,C_GZLX,N_JSCN,N_LTH,N_TOTAL_CN,C_IS_BXG,C_REMARK ");
            strSql.Append(" FROM TPB_BXGXMGZ ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperOra.Query(strSql.ToString());
        }




        #endregion  BasicMethod
        #region  ExtensionMethod

        #endregion  ExtensionMethod
    }
}
