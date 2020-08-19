using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;

namespace DAL
{
	/// <summary>
	/// 数据访问类:TQB_ROUTE
	/// </summary>
	public partial class Dal_TQB_ROUTE
	{
		public Dal_TQB_ROUTE()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string C_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from TQB_ROUTE");
			strSql.Append(" where C_ID=:C_ID ");
			OracleParameter[] parameters = {
					new OracleParameter(":C_ID", OracleDbType.Varchar2,100)			};
			parameters[0].Value = C_ID;

			return DbHelperOra.Exists(strSql.ToString(),parameters);
		}


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Mod_TQB_ROUTE model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TQB_ROUTE(");
            strSql.Append("C_STD_ID,C_STD_CODE,C_ROUTE_TYPE,C_ROUTE_DESC,N_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT,C_STL_GRD,C_IS_BXG,C_CUSTFILE_NAME,C_SPEC)");
            strSql.Append(" values (");
            strSql.Append(":C_STD_ID,:C_STD_CODE,:C_ROUTE_TYPE,:C_ROUTE_DESC,:N_STATUS,:C_REMARK,:C_EMP_ID,:D_MOD_DT,:C_STL_GRD,:C_IS_BXG,:C_CUSTFILE_NAME,:C_SPEC)");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_STD_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STD_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ROUTE_TYPE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ROUTE_DESC", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":C_STL_GRD", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_IS_BXG", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CUSTFILE_NAME", OracleDbType.Varchar2,200),
                    new OracleParameter(":C_SPEC", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.C_STD_ID;
            parameters[1].Value = model.C_STD_CODE;
            parameters[2].Value = model.C_ROUTE_TYPE;
            parameters[3].Value = model.C_ROUTE_DESC;
            parameters[4].Value = model.N_STATUS;
            parameters[5].Value = model.C_REMARK;
            parameters[6].Value = model.C_EMP_ID;
            parameters[7].Value = model.D_MOD_DT;
            parameters[8].Value = model.C_STL_GRD;
            parameters[9].Value = model.C_IS_BXG;
            parameters[10].Value = model.C_CUSTFILE_NAME;
            parameters[11].Value = model.C_SPEC;

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
        public bool Update(Mod_TQB_ROUTE model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TQB_ROUTE set ");
            strSql.Append("C_STD_ID=:C_STD_ID,");
            strSql.Append("C_STD_CODE=:C_STD_CODE,");
            strSql.Append("C_ROUTE_TYPE=:C_ROUTE_TYPE,");
            strSql.Append("C_ROUTE_DESC=:C_ROUTE_DESC,");
            strSql.Append("N_STATUS=:N_STATUS,");
            strSql.Append("C_REMARK=:C_REMARK,");
            strSql.Append("C_EMP_ID=:C_EMP_ID,");
            strSql.Append("D_MOD_DT=:D_MOD_DT,");
            strSql.Append("C_STL_GRD=:C_STL_GRD,");
            strSql.Append("C_IS_BXG=:C_IS_BXG,");
            strSql.Append("C_CUSTFILE_NAME=:C_CUSTFILE_NAME,");
            strSql.Append("C_SPEC=:C_SPEC");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_STD_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STD_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ROUTE_TYPE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ROUTE_DESC", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":C_STL_GRD", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_IS_BXG", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CUSTFILE_NAME", OracleDbType.Varchar2,200),
                    new OracleParameter(":C_SPEC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.C_STD_ID;
            parameters[1].Value = model.C_STD_CODE;
            parameters[2].Value = model.C_ROUTE_TYPE;
            parameters[3].Value = model.C_ROUTE_DESC;
            parameters[4].Value = model.N_STATUS;
            parameters[5].Value = model.C_REMARK;
            parameters[6].Value = model.C_EMP_ID;
            parameters[7].Value = model.D_MOD_DT;
            parameters[8].Value = model.C_STL_GRD;
            parameters[9].Value = model.C_IS_BXG;
            parameters[10].Value = model.C_CUSTFILE_NAME;
            parameters[11].Value = model.C_SPEC;
            parameters[12].Value = model.C_ID;

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
        /// 删除一条数据
        /// </summary>
        public bool Delete(string C_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from TQB_ROUTE ");
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
			strSql.Append("delete from TQB_ROUTE ");
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
        public Mod_TQB_ROUTE GetModel(string C_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_STD_ID,C_STD_CODE,C_ROUTE_TYPE,C_ROUTE_DESC,N_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT,C_STL_GRD,C_IS_BXG,C_CUSTFILE_NAME,C_SPEC from TQB_ROUTE ");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)            };
            parameters[0].Value = C_ID;

            Mod_TQB_ROUTE model = new Mod_TQB_ROUTE();
            DataSet ds = DbHelperOra.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
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
        public Mod_TQB_ROUTE DataRowToModel(DataRow row)
        {
            Mod_TQB_ROUTE model = new Mod_TQB_ROUTE();
            if (row != null)
            {
                if (row["C_ID"] != null)
                {
                    model.C_ID = row["C_ID"].ToString();
                }
                if (row["C_STD_ID"] != null)
                {
                    model.C_STD_ID = row["C_STD_ID"].ToString();
                }
                if (row["C_STD_CODE"] != null)
                {
                    model.C_STD_CODE = row["C_STD_CODE"].ToString();
                }
                if (row["C_ROUTE_TYPE"] != null)
                {
                    model.C_ROUTE_TYPE = row["C_ROUTE_TYPE"].ToString();
                }
                if (row["C_ROUTE_DESC"] != null)
                {
                    model.C_ROUTE_DESC = row["C_ROUTE_DESC"].ToString();
                }
                if (row["N_STATUS"] != null && row["N_STATUS"].ToString() != "")
                {
                    model.N_STATUS = decimal.Parse(row["N_STATUS"].ToString());
                }
                if (row["C_REMARK"] != null)
                {
                    model.C_REMARK = row["C_REMARK"].ToString();
                }
                if (row["C_EMP_ID"] != null)
                {
                    model.C_EMP_ID = row["C_EMP_ID"].ToString();
                }
                if (row["D_MOD_DT"] != null && row["D_MOD_DT"].ToString() != "")
                {
                    model.D_MOD_DT = DateTime.Parse(row["D_MOD_DT"].ToString());
                }
                if (row["C_STL_GRD"] != null)
                {
                    model.C_STL_GRD = row["C_STL_GRD"].ToString();
                }
                if (row["C_IS_BXG"] != null)
                {
                    model.C_IS_BXG = row["C_IS_BXG"].ToString();
                }
                if (row["C_CUSTFILE_NAME"] != null)
                {
                    model.C_CUSTFILE_NAME = row["C_CUSTFILE_NAME"].ToString();
                }
                if (row["C_SPEC"] != null)
                {
                    model.C_SPEC = row["C_SPEC"].ToString();
                }
            }
            return model;
        }


        /// <summary>
        /// 获得数据列表
        /// </summary>
        /// <param name="RH">过真空</param>
        /// <param name="DHL">大方坯缓冷</param>
        /// <param name="KP">开坯</param>
        /// <param name="HL">缓冷</param>
        /// <param name="XM">修磨</param>
        /// <param name="str_STD">执行标准</param>
        /// <param name="stl_grd">钢种</param>
        /// <param name="C_IS_BXG">是否为不锈钢</param>
        /// <returns></returns>
        public DataSet GetList(string RH,string DHL,string KP,string HL,string XM,string str_STD,string stl_grd,string C_IS_BXG)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select t.c_id,t.C_IS_BXG,t.c_std_code,t.c_stl_grd,t.c_route_type,t.c_route_desc,t.d_mod_dt,T.C_STD_ID,t.c_remark,T.C_EMP_ID,t.C_SPEC,t.C_CUSTFILE_NAME  ");
			strSql.Append(" from tqb_route t  where 1=1 AND T.N_STATUS=1 and t.C_IS_BXG='"+ C_IS_BXG + "' ");
            if (!string.IsNullOrEmpty(RH))
            {
                strSql.Append(" and t.c_route_desc like '%" + RH + "%' ");
            }
            if (!string.IsNullOrEmpty(DHL))
            {
                strSql.Append(" and t.c_route_desc like '%" + DHL + "%' ");
            }
            if (!string.IsNullOrEmpty(KP))
            {
                strSql.Append(" and t.c_route_desc like '%" + KP + "%' ");
            }
            if (!string.IsNullOrEmpty(HL))
            {
                strSql.Append(" and t.c_route_desc like '%" + HL + "%' ");
            }
            if (!string.IsNullOrEmpty(XM))
            {
                strSql.Append(" and t.c_route_desc like '%" + XM + "%' ");
            }
            if (str_STD != "")
            {
                strSql.Append(" and t.c_std_code like '%" + str_STD + "%' ");
            }
            if (stl_grd != "")
            {
                strSql.Append(" and t.c_stl_grd like '%" + stl_grd + "%' ");
            }
            return DbHelperOra.Query(strSql.ToString());
		}

        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM TQB_ROUTE ");
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
			strSql.Append(")AS Row, T.*  from TQB_ROUTE T ");
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

        /// <summary>
        /// 获取订单工艺路线
        /// </summary>
        /// <param name="C_STL_GRD">钢种</param>
        /// <param name="C_STD_CODE">执行标准</param>
        ///  <param name="C_ROUTE_TYPE">路线类型</param>
        /// <returns>工艺路线</returns>
        public DataTable GetGYLX(string C_STL_GRD,string C_STD_CODE,string C_ROUTE_TYPE)
        {
            string sql = @"SELECT T.C_STD_ID,
       T.C_STL_GRD,
       T.C_STD_CODE,
       T.C_ROUTE_TYPE,
       T.C_IS_BXG,
       T.C_ROUTE_DESC
  FROM TQB_ROUTE T
 WHERE T.N_STATUS = 1  AND T.C_STL_GRD = '" + C_STL_GRD + "'";

            if (C_STD_CODE.Contains("Q/XG")|| C_STD_CODE.Contains("GB/T")|| C_STD_CODE.Contains("Q/邢钢") )
            {
                C_STD_CODE = C_STD_CODE.Split('-')[0].Split('.')[0]; 
                sql = sql + " AND T.C_STD_CODE LIKE '" + C_STD_CODE + "%'";
            }
            else
            {
                sql = sql + "   AND T.C_STD_CODE = '" + C_STD_CODE + "'";
            }
            if (C_ROUTE_TYPE.Trim()!="")
            {
                sql = sql + "   AND T.C_ROUTE_TYPE = '" + C_ROUTE_TYPE + "'";
            }
         //   AND T.C_STD_CODE = '"+ C_STD_CODE + "' ";
         
            return DbHelperOra.Query(sql).Tables[0];
        }

		#endregion  ExtensionMethod
	}
}

