using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;
namespace DAL
{
    /// <summary>
    /// 数据访问类:TPB_ROLLXM
    /// </summary>
    public partial class Dal_TPB_ROLLXM
    {
        public Dal_TPB_ROLLXM()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string C_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TPB_ROLLXM");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)            };
            parameters[0].Value = C_ID;

            return DbHelperOra.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Mod_TPB_ROLLXM model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TPB_ROLLXM(");
            strSql.Append("C_STL_GRD,C_STD_CODE,C_XMFS,N_SFXMHPWTS,C_REMARK,C_EMP_ID,D_MOD_DT,C_SPEC_STR,N_SFXMQPWTS)");
            strSql.Append(" values (");
            strSql.Append(":C_STL_GRD,:C_STD_CODE,:C_XMFS,:N_SFXMHPWTS,:C_REMARK,:C_EMP_ID,:D_MOD_DT,:C_SPEC_STR,:N_SFXMQPWTS)");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_STL_GRD", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STD_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_XMFS", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_SFXMHPWTS", OracleDbType.Int16,1),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,200),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":C_SPEC_STR", OracleDbType.Varchar2,500),
                    new OracleParameter(":N_SFXMQPWTS", OracleDbType.Int16,1)};
            parameters[0].Value = model.C_STL_GRD;
            parameters[1].Value = model.C_STD_CODE;
            parameters[2].Value = model.C_XMFS;
            parameters[3].Value = model.N_SFXMHPWTS;
            parameters[4].Value = model.C_REMARK;
            parameters[5].Value = model.C_EMP_ID;
            parameters[6].Value = model.D_MOD_DT;
            parameters[7].Value = model.C_SPEC_STR;
            parameters[8].Value = model.N_SFXMQPWTS;

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
        public bool Update(Mod_TPB_ROLLXM model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TPB_ROLLXM set ");
            strSql.Append("C_STL_GRD=:C_STL_GRD,");
            strSql.Append("C_STD_CODE=:C_STD_CODE,");
            strSql.Append("C_XMFS=:C_XMFS,");
            strSql.Append("N_SFXMHPWTS=:N_SFXMHPWTS,");
            strSql.Append("C_REMARK=:C_REMARK,");
            strSql.Append("C_EMP_ID=:C_EMP_ID,");
            strSql.Append("D_MOD_DT=:D_MOD_DT,");
            strSql.Append("C_SPEC_STR=:C_SPEC_STR,");
            strSql.Append("N_SFXMQPWTS=:N_SFXMQPWTS");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_STL_GRD", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STD_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_XMFS", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_SFXMHPWTS", OracleDbType.Int16,1),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,200),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":C_SPEC_STR", OracleDbType.Varchar2,500),
                    new OracleParameter(":N_SFXMQPWTS", OracleDbType.Int16,1),
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.C_STL_GRD;
            parameters[1].Value = model.C_STD_CODE;
            parameters[2].Value = model.C_XMFS;
            parameters[3].Value = model.N_SFXMHPWTS;
            parameters[4].Value = model.C_REMARK;
            parameters[5].Value = model.C_EMP_ID;
            parameters[6].Value = model.D_MOD_DT;
            parameters[7].Value = model.C_SPEC_STR;
            parameters[8].Value = model.N_SFXMQPWTS;
            parameters[9].Value = model.C_ID;

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
            strSql.Append("delete from TPB_ROLLXM ");
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
            strSql.Append("delete from TPB_ROLLXM ");
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
        public Mod_TPB_ROLLXM GetModel(string C_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_STL_GRD,C_STD_CODE,C_XMFS,N_SFXMHPWTS,C_REMARK,C_EMP_ID,D_MOD_DT,C_SPEC_STR,N_SFXMQPWTS from TPB_ROLLXM ");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)            };
            parameters[0].Value = C_ID;

            Mod_TPB_ROLLXM model = new Mod_TPB_ROLLXM();
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
        public Mod_TPB_ROLLXM DataRowToModel(DataRow row)
        {
            Mod_TPB_ROLLXM model = new Mod_TPB_ROLLXM();
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
                if (row["C_XMFS"] != null)
                {
                    model.C_XMFS = row["C_XMFS"].ToString();
                }
                if (row["N_SFXMHPWTS"] != null && row["N_SFXMHPWTS"].ToString() != "")
                {
                    model.N_SFXMHPWTS = decimal.Parse(row["N_SFXMHPWTS"].ToString());
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
                if (row["C_SPEC_STR"] != null)
                {
                    model.C_SPEC_STR = row["C_SPEC_STR"].ToString();
                }
                if (row["N_SFXMQPWTS"] != null && row["N_SFXMQPWTS"].ToString() != "")
                {
                    model.N_SFXMQPWTS = decimal.Parse(row["N_SFXMQPWTS"].ToString());
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
            strSql.Append("select C_ID,C_STL_GRD,C_STD_CODE,C_XMFS,N_SFXMHPWTS,C_REMARK,C_EMP_ID,D_MOD_DT,C_SPEC_STR,N_SFXMQPWTS ");
            strSql.Append(" FROM TPB_ROLLXM ");
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
            strSql.Append("select count(1) FROM TPB_ROLLXM ");
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
            strSql.Append(")AS Row, T.*  from TPB_ROLLXM T ");
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
        /// 判断是否存在该数据
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public int SFCF(Mod_TPB_ROLLXM model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM TPB_ROLLXM ");
            strSql.Append(" WHERE C_STL_GRD='" + model.C_STL_GRD + "'");
            strSql.Append(" AND C_STD_CODE='" + model.C_STD_CODE + "'");
            strSql.Append(" AND C_SPEC_STR LIKE '%" + model.C_SPEC_STR + "%'");
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
        /// 根据钢种规格获取数据列表
        /// </summary>
        /// <param name="grd">钢种</param>
        /// <param name="std">执行标准</param>
        /// <returns></returns>
        public DataSet GetList(string grd, string std)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_STL_GRD,C_STD_CODE,C_XMFS,DECODE(N_SFXMHPWTS,1,'是','否') N_SFXMHPWTS,C_REMARK,C_EMP_ID,D_MOD_DT,C_SPEC_STR,DECODE(N_SFXMQPWTS,1,'是','否') N_SFXMQPWTS ");
            strSql.Append(" FROM TPB_ROLLXM WHERE 1=1 ");
            if (grd.Trim() != "")
            {
                strSql.Append(" AND C_STL_GRD LIKE'%" + grd + "%'");
            }
            if (std.Trim() != "")
            {
                strSql.Append(" AND C_STD_CODE LIKE'%" + std + "%'");
            }
            return DbHelperOra.Query(strSql.ToString());
        }
        #endregion  ExtensionMethod
    }
}
