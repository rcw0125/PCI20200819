using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;
namespace DAL
{
    /// <summary>
    /// 数据访问类:TQB_STD_SAMPLING
    /// </summary>
    public partial class Dal_TQB_STD_SAMPLING
    {
        public Dal_TQB_STD_SAMPLING()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string C_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TQB_STD_SAMPLING");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)          };
            parameters[0].Value = C_ID;

            return DbHelperOra.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Mod_TQB_STD_SAMPLING model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TQB_STD_SAMPLING(");
            strSql.Append("C_STD_MAIN_ID,C_SAMPLING_ID,C_NUMBER,C_SAM_SPE,C_SAM_LEN,C_SAM_METHOD,C_SAM_NUM,C_RECHECK_NUM,C_NUM_UNIT,C_SAM_SECTION,C_TEST_UNIT,N_STATUS,C_REMARK,C_EMP_ID)");
            strSql.Append(" values (");
            strSql.Append(":C_STD_MAIN_ID,:C_SAMPLING_ID,:C_NUMBER,:C_SAM_SPE,:C_SAM_LEN,:C_SAM_METHOD,:C_SAM_NUM,:C_RECHECK_NUM,:C_NUM_UNIT,:C_SAM_SECTION,:C_TEST_UNIT,:N_STATUS,:C_REMARK,:C_EMP_ID)");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_STD_MAIN_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SAMPLING_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_NUMBER", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SAM_SPE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SAM_LEN", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SAM_METHOD", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SAM_NUM", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_RECHECK_NUM", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_NUM_UNIT", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SAM_SECTION", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_TEST_UNIT", OracleDbType.Varchar2,500),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.C_STD_MAIN_ID;
            parameters[1].Value = model.C_SAMPLING_ID;
            parameters[2].Value = model.C_NUMBER;
            parameters[3].Value = model.C_SAM_SPE;
            parameters[4].Value = model.C_SAM_LEN;
            parameters[5].Value = model.C_SAM_METHOD;
            parameters[6].Value = model.C_SAM_NUM;
            parameters[7].Value = model.C_RECHECK_NUM;
            parameters[8].Value = model.C_NUM_UNIT;
            parameters[9].Value = model.C_SAM_SECTION;
            parameters[10].Value = model.C_TEST_UNIT;
            parameters[11].Value = model.N_STATUS;
            parameters[12].Value = model.C_REMARK;
            parameters[13].Value = model.C_EMP_ID;

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
        public bool Update(Mod_TQB_STD_SAMPLING model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TQB_STD_SAMPLING set ");
            strSql.Append("C_STD_MAIN_ID=:C_STD_MAIN_ID,");
            strSql.Append("C_SAMPLING_ID=:C_SAMPLING_ID,");
            strSql.Append("C_NUMBER=:C_NUMBER,");
            strSql.Append("C_SAM_SPE=:C_SAM_SPE,");
            strSql.Append("C_SAM_LEN=:C_SAM_LEN,");
            strSql.Append("C_SAM_METHOD=:C_SAM_METHOD,");
            strSql.Append("C_SAM_NUM=:C_SAM_NUM,");
            strSql.Append("C_RECHECK_NUM=:C_RECHECK_NUM,");
            strSql.Append("C_NUM_UNIT=:C_NUM_UNIT,");
            strSql.Append("C_SAM_SECTION=:C_SAM_SECTION,");
            strSql.Append("C_TEST_UNIT=:C_TEST_UNIT,");
            strSql.Append("N_STATUS=:N_STATUS,");
            strSql.Append("C_REMARK=:C_REMARK,");
            strSql.Append("C_EMP_ID=:C_EMP_ID,");
            strSql.Append("D_MOD_DT=:D_MOD_DT");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_STD_MAIN_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SAMPLING_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_NUMBER", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SAM_SPE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SAM_LEN", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SAM_METHOD", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SAM_NUM", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_RECHECK_NUM", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_NUM_UNIT", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SAM_SECTION", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_TEST_UNIT", OracleDbType.Varchar2,500),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.C_STD_MAIN_ID;
            parameters[1].Value = model.C_SAMPLING_ID;
            parameters[2].Value = model.C_NUMBER;
            parameters[3].Value = model.C_SAM_SPE;
            parameters[4].Value = model.C_SAM_LEN;
            parameters[5].Value = model.C_SAM_METHOD;
            parameters[6].Value = model.C_SAM_NUM;
            parameters[7].Value = model.C_RECHECK_NUM;
            parameters[8].Value = model.C_NUM_UNIT;
            parameters[9].Value = model.C_SAM_SECTION;
            parameters[10].Value = model.C_TEST_UNIT;
            parameters[11].Value = model.N_STATUS;
            parameters[12].Value = model.C_REMARK;
            parameters[13].Value = model.C_EMP_ID;
            parameters[14].Value = model.D_MOD_DT;
            parameters[15].Value = model.C_ID;

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
            strSql.Append("delete from TQB_STD_SAMPLING ");
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
            strSql.Append("delete from TQB_STD_SAMPLING ");
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
        public Mod_TQB_STD_SAMPLING GetModel(string C_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_STD_MAIN_ID,C_SAMPLING_ID,C_NUMBER,C_SAM_SPE,C_SAM_LEN,C_SAM_METHOD,C_SAM_NUM,C_RECHECK_NUM,C_NUM_UNIT,C_SAM_SECTION,C_TEST_UNIT,N_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT from TQB_STD_SAMPLING ");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)          };
            parameters[0].Value = C_ID;

            Mod_TQB_STD_SAMPLING model = new Mod_TQB_STD_SAMPLING();
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
        public Mod_TQB_STD_SAMPLING DataRowToModel(DataRow row)
        {
            Mod_TQB_STD_SAMPLING model = new Mod_TQB_STD_SAMPLING();
            if (row != null)
            {
                if (row["C_ID"] != null)
                {
                    model.C_ID = row["C_ID"].ToString();
                }
                if (row["C_STD_MAIN_ID"] != null)
                {
                    model.C_STD_MAIN_ID = row["C_STD_MAIN_ID"].ToString();
                }
                if (row["C_SAMPLING_ID"] != null)
                {
                    model.C_SAMPLING_ID = row["C_SAMPLING_ID"].ToString();
                }
                if (row["C_NUMBER"] != null)
                {
                    model.C_NUMBER = row["C_NUMBER"].ToString();
                }
                if (row["C_SAM_SPE"] != null)
                {
                    model.C_SAM_SPE = row["C_SAM_SPE"].ToString();
                }
                if (row["C_SAM_LEN"] != null)
                {
                    model.C_SAM_LEN = row["C_SAM_LEN"].ToString();
                }
                if (row["C_SAM_METHOD"] != null)
                {
                    model.C_SAM_METHOD = row["C_SAM_METHOD"].ToString();
                }
                if (row["C_SAM_NUM"] != null)
                {
                    model.C_SAM_NUM = row["C_SAM_NUM"].ToString();
                }
                if (row["C_RECHECK_NUM"] != null)
                {
                    model.C_RECHECK_NUM = row["C_RECHECK_NUM"].ToString();
                }
                if (row["C_NUM_UNIT"] != null)
                {
                    model.C_NUM_UNIT = row["C_NUM_UNIT"].ToString();
                }
                if (row["C_SAM_SECTION"] != null)
                {
                    model.C_SAM_SECTION = row["C_SAM_SECTION"].ToString();
                }
                if (row["C_TEST_UNIT"] != null)
                {
                    model.C_TEST_UNIT = row["C_TEST_UNIT"].ToString();
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
        /// 获得数据列表-获取取样数量
        /// </summary>
        /// <param name="c_stl_grd">钢种</param>
        /// <param name="c_std_code">执行标准</param>
        /// <returns></returns>
		public DataSet GetList_Query(string c_stl_grd, string c_std_code)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select t.c_sampling_name,a.C_SAM_NUM from tqb_std_sampling a join tqb_sampling t on a.c_sampling_id=t.c_id ");
            strSql.Append(" where a.c_std_main_id=(select q.c_id from tqb_std_main q where q.c_stl_grd ='" + c_stl_grd + "' and q.c_std_code='" + c_std_code + "' and q.N_IS_CHECK=1 and q.N_STATUS=1) and t.c_sampling_name not in ('化学成分','外形尺寸','表面质量') ");

            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select a.C_ID,b.C_SAMPLING_CODE,b.C_SAMPLING_NAME,a.C_STD_MAIN_ID,a.C_SAMPLING_ID,a.C_NUMBER,a.C_SAM_SPE,a.C_SAM_LEN,a.C_SAM_METHOD,a.C_SAM_NUM,a.C_RECHECK_NUM,a.C_NUM_UNIT,a.C_SAM_SECTION,a.C_TEST_UNIT,a.N_STATUS,a.C_REMARK,a.C_EMP_ID,a.D_MOD_DT ");
            strSql.Append(" FROM TQB_STD_SAMPLING a inner join tqb_sampling b on a.C_SAMPLING_ID=b.c_id WHERE a.N_STATUS='1' ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" AND " + strWhere);
            }
            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM TQB_STD_SAMPLING ");
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
            strSql.Append(")AS Row, T.*  from TQB_STD_SAMPLING T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取标准取样信息（技术中心）
        /// </summary>
        /// <param name="strTime1">开始时间</param>
        /// <param name="strTime2">结束时间</param>
        /// <returns></returns>
		public DataSet GetList_JSZX(string strTime1, string strTime2)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT distinct TA.C_BATCH_NO as 批号, TB.C_STOVE as 炉号, TB.C_STL_GRD as 钢种, TB.C_SPEC as 规格, TB.C_STD_CODE as 执行标准, te.C_SAMPLING_NAME  FROM TQC_PRESENT_SAMPLES_JSZX TA INNER JOIN TRC_ROLL_MAIN TB ON TA.C_BATCH_NO = TB.C_BATCH_NO    inner join TQB_STD_MAIN tc on tc.c_std_code = tb.C_STD_CODE and tc.c_stl_grd = tb.C_STL_GRD inner join TQB_STD_SAMPLING td on td.c_std_main_id = tc.c_id inner join TQB_SAMPLING te on te.c_id = td.c_sampling_id WHERE 1 = 1 AND TA.N_ENTRUST_TYPE in ('0', '1') and tc.n_status = 1 and tc.n_is_check = 1 and te.n_status = 1 AND Te.C_CHECK_DEPMT = '技术中心' AND Te.C_SAMPLING_NAME NOT IN('化学成分', '外形尺寸', '表面质量') ");

            strSql.Append("  AND TA.D_MOD_DT_SY BETWEEN to_date('"+ strTime1 + "','yyyy-mm-dd hh24:mi:ss') and to_date('" + strTime2 + "','yyyy-mm-dd hh24:mi:ss') ");

            return DbHelperOra.Query(strSql.ToString());
        }


        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int Get_Count(string c_std_code,string c_stl_grd)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from tqb_std_sampling ta inner join tqb_sampling tb on ta.c_sampling_id=tb.c_id inner join tqb_std_main tc on tc.c_id=ta.c_std_main_id where tc.n_is_check=1 and tc.n_status=1 and tb.c_sampling_name = '化学成分' and tc.c_std_code='"+ c_std_code + "' and tc.c_stl_grd='"+ c_stl_grd + "' and ta.c_sam_section in('盘条','线材') ");

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

        #endregion  BasicMethod
        #region  ExtensionMethod

        #endregion  ExtensionMethod
    }
}

