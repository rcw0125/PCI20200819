using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;
namespace DAL
{
    /// <summary>
    /// 数据访问类:TQB_STD_FILE
    /// </summary>
    public partial class Dal_TQB_STD_FILE
    {
        public Dal_TQB_STD_FILE()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string C_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TQB_STD_FILE");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)          };
            parameters[0].Value = C_ID;

            return DbHelperOra.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Mod_TQB_STD_FILE model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TQB_STD_FILE(");
            strSql.Append("C_STD_FILE_TYPE_ID,C_STD_FILE_CODE,C_STD_FILE_NAME,C_STD_FILE_PATH,C_FILE_NAME,N_STATUS,C_REMARK,C_EMP_ID)");
            strSql.Append(" values (");
            strSql.Append(":C_STD_FILE_TYPE_ID,:C_STD_FILE_CODE,:C_STD_FILE_NAME,:C_STD_FILE_PATH,:C_FILE_NAME,:N_STATUS,:C_REMARK,:C_EMP_ID)");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_STD_FILE_TYPE_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STD_FILE_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STD_FILE_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STD_FILE_PATH", OracleDbType.Varchar2,200),
                    new OracleParameter(":C_FILE_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.C_STD_FILE_TYPE_ID;
            parameters[1].Value = model.C_STD_FILE_CODE;
            parameters[2].Value = model.C_STD_FILE_NAME;
            parameters[3].Value = model.C_STD_FILE_PATH;
            parameters[4].Value = model.C_FILE_NAME;
            parameters[5].Value = model.N_STATUS;
            parameters[6].Value = model.C_REMARK;
            parameters[7].Value = model.C_EMP_ID;

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
        public bool Update(Mod_TQB_STD_FILE model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TQB_STD_FILE set ");
            strSql.Append("C_STD_FILE_TYPE_ID=:C_STD_FILE_TYPE_ID,");
            strSql.Append("C_STD_FILE_CODE=:C_STD_FILE_CODE,");
            strSql.Append("C_STD_FILE_NAME=:C_STD_FILE_NAME,");
            strSql.Append("C_STD_FILE_PATH=:C_STD_FILE_PATH,");
            strSql.Append("C_FILE_NAME=:C_FILE_NAME,");
            strSql.Append("N_STATUS=:N_STATUS,");
            strSql.Append("C_REMARK=:C_REMARK,");
            strSql.Append("C_EMP_ID=:C_EMP_ID,");
            strSql.Append("D_MOD_DT=:D_MOD_DT");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_STD_FILE_TYPE_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STD_FILE_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STD_FILE_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STD_FILE_PATH", OracleDbType.Varchar2,200),
                    new OracleParameter(":C_FILE_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.C_STD_FILE_TYPE_ID;
            parameters[1].Value = model.C_STD_FILE_CODE;
            parameters[2].Value = model.C_STD_FILE_NAME;
            parameters[3].Value = model.C_STD_FILE_PATH;
            parameters[4].Value = model.C_FILE_NAME;
            parameters[5].Value = model.N_STATUS;
            parameters[6].Value = model.C_REMARK;
            parameters[7].Value = model.C_EMP_ID;
            parameters[8].Value = model.D_MOD_DT;
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
            strSql.Append("delete from TQB_STD_FILE ");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)          };
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
            strSql.Append("delete from TQB_STD_FILE ");
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
        public Mod_TQB_STD_FILE GetModel(string C_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_STD_FILE_TYPE_ID,C_STD_FILE_CODE,C_STD_FILE_NAME,C_FILE_NAME,N_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT,C_STD_FILE_PATH from TQB_STD_FILE ");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)          };
            parameters[0].Value = C_ID;

            Mod_TQB_STD_FILE model = new Mod_TQB_STD_FILE();
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
        public Mod_TQB_STD_FILE DataRowToModel(DataRow row)
        {
            Mod_TQB_STD_FILE model = new Mod_TQB_STD_FILE();
            if (row != null)
            {
                if (row["C_ID"] != null)
                {
                    model.C_ID = row["C_ID"].ToString();
                }
                if (row["C_STD_FILE_TYPE_ID"] != null)
                {
                    model.C_STD_FILE_TYPE_ID = row["C_STD_FILE_TYPE_ID"].ToString();
                }
                if (row["C_STD_FILE_CODE"] != null)
                {
                    model.C_STD_FILE_CODE = row["C_STD_FILE_CODE"].ToString();
                }
                if (row["C_STD_FILE_NAME"] != null)
                {
                    model.C_STD_FILE_NAME = row["C_STD_FILE_NAME"].ToString();
                }
                if (row["C_FILE_NAME"] != null)
                {
                    model.C_FILE_NAME = row["C_FILE_NAME"].ToString();
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

                if (row["C_STD_FILE_PATH"] != null)
                {
                    model.C_STD_FILE_PATH = row["C_STD_FILE_PATH"].ToString();
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
            strSql.Append("select a.C_ID,a.C_STD_FILE_TYPE_ID,b.c_file_type_name,a.C_STD_FILE_PATH,a.C_STD_FILE_CODE,a.C_STD_FILE_NAME,a.C_FILE_NAME,a.N_STATUS,a.C_REMARK,a.C_EMP_ID,a.D_MOD_DT ");
            strSql.Append("  FROM TQB_STD_FILE a inner join tqb_std_file_type b on a.c_std_file_type_id=b.c_id where a.N_STATUS='1' ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" and " + strWhere);
            }
            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM TQB_STD_FILE ");
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
            strSql.Append(")AS Row, T.*  from TQB_STD_FILE T ");
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
					new OracleParameter(":PageSize", OracleDbType.Number),
					new OracleParameter(":PageIndex", OracleDbType.Number),
					new OracleParameter(":IsReCount", OracleDbType.Clob),
					new OracleParameter(":OrderType", OracleDbType.Clob),
					new OracleParameter(":strWhere", OracleDbType.Varchar2,1000),
					};
			parameters[0].Value = "TQB_STD_FILE";
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

        #endregion  ExtensionMethod
    }
}

