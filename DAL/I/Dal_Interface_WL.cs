﻿using DAL;
using MODEL;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
namespace DAL
{
    public partial class Dal_Interface_WL
    {
        public Dal_Interface_WL()
        { }
        Dal_Interface_NC_DM dal_Interface_NC_DM = new Dal_Interface_NC_DM();
        #region 向条码发送发运单实绩信息
        /// <summary>
        /// 向NC发送发运单
        /// </summary>
        /// <param name="fydid">发运单id</param>
        /// <returns>返回int类型 0发运单数据为空1成功，-1写入中间表出错,-2发送NC错误-3代码错误</returns>
        public string SENDFYD(string fydid, string path)
        {
            string LogSql = "";
            string name = "Dal_Interface_WL.SENDFYD";
            try
            {
                TransactionHelper.BeginTransaction();
                if (UPSLABSTATUS_Tran(fydid, "S") == 0)
                {
                    TransactionHelper.RollBack();
                    return "变更钢坯状态错误！";
                }
                if (UPFYDSTATUS_Tran(fydid, "9") == 0)
                {
                    TransactionHelper.RollBack();
                    return "变更发运单状态错误！";
                }
                string message = dal_Interface_NC_DM.SendXml_DM(path, fydid);
                if (message != "1")
                {
                    TransactionHelper.RollBack();
                    return message;
                }
                TransactionHelper.Commit();
                return "1";
            }
            catch (Exception ex)
            {
                LogSql = "INSERT INTO TI_RF_LOG(C_TYPE, C_LOG, C_NAME) VALUES('向物流发送发运单','" + ex.ToString() + "','" + name + "')";
                DbHelperOra.ExecuteSql(LogSql);
                return ex.ToString();
            }
        }
        /// <summary>
        /// 通过发运单号获得出库单数据
        /// </summary>
        /// <param name="idstr">id字符串</param>
        /// <returns></returns>
        public DataSet GetListByidstr(string idstr)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT SUM(n_Wgt) AS N_WGT,SUM(N_JZ) AS N_JZ,COUNT(1) AS N_NUM,C_STL_GRD,C_SPEC,C_MAT_CODE,C_STD_CODE,C_SLABWH_CODE,C_STOVE,C_BATCH_NO,C_MAT_NAME,c_Judge_Lev_Zh from TSC_SLAB_MAIN WHERE C_ID IN(" + idstr + ")");
            strSql.Append(" GROUP BY C_STL_GRD,C_SPEC,C_MAT_CODE,C_STD_CODE,C_SLABWH_CODE,C_STOVE,C_BATCH_NO,C_MAT_NAME,c_Judge_Lev_Zh ");
            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 查询钢坯实绩
        /// </summary>
        /// <param name="fydh">发运单号</param>
        /// <param name="C_STOVE">炉号</param>
        /// <param name="C_BATCH_NO">批号</param>
        /// <param name="C_MAT_CODE">物料号</param>
        /// <param name="C_STD_CODE">执行标准</param>
        /// <param name="C_SLABWH_CODE">仓库</param>
        /// <param name="C_JUDGE_LEV_ZH">质量等级</param>
        /// <param name="status">状态</param>
        /// <returns></returns>
        public DataSet GetListByidstr(string fydh, string C_MAT_CODE, string C_STD_CODE, string C_SLABWH_CODE, string C_JUDGE_LEV_ZH, string status)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT C_ID,N_QUA N_NUM,N_WGT, N_JZ,C_STOVE,C_BATCH_NO,C_MAT_CODE,C_MAT_NAME,C_SPEC,C_STL_GRD,C_STD_CODE,C_SLABWH_CODE,nvl(C_JUDGE_LEV_ZH,C_MAT_TYPE)C_JUDGE_LEV_ZH from TSC_SLAB_MAIN WHERE C_MOVE_TYPE='1' AND  nvl(C_FRFLAG,0)=0");
            if (fydh.Trim() != "")
            {
                strSql.Append(" AND C_FYDH ='" + fydh + "'");
            }
            if (C_MAT_CODE.Trim() != "")
            {
                strSql.Append(" AND C_MAT_CODE ='" + C_MAT_CODE + "'");
            }
            if (C_STD_CODE.Trim() != "")
            {
                strSql.Append(" AND C_STD_CODE ='" + C_STD_CODE + "'");
            }
            if (C_SLABWH_CODE.Trim() != "")
            {
                strSql.Append(" AND C_SLABWH_CODE ='" + C_SLABWH_CODE + "'");
            }
            if (C_JUDGE_LEV_ZH.Trim() != "")
            {
                strSql.Append(" AND C_JUDGE_LEV_ZH ='" + C_JUDGE_LEV_ZH + "'");
            }
            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 通过发运单号获得发运单数据
        /// </summary>
        /// <param name="idstr">发运单号字符串('id1','id2')</param>
        /// <returns></returns>
        public DataSet GetListByDH(string dhstr)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT b.c_dispatch_id,b.c_Send_Stock,a.c_Shipvia,a.c_Lic_Pla_No,b.c_Mat_Code, b.c_Mat_Name, a.c_Atstation, a.c_Business_Dept, a.c_Business_Id, a.c_Create_Id, a.d_Create_Dt, b.c_Stl_Grd,b.C_STD_CODE, b.c_Spec, c.c_Free1, c.c_Free2, c.c_Pack, c.c_area, c.c_cust_no, d.c_checkstate_name from TMD_DISPATCH a, TMD_DISPATCHDETAILS b, TMO_ORDER c, TQB_CHECKSTATE d WHERE a.c_id = b.c_dispatch_id AND b.c_no = c.c_order_no AND b.c_qualiry_lev = d.C_CHECKSTATE_NAME AND d.C_REMARK=c.C_XGID ");
            if (dhstr.Trim() != "")
            {
                strSql.Append(" AND b.C_DISPATCH_ID ='" + dhstr + "' ");
            }
            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 删除发运单中间表数据
        /// </summary>
        /// <param name="dh">发运单号</param>
        /// <returns></returns>
        public int DELFYD(string dh)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("DELETE TMD_DISPATCH_SJZJB ");
            strSql.Append(" WHERE c_Dispatch_Id ='" + dh + "'");
            return DbHelperOra.ExecuteSql(strSql.ToString());
        }

