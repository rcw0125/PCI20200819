using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;
namespace DAL
{
    /// <summary>
    /// 数据访问类:TQB_SLAB_LEN_MATCH
    /// </summary>
    public partial class Dal_TQB_SLAB_LEN_MATCH
    {
        public Dal_TQB_SLAB_LEN_MATCH()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string C_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TQB_SLAB_LEN_MATCH");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)          };
            parameters[0].Value = C_ID;

            return DbHelperOra.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Mod_TQB_SLAB_LEN_MATCH model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TQB_SLAB_LEN_MATCH(");
            strSql.Append("C_STD_ID,C_SLAB_ID,N_STATUS,C_REMARK,C_EMP_ID,C_GROUP,C_ORDER,C_STD_CODE,C_STL_GRD)");
            strSql.Append(" values (");
            strSql.Append(":C_STD_ID,:C_SLAB_ID,:N_STATUS,:C_REMARK,:C_EMP_ID,:C_GROUP,:C_ORDER,:C_STD_CODE,:C_STL_GRD)");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_STD_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SLAB_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,200),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_GROUP", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ORDER", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STD_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STL_GRD", OracleDbType.Varchar2,100)
            };
            parameters[0].Value = model.C_STD_ID;
            parameters[1].Value = model.C_SLAB_ID;
            parameters[2].Value = model.N_STATUS;
            parameters[3].Value = model.C_REMARK;
            parameters[4].Value = model.C_EMP_ID;
            parameters[5].Value = model.C_GROUP;
            parameters[6].Value = model.C_ORDER;
            parameters[7].Value = model.C_STD_CODE;
            parameters[8].Value = model.C_STL_GRD;

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
        public bool Update(Mod_TQB_SLAB_LEN_MATCH model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TQB_SLAB_LEN_MATCH set ");
            strSql.Append("C_STD_ID=:C_STD_ID,");
            strSql.Append("C_SLAB_ID=:C_SLAB_ID,");
            strSql.Append("N_STATUS=:N_STATUS,");
            strSql.Append("C_REMARK=:C_REMARK,");
            strSql.Append("C_EMP_ID=:C_EMP_ID,");
            strSql.Append("C_GROUP=:C_GROUP,");
            strSql.Append("C_ORDER=:C_ORDER,");
            strSql.Append("C_STD_CODE=:C_STD_CODE,");
            strSql.Append("C_STL_GRD=:C_STL_GRD");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_STD_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SLAB_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,200),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_GROUP", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ORDER", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STD_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STL_GRD", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.C_STD_ID;
            parameters[1].Value = model.C_SLAB_ID;
            parameters[2].Value = model.N_STATUS;
            parameters[3].Value = model.C_REMARK;
            parameters[4].Value = model.C_EMP_ID;
            parameters[5].Value = model.C_GROUP;
            parameters[6].Value = model.C_ORDER;
            parameters[7].Value = model.C_STD_CODE;
            parameters[8].Value = model.C_STL_GRD;
            parameters[9].Value = model.C_ID;

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
            strSql.Append("delete from TQB_SLAB_LEN_MATCH ");
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
            strSql.Append("delete from TQB_SLAB_LEN_MATCH ");
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
        public Mod_TQB_SLAB_LEN_MATCH GetModel(string C_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_STD_ID,C_SLAB_ID,N_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT,C_GROUP,C_ORDER,C_STD_CODE,C_STL_GRD from TQB_SLAB_LEN_MATCH ");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)          };
            parameters[0].Value = C_ID;

            Mod_TQB_SLAB_LEN_MATCH model = new Mod_TQB_SLAB_LEN_MATCH();
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
        public Mod_TQB_SLAB_LEN_MATCH DataRowToModel(DataRow row)
        {
            Mod_TQB_SLAB_LEN_MATCH model = new Mod_TQB_SLAB_LEN_MATCH();
            if (row != null)
            {
                if (row["C_ID"] != null)
                {
                    model.C_ID = row["C_ID"].ToString();
                }
                if (row["C_STD_ID"] != null)
                {
                    model.C_STD_ID = row["C_STD_ID"].ToString();
                }
                if (row["C_SLAB_ID"] != null)
                {
                    model.C_SLAB_ID = row["C_SLAB_ID"].ToString();
                }
                if (row["N_STATUS"] != null && row["N_STATUS"].ToString() != "")
                {
                    model.N_STATUS = decimal.Parse(row["N_STATUS"].ToString());
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
                if (row["C_GROUP"] != null)
                {
                    model.C_GROUP = row["C_GROUP"].ToString();
                }
                if (row["C_ORDER"] != null)
                {
                    model.C_ORDER = row["C_ORDER"].ToString();
                }
                if (row["C_STD_CODE"] != null)
                {
                    model.C_STD_CODE = row["C_STD_CODE"].ToString();
                }
                if (row["C_STL_GRD"] != null)
                {
                    model.C_STL_GRD = row["C_STL_GRD"].ToString();
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
            strSql.Append("select C_ID,C_STD_ID,C_SLAB_ID,N_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT,C_GROUP ,C_ORDER,C_STD_CODE,C_STL_GRD");
            strSql.Append(" FROM TQB_SLAB_LEN_MATCH ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetSlabMatch(string C_STD_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select (SELECT MAX( TT.C_MAT_CODE)   FROM TB_MATRL_MAIN TT WHERE TT.C_MAT_TYPE = 6 AND tt.c_stl_grd=b.c_stl_grd AND tt.n_lth=a.c_cold_len AND TT.C_SLAB_SIZE=A.C_SLAB_SIZE) AS C_MAT_CODE, b.C_ID,a.C_SLAB_SIZE,a.C_TYPE,a.C_HOT_LEN,a.C_COLD_LEN,a.C_THE_WEIGHT,a.N_STATUS,a.C_REMARK,b.C_EMP_ID,b.D_MOD_DT,C_GROUP as C_GROUP1,B.C_ORDER ,b.C_STD_CODE,b.C_STL_GRD");
            strSql.Append(" from Tqb_Slab_Len_Match b inner join tqb_slab_len a on b.c_slab_id=a.c_id where b.N_STATUS=1  ");
            if (C_STD_ID.Trim() != "")
            {
                strSql.Append(" and b.c_std_id='" + C_STD_ID + "'");
            }
            strSql.Append(" ORDER BY TO_NUMBER(B.C_ORDER) ");
            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetMatchZJB(string C_STD_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("  ");
            strSql.Append(" from Tqb_Slab_Len_Match b inner join tqb_slab_len a on b.c_slab_id=a.c_id where b.N_STATUS=1  ");
            if (C_STD_ID.Trim() != "")
            {
                strSql.Append(" and b.c_std_id='" + C_STD_ID + "'");
            }
            strSql.Append(" ORDER BY TO_NUMBER(B.C_ORDER) ");
            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM TQB_SLAB_LEN_MATCH ");
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
            strSql.Append(")AS Row, T.*  from TQB_SLAB_LEN_MATCH T ");
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
			parameters[0].Value = "TQB_SLAB_LEN_MATCH";
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
        public DataSet GetSlabSize(string C_STD_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select DISTINCT a.C_SLAB_SIZE ");
            strSql.Append(" from Tqb_Slab_Len_Match b inner join tqb_slab_len a on b.c_slab_id=a.c_id where b.N_STATUS=1 and a.N_STATUS=1 ");
            if (C_STD_ID.Trim() != "")
            {
                strSql.Append(" and b.c_std_id='" + C_STD_ID + "'");
            }
            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 根据钢种、执行标准获取订单生产钢坯信息
        /// </summary>
        /// <param name="C_STL_GRD">钢种</param>
        /// <param name="C_STD_CODE">执行标准</param>
        /// <param name="C_REMARK">商品坯/非商品坯</param>
        /// <returns>钢坯信息</returns>
        public DataSet GetOrderSlabSize(string C_STL_GRD ,string C_STD_CODE,string C_REMARK)
        {
            string sql = "SELECT T.C_ID,";
            sql = sql + "   T.C_STL_GRD,";
            sql = sql + "   T.C_STD_CODE,";
            sql = sql + "    T.C_SLAB_SIZE,";
            sql = sql + "   T.C_COLD_LEN,";
            sql = sql + "  T.C_TYPE,";
            sql = sql + "  T.C_THE_WEIGHT,";
            sql = sql + "  T.C_REMARK,";
            sql = sql + "  T.C_SLAB_SIZE_KP,";
            sql = sql + "  T.C_COLD_LEN_KP,";
            sql = sql + "  T.C_TYPE_KP,";
            sql = sql + "  T.C_THE_WEIGHT_KP";
            sql = sql + "  FROM V_GET_SLAB_SIZE T";
            sql = sql + "  WHERE T.C_STL_GRD = '"+ C_STL_GRD + "'";
            sql = sql + "  AND T.C_STD_CODE = '"+ C_STD_CODE + "'";
            if (C_REMARK.Trim().Length>0)
            {
                sql = sql + "  AND NVL(T.C_REMARK,' ') = '"+ C_REMARK + "'";
            }
            else
            {
                sql = sql + "  AND NVL(T.C_REMARK,' ') <> '商品坯'";
            }
            return DbHelperOra.Query(sql.ToString());
        }

        /// <summary>
        /// 根据钢坯断面和定尺获取理论单重
        /// </summary>
        /// <param name="C_SLAB_SIZE">断面</param>
        /// <param name="C_COLD_LEN">定尺</param>
        /// <returns>单重</returns>
        public decimal GetPW(string C_SLAB_SIZE ,string C_COLD_LEN)
        {
            string sql = "SELECT TO_NUMBER(NVL(MAX(T.C_THE_WEIGHT), '0')) N_PW  FROM TQB_SLAB_LEN T WHERE T.C_SLAB_SIZE = '"+ C_SLAB_SIZE + "'  AND T.C_COLD_LEN = '"+ C_COLD_LEN + "'";
           DataTable dt= DbHelperOra.Query(sql.ToString()).Tables[0];
            if (dt.Rows.Count>0)
            {
                return Convert.ToDecimal( dt.Rows[0]["N_PW"].ToString());
            }
            else
            {
                return 0;
            }

        }
        #endregion  ExtensionMethod
    }
}

