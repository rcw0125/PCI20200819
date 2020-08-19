using MODEL;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using BLL;
using DAL;

namespace IDAL
{
    public partial class Dal_Interface_FR
    {
        public Dal_Interface_FR()
        { }
        Bll_Interface_NC_Roll_ZK4I bll_Interface_NC_ZKCK = new Bll_Interface_NC_Roll_ZK4I();
        Bll_Interface_NC_Roll_ZK4A bll_Interface_NC_ZKRK = new Bll_Interface_NC_Roll_ZK4A();
        Bll_Interface_NC_Roll_QT4I bll_Interface_NC_QTCK = new Bll_Interface_NC_Roll_QT4I();
        Bll_Interface_NC_Roll_QT4A bll_Interface_NC_QTRK = new Bll_Interface_NC_Roll_QT4A();
        Dal_Interface_NC_XC dal_Interface_NC_XC = new Dal_Interface_NC_XC();
        Dal_TB_STD_CONFIG dalTbStdConfig = new Dal_TB_STD_CONFIG();
        Dal_TRP_WGD_ITEMINFO dalTrpWgdIteminfo = new Dal_TRP_WGD_ITEMINFO();

        #region 其他
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

        /// <summary>
        /// 获取订单信息
        /// </summary>
        /// <param name="strWgdh">完工单号</param>
        public DataSet Get_Order_Info(string strWgdh)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select TC.C_DESIGN_NO,TC.C_STD_CODE,TC.C_STL_GRD,tc.C_AREA,tc.c_cust_no,tc.c_cust_name from trc_roll_wgd ta inner join trp_plan_roll_item tb on ta.c_plan_id=tb.c_id inner join tmo_order tc on tc.c_order_no=tb.c_order_no where ta.C_MAIN_ID='" + strWgdh + "'");

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
            strSql.Append("SELECT TB.C_DESIGN_NO FROM TQB_STD_MAIN TA INNER JOIN TQB_DESIGN TB ON TA.C_ID=TB.C_STD_MAIN_ID WHERE TA.C_STD_CODE='" + C_STD_CODE + "' AND TA.C_STL_GRD='" + C_STL_GRD + "' AND TA.N_IS_CHECK=1 AND TA.N_STATUS=1 ");

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
        public DataSet GetKCList(string Barcode, string CK, string HW, string WGDH, string PH, string GH, string GZ)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT T1.BARCODE, T1.WGDH, T1.CK, T1.HW, T1.PCH, T1.WLH, T1.WLMC, T1.SX, T1.PH, T1.GG, T1.BB AS RKBB, T1.GH, T1.ZL, T1.BZ, T1.RQ, T1.RKTYPE, T1.RKRY, T1.WEIGHTRQ, T1.PRODUCEDATA, T1.VFREE1, T1.VFREE2, T1.VFREE3, T2.BB AS SCBB,T2.PCInfo, T2.SCX, T2.ZXBZ, T2.VFREE0,T1.ERRSEASON ");

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
        /// 获取工位id
        /// </summary>
        /// <param name="batch">批号</param>
        /// <returns></returns>
        public string GetSTAbybatch(string batch)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT C_ID  FROM TB_STA WHERE C_STA_CODE like '%ZX' and C_STA_CODE LIKE '%" + batch + "%'");

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
        /// 根据货位获取对应的仓库区域
        /// </summary>
        /// <param name="hw">货位编码</param>
        /// <returns></returns>
        public string GetHWQY(string hw)
        {
            string sql = @"SELECT TA.C_LINEWH_AREA_CODE
  FROM TPB_LINEWH_LOC T
  LEFT JOIN TPB_LINEWH_AREA TA
    ON T.C_LINEWH_AREA_ID = TA.C_ID
 WHERE T.C_LINEWH_LOC_CODE = '" + hw + "'";

            object obj = DbHelperOra.GetSingle(sql);
            if (obj == null)
            {
                return "";
            }
            else
            {
                return obj.ToString();
            }

        }

        Dal_TRC_ROLL_WGD dal_wgd = new Dal_TRC_ROLL_WGD();
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

            Mod_TRC_ROLL_WGD mod = dal_wgd.GetModelByC_BATCH_NO(dt.Rows[0]["PCH"].ToString());

            DataTable dtOrderInfo = Get_Order_Info(WGDH).Tables[0];

            string strDesignNo = "";
            string C_AREA = dtOrderInfo.Rows[0]["C_AREA"].ToString();
            string custNo = "";
            string custName = "";
            try
            {
                custNo = dtOrderInfo.Rows[0]["c_cust_no"] == DBNull.Value ? "" : dtOrderInfo.Rows[0]["c_cust_no"].ToString();
                custName = dtOrderInfo.Rows[0]["c_cust_name"] == DBNull.Value ? "" : dtOrderInfo.Rows[0]["c_cust_name"].ToString();
            }

