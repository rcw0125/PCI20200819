using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;
namespace DAL
{
	/// <summary>
	/// 数据访问类:TPB_COOLPIT_LOC
	/// </summary>
	public partial class Dal_TPB_COOLPIT_LOC
    {
		public Dal_TPB_COOLPIT_LOC()
		{}
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string C_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TPB_COOLPIT_LOC");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)          };
            parameters[0].Value = C_ID;

            return DbHelperOra.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Mod_TPB_COOLPIT_LOC model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TPB_COOLPIT_LOC(");
            strSql.Append("C_COOLPIT_AREA_ID,C_COOLPIT_LOC_CODE,C_COOLPIT_LOC_NAME,N_COOLPIT_LOC_CAP,N_COOLPIT_TIER,D_END_DATE,C_REMARK,C_EMP_ID,C_SLAB_TYPE)");
            strSql.Append(" values (");
            strSql.Append(":C_COOLPIT_AREA_ID,:C_COOLPIT_LOC_CODE,:C_COOLPIT_LOC_NAME,:N_COOLPIT_LOC_CAP,:N_COOLPIT_TIER,:D_END_DATE,:C_REMARK,:C_EMP_ID,:C_SLAB_TYPE)");
            OracleParameter[] parameters = {

                    new OracleParameter(":C_COOLPIT_AREA_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_COOLPIT_LOC_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_COOLPIT_LOC_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_COOLPIT_LOC_CAP", OracleDbType.Double,15),
                    new OracleParameter(":N_COOLPIT_TIER", OracleDbType.Decimal,3),
                    new OracleParameter(":D_END_DATE", OracleDbType.Date),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,200),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SLAB_TYPE", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.C_COOLPIT_AREA_ID;
            parameters[1].Value = model.C_COOLPIT_LOC_CODE;
            parameters[2].Value = model.C_COOLPIT_LOC_NAME;
            parameters[3].Value = model.N_COOLPIT_LOC_CAP;
            parameters[4].Value = model.N_COOLPIT_TIER;
            parameters[5].Value = model.D_END_DATE;
            parameters[6].Value = model.C_REMARK;
            parameters[7].Value = model.C_EMP_ID;
            parameters[8].Value = model.C_SLAB_TYPE;

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
        public bool Update(Mod_TPB_COOLPIT_LOC model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TPB_COOLPIT_LOC set ");
            strSql.Append("C_COOLPIT_AREA_ID=:C_COOLPIT_AREA_ID,");
            strSql.Append("C_COOLPIT_LOC_CODE=:C_COOLPIT_LOC_CODE,");
            strSql.Append("C_COOLPIT_LOC_NAME=:C_COOLPIT_LOC_NAME,");
            strSql.Append("N_COOLPIT_LOC_CAP=:N_COOLPIT_LOC_CAP,");
            strSql.Append("N_COOLPIT_TIER=:N_COOLPIT_TIER,");
            strSql.Append("D_START_DATE=:D_START_DATE,");
            strSql.Append("D_END_DATE=:D_END_DATE,");
            strSql.Append("N_STATUS=:N_STATUS,");
            strSql.Append("C_REMARK=:C_REMARK,");
            strSql.Append("C_EMP_ID=:C_EMP_ID,");
            strSql.Append("D_MOD_DT=:D_MOD_DT,");
            strSql.Append("C_SLAB_TYPE=:C_SLAB_TYPE ");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_COOLPIT_AREA_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_COOLPIT_LOC_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_COOLPIT_LOC_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_COOLPIT_LOC_CAP", OracleDbType.Double,15),
                    new OracleParameter(":N_COOLPIT_TIER", OracleDbType.Decimal,3),
                    new OracleParameter(":D_START_DATE", OracleDbType.Date),
                    new OracleParameter(":D_END_DATE", OracleDbType.Date),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,200),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":C_SLAB_TYPE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.C_COOLPIT_AREA_ID;
            parameters[1].Value = model.C_COOLPIT_LOC_CODE;
            parameters[2].Value = model.C_COOLPIT_LOC_NAME;
            parameters[3].Value = model.N_COOLPIT_LOC_CAP;
            parameters[4].Value = model.N_COOLPIT_TIER;
            parameters[5].Value = model.D_START_DATE;
            parameters[6].Value = model.D_END_DATE;
            parameters[7].Value = model.N_STATUS;
            parameters[8].Value = model.C_REMARK;
            parameters[9].Value = model.C_EMP_ID;
            parameters[10].Value = model.D_MOD_DT;
            parameters[11].Value = model.C_SLAB_TYPE;
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

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from TPB_COOLPIT_LOC ");
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
            strSql.Append("delete from TPB_COOLPIT_LOC ");
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
        public Mod_TPB_COOLPIT_LOC GetModel(string C_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_COOLPIT_AREA_ID,C_COOLPIT_LOC_CODE,C_COOLPIT_LOC_NAME,N_COOLPIT_LOC_CAP,N_COOLPIT_TIER,D_START_DATE,D_END_DATE,N_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT,C_SLAB_TYPE from TPB_COOLPIT_LOC ");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)          };
            parameters[0].Value = C_ID;

            Mod_TPB_COOLPIT_LOC model = new Mod_TPB_COOLPIT_LOC();
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
        public Mod_TPB_COOLPIT_LOC DataRowToModel(DataRow row)
        {
            Mod_TPB_COOLPIT_LOC model = new Mod_TPB_COOLPIT_LOC();
            if (row != null)
            {
                if (row["C_ID"] != null)
                {
                    model.C_ID = row["C_ID"].ToString();
                }
                if (row["C_COOLPIT_AREA_ID"] != null)
                {
                    model.C_COOLPIT_AREA_ID = row["C_COOLPIT_AREA_ID"].ToString();
                }
                if (row["C_COOLPIT_LOC_CODE"] != null)
                {
                    model.C_COOLPIT_LOC_CODE = row["C_COOLPIT_LOC_CODE"].ToString();
                }
                if (row["C_COOLPIT_LOC_NAME"] != null)
                {
                    model.C_COOLPIT_LOC_NAME = row["C_COOLPIT_LOC_NAME"].ToString();
                }
                if (row["N_COOLPIT_LOC_CAP"] != null && row["N_COOLPIT_LOC_CAP"].ToString() != "")
                {
                    model.N_COOLPIT_LOC_CAP = decimal.Parse(row["N_COOLPIT_LOC_CAP"].ToString());
                }
                if (row["N_COOLPIT_TIER"] != null && row["N_COOLPIT_TIER"].ToString() != "")
                {
                    model.N_COOLPIT_TIER = decimal.Parse(row["N_COOLPIT_TIER"].ToString());
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
                if (row["C_SLAB_TYPE"] != null)
                {
                    model.C_SLAB_TYPE = row["C_SLAB_TYPE"].ToString();
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
            strSql.Append("select C_ID,C_COOLPIT_AREA_ID,C_COOLPIT_LOC_CODE,C_COOLPIT_LOC_NAME,N_COOLPIT_LOC_CAP,N_COOLPIT_TIER,D_START_DATE,D_END_DATE,DECODE(N_STATUS,1,'启用','停用') N_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT,C_SLAB_TYPE ");
            strSql.Append(" FROM TPB_COOLPIT_LOC ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetListByArea(string strAreaID, int iStatus)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_COOLPIT_AREA_ID,C_COOLPIT_LOC_CODE,C_COOLPIT_LOC_NAME,N_COOLPIT_LOC_CAP,N_COOLPIT_TIER,D_START_DATE,D_END_DATE,DECODE(N_STATUS,1,'启用','停用') N_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT,C_SLAB_TYPE ");
            strSql.Append(" FROM TPB_COOLPIT_LOC ");
            if (strAreaID.Trim() != "")
            {
                strSql.Append(" where C_COOLPIT_AREA_ID=:C_COOLPIT_AREA_ID");
            }

            if (iStatus.ToString().Trim() != "")
            {
                strSql.Append(" AND N_STATUS=:N_STATUS");
            }
            OracleParameter[] parameters = {
                    new OracleParameter(":C_COOLPIT_AREA_ID", OracleDbType.Varchar2,100) ,
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,3)         };
            parameters[0].Value = strAreaID;
            parameters[1].Value = iStatus;
            return DbHelperOra.Query(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM TPB_COOLPIT_LOC ");
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
            strSql.Append(")AS Row, T.*  from TPB_COOLPIT_LOC T ");
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

        #endregion  ExtensionMethod
    }
}

