﻿using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;
namespace DAL
{
	/// <summary>
	/// 数据访问类:TQB_FAULT_STATISTICS
	/// </summary>
	public partial class Dal_TQB_FAULT_STATISTICS
    {
		public Dal_TQB_FAULT_STATISTICS()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string C_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from TQB_FAULT_STATISTICS");
			strSql.Append(" where C_ID=:C_ID ");
			OracleParameter[] parameters = {
					new OracleParameter(":C_ID", OracleDbType.Varchar2,100)			};
			parameters[0].Value = C_ID;

			return DbHelperOra.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Mod_TQB_FAULT_STATISTICS model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into TQB_FAULT_STATISTICS(");
			strSql.Append("C_STOVE,C_STL_GRD,C_SLAB_SIZE,C_MAT_NAME,C_STD_CODE,C_TEST_QUANTITY,C_FACE_FAULT_QUA,C_FACE_FAULT_CAUSE,C_FACE_DUTY_DEP,C_WAREHOUSE_QUA,C_WAR_FAULT_CAUSE,C_WAR_DUTY_DEP,C_ALTER_DECIDE_NUM,C_ALTER_DECIDE_CAUSE,C_ALTER_DECIDE_DEP,N_STATUS,C_REMARK,C_EMP_ID)");
			strSql.Append(" values (");
			strSql.Append(":C_STOVE,:C_STL_GRD,:C_SLAB_SIZE,:C_MAT_NAME,:C_STD_CODE,:C_TEST_QUANTITY,:C_FACE_FAULT_QUA,:C_FACE_FAULT_CAUSE,:C_FACE_DUTY_DEP,:C_WAREHOUSE_QUA,:C_WAR_FAULT_CAUSE,:C_WAR_DUTY_DEP,:C_ALTER_DECIDE_NUM,:C_ALTER_DECIDE_CAUSE,:C_ALTER_DECIDE_DEP,:N_STATUS,:C_REMARK,:C_EMP_ID)");
			OracleParameter[] parameters = {
					new OracleParameter(":C_STOVE", OracleDbType.Varchar2,100),
					new OracleParameter(":C_STL_GRD", OracleDbType.Varchar2,100),
					new OracleParameter(":C_SLAB_SIZE", OracleDbType.Varchar2,100),
					new OracleParameter(":C_MAT_NAME", OracleDbType.Varchar2,100),
					new OracleParameter(":C_STD_CODE", OracleDbType.Varchar2,100),
					new OracleParameter(":C_TEST_QUANTITY", OracleDbType.Varchar2,100),
					new OracleParameter(":C_FACE_FAULT_QUA", OracleDbType.Varchar2,100),
					new OracleParameter(":C_FACE_FAULT_CAUSE", OracleDbType.Varchar2,100),
					new OracleParameter(":C_FACE_DUTY_DEP", OracleDbType.Varchar2,100),
					new OracleParameter(":C_WAREHOUSE_QUA", OracleDbType.Varchar2,100),
					new OracleParameter(":C_WAR_FAULT_CAUSE", OracleDbType.Varchar2,100),
					new OracleParameter(":C_WAR_DUTY_DEP", OracleDbType.Varchar2,100),
					new OracleParameter(":C_ALTER_DECIDE_NUM", OracleDbType.Varchar2,100),
					new OracleParameter(":C_ALTER_DECIDE_CAUSE", OracleDbType.Varchar2,100),
					new OracleParameter(":C_ALTER_DECIDE_DEP", OracleDbType.Varchar2,100),
					new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
					new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
					new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100)};
			parameters[0].Value = model.C_STOVE;
			parameters[1].Value = model.C_STL_GRD;
			parameters[2].Value = model.C_SLAB_SIZE;
			parameters[3].Value = model.C_MAT_NAME;
			parameters[4].Value = model.C_STD_CODE;
			parameters[5].Value = model.C_TEST_QUANTITY;
			parameters[6].Value = model.C_FACE_FAULT_QUA;
			parameters[7].Value = model.C_FACE_FAULT_CAUSE;
			parameters[8].Value = model.C_FACE_DUTY_DEP;
			parameters[9].Value = model.C_WAREHOUSE_QUA;
			parameters[10].Value = model.C_WAR_FAULT_CAUSE;
			parameters[11].Value = model.C_WAR_DUTY_DEP;
			parameters[12].Value = model.C_ALTER_DECIDE_NUM;
			parameters[13].Value = model.C_ALTER_DECIDE_CAUSE;
			parameters[14].Value = model.C_ALTER_DECIDE_DEP;
			parameters[15].Value = model.N_STATUS;
			parameters[16].Value = model.C_REMARK;
			parameters[17].Value = model.C_EMP_ID;

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
		public bool Update(Mod_TQB_FAULT_STATISTICS model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update TQB_FAULT_STATISTICS set ");
			strSql.Append("C_STOVE=:C_STOVE,");
			strSql.Append("C_STL_GRD=:C_STL_GRD,");
			strSql.Append("C_SLAB_SIZE=:C_SLAB_SIZE,");
			strSql.Append("C_MAT_NAME=:C_MAT_NAME,");
			strSql.Append("C_STD_CODE=:C_STD_CODE,");
			strSql.Append("C_TEST_QUANTITY=:C_TEST_QUANTITY,");
			strSql.Append("C_FACE_FAULT_QUA=:C_FACE_FAULT_QUA,");
			strSql.Append("C_FACE_FAULT_CAUSE=:C_FACE_FAULT_CAUSE,");
			strSql.Append("C_FACE_DUTY_DEP=:C_FACE_DUTY_DEP,");
			strSql.Append("C_WAREHOUSE_QUA=:C_WAREHOUSE_QUA,");
			strSql.Append("C_WAR_FAULT_CAUSE=:C_WAR_FAULT_CAUSE,");
			strSql.Append("C_WAR_DUTY_DEP=:C_WAR_DUTY_DEP,");
			strSql.Append("C_ALTER_DECIDE_NUM=:C_ALTER_DECIDE_NUM,");
			strSql.Append("C_ALTER_DECIDE_CAUSE=:C_ALTER_DECIDE_CAUSE,");
			strSql.Append("C_ALTER_DECIDE_DEP=:C_ALTER_DECIDE_DEP,");
			strSql.Append("N_STATUS=:N_STATUS,");
			strSql.Append("C_REMARK=:C_REMARK,");
			strSql.Append("C_EMP_ID=:C_EMP_ID,");
			strSql.Append("D_MOD_DT=:D_MOD_DT");
			strSql.Append(" where C_ID=:C_ID ");
			OracleParameter[] parameters = {
					new OracleParameter(":C_STOVE", OracleDbType.Varchar2,100),
					new OracleParameter(":C_STL_GRD", OracleDbType.Varchar2,100),
					new OracleParameter(":C_SLAB_SIZE", OracleDbType.Varchar2,100),
					new OracleParameter(":C_MAT_NAME", OracleDbType.Varchar2,100),
					new OracleParameter(":C_STD_CODE", OracleDbType.Varchar2,100),
					new OracleParameter(":C_TEST_QUANTITY", OracleDbType.Varchar2,100),
					new OracleParameter(":C_FACE_FAULT_QUA", OracleDbType.Varchar2,100),
					new OracleParameter(":C_FACE_FAULT_CAUSE", OracleDbType.Varchar2,100),
					new OracleParameter(":C_FACE_DUTY_DEP", OracleDbType.Varchar2,100),
					new OracleParameter(":C_WAREHOUSE_QUA", OracleDbType.Varchar2,100),
					new OracleParameter(":C_WAR_FAULT_CAUSE", OracleDbType.Varchar2,100),
					new OracleParameter(":C_WAR_DUTY_DEP", OracleDbType.Varchar2,100),
					new OracleParameter(":C_ALTER_DECIDE_NUM", OracleDbType.Varchar2,100),
					new OracleParameter(":C_ALTER_DECIDE_CAUSE", OracleDbType.Varchar2,100),
					new OracleParameter(":C_ALTER_DECIDE_DEP", OracleDbType.Varchar2,100),
					new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
					new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
					new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
					new OracleParameter(":D_MOD_DT", OracleDbType.Date),
					new OracleParameter(":C_ID", OracleDbType.Varchar2,100)};
			parameters[0].Value = model.C_STOVE;
			parameters[1].Value = model.C_STL_GRD;
			parameters[2].Value = model.C_SLAB_SIZE;
			parameters[3].Value = model.C_MAT_NAME;
			parameters[4].Value = model.C_STD_CODE;
			parameters[5].Value = model.C_TEST_QUANTITY;
			parameters[6].Value = model.C_FACE_FAULT_QUA;
			parameters[7].Value = model.C_FACE_FAULT_CAUSE;
			parameters[8].Value = model.C_FACE_DUTY_DEP;
			parameters[9].Value = model.C_WAREHOUSE_QUA;
			parameters[10].Value = model.C_WAR_FAULT_CAUSE;
			parameters[11].Value = model.C_WAR_DUTY_DEP;
			parameters[12].Value = model.C_ALTER_DECIDE_NUM;
			parameters[13].Value = model.C_ALTER_DECIDE_CAUSE;
			parameters[14].Value = model.C_ALTER_DECIDE_DEP;
			parameters[15].Value = model.N_STATUS;
			parameters[16].Value = model.C_REMARK;
			parameters[17].Value = model.C_EMP_ID;
			parameters[18].Value = model.D_MOD_DT;
			parameters[19].Value = model.C_ID;

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
			strSql.Append("delete from TQB_FAULT_STATISTICS ");
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
			strSql.Append("delete from TQB_FAULT_STATISTICS ");
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
		public Mod_TQB_FAULT_STATISTICS GetModel(string C_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select C_ID,C_STOVE,C_STL_GRD,C_SLAB_SIZE,C_MAT_NAME,C_STD_CODE,C_TEST_QUANTITY,C_FACE_FAULT_QUA,C_FACE_FAULT_CAUSE,C_FACE_DUTY_DEP,C_WAREHOUSE_QUA,C_WAR_FAULT_CAUSE,C_WAR_DUTY_DEP,C_ALTER_DECIDE_NUM,C_ALTER_DECIDE_CAUSE,C_ALTER_DECIDE_DEP,N_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT from TQB_FAULT_STATISTICS ");
			strSql.Append(" where C_ID=:C_ID ");
			OracleParameter[] parameters = {
					new OracleParameter(":C_ID", OracleDbType.Varchar2,100)			};
			parameters[0].Value = C_ID;

			Mod_TQB_FAULT_STATISTICS model=new Mod_TQB_FAULT_STATISTICS();
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
		public Mod_TQB_FAULT_STATISTICS DataRowToModel(DataRow row)
		{
			Mod_TQB_FAULT_STATISTICS model=new Mod_TQB_FAULT_STATISTICS();
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
				if(row["C_STL_GRD"]!=null)
				{
					model.C_STL_GRD=row["C_STL_GRD"].ToString();
				}
				if(row["C_SLAB_SIZE"]!=null)
				{
					model.C_SLAB_SIZE=row["C_SLAB_SIZE"].ToString();
				}
				if(row["C_MAT_NAME"]!=null)
				{
					model.C_MAT_NAME=row["C_MAT_NAME"].ToString();
				}
				if(row["C_STD_CODE"]!=null)
				{
					model.C_STD_CODE=row["C_STD_CODE"].ToString();
				}
				if(row["C_TEST_QUANTITY"]!=null)
				{
					model.C_TEST_QUANTITY=row["C_TEST_QUANTITY"].ToString();
				}
				if(row["C_FACE_FAULT_QUA"]!=null)
				{
					model.C_FACE_FAULT_QUA=row["C_FACE_FAULT_QUA"].ToString();
				}
				if(row["C_FACE_FAULT_CAUSE"]!=null)
				{
					model.C_FACE_FAULT_CAUSE=row["C_FACE_FAULT_CAUSE"].ToString();
				}
				if(row["C_FACE_DUTY_DEP"]!=null)
				{
					model.C_FACE_DUTY_DEP=row["C_FACE_DUTY_DEP"].ToString();
				}
				if(row["C_WAREHOUSE_QUA"]!=null)
				{
					model.C_WAREHOUSE_QUA=row["C_WAREHOUSE_QUA"].ToString();
				}
				if(row["C_WAR_FAULT_CAUSE"]!=null)
				{
					model.C_WAR_FAULT_CAUSE=row["C_WAR_FAULT_CAUSE"].ToString();
				}
				if(row["C_WAR_DUTY_DEP"]!=null)
				{
					model.C_WAR_DUTY_DEP=row["C_WAR_DUTY_DEP"].ToString();
				}
				if(row["C_ALTER_DECIDE_NUM"]!=null)
				{
					model.C_ALTER_DECIDE_NUM=row["C_ALTER_DECIDE_NUM"].ToString();
				}
				if(row["C_ALTER_DECIDE_CAUSE"]!=null)
				{
					model.C_ALTER_DECIDE_CAUSE=row["C_ALTER_DECIDE_CAUSE"].ToString();
				}
				if(row["C_ALTER_DECIDE_DEP"]!=null)
				{
					model.C_ALTER_DECIDE_DEP=row["C_ALTER_DECIDE_DEP"].ToString();
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
			strSql.Append("select C_ID,C_STOVE,C_STL_GRD,C_SLAB_SIZE,C_MAT_NAME,C_STD_CODE,C_TEST_QUANTITY,C_FACE_FAULT_QUA,C_FACE_FAULT_CAUSE,C_FACE_DUTY_DEP,C_WAREHOUSE_QUA,C_WAR_FAULT_CAUSE,C_WAR_DUTY_DEP,C_ALTER_DECIDE_NUM,C_ALTER_DECIDE_CAUSE,C_ALTER_DECIDE_DEP,N_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT ");
			strSql.Append(" FROM TQB_FAULT_STATISTICS ");
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
			strSql.Append("select count(1) FROM TQB_FAULT_STATISTICS ");
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
			strSql.Append(")AS Row, T.*  from TQB_FAULT_STATISTICS T ");
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
			parameters[0].Value = "TQB_FAULT_STATISTICS";
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

