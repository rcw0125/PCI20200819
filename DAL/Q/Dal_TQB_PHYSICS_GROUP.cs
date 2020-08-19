using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;
namespace DAL
{
    /// <summary>
    /// 数据访问类:TQB_PHYSICS_GROUP
    /// </summary>
    public partial class Dal_TQB_PHYSICS_GROUP
    {
        public Dal_TQB_PHYSICS_GROUP()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string C_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TQB_PHYSICS_GROUP");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)         };
            parameters[0].Value = C_ID;

            return DbHelperOra.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Mod_TQB_PHYSICS_GROUP model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TQB_PHYSICS_GROUP(");
            strSql.Append("C_CODE,C_NAME,C_CHECK_DEPMT,N_STATUS,C_REMARK,C_EMP_ID)");
            strSql.Append(" values (");
            strSql.Append(":C_CODE,:C_NAME,:C_CHECK_DEPMT,:N_STATUS,:C_REMARK,:C_EMP_ID)");
            OracleParameter[] parameters = {

                    new OracleParameter(":C_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CHECK_DEPMT", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100)};

            parameters[0].Value = model.C_CODE;
            parameters[1].Value = model.C_NAME;
            parameters[2].Value = model.C_CHECK_DEPMT;
            parameters[3].Value = model.N_STATUS;
            parameters[4].Value = model.C_REMARK;
            parameters[5].Value = model.C_EMP_ID;

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
        public bool Update(Mod_TQB_PHYSICS_GROUP model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TQB_PHYSICS_GROUP set ");
            strSql.Append("C_CODE=:C_CODE,");
            strSql.Append("C_NAME=:C_NAME,");
            strSql.Append("C_CHECK_DEPMT=:C_CHECK_DEPMT,");
            strSql.Append("N_STATUS=:N_STATUS,");
            strSql.Append("C_REMARK=:C_REMARK,");
            strSql.Append("C_EMP_ID=:C_EMP_ID,");
            strSql.Append("D_MOD_DT=:D_MOD_DT");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CHECK_DEPMT", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.C_CODE;
            parameters[1].Value = model.C_NAME;
            parameters[2].Value = model.C_CHECK_DEPMT;
            parameters[3].Value = model.N_STATUS;
            parameters[4].Value = model.C_REMARK;
            parameters[5].Value = model.C_EMP_ID;
            parameters[6].Value = model.D_MOD_DT;
            parameters[7].Value = model.C_ID;

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
            strSql.Append("delete from TQB_PHYSICS_GROUP ");
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
            strSql.Append("delete from TQB_PHYSICS_GROUP ");
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
        public Mod_TQB_PHYSICS_GROUP GetModel(string C_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_CODE,C_NAME,C_CHECK_DEPMT,N_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT from TQB_PHYSICS_GROUP ");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)         };
            parameters[0].Value = C_ID;

            Mod_TQB_PHYSICS_GROUP model = new Mod_TQB_PHYSICS_GROUP();
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
        public Mod_TQB_PHYSICS_GROUP DataRowToModel(DataRow row)
        {
            Mod_TQB_PHYSICS_GROUP model = new Mod_TQB_PHYSICS_GROUP();
            if (row != null)
            {
                if (row["C_ID"] != null)
                {
                    model.C_ID = row["C_ID"].ToString();
                }
                if (row["C_CODE"] != null)
                {
                    model.C_CODE = row["C_CODE"].ToString();
                }
                if (row["C_NAME"] != null)
                {
                    model.C_NAME = row["C_NAME"].ToString();
                }
                if (row["C_CHECK_DEPMT"] != null)
                {
                    model.C_CHECK_DEPMT = row["C_CHECK_DEPMT"].ToString();
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
            }
            return model;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_CODE,C_NAME,C_CHECK_DEPMT,N_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT ");
            strSql.Append(" FROM TQB_PHYSICS_GROUP where N_STATUS='1' ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" AND C_NAME like '%" + strWhere + "%' ");
            }
            strSql.Append(" order by c_code");
            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 获得数据列表-项目代码
        /// </summary>
        /// <param name="C_CODE">项目代码</param>
        /// <returns></returns>
		public DataSet GetList_Code(string C_CODE)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_CODE,C_NAME,C_CHECK_DEPMT,N_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT ");
            strSql.Append(" FROM TQB_PHYSICS_GROUP where N_STATUS='1'  ");
            if (C_CODE.Trim() != "")
            {
                strSql.Append(" and C_CODE = '" + C_CODE + "' ");
            }
            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM TQB_PHYSICS_GROUP ");
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
            strSql.Append(")AS Row, T.*  from TQB_PHYSICS_GROUP T ");
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
        public DataSet Get_XN_List(string C_CHECK_DEPMT)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_CODE,C_NAME,C_CHECK_DEPMT,N_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT ");
            strSql.Append(" FROM TQB_PHYSICS_GROUP where N_STATUS='1' ");
            if (!string.IsNullOrEmpty(C_CHECK_DEPMT))
            {
                strSql.Append(" AND C_CHECK_DEPMT = '" + C_CHECK_DEPMT + "' ");
            }

            strSql.Append(" order by c_code");

            return DbHelperOra.Query(strSql.ToString());
        }

        #endregion  BasicMethod
        #region  ExtensionMethod
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList_Name(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_CODE,C_NAME,C_CHECK_DEPMT,N_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT ");
            strSql.Append(" FROM TQB_PHYSICS_GROUP where N_STATUS='1' ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" AND C_NAME = '" + strWhere + "' ");
            }

            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList_Not_Name(string Name)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_CODE,C_NAME,C_CHECK_DEPMT,N_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT ");
            strSql.Append(" FROM TQB_PHYSICS_GROUP where N_STATUS='1' ");
            if (Name.Trim() != "")
            {
                strSql.Append("  and C_NAME = '" + Name + "'  and C_NAME not in (select ta.C_NAME  from TQB_PHYSICS_GROUP ta where  ta.C_NAME not in ('" + Name + "'))");
            }

            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList_Max()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" select max( to_number（ substr(C_CODE,2))) as code ");
            strSql.Append(" FROM TQB_PHYSICS_GROUP where N_STATUS='1' ");

            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取物理性能ID
        /// </summary>
        public string Get_ID(string c_code)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select max(t.c_id) from TQB_PHYSICS_GROUP t where t.c_code='" + c_code + "' and t.n_status=1 ");

            object obj = DbHelperOra.GetSingle(strSql.ToString());
            if (obj == null)
            {
                return "0";
            }
            else
            {
                return obj.ToString();
            }
        }

        /// <summary>
        /// 获取物理性能Code
        /// </summary>
        public string Get_Code(string c_id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select max(t.c_code) from TQB_PHYSICS_GROUP t where t.c_id='" + c_id + "' and t.n_status=1 ");

            object obj = DbHelperOra.GetSingle(strSql.ToString());
            if (obj == null)
            {
                return "0";
            }
            else
            {
                return obj.ToString();
            }
        }

        /// <summary>
        /// 获取物理性能名称
        /// </summary>
        public string Get_Name(string c_code)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select max(t.C_NAME) from TQB_PHYSICS_GROUP t where t.c_code='" + c_code + "' and t.n_status=1 ");

            object obj = DbHelperOra.GetSingle(strSql.ToString());
            if (obj == null)
            {
                return "0";
            }
            else
            {
                return obj.ToString();
            }
        }

        #endregion  ExtensionMethod
    }
}

