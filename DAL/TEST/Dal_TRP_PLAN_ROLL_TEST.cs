using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;
namespace DAL
{
    /// <summary>
    /// 数据访问类:TRP_PLAN_ROLL_TEST
    /// </summary>
    public partial class Dal_TRP_PLAN_ROLL_TEST
    {
        public Dal_TRP_PLAN_ROLL_TEST()
        { }

        /// <summary>
        /// 按钢种和执行标准查询未下发计划的轧线
        /// </summary>
        public DataSet Get_Line_Lsit_Trans()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT T.C_LINE_CODE,T.C_STA_ID FROM TRP_PLAN_ROLL_TEST T WHERE t.c_line_code is not null and T.N_STATUS in (0,1) AND T.N_ISSUE_WGT < T.N_WGT GROUP BY T.C_LINE_CODE,T.C_STA_ID ORDER BY T.C_LINE_CODE ");

            return TransactionHelper.Query(strSql.ToString());
        }

        /// <summary>
        /// 排产初始化
        /// </summary>
        /// <returns></returns>
        public bool Update_Trans()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("UPDATE TRP_PLAN_ROLL_TEST T SET T.N_ROLL_PROD_WGT=round(NVL(t.N_GROUP_WGT,0)),T.D_P_START_TIME=NULL,T.D_P_END_TIME=NULL  where t.N_STATUS in(0,1) and t.N_TYPE=8 and t.c_line_code is not null ");

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
        public Mod_TRP_PLAN_ROLL_TEST DataRowToModel(DataRow row)
        {
            Mod_TRP_PLAN_ROLL_TEST model = new Mod_TRP_PLAN_ROLL_TEST();
            if (row != null)
            {
                if (row["C_ID"] != null)
                {
                    model.C_ID = row["C_ID"].ToString();
                }
                if (row["N_STATUS"] != null && row["N_STATUS"].ToString() != "")
                {
                    model.N_STATUS = decimal.Parse(row["N_STATUS"].ToString());
                }
                if (row["C_INITIALIZE_ITEM_ID"] != null)
                {
                    model.C_INITIALIZE_ITEM_ID = row["C_INITIALIZE_ITEM_ID"].ToString();
                }
                if (row["C_ORDER_NO"] != null)
                {
                    model.C_ORDER_NO = row["C_ORDER_NO"].ToString();
                }
                if (row["N_WGT"] != null && row["N_WGT"].ToString() != "")
                {
                    model.N_WGT = decimal.Parse(row["N_WGT"].ToString());
                }
                if (row["C_MAT_CODE"] != null)
                {
                    model.C_MAT_CODE = row["C_MAT_CODE"].ToString();
                }
                if (row["C_MAT_NAME"] != null)
                {
                    model.C_MAT_NAME = row["C_MAT_NAME"].ToString();
                }
                if (row["C_TECH_PROT"] != null)
                {
                    model.C_TECH_PROT = row["C_TECH_PROT"].ToString();
                }
                if (row["C_SPEC"] != null)
                {
                    model.C_SPEC = row["C_SPEC"].ToString();
                }
                if (row["C_STL_GRD"] != null)
                {
                    model.C_STL_GRD = row["C_STL_GRD"].ToString();
                }
                if (row["C_STD_CODE"] != null)
                {
                    model.C_STD_CODE = row["C_STD_CODE"].ToString();
                }
                if (row["N_USER_LEV"] != null && row["N_USER_LEV"].ToString() != "")
                {
                    model.N_USER_LEV = decimal.Parse(row["N_USER_LEV"].ToString());
                }
                if (row["N_STL_GRD_LEV"] != null && row["N_STL_GRD_LEV"].ToString() != "")
                {
                    model.N_STL_GRD_LEV = decimal.Parse(row["N_STL_GRD_LEV"].ToString());
                }
                if (row["N_ORDER_LEV"] != null && row["N_ORDER_LEV"].ToString() != "")
                {
                    model.N_ORDER_LEV = decimal.Parse(row["N_ORDER_LEV"].ToString());
                }
                if (row["C_QUALIRY_LEV"] != null)
                {
                    model.C_QUALIRY_LEV = row["C_QUALIRY_LEV"].ToString();
                }
                if (row["D_NEED_DT"] != null && row["D_NEED_DT"].ToString() != "")
                {
                    model.D_NEED_DT = DateTime.Parse(row["D_NEED_DT"].ToString());
                }
                if (row["D_DELIVERY_DT"] != null && row["D_DELIVERY_DT"].ToString() != "")
                {
                    model.D_DELIVERY_DT = DateTime.Parse(row["D_DELIVERY_DT"].ToString());
                }
                if (row["D_DT"] != null && row["D_DT"].ToString() != "")
                {
                    model.D_DT = DateTime.Parse(row["D_DT"].ToString());
                }
                if (row["C_LINE_DESC"] != null)
                {
                    model.C_LINE_DESC = row["C_LINE_DESC"].ToString();
                }
                if (row["C_LINE_CODE"] != null)
                {
                    model.C_LINE_CODE = row["C_LINE_CODE"].ToString();
                }
                if (row["D_P_START_TIME"] != null && row["D_P_START_TIME"].ToString() != "")
                {
                    model.D_P_START_TIME = DateTime.Parse(row["D_P_START_TIME"].ToString());
                }
                if (row["D_P_END_TIME"] != null && row["D_P_END_TIME"].ToString() != "")
                {
                    model.D_P_END_TIME = DateTime.Parse(row["D_P_END_TIME"].ToString());
                }
                if (row["N_PROD_TIME"] != null && row["N_PROD_TIME"].ToString() != "")
                {
                    model.N_PROD_TIME = decimal.Parse(row["N_PROD_TIME"].ToString());
                }
                if (row["N_SORT"] != null && row["N_SORT"].ToString() != "")
                {
                    model.N_SORT = decimal.Parse(row["N_SORT"].ToString());
                }
                if (row["N_ROLL_PROD_WGT"] != null && row["N_ROLL_PROD_WGT"].ToString() != "")
                {
                    model.N_ROLL_PROD_WGT = decimal.Parse(row["N_ROLL_PROD_WGT"].ToString());
                }
                if (row["C_ROLL_PROD_EMP_ID"] != null)
                {
                    model.C_ROLL_PROD_EMP_ID = row["C_ROLL_PROD_EMP_ID"].ToString();
                }
                if (row["C_STL_ROL_DT"] != null)
                {
                    model.C_STL_ROL_DT = row["C_STL_ROL_DT"].ToString();
                }
                if (row["N_PROD_WGT"] != null && row["N_PROD_WGT"].ToString() != "")
                {
                    model.N_PROD_WGT = decimal.Parse(row["N_PROD_WGT"].ToString());
                }
                if (row["N_WARE_WGT"] != null && row["N_WARE_WGT"].ToString() != "")
                {
                    model.N_WARE_WGT = decimal.Parse(row["N_WARE_WGT"].ToString());
                }
                if (row["N_WARE_OUT_WGT"] != null && row["N_WARE_OUT_WGT"].ToString() != "")
                {
                    model.N_WARE_OUT_WGT = decimal.Parse(row["N_WARE_OUT_WGT"].ToString());
                }
                if (row["N_FLAG"] != null && row["N_FLAG"].ToString() != "")
                {
                    model.N_FLAG = decimal.Parse(row["N_FLAG"].ToString());
                }
                if (row["N_ISSUE_WGT"] != null && row["N_ISSUE_WGT"].ToString() != "")
                {
                    model.N_ISSUE_WGT = decimal.Parse(row["N_ISSUE_WGT"].ToString());
                }
                if (row["C_CUST_NO"] != null)
                {
                    model.C_CUST_NO = row["C_CUST_NO"].ToString();
                }
                if (row["C_CUST_NAME"] != null)
                {
                    model.C_CUST_NAME = row["C_CUST_NAME"].ToString();
                }
                if (row["C_SALE_CHANNEL"] != null)
                {
                    model.C_SALE_CHANNEL = row["C_SALE_CHANNEL"].ToString();
                }
                if (row["C_PACK"] != null)
                {
                    model.C_PACK = row["C_PACK"].ToString();
                }
                if (row["C_DESIGN_NO"] != null)
                {
                    model.C_DESIGN_NO = row["C_DESIGN_NO"].ToString();
                }
                if (row["N_GROUP_WGT"] != null && row["N_GROUP_WGT"].ToString() != "")
                {
                    model.N_GROUP_WGT = decimal.Parse(row["N_GROUP_WGT"].ToString());
                }
                if (row["C_STA_ID"] != null)
                {
                    model.C_STA_ID = row["C_STA_ID"].ToString();
                }
                if (row["D_START_TIME"] != null && row["D_START_TIME"].ToString() != "")
                {
                    model.D_START_TIME = DateTime.Parse(row["D_START_TIME"].ToString());
                }
                if (row["D_END_TIME"] != null && row["D_END_TIME"].ToString() != "")
                {
                    model.D_END_TIME = DateTime.Parse(row["D_END_TIME"].ToString());
                }
                if (row["C_EMP_ID"] != null)
                {
                    model.C_EMP_ID = row["C_EMP_ID"].ToString();
                }
                if (row["D_MOD_DT"] != null && row["D_MOD_DT"].ToString() != "")
                {
                    model.D_MOD_DT = DateTime.Parse(row["D_MOD_DT"].ToString());
                }
                if (row["N_ROLL_WGT"] != null && row["N_ROLL_WGT"].ToString() != "")
                {
                    model.N_ROLL_WGT = decimal.Parse(row["N_ROLL_WGT"].ToString());
                }
                if (row["N_MACH_WGT"] != null && row["N_MACH_WGT"].ToString() != "")
                {
                    model.N_MACH_WGT = decimal.Parse(row["N_MACH_WGT"].ToString());
                }
                if (row["C_CAST_NO"] != null)
                {
                    model.C_CAST_NO = row["C_CAST_NO"].ToString();
                }
                if (row["C_INITIALIZE_ID"] != null)
                {
                    model.C_INITIALIZE_ID = row["C_INITIALIZE_ID"].ToString();
                }
                if (row["C_FREE_TERM"] != null)
                {
                    model.C_FREE_TERM = row["C_FREE_TERM"].ToString();
                }
                if (row["C_FREE_TERM2"] != null)
                {
                    model.C_FREE_TERM2 = row["C_FREE_TERM2"].ToString();
                }
                if (row["C_AREA"] != null)
                {
                    model.C_AREA = row["C_AREA"].ToString();
                }
                if (row["C_PCLX"] != null)
                {
                    model.C_PCLX = row["C_PCLX"].ToString();
                }
                if (row["C_SFHL"] != null)
                {
                    model.C_SFHL = row["C_SFHL"].ToString();
                }
                if (row["D_HL_START_TIME"] != null && row["D_HL_START_TIME"].ToString() != "")
                {
                    model.D_HL_START_TIME = DateTime.Parse(row["D_HL_START_TIME"].ToString());
                }
                if (row["D_HL_END_TIME"] != null && row["D_HL_END_TIME"].ToString() != "")
                {
                    model.D_HL_END_TIME = DateTime.Parse(row["D_HL_END_TIME"].ToString());
                }
                if (row["C_SFHL_D"] != null)
                {
                    model.C_SFHL_D = row["C_SFHL_D"].ToString();
                }
                if (row["D_DHL_START_TIME"] != null && row["D_DHL_START_TIME"].ToString() != "")
                {
                    model.D_DHL_START_TIME = DateTime.Parse(row["D_DHL_START_TIME"].ToString());
                }
                if (row["D_DHL_END_TIME"] != null && row["D_DHL_END_TIME"].ToString() != "")
                {
                    model.D_DHL_END_TIME = DateTime.Parse(row["D_DHL_END_TIME"].ToString());
                }
                if (row["C_SFKP"] != null)
                {
                    model.C_SFKP = row["C_SFKP"].ToString();
                }
                if (row["D_KP_START_TIME"] != null && row["D_KP_START_TIME"].ToString() != "")
                {
                    model.D_KP_START_TIME = DateTime.Parse(row["D_KP_START_TIME"].ToString());
                }
                if (row["D_KP_END_TIME"] != null && row["D_KP_END_TIME"].ToString() != "")
                {
                    model.D_KP_END_TIME = DateTime.Parse(row["D_KP_END_TIME"].ToString());
                }
                if (row["C_SFXM"] != null)
                {
                    model.C_SFXM = row["C_SFXM"].ToString();
                }
                if (row["D_XM_START_TIME"] != null && row["D_XM_START_TIME"].ToString() != "")
                {
                    model.D_XM_START_TIME = DateTime.Parse(row["D_XM_START_TIME"].ToString());
                }
                if (row["D_XM_END_TIME"] != null && row["D_XM_END_TIME"].ToString() != "")
                {
                    model.D_XM_END_TIME = DateTime.Parse(row["D_XM_END_TIME"].ToString());
                }
                if (row["N_UPLOADSTATUS"] != null && row["N_UPLOADSTATUS"].ToString() != "")
                {
                    model.N_UPLOADSTATUS = decimal.Parse(row["N_UPLOADSTATUS"].ToString());
                }
                if (row["C_MATRL_CODE_SLAB"] != null)
                {
                    model.C_MATRL_CODE_SLAB = row["C_MATRL_CODE_SLAB"].ToString();
                }
                if (row["C_MATRL_NAME_SLAB"] != null)
                {
                    model.C_MATRL_NAME_SLAB = row["C_MATRL_NAME_SLAB"].ToString();
                }
                if (row["C_SLAB_SIZE"] != null)
                {
                    model.C_SLAB_SIZE = row["C_SLAB_SIZE"].ToString();
                }
                if (row["N_SLAB_LENGTH"] != null && row["N_SLAB_LENGTH"].ToString() != "")
                {
                    model.N_SLAB_LENGTH = decimal.Parse(row["N_SLAB_LENGTH"].ToString());
                }
                if (row["N_SLAB_PW"] != null && row["N_SLAB_PW"].ToString() != "")
                {
                    model.N_SLAB_PW = decimal.Parse(row["N_SLAB_PW"].ToString());
                }
                if (row["D_CAN_ROLL_TIME"] != null && row["D_CAN_ROLL_TIME"].ToString() != "")
                {
                    model.D_CAN_ROLL_TIME = DateTime.Parse(row["D_CAN_ROLL_TIME"].ToString());
                }
                if (row["C_ROUTE"] != null)
                {
                    model.C_ROUTE = row["C_ROUTE"].ToString();
                }
                if (row["N_DIAMETER"] != null && row["N_DIAMETER"].ToString() != "")
                {
                    model.N_DIAMETER = decimal.Parse(row["N_DIAMETER"].ToString());
                }
                if (row["C_XM_YQ"] != null)
                {
                    model.C_XM_YQ = row["C_XM_YQ"].ToString();
                }
                if (row["N_JRL_WD"] != null && row["N_JRL_WD"].ToString() != "")
                {
                    model.N_JRL_WD = decimal.Parse(row["N_JRL_WD"].ToString());
                }
                if (row["N_JRL_SJ"] != null && row["N_JRL_SJ"].ToString() != "")
                {
                    model.N_JRL_SJ = decimal.Parse(row["N_JRL_SJ"].ToString());
                }
                if (row["C_STL_GRD_SLAB"] != null)
                {
                    model.C_STL_GRD_SLAB = row["C_STL_GRD_SLAB"].ToString();
                }
                if (row["C_STD_CODE_SLAB"] != null)
                {
                    model.C_STD_CODE_SLAB = row["C_STD_CODE_SLAB"].ToString();
                }
                if (row["C_REMARK1"] != null)
                {
                    model.C_REMARK1 = row["C_REMARK1"].ToString();
                }
                if (row["C_REMARK2"] != null)
                {
                    model.C_REMARK2 = row["C_REMARK2"].ToString();
                }
                if (row["C_REMARK3"] != null)
                {
                    model.C_REMARK3 = row["C_REMARK3"].ToString();
                }
                if (row["C_REMARK4"] != null)
                {
                    model.C_REMARK4 = row["C_REMARK4"].ToString();
                }
                if (row["C_REMARK5"] != null)
                {
                    model.C_REMARK5 = row["C_REMARK5"].ToString();
                }
                if (row["C_SPEC_PC"] != null)
                {
                    model.C_SPEC_PC = row["C_SPEC_PC"].ToString();
                }
            }
            return model;
        }

