using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;
namespace DAL
{
    public partial class Dal_TRC_ROLL_WGD_HANDLER_LOG
    {
        public Dal_TRC_ROLL_WGD_HANDLER_LOG()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string C_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TRC_ROLL_WGD_HANDLER_LOG");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)            };
            parameters[0].Value = C_ID;

            return DbHelperOra.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Mod_TRC_ROLL_WGD_HANDLER_LOG model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TRC_ROLL_WGD_HANDLER_LOG(");
            strSql.Append("C_STA_ID,C_WGD_ID,C_STOVE,C_BATCH_NO,C_PLAN_ID,D_MOD_DT,N_STATUS,C_STD_CODE,C_STL_GRD,C_SPEC,C_PACK,C_FREE_TERM,C_FREE_TERM2,C_MRSX,C_MAT_CODE,C_MAT_DESC,C_PCLX,C_NEWMRSX,C_NEWPCLX,C_NEW_STD_CODE,C_NEW_STL_GRD,C_NEW_SPEC,C_NEW_PACK,C_NEW_FREE_TERM,C_NEW_FREE_TERM2,C_NEW_MAT_CODE,C_NEW_MAT_DESC,C_SX,C_NEW_SX)");
            strSql.Append(" values (");
            strSql.Append(":C_STA_ID,:C_WGD_ID,:C_STOVE,:C_BATCH_NO,:C_PLAN_ID,:D_MOD_DT,:N_STATUS,:C_STD_CODE,:C_STL_GRD,:C_SPEC,:C_PACK,:C_FREE_TERM,:C_FREE_TERM2,:C_MRSX,:C_MAT_CODE,:C_MAT_DESC,:C_PCLX,:C_NEWMRSX,:C_NEWPCLX,:C_NEW_STD_CODE,:C_NEW_STL_GRD,:C_NEW_SPEC,:C_NEW_PACK,:C_NEW_FREE_TERM,:C_NEW_FREE_TERM2,:C_NEW_MAT_CODE,:C_NEW_MAT_DESC,:C_SX,:C_NEW_SX)");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_STA_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_WGD_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STOVE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_BATCH_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PLAN_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,15),
                    new OracleParameter(":C_STD_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STL_GRD", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SPEC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PACK", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_FREE_TERM", OracleDbType.Varchar2,300),
                    new OracleParameter(":C_FREE_TERM2", OracleDbType.Varchar2,300),
                    new OracleParameter(":C_MRSX", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_MAT_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MAT_DESC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PCLX", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_NEWMRSX", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_NEWPCLX", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_NEW_STD_CODE",  OracleDbType.Varchar2,100),
                    new OracleParameter(":C_NEW_STL_GRD",  OracleDbType.Varchar2,100),
                    new OracleParameter(":C_NEW_SPEC",  OracleDbType.Varchar2,100),
                    new OracleParameter(":C_NEW_PACK",  OracleDbType.Varchar2,100),
                    new OracleParameter(":C_NEW_FREE_TERM",  OracleDbType.Varchar2,100),
                    new OracleParameter(":C_NEW_FREE_TERM2",  OracleDbType.Varchar2,100),
                    new OracleParameter(":C_NEW_MAT_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_NEW_MAT_DESC", OracleDbType.Varchar2,100),
                   new OracleParameter(":C_SX", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_NEW_SX", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.C_STA_ID;
            parameters[1].Value = model.C_WGD_ID;
            parameters[2].Value = model.C_STOVE;
            parameters[3].Value = model.C_BATCH_NO;
            parameters[4].Value = model.C_PLAN_ID;
            parameters[5].Value = model.D_MOD_DT;
            parameters[6].Value = model.N_STATUS;
            parameters[7].Value = model.C_STD_CODE;
            parameters[8].Value = model.C_STL_GRD;
            parameters[9].Value = model.C_SPEC;
            parameters[10].Value = model.C_PACK;
            parameters[11].Value = model.C_FREE_TERM;
            parameters[12].Value = model.C_FREE_TERM2;
            parameters[13].Value = model.C_MRSX;
            parameters[14].Value = model.C_MAT_CODE;
            parameters[15].Value = model.C_MAT_DESC;
            parameters[16].Value = model.C_PCLX;
            parameters[17].Value = model.C_NEWMRSX;
            parameters[18].Value = model.C_NEWPCLX;
            parameters[19].Value = model.C_NEW_STD_CODE;
            parameters[20].Value = model.C_NEW_STL_GRD;
            parameters[21].Value = model.C_NEW_SPEC;
            parameters[22].Value = model.C_NEW_PACK;
            parameters[23].Value = model.C_NEW_FREE_TERM;
            parameters[24].Value = model.C_NEW_FREE_TERM2;
            parameters[25].Value = model.C_NEW_MAT_CODE;
            parameters[26].Value = model.C_NEW_MAT_DESC;
            parameters[27].Value = model.C_SX;
            parameters[28].Value = model.C_NEW_SX;
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
        public bool Update(Mod_TRC_ROLL_WGD_HANDLER_LOG model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TRC_ROLL_WGD_HANDLER_LOG set ");
            strSql.Append("C_STA_ID=:C_STA_ID,");
            strSql.Append("C_WGD_ID=:C_WGD_ID,");
            strSql.Append("C_STOVE=:C_STOVE,");
            strSql.Append("C_BATCH_NO=:C_BATCH_NO,");
            strSql.Append("C_PLAN_ID=:C_PLAN_ID,");
            strSql.Append("D_MOD_DT=:D_MOD_DT,");
            strSql.Append("N_STATUS=:N_STATUS,");
            strSql.Append("C_STD_CODE=:C_STD_CODE,");
            strSql.Append("C_STL_GRD=:C_STL_GRD,");
            strSql.Append("C_SPEC=:C_SPEC,");
            strSql.Append("C_PACK=:C_PACK,");
            strSql.Append("C_FREE_TERM=:C_FREE_TERM,");
            strSql.Append("C_FREE_TERM2=:C_FREE_TERM2,");
            strSql.Append("C_MRSX=:C_MRSX,");
            strSql.Append("C_MAT_CODE=:C_MAT_CODE,");
            strSql.Append("C_MAT_DESC=:C_MAT_DESC");
            strSql.Append("C_PCLX=:C_PCLX");
            strSql.Append("C_NEWMRSX=:C_NEWMRSX");
            strSql.Append("C_NEWPCLX=:C_NEWPCLX");
            strSql.Append("C_NEW_STD_CODE=:C_NEW_STD_CODE,");
            strSql.Append("C_NEW_STL_GRD=:C_NEW_STL_GRD,");
            strSql.Append("C_NEW_SPEC=:C_NEW_SPEC,");
            strSql.Append("C_NEW_PACK=:C_NEW_PACK,");
            strSql.Append("C_NEW_FREE_TERM=:C_NEW_FREE_TERM,");
            strSql.Append("C_NEW_FREE_TERM2=:C_NEW_FREE_TERM2");
            strSql.Append("C_NEW_MAT_CODE=:C_NEW_MAT_CODE,");
            strSql.Append("C_NEW_MAT_DESC=:C_NEW_MAT_DESC");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_STA_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_WGD_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STOVE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_BATCH_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PLAN_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,15),
                    new OracleParameter(":C_STD_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STL_GRD", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SPEC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PACK", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_FREE_TERM", OracleDbType.Varchar2,300),
                    new OracleParameter(":C_FREE_TERM2", OracleDbType.Varchar2,300),
                    new OracleParameter(":C_MRSX", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_MAT_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MAT_DESC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PCLX", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_NEWMRSX", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_NEWPCLX", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_NEW_STD_CODE",  OracleDbType.Varchar2,100),
                    new OracleParameter(":C_NEW_STL_GRD",  OracleDbType.Varchar2,100),
                    new OracleParameter(":C_NEW_SPEC",  OracleDbType.Varchar2,100),
                    new OracleParameter(":C_NEW_PACK",  OracleDbType.Varchar2,100),
                    new OracleParameter(":C_NEW_FREE_TERM",  OracleDbType.Varchar2,100),
                    new OracleParameter(":C_NEW_FREE_TERM2",  OracleDbType.Varchar2,100),
                    new OracleParameter(":C_NEW_MAT_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_NEW_MAT_DESC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.C_STA_ID;
            parameters[1].Value = model.C_WGD_ID;
            parameters[2].Value = model.C_STOVE;
            parameters[3].Value = model.C_BATCH_NO;
            parameters[4].Value = model.C_PLAN_ID;
            parameters[5].Value = model.D_MOD_DT;
            parameters[6].Value = model.N_STATUS;
            parameters[7].Value = model.C_STD_CODE;
            parameters[8].Value = model.C_STL_GRD;
            parameters[9].Value = model.C_SPEC;
            parameters[10].Value = model.C_PACK;
            parameters[11].Value = model.C_FREE_TERM;
            parameters[12].Value = model.C_FREE_TERM2;
            parameters[13].Value = model.C_MRSX;
            parameters[14].Value = model.C_MAT_CODE;
            parameters[15].Value = model.C_MAT_DESC;
            parameters[16].Value = model.C_PCLX;
            parameters[17].Value = model.C_NEWMRSX;
            parameters[18].Value = model.C_NEWPCLX;
            parameters[19].Value = model.C_NEW_STD_CODE;
            parameters[20].Value = model.C_NEW_STL_GRD;
            parameters[21].Value = model.C_NEW_SPEC;
            parameters[22].Value = model.C_NEW_PACK;
            parameters[23].Value = model.C_NEW_FREE_TERM;
            parameters[24].Value = model.C_NEW_FREE_TERM2;
            parameters[25].Value = model.C_NEW_MAT_CODE;
            parameters[26].Value = model.C_NEW_MAT_DESC;
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
            strSql.Append("delete from TRC_ROLL_WGD_HANDLER_LOG ");
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
            strSql.Append("delete from TRC_ROLL_WGD_HANDLER_LOG ");
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
        public Mod_TRC_ROLL_WGD_HANDLER_LOG GetModel(string C_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_STA_ID,C_WGD_ID,C_STOVE,C_BATCH_NO,C_PLAN_ID,D_MOD_DT,N_STATUS,C_STD_CODE,C_STL_GRD,C_SPEC,C_PACK,C_FREE_TERM,C_FREE_TERM2,C_MRSX,C_MAT_CODE,C_MAT_DESC,C_PCLX,C_NEWMRSX,C_NEWPCLX,C_NEW_STD_CODE,C_NEW_STL_GRD,C_NEW_SPEC,C_NEW_PACK,C_NEW_FREE_TERM,C_NEW_FREE_TERM2,C_NEW_MAT_CODE,C_NEW_MAT_DESC from TRC_ROLL_WGD_HANDLER_LOG ");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)            };
            parameters[0].Value = C_ID;

            Mod_TRC_ROLL_WGD_HANDLER_LOG model = new Mod_TRC_ROLL_WGD_HANDLER_LOG();
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
        public Mod_TRC_ROLL_WGD_HANDLER_LOG DataRowToModel(DataRow row)
        {
            Mod_TRC_ROLL_WGD_HANDLER_LOG model = new Mod_TRC_ROLL_WGD_HANDLER_LOG();
            if (row != null)
            {
                if (row["C_ID"] != null)
                {
                    model.C_ID = row["C_ID"].ToString();
                }
                if (row["C_STA_ID"] != null)
                {
                    model.C_STA_ID = row["C_STA_ID"].ToString();
                }
                if (row["C_WGD_ID"] != null)
                {
                    model.C_WGD_ID = row["C_WGD_ID"].ToString();
                }
                if (row["C_STOVE"] != null)
                {
                    model.C_STOVE = row["C_STOVE"].ToString();
                }
                if (row["C_BATCH_NO"] != null)
                {
                    model.C_BATCH_NO = row["C_BATCH_NO"].ToString();
                }
                if (row["C_PLAN_ID"] != null)
                {
                    model.C_PLAN_ID = row["C_PLAN_ID"].ToString();
                }
                if (row["D_MOD_DT"] != null && row["D_MOD_DT"].ToString() != "")
                {
                    model.D_MOD_DT = DateTime.Parse(row["D_MOD_DT"].ToString());
                }
                if (row["N_STATUS"] != null && row["N_STATUS"].ToString() != "")
                {
                    model.N_STATUS = decimal.Parse(row["N_STATUS"].ToString());
                }
                if (row["C_STD_CODE"] != null)
                {
                    model.C_STD_CODE = row["C_STD_CODE"].ToString();
                }
                if (row["C_STL_GRD"] != null)
                {
                    model.C_STL_GRD = row["C_STL_GRD"].ToString();
                }
                if (row["C_SPEC"] != null)
                {
                    model.C_SPEC = row["C_SPEC"].ToString();
                }
                if (row["C_PACK"] != null)
                {
                    model.C_PACK = row["C_PACK"].ToString();
                }
                if (row["C_FREE_TERM"] != null)
                {
                    model.C_FREE_TERM = row["C_FREE_TERM"].ToString();
                }
                if (row["C_FREE_TERM2"] != null)
                {
                    model.C_FREE_TERM2 = row["C_FREE_TERM2"].ToString();
                }
                if (row["C_MRSX"] != null)
                {
                    model.C_MRSX = row["C_MRSX"].ToString();
                }
                if (row["C_MAT_CODE"] != null)
                {
                    model.C_MAT_CODE = row["C_MAT_CODE"].ToString();
                }
                if (row["C_MAT_DESC"] != null)
                {
                    model.C_MAT_DESC = row["C_MAT_DESC"].ToString();
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
            strSql.Append("select C_ID,C_STA_ID,C_WGD_ID,C_STOVE,C_BATCH_NO,C_PLAN_ID,D_MOD_DT,N_STATUS,C_STD_CODE,C_STL_GRD,C_SPEC,C_PACK,C_FREE_TERM,C_FREE_TERM2,C_MRSX,C_MAT_CODE,C_MAT_DESC,C_PCLX,C_NEWMRSX,C_NEWPCLX,C_NEW_STD_CODE,C_NEW_STL_GRD,C_NEW_SPEC,C_NEW_PACK,C_NEW_FREE_TERM,C_NEW_FREE_TERM2,C_NEW_MAT_CODE,C_NEW_MAT_DESC ");
            strSql.Append(" FROM TRC_ROLL_WGD_HANDLER_LOG ");
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
            strSql.Append("select count(1) FROM TRC_ROLL_WGD_HANDLER_LOG ");
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
            strSql.Append(")AS Row, T.*  from TRC_ROLL_WGD_HANDLER_LOG T ");
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
