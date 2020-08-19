using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;
namespace DAL
{
	/// <summary>
	/// 数据访问类:TQC_FACE_ROLL
	/// </summary>
	public partial class Dal_TQC_FACE_ROLL
    {
		public Dal_TQC_FACE_ROLL()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string C_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from TQC_FACE_ROLL");
			strSql.Append(" where C_ID=:C_ID ");
			OracleParameter[] parameters = {
					new OracleParameter(":C_ID", OracleDbType.Varchar2,100)			};
			parameters[0].Value = C_ID;

			return DbHelperOra.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Mod_TQC_FACE_ROLL model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into TQC_FACE_ROLL(");
			strSql.Append("C_ROLL_ID,C_STOVE,C_BATCH_NO,C_TICK_NO,C_STL_GRD,N_WGT,C_STD_CODE,C_SPEC,C_MAT_CODE,C_MAT_NAME,C_SHIFT,C_GROUP,C_JUDGE_LEV,C_REASON_NAME,C_REASON_CODE,C_REASON_DEPMT_ID,C_REASON_DEPMT_DESC,C_SUGGESTION,N_STATUS,C_REMARK,C_EMP_ID)");
			strSql.Append(" values (");
			strSql.Append(":C_ROLL_ID,:C_STOVE,:C_BATCH_NO,:C_TICK_NO,:C_STL_GRD,:N_WGT,:C_STD_CODE,:C_SPEC,:C_MAT_CODE,:C_MAT_NAME,:C_SHIFT,:C_GROUP,:C_JUDGE_LEV,:C_REASON_NAME,:C_REASON_CODE,:C_REASON_DEPMT_ID,:C_REASON_DEPMT_DESC,:C_SUGGESTION,:N_STATUS,:C_REMARK,:C_EMP_ID)");
			OracleParameter[] parameters = {
					new OracleParameter(":C_ROLL_ID", OracleDbType.Varchar2,100),
					new OracleParameter(":C_STOVE", OracleDbType.Varchar2,100),
					new OracleParameter(":C_BATCH_NO", OracleDbType.Varchar2,100),
					new OracleParameter(":C_TICK_NO", OracleDbType.Varchar2,100),
					new OracleParameter(":C_STL_GRD", OracleDbType.Varchar2,100),
					new OracleParameter(":N_WGT", OracleDbType.Double,15),
					new OracleParameter(":C_STD_CODE", OracleDbType.Varchar2,100),
					new OracleParameter(":C_SPEC", OracleDbType.Varchar2,100),
					new OracleParameter(":C_MAT_CODE", OracleDbType.Varchar2,100),
					new OracleParameter(":C_MAT_NAME", OracleDbType.Varchar2,100),
					new OracleParameter(":C_SHIFT", OracleDbType.Varchar2,100),
					new OracleParameter(":C_GROUP", OracleDbType.Varchar2,100),
					new OracleParameter(":C_JUDGE_LEV", OracleDbType.Varchar2,100),
					new OracleParameter(":C_REASON_NAME", OracleDbType.Varchar2,100),
					new OracleParameter(":C_REASON_CODE", OracleDbType.Varchar2,100),
					new OracleParameter(":C_REASON_DEPMT_ID", OracleDbType.Varchar2,100),
					new OracleParameter(":C_REASON_DEPMT_DESC", OracleDbType.Varchar2,100),
					new OracleParameter(":C_SUGGESTION", OracleDbType.Varchar2,100),
					new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
					new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
					new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100)};
			parameters[0].Value = model.C_ROLL_ID;
			parameters[1].Value = model.C_STOVE;
			parameters[2].Value = model.C_BATCH_NO;
			parameters[3].Value = model.C_TICK_NO;
			parameters[4].Value = model.C_STL_GRD;
			parameters[5].Value = model.N_WGT;
			parameters[6].Value = model.C_STD_CODE;
			parameters[7].Value = model.C_SPEC;
			parameters[8].Value = model.C_MAT_CODE;
			parameters[9].Value = model.C_MAT_NAME;
			parameters[10].Value = model.C_SHIFT;
			parameters[11].Value = model.C_GROUP;
			parameters[12].Value = model.C_JUDGE_LEV;
			parameters[13].Value = model.C_REASON_NAME;
			parameters[14].Value = model.C_REASON_CODE;
			parameters[15].Value = model.C_REASON_DEPMT_ID;
			parameters[16].Value = model.C_REASON_DEPMT_DESC;
			parameters[17].Value = model.C_SUGGESTION;
			parameters[18].Value = model.N_STATUS;
			parameters[19].Value = model.C_REMARK;
			parameters[20].Value = model.C_EMP_ID;

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
		public bool Update(Mod_TQC_FACE_ROLL model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update TQC_FACE_ROLL set ");
			strSql.Append("C_ROLL_ID=:C_ROLL_ID,");
			strSql.Append("C_STOVE=:C_STOVE,");
			strSql.Append("C_BATCH_NO=:C_BATCH_NO,");
			strSql.Append("C_TICK_NO=:C_TICK_NO,");
			strSql.Append("C_STL_GRD=:C_STL_GRD,");
			strSql.Append("N_WGT=:N_WGT,");
			strSql.Append("C_STD_CODE=:C_STD_CODE,");
			strSql.Append("C_SPEC=:C_SPEC,");
			strSql.Append("C_MAT_CODE=:C_MAT_CODE,");
			strSql.Append("C_MAT_NAME=:C_MAT_NAME,");
			strSql.Append("C_SHIFT=:C_SHIFT,");
			strSql.Append("C_GROUP=:C_GROUP,");
			strSql.Append("C_JUDGE_LEV=:C_JUDGE_LEV,");
			strSql.Append("C_REASON_NAME=:C_REASON_NAME,");
			strSql.Append("C_REASON_CODE=:C_REASON_CODE,");
			strSql.Append("C_REASON_DEPMT_ID=:C_REASON_DEPMT_ID,");
			strSql.Append("C_REASON_DEPMT_DESC=:C_REASON_DEPMT_DESC,");
			strSql.Append("C_SUGGESTION=:C_SUGGESTION,");
			strSql.Append("N_STATUS=:N_STATUS,");
			strSql.Append("C_REMARK=:C_REMARK,");
			strSql.Append("C_EMP_ID=:C_EMP_ID,");
			strSql.Append("D_MOD_DT=:D_MOD_DT");
			strSql.Append(" where C_ID=:C_ID ");
			OracleParameter[] parameters = {
					new OracleParameter(":C_ROLL_ID", OracleDbType.Varchar2,100),
					new OracleParameter(":C_STOVE", OracleDbType.Varchar2,100),
					new OracleParameter(":C_BATCH_NO", OracleDbType.Varchar2,100),
					new OracleParameter(":C_TICK_NO", OracleDbType.Varchar2,100),
					new OracleParameter(":C_STL_GRD", OracleDbType.Varchar2,100),
					new OracleParameter(":N_WGT", OracleDbType.Double,15),
					new OracleParameter(":C_STD_CODE", OracleDbType.Varchar2,100),
					new OracleParameter(":C_SPEC", OracleDbType.Varchar2,100),
					new OracleParameter(":C_MAT_CODE", OracleDbType.Varchar2,100),
					new OracleParameter(":C_MAT_NAME", OracleDbType.Varchar2,100),
					new OracleParameter(":C_SHIFT", OracleDbType.Varchar2,100),
					new OracleParameter(":C_GROUP", OracleDbType.Varchar2,100),
					new OracleParameter(":C_JUDGE_LEV", OracleDbType.Varchar2,100),
					new OracleParameter(":C_REASON_NAME", OracleDbType.Varchar2,100),
					new OracleParameter(":C_REASON_CODE", OracleDbType.Varchar2,100),
					new OracleParameter(":C_REASON_DEPMT_ID", OracleDbType.Varchar2,100),
					new OracleParameter(":C_REASON_DEPMT_DESC", OracleDbType.Varchar2,100),
					new OracleParameter(":C_SUGGESTION", OracleDbType.Varchar2,100),
					new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
					new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
					new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
					new OracleParameter(":D_MOD_DT", OracleDbType.Date),
					new OracleParameter(":C_ID", OracleDbType.Varchar2,100)};
			parameters[0].Value = model.C_ROLL_ID;
			parameters[1].Value = model.C_STOVE;
			parameters[2].Value = model.C_BATCH_NO;
			parameters[3].Value = model.C_TICK_NO;
			parameters[4].Value = model.C_STL_GRD;
			parameters[5].Value = model.N_WGT;
			parameters[6].Value = model.C_STD_CODE;
			parameters[7].Value = model.C_SPEC;
			parameters[8].Value = model.C_MAT_CODE;
			parameters[9].Value = model.C_MAT_NAME;
			parameters[10].Value = model.C_SHIFT;
			parameters[11].Value = model.C_GROUP;
			parameters[12].Value = model.C_JUDGE_LEV;
			parameters[13].Value = model.C_REASON_NAME;
			parameters[14].Value = model.C_REASON_CODE;
			parameters[15].Value = model.C_REASON_DEPMT_ID;
			parameters[16].Value = model.C_REASON_DEPMT_DESC;
			parameters[17].Value = model.C_SUGGESTION;
			parameters[18].Value = model.N_STATUS;
			parameters[19].Value = model.C_REMARK;
			parameters[20].Value = model.C_EMP_ID;
			parameters[21].Value = model.D_MOD_DT;
			parameters[22].Value = model.C_ID;

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
			strSql.Append("delete from TQC_FACE_ROLL ");
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
			strSql.Append("delete from TQC_FACE_ROLL ");
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
		public Mod_TQC_FACE_ROLL GetModel(string C_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select C_ID,C_ROLL_ID,C_STOVE,C_BATCH_NO,C_TICK_NO,C_STL_GRD,N_WGT,C_STD_CODE,C_SPEC,C_MAT_CODE,C_MAT_NAME,C_SHIFT,C_GROUP,C_JUDGE_LEV,C_REASON_NAME,C_REASON_CODE,C_REASON_DEPMT_ID,C_REASON_DEPMT_DESC,C_SUGGESTION,N_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT from TQC_FACE_ROLL ");
			strSql.Append(" where C_ID=:C_ID ");
			OracleParameter[] parameters = {
					new OracleParameter(":C_ID", OracleDbType.Varchar2,100)			};
			parameters[0].Value = C_ID;

			Mod_TQC_FACE_ROLL model=new Mod_TQC_FACE_ROLL();
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
		public Mod_TQC_FACE_ROLL DataRowToModel(DataRow row)
		{
			Mod_TQC_FACE_ROLL model=new Mod_TQC_FACE_ROLL();
			if (row != null)
			{
				if(row["C_ID"]!=null)
				{
					model.C_ID=row["C_ID"].ToString();
				}
				if(row["C_ROLL_ID"]!=null)
				{
					model.C_ROLL_ID=row["C_ROLL_ID"].ToString();
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
				if(row["C_STL_GRD"]!=null)
				{
					model.C_STL_GRD=row["C_STL_GRD"].ToString();
				}
				if(row["N_WGT"]!=null && row["N_WGT"].ToString()!="")
				{
					model.N_WGT=decimal.Parse(row["N_WGT"].ToString());
				}
				if(row["C_STD_CODE"]!=null)
				{
					model.C_STD_CODE=row["C_STD_CODE"].ToString();
				}
				if(row["C_SPEC"]!=null)
				{
					model.C_SPEC=row["C_SPEC"].ToString();
				}
				if(row["C_MAT_CODE"]!=null)
				{
					model.C_MAT_CODE=row["C_MAT_CODE"].ToString();
				}
				if(row["C_MAT_NAME"]!=null)
				{
					model.C_MAT_NAME=row["C_MAT_NAME"].ToString();
				}
				if(row["C_SHIFT"]!=null)
				{
					model.C_SHIFT=row["C_SHIFT"].ToString();
				}
				if(row["C_GROUP"]!=null)
				{
					model.C_GROUP=row["C_GROUP"].ToString();
				}
				if(row["C_JUDGE_LEV"]!=null)
				{
					model.C_JUDGE_LEV=row["C_JUDGE_LEV"].ToString();
				}
				if(row["C_REASON_NAME"]!=null)
				{
					model.C_REASON_NAME=row["C_REASON_NAME"].ToString();
				}
				if(row["C_REASON_CODE"]!=null)
				{
					model.C_REASON_CODE=row["C_REASON_CODE"].ToString();
				}
				if(row["C_REASON_DEPMT_ID"]!=null)
				{
					model.C_REASON_DEPMT_ID=row["C_REASON_DEPMT_ID"].ToString();
				}
				if(row["C_REASON_DEPMT_DESC"]!=null)
				{
					model.C_REASON_DEPMT_DESC=row["C_REASON_DEPMT_DESC"].ToString();
				}
				if(row["C_SUGGESTION"]!=null)
				{
					model.C_SUGGESTION=row["C_SUGGESTION"].ToString();
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
		public DataSet GetList_ID(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_ROLL_ID,C_STOVE,C_BATCH_NO,C_TICK_NO,C_STL_GRD,N_WGT,C_STD_CODE,C_SPEC,C_MAT_CODE,C_MAT_NAME,C_SHIFT,C_GROUP,C_JUDGE_LEV,C_REASON_NAME,C_REASON_CODE,C_REASON_DEPMT_ID,C_REASON_DEPMT_DESC,C_SUGGESTION,N_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT ");
            strSql.Append(" FROM TQC_FACE_ROLL ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where C_ID='" + strWhere + "'");
            }
            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 获得数据列表-判定时间
        /// </summary>
        /// <param name="begin">开始时间</param>
        /// <param name="end">结束时间</param>
        /// <param name="strWhere">批号</param>
        /// <returns></returns>
        public DataSet GetList_DTE(DateTime begin, DateTime end, string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_ROLL_ID,C_STOVE,C_BATCH_NO,C_TICK_NO,C_STL_GRD,N_WGT,C_STD_CODE,C_SPEC,C_MAT_CODE,C_MAT_NAME,C_SHIFT,C_GROUP,C_JUDGE_LEV,C_REASON_NAME,C_REASON_CODE,C_REASON_DEPMT_ID,C_REASON_DEPMT_DESC,C_SUGGESTION,N_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT ");
            strSql.Append(" FROM TQC_FACE_ROLL where 1=1 ");
            if (begin != null && end != null)
            {
                strSql.Append(" and D_MOD_DT between to_date('" + Convert.ToDateTime(begin) + "','yyyy-mm-dd hh24:mi:ss') and to_date('" + Convert.ToDateTime(end) + "','yyyy-mm-dd hh24:mi:ss') ");
            }
            if (strWhere.Trim() != "")
            {
                strSql.Append(" and  C_BATCH_NO like '%" + strWhere + "%'");
            }
            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(DateTime begin, DateTime end, string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select C_ID,C_ROLL_ID,C_STOVE,C_BATCH_NO,C_TICK_NO,C_STL_GRD,N_WGT,C_STD_CODE,C_SPEC,C_MAT_CODE,C_MAT_NAME,C_SHIFT,C_GROUP,C_JUDGE_LEV,C_REASON_NAME,C_REASON_CODE,C_REASON_DEPMT_ID,C_REASON_DEPMT_DESC,C_SUGGESTION,N_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT ");
			strSql.Append(" FROM TQC_FACE_ROLL where N_STATUS=1");
            if (begin != null && end != null)
            {
                strSql.Append(" and D_MOD_DT between to_date('" + Convert.ToDateTime(begin) + "','yyyy-mm-dd hh24:mi:ss') and to_date('" + Convert.ToDateTime(end) + "','yyyy-mm-dd hh24:mi:ss') ");
            }
            if (strWhere.Trim()!="")
			{
				strSql.Append(" and  C_BATCH_NO  like '%"+ strWhere + "%'" );
			}
			return DbHelperOra.Query(strSql.ToString());
		}
        /// <summary>
        /// 通过线材实绩表外键获得数据列表
        /// </summary>
        public DataSet GetList_C_ROLL_ID(string C_ROLL_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_ROLL_ID,C_STOVE,C_BATCH_NO,C_TICK_NO,C_STL_GRD,N_WGT,C_STD_CODE,C_SPEC,C_MAT_CODE,C_MAT_NAME,C_SHIFT,C_GROUP,C_JUDGE_LEV,C_REASON_NAME,C_REASON_CODE,C_REASON_DEPMT_ID,C_REASON_DEPMT_DESC,C_SUGGESTION,N_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT ");
            strSql.Append(" FROM TQC_FACE_ROLL ");
            if (C_ROLL_ID.Trim() != "")
            {
                strSql.Append(" where  C_ROLL_ID ='" + C_ROLL_ID + "'");
            }
            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM TQC_FACE_ROLL ");
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
			strSql.Append(")AS Row, T.*  from TQC_FACE_ROLL T ");
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
			parameters[0].Value = "TQC_FACE_ROLL";
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

