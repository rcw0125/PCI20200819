using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;
using System.Data.SqlClient;

namespace IDAL
{
	/// <summary>
	/// 数据访问类:WMS_Bms_Tra_ZKD
	/// </summary>
	public partial class Dal_WMS_Bms_Tra_ZKD
    {
		public Dal_WMS_Bms_Tra_ZKD()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string ZKDH,string SCK,string TCK,string WLH)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from WMS_Bms_Tra_ZKD");
			strSql.Append(" where ZKDH=:ZKDH and SCK=:SCK and TCK=:TCK and WLH=:WLH ");
			SqlParameter[] parameters = {
					new SqlParameter(":ZKDH", SqlDbType.VarChar,50),
					new SqlParameter(":SCK", SqlDbType.VarChar,30),
					new SqlParameter(":TCK", SqlDbType.VarChar,30),
					new SqlParameter(":WLH", SqlDbType.VarChar,20)			};
			parameters[0].Value = ZKDH;
			parameters[1].Value = SCK;
			parameters[2].Value = TCK;
			parameters[3].Value = WLH;

			return DbHelper_SQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Mod_WMS_Bms_Tra_ZKD model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into WMS_Bms_Tra_ZKD(");
			strSql.Append("ZKDH,SCK,TCK,WLH,WLMC,PH,GG,PCH,SX,ZLDJ,ZJLDW,FJLDW,JHSL,JHZL,OutNum,OutZL,InNum,InZL,YHW,MBHW,ZHXLB,OutStatus,Status,Flag,ZDR,ZDRQ,vfree0,vfree1,vfree2,vfree3,vfree4)");
			strSql.Append(" values (");
			strSql.Append(":ZKDH,:SCK,:TCK,:WLH,:WLMC,:PH,:GG,:PCH,:SX,:ZLDJ,:ZJLDW,:FJLDW,:JHSL,:JHZL,:OutNum,:OutZL,:InNum,:InZL,:YHW,:MBHW,:ZHXLB,:OutStatus,:Status,:Flag,:ZDR,:ZDRQ,:vfree0,:vfree1,:vfree2,:vfree3,:vfree4)");
			SqlParameter[] parameters = {
					new SqlParameter(":ZKDH", SqlDbType.VarChar,50),
					new SqlParameter(":SCK", SqlDbType.VarChar,30),
					new SqlParameter(":TCK", SqlDbType.VarChar,30),
					new SqlParameter(":WLH", SqlDbType.VarChar,20),
					new SqlParameter(":WLMC", SqlDbType.VarChar,100),
					new SqlParameter(":PH", SqlDbType.VarChar,30),
					new SqlParameter(":GG", SqlDbType.VarChar,30),
					new SqlParameter(":PCH", SqlDbType.VarChar,20),
					new SqlParameter(":SX", SqlDbType.VarChar,30),
					new SqlParameter(":ZLDJ", SqlDbType.VarChar,30),
					new SqlParameter(":ZJLDW", SqlDbType.VarChar,10),
					new SqlParameter(":FJLDW", SqlDbType.VarChar,10),
					new SqlParameter(":JHSL", SqlDbType.Int,4),
					new SqlParameter(":JHZL", SqlDbType.Decimal,9),
					new SqlParameter(":OutNum", SqlDbType.Int,4),
					new SqlParameter(":OutZL", SqlDbType.Decimal,9),
					new SqlParameter(":InNum", SqlDbType.Int,4),
					new SqlParameter(":InZL", SqlDbType.Decimal,9),
					new SqlParameter(":YHW", SqlDbType.VarChar,10),
					new SqlParameter(":MBHW", SqlDbType.VarChar,10),
					new SqlParameter(":ZHXLB", SqlDbType.Bit,1),
					new SqlParameter(":OutStatus", SqlDbType.Bit,1),
					new SqlParameter(":Status", SqlDbType.Bit,1),
					new SqlParameter(":Flag", SqlDbType.VarChar,10),
					new SqlParameter(":ZDR", SqlDbType.VarChar,30),
					new SqlParameter(":ZDRQ", SqlDbType.DateTime),
					new SqlParameter(":vfree0", SqlDbType.VarChar,50),
					new SqlParameter(":vfree1", SqlDbType.VarChar,50),
					new SqlParameter(":vfree2", SqlDbType.VarChar,50),
					new SqlParameter(":vfree3", SqlDbType.VarChar,50),
					new SqlParameter(":vfree4", SqlDbType.VarChar,50)};
			parameters[0].Value = model.ZKDH;
			parameters[1].Value = model.SCK;
			parameters[2].Value = model.TCK;
			parameters[3].Value = model.WLH;
			parameters[4].Value = model.WLMC;
			parameters[5].Value = model.PH;
			parameters[6].Value = model.GG;
			parameters[7].Value = model.PCH;
			parameters[8].Value = model.SX;
			parameters[9].Value = model.ZLDJ;
			parameters[10].Value = model.ZJLDW;
			parameters[11].Value = model.FJLDW;
			parameters[12].Value = model.JHSL;
			parameters[13].Value = model.JHZL;
			parameters[14].Value = model.OutNum;
			parameters[15].Value = model.OutZL;
			parameters[16].Value = model.InNum;
			parameters[17].Value = model.InZL;
			parameters[18].Value = model.YHW;
			parameters[19].Value = model.MBHW;
			parameters[20].Value = model.ZHXLB;
			parameters[21].Value = model.OutStatus;
			parameters[22].Value = model.Status;
			parameters[23].Value = model.Flag;
			parameters[24].Value = model.ZDR;
			parameters[25].Value = model.ZDRQ;
			parameters[26].Value = model.vfree0;
			parameters[27].Value = model.vfree1;
			parameters[28].Value = model.vfree2;
			parameters[29].Value = model.vfree3;
			parameters[30].Value = model.vfree4;

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
		public bool Update(Mod_WMS_Bms_Tra_ZKD model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update WMS_Bms_Tra_ZKD set ");
			strSql.Append("WLMC=:WLMC,");
			strSql.Append("PH=:PH,");
			strSql.Append("GG=:GG,");
			strSql.Append("PCH=:PCH,");
			strSql.Append("SX=:SX,");
			strSql.Append("ZLDJ=:ZLDJ,");
			strSql.Append("ZJLDW=:ZJLDW,");
			strSql.Append("FJLDW=:FJLDW,");
			strSql.Append("JHSL=:JHSL,");
			strSql.Append("JHZL=:JHZL,");
			strSql.Append("OutNum=:OutNum,");
			strSql.Append("OutZL=:OutZL,");
			strSql.Append("InNum=:InNum,");
			strSql.Append("InZL=:InZL,");
			strSql.Append("YHW=:YHW,");
			strSql.Append("MBHW=:MBHW,");
			strSql.Append("ZHXLB=:ZHXLB,");
			strSql.Append("OutStatus=:OutStatus,");
			strSql.Append("Status=:Status,");
			strSql.Append("Flag=:Flag,");
			strSql.Append("ZDR=:ZDR,");
			strSql.Append("ZDRQ=:ZDRQ,");
			strSql.Append("vfree0=:vfree0,");
			strSql.Append("vfree1=:vfree1,");
			strSql.Append("vfree2=:vfree2,");
			strSql.Append("vfree3=:vfree3,");
			strSql.Append("vfree4=:vfree4");
			strSql.Append(" where ZKDH=:ZKDH and SCK=:SCK and TCK=:TCK and WLH=:WLH ");
			SqlParameter[] parameters = {
					new SqlParameter(":WLMC", SqlDbType.VarChar,100),
					new SqlParameter(":PH", SqlDbType.VarChar,30),
					new SqlParameter(":GG", SqlDbType.VarChar,30),
					new SqlParameter(":PCH", SqlDbType.VarChar,20),
					new SqlParameter(":SX", SqlDbType.VarChar,30),
					new SqlParameter(":ZLDJ", SqlDbType.VarChar,30),
					new SqlParameter(":ZJLDW", SqlDbType.VarChar,10),
					new SqlParameter(":FJLDW", SqlDbType.VarChar,10),
					new SqlParameter(":JHSL", SqlDbType.Int,4),
					new SqlParameter(":JHZL", SqlDbType.Decimal,9),
					new SqlParameter(":OutNum", SqlDbType.Int,4),
					new SqlParameter(":OutZL", SqlDbType.Decimal,9),
					new SqlParameter(":InNum", SqlDbType.Int,4),
					new SqlParameter(":InZL", SqlDbType.Decimal,9),
					new SqlParameter(":YHW", SqlDbType.VarChar,10),
					new SqlParameter(":MBHW", SqlDbType.VarChar,10),
					new SqlParameter(":ZHXLB", SqlDbType.Bit,1),
					new SqlParameter(":OutStatus", SqlDbType.Bit,1),
					new SqlParameter(":Status", SqlDbType.Bit,1),
					new SqlParameter(":Flag", SqlDbType.VarChar,10),
					new SqlParameter(":ZDR", SqlDbType.VarChar,30),
					new SqlParameter(":ZDRQ", SqlDbType.DateTime),
					new SqlParameter(":vfree0", SqlDbType.VarChar,50),
					new SqlParameter(":vfree1", SqlDbType.VarChar,50),
					new SqlParameter(":vfree2", SqlDbType.VarChar,50),
					new SqlParameter(":vfree3", SqlDbType.VarChar,50),
					new SqlParameter(":vfree4", SqlDbType.VarChar,50),
					new SqlParameter(":ZKDH", SqlDbType.VarChar,50),
					new SqlParameter(":SCK", SqlDbType.VarChar,30),
					new SqlParameter(":TCK", SqlDbType.VarChar,30),
					new SqlParameter(":WLH", SqlDbType.VarChar,20)};
			parameters[0].Value = model.WLMC;
			parameters[1].Value = model.PH;
			parameters[2].Value = model.GG;
			parameters[3].Value = model.PCH;
			parameters[4].Value = model.SX;
			parameters[5].Value = model.ZLDJ;
			parameters[6].Value = model.ZJLDW;
			parameters[7].Value = model.FJLDW;
			parameters[8].Value = model.JHSL;
			parameters[9].Value = model.JHZL;
			parameters[10].Value = model.OutNum;
			parameters[11].Value = model.OutZL;
			parameters[12].Value = model.InNum;
			parameters[13].Value = model.InZL;
			parameters[14].Value = model.YHW;
			parameters[15].Value = model.MBHW;
			parameters[16].Value = model.ZHXLB;
			parameters[17].Value = model.OutStatus;
			parameters[18].Value = model.Status;
			parameters[19].Value = model.Flag;
			parameters[20].Value = model.ZDR;
			parameters[21].Value = model.ZDRQ;
			parameters[22].Value = model.vfree0;
			parameters[23].Value = model.vfree1;
			parameters[24].Value = model.vfree2;
			parameters[25].Value = model.vfree3;
			parameters[26].Value = model.vfree4;
			parameters[27].Value = model.ZKDH;
			parameters[28].Value = model.SCK;
			parameters[29].Value = model.TCK;
			parameters[30].Value = model.WLH;

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
		public bool Delete(string ZKDH,string SCK,string TCK,string WLH)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from WMS_Bms_Tra_ZKD ");
			strSql.Append(" where ZKDH=:ZKDH and SCK=:SCK and TCK=:TCK and WLH=:WLH ");
			SqlParameter[] parameters = {
					new SqlParameter(":ZKDH", SqlDbType.VarChar,50),
					new SqlParameter(":SCK", SqlDbType.VarChar,30),
					new SqlParameter(":TCK", SqlDbType.VarChar,30),
					new SqlParameter(":WLH", SqlDbType.VarChar,20)			};
			parameters[0].Value = ZKDH;
			parameters[1].Value = SCK;
			parameters[2].Value = TCK;
			parameters[3].Value = WLH;

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
		public Mod_WMS_Bms_Tra_ZKD GetModel(string ZKDH,string SCK,string TCK,string WLH)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ZKDH,SCK,TCK,WLH,WLMC,PH,GG,PCH,SX,ZLDJ,ZJLDW,FJLDW,JHSL,JHZL,OutNum,OutZL,InNum,InZL,YHW,MBHW,ZHXLB,OutStatus,Status,Flag,ZDR,ZDRQ,vfree0,vfree1,vfree2,vfree3,vfree4 from WMS_Bms_Tra_ZKD ");
			strSql.Append(" where ZKDH=:ZKDH and SCK=:SCK and TCK=:TCK and WLH=:WLH ");
			SqlParameter[] parameters = {
					new SqlParameter(":ZKDH", SqlDbType.VarChar,50),
					new SqlParameter(":SCK", SqlDbType.VarChar,30),
					new SqlParameter(":TCK", SqlDbType.VarChar,30),
					new SqlParameter(":WLH", SqlDbType.VarChar,20)			};
			parameters[0].Value = ZKDH;
			parameters[1].Value = SCK;
			parameters[2].Value = TCK;
			parameters[3].Value = WLH;

			Mod_WMS_Bms_Tra_ZKD model=new Mod_WMS_Bms_Tra_ZKD();
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
		public Mod_WMS_Bms_Tra_ZKD DataRowToModel(DataRow row)
		{
			Mod_WMS_Bms_Tra_ZKD model=new Mod_WMS_Bms_Tra_ZKD();
			if (row != null)
			{
				if(row["ZKDH"]!=null)
				{
					model.ZKDH=row["ZKDH"].ToString();
				}
				if(row["SCK"]!=null)
				{
					model.SCK=row["SCK"].ToString();
				}
				if(row["TCK"]!=null)
				{
					model.TCK=row["TCK"].ToString();
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
				if(row["ZLDJ"]!=null)
				{
					model.ZLDJ=row["ZLDJ"].ToString();
				}
				if(row["ZJLDW"]!=null)
				{
					model.ZJLDW=row["ZJLDW"].ToString();
				}
				if(row["FJLDW"]!=null)
				{
					model.FJLDW=row["FJLDW"].ToString();
				}
				if(row["JHSL"]!=null && row["JHSL"].ToString()!="")
				{
					model.JHSL=int.Parse(row["JHSL"].ToString());
				}
				if(row["JHZL"]!=null && row["JHZL"].ToString()!="")
				{
					model.JHZL=decimal.Parse(row["JHZL"].ToString());
				}
				if(row["OutNum"]!=null && row["OutNum"].ToString()!="")
				{
					model.OutNum=int.Parse(row["OutNum"].ToString());
				}
				if(row["OutZL"]!=null && row["OutZL"].ToString()!="")
				{
					model.OutZL=decimal.Parse(row["OutZL"].ToString());
				}
				if(row["InNum"]!=null && row["InNum"].ToString()!="")
				{
					model.InNum=int.Parse(row["InNum"].ToString());
				}
				if(row["InZL"]!=null && row["InZL"].ToString()!="")
				{
					model.InZL=decimal.Parse(row["InZL"].ToString());
				}
				if(row["YHW"]!=null)
				{
					model.YHW=row["YHW"].ToString();
				}
				if(row["MBHW"]!=null)
				{
					model.MBHW=row["MBHW"].ToString();
				}
				if(row["ZHXLB"]!=null && row["ZHXLB"].ToString()!="")
				{
					if((row["ZHXLB"].ToString()=="1")||(row["ZHXLB"].ToString().ToLower()=="true"))
					{
						model.ZHXLB=true;
					}
					else
					{
						model.ZHXLB=false;
					}
				}
				if(row["OutStatus"]!=null && row["OutStatus"].ToString()!="")
				{
					if((row["OutStatus"].ToString()=="1")||(row["OutStatus"].ToString().ToLower()=="true"))
					{
						model.OutStatus=true;
					}
					else
					{
						model.OutStatus=false;
					}
				}
				if(row["Status"]!=null && row["Status"].ToString()!="")
				{
					if((row["Status"].ToString()=="1")||(row["Status"].ToString().ToLower()=="true"))
					{
						model.Status=true;
					}
					else
					{
						model.Status=false;
					}
				}
				if(row["Flag"]!=null)
				{
					model.Flag=row["Flag"].ToString();
				}
				if(row["ZDR"]!=null)
				{
					model.ZDR=row["ZDR"].ToString();
				}
				if(row["ZDRQ"]!=null && row["ZDRQ"].ToString()!="")
				{
					model.ZDRQ=DateTime.Parse(row["ZDRQ"].ToString());
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
			strSql.Append("select ZKDH,SCK,TCK,WLH,WLMC,PH,GG,PCH,SX,ZLDJ,ZJLDW,FJLDW,JHSL,JHZL,OutNum,OutZL,InNum,InZL,YHW,MBHW,ZHXLB,OutStatus,Status,Flag,ZDR,ZDRQ,vfree0,vfree1,vfree2,vfree3,vfree4 ");
			strSql.Append(" FROM WMS_Bms_Tra_ZKD ");
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
			strSql.Append(" ZKDH,SCK,TCK,WLH,WLMC,PH,GG,PCH,SX,ZLDJ,ZJLDW,FJLDW,JHSL,JHZL,OutNum,OutZL,InNum,InZL,YHW,MBHW,ZHXLB,OutStatus,Status,Flag,ZDR,ZDRQ,vfree0,vfree1,vfree2,vfree3,vfree4 ");
			strSql.Append(" FROM WMS_Bms_Tra_ZKD ");
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
			strSql.Append("select count(1) FROM WMS_Bms_Tra_ZKD ");
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
				strSql.Append("order by T.WLH desc");
			}
			strSql.Append(")AS Row, T.*  from WMS_Bms_Tra_ZKD T ");
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

