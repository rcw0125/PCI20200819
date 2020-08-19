using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;
namespace DAL
{
    /// <summary>
    /// 数据访问类:TPB_STA_MOVETIME
    /// </summary>
    public partial class Dal_TPB_STA_MOVETIME
    {
        public Dal_TPB_STA_MOVETIME()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string C_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TPB_STA_MOVETIME");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)         };
            parameters[0].Value = C_ID;

            return DbHelperOra.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Mod_TPB_STA_MOVETIME model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TPB_STA_MOVETIME(");
            strSql.Append("C_STA_ID1,C_STA_ID2,N_TIME,C_EMP_ID,D_MOD_DT,C_REMARK,N_STATUS)");
            strSql.Append(" values (");
            strSql.Append(":C_STA_ID1,:C_STA_ID2,:N_TIME,:C_EMP_ID,:D_MOD_DT,:C_REMARK,:N_STATUS)");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_STA_ID1", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STA_ID2", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_TIME", OracleDbType.Decimal,3),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,200),  new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),};
            parameters[0].Value = model.C_STA_ID1;
            parameters[1].Value = model.C_STA_ID2;
            parameters[2].Value = model.N_TIME;
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
        public bool Update(Mod_TPB_STA_MOVETIME model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TPB_STA_MOVETIME set ");
            strSql.Append("N_STATUS=:N_STATUS,");
            strSql.Append("C_STA_ID1=:C_STA_ID1,");
            strSql.Append("C_STA_ID2=:C_STA_ID2,");
            strSql.Append("N_TIME=:N_TIME,");
            strSql.Append("C_EMP_ID=:C_EMP_ID,");
            strSql.Append("D_MOD_DT=:D_MOD_DT,");
            strSql.Append("C_REMARK=:C_REMARK");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                 new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
                    new OracleParameter(":C_STA_ID1", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STA_ID2", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_TIME", OracleDbType.Decimal,3),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,200),
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.N_STATUS;
            parameters[1].Value = model.C_STA_ID1;
            parameters[2].Value = model.C_STA_ID2;
            parameters[3].Value = model.N_TIME;
            parameters[4].Value = model.C_EMP_ID;
            parameters[5].Value = model.D_MOD_DT;
            parameters[6].Value = model.C_REMARK;
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
            strSql.Append("delete from TPB_STA_MOVETIME ");
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
            strSql.Append("delete from TPB_STA_MOVETIME ");
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
        public Mod_TPB_STA_MOVETIME GetModel(string C_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_STA_ID1,C_STA_ID2,N_TIME,C_EMP_ID,D_MOD_DT,C_REMARK from TPB_STA_MOVETIME ");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)         };
            parameters[0].Value = C_ID;

            Mod_TPB_STA_MOVETIME model = new Mod_TPB_STA_MOVETIME();
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
        public Mod_TPB_STA_MOVETIME DataRowToModel(DataRow row)
        {
            Mod_TPB_STA_MOVETIME model = new Mod_TPB_STA_MOVETIME();
            if (row != null)
            {
                if (row["C_ID"] != null)
                {
                    model.C_ID = row["C_ID"].ToString();
                }
                if (row["C_STA_ID1"] != null)
                {
                    model.C_STA_ID1 = row["C_STA_ID1"].ToString();
                }
                if (row["C_STA_ID2"] != null)
                {
                    model.C_STA_ID2 = row["C_STA_ID2"].ToString();
                }
                if (row["N_TIME"] != null && row["N_TIME"].ToString() != "")
                {
                    model.N_TIME = decimal.Parse(row["N_TIME"].ToString());
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
            }
            return model;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_STA_ID1,C_STA_ID2,N_TIME,C_EMP_ID,D_MOD_DT,C_REMARK ");
            strSql.Append(" FROM TPB_STA_MOVETIME ");
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
            strSql.Append("select count(1) FROM TPB_STA_MOVETIME ");
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
            strSql.Append(")AS Row, T.*  from TPB_STA_MOVETIME T ");
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
					new OracleParameter(":PageSize", OracleDbType.Decimal),
					new OracleParameter(":PageIndex", OracleDbType.Decimal),
					new OracleParameter(":IsReCount", OracleType.Clob),
					new OracleParameter(":OrderType", OracleType.Clob),
					new OracleParameter(":strWhere", OracleDbType.Varchar2,1000),
					};
			parameters[0].Value = "TPB_STA_MOVETIME";
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

        /// <summary>
        /// 获取数据列表
        /// </summary>
        /// <param name="C_STA_ID1">开始工位</param>
        /// <param name="C_STA_ID2">结束工位</param>
        /// <param name="N_STATUS">状态</param>
        /// <returns></returns>
        public DataSet GetList(string C_STA_ID1, string C_STA_ID2, string N_STATUS)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_STA_ID1,C_STA_ID2,N_TIME,C_EMP_ID,D_MOD_DT,C_REMARK,DECODE(N_STATUS,1,'启用','停用') N_STATUS ");
            strSql.Append(" FROM TPB_STA_MOVETIME WHERE N_STATUS='" + N_STATUS + "' ");
            if (C_STA_ID1.Trim() != "")
            {
                strSql.Append(" AND C_STA_ID1='" + C_STA_ID1 + "' ");
            }
            if (C_STA_ID2.Trim() != "")
            {
                strSql.Append(" AND C_STA_ID2='" + C_STA_ID2 + "' ");
            }
            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        /// <param name="C_STA_ID1">工位1</param>
        /// <param name="C_STA_ID2">工位2</param>
        /// <returns></returns>
        public bool Delete(string C_STA_ID1, string C_STA_ID2)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from TPB_STA_MOVETIME ");
            strSql.Append(" where C_STA_ID1=:C_STA_ID1 ");
            strSql.Append(" and C_STA_ID2=:C_STA_ID2 ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_STA_ID1", OracleDbType.Varchar2,100),
             new OracleParameter(":C_STA_ID2", OracleDbType.Varchar2,100) };
            parameters[0].Value = C_STA_ID1;
            parameters[1].Value = C_STA_ID2;
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
        /// 根据工序/工位获取工位转移时间
        /// </summary>
        /// <param name="C_PRO_ID">开始工序</param>
        /// <param name="C_STA_ID1">开始工位</param>
        /// <param name="N_STATUS">状态</param>
        /// <returns></returns>
        public DataSet GetListByGXGW(string C_PRO_ID, string C_STA_ID1, string N_STATUS)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select a.C_ID,a.C_STA_ID1,a.C_STA_ID2,a.N_TIME,a.C_EMP_ID,a.D_MOD_DT FROM TPB_STA_MOVETIME a WHERE N_STATUS='" + N_STATUS + "'");
            if (C_PRO_ID.Trim() != "")
            {
                strSql.Append(" and a.c_sta_id1 IN (SELECT b.C_ID FROM TB_STA b WHERE b.C_PRO_ID='" + C_PRO_ID + "') ");
            }
         
            if (C_STA_ID1.Trim() != "")
            {
                strSql.Append(" AND a.C_STA_ID1='" + C_STA_ID1 + "' ");
            }
            return DbHelperOra.Query(strSql.ToString());
        }
        #endregion  ExtensionMethod
    }
}
