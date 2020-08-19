using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;
namespace DAL
{
    /// <summary>
    /// 数据访问类:TQB_GP_LCP_BASIS
    /// </summary>
    public partial class Dal_TQB_GP_LCP_BASIS
    {
        public Dal_TQB_GP_LCP_BASIS()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string C_MAT_CODE_PLAN)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TQB_GP_LCP_BASIS");
            strSql.Append(" where C_MAT_CODE_PLAN=:C_MAT_CODE_PLAN and N_STATUS=1 ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_MAT_CODE_PLAN", OracleDbType.Varchar2,100)         };
            parameters[0].Value = C_MAT_CODE_PLAN;

            return DbHelperOra.Exists(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string C_MAT_CODE_PLAN, string C_MAT_CODE_GP, string C_STL_GRD, string C_STD_CODE)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TQB_GP_LCP_BASIS");
            strSql.Append(" where C_MAT_CODE_PLAN='" + C_MAT_CODE_PLAN + "' and C_MAT_CODE_GP='" + C_MAT_CODE_GP + "' and C_STL_GRD='" + C_STL_GRD + "' and C_STD_CODE='" + C_STD_CODE + "' and N_STATUS=1 ");

            return DbHelperOra.Exists(strSql.ToString());
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Mod_TQB_GP_LCP_BASIS model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TQB_GP_LCP_BASIS(");
            strSql.Append("C_MAT_CODE_PLAN,C_MAT_CODE_GP,N_STATUS,C_REMARK,C_EMP_ID,N_SORT,C_STL_GRD,C_STD_CODE)");
            strSql.Append(" values (");
            strSql.Append(":C_MAT_CODE_PLAN,:C_MAT_CODE_GP,:N_STATUS,:C_REMARK,:C_EMP_ID,:N_SORT,:C_STL_GRD,:C_STD_CODE)");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_MAT_CODE_PLAN",OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MAT_CODE_GP",OracleDbType.Varchar2,100),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
                    new OracleParameter(":C_REMARK",OracleDbType.Varchar2,500),
                    new OracleParameter(":C_EMP_ID",OracleDbType.Varchar2,100),
                    new OracleParameter(":N_SORT", OracleDbType.Decimal,5),
                    new OracleParameter(":C_STL_GRD",OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STD_CODE",OracleDbType.Varchar2,100)};
            parameters[0].Value = model.C_MAT_CODE_PLAN;
            parameters[1].Value = model.C_MAT_CODE_GP;
            parameters[2].Value = model.N_STATUS;
            parameters[3].Value = model.C_REMARK;
            parameters[4].Value = model.C_EMP_ID;
            parameters[5].Value = model.N_SORT;
            parameters[6].Value = model.C_STL_GRD;
            parameters[7].Value = model.C_STD_CODE;

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
        public bool Update(Mod_TQB_GP_LCP_BASIS model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TQB_GP_LCP_BASIS set ");
            strSql.Append("C_MAT_CODE_PLAN=:C_MAT_CODE_PLAN,");
            strSql.Append("C_MAT_CODE_GP=:C_MAT_CODE_GP,");
            strSql.Append("N_STATUS=:N_STATUS,");
            strSql.Append("C_REMARK=:C_REMARK,");
            strSql.Append("C_EMP_ID=:C_EMP_ID,");
            strSql.Append("D_MOD_DT=:D_MOD_DT,");
            strSql.Append("N_SORT=:N_SORT,");
            strSql.Append("C_STL_GRD=:C_STL_GRD,");
            strSql.Append("C_STD_CODE=:C_STD_CODE");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_MAT_CODE_PLAN",OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MAT_CODE_GP",OracleDbType.Varchar2,100),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
                    new OracleParameter(":C_REMARK",OracleDbType.Varchar2,500),
                    new OracleParameter(":C_EMP_ID",OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":N_SORT", OracleDbType.Decimal,5),
                    new OracleParameter(":C_STL_GRD",OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STD_CODE",OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ID",OracleDbType.Varchar2,100)};
            parameters[0].Value = model.C_MAT_CODE_PLAN;
            parameters[1].Value = model.C_MAT_CODE_GP;
            parameters[2].Value = model.N_STATUS;
            parameters[3].Value = model.C_REMARK;
            parameters[4].Value = model.C_EMP_ID;
            parameters[5].Value = model.D_MOD_DT;
            parameters[6].Value = model.N_SORT;
            parameters[7].Value = model.C_STL_GRD;
            parameters[8].Value = model.C_STD_CODE;
            parameters[9].Value = model.C_ID;

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
            strSql.Append("delete from TQB_GP_LCP_BASIS ");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID",OracleDbType.Varchar2,100)          };
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
            strSql.Append("delete from TQB_GP_LCP_BASIS ");
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
        public Mod_TQB_GP_LCP_BASIS GetModel(string C_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_MAT_CODE_PLAN,C_MAT_CODE_GP,N_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT,N_SORT,C_STL_GRD,C_STD_CODE from TQB_GP_LCP_BASIS ");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID",OracleDbType.Varchar2,100)          };
            parameters[0].Value = C_ID;

            Mod_TQB_GP_LCP_BASIS model = new Mod_TQB_GP_LCP_BASIS();
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
        public Mod_TQB_GP_LCP_BASIS DataRowToModel(DataRow row)
        {
            Mod_TQB_GP_LCP_BASIS model = new Mod_TQB_GP_LCP_BASIS();
            if (row != null)
            {
                if (row["C_ID"] != null)
                {
                    model.C_ID = row["C_ID"].ToString();
                }
                if (row["C_MAT_CODE_PLAN"] != null)
                {
                    model.C_MAT_CODE_PLAN = row["C_MAT_CODE_PLAN"].ToString();
                }
                if (row["C_MAT_CODE_GP"] != null)
                {
                    model.C_MAT_CODE_GP = row["C_MAT_CODE_GP"].ToString();
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
                if (row["N_SORT"] != null && row["N_SORT"].ToString() != "")
                {
                    model.N_SORT = decimal.Parse(row["N_SORT"].ToString());
                }
                if (row["C_STL_GRD"] != null)
                {
                    model.C_STL_GRD = row["C_STL_GRD"].ToString();
                }
                if (row["C_STD_CODE"] != null)
                {
                    model.C_STD_CODE = row["C_STD_CODE"].ToString();
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
            strSql.Append("select C_ID,C_MAT_CODE_PLAN,C_MAT_CODE_GP,N_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT,N_SORT,C_STL_GRD,C_STD_CODE ");
            strSql.Append(" FROM TQB_GP_LCP_BASIS ");
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
            strSql.Append("select count(1) FROM TQB_GP_LCP_BASIS ");
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
        /// 获取联产品计划信息
        /// </summary>
        /// <param name="strGZ">钢种</param>
        /// <param name="strMatName">物料名称</param>
        /// <returns></returns>
		public DataSet GetList(string strGZ, string strMatName)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT TA.C_MAT_CODE_PLAN as 物料编码,TB.C_STL_GRD as 钢种,TB.C_SPEC as 规格,TB.C_MAT_NAME as 物料名称 FROM TQB_GP_LCP_BASIS TA INNER JOIN TB_MATRL_MAIN TB ON TA.C_MAT_CODE_PLAN=TB.C_MAT_CODE WHERE TA.N_STATUS=1  ");

            if (strGZ.Trim() != "")
            {
                strSql.Append(" AND TB.C_STL_GRD LIKE '%" + strGZ + "%' ");
            }

            if (strMatName.Trim() != "")
            {
                strSql.Append(" AND TA.C_MAT_CODE_PLAN LIKE '%" + strMatName + "%' ");
            }


            strSql.Append(" GROUP BY TA.C_MAT_CODE_PLAN,TB.C_MAT_NAME,TB.C_STL_GRD,TB.C_SPEC ORDER BY TA.C_MAT_CODE_PLAN ");

            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取联产品改判信息
        /// </summary>
        /// <param name="C_MAT_CODE_PLAN">物料编码</param>
        /// <param name="stl">钢种</param>
        /// <param name="std">执行标准</param>
        /// <param name="C_SLAB_SIZE">规格</param>
        /// <returns></returns>
		public DataSet Get_Item_List(string C_MAT_CODE_PLAN, string stl, string std, string C_SLAB_SIZE)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT TA.C_MAT_CODE_GP AS 物料编码, TB.C_MAT_NAME AS 物料名称, TA.C_STL_GRD AS 钢种, TB.N_LTH AS 定尺, TB.C_SLAB_SIZE AS 规格, TA.C_STD_CODE AS 执行标准, MAX(TD.C_ZYX1) AS 自由项1, MAX(TD.C_ZYX2) AS 自由项2  FROM TQB_GP_LCP_BASIS TA INNER JOIN TB_MATRL_MAIN TB ON TA.C_MAT_CODE_GP = TB.C_MAT_CODE INNER JOIN TQB_STD_MAIN TC ON TC.C_STL_GRD = TA.C_STL_GRD AND TC.C_STD_CODE = TA.C_STD_CODE LEFT JOIN TB_STD_CONFIG TD ON TD.C_STD_CODE = TC.C_STD_CODE AND TD.C_STL_GRD = TC.C_STL_GRD WHERE TA.N_STATUS = 1 AND TC.N_IS_CHECK = 1 AND TC.N_STATUS = 1 AND NVL(TC.N_STATUS, 1) = 1 AND NVL(TD.N_STATUS, 1) = 1  ");

            if (C_MAT_CODE_PLAN.Trim() != "")
            {
                strSql.Append(" AND TA.C_MAT_CODE_PLAN = '" + C_MAT_CODE_PLAN + "' ");
            }
            if (!string.IsNullOrEmpty(stl))
            {
                strSql.Append("  AND TA.C_STL_GRD like '%" + stl + "%'");
            }
            if (!string.IsNullOrEmpty(std))
            {
                strSql.Append("  AND TA.C_STD_CODE like '%" + std + "%'");
            }
            if (!string.IsNullOrEmpty(C_SLAB_SIZE))
            {
                strSql.Append("  AND  Tb.C_SLAB_SIZE like '%" + C_SLAB_SIZE + "%'");
            }

            strSql.Append("  GROUP BY TA.C_MAT_CODE_PLAN, TA.C_MAT_CODE_GP, TB.C_MAT_NAME, TA.C_STL_GRD, TB.N_LTH, TB.C_SLAB_SIZE, TA.C_STD_CODE, TD.C_ZYX1, TD.C_ZYX2 ");
            strSql.Append("  ORDER BY TA.C_MAT_CODE_PLAN, TA.C_MAT_CODE_GP ");

            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取来料钢坯物料信息
        /// </summary>
        /// <param name="C_MAT_CODE_PLAN">物料编码</param>
        /// <param name="stl">钢种</param>
        /// <param name="std">执行标准</param> 
        /// <returns></returns>
        public DataSet Get_Item_List_WLGP(string C_MAT_CODE, string stl, string std )
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT T.C_MAT_CODE  AS 物料编码, T.C_MAT_NAME  AS 物料名称,T.C_STL_GRD   AS 钢种,T.C_SLAB_SIZE AS 规格,TB.C_STD_CODE AS 执行标准,T.N_LTH       AS 定尺,TD.C_ZYX1     AS 自由项1,TD.C_ZYX2     AS 自由项2 FROM TB_MATRL_MAIN T INNER JOIN TQB_STD_MAIN TB  ON T.C_STL_GRD = TB.C_STL_GRD LEFT JOIN TB_STD_CONFIG TD  ON TD.C_STD_CODE = TB.C_STD_CODE  AND TD.C_STL_GRD = TB.C_STL_GRD WHERE T.C_CLS_TYPE = 'N' AND NVL(TD.N_STATUS, 1) = 1 AND TB.N_IS_CHECK = 1 AND TB.N_STATUS = 1 AND T.C_MAT_TYPE = 6  AND T.C_MAT_NAME LIKE '%来料%'  ");

            if (C_MAT_CODE.Trim() != "")
            {
                strSql.Append(" AND T.C_MAT_CODE = '" + C_MAT_CODE + "' ");
            }
            if (!string.IsNullOrEmpty(stl))
            {
                strSql.Append("  AND T.C_STL_GRD like '%" + stl + "%'");
            }
            if (!string.IsNullOrEmpty(std))
            {
                strSql.Append("  AND TB.C_STD_CODE like '%" + std + "%'");
            }
            strSql.Append(" GROUP BY T.C_MAT_CODE, T.C_MAT_NAME,  T.C_STL_GRD, T.C_SLAB_SIZE, TB.C_STD_CODE, T.N_LTH,  TD.C_ZYX1, TD.C_ZYX2 ");

            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 获取联产品改判信息
        /// </summary>
        /// <param name="C_MAT_CODE_PLAN">物料编码</param>
        /// <returns></returns>
        public DataSet Get_Gp_List(string C_MAT_CODE_PLAN)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT TA.C_MAT_CODE_GP AS 物料编码, TB.C_MAT_NAME AS 物料名称, TB.C_STL_GRD AS 钢种, TB.C_SPEC AS 规格,TA.C_ID  FROM TQB_GP_LCP_BASIS TA INNER JOIN TB_MATRL_MAIN TB ON TA.C_MAT_CODE_GP = TB.C_MAT_CODE WHERE TA.N_STATUS = 1 AND TA.C_MAT_CODE_PLAN = '" + C_MAT_CODE_PLAN + "'  ");

            strSql.Append("  ORDER BY TA.C_MAT_CODE_GP ");

            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update_Status(string c_mat_code_plan)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update tqb_gp_lcp_basis t set t.n_status=0 where t.c_mat_code_plan='" + c_mat_code_plan + "' ");

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
        public Mod_TQB_GP_LCP_BASIS Get_Model(string C_MAT_CODE_PLAN)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_MAT_CODE_PLAN,C_MAT_CODE_GP,N_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT,N_SORT,C_STL_GRD,C_STD_CODE from TQB_GP_LCP_BASIS ");
            strSql.Append(" where C_MAT_CODE_PLAN=:C_MAT_CODE_PLAN and C_MAT_CODE_GP is null and rownum=1 ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_MAT_CODE_PLAN",OracleDbType.Varchar2,100)          };
            parameters[0].Value = C_MAT_CODE_PLAN;

            Mod_TQB_GP_LCP_BASIS model = new Mod_TQB_GP_LCP_BASIS();
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
        /// 更新一条数据
        /// </summary>
        public bool Update_Status(string c_mat_code_plan, string C_MAT_CODE_GP)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update tqb_gp_lcp_basis t set t.n_status=0 where t.c_mat_code_plan='" + c_mat_code_plan + "' and C_MAT_CODE_GP='" + C_MAT_CODE_GP + "' ");

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
        /// 将没有添加到联产品的物料信息添加到联产品表
        /// </summary>
        /// <returns></returns>
        public string UPDATE_LCP_CODE()
        {
            OracleParameter[] parameters = {
            new OracleParameter("P_MSG", OracleDbType.Varchar2,100)};

            parameters[0].Value = "失败";

            return DbHelperOra.RunProcedureOut("PKG_TB_MATRL_MAIN.P_UPDATE_LCP_CODE", parameters);
        }


        #endregion  BasicMethod
    }
}