            catch
            { }
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {

                    string strFree1 = dt.Rows[i]["VFREE1"].ToString();
                    string strFree2 = dt.Rows[i]["VFREE2"].ToString();
                    string spec = dt.Rows[i]["GG"].ToString().Replace("mm", "");

                    string strStdCode = strFree1.Split('~')[1].Contains("协议") ? strFree2.Split('~')[1].Replace(" ", "").Replace("（", "(").Replace("）", ")") : strFree1.Split('~')[1].Replace(" ", "").Replace("（", "(").Replace("）", ")");

                    string batch = dt.Rows[i]["PCH"].ToString().Substring(1, 1);
                    string staid = GetSTAbybatch(batch);
                    string strarea = dt.Rows[i]["HW"].ToString();

                    if (strarea.Length > 4)
                    {
                        strarea = strarea.Substring(0, 5);
                    }


                    strDesignNo = Get_Design_No(strStdCode, dt.Rows[i]["PH"].ToString());


                    if (Exists(dt.Rows[i]["PCH"].ToString(), dt.Rows[i]["GH"].ToString()))//当前库已经存在该卷
                    {
                        try
                        {
                            string UpdateSql = " UPDATE TRC_ROLL_PRODCUT T";
                            UpdateSql = UpdateSql + "  SET T.N_WGT = '" + dt.Rows[i]["ZL"].ToString() + "',";
                            UpdateSql = UpdateSql + "   T.C_MOVE_TYPE = 'E',";
                            UpdateSql = UpdateSql + "   T.c_Barcode = '" + dt.Rows[i]["BARCODE"].ToString() + "',";
                            UpdateSql = UpdateSql + "   T.C_LINEWH_AREA_CODE = '" + strarea + "',";
                            UpdateSql = UpdateSql + "   T.C_SALE_AREA = '" + C_AREA + "',";  //C_SALE_AREA
                            UpdateSql = UpdateSql + "   T.C_DESIGN_NO = '" + strDesignNo + "',";
                            UpdateSql = UpdateSql + "   T.C_CUST_NO = '" + custNo + "',";
                            UpdateSql = UpdateSql + "   T.C_CUST_NAME = '" + custName + "',";
                            UpdateSql = UpdateSql + "   T.C_MAT_CODE = '" + dt.Rows[i]["WLH"].ToString() + "',";
                            UpdateSql = UpdateSql + "   T.C_MAT_DESC = '" + dt.Rows[i]["WLMC"].ToString() + "',";
                            UpdateSql = UpdateSql + "   T.C_LINEWH_CODE = '" + dt.Rows[i]["CK"].ToString() + "',";
                            UpdateSql = UpdateSql + "   T.C_LINEWH_LOC_CODE = '" + dt.Rows[i]["HW"].ToString() + "',";
                            UpdateSql = UpdateSql + "   T.C_ZYX1 = '" + dt.Rows[i]["VFREE1"].ToString() + "',";
                            UpdateSql = UpdateSql + "   T.C_ZYX2 = '" + dt.Rows[i]["VFREE2"].ToString() + "',";
                            UpdateSql = UpdateSql + "   T.C_STOVE = '" + dt.Rows[i]["VFREE0"].ToString() + "',";
                            UpdateSql = UpdateSql + "   T.C_JUDGE_LEV_BP = '" + dt.Rows[i]["SX"].ToString() + "',";
                            UpdateSql = UpdateSql + "   T.C_REASON_NAME = '" + dt.Rows[i]["ERRSEASON"].ToString() + "',";
                            UpdateSql = UpdateSql + "   T.C_MOVE_DESC = '" + dt.Rows[i]["RKtype"].ToString() + "',";
                            UpdateSql = UpdateSql + "   T.C_RKRY =SUBSTR( '" + dt.Rows[i]["RKRY"].ToString() + "',0,5),";
                            UpdateSql = UpdateSql + "   T.D_DP_DT =TO_DATE('" + dt.Rows[i]["WEIGHTRQ"].ToString() + "', 'yyyy-mm-dd hh24:mi:ss'),";
                            UpdateSql = UpdateSql + "   T.D_WEIGHT_DT =TO_DATE('" + dt.Rows[i]["WEIGHTRQ"].ToString() + "', 'yyyy-mm-dd hh24:mi:ss'),";

                            UpdateSql = UpdateSql + "   T.D_PRODUCE_DATE =TO_DATE('" + mod.D_PRODUCE_DATE + "', 'yyyy-mm-dd hh24:mi:ss'),";

                            UpdateSql = UpdateSql + "   T.D_RKRQ =to_date( '" + dt.Rows[i]["RQ"].ToString() + "','yyyy-mm-dd hh24:mi:ss')";
                            UpdateSql = UpdateSql + " WHERE T.C_BATCH_NO = '" + dt.Rows[i]["PCH"].ToString() + "' AND T.C_TICK_NO = '" + dt.Rows[i]["GH"].ToString() + "'";
                            int iRes = DbHelperOra.ExecuteSql(UpdateSql);
                            iUpdate = iUpdate + 1;
                        }
                        catch (Exception ex)
                        {
                            string name = "Dal_Interface_FR.TbKCList:PH=" + dt.Rows[i]["PCH"].ToString() + ",  GH=" + dt.Rows[i]["GH"].ToString() + "";
                            string LogSql = "INSERT INTO TI_RF_LOG(C_TYPE, C_LOG, C_NAME) VALUES('同步条码库存信息','" + ex.ToString() + "','" + name + "')";
                            DbHelperOra.ExecuteSql(LogSql);
                            iUpdateE = iUpdateE + 1;
                        }
                    }
                    else
                    {
                        try
                        {
                            //查询订单
                            string sql = "SELECT a.C_ORDER_NO FROM TRP_PLAN_ROLL_ITEM a  INNER JOIN  TRC_ROLL_MAIN b ON a.c_id=b.c_plan_id WHERE b.c_Id = '" + dt.Rows[i]["WGDH"].ToString() + "' ";
                            DataTable oddt = DbHelperOra.Query(sql).Tables[0];
                            string order = oddt.Rows[0]["C_ORDER_NO"].ToString();
                            string InsertSql = "INSERT INTO TRC_ROLL_PRODCUT (C_SALE_AREA,C_LINEWH_AREA_CODE,C_ID,C_BARCODE, C_TRC_ROLL_MAIN_ID, C_LINEWH_CODE, C_LINEWH_LOC_CODE, C_BATCH_NO, C_MAT_CODE, C_MAT_DESC, C_JUDGE_LEV_BP,C_REASON_NAME, C_STL_GRD, C_SPEC, C_DP_GROUP, C_TICK_NO, N_WGT, C_STD_CODE, D_RKRQ, C_MOVE_DESC, C_RKRY, D_WEIGHT_DT, D_MOD_DT, C_ZYX1, C_ZYX2, C_BZYQ, C_GROUP, C_PLANT_ID,  C_STOVE ,C_STA_ID,C_MOVE_TYPE,C_ORDER_NO,C_DESIGN_NO,D_DP_DT,D_PRODUCE_DATE,C_CUST_NO,C_CUST_NAME) VALUES ( '" + C_AREA + "','" + strarea + "','" + dt.Rows[i]["BARCODE"].ToString() + "','" + dt.Rows[i]["BARCODE"].ToString() + "','" + dt.Rows[i]["WGDH"].ToString() + "','" + dt.Rows[i]["CK"].ToString() + "','" + dt.Rows[i]["HW"].ToString() + "','" + dt.Rows[i]["PCH"].ToString() + "','" + dt.Rows[i]["WLH"].ToString() + "','" + dt.Rows[i]["WLMC"].ToString() + "','" + dt.Rows[i]["SX"].ToString() + "','" + dt.Rows[i]["ERRSEASON"].ToString() + "','" + dt.Rows[i]["PH"].ToString() + "','" + spec + "','" + dt.Rows[i]["RKBB"].ToString() + "','" + dt.Rows[i]["GH"].ToString() + "','" + dt.Rows[i]["ZL"].ToString() + "','" + strStdCode + "',to_date( '" + dt.Rows[i]["RQ"].ToString() + "','yyyy-mm-dd hh24:mi:ss'),'" + dt.Rows[i]["RKTYPE"].ToString() + "',SUBSTR( '" + dt.Rows[i]["RKRY"].ToString() + "',0,5), TO_DATE('" + dt.Rows[i]["WEIGHTRQ"].ToString() + "', 'YYYY-MM-DD HH24:MI:SS'), TO_DATE(REPLACE('" + dt.Rows[i]["PRODUCEDATA"].ToString() + "', '.', '-'), 'YYYY-MM-DD HH24:MI:SS'),'" + dt.Rows[i]["VFREE1"].ToString() + "','" + dt.Rows[i]["VFREE2"].ToString() + "','" + dt.Rows[i]["VFREE3"].ToString() + "','" + dt.Rows[i]["SCBB"].ToString() + "','" + dt.Rows[i]["SCX"].ToString() + "','" + dt.Rows[i]["VFREE0"].ToString() + "','" + staid + "','E','" + order + "','" + strDesignNo + "',TO_DATE('" + dt.Rows[i]["WEIGHTRQ"].ToString() + "', 'YYYY-MM-DD HH24:MI:SS'),TO_DATE('" + mod.D_PRODUCE_DATE.ToString() + "', 'YYYY-MM-DD HH24:MI:SS'),'" + custNo + "','" + custName + "')";
                            int a = DbHelperOra.ExecuteSql(InsertSql);
                            iInsert = iInsert + 1;
                        }
                        catch (Exception ex)
                        {
                            string name = "Dal_Interface_FR.TbKCList:PH=" + dt.Rows[i]["PCH"].ToString() + ",  GH=" + dt.Rows[i]["GH"].ToString() + "";
                            string LogSql = "INSERT INTO TI_RF_LOG(C_TYPE, C_LOG, C_NAME) VALUES('同步条码库存信息','" + ex.ToString() + "','" + name + "')";
                            DbHelperOra.ExecuteSql(LogSql);
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
            UPTMWGD(WGDH);
            UpdateWgdRqTime(WGDH, DateTime.Now, DateTime.Now);
            return strResult;
        }

        /// <summary>
        /// 修改完工单扫码入库时间
        /// </summary>
        /// <param name="id"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        public int UpdateWgdRqTime(string id, DateTime start, DateTime end)
        {
            string sql = @"UPDATE TRC_ROLL_WGD TRW SET TRW.D_SWEEP_START= to_date('" + start + "', 'yyyy-mm-dd hh24:mi:ss')    ";
            sql += "  where TRW.C_MAIN_ID='" + id + "'";
            return DbHelperOra.ExecuteSql(sql);
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
        public string TbKCList2(string Barcode, string CK, string HW, string WGDH, string PH, string GH, string GZ)
        {
            string strResult = "";//同步结果

            DataTable dt = GetKCList(Barcode, CK, HW, WGDH, PH, GH, GZ).Tables[0];

            Mod_TRC_ROLL_WGD mod = dal_wgd.GetModelByC_BATCH_NO(dt.Rows[0]["PCH"].ToString());

            string itemInfoId = "";


            //线材实绩数据已有数据
            if (dt.Rows.Count > 0)
            {
                string innerOrderSql = "SELECT A.* FROM TRP_PLAN_ROLL_ITEM A   INNER JOIN  TRC_ROLL_MAIN B ON A.c_id = B.c_plan_id WHERE B.c_Id = '" + mod.C_MAIN_ID + "' ";
                DataTable innerOrderDt = DbHelperOra.Query(innerOrderSql).Tables[0];
                if (innerOrderDt != null && innerOrderDt.Rows.Count > 0)
                {
                    //是合并订单
                    if (innerOrderDt.Rows[0]["N_IS_MERGE"].ToString() == "1")
                    {
                        bool bol = false;
                        Dal_TRP_PLAN_ROLL_ITEM_INFO itemInfo = new Dal_TRP_PLAN_ROLL_ITEM_INFO();
                        //按照订单计划量最大百分比
                        DataTable itemInfoDtps = itemInfo.GetItemInfoAsc(innerOrderDt.Rows[0]["C_ID"].ToString(), decimal.Parse(innerOrderDt.Rows[0]["N_WGT"].ToString()));

                        // 如果所有订单全部完成了则查询计划量最大的一条回值
                        if (itemInfoDtps == null || itemInfoDtps.Rows.Count == 0)
                        {
                            itemInfoDtps = itemInfo.GetItemInfo(innerOrderDt.Rows[0]["C_ID"].ToString());
                        }

                        //更新条码线材实绩至PCI
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            if (bol)
                            {
                                itemInfoDtps= itemInfo.GetItemInfoAsc(innerOrderDt.Rows[0]["C_ID"].ToString(), decimal.Parse(innerOrderDt.Rows[0]["N_WGT"].ToString()));

                                // 如果所有订单全部完成了则查询计划量最大的一条回值
                                if (itemInfoDtps == null || itemInfoDtps.Rows.Count == 0)
                                {
                                    itemInfoDtps = itemInfo.GetItemInfo(innerOrderDt.Rows[0]["C_ID"].ToString());
                                }
                            }

                            itemInfoId = itemInfoDtps.Rows[0]["C_ID"].ToString();
                            string order = itemInfoDtps.Rows[0]["C_ORDER_NO"].ToString();
                            Dal_TMO_ORDER dalOrder = new Dal_TMO_ORDER();
                            var orderM = dalOrder.GetModelByORDERNO(order);


                            string strDesignNo = "";
                            //规格
                            string spec = dt.Rows[i]["GG"].ToString().Replace("mm", "");
                            //自由项
                            string strFree1 = dt.Rows[i]["VFREE1"].ToString();
                            string strFree2 = dt.Rows[i]["VFREE2"].ToString();
                            //执行标准
                            string strStdCode = strFree1.Split('~')[1].Contains("协议") ? strFree2.Split('~')[1].Replace(" ", "").Replace("（", "(").Replace("）", ")") : strFree1.Split('~')[1].Replace(" ", "").Replace("（", "(").Replace("）", ")");
                            //批次号
                            string batch = dt.Rows[i]["PCH"].ToString().Substring(1, 1);
                            //产线
                            string staid = GetSTAbybatch(batch);
                            //货位
                            string strarea = dt.Rows[i]["HW"].ToString();

                            if (strarea.Length > 4)
                            {
                                strarea = strarea.Substring(0, 5);
                            }

                            //设计质量号
                            strDesignNo = Get_Design_No(strStdCode, dt.Rows[i]["PH"].ToString());


                            if (Exists(dt.Rows[i]["PCH"].ToString(), dt.Rows[i]["GH"].ToString()))//当前库已经存在该卷
                            {
                                try
                                {
                                    string UpdateSql = " UPDATE TRC_ROLL_PRODCUT T";
                                    UpdateSql = UpdateSql + "  SET T.N_WGT = '" + dt.Rows[i]["ZL"].ToString() + "',";
                                    UpdateSql = UpdateSql + "   T.C_MOVE_TYPE = 'E',";
                                    UpdateSql = UpdateSql + "   T.c_Barcode = '" + dt.Rows[i]["BARCODE"].ToString() + "',";
                                    UpdateSql = UpdateSql + "   T.C_LINEWH_AREA_CODE = '" + strarea + "',";
                                    UpdateSql = UpdateSql + "   T.C_SALE_AREA = '" + itemInfoDtps.Rows[0]["C_AREA"].ToString() + "',";  //C_SALE_AREA
                                    UpdateSql = UpdateSql + "   T.C_DESIGN_NO = '" + strDesignNo + "',";
                                    UpdateSql = UpdateSql + "   T.C_MAT_CODE = '" + dt.Rows[i]["WLH"].ToString() + "',";
                                    UpdateSql = UpdateSql + "   T.C_MAT_DESC = '" + dt.Rows[i]["WLMC"].ToString() + "',";
                                    UpdateSql = UpdateSql + "   T.C_LINEWH_CODE = '" + dt.Rows[i]["CK"].ToString() + "',";
                                    UpdateSql = UpdateSql + "   T.C_LINEWH_LOC_CODE = '" + dt.Rows[i]["HW"].ToString() + "',";
                                    UpdateSql = UpdateSql + "   T.C_ZYX1 = '" + dt.Rows[i]["VFREE1"].ToString() + "',";
                                    UpdateSql = UpdateSql + "   T.C_ZYX2 = '" + dt.Rows[i]["VFREE2"].ToString() + "',";
                                    UpdateSql = UpdateSql + "   T.C_STOVE = '" + dt.Rows[i]["VFREE0"].ToString() + "',";
                                    UpdateSql = UpdateSql + "   T.C_JUDGE_LEV_BP = '" + dt.Rows[i]["SX"].ToString() + "',";
                                    UpdateSql = UpdateSql + "   T.C_REASON_NAME = '" + dt.Rows[i]["ERRSEASON"].ToString() + "',";
                                    UpdateSql = UpdateSql + "   T.C_MOVE_DESC = '" + dt.Rows[i]["RKtype"].ToString() + "',";
                                    UpdateSql = UpdateSql + "   T.C_RKRY =SUBSTR( '" + dt.Rows[i]["RKRY"].ToString() + "',0,5),";
                                    UpdateSql = UpdateSql + "   T.D_DP_DT =TO_DATE('" + dt.Rows[i]["WEIGHTRQ"].ToString() + "', 'yyyy-mm-dd hh24:mi:ss'),";
                                    UpdateSql = UpdateSql + "   T.D_WEIGHT_DT =TO_DATE('" + dt.Rows[i]["WEIGHTRQ"].ToString() + "', 'yyyy-mm-dd hh24:mi:ss'),";
                                    UpdateSql = UpdateSql + "   T.D_PRODUCE_DATE =TO_DATE('" + mod.D_PRODUCE_DATE + "', 'yyyy-mm-dd hh24:mi:ss'),";
                                    UpdateSql = UpdateSql + "   T.D_RKRQ =to_date( '" + dt.Rows[i]["RQ"].ToString() + "','yyyy-mm-dd hh24:mi:ss')";
                                    UpdateSql = UpdateSql + " WHERE T.C_BATCH_NO = '" + dt.Rows[i]["PCH"].ToString() + "' AND T.C_TICK_NO = '" + dt.Rows[i]["GH"].ToString() + "'";
                                    int iRes = DbHelperOra.ExecuteSql(UpdateSql);

                                }
                                catch (Exception ex)
                                {
                                    string name = "Dal_Interface_FR.TbKCList:PH=" + dt.Rows[i]["PCH"].ToString() + ",  GH=" + dt.Rows[i]["GH"].ToString() + "";
                                    string LogSql = "INSERT INTO TI_RF_LOG(C_TYPE, C_LOG, C_NAME) VALUES('同步条码库存信息','" + ex.ToString() + "','" + name + "')";
                                    DbHelperOra.ExecuteSql(LogSql);

                                }
                            }
                            else
                            {
                                try
                                {
                                    string InsertSql = "INSERT INTO TRC_ROLL_PRODCUT (C_SALE_AREA,C_LINEWH_AREA_CODE,C_ID,C_BARCODE, C_TRC_ROLL_MAIN_ID, C_LINEWH_CODE, C_LINEWH_LOC_CODE, C_BATCH_NO, C_MAT_CODE, C_MAT_DESC, C_JUDGE_LEV_BP,C_REASON_NAME, C_STL_GRD, C_SPEC, C_DP_GROUP, C_TICK_NO, N_WGT, C_STD_CODE, D_RKRQ, C_MOVE_DESC, C_RKRY, D_WEIGHT_DT, D_MOD_DT, C_ZYX1, C_ZYX2, C_BZYQ, C_GROUP, C_PLANT_ID,  C_STOVE ,C_STA_ID,C_MOVE_TYPE,C_ORDER_NO,C_DESIGN_NO,D_DP_DT,D_PRODUCE_DATE,C_STL_GRD_BEFORE,C_CUST_NO,C_CUST_NAME,C_PLAN_ID,C_ORDER_NO1) VALUES ( '" + itemInfoDtps.Rows[0]["C_AREA"].ToString() + "','" + strarea + "','" + dt.Rows[i]["BARCODE"].ToString() + "','" + dt.Rows[i]["BARCODE"].ToString() + "','" + dt.Rows[i]["WGDH"].ToString() + "','" + dt.Rows[i]["CK"].ToString() + "','" + dt.Rows[i]["HW"].ToString() + "','" + dt.Rows[i]["PCH"].ToString() + "','" + dt.Rows[i]["WLH"].ToString() + "','" + dt.Rows[i]["WLMC"].ToString() + "','" + dt.Rows[i]["SX"].ToString() + "','" + dt.Rows[i]["ERRSEASON"].ToString() + "','" + dt.Rows[i]["PH"].ToString() + "','" + spec + "','" + dt.Rows[i]["RKBB"].ToString() + "','" + dt.Rows[i]["GH"].ToString() + "','" + dt.Rows[i]["ZL"].ToString() + "','" + strStdCode + "',to_date( '" + dt.Rows[i]["RQ"].ToString() + "','yyyy-mm-dd hh24:mi:ss'),'" + dt.Rows[i]["RKTYPE"].ToString() + "',SUBSTR( '" + dt.Rows[i]["RKRY"].ToString() + "',0,5), TO_DATE('" + dt.Rows[i]["WEIGHTRQ"].ToString() + "', 'YYYY-MM-DD HH24:MI:SS'), TO_DATE(REPLACE('" + dt.Rows[i]["PRODUCEDATA"].ToString() + "', '.', '-'), 'YYYY-MM-DD HH24:MI:SS'),'" + dt.Rows[i]["VFREE1"].ToString() + "','" + dt.Rows[i]["VFREE2"].ToString() + "','" + dt.Rows[i]["VFREE3"].ToString() + "','" + dt.Rows[i]["SCBB"].ToString() + "','" + dt.Rows[i]["SCX"].ToString() + "','" + dt.Rows[i]["VFREE0"].ToString() + "','" + staid + "','E','" + itemInfoDtps.Rows[0]["C_ORDER_NO"].ToString() + "','" + strDesignNo + "',TO_DATE('" + dt.Rows[i]["WEIGHTRQ"].ToString() + "', 'YYYY-MM-DD HH24:MI:SS'),TO_DATE('" + mod.D_PRODUCE_DATE.ToString() + "', 'YYYY-MM-DD HH24:MI:SS'),'" + itemInfoDtps.Rows[0]["C_ID"].ToString() + "','" + orderM.C_CUST_NO + "','" + orderM.C_CUST_NAME + "','" + itemInfoDtps.Rows[0]["C_ORDER_NO"].ToString() + "','" + itemInfoDtps.Rows[0]["C_ORDER_NO"].ToString() + "')";
                                    DbHelperOra.ExecuteSql(InsertSql);

                                    string updateProdWgt = @"UPDATE TRP_PLAN_ROLL_ITEM_INFO T SET T.N_PROD_WGT=T.N_PROD_WGT+'" + dt.Rows[i]["ZL"].ToString() + "' WHERE T.C_ID='" + itemInfoId + "'";
                                    DbHelperOra.ExecuteSql(updateProdWgt);

                                    string updateStatus = @"UPDATE TRP_PLAN_ROLL_ITEM_INFO T  SET T.N_STATUS=4 WHERE T.C_ID='" + itemInfoId + "' AND T.N_PROD_WGT>=T.N_WGT";
                                    int status = DbHelperOra.ExecuteSql(updateStatus);
                                    if (status > 0)
                                        bol = true;
                                    else
                                        bol = false;

                                }
                                catch (Exception ex)
                                {
                                    string name = "Dal_Interface_FR.TbKCList:PH=" + dt.Rows[i]["PCH"].ToString() + ",  GH=" + dt.Rows[i]["GH"].ToString() + "";
                                    string LogSql = "INSERT INTO TI_RF_LOG(C_TYPE, C_LOG, C_NAME) VALUES('同步条码库存信息','" + ex.ToString() + "','" + name + "')";
                                    DbHelperOra.ExecuteSql(LogSql);
                                }
                            }

                        }



                        //更新条码线材实绩至PCI
                        //for (int i = 0; i < dt.Rows.Count; i++)
                        //{

                        //    //按照订单计划量从小到大的顺序回值
                        //    DataTable itemInfoDts = itemInfo.GetItemInfoAsc(innerOrderDt.Rows[0]["C_ID"].ToString());


                        //    // 如果所有订单全部完成了则查询计划量最大的一条回值
                        //    if (itemInfoDtps == null || itemInfoDtps.Rows.Count == 0)
                        //    {
                        //        itemInfoDtps = itemInfo.GetItemInfo(innerOrderDt.Rows[0]["C_ID"].ToString());
                        //    }

                        //    itemInfoId = itemInfoDtps.Rows[0]["C_ID"].ToString();
                        //    string order = itemInfoDtps.Rows[0]["C_ORDER_NO"].ToString();
                        //    Dal_TMO_ORDER dalOrder = new Dal_TMO_ORDER();
                        //    var orderM = dalOrder.GetModelByORDERNO(order);

                        //    string strDesignNo = "";
                        //    //规格
                        //    string spec = dt.Rows[i]["GG"].ToString().Replace("mm", "");
                        //    //自由项
                        //    string strFree1 = dt.Rows[i]["VFREE1"].ToString();
                        //    string strFree2 = dt.Rows[i]["VFREE2"].ToString();
                        //    //执行标准
                        //    string strStdCode = strFree1.Split('~')[1].Contains("协议") ? strFree2.Split('~')[1].Replace(" ", "").Replace("（", "(").Replace("）", ")") : strFree1.Split('~')[1].Replace(" ", "").Replace("（", "(").Replace("）", ")");
                        //    //批次号
                        //    string batch = dt.Rows[i]["PCH"].ToString().Substring(1, 1);
                        //    //产线
                        //    string staid = GetSTAbybatch(batch);
                        //    //货位
                        //    string strarea = dt.Rows[i]["HW"].ToString();

                        //    if (strarea.Length > 4)
                        //    {
                        //        strarea = strarea.Substring(0, 5);
                        //    }

                        //    //设计质量号
                        //    strDesignNo = Get_Design_No(strStdCode, dt.Rows[i]["PH"].ToString());


                        //    if (Exists(dt.Rows[i]["PCH"].ToString(), dt.Rows[i]["GH"].ToString()))//当前库已经存在该卷
                        //    {
                        //        try
                        //        {
                        //            string UpdateSql = " UPDATE TRC_ROLL_PRODCUT T";
                        //            UpdateSql = UpdateSql + "  SET T.N_WGT = '" + dt.Rows[i]["ZL"].ToString() + "',";
                        //            UpdateSql = UpdateSql + "   T.C_MOVE_TYPE = 'E',";
                        //            UpdateSql = UpdateSql + "   T.c_Barcode = '" + dt.Rows[i]["BARCODE"].ToString() + "',";
                        //            UpdateSql = UpdateSql + "   T.C_LINEWH_AREA_CODE = '" + strarea + "',";
                        //            UpdateSql = UpdateSql + "   T.C_SALE_AREA = '" + itemInfoDtps.Rows[0]["C_AREA"].ToString() + "',";  //C_SALE_AREA
                        //            UpdateSql = UpdateSql + "   T.C_DESIGN_NO = '" + strDesignNo + "',";
                        //            UpdateSql = UpdateSql + "   T.C_MAT_CODE = '" + dt.Rows[i]["WLH"].ToString() + "',";
                        //            UpdateSql = UpdateSql + "   T.C_MAT_DESC = '" + dt.Rows[i]["WLMC"].ToString() + "',";
                        //            UpdateSql = UpdateSql + "   T.C_LINEWH_CODE = '" + dt.Rows[i]["CK"].ToString() + "',";
                        //            UpdateSql = UpdateSql + "   T.C_LINEWH_LOC_CODE = '" + dt.Rows[i]["HW"].ToString() + "',";
                        //            UpdateSql = UpdateSql + "   T.C_ZYX1 = '" + dt.Rows[i]["VFREE1"].ToString() + "',";
                        //            UpdateSql = UpdateSql + "   T.C_ZYX2 = '" + dt.Rows[i]["VFREE2"].ToString() + "',";
                        //            UpdateSql = UpdateSql + "   T.C_STOVE = '" + dt.Rows[i]["VFREE0"].ToString() + "',";
                        //            UpdateSql = UpdateSql + "   T.C_JUDGE_LEV_BP = '" + dt.Rows[i]["SX"].ToString() + "',";
                        //            UpdateSql = UpdateSql + "   T.C_REASON_NAME = '" + dt.Rows[i]["ERRSEASON"].ToString() + "',";
                        //            UpdateSql = UpdateSql + "   T.C_MOVE_DESC = '" + dt.Rows[i]["RKtype"].ToString() + "',";
                        //            UpdateSql = UpdateSql + "   T.C_RKRY =SUBSTR( '" + dt.Rows[i]["RKRY"].ToString() + "',0,5),";
                        //            UpdateSql = UpdateSql + "   T.D_DP_DT =TO_DATE('" + dt.Rows[i]["WEIGHTRQ"].ToString() + "', 'yyyy-mm-dd hh24:mi:ss'),";
                        //            UpdateSql = UpdateSql + "   T.D_WEIGHT_DT =TO_DATE('" + dt.Rows[i]["WEIGHTRQ"].ToString() + "', 'yyyy-mm-dd hh24:mi:ss'),";
                        //            UpdateSql = UpdateSql + "   T.D_PRODUCE_DATE =TO_DATE('" + mod.D_PRODUCE_DATE + "', 'yyyy-mm-dd hh24:mi:ss'),";
                        //            UpdateSql = UpdateSql + "   T.D_RKRQ =to_date( '" + dt.Rows[i]["RQ"].ToString() + "','yyyy-mm-dd hh24:mi:ss')";
                        //            UpdateSql = UpdateSql + " WHERE T.C_BATCH_NO = '" + dt.Rows[i]["PCH"].ToString() + "' AND T.C_TICK_NO = '" + dt.Rows[i]["GH"].ToString() + "'";
                        //            int iRes = DbHelperOra.ExecuteSql(UpdateSql);

                        //        }
                        //        catch (Exception ex)
                        //        {
                        //            string name = "Dal_Interface_FR.TbKCList:PH=" + dt.Rows[i]["PCH"].ToString() + ",  GH=" + dt.Rows[i]["GH"].ToString() + "";
                        //            string LogSql = "INSERT INTO TI_RF_LOG(C_TYPE, C_LOG, C_NAME) VALUES('同步条码库存信息','" + ex.ToString() + "','" + name + "')";
                        //            DbHelperOra.ExecuteSql(LogSql);

                        //        }
                        //    }
                        //    else
                        //    {
                        //        try
                        //        {
                        //            string InsertSql = "INSERT INTO TRC_ROLL_PRODCUT (C_SALE_AREA,C_LINEWH_AREA_CODE,C_ID,C_BARCODE, C_TRC_ROLL_MAIN_ID, C_LINEWH_CODE, C_LINEWH_LOC_CODE, C_BATCH_NO, C_MAT_CODE, C_MAT_DESC, C_JUDGE_LEV_BP,C_REASON_NAME, C_STL_GRD, C_SPEC, C_DP_GROUP, C_TICK_NO, N_WGT, C_STD_CODE, D_RKRQ, C_MOVE_DESC, C_RKRY, D_WEIGHT_DT, D_MOD_DT, C_ZYX1, C_ZYX2, C_BZYQ, C_GROUP, C_PLANT_ID,  C_STOVE ,C_STA_ID,C_MOVE_TYPE,C_ORDER_NO,C_DESIGN_NO,D_DP_DT,D_PRODUCE_DATE,C_STL_GRD_BEFORE,C_CUST_NO,C_CUST_NAME) VALUES ( '" + itemInfoDtps.Rows[0]["C_AREA"].ToString() + "','" + strarea + "','" + dt.Rows[i]["BARCODE"].ToString() + "','" + dt.Rows[i]["BARCODE"].ToString() + "','" + dt.Rows[i]["WGDH"].ToString() + "','" + dt.Rows[i]["CK"].ToString() + "','" + dt.Rows[i]["HW"].ToString() + "','" + dt.Rows[i]["PCH"].ToString() + "','" + dt.Rows[i]["WLH"].ToString() + "','" + dt.Rows[i]["WLMC"].ToString() + "','" + dt.Rows[i]["SX"].ToString() + "','" + dt.Rows[i]["ERRSEASON"].ToString() + "','" + dt.Rows[i]["PH"].ToString() + "','" + spec + "','" + dt.Rows[i]["RKBB"].ToString() + "','" + dt.Rows[i]["GH"].ToString() + "','" + dt.Rows[i]["ZL"].ToString() + "','" + strStdCode + "',to_date( '" + dt.Rows[i]["RQ"].ToString() + "','yyyy-mm-dd hh24:mi:ss'),'" + dt.Rows[i]["RKTYPE"].ToString() + "',SUBSTR( '" + dt.Rows[i]["RKRY"].ToString() + "',0,5), TO_DATE('" + dt.Rows[i]["WEIGHTRQ"].ToString() + "', 'YYYY-MM-DD HH24:MI:SS'), TO_DATE(REPLACE('" + dt.Rows[i]["PRODUCEDATA"].ToString() + "', '.', '-'), 'YYYY-MM-DD HH24:MI:SS'),'" + dt.Rows[i]["VFREE1"].ToString() + "','" + dt.Rows[i]["VFREE2"].ToString() + "','" + dt.Rows[i]["VFREE3"].ToString() + "','" + dt.Rows[i]["SCBB"].ToString() + "','" + dt.Rows[i]["SCX"].ToString() + "','" + dt.Rows[i]["VFREE0"].ToString() + "','" + staid + "','E','" + itemInfoDtps.Rows[0]["C_ORDER_NO"].ToString() + "','" + strDesignNo + "',TO_DATE('" + dt.Rows[i]["WEIGHTRQ"].ToString() + "', 'YYYY-MM-DD HH24:MI:SS'),TO_DATE('" + mod.D_PRODUCE_DATE.ToString() + "', 'YYYY-MM-DD HH24:MI:SS'),'" + itemInfoDtps.Rows[0]["C_ID"].ToString() + "','" + orderM.C_CUST_NO + "','" + orderM.C_CUST_NAME + "')";
                        //            DbHelperOra.ExecuteSql(InsertSql);

                        //            string updateProdWgt = @"UPDATE TRP_PLAN_ROLL_ITEM_INFO T SET T.N_PROD_WGT=T.N_PROD_WGT+'" + dt.Rows[i]["ZL"].ToString() + "' WHERE T.C_ID='" + itemInfoId + "'";
                        //            DbHelperOra.ExecuteSql(updateProdWgt);

                        //            string updateStatus = @"UPDATE TRP_PLAN_ROLL_ITEM_INFO T  SET T.N_STATUS=4 WHERE T.C_ID='" + itemInfoId + "' AND T.N_PROD_WGT>=T.N_WGT";
                        //            DbHelperOra.ExecuteSql(updateStatus);

                        //        }
                        //        catch (Exception ex)
                        //        {
                        //            string name = "Dal_Interface_FR.TbKCList:PH=" + dt.Rows[i]["PCH"].ToString() + ",  GH=" + dt.Rows[i]["GH"].ToString() + "";
                        //            string LogSql = "INSERT INTO TI_RF_LOG(C_TYPE, C_LOG, C_NAME) VALUES('同步条码库存信息','" + ex.ToString() + "','" + name + "')";
                        //            DbHelperOra.ExecuteSql(LogSql);
                        //        }
                        //    }
                        //}

                        //添加完工单 订单计划中间表 关系
                        Mod_TRP_WGD_ITEMINFO m = new Mod_TRP_WGD_ITEMINFO();
                        m.C_ITEM_INFO_ID = itemInfoId;
                        m.C_WGD_ID = WGDH;
                        dalTrpWgdIteminfo.Add(m);

                        //decimal remark2Wgt = 0;

                        //Dal_TRP_PLAN_ROLL_ITEM_INFO itemInfoP = new Dal_TRP_PLAN_ROLL_ITEM_INFO();

                        ////按照订单计划量最大百分比
                        //DataTable itemInfoDtps = itemInfo.GetItemInfoAsc(innerOrderDt.Rows[0]["C_ID"].ToString(), decimal.Parse(innerOrderDt.Rows[0]["N_WGT"].ToString()));
                        //itemInfoDtps = LinqSortDataTable(itemInfoDtps);

                        ////更新条码线材实绩至PCI
                        //for (int i = 0; i < dt.Rows.Count; i++)
                        //{

                        //    itemInfoId = itemInfoDtps.Rows[0]["C_ID"].ToString();
                        //    string order = itemInfoDtps.Rows[0]["C_ORDER_NO"].ToString();
                        //    Dal_TMO_ORDER dalOrder = new Dal_TMO_ORDER();
                        //    var orderM = dalOrder.GetModelByORDERNO(order);

                        //    if (Exists(dt.Rows[i]["PCH"].ToString(), dt.Rows[i]["GH"].ToString()))//当前库已经存在该卷
                        //    {
                        //        string UpdateSql = " UPDATE TRC_ROLL_PRODCUT T ";
                        //        UpdateSql = UpdateSql + " SET  T.C_SALE_AREA = '" + itemInfoDtps.Rows[0]["C_AREA"].ToString() + "',";  //C_SALE_AREA
                        //        UpdateSql = UpdateSql + "   T.C_CUST_NO = '" + orderM.C_CUST_NO + "',";
                        //        UpdateSql = UpdateSql + "   T.C_PLAN_ID = '" + orderM.C_ORDER_NO + "',";
                        //        UpdateSql = UpdateSql + "   T.C_CUST_NAME = '" + orderM.C_CUST_NAME + "' ";
                        //        UpdateSql = UpdateSql + " WHERE T.C_BATCH_NO = '" + dt.Rows[i]["PCH"].ToString() + "' AND T.C_TICK_NO = '" + dt.Rows[i]["GH"].ToString() + "'";
                        //        DbHelperOra.ExecuteSql(UpdateSql);
                        //        remark2Wgt += decimal.Parse(dt.Rows[i]["ZL"].ToString());
                        //    }
                        //}

                        //string updateRemark2 = @" UPDATE TRP_PLAN_ROLL_ITEM_INFO T SET T.C_REMARK2=NVL(T.C_REMARK2,0)+" + remark2Wgt + " WHERE T.C_ID='" + itemInfoId + "'";
                        //DbHelperOra.ExecuteSql(updateRemark2);

                        //更新条码状态
                        UPTMWGD(WGDH);
                        UpdateWgdRqTime(WGDH, DateTime.Now, DateTime.Now);
                    }
                    else
                    { }
                }
            }
            return strResult;
        }


        /// <summary>
        /// 更新条码完工单
        /// </summary>
        /// <param name="dh">单号</param>
        /// <returns></returns>
        public int UPTMWGD(string dh)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("UPDATE SeZJB_WGD_finished SET");
            strSql.Append(" ZJBstatus=1 ");
            strSql.Append("  where wgdh ='" + dh + "' ");
            return DbHelper_SQL.ExecuteSql(strSql.ToString());
        }
        /// <summary>
        /// 通过完工单号获取工位
        /// </summary>
        /// <param name="WGDH"></param>
        /// <returns></returns>
        public string GetSTA(string WGDH)
        {
            string sql = "";
            sql += "select C_STA_ID From TRC_ROLL_WGD WHERE C_MAIN_ID='" + WGDH + "'";
            DataTable dt = DbHelperOra.Query(sql).Tables[0];
            if (dt.Rows.Count > 0)
            {
                return dt.Rows[0]["C_STA_ID"].ToString();
            }
            else
            {
                return "";
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
                            DbHelperOra.ExecuteSql(LogSql);
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
                            DbHelperOra.ExecuteSql(LogSql);
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

        #endregion

        #region 接收条码入库信息

        #endregion

        #region 向条码发送转库单00
        /// <summary>
        /// 通过转库单号获得转库单数据
        /// </summary>
        /// <param name="dhstr">单号字符串</param>
        /// <returns></returns>
        public DataSet GetListByidstr(string dhstr)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_ZKD_NO,C_MAT_CODE,C_MAT_DESC,C_LINEWH_CODE,C_MBLINEWH_CODE,C_STL_GRD,C_JUDGE_LEV_ZH,N_NUM,N_WGT,C_Z_DW,C_F_DW,C_BATCH_NO,C_SPEC,C_STOVE,C_ZYX1,C_ZYX2,C_BZYQ,C_ZYX4,N_STATUS ");
            strSql.Append(" FROM TRC_ROLL_ZKD WHERE N_STATUS=1");
            if (dhstr.Trim() != "")
            {
                strSql.Append(" AND C_ZKD_NO in(" + dhstr + ") ");
            }
            return TransactionHelper.Query(strSql.ToString());
        }
        /// <summary>
        /// 向条码发送转库单
        /// </summary>
        /// <param name="idstr">id字符串</param>
        /// <param name="ckcode">仓库代码</param>
        /// <returns></returns>
        public string SENDZKD(string idstr, string ckcode)
        {
            string LogSql = "";
            string name = "Dal_Interface_FR.SENDZKD";
            DataTable dt = null;
            string zkdstr = "";
            TransactionHelper.BeginTransaction();//开启ora事务
            TransactionHelper_SQL.BeginTransaction();//开启sql事务
            try
            {
                DataTable zkddt = GetListbyIDORDERBY(idstr).Tables[0];//分组统计
                if (zkddt.Rows.Count == 0)
                {
                    return "转库信息查询失败!";
                }
                string zkd = RV.UI.ServerTime.timeNow().Year.ToString() + (Convert.ToInt32(RV.UI.ServerTime.timeNow().Month) > 9 ? RV.UI.ServerTime.timeNow().Month.ToString() : ("0" + RV.UI.ServerTime.timeNow().Month.ToString())) + (Convert.ToInt32(RV.UI.ServerTime.timeNow().Day) > 9 ? RV.UI.ServerTime.timeNow().Day.ToString() : ("0" + RV.UI.ServerTime.timeNow().Day.ToString()));
                long no = 0; //GetZKDNO(zkd);//获取转库单号
                string cksql = "Select C_ID From TPB_LINEWH WHERE C_LINEWH_CODE='" + ckcode + "'";
                DataTable cktb = DbHelperOra.Query(cksql).Tables[0];
                if (cktb.Rows.Count == 0)
                {
                    return ckcode + "目标仓库" + ckcode + "信息查询失败！";
                }
                cksql = cktb.Rows[0]["C_ID"].ToString();
                foreach (DataRow item in zkddt.Rows)
                {
                    if (no != 0)
                    {
                        no = no + 1;
                    }
                    else
                    {
                        no = Convert.ToInt64(zkd + "00001");
                    }
                    zkdstr += "'" + no + "',";
                    string ycksql = "Select C_ID From TPB_LINEWH WHERE C_LINEWH_CODE='" + item["C_LINEWH_CODE"] + "'";
                    DataTable ycktb = DbHelperOra.Query(ycksql).Tables[0];
                    if (ycktb.Rows.Count == 0)
                    {
                        TransactionHelper.RollBack();
                        return "源仓库(" + item["C_LINEWH_CODE"] + ")信息查询失败！";
                    }
                    ycksql = ycktb.Rows[0]["C_ID"].ToString();
                    StringBuilder strSql = new StringBuilder();
                    strSql.Append("INSERT INTO TRC_ROLL_ZKD(C_ZKD_NO,C_MAT_CODE,C_MAT_DESC,C_LINEWH_CODE,C_MBLINEWH_CODE,C_STL_GRD,C_JUDGE_LEV_ZH,N_NUM,N_WGT,C_Z_DW,C_F_DW,C_BATCH_NO,C_SPEC,C_STOVE,C_BZYQ,N_STATUS,C_ZYX1,C_ZYX2,C_EMP_ID,D_PRODUCE_DATE) VALUES('" + no + "','" + item["C_MAT_CODE"] + "','" + item["C_MAT_DESC"] + "','" + ycksql + "','" + cksql + "','" + item["C_STL_GRD"] + "','" + item["C_JUDGE_LEV_ZH"] + "','" + item["N_NUM"] + "','" + item["N_WGT"] + "','件【线材】','吨','" + item["C_BATCH_NO"] + "','" + item["C_SPEC"] + "','" + item["C_STOVE"] + "','" + item["C_BZYQ"] + "',1,'" + item["C_ZYX1"] + "','" + item["C_ZYX2"] + "','" + RV.UI.UserInfo.userID + "',to_date( '" + item["D_PRODUCE_DATE"] + "','yyyy-mm-dd hh24:mi:ss') ) ");
                    if (UPZKDSTATUS(no.ToString(), idstr, item) != Convert.ToInt32(item["N_NUM"]))//更新线材实绩表
                    {
                        TransactionHelper.RollBack();
                        return "更新线材实绩表状态错误！";
                    }
                    if (TransactionHelper.ExecuteSql(strSql.ToString()) == 0)
                    {
                        TransactionHelper.RollBack();
                        return "添加转库单中间表错误！";
                    }
                }
                zkdstr = zkdstr.Substring(0, zkdstr.Length - 1);
                dt = GetListByidstr(zkdstr).Tables[0];//要传输的转库单数据
                                                      //条码
                foreach (DataRow item in dt.Rows)//发送转库单
                {
                    string sql = "";
                    sql += "insert into ReZJB_ZKD(zkdh,sck,tck,wlh,wlmc,pch,sx,jhsl,jhzl,zjldw,fjldw,ph,gg,vfree0,vfree1,vfree2,vfree3,ZJBstatus,insertts,CAPPK) values('" + item["C_ZKD_NO"] + "','" + item["C_LINEWH_CODE"] + "','" + item["C_MBLINEWH_CODE"] + "','" + item["C_MAT_CODE"] + "','" + item["C_MAT_DESC"] + "','" + item["C_BATCH_NO"] + "','" + item["C_JUDGE_LEV_ZH"] + "','" + item["N_NUM"] + "','" + item["N_WGT"] + "','件【线材】','吨','" + item["C_STL_GRD"] + "','" + item["C_SPEC"] + "','" + item["C_STOVE"] + "','" + item["C_ZYX1"] + "','" + item["C_ZYX2"] + "','" + item["C_BZYQ"] + "','0','" + RV.UI.ServerTime.timeNow() + "','" + item["C_ID"] + "')";
                    if (UPZKDZJBSTATUS("'" + item["C_ZKD_NO"] + "'", 3) == 0)
                    {
                        TransactionHelper.RollBack();
                        return "修改转库单中间表状态错误！";
                    }
                    if (TransactionHelper_SQL.ExecuteSql(sql) == 0)
                    {
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
        /// 根据idstr统计线材实绩表
        /// </summary>
        /// <param name="idstr">id字符串</param>
        /// <returns>统计后线材实绩dataset</returns>
        public DataSet GetListbyIDORDERBY(string idstr)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT C_MAT_CODE,C_MAT_DESC,C_LINEWH_CODE,C_BATCH_NO,nvl(C_JUDGE_LEV_ZH,C_JUDGE_LEV_BP)AS C_JUDGE_LEV_ZH,C_STL_GRD,C_SPEC,C_STOVE,C_ZYX1,C_ZYX2,C_BZYQ,SUM(N_WGT) N_WGT,COUNT(1) N_NUM,D_PRODUCE_DATE FROM TRC_ROLL_PRODCUT WHERE 1=1 ");
            if (idstr.Trim() != "")
            {
                strSql.Append(" and C_ID in(" + idstr + ")");
            }
            strSql.Append(" GROUP BY C_MAT_CODE,C_MAT_DESC,C_LINEWH_CODE,C_BATCH_NO,C_JUDGE_LEV_ZH,C_STL_GRD,C_SPEC,C_STOVE,C_ZYX1,C_ZYX2,C_BZYQ,D_PRODUCE_DATE ,C_JUDGE_LEV_BP");
            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 根据转库单变更线材实绩表
        /// </summary>
        /// <param name="zkdstr">转库单字符串</param>
        /// <param name="idstr">id字符串</param>
        /// <returns></returns>
        public int UPZKDSTATUS(string zkdstr, string idstr, DataRow item)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("UPDATE TRC_ROLL_PRODCUT SET");
            strSql.Append(" C_ZKD_NO='" + zkdstr + "',C_MOVE_TYPE='M'");
            strSql.Append("  where C_ID in(" + idstr + ") AND C_MAT_CODE='" + item["C_MAT_CODE"] + "' AND C_MAT_DESC='" + item["C_MAT_DESC"] + "' AND C_BATCH_NO='" + item["C_BATCH_NO"] + "' AND nvl(C_JUDGE_LEV_ZH,C_JUDGE_LEV_BP)='" + item["C_JUDGE_LEV_ZH"] + "' AND C_STL_GRD='" + item["C_STL_GRD"] + "' AND C_SPEC='" + item["C_SPEC"] + "' AND C_STOVE='" + item["C_STOVE"] + "' AND C_BZYQ='" + item["C_BZYQ"] + "' ");

            return TransactionHelper.ExecuteSql(strSql.ToString());
        }
        /// <summary>
        /// 根据idstr变更转款单状态
        /// </summary>
        /// <param name="dhstr">dh字符串</param>
        /// <param name="status">状态1正常2已上传条码3上传失败</param>
        /// <returns></returns>
        public int UPZKDZJBSTATUS(string dhstr, int status)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("UPDATE TRC_ROLL_ZKD SET");
            strSql.Append(" N_STATUS='" + status + "'");
            strSql.Append("  where C_ZKD_NO in(" + dhstr + ") ");
            return TransactionHelper.ExecuteSql(strSql.ToString());
        }

        /// <summary>
        ///根据条码转库单撤销数据
        /// </summary>
        /// <param name="idstr">id字符串</param>
        /// <returns></returns>
        public int CXZKDByIdstr(string idstr)
        {
            string zkdstr = "";
            DataTable dt = GetZKDList(idstr).Tables[0];
            foreach (DataRow item in dt.Rows)
            {
                zkdstr += "'" + item["C_ZKD_NO"] + "',";
            }
            zkdstr = zkdstr.Substring(0, zkdstr.Length - 1);
            if (UPZKD(zkdstr) > 0)
            {
                UPZKDSTATUSBY(zkdstr);
                return 1;
            }
            return 0;
        }
        /// <summary>
        /// 根据idstr统计查询转库单号
        /// </summary>
        /// <param name="idstr">id字符串</param>
        /// <returns>统计后线材实绩dataset</returns>
        public DataSet GetZKDList(string idstr)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT distinct C_ZKD_NO FROM TRC_ROLL_PRODCUT WHERE 1=1 ");
            if (idstr.Trim() != "")
            {
                strSql.Append(" and C_ID in(" + idstr + ")");
            }

            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 撤销变更线材实绩表
        /// </summary>
        /// <param name="zkdstr">转库单字符串</param>
        /// <returns></returns>
        public int UPZKDSTATUSBY(string zkdstr)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("UPDATE TRC_ROLL_PRODCUT SET ");
            strSql.Append("C_MOVE_TYPE='E'");
            strSql.Append("  where C_ZKD_NO in(" + zkdstr + ") ");
            return DbHelperOra.ExecuteSql(strSql.ToString());
        }
        /// <summary>
        /// 修改条码转库单
        /// </summary>
        /// <param name="zkdstr">转库单字符串</param>
        /// <returns>返回int类型 大于0发送成功,等于0发送失败</returns>
        public int UPZKD(string zkdstr)
        {
            string sql = "";
            sql += "Delete ReZJB_ZKD WHERE zkdh in(" + zkdstr + ") and ZJBStatus=0";
            return DbHelper_SQL.ExecuteSql(sql);
        }
        #endregion

        #region 接收条码系统的转库实绩信息00
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
        /// 同步条码转库单信息
        /// </summary>
        /// <param name="path">地址</param>
        /// <returns></returns>
        public string TBZKD(string path)
        {
            string dhstr = "";
            string LogSql = "";
            string name = "Dal_Interface_FR.TBZKD";
            try
            {
                TransactionHelper.BeginTransaction();
                DataTable dhdt = GetZKDHByTM().Tables[0];
                if (dhdt.Rows.Count > 0)
                {
                    foreach (DataRow item in dhdt.Rows)
                    {
                        if (ExistsByZKD(item["ZKDH"].ToString()) == false)
                        {
                            if (UPTMZKD(item["ZKDH"].ToString()) == 0)
                            {
                                return "单号" + item["ZKDH"] + "变更条码中间表异常信息失败！";
                            }
                            continue;
                        }
                        else
                        {
                            //传送条码
                            dhstr += item["ZKDH"] + ",";
                            DataTable kcdhxqdt = QueryTMZKKWByKC(item["ZKDH"].ToString()).Tables[0];
                            List<string> zkdhlist = new List<string>();
                            List<string> qtckdhlist = new List<string>();
                            List<string> fyddhlist = new List<string>();
                            List<string> nulldhlist = new List<string>();
                            List<string> zbdhlist = new List<string>();
                            if (kcdhxqdt.Rows.Count == 0)
                            {
                                TransactionHelper.RollBack();
                                return "单号" + item["ZKDH"] + "未在条码库存查询到信息!";
                            }
                            foreach (DataRow kcxqitem in kcdhxqdt.Rows)
                            {
                                string zkdh = GetZKDDH(kcxqitem["Barcode"].ToString());
                                if (zkdh == "0")
                                {
                                    TransactionHelper.RollBack();
                                    return "打牌序号" + kcxqitem["Barcode"].ToString() + "未找到数据！";
                                }
                                if (zkdh == kcxqitem["ZKDH"].ToString())
                                {
                                    StringBuilder strSql = UPZKD(kcxqitem);
                                    if (TransactionHelper.ExecuteSql(strSql.ToString()) != 1)
                                    {
                                        return "打牌序号" + kcxqitem["Barcode"].ToString() + "变更线材实绩错误！（转库单号）";
                                    }
                                }
                                else
                                {
                                    if (zkdh != "")
                                    {
                                        zkdhlist.Add(zkdh);
                                        StringBuilder strSql = UPZKD(kcxqitem);
                                        if (TransactionHelper.ExecuteSql(strSql.ToString()) != 1)
                                        {
                                            return "打牌序号" + kcxqitem["Barcode"].ToString() + "变更线材实绩错误！（转库单号）";
                                        }
                                    }
                                    else
                                    {
                                        string qtckdh = GetQTCKDH(kcxqitem["Barcode"].ToString());
                                        if (qtckdh != "")
                                        {
                                            qtckdhlist.Add(qtckdh);
                                            StringBuilder strSql = UPZKD(kcxqitem);
                                            if (TransactionHelper.ExecuteSql(strSql.ToString()) != 1)
                                            {
                                                return "打牌序号" + kcxqitem["Barcode"].ToString() + "变更线材实绩错误！（转库单号）";
                                            }
                                        }
                                        else
                                        {
                                            string fyddh = GetFYDDH(kcxqitem["Barcode"].ToString());
                                            if (fyddh != "")
                                            {
                                                fyddhlist.Add(fyddh);
                                                StringBuilder strSql = UPZKD(kcxqitem);
                                                if (TransactionHelper.ExecuteSql(strSql.ToString()) != 1)
                                                {
                                                    return "打牌序号" + kcxqitem["Barcode"].ToString() + "变更线材实绩错误！（转库单号）";
                                                }
                                            }
                                            else
                                            {
                                                string typestr = GetTYPE(kcxqitem["Barcode"].ToString());
                                                if (typestr == "0")
                                                {
                                                    zbdhlist.Add("");
                                                    StringBuilder strSql = UPZKD(kcxqitem);
                                                    if (TransactionHelper.ExecuteSql(strSql.ToString()) != 1)
                                                    {
                                                        return "打牌序号" + kcxqitem["Barcode"].ToString() + "变更线材实绩错误！（转库单号）";
                                                    }
                                                }
                                                else
                                                {
                                                    nulldhlist.Add("");
                                                    StringBuilder strSql = UPZKD(kcxqitem);
                                                    if (TransactionHelper.ExecuteSql(strSql.ToString()) != 1)
                                                    {
                                                        return "打牌序号" + kcxqitem["Barcode"].ToString() + "变更线材实绩错误！（转库单号）";
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                            #region 条码出库信息
                            //DataTable ckxqdt = QueryTMZKKWByCK(item["ZKDH"].ToString()).Tables[0];
                            //foreach (DataRow ckdhitem in ckxqdt.Rows)
                            //{
                            //    string zkdh = GetZKDDH(ckdhitem["Barcode"].ToString());
                            //    if (zkdh == ckdhitem["ZKDH"].ToString())
                            //    {
                            //        StringBuilder strSql = UPZKD(ckdhitem);
                            //        scount += TransactionHelper.ExecuteSql(strSql.ToString());
                            //    }
                            //    if (zkdh != "")
                            //    {
                            //        zkdhlist.Add(zkdh);
                            //        StringBuilder strSql = UPZKD(ckdhitem);
                            //        scount += TransactionHelper.ExecuteSql(strSql.ToString());
                            //    }
                            //    else
                            //    {
                            //        string qtckdh = GetQTCKDH(ckdhitem["Barcode"].ToString());
                            //        if (qtckdh != "")
                            //        {
                            //            qtckdhlist.Add(qtckdh);
                            //            StringBuilder strSql = UPZKD(ckdhitem);
                            //            scount += TransactionHelper.ExecuteSql(strSql.ToString());
                            //        }
                            //        else
                            //        {
                            //            string fyddh = GetFYDDH(ckdhitem["Barcode"].ToString());
                            //            if (fyddh != "")
                            //            {
                            //                fyddhlist.Add(fyddh);
                            //                StringBuilder strSql = UPZKD(ckdhitem);
                            //                scount += TransactionHelper.ExecuteSql(strSql.ToString());
                            //            }
                            //            else
                            //            {
                            //                string typestr = GetTYPE(ckdhitem["Barcode"].ToString());
                            //                if (typestr == "0")
                            //                {
                            //                    zbdhlist.Add("");
                            //                    StringBuilder strSql = UPZKD(ckdhitem);
                            //                    scount += TransactionHelper.ExecuteSql(strSql.ToString());
                            //                }
                            //                else
                            //                {
                            //                    nulldhlist.Add("");
                            //                    StringBuilder strSql = UPZKD(ckdhitem);
                            //                    scount += TransactionHelper.ExecuteSql(strSql.ToString());
                            //                }
                            //            }
                            //        }
                            //    }
                            //}

                            #endregion
                            ///转库单
                            foreach (var wppitem in zkdhlist)
                            {
                                DataTable wppdt = GetWPPDH(item["zkdh"].ToString()).Tables[0];
                                if (wppdt.Rows.Count == 0)
                                {
                                    return "单号" + item["zkdh"].ToString() + "未查询到数据！";
                                }
                                if (UPRPByZKD(wppitem, wppdt.Rows[0]["C_BARCODE"].ToString()) == 0)
                                {
                                    return "打牌序号" + wppdt.Rows[0]["C_BARCODE"].ToString() + "变更线材实绩错误！（转库单号）";
                                }
                            }
                            foreach (var wppitem in qtckdhlist)
                            {
                                DataTable wppdt = GetWPPDH(item["zkdh"].ToString()).Tables[0];
                                if (wppdt.Rows.Count == 0)
                                {
                                    return "单号" + item["zkdh"].ToString() + "未查询到数据！";
                                }
                                if (UPRPByQTCKD(wppitem, wppdt.Rows[0]["C_BARCODE"].ToString()) == 0)
                                {
                                    return "打牌序号" + wppdt.Rows[0]["C_BARCODE"].ToString() + "变更线材实绩错误！（其他出库单号）";
                                }
                            }
                            foreach (var wppitem in fyddhlist)
                            {
                                DataTable wppdt = GetWPPDH(item["zkdh"].ToString()).Tables[0];
                                if (wppdt.Rows.Count == 0)
                                {
                                    return "单号" + item["zkdh"].ToString() + "未查询到数据！";
                                }
                                if (UPRPByFYD(wppitem, wppdt.Rows[0]["C_BARCODE"].ToString()) == 0)
                                {
                                    return "打牌序号" + wppdt.Rows[0]["C_BARCODE"].ToString() + "变更线材实绩错误！（发运单号）";
                                }
                            }
                            foreach (var wppitem in zbdhlist)
                            {
                                DataTable wppdt = GetWPPDH(item["zkdh"].ToString()).Tables[0];
                                if (wppdt.Rows.Count == 0)
                                {
                                    return "单号" + item["zkdh"].ToString() + "未查询到数据！";
                                }
                                if (UPRPByFYD(wppitem, wppdt.Rows[0]["C_BARCODE"].ToString()) == 0)
                                {
                                    return "打牌序号" + wppdt.Rows[0]["C_BARCODE"].ToString() + "变更线材实绩错误！（占用线材）";
                                }
                            }
                            foreach (var wppitem in nulldhlist)
                            {
                                DataTable wppdt = GetWPPDH(item["zkdh"].ToString()).Tables[0];
                                if (wppdt.Rows.Count == 0)
                                {
                                    return "单号" + item["zkdh"].ToString() + "未查询到数据！";
                                }
                                if (UPRPByNULL(wppdt.Rows[0]["C_BARCODE"].ToString()) == 0)
                                {
                                    return "打牌序号" + wppdt.Rows[0]["C_BARCODE"].ToString() + "变更线材实绩错误！（库存线材）";
                                }
                            }
                        }
                        //传送NC
                        if (bll_Interface_NC_ZKCK.SendXml_GP(path, item["ZKDH"].ToString()) == "1")//发送转库单实绩到NC 
                        {
                            TransactionHelper.RollBack();
                            return "传送NC转库出库信息失败！";
                        }
                        if (bll_Interface_NC_ZKRK.SendXml_GP(path, item["ZKDH"].ToString()) == "")//发送转库单实绩到NC 
                        {
                            TransactionHelper.RollBack();
                            return "传送NC转库入库信息失败！";
                        }
                    }
                }
                else
                {
                    return "条码转库单中间表中不存在PCI未接收信息！";
                }
                if (dhstr != "")
                {
                    dhstr = dhstr.Substring(0, dhstr.Length - 1);
                    var arr = dhstr.Split(',');
                    if (UPTMZKDSTATUS(dhstr) != arr.Count())
                    {
                        return "变更条码转库单中间表状态错误！";
                    }
                    TransactionHelper.Commit();
                    return "1";
                }
                else
                {
                    return "条码转库单中间表中不存在PCI可接收的信息！";
                }
            }
            catch (Exception ex)
            {
                LogSql = "INSERT INTO TI_RF_LOG(C_TYPE, C_LOG, C_NAME) VALUES('同步条码转库单信息','" + ex.ToString() + "','" + name + "')";
                DbHelperOra.ExecuteSql(LogSql);
                TransactionHelper.RollBack();
                return "代码异常！";
            }
        }

        private static StringBuilder UPZKD(DataRow kcxqitem)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("UPDATE TRC_ROLL_PRODCUT SET");
            strSql.Append(" C_ZKD_NO='',C_FYDH='',C_QTCKD_NO='', C_MOVE_TYPE = 'E',C_LINEWH_CODE='" + kcxqitem["CK"] + "',C_LINEWH_LOC_CODE='" + kcxqitem["HW"] + "' ");
            strSql.Append("  where C_BARCODE='" + kcxqitem["Barcode"] + "' ");
            return strSql;
        }

        /// <summary>
        /// 通过库存表查询条码转库库位
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
        /// 通过出库表查询条码转库库位
        /// </summary>
        /// <param name="zkdh">转库单号</param>
        /// <returns></returns>
        public DataSet QueryTMZKKWByCK(string zkdh)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT a.ZKDH, a.Barcode, b.CK, b.HW FROM WMS_Bms_Tra_ZKD_Detail a, WMS_Bms_Inv_OutInfo b WHERE a.Barcode = b.Barcode and a.ZKDH ='" + zkdh + "' ");
            return DbHelper_SQL.Query(strSql.ToString());
        }
        /// <summary>
        /// 更新转库单表
        /// </summary>
        /// <param name="dhstr">转库单号</param>
        /// <returns></returns>
        public int UPTMZKDSTATUS(string dhstr)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("UPDATE SeZJB_ZKD_finished SET");
            strSql.Append(" ZJBstatus=1 ");
            strSql.Append("  where zkdh in(" + dhstr + ") ");
            return TransactionHelper_SQL.ExecuteSql(strSql.ToString());
        }
        /// <summary>
        /// 异常后更新转库单表
        /// </summary>
        /// <param name="dh">转库单号</param>
        /// <returns></returns>
        public int UPTMZKD(string dh)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("UPDATE SeZJB_ZKD_finished SET");
            strSql.Append(" ZJBstatus=2,by1='当前单号PCI系统不存在！' ");
            strSql.Append("  where zkdh='" + dh + "' ");
            return TransactionHelper_SQL.ExecuteSql(strSql.ToString());
        }
        /// <summary>
        /// 根据条码实绩更新线材实绩
        /// </summary>
        /// <param name="C_BARCODE">牌号</param>
        /// <returns></returns>
        public int UPRPByNULL(string C_BARCODE)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("UPDATE TRC_ROLL_PRODCUT SET");
            strSql.Append(" C_MOVE_TYPE='E',C_ZKD_NO='',C_FYDH='',C_QTCKD_NO=''");
            strSql.Append("  where C_BARCODE='" + C_BARCODE + "' ");
            return TransactionHelper.ExecuteSql(strSql.ToString());
        }
        /// <summary>
        /// 根据条码实绩更新线材实绩
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
        /// 根据条码实绩更新线材实绩
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
        /// 根据条码实绩更新线材实绩
        /// </summary>
        /// <param name="dh">发运单号</param>
        /// <param name="C_BARCODE">牌号</param>
        /// <returns></returns>
        public int UPRPByFYD(string dh, string C_BARCODE)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("UPDATE TRC_ROLL_PRODCUT SET");
            strSql.Append(" C_MOVE_TYPE='0',C_ZKD_NO='',C_QTCKD_NO='',C_FYDH='" + dh + "'");
            strSql.Append("  where C_BARCODE='" + C_BARCODE + "' ");
            return TransactionHelper.ExecuteSql(strSql.ToString());
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
        /// 根据牌号获取其他出库单号
        /// </summary>
        /// <param name="dh">牌号</param>
        /// <returns></returns>
        public string GetQTCKDH(string Barcode)
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
                return "";
            }
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
        /// 根据牌号获取其他出库单号
        /// </summary>
        /// <param name="dh">牌号</param>
        /// <returns></returns>
        public string GetFYDDH(string Barcode)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT C_FYDH,C_MOVE_TYPE FROM TRC_ROLL_PRODCUT ");
            strSql.Append("  where C_BARCODE='" + Barcode + "' ");
            DataTable dt = DbHelperOra.Query(strSql.ToString()).Tables[0];
            if (dt.Rows.Count > 0)
            {
                return dt.Rows[0]["C_FYDH"].ToString();
            }
            else
            {
                return "";
            }
        }
        /// <summary>
        /// 根据牌号获取线材实绩状态
        /// </summary>
        /// <param name="dh">牌号</param>
        /// <returns></returns>
        public string GetTYPE(string Barcode)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT C_FYDH,C_MOVE_TYPE FROM TRC_ROLL_PRODCUT ");
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
        /// 根据转库单号获取未匹配线材
        /// </summary>
        /// <param name="zkdh">转库单号</param>
        /// <returns></returns>
        public DataSet GetWPPDH(string zkdh)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT C_BARCODE FROM TRC_ROLL_PRODCUT ");
            strSql.Append("  where C_ZKD_NO='" + zkdh + "' AND C_MOVE_TYPE='M' ");
            return TransactionHelper.Query(strSql.ToString());
        }
        /// <summary>
        /// 通过库存表查询条码回传转库单号
        /// </summary>
        /// <returns>DataSet</returns>
        public DataSet GetZKDHByTM()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT ZKDH FROM SeZJB_ZKD_finished  WHERE ZJBstatus!=1");
            return DbHelper_SQL.Query(strSql.ToString());
        }
        /// <summary>
        /// 添加转库操作日志
        /// </summary>
        /// <param name="zkdstr">转库单字符串</param>
        /// <param name="idstr">id字符串</param>
        /// <returns></returns>
        public int AddTMLOG(string barcode, string zytype1, string mtype1, string zytype2, string mtype2, string dhstr1, string dhstr2)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("INSERT INTO TRC_ROLL_TMLOG (" + zytype1 + ",C_BARCODE," + mtype1 + ",C_EMP_ID,D_MOD_DT," + zytype2 + "," + mtype2 + ")");
            strSql.Append(" VALUES('" + dhstr1 + "','" + barcode + "','" + mtype1 + "','1006AA100000000EQS94','" + RV.UI.ServerTime.timeNow() + "','" + dhstr2 + "','" + mtype2 + "')");
            return TransactionHelper.ExecuteSql(strSql.ToString());
        }
        #endregion

