using System;
using System.Data;
using System.Text;
using MODEL;
using System.Data.SqlClient;

namespace IDAL
{
    /// <summary>
    /// 数据访问类:ReZJB_PDD_Item
    /// </summary>
    public partial class Dal_ReZJB_PDD_Item
	{
		public Dal_ReZJB_PDD_Item()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelper_SQL.GetMaxID("pk_ZJB_PDD_Item", "ReZJB_PDD_Item"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int pk_ZJB_PDD_Item)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from ReZJB_PDD_Item");
			strSql.Append(" where pk_ZJB_PDD_Item=@pk_ZJB_PDD_Item");
			SqlParameter[] parameters = {
					new SqlParameter("@pk_ZJB_PDD_Item", SqlDbType.Int,4)
			};
			parameters[0].Value = pk_ZJB_PDD_Item;

			return DbHelper_SQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Mod_ReZJB_PDD_Item model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into ReZJB_PDD_Item(");
			strSql.Append("ysdh,BARCODE,PCH,SX,ZCSL,FZCZL,vfree0,vfree1,vfree2,vfree3,vfree4,ZJBstatus,CAPPK)");
			strSql.Append(" values (");
			strSql.Append("@ysdh,@BARCODE,@PCH,@SX,@ZCSL,@FZCZL,@vfree0,@vfree1,@vfree2,@vfree3,@vfree4,@ZJBstatus,@CAPPK)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@ysdh", SqlDbType.VarChar,50),
					new SqlParameter("@BARCODE", SqlDbType.VarChar,50),
					new SqlParameter("@PCH", SqlDbType.VarChar,50),
					new SqlParameter("@SX", SqlDbType.VarChar,50),
					new SqlParameter("@ZCSL", SqlDbType.Int,4),
					new SqlParameter("@FZCZL", SqlDbType.Decimal,9),
					new SqlParameter("@vfree0", SqlDbType.VarChar,150),
					new SqlParameter("@vfree1", SqlDbType.VarChar,150),
					new SqlParameter("@vfree2", SqlDbType.VarChar,150),
					new SqlParameter("@vfree3", SqlDbType.VarChar,150),
					new SqlParameter("@vfree4", SqlDbType.VarChar,150),
					new SqlParameter("@ZJBstatus", SqlDbType.Int,4),
					new SqlParameter("@CAPPK", SqlDbType.VarChar,50)};
			parameters[0].Value = model.ysdh;
			parameters[1].Value = model.BARCODE;
			parameters[2].Value = model.PCH;
			parameters[3].Value = model.SX;
			parameters[4].Value = model.ZCSL;
			parameters[5].Value = model.FZCZL;
			parameters[6].Value = model.vfree0;
			parameters[7].Value = model.vfree1;
			parameters[8].Value = model.vfree2;
			parameters[9].Value = model.vfree3;
			parameters[10].Value = model.vfree4;
			parameters[11].Value = model.ZJBstatus;
			parameters[12].Value = model.CAPPK;

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
		public bool Update(Mod_ReZJB_PDD_Item model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update ReZJB_PDD_Item set ");
			strSql.Append("ysdh=@ysdh,");
			strSql.Append("BARCODE=@BARCODE,");
			strSql.Append("PCH=@PCH,");
			strSql.Append("SX=@SX,");
			strSql.Append("ZCSL=@ZCSL,");
			strSql.Append("FZCZL=@FZCZL,");
			strSql.Append("vfree0=@vfree0,");
			strSql.Append("vfree1=@vfree1,");
			strSql.Append("vfree2=@vfree2,");
			strSql.Append("vfree3=@vfree3,");
			strSql.Append("vfree4=@vfree4,");
			strSql.Append("ZJBstatus=@ZJBstatus,");
			strSql.Append("CAPPK=@CAPPK");
			strSql.Append(" where pk_ZJB_PDD_Item=@pk_ZJB_PDD_Item");
			SqlParameter[] parameters = {
					new SqlParameter("@ysdh", SqlDbType.VarChar,50),
					new SqlParameter("@BARCODE", SqlDbType.VarChar,50),
					new SqlParameter("@PCH", SqlDbType.VarChar,50),
					new SqlParameter("@SX", SqlDbType.VarChar,50),
					new SqlParameter("@ZCSL", SqlDbType.Int,4),
					new SqlParameter("@FZCZL", SqlDbType.Decimal,9),
					new SqlParameter("@vfree0", SqlDbType.VarChar,150),
					new SqlParameter("@vfree1", SqlDbType.VarChar,150),
					new SqlParameter("@vfree2", SqlDbType.VarChar,150),
					new SqlParameter("@vfree3", SqlDbType.VarChar,150),
					new SqlParameter("@vfree4", SqlDbType.VarChar,150),
					new SqlParameter("@ZJBstatus", SqlDbType.Int,4),
					new SqlParameter("@CAPPK", SqlDbType.VarChar,50),
					new SqlParameter("@pk_ZJB_PDD_Item", SqlDbType.Int,4)};
			parameters[0].Value = model.ysdh;
			parameters[1].Value = model.BARCODE;
			parameters[2].Value = model.PCH;
			parameters[3].Value = model.SX;
			parameters[4].Value = model.ZCSL;
			parameters[5].Value = model.FZCZL;
			parameters[6].Value = model.vfree0;
			parameters[7].Value = model.vfree1;
			parameters[8].Value = model.vfree2;
			parameters[9].Value = model.vfree3;
			parameters[10].Value = model.vfree4;
			parameters[11].Value = model.ZJBstatus;
			parameters[12].Value = model.CAPPK;
			parameters[13].Value = model.pk_ZJB_PDD_Item;

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
		public bool Delete(int pk_ZJB_PDD_Item)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ReZJB_PDD_Item ");
			strSql.Append(" where pk_ZJB_PDD_Item=@pk_ZJB_PDD_Item");
			SqlParameter[] parameters = {
					new SqlParameter("@pk_ZJB_PDD_Item", SqlDbType.Int,4)
			};
			parameters[0].Value = pk_ZJB_PDD_Item;

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
		public bool DeleteList(string pk_ZJB_PDD_Itemlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ReZJB_PDD_Item ");
			strSql.Append(" where pk_ZJB_PDD_Item in ("+pk_ZJB_PDD_Itemlist + ")  ");
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
		public Mod_ReZJB_PDD_Item GetModel(int pk_ZJB_PDD_Item)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ysdh,BARCODE,PCH,SX,ZCSL,FZCZL,vfree0,vfree1,vfree2,vfree3,vfree4,ZJBstatus,CAPPK,pk_ZJB_PDD_Item from ReZJB_PDD_Item ");
			strSql.Append(" where pk_ZJB_PDD_Item=@pk_ZJB_PDD_Item");
			SqlParameter[] parameters = {
					new SqlParameter("@pk_ZJB_PDD_Item", SqlDbType.Int,4)
			};
			parameters[0].Value = pk_ZJB_PDD_Item;

			Mod_ReZJB_PDD_Item model=new Mod_ReZJB_PDD_Item();
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
		public Mod_ReZJB_PDD_Item DataRowToModel(DataRow row)
		{
			Mod_ReZJB_PDD_Item model=new Mod_ReZJB_PDD_Item();
			if (row != null)
			{
				if(row["ysdh"]!=null)
				{
					model.ysdh=row["ysdh"].ToString();
				}
				if(row["BARCODE"]!=null)
				{
					model.BARCODE=row["BARCODE"].ToString();
				}
				if(row["PCH"]!=null)
				{
					model.PCH=row["PCH"].ToString();
				}
				if(row["SX"]!=null)
				{
					model.SX=row["SX"].ToString();
				}
				if(row["ZCSL"]!=null && row["ZCSL"].ToString()!="")
				{
					model.ZCSL=int.Parse(row["ZCSL"].ToString());
				}
				if(row["FZCZL"]!=null && row["FZCZL"].ToString()!="")
				{
					model.FZCZL=decimal.Parse(row["FZCZL"].ToString());
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
				if(row["ZJBstatus"]!=null && row["ZJBstatus"].ToString()!="")
				{
					model.ZJBstatus=int.Parse(row["ZJBstatus"].ToString());
				}
				if(row["CAPPK"]!=null)
				{
					model.CAPPK=row["CAPPK"].ToString();
				}
				if(row["pk_ZJB_PDD_Item"]!=null && row["pk_ZJB_PDD_Item"].ToString()!="")
				{
					model.pk_ZJB_PDD_Item=int.Parse(row["pk_ZJB_PDD_Item"].ToString());
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
			strSql.Append("select ysdh,BARCODE,PCH,SX,ZCSL,FZCZL,vfree0,vfree1,vfree2,vfree3,vfree4,ZJBstatus,CAPPK,pk_ZJB_PDD_Item ");
			strSql.Append(" FROM ReZJB_PDD_Item ");
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
			strSql.Append(" ysdh,BARCODE,PCH,SX,ZCSL,FZCZL,vfree0,vfree1,vfree2,vfree3,vfree4,ZJBstatus,CAPPK,pk_ZJB_PDD_Item ");
			strSql.Append(" FROM ReZJB_PDD_Item ");
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
			strSql.Append("select count(1) FROM ReZJB_PDD_Item ");
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
				strSql.Append("order by T.pk_ZJB_PDD_Item desc");
			}
			strSql.Append(")AS Row, T.*  from ReZJB_PDD_Item T ");
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
			parameters[0].Value = "ReZJB_PDD_Item";
			parameters[1].Value = "pk_ZJB_PDD_Item";
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

