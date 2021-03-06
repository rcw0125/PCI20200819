﻿using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using RV.MODEL;

namespace RV.DAL
{
	/// <summary>
	/// 数据访问类:TB_LOG
	/// </summary>
	public partial class DalTB_LOG
	{
		public DalTB_LOG()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string C_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from TB_LOG");
			strSql.Append(" where C_ID=:C_ID ");
			OracleParameter[] parameters = {
					new OracleParameter(":C_ID", OracleDbType.Varchar2,50)			};
			parameters[0].Value = C_ID;

			return DbHelperOra.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(ModTB_LOG model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into TB_LOG(");
			strSql.Append("C_IP,C_MODULES,C_MENU_NAME,C_FORMS_NAME,C_FORMS_DESC,C_OPER_CONTEXT,N_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT)");
			strSql.Append(" values (");
			strSql.Append(":C_IP,:C_MODULES,:C_MENU_NAME,:C_FORMS_NAME,:C_FORMS_DESC,:C_OPER_CONTEXT,:N_STATUS,:C_REMARK,:C_EMP_ID,:D_MOD_DT)");
			OracleParameter[] parameters = {
					new OracleParameter(":C_IP", OracleDbType.Varchar2,100),
					new OracleParameter(":C_MODULES", OracleDbType.Varchar2,100),
					new OracleParameter(":C_MENU_NAME", OracleDbType.Varchar2,100),
					new OracleParameter(":C_FORMS_NAME", OracleDbType.Varchar2,100),
					new OracleParameter(":C_FORMS_DESC", OracleDbType.Varchar2,100),
					new OracleParameter(":C_OPER_CONTEXT", OracleDbType.Varchar2,500),
					new OracleParameter(":N_STATUS", OracleDbType.Int16,1),
					new OracleParameter(":C_REMARK", OracleDbType.Varchar2,50),
					new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,20),
					new OracleParameter(":D_MOD_DT", OracleDbType.Date)};
			parameters[0].Value = model.C_IP;
			parameters[1].Value = model.C_MODULES;
			parameters[2].Value = model.C_MENU_NAME;
			parameters[3].Value = model.C_FORMS_NAME;
			parameters[4].Value = model.C_FORMS_DESC;
			parameters[5].Value = model.C_OPER_CONTEXT;
			parameters[6].Value = model.N_STATUS;
			parameters[7].Value = model.C_REMARK;
			parameters[8].Value = model.C_EMP_ID;
			parameters[9].Value = model.D_MOD_DT;

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
		public bool Update(ModTB_LOG model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update TB_LOG set ");
			strSql.Append("C_IP=:C_IP,");
			strSql.Append("C_MODULES=:C_MODULES,");
			strSql.Append("C_MENU_NAME=:C_MENU_NAME,");
			strSql.Append("C_FORMS_NAME=:C_FORMS_NAME,");
			strSql.Append("C_FORMS_DESC=:C_FORMS_DESC,");
			strSql.Append("C_OPER_CONTEXT=:C_OPER_CONTEXT,");
			strSql.Append("N_STATUS=:N_STATUS,");
			strSql.Append("C_REMARK=:C_REMARK,");
			strSql.Append("C_EMP_ID=:C_EMP_ID,");
			strSql.Append("D_MOD_DT=:D_MOD_DT");
			strSql.Append(" where C_ID=:C_ID ");
			OracleParameter[] parameters = {
					new OracleParameter(":C_IP", OracleDbType.Varchar2,100),
					new OracleParameter(":C_MODULES", OracleDbType.Varchar2,100),
					new OracleParameter(":C_MENU_NAME", OracleDbType.Varchar2,100),
					new OracleParameter(":C_FORMS_NAME", OracleDbType.Varchar2,100),
					new OracleParameter(":C_FORMS_DESC", OracleDbType.Varchar2,100),
					new OracleParameter(":C_OPER_CONTEXT", OracleDbType.Varchar2,500),
					new OracleParameter(":N_STATUS", OracleDbType.Int16,1),
					new OracleParameter(":C_REMARK", OracleDbType.Varchar2,50),
					new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,20),
					new OracleParameter(":D_MOD_DT", OracleDbType.Date),
					new OracleParameter(":C_ID", OracleDbType.Varchar2,50)};
			parameters[0].Value = model.C_IP;
			parameters[1].Value = model.C_MODULES;
			parameters[2].Value = model.C_MENU_NAME;
			parameters[3].Value = model.C_FORMS_NAME;
			parameters[4].Value = model.C_FORMS_DESC;
			parameters[5].Value = model.C_OPER_CONTEXT;
			parameters[6].Value = model.N_STATUS;
			parameters[7].Value = model.C_REMARK;
			parameters[8].Value = model.C_EMP_ID;
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
			strSql.Append("delete from TB_LOG ");
			strSql.Append(" where C_ID=:C_ID ");
			OracleParameter[] parameters = {
					new OracleParameter(":C_ID", OracleDbType.Varchar2,50)			};
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
			strSql.Append("delete from TB_LOG ");
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
		public ModTB_LOG GetModel(string C_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select C_ID,C_IP,C_MODULES,C_MENU_NAME,C_FORMS_NAME,C_FORMS_DESC,C_OPER_CONTEXT,N_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT from TB_LOG ");
			strSql.Append(" where C_ID=:C_ID ");
			OracleParameter[] parameters = {
					new OracleParameter(":C_ID", OracleDbType.Varchar2,50)			};
			parameters[0].Value = C_ID;

			ModTB_LOG model=new ModTB_LOG();
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
		public ModTB_LOG DataRowToModel(DataRow row)
		{
			ModTB_LOG model=new ModTB_LOG();
			if (row != null)
			{
				if(row["C_ID"]!=null)
				{
					model.C_ID=row["C_ID"].ToString();
				}
				if(row["C_IP"]!=null)
				{
					model.C_IP=row["C_IP"].ToString();
				}
				if(row["C_MODULES"]!=null)
				{
					model.C_MODULES=row["C_MODULES"].ToString();
				}
				if(row["C_MENU_NAME"]!=null)
				{
					model.C_MENU_NAME=row["C_MENU_NAME"].ToString();
				}
				if(row["C_FORMS_NAME"]!=null)
				{
					model.C_FORMS_NAME=row["C_FORMS_NAME"].ToString();
				}
				if(row["C_FORMS_DESC"]!=null)
				{
					model.C_FORMS_DESC=row["C_FORMS_DESC"].ToString();
				}
				if(row["C_OPER_CONTEXT"]!=null)
				{
					model.C_OPER_CONTEXT=row["C_OPER_CONTEXT"].ToString();
				}
				if(row["N_STATUS"]!=null && row["N_STATUS"].ToString()!="")
				{
					model.N_STATUS=decimal.Parse(row["N_STATUS"].ToString());
				}
				if(row["C_REMARK"]!=null)
				{
					model.C_REMARK=row["C_REMARK"].ToString();
				}
				if(row["C_EMP_ID"]!=null)
				{
					model.C_EMP_ID=row["C_EMP_ID"].ToString();
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
			strSql.Append("select C_ID,C_IP,C_MODULES,C_MENU_NAME,C_FORMS_NAME,C_FORMS_DESC,C_OPER_CONTEXT,N_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT ");
			strSql.Append(" FROM TB_LOG ");
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
			strSql.Append("select count(1) FROM TB_LOG ");
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
			strSql.Append(")AS Row, T.*  from TB_LOG T ");
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
			parameters[0].Value = "TB_LOG";
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