        /// <summary>
        /// 获取待轧的轧钢计划
        /// </summary>
        public DataSet Get_Plan_Roll_Trans()
        {
            StringBuilder strSql = new StringBuilder();
            //strSql.Append("select * from TRP_PLAN_ROLL_TEST WHERE N_TYPE=8 and N_STATUS in (0, 1) AND N_ROLL_PROD_WGT<N_WGT and n_mach_wgt<>0 and c_line_code is not null ");
            strSql.Append("select * from TRP_PLAN_ROLL_TEST WHERE N_TYPE=8 and N_STATUS in (0, 1) and n_mach_wgt<>0 and c_line_code is not null ");

            strSql.Append(" ORDER BY (N_WGT-N_ROLL_PROD_WGT)DESC,C_STL_GRD,C_STD_CODE DESC  ");

            return TransactionHelper.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取前两个计划
        /// </summary>
        public DataSet Get_Up_Plan_Trans(string c_line_code, int rowNum)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from( select * from TRP_PLAN_ROLL_TEST t where t.c_line_code='" + c_line_code + "' AND T.D_P_END_TIME IS NOT NULL order by t.d_p_End_Time desc) where rownum<=" + rowNum + " ");

            return TransactionHelper.Query(strSql.ToString());
        }

        /// <summary>
        /// 更新轧钢排产量
        /// </summary>
        public bool Update_ZG_Trans(string C_ID, decimal N_ZG_WGT, string timeStart, string timeEnd)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TRP_PLAN_ROLL_TEST set n_roll_prod_wgt=" + N_ZG_WGT + ",D_P_START_TIME=to_date('" + timeStart + "','yyyy-mm-dd hh24:mi:ss'),D_P_END_TIME=to_date('" + timeEnd + "','yyyy-mm-dd hh24:mi:ss') where C_ID='" + C_ID + "' ");

