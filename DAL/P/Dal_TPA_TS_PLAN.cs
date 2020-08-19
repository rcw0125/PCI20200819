using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;
namespace DAL
{
    /// <summary>
    /// 数据访问类:TPA_TS_PLAN
    /// </summary>
    public partial class Dal_TPA_TS_PLAN
	{
		public Dal_TPA_TS_PLAN()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Mod_TPA_TS_PLAN model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into TPA_TS_PLAN(");
			strSql.Append("C_ID,C_STEEL_TYPE,D_PLAN_TIME,D_ARRIVE_TIME,N_STEEL_WGT,D_PLAN_DATE,D_SJ_TIME,N_SJ_WGT)");
			strSql.Append(" values (");
			strSql.Append(":C_ID,:C_STEEL_TYPE,:D_PLAN_TIME,:D_ARRIVE_TIME,:N_STEEL_WGT,:D_PLAN_DATE,:D_SJ_TIME,:N_SJ_WGT)");
			OracleParameter[] parameters = {
					new OracleParameter(":C_ID", OracleDbType.Varchar2,50),
					new OracleParameter(":C_STEEL_TYPE", OracleDbType.Varchar2,50),
					new OracleParameter(":D_PLAN_TIME", OracleDbType.Date),
					new OracleParameter(":D_ARRIVE_TIME", OracleDbType.Date),
					new OracleParameter(":N_STEEL_WGT", OracleDbType.Decimal,10),
					new OracleParameter(":D_PLAN_DATE", OracleDbType.Decimal),
					new OracleParameter(":D_SJ_TIME", OracleDbType.Date),
					new OracleParameter(":N_SJ_WGT", OracleDbType.Decimal,10)};
			parameters[0].Value = model.C_ID;
			parameters[1].Value = model.C_STEEL_TYPE;
			parameters[2].Value = model.D_PLAN_TIME;
			parameters[3].Value = model.D_ARRIVE_TIME;
			parameters[4].Value = model.N_STEEL_WGT;
			parameters[5].Value = model.D_PLAN_DATE;
			parameters[6].Value = model.D_SJ_TIME;
			parameters[7].Value = model.N_SJ_WGT;

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
		public bool Update(Mod_TPA_TS_PLAN model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update TPA_TS_PLAN set ");
			strSql.Append("C_ID=:C_ID,");
			strSql.Append("C_STEEL_TYPE=:C_STEEL_TYPE,");
			strSql.Append("D_PLAN_TIME=:D_PLAN_TIME,");
			strSql.Append("D_ARRIVE_TIME=:D_ARRIVE_TIME,");
			strSql.Append("N_STEEL_WGT=:N_STEEL_WGT,");
			strSql.Append("D_PLAN_DATE=:D_PLAN_DATE,");
			strSql.Append("D_SJ_TIME=:D_SJ_TIME,");
			strSql.Append("N_SJ_WGT=:N_SJ_WGT");
			strSql.Append(" where ");
			OracleParameter[] parameters = {
					new OracleParameter(":C_ID", OracleDbType.Varchar2,50),
					new OracleParameter(":C_STEEL_TYPE", OracleDbType.Varchar2,50),
					new OracleParameter(":D_PLAN_TIME", OracleDbType.Date),
					new OracleParameter(":D_ARRIVE_TIME", OracleDbType.Date),
					new OracleParameter(":N_STEEL_WGT", OracleDbType.Decimal,10),
					new OracleParameter(":D_PLAN_DATE", OracleDbType.Date),
					new OracleParameter(":D_SJ_TIME", OracleDbType.Date),
					new OracleParameter(":N_SJ_WGT", OracleDbType.Decimal,10)};
			parameters[0].Value = model.C_ID;
			parameters[1].Value = model.C_STEEL_TYPE;
			parameters[2].Value = model.D_PLAN_TIME;
			parameters[3].Value = model.D_ARRIVE_TIME;
			parameters[4].Value = model.N_STEEL_WGT;
			parameters[5].Value = model.D_PLAN_DATE;
			parameters[6].Value = model.D_SJ_TIME;
			parameters[7].Value = model.N_SJ_WGT;

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
			strSql.Append("delete from TPA_TS_PLAN ");
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
		public Mod_TPA_TS_PLAN GetModel()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select C_ID,C_STEEL_TYPE,D_PLAN_TIME,D_ARRIVE_TIME,N_STEEL_WGT,D_PLAN_DATE,D_SJ_TIME,N_SJ_WGT from TPA_TS_PLAN ");
			strSql.Append(" where ");
			OracleParameter[] parameters = {
			};

			Mod_TPA_TS_PLAN model=new Mod_TPA_TS_PLAN();
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
		public Mod_TPA_TS_PLAN DataRowToModel(DataRow row)
		{
			Mod_TPA_TS_PLAN model=new Mod_TPA_TS_PLAN();
			if (row != null)
			{
				if(row["C_ID"]!=null)
				{
					model.C_ID=row["C_ID"].ToString();
				}
				if(row["C_STEEL_TYPE"]!=null)
				{
					model.C_STEEL_TYPE=row["C_STEEL_TYPE"].ToString();
				}
				if(row["D_PLAN_TIME"]!=null && row["D_PLAN_TIME"].ToString()!="")
				{
					model.D_PLAN_TIME=DateTime.Parse(row["D_PLAN_TIME"].ToString());
				}
				if(row["D_ARRIVE_TIME"]!=null && row["D_ARRIVE_TIME"].ToString()!="")
				{
					model.D_ARRIVE_TIME=DateTime.Parse(row["D_ARRIVE_TIME"].ToString());
				}
				if(row["N_STEEL_WGT"]!=null && row["N_STEEL_WGT"].ToString()!="")
				{
					model.N_STEEL_WGT=decimal.Parse(row["N_STEEL_WGT"].ToString());
				}
				if(row["D_PLAN_DATE"]!=null && row["D_PLAN_DATE"].ToString()!="")
				{
					model.D_PLAN_DATE=DateTime.Parse(row["D_PLAN_DATE"].ToString());
				}
				if(row["D_SJ_TIME"]!=null && row["D_SJ_TIME"].ToString()!="")
				{
					model.D_SJ_TIME=DateTime.Parse(row["D_SJ_TIME"].ToString());
				}
				if(row["N_SJ_WGT"]!=null && row["N_SJ_WGT"].ToString()!="")
				{
					model.N_SJ_WGT=decimal.Parse(row["N_SJ_WGT"].ToString());
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
			strSql.Append("select C_ID,C_STEEL_TYPE,D_PLAN_TIME,D_ARRIVE_TIME,N_STEEL_WGT,D_PLAN_DATE,D_SJ_TIME,N_SJ_WGT ");
			strSql.Append(" FROM TPA_TS_PLAN ");
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
			strSql.Append("select count(1) FROM TPA_TS_PLAN ");
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
			strSql.Append(")AS Row, T.*  from TPA_TS_PLAN T ");
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
			parameters[0].Value = "TPA_TS_PLAN";
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

