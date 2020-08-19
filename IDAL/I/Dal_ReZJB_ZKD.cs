using System;
using System.Data;
using System.Text;
using MODEL;
using System.Data.SqlClient;

namespace IDAL
{
    /// <summary>
    /// 数据访问类:ReZJB_ZKD
    /// </summary>
    public partial class Dal_ReZJB_ZKD
	{
		public Dal_ReZJB_ZKD()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelper_SQL.GetMaxID("pk_ZJB_ZKD", "ReZJB_ZKD"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int pk_ZJB_ZKD)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from ReZJB_ZKD");
			strSql.Append(" where pk_ZJB_ZKD=@pk_ZJB_ZKD");
			SqlParameter[] parameters = {
					new SqlParameter("@pk_ZJB_ZKD", SqlDbType.Int,4)
			};
			parameters[0].Value = pk_ZJB_ZKD;

			return DbHelper_SQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Mod_ReZJB_ZKD model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into ReZJB_ZKD(");
			strSql.Append("zkdh,sck,tck,wlh,wlmc,pch,sx,zldj,jhsl,jhzl,zjldw,fjldw,ph,gg,vfree0,vfree1,vfree2,vfree3,vfree4,ZJBstatus,CAPPK)");
			strSql.Append(" values (");
			strSql.Append("@zkdh,@sck,@tck,@wlh,@wlmc,@pch,@sx,@zldj,@jhsl,@jhzl,@zjldw,@fjldw,@ph,@gg,@vfree0,@vfree1,@vfree2,@vfree3,@vfree4,@ZJBstatus,@CAPPK)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@zkdh", SqlDbType.VarChar,50),
					new SqlParameter("@sck", SqlDbType.VarChar,50),
					new SqlParameter("@tck", SqlDbType.VarChar,50),
					new SqlParameter("@wlh", SqlDbType.VarChar,50),
					new SqlParameter("@wlmc", SqlDbType.VarChar,50),
					new SqlParameter("@pch", SqlDbType.VarChar,50),
					new SqlParameter("@sx", SqlDbType.VarChar,50),
					new SqlParameter("@zldj", SqlDbType.VarChar,50),
					new SqlParameter("@jhsl", SqlDbType.Decimal,9),
					new SqlParameter("@jhzl", SqlDbType.Decimal,9),
					new SqlParameter("@zjldw", SqlDbType.VarChar,50),
					new SqlParameter("@fjldw", SqlDbType.VarChar,50),
					new SqlParameter("@ph", SqlDbType.VarChar,50),
					new SqlParameter("@gg", SqlDbType.VarChar,50),
					new SqlParameter("@vfree0", SqlDbType.VarChar,50),
					new SqlParameter("@vfree1", SqlDbType.VarChar,50),
					new SqlParameter("@vfree2", SqlDbType.VarChar,50),
					new SqlParameter("@vfree3", SqlDbType.VarChar,50),
					new SqlParameter("@vfree4", SqlDbType.VarChar,50),
					new SqlParameter("@ZJBstatus", SqlDbType.Int,4),
					new SqlParameter("@CAPPK", SqlDbType.VarChar,50)};
			parameters[0].Value = model.zkdh;
			parameters[1].Value = model.sck;
			parameters[2].Value = model.tck;
			parameters[3].Value = model.wlh;
			parameters[4].Value = model.wlmc;
			parameters[5].Value = model.pch;
			parameters[6].Value = model.sx;
			parameters[7].Value = model.zldj;
			parameters[8].Value = model.jhsl;
			parameters[9].Value = model.jhzl;
			parameters[10].Value = model.zjldw;
			parameters[11].Value = model.fjldw;
			parameters[12].Value = model.ph;
			parameters[13].Value = model.gg;
			parameters[14].Value = model.vfree0;
			parameters[15].Value = model.vfree1;
			parameters[16].Value = model.vfree2;
			parameters[17].Value = model.vfree3;
			parameters[18].Value = model.vfree4;
			parameters[19].Value = model.ZJBstatus;
			parameters[20].Value = model.CAPPK;

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
		public bool Update(Mod_ReZJB_ZKD model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update ReZJB_ZKD set ");
			strSql.Append("zkdh=@zkdh,");
			strSql.Append("sck=@sck,");
			strSql.Append("tck=@tck,");
			strSql.Append("wlh=@wlh,");
			strSql.Append("wlmc=@wlmc,");
			strSql.Append("pch=@pch,");
			strSql.Append("sx=@sx,");
			strSql.Append("zldj=@zldj,");
			strSql.Append("jhsl=@jhsl,");
			strSql.Append("jhzl=@jhzl,");
			strSql.Append("zjldw=@zjldw,");
			strSql.Append("fjldw=@fjldw,");
			strSql.Append("ph=@ph,");
			strSql.Append("gg=@gg,");
			strSql.Append("vfree0=@vfree0,");
			strSql.Append("vfree1=@vfree1,");
			strSql.Append("vfree2=@vfree2,");
			strSql.Append("vfree3=@vfree3,");
			strSql.Append("vfree4=@vfree4,");
			strSql.Append("ZJBstatus=@ZJBstatus,");
			strSql.Append("CAPPK=@CAPPK");
			strSql.Append(" where pk_ZJB_ZKD=@pk_ZJB_ZKD");
			SqlParameter[] parameters = {
					new SqlParameter("@zkdh", SqlDbType.VarChar,50),
					new SqlParameter("@sck", SqlDbType.VarChar,50),
					new SqlParameter("@tck", SqlDbType.VarChar,50),
					new SqlParameter("@wlh", SqlDbType.VarChar,50),
					new SqlParameter("@wlmc", SqlDbType.VarChar,50),
					new SqlParameter("@pch", SqlDbType.VarChar,50),
					new SqlParameter("@sx", SqlDbType.VarChar,50),
					new SqlParameter("@zldj", SqlDbType.VarChar,50),
					new SqlParameter("@jhsl", SqlDbType.Decimal,9),
					new SqlParameter("@jhzl", SqlDbType.Decimal,9),
					new SqlParameter("@zjldw", SqlDbType.VarChar,50),
					new SqlParameter("@fjldw", SqlDbType.VarChar,50),
					new SqlParameter("@ph", SqlDbType.VarChar,50),
					new SqlParameter("@gg", SqlDbType.VarChar,50),
					new SqlParameter("@vfree0", SqlDbType.VarChar,50),
					new SqlParameter("@vfree1", SqlDbType.VarChar,50),
					new SqlParameter("@vfree2", SqlDbType.VarChar,50),
					new SqlParameter("@vfree3", SqlDbType.VarChar,50),
					new SqlParameter("@vfree4", SqlDbType.VarChar,50),
					new SqlParameter("@ZJBstatus", SqlDbType.Int,4),
					new SqlParameter("@CAPPK", SqlDbType.VarChar,50),
					new SqlParameter("@pk_ZJB_ZKD", SqlDbType.Int,4)};
			parameters[0].Value = model.zkdh;
			parameters[1].Value = model.sck;
			parameters[2].Value = model.tck;
			parameters[3].Value = model.wlh;
			parameters[4].Value = model.wlmc;
			parameters[5].Value = model.pch;
			parameters[6].Value = model.sx;
			parameters[7].Value = model.zldj;
			parameters[8].Value = model.jhsl;
			parameters[9].Value = model.jhzl;
			parameters[10].Value = model.zjldw;
			parameters[11].Value = model.fjldw;
			parameters[12].Value = model.ph;
			parameters[13].Value = model.gg;
			parameters[14].Value = model.vfree0;
			parameters[15].Value = model.vfree1;
			parameters[16].Value = model.vfree2;
			parameters[17].Value = model.vfree3;
			parameters[18].Value = model.vfree4;
			parameters[19].Value = model.ZJBstatus;
			parameters[20].Value = model.CAPPK;
			parameters[21].Value = model.pk_ZJB_ZKD;

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
		public bool Delete(int pk_ZJB_ZKD)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ReZJB_ZKD ");
			strSql.Append(" where pk_ZJB_ZKD=@pk_ZJB_ZKD");
			SqlParameter[] parameters = {
					new SqlParameter("@pk_ZJB_ZKD", SqlDbType.Int,4)
			};
			parameters[0].Value = pk_ZJB_ZKD;

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
		public bool DeleteList(string pk_ZJB_ZKDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ReZJB_ZKD ");
			strSql.Append(" where pk_ZJB_ZKD in ("+pk_ZJB_ZKDlist + ")  ");
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
		public Mod_ReZJB_ZKD GetModel(int pk_ZJB_ZKD)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 zkdh,sck,tck,wlh,wlmc,pch,sx,zldj,jhsl,jhzl,zjldw,fjldw,ph,gg,vfree0,vfree1,vfree2,vfree3,vfree4,pk_ZJB_ZKD,ZJBstatus,CAPPK from ReZJB_ZKD ");
			strSql.Append(" where pk_ZJB_ZKD=@pk_ZJB_ZKD");
			SqlParameter[] parameters = {
					new SqlParameter("@pk_ZJB_ZKD", SqlDbType.Int,4)
			};
			parameters[0].Value = pk_ZJB_ZKD;

			Mod_ReZJB_ZKD model=new Mod_ReZJB_ZKD();
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
		public Mod_ReZJB_ZKD DataRowToModel(DataRow row)
		{
			Mod_ReZJB_ZKD model=new Mod_ReZJB_ZKD();
			if (row != null)
			{
				if(row["zkdh"]!=null)
				{
					model.zkdh=row["zkdh"].ToString();
				}
				if(row["sck"]!=null)
				{
					model.sck=row["sck"].ToString();
				}
				if(row["tck"]!=null)
				{
					model.tck=row["tck"].ToString();
				}
				if(row["wlh"]!=null)
				{
					model.wlh=row["wlh"].ToString();
				}
				if(row["wlmc"]!=null)
				{
					model.wlmc=row["wlmc"].ToString();
				}
				if(row["pch"]!=null)
				{
					model.pch=row["pch"].ToString();
				}
				if(row["sx"]!=null)
				{
					model.sx=row["sx"].ToString();
				}
				if(row["zldj"]!=null)
				{
					model.zldj=row["zldj"].ToString();
				}
				if(row["jhsl"]!=null && row["jhsl"].ToString()!="")
				{
					model.jhsl=decimal.Parse(row["jhsl"].ToString());
				}
				if(row["jhzl"]!=null && row["jhzl"].ToString()!="")
				{
					model.jhzl=decimal.Parse(row["jhzl"].ToString());
				}
				if(row["zjldw"]!=null)
				{
					model.zjldw=row["zjldw"].ToString();
				}
				if(row["fjldw"]!=null)
				{
					model.fjldw=row["fjldw"].ToString();
				}
				if(row["ph"]!=null)
				{
					model.ph=row["ph"].ToString();
				}
				if(row["gg"]!=null)
				{
					model.gg=row["gg"].ToString();
				}
				if(row["vfree0"]!=null)
				{
					model.vfree0=row["vfree0"].ToString();
				}
				if(row["vfree1"]!=null)
				{
					model.vfree1=row["vfree1"].ToString();
				}
				if(row["vfree2"]!=null)
				{
					model.vfree2=row["vfree2"].ToString();
				}
				if(row["vfree3"]!=null)
				{
					model.vfree3=row["vfree3"].ToString();
				}
				if(row["vfree4"]!=null)
				{
					model.vfree4=row["vfree4"].ToString();
				}
				if(row["pk_ZJB_ZKD"]!=null && row["pk_ZJB_ZKD"].ToString()!="")
				{
					model.pk_ZJB_ZKD=int.Parse(row["pk_ZJB_ZKD"].ToString());
				}
				if(row["ZJBstatus"]!=null && row["ZJBstatus"].ToString()!="")
				{
					model.ZJBstatus=int.Parse(row["ZJBstatus"].ToString());
				}
				if(row["CAPPK"]!=null)
				{
					model.CAPPK=row["CAPPK"].ToString();
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
			strSql.Append("select zkdh,sck,tck,wlh,wlmc,pch,sx,zldj,jhsl,jhzl,zjldw,fjldw,ph,gg,vfree0,vfree1,vfree2,vfree3,vfree4,pk_ZJB_ZKD,ZJBstatus,CAPPK ");
			strSql.Append(" FROM ReZJB_ZKD ");
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
			strSql.Append(" zkdh,sck,tck,wlh,wlmc,pch,sx,zldj,jhsl,jhzl,zjldw,fjldw,ph,gg,vfree0,vfree1,vfree2,vfree3,vfree4,pk_ZJB_ZKD,ZJBstatus,CAPPK ");
			strSql.Append(" FROM ReZJB_ZKD ");
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
			strSql.Append("select count(1) FROM ReZJB_ZKD ");
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
			strSql.Append(")AS Row, T.*  from ReZJB_ZKD T ");
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
			parameters[0].Value = "ReZJB_ZKD";
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

