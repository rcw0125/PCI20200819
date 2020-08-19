using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;
namespace DAL
{
	/// <summary>
	/// 数据访问类:TB_PLAN_OPERATION_LOG
	/// </summary>
	public partial class Dal_TB_PLAN_OPERATION_LOG
    {
		public Dal_TB_PLAN_OPERATION_LOG()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string C_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from TB_PLAN_OPERATION_LOG");
			strSql.Append(" where C_ID=:C_ID ");
			OracleParameter[] parameters = {
					new OracleParameter(":C_ID", OracleDbType.Varchar2,100)			};
			parameters[0].Value = C_ID;

			return DbHelperOra.Exists(strSql.ToString(),parameters);
		}

        /// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Mod_TB_PLAN_OPERATION_LOG model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TB_PLAN_OPERATION_LOG(");
            strSql.Append("C_ID,C_OPERATION,C_FUNCTION,D_MOD_DT,C_EMP_ID,C_CP_IP,C_CP_NAME,C_ORDER_NO,C_PLAN_ID)");
            strSql.Append(" values (");
            strSql.Append(":C_ID,:C_OPERATION,:C_FUNCTION,:D_MOD_DT,:C_EMP_ID,:C_CP_IP,:C_CP_NAME,:C_ORDER_NO,:C_PLAN_ID)");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_OPERATION", OracleDbType.Varchar2,1000),
                    new OracleParameter(":C_FUNCTION", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CP_IP", OracleDbType.Varchar2,1000),
                    new OracleParameter(":C_CP_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ORDER_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PLAN_ID", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.C_ID;
            parameters[1].Value = model.C_OPERATION;
            parameters[2].Value = model.C_FUNCTION;
            parameters[3].Value = model.D_MOD_DT;
            parameters[4].Value = model.C_EMP_ID;
            parameters[5].Value = model.C_CP_IP;
            parameters[6].Value = model.C_CP_NAME;
            parameters[7].Value = model.C_ORDER_NO;
            parameters[8].Value = model.C_PLAN_ID;

            int rows = DbHelperOra.ExecuteSql(strSql.ToString(), parameters);
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
        public bool Update(Mod_TB_PLAN_OPERATION_LOG model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update TB_PLAN_OPERATION_LOG set ");
			strSql.Append("C_OPERATION=:C_OPERATION,");
			strSql.Append("C_FUNCTION=:C_FUNCTION,");
			strSql.Append("D_MOD_DT=:D_MOD_DT,");
			strSql.Append("C_EMP_ID=:C_EMP_ID");
			strSql.Append(" where C_ID=:C_ID ");
			OracleParameter[] parameters = {
					new OracleParameter(":C_OPERATION", OracleDbType.Varchar2,100),
					new OracleParameter(":C_FUNCTION", OracleDbType.Varchar2,100),
					new OracleParameter(":D_MOD_DT", OracleDbType.Date),
					new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
					new OracleParameter(":C_ID", OracleDbType.Varchar2,100)};
			parameters[0].Value = model.C_OPERATION;
			parameters[1].Value = model.C_FUNCTION;
			parameters[2].Value = model.D_MOD_DT;
			parameters[3].Value = model.C_EMP_ID;
			parameters[4].Value = model.C_ID;

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
			strSql.Append("delete from TB_PLAN_OPERATION_LOG ");
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
			strSql.Append("delete from TB_PLAN_OPERATION_LOG ");
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
		public Mod_TB_PLAN_OPERATION_LOG GetModel(string C_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
            strSql.Append("select C_ID,C_OPERATION,C_FUNCTION,D_MOD_DT,C_EMP_ID,C_CP_IP,C_CP_NAME,C_ORDER_NO,C_PLAN_ID from TB_PLAN_OPERATION_LOG ");
            strSql.Append(" where C_ID=:C_ID ");
			OracleParameter[] parameters = {
					new OracleParameter(":C_ID", OracleDbType.Varchar2,100)			};
			parameters[0].Value = C_ID;

			Mod_TB_PLAN_OPERATION_LOG model=new Mod_TB_PLAN_OPERATION_LOG();
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
		public Mod_TB_PLAN_OPERATION_LOG DataRowToModel(DataRow row)
		{
			Mod_TB_PLAN_OPERATION_LOG model=new Mod_TB_PLAN_OPERATION_LOG();
            if (row != null)
            {
                if (row["C_ID"] != null)
                {
                    model.C_ID = row["C_ID"].ToString();
                }
                if (row["C_OPERATION"] != null)
                {
                    model.C_OPERATION = row["C_OPERATION"].ToString();
                }
                if (row["C_FUNCTION"] != null)
                {
                    model.C_FUNCTION = row["C_FUNCTION"].ToString();
                }
                if (row["D_MOD_DT"] != null && row["D_MOD_DT"].ToString() != "")
                {
                    model.D_MOD_DT = DateTime.Parse(row["D_MOD_DT"].ToString());
                }
                if (row["C_EMP_ID"] != null)
                {
                    model.C_EMP_ID = row["C_EMP_ID"].ToString();
                }
                if (row["C_CP_IP"] != null)
                {
                    model.C_CP_IP = row["C_CP_IP"].ToString();
                }
                if (row["C_CP_NAME"] != null)
                {
                    model.C_CP_NAME = row["C_CP_NAME"].ToString();
                }
                if (row["C_ORDER_NO"] != null)
                {
                    model.C_ORDER_NO = row["C_ORDER_NO"].ToString();
                }
                if (row["C_PLAN_ID"] != null)
                {
                    model.C_PLAN_ID = row["C_PLAN_ID"].ToString();
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
			strSql.Append("select * ");
			strSql.Append(" FROM TB_PLAN_OPERATION_LOG ");
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
			strSql.Append("select count(1) FROM TB_PLAN_OPERATION_LOG ");
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
			strSql.Append(")AS Row, T.*  from TB_PLAN_OPERATION_LOG T ");
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

