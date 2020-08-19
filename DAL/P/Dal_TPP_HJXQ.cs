using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;
namespace DAL
{
    public partial class Dal_TPP_HJXQ
    {
        public Dal_TPP_HJXQ()
        { }
        /// <summary>
        /// 根据合金名称获取数据
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public DataSet GetList(string name,DateTime dt1,DateTime dt2)
        {
            OracleParameter[] parameters = {
            new OracleParameter("P_MSG", OracleDbType.Varchar2,500)};
            parameters[0].Value = "0";

            String msg = DbHelperOra.RunProcedureOut("PKG_TB_ALLOY_STOCK.P_TB_ALLOY_STOCK", parameters);

            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT mt.c_mat_name,c_alloy_code,round(nvl(n_alloy_wgt,0),1) n_alloy_wgt,round(nvl(N_NEED_WGT,0),1) N_NEED_WGT FROM (SELECT nvl(tb.c_alloy_code, tb.C_ALLOYN__CODE) c_alloy_code, tb.n_alloy_wgt, tb.N_NEED_WGT FROM (SELECT aa.c_alloy__name, aa.c_alloy_code, bb.C_ALLOYN__CODE,aa.n_alloy_wgt, bb.N_NEED_WGT FROM TB_ALLOY_STOCK aa FULL JOIN (SELECT A.C_ALLOYN__CODE, SUM(B.N_SLAB_WGT * A.N_ALLOY_WGT) / 1000 N_NEED_WGT FROM TQB_ALLOY_CONSUMPTION A INNER JOIN(SELECT SUM(T.N_SLAB_WGT) N_SLAB_WGT, T.C_STL_GRD, T.C_STD_CODE FROM TSP_PLAN_SMS T WHERE T.N_STATUS = 1AND T.N_CREAT_PLAN < 4 AND t.d_p_Start_Time > to_date('" + dt1 + "', 'yyyy-mm-dd HH24-mi-ss') AND t.d_p_End_Time < to_date('" + dt2 + "', 'yyyy-mm-dd HH24-mi-ss')  GROUP BY T.C_STL_GRD, T.C_STD_CODE) B ON A.C_STL_GRD = B.C_STL_GRD AND(A.C_STD_CODE = B.C_STD_CODE OR A.C_STD_CODE = GET_STRARRAYSTROFINDEX(B.C_STD_CODE, '.', 0) OR A.C_STD_CODE = GET_STRARRAYSTROFINDEX(B.C_STD_CODE, '-', 0)) GROUP BY A.C_ALLOYN__CODE)bb ON aa.c_alloy_code = bb.C_ALLOYN__CODE) tb) tt LEFT JOIN tb_matrl_main mt ON tt.c_alloy_code = mt.c_mat_code");
            if (name.Trim() != "")
            {
                strSql.Append(" where  mt.c_mat_name LIKE '%" + name + "%'");
            }
       
            return DbHelperOra.Query(strSql.ToString());
        }


        /// <summary>
        /// 估计合金名称获取需求合金订单
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public DataSet GetXQList(string code, DateTime dt1, DateTime dt2)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" SELECT bb.c_alloyn__name,ROUND(bb.n_alloy_wgt*aa.N_SLAB_WGT/1000,1)N_NEED_WGT,ROUND(aa.N_SLAB_WGT,1) N_SLAB_WGT,aa.C_STL_GRD,aa.C_STD_CODE,aa.D_P_START_TIME,aa.D_P_END_TIME  FROM  (SELECT SUM(T.N_SLAB_WGT) N_SLAB_WGT, T.C_STL_GRD, T.C_STD_CODE, MIN(D_P_START_TIME) D_P_START_TIME, MAX(D_P_END_TIME)D_P_END_TIME FROM TSP_PLAN_SMS T WHERE T.N_STATUS = 1 AND T.N_CREAT_PLAN < 4 AND t.d_p_Start_Time > to_date('" + dt1 + "', 'yyyy-mm-dd HH24-mi-ss') AND t.d_p_End_Time < to_date('" + dt2 + "', 'yyyy-mm-dd HH24-mi-ss') GROUP BY T.C_STL_GRD, T.C_STD_CODE ) aa INNER JOIN TQB_ALLOY_CONSUMPTION bb ON aa.C_STL_GRD = bb.C_STL_GRD AND(aa.C_STD_CODE = bb.C_STD_CODE OR bb.C_STD_CODE = GET_STRARRAYSTROFINDEX(aa.C_STD_CODE, '.', 0) OR  bb.C_STD_CODE = GET_STRARRAYSTROFINDEX(aa.C_STD_CODE, '-', 0)) where 1=1");
            if (code.Trim() != "")
            {
                strSql.Append(" and  bb.C_ALLOYN__CODE = '" + code + "'");
            }
           
            return DbHelperOra.Query(strSql.ToString());
        }
    }
}