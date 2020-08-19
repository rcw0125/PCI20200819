using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;
namespace DAL
{
    /// <summary>
    /// 数据访问类:TQB_TSBZ_CF
    /// </summary>
    public partial class Dal_TQB_TSBZ_CF
    {
        public Dal_TQB_TSBZ_CF()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string C_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TQB_TSBZ_CF");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)         };
            parameters[0].Value = C_ID;

            return DbHelperOra.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Mod_TQB_TSBZ_CF model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TQB_TSBZ_CF(");
            strSql.Append("C_CHARACTER_ID,C_CODE,C_NAME,N_TARGET_VALUE,C_REMARK,C_EMP_ID,C_STD_CODE,C_STL_GRD,C_PRO_CONDITION_ID)");
            strSql.Append(" values (");
            strSql.Append(":C_CHARACTER_ID,:C_CODE,:C_NAME,:N_TARGET_VALUE,:C_REMARK,:C_EMP_ID,:C_STD_CODE,:C_STL_GRD,:C_PRO_CONDITION_ID)");
            OracleParameter[] parameters = {

                    new OracleParameter(":C_CHARACTER_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_TARGET_VALUE", OracleDbType.Decimal),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STD_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STL_GRD", OracleDbType.Varchar2,100), 
                    new OracleParameter(":C_PRO_CONDITION_ID", OracleDbType.Varchar2,100)
            };
            parameters[0].Value = model.C_CHARACTER_ID;
            parameters[1].Value = model.C_CODE;
            parameters[2].Value = model.C_NAME;
            parameters[3].Value = model.N_TARGET_VALUE;
            parameters[4].Value = model.C_REMARK;
            parameters[5].Value = model.C_EMP_ID;
            parameters[6].Value = model.C_STD_CODE;
            parameters[7].Value = model.C_STL_GRD;
            parameters[8].Value = model.C_PRO_CONDITION_ID;
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
        public bool Update(Mod_TQB_TSBZ_CF model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TQB_TSBZ_CF set ");
            strSql.Append("C_CHARACTER_ID=:C_CHARACTER_ID,");
            strSql.Append("C_CODE=:C_CODE,");
            strSql.Append("C_NAME=:C_NAME,");
            strSql.Append("N_TARGET_VALUE=:N_TARGET_VALUE,");
            strSql.Append("N_STATUS=:N_STATUS,");
            strSql.Append("C_REMARK=:C_REMARK,");
            strSql.Append("C_EMP_ID=:C_EMP_ID,");
            strSql.Append("D_MOD_DT=:D_MOD_DT,");
            strSql.Append("C_STD_CODE=:C_STD_CODE,");
            strSql.Append("C_STL_GRD=:C_STL_GRD,");
            strSql.Append("C_PRO_CONDITION_ID=:C_PRO_CONDITION_ID");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_CHARACTER_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_TARGET_VALUE", OracleDbType.Decimal,15),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":C_STD_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STL_GRD", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PRO_CONDITION_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)
            };
            parameters[0].Value = model.C_CHARACTER_ID;
            parameters[1].Value = model.C_CODE;
            parameters[2].Value = model.C_NAME;
            parameters[3].Value = model.N_TARGET_VALUE;
            parameters[4].Value = model.N_STATUS;
            parameters[5].Value = model.C_REMARK;
            parameters[6].Value = model.C_EMP_ID;
            parameters[7].Value = model.D_MOD_DT;
            parameters[8].Value = model.C_STD_CODE;
            parameters[9].Value = model.C_STL_GRD;
            parameters[10].Value = model.C_PRO_CONDITION_ID;
            parameters[11].Value = model.C_ID;

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
            strSql.Append("delete from TQB_TSBZ_CF ");
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
            strSql.Append("delete from TQB_TSBZ_CF ");
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
        public Mod_TQB_TSBZ_CF GetModel(string C_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_CHARACTER_ID,C_CODE,C_NAME,N_TARGET_VALUE,N_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT,C_STD_CODE,C_STL_GRD,C_PRO_CONDITION_ID from TQB_TSBZ_CF ");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)         };
            parameters[0].Value = C_ID;

            Mod_TQB_TSBZ_CF model = new Mod_TQB_TSBZ_CF();
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
        public Mod_TQB_TSBZ_CF GetModel_GZ(string C_NAME, decimal N_TARGET_VALUE, string C_PRO_CONDITION_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_CHARACTER_ID,C_CODE,C_NAME,N_TARGET_VALUE,N_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT,C_STD_CODE,C_STL_GRD,C_PRO_CONDITION_ID from TQB_TSBZ_CF ");
            strSql.Append(" where  C_NAME=:C_NAME AND N_TARGET_VALUE=:N_TARGET_VALUE  AND C_PRO_CONDITION_ID=:C_PRO_CONDITION_ID  AND N_STATUS=1");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_NAME", OracleDbType.Varchar2,100)  ,
                    new OracleParameter(":N_TARGET_VALUE", OracleDbType.Decimal,15),
                    new OracleParameter(":C_PRO_CONDITION_ID", OracleDbType.Varchar2,100)         };
            parameters[0].Value = C_NAME;
            parameters[1].Value = N_TARGET_VALUE;
            parameters[2].Value = C_PRO_CONDITION_ID;

            Mod_TQB_TSBZ_CF model = new Mod_TQB_TSBZ_CF();
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
        public Mod_TQB_TSBZ_CF DataRowToModel(DataRow row)
        {
            Mod_TQB_TSBZ_CF model = new Mod_TQB_TSBZ_CF();
            if (row != null)
            {
                if (row["C_ID"] != null)
                {
                    model.C_ID = row["C_ID"].ToString();
                }

                if (row["C_CHARACTER_ID"] != null)
                {
                    model.C_CHARACTER_ID = row["C_CHARACTER_ID"].ToString();
                }
                if (row["C_CODE"] != null)
                {
                    model.C_CODE = row["C_CODE"].ToString();
                }
                if (row["C_NAME"] != null)
                {
                    model.C_NAME = row["C_NAME"].ToString();
                }
                if (row["N_TARGET_VALUE"] != null && row["N_TARGET_VALUE"].ToString() != "")
                {
                    model.N_TARGET_VALUE = decimal.Parse(row["N_TARGET_VALUE"].ToString());
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
                if (row["C_PRO_CONDITION_ID"] != null)
                {
                    model.C_PRO_CONDITION_ID = row["C_PRO_CONDITION_ID"].ToString();
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
            strSql.Append("select C_ID,C_CHARACTER_ID,C_CODE,C_NAME,N_TARGET_VALUE,N_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT,C_STD_CODE,C_STL_GRD ");
            strSql.Append(" FROM TQB_TSBZ_CF ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList_ProID(string C_PRO_CONDITION_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_CHARACTER_ID,C_CODE,C_NAME,N_TARGET_VALUE,N_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT,C_STD_CODE,C_STL_GRD,C_PRO_CONDITION_ID ");
            strSql.Append(" FROM TQB_TSBZ_CF  where N_STATUS=1 ");
            if (C_PRO_CONDITION_ID.Trim() != "")
            {
                strSql.Append(" and C_PRO_CONDITION_ID= '"+ C_PRO_CONDITION_ID + "' ");
            }
            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 根据钢种，执行标准获取数据列表
        /// </summary>
        /// <param name="C_STD_CODE">执行标准</param>
        /// <param name="C_STL_GRD">钢种</param>
        /// <returns></returns>
        public DataSet GetList_Query(string C_STD_CODE, string C_STL_GRD)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_CHARACTER_ID,C_CODE,C_NAME,N_TARGET_VALUE,N_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT,C_STD_CODE,C_STL_GRD ");
            strSql.Append(" FROM TQB_TSBZ_CF where  N_STATUS=1");
            strSql.Append(" and C_STD_CODE = '" + C_STD_CODE + "'   and C_STL_GRD='" + C_STL_GRD + "' ");

            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 根据主表ID获得数据列表
        /// </summary>
        /// <param name="strMainID">主表ID</param>
        /// <returns></returns>
        public DataSet GetListByMainID(string strMainID, int iStatus)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_CHARACTER_ID,C_CODE,C_NAME,N_TARGET_VALUE,N_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT,C_STD_CODE,C_STL_GRD ");
            strSql.Append(" FROM TQB_TSBZ_CF where 1=1  ");
            if (strMainID.Trim() != "")
            {
                strSql.Append(" and C_TSBZ_MAIN_ID='" + strMainID + "'");
            }
            strSql.Append(" and N_STATUS=" + iStatus);

            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM TQB_TSBZ_CF ");
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
        /// 得到已初始化订单铁水信息(废除)
        /// </summary>
        /// <param name="strIniID">方案主键</param>
        /// <param name="strGZ">钢种</param>
        /// <param name="strBZ">标准</param>
        /// <param name="strRollID">轧线</param>
        /// <param name="strCCMID">连铸</param>
        /// <param name="rolltype">轧钢是否排产</param>
        /// <param name="ccmtype">炼钢是否排产</param>
        /// <returns>铁水信息</returns>
        public DataTable GetTSCFByOrder(string strIniID, string strGZ, string strBZ, string strRollID, string strCCMID, int? rolltype, int? ccmtype)
        {
            string sql = @"SELECT T.C_NAME, min(T.N_TARGET_VALUE) N_TARGET_VALUE
  FROM TQB_TSBZ_CF T, 
       TQB_TSBZ_MAIN A,
       (SELECT A.C_INITIALIZE_ID,
               A.C_ORDER_ID,
               A.N_WGT,
               A.C_ROLL_STA_ID,
               (SELECT M.C_STA_DESC
                  FROM TB_STA M
                 WHERE M.C_ID = A.C_ROLL_STA_ID) C_ROLL_DESC,
               A.N_MACH_WGT,
               A.C_CCM_STA_ID,
               (SELECT M.C_STA_DESC
                  FROM TB_STA M
                 WHERE M.C_ID = A.C_CCM_STA_ID) C_CCM_DESC,
               A.N_MACH_WGT_CCM,
               A.C_ID,
               T.C_ORDER_NO,
               T.C_CON_NO,
               T.C_CON_NAME,
               T.C_AREA,
               T.C_MAT_CODE,
               T.C_MAT_NAME,
               T.C_TECH_PROT,
               T.C_SPEC,
               T.C_STL_GRD,
               T.C_STD_CODE,
               T.C_FREE_TERM,
               T.C_FREE_TERM2,
               T.C_PRO_USE,
               T.D_NEED_DT,
               T.D_DELIVERY_DT,
               T.C_PACK,
               T.C_LEV
          FROM TPP_INITIALIZE_ORDER A, TMO_ORDER T ";
            sql = sql + "    WHERE A.C_ORDER_ID = T.C_ID ";
            sql = sql + "   AND A.C_INITIALIZE_ID = '" + strIniID + "' ";
            if (rolltype != null)
            {
                sql = sql + "  AND A.N_EXEC_STATUS = " + rolltype + " ";
            }
            if (ccmtype != null)
            {
                sql = sql + "  AND A.N_LGPC_STATUS = " + ccmtype + "  ";
            }
            if (strGZ.Trim() != "")
            {
                sql = sql + "  AND UPPER(T.C_STL_GRD)  LIKE UPPER( '" + strGZ + "')";
            }

            if (strBZ.Trim() != "")
            {
                sql = sql + "  AND UPPER(T.C_STD_CODE)  LIKE UPPER( '" + strBZ + "') ";
            }
            if (strRollID.Trim() != "")
            {
                sql = sql + "  AND A.C_ROLL_STA_ID = '" + strRollID + "' ";
            }
            if (strCCMID.Trim() != "")
            {
                sql = sql + "  AND A.C_CCM_STA_ID = '" + strCCMID + "'";
            }
            sql = sql + "  ) X ";
            sql = sql + "    WHERE T.C_TSBZ_MAIN_ID = A.C_ID ";
            sql = sql + "     AND A.C_STL_GRD = X.C_STL_GRD ";
            sql = sql + "    AND A.C_XY_CODE = X.C_STD_CODE ";
            sql = sql + "    AND T.N_STATUS = 1 GROUP BY C_NAME";
            //sql = sql + " ORDER BY  T.C_NAME ";

            return DbHelperOra.Query(sql).Tables[0];

        }

        /// <summary>
        /// 当前炼钢排产铁水成分要求
        /// </summary>
        /// <returns></returns>
        public DataTable GetTSCFByOrder()
        {
            string sql = @"SELECT T.C_NAME, MIN(T.N_TARGET_VALUE) N_TARGET_VALUE
  FROM TQB_TSBZ_CF T,
        TPB_STEEL_PRO_CONDITION A,
       (SELECT T.C_ORDER_NO,
               T.N_WGT,
               (SELECT M.C_STA_DESC FROM TB_STA M WHERE M.C_ID = T.C_LINE_NO) C_ROLL_DESC,
               (SELECT M.C_STA_DESC FROM TB_STA M WHERE M.C_ID = T.C_CCM_NO) C_CCM_DESC,
               T.C_ORDER_NO,
               T.C_CON_NO,
               T.C_CON_NAME,
               T.C_AREA,
               T.C_MAT_CODE,
               T.C_MAT_NAME,
               T.C_TECH_PROT,
               T.C_SPEC,
               T.C_STL_GRD,
               T.C_STD_CODE,
               T.C_FREE1,
               T.C_FREE2,
               T.C_PRO_USE,
               T.D_NEED_DT,
               T.D_DELIVERY_DT,
               T.C_PACK,
               T.C_LEV
          FROM TMO_ORDER T
         WHERE T.N_STATUS = 2
           AND(T.N_WGT - T.N_SMS_PROD_WGT - T.N_SLAB_MATCH_WGT) > 0) X
WHERE T.C_STL_GRD = A.C_STL_GRD
   AND T.C_STD_CODE = A.C_STD_CODE
   AND A.C_STL_GRD = X.C_STL_GRD
   AND A.C_STD_CODE = X.C_STD_CODE
   AND T.N_STATUS = 1
 GROUP BY C_NAME";
            return DbHelperOra.Query(sql).Tables[0];

        }
        #endregion  BasicMethod
    }
}
