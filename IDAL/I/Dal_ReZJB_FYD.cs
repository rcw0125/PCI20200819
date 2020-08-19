using System;
using System.Data;
using System.Text;
using MODEL;
using System.Data.SqlClient;

namespace IDAL
{
    /// <summary>
    /// 数据访问类:ReZJB_FYD
    /// </summary>
    public partial class Dal_ReZJB_FYD
	{
		public Dal_ReZJB_FYD()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelper_SQL.GetMaxID("pk_ZJB_FYD", "ReZJB_FYD"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int pk_ZJB_FYD)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from ReZJB_FYD");
			strSql.Append(" where pk_ZJB_FYD=@pk_ZJB_FYD");
			SqlParameter[] parameters = {
					new SqlParameter("@pk_ZJB_FYD", SqlDbType.Int,4)
			};
			parameters[0].Value = pk_ZJB_FYD;

			return DbHelper_SQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Mod_ReZJB_FYD model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into ReZJB_FYD(");
			strSql.Append("fydh,ck,khbm,yslb,cph,wlh,wlmc,sx,zldj,jhsl,jhzl,zjldw,fjldw,varrivestation,zdr,zdrq,PH,GG,PCInfo,zyx1,zyx2,zyx3,zyx4,zyx5,ZJBstatus,CAPPK,ywbm,ywry)");
			strSql.Append(" values (");
			strSql.Append("@fydh,@ck,@khbm,@yslb,@cph,@wlh,@wlmc,@sx,@zldj,@jhsl,@jhzl,@zjldw,@fjldw,@varrivestation,@zdr,@zdrq,@PH,@GG,@PCInfo,@zyx1,@zyx2,@zyx3,@zyx4,@zyx5,@ZJBstatus,@CAPPK,@ywbm,@ywry)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@fydh", SqlDbType.VarChar,50),
					new SqlParameter("@ck", SqlDbType.VarChar,50),
					new SqlParameter("@khbm", SqlDbType.VarChar,50),
					new SqlParameter("@yslb", SqlDbType.VarChar,50),
					new SqlParameter("@cph", SqlDbType.VarChar,50),
					new SqlParameter("@wlh", SqlDbType.VarChar,50),
					new SqlParameter("@wlmc", SqlDbType.VarChar,50),
					new SqlParameter("@sx", SqlDbType.VarChar,50),
					new SqlParameter("@zldj", SqlDbType.VarChar,50),
					new SqlParameter("@jhsl", SqlDbType.Decimal,9),
					new SqlParameter("@jhzl", SqlDbType.Decimal,9),
					new SqlParameter("@zjldw", SqlDbType.VarChar,50),
					new SqlParameter("@fjldw", SqlDbType.VarChar,50),
					new SqlParameter("@varrivestation", SqlDbType.VarChar,50),
					new SqlParameter("@zdr", SqlDbType.VarChar,50),
					new SqlParameter("@zdrq", SqlDbType.DateTime),
					new SqlParameter("@PH", SqlDbType.VarChar,50),
					new SqlParameter("@GG", SqlDbType.VarChar,50),
					new SqlParameter("@PCInfo", SqlDbType.VarChar,50),
					new SqlParameter("@zyx1", SqlDbType.VarChar,50),
					new SqlParameter("@zyx2", SqlDbType.VarChar,50),
					new SqlParameter("@zyx3", SqlDbType.VarChar,50),
					new SqlParameter("@zyx4", SqlDbType.VarChar,50),
					new SqlParameter("@zyx5", SqlDbType.VarChar,50),
					new SqlParameter("@ZJBstatus", SqlDbType.Int,4),
					new SqlParameter("@CAPPK", SqlDbType.VarChar,50),
					new SqlParameter("@ywbm", SqlDbType.VarChar,50),
					new SqlParameter("@ywry", SqlDbType.VarChar,50)};
			parameters[0].Value = model.fydh;
			parameters[1].Value = model.ck;
			parameters[2].Value = model.khbm;
			parameters[3].Value = model.yslb;
			parameters[4].Value = model.cph;
			parameters[5].Value = model.wlh;
			parameters[6].Value = model.wlmc;
			parameters[7].Value = model.sx;
			parameters[8].Value = model.zldj;
			parameters[9].Value = model.jhsl;
			parameters[10].Value = model.jhzl;
			parameters[11].Value = model.zjldw;
			parameters[12].Value = model.fjldw;
			parameters[13].Value = model.varrivestation;
			parameters[14].Value = model.zdr;
			parameters[15].Value = model.zdrq;
			parameters[16].Value = model.PH;
			parameters[17].Value = model.GG;
			parameters[18].Value = model.PCInfo;
			parameters[19].Value = model.zyx1;
			parameters[20].Value = model.zyx2;
			parameters[21].Value = model.zyx3;
			parameters[22].Value = model.zyx4;
			parameters[23].Value = model.zyx5;
			parameters[24].Value = model.ZJBstatus;
			parameters[25].Value = model.CAPPK;
			parameters[26].Value = model.ywbm;
			parameters[27].Value = model.ywry;

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
		public bool Update(Mod_ReZJB_FYD model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update ReZJB_FYD set ");
			strSql.Append("fydh=@fydh,");
			strSql.Append("ck=@ck,");
			strSql.Append("khbm=@khbm,");
			strSql.Append("yslb=@yslb,");
			strSql.Append("cph=@cph,");
			strSql.Append("wlh=@wlh,");
			strSql.Append("wlmc=@wlmc,");
			strSql.Append("sx=@sx,");
			strSql.Append("zldj=@zldj,");
			strSql.Append("jhsl=@jhsl,");
			strSql.Append("jhzl=@jhzl,");
			strSql.Append("zjldw=@zjldw,");
			strSql.Append("fjldw=@fjldw,");
			strSql.Append("varrivestation=@varrivestation,");
			strSql.Append("zdr=@zdr,");
			strSql.Append("zdrq=@zdrq,");
			strSql.Append("PH=@PH,");
			strSql.Append("GG=@GG,");
			strSql.Append("PCInfo=@PCInfo,");
			strSql.Append("zyx1=@zyx1,");
			strSql.Append("zyx2=@zyx2,");
			strSql.Append("zyx3=@zyx3,");
			strSql.Append("zyx4=@zyx4,");
			strSql.Append("zyx5=@zyx5,");
			strSql.Append("ZJBstatus=@ZJBstatus,");
			strSql.Append("CAPPK=@CAPPK,");
			strSql.Append("ywbm=@ywbm,");
			strSql.Append("ywry=@ywry");
			strSql.Append(" where pk_ZJB_FYD=@pk_ZJB_FYD");
			SqlParameter[] parameters = {
					new SqlParameter("@fydh", SqlDbType.VarChar,50),
					new SqlParameter("@ck", SqlDbType.VarChar,50),
					new SqlParameter("@khbm", SqlDbType.VarChar,50),
					new SqlParameter("@yslb", SqlDbType.VarChar,50),
					new SqlParameter("@cph", SqlDbType.VarChar,50),
					new SqlParameter("@wlh", SqlDbType.VarChar,50),
					new SqlParameter("@wlmc", SqlDbType.VarChar,50),
					new SqlParameter("@sx", SqlDbType.VarChar,50),
					new SqlParameter("@zldj", SqlDbType.VarChar,50),
					new SqlParameter("@jhsl", SqlDbType.Decimal,9),
					new SqlParameter("@jhzl", SqlDbType.Decimal,9),
					new SqlParameter("@zjldw", SqlDbType.VarChar,50),
					new SqlParameter("@fjldw", SqlDbType.VarChar,50),
					new SqlParameter("@varrivestation", SqlDbType.VarChar,50),
					new SqlParameter("@zdr", SqlDbType.VarChar,50),
					new SqlParameter("@zdrq", SqlDbType.DateTime),
					new SqlParameter("@PH", SqlDbType.VarChar,50),
					new SqlParameter("@GG", SqlDbType.VarChar,50),
					new SqlParameter("@PCInfo", SqlDbType.VarChar,50),
					new SqlParameter("@zyx1", SqlDbType.VarChar,50),
					new SqlParameter("@zyx2", SqlDbType.VarChar,50),
					new SqlParameter("@zyx3", SqlDbType.VarChar,50),
					new SqlParameter("@zyx4", SqlDbType.VarChar,50),
					new SqlParameter("@zyx5", SqlDbType.VarChar,50),
					new SqlParameter("@ZJBstatus", SqlDbType.Int,4),
					new SqlParameter("@CAPPK", SqlDbType.VarChar,50),
					new SqlParameter("@ywbm", SqlDbType.VarChar,50),
					new SqlParameter("@ywry", SqlDbType.VarChar,50),
					new SqlParameter("@pk_ZJB_FYD", SqlDbType.Int,4)};
			parameters[0].Value = model.fydh;
			parameters[1].Value = model.ck;
			parameters[2].Value = model.khbm;
			parameters[3].Value = model.yslb;
			parameters[4].Value = model.cph;
			parameters[5].Value = model.wlh;
			parameters[6].Value = model.wlmc;
			parameters[7].Value = model.sx;
			parameters[8].Value = model.zldj;
			parameters[9].Value = model.jhsl;
			parameters[10].Value = model.jhzl;
			parameters[11].Value = model.zjldw;
			parameters[12].Value = model.fjldw;
			parameters[13].Value = model.varrivestation;
			parameters[14].Value = model.zdr;
			parameters[15].Value = model.zdrq;
			parameters[16].Value = model.PH;
			parameters[17].Value = model.GG;
			parameters[18].Value = model.PCInfo;
			parameters[19].Value = model.zyx1;
			parameters[20].Value = model.zyx2;
			parameters[21].Value = model.zyx3;
			parameters[22].Value = model.zyx4;
			parameters[23].Value = model.zyx5;
			parameters[24].Value = model.ZJBstatus;
			parameters[25].Value = model.CAPPK;
			parameters[26].Value = model.ywbm;
			parameters[27].Value = model.ywry;
			parameters[28].Value = model.pk_ZJB_FYD;

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
		public bool Delete(int pk_ZJB_FYD)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ReZJB_FYD ");
			strSql.Append(" where pk_ZJB_FYD=@pk_ZJB_FYD");
			SqlParameter[] parameters = {
					new SqlParameter("@pk_ZJB_FYD", SqlDbType.Int,4)
			};
			parameters[0].Value = pk_ZJB_FYD;

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
		public bool DeleteList(string pk_ZJB_FYDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ReZJB_FYD ");
			strSql.Append(" where pk_ZJB_FYD in ("+pk_ZJB_FYDlist + ")  ");
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
		public Mod_ReZJB_FYD GetModel(int pk_ZJB_FYD)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 fydh,ck,khbm,yslb,cph,wlh,wlmc,sx,zldj,jhsl,jhzl,zjldw,fjldw,varrivestation,zdr,zdrq,PH,GG,PCInfo,zyx1,zyx2,zyx3,zyx4,zyx5,pk_ZJB_FYD,ZJBstatus,CAPPK,ywbm,ywry from ReZJB_FYD ");
			strSql.Append(" where pk_ZJB_FYD=@pk_ZJB_FYD");
			SqlParameter[] parameters = {
					new SqlParameter("@pk_ZJB_FYD", SqlDbType.Int,4)
			};
			parameters[0].Value = pk_ZJB_FYD;

			Mod_ReZJB_FYD model=new Mod_ReZJB_FYD();
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
		public Mod_ReZJB_FYD DataRowToModel(DataRow row)
		{
			Mod_ReZJB_FYD model=new Mod_ReZJB_FYD();
			if (row != null)
			{
				if(row["fydh"]!=null)
				{
					model.fydh=row["fydh"].ToString();
				}
				if(row["ck"]!=null)
				{
					model.ck=row["ck"].ToString();
				}
				if(row["khbm"]!=null)
				{
					model.khbm=row["khbm"].ToString();
				}
				if(row["yslb"]!=null)
				{
					model.yslb=row["yslb"].ToString();
				}
				if(row["cph"]!=null)
				{
					model.cph=row["cph"].ToString();
				}
				if(row["wlh"]!=null)
				{
					model.wlh=row["wlh"].ToString();
				}
				if(row["wlmc"]!=null)
				{
					model.wlmc=row["wlmc"].ToString();
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
				if(row["varrivestation"]!=null)
				{
					model.varrivestation=row["varrivestation"].ToString();
				}
				if(row["zdr"]!=null)
				{
					model.zdr=row["zdr"].ToString();
				}
				if(row["zdrq"]!=null && row["zdrq"].ToString()!="")
				{
					model.zdrq=DateTime.Parse(row["zdrq"].ToString());
				}
				if(row["PH"]!=null)
				{
					model.PH=row["PH"].ToString();
				}
				if(row["GG"]!=null)
				{
					model.GG=row["GG"].ToString();
				}
				if(row["PCInfo"]!=null)
				{
					model.PCInfo=row["PCInfo"].ToString();
				}
				if(row["zyx1"]!=null)
				{
					model.zyx1=row["zyx1"].ToString();
				}
				if(row["zyx2"]!=null)
				{
					model.zyx2=row["zyx2"].ToString();
				}
				if(row["zyx3"]!=null)
				{
					model.zyx3=row["zyx3"].ToString();
				}
				if(row["zyx4"]!=null)
				{
					model.zyx4=row["zyx4"].ToString();
				}
				if(row["zyx5"]!=null)
				{
					model.zyx5=row["zyx5"].ToString();
				}
				if(row["pk_ZJB_FYD"]!=null && row["pk_ZJB_FYD"].ToString()!="")
				{
					model.pk_ZJB_FYD=int.Parse(row["pk_ZJB_FYD"].ToString());
				}
				if(row["ZJBstatus"]!=null && row["ZJBstatus"].ToString()!="")
				{
					model.ZJBstatus=int.Parse(row["ZJBstatus"].ToString());
				}
				if(row["CAPPK"]!=null)
				{
					model.CAPPK=row["CAPPK"].ToString();
				}
				if(row["ywbm"]!=null)
				{
					model.ywbm=row["ywbm"].ToString();
				}
				if(row["ywry"]!=null)
				{
					model.ywry=row["ywry"].ToString();
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
			strSql.Append("select fydh,ck,khbm,yslb,cph,wlh,wlmc,sx,zldj,jhsl,jhzl,zjldw,fjldw,varrivestation,zdr,zdrq,PH,GG,PCInfo,zyx1,zyx2,zyx3,zyx4,zyx5,pk_ZJB_FYD,ZJBstatus,CAPPK,ywbm,ywry ");
			strSql.Append(" FROM ReZJB_FYD ");
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
			strSql.Append(" fydh,ck,khbm,yslb,cph,wlh,wlmc,sx,zldj,jhsl,jhzl,zjldw,fjldw,varrivestation,zdr,zdrq,PH,GG,PCInfo,zyx1,zyx2,zyx3,zyx4,zyx5,pk_ZJB_FYD,ZJBstatus,CAPPK,ywbm,ywry ");
			strSql.Append(" FROM ReZJB_FYD ");
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
			strSql.Append("select count(1) FROM ReZJB_FYD ");
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
				strSql.Append("order by T.pk_ZJB_FYD desc");
			}
			strSql.Append(")AS Row, T.*  from ReZJB_FYD T ");
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
			parameters[0].Value = "ReZJB_FYD";
			parameters[1].Value = "pk_ZJB_FYD";
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

