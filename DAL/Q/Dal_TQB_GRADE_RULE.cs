using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;
namespace DAL
{
	/// <summary>
	/// 数据访问类:TQB_GRADE_RULE
	/// </summary>
	public partial class Dal_TQB_GRADE_RULE
    {
		public Dal_TQB_GRADE_RULE()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string C_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from TQB_GRADE_RULE");
			strSql.Append(" where C_ID=:C_ID ");
			OracleParameter[] parameters = {
					new OracleParameter(":C_ID", OracleDbType.Varchar2,100)			};
			parameters[0].Value = C_ID;

			return DbHelperOra.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Mod_TQB_GRADE_RULE model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into TQB_GRADE_RULE(");
			strSql.Append("C_RULE_STD_ID,C_SPEC_MIN,C_SPEC_INTERVAL,C_SPEC_MAX,C_CHARACTER_ID,C_LEV,C_TARGET_MIN,C_TARGET_INTERVAL,C_TARGET_MAX,N_STATUS,C_REMARK,C_EMP_ID)");
			strSql.Append(" values (");
			strSql.Append(":C_RULE_STD_ID,:C_SPEC_MIN,:C_SPEC_INTERVAL,:C_SPEC_MAX,:C_CHARACTER_ID,:C_LEV,:C_TARGET_MIN,:C_TARGET_INTERVAL,:C_TARGET_MAX,:N_STATUS,:C_REMARK,:C_EMP_ID)");
			OracleParameter[] parameters = {
					new OracleParameter(":C_RULE_STD_ID", OracleDbType.Varchar2,100),
					new OracleParameter(":C_SPEC_MIN", OracleDbType.Varchar2,100),
					new OracleParameter(":C_SPEC_INTERVAL", OracleDbType.Varchar2,100),
					new OracleParameter(":C_SPEC_MAX", OracleDbType.Varchar2,100),
					new OracleParameter(":C_CHARACTER_ID", OracleDbType.Varchar2,100),
					new OracleParameter(":C_LEV", OracleDbType.Varchar2,100),
					new OracleParameter(":C_TARGET_MIN", OracleDbType.Varchar2,100),
					new OracleParameter(":C_TARGET_INTERVAL", OracleDbType.Varchar2,100),
					new OracleParameter(":C_TARGET_MAX", OracleDbType.Varchar2,100),
					new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
					new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
					new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100)};
			parameters[0].Value = model.C_RULE_STD_ID;
			parameters[1].Value = model.C_SPEC_MIN;
			parameters[2].Value = model.C_SPEC_INTERVAL;
			parameters[3].Value = model.C_SPEC_MAX;
			parameters[4].Value = model.C_CHARACTER_ID;
			parameters[5].Value = model.C_LEV;
			parameters[6].Value = model.C_TARGET_MIN;
			parameters[7].Value = model.C_TARGET_INTERVAL;
			parameters[8].Value = model.C_TARGET_MAX;
			parameters[9].Value = model.N_STATUS;
			parameters[10].Value = model.C_REMARK;
			parameters[11].Value = model.C_EMP_ID;

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
		public bool Update(Mod_TQB_GRADE_RULE model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update TQB_GRADE_RULE set ");
			strSql.Append("C_RULE_STD_ID=:C_RULE_STD_ID,");
			strSql.Append("C_SPEC_MIN=:C_SPEC_MIN,");
			strSql.Append("C_SPEC_INTERVAL=:C_SPEC_INTERVAL,");
			strSql.Append("C_SPEC_MAX=:C_SPEC_MAX,");
			strSql.Append("C_CHARACTER_ID=:C_CHARACTER_ID,");
			strSql.Append("C_LEV=:C_LEV,");
			strSql.Append("C_TARGET_MIN=:C_TARGET_MIN,");
			strSql.Append("C_TARGET_INTERVAL=:C_TARGET_INTERVAL,");
			strSql.Append("C_TARGET_MAX=:C_TARGET_MAX,");
			strSql.Append("N_STATUS=:N_STATUS,");
			strSql.Append("C_REMARK=:C_REMARK,");
			strSql.Append("C_EMP_ID=:C_EMP_ID,");
			strSql.Append("D_MOD_DT=:D_MOD_DT");
			strSql.Append(" where C_ID=:C_ID ");
			OracleParameter[] parameters = {
					new OracleParameter(":C_RULE_STD_ID", OracleDbType.Varchar2,100),
					new OracleParameter(":C_SPEC_MIN", OracleDbType.Varchar2,100),
					new OracleParameter(":C_SPEC_INTERVAL", OracleDbType.Varchar2,100),
					new OracleParameter(":C_SPEC_MAX", OracleDbType.Varchar2,100),
					new OracleParameter(":C_CHARACTER_ID", OracleDbType.Varchar2,100),
					new OracleParameter(":C_LEV", OracleDbType.Varchar2,100),
					new OracleParameter(":C_TARGET_MIN", OracleDbType.Varchar2,100),
					new OracleParameter(":C_TARGET_INTERVAL", OracleDbType.Varchar2,100),
					new OracleParameter(":C_TARGET_MAX", OracleDbType.Varchar2,100),
					new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
					new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
					new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
					new OracleParameter(":D_MOD_DT", OracleDbType.Date),
					new OracleParameter(":C_ID", OracleDbType.Varchar2,100)};
			parameters[0].Value = model.C_RULE_STD_ID;
			parameters[1].Value = model.C_SPEC_MIN;
			parameters[2].Value = model.C_SPEC_INTERVAL;
			parameters[3].Value = model.C_SPEC_MAX;
			parameters[4].Value = model.C_CHARACTER_ID;
			parameters[5].Value = model.C_LEV;
			parameters[6].Value = model.C_TARGET_MIN;
			parameters[7].Value = model.C_TARGET_INTERVAL;
			parameters[8].Value = model.C_TARGET_MAX;
			parameters[9].Value = model.N_STATUS;
			parameters[10].Value = model.C_REMARK;
			parameters[11].Value = model.C_EMP_ID;
			parameters[12].Value = model.D_MOD_DT;
			parameters[13].Value = model.C_ID;

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
			strSql.Append("delete from TQB_GRADE_RULE ");
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
			strSql.Append("delete from TQB_GRADE_RULE ");
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
		public Mod_TQB_GRADE_RULE GetModel(string C_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select C_ID,C_RULE_STD_ID,C_SPEC_MIN,C_SPEC_INTERVAL,C_SPEC_MAX,C_CHARACTER_ID,C_LEV,C_TARGET_MIN,C_TARGET_INTERVAL,C_TARGET_MAX,N_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT from TQB_GRADE_RULE ");
			strSql.Append(" where C_ID=:C_ID ");
			OracleParameter[] parameters = {
					new OracleParameter(":C_ID", OracleDbType.Varchar2,100)			};
			parameters[0].Value = C_ID;

			Mod_TQB_GRADE_RULE model=new Mod_TQB_GRADE_RULE();
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
		public Mod_TQB_GRADE_RULE DataRowToModel(DataRow row)
		{
			Mod_TQB_GRADE_RULE model=new Mod_TQB_GRADE_RULE();
			if (row != null)
			{
				if(row["C_ID"]!=null)
				{
					model.C_ID=row["C_ID"].ToString();
				}
				if(row["C_RULE_STD_ID"] !=null)
				{
					model.C_RULE_STD_ID = row["C_RULE_STD_ID"].ToString();
				}
				if(row["C_SPEC_MIN"]!=null)
				{
					model.C_SPEC_MIN=row["C_SPEC_MIN"].ToString();
				}
				if(row["C_SPEC_INTERVAL"]!=null)
				{
					model.C_SPEC_INTERVAL=row["C_SPEC_INTERVAL"].ToString();
				}
				if(row["C_SPEC_MAX"]!=null)
				{
					model.C_SPEC_MAX=row["C_SPEC_MAX"].ToString();
				}
				if(row["C_CHARACTER_ID"]!=null)
				{
					model.C_CHARACTER_ID=row["C_CHARACTER_ID"].ToString();
				}
				if(row["C_LEV"]!=null)
				{
					model.C_LEV=row["C_LEV"].ToString();
				}
				if(row["C_TARGET_MIN"]!=null)
				{
					model.C_TARGET_MIN=row["C_TARGET_MIN"].ToString();
				}
				if(row["C_TARGET_INTERVAL"]!=null)
				{
					model.C_TARGET_INTERVAL=row["C_TARGET_INTERVAL"].ToString();
				}
				if(row["C_TARGET_MAX"]!=null)
				{
					model.C_TARGET_MAX=row["C_TARGET_MAX"].ToString();
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
			strSql.Append("select C_ID,C_RULE_STD_ID,C_SPEC_MIN,C_SPEC_INTERVAL,C_SPEC_MAX,C_CHARACTER_ID,C_LEV,C_TARGET_MIN,C_TARGET_INTERVAL,C_TARGET_MAX,N_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT ");
			strSql.Append(" FROM TQB_GRADE_RULE ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperOra.Query(strSql.ToString());
		}

        /// <summary>
        /// 获取标准列表
        /// </summary>
        /// <param name="C_RULE_STD_ID">标准主键</param>
        /// <returns></returns>
		public DataSet GetGradeDetails(string C_RULE_STD_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ta.C_ID, ta.C_CHARACTER_ID,tb.c_name,tc.c_type_name,ta.C_LEV,ta.C_TARGET_MIN,ta.C_TARGET_INTERVAL,ta.C_TARGET_MAX,ta.c_spec_min,ta.c_spec_interval,ta.c_spec_max,ta.d_mod_dt,ta.c_emp_id     from tqb_grade_rule ta inner join tqb_character tb on ta.C_CHARACTER_ID=tb.c_id inner join tqb_checktype tc on tc.c_id=tb.c_type_id ");
            strSql.Append(" where 1=1 and ta.N_STATUS=1 and ta.C_RULE_STD_ID='"+ C_RULE_STD_ID + "' ");

            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM TQB_GRADE_RULE ");
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
			strSql.Append(")AS Row, T.*  from TQB_GRADE_RULE T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DbHelperOra.Query(strSql.ToString());
		}

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

