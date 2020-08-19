using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;
namespace DAL
{
    /// <summary>
    /// 数据访问类:TPO_XCKWT_LAB
    /// </summary>
    public partial class Dal_TPO_XCKWT_LAB
    {
		public Dal_TPO_XCKWT_LAB()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string C_LOC_CODE)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from TPO_XCKWT_LAB");
			strSql.Append(" where C_LOC_CODE=:C_LOC_CODE ");
			OracleParameter[] parameters = {
					new OracleParameter(":C_LOC_CODE", OracleDbType.Varchar2,100)			};
			parameters[0].Value = C_LOC_CODE;

			return DbHelperOra.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Mod_TPO_XCKWT_LAB model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into TPO_XCKWT_LAB(");
			strSql.Append("C_CODE,C_AREA_CODE,C_LOC_CODE,C_TIER_CODE,C_X_WIRE,C_Y_WIRE,C_LAB_HEIGHT,C_LAB_WIDTH,C_COUNT,C_REMARK,C_EMP_ID,D_MOD_DT)");
			strSql.Append(" values (");
			strSql.Append(":C_CODE,:C_AREA_CODE,:C_LOC_CODE,:C_TIER_CODE,:C_X_WIRE,:C_Y_WIRE,:C_LAB_HEIGHT,:C_LAB_WIDTH,:C_COUNT,:C_REMARK,:C_EMP_ID,:D_MOD_DT)");
			OracleParameter[] parameters = {
					new OracleParameter(":C_CODE", OracleDbType.Varchar2,100),
					new OracleParameter(":C_AREA_CODE", OracleDbType.Varchar2,100),
					new OracleParameter(":C_LOC_CODE", OracleDbType.Varchar2,100),
					new OracleParameter(":C_TIER_CODE", OracleDbType.Varchar2,100),
					new OracleParameter(":C_X_WIRE", OracleDbType.Varchar2,100),
					new OracleParameter(":C_Y_WIRE", OracleDbType.Varchar2,100),
					new OracleParameter(":C_LAB_HEIGHT", OracleDbType.Varchar2,100),
					new OracleParameter(":C_LAB_WIDTH", OracleDbType.Varchar2,100),
					new OracleParameter(":C_COUNT", OracleDbType.Varchar2,100),
					new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
					new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
					new OracleParameter(":D_MOD_DT", OracleDbType.Date)};
			parameters[0].Value = model.C_CODE;
			parameters[1].Value = model.C_AREA_CODE;
			parameters[2].Value = model.C_LOC_CODE;
			parameters[3].Value = model.C_TIER_CODE;
			parameters[4].Value = model.C_X_WIRE;
			parameters[5].Value = model.C_Y_WIRE;
			parameters[6].Value = model.C_LAB_HEIGHT;
			parameters[7].Value = model.C_LAB_WIDTH;
			parameters[8].Value = model.C_COUNT;
			parameters[9].Value = model.C_REMARK;
			parameters[10].Value = model.C_EMP_ID;
			parameters[11].Value = model.D_MOD_DT;

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
		public bool Update(Mod_TPO_XCKWT_LAB model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update TPO_XCKWT_LAB set ");
			strSql.Append("C_CODE=:C_CODE,");
			strSql.Append("C_AREA_CODE=:C_AREA_CODE,");
			 
			strSql.Append("C_TIER_CODE=:C_TIER_CODE,");
			strSql.Append("C_X_WIRE=:C_X_WIRE,");
			strSql.Append("C_Y_WIRE=:C_Y_WIRE,");
			strSql.Append("C_LAB_HEIGHT=:C_LAB_HEIGHT,");
			strSql.Append("C_LAB_WIDTH=:C_LAB_WIDTH,");
			strSql.Append("C_COUNT=:C_COUNT,");
			strSql.Append("C_REMARK=:C_REMARK,");
			strSql.Append("C_EMP_ID=:C_EMP_ID,");
			strSql.Append("D_MOD_DT=:D_MOD_DT");
			strSql.Append(" where C_LOC_CODE=:C_LOC_CODE ");
			OracleParameter[] parameters = {
					new OracleParameter(":C_CODE", OracleDbType.Varchar2,100),
					new OracleParameter(":C_AREA_CODE", OracleDbType.Varchar2,100),
					 
					new OracleParameter(":C_TIER_CODE", OracleDbType.Varchar2,100),
					new OracleParameter(":C_X_WIRE", OracleDbType.Varchar2,100),
					new OracleParameter(":C_Y_WIRE", OracleDbType.Varchar2,100),
					new OracleParameter(":C_LAB_HEIGHT", OracleDbType.Varchar2,100),
					new OracleParameter(":C_LAB_WIDTH", OracleDbType.Varchar2,100),
					new OracleParameter(":C_COUNT", OracleDbType.Varchar2,100),
					new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
					new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
					new OracleParameter(":D_MOD_DT", OracleDbType.Date),
					new OracleParameter(":C_LOC_CODE", OracleDbType.Varchar2,100)};
			parameters[0].Value = model.C_CODE;
			parameters[1].Value = model.C_AREA_CODE;		 
			parameters[2].Value = model.C_TIER_CODE;
			parameters[3].Value = model.C_X_WIRE;
			parameters[4].Value = model.C_Y_WIRE;
			parameters[5].Value = model.C_LAB_HEIGHT;
			parameters[6].Value = model.C_LAB_WIDTH;
			parameters[7].Value = model.C_COUNT;
			parameters[8].Value = model.C_REMARK;
			parameters[9].Value = model.C_EMP_ID;
			parameters[10].Value = model.D_MOD_DT;
			parameters[11].Value = model.C_LOC_CODE;

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
		public bool Delete(string C_LOC_CODE)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from TPO_XCKWT_LAB ");
			strSql.Append(" where C_LOC_CODE=:C_LOC_CODE ");
			OracleParameter[] parameters = {
					new OracleParameter(":C_LOC_CODE", OracleDbType.Varchar2,100)			};
			parameters[0].Value = C_LOC_CODE;

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
			strSql.Append("delete from TPO_XCKWT_LAB ");
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
		public Mod_TPO_XCKWT_LAB GetModel(string C_LOC_CODE)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select C_ID,C_CODE,C_AREA_CODE,C_LOC_CODE,C_TIER_CODE,C_X_WIRE,C_Y_WIRE,C_LAB_HEIGHT,C_LAB_WIDTH,C_COUNT,C_REMARK,C_EMP_ID,D_MOD_DT from TPO_XCKWT_LAB ");
			strSql.Append(" where C_LOC_CODE=:C_LOC_CODE ");
			OracleParameter[] parameters = {
					new OracleParameter(":C_LOC_CODE", OracleDbType.Varchar2,100)			};
			parameters[0].Value = C_LOC_CODE;

			Mod_TPO_XCKWT_LAB model=new Mod_TPO_XCKWT_LAB();
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
		public Mod_TPO_XCKWT_LAB DataRowToModel(DataRow row)
		{
			Mod_TPO_XCKWT_LAB model=new Mod_TPO_XCKWT_LAB();
			if (row != null)
			{
				if(row["C_ID"]!=null)
				{
					model.C_ID=row["C_ID"].ToString();
				}
				if(row["C_CODE"]!=null)
				{
					model.C_CODE=row["C_CODE"].ToString();
				}
				if(row["C_AREA_CODE"]!=null)
				{
					model.C_AREA_CODE=row["C_AREA_CODE"].ToString();
				}
				if(row["C_LOC_CODE"]!=null)
				{
					model.C_LOC_CODE=row["C_LOC_CODE"].ToString();
				}
				if(row["C_TIER_CODE"]!=null)
				{
					model.C_TIER_CODE=row["C_TIER_CODE"].ToString();
				}
				if(row["C_X_WIRE"]!=null)
				{
					model.C_X_WIRE=row["C_X_WIRE"].ToString();
				}
				if(row["C_Y_WIRE"]!=null)
				{
					model.C_Y_WIRE=row["C_Y_WIRE"].ToString();
				}
				if(row["C_LAB_HEIGHT"]!=null)
				{
					model.C_LAB_HEIGHT=row["C_LAB_HEIGHT"].ToString();
				}
				if(row["C_LAB_WIDTH"]!=null)
				{
					model.C_LAB_WIDTH=row["C_LAB_WIDTH"].ToString();
				}
				if(row["C_COUNT"]!=null)
				{
					model.C_COUNT=row["C_COUNT"].ToString();
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
			strSql.Append("select C_ID,C_CODE,C_AREA_CODE,C_LOC_CODE,C_TIER_CODE,C_X_WIRE,C_Y_WIRE,C_LAB_HEIGHT,C_LAB_WIDTH,C_COUNT,C_REMARK,C_EMP_ID,D_MOD_DT ");
			strSql.Append(" FROM TPO_XCKWT_LAB ");
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
			strSql.Append("select count(1) FROM TPO_XCKWT_LAB ");
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
			strSql.Append(")AS Row, T.*  from TPO_XCKWT_LAB T ");
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
			parameters[0].Value = "TPO_XCKWT_LAB";
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
        public DataSet GetList_ID(string c_code,string c_area_code)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_CODE,C_AREA_CODE,C_LOC_CODE,C_TIER_CODE,C_X_WIRE,C_Y_WIRE,C_LAB_HEIGHT,C_LAB_WIDTH,C_COUNT,C_REMARK,C_EMP_ID,D_MOD_DT ");
            strSql.Append(" FROM TPO_XCKWT_LAB where 1=1 ");
            if (c_code.Trim() != "")
            {
                strSql.Append(" and c_code='" + c_code + "' ");
            }

            if (c_area_code.Trim() != "")
            {
                strSql.Append(" and c_area_code='" + c_area_code + "' ");
            }
            return DbHelperOra.Query(strSql.ToString());
        }
        #endregion  ExtensionMethod
    }
}

