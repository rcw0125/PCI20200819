using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;
namespace DAL
{
    /// <summary>
    /// 数据访问类:TPB_CAST_STOVE
    /// </summary>
    public partial class Dal_TPB_CAST_STOVE
    {
        public Dal_TPB_CAST_STOVE()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string C_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TPB_CAST_STOVE");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)         };
            parameters[0].Value = C_ID;

            return DbHelperOra.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Mod_TPB_CAST_STOVE model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TPB_CAST_STOVE(");
            strSql.Append("C_STL_GRD,C_STD_CODE,N_STOVE_MIN_NUM,N_STOVE_MAX_NUM,C_REMARK,N_STATUS,C_EMP_ID,D_MOD_DT,D_START_DATE,D_END_DATE,N_TARGET_NUM,C_STA_ID)");
            strSql.Append(" values (");
            strSql.Append(":C_STL_GRD,:C_STD_CODE,:N_STOVE_MIN_NUM,:N_STOVE_MAX_NUM,:C_REMARK,:N_STATUS,:C_EMP_ID,:D_MOD_DT,:D_START_DATE,:D_END_DATE,:N_TARGET_NUM,:C_STA_ID)");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_STL_GRD", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STD_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_STOVE_MIN_NUM",OracleDbType.Decimal,3),
                    new OracleParameter(":N_STOVE_MAX_NUM",OracleDbType.Decimal,3),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,200),
                    new OracleParameter(":N_STATUS",OracleDbType.Decimal,1),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":D_START_DATE", OracleDbType.Date),
                    new OracleParameter(":D_END_DATE", OracleDbType.Date),
                    new OracleParameter(":N_TARGET_NUM",OracleDbType.Decimal,3),
                    new OracleParameter(":C_STA_ID", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.C_STL_GRD;
            parameters[1].Value = model.C_STD_CODE;
            parameters[2].Value = model.N_STOVE_MIN_NUM;
            parameters[3].Value = model.N_STOVE_MAX_NUM;
            parameters[4].Value = model.C_REMARK;
            parameters[5].Value = model.N_STATUS;
            parameters[6].Value = model.C_EMP_ID;
            parameters[7].Value = model.D_MOD_DT;
            parameters[8].Value = model.D_START_DATE;
            parameters[9].Value = model.D_END_DATE;
            parameters[10].Value = model.N_TARGET_NUM;
            parameters[11].Value = model.C_STA_ID;

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
        public bool Update(Mod_TPB_CAST_STOVE model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TPB_CAST_STOVE set ");
            strSql.Append("C_STL_GRD=:C_STL_GRD,");
            strSql.Append("C_STD_CODE=:C_STD_CODE,");
            strSql.Append("N_STOVE_MIN_NUM=:N_STOVE_MIN_NUM,");
            strSql.Append("N_STOVE_MAX_NUM=:N_STOVE_MAX_NUM,");
            strSql.Append("C_REMARK=:C_REMARK,");
            strSql.Append("N_STATUS=:N_STATUS,");
            strSql.Append("C_EMP_ID=:C_EMP_ID,");
            strSql.Append("D_MOD_DT=:D_MOD_DT,");
            strSql.Append("D_START_DATE=:D_START_DATE,");
            strSql.Append("D_END_DATE=:D_END_DATE,");
            strSql.Append("N_TARGET_NUM=:N_TARGET_NUM,");
            strSql.Append("C_STA_ID=:C_STA_ID");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_STL_GRD", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STD_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_STOVE_MIN_NUM",OracleDbType.Decimal,3),
                    new OracleParameter(":N_STOVE_MAX_NUM",OracleDbType.Decimal,3),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,200),
                    new OracleParameter(":N_STATUS",OracleDbType.Decimal,1),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":D_START_DATE", OracleDbType.Date),
                    new OracleParameter(":D_END_DATE", OracleDbType.Date),
                    new OracleParameter(":N_TARGET_NUM",OracleDbType.Decimal,3),
                    new OracleParameter(":C_STA_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.C_STL_GRD;
            parameters[1].Value = model.C_STD_CODE;
            parameters[2].Value = model.N_STOVE_MIN_NUM;
            parameters[3].Value = model.N_STOVE_MAX_NUM;
            parameters[4].Value = model.C_REMARK;
            parameters[5].Value = model.N_STATUS;
            parameters[6].Value = model.C_EMP_ID;
            parameters[7].Value = model.D_MOD_DT;
            parameters[8].Value = model.D_START_DATE;
            parameters[9].Value = model.D_END_DATE;
            parameters[10].Value = model.N_TARGET_NUM;
            parameters[11].Value = model.C_STA_ID;
            parameters[12].Value = model.C_ID;

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
            strSql.Append("delete from TPB_CAST_STOVE ");
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
            strSql.Append("delete from TPB_CAST_STOVE ");
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
        public Mod_TPB_CAST_STOVE GetModel(string C_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_STL_GRD,C_STD_CODE,N_STOVE_MIN_NUM,N_STOVE_MAX_NUM,C_REMARK,N_STATUS,C_EMP_ID,D_MOD_DT,D_START_DATE,D_END_DATE,N_TARGET_NUM,C_STA_ID from TPB_CAST_STOVE ");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)         };
            parameters[0].Value = C_ID;

            Mod_TPB_CAST_STOVE model = new Mod_TPB_CAST_STOVE();
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
        public Mod_TPB_CAST_STOVE DataRowToModel(DataRow row)
        {
            Mod_TPB_CAST_STOVE model = new Mod_TPB_CAST_STOVE();
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
                if (row["N_STOVE_MIN_NUM"] != null && row["N_STOVE_MIN_NUM"].ToString() != "")
                {
                    model.N_STOVE_MIN_NUM = decimal.Parse(row["N_STOVE_MIN_NUM"].ToString());
                }
                if (row["N_STOVE_MAX_NUM"] != null && row["N_STOVE_MAX_NUM"].ToString() != "")
                {
                    model.N_STOVE_MAX_NUM = decimal.Parse(row["N_STOVE_MAX_NUM"].ToString());
                }
                if (row["C_REMARK"] != null)
                {
                    model.C_REMARK = row["C_REMARK"].ToString();
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
                if (row["D_START_DATE"] != null && row["D_START_DATE"].ToString() != "")
                {
                    model.D_START_DATE = DateTime.Parse(row["D_START_DATE"].ToString());
                }
                if (row["D_END_DATE"] != null && row["D_END_DATE"].ToString() != "")
                {
                    model.D_END_DATE = DateTime.Parse(row["D_END_DATE"].ToString());
                }
                if (row["N_TARGET_NUM"] != null && row["N_TARGET_NUM"].ToString() != "")
                {
                    model.N_TARGET_NUM = decimal.Parse(row["N_TARGET_NUM"].ToString());
                }
                if (row["C_STA_ID"] != null)
                {
                    model.C_STA_ID = row["C_STA_ID"].ToString();
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
            strSql.Append("select C_ID,C_STL_GRD,C_STD_CODE,N_STOVE_MIN_NUM,N_STOVE_MAX_NUM,C_REMARK,N_STATUS,C_EMP_ID,D_MOD_DT,D_START_DATE,D_END_DATE,N_TARGET_NUM,C_STA_ID ");
            strSql.Append(" FROM TPB_CAST_STOVE ");
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
            strSql.Append("select count(1) FROM TPB_CAST_STOVE ");
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
            strSql.Append(")AS Row, T.*  from TPB_CAST_STOVE T ");
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
        /// 显示列表
        /// </summary>
        /// <returns></returns>
        public DataSet LSGetList()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1), '' as N_STOVE_MIN_NUM,'' as N_STOVE_MAX_NUM from TPB_CAST_STOVE");
            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 是否存在相同数据
        /// </summary>
        public bool ExistsDate(string C_STL_GRD, string C_STD_CODE, string C_STA_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TPB_CAST_STOVE where N_STATUS=1 ");
            strSql.Append(" and C_STA_ID=:C_STA_ID  ");
            strSql.Append(" and C_STL_GRD=:C_STL_GRD  ");
            strSql.Append(" and C_STD_CODE=:C_STD_CODE  ");
            OracleParameter[] parameters = {
                 new OracleParameter(":C_STA_ID", OracleDbType.Varchar2,100),
            new OracleParameter(":C_STL_GRD", OracleDbType.Varchar2,100),
            new OracleParameter(":C_STD_CODE", OracleDbType.Varchar2,100)
            };
            parameters[0].Value = C_STA_ID;
            parameters[1].Value = C_STL_GRD;
            parameters[2].Value = C_STD_CODE;
            return DbHelperOra.Exists(strSql.ToString(), parameters);
        }
        /// <summary>
        /// 查询数据列表
        /// </summary>
        public DataSet GetList(int status, string C_STL_GRD, string C_STD_CODE, string C_STA_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_STL_GRD,C_STD_CODE,N_STOVE_MIN_NUM,N_STOVE_MAX_NUM,C_REMARK,DECODE(N_STATUS,1,'启用','停用') N_STATUS,C_EMP_ID,D_MOD_DT,D_START_DATE,D_END_DATE,C_STA_ID,N_TARGET_NUM");
            strSql.Append(" FROM TPB_CAST_STOVE where N_STATUS='" + status + "'");
            if (C_STL_GRD.Trim() != "")
            {
                strSql.Append(" and C_STL_GRD LIKE '%" + C_STL_GRD + "%' ");
            }
            if (C_STD_CODE.Trim() != "")
            {
                strSql.Append(" and C_STD_CODE LIKE '%" + C_STD_CODE + "%' ");
            }
            if (C_STA_ID.Trim() != "")
            {
                strSql.Append(" and C_STA_ID = '" + C_STA_ID + "' ");
            }
            strSql.Append(" ORDER BY C_STL_GRD,C_STD_CODE");

            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取浇次炉数
        /// </summary>
        /// <param name="C_STA_ID"></param>
        /// <param name="C_STL_GRD"></param>
        /// <param name="C_STD_CODE"></param>
        /// <returns></returns>
        public DataSet GetList(string C_STA_ID, string C_STL_GRD, string C_STD_CODE)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select max(N_TARGET_NUM)as N_STOVE_NUM ");
            strSql.Append(" FROM TPB_CAST_STOVE t where N_STATUS=1 and C_STA_ID='" + C_STA_ID + "' and C_STL_GRD='" + C_STL_GRD + "' and C_STD_CODE='" + C_STD_CODE + "' ");

            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取浇次炉数
        /// </summary>
        /// <param name="C_STA_ID"></param>
        /// <param name="C_STL_GRD"></param>
        /// <param name="C_STD_CODE"></param>
        /// <returns></returns>
        public DataSet GetZJCList(string C_STA_ID, string C_STL_GRD, string C_STD_CODE)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * ");
            strSql.Append(" FROM TPB_CAST_STOVE t where N_STATUS=1 and C_STA_ID='" + C_STA_ID + "' and C_STL_GRD='" + C_STL_GRD + "' and C_STD_CODE='" + C_STD_CODE + "' ");

            return DbHelperOra.Query(strSql.ToString());
        }


        #endregion  ExtensionMethod
    }
}

