using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;
namespace DAL
{
	/// <summary>
	/// 数据访问类:TS_TABLE_INFO
	/// </summary>
	public partial class Dal_TS_TABLE_INFO
    {
		public Dal_TS_TABLE_INFO()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Mod_TS_TABLE_INFO model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into TS_TABLE_INFO(");
			strSql.Append("C_ID,C_TABLE_NAME,C_TABLE_DESC,C_CREATE_EMP,D_CREATE_DATE)");
			strSql.Append(" values (");
			strSql.Append(":C_ID,:C_TABLE_NAME,:C_TABLE_DESC,:C_CREATE_EMP,:D_CREATE_DATE)");
			OracleParameter[] parameters = {
					new OracleParameter(":C_ID", OracleDbType.Varchar2,100),
					new OracleParameter(":C_TABLE_NAME", OracleDbType.Varchar2,100),
					new OracleParameter(":C_TABLE_DESC", OracleDbType.Varchar2,100),
					new OracleParameter(":C_CREATE_EMP", OracleDbType.Varchar2,100),
					new OracleParameter(":D_CREATE_DATE", OracleDbType.Date)};
			parameters[0].Value = model.C_ID;
			parameters[1].Value = model.C_TABLE_NAME;
			parameters[2].Value = model.C_TABLE_DESC;
			parameters[3].Value = model.C_CREATE_EMP;
			parameters[4].Value = model.D_CREATE_DATE;

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
		public bool Update(Mod_TS_TABLE_INFO model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update TS_TABLE_INFO set ");
			strSql.Append("C_ID=:C_ID,");
			strSql.Append("C_TABLE_NAME=:C_TABLE_NAME,");
			strSql.Append("C_TABLE_DESC=:C_TABLE_DESC,");
			strSql.Append("C_CREATE_EMP=:C_CREATE_EMP,");
			strSql.Append("D_CREATE_DATE=:D_CREATE_DATE");
			strSql.Append(" where ");
			OracleParameter[] parameters = {
					new OracleParameter(":C_ID", OracleDbType.Varchar2,100),
					new OracleParameter(":C_TABLE_NAME", OracleDbType.Varchar2,100),
					new OracleParameter(":C_TABLE_DESC", OracleDbType.Varchar2,100),
					new OracleParameter(":C_CREATE_EMP", OracleDbType.Varchar2,100),
					new OracleParameter(":D_CREATE_DATE", OracleDbType.Date)};
			parameters[0].Value = model.C_ID;
			parameters[1].Value = model.C_TABLE_NAME;
			parameters[2].Value = model.C_TABLE_DESC;
			parameters[3].Value = model.C_CREATE_EMP;
			parameters[4].Value = model.D_CREATE_DATE;

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
			strSql.Append("delete from TS_TABLE_INFO ");
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
		public Mod_TS_TABLE_INFO GetModel()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select C_ID,C_TABLE_NAME,C_TABLE_DESC,C_CREATE_EMP,D_CREATE_DATE from TS_TABLE_INFO ");
			strSql.Append(" where ");
			OracleParameter[] parameters = {
			};

			Mod_TS_TABLE_INFO model=new Mod_TS_TABLE_INFO();
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
		public Mod_TS_TABLE_INFO DataRowToModel(DataRow row)
		{
			Mod_TS_TABLE_INFO model=new Mod_TS_TABLE_INFO();
			if (row != null)
			{
				if(row["C_ID"]!=null)
				{
					model.C_ID=row["C_ID"].ToString();
				}
				if(row["C_TABLE_NAME"]!=null)
				{
					model.C_TABLE_NAME=row["C_TABLE_NAME"].ToString();
				}
				if(row["C_TABLE_DESC"]!=null)
				{
					model.C_TABLE_DESC=row["C_TABLE_DESC"].ToString();
				}
				if(row["C_CREATE_EMP"]!=null)
				{
					model.C_CREATE_EMP=row["C_CREATE_EMP"].ToString();
				}
				if(row["D_CREATE_DATE"]!=null && row["D_CREATE_DATE"].ToString()!="")
				{
					model.D_CREATE_DATE=DateTime.Parse(row["D_CREATE_DATE"].ToString());
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
			strSql.Append("select C_ID,C_TABLE_NAME,C_TABLE_DESC,C_CREATE_EMP,D_CREATE_DATE ");
			strSql.Append(" FROM TS_TABLE_INFO ");
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
			strSql.Append("select count(1) FROM TS_TABLE_INFO ");
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
			strSql.Append(")AS Row, T.*  from TS_TABLE_INFO T ");
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
			parameters[0].Value = "TS_TABLE_INFO";
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