            int rows = TransactionHelper.ExecuteSql(strSql.ToString());
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
        /// 查询轧钢计划
        /// </summary>
        /// <param name="C_LINT_ID">产线</param>
        /// <param name="N_STATUS">是否排产</param>
        /// <param name="C_ORDER_NO">订单号</param>
        /// <param name="C_STL_GRD">钢种</param>
        /// <param name="C_STD_CODE">执行标准</param>
        /// <param name="D_SPEC_MIN">规格最小</param>
        /// <param name="D_SPEC_MAX">规格最大</param>
        /// <param name="C_CUST_NAME">客户名称</param>
        /// <param name="C_JQ_MIN">交货日期最小</param>
        /// <param name="C_JQ_MAX">交货日期最大</param>
        /// <param name="C_DD_MIN">订单日期最小</param>
        /// <param name="C_DD_MAX">订单日期最大</param>
        /// <returns>轧钢计划</returns>
        public DataSet GetZGPlan(string C_LINT_ID, int? N_STATUS, string C_ORDER_NO, string C_STL_GRD, string C_STD_CODE, double? D_SPEC_MIN, double? D_SPEC_MAX, string C_CUST_NAME, string C_JQ_MIN, string C_JQ_MAX, string C_DD_MIN, string C_DD_MAX)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * ");
            strSql.Append(" FROM TRP_PLAN_ROLL_TEST T WHERE N_TYPE=8 ");

