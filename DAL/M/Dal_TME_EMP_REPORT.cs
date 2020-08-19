using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;
namespace DAL
{
	/// <summary>
	/// 数据访问类:TME_EMP_REPORT
	/// </summary>
	public partial class Dal_TME_EMP_REPORT
    {
		public Dal_TME_EMP_REPORT()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string C_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from TME_EMP_REPORT");
			strSql.Append(" where C_ID=:C_ID ");
			OracleParameter[] parameters = {
					new OracleParameter(":C_ID", OracleDbType.Varchar2,100)			};
			parameters[0].Value = C_ID;

			return DbHelperOra.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Mod_TME_EMP_REPORT model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into TME_EMP_REPORT(");
			strSql.Append("C_ID,C_COMPANY,C_STL_GRD,C_SPEC,C_USE,C_CONTENT,C_REMARK,D_CRT_DATE,C_CRT_EMP)");
			strSql.Append(" values (");
			strSql.Append(":C_ID,:C_COMPANY,:C_STL_GRD,:C_SPEC,:C_USE,:C_CONTENT,:C_REMARK,:D_CRT_DATE,:C_CRT_EMP)");
			OracleParameter[] parameters = {
					new OracleParameter(":C_ID", OracleDbType.Varchar2,100),
					new OracleParameter(":C_COMPANY", OracleDbType.Varchar2,100),
					new OracleParameter(":C_STL_GRD", OracleDbType.Varchar2,100),
					new OracleParameter(":C_SPEC", OracleDbType.Varchar2,100),
					new OracleParameter(":C_USE", OracleDbType.Varchar2,100),
					new OracleParameter(":C_CONTENT", OracleDbType.Varchar2,200),
					new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
					new OracleParameter(":D_CRT_DATE", OracleDbType.Date),
					new OracleParameter(":C_CRT_EMP", OracleDbType.Varchar2,100)};
			parameters[0].Value = model.C_ID;
			parameters[1].Value = model.C_COMPANY;
			parameters[2].Value = model.C_STL_GRD;
			parameters[3].Value = model.C_SPEC;
			parameters[4].Value = model.C_USE;
			parameters[5].Value = model.C_CONTENT;
			parameters[6].Value = model.C_REMARK;
			parameters[7].Value = model.D_CRT_DATE;
			parameters[8].Value = model.C_CRT_EMP;

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
		public bool Update(Mod_TME_EMP_REPORT model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update TME_EMP_REPORT set ");
			strSql.Append("C_COMPANY=:C_COMPANY,");
			strSql.Append("C_STL_GRD=:C_STL_GRD,");
			strSql.Append("C_SPEC=:C_SPEC,");
			strSql.Append("C_USE=:C_USE,");
			strSql.Append("C_CONTENT=:C_CONTENT,");
			strSql.Append("C_REMARK=:C_REMARK,");
			strSql.Append("D_CRT_DATE=:D_CRT_DATE,");
			strSql.Append("C_CRT_EMP=:C_CRT_EMP");
			strSql.Append(" where C_ID=:C_ID ");
			OracleParameter[] parameters = {
					new OracleParameter(":C_COMPANY", OracleDbType.Varchar2,100),
					new OracleParameter(":C_STL_GRD", OracleDbType.Varchar2,100),
					new OracleParameter(":C_SPEC", OracleDbType.Varchar2,100),
					new OracleParameter(":C_USE", OracleDbType.Varchar2,100),
					new OracleParameter(":C_CONTENT", OracleDbType.Varchar2,200),
					new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
					new OracleParameter(":D_CRT_DATE", OracleDbType.Date),
					new OracleParameter(":C_CRT_EMP", OracleDbType.Varchar2,100),
					new OracleParameter(":C_ID", OracleDbType.Varchar2,100)};
			parameters[0].Value = model.C_COMPANY;
			parameters[1].Value = model.C_STL_GRD;
			parameters[2].Value = model.C_SPEC;
			parameters[3].Value = model.C_USE;
			parameters[4].Value = model.C_CONTENT;
			parameters[5].Value = model.C_REMARK;
			parameters[6].Value = model.D_CRT_DATE;
			parameters[7].Value = model.C_CRT_EMP;
			parameters[8].Value = model.C_ID;

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
			strSql.Append("delete from TME_EMP_REPORT ");
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
			strSql.Append("delete from TME_EMP_REPORT ");
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
		public Mod_TME_EMP_REPORT GetModel(string C_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select C_ID,C_COMPANY,C_STL_GRD,C_SPEC,C_USE,C_CONTENT,C_REMARK,D_CRT_DATE,C_CRT_EMP from TME_EMP_REPORT ");
			strSql.Append(" where C_ID=:C_ID ");
			OracleParameter[] parameters = {
					new OracleParameter(":C_ID", OracleDbType.Varchar2,100)			};
			parameters[0].Value = C_ID;

			Mod_TME_EMP_REPORT model=new Mod_TME_EMP_REPORT();
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
		public Mod_TME_EMP_REPORT DataRowToModel(DataRow row)
		{
			Mod_TME_EMP_REPORT model=new Mod_TME_EMP_REPORT();
			if (row != null)
			{
				if(row["C_ID"]!=null)
				{
					model.C_ID=row["C_ID"].ToString();
				}
				if(row["C_COMPANY"]!=null)
				{
					model.C_COMPANY=row["C_COMPANY"].ToString();
				}
				if(row["C_STL_GRD"]!=null)
				{
					model.C_STL_GRD=row["C_STL_GRD"].ToString();
				}
				if(row["C_SPEC"]!=null)
				{
					model.C_SPEC=row["C_SPEC"].ToString();
				}
				if(row["C_USE"]!=null)
				{
					model.C_USE=row["C_USE"].ToString();
				}
				if(row["C_CONTENT"]!=null)
				{
					model.C_CONTENT=row["C_CONTENT"].ToString();
				}
				if(row["C_REMARK"]!=null)
				{
					model.C_REMARK=row["C_REMARK"].ToString();
				}
				if(row["D_CRT_DATE"]!=null && row["D_CRT_DATE"].ToString()!="")
				{
					model.D_CRT_DATE=DateTime.Parse(row["D_CRT_DATE"].ToString());
				}
				if(row["C_CRT_EMP"]!=null)
				{
					model.C_CRT_EMP=row["C_CRT_EMP"].ToString();
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
			strSql.Append("select C_ID,C_COMPANY,C_STL_GRD,C_SPEC,C_USE,C_CONTENT,C_REMARK,D_CRT_DATE,C_CRT_EMP ");
			strSql.Append(" FROM TME_EMP_REPORT ");
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
			strSql.Append("select count(1) FROM TME_EMP_REPORT ");
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
			strSql.Append(")AS Row, T.*  from TME_EMP_REPORT T ");
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
			parameters[0].Value = "TME_EMP_REPORT";
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

