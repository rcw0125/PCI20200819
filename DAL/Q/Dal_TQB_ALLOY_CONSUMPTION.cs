using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;
namespace DAL
{
    /// <summary>
    /// 数据访问类:TQB_ALLOY_CONSUMPTION
    /// </summary>
    public partial class Dal_TQB_ALLOY_CONSUMPTION
    {
        public Dal_TQB_ALLOY_CONSUMPTION()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string C_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TQB_ALLOY_CONSUMPTION");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)         };
            parameters[0].Value = C_ID;

            return DbHelperOra.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Mod_TQB_ALLOY_CONSUMPTION model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TQB_ALLOY_CONSUMPTION(");
            strSql.Append("C_STL_GRD,C_STD_CODE,C_ALLOYN__NAME,N_ALLOY_WGT,N_STATUS,C_EMP_ID,D_MOD_DT,C_REMARK,C_ALLOYN__CODE)");
            strSql.Append(" values (");
            strSql.Append(":C_STL_GRD,:C_STD_CODE,:C_ALLOYN__NAME,:N_ALLOY_WGT,:N_STATUS,:C_EMP_ID,:D_MOD_DT,:C_REMARK,:C_ALLOYN__CODE)");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_STL_GRD", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STD_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ALLOYN__NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_ALLOY_WGT", OracleDbType.Decimal),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_ALLOYN__CODE", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.C_STL_GRD;
            parameters[1].Value = model.C_STD_CODE;
            parameters[2].Value = model.C_ALLOYN__NAME;
            parameters[3].Value = model.N_ALLOY_WGT;
            parameters[4].Value = model.N_STATUS;
            parameters[5].Value = model.C_EMP_ID;
            parameters[6].Value = model.D_MOD_DT;
            parameters[7].Value = model.C_REMARK;
            parameters[8].Value = model.C_ALLOYN__CODE;

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
        public bool Update(Mod_TQB_ALLOY_CONSUMPTION model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TQB_ALLOY_CONSUMPTION set ");
            strSql.Append("C_STL_GRD=:C_STL_GRD,");
            strSql.Append("C_STD_CODE=:C_STD_CODE,");
            strSql.Append("C_ALLOYN__NAME=:C_ALLOYN__NAME,");
            strSql.Append("N_ALLOY_WGT=:N_ALLOY_WGT,");
            strSql.Append("N_STATUS=:N_STATUS,");
            strSql.Append("C_EMP_ID=:C_EMP_ID,");
            strSql.Append("D_MOD_DT=:D_MOD_DT,");
            strSql.Append("C_REMARK=:C_REMARK,");
            strSql.Append("C_ALLOYN__CODE=:C_ALLOYN__CODE");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_STL_GRD", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STD_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ALLOYN__NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_ALLOY_WGT", OracleDbType.Decimal),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
                     new OracleParameter(":C_ALLOYN__CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.C_STL_GRD;
            parameters[1].Value = model.C_STD_CODE;
            parameters[2].Value = model.C_ALLOYN__NAME;
            parameters[3].Value = model.N_ALLOY_WGT;
            parameters[4].Value = model.N_STATUS;
            parameters[5].Value = model.C_EMP_ID;
            parameters[6].Value = model.D_MOD_DT;
            parameters[7].Value = model.C_REMARK;
            parameters[8].Value = model.C_ALLOYN__CODE;
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
            strSql.Append("delete from TQB_ALLOY_CONSUMPTION ");
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
            strSql.Append("delete from TQB_ALLOY_CONSUMPTION ");
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
        public Mod_TQB_ALLOY_CONSUMPTION GetModel(string C_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_STL_GRD,C_STD_CODE,C_ALLOYN__NAME,N_ALLOY_WGT,N_STATUS,C_EMP_ID,D_MOD_DT,C_REMARK,C_ALLOYN__CODE from TQB_ALLOY_CONSUMPTION ");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)         };
            parameters[0].Value = C_ID;

            Mod_TQB_ALLOY_CONSUMPTION model = new Mod_TQB_ALLOY_CONSUMPTION();
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
        /// 根据钢种、执行标准、合金名称得到实体对象
        /// </summary>
        /// <param name="C_STL_GRD">钢种</param>
        /// <param name="C_STD_CODE">执行标准</param>
        /// <param name="C_ALLOYN__CODE">合金代码</param>
        /// <param name="C_ALLOYN__NAME">合金名称</param>
        /// <returns></returns>
		public Mod_TQB_ALLOY_CONSUMPTION GetModel(string C_STL_GRD, string C_STD_CODE,string C_ALLOYN__CODE)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_STL_GRD,C_STD_CODE,C_ALLOYN__NAME,N_ALLOY_WGT,N_STATUS,C_EMP_ID,D_MOD_DT,C_REMARK,C_ALLOYN__CODE from TQB_ALLOY_CONSUMPTION ");
            strSql.Append(" where C_STL_GRD=:C_STL_GRD and  C_STD_CODE=:C_STD_CODE and C_ALLOYN__CODE=:C_ALLOYN__CODE ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_STL_GRD", OracleDbType.Varchar2,100) ,
                    new OracleParameter(":C_STD_CODE", OracleDbType.Varchar2,100) ,
                    new OracleParameter(":C_ALLOYN__CODE", OracleDbType.Varchar2,100)};
            parameters[0].Value = C_STL_GRD;
            parameters[1].Value = C_STD_CODE;
            parameters[2].Value = C_ALLOYN__CODE;

            Mod_TQB_ALLOY_CONSUMPTION model = new Mod_TQB_ALLOY_CONSUMPTION();
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
        public Mod_TQB_ALLOY_CONSUMPTION DataRowToModel(DataRow row)
        {
            Mod_TQB_ALLOY_CONSUMPTION model = new Mod_TQB_ALLOY_CONSUMPTION();
            if (row != null)
            {
                if (row["C_ID"] != null)
                {
                    model.C_ID = row["C_ID"].ToString();
                }
                if (row["C_STL_GRD"] != null)
                {
                    model.C_STL_GRD = row["C_STL_GRD"].ToString();
                }
                if (row["C_STD_CODE"] != null)
                {
                    model.C_STD_CODE = row["C_STD_CODE"].ToString();
                }
                if (row["C_ALLOYN__NAME"] != null)
                {
                    model.C_ALLOYN__NAME = row["C_ALLOYN__NAME"].ToString();
                }
                if (row["C_ALLOYN__CODE"] != null)
                {
                    model.C_ALLOYN__CODE = row["C_ALLOYN__CODE"].ToString();
                }
                if (row["N_ALLOY_WGT"] != null && row["N_ALLOY_WGT"].ToString() != "")
                {
                    model.N_ALLOY_WGT = decimal.Parse(row["N_ALLOY_WGT"].ToString());
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
            strSql.Append("select C_ID,C_STL_GRD,C_STD_CODE,C_ALLOYN__NAME,N_ALLOY_WGT,N_STATUS,C_EMP_ID,D_MOD_DT,C_REMARK,C_ALLOYN__CODE ");
            strSql.Append(" FROM TQB_ALLOY_CONSUMPTION ");
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
            strSql.Append("select count(1) FROM TQB_ALLOY_CONSUMPTION ");
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
            strSql.Append(")AS Row, T.*  from TQB_ALLOY_CONSUMPTION T ");
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
        /// 根据钢种、执行标准获取数据列表
        /// </summary>
        /// <param name="C_STL_GRD"></param>
        /// <param name="C_STD_CODE"></param>
        /// <returns></returns>
        public DataSet GetList(string C_STL_GRD,string C_STD_CODE)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT T.C_STL_GRD, T.C_STD_CODE, T.C_REMARK ");
            strSql.Append(" FROM TQB_ALLOY_CONSUMPTION T ");
            strSql.Append("  WHERE 1=1 ");
            if (C_STL_GRD.Trim().Length>0)
            {
                strSql.Append(" AND T.C_STL_GRD LIKE '%"+ C_STL_GRD + "%'");

            }
            if (C_STD_CODE.Trim().Length > 0)
            {
                strSql.Append(" AND T.C_STD_CODE LIKE '%" + C_STD_CODE + "%'");

            }
            strSql.Append("  GROUP BY T.C_STL_GRD, T.C_STD_CODE, T.C_REMARK ");
            strSql.Append("  ORDER BY T.C_REMARK, T.C_STL_GRD, T.C_STD_CODE  ");
            
            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 根据钢种、执行标准获取合金需求数量
        /// </summary>
        /// <param name="C_STL_GRD"></param>
        /// <param name="C_STD_CODE"></param>
        /// <returns></returns>
        public DataSet GetAlloy(string C_STL_GRD, string C_STD_CODE)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT C_ID,C_STL_GRD,C_STD_CODE,C_ALLOYN__CODE,C_ALLOYN__NAME,N_ALLOY_WGT,N_STATUS,C_EMP_ID,D_MOD_DT,C_REMARK ");
            strSql.Append(" FROM TQB_ALLOY_CONSUMPTION T ");
            strSql.Append("  WHERE N_STATUS=1 ");
            if (C_STL_GRD.Trim().Length > 0)
            {
                strSql.Append(" AND T.C_STL_GRD = '" + C_STL_GRD + "'");

            }
            if (C_STD_CODE.Trim().Length > 0)
            {
                strSql.Append(" AND T.C_STD_CODE = '" + C_STD_CODE + "'");

            }
            strSql.Append("  ORDER BY C_STL_GRD,C_STD_CODE, T.C_ID  ");
            return DbHelperOra.Query(strSql.ToString());

        }
        /// <summary>
        /// 根据合金代码和合金名称查询
        /// </summary>
        /// <param name="C_STL_GRD">钢种</param>
        /// <param name="C_STD_CODE">执行标准</param>
        /// <param name="C_ALLOYN__CODE">合金代码</param>
        /// <param name="C_ALLOYN__NAME">合金名称</param>
        /// <returns></returns>
        public DataSet GetAlloyByWhere(string C_STL_GRD, string C_STD_CODE, string C_ALLOYN__CODE, string C_ALLOYN__NAME)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT C_ID,C_STL_GRD,C_STD_CODE,C_ALLOYN__CODE,C_ALLOYN__NAME,N_ALLOY_WGT,N_STATUS,C_EMP_ID,D_MOD_DT,C_REMARK ");
            strSql.Append(" FROM TQB_ALLOY_CONSUMPTION T ");
            strSql.Append("  WHERE N_STATUS=1 ");
            if (C_STL_GRD.Trim().Length > 0)
            {
                strSql.Append(" AND T.C_STL_GRD = '" + C_STL_GRD + "'");

            }
            if (C_STD_CODE.Trim().Length > 0)
            {
                strSql.Append(" AND T.C_STD_CODE = '" + C_STD_CODE + "'");

            }
            if (C_ALLOYN__CODE.Trim().Length > 0)
            {
                strSql.Append(" AND T.C_ALLOYN__CODE  like  '%" + C_ALLOYN__CODE + "%'");

            }
            if (C_ALLOYN__NAME.Trim().Length > 0)
            {
                strSql.Append(" AND T.C_ALLOYN__NAME like  '%" + C_ALLOYN__NAME + "%'");

            }
            strSql.Append("  ORDER BY C_STL_GRD,C_STD_CODE, T.C_ID  ");
            return DbHelperOra.Query(strSql.ToString());

        }
        #endregion  ExtensionMethod
    }
}

