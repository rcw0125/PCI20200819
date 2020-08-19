using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;
using System.Collections.Generic;

namespace DAL.P
{
    public partial class Dal_KP_PLAN
    {
        public Dal_KP_PLAN()
        { }
        /// <summary>
        /// 开坯计划排序
        /// </summary>
        public void P_SORT_KP_PLAN()
        {
            //获取当前的额开坯计划
            string sqlkp = @"SELECT T.C_KP_ID
  FROM TSP_PLAN_SMS T
 WHERE T.C_KP_ID IS NOT NULL
   AND T.C_KP = 'Y'
   AND T.N_KP_WGT > 0
 GROUP BY T.C_KP_ID";
            DataTable dtkp = DbHelperOra.Query(sqlkp).Tables[0];
            if (dtkp.Rows.Count>0)
            {
                for (int i = 0; i < dtkp.Rows.Count; i++)
                {
                    string c_kp_id = dtkp.Rows[i]["C_KP_ID"].ToString();

                }
            }

        }
    }
}
