using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;
namespace DAL
{
    /// <summary>
    /// 数据访问类:TPA_ROLL_ACT_PLAN
    /// </summary>
    public partial class Dal_TPA_ROLL_ACT_PLAN
	{
		public Dal_TPA_ROLL_ACT_PLAN()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string C_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from TPA_ROLL_ACT_PLAN");
			strSql.Append(" where C_ID=:C_ID ");
			OracleParameter[] parameters = {
					new OracleParameter(":C_ID", OracleDbType.Varchar2,50)			};
			parameters[0].Value = C_ID;

			return DbHelperOra.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Mod_TPA_ROLL_ACT_PLAN model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into TPA_ROLL_ACT_PLAN(");
			strSql.Append("C_ID,C_LINE,C_STL_GRD,C_STD_CODE,C_SPEC,N_WGT,D_PLAN_DATE,D_NEED_DATE,C_REMARK,D_START_TIME,D_END_TIME,C_FK)");
			strSql.Append(" values (");
			strSql.Append(":C_ID,:C_LINE,:C_STL_GRD,:C_STD_CODE,:C_SPEC,:N_WGT,:D_PLAN_DATE,:D_NEED_DATE,:C_REMARK,:D_START_TIME,:D_END_TIME,:C_FK)");
			OracleParameter[] parameters = {
					new OracleParameter(":C_ID", OracleDbType.Varchar2,50),
					new OracleParameter(":C_LINE", OracleDbType.Varchar2,50),
					new OracleParameter(":C_STL_GRD", OracleDbType.Varchar2,50),
					new OracleParameter(":C_STD_CODE", OracleDbType.Varchar2,50),
					new OracleParameter(":C_SPEC", OracleDbType.Varchar2,50),
					new OracleParameter(":N_WGT", OracleDbType.Decimal,10),
					new OracleParameter(":D_PLAN_DATE", OracleDbType.Date),
					new OracleParameter(":D_NEED_DATE", OracleDbType.Date),
					new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
					new OracleParameter(":D_START_TIME", OracleDbType.Date),
					new OracleParameter(":D_END_TIME", OracleDbType.Date),
					new OracleParameter(":C_FK", OracleDbType.Varchar2,50)};
			parameters[0].Value = model.C_ID;
			parameters[1].Value = model.C_LINE;
			parameters[2].Value = model.C_STL_GRD;
			parameters[3].Value = model.C_STD_CODE;
			parameters[4].Value = model.C_SPEC;
			parameters[5].Value = model.N_WGT;
			parameters[6].Value = model.D_PLAN_DATE;
			parameters[7].Value = model.D_NEED_DATE;
			parameters[8].Value = model.C_REMARK;
			parameters[9].Value = model.D_START_TIME;
			parameters[10].Value = model.D_END_TIME;
			parameters[11].Value = model.C_FK;

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
		public bool Update(Mod_TPA_ROLL_ACT_PLAN model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update TPA_ROLL_ACT_PLAN set ");
			strSql.Append("C_LINE=:C_LINE,");
			strSql.Append("C_STL_GRD=:C_STL_GRD,");
			strSql.Append("C_STD_CODE=:C_STD_CODE,");
			strSql.Append("C_SPEC=:C_SPEC,");
			strSql.Append("N_WGT=:N_WGT,");
			strSql.Append("D_PLAN_DATE=:D_PLAN_DATE,");
			strSql.Append("D_NEED_DATE=:D_NEED_DATE,");
			strSql.Append("C_REMARK=:C_REMARK,");
			strSql.Append("D_START_TIME=:D_START_TIME,");
			strSql.Append("D_END_TIME=:D_END_TIME,");
			strSql.Append("C_FK=:C_FK");
			strSql.Append(" where C_ID=:C_ID ");
			OracleParameter[] parameters = {
					new OracleParameter(":C_LINE", OracleDbType.Varchar2,50),
					new OracleParameter(":C_STL_GRD", OracleDbType.Varchar2,50),
					new OracleParameter(":C_STD_CODE", OracleDbType.Varchar2,50),
					new OracleParameter(":C_SPEC", OracleDbType.Varchar2,50),
					new OracleParameter(":N_WGT", OracleDbType.Decimal,10),
					new OracleParameter(":D_PLAN_DATE", OracleDbType.Date),
					new OracleParameter(":D_NEED_DATE", OracleDbType.Date),
					new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
					new OracleParameter(":D_START_TIME", OracleDbType.Date),
					new OracleParameter(":D_END_TIME", OracleDbType.Date),
					new OracleParameter(":C_FK", OracleDbType.Varchar2,50),
					new OracleParameter(":C_ID", OracleDbType.Varchar2,50)};
			parameters[0].Value = model.C_LINE;
			parameters[1].Value = model.C_STL_GRD;
			parameters[2].Value = model.C_STD_CODE;
			parameters[3].Value = model.C_SPEC;
			parameters[4].Value = model.N_WGT;
			parameters[5].Value = model.D_PLAN_DATE;
			parameters[6].Value = model.D_NEED_DATE;
			parameters[7].Value = model.C_REMARK;
			parameters[8].Value = model.D_START_TIME;
			parameters[9].Value = model.D_END_TIME;
			parameters[10].Value = model.C_FK;
			parameters[11].Value = model.C_ID;

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
			strSql.Append("delete from TPA_ROLL_ACT_PLAN ");
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
			strSql.Append("delete from TPA_ROLL_ACT_PLAN ");
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
		public Mod_TPA_ROLL_ACT_PLAN GetModel(string C_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select C_ID,C_LINE,C_STL_GRD,C_STD_CODE,C_SPEC,N_WGT,D_PLAN_DATE,D_NEED_DATE,C_REMARK,D_START_TIME,D_END_TIME,C_FK from TPA_ROLL_ACT_PLAN ");
			strSql.Append(" where C_ID=:C_ID ");
			OracleParameter[] parameters = {
					new OracleParameter(":C_ID", OracleDbType.Varchar2,50)			};
			parameters[0].Value = C_ID;

			Mod_TPA_ROLL_ACT_PLAN model=new Mod_TPA_ROLL_ACT_PLAN();
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
		public Mod_TPA_ROLL_ACT_PLAN DataRowToModel(DataRow row)
		{
			Mod_TPA_ROLL_ACT_PLAN model=new Mod_TPA_ROLL_ACT_PLAN();
			if (row != null)
			{
				if(row["C_ID"]!=null)
				{
					model.C_ID=row["C_ID"].ToString();
				}
				if(row["C_LINE"]!=null)
				{
					model.C_LINE=row["C_LINE"].ToString();
				}
				if(row["C_STL_GRD"]!=null)
				{
					model.C_STL_GRD=row["C_STL_GRD"].ToString();
				}
				if(row["C_STD_CODE"]!=null)
				{
					model.C_STD_CODE=row["C_STD_CODE"].ToString();
				}
				if(row["C_SPEC"]!=null)
				{
					model.C_SPEC=row["C_SPEC"].ToString();
				}
				if(row["N_WGT"]!=null && row["N_WGT"].ToString()!="")
				{
					model.N_WGT=decimal.Parse(row["N_WGT"].ToString());
				}
				if(row["D_PLAN_DATE"]!=null && row["D_PLAN_DATE"].ToString()!="")
				{
					model.D_PLAN_DATE=DateTime.Parse(row["D_PLAN_DATE"].ToString());
				}
				if(row["D_NEED_DATE"]!=null && row["D_NEED_DATE"].ToString()!="")
				{
					model.D_NEED_DATE=DateTime.Parse(row["D_NEED_DATE"].ToString());
				}
				if(row["C_REMARK"]!=null)
				{
					model.C_REMARK=row["C_REMARK"].ToString();
				}
				if(row["D_START_TIME"]!=null && row["D_START_TIME"].ToString()!="")
				{
					model.D_START_TIME=DateTime.Parse(row["D_START_TIME"].ToString());
				}
				if(row["D_END_TIME"]!=null && row["D_END_TIME"].ToString()!="")
				{
					model.D_END_TIME=DateTime.Parse(row["D_END_TIME"].ToString());
				}
				if(row["C_FK"]!=null)
				{
					model.C_FK=row["C_FK"].ToString();
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
			strSql.Append("select C_ID,C_LINE,C_STL_GRD,C_STD_CODE,C_SPEC,N_WGT,D_PLAN_DATE,D_NEED_DATE,C_REMARK,D_START_TIME,D_END_TIME,C_FK ");
			strSql.Append(" FROM TPA_ROLL_ACT_PLAN ");
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
			strSql.Append("select count(1) FROM TPA_ROLL_ACT_PLAN ");
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
			strSql.Append(")AS Row, T.*  from TPA_ROLL_ACT_PLAN T ");
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
			parameters[0].Value = "TPA_ROLL_ACT_PLAN";
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

