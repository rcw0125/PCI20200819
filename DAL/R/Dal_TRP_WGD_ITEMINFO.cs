using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;
namespace DAL
{
    public class Dal_TRP_WGD_ITEMINFO
    {
        public Dal_TRP_WGD_ITEMINFO()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string C_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TRP_WGD_ITEMINFO");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)            };
            parameters[0].Value = C_ID;

            return DbHelperOra.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Mod_TRP_WGD_ITEMINFO model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TRP_WGD_ITEMINFO(");
            strSql.Append("C_ITEM_INFO_ID,C_WGD_ID)");
            strSql.Append(" values (");
            strSql.Append(":C_ITEM_INFO_ID,:C_WGD_ID)");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ITEM_INFO_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_WGD_ID", OracleDbType.Varchar2,100) };
            parameters[0].Value = model.C_ITEM_INFO_ID;
            parameters[1].Value = model.C_WGD_ID;

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
        public bool Update(Mod_TRP_WGD_ITEMINFO model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TRP_WGD_ITEMINFO set ");
            strSql.Append("C_ITEM_INFO_ID=:C_ITEM_INFO_ID,");
            strSql.Append("C_WGD_ID=:C_WGD_ID");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ITEM_INFO_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_WGD_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.C_ITEM_INFO_ID;
            parameters[1].Value = model.C_WGD_ID;
            parameters[2].Value = model.C_ID;

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
            strSql.Append("delete from TRP_WGD_ITEMINFO ");
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
            strSql.Append("delete from TRP_WGD_ITEMINFO ");
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
        public Mod_TRP_WGD_ITEMINFO GetModel(string C_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ITEM_INFO_ID,C_WGD_ID,C_ID from TRP_WGD_ITEMINFO ");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)            };
            parameters[0].Value = C_ID;

            Mod_TRP_WGD_ITEMINFO model = new Mod_TRP_WGD_ITEMINFO();
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
        public Mod_TRP_WGD_ITEMINFO GetModelItem(string C_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ITEM_INFO_ID,C_WGD_ID,C_ID from TRP_WGD_ITEMINFO ");
            strSql.Append(" where C_WGD_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)            };
            parameters[0].Value = C_ID;

            Mod_TRP_WGD_ITEMINFO model = new Mod_TRP_WGD_ITEMINFO();
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
        public Mod_TRP_WGD_ITEMINFO DataRowToModel(DataRow row)
        {
            Mod_TRP_WGD_ITEMINFO model = new Mod_TRP_WGD_ITEMINFO();
            if (row != null)
            {
                if (row["C_ITEM_INFO_ID"] != null)
                {
                    model.C_ITEM_INFO_ID = row["C_ITEM_INFO_ID"].ToString();
                }
                if (row["C_WGD_ID"] != null)
                {
                    model.C_WGD_ID = row["C_WGD_ID"].ToString();
                }
                if (row["C_ID"] != null)
                {
                    model.C_ID = row["C_ID"].ToString();
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
            strSql.Append("select C_ITEM_INFO_ID,C_WGD_ID,C_ID ");
            strSql.Append(" FROM TRP_WGD_ITEMINFO ");
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
            strSql.Append("select count(1) FROM TRP_WGD_ITEMINFO ");
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
            strSql.Append(")AS Row, T.*  from TRP_WGD_ITEMINFO T ");
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
