using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;
namespace DAL
{
    /// <summary>
    /// 数据访问类:TPB_HOOK
    /// </summary>
    public partial class Dal_TPB_HOOK
	{
		public Dal_TPB_HOOK()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string C_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from TPB_HOOK");
			strSql.Append(" where C_ID=:C_ID ");
			OracleParameter[] parameters = {
					new OracleParameter(":C_ID", OracleDbType.Varchar2,100)			};
			parameters[0].Value = C_ID;

			return DbHelperOra.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Mod_TPB_HOOK model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into TPB_HOOK(");
			strSql.Append("C_STA_ID,N_HOOK_NO,N_STATUS,C_EMP_ID,D_MOD_DT,C_REMARK)");
			strSql.Append(" values (");
			strSql.Append(":C_STA_ID,:N_HOOK_NO,:N_STATUS,:C_EMP_ID,:D_MOD_DT,:C_REMARK)");
			OracleParameter[] parameters = { 
					new OracleParameter(":C_STA_ID", OracleDbType.Varchar2,100),
					new OracleParameter(":N_HOOK_NO", OracleDbType.Decimal,5),
					new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
					new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
					new OracleParameter(":D_MOD_DT", OracleDbType.Date),
					new OracleParameter(":C_REMARK", OracleDbType.Varchar2,100)}; 
			parameters[0].Value = model.C_STA_ID;
			parameters[1].Value = model.N_HOOK_NO;
			parameters[2].Value = model.N_STATUS;
			parameters[3].Value = model.C_EMP_ID;
			parameters[4].Value = model.D_MOD_DT;
			parameters[5].Value = model.C_REMARK;

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
		public bool Update(Mod_TPB_HOOK model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update TPB_HOOK set ");
			strSql.Append("C_STA_ID=:C_STA_ID,");
			strSql.Append("N_HOOK_NO=:N_HOOK_NO,");
			strSql.Append("N_STATUS=:N_STATUS,");
			strSql.Append("C_EMP_ID=:C_EMP_ID,");
			strSql.Append("D_MOD_DT=:D_MOD_DT,");
			strSql.Append("C_REMARK=:C_REMARK");
			strSql.Append(" where C_ID=:C_ID ");
			OracleParameter[] parameters = {
					new OracleParameter(":C_STA_ID", OracleDbType.Varchar2,100),
					new OracleParameter(":N_HOOK_NO", OracleDbType.Decimal,5),
					new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
					new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
					new OracleParameter(":D_MOD_DT", OracleDbType.Date),
					new OracleParameter(":C_REMARK", OracleDbType.Varchar2,100),
					new OracleParameter(":C_ID", OracleDbType.Varchar2,100)};
			parameters[0].Value = model.C_STA_ID;
			parameters[1].Value = model.N_HOOK_NO;
			parameters[2].Value = model.N_STATUS;
			parameters[3].Value = model.C_EMP_ID;
			parameters[4].Value = model.D_MOD_DT;
			parameters[5].Value = model.C_REMARK;
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
			strSql.Append("delete from TPB_HOOK ");
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
			strSql.Append("delete from TPB_HOOK ");
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
		public Mod_TPB_HOOK GetModel(string C_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select C_ID,C_STA_ID,N_HOOK_NO,N_STATUS,C_EMP_ID,D_MOD_DT,C_REMARK from TPB_HOOK ");
			strSql.Append(" where C_ID=:C_ID ");
			OracleParameter[] parameters = {
					new OracleParameter(":C_ID", OracleDbType.Varchar2,100)			};
			parameters[0].Value = C_ID;

			Mod_TPB_HOOK model=new Mod_TPB_HOOK();
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
		public Mod_TPB_HOOK DataRowToModel(DataRow row)
		{
			Mod_TPB_HOOK model=new Mod_TPB_HOOK();
			if (row != null)
			{
				if(row["C_ID"]!=null)
				{
					model.C_ID=row["C_ID"].ToString();
				}
				if(row["C_STA_ID"]!=null)
				{
					model.C_STA_ID=row["C_STA_ID"].ToString();
				}
				if(row["N_HOOK_NO"]!=null && row["N_HOOK_NO"].ToString()!="")
				{
					model.N_HOOK_NO=decimal.Parse(row["N_HOOK_NO"].ToString());
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
				if(row["C_REMARK"]!=null)
				{
					model.C_REMARK=row["C_REMARK"].ToString();
				}
			}
			return model;
		}

        /// <summary>
        /// 获得数据列表
        /// </summary>
        /// <param name="c_batch_no">批号</param>
        /// <param name="c_sta_id">产线</param>
        /// <returns></returns>
        public DataSet GetList(string c_batch_no,string c_sta_id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select C_ID,C_STA_ID,N_HOOK_NO,N_STATUS,C_EMP_ID,D_MOD_DT,C_REMARK ");
			strSql.Append(" FROM TPB_HOOK where  N_STATUS =1 and N_HOOK_NO not in (select a.c_tick_no  from TQC_PRESENT_SAMPLES a where a.c_batch_no='"+ c_batch_no + "') ");
			if(c_sta_id.Trim()!="")
			{
				strSql.Append(" and c_sta_id='"+ c_sta_id + "'");
			}
            strSql.Append(" order by n_hook_no");
            return DbHelperOra.Query(strSql.ToString());
		}
        /// <summary>
        /// 获得数据列表
        /// </summary>
        /// <param name="N_HOOK_NO">钩号</param>
        /// <param name="c_sta_id">产线</param>
        /// <returns></returns>
        public DataSet GetList_Query(string N_HOOK_NO, string c_sta_id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select t.C_ID,a.c_sta_desc,t.C_STA_ID,t.N_HOOK_NO,t.N_STATUS,t.C_EMP_ID,t.D_MOD_DT,t.C_REMARK ");
            strSql.Append(" FROM TPB_HOOK t join tb_sta a on t.C_STA_ID=a.c_id where  t.N_STATUS =1 ");
            if (c_sta_id.Trim() != "")
            {
                strSql.Append(" and t.c_sta_id='" + c_sta_id + "'");
            }
            if (!string.IsNullOrEmpty(N_HOOK_NO))
            {
                strSql.Append(" and t.N_HOOK_NO='" + N_HOOK_NO + "'");
            }
            strSql.Append(" order by t.n_hook_no");
            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM TPB_HOOK ");
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
			strSql.Append(")AS Row, T.*  from TPB_HOOK T ");
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
			parameters[0].Value = "TPB_HOOK";
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

