using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;

namespace DAL
{
    /// <summary>
    /// 数据访问类:TQB_PHYSICS_GROUP_STD
    /// </summary>
    public partial class Dal_TQB_PHYSICS_GROUP_STD
    {
        public Dal_TQB_PHYSICS_GROUP_STD()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string C_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TQB_PHYSICS_GROUP_STD");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)         };
            parameters[0].Value = C_ID;

            return DbHelperOra.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Mod_TQB_PHYSICS_GROUP_STD model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TQB_PHYSICS_GROUP_STD(");
            strSql.Append("C_PHYSICS_CODE,C_PHYSICS_NAME,C_STL_GRD,C_STD_CODE,N_STATUS,C_REMARK,C_EMP_ID)");
            strSql.Append(" values (");
            strSql.Append(":C_PHYSICS_CODE,:C_PHYSICS_NAME,:C_STL_GRD,:C_STD_CODE,:N_STATUS,:C_REMARK,:C_EMP_ID)");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_PHYSICS_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PHYSICS_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STL_GRD", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STD_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_STATUS", OracleDbType.Int32,1),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.C_PHYSICS_CODE;
            parameters[1].Value = model.C_PHYSICS_NAME;
            parameters[2].Value = model.C_STL_GRD;
            parameters[3].Value = model.C_STD_CODE;
            parameters[4].Value = model.N_STATUS;
            parameters[5].Value = model.C_REMARK;
            parameters[6].Value = model.C_EMP_ID;

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
        public bool Update(Mod_TQB_PHYSICS_GROUP_STD model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TQB_PHYSICS_GROUP_STD set ");
            strSql.Append("C_PHYSICS_CODE=:C_PHYSICS_CODE,");
            strSql.Append("C_PHYSICS_NAME=:C_PHYSICS_NAME,");
            strSql.Append("C_STL_GRD=:C_STL_GRD,");
            strSql.Append("C_STD_CODE=:C_STD_CODE,");
            strSql.Append("N_STATUS=:N_STATUS,");
            strSql.Append("C_REMARK=:C_REMARK,");
            strSql.Append("C_EMP_ID=:C_EMP_ID,");
            strSql.Append("D_MOD_DT=:D_MOD_DT");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_PHYSICS_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PHYSICS_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STL_GRD", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STD_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_STATUS", OracleDbType.Int32,1),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.C_PHYSICS_CODE;
            parameters[1].Value = model.C_PHYSICS_NAME;
            parameters[2].Value = model.C_STL_GRD;
            parameters[3].Value = model.C_STD_CODE;
            parameters[4].Value = model.N_STATUS;
            parameters[5].Value = model.C_REMARK;
            parameters[6].Value = model.C_EMP_ID;
            parameters[7].Value = model.D_MOD_DT;
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
            strSql.Append("delete from TQB_PHYSICS_GROUP_STD ");
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
            strSql.Append("delete from TQB_PHYSICS_GROUP_STD ");
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
        public Mod_TQB_PHYSICS_GROUP_STD GetModel(string C_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_PHYSICS_CODE,C_PHYSICS_NAME,C_STL_GRD,C_STD_CODE,N_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT from TQB_PHYSICS_GROUP_STD ");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)         };
            parameters[0].Value = C_ID;

            Mod_TQB_PHYSICS_GROUP_STD model = new Mod_TQB_PHYSICS_GROUP_STD();
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
        public Mod_TQB_PHYSICS_GROUP_STD GetModel(string C_PHYSICS_CODE, string C_STD_CODE, string C_STL_GRD)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_PHYSICS_CODE,C_PHYSICS_NAME,C_STL_GRD,C_STD_CODE,N_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT from TQB_PHYSICS_GROUP_STD ");
            strSql.Append(" where C_PHYSICS_CODE=:C_PHYSICS_CODE and C_STD_CODE=:C_STD_CODE and C_STL_GRD=:C_STL_GRD ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_PHYSICS_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STD_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STL_GRD", OracleDbType.Varchar2,100)};
            parameters[0].Value = C_PHYSICS_CODE;
            parameters[0].Value = C_STD_CODE;
            parameters[0].Value = C_STL_GRD;

            Mod_TQB_PHYSICS_GROUP_STD model = new Mod_TQB_PHYSICS_GROUP_STD();
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
        public Mod_TQB_PHYSICS_GROUP_STD DataRowToModel(DataRow row)
        {
            Mod_TQB_PHYSICS_GROUP_STD model = new Mod_TQB_PHYSICS_GROUP_STD();
            if (row != null)
            {
                if (row["C_ID"] != null)
                {
                    model.C_ID = row["C_ID"].ToString();
                }
                if (row["C_PHYSICS_CODE"] != null)
                {
                    model.C_PHYSICS_CODE = row["C_PHYSICS_CODE"].ToString();
                }
                if (row["C_PHYSICS_NAME"] != null)
                {
                    model.C_PHYSICS_NAME = row["C_PHYSICS_NAME"].ToString();
                }
                if (row["C_STL_GRD"] != null)
                {
                    model.C_STL_GRD = row["C_STL_GRD"].ToString();
                }
                if (row["C_STD_CODE"] != null)
                {
                    model.C_STD_CODE = row["C_STD_CODE"].ToString();
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
            strSql.Append("select C_ID,C_PHYSICS_CODE,C_PHYSICS_NAME,C_STL_GRD,C_STD_CODE,N_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT ");
            strSql.Append(" FROM TQB_PHYSICS_GROUP_STD ");
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
            strSql.Append("select count(1) FROM TQB_PHYSICS_GROUP_STD ");
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
            strSql.Append(")AS Row, T.*  from TQB_PHYSICS_GROUP_STD T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取列表信息
        /// </summary>
        /// <param name="C_PHYSICS_CODE">物理性能分组代码</param>
        /// <returns></returns>
        public DataSet Get_List(string C_PHYSICS_CODE)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_PHYSICS_CODE,C_PHYSICS_NAME,C_STL_GRD,C_STD_CODE,N_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT FROM TQB_PHYSICS_GROUP_STD where N_STATUS=1 ");

            if (!string.IsNullOrEmpty(C_PHYSICS_CODE.Trim()))
            {
                strSql.Append(" and  C_PHYSICS_CODE='" + C_PHYSICS_CODE + "' ");
            }

            return DbHelperOra.Query(strSql.ToString());
        }

        #endregion  BasicMethod

    }
}

