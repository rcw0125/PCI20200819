using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;
namespace DAL
{
	/// <summary>
	/// 数据访问类:TQR_GRADE
	/// </summary>
	public partial class Dal_TQR_GRADE
    {
		public Dal_TQR_GRADE()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string C_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from TQR_GRADE");
			strSql.Append(" where C_ID=:C_ID ");
			OracleParameter[] parameters = {
					new OracleParameter(":C_ID", OracleDbType.Varchar2,100)			};
			parameters[0].Value = C_ID;

			return DbHelperOra.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Mod_TQR_GRADE model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into TQR_GRADE(");
			strSql.Append("D_RATE_DT,C_BATCH_NO,C_BATCH_NO_KP,C_STOVE,C_STL_GRD,C_SPEC,C_QUA,N_WGT,C_LG_GX_GRADE,C_LG_GRADE_CAUSE,C_XC_GX_GRADE,C_XC_GRADE_CAUSE,C_CF_GRADE,C_CF_GRADE_CAUSE,C_XN_GRADE,C_XN_GRADE_CAUSE,C_FACE_GRADE,C_FACE_GRADE_CAUSE,C_CP_ZH_GRADE,N_STATUS,C_REMARK,C_EMP_ID)");
			strSql.Append(" values (");
			strSql.Append(":D_RATE_DT,:C_BATCH_NO,:C_BATCH_NO_KP,:C_STOVE,:C_STL_GRD,:C_SPEC,:C_QUA,:N_WGT,:C_LG_GX_GRADE,:C_LG_GRADE_CAUSE,:C_XC_GX_GRADE,:C_XC_GRADE_CAUSE,:C_CF_GRADE,:C_CF_GRADE_CAUSE,:C_XN_GRADE,:C_XN_GRADE_CAUSE,:C_FACE_GRADE,:C_FACE_GRADE_CAUSE,:C_CP_ZH_GRADE,:N_STATUS,:C_REMARK,:C_EMP_ID)");
			OracleParameter[] parameters = {
					new OracleParameter(":D_RATE_DT", OracleDbType.Date),
					new OracleParameter(":C_BATCH_NO", OracleDbType.Varchar2,100),
					new OracleParameter(":C_BATCH_NO_KP", OracleDbType.Varchar2,100),
					new OracleParameter(":C_STOVE", OracleDbType.Varchar2,100),
					new OracleParameter(":C_STL_GRD", OracleDbType.Varchar2,100),
					new OracleParameter(":C_SPEC", OracleDbType.Varchar2,100),
					new OracleParameter(":C_QUA", OracleDbType.Varchar2,100),
					new OracleParameter(":N_WGT", OracleDbType.Double,15),
					new OracleParameter(":C_LG_GX_GRADE", OracleDbType.Varchar2,100),
					new OracleParameter(":C_LG_GRADE_CAUSE", OracleDbType.Varchar2,100),
					new OracleParameter(":C_XC_GX_GRADE", OracleDbType.Varchar2,100),
					new OracleParameter(":C_XC_GRADE_CAUSE", OracleDbType.Varchar2,100),
					new OracleParameter(":C_CF_GRADE", OracleDbType.Varchar2,100),
					new OracleParameter(":C_CF_GRADE_CAUSE", OracleDbType.Varchar2,100),
					new OracleParameter(":C_XN_GRADE", OracleDbType.Varchar2,100),
					new OracleParameter(":C_XN_GRADE_CAUSE", OracleDbType.Varchar2,100),
					new OracleParameter(":C_FACE_GRADE", OracleDbType.Varchar2,100),
					new OracleParameter(":C_FACE_GRADE_CAUSE", OracleDbType.Varchar2,100),
					new OracleParameter(":C_CP_ZH_GRADE", OracleDbType.Varchar2,100),
					new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
					new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
					new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100)};
			parameters[0].Value = model.D_RATE_DT;
			parameters[1].Value = model.C_BATCH_NO;
			parameters[2].Value = model.C_BATCH_NO_KP;
			parameters[3].Value = model.C_STOVE;
			parameters[4].Value = model.C_STL_GRD;
			parameters[5].Value = model.C_SPEC;
			parameters[6].Value = model.C_QUA;
			parameters[7].Value = model.N_WGT;
			parameters[8].Value = model.C_LG_GX_GRADE;
			parameters[9].Value = model.C_LG_GRADE_CAUSE;
			parameters[10].Value = model.C_XC_GX_GRADE;
			parameters[11].Value = model.C_XC_GRADE_CAUSE;
			parameters[12].Value = model.C_CF_GRADE;
			parameters[13].Value = model.C_CF_GRADE_CAUSE;
			parameters[14].Value = model.C_XN_GRADE;
			parameters[15].Value = model.C_XN_GRADE_CAUSE;
			parameters[16].Value = model.C_FACE_GRADE;
			parameters[17].Value = model.C_FACE_GRADE_CAUSE;
			parameters[18].Value = model.C_CP_ZH_GRADE;
			parameters[19].Value = model.N_STATUS;
			parameters[20].Value = model.C_REMARK;
			parameters[21].Value = model.C_EMP_ID;

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
		public bool Update(Mod_TQR_GRADE model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update TQR_GRADE set ");
			strSql.Append("D_RATE_DT=:D_RATE_DT,");
			strSql.Append("C_BATCH_NO=:C_BATCH_NO,");
			strSql.Append("C_BATCH_NO_KP=:C_BATCH_NO_KP,");
			strSql.Append("C_STOVE=:C_STOVE,");
			strSql.Append("C_STL_GRD=:C_STL_GRD,");
			strSql.Append("C_SPEC=:C_SPEC,");
			strSql.Append("C_QUA=:C_QUA,");
			strSql.Append("N_WGT=:N_WGT,");
			strSql.Append("C_LG_GX_GRADE=:C_LG_GX_GRADE,");
			strSql.Append("C_LG_GRADE_CAUSE=:C_LG_GRADE_CAUSE,");
			strSql.Append("C_XC_GX_GRADE=:C_XC_GX_GRADE,");
			strSql.Append("C_XC_GRADE_CAUSE=:C_XC_GRADE_CAUSE,");
			strSql.Append("C_CF_GRADE=:C_CF_GRADE,");
			strSql.Append("C_CF_GRADE_CAUSE=:C_CF_GRADE_CAUSE,");
			strSql.Append("C_XN_GRADE=:C_XN_GRADE,");
			strSql.Append("C_XN_GRADE_CAUSE=:C_XN_GRADE_CAUSE,");
			strSql.Append("C_FACE_GRADE=:C_FACE_GRADE,");
			strSql.Append("C_FACE_GRADE_CAUSE=:C_FACE_GRADE_CAUSE,");
			strSql.Append("C_CP_ZH_GRADE=:C_CP_ZH_GRADE,");
			strSql.Append("N_STATUS=:N_STATUS,");
			strSql.Append("C_REMARK=:C_REMARK,");
			strSql.Append("C_EMP_ID=:C_EMP_ID,");
			strSql.Append("D_MOD_DT=:D_MOD_DT");
			strSql.Append(" where C_ID=:C_ID ");
			OracleParameter[] parameters = {
					new OracleParameter(":D_RATE_DT", OracleDbType.Date),
					new OracleParameter(":C_BATCH_NO", OracleDbType.Varchar2,100),
					new OracleParameter(":C_BATCH_NO_KP", OracleDbType.Varchar2,100),
					new OracleParameter(":C_STOVE", OracleDbType.Varchar2,100),
					new OracleParameter(":C_STL_GRD", OracleDbType.Varchar2,100),
					new OracleParameter(":C_SPEC", OracleDbType.Varchar2,100),
					new OracleParameter(":C_QUA", OracleDbType.Varchar2,100),
					new OracleParameter(":N_WGT", OracleDbType.Double,15),
					new OracleParameter(":C_LG_GX_GRADE", OracleDbType.Varchar2,100),
					new OracleParameter(":C_LG_GRADE_CAUSE", OracleDbType.Varchar2,100),
					new OracleParameter(":C_XC_GX_GRADE", OracleDbType.Varchar2,100),
					new OracleParameter(":C_XC_GRADE_CAUSE", OracleDbType.Varchar2,100),
					new OracleParameter(":C_CF_GRADE", OracleDbType.Varchar2,100),
					new OracleParameter(":C_CF_GRADE_CAUSE", OracleDbType.Varchar2,100),
					new OracleParameter(":C_XN_GRADE", OracleDbType.Varchar2,100),
					new OracleParameter(":C_XN_GRADE_CAUSE", OracleDbType.Varchar2,100),
					new OracleParameter(":C_FACE_GRADE", OracleDbType.Varchar2,100),
					new OracleParameter(":C_FACE_GRADE_CAUSE", OracleDbType.Varchar2,100),
					new OracleParameter(":C_CP_ZH_GRADE", OracleDbType.Varchar2,100),
					new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
					new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
					new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
					new OracleParameter(":D_MOD_DT", OracleDbType.Date),
					new OracleParameter(":C_ID", OracleDbType.Varchar2,100)};
			parameters[0].Value = model.D_RATE_DT;
			parameters[1].Value = model.C_BATCH_NO;
			parameters[2].Value = model.C_BATCH_NO_KP;
			parameters[3].Value = model.C_STOVE;
			parameters[4].Value = model.C_STL_GRD;
			parameters[5].Value = model.C_SPEC;
			parameters[6].Value = model.C_QUA;
			parameters[7].Value = model.N_WGT;
			parameters[8].Value = model.C_LG_GX_GRADE;
			parameters[9].Value = model.C_LG_GRADE_CAUSE;
			parameters[10].Value = model.C_XC_GX_GRADE;
			parameters[11].Value = model.C_XC_GRADE_CAUSE;
			parameters[12].Value = model.C_CF_GRADE;
			parameters[13].Value = model.C_CF_GRADE_CAUSE;
			parameters[14].Value = model.C_XN_GRADE;
			parameters[15].Value = model.C_XN_GRADE_CAUSE;
			parameters[16].Value = model.C_FACE_GRADE;
			parameters[17].Value = model.C_FACE_GRADE_CAUSE;
			parameters[18].Value = model.C_CP_ZH_GRADE;
			parameters[19].Value = model.N_STATUS;
			parameters[20].Value = model.C_REMARK;
			parameters[21].Value = model.C_EMP_ID;
			parameters[22].Value = model.D_MOD_DT;
			parameters[23].Value = model.C_ID;

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
			strSql.Append("delete from TQR_GRADE ");
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
			strSql.Append("delete from TQR_GRADE ");
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
		public Mod_TQR_GRADE GetModel(string C_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select C_ID,D_RATE_DT,C_BATCH_NO,C_BATCH_NO_KP,C_STOVE,C_STL_GRD,C_SPEC,C_QUA,N_WGT,C_LG_GX_GRADE,C_LG_GRADE_CAUSE,C_XC_GX_GRADE,C_XC_GRADE_CAUSE,C_CF_GRADE,C_CF_GRADE_CAUSE,C_XN_GRADE,C_XN_GRADE_CAUSE,C_FACE_GRADE,C_FACE_GRADE_CAUSE,C_CP_ZH_GRADE,N_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT from TQR_GRADE ");
			strSql.Append(" where C_ID=:C_ID ");
			OracleParameter[] parameters = {
					new OracleParameter(":C_ID", OracleDbType.Varchar2,100)			};
			parameters[0].Value = C_ID;

			Mod_TQR_GRADE model=new Mod_TQR_GRADE();
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
		public Mod_TQR_GRADE DataRowToModel(DataRow row)
		{
			Mod_TQR_GRADE model=new Mod_TQR_GRADE();
			if (row != null)
			{
				if(row["C_ID"]!=null)
				{
					model.C_ID=row["C_ID"].ToString();
				}
				if(row["D_RATE_DT"]!=null && row["D_RATE_DT"].ToString()!="")
				{
					model.D_RATE_DT=DateTime.Parse(row["D_RATE_DT"].ToString());
				}
				if(row["C_BATCH_NO"]!=null)
				{
					model.C_BATCH_NO=row["C_BATCH_NO"].ToString();
				}
				if(row["C_BATCH_NO_KP"]!=null)
				{
					model.C_BATCH_NO_KP=row["C_BATCH_NO_KP"].ToString();
				}
				if(row["C_STOVE"]!=null)
				{
					model.C_STOVE=row["C_STOVE"].ToString();
				}
				if(row["C_STL_GRD"]!=null)
				{
					model.C_STL_GRD=row["C_STL_GRD"].ToString();
				}
				if(row["C_SPEC"]!=null)
				{
					model.C_SPEC=row["C_SPEC"].ToString();
				}
				if(row["C_QUA"]!=null)
				{
					model.C_QUA=row["C_QUA"].ToString();
				}
				if(row["N_WGT"]!=null && row["N_WGT"].ToString()!="")
				{
					model.N_WGT=decimal.Parse(row["N_WGT"].ToString());
				}
				if(row["C_LG_GX_GRADE"]!=null)
				{
					model.C_LG_GX_GRADE=row["C_LG_GX_GRADE"].ToString();
				}
				if(row["C_LG_GRADE_CAUSE"]!=null)
				{
					model.C_LG_GRADE_CAUSE=row["C_LG_GRADE_CAUSE"].ToString();
				}
				if(row["C_XC_GX_GRADE"]!=null)
				{
					model.C_XC_GX_GRADE=row["C_XC_GX_GRADE"].ToString();
				}
				if(row["C_XC_GRADE_CAUSE"]!=null)
				{
					model.C_XC_GRADE_CAUSE=row["C_XC_GRADE_CAUSE"].ToString();
				}
				if(row["C_CF_GRADE"]!=null)
				{
					model.C_CF_GRADE=row["C_CF_GRADE"].ToString();
				}
				if(row["C_CF_GRADE_CAUSE"]!=null)
				{
					model.C_CF_GRADE_CAUSE=row["C_CF_GRADE_CAUSE"].ToString();
				}
				if(row["C_XN_GRADE"]!=null)
				{
					model.C_XN_GRADE=row["C_XN_GRADE"].ToString();
				}
				if(row["C_XN_GRADE_CAUSE"]!=null)
				{
					model.C_XN_GRADE_CAUSE=row["C_XN_GRADE_CAUSE"].ToString();
				}
				if(row["C_FACE_GRADE"]!=null)
				{
					model.C_FACE_GRADE=row["C_FACE_GRADE"].ToString();
				}
				if(row["C_FACE_GRADE_CAUSE"]!=null)
				{
					model.C_FACE_GRADE_CAUSE=row["C_FACE_GRADE_CAUSE"].ToString();
				}
				if(row["C_CP_ZH_GRADE"]!=null)
				{
					model.C_CP_ZH_GRADE=row["C_CP_ZH_GRADE"].ToString();
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
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select C_ID,D_RATE_DT,C_BATCH_NO,C_BATCH_NO_KP,C_STOVE,C_STL_GRD,C_SPEC,C_QUA,N_WGT,C_LG_GX_GRADE,C_LG_GRADE_CAUSE,C_XC_GX_GRADE,C_XC_GRADE_CAUSE,C_CF_GRADE,C_CF_GRADE_CAUSE,C_XN_GRADE,C_XN_GRADE_CAUSE,C_FACE_GRADE,C_FACE_GRADE_CAUSE,C_CP_ZH_GRADE,N_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT ");
			strSql.Append(" FROM TQR_GRADE ");
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
			strSql.Append("select count(1) FROM TQR_GRADE ");
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
			strSql.Append(")AS Row, T.*  from TQR_GRADE T ");
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
			parameters[0].Value = "TQR_GRADE";
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

