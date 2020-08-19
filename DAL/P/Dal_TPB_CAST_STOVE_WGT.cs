using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;
namespace DAL
{
    /// <summary>
    /// 数据访问类:TPB_CAST_STOVE_WGT
    /// </summary>
    public partial class Dal_TPB_CAST_STOVE_WGT
    {
        public Dal_TPB_CAST_STOVE_WGT()
        { }
        
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string C_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TPB_CAST_STOVE_WGT");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)         };
            parameters[0].Value = C_ID;

            return DbHelperOra.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Mod_TPB_CAST_STOVE_WGT model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TPB_CAST_STOVE_WGT(");
            strSql.Append("C_STA_ID,C_STA_DESC,N_STA_WGT,C_EMP_ID,D_MOD_DT,C_REMARK,N_STATUS)");
            strSql.Append(" values (");
            strSql.Append(":C_STA_ID,:C_STA_DESC,:N_STA_WGT,:C_EMP_ID,:D_MOD_DT,:C_REMARK,:N_STATUS)");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_STA_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STA_DESC", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_STA_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,200),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,1)};
            parameters[0].Value = model.C_STA_ID;
            parameters[1].Value = model.C_STA_DESC;
            parameters[2].Value = model.N_STA_WGT;
            parameters[3].Value = model.C_EMP_ID;
            parameters[4].Value = model.D_MOD_DT;
            parameters[5].Value = model.C_REMARK;
            parameters[6].Value = model.N_STATUS;

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
        public bool Update(Mod_TPB_CAST_STOVE_WGT model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TPB_CAST_STOVE_WGT set ");
            strSql.Append("C_STA_ID=:C_STA_ID,");
            strSql.Append("C_STA_DESC=:C_STA_DESC,");
            strSql.Append("N_STA_WGT=:N_STA_WGT,");
            strSql.Append("C_EMP_ID=:C_EMP_ID,");
            strSql.Append("D_MOD_DT=:D_MOD_DT,");
            strSql.Append("C_REMARK=:C_REMARK,");
            strSql.Append("N_STATUS=:N_STATUS");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_STA_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STA_DESC", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_STA_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,200),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.C_STA_ID;
            parameters[1].Value = model.C_STA_DESC;
            parameters[2].Value = model.N_STA_WGT;
            parameters[3].Value = model.C_EMP_ID;
            parameters[4].Value = model.D_MOD_DT;
            parameters[5].Value = model.C_REMARK;
            parameters[6].Value = model.N_STATUS;
            parameters[7].Value = model.C_ID;

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
            strSql.Append("delete from TPB_CAST_STOVE_WGT ");
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
            strSql.Append("delete from TPB_CAST_STOVE_WGT ");
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
        public Mod_TPB_CAST_STOVE_WGT GetModel(string C_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_STA_ID,C_STA_DESC,N_STA_WGT,C_EMP_ID,D_MOD_DT,C_REMARK,N_STATUS from TPB_CAST_STOVE_WGT ");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)         };
            parameters[0].Value = C_ID;

            Mod_TPB_CAST_STOVE_WGT model = new Mod_TPB_CAST_STOVE_WGT();
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
        public Mod_TPB_CAST_STOVE_WGT DataRowToModel(DataRow row)
        {
            Mod_TPB_CAST_STOVE_WGT model = new Mod_TPB_CAST_STOVE_WGT();
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
                if (row["C_STA_DESC"] != null)
                {
                    model.C_STA_DESC = row["C_STA_DESC"].ToString();
                }
                if (row["N_STA_WGT"] != null && row["N_STA_WGT"].ToString() != "")
                {
                    model.N_STA_WGT = decimal.Parse(row["N_STA_WGT"].ToString());
                }
                if (row["C_EMP_ID"] != null)
                {
                    model.C_EMP_ID = row["C_EMP_ID"].ToString();
                }
                if (row["D_MOD_DT"] != null && row["D_MOD_DT"].ToString() != "")
                {
                    model.D_MOD_DT = DateTime.Parse(row["D_MOD_DT"].ToString());
                }
                if (row["C_REMARK"] != null)
                {
                    model.C_REMARK = row["C_REMARK"].ToString();
                }
                if (row["N_STATUS"] != null && row["N_STATUS"].ToString() != "")
                {
                    model.N_STATUS = decimal.Parse(row["N_STATUS"].ToString());
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
            strSql.Append("select C_ID,C_STA_ID,C_STA_DESC,N_STA_WGT,C_EMP_ID,D_MOD_DT,C_REMARK,N_STATUS ");
            strSql.Append(" FROM TPB_CAST_STOVE_WGT ");
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
            strSql.Append("select count(1) FROM TPB_CAST_STOVE_WGT ");
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
            strSql.Append(")AS Row, T.*  from TPB_CAST_STOVE_WGT T ");
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
        /// 获取每炉重量数据列表
        /// </summary>
        /// <param name="N_STATUS">状态</param>
        /// <param name="C_STA_ID">工位</param>
        /// <returns></returns>
        public DataSet GetList(int N_STATUS,string C_STA_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_STA_ID,C_STA_DESC,N_STA_WGT,C_EMP_ID,D_MOD_DT,C_REMARK,N_STATUS ");
            strSql.Append(" FROM TPB_CAST_STOVE_WGT WHERE N_STATUS='"+ N_STATUS + "' ");
            if (C_STA_ID.Trim() != "")
            {
                strSql.Append(" AND C_STA_ID='"+ C_STA_ID + "' " );
            }
            strSql.Append(" ORDER BY C_STA_ID");
            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 获取炉次重量
        /// </summary>
        /// <param name="str_CC_CODE">连铸描述</param>
        /// <param name="c_initialize_item">方案名称</param>
        /// <returns></returns>
        public double GetWGT(string str_CC_CODE, string c_initialize_item)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select max(TA.N_STA_WGT)as N_STA_WGT from tpb_cast_stove_wgt ta inner join tpp_initialize_line tb on ta.C_STA_ID=tb.c_zl_sta_id where tb.c_lz_sta_id='" + str_CC_CODE + "'  and tb.c_initialize_item_id='" + c_initialize_item + "' ");

            object obj = DbHelperOra.GetSingle(strSql.ToString());
            if (obj == null)
            {
                return 0;
            }
            else
            {
                return Convert.ToDouble(obj);
            }
        }
        /// <summary>
        /// 根据工位得到一个对象实体
        /// </summary>
        /// <param name="C_STA_ID">工位</param>
        /// <returns></returns>
        public Mod_TPB_CAST_STOVE_WGT GetModelBySTA(string C_STA_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_STA_ID,C_STA_DESC,N_STA_WGT,C_EMP_ID,D_MOD_DT,C_REMARK,N_STATUS from TPB_CAST_STOVE_WGT ");
            strSql.Append(" where C_STA_ID=:C_STA_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_STA_ID", OracleDbType.Varchar2,100)         };
            parameters[0].Value = C_STA_ID;

            Mod_TPB_CAST_STOVE_WGT model = new Mod_TPB_CAST_STOVE_WGT();
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
        #endregion  ExtensionMethod
    }
}

