using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;
using System.Data.SqlClient;

namespace IDAL
{
	/// <summary>
	/// 数据访问类:WMS_Bms_Tra_ZKD_Detail
	/// </summary>
	public partial class Dal_WMS_Bms_Tra_ZKD_Detail
    {
		public Dal_WMS_Bms_Tra_ZKD_Detail()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string ZKDH,string CPH,string Barcode,string PCH,string SX)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from WMS_Bms_Tra_ZKD_Detail");
			strSql.Append(" where ZKDH=:ZKDH and CPH=:CPH and Barcode=:Barcode and PCH=:PCH and SX=:SX ");
			SqlParameter[] parameters = {
					new SqlParameter(":ZKDH", SqlDbType.VarChar,50),
					new SqlParameter(":CPH", SqlDbType.VarChar,30),
					new SqlParameter(":Barcode", SqlDbType.VarChar,20),
					new SqlParameter(":PCH", SqlDbType.VarChar,20),
					new SqlParameter(":SX", SqlDbType.VarChar,30)			};
			parameters[0].Value = ZKDH;
			parameters[1].Value = CPH;
			parameters[2].Value = Barcode;
			parameters[3].Value = PCH;
			parameters[4].Value = SX;

			return DbHelper_SQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Mod_WMS_Bms_Tra_ZKD_Detail model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into WMS_Bms_Tra_ZKD_Detail(");
			strSql.Append("ZKDH,CPH,Barcode,WLH,WLMC,PH,GG,PCH,SX,CK,HW,ZL,CKOperator,CKTime,YKOperator,YKTime,YRKDH,YRKTime,YRKOperator,YRKType,vfree0,vfree1,vfree2,vfree3,vfree4)");
			strSql.Append(" values (");
			strSql.Append(":ZKDH,:CPH,:Barcode,:WLH,:WLMC,:PH,:GG,:PCH,:SX,:CK,:HW,:ZL,:CKOperator,:CKTime,:YKOperator,:YKTime,:YRKDH,:YRKTime,:YRKOperator,:YRKType,:vfree0,:vfree1,:vfree2,:vfree3,:vfree4)");
			SqlParameter[] parameters = {
					new SqlParameter(":ZKDH", SqlDbType.VarChar,50),
					new SqlParameter(":CPH", SqlDbType.VarChar,30),
					new SqlParameter(":Barcode", SqlDbType.VarChar,20),
					new SqlParameter(":WLH", SqlDbType.VarChar,30),
					new SqlParameter(":WLMC", SqlDbType.VarChar,100),
					new SqlParameter(":PH", SqlDbType.VarChar,30),
					new SqlParameter(":GG", SqlDbType.VarChar,30),
					new SqlParameter(":PCH", SqlDbType.VarChar,20),
					new SqlParameter(":SX", SqlDbType.VarChar,30),
					new SqlParameter(":CK", SqlDbType.VarChar,30),
					new SqlParameter(":HW", SqlDbType.VarChar,20),
					new SqlParameter(":ZL", SqlDbType.Decimal,9),
					new SqlParameter(":CKOperator", SqlDbType.VarChar,20),
					new SqlParameter(":CKTime", SqlDbType.DateTime),
					new SqlParameter(":YKOperator", SqlDbType.VarChar,20),
					new SqlParameter(":YKTime", SqlDbType.DateTime),
					new SqlParameter(":YRKDH", SqlDbType.VarChar,50),
					new SqlParameter(":YRKTime", SqlDbType.DateTime),
					new SqlParameter(":YRKOperator", SqlDbType.VarChar,20),
					new SqlParameter(":YRKType", SqlDbType.VarChar,10),
					new SqlParameter(":vfree0", SqlDbType.VarChar,50),
					new SqlParameter(":vfree1", SqlDbType.VarChar,50),
					new SqlParameter(":vfree2", SqlDbType.VarChar,50),
					new SqlParameter(":vfree3", SqlDbType.VarChar,50),
					new SqlParameter(":vfree4", SqlDbType.VarChar,50)};
			parameters[0].Value = model.ZKDH;
			parameters[1].Value = model.CPH;
			parameters[2].Value = model.Barcode;
			parameters[3].Value = model.WLH;
			parameters[4].Value = model.WLMC;
			parameters[5].Value = model.PH;
			parameters[6].Value = model.GG;
			parameters[7].Value = model.PCH;
			parameters[8].Value = model.SX;
			parameters[9].Value = model.CK;
			parameters[10].Value = model.HW;
			parameters[11].Value = model.ZL;
			parameters[12].Value = model.CKOperator;
			parameters[13].Value = model.CKTime;
			parameters[14].Value = model.YKOperator;
			parameters[15].Value = model.YKTime;
			parameters[16].Value = model.YRKDH;
			parameters[17].Value = model.YRKTime;
			parameters[18].Value = model.YRKOperator;
			parameters[19].Value = model.YRKType;
			parameters[20].Value = model.vfree0;
			parameters[21].Value = model.vfree1;
			parameters[22].Value = model.vfree2;
			parameters[23].Value = model.vfree3;
			parameters[24].Value = model.vfree4;

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
		public bool Update(Mod_WMS_Bms_Tra_ZKD_Detail model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update WMS_Bms_Tra_ZKD_Detail set ");
			strSql.Append("WLH=:WLH,");
			strSql.Append("WLMC=:WLMC,");
			strSql.Append("PH=:PH,");
			strSql.Append("GG=:GG,");
			strSql.Append("CK=:CK,");
			strSql.Append("HW=:HW,");
			strSql.Append("ZL=:ZL,");
			strSql.Append("CKOperator=:CKOperator,");
			strSql.Append("CKTime=:CKTime,");
			strSql.Append("YKOperator=:YKOperator,");
			strSql.Append("YKTime=:YKTime,");
			strSql.Append("YRKDH=:YRKDH,");
			strSql.Append("YRKTime=:YRKTime,");
			strSql.Append("YRKOperator=:YRKOperator,");
			strSql.Append("YRKType=:YRKType,");
			strSql.Append("vfree0=:vfree0,");
			strSql.Append("vfree1=:vfree1,");
			strSql.Append("vfree2=:vfree2,");
			strSql.Append("vfree3=:vfree3,");
			strSql.Append("vfree4=:vfree4");
			strSql.Append(" where ZKDH=:ZKDH and CPH=:CPH and Barcode=:Barcode and PCH=:PCH and SX=:SX ");
			SqlParameter[] parameters = {
					new SqlParameter(":WLH", SqlDbType.VarChar,30),
					new SqlParameter(":WLMC", SqlDbType.VarChar,100),
					new SqlParameter(":PH", SqlDbType.VarChar,30),
					new SqlParameter(":GG", SqlDbType.VarChar,30),
					new SqlParameter(":CK", SqlDbType.VarChar,30),
					new SqlParameter(":HW", SqlDbType.VarChar,20),
					new SqlParameter(":ZL", SqlDbType.Decimal,9),
					new SqlParameter(":CKOperator", SqlDbType.VarChar,20),
					new SqlParameter(":CKTime", SqlDbType.DateTime),
					new SqlParameter(":YKOperator", SqlDbType.VarChar,20),
					new SqlParameter(":YKTime", SqlDbType.DateTime),
					new SqlParameter(":YRKDH", SqlDbType.VarChar,50),
					new SqlParameter(":YRKTime", SqlDbType.DateTime),
					new SqlParameter(":YRKOperator", SqlDbType.VarChar,20),
					new SqlParameter(":YRKType", SqlDbType.VarChar,10),
					new SqlParameter(":vfree0", SqlDbType.VarChar,50),
					new SqlParameter(":vfree1", SqlDbType.VarChar,50),
					new SqlParameter(":vfree2", SqlDbType.VarChar,50),
					new SqlParameter(":vfree3", SqlDbType.VarChar,50),
					new SqlParameter(":vfree4", SqlDbType.VarChar,50),
					new SqlParameter(":ZKDH", SqlDbType.VarChar,50),
					new SqlParameter(":CPH", SqlDbType.VarChar,30),
					new SqlParameter(":Barcode", SqlDbType.VarChar,20),
					new SqlParameter(":PCH", SqlDbType.VarChar,20),
					new SqlParameter(":SX", SqlDbType.VarChar,30)};
			parameters[0].Value = model.WLH;
			parameters[1].Value = model.WLMC;
			parameters[2].Value = model.PH;
			parameters[3].Value = model.GG;
			parameters[4].Value = model.CK;
			parameters[5].Value = model.HW;
			parameters[6].Value = model.ZL;
			parameters[7].Value = model.CKOperator;
			parameters[8].Value = model.CKTime;
			parameters[9].Value = model.YKOperator;
			parameters[10].Value = model.YKTime;
			parameters[11].Value = model.YRKDH;
			parameters[12].Value = model.YRKTime;
			parameters[13].Value = model.YRKOperator;
			parameters[14].Value = model.YRKType;
			parameters[15].Value = model.vfree0;
			parameters[16].Value = model.vfree1;
			parameters[17].Value = model.vfree2;
			parameters[18].Value = model.vfree3;
			parameters[19].Value = model.vfree4;
			parameters[20].Value = model.ZKDH;
			parameters[21].Value = model.CPH;
			parameters[22].Value = model.Barcode;
			parameters[23].Value = model.PCH;
			parameters[24].Value = model.SX;

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
		public bool Delete(string ZKDH,string CPH,string Barcode,string PCH,string SX)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from WMS_Bms_Tra_ZKD_Detail ");
			strSql.Append(" where ZKDH=:ZKDH and CPH=:CPH and Barcode=:Barcode and PCH=:PCH and SX=:SX ");
			SqlParameter[] parameters = {
					new SqlParameter(":ZKDH", SqlDbType.VarChar,50),
					new SqlParameter(":CPH", SqlDbType.VarChar,30),
					new SqlParameter(":Barcode", SqlDbType.VarChar,20),
					new SqlParameter(":PCH", SqlDbType.VarChar,20),
					new SqlParameter(":SX", SqlDbType.VarChar,30)			};
			parameters[0].Value = ZKDH;
			parameters[1].Value = CPH;
			parameters[2].Value = Barcode;
			parameters[3].Value = PCH;
			parameters[4].Value = SX;

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
		public Mod_WMS_Bms_Tra_ZKD_Detail GetModel(string ZKDH,string CPH,string Barcode,string PCH,string SX)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ZKDH,CPH,Barcode,WLH,WLMC,PH,GG,PCH,SX,CK,HW,ZL,CKOperator,CKTime,YKOperator,YKTime,YRKDH,YRKTime,YRKOperator,YRKType,vfree0,vfree1,vfree2,vfree3,vfree4 from WMS_Bms_Tra_ZKD_Detail ");
			strSql.Append(" where ZKDH=:ZKDH and CPH=:CPH and Barcode=:Barcode and PCH=:PCH and SX=:SX ");
			SqlParameter[] parameters = {
					new SqlParameter(":ZKDH", SqlDbType.VarChar,50),
					new SqlParameter(":CPH", SqlDbType.VarChar,30),
					new SqlParameter(":Barcode", SqlDbType.VarChar,20),
					new SqlParameter(":PCH", SqlDbType.VarChar,20),
					new SqlParameter(":SX", SqlDbType.VarChar,30)			};
			parameters[0].Value = ZKDH;
			parameters[1].Value = CPH;
			parameters[2].Value = Barcode;
			parameters[3].Value = PCH;
			parameters[4].Value = SX;

			Mod_WMS_Bms_Tra_ZKD_Detail model=new Mod_WMS_Bms_Tra_ZKD_Detail();
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
		public Mod_WMS_Bms_Tra_ZKD_Detail DataRowToModel(DataRow row)
		{
			Mod_WMS_Bms_Tra_ZKD_Detail model=new Mod_WMS_Bms_Tra_ZKD_Detail();
			if (row != null)
			{
				if(row["ZKDH"]!=null)
				{
					model.ZKDH=row["ZKDH"].ToString();
				}
				if(row["CPH"]!=null)
				{
					model.CPH=row["CPH"].ToString();
				}
				if(row["Barcode"]!=null)
				{
					model.Barcode=row["Barcode"].ToString();
				}
				if(row["WLH"]!=null)
				{
					model.WLH=row["WLH"].ToString();
				}
				if(row["WLMC"]!=null)
				{
					model.WLMC=row["WLMC"].ToString();
				}
				if(row["PH"]!=null)
				{
					model.PH=row["PH"].ToString();
				}
				if(row["GG"]!=null)
				{
					model.GG=row["GG"].ToString();
				}
				if(row["PCH"]!=null)
				{
					model.PCH=row["PCH"].ToString();
				}
				if(row["SX"]!=null)
				{
					model.SX=row["SX"].ToString();
				}
				if(row["CK"]!=null)
				{
					model.CK=row["CK"].ToString();
				}
				if(row["HW"]!=null)
				{
					model.HW=row["HW"].ToString();
				}
				if(row["ZL"]!=null && row["ZL"].ToString()!="")
				{
					model.ZL=decimal.Parse(row["ZL"].ToString());
				}
				if(row["CKOperator"]!=null)
				{
					model.CKOperator=row["CKOperator"].ToString();
				}
				if(row["CKTime"]!=null && row["CKTime"].ToString()!="")
				{
					model.CKTime=DateTime.Parse(row["CKTime"].ToString());
				}
				if(row["YKOperator"]!=null)
				{
					model.YKOperator=row["YKOperator"].ToString();
				}
				if(row["YKTime"]!=null && row["YKTime"].ToString()!="")
				{
					model.YKTime=DateTime.Parse(row["YKTime"].ToString());
				}
				if(row["YRKDH"]!=null)
				{
					model.YRKDH=row["YRKDH"].ToString();
				}
				if(row["YRKTime"]!=null && row["YRKTime"].ToString()!="")
				{
					model.YRKTime=DateTime.Parse(row["YRKTime"].ToString());
				}
				if(row["YRKOperator"]!=null)
				{
					model.YRKOperator=row["YRKOperator"].ToString();
				}
				if(row["YRKType"]!=null)
				{
					model.YRKType=row["YRKType"].ToString();
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
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ZKDH,CPH,Barcode,WLH,WLMC,PH,GG,PCH,SX,CK,HW,ZL,CKOperator,CKTime,YKOperator,YKTime,YRKDH,YRKTime,YRKOperator,YRKType,vfree0,vfree1,vfree2,vfree3,vfree4 ");
			strSql.Append(" FROM WMS_Bms_Tra_ZKD_Detail ");
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
			strSql.Append(" ZKDH,CPH,Barcode,WLH,WLMC,PH,GG,PCH,SX,CK,HW,ZL,CKOperator,CKTime,YKOperator,YKTime,YRKDH,YRKTime,YRKOperator,YRKType,vfree0,vfree1,vfree2,vfree3,vfree4 ");
			strSql.Append(" FROM WMS_Bms_Tra_ZKD_Detail ");
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
			strSql.Append("select count(1) FROM WMS_Bms_Tra_ZKD_Detail ");
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
				strSql.Append("order by T.SX desc");
			}
			strSql.Append(")AS Row, T.*  from WMS_Bms_Tra_ZKD_Detail T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DbHelper_SQL.Query(strSql.ToString());
		}

	
		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