            if (C_LINT_ID.Trim() != "")
            {
                strSql.Append(" AND  C_STA_ID='" + C_LINT_ID + "' ");
            }

            if (N_STATUS != null)
            {
                if (N_STATUS == 1)//已确认排产
                {
                    strSql.Append(" AND  N_STATUS=1 ");
                }
                if (N_STATUS == 0)//未确认完排产
                {
                    strSql.Append(" AND   N_STATUS=0 ");
                }
            }
            if (C_ORDER_NO.Trim() != "")
            {
                strSql.Append(" AND   C_ORDER_NO  LIKE '%" + C_ORDER_NO + "%'");
            }

            if (C_STL_GRD.Trim() != "")
            {
                strSql.Append(" AND   C_STL_GRD LIKE '%" + C_STL_GRD + "%'");
            }

            if (C_STD_CODE.Trim() != "")
            {
                strSql.Append(" AND   C_STD_CODE LIKE '%" + C_STD_CODE + "%'");
            }

            if (D_SPEC_MIN != null)
            {
                strSql.Append("   AND ((T.C_SPEC LIKE '%φ%' AND TO_NUMBER(REPLACE(T.C_SPEC, 'φ', '')) >= " + D_SPEC_MIN + ") OR  (T.C_SPEC LIKE '%*%' AND TO_NUMBER(GET_STRARRAYSTROFINDEX(T.C_SPEC, '*', 0)) >= " + D_SPEC_MIN + "))");
            }

