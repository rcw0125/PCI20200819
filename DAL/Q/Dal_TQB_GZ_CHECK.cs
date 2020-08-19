using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;

namespace DAL
{
	/// <summary>
	/// 数据访问类:TQB_GZ_CHECK
	/// </summary>
	public partial class Dal_TQB_GZ_CHECK
	{
		public Dal_TQB_GZ_CHECK()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string C_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from TQB_GZ_CHECK");
			strSql.Append(" where C_ID=:C_ID ");
			OracleParameter[] parameters = {
					new OracleParameter(":C_ID", OracleDbType.Varchar2,100)			};
			parameters[0].Value = C_ID;

			return DbHelperOra.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Mod_TQB_GZ_CHECK model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into TQB_GZ_CHECK(");
			strSql.Append("C_STD_ID,C_CHECK,C_REMARK,C_EMP_ID,D_MOD_DT,C_STD_MAIN_ID)");
			strSql.Append(" values (");
			strSql.Append(":C_STD_ID,:C_CHECK,:C_REMARK,:C_EMP_ID,:D_MOD_DT,:C_STD_MAIN_ID)");
			OracleParameter[] parameters = {
					new OracleParameter(":C_STD_ID", OracleDbType.Varchar2,100),
					new OracleParameter(":C_CHECK", OracleDbType.Varchar2,100),
					new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
					new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
					new OracleParameter(":D_MOD_DT", OracleDbType.Date),
					new OracleParameter(":C_STD_MAIN_ID", OracleDbType.Varchar2,100)};
			parameters[0].Value = model.C_STD_ID;
			parameters[1].Value = model.C_CHECK;
			parameters[2].Value = model.C_REMARK;
			parameters[3].Value = model.C_EMP_ID;
			parameters[4].Value = model.D_MOD_DT;
			parameters[5].Value = model.C_STD_MAIN_ID;

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
		public bool Update(Mod_TQB_GZ_CHECK model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update TQB_GZ_CHECK set ");
			strSql.Append("C_STD_ID=:C_STD_ID,");
			strSql.Append("C_CHECK=:C_CHECK,");
			strSql.Append("C_REMARK=:C_REMARK,");
			strSql.Append("C_EMP_ID=:C_EMP_ID,");
			strSql.Append("D_MOD_DT=:D_MOD_DT,");
			strSql.Append("C_STD_MAIN_ID=:C_STD_MAIN_ID");
			strSql.Append(" where C_ID=:C_ID ");
			OracleParameter[] parameters = {
					new OracleParameter(":C_STD_ID", OracleDbType.Varchar2,100),
					new OracleParameter(":C_CHECK", OracleDbType.Varchar2,100),
					new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
					new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
					new OracleParameter(":D_MOD_DT", OracleDbType.Date),
					new OracleParameter(":C_STD_MAIN_ID", OracleDbType.Varchar2,100),
					new OracleParameter(":C_ID", OracleDbType.Varchar2,100)};
			parameters[0].Value = model.C_STD_ID;
			parameters[1].Value = model.C_CHECK;
			parameters[2].Value = model.C_REMARK;
			parameters[3].Value = model.C_EMP_ID;
			parameters[4].Value = model.D_MOD_DT;
			parameters[5].Value = model.C_STD_MAIN_ID;
			parameters[6].Value = model.C_ID;

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
			strSql.Append("delete from TQB_GZ_CHECK ");
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
			strSql.Append("delete from TQB_GZ_CHECK ");
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
		public Mod_TQB_GZ_CHECK GetModel(string C_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select C_ID,C_STD_ID,C_CHECK,C_REMARK,C_EMP_ID,D_MOD_DT,C_STD_MAIN_ID from TQB_GZ_CHECK ");
			strSql.Append(" where C_ID=:C_ID ");
			OracleParameter[] parameters = {
					new OracleParameter(":C_ID", OracleDbType.Varchar2,100)			};
			parameters[0].Value = C_ID;

			Mod_TQB_GZ_CHECK model=new Mod_TQB_GZ_CHECK();
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
		public Mod_TQB_GZ_CHECK DataRowToModel(DataRow row)
		{
			Mod_TQB_GZ_CHECK model=new Mod_TQB_GZ_CHECK();
			if (row != null)
			{
				if(row["C_ID"]!=null)
				{
					model.C_ID=row["C_ID"].ToString();
				}
				if(row["C_STD_ID"]!=null)
				{
					model.C_STD_ID=row["C_STD_ID"].ToString();
				}
				if(row["C_CHECK"]!=null)
				{
					model.C_CHECK=row["C_CHECK"].ToString();
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
				if(row["C_STD_MAIN_ID"]!=null)
				{
					model.C_STD_MAIN_ID=row["C_STD_MAIN_ID"].ToString();
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
			strSql.Append("select C_ID,C_STD_ID,C_CHECK,C_REMARK,C_EMP_ID,D_MOD_DT,C_STD_MAIN_ID ");
			strSql.Append(" FROM TQB_GZ_CHECK ");
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
			strSql.Append("select count(1) FROM TQB_GZ_CHECK ");
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
			strSql.Append(")AS Row, T.*  from TQB_GZ_CHECK T ");
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
			parameters[0].Value = "TQB_GZ_CHECK";
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
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet Query(string c_std_id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select t.C_ID,t.C_STD_ID,t.C_CHECK,t.C_REMARK,t.C_EMP_ID,t.D_MOD_DT,a.c_std_code,a.c_stl_grd ");
            strSql.Append(" FROM TQB_GZ_CHECK t join Tqb_Std_Main a on t.c_std_main_id=a.c_id where t.C_CHECK='1' ");
            if (c_std_id.Trim() != "")
            {
                strSql.Append(" and t.C_STD_ID = '"+ c_std_id+"' ");
            }
            return DbHelperOra.Query(strSql.ToString());
        }
        #endregion  ExtensionMethod
    }
}

