using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;
namespace DAL
{
    public partial class Dal_APS_LGPC
    {
        public Dal_APS_LGPC()
        { }


        #region 浇次计划排序

        #region 5#连铸浇次计划排序

        /// <summary>
        /// 返回上期排产的RH炉连续生产数量
        /// </summary>
        /// <returns>连续生产数量</returns>
        public int GetYPRH()
        {
            OracleParameter[] parameters = {
            new OracleParameter("P_MSG", OracleDbType.Varchar2,100)};
            parameters[0].Value = "0";
            return Convert.ToInt32(DbHelperOra.RunProcedureOut("PKG_LG_JCJH.P_RETURN_RHLS", parameters));
        }
        public void SortRHPlan()
        {
            //5#连铸已经排产的日历
            //已经排产的浇次计划
            string sqlRHLS = "SELECT SUM(T.N_RH)  N_TOTAL_RH  FROM TPP_LGPC_LSB T";
            int rhls = Convert.ToInt32(DbHelperOra.Query(sqlRHLS.ToString()).Tables[0].Rows[0]["N_TOTAL_RH"]);//本次生成浇次的RH总路数
            int totalrhnum = rhls + GetYPRH();


            string sqlJCJH = @"SELECT T.C_ID, T.C_CCM_ID, T.C_CCM_CODE, T.N_GROUP, T.N_TOTAL_WGT, T.N_ZJCLS, T.N_ZJCLZL, T.N_MLZL, T.N_SORT, T.C_STL_GRD, T.N_PRODUCE_TIME, T.N_JSCN, T.C_BY1, T.C_BY2, T.C_BY3, T.C_RH, T.C_DFP_HL, T.C_HL, T.C_XM, T.N_ORDER_LS, T.D_DFPHL_START_TIME, T.D_DFPHL_END_TIME, T.D_KP_START_TIME, T.D_KP_END_TIME, T.D_HL_START_TIME, T.D_HL_END_TIME, T.D_PLAN_KY_TIME, T.C_PLAN_ROLL, T.D_ZZ_START_TIME, T.D_ZZ_END_TIME, T.D_XM_START_TIME, T.D_XM_END_TIME, T.C_STD_CODE, T.C_SLAB_TYPE, T.C_STL_GRD_TYPE, T.C_PROD_NAME, T.C_PROD_KIND, T.N_DFP_HL_TIME, T.N_HL_TIME, T.N_XM_TIME, T.N_GG, T.N_CCM_TIME, T.C_TJ_REMARK, T.C_TL, T.N_RH, T.N_TL, T.N_GZSL, T.C_REMARK, T.N_XM, T.N_DHL, T.N_HL FROM TPP_LGPC_LSB T WHERE T.C_CCM_CODE='5#CC'  ";

            //炉次计划表（更新炉次计划表信息)已排产 未完成的炉次计划

            string sqlPlanSms = "SELECT T.C_ID, T.C_ORDER_NO, T.C_DESIGN_NO, T.N_SLAB_WGT, T.C_CTRL_NO, T.C_CCM_ID, T.C_CCM_DESC, T.C_PROD_NAME, T.C_STL_GRD, T.C_SPEC_CODE, T.C_LENGTH, T.C_MATRL_NO, T.C_MATRL_NAME, T.C_SLAB_SIZE, T.C_SLAB_LENGTH, T.C_STATE, T.C_STD_CODE, T.C_INITIALIZE_ITEM_ID, T.D_P_START_TIME, T.D_P_END_TIME, T.N_PROD_TIME, T.N_SORT, T.C_CAST_NO, T.N_STATUS, T.C_EMP_ID, T.D_MOD_DT, T.C_REMARK, T.N_CREAT_PLAN, T.N_CREAT_ZG_PLAN, T.N_PRODUCE_TIME, T.C_ZL_ID, T.C_LF_ID, T.C_RH_ID, T.C_LGJH, T.C_QUA, T.D_ARRIVE_ZG_TIME, T.C_BY1, T.C_BY2, T.C_BY3, T.C_RH, T.C_DFP_HL, T.C_HL, T.C_XM, T.D_DFPHL_START_TIME, T.D_DFPHL_END_TIME, T.D_KP_START_TIME, T.D_KP_END_TIME, T.D_HL_START_TIME, T.D_HL_END_TIME, T.D_PLAN_KY_TIME, T.C_PLAN_ROLL, T.D_ZZ_START_TIME, T.D_ZZ_END_TIME, T.D_XM_START_TIME, T.D_XM_END_TIME, T.C_STOVE_NO, T.D_DFPHL_START_TIME_SJ, T.D_DFPHL_END_TIME_SJ, T.D_KP_START_TIME_SJ, T.D_KP_END_TIME_SJ, T.D_HL_START_TIME_SJ, T.D_HL_END_TIME_SJ, T.D_XM_START_TIME_SJ, T.D_XM_END_TIME_SJ, T.N_SJ_WGT, T.D_START_TIME_SJ, T.D_END_TIME_SJ, T.N_DFP_HL_TIME, T.N_HL_TIME, T.C_ROUTE, T.N_SLAB_PW, T.C_MATRL_CODE_KP, T.C_MATRL_NAME_KP, T.C_KP_SIZE, T.N_KP_LENGTH, T.N_KP_PW, T.N_USE_WGT, T.D_USE_START_TIME_SJ, T.D_USE_END_TIME_SJ, T.D_CAN_USE_TIME, T.N_RH_NUM, T.N_KP_WGT, T.N_XM_WGT, T.C_DFP_RZ, T.C_RZP_RZ, T.C_DFP_YQ, T.C_RZP_YQ, T.C_STL_GRD_TYPE, T.C_PROD_KIND, T.C_TL, T.N_JSCN, T.C_FREE1, T.C_FREE2 FROM TSP_PLAN_SMS T WHERE   N_STATUS = 1 AND N_CREAT_PLAN < 3 AND T.C_CCM_DESC = '5#连铸' ORDER BY T.N_SORT ";




            //大方坯缓冷计划表(获取当前计划排产时的大方坯缓冷坑情况)将未完成的缓冷计划添加到缓冷计划临时表



            //开坯计划表（获取当前计划排产时开坯计划情况）将未完成的开坯计划添加到开坯临时计划表
            //热轧钢坯计划表（获取当前计划排产时开坯后的热轧钢坯缓冷坑情况）
            //修磨计划表（获取当前计划可缓冷的修磨计划情况）

        }