        /// <summary>
        /// 更新发运单状态
        /// </summary>
        /// <param name="dh">发运单号</param>
        /// <param name="status">状态</param>
        /// <returns></returns>
        public int UPFYDSTATUS(string dh, string status)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("UPDATE TMD_DISPATCH SET");
            strSql.Append(" C_STATUS='" + status + "'");
            strSql.Append(" WHERE C_ID ='" + dh + "'");
            return DbHelperOra.ExecuteSql(strSql.ToString());
        }
        /// <summary>
        /// 根据idstr更新钢坯库存状态
        /// </summary>
        /// <param name="idstr">库存钢坯id字符串</param>
        /// <returns></returns>
        public string GPFY(string dh)
        {
            TransactionHelper.BeginTransaction();
            if (UPSLABSTATUS_Tran(dh, "S") == 0)
            {
                return "变更钢坯状态错误！";
            }
            if (UPFYDSTATUS_Tran(dh, "8") == 0)
            {
                return "变更发运单状态错误！";
            }
            TransactionHelper.Commit();
            return "1";
        }
        /// <summary>
        /// 根据idstr更新钢坯库存状态
        /// </summary>
        /// <param name="idstr">库存钢坯id字符串</param>
        /// <param name="type">状态</param>
        /// <param name="status">要变更的状态</param>
        /// <returns></returns>
        public int UPSLABSTATUS_Tran(string dh, string status)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("UPDATE TSC_SLAB_MAIN SET");
            strSql.Append(" C_MOVE_TYPE='" + status + "'");
            strSql.Append(" WHERE C_FYDH ='" + dh + "' ");
            return TransactionHelper.ExecuteSql(strSql.ToString());
        }
        /// <summary>
        /// 根据idstr更新钢坯库存状态
        /// </summary>
        /// <param name="idstr">库存钢坯id字符串</param>
        /// <param name="type">状态</param>
        /// <param name="status">要变更的状态</param>
        /// <returns></returns>
        public int UPSLABSTATUS(string dh, string type, string status)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("UPDATE TSC_SLAB_MAIN SET");
            strSql.Append(" C_MOVE_TYPE='" + status + "'");
            if (type == "0")
            {
                strSql.Append(" ,C_FYDH=''");
            }
            strSql.Append(" WHERE C_FYDH ='" + dh + "' ");
            return DbHelperOra.ExecuteSql(strSql.ToString());
        }
        /// <summary>
        /// 更新发运单状态
        /// </summary>
        /// <param name="dh">发运单号</param>
        /// <param name="status">状态</param>
        /// <returns></returns>
        public int UPFYDSTATUS_Tran(string dh, string status)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("UPDATE TMD_DISPATCH SET");
            strSql.Append(" C_STATUS='" + status + "'");
            strSql.Append(" WHERE C_ID ='" + dh + "'");
            return TransactionHelper.ExecuteSql(strSql.ToString());
        }
        /// <summary>
        /// 发送发运单到中间表
        /// </summary>
        /// <param name="fydid">要发送的发运单号</param>
        /// <returns>返回int类型 1转入成功-1发送失败</returns>
        public string ADDFYDToZJB(string fydid, DateTime dateTime)
        {
            TransactionHelper.BeginTransaction();
            #region MyRegion
            string rjhsql = "SELECT C_PLAN_ID,C_ID,C_MAT_CODE,C_STD_CODE,C_SEND_STOCK_CODE,c_Judge_Lev_Zh,C_PACK,N_FYZS FROM TMD_DISPATCHDETAILS WHERE C_DISPATCH_ID='" + fydid + "'";
            DataTable plandt = TransactionHelper.Query(rjhsql).Tables[0];
            if (plandt.Rows.Count < 1)
            {
                TransactionHelper.RollBack();
                return "未查询到发运单子表数据！";
            }
            foreach (DataRow planrow in plandt.Rows)
            {
                int plannum = Convert.ToInt32(planrow["N_FYZS"]);
                #region 获取出库单
                string no = RV.UI.ServerTime.timeNow().Year.ToString() + (Convert.ToInt32(RV.UI.ServerTime.timeNow().Month) > 9 ? RV.UI.ServerTime.timeNow().Month.ToString() : ("0" + RV.UI.ServerTime.timeNow().Month.ToString())) + (Convert.ToInt32(RV.UI.ServerTime.timeNow().Day) > 9 ? RV.UI.ServerTime.timeNow().Day.ToString() : ("0" + RV.UI.ServerTime.timeNow().Day.ToString()));//转库单号
                string maxckd = GetCKDNO(no);//查询当天最大转库单
                if (maxckd == "0")
                {
                    no = no + "0001";
                }
                else
                {
                    no = (Convert.ToInt64(maxckd.Substring(2, maxckd.Length - 2)) + 1).ToString();
                }
                no = "GP" + no;
                #endregion
                #region 获取线材实绩
                DataTable dt1 = GetListByidstr(fydid, planrow["C_MAT_CODE"].ToString(), planrow["C_STD_CODE"].ToString(), planrow["C_SEND_STOCK_CODE"].ToString(), planrow["c_Judge_Lev_Zh"].ToString(), "1").Tables[0];//要传输的发运单数据
                if (dt1.Rows.Count < 1)
                {
                    TransactionHelper.RollBack();
                    return "根据发运单子表查询线材实绩错误！";
                }
                int fpnum = 0;
                string idstr = "";
                foreach (DataRow xqitem in dt1.Rows)
                {
                    if (plannum == fpnum)
                    {
                        break;
                    }
                    idstr += "'" + xqitem["C_ID"] + "',";
                    fpnum++;
                }
                idstr = idstr.Substring(0, idstr.Length - 1);
                #region 变更线材实绩
                if (BJBynum(plannum, fydid) == 0)
                {
                    TransactionHelper.RollBack();
                    return "根据发运单子表变更线材实绩错误！";
                }
                #endregion
                DataTable sjdt = GetListByidstr(idstr).Tables[0];//要传输的发运单数据
                foreach (DataRow item1 in sjdt.Rows)
                {
                    #region 添加中间表
                    string sql = "";
                    sql += "insert into TMD_DISPATCH_SJZJB(C_DISPATCH_ID,N_NUM,N_STATUS,C_CKDH,N_JZ,C_SEND_STOCK,C_STOVE,C_BATCH_NO,C_PLAN_ID,C_STL_GRD,C_STD_CODE,C_SPEC,C_PK_NCID,C_ZLDJ,C_BZYQ,D_CKSJ,C_MAT_CODE,C_MAT_NAME,C_TICK_STR) values('" + fydid + "','" + item1["N_NUM"] + "','8','" + no + "','" + item1["N_WGT"] + "','" + item1["C_SLABWH_CODE"] + "','" + item1["C_STOVE"] + "','" + item1["C_BATCH_NO"] + "','" + planrow["C_PLAN_ID"].ToString() + "','" + item1["C_STL_GRD"] + "','" + item1["C_STD_CODE"] + "','" + item1["C_SPEC"] + "','" + planrow["C_ID"].ToString() + "','" + item1["C_JUDGE_LEV_ZH"].ToString() + "','',to_date('" + dateTime + "', 'yyyy-mm-dd hh24:mi:ss'),'" + item1["C_MAT_CODE"].ToString() + "','" + item1["C_MAT_NAME"].ToString() + "','')";
                    if (TransactionHelper.ExecuteSql(sql) == 0)
                    {
                        TransactionHelper.RollBack();
                        return "条件发运单中间表错误！";
                    }
                    #endregion
                }
                #endregion
            }
            #endregion

            TransactionHelper.Commit();
            return "1";
        }
        /// <summary>
        /// 根据发运单号更新线材实绩
        /// </summary>
        /// <param name="num">数量</param>
        /// <returns></returns>
        public int BJBynum(int num, string fydh)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("UPDATE TSC_SLAB_MAIN SET");
            strSql.Append(" C_FRFLAG='1'");
            strSql.Append("  where C_FYDH='" + fydh + "' AND rownum<='" + num + "'");
            return TransactionHelper.ExecuteSql(strSql.ToString());
        }
        /// <summary>
        /// 获取最新的钢坯出库单号
        /// </summary>
        /// <param name="ckdh">出库单号</param>
        /// <returns></returns>
        public string GetCKDNO(string ckdh)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select MAX(C_CKDH) ");
            strSql.Append(" FROM TMD_DISPATCH_SJZJB WHERE 1=1 ");
            if (ckdh.Trim() != "")
            {
                strSql.Append(" AND C_CKDH LIKE 'GP" + ckdh + "%' ");
            }
            object obj = TransactionHelper.GetSingle(strSql.ToString());
            if (obj == null)
            {
                return "0";
            }
            else
            {
                return obj.ToString();
            }
        }
        /// <summary>
        /// 根据发运单号获取发运单状态
        /// </summary>
        /// <param name="fydh">发运单</param>
        /// <returns></returns>
        public string GetFYDZT(string fydh)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_STATUS ");
            strSql.Append(" FROM TMD_DISPATCH WHERE 1=1 ");
            if (fydh.Trim() != "")
            {
                strSql.Append(" AND C_ID = '" + fydh + "' ");
            }
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
        #endregion

    }
}