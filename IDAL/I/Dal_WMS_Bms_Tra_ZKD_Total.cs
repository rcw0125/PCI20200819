using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;
using System.Data.SqlClient;

namespace IDAL
{
	/// <summary>
	/// 数据访问类:WMS_Bms_Tra_ZKD_Total
	/// </summary>
	public partial class Dal_WMS_Bms_Tra_ZKD_Total
    {
		public Dal_WMS_Bms_Tra_ZKD_Total()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string ZKDH,string PCH,string SX,string CPH)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from WMS_Bms_Tra_ZKD_Total");
			strSql.Append(" where ZKDH=:ZKDH and PCH=:PCH and SX=:SX and CPH=:CPH ");
			SqlParameter[] parameters = {
					new SqlParameter(":ZKDH", SqlDbType.VarChar,50),
					new SqlParameter(":PCH", SqlDbType.VarChar,20),
					new SqlParameter(":SX", SqlDbType.VarChar,30),
					new SqlParameter(":CPH", SqlDbType.VarChar,30)			};
			parameters[0].Value = ZKDH;
			parameters[1].Value = PCH;
			parameters[2].Value = SX;
			parameters[3].Value = CPH;

			return DbHelper_SQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Mod_WMS_Bms_Tra_ZKD_Total model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into WMS_Bms_Tra_ZKD_Total(");
			strSql.Append("ZKDH,PCH,SX,CPH,CKNUM,RKNUM,CKOperator,CKTime,YKOperator,YKTime)");
			strSql.Append(" values (");
			strSql.Append(":ZKDH,:PCH,:SX,:CPH,:CKNUM,:RKNUM,:CKOperator,:CKTime,:YKOperator,:YKTime)");
			SqlParameter[] parameters = {
					new SqlParameter(":ZKDH", SqlDbType.VarChar,50),
					new SqlParameter(":PCH", SqlDbType.VarChar,20),
					new SqlParameter(":SX", SqlDbType.VarChar,30),
					new SqlParameter(":CPH", SqlDbType.VarChar,30),
					new SqlParameter(":CKNUM", SqlDbType.Int,4),
					new SqlParameter(":RKNUM", SqlDbType.Int,4),
					new SqlParameter(":CKOperator", SqlDbType.VarChar,20),
					new SqlParameter(":CKTime", SqlDbType.DateTime),
					new SqlParameter(":YKOperator", SqlDbType.VarChar,20),
					new SqlParameter(":YKTime", SqlDbType.DateTime)};
			parameters[0].Value = model.ZKDH;
			parameters[1].Value = model.PCH;
			parameters[2].Value = model.SX;
			parameters[3].Value = model.CPH;
			parameters[4].Value = model.CKNUM;
			parameters[5].Value = model.RKNUM;
			parameters[6].Value = model.CKOperator;
			parameters[7].Value = model.CKTime;
			parameters[8].Value = model.YKOperator;
			parameters[9].Value = model.YKTime;

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
		public bool Update(Mod_WMS_Bms_Tra_ZKD_Total model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update WMS_Bms_Tra_ZKD_Total set ");
			strSql.Append("CKNUM=:CKNUM,");
			strSql.Append("RKNUM=:RKNUM,");
			strSql.Append("CKOperator=:CKOperator,");
			strSql.Append("CKTime=:CKTime,");
			strSql.Append("YKOperator=:YKOperator,");
			strSql.Append("YKTime=:YKTime");
			strSql.Append(" where ZKDH=:ZKDH and PCH=:PCH and SX=:SX and CPH=:CPH ");
			SqlParameter[] parameters = {
					new SqlParameter(":CKNUM", SqlDbType.Int,4),
					new SqlParameter(":RKNUM", SqlDbType.Int,4),
					new SqlParameter(":CKOperator", SqlDbType.VarChar,20),
					new SqlParameter(":CKTime", SqlDbType.DateTime),
					new SqlParameter(":YKOperator", SqlDbType.VarChar,20),
					new SqlParameter(":YKTime", SqlDbType.DateTime),
					new SqlParameter(":ZKDH", SqlDbType.VarChar,50),
					new SqlParameter(":PCH", SqlDbType.VarChar,20),
					new SqlParameter(":SX", SqlDbType.VarChar,30),
					new SqlParameter(":CPH", SqlDbType.VarChar,30)};
			parameters[0].Value = model.CKNUM;
			parameters[1].Value = model.RKNUM;
			parameters[2].Value = model.CKOperator;
			parameters[3].Value = model.CKTime;
			parameters[4].Value = model.YKOperator;
			parameters[5].Value = model.YKTime;
			parameters[6].Value = model.ZKDH;
			parameters[7].Value = model.PCH;
			parameters[8].Value = model.SX;
			parameters[9].Value = model.CPH;

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
		public bool Delete(string ZKDH,string PCH,string SX,string CPH)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from WMS_Bms_Tra_ZKD_Total ");
			strSql.Append(" where ZKDH=:ZKDH and PCH=:PCH and SX=:SX and CPH=:CPH ");
			SqlParameter[] parameters = {
					new SqlParameter(":ZKDH", SqlDbType.VarChar,50),
					new SqlParameter(":PCH", SqlDbType.VarChar,20),
					new SqlParameter(":SX", SqlDbType.VarChar,30),
					new SqlParameter(":CPH", SqlDbType.VarChar,30)			};
			parameters[0].Value = ZKDH;
			parameters[1].Value = PCH;
			parameters[2].Value = SX;
			parameters[3].Value = CPH;

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
		public Mod_WMS_Bms_Tra_ZKD_Total GetModel(string ZKDH,string PCH,string SX,string CPH)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ZKDH,PCH,SX,CPH,CKNUM,RKNUM,CKOperator,CKTime,YKOperator,YKTime from WMS_Bms_Tra_ZKD_Total ");
			strSql.Append(" where ZKDH=:ZKDH and PCH=:PCH and SX=:SX and CPH=:CPH ");
			SqlParameter[] parameters = {
					new SqlParameter(":ZKDH", SqlDbType.VarChar,50),
					new SqlParameter(":PCH", SqlDbType.VarChar,20),
					new SqlParameter(":SX", SqlDbType.VarChar,30),
					new SqlParameter(":CPH", SqlDbType.VarChar,30)			};
			parameters[0].Value = ZKDH;
			parameters[1].Value = PCH;
			parameters[2].Value = SX;
			parameters[3].Value = CPH;

			Mod_WMS_Bms_Tra_ZKD_Total model=new Mod_WMS_Bms_Tra_ZKD_Total();
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
		public Mod_WMS_Bms_Tra_ZKD_Total DataRowToModel(DataRow row)
		{
			Mod_WMS_Bms_Tra_ZKD_Total model=new Mod_WMS_Bms_Tra_ZKD_Total();
			if (row != null)
			{
				if(row["ZKDH"]!=null)
				{
					model.ZKDH=row["ZKDH"].ToString();
				}
				if(row["PCH"]!=null)
				{
					model.PCH=row["PCH"].ToString();
				}
				if(row["SX"]!=null)
				{
					model.SX=row["SX"].ToString();
				}
				if(row["CPH"]!=null)
				{
					model.CPH=row["CPH"].ToString();
				}
				if(row["CKNUM"]!=null && row["CKNUM"].ToString()!="")
				{
					model.CKNUM=int.Parse(row["CKNUM"].ToString());
				}
				if(row["RKNUM"]!=null && row["RKNUM"].ToString()!="")
				{
					model.RKNUM=int.Parse(row["RKNUM"].ToString());
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
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ZKDH,PCH,SX,CPH,CKNUM,RKNUM,CKOperator,CKTime,YKOperator,YKTime ");
			strSql.Append(" FROM WMS_Bms_Tra_ZKD_Total ");
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
			strSql.Append(" ZKDH,PCH,SX,CPH,CKNUM,RKNUM,CKOperator,CKTime,YKOperator,YKTime ");
			strSql.Append(" FROM WMS_Bms_Tra_ZKD_Total ");
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
			strSql.Append("select count(1) FROM WMS_Bms_Tra_ZKD_Total ");
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
				strSql.Append("order by T.CPH desc");
			}
			strSql.Append(")AS Row, T.*  from WMS_Bms_Tra_ZKD_Total T ");
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

