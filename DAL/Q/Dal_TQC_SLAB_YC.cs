﻿using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;
namespace DAL
{
    /// <summary>
    /// 数据访问类:TQC_SLAB_YC
    /// </summary>
    public partial class Dal_TQC_SLAB_YC
	{
		public Dal_TQC_SLAB_YC()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string C_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from TQC_SLAB_YC");
			strSql.Append(" where C_ID=:C_ID ");
			OracleParameter[] parameters = {
					new OracleParameter(":C_ID", OracleDbType.Varchar2,100)			};
			parameters[0].Value = C_ID;

			return DbHelperOra.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Mod_TQC_SLAB_YC model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into TQC_SLAB_YC(");
			strSql.Append("C_ID,C_STOVE,C_STL_GRD,C_STD_CODE,C_MAT_CODE,C_MAT_NAME,C_SPEC,N_LEN,C_REASON,N_STATUS,C_EMP_ID,D_MOD_DT,C_REMARK)");
			strSql.Append(" values (");
			strSql.Append(":C_ID,:C_STOVE,:C_STL_GRD,:C_STD_CODE,:C_MAT_CODE,:C_MAT_NAME,:C_SPEC,:N_LEN,:C_REASON,:N_STATUS,:C_EMP_ID,:D_MOD_DT,:C_REMARK)");
			OracleParameter[] parameters = {
					new OracleParameter(":C_ID", OracleDbType.Varchar2,100),
					new OracleParameter(":C_STOVE", OracleDbType.Varchar2,100),
					new OracleParameter(":C_STL_GRD", OracleDbType.Varchar2,100),
					new OracleParameter(":C_STD_CODE", OracleDbType.Varchar2,100),
					new OracleParameter(":C_MAT_CODE", OracleDbType.Varchar2,100),
					new OracleParameter(":C_MAT_NAME", OracleDbType.Varchar2,100),
					new OracleParameter(":C_SPEC", OracleDbType.Varchar2,100),
					new OracleParameter(":N_LEN", OracleDbType.Decimal,15),
					new OracleParameter(":C_REASON", OracleDbType.Varchar2,100),
					new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
					new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
					new OracleParameter(":D_MOD_DT", OracleDbType.Date),
					new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500)};
			parameters[0].Value = model.C_ID;
			parameters[1].Value = model.C_STOVE;
			parameters[2].Value = model.C_STL_GRD;
			parameters[3].Value = model.C_STD_CODE;
			parameters[4].Value = model.C_MAT_CODE;
			parameters[5].Value = model.C_MAT_NAME;
			parameters[6].Value = model.C_SPEC;
			parameters[7].Value = model.N_LEN;
			parameters[8].Value = model.C_REASON;
			parameters[9].Value = model.N_STATUS;
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
		/// 更新一条数据
		/// </summary>
		public bool Update(Mod_TQC_SLAB_YC model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update TQC_SLAB_YC set ");
			strSql.Append("C_STOVE=:C_STOVE,");
			strSql.Append("C_STL_GRD=:C_STL_GRD,");
			strSql.Append("C_STD_CODE=:C_STD_CODE,");
			strSql.Append("C_MAT_CODE=:C_MAT_CODE,");
			strSql.Append("C_MAT_NAME=:C_MAT_NAME,");
			strSql.Append("C_SPEC=:C_SPEC,");
			strSql.Append("N_LEN=:N_LEN,");
			strSql.Append("C_REASON=:C_REASON,");
			strSql.Append("N_STATUS=:N_STATUS,");
			strSql.Append("C_EMP_ID=:C_EMP_ID,");
			strSql.Append("D_MOD_DT=:D_MOD_DT,");
			strSql.Append("C_REMARK=:C_REMARK");
			strSql.Append(" where C_ID=:C_ID ");
			OracleParameter[] parameters = {
					new OracleParameter(":C_STOVE", OracleDbType.Varchar2,100),
					new OracleParameter(":C_STL_GRD", OracleDbType.Varchar2,100),
					new OracleParameter(":C_STD_CODE", OracleDbType.Varchar2,100),
					new OracleParameter(":C_MAT_CODE", OracleDbType.Varchar2,100),
					new OracleParameter(":C_MAT_NAME", OracleDbType.Varchar2,100),
					new OracleParameter(":C_SPEC", OracleDbType.Varchar2,100),
					new OracleParameter(":N_LEN", OracleDbType.Decimal,15),
					new OracleParameter(":C_REASON", OracleDbType.Varchar2,100),
					new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
					new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
					new OracleParameter(":D_MOD_DT", OracleDbType.Date),
					new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
					new OracleParameter(":C_ID", OracleDbType.Varchar2,100)};
			parameters[0].Value = model.C_STOVE;
			parameters[1].Value = model.C_STL_GRD;
			parameters[2].Value = model.C_STD_CODE;
			parameters[3].Value = model.C_MAT_CODE;
			parameters[4].Value = model.C_MAT_NAME;
			parameters[5].Value = model.C_SPEC;
			parameters[6].Value = model.N_LEN;
			parameters[7].Value = model.C_REASON;
			parameters[8].Value = model.N_STATUS;
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
			strSql.Append("delete from TQC_SLAB_YC ");
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
			strSql.Append("delete from TQC_SLAB_YC ");
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
		public Mod_TQC_SLAB_YC GetModel(string C_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select C_ID,C_STOVE,C_STL_GRD,C_STD_CODE,C_MAT_CODE,C_MAT_NAME,C_SPEC,N_LEN,C_REASON,N_STATUS,C_EMP_ID,D_MOD_DT,C_REMARK from TQC_SLAB_YC ");
			strSql.Append(" where C_ID=:C_ID ");
			OracleParameter[] parameters = {
					new OracleParameter(":C_ID", OracleDbType.Varchar2,100)			};
			parameters[0].Value = C_ID;

			Mod_TQC_SLAB_YC model=new Mod_TQC_SLAB_YC();
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
		public Mod_TQC_SLAB_YC DataRowToModel(DataRow row)
		{
			Mod_TQC_SLAB_YC model=new Mod_TQC_SLAB_YC();
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
				if(row["C_STL_GRD"]!=null)
				{
					model.C_STL_GRD=row["C_STL_GRD"].ToString();
				}
				if(row["C_STD_CODE"]!=null)
				{
					model.C_STD_CODE=row["C_STD_CODE"].ToString();
				}
				if(row["C_MAT_CODE"]!=null)
				{
					model.C_MAT_CODE=row["C_MAT_CODE"].ToString();
				}
				if(row["C_MAT_NAME"]!=null)
				{
					model.C_MAT_NAME=row["C_MAT_NAME"].ToString();
				}
				if(row["C_SPEC"]!=null)
				{
					model.C_SPEC=row["C_SPEC"].ToString();
				} 
                if (row["N_LEN"] != null && row["N_LEN"].ToString() != "")
                {
                    model.N_LEN = decimal.Parse(row["N_LEN"].ToString());
                }
                if (row["C_REASON"]!=null)
				{
					model.C_REASON=row["C_REASON"].ToString();
				}
				if(row["N_STATUS"]!=null && row["N_STATUS"].ToString()!="")
				{
					model.N_STATUS=decimal.Parse(row["N_STATUS"].ToString());
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
			strSql.Append("select C_ID,C_STOVE,C_STL_GRD,C_STD_CODE,C_MAT_CODE,C_MAT_NAME,C_SPEC,N_LEN,C_REASON,N_STATUS,C_EMP_ID,D_MOD_DT,C_REMARK ");
			strSql.Append(" FROM TQC_SLAB_YC ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperOra.Query(strSql.ToString());
		}

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList_SlabYC(string stove)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_STOVE,C_STL_GRD,C_STD_CODE,C_MAT_CODE,C_MAT_NAME,C_SPEC,N_LEN,C_REASON,N_STATUS,C_EMP_ID,D_MOD_DT,C_REMARK ");
            strSql.Append(" FROM TQC_SLAB_YC WHERE N_STATUS=1 ");
            if (stove.Trim() != "")
            {
                strSql.Append(" AND C_STOVE ='"+ stove + "' ");
            }

            strSql.Append(" order by D_MOD_DT desc ");

            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM TQC_SLAB_YC ");
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
			strSql.Append(")AS Row, T.*  from TQC_SLAB_YC T ");
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
			parameters[0].Value = "TQC_SLAB_YC";
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

