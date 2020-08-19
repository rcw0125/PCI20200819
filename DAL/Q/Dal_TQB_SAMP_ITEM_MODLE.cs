using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;

namespace DAL
{
    /// <summary>
    /// 数据访问类:TQB_SAMP_ITEM_MODLE
    /// </summary>
    public partial class Dal_TQB_SAMP_ITEM_MODLE
    {
        public Dal_TQB_SAMP_ITEM_MODLE()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string C_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TQB_SAMP_ITEM_MODLE");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)         };
            parameters[0].Value = C_ID;

            return DbHelperOra.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Mod_TQB_SAMP_ITEM_MODLE model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TQB_SAMP_ITEM_MODLE(");
            strSql.Append("C_SAMP_MODLE_ID,C_SAMPLES_ID,C_SAM_NUM,N_STATUS,C_EMP_ID,D_MOD_DT,C_SAMPLES_NAME)");
            strSql.Append(" values (");
            strSql.Append(":C_SAMP_MODLE_ID,:C_SAMPLES_ID,:C_SAM_NUM,:N_STATUS,:C_EMP_ID,:D_MOD_DT,:C_SAMPLES_NAME)");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_SAMP_MODLE_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SAMPLES_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SAM_NUM", OracleDbType.Varchar2,500),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":C_SAMPLES_NAME", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.C_SAMP_MODLE_ID;
            parameters[1].Value = model.C_SAMPLES_ID;
            parameters[2].Value = model.C_SAM_NUM;
            parameters[3].Value = model.N_STATUS;
            parameters[4].Value = model.C_EMP_ID;
            parameters[5].Value = model.D_MOD_DT;
            parameters[6].Value = model.C_SAMPLES_NAME;

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
        /// 增加一条数据
        /// </summary>
        public bool Add_Trans(Mod_TQB_SAMP_ITEM_MODLE model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TQB_SAMP_ITEM_MODLE(");
            strSql.Append("C_SAMP_MODLE_ID,C_SAMPLES_ID,C_SAM_NUM,N_STATUS,C_EMP_ID,D_MOD_DT,C_SAMPLES_NAME)");
            strSql.Append(" values (");
            strSql.Append(":C_SAMP_MODLE_ID,:C_SAMPLES_ID,:C_SAM_NUM,:N_STATUS,:C_EMP_ID,:D_MOD_DT,:C_SAMPLES_NAME)");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_SAMP_MODLE_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SAMPLES_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SAM_NUM", OracleDbType.Varchar2,500),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":C_SAMPLES_NAME", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.C_SAMP_MODLE_ID;
            parameters[1].Value = model.C_SAMPLES_ID;
            parameters[2].Value = model.C_SAM_NUM;
            parameters[3].Value = model.N_STATUS;
            parameters[4].Value = model.C_EMP_ID;
            parameters[5].Value = model.D_MOD_DT;
            parameters[6].Value = model.C_SAMPLES_NAME;

            int rows = TransactionHelper.ExecuteSql(strSql.ToString(), parameters);
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
        public bool Update(Mod_TQB_SAMP_ITEM_MODLE model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TQB_SAMP_ITEM_MODLE set ");
            strSql.Append("C_SAMP_MODLE_ID=:C_SAMP_MODLE_ID,");
            strSql.Append("C_SAMPLES_ID=:C_SAMPLES_ID,");
            strSql.Append("C_SAM_NUM=:C_SAM_NUM,");
            strSql.Append("N_STATUS=:N_STATUS,");
            strSql.Append("C_EMP_ID=:C_EMP_ID,");
            strSql.Append("D_MOD_DT=:D_MOD_DT,");
            strSql.Append("C_SAMPLES_NAME=:C_SAMPLES_NAME");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_SAMP_MODLE_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SAMPLES_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SAM_NUM", OracleDbType.Varchar2,500),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":C_SAMPLES_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.C_SAMP_MODLE_ID;
            parameters[1].Value = model.C_SAMPLES_ID;
            parameters[2].Value = model.C_SAM_NUM;
            parameters[3].Value = model.N_STATUS;
            parameters[4].Value = model.C_EMP_ID;
            parameters[5].Value = model.D_MOD_DT;
            parameters[6].Value = model.C_SAMPLES_NAME;
            parameters[7].Value = model.C_ID;

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
            strSql.Append("delete from TQB_SAMP_ITEM_MODLE ");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)         };
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
            strSql.Append("delete from TQB_SAMP_ITEM_MODLE ");
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
        public Mod_TQB_SAMP_ITEM_MODLE GetModel(string C_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_SAMP_MODLE_ID,C_SAMPLES_ID,C_SAM_NUM,N_STATUS,C_EMP_ID,D_MOD_DT,C_SAMPLES_NAME from TQB_SAMP_ITEM_MODLE ");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)         };
            parameters[0].Value = C_ID;

            Mod_TQB_SAMP_ITEM_MODLE model = new Mod_TQB_SAMP_ITEM_MODLE();
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
        public Mod_TQB_SAMP_ITEM_MODLE DataRowToModel(DataRow row)
        {
            Mod_TQB_SAMP_ITEM_MODLE model = new Mod_TQB_SAMP_ITEM_MODLE();
            if (row != null)
            {
                if (row["C_ID"] != null)
                {
                    model.C_ID = row["C_ID"].ToString();
                }
                if (row["C_SAMP_MODLE_ID"] != null)
                {
                    model.C_SAMP_MODLE_ID = row["C_SAMP_MODLE_ID"].ToString();
                }
                if (row["C_SAMPLES_ID"] != null)
                {
                    model.C_SAMPLES_ID = row["C_SAMPLES_ID"].ToString();
                }
                if (row["C_SAM_NUM"] != null)
                {
                    model.C_SAM_NUM = row["C_SAM_NUM"].ToString();
                }
                if (row["N_STATUS"] != null && row["N_STATUS"].ToString() != "")
                {
                    model.N_STATUS = decimal.Parse(row["N_STATUS"].ToString());
                }
                if (row["C_EMP_ID"] != null)
                {
                    model.C_EMP_ID = row["C_EMP_ID"].ToString();
                }
                if (row["D_MOD_DT"] != null && row["D_MOD_DT"].ToString() != "")
                {
                    model.D_MOD_DT = DateTime.Parse(row["D_MOD_DT"].ToString());
                }
                if (row["C_SAMPLES_NAME"] != null)
                {
                    model.C_SAMPLES_NAME = row["C_SAMPLES_NAME"].ToString();
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
            strSql.Append("select C_ID,C_SAMP_MODLE_ID,C_SAMPLES_ID,C_SAM_NUM,N_STATUS,C_EMP_ID,D_MOD_DT,C_SAMPLES_NAME ");
            strSql.Append(" FROM TQB_SAMP_ITEM_MODLE ");
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
            strSql.Append("select count(1) FROM TQB_SAMP_ITEM_MODLE ");
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
            strSql.Append(")AS Row, T.*  from TQB_SAMP_ITEM_MODLE T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 按标准，钢种，规格查询取样模板信息
        /// </summary>
        /// <param name="P_STD_CODE">标准</param>
        /// <param name="P_STL_GRD">钢种</param>
        /// <param name="P_SPEC_MIN">规格最小值</param>
        /// <param name="P_SPEC_MAX">规格最大值</param>
        /// <returns></returns>
		public DataSet Get_Model_List(string P_STD_CODE, string P_STL_GRD, string P_SPEC_MIN, string P_SPEC_MAX)
        {
            OracleParameter[] parameters = {
                    new OracleParameter("P_STD_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter("P_STL_GRD", OracleDbType.Varchar2,100),
                    new OracleParameter("P_SPEC_MIN", OracleDbType.Varchar2,100),
                    new OracleParameter("P_SPEC_MAX", OracleDbType.Varchar2,100),
                    new OracleParameter("P_CUR", OracleDbType.RefCursor)};

            parameters[0].Value = P_STD_CODE;
            parameters[1].Value = P_STL_GRD;
            parameters[2].Value = P_SPEC_MIN;
            parameters[3].Value = P_SPEC_MAX;
            parameters[4].Value = null;

            return DbHelperOra.RunProcedure("PKG_XN.P_SAMP_MODLE", parameters, "ds");
        }

        #endregion  BasicMethod

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update_Trans(string c_std_code, string c_stl_grd, string c_spec_min, string c_spec_max)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update tqb_samp_item_modle t set t.n_status=0 where t.c_samp_modle_id in(select ta.c_id from tqb_samp_modle ta where ta.c_std_code = '" + c_std_code + "' and ta.c_stl_grd = '" + c_stl_grd + "' and nvl(ta.c_spec_min,' ')=nvl('" + c_spec_min + "',' ') and nvl(ta.c_spec_max,' ')=nvl('" + c_spec_max + "',' ') ) ");

            int rows = TransactionHelper.ExecuteSql(strSql.ToString());
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
        public bool Update_Trans(string C_SAMP_MODLE_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update tqb_samp_item_modle t set t.n_status=0 where t.c_samp_modle_id='" + C_SAMP_MODLE_ID + "' ");

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
        /// 获取取样明细信息
        /// </summary>
        /// <param name="C_STD_CODE">标准</param>
        /// <param name="C_STL_GRD">钢种</param>
        /// <param name="C_SPEC">规格</param>
        /// <returns></returns>
        public DataSet Get_ITEM_List(string C_STD_CODE, string C_STL_GRD, string C_SPEC)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT TM.C_STD_CODE, TM.C_STL_GRD, TM.C_SAMPLES_NAME, TM.C_SAM_NUM FROM(SELECT TA.C_STD_CODE, TA.C_STL_GRD, TB.C_SAMPLES_NAME, TO_CHAR(SUM(TB.C_SAM_NUM)) AS C_SAM_NUM, TB.C_SAMPLES_ID FROM TQB_SAMP_MODLE TA INNER JOIN TQB_SAMP_ITEM_MODLE TB ON TA.C_ID = TB.C_SAMP_MODLE_ID WHERE TB.C_SAMPLES_NAME NOT LIKE '备注%' AND TA.N_STATUS = 1 AND TB.N_STATUS = 1 AND TA.C_STD_CODE='" + C_STD_CODE + "' AND TA.C_STL_GRD='" + C_STL_GRD + "' AND TO_NUMBER(NVL(TA.C_SPEC_MIN, '0')) <= " + C_SPEC + " AND TO_NUMBER(NVL(TA.C_SPEC_MAX, '999')) >= " + C_SPEC + " GROUP BY TA.C_STD_CODE, TA.C_STL_GRD, TB.C_SAMPLES_NAME, TB.C_SAMPLES_ID UNION ALL SELECT TA.C_STD_CODE, TA.C_STL_GRD, TB.C_SAMPLES_NAME, TB.C_SAM_NUM, TB.C_SAMPLES_ID FROM TQB_SAMP_MODLE TA INNER JOIN TQB_SAMP_ITEM_MODLE TB ON TA.C_ID = TB.C_SAMP_MODLE_ID WHERE TB.C_SAMPLES_NAME LIKE '备注%' AND TA.N_STATUS = 1 AND TB.N_STATUS = 1 AND TA.C_STD_CODE = '" + C_STD_CODE + "' AND TA.C_STL_GRD = '" + C_STL_GRD + "' AND TO_NUMBER(NVL(TA.C_SPEC_MIN, '0')) <= " + C_SPEC + " AND TO_NUMBER(NVL(TA.C_SPEC_MAX, '999')) >= " + C_SPEC + " ) TM INNER JOIN TQB_SAMPLING TL ON TM.C_SAMPLES_ID = TL.C_ID ORDER BY TL.N_SAMPLING_SN    ");

            return DbHelperOra.Query(strSql.ToString());
        }

    }
}

