using System;
using System.Data;
using System.Text;
using MODEL;
using System.Data.SqlClient;

namespace IDAL
{
    /// <summary>
    /// 数据访问类:SeZJB_WGD_Finished
    /// </summary>
    public partial class Dal_SeZJB_WGD_Finished
	{
		public Dal_SeZJB_WGD_Finished()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Mod_SeZJB_WGD_Finished model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into SeZJB_WGD_Finished(");
			strSql.Append("wgdh,pch,finished,ZJBstatus,ts,by1,by2,by3,by4,by5)");
			strSql.Append(" values (");
			strSql.Append("@wgdh,@pch,@finished,@ZJBstatus,@ts,@by1,@by2,@by3,@by4,@by5)");
			SqlParameter[] parameters = {
					new SqlParameter("@wgdh", SqlDbType.VarChar,50),
					new SqlParameter("@pch", SqlDbType.VarChar,20),
					new SqlParameter("@finished", SqlDbType.Int,4),
					new SqlParameter("@ZJBstatus", SqlDbType.Int,4),
					new SqlParameter("@ts", SqlDbType.DateTime),
					new SqlParameter("@by1", SqlDbType.VarChar,100),
					new SqlParameter("@by2", SqlDbType.VarChar,100),
					new SqlParameter("@by3", SqlDbType.VarChar,100),
					new SqlParameter("@by4", SqlDbType.VarChar,100),
					new SqlParameter("@by5", SqlDbType.VarChar,100)};
			parameters[0].Value = model.wgdh;
			parameters[1].Value = model.pch;
			parameters[2].Value = model.finished;
			parameters[3].Value = model.ZJBstatus;
			parameters[4].Value = model.ts;
			parameters[5].Value = model.by1;
			parameters[6].Value = model.by2;
			parameters[7].Value = model.by3;
			parameters[8].Value = model.by4;
			parameters[9].Value = model.by5;

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
		/// 更新一条数据
		/// </summary>
		public bool Update(Mod_SeZJB_WGD_Finished model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update SeZJB_WGD_Finished set ");
			strSql.Append("wgdh=@wgdh,");
			strSql.Append("pch=@pch,");
			strSql.Append("finished=@finished,");
			strSql.Append("ZJBstatus=@ZJBstatus,");
			strSql.Append("ts=@ts,");
			strSql.Append("by1=@by1,");
			strSql.Append("by2=@by2,");
			strSql.Append("by3=@by3,");
			strSql.Append("by4=@by4,");
			strSql.Append("by5=@by5");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
					new SqlParameter("@wgdh", SqlDbType.VarChar,50),
					new SqlParameter("@pch", SqlDbType.VarChar,20),
					new SqlParameter("@finished", SqlDbType.Int,4),
					new SqlParameter("@ZJBstatus", SqlDbType.Int,4),
					new SqlParameter("@ts", SqlDbType.DateTime),
					new SqlParameter("@by1", SqlDbType.VarChar,100),
					new SqlParameter("@by2", SqlDbType.VarChar,100),
					new SqlParameter("@by3", SqlDbType.VarChar,100),
					new SqlParameter("@by4", SqlDbType.VarChar,100),
					new SqlParameter("@by5", SqlDbType.VarChar,100)};
			parameters[0].Value = model.wgdh;
			parameters[1].Value = model.pch;
			parameters[2].Value = model.finished;
			parameters[3].Value = model.ZJBstatus;
			parameters[4].Value = model.ts;
			parameters[5].Value = model.by1;
			parameters[6].Value = model.by2;
			parameters[7].Value = model.by3;
			parameters[8].Value = model.by4;
			parameters[9].Value = model.by5;

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
		public bool Delete()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from SeZJB_WGD_Finished ");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
			};

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
		/// 得到一个对象实体
		/// </summary>
		public Mod_SeZJB_WGD_Finished GetModel()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 wgdh,pch,finished,ZJBstatus,ts,by1,by2,by3,by4,by5 from SeZJB_WGD_Finished ");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
			};

			Mod_SeZJB_WGD_Finished model=new Mod_SeZJB_WGD_Finished();
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
		public Mod_SeZJB_WGD_Finished DataRowToModel(DataRow row)
		{
			Mod_SeZJB_WGD_Finished model=new Mod_SeZJB_WGD_Finished();
			if (row != null)
			{
				if(row["wgdh"]!=null)
				{
					model.wgdh=row["wgdh"].ToString();
				}
				if(row["pch"]!=null)
				{
					model.pch=row["pch"].ToString();
				}
				if(row["finished"]!=null && row["finished"].ToString()!="")
				{
					model.finished=int.Parse(row["finished"].ToString());
				}
				if(row["ZJBstatus"]!=null && row["ZJBstatus"].ToString()!="")
				{
					model.ZJBstatus=int.Parse(row["ZJBstatus"].ToString());
				}
				if(row["ts"]!=null && row["ts"].ToString()!="")
				{
					model.ts=DateTime.Parse(row["ts"].ToString());
				}
				if(row["by1"]!=null)
				{
					model.by1=row["by1"].ToString();
				}
				if(row["by2"]!=null)
				{
					model.by2=row["by2"].ToString();
				}
				if(row["by3"]!=null)
				{
					model.by3=row["by3"].ToString();
				}
				if(row["by4"]!=null)
				{
					model.by4=row["by4"].ToString();
				}
				if(row["by5"]!=null)
				{
					model.by5=row["by5"].ToString();
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
			strSql.Append("select wgdh,pch,finished,ZJBstatus,ts,by1,by2,by3,by4,by5 ");
			strSql.Append(" FROM SeZJB_WGD_Finished ");
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
			strSql.Append(" wgdh,pch,finished,ZJBstatus,ts,by1,by2,by3,by4,by5 ");
			strSql.Append(" FROM SeZJB_WGD_Finished ");
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
			strSql.Append("select count(1) FROM SeZJB_WGD_Finished ");
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
				strSql.Append("order by T.pk_ZJB_ZKD desc");
			}
			strSql.Append(")AS Row, T.*  from SeZJB_WGD_Finished T ");
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
			parameters[0].Value = "SeZJB_WGD_Finished";
			parameters[1].Value = "pk_ZJB_ZKD";
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

