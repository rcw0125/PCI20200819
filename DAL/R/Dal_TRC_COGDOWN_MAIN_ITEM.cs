using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;
namespace DAL
{
    public partial class Dal_TRC_COGDOWN_MAIN_ITEM
    {
        public Dal_TRC_COGDOWN_MAIN_ITEM()
        { }
        #region  BasicMethod



        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Mod_TRC_COGDOWN_MAIN_ITEM model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TRC_COGDOWN_MAIN_ITEM(");
            strSql.Append("C_COGDOWN_MAIN_ID,C_SLAB_MAIN_ID)");
            strSql.Append(" values (");
            strSql.Append(":C_COGDOWN_MAIN_ID,:C_SLAB_MAIN_ID)");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_COGDOWN_MAIN_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SLAB_MAIN_ID", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.C_COGDOWN_MAIN_ID;
            parameters[1].Value = model.C_SLAB_MAIN_ID;


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
        public bool Update(Mod_TRC_COGDOWN_MAIN_ITEM model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TRC_COGDOWN_MAIN_ITEM set ");
            strSql.Append("C_COGDOWN_MAIN_ID=:C_COGDOWN_MAIN_ID,");
            strSql.Append("C_SLAB_MAIN_ID=:C_SLAB_MAIN_ID");
            strSql.Append(" where C_ID=:C_ID");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_COGDOWN_MAIN_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SLAB_MAIN_ID", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.C_ID;
            parameters[1].Value = model.C_COGDOWN_MAIN_ID;
            parameters[2].Value = model.C_SLAB_MAIN_ID;

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
        public bool Delete(string id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from TRC_COGDOWN_MAIN_ITEM ");
            strSql.Append(" where  C_COGDOWN_MAIN_ID='" + id + "'");
            int rows = TransactionHelper.ExecuteSql(strSql.ToString());
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
        public Mod_TRC_COGDOWN_MAIN_ITEM GetModel()
        {
            //该表无主键信息，请自定义主键/条件字段
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_COGDOWN_MAIN_ID,C_SLAB_MAIN_ID from TRC_COGDOWN_MAIN_ITEM ");
            strSql.Append(" where ");
            OracleParameter[] parameters = {
            };

            Mod_TRC_COGDOWN_MAIN_ITEM model = new Mod_TRC_COGDOWN_MAIN_ITEM();
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
        public Mod_TRC_COGDOWN_MAIN_ITEM DataRowToModel(DataRow row)
        {
            Mod_TRC_COGDOWN_MAIN_ITEM model = new Mod_TRC_COGDOWN_MAIN_ITEM();
            if (row != null)
            {
                if (row["C_ID"] != null)
                {
                    model.C_ID = row["C_ID"].ToString();
                }
                if (row["C_COGDOWN_MAIN_ID"] != null)
                {
                    model.C_COGDOWN_MAIN_ID = row["C_COGDOWN_MAIN_ID"].ToString();
                }
                if (row["C_SLAB_MAIN_ID"] != null)
                {
                    model.C_SLAB_MAIN_ID = row["C_SLAB_MAIN_ID"].ToString();
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
            strSql.Append("select C_ID,C_COGDOWN_MAIN_ID,C_SLAB_MAIN_ID ");
            strSql.Append(" FROM TRC_COGDOWN_MAIN_ITEM ");
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
            strSql.Append("select count(1) FROM TRC_COGDOWN_MAIN_ITEM ");
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
            strSql.Append(")AS Row, T.*  from TRC_COGDOWN_MAIN_ITEM T ");
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
        /// 获取钢种信息
        /// </summary>
        public DataTable GetSlabMainInfoKp(string id)
        {
            string query1 = @"SELECT T.C_SLAB_MAIN_ID C_SLAB_MAIN_ID from TRC_COGDOWN_MAIN_ITEM t WHERE T.C_COGDOWN_MAIN_ID='" + id + "'";
            DataTable dt = DbHelperOra.Query(query1).Tables[0];
            DataTable dt2 = new DataTable();
            if (dt != null && dt.Rows.Count > 0)
            {
                string query2 = @"SELECT  T.C_MAT_CODE  
                                                           ,SUM(T.N_WGT)N_WGT
                                                           ,COUNT(T.C_ID)N_QUA
                                                           ,C_STOVE
                                                           ,T.C_STL_GRD
                                                           ,T.C_STD_CODE
                                                           ,T.C_BATCH_NO
                                                           ,MAX(T.C_SLABWH_CODE) C_SLABWH_CODE
                                                           ,MAX(T.C_ZYX1) C_ZYX1
                                                           ,MAX(T.C_ZYX2)C_ZYX2
                                                    FROM TSC_SLAB_MAIN  T where  1=1
                                                   AND  ( ";
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (i == dt.Rows.Count - 1)
                        query2 += " T.C_ID='" + dt.Rows[i]["C_SLAB_MAIN_ID"].ToString() + "'";
                    else
                        query2 += "  T.C_ID= '" + dt.Rows[i]["C_SLAB_MAIN_ID"].ToString() + "' OR ";
                }
                query2 += " ) GROUP BY T.C_MAT_CODE,T.C_STOVE,T.C_STL_GRD,T.C_STD_CODE,T.C_BATCH_NO  ";
                dt2 = DbHelperOra.Query(query2).Tables[0];
            }
            return dt2;
        }
        #endregion  ExtensionMethod
    }
}
