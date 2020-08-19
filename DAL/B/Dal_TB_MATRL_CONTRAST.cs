using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;
namespace DAL
{
    /// <summary>
    /// 数据访问类:TB_MATRL_CONTRAST
    /// </summary>
    public partial class Dal_TB_MATRL_CONTRAST
	{
		public Dal_TB_MATRL_CONTRAST()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string C_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from TB_MATRL_CONTRAST");
			strSql.Append(" where C_ID=:C_ID ");
			OracleParameter[] parameters = {
					new OracleParameter(":C_ID", OracleDbType.Varchar2,100)			};
			parameters[0].Value = C_ID;

			return DbHelperOra.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Mod_TB_MATRL_CONTRAST model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into TB_MATRL_CONTRAST(");
			strSql.Append("C_SLAB_SIZE,N_SLAB_LENTH,C_KP_SIZE,N_KP_LENTH,C_EMP_ID,D_MOD_DT,C_REMARK1,C_REMARK2,C_REMARK3)");
			strSql.Append(" values (");
			strSql.Append(":C_SLAB_SIZE,:N_SLAB_LENTH,:C_KP_SIZE,:N_KP_LENTH,:C_EMP_ID,:D_MOD_DT,:C_REMARK1,:C_REMARK2,:C_REMARK3)");
			OracleParameter[] parameters = {
					new OracleParameter(":C_SLAB_SIZE", OracleDbType.Varchar2,50),
					new OracleParameter(":N_SLAB_LENTH", OracleDbType.Decimal,4),
					new OracleParameter(":C_KP_SIZE", OracleDbType.Varchar2,50),
					new OracleParameter(":N_KP_LENTH", OracleDbType.Decimal,4),
					new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
					new OracleParameter(":D_MOD_DT", OracleDbType.Date),
					new OracleParameter(":C_REMARK1", OracleDbType.Varchar2,200),
					new OracleParameter(":C_REMARK2", OracleDbType.Varchar2,200),
					new OracleParameter(":C_REMARK3", OracleDbType.Varchar2,200)};
			parameters[0].Value = model.C_SLAB_SIZE;
			parameters[1].Value = model.N_SLAB_LENTH;
			parameters[2].Value = model.C_KP_SIZE;
			parameters[3].Value = model.N_KP_LENTH;
			parameters[4].Value = model.C_EMP_ID;
			parameters[5].Value = model.D_MOD_DT;
			parameters[6].Value = model.C_REMARK1;
			parameters[7].Value = model.C_REMARK2;
			parameters[8].Value = model.C_REMARK3;

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
		public bool Update(Mod_TB_MATRL_CONTRAST model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update TB_MATRL_CONTRAST set ");
			strSql.Append("C_SLAB_SIZE=:C_SLAB_SIZE,");
			strSql.Append("N_SLAB_LENTH=:N_SLAB_LENTH,");
			strSql.Append("C_KP_SIZE=:C_KP_SIZE,");
			strSql.Append("N_KP_LENTH=:N_KP_LENTH,");
			strSql.Append("C_EMP_ID=:C_EMP_ID,");
			strSql.Append("D_MOD_DT=:D_MOD_DT,");
			strSql.Append("C_REMARK1=:C_REMARK1,");
			strSql.Append("C_REMARK2=:C_REMARK2,");
			strSql.Append("C_REMARK3=:C_REMARK3");
			strSql.Append(" where C_ID=:C_ID ");
			OracleParameter[] parameters = {
					new OracleParameter(":C_SLAB_SIZE", OracleDbType.Varchar2,50),
					new OracleParameter(":N_SLAB_LENTH", OracleDbType.Decimal,4),
					new OracleParameter(":C_KP_SIZE", OracleDbType.Varchar2,50),
					new OracleParameter(":N_KP_LENTH", OracleDbType.Decimal,4),
					new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
					new OracleParameter(":D_MOD_DT", OracleDbType.Date),
					new OracleParameter(":C_REMARK1", OracleDbType.Varchar2,200),
					new OracleParameter(":C_REMARK2", OracleDbType.Varchar2,200),
					new OracleParameter(":C_REMARK3", OracleDbType.Varchar2,200),
					new OracleParameter(":C_ID", OracleDbType.Varchar2,100)};
			parameters[0].Value = model.C_SLAB_SIZE;
			parameters[1].Value = model.N_SLAB_LENTH;
			parameters[2].Value = model.C_KP_SIZE;
			parameters[3].Value = model.N_KP_LENTH;
			parameters[4].Value = model.C_EMP_ID;
			parameters[5].Value = model.D_MOD_DT;
			parameters[6].Value = model.C_REMARK1;
			parameters[7].Value = model.C_REMARK2;
			parameters[8].Value = model.C_REMARK3;
			parameters[9].Value = model.C_ID;

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
			strSql.Append("delete from TB_MATRL_CONTRAST ");
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
			strSql.Append("delete from TB_MATRL_CONTRAST ");
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
		public Mod_TB_MATRL_CONTRAST GetModel(string C_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select C_ID,C_SLAB_SIZE,N_SLAB_LENTH,C_KP_SIZE,N_KP_LENTH,C_EMP_ID,D_MOD_DT,C_REMARK1,C_REMARK2,C_REMARK3 from TB_MATRL_CONTRAST ");
			strSql.Append(" where C_ID=:C_ID ");
			OracleParameter[] parameters = {
					new OracleParameter(":C_ID", OracleDbType.Varchar2,100)			};
			parameters[0].Value = C_ID;

			Mod_TB_MATRL_CONTRAST model=new Mod_TB_MATRL_CONTRAST();
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
		public Mod_TB_MATRL_CONTRAST DataRowToModel(DataRow row)
		{
			Mod_TB_MATRL_CONTRAST model=new Mod_TB_MATRL_CONTRAST();
			if (row != null)
			{
				if(row["C_ID"]!=null)
				{
					model.C_ID=row["C_ID"].ToString();
				}
				if(row["C_SLAB_SIZE"]!=null)
				{
					model.C_SLAB_SIZE=row["C_SLAB_SIZE"].ToString();
				}
				if(row["N_SLAB_LENTH"]!=null && row["N_SLAB_LENTH"].ToString()!="")
				{
					model.N_SLAB_LENTH=decimal.Parse(row["N_SLAB_LENTH"].ToString());
				}
				if(row["C_KP_SIZE"]!=null)
				{
					model.C_KP_SIZE=row["C_KP_SIZE"].ToString();
				}
				if(row["N_KP_LENTH"]!=null && row["N_KP_LENTH"].ToString()!="")
				{
					model.N_KP_LENTH=decimal.Parse(row["N_KP_LENTH"].ToString());
				}
				if(row["C_EMP_ID"]!=null)
				{
					model.C_EMP_ID=row["C_EMP_ID"].ToString();
				}
				if(row["D_MOD_DT"]!=null && row["D_MOD_DT"].ToString()!="")
				{
					model.D_MOD_DT=DateTime.Parse(row["D_MOD_DT"].ToString());
				}
				if(row["C_REMARK1"]!=null)
				{
					model.C_REMARK1=row["C_REMARK1"].ToString();
				}
				if(row["C_REMARK2"]!=null)
				{
					model.C_REMARK2=row["C_REMARK2"].ToString();
				}
				if(row["C_REMARK3"]!=null)
				{
					model.C_REMARK3=row["C_REMARK3"].ToString();
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
			strSql.Append("select C_ID,C_SLAB_SIZE,N_SLAB_LENTH,C_KP_SIZE,N_KP_LENTH,C_EMP_ID,D_MOD_DT,C_REMARK1,C_REMARK2,C_REMARK3 ");
			strSql.Append(" FROM TB_MATRL_CONTRAST ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperOra.Query(strSql.ToString());
		}
        /// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList_Slab(string C_SLAB_SIZE,string N_SLAB_LENTH)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_SLAB_SIZE,N_SLAB_LENTH,C_KP_SIZE,N_KP_LENTH,C_EMP_ID,D_MOD_DT,C_REMARK1,C_REMARK2,C_REMARK3 ");
            strSql.Append(" FROM TB_MATRL_CONTRAST where   C_SLAB_SIZE='"+ C_SLAB_SIZE + "' and  N_SLAB_LENTH = '"+ N_SLAB_LENTH + "'");
             
            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM TB_MATRL_CONTRAST ");
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
			strSql.Append(")AS Row, T.*  from TB_MATRL_CONTRAST T ");
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
			parameters[0].Value = "TB_MATRL_CONTRAST";
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

