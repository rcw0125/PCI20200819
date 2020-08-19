using System;
using System.Data;
using System.Text;
using MODEL;
using System.Data.SqlClient;

namespace IDAL
{
    /// <summary>
    /// 数据访问类:ReZJB_WGD
    /// </summary>
    public partial class Dal_ReZJB_WGD
	{
		public Dal_ReZJB_WGD()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelper_SQL.GetMaxID("pk_ZJB_WGD", "ReZJB_WGD"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int pk_ZJB_WGD)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from ReZJB_WGD");
			strSql.Append(" where pk_ZJB_WGD=@pk_ZJB_WGD");
			SqlParameter[] parameters = {
					new SqlParameter("@pk_ZJB_WGD", SqlDbType.Int,4)
			};
			parameters[0].Value = pk_ZJB_WGD;

			return DbHelper_SQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Mod_ReZJB_WGD model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into ReZJB_WGD(");
			strSql.Append("wgdh,pch,ph,gg,bb,wlh,wlmc,fzdw,zxbz,zldj,SCX,pcinfo,zyx1,zyx2,zyx3,zyx4,zyx5,gpmainmeasrate,ZJBstatus,CAPPK)");
			strSql.Append(" values (");
			strSql.Append("@wgdh,@pch,@ph,@gg,@bb,@wlh,@wlmc,@fzdw,@zxbz,@zldj,@SCX,@pcinfo,@zyx1,@zyx2,@zyx3,@zyx4,@zyx5,@gpmainmeasrate,@ZJBstatus,@CAPPK)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@wgdh", SqlDbType.VarChar,50),
					new SqlParameter("@pch", SqlDbType.VarChar,50),
					new SqlParameter("@ph", SqlDbType.VarChar,50),
					new SqlParameter("@gg", SqlDbType.VarChar,50),
					new SqlParameter("@bb", SqlDbType.VarChar,50),
					new SqlParameter("@wlh", SqlDbType.VarChar,50),
					new SqlParameter("@wlmc", SqlDbType.VarChar,50),
					new SqlParameter("@fzdw", SqlDbType.VarChar,50),
					new SqlParameter("@zxbz", SqlDbType.VarChar,50),
					new SqlParameter("@zldj", SqlDbType.VarChar,50),
					new SqlParameter("@SCX", SqlDbType.VarChar,50),
					new SqlParameter("@pcinfo", SqlDbType.VarChar,150),
					new SqlParameter("@zyx1", SqlDbType.VarChar,150),
					new SqlParameter("@zyx2", SqlDbType.VarChar,150),
					new SqlParameter("@zyx3", SqlDbType.VarChar,150),
					new SqlParameter("@zyx4", SqlDbType.VarChar,150),
					new SqlParameter("@zyx5", SqlDbType.VarChar,150),
					new SqlParameter("@gpmainmeasrate", SqlDbType.Decimal,9),
					new SqlParameter("@ZJBstatus", SqlDbType.Int,4),
					new SqlParameter("@CAPPK", SqlDbType.VarChar,50)};
			parameters[0].Value = model.wgdh;
			parameters[1].Value = model.pch;
			parameters[2].Value = model.ph;
			parameters[3].Value = model.gg;
			parameters[4].Value = model.bb;
			parameters[5].Value = model.wlh;
			parameters[6].Value = model.wlmc;
			parameters[7].Value = model.fzdw;
			parameters[8].Value = model.zxbz;
			parameters[9].Value = model.zldj;
			parameters[10].Value = model.SCX;
			parameters[11].Value = model.pcinfo;
			parameters[12].Value = model.zyx1;
			parameters[13].Value = model.zyx2;
			parameters[14].Value = model.zyx3;
			parameters[15].Value = model.zyx4;
			parameters[16].Value = model.zyx5;
			parameters[17].Value = model.gpmainmeasrate;
			parameters[18].Value = model.ZJBstatus;
			parameters[19].Value = model.CAPPK;

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
		public bool Update(Mod_ReZJB_WGD model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update ReZJB_WGD set ");
			strSql.Append("wgdh=@wgdh,");
			strSql.Append("pch=@pch,");
			strSql.Append("ph=@ph,");
			strSql.Append("gg=@gg,");
			strSql.Append("bb=@bb,");
			strSql.Append("wlh=@wlh,");
			strSql.Append("wlmc=@wlmc,");
			strSql.Append("fzdw=@fzdw,");
			strSql.Append("zxbz=@zxbz,");
			strSql.Append("zldj=@zldj,");
			strSql.Append("SCX=@SCX,");
			strSql.Append("pcinfo=@pcinfo,");
			strSql.Append("zyx1=@zyx1,");
			strSql.Append("zyx2=@zyx2,");
			strSql.Append("zyx3=@zyx3,");
			strSql.Append("zyx4=@zyx4,");
			strSql.Append("zyx5=@zyx5,");
			strSql.Append("gpmainmeasrate=@gpmainmeasrate,");
			strSql.Append("ZJBstatus=@ZJBstatus,");
			strSql.Append("CAPPK=@CAPPK");
			strSql.Append(" where pk_ZJB_WGD=@pk_ZJB_WGD");
			SqlParameter[] parameters = {
					new SqlParameter("@wgdh", SqlDbType.VarChar,50),
					new SqlParameter("@pch", SqlDbType.VarChar,50),
					new SqlParameter("@ph", SqlDbType.VarChar,50),
					new SqlParameter("@gg", SqlDbType.VarChar,50),
					new SqlParameter("@bb", SqlDbType.VarChar,50),
					new SqlParameter("@wlh", SqlDbType.VarChar,50),
					new SqlParameter("@wlmc", SqlDbType.VarChar,50),
					new SqlParameter("@fzdw", SqlDbType.VarChar,50),
					new SqlParameter("@zxbz", SqlDbType.VarChar,50),
					new SqlParameter("@zldj", SqlDbType.VarChar,50),
					new SqlParameter("@SCX", SqlDbType.VarChar,50),
					new SqlParameter("@pcinfo", SqlDbType.VarChar,150),
					new SqlParameter("@zyx1", SqlDbType.VarChar,150),
					new SqlParameter("@zyx2", SqlDbType.VarChar,150),
					new SqlParameter("@zyx3", SqlDbType.VarChar,150),
					new SqlParameter("@zyx4", SqlDbType.VarChar,150),
					new SqlParameter("@zyx5", SqlDbType.VarChar,150),
					new SqlParameter("@gpmainmeasrate", SqlDbType.Decimal,9),
					new SqlParameter("@ZJBstatus", SqlDbType.Int,4),
					new SqlParameter("@CAPPK", SqlDbType.VarChar,50),
					new SqlParameter("@pk_ZJB_WGD", SqlDbType.Int,4)};
			parameters[0].Value = model.wgdh;
			parameters[1].Value = model.pch;
			parameters[2].Value = model.ph;
			parameters[3].Value = model.gg;
			parameters[4].Value = model.bb;
			parameters[5].Value = model.wlh;
			parameters[6].Value = model.wlmc;
			parameters[7].Value = model.fzdw;
			parameters[8].Value = model.zxbz;
			parameters[9].Value = model.zldj;
			parameters[10].Value = model.SCX;
			parameters[11].Value = model.pcinfo;
			parameters[12].Value = model.zyx1;
			parameters[13].Value = model.zyx2;
			parameters[14].Value = model.zyx3;
			parameters[15].Value = model.zyx4;
			parameters[16].Value = model.zyx5;
			parameters[17].Value = model.gpmainmeasrate;
			parameters[18].Value = model.ZJBstatus;
			parameters[19].Value = model.CAPPK;
			parameters[20].Value = model.pk_ZJB_WGD;

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
		public bool Delete(int pk_ZJB_WGD)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ReZJB_WGD ");
			strSql.Append(" where pk_ZJB_WGD=@pk_ZJB_WGD");
			SqlParameter[] parameters = {
					new SqlParameter("@pk_ZJB_WGD", SqlDbType.Int,4)
			};
			parameters[0].Value = pk_ZJB_WGD;

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
		public bool DeleteList(string pk_ZJB_WGDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ReZJB_WGD ");
			strSql.Append(" where pk_ZJB_WGD in ("+pk_ZJB_WGDlist + ")  ");
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
		public Mod_ReZJB_WGD GetModel(int pk_ZJB_WGD)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 wgdh,pch,ph,gg,bb,wlh,wlmc,fzdw,zxbz,zldj,SCX,pcinfo,zyx1,zyx2,zyx3,zyx4,zyx5,gpmainmeasrate,pk_ZJB_WGD,ZJBstatus,CAPPK from ReZJB_WGD ");
			strSql.Append(" where pk_ZJB_WGD=@pk_ZJB_WGD");
			SqlParameter[] parameters = {
					new SqlParameter("@pk_ZJB_WGD", SqlDbType.Int,4)
			};
			parameters[0].Value = pk_ZJB_WGD;

			Mod_ReZJB_WGD model=new Mod_ReZJB_WGD();
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
		public Mod_ReZJB_WGD DataRowToModel(DataRow row)
		{
			Mod_ReZJB_WGD model=new Mod_ReZJB_WGD();
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
				if(row["ph"]!=null)
				{
					model.ph=row["ph"].ToString();
				}
				if(row["gg"]!=null)
				{
					model.gg=row["gg"].ToString();
				}
				if(row["bb"]!=null)
				{
					model.bb=row["bb"].ToString();
				}
				if(row["wlh"]!=null)
				{
					model.wlh=row["wlh"].ToString();
				}
				if(row["wlmc"]!=null)
				{
					model.wlmc=row["wlmc"].ToString();
				}
				if(row["fzdw"]!=null)
				{
					model.fzdw=row["fzdw"].ToString();
				}
				if(row["zxbz"]!=null)
				{
					model.zxbz=row["zxbz"].ToString();
				}
				if(row["zldj"]!=null)
				{
					model.zldj=row["zldj"].ToString();
				}
				if(row["SCX"]!=null)
				{
					model.SCX=row["SCX"].ToString();
				}
				if(row["pcinfo"]!=null)
				{
					model.pcinfo=row["pcinfo"].ToString();
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
				if(row["gpmainmeasrate"]!=null && row["gpmainmeasrate"].ToString()!="")
				{
					model.gpmainmeasrate=decimal.Parse(row["gpmainmeasrate"].ToString());
				}
				if(row["pk_ZJB_WGD"]!=null && row["pk_ZJB_WGD"].ToString()!="")
				{
					model.pk_ZJB_WGD=int.Parse(row["pk_ZJB_WGD"].ToString());
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
			strSql.Append("select wgdh,pch,ph,gg,bb,wlh,wlmc,fzdw,zxbz,zldj,SCX,pcinfo,zyx1,zyx2,zyx3,zyx4,zyx5,gpmainmeasrate,pk_ZJB_WGD,ZJBstatus,CAPPK ");
			strSql.Append(" FROM ReZJB_WGD ");
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
			strSql.Append(" wgdh,pch,ph,gg,bb,wlh,wlmc,fzdw,zxbz,zldj,SCX,pcinfo,zyx1,zyx2,zyx3,zyx4,zyx5,gpmainmeasrate,pk_ZJB_WGD,ZJBstatus,CAPPK ");
			strSql.Append(" FROM ReZJB_WGD ");
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
			strSql.Append("select count(1) FROM ReZJB_WGD ");
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
				strSql.Append("order by T.pk_ZJB_WGD desc");
			}
			strSql.Append(")AS Row, T.*  from ReZJB_WGD T ");
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
			parameters[0].Value = "ReZJB_WGD";
			parameters[1].Value = "pk_ZJB_WGD";
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

