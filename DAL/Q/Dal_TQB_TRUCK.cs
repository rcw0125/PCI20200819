using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;
namespace DAL
{
	/// <summary>
	/// 数据访问类:TQB_TRUCK
	/// </summary>
	public partial class Dal_TQB_TRUCK
    {
		public Dal_TQB_TRUCK()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string C_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from TQB_TRUCK");
			strSql.Append(" where C_ID=:C_ID ");
			OracleParameter[] parameters = {
					new OracleParameter(":C_ID", OracleDbType.Varchar2,100)			};
			parameters[0].Value = C_ID;

			return DbHelperOra.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Mod_TQB_TRUCK model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into TQB_TRUCK(");
			strSql.Append("D_TRUCK_DT,C_TRUCK_NUM,C_SHIPMENT_BATCH,C_STL_GRD,C_LOADING_QUANTITY,C_CRE_ABRADE,C_CRE_ABRADE_TICK,C_BACK_ABRADE,C_BACK_ABRADE_TICK,C_SUPERINTENDENT,N_STATUS,C_REMARK,C_EMP_ID)");
			strSql.Append(" values (");
			strSql.Append(":D_TRUCK_DT,:C_TRUCK_NUM,:C_SHIPMENT_BATCH,:C_STL_GRD,:C_LOADING_QUANTITY,:C_CRE_ABRADE,:C_CRE_ABRADE_TICK,:C_BACK_ABRADE,:C_BACK_ABRADE_TICK,:C_SUPERINTENDENT,:N_STATUS,:C_REMARK,:C_EMP_ID)");
			OracleParameter[] parameters = {
					new OracleParameter(":D_TRUCK_DT", OracleDbType.Date),
					new OracleParameter(":C_TRUCK_NUM", OracleDbType.Varchar2,100),
					new OracleParameter(":C_SHIPMENT_BATCH", OracleDbType.Varchar2,100),
					new OracleParameter(":C_STL_GRD", OracleDbType.Varchar2,100),
					new OracleParameter(":C_LOADING_QUANTITY", OracleDbType.Varchar2,100),
					new OracleParameter(":C_CRE_ABRADE", OracleDbType.Varchar2,100),
					new OracleParameter(":C_CRE_ABRADE_TICK", OracleDbType.Varchar2,100),
					new OracleParameter(":C_BACK_ABRADE", OracleDbType.Varchar2,100),
					new OracleParameter(":C_BACK_ABRADE_TICK", OracleDbType.Varchar2,100),
					new OracleParameter(":C_SUPERINTENDENT", OracleDbType.Varchar2,100),
					new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
					new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
					new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100)};
			parameters[0].Value = model.D_TRUCK_DT;
			parameters[1].Value = model.C_TRUCK_NUM;
			parameters[2].Value = model.C_SHIPMENT_BATCH;
			parameters[3].Value = model.C_STL_GRD;
			parameters[4].Value = model.C_LOADING_QUANTITY;
			parameters[5].Value = model.C_CRE_ABRADE;
			parameters[6].Value = model.C_CRE_ABRADE_TICK;
			parameters[7].Value = model.C_BACK_ABRADE;
			parameters[8].Value = model.C_BACK_ABRADE_TICK;
			parameters[9].Value = model.C_SUPERINTENDENT;
			parameters[10].Value = model.N_STATUS;
			parameters[11].Value = model.C_REMARK;
			parameters[12].Value = model.C_EMP_ID;

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
		public bool Update(Mod_TQB_TRUCK model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update TQB_TRUCK set ");
			strSql.Append("D_TRUCK_DT=:D_TRUCK_DT,");
			strSql.Append("C_TRUCK_NUM=:C_TRUCK_NUM,");
			strSql.Append("C_SHIPMENT_BATCH=:C_SHIPMENT_BATCH,");
			strSql.Append("C_STL_GRD=:C_STL_GRD,");
			strSql.Append("C_LOADING_QUANTITY=:C_LOADING_QUANTITY,");
			strSql.Append("C_CRE_ABRADE=:C_CRE_ABRADE,");
			strSql.Append("C_CRE_ABRADE_TICK=:C_CRE_ABRADE_TICK,");
			strSql.Append("C_BACK_ABRADE=:C_BACK_ABRADE,");
			strSql.Append("C_BACK_ABRADE_TICK=:C_BACK_ABRADE_TICK,");
			strSql.Append("C_SUPERINTENDENT=:C_SUPERINTENDENT,");
			strSql.Append("N_STATUS=:N_STATUS,");
			strSql.Append("C_REMARK=:C_REMARK,");
			strSql.Append("C_EMP_ID=:C_EMP_ID,");
			strSql.Append("D_MOD_DT=:D_MOD_DT");
			strSql.Append(" where C_ID=:C_ID ");
			OracleParameter[] parameters = {
					new OracleParameter(":D_TRUCK_DT", OracleDbType.Date),
					new OracleParameter(":C_TRUCK_NUM", OracleDbType.Varchar2,100),
					new OracleParameter(":C_SHIPMENT_BATCH", OracleDbType.Varchar2,100),
					new OracleParameter(":C_STL_GRD", OracleDbType.Varchar2,100),
					new OracleParameter(":C_LOADING_QUANTITY", OracleDbType.Varchar2,100),
					new OracleParameter(":C_CRE_ABRADE", OracleDbType.Varchar2,100),
					new OracleParameter(":C_CRE_ABRADE_TICK", OracleDbType.Varchar2,100),
					new OracleParameter(":C_BACK_ABRADE", OracleDbType.Varchar2,100),
					new OracleParameter(":C_BACK_ABRADE_TICK", OracleDbType.Varchar2,100),
					new OracleParameter(":C_SUPERINTENDENT", OracleDbType.Varchar2,100),
					new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
					new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
					new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
					new OracleParameter(":D_MOD_DT", OracleDbType.Date),
					new OracleParameter(":C_ID", OracleDbType.Varchar2,100)};
			parameters[0].Value = model.D_TRUCK_DT;
			parameters[1].Value = model.C_TRUCK_NUM;
			parameters[2].Value = model.C_SHIPMENT_BATCH;
			parameters[3].Value = model.C_STL_GRD;
			parameters[4].Value = model.C_LOADING_QUANTITY;
			parameters[5].Value = model.C_CRE_ABRADE;
			parameters[6].Value = model.C_CRE_ABRADE_TICK;
			parameters[7].Value = model.C_BACK_ABRADE;
			parameters[8].Value = model.C_BACK_ABRADE_TICK;
			parameters[9].Value = model.C_SUPERINTENDENT;
			parameters[10].Value = model.N_STATUS;
			parameters[11].Value = model.C_REMARK;
			parameters[12].Value = model.C_EMP_ID;
			parameters[13].Value = model.D_MOD_DT;
			parameters[14].Value = model.C_ID;

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
			strSql.Append("delete from TQB_TRUCK ");
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
			strSql.Append("delete from TQB_TRUCK ");
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
		public Mod_TQB_TRUCK GetModel(string C_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select C_ID,D_TRUCK_DT,C_TRUCK_NUM,C_SHIPMENT_BATCH,C_STL_GRD,C_LOADING_QUANTITY,C_CRE_ABRADE,C_CRE_ABRADE_TICK,C_BACK_ABRADE,C_BACK_ABRADE_TICK,C_SUPERINTENDENT,N_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT from TQB_TRUCK ");
			strSql.Append(" where C_ID=:C_ID ");
			OracleParameter[] parameters = {
					new OracleParameter(":C_ID", OracleDbType.Varchar2,100)			};
			parameters[0].Value = C_ID;

			Mod_TQB_TRUCK model=new Mod_TQB_TRUCK();
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
		public Mod_TQB_TRUCK DataRowToModel(DataRow row)
		{
			Mod_TQB_TRUCK model=new Mod_TQB_TRUCK();
			if (row != null)
			{
				if(row["C_ID"]!=null)
				{
					model.C_ID=row["C_ID"].ToString();
				}
				if(row["D_TRUCK_DT"]!=null && row["D_TRUCK_DT"].ToString()!="")
				{
					model.D_TRUCK_DT=DateTime.Parse(row["D_TRUCK_DT"].ToString());
				}
				if(row["C_TRUCK_NUM"]!=null)
				{
					model.C_TRUCK_NUM=row["C_TRUCK_NUM"].ToString();
				}
				if(row["C_SHIPMENT_BATCH"]!=null)
				{
					model.C_SHIPMENT_BATCH=row["C_SHIPMENT_BATCH"].ToString();
				}
				if(row["C_STL_GRD"]!=null)
				{
					model.C_STL_GRD=row["C_STL_GRD"].ToString();
				}
				if(row["C_LOADING_QUANTITY"]!=null)
				{
					model.C_LOADING_QUANTITY=row["C_LOADING_QUANTITY"].ToString();
				}
				if(row["C_CRE_ABRADE"]!=null)
				{
					model.C_CRE_ABRADE=row["C_CRE_ABRADE"].ToString();
				}
				if(row["C_CRE_ABRADE_TICK"]!=null)
				{
					model.C_CRE_ABRADE_TICK=row["C_CRE_ABRADE_TICK"].ToString();
				}
				if(row["C_BACK_ABRADE"]!=null)
				{
					model.C_BACK_ABRADE=row["C_BACK_ABRADE"].ToString();
				}
				if(row["C_BACK_ABRADE_TICK"]!=null)
				{
					model.C_BACK_ABRADE_TICK=row["C_BACK_ABRADE_TICK"].ToString();
				}
				if(row["C_SUPERINTENDENT"]!=null)
				{
					model.C_SUPERINTENDENT=row["C_SUPERINTENDENT"].ToString();
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
        /// 获得数据列表-日期
        /// </summary>
        /// <param name="begin">装车开始时间</param>
        /// <param name="end">装车结束后时间</param>
        /// <param name="C_TRUCK_NUM">车号</param>
        /// <returns></returns>
        public DataSet GetList_Query(DateTime begin, DateTime end, string C_TRUCK_NUM)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,D_TRUCK_DT,C_TRUCK_NUM,C_SHIPMENT_BATCH,C_STL_GRD,C_LOADING_QUANTITY,C_CRE_ABRADE,C_CRE_ABRADE_TICK,C_BACK_ABRADE,C_BACK_ABRADE_TICK,C_SUPERINTENDENT,N_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT ");
            strSql.Append(" FROM TQB_TRUCK where N_STATUS=1");
            if (begin != null && end != null)
            {
                strSql.Append(" and D_TRUCK_DT between to_date('" + Convert.ToDateTime(begin) + "','yyyy-mm-dd hh24:mi:ss') and to_date('" + Convert.ToDateTime(end) + "','yyyy-mm-dd hh24:mi:ss') ");
            }
            if (C_TRUCK_NUM.Trim() != "")
            {
                strSql.Append(" and C_TRUCK_NUM like '%" + C_TRUCK_NUM + "%' ");
            }
            return DbHelperOra.Query(strSql.ToString());
        }
        
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select C_ID,D_TRUCK_DT,C_TRUCK_NUM,C_SHIPMENT_BATCH,C_STL_GRD,C_LOADING_QUANTITY,C_CRE_ABRADE,C_CRE_ABRADE_TICK,C_BACK_ABRADE,C_BACK_ABRADE_TICK,C_SUPERINTENDENT,N_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT ");
			strSql.Append(" FROM TQB_TRUCK ");
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
			strSql.Append("select count(1) FROM TQB_TRUCK ");
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
			strSql.Append(")AS Row, T.*  from TQB_TRUCK T ");
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
			parameters[0].Value = "TQB_TRUCK";
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

