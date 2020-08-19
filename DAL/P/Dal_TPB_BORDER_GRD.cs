using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;
namespace DAL
{
    /// <summary>
    /// 数据访问类:TPB_BORDER_GRD
    /// </summary>
    public partial class Dal_TPB_BORDER_GRD
    {
        public Dal_TPB_BORDER_GRD()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string C_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TPB_BORDER_GRD");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)         };
            parameters[0].Value = C_ID;

            return DbHelperOra.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Mod_TPB_BORDER_GRD model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TPB_BORDER_GRD(");
            strSql.Append(" C_BORDER_STL_GRD,C_BORDER_STD_CODE,N_LEVEL,C_REMARK,N_STATUS,C_EMP_ID,D_MOD_DT,D_START_DATE,D_END_DATE,C_PRO_CONDITION_ID,C_SLAB_REQUIRE)");
            strSql.Append(" values (");
            strSql.Append(" :C_BORDER_STL_GRD,:C_BORDER_STD_CODE,:N_LEVEL,:C_REMARK,:N_STATUS,:C_EMP_ID,:D_MOD_DT,:D_START_DATE,:D_END_DATE,:C_PRO_CONDITION_ID,:C_SLAB_REQUIRE)");
            OracleParameter[] parameters = {

                    new OracleParameter(":C_BORDER_STL_GRD", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_BORDER_STD_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_LEVEL", OracleDbType.Decimal,3),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,200),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":D_START_DATE", OracleDbType.Date),
                    new OracleParameter(":D_END_DATE", OracleDbType.Date),
                    new OracleParameter(":C_PRO_CONDITION_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SLAB_REQUIRE", OracleDbType.Varchar2,200)};

            parameters[0].Value = model.C_BORDER_STL_GRD;
            parameters[1].Value = model.C_BORDER_STD_CODE;
            parameters[2].Value = model.N_LEVEL;
            parameters[3].Value = model.C_REMARK;
            parameters[4].Value = model.N_STATUS;
            parameters[5].Value = model.C_EMP_ID;
            parameters[6].Value = model.D_MOD_DT;
            parameters[7].Value = model.D_START_DATE;
            parameters[8].Value = model.D_END_DATE;
            parameters[9].Value = model.C_PRO_CONDITION_ID;
            parameters[10].Value = model.C_SLAB_REQUIRE;

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
        public bool Update(Mod_TPB_BORDER_GRD model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TPB_BORDER_GRD set ");
            strSql.Append("C_BORDER_STL_GRD=:C_BORDER_STL_GRD,");
            strSql.Append("C_BORDER_STD_CODE=:C_BORDER_STD_CODE,");
            strSql.Append("N_LEVEL=:N_LEVEL,");
            strSql.Append("C_REMARK=:C_REMARK,");
            strSql.Append("N_STATUS=:N_STATUS,");
            strSql.Append("C_EMP_ID=:C_EMP_ID,");
            strSql.Append("D_MOD_DT=:D_MOD_DT,");
            strSql.Append("D_START_DATE=:D_START_DATE,");
            strSql.Append("D_END_DATE=:D_END_DATE,");
            strSql.Append("C_PRO_CONDITION_ID=:C_PRO_CONDITION_ID,");
            strSql.Append("C_SLAB_REQUIRE=:C_SLAB_REQUIRE");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_BORDER_STL_GRD", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_BORDER_STD_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_LEVEL", OracleDbType.Decimal,3),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,200),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":D_START_DATE", OracleDbType.Date),
                    new OracleParameter(":D_END_DATE", OracleDbType.Date),
                    new OracleParameter(":C_PRO_CONDITION_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SLAB_REQUIRE", OracleDbType.Varchar2,200),
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.C_BORDER_STL_GRD;
            parameters[1].Value = model.C_BORDER_STD_CODE;
            parameters[2].Value = model.N_LEVEL;
            parameters[3].Value = model.C_REMARK;
            parameters[4].Value = model.N_STATUS;
            parameters[5].Value = model.C_EMP_ID;
            parameters[6].Value = model.D_MOD_DT;
            parameters[7].Value = model.D_START_DATE;
            parameters[8].Value = model.D_END_DATE;
            parameters[9].Value = model.C_PRO_CONDITION_ID;
            parameters[10].Value = model.C_SLAB_REQUIRE;
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
            strSql.Append("delete from TPB_BORDER_GRD ");
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
            strSql.Append("delete from TPB_BORDER_GRD ");
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
        public Mod_TPB_BORDER_GRD GetModel(string C_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_BORDER_STL_GRD,C_BORDER_STD_CODE,N_LEVEL,C_REMARK,N_STATUS,C_EMP_ID,D_MOD_DT,D_START_DATE,D_END_DATE,C_PRO_CONDITION_ID,C_SLAB_REQUIRE from TPB_BORDER_GRD ");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)         };
            parameters[0].Value = C_ID;

            Mod_TPB_BORDER_GRD model = new Mod_TPB_BORDER_GRD();
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
        public Mod_TPB_BORDER_GRD GetModel_GZ(string C_BORDER_STL_GRD, string C_BORDER_STD_CODE, string C_PRO_CONDITION_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_BORDER_STL_GRD,C_BORDER_STD_CODE,N_LEVEL,C_REMARK,N_STATUS,C_EMP_ID,D_MOD_DT,D_START_DATE,D_END_DATE,C_PRO_CONDITION_ID,C_SLAB_REQUIRE from TPB_BORDER_GRD ");
            strSql.Append(" where C_BORDER_STL_GRD=:C_BORDER_STL_GRD AND C_BORDER_STD_CODE=:C_BORDER_STD_CODE AND C_PRO_CONDITION_ID=:C_PRO_CONDITION_ID and N_STATUS=1");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_BORDER_STL_GRD", OracleDbType.Varchar2,100) ,
                new OracleParameter(":C_BORDER_STD_CODE", OracleDbType.Varchar2,100),
                new OracleParameter(":C_PRO_CONDITION_ID", OracleDbType.Varchar2,100)         };
            parameters[0].Value = C_BORDER_STL_GRD;
            parameters[1].Value = C_BORDER_STD_CODE;
            parameters[2].Value = C_PRO_CONDITION_ID;

            Mod_TPB_BORDER_GRD model = new Mod_TPB_BORDER_GRD();
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
        public Mod_TPB_BORDER_GRD DataRowToModel(DataRow row)
        {
            Mod_TPB_BORDER_GRD model = new Mod_TPB_BORDER_GRD();
            if (row != null)
            {
                if (row["C_ID"] != null)
                {
                    model.C_ID = row["C_ID"].ToString();
                }
                if (row["C_BORDER_STL_GRD"] != null)
                {
                    model.C_BORDER_STL_GRD = row["C_BORDER_STL_GRD"].ToString();
                }
                if (row["C_BORDER_STD_CODE"] != null)
                {
                    model.C_BORDER_STD_CODE = row["C_BORDER_STD_CODE"].ToString();
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
                if (row["C_SLAB_REQUIRE"] != null)
                {
                    model.C_SLAB_REQUIRE = row["C_SLAB_REQUIRE"].ToString();
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
            strSql.Append("SELECT B.N_GROUP,T1.C_ROUTE_TYPE,T1.C_ROUTE_DESC,T.C_ID,T.C_BORDER_STL_GRD,T.C_BORDER_STD_CODE,T.N_LEVEL,T.C_REMARK,T.N_STATUS,T.C_EMP_ID,T.D_MOD_DT,T.D_START_DATE,T.D_END_DATE,T.C_PRO_CONDITION_ID,T.C_SLAB_REQUIRE FROM TPB_BORDER_GRD T LEFT JOIN TPB_STEEL_PRO_CONDITION B  ON T.C_PRO_CONDITION_ID=B.C_ID  LEFT JOIN TQB_ROUTE T1 ON T.C_BORDER_STL_GRD = T1.C_STL_GRD AND T.C_BORDER_STD_CODE = T1.C_STD_CODE WHERE   T.N_STATUS = 1 AND B.N_STATUS = 1   ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" and t.C_PRO_CONDITION_ID = '" + strWhere + "' ");
            }
            strSql.Append(" order by t.N_LEVEL");
            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_BORDER_STL_GRD,C_BORDER_STD_CODE,N_LEVEL,C_REMARK,N_STATUS,C_EMP_ID,D_MOD_DT,D_START_DATE,D_END_DATE,C_PRO_CONDITION_ID,C_SLAB_REQUIRE ");
            strSql.Append(" FROM TPB_BORDER_GRD ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where  " + strWhere);
            }
            return DbHelperOra.Query(strSql.ToString());
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
            strSql.Append("update TPB_BORDER_GRD set N_LEVEL = N_LEVEL-1 where N_LEVEL>" + order + " and C_PRO_CONDITION_ID='" + C_PRO_CONDITION_ID + "'"); 
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
        /// 获取优先级的最大值
        /// </summary>
        /// <param name="C_PRO_CONDITION_ID">主表外键</param>
        /// <returns></returns>
        public DataSet GetList_Max(string C_PRO_CONDITION_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select MAX(N_LEVEL)as N_LEVEL ");
            strSql.Append(" FROM TPB_BORDER_GRD  ");
            if (C_PRO_CONDITION_ID.Trim() != "")
            {
                strSql.Append(" where  C_PRO_CONDITION_ID='"+ C_PRO_CONDITION_ID + "'");
            }
            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM TPB_BORDER_GRD ");
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
            strSql.Append(")AS Row, T.*  from TPB_BORDER_GRD T ");
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
			parameters[0].Value = "TPB_BORDER_GRD";
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
        /// 判断两个钢种能否进行混浇
        /// </summary>
        /// <param name="strGZ1">钢种1</param>
        /// <param name="strBZ1">标准1</param>
        /// <param name="strGZ2">钢种2</param>
        /// <param name="strBZ2">标准2</param>
        /// <returns>结果</returns>
        public bool NFHJ(string strGZ1, string strBZ1, string strGZ2, string strBZ2)
        {
            string sql = "SELECT T.C_STL_GRD, T.C_STD_CODE, TB.C_BORDER_STL_GRD, TB.C_BORDER_STD_CODE  FROM TPB_STEEL_PRO_CONDITION T, TPB_BORDER_GRD TB WHERE T.C_ID = TB.C_PRO_CONDITION_ID AND T.N_STATUS = 1  AND TB.N_STATUS = 1  AND T.C_STL_GRD = '" + strGZ1 + "'  AND T.C_STD_CODE = '" + strBZ1 + "'  AND TB.C_BORDER_STL_GRD = '" + strGZ2 + "'  AND TB.C_BORDER_STD_CODE = '" + strBZ2 + "'";
            int a = DbHelperOra.Query(sql.ToString()).Tables[0].Rows.Count;
            if (a > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        #endregion  ExtensionMethod
    }
}