        #region 接收条码系统的移库信息oo
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
                    DataTable dt = QueryTMYKKWByKC(dhrow["ywdh"].ToString()).Tables[0];//获取移位详情
                    if (dt.Rows.Count == 0)
                    {
                        message = "该移位单未查询到移位实绩！";
                        continue;
                    }
                    TransactionHelper.BeginTransaction();//开启事务
                    foreach (DataRow item in dt.Rows)
                    {
                        DataTable ydt = GetXCKC(item["Barcode"].ToString()).Tables[0];//获取原线材状态
                        if (ydt.Rows.Count != 1)
                        {
                            message = "牌号" + item["Barcode"].ToString() + "PCI系统不存在！";
                            break;
                        }
                        DataRow data = ydt.Rows[0];
                        string sql = "insert into TRC_ROLLCZ_LOG(C_DH,C_STOVE,C_BATCH_NO,C_TICK_NO,C_STL_GRD,N_WGT,C_STD_CODE,C_SPEC,C_LINEWH_CODE,C_LINEWH_AREA_CODE,C_LINEWH_LOC_CODE,C_YLINEWH_CODE,C_YLINEWH_AREA_CODE,C_YLINEWH_LOC_CODE,C_JUDGE_LEV_ZH,D_CZ_DATE,C_MAT_CODE,C_MAT_DESC,C_BARCODE,N_TYPE) values('" + item["YWDH"] + "','" + data["C_STOVE"] + "','" + data["C_BATCH_NO"] + "','" + data["C_TICK_NO"] + "','" + data["C_STL_GRD"] + "','" + data["N_WGT"] + "','" + data["C_STD_CODE"] + "','" + data["C_SPEC"] + "','" + item["CK"] + "','','" + item["HW"] + "','" + data["C_LINEWH_CODE"] + "','" + data["C_LINEWH_AREA_CODE"] + "','" + data["C_LINEWH_LOC_CODE"] + "','" + data["C_JUDGE_LEV_ZH"] + "', to_date('" + RV.UI.ServerTime.timeNow() + "', 'yyyy-mm-dd hh24:mi:ss'),'" + data["C_MAT_CODE"] + "','" + data["C_MAT_DESC"] + "','" + item["Barcode"] + "','2')";
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
                        UPYWDSTATUS(dhrow["ywdh"].ToString(), "2", message);
                    }
                    UPYWDSTATUS(dhrow["ywdh"].ToString(), "1", "");
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
        /// <summary>
        /// 通过条码移位单中间表查询所有未同步的移位单号
        /// </summary>
        /// <returns></returns>
        public DataSet GetYWD()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT distinct ywdh FROM SeZJB_Shift_Record WHERE ZJBstatus!=1");
            return DbHelper_SQL.Query(strSql.ToString());
        }
        /// <summary>
        /// 通过库存表查询条码移库库位
        /// </summary>
        /// <param name="dh"></param>
        /// <returns></returns>
        public DataSet QueryTMYKKWByKC(string dh)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT a.YWDH, a.Barcode, b.CK, b.HW FROM WMS_Bms_Shi_YWD_item a, WMS_Bms_Inv_Info b WHERE a.Barcode = b.Barcode and a.ywdh='" + dh + "'");

