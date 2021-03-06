﻿using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;
namespace DAL
{
    /// <summary>
    /// 数据访问类:TPA_SLAB_USE_PLAN
    /// </summary>
    public partial class Dal_TPA_SLAB_USE_PLAN
	{
		public Dal_TPA_SLAB_USE_PLAN()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string C_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from TPA_SLAB_USE_PLAN");
			strSql.Append(" where C_ID=:C_ID ");
			OracleParameter[] parameters = {
					new OracleParameter(":C_ID", OracleDbType.Varchar2,50)			};
			parameters[0].Value = C_ID;

			return DbHelperOra.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Mod_TPA_SLAB_USE_PLAN model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into TPA_SLAB_USE_PLAN(");
			strSql.Append("C_ID,C_FK,C_STOVE_NO,C_STL_GRD,C_STD_CODE,N_WGT,D_PLAN_DATE,C_REMARK,N_STATUS,N_QUA,C_CCM,D_OUT_STOCK_TIME,C_USE_CX)");
			strSql.Append(" values (");
			strSql.Append(":C_ID,:C_FK,:C_STOVE_NO,:C_STL_GRD,:C_STD_CODE,:N_WGT,:D_PLAN_DATE,:C_REMARK,:N_STATUS,:N_QUA,:C_CCM,:D_OUT_STOCK_TIME,:C_USE_CX)");
			OracleParameter[] parameters = {
					new OracleParameter(":C_ID", OracleDbType.Varchar2,50),
					new OracleParameter(":C_FK", OracleDbType.Varchar2,50),
					new OracleParameter(":C_STOVE_NO", OracleDbType.Varchar2,50),
					new OracleParameter(":C_STL_GRD", OracleDbType.Varchar2,50),
					new OracleParameter(":C_STD_CODE", OracleDbType.Varchar2,50),
					new OracleParameter(":N_WGT", OracleDbType.Decimal,10),
					new OracleParameter(":D_PLAN_DATE", OracleDbType.Date),
					new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
					new OracleParameter(":N_STATUS", OracleDbType.Decimal,5),
					new OracleParameter(":N_QUA", OracleDbType.Decimal,5),
					new OracleParameter(":C_CCM", OracleDbType.Varchar2,50),
					new OracleParameter(":D_OUT_STOCK_TIME", OracleDbType.Date),
					new OracleParameter(":C_USE_CX", OracleDbType.Varchar2,50)};
			parameters[0].Value = model.C_ID;
			parameters[1].Value = model.C_FK;
			parameters[2].Value = model.C_STOVE_NO;
			parameters[3].Value = model.C_STL_GRD;
			parameters[4].Value = model.C_STD_CODE;
			parameters[5].Value = model.N_WGT;
			parameters[6].Value = model.D_PLAN_DATE;
			parameters[7].Value = model.C_REMARK;
			parameters[8].Value = model.N_STATUS;
			parameters[9].Value = model.N_QUA;
			parameters[10].Value = model.C_CCM;
			parameters[11].Value = model.D_OUT_STOCK_TIME;
			parameters[12].Value = model.C_USE_CX;

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
		public bool Update(Mod_TPA_SLAB_USE_PLAN model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update TPA_SLAB_USE_PLAN set ");
			strSql.Append("C_FK=:C_FK,");
			strSql.Append("C_STOVE_NO=:C_STOVE_NO,");
			strSql.Append("C_STL_GRD=:C_STL_GRD,");
			strSql.Append("C_STD_CODE=:C_STD_CODE,");
			strSql.Append("N_WGT=:N_WGT,");
			strSql.Append("D_PLAN_DATE=:D_PLAN_DATE,");
			strSql.Append("C_REMARK=:C_REMARK,");
			strSql.Append("N_STATUS=:N_STATUS,");
			strSql.Append("N_QUA=:N_QUA,");
			strSql.Append("C_CCM=:C_CCM,");
			strSql.Append("D_OUT_STOCK_TIME=:D_OUT_STOCK_TIME,");
			strSql.Append("C_USE_CX=:C_USE_CX");
			strSql.Append(" where C_ID=:C_ID ");
			OracleParameter[] parameters = {
					new OracleParameter(":C_FK", OracleDbType.Varchar2,50),
					new OracleParameter(":C_STOVE_NO", OracleDbType.Varchar2,50),
					new OracleParameter(":C_STL_GRD", OracleDbType.Varchar2,50),
					new OracleParameter(":C_STD_CODE", OracleDbType.Varchar2,50),
					new OracleParameter(":N_WGT", OracleDbType.Decimal,10),
					new OracleParameter(":D_PLAN_DATE", OracleDbType.Date),
					new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
					new OracleParameter(":N_STATUS", OracleDbType.Decimal,5),
					new OracleParameter(":N_QUA", OracleDbType.Decimal,5),
					new OracleParameter(":C_CCM", OracleDbType.Varchar2,50),
					new OracleParameter(":D_OUT_STOCK_TIME", OracleDbType.Date),
					new OracleParameter(":C_USE_CX", OracleDbType.Varchar2,50),
					new OracleParameter(":C_ID", OracleDbType.Varchar2,50)};
			parameters[0].Value = model.C_FK;
			parameters[1].Value = model.C_STOVE_NO;
			parameters[2].Value = model.C_STL_GRD;
			parameters[3].Value = model.C_STD_CODE;
			parameters[4].Value = model.N_WGT;
			parameters[5].Value = model.D_PLAN_DATE;
			parameters[6].Value = model.C_REMARK;
			parameters[7].Value = model.N_STATUS;
			parameters[8].Value = model.N_QUA;
			parameters[9].Value = model.C_CCM;
			parameters[10].Value = model.D_OUT_STOCK_TIME;
			parameters[11].Value = model.C_USE_CX;
			parameters[12].Value = model.C_ID;

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
			strSql.Append("delete from TPA_SLAB_USE_PLAN ");
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
			strSql.Append("delete from TPA_SLAB_USE_PLAN ");
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
		public Mod_TPA_SLAB_USE_PLAN GetModel(string C_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select C_ID,C_FK,C_STOVE_NO,C_STL_GRD,C_STD_CODE,N_WGT,D_PLAN_DATE,C_REMARK,N_STATUS,N_QUA,C_CCM,D_OUT_STOCK_TIME,C_USE_CX from TPA_SLAB_USE_PLAN ");
			strSql.Append(" where C_ID=:C_ID ");
			OracleParameter[] parameters = {
					new OracleParameter(":C_ID", OracleDbType.Varchar2,50)			};
			parameters[0].Value = C_ID;

			Mod_TPA_SLAB_USE_PLAN model=new Mod_TPA_SLAB_USE_PLAN();
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
		public Mod_TPA_SLAB_USE_PLAN DataRowToModel(DataRow row)
		{
			Mod_TPA_SLAB_USE_PLAN model=new Mod_TPA_SLAB_USE_PLAN();
			if (row != null)
			{
				if(row["C_ID"]!=null)
				{
					model.C_ID=row["C_ID"].ToString();
				}
				if(row["C_FK"]!=null)
				{
					model.C_FK=row["C_FK"].ToString();
				}
				if(row["C_STOVE_NO"]!=null)
				{
					model.C_STOVE_NO=row["C_STOVE_NO"].ToString();
				}
				if(row["C_STL_GRD"]!=null)
				{
					model.C_STL_GRD=row["C_STL_GRD"].ToString();
				}
				if(row["C_STD_CODE"]!=null)
				{
					model.C_STD_CODE=row["C_STD_CODE"].ToString();
				}
				if(row["N_WGT"]!=null && row["N_WGT"].ToString()!="")
				{
					model.N_WGT=decimal.Parse(row["N_WGT"].ToString());
				}
				if(row["D_PLAN_DATE"]!=null && row["D_PLAN_DATE"].ToString()!="")
				{
					model.D_PLAN_DATE=DateTime.Parse(row["D_PLAN_DATE"].ToString());
				}
				if(row["C_REMARK"]!=null)
				{
					model.C_REMARK=row["C_REMARK"].ToString();
				}
				if(row["N_STATUS"]!=null && row["N_STATUS"].ToString()!="")
				{
					model.N_STATUS=decimal.Parse(row["N_STATUS"].ToString());
				}
				if(row["N_QUA"]!=null && row["N_QUA"].ToString()!="")
				{
					model.N_QUA=decimal.Parse(row["N_QUA"].ToString());
				}
				if(row["C_CCM"]!=null)
				{
					model.C_CCM=row["C_CCM"].ToString();
				}
				if(row["D_OUT_STOCK_TIME"]!=null && row["D_OUT_STOCK_TIME"].ToString()!="")
				{
					model.D_OUT_STOCK_TIME=DateTime.Parse(row["D_OUT_STOCK_TIME"].ToString());
				}
				if(row["C_USE_CX"]!=null)
				{
					model.C_USE_CX=row["C_USE_CX"].ToString();
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
			strSql.Append("select C_ID,C_FK,C_STOVE_NO,C_STL_GRD,C_STD_CODE,N_WGT,D_PLAN_DATE,C_REMARK,N_STATUS,N_QUA,C_CCM,D_OUT_STOCK_TIME,C_USE_CX ");
			strSql.Append(" FROM TPA_SLAB_USE_PLAN ");
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
			strSql.Append("select count(1) FROM TPA_SLAB_USE_PLAN ");
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
			strSql.Append(")AS Row, T.*  from TPA_SLAB_USE_PLAN T ");
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
			parameters[0].Value = "TPA_SLAB_USE_PLAN";
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

