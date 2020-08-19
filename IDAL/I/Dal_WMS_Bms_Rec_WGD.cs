using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;
using System.Data.SqlClient;

namespace IDAL
{
	/// <summary>
	/// 数据访问类:WMS_Bms_Rec_WGD
	/// </summary>
	public partial class Dal_WMS_Bms_Rec_WGD
    {
		public Dal_WMS_Bms_Rec_WGD()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string WGDH,string PCH,string PH,string GG,string SCX,string WLH)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from WMS_Bms_Rec_WGD");
			strSql.Append(" where WGDH=:WGDH and PCH=:PCH and PH=:PH and GG=:GG and SCX=:SCX and WLH=:WLH ");
			SqlParameter[] parameters = {
					new SqlParameter(":WGDH", SqlDbType.VarChar,50),
					new SqlParameter(":PCH", SqlDbType.VarChar,20),
					new SqlParameter(":PH", SqlDbType.VarChar,30),
					new SqlParameter(":GG", SqlDbType.VarChar,30),
					new SqlParameter(":SCX", SqlDbType.VarChar,50),
					new SqlParameter(":WLH", SqlDbType.VarChar,20)			};
			parameters[0].Value = WGDH;
			parameters[1].Value = PCH;
			parameters[2].Value = PH;
			parameters[3].Value = GG;
			parameters[4].Value = SCX;
			parameters[5].Value = WLH;

