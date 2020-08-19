using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;

namespace DAL
{
    /// <summary>
    /// 数据访问类:TQB_RINSE_TANK_GRD
    /// </summary>
    public partial class Dal_TQB_RINSE_TANK_GRD
    {
        public Dal_TQB_RINSE_TANK_GRD()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string C_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TQB_RINSE_TANK_GRD");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)         };
            parameters[0].Value = C_ID;

            return DbHelperOra.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Mod_TQB_RINSE_TANK_GRD model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TQB_RINSE_TANK_GRD(");
            strSql.Append("N_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT,C_STD_CODE,C_STL_GRD)");
            strSql.Append(" values (");
            strSql.Append(":N_STATUS,:C_REMARK,:C_EMP_ID,:D_MOD_DT,:C_STD_CODE,:C_STL_GRD)");
            OracleParameter[] parameters = {
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":C_STD_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STL_GRD", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.N_STATUS;
            parameters[1].Value = model.C_REMARK;
            parameters[2].Value = model.C_EMP_ID;
            parameters[3].Value = model.D_MOD_DT;
            parameters[4].Value = model.C_STD_CODE;
            parameters[5].Value = model.C_STL_GRD;

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
        public bool Update(Mod_TQB_RINSE_TANK_GRD model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TQB_RINSE_TANK_GRD set ");
            strSql.Append("N_STATUS=:N_STATUS,");
            strSql.Append("C_REMARK=:C_REMARK,");
            strSql.Append("C_EMP_ID=:C_EMP_ID,");
            strSql.Append("D_MOD_DT=:D_MOD_DT,");
            strSql.Append("C_STD_CODE=:C_STD_CODE,");
            strSql.Append("C_STL_GRD=:C_STL_GRD");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":C_STD_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STL_GRD", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.N_STATUS;
            parameters[1].Value = model.C_REMARK;
            parameters[2].Value = model.C_EMP_ID;
            parameters[3].Value = model.D_MOD_DT;
            parameters[4].Value = model.C_STD_CODE;
            parameters[5].Value = model.C_STL_GRD;
            parameters[6].Value = model.C_ID;

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
            strSql.Append("delete from TQB_RINSE_TANK_GRD ");
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
            strSql.Append("delete from TQB_RINSE_TANK_GRD ");
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
        public Mod_TQB_RINSE_TANK_GRD GetModel(string C_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,N_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT,C_STD_CODE,C_STL_GRD from TQB_RINSE_TANK_GRD ");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)         };
            parameters[0].Value = C_ID;

            Mod_TQB_RINSE_TANK_GRD model = new Mod_TQB_RINSE_TANK_GRD();
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
        public Mod_TQB_RINSE_TANK_GRD DataRowToModel(DataRow row)
        {
            Mod_TQB_RINSE_TANK_GRD model = new Mod_TQB_RINSE_TANK_GRD();
            if (row != null)
            {
                if (row["C_ID"] != null)
                {
                    model.C_ID = row["C_ID"].ToString();
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
                if (row["C_STD_CODE"] != null)
                {
                    model.C_STD_CODE = row["C_STD_CODE"].ToString();
                }
                if (row["C_STL_GRD"] != null)
                {
                    model.C_STL_GRD = row["C_STL_GRD"].ToString();
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
            strSql.Append("select C_ID,N_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT,C_STD_CODE,C_STL_GRD ");
            strSql.Append(" FROM TQB_RINSE_TANK_GRD ");
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
            strSql.Append("select count(1) FROM TQB_RINSE_TANK_GRD ");
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
            strSql.Append(")AS Row, T.*  from TQB_RINSE_TANK_GRD T ");
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
        /// 获得数据列表
        /// </summary>
        /// <param name="std">执行标准</param>
        /// <param name="grd">钢种</param>
        /// <returns></returns>
        public DataSet Query(string std, string grd)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select a.C_ID,a.N_STATUS,a.C_REMARK,a.C_EMP_ID,a.D_MOD_DT,a.c_std_code,a.c_stl_grd ");
            strSql.Append(" FROM TQB_RINSE_TANK_GRD a inner join  tqb_std_main b on a.c_std_code=b.c_std_code and a.c_stl_grd=b.c_stl_grd  where a.n_status=1 and b.n_status=1 AND b.N_IS_CHECK=1 ");
            if (!string.IsNullOrEmpty(std))
            {
                strSql.Append(" and b.c_std_code like '%" + std + "%'");
            }
            if (!string.IsNullOrEmpty(grd))
            {
                strSql.Append(" and b.c_stl_grd like '%" + grd + "%'");
            }
            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 查询可以洗槽的钢种
        /// </summary>
        /// <param name="C_STL_GRD"></param>
        /// <param name="C_STD_CODE"></param>
        /// <returns>洗槽的钢种信息</returns>
        public DataSet GetXCGZ(string C_STL_GRD, string C_STD_CODE)
        {
            string strSql = " SELECT A.C_ID, A.N_STATUS,  A.C_REMARK,  A.C_EMP_ID, A.D_MOD_DT, a.C_STD_CODE,  A.C_STL_GRD  FROM TQB_RINSE_TANK_GRD A inner join  tqb_std_main b on a.c_std_code=b.c_std_code and a.c_stl_grd=b.c_stl_grd  where a.n_status=1 and b.n_status=1 ";
            if (C_STL_GRD.Trim() != "")
            {
                strSql = strSql + "  AND A.C_STL_GRD='" + C_STL_GRD + "' ";
            }

            if (C_STD_CODE.Trim() != "")
            {
                strSql = strSql + " AND A.C_STD_CODE ='" + C_STD_CODE + "' ";
            }
            return DbHelperOra.Query(strSql.ToString());

        }
        #endregion  ExtensionMethod
    }
}




