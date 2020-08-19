using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;
namespace DAL
{
	/// <summary>
	/// 数据访问类:TQC_ROOL_CHECK_AFFIRM
	/// </summary>
	public partial class Dal_TQC_ROOL_CHECK_AFFIRM
	{
		public Dal_TQC_ROOL_CHECK_AFFIRM()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string C_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from TQC_ROOL_CHECK_AFFIRM");
			strSql.Append(" where C_ID=:C_ID ");
			OracleParameter[] parameters = {
					new OracleParameter(":C_ID", OracleDbType.Varchar2,100)			};
			parameters[0].Value = C_ID;

			return DbHelperOra.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Mod_TQC_ROOL_CHECK_AFFIRM model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into TQC_ROOL_CHECK_AFFIRM(");
			strSql.Append("C_WE_CHECK_ROOL_ID,C_SUGGESTION,N_STATUS,C_REMARK,C_CHECK_EMP_ID,D_CHECK_DT)");
			strSql.Append(" values (");
			strSql.Append(":C_WE_CHECK_ROOL_ID,:C_SUGGESTION,:N_STATUS,:C_REMARK,:C_CHECK_EMP_ID,:D_CHECK_DT)");
			OracleParameter[] parameters = {
					new OracleParameter(":C_WE_CHECK_ROOL_ID", OracleDbType.Varchar2,100),
					new OracleParameter(":C_SUGGESTION", OracleDbType.Varchar2,100),
					new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
					new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
					new OracleParameter(":C_CHECK_EMP_ID", OracleDbType.Varchar2,100),
					new OracleParameter(":D_CHECK_DT", OracleDbType.Date)};
			parameters[0].Value = model.C_WE_CHECK_ROOL_ID;
			parameters[1].Value = model.C_SUGGESTION;
			parameters[2].Value = model.N_STATUS;
			parameters[3].Value = model.C_REMARK;
			parameters[4].Value = model.C_CHECK_EMP_ID;
			parameters[5].Value = model.D_CHECK_DT;

			int rows=DbHelperOra.ExecuteSql(strSql.ToString(),parameters);
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
		public bool Update(Mod_TQC_ROOL_CHECK_AFFIRM model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update TQC_ROOL_CHECK_AFFIRM set ");
			strSql.Append("C_WE_CHECK_ROOL_ID=:C_WE_CHECK_ROOL_ID,");
			strSql.Append("C_SUGGESTION=:C_SUGGESTION,");
			strSql.Append("N_STATUS=:N_STATUS,");
			strSql.Append("C_REMARK=:C_REMARK,");
			strSql.Append("C_CHECK_EMP_ID=:C_CHECK_EMP_ID,");
			strSql.Append("D_CHECK_DT=:D_CHECK_DT");
			strSql.Append(" where C_ID=:C_ID ");
			OracleParameter[] parameters = {
					new OracleParameter(":C_WE_CHECK_ROOL_ID", OracleDbType.Varchar2,100),
					new OracleParameter(":C_SUGGESTION", OracleDbType.Varchar2,100),
					new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
					new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
					new OracleParameter(":C_CHECK_EMP_ID", OracleDbType.Varchar2,100),
					new OracleParameter(":D_CHECK_DT", OracleDbType.Date),
					new OracleParameter(":C_ID", OracleDbType.Varchar2,100)};
			parameters[0].Value = model.C_WE_CHECK_ROOL_ID;
			parameters[1].Value = model.C_SUGGESTION;
			parameters[2].Value = model.N_STATUS;
			parameters[3].Value = model.C_REMARK;
			parameters[4].Value = model.C_CHECK_EMP_ID;
			parameters[5].Value = model.D_CHECK_DT;
			parameters[6].Value = model.C_ID;

			int rows=DbHelperOra.ExecuteSql(strSql.ToString(),parameters);
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
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from TQC_ROOL_CHECK_AFFIRM ");
			strSql.Append(" where C_ID=:C_ID ");
			OracleParameter[] parameters = {
					new OracleParameter(":C_ID", OracleDbType.Varchar2,100)			};
			parameters[0].Value = C_ID;

			int rows=DbHelperOra.ExecuteSql(strSql.ToString(),parameters);
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
		public bool DeleteList(string C_IDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from TQC_ROOL_CHECK_AFFIRM ");
			strSql.Append(" where C_ID in ("+C_IDlist + ")  ");
			int rows=DbHelperOra.ExecuteSql(strSql.ToString());
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
		public Mod_TQC_ROOL_CHECK_AFFIRM GetModel(string C_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select C_ID,C_WE_CHECK_ROOL_ID,C_SUGGESTION,N_STATUS,C_REMARK,C_CHECK_EMP_ID,D_CHECK_DT from TQC_ROOL_CHECK_AFFIRM ");
			strSql.Append(" where C_ID=:C_ID ");
			OracleParameter[] parameters = {
					new OracleParameter(":C_ID", OracleDbType.Varchar2,100)			};
			parameters[0].Value = C_ID;

			Mod_TQC_ROOL_CHECK_AFFIRM model=new Mod_TQC_ROOL_CHECK_AFFIRM();
			DataSet ds=DbHelperOra.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
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
		public Mod_TQC_ROOL_CHECK_AFFIRM DataRowToModel(DataRow row)
		{
			Mod_TQC_ROOL_CHECK_AFFIRM model=new Mod_TQC_ROOL_CHECK_AFFIRM();
			if (row != null)
			{
				if(row["C_ID"]!=null)
				{
					model.C_ID=row["C_ID"].ToString();
				}
				if(row["C_WE_CHECK_ROOL_ID"]!=null)
				{
					model.C_WE_CHECK_ROOL_ID=row["C_WE_CHECK_ROOL_ID"].ToString();
				}
				if(row["C_SUGGESTION"]!=null)
				{
					model.C_SUGGESTION=row["C_SUGGESTION"].ToString();
				}
				if(row["N_STATUS"]!=null && row["N_STATUS"].ToString()!="")
				{
					model.N_STATUS=decimal.Parse(row["N_STATUS"].ToString());
				}
				if(row["C_REMARK"]!=null)
				{
					model.C_REMARK=row["C_REMARK"].ToString();
				}
				if(row["C_CHECK_EMP_ID"]!=null)
				{
					model.C_CHECK_EMP_ID=row["C_CHECK_EMP_ID"].ToString();
				}
				if(row["D_CHECK_DT"]!=null && row["D_CHECK_DT"].ToString()!="")
				{
					model.D_CHECK_DT=DateTime.Parse(row["D_CHECK_DT"].ToString());
				}
			}
			return model;
		}
        /// <summary>
        /// 获得数据列表_未确认
        /// </summary>
        /// <param name="begin">开始时间</param>
        /// <param name="end">结束时间</param>
        /// <param name="C_BATCH_NO">批号</param>
        /// <returns></returns>
        public DataSet GetList_Query(DateTime begin, DateTime end, string C_BATCH_NO)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" select a.C_ID,a.C_ROLL_ID, a.C_STOVE,a.C_BATCH_NO,a.C_TICK_NO,a.C_STL_GRD,a.N_WGT,a.C_STD_CODE,a.C_SPEC,a.C_MAT_CODE,a.C_MAT_NAME, a.D_WAREHOUSE_IN,a.C_SHIFT,a.C_GROUP,a.C_REASON_NAME,a.C_REASON_CODE,a.C_REASON_DEPMT_ID,a.C_REASON_DEPMT_DESC,a.C_SUGGESTION,a.N_STATUS,a.C_REMARK, a.C_EMP_ID,a.D_MOD_DT,a.C_CHECK_EMP_ID,a.C_SUGGESTION as C_AUDIT,a.D_CHECK_DT ");
            strSql.Append(" FROM TQC_WAREHOUSE_CHECK_ROLL a where a.C_CHECK_EMP_ID is null ");
            if (begin != null && end != null)
            {
                strSql.Append(" and a.D_MOD_DT between to_date('" + Convert.ToDateTime(begin) + "','yyyy-mm-dd hh24:mi:ss') and to_date('" + Convert.ToDateTime(end) + "','yyyy-mm-dd hh24:mi:ss')  ");
            }
            if (!string.IsNullOrEmpty(C_BATCH_NO))
            {
                strSql.Append(" and a.C_BATCH_NO like '%" + C_BATCH_NO + "%' ");
            }
            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得数据列表_已确认
        /// </summary>
        /// <param name="begin">开始时间</param>
        /// <param name="end">结束时间</param>
        /// <param name="C_BATCH_NO">批号</param>
        /// <returns></returns>
		public DataSet GetList_Query1(DateTime begin, DateTime end, string C_BATCH_NO)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" select a.C_ID,a.C_ROLL_ID, a.C_STOVE,a.C_BATCH_NO,a.C_TICK_NO,a.C_STL_GRD,a.N_WGT,a.C_STD_CODE,a.C_SPEC,a.C_MAT_CODE,a.C_MAT_NAME, a.D_WAREHOUSE_IN,a.C_SHIFT,a.C_GROUP,a.C_REASON_NAME,a.C_REASON_CODE,a.C_REASON_DEPMT_ID,a.C_REASON_DEPMT_DESC,a.C_SUGGESTION,a.N_STATUS,a.C_REMARK, a.C_EMP_ID,a.D_MOD_DT,t.C_CHECK_EMP_ID,t.D_CHECK_DT,t.C_SUGGESTION as C_AUDIT ");
            strSql.Append(" FROM TQC_WAREHOUSE_CHECK_ROLL a join TQC_ROOL_CHECK_AFFIRM t on a.c_id=t.c_we_check_rool_id where a.C_CHECK_EMP_ID is not null ");
            if (begin != null && end != null)
            {
                strSql.Append(" and a.D_MOD_DT between to_date('" + Convert.ToDateTime(begin) + "','yyyy-mm-dd hh24:mi:ss') and to_date('" + Convert.ToDateTime(end) + "','yyyy-mm-dd hh24:mi:ss')  ");
            }
            if (!string.IsNullOrEmpty(C_BATCH_NO))
            {
                strSql.Append(" and a.C_BATCH_NO like '%" + C_BATCH_NO + "%' ");
            }
            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select C_ID,C_WE_CHECK_ROOL_ID,C_SUGGESTION,N_STATUS,C_REMARK,C_CHECK_EMP_ID,D_CHECK_DT ");
			strSql.Append(" FROM TQC_ROOL_CHECK_AFFIRM ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperOra.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM TQC_ROOL_CHECK_AFFIRM ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
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
			StringBuilder strSql=new StringBuilder();
			strSql.Append("SELECT * FROM ( ");
			strSql.Append(" SELECT ROW_NUMBER() OVER (");
			if (!string.IsNullOrEmpty(orderby.Trim()))
			{
				strSql.Append("order by T." + orderby );
			}
			else
			{
				strSql.Append("order by T.C_ID desc");
			}
			strSql.Append(")AS Row, T.*  from TQC_ROOL_CHECK_AFFIRM T ");
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
			parameters[0].Value = "TQC_ROOL_CHECK_AFFIRM";
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
	}
}

