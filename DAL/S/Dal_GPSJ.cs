using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;
namespace DAL
{
    public class Dal_GPSJ
    {
        /// <summary>
        /// 获得数据列表- 实绩信息
        /// </summary>
        /// <param name="begin">开始时间</param>
        /// <param name="end">结束时间</param>
        /// <param name="C_STOVE">炉号</param> 
        /// <param name="stl">钢种</param>
        /// <param name="std">执行标准</param>
        /// <param name="slabwhCode">仓库编码</param>
        /// <param name="code">仓库编码</param>
        /// <param name="matType">表判</param>
        /// <returns></returns>
        public DataSet GetList_SJ_Group(string C_STOVE, string stl, string std, string slabwhCode, string code
            , string matType, string strZT)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(@"SELECT TSM.C_STOVE,
                            TSM.C_BATCH_NO,
                            COUNT(TSM.C_STOVE) N_QUA,
                            TSM.C_STL_GRD,
                            TSM.C_SPEC ,
                            TSM.N_LEN,
                            TSM.C_STD_CODE C_STD_CODE,
                            TSM.C_JUDGE_LEV_ZH,
                            Decode(TSM.C_MOVE_TYPE,'S','已销售','N','待入库','DZ','待轧','NP','待开坯','R','入炉','C','出炉','EX','消耗','M','调拨中','E','入库','DX','待修磨','0','销售占用','1','销售实绩','TP','挑坯改判')C_MOVE_TYPE,
                            sum(TSM.N_WGT) N_WGT ,
                            TSM.C_SLABWH_CODE,
                            (SELECT TS.C_SLABWH_NAME FROM TPB_SLABWH TS WHERE TS.C_SLABWH_CODE = TSM.C_SLABWH_CODE AND TS.N_STATUS = 1) C_SLABWH_CODE_NAME,
                            (SELECT TSA.C_SLABWH_AREA_NAME  FROM TPB_SLABWH_AREA TSA  WHERE TSA.C_SLABWH_AREA_CODE = TSM.C_SLABWH_AREA_CODE AND TSA.N_STATUS = 1)           C_SLABWH_AREA_CODE_NAME,
                            (SELECT TST.C_SLABWH_LOC_NAME  FROM TPB_SLABWH_LOC TST  WHERE TST.C_SLABWH_LOC_CODE = TSM.C_SLABWH_LOC_CODE  AND TST.N_STATUS = 1)      C_SLABWH_LOC_CODE_NAME,
                            TSM.C_SLABWH_TIER_CODE,
                            (SELECT MAX(TO_NUMBER( TT.C_SLABWH_TIER_CODE)) 
                               FROM TSC_SLAB_MAIN TT
                              WHERE TT.C_SLABWH_LOC_CODE = TSM.C_SLABWH_LOC_CODE
                                AND (TT.C_MOVE_TYPE != 'S' AND TT.C_MOVE_TYPE!='C' AND TSM.C_MOVE_TYPE!='EX'AND TSM.C_MOVE_TYPE!='1'AND TSM.C_MOVE_TYPE!='0' AND TSM.C_MOVE_TYPE!='P' )) MAXTIER,
                            MAX(TSM.C_SLABWH_LOC_CODE) C_SLABWH_LOC_CODE,
                            MAX(TSM.C_SLABWH_AREA_CODE) C_SLABWH_AREA_CODE,
                            TSM.C_MAT_CODE,
                            TSM.C_MAT_NAME,
                            MAX(TSM.C_WE_SHIFT)C_SHIFT,       
                            MAX(TSM.C_WE_GROUP)C_GROUP,
                            MAX(TSM.D_WE_DATE)DT,
                            TSM.C_REMARK,
                            TSM.C_MOVE_TYPE
                       FROM TSC_SLAB_MAIN TSM   WHERE 1 = 1  AND (TSM.C_MOVE_TYPE != 'S' AND TSM.C_MOVE_TYPE != 'P'  AND TSM.C_MOVE_TYPE!='EX' AND TSM.C_MOVE_TYPE!='1' AND TSM.C_MOVE_TYPE!='0'  ) ");

            if (!string.IsNullOrEmpty(C_STOVE))
            {
                strSql.Append(" AND ( TSM.C_STOVE like '%" + C_STOVE + "%' or  TSM.C_BATCH_NO like '%" + C_STOVE + "%' ) ");
            }
            if (!string.IsNullOrEmpty(stl))
            {
                strSql.Append(" and upper(TSM.C_STL_GRD) like upper('%" + stl + "%') ");
            }
            if (!string.IsNullOrEmpty(std))
            {
                strSql.Append(" and  TSM.C_STD_CODE like '%" + std + "%' ");
            }
            if (slabwhCode != "全部")
            {
                strSql.Append(" and  TSM.c_slabwh_code  ='" + slabwhCode + "' ");
            }
            if (!string.IsNullOrEmpty(code))
            {
                strSql.Append(" and  TSM.c_slabwh_code LIKE '%" + code + "%' ");
            }
            if (!string.IsNullOrEmpty(matType))
            {
                strSql.Append(" and  TSM.c_mat_type  ='" + matType + "' ");
            }
            if (strZT != "全部")
            {
                strSql.Append(" and  TSM.C_MOVE_TYPE  ='" + strZT + "' ");
            }
            strSql.Append(@"  GROUP BY TSM.C_BATCH_NO,
                              TSM.C_STOVE,
                              TSM.C_STD_CODE,
                              TSM.C_MAT_CODE,
                              TSM.C_MAT_NAME,
                              TSM.C_STL_GRD,
                              TSM.C_SPEC ,
                              TSM.N_LEN, 
                              TSM.C_JUDGE_LEV_ZH,
                              TSM.C_MAT_TYPE,
                              TSM.C_REMARK,
                              TSM.C_SLABWH_CODE,
                              TSM.C_MOVE_TYPE,
                              TSM.C_SLABWH_CODE,
                              TSM.C_SLABWH_AREA_CODE,
                              TSM.C_SLABWH_LOC_CODE,
                              TSM.C_SLABWH_TIER_CODE
                     ORDER BY TO_NUMBER(NVL(TSM.C_SLABWH_TIER_CODE,'0'))  DESC ");
            return DbHelperOra.Query(strSql.ToString());
        }

        public bool UpdateSlabRemark(string stove, string matCode, string slabwhCode, string remark, string batchNo)
        {
            string sql = "";
            if (string.IsNullOrWhiteSpace(batchNo))
                sql = @"UPDATE TSC_SLAB_MAIN TSM  SET TSM.C_REMARK='" + remark + "'   WHERE TSM.C_STOVE='" + stove + "'  AND TSM.C_MAT_CODE='" + matCode + "' AND TSM.C_SLABWH_CODE='" + slabwhCode + "'";
            else
            {
                sql = @"UPDATE TSC_SLAB_MAIN TSM  SET TSM.C_REMARK='" + remark + "'   WHERE TSM.C_BATCH_NO='" + batchNo + "'  AND TSM.C_MAT_CODE='" + matCode + "' AND TSM.C_SLABWH_CODE='" + slabwhCode + "'";
            }

            int rows = DbHelperOra.ExecuteSql(sql);
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
        /// 标记钢坯异常
        /// </summary>
        /// <param name="stove">炉号</param>
        /// <param name="matCode">物料编码</param>
        /// <param name="slabwhCode">货位</param>
        /// <param name="remark">异常原因</param>
        /// <param name="batchNo">开坯号</param>
        /// <returns>标记是否成功</returns>
        public bool UpdateSlabYC(string stove, string matCode, string slabwhCode, string remark, string batchNo)
        {
            string sql = "";
            if (string.IsNullOrWhiteSpace(batchNo))
                sql = @"UPDATE TSC_SLAB_MAIN TSM  SET TSM.C_KP_ID='" + remark + "'   WHERE TSM.C_STOVE='" + stove + "'  AND TSM.C_MAT_CODE='" + matCode + "' AND TSM.C_SLABWH_CODE='" + slabwhCode + "'";
            else
            {
                sql = @"UPDATE TSC_SLAB_MAIN TSM  SET TSM.C_KP_ID='" + remark + "'   WHERE TSM.C_BATCH_NO='" + batchNo + "'  AND TSM.C_MAT_CODE='" + matCode + "' AND TSM.C_SLABWH_CODE='" + slabwhCode + "'";
            }

            int rows = DbHelperOra.ExecuteSql(sql);
            if (rows > 0)
            {
                string sql2 = "";
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 标记钢坯异常
        /// </summary>
        /// <param name="stove">炉号</param>
        /// <param name="matCode">物料编码</param>
        /// <param name="slabwhCode">货位</param>
        /// <param name="remark">异常原因</param>
        /// <param name="batchNo">开坯号</param>
        /// <returns>标记是否成功</returns>
        public bool UpdateSlabCancleYC(string stove, string matCode, string slabwhCode, string batchNo)
        {
            string sql = "";
            if (string.IsNullOrWhiteSpace(batchNo))
                sql = @"UPDATE TSC_SLAB_MAIN TSM  SET TSM.C_KP_ID=''   WHERE TSM.C_STOVE='" + stove + "'  AND TSM.C_MAT_CODE='" + matCode + "' AND TSM.C_SLABWH_CODE='" + slabwhCode + "'";
            else
            {
                sql = @"UPDATE TSC_SLAB_MAIN TSM  SET TSM.C_KP_ID=''   WHERE TSM.C_BATCH_NO='" + batchNo + "'  AND TSM.C_MAT_CODE='" + matCode + "' AND TSM.C_SLABWH_CODE='" + slabwhCode + "'";
            }

            int rows = DbHelperOra.ExecuteSql(sql);
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
        /// 获取钢坯信息
        /// </summary>
        /// <returns></returns>
        public DataTable GetSlabInfo(string stove)
        {
            string sql = " SELECT * FROM TSC_SLAB_MAIN T WHERE T.C_STOVE='" + stove + "' AND T.C_MOVE_TYPE='E'  ";
            return DbHelperOra.Query(sql).Tables[0];
        }


    }
}
