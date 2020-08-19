using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;
namespace DAL
{
	/// <summary>
	/// 数据访问类:TQB_SLAB_LEN
	/// </summary>
	public partial class Dal_TQB_SLAB_LEN
    {
		public Dal_TQB_SLAB_LEN()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string C_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql  .Append("select count(1) from TQB_SLAB_LEN");
			strSql.Append(" where C_ID=:C_ID ");
			OracleParameter[] parameters = {
					new OracleParameter(":C_ID", OracleDbType.Varchar2,100)			};
			parameters[0].Value = C_ID;

			return DbHelperOra.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Mod_TQB_SLAB_LEN model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into TQB_SLAB_LEN(");
			strSql.Append("C_SLAB_SIZE,C_TYPE,C_HOT_LEN,C_COLD_LEN,C_THE_WEIGHT,N_STATUS,C_REMARK,C_EMP_ID)");
			strSql.Append(" values (");
			strSql.Append(":C_SLAB_SIZE,:C_TYPE,:C_HOT_LEN,:C_COLD_LEN,:C_THE_WEIGHT,:N_STATUS,:C_REMARK,:C_EMP_ID)");
			OracleParameter[] parameters = {
					new OracleParameter(":C_SLAB_SIZE", OracleDbType.Varchar2,100),
					new OracleParameter(":C_TYPE", OracleDbType.Varchar2,100),
					new OracleParameter(":C_HOT_LEN", OracleDbType.Varchar2,100),
					new OracleParameter(":C_COLD_LEN", OracleDbType.Varchar2,100),
					new OracleParameter(":C_THE_WEIGHT", OracleDbType.Varchar2,100),
					new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
					new OracleParameter(":C_REMARK", OracleDbType.Varchar2,200),
					new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100)};
			parameters[0].Value = model.C_SLAB_SIZE;
			parameters[1].Value = model.C_TYPE;
			parameters[2].Value = model.C_HOT_LEN;
			parameters[3].Value = model.C_COLD_LEN;
			parameters[4].Value = model.C_THE_WEIGHT;
			parameters[5].Value = model.N_STATUS;
			parameters[6].Value = model.C_REMARK;
			parameters[7].Value = model.C_EMP_ID;

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
		public bool Update(Mod_TQB_SLAB_LEN model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update TQB_SLAB_LEN set ");
			strSql.Append("C_SLAB_SIZE=:C_SLAB_SIZE,");
			strSql.Append("C_TYPE=:C_TYPE,");
			strSql.Append("C_HOT_LEN=:C_HOT_LEN,");
			strSql.Append("C_COLD_LEN=:C_COLD_LEN,");
			strSql.Append("C_THE_WEIGHT=:C_THE_WEIGHT,");
			strSql.Append("N_STATUS=:N_STATUS,");
			strSql.Append("C_REMARK=:C_REMARK,");
			strSql.Append("C_EMP_ID=:C_EMP_ID,");
			strSql.Append("D_MOD_DT=:D_MOD_DT");
			strSql.Append(" where C_ID=:C_ID ");
			OracleParameter[] parameters = {
					new OracleParameter(":C_SLAB_SIZE", OracleDbType.Varchar2,100),
					new OracleParameter(":C_TYPE", OracleDbType.Varchar2,100),
					new OracleParameter(":C_HOT_LEN", OracleDbType.Varchar2,100),
					new OracleParameter(":C_COLD_LEN", OracleDbType.Varchar2,100),
					new OracleParameter(":C_THE_WEIGHT", OracleDbType.Varchar2,100),
					new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
					new OracleParameter(":C_REMARK", OracleDbType.Varchar2,200),
					new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
					new OracleParameter(":D_MOD_DT", OracleDbType.Date),
					new OracleParameter(":C_ID", OracleDbType.Varchar2,100)};
			parameters[0].Value = model.C_SLAB_SIZE;
			parameters[1].Value = model.C_TYPE;
			parameters[2].Value = model.C_HOT_LEN;
			parameters[3].Value = model.C_COLD_LEN;
			parameters[4].Value = model.C_THE_WEIGHT;
			parameters[5].Value = model.N_STATUS;
			parameters[6].Value = model.C_REMARK;
			parameters[7].Value = model.C_EMP_ID;
			parameters[8].Value = model.D_MOD_DT;
			parameters[9].Value = model.C_ID;

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
			strSql.Append("delete from TQB_SLAB_LEN ");
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
			strSql.Append("delete from TQB_SLAB_LEN ");
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
		public Mod_TQB_SLAB_LEN GetModel(string C_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select C_ID,C_SLAB_SIZE,C_TYPE,C_HOT_LEN,C_COLD_LEN,C_THE_WEIGHT,N_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT from TQB_SLAB_LEN ");
			strSql.Append(" where C_ID=:C_ID ");
			OracleParameter[] parameters = {
					new OracleParameter(":C_ID", OracleDbType.Varchar2,100)			};
			parameters[0].Value = C_ID;

			Mod_TQB_SLAB_LEN model=new Mod_TQB_SLAB_LEN();
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
		public Mod_TQB_SLAB_LEN DataRowToModel(DataRow row)
		{
			Mod_TQB_SLAB_LEN model=new Mod_TQB_SLAB_LEN();
			if (row != null)
			{
				if(row["C_ID"]!=null)
				{
					model.C_ID=row["C_ID"].ToString();
				}
				if(row["C_SLAB_SIZE"]!=null)
				{
					model.C_SLAB_SIZE=row["C_SLAB_SIZE"].ToString();
				}
				if(row["C_TYPE"]!=null)
				{
					model.C_TYPE=row["C_TYPE"].ToString();
				}
				if(row["C_HOT_LEN"]!=null)
				{
					model.C_HOT_LEN=row["C_HOT_LEN"].ToString();
				}
				if(row["C_COLD_LEN"]!=null)
				{
					model.C_COLD_LEN=row["C_COLD_LEN"].ToString();
				}
				if(row["C_THE_WEIGHT"]!=null)
				{
					model.C_THE_WEIGHT=row["C_THE_WEIGHT"].ToString();
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
			strSql.Append("select C_ID,C_SLAB_SIZE,C_TYPE,C_HOT_LEN,C_COLD_LEN,C_THE_WEIGHT,N_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT ");
			strSql.Append(" FROM TQB_SLAB_LEN where N_STATUS=1 ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" and C_TYPE like '%"+ strWhere + "%'  " );
			}
            strSql.Append(" order by C_SLAB_SIZE ");
            return DbHelperOra.Query(strSql.ToString());
		}

        /// <summary>
        /// 获得数据列表
        /// </summary>
        /// <param name="C_STD_ID">执行标准主键</param>
        /// <param name="stl">钢种</param>
        /// <returns></returns>
        public DataSet GetSLabNoMatch_Cold(string C_STD_ID,string stl, string size)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" SELECT q.c_mat_code, A.C_ID, A.C_SLAB_SIZE,  A.C_TYPE, A.C_HOT_LEN,  A.C_COLD_LEN,  A.C_THE_WEIGHT, A.N_STATUS, A.C_REMARK, A.C_EMP_ID,  A.D_MOD_DT FROM TQB_SLAB_LEN A LEFT JOIN (select tt.c_mat_code, tt.n_lth, tt.c_slab_size  from tB_MATRL_MAIN tt  where tt.c_mat_type = 6  and tt.c_stl_grd = '"+ stl + "') Q  on a.c_cold_len = q.n_lth and a.c_slab_size = q.c_slab_size WHERE A.N_STATUS = 1 ");
             
            if (!string.IsNullOrEmpty(size))
            {
                strSql.Append(" and A.C_SLAB_SIZE like '%" + size + "%' ");
            }
            strSql.Append(" order by a.c_type desc,a.c_slab_size asc ");
            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 获得数据列表
        /// </summary> 
        /// <param name="stl">钢种</param>
        /// <param name="size">规格</param>
        /// <returns></returns>
        public DataSet GetSLabNoMatch613( string stl, string size,string std)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT TT.*, TM.*  FROM (SELECT T.C_STL_GRD,  T.C_STD_CODE, T.C_ROUTE_DESC, (CASE  WHEN T.C_ROUTE_DESC LIKE '%KP%' OR T.C_ROUTE_DESC LIKE '%DHL%' THEN  CASE   WHEN T.C_ROUTE_DESC LIKE '%ZL>LF>CC%' THEN  '(BL)'  WHEN T.C_ROUTE_DESC LIKE '%ZL>LF>RH>CC%' THEN   '(BLR)'  WHEN T.C_ROUTE_DESC LIKE '%ZL>RH>CC%' THEN    '(BR)'   ELSE  ''   END   ELSE  ''  END) KP  FROM TQB_ROUTE T  WHERE T.N_STATUS = 1   AND T.C_IS_BXG = '0' GROUP BY T.C_STL_GRD, T.C_STD_CODE, T.C_ROUTE_DESC) TT  LEFT JOIN (SELECT T1.C_ID,  T1.C_STL_GRD,   T1.C_MAT_NAME, T1.N_LTH, T1.C_SLAB_SIZE, T1.N_HSL  FROM TB_MATRL_MAIN T1 WHERE T1.C_MAT_TYPE = '6') TM  ON TM.C_STL_GRD = TT.C_STL_GRD  AND TM.C_MAT_NAME LIKE '%' || TT.KP || '%'  ");
            strSql.Append("  WHERE TT.C_STL_GRD = '"+stl+ "' AND tm.c_id LIKE  '613%'  and TT.C_STD_CODE='"+std+"'  ");
            if (!string.IsNullOrEmpty(size))
            {
                strSql.Append(" and  tm.c_slab_size LIKE '%" + size + "%' ");
            }
            strSql.Append(" UNION ");
            strSql.Append("SELECT TT.*, TM.*  FROM (SELECT T.C_STL_GRD,  T.C_STD_CODE, T.C_ROUTE_DESC, (CASE  WHEN T.C_ROUTE_DESC LIKE '%KP%' OR T.C_ROUTE_DESC LIKE '%DHL%' THEN  CASE   WHEN T.C_ROUTE_DESC LIKE '%ZL>LF>CC%' THEN  '(BL)'  WHEN T.C_ROUTE_DESC LIKE '%ZL>LF>RH>CC%' THEN   '(BLR)'  WHEN T.C_ROUTE_DESC LIKE '%ZL>RH>CC%' THEN    '(BR)'   ELSE  ''   END   ELSE  ''  END) KP  FROM TQB_ROUTE T  WHERE T.N_STATUS = 1   AND T.C_IS_BXG = '0' GROUP BY T.C_STL_GRD, T.C_STD_CODE, T.C_ROUTE_DESC) TT  LEFT JOIN (SELECT T1.C_ID,  T1.C_STL_GRD,   T1.C_MAT_NAME, T1.N_LTH, T1.C_SLAB_SIZE, T1.N_HSL  FROM TB_MATRL_MAIN T1 WHERE T1.C_MAT_TYPE = '6') TM  ON TM.C_STL_GRD = TT.C_STL_GRD  AND TM.C_MAT_NAME LIKE '%' || TT.KP || '%'  ");
            strSql.Append("  WHERE TT.C_STL_GRD = '"+stl+ "' AND tm.c_id LIKE  '614%'   and TT.C_STD_CODE='" + std + "' "); 
            if (!string.IsNullOrEmpty(size))
            {
                strSql.Append(" and  tm.c_slab_size LIKE '%" + size + "%' ");
            } 
            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 获得数据列表
        /// </summary> 
        /// <param name="stl">钢种</param>
        /// <param name="size">规格</param>
        /// <returns></returns>
        public DataSet GetSLabNoMatch611(string stl, string size,string std)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT TT.*, TM.*  FROM (SELECT T.C_STL_GRD,  T.C_STD_CODE, T.C_ROUTE_DESC, (CASE  WHEN T.C_ROUTE_DESC LIKE '%KP%' OR T.C_ROUTE_DESC LIKE '%DHL%' THEN  CASE   WHEN T.C_ROUTE_DESC LIKE '%ZL>LF>CC%' THEN  '(BL)'  WHEN T.C_ROUTE_DESC LIKE '%ZL>LF>RH>CC%' THEN   '(BLR)'  WHEN T.C_ROUTE_DESC LIKE '%ZL>RH>CC%' THEN    '(BR)'   ELSE  ''   END   ELSE  ''  END) KP  FROM TQB_ROUTE T  WHERE T.N_STATUS = 1   AND T.C_IS_BXG = '0' GROUP BY T.C_STL_GRD, T.C_STD_CODE, T.C_ROUTE_DESC) TT  LEFT JOIN (SELECT T1.C_ID,  T1.C_STL_GRD,   T1.C_MAT_NAME, T1.N_LTH, T1.C_SLAB_SIZE, T1.N_HSL  FROM TB_MATRL_MAIN T1 WHERE T1.C_MAT_TYPE = '6') TM  ON TM.C_STL_GRD = TT.C_STL_GRD  AND TM.C_MAT_NAME LIKE '%' || TT.KP || '%'  ");
            strSql.Append("  WHERE TT.C_STL_GRD = '" + stl + "' AND tm.c_id LIKE  '611%'    and TT.C_STD_CODE='" + std + "'  UNION ");
            if (!string.IsNullOrEmpty(size))
            {
                strSql.Append(" and  tm.c_slab_size LIKE '%" + size + "%' ");
            }
            strSql.Append("SELECT TT.*, TM.*  FROM (SELECT T.C_STL_GRD,  T.C_STD_CODE, T.C_ROUTE_DESC, (CASE  WHEN T.C_ROUTE_DESC LIKE '%KP%' OR T.C_ROUTE_DESC LIKE '%DHL%' THEN  CASE   WHEN T.C_ROUTE_DESC LIKE '%ZL>LF>CC%' THEN  '(BL)'  WHEN T.C_ROUTE_DESC LIKE '%ZL>LF>RH>CC%' THEN   '(BLR)'  WHEN T.C_ROUTE_DESC LIKE '%ZL>RH>CC%' THEN    '(BR)'   ELSE  ''   END   ELSE  ''  END) KP  FROM TQB_ROUTE T  WHERE T.N_STATUS = 1   AND T.C_IS_BXG = '0' GROUP BY T.C_STL_GRD, T.C_STD_CODE, T.C_ROUTE_DESC) TT  LEFT JOIN (SELECT T1.C_ID,  T1.C_STL_GRD,   T1.C_MAT_NAME, T1.N_LTH, T1.C_SLAB_SIZE, T1.N_HSL  FROM TB_MATRL_MAIN T1 WHERE T1.C_MAT_TYPE = '6') TM  ON TM.C_STL_GRD = TT.C_STL_GRD  AND TM.C_MAT_NAME LIKE '%' || TT.KP || '%'  ");
            strSql.Append("  WHERE TT.C_STL_GRD = '" + stl + "' AND tm.c_id LIKE  '612%'  and TT.C_STD_CODE='" + std + "'  ");
            if (!string.IsNullOrEmpty(size))
            {
                strSql.Append(" and  tm.c_slab_size LIKE '%" + size + "%' ");
            }
            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 获得数据列表
        /// </summary> 
        /// <param name="stl">钢种</param>
        /// <param name="size">规格</param>
        /// <returns></returns>
        public DataSet GetSLabNoMatch611_BXG(string stl, string size, string std)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT TT.*, TM.*  FROM (SELECT T.C_STL_GRD,  T.C_STD_CODE,  T.C_ROUTE_DESC   FROM TQB_ROUTE T  WHERE T.N_STATUS = 1  AND T.C_IS_BXG = '1'  GROUP BY T.C_STL_GRD, T.C_STD_CODE, T.C_ROUTE_DESC) TT  LEFT JOIN (SELECT T1.C_ID, T1.C_STL_GRD, T1.C_MAT_NAME,  T1.N_LTH,  T1.C_SLAB_SIZE, T1.N_HSL FROM TB_MATRL_MAIN T1 WHERE T1.C_MAT_TYPE = '6') TM ON TM.C_STL_GRD = TT.C_STL_GRD  ");
            strSql.Append("  WHERE TT.C_STL_GRD = '" + stl + "' AND tm.c_id LIKE  '611%'  and TT.C_STD_CODE='" + std + "'  UNION ");
            if (!string.IsNullOrEmpty(size))
            {
                strSql.Append(" and  tm.c_slab_size LIKE '%" + size + "%' ");
            }
            strSql.Append("SELECT TT.*, TM.*  FROM (SELECT T.C_STL_GRD,  T.C_STD_CODE,  T.C_ROUTE_DESC   FROM TQB_ROUTE T  WHERE T.N_STATUS = 1  AND T.C_IS_BXG = '1'  GROUP BY T.C_STL_GRD, T.C_STD_CODE, T.C_ROUTE_DESC) TT  LEFT JOIN (SELECT T1.C_ID, T1.C_STL_GRD, T1.C_MAT_NAME,  T1.N_LTH,  T1.C_SLAB_SIZE, T1.N_HSL FROM TB_MATRL_MAIN T1 WHERE T1.C_MAT_TYPE = '6') TM ON TM.C_STL_GRD = TT.C_STL_GRD ");
            strSql.Append("  WHERE TT.C_STL_GRD = '" + stl + "' AND tm.c_id LIKE  '612%'  and TT.C_STD_CODE='" + std + "'  ");
            if (!string.IsNullOrEmpty(size))
            {
                strSql.Append(" and  tm.c_slab_size LIKE '%" + size + "%' ");
            }
            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        /// <param name="C_STD_ID">执行标准主键</param>
        /// <param name="stl">钢种</param>
        /// <returns></returns>
        public DataSet GetSLabNoMatch_Hot(string C_STD_ID, string stl,string size)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" SELECT q.c_mat_code, A.C_ID, A.C_SLAB_SIZE,  A.C_TYPE, A.C_HOT_LEN,  A.C_COLD_LEN,  A.C_THE_WEIGHT, A.N_STATUS, A.C_REMARK, A.C_EMP_ID,  A.D_MOD_DT FROM TQB_SLAB_LEN A LEFT JOIN (select tt.c_mat_code, tt.n_lth, tt.c_slab_size  from tB_MATRL_MAIN tt  where tt.c_mat_type = 6  and tt.c_stl_grd = '"+ stl + "') Q  on a.c_hot_len = q.n_lth and a.c_slab_size = q.c_slab_size WHERE A.N_STATUS = 1 "); 
             
            if (!string.IsNullOrEmpty(size))
            {
                strSql.Append(" and A.C_SLAB_SIZE like '%"+size+"%' ");
            }
            strSql.Append(" order by a.c_type desc,a.c_slab_size asc ");
            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM TQB_SLAB_LEN ");
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
			strSql.Append(")AS Row, T.*  from TQB_SLAB_LEN T ");
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
			parameters[0].Value = "TQB_SLAB_LEN";
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

