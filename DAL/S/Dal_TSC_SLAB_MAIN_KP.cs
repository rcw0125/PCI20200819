using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;
namespace DAL
{
    /// <summary>
    /// 数据访问类:TSC_SLAB_MAIN_KP
    /// </summary>
    public partial class Dal_TSC_SLAB_MAIN_KP
    {
        public Dal_TSC_SLAB_MAIN_KP()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string C_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TSC_SLAB_MAIN_KP");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)         };
            parameters[0].Value = C_ID;

            return DbHelperOra.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Mod_TSC_SLAB_MAIN_KP model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TSC_SLAB_MAIN_KP(");
            strSql.Append("C_SLAN_PLAN_KP_ID,C_STA_ID,C_SPEC,N_LEN,N_QUA,N_WGT,D_ACT_START_TIME,D_ACT_END_TIME,N_STATUS,N_BFZS,N_KPSJ,C_BC,C_BZ,C_EMP_ID,D_MOD_DT,C_REMARK)");
            strSql.Append(" values (");
            strSql.Append(":C_SLAN_PLAN_KP_ID,:C_STA_ID,:C_SPEC,:N_LEN,:N_QUA,:N_WGT,:D_ACT_START_TIME,:D_ACT_END_TIME,:N_STATUS,:N_BFZS,:N_KPSJ,:C_BC,:C_BZ,:C_EMP_ID,:D_MOD_DT,:C_REMARK)");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_SLAN_PLAN_KP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STA_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SPEC", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_LEN", OracleDbType.Decimal,15),
                    new OracleParameter(":N_QUA", OracleDbType.Decimal,4),
                    new OracleParameter(":N_WGT", OracleDbType.Decimal,10),
                    new OracleParameter(":D_ACT_START_TIME", OracleDbType.Date),
                    new OracleParameter(":D_ACT_END_TIME", OracleDbType.Date),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
                    new OracleParameter(":N_BFZS", OracleDbType.Decimal,1),
                    new OracleParameter(":N_KPSJ", OracleDbType.Decimal,3),
                    new OracleParameter(":C_BC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_BZ", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,200)};
            parameters[0].Value = model.C_SLAN_PLAN_KP_ID;
            parameters[1].Value = model.C_STA_ID;
            parameters[2].Value = model.C_SPEC;
            parameters[3].Value = model.N_LEN;
            parameters[4].Value = model.N_QUA;
            parameters[5].Value = model.N_WGT;
            parameters[6].Value = model.D_ACT_START_TIME;
            parameters[7].Value = model.D_ACT_END_TIME;
            parameters[8].Value = model.N_STATUS;
            parameters[9].Value =  model.N_BFZS;
            parameters[10].Value = model.N_KPSJ;
            parameters[11].Value = model.C_BC;
            parameters[12].Value = model.C_BZ;
            parameters[13].Value = model.C_EMP_ID;
            parameters[14].Value = model.D_MOD_DT;
            parameters[15].Value = model.C_REMARK;

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
        public bool Update(Mod_TSC_SLAB_MAIN_KP model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TSC_SLAB_MAIN_KP set ");
            strSql.Append("C_SLAN_PLAN_KP_ID=:C_SLAN_PLAN_KP_ID,");
            strSql.Append("C_STA_ID=:C_STA_ID,");
            strSql.Append("C_SPEC=:C_SPEC,");
            strSql.Append("N_LEN=:N_LEN,");
            strSql.Append("N_QUA=:N_QUA,");
            strSql.Append("N_WGT=:N_WGT,");
            strSql.Append("D_ACT_START_TIME=:D_ACT_START_TIME,");
            strSql.Append("D_ACT_END_TIME=:D_ACT_END_TIME,");
            strSql.Append("N_STATUS=:N_STATUS,");
            strSql.Append("N_BFZS=:N_BFZS,");
            strSql.Append("N_KPSJ=:N_KPSJ,");
            strSql.Append("C_BC=:C_BC,");
            strSql.Append("C_BZ=:C_BZ,");
            strSql.Append("C_EMP_ID=:C_EMP_ID,");
            strSql.Append("D_MOD_DT=:D_MOD_DT,");
            strSql.Append("C_REMARK=:C_REMARK");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_SLAN_PLAN_KP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STA_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SPEC", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_LEN", OracleDbType.Decimal,15),
                    new OracleParameter(":N_QUA", OracleDbType.Decimal,4),
                    new OracleParameter(":N_WGT", OracleDbType.Decimal,10),
                    new OracleParameter(":D_ACT_START_TIME", OracleDbType.Date),
                    new OracleParameter(":D_ACT_END_TIME", OracleDbType.Date),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
                    new OracleParameter(":N_BFZS", OracleDbType.Decimal,1),
                    new OracleParameter(":N_KPSJ", OracleDbType.Decimal,3),
                    new OracleParameter(":C_BC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_BZ", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,200),
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.C_SLAN_PLAN_KP_ID;
            parameters[1].Value = model.C_STA_ID;
            parameters[2].Value = model.C_SPEC;
            parameters[3].Value = model.N_LEN;
            parameters[4].Value = model.N_QUA;
            parameters[5].Value = model.N_WGT;
            parameters[6].Value = model.D_ACT_START_TIME;
            parameters[7].Value = model.D_ACT_END_TIME;
            parameters[8].Value = model.N_STATUS;
            parameters[9].Value = model.N_BFZS;
            parameters[10].Value = model.N_KPSJ;
            parameters[11].Value = model.C_BC;
            parameters[12].Value = model.C_BZ;
            parameters[13].Value = model.C_EMP_ID;
            parameters[14].Value = model.D_MOD_DT;
            parameters[15].Value = model.C_REMARK;
            parameters[16].Value = model.C_ID;

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
            strSql.Append("delete from TSC_SLAB_MAIN_KP ");
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
            strSql.Append("delete from TSC_SLAB_MAIN_KP ");
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
        public Mod_TSC_SLAB_MAIN_KP GetModel(string C_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_SLAN_PLAN_KP_ID,C_STA_ID,C_SPEC,N_LEN,N_QUA,N_WGT,D_ACT_START_TIME,D_ACT_END_TIME,N_STATUS,N_BFZS,N_KPSJ,C_BC,C_BZ,C_EMP_ID,D_MOD_DT,C_REMARK from TSC_SLAB_MAIN_KP ");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)         };
            parameters[0].Value = C_ID;

            Mod_TSC_SLAB_MAIN_KP model = new Mod_TSC_SLAB_MAIN_KP();
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
        public Mod_TSC_SLAB_MAIN_KP DataRowToModel(DataRow row)
        {
            Mod_TSC_SLAB_MAIN_KP model = new Mod_TSC_SLAB_MAIN_KP();
            if (row != null)
            {
                if (row["C_ID"] != null)
                {
                    model.C_ID = row["C_ID"].ToString();
                }
                if (row["C_SLAN_PLAN_KP_ID"] != null)
                {
                    model.C_SLAN_PLAN_KP_ID = row["C_SLAN_PLAN_KP_ID"].ToString();
                }
                if (row["C_STA_ID"] != null)
                {
                    model.C_STA_ID = row["C_STA_ID"].ToString();
                }
                if (row["C_SPEC"] != null)
                {
                    model.C_SPEC = row["C_SPEC"].ToString();
                }
                if (row["N_LEN"] != null && row["N_LEN"].ToString() != "")
                {
                    model.N_LEN = decimal.Parse(row["N_LEN"].ToString());
                }
                if (row["N_QUA"] != null && row["N_QUA"].ToString() != "")
                {
                    model.N_QUA = decimal.Parse(row["N_QUA"].ToString());
                }
                if (row["N_WGT"] != null && row["N_WGT"].ToString() != "")
                {
                    model.N_WGT = decimal.Parse(row["N_WGT"].ToString());
                }
                if (row["D_ACT_START_TIME"] != null && row["D_ACT_START_TIME"].ToString() != "")
                {
                    model.D_ACT_START_TIME = DateTime.Parse(row["D_ACT_START_TIME"].ToString());
                }
                if (row["D_ACT_END_TIME"] != null && row["D_ACT_END_TIME"].ToString() != "")
                {
                    model.D_ACT_END_TIME = DateTime.Parse(row["D_ACT_END_TIME"].ToString());
                }
                if (row["N_STATUS"] != null && row["N_STATUS"].ToString() != "")
                {
                    model.N_STATUS = decimal.Parse(row["N_STATUS"].ToString());
                }
                if (row["N_BFZS"] != null && row["N_BFZS"].ToString() != "")
                {
                    model.N_BFZS = decimal.Parse(row["N_BFZS"].ToString());
                }
                if (row["N_KPSJ"] != null && row["N_KPSJ"].ToString() != "")
                {
                    model.N_KPSJ = decimal.Parse(row["N_KPSJ"].ToString());
                }
                if (row["C_BC"] != null)
                {
                    model.C_BC = row["C_BC"].ToString();
                }
                if (row["C_BZ"] != null)
                {
                    model.C_BZ = row["C_BZ"].ToString();
                }
                if (row["C_EMP_ID"] != null)
                {
                    model.C_EMP_ID = row["C_EMP_ID"].ToString();
                }
                if (row["D_MOD_DT"] != null && row["D_MOD_DT"].ToString() != "")
                {
                    model.D_MOD_DT = DateTime.Parse(row["D_MOD_DT"].ToString());
                }
                if (row["C_REMARK"] != null)
                {
                    model.C_REMARK = row["C_REMARK"].ToString();
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
            strSql.Append("select C_ID,C_SLAN_PLAN_KP_ID,C_STA_ID,C_SPEC,N_LEN,N_QUA,N_WGT,D_ACT_START_TIME,D_ACT_END_TIME,N_STATUS,N_BFZS,N_KPSJ,C_BC,C_BZ,C_EMP_ID,D_MOD_DT,C_REMARK ");
            strSql.Append(" FROM TSC_SLAB_MAIN_KP ");
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
            strSql.Append("select count(1) FROM TSC_SLAB_MAIN_KP ");
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
            strSql.Append(")AS Row, T.*  from TSC_SLAB_MAIN_KP T ");
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
        /// 更新一条数据
        /// </summary>
        public bool Update(string cid, string status)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TPP_SLAB_PLAN_KP set ");
            strSql.Append(" N_STATUS='" + status + "' Where C_ID='" + cid + "'");
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
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string sta, string lh, string grd, string std, DateTime time, int status)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select t.C_ID，y.c_stove,y.c_stl_grd,u.c_spec,u.n_len,u.n_qua,u.n_wgt,u.n_bfzs,u.n_kpsj,u.c_bc,u.c_bz,u.c_remark,u.d_act_start_time,u.d_act_end_time from TPP_SLAB_PLAN_KP t inner join TSC_SLAB_MAIN y on t.c_slan_main_id = y.c_id inner join  TSC_SLAB_MAIN_KP u on u.c_slan_plan_kp_id= t.c_id where u.n_status = '" + status + "'  ");
            if (sta.Trim() != "")
            {
                strSql.Append(" and u.c_sta_id='" + sta + "' ");
            }

            if (lh.Trim() != "")
            {
                strSql.Append(" and y.c_stove LIKE '%" + lh + "%'");
            }
            if (grd.Trim() != "")
            {
                strSql.Append(" and y.c_stl_grd LIKE '%" + grd + "%'");
            }
            if (std.Trim() != "")
            {
                strSql.Append(" and y.c_std_code LIKE '%" + std + "%'");
            }
            if (time != null)
            {
                strSql.Append(" and u.d_act_start_time Like  to_date('" + time + "', 'yyyy - mm - dd HH24:MI:SS') ");
            }
            strSql.Append(" ORDER BY u.d_act_start_time ");
            return DbHelperOra.Query(strSql.ToString());
        }
        #endregion  ExtensionMethod
    }
}
