using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;

namespace DAL
{
    /// <summary>
    /// 数据访问类:TQB_REPLACE_SLAB
    /// </summary>
    public partial class Dal_TQB_REPLACE_SLAB
    {
        public Dal_TQB_REPLACE_SLAB()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string C_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TQB_REPLACE_SLAB");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)         };
            parameters[0].Value = C_ID;

            return DbHelperOra.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Mod_TQB_REPLACE_SLAB model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TQB_REPLACE_SLAB(");
            strSql.Append("C_STL_GRD,C_STL_GRD_SLAB,C_STD_CODE,C_STD_CODE_SLAB,N_STATUS,C_EMP_ID,D_MOD_DT,C_REMARK,C_SF_BXG,C_XM,C_DFP)");
            strSql.Append(" values (");
            strSql.Append(":C_STL_GRD,:C_STL_GRD_SLAB,:C_STD_CODE,:C_STD_CODE_SLAB,:N_STATUS,:C_EMP_ID,:D_MOD_DT,:C_REMARK,:C_SF_BXG,:C_XM,:C_DFP)");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_STL_GRD", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STL_GRD_SLAB", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STD_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STD_CODE_SLAB", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_SF_BXG", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_XM", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_DFP", OracleDbType.Varchar2,100)
            };
            parameters[0].Value = model.C_STL_GRD;
            parameters[1].Value = model.C_STL_GRD_SLAB;
            parameters[2].Value = model.C_STD_CODE;
            parameters[3].Value = model.C_STD_CODE_SLAB;
            parameters[4].Value = model.N_STATUS;
            parameters[5].Value = model.C_EMP_ID;
            parameters[6].Value = model.D_MOD_DT;
            parameters[7].Value = model.C_REMARK;
            parameters[8].Value = model.C_SF_BXG;
            parameters[9].Value = model.C_XM;
            parameters[10].Value = model.C_DFP;

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
        public bool Update(Mod_TQB_REPLACE_SLAB model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TQB_REPLACE_SLAB set ");
            strSql.Append("C_STL_GRD=:C_STL_GRD,");
            strSql.Append("C_STL_GRD_SLAB=:C_STL_GRD_SLAB,");
            strSql.Append("C_STD_CODE=:C_STD_CODE,");
            strSql.Append("C_STD_CODE_SLAB=:C_STD_CODE_SLAB,");
            strSql.Append("N_STATUS=:N_STATUS,");
            strSql.Append("C_EMP_ID=:C_EMP_ID,");
            strSql.Append("D_MOD_DT=:D_MOD_DT,");
            strSql.Append("C_REMARK=:C_REMARK,");
            strSql.Append("C_SF_BXG=:C_SF_BXG,");
            strSql.Append("C_XM=:C_XM,");
            strSql.Append("C_DFP=:C_DFP");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_STL_GRD", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STL_GRD_SLAB", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STD_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STD_CODE_SLAB", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_SF_BXG", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_XM", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_DFP", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)
            };
            parameters[0].Value = model.C_STL_GRD;
            parameters[1].Value = model.C_STL_GRD_SLAB;
            parameters[2].Value = model.C_STD_CODE;
            parameters[3].Value = model.C_STD_CODE_SLAB;
            parameters[4].Value = model.N_STATUS;
            parameters[5].Value = model.C_EMP_ID;
            parameters[6].Value = model.D_MOD_DT;
            parameters[7].Value = model.C_REMARK;
            parameters[8].Value = model.C_SF_BXG;
            parameters[9].Value = model.C_XM;
            parameters[10].Value = model.C_DFP;
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
            strSql.Append("delete from TQB_REPLACE_SLAB ");
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
            strSql.Append("delete from TQB_REPLACE_SLAB ");
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
        public Mod_TQB_REPLACE_SLAB GetModel(string C_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_STL_GRD,C_STL_GRD_SLAB,C_STD_CODE,C_STD_CODE_SLAB,N_STATUS,C_EMP_ID,D_MOD_DT,C_REMARK,C_SF_BXG,C_XM,C_DFP from TQB_REPLACE_SLAB ");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)         };
            parameters[0].Value = C_ID;

            Mod_TQB_REPLACE_SLAB model = new Mod_TQB_REPLACE_SLAB();
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
        public Mod_TQB_REPLACE_SLAB DataRowToModel(DataRow row)
        {
            Mod_TQB_REPLACE_SLAB model = new Mod_TQB_REPLACE_SLAB();
            if (row != null)
            {
                if (row["C_ID"] != null)
                {
                    model.C_ID = row["C_ID"].ToString();
                }
                if (row["C_STL_GRD"] != null)
                {
                    model.C_STL_GRD = row["C_STL_GRD"].ToString();
                }
                if (row["C_STL_GRD_SLAB"] != null)
                {
                    model.C_STL_GRD_SLAB = row["C_STL_GRD_SLAB"].ToString();
                }
                if (row["C_STD_CODE"] != null)
                {
                    model.C_STD_CODE = row["C_STD_CODE"].ToString();
                }
                if (row["C_STD_CODE_SLAB"] != null)
                {
                    model.C_STD_CODE_SLAB = row["C_STD_CODE_SLAB"].ToString();
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
                if (row["C_REMARK"] != null)
                {
                    model.C_REMARK = row["C_REMARK"].ToString();
                }
                if (row["C_SF_BXG"] != null)
                {
                    model.C_SF_BXG = row["C_SF_BXG"].ToString();
                }
                if (row["C_XM"] != null)
                {
                    model.C_XM = row["C_XM"].ToString();
                }
                if (row["C_DFP"] != null)
                {
                    model.C_DFP = row["C_DFP"].ToString();
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
            strSql.Append("select C_ID,C_STL_GRD,C_STL_GRD_SLAB,C_STD_CODE,C_STD_CODE_SLAB,N_STATUS,C_EMP_ID,D_MOD_DT,C_REMARK,C_SF_BXG,C_XM,C_DFP ");
            strSql.Append(" FROM TQB_REPLACE_SLAB ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        /// <param name="C_SF_BXG">是否为不锈钢</param>
        /// <param name="C_STL_GRD">钢种</param>
        /// <param name="C_STD_CODE">执行标准</param>
        /// <returns></returns>
		public DataSet GetList_Query(string C_SF_BXG, string C_STL_GRD, string C_STD_CODE)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_STL_GRD,C_STL_GRD_SLAB,C_STD_CODE,C_STD_CODE_SLAB,N_STATUS,C_EMP_ID,D_MOD_DT,C_REMARK,C_SF_BXG,C_XM,C_DFP ");
            strSql.Append(" FROM TQB_REPLACE_SLAB WHERE N_STATUS=1");
            if (C_SF_BXG.Trim() != "")
            {
                strSql.Append(" AND C_SF_BXG = '" + C_SF_BXG + "' ");
            }
            if (C_STL_GRD.Trim() != "")
            {
                strSql.Append(" AND C_STL_GRD = '" + C_STL_GRD + "' ");
            }
            if (C_STD_CODE.Trim() != "")
            {
                strSql.Append(" AND C_STD_CODE = '" + C_STD_CODE + "' ");
            }
            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM TQB_REPLACE_SLAB ");
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
            strSql.Append(")AS Row, T.*  from TQB_REPLACE_SLAB T ");
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
			parameters[0].Value = "TQB_REPLACE_SLAB";
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

        #endregion  ExtensionMethod

        #region lj


        /// <summary>
        /// 查询是否使用替代钢坯进行炼钢生产
        /// </summary>
        /// <param name="C_STL_GRD">订单钢种</param>
        /// <param name="C_STD_CODE">订单标准</param>
        /// <returns></returns>
        public DataTable GetReplaceSlab(string C_STL_GRD, string C_STD_CODE) 
        {
            string sql = @" SELECT T.C_STL_GRD_SLAB, T.C_STD_CODE_SLAB
          FROM TQB_REPLACE_SLAB T  WHERE T.C_STL_GRD ='" + C_STL_GRD + "' AND T.N_STATUS=1  AND T.C_STD_CODE = '" + C_STD_CODE + "' AND ROWNUM = 1";
            return DbHelperOra.Query(sql).Tables[0];


        }
        #endregion
    }
}

