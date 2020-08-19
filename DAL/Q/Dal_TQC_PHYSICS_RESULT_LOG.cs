using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;
using System.Collections;

namespace DAL
{
    /// <summary>
    /// 数据访问类:TQC_PHYSICS_RESULT_LOG
    /// </summary>
    public partial class Dal_TQC_PHYSICS_RESULT_LOG
    {
        public Dal_TQC_PHYSICS_RESULT_LOG()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string C_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TQC_PHYSICS_RESULT_LOG");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)         };
            parameters[0].Value = C_ID;

            return DbHelperOra.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Mod_TQC_PHYSICS_RESULT_LOG model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TQC_PHYSICS_RESULT_LOG(");
            strSql.Append("C_PHYSICS_GROUP_ID,C_PRESENT_SAMPLES_ID,C_CHARACTER_ID,C_CHARACTER_CODE,C_CHARACTER_NAME,C_VALUE,N_STATUS,C_REMARK,C_EMP_ID,N_SPLIT,N_TYPE,C_CHECK_STATE,C_TICK_NO,C_GROUP,C_EDIT_NUM)");
            strSql.Append(" values (");
            strSql.Append(":C_PHYSICS_GROUP_ID,:C_PRESENT_SAMPLES_ID,:C_CHARACTER_ID,:C_CHARACTER_CODE,:C_CHARACTER_NAME,:C_VALUE,:N_STATUS,:C_REMARK,:C_EMP_ID,:N_SPLIT,:N_TYPE,:C_CHECK_STATE,:C_TICK_NO,:C_GROUP,:C_EDIT_NUM)");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_PHYSICS_GROUP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PRESENT_SAMPLES_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CHARACTER_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CHARACTER_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CHARACTER_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_VALUE", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_SPLIT", OracleDbType.Decimal,1),
                    new OracleParameter(":N_TYPE", OracleDbType.Decimal,1),
                    new OracleParameter(":C_CHECK_STATE", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_TICK_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_GROUP", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_EDIT_NUM", OracleDbType.Varchar2,10)};
            parameters[0].Value = model.C_PHYSICS_GROUP_ID;
            parameters[1].Value = model.C_PRESENT_SAMPLES_ID;
            parameters[2].Value = model.C_CHARACTER_ID;
            parameters[3].Value = model.C_CHARACTER_CODE;
            parameters[4].Value = model.C_CHARACTER_NAME;
            parameters[5].Value = model.C_VALUE;
            parameters[6].Value = model.N_STATUS;
            parameters[7].Value = model.C_REMARK;
            parameters[8].Value = model.C_EMP_ID;
            parameters[9].Value = model.N_SPLIT;
            parameters[10].Value = model.N_TYPE;
            parameters[11].Value = model.C_CHECK_STATE;
            parameters[12].Value = model.C_TICK_NO;
            parameters[13].Value = model.C_GROUP;
            parameters[14].Value = model.C_EDIT_NUM;

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
        /// 增加一条数据
        /// </summary>
        public bool Add_Trans(Mod_TQC_PHYSICS_RESULT_LOG model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TQC_PHYSICS_RESULT_LOG(");
            strSql.Append("C_PHYSICS_GROUP_ID,C_PRESENT_SAMPLES_ID,C_CHARACTER_ID,C_CHARACTER_CODE,C_CHARACTER_NAME,C_VALUE,N_STATUS,C_REMARK,C_EMP_ID,N_SPLIT,N_TYPE,C_CHECK_STATE,C_TICK_NO,C_GROUP,C_EDIT_NUM)");
            strSql.Append(" values (");
            strSql.Append(":C_PHYSICS_GROUP_ID,:C_PRESENT_SAMPLES_ID,:C_CHARACTER_ID,:C_CHARACTER_CODE,:C_CHARACTER_NAME,:C_VALUE,:N_STATUS,:C_REMARK,:C_EMP_ID,:N_SPLIT,:N_TYPE,:C_CHECK_STATE,:C_TICK_NO,:C_GROUP,:C_EDIT_NUM)");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_PHYSICS_GROUP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PRESENT_SAMPLES_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CHARACTER_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CHARACTER_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CHARACTER_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_VALUE", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_SPLIT", OracleDbType.Decimal,1),
                    new OracleParameter(":N_TYPE", OracleDbType.Decimal,1),
                    new OracleParameter(":C_CHECK_STATE", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_TICK_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_GROUP", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_EDIT_NUM", OracleDbType.Varchar2,10)};
            parameters[0].Value = model.C_PHYSICS_GROUP_ID;
            parameters[1].Value = model.C_PRESENT_SAMPLES_ID;
            parameters[2].Value = model.C_CHARACTER_ID;
            parameters[3].Value = model.C_CHARACTER_CODE;
            parameters[4].Value = model.C_CHARACTER_NAME;
            parameters[5].Value = model.C_VALUE;
            parameters[6].Value = model.N_STATUS;
            parameters[7].Value = model.C_REMARK;
            parameters[8].Value = model.C_EMP_ID;
            parameters[9].Value = model.N_SPLIT;
            parameters[10].Value = model.N_TYPE;
            parameters[11].Value = model.C_CHECK_STATE;
            parameters[12].Value = model.C_TICK_NO;
            parameters[13].Value = model.C_GROUP;
            parameters[14].Value = model.C_EDIT_NUM;

