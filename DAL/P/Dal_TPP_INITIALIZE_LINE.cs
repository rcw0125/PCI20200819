using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;
namespace DAL
{
    /// <summary>
    /// 数据访问类:TPP_INITIALIZE_LINE
    /// </summary>
    public partial class Dal_TPP_INITIALIZE_LINE
    {
        public Dal_TPP_INITIALIZE_LINE()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string C_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TPP_INITIALIZE_LINE");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)         };
            parameters[0].Value = C_ID;

            return DbHelperOra.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Mod_TPP_INITIALIZE_LINE model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TPP_INITIALIZE_LINE(");
            strSql.Append("C_INITIALIZE_ITEM_ID,C_REMARK,C_EMP_ID,D_MOD_DT,N_CAPACITY,N_WGT,C_ZL_STA_ID,C_JL_STA_ID,C_ZK_STA_ID,C_LZ_STA_ID,C_ZL_STA_DESC,C_JL_STA_DESC,C_ZK_STA_DESC,C_LZ_STA_DESC)");
            strSql.Append(" values (");
            strSql.Append(":C_INITIALIZE_ITEM_ID,:C_REMARK,:C_EMP_ID,:D_MOD_DT,:N_CAPACITY,:N_WGT,:C_ZL_STA_ID,:C_JL_STA_ID,:C_ZK_STA_ID,:C_LZ_STA_ID,:C_ZL_STA_DESC,:C_JL_STA_DESC,:C_ZK_STA_DESC,:C_LZ_STA_DESC)");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_INITIALIZE_ITEM_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,200),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":N_CAPACITY", OracleDbType.Decimal,15),
                    new OracleParameter(":N_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":C_ZL_STA_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_JL_STA_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ZK_STA_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_LZ_STA_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ZL_STA_DESC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_JL_STA_DESC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ZK_STA_DESC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_LZ_STA_DESC", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.C_INITIALIZE_ITEM_ID;
            parameters[1].Value = model.C_REMARK;
            parameters[2].Value = model.C_EMP_ID;
            parameters[3].Value = model.D_MOD_DT;
            parameters[4].Value = model.N_CAPACITY;
            parameters[5].Value = model.N_WGT;
            parameters[6].Value = model.C_ZL_STA_ID;
            parameters[7].Value = model.C_JL_STA_ID;
            parameters[8].Value = model.C_ZK_STA_ID;
            parameters[9].Value =  model.C_LZ_STA_ID;
            parameters[10].Value = model.C_ZL_STA_DESC;
            parameters[11].Value = model.C_JL_STA_DESC;
            parameters[12].Value = model.C_ZK_STA_DESC;
            parameters[13].Value = model.C_LZ_STA_DESC;

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
        public bool Update(Mod_TPP_INITIALIZE_LINE model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TPP_INITIALIZE_LINE set ");
            strSql.Append("C_INITIALIZE_ITEM_ID=:C_INITIALIZE_ITEM_ID,");
            strSql.Append("C_REMARK=:C_REMARK,");
            strSql.Append("C_EMP_ID=:C_EMP_ID,");
            strSql.Append("D_MOD_DT=:D_MOD_DT,");
            strSql.Append("N_CAPACITY=:N_CAPACITY,");
            strSql.Append("N_WGT=:N_WGT,");
            strSql.Append("C_ZL_STA_ID=:C_ZL_STA_ID,");
            strSql.Append("C_JL_STA_ID=:C_JL_STA_ID,");
            strSql.Append("C_ZK_STA_ID=:C_ZK_STA_ID,");
            strSql.Append("C_LZ_STA_ID=:C_LZ_STA_ID,");
            strSql.Append("C_ZL_STA_DESC=:C_ZL_STA_DESC,");
            strSql.Append("C_JL_STA_DESC=:C_JL_STA_DESC,");
            strSql.Append("C_ZK_STA_DESC=:C_ZK_STA_DESC,");
            strSql.Append("C_LZ_STA_DESC=:C_LZ_STA_DESC");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_INITIALIZE_ITEM_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,200),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":N_CAPACITY", OracleDbType.Decimal,15),
                    new OracleParameter(":N_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":C_ZL_STA_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_JL_STA_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ZK_STA_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_LZ_STA_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ZL_STA_DESC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_JL_STA_DESC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ZK_STA_DESC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_LZ_STA_DESC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.C_INITIALIZE_ITEM_ID;
            parameters[1].Value = model.C_REMARK;
            parameters[2].Value = model.C_EMP_ID;
            parameters[3].Value = model.D_MOD_DT;
            parameters[4].Value = model.N_CAPACITY;
            parameters[5].Value = model.N_WGT;
            parameters[6].Value = model.C_ZL_STA_ID;
            parameters[7].Value = model.C_JL_STA_ID;
            parameters[8].Value = model.C_ZK_STA_ID;
            parameters[9].Value = model.C_LZ_STA_ID;
            parameters[10].Value = model.C_ZL_STA_DESC;
            parameters[11].Value = model.C_JL_STA_DESC;
            parameters[12].Value = model.C_ZK_STA_DESC;
            parameters[13].Value = model.C_LZ_STA_DESC;
            parameters[14].Value = model.C_ID;

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
            strSql.Append("delete from TPP_INITIALIZE_LINE ");
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
            strSql.Append("delete from TPP_INITIALIZE_LINE ");
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
        public Mod_TPP_INITIALIZE_LINE GetModel(string C_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_INITIALIZE_ITEM_ID,C_REMARK,C_EMP_ID,D_MOD_DT,N_CAPACITY,N_WGT,C_ZL_STA_ID,C_JL_STA_ID,C_ZK_STA_ID,C_LZ_STA_ID,C_ZL_STA_DESC,C_JL_STA_DESC,C_ZK_STA_DESC,C_LZ_STA_DESC from TPP_INITIALIZE_LINE ");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)         };
            parameters[0].Value = C_ID;

            Mod_TPP_INITIALIZE_LINE model = new Mod_TPP_INITIALIZE_LINE();
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
        public Mod_TPP_INITIALIZE_LINE DataRowToModel(DataRow row)
        {
            Mod_TPP_INITIALIZE_LINE model = new Mod_TPP_INITIALIZE_LINE();
            if (row != null)
            {
                if (row["C_ID"] != null)
                {
                    model.C_ID = row["C_ID"].ToString();
                }
                if (row["C_INITIALIZE_ITEM_ID"] != null)
                {
                    model.C_INITIALIZE_ITEM_ID = row["C_INITIALIZE_ITEM_ID"].ToString();
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
                if (row["N_CAPACITY"] != null && row["N_CAPACITY"].ToString() != "")
                {
                    model.N_CAPACITY = decimal.Parse(row["N_CAPACITY"].ToString());
                }
                if (row["N_WGT"] != null && row["N_WGT"].ToString() != "")
                {
                    model.N_WGT = decimal.Parse(row["N_WGT"].ToString());
                }
                if (row["C_ZL_STA_ID"] != null)
                {
                    model.C_ZL_STA_ID = row["C_ZL_STA_ID"].ToString();
                }
                if (row["C_JL_STA_ID"] != null)
                {
                    model.C_JL_STA_ID = row["C_JL_STA_ID"].ToString();
                }
                if (row["C_ZK_STA_ID"] != null)
                {
                    model.C_ZK_STA_ID = row["C_ZK_STA_ID"].ToString();
                }
                if (row["C_LZ_STA_ID"] != null)
                {
                    model.C_LZ_STA_ID = row["C_LZ_STA_ID"].ToString();
                }
                if (row["C_ZL_STA_DESC"] != null)
                {
                    model.C_ZL_STA_DESC = row["C_ZL_STA_DESC"].ToString();
                }
                if (row["C_JL_STA_DESC"] != null)
                {
                    model.C_JL_STA_DESC = row["C_JL_STA_DESC"].ToString();
                }
                if (row["C_ZK_STA_DESC"] != null)
                {
                    model.C_ZK_STA_DESC = row["C_ZK_STA_DESC"].ToString();
                }
                if (row["C_LZ_STA_DESC"] != null)
                {
                    model.C_LZ_STA_DESC = row["C_LZ_STA_DESC"].ToString();
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
            strSql.Append("select C_ID,C_INITIALIZE_ITEM_ID,C_REMARK,C_EMP_ID,D_MOD_DT,N_CAPACITY,N_WGT,C_ZL_STA_ID,C_JL_STA_ID,C_ZK_STA_ID,C_LZ_STA_ID,C_ZL_STA_DESC,C_JL_STA_DESC,C_ZK_STA_DESC,C_LZ_STA_DESC ");
            strSql.Append(" FROM TPP_INITIALIZE_LINE ");
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
            strSql.Append("select count(1) FROM TPP_INITIALIZE_LINE ");
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
            strSql.Append(")AS Row, T.*  from TPP_INITIALIZE_LINE T ");
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
        /// 查询当前方案的炼钢工艺路线
        /// </summary>
        /// <param name="C_INITIALIZE_ITEM_ID">方案主键</param>
        /// <returns></returns>
        public DataSet GetListByIniID(string C_INITIALIZE_ITEM_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_INITIALIZE_ITEM_ID,C_REMARK,C_EMP_ID,D_MOD_DT,N_CAPACITY,N_WGT,C_ZL_STA_ID,C_JL_STA_ID,C_ZK_STA_ID,C_LZ_STA_ID,C_ZL_STA_DESC,C_JL_STA_DESC,C_ZK_STA_DESC,C_LZ_STA_DESC ");
            strSql.Append(" FROM TPP_INITIALIZE_LINE WHERE 1=1 ");
            if (C_INITIALIZE_ITEM_ID.Trim() != "")
            {
                strSql.Append(" AND C_INITIALIZE_ITEM_ID ='"+ C_INITIALIZE_ITEM_ID + "'" );
            }
            else
            {
                strSql.Append(" AND C_INITIALIZE_ITEM_ID IS NULL ");
            }
           return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 查询产线
        /// </summary>
        /// <param name="C_INITIALIZE_ITEM_ID">方案</param>
        /// <returns></returns>
        public DataSet GetCXList(string C_INITIALIZE_ITEM_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select distinct C_REMARK ");
            strSql.Append(" FROM TPP_INITIALIZE_LINE WHERE 1=1 ");
            if (C_INITIALIZE_ITEM_ID.Trim() != "")
            {
                strSql.Append(" AND C_INITIALIZE_ITEM_ID ='"+ C_INITIALIZE_ITEM_ID + "'" );
            }
        
            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 删除该方案下数据
        /// </summary>
        public bool DeleteByFa(string FID)
        {
            int rows = 0;
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from TPP_INITIALIZE_LINE ");
            if (FID.Trim()!="")
            {
                strSql.Append(" where C_INITIALIZE_ITEM_ID=:C_INITIALIZE_ITEM_ID ");
                OracleParameter[] parameters = {
                    new OracleParameter(":C_INITIALIZE_ITEM_ID", OracleDbType.Varchar2,100)         };
                parameters[0].Value = FID;

                 rows = DbHelperOra.ExecuteSql(strSql.ToString(), parameters);
            }
            else
            {
                 rows = DbHelperOra.ExecuteSql(strSql.ToString());
            }
           
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
        /// 根据连铸主键获取炼钢生产工位路线
        /// </summary>
        /// <param name="C_LZ_STA_ID">连铸主键</param>
        /// <returns></returns>
        public Mod_TPP_INITIALIZE_LINE GetListByLZID(string C_LZ_STA_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_INITIALIZE_ITEM_ID,C_REMARK,C_EMP_ID,D_MOD_DT,N_CAPACITY,N_WGT,C_ZL_STA_ID,C_JL_STA_ID,C_ZK_STA_ID,C_LZ_STA_ID,C_ZL_STA_DESC,C_JL_STA_DESC,C_ZK_STA_DESC,C_LZ_STA_DESC ");
            strSql.Append(" FROM TPP_INITIALIZE_LINE WHERE C_LZ_STA_ID='" + C_LZ_STA_ID + "' ");

            Mod_TPP_INITIALIZE_LINE model = new Mod_TPP_INITIALIZE_LINE();
            DataSet ds = DbHelperOra.Query(strSql.ToString());
            if (ds.Tables[0].Rows.Count > 0)
            {
                return DataRowToModel(ds.Tables[0].Rows[0]);
            }
            else
            {
                return null;
            }
        }

        #endregion  ExtensionMethod
    }
}
