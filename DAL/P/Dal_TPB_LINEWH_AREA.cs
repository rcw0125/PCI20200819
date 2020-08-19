using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;
namespace DAL
{
    /// <summary>
    /// 数据访问类:TPB_LINEWH_AREA
    /// </summary>
    public partial class Dal_TPB_LINEWH_AREA
    {
        public Dal_TPB_LINEWH_AREA()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string C_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TPB_LINEWH_AREA");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)          };
            parameters[0].Value = C_ID;

            return DbHelperOra.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 查询某仓库是否存在未停用的区域信息
        /// </summary>
        /// <param name="strLineWH">仓库主键</param>
        /// <returns></returns>
		public bool ExistsNOSotpByLineWH(string strLineWH)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TPB_LINEWH_AREA");
            strSql.Append(" where C_LINEWH_ID=:C_LINEWH_ID  AND N_STATUS=1");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_LINEWH_ID", OracleDbType.Varchar2,100)          };
            parameters[0].Value = strLineWH;

            return DbHelperOra.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Mod_TPB_LINEWH_AREA model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TPB_LINEWH_AREA(");
            strSql.Append("C_LINEWH_ID,C_LINEWH_AREA_CODE,C_LINEWH_AREA_NAME,N_LINEWH_AREA_CAP,C_REMARK,C_EMP_ID,C_ISOUT,C_LOADING_MODE,C_TRANSPORT_MODE)");
            strSql.Append(" values (");
            strSql.Append(":C_LINEWH_ID,:C_LINEWH_AREA_CODE,:C_LINEWH_AREA_NAME,:N_LINEWH_AREA_CAP,:C_REMARK,:C_EMP_ID,:C_ISOUT,:C_LOADING_MODE,:C_TRANSPORT_MODE)");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_LINEWH_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_LINEWH_AREA_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_LINEWH_AREA_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_LINEWH_AREA_CAP", OracleDbType.Double,15),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,200),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ISOUT", OracleDbType.Varchar2,2),
                    new OracleParameter(":C_LOADING_MODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_TRANSPORT_MODE", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.C_LINEWH_ID;
            parameters[1].Value = model.C_LINEWH_AREA_CODE;
            parameters[2].Value = model.C_LINEWH_AREA_NAME;
            parameters[3].Value = model.N_LINEWH_AREA_CAP;
            parameters[4].Value = model.C_REMARK;
            parameters[5].Value = model.C_EMP_ID;
            parameters[6].Value = model.C_ISOUT;
            parameters[7].Value = model.C_LOADING_MODE;
            parameters[8].Value = model.C_TRANSPORT_MODE;


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
        public bool Update(Mod_TPB_LINEWH_AREA model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TPB_LINEWH_AREA set ");
            strSql.Append("C_LINEWH_ID=:C_LINEWH_ID,");
            strSql.Append("C_LINEWH_AREA_CODE=:C_LINEWH_AREA_CODE,");
            strSql.Append("C_LINEWH_AREA_NAME=:C_LINEWH_AREA_NAME,");
            strSql.Append("N_LINEWH_AREA_CAP=:N_LINEWH_AREA_CAP,");
            strSql.Append("D_START_DATE=:D_START_DATE,");
            strSql.Append("D_END_DATE=:D_END_DATE,");
            strSql.Append("N_STATUS=:N_STATUS,");
            strSql.Append("C_REMARK=:C_REMARK,");
            strSql.Append("C_EMP_ID=:C_EMP_ID,");
            strSql.Append("D_MOD_DT=:D_MOD_DT,");
            strSql.Append("C_ISOUT=:C_ISOUT,");
            strSql.Append("C_LOADING_MODE=:C_LOADING_MODE,");
            strSql.Append("C_TRANSPORT_MODE=:C_TRANSPORT_MODE");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_LINEWH_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_LINEWH_AREA_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_LINEWH_AREA_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_LINEWH_AREA_CAP", OracleDbType.Decimal,15),
                    new OracleParameter(":D_START_DATE", OracleDbType.Date),
                    new OracleParameter(":D_END_DATE", OracleDbType.Date),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,200),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":C_ISOUT", OracleDbType.Varchar2,2),
                    new OracleParameter(":C_LOADING_MODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_TRANSPORT_MODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.C_LINEWH_ID;
            parameters[1].Value = model.C_LINEWH_AREA_CODE;
            parameters[2].Value = model.C_LINEWH_AREA_NAME;
            parameters[3].Value = model.N_LINEWH_AREA_CAP;
            parameters[4].Value = model.D_START_DATE;
            parameters[5].Value = model.D_END_DATE;
            parameters[6].Value = model.N_STATUS;
            parameters[7].Value = model.C_REMARK;
            parameters[8].Value = model.C_EMP_ID;
            parameters[9].Value = model.D_MOD_DT;
            parameters[10].Value = model.C_ISOUT;
            parameters[11].Value = model.C_LOADING_MODE;
            parameters[12].Value = model.C_TRANSPORT_MODE;
            parameters[13].Value = model.C_ID;

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
            strSql.Append("delete from TPB_LINEWH_AREA ");
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
            strSql.Append("delete from TPB_LINEWH_AREA ");
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
		public Mod_TPB_LINEWH_AREA GetModel(string C_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_LINEWH_ID,C_LINEWH_AREA_CODE,C_LINEWH_AREA_NAME,N_LINEWH_AREA_CAP,D_START_DATE,D_END_DATE,N_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT,C_ISOUT,C_LOADING_MODE,C_TRANSPORT_MODE from TPB_LINEWH_AREA ");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)         };
            parameters[0].Value = C_ID;

            Mod_TPB_LINEWH_AREA model = new Mod_TPB_LINEWH_AREA();
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
        public Mod_TPB_LINEWH_AREA DataRowToModel(DataRow row)
        {
            Mod_TPB_LINEWH_AREA model = new Mod_TPB_LINEWH_AREA();
            if (row != null)
            {
                if (row["C_ID"] != null)
                {
                    model.C_ID = row["C_ID"].ToString();
                }
                if (row["C_LINEWH_ID"] != null)
                {
                    model.C_LINEWH_ID = row["C_LINEWH_ID"].ToString();
                }
                if (row["C_LINEWH_AREA_CODE"] != null)
                {
                    model.C_LINEWH_AREA_CODE = row["C_LINEWH_AREA_CODE"].ToString();
                }
                if (row["C_LINEWH_AREA_NAME"] != null)
                {
                    model.C_LINEWH_AREA_NAME = row["C_LINEWH_AREA_NAME"].ToString();
                }
                if (row["N_LINEWH_AREA_CAP"] != null && row["N_LINEWH_AREA_CAP"].ToString() != "")
                {
                    model.N_LINEWH_AREA_CAP = decimal.Parse(row["N_LINEWH_AREA_CAP"].ToString());
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
                if (row["C_ISOUT"] != null)
                {
                    model.C_ISOUT = row["C_ISOUT"].ToString();
                }
                if (row["C_LOADING_MODE"] != null)
                {
                    model.C_LOADING_MODE = row["C_LOADING_MODE"].ToString();
                }
                if (row["C_TRANSPORT_MODE"] != null)
                {
                    model.C_TRANSPORT_MODE = row["C_TRANSPORT_MODE"].ToString();
                }
            }
            return model;
        }
        /// <summary>
        /// 根据仓库代码获取区域
        /// </summary>
        /// <param name="C_LINEWH_CODE">仓库代码</param>
        /// <returns></returns>
        public DataSet GetList_ID(string C_LINEWH_CODE)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT A.C_LINEWH_AREA_CODE,A.C_LINEWH_AREA_NAME");
            strSql.Append(" FROM TPB_LINEWH_AREA A,TPB_LINEWH B WHERE A.C_LINEWH_ID=B.C_ID");
            if (C_LINEWH_CODE.Trim() != "")
            {
                strSql.Append(" AND B.C_LINEWH_CODE = '" + C_LINEWH_CODE + "'");
            }
            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 获得数据列表-外键
        /// </summary>
        public DataSet GetList_Query(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_LINEWH_ID,C_LINEWH_AREA_CODE,C_LINEWH_AREA_NAME,N_LINEWH_AREA_CAP,D_START_DATE,D_END_DATE,DECODE(N_STATUS,1,'启用','停用') N_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT,C_ISOUT ");
            strSql.Append(" FROM TPB_LINEWH_AREA ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where C_LINEWH_ID = '"+ strWhere + "'" );
            }
            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_LINEWH_ID,C_LINEWH_AREA_CODE,C_LINEWH_AREA_NAME,N_LINEWH_AREA_CAP,D_START_DATE,D_END_DATE,DECODE(N_STATUS,1,'启用','停用') N_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT,C_ISOUT,C_LOADING_MODE,C_TRANSPORT_MODE  ");
            strSql.Append(" FROM TPB_LINEWH_AREA ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetListByLineWHID(string strLineWHID, int iStatus)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_LINEWH_ID,C_LINEWH_AREA_CODE,C_LINEWH_AREA_NAME,N_LINEWH_AREA_CAP,D_START_DATE,D_END_DATE,DECODE(N_STATUS,1,'启用','停用') N_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT,C_ISOUT,C_LOADING_MODE,C_TRANSPORT_MODE  ");
            strSql.Append(" FROM TPB_LINEWH_AREA ");
            if (strLineWHID.Trim() != "")
            {
                strSql.Append(" where C_LINEWH_ID=:C_LINEWH_ID  ");
            }
            if (iStatus.ToString().Trim() != "")
            {
                strSql.Append(" AND N_STATUS=:N_STATUS  ");
            }
            strSql.Append(" order by to_number(C_LINEWH_AREA_CODE)");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_LINEWH_ID", OracleDbType.Varchar2,100),
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
            strSql.Append("select count(1) FROM TPB_LINEWH_AREA ");
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
        /// 获得数据列表
        /// </summary>
        /// <param name="C_LINEWH_AREA_CODE">仓库编码</param>
        /// <param name="C_LINEWH_AREA_NAME">仓库描述</param>
        /// <returns></returns>
        public DataSet GetList_linewh_id(string C_LINEWH_AREA_CODE,string C_LINEWH_AREA_NAME)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_LINEWH_ID,C_LINEWH_AREA_CODE,C_LINEWH_AREA_NAME  ");
            strSql.Append(" FROM TPB_LINEWH_AREA where 1=1 ");
            if (C_LINEWH_AREA_CODE.Trim() != "")
            {
                strSql.Append(" and C_LINEWH_AREA_CODE = '" + C_LINEWH_AREA_CODE + "'");
            }
            if (C_LINEWH_AREA_NAME.Trim() != "")
            {
                strSql.Append(" and C_LINEWH_AREA_NAME = '" + C_LINEWH_AREA_NAME + "'");
            }
            return DbHelperOra.Query(strSql.ToString());
        }


        #endregion  BasicMethod
    }
}