            int rows = TransactionHelper.ExecuteSql(strSql.ToString(), parameters);
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
        public bool Update(Mod_TQC_PHYSICS_RESULT_LOG model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TQC_PHYSICS_RESULT_LOG set ");
            strSql.Append("C_PHYSICS_GROUP_ID=:C_PHYSICS_GROUP_ID,");
            strSql.Append("C_PRESENT_SAMPLES_ID=:C_PRESENT_SAMPLES_ID,");
            strSql.Append("C_CHARACTER_ID=:C_CHARACTER_ID,");
            strSql.Append("C_CHARACTER_CODE=:C_CHARACTER_CODE,");
            strSql.Append("C_CHARACTER_NAME=:C_CHARACTER_NAME,");
            strSql.Append("C_VALUE=:C_VALUE,");
            strSql.Append("N_STATUS=:N_STATUS,");
            strSql.Append("C_REMARK=:C_REMARK,");
            strSql.Append("C_EMP_ID=:C_EMP_ID,");
            strSql.Append("D_MOD_DT=:D_MOD_DT,");
            strSql.Append("N_SPLIT=:N_SPLIT,");
            strSql.Append("N_TYPE=:N_TYPE,");
            strSql.Append("C_CHECK_STATE=:C_CHECK_STATE,");
            strSql.Append("C_TICK_NO=:C_TICK_NO,");
            strSql.Append("C_GROUP=:C_GROUP,");
            strSql.Append("C_EDIT_NUM=:C_EDIT_NUM");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_PHYSICS_GROUP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PRESENT_SAMPLES_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CHARACTER_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CHARACTER_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CHARACTER_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_VALUE", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":N_SPLIT", OracleDbType.Decimal,1),
                    new OracleParameter(":N_TYPE", OracleDbType.Decimal,1),
                    new OracleParameter(":C_CHECK_STATE", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_TICK_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_GROUP", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_EDIT_NUM", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.C_PHYSICS_GROUP_ID;
            parameters[1].Value = model.C_PRESENT_SAMPLES_ID;
            parameters[2].Value = model.C_CHARACTER_ID;
            parameters[3].Value = model.C_CHARACTER_CODE;
            parameters[4].Value = model.C_CHARACTER_NAME;
            parameters[5].Value = model.C_VALUE;
            parameters[6].Value = model.N_STATUS;
            parameters[7].Value = model.C_REMARK;
            parameters[8].Value = model.C_EMP_ID;
            parameters[9].Value = model.D_MOD_DT;
            parameters[10].Value = model.N_SPLIT;
            parameters[11].Value = model.N_TYPE;
            parameters[12].Value = model.C_CHECK_STATE;
            parameters[13].Value = model.C_TICK_NO;
            parameters[14].Value = model.C_GROUP;
            parameters[15].Value = model.C_EDIT_NUM;
            parameters[16].Value = model.C_ID;

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
            strSql.Append("delete from TQC_PHYSICS_RESULT_LOG ");
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
            strSql.Append("delete from TQC_PHYSICS_RESULT_LOG ");
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
        public Mod_TQC_PHYSICS_RESULT_LOG GetModel(string C_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_PHYSICS_GROUP_ID,C_PRESENT_SAMPLES_ID,C_CHARACTER_ID,C_CHARACTER_CODE,C_CHARACTER_NAME,C_VALUE,N_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT,N_SPLIT,N_TYPE,C_CHECK_STATE,C_TICK_NO,C_GROUP,C_EDIT_NUM from TQC_PHYSICS_RESULT_LOG ");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)         };
            parameters[0].Value = C_ID;

            Mod_TQC_PHYSICS_RESULT_LOG model = new Mod_TQC_PHYSICS_RESULT_LOG();
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
        public Mod_TQC_PHYSICS_RESULT_LOG DataRowToModel(DataRow row)
        {
            Mod_TQC_PHYSICS_RESULT_LOG model = new Mod_TQC_PHYSICS_RESULT_LOG();
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
                if (row["C_PRESENT_SAMPLES_ID"] != null)
                {
                    model.C_PRESENT_SAMPLES_ID = row["C_PRESENT_SAMPLES_ID"].ToString();
                }
                if (row["C_CHARACTER_ID"] != null)
                {
                    model.C_CHARACTER_ID = row["C_CHARACTER_ID"].ToString();
                }
                if (row["C_CHARACTER_CODE"] != null)
                {
                    model.C_CHARACTER_CODE = row["C_CHARACTER_CODE"].ToString();
                }
                if (row["C_CHARACTER_NAME"] != null)
                {
                    model.C_CHARACTER_NAME = row["C_CHARACTER_NAME"].ToString();
                }
                if (row["C_VALUE"] != null)
                {
                    model.C_VALUE = row["C_VALUE"].ToString();
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
                if (row["N_SPLIT"] != null && row["N_SPLIT"].ToString() != "")
                {
                    model.N_SPLIT = decimal.Parse(row["N_SPLIT"].ToString());
                }
                if (row["N_TYPE"] != null && row["N_TYPE"].ToString() != "")
                {
                    model.N_TYPE = decimal.Parse(row["N_TYPE"].ToString());
                }
                if (row["C_CHECK_STATE"] != null)
                {
                    model.C_CHECK_STATE = row["C_CHECK_STATE"].ToString();
                }
                if (row["C_TICK_NO"] != null)
                {
                    model.C_TICK_NO = row["C_TICK_NO"].ToString();
                }
                if (row["C_GROUP"] != null)
                {
                    model.C_GROUP = row["C_GROUP"].ToString();
                }
                if (row["C_EDIT_NUM"] != null)
                {
                    model.C_EDIT_NUM = row["C_EDIT_NUM"].ToString();
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
            strSql.Append("select C_ID,C_PHYSICS_GROUP_ID,C_PRESENT_SAMPLES_ID,C_CHARACTER_ID,C_CHARACTER_CODE,C_CHARACTER_NAME,C_VALUE,N_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT,N_SPLIT,N_TYPE,C_CHECK_STATE,C_TICK_NO,C_GROUP,C_EDIT_NUM ");
            strSql.Append(" FROM TQC_PHYSICS_RESULT_LOG ");
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
            strSql.Append("select count(1) FROM TQC_PHYSICS_RESULT_LOG ");
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
            strSql.Append(")AS Row, T.*  from TQC_PHYSICS_RESULT_LOG T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            return DbHelperOra.Query(strSql.ToString());
        }


        /// <summary>
        /// 获取最大修改次数
        /// </summary>
        /// <param name="C_PHYSICS_GROUP_ID">物理性能分组主键</param>
        /// <param name="C_PRESENT_SAMPLES_ID">TQC_PHYSICS_RESULT_main主键</param>
        /// <returns></returns>
        public int Get_Max_EditNum(string C_PHYSICS_GROUP_ID, string C_PRESENT_SAMPLES_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select max(to_number(C_EDIT_NUM)) FROM TQC_PHYSICS_RESULT_LOG where C_PHYSICS_GROUP_ID='" + C_PHYSICS_GROUP_ID + "' and C_PRESENT_SAMPLES_ID='" + C_PRESENT_SAMPLES_ID + "' ");

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

        #endregion  ExtensionMethod
    }
}

