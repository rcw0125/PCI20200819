using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;
namespace DAL
{
	/// <summary>
	/// 数据访问类:TB_REHEATING_FURNACE
	/// </summary>
	public partial class Dal_TB_REHEATING_FURNACE
    {
		public Dal_TB_REHEATING_FURNACE()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string C_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from TB_REHEATING_FURNACE");
			strSql.Append(" where C_ID=:C_ID ");
			OracleParameter[] parameters = {
					new OracleParameter(":C_ID", OracleDbType.Varchar2,50)			};
			parameters[0].Value = C_ID;

			return DbHelperOra.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Mod_TB_REHEATING_FURNACE model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into TB_REHEATING_FURNACE(");
			strSql.Append("C_TYPE,N_HOUR,C_STL_GRD,C_STD_CODE,C_ZL_TYPE,D_MOD_DT,C_EMP_ID,C_BY1,C_BY2,C_BY3,C_BY4,C_BY5,C_BY6)");
			strSql.Append(" values (");
			strSql.Append(":C_TYPE,:N_HOUR,:C_STL_GRD,:C_STD_CODE,:C_ZL_TYPE,:D_MOD_DT,:C_EMP_ID,:C_BY1,:C_BY2,:C_BY3,:C_BY4,:C_BY5,:C_BY6)");
			OracleParameter[] parameters = {
					new OracleParameter(":C_TYPE", OracleDbType.Varchar2,50),
					new OracleParameter(":N_HOUR", OracleDbType.Decimal,4),
					new OracleParameter(":C_STL_GRD", OracleDbType.Varchar2,50),
					new OracleParameter(":C_STD_CODE", OracleDbType.Varchar2,50),
					new OracleParameter(":C_ZL_TYPE", OracleDbType.Varchar2,50),
					new OracleParameter(":D_MOD_DT", OracleDbType.Date),
					new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
					new OracleParameter(":C_BY1", OracleDbType.Varchar2,1000),
					new OracleParameter(":C_BY2", OracleDbType.Varchar2,1000),
					new OracleParameter(":C_BY3", OracleDbType.Varchar2,1000),
					new OracleParameter(":C_BY4", OracleDbType.Varchar2,1000),
					new OracleParameter(":C_BY5", OracleDbType.Varchar2,1000),
					new OracleParameter(":C_BY6", OracleDbType.Varchar2,1000)};
			parameters[0].Value = model.C_TYPE;
			parameters[1].Value = model.N_HOUR;
			parameters[2].Value = model.C_STL_GRD;
			parameters[3].Value = model.C_STD_CODE;
			parameters[4].Value = model.C_ZL_TYPE;
			parameters[5].Value = model.D_MOD_DT;
			parameters[6].Value = model.C_EMP_ID;
			parameters[7].Value = model.C_BY1;
			parameters[8].Value = model.C_BY2;
			parameters[9].Value = model.C_BY3;
			parameters[10].Value = model.C_BY4;
			parameters[11].Value = model.C_BY5;
			parameters[12].Value = model.C_BY6;

			int rows=DbHelperOra.ExecuteSql(strSql.ToString(),parameters);
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
		public bool Update(Mod_TB_REHEATING_FURNACE model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update TB_REHEATING_FURNACE set ");
			strSql.Append("C_TYPE=:C_TYPE,");
			strSql.Append("N_HOUR=:N_HOUR,");
			strSql.Append("C_STL_GRD=:C_STL_GRD,");
			strSql.Append("C_STD_CODE=:C_STD_CODE,");
			strSql.Append("C_ZL_TYPE=:C_ZL_TYPE,");
			strSql.Append("D_MOD_DT=:D_MOD_DT,");
			strSql.Append("C_EMP_ID=:C_EMP_ID,");
			strSql.Append("C_BY1=:C_BY1,");
			strSql.Append("C_BY2=:C_BY2,");
			strSql.Append("C_BY3=:C_BY3,");
			strSql.Append("C_BY4=:C_BY4,");
			strSql.Append("C_BY5=:C_BY5,");
			strSql.Append("C_BY6=:C_BY6");
			strSql.Append(" where C_ID=:C_ID ");
			OracleParameter[] parameters = {
					new OracleParameter(":C_TYPE", OracleDbType.Varchar2,50),
					new OracleParameter(":N_HOUR", OracleDbType.Decimal,4),
					new OracleParameter(":C_STL_GRD", OracleDbType.Varchar2,50),
					new OracleParameter(":C_STD_CODE", OracleDbType.Varchar2,50),
					new OracleParameter(":C_ZL_TYPE", OracleDbType.Varchar2,50),
					new OracleParameter(":D_MOD_DT", OracleDbType.Date),
					new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
					new OracleParameter(":C_BY1", OracleDbType.Varchar2,1000),
					new OracleParameter(":C_BY2", OracleDbType.Varchar2,1000),
					new OracleParameter(":C_BY3", OracleDbType.Varchar2,1000),
					new OracleParameter(":C_BY4", OracleDbType.Varchar2,1000),
					new OracleParameter(":C_BY5", OracleDbType.Varchar2,1000),
					new OracleParameter(":C_BY6", OracleDbType.Varchar2,1000),
					new OracleParameter(":C_ID", OracleDbType.Varchar2,50)};
			parameters[0].Value = model.C_TYPE;
			parameters[1].Value = model.N_HOUR;
			parameters[2].Value = model.C_STL_GRD;
			parameters[3].Value = model.C_STD_CODE;
			parameters[4].Value = model.C_ZL_TYPE;
			parameters[5].Value = model.D_MOD_DT;
			parameters[6].Value = model.C_EMP_ID;
			parameters[7].Value = model.C_BY1;
			parameters[8].Value = model.C_BY2;
			parameters[9].Value = model.C_BY3;
			parameters[10].Value = model.C_BY4;
			parameters[11].Value = model.C_BY5;
			parameters[12].Value = model.C_BY6;
			parameters[13].Value = model.C_ID;

			int rows=DbHelperOra.ExecuteSql(strSql.ToString(),parameters);
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
		public bool Delete(string C_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from TB_REHEATING_FURNACE ");
			strSql.Append(" where C_ID=:C_ID ");
			OracleParameter[] parameters = {
					new OracleParameter(":C_ID", OracleDbType.Varchar2,50)			};
			parameters[0].Value = C_ID;

			int rows=DbHelperOra.ExecuteSql(strSql.ToString(),parameters);
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
		public bool DeleteList(string C_IDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from TB_REHEATING_FURNACE ");
			strSql.Append(" where C_ID in ("+C_IDlist + ")  ");
			int rows=DbHelperOra.ExecuteSql(strSql.ToString());
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
		public Mod_TB_REHEATING_FURNACE GetModel(string C_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select C_ID,C_TYPE,N_HOUR,C_STL_GRD,C_STD_CODE,C_ZL_TYPE,D_MOD_DT,C_EMP_ID,C_BY1,C_BY2,C_BY3,C_BY4,C_BY5,C_BY6 from TB_REHEATING_FURNACE ");
			strSql.Append(" where C_ID=:C_ID ");
			OracleParameter[] parameters = {
					new OracleParameter(":C_ID", OracleDbType.Varchar2,50)			};
			parameters[0].Value = C_ID;

			Mod_TB_REHEATING_FURNACE model=new Mod_TB_REHEATING_FURNACE();
			DataSet ds=DbHelperOra.Query(strSql.ToString(),parameters);
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
		public Mod_TB_REHEATING_FURNACE DataRowToModel(DataRow row)
		{
			Mod_TB_REHEATING_FURNACE model=new Mod_TB_REHEATING_FURNACE();
			if (row != null)
			{
				if(row["C_ID"]!=null)
				{
					model.C_ID=row["C_ID"].ToString();
				}
				if(row["C_TYPE"]!=null)
				{
					model.C_TYPE=row["C_TYPE"].ToString();
				}
				if(row["N_HOUR"]!=null && row["N_HOUR"].ToString()!="")
				{
					model.N_HOUR=decimal.Parse(row["N_HOUR"].ToString());
				}
				if(row["C_STL_GRD"]!=null)
				{
					model.C_STL_GRD=row["C_STL_GRD"].ToString();
				}
				if(row["C_STD_CODE"]!=null)
				{
					model.C_STD_CODE=row["C_STD_CODE"].ToString();
				}
				if(row["C_ZL_TYPE"]!=null)
				{
					model.C_ZL_TYPE=row["C_ZL_TYPE"].ToString();
				}
				if(row["D_MOD_DT"]!=null && row["D_MOD_DT"].ToString()!="")
				{
					model.D_MOD_DT=DateTime.Parse(row["D_MOD_DT"].ToString());
				}
				if(row["C_EMP_ID"]!=null)
				{
					model.C_EMP_ID=row["C_EMP_ID"].ToString();
				}
				if(row["C_BY1"]!=null)
				{
					model.C_BY1=row["C_BY1"].ToString();
				}
				if(row["C_BY2"]!=null)
				{
					model.C_BY2=row["C_BY2"].ToString();
				}
				if(row["C_BY3"]!=null)
				{
					model.C_BY3=row["C_BY3"].ToString();
				}
				if(row["C_BY4"]!=null)
				{
					model.C_BY4=row["C_BY4"].ToString();
				}
				if(row["C_BY5"]!=null)
				{
					model.C_BY5=row["C_BY5"].ToString();
				}
				if(row["C_BY6"]!=null)
				{
					model.C_BY6=row["C_BY6"].ToString();
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
			strSql.Append("select C_ID,C_TYPE,N_HOUR,C_STL_GRD,C_STD_CODE,C_ZL_TYPE,D_MOD_DT,C_EMP_ID,C_BY1,C_BY2,C_BY3,C_BY4,C_BY5,C_BY6 ");
			strSql.Append(" FROM TB_REHEATING_FURNACE ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperOra.Query(strSql.ToString());
		}
        /// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet Getlist_Query(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_TYPE,N_HOUR,C_STL_GRD,C_STD_CODE,C_ZL_TYPE,D_MOD_DT,C_EMP_ID,C_BY1,C_BY2,C_BY3,C_BY4,C_BY5,C_BY6 ");
            strSql.Append(" FROM TB_REHEATING_FURNACE where 1=1 ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" and C_STL_GRD LIKE '%"+ strWhere + "%' ");
            }
            strSql.Append(" ORDER BY C_STL_GRD,N_HOUR ");
            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM TB_REHEATING_FURNACE ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			object obj = DbHelperOra.GetSingle(strSql.ToString());
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
				strSql.Append("order by T.C_ID desc");
			}
			strSql.Append(")AS Row, T.*  from TB_REHEATING_FURNACE T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DbHelperOra.Query(strSql.ToString());
		}

		/*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			OracleParameter[] parameters = {
					new OracleParameter(":tblName", OracleDbType.Varchar2, 255),
					new OracleParameter(":fldName", OracleDbType.Varchar2, 255),
					new OracleParameter(":PageSize", OracleDbType.Decimal),
					new OracleParameter(":PageIndex", OracleDbType.Decimal),
					new OracleParameter(":IsReCount", OracleType.Clob),
					new OracleParameter(":OrderType", OracleType.Clob),
					new OracleParameter(":strWhere", OracleDbType.Varchar2,1000),
					};
			parameters[0].Value = "TB_REHEATING_FURNACE";
			parameters[1].Value = "C_ID";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperOra.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

