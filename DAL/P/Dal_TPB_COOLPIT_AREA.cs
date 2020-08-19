using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;
namespace DAL
{
	/// <summary>
	/// 数据访问类:TPB_COOLPIT_AREA
	/// </summary>
	public partial class Dal_TPB_COOLPIT_AREA
    {
		public Dal_TPB_COOLPIT_AREA()
		{}
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string C_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TPB_COOLPIT_AREA");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)          };
            parameters[0].Value = C_ID;

            return DbHelperOra.Exists(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 查询某仓库是否存在未停用的区域信息
        /// </summary>
        /// <param name="strCOOLPIT">仓库主键</param>
        /// <returns></returns>
        public bool ExistsNOSotpByCOOLPIT(string strCOOLPIT)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TPB_COOLPIT_AREA");
            strSql.Append(" where C_COOLPIT_ID=:C_COOLPIT_ID  AND N_STATUS=1");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_COOLPIT_ID", OracleDbType.Varchar2,100)          };
            parameters[0].Value = strCOOLPIT;

            return DbHelperOra.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Mod_TPB_COOLPIT_AREA model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TPB_COOLPIT_AREA(");
            strSql.Append("C_COOLPIT_ID,C_COOLPIT_AREA_CODE,C_COOLPIT_AREA_NAME,D_END_DATE,C_REMARK,C_EMP_ID)");
            strSql.Append(" values (");
            strSql.Append(":C_COOLPIT_ID,:C_COOLPIT_AREA_CODE,:C_COOLPIT_AREA_NAME,:D_END_DATE,:C_REMARK,:C_EMP_ID)");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_COOLPIT_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_COOLPIT_AREA_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_COOLPIT_AREA_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_END_DATE", OracleDbType.Date),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,200),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.C_COOLPIT_ID;
            parameters[1].Value = model.C_COOLPIT_AREA_CODE;
            parameters[2].Value = model.C_COOLPIT_AREA_NAME;
            parameters[3].Value = model.D_END_DATE;
            parameters[4].Value = model.C_REMARK;
            parameters[5].Value = model.C_EMP_ID;


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
        public bool Update(Mod_TPB_COOLPIT_AREA model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TPB_COOLPIT_AREA set ");
            strSql.Append("C_COOLPIT_ID=:C_COOLPIT_ID,");
            strSql.Append("C_COOLPIT_AREA_CODE=:C_COOLPIT_AREA_CODE,");
            strSql.Append("C_COOLPIT_AREA_NAME=:C_COOLPIT_AREA_NAME,");
            strSql.Append("D_START_DATE=:D_START_DATE,");
            strSql.Append("D_END_DATE=:D_END_DATE,");
            strSql.Append("N_STATUS=:N_STATUS,");
            strSql.Append("C_REMARK=:C_REMARK,");
            strSql.Append("C_EMP_ID=:C_EMP_ID,");
            strSql.Append("D_MOD_DT=:D_MOD_DT");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_COOLPIT_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_COOLPIT_AREA_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_COOLPIT_AREA_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_START_DATE", OracleDbType.Date),
                    new OracleParameter(":D_END_DATE", OracleDbType.Date),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,200),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.C_COOLPIT_ID;
            parameters[1].Value = model.C_COOLPIT_AREA_CODE;
            parameters[2].Value = model.C_COOLPIT_AREA_NAME;
            parameters[3].Value = model.D_START_DATE;
            parameters[4].Value = model.D_END_DATE;
            parameters[5].Value = model.N_STATUS;
            parameters[6].Value = model.C_REMARK;
            parameters[7].Value = model.C_EMP_ID;
            parameters[8].Value = model.D_MOD_DT;
            parameters[9].Value = model.C_ID;


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

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from TPB_COOLPIT_AREA ");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)          };
            parameters[0].Value = C_ID;

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
        public bool DeleteList(string C_IDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from TPB_COOLPIT_AREA ");
            strSql.Append(" where C_ID in (" + C_IDlist + ")  ");
            int rows = DbHelperOra.ExecuteSql(strSql.ToString());
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
        public Mod_TPB_COOLPIT_AREA GetModel(string C_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_COOLPIT_ID,C_COOLPIT_AREA_CODE,C_COOLPIT_AREA_NAME,D_START_DATE,D_END_DATE,N_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT from TPB_COOLPIT_AREA ");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)          };
            parameters[0].Value = C_ID;

            Mod_TPB_COOLPIT_AREA model = new Mod_TPB_COOLPIT_AREA();
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
        public Mod_TPB_COOLPIT_AREA DataRowToModel(DataRow row)
        {
            Mod_TPB_COOLPIT_AREA model = new Mod_TPB_COOLPIT_AREA();
            if (row != null)
            {
                if (row["C_ID"] != null)
                {
                    model.C_ID = row["C_ID"].ToString();
                }
                if (row["C_COOLPIT_ID"] != null)
                {
                    model.C_COOLPIT_ID = row["C_COOLPIT_ID"].ToString();
                }
                if (row["C_COOLPIT_AREA_CODE"] != null)
                {
                    model.C_COOLPIT_AREA_CODE = row["C_COOLPIT_AREA_CODE"].ToString();
                }
                if (row["C_COOLPIT_AREA_NAME"] != null)
                {
                    model.C_COOLPIT_AREA_NAME = row["C_COOLPIT_AREA_NAME"].ToString();
                }

                if (row["D_START_DATE"] != null && row["D_START_DATE"].ToString() != "")
                {
                    model.D_START_DATE = DateTime.Parse(row["D_START_DATE"].ToString());
                }
                if (row["D_END_DATE"] != null && row["D_END_DATE"].ToString() != "")
                {
                    model.D_END_DATE = DateTime.Parse(row["D_END_DATE"].ToString());
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
            }
            return model;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_COOLPIT_ID,C_COOLPIT_AREA_CODE,C_COOLPIT_AREA_NAME,D_START_DATE,D_END_DATE,DECODE(N_STATUS,1,'启用','停用') N_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT ");
            strSql.Append(" FROM TPB_COOLPIT_AREA ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperOra.Query(strSql.ToString());
        }


        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetListByCOOLPITID(string strLineWHID, int iStatus)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_COOLPIT_ID,C_COOLPIT_AREA_CODE,C_COOLPIT_AREA_NAME,D_START_DATE,D_END_DATE,DECODE(N_STATUS,1,'启用','停用') N_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT ");
            strSql.Append(" FROM TPB_COOLPIT_AREA ");
            if (strLineWHID.Trim() != "")
            {
                strSql.Append(" where C_COOLPIT_ID=:C_COOLPIT_ID  ");
            }
            if (iStatus.ToString().Trim() != "")
            {
                strSql.Append(" AND N_STATUS=:N_STATUS  ");
            }

            OracleParameter[] parameters = {
                    new OracleParameter(":C_COOLPIT_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,3) };
            parameters[0].Value = strLineWHID;
            parameters[1].Value = iStatus;
            return DbHelperOra.Query(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM TPB_COOLPIT_AREA ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
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
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT * FROM ( ");
            strSql.Append(" SELECT ROW_NUMBER() OVER (");
            if (!string.IsNullOrEmpty(orderby.Trim()))
            {
                strSql.Append("order by T." + orderby);
            }
            else
            {
                strSql.Append("order by T.C_ID desc");
            }
            strSql.Append(")AS Row, T.*  from TPB_COOLPIT_AREA T ");
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
			parameters[0].Value = "TPB_COOLPIT_AREA";
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

