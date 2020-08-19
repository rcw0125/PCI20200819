using System;
using System.Data;
using System.Text;
using MODEL;
using System.Data.SqlClient;

namespace IDAL
{
    /// <summary>
    /// 数据访问类:ReZJB_GPD
    /// </summary>
    public partial class Dal_ReZJB_GPD
	{
		public Dal_ReZJB_GPD()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelper_SQL.GetMaxID("pk_ZJB_GPD", "ReZJB_GPD"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int pk_ZJB_GPD)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from ReZJB_GPD");
			strSql.Append(" where pk_ZJB_GPD=@pk_ZJB_GPD");
			SqlParameter[] parameters = {
					new SqlParameter("@pk_ZJB_GPD", SqlDbType.Int,4)
			};
			parameters[0].Value = pk_ZJB_GPD;

			return DbHelper_SQL.Exists(strSql.ToString(),parameters);
		}


        ///// <summary>
        ///// 增加一条数据
        ///// </summary>
        public int Add(Mod_ReZJB_GPD model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into ReZJB_GPD(");
            strSql.Append("Barcode,WGDH,CK,HW,PCH,WLH,WLMC,SX,ZLDJ,PH,GG,BB,GH,ZL,BZ,RQ,RKType,RKRY,WeightRQ,CKCXH,ProduceData,PCInfo,Filed1,ErrSeason,Filed2,vfree0,vfree1,vfree2,vfree3,vfree4,GPTYPE,ZJBStatus,CAPPK)");
            strSql.Append(" values (");
            strSql.Append("@Barcode,@WGDH,@CK,@HW,@PCH,@WLH,@WLMC,@SX,@ZLDJ,@PH,@GG,@BB,@GH,@ZL,@BZ,@RQ,@RKType,@RKRY,@WeightRQ,@CKCXH,@ProduceData,@PCInfo,@Filed1,@ErrSeason,@Filed2,@vfree0,@vfree1,@vfree2,@vfree3,@vfree4,@GPTYPE,@ZJBStatus,@CAPPK)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
                    new SqlParameter("@Barcode", SqlDbType.VarChar,20),
                    new SqlParameter("@WGDH", SqlDbType.VarChar,50),
                    new SqlParameter("@CK", SqlDbType.VarChar,30),
                    new SqlParameter("@HW", SqlDbType.VarChar,20),
                    new SqlParameter("@PCH", SqlDbType.VarChar,20),
                    new SqlParameter("@WLH", SqlDbType.VarChar,20),
                    new SqlParameter("@WLMC", SqlDbType.VarChar,100),
                    new SqlParameter("@SX", SqlDbType.VarChar,30),
                    new SqlParameter("@ZLDJ", SqlDbType.VarChar,10),
                    new SqlParameter("@PH", SqlDbType.VarChar,30),
                    new SqlParameter("@GG", SqlDbType.VarChar,30),
                    new SqlParameter("@BB", SqlDbType.VarChar,10),
                    new SqlParameter("@GH", SqlDbType.Int,4),
                    new SqlParameter("@ZL", SqlDbType.Decimal,9),
                    new SqlParameter("@BZ", SqlDbType.VarChar,50),
                    new SqlParameter("@RQ", SqlDbType.DateTime),
                    new SqlParameter("@RKType", SqlDbType.VarChar,20),
                    new SqlParameter("@RKRY", SqlDbType.VarChar,20),
                    new SqlParameter("@WeightRQ", SqlDbType.DateTime),
                    new SqlParameter("@CKCXH", SqlDbType.Int,4),
                    new SqlParameter("@ProduceData", SqlDbType.VarChar,20),
                    new SqlParameter("@PCInfo", SqlDbType.VarChar,150),
                    new SqlParameter("@Filed1", SqlDbType.VarChar,50),
                    new SqlParameter("@ErrSeason", SqlDbType.VarChar,50),
                    new SqlParameter("@Filed2", SqlDbType.VarChar,50),
                    new SqlParameter("@vfree0", SqlDbType.VarChar,300),
                    new SqlParameter("@vfree1", SqlDbType.VarChar,50),
                    new SqlParameter("@vfree2", SqlDbType.VarChar,50),
                    new SqlParameter("@vfree3", SqlDbType.VarChar,50),
                    new SqlParameter("@vfree4", SqlDbType.VarChar,50),
                    new SqlParameter("@GPTYPE", SqlDbType.VarChar,50),
                    new SqlParameter("@ZJBStatus", SqlDbType.Int,4),
                    new SqlParameter("@CAPPK", SqlDbType.VarChar,50)};
            parameters[0].Value = model.Barcode;
            parameters[1].Value = model.WGDH;
            parameters[2].Value = model.CK;
            parameters[3].Value = model.HW;
            parameters[4].Value = model.PCH;
            parameters[5].Value = model.WLH;
            parameters[6].Value = model.WLMC;
            parameters[7].Value = model.SX;
            parameters[8].Value = model.ZLDJ;
            parameters[9].Value = model.PH;
            parameters[10].Value = model.GG;
            parameters[11].Value = model.BB;
            parameters[12].Value = model.GH;
            parameters[13].Value = model.ZL;
            parameters[14].Value = model.BZ;
            parameters[15].Value = model.RQ;
            parameters[16].Value = model.RKType;
            parameters[17].Value = model.RKRY;
            parameters[18].Value = model.WeightRQ;
            parameters[19].Value = model.CKCXH;
            parameters[20].Value = model.ProduceData;
            parameters[21].Value = model.PCInfo;
            parameters[22].Value = model.Filed1;
            parameters[23].Value = model.ErrSeason;
            parameters[24].Value = model.Filed2;
            parameters[25].Value = model.vfree0;
            parameters[26].Value = model.vfree1;
            parameters[27].Value = model.vfree2;
            parameters[28].Value = model.vfree3;
            parameters[29].Value = model.vfree4;
            parameters[30].Value = model.GPTYPE;
            parameters[31].Value = model.ZJBStatus;
            parameters[32].Value = model.CAPPK;

            object obj = DbHelper_SQL.GetSingle(strSql.ToString(), parameters);
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
        public bool Update(Mod_ReZJB_GPD model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update ReZJB_GPD set ");
			strSql.Append("Barcode=@Barcode,");
			strSql.Append("WGDH=@WGDH,");
			strSql.Append("CK=@CK,");
			strSql.Append("HW=@HW,");
			strSql.Append("PCH=@PCH,");
			strSql.Append("WLH=@WLH,");
			strSql.Append("WLMC=@WLMC,");
			strSql.Append("SX=@SX,");
			strSql.Append("ZLDJ=@ZLDJ,");
			strSql.Append("PH=@PH,");
			strSql.Append("GG=@GG,");
			strSql.Append("BB=@BB,");
			strSql.Append("GH=@GH,");
			strSql.Append("ZL=@ZL,");
			strSql.Append("BZ=@BZ,");
			strSql.Append("RQ=@RQ,");
			strSql.Append("RKType=@RKType,");
			strSql.Append("RKRY=@RKRY,");
			strSql.Append("WeightRQ=@WeightRQ,");
			strSql.Append("CKCXH=@CKCXH,");
			strSql.Append("ProduceData=@ProduceData,");
			strSql.Append("PCInfo=@PCInfo,");
			strSql.Append("Filed1=@Filed1,");
			strSql.Append("ErrSeason=@ErrSeason,");
			strSql.Append("Filed2=@Filed2,");
			strSql.Append("vfree0=@vfree0,");
			strSql.Append("vfree1=@vfree1,");
			strSql.Append("vfree2=@vfree2,");
			strSql.Append("vfree3=@vfree3,");
			strSql.Append("vfree4=@vfree4,");
			strSql.Append("GPTYPE=@GPTYPE,");
			strSql.Append("ZJBStatus=@ZJBStatus,");
			strSql.Append("CAPPK=@CAPPK");
			strSql.Append(" where pk_ZJB_GPD=@pk_ZJB_GPD");
			SqlParameter[] parameters = {
					new SqlParameter("@Barcode", SqlDbType.VarChar,20),
					new SqlParameter("@WGDH", SqlDbType.VarChar,50),
					new SqlParameter("@CK", SqlDbType.VarChar,30),
					new SqlParameter("@HW", SqlDbType.VarChar,20),
					new SqlParameter("@PCH", SqlDbType.VarChar,20),
					new SqlParameter("@WLH", SqlDbType.VarChar,20),
					new SqlParameter("@WLMC", SqlDbType.VarChar,100),
					new SqlParameter("@SX", SqlDbType.VarChar,30),
					new SqlParameter("@ZLDJ", SqlDbType.VarChar,10),
					new SqlParameter("@PH", SqlDbType.VarChar,30),
					new SqlParameter("@GG", SqlDbType.VarChar,30),
					new SqlParameter("@BB", SqlDbType.VarChar,10),
					new SqlParameter("@GH", SqlDbType.Int,4),
					new SqlParameter("@ZL", SqlDbType.Decimal,9),
					new SqlParameter("@BZ", SqlDbType.VarChar,50),
					new SqlParameter("@RQ", SqlDbType.DateTime),
					new SqlParameter("@RKType", SqlDbType.VarChar,20),
					new SqlParameter("@RKRY", SqlDbType.VarChar,20),
					new SqlParameter("@WeightRQ", SqlDbType.DateTime),
					new SqlParameter("@CKCXH", SqlDbType.Int,4),
					new SqlParameter("@ProduceData", SqlDbType.VarChar,20),
					new SqlParameter("@PCInfo", SqlDbType.VarChar,150),
					new SqlParameter("@Filed1", SqlDbType.VarChar,50),
					new SqlParameter("@ErrSeason", SqlDbType.VarChar,50),
					new SqlParameter("@Filed2", SqlDbType.VarChar,50),
					new SqlParameter("@vfree0", SqlDbType.VarChar,300),
					new SqlParameter("@vfree1", SqlDbType.VarChar,50),
					new SqlParameter("@vfree2", SqlDbType.VarChar,50),
					new SqlParameter("@vfree3", SqlDbType.VarChar,50),
					new SqlParameter("@vfree4", SqlDbType.VarChar,50),
					new SqlParameter("@GPTYPE", SqlDbType.VarChar,50),
					new SqlParameter("@ZJBStatus", SqlDbType.Int,4),
					new SqlParameter("@CAPPK", SqlDbType.VarChar,50),
					new SqlParameter("@pk_ZJB_GPD", SqlDbType.Int,4)};
			parameters[0].Value = model.Barcode;
			parameters[1].Value = model.WGDH;
			parameters[2].Value = model.CK;
			parameters[3].Value = model.HW;
			parameters[4].Value = model.PCH;
			parameters[5].Value = model.WLH;
			parameters[6].Value = model.WLMC;
			parameters[7].Value = model.SX;
			parameters[8].Value = model.ZLDJ;
			parameters[9].Value = model.PH;
			parameters[10].Value = model.GG;
			parameters[11].Value = model.BB;
			parameters[12].Value = model.GH;
			parameters[13].Value = model.ZL;
			parameters[14].Value = model.BZ;
			parameters[15].Value = model.RQ;
			parameters[16].Value = model.RKType;
			parameters[17].Value = model.RKRY;
			parameters[18].Value = model.WeightRQ;
			parameters[19].Value = model.CKCXH;
			parameters[20].Value = model.ProduceData;
			parameters[21].Value = model.PCInfo;
			parameters[22].Value = model.Filed1;
			parameters[23].Value = model.ErrSeason;
			parameters[24].Value = model.Filed2;
			parameters[25].Value = model.vfree0;
			parameters[26].Value = model.vfree1;
			parameters[27].Value = model.vfree2;
			parameters[28].Value = model.vfree3;
			parameters[29].Value = model.vfree4;
			parameters[30].Value = model.GPTYPE;
			parameters[31].Value = model.ZJBStatus;
			parameters[32].Value = model.CAPPK;
			parameters[33].Value = model.pk_ZJB_GPD;

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
		public bool Delete(int pk_ZJB_GPD)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ReZJB_GPD ");
			strSql.Append(" where pk_ZJB_GPD=@pk_ZJB_GPD");
			SqlParameter[] parameters = {
					new SqlParameter("@pk_ZJB_GPD", SqlDbType.Int,4)
			};
			parameters[0].Value = pk_ZJB_GPD;

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
		public bool DeleteList(string pk_ZJB_GPDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ReZJB_GPD ");
			strSql.Append(" where pk_ZJB_GPD in ("+pk_ZJB_GPDlist + ")  ");
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
		public Mod_ReZJB_GPD GetModel(int pk_ZJB_GPD)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 Barcode,WGDH,CK,HW,PCH,WLH,WLMC,SX,ZLDJ,PH,GG,BB,GH,ZL,BZ,RQ,RKType,RKRY,WeightRQ,CKCXH,ProduceData,PCInfo,Filed1,ErrSeason,Filed2,vfree0,vfree1,vfree2,vfree3,vfree4,pk_ZJB_GPD,GPTYPE,ZJBStatus,CAPPK from ReZJB_GPD ");
			strSql.Append(" where pk_ZJB_GPD=@pk_ZJB_GPD");
			SqlParameter[] parameters = {
					new SqlParameter("@pk_ZJB_GPD", SqlDbType.Int,4)
			};
			parameters[0].Value = pk_ZJB_GPD;

			Mod_ReZJB_GPD model=new Mod_ReZJB_GPD();
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
		public Mod_ReZJB_GPD DataRowToModel(DataRow row)
		{
			Mod_ReZJB_GPD model=new Mod_ReZJB_GPD();
			if (row != null)
			{
				if(row["Barcode"]!=null)
				{
					model.Barcode=row["Barcode"].ToString();
				}
				if(row["WGDH"]!=null)
				{
					model.WGDH=row["WGDH"].ToString();
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
				if(row["RKType"]!=null)
				{
					model.RKType=row["RKType"].ToString();
				}
				if(row["RKRY"]!=null)
				{
					model.RKRY=row["RKRY"].ToString();
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
				if(row["PCInfo"]!=null)
				{
					model.PCInfo=row["PCInfo"].ToString();
				}
				if(row["Filed1"]!=null)
				{
					model.Filed1=row["Filed1"].ToString();
				}
				if(row["ErrSeason"]!=null)
				{
					model.ErrSeason=row["ErrSeason"].ToString();
				}
				if(row["Filed2"]!=null)
				{
					model.Filed2=row["Filed2"].ToString();
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
				if(row["pk_ZJB_GPD"]!=null && row["pk_ZJB_GPD"].ToString()!="")
				{
					model.pk_ZJB_GPD=int.Parse(row["pk_ZJB_GPD"].ToString());
				}
				if(row["GPTYPE"]!=null)
				{
					model.GPTYPE=row["GPTYPE"].ToString();
				}
				if(row["ZJBStatus"]!=null && row["ZJBStatus"].ToString()!="")
				{
					model.ZJBStatus=int.Parse(row["ZJBStatus"].ToString());
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
			strSql.Append("select Barcode,WGDH,CK,HW,PCH,WLH,WLMC,SX,ZLDJ,PH,GG,BB,GH,ZL,BZ,RQ,RKType,RKRY,WeightRQ,CKCXH,ProduceData,PCInfo,Filed1,ErrSeason,Filed2,vfree0,vfree1,vfree2,vfree3,vfree4,pk_ZJB_GPD,GPTYPE,ZJBStatus,CAPPK ");
			strSql.Append(" FROM ReZJB_GPD ");
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
			strSql.Append(" Barcode,WGDH,CK,HW,PCH,WLH,WLMC,SX,ZLDJ,PH,GG,BB,GH,ZL,BZ,RQ,RKType,RKRY,WeightRQ,CKCXH,ProduceData,PCInfo,Filed1,ErrSeason,Filed2,vfree0,vfree1,vfree2,vfree3,vfree4,pk_ZJB_GPD,GPTYPE,ZJBStatus,CAPPK ");
			strSql.Append(" FROM ReZJB_GPD ");
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
			strSql.Append("select count(1) FROM ReZJB_GPD ");
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
				strSql.Append("order by T.pk_ZJB_GPD desc");
			}
			strSql.Append(")AS Row, T.*  from ReZJB_GPD T ");
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
			parameters[0].Value = "ReZJB_GPD";
			parameters[1].Value = "pk_ZJB_GPD";
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

