using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;
using System.Collections;

namespace DAL
{
	/// <summary>
	/// 数据访问类:TRC_ROLL_SPOT_CHECK_NAME
	/// </summary>
	public partial class Dal_TRC_ROLL_SPOT_CHECK_NAME
	{
		public Dal_TRC_ROLL_SPOT_CHECK_NAME()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string C_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from TRC_ROLL_SPOT_CHECK_NAME");
			strSql.Append(" where C_ID=:C_ID ");
			OracleParameter[] parameters = {
					new OracleParameter(":C_ID", OracleDbType.Varchar2,100)			};
			parameters[0].Value = C_ID;

			return DbHelperOra.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Mod_TRC_ROLL_SPOT_CHECK_NAME model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into TRC_ROLL_SPOT_CHECK_NAME(");
			strSql.Append("C_ROLL_SPOT_CHECK_ID,C_SAMPLES_NAME,N_SAM_NUM,N_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT)");
			strSql.Append(" values (");
			strSql.Append(":C_ROLL_SPOT_CHECK_ID,:C_SAMPLES_NAME,:N_SAM_NUM,:N_STATUS,:C_REMARK,:C_EMP_ID,:D_MOD_DT)");
			OracleParameter[] parameters = {
					new OracleParameter(":C_ROLL_SPOT_CHECK_ID", OracleDbType.Varchar2,100),
					new OracleParameter(":C_SAMPLES_NAME", OracleDbType.Varchar2,100),
					new OracleParameter(":N_SAM_NUM", OracleDbType.Decimal,5),
					new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
					new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
					new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
					new OracleParameter(":D_MOD_DT", OracleDbType.Date)};
			parameters[0].Value = model.C_ROLL_SPOT_CHECK_ID;
			parameters[1].Value = model.C_SAMPLES_NAME;
			parameters[2].Value = model.N_SAM_NUM;
			parameters[3].Value = model.N_STATUS;
			parameters[4].Value = model.C_REMARK;
			parameters[5].Value = model.C_EMP_ID;
			parameters[6].Value = model.D_MOD_DT;

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
		public bool Update(Mod_TRC_ROLL_SPOT_CHECK_NAME model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update TRC_ROLL_SPOT_CHECK_NAME set ");
			strSql.Append("C_ROLL_SPOT_CHECK_ID=:C_ROLL_SPOT_CHECK_ID,");
			strSql.Append("C_SAMPLES_NAME=:C_SAMPLES_NAME,");
			strSql.Append("N_SAM_NUM=:N_SAM_NUM,");
			strSql.Append("N_STATUS=:N_STATUS,");
			strSql.Append("C_REMARK=:C_REMARK,");
			strSql.Append("C_EMP_ID=:C_EMP_ID,");
			strSql.Append("D_MOD_DT=:D_MOD_DT");
			strSql.Append(" where C_ID=:C_ID ");
			OracleParameter[] parameters = {
					new OracleParameter(":C_ROLL_SPOT_CHECK_ID", OracleDbType.Varchar2,100),
					new OracleParameter(":C_SAMPLES_NAME", OracleDbType.Varchar2,100),
					new OracleParameter(":N_SAM_NUM", OracleDbType.Decimal,5),
					new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
					new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
					new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
					new OracleParameter(":D_MOD_DT", OracleDbType.Date),
					new OracleParameter(":C_ID", OracleDbType.Varchar2,100)};
			parameters[0].Value = model.C_ROLL_SPOT_CHECK_ID;
			parameters[1].Value = model.C_SAMPLES_NAME;
			parameters[2].Value = model.N_SAM_NUM;
			parameters[3].Value = model.N_STATUS;
			parameters[4].Value = model.C_REMARK;
			parameters[5].Value = model.C_EMP_ID;
			parameters[6].Value = model.D_MOD_DT;
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
			strSql.Append("delete from TRC_ROLL_SPOT_CHECK_NAME ");
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
			strSql.Append("delete from TRC_ROLL_SPOT_CHECK_NAME ");
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
		public Mod_TRC_ROLL_SPOT_CHECK_NAME GetModel(string C_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select C_ID,C_ROLL_SPOT_CHECK_ID,C_SAMPLES_NAME,N_SAM_NUM,N_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT from TRC_ROLL_SPOT_CHECK_NAME ");
			strSql.Append(" where C_ID=:C_ID ");
			OracleParameter[] parameters = {
					new OracleParameter(":C_ID", OracleDbType.Varchar2,100)			};
			parameters[0].Value = C_ID;

			Mod_TRC_ROLL_SPOT_CHECK_NAME model=new Mod_TRC_ROLL_SPOT_CHECK_NAME();
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
		public Mod_TRC_ROLL_SPOT_CHECK_NAME DataRowToModel(DataRow row)
		{
			Mod_TRC_ROLL_SPOT_CHECK_NAME model=new Mod_TRC_ROLL_SPOT_CHECK_NAME();
			if (row != null)
			{
				if(row["C_ID"]!=null)
				{
					model.C_ID=row["C_ID"].ToString();
				}
				if(row["C_ROLL_SPOT_CHECK_ID"]!=null)
				{
					model.C_ROLL_SPOT_CHECK_ID=row["C_ROLL_SPOT_CHECK_ID"].ToString();
				}
				if(row["C_SAMPLES_NAME"]!=null)
				{
					model.C_SAMPLES_NAME=row["C_SAMPLES_NAME"].ToString();
				}
				if(row["N_SAM_NUM"]!=null && row["N_SAM_NUM"].ToString()!="")
				{
					model.N_SAM_NUM=decimal.Parse(row["N_SAM_NUM"].ToString());
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
        /// 获得数据列表-条件查询
        /// </summary>
        /// <param name="begin">开始时间</param>
        /// <param name="end">结束时间</param>
        /// <param name="strBatchNo">批号</param>
        /// <returns></returns>
        public DataSet GetList_CCSY(DateTime begin, DateTime end, string strBatchNo)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ta.c_id as 主键,decode(ta.N_ENTRUST_TYPE, 0, '未委托', 1, '已委托') as 状态,ta.c_stove as 炉号,ta.c_batch_no as 批号, ta.c_tick_no as 钩号,ta.c_stl_grd as 钢种,ta.c_spec as 规格,tb.c_samples_name as 取样名称,tb.n_sam_num as 取样数量,ta.d_mod_dt as 取样时间 from TRC_ROLL_SPOT_CHECK ta left join TRC_ROLL_SPOT_CHECK_NAME tb on tb.C_ROLL_SPOT_CHECK_ID = ta.C_ID WHERE ta.N_ENTRUST_TYPE = 1 ");
            if (begin != null && end != null)
            {
                strSql.Append(" and ta.d_mod_dt between to_date('" + Convert.ToDateTime(begin) + "','yyyy-mm-dd hh24:mi:ss') and to_date('" + Convert.ToDateTime(end) + "','yyyy-mm-dd hh24:mi:ss')  ");
            }
            if (strBatchNo.Trim() != "")
            {
                strSql.Append(" AND ta.c_batch_no like '" + strBatchNo + "%' ");
            }
            strSql.Append(" order by ta.c_batch_no,ta.c_tick_no");

            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得数据列表-条件查询
        /// </summary>
        /// <param name="begin">开始时间</param>
        /// <param name="end">结束时间</param>
        /// <param name="strBatchNo">批号</param>
        /// <returns></returns>
        public DataSet GetList_CCZY(DateTime begin, DateTime end, string strBatchNo)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ta.c_id as 主键,decode(ta.N_ENTRUST_TYPE, 0, '未委托', 1, '已委托') as 状态,ta.c_stove as 炉号,ta.c_batch_no as 批号, ta.c_tick_no as 钩号,ta.c_stl_grd as 钢种,ta.c_spec as 规格,tb.c_samples_name as 取样名称,tb.n_sam_num as 取样数量,tb.d_mod_dt as 取样时间,ta.d_mod_dt_js as 接样时间 from TRC_ROLL_SPOT_CHECK ta left join TRC_ROLL_SPOT_CHECK_NAME tb on tb.C_ROLL_SPOT_CHECK_ID = ta.C_ID WHERE ta.N_ENTRUST_TYPE = 2 ");
            if (begin != null && end != null)
            {
                strSql.Append(" and ta.d_mod_dt_js between to_date('" + Convert.ToDateTime(begin) + "','yyyy-mm-dd hh24:mi:ss') and to_date('" + Convert.ToDateTime(end) + "','yyyy-mm-dd hh24:mi:ss')  ");
            }
            if (strBatchNo.Trim() != "")
            {
                strSql.Append(" AND ta.c_batch_no like '" + strBatchNo + "%' ");
            }
            strSql.Append(" order by ta.c_batch_no,ta.c_tick_no");

            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得数据列表-条件查询
        /// </summary>
        /// <param name="begin">开始时间</param>
        /// <param name="end">结束时间</param>
        /// <param name="strBatchNo">批号</param>
        /// <returns></returns>
        public DataSet GetList_ZYXX(DateTime begin, DateTime end, string strBatchNo)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ta.c_id as 主键,decode(ta.N_ENTRUST_TYPE, 0, '未委托', 1, '已委托') as 状态,ta.c_stove as 炉号,ta.c_batch_no as 批号, ta.c_tick_no as 钩号,ta.c_stl_grd as 钢种,ta.c_spec as 规格,tb.c_samples_name as 取样名称,tb.n_sam_num as 取样数量,tb.d_mod_dt as 取样时间,ta.d_mod_dt_zy as 制样时间 from TRC_ROLL_SPOT_CHECK ta left join TRC_ROLL_SPOT_CHECK_NAME tb on tb.C_ROLL_SPOT_CHECK_ID = ta.C_ID WHERE ta.N_ENTRUST_TYPE not in (0,1) ");
            if (begin != null && end != null)
            {
                strSql.Append(" and ta.d_mod_dt_zy between to_date('" + Convert.ToDateTime(begin) + "','yyyy-mm-dd hh24:mi:ss') and to_date('" + Convert.ToDateTime(end) + "','yyyy-mm-dd hh24:mi:ss')  ");
            }
            if (strBatchNo.Trim() != "")
            {
                strSql.Append(" AND ta.c_batch_no like '" + strBatchNo + "%' ");
            }
            strSql.Append(" order by ta.c_batch_no,ta.c_tick_no");

            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得数据列表-已委托
        /// </summary>
        public DataSet Get_List_Query(string strBatchNo)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ta.c_id as 主键,decode(ta.N_ENTRUST_TYPE, 0, '未委托', 1, '已委托') as 状态,ta.c_stove as 炉号,ta.c_batch_no as 批号, ta.c_tick_no as 钩号,ta.c_stl_grd as 钢种,ta.c_spec as 规格,tb.c_samples_name as 取样名称,tb.n_sam_num as 取样数量 from TRC_ROLL_SPOT_CHECK ta left join TRC_ROLL_SPOT_CHECK_NAME tb on tb.C_ROLL_SPOT_CHECK_ID = ta.C_ID WHERE ta.N_ENTRUST_TYPE = 1 ");
            if (strBatchNo.Trim() != "")
            {
                strSql.Append(" AND ta.c_batch_no like '" + strBatchNo + "%' ");
            }
            strSql.Append(" order by ta.c_batch_no,ta.c_tick_no");

            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 获得数据列表-未委托
        /// </summary>
        public DataSet Get_List(string strBatchNo)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ta.c_id as 主键,decode(ta.N_ENTRUST_TYPE, 0, '未委托', 1, '已委托') as 状态,ta.c_stove as 炉号,ta.c_batch_no as 批号, ta.c_tick_no as 钩号,ta.c_stl_grd as 钢种,ta.c_spec as 规格,tb.c_samples_name as 取样名称,tb.n_sam_num as 取样数量 from TRC_ROLL_SPOT_CHECK ta left join TRC_ROLL_SPOT_CHECK_NAME tb on tb.C_ROLL_SPOT_CHECK_ID = ta.C_ID WHERE ta.N_ENTRUST_TYPE = 0 ");
            if (strBatchNo.Trim() != "")
            {
                strSql.Append(" AND ta.c_batch_no like '" + strBatchNo + "%' ");
            }
            strSql.Append(" order by ta.c_batch_no,ta.c_tick_no");

            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select C_ID,C_ROLL_SPOT_CHECK_ID,C_SAMPLES_NAME,N_SAM_NUM,N_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT ");
			strSql.Append(" FROM TRC_ROLL_SPOT_CHECK_NAME ");
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
			strSql.Append("select count(1) FROM TRC_ROLL_SPOT_CHECK_NAME ");
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
			strSql.Append(")AS Row, T.*  from TRC_ROLL_SPOT_CHECK_NAME T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DbHelperOra.Query(strSql.ToString());
		}

        /// <summary>
        /// 保存送样信息
        /// </summary>
        public bool SaveSamp(ArrayList SQLStringList)
        {
            return DbHelperOra.ExecuteSqlTran(SQLStringList);
        }

        #endregion  BasicMethod
        #region  ExtensionMethod

        #endregion  ExtensionMethod
    }
}

