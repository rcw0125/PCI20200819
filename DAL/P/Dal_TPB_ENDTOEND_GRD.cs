using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;
namespace DAL
{
    /// <summary>
    /// 数据访问类:TPB_ENDTOEND_GRD
    /// </summary>
    public partial class Dal_TPB_ENDTOEND_GRD
    {
        public Dal_TPB_ENDTOEND_GRD()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string C_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TPB_ENDTOEND_GRD");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)         };
            parameters[0].Value = C_ID;

            return DbHelperOra.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Mod_TPB_ENDTOEND_GRD model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TPB_ENDTOEND_GRD(");
            strSql.Append("N_LEVEL,C_REMARK,N_STATUS,C_EMP_ID,D_MOD_DT,D_START_DATE,D_END_DATE,C_PRO_CONDITION_ID,C_B_E_STOVE,C_B_E_STOVE_STEEL,C_BORDER_STD_CODE)");
            strSql.Append(" values (");
            strSql.Append(":N_LEVEL,:C_REMARK,:N_STATUS,:C_EMP_ID,:D_MOD_DT,:D_START_DATE,:D_END_DATE,:C_PRO_CONDITION_ID,:C_B_E_STOVE,:C_B_E_STOVE_STEEL,:C_BORDER_STD_CODE)");
            OracleParameter[] parameters = {
                    new OracleParameter(":N_LEVEL", OracleDbType.Decimal ,3),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,200),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":D_START_DATE", OracleDbType.Date),
                    new OracleParameter(":D_END_DATE", OracleDbType.Date),
                    new OracleParameter(":C_PRO_CONDITION_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_B_E_STOVE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_B_E_STOVE_STEEL", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_BORDER_STD_CODE", OracleDbType.Varchar2,100)};

            parameters[0].Value = model.N_LEVEL;
            parameters[1].Value = model.C_REMARK;
            parameters[2].Value = model.N_STATUS;
            parameters[3].Value = model.C_EMP_ID;
            parameters[4].Value = model.D_MOD_DT;
            parameters[5].Value = model.D_START_DATE;
            parameters[6].Value = model.D_END_DATE;
            parameters[7].Value = model.C_PRO_CONDITION_ID;
            parameters[8].Value = model.C_B_E_STOVE;
            parameters[9].Value = model.C_B_E_STOVE_STEEL;
            parameters[10].Value = model.C_BORDER_STD_CODE;

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
        public bool Update(Mod_TPB_ENDTOEND_GRD model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TPB_ENDTOEND_GRD set ");
            strSql.Append("N_LEVEL=:N_LEVEL,");
            strSql.Append("C_REMARK=:C_REMARK,");
            strSql.Append("N_STATUS=:N_STATUS,");
            strSql.Append("C_EMP_ID=:C_EMP_ID,");
            strSql.Append("D_MOD_DT=:D_MOD_DT,");
            strSql.Append("D_START_DATE=:D_START_DATE,");
            strSql.Append("D_END_DATE=:D_END_DATE,");
            strSql.Append("C_PRO_CONDITION_ID=:C_PRO_CONDITION_ID,");
            strSql.Append("C_B_E_STOVE=:C_B_E_STOVE,");
            strSql.Append("C_B_E_STOVE_STEEL=:C_B_E_STOVE_STEEL,");
            strSql.Append("C_BORDER_STD_CODE=:C_BORDER_STD_CODE");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":N_LEVEL", OracleDbType.Decimal,3),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,200),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":D_START_DATE", OracleDbType.Date),
                    new OracleParameter(":D_END_DATE", OracleDbType.Date),
                    new OracleParameter(":C_PRO_CONDITION_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_B_E_STOVE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_B_E_STOVE_STEEL", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_BORDER_STD_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.N_LEVEL;
            parameters[1].Value = model.C_REMARK;
            parameters[2].Value = model.N_STATUS;
            parameters[3].Value = model.C_EMP_ID;
            parameters[4].Value = model.D_MOD_DT;
            parameters[5].Value = model.D_START_DATE;
            parameters[6].Value = model.D_END_DATE;
            parameters[7].Value = model.C_PRO_CONDITION_ID;
            parameters[8].Value = model.C_B_E_STOVE;
            parameters[9].Value = model.C_B_E_STOVE_STEEL;
            parameters[10].Value = model.C_BORDER_STD_CODE;
            parameters[11].Value = model.C_ID;

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
            strSql.Append("delete from TPB_ENDTOEND_GRD ");
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
            strSql.Append("delete from TPB_ENDTOEND_GRD ");
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
        public Mod_TPB_ENDTOEND_GRD GetModel(string C_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,N_LEVEL,C_REMARK,N_STATUS,C_EMP_ID,D_MOD_DT,D_START_DATE,D_END_DATE,C_PRO_CONDITION_ID,C_B_E_STOVE,C_B_E_STOVE_STEEL,C_BORDER_STD_CODE from TPB_ENDTOEND_GRD ");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)         };
            parameters[0].Value = C_ID;

            Mod_TPB_ENDTOEND_GRD model = new Mod_TPB_ENDTOEND_GRD();
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
        public Mod_TPB_ENDTOEND_GRD GetModel_GZ(string C_B_E_STOVE_STEEL, string C_BORDER_STD_CODE, string C_PRO_CONDITION_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,N_LEVEL,C_REMARK,N_STATUS,C_EMP_ID,D_MOD_DT,D_START_DATE,D_END_DATE,C_PRO_CONDITION_ID,C_B_E_STOVE,C_B_E_STOVE_STEEL,C_BORDER_STD_CODE from TPB_ENDTOEND_GRD ");
            strSql.Append(" where C_B_E_STOVE_STEEL=:C_B_E_STOVE_STEEL AND C_BORDER_STD_CODE=:C_BORDER_STD_CODE AND C_PRO_CONDITION_ID=:C_PRO_CONDITION_ID AND N_STATUS=1");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_B_E_STOVE_STEEL", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_BORDER_STD_CODE", OracleDbType.Varchar2,100)   ,
                    new OracleParameter(":C_PRO_CONDITION_ID", OracleDbType.Varchar2,100)         };
            parameters[0].Value = C_B_E_STOVE_STEEL;
            parameters[1].Value = C_BORDER_STD_CODE;
            parameters[2].Value = C_PRO_CONDITION_ID;

            Mod_TPB_ENDTOEND_GRD model = new Mod_TPB_ENDTOEND_GRD();
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
        public Mod_TPB_ENDTOEND_GRD DataRowToModel(DataRow row)
        {
            Mod_TPB_ENDTOEND_GRD model = new Mod_TPB_ENDTOEND_GRD();
            if (row != null)
            {
                if (row["C_ID"] != null)
                {
                    model.C_ID = row["C_ID"].ToString();
                }
                if (row["N_LEVEL"] != null && row["N_LEVEL"].ToString() != "")
                {
                    model.N_LEVEL = decimal.Parse(row["N_LEVEL"].ToString());
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
                if (row["C_PRO_CONDITION_ID"] != null)
                {
                    model.C_PRO_CONDITION_ID = row["C_PRO_CONDITION_ID"].ToString();
                }
                if (row["C_B_E_STOVE"] != null)
                {
                    model.C_B_E_STOVE = row["C_B_E_STOVE"].ToString();
                }
                if (row["C_B_E_STOVE_STEEL"] != null)
                {
                    model.C_B_E_STOVE_STEEL = row["C_B_E_STOVE_STEEL"].ToString();
                }
                if (row["C_BORDER_STD_CODE"] != null)
                {
                    model.C_BORDER_STD_CODE = row["C_BORDER_STD_CODE"].ToString();
                }
            }
            return model;
        }
        /// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList_Query(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT T1.C_ROUTE_DESC, T.C_ID,T.N_LEVEL,T.C_REMARK,T.N_STATUS,T.C_EMP_ID,T.D_MOD_DT,T.D_START_DATE,T.D_END_DATE,T.C_PRO_CONDITION_ID,T.C_B_E_STOVE,T.C_B_E_STOVE_STEEL,T.C_BORDER_STD_CODE FROM TPB_ENDTOEND_GRD T LEFT JOIN TQB_ROUTE T1 ON T1.N_STATUS = 1 AND T.C_B_E_STOVE_STEEL = T1.C_STL_GRD  AND T.C_BORDER_STD_CODE = T1.C_STD_CODE  WHERE T.N_STATUS = 1 ");
            if (strWhere.Trim() != "")
            {
                strSql.Append("  and T.C_PRO_CONDITION_ID = '" + strWhere + "' ");
            }
            strSql.Append("  order by T.N_LEVEL");
            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,N_LEVEL,C_REMARK,N_STATUS,C_EMP_ID,D_MOD_DT,D_START_DATE,D_END_DATE,C_PRO_CONDITION_ID,C_B_E_STOVE,C_B_E_STOVE_STEEL,C_BORDER_STD_CODE ");
            strSql.Append(" FROM TPB_ENDTOEND_GRD ");
            if (strWhere.Trim() != "")
            {
                strSql.Append("  where " + strWhere);
            }
            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 获取优先级最大值
        /// </summary>
        /// <param name="C_PRO_CONDITION_ID">主表外键</param>
        /// <returns></returns>
        public DataSet GetList_Max(string C_PRO_CONDITION_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  MAX(N_LEVEL)as N_LEVEL ");
            strSql.Append(" FROM TPB_ENDTOEND_GRD ");
            if (C_PRO_CONDITION_ID.Trim() != "")
            {
                strSql.Append("  where  C_PRO_CONDITION_ID='"+ C_PRO_CONDITION_ID + "'");
            }
            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList_Condition(string strSTD ,string strSTL)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select t.c_b_e_stove,t.c_b_e_stove_steel,t.c_border_std_code from TPB_ENDTOEND_GRD t  left join TPB_STEEL_PRO_CONDITION a on t.c_pro_condition_id=a.c_id ");
            strSql.Append(" FROM TPB_ENDTOEND_GRD  where a.n_status=1 ");
            if (strSTD.Trim() != "")
            {
                strSql.Append("  and a.c_stl_grd='"+ strSTD + "' ");
            }
            if (strSTL.Trim() != "")
            {
                strSql.Append("  and a.c_stl_grd='" + strSTL + "' ");
            }
            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM TPB_ENDTOEND_GRD ");
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
        /// 修改大于当前删除行的优先级
        /// </summary>
        /// <param name="order">优先级</param>
        /// <param name="C_PRO_CONDITION_ID">主表外键</param>
        /// <returns></returns>
        public bool Update_Order(int order, string C_PRO_CONDITION_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TPB_ENDTOEND_GRD set N_LEVEL = N_LEVEL-1 where N_LEVEL>" + order + " and C_PRO_CONDITION_ID='" + C_PRO_CONDITION_ID + "'");
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
            strSql.Append(")AS Row, T.*  from TPB_ENDTOEND_GRD T ");
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
			parameters[0].Value = "TPB_ENDTOEND_GRD";
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
        /// <param name="c_stl_grd">钢种</param>
        /// <param name="c_std_code">执行标准</param>
        /// <returns></returns>
        public DataSet GetList(string c_stl_grd, string c_std_code)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT C_B_E_STOVE,C_B_E_STOVE_STEEL,C_BORDER_STD_CODE from TPB_ENDTOEND_GRD a,TPB_STEEL_PRO_CONDITION b WHERE a.c_pro_condition_id=b.c_id and a.n_Status=1 ");
            if (c_stl_grd.Trim() != "")
            {
                strSql.Append(" AND  b.c_stl_grd='" + c_stl_grd + "'");
            }
            if (c_stl_grd.Trim() != "")
            {
                strSql.Append(" AND  b.c_std_code='" + c_std_code + "'");
            }
            return DbHelperOra.Query(strSql.ToString());
        }


        /// <summary>
        /// 查询产品是否需要首尾炉钢种
        /// </summary>
        /// <param name="C_STL_GRD">钢种</param>
        /// <param name="C_STD_CODE">执行标准</param>
        /// <param name="C_B_E_STOVE">首炉/尾炉</param>
        /// <returns>首尾炉钢种信息</returns>
        public DataTable GetSWLSteel(string C_STL_GRD, string C_STD_CODE, string C_B_E_STOVE)
        {
            string sql = "SELECT T.C_STL_GRD, T.C_STD_CODE, TB.C_B_E_STOVE, TB.C_B_E_STOVE_STEEL, TB.C_BORDER_STD_CODE FROM TPB_STEEL_PRO_CONDITION T, TPB_ENDTOEND_GRD TB WHERE T.N_STATUS = 1 AND TB.N_STATUS = 1 AND T.C_ID = TB.C_PRO_CONDITION_ID AND T.C_STL_GRD<>TB.C_B_E_STOVE_STEEL AND T.C_STD_CODE<>TB.C_BORDER_STD_CODE ";
            sql = sql + " AND T.C_STL_GRD='" + C_STL_GRD + "'";


            if (C_STD_CODE.Contains("Q/XG") || C_STD_CODE.Contains("GB/T") || C_STD_CODE.Contains("Q/邢钢"))
            {
                C_STD_CODE = C_STD_CODE.Split('-')[0].Split('.')[0];

            }
            sql = sql + " AND T.C_STD_CODE='" + C_STD_CODE + "'";
            if (C_B_E_STOVE.Trim() != "")
            {
                sql = sql + " AND TB.C_B_E_STOVE like '%" + C_B_E_STOVE + "%' ";
            }

            return DbHelperOra.Query(sql.ToString()).Tables[0];
        }
        #endregion  ExtensionMethod
    }
}

