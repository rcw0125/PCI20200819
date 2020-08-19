using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;
namespace DAL
{
    /// <summary>
    /// 数据访问类:TB_PRO
    /// </summary>
    public partial class Dal_TB_PRO
    {
        public Dal_TB_PRO()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string C_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TB_PRO");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)         };
            parameters[0].Value = C_ID;

            return DbHelperOra.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Mod_TB_PRO model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TB_PRO(");
            strSql.Append("C_PRO_CODE,C_PRO_DESC,C_EMP_ID,C_REMARK,D_END_DATE,N_STATUS,C_PRO_ERPCODE,C_PRO_MESCODE,N_SORT)");
            strSql.Append(" values (");
            strSql.Append(":C_PRO_CODE,:C_PRO_DESC,:C_EMP_ID,:C_REMARK,:D_END_DATE,:N_STATUS,:C_PRO_ERPCODE,:C_PRO_MESCODE,:N_SORT)");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_PRO_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PRO_DESC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,200),
                    new OracleParameter(":D_END_DATE", OracleDbType.Date),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
                    new OracleParameter(":C_PRO_ERPCODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PRO_MESCODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_SORT", OracleDbType.Decimal,3)};
            parameters[0].Value = model.C_PRO_CODE;
            parameters[1].Value = model.C_PRO_DESC;
            parameters[2].Value = model.C_EMP_ID;
            parameters[3].Value = model.C_REMARK;
            parameters[4].Value = model.D_END_DATE;
            parameters[5].Value = model.N_STATUS;
            parameters[6].Value = model.C_PRO_ERPCODE;
            parameters[7].Value = model.C_PRO_MESCODE;
            parameters[8].Value = model.N_SORT;


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
        public bool Update(Mod_TB_PRO model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TB_PRO set ");
            strSql.Append("C_PRO_CODE=:C_PRO_CODE,");
            strSql.Append("C_PRO_DESC=:C_PRO_DESC,");
            strSql.Append("C_EMP_ID=:C_EMP_ID,");
            strSql.Append("D_MOD_DT=:D_MOD_DT,");
            strSql.Append("C_REMARK=:C_REMARK,");
            strSql.Append("D_START_DATE=:D_START_DATE,");
            strSql.Append("D_END_DATE=:D_END_DATE,");
            strSql.Append("N_STATUS=:N_STATUS,");
            strSql.Append("C_PRO_ERPCODE=:C_PRO_ERPCODE,");
            strSql.Append("C_PRO_MESCODE=:C_PRO_MESCODE,");
            strSql.Append("N_SORT=:N_SORT");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_PRO_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PRO_DESC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,200),
                    new OracleParameter(":D_START_DATE", OracleDbType.Date),
                    new OracleParameter(":D_END_DATE", OracleDbType.Date),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
                    new OracleParameter(":C_PRO_ERPCODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PRO_MESCODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_SORT", OracleDbType.Decimal,3),
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.C_PRO_CODE;
            parameters[1].Value = model.C_PRO_DESC;
            parameters[2].Value = model.C_EMP_ID;
            parameters[3].Value = model.D_MOD_DT;
            parameters[4].Value = model.C_REMARK;
            parameters[5].Value = model.D_START_DATE;
            parameters[6].Value = model.D_END_DATE;
            parameters[7].Value = model.N_STATUS;
            parameters[8].Value = model.C_PRO_ERPCODE;
            parameters[9].Value = model.C_PRO_MESCODE;
            parameters[10].Value = model.N_SORT;
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
            strSql.Append("delete from TB_PRO ");
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
            strSql.Append("delete from TB_PRO ");
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
        public Mod_TB_PRO GetModel(string C_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_PRO_CODE,C_PRO_DESC,C_EMP_ID,D_MOD_DT,C_REMARK,D_START_DATE,D_END_DATE,N_STATUS,C_PRO_ERPCODE,C_PRO_MESCODE,N_SORT from TB_PRO ");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)         };
            parameters[0].Value = C_ID;

            Mod_TB_PRO model = new Mod_TB_PRO();
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
        public Mod_TB_PRO DataRowToModel(DataRow row)
        {
            Mod_TB_PRO model = new Mod_TB_PRO();
            if (row != null)
            {
                if (row["C_ID"] != null)
                {
                    model.C_ID = row["C_ID"].ToString();
                }
                if (row["C_PRO_CODE"] != null)
                {
                    model.C_PRO_CODE = row["C_PRO_CODE"].ToString();
                }
                if (row["C_PRO_DESC"] != null)
                {
                    model.C_PRO_DESC = row["C_PRO_DESC"].ToString();
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
                if (row["C_PRO_ERPCODE"] != null)
                {
                    model.C_PRO_ERPCODE = row["C_PRO_ERPCODE"].ToString();
                }
                if (row["C_PRO_MESCODE"] != null)
                {
                    model.C_PRO_MESCODE = row["C_PRO_MESCODE"].ToString();
                }
                if (row["N_SORT"] != null && row["N_SORT"].ToString() != "")
                {
                    model.N_SORT = decimal.Parse(row["N_SORT"].ToString());
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
            strSql.Append("select C_ID,C_PRO_CODE,C_PRO_DESC,C_EMP_ID,D_MOD_DT,C_REMARK,D_START_DATE,D_END_DATE,N_STATUS,C_PRO_ERPCODE,C_PRO_MESCODE,N_SORT ");
            strSql.Append(" FROM TB_PRO ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append("  ORDER BY N_SORT");
            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM TB_PRO  WHERE N_STATUS=1 ");
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
            strSql.Append(")AS Row, T.*  from TB_PRO T ");
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
        /// 工序主键
        /// </summary>
        /// <param name="strProCode">工序代码</param>
        /// <returns></returns>
        public string GetIDByProCode(string strProCode)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID from TB_PRO");
            strSql.Append(" where C_PRO_CODE=:C_PRO_CODE  AND N_STATUS=1");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_PRO_CODE", OracleDbType.Varchar2,100)          };
            parameters[0].Value = strProCode;
            DataTable dt = DbHelperOra.Query(strSql.ToString(), parameters).Tables[0];
            if (dt.Rows.Count > 0)
            {
                return dt.Rows[0]["C_ID"].ToString();
            }
            else
            {
                return "";
            }

        }
        /// <summary>
        /// 根据顺序号得到一个对象实体
        /// </summary>
        public Mod_TB_PRO GetModelBySoft(string N_SORT)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_PRO_CODE,C_PRO_DESC,C_EMP_ID,D_MOD_DT,C_REMARK,D_START_DATE,D_END_DATE,N_STATUS,C_PRO_ERPCODE,C_PRO_MESCODE,N_SORT from TB_PRO ");
            strSql.Append(" where N_STATUS=1 AND N_SORT=:N_SORT ");
            OracleParameter[] parameters = {
                    new OracleParameter(":N_SORT", OracleDbType.Decimal,3)         };
            parameters[0].Value = N_SORT;

            Mod_TB_PRO model = new Mod_TB_PRO();
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
        /// 重置顺序
        /// </summary>
        public int CZSORT()
        {
            DataTable dt = GetListByStatus(1,"","").Tables[0];
            if (dt.Rows.Count>0)
            {
                int sort = 1;
                TransactionHelper.BeginTransaction();
                foreach (DataRow item in dt.Rows)
                {
                    string sql = "";
                    sql = "UPDATE TB_PRO SET N_SORT='" + sort + "' WHERE C_ID='"+ item["C_ID"]+ "' ";
                    if (TransactionHelper.ExecuteSql(sql)==1)
                    {
                        sort++;
                    }
                    else
                    {
                        TransactionHelper.RollBack();
                        return 0;
                    }
                }
            }
            TransactionHelper.Commit();
            return 1;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetListByStatus(int iStatus, string gx, string C_PRO_DESC)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_PRO_CODE,C_PRO_DESC,C_EMP_ID,D_MOD_DT,C_REMARK,D_START_DATE,D_END_DATE,DECODE(N_STATUS,1,'启用','停用') N_STATUS,C_PRO_ERPCODE,C_PRO_MESCODE,N_SORT ");
            strSql.Append(" FROM TB_PRO where 1=1");
            strSql.Append(" and N_STATUS=" + iStatus);
            if (gx.Trim() != "")
            {
                strSql.Append(" and C_PRO_CODE = '" + gx + "'");
            }
            if (C_PRO_DESC.Trim() != "")
            {
                strSql.Append(" and C_PRO_CODE in(" + C_PRO_DESC + ")");
            }
            strSql.Append("  ORDER BY N_SORT");
            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 检查是否存在重复数据
        /// </summary>
        /// <param name="strProCode">工序主键</param>
        /// <returns></returns>
        public bool ExistsByProCode(string strProCode)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TB_PRO");
            strSql.Append(" where C_PRO_CODE=:C_PRO_CODE  AND N_STATUS=1");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_PRO_CODE", OracleDbType.Varchar2,100)          };
            parameters[0].Value = strProCode;

            return DbHelperOra.Exists(strSql.ToString(), parameters);
        }



        /// <summary>
        /// 查询工序是否存在未停用的工位
        /// </summary>
        /// <param name="gxidstr">工序主键</param>
        /// <returns></returns>
        public bool ExistsNOSotpGX(string C_PRO_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TB_STA");
            strSql.Append(" where C_PRO_ID=:C_PRO_ID  AND N_STATUS=1");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_PRO_ID", OracleDbType.Varchar2,100)          };
            parameters[0].Value = C_PRO_ID;

            return DbHelperOra.Exists(strSql.ToString(), parameters);
        }
        #endregion  ExtensionMethod
    }
}

