using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;
namespace DAL
{
	/// <summary>
	/// 数据访问类:TQB_COPING_BASIC
	/// </summary>
	public partial class Dal_TQB_COPING_BASIC
	{
		public Dal_TQB_COPING_BASIC()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string C_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from TQB_COPING_BASIC");
			strSql.Append(" where C_ID=:C_ID ");
			OracleParameter[] parameters = {
					new OracleParameter(":C_ID", OracleDbType.Varchar2,100)			};
			parameters[0].Value = C_ID;

			return DbHelperOra.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Mod_TQB_COPING_BASIC model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into TQB_COPING_BASIC(");
			strSql.Append("C_COPING_CRAFT,C_CRAFT_FLOW,N_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT,C_IS_BXG)");
			strSql.Append(" values (");
			strSql.Append(":C_COPING_CRAFT,:C_CRAFT_FLOW,:N_STATUS,:C_REMARK,:C_EMP_ID,:D_MOD_DT,:C_IS_BXG)");
			OracleParameter[] parameters = {
					new OracleParameter(":C_COPING_CRAFT", OracleDbType.Varchar2,100),
					new OracleParameter(":C_CRAFT_FLOW", OracleDbType.Varchar2,500),
					new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
					new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
					new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
					new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":C_IS_BXG", OracleDbType.Varchar2,100)
            };
			parameters[0].Value = model.C_COPING_CRAFT;
			parameters[1].Value = model.C_CRAFT_FLOW;
			parameters[2].Value = model.N_STATUS;
			parameters[3].Value = model.C_REMARK;
			parameters[4].Value = model.C_EMP_ID;
			parameters[5].Value = model.D_MOD_DT;
            parameters[6].Value = model.C_IS_BXG;

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
		public bool Update(Mod_TQB_COPING_BASIC model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update TQB_COPING_BASIC set ");
			strSql.Append("C_COPING_CRAFT=:C_COPING_CRAFT,");
			strSql.Append("C_CRAFT_FLOW=:C_CRAFT_FLOW,");
			strSql.Append("N_STATUS=:N_STATUS,");
			strSql.Append("C_REMARK=:C_REMARK,");
			strSql.Append("C_EMP_ID=:C_EMP_ID,");
			strSql.Append("D_MOD_DT=:D_MOD_DT,");
            strSql.Append("C_IS_BXG=:C_IS_BXG");
            strSql.Append(" where C_ID=:C_ID ");
			OracleParameter[] parameters = {
					new OracleParameter(":C_COPING_CRAFT", OracleDbType.Varchar2,100),
					new OracleParameter(":C_CRAFT_FLOW", OracleDbType.Varchar2,500),
					new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
					new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
					new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
					new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":C_IS_BXG", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)};
			parameters[0].Value = model.C_COPING_CRAFT;
			parameters[1].Value = model.C_CRAFT_FLOW;
			parameters[2].Value = model.N_STATUS;
			parameters[3].Value = model.C_REMARK;
			parameters[4].Value = model.C_EMP_ID;
			parameters[5].Value = model.D_MOD_DT;
            parameters[6].Value = model.C_IS_BXG;
            parameters[7].Value = model.C_ID;

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
			strSql.Append("delete from TQB_COPING_BASIC ");
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
			strSql.Append("delete from TQB_COPING_BASIC ");
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
		public Mod_TQB_COPING_BASIC GetModel(string C_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select C_ID,C_COPING_CRAFT,C_CRAFT_FLOW,N_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT,C_IS_BXG from TQB_COPING_BASIC  where N_STATUS=1 ");
			strSql.Append(" and C_ID=:C_ID ");
			OracleParameter[] parameters = {
					new OracleParameter(":C_ID", OracleDbType.Varchar2,100)			};
			parameters[0].Value = C_ID;

			Mod_TQB_COPING_BASIC model=new Mod_TQB_COPING_BASIC();
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
		public Mod_TQB_COPING_BASIC DataRowToModel(DataRow row)
		{
			Mod_TQB_COPING_BASIC model=new Mod_TQB_COPING_BASIC();
			if (row != null)
			{
				if(row["C_ID"]!=null)
				{
					model.C_ID=row["C_ID"].ToString();
				}
				if(row["C_COPING_CRAFT"]!=null)
				{
					model.C_COPING_CRAFT=row["C_COPING_CRAFT"].ToString();
				}
				if(row["C_CRAFT_FLOW"]!=null)
				{
					model.C_CRAFT_FLOW=row["C_CRAFT_FLOW"].ToString();
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
                if (row["C_IS_BXG"] != null)
                {
                    model.C_IS_BXG = row["C_IS_BXG"].ToString();
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
			strSql.Append("select C_ID,C_COPING_CRAFT,C_CRAFT_FLOW,N_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT,C_IS_BXG ");
			strSql.Append(" FROM TQB_COPING_BASIC where N_STATUS=1");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" and "+strWhere);
			}
			return DbHelperOra.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM TQB_COPING_BASIC ");
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
			strSql.Append(")AS Row, T.*  from TQB_COPING_BASIC T ");
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
			parameters[0].Value = "TQB_COPING_BASIC";
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
        /// <param name="C_COPING_CRAFT">修磨工艺</param>
        /// <param name="C_IS_BXG">是否为不锈钢</param>
        /// <returns></returns>
        public DataSet GetList_CopingCraft(string C_COPING_CRAFT,string C_IS_BXG)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_COPING_CRAFT,C_CRAFT_FLOW,N_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT,C_IS_BXG ");
            strSql.Append(" FROM TQB_COPING_BASIC where N_STATUS=1 and C_IS_BXG='"+ C_IS_BXG + "'");
            if (C_COPING_CRAFT.Trim() != "")
            {
                strSql.Append(" and C_COPING_CRAFT like '%"+ C_COPING_CRAFT + "%' ");
            }
            return DbHelperOra.Query(strSql.ToString());
        }
        #endregion  ExtensionMethod

        /// <summary>
        /// 加载不锈钢修磨要求
        /// </summary>
        /// <returns></returns>
        public DataTable GetBxgBZ()
        {
            string sql = "SELECT C_COPING_CRAFT, C_COPING_CRAFT||'【'||C_CRAFT_FLOW ||'】' C_CRAFT_FLOW  FROM TQB_COPING_BASIC where N_STATUS=1 and C_IS_BXG='1' order by C_COPING_CRAFT ";
            return DbHelperOra.Query(sql).Tables[0];
        }
    }
}

