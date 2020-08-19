using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace DAL
{
    /// <summary>
    /// 质量设计相关操作
    /// </summary>
    public class Dal_TQD_DESIGN
    {
        public Dal_TQD_DESIGN()
        { }

        /// <summary>
        /// 查询线材质量设计结果
        /// </summary>
        /// <param name="strBatch">批号</param>
        /// <param name="strOrderID">订单号</param>
        /// <returns></returns>
		public DataSet GetDesignRoll(string strBatch, string strOrderID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ta.c_design_no as 质量设计号, ta.c_std_code as 执行标准, tb.c_batch_no as 批号, ta.C_ORDER_NO as 订单号, ta.C_STL_GRD as 钢种, ta.C_SPEC as 规格, ta.C_MAT_CODE as 物料编码, ta.C_MAT_NAME as 物料名称  from TRP_PLAN_ROLL ta inner  join tpp_initialize_item tc on tc.c_item_name = ta.c_initialize_item_id LEFT JOIN trc_roll_main tb on ta.c_id = tb.C_PLAN_ID where 1 = 1   and tc.n_status = 1 ");

            if (strBatch.Trim() != "")
            {
                strSql.Append(" and tb.c_batch_no = '" + strBatch + "' ");
            }

            if (strOrderID.Trim() != "")
            {
                strSql.Append(" and ta.C_ORDER_NO = '" + strOrderID + "' ");
            }

            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 查询钢坯质量设计结果
        /// </summary>
        /// <param name="strStove">炉号</param>
        /// <param name="strOrderID">订单号</param>
        /// <returns></returns>
		public DataSet GetDesignSlab(string strStove, string strOrderID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ta.c_design_no  as 质量设计号, ta.c_std_code as 执行标准, tb.c_stove as 炉号, ta.c_order_no as 订单号, ta.C_STL_GRD as 钢种, ta.c_slab_size as 断面, ta.C_MATRL_NO as 物料编码, ta.C_MATRL_NAME as 物料名称  from tsp_plan_sms ta inner  join tpp_initialize_item tc on tc.c_item_name = ta.c_initialize_item_id LEFT JOIN tsc_slab_main tb on ta.c_plan_sms_id = tb.c_plan_id where TA.N_STATUS = 1 AND  tc.n_status = 1 ");

            if (strStove.Trim() != "")
            {
                strSql.Append(" and tb.c_stove = '" + strStove + "' ");

            }

            if (strOrderID.Trim() != "")
            {
                strSql.Append(" and ta.c_order_no = '" + strOrderID + "' ");
            }

            strSql.Append(" group by ta.c_design_no, ta.c_std_code, tb.c_stove, ta.c_order_no, ta.C_STL_GRD, ta.c_slab_size, ta.C_MATRL_NO, ta.C_MATRL_NAME  ");

            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 查询质量设计结果明细
        /// </summary>
        /// <param name="strDesignNo">质量设计号</param>
        /// <param name="strStdCode">执行标准</param>
        /// <param name="strGrd">钢种</param>
        /// <param name="strType">类型,0-钢坯；1-线材</param>
        /// <returns></returns>
		public DataSet GetDesignItemRoll(string strDesignNo, string strStdCode, string strGrd, string strType)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select tb.c_design_no as 质量设计号,tc.c_std_code as 执行标准,te.c_type_name as 项目类型,td.c_code as 项目代码,td.c_name as 项目名称,ta.c_target_min as 最小值,ta.c_target_interval as 区间,ta.c_target_max as 最大值 from TQB_DESIGN_ITEM ta inner join tqb_design tb on ta.c_design_id=tb.c_id inner join tqb_std_main tc on tc.c_id=tb.c_std_main_id inner join tqb_character td on ta.c_character_id=td.c_id inner join tqb_checktype te on td.c_type_id=te.c_id where 1=1");

            if (strDesignNo.Trim() != "")
            {
                strSql.Append(" and tb.c_design_no = '" + strDesignNo + "' ");
            }

            if (strStdCode.Trim() != "")
            {
                strSql.Append(" and tc.c_std_code = '" + strStdCode + "' ");

            }

            if (strStdCode.Trim() != "")
            {
                strSql.Append(" and tc.C_STL_GRD = '" + strGrd + "' ");

            }

            if (strType == "0")
            {
                strSql.Append(" and te.c_type_name='成分' ");
            }

            strSql.Append(" order by td.c_code ");

            return DbHelperOra.Query(strSql.ToString());
        }


        /// <summary>
        /// 获取质量设计号
        /// </summary>
        /// <param name="C_STD_CODE">执行标准</param>
        /// <param name="C_STL_GRD">钢种</param>
        /// <returns></returns>
        public string Get_Design_No(string C_STD_CODE, string C_STL_GRD)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT TB.C_DESIGN_NO FROM TQB_STD_MAIN TA INNER JOIN TQB_DESIGN TB ON TA.C_ID=TB.C_STD_MAIN_ID WHERE TA.N_IS_CHECK=1 AND TA.N_STATUS=1 and TA.C_STD_CODE='" + C_STD_CODE + "' AND TA.C_STL_GRD='" + C_STL_GRD + "' ");

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
    }
}
