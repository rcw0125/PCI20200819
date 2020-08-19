using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;
namespace DAL
{
    /// <summary>
    /// 数据访问类:TPA_HL_PLAN
    /// </summary>
    public partial class Dal_TPA_HL_PLAN
	{
		public Dal_TPA_HL_PLAN()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string C_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from TPA_HL_PLAN");
			strSql.Append(" where C_ID=:C_ID ");
			OracleParameter[] parameters = {
					new OracleParameter(":C_ID", OracleDbType.Varchar2,50)			};
			parameters[0].Value = C_ID;

			return DbHelperOra.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Mod_TPA_HL_PLAN model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into TPA_HL_PLAN(");
			strSql.Append("C_ID,C_FK,C_STOVE_NO,C_STL_GRD,C_STD_CODE,C_WH_CODE,C_SLAB_TYPE,D_START_TIME,D_END_TIME,N_HL_TIME,D_PLAN_DATE,C_HLYQ,C_REMARK,N_STATUS,C_CCM,N_QUA,N_CAP,N_TOTAL_QUA,D_START_TIME_SJ,D_END_TIME_SJ,N_QUA_SJ,C_WH_CODE_SJ,D_OVER_TIME,N_NUM)");
			strSql.Append(" values (");
			strSql.Append(":C_ID,:C_FK,:C_STOVE_NO,:C_STL_GRD,:C_STD_CODE,:C_WH_CODE,:C_SLAB_TYPE,:D_START_TIME,:D_END_TIME,:N_HL_TIME,:D_PLAN_DATE,:C_HLYQ,:C_REMARK,:N_STATUS,:C_CCM,:N_QUA,:N_CAP,:N_TOTAL_QUA,:D_START_TIME_SJ,:D_END_TIME_SJ,:N_QUA_SJ,:C_WH_CODE_SJ,:D_OVER_TIME,:N_NUM)");
			OracleParameter[] parameters = {
					new OracleParameter(":C_ID", OracleDbType.Varchar2,50),
					new OracleParameter(":C_FK", OracleDbType.Varchar2,50),
					new OracleParameter(":C_STOVE_NO", OracleDbType.Varchar2,50),
					new OracleParameter(":C_STL_GRD", OracleDbType.Varchar2,50),
					new OracleParameter(":C_STD_CODE", OracleDbType.Varchar2,50),
					new OracleParameter(":C_WH_CODE", OracleDbType.Varchar2,50),
					new OracleParameter(":C_SLAB_TYPE", OracleDbType.Varchar2,50),
					new OracleParameter(":D_START_TIME", OracleDbType.Date),
					new OracleParameter(":D_END_TIME", OracleDbType.Date),
					new OracleParameter(":N_HL_TIME", OracleDbType.Decimal,10),
					new OracleParameter(":D_PLAN_DATE", OracleDbType.Date),
					new OracleParameter(":C_HLYQ", OracleDbType.Varchar2,500),
					new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
					new OracleParameter(":N_STATUS", OracleDbType.Decimal,5),
					new OracleParameter(":C_CCM", OracleDbType.Varchar2,50),
					new OracleParameter(":N_QUA", OracleDbType.Decimal,10),
					new OracleParameter(":N_CAP", OracleDbType.Decimal,10),
					new OracleParameter(":N_TOTAL_QUA", OracleDbType.Decimal,10),
					new OracleParameter(":D_START_TIME_SJ", OracleDbType.Date),
					new OracleParameter(":D_END_TIME_SJ", OracleDbType.Date),
					new OracleParameter(":N_QUA_SJ", OracleDbType.Decimal,10),
					new OracleParameter(":C_WH_CODE_SJ", OracleDbType.Varchar2,50),
					new OracleParameter(":D_OVER_TIME", OracleDbType.Date),
					new OracleParameter(":N_NUM", OracleDbType.Decimal,10)};
			parameters[0].Value = model.C_ID;
			parameters[1].Value = model.C_FK;
			parameters[2].Value = model.C_STOVE_NO;
			parameters[3].Value = model.C_STL_GRD;
			parameters[4].Value = model.C_STD_CODE;
			parameters[5].Value = model.C_WH_CODE;
			parameters[6].Value = model.C_SLAB_TYPE;
			parameters[7].Value = model.D_START_TIME;
			parameters[8].Value = model.D_END_TIME;
			parameters[9].Value = model.N_HL_TIME;
			parameters[10].Value = model.D_PLAN_DATE;
			parameters[11].Value = model.C_HLYQ;
			parameters[12].Value = model.C_REMARK;
			parameters[13].Value = model.N_STATUS;
			parameters[14].Value = model.C_CCM;
			parameters[15].Value = model.N_QUA;
			parameters[16].Value = model.N_CAP;
			parameters[17].Value = model.N_TOTAL_QUA;
			parameters[18].Value = model.D_START_TIME_SJ;
			parameters[19].Value = model.D_END_TIME_SJ;
			parameters[20].Value = model.N_QUA_SJ;
			parameters[21].Value = model.C_WH_CODE_SJ;
			parameters[22].Value = model.D_OVER_TIME;
			parameters[23].Value = model.N_NUM;

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
        public bool TranAdd(Mod_TPA_HL_PLAN model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TPA_HL_PLAN(");
            strSql.Append("C_ID,C_FK,C_STOVE_NO,C_STL_GRD,C_STD_CODE,C_WH_CODE,C_SLAB_TYPE,D_START_TIME,D_END_TIME,N_HL_TIME,D_PLAN_DATE,C_HLYQ,C_REMARK,N_STATUS,C_CCM,N_QUA,N_CAP,N_TOTAL_QUA,D_START_TIME_SJ,D_END_TIME_SJ,N_QUA_SJ,C_WH_CODE_SJ,D_OVER_TIME,N_NUM)");
            strSql.Append(" values (");
            strSql.Append(":C_ID,:C_FK,:C_STOVE_NO,:C_STL_GRD,:C_STD_CODE,:C_WH_CODE,:C_SLAB_TYPE,:D_START_TIME,:D_END_TIME,:N_HL_TIME,:D_PLAN_DATE,:C_HLYQ,:C_REMARK,:N_STATUS,:C_CCM,:N_QUA,:N_CAP,:N_TOTAL_QUA,:D_START_TIME_SJ,:D_END_TIME_SJ,:N_QUA_SJ,:C_WH_CODE_SJ,:D_OVER_TIME,:N_NUM)");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,50),
                    new OracleParameter(":C_FK", OracleDbType.Varchar2,50),
                    new OracleParameter(":C_STOVE_NO", OracleDbType.Varchar2,50),
                    new OracleParameter(":C_STL_GRD", OracleDbType.Varchar2,50),
                    new OracleParameter(":C_STD_CODE", OracleDbType.Varchar2,50),
                    new OracleParameter(":C_WH_CODE", OracleDbType.Varchar2,50),
                    new OracleParameter(":C_SLAB_TYPE", OracleDbType.Varchar2,50),
                    new OracleParameter(":D_START_TIME", OracleDbType.Date),
                    new OracleParameter(":D_END_TIME", OracleDbType.Date),
                    new OracleParameter(":N_HL_TIME", OracleDbType.Decimal,10),
                    new OracleParameter(":D_PLAN_DATE", OracleDbType.Date),
                    new OracleParameter(":C_HLYQ", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,5),
                    new OracleParameter(":C_CCM", OracleDbType.Varchar2,50),
                    new OracleParameter(":N_QUA", OracleDbType.Decimal,10),
                    new OracleParameter(":N_CAP", OracleDbType.Decimal,10),
                    new OracleParameter(":N_TOTAL_QUA", OracleDbType.Decimal,10),
                    new OracleParameter(":D_START_TIME_SJ", OracleDbType.Date),
                    new OracleParameter(":D_END_TIME_SJ", OracleDbType.Date),
                    new OracleParameter(":N_QUA_SJ", OracleDbType.Decimal,10),
                    new OracleParameter(":C_WH_CODE_SJ", OracleDbType.Varchar2,50),
                    new OracleParameter(":D_OVER_TIME", OracleDbType.Date),
                    new OracleParameter(":N_NUM", OracleDbType.Decimal,10)};
            parameters[0].Value = model.C_ID;
            parameters[1].Value = model.C_FK;
            parameters[2].Value = model.C_STOVE_NO;
            parameters[3].Value = model.C_STL_GRD;
            parameters[4].Value = model.C_STD_CODE;
            parameters[5].Value = model.C_WH_CODE;
            parameters[6].Value = model.C_SLAB_TYPE;
            parameters[7].Value = model.D_START_TIME;
            parameters[8].Value = model.D_END_TIME;
            parameters[9].Value = model.N_HL_TIME;
            parameters[10].Value = model.D_PLAN_DATE;
            parameters[11].Value = model.C_HLYQ;
            parameters[12].Value = model.C_REMARK;
            parameters[13].Value = model.N_STATUS;
            parameters[14].Value = model.C_CCM;
            parameters[15].Value = model.N_QUA;
            parameters[16].Value = model.N_CAP;
            parameters[17].Value = model.N_TOTAL_QUA;
            parameters[18].Value = model.D_START_TIME_SJ;
            parameters[19].Value = model.D_END_TIME_SJ;
            parameters[20].Value = model.N_QUA_SJ;
            parameters[21].Value = model.C_WH_CODE_SJ;
            parameters[22].Value = model.D_OVER_TIME;
            parameters[23].Value = model.N_NUM;

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
        public bool Update(Mod_TPA_HL_PLAN model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update TPA_HL_PLAN set ");
			strSql.Append("C_FK=:C_FK,");
			strSql.Append("C_STOVE_NO=:C_STOVE_NO,");
			strSql.Append("C_STL_GRD=:C_STL_GRD,");
			strSql.Append("C_STD_CODE=:C_STD_CODE,");
			strSql.Append("C_WH_CODE=:C_WH_CODE,");
			strSql.Append("C_SLAB_TYPE=:C_SLAB_TYPE,");
			strSql.Append("D_START_TIME=:D_START_TIME,");
			strSql.Append("D_END_TIME=:D_END_TIME,");
			strSql.Append("N_HL_TIME=:N_HL_TIME,");
			strSql.Append("D_PLAN_DATE=:D_PLAN_DATE,");
			strSql.Append("C_HLYQ=:C_HLYQ,");
			strSql.Append("C_REMARK=:C_REMARK,");
			strSql.Append("N_STATUS=:N_STATUS,");
			strSql.Append("C_CCM=:C_CCM,");
			strSql.Append("N_QUA=:N_QUA,");
			strSql.Append("N_CAP=:N_CAP,");
			strSql.Append("N_TOTAL_QUA=:N_TOTAL_QUA,");
			strSql.Append("D_START_TIME_SJ=:D_START_TIME_SJ,");
			strSql.Append("D_END_TIME_SJ=:D_END_TIME_SJ,");
			strSql.Append("N_QUA_SJ=:N_QUA_SJ,");
			strSql.Append("C_WH_CODE_SJ=:C_WH_CODE_SJ,");
			strSql.Append("D_OVER_TIME=:D_OVER_TIME,");
			strSql.Append("N_NUM=:N_NUM");
			strSql.Append(" where C_ID=:C_ID ");
			OracleParameter[] parameters = {
					new OracleParameter(":C_FK", OracleDbType.Varchar2,50),
					new OracleParameter(":C_STOVE_NO", OracleDbType.Varchar2,50),
					new OracleParameter(":C_STL_GRD", OracleDbType.Varchar2,50),
					new OracleParameter(":C_STD_CODE", OracleDbType.Varchar2,50),
					new OracleParameter(":C_WH_CODE", OracleDbType.Varchar2,50),
					new OracleParameter(":C_SLAB_TYPE", OracleDbType.Varchar2,50),
					new OracleParameter(":D_START_TIME", OracleDbType.Date),
					new OracleParameter(":D_END_TIME", OracleDbType.Date),
					new OracleParameter(":N_HL_TIME", OracleDbType.Decimal,10),
					new OracleParameter(":D_PLAN_DATE", OracleDbType.Date),
					new OracleParameter(":C_HLYQ", OracleDbType.Varchar2,500),
					new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
					new OracleParameter(":N_STATUS", OracleDbType.Decimal,5),
					new OracleParameter(":C_CCM", OracleDbType.Varchar2,50),
					new OracleParameter(":N_QUA", OracleDbType.Decimal,10),
					new OracleParameter(":N_CAP", OracleDbType.Decimal,10),
					new OracleParameter(":N_TOTAL_QUA", OracleDbType.Decimal,10),
					new OracleParameter(":D_START_TIME_SJ", OracleDbType.Date),
					new OracleParameter(":D_END_TIME_SJ", OracleDbType.Date),
					new OracleParameter(":N_QUA_SJ", OracleDbType.Decimal,10),
					new OracleParameter(":C_WH_CODE_SJ", OracleDbType.Varchar2,50),
					new OracleParameter(":D_OVER_TIME", OracleDbType.Date),
					new OracleParameter(":N_NUM", OracleDbType.Decimal,10),
					new OracleParameter(":C_ID", OracleDbType.Varchar2,50)};
			parameters[0].Value = model.C_FK;
			parameters[1].Value = model.C_STOVE_NO;
			parameters[2].Value = model.C_STL_GRD;
			parameters[3].Value = model.C_STD_CODE;
			parameters[4].Value = model.C_WH_CODE;
			parameters[5].Value = model.C_SLAB_TYPE;
			parameters[6].Value = model.D_START_TIME;
			parameters[7].Value = model.D_END_TIME;
			parameters[8].Value = model.N_HL_TIME;
			parameters[9].Value = model.D_PLAN_DATE;
			parameters[10].Value = model.C_HLYQ;
			parameters[11].Value = model.C_REMARK;
			parameters[12].Value = model.N_STATUS;
			parameters[13].Value = model.C_CCM;
			parameters[14].Value = model.N_QUA;
			parameters[15].Value = model.N_CAP;
			parameters[16].Value = model.N_TOTAL_QUA;
			parameters[17].Value = model.D_START_TIME_SJ;
			parameters[18].Value = model.D_END_TIME_SJ;
			parameters[19].Value = model.N_QUA_SJ;
			parameters[20].Value = model.C_WH_CODE_SJ;
			parameters[21].Value = model.D_OVER_TIME;
			parameters[22].Value = model.N_NUM;
			parameters[23].Value = model.C_ID;

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
			strSql.Append("delete from TPA_HL_PLAN ");
			strSql.Append(" where C_ID=:C_ID ");
			OracleParameter[] parameters = {
					new OracleParameter(":C_ID", OracleDbType.Varchar2,50)			};
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
        /// 根据浇次主键删除对应的工序计划
        /// </summary>
        /// <param name="C_FK">浇次主键</param>
        /// <returns></returns>
        public bool DeleteByJcID(string C_FK)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from TPA_HL_PLAN ");
            strSql.Append(" where C_FK=:C_FK ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_FK", OracleDbType.Varchar2,50)          };
            parameters[0].Value = C_FK;

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
        /// 批量删除数据
        /// </summary>
        public bool DeleteList(string C_IDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from TPA_HL_PLAN ");
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
		public Mod_TPA_HL_PLAN GetModel(string C_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select C_ID,C_FK,C_STOVE_NO,C_STL_GRD,C_STD_CODE,C_WH_CODE,C_SLAB_TYPE,D_START_TIME,D_END_TIME,N_HL_TIME,D_PLAN_DATE,C_HLYQ,C_REMARK,N_STATUS,C_CCM,N_QUA,N_CAP,N_TOTAL_QUA,D_START_TIME_SJ,D_END_TIME_SJ,N_QUA_SJ,C_WH_CODE_SJ,D_OVER_TIME,N_NUM from TPA_HL_PLAN ");
			strSql.Append(" where C_ID=:C_ID ");
			OracleParameter[] parameters = {
					new OracleParameter(":C_ID", OracleDbType.Varchar2,50)			};
			parameters[0].Value = C_ID;

			Mod_TPA_HL_PLAN model=new Mod_TPA_HL_PLAN();
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
		public Mod_TPA_HL_PLAN DataRowToModel(DataRow row)
		{
			Mod_TPA_HL_PLAN model=new Mod_TPA_HL_PLAN();
			if (row != null)
			{
				if(row["C_ID"]!=null)
				{
					model.C_ID=row["C_ID"].ToString();
				}
				if(row["C_FK"]!=null)
				{
					model.C_FK=row["C_FK"].ToString();
				}
				if(row["C_STOVE_NO"]!=null)
				{
					model.C_STOVE_NO=row["C_STOVE_NO"].ToString();
				}
				if(row["C_STL_GRD"]!=null)
				{
					model.C_STL_GRD=row["C_STL_GRD"].ToString();
				}
				if(row["C_STD_CODE"]!=null)
				{
					model.C_STD_CODE=row["C_STD_CODE"].ToString();
				}
				if(row["C_WH_CODE"]!=null)
				{
					model.C_WH_CODE=row["C_WH_CODE"].ToString();
				}
				if(row["C_SLAB_TYPE"]!=null)
				{
					model.C_SLAB_TYPE=row["C_SLAB_TYPE"].ToString();
				}
				if(row["D_START_TIME"]!=null && row["D_START_TIME"].ToString()!="")
				{
					model.D_START_TIME=DateTime.Parse(row["D_START_TIME"].ToString());
				}
				if(row["D_END_TIME"]!=null && row["D_END_TIME"].ToString()!="")
				{
					model.D_END_TIME=DateTime.Parse(row["D_END_TIME"].ToString());
				}
				if(row["N_HL_TIME"]!=null && row["N_HL_TIME"].ToString()!="")
				{
					model.N_HL_TIME=decimal.Parse(row["N_HL_TIME"].ToString());
				}
				if(row["D_PLAN_DATE"]!=null && row["D_PLAN_DATE"].ToString()!="")
				{
					model.D_PLAN_DATE=DateTime.Parse(row["D_PLAN_DATE"].ToString());
				}
				if(row["C_HLYQ"]!=null)
				{
					model.C_HLYQ=row["C_HLYQ"].ToString();
				}
				if(row["C_REMARK"]!=null)
				{
					model.C_REMARK=row["C_REMARK"].ToString();
				}
				if(row["N_STATUS"]!=null && row["N_STATUS"].ToString()!="")
				{
					model.N_STATUS=decimal.Parse(row["N_STATUS"].ToString());
				}
				if(row["C_CCM"]!=null)
				{
					model.C_CCM=row["C_CCM"].ToString();
				}
				if(row["N_QUA"]!=null && row["N_QUA"].ToString()!="")
				{
					model.N_QUA=decimal.Parse(row["N_QUA"].ToString());
				}
				if(row["N_CAP"]!=null && row["N_CAP"].ToString()!="")
				{
					model.N_CAP=decimal.Parse(row["N_CAP"].ToString());
				}
				if(row["N_TOTAL_QUA"]!=null && row["N_TOTAL_QUA"].ToString()!="")
				{
					model.N_TOTAL_QUA=decimal.Parse(row["N_TOTAL_QUA"].ToString());
				}
				if(row["D_START_TIME_SJ"]!=null && row["D_START_TIME_SJ"].ToString()!="")
				{
					model.D_START_TIME_SJ=DateTime.Parse(row["D_START_TIME_SJ"].ToString());
				}
				if(row["D_END_TIME_SJ"]!=null && row["D_END_TIME_SJ"].ToString()!="")
				{
					model.D_END_TIME_SJ=DateTime.Parse(row["D_END_TIME_SJ"].ToString());
				}
				if(row["N_QUA_SJ"]!=null && row["N_QUA_SJ"].ToString()!="")
				{
					model.N_QUA_SJ=decimal.Parse(row["N_QUA_SJ"].ToString());
				}
				if(row["C_WH_CODE_SJ"]!=null)
				{
					model.C_WH_CODE_SJ=row["C_WH_CODE_SJ"].ToString();
				}
				if(row["D_OVER_TIME"]!=null && row["D_OVER_TIME"].ToString()!="")
				{
					model.D_OVER_TIME=DateTime.Parse(row["D_OVER_TIME"].ToString());
				}
				if(row["N_NUM"]!=null && row["N_NUM"].ToString()!="")
				{
					model.N_NUM=decimal.Parse(row["N_NUM"].ToString());
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
			strSql.Append("select C_ID,C_FK,C_STOVE_NO,C_STL_GRD,C_STD_CODE,C_WH_CODE,C_SLAB_TYPE,D_START_TIME,D_END_TIME,N_HL_TIME,D_PLAN_DATE,C_HLYQ,C_REMARK,N_STATUS,C_CCM,N_QUA,N_CAP,N_TOTAL_QUA,D_START_TIME_SJ,D_END_TIME_SJ,N_QUA_SJ,C_WH_CODE_SJ,D_OVER_TIME,N_NUM ");
			strSql.Append(" FROM TPA_HL_PLAN ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where 1=1 "+strWhere);
			}
			return DbHelperOra.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM TPA_HL_PLAN ");
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
			strSql.Append(")AS Row, T.*  from TPA_HL_PLAN T ");
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
					new OracleParameter(":PageSize", OracleDbType.Decimal),
					new OracleParameter(":PageIndex", OracleDbType.Decimal),
					new OracleParameter(":IsReCount", OracleDbType.Clob),
					new OracleParameter(":OrderType", OracleDbType.Clob),
					new OracleParameter(":strWhere", OracleDbType.Varchar2,1000),
					};
			parameters[0].Value = "TPA_HL_PLAN";
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

