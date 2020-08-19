using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;
namespace DAL
{
    /// <summary>
    /// 数据访问类:TRC_SLABWH_LOG
    /// </summary>
    public partial class Dal_TRC_SLABWH_LOG
    {
        public Dal_TRC_SLABWH_LOG()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string C_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TRC_SLABWH_LOG");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)         };
            parameters[0].Value = C_ID;

            return DbHelperOra.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Mod_TRC_SLABWH_LOG model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TRC_SLABWH_LOG(");
            strSql.Append("C_SLAB_MAIN_ID,C_MOVE_TYPE,C_SHIFT,C_GROUP,C_MAT_CODE,C_MAT_DESC,C_SLABWH_CODE_BEFORE,C_SLABWH_AREA_CODE_BEFORE,C_SLABWH_LOC_CODE_BEFORE,C_FLOOR_BEFORE,D_STORAGE_DT,C_SLABWH_CODE_AFTER,C_SLABWH_AREA_CODE_AFTER,C_FLOOR_AFTER,C_SALE_AREA,C_TRANSPORTATION,C_EMP_ID,D_MOD_DT,N_STATUS,C_SLABWH_LOC_CODE_AFTER,N_ORDER,D_ESC_DATE,D_LSC_DATE,C_COOLPIT_CODE,C_COOLPIT_AREA_CODE,C_COOLPIT_LOC_CODE,C_COOLPIT)");
            strSql.Append(" values (");
            strSql.Append(":C_SLAB_MAIN_ID,:C_MOVE_TYPE,:C_SHIFT,:C_GROUP,:C_MAT_CODE,:C_MAT_DESC,:C_SLABWH_CODE_BEFORE,:C_SLABWH_AREA_CODE_BEFORE,:C_SLABWH_LOC_CODE_BEFORE,:C_FLOOR_BEFORE,:D_STORAGE_DT,:C_SLABWH_CODE_AFTER,:C_SLABWH_AREA_CODE_AFTER,:C_FLOOR_AFTER,:C_SALE_AREA,:C_TRANSPORTATION,:C_EMP_ID,:D_MOD_DT,:N_STATUS,:C_SLABWH_LOC_CODE_AFTER,:N_ORDER,:D_ESC_DATE,:D_LSC_DATE,:C_COOLPIT_CODE,:C_COOLPIT_AREA_CODE,:C_COOLPIT_LOC_CODE,:C_COOLPIT)");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_SLAB_MAIN_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MOVE_TYPE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SHIFT", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_GROUP", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MAT_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MAT_DESC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SLABWH_CODE_BEFORE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SLABWH_AREA_CODE_BEFORE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SLABWH_LOC_CODE_BEFORE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_FLOOR_BEFORE", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_STORAGE_DT", OracleDbType.Date),
                    new OracleParameter(":C_SLABWH_CODE_AFTER", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SLABWH_AREA_CODE_AFTER", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_FLOOR_AFTER", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SALE_AREA", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_TRANSPORTATION", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
                    new OracleParameter(":C_SLABWH_LOC_CODE_AFTER", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_ORDER", OracleDbType.Decimal,3),
                    new OracleParameter(":D_ESC_DATE", OracleDbType.Date),
                    new OracleParameter(":D_LSC_DATE", OracleDbType.Date),
                    new OracleParameter(":C_COOLPIT_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_COOLPIT_AREA_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_COOLPIT_LOC_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_COOLPIT", OracleDbType.Varchar2,100),
};
            parameters[0].Value = model.C_SLAB_MAIN_ID;
            parameters[1].Value = model.C_MOVE_TYPE;
            parameters[2].Value = model.C_SHIFT;
            parameters[3].Value = model.C_GROUP;
            parameters[4].Value = model.C_MAT_CODE;
            parameters[5].Value = model.C_MAT_DESC;
            parameters[6].Value = model.C_SLABWH_CODE_BEFORE;
            parameters[7].Value = model.C_SLABWH_AREA_CODE_BEFORE;
            parameters[8].Value = model.C_SLABWH_LOC_CODE_BEFORE;
            parameters[9].Value = model.C_FLOOR_BEFORE;
            parameters[10].Value = model.D_STORAGE_DT;
            parameters[11].Value = model.C_SLABWH_CODE_AFTER;
            parameters[12].Value = model.C_SLABWH_AREA_CODE_AFTER;
            parameters[13].Value = model.C_FLOOR_AFTER;
            parameters[14].Value = model.C_SALE_AREA;
            parameters[15].Value = model.C_TRANSPORTATION;
            parameters[16].Value = model.C_EMP_ID;
            parameters[17].Value = model.D_MOD_DT;
            parameters[18].Value = model.N_STATUS;
            parameters[19].Value = model.C_SLABWH_LOC_CODE_AFTER;
            parameters[20].Value = model.N_ORDER;
            parameters[21].Value = model.D_ESC_DATE;
            parameters[22].Value = model.D_LSC_DATE;
            parameters[23].Value = model.C_COOLPIT_CODE;
            parameters[24].Value = model.C_COOLPIT_AREA_CODE;
            parameters[25].Value = model.C_COOLPIT_LOC_CODE;
            parameters[26].Value = model.C_COOLPIT;

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
        public bool Update(Mod_TRC_SLABWH_LOG model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TRC_SLABWH_LOG set ");
            strSql.Append("C_SLAB_MAIN_ID=:C_SLAB_MAIN_ID,");
            strSql.Append("C_MOVE_TYPE=:C_MOVE_TYPE,");
            strSql.Append("C_SHIFT=:C_SHIFT,");
            strSql.Append("C_GROUP=:C_GROUP,");
            strSql.Append("C_MAT_CODE=:C_MAT_CODE,");
            strSql.Append("C_MAT_DESC=:C_MAT_DESC,");
            strSql.Append("C_SLABWH_CODE_BEFORE=:C_SLABWH_CODE_BEFORE,");
            strSql.Append("C_SLABWH_AREA_CODE_BEFORE=:C_SLABWH_AREA_CODE_BEFORE,");
            strSql.Append("C_SLABWH_LOC_CODE_BEFORE=:C_SLABWH_LOC_CODE_BEFORE,");
            strSql.Append("C_FLOOR_BEFORE=:C_FLOOR_BEFORE,");
            strSql.Append("D_STORAGE_DT=:D_STORAGE_DT,");
            strSql.Append("C_SLABWH_CODE_AFTER=:C_SLABWH_CODE_AFTER,");
            strSql.Append("C_SLABWH_AREA_CODE_AFTER=:C_SLABWH_AREA_CODE_AFTER,");
            strSql.Append("C_FLOOR_AFTER=:C_FLOOR_AFTER,");
            strSql.Append("C_SALE_AREA=:C_SALE_AREA,");
            strSql.Append("C_TRANSPORTATION=:C_TRANSPORTATION,");
            strSql.Append("C_EMP_ID=:C_EMP_ID,");
            strSql.Append("D_MOD_DT=:D_MOD_DT,");
            strSql.Append("N_STATUS=:N_STATUS,");
            strSql.Append("C_SLABWH_LOC_CODE_AFTER=:C_SLABWH_LOC_CODE_AFTER,");
            strSql.Append("N_ORDER=:N_ORDER,");
            strSql.Append("D_ESC_DATE=:D_ESC_DATE,");
            strSql.Append("D_LSC_DATE=:D_LSC_DATE,");
            strSql.Append("C_COOLPIT_CODE=:C_COOLPIT_CODE,");
            strSql.Append("C_COOLPIT_AREA_CODE=:C_COOLPIT_AREA_CODE,");
            strSql.Append("C_COOLPIT_LOC_CODE=:C_COOLPIT_LOC_CODE,");
            strSql.Append("C_COOLPIT=:C_COOLPIT,");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_SLAB_MAIN_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MOVE_TYPE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SHIFT", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_GROUP", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MAT_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MAT_DESC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SLABWH_CODE_BEFORE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SLABWH_AREA_CODE_BEFORE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SLABWH_LOC_CODE_BEFORE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_FLOOR_BEFORE", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_STORAGE_DT", OracleDbType.Date),
                    new OracleParameter(":C_SLABWH_CODE_AFTER", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SLABWH_AREA_CODE_AFTER", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_FLOOR_AFTER", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SALE_AREA", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_TRANSPORTATION", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
                    new OracleParameter(":C_SLABWH_LOC_CODE_AFTER", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_ORDER", OracleDbType.Decimal,3),
                    new OracleParameter(":D_ESC_DATE", OracleDbType.Date),
                    new OracleParameter(":D_LSC_DATE", OracleDbType.Date),
                    new OracleParameter(":C_COOLPIT_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_COOLPIT_AREA_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_COOLPIT_LOC_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_COOLPIT", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.C_SLAB_MAIN_ID;
            parameters[1].Value = model.C_MOVE_TYPE;
            parameters[2].Value = model.C_SHIFT;
            parameters[3].Value = model.C_GROUP;
            parameters[4].Value = model.C_MAT_CODE;
            parameters[5].Value = model.C_MAT_DESC;
            parameters[6].Value = model.C_SLABWH_CODE_BEFORE;
            parameters[7].Value = model.C_SLABWH_AREA_CODE_BEFORE;
            parameters[8].Value = model.C_SLABWH_LOC_CODE_BEFORE;
            parameters[9].Value = model.C_FLOOR_BEFORE;
            parameters[10].Value = model.D_STORAGE_DT;
            parameters[11].Value = model.C_SLABWH_CODE_AFTER;
            parameters[12].Value = model.C_SLABWH_AREA_CODE_AFTER;
            parameters[13].Value = model.C_FLOOR_AFTER;
            parameters[14].Value = model.C_SALE_AREA;
            parameters[15].Value = model.C_TRANSPORTATION;
            parameters[16].Value = model.C_EMP_ID;
            parameters[17].Value = model.D_MOD_DT;
            parameters[18].Value = model.N_STATUS;
            parameters[19].Value = model.C_SLABWH_LOC_CODE_AFTER;
            parameters[20].Value = model.N_ORDER;
            parameters[21].Value = model.D_ESC_DATE;
            parameters[22].Value = model.D_LSC_DATE;
            parameters[23].Value = model.C_COOLPIT_CODE;
            parameters[24].Value = model.C_COOLPIT_AREA_CODE;
            parameters[25].Value = model.C_COOLPIT_LOC_CODE;
            parameters[26].Value = model.C_COOLPIT;
            parameters[27].Value = model.C_ID;

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
            strSql.Append("delete from TRC_SLABWH_LOG ");
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
            strSql.Append("delete from TRC_SLABWH_LOG ");
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
        public Mod_TRC_SLABWH_LOG GetModel(string C_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_SLAB_MAIN_ID,C_MOVE_TYPE,C_SHIFT,C_GROUP,C_MAT_CODE,C_MAT_DESC,C_SLABWH_CODE_BEFORE,C_SLABWH_AREA_CODE_BEFORE,C_SLABWH_LOC_CODE_BEFORE,C_FLOOR_BEFORE,D_STORAGE_DT,C_SLABWH_CODE_AFTER,C_SLABWH_AREA_CODE_AFTER,C_FLOOR_AFTER,C_SALE_AREA,C_TRANSPORTATION,C_EMP_ID,D_MOD_DT,N_STATUS,C_SLABWH_LOC_CODE_AFTER,N_ORDER,D_ESC_DATE,D_LSC_DATE,C_COOLPIT_CODE,C_COOLPIT_AREA_CODE,C_COOLPIT_LOC_CODE,C_COOLPIT from TRC_SLABWH_LOG ");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)         };
            parameters[0].Value = C_ID;

            Mod_TRC_SLABWH_LOG model = new Mod_TRC_SLABWH_LOG();
      
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
        public Mod_TRC_SLABWH_LOG DataRowToModel(DataRow row)
        {
            Mod_TRC_SLABWH_LOG model = new Mod_TRC_SLABWH_LOG();
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
                if (row["C_MOVE_TYPE"] != null)
                {
                    model.C_MOVE_TYPE = row["C_MOVE_TYPE"].ToString();
                }
                if (row["C_SHIFT"] != null)
                {
                    model.C_SHIFT = row["C_SHIFT"].ToString();
                }
                if (row["C_GROUP"] != null)
                {
                    model.C_GROUP = row["C_GROUP"].ToString();
                }
                if (row["C_MAT_CODE"] != null)
                {
                    model.C_MAT_CODE = row["C_MAT_CODE"].ToString();
                }
                if (row["C_MAT_DESC"] != null)
                {
                    model.C_MAT_DESC = row["C_MAT_DESC"].ToString();
                }
                if (row["C_SLABWH_CODE_BEFORE"] != null)
                {
                    model.C_SLABWH_CODE_BEFORE = row["C_SLABWH_CODE_BEFORE"].ToString();
                }
                if (row["C_SLABWH_AREA_CODE_BEFORE"] != null)
                {
                    model.C_SLABWH_AREA_CODE_BEFORE = row["C_SLABWH_AREA_CODE_BEFORE"].ToString();
                }
                if (row["C_SLABWH_LOC_CODE_BEFORE"] != null)
                {
                    model.C_SLABWH_LOC_CODE_BEFORE = row["C_SLABWH_LOC_CODE_BEFORE"].ToString();
                }
                if (row["C_FLOOR_BEFORE"] != null)
                {
                    model.C_FLOOR_BEFORE = row["C_FLOOR_BEFORE"].ToString();
                }
                if (row["D_STORAGE_DT"] != null && row["D_STORAGE_DT"].ToString() != "")
                {
                    model.D_STORAGE_DT = DateTime.Parse(row["D_STORAGE_DT"].ToString());
                }
                if (row["C_SLABWH_CODE_AFTER"] != null)
                {
                    model.C_SLABWH_CODE_AFTER = row["C_SLABWH_CODE_AFTER"].ToString();
                }
                if (row["C_SLABWH_AREA_CODE_AFTER"] != null)
                {
                    model.C_SLABWH_AREA_CODE_AFTER = row["C_SLABWH_AREA_CODE_AFTER"].ToString();
                }
                if (row["C_FLOOR_AFTER"] != null)
                {
                    model.C_FLOOR_AFTER = row["C_FLOOR_AFTER"].ToString();
                }
                if (row["C_SALE_AREA"] != null)
                {
                    model.C_SALE_AREA = row["C_SALE_AREA"].ToString();
                }
                if (row["C_TRANSPORTATION"] != null)
                {
                    model.C_TRANSPORTATION = row["C_TRANSPORTATION"].ToString();
                }
                if (row["C_EMP_ID"] != null)
                {
                    model.C_EMP_ID = row["C_EMP_ID"].ToString();
                }
                if (row["D_MOD_DT"] != null && row["D_MOD_DT"].ToString() != "")
                {
                    model.D_MOD_DT = DateTime.Parse(row["D_MOD_DT"].ToString());
                }
                if (row["N_STATUS"] != null && row["N_STATUS"].ToString() != "")
                {
                    model.N_STATUS = decimal.Parse(row["N_STATUS"].ToString());
                }
                if (row["C_SLABWH_LOC_CODE_AFTER"] != null)
                {
                    model.C_SLABWH_LOC_CODE_AFTER = row["C_SLABWH_LOC_CODE_AFTER"].ToString();
                }
                if (row["N_ORDER"] != null && row["N_ORDER"].ToString() != "")
                {
                    model.N_ORDER = decimal.Parse(row["N_ORDER"].ToString());
                }
                if (row["D_ESC_DATE"] != null && row["D_ESC_DATE"].ToString() != "")
                {
                    model.D_ESC_DATE = DateTime.Parse(row["D_ESC_DATE"].ToString());
                }
                if (row["D_LSC_DATE"] != null && row["D_LSC_DATE"].ToString() != "")
                {
                    model.D_LSC_DATE = DateTime.Parse(row["D_LSC_DATE"].ToString());
                }
                if (row["C_COOLPIT_CODE"] != null)
                {
                    model.C_COOLPIT_CODE = row["C_COOLPIT_CODE"].ToString();
                }
                if (row["C_COOLPIT_AREA_CODE"] != null)
                {
                    model.C_COOLPIT_AREA_CODE = row["C_COOLPIT_AREA_CODE"].ToString();
                }
                if (row["C_COOLPIT_LOC_CODE"] != null)
                {
                    model.C_COOLPIT_LOC_CODE = row["C_COOLPIT_LOC_CODE"].ToString();
                }
                if (row["C_COOLPIT"] != null)
                {
                    model.C_COOLPIT = row["C_COOLPIT"].ToString();
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
            strSql.Append("select C_ID,C_SLAB_MAIN_ID,C_MOVE_TYPE,C_SHIFT,C_GROUP,C_MAT_CODE,C_MAT_DESC,C_SLABWH_CODE_BEFORE,C_SLABWH_AREA_CODE_BEFORE,C_SLABWH_LOC_CODE_BEFORE,C_FLOOR_BEFORE,D_STORAGE_DT,C_SLABWH_CODE_AFTER,C_SLABWH_AREA_CODE_AFTER,C_FLOOR_AFTER,C_SALE_AREA,C_TRANSPORTATION,C_EMP_ID,D_MOD_DT,N_STATUS,C_SLABWH_LOC_CODE_AFTER,N_ORDER,D_ESC_DATE,D_LSC_DATE,C_COOLPIT_CODE,C_COOLPIT_AREA_CODE,C_COOLPIT_LOC_CODE,C_COOLPIT");
            strSql.Append(" FROM TRC_SLABWH_LOG ");
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
            strSql.Append("select count(1) FROM TRC_SLABWH_LOG ");
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
            strSql.Append(")AS Row, T.*  from TRC_SLABWH_LOG T ");
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
        public DataSet GetList(int status, string movetype, string grd, string std, string stove)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select a.C_ID,a.C_SLAB_MAIN_ID,a.C_MOVE_TYPE,a.C_SHIFT,a.C_GROUP,a.C_MAT_CODE,a.C_MAT_DESC,a.C_SLABWH_CODE_BEFORE,a.C_SLABWH_AREA_CODE_BEFORE,a.C_SLABWH_LOC_CODE_BEFORE,a.C_FLOOR_BEFORE,a.D_STORAGE_DT,a.C_SLABWH_CODE_AFTER,a.C_SLABWH_AREA_CODE_AFTER,a.C_SLABWH_LOC_CODE_AFTER,a.C_FLOOR_AFTER,a.C_SALE_AREA,a.C_TRANSPORTATION,a.C_EMP_ID,a.D_MOD_DT,a.N_STATUS,a.N_ORDER,a.D_ESC_DATE,a.D_LSC_DATE,a.C_COOLPIT_CODE,a.C_COOLPIT_AREA_CODE,a.C_COOLPIT_LOC_CODE,a.C_COOLPIT,b.C_STL_GRD,b.C_STOVE,b.C_STA_DESC,b.C_STD_CODE,b.C_SPEC,b.N_LEN,b.N_QUA,b.N_WGT ");
            strSql.Append(" FROM TRC_SLABWH_LOG a,TSC_SLAB_MAIN b Where a.C_SLAB_MAIN_ID=b.C_ID And a.N_STATUS='" + status + "' ");
            if (movetype.Trim() != "")
            {
                strSql.Append(" And a.C_MOVE_TYPE='" + movetype + "' ");
            }
            if (grd.Trim() != "")
            {
                strSql.Append(" And b.C_STL_GRD LIKE'%" + grd + "%' ");
            }
            if (stove.Trim() != "")
            {
                strSql.Append(" And b.C_STOVE  LIKE'%" + stove + "%' ");

            }
            if (std.Trim() != "")
            {
                strSql.Append(" And b.C_STD_CODE LIKE'%" + std + "%' ");
            }

            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 查询钢种记录
        /// </summary>
        public DataSet GetSLABCount(string slabid, string type)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select DISTINCT C_MOVE_TYPE FROM TRC_SLABWH_LOG ");
            if (slabid.Trim() != "")
            {
                strSql.Append(" where C_SLAB_MAIN_ID='" + slabid + "' ");
            }
            strSql.Append(" AND C_MOVE_TYPE <> '" + type + "'");
            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Upstatus(string slabid, int status, int order)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TRC_SLABWH_LOG set N_STATUS ='" + status + "' WHERE C_SLAB_MAIN_ID='" + slabid + "' ");
            if (status == 0)
            {
                if (order != 0)
                {
                    strSql.Append(" AND C_ID<>(SELECT C_ID FROM TRC_SLABWH_LOG WHERE C_SLAB_MAIN_ID='" + slabid + "'");
                    strSql.Append(" AND　N_ORDER = '" + order + "'");
                    strSql.Append(" AND D_MOD_DT  = (SELECT MAX(D_MOD_DT) FROM TRC_SLABWH_LOG WHERE C_SLAB_MAIN_ID ='" + slabid + "'AND N_ORDER = '" + order + "'))");
                }
            }
            else
            {
                if (order != 0)
                {
                    strSql.Append(" AND C_ID=(SELECT C_ID FROM TRC_SLABWH_LOG WHERE C_SLAB_MAIN_ID='" + slabid + "'");
                    strSql.Append(" AND　N_ORDER = '" + order + "'");
                    strSql.Append(" AND D_MOD_DT  = (SELECT MAX(D_MOD_DT) FROM TRC_SLABWH_LOG WHERE C_SLAB_MAIN_ID ='" + slabid + "'AND N_ORDER = '" + order + "'))");
                }
            }

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
        /// 获得数据列表
        /// </summary>
        public DataSet GetListByID(string slabid,string type)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_SLAB_MAIN_ID,C_MOVE_TYPE,C_SHIFT,C_GROUP,C_MAT_CODE,C_MAT_DESC,C_SLABWH_CODE_BEFORE,C_SLABWH_AREA_CODE_BEFORE,C_SLABWH_LOC_CODE_BEFORE,C_FLOOR_BEFORE,D_STORAGE_DT,C_SLABWH_CODE_AFTER,C_SLABWH_AREA_CODE_AFTER,C_SLABWH_LOC_CODE_AFTER,C_FLOOR_AFTER,C_SALE_AREA,C_TRANSPORTATION,C_EMP_ID,D_MOD_DT,N_STATUS,N_ORDER  ");
            strSql.Append(" FROM TRC_SLABWH_LOG WHERE N_STATUS=1");
            if (slabid.Trim() != "")
            {
                strSql.Append(" AND C_SLAB_MAIN_ID='" + slabid + "' ");
            }
            if (type.Trim() != "")
            {
                strSql.Append(" AND C_MOVE_TYPE='" + type + "' ");
            }
            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 根据操作类型记录总数
        /// </summary>
        public int GetDBCount(string slabid, string type)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM TRC_SLABWH_LOG ");
            strSql.Append(" where C_SLAB_MAIN_ID='" + slabid + "' ");
            strSql.Append(" AND C_MOVE_TYPE='" + type + "' ");
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
        #endregion  ExtensionMethod
    }
}
