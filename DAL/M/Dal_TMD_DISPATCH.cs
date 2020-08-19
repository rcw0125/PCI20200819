using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;
namespace DAL
{
    /// <summary>
    /// 数据访问类:TMD_DISPATCH
    /// </summary>
    public partial class Dal_TMD_DISPATCH
    {
        public Dal_TMD_DISPATCH()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string C_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TMD_DISPATCH");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)            };
            parameters[0].Value = C_ID;

            return DbHelperOra.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Mod_TMD_DISPATCH model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TMD_DISPATCH(");
            strSql.Append("C_PLAN_ID,C_GPS_NO,C_NO,C_CON_NO,D_DISP_DT,C_SHIPVIA,C_COMCAR,C_PATH,C_PATH_DESC,C_SEND_DEPT,C_BUSINESS_DEPT,C_BUSINESS_ID,C_IS_WIRESALE,N_IS_EXPORT,C_LIC_PLA_NO,C_ATSTATION,D_APPROVE_DT,D_CREATE_DT,C_APPROVE_ID,C_CREATE_ID,C_STATUS,C_EMP_ID,C_EMP_NAME,D_MOD_DT,C_GUID,C_IS_WIRESALE_ID,C_REMARK,C_REMARK2,D_FAILURE)");
            strSql.Append(" values (");
            strSql.Append(":C_PLAN_ID,:C_GPS_NO,:C_NO,:C_CON_NO,:D_DISP_DT,:C_SHIPVIA,:C_COMCAR,:C_PATH,:C_PATH_DESC,:C_SEND_DEPT,:C_BUSINESS_DEPT,:C_BUSINESS_ID,:C_IS_WIRESALE,:N_IS_EXPORT,:C_LIC_PLA_NO,:C_ATSTATION,:D_APPROVE_DT,:D_CREATE_DT,:C_APPROVE_ID,:C_CREATE_ID,:C_STATUS,:C_EMP_ID,:C_EMP_NAME,:D_MOD_DT,:C_GUID,:C_IS_WIRESALE_ID,:C_REMARK,:C_REMARK2,:D_FAILURE)");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_PLAN_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_GPS_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CON_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_DISP_DT", OracleDbType.Date),
                    new OracleParameter(":C_SHIPVIA", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_COMCAR", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PATH", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PATH_DESC", OracleDbType.Varchar2,200),
                    new OracleParameter(":C_SEND_DEPT", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_BUSINESS_DEPT", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_BUSINESS_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_IS_WIRESALE", OracleDbType.Varchar2,2),
                    new OracleParameter(":N_IS_EXPORT", OracleDbType.Int16,1),
                    new OracleParameter(":C_LIC_PLA_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ATSTATION", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_APPROVE_DT", OracleDbType.Date),
                    new OracleParameter(":D_CREATE_DT", OracleDbType.Date),
                    new OracleParameter(":C_APPROVE_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CREATE_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STATUS", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_EMP_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":C_GUID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_IS_WIRESALE_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_REMARK2", OracleDbType.Varchar2,500),
                    new OracleParameter(":D_FAILURE", OracleDbType.Date)};
            parameters[0].Value = model.C_PLAN_ID;
            parameters[1].Value = model.C_GPS_NO;
            parameters[2].Value = model.C_NO;
            parameters[3].Value = model.C_CON_NO;
            parameters[4].Value = model.D_DISP_DT;
            parameters[5].Value = model.C_SHIPVIA;
            parameters[6].Value = model.C_COMCAR;
            parameters[7].Value = model.C_PATH;
            parameters[8].Value = model.C_PATH_DESC;
            parameters[9].Value = model.C_SEND_DEPT;
            parameters[10].Value = model.C_BUSINESS_DEPT;
            parameters[11].Value = model.C_BUSINESS_ID;
            parameters[12].Value = model.C_IS_WIRESALE;
            parameters[13].Value = model.N_IS_EXPORT;
            parameters[14].Value = model.C_LIC_PLA_NO;
            parameters[15].Value = model.C_ATSTATION;
            parameters[16].Value = model.D_APPROVE_DT;
            parameters[17].Value = model.D_CREATE_DT;
            parameters[18].Value = model.C_APPROVE_ID;
            parameters[19].Value = model.C_CREATE_ID;
            parameters[20].Value = model.C_STATUS;
            parameters[21].Value = model.C_EMP_ID;
            parameters[22].Value = model.C_EMP_NAME;
            parameters[23].Value = model.D_MOD_DT;
            parameters[24].Value = model.C_GUID;
            parameters[25].Value = model.C_IS_WIRESALE_ID;
            parameters[26].Value = model.C_REMARK;
            parameters[27].Value = model.C_REMARK2;
            parameters[28].Value = model.D_FAILURE;

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
        public bool Update(Mod_TMD_DISPATCH model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TMD_DISPATCH set ");
            strSql.Append("C_PLAN_ID=:C_PLAN_ID,");
            strSql.Append("C_GPS_NO=:C_GPS_NO,");
            strSql.Append("C_NO=:C_NO,");
            strSql.Append("C_CON_NO=:C_CON_NO,");
            strSql.Append("D_DISP_DT=:D_DISP_DT,");
            strSql.Append("C_SHIPVIA=:C_SHIPVIA,");
            strSql.Append("C_COMCAR=:C_COMCAR,");
            strSql.Append("C_PATH=:C_PATH,");
            strSql.Append("C_PATH_DESC=:C_PATH_DESC,");
            strSql.Append("C_SEND_DEPT=:C_SEND_DEPT,");
            strSql.Append("C_BUSINESS_DEPT=:C_BUSINESS_DEPT,");
            strSql.Append("C_BUSINESS_ID=:C_BUSINESS_ID,");
            strSql.Append("C_IS_WIRESALE=:C_IS_WIRESALE,");
            strSql.Append("N_IS_EXPORT=:N_IS_EXPORT,");
            strSql.Append("C_LIC_PLA_NO=:C_LIC_PLA_NO,");
            strSql.Append("C_ATSTATION=:C_ATSTATION,");
            strSql.Append("D_APPROVE_DT=:D_APPROVE_DT,");
            strSql.Append("D_CREATE_DT=:D_CREATE_DT,");
            strSql.Append("C_APPROVE_ID=:C_APPROVE_ID,");
            strSql.Append("C_CREATE_ID=:C_CREATE_ID,");
            strSql.Append("C_STATUS=:C_STATUS,");
            strSql.Append("C_EMP_ID=:C_EMP_ID,");
            strSql.Append("C_EMP_NAME=:C_EMP_NAME,");
            strSql.Append("D_MOD_DT=:D_MOD_DT,");
            strSql.Append("C_GUID=:C_GUID,");
            strSql.Append("C_IS_WIRESALE_ID=:C_IS_WIRESALE_ID,");
            strSql.Append("C_REMARK=:C_REMARK,");
            strSql.Append("C_REMARK2=:C_REMARK2,");
            strSql.Append("D_FAILURE=:D_FAILURE");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_PLAN_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_GPS_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CON_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_DISP_DT", OracleDbType.Date),
                    new OracleParameter(":C_SHIPVIA", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_COMCAR", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PATH", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PATH_DESC", OracleDbType.Varchar2,200),
                    new OracleParameter(":C_SEND_DEPT", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_BUSINESS_DEPT", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_BUSINESS_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_IS_WIRESALE", OracleDbType.Varchar2,2),
                    new OracleParameter(":N_IS_EXPORT", OracleDbType.Int16,1),
                    new OracleParameter(":C_LIC_PLA_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ATSTATION", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_APPROVE_DT", OracleDbType.Date),
                    new OracleParameter(":D_CREATE_DT", OracleDbType.Date),
                    new OracleParameter(":C_APPROVE_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CREATE_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STATUS", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_EMP_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":C_GUID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_IS_WIRESALE_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_REMARK2", OracleDbType.Varchar2,500),
                    new OracleParameter(":D_FAILURE", OracleDbType.Date),
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.C_PLAN_ID;
            parameters[1].Value = model.C_GPS_NO;
            parameters[2].Value = model.C_NO;
            parameters[3].Value = model.C_CON_NO;
            parameters[4].Value = model.D_DISP_DT;
            parameters[5].Value = model.C_SHIPVIA;
            parameters[6].Value = model.C_COMCAR;
            parameters[7].Value = model.C_PATH;
            parameters[8].Value = model.C_PATH_DESC;
            parameters[9].Value = model.C_SEND_DEPT;
            parameters[10].Value = model.C_BUSINESS_DEPT;
            parameters[11].Value = model.C_BUSINESS_ID;
            parameters[12].Value = model.C_IS_WIRESALE;
            parameters[13].Value = model.N_IS_EXPORT;
            parameters[14].Value = model.C_LIC_PLA_NO;
            parameters[15].Value = model.C_ATSTATION;
            parameters[16].Value = model.D_APPROVE_DT;
            parameters[17].Value = model.D_CREATE_DT;
            parameters[18].Value = model.C_APPROVE_ID;
            parameters[19].Value = model.C_CREATE_ID;
            parameters[20].Value = model.C_STATUS;
            parameters[21].Value = model.C_EMP_ID;
            parameters[22].Value = model.C_EMP_NAME;
            parameters[23].Value = model.D_MOD_DT;
            parameters[24].Value = model.C_GUID;
            parameters[25].Value = model.C_IS_WIRESALE_ID;
            parameters[26].Value = model.C_REMARK;
            parameters[27].Value = model.C_REMARK2;
            parameters[28].Value = model.D_FAILURE;
            parameters[29].Value = model.C_ID;

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
            strSql.Append("delete from TMD_DISPATCH ");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)            };
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
            strSql.Append("delete from TMD_DISPATCH ");
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
        public Mod_TMD_DISPATCH GetModel(string C_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_PLAN_ID,C_GPS_NO,C_NO,C_CON_NO,D_DISP_DT,C_SHIPVIA,C_COMCAR,C_PATH,C_PATH_DESC,C_SEND_DEPT,C_BUSINESS_DEPT,C_BUSINESS_ID,C_IS_WIRESALE,N_IS_EXPORT,C_LIC_PLA_NO,C_ATSTATION,D_APPROVE_DT,D_CREATE_DT,C_APPROVE_ID,C_CREATE_ID,C_STATUS,C_EMP_ID,C_EMP_NAME,D_MOD_DT,C_GUID,C_IS_WIRESALE_ID,C_REMARK,C_REMARK2,D_FAILURE from TMD_DISPATCH ");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)            };
            parameters[0].Value = C_ID;

            Mod_TMD_DISPATCH model = new Mod_TMD_DISPATCH();
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
        public Mod_TMD_DISPATCH DataRowToModel(DataRow row)
        {
            Mod_TMD_DISPATCH model = new Mod_TMD_DISPATCH();
            if (row != null)
            {
                if (row["C_ID"] != null)
                {
                    model.C_ID = row["C_ID"].ToString();
                }
                if (row["C_PLAN_ID"] != null)
                {
                    model.C_PLAN_ID = row["C_PLAN_ID"].ToString();
                }
                if (row["C_GPS_NO"] != null)
                {
                    model.C_GPS_NO = row["C_GPS_NO"].ToString();
                }
                if (row["C_NO"] != null)
                {
                    model.C_NO = row["C_NO"].ToString();
                }
                if (row["C_CON_NO"] != null)
                {
                    model.C_CON_NO = row["C_CON_NO"].ToString();
                }
                if (row["D_DISP_DT"] != null && row["D_DISP_DT"].ToString() != "")
                {
                    model.D_DISP_DT = DateTime.Parse(row["D_DISP_DT"].ToString());
                }
                if (row["C_SHIPVIA"] != null)
                {
                    model.C_SHIPVIA = row["C_SHIPVIA"].ToString();
                }
                if (row["C_COMCAR"] != null)
                {
                    model.C_COMCAR = row["C_COMCAR"].ToString();
                }
                if (row["C_PATH"] != null)
                {
                    model.C_PATH = row["C_PATH"].ToString();
                }
                if (row["C_PATH_DESC"] != null)
                {
                    model.C_PATH_DESC = row["C_PATH_DESC"].ToString();
                }
                if (row["C_SEND_DEPT"] != null)
                {
                    model.C_SEND_DEPT = row["C_SEND_DEPT"].ToString();
                }
                if (row["C_BUSINESS_DEPT"] != null)
                {
                    model.C_BUSINESS_DEPT = row["C_BUSINESS_DEPT"].ToString();
                }
                if (row["C_BUSINESS_ID"] != null)
                {
                    model.C_BUSINESS_ID = row["C_BUSINESS_ID"].ToString();
                }
                if (row["C_IS_WIRESALE"] != null)
                {
                    model.C_IS_WIRESALE = row["C_IS_WIRESALE"].ToString();
                }
                if (row["N_IS_EXPORT"] != null && row["N_IS_EXPORT"].ToString() != "")
                {
                    model.N_IS_EXPORT = decimal.Parse(row["N_IS_EXPORT"].ToString());
                }
                if (row["C_LIC_PLA_NO"] != null)
                {
                    model.C_LIC_PLA_NO = row["C_LIC_PLA_NO"].ToString();
                }
                if (row["C_ATSTATION"] != null)
                {
                    model.C_ATSTATION = row["C_ATSTATION"].ToString();
                }
                if (row["D_APPROVE_DT"] != null && row["D_APPROVE_DT"].ToString() != "")
                {
                    model.D_APPROVE_DT = DateTime.Parse(row["D_APPROVE_DT"].ToString());
                }
                if (row["D_CREATE_DT"] != null && row["D_CREATE_DT"].ToString() != "")
                {
                    model.D_CREATE_DT = DateTime.Parse(row["D_CREATE_DT"].ToString());
                }
                if (row["C_APPROVE_ID"] != null)
                {
                    model.C_APPROVE_ID = row["C_APPROVE_ID"].ToString();
                }
                if (row["C_CREATE_ID"] != null)
                {
                    model.C_CREATE_ID = row["C_CREATE_ID"].ToString();
                }
                if (row["C_STATUS"] != null)
                {
                    model.C_STATUS = row["C_STATUS"].ToString();
                }
                if (row["C_EMP_ID"] != null)
                {
                    model.C_EMP_ID = row["C_EMP_ID"].ToString();
                }
                if (row["C_EMP_NAME"] != null)
                {
                    model.C_EMP_NAME = row["C_EMP_NAME"].ToString();
                }
                if (row["D_MOD_DT"] != null && row["D_MOD_DT"].ToString() != "")
                {
                    model.D_MOD_DT = DateTime.Parse(row["D_MOD_DT"].ToString());
                }
                if (row["C_GUID"] != null)
                {
                    model.C_GUID = row["C_GUID"].ToString();
                }
                if (row["C_IS_WIRESALE_ID"] != null)
                {
                    model.C_IS_WIRESALE_ID = row["C_IS_WIRESALE_ID"].ToString();
                }
                if (row["C_REMARK"] != null)
                {
                    model.C_REMARK = row["C_REMARK"].ToString();
                }
                if (row["C_REMARK2"] != null)
                {
                    model.C_REMARK2 = row["C_REMARK2"].ToString();
                }
                if (row["D_FAILURE"] != null && row["D_FAILURE"].ToString() != "")
                {
                    model.D_FAILURE = DateTime.Parse(row["D_FAILURE"].ToString());
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
            strSql.Append("select C_ID,C_PLAN_ID,C_GPS_NO,C_NO,C_CON_NO,D_DISP_DT,C_SHIPVIA,C_COMCAR,C_PATH,C_PATH_DESC,C_SEND_DEPT,C_BUSINESS_DEPT,C_BUSINESS_ID,C_IS_WIRESALE,N_IS_EXPORT,C_LIC_PLA_NO,C_ATSTATION,D_APPROVE_DT,D_CREATE_DT,C_APPROVE_ID,C_CREATE_ID,C_STATUS,C_EMP_ID,C_EMP_NAME,D_MOD_DT,C_GUID,C_IS_WIRESALE_ID,C_REMARK,C_REMARK2,D_FAILURE ");
            strSql.Append(" FROM TMD_DISPATCH ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM TMD_DISPATCH ");
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
            strSql.Append(")AS Row, T.*  from TMD_DISPATCH T ");
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
        /// 获取钢坯发运单
        /// </summary>
        /// <param name="C_ID">发运单号</param>
        /// <param name="dt1">时间1</param>
        /// <param name="dt2">时间2</param>
        /// <param name="status">状态</param>
        /// <returns></returns>
        public DataSet GetFYDList(string C_ID,DateTime dt1,DateTime dt2,string status)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT a.d_create_dt,a.c_id, b.C_MAT_CODE,b.C_STL_GRD,b.C_STD_CODE,b.C_SEND_STOCK_CODE,b.C_JUDGE_LEV_ZH,b.C_SPEC,b.N_FYZS N_NUM,b.N_FYWGT N_WGT,b.N_JWGT N_JWGT,c.SJSL FROM TMD_DISPATCH a INNER JOIN TMD_DISPATCHDETAILS b ON a.c_id=b.c_dispatch_id LEFT JOIN (SELECT COUNT(1) SJSL,C_FYDH  FROM TSC_SLAB_MAIN  WHERE C_MOVE_TYPE='1' GROUP BY C_FYDH )c ON c.c_Fydh=a.c_Id WHERE a.C_STATUS='" + status + "' ");
            strSql.Append(" AND a.d_create_dt >=TO_DATE('" + dt1 + "','YYYY-MM-DD HH24:MI:SS') ");
            strSql.Append(" and a.d_create_dt <=TO_DATE('" + dt2 + "','YYYY-MM-DD HH24:MI:SS') ");
            if (C_ID.Trim() != "")
            {
                strSql.Append(" AND a.C_ID='" + C_ID + "'");
            }
            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 通过发运单号获得出库详情
        /// </summary>
        /// <param name="status">状态1钢坯2线材</param>
        /// <param name="C_FYDH">出库单号</param>
        /// <returns></returns>
        public DataSet GetCKByCKDH(int status, string C_FYDH)
        {
            StringBuilder strSql = new StringBuilder();
            if (status == 1)
            {
                strSql.Append("SELECT A.C_CKDH,A.C_SEND_STOCK,A.D_CKSJ,A.C_STD_CODE,A.C_MAT_CODE,A.C_MAT_NAME,A.C_STL_GRD,A.C_SPEC,A.C_STOVE,A.N_NUM,A.N_JZ,A.C_DISPATCH_ID FROM TMD_DISPATCH_SJZJB A WHERE 1=1");
            }
            else
            {
                strSql.Append("SELECT A.C_CKDH,A.C_SEND_STOCK,A.D_CKSJ,A.C_STD_CODE,A.C_MAT_CODE,A.C_MAT_NAME,A.C_STL_GRD,A.C_SPEC,A.C_BATCH_NO,A.C_TICK_STR,A.N_NUM,A.N_JZ,A.C_DISPATCH_ID FROM TMD_DISPATCH_SJZJB A WHERE 1=1");
            }
            if (C_FYDH.Trim() != "")
            {
                strSql.Append(" AND A.C_DISPATCH_ID='" + C_FYDH + "'");
            }
            strSql.Append("GROUP BY a.c_id,b.C_STL_GRD,b.C_STD_CODE,b.C_SPEC,a.d_create_dt");
            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 获取钢坯出库单
        /// </summary>
        /// <param name="status">状态</param>
        /// <param name="ckdh">出库单号</param>
        /// <param name="cph">车牌号</param>
        /// <param name="fyfs">发运方式</param>
        /// <returns></returns>
        public DataSet GetCKDList(int status, string ckdh, string cph, string fyfs)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT A.C_CKDH,A.C_SEND_STOCK,A.D_CKSJ,A.C_STL_GRD,A.C_SPEC,A.C_STOVE,A.N_NUM,A.N_JZ,A.C_DISPATCH_ID,B.C_LIC_PLA_NO,D.C_CUST_NAME,D.C_TRANSMODE ,D.C_MAT_NAME,E.C_NAME AS C_CREATE_NAME,F.C_NAME AS C_APPROVE_NAME,B.D_APPROVE_DT,G.C_NAME FROM TMD_DISPATCH_SJZJB A INNER JOIN TMD_DISPATCH B ON A.C_DISPATCH_ID=B.C_ID INNER JOIN TMD_DISPATCHDETAILS C ON B.C_ID=C.C_DISPATCH_ID   INNER JOIN TMO_ORDER D ON C.C_NO=D.C_ORDER_NO INNER JOIN TS_USER E ON B.C_CREATE_ID=E.C_ID INNER JOIN TS_USER F ON B.C_APPROVE_ID=F.C_ID INNER JOIN TS_CUSTFILE G ON D.C_RECEIPTCORPID=G.C_NC_M_ID ");
            strSql.Append(" WHERE A.N_STATUS='" + status + "'");
            if (ckdh.Trim() != "")
            {
                strSql.Append(" AND A.C_DISPATCH_ID='" + ckdh + "'");
            }
            if (cph.Trim() != "")
            {
                strSql.Append(" AND B.C_LIC_PLA_NO='" + cph + "'");
            }
            if (fyfs.Trim() != "")
            {
                strSql.Append(" AND D.C_TRANSMODE='" + fyfs + "'");
            }
            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 根据状态和车牌号获取车牌号
        /// </summary>
        /// <param name="status">状态1钢坯2线材</param>
        /// <param name="cph">车牌号</param>
        /// <returns></returns>
        public DataSet GetCPH(int status, string cph)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT B.C_ID,B.C_LIC_PLA_NO,D.C_CUST_NAME,D.C_TRANSMODE FROM TMD_DISPATCH_SJZJB A INNER JOIN TMD_DISPATCH B ON A.C_DISPATCH_ID=B.C_ID INNER JOIN TMD_DISPATCHDETAILS C ON B.C_ID=C.C_DISPATCH_ID  INNER JOIN TMO_ORDER D ON C.C_NO=D.C_ORDER_NO  ");
            strSql.Append(" WHERE A.N_STATUS='" + status + "'");
            return DbHelperOra.Query(strSql.ToString());
        }

        #endregion  ExtensionMethod

    }
}