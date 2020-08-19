using System;
using System.Data;
using System.Text;
using MODEL;
using System.Data.SqlClient;

namespace IDAL
{
    /// <summary>
    /// 数据访问类:ReZJB_PDD
    /// </summary>
    public partial class Dal_ReZJB_PDD
	{
		public Dal_ReZJB_PDD()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelper_SQL.GetMaxID("pk_ZJB_PDD", "ReZJB_PDD"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int pk_ZJB_PDD)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from ReZJB_PDD");
			strSql.Append(" where pk_ZJB_PDD=@pk_ZJB_PDD");
			SqlParameter[] parameters = {
					new SqlParameter("@pk_ZJB_PDD", SqlDbType.Int,4)
			};
			parameters[0].Value = pk_ZJB_PDD;

			return DbHelper_SQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Mod_ReZJB_PDD model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into ReZJB_PDD(");
			strSql.Append("ZJBstatus,CAPPK,ck,pdrq,ysdh)");
			strSql.Append(" values (");
			strSql.Append("@ZJBstatus,@CAPPK,@ck,@pdrq,@ysdh)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@ZJBstatus", SqlDbType.Int,4),
					new SqlParameter("@CAPPK", SqlDbType.VarChar,50),
					new SqlParameter("@ck", SqlDbType.VarChar,50),
					new SqlParameter("@pdrq", SqlDbType.DateTime),
					new SqlParameter("@ysdh", SqlDbType.VarChar,50)};
			parameters[0].Value = model.ZJBstatus;
			parameters[1].Value = model.CAPPK;
			parameters[2].Value = model.ck;
			parameters[3].Value = model.pdrq;
			parameters[4].Value = model.ysdh;

			object obj = DbHelper_SQL.GetSingle(strSql.ToString(),parameters);
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
		/// 更新一条数据
		/// </summary>
		public bool Update(Mod_ReZJB_PDD model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update ReZJB_PDD set ");
			strSql.Append("ZJBstatus=@ZJBstatus,");
			strSql.Append("CAPPK=@CAPPK,");
			strSql.Append("ck=@ck,");
			strSql.Append("pdrq=@pdrq,");
			strSql.Append("ysdh=@ysdh");
			strSql.Append(" where pk_ZJB_PDD=@pk_ZJB_PDD");
			SqlParameter[] parameters = {
					new SqlParameter("@ZJBstatus", SqlDbType.Int,4),
					new SqlParameter("@CAPPK", SqlDbType.VarChar,50),
					new SqlParameter("@ck", SqlDbType.VarChar,50),
					new SqlParameter("@pdrq", SqlDbType.DateTime),
					new SqlParameter("@ysdh", SqlDbType.VarChar,50),
					new SqlParameter("@pk_ZJB_PDD", SqlDbType.Int,4)};
			parameters[0].Value = model.ZJBstatus;
			parameters[1].Value = model.CAPPK;
			parameters[2].Value = model.ck;
			parameters[3].Value = model.pdrq;
			parameters[4].Value = model.ysdh;
			parameters[5].Value = model.pk_ZJB_PDD;

			int rows=DbHelper_SQL.ExecuteSql(strSql.ToString(),parameters);
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
		public bool Delete(int pk_ZJB_PDD)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ReZJB_PDD ");
			strSql.Append(" where pk_ZJB_PDD=@pk_ZJB_PDD");
			SqlParameter[] parameters = {
					new SqlParameter("@pk_ZJB_PDD", SqlDbType.Int,4)
			};
			parameters[0].Value = pk_ZJB_PDD;

			int rows=DbHelper_SQL.ExecuteSql(strSql.ToString(),parameters);
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
		public bool DeleteList(string pk_ZJB_PDDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ReZJB_PDD ");
			strSql.Append(" where pk_ZJB_PDD in ("+pk_ZJB_PDDlist + ")  ");
			int rows=DbHelper_SQL.ExecuteSql(strSql.ToString());
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
		public Mod_ReZJB_PDD GetModel(int pk_ZJB_PDD)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 pk_ZJB_PDD,ZJBstatus,CAPPK,ck,pdrq,ysdh from ReZJB_PDD ");
			strSql.Append(" where pk_ZJB_PDD=@pk_ZJB_PDD");
			SqlParameter[] parameters = {
					new SqlParameter("@pk_ZJB_PDD", SqlDbType.Int,4)
			};
			parameters[0].Value = pk_ZJB_PDD;

			Mod_ReZJB_PDD model=new Mod_ReZJB_PDD();
			DataSet ds=DbHelper_SQL.Query(strSql.ToString(),parameters);
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
		public Mod_ReZJB_PDD DataRowToModel(DataRow row)
		{
			Mod_ReZJB_PDD model=new Mod_ReZJB_PDD();
			if (row != null)
			{
				if(row["pk_ZJB_PDD"]!=null && row["pk_ZJB_PDD"].ToString()!="")
				{
					model.pk_ZJB_PDD=int.Parse(row["pk_ZJB_PDD"].ToString());
				}
				if(row["ZJBstatus"]!=null && row["ZJBstatus"].ToString()!="")
				{
					model.ZJBstatus=int.Parse(row["ZJBstatus"].ToString());
				}
				if(row["CAPPK"]!=null)
				{
					model.CAPPK=row["CAPPK"].ToString();
				}
				if(row["ck"]!=null)
				{
					model.ck=row["ck"].ToString();
				}
				if(row["pdrq"]!=null && row["pdrq"].ToString()!="")
				{
					model.pdrq=DateTime.Parse(row["pdrq"].ToString());
				}
				if(row["ysdh"]!=null)
				{
					model.ysdh=row["ysdh"].ToString();
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
			strSql.Append("select pk_ZJB_PDD,ZJBstatus,CAPPK,ck,pdrq,ysdh ");
			strSql.Append(" FROM ReZJB_PDD ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelper_SQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			if(Top>0)
			{
				strSql.Append(" top "+Top.ToString());
			}
			strSql.Append(" pk_ZJB_PDD,ZJBstatus,CAPPK,ck,pdrq,ysdh ");
			strSql.Append(" FROM ReZJB_PDD ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelper_SQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM ReZJB_PDD ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			object obj = DbHelper_SQL.GetSingle(strSql.ToString());
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
				strSql.Append("order by T.pk_ZJB_PDD desc");
			}
			strSql.Append(")AS Row, T.*  from ReZJB_PDD T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DbHelper_SQL.Query(strSql.ToString());
		}

		/*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			SqlParameter[] parameters = {
					new SqlParameter("@tblName", SqlDbType.VarChar, 255),
					new SqlParameter("@fldName", SqlDbType.VarChar, 255),
					new SqlParameter("@PageSize", SqlDbType.Int),
					new SqlParameter("@PageIndex", SqlDbType.Int),
					new SqlParameter("@IsReCount", SqlDbType.Bit),
					new SqlParameter("@OrderType", SqlDbType.Bit),
					new SqlParameter("@strWhere", SqlDbType.VarChar,1000),
					};
			parameters[0].Value = "ReZJB_PDD";
			parameters[1].Value = "pk_ZJB_PDD";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelper_SQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

