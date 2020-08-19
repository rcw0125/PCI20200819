using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;
namespace DAL
{
    /// <summary>
    /// 数据访问类:TQB_STD_SPEC
    /// </summary>
    public partial class Dal_TQB_STD_SPEC
    {
        public Dal_TQB_STD_SPEC()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string C_STD_MAIN_ID, string C_SPEC)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TQB_STD_SPEC");
            strSql.Append(" where C_STD_MAIN_ID='" + C_STD_MAIN_ID + "' and C_SPEC='" + C_SPEC + "' ");

            return DbHelperOra.Exists(strSql.ToString());
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Mod_TQB_STD_SPEC model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TQB_STD_SPEC(");
            strSql.Append("C_STD_MAIN_ID,C_SPEC,N_STATUS,C_REMARK,C_EMP_ID)");
            strSql.Append(" values (");
            strSql.Append(":C_STD_MAIN_ID,:C_SPEC,:N_STATUS,:C_REMARK,:C_EMP_ID)");
            OracleParameter[] parameters = {

                    new OracleParameter(":C_STD_MAIN_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SPEC", OracleDbType.Varchar2,500),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100)};

            parameters[0].Value = model.C_STD_MAIN_ID;
            parameters[1].Value = model.C_SPEC;
            parameters[2].Value = model.N_STATUS;
            parameters[3].Value = model.C_REMARK;
            parameters[4].Value = model.C_EMP_ID;

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
        public bool Update(Mod_TQB_STD_SPEC model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TQB_STD_SPEC set ");
            strSql.Append("C_STD_MAIN_ID=:C_STD_MAIN_ID,");
            strSql.Append("C_SPEC=:C_SPEC,");
            strSql.Append("N_STATUS=:N_STATUS,");
            strSql.Append("C_REMARK=:C_REMARK,");
            strSql.Append("C_EMP_ID=:C_EMP_ID,");
            strSql.Append("D_MOD_DT=:D_MOD_DT");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_STD_MAIN_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SPEC", OracleDbType.Varchar2,500),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.C_STD_MAIN_ID;
            parameters[1].Value = model.C_SPEC;
            parameters[2].Value = model.N_STATUS;
            parameters[3].Value = model.C_REMARK;
            parameters[4].Value = model.C_EMP_ID;
            parameters[5].Value = model.D_MOD_DT;
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
            strSql.Append("delete from TQB_STD_SPEC ");
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
            strSql.Append("delete from TQB_STD_SPEC ");
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
        public Mod_TQB_STD_SPEC GetModel(string C_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_STD_MAIN_ID,C_SPEC,N_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT from TQB_STD_SPEC ");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)          };
            parameters[0].Value = C_ID;

            Mod_TQB_STD_SPEC model = new Mod_TQB_STD_SPEC();
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
        public Mod_TQB_STD_SPEC DataRowToModel(DataRow row)
        {
            Mod_TQB_STD_SPEC model = new Mod_TQB_STD_SPEC();
            if (row != null)
            {
                if (row["C_ID"] != null)
                {
                    model.C_ID = row["C_ID"].ToString();
                }
                if (row["C_STD_MAIN_ID"] != null)
                {
                    model.C_STD_MAIN_ID = row["C_STD_MAIN_ID"].ToString();
                }
                if (row["C_SPEC"] != null)
                {
                    model.C_SPEC = row["C_SPEC"].ToString();
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
            strSql.Append("select a.C_ID,a.C_STD_MAIN_ID,b.c_stl_grd,a.C_SPEC,a.N_STATUS,a.C_REMARK,a.C_EMP_ID,a.D_MOD_DT ");
            strSql.Append(" FROM TQB_STD_SPEC a inner join tqb_std_main b on a.c_std_main_id=b.c_id WHERE a.N_STATUS='1' ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" AND " + strWhere);
            }
            strSql.Append("  order by to_number(substr(a.C_SPEC,2))  ");
            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得所有规格
        /// </summary>
        public DataSet GetSPECList()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select DISTINCT C_SPEC");
            strSql.Append(" FROM TQB_STD_SPEC where N_STATUS=1 ORDER BY  to_number(replace(C_SPEC, 'φ', ''))");
            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 获得所有配品种
        /// </summary>
        public DataSet GetPZList()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select DISTINCT C_PROD_NAME");
            strSql.Append(" FROM TQB_STD_MAIN ");
            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 获得所有品名
        /// </summary>
        public DataSet GetPMList()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select DISTINCT C_PROD_KIND");
            strSql.Append(" FROM TQB_STD_MAIN ");
            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM TQB_STD_SPEC ");
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
        #region  ExtensionMethod
        /// <summary>
        /// 根据执行标准获得规格，产能列表
        /// </summary>
        public DataSet GetListBySTD(string strSTD, string staid, string stlgrd, string stdcode)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  C_SPEC,'' as N_CAPACITY");
            strSql.Append(" FROM TQB_STD_SPEC where N_STATUS=1 ");
            if (strSTD.Trim() != "")
            {
                strSql.Append(" and C_STD_MAIN_ID='" + strSTD + "' ");
            }
            strSql.Append(" and C_SPEC not in (select t.C_SPEC from TPB_STATION_CAPACITY t where t.c_sta_id='" + staid + "'and t.c_stl_grd = '" + stlgrd + "' and t.c_std_code = '" + stdcode + "')");
            strSql.Append("  ORDER BY to_number(replace(C_SPEC, 'φ', ''))");
            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 根据执行标准获得规格
        /// </summary>
        public DataSet GetListBySTD(string strSTD)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  C_SPEC");
            strSql.Append(" FROM TQB_STD_SPEC where N_STATUS=1 ");
            if (strSTD.Trim() != "")
            {
                strSql.Append(" and C_STD_MAIN_ID='" + strSTD + "' ");
            }
            strSql.Append("  ORDER BY to_number(replace(C_SPEC, 'φ', ''))");
            return DbHelperOra.Query(strSql.ToString());
        }


        /// <summary>
        /// 根据执行标准获得规格(钢种产线规格匹配)
        /// </summary>
        public DataSet GetListBySTDCXGG(string strSTD)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select DISTINCT C_SPEC");
            strSql.Append(" FROM TQB_STD_SPEC where N_STATUS=1 ");
            if (strSTD.Trim() != "")
            {
                strSql.Append(" and C_STD_MAIN_ID='" + strSTD + "' ");
                strSql.Append("  AND C_SPEC NOT IN(SELECT NVL(A.C_SPEC, ' ') FROM TPB_LINE_SPEC A WHERE A.C_STD_MIAN_ID = '" + strSTD + "') ");

            }
            strSql.Append("  ORDER BY to_number(replace(C_SPEC, 'φ', ''))");
            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 根据执行标准获得规格(钢种产线规格匹配)
        /// </summary>
        public DataSet GetSPECListBySTA(string C_STA_ID, string C_SPEC1, string C_SPEC2)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select DISTINCT C_SPEC");
            strSql.Append(" FROM TQB_STD_SPEC where N_STATUS=1 ");
            strSql.Append("  AND C_STD_MAIN_ID  IN(SELECT C_ID FROM TQB_STD_MAIN WHERE N_STATUS=1 AND N_IS_CHECK=1 )");
            if (C_STA_ID.Trim() != "")
            {
                strSql.Append("  AND C_SPEC NOT IN(SELECT NVL(A.C_SPEC, ' ') FROM TPB_LINE_SPEC A WHERE A.N_STATUS=1 AND A.C_STA_ID = '" + C_STA_ID + "') ");
            }
            if (C_SPEC1.Trim() != "")
            {
                strSql.Append("  AND to_number(replace(C_SPEC, 'φ', ''))>=to_number(replace('" + C_SPEC1 + "', 'φ', '')) ");
            }
            if (C_SPEC2.Trim() != "")
            {
                strSql.Append("  AND to_number(replace(C_SPEC, 'φ', ''))<=to_number(replace('" + C_SPEC2 + "', 'φ', '')) ");
            }
            strSql.Append("  ORDER BY to_number(replace(C_SPEC, 'φ', ''))");
            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 根据规格获得规格
        /// </summary>
        /// <param name="C_SPEC">规格</param>
        /// <returns></returns>
        public DataSet GetSPECListBySPEC(string C_SPEC)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select DISTINCT C_SPEC");
            strSql.Append(" FROM TQB_STD_SPEC where N_STATUS=1 ");
            strSql.Append(" AND C_STD_MAIN_ID IN(SELECT C_ID FROM TQB_STD_MAIN WHERE N_STATUS=1 AND N_IS_CHECK=1) ");
            if (C_SPEC.Trim() != "")
            {
                strSql.Append("  AND  to_number(replace(C_SPEC, 'φ', ''))>to_number(replace('" + C_SPEC + "', 'φ', '')) ");
            }
            strSql.Append("  ORDER BY to_number(replace(C_SPEC, 'φ', ''))");
            return DbHelperOra.Query(strSql.ToString());
        }
        #endregion  ExtensionMethod

        #region 钢种执行标准规格

        /// <summary>
        /// 查询钢种执行标准规格数据
        /// </summary>
        /// <param name="C_STL_GRD">钢种</param>
        /// <param name="C_STD_CODE">执行标准</param>
        /// <param name="C_SPEC">规格</param>
        /// <returns></returns>
        public DataTable GetGZGG(string C_STL_GRD, string C_STD_CODE, string C_SPEC)
        {
            string sql = @"SELECT T.C_STL_GRD, T.C_STD_CODE, TS.C_SPEC
  FROM TQB_STD_MAIN T
  LEFT JOIN TQB_STD_SPEC TS
    ON T.C_ID = TS.C_STD_MAIN_ID
 WHERE T.N_STATUS = 1 AND TS.N_STATUS = 1
   AND T.N_IS_CHECK = 1
   AND T.C_STL_GRD = '" + C_STL_GRD + "'   AND T.C_STD_CODE = '" + C_STD_CODE + "' ";
            if (C_SPEC.Trim() != "")
            {
                sql = sql + " AND TS.C_SPEC='" + C_SPEC + "'";
            }

            sql = sql + " ORDER BY TO_NUMBER(REPLACE(TS.C_SPEC, 'φ', ''))";
            return DbHelperOra.Query(sql).Tables[0];
        }

        #endregion
    }
}

