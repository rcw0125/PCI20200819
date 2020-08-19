using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;
namespace DAL
{
    /// <summary>
    /// 数据访问类:TB_LG_PLAN_EDIT_LOG
    /// </summary>
    public partial class Dal_TB_LG_PLAN_EDIT_LOG
    {
        public Dal_TB_LG_PLAN_EDIT_LOG()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string C_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TB_LG_PLAN_EDIT_LOG");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)         };
            parameters[0].Value = C_ID;

            return DbHelperOra.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Mod_TB_LG_PLAN_EDIT_LOG model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TB_LG_PLAN_EDIT_LOG(");
            strSql.Append("C_STOVE,C_ORDER_ID_BEFORE,C_STL_GRD_BEFORE,C_STD_CODE_BEFORE,C_SLAB_SIZE_BEFORE,C_LENGTH_BEFORE,C_MAT_CODE_BEFORE,C_ZL_DESC_BEFORE,C_LF_DESC_BEFORE,C_RH_DESC_BEFORE,C_CC_DESC_BEFORE,C_ORDER_ID_AFTER,C_STL_GRD_AFTER,C_STD_CODE_AFTER,C_SLAB_SIZE_AFTER,C_LENGTH_AFTER,C_MAT_CODE_AFTER,C_ZL_DESC_AFTER,C_LF_DESC_AFTER,C_RH_DESC_AFTER,C_CC_DESC_AFTER,C_EMP_ID,C_EMP_NAME,D_MOD_DT,C_REASON)");
            strSql.Append(" values (");
            strSql.Append(":C_STOVE,:C_ORDER_ID_BEFORE,:C_STL_GRD_BEFORE,:C_STD_CODE_BEFORE,:C_SLAB_SIZE_BEFORE,:C_LENGTH_BEFORE,:C_MAT_CODE_BEFORE,:C_ZL_DESC_BEFORE,:C_LF_DESC_BEFORE,:C_RH_DESC_BEFORE,:C_CC_DESC_BEFORE,:C_ORDER_ID_AFTER,:C_STL_GRD_AFTER,:C_STD_CODE_AFTER,:C_SLAB_SIZE_AFTER,:C_LENGTH_AFTER,:C_MAT_CODE_AFTER,:C_ZL_DESC_AFTER,:C_LF_DESC_AFTER,:C_RH_DESC_AFTER,:C_CC_DESC_AFTER,:C_EMP_ID,:C_EMP_NAME,:D_MOD_DT,:C_REASON)");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_STOVE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ORDER_ID_BEFORE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STL_GRD_BEFORE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STD_CODE_BEFORE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SLAB_SIZE_BEFORE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_LENGTH_BEFORE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MAT_CODE_BEFORE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ZL_DESC_BEFORE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_LF_DESC_BEFORE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_RH_DESC_BEFORE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CC_DESC_BEFORE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ORDER_ID_AFTER", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STL_GRD_AFTER", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STD_CODE_AFTER", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SLAB_SIZE_AFTER", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_LENGTH_AFTER", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MAT_CODE_AFTER", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ZL_DESC_AFTER", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_LF_DESC_AFTER", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_RH_DESC_AFTER", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CC_DESC_AFTER", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_EMP_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":C_REASON", OracleDbType.Varchar2,500)};
            parameters[0].Value = model.C_STOVE;
            parameters[1].Value = model.C_ORDER_ID_BEFORE;
            parameters[2].Value = model.C_STL_GRD_BEFORE;
            parameters[3].Value = model.C_STD_CODE_BEFORE;
            parameters[4].Value = model.C_SLAB_SIZE_BEFORE;
            parameters[5].Value = model.C_LENGTH_BEFORE;
            parameters[6].Value = model.C_MAT_CODE_BEFORE;
            parameters[7].Value = model.C_ZL_DESC_BEFORE;
            parameters[8].Value = model.C_LF_DESC_BEFORE;
            parameters[9].Value = model.C_RH_DESC_BEFORE;
            parameters[10].Value = model.C_CC_DESC_BEFORE;
            parameters[11].Value = model.C_ORDER_ID_AFTER;
            parameters[12].Value = model.C_STL_GRD_AFTER;
            parameters[13].Value = model.C_STD_CODE_AFTER;
            parameters[14].Value = model.C_SLAB_SIZE_AFTER;
            parameters[15].Value = model.C_LENGTH_AFTER;
            parameters[16].Value = model.C_MAT_CODE_AFTER;
            parameters[17].Value = model.C_ZL_DESC_AFTER;
            parameters[18].Value = model.C_LF_DESC_AFTER;
            parameters[19].Value = model.C_RH_DESC_AFTER;
            parameters[20].Value = model.C_CC_DESC_AFTER;
            parameters[21].Value = model.C_EMP_ID;
            parameters[22].Value = model.C_EMP_NAME;
            parameters[23].Value = model.D_MOD_DT;
            parameters[24].Value = model.C_REASON;

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
        public bool Add_Trans(Mod_TB_LG_PLAN_EDIT_LOG model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TB_LG_PLAN_EDIT_LOG(");
            strSql.Append("C_STOVE,C_ORDER_ID_BEFORE,C_STL_GRD_BEFORE,C_STD_CODE_BEFORE,C_SLAB_SIZE_BEFORE,C_LENGTH_BEFORE,C_MAT_CODE_BEFORE,C_ZL_DESC_BEFORE,C_LF_DESC_BEFORE,C_RH_DESC_BEFORE,C_CC_DESC_BEFORE,C_ORDER_ID_AFTER,C_STL_GRD_AFTER,C_STD_CODE_AFTER,C_SLAB_SIZE_AFTER,C_LENGTH_AFTER,C_MAT_CODE_AFTER,C_ZL_DESC_AFTER,C_LF_DESC_AFTER,C_RH_DESC_AFTER,C_CC_DESC_AFTER,C_EMP_ID,C_EMP_NAME,D_MOD_DT,C_REASON)");
            strSql.Append(" values (");
            strSql.Append(":C_STOVE,:C_ORDER_ID_BEFORE,:C_STL_GRD_BEFORE,:C_STD_CODE_BEFORE,:C_SLAB_SIZE_BEFORE,:C_LENGTH_BEFORE,:C_MAT_CODE_BEFORE,:C_ZL_DESC_BEFORE,:C_LF_DESC_BEFORE,:C_RH_DESC_BEFORE,:C_CC_DESC_BEFORE,:C_ORDER_ID_AFTER,:C_STL_GRD_AFTER,:C_STD_CODE_AFTER,:C_SLAB_SIZE_AFTER,:C_LENGTH_AFTER,:C_MAT_CODE_AFTER,:C_ZL_DESC_AFTER,:C_LF_DESC_AFTER,:C_RH_DESC_AFTER,:C_CC_DESC_AFTER,:C_EMP_ID,:C_EMP_NAME,:D_MOD_DT,:C_REASON)");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_STOVE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ORDER_ID_BEFORE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STL_GRD_BEFORE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STD_CODE_BEFORE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SLAB_SIZE_BEFORE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_LENGTH_BEFORE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MAT_CODE_BEFORE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ZL_DESC_BEFORE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_LF_DESC_BEFORE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_RH_DESC_BEFORE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CC_DESC_BEFORE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ORDER_ID_AFTER", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STL_GRD_AFTER", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STD_CODE_AFTER", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SLAB_SIZE_AFTER", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_LENGTH_AFTER", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MAT_CODE_AFTER", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ZL_DESC_AFTER", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_LF_DESC_AFTER", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_RH_DESC_AFTER", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CC_DESC_AFTER", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_EMP_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":C_REASON", OracleDbType.Varchar2,500)};
            parameters[0].Value = model.C_STOVE;
            parameters[1].Value = model.C_ORDER_ID_BEFORE;
            parameters[2].Value = model.C_STL_GRD_BEFORE;
            parameters[3].Value = model.C_STD_CODE_BEFORE;
            parameters[4].Value = model.C_SLAB_SIZE_BEFORE;
            parameters[5].Value = model.C_LENGTH_BEFORE;
            parameters[6].Value = model.C_MAT_CODE_BEFORE;
            parameters[7].Value = model.C_ZL_DESC_BEFORE;
            parameters[8].Value = model.C_LF_DESC_BEFORE;
            parameters[9].Value = model.C_RH_DESC_BEFORE;
            parameters[10].Value = model.C_CC_DESC_BEFORE;
            parameters[11].Value = model.C_ORDER_ID_AFTER;
            parameters[12].Value = model.C_STL_GRD_AFTER;
            parameters[13].Value = model.C_STD_CODE_AFTER;
            parameters[14].Value = model.C_SLAB_SIZE_AFTER;
            parameters[15].Value = model.C_LENGTH_AFTER;
            parameters[16].Value = model.C_MAT_CODE_AFTER;
            parameters[17].Value = model.C_ZL_DESC_AFTER;
            parameters[18].Value = model.C_LF_DESC_AFTER;
            parameters[19].Value = model.C_RH_DESC_AFTER;
            parameters[20].Value = model.C_CC_DESC_AFTER;
            parameters[21].Value = model.C_EMP_ID;
            parameters[22].Value = model.C_EMP_NAME;
            parameters[23].Value = model.D_MOD_DT;
            parameters[24].Value = model.C_REASON;

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
        public bool Update(Mod_TB_LG_PLAN_EDIT_LOG model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TB_LG_PLAN_EDIT_LOG set ");
            strSql.Append("C_STOVE=:C_STOVE,");
            strSql.Append("C_ORDER_ID_BEFORE=:C_ORDER_ID_BEFORE,");
            strSql.Append("C_STL_GRD_BEFORE=:C_STL_GRD_BEFORE,");
            strSql.Append("C_STD_CODE_BEFORE=:C_STD_CODE_BEFORE,");
            strSql.Append("C_SLAB_SIZE_BEFORE=:C_SLAB_SIZE_BEFORE,");
            strSql.Append("C_LENGTH_BEFORE=:C_LENGTH_BEFORE,");
            strSql.Append("C_MAT_CODE_BEFORE=:C_MAT_CODE_BEFORE,");
            strSql.Append("C_ZL_DESC_BEFORE=:C_ZL_DESC_BEFORE,");
            strSql.Append("C_LF_DESC_BEFORE=:C_LF_DESC_BEFORE,");
            strSql.Append("C_RH_DESC_BEFORE=:C_RH_DESC_BEFORE,");
            strSql.Append("C_CC_DESC_BEFORE=:C_CC_DESC_BEFORE,");
            strSql.Append("C_ORDER_ID_AFTER=:C_ORDER_ID_AFTER,");
            strSql.Append("C_STL_GRD_AFTER=:C_STL_GRD_AFTER,");
            strSql.Append("C_STD_CODE_AFTER=:C_STD_CODE_AFTER,");
            strSql.Append("C_SLAB_SIZE_AFTER=:C_SLAB_SIZE_AFTER,");
            strSql.Append("C_LENGTH_AFTER=:C_LENGTH_AFTER,");
            strSql.Append("C_MAT_CODE_AFTER=:C_MAT_CODE_AFTER,");
            strSql.Append("C_ZL_DESC_AFTER=:C_ZL_DESC_AFTER,");
            strSql.Append("C_LF_DESC_AFTER=:C_LF_DESC_AFTER,");
            strSql.Append("C_RH_DESC_AFTER=:C_RH_DESC_AFTER,");
            strSql.Append("C_CC_DESC_AFTER=:C_CC_DESC_AFTER,");
            strSql.Append("C_EMP_ID=:C_EMP_ID,");
            strSql.Append("C_EMP_NAME=:C_EMP_NAME,");
            strSql.Append("D_MOD_DT=:D_MOD_DT,");
            strSql.Append("C_REASON=:C_REASON");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_STOVE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ORDER_ID_BEFORE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STL_GRD_BEFORE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STD_CODE_BEFORE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SLAB_SIZE_BEFORE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_LENGTH_BEFORE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MAT_CODE_BEFORE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ZL_DESC_BEFORE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_LF_DESC_BEFORE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_RH_DESC_BEFORE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CC_DESC_BEFORE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ORDER_ID_AFTER", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STL_GRD_AFTER", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STD_CODE_AFTER", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SLAB_SIZE_AFTER", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_LENGTH_AFTER", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MAT_CODE_AFTER", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ZL_DESC_AFTER", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_LF_DESC_AFTER", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_RH_DESC_AFTER", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CC_DESC_AFTER", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_EMP_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":C_REASON", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.C_STOVE;
            parameters[1].Value = model.C_ORDER_ID_BEFORE;
            parameters[2].Value = model.C_STL_GRD_BEFORE;
            parameters[3].Value = model.C_STD_CODE_BEFORE;
            parameters[4].Value = model.C_SLAB_SIZE_BEFORE;
            parameters[5].Value = model.C_LENGTH_BEFORE;
            parameters[6].Value = model.C_MAT_CODE_BEFORE;
            parameters[7].Value = model.C_ZL_DESC_BEFORE;
            parameters[8].Value = model.C_LF_DESC_BEFORE;
            parameters[9].Value = model.C_RH_DESC_BEFORE;
            parameters[10].Value = model.C_CC_DESC_BEFORE;
            parameters[11].Value = model.C_ORDER_ID_AFTER;
            parameters[12].Value = model.C_STL_GRD_AFTER;
            parameters[13].Value = model.C_STD_CODE_AFTER;
            parameters[14].Value = model.C_SLAB_SIZE_AFTER;
            parameters[15].Value = model.C_LENGTH_AFTER;
            parameters[16].Value = model.C_MAT_CODE_AFTER;
            parameters[17].Value = model.C_ZL_DESC_AFTER;
            parameters[18].Value = model.C_LF_DESC_AFTER;
            parameters[19].Value = model.C_RH_DESC_AFTER;
            parameters[20].Value = model.C_CC_DESC_AFTER;
            parameters[21].Value = model.C_EMP_ID;
            parameters[22].Value = model.C_EMP_NAME;
            parameters[23].Value = model.D_MOD_DT;
            parameters[24].Value = model.C_REASON;
            parameters[25].Value = model.C_ID;

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
            strSql.Append("delete from TB_LG_PLAN_EDIT_LOG ");
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
            strSql.Append("delete from TB_LG_PLAN_EDIT_LOG ");
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
        public Mod_TB_LG_PLAN_EDIT_LOG GetModel(string C_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_STOVE,C_ORDER_ID_BEFORE,C_STL_GRD_BEFORE,C_STD_CODE_BEFORE,C_SLAB_SIZE_BEFORE,C_LENGTH_BEFORE,C_MAT_CODE_BEFORE,C_ZL_DESC_BEFORE,C_LF_DESC_BEFORE,C_RH_DESC_BEFORE,C_CC_DESC_BEFORE,C_ORDER_ID_AFTER,C_STL_GRD_AFTER,C_STD_CODE_AFTER,C_SLAB_SIZE_AFTER,C_LENGTH_AFTER,C_MAT_CODE_AFTER,C_ZL_DESC_AFTER,C_LF_DESC_AFTER,C_RH_DESC_AFTER,C_CC_DESC_AFTER,C_EMP_ID,C_EMP_NAME,D_MOD_DT,C_REASON from TB_LG_PLAN_EDIT_LOG ");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)         };
            parameters[0].Value = C_ID;

            Mod_TB_LG_PLAN_EDIT_LOG model = new Mod_TB_LG_PLAN_EDIT_LOG();
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
        public Mod_TB_LG_PLAN_EDIT_LOG DataRowToModel(DataRow row)
        {
            Mod_TB_LG_PLAN_EDIT_LOG model = new Mod_TB_LG_PLAN_EDIT_LOG();
            if (row != null)
            {
                if (row["C_ID"] != null)
                {
                    model.C_ID = row["C_ID"].ToString();
                }
                if (row["C_STOVE"] != null)
                {
                    model.C_STOVE = row["C_STOVE"].ToString();
                }
                if (row["C_ORDER_ID_BEFORE"] != null)
                {
                    model.C_ORDER_ID_BEFORE = row["C_ORDER_ID_BEFORE"].ToString();
                }
                if (row["C_STL_GRD_BEFORE"] != null)
                {
                    model.C_STL_GRD_BEFORE = row["C_STL_GRD_BEFORE"].ToString();
                }
                if (row["C_STD_CODE_BEFORE"] != null)
                {
                    model.C_STD_CODE_BEFORE = row["C_STD_CODE_BEFORE"].ToString();
                }
                if (row["C_SLAB_SIZE_BEFORE"] != null)
                {
                    model.C_SLAB_SIZE_BEFORE = row["C_SLAB_SIZE_BEFORE"].ToString();
                }
                if (row["C_LENGTH_BEFORE"] != null)
                {
                    model.C_LENGTH_BEFORE = row["C_LENGTH_BEFORE"].ToString();
                }
                if (row["C_MAT_CODE_BEFORE"] != null)
                {
                    model.C_MAT_CODE_BEFORE = row["C_MAT_CODE_BEFORE"].ToString();
                }
                if (row["C_ZL_DESC_BEFORE"] != null)
                {
                    model.C_ZL_DESC_BEFORE = row["C_ZL_DESC_BEFORE"].ToString();
                }
                if (row["C_LF_DESC_BEFORE"] != null)
                {
                    model.C_LF_DESC_BEFORE = row["C_LF_DESC_BEFORE"].ToString();
                }
                if (row["C_RH_DESC_BEFORE"] != null)
                {
                    model.C_RH_DESC_BEFORE = row["C_RH_DESC_BEFORE"].ToString();
                }
                if (row["C_CC_DESC_BEFORE"] != null)
                {
                    model.C_CC_DESC_BEFORE = row["C_CC_DESC_BEFORE"].ToString();
                }
                if (row["C_ORDER_ID_AFTER"] != null)
                {
                    model.C_ORDER_ID_AFTER = row["C_ORDER_ID_AFTER"].ToString();
                }
                if (row["C_STL_GRD_AFTER"] != null)
                {
                    model.C_STL_GRD_AFTER = row["C_STL_GRD_AFTER"].ToString();
                }
                if (row["C_STD_CODE_AFTER"] != null)
                {
                    model.C_STD_CODE_AFTER = row["C_STD_CODE_AFTER"].ToString();
                }
                if (row["C_SLAB_SIZE_AFTER"] != null)
                {
                    model.C_SLAB_SIZE_AFTER = row["C_SLAB_SIZE_AFTER"].ToString();
                }
                if (row["C_LENGTH_AFTER"] != null)
                {
                    model.C_LENGTH_AFTER = row["C_LENGTH_AFTER"].ToString();
                }
                if (row["C_MAT_CODE_AFTER"] != null)
                {
                    model.C_MAT_CODE_AFTER = row["C_MAT_CODE_AFTER"].ToString();
                }
                if (row["C_ZL_DESC_AFTER"] != null)
                {
                    model.C_ZL_DESC_AFTER = row["C_ZL_DESC_AFTER"].ToString();
                }
                if (row["C_LF_DESC_AFTER"] != null)
                {
                    model.C_LF_DESC_AFTER = row["C_LF_DESC_AFTER"].ToString();
                }
                if (row["C_RH_DESC_AFTER"] != null)
                {
                    model.C_RH_DESC_AFTER = row["C_RH_DESC_AFTER"].ToString();
                }
                if (row["C_CC_DESC_AFTER"] != null)
                {
                    model.C_CC_DESC_AFTER = row["C_CC_DESC_AFTER"].ToString();
                }
                if (row["C_EMP_ID"] != null)
                {
                    model.C_EMP_ID = row["C_EMP_ID"].ToString();
                }
                if (row["C_EMP_NAME"] != null)
                {
                    model.C_EMP_NAME = row["C_EMP_NAME"].ToString();
                }
                if (row["D_MOD_DT"] != null && row["D_MOD_DT"].ToString() != "")
                {
                    model.D_MOD_DT = DateTime.Parse(row["D_MOD_DT"].ToString());
                }
                if (row["C_REASON"] != null)
                {
                    model.C_REASON = row["C_REASON"].ToString();
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
            strSql.Append("select C_ID,C_STOVE,C_ORDER_ID_BEFORE,C_STL_GRD_BEFORE,C_STD_CODE_BEFORE,C_SLAB_SIZE_BEFORE,C_LENGTH_BEFORE,C_MAT_CODE_BEFORE,C_ZL_DESC_BEFORE,C_LF_DESC_BEFORE,C_RH_DESC_BEFORE,C_CC_DESC_BEFORE,C_ORDER_ID_AFTER,C_STL_GRD_AFTER,C_STD_CODE_AFTER,C_SLAB_SIZE_AFTER,C_LENGTH_AFTER,C_MAT_CODE_AFTER,C_ZL_DESC_AFTER,C_LF_DESC_AFTER,C_RH_DESC_AFTER,C_CC_DESC_AFTER,C_EMP_ID,C_EMP_NAME,D_MOD_DT,C_REASON ");
            strSql.Append(" FROM TB_LG_PLAN_EDIT_LOG ");
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
            strSql.Append("select count(1) FROM TB_LG_PLAN_EDIT_LOG ");
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
            strSql.Append(")AS Row, T.*  from TB_LG_PLAN_EDIT_LOG T ");
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
        /// 获得数据列表
        /// </summary>
        public DataSet Get_List(string C_STOVE, string strTime1, string strTime2)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_STOVE,C_ORDER_ID_BEFORE,C_STL_GRD_BEFORE,C_STD_CODE_BEFORE,C_SLAB_SIZE_BEFORE,C_LENGTH_BEFORE,C_MAT_CODE_BEFORE,C_ZL_DESC_BEFORE,C_LF_DESC_BEFORE,C_RH_DESC_BEFORE,C_CC_DESC_BEFORE,C_ORDER_ID_AFTER,C_STL_GRD_AFTER,C_STD_CODE_AFTER,C_SLAB_SIZE_AFTER,C_LENGTH_AFTER,C_MAT_CODE_AFTER,C_ZL_DESC_AFTER,C_LF_DESC_AFTER,C_RH_DESC_AFTER,C_CC_DESC_AFTER,C_EMP_ID,C_EMP_NAME,D_MOD_DT,C_REASON ");
            strSql.Append(" FROM TB_LG_PLAN_EDIT_LOG where 1=1");

            if (!string.IsNullOrEmpty(C_STOVE))
            {
                strSql.Append(" and  C_STOVE like '%" + C_STOVE + "%' ");
            }

            if (!string.IsNullOrEmpty(strTime1) && !string.IsNullOrEmpty(strTime2))
            {
                strSql.Append(" and  D_MOD_DT between to_date('" + strTime1 + "','yyyy-mm-dd hh24:mi:ss') and to_date('" + strTime2 + "','yyyy-mm-dd hh24:mi:ss') ");
            }

            strSql.Append(" order by d_mod_dt DESC ");

            return DbHelperOra.Query(strSql.ToString());
        }

        #endregion  ExtensionMethod
    }
}

