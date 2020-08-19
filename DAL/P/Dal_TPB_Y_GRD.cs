using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;
namespace DAL
{
    /// <summary>
    /// 数据访问类:TPB_Y_GRD
    /// </summary>
    public partial class Dal_TPB_Y_GRD
    {
        public Dal_TPB_Y_GRD()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string C_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TPB_Y_GRD");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)            };
            parameters[0].Value = C_ID;

            return DbHelperOra.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Mod_TPB_Y_GRD model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TPB_Y_GRD(");
            strSql.Append("C_STA_ID,C_STL_GRD,C_STD_CODE,C_PROD_NAME,C_PROD_KIND,N_LEVEL,N_STATUS,C_EMP_ID,D_MOD_DT,C_REMARK,D_START_DATE,D_END_DATE,C_SPEC)");
            strSql.Append(" values (");
            strSql.Append(":C_STA_ID,:C_STL_GRD,:C_STD_CODE,:C_PROD_NAME,:C_PROD_KIND,:N_LEVEL,:N_STATUS,:C_EMP_ID,:D_MOD_DT,:C_REMARK,:D_START_DATE,:D_END_DATE,:C_SPEC)");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_STA_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STL_GRD", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STD_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PROD_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PROD_KIND", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_LEVEL", OracleDbType.Decimal,3),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
                    new OracleParameter(":D_START_DATE", OracleDbType.Date),
                    new OracleParameter(":D_END_DATE", OracleDbType.Date),
                    new OracleParameter(":C_SPEC", OracleDbType.Varchar2,50)};
            parameters[0].Value = model.C_STA_ID;
            parameters[1].Value = model.C_STL_GRD;
            parameters[2].Value = model.C_STD_CODE;
            parameters[3].Value = model.C_PROD_NAME;
            parameters[4].Value = model.C_PROD_KIND;
            parameters[5].Value = model.N_LEVEL;
            parameters[6].Value = model.N_STATUS;
            parameters[7].Value = model.C_EMP_ID;
            parameters[8].Value = model.D_MOD_DT;
            parameters[9].Value =  model.C_REMARK;
            parameters[10].Value = model.D_START_DATE;
            parameters[11].Value = model.D_END_DATE;
            parameters[12].Value = model.C_SPEC;

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
        public bool Update(Mod_TPB_Y_GRD model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TPB_Y_GRD set ");
            strSql.Append("C_STA_ID=:C_STA_ID,");
            strSql.Append("C_STL_GRD=:C_STL_GRD,");
            strSql.Append("C_STD_CODE=:C_STD_CODE,");
            strSql.Append("C_PROD_NAME=:C_PROD_NAME,");
            strSql.Append("C_PROD_KIND=:C_PROD_KIND,");
            strSql.Append("N_LEVEL=:N_LEVEL,");
            strSql.Append("N_STATUS=:N_STATUS,");
            strSql.Append("C_EMP_ID=:C_EMP_ID,");
            strSql.Append("D_MOD_DT=:D_MOD_DT,");
            strSql.Append("C_REMARK=:C_REMARK,");
            strSql.Append("D_START_DATE=:D_START_DATE,");
            strSql.Append("D_END_DATE=:D_END_DATE,");
            strSql.Append("C_SPEC=:C_SPEC");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_STA_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STL_GRD", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STD_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PROD_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PROD_KIND", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_LEVEL", OracleDbType.Decimal,3),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
                    new OracleParameter(":D_START_DATE", OracleDbType.Date),
                    new OracleParameter(":D_END_DATE", OracleDbType.Date),
                    new OracleParameter(":C_SPEC", OracleDbType.Varchar2,50),
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.C_STA_ID;
            parameters[1].Value = model.C_STL_GRD;
            parameters[2].Value = model.C_STD_CODE;
            parameters[3].Value = model.C_PROD_NAME;
            parameters[4].Value = model.C_PROD_KIND;
            parameters[5].Value = model.N_LEVEL;
            parameters[6].Value = model.N_STATUS;
            parameters[7].Value = model.C_EMP_ID;
            parameters[8].Value = model.D_MOD_DT;
            parameters[9].Value = model.C_REMARK;
            parameters[10].Value = model.D_START_DATE;
            parameters[11].Value = model.D_END_DATE;
            parameters[12].Value = model.C_SPEC;
            parameters[13].Value = model.C_ID;

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
            strSql.Append("delete from TPB_Y_GRD ");
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
            strSql.Append("delete from TPB_Y_GRD ");
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
        public Mod_TPB_Y_GRD GetModel(string C_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_STA_ID,C_STL_GRD,C_STD_CODE,C_PROD_NAME,C_PROD_KIND,N_LEVEL,N_STATUS,C_EMP_ID,D_MOD_DT,C_REMARK,D_START_DATE,D_END_DATE,C_SPEC from TPB_Y_GRD ");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)            };
            parameters[0].Value = C_ID;

            Mod_TPB_Y_GRD model = new Mod_TPB_Y_GRD();
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
        public Mod_TPB_Y_GRD DataRowToModel(DataRow row)
        {
            Mod_TPB_Y_GRD model = new Mod_TPB_Y_GRD();
            if (row != null)
            {
                if (row["C_ID"] != null)
                {
                    model.C_ID = row["C_ID"].ToString();
                }
                if (row["C_STA_ID"] != null)
                {
                    model.C_STA_ID = row["C_STA_ID"].ToString();
                }
                if (row["C_STL_GRD"] != null)
                {
                    model.C_STL_GRD = row["C_STL_GRD"].ToString();
                }
                if (row["C_STD_CODE"] != null)
                {
                    model.C_STD_CODE = row["C_STD_CODE"].ToString();
                }
                if (row["C_PROD_NAME"] != null)
                {
                    model.C_PROD_NAME = row["C_PROD_NAME"].ToString();
                }
                if (row["C_PROD_KIND"] != null)
                {
                    model.C_PROD_KIND = row["C_PROD_KIND"].ToString();
                }
                if (row["N_LEVEL"] != null && row["N_LEVEL"].ToString() != "")
                {
                    model.N_LEVEL = decimal.Parse(row["N_LEVEL"].ToString());
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
                if (row["D_START_DATE"] != null && row["D_START_DATE"].ToString() != "")
                {
                    model.D_START_DATE = DateTime.Parse(row["D_START_DATE"].ToString());
                }
                if (row["D_END_DATE"] != null && row["D_END_DATE"].ToString() != "")
                {
                    model.D_END_DATE = DateTime.Parse(row["D_END_DATE"].ToString());
                }
                if (row["C_SPEC"] != null)
                {
                    model.C_SPEC = row["C_SPEC"].ToString();
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
            strSql.Append("select C_ID,C_STA_ID,C_STL_GRD,C_STD_CODE,C_PROD_NAME,C_PROD_KIND,N_LEVEL,N_STATUS,C_EMP_ID,D_MOD_DT,C_REMARK,D_START_DATE,D_END_DATE,C_SPEC ");
            strSql.Append(" FROM TPB_Y_GRD ");
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
            strSql.Append("select count(1) FROM TPB_Y_GRD ");
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
            strSql.Append(")AS Row, T.*  from TPB_Y_GRD T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            return DbHelperOra.Query(strSql.ToString());
        }

        /*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			OracleParameter[] parameters = {
					new OracleParameter(":tblName", OracleDbType.Varchar2, 255),
					new OracleParameter(":fldName", OracleDbType.Varchar2, 255),
					new OracleParameter(":PageSize", OracleDbType.Decimal),
					new OracleParameter(":PageIndex", OracleDbType.Decimal),
					new OracleParameter(":IsReCount", OracleType.Clob),
					new OracleParameter(":OrderType", OracleType.Clob),
					new OracleParameter(":strWhere", OracleDbType.Varchar2,1000),
					};
			parameters[0].Value = "TPB_Y_GRD";
			parameters[1].Value = "C_ID";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperOra.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

        #endregion  BasicMethod
        #region  ExtensionMethod
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(int N_STATUS, string C_STA_ID, string C_STL_GRD, String C_STD_CODE)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_STA_ID,C_STL_GRD,C_STD_CODE,N_LEVEL,C_REMARK,C_PROD_NAME,C_PROD_KIND,N_STATUS,C_EMP_ID,D_MOD_DT,C_SPEC ");
            strSql.Append(" FROM TPB_Y_GRD WHERE N_STATUS='" + N_STATUS + "' ");
            if (C_STA_ID.Trim() != "")
            {
                if (C_STA_ID.Length>5)
                {
                    strSql.Append(" and C_STA_ID='" + C_STA_ID + "' ");
                }
                else
                {
                    strSql.Append(" and C_STA_ID IN (select C_ID FROM TB_STA WHERE C_STA_CODE LIKE '%" + C_STA_ID + "') ");
                }
              
            }
            if (C_STL_GRD.Trim() != "")
            {
                strSql.Append(" and C_STL_GRD LIKE'%" + C_STL_GRD + "%' ");
            }
            if (C_STD_CODE.Trim() != "")
            {
                strSql.Append(" and C_STD_CODE LIKE'%" + C_STD_CODE + "%' ");
            }
            strSql.Append(" ORDER BY C_STA_ID,C_STL_GRD");
            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 获取所有规格
        /// </summary>
        /// <returns></returns>
        public DataTable GetGG()
        {
            string sql = "SELECT DISTINCT T.C_SPEC FROM TQB_STD_SPEC T,TQB_STD_MAIN TB WHERE T.C_STD_MAIN_ID=TB.C_ID AND TB.N_IS_CHECK=1 AND TB.N_STATUS=1 AND  T.N_STATUS=1 ORDER BY TO_NUMBER(REPLACE(T.C_SPEC,'φ'))";
            return DbHelperOra.Query(sql).Tables[0];
        }

        /// <summary>
        /// 获取钢坯连铸生产信息
        /// </summary>
        /// <param name="c_stl_grd">钢种</param>
        /// <param name="c_std_code">执行标准</param>
        /// <returns></returns>
        public DataTable GetCCM(string c_stl_grd,string c_std_code)
        {

            string sql = " SELECT T.C_STL_GRD, T.C_STD_CODE, A.C_ID, A.C_STA_CODE, A.C_STA_DESC FROM TPB_Y_GRD T  LEFT JOIN TB_STA A    ON T.C_STA_ID = A.C_ID  WHERE c_stl_grd='"+ c_stl_grd + "' AND T.c_std_code='"+ c_std_code + "'";
            return DbHelperOra.Query(sql).Tables[0];
        }
        #endregion  ExtensionMethod
    }
}
