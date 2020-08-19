using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;
namespace DAL
{
	/// <summary>
	/// 数据访问类:TB_ITEM_TYPE
	/// </summary>
	public partial class Dal_TB_ITEM_TYPE
	{
		public Dal_TB_ITEM_TYPE()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string C_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from TB_ITEM_TYPE");
			strSql.Append(" where C_ID=:C_ID ");
			OracleParameter[] parameters = {
					new OracleParameter(":C_ID", OracleDbType.Varchar2,100)			};
			parameters[0].Value = C_ID;

			return DbHelperOra.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Mod_TB_ITEM_TYPE model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into TB_ITEM_TYPE(");
			strSql.Append("C_ID,C_TYPE,C_ITEM_CODE,C_ITEM_NAME,N_STATUS,C_EMP_ID,D_MOD_DT,D_END_DATE,N_SORT)");
			strSql.Append(" values (");
			strSql.Append(":C_ID,:C_TYPE,:C_ITEM_CODE,:C_ITEM_NAME,:N_STATUS,:C_EMP_ID,:D_MOD_DT,:D_END_DATE,:N_SORT)");
			OracleParameter[] parameters = {
					new OracleParameter(":C_ID", OracleDbType.Varchar2,100),
					new OracleParameter(":C_TYPE", OracleDbType.Varchar2,100),
					new OracleParameter(":C_ITEM_CODE", OracleDbType.Varchar2,100),
					new OracleParameter(":C_ITEM_NAME", OracleDbType.Varchar2,100),
					new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
					new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
					new OracleParameter(":D_MOD_DT", OracleDbType.Date),
					new OracleParameter(":D_END_DATE", OracleDbType.Date),
					new OracleParameter(":N_SORT", OracleDbType.Decimal,3)};
			parameters[0].Value = model.C_ID;
			parameters[1].Value = model.C_TYPE;
			parameters[2].Value = model.C_ITEM_CODE;
			parameters[3].Value = model.C_ITEM_NAME;
			parameters[4].Value = model.N_STATUS;
			parameters[5].Value = model.C_EMP_ID;
			parameters[6].Value = model.D_MOD_DT;
			parameters[7].Value = model.D_END_DATE;
			parameters[8].Value = model.N_SORT;

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
		public bool Update(Mod_TB_ITEM_TYPE model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update TB_ITEM_TYPE set ");
			strSql.Append("C_TYPE=:C_TYPE,");
			strSql.Append("C_ITEM_CODE=:C_ITEM_CODE,");
			strSql.Append("C_ITEM_NAME=:C_ITEM_NAME,");
			strSql.Append("N_STATUS=:N_STATUS,");
			strSql.Append("C_EMP_ID=:C_EMP_ID,");
			strSql.Append("D_MOD_DT=:D_MOD_DT,");
			strSql.Append("D_END_DATE=:D_END_DATE,");
			strSql.Append("N_SORT=:N_SORT");
			strSql.Append(" where C_ID=:C_ID ");
			OracleParameter[] parameters = {
					new OracleParameter(":C_TYPE", OracleDbType.Varchar2,100),
					new OracleParameter(":C_ITEM_CODE", OracleDbType.Varchar2,100),
					new OracleParameter(":C_ITEM_NAME", OracleDbType.Varchar2,100),
					new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
					new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
					new OracleParameter(":D_MOD_DT", OracleDbType.Date),
					new OracleParameter(":D_END_DATE", OracleDbType.Date),
					new OracleParameter(":N_SORT", OracleDbType.Decimal,3),
					new OracleParameter(":C_ID", OracleDbType.Varchar2,100)};
			parameters[0].Value = model.C_TYPE;
			parameters[1].Value = model.C_ITEM_CODE;
			parameters[2].Value = model.C_ITEM_NAME;
			parameters[3].Value = model.N_STATUS;
			parameters[4].Value = model.C_EMP_ID;
			parameters[5].Value = model.D_MOD_DT;
			parameters[6].Value = model.D_END_DATE;
			parameters[7].Value = model.N_SORT;
			parameters[8].Value = model.C_ID;

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
			strSql.Append("delete from TB_ITEM_TYPE ");
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
			strSql.Append("delete from TB_ITEM_TYPE ");
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
		public Mod_TB_ITEM_TYPE GetModel(string C_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select C_ID,C_TYPE,C_ITEM_CODE,C_ITEM_NAME,N_STATUS,C_EMP_ID,D_MOD_DT,D_END_DATE,N_SORT from TB_ITEM_TYPE ");
			strSql.Append(" where C_ID=:C_ID ");
			OracleParameter[] parameters = {
					new OracleParameter(":C_ID", OracleDbType.Varchar2,100)			};
			parameters[0].Value = C_ID;

			Mod_TB_ITEM_TYPE model=new Mod_TB_ITEM_TYPE();
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
		public Mod_TB_ITEM_TYPE DataRowToModel(DataRow row)
		{
			Mod_TB_ITEM_TYPE model=new Mod_TB_ITEM_TYPE();
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
				if(row["C_ITEM_CODE"]!=null)
				{
					model.C_ITEM_CODE=row["C_ITEM_CODE"].ToString();
				}
				if(row["C_ITEM_NAME"]!=null)
				{
					model.C_ITEM_NAME=row["C_ITEM_NAME"].ToString();
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
					model.D_MOD_DT= DateTime.Parse(row["D_MOD_DT"].ToString());
				}
				if(row["D_END_DATE"]!=null && row["D_END_DATE"].ToString()!="")
				{
					model.D_END_DATE= DateTime.Parse(row["D_END_DATE"].ToString());
				}
				if(row["N_SORT"]!=null && row["N_SORT"].ToString()!="")
				{
					model.N_SORT=decimal.Parse(row["N_SORT"].ToString());
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
			strSql.Append("select C_ID,C_TYPE,C_ITEM_CODE,C_ITEM_NAME,N_STATUS,C_EMP_ID,D_MOD_DT,D_END_DATE,N_SORT ");
			strSql.Append(" FROM TB_ITEM_TYPE ");
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
			strSql.Append("select count(1) FROM TB_ITEM_TYPE ");
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
			strSql.Append(")AS Row, T.*  from TB_ITEM_TYPE T ");
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
			parameters[0].Value = "TB_ITEM_TYPE";
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
       /// 根据类型加载项目
       /// </summary>
       /// <param name="C_TYPE">类型</param>
       /// <returns></returns>
        public DataSet GetListByType(string C_TYPE)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_TYPE,C_ITEM_CODE,C_ITEM_NAME,N_STATUS,C_EMP_ID,D_MOD_DT,D_END_DATE,N_SORT from TB_ITEM_TYPE ");
            strSql.Append(" where C_TYPE=:C_TYPE ");
            strSql.Append(" order by N_SORT  ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_TYPE", OracleDbType.Varchar2,100)          };
            parameters[0].Value = C_TYPE;

            return DbHelperOra.Query(strSql.ToString(), parameters);
           
        }
        #endregion  ExtensionMethod
    }
}

