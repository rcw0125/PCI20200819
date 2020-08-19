using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;
using System.Data.SqlClient;

namespace IDAL
{
	/// <summary>
	/// 数据访问类:WMS_Bms_Inv_OutInfo
	/// </summary>
	public partial class Dal_WMS_Bms_Inv_OutInfo
    {
		public Dal_WMS_Bms_Inv_OutInfo()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelper_SQL.GetMaxID("CKDH", "WMS_Bms_Inv_OutInfo"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string Barcode,string FYDH,int CKDH,string PCH,string WLH,DateTime WeightRQ,string ProduceData)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from WMS_Bms_Inv_OutInfo");
			strSql.Append(" where Barcode=:Barcode and FYDH=:FYDH and CKDH=:CKDH and PCH=:PCH and WLH=:WLH and WeightRQ=:WeightRQ and ProduceData=:ProduceData ");
			SqlParameter[] parameters = {
					new SqlParameter(":Barcode", SqlDbType.VarChar,20),
					new SqlParameter(":FYDH", SqlDbType.VarChar,50),
					new SqlParameter(":CKDH", SqlDbType.Int,4),
					new SqlParameter(":PCH", SqlDbType.VarChar,20),
					new SqlParameter(":WLH", SqlDbType.VarChar,20),
					new SqlParameter(":WeightRQ", SqlDbType.DateTime),
					new SqlParameter(":ProduceData", SqlDbType.VarChar,20)			};
			parameters[0].Value = Barcode;
			parameters[1].Value = FYDH;
			parameters[2].Value = CKDH;
			parameters[3].Value = PCH;
			parameters[4].Value = WLH;
			parameters[5].Value = WeightRQ;
			parameters[6].Value = ProduceData;

