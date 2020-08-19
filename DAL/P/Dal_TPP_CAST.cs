using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;
namespace DAL
{
    /// <summary>
    /// 数据访问类:TPP_CAST
    /// </summary>
    public partial class Dal_TPP_CAST
    {
        public Dal_TPP_CAST()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string C_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TPP_CAST");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)          };
            parameters[0].Value = C_ID;

            return DbHelperOra.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Mod_TPP_CAST model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TPP_CAST(");
            strSql.Append("C_CAST_NO,C_CAST_LS,N_CAST_WGT,N_SORT,C_INITIALIZE_ITEM,N_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT,C_CCM_ID,N_SFZJC)");
            strSql.Append(" values (");
            strSql.Append(":C_CAST_NO,:C_CAST_LS,:N_CAST_WGT,:N_SORT,:C_INITIALIZE_ITEM,:N_STATUS,:C_REMARK,:C_EMP_ID,:D_MOD_DT,:C_CCM_ID,:N_SFZJC)");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_CAST_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CAST_LS", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_CAST_WGT", OracleDbType.Double,15),
                    new OracleParameter(":N_SORT", OracleDbType.Decimal,3),
                    new OracleParameter(":C_INITIALIZE_ITEM", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":C_CCM_ID", OracleDbType.Varchar2,100),
            new OracleParameter(":N_SFZJC", OracleDbType.Decimal,1),};
            parameters[0].Value = model.C_CAST_NO;
            parameters[1].Value = model.C_CAST_LS;
            parameters[2].Value = model.N_CAST_WGT;
            parameters[3].Value = model.N_SORT;
            parameters[4].Value = model.C_INITIALIZE_ITEM;
            parameters[5].Value = model.N_STATUS;
            parameters[6].Value = model.C_REMARK;
            parameters[7].Value = model.C_EMP_ID;
            parameters[8].Value = model.D_MOD_DT;
            parameters[9].Value = model.C_CCM_ID;
            parameters[10].Value = model.N_SFZJC;
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
        public bool Update(Mod_TPP_CAST model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TPP_CAST set ");
            strSql.Append("C_CAST_NO=:C_CAST_NO,");
            strSql.Append("C_CAST_LS=:C_CAST_LS,");
            strSql.Append("N_CAST_WGT=:N_CAST_WGT,");
            strSql.Append("N_SORT=:N_SORT,");
            strSql.Append("C_INITIALIZE_ITEM=:C_INITIALIZE_ITEM,");
            strSql.Append("N_STATUS=:N_STATUS,");
            strSql.Append("C_REMARK=:C_REMARK,");
            strSql.Append("C_EMP_ID=:C_EMP_ID,");
            strSql.Append("D_MOD_DT=:D_MOD_DT,");
            strSql.Append("C_CCM_ID=:C_CCM_ID,");
            strSql.Append("N_SFZJC=:N_SFZJC");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_CAST_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CAST_LS", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_CAST_WGT", OracleDbType.Double,15),
                    new OracleParameter(":N_SORT", OracleDbType.Decimal,1),
                    new OracleParameter(":C_INITIALIZE_ITEM", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":C_CCM_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_SFZJC", OracleDbType.Decimal,1),
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.C_CAST_NO;
            parameters[1].Value = model.C_CAST_LS;
            parameters[2].Value = model.N_CAST_WGT;
            parameters[3].Value = model.N_SORT;
            parameters[4].Value = model.C_INITIALIZE_ITEM;
            parameters[5].Value = model.N_STATUS;
            parameters[6].Value = model.C_REMARK;
            parameters[7].Value = model.C_EMP_ID;
            parameters[8].Value = model.D_MOD_DT;
            parameters[9].Value = model.C_CCM_ID;
            parameters[10].Value = model.N_SFZJC;
            parameters[11].Value = model.C_ID;

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
            strSql.Append("delete from TPP_CAST ");
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
            strSql.Append("delete from TPP_CAST ");
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
        public Mod_TPP_CAST GetModel(string C_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_CAST_NO,C_CAST_LS,N_CAST_WGT,N_SORT,C_INITIALIZE_ITEM,N_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT,C_CCM_ID,N_SFZJC from TPP_CAST ");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)          };
            parameters[0].Value = C_ID;

            Mod_TPP_CAST model = new Mod_TPP_CAST();
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
        public Mod_TPP_CAST GetModel(string str_SORT, string C_CCM_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_CAST_NO,C_CAST_LS,N_CAST_WGT,N_SORT,C_INITIALIZE_ITEM,N_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT,C_CCM_ID,N_SFZJC from TPP_CAST ");
            strSql.Append(" where N_SORT='" + str_SORT + "' and C_CCM_ID='" + C_CCM_ID + "' and rownum=1 ");

            Mod_TPP_CAST model = new Mod_TPP_CAST();
            DataSet ds = DbHelperOra.Query(strSql.ToString());
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
        public Mod_TPP_CAST DataRowToModel(DataRow row)
        {
            Mod_TPP_CAST model = new Mod_TPP_CAST();
            if (row != null)
            {
                if (row["C_ID"] != null)
                {
                    model.C_ID = row["C_ID"].ToString();
                }
                if (row["C_CAST_NO"] != null)
                {
                    model.C_CAST_NO = row["C_CAST_NO"].ToString();
                }
                if (row["C_CAST_LS"] != null)
                {
                    model.C_CAST_LS = row["C_CAST_LS"].ToString();
                }
                if (row["N_CAST_WGT"] != null && row["N_CAST_WGT"].ToString() != "")
                {
                    model.N_CAST_WGT = decimal.Parse(row["N_CAST_WGT"].ToString());
                }
                if (row["N_SORT"] != null && row["N_SORT"].ToString() != "")
                {
                    model.N_SORT = decimal.Parse(row["N_SORT"].ToString());
                }
                if (row["C_INITIALIZE_ITEM"] != null)
                {
                    model.C_INITIALIZE_ITEM = row["C_INITIALIZE_ITEM"].ToString();
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
                if (row["C_CCM_ID"] != null)
                {
                    model.C_CCM_ID = row["C_CCM_ID"].ToString();
                }
                if (row["N_SFZJC"] != null && row["N_SFZJC"].ToString() != "")
                {
                    model.N_SFZJC = decimal.Parse(row["N_SFZJC"].ToString());
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
            strSql.Append("select C_ID,C_CAST_NO,C_CAST_LS,N_CAST_WGT,N_SORT,C_INITIALIZE_ITEM,N_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT,C_CCM_ID ");
            strSql.Append(" FROM TPP_CAST ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 获得数据列表-获得顺序号
        /// </summary>
        /// <param name="strWhere">工位</param>
        /// <param name="C_INITIALIZE_ITEM">方案号</param>
        /// <returns></returns>
        public DataSet GetList_Number(string strWhere, string C_INITIALIZE_ITEM)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  N_SORT  ");
            strSql.Append(" FROM TPP_CAST where 1=1");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" and   C_CCM_ID = '" + strWhere + "' ");
            }
            if (C_INITIALIZE_ITEM.Trim() != "")
            {
                strSql.Append(" and   C_INITIALIZE_ITEM = '" + C_INITIALIZE_ITEM + "' ");
            }
            strSql.Append(" order by N_SORT ");
            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 获得数据列表-方案和工位查询
        /// </summary>
        /// <param name="C_INITIALIZE_ITEM">铸机号</param>
        /// <param name="C_CCM_ID">工位</param>
        /// <returns></returns>
        public DataSet GetList_Code(string C_INITIALIZE_ITEM, string C_CCM_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select t.C_ID, t.C_CAST_NO, t.C_CAST_LS, t.N_CAST_WGT, t.N_SORT, t.C_INITIALIZE_ITEM, t.N_STATUS, t.C_REMARK, t.C_EMP_ID, t.D_MOD_DT, t.C_CCM_ID, t.N_SFZJC, TB.C_STA_DESC,max(tp.c_stl_grd) as C_STL_GRD ");
            strSql.Append(" FROM TPP_CAST t inner join tb_sta tb on t.c_ccm_id=tb.c_id inner join tsp_plan_sms tp on t.c_cast_no = tp.c_cast_no where 1=1 and tp.N_STATUS=1 ");
            if (C_INITIALIZE_ITEM.Trim() != "")
            {
                strSql.Append(" and t.C_INITIALIZE_ITEM = '" + C_INITIALIZE_ITEM + "' ");
            }
            if (C_CCM_ID.Trim() != "全部")
            {
                strSql.Append(" and t.C_CCM_ID = '" + C_CCM_ID + "' ");
            }
            strSql.Append(" group by t.C_ID, t.C_CAST_NO, t.C_CAST_LS, t.N_CAST_WGT, t.N_SORT, t.C_INITIALIZE_ITEM, t.N_STATUS, t.C_REMARK, t.C_EMP_ID, t.D_MOD_DT, t.C_CCM_ID, t.N_SFZJC, TB.C_STA_DESC order by t.C_CAST_NO,t.N_SORT ");
            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM TPP_CAST ");
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
            strSql.Append(")AS Row, T.*  from TPP_CAST T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            return DbHelperOra.Query(strSql.ToString());
        }


        /// <summary>
        /// 获取最大顺序号
        /// </summary>
        /// <param name="C_CCM_ID"></param>
        /// <returns></returns>
        public int GetMaxSort(string C_CCM_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select max(t.n_sort) as N_SORT from tpp_cast t where t.C_CCM_ID='" + C_CCM_ID + "' ");

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
        /// 获取最大浇次号
        /// </summary>
        /// <param name="C_CCM_ID"></param>
        /// <returns></returns>
        public string GetMaxCastNo(string C_CCM_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select max(T.C_CAST_NO) from tpp_cast t where t.C_CCM_ID='" + C_CCM_ID + "' ");

            object obj = DbHelperOra.GetSingle(strSql.ToString());
            if (obj == null)
            {
                return "0";
            }
            else
            {
                return obj.ToString();
            }
        }

        /// <summary>
        /// 获取浇次信息
        /// </summary>
        /// <param name="C_INITIALIZE_ITEM">方案号</param>
        /// <param name="C_CCM_ID">工位</param>
        /// <returns></returns>
        public DataSet GetList_JC(string C_INITIALIZE_ITEM, string C_CCM_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select tb.c_sta_desc as 铸机, t.c_cast_no as 浇次号, t.c_cast_ls as 炉数, t.n_cast_wgt as 重量, t.n_sort as 顺序, t.C_CCM_ID, t.C_INITIALIZE_ITEM  from TPP_CAST t inner join tb_sta tb on t.c_ccm_id = tb.c_id where t.c_initialize_item='" + C_INITIALIZE_ITEM + "' ");

            if (C_CCM_ID != "全部")
            {
                strSql.Append(" and t.C_CCM_ID='" + C_CCM_ID + "' ");
            }

            strSql.Append(" order by t.C_CCM_ID,t.n_sort ");
            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 修改生产顺序
        /// </summary>
        /// <param name="c_id">主键</param>
        /// <param name="C_CCM_ID">工位</param>
        /// <param name="C_INITIALIZE_ITEM">方案</param>
        /// <param name="sort_new">顺序-新</param>
        /// <param name="sort_old">顺序-旧</param>
        /// <param name="stype">判断大小</param>
        /// <returns></returns>
        public bool Update_SX(string c_id, string C_CCM_ID, string C_INITIALIZE_ITEM, int sort_new, int sort_old, string stype)
        {
            StringBuilder strSql = new StringBuilder();

            if (stype == "1")
            {
                strSql.Append(" update TPP_CAST t set t.n_sort=t.n_sort+1 where t.c_id not in ('" + c_id + "') and C_CCM_ID='" + C_CCM_ID + "' and t.C_INITIALIZE_ITEM='" + C_INITIALIZE_ITEM + "' and t.n_sort>=" + sort_new + " and t.n_sort<=" + sort_old + " ");
            }

            if (stype == "0")
            {
                strSql.Append(" update TPP_CAST t set t.n_sort=t.n_sort-1 where t.c_id not in ('" + c_id + "') and t.n_sort>" + sort_old + " and t.n_sort<=" + sort_new + " and C_CCM_ID='" + C_CCM_ID + "' and t.C_INITIALIZE_ITEM='" + C_INITIALIZE_ITEM + "'  ");
            }


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
        /// 更新浇次子计划
        /// </summary>
        /// <param name="P_INITIALIZE_ITEM_ID">订单方案号</param>
        /// <param name="P_CCM_CODE">连铸机代码</param>
        /// <returns></returns>
        public int Update_LG_Plan(string P_INITIALIZE_ITEM_ID, string P_CCM_CODE)
        {
            OracleParameter[] parameters = {
                    new OracleParameter("P_INITIALIZE_ITEM_ID", OracleDbType.Varchar2,100),
            new OracleParameter("P_CCM_CODE", OracleDbType.Varchar2,100)};

            parameters[0].Value = P_INITIALIZE_ITEM_ID;
            parameters[1].Value = P_CCM_CODE;

            return DbHelperOra.RunProcedure("pkg_p_plan.P_UPDATE_JCJH_SORT", parameters);
        }

        #endregion  BasicMethod
    }
}

