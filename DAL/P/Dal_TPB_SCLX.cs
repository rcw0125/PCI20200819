using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;
namespace DAL
{
    /// <summary>
    /// 数据访问类:TPB_SCLX
    /// </summary>
    public partial class Dal_TPB_SCLX
    {
        public Dal_TPB_SCLX()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string C_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TPB_SCLX");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)            };
            parameters[0].Value = C_ID;

            return DbHelperOra.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Mod_TPB_SCLX model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TPB_SCLX(");
            strSql.Append("C_CC,C_ZL,C_LF,C_RH,C_EMP_ID)");
            strSql.Append(" values (");
            strSql.Append(":C_CC,:C_ZL,:C_LF,:C_RH,:C_EMP_ID)");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_CC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ZL", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_LF", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_RH", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.C_CC;
            parameters[1].Value = model.C_ZL;
            parameters[2].Value = model.C_LF;
            parameters[3].Value = model.C_RH;
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
        public bool Update(Mod_TPB_SCLX model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TPB_SCLX set ");
            strSql.Append("C_CC=:C_CC,");
            strSql.Append("C_ZL=:C_ZL,");
            strSql.Append("C_LF=:C_LF,");
            strSql.Append("C_RH=:C_RH,");
            strSql.Append("C_EMP_ID=:C_EMP_ID,");
            strSql.Append("D_MOD_DT=:D_MOD_DT");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_CC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ZL", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_LF", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_RH", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.C_CC;
            parameters[1].Value = model.C_ZL;
            parameters[2].Value = model.C_LF;
            parameters[3].Value = model.C_RH;
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
            strSql.Append("delete from TPB_SCLX ");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)            };
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
            strSql.Append("delete from TPB_SCLX ");
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
        public Mod_TPB_SCLX GetModel(string C_CC)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_CC,C_ZL,C_LF,C_RH,C_EMP_ID,D_MOD_DT from TPB_SCLX ");
            strSql.Append(" where C_CC=:C_CC ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_CC", OracleDbType.Varchar2,100)            };
            parameters[0].Value = C_CC;

            Mod_TPB_SCLX model = new Mod_TPB_SCLX();
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
        public Mod_TPB_SCLX DataRowToModel(DataRow row)
        {
            Mod_TPB_SCLX model = new Mod_TPB_SCLX();
            if (row != null)
            {
                if (row["C_ID"] != null)
                {
                    model.C_ID = row["C_ID"].ToString();
                }
                if (row["C_CC"] != null)
                {
                    model.C_CC = row["C_CC"].ToString();
                }
                if (row["C_ZL"] != null)
                {
                    model.C_ZL = row["C_ZL"].ToString();
                }
                if (row["C_LF"] != null)
                {
                    model.C_LF = row["C_LF"].ToString();
                }
                if (row["C_RH"] != null)
                {
                    model.C_RH = row["C_RH"].ToString();
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
            strSql.Append("select A.C_ID,A.C_CC,A.C_ZL,A.C_LF,A.C_RH,A.C_EMP_ID,A.D_MOD_DT,B.C_STA_CODE ");
            strSql.Append(" FROM TPB_SCLX a inner JOIN TB_STA B ON  A.C_CC=B.C_ID");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" ORDER BY B.C_STA_CODE");
            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM TPB_SCLX ");
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
            strSql.Append(")AS Row, T.*  from TPB_SCLX T ");
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
        /// 删除数据
        /// </summary>
        public bool Delete()
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from TPB_SCLX ");
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
        /// 根据工序检测是否有新加工位
        /// </summary>
        /// <param name="pro">工序</param>
        /// <returns></returns>
        public DataSet CKGW(string pro)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID ");
            strSql.Append(" FROM TB_STA WHERE C_PRO_ID='"+ pro + "' AND  C_ID NOT IN(SELECT C_CC C_ID FROM TPB_SCLX)");
            return DbHelperOra.Query(strSql.ToString());
        }
        #endregion  ExtensionMethod
    }
}
