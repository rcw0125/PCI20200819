﻿using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;
namespace DAL
{
	/// <summary>
	/// 数据访问类:TPB_SLAB_ALLOT
	/// </summary>
	public partial class Dal_TPB_SLAB_ALLOT
	{
		public Dal_TPB_SLAB_ALLOT()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string C_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from TPB_SLAB_ALLOT");
			strSql.Append(" where C_ID=:C_ID ");
			OracleParameter[] parameters = {
					new OracleParameter(":C_ID", OracleDbType.Varchar2,100)			};
			parameters[0].Value = C_ID;

			return DbHelperOra.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Mod_TPB_SLAB_ALLOT model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into TPB_SLAB_ALLOT(");
			strSql.Append("C_PRO_CONDITION_ID,C_SLAB_REQUIRE,N_STATUS,C_REMARK,D_START_DATE,D_END_DATE,C_EMP_ID,D_MOD_DT)");
			strSql.Append(" values (");
			strSql.Append(":C_PRO_CONDITION_ID,:C_SLAB_REQUIRE,:N_STATUS,:C_REMARK,:D_START_DATE,:D_END_DATE,:C_EMP_ID,:D_MOD_DT)");
			OracleParameter[] parameters = {

					new OracleParameter(":C_PRO_CONDITION_ID", OracleDbType.Varchar2,100),
					new OracleParameter(":C_SLAB_REQUIRE", OracleDbType.Varchar2,1000),
					new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
					new OracleParameter(":C_REMARK", OracleDbType.Varchar2,200),
					new OracleParameter(":D_START_DATE", OracleDbType.Date),
					new OracleParameter(":D_END_DATE", OracleDbType.Date),
					new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
					new OracleParameter(":D_MOD_DT", OracleDbType.Date)};
			parameters[0].Value = model.C_PRO_CONDITION_ID;
			parameters[1].Value = model.C_SLAB_REQUIRE;
			parameters[2].Value = model.N_STATUS;
			parameters[3].Value = model.C_REMARK;
			parameters[4].Value = model.D_START_DATE;
			parameters[5].Value = model.D_END_DATE;
			parameters[6].Value = model.C_EMP_ID;
			parameters[7].Value = model.D_MOD_DT;

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
		public bool Update(Mod_TPB_SLAB_ALLOT model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update TPB_SLAB_ALLOT set ");
			strSql.Append("C_PRO_CONDITION_ID=:C_PRO_CONDITION_ID,");
			strSql.Append("C_SLAB_REQUIRE=:C_SLAB_REQUIRE,");
			strSql.Append("N_STATUS=:N_STATUS,");
			strSql.Append("C_REMARK=:C_REMARK,");
			strSql.Append("D_START_DATE=:D_START_DATE,");
			strSql.Append("D_END_DATE=:D_END_DATE,");
			strSql.Append("C_EMP_ID=:C_EMP_ID,");
			strSql.Append("D_MOD_DT=:D_MOD_DT");
			strSql.Append(" where C_ID=:C_ID ");
			OracleParameter[] parameters = {
					new OracleParameter(":C_PRO_CONDITION_ID", OracleDbType.Varchar2,100),
					new OracleParameter(":C_SLAB_REQUIRE", OracleDbType.Varchar2,1000),
					new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
					new OracleParameter(":C_REMARK", OracleDbType.Varchar2,200),
					new OracleParameter(":D_START_DATE", OracleDbType.Date),
					new OracleParameter(":D_END_DATE", OracleDbType.Date),
					new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
					new OracleParameter(":D_MOD_DT", OracleDbType.Date),
					new OracleParameter(":C_ID", OracleDbType.Varchar2,100)};
			parameters[0].Value = model.C_PRO_CONDITION_ID;
			parameters[1].Value = model.C_SLAB_REQUIRE;
			parameters[2].Value = model.N_STATUS;
			parameters[3].Value = model.C_REMARK;
			parameters[4].Value = model.D_START_DATE;
			parameters[5].Value = model.D_END_DATE;
			parameters[6].Value = model.C_EMP_ID;
			parameters[7].Value = model.D_MOD_DT;
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
			strSql.Append("delete from TPB_SLAB_ALLOT ");
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
			strSql.Append("delete from TPB_SLAB_ALLOT ");
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
		public Mod_TPB_SLAB_ALLOT GetModel(string C_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select C_ID,C_PRO_CONDITION_ID,C_SLAB_REQUIRE,N_STATUS,C_REMARK,D_START_DATE,D_END_DATE,C_EMP_ID,D_MOD_DT from TPB_SLAB_ALLOT ");
			strSql.Append(" where C_ID=:C_ID ");
			OracleParameter[] parameters = {
					new OracleParameter(":C_ID", OracleDbType.Varchar2,100)			};
			parameters[0].Value = C_ID;

			Mod_TPB_SLAB_ALLOT model=new Mod_TPB_SLAB_ALLOT();
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
		public Mod_TPB_SLAB_ALLOT DataRowToModel(DataRow row)
		{
			Mod_TPB_SLAB_ALLOT model=new Mod_TPB_SLAB_ALLOT();
			if (row != null)
			{
				if(row["C_ID"]!=null)
				{
					model.C_ID=row["C_ID"].ToString();
				}
				if(row["C_PRO_CONDITION_ID"]!=null)
				{
					model.C_PRO_CONDITION_ID=row["C_PRO_CONDITION_ID"].ToString();
				}
				if(row["C_SLAB_REQUIRE"]!=null)
				{
					model.C_SLAB_REQUIRE=row["C_SLAB_REQUIRE"].ToString();
				}
				if(row["N_STATUS"]!=null && row["N_STATUS"].ToString()!="")
				{
					model.N_STATUS=decimal.Parse(row["N_STATUS"].ToString());
				}
				if(row["C_REMARK"]!=null)
				{
					model.C_REMARK=row["C_REMARK"].ToString();
				}
				if(row["D_START_DATE"]!=null && row["D_START_DATE"].ToString()!="")
				{
					model.D_START_DATE=DateTime.Parse(row["D_START_DATE"].ToString());
				}
				if(row["D_END_DATE"]!=null && row["D_END_DATE"].ToString()!="")
				{
					model.D_END_DATE=DateTime.Parse(row["D_END_DATE"].ToString());
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
		public DataSet GetList_Query(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_PRO_CONDITION_ID,C_SLAB_REQUIRE,N_STATUS,C_REMARK,D_START_DATE,D_END_DATE,C_EMP_ID,D_MOD_DT ");
            strSql.Append(" FROM TPB_SLAB_ALLOT ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where  C_PRO_CONDITION_ID = '" + strWhere + "' ");
            }
            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select C_ID,C_PRO_CONDITION_ID,C_SLAB_REQUIRE,N_STATUS,C_REMARK,D_START_DATE,D_END_DATE,C_EMP_ID,D_MOD_DT ");
			strSql.Append(" FROM TPB_SLAB_ALLOT ");
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
			strSql.Append("select count(1) FROM TPB_SLAB_ALLOT ");
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
			strSql.Append(")AS Row, T.*  from TPB_SLAB_ALLOT T ");
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
			parameters[0].Value = "TPB_SLAB_ALLOT";
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