			return DbHelper_SQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Mod_WMS_Bms_Inv_OutInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into WMS_Bms_Inv_OutInfo(");
			strSql.Append("Barcode,RKDH,FYDH,CKDH,CK,HW,PCH,WLH,WLMC,SX,ZLDJ,PH,GG,BB,GH,ZL,BZ,RQ,Flag,CKRY,CXH,KHBM,WeightRQ,CKCXH,ProduceData,Filed1,PCInfo,Filed2,ErrSeason,vfree0,vfree1,vfree2,vfree3,vfree4,ysmz)");
			strSql.Append(" values (");
			strSql.Append(":Barcode,:RKDH,:FYDH,:CKDH,:CK,:HW,:PCH,:WLH,:WLMC,:SX,:ZLDJ,:PH,:GG,:BB,:GH,:ZL,:BZ,:RQ,:Flag,:CKRY,:CXH,:KHBM,:WeightRQ,:CKCXH,:ProduceData,:Filed1,:PCInfo,:Filed2,:ErrSeason,:vfree0,:vfree1,:vfree2,:vfree3,:vfree4,:ysmz)");
			SqlParameter[] parameters = {
					new SqlParameter(":Barcode", SqlDbType.VarChar,20),
					new SqlParameter(":RKDH", SqlDbType.VarChar,50),
					new SqlParameter(":FYDH", SqlDbType.VarChar,50),
					new SqlParameter(":CKDH", SqlDbType.Int,4),
					new SqlParameter(":CK", SqlDbType.VarChar,30),
					new SqlParameter(":HW", SqlDbType.VarChar,20),
					new SqlParameter(":PCH", SqlDbType.VarChar,20),
					new SqlParameter(":WLH", SqlDbType.VarChar,20),
					new SqlParameter(":WLMC", SqlDbType.VarChar,100),
					new SqlParameter(":SX", SqlDbType.VarChar,30),
					new SqlParameter(":ZLDJ", SqlDbType.VarChar,10),
					new SqlParameter(":PH", SqlDbType.VarChar,30),
					new SqlParameter(":GG", SqlDbType.VarChar,30),
					new SqlParameter(":BB", SqlDbType.VarChar,10),
					new SqlParameter(":GH", SqlDbType.Int,4),
					new SqlParameter(":ZL", SqlDbType.Decimal,9),
					new SqlParameter(":BZ", SqlDbType.VarChar,50),
					new SqlParameter(":RQ", SqlDbType.DateTime),
					new SqlParameter(":Flag", SqlDbType.VarChar,20),
					new SqlParameter(":CKRY", SqlDbType.VarChar,20),
					new SqlParameter(":CXH", SqlDbType.VarChar,30),
					new SqlParameter(":KHBM", SqlDbType.VarChar,50),
					new SqlParameter(":WeightRQ", SqlDbType.DateTime),
					new SqlParameter(":CKCXH", SqlDbType.Int,4),
					new SqlParameter(":ProduceData", SqlDbType.VarChar,20),
					new SqlParameter(":Filed1", SqlDbType.VarChar,50),
					new SqlParameter(":PCInfo", SqlDbType.VarChar,150),
					new SqlParameter(":Filed2", SqlDbType.VarChar,50),
					new SqlParameter(":ErrSeason", SqlDbType.VarChar,50),
					new SqlParameter(":vfree0", SqlDbType.VarChar,50),
					new SqlParameter(":vfree1", SqlDbType.VarChar,50),
					new SqlParameter(":vfree2", SqlDbType.VarChar,50),
					new SqlParameter(":vfree3", SqlDbType.VarChar,50),
					new SqlParameter(":vfree4", SqlDbType.VarChar,50),
					new SqlParameter(":ysmz", SqlDbType.Decimal,9)};
			parameters[0].Value = model.Barcode;
			parameters[1].Value = model.RKDH;
			parameters[2].Value = model.FYDH;
			parameters[3].Value = model.CKDH;
			parameters[4].Value = model.CK;
			parameters[5].Value = model.HW;
			parameters[6].Value = model.PCH;
			parameters[7].Value = model.WLH;
			parameters[8].Value = model.WLMC;
			parameters[9].Value = model.SX;
			parameters[10].Value = model.ZLDJ;
			parameters[11].Value = model.PH;
			parameters[12].Value = model.GG;
			parameters[13].Value = model.BB;
			parameters[14].Value = model.GH;
			parameters[15].Value = model.ZL;
			parameters[16].Value = model.BZ;
			parameters[17].Value = model.RQ;
			parameters[18].Value = model.Flag;
			parameters[19].Value = model.CKRY;
			parameters[20].Value = model.CXH;
			parameters[21].Value = model.KHBM;
			parameters[22].Value = model.WeightRQ;
			parameters[23].Value = model.CKCXH;
			parameters[24].Value = model.ProduceData;
			parameters[25].Value = model.Filed1;
			parameters[26].Value = model.PCInfo;
			parameters[27].Value = model.Filed2;
			parameters[28].Value = model.ErrSeason;
			parameters[29].Value = model.vfree0;
			parameters[30].Value = model.vfree1;
			parameters[31].Value = model.vfree2;
			parameters[32].Value = model.vfree3;
			parameters[33].Value = model.vfree4;
			parameters[34].Value = model.ysmz;

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
		public bool Update(Mod_WMS_Bms_Inv_OutInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update WMS_Bms_Inv_OutInfo set ");
			strSql.Append("RKDH=:RKDH,");
			strSql.Append("CK=:CK,");
			strSql.Append("HW=:HW,");
			strSql.Append("WLMC=:WLMC,");
			strSql.Append("SX=:SX,");
			strSql.Append("ZLDJ=:ZLDJ,");
			strSql.Append("PH=:PH,");
			strSql.Append("GG=:GG,");
			strSql.Append("BB=:BB,");
			strSql.Append("GH=:GH,");
			strSql.Append("ZL=:ZL,");
			strSql.Append("BZ=:BZ,");
			strSql.Append("RQ=:RQ,");
			strSql.Append("Flag=:Flag,");
			strSql.Append("CKRY=:CKRY,");
			strSql.Append("CXH=:CXH,");
			strSql.Append("KHBM=:KHBM,");
			strSql.Append("CKCXH=:CKCXH,");
			strSql.Append("Filed1=:Filed1,");
			strSql.Append("PCInfo=:PCInfo,");
			strSql.Append("Filed2=:Filed2,");
			strSql.Append("ErrSeason=:ErrSeason,");
			strSql.Append("vfree0=:vfree0,");
			strSql.Append("vfree1=:vfree1,");
			strSql.Append("vfree2=:vfree2,");
			strSql.Append("vfree3=:vfree3,");
			strSql.Append("vfree4=:vfree4,");
			strSql.Append("ysmz=:ysmz");
			strSql.Append(" where Barcode=:Barcode and FYDH=:FYDH and CKDH=:CKDH and PCH=:PCH and WLH=:WLH and WeightRQ=:WeightRQ and ProduceData=:ProduceData ");
			SqlParameter[] parameters = {
					new SqlParameter(":RKDH", SqlDbType.VarChar,50),
					new SqlParameter(":CK", SqlDbType.VarChar,30),
					new SqlParameter(":HW", SqlDbType.VarChar,20),
					new SqlParameter(":WLMC", SqlDbType.VarChar,100),
					new SqlParameter(":SX", SqlDbType.VarChar,30),
					new SqlParameter(":ZLDJ", SqlDbType.VarChar,10),
					new SqlParameter(":PH", SqlDbType.VarChar,30),
					new SqlParameter(":GG", SqlDbType.VarChar,30),
					new SqlParameter(":BB", SqlDbType.VarChar,10),
					new SqlParameter(":GH", SqlDbType.Int,4),
					new SqlParameter(":ZL", SqlDbType.Decimal,9),
					new SqlParameter(":BZ", SqlDbType.VarChar,50),
					new SqlParameter(":RQ", SqlDbType.DateTime),
					new SqlParameter(":Flag", SqlDbType.VarChar,20),
					new SqlParameter(":CKRY", SqlDbType.VarChar,20),
					new SqlParameter(":CXH", SqlDbType.VarChar,30),
					new SqlParameter(":KHBM", SqlDbType.VarChar,50),
					new SqlParameter(":CKCXH", SqlDbType.Int,4),
					new SqlParameter(":Filed1", SqlDbType.VarChar,50),
					new SqlParameter(":PCInfo", SqlDbType.VarChar,150),
					new SqlParameter(":Filed2", SqlDbType.VarChar,50),
					new SqlParameter(":ErrSeason", SqlDbType.VarChar,50),
					new SqlParameter(":vfree0", SqlDbType.VarChar,50),
					new SqlParameter(":vfree1", SqlDbType.VarChar,50),
					new SqlParameter(":vfree2", SqlDbType.VarChar,50),
					new SqlParameter(":vfree3", SqlDbType.VarChar,50),
					new SqlParameter(":vfree4", SqlDbType.VarChar,50),
					new SqlParameter(":ysmz", SqlDbType.Decimal,9),
					new SqlParameter(":Barcode", SqlDbType.VarChar,20),
					new SqlParameter(":FYDH", SqlDbType.VarChar,50),
					new SqlParameter(":CKDH", SqlDbType.Int,4),
					new SqlParameter(":PCH", SqlDbType.VarChar,20),
					new SqlParameter(":WLH", SqlDbType.VarChar,20),
					new SqlParameter(":WeightRQ", SqlDbType.DateTime),
					new SqlParameter(":ProduceData", SqlDbType.VarChar,20)};
			parameters[0].Value = model.RKDH;
			parameters[1].Value = model.CK;
			parameters[2].Value = model.HW;
			parameters[3].Value = model.WLMC;
			parameters[4].Value = model.SX;
			parameters[5].Value = model.ZLDJ;
			parameters[6].Value = model.PH;
			parameters[7].Value = model.GG;
			parameters[8].Value = model.BB;
			parameters[9].Value = model.GH;
			parameters[10].Value = model.ZL;
			parameters[11].Value = model.BZ;
			parameters[12].Value = model.RQ;
			parameters[13].Value = model.Flag;
			parameters[14].Value = model.CKRY;
			parameters[15].Value = model.CXH;
			parameters[16].Value = model.KHBM;
			parameters[17].Value = model.CKCXH;
			parameters[18].Value = model.Filed1;
			parameters[19].Value = model.PCInfo;
			parameters[20].Value = model.Filed2;
			parameters[21].Value = model.ErrSeason;
			parameters[22].Value = model.vfree0;
			parameters[23].Value = model.vfree1;
			parameters[24].Value = model.vfree2;
			parameters[25].Value = model.vfree3;
			parameters[26].Value = model.vfree4;
			parameters[27].Value = model.ysmz;
			parameters[28].Value = model.Barcode;
			parameters[29].Value = model.FYDH;
			parameters[30].Value = model.CKDH;
			parameters[31].Value = model.PCH;
			parameters[32].Value = model.WLH;
			parameters[33].Value = model.WeightRQ;
			parameters[34].Value = model.ProduceData;

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
		public bool Delete(string Barcode,string FYDH,int CKDH,string PCH,string WLH,DateTime WeightRQ,string ProduceData)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from WMS_Bms_Inv_OutInfo ");
			strSql.Append(" where Barcode=:Barcode and FYDH=:FYDH and CKDH=:CKDH and PCH=:PCH and WLH=:WLH and WeightRQ=:WeightRQ and ProduceData=:ProduceData ");
			SqlParameter[] parameters = {
					new SqlParameter(":Barcode", SqlDbType.VarChar,20),
					new SqlParameter(":FYDH", SqlDbType.VarChar,50),
					new SqlParameter(":CKDH", SqlDbType.Int,4),
					new SqlParameter(":PCH", SqlDbType.VarChar,20),
					new SqlParameter(":WLH", SqlDbType.VarChar,20),
					new SqlParameter(":WeightRQ", SqlDbType.DateTime),
					new SqlParameter(":ProduceData", SqlDbType.VarChar,20)			};
			parameters[0].Value = Barcode;
			parameters[1].Value = FYDH;
			parameters[2].Value = CKDH;
			parameters[3].Value = PCH;
			parameters[4].Value = WLH;
			parameters[5].Value = WeightRQ;
			parameters[6].Value = ProduceData;

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
		public Mod_WMS_Bms_Inv_OutInfo GetModel(string Barcode,string FYDH,int CKDH,string PCH,string WLH,DateTime WeightRQ,string ProduceData)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 Barcode,RKDH,FYDH,CKDH,CK,HW,PCH,WLH,WLMC,SX,ZLDJ,PH,GG,BB,GH,ZL,BZ,RQ,Flag,CKRY,CXH,KHBM,WeightRQ,CKCXH,ProduceData,Filed1,PCInfo,Filed2,ErrSeason,vfree0,vfree1,vfree2,vfree3,vfree4,ysmz from WMS_Bms_Inv_OutInfo ");
			strSql.Append(" where Barcode=:Barcode and FYDH=:FYDH and CKDH=:CKDH and PCH=:PCH and WLH=:WLH and WeightRQ=:WeightRQ and ProduceData=:ProduceData ");
			SqlParameter[] parameters = {
					new SqlParameter(":Barcode", SqlDbType.VarChar,20),
					new SqlParameter(":FYDH", SqlDbType.VarChar,50),
					new SqlParameter(":CKDH", SqlDbType.Int,4),
					new SqlParameter(":PCH", SqlDbType.VarChar,20),
					new SqlParameter(":WLH", SqlDbType.VarChar,20),
					new SqlParameter(":WeightRQ", SqlDbType.DateTime),
					new SqlParameter(":ProduceData", SqlDbType.VarChar,20)			};
			parameters[0].Value = Barcode;
			parameters[1].Value = FYDH;
			parameters[2].Value = CKDH;
			parameters[3].Value = PCH;
			parameters[4].Value = WLH;
			parameters[5].Value = WeightRQ;
			parameters[6].Value = ProduceData;

			Mod_WMS_Bms_Inv_OutInfo model=new Mod_WMS_Bms_Inv_OutInfo();
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
		public Mod_WMS_Bms_Inv_OutInfo DataRowToModel(DataRow row)
		{
			Mod_WMS_Bms_Inv_OutInfo model=new Mod_WMS_Bms_Inv_OutInfo();
			if (row != null)
			{
				if(row["Barcode"]!=null)
				{
					model.Barcode=row["Barcode"].ToString();
				}
				if(row["RKDH"]!=null)
				{
					model.RKDH=row["RKDH"].ToString();
				}
				if(row["FYDH"]!=null)
				{
					model.FYDH=row["FYDH"].ToString();
				}
				if(row["CKDH"]!=null && row["CKDH"].ToString()!="")
				{
					model.CKDH=int.Parse(row["CKDH"].ToString());
				}
				if(row["CK"]!=null)
				{
					model.CK=row["CK"].ToString();
				}
				if(row["HW"]!=null)
				{
					model.HW=row["HW"].ToString();
				}
				if(row["PCH"]!=null)
				{
					model.PCH=row["PCH"].ToString();
				}
				if(row["WLH"]!=null)
				{
					model.WLH=row["WLH"].ToString();
				}
				if(row["WLMC"]!=null)
				{
					model.WLMC=row["WLMC"].ToString();
				}
				if(row["SX"]!=null)
				{
					model.SX=row["SX"].ToString();
				}
				if(row["ZLDJ"]!=null)
				{
					model.ZLDJ=row["ZLDJ"].ToString();
				}
				if(row["PH"]!=null)
				{
					model.PH=row["PH"].ToString();
				}
				if(row["GG"]!=null)
				{
					model.GG=row["GG"].ToString();
				}
				if(row["BB"]!=null)
				{
					model.BB=row["BB"].ToString();
				}
				if(row["GH"]!=null && row["GH"].ToString()!="")
				{
					model.GH=int.Parse(row["GH"].ToString());
				}
				if(row["ZL"]!=null && row["ZL"].ToString()!="")
				{
					model.ZL=decimal.Parse(row["ZL"].ToString());
				}
				if(row["BZ"]!=null)
				{
					model.BZ=row["BZ"].ToString();
				}
				if(row["RQ"]!=null && row["RQ"].ToString()!="")
				{
					model.RQ=DateTime.Parse(row["RQ"].ToString());
				}
				if(row["Flag"]!=null)
				{
					model.Flag=row["Flag"].ToString();
				}
				if(row["CKRY"]!=null)
				{
					model.CKRY=row["CKRY"].ToString();
				}
				if(row["CXH"]!=null)
				{
					model.CXH=row["CXH"].ToString();
				}
				if(row["KHBM"]!=null)
				{
					model.KHBM=row["KHBM"].ToString();
				}
				if(row["WeightRQ"]!=null && row["WeightRQ"].ToString()!="")
				{
					model.WeightRQ=DateTime.Parse(row["WeightRQ"].ToString());
				}
				if(row["CKCXH"]!=null && row["CKCXH"].ToString()!="")
				{
					model.CKCXH=int.Parse(row["CKCXH"].ToString());
				}
				if(row["ProduceData"]!=null)
				{
					model.ProduceData=row["ProduceData"].ToString();
				}
				if(row["Filed1"]!=null)
				{
					model.Filed1=row["Filed1"].ToString();
				}
				if(row["PCInfo"]!=null)
				{
					model.PCInfo=row["PCInfo"].ToString();
				}
				if(row["Filed2"]!=null)
				{
					model.Filed2=row["Filed2"].ToString();
				}
				if(row["ErrSeason"]!=null)
				{
					model.ErrSeason=row["ErrSeason"].ToString();
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
				if(row["ysmz"]!=null && row["ysmz"].ToString()!="")
				{
					model.ysmz=decimal.Parse(row["ysmz"].ToString());
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
			strSql.Append("select Barcode,RKDH,FYDH,CKDH,CK,HW,PCH,WLH,WLMC,SX,ZLDJ,PH,GG,BB,GH,ZL,BZ,RQ,Flag,CKRY,CXH,KHBM,WeightRQ,CKCXH,ProduceData,Filed1,PCInfo,Filed2,ErrSeason,vfree0,vfree1,vfree2,vfree3,vfree4,ysmz ");
			strSql.Append(" FROM WMS_Bms_Inv_OutInfo ");
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
			strSql.Append(" Barcode,RKDH,FYDH,CKDH,CK,HW,PCH,WLH,WLMC,SX,ZLDJ,PH,GG,BB,GH,ZL,BZ,RQ,Flag,CKRY,CXH,KHBM,WeightRQ,CKCXH,ProduceData,Filed1,PCInfo,Filed2,ErrSeason,vfree0,vfree1,vfree2,vfree3,vfree4,ysmz ");
			strSql.Append(" FROM WMS_Bms_Inv_OutInfo ");
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
			strSql.Append("select count(1) FROM WMS_Bms_Inv_OutInfo ");
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
				strSql.Append("order by T.ProduceData desc");
			}
			strSql.Append(")AS Row, T.*  from WMS_Bms_Inv_OutInfo T ");
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
        /// <summary>
        /// 获取条码库存信息
        /// </summary>
        /// <param name="CK">仓库</param>
        /// <param name="HW">货位</param>
        /// <param name="FYDH">发运单号</param>
        /// <param name="RKDH">入库单号</param>
        /// <param name="CKDH">出库单号</param>
        /// <param name="PH">批号</param>
        /// <param name="GH">钩号</param>
        /// <param name="GZ">钢种</param>
        /// <returns>条码库存信息</returns>
        public DataSet GetList(string CK, string HW, string FYDH,string RKDH,string CKDH, string PH, string GH, string GZ)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ");
            strSql.Append(" Barcode,RKDH,FYDH,CKDH,CK,HW,PCH,WLH,WLMC,SX,ZLDJ,PH,GG,BB,GH,ZL,BZ,RQ,Flag,CKRY,CXH,KHBM,WeightRQ,CKCXH,ProduceData,Filed1,PCInfo,Filed2,ErrSeason,vfree0,vfree1,vfree2,vfree3,vfree4,ysmz  ");
            strSql.Append(" FROM WMS_Bms_Inv_OutInfo where 1=1 ");
            if (CK.Trim() != "")
            {
                strSql.Append(" and  CK='" + CK + "' ");
            }
            if (HW.Trim() != "")
            {
                strSql.Append(" and  HW='" + HW + "' ");
            }
            if (FYDH.Trim() != "")
            {
                strSql.Append(" and  FYDH='" + FYDH + "' ");
            }
            if (RKDH.Trim() != "")
            {
                strSql.Append(" and  RKDH='" + RKDH + "' ");
            }
            if (CKDH.Trim() != "")
            {
                strSql.Append(" and  CKDH='" + CKDH + "' ");
            }
            if (PH.Trim() != "")
            {
                strSql.Append(" and  PCH='" + PH + "' ");
            }

            if (GH.Trim() != "")
            {
                strSql.Append(" and  GH='" + GH + "' ");
            }

            if (GZ.Trim() != "")
            {
                strSql.Append(" and  PH='" + GZ + "' ");
            }
            strSql.Append(" order by  Barcode ");
            return DbHelper_SQL.Query(strSql.ToString());
        }
        #endregion  ExtensionMethod
    }
}

