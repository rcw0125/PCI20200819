using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;
namespace DAL
{
    /// <summary>
    /// 数据访问类:TQC_UPDATE_MATERIAL_LOG
    /// </summary>
    public partial class Dal_TQC_UPDATE_MATERIAL_LOG
	{
		public Dal_TQC_UPDATE_MATERIAL_LOG()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string C_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from TQC_UPDATE_MATERIAL_LOG");
			strSql.Append(" where C_ID=:C_ID ");
			OracleParameter[] parameters = {
					new OracleParameter(":C_ID", OracleDbType.Varchar2,100)			};
			parameters[0].Value = C_ID;

			return DbHelperOra.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Mod_TQC_UPDATE_MATERIAL_LOG model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into TQC_UPDATE_MATERIAL_LOG(");
			strSql.Append("C_ROLL_PRODUCT_ID,C_TYPE,N_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT,N_WGT,N_WGT_DIFFERENCE,C_SFHG)");
			strSql.Append(" values (");
			strSql.Append(":C_ROLL_PRODUCT_ID,:C_TYPE,:N_STATUS,:C_REMARK,:C_EMP_ID,:D_MOD_DT,:N_WGT,:N_WGT_DIFFERENCE,:C_SFHG)");
			OracleParameter[] parameters = { 
					new OracleParameter(":C_ROLL_PRODUCT_ID", OracleDbType.Varchar2,100),
					new OracleParameter(":C_TYPE", OracleDbType.Varchar2,100),
					new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
					new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
					new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
					new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":N_WGT", OracleDbType.Decimal,6),
                    new OracleParameter(":N_WGT_DIFFERENCE", OracleDbType.Decimal,6),
                    new OracleParameter(":C_SFHG", OracleDbType.Varchar2,100)}; 
			parameters[0].Value = model.C_ROLL_PRODUCT_ID;
			parameters[1].Value = model.C_TYPE;
			parameters[2].Value = model.N_STATUS;
			parameters[3].Value = model.C_REMARK;
			parameters[4].Value = model.C_EMP_ID;
			parameters[5].Value = model.D_MOD_DT;
			parameters[6].Value = model.N_WGT;
			parameters[7].Value = model.N_WGT_DIFFERENCE;
			parameters[8].Value = model.C_SFHG;

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
		/// 增加一条数据
		/// </summary>
		public bool Add_Trans(Mod_TQC_UPDATE_MATERIAL_LOG model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TQC_UPDATE_MATERIAL_LOG(");
            strSql.Append("C_ROLL_PRODUCT_ID,C_TYPE,N_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT,N_WGT,N_WGT_DIFFERENCE,C_SFHG)");
            strSql.Append(" values (");
            strSql.Append(":C_ROLL_PRODUCT_ID,:C_TYPE,:N_STATUS,:C_REMARK,:C_EMP_ID,:D_MOD_DT,:N_WGT,:N_WGT_DIFFERENCE,:C_SFHG)");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ROLL_PRODUCT_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_TYPE", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":N_WGT", OracleDbType.Decimal,6),
                    new OracleParameter(":N_WGT_DIFFERENCE", OracleDbType.Decimal,6),
                    new OracleParameter(":C_SFHG", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.C_ROLL_PRODUCT_ID;
            parameters[1].Value = model.C_TYPE;
            parameters[2].Value = model.N_STATUS;
            parameters[3].Value = model.C_REMARK;
            parameters[4].Value = model.C_EMP_ID;
            parameters[5].Value = model.D_MOD_DT;
            parameters[6].Value = model.N_WGT;
            parameters[7].Value = model.N_WGT_DIFFERENCE;
            parameters[8].Value = model.C_SFHG;

            int rows = TransactionHelper.ExecuteSql(strSql.ToString(), parameters);
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
        public bool Update(Mod_TQC_UPDATE_MATERIAL_LOG model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update TQC_UPDATE_MATERIAL_LOG set ");
			strSql.Append("C_ROLL_PRODUCT_ID=:C_ROLL_PRODUCT_ID,");
			strSql.Append("C_TYPE=:C_TYPE,");
			strSql.Append("N_STATUS=:N_STATUS,");
			strSql.Append("C_REMARK=:C_REMARK,");
			strSql.Append("C_EMP_ID=:C_EMP_ID,");
			strSql.Append("D_MOD_DT=:D_MOD_DT,");
			strSql.Append("N_WGT=:N_WGT,");
			strSql.Append("N_WGT_DIFFERENCE=:N_WGT_DIFFERENCE,");
			strSql.Append("C_SFHG=:C_SFHG");
			strSql.Append(" where C_ID=:C_ID ");
			OracleParameter[] parameters = {
					new OracleParameter(":C_ROLL_PRODUCT_ID", OracleDbType.Varchar2,100),
					new OracleParameter(":C_TYPE", OracleDbType.Varchar2,100),
					new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
					new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
					new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
					new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":N_WGT", OracleDbType.Decimal,6),
                    new OracleParameter(":N_WGT_DIFFERENCE", OracleDbType.Decimal,6),
                    new OracleParameter(":C_SFHG", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)};
			parameters[0].Value = model.C_ROLL_PRODUCT_ID;
			parameters[1].Value = model.C_TYPE;
			parameters[2].Value = model.N_STATUS;
			parameters[3].Value = model.C_REMARK;
			parameters[4].Value = model.C_EMP_ID;
			parameters[5].Value = model.D_MOD_DT;
            parameters[6].Value = model.N_WGT;
            parameters[7].Value = model.N_WGT_DIFFERENCE;
            parameters[8].Value = model.C_SFHG;
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
			strSql.Append("delete from TQC_UPDATE_MATERIAL_LOG ");
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
			strSql.Append("delete from TQC_UPDATE_MATERIAL_LOG ");
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
		public Mod_TQC_UPDATE_MATERIAL_LOG GetModel(string C_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select C_ID,C_ROLL_PRODUCT_ID,C_TYPE,N_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT,N_WGT,N_WGT_DIFFERENCE,C_SFHG from TQC_UPDATE_MATERIAL_LOG ");
			strSql.Append(" where C_ID=:C_ID ");
			OracleParameter[] parameters = {
					new OracleParameter(":C_ID", OracleDbType.Varchar2,100)			};
			parameters[0].Value = C_ID;

			Mod_TQC_UPDATE_MATERIAL_LOG model=new Mod_TQC_UPDATE_MATERIAL_LOG();
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
		public Mod_TQC_UPDATE_MATERIAL_LOG DataRowToModel(DataRow row)
		{
			Mod_TQC_UPDATE_MATERIAL_LOG model=new Mod_TQC_UPDATE_MATERIAL_LOG();
			if (row != null)
			{
				if(row["C_ID"]!=null)
				{
					model.C_ID=row["C_ID"].ToString();
				}
				if(row["C_ROLL_PRODUCT_ID"]!=null)
				{
					model.C_ROLL_PRODUCT_ID=row["C_ROLL_PRODUCT_ID"].ToString();
				}
				if(row["C_TYPE"]!=null)
				{
					model.C_TYPE=row["C_TYPE"].ToString();
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
                if (row["N_WGT"] != null && row["N_WGT"].ToString() != "")
                {
                    model.N_WGT = decimal.Parse(row["N_WGT"].ToString());
                }
                if (row["N_WGT_DIFFERENCE"] != null && row["N_WGT_DIFFERENCE"].ToString() != "")
                {
                    model.N_WGT_DIFFERENCE = decimal.Parse(row["N_WGT_DIFFERENCE"].ToString());
                }
                if (row["C_SFHG"] != null)
                {
                    model.C_SFHG = row["C_SFHG"].ToString();
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
			strSql.Append("select C_ID,C_ROLL_PRODUCT_ID,C_TYPE,N_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT,N_WGT,N_WGT_DIFFERENCE,C_SFHG ");
			strSql.Append(" FROM TQC_UPDATE_MATERIAL_LOG ");
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
			strSql.Append("select count(1) FROM TQC_UPDATE_MATERIAL_LOG ");
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
			strSql.Append(")AS Row, T.*  from TQC_UPDATE_MATERIAL_LOG T ");
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
			parameters[0].Value = "TQC_UPDATE_MATERIAL_LOG";
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

