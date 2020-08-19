using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;
namespace DAL
{
    public partial    class Dal_TRC_ROLL_WGD_ITEM_LOG
    {
        public Dal_TRC_ROLL_WGD_ITEM_LOG()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string C_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from Dal_TRC_ROLL_WGD_ITEM_LOG");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)            };
            parameters[0].Value = C_ID;

            return DbHelperOra.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Mod_TRC_ROLL_WGD_ITEM_LOG model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TRC_ROLL_WGD_ITEM_LOG(");
            strSql.Append("C_MAIN_ID,C_ROLL_WGD_ID,C_BATCH_NO,N_STATUS,C_STD_CODE,C_STL_GRD,C_SPEC,C_MAT_CODE,C_MAT_DESC,C_SALE_AREA,C_ZYX1,C_ZYX2,C_BZYQ)");
            strSql.Append(" values (");
            strSql.Append(":C_MAIN_ID,:C_ROLL_WGD_ID,:C_BATCH_NO,:N_STATUS,:C_STD_CODE,:C_STL_GRD,:C_SPEC,:C_MAT_CODE,:C_MAT_DESC,:C_SALE_AREA,:C_ZYX1,:C_ZYX2,:C_BZYQ)");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_MAIN_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ROLL_WGD_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_BATCH_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,15),
                    new OracleParameter(":C_STD_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STL_GRD", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SPEC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MAT_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MAT_DESC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SALE_AREA", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ZYX1", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ZYX2", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_BZYQ", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.C_MAIN_ID;
            parameters[1].Value = model.C_ROLL_WGD_ID;
            parameters[2].Value = model.C_BATCH_NO;
            parameters[3].Value = model.N_STATUS;
            parameters[4].Value = model.C_STD_CODE;
            parameters[5].Value = model.C_STL_GRD;
            parameters[6].Value = model.C_SPEC;
            parameters[7].Value = model.C_MAT_CODE;
            parameters[8].Value = model.C_MAT_DESC;
            parameters[9].Value =  model.C_SALE_AREA;
            parameters[10].Value = model.C_ZYX1;
            parameters[11].Value = model.C_ZYX2;
            parameters[12].Value = model.C_BZYQ;

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
        public bool Update(Mod_TRC_ROLL_WGD_ITEM_LOG model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TRC_ROLL_WGD_ITEM_LOG set ");
            strSql.Append("C_MAIN_ID=:C_MAIN_ID,");
            strSql.Append("C_ROLL_WGD_ID=:C_ROLL_WGD_ID,");
            strSql.Append("C_BATCH_NO=:C_BATCH_NO,");
            strSql.Append("N_STATUS=:N_STATUS,");
            strSql.Append("C_STD_CODE=:C_STD_CODE,");
            strSql.Append("C_STL_GRD=:C_STL_GRD,");
            strSql.Append("C_SPEC=:C_SPEC,");
            strSql.Append("C_MAT_CODE=:C_MAT_CODE,");
            strSql.Append("C_MAT_DESC=:C_MAT_DESC,");
            strSql.Append("C_SALE_AREA=:C_SALE_AREA,");
            strSql.Append("C_ZYX1=:C_ZYX1,");
            strSql.Append("C_ZYX2=:C_ZYX2,");
            strSql.Append("C_BZYQ=:C_BZYQ");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_MAIN_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ROLL_WGD_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_BATCH_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,15),
                    new OracleParameter(":C_STD_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STL_GRD", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SPEC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MAT_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MAT_DESC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SALE_AREA", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ZYX1", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ZYX2", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_BZYQ", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.C_MAIN_ID;
            parameters[1].Value = model.C_ROLL_WGD_ID;
            parameters[2].Value = model.C_BATCH_NO;
            parameters[3].Value = model.N_STATUS;
            parameters[4].Value = model.C_STD_CODE;
            parameters[5].Value = model.C_STL_GRD;
            parameters[6].Value = model.C_SPEC;
            parameters[7].Value = model.C_MAT_CODE;
            parameters[8].Value = model.C_MAT_DESC;
            parameters[9].Value = model.C_SALE_AREA;
            parameters[10].Value = model.C_ZYX1;
            parameters[11].Value = model.C_ZYX2;
            parameters[12].Value = model.C_BZYQ;
            parameters[13].Value = model.C_ID;

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
            strSql.Append("delete from TRC_ROLL_WGD_ITEM_LOG ");
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
            strSql.Append("delete from TRC_ROLL_WGD_ITEM_LOG ");
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
        public Mod_TRC_ROLL_WGD_ITEM_LOG GetModel(string C_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_MAIN_ID,C_ROLL_WGD_ID,C_BATCH_NO,N_STATUS,C_STD_CODE,C_STL_GRD,C_SPEC,C_MAT_CODE,C_MAT_DESC,C_SALE_AREA,C_ZYX1,C_ZYX2,C_BZYQ from TRC_ROLL_WGD_ITEM_LOG ");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)            };
            parameters[0].Value = C_ID;

            Mod_TRC_ROLL_WGD_ITEM_LOG model = new Mod_TRC_ROLL_WGD_ITEM_LOG();
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
        public Mod_TRC_ROLL_WGD_ITEM_LOG DataRowToModel(DataRow row)
        {
            Mod_TRC_ROLL_WGD_ITEM_LOG model = new Mod_TRC_ROLL_WGD_ITEM_LOG();
            if (row != null)
            {
                if (row["C_ID"] != null)
                {
                    model.C_ID = row["C_ID"].ToString();
                }
                if (row["C_MAIN_ID"] != null)
                {
                    model.C_MAIN_ID = row["C_MAIN_ID"].ToString();
                }
                if (row["C_ROLL_WGD_ID"] != null)
                {
                    model.C_ROLL_WGD_ID = row["C_ROLL_WGD_ID"].ToString();
                }
                if (row["C_BATCH_NO"] != null)
                {
                    model.C_BATCH_NO = row["C_BATCH_NO"].ToString();
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
                if (row["C_MAT_CODE"] != null)
                {
                    model.C_MAT_CODE = row["C_MAT_CODE"].ToString();
                }
                if (row["C_MAT_DESC"] != null)
                {
                    model.C_MAT_DESC = row["C_MAT_DESC"].ToString();
                }
                if (row["C_SALE_AREA"] != null)
                {
                    model.C_SALE_AREA = row["C_SALE_AREA"].ToString();
                }
                if (row["C_ZYX1"] != null)
                {
                    model.C_ZYX1 = row["C_ZYX1"].ToString();
                }
                if (row["C_ZYX2"] != null)
                {
                    model.C_ZYX2 = row["C_ZYX2"].ToString();
                }
                if (row["C_BZYQ"] != null)
                {
                    model.C_BZYQ = row["C_BZYQ"].ToString();
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
            strSql.Append("select C_ID,C_MAIN_ID,C_ROLL_WGD_ID,C_BATCH_NO,N_STATUS,C_STD_CODE,C_STL_GRD,C_SPEC,C_MAT_CODE,C_MAT_DESC,C_SALE_AREA,C_ZYX1,C_ZYX2,C_BZYQ ");
            strSql.Append(" FROM TRC_ROLL_WGD_ITEM_LOG ");
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
            strSql.Append("select count(1) FROM TRC_ROLL_WGD_ITEM_LOG ");
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
            strSql.Append(")AS Row, T.*  from TRC_ROLL_WGD_ITEM_LOG T ");
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