            if (D_SPEC_MAX != null)
            {
                strSql.Append("   AND ((T.C_SPEC LIKE '%φ%' AND TO_NUMBER(REPLACE(T.C_SPEC, 'φ', '')) <= " + D_SPEC_MAX + ") OR  (T.C_SPEC LIKE '%*%' AND TO_NUMBER(GET_STRARRAYSTROFINDEX(T.C_SPEC, '*', 0)) <= " + D_SPEC_MAX + "))");
            }

            if (C_CUST_NAME.Trim() != "")
            {
                strSql.Append(" AND   C_CUST_NAME LIKE  '%" + C_CUST_NAME + "%'");
            }

            if (C_JQ_MIN.Trim() != "")
            {
                strSql.Append(" AND  D_DELIVERY_DT >=TO_DATE('" + C_JQ_MIN + "','yyyy-mm-dd hh24:mi:ss')");
            }
            if (C_JQ_MAX.Trim() != "")
            {
                strSql.Append("  AND  D_DELIVERY_DT <=TO_DATE('" + C_JQ_MAX + "','yyyy-mm-dd hh24:mi:ss')");
            }

            if (C_DD_MIN.Trim() != "")
            {
                strSql.Append(" AND  D_DT >=TO_DATE('" + C_DD_MIN + "','yyyy-mm-dd hh24:mi:ss')");
            }
            if (C_DD_MAX.Trim() != "")
            {
                strSql.Append("  AND  D_DT <=TO_DATE('" + C_DD_MAX + "','yyyy-mm-dd hh24:mi:ss')");
            }

            strSql.Append(" ORDER BY substr(C_LINE_CODE,1,1),D_P_START_TIME");
            return DbHelperOra.Query(strSql.ToString());
        }


        /// <summary>
        /// 更新排产计划到正式表
        /// </summary>
        /// <returns></returns>
        public string Update_Plan()
        {
            OracleParameter[] parameters = {
            new OracleParameter("P_MSG", OracleDbType.Varchar2,100)};

            parameters[0].Value = "失败";

            return DbHelperOra.RunProcedureOut("pkg_p_plan.P_UPDATE_PLAN", parameters);
        }

        /// <summary>
        /// 保存排产历史结果记录
        /// </summary>
        /// <returns></returns>
        public string Save_Plan_Log()
        {
            OracleParameter[] parameters = {
            new OracleParameter("P_MSG", OracleDbType.Varchar2,100)};

            parameters[0].Value = "失败";

            return DbHelperOra.RunProcedureOut("pkg_p_plan.P_PLAN_LOG", parameters);
        }

    }
}

