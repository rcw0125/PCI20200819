using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;
namespace DAL
{
    public partial class Dal_TSC_ALLOT_LOG
    {
        public Dal_TSC_ALLOT_LOG()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string C_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TSC_ALLOT_LOG");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)            };
            parameters[0].Value = C_ID;

            return DbHelperOra.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Mod_TSC_ALLOT_LOG model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TSC_ALLOT_LOG(");
            strSql.Append("C_SLAB_MAIN_ID,N_TYPE,D_MOD_DT,C_EMP_ID,C_STA_ID,C_SLABWH_CODE,C_SLABWH_AREA_CODE,C_SLABWH_LOC_CODE,C_SLABWH_TIER_CODE,C_STL_GRD,C_SPEC,C_STD_CODE,C_MAT_CODE,C_MAT_NAME,N_LEN,C_STOVE)");
            strSql.Append(" values (");
            strSql.Append(":C_SLAB_MAIN_ID,:N_TYPE,:D_MOD_DT,:C_EMP_ID,:C_STA_ID,:C_SLABWH_CODE,:C_SLABWH_AREA_CODE,:C_SLABWH_LOC_CODE,:C_SLABWH_TIER_CODE,:C_STL_GRD,:C_SPEC,:C_STD_CODE,:C_MAT_CODE,:C_MAT_NAME,:N_LEN,:C_STOVE)");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_SLAB_MAIN_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_TYPE", OracleDbType.Decimal,4),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STA_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SLABWH_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SLABWH_AREA_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SLABWH_LOC_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SLABWH_TIER_CODE", OracleDbType.Varchar2,100) ,
                    new OracleParameter(":C_STL_GRD", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SPEC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STD_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MAT_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MAT_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_LEN", OracleDbType.Decimal,5),
                    new OracleParameter(":C_STOVE",  OracleDbType.Varchar2,100)};
            parameters[0].Value = model.C_SLAB_MAIN_ID;
            parameters[1].Value = model.N_TYPE;
            parameters[2].Value = model.D_MOD_DT;
            parameters[3].Value = model.C_EMP_ID;
            parameters[4].Value = model.C_STA_ID;
            parameters[5].Value = model.C_SLABWH_CODE;
            parameters[6].Value = model.C_SLABWH_AREA_CODE;
            parameters[7].Value = model.C_SLABWH_LOC_CODE;
            parameters[8].Value = model.C_SLABWH_TIER_CODE;
            parameters[9].Value = model.C_STL_GRD;
            parameters[10].Value = model.C_SPEC;
            parameters[11].Value = model.C_STD_CODE;
            parameters[12].Value = model.C_MAT_CODE;
            parameters[13].Value = model.C_MAT_NAME;
            parameters[14].Value = model.N_LEN;
            parameters[15].Value = model.C_STOVE;

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
        public bool Update(Mod_TSC_ALLOT_LOG model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TSC_ALLOT_LOG set ");
            strSql.Append("C_SLAB_MAIN_ID=:C_SLAB_MAIN_ID,");
            strSql.Append("N_TYPE=:N_TYPE,");
            strSql.Append("D_MOD_DT=:D_MOD_DT,");
            strSql.Append("C_EMP_ID=:C_EMP_ID,");
            strSql.Append("C_STA_ID=:C_STA_ID,");
            strSql.Append("C_SLABWH_CODE=:C_SLABWH_CODE,");
            strSql.Append("C_SLABWH_AREA_CODE=:C_SLABWH_AREA_CODE,");
            strSql.Append("C_SLABWH_LOC_CODE=:C_SLABWH_LOC_CODE,");
            strSql.Append("C_SLABWH_TIER_CODE=:C_SLABWH_TIER_CODE");
            strSql.Append("C_STL_GRD=:C_STL_GRD,");
            strSql.Append("C_SPEC=:C_SPEC,");
            strSql.Append("C_STD_CODE=:C_STD_CODE,");
            strSql.Append("C_MAT_CODE=:C_MAT_CODE,");
            strSql.Append("C_MAT_NAME=:C_MAT_NAME,");
            strSql.Append("N_LEN=:N_LEN");
            strSql.Append("C_STOVE=:C_STOVE");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_SLAB_MAIN_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_TYPE", OracleDbType.Decimal,4),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STA_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SLABWH_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SLABWH_AREA_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SLABWH_LOC_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SLABWH_TIER_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STL_GRD", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SPEC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STD_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MAT_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MAT_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_LEN", OracleDbType.Decimal,5),
                     new OracleParameter(":C_STOVE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.C_SLAB_MAIN_ID;
            parameters[1].Value = model.N_TYPE;
            parameters[2].Value = model.D_MOD_DT;
            parameters[3].Value = model.C_EMP_ID;
            parameters[4].Value = model.C_STA_ID;
            parameters[5].Value = model.C_SLABWH_CODE;
            parameters[6].Value = model.C_SLABWH_AREA_CODE;
            parameters[7].Value = model.C_SLABWH_LOC_CODE;
            parameters[8].Value = model.C_SLABWH_TIER_CODE;
            parameters[9].Value = model.C_STL_GRD;
            parameters[10].Value = model.C_SPEC;
            parameters[11].Value = model.C_STD_CODE;
            parameters[12].Value = model.C_MAT_CODE;
            parameters[13].Value = model.C_MAT_NAME;
            parameters[14].Value = model.N_LEN;
            parameters[15].Value = model.C_STOVE;
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
            strSql.Append("delete from TSC_ALLOT_LOG ");
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
            strSql.Append("delete from TSC_ALLOT_LOG ");
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
        public Mod_TSC_ALLOT_LOG GetModel(string C_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_SLAB_MAIN_ID,N_TYPE,D_MOD_DT,C_EMP_ID,C_STA_ID,C_SLABWH_CODE,C_SLABWH_AREA_CODE,C_SLABWH_LOC_CODE,C_SLABWH_TIER_CODE from TSC_ALLOT_LOG ");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)            };
            parameters[0].Value = C_ID;

            Mod_TSC_ALLOT_LOG model = new Mod_TSC_ALLOT_LOG();
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
        public Mod_TSC_ALLOT_LOG DataRowToModel(DataRow row)
        {
            Mod_TSC_ALLOT_LOG model = new Mod_TSC_ALLOT_LOG();
            if (row != null)
            {
                if (row["C_ID"] != null)
                {
                    model.C_ID = row["C_ID"].ToString();
                }
                if (row["C_SLAB_MAIN_ID"] != null)
                {
                    model.C_SLAB_MAIN_ID = row["C_SLAB_MAIN_ID"].ToString();
                }
                if (row["N_TYPE"] != null && row["N_TYPE"].ToString() != "")
                {
                    model.N_TYPE = decimal.Parse(row["N_TYPE"].ToString());
                }
                if (row["D_MOD_DT"] != null && row["D_MOD_DT"].ToString() != "")
                {
                    model.D_MOD_DT = DateTime.Parse(row["D_MOD_DT"].ToString());
                }
                if (row["C_EMP_ID"] != null)
                {
                    model.C_EMP_ID = row["C_EMP_ID"].ToString();
                }
                if (row["C_STA_ID"] != null)
                {
                    model.C_STA_ID = row["C_STA_ID"].ToString();
                }
                if (row["C_SLABWH_CODE"] != null)
                {
                    model.C_SLABWH_CODE = row["C_SLABWH_CODE"].ToString();
                }
                if (row["C_SLABWH_AREA_CODE"] != null)
                {
                    model.C_SLABWH_AREA_CODE = row["C_SLABWH_AREA_CODE"].ToString();
                }
                if (row["C_SLABWH_LOC_CODE"] != null)
                {
                    model.C_SLABWH_LOC_CODE = row["C_SLABWH_LOC_CODE"].ToString();
                }
                if (row["C_SLABWH_TIER_CODE"] != null)
                {
                    model.C_SLABWH_TIER_CODE = row["C_SLABWH_TIER_CODE"].ToString();
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
            strSql.Append("select C_ID,C_SLAB_MAIN_ID,N_TYPE,D_MOD_DT,C_EMP_ID,C_STA_ID,C_SLABWH_CODE,C_SLABWH_AREA_CODE,C_SLABWH_LOC_CODE,C_SLABWH_TIER_CODE ");
            strSql.Append(" FROM TSC_ALLOT_LOG ");
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
            strSql.Append("select count(1) FROM TSC_ALLOT_LOG ");
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
            strSql.Append(")AS Row, T.*  from TSC_ALLOT_LOG T ");
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
