using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;
namespace DAL
{
	/// <summary>
	/// 数据访问类:TPB_LINEWH_TIER
	/// </summary>
	public partial class Dal_TPB_LINEWH_TIER
	{
		public Dal_TPB_LINEWH_TIER()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string C_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from TPB_LINEWH_TIER");
			strSql.Append(" where C_ID=:C_ID ");
			OracleParameter[] parameters = {
					new OracleParameter(":C_ID", OracleDbType.Varchar2,100)			};
			parameters[0].Value = C_ID;

			return DbHelperOra.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Mod_TPB_LINEWH_TIER model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into TPB_LINEWH_TIER(");
			strSql.Append("C_ID,C_LINEWH_LOC_ID,C_LINEWH_TIER_CODE,C_LINEWH_TIER_NAME,N_LINEWH_TIER_NUM,D_START_DATE,D_END_DATE,N_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT)");
			strSql.Append(" values (");
			strSql.Append(":C_ID,:C_LINEWH_LOC_ID,:C_LINEWH_TIER_CODE,:C_LINEWH_TIER_NAME,:N_LINEWH_TIER_NUM,:D_START_DATE,:D_END_DATE,:N_STATUS,:C_REMARK,:C_EMP_ID,:D_MOD_DT)");
			OracleParameter[] parameters = {
					new OracleParameter(":C_ID", OracleDbType.Varchar2,100),
					new OracleParameter(":C_LINEWH_LOC_ID", OracleDbType.Varchar2,100),
					new OracleParameter(":C_LINEWH_TIER_CODE", OracleDbType.Varchar2,100),
					new OracleParameter(":C_LINEWH_TIER_NAME", OracleDbType.Varchar2,100),
					new OracleParameter(":N_LINEWH_TIER_NUM", OracleDbType.Decimal,2),
					new OracleParameter(":D_START_DATE", OracleDbType.Date),
					new OracleParameter(":D_END_DATE", OracleDbType.Date),
					new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
					new OracleParameter(":C_REMARK", OracleDbType.Varchar2,200),
					new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
					new OracleParameter(":D_MOD_DT", OracleDbType.Date)};
			parameters[0].Value = model.C_ID;
			parameters[1].Value = model.C_LINEWH_LOC_ID;
			parameters[2].Value = model.C_LINEWH_TIER_CODE;
			parameters[3].Value = model.C_LINEWH_TIER_NAME;
			parameters[4].Value = model.N_LINEWH_TIER_NUM;
			parameters[5].Value = model.D_START_DATE;
			parameters[6].Value = model.D_END_DATE;
			parameters[7].Value = model.N_STATUS;
			parameters[8].Value = model.C_REMARK;
			parameters[9].Value = model.C_EMP_ID;
			parameters[10].Value = model.D_MOD_DT;

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
		public bool Update(Mod_TPB_LINEWH_TIER model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update TPB_LINEWH_TIER set ");
			strSql.Append("C_LINEWH_LOC_ID=:C_LINEWH_LOC_ID,");
			strSql.Append("C_LINEWH_TIER_CODE=:C_LINEWH_TIER_CODE,");
			strSql.Append("C_LINEWH_TIER_NAME=:C_LINEWH_TIER_NAME,");
			strSql.Append("N_LINEWH_TIER_NUM=:N_LINEWH_TIER_NUM,");
			strSql.Append("D_START_DATE=:D_START_DATE,");
			strSql.Append("D_END_DATE=:D_END_DATE,");
			strSql.Append("N_STATUS=:N_STATUS,");
			strSql.Append("C_REMARK=:C_REMARK,");
			strSql.Append("C_EMP_ID=:C_EMP_ID,");
			strSql.Append("D_MOD_DT=:D_MOD_DT");
			strSql.Append(" where C_ID=:C_ID ");
			OracleParameter[] parameters = {
					new OracleParameter(":C_LINEWH_LOC_ID", OracleDbType.Varchar2,100),
					new OracleParameter(":C_LINEWH_TIER_CODE", OracleDbType.Varchar2,100),
					new OracleParameter(":C_LINEWH_TIER_NAME", OracleDbType.Varchar2,100),
					new OracleParameter(":N_LINEWH_TIER_NUM", OracleDbType.Decimal,2),
					new OracleParameter(":D_START_DATE", OracleDbType.Date),
					new OracleParameter(":D_END_DATE", OracleDbType.Date),
					new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
					new OracleParameter(":C_REMARK", OracleDbType.Varchar2,200),
					new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
					new OracleParameter(":D_MOD_DT", OracleDbType.Date),
					new OracleParameter(":C_ID", OracleDbType.Varchar2,100)};
			parameters[0].Value = model.C_LINEWH_LOC_ID;
			parameters[1].Value = model.C_LINEWH_TIER_CODE;
			parameters[2].Value = model.C_LINEWH_TIER_NAME;
			parameters[3].Value = model.N_LINEWH_TIER_NUM;
			parameters[4].Value = model.D_START_DATE;
			parameters[5].Value = model.D_END_DATE;
			parameters[6].Value = model.N_STATUS;
			parameters[7].Value = model.C_REMARK;
			parameters[8].Value = model.C_EMP_ID;
			parameters[9].Value = model.D_MOD_DT;
			parameters[10].Value = model.C_ID;

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
			strSql.Append("delete from TPB_LINEWH_TIER ");
			strSql.Append(" where C_ID=:C_ID ");
			OracleParameter[] parameters = {
					new OracleParameter(":C_ID", OracleDbType.Varchar2,100)			};
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
			strSql.Append("delete from TPB_LINEWH_TIER ");
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
		public Mod_TPB_LINEWH_TIER GetModel(string C_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select C_ID,C_LINEWH_LOC_ID,C_LINEWH_TIER_CODE,C_LINEWH_TIER_NAME,N_LINEWH_TIER_NUM,D_START_DATE,D_END_DATE,N_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT from TPB_LINEWH_TIER ");
			strSql.Append(" where C_ID=:C_ID ");
			OracleParameter[] parameters = {
					new OracleParameter(":C_ID", OracleDbType.Varchar2,100)			};
			parameters[0].Value = C_ID;

			Mod_TPB_LINEWH_TIER model=new Mod_TPB_LINEWH_TIER();
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
		public Mod_TPB_LINEWH_TIER DataRowToModel(DataRow row)
		{
			Mod_TPB_LINEWH_TIER model=new Mod_TPB_LINEWH_TIER();
			if (row != null)
			{
				if(row["C_ID"]!=null)
				{
					model.C_ID=row["C_ID"].ToString();
				}
				if(row["C_LINEWH_LOC_ID"]!=null)
				{
					model.C_LINEWH_LOC_ID=row["C_LINEWH_LOC_ID"].ToString();
				}
				if(row["C_LINEWH_TIER_CODE"]!=null)
				{
					model.C_LINEWH_TIER_CODE=row["C_LINEWH_TIER_CODE"].ToString();
				}
				if(row["C_LINEWH_TIER_NAME"]!=null)
				{
					model.C_LINEWH_TIER_NAME=row["C_LINEWH_TIER_NAME"].ToString();
				}
				if(row["N_LINEWH_TIER_NUM"]!=null && row["N_LINEWH_TIER_NUM"].ToString()!="")
				{
					model.N_LINEWH_TIER_NUM=decimal.Parse(row["N_LINEWH_TIER_NUM"].ToString());
				}
				if(row["D_START_DATE"]!=null && row["D_START_DATE"].ToString()!="")
				{
					model.D_START_DATE=DateTime.Parse(row["D_START_DATE"].ToString());
				}
				if(row["D_END_DATE"]!=null && row["D_END_DATE"].ToString()!="")
				{
					model.D_END_DATE=DateTime.Parse(row["D_END_DATE"].ToString());
				}
				if(row["N_STATUS"]!=null && row["N_STATUS"].ToString()!="")
				{
					model.N_STATUS=decimal.Parse(row["N_STATUS"].ToString());
				}
				if(row["C_REMARK"]!=null)
				{
					model.C_REMARK=row["C_REMARK"].ToString();
				}
				if(row["C_EMP_ID"]!=null)
				{
					model.C_EMP_ID=row["C_EMP_ID"].ToString();
				}
				if(row["D_MOD_DT"]!=null && row["D_MOD_DT"].ToString()!="")
				{
					model.D_MOD_DT=DateTime.Parse(row["D_MOD_DT"].ToString());
				}
			}
			return model;
		}
        /// <summary>
        /// 获得数据列表-外键
        /// </summary>
        public DataSet GetList_Query(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_LINEWH_LOC_ID,C_LINEWH_TIER_CODE,C_LINEWH_TIER_NAME,N_LINEWH_TIER_NUM,D_START_DATE,D_END_DATE,N_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT ");
            strSql.Append(" FROM TPB_LINEWH_TIER ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where C_LINEWH_LOC_ID = '"+ strWhere + "'"  );
            }
            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select C_ID,C_LINEWH_LOC_ID,C_LINEWH_TIER_CODE,C_LINEWH_TIER_NAME,N_LINEWH_TIER_NUM,D_START_DATE,D_END_DATE,N_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT ");
			strSql.Append(" FROM TPB_LINEWH_TIER ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperOra.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM TPB_LINEWH_TIER ");
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
			strSql.Append(")AS Row, T.*  from TPB_LINEWH_TIER T ");
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
					new OracleParameter(":PageSize", OracleDbType.Number),
					new OracleParameter(":PageIndex", OracleDbType.Number),
					new OracleParameter(":IsReCount", OracleDbType.Clob),
					new OracleParameter(":OrderType", OracleDbType.Clob),
					new OracleParameter(":strWhere", OracleDbType.Varchar2,1000),
					};
			parameters[0].Value = "TPB_LINEWH_TIER";
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
 