            return DbHelper_SQL.Query(strSql.ToString());
        }
        /// <summary>
        /// 通过出库表查询条码转库库位
        /// </summary>
        /// <returns>DataSet</returns>
        public DataSet QueryTMYKKWByCK()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT a.YWDH, a.Barcode, b.Flag FROM WMS_Bms_Shi_YWD_item a, WMS_Bms_Inv_OutInfo b, SeZJB_Shift_Record c WHERE a.Barcode = b.Barcode and a.YWDH = c.ywdh and c.ZJBstatus=1");
            return DbHelper_SQL.Query(strSql.ToString());
        }
        /// <summary>
        /// 更新移位单表
        /// </summary>
        /// <param name="dhstr">移位单号</param>
        /// <returns></returns>
        public int UPYWDSTATUS(string dhstr, string status, string by1)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("UPDATE SeZJB_Shift_Record SET");
            strSql.Append(" ZJBstatus='" + status + "',by1='" + by1 + "',updatets='" + RV.UI.ServerTime.timeNow() + "'");
            strSql.Append("  where ywdh='" + dhstr + "'  ");
            return DbHelper_SQL.ExecuteSql(strSql.ToString());
        }
        #endregion

        #region 向条码发送其他出库信息
        /// <summary>
        /// 向条码发送其他出库信息
        /// </summary>
        /// <param name="idstr">id字符串</param>
        /// <param name="cph">车牌号</param>
        /// <param name="address">位置</param>
        /// <param name="zdr">制单人</param>
        /// <param name="cklx">出库类型</param>
        /// <param name="shdw">送货单位</param>
        /// <param name="fysj">发运实绩</param>
        /// <returns></returns>
        public string SENDQTCKD(string idstr, string cph, string address, string zdr, string cklx, string shdw, DateTime fysj, string cys, string mbckid, string mbckmc)
        {
            string LogSql = "";
            string name = "Dal_Interface_FR.SENDQTCKD";
            DataTable dt = null;
            try
            {
                DataTable qtcddt = GetListbyIDORDERBY(idstr).Tables[0];//分组统计
                if (qtcddt.Rows.Count == 0)
                {
                    return "其他出库单信息查询失败！";
                }
                string qtckd = RV.UI.ServerTime.timeNow().Year.ToString() + (Convert.ToInt32(RV.UI.ServerTime.timeNow().Month) > 9 ? RV.UI.ServerTime.timeNow().Month.ToString() : ("0" + RV.UI.ServerTime.timeNow().Month.ToString())) + (Convert.ToInt32(RV.UI.ServerTime.timeNow().Day) > 9 ? RV.UI.ServerTime.timeNow().Day.ToString() : ("0" + RV.UI.ServerTime.timeNow().Day.ToString()));
                long no = 0;//GetQTCKNO(qtckd);//获取转库单号
                if (no != 0)
                {
                    no = no + 1;
                }
                else
                {
                    no = Convert.ToInt64(qtckd + "00001");
                }
                StringBuilder strSql = new StringBuilder();
                strSql.Append("INSERT INTO TRC_ROLL_QTCKD(C_QTCKD_NO,C_ADDRESS,C_LIC_PLA_NO,C_CREATE_ID,D_CREATE_DT,N_STATUS,C_TYPE,C_SHDW,D_FYSJ,C_NCDJ,C_CYS,C_MBWH_ID,C_MBWH_NAME) VALUES('" + no + "','" + address + "','" + cph + "','" + zdr + "',to_date('" + RV.UI.ServerTime.timeNow() + "','yyyy-mm-dd hh24:mi:ss'),1,'" + cklx + "','" + shdw + "',to_date('" + fysj + "','yyyy-mm-dd hh24:mi:ss'),'" + no + "','" + cys + "','" + mbckid + "','" + mbckmc + "') ");
                TransactionHelper.BeginTransaction();//开启事务ora
                TransactionHelper_SQL.BeginTransaction();//开启事务sql
                if (TransactionHelper.ExecuteSql(strSql.ToString()) == 0)//生成其他出库单
                {
                    TransactionHelper.RollBack();
                    return "生成其他出库单错误！";
                }
                foreach (DataRow item in qtcddt.Rows)
                {
                    StringBuilder strSql1 = new StringBuilder();
                    strSql1.Append("INSERT INTO TRC_ROLL_QTCKD_ITEM(C_QTCKD_NO,C_BATCH_NO,C_JUDGE_LEV_ZH,C_MAT_CODE,C_MAT_DESC,C_STL_GRD,C_SPEC,N_NUM,N_WGT,C_Z_DW,C_F_DW,C_STOVE,C_BZYQ,N_STATUS,C_LINEWH_CODE,C_ZYX1,C_ZYX2) VALUES('" + no + "','" + item["C_BATCH_NO"] + "','" + item["C_JUDGE_LEV_ZH"] + "','" + item["C_MAT_CODE"] + "','" + item["C_MAT_DESC"] + "','" + item["C_STL_GRD"] + "','" + item["C_SPEC"] + "','" + item["N_NUM"] + "','" + item["N_WGT"] + "','件【线材】','吨','" + item["C_STOVE"] + "','" + item["C_BZYQ"] + "',1,'" + item["C_LINEWH_CODE"] + "','" + item["C_ZYX1"] + "','" + item["C_ZYX2"] + "') ");
                    if (TransactionHelper.ExecuteSql(strSql1.ToString()) == 0)//生成其他出库单详情
                    {
                        TransactionHelper.RollBack();
                        return "生成其他出库单详情错误！";
                    }
                    if (UPQTCKSTATUS(item, no.ToString(), idstr) == 0)//更新线材实绩表)
                    {
                        TransactionHelper.RollBack();
                        return "变更线材实绩错误！";
                    }

                }
                dt = GetListByQTCKdhstr(no.ToString()).Tables[0];//要传输的其他出库单数据
                if (dt.Rows.Count == 0)
                {
                    TransactionHelper.RollBack();
                    TransactionHelper_SQL.RollBack();
                    return "查询要传输的转库单数据错误！";
                }
                if (ADDQTCKD(dt.Rows[0]) != 1)//发送出库单
                {
                    TransactionHelper.RollBack();
                    TransactionHelper_SQL.RollBack();
                    return "上传条码其他出库单中间表错误！";
                }
                dt = GetListByQTCKdhXQstr(no.ToString()).Tables[0]; //要传输的其他出库单详情数据
                if (dt.Rows.Count == 0)
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
        /// 通过出库单号获得出库单数据
        /// </summary>
        /// <param name="dhstr">出库单号字符串</param>
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
        /// 通过出库单号获得出库单详情数据
        /// </summary>
        /// <param name="dhstr">出库单号字符串</param>
        /// <returns></returns>
        public DataSet GetListByQTCKdhXQstr(string dhstr)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_QTCKD_NO,C_MAT_CODE,C_MAT_DESC,C_STL_GRD,C_JUDGE_LEV_ZH,N_NUM,N_WGT,C_Z_DW,C_F_DW,C_BATCH_NO,C_SPEC,C_STOVE,C_ZYX1,C_ZYX2,C_BZYQ,C_ZYX4,N_STATUS ");
            strSql.Append(" FROM TRC_ROLL_QTCKD_ITEM WHERE N_STATUS=1");

            if (dhstr.Trim() != "")
            {
                strSql.Append(" AND C_QTCKD_NO in(" + dhstr + ") ");
            }
            return TransactionHelper.Query(strSql.ToString());
        }

        /// <summary>
        /// 生成其他出库单和其他出库单详情
        /// </summary>
        /// <param name="idstr">id字符串</param>
        /// <param name="cph">车牌号</param>
        /// <param name="address">地址</param>
        /// <param name="zdr">制单人</param>
        /// <param name="cklx">出库类型</param>
        /// <param name="shdw">送货单位</param>
        /// <param name="fysj">发运时间</param>
        /// <returns>返回其他出库单字符串</returns>
        public string SCQTCKD(string idstr, string cph, string address, string zdr, string cklx, string shdw, DateTime fysj, string cys, string mbckid, string mbckmc)
        {
            DataTable qtcddt = GetListbyIDORDERBY(idstr).Tables[0];//分组统计
            string qtckd = RV.UI.ServerTime.timeNow().Year.ToString() + RV.UI.ServerTime.timeNow().Month.ToString() + RV.UI.ServerTime.timeNow().Day.ToString();
            long no = 0;// GetQTCKNO(qtckd);//获取转库单号
            if (no != 0)
            {
                no = no + 1;
            }
            else
            {
                no = Convert.ToInt64(qtckd + "00001");
            }
            StringBuilder strSql = new StringBuilder();
            strSql.Append("INSERT INTO TRC_ROLL_QTCKD(C_QTCKD_NO,C_ADDRESS,C_LIC_PLA_NO,C_CREATE_ID,D_CREATE_DT,N_STATUS,C_TYPE,C_SHDW,D_FYSJ,C_NCDJ,C_CYS,C_MBWH_ID,C_MBWH_NAME) VALUES('" + no + "','" + address + "','" + cph + "','" + zdr + "',to_date('" + RV.UI.ServerTime.timeNow() + "','yyyy-mm-dd hh24:mi:ss'),1,'" + cklx + "','" + shdw + "',to_date('" + fysj + "','yyyy-mm-dd hh24:mi:ss'),'" + no + "','" + cys + "','" + mbckid + "','" + mbckmc + "') ");
            if (TransactionHelper.ExecuteSql(strSql.ToString()) == 0)//生成其他出库单
            {
                TransactionHelper.RollBack();
                return "-1";
            }

            foreach (DataRow item in qtcddt.Rows)
            {
                StringBuilder strSql1 = new StringBuilder();
                strSql1.Append("INSERT INTO TRC_ROLL_QTCKD_ITEM(C_QTCKD_NO,C_BATCH_NO,C_JUDGE_LEV_ZH,C_MAT_CODE,C_MAT_DESC,C_STL_GRD,C_SPEC,N_NUM,N_WGT,C_Z_DW,C_F_DW,C_STOVE,C_BZYQ,N_STATUS,C_LINEWH_CODE,C_ZYX1,C_ZYX2) VALUES('" + no + "','" + item["C_BATCH_NO"] + "','" + item["C_JUDGE_LEV_ZH"] + "','" + item["C_MAT_CODE"] + "','" + item["C_MAT_DESC"] + "','" + item["C_STL_GRD"] + "','" + item["C_SPEC"] + "','" + item["N_NUM"] + "','" + item["N_WGT"] + "','件【线材】','吨','" + item["C_STOVE"] + "','" + item["C_BZYQ"] + "',1,'" + item["C_LINEWH_CODE"] + "','" + item["C_ZYX1"] + "','" + item["C_ZYX2"] + "') ");
                TransactionHelper.ExecuteSql(strSql1.ToString());//生成其他出库单详情
                UPQTCKSTATUS(item, no.ToString(), idstr);//更新线材实绩表
            }

            return "";
        }
        /// <summary>
        /// 更新线材实绩
        /// </summary>
        /// <param name="dhstr">转库单号</param>
        /// <returns></returns>
        public int UPQTCKSTATUS(DataRow dr, string qtckd, string idstr)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("UPDATE TRC_ROLL_PRODCUT SET");
            strSql.Append(" C_QTCKD_NO='" + qtckd + "',C_MOVE_TYPE='QC'");
            strSql.Append("  where C_ID in(" + idstr + ") ");
            return TransactionHelper.ExecuteSql(strSql.ToString());
        }
        /// <summary>
        ///根据条码其他出库单撤销数据
        /// </summary>
        /// <param name="idstr">id字符串</param>
        /// <returns></returns>
        public int CXQTCKDByIdstr(string idstr)
        {
            string qtckdstr = "";
            DataTable dt = GetQTCKDList(idstr).Tables[0];
            foreach (DataRow item in dt.Rows)
            {
                qtckdstr += "'" + item["C_QTCKD_NO"] + "',";
            }
            qtckdstr = qtckdstr.Substring(0, qtckdstr.Length - 1);
            if (UPQTCKD(qtckdstr) > 0)
            {
                UPQTCKDITEM(qtckdstr);
                UPQTCKDSTATUSBY(qtckdstr);
                return 1;
            }
            return 0;
        }
        /// <summary>
        /// 根据idstr统计查询其他出库号
        /// </summary>
        /// <param name="idstr">id字符串</param>
        /// <returns>统计后线材实绩dataset</returns>
        public DataSet GetQTCKDList(string idstr)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT C_QTCKD_NO FROM TRC_ROLL_PRODCUT WHERE 1=1 ");
            if (idstr.Trim() != "")
            {
                strSql.Append(" and C_ID in(" + idstr + ")");
            }

            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 撤销变更线材实绩表
        /// </summary>
        /// <param name="qtckdstr">其他出库单符串</param>
        /// <returns></returns>
        public int UPQTCKDSTATUSBY(string qtckdstr)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("UPDATE TRC_ROLL_PRODCUT SET ");
            strSql.Append("C_MOVE_TYPE='E',C_QTCKD_NO=''");
            strSql.Append("  where C_QTCKD_NO in(" + qtckdstr + ") ");
            return DbHelperOra.ExecuteSql(strSql.ToString());
        }
        /// <summary>
        /// 修改其他出库单子表
        /// </summary>
        /// <param name="qtckdstr">其他出库单字符串</param>
        /// <returns>返回int类型 大于0发送成功,等于0发送失败</returns>
        public int UPQTCKDITEM(string qtckdstr)
        {
            string sql = "";
            sql += "Delete ReZJB_QTCKD_Item WHERE ckdh in(" + qtckdstr + ") and ZJBStatus=0";
            return DbHelper_SQL.ExecuteSql(sql);
        }
        /// <summary>
        /// 修改其他出库单
        /// </summary>
        /// <param name="qtckdstr">其他出库单字符串</param>
        /// <returns>返回int类型 大于0发送成功,等于0发送失败</returns>
        public int UPQTCKD(string qtckdstr)
        {
            string sql = "";
            sql += "Delete ReZJB_QTCKD WHERE ckdh in(" + qtckdstr + ") and ZJBStatus=0";
            return DbHelper_SQL.ExecuteSql(sql);
        }
        #endregion

        #region 接收条码的其他出实绩  
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
        /// 同步条码其他出库单信息
        /// </summary>
        /// <returns></returns>
        public string TBQTCKD(string xmlFileName)
        {
            string dhstr = "";
            string LogSql = "";
            string name = "Dal_Interface_FR.TBYWD";
            int count = 0;
            try
            {
                DataTable dt = QueryQTCKD().Tables[0];
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow item in dt.Rows)
                    {
                        if (ExistsByQTCKD(item["CKDH"].ToString()) == false)
                        {
                            if (YCUPTMQTCKD(item["CKDH"].ToString()) == 0)
                            {
                                return "单号" + item["CKDH"] + "PCI系统不存在该其他出库单号";
                            }
                            continue;
                        }
                        else
                        {
                            //传送条码
                            DataTable ckdt = QueryQTCKDByCK(item["CKDH"].ToString()).Tables[0];
                            List<string> zkdhlist = new List<string>();
                            List<string> qtckdhlist = new List<string>();
                            List<string> fyddhlist = new List<string>();
                            List<string> nulldhlist = new List<string>();
                            List<string> zbdhlist = new List<string>();
                            count += ckdt.Rows.Count;
                            if (count > 0)
                            {
                                foreach (DataRow xqitem in ckdt.Rows)
                                {
                                    string ckdh = GetQTCKDH(xqitem["Barcode"].ToString());
                                    if (item["CKDH"].ToString() == ckdh)
                                    {
                                        StringBuilder strSql = UPQTCKD(xqitem);
                                        if (TransactionHelper.ExecuteSql(strSql.ToString()) != 1)
                                        {
                                            return "打牌序号" + xqitem["Barcode"] + "更新线材实绩状态错误（其他出库单）";
                                        }
                                    }
                                    else
                                    {
                                        if (ckdh != "")
                                        {
                                            qtckdhlist.Add(ckdh);
                                            StringBuilder strSql = UPQTCKD(xqitem);
                                            if (TransactionHelper.ExecuteSql(strSql.ToString()) != 1)
                                            {
                                                return "打牌序号" + xqitem["Barcode"] + "更新线材实绩状态错误（其他出库单）";
                                            }
                                        }
                                        else
                                        {
                                            string zkdh = GetQTCKDH(xqitem["Barcode"].ToString());
                                            if (zkdh != "")
                                            {
                                                zkdhlist.Add(zkdh);
                                                StringBuilder strSql = UPQTCKD(xqitem);
                                                if (TransactionHelper.ExecuteSql(strSql.ToString()) != 1)
                                                {
                                                    return "打牌序号" + xqitem["Barcode"] + "更新线材实绩状态错误（其他出库单）";
                                                }
                                            }
                                            else
                                            {
                                                string fyddh = GetFYDDH(xqitem["Barcode"].ToString());
                                                if (fyddh != "")
                                                {
                                                    fyddhlist.Add(fyddh);
                                                    StringBuilder strSql = UPQTCKD(xqitem);
                                                    if (TransactionHelper.ExecuteSql(strSql.ToString()) != 1)
                                                    {
                                                        return "打牌序号" + xqitem["Barcode"] + "更新线材实绩状态错误（其他出库单）";
                                                    }
                                                }
                                                else
                                                {
                                                    string type = GetTYPE(xqitem["Barcode"].ToString());
                                                    if (type == "0")
                                                    {
                                                        zbdhlist.Add("");
                                                        StringBuilder strSql = UPQTCKD(xqitem);
                                                        if (TransactionHelper.ExecuteSql(strSql.ToString()) != 1)
                                                        {
                                                            return "打牌序号" + xqitem["Barcode"] + "更新线材实绩状态错误（其他出库单）";
                                                        }
                                                    }
                                                    else
                                                    {
                                                        nulldhlist.Add("");
                                                        StringBuilder strSql = UPQTCKD(xqitem);
                                                        if (TransactionHelper.ExecuteSql(strSql.ToString()) != 1)
                                                        {
                                                            return "打牌序号" + xqitem["Barcode"] + "更新线材实绩状态错误（其他出库单）";
                                                        }
                                                    }
                                                }
                                            }
                                        }

                                    }
                                }
                                foreach (var wppitem in zkdhlist)
                                {
                                    DataTable wppdt = GetWPPQTCKDH(item["CKDH"].ToString()).Tables[0];
                                    if (wppdt.Rows.Count == 0)
                                    {
                                        return "单号" + item["zkdh"].ToString() + "未查询到数据！";
                                    }
                                    if (UPRPByZKD(wppitem, wppdt.Rows[0]["C_BARCODE"].ToString()) != 1)
                                    {
                                        return "打牌序号" + wppdt.Rows[0]["C_BARCODE"] + "更新线材实绩状态错误（转库单）";
                                    }

                                }
                                foreach (var wppitem in qtckdhlist)
                                {
                                    DataTable wppdt = GetWPPQTCKDH(item["CKDH"].ToString()).Tables[0];
                                    if (wppdt.Rows.Count == 0)
                                    {
                                        return "单号" + item["zkdh"].ToString() + "未查询到数据！";
                                    }
                                    if (UPRPByQTCKD(wppitem, wppdt.Rows[0]["C_BARCODE"].ToString()) != 1)
                                    {
                                        return "打牌序号" + wppdt.Rows[0]["C_BARCODE"] + "更新线材实绩状态错误（其他出库单）";
                                    }
                                }
                                foreach (var wppitem in fyddhlist)
                                {
                                    DataTable wppdt = GetWPPQTCKDH(item["CKDH"].ToString()).Tables[0];
                                    if (wppdt.Rows.Count == 0)
                                    {
                                        return "单号" + item["zkdh"].ToString() + "未查询到数据！";
                                    }
                                    if (UPRPByFYD(wppitem, wppdt.Rows[0]["C_BARCODE"].ToString()) != 1)
                                    {
                                        return "打牌序号" + wppdt.Rows[0]["C_BARCODE"] + "更新线材实绩状态错误（其他出库单）";
                                    }
                                }
                                foreach (var wppitem in nulldhlist)
                                {
                                    DataTable wppdt = GetWPPQTCKDH(item["CKDH"].ToString()).Tables[0];
                                    if (wppdt.Rows.Count == 0)
                                    {
                                        return "单号" + item["zkdh"].ToString() + "未查询到数据！";
                                    }
                                    if (UPRPByNULL(wppdt.Rows[0]["C_BARCODE"].ToString()) != 1)
                                    {
                                        return "打牌序号" + wppdt.Rows[0]["C_BARCODE"] + "更新线材实绩状态错误（库存）";
                                    }
                                }
                                foreach (var wppitem in zbdhlist)
                                {
                                    DataTable wppdt = GetWPPQTCKDH(item["CKDH"].ToString()).Tables[0];
                                    if (wppdt.Rows.Count == 0)
                                    {
                                        return "单号" + item["zkdh"].ToString() + "未查询到数据！";
                                    }
                                    if (UPRPByFYD("", wppdt.Rows[0]["C_BARCODE"].ToString()) != 1)
                                    {
                                        return "打牌序号" + wppdt.Rows[0]["C_BARCODE"] + "更新线材实绩状态错误（占用）";
                                    }
                                }
                            }
                            else
                            {
                                return "单号" + item["CKDH"] + "条码信息不存在！";
                            }
                            //传送NC
                            DataTable itemdt = GetListByQTCKdhXQstr(item["ckdh"].ToString()).Tables[0]; //要传输的出库单数据
                            foreach (DataRow item1 in itemdt.Rows)
                            {
                                if (bll_Interface_NC_QTCK.SendXml_GP(xmlFileName, item1["C_QTCKD_NO"].ToString()) != "1")//发送其他出库单实绩到NC
                                {
                                    return "单号" + item1["C_QTCKD_NO"] + "其他出库信息发送NC失败！";
                                }
                                if (bll_Interface_NC_QTRK.SendXml_GP(xmlFileName, item1["C_QTCKD_NO"].ToString()) != "1")//发送其他出库单实绩到NC
                                {
                                    return "单号" + item1["C_QTCKD_NO"] + "其他入库信息发送NC失败！";
                                }
                            }
                        }
                    }
                    if (dhstr != "")
                    {
                        if (UPQTCKDSTATUS(dhstr) == count)
                        {
                            return "更新条码其他出库单中间表错误";
                        }
                    }
                    return "";
                }
                else
                {
                    return "条码不存在未上传的其他出库单信息！";
                }
            }
            catch (Exception ex)
            {
                LogSql = "INSERT INTO TI_RF_LOG(C_TYPE, C_LOG, C_NAME) VALUES('同步条码其他出库单信息','" + ex.ToString() + "','" + name + "')";
                DbHelperOra.ExecuteSql(LogSql);
                return "代码异常！";
            }
        }
        public void RFLOG(string type, string message)
        {
            string sql = "INSERT INTO TI_RF_LOG(C_TYPE, C_LOG) VALUES('" + type + "','" + message + "')";
            DbHelperOra.ExecuteSql(sql);
        }
        private static StringBuilder UPQTCKD(DataRow item)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("UPDATE TRC_ROLL_PRODCUT SET C_ZKD_NO='',C_QTCKD_NO=''");
            strSql.Append(",C_MOVE_TYPE = 'QE' ");
            strSql.Append("  where C_BARCODE='" + item["Barcode"] + "' ");
            return strSql;
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
        /// 通过出库表查询条码其他出库单实绩
        /// </summary>
        /// <returns>DataSet</returns>
        public DataSet QueryQTCKD()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT ckdh FROM SeZJB_QTCKD_finished  WHERE ZJBstatus!=1");
            return DbHelper_SQL.Query(strSql.ToString());
        }
        /// <summary>
        /// 异常更新其他出库单表
        /// </summary>
        /// <param name="dh">其他出库单</param>
        /// <returns></returns>
        public int YCUPTMQTCKD(string dh)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("UPDATE SeZJB_QTCKD_finished SET");
            strSql.Append(" ZJBstatus=2,by1='当前单号PCI系统不存在！' ");
            strSql.Append("  where zkdh='" + dh + "' ");
            return DbHelper_SQL.ExecuteSql(strSql.ToString());
        }
        /// <summary>
        /// 更新其他出库单
        /// </summary>
        /// <param name="dhstr">移位单号</param>
        /// <returns></returns>
        public int UPQTCKDSTATUS(string dhstr)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("UPDATE SeZJB_QTCKD_finished SET");
            strSql.Append(" ZJBstatus=1 ");
            strSql.Append("  where ywdh in(" + dhstr.Substring(0, dhstr.Length - 1) + ") ");
            return DbHelper_SQL.ExecuteSql(strSql.ToString());
        }
        #endregion

        #region 接收条码其他入信息（退库）

        #endregion

        #region 向条码发送发运单信息
        /// <summary>
        /// 获取最新的转库单号
        /// </summary>
        /// <param name="fydh">发运单</param>
        /// <returns></returns>
        public string GetCKDNO(string fydh)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select MAX(C_CKDH) ");
            strSql.Append(" FROM TMD_DISPATCH_TMZJB WHERE 1=1 ");
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
        /// 向条码发送发运单
        /// </summary>
        /// <param name="idstr">id字符串</param>
        /// <returns>返回int类型 1为转入成功,等于0代码异常-1导入PCI中间表错误-2导入条码中间表错误</returns>
        public string SENDFYD(string fydh)
        {
            string LogSql = "";
            string name = "Dal_Interface_FR.SENDFYD";
            try
            {
                DataTable dt = GetListByFYDstr(fydh).Tables[0];//要传输的发运单数据
                if (dt.Rows.Count == 0)
                {
                    return "单号" + fydh + "数据查询失败！";
                }
                return ADDFYDToZJB(dt);//发送发运单
            }
            catch (Exception ex)
            {
                LogSql = "INSERT INTO TI_RF_LOG(C_TYPE, C_LOG, C_NAME) VALUES('向条码发送发运单','" + ex.ToString() + "','" + name + "')";
                DbHelperOra.ExecuteSql(LogSql);
                return "代码错误";
            }
        }
        /// <summary>
        /// 通过发运单号获得发运单数据
        /// </summary>
        /// <param name="fydh">发运单号</param>
        /// <returns></returns>
        public DataSet GetListByFYDstr(string fydh)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select b.n_Wgt, N_NUM,b.c_dispatch_id,b.c_Send_Stock,a.c_Shipvia,a.c_Lic_Pla_No,b.c_Mat_Code, b.c_Mat_Name, a.c_Atstation, a.c_Business_Dept, a.c_Business_Id, a.c_Create_Id, a.d_Create_Dt, b.c_Stl_Grd, b.c_std_code, b.c_Spec, c.c_Free1, c.c_Free2, c.c_Pack, c.c_area, c.c_cust_no, d.c_checkstate_name from TMD_DISPATCH a, TMD_DISPATCHDETAILS b, TMO_ORDER c, TQB_CHECKSTATE d WHERE a.c_id = b.c_dispatch_id AND b.c_no = c.c_order_no AND b.c_qualiry_lev = d.C_CHECKSTATE_NAME AND d.C_REMARK=c.C_XGID");
            if (fydh.Trim() != "")
            {
                strSql.Append(" AND a.C_ID ='" + fydh + "' ");
            }
            strSql.Append(" GROUP BY b.c_dispatch_id, b.c_Send_Stock, a.c_Shipvia, a.c_Lic_Pla_No, b.c_Mat_Code, b.c_Mat_Name, a.c_Atstation, a.c_Business_Dept, a.c_Business_Id, a.c_Create_Id, a.d_Create_Dt, b.c_Stl_Grd, b.c_std_code, b.c_Spec, c.c_Free1, c.c_Free2, c.c_Pack, c.c_area, c.c_cust_no, d.c_checkstate_name");
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
            strSql.Append("select * from TMD_DISPATCH_TMZJB WHERE 1=1");
            if (dhstr.Trim() != "")
            {
                strSql.Append(" AND C_DISPATCH_ID ='" + dhstr + "' ");
            }
            return TransactionHelper.Query(strSql.ToString());
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

            return DbHelperOra.ExecuteSql(strSql.ToString());
        }
        /// <summary>
        /// 发送发运单到中间表
        /// </summary>
        /// <param name="dt">要发送的集合</param>
        /// <returns></returns>
        public string ADDFYDToZJB(DataTable dt)
        {
            TransactionHelper_SQL.BeginTransaction();
            TransactionHelper.BeginTransaction();
            foreach (DataRow item in dt.Rows)
            {
                string deptsql = "Select * From TS_DEPT WHERE C_ID='" + item["C_BUSINESS_DEPT"] + "'";
                DataTable depttb = DbHelperOra.Query(deptsql).Tables[0];
                deptsql = depttb.Rows[0]["C_NAME"].ToString();
                string ywysql = "Select * From TS_SALE_EMP WHERE C_ID='" + item["C_BUSINESS_ID"] + "'";
                DataTable ywytb = DbHelperOra.Query(ywysql).Tables[0];
                ywysql = ywytb.Rows[0]["C_NAME"].ToString();
                string zdrsql = "Select * From TS_USER WHERE C_ID='" + item["C_CREATE_ID"] + "'";
                DataTable zdrtb = DbHelperOra.Query(zdrsql).Tables[0];
                zdrsql = zdrtb.Rows[0]["C_NAME"].ToString();
                string cksql = "Select * From TPB_LINEWH WHERE C_ID='" + item["C_SEND_STOCK"] + "'";
                DataTable cktb = DbHelperOra.Query(cksql).Tables[0];
                cksql = cktb.Rows[0]["C_ID"].ToString();
                string sql = "";
                sql += "insert into TMD_DISPATCH_TMZJB(C_DISPATCH_ID,C_SEND_STOCK,C_NO,C_SHIPVIA,C_LIC_PLA_NO,C_MAT_CODE,C_MAT_NAME,C_JUDGE_LEV_ZH,N_NUM,N_WGT,C_Z_DW,C_F_DW,C_ATSTATION,C_BUSINESS_DEPT,C_BUSINESS_ID,C_CREATE_ID,D_CREATE_DT,C_STL_GRD,C_SPEC,C_ZYX1,C_ZYX2,C_BZYQ,N_STATUS,C_AREA) values('" + item["C_DISPATCH_ID"] + "','" + cksql + "','" + item["c_cust_no"] + "','" + item["C_SHIPVIA"] + "','" + item["C_LIC_PLA_NO"] + "','" + item["C_MAT_CODE"] + "','" + item["C_MAT_NAME"] + "','" + item["c_checkstate_name"] + "','" + item["N_NUM"] + "','" + item["N_WGT"] + "','件【线材】','吨','" + item["C_ATSTATION"] + "','" + deptsql + "','" + ywysql + "','" + zdrsql + "',to_date('" + item["D_CREATE_DT"] + "','yyyy-mm-dd hh24:mi:ss'),'" + item["C_STL_GRD"] + "','" + item["C_SPEC"] + "','" + item["c_Free1"] + "','" + item["c_Free2"] + "','" + item["c_Pack"] + "','1','" + item["c_area"] + "')";
                if (TransactionHelper.ExecuteSql(sql) == 0)
                {
                    TransactionHelper.RollBack();
                    TransactionHelper_SQL.RollBack();
                    return "添加发运单中间表错误！";
                }
                DataTable dt1 = GetListByDH(item["C_DISPATCH_ID"].ToString()).Tables[0];//要传输的发运单数据
                foreach (DataRow item1 in dt1.Rows)
                {
                    sql = "";
                    sql += "insert into ReZJB_FYD(fydh,ck,khbm,yslb,cph,wlh,wlmc,sx,jhsl,jhzl,zjldw,fjldw,varrivestation,ywbm,ywry,zdr,zdrq,PH,GG,ZJBstatus,CAPPK,insertts,PCInfo,zyx1,zyx2,zyx3) values('" + item1["C_DISPATCH_ID"] + "','" + item1["C_SEND_STOCK"] + "','" + item1["C_NO"] + "','" + item1["C_SHIPVIA"] + "','" + item1["C_LIC_PLA_NO"] + "','" + item1["C_MAT_CODE"] + "','" + item1["C_MAT_NAME"] + "','" + item1["C_JUDGE_LEV_ZH"] + "','" + item1["N_NUM"] + "','" + item1["N_WGT"] + "','件【线材】','吨','" + item1["C_ATSTATION"] + "','" + item1["C_BUSINESS_DEPT"] + "','" + item1["C_BUSINESS_ID"] + "','" + item1["C_CREATE_ID"] + "','" + item1["D_CREATE_DT"] + "','" + item1["C_STL_GRD"] + "','" + item1["C_SPEC"] + "','0','" + item1["C_ID"] + "','" + RV.UI.ServerTime.timeNow() + "','" + item1["C_AREA"] + "','" + item1["C_ZYX1"] + "','" + item1["C_ZYX2"] + "','" + item1["C_BZYQ"] + "')";
                    if (TransactionHelper_SQL.ExecuteSql(sql) == 0)
                    {
                        TransactionHelper.RollBack();
                        TransactionHelper_SQL.RollBack();
                        return "发送条码失败！";
                    }
                }
            }
            TransactionHelper.Commit();
            TransactionHelper_SQL.Commit();
            return "1";
        }
        #endregion

        #region 接收条码发送发运单实绩
        /// <summary>
        /// 更新发运单表
        /// </summary>
        /// <param name="dhstr">移位单号</param>
        /// <returns></returns>
        public int UPFYDSTATUS(string dhstr, string status, string by1)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("UPDATE SeZJB_FYD_finished SET");
            strSql.Append(" ZJBstatus='" + status + "',by1='" + by1 + "',updatets='" + RV.UI.ServerTime.timeNow() + "'");
            strSql.Append("  where fydh='" + dhstr + "' AND insertts=(select MAX(insertts) insertts from SeZJB_FYD_finished WHERE fydh='" + dhstr + "' )  ");
            return DbHelper_SQL.ExecuteSql(strSql.ToString());
        }
        /// <summary>
        /// 根据其他出库单号获取未匹配线材
        /// </summary>
        /// <param name="qtcdh">其他出库单号</param>
        /// <returns></returns>
        public DataSet GetWPPFYDH(string qtcdh)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT C_BARCODE FROM TRC_ROLL_PRODCUT ");
            strSql.Append("  where C_QTCKD_NO='" + qtcdh + "' C_MOVE_TYPE='QC' ");
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
        /// 通过出库表查询条码其他出库单实绩
        /// </summary>
        /// <returns>DataSet</returns>
        public DataSet QueryFYD()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT fydh FROM SeZJB_FYD_finished  WHERE ZJBstatus!=1");
            return DbHelper_SQL.Query(strSql.ToString());
        }
        /// <summary>
        /// 通过出库表查询条码其他出库单实绩
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
        /// <summary>
        /// 异常更新发运单表
        /// </summary>
        /// <param name="dh">发运单</param>
        /// <returns></returns>
        public int YCUPTMFYD(string dh)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("UPDATE SeZJB_FYD_finished SET");
            strSql.Append(" ZJBstatus=2,by1='当前单号PCI系统不存在！' ");
            strSql.Append("  where fydh='" + dh + "' ");
            return TransactionHelper_SQL.ExecuteSql(strSql.ToString());
        }

        /// <summary>
        /// 同步条码发运单信息
        /// </summary>
        /// <returns>0代码异常,1成功，-1更新条码异常信息时失败(条码的发运单PCI不存在)，-2更新线材实绩时失败，-3更新条码状态时失败,-4条码发运单在PCI中全部不存在,-5条码中没有可返回发运单实绩</returns>
        public string TBFYD(string path)
        {
            string dhstr = "";
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
                        string message = "";
                        if (ExistsByFYD(item["fydh"].ToString()) == false)
                        {
                            UPFYDSTATUS(item["fydh"].ToString(), "2", "PCI系统不存在发运单号" + item["fydh"].ToString());
                        }
                        else
                        {
                            ///发运单号多次发送覆盖
                            if (CKFYD(item["fydh"].ToString()) > 1)
                            {
                                UPFYDSTATUS(item["fydh"].ToString(), "3");
                                UPRPByFYDH(item["fydh"].ToString());
                                DELFYD(item["fydh"].ToString());
                            }
                            dhstr += "'" + item["fydh"].ToString() + "',";
                            //传送条码
                            DataTable fydt = QueryFYDByCK(item["fydh"].ToString()).Tables[0];
                            if (fydt.Rows.Count > 0)
                            {
                                TransactionHelper.BeginTransaction();
                                foreach (DataRow xqitem in fydt.Rows)
                                {
                                    DataTable ydt = GetXCKC(xqitem["Barcode"].ToString()).Tables[0];//获取原线材状态
                                    if (ydt.Rows.Count != 1)
                                    {
                                        UPFYDSTATUS(item["fydh"].ToString(), "2", "牌号" + xqitem["Barcode"].ToString() + "PCI系统不存在！");
                                        TransactionHelper.RollBack();
                                        break;
                                    }
                                    string movetype = GetMOVETYPE(xqitem["Barcode"].ToString());///获取线材库存状态
                                    if (movetype != "E")
                                    {
                                        TransactionHelper.RollBack();
                                        UPFYDSTATUS(item["fydh"].ToString(), "2", "牌号" + xqitem["Barcode"].ToString() + "信息库存状态为" + movetype);
                                        message = "1";
                                        break;
                                    }

                                    DataRow data = ydt.Rows[0];
                                    string sql = "insert into TRC_ROLLCZ_LOG(C_DH,C_STOVE,C_BATCH_NO,C_TICK_NO,C_STL_GRD,N_WGT,C_STD_CODE,C_SPEC,C_LINEWH_CODE,C_LINEWH_AREA_CODE,C_LINEWH_LOC_CODE,C_YLINEWH_CODE,C_YLINEWH_AREA_CODE,C_YLINEWH_LOC_CODE,C_JUDGE_LEV_ZH,D_CZ_DATE,C_MAT_CODE,C_MAT_DESC,C_BARCODE,N_TYPE) values('" + item["fydh"] + "','" + data["C_STOVE"] + "','" + data["C_BATCH_NO"] + "','" + data["C_TICK_NO"] + "','" + data["C_STL_GRD"] + "','" + data["N_WGT"] + "','" + data["C_STD_CODE"] + "','" + data["C_SPEC"] + "','','','','" + data["C_LINEWH_CODE"] + "','" + data["C_LINEWH_AREA_CODE"] + "','" + data["C_LINEWH_LOC_CODE"] + "','" + data["C_JUDGE_LEV_ZH"] + "', to_date('" + RV.UI.ServerTime.timeNow() + "', 'yyyy-mm-dd hh24:mi:ss'),'" + data["C_MAT_CODE"] + "','" + data["C_MAT_DESC"] + "','" + xqitem["Barcode"] + "','2')";
                                    if (TransactionHelper.ExecuteSql(sql.ToString()) != 1)///添加操作记录
                                    {
                                        UPFYDSTATUS(item["fydh"].ToString(), "2", "PCI添加操作日志时错误！");
                                        break;
                                    }
                                    StringBuilder strSql = UPFYD(xqitem);
                                    if (TransactionHelper.ExecuteSql(strSql.ToString()) == 0)
                                    {
                                        TransactionHelper.RollBack();
                                        UPFYDSTATUS(item["fydh"].ToString(), "2", "牌号" + xqitem["Barcode"].ToString() + "变更线材实绩状态错误！");
                                        message = "1";
                                        break;
                                    }
                                }
                            }
                            else
                            {
                                UPFYDSTATUS(item["fydh"].ToString(), "2", "查询发运单详情错误！");
                                continue;
                            }
                            if (message == "1")
                            {
                                continue;
                            }
                            ///添加转库单中间表

                            DataTable dt1 = GetFYSJList(item["fydh"].ToString()).Tables[0];
                            foreach (DataRow item1 in dt1.Rows)
                            {
                                DataTable dt2 = GetTICKList(item["fydh"].ToString(), item1["C_BATCH_NO"].ToString(), item1["C_LINEWH_CODE"].ToString(), item1["C_JUDGE_LEV_ZH"].ToString(), item1["C_BZYQ"].ToString()).Tables[0];
                                string tickstr = "";
                                foreach (DataRow item2 in dt2.Rows)
                                {
                                    tickstr += item2["C_TICK_NO"] + ",";
                                }
                                tickstr = tickstr.Substring(0, tickstr.Length - 1);

                                string rjhsql = "SELECT C_PLAN_ID,C_ID FROM TMD_DISPATCHDETAILS WHERE C_DISPATCH_ID='" + item["fydh"].ToString() + "' AND C_MAT_CODE='" + item1["C_MAT_CODE"] + "' AND C_SEND_STOCK_CODE='" + item1["C_LINEWH_CODE"].ToString() + "' ";// AND C_QUALIRY_LEV='"+ item1["C_JUDGE_LEV_ZH"].ToString() + "' AND C_PACK='"+ item1["C_BZYQ"].ToString() + "'
                                DataTable plandt = TransactionHelper.Query(rjhsql).Tables[0];
                                string planid = "";
                                string pkncid = "";
                                if (plandt.Rows.Count > 0)
                                {
                                    planid = plandt.Rows[0]["C_PLAN_ID"].ToString();
                                    pkncid = plandt.Rows[0]["C_ID"].ToString();
                                }
                                //获取出库单
                                string no = RV.UI.ServerTime.timeNow().Year.ToString() + (Convert.ToInt32(RV.UI.ServerTime.timeNow().Month) > 9 ? RV.UI.ServerTime.timeNow().Month.ToString() : ("0" + RV.UI.ServerTime.timeNow().Month.ToString())) + (Convert.ToInt32(RV.UI.ServerTime.timeNow().Day) > 9 ? RV.UI.ServerTime.timeNow().Day.ToString() : ("0" + RV.UI.ServerTime.timeNow().Day.ToString()));//转库单号
                                string maxckd = GetCKDNO(no);//查询当天最大转库单
                                if (maxckd == "")
                                {
                                    no = no + "00001";
                                }
                                else
                                {
                                    no = (Convert.ToInt64(maxckd.Substring(2, maxckd.Length - 2)) + 1).ToString();
                                }
                                no = "XC" + no;
                                string sql = "";
                                sql += "insert into TMD_DISPATCH_SJZJB(C_DISPATCH_ID,N_NUM,N_STATUS,C_CKDH,N_JZ,C_SEND_STOCK,C_BATCH_NO,C_TICK_STR,C_PLAN_ID,C_STL_GRD,C_STD_CODE,C_SPEC,C_PK_NCID,C_MZDATE,N_MWGT,N_PWGT,N_MZTIME,N_PZTIME,C_PZDATE,C_ZLDJ) values('" + item["fydh"].ToString() + "','" + item1["N_NUM"] + "','8','" + no + "','" + item1["N_WGT"] + "','" + item1["C_LINEWH_CODE"] + "','" + item1["C_BATCH_NO"] + "','" + tickstr + "','" + planid + "','" + item1["C_STL_GRD"] + "','" + item1["C_STD_CODE"] + "','" + item1["C_SPEC"] + "','" + pkncid + "','','','','','','','" + item1["C_JUDGE_LEV_ZH"].ToString() + "')";
                                if (TransactionHelper.ExecuteSql(sql) == 0)
                                {
                                    TransactionHelper.RollBack();
                                    UPFYDSTATUS(item["fydh"].ToString(), "2", "添加发运单中间表错误！");
                                }
                            }
                            //上传条码
                            message = dal_Interface_NC_XC.SendXml_DM(path, item["fydh"].ToString());
                            if (message != "1")
                            {
                                TransactionHelper.RollBack();
                                int len = message.IndexOf("异常信息");
                                message = message.Substring(len, message.Length - len);
                                UPFYDSTATUS(item["fydh"].ToString(), "2", message);
                                return "message";
                            }
                            TransactionHelper.Commit();
                            UPFYDSTATUS(item["fydh"].ToString(), "1", "");
                            UPFYDSTATUS(item["fydh"].ToString(), "8");
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
        public DataSet GetFYSJList(string dh)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT COUNT(1) N_NUM,SUM(N_WGT) N_WGT, C_BATCH_NO,C_MAT_CODE,C_MAT_DESC,C_SPEC,C_STL_GRD,C_STD_CODE,C_LINEWH_CODE,nvl(C_JUDGE_LEV_ZH,C_JUDGE_LEV_BP)C_JUDGE_LEV_ZH,C_BZYQ from TRC_ROLL_PRODCUT WHERE 1=1");
            if (dh.Trim() != "")
            {
                strSql.Append(" AND C_FYDH='" + dh + "'");
            }
            strSql.Append(" GROUP BY C_BATCH_NO,C_MAT_CODE,C_MAT_DESC,C_SPEC,C_STL_GRD,C_STD_CODE,C_LINEWH_CODE,C_JUDGE_LEV_ZH,C_JUDGE_LEV_BP,C_BZYQ");
            return TransactionHelper.Query(strSql.ToString());
        }
        /// <summary>
        ///根据发运单号，批号获取牌号
        /// </summary>
        /// <param name="dh"></param>
        /// <param name="C_BATCH_NO">批号</param>
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
        /// 通过单号查询条码发运实绩详情
        /// </summary>
        /// <param name="dh">单号</param>
        /// <returns></returns>
        public DataSet GetFYSJList(string dh, string C_MAT_CODE, string C_LINEWH_CODE)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT C_BATCH_NO ,C_MAT_CODE,C_STL_GRD,C_STD_CODE,C_SPEC,C_LINEWH_CODE,SUM(N_WGT) N_WGT,COUNT(1) N_NUM from TRC_ROLL_PRODCUT WHERE 1=1");
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
            strSql.Append(" GROUP BY C_BATCH_NO,C_MAT_CODE ,C_STL_GRD,C_STD_CODE,C_SPEC,C_LINEWH_CODE");
            return DbHelper_SQL.Query(strSql.ToString());
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
        /// 更新发运单状态
        /// </summary>
        /// <param name="dhstr">单号</param>
        /// <returns></returns>
        public int UPTMFYDSTATUS(string dhstr)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("UPDATE SeZJB_FYD_finished SET");
            strSql.Append(" ZJBstatus=0 ,updates='" + RV.UI.ServerTime.timeNow() + "'");
            strSql.Append("  where fydh in(" + dhstr.Substring(0, dhstr.Length - 1) + ") ");
            return TransactionHelper_SQL.ExecuteSql(strSql.ToString());
        }
        #endregion

        #region 向条码发送线材改判信息
        /// <summary>
        /// 获取改判后信息集合
        /// </summary>
        /// <param name="C_TICK_NO">钩号</param>
        /// <param name="C_BATCH_NO">批号</param>
        /// <returns></returns>
        public DataTable GETGRDLIST(string C_TICK_NO, string C_BATCH_NO)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT C_BARCODE ,C_TRC_ROLL_MAIN_ID ,C_LINEWH_CODE ,C_LINEWH_LOC_CODE , C_BATCH_NO , C_MAT_CODE , C_MAT_DESC ,C_JUDGE_LEV_ZH  , C_STL_GRD , C_SPEC , C_GROUP ,C_TICK_NO , N_WGT, C_STD_CODE,D_RKRQ , C_MOVE_DESC , C_RKRY , D_WEIGHT_DT, D_PRODUCE_DATE , C_SALE_AREA  , C_STOVE,C_ZYX1 , C_ZYX2 , C_BZYQ , C_GP_TYPE , C_ID  from TRC_ROLL_PRODCUT WHERE 1=1 ");
            if (C_TICK_NO.Trim() != "")
            {
                strSql.Append(" AND C_TICK_NO='" + C_TICK_NO + "'");
            }
            if (C_BATCH_NO.Trim() != "")
            {
                strSql.Append(" AND C_BATCH_NO='" + C_BATCH_NO + "'");
            }
            return DbHelperOra.Query(strSql.ToString()).Tables[0];
        }
        /// <summary>
        /// 根据钩号/批号传改判后钢种信息
        /// </summary>
        /// <param name="C_TICK_NO">钩号</param>
        /// <param name="C_BATCH_NO">批号</param>
        /// <returns>-1导入条码中间表错误,0代码错误，1成功</returns>
        public int SendGRD(string C_TICK_NO, string C_BATCH_NO)
        {
            string LogSql = "";
            string name = "Dal_Interface_FR.SendGRD";
            TransactionHelper_SQL.BeginTransaction();
            try
            {
                DataTable dt = GETGRDLIST(C_TICK_NO, C_BATCH_NO);
                foreach (DataRow item in dt.Rows)
                {
                    string sql = "";
                    sql += "insert into ReZJB_GPD(Barcode,WGDH,CK,HW,PCH,WLH,WLMC,SX,PH,GG,BB,GH,ZL,BZ,RQ,RKType,RKRY,WeightRQ,ProduceData,PCInfo,vfree0,vfree3,GPTYPE,ZJBstatus,CAPPK,insertts) values('" + item["C_BARCODE"] + "','" + item["C_TRC_ROLL_MAIN_ID"] + "','" + item["C_LINEWH_CODE"] + "','" + item["C_LINEWH_LOC_CODE"] + "','" + item["C_BATCH_NO"] + "','" + item["C_MAT_CODE"] + "','" + item["C_MAT_DESC"] + "','" + item["C_JUDGE_LEV_ZH"] + "','" + item["C_STL_GRD"] + "','" + item["C_SPEC"] + "','" + item["C_GROUP"] + "','" + item["C_TICK_NO"] + "','" + item["N_WGT"] + "','" + item["C_STD_CODE"] + "','" + item["D_RKRQ"] + "','" + item["C_MOVE_DESC"] + "','" + item["C_RKRY"] + "','" + item["D_WEIGHT_DT"] + "','" + item["D_PRODUCE_DATE"] + "','" + item["C_SALE_AREA"] + "','" + item["C_STOVE"] + "','" + item["C_BZYQ"] + "','" + item["C_GP_TYPE"] + "','0','" + item["C_ID"] + "','" + RV.UI.ServerTime.timeNow() + "')";
                    if (TransactionHelper_SQL.ExecuteSql(sql) == 0)
                    {
                        TransactionHelper_SQL.RollBack();
                        return -1;
                    }
                }
                TransactionHelper_SQL.Commit();
                return 1;
            }
            catch (Exception ex)
            {
                LogSql = "INSERT INTO TI_RF_LOG(C_TYPE, C_LOG, C_NAME) VALUES('上传传改判后钢种信息','" + ex.ToString() + "','" + name + "')";
                DbHelperOra.ExecuteSql(LogSql);
                return 0;
            }
        }
        #endregion

        #region 其他出库单

        /// <summary>
        /// 检测库存是否变更
        /// </summary>
        /// <param name="mat">物料号</param>
        /// <param name="ck">仓库</param>
        /// <param name="ckarea">区域</param>
        /// <param name="ckloc">库位</param>
        /// <param name="stove">炉号</param>
        /// <param name="batch">批号</param>
        /// <returns></returns>
        public int CKKC(string mat, string ck, string batch)
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
        /// 更新线材实绩
        /// </summary>
        /// <param name="dhstr">转库单号</param>
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
        ///根据条码其他出库单撤销数据
        /// </summary>
        /// <param name="dhstr">id字符串</param>
        /// <returns></returns>
        public int CXQTCKDByCKD(string dhstr)
        {
            if (UPQTCKD(dhstr) > 0)
            {
                UPQTCKDITEM(dhstr);
                UPQTCKDSTATUSBY(dhstr);
                return 1;
            }
            return 0;
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
            strSql.Append(" ORDER BY  ckdh ");
            return TransactionHelper_SQL.Query(strSql.ToString());
        }
        /// <summary>
        /// 获取其他出库单数据
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
                        if (ExistsByQTCKD(item["CKDH"].ToString()) == false)
                        {
                            UPQTCKZJBSTATUS(item["CKDH"].ToString(), "2", "异常:错误编码001，单号" + item["CKDH"].ToString() + "PCI系统不存在！");
                            continue;
                        }
                        else
                        {
                            TransactionHelper.BeginTransaction();
                            //传送条码
                            DataTable ckdt = QueryQTCKDByCK(item["CKDH"].ToString()).Tables[0];///查询条码出库表
                            List<string> zkdhlist = new List<string>();
                            List<string> qtckdhlist = new List<string>();
                            List<string> nulldhlist = new List<string>();
                            string message = "";
                            if (ckdt.Rows.Count > 0)
                            {
                                foreach (DataRow xqitem in ckdt.Rows)
                                {
                                    string ckdh = GetQTCKDByPH(xqitem["Barcode"].ToString());
                                    if (ckdh == "0")
                                    {
                                        message = "1";
                                        TransactionHelper.RollBack();
                                        UPQTCKZJBSTATUS(item["CKDH"].ToString(), "2", "打牌序号" + xqitem["Barcode"] + "PCI系统不存在！");
                                        break;
                                    }

                                    if (item["CKDH"].ToString() == ckdh)
                                    {
                                        StringBuilder strSql = UPQTCKD(xqitem);
                                        if (TransactionHelper.ExecuteSql(strSql.ToString()) != 1)
                                        {
                                            message = "1";
                                            TransactionHelper.RollBack();
                                            UPQTCKZJBSTATUS(item["CKDH"].ToString(), "2", "异常:错误编码101,打牌序号" + xqitem["Barcode"] + "更新线材实绩状态错误");
                                            break;
                                        }
                                    }
                                    else
                                    {
                                        if (ckdh != "")
                                        {
                                            qtckdhlist.Add(ckdh);
                                            StringBuilder strSql = UPQTCKD(xqitem);
                                            if (TransactionHelper.ExecuteSql(strSql.ToString()) != 1)
                                            {
                                                message = "1";
                                                TransactionHelper.RollBack();
                                                UPQTCKZJBSTATUS(item["CKDH"].ToString(), "2", "异常:错误编码102，打牌序号" + xqitem["Barcode"] + "更新线材实绩状态错误");
                                                break;
                                            }
                                        }
                                        else
                                        {
                                            string zkdh = GetZKDDH(xqitem["Barcode"].ToString());
                                            if (zkdh == "0")
                                            {
                                                nulldhlist.Add("");
                                                StringBuilder strSql = UPQTCKD(xqitem);
                                                if (TransactionHelper.ExecuteSql(strSql.ToString()) != 1)
                                                {
                                                    message = "1";
                                                    TransactionHelper.RollBack();
                                                    UPQTCKZJBSTATUS(item["CKDH"].ToString(), "2", "异常:错误编码103，打牌序号" + xqitem["Barcode"] + "更新线材实绩状态错误");
                                                    break;
                                                }
                                            }
                                            if (zkdh != "")
                                            {
                                                zkdhlist.Add(zkdh);
                                                StringBuilder strSql = UPQTCKD(xqitem);
                                                if (TransactionHelper.ExecuteSql(strSql.ToString()) != 1)
                                                {
                                                    message = "1";
                                                    TransactionHelper.RollBack();
                                                    UPQTCKZJBSTATUS(item["CKDH"].ToString(), "2", "异常:错误编码104，打牌序号" + xqitem["Barcode"] + "更新线材实绩状态错误");
                                                    break;
                                                }
                                            }
                                            else
                                            {
                                                nulldhlist.Add("");
                                                StringBuilder strSql = UPQTCKD(xqitem);
                                                if (TransactionHelper.ExecuteSql(strSql.ToString()) != 1)
                                                {
                                                    message = "1";
                                                    TransactionHelper.RollBack();
                                                    UPQTCKZJBSTATUS(item["CKDH"].ToString(), "2", "异常:错误编码105，打牌序号" + xqitem["Barcode"] + "更新线材实绩状态错误");
                                                    break;
                                                }
                                            }
                                        }

                                    }
                                    DataTable ydt = GetXCKC(xqitem["Barcode"].ToString()).Tables[0];//获取原线材状态
                                    DataRow data = ydt.Rows[0];
                                    string sql = "insert into TRC_ROLLCZ_LOG(C_DH,C_STOVE,C_BATCH_NO,C_TICK_NO,C_STL_GRD,N_WGT,C_STD_CODE,C_SPEC,C_LINEWH_CODE,C_LINEWH_AREA_CODE,C_LINEWH_LOC_CODE,C_YLINEWH_CODE,C_YLINEWH_AREA_CODE,C_YLINEWH_LOC_CODE,C_JUDGE_LEV_ZH,D_CZ_DATE,C_MAT_CODE,C_MAT_DESC,C_BARCODE,N_TYPE) values('" + xqitem["CKDH"] + "','" + data["C_STOVE"] + "','" + data["C_BATCH_NO"] + "','" + data["C_TICK_NO"] + "','" + data["C_STL_GRD"] + "','" + data["N_WGT"] + "','" + data["C_STD_CODE"] + "','" + data["C_SPEC"] + "','" + xqitem["CK"] + "','','" + xqitem["HW"] + "','" + data["C_LINEWH_CODE"] + "','" + data["C_LINEWH_AREA_CODE"] + "','" + data["C_LINEWH_LOC_CODE"] + "','" + data["C_JUDGE_LEV_ZH"] + "', to_date('" + RV.UI.ServerTime.timeNow() + "', 'yyyy-mm-dd hh24:mi:ss'),'" + data["C_MAT_CODE"] + "','" + data["C_MAT_DESC"] + "','" + xqitem["Barcode"] + "','3')";
                                    if (TransactionHelper.ExecuteSql(sql.ToString()) != 1)///添加操作记录
                                    {
                                        message = "1";
                                        TransactionHelper.RollBack();
                                        UPQTCKZJBSTATUS(item["CKDH"].ToString(), "2", "PCI添加操作记录时错误");
                                        break;
                                    }
                                }
                                if (message == "1")
                                {
                                    continue;
                                }
                                foreach (var wppitem in zkdhlist)
                                {
                                    DataTable wppdt = GetWPPQTCKDH(item["CKDH"].ToString()).Tables[0];
                                    if (wppdt.Rows.Count == 0)
                                    {
                                        message = "1";
                                        TransactionHelper.RollBack();
                                        UPQTCKZJBSTATUS(item["CKDH"].ToString(), "2", "异常:错误编码106，单号" + item["CKDH"].ToString() + "未查询到数据！");
                                        break;
                                    }
                                    if (UPRPByZKD(wppitem, wppdt.Rows[0]["C_BARCODE"].ToString()) != 1)
                                    {
                                        message = "1";
                                        TransactionHelper.RollBack();
                                        UPQTCKZJBSTATUS(item["CKDH"].ToString(), "2", "异常:错误编码107，打牌序号" + wppdt.Rows[0]["C_BARCODE"] + "更新线材实绩状态错误");
                                        break;
                                    }
                                }
                                if (message == "1")
                                {
                                    continue;
                                }
                                foreach (var wppitem in qtckdhlist)
                                {
                                    DataTable wppdt = GetWPPQTCKDH(item["CKDH"].ToString()).Tables[0];
                                    if (wppdt.Rows.Count == 0)
                                    {
                                        message = "1";
                                        TransactionHelper.RollBack();
                                        UPQTCKZJBSTATUS(item["CKDH"].ToString(), "2", "异常:错误编码108，单号" + item["CKDH"].ToString() + "未查询到数据！");
                                        break;
                                    }
                                    if (UPRPByQTCKD(wppitem, wppdt.Rows[0]["C_BARCODE"].ToString()) != 1)
                                    {
                                        message = "1";
                                        TransactionHelper.RollBack();
                                        UPQTCKZJBSTATUS(item["CKDH"].ToString(), "2", "异常:错误编码109，打牌序号" + wppdt.Rows[0]["C_BARCODE"] + "更新线材实绩状态错误（其他出库单）");
                                        break;
                                    }
                                }
                                if (message == "1")
                                {
                                    continue;
                                }
                                foreach (var wppitem in nulldhlist)
                                {
                                    DataTable wppdt = GetWPPQTCKDH(item["CKDH"].ToString()).Tables[0];
                                    if (wppdt.Rows.Count == 0)
                                    {
                                        message = "1";
                                        TransactionHelper.RollBack();
                                        UPQTCKZJBSTATUS(item["CKDH"].ToString(), "2", "异常:错误编码110，单号" + item["CKDH"].ToString() + "未查询到数据！");
                                        break;
                                    }
                                    if (UPRPByNULL(wppdt.Rows[0]["C_BARCODE"].ToString()) == 0)
                                    {
                                        message = "1";
                                        TransactionHelper.RollBack();
                                        UPQTCKZJBSTATUS(item["CKDH"].ToString(), "2", "异常:错误编码111，打牌序号" + wppdt.Rows[0]["C_BARCODE"].ToString() + "变更线材实绩错误！（库存线材）");
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
                                UPQTCKZJBSTATUS(item["CKDH"].ToString(), "2", "条码仓库不存在库存信息！");
                                continue;
                            }
                            //传送NC
                            DataTable itemdt = GetQTCKXQByDH(item["CKDH"].ToString()).Tables[0]; //要传输的出库单数据
                            if (itemdt.Rows.Count != 1)
                            {
                                message = "1";
                                TransactionHelper.RollBack();
                                UPQTCKZJBSTATUS(item["CKDH"].ToString(), "2", "其他出库单错误！");
                                continue;
                            }
                            if (message == "1")
                            {
                                continue;
                            }
                            DataRow item1 = itemdt.Rows[0];
                            string msg = bll_Interface_NC_QTCK.SendXml_GP(xmlFileName, item1["C_QTCKD_NO"].ToString());
                            if (msg != "1")//发送其他出库单实绩到NC(4I)
                            {
                                TransactionHelper.RollBack();
                                UPQTCKZJBSTATUS(item["CKDH"].ToString(), "2", "4I" + msg);
                                continue;
                            }
                            msg = bll_Interface_NC_QTRK.SendXml_GP(xmlFileName, item1["C_QTCKD_NO"].ToString());
                            if (msg != "1")//发送其他出库单实绩到NC(4A)
                            {
                                TransactionHelper.RollBack();
                                UPQTCKZJBSTATUS(item["CKDH"].ToString(), "2", "4A" + msg);
                                continue;
                            }
                            TransactionHelper.Commit();
                            UPQTCKZJBSTATUS(item["CKDH"].ToString(), "1", "");
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
                DbHelperOra.ExecuteSql(LogSql);
                return "代码异常！";
            }
        }
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
        /// 更新其他出库单表
        /// </summary>
        /// <param name="dh">转库单号</param>
        /// <returns></returns>
        public int UPQTCKZJBSTATUS(string dh, string status, string message)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("UPDATE SeZJB_QTCKD_finished SET");
            strSql.Append(" ZJBstatus='" + status + "',by1='" + message + "',updatets='" + RV.UI.ServerTime.timeNow() + "'");
            strSql.Append("  where ckdh='" + dh + "'  ");
            return DbHelper_SQL.ExecuteSql(strSql.ToString());
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
        /// <summary>
        /// 更新其他出库单
        /// </summary>
        /// <param name="dhstr">移位单号</param>
        /// <returns></returns>
        public int UPQTCKD1(string dh)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("UPDATE SeZJB_QTCKD_finished SET");
            strSql.Append(" ZJBstatus=1 ,updatets='" + RV.UI.ServerTime.timeNow() + "'");
            strSql.Append("  where ckdh ='" + dh + "' ");
            return DbHelper_SQL.ExecuteSql(strSql.ToString());
        }
        #endregion

        #region 其他出库单
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

        #region 转库单号
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
        /// <summary>
        /// 变更线材实绩flag状态
        /// </summary>
        /// <param name="dh">转库单号</param>
        /// <returns></returns>
        public int UPRPFLAG(string dh)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("UPDATE TRC_ROLL_PRODCUT SET");
            strSql.Append(" N_FRFLAG='1'");
            strSql.Append("  where C_ZKD_NO='" + dh + "' ");
            return TransactionHelper.ExecuteSql(strSql.ToString());
        }
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
                        if (ExistsByZKD(item["ZKDH"].ToString()) == false)
                        {
                            UPZKSTATUS(item["ZKDH"].ToString(), "2", "当前单号PCI系统不存在！");
                            continue;
                        }
                        else
                        {
                            TransactionHelper.BeginTransaction();
                            //传送条码
                            DataTable ckdt = QueryTMZKKWByKC(item["ZKDH"].ToString()).Tables[0];///查询条码出库表
                            List<string> zkdhlist = new List<string>();
                            List<string> qtckdhlist = new List<string>();
                            List<string> nulldhlist = new List<string>();
                            string msg = "";
                            if (ckdt.Rows.Count > 0)
                            {
                                foreach (DataRow xqitem in ckdt.Rows)
                                {
                                    string zkdh = GetZKDDH(xqitem["Barcode"].ToString());
                                    if (zkdh == "0")
                                    {
                                        msg = "1";
                                        TransactionHelper.RollBack();
                                        UPZKSTATUS(item["ZKDH"].ToString(), "2", "打牌序号" + xqitem["Barcode"] + "PCI系统不存在！");
                                        break;
                                    }
                                    if (item["ZKDH"].ToString() == zkdh)
                                    {
                                        StringBuilder strSql = UPZKD(xqitem);
                                        if (TransactionHelper.ExecuteSql(strSql.ToString()) != 1)
                                        {
                                            msg = "1";
                                            TransactionHelper.RollBack();
                                            UPZKSTATUS(item["ZKDH"].ToString(), "2", "异常:错误编码，201打牌序号" + xqitem["Barcode"] + "更新线材实绩状态错误");
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
                                                UPZKSTATUS(item["ZKDH"].ToString(), "2", "异常:错误编码202，打牌序号" + xqitem["Barcode"] + "更新线材实绩状态错误");
                                                break;
                                            }
                                        }
                                        else
                                        {
                                            string ckdh = GetZKDDH(xqitem["Barcode"].ToString());
                                            if (ckdh == "0")
                                            {
                                                nulldhlist.Add("");
                                                StringBuilder strSql = UPZKD(xqitem);
                                                if (TransactionHelper.ExecuteSql(strSql.ToString()) != 1)
                                                {
                                                    msg = "1";
                                                    TransactionHelper.RollBack();
                                                    UPZKSTATUS(item["ZKDH"].ToString(), "2", "异常:错误编码203，打牌序号" + xqitem["Barcode"] + "更新线材实绩状态错误");
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
                                                    UPZKSTATUS(item["ZKDH"].ToString(), "2", "异常:错误编码204，打牌序号" + xqitem["Barcode"] + "更新线材实绩状态错误");
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
                                                    UPZKSTATUS(item["ZKDH"].ToString(), "2", "异常:错误编码205，打牌序号" + xqitem["Barcode"] + "更新线材实绩状态错误");
                                                    break;
                                                }
                                            }
                                        }

                                    }
                                    DataTable ydt = GetXCKC(xqitem["Barcode"].ToString()).Tables[0];//获取原线材状态
                                    DataRow data = ydt.Rows[0];
                                    string sql = "insert into TRC_ROLLCZ_LOG(C_DH,C_STOVE,C_BATCH_NO,C_TICK_NO,C_STL_GRD,N_WGT,C_STD_CODE,C_SPEC,C_LINEWH_CODE,C_LINEWH_AREA_CODE,C_LINEWH_LOC_CODE,C_YLINEWH_CODE,C_YLINEWH_AREA_CODE,C_YLINEWH_LOC_CODE,C_JUDGE_LEV_ZH,D_CZ_DATE,C_MAT_CODE,C_MAT_DESC,C_BARCODE,N_TYPE) values('" + xqitem["ZKDH"] + "','" + data["C_STOVE"] + "','" + data["C_BATCH_NO"] + "','" + data["C_TICK_NO"] + "','" + data["C_STL_GRD"] + "','" + data["N_WGT"] + "','" + data["C_STD_CODE"] + "','" + data["C_SPEC"] + "','" + xqitem["CK"] + "','','" + xqitem["HW"] + "','" + data["C_LINEWH_CODE"] + "','" + data["C_LINEWH_AREA_CODE"] + "','" + data["C_LINEWH_LOC_CODE"] + "','" + data["C_JUDGE_LEV_ZH"] + "', to_date('" + RV.UI.ServerTime.timeNow() + "', 'yyyy-mm-dd hh24:mi:ss'),'" + data["C_MAT_CODE"] + "','" + data["C_MAT_DESC"] + "','" + xqitem["Barcode"] + "','1')";
                                    if (TransactionHelper.ExecuteSql(sql.ToString()) != 1)///添加操作记录
                                    {
                                        msg = "1";
                                        TransactionHelper.RollBack();
                                        UPZKSTATUS(item["zkdh"].ToString(), "2", "PCI添加操作记录时错误");
                                        break;
                                    }
                                }
                                if (msg == "1")//验证是否有异常
                                {
                                    continue;
                                }
                                foreach (var wppitem in zkdhlist)
                                {
                                    DataTable wppdt = GetWPPDH(item["ZKDH"].ToString()).Tables[0];
                                    if (wppdt.Rows.Count == 0)
                                    {
                                        msg = "1";
                                        TransactionHelper.RollBack();
                                        UPZKSTATUS(item["ZKDH"].ToString(), "2", "异常:错误编码206，单号" + item["zkdh"].ToString() + "未查询到数据！");
                                        break;
                                    }
                                    if (UPRPByZKD(wppitem, wppdt.Rows[0]["C_BARCODE"].ToString()) != 1)
                                    {
                                        msg = "1";
                                        TransactionHelper.RollBack();
                                        UPZKSTATUS(item["ZKDH"].ToString(), "2", "异常:错误编码207，打牌序号" + wppdt.Rows[0]["C_BARCODE"] + "更新线材实绩状态错误");
                                        break;
                                    }
                                }
                                if (msg == "1")//验证是否有异常
                                {
                                    continue;
                                }
                                foreach (var wppitem in qtckdhlist)
                                {
                                    DataTable wppdt = GetWPPDH(item["ZKDH"].ToString()).Tables[0];
                                    if (wppdt.Rows.Count == 0)
                                    {
                                        msg = "1";
                                        TransactionHelper.RollBack();
                                        UPZKSTATUS(item["ZKDH"].ToString(), "2", "异常:错误编码208，单号" + item["zkdh"].ToString() + "未查询到数据！");
                                        break;
                                    }
                                    if (UPRPByQTCKD(wppitem, wppdt.Rows[0]["C_BARCODE"].ToString()) != 1)
                                    {
                                        msg = "1";
                                        TransactionHelper.RollBack();
                                        UPZKSTATUS(item["ZKDH"].ToString(), "2", "异常:错误编码209，打牌序号" + wppdt.Rows[0]["C_BARCODE"] + "更新线材实绩状态错误（其他出库单）");
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
                                        UPZKSTATUS(item["ZKDH"].ToString(), "2", "异常:错误编码210，单号" + item["zkdh"].ToString() + "未查询到数据！");
                                        break;
                                    }
                                    if (UPRPByNULL(wppdt.Rows[0]["C_BARCODE"].ToString()) == 0)
                                    {
                                        msg = "1";
                                        TransactionHelper.RollBack();
                                        UPZKSTATUS(item["ZKDH"].ToString(), "2", "异常:错误编码211，打牌序号" + wppdt.Rows[0]["C_BARCODE"].ToString() + "变更线材实绩错误！（库存线材）");
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
                                UPZKSTATUS(item["ZKDH"].ToString(), "2", "条码仓库不存在库存信息！");
                                continue;
                            }
                            //传送NC
                            string message = bll_Interface_NC_ZKCK.SendXml_GP(path, item["ZKDH"].ToString());
                            if (message != "1")//发送其他出库单实绩到NC(4I)
                            {
                                int len = message.IndexOf("异常信息");
                                message = message.Substring(len, message.Length - len);
                                TransactionHelper.RollBack();
                                UPZKSTATUS(item["ZKDH"].ToString(), "2", "4I" + message);
                                continue;
                            }
                            message = bll_Interface_NC_ZKRK.SendXml_GP(path, item["ZKDH"].ToString());
                            if (message != "1")//发送其他出库单实绩到NC(4A)
                            {
                                int len = message.IndexOf("异常信息");
                                message = message.Substring(len, message.Length - len);
                                TransactionHelper.RollBack();
                                UPZKSTATUS(item["ZKDH"].ToString(), "2", "4A" + message);
                                continue;
                            }
                            TransactionHelper.Commit();
                            UPZKSTATUS(item["ZKDH"].ToString(), "1", "");
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
        /// <summary>
        /// 更新其他出库单表
        /// </summary>
        /// <param name="dh">转库单号</param>
        /// <returns></returns>
        public int UPZKSTATUS(string dh, string status, string message)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("UPDATE SeZJB_ZKD_finished SET");
            strSql.Append(" ZJBstatus='" + status + "',by1='" + message + "',updatets='" + RV.UI.ServerTime.timeNow() + "'");
            strSql.Append("  where zkdh='" + dh + "'  ");
            return DbHelper_SQL.ExecuteSql(strSql.ToString());
        }

        #endregion

        #region 移位单
        /// <summary>
        /// 获取移位单数据
        /// </summary>
        /// <param name="C_YWDH">其他出库单号</param>
        /// <returns></returns>
        public DataSet GetTMYQD(string C_YWDH)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ywdh,case ZJBstatus when '0' then '未同步' when '1' then '同步成功'when '2' then '同步异常'end ZJBstatus ,by1,insertts,updatets ");
            strSql.Append(" FROM SeZJB_Shift_Record WHERE 1=1");
            if (C_YWDH.Trim() != "")
            {
                strSql.Append(" AND ywdh='" + C_YWDH + "' ");
            }
            strSql.Append(" ORDER BY  ywdh ");
            return TransactionHelper_SQL.Query(strSql.ToString());
        }
        /// <summary>
        /// 获取移位单详情数据
        /// </summary>
        /// <param name="C_YWDH">其他出库单号</param>
        /// <returns></returns>
        public DataSet GetYWDXQ(string DH, string status)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_DH,C_STOVE,C_BATCH_NO,C_TICK_NO,C_STL_GRD,N_WGT,C_STD_CODE,C_SPEC,C_LINEWH_CODE,C_LINEWH_AREA_CODE,C_LINEWH_LOC_CODE,C_YLINEWH_CODE,C_YLINEWH_AREA_CODE,C_YLINEWH_LOC_CODE,C_JUDGE_LEV_ZH,C_MAT_CODE,C_MAT_DESC,C_BARCODE");
            strSql.Append(" FROM TRC_ROLLCZ_LOG WHERE N_TYPE='" + status + "'");
            if (DH.Trim() != "")
            {
                strSql.Append(" AND C_DH='" + DH + "' ");
            }
            strSql.Append(" ORDER BY  C_STOVE,C_BATCH_NO,C_TICK_NO ");
            return DbHelperOra.Query(strSql.ToString());
        }
        #endregion

        #region 发运单
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
            return DbHelperOra.ExecuteSql(strSql.ToString());
        }
        /// <summary>
        /// 删除发运单日志
        /// </summary>
        /// <param name="dhstr">发运单号</param>
        /// <returns></returns>
        public int DELFYD(string dhstr)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("DELETE TRC_ROLLCZ_LOG ");
            strSql.Append(" WHERE C_DH='" + dhstr + "'");
            return DbHelperOra.ExecuteSql(strSql.ToString());
        }
        /// <summary>
        /// 数据
        /// </summary>
        /// <param name="C_FYDH">发运单号</param>
        /// <returns></returns>
        public DataSet GetTMFYD(string C_FYDH)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select fydh,case ZJBstatus when '0' then '未同步' when '1' then '同步成功'when '2' then '同步异常'end ZJBstatus ,by1,insertts,updatets ");
            strSql.Append(" FROM SeZJB_FYD_finished WHERE 1=1");
            if (C_FYDH.Trim() != "")
            {
                strSql.Append(" AND fydh='" + C_FYDH + "' ");
            }
            strSql.Append(" ORDER BY  fydh ");
            return TransactionHelper_SQL.Query(strSql.ToString());
        }
        #endregion

        #region 条码库存同步

        #endregion

        public DataTable LinqSortDataTable(DataTable tmpDt)
        {
            DataTable dtsort = tmpDt.Clone();
            dtsort = tmpDt.Rows.Cast<DataRow>().OrderByDescending(r => Convert.ToDecimal(r["PRESENTAGE"])).CopyToDataTable();
            return dtsort;
        }

    }
}
