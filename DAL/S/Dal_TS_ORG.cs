﻿using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;
namespace DAL
{
	/// <summary>
	/// 数据访问类:TS_ORG
	/// </summary>
	public partial class Dal_TS_ORG
    {
		public Dal_TS_ORG()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string C_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from TS_ORG");
			strSql.Append(" where C_ID=:C_ID ");
			OracleParameter[] parameters = {
					new OracleParameter(":C_ID", OracleDbType.Varchar2,100)			};
			parameters[0].Value = C_ID;

			return DbHelperOra.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Mod_TS_ORG model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into TS_ORG(");
			strSql.Append("C_ID,C_PARENTID,C_CODE,C_NAME,C_DESC,C_DEPTH,C_STATE,C_DEPTATTR,C_EMP_ID,C_EMP_NAME,D_MOD_DT)");
			strSql.Append(" values (");
			strSql.Append(":C_ID,:C_PARENTID,:C_CODE,:C_NAME,:C_DESC,:C_DEPTH,:C_STATE,:C_DEPTATTR,:C_EMP_ID,:C_EMP_NAME,:D_MOD_DT)");
			OracleParameter[] parameters = {
					new OracleParameter(":C_ID", OracleDbType.Varchar2,100),
					new OracleParameter(":C_PARENTID", OracleDbType.Varchar2,100),
					new OracleParameter(":C_CODE", OracleDbType.Varchar2,100),
					new OracleParameter(":C_NAME", OracleDbType.Varchar2,100),
					new OracleParameter(":C_DESC", OracleDbType.Varchar2,200),
					new OracleParameter(":C_DEPTH", OracleDbType.Decimal,3),
					new OracleParameter(":C_STATE", OracleDbType.Decimal,1),
					new OracleParameter(":C_DEPTATTR", OracleDbType.Decimal,2),
					new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
					new OracleParameter(":C_EMP_NAME", OracleDbType.Varchar2,100),
					new OracleParameter(":D_MOD_DT", OracleDbType.Date)};
			parameters[0].Value = model.C_ID;
			parameters[1].Value = model.C_PARENTID;
			parameters[2].Value = model.C_CODE;
			parameters[3].Value = model.C_NAME;
			parameters[4].Value = model.C_DESC;
			parameters[5].Value = model.C_DEPTH;
			parameters[6].Value = model.C_STATE;
			parameters[7].Value = model.C_DEPTATTR;
			parameters[8].Value = model.C_EMP_ID;
			parameters[9].Value = model.C_EMP_NAME;
			parameters[10].Value = model.D_MOD_DT;

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
		public bool Update(Mod_TS_ORG model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update TS_ORG set ");
			strSql.Append("C_PARENTID=:C_PARENTID,");
			strSql.Append("C_CODE=:C_CODE,");
			strSql.Append("C_NAME=:C_NAME,");
			strSql.Append("C_DESC=:C_DESC,");
			strSql.Append("C_DEPTH=:C_DEPTH,");
			strSql.Append("C_STATE=:C_STATE,");
			strSql.Append("C_DEPTATTR=:C_DEPTATTR,");
			strSql.Append("C_EMP_ID=:C_EMP_ID,");
			strSql.Append("C_EMP_NAME=:C_EMP_NAME,");
			strSql.Append("D_MOD_DT=:D_MOD_DT");
			strSql.Append(" where C_ID=:C_ID ");
			OracleParameter[] parameters = {
					new OracleParameter(":C_PARENTID", OracleDbType.Varchar2,100),
					new OracleParameter(":C_CODE", OracleDbType.Varchar2,100),
					new OracleParameter(":C_NAME", OracleDbType.Varchar2,100),
					new OracleParameter(":C_DESC", OracleDbType.Varchar2,200),
					new OracleParameter(":C_DEPTH", OracleDbType.Decimal,3),
					new OracleParameter(":C_STATE", OracleDbType.Decimal,1),
					new OracleParameter(":C_DEPTATTR", OracleDbType.Decimal,2),
					new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
					new OracleParameter(":C_EMP_NAME", OracleDbType.Varchar2,100),
					new OracleParameter(":D_MOD_DT", OracleDbType.Date),
					new OracleParameter(":C_ID", OracleDbType.Varchar2,100)};
			parameters[0].Value = model.C_PARENTID;
			parameters[1].Value = model.C_CODE;
			parameters[2].Value = model.C_NAME;
			parameters[3].Value = model.C_DESC;
			parameters[4].Value = model.C_DEPTH;
			parameters[5].Value = model.C_STATE;
			parameters[6].Value = model.C_DEPTATTR;
			parameters[7].Value = model.C_EMP_ID;
			parameters[8].Value = model.C_EMP_NAME;
			parameters[9].Value = model.D_MOD_DT;
			parameters[10].Value = model.C_ID;

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
			strSql.Append("delete from TS_ORG ");
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
			strSql.Append("delete from TS_ORG ");
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
		public Mod_TS_ORG GetModel(string C_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select C_ID,C_PARENTID,C_CODE,C_NAME,C_DESC,C_DEPTH,C_STATE,C_DEPTATTR,C_EMP_ID,C_EMP_NAME,D_MOD_DT from TS_ORG ");
			strSql.Append(" where C_ID=:C_ID ");
			OracleParameter[] parameters = {
					new OracleParameter(":C_ID", OracleDbType.Varchar2,100)			};
			parameters[0].Value = C_ID;

			Mod_TS_ORG model=new Mod_TS_ORG();
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
		public Mod_TS_ORG DataRowToModel(DataRow row)
		{
			Mod_TS_ORG model=new Mod_TS_ORG();
			if (row != null)
			{
				if(row["C_ID"]!=null)
				{
					model.C_ID=row["C_ID"].ToString();
				}
				if(row["C_PARENTID"]!=null)
				{
					model.C_PARENTID=row["C_PARENTID"].ToString();
				}
				if(row["C_CODE"]!=null)
				{
					model.C_CODE=row["C_CODE"].ToString();
				}
				if(row["C_NAME"]!=null)
				{
					model.C_NAME=row["C_NAME"].ToString();
				}
				if(row["C_DESC"]!=null)
				{
					model.C_DESC=row["C_DESC"].ToString();
				}
				if(row["C_DEPTH"]!=null && row["C_DEPTH"].ToString()!="")
				{
					model.C_DEPTH=decimal.Parse(row["C_DEPTH"].ToString());
				}
				if(row["C_STATE"]!=null && row["C_STATE"].ToString()!="")
				{
					model.C_STATE=decimal.Parse(row["C_STATE"].ToString());
				}
				if(row["C_DEPTATTR"]!=null && row["C_DEPTATTR"].ToString()!="")
				{
					model.C_DEPTATTR=decimal.Parse(row["C_DEPTATTR"].ToString());
				}
				if(row["C_EMP_ID"]!=null)
				{
					model.C_EMP_ID=row["C_EMP_ID"].ToString();
				}
				if(row["C_EMP_NAME"]!=null)
				{
					model.C_EMP_NAME=row["C_EMP_NAME"].ToString();
				}
				if(row["D_MOD_DT"]!=null && row["D_MOD_DT"].ToString()!="")
				{
					model.D_MOD_DT=DateTime.Parse(row["D_MOD_DT"].ToString());
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
			strSql.Append("select C_ID,C_PARENTID,C_CODE,C_NAME,C_DESC,C_DEPTH,C_STATE,C_DEPTATTR,C_EMP_ID,C_EMP_NAME,D_MOD_DT ");
			strSql.Append(" FROM TS_ORG ");
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
			strSql.Append("select count(1) FROM TS_ORG ");
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
			strSql.Append(")AS Row, T.*  from TS_ORG T ");
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
			parameters[0].Value = "TS_ORG";
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

