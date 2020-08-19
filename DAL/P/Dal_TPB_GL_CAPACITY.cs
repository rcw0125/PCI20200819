using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;
namespace DAL
{
	/// <summary>
	/// 数据访问类:TPB_GL_CAPACITY
	/// </summary>
	public partial class Dal_TPB_GL_CAPACITY
    {
		public Dal_TPB_GL_CAPACITY()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string C_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from TPB_GL_CAPACITY");
			strSql.Append(" where C_ID=:C_ID ");
			OracleParameter[] parameters = {
					new OracleParameter(":C_ID", OracleDbType.Varchar2,100)			};
			parameters[0].Value = C_ID;

			return DbHelperOra.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Mod_TPB_GL_CAPACITY model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into TPB_GL_CAPACITY(");
			strSql.Append("C_PRO_ID,C_STA_ID,C_STA_DESC,C_STA_CODE,N_CAPACITY,D_START_DATE,D_END_DATE,C_EMP_ID)");
			strSql.Append(" values (");
			strSql.Append(":C_PRO_ID,:C_STA_ID,:C_STA_DESC,:C_STA_CODE,:N_CAPACITY,:D_START_DATE,:D_END_DATE,:C_EMP_ID)");
			OracleParameter[] parameters = {
					
					new OracleParameter(":C_PRO_ID", OracleDbType.Varchar2,100),
					new OracleParameter(":C_STA_ID", OracleDbType.Varchar2,100),
					new OracleParameter(":C_STA_DESC", OracleDbType.Varchar2,100),
					new OracleParameter(":C_STA_CODE", OracleDbType.Varchar2,100),
					new OracleParameter(":N_CAPACITY", OracleDbType.Double,15),
					new OracleParameter(":D_START_DATE", OracleDbType.Date),
					new OracleParameter(":D_END_DATE", OracleDbType.Date),
					new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100)};
			parameters[0].Value = model.C_PRO_ID;
            parameters[1].Value =model.C_STA_ID; 
			parameters[2].Value =model.C_STA_DESC; 
			parameters[3].Value =model.C_STA_CODE; 
			parameters[4].Value =model.N_CAPACITY; 
			parameters[5].Value =model.D_START_DATE; 
			parameters[6].Value =model.D_END_DATE; 
			parameters[7].Value = model.C_EMP_ID;

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
		/// <summary>OracleDbType.Date
		/// 更新一条数据
		/// </summary>
		public bool Update(Mod_TPB_GL_CAPACITY model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update TPB_GL_CAPACITY set ");
			strSql.Append("C_PRO_ID=:C_PRO_ID,");
			strSql.Append("C_STA_ID=:C_STA_ID,");
			strSql.Append("C_STA_DESC=:C_STA_DESC,");
			strSql.Append("C_STA_CODE=:C_STA_CODE,");
			strSql.Append("N_CAPACITY=:N_CAPACITY,");
			strSql.Append("D_START_DATE=:D_START_DATE,");
			strSql.Append("D_END_DATE=:D_END_DATE,");
			strSql.Append("N_STATUS=:N_STATUS,");
			strSql.Append("C_EMP_ID=:C_EMP_ID,");
			strSql.Append("D_MOD_DT=:D_MOD_DT");
			strSql.Append(" where C_ID=:C_ID ");
			OracleParameter[] parameters = {
					new OracleParameter(":C_PRO_ID", OracleDbType.Varchar2,100),
					new OracleParameter(":C_STA_ID", OracleDbType.Varchar2,100),
					new OracleParameter(":C_STA_DESC", OracleDbType.Varchar2,100),
					new OracleParameter(":C_STA_CODE", OracleDbType.Varchar2,100),
					new OracleParameter(":N_CAPACITY", OracleDbType.Double,15),
					new OracleParameter(":D_START_DATE", OracleDbType.Date),
					new OracleParameter(":D_END_DATE", OracleDbType.Date),
					new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
					new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
					new OracleParameter(":D_MOD_DT", OracleDbType.Date),
					new OracleParameter(":C_ID", OracleDbType.Varchar2,100)};
			parameters[0].Value = model.C_PRO_ID;
			parameters[1].Value = model.C_STA_ID;
			parameters[2].Value = model.C_STA_DESC;
			parameters[3].Value = model.C_STA_CODE;
			parameters[4].Value = model.N_CAPACITY;
			parameters[5].Value = model.D_START_DATE;
			parameters[6].Value = model.D_END_DATE;
			parameters[7].Value = model.N_STATUS;
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
			strSql.Append("delete from TPB_GL_CAPACITY ");
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
			strSql.Append("delete from TPB_GL_CAPACITY ");
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
		public Mod_TPB_GL_CAPACITY GetModel(string C_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select C_ID,C_PRO_ID,C_STA_ID,C_STA_DESC,C_STA_CODE,N_CAPACITY,D_START_DATE,D_END_DATE,N_STATUS,C_EMP_ID,D_MOD_DT from TPB_GL_CAPACITY ");
			strSql.Append(" where C_ID=:C_ID ");
			OracleParameter[] parameters = {
					new OracleParameter(":C_ID", OracleDbType.Varchar2,100)			};
			parameters[0].Value = C_ID;

			Mod_TPB_GL_CAPACITY model=new Mod_TPB_GL_CAPACITY();
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
		public Mod_TPB_GL_CAPACITY DataRowToModel(DataRow row)
		{
			Mod_TPB_GL_CAPACITY model=new Mod_TPB_GL_CAPACITY();
			if (row != null)
			{
				if(row["C_ID"]!=null)
				{
					model.C_ID=row["C_ID"].ToString();
				}
				if(row["C_PRO_ID"]!=null)
				{
					model.C_PRO_ID=row["C_PRO_ID"].ToString();
				}
				if(row["C_STA_ID"]!=null)
				{
					model.C_STA_ID=row["C_STA_ID"].ToString();
				}
				if(row["C_STA_DESC"]!=null)
				{
					model.C_STA_DESC=row["C_STA_DESC"].ToString();
				}
				if(row["C_STA_CODE"]!=null)
				{
					model.C_STA_CODE=row["C_STA_CODE"].ToString();
				}
				if(row["N_CAPACITY"]!=null && row["N_CAPACITY"].ToString()!="")
				{
					model.N_CAPACITY=decimal.Parse(row["N_CAPACITY"].ToString());
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
		public DataSet GetList(string C_PRO_ID, string C_STA_CODE, int N_STATUS)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select C_ID,C_PRO_ID,C_STA_ID,C_STA_DESC,C_STA_CODE,N_CAPACITY,D_START_DATE,D_END_DATE,DECODE(N_STATUS,1,'启用','停用') N_STATUS,C_EMP_ID,D_MOD_DT ");
			strSql.Append(" FROM TPB_GL_CAPACITY WHERE N_STATUS='"+ N_STATUS + "'  ");
			if(C_PRO_ID.Trim()!="")
			{
				strSql.Append(" AND C_PRO_ID='" + C_PRO_ID + "' " );
			}
            if (C_STA_CODE.Trim() != "")
            {
                strSql.Append(" AND C_STA_CODE='" + C_STA_CODE + "' ");
            }
            return DbHelperOra.Query(strSql.ToString());
		}


        #endregion  BasicMethod
        #region  ExtensionMethod
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string C_STA_ID, int N_STATUS)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_PRO_ID,C_STA_ID,C_STA_DESC,C_STA_CODE,N_CAPACITY,D_START_DATE,D_END_DATE,DECODE(N_STATUS,1,'启用','停用') N_STATUS,C_EMP_ID,D_MOD_DT ");
            strSql.Append(" FROM TPB_GL_CAPACITY WHERE N_STATUS='" + N_STATUS + "'  ");
            if (C_STA_ID.Trim() != "")
            {
                strSql.Append(" AND C_STA_ID='" + C_STA_ID + "' ");
            }
            return DbHelperOra.Query(strSql.ToString());
        }
        #endregion  ExtensionMethod
    }
}

