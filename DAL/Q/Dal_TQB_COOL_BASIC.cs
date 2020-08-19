using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;
namespace DAL
{
	/// <summary>
	/// 数据访问类:TQB_COOL_BASIC
	/// </summary>
	public partial class Dal_TQB_COOL_BASIC
	{
		public Dal_TQB_COOL_BASIC()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string C_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from TQB_COOL_BASIC");
			strSql.Append(" where C_ID=:C_ID ");
			OracleParameter[] parameters = {
					new OracleParameter(":C_ID", OracleDbType.Varchar2,100)			};
			parameters[0].Value = C_ID;

			return DbHelperOra.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Mod_TQB_COOL_BASIC model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into TQB_COOL_BASIC(");
			strSql.Append("N_COOL_DT,C_HEAT,C_TYPE,C_COOL_CRAFT_CODE,C_COOL_CRAFT,C_HOT_T,N_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT)");
			strSql.Append(" values (");
			strSql.Append(":N_COOL_DT,:C_HEAT,:C_TYPE,:C_COOL_CRAFT_CODE,:C_COOL_CRAFT,:C_HOT_T,:N_STATUS,:C_REMARK,:C_EMP_ID,:D_MOD_DT)");
			OracleParameter[] parameters = {
					new OracleParameter(":N_COOL_DT", OracleDbType.Decimal,10),
					new OracleParameter(":C_HEAT", OracleDbType.Varchar2,100),
					new OracleParameter(":C_TYPE", OracleDbType.Varchar2,100),
					new OracleParameter(":C_COOL_CRAFT_CODE", OracleDbType.Varchar2,100),
					new OracleParameter(":C_COOL_CRAFT", OracleDbType.Varchar2,500),
					new OracleParameter(":C_HOT_T", OracleDbType.Varchar2,100),
					new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
					new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
					new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
					new OracleParameter(":D_MOD_DT", OracleDbType.Date)};
			parameters[0].Value = model.N_COOL_DT;
			parameters[1].Value = model.C_HEAT;
			parameters[2].Value = model.C_TYPE;
			parameters[3].Value = model.C_COOL_CRAFT_CODE;
			parameters[4].Value = model.C_COOL_CRAFT;
			parameters[5].Value = model.C_HOT_T;
			parameters[6].Value = model.N_STATUS;
			parameters[7].Value = model.C_REMARK;
			parameters[8].Value = model.C_EMP_ID;
			parameters[9].Value = model.D_MOD_DT;

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
		public bool Update(Mod_TQB_COOL_BASIC model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update TQB_COOL_BASIC set ");
			strSql.Append("N_COOL_DT=:N_COOL_DT,");
			strSql.Append("C_HEAT=:C_HEAT,");
			strSql.Append("C_TYPE=:C_TYPE,");
			strSql.Append("C_COOL_CRAFT_CODE=:C_COOL_CRAFT_CODE,");
			strSql.Append("C_COOL_CRAFT=:C_COOL_CRAFT,");
			strSql.Append("C_HOT_T=:C_HOT_T,");
			strSql.Append("N_STATUS=:N_STATUS,");
			strSql.Append("C_REMARK=:C_REMARK,");
			strSql.Append("C_EMP_ID=:C_EMP_ID,");
			strSql.Append("D_MOD_DT=:D_MOD_DT");
			strSql.Append(" where C_ID=:C_ID ");
			OracleParameter[] parameters = {
					new OracleParameter(":N_COOL_DT", OracleDbType.Decimal,10),
					new OracleParameter(":C_HEAT", OracleDbType.Varchar2,100),
					new OracleParameter(":C_TYPE", OracleDbType.Varchar2,100),
					new OracleParameter(":C_COOL_CRAFT_CODE", OracleDbType.Varchar2,100),
					new OracleParameter(":C_COOL_CRAFT", OracleDbType.Varchar2,500),
					new OracleParameter(":C_HOT_T", OracleDbType.Varchar2,100),
					new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
					new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
					new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
					new OracleParameter(":D_MOD_DT", OracleDbType.Date),
					new OracleParameter(":C_ID", OracleDbType.Varchar2,100)};
			parameters[0].Value = model.N_COOL_DT;
			parameters[1].Value = model.C_HEAT;
			parameters[2].Value = model.C_TYPE;
			parameters[3].Value = model.C_COOL_CRAFT_CODE;
			parameters[4].Value = model.C_COOL_CRAFT;
			parameters[5].Value = model.C_HOT_T;
			parameters[6].Value = model.N_STATUS;
			parameters[7].Value = model.C_REMARK;
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
			strSql.Append("delete from TQB_COOL_BASIC ");
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
			strSql.Append("delete from TQB_COOL_BASIC ");
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
		public Mod_TQB_COOL_BASIC GetModel(string C_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select C_ID,N_COOL_DT,C_HEAT,C_TYPE,C_COOL_CRAFT_CODE,C_COOL_CRAFT,C_HOT_T,N_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT from TQB_COOL_BASIC where N_STATUS=1");
			strSql.Append(" and C_ID=:C_ID ");
			OracleParameter[] parameters = {
					new OracleParameter(":C_ID", OracleDbType.Varchar2,100)			};
			parameters[0].Value = C_ID;

			Mod_TQB_COOL_BASIC model=new Mod_TQB_COOL_BASIC();
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
		public Mod_TQB_COOL_BASIC DataRowToModel(DataRow row)
		{
			Mod_TQB_COOL_BASIC model=new Mod_TQB_COOL_BASIC();
			if (row != null)
			{
				if(row["C_ID"]!=null)
				{
					model.C_ID=row["C_ID"].ToString();
				}
				if(row["N_COOL_DT"]!=null && row["N_COOL_DT"].ToString()!="")
				{
					model.N_COOL_DT=decimal.Parse(row["N_COOL_DT"].ToString());
				}
				if(row["C_HEAT"]!=null)
				{
					model.C_HEAT=row["C_HEAT"].ToString();
				}
				if(row["C_TYPE"]!=null)
				{
					model.C_TYPE=row["C_TYPE"].ToString();
				}
				if(row["C_COOL_CRAFT_CODE"]!=null)
				{
					model.C_COOL_CRAFT_CODE=row["C_COOL_CRAFT_CODE"].ToString();
				}
				if(row["C_COOL_CRAFT"]!=null)
				{
					model.C_COOL_CRAFT=row["C_COOL_CRAFT"].ToString();
				}
				if(row["C_HOT_T"]!=null)
				{
					model.C_HOT_T=row["C_HOT_T"].ToString();
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
			strSql.Append("select C_ID,N_COOL_DT,C_HEAT,C_TYPE,C_COOL_CRAFT_CODE,C_COOL_CRAFT,C_HOT_T,N_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT ");
			strSql.Append(" FROM TQB_COOL_BASIC where N_STATUS=1 ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" and "+strWhere);
			}
            strSql.Append(" order by to_number( substr( c_cool_craft_code,2))");
            return DbHelperOra.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM TQB_COOL_BASIC ");
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
			strSql.Append(")AS Row, T.*  from TQB_COOL_BASIC T ");
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
			parameters[0].Value = "TQB_COOL_BASIC";
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
        /// <param name="C_COOL_CRAFT_CODE">缓冷工艺代码</param>
        /// <returns></returns>
        public DataSet GetList_CraftCode(string C_COOL_CRAFT_CODE)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,N_COOL_DT,C_HEAT,C_TYPE,C_COOL_CRAFT_CODE,C_COOL_CRAFT,C_HOT_T,N_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT ");
            strSql.Append(" FROM TQB_COOL_BASIC where N_STATUS=1 ");
            if (C_COOL_CRAFT_CODE.Trim() != "")
            {
                strSql.Append(" and C_COOL_CRAFT_CODE like '%"+ C_COOL_CRAFT_CODE + "%' ");
            }
            strSql.Append(" order by to_number( substr( c_cool_craft_code,2))");
            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取钢种缓冷要求
        /// </summary>
        /// <param name="C_STL_GRD">钢种</param>
        /// <param name="C_STD_CODE">执行标准</param>
        /// <param name="C_TYPE">钢坯类型 大方坯连铸坯、热轧钢坯\小方坯连铸坯</param>
        /// <returns>缓冷要求</returns>
        public DataSet GetHLYQ(string C_STL_GRD,string C_STD_CODE,string C_TYPE)
        {
            string sql = "SELECT T.C_STL_GRD, T.C_STD_CODE, nvl(TB.N_COOL_DT,0) N_COOL_DT ,TB.C_COOL_CRAFT_CODE, TB.C_COOL_CRAFT,TB.C_TYPE,TB.C_HEAT FROM TQB_COOL T, TQB_COOL_BASIC TB WHERE TB.C_ID = T.C_COOL_BASIC_ID  AND T.N_STATUS = 1 AND TB.N_STATUS = 1  AND TB.C_HEAT='否'  AND T.C_STL_GRD='" + C_STL_GRD + "'  ";

            if (C_STD_CODE.Trim() != "")
            {
                sql = sql + "  AND T.C_STD_CODE = '" + C_STD_CODE + "' ";
            }

            if (C_TYPE.Trim()!="")
            {
                sql = sql + "  AND TB.C_TYPE like '%" + C_TYPE + "%' ";
            }
            return DbHelperOra.Query(sql.ToString());

        }
        #endregion  ExtensionMethod
    }
}

