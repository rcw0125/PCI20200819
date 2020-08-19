using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;
namespace DAL
{
	/// <summary>
	/// 数据访问类:TRC_ROLL_SPOT_CHECK
	/// </summary>
	public partial class Dal_TRC_ROLL_SPOT_CHECK
	{
		public Dal_TRC_ROLL_SPOT_CHECK()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string C_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from TRC_ROLL_SPOT_CHECK");
			strSql.Append(" where C_ID=:C_ID ");
			OracleParameter[] parameters = {
					new OracleParameter(":C_ID", OracleDbType.Varchar2,100)			};
			parameters[0].Value = C_ID;

			return DbHelperOra.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Mod_TRC_ROLL_SPOT_CHECK model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into TRC_ROLL_SPOT_CHECK(");
			strSql.Append("  C_STOVE,C_BATCH_NO,C_TICK_NO,C_STD_CODE,C_STL_GRD,C_SPEC,N_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT,N_ENTRUST_TYPE,C_EMP_ID_ZY,D_MOD_DT_ZY,C_EMP_ID_JS,D_MOD_DT_JS)");
			strSql.Append(" values (");
			strSql.Append(" :C_STOVE,:C_BATCH_NO,:C_TICK_NO,:C_STD_CODE,:C_STL_GRD,:C_SPEC,:N_STATUS,:C_REMARK,:C_EMP_ID,:D_MOD_DT,:N_ENTRUST_TYPE,:C_EMP_ID_ZY,:D_MOD_DT_ZY,:C_EMP_ID_JS,:D_MOD_DT_JS)");
			OracleParameter[] parameters = {
 					new OracleParameter(":C_STOVE", OracleDbType.Varchar2,100),
					new OracleParameter(":C_BATCH_NO", OracleDbType.Varchar2,100),
					new OracleParameter(":C_TICK_NO", OracleDbType.Varchar2,100),
					new OracleParameter(":C_STD_CODE", OracleDbType.Varchar2,100),
					new OracleParameter(":C_STL_GRD", OracleDbType.Varchar2,100),
					new OracleParameter(":C_SPEC", OracleDbType.Varchar2,100),
					new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
					new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
					new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
					new OracleParameter(":D_MOD_DT", OracleDbType.Date),
					new OracleParameter(":N_ENTRUST_TYPE", OracleDbType.Decimal,1),
					new OracleParameter(":C_EMP_ID_ZY", OracleDbType.Varchar2,100),
					new OracleParameter(":D_MOD_DT_ZY", OracleDbType.Date),
                    new OracleParameter(":C_EMP_ID_JS", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT_JS", OracleDbType.Date)};
 			parameters[0].Value = model.C_STOVE;
			parameters[1].Value = model.C_BATCH_NO;
			parameters[2].Value = model.C_TICK_NO;
			parameters[3].Value = model.C_STD_CODE;
			parameters[4].Value = model.C_STL_GRD;
			parameters[5].Value = model.C_SPEC;
			parameters[6].Value = model.N_STATUS;
			parameters[7].Value = model.C_REMARK;
			parameters[8].Value = model.C_EMP_ID;
			parameters[9].Value = model.D_MOD_DT;
			parameters[10].Value = model.N_ENTRUST_TYPE;
			parameters[11].Value = model.C_EMP_ID_ZY;
			parameters[12].Value = model.D_MOD_DT_ZY;
            parameters[13].Value = model.C_EMP_ID_JS;
            parameters[14].Value = model.D_MOD_DT_JS;

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
		public bool Update(Mod_TRC_ROLL_SPOT_CHECK model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update TRC_ROLL_SPOT_CHECK set ");
			strSql.Append("C_STOVE=:C_STOVE,");
			strSql.Append("C_BATCH_NO=:C_BATCH_NO,");
			strSql.Append("C_TICK_NO=:C_TICK_NO,");
			strSql.Append("C_STD_CODE=:C_STD_CODE,");
			strSql.Append("C_STL_GRD=:C_STL_GRD,");
			strSql.Append("C_SPEC=:C_SPEC,");
			strSql.Append("N_STATUS=:N_STATUS,");
			strSql.Append("C_REMARK=:C_REMARK,");
			strSql.Append("C_EMP_ID=:C_EMP_ID,");
			strSql.Append("D_MOD_DT=:D_MOD_DT,");
			strSql.Append("N_ENTRUST_TYPE=:N_ENTRUST_TYPE,");
			strSql.Append("C_EMP_ID_ZY=:C_EMP_ID_ZY,");
			strSql.Append("D_MOD_DT_ZY=:D_MOD_DT_ZY,");
            strSql.Append("C_EMP_ID_JS=:C_EMP_ID_JS,");
            strSql.Append("D_MOD_DT_JS=:D_MOD_DT_JS");
            strSql.Append(" where C_ID=:C_ID ");
			OracleParameter[] parameters = {
					new OracleParameter(":C_STOVE", OracleDbType.Varchar2,100),
					new OracleParameter(":C_BATCH_NO", OracleDbType.Varchar2,100),
					new OracleParameter(":C_TICK_NO", OracleDbType.Varchar2,100),
					new OracleParameter(":C_STD_CODE", OracleDbType.Varchar2,100),
					new OracleParameter(":C_STL_GRD", OracleDbType.Varchar2,100),
					new OracleParameter(":C_SPEC", OracleDbType.Varchar2,100),
					new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
					new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
					new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
					new OracleParameter(":D_MOD_DT", OracleDbType.Date),
					new OracleParameter(":N_ENTRUST_TYPE", OracleDbType.Decimal,1),
					new OracleParameter(":C_EMP_ID_ZY", OracleDbType.Varchar2,100),
					new OracleParameter(":D_MOD_DT_ZY", OracleDbType.Date),
                    new OracleParameter(":C_EMP_ID_JS", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT_JS", OracleDbType.Date),
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)};
			parameters[0].Value = model.C_STOVE;
			parameters[1].Value = model.C_BATCH_NO;
			parameters[2].Value = model.C_TICK_NO;
			parameters[3].Value = model.C_STD_CODE;
			parameters[4].Value = model.C_STL_GRD;
			parameters[5].Value = model.C_SPEC;
			parameters[6].Value = model.N_STATUS;
			parameters[7].Value = model.C_REMARK;
			parameters[8].Value = model.C_EMP_ID;
			parameters[9].Value = model.D_MOD_DT;
			parameters[10].Value = model.N_ENTRUST_TYPE;
			parameters[11].Value = model.C_EMP_ID_ZY;
			parameters[12].Value = model.D_MOD_DT_ZY;
            parameters[13].Value = model.C_EMP_ID_JS;
            parameters[14].Value = model.D_MOD_DT_JS;
            parameters[15].Value = model.C_ID;

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
			strSql.Append("delete from TRC_ROLL_SPOT_CHECK ");
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
			strSql.Append("delete from TRC_ROLL_SPOT_CHECK ");
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
		public Mod_TRC_ROLL_SPOT_CHECK GetModel(string C_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select C_ID,C_STOVE,C_BATCH_NO,C_TICK_NO,C_STD_CODE,C_STL_GRD,C_SPEC,N_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT,N_ENTRUST_TYPE,C_EMP_ID_ZY,D_MOD_DT_ZY,C_EMP_ID_JS,D_MOD_DT_JS from TRC_ROLL_SPOT_CHECK ");
			strSql.Append(" where C_ID=:C_ID ");
			OracleParameter[] parameters = {
					new OracleParameter(":C_ID", OracleDbType.Varchar2,100)			};
			parameters[0].Value = C_ID;

			Mod_TRC_ROLL_SPOT_CHECK model=new Mod_TRC_ROLL_SPOT_CHECK();
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
		public Mod_TRC_ROLL_SPOT_CHECK DataRowToModel(DataRow row)
		{
			Mod_TRC_ROLL_SPOT_CHECK model=new Mod_TRC_ROLL_SPOT_CHECK();
			if (row != null)
			{
				if(row["C_ID"]!=null)
				{
					model.C_ID=row["C_ID"].ToString();
				}
				if(row["C_STOVE"]!=null)
				{
					model.C_STOVE=row["C_STOVE"].ToString();
				}
				if(row["C_BATCH_NO"]!=null)
				{
					model.C_BATCH_NO=row["C_BATCH_NO"].ToString();
				}
				if(row["C_TICK_NO"]!=null)
				{
					model.C_TICK_NO=row["C_TICK_NO"].ToString();
				}
				if(row["C_STD_CODE"]!=null)
				{
					model.C_STD_CODE=row["C_STD_CODE"].ToString();
				}
				if(row["C_STL_GRD"]!=null)
				{
					model.C_STL_GRD=row["C_STL_GRD"].ToString();
				}
				if(row["C_SPEC"]!=null)
				{
					model.C_SPEC=row["C_SPEC"].ToString();
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
				if(row["N_ENTRUST_TYPE"]!=null && row["N_ENTRUST_TYPE"].ToString()!="")
				{
					model.N_ENTRUST_TYPE=decimal.Parse(row["N_ENTRUST_TYPE"].ToString());
				}
				if(row["C_EMP_ID_ZY"]!=null)
				{
					model.C_EMP_ID_ZY=row["C_EMP_ID_ZY"].ToString();
				}
				if(row["D_MOD_DT_ZY"]!=null && row["D_MOD_DT_ZY"].ToString()!="")
				{
					model.D_MOD_DT_ZY=DateTime.Parse(row["D_MOD_DT_ZY"].ToString());
				}
                if (row["C_EMP_ID_JS"] != null)
                {
                    model.C_EMP_ID_JS = row["C_EMP_ID_JS"].ToString();
                }
                if (row["D_MOD_DT_JS"] != null && row["D_MOD_DT_JS"].ToString() != "")
                {
                    model.D_MOD_DT_JS = DateTime.Parse(row["D_MOD_DT_JS"].ToString());
                }
            }
			return model;
		}
        

        /// <summary>
        /// 条件获得数据列表
        /// </summary>
        /// <param name="begin">生产时间 开始</param>
        /// <param name="end">生产时间 结束</param>         
        /// <param name="batch">批号</param>
        /// <returns></returns>
        public DataSet GetList_Query(DateTime begin, DateTime end, string batch)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_STOVE,C_BATCH_NO,C_TICK_NO,C_STD_CODE,C_STL_GRD,C_SPEC,N_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT,N_ENTRUST_TYPE,C_EMP_ID_ZY,D_MOD_DT_ZY,C_EMP_ID_JS,D_MOD_DT_JS ");
            strSql.Append(" FROM TRC_ROLL_SPOT_CHECK where N_ENTRUST_TYPE is null ");
            if (begin != null && end != null)
            {
                strSql.Append(" and D_MOD_DT between to_date('" + Convert.ToDateTime(begin) + "','yyyy-mm-dd hh24:mi:ss') and to_date('" + Convert.ToDateTime(end) + "','yyyy-mm-dd hh24:mi:ss') ");
            }
            if (!string.IsNullOrEmpty(batch))
            {
                strSql.Append(" and C_BATCH_NO like '%" + batch + "%'");
            }

            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 获得数据列表-主键
        /// </summary>
        public DataSet GetList_ID(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_STOVE,C_BATCH_NO,C_TICK_NO,C_STD_CODE,C_STL_GRD,C_SPEC,N_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT,N_ENTRUST_TYPE,C_EMP_ID_ZY,D_MOD_DT_ZY,C_EMP_ID_JS,D_MOD_DT_JS ");
            strSql.Append(" FROM TRC_ROLL_SPOT_CHECK ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where C_ID = '" + strWhere + "' ");
            }
            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select C_ID,C_STOVE,C_BATCH_NO,C_TICK_NO,C_STD_CODE,C_STL_GRD,C_SPEC,N_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT,N_ENTRUST_TYPE,C_EMP_ID_ZY,D_MOD_DT_ZY,C_EMP_ID_JS,D_MOD_DT_JS ");
			strSql.Append(" FROM TRC_ROLL_SPOT_CHECK ");
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
			strSql.Append("select count(1) FROM TRC_ROLL_SPOT_CHECK ");
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
			strSql.Append(")AS Row, T.*  from TRC_ROLL_SPOT_CHECK T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DbHelperOra.Query(strSql.ToString());
		}

		#endregion  BasicMethod
	}
}

