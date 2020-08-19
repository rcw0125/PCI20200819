using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;
namespace DAL
{
    /// <summary>
    /// 数据访问类:TPB_SLAB_CAPACITY
    /// </summary>
    public partial class Dal_TPB_SLAB_CAPACITY
    {
        public Dal_TPB_SLAB_CAPACITY()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string C_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TPB_SLAB_CAPACITY");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)         };
            parameters[0].Value = C_ID;

            return DbHelperOra.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Mod_TPB_SLAB_CAPACITY model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TPB_SLAB_CAPACITY(");
            strSql.Append("C_STA_ID,C_STL_GRD,C_SPEC,N_CAPACITY,D_START_DATE,D_END_DATE,N_STATUS,C_EMP_ID,D_MOD_DT,C_STD_CODE,C_PRO_ID,C_STA_DESC,C_STA_CODE,C_PROD_NAME,C_TYPE)");
            strSql.Append(" values (");
            strSql.Append(":C_STA_ID,:C_STL_GRD,:C_SPEC,:N_CAPACITY,:D_START_DATE,:D_END_DATE,:N_STATUS,:C_EMP_ID,:D_MOD_DT,:C_STD_CODE,:C_PRO_ID,:C_STA_DESC,:C_STA_CODE,:C_PROD_NAME,:C_TYPE)");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_STA_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STL_GRD", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SPEC", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_CAPACITY", OracleDbType.Decimal,15),
                    new OracleParameter(":D_START_DATE", OracleDbType.Date),
                    new OracleParameter(":D_END_DATE", OracleDbType.Date),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":C_STD_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PRO_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STA_DESC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STA_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PROD_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_TYPE", OracleDbType.Varchar2,100)
            };

            parameters[0].Value = model.C_STA_ID;
            parameters[1].Value = model.C_STL_GRD;
            parameters[2].Value = model.C_SPEC;
            parameters[3].Value = model.N_CAPACITY;
            parameters[4].Value = model.D_START_DATE;
            parameters[5].Value = model.D_END_DATE;
            parameters[6].Value = model.N_STATUS;
            parameters[7].Value = model.C_EMP_ID;
            parameters[8].Value = model.D_MOD_DT;
            parameters[9].Value = model.C_STD_CODE;
            parameters[10].Value = model.C_PRO_ID;
            parameters[11].Value = model.C_STA_DESC;
            parameters[12].Value = model.C_STA_CODE;
            parameters[13].Value = model.C_PROD_NAME;
            parameters[14].Value = model.C_TYPE;
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
        public bool Update(Mod_TPB_SLAB_CAPACITY model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TPB_SLAB_CAPACITY set ");
            strSql.Append("C_STA_ID=:C_STA_ID,");
            strSql.Append("C_STL_GRD=:C_STL_GRD,");
            strSql.Append("C_SPEC=:C_SPEC,");
            strSql.Append("N_CAPACITY=:N_CAPACITY,");
            strSql.Append("D_START_DATE=:D_START_DATE,");
            strSql.Append("D_END_DATE=:D_END_DATE,");
            strSql.Append("N_STATUS=:N_STATUS,");
            strSql.Append("C_EMP_ID=:C_EMP_ID,");
            strSql.Append("D_MOD_DT=:D_MOD_DT,");
            strSql.Append("C_STD_CODE=:C_STD_CODE,");
            strSql.Append("C_PRO_ID=:C_PRO_ID,");
            strSql.Append("C_STA_DESC=:C_STA_DESC,");
            strSql.Append("C_STA_CODE=:C_STA_CODE,");
            strSql.Append("C_TYPE=:C_TYPE,");
            strSql.Append("C_PROD_NAME=:C_PROD_NAME");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_STA_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STL_GRD", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SPEC", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_CAPACITY", OracleDbType.Decimal,15),
                    new OracleParameter(":D_START_DATE", OracleDbType.Date),
                    new OracleParameter(":D_END_DATE", OracleDbType.Date),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":C_STD_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PRO_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STA_DESC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STA_CODE", OracleDbType.Varchar2,100),
                     new OracleParameter(":C_TYPE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PROD_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)

            };

