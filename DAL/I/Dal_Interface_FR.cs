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
    public partial class Dal_Interface_FR
    {
        Dal_TB_STA dal_TB_STA = new Dal_TB_STA();
        Dal_TB_MATRL_MAIN dal_matra = new Dal_TB_MATRL_MAIN();
        Dal_TB_STD_CONFIG dalTbStdConfig = new Dal_TB_STD_CONFIG();
        Dal_Interface_NC_XC dal_Interface_NC_XC = new Dal_Interface_NC_XC();
        Dal_Interface_NC_Roll_ZK4I dal_Interface_NC_Roll_ZK4I = new Dal_Interface_NC_Roll_ZK4I();
        Dal_Interface_NC_Roll_ZK4A dal_Interface_NC_Roll_ZK4A = new Dal_Interface_NC_Roll_ZK4A();
        Dal_Interface_NC_Roll_QT4A dal_Interface_NC_Roll_QT4A = new Dal_Interface_NC_Roll_QT4A();
        Dal_Interface_NC_Roll_QT4I dal_Interface_NC_Roll_QT4I = new Dal_Interface_NC_Roll_QT4I();
        public Dal_Interface_FR()
        { }
        /// <summary>
        /// 根据批号、钩号判断本地库存是否存在当前卷信息
        /// </summary>
        /// <param name="PH">批号</param>
        /// <param name="GH">钩号</param>
        /// <returns>是否存在</returns>
        public bool Exists(string PH, string GH)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TRC_ROLL_PRODCUT ");
            strSql.Append(" where C_BATCH_NO='" + PH + "' and  C_TICK_NO ='" + GH + "'");
            return DbHelperOra.Exists(strSql.ToString());
        }

        #region 同步条码库存信息
        /// <summary>
        /// 获取条码库存信息
        /// </summary>
        /// <param name="Barcode">钢卷唯一码</param>
        /// <param name="CK">仓库</param>
        /// <param name="HW">货位</param>
        /// <param name="WGDH">完工单号</param>
        /// <param name="PH">批号</param>
        /// <param name="GH">钩号</param>
        /// <param name="GZ">钢种</param>
        /// <returns>条码库存信息</returns>
        public DataSet GetWWKCList()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from XGERP50.V_ONHANd_wwjg t ");
            return DbHelperNC.Query(strSql.ToString());
        }

        /// <summary>
        /// 根据批号获取条码库存钢卷信息
        /// </summary>
        /// <param name="PCH"></param>
        /// <returns></returns>
        public DataTable GetRFListByPCH(string PCH)
        {
            string sql = "select t.PCH,t.GH,t.ZL,t.WeightRQ,t.CK,t.HW  FROM WMS_BMS_INV_INFO t where t.PCH='"+ PCH + "' ORDER BY t.GH ";
            return DbHelper_SQL.Query(sql).Tables[0];

        }

        /// <summary>
        /// 获取条码库存信息
        /// </summary>
        /// <param name="Barcode">钢卷唯一码</param>
        /// <param name="CK">仓库</param>
        /// <param name="HW">货位</param>
        /// <param name="WGDH">完工单号</param>
        /// <param name="PH">批号</param>
        /// <param name="GH">钩号</param>
        /// <param name="GZ">钢种</param>
        /// <returns>条码库存信息</returns>
        public DataSet GetKCList(string Barcode, string CK, string HW, string WGDH, string PH, string GH, string GZ)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT T1.BARCODE, T1.WGDH, T1.CK, T1.HW, T1.PCH, T1.WLH, T1.WLMC, T1.SX, T1.PH, T1.GG, T1.BB AS RKBB, T1.GH, T1.ZL, T1.BZ, T1.RQ, T1.RKTYPE, T1.RKRY, T1.WEIGHTRQ, T1.PRODUCEDATA, T1.VFREE1, T1.VFREE2, T1.VFREE3,T1.ERRSEASON,T1.PCInfo, T2.BB AS SCBB, T2.SCX, T2.ZXBZ, T2.VFREE0 ");

            strSql.Append(" FROM WMS_BMS_INV_INFO T1 JOIN WMS_BMS_REC_WGD T2 ON T1.WGDH = T2.WGDH  ");
            if (Barcode.Trim() != "")
            {
                strSql.Append(" and  T1.Barcode='" + Barcode + "' ");
            }
            if (CK.Trim() != "")
            {
                strSql.Append(" and  T1.CK='" + CK + "' ");
            }
            if (HW.Trim() != "")
            {
                strSql.Append(" and  T1.HW='" + HW + "' ");
            }
            if (WGDH.Trim() != "")
            {
                strSql.Append(" and  T1.WGDH='" + WGDH + "' ");
            }
            if (PH.Trim() != "")
            {
                strSql.Append(" and  T1.PCH='" + PH + "' ");
            }
            if (GH.Trim() != "")
            {
                strSql.Append(" and  T1.GH='" + GH + "' ");
            }
            if (GZ.Trim() != "")
            {
                strSql.Append(" and  T1.PH='" + GZ + "' ");
            }
            strSql.Append(" ORDER BY T1.RQ,T1.Barcode ");
            return DbHelper_SQL.Query(strSql.ToString());
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
            strSql.Append("SELECT TB.C_DESIGN_NO FROM TQB_STD_MAIN TA INNER JOIN TQB_DESIGN TB ON TA.C_ID=TB.C_STD_MAIN_ID WHERE TA.C_STD_CODE='" + C_STD_CODE + "' AND TA.C_STL_GRD='" + C_STL_GRD + "' AND TA.N_IS_CHECK=1 AND TA.N_STATUS=1  ");

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
        /// <summary>
        /// 获取工位id
        /// </summary>
        /// <param name="batch">批号</param>
        /// <returns></returns>
        public string GetSTA(string batch)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT C_ID  FROM TB_STA WHERE C_STA_CODE LIKE '%" + batch + "#ZX%'");
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
        /// <summary>
        ///同步条码库存信息
        /// </summary>
        /// <param name="Barcode">钢卷唯一码</param>
        /// <param name="CK">仓库</param>
        /// <param name="HW">货位</param>
        /// <param name="WGDH">完工单号</param>
        /// <param name="PH">批号</param>
        /// <param name="GH">钩号</param>
        /// <param name="GZ">钢种</param>
        /// <returns>同步结果</returns>
        public string TbKCList(string Barcode, string CK, string HW, string WGDH, string PH, string GH, string GZ)
        {
            string strResult = "";//同步结果
            int iUpdate = 0;//更新成功记录数
            int iUpdateE = 0;//更新失败记录数
            int iInsert = 0;//插入成功记录数
            int iInsertE = 0;//插入失败记录数
            DataTable dt = GetKCList(Barcode, CK, HW, WGDH, PH, GH, GZ).Tables[0];
            string strDesignNo = "";
            try
            {
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        string strFree1 = dt.Rows[i]["VFREE1"].ToString();
                        string strFree2 = dt.Rows[i]["VFREE2"].ToString();
                        //strFree1 = strFree1.Replace(" ", "");
                        //strFree2 = strFree2.Replace(" ", "");
                        //strFree1 = strFree1.Replace("（", "");
                        //strFree2 = strFree2.Replace("（", "");
                        //strFree1 = strFree1.Replace("）", "");
                        //strFree2 = strFree2.Replace("）", "");
                        string spec = dt.Rows[i]["GG"].ToString().Replace("mm", "");
                        string bz = strFree1.Split('~')[1].Contains("协议") ? strFree2.Split('~')[1].Replace(" ", "").Replace("（", "(").Replace("）", ")") : strFree1.Split('~')[1].Replace(" ", "").Replace("（", "(").Replace("）", ")");

                        //string strStdCode = dalTbStdConfig.Get_Std_Code(strFree1, strFree2);//获取质量等级
                        string strarea = dt.Rows[i]["HW"].ToString();
                        string pch = dt.Rows[i]["PCH"].ToString();
                        string batch = pch.Substring(1, 1);
                        string staid = GetSTA(batch);
                        if (strarea.Length > 4)
                        {
                            strarea = strarea.Substring(0, 5);
                        }
                        if (bz != "")
                        {
                            strDesignNo = Get_Design_No(bz, dt.Rows[i]["PH"].ToString());
                        }
                        string sql = "select pclx from WMS_Bms_Rec_WGD WHERE PCH='" + pch + "'";
                        string obj = DbHelper_SQL.GetSingle(sql).ToString();
                        string zpdj = "";
                        if (obj != "1")
                        {
                            zpdj = dt.Rows[i]["SX"].ToString();
                        }
                        //查询订单
                        string InsertSql = "INSERT INTO TRC_ROLL_PRODCUT (C_ID,C_BARCODE, C_TRC_ROLL_MAIN_ID, C_LINEWH_CODE, C_LINEWH_LOC_CODE, C_BATCH_NO, C_MAT_CODE, C_MAT_DESC, C_JUDGE_LEV_ZH,C_REASON_NAME, C_STL_GRD, C_SPEC, C_DP_GROUP, C_TICK_NO, N_WGT, C_STD_CODE, D_RKRQ, C_MOVE_DESC, C_RKRY, D_WEIGHT_DT, D_MOD_DT, C_ZYX1, C_ZYX2, C_BZYQ, C_GROUP, C_PLANT_ID,  C_STOVE ,C_STA_ID,C_MOVE_TYPE,C_ORDER_NO,C_DESIGN_NO,D_DP_DT,C_IS_QR,C_IS_TB,C_IS_PD,D_PRODUCE_DATE,C_JUDGE_LEV_BP,C_LINEWH_AREA_CODE,C_SALE_AREA，N_SFOB) VALUES ('" + dt.Rows[i]["BARCODE"].ToString() + "','" + dt.Rows[i]["BARCODE"].ToString() + "','" + dt.Rows[i]["WGDH"].ToString() + "','" + dt.Rows[i]["CK"].ToString() + "','" + dt.Rows[i]["HW"].ToString() + "','" + dt.Rows[i]["PCH"].ToString() + "','" + dt.Rows[i]["WLH"].ToString() + "','" + dt.Rows[i]["WLMC"].ToString() + "','" + zpdj + "','" + dt.Rows[i]["ERRSEASON"].ToString() + "','" + dt.Rows[i]["PH"].ToString() + "','" + spec + "','" + dt.Rows[i]["RKBB"].ToString() + "','" + dt.Rows[i]["GH"].ToString() + "','" + dt.Rows[i]["ZL"].ToString() + "','" + bz + "',to_date( '" + dt.Rows[i]["RQ"].ToString() + "','yyyy-mm-dd hh24:mi:ss'),'" + dt.Rows[i]["RKTYPE"].ToString() + "',SUBSTR( '" + dt.Rows[i]["RKRY"].ToString() + "',0,5), TO_DATE('" + dt.Rows[i]["WEIGHTRQ"].ToString() + "', 'YYYY-MM-DD HH24:MI:SS'), TO_DATE(REPLACE('" + dt.Rows[i]["PRODUCEDATA"].ToString() + "', '.', '-'), 'YYYY-MM-DD HH24:MI:SS'),'" + strFree1 + "','" + strFree2 + "','" + dt.Rows[i]["VFREE3"].ToString() + "','" + dt.Rows[i]["SCBB"].ToString() + "','" + dt.Rows[i]["SCX"].ToString() + "','" + dt.Rows[i]["VFREE0"].ToString() + "','" + staid + "','E','','" + strDesignNo + "',TO_DATE('" + dt.Rows[i]["WEIGHTRQ"].ToString() + "', 'YYYY-MM-DD HH24:MI:SS'),'Y','Y','Y', TO_DATE(REPLACE('" + dt.Rows[i]["PRODUCEDATA"].ToString() + "', '.', '-'), 'YYYY-MM-DD HH24:MI:SS'), '" + dt.Rows[i]["SX"].ToString() + "','" + strarea + "','" + dt.Rows[i]["PCInfo"].ToString() + "',1)";
                        int a = DbHelperOra.ExecuteSql(InsertSql);
                        iInsert = iInsert + 1;
                    }
                    strResult = "数据已同步：\r\n更新成功：" + iUpdate.ToString() + "\r\n更新失败：" + iUpdateE.ToString() + "\r\n新增成功：" + iInsert.ToString() + "\r\n新增失败：" + iInsertE.ToString();
                }
                else
                {
                    strResult = "没有查到需要同步的库存信息！";

                }
                return strResult;
            }
            catch (Exception ex)
            {

                string name = "Dal_Interface_FR.TbKCList";
                string LogSql = "INSERT INTO TI_RF_LOG(C_TYPE, C_LOG, C_NAME) VALUES('同步条码库存信息','" + ex.ToString() + "','" + name + "')";
                DbHelperOra.ExecuteSql(LogSql);
                return "代码错误！";
            }
        }
        public int DelTM()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("DELETE TRC_ROLL_PRODUCT_TM");

            object obj = DbHelperOra.ExecuteSql(strSql.ToString());

            return Convert.ToInt32(obj);
        }
        /// <summary>
        ///同步条码库存信息
        /// </summary>
        /// <param name="Barcode">钢卷唯一码</param>
        /// <param name="CK">仓库</param>
        /// <param name="HW">货位</param>
        /// <param name="WGDH">完工单号</param>
        /// <param name="PH">批号</param>
        /// <param name="GH">钩号</param>
        /// <param name="GZ">钢种</param>
        /// <returns>同步结果</returns>
        public string TbPCIList()
        {
            string strResult = "";//同步结果
            int iUpdate = 0;//更新成功记录数
            int iUpdateE = 0;//更新失败记录数
            int iInsert = 0;//插入成功记录数
            int iInsertE = 0;//插入失败记录数
            DataTable dt = GetKCList("", "", "", "", "", "", "").Tables[0];
            string strDesignNo = "";
            try
            {
                DelTM();
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        string strFree1 = dt.Rows[i]["VFREE1"].ToString();
                        string strFree2 = dt.Rows[i]["VFREE2"].ToString();
                        strFree1 = strFree1.Replace(" ", "");
                        strFree2 = strFree2.Replace(" ", "");
                        strFree1 = strFree1.Replace("（", "");
                        strFree2 = strFree2.Replace("（", "");
                        strFree1 = strFree1.Replace("）", "");
                        strFree2 = strFree2.Replace("）", "");
                        string spec = dt.Rows[i]["GG"].ToString().Replace("mm", "");
                        string strStdCode = dalTbStdConfig.Get_Std_Code(strFree1, strFree2);//获取质量等级
                        string strarea = dt.Rows[i]["HW"].ToString();
                        string batch = dt.Rows[i]["PCH"].ToString().Substring(1, 1);
                        string staid = GetSTA(batch);
                        if (strarea.Length > 4)
                        {
                            strarea = strarea.Substring(0, 5);
                        }
                        if (strStdCode != "")
                        {
                            strDesignNo = Get_Design_No(strStdCode, dt.Rows[i]["PH"].ToString());
                        }
                        //查询订单
                        string InsertSql = "INSERT INTO TRC_ROLL_PRODUCT_TM (C_ID,C_BARCODE, C_TRC_ROLL_MAIN_ID, C_LINEWH_CODE, C_LINEWH_LOC_CODE, C_BATCH_NO, C_MAT_CODE, C_MAT_DESC, C_JUDGE_LEV_ZH,C_REASON_NAME, C_STL_GRD, C_SPEC, C_DP_GROUP, C_TICK_NO, N_WGT, C_STD_CODE, D_RKRQ, C_MOVE_DESC, C_RKRY, D_WEIGHT_DT, D_MOD_DT, C_ZYX1, C_ZYX2, C_BZYQ, C_GROUP, C_PLANT_ID,  C_STOVE ,C_STA_ID,C_MOVE_TYPE,C_ORDER_NO,C_DESIGN_NO,D_DP_DT,C_IS_QR,C_IS_TB,C_IS_PD,D_PRODUCE_DATE,C_JUDGE_LEV_BP,C_LINEWH_AREA_CODE,C_SALE_AREA) VALUES ('" + dt.Rows[i]["BARCODE"].ToString() + "','" + dt.Rows[i]["BARCODE"].ToString() + "','" + dt.Rows[i]["WGDH"].ToString() + "','" + dt.Rows[i]["CK"].ToString() + "','" + dt.Rows[i]["HW"].ToString() + "','" + dt.Rows[i]["PCH"].ToString() + "','" + dt.Rows[i]["WLH"].ToString() + "','" + dt.Rows[i]["WLMC"].ToString() + "','" + dt.Rows[i]["SX"].ToString() + "','" + dt.Rows[i]["ERRSEASON"].ToString() + "','" + dt.Rows[i]["PH"].ToString() + "','" + spec + "','" + dt.Rows[i]["RKBB"].ToString() + "','" + dt.Rows[i]["GH"].ToString() + "','" + dt.Rows[i]["ZL"].ToString() + "','" + strStdCode + "',to_date( '" + dt.Rows[i]["RQ"].ToString() + "','yyyy-mm-dd hh24:mi:ss'),'" + dt.Rows[i]["RKTYPE"].ToString() + "',SUBSTR( '" + dt.Rows[i]["RKRY"].ToString() + "',0,5), TO_DATE('" + dt.Rows[i]["WEIGHTRQ"].ToString() + "', 'YYYY-MM-DD HH24:MI:SS'), TO_DATE(REPLACE('" + dt.Rows[i]["PRODUCEDATA"].ToString() + "', '.', '-'), 'YYYY-MM-DD HH24:MI:SS'),'" + strFree1 + "','" + strFree2 + "','" + dt.Rows[i]["VFREE3"].ToString() + "','" + dt.Rows[i]["SCBB"].ToString() + "','" + dt.Rows[i]["SCX"].ToString() + "','" + dt.Rows[i]["VFREE0"].ToString() + "','" + staid + "','E','','" + strDesignNo + "',TO_DATE('" + dt.Rows[i]["WEIGHTRQ"].ToString() + "', 'YYYY-MM-DD HH24:MI:SS'),'Y','Y','Y', TO_DATE(REPLACE('" + dt.Rows[i]["PRODUCEDATA"].ToString() + "', '.', '-'), 'YYYY-MM-DD HH24:MI:SS'), '" + dt.Rows[i]["SX"].ToString() + "','" + strarea + "','" + dt.Rows[i]["PCInfo"].ToString() + "')";
                        int a = DbHelperOra.ExecuteSql(InsertSql);
                        iInsert = iInsert + 1;
                    }
                    strResult = "数据已同步：\r\n更新成功：" + iUpdate.ToString() + "\r\n更新失败：" + iUpdateE.ToString() + "\r\n新增成功：" + iInsert.ToString() + "\r\n新增失败：" + iInsertE.ToString();
                }
                else
                {
                    strResult = "没有查到需要同步的库存信息！";

                }
                return strResult;
            }
            catch (Exception ex)
            {

                string name = "Dal_Interface_FR.TbKCList";
                string LogSql = "INSERT INTO TI_RF_LOG(C_TYPE, C_LOG, C_NAME) VALUES('同步条码库存信息','" + ex.ToString() + "','" + name + "')";
                DbHelperOra.ExecuteSql(LogSql);
                return "代码错误！";
            }
        }
        /// <summary>
        ///同步条码库存信息
        /// </summary>
        public string TbWWList()
        {
            string strResult = "";//同步结果

            DataTable dt = GetWWKCList().Tables[0];
            string strDesignNo = "";
            try
            {
                if (dt.Rows.Count > 0)
                {
                    int count = 0;
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        string strFree1 = dt.Rows[i]["VFREE1"].ToString();
                        string strFree2 = dt.Rows[i]["VFREE2"].ToString();
                        string spec = dt.Rows[i]["INVSPEC"].ToString().Replace("mm", "");
                        string bz = strFree1.Split('~')[1].Contains("协议") ? strFree2.Split('~')[1].Replace(" ", "").Replace("（", "(").Replace("）", ")") : strFree1.Split('~')[1].Replace(" ", "").Replace("（", "(").Replace("）", ")");
                        string batch = dt.Rows[i]["批次号"].ToString();
                        string staid = GetSTA(batch);
                        if (bz != "")
                        {
                            strDesignNo = Get_Design_No(bz, dt.Rows[i]["INVTYPE"].ToString());
                        }
                        decimal sl = Convert.ToDecimal(dt.Rows[i]["辅数量"]);
                        decimal szl = Convert.ToDecimal(dt.Rows[i]["数量"]);
                        decimal zl = Math.Round(szl / sl, 6);
                        for (int a = 1; a < sl + 1; a++)
                        {
                            if (count == 31)
                            {

                            }
                            string sql = "select MAX(to_number(C_TICK_NO)) FROM TRC_ROLL_PRODCUT WHERE C_BATCH_NO='" + batch + "'";
                            var obj = DbHelperOra.GetSingle(sql);
                            int gh = a;
                            if (obj != null)
                            {
                                string bar = obj.ToString();
                                if (bar.ToString() != "")
                                {
                                    gh = Convert.ToInt32(obj) + 1;
                                }
                            }
                            string ph = batch + "000" + gh;
                            if (gh < 10)
                            {
                                ph = batch + "0000" + gh;
                            }
                            //查询订单
                            string InsertSql = "INSERT INTO TRC_ROLL_PRODCUT  (C_ID,C_BARCODE, C_LINEWH_CODE, C_BATCH_NO, C_MAT_CODE, C_MAT_DESC, C_JUDGE_LEV_ZH,C_REASON_NAME, C_STL_GRD, C_SPEC, C_TICK_NO, N_WGT, C_STD_CODE, C_ZYX1, C_ZYX2, C_BZYQ,  C_STOVE ,C_MOVE_TYPE,C_DESIGN_NO,C_IS_QR,C_IS_TB,C_IS_PD) VALUES ('" + ph + "','" + ph + "','" + dt.Rows[i]["STORCODE"].ToString() + "','" + batch + "','" + dt.Rows[i]["INVCODE"].ToString() + "','" + dt.Rows[i]["INVNAME"].ToString() + "','" + dt.Rows[i]["CCHECKSTATENAME"].ToString() + "','','" + dt.Rows[i]["INVTYPE"].ToString() + "','" + spec + "','" + gh + "','" + zl + "','" + bz + "','" + strFree1 + "','" + strFree2 + "','" + dt.Rows[i]["VFREE3"].ToString() + "','" + dt.Rows[i]["连铸炉号"].ToString() + "','E','" + strDesignNo + "','Y','Y','Y')";
                            DbHelperOra.ExecuteSql(InsertSql);
                            count++;
                        }
                    }
                    strResult = "1";
                }
                else
                {
                    strResult = "没有查到需要同步的库存信息！";

                }
                return strResult;
            }
            catch (Exception ex)
            {

                string name = "Dal_Interface_FR.TbKCList";
                string LogSql = "INSERT INTO TI_RF_LOG(C_TYPE, C_LOG, C_NAME) VALUES('同步条码库存信息','" + ex.ToString() + "','" + name + "')";
                DbHelperOra.ExecuteSql(LogSql);
                return "代码错误！";
            }
        }
        #endregion

        #region 同步条码出库信息

        /// 获取条码库存信息
        /// </summary>
        /// <param name="CK">仓库</param>
        /// <param name="HW">货位</param>
        /// <param name="FYDH">发运单号</param>
        /// <param name="RKDH">入库单号</param>
        /// <param name="CKDH">出库单号</param>
        /// <param name="PH">批号</param>
        /// <param name="GH">钩号</param>
        /// <param name="GZ">钢种</param>
        /// <returns>条码库存信息</returns>
        public DataSet GetList(string CK, string HW, string FYDH, string RKDH, string CKDH, string PH, string GH, string GZ)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ");
            strSql.Append(" Barcode,RKDH,FYDH,CKDH,CK,HW,PCH,WLH,WLMC,SX,ZLDJ,PH,GG,BB,GH,ZL,BZ,RQ,Flag,CKRY,CXH,KHBM,WeightRQ,CKCXH,ProduceData,Filed1,PCInfo,Filed2,ErrSeason,vfree0,vfree1,vfree2,vfree3,vfree4,ysmz  ");
            strSql.Append(" FROM WMS_Bms_Inv_OutInfo where 1=1 ");
            if (CK.Trim() != "")
            {
                strSql.Append(" and  CK='" + CK + "' ");
            }
            if (HW.Trim() != "")
            {
                strSql.Append(" and  HW='" + HW + "' ");
            }
            if (FYDH.Trim() != "")
            {
                strSql.Append(" and  FYDH='" + FYDH + "' ");
            }
            if (RKDH.Trim() != "")
            {
                strSql.Append(" and  RKDH='" + RKDH + "' ");
            }
            if (CKDH.Trim() != "")
            {
                strSql.Append(" and  CKDH='" + CKDH + "' ");
            }
            if (PH.Trim() != "")
            {
                strSql.Append(" and  PCH='" + PH + "' ");
            }

            if (GH.Trim() != "")
            {
                strSql.Append(" and  GH='" + GH + "' ");
            }

            if (GZ.Trim() != "")
            {
                strSql.Append(" and  PH='" + GZ + "' ");
            }
            strSql.Append(" order by  Barcode ");
            return DbHelper_SQL.Query(strSql.ToString());
        }

        /// 获取条码库存信息
        /// </summary> 
        /// <param name="PH">批号</param> 
        /// <param name="GH">勾号</param> 
        public DataSet Get_TM_XL_List(string PCH,string GH)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" SELECT Barcode ,WGDH,CK,HW,PCH,WLH,WLMC,SX,ZLDJ,PH,GG,BB,GH,ZL,BZ,RQ,RKType,RKRY,WeightRQ,CKCXH,ProduceData,PCInfo,Filed1,ErrSeason,Filed2,vfree0,vfree1,vfree2,vfree3,vfree4 ");
            strSql.Append(" FROM WMS_Bms_Inv_Info where PCH = '" + PCH + "' AND GH='"+ GH + "'");
             
            return DbHelper_SQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取条码库存信息
        /// </summary>
        /// <param name="CK">仓库</param>
        /// <param name="HW">货位</param>
        /// <param name="FYDH">发运单号</param>
        /// <param name="RKDH">入库单号</param>
        /// <param name="CKDH">出库单号</param>
        /// <param name="PH">批号</param>
        /// <param name="GH">钩号</param>
        /// <param name="GZ">钢种</param>
        /// <returns>条码库存信息</returns>
        public string TbRFCK(string CK, string HW, string FYDH, string RKDH, string CKDH, string PH, string GH, string GZ)
        {
            string strResult = "";//同步结果
            int iUpdate = 0;//更新成功记录数
            int iUpdateE = 0;//更新失败记录数
            int iInsert = 0;//插入成功记录数
            int iInsertE = 0;//插入失败记录数
            //同步出库信息
            DataTable dt2 = GetList(CK, HW, FYDH, RKDH, CKDH, PH, GH, GZ).Tables[0];
            if (dt2.Rows.Count > 0)
            {
                for (int i = 0; i < dt2.Rows.Count; i++)
                {
                    // Mod_TRC_ROLL_PRODCUT mod = bll_pci_kc.GetModel(dt2.Rows[i]["PCH"].ToString(), dt2.Rows[i]["GH"].ToString());//判断是否存在
                    if (Exists(dt2.Rows[i]["PCH"].ToString(), dt2.Rows[i]["GH"].ToString()))//当前库已经存在该卷
                    {

                        try
                        {
                            string updateSql = " UPDATE TRC_ROLL_PRODCUT T SET ";
                            //updateSql = updateSql + " C_BATCH_NO = '" + dt2.Rows[i]["PCH"].ToString() + "'";
                            //updateSql = updateSql + " C_TICK_NO =  '" + dt2.Rows[i]["GH"].ToString() + "'";
                            updateSql = updateSql + " C_STL_GRD =  '" + dt2.Rows[i]["PH"].ToString() + "'";
                            updateSql = updateSql + " ,N_WGT = Convert.ToDecimal( '" + dt2.Rows[i]["ZL"].ToString() + "')";
                            updateSql = updateSql + " ,C_MOVE_TYPE = 'S'";
                            updateSql = updateSql + " ,C_SPEC =  '" + dt2.Rows[i]["GG"].ToString() + "'";
                            updateSql = updateSql + " ,C_DP_SHIFT =  '" + dt2.Rows[i]["BB"].ToString() + "'";
                            updateSql = updateSql + " ,D_DP_DT = Convert.ToDateTime( '" + dt2.Rows[i]["WeightRQ"].ToString() + "')";
                            updateSql = updateSql + " ,C_MAT_CODE =  '" + dt2.Rows[i]["WLH"].ToString() + "'";
                            updateSql = updateSql + " ,C_MAT_DESC =  '" + dt2.Rows[i]["WLMC"].ToString() + "'";
                            updateSql = updateSql + " ,C_LINEWH_CODE =  '" + dt2.Rows[i]["CK"].ToString() + "'";
                            updateSql = updateSql + " ,C_LINEWH_LOC_CODE =  '" + dt2.Rows[i]["HW"].ToString() + "'";
                            updateSql = updateSql + " ,C_SALE_AREA =  '" + dt2.Rows[i]["PCInfo"].ToString() + "'";
                            updateSql = updateSql + " ,C_JUDGE_LEV_ZH =  '" + dt2.Rows[i]["SX"].ToString() + "'";
                            updateSql = updateSql + " ,C_BARCODE =  '" + dt2.Rows[i]["Barcode"].ToString() + "'";
                            // mod.C_RKDH = dt1.Rows[i]["RKDH"].ToString();
                            updateSql = updateSql + " ,C_FYDH =  '" + dt2.Rows[i]["FYDH"].ToString() + "'";
                            updateSql = updateSql + " ,C_CKDH =  '" + dt2.Rows[i]["CKDH"].ToString() + "'";
                            updateSql = updateSql + " ,C_MOVE_DESC =  '" + dt2.Rows[i]["Flag"].ToString() + "'";

                            updateSql = updateSql + " ,C_CKRY = SUBSTR( '" + dt2.Rows[i]["CKRY"].ToString().Trim() + "',0,5)";
                            updateSql = updateSql + " ,D_CKRQ = Convert.ToDateTime( '" + dt2.Rows[i]["RQ"].ToString() + "')";
                            updateSql = updateSql + " ,_BZYQ =  '" + dt2.Rows[i]["vfree3"].ToString() + "'";
                            updateSql = updateSql + " D_MOD_DT = Convert.ToDateTime( '" + dt2.Rows[i]["ProduceData"].ToString().Replace(".", "- ") + "')";
                            updateSql = updateSql + "  WHERE  C_BATCH_NO = '" + dt2.Rows[i]["PCH"].ToString() + "' AND C_TICK_NO =  '" + dt2.Rows[i]["GH"].ToString() + "' ";
                            int res = DbHelperOra.ExecuteSql(updateSql);
                            iUpdate = iUpdate + 1;

                        }
                        catch (Exception ex)
                        {
                            string name = "Dal_Interface_FR.TbRFCK:PH=" + dt2.Rows[i]["PCH"].ToString() + ",  GH=" + dt2.Rows[i]["GH"].ToString() + "";
                            string LogSql = "INSERT INTO TI_RF_LOG(C_TYPE, C_LOG, C_NAME) VALUES('同步条码库存信息','" + ex.ToString() + "','" + name + "')";
                            iUpdateE = iUpdateE + 1;

                        }
                    }
                    else//插入
                    {
                        try
                        {
                            string DD = "";
                            string insertSql = " INSERT INTO TRC_ROLL_PRODCUT ( C_ID ,C_BATCH_NO,C_TICK_NO,C_STL_GRD,N_WGT,C_MOVE_TYPE,C_SPEC,C_DP_SHIFT,D_DP_DT,C_MAT_CODE,C_MAT_DESC,C_LINEWH_CODE,C_LINEWH_LOC_CODE,C_SALE_AREA,C_JUDGE_LEV_ZH,C_BARCODE,C_RKDH,C_FYDH,C_CKDH,C_MOVE_DESC,C_CKRY,D_CKRQ,C_BZYQ,D_MOD_DT) VALUES ('" + dt2.Rows[i]["Barcode"].ToString() + "','" + dt2.Rows[i]["PCH"].ToString() + "','" + dt2.Rows[i]["GH"].ToString() + "','" + dt2.Rows[i]["PH"].ToString() + "'," + Convert.ToDecimal(dt2.Rows[i]["ZL"].ToString()) + ",'S','" + dt2.Rows[i]["GG"].ToString() + "','" + dt2.Rows[i]["BB"].ToString() + "',TO_DATE('" + dt2.Rows[i]["WeightRQ"].ToString() + "','yyyy-mm-dd hh24:mi:ss'),'" + dt2.Rows[i]["WLH"].ToString() + "','" + dt2.Rows[i]["WLMC"].ToString() + "','" + dt2.Rows[i]["CK"].ToString() + "','" + dt2.Rows[i]["HW"].ToString() + "','" + dt2.Rows[i]["PCInfo"].ToString() + "','" + dt2.Rows[i]["SX"].ToString() + "','" + dt2.Rows[i]["Barcode"].ToString() + "','" + dt2.Rows[i]["RKDH"].ToString() + "','" + dt2.Rows[i]["FYDH"].ToString() + "','" + dt2.Rows[i]["CKDH"].ToString() + "','" + dt2.Rows[i]["Flag"].ToString() + "',SUBSTR('" + dt2.Rows[i]["CKRY"].ToString() + "',0,5),TO_DATE('" + dt2.Rows[i]["RQ"].ToString() + "','yyyy-mm-dd hh24:mi:ss'),'" + dt2.Rows[i]["vfree3"].ToString() + "',to_date('" + dt2.Rows[i]["ProduceData"].ToString().Replace(".", "-") + "','yyyy-mm-dd hh24:mi:ss'))";
                            int res = DbHelperOra.ExecuteSql(insertSql);
                            iInsert = iInsert + 1;
                        }
                        catch (Exception ex)
                        {
                            string name = "Dal_Interface_FR.TbRFCK:PH=" + dt2.Rows[i]["PCH"].ToString() + ",  GH=" + dt2.Rows[i]["GH"].ToString() + "";
                            string LogSql = "INSERT INTO TI_RF_LOG(C_TYPE, C_LOG, C_NAME) VALUES('同步条码库存信息','" + ex.ToString() + "','" + name + "')";
                            iInsertE = iInsertE + 1;

                        }
                    }

                    strResult = "数据已同步：\r\n更新成功：" + iUpdate.ToString() + "\r\n更新失败：" + iUpdateE.ToString() + "\r\n新增成功：" + iInsert.ToString() + "\r\n新增失败：" + iInsertE.ToString();
                }
            }
            else
            {
                strResult = "没有查到需要同步的库存信息！";
            }
            return strResult;
        }
        #endregion



        #region 向条码系统发送完工单信息
        /// <summary>
        /// 向条码系统发送完工单信息
        /// </summary>
        /// <param name="model"></param>
        /// <param name="modelItem"></param>
        /// <returns></returns>
        public int SENDWGD(Mod_TRC_ROLL_WGD model)
        {
            string fzdw = dal_matra.GetModel(model.C_MAT_CODE).C_FJLDWMC;//辅计量单位
            string sql = @"INSERT ReZJB_WGD (
                                     wgdh,
                    				 pch,
                    				 ph,
                    				 gg,
                    				 bb,
                    				 wlh,
                    				 wlmc,
                    				 fzdw,
                    				 zxbz,
                    				 SCX,
                    				 zyx1,
                    				 zyx2,
                    				 zyx3,
                    				 gpmainmeasrate,
                    				 ZJBstatus,
                    				 CAPPK,
                    				 Filed1,
                    				 pcsx,
                    				 zpdjbz,
                                     producedate,
                    				 vfree0,
                    				 pclx,
                                     insertts
                    				 )
                                     values
                                     (   ";
            sql += "'" + model.C_MAIN_ID + "',";
            sql += "'" + model.C_BATCH_NO + "',";
            sql += "'" + model.C_STL_GRD + "',";
            sql += "'" + model.C_SPEC + "',";
            sql += "'" + model.C_PRODUCE_GROUP_NAME + "',";
            sql += "'" + model.C_MAT_CODE + "',";
            sql += "'" + model.C_MAT_DESC + "',";
            sql += "'" + fzdw + "',";
            sql += "'" + model.C_STD_CODE + "',";

            sql += "'" + dal_TB_STA.GetModel(model.C_STA_ID).C_SSBMID + "',";
            sql += "'" + model.C_FREE_TERM + "',";
            sql += "'" + model.C_FREE_TERM2 + "',";
            sql += "'" + model.C_PACK + "',";
            sql += "'" + model.N_WGT_PRODUCE + "',";
            sql += "0 ,";
            sql += "'" + model.C_ID + "',";
            sql += "'" + model.C_SX + "',";
            sql += "'" + model.C_MRSX + "',";
            sql += "'" + model.C_ZPDJBZ + "',";
            sql += "'" + model.D_PRODUCE_DATE + "',";
            sql += "'" + model.C_STOVE + "',";
            sql += "'" + model.C_PCLX + "',";
            sql += "'" + DateTime.Now + "'";
            sql += "   )  ";

            return DbHelper_SQL.ExecuteSql(sql);
        }

        /// <summary>
        /// 向条码系统发送完工单信息
        /// </summary>
        /// <param name="model"></param>
        /// <param name="modelItem"></param>
        /// <returns></returns>
        public int SENDWGDITEM(List<Mod_TRC_ROLL_WGD_ITEM> modelItems, Mod_TRC_ROLL_WGD model)
        {
            int count = 0;
            foreach (var item in modelItems)
            {
                string sql = @"INSERT ReZJB_WGD_Item
                                    (wgdh,
                                     pch,
                                     ph,
                                     gg,
                                     wlh,
                                     wlmc,
                                     zyx1,
                                     zyx2,
                                     zyx3,
                                     ZJBstatus,
                                     CAPPK,
                                     zpbxbz,
                                     sx,
                                     zxbz,
                                     insertts
                                     )
                                     values
                                     (   ";

                sql += "'" + item.C_MAIN_ID + "',";
                sql += "'" + item.C_BATCH_NO + "',";
                sql += "'" + item.C_STL_GRD + "',";
                sql += "'" + item.C_SPEC + "',";
                sql += "'" + item.C_MAT_CODE + "',";
                sql += "'" + item.C_MAT_DESC + "',";
                sql += "'" + item.C_ZYX1 + "',";
                sql += "'" + item.C_ZYX2 + "',";
                sql += "'" + item.C_BZYQ + "',";
                sql += "0 ,";
                sql += "'" + item.C_ID + "',";
                sql += "'" + item.N_STATUS + "',";
                sql += "'" + model.C_SX + "',";
                sql += "'" + item.C_STD_CODE + "',";
                sql += "'" + DateTime.Now + "'";
                sql += "   )  ";
                DbHelper_SQL.ExecuteSql(sql);
                count++;
            }
            return count;
        }
        /// <summary>
        /// 获取条码库存信息
        /// </summary> 
        /// <param name="PH">批号</param> 
        public DataSet Get_XL_List(string Barcode, string CK, string HW, string WGDH, string PH, string GH, string GZ)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT T1.BARCODE, T1.WGDH, T1.CK, T1.HW, T1.PCH, T1.WLH, T1.WLMC, T1.SX, T1.PH, T1.GG, T1.BB AS RKBB, T1.GH, T1.ZL, T1.BZ, T1.RQ, T1.RKTYPE, T1.RKRY, T1.WEIGHTRQ, T1.PRODUCEDATA, T1.VFREE1, T1.VFREE2, T1.VFREE3,T1.ERRSEASON,T1.PCInfo, T2.BB AS SCBB, T2.SCX, T2.ZXBZ, T2.VFREE0 ");

            strSql.Append(" FROM WMS_BMS_INV_INFO T1 JOIN WMS_BMS_REC_WGD T2 ON T1.WGDH = T2.WGDH  ");
            if (Barcode.Trim() != "")
            {
                strSql.Append(" and  T1.Barcode='" + Barcode + "' ");
            }
            if (CK.Trim() != "")
            {
                strSql.Append(" and  T1.CK='" + CK + "' ");
            }
            if (HW.Trim() != "")
            {
                strSql.Append(" and  T1.HW='" + HW + "' ");
            }
            if (WGDH.Trim() != "")
            {
                strSql.Append(" and  T1.WGDH='" + WGDH + "' ");
            }
            if (PH.Trim() != "")
            {
                strSql.Append(" and  T1.PCH='" + PH + "' ");
            }
            if (GH.Trim() != "")
            {
                strSql.Append(" and  T1.GH='" + GH + "' ");
            }
            if (GZ.Trim() != "")
            {
                strSql.Append(" and  T1.PH='" + GZ + "' ");
            }
            strSql.Append(" ORDER BY T1.RQ,T1.Barcode ");
            return DbHelper_SQL.Query(strSql.ToString());
        }


        #endregion

        #region 实绩日志表
        /// <summary>
        /// 根据单号获取线材实绩日志
        /// </summary>
        /// <param name="DH">单号</param>
        /// <param name="status">状态</param>
        /// <returns></returns>
        public DataSet GetYWDXQ(string DH, string status, string id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_DH,C_STOVE,C_BATCH_NO,C_TICK_NO,C_STL_GRD,N_WGT,C_STD_CODE,C_SPEC,C_LINEWH_CODE,C_LINEWH_AREA_CODE,C_LINEWH_LOC_CODE,C_YLINEWH_CODE,C_YLINEWH_AREA_CODE,C_YLINEWH_LOC_CODE,C_JUDGE_LEV_ZH,C_MAT_CODE,C_MAT_DESC,C_BARCODE");
            strSql.Append(" FROM TRC_ROLLCZ_LOG WHERE N_TYPE='" + status + "'");
            if (DH.Trim() != "")
            {
                strSql.Append(" AND C_DH='" + DH + "' ");
            }
            if (id.Trim() != "")
            {
                strSql.Append(" AND C_REMARK='" + id + "' ");
            }
            strSql.Append(" ORDER BY  C_DH,C_STOVE,C_BATCH_NO,C_TICK_NO ");
            return DbHelperOra.Query(strSql.ToString());
        }

        #endregion
        #region 发运单

        /// <summary>
        ///根据发运单号获取条码中间表数据
        /// </summary>
        /// <param name="C_FYDH">发运单号</param>
        /// <returns></returns>
        public DataSet GetTMFYD(string C_FYDH)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select pk_SeZJB_FYD_finished,fydh,case ZJBstatus when '0' then '未同步' when '1' then '同步成功'when '2' then '同步异常'end ZJBstatus ,by1,insertts,updatets ");
            strSql.Append(" FROM SeZJB_FYD_finished WHERE 1=1");
            if (C_FYDH.Trim() != "")
            {
                strSql.Append(" AND fydh='" + C_FYDH + "' ");
            }
            strSql.Append(" ORDER BY  fydh,pk_SeZJB_FYD_finished ");
            return TransactionHelper_SQL.Query(strSql.ToString());
        }
        /// <summary>
        /// 查询条码返回中间表未接收成功的发运单号
        /// </summary>
        /// <returns>DataSet</returns>
        public DataSet QueryFYD()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT fydh,pk_SeZJB_FYD_finished,insertts FROM SeZJB_FYD_finished  WHERE ZJBstatus!=1");
            return DbHelper_SQL.Query(strSql.ToString());
        }
        /// <summary>
        /// 根发运单号判断PCI是否存在此发运单
        /// </summary>
        /// <param name="FYD">发运单</param>
        /// <returns>是否存在</returns>
        public bool ExistsByFYD(string FYD)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TMD_DISPATCH ");
            strSql.Append(" where C_ID='" + FYD + "'");
            return DbHelperOra.Exists(strSql.ToString());
        }

        /// <summary>
        /// 更新条码发运单实绩中间表
        /// </summary>
        /// <param name="id">id</param>
        /// <returns></returns>
        public int UPFYDBZ(string id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("UPDATE SeZJB_FYD_finished SET");
            strSql.Append(" by1='已撤回！',updatets='" + RV.UI.ServerTime.timeNow() + "'");
            strSql.Append("  where   pk_SeZJB_FYD_finished='" + id + "'  ");
            return DbHelper_SQL.ExecuteSql(strSql.ToString());
        }
        /// <summary>
        /// 更新发运单表
        /// </summary>
        /// <param name="dhstr">移位单号</param>
        /// <returns></returns>
        public int UPFYDSTATUS(string dhstr, string status, string by1, string id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("UPDATE SeZJB_FYD_finished SET");
            strSql.Append(" ZJBstatus='" + status + "',by1='" + by1 + "',by2='',updatets='" + RV.UI.ServerTime.timeNow() + "'");
            strSql.Append("  where fydh='" + dhstr + "' AND pk_SeZJB_FYD_finished='" + id + "'  ");
            return DbHelper_SQL.ExecuteSql(strSql.ToString());
        }
        /// <summary>
        /// 更新发运单状态
        /// </summary>
        /// <param name="dhstr">发运单号</param>
        /// <returns></returns>
        public int UPFYDSTATUS(string dhstr, string status)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("UPDATE TMD_DISPATCH SET");
            strSql.Append(" C_STATUS='" + status + "'");
            strSql.Append(" WHERE C_ID ='" + dhstr + "'");

            return TransactionHelper.ExecuteSql(strSql.ToString());
        }
        /// <summary>
        /// 根据发运单号更新线材实绩
        /// </summary>
        /// <param name="fydh">发运单号</param>
        /// <returns></returns>
        public int UPRPByFYDH(string fydh)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("UPDATE TRC_ROLL_PRODCUT SET");
            strSql.Append(" C_MOVE_TYPE='E',C_ZKD_NO='',C_FYDH='',C_QTCKD_NO=''");
            strSql.Append("  where C_FYDH='" + fydh + "' ");
            return TransactionHelper.ExecuteSql(strSql.ToString());
        }
        /// <summary>
        /// 删除发运单日志
        /// </summary>
        /// <param name="dhstr">发运单号</param>
        /// <returns></returns>
        public int DelFYDZJB(string dhstr)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("DELETE TMD_DISPATCH_SJZJB ");
            strSql.Append(" WHERE C_DISPATCH_ID='" + dhstr + "'");
            return TransactionHelper.ExecuteSql(strSql.ToString());
        }
        /// <summary>
        /// 删除发运单日志
        /// </summary>
        /// <param name="dhstr">发运单号</param>
        /// <returns></returns>
        public int UPFYD(string dhstr)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("UPDATE TRC_ROLLCZ_LOG SET C_REMARK='已撤回！'");
            strSql.Append(" WHERE C_DH='" + dhstr + "'");
            return DbHelperOra.ExecuteSql(strSql.ToString());
        }
        /// <summary>
        /// 通过单号查询条码发运详情
        /// </summary>
        /// <param name="dh">单号</param>
        /// <returns></returns>
        public DataSet QueryFYDByCK(string dh)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT Barcode,fydh FROM  WMS_Bms_Inv_OutInfo  WHERE FYDH = '" + dh + "'");
            return DbHelper_SQL.Query(strSql.ToString());
        }
        /// <summary>
        /// 根据牌号查询线材库存详情
        /// </summary>
        /// <param name="C_BARCODE"></param>
        /// <returns></returns>
        public DataSet GetXCKC(string C_BARCODE)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_BATCH_NO,C_STOVE,C_TICK_NO,C_STL_GRD,N_WGT,C_STD_CODE,C_MOVE_TYPE,C_SPEC,C_MAT_CODE,C_MAT_DESC,C_LINEWH_CODE,C_LINEWH_AREA_CODE,C_LINEWH_LOC_CODE,nvl(C_JUDGE_LEV_ZH,C_JUDGE_LEV_BP)AS C_JUDGE_LEV_ZH,C_BZYQ,C_ZYX1,C_ZYX2,C_ZKD_NO,C_QTCKD_NO ");
            strSql.Append(" FROM TRC_ROLL_PRODCUT where 1=1 ");
            if (C_BARCODE.Trim() != "")
            {
                strSql.Append(" and C_BARCODE ='" + C_BARCODE + "' ");
            }
            strSql.Append(" ORDER BY  C_BATCH_NO,C_STOVE,C_TICK_NO");
            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 根据牌号获取状态
        /// </summary>
        /// <param name="dh">牌号</param>
        /// <returns></returns>
        public string GetMOVETYPE(string Barcode)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT C_MOVE_TYPE FROM TRC_ROLL_PRODCUT ");
            strSql.Append("  where C_BARCODE='" + Barcode + "' ");
            DataTable dt = DbHelperOra.Query(strSql.ToString()).Tables[0];
            if (dt.Rows.Count > 0)
            {
                return dt.Rows[0]["C_MOVE_TYPE"].ToString();
            }
            else
            {
                return "";
            }
        }
        /// <summary>
        /// 根据发运单item修改线材实绩
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        private static StringBuilder UPFYD(DataRow item)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("UPDATE TRC_ROLL_PRODCUT SET");
            strSql.Append(" C_MOVE_TYPE = 'S', C_FYDH='" + item["fydh"] + "',C_ZKD_NO='',C_QTCKD_NO=''");
            strSql.Append("  where C_BARCODE='" + item["Barcode"] + "' ");
            return strSql;
        }
        /// <summary>
        /// 通过单号查询条码发运实绩详情
        /// </summary>
        /// <param name="dh">单号</param>
        /// <returns></returns>
        public DataSet GetFYSJList(string dh, string C_MAT_CODE, string C_LINEWH_CODE, string C_JUDGE_LEV_ZH, string C_BZYQ)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT N_WGT,C_BARCODE, C_BATCH_NO,C_MAT_CODE,C_MAT_DESC,C_SPEC,C_STL_GRD,C_STD_CODE,C_LINEWH_CODE,nvl(C_JUDGE_LEV_ZH,C_JUDGE_LEV_BP)C_JUDGE_LEV_ZH,C_BZYQ,C_TICK_NO from TRC_ROLL_PRODCUT WHERE C_MOVE_TYPE='S' AND nvl(C_FRFLAG,0)=0 ");
            if (dh.Trim() != "")
            {
                strSql.Append(" AND C_FYDH='" + dh + "'");
            }
            if (C_MAT_CODE.Trim() != "")
            {
                strSql.Append(" AND C_MAT_CODE='" + C_MAT_CODE + "'");
            }
            if (C_LINEWH_CODE.Trim() != "")
            {
                strSql.Append(" AND C_LINEWH_CODE='" + C_LINEWH_CODE + "'");
            }
            if (C_JUDGE_LEV_ZH.Trim() != "")
            {
                strSql.Append(" AND C_JUDGE_LEV_ZH='" + C_JUDGE_LEV_ZH + "'");
            }
            if (C_BZYQ.Trim() != "")
            {
                strSql.Append(" AND C_BZYQ='" + C_BZYQ + "'");
            }
            strSql.Append(" ORDER BY C_BATCH_NO,to_number(C_TICK_NO)");
            return TransactionHelper.Query(strSql.ToString());
        }
        /// <summary>
        /// 通过单号查询条码发运实绩详情
        /// </summary>
        /// <param name="dh">单号</param>ss
        /// <returns></returns>
        public DataSet GetFYSJList(string C_BARCODE)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT COUNT(1) N_NUM,SUM(N_WGT) N_WGT, C_BATCH_NO,C_MAT_CODE,C_MAT_DESC,C_SPEC,C_STL_GRD,C_STD_CODE,C_LINEWH_CODE,nvl(C_JUDGE_LEV_ZH,C_JUDGE_LEV_BP)C_JUDGE_LEV_ZH,C_BZYQ from TRC_ROLL_PRODCUT WHERE  C_BARCODE IN(" + C_BARCODE + ") ");

            strSql.Append(" GROUP  BY C_BATCH_NO,C_MAT_CODE,C_MAT_DESC,C_SPEC,C_STL_GRD,C_STD_CODE,C_LINEWH_CODE,nvl(C_JUDGE_LEV_ZH,C_JUDGE_LEV_BP),C_BZYQ");
            return TransactionHelper.Query(strSql.ToString());
        }
        /// <summary>
        /// 根据发运单号，批号，仓库，质量等级，包装要求查询钩号
        /// </summary>
        /// <param name="dh">发运单号</param>
        /// <param name="C_BATCH_NO">批号</param>
        /// <param name="C_LINEWH_CODE">仓库</param>
        /// <param name="C_JUDGE_LEV_ZH">质量等级</param>
        /// <param name="C_BZYQ">包装要求</param>
        /// <returns></returns>
        public DataSet GetTICKList(string dh, string C_BATCH_NO, string C_LINEWH_CODE, string C_JUDGE_LEV_ZH, string C_BZYQ)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT C_TICK_NO from TRC_ROLL_PRODCUT WHERE 1=1");
            if (dh.Trim() != "")
            {
                strSql.Append(" AND C_FYDH='" + dh + "'");
            }
            if (C_BATCH_NO.Trim() != "")
            {
                strSql.Append(" AND C_BATCH_NO='" + C_BATCH_NO + "'");
            }
            if (C_LINEWH_CODE.Trim() != "")
            {
                strSql.Append(" AND C_LINEWH_CODE='" + C_LINEWH_CODE + "'");
            }
            if (C_JUDGE_LEV_ZH.Trim() != "")
            {
                strSql.Append(" AND nvl(C_JUDGE_LEV_ZH,C_JUDGE_LEV_BP)='" + C_JUDGE_LEV_ZH + "'");
            }
            if (C_BZYQ.Trim() != "")
            {
                strSql.Append(" AND C_BZYQ='" + C_BZYQ + "'");
            }
            return TransactionHelper.Query(strSql.ToString());
        }
        /// <summary>
        /// 获取最新的转库单号
        /// </summary>
        /// <param name="fydh">发运单</param>
        /// <returns></returns>
        public string GetCKDNO(string fydh)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select MAX(C_CKDH) ");
            strSql.Append(" FROM TMD_DISPATCH_SJZJB WHERE 1=1 ");
            if (fydh.Trim() != "")
            {
                strSql.Append(" AND C_CKDH LIKE 'XC" + fydh + "%' ");
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
        /// <summary>
        /// 同步发运单
        /// </summary>
        /// <param name="path">路径</param>
        /// <returns></returns>
        public string TBFYD(string path)
        {
            string LogSql = "";
            string name = "Dal_Interface_FR.TBFYD";
            int fydcount = 0;
            try
            {
                DataTable dt = QueryFYD().Tables[0];//查询条码未上传的发运单
                fydcount = dt.Rows.Count;
                if (fydcount > 0)
                {
                    foreach (DataRow item in dt.Rows)
                    {
                        string fydh = item["fydh"].ToString();
                        string id = item["pk_SeZJB_FYD_finished"].ToString();
                        string message = "";
                        if (ExistsByFYD(fydh) == false)
                        {
                            UPFYDSTATUS(fydh, "2", "PCI系统不存在发运单号" + item["fydh"].ToString(), id);
                        }
                        else
                        {
                            ///发运单号多次发送覆盖
                            if (CKFYD(fydh) > 1)
                            {
                                string lastid = GetLastFYDID(fydh, id);
                                if (lastid != "")
                                {
                                    UPFYDSTATUS(fydh, "3");
                                    UPRPByFYDH(fydh);
                                    DelFYDZJB(fydh);
                                    UPFYDBZ(lastid);
                                }
                            }
                            //传送条码
                            DataTable fydt = QueryFYDByCK(fydh).Tables[0];
                            if (fydt.Rows.Count > 0)
                            {
                                TransactionHelper.BeginTransaction();
                                foreach (DataRow xqitem in fydt.Rows)
                                {
                                    DataTable ydt = GetXCKC(xqitem["Barcode"].ToString()).Tables[0];//获取原线材状态
                                    if (ydt.Rows.Count != 1)
                                    {
                                        UPFYDSTATUS(fydh, "2", "牌号" + xqitem["Barcode"].ToString() + "PCI系统不存在！", id);
                                        TransactionHelper.RollBack();
                                        break;
                                    }

                                    string movetype = GetMOVETYPE(xqitem["Barcode"].ToString());///获取线材库存状态
                                    if (movetype != "E")
                                    {
                                        TransactionHelper.RollBack();
                                        UPFYDSTATUS(fydh, "2", "牌号" + xqitem["Barcode"].ToString() + "信息库存状态为" + movetype, id);
                                        message = "1";
                                        break;
                                    }
                                    //添加线材操作日志
                                    DataRow data = ydt.Rows[0];
                                    string sql = "insert into TRC_ROLLCZ_LOG(C_DH,C_REMARK,C_STOVE,C_BATCH_NO,C_TICK_NO,C_STL_GRD,N_WGT,C_STD_CODE,C_SPEC,C_LINEWH_CODE,C_LINEWH_AREA_CODE,C_LINEWH_LOC_CODE,C_YLINEWH_CODE,C_YLINEWH_AREA_CODE,C_YLINEWH_LOC_CODE,C_JUDGE_LEV_ZH,D_CZ_DATE,C_MAT_CODE,C_MAT_DESC,C_BARCODE,N_TYPE) values('" + fydh + "','" + id + "','" + data["C_STOVE"] + "','" + data["C_BATCH_NO"] + "','" + data["C_TICK_NO"] + "','" + data["C_STL_GRD"] + "','" + data["N_WGT"] + "','" + data["C_STD_CODE"] + "','" + data["C_SPEC"] + "','','','','" + data["C_LINEWH_CODE"] + "','" + data["C_LINEWH_AREA_CODE"] + "','" + data["C_LINEWH_LOC_CODE"] + "','" + data["C_JUDGE_LEV_ZH"] + "', to_date('" + RV.UI.ServerTime.timeNow() + "', 'yyyy-mm-dd hh24:mi:ss'),'" + data["C_MAT_CODE"] + "','" + data["C_MAT_DESC"] + "','" + xqitem["Barcode"] + "','2')";
                                    if (TransactionHelper.ExecuteSql(sql.ToString()) != 1)///添加操作记录
                                    {
                                        UPFYDSTATUS(fydh, "2", "PCI添加操作日志时错误！", id);
                                        break;
                                    }
                                    StringBuilder strSql = UPFYD(xqitem);
                                    if (TransactionHelper.ExecuteSql(strSql.ToString()) == 0)
                                    {
                                        TransactionHelper.RollBack();
                                        UPFYDSTATUS(fydh, "2", "牌号" + xqitem["Barcode"].ToString() + "变更线材实绩状态错误！", id);
                                        message = "1";
                                        break;
                                    }
                                }
                            }
                            else
                            {
                                UPFYDSTATUS(fydh, "2", "查询发运单详情错误！", id);
                                continue;
                            }
                            if (message == "1")
                            {
                                continue;
                            }
                            ///添加转库单中间表
                            string rjhsql = "SELECT C_PLAN_ID,C_ID,C_MAT_CODE,C_SEND_STOCK_CODE,c_Judge_Lev_Zh,C_PACK,N_FYZS FROM TMD_DISPATCHDETAILS WHERE C_DISPATCH_ID='" + item["fydh"].ToString() + "'";
                            DataTable plandt = TransactionHelper.Query(rjhsql).Tables[0];
                            if (plandt.Rows.Count < 1)
                            {
                                TransactionHelper.RollBack();
                                UPFYDSTATUS(fydh, "2", "发运单子表查询错误！", id);
                            }
                            foreach (DataRow planrow in plandt.Rows)
                            {
                                int plannum = Convert.ToInt32(planrow["N_FYZS"]);
                                #region 获取出库单
                                string no = RV.UI.ServerTime.timeNow().Year.ToString() + (Convert.ToInt32(RV.UI.ServerTime.timeNow().Month) > 9 ? RV.UI.ServerTime.timeNow().Month.ToString() : ("0" + RV.UI.ServerTime.timeNow().Month.ToString())) + (Convert.ToInt32(RV.UI.ServerTime.timeNow().Day) > 9 ? RV.UI.ServerTime.timeNow().Day.ToString() : ("0" + RV.UI.ServerTime.timeNow().Day.ToString()));//转库单号
                                string maxckd = GetCKDNO(no);//查询当天最大转库单
                                if (maxckd == "")
                                {
                                    no = no + "0001";
                                }
                                else
                                {
                                    no = (Convert.ToInt64(maxckd.Substring(2, maxckd.Length - 2)) + 1).ToString();
                                }
                                no = "XC" + no;
                                #endregion
                                #region 获取线材实绩
                                DataTable dt1 = GetFYSJList(fydh, planrow["C_MAT_CODE"].ToString(), planrow["C_SEND_STOCK_CODE"].ToString(), planrow["c_Judge_Lev_Zh"].ToString(), planrow["C_PACK"].ToString()).Tables[0];
                                if (dt1.Rows.Count < 1)
                                {
                                    TransactionHelper.RollBack();
                                    UPFYDSTATUS(fydh, "2", "根据发运单子表查询线材实绩错误！", id);
                                    break;
                                }

                                string barcodestr = "";
                                string gh = "";
                                int fpnum = 0;
                                foreach (DataRow xqitem in dt1.Rows)
                                {
                                    if (plannum == fpnum)
                                    {
                                        break;
                                    }
                                    barcodestr += "'" + xqitem["C_BARCODE"] + "',";
                                    gh += xqitem["C_TICK_NO"] + ",";
                                    fpnum++;
                                }
                                barcodestr = barcodestr.Substring(0, barcodestr.Length - 1);
                                gh = gh.Substring(0, gh.Length - 1);
                                #region 变更线材实绩
                                if (BJByBARCODE(barcodestr) == 0)
                                {
                                    TransactionHelper.RollBack();
                                    UPFYDSTATUS(fydh, "2", "根据发运单子表变更线材实绩错误！", id);
                                    break;
                                }

                                #endregion
                                DataTable sjdt = GetFYSJList(barcodestr).Tables[0];//查询材实绩
                                foreach (DataRow item1 in sjdt.Rows)
                                {
                                    #region 添加中间表
                                    string sql = "";
                                    sql += "insert into TMD_DISPATCH_SJZJB(C_DISPATCH_ID,N_NUM,N_STATUS,C_CKDH,N_JZ,C_SEND_STOCK,C_BATCH_NO,C_PLAN_ID,C_STL_GRD,C_STD_CODE,C_SPEC,C_PK_NCID,C_ZLDJ,C_BZYQ,D_CKSJ,C_MAT_CODE,C_MAT_NAME,C_TICK_STR) values('" + item["fydh"].ToString() + "','" + item1["N_NUM"] + "','8','" + no + "','" + item1["N_WGT"] + "','" + item1["C_LINEWH_CODE"] + "','" + item1["C_BATCH_NO"] + "','" + planrow["C_PLAN_ID"].ToString() + "','" + item1["C_STL_GRD"] + "','" + item1["C_STD_CODE"] + "','" + item1["C_SPEC"] + "','" + planrow["C_ID"].ToString() + "','" + item1["C_JUDGE_LEV_ZH"].ToString() + "','" + item1["C_BZYQ"] + "',to_date('" + item["insertts"].ToString() + "', 'yyyy-mm-dd hh24:mi:ss'),'" + item1["C_MAT_CODE"].ToString() + "','" + item1["C_MAT_DESC"].ToString() + "','" + gh + "')";
                                    if (TransactionHelper.ExecuteSql(sql) == 0)
                                    {
                                        TransactionHelper.RollBack();
                                        UPFYDSTATUS(fydh, "2", "添加发运单中间表错误！", id);
                                    }
                                    #endregion
                                }
                                #endregion
                            }
                            //上传条码
                            message = dal_Interface_NC_XC.SendXml_DM(path, item["fydh"].ToString());
                            if (message != "1")
                            {
                                TransactionHelper.RollBack();
                                UPFYDSTATUS(fydh, "2", message, id);
                                return "message";
                            }
                            TransactionHelper.Commit();
                            UPFYDSTATUS(fydh, "1", "", id);
                            UPFYDSTATUS(fydh, "8");
                        }
                    }
                    return "1";
                }
                else
                {
                    TransactionHelper.RollBack();
                    return "未查询到条码未上传的发运单！";
                }
            }
            catch (Exception ex)
            {
                LogSql = "INSERT INTO TI_RF_LOG(C_TYPE, C_LOG, C_NAME) VALUES('同步条码发运单信息','" + ex.ToString() + "','" + name + "')";
                DbHelperOra.ExecuteSql(LogSql);
                TransactionHelper.RollBack();
                return "代码异常！";
            }
        }
        /// <summary>
        /// 根据发运单号更新线材实绩
        /// </summary>
        /// <param name="C_BARCODE">牌号</param>
        /// <returns></returns>
        public int BJByBARCODE(string C_BARCODE)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("UPDATE TRC_ROLL_PRODCUT SET");
            strSql.Append(" C_FRFLAG='1' ");
            strSql.Append("  where C_BARCODE in(" + C_BARCODE + ") ");
            return TransactionHelper.ExecuteSql(strSql.ToString());
        }
        #endregion
        #region 转库单
        /// <summary>
        /// 更新条码转库单实绩表
        /// </summary>
        /// <param name="id">id</param>
        /// <returns></returns>
        public int UPYWDBZ(string id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("UPDATE SeZJB_Shift_Record SET");
            strSql.Append(" by1='已撤回！',updatets='" + RV.UI.ServerTime.timeNow() + "'");
            strSql.Append("  where  pk_SeZJB_Shift_Record='" + id + "'  ");
            return DbHelper_SQL.ExecuteSql(strSql.ToString());
        }
        /// <summary>
        /// 更新条码转库单实绩表
        /// </summary>
        /// <param name="id">id</param>
        /// <returns></returns>
        public int UPZKDBZ(string id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("UPDATE SeZJB_ZKD_finished SET");
            strSql.Append(" by1='已撤回！',updatets='" + RV.UI.ServerTime.timeNow() + "'");
            strSql.Append("  where  pk_SeZJB_ZKD_finishes='" + id + "'  ");
            return DbHelper_SQL.ExecuteSql(strSql.ToString());
        }
        /// <summary>
        /// 删除转库单中间表
        /// </summary>
        /// <param name="dhstr">单号</param>
        /// <returns></returns>
        public int UPRPBYZKD(string dhstr, string id)
        {
            #region 获取线材操作记录表
            string sql = "SELECT C_BARCODE,C_YLINEWH_CODE,C_YLINEWH_AREA_CODE,C_YLINEWH_LOC_CODE FROM TRC_ROLLCZ_LOG WHERE C_DH='" + dhstr + "' AND C_REMARK='" + id + "'";
            DataTable dt = TransactionHelper.Query(sql).Tables[0];
            #endregion
            if (dt.Rows.Count < 1)
            {
                return 0;
            }
            string barcode = "";
            string ck = dt.Rows[0]["C_YLINEWH_CODE"].ToString();
            string qy = dt.Rows[0]["C_YLINEWH_AREA_CODE"].ToString();
            string kw = dt.Rows[0]["C_YLINEWH_LOC_CODE"].ToString();
            foreach (DataRow item in dt.Rows)
            {
                barcode += "'" + item["C_BARCODE"] + "',";
            }
            barcode = barcode.Substring(0, barcode.Length - 1);
            StringBuilder strSql = new StringBuilder();
            strSql.Append("UPDATE Trc_Roll_Prodcut SET C_MOVE_TYPE='M',C_LINEWH_CODE='" + ck + "',C_LINEWH_AREA_CODE='" + qy + "',C_LINEWH_LOC_CODE='" + kw + "',C_ZKD_NO='" + dhstr + "'");
            strSql.Append(" WHERE C_BARCODE in(" + barcode + ")");
            return TransactionHelper.ExecuteSql(strSql.ToString());
        }
        /// <summary>
        /// 删除转库单中间表
        /// </summary>
        /// <param name="dhstr">单号</param>
        /// <returns></returns>
        public int UPRPBYYWD(string dhstr, string id)
        {
            #region 获取线材操作记录表
            string sql = "SELECT C_BARCODE,C_YLINEWH_CODE,C_YLINEWH_AREA_CODE,C_YLINEWH_LOC_CODE FROM TRC_ROLLCZ_LOG WHERE C_DH='" + dhstr + "' AND C_REMARK='" + id + "'";
            DataTable dt = TransactionHelper.Query(sql).Tables[0];
            #endregion
            if (dt.Rows.Count < 1)
            {
                return 0;
            }
            string barcode = "";
            string ck = dt.Rows[0]["C_YLINEWH_CODE"].ToString();
            string qy = dt.Rows[0]["C_YLINEWH_AREA_CODE"].ToString();
            string kw = dt.Rows[0]["C_YLINEWH_LOC_CODE"].ToString();
            foreach (DataRow item in dt.Rows)
            {
                barcode += "'" + item["C_BARCODE"] + "',";
            }
            barcode = barcode.Substring(0, barcode.Length - 1);
            StringBuilder strSql = new StringBuilder();
            strSql.Append("UPDATE Trc_Roll_Prodcut SET C_MOVE_TYPE='E',C_LINEWH_CODE='" + ck + "',C_LINEWH_AREA_CODE='" + qy + "',C_LINEWH_LOC_CODE='" + kw + "'");
            strSql.Append(" WHERE C_BARCODE in(" + barcode + ")");
            return TransactionHelper.ExecuteSql(strSql.ToString());
        }
        #region 发送转库单
        /// <summary>
        /// 更新线材实绩
        /// </summary>
        /// <param name="dhstr">转库单号</param>
        /// <returns></returns>
        public int UPZKSTATUS(string zkd, string matcode, string ck, string batch, string zldj, string bzyq, int num)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("UPDATE TRC_ROLL_PRODCUT SET");
            strSql.Append(" C_ZKD_NO='" + zkd + "',C_MOVE_TYPE='M'");
            strSql.Append("  where C_MOVE_TYPE='E' and C_MAT_CODE='" + matcode + "' AND nvl(C_JUDGE_LEV_ZH,C_JUDGE_LEV_BP)='" + zldj + "' AND C_LINEWH_CODE='" + ck + "' AND C_BATCH_NO='" + batch + "'    AND C_BZYQ='" + bzyq + "' AND ROWNUM<='" + num + "'");
            return TransactionHelper.ExecuteSql(strSql.ToString());
        }
        /// <summary>
        /// 分组获取库存信息
        /// </summary>
        /// <param name="C_QTCKD"></param>
        /// <param name="status"></param>
        /// <param name="C_ZKD"></param>
        /// <returns></returns>
        public DataSet GetXCKC(string C_QTCKD, string status, string C_ZKD)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select COUNT(1) N_NUM,C_STOVE,C_BATCH_NO,C_STL_GRD,SUM(N_WGT) N_WGT,C_STD_CODE,C_MOVE_TYPE,C_SPEC,C_MAT_CODE,C_MAT_DESC,C_LINEWH_CODE,nvl(C_JUDGE_LEV_ZH,C_JUDGE_LEV_BP)C_JUDGE_LEV_ZH,C_BZYQ,C_ZYX1,C_ZYX2,C_ZKD_NO,C_QTCKD_NO ");
            strSql.Append(" FROM TRC_ROLL_PRODCUT where C_MOVE_TYPE ='" + status + "' ");
            if (C_QTCKD.Trim() != "")
            {
                strSql.Append(" and C_QTCKD_NO ='" + C_QTCKD + "' ");
            }
            if (C_ZKD.Trim() != "")
            {
                strSql.Append(" and C_ZKD_NO ='" + C_ZKD + "' ");
            }
            strSql.Append(" GROUP BY  C_BATCH_NO,C_STOVE,C_STL_GRD,C_STD_CODE,C_MOVE_TYPE,C_SPEC,C_MAT_CODE,C_MAT_DESC,C_LINEWH_CODE,C_JUDGE_LEV_ZH,C_BZYQ,C_JUDGE_LEV_BP,C_ZYX1,C_ZYX2,C_ZKD_NO,C_QTCKD_NO ");
            return TransactionHelper.Query(strSql.ToString());
        }
        /// <summary>
        /// 通过转库单号获得转库单数据
        /// </summary>
        /// <param name="dh">单号</param>
        /// <returns></returns>
        public DataSet GetZKDListBydh(string dh)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_ZKD_NO,C_MAT_CODE,C_MAT_DESC,C_LINEWH_CODE,C_MBLINEWH_CODE,C_STL_GRD,C_JUDGE_LEV_ZH,N_NUM,N_WGT,C_Z_DW,C_F_DW,C_BATCH_NO,C_SPEC,C_STOVE,C_ZYX1,C_ZYX2,C_BZYQ,C_ZYX4,N_STATUS ");
            strSql.Append(" FROM TRC_ROLL_ZKD WHERE N_STATUS=1");
            if (dh.Trim() != "")
            {
                strSql.Append(" AND C_ZKD_NO ='" + dh + "' ");
            }
            return TransactionHelper.Query(strSql.ToString());
        }
        /// <summary>
        /// 检测库存是否变更
        /// </summary>
        /// <param name="mat">物料号</param>
        /// <param name="ck">仓库</param>
        /// <param name="batch">批号</param>
        /// <returns></returns>
        public int CKKC(string mat, string ck, string batch, string zldj, string bzyq)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT count(1) N_NUM FROM TRC_ROLL_PRODCUT WHERE C_MOVE_TYPE='E'");
            if (mat.Trim() != "")
            {
                strSql.Append(" and C_MAT_CODE='" + mat + "'");
            }
            if (ck.Trim() != "")
            {
                strSql.Append(" and C_LINEWH_CODE='" + ck + "'");
            }
            if (batch.Trim() != "")
            {
                strSql.Append(" and C_BATCH_NO='" + batch + "'");
            }
            if (zldj.Trim() != "")
            {
                strSql.Append(" and nvl(C_JUDGE_LEV_ZH,C_JUDGE_LEV_BP)='" + zldj + "'");
            }
            if (bzyq.Trim() != "")
            {
                strSql.Append(" and C_BZYQ='" + bzyq + "'");
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
        /// 获取最新的转库单号
        /// </summary>
        /// <param name="zkdstr">转库单</param>
        /// <returns></returns>
        public string GetZKDNO(string zkdstr)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select MAX(C_ZKD_NO) ");
            strSql.Append(" FROM TRC_ROLL_ZKD WHERE 1=1 ");
            if (zkdstr.Trim() != "")
            {
                strSql.Append(" AND C_ZKD_NO LIKE '%" + zkdstr + "%' ");
            }
            object obj = DbHelperOra.GetSingle(strSql.ToString());
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
        /// 向条码发送转库单
        /// </summary>
        /// <param name="idstr">id字符串</param>
        /// <param name="ckcode">仓库代码</param>
        /// <returns></returns>
        public string SENDZKD1(List<CommonKC> list, string mbck, string zkd)
        {
            string LogSql = "";
            string name = "Dal_Interface_FR.SENDZKD";
            DataTable dt = null;
            TransactionHelper.BeginTransaction();//开启ora事务
            TransactionHelper_SQL.BeginTransaction();//开启sql事务
            try
            {
                ///变更线材实绩
                foreach (CommonKC commonkc in list)
                {
                    if (UPZKSTATUS(zkd, commonkc.mat, commonkc.ck, commonkc.batch, commonkc.zldj, commonkc.bzyq, commonkc.num) != commonkc.num)//更新线材实绩表
                    {
                        TransactionHelper.RollBack();
                        TransactionHelper_SQL.RollBack();
                        return "更新线材实绩表状态错误！";
                    }
                }
                ///添加转库单中间表
                DataTable qtckdt = GetXCKC("", "M", zkd).Tables[0];
                if (qtckdt.Rows.Count == 0)
                {
                    TransactionHelper.RollBack();
                    TransactionHelper_SQL.RollBack();
                    return "查询出库详情错误！";
                }
                foreach (DataRow item in qtckdt.Rows)
                {
                    string mbsql = "Select C_ID From TPB_LINEWH WHERE C_LINEWH_CODE='" + mbck + "'";
                    DataTable mbcktb = DbHelperOra.Query(mbsql).Tables[0];
                    if (mbcktb.Rows.Count == 0)
                    {
                        TransactionHelper.RollBack();
                        TransactionHelper_SQL.RollBack();
                        return "源仓库(" + mbck + ")信息查询失败！";
                    }
                    mbsql = mbcktb.Rows[0]["C_ID"].ToString();
                    string ycksql = "Select C_ID From TPB_LINEWH WHERE C_LINEWH_CODE='" + item["C_LINEWH_CODE"] + "'";
                    DataTable ycktb = DbHelperOra.Query(ycksql).Tables[0];
                    if (ycktb.Rows.Count == 0)
                    {
                        TransactionHelper.RollBack();
                        TransactionHelper_SQL.RollBack();
                        return "源仓库(" + item["C_LINEWH_CODE"] + ")信息查询失败！";
                    }
                    ycksql = ycktb.Rows[0]["C_ID"].ToString();
                    StringBuilder strSql = new StringBuilder();
                    strSql.Append("INSERT INTO TRC_ROLL_ZKD(C_ZKD_NO,C_MAT_CODE,C_MAT_DESC,C_LINEWH_CODE,C_MBLINEWH_CODE,C_STL_GRD,C_JUDGE_LEV_ZH,N_NUM,N_WGT,C_Z_DW,C_F_DW,C_BATCH_NO,C_SPEC,C_STOVE,C_BZYQ,N_STATUS,C_ZYX1,C_ZYX2,C_EMP_ID) VALUES('" + zkd + "','" + item["C_MAT_CODE"] + "','" + item["C_MAT_DESC"] + "','" + ycksql + "','" + mbsql + "','" + item["C_STL_GRD"] + "','" + item["C_JUDGE_LEV_ZH"] + "','" + item["N_NUM"] + "','" + item["N_WGT"] + "','件【线材】','吨','" + item["C_BATCH_NO"] + "','" + item["C_SPEC"] + "','" + item["C_STOVE"] + "','" + item["C_BZYQ"] + "',1,'" + item["C_ZYX1"] + "','" + item["C_ZYX2"] + "','" + RV.UI.UserInfo.userID + "' ) ");

                    if (TransactionHelper.ExecuteSql(strSql.ToString()) == 0)
                    {
                        TransactionHelper.RollBack();
                        TransactionHelper_SQL.RollBack();
                        return "添加转库单中间表错误！";
                    }
                }
                dt = GetZKDListBydh(zkd).Tables[0];//要传输的转库单数据
                if (dt.Rows.Count != list.Count)
                {
                    TransactionHelper.RollBack();
                    TransactionHelper_SQL.RollBack();
                    return "查询要传输的转库单数据错误！";
                }
                foreach (DataRow zkditem in dt.Rows)
                {
                    //条码
                    string sql = "";
                    sql += "insert into ReZJB_ZKD(zkdh,sck,tck,wlh,wlmc,pch,sx,jhsl,jhzl,zjldw,fjldw,ph,gg,vfree0,vfree1,vfree2,vfree3,ZJBstatus,insertts,CAPPK) values('" + zkditem["C_ZKD_NO"] + "','" + zkditem["C_LINEWH_CODE"] + "','" + zkditem["C_MBLINEWH_CODE"] + "','" + zkditem["C_MAT_CODE"] + "','" + zkditem["C_MAT_DESC"] + "','" + zkditem["C_BATCH_NO"] + "','" + zkditem["C_JUDGE_LEV_ZH"] + "','" + zkditem["N_NUM"] + "','" + zkditem["N_WGT"] + "','件【线材】','吨','" + zkditem["C_STL_GRD"] + "','" + zkditem["C_SPEC"] + "','" + zkditem["C_STOVE"] + "','" + zkditem["C_ZYX1"] + "','" + zkditem["C_ZYX2"] + "','" + zkditem["C_BZYQ"] + "','0','" + RV.UI.ServerTime.timeNow() + "','" + zkditem["C_ID"] + "')";
                    if (TransactionHelper_SQL.ExecuteSql(sql) == 0)
                    {

                        TransactionHelper.RollBack();
                        TransactionHelper_SQL.RollBack();
                        return "发送条码中间表错误！";
                    }
                }

                TransactionHelper.Commit();//提交ora事务
                TransactionHelper_SQL.Commit();//提交sql事务
                return "1";
            }
            catch (Exception ex)
            {
                LogSql = "INSERT INTO TI_RF_LOG(C_TYPE, C_LOG, C_NAME) VALUES('向条码发送转库单','" + ex.ToString() + "','" + name + "')";
                DbHelperOra.ExecuteSql(LogSql);
                TransactionHelper.RollBack();
                TransactionHelper_SQL.RollBack();
                return "代码错误";
            }
        }
        #endregion
        #region 同步转库单
        /// <summary>
        /// 转库日志记录
        /// </summary>
        /// <param name="C_ZKD">其他出库单号</param>
        /// <returns></returns>
        public DataSet GetTMZKZJB(string C_ZKD)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select zkdh,case ZJBstatus when '0' then '未同步' when '1' then '同步成功'when '2' then '同步异常'end ZJBstatus ,by1,insertts,updatets ");
            strSql.Append(" FROM SeZJB_ZKD_finished WHERE 1=1");
            if (C_ZKD.Trim() != "")
            {
                strSql.Append(" AND zkdh='" + C_ZKD + "' ");
            }
            strSql.Append(" ORDER BY  zkdh ");
            return TransactionHelper_SQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 查询条码中间表未同步成功的转库单
        /// </summary>
        /// <returns>DataSet</returns>
        public DataSet GetZKDHByTM()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT ZKDH,pk_SeZJB_ZKD_finishes,by1 FROM SeZJB_ZKD_finished  WHERE ZJBstatus!=1");
            return DbHelper_SQL.Query(strSql.ToString());
        }
        /// <summary>
        /// 根据转库单号判断PCI是否存在本转库单
        /// </summary>
        /// <param name="ZKDH">转库单号</param>
        /// <returns>是否存在</returns>
        public bool ExistsByZKD(string ZKDH)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TRC_ROLL_ZKD ");
            strSql.Append(" where C_ZKD_NO='" + ZKDH + "'");
            return DbHelperOra.Exists(strSql.ToString());
        }
        /// <summary>
        /// 更新条码中间表状态
        /// </summary>
        /// <param name="status">状态</param>
        /// <param name="message">备注</param>
        /// <param name="id">id</param>
        /// <returns></returns>
        public int UPZKSTATUS(string status, string message, string id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("UPDATE SeZJB_ZKD_finished SET");
            strSql.Append(" ZJBstatus='" + status + "',by1='" + message + "',updatets='" + RV.UI.ServerTime.timeNow() + "'");
            strSql.Append("  where pk_SeZJB_ZKD_finishes='" + id + "' ");
            return DbHelper_SQL.ExecuteSql(strSql.ToString());
        }
        /// <summary>
        /// 根据转库单查询条码库存
        /// </summary>
        /// <param name="zkdh">转库单号</param>
        /// <returns></returns>
        public DataSet QueryTMZKKWByKC(string zkdh)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT a.ZKDH, a.Barcode, b.CK, b.HW FROM WMS_Bms_Tra_ZKD_Detail a, WMS_Bms_Inv_Info b WHERE a.Barcode = b.Barcode and a.ZKDH = '" + zkdh + "' ");
            return DbHelper_SQL.Query(strSql.ToString());
        }
        /// <summary>
        /// 根据牌号获取转库单号
        /// </summary>
        /// <param name="Barcode">牌号</param>
        /// <returns></returns>
        public string GetZKDDH(string Barcode)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT C_ZKD_NO FROM TRC_ROLL_PRODCUT ");
            strSql.Append("  where C_BARCODE='" + Barcode + "'");
            DataTable dt = DbHelperOra.Query(strSql.ToString()).Tables[0];
            if (dt.Rows.Count > 0)
            {
                return dt.Rows[0]["C_ZKD_NO"].ToString();
            }
            else
            {
                return "0";
            }
        }
        /// <summary>
        /// 生产修改转库单语句
        /// </summary>
        /// <param name="kcxqitem"></param>
        /// <returns></returns>
        private static StringBuilder UPZKD(DataRow kcxqitem)
        {
            string qy = kcxqitem["HW"].ToString().Substring(0, 5);
            StringBuilder strSql = new StringBuilder();
            strSql.Append("UPDATE TRC_ROLL_PRODCUT SET");
            strSql.Append(" C_ZKD_NO='',C_FYDH='',C_QTCKD_NO='', C_MOVE_TYPE = 'E',C_LINEWH_CODE='" + kcxqitem["CK"] + "',C_LINEWH_AREA_CODE='" + qy + "' ,C_LINEWH_LOC_CODE='" + kcxqitem["HW"] + "' ");
            strSql.Append("  where C_BARCODE='" + kcxqitem["Barcode"] + "' ");
            return strSql;
        }
        /// <summary>
        /// 根据转库单号获取未匹配线材
        /// </summary>
        /// <param name="zkdh">转库单号</param>
        /// <returns></returns>
        public DataSet GetWPPDH(string zkdh)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT C_BARCODE FROM TRC_ROLL_PRODCUT ");
            strSql.Append("  where C_ZKD_NO='" + zkdh + "'");
            return TransactionHelper.Query(strSql.ToString());
        }
        /// <summary>
        /// 根据单号，牌号更新线材实绩
        /// </summary>
        /// <param name="dh">转库单号</param>
        /// <param name="C_BARCODE">牌号</param>
        /// <returns></returns>
        public int UPRPByZKD(string dh, string C_BARCODE)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("UPDATE TRC_ROLL_PRODCUT SET");
            strSql.Append(" C_MOVE_TYPE='M', C_ZKD_NO='" + dh + "',C_QTCKD_NO=''");
            strSql.Append("  where C_BARCODE='" + C_BARCODE + "' ");
            return TransactionHelper.ExecuteSql(strSql.ToString());
        }
        /// <summary>
        /// 根据单号，牌号更新线材实绩
        /// </summary>
        /// <param name="dh">其他出库单单号</param>
        /// <param name="C_BARCODE">牌号</param>
        /// <returns></returns>
        public int UPRPByQTCKD(string dh, string C_BARCODE)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("UPDATE TRC_ROLL_PRODCUT SET");
            strSql.Append(" C_MOVE_TYPE='QC', C_QTCKD_NO='" + dh + "',C_ZKD_NO='',C_FYDH=''");
            strSql.Append("  where C_BARCODE='" + C_BARCODE + "' ");
            return TransactionHelper.ExecuteSql(strSql.ToString());
        }
        /// <summary>
        /// 根据牌号更新线材实绩
        /// </summary>
        /// <param name="C_BARCODE">牌号</param>
        /// <returns></returns>
        public int UPRPByNULL(string C_BARCODE)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("UPDATE TRC_ROLL_PRODCUT SET");
            strSql.Append(" C_MOVE_TYPE='E'");
            strSql.Append("  where C_BARCODE='" + C_BARCODE + "' ");
            return TransactionHelper.ExecuteSql(strSql.ToString());
        }

        /// <summary>
        /// 同步条码转库单信息
        /// </summary>
        /// <param name="path">地址</param>
        /// <returns></returns>
        public string TBZKD1(string path)
        {
            string LogSql = "";
            string name = "Dal_Interface_FR.TBZKD";
            try
            {
                DataTable dt = GetZKDHByTM().Tables[0];
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow item in dt.Rows)
                    {
                        string id = item["pk_SeZJB_ZKD_finishes"].ToString();
                        string zkd = item["ZKDH"].ToString();
                        if (item["by1"].ToString().Contains("已撤回"))
                        {
                            continue;
                        }
                        if (ExistsByZKD(zkd) == false)
                        {
                            UPZKSTATUS("2", "当前单号PCI系统不存在！", id);
                            continue;
                        }
                        else
                        {
                            TransactionHelper.BeginTransaction();
                            ///发运单号多次发送覆盖
                            if (CKZKD(zkd) > 1)
                            {
                                string lastid = GetLastZKDID(zkd, id);//获取上一条id
                                if (lastid != "")
                                {
                                    if (UPRPBYZKD(zkd, lastid) == 0)//撤回线材实绩
                                    {
                                        TransactionHelper.RollBack();
                                        UPZKSTATUS("2", "撤回线材实绩错误", id);
                                        return "撤回线材实绩错误";
                                    }
                                    UPZKDBZ(lastid);
                                }
                            }


                            //传送条码
                            DataTable ckdt = QueryTMZKKWByKC(zkd).Tables[0];///查询条码出库表
                            List<string> zkdhlist = new List<string>();
                            List<string> qtckdhlist = new List<string>();
                            List<string> nulldhlist = new List<string>();
                            string msg = "";
                            if (ckdt.Rows.Count > 0)
                            {
                                foreach (DataRow xqitem in ckdt.Rows)
                                {
                                    string barcode = xqitem["Barcode"].ToString();
                                    string zkdh = GetZKDDH(barcode);
                                    if (zkdh == "0")
                                    {
                                        msg = "1";
                                        TransactionHelper.RollBack();
                                        UPZKSTATUS("2", "打牌序号" + barcode + "PCI系统不存在！", id);
                                        break;
                                    }
                                    if (zkd == zkdh)
                                    {
                                        StringBuilder strSql = UPZKD(xqitem);
                                        if (TransactionHelper.ExecuteSql(strSql.ToString()) != 1)
                                        {
                                            msg = "1";
                                            TransactionHelper.RollBack();
                                            UPZKSTATUS("2", "异常:错误编码，201打牌序号" + barcode + "更新线材实绩状态错误", id);
                                            break;
                                        }
                                    }
                                    else
                                    {
                                        if (zkdh != "")
                                        {
                                            qtckdhlist.Add(zkdh);
                                            StringBuilder strSql = UPZKD(xqitem);
                                            if (TransactionHelper.ExecuteSql(strSql.ToString()) != 1)
                                            {
                                                msg = "1";
                                                TransactionHelper.RollBack();
                                                UPZKSTATUS("2", "异常:错误编码202，打牌序号" + barcode + "更新线材实绩状态错误", id);
                                                break;
                                            }
                                        }
                                        else
                                        {
                                            string ckdh = GetZKDDH(barcode);
                                            if (ckdh == "0")
                                            {
                                                nulldhlist.Add("");
                                                StringBuilder strSql = UPZKD(xqitem);
                                                if (TransactionHelper.ExecuteSql(strSql.ToString()) != 1)
                                                {
                                                    msg = "1";
                                                    TransactionHelper.RollBack();
                                                    UPZKSTATUS("2", "异常:错误编码203，打牌序号" + barcode + "更新线材实绩状态错误", id);
                                                    break;
                                                }
                                            }
                                            if (ckdh != "")
                                            {
                                                zkdhlist.Add(ckdh);
                                                StringBuilder strSql = UPZKD(xqitem);
                                                if (TransactionHelper.ExecuteSql(strSql.ToString()) != 1)
                                                {
                                                    msg = "1";
                                                    TransactionHelper.RollBack();
                                                    UPZKSTATUS("2", "异常:错误编码204，打牌序号" + barcode + "更新线材实绩状态错误", id);
                                                    break;
                                                }
                                            }
                                            else
                                            {
                                                nulldhlist.Add("");
                                                StringBuilder strSql = UPZKD(xqitem);
                                                if (TransactionHelper.ExecuteSql(strSql.ToString()) != 1)
                                                {
                                                    msg = "1";
                                                    TransactionHelper.RollBack();
                                                    UPZKSTATUS("2", "异常:错误编码205，打牌序号" + barcode + "更新线材实绩状态错误", id);
                                                    break;
                                                }
                                            }
                                        }

                                    }
                                    DataTable ydt = GetXCKC(barcode).Tables[0];//获取原线材状态
                                    DataRow data = ydt.Rows[0];
                                    string qy = xqitem["HW"].ToString().Substring(0, 5);
                                    string sql = "insert into TRC_ROLLCZ_LOG(C_DH,C_STOVE,C_BATCH_NO,C_TICK_NO,C_STL_GRD,N_WGT,C_STD_CODE,C_SPEC,C_LINEWH_CODE,C_LINEWH_AREA_CODE,C_LINEWH_LOC_CODE,C_YLINEWH_CODE,C_YLINEWH_AREA_CODE,C_YLINEWH_LOC_CODE,C_JUDGE_LEV_ZH,D_CZ_DATE,C_MAT_CODE,C_MAT_DESC,C_BARCODE,N_TYPE,C_REMARK) values('" + zkd + "','" + data["C_STOVE"] + "','" + data["C_BATCH_NO"] + "','" + data["C_TICK_NO"] + "','" + data["C_STL_GRD"] + "','" + data["N_WGT"] + "','" + data["C_STD_CODE"] + "','" + data["C_SPEC"] + "','" + xqitem["CK"] + "','" + qy + "','" + xqitem["HW"] + "','" + data["C_LINEWH_CODE"] + "','" + data["C_LINEWH_AREA_CODE"] + "','" + data["C_LINEWH_LOC_CODE"] + "','" + data["C_JUDGE_LEV_ZH"] + "', to_date('" + RV.UI.ServerTime.timeNow() + "', 'yyyy-mm-dd hh24:mi:ss'),'" + data["C_MAT_CODE"] + "','" + data["C_MAT_DESC"] + "','" + barcode + "','1','" + id + "')";
                                    if (TransactionHelper.ExecuteSql(sql.ToString()) != 1)///添加操作记录
                                    {
                                        msg = "1";
                                        TransactionHelper.RollBack();
                                        UPZKSTATUS("2", "PCI添加操作记录时错误", id);
                                        break;
                                    }
                                }
                                if (msg == "1")//验证是否有异常
                                {
                                    continue;
                                }
                                foreach (var wppitem in zkdhlist)
                                {
                                    DataTable wppdt = GetWPPDH(zkd).Tables[0];
                                    if (wppdt.Rows.Count == 0)
                                    {
                                        msg = "1";
                                        TransactionHelper.RollBack();
                                        UPZKSTATUS("2", "异常:错误编码206，单号" + zkd + "未查询到数据！PCI转库单已撤回！", id);
                                        break;
                                    }
                                    if (UPRPByZKD(wppitem, wppdt.Rows[0]["C_BARCODE"].ToString()) != 1)
                                    {
                                        msg = "1";
                                        TransactionHelper.RollBack();
                                        UPZKSTATUS("2", "异常:错误编码207，打牌序号" + wppdt.Rows[0]["C_BARCODE"] + "更新线材实绩状态错误", id);
                                        break;
                                    }
                                }
                                if (msg == "1")//验证是否有异常
                                {
                                    continue;
                                }
                                foreach (var wppitem in qtckdhlist)
                                {
                                    DataTable wppdt = GetWPPDH(zkd).Tables[0];
                                    if (wppdt.Rows.Count == 0)
                                    {
                                        msg = "1";
                                        TransactionHelper.RollBack();
                                        UPZKSTATUS("2", "异常:错误编码208，单号" + zkd + "未查询到数据！PCI转库单已撤回！", id);
                                        break;
                                    }
                                    if (UPRPByQTCKD(wppitem, wppdt.Rows[0]["C_BARCODE"].ToString()) != 1)
                                    {
                                        msg = "1";
                                        TransactionHelper.RollBack();
                                        UPZKSTATUS("2", "异常:错误编码209，打牌序号" + wppdt.Rows[0]["C_BARCODE"] + "更新线材实绩状态错误（其他出库单）", id);
                                        break;
                                    }
                                }
                                if (msg == "1")//验证是否有异常
                                {
                                    continue;
                                }
                                foreach (var wppitem in nulldhlist)
                                {
                                    DataTable wppdt = GetWPPDH(item["zkdh"].ToString()).Tables[0];
                                    if (wppdt.Rows.Count == 0)
                                    {
                                        msg = "1";
                                        TransactionHelper.RollBack();
                                        UPZKSTATUS("2", "异常:错误编码210，单号" + zkd + "未查询到数据！PCI转库单已撤回！", id);
                                        break;
                                    }
                                    if (UPRPByNULL(wppdt.Rows[0]["C_BARCODE"].ToString()) == 0)
                                    {
                                        msg = "1";
                                        TransactionHelper.RollBack();
                                        UPZKSTATUS("2", "异常:错误编码211，打牌序号" + wppdt.Rows[0]["C_BARCODE"].ToString() + "变更线材实绩错误！（库存线材）", id);
                                        break;
                                    }
                                }
                                if (msg == "1")//验证是否有异常
                                {
                                    continue;
                                }
                            }
                            else
                            {
                                UPZKSTATUS("2", "条码仓库不存在库存信息！", id);
                                continue;
                            }
                            //传送NC
                            string message = dal_Interface_NC_Roll_ZK4I.SendXml_GP(path, zkd);
                            if (message != "1")//发送其他出库单实绩到NC(4I)
                            {
                                if (msg.Contains("已存在") == false)
                                {
                                    TransactionHelper.RollBack();
                                    UPZKSTATUS("2", "4I" + message, id);
                                    continue;
                                }
                            }
                            message = dal_Interface_NC_Roll_ZK4A.SendXml_GP(path, zkd);
                            if (message != "1")//发送其他出库单实绩到NC(4A)
                            {
                                TransactionHelper.RollBack();
                                UPZKSTATUS("2", "4A" + message, id);
                                continue;
                            }
                            TransactionHelper.Commit();
                            UPZKSTATUS("1", "", id);
                        }
                    }
                    return "1";
                }
                else
                {
                    return "条码不存在未上传的转库单信息！";
                }
            }
            catch (Exception ex)
            {
                TransactionHelper.RollBack();
                LogSql = "INSERT INTO TI_RF_LOG(C_TYPE, C_LOG, C_NAME) VALUES('同步条码转库单信息','" + ex.ToString() + "','" + name + "')";
                DbHelperOra.ExecuteSql(LogSql);
                return "代码异常！";
            }
        }
        #endregion
        #region 撤回其他出库单




        /// <summary>
        /// 删除转库单表
        /// </summary>
        /// <param name="zkd">转库单</param>
        /// <returns>返回int类型 大于0发送成功,等于0发送失败</returns>
        public int DELZKD(string zkd)
        {
            string sql = "";
            sql += "Delete TRC_ROLL_ZKD WHERE C_ZKD_NO ='" + zkd + "'";
            return DbHelperOra.ExecuteSql(sql);
        }

        /// <summary>
        /// 变更线材实绩表
        /// </summary>
        /// <param name="zkd">转库单</param>
        /// <returns></returns>
        public int UPZKDSTATUSBY(string zkd)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("UPDATE TRC_ROLL_PRODCUT SET ");
            strSql.Append("C_MOVE_TYPE='E',C_ZKD_NO=''");
            strSql.Append("  where C_ZKD_NO ='" + zkd + "' ");
            return DbHelperOra.ExecuteSql(strSql.ToString());
        }
        /// <summary>
        ///根据条码其他出库单撤销数据
        /// </summary>
        /// <param name="zkd">转库单</param>
        /// <returns></returns>
        public int CXZKDByDH(string zkd)
        {
            if (CKZKD(zkd) > 0)
            {
                return 0;
            }
            if (UPZKDSTATUSBY(zkd) == 0)
            {
                return 0;
            }
            return 1;
        }
        #endregion
        #endregion
        #region 其他出库单
        /// <summary>
        /// 获取其他出库单数据
        /// </summary>
        /// <param name="C_QTCKD">其他出库单号</param>
        /// <returns></returns>
        public DataSet GetTMZJB(string C_QTCKD)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ckdh,case ZJBstatus when '0' then '未同步' when '1' then '同步成功'when '2' then '同步异常'end ZJBstatus ,by1,insertts,updatets ");
            strSql.Append(" FROM SeZJB_QTCKD_finished WHERE 1=1");
            if (C_QTCKD.Trim() != "")
            {
                strSql.Append(" AND ckdh='" + C_QTCKD + "' ");
            }
            strSql.Append(" ORDER BY  ckdh,pk_SeZJB_QTCKD_finished ");
            return TransactionHelper_SQL.Query(strSql.ToString());
        }
        /// <summary>
        /// 查未同步条码其他出库单中间表数据
        /// </summary>
        /// <returns>DataSet</returns>
        public DataSet QueryQTCKD()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT ckdh,pk_SeZJB_QTCKD_finished,by1 FROM SeZJB_QTCKD_finished  WHERE ZJBstatus!=1 ");
            return DbHelper_SQL.Query(strSql.ToString());
        }
        #region 撤回其他出库单
        /// <summary>
        /// 根其他出库单号判断PCI是否存在此其他出库单
        /// </summary>
        /// <param name="QTCKD">此其他出库单</param>
        /// <returns>是否存在</returns>
        public bool ExistsByQTCKD(string QTCKD)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TRC_ROLL_QTCKD ");
            strSql.Append(" where C_QTCKD_NO='" + QTCKD + "'");
            return DbHelperOra.Exists(strSql.ToString());
        }



        /// <summary>
        /// 删除其他出库单子表
        /// </summary>
        /// <param name="qtckdstr">其他出库单字符串</param>
        /// <returns>返回int类型 大于0发送成功,等于0发送失败</returns>
        public int DELQTCKDITEM(string qtckdstr)
        {
            string sql = "";
            sql += "Delete TRC_ROLL_QTCKD_ITEM WHERE C_QTCKD_NO ='" + qtckdstr + "' ";
            return DbHelperOra.ExecuteSql(sql);
        }
        /// <summary>
        /// 删除其他出库单子表
        /// </summary>
        /// <param name="qtckdstr">其他出库单字符串</param>
        /// <returns>返回int类型 大于0发送成功,等于0发送失败</returns>
        public int DELQTCKD(string qtckdstr)
        {
            string sql = "";
            sql += "Delete TRC_ROLL_QTCKD WHERE C_QTCKD_NO= '" + qtckdstr + "' ";
            return DbHelperOra.ExecuteSql(sql);
        }

        /// <summary>
        /// 变更线材实绩表
        /// </summary>
        /// <param name="qtckdstr">其他出库单符串</param>
        /// <returns></returns>
        public int UPQTCKDSTATUSBY(string qtckdstr)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("UPDATE TRC_ROLL_PRODCUT SET ");
            strSql.Append("C_MOVE_TYPE='E',C_QTCKD_NO=''");
            strSql.Append("  where C_QTCKD_NO ='" + qtckdstr + "' ");
            return DbHelperOra.ExecuteSql(strSql.ToString());
        }
        /// <summary>
        ///根据条码其他出库单撤销数据
        /// </summary>
        /// <param name="qtckd">其他出库单</param>
        /// <returns></returns>
        public int CXQTCKDByDH(string qtckd)
        {
            if (CKQTCKD(qtckd) < 0)
            {
                return 0;
            }
            if (UPQTCKDSTATUSBY(qtckd) == 0)
            {
                return 0;
            }
            return 1;
        }
        #endregion

        #region 发送其他出库单
        /// <summary>
        /// 获取最新的其他出库单号
        /// </summary>
        /// <param name="qtckdstr">出库单号</param>
        /// <returns></returns>
        public string GetQTCKNO(string qtckdstr)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select MAX(C_QTCKD_NO) ");
            strSql.Append(" FROM TRC_ROLL_QTCKD WHERE 1=1 ");
            if (qtckdstr.Trim() != "")
            {
                strSql.Append(" AND C_QTCKD_NO LIKE '%" + qtckdstr + "%' ");
            }
            object obj = DbHelperOra.GetSingle(strSql.ToString());
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
        /// 根据物料号，仓库批号，质量等级，包装要求，数量变更线材实绩表
        /// </summary>
        /// <param name="qtckd"></param>
        /// <param name="matcode"></param>
        /// <param name="ck"></param>
        /// <param name="batch"></param>
        /// <param name="zldj"></param>
        /// <param name="bzyq"></param>
        /// <param name="num"></param>
        /// <returns></returns>
        public int UPQTCKSTATUS(string qtckd, string matcode, string ck, string batch, string zldj, string bzyq, int num)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("UPDATE TRC_ROLL_PRODCUT SET");
            strSql.Append(" C_QTCKD_NO='" + qtckd + "',C_MOVE_TYPE='QC'");
            strSql.Append("  where C_MOVE_TYPE='E' AND C_MAT_CODE='" + matcode + "' AND nvl(C_JUDGE_LEV_ZH,C_JUDGE_LEV_BP)='" + zldj + "' AND C_LINEWH_CODE='" + ck + "' AND C_BATCH_NO='" + batch + "'    AND C_BZYQ='" + bzyq + "' AND ROWNUM<='" + num + "'");
            return TransactionHelper.ExecuteSql(strSql.ToString());
        }
        /// <summary>
        /// 通过其他出库单号获得其他出库单数据
        /// </summary>
        /// <param name="dhstr">其他出库单号</param>
        /// <returns></returns>
        public DataSet GetListByQTCKdhstr(string dhstr)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT a.C_QTCKD_NO,a.C_LIC_PLA_NO,a.C_ADDRESS,a.C_CREATE_ID,a.D_CREATE_DT,a.C_TYPE,a.C_SHDW,a.D_FYSJ,a.C_ID,a.C_CYS,a.C_NCDJ,b.C_LINEWH_CODE FROM TRC_ROLL_QTCKD a LEFT JOIN TRC_ROLL_QTCKD_ITEM b ON a.c_qtckd_no=b.c_qtckd_no  WHERE a.N_STATUS = 1 ");
            if (dhstr.Trim() != "")
            {
                strSql.Append(" AND a.C_QTCKD_NO ='" + dhstr + "' ");
            }
            return TransactionHelper.Query(strSql.ToString());
        }
        /// <summary>
        /// 向条码发送其他出库单
        /// </summary>
        /// <param name="dt">要发送的集合</param>
        /// <returns>返回int类型 大于0为转入成功,等于0发送失败</returns>
        public int ADDQTCKD(DataRow item)
        {
            string sql = "";
            sql += "insert into ReZJB_QTCKD (CKDH,CK,CPH,AimAdress,ZDR,ZDRQ,CKLX,SHDW,FYSJ,ZJBStatus,insertts,CAPPK,NCDJ,CYS) values('" + item["C_QTCKD_NO"] + "','" + item["C_LINEWH_CODE"] + "','" + item["C_LIC_PLA_NO"] + "','" + item["C_ADDRESS"] + "','" + item["C_CREATE_ID"] + "','" + item["D_CREATE_DT"] + "','" + item["C_TYPE"] + "','" + item["C_SHDW"] + "','" + item["D_FYSJ"] + "','0','" + RV.UI.ServerTime.timeNow() + "','" + item["C_ID"] + "','" + item["C_NCDJ"] + "','" + item["C_CYS"] + "')";

            return TransactionHelper_SQL.ExecuteSql(sql);
        }
        /// <summary>
        /// 向条码发送其他出库单详情
        /// </summary>
        /// <param name="dt">要发送的集合</param>
        /// <returns>返回int类型 大于0为转入成功,等于0发送失败</returns>
        public int ADDQTCKDXQ(DataTable dt)
        {
            int scount = 0;
            foreach (DataRow item in dt.Rows)
            {
                string sql = "";
                sql += "insert into ReZJB_QTCKD_Item(CKDH,PCH,SX,WLH,WLMC,PH,GG,JHSL,JHZL,SLDW,ZLDW,vfree0,vfree3,ZJBStatus,insertts,CAPPK,vfree1,vfree2) values('" + item["C_QTCKD_NO"] + "','" + item["C_BATCH_NO"] + "','" + item["C_JUDGE_LEV_ZH"] + "','" + item["C_MAT_CODE"] + "','" + item["C_MAT_DESC"] + "','" + item["C_STL_GRD"] + "','" + item["C_SPEC"] + "','" + item["N_NUM"] + "','" + item["N_WGT"] + "','件【线材】','吨','" + item["C_STOVE"] + "','" + item["C_BZYQ"] + "','0','" + RV.UI.ServerTime.timeNow() + "','" + item["C_ID"] + "','" + item["C_ZYX1"] + "','" + item["C_ZYX2"] + "')";
                if (TransactionHelper_SQL.ExecuteSql(sql) > 0)
                {
                    scount++;
                }
                else
                {
                    return 0;
                }
            }
            return scount;
        }
        /// <summary>
        /// 通过出库单号获得出库单详情数据
        /// </summary>
        /// <param name="dh">出库单号</param>
        /// <returns></returns>
        public DataSet GetListByQTCKdhXQ(string dh)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_QTCKD_NO,C_MAT_CODE,C_MAT_DESC,C_STL_GRD,C_JUDGE_LEV_ZH,N_NUM,N_WGT,C_Z_DW,C_F_DW,C_BATCH_NO,C_SPEC,C_STOVE,C_ZYX1,C_ZYX2,C_BZYQ,C_ZYX4,N_STATUS ");
            strSql.Append(" FROM TRC_ROLL_QTCKD_ITEM WHERE N_STATUS=1");

            if (dh.Trim() != "")
            {
                strSql.Append(" AND C_QTCKD_NO ='" + dh + "' ");
            }
            return TransactionHelper.Query(strSql.ToString());
        }
        /// <summary>
        /// 向条码发送其他出库信息
        /// </summary>
        /// <param name="num">数量</param>
        /// <param name="cph">车牌号</param>
        /// <param name="address">位置</param>
        /// <param name="zdr">制单人</param>
        /// <param name="cklx">出库类型</param>
        /// <param name="shdw">送货单位</param>
        /// <param name="fysj">发运实绩</param>
        /// <returns></returns>
        public string SENDQTCKD1(List<CommonKC> list, string qtckd, string cph, string address, string zdr, string cklx, string shdw, DateTime fysj, string cys, string mbckid, string mbckmc)
        {
            string LogSql = "";
            string name = "Dal_Interface_FR.SENDQTCKD";
            DataTable dt = null;
            try
            {

                StringBuilder strSql = new StringBuilder();
                strSql.Append("INSERT INTO TRC_ROLL_QTCKD(C_QTCKD_NO,C_ADDRESS,C_LIC_PLA_NO,C_CREATE_ID,D_CREATE_DT,N_STATUS,C_TYPE,C_SHDW,D_FYSJ,C_NCDJ,C_CYS,C_MBWH_ID,C_MBWH_NAME) VALUES('" + qtckd + "','" + address + "','" + cph + "','" + zdr + "',to_date('" + RV.UI.ServerTime.timeNow() + "','yyyy-mm-dd hh24:mi:ss'),1,'" + cklx + "','" + shdw + "',to_date('" + fysj + "','yyyy-mm-dd hh24:mi:ss'),'" + qtckd + "','" + cys + "','" + mbckid + "','" + mbckmc + "') ");
                TransactionHelper.BeginTransaction();//开启事务ora
                TransactionHelper_SQL.BeginTransaction();//开启事务sql
                if (TransactionHelper.ExecuteSql(strSql.ToString()) == 0)//生成其他出库单
                {
                    TransactionHelper.RollBack();
                    return "生成其他出库单错误！";
                }
                foreach (CommonKC item in list)
                {
                    if (UPQTCKSTATUS(qtckd, item.mat, item.ck, item.batch, item.zldj, item.bzyq, item.num) != item.num)
                    {
                        TransactionHelper.RollBack();
                        return "变更库存状态错误！";
                    }
                }
                DataTable qtckdt = GetXCKC(qtckd, "QC", "").Tables[0];
                if (qtckdt.Rows.Count != list.Count)
                {
                    TransactionHelper.RollBack();
                    return "查询出库详情错误！";
                }
                foreach (DataRow qtrow in qtckdt.Rows)
                {
                    StringBuilder strSql1 = new StringBuilder();
                    strSql1.Append("INSERT INTO TRC_ROLL_QTCKD_ITEM(C_QTCKD_NO,C_BATCH_NO,C_JUDGE_LEV_ZH,C_MAT_CODE,C_MAT_DESC,C_STL_GRD,C_SPEC,N_NUM,N_WGT,C_Z_DW,C_F_DW,C_STOVE,C_BZYQ,N_STATUS,C_LINEWH_CODE,C_ZYX1,C_ZYX2) VALUES('" + qtrow["C_QTCKD_NO"] + "','" + qtrow["C_BATCH_NO"] + "','" + qtrow["C_JUDGE_LEV_ZH"] + "','" + qtrow["C_MAT_CODE"] + "','" + qtrow["C_MAT_DESC"] + "','" + qtrow["C_STL_GRD"] + "','" + qtrow["C_SPEC"] + "','" + qtrow["N_NUM"] + "','" + qtrow["N_WGT"] + "','件【线材】','吨','" + qtrow["C_STOVE"] + "','" + qtrow["C_BZYQ"] + "',1,'" + qtrow["C_LINEWH_CODE"] + "','" + qtrow["C_ZYX1"] + "','" + qtrow["C_ZYX2"] + "') ");
                    if (TransactionHelper.ExecuteSql(strSql1.ToString()) == 0)//生成其他出库单详情
                    {
                        TransactionHelper.RollBack();
                        return "生成其他出库单详情错误！";
                    }
                }

                dt = GetListByQTCKdhstr(qtckd).Tables[0];//要传输的其他出库单数据
                if (dt.Rows.Count == 0)
                {
                    TransactionHelper.RollBack();
                    return "查询要传输的转库单数据错误！";
                }

                if (ADDQTCKD(dt.Rows[0]) != 1)//发送出库单
                {
                    TransactionHelper.RollBack();
                    TransactionHelper_SQL.RollBack();
                    return "上传条码其他出库单中间表错误！";
                }
                dt = GetListByQTCKdhXQ(qtckd).Tables[0]; //要传输的其他出库单详情数据
                if (dt.Rows.Count != list.Count)
                {
                    TransactionHelper.RollBack();
                    TransactionHelper_SQL.RollBack();
                    return "查询要传输的转库单详情数据错误！";
                }
                if (ADDQTCKDXQ(dt) != dt.Rows.Count)//发送出库单
                {
                    TransactionHelper.RollBack();
                    TransactionHelper_SQL.RollBack();
                    return "上传条码其他出库单详情中间表错误！";
                }
                TransactionHelper.Commit();
                TransactionHelper_SQL.Commit();
                return "1";
            }
            catch (Exception ex)
            {
                LogSql = "INSERT INTO TI_RF_LOG(C_TYPE, C_LOG, C_NAME) VALUES('向条码发送其他出库单','" + ex.ToString() + "','" + name + "')";
                DbHelperOra.ExecuteSql(LogSql);
                TransactionHelper.RollBack();
                TransactionHelper_SQL.RollBack();
                return "代码错误";
            }
        }
        #endregion
        #region 其他出库单同步
        /// <summary>
        /// 根据牌号获取其他出库单号
        /// </summary>
        /// <param name="Barcode">牌号</param>
        /// <returns></returns>
        public string GetQTCKDByPH(string Barcode)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT C_QTCKD_NO FROM TRC_ROLL_PRODCUT ");
            strSql.Append("  where C_BARCODE='" + Barcode + "' ");
            DataTable dt = DbHelperOra.Query(strSql.ToString()).Tables[0];
            if (dt.Rows.Count > 0)
            {
                return dt.Rows[0]["C_QTCKD_NO"].ToString();
            }
            else
            {
                return "0";
            }
        }
        /// <summary>
        /// 根据其他出库单查询条码出库详情
        /// </summary>
        /// <param name="qtckd">其他出库单</param>
        /// <returns></returns>
        public DataSet QueryQTCKDByCK(string qtckd)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT b.FYDH CKDH, b.Barcode, b.CK, b.HW FROM WMS_Bms_Inv_OutInfo b WHERE   b.FYDH = '" + qtckd + "'");
            return DbHelper_SQL.Query(strSql.ToString());
        }
        /// <summary>
        /// 根据单号变更条码其他出库单中间表数据
        /// </summary>
        /// <param name="status">要变更的状态</param>
        /// <param name="message">备注</param>
        /// <param name="id">主键</param>
        /// <returns></returns>
        public int UPQTCKZJBSTATUS(string status, string message, string id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("UPDATE SeZJB_QTCKD_finished SET");
            strSql.Append(" ZJBstatus='" + status + "',by1='" + message + "',updatets='" + RV.UI.ServerTime.timeNow() + "'");
            strSql.Append("  where pk_SeZJB_QTCKD_finished='" + id + "'  ");
            return DbHelper_SQL.ExecuteSql(strSql.ToString());
        }
        /// <summary>
        /// 生成修改其他出库单sql
        /// </summary>
        /// <param name="dh"></param>
        /// <param name="barcode"></param>
        /// <returns></returns>
        private static StringBuilder UPQTCKD(string dh, string barcode)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("UPDATE TRC_ROLL_PRODCUT SET C_ZKD_NO='',C_QTCKD_NO='" + dh + "'");
            strSql.Append(",C_MOVE_TYPE = 'QE' ");
            strSql.Append("  where C_BARCODE='" + barcode + "' ");
            return strSql;
        }
        /// <summary>
        /// 根据其他出库单号获取未匹配线材
        /// </summary>
        /// <param name="qtcdh">其他出库单号</param>
        /// <returns></returns>
        public DataSet GetWPPQTCKDH(string qtcdh)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT C_BARCODE FROM TRC_ROLL_PRODCUT ");
            strSql.Append("  where C_QTCKD_NO='" + qtcdh + "' ");
            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 更新发运单表
        /// </summary>
        /// <param name="dhstr">移位单号</param>
        /// <returns></returns>
        public int UPQTCKDSJZJB(string dhstr, string status, string by1, string id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("UPDATE SeZJB_QTCKD_finished SET");
            strSql.Append(" ZJBstatus='" + status + "',by1='" + by1 + "',updatets='" + RV.UI.ServerTime.timeNow() + "'");
            strSql.Append("  where fydh='" + dhstr + "' AND pk_SeZJB_QTCKD_finished='" + id + "'  ");
            return DbHelper_SQL.ExecuteSql(strSql.ToString());
        }
        /// <summary>
        /// 更新条码其他出库单实绩中间表
        /// </summary>
        /// <param name="id">id</param>
        /// <returns></returns>
        public int UPQTCKDBZ(string id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("UPDATE SeZJB_QTCKD_finished SET");
            strSql.Append("by1='已撤回！',updatets='" + RV.UI.ServerTime.timeNow() + "'");
            strSql.Append("  where   pk_SeZJB_QTCKD_finished='" + id + "'  ");
            return DbHelper_SQL.ExecuteSql(strSql.ToString());
        }
        /// <summary>
        /// 根据其他出库单更新线材实绩
        /// </summary>
        /// <param name="qtckd">其他出库单</param>
        /// <returns></returns>
        public int UPRPByQTCKDH(string qtckd)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("UPDATE TRC_ROLL_PRODCUT SET");
            strSql.Append(" C_MOVE_TYPE='QC'");
            strSql.Append("  where C_QTCKD_NO='" + qtckd + "' ");
            return TransactionHelper.ExecuteSql(strSql.ToString());
        }
        /// <summary>
        /// 同步条码其他出库单信息
        /// </summary>
        /// <returns></returns>
        public string QTCKDTB(string xmlFileName)
        {
            string LogSql = "";
            string name = "Dal_Interface_FR.TBYWD";
            try
            {
                DataTable dt = QueryQTCKD().Tables[0];
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow item in dt.Rows)
                    {
                        string ckd = item["CKDH"].ToString();
                        string id = item["pk_SeZJB_QTCKD_finished"].ToString();
                        if (item["by1"].ToString().Contains("已撤回"))
                        {
                            continue;
                        }
                        if (ExistsByQTCKD(ckd) == false)
                        {
                            UPQTCKZJBSTATUS("2", "异常:错误编码001，单号" + ckd + "PCI系统不存在！", id);
                            continue;
                        }
                        else
                        {
                            TransactionHelper.BeginTransaction();
                            ///发运单号多次发送覆盖
                            if (CKQTCKD(ckd) > 1)
                            {
                                string lastid = GetLastQTCKDID(ckd, id);
                                if (lastid != "")
                                {
                                    UPRPByQTCKDH(ckd);
                                    UPQTCKDBZ(lastid);
                                }
                            }


                            //传送条码
                            DataTable ckdt = QueryQTCKDByCK(ckd).Tables[0];///查询条码出库表
                            List<string> zkdhlist = new List<string>();
                            List<string> qtckdhlist = new List<string>();
                            List<string> nulldhlist = new List<string>();
                            string message = "";
                            if (ckdt.Rows.Count > 0)
                            {
                                foreach (DataRow xqitem in ckdt.Rows)
                                {
                                    string barcode = xqitem["Barcode"].ToString();
                                    string ckdh = GetQTCKDByPH(barcode);
                                    if (ckdh == "0")
                                    {
                                        message = "1";
                                        TransactionHelper.RollBack();
                                        UPQTCKZJBSTATUS("2", "打牌序号" + barcode + "PCI系统不存在！", id);
                                        break;
                                    }

                                    if (ckd == ckdh)
                                    {
                                        StringBuilder strSql = UPQTCKD(ckd, barcode);
                                        if (TransactionHelper.ExecuteSql(strSql.ToString()) != 1)
                                        {
                                            message = "1";
                                            TransactionHelper.RollBack();
                                            UPQTCKZJBSTATUS("2", "异常:错误编码101,打牌序号" + barcode + "更新线材实绩状态错误", id);
                                            break;
                                        }
                                    }
                                    else
                                    {
                                        if (ckdh != "")
                                        {
                                            qtckdhlist.Add(ckdh);
                                            StringBuilder strSql = UPQTCKD(ckd, barcode);
                                            if (TransactionHelper.ExecuteSql(strSql.ToString()) != 1)
                                            {
                                                message = "1";
                                                TransactionHelper.RollBack();
                                                UPQTCKZJBSTATUS("2", "异常:错误编码102，打牌序号" + barcode + "更新线材实绩状态错误", id);
                                                break;
                                            }
                                        }
                                        else
                                        {
                                            string zkdh = GetZKDDH(xqitem["Barcode"].ToString());
                                            if (zkdh == "0")
                                            {
                                                nulldhlist.Add("");
                                                StringBuilder strSql = UPQTCKD(ckd, barcode);
                                                if (TransactionHelper.ExecuteSql(strSql.ToString()) != 1)
                                                {
                                                    message = "1";
                                                    TransactionHelper.RollBack();
                                                    UPQTCKZJBSTATUS("2", "异常:错误编码103，打牌序号" + barcode + "更新线材实绩状态错误", id);
                                                    break;
                                                }
                                            }
                                            if (zkdh != "")
                                            {
                                                zkdhlist.Add(zkdh);
                                                StringBuilder strSql = UPQTCKD(ckd, barcode);
                                                if (TransactionHelper.ExecuteSql(strSql.ToString()) != 1)
                                                {
                                                    message = "1";
                                                    TransactionHelper.RollBack();
                                                    UPQTCKZJBSTATUS("2", "异常:错误编码104，打牌序号" + barcode + "更新线材实绩状态错误", id);
                                                    break;
                                                }
                                            }
                                            else
                                            {
                                                nulldhlist.Add("");
                                                StringBuilder strSql = UPQTCKD(ckd, barcode);
                                                if (TransactionHelper.ExecuteSql(strSql.ToString()) != 1)
                                                {
                                                    message = "1";
                                                    TransactionHelper.RollBack();
                                                    UPQTCKZJBSTATUS("2", "异常:错误编码105，打牌序号" + barcode + "更新线材实绩状态错误", id);
                                                    break;
                                                }
                                            }
                                        }

                                    }
                                    DataTable ydt = GetXCKC(barcode).Tables[0];//获取原线材状态
                                    DataRow data = ydt.Rows[0];
                                    string qy = xqitem["HW"].ToString().Substring(0, 5);
                                    string sql = "insert into TRC_ROLLCZ_LOG(C_DH,C_STOVE,C_BATCH_NO,C_TICK_NO,C_STL_GRD,N_WGT,C_STD_CODE,C_SPEC,C_LINEWH_CODE,C_LINEWH_AREA_CODE,C_LINEWH_LOC_CODE,C_YLINEWH_CODE,C_YLINEWH_AREA_CODE,C_YLINEWH_LOC_CODE,C_JUDGE_LEV_ZH,D_CZ_DATE,C_MAT_CODE,C_MAT_DESC,C_BARCODE,N_TYPE,C_REMARK) values('" + ckd + "','" + data["C_STOVE"] + "','" + data["C_BATCH_NO"] + "','" + data["C_TICK_NO"] + "','" + data["C_STL_GRD"] + "','" + data["N_WGT"] + "','" + data["C_STD_CODE"] + "','" + data["C_SPEC"] + "','" + xqitem["CK"] + "','" + qy + "','" + xqitem["HW"] + "','" + data["C_LINEWH_CODE"] + "','" + data["C_LINEWH_AREA_CODE"] + "','" + data["C_LINEWH_LOC_CODE"] + "','" + data["C_JUDGE_LEV_ZH"] + "', to_date('" + RV.UI.ServerTime.timeNow() + "', 'yyyy-mm-dd hh24:mi:ss'),'" + data["C_MAT_CODE"] + "','" + data["C_MAT_DESC"] + "','" + barcode + "','3','" + id + "')";
                                    if (TransactionHelper.ExecuteSql(sql.ToString()) != 1)///添加操作记录
                                    {
                                        message = "1";
                                        TransactionHelper.RollBack();
                                        UPQTCKZJBSTATUS("2", "PCI添加操作记录时错误", id);
                                        break;
                                    }
                                }
                                if (message == "1")
                                {
                                    continue;
                                }
                                foreach (var wppitem in zkdhlist)
                                {
                                    DataTable wppdt = GetWPPQTCKDH(ckd).Tables[0];
                                    if (wppdt.Rows.Count == 0)
                                    {
                                        message = "1";
                                        TransactionHelper.RollBack();
                                        UPQTCKZJBSTATUS("2", "异常:错误编码106，单号" + ckd + "未查询到数据！PCI转库单已撤回！", id);
                                        break;
                                    }
                                    if (UPRPByZKD(wppitem, wppdt.Rows[0]["C_BARCODE"].ToString()) != 1)
                                    {
                                        message = "1";
                                        TransactionHelper.RollBack();
                                        UPQTCKZJBSTATUS(ckd, "2", "异常:错误编码107，打牌序号" + wppdt.Rows[0]["C_BARCODE"] + "更新线材实绩状态错误");
                                        break;
                                    }
                                }
                                if (message == "1")
                                {
                                    continue;
                                }
                                foreach (var wppitem in qtckdhlist)
                                {
                                    DataTable wppdt = GetWPPQTCKDH(ckd).Tables[0];
                                    if (wppdt.Rows.Count == 0)
                                    {
                                        message = "1";
                                        TransactionHelper.RollBack();
                                        UPQTCKZJBSTATUS("2", "异常:错误编码108，单号" + ckd + "未查询到数据！PCI转库单已撤回！", id);
                                        break;
                                    }
                                    if (UPRPByQTCKD(wppitem, wppdt.Rows[0]["C_BARCODE"].ToString()) != 1)
                                    {
                                        message = "1";
                                        TransactionHelper.RollBack();
                                        UPQTCKZJBSTATUS("2", "异常:错误编码109，打牌序号" + wppdt.Rows[0]["C_BARCODE"] + "更新线材实绩状态错误（其他出库单）", id);
                                        break;
                                    }
                                }
                                if (message == "1")
                                {
                                    continue;
                                }
                                foreach (var wppitem in nulldhlist)
                                {
                                    DataTable wppdt = GetWPPQTCKDH(ckd).Tables[0];
                                    if (wppdt.Rows.Count == 0)
                                    {
                                        message = "1";
                                        TransactionHelper.RollBack();
                                        UPQTCKZJBSTATUS("2", "异常:错误编码110，单号" + ckd + "未查询到数据！PCI转库单已撤回！", id);
                                        break;
                                    }
                                    if (UPRPByNULL(wppdt.Rows[0]["C_BARCODE"].ToString()) == 0)
                                    {
                                        message = "1";
                                        TransactionHelper.RollBack();
                                        UPQTCKZJBSTATUS("2", "异常:错误编码111，打牌序号" + wppdt.Rows[0]["C_BARCODE"].ToString() + "变更线材实绩错误！（库存线材）", id);
                                        break;
                                    }
                                }
                                if (message == "1")
                                {
                                    continue;
                                }
                            }
                            else
                            {
                                TransactionHelper.RollBack();
                                UPQTCKZJBSTATUS("2", "条码仓库不存在库存信息！", id);
                                continue;
                            }
                            //传送NC
                            DataTable itemdt = GetQTCKXQByDH(ckd).Tables[0]; //要传输的出库单数据
                            if (itemdt.Rows.Count == 0)
                            {
                                message = "1";
                                TransactionHelper.RollBack();
                                UPQTCKZJBSTATUS("2", "其他出库单错误！", id);
                                continue;
                            }
                            if (message == "1")
                            {
                                continue;
                            }
                            DataRow item1 = itemdt.Rows[0];
                            string msg = dal_Interface_NC_Roll_QT4I.SendXml_GP(xmlFileName, ckd);
                            if (msg != "1")//发送其他出库单实绩到NC(4I)
                            {
                                if (msg.Contains("存在") == false)
                                {
                                    TransactionHelper.RollBack();
                                    UPQTCKZJBSTATUS("2", "4I" + msg, id);
                                    continue;
                                }
                            }
                            msg = dal_Interface_NC_Roll_QT4A.SendXml_GP(xmlFileName, ckd);
                            if (msg != "1")//发送其他出库单实绩到NC(4A)
                            {
                                TransactionHelper.RollBack();
                                UPQTCKZJBSTATUS("2", "4A" + msg, id);
                                continue;
                            }
                            TransactionHelper.Commit();
                            UPQTCKZJBSTATUS("1", "", id);
                        }
                    }
                    return "1";
                }
                else
                {
                    return "条码不存在未上传的其他出库单信息！";
                }
            }
            catch (Exception ex)
            {

                LogSql = "INSERT INTO TI_RF_LOG(C_TYPE, C_LOG, C_NAME) VALUES('同步条码其他出库单信息','" + ex.ToString() + "','" + name + "')";
                TransactionHelper.RollBack();
                DbHelperOra.ExecuteSql(LogSql);
                return "代码异常！";
            }
        }
        /// <summary>
        /// 通过出库单号获得出库单详情数据
        /// </summary>
        /// <param name="dh">出库单号</param>
        /// <returns></returns>
        public DataSet GetQTCKXQByDH(string dh)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_QTCKD_NO,C_MAT_CODE,C_MAT_DESC,C_STL_GRD,C_JUDGE_LEV_ZH,N_NUM,N_WGT,C_Z_DW,C_F_DW,C_BATCH_NO,C_SPEC,C_STOVE,C_ZYX1,C_ZYX2,C_BZYQ,C_ZYX4,N_STATUS ");
            strSql.Append(" FROM TRC_ROLL_QTCKD_ITEM WHERE N_STATUS=1");

            if (dh.Trim() != "")
            {
                strSql.Append(" AND C_QTCKD_NO ='" + dh + "' ");
            }
            return TransactionHelper.Query(strSql.ToString());
        }
        #endregion
        #endregion
        #region 移位单
        /// <summary>
        /// 获取移位单数据
        /// </summary>
        /// <param name="C_YWDH">其他出库单号</param>
        /// <returns></returns>
        public DataSet GetTMYWD(string C_YWDH)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select pk_SeZJB_Shift_Record,ywdh,barcode,case ZJBstatus when '0' then '未同步' when '1' then '同步成功'when '2' then '同步异常'end ZJBstatus ,by1,insertts,updatets ");
            strSql.Append(" FROM SeZJB_Shift_Record WHERE 1=1");
            if (C_YWDH.Trim() != "")
            {
                strSql.Append(" AND ywdh='" + C_YWDH + "' ");
            }
            strSql.Append(" ORDER BY  ywdh ");
            return TransactionHelper_SQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 通过条码移位单中间表查询所有未同步的移位单号
        /// </summary>
        /// <returns></returns>
        public DataSet GetYWD()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT barcode,ywdh,pk_SeZJB_Shift_Record FROM SeZJB_Shift_Record WHERE ZJBstatus!=1");
            return DbHelper_SQL.Query(strSql.ToString());
        }
        /// <summary>
        /// 通过库存表查询条码移库库位
        /// </summary>
        /// <param name="dh"></param>
        /// <returns></returns>
        public DataSet QueryTMYKKWByKC(string dh, string barcode)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT a.YWDH, a.Barcode, b.CK, b.HW FROM WMS_Bms_Shi_YWD_item a, WMS_Bms_Inv_Info b WHERE a.Barcode = b.Barcode and a.ywdh='" + dh + "' AND a.barcode='" + barcode + "'");

            return DbHelper_SQL.Query(strSql.ToString());
        }
        /// <summary>
        /// 更新移位单表
        /// </summary>
        /// <param name="dhstr">移位单号</param>
        /// <returns></returns>
        public int UPYWDSTATUS(string status, string by1, string id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("UPDATE SeZJB_Shift_Record SET");
            strSql.Append(" ZJBstatus='" + status + "',by1='" + by1 + "',updatets='" + RV.UI.ServerTime.timeNow() + "'");
            strSql.Append("  where pk_SeZJB_Shift_Record='" + id + "'  ");
            return DbHelper_SQL.ExecuteSql(strSql.ToString());
        }
        /// <summary>
        /// 同步条码移位单信息
        /// </summary>
        /// <returns></returns>
        public string TBYWD()
        {
            string LogSql = "";
            string name = "Dal_Interface_FR.TBYWD";
            string message = "";
            try
            {
                DataTable dhdt = GetYWD().Tables[0];
                if (dhdt.Rows.Count == 0)
                {
                    return "没有要同步的单号!";
                }
                foreach (DataRow dhrow in dhdt.Rows)
                {
                    string id = dhrow["pk_SeZJB_Shift_Record"].ToString();
                    string ywd = dhrow["ywdh"].ToString();
                    string barcode = dhrow["barcode"].ToString();
                    DataTable dt = QueryTMYKKWByKC(ywd, barcode).Tables[0];//获取移位详情
                    if (dt.Rows.Count == 0)
                    {
                        message = "该移位单未查询到移位实绩！";
                        continue;
                    }
                    TransactionHelper.BeginTransaction();//开启事务
                    //if (CKYWD(ywd)>1)
                    //{
                    //    string lastid = GetLastYWDID(ywd, id);//获取上一条id
                    //    if (lastid != "")
                    //    {
                    //        if (UPRPBYYWD(ywd, lastid) == 0)//撤回线材实绩
                    //        {
                    //            TransactionHelper.RollBack();
                    //            UPYWDSTATUS("2", "撤回线材实绩错误", id);
                    //            return "撤回线材实绩错误";
                    //        }
                    //        UPYWDBZ(lastid);
                    //    }
                    //}
                    foreach (DataRow item in dt.Rows)
                    {
                        DataTable ydt = GetXCKC(item["Barcode"].ToString()).Tables[0];//获取原线材状态
                        if (ydt.Rows.Count != 1)
                        {
                            message = "牌号" + item["Barcode"].ToString() + "PCI系统不存在！";
                            break;
                        }
                        DataRow data = ydt.Rows[0];
                        if (data["C_MOVE_TYPE"].ToString() != "E")
                        {
                            message = "牌号" + item["Barcode"].ToString() + "PCI系统状态为" + data["C_MOVE_TYPE"].ToString() + "！";
                            break;
                        }
                        string qy = item["HW"].ToString().Substring(0, 5);
                        string sql = "insert into TRC_ROLLCZ_LOG(C_DH,C_REMARK,C_STOVE,C_BATCH_NO,C_TICK_NO,C_STL_GRD,N_WGT,C_STD_CODE,C_SPEC,C_LINEWH_CODE,C_LINEWH_AREA_CODE,C_LINEWH_LOC_CODE,C_YLINEWH_CODE,C_YLINEWH_AREA_CODE,C_YLINEWH_LOC_CODE,C_JUDGE_LEV_ZH,D_CZ_DATE,C_MAT_CODE,C_MAT_DESC,C_BARCODE,N_TYPE) values('" + ywd + "','" + id + "','" + data["C_STOVE"] + "','" + data["C_BATCH_NO"] + "','" + data["C_TICK_NO"] + "','" + data["C_STL_GRD"] + "','" + data["N_WGT"] + "','" + data["C_STD_CODE"] + "','" + data["C_SPEC"] + "','" + item["CK"] + "','" + qy + "','" + item["HW"] + "','" + data["C_LINEWH_CODE"] + "','" + data["C_LINEWH_AREA_CODE"] + "','" + data["C_LINEWH_LOC_CODE"] + "','" + data["C_JUDGE_LEV_ZH"] + "', to_date('" + RV.UI.ServerTime.timeNow() + "', 'yyyy-mm-dd hh24:mi:ss'),'" + data["C_MAT_CODE"] + "','" + data["C_MAT_DESC"] + "','" + item["Barcode"] + "','2')";
                        if (TransactionHelper.ExecuteSql(sql.ToString()) != 1)///添加操作记录
                        {
                            message = "PCI添加操作日志时错误！";
                            break;
                        }
                        StringBuilder strSql = new StringBuilder();
                        strSql.Append("UPDATE TRC_ROLL_PRODCUT SET");
                        strSql.Append(" C_MOVE_TYPE = 'E',C_LINEWH_CODE='" + item["CK"] + "',C_LINEWH_LOC_CODE='" + item["HW"] + "' ");
                        strSql.Append("  where C_BARCODE='" + item["Barcode"] + "' ");
                        if (TransactionHelper.ExecuteSql(strSql.ToString()) != 1)//变更线材实绩
                        {
                            message = "更新实绩时错误！";
                            break;
                        }
                    }
                    if (message != "")
                    {
                        TransactionHelper.RollBack();
                        UPYWDSTATUS("2", message, id);
                    }
                    UPYWDSTATUS("1", "", id);
                    TransactionHelper.Commit();
                }
                return "1";
            }
            catch (Exception ex)
            {
                LogSql = "INSERT INTO TI_RF_LOG(C_TYPE, C_LOG, C_NAME) VALUES('同步条码移位单信息','" + ex.ToString() + "','" + name + "')";
                DbHelperOra.ExecuteSql(LogSql);
                TransactionHelper.RollBack();
                return ex.ToString();
            }
        }
        #endregion
        #region 检查中间表
        /// <summary>
        /// 通过转库单号查询条码中间实绩中间表上一个数据id
        /// </summary>
        /// <param name="fyd">发运单</param>
        /// <returns></returns>
        public string GetLastFYDID(string fyd, string id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT MAX(pk_SeZJB_FYD_finished) FROM SeZJB_FYD_finished  WHERE fydh='" + fyd + "' AND pk_SeZJB_FYD_finished<'" + id + "'");
            var obj = DbHelper_SQL.GetSingle(strSql.ToString());
            if (obj == null)
            {
                return "";
            }
            else
            {
                return obj.ToString();
            }
        }
        /// <summary>
        /// 通过其他出库单查询条码中间实绩中间表上一个数据id
        /// </summary>
        /// <param name="qtckd">转库单号</param>
        /// <returns></returns>
        public string GetLastQTCKDID(string qtckd, string id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT MAX(pk_SeZJB_QTCKD_finished) FROM SeZJB_QTCKD_finished  WHERE ckdh='" + qtckd + "' AND pk_SeZJB_QTCKD_finished<'" + id + "'");
            var obj = DbHelper_SQL.GetSingle(strSql.ToString());
            if (obj == null)
            {
                return "";
            }
            else
            {
                return obj.ToString();
            }
        }
        /// <summary>
        /// 通过移位单号，id查询条码中间实绩中间表上一个数据id
        /// </summary>
        /// <param name="ywdh">移位单号</param>
        /// <returns></returns>
        public string GetLastYWDID(string ywdh, string id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT MAX(pk_SeZJB_Shift_Record) FROM SeZJB_Shift_Record  WHERE ywdh='" + ywdh + "' AND pk_SeZJB_Shift_Record<'" + id + "'");
            var obj = DbHelper_SQL.GetSingle(strSql.ToString());
            if (obj == null)
            {
                return "";
            }
            else
            {
                return obj.ToString();
            }
        }
        /// <summary>
        /// 通过转库单号查询条码中间实绩中间表上一个数据id
        /// </summary>
        /// <param name="zkdh">转库单号</param>
        /// <returns></returns>
        public string GetLastZKDID(string zkdh, string id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT MAX(pk_SeZJB_ZKD_finishes) FROM SeZJB_ZKD_finished  WHERE zkdh='" + zkdh + "' AND pk_SeZJB_ZKD_finishes<'" + id + "'");
            var obj = DbHelper_SQL.GetSingle(strSql.ToString());
            if (obj == null)
            {
                return "";
            }
            else
            {
                return obj.ToString();
            }
        }
        /// <summary>
        /// 通过转库单号查询条码中间实绩中间表数量
        /// </summary>
        /// <param name="zkdh">转库单号</param>
        /// <returns></returns>
        public int CKZKD(string zkdh)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT count(1) FROM SeZJB_ZKD_finished  WHERE zkdh='" + zkdh + "'");
            var obj = DbHelper_SQL.GetSingle(strSql.ToString());
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
        /// 根据移位单号查询条码实绩中间表数量
        /// </summary>
        /// <returns>DataSet</returns>
        public int CKYWD(string ywdh)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT count(1) FROM SeZJB_Shift_Record  WHERE ywdh='" + ywdh + "'");
            var obj = DbHelper_SQL.GetSingle(strSql.ToString());
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
        /// 根据其他出库单号查询条码实绩中间表数量
        /// </summary>
        /// <param name="ckdh">其他出库单</param>
        /// <returns></returns>
        public int CKQTCKD(string ckdh)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT Count(1) FROM SeZJB_QTCKD_finished ");
            strSql.Append("  where ckdh='" + ckdh + "' ");
            var obj = DbHelper_SQL.GetSingle(strSql.ToString());
            if (obj == null)
            {
                return 0;
            }
            else
            {
                return Convert.ToInt32(obj); ;
            }
        }
        /// <summary>
        /// 通过发运单号查询条码实绩中间表数量
        /// </summary>
        /// <returns>DataSet</returns>
        public int CKFYD(string fydh)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT count(1) FROM SeZJB_FYD_finished  WHERE fydh='" + fydh + "'");
            var obj = DbHelper_SQL.GetSingle(strSql.ToString());
            if (obj == null)
            {
                return 0;
            }
            else
            {
                return Convert.ToInt32(obj);
            }
        }
        #endregion
        #region 查询条码中间表id

        #endregion
        #region 查询线材信息
        /// <summary>
        /// 查询线材信息
        /// </summary>
        /// <param name="batchNo">批号</param>
        /// <param name="gh">钩号</param>
        /// <returns></returns>
        public DataSet RfXC(string batchNo, string gh)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(@"SELECT * FROM DBO.WMS_Bms_Inv_Info WHERE PCH = '" + batchNo + "'  ");
            if (!string.IsNullOrWhiteSpace(gh))
                strSql.Append(@" AND GH='" + gh + "'  ");
            strSql.Append(@"  ORDER BY GH ");
            return DbHelper_SQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取线材信息
        /// </summary>
        /// <param name="batchNo"></param>
        /// <returns></returns>
        public DataSet RollPro(string batchNo, string gh)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(@"  SELECT * FROM TRC_ROLL_PRODCUT WHERE C_BATCH_NO = '" + batchNo + "'  AND  C_MOVE_TYPE='E' ");
            if (!string.IsNullOrWhiteSpace(gh))
                strSql.Append(@" AND C_TICK_NO='" + gh + "'  ");
            strSql.Append(@"ORDER BY to_number(nvl(C_TICK_NO, '0')) ");
            return DbHelperOra.Query(strSql.ToString());
        }

        public bool UpdateWgt(string id, decimal wgt, DateTime rkrq)
        {
            string sql = @" UPDATE  TRC_ROLL_PRODCUT T SET T.N_WGT=" + wgt + " ,T.D_RKRQ=to_date('" + rkrq + "','yyyy-mm-dd hh24:mi:ss')  WHERE T.C_ID='" + id + "'  ";

            int rows = TransactionHelper.ExecuteSql(sql);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        #endregion
    }
}
