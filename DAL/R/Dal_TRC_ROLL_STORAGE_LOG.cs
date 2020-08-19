using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;
namespace DAL
{
    /// <summary>
    /// 数据访问类:TRC_ROLL_STORAGE_LOG
    /// </summary>
    public partial class Dal_TRC_ROLL_STORAGE_LOG
    {
        public Dal_TRC_ROLL_STORAGE_LOG()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string C_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TRC_ROLL_STORAGE_LOG");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)          };
            parameters[0].Value = C_ID;

            return DbHelperOra.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Mod_TRC_ROLL_STORAGE_LOG model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TRC_ROLL_STORAGE_LOG(");
            strSql.Append(" C_TRC_ROLL_MAIN_ID,C_STOVE,C_BATCH_NO,C_TICK_NO,C_STL_GRD,N_WGT,C_STD_CODE,C_MOVE_TYPE,C_SPEC,C_SHIFT,C_GROUP,C_MAT_CODE,C_MAT_DESC,C_LINEWH_CODE_BEFORE,C_LINEWH_AREA_CODE_BEFORE,C_LINEWH_LOC_CODE_BEFORE,C_FLOOR_BEFORE,D_STORAGE_DT,C_LINEWH_CODE_AFTER,C_LINEWH_AREA_CODE_AFTER,C_LINEWH_LOC_CODE_AFTER,C_FLOOR_AFTER,C_SALE_AREA,C_TRANSPORTATION,C_EMP_ID,D_MOD_DT,N_STATUS)");
            strSql.Append(" values (");
            strSql.Append(" :C_TRC_ROLL_MAIN_ID,:C_STOVE,:C_BATCH_NO,:C_TICK_NO,:C_STL_GRD,:N_WGT,:C_STD_CODE,:C_MOVE_TYPE,:C_SPEC,:C_SHIFT,:C_GROUP,:C_MAT_CODE,:C_MAT_DESC,:C_LINEWH_CODE_BEFORE,:C_LINEWH_AREA_CODE_BEFORE,:C_LINEWH_LOC_CODE_BEFORE,:C_FLOOR_BEFORE,:D_STORAGE_DT,:C_LINEWH_CODE_AFTER,:C_LINEWH_AREA_CODE_AFTER,:C_LINEWH_LOC_CODE_AFTER,:C_FLOOR_AFTER,:C_SALE_AREA,:C_TRANSPORTATION,:C_EMP_ID,:D_MOD_DT,:N_STATUS)");
            OracleParameter[] parameters = {
                     new OracleParameter(":C_TRC_ROLL_MAIN_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STOVE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_BATCH_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_TICK_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STL_GRD", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":C_STD_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MOVE_TYPE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SPEC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SHIFT", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_GROUP", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MAT_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MAT_DESC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_LINEWH_CODE_BEFORE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_LINEWH_AREA_CODE_BEFORE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_LINEWH_LOC_CODE_BEFORE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_FLOOR_BEFORE", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_STORAGE_DT", OracleDbType.Date),
                    new OracleParameter(":C_LINEWH_CODE_AFTER", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_LINEWH_AREA_CODE_AFTER", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_LINEWH_LOC_CODE_AFTER", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_FLOOR_AFTER", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SALE_AREA", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_TRANSPORTATION", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,1)};
            parameters[0].Value = model.C_TRC_ROLL_MAIN_ID;
            parameters[1].Value = model.C_STOVE;
            parameters[2].Value = model.C_BATCH_NO;
            parameters[3].Value = model.C_TICK_NO;
            parameters[4].Value = model.C_STL_GRD;
            parameters[5].Value = model.N_WGT;
            parameters[6].Value = model.C_STD_CODE;
            parameters[7].Value = model.C_MOVE_TYPE;
            parameters[8].Value = model.C_SPEC;
            parameters[9].Value = model.C_SHIFT;
            parameters[10].Value = model.C_GROUP;
            parameters[11].Value = model.C_MAT_CODE;
            parameters[12].Value = model.C_MAT_DESC;
            parameters[13].Value = model.C_LINEWH_CODE_BEFORE;
            parameters[14].Value = model.C_LINEWH_AREA_CODE_BEFORE;
            parameters[15].Value = model.C_LINEWH_LOC_CODE_BEFORE;
            parameters[16].Value = model.C_FLOOR_BEFORE;
            parameters[17].Value = model.D_STORAGE_DT;
            parameters[18].Value = model.C_LINEWH_CODE_AFTER;
            parameters[19].Value = model.C_LINEWH_AREA_CODE_AFTER;
            parameters[20].Value = model.C_LINEWH_LOC_CODE_AFTER;
            parameters[21].Value = model.C_FLOOR_AFTER;
            parameters[22].Value = model.C_SALE_AREA;
            parameters[23].Value = model.C_TRANSPORTATION;
            parameters[24].Value = model.C_EMP_ID;
            parameters[25].Value = model.D_MOD_DT;
            parameters[26].Value = model.N_STATUS;
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
        public bool Update(Mod_TRC_ROLL_STORAGE_LOG model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TRC_ROLL_STORAGE_LOG set ");
            strSql.Append("C_TRC_ROLL_MAIN_ID=:C_TRC_ROLL_MAIN_ID,");
            strSql.Append("C_STOVE=:C_STOVE,");
            strSql.Append("C_BATCH_NO=:C_BATCH_NO,");
            strSql.Append("C_TICK_NO=:C_TICK_NO,");
            strSql.Append("C_STL_GRD=:C_STL_GRD,");
            strSql.Append("N_WGT=:N_WGT,");
            strSql.Append("C_STD_CODE=:C_STD_CODE,");
            strSql.Append("C_MOVE_TYPE=:C_MOVE_TYPE,");
            strSql.Append("C_SPEC=:C_SPEC,");
            strSql.Append("C_SHIFT=:C_SHIFT,");
            strSql.Append("C_GROUP=:C_GROUP,");
            strSql.Append("C_MAT_CODE=:C_MAT_CODE,");
            strSql.Append("C_MAT_DESC=:C_MAT_DESC,");
            strSql.Append("C_LINEWH_CODE_BEFORE=:C_LINEWH_CODE_BEFORE,");
            strSql.Append("C_LINEWH_AREA_CODE_BEFORE=:C_LINEWH_AREA_CODE_BEFORE,");
            strSql.Append("C_LINEWH_LOC_CODE_BEFORE=:C_LINEWH_LOC_CODE_BEFORE,");
            strSql.Append("C_FLOOR_BEFORE=:C_FLOOR_BEFORE,");
            strSql.Append("D_STORAGE_DT=:D_STORAGE_DT,");
            strSql.Append("C_LINEWH_CODE_AFTER=:C_LINEWH_CODE_AFTER,");
            strSql.Append("C_LINEWH_AREA_CODE_AFTER=:C_LINEWH_AREA_CODE_AFTER,");
            strSql.Append("C_LINEWH_LOC_CODE_AFTER=:C_LINEWH_LOC_CODE_AFTER,");
            strSql.Append("C_FLOOR_AFTER=:C_FLOOR_AFTER,");
            strSql.Append("C_SALE_AREA=:C_SALE_AREA,");
            strSql.Append("C_TRANSPORTATION=:C_TRANSPORTATION,");
            strSql.Append("C_EMP_ID=:C_EMP_ID,");
            strSql.Append("D_MOD_DT=:D_MOD_DT");
            strSql.Append("N_STATUS=:N_STATUS");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_TRC_ROLL_MAIN_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STOVE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_BATCH_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_TICK_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STL_GRD", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":C_STD_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MOVE_TYPE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SPEC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SHIFT", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_GROUP", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MAT_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MAT_DESC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_LINEWH_CODE_BEFORE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_LINEWH_AREA_CODE_BEFORE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_LINEWH_LOC_CODE_BEFORE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_FLOOR_BEFORE", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_STORAGE_DT", OracleDbType.Date),
                    new OracleParameter(":C_LINEWH_CODE_AFTER", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_LINEWH_AREA_CODE_AFTER", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_LINEWH_LOC_CODE_AFTER", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_FLOOR_AFTER", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SALE_AREA", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_TRANSPORTATION", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.C_TRC_ROLL_MAIN_ID;
            parameters[1].Value = model.C_STOVE;
            parameters[2].Value = model.C_BATCH_NO;
            parameters[3].Value = model.C_TICK_NO;
            parameters[4].Value = model.C_STL_GRD;
            parameters[5].Value = model.N_WGT;
            parameters[6].Value = model.C_STD_CODE;
            parameters[7].Value = model.C_MOVE_TYPE;
            parameters[8].Value = model.C_SPEC;
            parameters[9].Value = model.C_SHIFT;
            parameters[10].Value = model.C_GROUP;
            parameters[11].Value = model.C_MAT_CODE;
            parameters[12].Value = model.C_MAT_DESC;
            parameters[13].Value = model.C_LINEWH_CODE_BEFORE;
            parameters[14].Value = model.C_LINEWH_AREA_CODE_BEFORE;
            parameters[15].Value = model.C_LINEWH_LOC_CODE_BEFORE;
            parameters[16].Value = model.C_FLOOR_BEFORE;
            parameters[17].Value = model.D_STORAGE_DT;
            parameters[18].Value = model.C_LINEWH_CODE_AFTER;
            parameters[19].Value = model.C_LINEWH_AREA_CODE_AFTER;
            parameters[20].Value = model.C_LINEWH_LOC_CODE_AFTER;
            parameters[21].Value = model.C_FLOOR_AFTER;
            parameters[22].Value = model.C_SALE_AREA;
            parameters[23].Value = model.C_TRANSPORTATION;
            parameters[24].Value = model.C_EMP_ID;
            parameters[25].Value = model.D_MOD_DT;
            parameters[26].Value = model.N_STATUS;
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
            strSql.Append("delete from TRC_ROLL_STORAGE_LOG ");
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
            strSql.Append("delete from TRC_ROLL_STORAGE_LOG ");
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
        public Mod_TRC_ROLL_STORAGE_LOG GetModel(string C_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_TRC_ROLL_MAIN_ID,C_STOVE,C_BATCH_NO,C_TICK_NO,C_STL_GRD,N_WGT,C_STD_CODE,C_MOVE_TYPE,C_SPEC,C_SHIFT,C_GROUP,C_MAT_CODE,C_MAT_DESC,C_LINEWH_CODE_BEFORE,C_LINEWH_AREA_CODE_BEFORE,C_LINEWH_LOC_CODE_BEFORE,C_FLOOR_BEFORE,D_STORAGE_DT,C_LINEWH_CODE_AFTER,C_LINEWH_AREA_CODE_AFTER,C_LINEWH_LOC_CODE_AFTER,C_FLOOR_AFTER,C_SALE_AREA,C_TRANSPORTATION,C_EMP_ID,D_MOD_DT,N_STATUS from TRC_ROLL_STORAGE_LOG ");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)          };
            parameters[0].Value = C_ID;

            Mod_TRC_ROLL_STORAGE_LOG model = new Mod_TRC_ROLL_STORAGE_LOG();
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
        public Mod_TRC_ROLL_STORAGE_LOG DataRowToModel(DataRow row)
        {
            Mod_TRC_ROLL_STORAGE_LOG model = new Mod_TRC_ROLL_STORAGE_LOG();
            if (row != null)
            {
                if (row["C_ID"] != null)
                {
                    model.C_ID = row["C_ID"].ToString();
                }
                if (row["C_TRC_ROLL_MAIN_ID"] != null)
                {
                    model.C_TRC_ROLL_MAIN_ID = row["C_TRC_ROLL_MAIN_ID"].ToString();
                }
                if (row["C_STOVE"] != null)
                {
                    model.C_STOVE = row["C_STOVE"].ToString();
                }
                if (row["C_BATCH_NO"] != null)
                {
                    model.C_BATCH_NO = row["C_BATCH_NO"].ToString();
                }
                if (row["C_TICK_NO"] != null)
                {
                    model.C_TICK_NO = row["C_TICK_NO"].ToString();
                }
                if (row["C_STL_GRD"] != null)
                {
                    model.C_STL_GRD = row["C_STL_GRD"].ToString();
                }
                if (row["N_WGT"] != null && row["N_WGT"].ToString() != "")
                {
                    model.N_WGT = decimal.Parse(row["N_WGT"].ToString());
                }
                if (row["C_STD_CODE"] != null)
                {
                    model.C_STD_CODE = row["C_STD_CODE"].ToString();
                }
                if (row["C_MOVE_TYPE"] != null)
                {
                    model.C_MOVE_TYPE = row["C_MOVE_TYPE"].ToString();
                }
                if (row["C_SPEC"] != null)
                {
                    model.C_SPEC = row["C_SPEC"].ToString();
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
                if (row["C_LINEWH_CODE_BEFORE"] != null)
                {
                    model.C_LINEWH_CODE_BEFORE = row["C_LINEWH_CODE_BEFORE"].ToString();
                }
                if (row["C_LINEWH_AREA_CODE_BEFORE"] != null)
                {
                    model.C_LINEWH_AREA_CODE_BEFORE = row["C_LINEWH_AREA_CODE_BEFORE"].ToString();
                }
                if (row["C_LINEWH_LOC_CODE_BEFORE"] != null)
                {
                    model.C_LINEWH_LOC_CODE_BEFORE = row["C_LINEWH_LOC_CODE_BEFORE"].ToString();
                }
                if (row["C_FLOOR_BEFORE"] != null)
                {
                    model.C_FLOOR_BEFORE = row["C_FLOOR_BEFORE"].ToString();
                }
                if (row["D_STORAGE_DT"] != null && row["D_STORAGE_DT"].ToString() != "")
                {
                    model.D_STORAGE_DT = DateTime.Parse(row["D_STORAGE_DT"].ToString());
                }
                if (row["C_LINEWH_CODE_AFTER"] != null)
                {
                    model.C_LINEWH_CODE_AFTER = row["C_LINEWH_CODE_AFTER"].ToString();
                }
                if (row["C_LINEWH_AREA_CODE_AFTER"] != null)
                {
                    model.C_LINEWH_AREA_CODE_AFTER = row["C_LINEWH_AREA_CODE_AFTER"].ToString();
                }
                if (row["C_LINEWH_LOC_CODE_AFTER"] != null)
                {
                    model.C_LINEWH_LOC_CODE_AFTER = row["C_LINEWH_LOC_CODE_AFTER"].ToString();
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
            }
            return model;
        }
        /// <summary>
		/// 获得数据列表-入库 记录查询
		/// </summary>
		public DataSet GetList_RK(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_TRC_ROLL_MAIN_ID,C_STOVE,C_BATCH_NO,C_TICK_NO,C_STL_GRD,N_WGT,C_STD_CODE,C_MOVE_TYPE,C_SPEC,C_SHIFT,C_GROUP,C_MAT_CODE,C_MAT_DESC,C_LINEWH_CODE_BEFORE,C_LINEWH_AREA_CODE_BEFORE,C_LINEWH_LOC_CODE_BEFORE,C_FLOOR_BEFORE,D_STORAGE_DT,C_LINEWH_CODE_AFTER,C_LINEWH_AREA_CODE_AFTER,C_LINEWH_LOC_CODE_AFTER,C_FLOOR_AFTER,C_SALE_AREA,C_TRANSPORTATION,C_EMP_ID,D_MOD_DT,N_STATUS ");
            strSql.Append(" FROM TRC_ROLL_STORAGE_LOG where N_STATUS =1 and C_MOVE_TYPE ='E' ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" and C_BATCH_NO like '%" + strWhere + "%'");
            }
            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
		/// 获得数据列表-转库与销售 记录查询
		/// </summary>
		public DataSet GetList_Query(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_TRC_ROLL_MAIN_ID,C_STOVE,C_BATCH_NO,C_TICK_NO,C_STL_GRD,N_WGT,C_STD_CODE,C_MOVE_TYPE,C_SPEC,C_SHIFT,C_GROUP,C_MAT_CODE,C_MAT_DESC,C_LINEWH_CODE_BEFORE,C_LINEWH_AREA_CODE_BEFORE,C_LINEWH_LOC_CODE_BEFORE,C_FLOOR_BEFORE,D_STORAGE_DT,C_LINEWH_CODE_AFTER,C_LINEWH_AREA_CODE_AFTER,C_LINEWH_LOC_CODE_AFTER,C_FLOOR_AFTER,C_SALE_AREA,C_TRANSPORTATION,C_EMP_ID,D_MOD_DT,N_STATUS ");
            strSql.Append(" FROM TRC_ROLL_STORAGE_LOG where N_STATUS =1 and C_MOVE_TYPE ='Z' or C_MOVE_TYPE='S' ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" and C_BATCH_NO like '%"+ strWhere + "%'");
            }
            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_TRC_ROLL_MAIN_ID,C_STOVE,C_BATCH_NO,C_TICK_NO,C_STL_GRD,N_WGT,C_STD_CODE,C_MOVE_TYPE,C_SPEC,C_SHIFT,C_GROUP,C_MAT_CODE,C_MAT_DESC,C_LINEWH_CODE_BEFORE,C_LINEWH_AREA_CODE_BEFORE,C_LINEWH_LOC_CODE_BEFORE,C_FLOOR_BEFORE,D_STORAGE_DT,C_LINEWH_CODE_AFTER,C_LINEWH_AREA_CODE_AFTER,C_LINEWH_LOC_CODE_AFTER,C_FLOOR_AFTER,C_SALE_AREA,C_TRANSPORTATION,C_EMP_ID,D_MOD_DT,N_STATUS ");
            strSql.Append(" FROM TRC_ROLL_STORAGE_LOG ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 获得数据列表-ID
        /// </summary>
        public DataSet GetList_ID(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_TRC_ROLL_MAIN_ID,C_STOVE,C_BATCH_NO,C_TICK_NO,C_STL_GRD,N_WGT,C_STD_CODE,C_MOVE_TYPE,C_SPEC,C_SHIFT,C_GROUP,C_MAT_CODE,C_MAT_DESC,C_LINEWH_CODE_BEFORE,C_LINEWH_AREA_CODE_BEFORE,C_LINEWH_LOC_CODE_BEFORE,C_FLOOR_BEFORE,D_STORAGE_DT,C_LINEWH_CODE_AFTER,C_LINEWH_AREA_CODE_AFTER,C_LINEWH_LOC_CODE_AFTER,C_FLOOR_AFTER,C_SALE_AREA,C_TRANSPORTATION,C_EMP_ID,D_MOD_DT,N_STATUS ");
            strSql.Append(" FROM TRC_ROLL_STORAGE_LOG ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where C_ID =" + strWhere);
            }
            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM TRC_ROLL_STORAGE_LOG ");
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
            strSql.Append(")AS Row, T.*  from TRC_ROLL_STORAGE_LOG T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            return DbHelperOra.Query(strSql.ToString());
        }

        /*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			OracleParameter[] parameters = {
					new OracleParameter(":tblName", OracleDbType.Varchar2, 255),
					new OracleParameter(":fldName", OracleDbType.Varchar2, 255),
					new OracleParameter(":PageSize", OracleDbType.Number),
					new OracleParameter(":PageIndex", OracleDbType.Number),
					new OracleParameter(":IsReCount", OracleDbType.Clob),
					new OracleParameter(":OrderType", OracleDbType.Clob),
					new OracleParameter(":strWhere", OracleDbType.Varchar2,1000),
					};
			parameters[0].Value = "TRC_ROLL_STORAGE_LOG";
			parameters[1].Value = "C_ID";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperOra.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

        #endregion  BasicMethod
        #region  ExtensionMethod

        #endregion  ExtensionMethod
    }
}

