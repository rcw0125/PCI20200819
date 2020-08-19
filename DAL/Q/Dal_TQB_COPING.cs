using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;
namespace DAL
{
    /// <summary>
    /// 数据访问类:TQB_COPING
    /// </summary>
    public partial class Dal_TQB_COPING
	{
		public Dal_TQB_COPING()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string C_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from TQB_COPING");
			strSql.Append(" where C_ID=:C_ID ");
			OracleParameter[] parameters = {
					new OracleParameter(":C_ID", OracleDbType.Varchar2,100)			};
			parameters[0].Value = C_ID;

			return DbHelperOra.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Mod_TQB_COPING model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into TQB_COPING(");
			strSql.Append("C_STL_GRD,C_STD_CODE,C_SPCIFICATION_MIN,C_SPCIFICATION_MAX,N_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT,C_COPING_BASIC_ID,C_IS_BXG,C_CUSTFILE_NAME)");
			strSql.Append(" values (");
			strSql.Append(":C_STL_GRD,:C_STD_CODE,:C_SPCIFICATION_MIN,:C_SPCIFICATION_MAX,:N_STATUS,:C_REMARK,:C_EMP_ID,:D_MOD_DT,:C_COPING_BASIC_ID,:C_IS_BXG,:C_CUSTFILE_NAME)");
			OracleParameter[] parameters = {
 					new OracleParameter(":C_STL_GRD", OracleDbType.Varchar2,100),
					new OracleParameter(":C_STD_CODE", OracleDbType.Varchar2,100),
					new OracleParameter(":C_SPCIFICATION_MIN", OracleDbType.Varchar2,100),
					new OracleParameter(":C_SPCIFICATION_MAX", OracleDbType.Varchar2,100),
					new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
					new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
					new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
					new OracleParameter(":D_MOD_DT", OracleDbType.Date),
					new OracleParameter(":C_COPING_BASIC_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_IS_BXG", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CUSTFILE_NAME", OracleDbType.Varchar2,100)
            };
 			parameters[0].Value = model.C_STL_GRD;
			parameters[1].Value = model.C_STD_CODE;
			parameters[2].Value = model.C_SPCIFICATION_MIN;
			parameters[3].Value = model.C_SPCIFICATION_MAX;
			parameters[4].Value = model.N_STATUS;
			parameters[5].Value = model.C_REMARK;
			parameters[6].Value = model.C_EMP_ID;
			parameters[7].Value = model.D_MOD_DT;
			parameters[8].Value = model.C_COPING_BASIC_ID;
            parameters[9].Value = model.C_IS_BXG;
            parameters[10].Value = model.C_CUSTFILE_NAME;



            int rows =DbHelperOra.ExecuteSql(strSql.ToString(),parameters);
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
		public bool Update(Mod_TQB_COPING model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update TQB_COPING set ");
			strSql.Append("C_STL_GRD=:C_STL_GRD,");
			strSql.Append("C_STD_CODE=:C_STD_CODE,");
			strSql.Append("C_SPCIFICATION_MIN=:C_SPCIFICATION_MIN,");
			strSql.Append("C_SPCIFICATION_MAX=:C_SPCIFICATION_MAX,");
			strSql.Append("N_STATUS=:N_STATUS,");
			strSql.Append("C_REMARK=:C_REMARK,");
			strSql.Append("C_EMP_ID=:C_EMP_ID,");
			strSql.Append("D_MOD_DT=:D_MOD_DT,");
			strSql.Append("C_COPING_BASIC_ID=:C_COPING_BASIC_ID,");
            strSql.Append("C_IS_BXG=:C_IS_BXG,");
            strSql.Append("C_CUSTFILE_NAME=:C_CUSTFILE_NAME");
            strSql.Append(" where C_ID=:C_ID ");
			OracleParameter[] parameters = {
					new OracleParameter(":C_STL_GRD", OracleDbType.Varchar2,100),
					new OracleParameter(":C_STD_CODE", OracleDbType.Varchar2,100),
					new OracleParameter(":C_SPCIFICATION_MIN", OracleDbType.Varchar2,100),
					new OracleParameter(":C_SPCIFICATION_MAX", OracleDbType.Varchar2,100),
					new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
					new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
					new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
					new OracleParameter(":D_MOD_DT", OracleDbType.Date),
					new OracleParameter(":C_COPING_BASIC_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_IS_BXG", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CUSTFILE_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)};
			parameters[0].Value = model.C_STL_GRD;
			parameters[1].Value = model.C_STD_CODE;
			parameters[2].Value = model.C_SPCIFICATION_MIN;
			parameters[3].Value = model.C_SPCIFICATION_MAX;
			parameters[4].Value = model.N_STATUS;
			parameters[5].Value = model.C_REMARK;
			parameters[6].Value = model.C_EMP_ID;
			parameters[7].Value = model.D_MOD_DT;
			parameters[8].Value = model.C_COPING_BASIC_ID;
            parameters[9].Value = model.C_IS_BXG;
            parameters[10].Value = model.C_CUSTFILE_NAME;
            parameters[11].Value = model.C_ID;

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
			strSql.Append("delete from TQB_COPING ");
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
			strSql.Append("delete from TQB_COPING ");
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
		public Mod_TQB_COPING GetModel(string C_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select C_ID,C_STL_GRD,C_STD_CODE,C_SPCIFICATION_MIN,C_SPCIFICATION_MAX,N_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT,C_COPING_BASIC_ID,C_IS_BXG,C_CUSTFILE_NAME from TQB_COPING ");
			strSql.Append(" where C_ID=:C_ID ");
			OracleParameter[] parameters = {
					new OracleParameter(":C_ID", OracleDbType.Varchar2,100)			};
			parameters[0].Value = C_ID;

			Mod_TQB_COPING model=new Mod_TQB_COPING();
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
		public Mod_TQB_COPING DataRowToModel(DataRow row)
		{
			Mod_TQB_COPING model=new Mod_TQB_COPING();
			if (row != null)
			{
				if(row["C_ID"]!=null)
				{
					model.C_ID=row["C_ID"].ToString();
				}
				if(row["C_STL_GRD"]!=null)
				{
					model.C_STL_GRD=row["C_STL_GRD"].ToString();
				}
				if(row["C_STD_CODE"]!=null)
				{
					model.C_STD_CODE=row["C_STD_CODE"].ToString();
				}
				if(row["C_SPCIFICATION_MIN"]!=null)
				{
					model.C_SPCIFICATION_MIN=row["C_SPCIFICATION_MIN"].ToString();
				}
				if(row["C_SPCIFICATION_MAX"]!=null)
				{
					model.C_SPCIFICATION_MAX=row["C_SPCIFICATION_MAX"].ToString();
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
				if(row["C_COPING_BASIC_ID"]!=null)
				{
					model.C_COPING_BASIC_ID=row["C_COPING_BASIC_ID"].ToString();
                }
                if (row["C_IS_BXG"] != null)
                {
                    model.C_IS_BXG = row["C_IS_BXG"].ToString();
                }
                if (row["C_CUSTFILE_NAME"] != null)
                {
                    model.C_CUSTFILE_NAME = row["C_CUSTFILE_NAME"].ToString();
                }
            }
			return model;
		}

        /// <summary>
        /// 获得数据列表
        /// </summary>
        /// <param name="C_IS_BXG">是否为不锈钢</param>
        /// <param name="C_STL_GRD">钢种</param>
        /// <returns></returns>
        public DataSet GetList(string C_IS_BXG, string C_STL_GRD)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select a.C_ID,a.C_STL_GRD,a.C_STD_CODE,a.C_SPCIFICATION_MIN,a.C_SPCIFICATION_MAX,t.c_coping_craft,t.c_craft_flow,a.N_STATUS,a.C_REMARK,a.C_EMP_ID,a.D_MOD_DT,a.C_COPING_BASIC_ID,a.C_IS_BXG,a.C_CUSTFILE_NAME  ");
            strSql.Append(" FROM TQB_COPING a  join tqb_coping_basic t on a.C_COPING_BASIC_ID=t.c_id where a.N_STATUS='1'  and a.c_is_bxg='"+ C_IS_BXG + "'  ");
            if (C_STL_GRD.Trim() != "")
            {
                strSql.Append(" and a.C_STL_GRD like '%" + C_STL_GRD + "%' ");
            }
            return DbHelperOra.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM TQB_COPING ");
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
			strSql.Append(")AS Row, T.*  from TQB_COPING T ");
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
        /// 获取钢坯修磨要求
        /// </summary>
        /// <param name="C_STL_GRD">钢种</param>
        /// <param name="C_STD_CODE">执行标准</param>
        /// <returns>钢坯修磨要求</returns>
        public DataSet GetXMYQ(string C_STL_GRD, string C_STD_CODE)
        {
            string sql = "SELECT T.C_STL_GRD, T.C_STD_CODE, TB.C_COPING_CRAFT, TB.C_CRAFT_FLOW  FROM TQB_COPING T, TQB_COPING_BASIC TB WHERE TB.C_ID = T.C_COPING_BASIC_ID  AND T.N_STATUS = 1 AND TB.N_STATUS = 1 AND T.C_STL_GRD = '" + C_STL_GRD + "'";
            sql = sql + " AND ( ";
            if (C_STD_CODE.Contains("Q/XG") || C_STD_CODE.Contains("GB/T") || C_STD_CODE.Contains("Q/邢钢"))
            {
                C_STD_CODE = C_STD_CODE.Split('-')[0].Split('.')[0];
                sql = sql + " T.C_STD_CODE LIKE '" + C_STD_CODE + "%'";
            }
            else
            {
                sql = sql + " T.C_STD_CODE = '" + C_STD_CODE + "'";
            }
            sql = sql + "  OR T.C_STD_CODE = '全部' OR T.C_STD_CODE = '所有' OR T.C_STD_CODE IS NULL)  ";

            return DbHelperOra.Query(sql.ToString());
        }
        #endregion  ExtensionMethod
    }
}

