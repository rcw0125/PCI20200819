using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;
namespace DAL
{
	/// <summary>
	/// 数据访问类:TQR_REJECTS
	/// </summary>
	public partial class Dal_TQR_REJECTS
    {
		public Dal_TQR_REJECTS()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string C_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from TQR_REJECTS");
			strSql.Append(" where C_ID=:C_ID ");
			OracleParameter[] parameters = {
					new OracleParameter(":C_ID", OracleDbType.Varchar2,100)			};
			parameters[0].Value = C_ID;

			return DbHelperOra.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Mod_TQR_REJECTS model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into TQR_REJECTS(");
			strSql.Append("C_STOVE,C_BATCH_NO,C_STL_GRD,C_STL_GRD_TYPE,C_REASON_NAME,C_REASON_QUA,N_REASON_WGT)");
			strSql.Append(" values (");
			strSql.Append(":C_STOVE,:C_BATCH_NO,:C_STL_GRD,:C_STL_GRD_TYPE,:C_REASON_NAME,:C_REASON_QUA,:N_REASON_WGT)");
			OracleParameter[] parameters = {
					new OracleParameter(":C_STOVE", OracleDbType.Varchar2,100),
					new OracleParameter(":C_BATCH_NO", OracleDbType.Varchar2,100),
					new OracleParameter(":C_STL_GRD", OracleDbType.Varchar2,100),
					new OracleParameter(":C_STL_GRD_TYPE", OracleDbType.Varchar2,100),
					new OracleParameter(":C_REASON_NAME", OracleDbType.Varchar2,100),
					new OracleParameter(":C_REASON_QUA", OracleDbType.Varchar2,100),
					new OracleParameter(":N_REASON_WGT", OracleDbType.Double,15)};
			parameters[0].Value = model.C_STOVE;
			parameters[1].Value = model.C_BATCH_NO;
			parameters[2].Value = model.C_STL_GRD;
			parameters[3].Value = model.C_STL_GRD_TYPE;
			parameters[4].Value = model.C_REASON_NAME;
			parameters[5].Value = model.C_REASON_QUA;
			parameters[6].Value = model.N_REASON_WGT;

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
		public bool Update(Mod_TQR_REJECTS model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update TQR_REJECTS set ");
			strSql.Append("C_STOVE=:C_STOVE,");
			strSql.Append("C_BATCH_NO=:C_BATCH_NO,");
			strSql.Append("C_STL_GRD=:C_STL_GRD,");
			strSql.Append("C_STL_GRD_TYPE=:C_STL_GRD_TYPE,");
			strSql.Append("C_REASON_NAME=:C_REASON_NAME,");
			strSql.Append("C_REASON_QUA=:C_REASON_QUA,");
			strSql.Append("N_REASON_WGT=:N_REASON_WGT");
			strSql.Append(" where C_ID=:C_ID ");
			OracleParameter[] parameters = {
					new OracleParameter(":C_STOVE", OracleDbType.Varchar2,100),
					new OracleParameter(":C_BATCH_NO", OracleDbType.Varchar2,100),
					new OracleParameter(":C_STL_GRD", OracleDbType.Varchar2,100),
					new OracleParameter(":C_STL_GRD_TYPE", OracleDbType.Varchar2,100),
					new OracleParameter(":C_REASON_NAME", OracleDbType.Varchar2,100),
					new OracleParameter(":C_REASON_QUA", OracleDbType.Varchar2,100),
					new OracleParameter(":N_REASON_WGT", OracleDbType.Double,15),
					new OracleParameter(":C_ID", OracleDbType.Varchar2,100)};
			parameters[0].Value = model.C_STOVE;
			parameters[1].Value = model.C_BATCH_NO;
			parameters[2].Value = model.C_STL_GRD;
			parameters[3].Value = model.C_STL_GRD_TYPE;
			parameters[4].Value = model.C_REASON_NAME;
			parameters[5].Value = model.C_REASON_QUA;
			parameters[6].Value = model.N_REASON_WGT;
			parameters[7].Value = model.C_ID;

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
			strSql.Append("delete from TQR_REJECTS ");
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
			strSql.Append("delete from TQR_REJECTS ");
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
		public Mod_TQR_REJECTS GetModel(string C_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select C_ID,C_STOVE,C_BATCH_NO,C_STL_GRD,C_STL_GRD_TYPE,C_REASON_NAME,C_REASON_QUA,N_REASON_WGT from TQR_REJECTS ");
			strSql.Append(" where C_ID=:C_ID ");
			OracleParameter[] parameters = {
					new OracleParameter(":C_ID", OracleDbType.Varchar2,100)			};
			parameters[0].Value = C_ID;

			Mod_TQR_REJECTS model=new Mod_TQR_REJECTS();
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
		public Mod_TQR_REJECTS DataRowToModel(DataRow row)
		{
			Mod_TQR_REJECTS model=new Mod_TQR_REJECTS();
			if (row != null)
			{
				if(row["C_ID"]!=null)
				{
					model.C_ID=row["C_ID"].ToString();
				}
				if(row["C_STOVE"]!=null)
				{
					model.C_STOVE=row["C_STOVE"].ToString();
				}
				if(row["C_BATCH_NO"]!=null)
				{
					model.C_BATCH_NO=row["C_BATCH_NO"].ToString();
				}
				if(row["C_STL_GRD"]!=null)
				{
					model.C_STL_GRD=row["C_STL_GRD"].ToString();
				}
				if(row["C_STL_GRD_TYPE"]!=null)
				{
					model.C_STL_GRD_TYPE=row["C_STL_GRD_TYPE"].ToString();
				}
				if(row["C_REASON_NAME"]!=null)
				{
					model.C_REASON_NAME=row["C_REASON_NAME"].ToString();
				}
				if(row["C_REASON_QUA"]!=null)
				{
					model.C_REASON_QUA=row["C_REASON_QUA"].ToString();
				}
				if(row["N_REASON_WGT"]!=null && row["N_REASON_WGT"].ToString()!="")
				{
					model.N_REASON_WGT=decimal.Parse(row["N_REASON_WGT"].ToString());
				}
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select C_ID,C_STOVE,C_BATCH_NO,C_STL_GRD,C_STL_GRD_TYPE,C_REASON_NAME,C_REASON_QUA,N_REASON_WGT ");
			strSql.Append(" FROM TQR_REJECTS ");
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
			strSql.Append("select count(1) FROM TQR_REJECTS ");
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
			strSql.Append(")AS Row, T.*  from TQR_REJECTS T ");
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
			parameters[0].Value = "TQR_REJECTS";
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

