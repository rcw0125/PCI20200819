using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;
namespace DAL
{
    /// <summary>
    /// 数据访问类:TQB_TSBZ_MAIN
    /// </summary>
    public partial class Dal_TQB_TSBZ_MAIN
    {
        public Dal_TQB_TSBZ_MAIN()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string C_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TQB_TSBZ_MAIN");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)         };
            parameters[0].Value = C_ID;

            return DbHelperOra.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Mod_TQB_TSBZ_MAIN model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TQB_TSBZ_MAIN(");
            strSql.Append("C_ID,C_XY_CODE,C_XY_DESC,C_STL_GRD,C_PROD_NAME,C_PROD_KIND,C_ROUTE,C_EDITION,N_IS_CHECK,C_REMARK,C_EMP_ID,C_IS_OFTEN,C_REMARK_JB,N_EDIT_NUM)");
            strSql.Append(" values (");
            strSql.Append(":C_ID,:C_XY_CODE,:C_XY_DESC,:C_STL_GRD,:C_PROD_NAME,:C_PROD_KIND,:C_ROUTE,:C_EDITION,:N_IS_CHECK,:C_REMARK,:C_EMP_ID,:C_IS_OFTEN,:C_REMARK_JB,:N_EDIT_NUM)");
            OracleParameter[] parameters = {
                 new OracleParameter(":C_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_XY_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_XY_DESC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STL_GRD", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PROD_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PROD_KIND", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ROUTE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_EDITION", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_IS_CHECK", OracleDbType.Decimal,1),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_IS_OFTEN", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_REMARK_JB", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_EDIT_NUM", OracleDbType.Decimal,5)};
            parameters[0].Value = model.C_ID;
            parameters[1].Value = model.C_XY_CODE;
            parameters[2].Value = model.C_XY_DESC;
            parameters[3].Value = model.C_STL_GRD;
            parameters[4].Value = model.C_PROD_NAME;
            parameters[5].Value = model.C_PROD_KIND;
            parameters[6].Value = model.C_ROUTE;
            parameters[7].Value = model.C_EDITION;
            parameters[8].Value = model.N_IS_CHECK;
            parameters[9].Value = model.C_REMARK;
            parameters[10].Value = model.C_EMP_ID;
            parameters[11].Value = model.C_IS_OFTEN;
            parameters[12].Value = model.C_REMARK_JB;
            parameters[13].Value = model.N_EDIT_NUM;
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
        public bool Update(Mod_TQB_TSBZ_MAIN model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TQB_TSBZ_MAIN set ");
            strSql.Append("C_XY_CODE=:C_XY_CODE,");
            strSql.Append("C_XY_DESC=:C_XY_DESC,");
            strSql.Append("C_STL_GRD=:C_STL_GRD,");
            strSql.Append("C_PROD_NAME=:C_PROD_NAME,");
            strSql.Append("C_PROD_KIND=:C_PROD_KIND,");
            strSql.Append("C_ROUTE=:C_ROUTE,");
            strSql.Append("C_EDITION=:C_EDITION,");
            strSql.Append("N_IS_CHECK=:N_IS_CHECK,");
            strSql.Append("N_STATUS=:N_STATUS,");
            strSql.Append("C_REMARK=:C_REMARK,");
            strSql.Append("C_EMP_ID=:C_EMP_ID,");
            strSql.Append("D_MOD_DT=:D_MOD_DT,");
            strSql.Append("C_IS_OFTEN=:C_IS_OFTEN,");
            strSql.Append("C_REMARK_JB=:C_REMARK_JB,");
            strSql.Append("N_EDIT_NUM=:N_EDIT_NUM");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_XY_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_XY_DESC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STL_GRD", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PROD_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PROD_KIND", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ROUTE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_EDITION", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_IS_CHECK", OracleDbType.Decimal,1),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":C_IS_OFTEN", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_REMARK_JB", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_EDIT_NUM", OracleDbType.Decimal,5),
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.C_XY_CODE;
            parameters[1].Value = model.C_XY_DESC;
            parameters[2].Value = model.C_STL_GRD;
            parameters[3].Value = model.C_PROD_NAME;
            parameters[4].Value = model.C_PROD_KIND;
            parameters[5].Value = model.C_ROUTE;
            parameters[6].Value = model.C_EDITION;
            parameters[7].Value = model.N_IS_CHECK;
            parameters[8].Value = model.N_STATUS;
            parameters[9].Value = model.C_REMARK;
            parameters[10].Value = model.C_EMP_ID;
            parameters[11].Value = model.D_MOD_DT;
            parameters[12].Value = model.C_IS_OFTEN;
            parameters[13].Value = model.C_REMARK_JB;
            parameters[14].Value = model.N_EDIT_NUM;
            parameters[15].Value = model.C_ID;

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
            strSql.Append("delete from TQB_TSBZ_MAIN ");
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
            strSql.Append("delete from TQB_TSBZ_MAIN ");
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
        public Mod_TQB_TSBZ_MAIN GetModel(string C_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_XY_CODE,C_XY_DESC,C_STL_GRD,C_PROD_NAME,C_PROD_KIND,C_ROUTE,C_EDITION,N_IS_CHECK,N_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT,C_IS_OFTEN,C_REMARK_JB,N_EDIT_NUM from TQB_TSBZ_MAIN ");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)         };
            parameters[0].Value = C_ID;

            Mod_TQB_TSBZ_MAIN model = new Mod_TQB_TSBZ_MAIN();
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
        public Mod_TQB_TSBZ_MAIN DataRowToModel(DataRow row)
        {
            Mod_TQB_TSBZ_MAIN model = new Mod_TQB_TSBZ_MAIN();
            if (row != null)
            {
                if (row["C_ID"] != null)
                {
                    model.C_ID = row["C_ID"].ToString();
                }
                if (row["C_XY_CODE"] != null)
                {
                    model.C_XY_CODE = row["C_XY_CODE"].ToString();
                }
                if (row["C_XY_DESC"] != null)
                {
                    model.C_XY_DESC = row["C_XY_DESC"].ToString();
                }
                if (row["C_STL_GRD"] != null)
                {
                    model.C_STL_GRD = row["C_STL_GRD"].ToString();
                }
                if (row["C_PROD_NAME"] != null)
                {
                    model.C_PROD_NAME = row["C_PROD_NAME"].ToString();
                }
                if (row["C_PROD_KIND"] != null)
                {
                    model.C_PROD_KIND = row["C_PROD_KIND"].ToString();
                }
                if (row["C_ROUTE"] != null)
                {
                    model.C_ROUTE = row["C_ROUTE"].ToString();
                }
                if (row["C_EDITION"] != null)
                {
                    model.C_EDITION = row["C_EDITION"].ToString();
                }
                if (row["N_IS_CHECK"] != null && row["N_IS_CHECK"].ToString() != "")
                {
                    model.N_IS_CHECK = decimal.Parse(row["N_IS_CHECK"].ToString());
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
                if (row["C_IS_OFTEN"] != null)
                {
                    model.C_IS_OFTEN = row["C_IS_OFTEN"].ToString();
                }
                if (row["C_REMARK_JB"] != null)
                {
                    model.C_REMARK_JB = row["C_REMARK_JB"].ToString();
                }
                if (row["N_EDIT_NUM"] != null && row["N_EDIT_NUM"].ToString() != "")
                {
                    model.N_EDIT_NUM = decimal.Parse(row["N_EDIT_NUM"].ToString());
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
            strSql.Append("select C_ID,C_XY_CODE,C_XY_DESC,C_STL_GRD,C_PROD_NAME,C_PROD_KIND,C_ROUTE,C_EDITION,N_IS_CHECK,N_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT,C_IS_OFTEN,C_REMARK_JB,N_EDIT_NUM ");
            strSql.Append(" FROM TQB_TSBZ_MAIN ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperOra.Query(strSql.ToString());
        }


        /// <summary>
        /// 加载铁水标准
        /// </summary>
        /// <param name="strGZFL">钢种分类</param>
        /// <param name="strGZ">钢种</param>
        /// <param name="strBZ">标准</param>
        /// <param name="iStatus">状态</param>
        /// <returns></returns>
        public DataSet GetListByWhere(string strGZFL, string strGZ, string strBZ, int iStatus)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_XY_CODE,C_XY_DESC,C_STL_GRD,C_PROD_NAME,C_PROD_KIND,C_ROUTE,C_EDITION,N_IS_CHECK,N_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT,C_IS_OFTEN,C_REMARK_JB,N_EDIT_NUM ");
            strSql.Append(" FROM TQB_TSBZ_MAIN  where 1=1 ");
            if (strGZFL.Trim() != "")
            {
                strSql.Append(" AND C_PROD_KIND LIKE '%" + strGZFL + "%' ");
            }
            if (strGZ.Trim() != "")
            {
                strSql.Append(" AND C_STL_GRD LIKE '%" + strGZ + "%' ");
            }
            if (strBZ.Trim() != "")
            {
                strSql.Append(" AND C_XY_CODE LIKE '%" + strBZ + "%' ");
            }
            if (iStatus.ToString() != "")
            {
                strSql.Append(" AND N_STATUS LIKE '%" + iStatus + "%' ");
            }
            strSql.Append("  ORDER BY C_PROD_KIND ");
            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM TQB_TSBZ_MAIN ");
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
    }
}
