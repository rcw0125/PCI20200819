using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;
namespace DAL
{   /// <summary>
    /// 数据访问类:TPP_INITIALIZE_STA
    /// </summary>
    public partial class Dal_TPP_INITIALIZE_STA
    {
        public Dal_TPP_INITIALIZE_STA()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string C_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TPP_INITIALIZE_STA");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)         };
            parameters[0].Value = C_ID;

            return DbHelperOra.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Mod_TPP_INITIALIZE_STA model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TPP_INITIALIZE_STA(");
            strSql.Append("C_STA_ID,C_EMP_ID,D_MOD_DT,C_REMARK,N_PRODUCIBILITY_TIME,N_IMPACT_TIME,N_CAPACITY,C_PRO_CODE,C_INITIALIZE_ITEM_ID,N_WGT,C_STA_DESC,C_PRO_ID,C_STA_CODE,D_START_TIME,D_END_TIME)");
            strSql.Append(" values (");
            strSql.Append(":C_STA_ID,:C_EMP_ID,:D_MOD_DT,:C_REMARK,:N_PRODUCIBILITY_TIME,:N_IMPACT_TIME,:N_CAPACITY,:C_PRO_CODE,:C_INITIALIZE_ITEM_ID,:N_WGT,:C_STA_DESC,:C_PRO_ID,:C_STA_CODE,:D_START_TIME,:D_END_TIME)");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_STA_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,200),
                    new OracleParameter(":N_PRODUCIBILITY_TIME", OracleDbType.Decimal,15),
                    new OracleParameter(":N_IMPACT_TIME", OracleDbType.Decimal,15),
                    new OracleParameter(":N_CAPACITY", OracleDbType.Decimal,15),
                    new OracleParameter(":C_PRO_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_INITIALIZE_ITEM_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":C_STA_DESC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PRO_ID", OracleDbType.Varchar2,100),
                new OracleParameter(":C_STA_CODE", OracleDbType.Varchar2,100),
                new OracleParameter(":D_START_TIME", OracleDbType.Date),
                    new OracleParameter(":D_END_TIME", OracleDbType.Date)
            };
            parameters[0].Value = model.C_STA_ID;
            parameters[1].Value = model.C_EMP_ID;
            parameters[2].Value = model.D_MOD_DT;
            parameters[3].Value = model.C_REMARK;
            parameters[4].Value = model.N_PRODUCIBILITY_TIME;
            parameters[5].Value = model.N_IMPACT_TIME;
            parameters[6].Value = model.N_CAPACITY;
            parameters[7].Value = model.C_PRO_CODE;
            parameters[8].Value = model.C_INITIALIZE_ITEM_ID;
            parameters[9].Value = model.N_WGT;
            parameters[10].Value = model.C_STA_DESC;
            parameters[11].Value = model.C_PRO_ID;
            parameters[12].Value = model.C_STA_CODE;
            parameters[13].Value = model.D_START_TIME;
            parameters[14].Value = model.D_END_TIME;
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
        public bool Update(Mod_TPP_INITIALIZE_STA model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TPP_INITIALIZE_STA set ");
            strSql.Append("C_STA_ID=:C_STA_ID,");
            strSql.Append("C_EMP_ID=:C_EMP_ID,");
            strSql.Append("D_MOD_DT=:D_MOD_DT,");
            strSql.Append("C_REMARK=:C_REMARK,");
            strSql.Append("N_PRODUCIBILITY_TIME=:N_PRODUCIBILITY_TIME,");
            strSql.Append("N_IMPACT_TIME=:N_IMPACT_TIME,");
            strSql.Append("N_CAPACITY=:N_CAPACITY,");
            strSql.Append("C_PRO_CODE=:C_PRO_CODE,");
            strSql.Append("C_INITIALIZE_ITEM_ID=:C_INITIALIZE_ITEM_ID,");
            strSql.Append("N_WGT=:N_WGT,");
            strSql.Append("C_STA_DESC=:C_STA_DESC,");
            strSql.Append("D_START_TIME=:D_START_TIME,");
            strSql.Append("D_END_TIME=:D_END_TIME,");
            strSql.Append("C_PRO_ID=:C_PRO_ID");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_STA_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,200),
                    new OracleParameter(":N_PRODUCIBILITY_TIME", OracleDbType.Decimal,15),
                    new OracleParameter(":N_IMPACT_TIME", OracleDbType.Decimal,15),
                    new OracleParameter(":N_CAPACITY", OracleDbType.Decimal,15),
                    new OracleParameter(":C_PRO_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_INITIALIZE_ITEM_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":C_STA_DESC", OracleDbType.Varchar2,100),
                     new OracleParameter(":D_START_TIME", OracleDbType.Date),
                    new OracleParameter(":D_END_TIME", OracleDbType.Date),
                    new OracleParameter(":C_PRO_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.C_STA_ID;
            parameters[1].Value = model.C_EMP_ID;
            parameters[2].Value = model.D_MOD_DT;
            parameters[3].Value = model.C_REMARK;
            parameters[4].Value = model.N_PRODUCIBILITY_TIME;
            parameters[5].Value = model.N_IMPACT_TIME;
            parameters[6].Value = model.N_CAPACITY;
            parameters[7].Value = model.C_PRO_CODE;
            parameters[8].Value = model.C_INITIALIZE_ITEM_ID;
            parameters[9].Value = model.N_WGT;
            parameters[10].Value = model.C_STA_DESC;
            parameters[11].Value = model.D_START_TIME;
            parameters[12].Value = model.D_END_TIME;
            parameters[13].Value = model.C_PRO_ID;
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
            strSql.Append("delete from TPP_INITIALIZE_STA ");
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
            strSql.Append("delete from TPP_INITIALIZE_STA ");
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
        public Mod_TPP_INITIALIZE_STA GetModel(string C_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_STA_ID,C_EMP_ID,D_MOD_DT,C_REMARK,N_PRODUCIBILITY_TIME,N_IMPACT_TIME,N_CAPACITY,C_PRO_CODE,C_INITIALIZE_ITEM_ID,N_WGT,C_STA_DESC,C_PRO_ID,D_START_TIME,D_END_TIME from TPP_INITIALIZE_STA ");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)         };
            parameters[0].Value = C_ID;

            Mod_TPP_INITIALIZE_STA model = new Mod_TPP_INITIALIZE_STA();
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
        public Mod_TPP_INITIALIZE_STA DataRowToModel(DataRow row)
        {
            Mod_TPP_INITIALIZE_STA model = new Mod_TPP_INITIALIZE_STA();
            if (row != null)
            {
                if (row["C_ID"] != null)
                {
                    model.C_ID = row["C_ID"].ToString();
                }
                if (row["C_STA_ID"] != null)
                {
                    model.C_STA_ID = row["C_STA_ID"].ToString();
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
                if (row["N_PRODUCIBILITY_TIME"] != null && row["N_PRODUCIBILITY_TIME"].ToString() != "")
                {
                    model.N_PRODUCIBILITY_TIME = decimal.Parse(row["N_PRODUCIBILITY_TIME"].ToString());
                }
                if (row["N_IMPACT_TIME"] != null && row["N_IMPACT_TIME"].ToString() != "")
                {
                    model.N_IMPACT_TIME = decimal.Parse(row["N_IMPACT_TIME"].ToString());
                }
                if (row["N_CAPACITY"] != null && row["N_CAPACITY"].ToString() != "")
                {
                    model.N_CAPACITY = decimal.Parse(row["N_CAPACITY"].ToString());
                }
                if (row["C_PRO_CODE"] != null)
                {
                    model.C_PRO_CODE = row["C_PRO_CODE"].ToString();
                }
                if (row["C_INITIALIZE_ITEM_ID"] != null)
                {
                    model.C_INITIALIZE_ITEM_ID = row["C_INITIALIZE_ITEM_ID"].ToString();
                }
                if (row["N_WGT"] != null && row["N_WGT"].ToString() != "")
                {
                    model.N_WGT = decimal.Parse(row["N_WGT"].ToString());
                }
                if (row["C_STA_DESC"] != null)
                {
                    model.C_STA_DESC = row["C_STA_DESC"].ToString();
                }
                if (row["C_PRO_ID"] != null)
                {
                    model.C_PRO_ID = row["C_PRO_ID"].ToString();
                }
                if (row["D_START_TIME"] != null && row["D_START_TIME"].ToString() != "")
                {
                    model.D_START_TIME = DateTime.Parse(row["D_START_TIME"].ToString());
                }
                if (row["D_END_TIME"] != null && row["D_END_TIME"].ToString() != "")
                {
                    model.D_END_TIME = DateTime.Parse(row["D_END_TIME"].ToString());
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
            strSql.Append("select C_ID,C_STA_ID,C_EMP_ID,D_MOD_DT,C_REMARK,N_PRODUCIBILITY_TIME,N_IMPACT_TIME,N_CAPACITY,C_PRO_CODE,C_INITIALIZE_ITEM_ID,N_WGT,C_STA_DESC,C_PRO_ID ,D_START_TIME,D_END_TIME");
            strSql.Append(" FROM TPP_INITIALIZE_STA ");
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
            strSql.Append("select count(1) FROM TPP_INITIALIZE_STA ");
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
            strSql.Append(")AS Row, T.*  from TPP_INITIALIZE_STA T ");
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
        /// 获取方案工位
        /// </summary>
        /// <param name="C_STA_ID">工位</param>
        /// <param name="C_INITIALIZE_ITEM_ID">方案表主键</param>
        /// <returns></returns>
        public DataSet GetList(string C_PRO_ID, string C_STA_ID, string C_INITIALIZE_ITEM_ID, string type)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select tb.c_sta_desc,tb.c_sta_code,tb.c_id ");
            strSql.Append(" FROM TPP_INITIALIZE_STA ta inner join tb_sta tb on ta.c_sta_id=tb.c_id WHERE 1=1 ");
            if (type.Trim() != "")
            {
                strSql.Append(" AND ta.N_WGT<>0 ");
            }
            if (C_PRO_ID.Trim() != "")
            {
                strSql.Append(" AND ta.C_PRO_ID='" + C_PRO_ID + "' ");
            }
            if (C_STA_ID.Trim() != "全部")
            {
                strSql.Append(" AND tb.c_id='" + C_STA_ID + "' ");
            }
            if (C_INITIALIZE_ITEM_ID.Trim() != "")
            {
                strSql.Append(" AND ta.C_INITIALIZE_ITEM_ID='" + C_INITIALIZE_ITEM_ID + "' ");
            }
            strSql.Append(" ORDER BY  C_STA_CODE");
            return DbHelperOra.Query(strSql.ToString());
        }



        /// <summary>
        ///获取选中方案排产工位信息
        /// </summary>
        /// <param name="C_PRO_ID">工序主键</param>
        /// <param name="C_INITIALIZE_ITEM_ID">方案主键</param>
        /// <returns></returns>
        public DataSet GetListByFaid(string C_PRO_CODE, string C_INITIALIZE_ITEM_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_STA_ID,C_EMP_ID,D_MOD_DT,C_REMARK,N_PRODUCIBILITY_TIME,N_IMPACT_TIME,N_CAPACITY,C_PRO_CODE,C_INITIALIZE_ITEM_ID,N_WGT,C_STA_DESC,C_PRO_ID,C_STA_CODE,D_START_TIME,D_END_TIME ");
            strSql.Append(" FROM TPP_INITIALIZE_STA WHERE 1=1  ");

            if (C_PRO_CODE.Trim() != "")
            {
                strSql.Append(" AND C_PRO_CODE='" + C_PRO_CODE + "' ");
            }

            if (C_INITIALIZE_ITEM_ID.Trim() != "")
            {
                strSql.Append(" AND C_INITIALIZE_ITEM_ID='" + C_INITIALIZE_ITEM_ID + "' ");
            }
            else
            {
                strSql.Append(" AND C_INITIALIZE_ITEM_ID IS NULL ");
            }
            strSql.Append(" ORDER BY  C_STA_CODE");
            return DbHelperOra.Query(strSql.ToString());
        }


        /// <summary>
        /// 删除该方案下工位数据
        /// </summary>
        /// <param name="C_INITIALIZE_ITEM_ID">方案id</param>
        /// <returns></returns>
        public bool DeleteByItemID(string C_INITIALIZE_ITEM_ID)
        {
            int rows = 0;
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from TPP_INITIALIZE_STA ");
            if (C_INITIALIZE_ITEM_ID.Trim()!="")
            {
                strSql.Append(" where C_INITIALIZE_ITEM_ID=:C_ID ");
                OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)         };
                parameters[0].Value = C_INITIALIZE_ITEM_ID;

                 rows = DbHelperOra.ExecuteSql(strSql.ToString(), parameters);
            }
            else
            {
                 rows = DbHelperOra.ExecuteSql(strSql.ToString());
            }
           
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
        /// 修改该方案下工位的数据
        /// </summary>
        /// <param name="C_INITIALIZE_ITEM_ID">方案id</param>
        /// <param name="C_STA_ID">工位id</param>
        /// <returns></returns>
        public bool UpdateBySTAFID(string C_INITIALIZE_ITEM_ID, string C_STA_ID, decimal? N_WGT)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TPP_INITIALIZE_STA set N_WGT=N_WGT+:N_WGT ");
            strSql.Append(" where C_INITIALIZE_ITEM_ID=:C_INITIALIZE_ITEM_ID AND C_STA_ID=:C_STA_ID");
            OracleParameter[] parameters = { new OracleParameter(":N_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":C_INITIALIZE_ITEM_ID", OracleDbType.Varchar2,100) ,
               new OracleParameter(":C_STA_ID", OracleDbType.Varchar2,100)   };
            parameters[0].Value = N_WGT;
            parameters[1].Value = C_INITIALIZE_ITEM_ID;
            parameters[2].Value = C_STA_ID;
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
        /// 根据方案主键，工序代码加载未匹配炼钢路线的工位信息
        /// </summary>
        /// <param name="C_INITIALIZE_ITEM_ID">方案主键</param>
        /// <param name="C_PRO_CODE">工序代码</param>
        /// <returns></returns>
        public DataTable GetLGGXGWByIniID(string C_INITIALIZE_ITEM_ID, string C_PRO_CODE)
        {
            string sql = @"SELECT T.C_STA_ID, T.C_INITIALIZE_ITEM_ID, T.C_PRO_CODE, T.C_STA_CODE, T.C_STA_DESC,T.D_START_TIME,T.D_END_TIME FROM TPP_INITIALIZE_STA T WHERE T.C_INITIALIZE_ITEM_ID NOT IN     (SELECT A.C_INITIALIZE_ITEM_ID  FROM TPP_INITIALIZE_LINE A WHERE 1=1 ";

            sql = sql + " AND nvl( T.C_INITIALIZE_ITEM_ID,'0') = nvl(A.C_INITIALIZE_ITEM_ID ,'0')";


            sql = sql + "  AND(T.C_STA_ID = A.C_ZL_STA_ID OR   T.C_STA_ID = A.C_JL_STA_ID OR   T.C_STA_ID = A.C_ZK_STA_ID OR   T.C_STA_ID = A.C_LZ_STA_ID) ";
            sql = sql + ")";
            sql = sql + " AND T.C_PRO_CODE = '" + C_PRO_CODE + "' ";
            if (C_INITIALIZE_ITEM_ID.Trim() != "")
            {
                sql = sql + " AND T.C_INITIALIZE_ITEM_ID='" + C_INITIALIZE_ITEM_ID + "' ";
            }
            else
            {
                sql = sql + " AND T.C_INITIALIZE_ITEM_ID IS NULL ";
            }
            
            sql = sql + " ORDER BY  T.C_STA_CODE ";
            return DbHelperOra.Query(sql).Tables[0];
        }

        /// <summary>
        /// 获取当前方案的工序工位
        /// </summary>
        /// <param name="strIniID">方案主键</param>
        /// <param name="strGX">工序代码</param>
        /// <returns>工位列表</returns>
        public DataTable GetGXGWByIni(string strIniID, string strGX)
        {
            string sql = " SELECT T.C_STA_ID, T.C_STA_CODE, T.C_STA_DESC, B.C_PRO_CODE FROM TPP_INITIALIZE_STA T, TB_STA A, TB_PRO B WHERE T.C_STA_ID = A.C_ID AND A.C_PRO_ID = B.C_ID ";
            if (strIniID.Trim()!="")
            {
                sql = sql + " AND T.C_INITIALIZE_ITEM_ID = '" + strIniID + "' ";
            }
            sql = sql + " AND B.C_PRO_CODE = '" + strGX + "' ";
            sql = sql + "  ORDER BY A.N_SORT  ";
            return DbHelperOra.Query(sql).Tables[0];

        }

        /// <summary>
        /// 获取当前方案的工序工位
        /// </summary>
        /// <param name="strIniID">方案主键</param>
        /// <param name="strGX">工序代码</param>
        /// <returns>工位列表</returns>
        public DataTable GetGXGWByBXG(string strIniID, string strGX)
        {
            string sql = " SELECT T.C_STA_ID, T.C_STA_CODE, T.C_STA_DESC, B.C_PRO_CODE FROM TPP_INITIALIZE_STA T, TB_STA A, TB_PRO B WHERE T.C_STA_ID = A.C_ID AND A.C_PRO_ID = B.C_ID  AND T.C_STA_CODE='6#CC' ";
            if (strIniID.Trim() != "")
            {
                sql = sql + " AND T.C_INITIALIZE_ITEM_ID = '" + strIniID + "' ";
            }
            sql = sql + " AND B.C_PRO_CODE = '" + strGX + "' ";
            sql = sql + "  ORDER BY A.N_SORT  ";
            return DbHelperOra.Query(sql).Tables[0];

        }

        /// <summary>
        /// 获取工位开始时间
        /// </summary>
        /// <param name="C_STA_ID">工位主键</param>
        /// <returns></returns>
        public string Get_StartTime(string C_STA_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select Max(D_START_TIME) FROM TPP_INITIALIZE_STA where C_STA_ID='" + C_STA_ID + "' ");

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

        #endregion  ExtensionMethod
    }
}
