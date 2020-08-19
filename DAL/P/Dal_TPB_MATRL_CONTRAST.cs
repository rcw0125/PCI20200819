using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;
namespace DAL
{
	/// <summary>
	/// 数据访问类:TPB_MATRL_CONTRAST
	/// </summary>
	public partial class Dal_TPB_MATRL_CONTRAST
    {
		public Dal_TPB_MATRL_CONTRAST()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string C_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from TPB_MATRL_CONTRAST");
			strSql.Append(" where C_ID=:C_ID ");
			OracleParameter[] parameters = {
					new OracleParameter(":C_ID", OracleDbType.Varchar2,100)			};
			parameters[0].Value = C_ID;

			return DbHelperOra.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Mod_TPB_MATRL_CONTRAST model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into TPB_MATRL_CONTRAST(");
			strSql.Append("C_MAT_LINE_CODE,C_MAT_LINE_NAME,C_SPEC_LINE,C_MAT_SLAB_CODE,C_MAT_SLAB_NAME,C_SPEC_SLAB,C_TRAN,N_LEVEL,C_LENGTH_SLAB,C_REMARK,N_STATUS,C_EMP_ID,D_MOD_DT,D_START_DATE,D_END_DATE)");
			strSql.Append(" values (");
			strSql.Append(":C_MAT_LINE_CODE,:C_MAT_LINE_NAME,:C_SPEC_LINE,:C_MAT_SLAB_CODE,:C_MAT_SLAB_NAME,:C_SPEC_SLAB,:C_TRAN,:N_LEVEL,:C_LENGTH_SLAB,:C_REMARK,:N_STATUS,:C_EMP_ID,:D_MOD_DT,:D_START_DATE,:D_END_DATE)");
			OracleParameter[] parameters = {
					new OracleParameter(":C_MAT_LINE_CODE", OracleDbType.Varchar2,100),
					new OracleParameter(":C_MAT_LINE_NAME", OracleDbType.Varchar2,100),
					new OracleParameter(":C_SPEC_LINE", OracleDbType.Varchar2,100),
					new OracleParameter(":C_MAT_SLAB_CODE", OracleDbType.Varchar2,100),
					new OracleParameter(":C_MAT_SLAB_NAME", OracleDbType.Varchar2,100),
					new OracleParameter(":C_SPEC_SLAB", OracleDbType.Varchar2,100),
					new OracleParameter(":C_TRAN", OracleDbType.Varchar2,100),
					new OracleParameter(":N_LEVEL", OracleDbType.Decimal,3),
					new OracleParameter(":C_LENGTH_SLAB", OracleDbType.Varchar2,100),
					new OracleParameter(":C_REMARK", OracleDbType.Varchar2,200),
					new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
					new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
					new OracleParameter(":D_MOD_DT", OracleDbType.Date),
					new OracleParameter(":D_START_DATE", OracleDbType.Date),
					new OracleParameter(":D_END_DATE", OracleDbType.Date)};
			parameters[0].Value = model.C_MAT_LINE_CODE;
            parameters[1].Value = model.C_MAT_LINE_NAME;
			parameters[2].Value = model.C_SPEC_LINE;
			parameters[3].Value = model.C_MAT_SLAB_CODE;
			parameters[4].Value = model.C_MAT_SLAB_NAME;
			parameters[5].Value = model.C_SPEC_SLAB;
			parameters[6].Value = model.C_TRAN;
			parameters[7].Value = model.N_LEVEL;
			parameters[8].Value = model.C_LENGTH_SLAB;
			parameters[9].Value =  model.C_REMARK;
			parameters[10].Value = model.N_STATUS;
			parameters[11].Value = model.C_EMP_ID;
			parameters[12].Value = model.D_MOD_DT;
			parameters[13].Value = model.D_START_DATE;
			parameters[14].Value = model.D_END_DATE;

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
		public bool Update(Mod_TPB_MATRL_CONTRAST model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update TPB_MATRL_CONTRAST set ");
			strSql.Append("C_MAT_LINE_CODE=:C_MAT_LINE_CODE,");
			strSql.Append("C_MAT_LINE_NAME=:C_MAT_LINE_NAME,");
			strSql.Append("C_SPEC_LINE=:C_SPEC_LINE,");
			strSql.Append("C_MAT_SLAB_CODE=:C_MAT_SLAB_CODE,");
			strSql.Append("C_MAT_SLAB_NAME=:C_MAT_SLAB_NAME,");
			strSql.Append("C_SPEC_SLAB=:C_SPEC_SLAB,");
			strSql.Append("C_TRAN=:C_TRAN,");
			strSql.Append("N_LEVEL=:N_LEVEL,");
			strSql.Append("C_LENGTH_SLAB=:C_LENGTH_SLAB,");
			strSql.Append("C_REMARK=:C_REMARK,");
			strSql.Append("N_STATUS=:N_STATUS,");
			strSql.Append("C_EMP_ID=:C_EMP_ID,");
			strSql.Append("D_MOD_DT=:D_MOD_DT,");
			strSql.Append("D_START_DATE=:D_START_DATE,");
			strSql.Append("D_END_DATE=:D_END_DATE");
			strSql.Append(" where C_ID=:C_ID ");
			OracleParameter[] parameters = {
					new OracleParameter(":C_MAT_LINE_CODE", OracleDbType.Varchar2,100),
					new OracleParameter(":C_MAT_LINE_NAME", OracleDbType.Varchar2,100),
					new OracleParameter(":C_SPEC_LINE", OracleDbType.Varchar2,100),
					new OracleParameter(":C_MAT_SLAB_CODE", OracleDbType.Varchar2,100),
					new OracleParameter(":C_MAT_SLAB_NAME", OracleDbType.Varchar2,100),
					new OracleParameter(":C_SPEC_SLAB", OracleDbType.Varchar2,100),
					new OracleParameter(":C_TRAN", OracleDbType.Varchar2,100),
					new OracleParameter(":N_LEVEL", OracleDbType.Decimal,3),
					new OracleParameter(":C_LENGTH_SLAB", OracleDbType.Varchar2,100),
					new OracleParameter(":C_REMARK", OracleDbType.Varchar2,200),
					new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
					new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
					new OracleParameter(":D_MOD_DT", OracleDbType.Date),
					new OracleParameter(":D_START_DATE", OracleDbType.Date),
					new OracleParameter(":D_END_DATE", OracleDbType.Date),
					new OracleParameter(":C_ID", OracleDbType.Varchar2,100)};
			parameters[0].Value = model.C_MAT_LINE_CODE;
			parameters[1].Value = model.C_MAT_LINE_NAME;
			parameters[2].Value = model.C_SPEC_LINE;
			parameters[3].Value = model.C_MAT_SLAB_CODE;
			parameters[4].Value = model.C_MAT_SLAB_NAME;
			parameters[5].Value = model.C_SPEC_SLAB;
			parameters[6].Value = model.C_TRAN;
			parameters[7].Value = model.N_LEVEL;
			parameters[8].Value = model.C_LENGTH_SLAB;
			parameters[9].Value = model.C_REMARK;
			parameters[10].Value = model.N_STATUS;
			parameters[11].Value = model.C_EMP_ID;
			parameters[12].Value = model.D_MOD_DT;
			parameters[13].Value = model.D_START_DATE;
			parameters[14].Value = model.D_END_DATE;
			parameters[15].Value = model.C_ID;

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
			strSql.Append("delete from TPB_MATRL_CONTRAST ");
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
			strSql.Append("delete from TPB_MATRL_CONTRAST ");
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
		public Mod_TPB_MATRL_CONTRAST GetModel(string C_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select C_ID,C_MAT_LINE_CODE,C_MAT_LINE_NAME,C_SPEC_LINE,C_MAT_SLAB_CODE,C_MAT_SLAB_NAME,C_SPEC_SLAB,C_TRAN,N_LEVEL,C_LENGTH_SLAB,C_REMARK,N_STATUS,C_EMP_ID,D_MOD_DT,D_START_DATE,D_END_DATE from TPB_MATRL_CONTRAST ");
			strSql.Append(" where C_ID=:C_ID ");
			OracleParameter[] parameters = {
					new OracleParameter(":C_ID", OracleDbType.Varchar2,100)			};
			parameters[0].Value = C_ID;

			Mod_TPB_MATRL_CONTRAST model=new Mod_TPB_MATRL_CONTRAST();
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
		public Mod_TPB_MATRL_CONTRAST DataRowToModel(DataRow row)
		{
			Mod_TPB_MATRL_CONTRAST model=new Mod_TPB_MATRL_CONTRAST();
			if (row != null)
			{
				if(row["C_ID"]!=null)
				{
					model.C_ID=row["C_ID"].ToString();
				}
				if(row["C_MAT_LINE_CODE"]!=null)
				{
					model.C_MAT_LINE_CODE=row["C_MAT_LINE_CODE"].ToString();
				}
				if(row["C_MAT_LINE_NAME"]!=null)
				{
					model.C_MAT_LINE_NAME=row["C_MAT_LINE_NAME"].ToString();
				}
				if(row["C_SPEC_LINE"]!=null)
				{
					model.C_SPEC_LINE=row["C_SPEC_LINE"].ToString();
				}
				if(row["C_MAT_SLAB_CODE"]!=null)
				{
					model.C_MAT_SLAB_CODE=row["C_MAT_SLAB_CODE"].ToString();
				}
				if(row["C_MAT_SLAB_NAME"]!=null)
				{
					model.C_MAT_SLAB_NAME=row["C_MAT_SLAB_NAME"].ToString();
				}
				if(row["C_SPEC_SLAB"]!=null)
				{
					model.C_SPEC_SLAB=row["C_SPEC_SLAB"].ToString();
				}
				if(row["C_TRAN"]!=null)
				{
					model.C_TRAN=row["C_TRAN"].ToString();
				}
				if(row["N_LEVEL"]!=null && row["N_LEVEL"].ToString()!="")
				{
					model.N_LEVEL=decimal.Parse(row["N_LEVEL"].ToString());
				}
				if(row["C_LENGTH_SLAB"]!=null)
				{
					model.C_LENGTH_SLAB=row["C_LENGTH_SLAB"].ToString();
				}
				if(row["C_REMARK"]!=null)
				{
					model.C_REMARK=row["C_REMARK"].ToString();
				}
				if(row["N_STATUS"]!=null && row["N_STATUS"].ToString()!="")
				{
					model.N_STATUS=decimal.Parse(row["N_STATUS"].ToString());
				}
				if(row["C_EMP_ID"]!=null)
				{
					model.C_EMP_ID=row["C_EMP_ID"].ToString();
				}
				if(row["D_MOD_DT"]!=null && row["D_MOD_DT"].ToString()!="")
				{
					model.D_MOD_DT=DateTime.Parse(row["D_MOD_DT"].ToString());
				}
				if(row["D_START_DATE"]!=null && row["D_START_DATE"].ToString()!="")
				{
					model.D_START_DATE=DateTime.Parse(row["D_START_DATE"].ToString());
				}
				if(row["D_END_DATE"]!=null && row["D_END_DATE"].ToString()!="")
				{
					model.D_END_DATE=DateTime.Parse(row["D_END_DATE"].ToString());
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
			strSql.Append("select C_ID,C_MAT_LINE_CODE,C_MAT_LINE_NAME,C_SPEC_LINE,C_MAT_SLAB_CODE,C_MAT_SLAB_NAME,C_SPEC_SLAB,C_TRAN,N_LEVEL,C_LENGTH_SLAB,C_REMARK,N_STATUS,C_EMP_ID,D_MOD_DT,D_START_DATE,D_END_DATE ");
			strSql.Append(" FROM TPB_MATRL_CONTRAST ");
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
			strSql.Append("select count(1) FROM TPB_MATRL_CONTRAST ");
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
			strSql.Append(")AS Row, T.*  from TPB_MATRL_CONTRAST T ");
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
			parameters[0].Value = "TPB_MATRL_CONTRAST";
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

