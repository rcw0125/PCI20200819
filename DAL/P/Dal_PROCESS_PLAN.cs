using MODEL;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DAL
{
    public class Dal_PROCESS_PLAN
    {
        /// <summary>
        /// 获取当前开坯计划最后一次开坯时间
        /// </summary>
        /// <returns></returns>
        public object GetKpLastTime()
        {
            string sql = @"SELECT MAX(T.D_END_TIME) FROM TPA_KP_PLAN T
                                    ORDER BY T.D_END_TIME";
            return DbHelperOra.GetSingle(sql);
        }

        /// <summary>
        /// 获取缓冷计划前一次计划最后入坑记录
        /// </summary>
        /// <returns></returns>
        public DataTable GetDfpHlLastRecound()
        {
            string sql = @"SELECT * FROM (
                                    SELECT * FROM TPA_DHL_PLAN TDP
                                    ORDER BY   TDP.C_WH_CODE DESC ,TDP.N_TOTAL_QUA
                                    )
                                    where rownum=1";
            return DbHelperOra.Query(sql).Tables[0];
        }

        /// <summary>
        /// 获取缓冷坑库位
        /// </summary>
        /// <returns></returns>
        public DataTable GetDfpHlStrLoc()
        {
            string sql = @"SELECT * FROM  TPA_HL_ACT THA
                                    ORDER BY C_WH_CODE";
            return DbHelperOra.Query(sql).Tables[0];
        }

        /// <summary>
        /// 修改大方坯缓冷计划时间
        /// </summary>
        public bool UpdateDfpHLTiem(string id, DateTime? start, DateTime? end)
        {
            string sql = @"UPDATE TSP_PLAN_SMS TPS
                                    TPS.D_DFPHL_START_TIME=:D_DFPHL_START_TIME
                                    TPS.D_DFPHL_END_TIME=:D_DFPHL_END_TIME
                                    WHERE TPS.C_ID=:C_ID";
            OracleParameter[] parameters = {
                    new OracleParameter(":D_DFPHL_START_TIME", OracleDbType.Date),
                    new OracleParameter(":D_DFPHL_END_TIME", OracleDbType.Date),
                     new OracleParameter(":C_ID", OracleDbType.Varchar2,100)
            };
            parameters[0].Value = start;
            parameters[1].Value = end;
            parameters[2].Value = id;
            int rows = 1;// TransactionHelper.ExecuteSql(sql);
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
        /// 获取正在使用坑位
        /// </summary>
        /// <returns></returns>
        public DataTable GetUsedLoc()
        {
            string sql = @"SELECT TDP.C_WH_CODE 
                                                ,MAX(TDP.N_NUM) N_NUM
                                    FROM TPA_DHL_PLAN TDP
                                    WHERE TDP.C_WH_CODE!='0'
                                    GROUP BY TDP.C_WH_CODE
                                    ";
            return DbHelperOra.Query(sql).Tables[0];
        }

        /// <summary>
        /// 获取正在使用坑位
        /// </summary>
        /// <returns></returns>
        public DataTable GetUsedXLoc()
        {
            string sql = @"SELECT TDP.C_WH_CODE 
                                                ,MAX(TDP.N_NUM) N_NUM
                                    FROM TPA_HL_PLAN TDP
                                    WHERE TDP.C_WH_CODE!='0'
                                    GROUP BY TDP.C_WH_CODE
                                    ";
            return DbHelperOra.Query(sql).Tables[0];
        }

        /// <summary>
        /// 获取缓冷坑出坑明细
        /// </summary>
        /// <returns></returns>
        public DataTable GetOutLoc(DataTable usedD, DateTime? putTime)
        {
            string sql = @"SELECT  * FROM (
                                    SELECT 
                                    TDP.C_WH_CODE
                                    ,MAX(TDP.N_NUM)N_NUM
                                    ,MAX(TDP.N_TOTAL_QUA)N_TOTAL_QUA
                                    ,MAX(TDP.N_CAP)N_CAP
                                    ,MAX(TDP.D_OVER_TIME)D_OVER_TIME
                                    FROM  TPA_DHL_PLAN TDP ";
            if (usedD != null && usedD.Rows.Count > 0)
            {
                sql += " WHERE  (";
                for (int i = 0; i < usedD.Rows.Count; i++)
                {
                    if (i == 0)
                        sql += "   (TDP.N_NUM=" + usedD.Rows[i]["N_NUM"] + " AND TDP.C_WH_CODE='" + usedD.Rows[i]["C_WH_CODE"] + "') ";
                    else
                        sql += " OR  (TDP.N_NUM=" + usedD.Rows[i]["N_NUM"] + " AND TDP.C_WH_CODE='" + usedD.Rows[i]["C_WH_CODE"] + "') ";
                }
                sql += "  ) ";
            }
            sql += @" GROUP BY TDP.C_WH_CODE,TDP.N_NUM
                             ORDER BY TDP.C_WH_CODE, TDP.N_NUM
                              )T      ";
            if (putTime != null)
                sql += " WHERE To_date('" + putTime + "', 'yyyy-mm-dd hh24-mi-ss')> T.D_OVER_TIME ";
            return DbHelperOra.Query(sql).Tables[0];
        }

        /// <summary>
        /// 获取缓冷坑出坑明细(小方坯)
        /// </summary>
        /// <returns></returns>
        public DataTable GetOutXLoc(DataTable usedD, DateTime? putTime)
        {
            string sql = @"SELECT  * FROM (
                                    SELECT 
                                    TDP.C_WH_CODE
                                    ,MAX(TDP.N_NUM)N_NUM
                                    ,MAX(TDP.N_TOTAL_QUA)N_TOTAL_QUA
                                    ,MAX(TDP.N_CAP)N_CAP
                                    ,MAX(TDP.D_OVER_TIME)D_OVER_TIME
                                    FROM  TPA_HL_PLAN TDP ";
            if (usedD != null && usedD.Rows.Count > 0)
            {
                sql += " WHERE  (";
                for (int i = 0; i < usedD.Rows.Count; i++)
                {
                    if (i == 0)
                        sql += "   (TDP.N_NUM=" + usedD.Rows[i]["N_NUM"] + " AND TDP.C_WH_CODE='" + usedD.Rows[i]["C_WH_CODE"] + "') ";
                    else
                        sql += " OR  (TDP.N_NUM=" + usedD.Rows[i]["N_NUM"] + " AND TDP.C_WH_CODE='" + usedD.Rows[i]["C_WH_CODE"] + "') ";
                }
                sql += "  ) ";
            }
            sql += @" GROUP BY TDP.C_WH_CODE,TDP.N_NUM
                             ORDER BY TDP.C_WH_CODE, TDP.N_NUM
                              )T      ";
            if (putTime != null)
                sql += " WHERE To_date('" + putTime + "', 'yyyy-mm-dd hh24-mi-ss')> T.D_OVER_TIME ";
            return DbHelperOra.Query(sql).Tables[0];
        }

        /// <summary>
        /// 可以使用坑位
        /// </summary>
        /// <param name="usedD"></param>
        /// <param name="qua">入坑支数</param>
        /// <param name="outTime">出坑时间</param>
        /// <returns></returns>
        public DataTable GetUseLoc(DataTable usedD, int qua, DateTime? outTime)
        {
            string sql = @"SELECT * FROM (
                                    SELECT 
                                    TDP.C_WH_CODE
                                    ,MAX(TDP.N_NUM)N_NUM
                                    ,MAX(TDP.N_TOTAL_QUA)N_TOTAL_QUA
                                    ,MAX(TDP.N_CAP)N_CAP
                                    ,MAX(TDP.D_OVER_TIME)D_OVER_TIME
                                    FROM  TPA_DHL_PLAN TDP 
                                    GROUP BY TDP.C_WH_CODE,TDP.N_NUM
                                    ORDER BY TDP.C_WH_CODE, TDP.N_NUM
                                  ) T  WHERE 1=1 ";
            if (usedD != null && usedD.Rows.Count > 0)
            {
                sql += "AND  (";
                for (int i = 0; i < usedD.Rows.Count; i++)
                {
                    if (i == 0)
                        sql += "   (T .N_NUM=" + usedD.Rows[i]["N_NUM"] + " AND T .C_WH_CODE='" + usedD.Rows[i]["C_WH_CODE"] + "') ";
                    else
                        sql += " OR  (T .N_NUM=" + usedD.Rows[i]["N_NUM"] + " AND T .C_WH_CODE='" + usedD.Rows[i]["C_WH_CODE"] + "') ";
                }
                sql += "  )  ";
            }

            if (qua > 0)
                sql += " AND  T.N_TOTAL_QUA+" + qua + "<=T.N_CAP  ";

            if (outTime != null)
                sql += "   AND (ceil((To_date('" + outTime + "', 'yyyy-mm-dd hh24-mi-ss') - T.D_OVER_TIME) * 24) <=5 AND ceil((To_date('" + outTime + "', 'yyyy-mm-dd hh24-mi-ss') -  T.D_OVER_TIME) * 24) >= -5)   ";


            return DbHelperOra.Query(sql).Tables[0];
        }

        /// <summary>
        /// 可以使用坑位（小方坯）
        /// </summary>
        /// <param name="usedD"></param>
        /// <param name="qua">入坑支数</param>
        /// <param name="outTime">出坑时间</param>
        /// <returns></returns>
        public DataTable GetUseXLoc(DataTable usedD, int qua, DateTime? outTime)
        {
            string sql = @"SELECT * FROM (
                                    SELECT 
                                    TDP.C_WH_CODE
                                    ,MAX(TDP.N_NUM)N_NUM
                                    ,MAX(TDP.N_TOTAL_QUA)N_TOTAL_QUA
                                    ,MAX(TDP.N_CAP)N_CAP
                                    ,MAX(TDP.D_OVER_TIME)D_OVER_TIME
                                    FROM  TPA_HL_PLAN TDP 
                                    GROUP BY TDP.C_WH_CODE,TDP.N_NUM
                                    ORDER BY TDP.C_WH_CODE, TDP.N_NUM
                                  ) T  WHERE 1=1 ";
            if (usedD != null && usedD.Rows.Count > 0)
            {
                sql += "AND  (";
                for (int i = 0; i < usedD.Rows.Count; i++)
                {
                    if (i == 0)
                        sql += "   (T .N_NUM=" + usedD.Rows[i]["N_NUM"] + " AND T .C_WH_CODE='" + usedD.Rows[i]["C_WH_CODE"] + "') ";
                    else
                        sql += " OR  (T .N_NUM=" + usedD.Rows[i]["N_NUM"] + " AND T .C_WH_CODE='" + usedD.Rows[i]["C_WH_CODE"] + "') ";
                }
                sql += "  )  ";
            }

            if (qua > 0)
                sql += " AND  T.N_TOTAL_QUA+" + qua + "<=T.N_CAP  ";

            if (outTime != null)
                sql += "   AND (ceil((To_date('" + outTime + "', 'yyyy-mm-dd hh24-mi-ss') - T.D_OVER_TIME) * 24) <=5 AND ceil((To_date('" + outTime + "', 'yyyy-mm-dd hh24-mi-ss') -  T.D_OVER_TIME) * 24) >= -5)   ";


            return DbHelperOra.Query(sql).Tables[0];
        }

        /// <summary>
        /// 删除大方坯入坑记录
        /// </summary>
        /// <param name="dhlPlans"></param>
        public void DelDfpHl(List<Mod_TPA_DHL_PLAN> dhlPlans)
        {
            if (dhlPlans != null && dhlPlans.Count > 0)
            {
                string sql = @"DELETE TPA_DHL_PLAN  ";
                for (int i = 0; i < dhlPlans.Count; i++)
                {
                    if (i == 0)
                        sql += @" WHERE C_ID='" + dhlPlans[i].C_ID + "'  ";
                    else
                        sql += @" OR C_ID='" + dhlPlans[i].C_ID + "'  ";
                }
                DbHelperOra.ExecuteSql(sql);
            }
        }

        /// <summary>
        /// 删除大方坯入坑记录
        /// </summary>
        /// <param name="dhlPlans"></param>
        public void DelDfpHl_FK(List<Mod_TSP_PLAN_SMS> dhlPlans)
        {
            if (dhlPlans != null && dhlPlans.Count > 0)
            {
                string sql = @"DELETE TPA_DHL_PLAN  ";
                for (int i = 0; i < dhlPlans.Count; i++)
                {
                    if (i == 0)
                        sql += @" WHERE C_FK='" + dhlPlans[i].C_ID + "'  ";
                    else
                        sql += @" OR C_FK='" + dhlPlans[i].C_ID + "'  ";
                }
                DbHelperOra.ExecuteSql(sql);
            }
        }

        /// <summary>
        /// 删除连铸计划
        /// </summary>
        /// <param name="smsPlans"></param>
        public bool DelSms(List<Mod_TSP_PLAN_SMS> smsPlans)
        {
            int rows = 0;
            if (smsPlans != null && smsPlans.Count > 0)
            {
                string sql = @"DELETE TSP_PLAN_SMS  ";
                for (int i = 0; i < smsPlans.Count; i++)
                {
                    if (i == 0)
                        sql += @" WHERE C_ID='" + smsPlans[i].C_ID + "'  ";
                    else
                        sql += @" OR C_ID='" + smsPlans[i].C_ID + "'  ";
                }
                rows = TransactionHelper.ExecuteSql(sql);
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
        /// 删除小方坯入坑坯记录
        /// </summary>
        /// <param name="dhlPlans"></param>
        public void DelHl(List<Mod_TPA_HL_PLAN> hlPlans)
        {
            if (hlPlans != null && hlPlans.Count > 0)
            {
                string sql = @"DELETE TPA_HL_PLAN  ";
                for (int i = 0; i < hlPlans.Count; i++)
                {
                    if (i == 0)
                        sql += @" WHERE C_ID='" + hlPlans[i].C_ID + "'  ";
                    else
                        sql += @" OR C_ID='" + hlPlans[i].C_ID + "'  ";
                }
                DbHelperOra.ExecuteSql(sql);
            }
        }

        /// <summary>
        /// 删除小方坯入坑坯记录
        /// </summary>
        /// <param name="dhlPlans"></param>
        public void DelHl_FK(List<Mod_TSP_PLAN_SMS> hlPlans)
        {
            if (hlPlans != null && hlPlans.Count > 0)
            {
                string sql = @"DELETE TPA_HL_PLAN  ";
                for (int i = 0; i < hlPlans.Count; i++)
                {
                    if (i == 0)
                        sql += @" WHERE C_FK='" + hlPlans[i].C_ID + "'  ";
                    else
                        sql += @" OR C_FK='" + hlPlans[i].C_ID + "'  ";
                }
                DbHelperOra.ExecuteSql(sql);
            }
        }

        /// <summary>
        /// 删除修磨记录
        /// </summary>
        /// <param name="dhlPlans"></param>
        public void DelXm_FK(List<Mod_TSP_PLAN_SMS> xmPlans)
        {
            if (xmPlans != null && xmPlans.Count > 0)
            {
                string sql = @"DELETE TPA_XM_PLAN  ";
                for (int i = 0; i < xmPlans.Count; i++)
                {
                    if (i == 0)
                        sql += @" WHERE C_FK='" + xmPlans[i].C_ID + "'  ";
                    else
                        sql += @" OR C_FK='" + xmPlans[i].C_ID + "'  ";
                }
                DbHelperOra.ExecuteSql(sql);
            }
        }

        /// <summary>
        /// 删除开坯记录
        /// </summary>
        /// <param name="dhlPlans"></param>
        public void DelKp_FK(List<Mod_TSP_PLAN_SMS> kpPlans)
        {
            if (kpPlans != null && kpPlans.Count > 0)
            {
                string sql = @"DELETE TPA_KP_PLAN  ";
                for (int i = 0; i < kpPlans.Count; i++)
                {
                    if (i == 0)
                        sql += @" WHERE C_FK='" + kpPlans[i].C_ID + "'  ";
                    else
                        sql += @" OR C_FK='" + kpPlans[i].C_ID + "'  ";
                }
                DbHelperOra.ExecuteSql(sql);
            }
        }

        /// <summary>
        /// 获取虚拟坑最大入坑支数
        /// </summary>
        /// <returns></returns>
        public int GetVirtualLocMaxQua()
        {
            string sql = @"
                                    SELECT MAX(TDP.N_TOTAL_QUA)N_TOTAL_QUA
                                    FROM TPA_DHL_PLAN TDP
                                    WHERE TDP.C_WH_CODE='0'
                                    ";
            object obj = DbHelperOra.GetSingle(sql);
            int result = 0;
            int value = 0;
            if (obj != null)
            {
                if (int.TryParse(obj.ToString(), out value))
                    result = value;
            }
            return result;
        }

        /// <summary>
        /// 获取虚拟坑最大入坑支数
        /// </summary>
        /// <returns></returns>
        public int GetVirtualXLocMaxQua()
        {
            string sql = @"
                                    SELECT MAX(TDP.N_TOTAL_QUA)N_TOTAL_QUA
                                    FROM TPA_HL_PLAN TDP
                                    WHERE TDP.C_WH_CODE='0'
                                    ";
            object obj = DbHelperOra.GetSingle(sql);
            int result = 0;
            int value = 0;
            if (obj != null)
            {
                if (int.TryParse(obj.ToString(), out value))
                    result = value;
            }
            return result;
        }

        /// <summary>
        /// 获取出坑时间
        /// </summary>
        /// <param name="whCode">坑位编号</param>
        /// <param name="num">第几次入坑</param>
        /// <returns></returns>
        public DataTable GetOutPitTime(string whCode, int num)
        {
            string sql = @"SELECT 
                                    TDP.C_FK,
                                    (SELECT MAX(D_OVER_TIME) FROM TPA_DHL_PLAN  WHERE C_WH_CODE='" + whCode + "'  AND N_NUM=" + num + " ) D_OVER_TIME ";
            sql += @"    FROM TPA_DHL_PLAN TDP
                                    WHERE TDP.C_WH_CODE = '" + whCode + "' ";
            sql += "  AND TDP.N_NUM = " + num + " ";
            return DbHelperOra.Query(sql).Tables[0];
        }

        /// <summary>
        /// 获取出坑时间(小方坯)
        /// </summary>
        /// <param name="whCode">坑位编号</param>
        /// <param name="num">第几次入坑</param>
        /// <returns></returns>
        public DataTable GetOutPitXTime(string whCode, int num)
        {
            string sql = @"SELECT 
                                    TDP.C_FK,
                                    (SELECT MAX(D_OVER_TIME) FROM TPA_HL_PLAN  WHERE C_WH_CODE='" + whCode + "'  AND N_NUM=" + num + " ) D_OVER_TIME ";
            sql += @"    FROM TPA_DHL_PLAN TDP
                                    WHERE TDP.C_WH_CODE = '" + whCode + "' ";
            sql += "  AND TDP.N_NUM = " + num + " ";
            return DbHelperOra.Query(sql).Tables[0];
        }

    }
}
;