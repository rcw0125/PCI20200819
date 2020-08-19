using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;
namespace DAL
{
	/// <summary>
	/// 数据访问类:TB_LG_PLAN_LOG
	/// </summary>
	public partial class Dal_TB_LG_PLAN_LOG
	{
		public Dal_TB_LG_PLAN_LOG()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string C_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from TB_LG_PLAN_LOG");
			strSql.Append(" where C_ID=:C_ID ");
			OracleParameter[] parameters = {
					new OracleParameter(":C_ID", OracleDbType.Varchar2,100)			};
			parameters[0].Value = C_ID;

			return DbHelperOra.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Mod_TB_LG_PLAN_LOG model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into TB_LG_PLAN_LOG(");
			strSql.Append("C_ID,C_IP,C_STOVE,C_PLAN_ID,C_ORDER_NO,C_MES_PLAN_ID,C_LD_DESC,C_LF_DESC,C_RH_DESC,C_CC_DESC,C_EMP_ID,D_MOD_DT,C_REMARK)");
			strSql.Append(" values (");
			strSql.Append(":C_ID,:C_IP,:C_STOVE,:C_PLAN_ID,:C_ORDER_NO,:C_MES_PLAN_ID,:C_LD_DESC,:C_LF_DESC,:C_RH_DESC,:C_CC_DESC,:C_EMP_ID,:D_MOD_DT,:C_REMARK)");
			OracleParameter[] parameters = {
					new OracleParameter(":C_ID", OracleDbType.Varchar2,100),
					new OracleParameter(":C_IP", OracleDbType.Varchar2,100),
					new OracleParameter(":C_STOVE", OracleDbType.Varchar2,100),
					new OracleParameter(":C_PLAN_ID", OracleDbType.Varchar2,100),
					new OracleParameter(":C_ORDER_NO", OracleDbType.Varchar2,100),
					new OracleParameter(":C_MES_PLAN_ID", OracleDbType.Varchar2,100),
					new OracleParameter(":C_LD_DESC", OracleDbType.Varchar2,100),
					new OracleParameter(":C_LF_DESC", OracleDbType.Varchar2,100),
					new OracleParameter(":C_RH_DESC", OracleDbType.Varchar2,100),
					new OracleParameter(":C_CC_DESC", OracleDbType.Varchar2,100),
					new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
					new OracleParameter(":D_MOD_DT", OracleDbType.Date),
					new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500)};
			parameters[0].Value = model.C_ID;
			parameters[1].Value = model.C_IP;
			parameters[2].Value = model.C_STOVE;
			parameters[3].Value = model.C_PLAN_ID;
			parameters[4].Value = model.C_ORDER_NO;
			parameters[5].Value = model.C_MES_PLAN_ID;
			parameters[6].Value = model.C_LD_DESC;
			parameters[7].Value = model.C_LF_DESC;
			parameters[8].Value = model.C_RH_DESC;
			parameters[9].Value = model.C_CC_DESC;
			parameters[10].Value = model.C_EMP_ID;
			parameters[11].Value = model.D_MOD_DT;
			parameters[12].Value = model.C_REMARK;

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
		public bool Add_Trans(Mod_TB_LG_PLAN_LOG model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TB_LG_PLAN_LOG(");
            strSql.Append("C_IP,C_STOVE,C_PLAN_ID,C_ORDER_NO,C_MES_PLAN_ID,C_LD_DESC,C_LF_DESC,C_RH_DESC,C_CC_DESC,C_EMP_ID,D_MOD_DT,C_REMARK)");
            strSql.Append(" values (");
            strSql.Append(":C_IP,:C_STOVE,:C_PLAN_ID,:C_ORDER_NO,:C_MES_PLAN_ID,:C_LD_DESC,:C_LF_DESC,:C_RH_DESC,:C_CC_DESC,:C_EMP_ID,:D_MOD_DT,:C_REMARK)");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_IP", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STOVE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PLAN_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ORDER_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MES_PLAN_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_LD_DESC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_LF_DESC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_RH_DESC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CC_DESC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500)};
            parameters[0].Value = model.C_IP;
            parameters[1].Value = model.C_STOVE;
            parameters[2].Value = model.C_PLAN_ID;
            parameters[3].Value = model.C_ORDER_NO;
            parameters[4].Value = model.C_MES_PLAN_ID;
            parameters[5].Value = model.C_LD_DESC;
            parameters[6].Value = model.C_LF_DESC;
            parameters[7].Value = model.C_RH_DESC;
            parameters[8].Value = model.C_CC_DESC;
            parameters[9].Value = model.C_EMP_ID;
            parameters[10].Value = model.D_MOD_DT;
            parameters[11].Value = model.C_REMARK;

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
        public bool Update(Mod_TB_LG_PLAN_LOG model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update TB_LG_PLAN_LOG set ");
			strSql.Append("C_IP=:C_IP,");
			strSql.Append("C_STOVE=:C_STOVE,");
			strSql.Append("C_PLAN_ID=:C_PLAN_ID,");
			strSql.Append("C_ORDER_NO=:C_ORDER_NO,");
			strSql.Append("C_MES_PLAN_ID=:C_MES_PLAN_ID,");
			strSql.Append("C_LD_DESC=:C_LD_DESC,");
			strSql.Append("C_LF_DESC=:C_LF_DESC,");
			strSql.Append("C_RH_DESC=:C_RH_DESC,");
			strSql.Append("C_CC_DESC=:C_CC_DESC,");
			strSql.Append("C_EMP_ID=:C_EMP_ID,");
			strSql.Append("D_MOD_DT=:D_MOD_DT,");
			strSql.Append("C_REMARK=:C_REMARK");
			strSql.Append(" where C_ID=:C_ID ");
			OracleParameter[] parameters = {
					new OracleParameter(":C_IP", OracleDbType.Varchar2,100),
					new OracleParameter(":C_STOVE", OracleDbType.Varchar2,100),
					new OracleParameter(":C_PLAN_ID", OracleDbType.Varchar2,100),
					new OracleParameter(":C_ORDER_NO", OracleDbType.Varchar2,100),
					new OracleParameter(":C_MES_PLAN_ID", OracleDbType.Varchar2,100),
					new OracleParameter(":C_LD_DESC", OracleDbType.Varchar2,100),
					new OracleParameter(":C_LF_DESC", OracleDbType.Varchar2,100),
					new OracleParameter(":C_RH_DESC", OracleDbType.Varchar2,100),
					new OracleParameter(":C_CC_DESC", OracleDbType.Varchar2,100),
					new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
					new OracleParameter(":D_MOD_DT", OracleDbType.Date),
					new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
					new OracleParameter(":C_ID", OracleDbType.Varchar2,100)};
			parameters[0].Value = model.C_IP;
			parameters[1].Value = model.C_STOVE;
			parameters[2].Value = model.C_PLAN_ID;
			parameters[3].Value = model.C_ORDER_NO;
			parameters[4].Value = model.C_MES_PLAN_ID;
			parameters[5].Value = model.C_LD_DESC;
			parameters[6].Value = model.C_LF_DESC;
			parameters[7].Value = model.C_RH_DESC;
			parameters[8].Value = model.C_CC_DESC;
			parameters[9].Value = model.C_EMP_ID;
			parameters[10].Value = model.D_MOD_DT;
			parameters[11].Value = model.C_REMARK;
			parameters[12].Value = model.C_ID;

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
			strSql.Append("delete from TB_LG_PLAN_LOG ");
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
			strSql.Append("delete from TB_LG_PLAN_LOG ");
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
		public Mod_TB_LG_PLAN_LOG GetModel(string C_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select C_ID,C_IP,C_STOVE,C_PLAN_ID,C_ORDER_NO,C_MES_PLAN_ID,C_LD_DESC,C_LF_DESC,C_RH_DESC,C_CC_DESC,C_EMP_ID,D_MOD_DT,C_REMARK from TB_LG_PLAN_LOG ");
			strSql.Append(" where C_ID=:C_ID ");
			OracleParameter[] parameters = {
					new OracleParameter(":C_ID", OracleDbType.Varchar2,100)			};
			parameters[0].Value = C_ID;

			Mod_TB_LG_PLAN_LOG model=new Mod_TB_LG_PLAN_LOG();
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
		public Mod_TB_LG_PLAN_LOG DataRowToModel(DataRow row)
		{
			Mod_TB_LG_PLAN_LOG model=new Mod_TB_LG_PLAN_LOG();
			if (row != null)
			{
				if(row["C_ID"]!=null)
				{
					model.C_ID=row["C_ID"].ToString();
				}
				if(row["C_IP"]!=null)
				{
					model.C_IP=row["C_IP"].ToString();
				}
				if(row["C_STOVE"]!=null)
				{
					model.C_STOVE=row["C_STOVE"].ToString();
				}
				if(row["C_PLAN_ID"]!=null)
				{
					model.C_PLAN_ID=row["C_PLAN_ID"].ToString();
				}
				if(row["C_ORDER_NO"]!=null)
				{
					model.C_ORDER_NO=row["C_ORDER_NO"].ToString();
				}
				if(row["C_MES_PLAN_ID"]!=null)
				{
					model.C_MES_PLAN_ID=row["C_MES_PLAN_ID"].ToString();
				}
				if(row["C_LD_DESC"]!=null)
				{
					model.C_LD_DESC=row["C_LD_DESC"].ToString();
				}
				if(row["C_LF_DESC"]!=null)
				{
					model.C_LF_DESC=row["C_LF_DESC"].ToString();
				}
				if(row["C_RH_DESC"]!=null)
				{
					model.C_RH_DESC=row["C_RH_DESC"].ToString();
				}
				if(row["C_CC_DESC"]!=null)
				{
					model.C_CC_DESC=row["C_CC_DESC"].ToString();
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
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select C_ID,C_IP,C_STOVE,C_PLAN_ID,C_ORDER_NO,C_MES_PLAN_ID,C_LD_DESC,C_LF_DESC,C_RH_DESC,C_CC_DESC,C_EMP_ID,D_MOD_DT,C_REMARK ");
			strSql.Append(" FROM TB_LG_PLAN_LOG ");
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
			strSql.Append("select count(1) FROM TB_LG_PLAN_LOG ");
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
			strSql.Append(")AS Row, T.*  from TB_LG_PLAN_LOG T ");
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

