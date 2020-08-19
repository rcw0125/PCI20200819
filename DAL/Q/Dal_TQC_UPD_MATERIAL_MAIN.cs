using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;
namespace DAL
{
    /// <summary>
    /// 数据访问类:TQC_UPD_MATERIAL_MAIN
    /// </summary>
    public partial class Dal_TQC_UPD_MATERIAL_MAIN
	{
		public Dal_TQC_UPD_MATERIAL_MAIN()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string C_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from TQC_UPD_MATERIAL_MAIN");
			strSql.Append(" where C_ID=:C_ID ");
			OracleParameter[] parameters = {
					new OracleParameter(":C_ID", OracleDbType.Varchar2,100)			};
			parameters[0].Value = C_ID;

			return DbHelperOra.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Mod_TQC_UPD_MATERIAL_MAIN model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into TQC_UPD_MATERIAL_MAIN(");
			strSql.Append("C_BATCH_NO,C_REMARK,N_STATUS,C_EMP_ID,D_MOD_DT)");
			strSql.Append(" values (");
			strSql.Append(":C_BATCH_NO,:C_REMARK,:N_STATUS,:C_EMP_ID,:D_MOD_DT)");
			OracleParameter[] parameters = {
					new OracleParameter(":C_BATCH_NO", OracleDbType.Varchar2,100),
					new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
					new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
					new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
					new OracleParameter(":D_MOD_DT", OracleDbType.Date)};
			parameters[0].Value = model.C_BATCH_NO;
			parameters[1].Value = model.C_REMARK;
			parameters[2].Value = model.N_STATUS;
			parameters[3].Value = model.C_EMP_ID;
			parameters[4].Value = model.D_MOD_DT;

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
		public bool Update(Mod_TQC_UPD_MATERIAL_MAIN model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update TQC_UPD_MATERIAL_MAIN set ");
			strSql.Append("C_BATCH_NO=:C_BATCH_NO,");
			strSql.Append("C_REMARK=:C_REMARK,");
			strSql.Append("N_STATUS=:N_STATUS,");
			strSql.Append("C_EMP_ID=:C_EMP_ID,");
			strSql.Append("D_MOD_DT=:D_MOD_DT");
			strSql.Append(" where C_ID=:C_ID ");
			OracleParameter[] parameters = {
					new OracleParameter(":C_BATCH_NO", OracleDbType.Varchar2,100),
					new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
					new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
					new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
					new OracleParameter(":D_MOD_DT", OracleDbType.Date),
					new OracleParameter(":C_ID", OracleDbType.Varchar2,100)};
			parameters[0].Value = model.C_BATCH_NO;
			parameters[1].Value = model.C_REMARK;
			parameters[2].Value = model.N_STATUS;
			parameters[3].Value = model.C_EMP_ID;
			parameters[4].Value = model.D_MOD_DT;
			parameters[5].Value = model.C_ID;

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
			strSql.Append("delete from TQC_UPD_MATERIAL_MAIN ");
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
			strSql.Append("delete from TQC_UPD_MATERIAL_MAIN ");
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
		public Mod_TQC_UPD_MATERIAL_MAIN GetModel(string C_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select C_ID,C_BATCH_NO,C_REMARK,N_STATUS,C_EMP_ID,D_MOD_DT from TQC_UPD_MATERIAL_MAIN ");
			strSql.Append(" where C_ID=:C_ID ");
			OracleParameter[] parameters = {
					new OracleParameter(":C_ID", OracleDbType.Varchar2,100)			};
			parameters[0].Value = C_ID;

			Mod_TQC_UPD_MATERIAL_MAIN model=new Mod_TQC_UPD_MATERIAL_MAIN();
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
        /// 更新一条数据
        /// </summary>
        public bool Update_BATCH_NO(string C_BATCH_NO)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("UPDATE TQC_UPD_MATERIAL_MAIN T SET T.N_STATUS = 0 WHERE T.C_BATCH_NO='"+ C_BATCH_NO + "' AND T.N_STATUS=1 "); 
            int rows = DbHelperOra.ExecuteSql(strSql.ToString());
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
        public bool Update_BATCH_NO_Trans(string C_BATCH_NO)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("UPDATE TQC_UPD_MATERIAL_MAIN T SET T.N_STATUS = 0 WHERE T.C_BATCH_NO='" + C_BATCH_NO + "' AND T.N_STATUS=1 ");
            int rows = TransactionHelper.ExecuteSql(strSql.ToString());
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
        public Mod_TQC_UPD_MATERIAL_MAIN DataRowToModel(DataRow row)
		{
			Mod_TQC_UPD_MATERIAL_MAIN model=new Mod_TQC_UPD_MATERIAL_MAIN();
			if (row != null)
			{
				if(row["C_ID"]!=null)
				{
					model.C_ID=row["C_ID"].ToString();
				}
				if(row["C_BATCH_NO"]!=null)
				{
					model.C_BATCH_NO=row["C_BATCH_NO"].ToString();
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
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select C_ID,C_BATCH_NO,C_REMARK,N_STATUS,C_EMP_ID,D_MOD_DT ");
			strSql.Append(" FROM TQC_UPD_MATERIAL_MAIN where N_STATUS=1 ");
			if(strWhere.Trim()!="")
			{
                strSql.Append(" AND  C_BATCH_NO LIKE '" + strWhere + "%' ");
            }
			return DbHelperOra.Query(strSql.ToString());
		}
        /// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList_BatchNo(string BatchNo)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select Min(D_MOD_DT)D_MOD_DT ");
            strSql.Append(" FROM TQC_UPD_MATERIAL_MAIN where 1=1 ");
            if (BatchNo.Trim() != "")
            {
                strSql.Append(" AND  C_BATCH_NO = '" + BatchNo + "' ");
            }
            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList_Query(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT T2.C_LINEWH_NAME, T1.C_BATCH_NO, T1.C_TICK_NO, T1.C_STL_GRD, T1.C_STD_CODE,  T1.N_WGT,  T1.C_LINEWH_CODE, T1.C_MAT_CODE, T1.C_MAT_DESC, T.C_ID, T.C_BATCH_NO,  T.C_REMARK,  T.N_STATUS, T.C_EMP_ID,  T.D_MOD_DT ");
            strSql.Append(" FROM TQC_UPD_MATERIAL_MAIN T LEFT JOIN TRC_ROLL_PRODCUT T1 ON T.C_BATCH_NO = T1.C_BATCH_NO LEFT JOIN TPB_LINEWH T2  ON T1.C_LINEWH_CODE = T2.C_LINEWH_CODE WHERE T.N_STATUS = 1  ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" AND  T1.C_BATCH_NO LIKE '"+ strWhere + "' " );
            }
            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM TQC_UPD_MATERIAL_MAIN ");
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
			strSql.Append(")AS Row, T.*  from TQC_UPD_MATERIAL_MAIN T ");
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
			parameters[0].Value = "TQC_UPD_MATERIAL_MAIN";
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

