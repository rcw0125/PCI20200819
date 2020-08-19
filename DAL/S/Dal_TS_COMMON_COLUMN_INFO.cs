using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;
namespace DAL
{
	/// <summary>
	/// 数据访问类:TS_COMMON_COLUMN_INFO
	/// </summary>
	public partial class Dal_TS_COMMON_COLUMN_INFO
    {
		public Dal_TS_COMMON_COLUMN_INFO()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Mod_TS_COMMON_COLUMN_INFO model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into TS_COMMON_COLUMN_INFO(");
			strSql.Append("C_ID,C_COLUMN_NAME,C_COLUMN_TYPE,C_COLUMN_COMMENTS,D_MOD_DATE)");
			strSql.Append(" values (");
			strSql.Append(":C_ID,:C_COLUMN_NAME,:C_COLUMN_TYPE,:C_COLUMN_COMMENTS,:D_MOD_DATE)");
			OracleParameter[] parameters = {
					new OracleParameter(":C_ID", OracleDbType.Varchar2),
					new OracleParameter(":C_COLUMN_NAME", OracleDbType.Varchar2),
					new OracleParameter(":C_COLUMN_TYPE", OracleDbType.Varchar2),
					new OracleParameter(":C_COLUMN_COMMENTS", OracleDbType.Varchar2),
					new OracleParameter(":D_MOD_DATE", OracleDbType.Date)};
			parameters[0].Value = model.C_ID;
			parameters[1].Value = model.C_COLUMN_NAME;
			parameters[2].Value = model.C_COLUMN_TYPE;
			parameters[3].Value = model.C_COLUMN_COMMENTS;
			parameters[4].Value = model.D_MOD_DATE;

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
		public bool Update(Mod_TS_COMMON_COLUMN_INFO model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update TS_COMMON_COLUMN_INFO set ");
			strSql.Append("C_ID=:C_ID,");
			strSql.Append("C_COLUMN_NAME=:C_COLUMN_NAME,");
			strSql.Append("C_COLUMN_TYPE=:C_COLUMN_TYPE,");
			strSql.Append("C_COLUMN_COMMENTS=:C_COLUMN_COMMENTS,");
			strSql.Append("D_MOD_DATE=:D_MOD_DATE");
			strSql.Append(" where ");
			OracleParameter[] parameters = {
					new OracleParameter(":C_ID", OracleDbType.Varchar2),
					new OracleParameter(":C_COLUMN_NAME", OracleDbType.Varchar2),
					new OracleParameter(":C_COLUMN_TYPE", OracleDbType.Varchar2),
					new OracleParameter(":C_COLUMN_COMMENTS", OracleDbType.Varchar2),
					new OracleParameter(":D_MOD_DATE", OracleDbType.Date)};
			parameters[0].Value = model.C_ID;
			parameters[1].Value = model.C_COLUMN_NAME;
			parameters[2].Value = model.C_COLUMN_TYPE;
			parameters[3].Value = model.C_COLUMN_COMMENTS;
			parameters[4].Value = model.D_MOD_DATE;

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
		public bool Delete()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from TS_COMMON_COLUMN_INFO ");
			strSql.Append(" where ");
			OracleParameter[] parameters = {
			};

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
		/// 得到一个对象实体
		/// </summary>
		public Mod_TS_COMMON_COLUMN_INFO GetModel()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select C_ID,C_COLUMN_NAME,C_COLUMN_TYPE,C_COLUMN_COMMENTS,D_MOD_DATE from TS_COMMON_COLUMN_INFO ");
			strSql.Append(" where ");
			OracleParameter[] parameters = {
			};

			Mod_TS_COMMON_COLUMN_INFO model=new Mod_TS_COMMON_COLUMN_INFO();
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
		public Mod_TS_COMMON_COLUMN_INFO DataRowToModel(DataRow row)
		{
			Mod_TS_COMMON_COLUMN_INFO model=new Mod_TS_COMMON_COLUMN_INFO();
			if (row != null)
			{
				if(row["C_ID"]!=null)
				{
					model.C_ID=row["C_ID"].ToString();
				}
				if(row["C_COLUMN_NAME"]!=null)
				{
					model.C_COLUMN_NAME=row["C_COLUMN_NAME"].ToString();
				}
				if(row["C_COLUMN_TYPE"]!=null)
				{
					model.C_COLUMN_TYPE=row["C_COLUMN_TYPE"].ToString();
				}
				if(row["C_COLUMN_COMMENTS"]!=null)
				{
					model.C_COLUMN_COMMENTS=row["C_COLUMN_COMMENTS"].ToString();
				}
				if(row["D_MOD_DATE"]!=null && row["D_MOD_DATE"].ToString()!="")
				{
					model.D_MOD_DATE=DateTime.Parse(row["D_MOD_DATE"].ToString());
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
			strSql.Append("select C_ID,C_COLUMN_NAME,C_COLUMN_TYPE,C_COLUMN_COMMENTS,D_MOD_DATE ");
			strSql.Append(" FROM TS_COMMON_COLUMN_INFO ");
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
			strSql.Append("select count(1) FROM TS_COMMON_COLUMN_INFO ");
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
			strSql.Append(")AS Row, T.*  from TS_COMMON_COLUMN_INFO T ");
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
			parameters[0].Value = "TS_COMMON_COLUMN_INFO";
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

