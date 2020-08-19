
using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;
namespace DAL
{
    /// <summary>
    /// 数据访问类:Dal_TB_STD_CONFIG
    /// </summary>
    public partial class Dal_TB_STD_CONFIG
    {
        public Dal_TB_STD_CONFIG()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string C_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TB_STD_CONFIG");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)         };
            parameters[0].Value = C_ID;

            return DbHelperOra.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Mod_TB_STD_CONFIG model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TB_STD_CONFIG(");
            strSql.Append("C_STD_ID,C_CUST_TECH_PROT,C_ZYX1,C_ZYX2,C_STL_GRD,C_STD_CODE,C_STEEL_SIGN,C_EMP_ID,D_MOD_DT,C_REMARK,D_START_DATE,D_END_DATE,N_STATUS,C_CUST_NO,C_CUST_NAME)");
            strSql.Append(" values (");
            strSql.Append(":C_STD_ID,:C_CUST_TECH_PROT,:C_ZYX1,:C_ZYX2,:C_STL_GRD,:C_STD_CODE,:C_STEEL_SIGN,:C_EMP_ID,:D_MOD_DT,:C_REMARK,:D_START_DATE,:D_END_DATE,:N_STATUS,:C_CUST_NO,:C_CUST_NAME)");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_STD_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CUST_TECH_PROT", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ZYX1", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ZYX2", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STL_GRD", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STD_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STEEL_SIGN", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,200),
                    new OracleParameter(":D_START_DATE", OracleDbType.Date),
                    new OracleParameter(":D_END_DATE", OracleDbType.Date),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
            new OracleParameter(":C_CUST_NO", OracleDbType.Varchar2,100),
            new OracleParameter(":C_CUST_NAME", OracleDbType.Varchar2,200)};
            parameters[0].Value = model.C_STD_ID;
            parameters[1].Value = model.C_CUST_TECH_PROT;
            parameters[2].Value = model.C_ZYX1;
            parameters[3].Value = model.C_ZYX2;
            parameters[4].Value = model.C_STL_GRD;
            parameters[5].Value = model.C_STD_CODE;
            parameters[6].Value = model.C_STEEL_SIGN;
            parameters[7].Value = model.C_EMP_ID;
            parameters[8].Value = model.D_MOD_DT;
            parameters[9].Value = model.C_REMARK;
            parameters[10].Value = model.D_START_DATE;
            parameters[11].Value = model.D_END_DATE;
            parameters[12].Value = model.N_STATUS;
            parameters[13].Value = model.C_CUST_NO;
            parameters[14].Value = model.C_CUST_NAME;

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
        public bool Update(Mod_TB_STD_CONFIG model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TB_STD_CONFIG set ");
            strSql.Append("C_STD_ID=:C_STD_ID,");
            strSql.Append("C_CUST_TECH_PROT=:C_CUST_TECH_PROT,");
            strSql.Append("C_ZYX1=:C_ZYX1,");
            strSql.Append("C_ZYX2=:C_ZYX2,");
            strSql.Append("C_STL_GRD=:C_STL_GRD,");
            strSql.Append("C_STD_CODE=:C_STD_CODE,");
            strSql.Append("C_STEEL_SIGN=:C_STEEL_SIGN,");
            strSql.Append("C_EMP_ID=:C_EMP_ID,");
            strSql.Append("D_MOD_DT=:D_MOD_DT,");
            strSql.Append("C_REMARK=:C_REMARK,");
            strSql.Append("D_START_DATE=:D_START_DATE,");
            strSql.Append("D_END_DATE=:D_END_DATE,");
            strSql.Append("N_STATUS=:N_STATUS");
            strSql.Append("C_CUST_NO=:C_CUST_NO");
            strSql.Append("C_CUST_NAME=:C_CUST_NAME");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_STD_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CUST_TECH_PROT", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ZYX1", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ZYX2", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STL_GRD", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STD_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STEEL_SIGN", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,200),
                    new OracleParameter(":D_START_DATE", OracleDbType.Date),
                    new OracleParameter(":D_END_DATE", OracleDbType.Date),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100),
            new OracleParameter(":C_CUST_NO", OracleDbType.Varchar2,100),
            new OracleParameter(":C_CUST_NAME", OracleDbType.Varchar2,200)};
            parameters[0].Value = model.C_STD_ID;
            parameters[1].Value = model.C_CUST_TECH_PROT;
            parameters[2].Value = model.C_ZYX1;
            parameters[3].Value = model.C_ZYX2;
            parameters[4].Value = model.C_STL_GRD;
            parameters[5].Value = model.C_STD_CODE;
            parameters[6].Value = model.C_STEEL_SIGN;
            parameters[7].Value = model.C_EMP_ID;
            parameters[8].Value = model.D_MOD_DT;
            parameters[9].Value = model.C_REMARK;
            parameters[10].Value = model.D_START_DATE;
            parameters[11].Value = model.D_END_DATE;
            parameters[12].Value = model.N_STATUS;
            parameters[13].Value = model.C_CUST_NO;
            parameters[14].Value = model.C_CUST_NAME;
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
            strSql.Append("delete from TB_STD_CONFIG ");
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
            strSql.Append("delete from TB_STD_CONFIG ");
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
        public Mod_TB_STD_CONFIG GetModel(string C_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_STD_ID,C_CUST_TECH_PROT,C_ZYX1,C_ZYX2,C_STL_GRD,C_STD_CODE,C_STEEL_SIGN,C_EMP_ID,D_MOD_DT,C_REMARK,D_START_DATE,D_END_DATE,N_STATUS,C_CUST_NO,C_CUST_NAME from TB_STD_CONFIG ");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)         };
            parameters[0].Value = C_ID;

            Mod_TB_STD_CONFIG model = new Mod_TB_STD_CONFIG();
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
        public Mod_TB_STD_CONFIG GetModel_Interface(string C_STD_CODE, string C_STL_GRD)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_STD_ID,C_CUST_TECH_PROT,C_ZYX1,C_ZYX2,C_STL_GRD,C_STD_CODE,C_STEEL_SIGN,C_EMP_ID,D_MOD_DT,C_REMARK,D_START_DATE,D_END_DATE,N_STATUS,C_CUST_NO,C_CUST_NAME from TB_STD_CONFIG ");
            strSql.Append(" where C_STD_CODE=:C_STD_CODE and C_STL_GRD=:C_STL_GRD ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_STD_CODE", OracleDbType.Varchar2,100) ,
                     new OracleParameter(":C_STL_GRD", OracleDbType.Varchar2,100)
            };
            parameters[0].Value = C_STD_CODE;
            parameters[1].Value = C_STL_GRD;
            Mod_TB_STD_CONFIG model = new Mod_TB_STD_CONFIG();
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
        public Mod_TB_STD_CONFIG GetModel_Interface_Trans(string C_STD_CODE, string C_STL_GRD)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_STD_ID,C_CUST_TECH_PROT,C_ZYX1,C_ZYX2,C_STL_GRD,C_STD_CODE,C_STEEL_SIGN,C_EMP_ID,D_MOD_DT,C_REMARK,D_START_DATE,D_END_DATE,N_STATUS,C_CUST_NO,C_CUST_NAME from TB_STD_CONFIG ");
            strSql.Append(" where C_STD_CODE=:C_STD_CODE and C_STL_GRD=:C_STL_GRD ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_STD_CODE", OracleDbType.Varchar2,100) ,
                     new OracleParameter(":C_STL_GRD", OracleDbType.Varchar2,100)
            };
            parameters[0].Value = C_STD_CODE;
            parameters[1].Value = C_STL_GRD;
            Mod_TB_STD_CONFIG model = new Mod_TB_STD_CONFIG();
            DataSet ds = TransactionHelper.Query(strSql.ToString(), parameters);
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
        public Mod_TB_STD_CONFIG DataRowToModel(DataRow row)
        {
            Mod_TB_STD_CONFIG model = new Mod_TB_STD_CONFIG();
            if (row != null)
            {
                if (row["C_ID"] != null)
                {
                    model.C_ID = row["C_ID"].ToString();
                }
                if (row["C_STD_ID"] != null)
                {
                    model.C_STD_ID = row["C_STD_ID"].ToString();
                }
                if (row["C_CUST_TECH_PROT"] != null)
                {
                    model.C_CUST_TECH_PROT = row["C_CUST_TECH_PROT"].ToString();
                }
                if (row["C_ZYX1"] != null)
                {
                    model.C_ZYX1 = row["C_ZYX1"].ToString();
                }
                if (row["C_ZYX2"] != null)
                {
                    model.C_ZYX2 = row["C_ZYX2"].ToString();
                }
                if (row["C_STL_GRD"] != null)
                {
                    model.C_STL_GRD = row["C_STL_GRD"].ToString();
                }
                if (row["C_STD_CODE"] != null)
                {
                    model.C_STD_CODE = row["C_STD_CODE"].ToString();
                }
                if (row["C_STEEL_SIGN"] != null)
                {
                    model.C_STEEL_SIGN = row["C_STEEL_SIGN"].ToString();
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
                if (row["N_STATUS"] != null && row["N_STATUS"].ToString() != "")
                {
                    model.N_STATUS = decimal.Parse(row["N_STATUS"].ToString());
                }
                if (row["C_CUST_NO"] != null)
                {
                    model.C_CUST_NO = row["C_CUST_NO"].ToString();
                }
                if (row["C_CUST_NAME"] != null)
                {
                    model.C_CUST_NAME = row["C_CUST_NAME"].ToString();
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
            strSql.Append("select C_ID,C_STD_ID,C_CUST_TECH_PROT,C_ZYX1,C_ZYX2,C_STL_GRD,C_STD_CODE,C_STEEL_SIGN,C_EMP_ID,D_MOD_DT,C_REMARK,D_START_DATE,D_END_DATE,N_STATUS,C_CUST_NO,C_CUST_NAME ");
            strSql.Append(" FROM TB_STD_CONFIG ");
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
            strSql.Append("select count(1) FROM TB_STD_CONFIG ");
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
            strSql.Append(")AS Row, T.*  from TB_STD_CONFIG T ");
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
        /// 获取自由项列表
        /// </summary>
        /// <param name="strgz">钢种</param>
        /// <param name="iType">1：自由项1，2：自由项2</param>
        /// <returns></returns>
        public DataSet GetZYX(string strgz, int iType)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" SELECT N.DOCNAME  FROM XGERP50.BD_DEFDOCLIST@CAP_ERP M, XGERP50.BD_DEFDOC@CAP_ERP N  WHERE M.PK_DEFDOCLIST = N.PK_DEFDOCLIST AND (N.SEALFLAG = 'N' OR N.SEALFLAG IS NULL)  ");

            if (strgz.Trim() != "")
            {
                strSql.Append(" and  N.DOCNAME like '%" + strgz + "%'");
            }
            if (iType == 1)
            {
                strSql.Append(" AND M.DOCLISTNAME LIKE '%CPBZ%' ");//自由项1
            }
            else
            {
                strSql.Append(" AND M.DOCLISTNAME LIKE '%JSYQ%' ");//自由项2
            }
            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string grd, string xy, string zxbz, string lgjh)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_STD_ID,C_CUST_TECH_PROT,C_ZYX1,C_ZYX2,C_STL_GRD,C_STD_CODE,C_STEEL_SIGN,C_EMP_ID,D_MOD_DT,C_REMARK,D_START_DATE,D_END_DATE,N_STATUS,C_CUST_NO,C_CUST_NAME ");
            strSql.Append(" FROM TB_STD_CONFIG WHERE N_STATUS=1");
            if (grd.Trim() != "")
            {
                strSql.Append(" AND C_STL_GRD LIKE '%" + grd + "%' ");
            }
            if (xy.Trim() != "")
            {
                strSql.Append(" AND C_CUST_TECH_PROT LIKE '%" + xy + "%' ");
            }
            if (zxbz.Trim() != "")
            {
                strSql.Append(" AND C_STD_CODE LIKE '%" + zxbz + "%' ");
            }
            if (lgjh.Trim() != "")
            {
                strSql.Append(" AND C_STEEL_SIGN LIKE '%" + lgjh + "%' ");
            }
            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 通过钢种执行标准获取自由项
        /// </summary>
        /// <param name="grd"></param>
        /// <param name="std"></param>
        /// <returns></returns>
        public DataSet GetZYX(string grd, string std)
        {
            string sql = @"SELECT * FROM TB_STD_CONFIG TSC
                                    WHERE TSC.C_STL_GRD='" + grd + "'    AND TSC.C_STD_CODE='" + std + "'";
            return DbHelperOra.Query(sql);
        }

        /// <summary>
        /// 获取执行标准代码
        /// </summary>
        /// <param name="strFree1">自由项1</param>
        /// <param name="strFree2">自由项2</param>
        /// <returns></returns>
        public string Get_Std_Code(string strFree1, string strFree2)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT MAX(T.C_STD_CODE) FROM TB_STD_CONFIG T WHERE T.C_ZYX1='" + strFree1 + "' AND T.C_ZYX2='" + strFree2 + "' ");

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

        #endregion  ExtensionMethod
    }
}

