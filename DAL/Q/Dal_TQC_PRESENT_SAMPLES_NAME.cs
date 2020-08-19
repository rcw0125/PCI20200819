using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using System.Collections;
using MODEL;
namespace DAL
{
    /// <summary>
    /// 数据访问类:TQC_PRESENT_SAMPLES_NAME
    /// </summary>
    public partial class Dal_TQC_PRESENT_SAMPLES_NAME
    {
        public Dal_TQC_PRESENT_SAMPLES_NAME()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string C_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TQC_PRESENT_SAMPLES_NAME");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)          };
            parameters[0].Value = C_ID;

            return DbHelperOra.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Mod_TQC_PRESENT_SAMPLES_NAME model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TQC_PRESENT_SAMPLES_NAME(");
            strSql.Append("C_ID,C_PRESENT_SAMPLES_ID,C_SAMPLES_ID,N_SAM_NUM,N_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT)");
            strSql.Append(" values (");
            strSql.Append(":C_ID,:C_PRESENT_SAMPLES_ID,:C_SAMPLES_ID,:N_SAM_NUM,:N_STATUS,:C_REMARK,:C_EMP_ID,:D_MOD_DT)");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PRESENT_SAMPLES_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SAMPLES_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_SAM_NUM", OracleDbType.Decimal,5),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date)};
            parameters[0].Value = model.C_ID;
            parameters[1].Value = model.C_PRESENT_SAMPLES_ID;
            parameters[2].Value = model.C_SAMPLES_ID;
            parameters[3].Value = model.N_SAM_NUM;
            parameters[4].Value = model.N_STATUS;
            parameters[5].Value = model.C_REMARK;
            parameters[6].Value = model.C_EMP_ID;
            parameters[7].Value = model.D_MOD_DT;

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
        public bool Update(Mod_TQC_PRESENT_SAMPLES_NAME model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TQC_PRESENT_SAMPLES_NAME set ");
            strSql.Append("C_PRESENT_SAMPLES_ID=:C_PRESENT_SAMPLES_ID,");
            strSql.Append("C_SAMPLES_ID=:C_SAMPLES_ID,");
            strSql.Append("N_SAM_NUM=:N_SAM_NUM,");
            strSql.Append("N_STATUS=:N_STATUS,");
            strSql.Append("C_REMARK=:C_REMARK,");
            strSql.Append("C_EMP_ID=:C_EMP_ID,");
            strSql.Append("D_MOD_DT=:D_MOD_DT");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_PRESENT_SAMPLES_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SAMPLES_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_SAM_NUM", OracleDbType.Decimal,5),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.C_PRESENT_SAMPLES_ID;
            parameters[1].Value = model.C_SAMPLES_ID;
            parameters[2].Value = model.N_SAM_NUM;
            parameters[3].Value = model.N_STATUS;
            parameters[4].Value = model.C_REMARK;
            parameters[5].Value = model.C_EMP_ID;
            parameters[6].Value = model.D_MOD_DT;
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
        public bool Delete(string C_PRESENT_SAMPLES_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from TQC_PRESENT_SAMPLES_NAME ");
            strSql.Append(" where C_PRESENT_SAMPLES_ID=:C_PRESENT_SAMPLES_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_PRESENT_SAMPLES_ID", OracleDbType.Varchar2,100)          };
            parameters[0].Value = C_PRESENT_SAMPLES_ID;

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
            strSql.Append("delete from TQC_PRESENT_SAMPLES_NAME ");
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
        public Mod_TQC_PRESENT_SAMPLES_NAME GetModel(string C_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_PRESENT_SAMPLES_ID,C_SAMPLES_ID,N_SAM_NUM,N_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT from TQC_PRESENT_SAMPLES_NAME ");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)          };
            parameters[0].Value = C_ID;

            Mod_TQC_PRESENT_SAMPLES_NAME model = new Mod_TQC_PRESENT_SAMPLES_NAME();
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
        public Mod_TQC_PRESENT_SAMPLES_NAME DataRowToModel(DataRow row)
        {
            Mod_TQC_PRESENT_SAMPLES_NAME model = new Mod_TQC_PRESENT_SAMPLES_NAME();
            if (row != null)
            {
                if (row["C_ID"] != null)
                {
                    model.C_ID = row["C_ID"].ToString();
                }
                if (row["C_PRESENT_SAMPLES_ID"] != null)
                {
                    model.C_PRESENT_SAMPLES_ID = row["C_PRESENT_SAMPLES_ID"].ToString();
                }
                if (row["C_SAMPLES_ID"] != null)
                {
                    model.C_SAMPLES_ID = row["C_SAMPLES_ID"].ToString();
                }
                if (row["N_SAM_NUM"] != null && row["N_SAM_NUM"].ToString() != "")
                {
                    model.N_SAM_NUM = decimal.Parse(row["N_SAM_NUM"].ToString());
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
            strSql.Append("select C_ID,C_PRESENT_SAMPLES_ID,C_SAMPLES_ID,N_SAM_NUM,N_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT ");
            strSql.Append(" FROM TQC_PRESENT_SAMPLES_NAME ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetZYXX(string strStart, string strEnd, string strBatchNo, string strType)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ta.c_id as 主键, ta.c_batch_no as 批号, ta.c_tick_no as 钩号, ta.c_stl_grd as 牌号, ta.c_spec as 规格, ts.c_sampling_name as 取样名称, tb.n_sam_num as 取样数量, ta.d_mod_dt as 取样时间, ta.d_mod_dt_js as 接样时间  from TQC_PRESENT_SAMPLES ta left join tqc_present_samples_name tb on tb.c_present_samples_id = ta.C_ID inner join tqb_sampling ts on ts.c_id = tb.c_samples_id WHERE 1=1  and ts.c_check_depmt='质控部' ");

            if (strStart.Trim() != "" && strEnd.Trim() != "")
            {
                strSql.Append(" AND ta.d_mod_dt between to_date('" + strStart + "', 'yyyy-mm-dd hh24:mi:ss') and to_date('" + strEnd + "','yyyy-mm-dd hh24:mi:ss') ");
            }

            if (strBatchNo.Trim() != "")
            {
                strSql.Append(" AND ta.c_batch_no like '" + strBatchNo + "%' ");
            }

            if (strType.Trim() != "")
            {
                if (strType == "9")
                {
                    strSql.Append(" AND ta.N_ENTRUST_TYPE not in(0,1) ");
                }
                else
                {
                    strSql.Append(" AND ta.N_ENTRUST_TYPE like '" + strType + "%' ");
                }
            }

            strSql.Append(" order by ta.c_batch_no,ta.c_tick_no");

            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetZYXX(string strStart, string strEnd, string strBatchNo)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ta.c_id as 主键, ta.c_batch_no as 批号,ta.c_tick_no as 钩号,ta.c_stl_grd as 牌号,ta.c_spec as 规格,ts.c_sampling_name as 取样名称,tb.n_sam_num as 取样数量,ta.d_mod_dt as 取样时间,ta.d_mod_dt_zy as 制样时间  from TQC_PRESENT_SAMPLES ta left join tqc_present_samples_name tb on tb.c_present_samples_id=ta.C_ID inner join tqb_sampling ts on ts.c_id = tb.c_samples_id WHERE 1=1 ");

            if (strStart.Trim() != "" && strEnd.Trim() != "")
            {
                strSql.Append(" AND ta.d_mod_dt_zy between to_date('" + strStart + "', 'yyyy-mm-dd hh24:mi:ss') and to_date('" + strEnd + "','yyyy-mm-dd hh24:mi:ss') ");
            }

            if (strBatchNo.Trim() != "")
            {
                strSql.Append(" AND ta.c_batch_no like '" + strBatchNo + "%' ");
            }

            strSql.Append(" AND ta.N_ENTRUST_TYPE = 3 ");

            strSql.Append(" order by ta.c_batch_no,ta.c_tick_no");

            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM TQC_PRESENT_SAMPLES_NAME ");
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
            strSql.Append(")AS Row, T.*  from TQC_PRESENT_SAMPLES_NAME T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
		/// 保存送样信息
		/// </summary>
		public bool SaveSamp(ArrayList SQLStringList)
        {
            return DbHelperOra.ExecuteSqlTran(SQLStringList);
        }

        /// <summary>
        /// 按时间和批号获取取样详细信息
        /// </summary>
        /// <param name="P_BATCH">批号</param>
        /// <param name="P_START">时间（开始）</param>
        /// <param name="P_END">时间（结束）</param>
        /// <param name="P_TYPE">类型,1查询委托信息，2查询已接收送样信息，3查询已制样信息</param>
        /// <returns></returns>
		public DataSet Get_List(string P_BATCH_MIN, string P_BATCH_MAX, string P_START, string P_END, string P_TYPE)
        {
            OracleParameter[] parameters = {
                    new OracleParameter("P_BATCH_MIN", OracleDbType.Varchar2,100),
                    new OracleParameter("P_BATCH_MAX", OracleDbType.Varchar2,100),
                    new OracleParameter("P_START", OracleDbType.Varchar2,100),
                    new OracleParameter("P_END", OracleDbType.Varchar2,100),
                    new OracleParameter("P_TYPE", OracleDbType.Varchar2,1),
                    new OracleParameter("P_CUR", OracleDbType.RefCursor)};

            parameters[0].Value = P_BATCH_MIN;
            parameters[1].Value = P_BATCH_MAX;
            parameters[2].Value = P_START;
            parameters[3].Value = P_END;
            parameters[4].Value = P_TYPE;
            parameters[5].Value = null;

            return DbHelperOra.RunProcedure("PKG_XN.P_ZY_ITEMS", parameters, "ds");
        }

        /// <summary>
        /// 按时间和批号获取取样详细信息
        /// </summary>
        /// <param name="P_BATCH">批号</param>
        /// <param name="P_START">时间（开始）</param>
        /// <param name="P_END">时间（结束）</param>
        /// <param name="P_TYPE">类型,0未委托；1查询委托信息，2查询已接收送样信息，3查询已制样信息</param>
        /// <returns></returns>
		public DataSet Get_List_JSZX(string P_BATCH, string P_START, string P_END, string P_TYPE)
        {
            OracleParameter[] parameters = {
                    new OracleParameter("P_BATCH", OracleDbType.Varchar2,100),
                    new OracleParameter("P_START", OracleDbType.Varchar2,100),
                    new OracleParameter("P_END", OracleDbType.Varchar2,100),
                    new OracleParameter("P_TYPE", OracleDbType.Varchar2,1),
                    new OracleParameter("P_CUR", OracleDbType.RefCursor)};

            parameters[0].Value = P_BATCH;
            parameters[1].Value = P_START;
            parameters[2].Value = P_END;
            parameters[3].Value = P_TYPE;
            parameters[4].Value = null;

            return DbHelperOra.RunProcedure("PKG_XN.P_ZY_ITEMS_JSZX", parameters, "ds");
        }

        /// <summary>
        /// 获取物理性能分组主键
        /// </summary>
        /// <param name="C_PRESENT_SAMPLES_ID">取样主表ID</param>
        /// <param name="c_check_depmt">检测部门</param>
        /// <returns></returns>
		public DataSet Get_PHYSICS_GROUP_ID(string C_PRESENT_SAMPLES_ID, string c_check_depmt)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" SELECT TB.C_PHYSICS_GROUP_ID FROM TQC_PRESENT_SAMPLES_NAME TA INNER JOIN TQB_SAMPLING_GROUP TB ON TA.C_SAMPLES_ID=TB.C_SAMPLING_ID inner join tqb_sampling tc on tc.c_id=ta.c_samples_id WHERE TA.C_PRESENT_SAMPLES_ID='" + C_PRESENT_SAMPLES_ID + "' and tc.c_check_depmt='" + c_check_depmt + "' and tb.N_STATUS='1' GROUP BY TB.C_PHYSICS_GROUP_ID ");

            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取物理性能分组主键
        /// </summary>
        /// <param name="C_PRESENT_SAMPLES_ID">取样主表ID</param>
        /// <param name="c_check_depmt">检测部门</param>
        /// <param name="C_STD_CODE">执行标准</param>
        /// <param name="C_STL_GRD">钢种</param>
        /// <returns></returns>
		public DataSet Get_PHYSICS_GROUP_ID(string C_PRESENT_SAMPLES_ID, string c_check_depmt, string C_STD_CODE, string C_STL_GRD)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT td.C_ID as C_PHYSICS_GROUP_ID, td.c_name  FROM tqb_physics_group td inner join tqb_physics_group_std te    on te.c_physics_code = td.c_code WHERE td.c_check_depmt = '技术中心' and td.N_STATUS = '1' and td.n_status = 1 and te.n_status = 1 and te.C_STD_CODE='" + C_STD_CODE + "' and te.C_STL_GRD='" + C_STL_GRD + "' GROUP BY td.C_ID, td.c_name ");

            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取物理性能分组主键(技术中心)
        /// </summary>
        /// <returns></returns>
        public string Get_GroupID()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select max(ta.c_id) from tqb_physics_group ta where ta.n_status=1 and ta.c_check_depmt='技术中心' and ta.c_code not in( select tb.c_physics_code from tqb_physics_group_std tb where tb.n_status=1 ) ");

            object obj = DbHelperOra.GetSingle(strSql.ToString());
            if (obj == null)
            {
                return "";
            }
            else
            {
                return obj.ToString();
            }
        }


        /// <summary>
        /// 按时间和批号获取取样详细信息
        /// </summary>
        /// <param name="P_STD_CODE">标准</param>
        /// <param name="P_STL_GRD">钢种</param>
        /// <returns></returns>
		public DataSet Get_Model_List(string P_STD_CODE, string P_STL_GRD)
        {
            OracleParameter[] parameters = {
                    new OracleParameter("P_STD_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter("P_STL_GRD", OracleDbType.Varchar2,100),
                    new OracleParameter("P_CUR", OracleDbType.RefCursor)};

            parameters[0].Value = P_STD_CODE;
            parameters[1].Value = P_STL_GRD;
            parameters[2].Value = null;

            return DbHelperOra.RunProcedure("PKG_XN.P_ZY_ITEMS_MODEL", parameters, "ds");
        }

        /// <summary>
        /// 按时间和批号获取取样详细信息
        /// </summary>
        /// <param name="P_STD_CODE">标准</param>
        /// <param name="P_STL_GRD">钢种</param>
        /// <returns></returns>
		public DataSet Get_Model_List_JSZX(string P_STD_CODE, string P_STL_GRD)
        {
            OracleParameter[] parameters = {
                    new OracleParameter("P_STD_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter("P_STL_GRD", OracleDbType.Varchar2,100),
                    new OracleParameter("P_CUR", OracleDbType.RefCursor)};

            parameters[0].Value = P_STD_CODE;
            parameters[1].Value = P_STL_GRD;
            parameters[2].Value = null;

            return DbHelperOra.RunProcedure("PKG_XN.P_ZY_ITEMS_MODEL_JSZX", parameters, "ds");
        }

        #endregion  BasicMethod
    }
}

