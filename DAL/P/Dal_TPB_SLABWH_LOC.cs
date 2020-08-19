using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;
namespace DAL
{
    /// <summary>
    /// 数据访问类:TPB_SLABWH_LOC
    /// </summary>
    public partial class Dal_TPB_SLABWH_LOC
    {
        public Dal_TPB_SLABWH_LOC()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string C_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TPB_SLABWH_LOC");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)          };
            parameters[0].Value = C_ID;

            return DbHelperOra.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Mod_TPB_SLABWH_LOC model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TPB_SLABWH_LOC(");
            strSql.Append("C_SLABWH_AREA_ID,C_SLABWH_LOC_CODE,C_SLABWH_LOC_NAME,N_SLABWH_LOC_CAP,N_SLABWH_TIER,D_END_DATE,C_REMARK,C_EMP_ID,C_SLAB_TYPE,C_SLABWH_TYPE)");
            strSql.Append(" values (");
            strSql.Append(":C_SLABWH_AREA_ID,:C_SLABWH_LOC_CODE,:C_SLABWH_LOC_NAME,:N_SLABWH_LOC_CAP,:N_SLABWH_TIER,:D_END_DATE,:C_REMARK,:C_EMP_ID,:C_SLAB_TYPE,:C_SLABWH_TYPE)");
            OracleParameter[] parameters = {

                    new OracleParameter(":C_SLABWH_AREA_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SLABWH_LOC_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SLABWH_LOC_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_SLABWH_LOC_CAP", OracleDbType.Double,15),
                    new OracleParameter(":N_SLABWH_TIER", OracleDbType.Decimal,3),
                    new OracleParameter(":D_END_DATE", OracleDbType.Date),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,200),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SLAB_TYPE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SLABWH_TYPE", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.C_SLABWH_AREA_ID;
            parameters[1].Value = model.C_SLABWH_LOC_CODE;
            parameters[2].Value = model.C_SLABWH_LOC_NAME;
            parameters[3].Value = model.N_SLABWH_LOC_CAP;
            parameters[4].Value = model.N_SLABWH_TIER;
            parameters[5].Value = model.D_END_DATE;
            parameters[6].Value = model.C_REMARK;
            parameters[7].Value = model.C_EMP_ID;
            parameters[8].Value = model.C_SLAB_TYPE;
            parameters[9].Value = model.C_SLABWH_TYPE;
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
        public bool Update(Mod_TPB_SLABWH_LOC model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TPB_SLABWH_LOC set ");
            strSql.Append("C_SLABWH_AREA_ID=:C_SLABWH_AREA_ID,");
            strSql.Append("C_SLABWH_LOC_CODE=:C_SLABWH_LOC_CODE,");
            strSql.Append("C_SLABWH_LOC_NAME=:C_SLABWH_LOC_NAME,");
            strSql.Append("N_SLABWH_LOC_CAP=:N_SLABWH_LOC_CAP,");
            strSql.Append("N_SLABWH_TIER=:N_SLABWH_TIER,");
            strSql.Append("D_START_DATE=:D_START_DATE,");
            strSql.Append("D_END_DATE=:D_END_DATE,");
            strSql.Append("N_STATUS=:N_STATUS,");
            strSql.Append("C_REMARK=:C_REMARK,");
            strSql.Append("C_EMP_ID=:C_EMP_ID,");
            strSql.Append("D_MOD_DT=:D_MOD_DT,");
            strSql.Append("C_SLAB_TYPE=:C_SLAB_TYPE,");
            strSql.Append("C_SLABWH_TYPE=:C_SLABWH_TYPE");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_SLABWH_AREA_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SLABWH_LOC_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SLABWH_LOC_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_SLABWH_LOC_CAP", OracleDbType.Double,15),
                    new OracleParameter(":N_SLABWH_TIER", OracleDbType.Decimal,3),
                    new OracleParameter(":D_START_DATE", OracleDbType.Date),
                    new OracleParameter(":D_END_DATE", OracleDbType.Date),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,200),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":C_SLAB_TYPE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SLABWH_TYPE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.C_SLABWH_AREA_ID;
            parameters[1].Value = model.C_SLABWH_LOC_CODE;
            parameters[2].Value = model.C_SLABWH_LOC_NAME;
            parameters[3].Value = model.N_SLABWH_LOC_CAP;
            parameters[4].Value = model.N_SLABWH_TIER;
            parameters[5].Value = model.D_START_DATE;
            parameters[6].Value = model.D_END_DATE;
            parameters[7].Value = model.N_STATUS;
            parameters[8].Value = model.C_REMARK;
            parameters[9].Value = model.C_EMP_ID;
            parameters[10].Value = model.D_MOD_DT;
            parameters[11].Value = model.C_SLAB_TYPE;
            parameters[12].Value = model.C_SLABWH_TYPE;
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
            strSql.Append("delete from TPB_SLABWH_LOC ");
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
            strSql.Append("delete from TPB_SLABWH_LOC ");
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
        public Mod_TPB_SLABWH_LOC GetModel(string C_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_SLABWH_AREA_ID,C_SLABWH_LOC_CODE,C_SLABWH_LOC_NAME,N_SLABWH_LOC_CAP,N_SLABWH_TIER,D_START_DATE,D_END_DATE,N_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT,C_SLAB_TYPE,C_SLABWH_TYPE from TPB_SLABWH_LOC ");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)         };
            parameters[0].Value = C_ID;

            Mod_TPB_SLABWH_LOC model = new Mod_TPB_SLABWH_LOC();
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
        public Mod_TPB_SLABWH_LOC DataRowToModel(DataRow row)
        {
            Mod_TPB_SLABWH_LOC model = new Mod_TPB_SLABWH_LOC();
            if (row != null)
            {
                if (row["C_ID"] != null)
                {
                    model.C_ID = row["C_ID"].ToString();
                }
                if (row["C_SLABWH_AREA_ID"] != null)
                {
                    model.C_SLABWH_AREA_ID = row["C_SLABWH_AREA_ID"].ToString();
                }
                if (row["C_SLABWH_LOC_CODE"] != null)
                {
                    model.C_SLABWH_LOC_CODE = row["C_SLABWH_LOC_CODE"].ToString();
                }
                if (row["C_SLABWH_LOC_NAME"] != null)
                {
                    model.C_SLABWH_LOC_NAME = row["C_SLABWH_LOC_NAME"].ToString();
                }
                if (row["N_SLABWH_LOC_CAP"] != null && row["N_SLABWH_LOC_CAP"].ToString() != "")
                {
                    model.N_SLABWH_LOC_CAP = decimal.Parse(row["N_SLABWH_LOC_CAP"].ToString());
                }
                if (row["N_SLABWH_TIER"] != null && row["N_SLABWH_TIER"].ToString() != "")
                {
                    model.N_SLABWH_TIER = decimal.Parse(row["N_SLABWH_TIER"].ToString());
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
                if (row["C_SLABWH_TYPE"] != null)
                {
                    model.C_SLABWH_TYPE = row["C_SLABWH_TYPE"].ToString();
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
            strSql.Append("select C_ID,C_SLABWH_AREA_ID,C_SLABWH_LOC_CODE,C_SLABWH_LOC_NAME,N_SLABWH_LOC_CAP,N_SLABWH_TIER,D_START_DATE,D_END_DATE,DECODE(N_STATUS,1,'启用','停用') N_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT,C_SLAB_TYPE,C_SLABWH_TYPE ");
            strSql.Append(" FROM TPB_SLABWH_LOC ");
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
            strSql.Append("select count(1) FROM TPB_SLABWH_LOC ");
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
            strSql.Append(")AS Row, T.*  from TPB_SLABWH_LOC T ");
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
        /// 通过代码获取名称
        /// </summary>
        /// <param name="strAreaID"></param>
        /// <returns></returns>
        public Mod_TPB_SLABWH_LOC GetNameByCode(string Code)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_SLABWH_AREA_ID,C_SLABWH_LOC_CODE,C_SLABWH_LOC_NAME,N_SLABWH_LOC_CAP,N_SLABWH_TIER,D_START_DATE,D_END_DATE,N_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT,C_SLAB_TYPE,C_SLABWH_TYPE from TPB_SLABWH_LOC ");
            strSql.Append(" where C_SLABWH_LOC_CODE=:C_SLABWH_LOC_CODE ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_SLABWH_LOC_CODE", OracleDbType.Varchar2,100)         };
            parameters[0].Value = Code;

            Mod_TPB_SLABWH_LOC model = new Mod_TPB_SLABWH_LOC();
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
        /// 通过区域获取数据列表
        /// </summary>
        /// <param name="strAreaID"></param>
        /// <param name="iStatus"></param>
        /// <returns></returns>
        public DataSet GetListByArea(string strAreaID, int iStatus)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_SLABWH_AREA_ID,C_SLABWH_LOC_CODE,C_SLABWH_LOC_NAME,N_SLABWH_LOC_CAP,N_SLABWH_TIER,D_START_DATE,D_END_DATE,DECODE(N_STATUS,1,'启用','停用') N_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT,C_SLAB_TYPE,C_SLABWH_TYPE ");
            strSql.Append(" FROM TPB_SLABWH_LOC where N_STATUS='" + iStatus + "' ");
            if (strAreaID.Trim() != "")
            {
                strSql.Append(" AND C_SLABWH_AREA_ID='" + strAreaID + "'");
            }
            strSql.Append(" ORDER BY to_number(C_SLABWH_LOC_CODE) ");
            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 通过库位编码获取数据
        /// </summary>
        /// <param name="strLOCCODE">库位编码</param>
        /// <param name="iStatus">状态</param>
        /// <returns></returns>
        public DataSet GetListByLOCCODE(string strLOCCODE, int iStatus)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_SLABWH_AREA_ID,C_SLABWH_LOC_CODE,C_SLABWH_LOC_NAME,N_SLABWH_LOC_CAP,N_SLABWH_TIER,D_START_DATE,D_END_DATE,DECODE(N_STATUS,1,'启用','停用') N_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT,C_SLAB_TYPE,C_SLABWH_TYPE ");
            strSql.Append(" FROM TPB_SLABWH_LOC where 1=1 ");
            if (strLOCCODE.Trim() != "")
            {
                strSql.Append(" and C_SLABWH_LOC_CODE=:C_SLABWH_LOC_CODE");
            }

            if (iStatus.ToString().Trim() != "")
            {
                strSql.Append(" AND N_STATUS=:N_STATUS");
            }
            OracleParameter[] parameters = {
                    new OracleParameter(":C_SLABWH_LOC_CODE", OracleDbType.Varchar2,100) ,
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,3)         };
            parameters[0].Value = strLOCCODE;
            parameters[1].Value = iStatus;
            return DbHelperOra.Query(strSql.ToString(), parameters);
        }
        /// <summary>
        /// 通过库位编码获取数据
        /// </summary>
        /// <param name="strLOCCODE">库位编码</param> 
        /// <returns></returns>
        public DataSet GetList_LocCode(string strLOCCODE)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_SLABWH_AREA_ID,C_SLABWH_LOC_CODE,C_SLABWH_LOC_NAME,N_SLABWH_LOC_CAP,N_SLABWH_TIER,D_START_DATE,D_END_DATE,DECODE(N_STATUS,1,'启用','停用') N_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT,C_SLAB_TYPE,C_SLABWH_TYPE ");
            strSql.Append(" FROM TPB_SLABWH_LOC where N_STATUS=1 ");
            if (strLOCCODE.Trim() != "")
            {
                strSql.Append(" and C_SLABWH_LOC_CODE= '" + strLOCCODE + "'");
            }

            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 通过库位编码获取数据
        /// </summary>
        /// <param name="locCode">库位编码</param>
        /// <param name="iStatus">状态</param>
        /// <returns></returns>
        public object GetListByLocID(string locCode, int iStatus)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  C_ID ");
            strSql.Append(" FROM TPB_SLABWH_LOC ");
            if (locCode.Trim() != "")
            {
                strSql.Append(" where C_SLABWH_LOC_CODE=:C_SLABWH_LOC_CODE");
            }

            if (iStatus.ToString().Trim() != "")
            {
                strSql.Append(" AND N_STATUS=:N_STATUS");
            }
            OracleParameter[] parameters = {
                    new OracleParameter(":C_SLABWH_LOC_CODE", OracleDbType.Varchar2,100) ,
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,3)         };
            parameters[0].Value = locCode;
            parameters[1].Value = iStatus;
            return DbHelperOra.GetSingle(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList_ID(string C_SLABWH_LOC_CODE, string C_SLABWH_LOC_NAME)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_SLABWH_AREA_ID,C_SLABWH_LOC_CODE,C_SLABWH_LOC_NAME ");
            strSql.Append(" FROM TPB_SLABWH_LOC where 1=1 ");
            if (C_SLABWH_LOC_CODE.Trim() != "")
            {
                strSql.Append(" and C_SLABWH_LOC_CODE= '" + C_SLABWH_LOC_CODE + "'");
            }
            if (C_SLABWH_LOC_NAME.Trim() != "")
            {
                strSql.Append(" and C_SLABWH_LOC_NAME= '" + C_SLABWH_LOC_NAME + "'");
            }
            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 通过区域获取数据列表
        /// </summary>
        /// <param name="c_slabwh_code">仓库编码</param> 
        /// <param name="C_SLABWH_LOC_CODE">区域编码</param>
        /// <returns></returns>
        public DataSet Get_List(string c_slabwh_code, string C_SLABWH_LOC_CODE)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select DECODE(a.cou,'',0,a.cou)cou,(t.N_SLABWH_LOC_CAP - to_number(DECODE(a.cou, '', 0, a.cou)))nu,  b.c_slabwh_area_code,  b.c_slabwh_area_name, c.c_slabwh_code, c.c_slabwh_name,   t.C_SLABWH_LOC_CODE, t.C_SLABWH_LOC_NAME, t.N_SLABWH_LOC_CAP,  t.N_SLABWH_TIER, t.C_SLAB_TYPE, t.C_SLABWH_TYPE ");
            strSql.Append(" FROM TPB_SLABWH_LOC t left join (select count(1) cou, s.C_SLABWH_LOC_CODE   from tsc_slab_main s  where s.c_move_type ='E'   group by s.C_SLABWH_LOC_CODE)a   on t.c_slabwh_loc_code = a.c_slabwh_loc_code join tpb_slabwh_area b on t.c_slabwh_area_id = b.c_id join tpb_slabwh c on b.c_slabwh_id = c.c_id where t.n_status=1  ");
            if (c_slabwh_code.Trim() != "")
            {
                strSql.Append(" AND c.c_slabwh_code='" + c_slabwh_code + "'");
            }

            if (C_SLABWH_LOC_CODE.Trim().Length > 0)
            {
                strSql.Append(" AND t.C_SLABWH_LOC_CODE not in (" + C_SLABWH_LOC_CODE.Substring(0, C_SLABWH_LOC_CODE.Length - 1) + ") ");
            }
            strSql.Append(" ORDER BY T.C_SLABWH_LOC_CODE");
            return DbHelperOra.Query(strSql.ToString());
        }


        /// <summary>
        /// 获取记录总数
        /// </summary>
        public DataSet Get_CAP(string C_SLABWH_CODE)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT T.C_SLABWH_LOC_CODE,T.N_SLABWH_LOC_CAP FROM TPB_SLABWH_LOC T INNER JOIN TPB_SLABWH_AREA TB ON T.C_SLABWH_AREA_ID=TB.C_ID INNER JOIN TPB_SLABWH TC ON TC.C_ID=TB.C_SLABWH_ID WHERE TC.C_SLABWH_CODE='" + C_SLABWH_CODE + "' and t.n_status = 1 ");

            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        /// <param name="c_slabwh_code">仓库编码</param>
        /// <param name="c_slabwh_area_code">库位编码</param>
        /// <param name="C_SLABWH_TYPE">库位类型</param>
        /// <returns></returns>
        public DataSet GetList_count(string c_slabwh_code, string c_slabwh_area_code, string C_SLABWH_TYPE)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select DECODE(a.cou,'',0,a.cou)cou,(t.N_SLABWH_LOC_CAP - to_number(DECODE(a.cou, '', 0, a.cou)))nu,  b.c_slabwh_area_code,  b.c_slabwh_area_name, c.c_slabwh_code, c.c_slabwh_name,   t.C_SLABWH_LOC_CODE, t.C_SLABWH_LOC_NAME, t.N_SLABWH_LOC_CAP,  t.N_SLABWH_TIER, t.C_SLAB_TYPE, t.C_SLABWH_TYPE  ");
            strSql.Append(" FROM TPB_SLABWH_LOC t left join (select count(1) cou, s.C_SLABWH_LOC_CODE   from tsc_slab_main s  where s.c_move_type ='E'   group by s.C_SLABWH_LOC_CODE)a   on t.c_slabwh_loc_code = a.c_slabwh_loc_code join tpb_slabwh_area b on t.c_slabwh_area_id = b.c_id join tpb_slabwh c on b.c_slabwh_id = c.c_id where t.n_status=1  ");
            if (c_slabwh_code.Trim() != "全部")
            {
                strSql.Append(" AND c.c_slabwh_code='" + c_slabwh_code + "' ");
            }

            if (c_slabwh_area_code.Trim() != "全部")
            {
                strSql.Append(" AND b.c_slabwh_area_code='" + c_slabwh_area_code + "' ");
            }
            if (C_SLABWH_TYPE.Trim() != "")
            {
                strSql.Append(" AND t.C_SLABWH_TYPE='" + C_SLABWH_TYPE + "' ");
            }

            strSql.Append(" ORDER BY T.C_SLABWH_LOC_CODE");
            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 通过库位编码获取数据
        /// </summary>
        /// <param name="strLOCCODE">库位编码</param> 
        /// <returns></returns>
        public DataSet GetLocByCODEL()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_SLABWH_AREA_ID,C_SLABWH_LOC_CODE,C_SLABWH_LOC_NAME,N_SLABWH_LOC_CAP,N_SLABWH_TIER,D_START_DATE,D_END_DATE,DECODE(N_STATUS,1,'启用','停用') N_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT,C_SLAB_TYPE,C_SLABWH_TYPE ");
            strSql.Append(" FROM TPB_SLABWH_LOC where N_STATUS=1 AND ( C_SLABWH_LOC_CODE LIKE '53509%' OR C_SLABWH_LOC_CODE LIKE '514%') AND  C_SLABWH_LOC_NAME NOT IN('501','502','503','504','505','506','507','508','509','510','出炉口','平台上','601','602','603','门东','门西','直上区')  ORDER BY C_SLABWH_LOC_CODE");
            return DbHelperOra.Query(strSql.ToString());
        }
        #endregion  ExtensionMethod
    }
}