			return DbHelper_SQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Mod_WMS_Bms_Rec_WGD model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into WMS_Bms_Rec_WGD(");
			strSql.Append("WGDH,PCH,PH,GG,BB,SCX,NCWLBMID,WLH,WLMC,FZDW,ZXBZ,PCSX,PCLX,ZLDJ,ZPGP,PCXH,WCBZ,PGBZ,ZJBZ,ZPDJBZ,Rev_Time,End_Time,PEnd_Time,FEW_scx,SendEnd,IsTran,YWLH,YWLMC,YPH,YGG,YZXBZ,ZDR,ZDDATE,UPDATERY,UPDATEDATE,FLAG,Filed1,PCInfo,Filed2,SendBack,vfree0,vfree1,vfree2,vfree3,vfree4,yvfree0,yvfree1,yvfree2,yvfree3,yvfree4,GPZL)");
			strSql.Append(" values (");
			strSql.Append(":WGDH,:PCH,:PH,:GG,:BB,:SCX,:NCWLBMID,:WLH,:WLMC,:FZDW,:ZXBZ,:PCSX,:PCLX,:ZLDJ,:ZPGP,:PCXH,:WCBZ,:PGBZ,:ZJBZ,:ZPDJBZ,:Rev_Time,:End_Time,:PEnd_Time,:FEW_scx,:SendEnd,:IsTran,:YWLH,:YWLMC,:YPH,:YGG,:YZXBZ,:ZDR,:ZDDATE,:UPDATERY,:UPDATEDATE,:FLAG,:Filed1,:PCInfo,:Filed2,:SendBack,:vfree0,:vfree1,:vfree2,:vfree3,:vfree4,:yvfree0,:yvfree1,:yvfree2,:yvfree3,:yvfree4,:GPZL)");
			SqlParameter[] parameters = {
					new SqlParameter(":WGDH", SqlDbType.VarChar,50),
					new SqlParameter(":PCH", SqlDbType.VarChar,20),
					new SqlParameter(":PH", SqlDbType.VarChar,30),
					new SqlParameter(":GG", SqlDbType.VarChar,30),
					new SqlParameter(":BB", SqlDbType.VarChar,10),
					new SqlParameter(":SCX", SqlDbType.VarChar,50),
					new SqlParameter(":NCWLBMID", SqlDbType.VarChar,20),
					new SqlParameter(":WLH", SqlDbType.VarChar,20),
					new SqlParameter(":WLMC", SqlDbType.VarChar,100),
					new SqlParameter(":FZDW", SqlDbType.VarChar,10),
					new SqlParameter(":ZXBZ", SqlDbType.VarChar,40),
					new SqlParameter(":PCSX", SqlDbType.VarChar,30),
					new SqlParameter(":PCLX", SqlDbType.Int,4),
					new SqlParameter(":ZLDJ", SqlDbType.VarChar,10),
					new SqlParameter(":ZPGP", SqlDbType.VarChar,30),
					new SqlParameter(":PCXH", SqlDbType.Int,4),
					new SqlParameter(":WCBZ", SqlDbType.Int,4),
					new SqlParameter(":PGBZ", SqlDbType.Int,4),
					new SqlParameter(":ZJBZ", SqlDbType.Int,4),
					new SqlParameter(":ZPDJBZ", SqlDbType.Int,4),
					new SqlParameter(":Rev_Time", SqlDbType.DateTime),
					new SqlParameter(":End_Time", SqlDbType.DateTime),
					new SqlParameter(":PEnd_Time", SqlDbType.DateTime),
					new SqlParameter(":FEW_scx", SqlDbType.VarChar,10),
					new SqlParameter(":SendEnd", SqlDbType.Int,4),
					new SqlParameter(":IsTran", SqlDbType.Int,4),
					new SqlParameter(":YWLH", SqlDbType.VarChar,50),
					new SqlParameter(":YWLMC", SqlDbType.VarChar,50),
					new SqlParameter(":YPH", SqlDbType.VarChar,50),
					new SqlParameter(":YGG", SqlDbType.VarChar,50),
					new SqlParameter(":YZXBZ", SqlDbType.VarChar,50),
					new SqlParameter(":ZDR", SqlDbType.VarChar,20),
					new SqlParameter(":ZDDATE", SqlDbType.DateTime),
					new SqlParameter(":UPDATERY", SqlDbType.VarChar,20),
					new SqlParameter(":UPDATEDATE", SqlDbType.DateTime),
					new SqlParameter(":FLAG", SqlDbType.VarChar,10),
					new SqlParameter(":Filed1", SqlDbType.VarChar,50),
					new SqlParameter(":PCInfo", SqlDbType.VarChar,150),
					new SqlParameter(":Filed2", SqlDbType.VarChar,50),
					new SqlParameter(":SendBack", SqlDbType.Bit,1),
					new SqlParameter(":vfree0", SqlDbType.VarChar,50),
					new SqlParameter(":vfree1", SqlDbType.VarChar,50),
					new SqlParameter(":vfree2", SqlDbType.VarChar,50),
					new SqlParameter(":vfree3", SqlDbType.VarChar,50),
					new SqlParameter(":vfree4", SqlDbType.VarChar,50),
					new SqlParameter(":yvfree0", SqlDbType.VarChar,50),
					new SqlParameter(":yvfree1", SqlDbType.VarChar,50),
					new SqlParameter(":yvfree2", SqlDbType.VarChar,50),
					new SqlParameter(":yvfree3", SqlDbType.VarChar,50),
					new SqlParameter(":yvfree4", SqlDbType.VarChar,50),
					new SqlParameter(":GPZL", SqlDbType.Decimal,9)};
			parameters[0].Value = model.WGDH;
			parameters[1].Value = model.PCH;
			parameters[2].Value = model.PH;
			parameters[3].Value = model.GG;
			parameters[4].Value = model.BB;
			parameters[5].Value = model.SCX;
			parameters[6].Value = model.NCWLBMID;
			parameters[7].Value = model.WLH;
			parameters[8].Value = model.WLMC;
			parameters[9].Value = model.FZDW;
			parameters[10].Value = model.ZXBZ;
			parameters[11].Value = model.PCSX;
			parameters[12].Value = model.PCLX;
			parameters[13].Value = model.ZLDJ;
			parameters[14].Value = model.ZPGP;
			parameters[15].Value = model.PCXH;
			parameters[16].Value = model.WCBZ;
			parameters[17].Value = model.PGBZ;
			parameters[18].Value = model.ZJBZ;
			parameters[19].Value = model.ZPDJBZ;
			parameters[20].Value = model.Rev_Time;
			parameters[21].Value = model.End_Time;
			parameters[22].Value = model.PEnd_Time;
			parameters[23].Value = model.FEW_scx;
			parameters[24].Value = model.SendEnd;
			parameters[25].Value = model.IsTran;
			parameters[26].Value = model.YWLH;
			parameters[27].Value = model.YWLMC;
			parameters[28].Value = model.YPH;
			parameters[29].Value = model.YGG;
			parameters[30].Value = model.YZXBZ;
			parameters[31].Value = model.ZDR;
			parameters[32].Value = model.ZDDATE;
			parameters[33].Value = model.UPDATERY;
			parameters[34].Value = model.UPDATEDATE;
			parameters[35].Value = model.FLAG;
			parameters[36].Value = model.Filed1;
			parameters[37].Value = model.PCInfo;
			parameters[38].Value = model.Filed2;
			parameters[39].Value = model.SendBack;
			parameters[40].Value = model.vfree0;
			parameters[41].Value = model.vfree1;
			parameters[42].Value = model.vfree2;
			parameters[43].Value = model.vfree3;
			parameters[44].Value = model.vfree4;
			parameters[45].Value = model.yvfree0;
			parameters[46].Value = model.yvfree1;
			parameters[47].Value = model.yvfree2;
			parameters[48].Value = model.yvfree3;
			parameters[49].Value = model.yvfree4;
			parameters[50].Value = model.GPZL;

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
		public bool Update(Mod_WMS_Bms_Rec_WGD model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update WMS_Bms_Rec_WGD set ");
			strSql.Append("BB=:BB,");
			strSql.Append("NCWLBMID=:NCWLBMID,");
			strSql.Append("WLMC=:WLMC,");
			strSql.Append("FZDW=:FZDW,");
			strSql.Append("ZXBZ=:ZXBZ,");
			strSql.Append("PCSX=:PCSX,");
			strSql.Append("PCLX=:PCLX,");
			strSql.Append("ZLDJ=:ZLDJ,");
			strSql.Append("ZPGP=:ZPGP,");
			strSql.Append("PCXH=:PCXH,");
			strSql.Append("WCBZ=:WCBZ,");
			strSql.Append("PGBZ=:PGBZ,");
			strSql.Append("ZJBZ=:ZJBZ,");
			strSql.Append("ZPDJBZ=:ZPDJBZ,");
			strSql.Append("Rev_Time=:Rev_Time,");
			strSql.Append("End_Time=:End_Time,");
			strSql.Append("PEnd_Time=:PEnd_Time,");
			strSql.Append("FEW_scx=:FEW_scx,");
			strSql.Append("SendEnd=:SendEnd,");
			strSql.Append("IsTran=:IsTran,");
			strSql.Append("YWLH=:YWLH,");
			strSql.Append("YWLMC=:YWLMC,");
			strSql.Append("YPH=:YPH,");
			strSql.Append("YGG=:YGG,");
			strSql.Append("YZXBZ=:YZXBZ,");
			strSql.Append("ZDR=:ZDR,");
			strSql.Append("ZDDATE=:ZDDATE,");
			strSql.Append("UPDATERY=:UPDATERY,");
			strSql.Append("UPDATEDATE=:UPDATEDATE,");
			strSql.Append("FLAG=:FLAG,");
			strSql.Append("Filed1=:Filed1,");
			strSql.Append("PCInfo=:PCInfo,");
			strSql.Append("Filed2=:Filed2,");
			strSql.Append("SendBack=:SendBack,");
			strSql.Append("vfree0=:vfree0,");
			strSql.Append("vfree1=:vfree1,");
			strSql.Append("vfree2=:vfree2,");
			strSql.Append("vfree3=:vfree3,");
			strSql.Append("vfree4=:vfree4,");
			strSql.Append("yvfree0=:yvfree0,");
			strSql.Append("yvfree1=:yvfree1,");
			strSql.Append("yvfree2=:yvfree2,");
			strSql.Append("yvfree3=:yvfree3,");
			strSql.Append("yvfree4=:yvfree4,");
			strSql.Append("GPZL=:GPZL");
			strSql.Append(" where WGDH=:WGDH and PCH=:PCH and PH=:PH and GG=:GG and SCX=:SCX and WLH=:WLH ");
			SqlParameter[] parameters = {
					new SqlParameter(":BB", SqlDbType.VarChar,10),
					new SqlParameter(":NCWLBMID", SqlDbType.VarChar,20),
					new SqlParameter(":WLMC", SqlDbType.VarChar,100),
					new SqlParameter(":FZDW", SqlDbType.VarChar,10),
					new SqlParameter(":ZXBZ", SqlDbType.VarChar,40),
					new SqlParameter(":PCSX", SqlDbType.VarChar,30),
					new SqlParameter(":PCLX", SqlDbType.Int,4),
					new SqlParameter(":ZLDJ", SqlDbType.VarChar,10),
					new SqlParameter(":ZPGP", SqlDbType.VarChar,30),
					new SqlParameter(":PCXH", SqlDbType.Int,4),
					new SqlParameter(":WCBZ", SqlDbType.Int,4),
					new SqlParameter(":PGBZ", SqlDbType.Int,4),
					new SqlParameter(":ZJBZ", SqlDbType.Int,4),
					new SqlParameter(":ZPDJBZ", SqlDbType.Int,4),
					new SqlParameter(":Rev_Time", SqlDbType.DateTime),
					new SqlParameter(":End_Time", SqlDbType.DateTime),
					new SqlParameter(":PEnd_Time", SqlDbType.DateTime),
					new SqlParameter(":FEW_scx", SqlDbType.VarChar,10),
					new SqlParameter(":SendEnd", SqlDbType.Int,4),
					new SqlParameter(":IsTran", SqlDbType.Int,4),
					new SqlParameter(":YWLH", SqlDbType.VarChar,50),
					new SqlParameter(":YWLMC", SqlDbType.VarChar,50),
					new SqlParameter(":YPH", SqlDbType.VarChar,50),
					new SqlParameter(":YGG", SqlDbType.VarChar,50),
					new SqlParameter(":YZXBZ", SqlDbType.VarChar,50),
					new SqlParameter(":ZDR", SqlDbType.VarChar,20),
					new SqlParameter(":ZDDATE", SqlDbType.DateTime),
					new SqlParameter(":UPDATERY", SqlDbType.VarChar,20),
					new SqlParameter(":UPDATEDATE", SqlDbType.DateTime),
					new SqlParameter(":FLAG", SqlDbType.VarChar,10),
					new SqlParameter(":Filed1", SqlDbType.VarChar,50),
					new SqlParameter(":PCInfo", SqlDbType.VarChar,150),
					new SqlParameter(":Filed2", SqlDbType.VarChar,50),
					new SqlParameter(":SendBack", SqlDbType.Bit,1),
					new SqlParameter(":vfree0", SqlDbType.VarChar,50),
					new SqlParameter(":vfree1", SqlDbType.VarChar,50),
					new SqlParameter(":vfree2", SqlDbType.VarChar,50),
					new SqlParameter(":vfree3", SqlDbType.VarChar,50),
					new SqlParameter(":vfree4", SqlDbType.VarChar,50),
					new SqlParameter(":yvfree0", SqlDbType.VarChar,50),
					new SqlParameter(":yvfree1", SqlDbType.VarChar,50),
					new SqlParameter(":yvfree2", SqlDbType.VarChar,50),
					new SqlParameter(":yvfree3", SqlDbType.VarChar,50),
					new SqlParameter(":yvfree4", SqlDbType.VarChar,50),
					new SqlParameter(":GPZL", SqlDbType.Decimal,9),
					new SqlParameter(":WGDH", SqlDbType.VarChar,50),
					new SqlParameter(":PCH", SqlDbType.VarChar,20),
					new SqlParameter(":PH", SqlDbType.VarChar,30),
					new SqlParameter(":GG", SqlDbType.VarChar,30),
					new SqlParameter(":SCX", SqlDbType.VarChar,50),
					new SqlParameter(":WLH", SqlDbType.VarChar,20)};
			parameters[0].Value = model.BB;
			parameters[1].Value = model.NCWLBMID;
			parameters[2].Value = model.WLMC;
			parameters[3].Value = model.FZDW;
			parameters[4].Value = model.ZXBZ;
			parameters[5].Value = model.PCSX;
			parameters[6].Value = model.PCLX;
			parameters[7].Value = model.ZLDJ;
			parameters[8].Value = model.ZPGP;
			parameters[9].Value = model.PCXH;
			parameters[10].Value = model.WCBZ;
			parameters[11].Value = model.PGBZ;
			parameters[12].Value = model.ZJBZ;
			parameters[13].Value = model.ZPDJBZ;
			parameters[14].Value = model.Rev_Time;
			parameters[15].Value = model.End_Time;
			parameters[16].Value = model.PEnd_Time;
			parameters[17].Value = model.FEW_scx;
			parameters[18].Value = model.SendEnd;
			parameters[19].Value = model.IsTran;
			parameters[20].Value = model.YWLH;
			parameters[21].Value = model.YWLMC;
			parameters[22].Value = model.YPH;
			parameters[23].Value = model.YGG;
			parameters[24].Value = model.YZXBZ;
			parameters[25].Value = model.ZDR;
			parameters[26].Value = model.ZDDATE;
			parameters[27].Value = model.UPDATERY;
			parameters[28].Value = model.UPDATEDATE;
			parameters[29].Value = model.FLAG;
			parameters[30].Value = model.Filed1;
			parameters[31].Value = model.PCInfo;
			parameters[32].Value = model.Filed2;
			parameters[33].Value = model.SendBack;
			parameters[34].Value = model.vfree0;
			parameters[35].Value = model.vfree1;
			parameters[36].Value = model.vfree2;
			parameters[37].Value = model.vfree3;
			parameters[38].Value = model.vfree4;
			parameters[39].Value = model.yvfree0;
			parameters[40].Value = model.yvfree1;
			parameters[41].Value = model.yvfree2;
			parameters[42].Value = model.yvfree3;
			parameters[43].Value = model.yvfree4;
			parameters[44].Value = model.GPZL;
			parameters[45].Value = model.WGDH;
			parameters[46].Value = model.PCH;
			parameters[47].Value = model.PH;
			parameters[48].Value = model.GG;
			parameters[49].Value = model.SCX;
			parameters[50].Value = model.WLH;

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
		public bool Delete(string WGDH,string PCH,string PH,string GG,string SCX,string WLH)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from WMS_Bms_Rec_WGD ");
			strSql.Append(" where WGDH=:WGDH and PCH=:PCH and PH=:PH and GG=:GG and SCX=:SCX and WLH=:WLH ");
			SqlParameter[] parameters = {
					new SqlParameter(":WGDH", SqlDbType.VarChar,50),
					new SqlParameter(":PCH", SqlDbType.VarChar,20),
					new SqlParameter(":PH", SqlDbType.VarChar,30),
					new SqlParameter(":GG", SqlDbType.VarChar,30),
					new SqlParameter(":SCX", SqlDbType.VarChar,50),
					new SqlParameter(":WLH", SqlDbType.VarChar,20)			};
			parameters[0].Value = WGDH;
			parameters[1].Value = PCH;
			parameters[2].Value = PH;
			parameters[3].Value = GG;
			parameters[4].Value = SCX;
			parameters[5].Value = WLH;

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
		public Mod_WMS_Bms_Rec_WGD GetModel(string WGDH,string PCH,string PH,string GG,string SCX,string WLH)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 WGDH,PCH,PH,GG,BB,SCX,NCWLBMID,WLH,WLMC,FZDW,ZXBZ,PCSX,PCLX,ZLDJ,ZPGP,PCXH,WCBZ,PGBZ,ZJBZ,ZPDJBZ,Rev_Time,End_Time,PEnd_Time,FEW_scx,SendEnd,IsTran,YWLH,YWLMC,YPH,YGG,YZXBZ,ZDR,ZDDATE,UPDATERY,UPDATEDATE,FLAG,Filed1,PCInfo,Filed2,SendBack,vfree0,vfree1,vfree2,vfree3,vfree4,yvfree0,yvfree1,yvfree2,yvfree3,yvfree4,GPZL from WMS_Bms_Rec_WGD ");
			strSql.Append(" where WGDH=:WGDH and PCH=:PCH and PH=:PH and GG=:GG and SCX=:SCX and WLH=:WLH ");
			SqlParameter[] parameters = {
					new SqlParameter(":WGDH", SqlDbType.VarChar,50),
					new SqlParameter(":PCH", SqlDbType.VarChar,20),
					new SqlParameter(":PH", SqlDbType.VarChar,30),
					new SqlParameter(":GG", SqlDbType.VarChar,30),
					new SqlParameter(":SCX", SqlDbType.VarChar,50),
					new SqlParameter(":WLH", SqlDbType.VarChar,20)			};
			parameters[0].Value = WGDH;
			parameters[1].Value = PCH;
			parameters[2].Value = PH;
			parameters[3].Value = GG;
			parameters[4].Value = SCX;
			parameters[5].Value = WLH;

			Mod_WMS_Bms_Rec_WGD model=new Mod_WMS_Bms_Rec_WGD();
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
		public Mod_WMS_Bms_Rec_WGD DataRowToModel(DataRow row)
		{
			Mod_WMS_Bms_Rec_WGD model=new Mod_WMS_Bms_Rec_WGD();
			if (row != null)
			{
				if(row["WGDH"]!=null)
				{
					model.WGDH=row["WGDH"].ToString();
				}
				if(row["PCH"]!=null)
				{
					model.PCH=row["PCH"].ToString();
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
				if(row["SCX"]!=null)
				{
					model.SCX=row["SCX"].ToString();
				}
				if(row["NCWLBMID"]!=null)
				{
					model.NCWLBMID=row["NCWLBMID"].ToString();
				}
				if(row["WLH"]!=null)
				{
					model.WLH=row["WLH"].ToString();
				}
				if(row["WLMC"]!=null)
				{
					model.WLMC=row["WLMC"].ToString();
				}
				if(row["FZDW"]!=null)
				{
					model.FZDW=row["FZDW"].ToString();
				}
				if(row["ZXBZ"]!=null)
				{
					model.ZXBZ=row["ZXBZ"].ToString();
				}
				if(row["PCSX"]!=null)
				{
					model.PCSX=row["PCSX"].ToString();
				}
				if(row["PCLX"]!=null && row["PCLX"].ToString()!="")
				{
					model.PCLX=int.Parse(row["PCLX"].ToString());
				}
				if(row["ZLDJ"]!=null)
				{
					model.ZLDJ=row["ZLDJ"].ToString();
				}
				if(row["ZPGP"]!=null)
				{
					model.ZPGP=row["ZPGP"].ToString();
				}
				if(row["PCXH"]!=null && row["PCXH"].ToString()!="")
				{
					model.PCXH=int.Parse(row["PCXH"].ToString());
				}
				if(row["WCBZ"]!=null && row["WCBZ"].ToString()!="")
				{
					model.WCBZ=int.Parse(row["WCBZ"].ToString());
				}
				if(row["PGBZ"]!=null && row["PGBZ"].ToString()!="")
				{
					model.PGBZ=int.Parse(row["PGBZ"].ToString());
				}
				if(row["ZJBZ"]!=null && row["ZJBZ"].ToString()!="")
				{
					model.ZJBZ=int.Parse(row["ZJBZ"].ToString());
				}
				if(row["ZPDJBZ"]!=null && row["ZPDJBZ"].ToString()!="")
				{
					model.ZPDJBZ=int.Parse(row["ZPDJBZ"].ToString());
				}
				if(row["Rev_Time"]!=null && row["Rev_Time"].ToString()!="")
				{
					model.Rev_Time=DateTime.Parse(row["Rev_Time"].ToString());
				}
				if(row["End_Time"]!=null && row["End_Time"].ToString()!="")
				{
					model.End_Time=DateTime.Parse(row["End_Time"].ToString());
				}
				if(row["PEnd_Time"]!=null && row["PEnd_Time"].ToString()!="")
				{
					model.PEnd_Time=DateTime.Parse(row["PEnd_Time"].ToString());
				}
				if(row["FEW_scx"]!=null)
				{
					model.FEW_scx=row["FEW_scx"].ToString();
				}
				if(row["SendEnd"]!=null && row["SendEnd"].ToString()!="")
				{
					model.SendEnd=int.Parse(row["SendEnd"].ToString());
				}
				if(row["IsTran"]!=null && row["IsTran"].ToString()!="")
				{
					model.IsTran=int.Parse(row["IsTran"].ToString());
				}
				if(row["YWLH"]!=null)
				{
					model.YWLH=row["YWLH"].ToString();
				}
				if(row["YWLMC"]!=null)
				{
					model.YWLMC=row["YWLMC"].ToString();
				}
				if(row["YPH"]!=null)
				{
					model.YPH=row["YPH"].ToString();
				}
				if(row["YGG"]!=null)
				{
					model.YGG=row["YGG"].ToString();
				}
				if(row["YZXBZ"]!=null)
				{
					model.YZXBZ=row["YZXBZ"].ToString();
				}
				if(row["ZDR"]!=null)
				{
					model.ZDR=row["ZDR"].ToString();
				}
				if(row["ZDDATE"]!=null && row["ZDDATE"].ToString()!="")
				{
					model.ZDDATE=DateTime.Parse(row["ZDDATE"].ToString());
				}
				if(row["UPDATERY"]!=null)
				{
					model.UPDATERY=row["UPDATERY"].ToString();
				}
				if(row["UPDATEDATE"]!=null && row["UPDATEDATE"].ToString()!="")
				{
					model.UPDATEDATE=DateTime.Parse(row["UPDATEDATE"].ToString());
				}
				if(row["FLAG"]!=null)
				{
					model.FLAG=row["FLAG"].ToString();
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
				if(row["SendBack"]!=null && row["SendBack"].ToString()!="")
				{
					if((row["SendBack"].ToString()=="1")||(row["SendBack"].ToString().ToLower()=="true"))
					{
						model.SendBack=true;
					}
					else
					{
						model.SendBack=false;
					}
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
				if(row["yvfree0"]!=null)
				{
					model.yvfree0=row["yvfree0"].ToString();
				}
				if(row["yvfree1"]!=null)
				{
					model.yvfree1=row["yvfree1"].ToString();
				}
				if(row["yvfree2"]!=null)
				{
					model.yvfree2=row["yvfree2"].ToString();
				}
				if(row["yvfree3"]!=null)
				{
					model.yvfree3=row["yvfree3"].ToString();
				}
				if(row["yvfree4"]!=null)
				{
					model.yvfree4=row["yvfree4"].ToString();
				}
				if(row["GPZL"]!=null && row["GPZL"].ToString()!="")
				{
					model.GPZL=decimal.Parse(row["GPZL"].ToString());
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
			strSql.Append("select WGDH,PCH,PH,GG,BB,SCX,NCWLBMID,WLH,WLMC,FZDW,ZXBZ,PCSX,PCLX,ZLDJ,ZPGP,PCXH,WCBZ,PGBZ,ZJBZ,ZPDJBZ,Rev_Time,End_Time,PEnd_Time,FEW_scx,SendEnd,IsTran,YWLH,YWLMC,YPH,YGG,YZXBZ,ZDR,ZDDATE,UPDATERY,UPDATEDATE,FLAG,Filed1,PCInfo,Filed2,SendBack,vfree0,vfree1,vfree2,vfree3,vfree4,yvfree0,yvfree1,yvfree2,yvfree3,yvfree4,GPZL ");
			strSql.Append(" FROM WMS_Bms_Rec_WGD ");
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
			strSql.Append(" WGDH,PCH,PH,GG,BB,SCX,NCWLBMID,WLH,WLMC,FZDW,ZXBZ,PCSX,PCLX,ZLDJ,ZPGP,PCXH,WCBZ,PGBZ,ZJBZ,ZPDJBZ,Rev_Time,End_Time,PEnd_Time,FEW_scx,SendEnd,IsTran,YWLH,YWLMC,YPH,YGG,YZXBZ,ZDR,ZDDATE,UPDATERY,UPDATEDATE,FLAG,Filed1,PCInfo,Filed2,SendBack,vfree0,vfree1,vfree2,vfree3,vfree4,yvfree0,yvfree1,yvfree2,yvfree3,yvfree4,GPZL ");
			strSql.Append(" FROM WMS_Bms_Rec_WGD ");
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
			strSql.Append("select count(1) FROM WMS_Bms_Rec_WGD ");
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
			strSql.Append(")AS Row, T.*  from WMS_Bms_Rec_WGD T ");
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

