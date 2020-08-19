using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;
namespace DAL
{
    /// <summary>
    /// 数据访问类:TB_SLAB_MATRAL
    /// </summary>
    public partial class Dal_TB_SLAB_MATRAL
    {
        public Dal_TB_SLAB_MATRAL()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string C_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TB_SLAB_MATRAL");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,50)          };
            parameters[0].Value = C_ID;

            return DbHelperOra.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Mod_TB_SLAB_MATRAL model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TB_SLAB_MATRAL(");
            strSql.Append("C_MATRAL_CODE,C_STL_GRD,C_STD_CODE,N_STATUS,C_EMP_ID,D_MOD_DT,C_REMARK,C_ROUTE_DESC)");
            strSql.Append(" values (");
            strSql.Append(":C_MATRAL_CODE,:C_STL_GRD,:C_STD_CODE,:N_STATUS,:C_EMP_ID,:D_MOD_DT,:C_REMARK,:C_ROUTE_DESC)");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_MATRAL_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STL_GRD", OracleDbType.Varchar2,50),
                    new OracleParameter(":C_STD_CODE", OracleDbType.Varchar2,50),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_ROUTE_DESC", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.C_MATRAL_CODE;
            parameters[1].Value = model.C_STL_GRD;
            parameters[2].Value = model.C_STD_CODE;
            parameters[3].Value = model.N_STATUS;
            parameters[4].Value = model.C_EMP_ID;
            parameters[5].Value = model.D_MOD_DT;
            parameters[6].Value = model.C_REMARK;
            parameters[7].Value = model.C_ROUTE_DESC;

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
        public bool Update(Mod_TB_SLAB_MATRAL model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TB_SLAB_MATRAL set ");
            strSql.Append("C_MATRAL_CODE=:C_MATRAL_CODE,");
            strSql.Append("C_STL_GRD=:C_STL_GRD,");
            strSql.Append("C_STD_CODE=:C_STD_CODE,");
            strSql.Append("N_STATUS=:N_STATUS,");
            strSql.Append("C_EMP_ID=:C_EMP_ID,");
            strSql.Append("D_MOD_DT=:D_MOD_DT,");
            strSql.Append("C_REMARK=:C_REMARK,");
            strSql.Append("C_ROUTE_DESC=:C_ROUTE_DESC ");//C_ROUTE_DESC
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_MATRAL_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STL_GRD", OracleDbType.Varchar2,50),
                    new OracleParameter(":C_STD_CODE", OracleDbType.Varchar2,50),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
                      new OracleParameter(":C_ROUTE_DESC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,50)};
            parameters[0].Value = model.C_MATRAL_CODE;
            parameters[1].Value = model.C_STL_GRD;
            parameters[2].Value = model.C_STD_CODE;
            parameters[3].Value = model.N_STATUS;
            parameters[4].Value = model.C_EMP_ID;
            parameters[5].Value = model.D_MOD_DT;
            parameters[6].Value = model.C_REMARK;
            parameters[7].Value = model.C_ROUTE_DESC;
            parameters[8].Value = model.C_ID;

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
            strSql.Append("delete from TB_SLAB_MATRAL ");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,50)          };
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
            strSql.Append("delete from TB_SLAB_MATRAL ");
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
        public Mod_TB_SLAB_MATRAL GetModel(string C_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_MATRAL_CODE,C_STL_GRD,C_STD_CODE,N_STATUS,C_EMP_ID,D_MOD_DT,C_REMARK,C_ROUTE_DESC from TB_SLAB_MATRAL ");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,50)          };
            parameters[0].Value = C_ID;

            Mod_TB_SLAB_MATRAL model = new Mod_TB_SLAB_MATRAL();
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
        public Mod_TB_SLAB_MATRAL DataRowToModel(DataRow row)
        {
            Mod_TB_SLAB_MATRAL model = new Mod_TB_SLAB_MATRAL();
            if (row != null)
            {
                if (row["C_ID"] != null)
                {
                    model.C_ID = row["C_ID"].ToString();
                }
                if (row["C_MATRAL_CODE"] != null)
                {
                    model.C_MATRAL_CODE = row["C_MATRAL_CODE"].ToString();
                }
                if (row["C_STL_GRD"] != null)
                {
                    model.C_STL_GRD = row["C_STL_GRD"].ToString();
                }
                if (row["C_STD_CODE"] != null)
                {
                    model.C_STD_CODE = row["C_STD_CODE"].ToString();
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
                if (row["C_REMARK"] != null)
                {
                    model.C_REMARK = row["C_REMARK"].ToString();
                }
                if (row["C_ROUTE_DESC"] != null)
                {
                    model.C_ROUTE_DESC = row["C_ROUTE_DESC"].ToString();
                }
                
            }
            return model;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string C_STL_GRD, string C_STD_CODE,string C_ROUTE_DESC)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select t.C_ID,t.C_MATRAL_CODE,t1.c_mat_name,t1.n_lth,t1.c_slab_size,t1.n_hsl,t.C_STL_GRD,t.C_STD_CODE,t.N_STATUS,t.C_EMP_ID,t.D_MOD_DT,t.C_REMARK ,t.C_ROUTE_DESC FROM TB_SLAB_MATRAL t JOIN tb_matrl_main t1   ON t.c_matral_code=t1.c_id WHERE t.n_status=1     AND t.c_stl_grd='" + C_STL_GRD + "' and t.C_STD_CODE='" + C_STD_CODE + "' AND T.C_ROUTE_DESC='" + C_ROUTE_DESC + "' ");
            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM TB_SLAB_MATRAL ");
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
            strSql.Append(")AS Row, T.*  from TB_SLAB_MATRAL T ");
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
 //       /// <summary>
 //       /// 获取钢坯物料信息
 //       /// </summary>
 //       /// <param name="C_STL_GRD">钢种</param>
 //       /// <param name="C_STD_CODE">执行标准</param>
 //       /// <param name="C_TYPE">钢坯类型61(611\612)小方坯连铸坯613大方坯连铸坯614热轧钢坯</param>
 //       /// <param name="C_SLAB_SIZE">连铸坯断面</param>
 //       /// <param name="N_SLAB_LEN">钢坯定尺</param>
 //       /// <param name="C_KP_SIZE">热轧坯断面</param>
 //       /// <param name="N_KP_LEN">热轧坯定尺</param>
 //       /// <returns>物料信息</returns>
 //       public DataTable GetSlabMatral(string C_STL_GRD,string C_STD_CODE,string C_TYPE,string C_SLAB_SIZE,int? N_SLAB_LEN, string C_KP_SIZE,int? N_KP_LEN)
 //       {
 //           string sql = @"SELECT T.C_STL_GRD,
 //      T.C_STD_CODE,
 //      TB.C_ID,
 //      TB.C_MAT_NAME,
 //      TB.C_SLAB_SIZE,
 //      TB.N_LTH,
 //      TB.N_HSL,
 //      TN.C_KP_SIZE,
 //      TN.N_KP_LENTH,
 //      M.C_ID C_KP_CODE,
 //      M.C_MAT_NAME C_KP_NAME,
 //      M.N_HSL N_KP_PW
 // FROM TB_SLAB_MATRAL T
 // LEFT JOIN TB_MATRL_MAIN TB
 //   ON T.C_MATRAL_CODE = TB.C_ID
 // LEFT JOIN TB_MATRL_CONTRAST TN
 //   ON TB.C_SLAB_SIZE = TN.C_SLAB_SIZE
 //  AND TB.N_LTH = TN.N_SLAB_LENTH
 // LEFT JOIN(SELECT T.C_STL_GRD,
 //                   T.C_STD_CODE,
 //                   TB.C_ID,
 //                   TB.C_MAT_NAME,
 //                   TB.C_SLAB_SIZE,
 //                   TB.N_LTH,
 //                   TB.N_HSL
 //              FROM TB_SLAB_MATRAL T
 //              LEFT JOIN TB_MATRL_MAIN TB
 //                ON T.C_MATRAL_CODE = TB.C_ID) M
 //   ON T.C_STL_GRD = M.C_STL_GRD
 //  AND T.C_STD_CODE = M.C_STD_CODE
 //  AND TN.C_KP_SIZE = M.C_SLAB_SIZE
 //  AND TN.N_KP_LENTH = M.N_LTH
 //WHERE T.C_STL_GRD = '"+ C_STL_GRD + "'";
 //           sql = sql + @"  AND T.C_STD_CODE = '"+ C_STD_CODE + "'";

 //           if (C_TYPE.Trim()=="61")
 //           {
 //               sql = sql + @"  AND (TB.C_ID like '" + 611 + "%' or TB.C_ID like '" + 612 + "%')";
 //           }
 //           if (C_TYPE.Trim() == "613")
 //           {
 //               sql = sql + @"  AND TB.C_ID like '" + 613 + "%'";
 //           }
 //           if (C_TYPE.Trim() == "614")
 //           {
 //               sql = sql + @"  AND TB.C_ID like '" + 614 + "%'";
 //           }

 //           if (C_SLAB_SIZE.Trim() != "")
 //           {
 //               sql = sql + @"  AND TB.C_SLAB_SIZE = '" + C_SLAB_SIZE + "'";
 //           }
 //           if (N_SLAB_LEN!=null)
 //           {
 //               sql = sql + @"  AND TB.N_LTH = " + N_SLAB_LEN  ;
 //           }
 //           if (C_KP_SIZE.Trim() != "")
 //           {
 //               sql = sql + @"  AND TN.C_KP_SIZE = '" + C_KP_SIZE + "'";
 //           }

 //           if (N_KP_LEN != null)
 //           {
 //               sql = sql + @"  AND  TN.N_KP_LENTH = " + N_KP_LEN;
 //           }

 //           sql =sql+@" ORDER BY DECODE(TB.N_LTH, 6120, 1, 5850, 2, 10500, 3, 10700, 4, 10300, 5, 10850, 6, 11000, 7, 9100, 8, 9) ";

 //           return DbHelperOra.Query(sql).Tables[0];
 //       }


        /// <summary>
        /// 根据钢种执行标准获取连铸坯物料信息
        /// </summary>
        /// <param name="C_STL_GRD">钢种</param>
        /// <param name="C_STD_CODE">执行标准</param>
        /// <param name="C_CCM_ID">连铸机主键，6#连铸机断面为150*150，其他铸机默认为160*160或280*325</param>
        public DataTable GetCCMSlabMatral(string C_STL_GRD, string C_STD_CODE, string C_CCM_ID)
        {
            string sql = "SELECT T.C_STL_GRD,       T.C_STD_CODE,       TB.C_ID,       TB.C_MAT_NAME,       TB.C_SLAB_SIZE,       TB.N_LTH,       TB.N_HSL,T.C_ROUTE_DESC  FROM TB_SLAB_MATRAL T  LEFT JOIN TB_MATRL_MAIN TB    ON T.C_MATRAL_CODE = TB.C_ID WHERE   (T.C_ID LIKE '611%' OR T.C_ID LIKE '612%' OR T.C_ID LIKE '613%') AND t.n_status = 1 AND t.c_stl_grd = '" + C_STL_GRD + "' AND t.c_std_code = '" + C_STD_CODE + "'";
            if (C_CCM_ID == "01C145B259E740F6A258AF313DD9268C")//6#连铸
            {
                sql = sql + "  AND TB.C_SLAB_SIZE = '150*150' ";

            }

            sql = sql + " ORDER BY DECODE( TB.N_LTH,6120,1,5850,2,6070,3,10500,4,10300,5,10700,6,10000,7,8) ";

            return DbHelperOra.Query(sql).Tables[0];

        }




        #endregion  ExtensionMethod


        /// <summary>
        /// 获取物料编码列表
        /// </summary>
        /// <param name="C_STL_GRD">钢种</param>
        /// <param name="C_STD_CODE">执行标准</param>
        /// <returns></returns>
        public DataSet Get_MatCode_List(string C_STL_GRD, string C_STD_CODE)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT TB.C_STL_GRD,T.C_MATRAL_CODE,TB.C_MAT_NAME,TB.C_SLAB_SIZE,TB.N_LTH,TB.N_HSL,T.C_ROUTE_DESC FROM TB_SLAB_MATRAL T INNER JOIN TB_MATRL_MAIN TB ON T.C_MATRAL_CODE=TB.C_MAT_CODE WHERE T.N_STATUS=1 AND T.C_STL_GRD='" + C_STL_GRD + "'");

            
            if (C_STD_CODE.Contains("Q/XG") || C_STD_CODE.Contains("GB/T") || C_STD_CODE.Contains("Q/邢钢"))
            {
                C_STD_CODE = C_STD_CODE.Split('-')[0].Split('.')[0];
                strSql.Append(" AND T.C_STD_CODE LIKE '" + C_STD_CODE + "%'");
                //sql = sql + " AND T.C_STD_CODE LIKE '" + C_STD_CODE + "%'";
            }
            else
            {
                strSql.Append(" AND T.C_STD_CODE='" + C_STD_CODE + "'");
               // sql = sql + "   AND T.C_STD_CODE = '" + C_STD_CODE + "'";
            }


            strSql.Append( " AND TB.C_SLAB_SIZE<>'280*325' ORDER BY TB.C_SLAB_SIZE,TB.N_LTH ");
            return DbHelperOra.Query(strSql.ToString());
        }
    }
}