            parameters[0].Value = model.C_STA_ID;
            parameters[1].Value = model.C_STL_GRD;
            parameters[2].Value = model.C_SPEC;
            parameters[3].Value = model.N_CAPACITY;
            parameters[4].Value = model.D_START_DATE;
            parameters[5].Value = model.D_END_DATE;
            parameters[6].Value = model.N_STATUS;
            parameters[7].Value = model.C_EMP_ID;
            parameters[8].Value = model.D_MOD_DT;
            parameters[9].Value = model.C_STD_CODE;
            parameters[10].Value = model.C_PRO_ID;
            parameters[11].Value = model.C_STA_DESC;
            parameters[12].Value = model.C_STA_CODE;
            parameters[13].Value = model.C_TYPE;
            parameters[14].Value = model.C_PROD_NAME;
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
            strSql.Append("delete from TPB_SLAB_CAPACITY ");
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
            strSql.Append("delete from TPB_SLAB_CAPACITY ");
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
        public Mod_TPB_SLAB_CAPACITY GetModel(string C_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_STA_ID,C_STL_GRD,C_SPEC,N_CAPACITY,D_START_DATE,D_END_DATE,N_STATUS,C_EMP_ID,D_MOD_DT,C_STD_CODE,C_PRO_ID,C_STA_DESC,C_STA_CODE,C_PROD_NAME,C_TYPE from TPB_SLAB_CAPACITY ");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)         };
            parameters[0].Value = C_ID;

            Mod_TPB_SLAB_CAPACITY model = new Mod_TPB_SLAB_CAPACITY();
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
        public Mod_TPB_SLAB_CAPACITY DataRowToModel(DataRow row)
        {
            Mod_TPB_SLAB_CAPACITY model = new Mod_TPB_SLAB_CAPACITY();
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
                if (row["C_SPEC"] != null)
                {
                    model.C_SPEC = row["C_SPEC"].ToString();
                }
                if (row["N_CAPACITY"] != null && row["N_CAPACITY"].ToString() != "")
                {
                    model.N_CAPACITY = decimal.Parse(row["N_CAPACITY"].ToString());
                }
                if (row["D_START_DATE"] != null && row["D_START_DATE"].ToString() != "")
                {
                    model.D_START_DATE = DateTime.Parse(row["D_START_DATE"].ToString());
                }
                if (row["D_END_DATE"] != null && row["D_END_DATE"].ToString() != "")
                {
                    model.D_END_DATE = DateTime.Parse(row["D_END_DATE"].ToString());
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
                if (row["C_STD_CODE"] != null)
                {
                    model.C_STD_CODE = row["C_STD_CODE"].ToString();
                }
                if (row["C_PRO_ID"] != null)
                {
                    model.C_PRO_ID = row["C_PRO_ID"].ToString();
                }
                if (row["C_STA_DESC"] != null)
                {
                    model.C_STA_DESC = row["C_STA_DESC"].ToString();
                }
                if (row["C_STA_CODE"] != null)
                {
                    model.C_STA_CODE = row["C_STA_CODE"].ToString();
                }
                if (row["C_PROD_NAME"] != null)
                {
                    model.C_PROD_NAME = row["C_PROD_NAME"].ToString();
                }
                if (row["C_TYPE"] != null)
                {
                    model.C_TYPE = row["C_TYPE"].ToString();
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
            strSql.Append("select C_ID,C_STA_ID,C_STL_GRD,C_SPEC,N_CAPACITY,D_START_DATE,D_END_DATE,N_STATUS,C_EMP_ID,D_MOD_DT,C_STD_CODE,C_PRO_ID,C_STA_DESC,C_STA_CODE,C_PROD_NAME,C_TYPE ");
            strSql.Append(" FROM TPB_SLAB_CAPACITY ");
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
            strSql.Append("select count(1) FROM TPB_SLAB_CAPACITY ");
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
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string sta, string gl, string grd, int status, string zxbz,string type)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_STA_ID,C_STL_GRD,C_SPEC,N_CAPACITY,D_START_DATE,D_END_DATE,DECODE(N_STATUS,1,'启用','停用') N_STATUS,C_EMP_ID,D_MOD_DT,C_STD_CODE,C_PRO_ID,C_STA_DESC,C_STA_CODE,C_PROD_NAME,C_TYPE ");
            strSql.Append(" FROM TPB_SLAB_CAPACITY where N_STATUS='" + status + "' ");
            if (sta.Trim() != "")
            {
                strSql.Append(" AND C_STA_ID ='" + sta + "' ");
            }
            if (type.Trim()!="全部")
            {
                strSql.Append(" AND C_TYPE ='" + type + "' ");
            }
            strSql.Append(" AND nvl(C_PROD_NAME,' ') LIKE '%" + gl + "%'");
            strSql.Append(" AND nvl(C_STL_GRD,' ') LIKE '%" + grd + "%' ");
            strSql.Append(" AND nvl(C_STD_CODE,' ') LIKE '%" + zxbz + "%' ");
            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 通过钢种检验是否存在数据
        /// </summary>
        /// <param name="C_PROD_NAME">钢类</param>
        /// <param name="C_STA_ID">工位</param>
        /// <param name="C_SPEC">规格</param>
        /// <param name="C_STL_GRD">钢种</param>
        /// <param name="C_STD_CODE">执行标准</param>
        /// <returns></returns>
        public bool ExistsByGRD(string C_PROD_NAME, string C_STA_ID, string C_SPEC, string C_STL_GRD, string C_STD_CODE)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TPB_SLAB_CAPACITY where N_STATUS=1 ");
            if (C_STL_GRD.Trim()=="")
            {
                strSql.Append(" AND C_STL_GRD is null ");
                strSql.Append(" AND C_STD_CODE is null ");
                strSql.Append(" and C_STA_ID=:C_STA_ID  ");
                strSql.Append(" and C_SPEC=:C_SPEC  ");
                strSql.Append(" and C_PROD_NAME=:C_PROD_NAME  ");
                OracleParameter[] parameters1 = {
                new OracleParameter(":C_STA_ID", OracleDbType.Varchar2,100),
                new OracleParameter(":C_SPEC", OracleDbType.Varchar2,100),
                 new OracleParameter(":C_PROD_NAME", OracleDbType.Varchar2,100)
            };
                parameters1[0].Value = C_STA_ID;
                parameters1[1].Value = C_SPEC;
                parameters1[2].Value = C_PROD_NAME;
                return DbHelperOra.Exists(strSql.ToString(), parameters1);
            }
            else
            {
                strSql.Append(" and C_STA_ID=:C_STA_ID  ");
                strSql.Append(" and C_STL_GRD=:C_STL_GRD  ");
                strSql.Append(" and C_SPEC=:C_SPEC  ");
                strSql.Append(" and C_STD_CODE=:C_STD_CODE  ");
                strSql.Append(" and C_PROD_NAME=:C_PROD_NAME  ");
                OracleParameter[] parameters = {
                new OracleParameter(":C_STA_ID", OracleDbType.Varchar2,100),
                new OracleParameter(":C_STL_GRD", OracleDbType.Varchar2,100),
                new OracleParameter(":C_SPEC", OracleDbType.Varchar2,100),
                new OracleParameter(":C_STD_CODE", OracleDbType.Varchar2,100),
                new OracleParameter(":C_PROD_NAME", OracleDbType.Varchar2,100)
            };
                parameters[0].Value = C_STA_ID;
                parameters[1].Value = C_STL_GRD;
                parameters[2].Value = C_SPEC;
                parameters[3].Value = C_STD_CODE;
                parameters[4].Value = C_PROD_NAME;
                return DbHelperOra.Exists(strSql.ToString(), parameters);
            }
           
        }
        /// <summary>
        /// 仅看断面检验是否存在数据
        /// </summary>
        /// <param name="C_STA_ID">工位</param>
        /// <param name="C_SPEC">断面</param>
        /// <returns></returns>
        public bool Exists(string C_STA_ID, string C_SPEC)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TPB_SLAB_CAPACITY where N_STATUS=1 ");
            strSql.Append(" AND C_STL_GRD is null ");
            strSql.Append(" AND C_STD_CODE is null ");
            strSql.Append(" AND C_PROD_NAME is null ");
            strSql.Append(" and C_STA_ID=:C_STA_ID  ");
            strSql.Append(" and C_SPEC=:C_SPEC  ");
            OracleParameter[] parameters = {
                new OracleParameter(":C_STA_ID", OracleDbType.Varchar2,100),
                new OracleParameter(":C_SPEC", OracleDbType.Varchar2,100)
            };
            parameters[0].Value = C_STA_ID;
            parameters[1].Value = C_SPEC;
            return DbHelperOra.Exists(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 获取默认连铸机信息
        /// </summary>
        /// <param name="strGZ">钢种</param>
        /// <param name="strBZ">标准</param>
        /// <param name="strIniID">方案主键</param>
        public DataTable GetOrderCCM(string strGZ,string strBZ,string strIniID)
        {
            string sql = "SELECT T.C_STA_ID, A.C_STA_CODE, A.C_STA_DESC , T.N_CAPACITY";
            sql = sql + " FROM TPB_SLAB_CAPACITY T, TB_STA A ";
            sql = sql + "  WHERE T.C_STA_ID = A.C_ID  AND T.N_STATUS=1 ";
            sql = sql + "   AND T.C_STL_GRD = '" + strGZ + "'";
            sql = sql + "   AND T.C_STD_CODE = '"+ strBZ + "'";
            sql = sql + "   AND T.C_STA_ID IN ";
            sql = sql + "      (SELECT C.C_STA_ID ";
            sql = sql + "     FROM TPP_INITIALIZE_STA C ";
            sql = sql + "   WHERE C.C_INITIALIZE_ITEM_ID = '"+ strIniID + "')";
            sql = sql + "    AND ROWNUM = 1";
            sql = sql + "    ORDER BY T.N_CAPACITY DESC, A.N_SORT";
            return DbHelperOra.Query(sql).Tables[0];
        }



        /// <summary>
        /// 获取默认连铸机信息
        /// </summary>
        /// <param name="strGZ">钢种</param>
        /// <param name="strBZ">标准</param>
        /// <param name="strCCM">连铸</param>
        /// <param name="sfKP">是否开坯</param>
        /// <returns>订单连铸信息</returns>
        public DataTable GetSteelCCM(string strGZ, string strBZ, string strCCM,string sfKP)
        {
            string sql = "SELECT  T.C_TYPE,T.C_STA_ID, A.C_STA_CODE, A.C_STA_DESC , T.N_CAPACITY"; 
            sql = sql + " FROM TPB_SLAB_CAPACITY T, TB_STA A ";
            sql = sql + "  WHERE T.C_STA_ID = A.C_ID  AND T.N_STATUS=1 ";
            sql = sql + "   AND T.C_STL_GRD = '" + strGZ + "'";
            if (sfKP == "Y")
            {
                sql = sql + "   AND  A.C_STA_CODE IN ('5#CC','7#CC') ";
            }
            else
            {
                sql = sql + "   AND  A.C_STA_CODE NOT IN ('5#CC','7#CC') ";
            }
         
            if (strCCM.Trim()!="")
            {
                sql = sql + "   AND A.C_ID = '" + strCCM + "'";
            }
            sql = sql + "   AND T.C_STD_CODE = '" + strBZ + "'";
            sql = sql + "   AND T.C_STA_ID IN ";
            sql = sql + "      (SELECT C.C_STA_ID ";
            sql = sql + "     FROM TPP_INITIALIZE_STA C )";
            sql = sql + "    ORDER BY T.N_CAPACITY DESC, A.N_SORT";
            return DbHelperOra.Query(sql).Tables[0];
        }


        /// <summary>
        /// 获取默认连铸机信息
        /// </summary>
        /// <param name="strGZ">钢种</param>
        /// <param name="strBZ">标准</param>
        /// <param name="strCCM">连铸</param>
        /// <param name="sfKP">是否开坯</param>
        /// <returns>订单连铸信息</returns>
        public DataTable GetListByCCM(string strGZ, string strBZ, string strCCM)
        {
            string sql = "SELECT  T.* ";
            sql = sql + " FROM TPB_SLAB_CAPACITY T ";
            sql = sql + "  WHERE T.C_STA_ID ='"+ strCCM + "' ";
            sql = sql + "   AND T.C_STL_GRD = '" + strGZ + "'";
            sql = sql + "   AND T.C_STD_CODE = '" + strBZ + "'";
            return DbHelperOra.Query(sql).Tables[0];
        }

        #endregion  ExtensionMethod
    }
}