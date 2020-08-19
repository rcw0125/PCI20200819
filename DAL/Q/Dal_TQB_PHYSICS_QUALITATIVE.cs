using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;

namespace DAL
{
    /// <summary>
    /// 数据访问类:TQB_PHYSICS_QUALITATIVE
    /// </summary>
    public partial class Dal_TQB_PHYSICS_QUALITATIVE
    {
        public Dal_TQB_PHYSICS_QUALITATIVE()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string C_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TQB_PHYSICS_QUALITATIVE");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)          };
            parameters[0].Value = C_ID;

            return DbHelperOra.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Mod_TQB_PHYSICS_QUALITATIVE model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TQB_PHYSICS_QUALITATIVE(");
            strSql.Append("C_PHYSICS_GROUP_ID,C_CHARACTER_ID,C_NAME,N_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT,C_RESULT)");
            strSql.Append(" values (");
            strSql.Append(":C_PHYSICS_GROUP_ID,:C_CHARACTER_ID,:C_NAME,:N_STATUS,:C_REMARK,:C_EMP_ID,:D_MOD_DT,:C_RESULT)");
            OracleParameter[] parameters = {
                     new OracleParameter(":C_PHYSICS_GROUP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CHARACTER_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":C_RESULT", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.C_PHYSICS_GROUP_ID;
            parameters[1].Value = model.C_CHARACTER_ID;
            parameters[2].Value = model.C_NAME;
            parameters[3].Value = model.N_STATUS;
            parameters[4].Value = model.C_REMARK;
            parameters[5].Value = model.C_EMP_ID;
            parameters[6].Value = model.D_MOD_DT;
            parameters[7].Value = model.C_RESULT;
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
        public bool Update(Mod_TQB_PHYSICS_QUALITATIVE model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TQB_PHYSICS_QUALITATIVE set ");
            strSql.Append("C_PHYSICS_GROUP_ID=:C_PHYSICS_GROUP_ID,");
            strSql.Append("C_CHARACTER_ID=:C_CHARACTER_ID,");
            strSql.Append("C_NAME=:C_NAME,");
            strSql.Append("N_STATUS=:N_STATUS,");
            strSql.Append("C_REMARK=:C_REMARK,");
            strSql.Append("C_EMP_ID=:C_EMP_ID,");
            strSql.Append("D_MOD_DT=:D_MOD_DT");
            strSql.Append("C_RESULT=:C_RESULT");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_PHYSICS_GROUP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CHARACTER_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100),
            new OracleParameter(":C_RESULT", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.C_PHYSICS_GROUP_ID;
            parameters[1].Value = model.C_CHARACTER_ID;
            parameters[2].Value = model.C_NAME;
            parameters[3].Value = model.N_STATUS;
            parameters[4].Value = model.C_REMARK;
            parameters[5].Value = model.C_EMP_ID;
            parameters[6].Value = model.D_MOD_DT;
            parameters[7].Value = model.C_RESULT;
            parameters[8].Value = model.C_ID;

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
            strSql.Append("delete from TQB_PHYSICS_QUALITATIVE ");
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
            strSql.Append("delete from TQB_PHYSICS_QUALITATIVE ");
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
        public Mod_TQB_PHYSICS_QUALITATIVE GetModel(string C_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_PHYSICS_GROUP_ID,C_CHARACTER_ID,C_NAME,N_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT,C_RESULT from TQB_PHYSICS_QUALITATIVE ");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)          };
            parameters[0].Value = C_ID;

            Mod_TQB_PHYSICS_QUALITATIVE model = new Mod_TQB_PHYSICS_QUALITATIVE();
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
        public Mod_TQB_PHYSICS_QUALITATIVE DataRowToModel(DataRow row)
        {
            Mod_TQB_PHYSICS_QUALITATIVE model = new Mod_TQB_PHYSICS_QUALITATIVE();
            if (row != null)
            {
                if (row["C_ID"] != null)
                {
                    model.C_ID = row["C_ID"].ToString();
                }
                if (row["C_PHYSICS_GROUP_ID"] != null)
                {
                    model.C_PHYSICS_GROUP_ID = row["C_PHYSICS_GROUP_ID"].ToString();
                }
                if (row["C_CHARACTER_ID"] != null)
                {
                    model.C_CHARACTER_ID = row["C_CHARACTER_ID"].ToString();
                }
                if (row["C_NAME"] != null)
                {
                    model.C_NAME = row["C_NAME"].ToString();
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
                if (row["C_RESULT"] != null)
                {
                    model.C_RESULT = row["C_RESULT"].ToString();
                }
                
            }
            return model;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_PHYSICS_GROUP_ID,C_CHARACTER_ID,C_NAME,N_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT,C_RESULT ");
            strSql.Append(" FROM TQB_PHYSICS_QUALITATIVE where N_STATUS=1");
            if (strWhere != "全部")
            {
                strSql.Append(" and C_PHYSICS_GROUP_ID= '" + strWhere + "'");
            }
            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM TQB_PHYSICS_QUALITATIVE ");
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
        /// 获取定性列表
        /// </summary>
        /// <param name="C_PHYSICS_GROUP_ID">物理性能分组ID</param>
        /// <returns></returns>
        public DataSet Get_List(string C_PHYSICS_GROUP_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_PHYSICS_GROUP_ID,C_CHARACTER_ID,C_NAME,C_RESULT ");
            strSql.Append(" FROM TQB_PHYSICS_QUALITATIVE where N_STATUS=1 and C_PHYSICS_GROUP_ID='" + C_PHYSICS_GROUP_ID + "' ");

            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取定性列表
        /// </summary>
        /// <param name="C_PHYSICS_GROUP_ID">物理性能分组ID</param>
        /// <returns></returns>
        public DataSet Get_DX_List(string C_PHYSICS_GROUP_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_PHYSICS_GROUP_ID,C_CHARACTER_ID,C_NAME,N_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT,C_RESULT ");
            strSql.Append(" FROM TQB_PHYSICS_QUALITATIVE where N_STATUS=1 and C_PHYSICS_GROUP_ID='" + C_PHYSICS_GROUP_ID + "' ");

            return DbHelperOra.Query(strSql.ToString());
        }

        #endregion  BasicMethod
        #region  ExtensionMethod

        #endregion  ExtensionMethod
    }
}