        #endregion

        #endregion


        #region 钢种生产条件分组

        public void AutoGroup(string c_id, int n_group)
        {

            update(c_id, n_group);
            string sql2 = @"SELECT T.C_BORDER_STL_GRD, T.C_BORDER_STD_CODE, TB.C_ID
  FROM TPB_BORDER_GRD T
  LEFT JOIN TPB_STEEL_PRO_CONDITION TB
    ON T.C_BORDER_STL_GRD = TB.C_STL_GRD
   AND T.C_BORDER_STD_CODE = TB.C_STD_CODE WHERE t.c_pro_condition_id='" + c_id + "' and tb.n_group IS  NULL    AND TB.N_STATUS = 1";
            DataTable dt2 = DbHelperOra.Query(sql2).Tables[0];
            if (dt2.Rows.Count > 0)
            {
                for (int i = 0; i < dt2.Rows.Count; i++)
                {
                    string c_id1 = dt2.Rows[i]["C_ID"].ToString();
                    //update(c_id1, n_group);
                    AutoGroup( c_id1,  n_group);

                }
            }

        }



        /// <summary>
        /// 根据钢种生产条件主表更新相邻钢种表对应的钢种生产条件组号
        /// </summary>
        /// <param name="c_id"></param>
        /// <param name="n_group"></param>
        public int update(string c_id, int n_group)
        {
            string sql = "UPDATE TPB_STEEL_PRO_CONDITION T SET T.N_GROUP = " + n_group + " WHERE T.C_ID = '" + c_id + "' ";
            return DbHelperOra.ExecuteSql(sql);


        }

        public int GetGroupNullNum()
        {
            string sql = "SELECT COUNT(1) COU FROM TPB_STEEL_PRO_CONDITION T WHERE T.N_GROUP IS NULL";

            object obj = DbHelperOra.GetSingle(sql.ToString());
            if (obj == null)
            {
                return 0;
            }
            else
            {
                return Convert.ToInt32(obj);
            }

        }


        public void updateALL()
        {
            //清空钢种生产条件组号
            string sql_update = "UPDATE TPB_STEEL_PRO_CONDITION T SET T.N_GROUP = NULL";
            int update = DbHelperOra.ExecuteSql(sql_update);

            while (GetGroupNullNum() > 0)
            {
                int n_group = 1;//当前分组号
                string sqln_group = "SELECT (MAX(N_GROUP) + 1) N_GROUP  FROM TPB_STEEL_PRO_CONDITION T WHERE T.N_GROUP IS NOT NULL";

                object obj = DbHelperOra.GetSingle(sqln_group.ToString());
                if (obj == null)
                {
                    n_group = 1;
                }
                else
                {
                    n_group = Convert.ToInt32(obj);
                }
                string c_id = "";
                string sql = "SELECT MAX(C_ID) C_ID FROM TPB_STEEL_PRO_CONDITION T WHERE T.N_GROUP IS NULL";

                c_id = DbHelperOra.Query(sql).Tables[0].Rows[0]["C_ID"].ToString();
                AutoGroup(c_id, n_group);

            }

            //更新所有相关计划组号




        }


        #endregion

    }
}
