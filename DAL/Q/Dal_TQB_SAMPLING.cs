using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;

namespace DAL
{
    /// <summary>
    /// 数据访问类:TQB_SAMPLING
    /// </summary>
    public partial class Dal_TQB_SAMPLING
    {
        public Dal_TQB_SAMPLING()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string C_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TQB_SAMPLING");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)          };
            parameters[0].Value = C_ID;

            return DbHelperOra.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Mod_TQB_SAMPLING model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TQB_SAMPLING(");
            strSql.Append("C_SAMPLING_CODE,C_SAMPLING_NAME,N_STATUS,C_REMARK,C_EMP_ID,N_SAMPLING_SN,C_CHECK_DEPMT)");
            strSql.Append(" values (");
            strSql.Append(":C_SAMPLING_CODE,:C_SAMPLING_NAME,:N_STATUS,:C_REMARK,:C_EMP_ID,:N_SAMPLING_SN,:C_CHECK_DEPMT)");
            OracleParameter[] parameters = {

                    new OracleParameter(":C_SAMPLING_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SAMPLING_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_SAMPLING_SN", OracleDbType.Decimal,1),
                    new OracleParameter(":C_CHECK_DEPMT", OracleDbType.Varchar2,100)};

            parameters[0].Value = model.C_SAMPLING_CODE;
            parameters[1].Value = model.C_SAMPLING_NAME;
            parameters[2].Value = model.N_STATUS;
            parameters[3].Value = model.C_REMARK;
            parameters[4].Value = model.C_EMP_ID;
            parameters[5].Value = model.N_SAMPLING_SN;
            parameters[6].Value = model.C_CHECK_DEPMT;
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
        public bool Update(Mod_TQB_SAMPLING model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TQB_SAMPLING set ");
            strSql.Append("C_SAMPLING_CODE=:C_SAMPLING_CODE,");
            strSql.Append("C_SAMPLING_NAME=:C_SAMPLING_NAME,");
            strSql.Append("N_STATUS=:N_STATUS,");
            strSql.Append("C_REMARK=:C_REMARK,");
            strSql.Append("C_EMP_ID=:C_EMP_ID,");
            strSql.Append("D_MOD_DT=:D_MOD_DT,");
            strSql.Append("N_SAMPLING_SN=:N_SAMPLING_SN,");
            strSql.Append("C_CHECK_DEPMT=:C_CHECK_DEPMT");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_SAMPLING_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SAMPLING_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":N_SAMPLING_SN", OracleDbType.Decimal,1),
                    new OracleParameter(":C_CHECK_DEPMT", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.C_SAMPLING_CODE;
            parameters[1].Value = model.C_SAMPLING_NAME;
            parameters[2].Value = model.N_STATUS;
            parameters[3].Value = model.C_REMARK;
            parameters[4].Value = model.C_EMP_ID;
            parameters[5].Value = model.D_MOD_DT;
            parameters[6].Value = model.N_SAMPLING_SN;
            parameters[7].Value = model.C_CHECK_DEPMT;
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
        /// 删除一条数据
        /// </summary>
        public bool Delete(string C_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from TQB_SAMPLING ");
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
            strSql.Append("delete from TQB_SAMPLING ");
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
        public Mod_TQB_SAMPLING GetModel(string C_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_SAMPLING_CODE,C_SAMPLING_NAME,N_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT,N_SAMPLING_SN,C_CHECK_DEPMT from TQB_SAMPLING ");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)          };
            parameters[0].Value = C_ID;

            Mod_TQB_SAMPLING model = new Mod_TQB_SAMPLING();
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
        public Mod_TQB_SAMPLING DataRowToModel(DataRow row)
        {
            Mod_TQB_SAMPLING model = new Mod_TQB_SAMPLING();
            if (row != null)
            {
                if (row["C_ID"] != null)
                {
                    model.C_ID = row["C_ID"].ToString();
                }
                if (row["C_SAMPLING_CODE"] != null)
                {
                    model.C_SAMPLING_CODE = row["C_SAMPLING_CODE"].ToString();
                }
                if (row["C_SAMPLING_NAME"] != null)
                {
                    model.C_SAMPLING_NAME = row["C_SAMPLING_NAME"].ToString();
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
                if (row["N_SAMPLING_SN"] != null && row["N_SAMPLING_SN"].ToString() != "")
                {
                    model.N_SAMPLING_SN = decimal.Parse(row["N_SAMPLING_SN"].ToString());
                }
                if (row["C_CHECK_DEPMT"] != null)
                {
                    model.C_CHECK_DEPMT = row["C_CHECK_DEPMT"].ToString();
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
            strSql.Append("select C_ID,C_SAMPLING_CODE,C_SAMPLING_NAME,N_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT,N_SAMPLING_SN,C_CHECK_DEPMT ");
            strSql.Append(" FROM TQB_SAMPLING  where N_STATUS=1 ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" and " + strWhere);
            }
            strSql.Append(" order by N_SAMPLING_SN ");
            return DbHelperOra.Query(strSql.ToString());
        }


        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList_CODE(string strWhere, string C_SAMPLING_NAME)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_SAMPLING_CODE,C_SAMPLING_NAME,N_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT,N_SAMPLING_SN,C_CHECK_DEPMT ");
            strSql.Append(" FROM TQB_SAMPLING  where N_STATUS=1 ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" and  C_SAMPLING_CODE not in (" + strWhere + ") ");
            }
            if (C_SAMPLING_NAME.Trim() != "")
            {
                strSql.Append(" and C_SAMPLING_NAME like '%" + C_SAMPLING_NAME + "%' ");
            }
            strSql.Append(" order by C_SAMPLING_CODE ");
            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得数据列表-项目名称
        /// </summary>
        public DataSet GetList_Query(string C_SAMPLING_NAME)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_SAMPLING_CODE,C_SAMPLING_NAME,N_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT,N_SAMPLING_SN,C_CHECK_DEPMT ");
            strSql.Append(" FROM TQB_SAMPLING  where N_STATUS=1 ");
            if (C_SAMPLING_NAME.Trim() != "")
            {
                strSql.Append(" and C_SAMPLING_NAME like '%" + C_SAMPLING_NAME + "%'");
            }
            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 获取取样名称主键ID
        /// </summary>
        /// <param name="SampName">取样名称</param>
        /// <returns></returns>
		public string GetSampId(string SampName, string c_check_depmt)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select max(C_ID) FROM TQB_SAMPLING where 1=1 and N_STATUS=1 ");
            if (!string.IsNullOrEmpty(SampName.Trim()))
            {
                strSql.Append(" and C_SAMPLING_NAME= '" + SampName + "'  ");
            }

            if (!string.IsNullOrEmpty(c_check_depmt.Trim()))
            {
                strSql.Append(" and c_check_depmt='" + c_check_depmt + "'  ");
            }


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
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM TQB_SAMPLING ");
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
            strSql.Append(")AS Row, T.*  from TQB_SAMPLING T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet Get_JSZX(string strSamplesName)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_SAMPLING_CODE,C_SAMPLING_NAME,N_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT,N_SAMPLING_SN,C_CHECK_DEPMT ");
            strSql.Append(" FROM TQB_SAMPLING  where N_STATUS=1 and C_SAMPLING_NAME in (" + strSamplesName + ")");

            return DbHelperOra.Query(strSql.ToString());
        }


        /// <summary>
        /// 获取制样信息列名
        /// </summary>
        public DataSet GetList_Item()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT T.C_SAMPLING_NAME, T.C_ID FROM TQB_SAMPLING T WHERE T.N_STATUS = 1 AND T.C_CHECK_DEPMT = '质控部' ORDER BY T.N_SAMPLING_SN ");

            return DbHelperOra.Query(strSql.ToString());
        }

        #endregion  BasicMethod
        #region  ExtensionMethod
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList_Max(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select max( to_number（ substr(C_SAMPLING_CODE,2))) as max,max(N_SAMPLING_SN) as ord ");
            strSql.Append(" FROM TQB_SAMPLING where N_STATUS=1 ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" and " + strWhere);
            }
            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList_Not_Name(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" select C_ID,C_SAMPLING_CODE,C_SAMPLING_NAME,N_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT,N_SAMPLING_SN,C_CHECK_DEPMT ");
            strSql.Append(" FROM TQB_SAMPLING where N_STATUS='1' ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" and C_SAMPLING_NAME='" + strWhere + "' and C_SAMPLING_NAME  not in( select ta.C_SAMPLING_NAME  from TQB_SAMPLING ta where  ta.C_SAMPLING_NAME   in ('" + strWhere + "'))");
            }
            return DbHelperOra.Query(strSql.ToString());
        }
        #endregion  ExtensionMethod
    }
}

