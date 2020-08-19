using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;
namespace DAL
{
    /// <summary>
    /// 数据访问类:TSC_SLAB_MAIN_XM
    /// </summary>
    public partial class Dal_TSC_SLAB_MAIN_XM
    {
        public Dal_TSC_SLAB_MAIN_XM()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string C_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TSC_SLAB_MAIN_XM");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)         };
            parameters[0].Value = C_ID;

            return DbHelperOra.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Mod_TSC_SLAB_MAIN_XM model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TSC_SLAB_MAIN_XM(");
            strSql.Append("C_SLAB_MAIN_PLAN_ID,C_STA_ID，C_XMGX,N_XMZS,N_BFZS,N_XMSJ,C_BC,C_BZ,C_EMP_ID,D_MOD_DT,C_REMARK,N_STATUS,D_ACT_START_TIME,D_ACT_END_TIME)");
            strSql.Append(" values (");
            strSql.Append(":C_SLAB_MAIN_PLAN_ID,:C_STA_ID,:C_XMGX,:N_XMZS,:N_BFZS,:N_XMSJ,:C_BC,:C_BZ,:C_EMP_ID,:D_MOD_DT,:C_REMARK,:N_STATUS,:D_ACT_START_TIME,:D_ACT_END_TIME)");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_SLAB_MAIN_PLAN_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STA_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_XMGX", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_XMZS", OracleDbType.Decimal,1),
                    new OracleParameter(":N_BFZS", OracleDbType.Decimal,1),
                    new OracleParameter(":N_XMSJ", OracleDbType.Decimal,3),
                    new OracleParameter(":C_BC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_BZ", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT",OracleDbType.Date),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,200),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
                    new OracleParameter(":D_ACT_START_TIME",OracleDbType.Date),
                    new OracleParameter(":D_ACT_END_TIME",OracleDbType.Date)};
            parameters[0].Value = model.C_SLAB_MAIN_PLAN_ID;
            parameters[1].Value = model.C_STA_ID;
            parameters[2].Value = model.C_XMGX;
            parameters[3].Value = model.N_XMZS;
            parameters[4].Value = model.N_BFZS;
            parameters[5].Value = model.N_XMSJ;
            parameters[6].Value = model.C_BC;
            parameters[7].Value = model.C_BZ;
            parameters[8].Value = model.C_EMP_ID;
            parameters[9].Value = model.D_MOD_DT;
            parameters[10].Value = model.C_REMARK;
            parameters[11].Value = model.N_STATUS;
            parameters[12].Value = model.D_ACT_START_TIME;
            parameters[13].Value = model.D_ACT_END_TIME;
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
        public bool Update(Mod_TSC_SLAB_MAIN_XM model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TSC_SLAB_MAIN_XM set ");
            strSql.Append("C_SLAB_MAIN_PLAN_ID=:C_SLAB_MAIN_PLAN_ID,");
            strSql.Append("C_STA_ID=:C_STA_ID,");
            strSql.Append("C_XMGX=:C_XMGX,");
            strSql.Append("N_XMZS=:N_XMZS,");
            strSql.Append("N_BFZS=:N_BFZS,");
            strSql.Append("N_XMSJ=:N_XMSJ,");
            strSql.Append("C_BC=:C_BC,");
            strSql.Append("C_BZ=:C_BZ,");
            strSql.Append("C_EMP_ID=:C_EMP_ID,");
            strSql.Append("D_MOD_DT=:D_MOD_DT,");
            strSql.Append("C_REMARK=:C_REMARK,");
            strSql.Append("N_STATUS=:N_STATUS,");
            strSql.Append("D_ACT_START_TIME=:D_ACT_START_TIME,");
            strSql.Append("D_ACT_END_TIME=:D_ACT_END_TIME");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_SLAB_MAIN_PLAN_ID", OracleDbType.Varchar2,100),
                        new OracleParameter(":C_STA_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_XMGX", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_XMZS", OracleDbType.Decimal,1),
                    new OracleParameter(":N_BFZS", OracleDbType.Decimal,1),
                    new OracleParameter(":N_XMSJ", OracleDbType.Decimal,3),
                    new OracleParameter(":C_BC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_BZ", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT",OracleDbType.Date),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,200),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
                    new OracleParameter(":D_ACT_START_TIME",OracleDbType.Date),
                    new OracleParameter(":D_ACT_END_TIME",OracleDbType.Date),
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.C_SLAB_MAIN_PLAN_ID;
            parameters[1].Value = model.C_STA_ID;
            parameters[2].Value = model.C_XMGX;
            parameters[3].Value = model.N_XMZS;
            parameters[4].Value = model.N_BFZS;
            parameters[5].Value = model.N_XMSJ;
            parameters[6].Value = model.C_BC;
            parameters[7].Value = model.C_BZ;
            parameters[8].Value = model.C_EMP_ID;
            parameters[9].Value = model.D_MOD_DT;
            parameters[10].Value =model.C_REMARK;
            parameters[11].Value = model.N_STATUS;
            parameters[12].Value = model.D_ACT_START_TIME;
            parameters[13].Value = model.D_ACT_END_TIME;
            parameters[14].Value = model.C_ID;
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
            strSql.Append("delete from TSC_SLAB_MAIN_XM ");
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
            strSql.Append("delete from TSC_SLAB_MAIN_XM ");
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
        public Mod_TSC_SLAB_MAIN_XM GetModel(string C_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_SLAB_MAIN_PLAN_ID,C_STA_ID,C_XMGX,N_XMZS,N_BFZS,N_XMSJ,C_BC,C_BZ,C_EMP_ID,D_MOD_DT,C_REMARK,N_STATUS,D_ACT_START_TIME,D_ACT_END_TIME from TSC_SLAB_MAIN_XM ");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)         };
            parameters[0].Value = C_ID;

            Mod_TSC_SLAB_MAIN_XM model = new Mod_TSC_SLAB_MAIN_XM();
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
        public Mod_TSC_SLAB_MAIN_XM DataRowToModel(DataRow row)
        {
            Mod_TSC_SLAB_MAIN_XM model = new Mod_TSC_SLAB_MAIN_XM();
            if (row != null)
            {
                if (row["C_ID"] != null)
                {
                    model.C_ID = row["C_ID"].ToString();
                }
                if (row["C_SLAB_MAIN_PLAN_ID"] != null)
                {
                    model.C_SLAB_MAIN_PLAN_ID = row["C_SLAB_MAIN_PLAN_ID"].ToString();
                }
                if (row["C_XMGX"] != null)
                {
                    model.C_XMGX = row["C_XMGX"].ToString();
                }
                if (row["N_XMZS"] != null && row["N_XMZS"].ToString() != "")
                {
                    model.N_XMZS = decimal.Parse(row["N_XMZS"].ToString());
                }
                if (row["N_BFZS"] != null && row["N_BFZS"].ToString() != "")
                {
                    model.N_BFZS = decimal.Parse(row["N_BFZS"].ToString());
                }
                if (row["N_XMSJ"] != null && row["N_XMSJ"].ToString() != "")
                {
                    model.N_XMSJ = decimal.Parse(row["N_XMSJ"].ToString());
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
                if (row["N_STATUS"] != null && row["N_STATUS"].ToString() != "")
                {
                    model.N_STATUS = decimal.Parse(row["N_STATUS"].ToString());
                }
                if (row["D_ACT_START_TIME"] != null && row["D_ACT_START_TIME"].ToString() != "")
                {
                    model.D_ACT_START_TIME = DateTime.Parse(row["D_ACT_START_TIME"].ToString());
                }
                if (row["D_ACT_END_TIME"] != null && row["D_ACT_END_TIME"].ToString() != "")
                {
                    model.D_ACT_END_TIME = DateTime.Parse(row["D_ACT_END_TIME"].ToString());
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
            strSql.Append("select C_ID,C_SLAB_MAIN_PLAN_ID,C_STA_ID，C_XMGX,N_XMZS,N_BFZS,N_XMSJ,C_BC,C_BZ,C_EMP_ID,D_MOD_DT,C_REMARK,N_STATUS,D_ACT_START_TIME,D_ACT_END_TIME ");
            strSql.Append(" FROM TSC_SLAB_MAIN_XM ");
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
            strSql.Append("select count(1) FROM TSC_SLAB_MAIN_XM ");
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
            strSql.Append(")AS Row, T.*  from TSC_SLAB_MAIN_XM T ");
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
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string sta, string xmgx, string lh, string grd, string std, DateTime time, int status)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select t.C_ID，y.c_stove,y.c_stl_grd,y.c_spec,y.n_len,y.n_qua,y.n_wgt,u.c_xmgx,u.n_xmzs,u.n_bfzs,u.n_xmsj,u.c_bc,u.c_bz,u.c_remark,u.d_act_start_time,u.d_act_end_time from TPP_SLAB_PLAN_XM t inner join TSC_SLAB_MAIN y on t.c_slan_main_id = y.c_id inner join  TSC_SLAB_MAIN_XM u on u.c_slab_main_plan_id= t.c_id where u.n_status = '" + status + "'  ");
            if (sta.Trim() != "")
            {
                strSql.Append(" and u.c_sta_id='" + sta + "' ");
            }
            if (xmgx.Trim() != "")
            {
                strSql.Append(" and  u.c_xmgx='" + xmgx + "'");
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
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update( string cid,string status)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TPP_SLAB_PLAN_XM set ");
            strSql.Append(" N_STATUS='"+ status + "' Where C_ID='"+ cid + "'");

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
        #endregion  ExtensionMethod
    }
}