using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;
namespace DAL
{
    /// <summary>
    /// 数据访问类:TPB_CHANGESPEC_TIME
    /// </summary>
    public partial class Dal_TPB_CHANGESPEC_TIME
    {
        public Dal_TPB_CHANGESPEC_TIME()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string C_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TPB_CHANGESPEC_TIME");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)          };
            parameters[0].Value = C_ID;

            return DbHelperOra.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Mod_TPB_CHANGESPEC_TIME model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TPB_CHANGESPEC_TIME(");
            strSql.Append("C_STA_ID,C_B_SPEC,C_L_SPEC,N_TIME,C_REMARK,N_STATUS,C_EMP_ID,D_MOD_DT,D_START_DATE,D_END_DATE)");
            strSql.Append(" values (");
            strSql.Append(":C_STA_ID,:C_B_SPEC,:C_L_SPEC,:N_TIME,:C_REMARK,:N_STATUS,:C_EMP_ID,:D_MOD_DT,:D_START_DATE,:D_END_DATE)");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_STA_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_B_SPEC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_L_SPEC", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_TIME", OracleDbType.Decimal,3),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,200),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":D_START_DATE", OracleDbType.Date),
                    new OracleParameter(":D_END_DATE", OracleDbType.Date)};
            parameters[0].Value = model.C_STA_ID;
            parameters[1].Value = model.C_B_SPEC;
            parameters[2].Value = model.C_L_SPEC;
            parameters[3].Value = model.N_TIME;
            parameters[4].Value = model.C_REMARK;
            parameters[5].Value = model.N_STATUS;
            parameters[6].Value = model.C_EMP_ID;
            parameters[7].Value = model.D_MOD_DT;
            parameters[8].Value = model.D_START_DATE;
            parameters[9].Value = model.D_END_DATE;

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
        public bool Update(Mod_TPB_CHANGESPEC_TIME model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TPB_CHANGESPEC_TIME set ");
            strSql.Append("C_STA_ID=:C_STA_ID,");
            strSql.Append("C_B_SPEC=:C_B_SPEC,");
            strSql.Append("C_L_SPEC=:C_L_SPEC,");
            strSql.Append("N_TIME=:N_TIME,");
            strSql.Append("C_REMARK=:C_REMARK,");
            strSql.Append("N_STATUS=:N_STATUS,");
            strSql.Append("C_EMP_ID=:C_EMP_ID,");
            strSql.Append("D_MOD_DT=:D_MOD_DT,");
            strSql.Append("D_START_DATE=:D_START_DATE,");
            strSql.Append("D_END_DATE=:D_END_DATE");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_STA_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_B_SPEC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_L_SPEC", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_TIME", OracleDbType.Decimal,3),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,200),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":D_START_DATE", OracleDbType.Date),
                    new OracleParameter(":D_END_DATE", OracleDbType.Date),
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.C_STA_ID;
            parameters[1].Value = model.C_B_SPEC;
            parameters[2].Value = model.C_L_SPEC;
            parameters[3].Value = model.N_TIME;
            parameters[4].Value = model.C_REMARK;
            parameters[5].Value = model.N_STATUS;
            parameters[6].Value = model.C_EMP_ID;
            parameters[7].Value = model.D_MOD_DT;
            parameters[8].Value = model.D_START_DATE;
            parameters[9].Value = model.D_END_DATE;
            parameters[10].Value = model.C_ID;

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
            strSql.Append("delete from TPB_CHANGESPEC_TIME ");
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
            strSql.Append("delete from TPB_CHANGESPEC_TIME ");
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
        public Mod_TPB_CHANGESPEC_TIME GetModel(string C_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_STA_ID,C_B_SPEC,C_L_SPEC,N_TIME,C_REMARK,N_STATUS,C_EMP_ID,D_MOD_DT,D_START_DATE,D_END_DATE from TPB_CHANGESPEC_TIME ");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)          };
            parameters[0].Value = C_ID;

            Mod_TPB_CHANGESPEC_TIME model = new Mod_TPB_CHANGESPEC_TIME();
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
        public Mod_TPB_CHANGESPEC_TIME DataRowToModel(DataRow row)
        {
            Mod_TPB_CHANGESPEC_TIME model = new Mod_TPB_CHANGESPEC_TIME();
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
                if (row["C_B_SPEC"] != null)
                {
                    model.C_B_SPEC = row["C_B_SPEC"].ToString();
                }
                if (row["C_L_SPEC"] != null)
                {
                    model.C_L_SPEC = row["C_L_SPEC"].ToString();
                }
                if (row["N_TIME"] != null && row["N_TIME"].ToString() != "")
                {
                    model.N_TIME = decimal.Parse(row["N_TIME"].ToString());
                }
                if (row["C_REMARK"] != null)
                {
                    model.C_REMARK = row["C_REMARK"].ToString();
                }
                if (row["N_STATUS"] != null && row["N_STATUS"].ToString() != "")
                {
                    model.N_STATUS = decimal.Parse(row["N_STATUS"].ToString());
                }
                if (row["C_EMP_ID"] != null)
                {
                    model.C_EMP_ID = row["C_EMP_ID"].ToString();
                }
                if (row["D_MOD_DT"] != null && row["D_MOD_DT"].ToString() != "")
                {
                    model.D_MOD_DT = DateTime.Parse(row["D_MOD_DT"].ToString());
                }
                if (row["D_START_DATE"] != null && row["D_START_DATE"].ToString() != "")
                {
                    model.D_START_DATE = DateTime.Parse(row["D_START_DATE"].ToString());
                }
                if (row["D_END_DATE"] != null && row["D_END_DATE"].ToString() != "")
                {
                    model.D_END_DATE = DateTime.Parse(row["D_END_DATE"].ToString());
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
            strSql.Append("select C_ID,C_STA_ID,C_B_SPEC,C_L_SPEC,N_TIME,C_REMARK,N_STATUS,C_EMP_ID,D_MOD_DT,D_START_DATE,D_END_DATE ");
            strSql.Append(" FROM TPB_CHANGESPEC_TIME ");
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
            strSql.Append("select count(1) FROM TPB_CHANGESPEC_TIME ");
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
            strSql.Append(")AS Row, T.*  from TPB_CHANGESPEC_TIME T ");
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
			parameters[0].Value = "TPB_CHANGESPEC_TIME";
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
        /// 获得数据列表
        /// </summary>
        /// <param name="staid"></param>
        /// <param name="C_B_SPEC"></param>
        /// <returns></returns>
        public DataSet GetGGSJ(string staid, string C_B_SPEC)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select DISTINCT C_SPEC,'' as N_TIME");
            strSql.Append(" FROM TQB_STD_SPEC where N_STATUS=1 ");
            strSql.Append(" and C_SPEC not in (select t.C_L_SPEC from TPB_CHANGESPEC_TIME t where  t.N_STATUS=1 and t.c_sta_id='" + staid + "'and t.C_B_SPEC = '" + C_B_SPEC + "' )");
            strSql.Append("  and C_SPEC not in '" + C_B_SPEC + "'");
            strSql.Append("  ORDER BY to_number(replace(C_SPEC, 'φ', ''))");
            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(int status, string C_STA_ID, string C_B_SPEC, string C_L_SPEC)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_STA_ID,C_B_SPEC,C_L_SPEC,N_TIME,C_REMARK,N_STATUS,C_EMP_ID,D_MOD_DT,D_START_DATE,D_END_DATE ");
            strSql.Append(" FROM TPB_CHANGESPEC_TIME where N_STATUS='" + status + "'");
            if (C_STA_ID.Trim() != "")
            {
                strSql.Append(" and C_STA_ID='" + C_STA_ID + "'  ");
            }
            if (C_B_SPEC.Trim() != "")
            {
                strSql.Append(" and to_number(replace(C_B_SPEC, 'φ', ''))=to_number(replace('" + C_B_SPEC + "', 'φ', ''))  ");
            }
            if (C_L_SPEC.Trim() != "")
            {
                strSql.Append(" and to_number(replace(C_L_SPEC, 'φ', ''))=to_number(replace('" + C_L_SPEC + "', 'φ', ''))  ");
            }
            strSql.Append(" ORDER BY C_STA_ID,to_number(replace(C_B_SPEC, 'φ', '')),to_number(replace(C_L_SPEC, 'φ', ''))");
            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取换规格时间
        /// </summary>
        /// <param name="c_line_code">轧线</param>
        /// <param name="C_B_SPEC">更换前规格</param>
        /// <param name="C_L_SPEC">更换后规格</param>
        /// <returns></returns>
        public int Get_Time(string c_line_code, string C_B_SPEC, string C_L_SPEC)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select max(ta.n_time)  FROM TPB_CHANGESPEC_TIME ta inner join tb_sta tb on tb.c_id = ta.c_sta_id where ta.N_STATUS = '1' and tb.C_STA_CODE = '" + c_line_code + "' and ta.C_B_SPEC = '" + C_B_SPEC + "' and ta.C_L_SPEC = '" + C_L_SPEC + "' ");
            
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
        /// 获取换规格时间
        /// </summary>
        /// <param name="strLineID">轧线ID</param>
        /// <param name="C_B_SPEC">更换前规格</param>
        /// <param name="C_L_SPEC">更换后规格</param>
        /// <returns></returns>
        public int Get_Time2(string strLineID, string C_B_SPEC, string C_L_SPEC)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select max(ta.n_time)  FROM TPB_CHANGESPEC_TIME ta inner join tb_sta tb on tb.c_id = ta.c_sta_id where ta.N_STATUS = '1' and tb.C_ID = '" + strLineID + "' and ta.C_B_SPEC = '" + C_B_SPEC + "' and ta.C_L_SPEC = '" + C_L_SPEC + "' ");

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

