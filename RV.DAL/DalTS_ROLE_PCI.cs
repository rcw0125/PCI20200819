using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using RV.MODEL;

namespace RV.DAL
{
    /// <summary>
    /// 数据访问类:TS_ROLE_PCI
    /// </summary>
    public partial class DalTS_ROLE_PCI
    {
        public DalTS_ROLE_PCI()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string C_ROLE_NAME)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TS_ROLE_PCI");
            strSql.Append(" where N_STATUS=1 and C_ROLE_NAME=:C_ROLE_NAME ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ROLE_NAME", OracleDbType.Varchar2,20)          };
            parameters[0].Value = C_ROLE_NAME;

            return DbHelperOra.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(ModTS_ROLE_PCI model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TS_ROLE_PCI(");
            strSql.Append("C_ROLE_NAME,N_STATUS,C_REMARK,C_EMP_ID)");
            strSql.Append(" values (");
            strSql.Append(":C_ROLE_NAME,:N_STATUS,:C_REMARK,:C_EMP_ID)");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ROLE_NAME", OracleDbType.Varchar2,20),
                    new OracleParameter(":N_STATUS", OracleDbType.Int16,1),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,50),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,20)};
            parameters[0].Value = model.C_ROLE_NAME;
            parameters[1].Value = model.N_STATUS;
            parameters[2].Value = model.C_REMARK;
            parameters[3].Value = model.C_EMP_ID;

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
        public bool Update(ModTS_ROLE_PCI model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TS_ROLE_PCI set ");
            strSql.Append("C_ROLE_NAME=:C_ROLE_NAME,");
            strSql.Append("N_STATUS=:N_STATUS,");
            strSql.Append("C_REMARK=:C_REMARK,");
            strSql.Append("C_EMP_ID=:C_EMP_ID,");
            strSql.Append("D_MOD_DT=:D_MOD_DT");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ROLE_NAME", OracleDbType.Varchar2,20),
                    new OracleParameter(":N_STATUS", OracleDbType.Int16,1),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,50),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,20),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,50)};
            parameters[0].Value = model.C_ROLE_NAME;
            parameters[1].Value = model.N_STATUS;
            parameters[2].Value = model.C_REMARK;
            parameters[3].Value = model.C_EMP_ID;
            parameters[4].Value = model.D_MOD_DT;
            parameters[5].Value = model.C_ID;

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
            strSql.Append("delete from TS_ROLE_PCI ");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,50)          };
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
            strSql.Append("delete from TS_ROLE_PCI ");
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
        public ModTS_ROLE_PCI GetModel(string C_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_ROLE_NAME,N_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT from TS_ROLE_PCI ");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,50)          };
            parameters[0].Value = C_ID;

            ModTS_ROLE_PCI model = new ModTS_ROLE_PCI();
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
        public ModTS_ROLE_PCI DataRowToModel(DataRow row)
        {
            ModTS_ROLE_PCI model = new ModTS_ROLE_PCI();
            if (row != null)
            {
                if (row["C_ID"] != null)
                {
                    model.C_ID = row["C_ID"].ToString();
                }
                if (row["C_ROLE_NAME"] != null)
                {
                    model.C_ROLE_NAME = row["C_ROLE_NAME"].ToString();
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
            strSql.Append("select C_ID,C_ROLE_NAME,N_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT ");
            strSql.Append(" FROM TS_ROLE_PCI ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得角色列表
        /// </summary>
        public DataSet GetRoleList()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT TA.C_ID,TA.C_ROLE_NAME,TB.C_NAME,TA.D_MOD_DT FROM TS_ROLE_PCI TA LEFT JOIN TS_USER TB ON TA.C_EMP_ID=TB.C_ACCOUNT where ta.N_STATUS=1 and tb.n_type=3 ");

            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得角色列表
        /// </summary>
        public DataSet GetUserRoleList(string strUserID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT TA.C_ID,TA.C_ROLE_NAME,decode((select tb.c_role_id from ts_user_role_pci tb where tb.n_status=1 and tb.c_user_id='" + strUserID + "' and tb.c_role_id=ta.c_id),'','0','1')as c_checkstate FROM TS_ROLE_PCI TA where ta.N_STATUS=1 ");

            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM TS_ROLE_PCI ");
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
            strSql.Append(")AS Row, T.*  from TS_ROLE_PCI T ");
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

        #endregion  ExtensionMethod
    }
}

