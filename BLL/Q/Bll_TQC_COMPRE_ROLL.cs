using System;
using System.Data;
using System.Collections.Generic;
using MODEL;
using DAL;
namespace BLL
{
    /// <summary>
    /// 线材综合判定信息表
    /// </summary>
    public partial class Bll_TQC_COMPRE_ROLL
    {
        private readonly Dal_TQC_COMPRE_ROLL dal = new Dal_TQC_COMPRE_ROLL();

        public Bll_TQC_COMPRE_ROLL()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string C_ID)
        {
            return dal.Exists(C_ID);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Mod_TQC_COMPRE_ROLL model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Mod_TQC_COMPRE_ROLL model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(string C_ID)
        {

            return dal.Delete(C_ID);
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool DeleteList(string C_IDlist)
        {
            return dal.DeleteList(C_IDlist);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Mod_TQC_COMPRE_ROLL GetModel(string C_ID)
        {

            return dal.GetModel(C_ID);
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            return dal.GetList(strWhere);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Mod_TQC_COMPRE_ROLL> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Mod_TQC_COMPRE_ROLL> DataTableToList(DataTable dt)
        {
            List<Mod_TQC_COMPRE_ROLL> modelList = new List<Mod_TQC_COMPRE_ROLL>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Mod_TQC_COMPRE_ROLL model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = dal.DataRowToModel(dt.Rows[n]);
                    if (model != null)
                    {
                        modelList.Add(model);
                    }
                }
            }
            return modelList;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetAllList()
        {
            return GetList("");
        }

        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            return dal.GetRecordCount(strWhere);
        }

        /// <summary>
        /// 查询线材综合判定数据
        /// </summary>
        /// <param name="batchNo">批号</param>
        /// <param name="stove">炉号</param>
        /// <param name="strTime1">生产开始时间</param>
        /// <param name="strTime2">生产结束时间</param>
        /// <param name="strState">全部；已确认，未确认</param>
        /// <returns></returns>
        public DataSet GetList(string batchNo, string stove, string strTime1, string strTime2, string strState)
        {
            return dal.GetList(batchNo, stove, strTime1, strTime2, strState);
        }

        /// <summary>
        /// 查询线材综合判定数据
        /// </summary>
        /// <param name="batchNo">批号</param>
        /// <param name="stove">炉号</param>
        /// <param name="strTime1">生产开始时间</param>
        /// <param name="strTime2">生产结束时间</param>
        /// <param name="strState">全部；已确认，未确认</param>
        /// <param name="strTimeType">生产时间，确认时间</param>
        /// <returns></returns>
        public DataSet GetList(string batchNo, string stove, string strTime1, string strTime2, string strState, string strTimeType)
        {
            return dal.GetList(batchNo, stove, strTime1, strTime2, strState, strTimeType);
        }


        /// <summary>
        /// 查询线材综合判定数据
        /// </summary>
        /// <param name="batchNo">批号</param>
        /// <param name="stove">炉号</param>
        /// <param name="strTime1">生产开始时间</param>
        /// <param name="strTime2">生产结束时间</param>
        /// <param name="strState">全部；已确认，未确认</param>
        /// <param name="strTimeType">生产时间，确认时间</param>
        /// <param name="strStlGrd">钢种</param>
        /// <param name="strStdCode">标准</param>
        /// <returns></returns>
        public DataSet Get_Compre_List(string batchMin, string batchMax, string stove, string strTime1, string strTime2, string strState, string strTimeType, string strStlGrd, string strStdCode)
        {
            return dal.Get_Compre_List(batchMin, batchMax, stove, strTime1, strTime2, strState, strTimeType, strStlGrd, strStdCode);
        }


        /// <summary>
        /// 线材综合判定
        /// </summary>
        /// <returns></returns>
        public int JUDGE_ROLL()
        {
            return dal.JUDGE_ROLL();
        }

        /// <summary>
        /// 同步线材信息到综合判定表
        /// </summary>
        /// <returns></returns>
        public int TB_ROLL()
        {
            return dal.TB_ROLL();
        }

        /// <summary>
        /// 线材综合判定(指定批号)
        /// </summary>
        /// <param name="P_BATCH">批号</param>
        /// <returns></returns>
        public string JUDGE_ROLL_BATCH(string P_BATCH)
        {
            return dal.JUDGE_ROLL_BATCH(P_BATCH);
        }

        /// <summary>
        /// 同步线材信息到综合判定表(指定批号)
        /// </summary>
        /// <param name="P_BATCH">批号</param>
        /// <returns></returns>
        public string TB_ROLL_BATCH(string P_BATCH)
        {
            return dal.TB_ROLL_BATCH(P_BATCH);
        }

        #endregion  BasicMethod
        #region  ExtensionMethod

        /// <summary>
        /// 线材综合判定确认
        /// </summary>
        /// <param name="strBatchNo">批号</param>
        /// <param name="strUrl">xml地址</param>
        /// <returns></returns>
        public string Roll_Compre_OK(string strBatchNo, string strUrl)
        {
            string result = "1";
            try
            {
                Dal_TRC_ROLL_PRODCUT dalTrcRollProduct = new Dal_TRC_ROLL_PRODCUT();
                Dal_TRC_ROLL_WGD dalTrcRollWgd = new Dal_TRC_ROLL_WGD();
                Dal_TQC_ROLL_COMMUTE DalTqcRollCommute = new Dal_TQC_ROLL_COMMUTE();
                Dal_Interface_NC_Roll_KC4N_ZP dal_interface = new Dal_Interface_NC_Roll_KC4N_ZP();
                Dal_Interface_NC_Roll_KC4N_ZP_No_WGD dal_interface_No_Wgd = new Dal_Interface_NC_Roll_KC4N_ZP_No_WGD();
                Dal_TQR_ZBS_ITEM dalTqrZbsItem = new Dal_TQR_ZBS_ITEM();
                Dal_TQC_COMPRE_ITEM_RESULT dalTqcCompreItemResult = new Dal_TQC_COMPRE_ITEM_RESULT();
                Dal_TQC_PHYSICS_RESULT_MAIN dalTqcPhysicsResultMain = new Dal_TQC_PHYSICS_RESULT_MAIN();

                TransactionHelper.BeginTransaction();
                TransactionHelper_SQL.BeginTransaction();

                string strUserID = RV.UI.UserInfo.userID;
                DateTime time = RV.UI.ServerTime.timeNow();

                string C_MASTER_ID = "";
                string C_GP_BEFORE_ID = "";
                string C_GP_AFTER_ID = "";

                DataTable dt_CompreRoll = dal.Get_List(strBatchNo).Tables[0];

                if (dt_CompreRoll.Rows.Count > 0)
                {
                    int num = 0;
                    for (int i = 0; i < dt_CompreRoll.Rows.Count; i++)
                    {
                        num++;

                        Mod_TQC_COMPRE_ROLL modTqcCompreRoll = dal.GetModel(dt_CompreRoll.Rows[i]["C_ID"].ToString());

                        if (!string.IsNullOrEmpty(modTqcCompreRoll.C_RESULT_PEOPLE) || !string.IsNullOrEmpty(modTqcCompreRoll.C_RESULT_ALL))
                        {
                            //判定结果回写实绩表
                            string strResult = "";
                            if (!string.IsNullOrEmpty(modTqcCompreRoll.C_RESULT_PEOPLE))
                            {
                                strResult = modTqcCompreRoll.C_RESULT_PEOPLE;
                            }
                            else
                            {
                                strResult = modTqcCompreRoll.C_RESULT_ALL;
                            }

                            if (strResult == "N")
                            {
                                TransactionHelper.RollBack();
                                TransactionHelper_SQL.RollBack();
                                return "综判等级为N，请选择人工判定等级！";
                            }

                            modTqcCompreRoll.C_QR_STATE = "Y";
                            modTqcCompreRoll.C_EMP_ID = strUserID;
                            modTqcCompreRoll.D_MOD_DT = time;

                            if (!dal.Update_Trans(modTqcCompreRoll))
                            {
                                TransactionHelper.RollBack();
                                TransactionHelper_SQL.RollBack();
                                return "操作失败！";
                            }

                            DataTable dt = DalTqcRollCommute.GetList_max_Trans().Tables[0];

                            if (string.IsNullOrEmpty(dt.Rows[0]["C_GP_AFTER_ID"].ToString()))
                            {
                                C_GP_AFTER_ID = "ph" + time.ToString("yyMMdd00001");
                            }
                            else
                            {
                                C_GP_AFTER_ID = "ph" + (Convert.ToInt64(dt.Rows[0]["C_GP_AFTER_ID"].ToString()) + 1).ToString();
                            }

                            if (!dalTrcRollProduct.Update_Trans(strResult, modTqcCompreRoll.C_EMP_ID, modTqcCompreRoll, C_GP_AFTER_ID))
                            {
                                TransactionHelper.RollBack();
                                TransactionHelper_SQL.RollBack();
                                return "操作失败！";
                            }

                        }
                        else
                        {
                            TransactionHelper.RollBack();
                            TransactionHelper_SQL.RollBack();
                            return "请先选择人工判定等级！";
                        }
                    }

                    int num_main = dalTqcPhysicsResultMain.Get_Count(strBatchNo);

                    if (num_main > 0)
                    {
                        if (!dalTqcPhysicsResultMain.Update_PD_Trans(strBatchNo))
                        {
                            TransactionHelper.RollBack();
                            TransactionHelper_SQL.RollBack();
                            return "更新判定状态失败！";
                        }
                    }

                    if (num == dt_CompreRoll.Rows.Count)
                    {
                        #region 同步重量

                        DataTable dtTM = dal.Get_TM_List(strBatchNo).Tables[0];
                        if (dtTM.Rows.Count > 0)
                        {
                            for (int i = 0; i < dtTM.Rows.Count; i++)
                            {
                                if (!dalTrcRollProduct.Update_Wgt_Trans(strBatchNo, dtTM.Rows[i]["GH"].ToString(), dtTM.Rows[i]["ZL"].ToString()))
                                {
                                    TransactionHelper.RollBack();
                                    TransactionHelper_SQL.RollBack();
                                    return "更新重量失败！";
                                }
                            }
                        }
                        else
                        {
                            TransactionHelper.RollBack();
                            TransactionHelper_SQL.RollBack();
                            return "没有找到条码库存信息，判定失败！";
                        }

                        #endregion

                        Mod_TRC_ROLL_WGD mod_wgd = dalTrcRollWgd.Get_WGD_Modle(strBatchNo);//获取完工单信息
                        if (mod_wgd != null)
                        {
                            DataTable dt_Group = dalTrcRollProduct.Get_List_ByGroup(strBatchNo).Tables[0];

                            for (int i = 0; i < dt_Group.Rows.Count; i++)
                            {
                                #region 更新线材实绩表

                                DataTable dt = DalTqcRollCommute.GetList_max_MasterID_Trans().Tables[0];

                                if (string.IsNullOrEmpty(dt.Rows[0]["C_MASTER_ID"].ToString()))
                                {
                                    C_MASTER_ID = "sj" + time.ToString("yyMMdd00001");
                                }
                                else
                                {
                                    C_MASTER_ID = "sj" + (Convert.ToInt64(dt.Rows[0]["C_MASTER_ID"].ToString()) + 1).ToString();
                                }

                                if (string.IsNullOrEmpty(dt.Rows[0]["C_GP_BEFORE_ID"].ToString()))
                                {
                                    C_GP_BEFORE_ID = "pq" + time.ToString("yyMMdd00001");
                                }
                                else
                                {
                                    C_GP_BEFORE_ID = "pq" + (Convert.ToInt64(dt.Rows[0]["C_GP_BEFORE_ID"].ToString()) + 1).ToString();
                                }

                                if (!dalTrcRollProduct.Update_Trans(C_MASTER_ID, C_GP_BEFORE_ID, dt_Group.Rows[i]["C_STD_CODE"].ToString(), dt_Group.Rows[i]["C_MAT_CODE"].ToString(), dt_Group.Rows[i]["C_ZYX1"].ToString(), dt_Group.Rows[i]["C_ZYX2"].ToString(), strBatchNo))
                                {
                                    TransactionHelper.RollBack();
                                    TransactionHelper_SQL.RollBack();
                                    return "操作失败！";
                                }

                                #endregion

                                #region 上传条码

                                DataTable dt_Details = dalTrcRollProduct.Get_Details(strBatchNo, dt_Group.Rows[i]["C_STD_CODE"].ToString(), dt_Group.Rows[i]["C_MAT_CODE"].ToString(), dt_Group.Rows[i]["C_ZYX1"].ToString(), dt_Group.Rows[i]["C_ZYX2"].ToString()).Tables[0];


                                if (dt_Details.Rows.Count > 0)
                                {
                                    string sql = "";

                                    for (int kk = 0; kk < dt_Details.Rows.Count; kk++)
                                    {
                                        if (mod_wgd.C_MRSX.ToString() == "DP")
                                        {
                                            sql = "insert into ReZJB_GPD(Barcode,WGDH,CK,HW,PCH,WLH,WLMC,SX,PH,GG,BB,GH,ZL,BZ,RQ,RKType,RKRY,WeightRQ,ProduceData,PCInfo,vfree0,vfree3,GPTYPE,ZJBstatus,CAPPK,insertts,vfree1,vfree2) values('" + dt_Details.Rows[kk]["C_BARCODE"] + "','" + dt_Details.Rows[kk]["C_TRC_ROLL_MAIN_ID"] + "','" + dt_Details.Rows[kk]["C_LINEWH_CODE"] + "','" + dt_Details.Rows[kk]["C_LINEWH_LOC_CODE"] + "','" + dt_Details.Rows[kk]["C_BATCH_NO"] + "','" + dt_Details.Rows[kk]["C_MAT_CODE"] + "','" + dt_Details.Rows[kk]["C_MAT_DESC"] + "','" + dt_Details.Rows[kk]["C_JUDGE_LEV_ZH"] + "','" + dt_Details.Rows[kk]["C_STL_GRD"] + "','" + dt_Details.Rows[kk]["C_SPEC"] + "mm','" + dt_Details.Rows[kk]["C_GROUP"] + "','" + dt_Details.Rows[kk]["C_TICK_NO"] + "','" + dt_Details.Rows[kk]["N_WGT"] + "','" + dt_Details.Rows[kk]["C_STD_CODE"] + "','" + dt_Details.Rows[kk]["D_RKRQ"] + "','" + dt_Details.Rows[kk]["C_MOVE_DESC"] + "','" + dt_Details.Rows[kk]["C_RKRY"] + "','" + dt_Details.Rows[kk]["D_WEIGHT_DT"] + "','" + dt_Details.Rows[kk]["D_PRODUCE_DATE"] + "','" + dt_Details.Rows[kk]["C_PCINFO"] + "','" + dt_Details.Rows[kk]["C_STOVE"] + "','" + dt_Details.Rows[kk]["C_BZYQ"] + "','','0','" + dt_Details.Rows[kk]["C_ID"] + "','" + time + "','" + dt_Details.Rows[kk]["C_ZYX1"].ToString() + "','" + dt_Details.Rows[kk]["C_ZYX2"].ToString() + "')";

                                            if (TransactionHelper_SQL.ExecuteSql(sql) == 0)
                                            {
                                                TransactionHelper.RollBack();
                                                TransactionHelper_SQL.RollBack();
                                                return "信息传到条码时出错！";
                                            }
                                        }
                                        else
                                        {
                                            if (dt_Details.Rows[kk]["C_JUDGE_LEV_BP"].ToString() != dt_Details.Rows[kk]["C_JUDGE_LEV_ZH"].ToString())
                                            {
                                                sql = "insert into ReZJB_GPD(Barcode,WGDH,CK,HW,PCH,WLH,WLMC,SX,PH,GG,BB,GH,ZL,BZ,RQ,RKType,RKRY,WeightRQ,ProduceData,PCInfo,vfree0,vfree3,GPTYPE,ZJBstatus,CAPPK,insertts,vfree1,vfree2) values('" + dt_Details.Rows[kk]["C_BARCODE"] + "','" + dt_Details.Rows[kk]["C_TRC_ROLL_MAIN_ID"] + "','" + dt_Details.Rows[kk]["C_LINEWH_CODE"] + "','" + dt_Details.Rows[kk]["C_LINEWH_LOC_CODE"] + "','" + dt_Details.Rows[kk]["C_BATCH_NO"] + "','" + dt_Details.Rows[kk]["C_MAT_CODE"] + "','" + dt_Details.Rows[kk]["C_MAT_DESC"] + "','" + dt_Details.Rows[kk]["C_JUDGE_LEV_ZH"] + "','" + dt_Details.Rows[kk]["C_STL_GRD"] + "','" + dt_Details.Rows[kk]["C_SPEC"] + "mm','" + dt_Details.Rows[kk]["C_GROUP"] + "','" + dt_Details.Rows[kk]["C_TICK_NO"] + "','" + dt_Details.Rows[kk]["N_WGT"] + "','" + dt_Details.Rows[kk]["C_STD_CODE"] + "','" + dt_Details.Rows[kk]["D_RKRQ"] + "','" + dt_Details.Rows[kk]["C_MOVE_DESC"] + "','" + dt_Details.Rows[kk]["C_RKRY"] + "','" + dt_Details.Rows[kk]["D_WEIGHT_DT"] + "','" + dt_Details.Rows[kk]["D_PRODUCE_DATE"] + "','" + dt_Details.Rows[kk]["C_PCINFO"] + "','" + dt_Details.Rows[kk]["C_STOVE"] + "','" + dt_Details.Rows[kk]["C_BZYQ"] + "','','0','" + dt_Details.Rows[kk]["C_ID"] + "','" + time + "','" + dt_Details.Rows[kk]["C_ZYX1"].ToString() + "','" + dt_Details.Rows[kk]["C_ZYX2"].ToString() + "')";

                                                if (TransactionHelper_SQL.ExecuteSql(sql) == 0)
                                                {
                                                    TransactionHelper.RollBack();
                                                    TransactionHelper_SQL.RollBack();
                                                    return "信息传到条码时出错！";
                                                }
                                            }
                                        }
                                    }
                                }
                                else
                                {
                                    TransactionHelper.RollBack();
                                    TransactionHelper_SQL.RollBack();
                                    return "信息传到条码时出错！";
                                }

                                #endregion

                                #region 上传NC

                                string sql_NC = "select count(distinct t.STORCODE) from XGERP50.V_ONHAND_XC t where t.批次号='" + strBatchNo + "' AND T.INVTYPE='" + dt_Group.Rows[i]["C_STL_GRD"].ToString() + "' AND T.INVCODE='" + dt_Group.Rows[i]["C_MAT_CODE"].ToString() + "' ";
                                int countNC = dal.Get_NC_Batch_Count(sql_NC);
                                if (countNC > 1)
                                {
                                    TransactionHelper.RollBack();
                                    TransactionHelper_SQL.RollBack();
                                    return "该批次信息不在同一个仓库，不能判定！";
                                }
                                else if (countNC == 0)
                                {
                                    TransactionHelper.RollBack();
                                    TransactionHelper_SQL.RollBack();
                                    return "该批次信息还没有入库！";
                                }

                                string interface_nc = dal_interface.SendXml_GP(strUrl, strBatchNo, C_MASTER_ID, dt_Group.Rows[i]["C_MAT_CODE"].ToString(), dt_Group.Rows[i]["N_WGT"].ToString(), dt_Group.Rows[i]["QUA"].ToString(), dt_Group.Rows[i]["C_ZYX1"].ToString(), dt_Group.Rows[i]["C_ZYX2"].ToString(), mod_wgd, C_GP_BEFORE_ID);

                                if (interface_nc != "1")
                                {
                                    TransactionHelper.RollBack();
                                    TransactionHelper_SQL.RollBack();
                                    return interface_nc;
                                }

                                #endregion

                            }
                        }
                        else
                        {
                            DataTable dt_Group = dalTrcRollProduct.Get_List_ByGroup(strBatchNo).Tables[0];

                            for (int i = 0; i < dt_Group.Rows.Count; i++)
                            {
                                #region 更新线材实绩表

                                DataTable dt = DalTqcRollCommute.GetList_max_MasterID_Trans().Tables[0];

                                if (string.IsNullOrEmpty(dt.Rows[0]["C_MASTER_ID"].ToString()))
                                {
                                    C_MASTER_ID = "sj" + time.ToString("yyMMdd00001");
                                }
                                else
                                {
                                    C_MASTER_ID = "sj" + (Convert.ToInt64(dt.Rows[0]["C_MASTER_ID"].ToString()) + 1).ToString();
                                }

                                if (string.IsNullOrEmpty(dt.Rows[0]["C_GP_BEFORE_ID"].ToString()))
                                {
                                    C_GP_BEFORE_ID = "pq" + time.ToString("yyMMdd00001");
                                }
                                else
                                {
                                    C_GP_BEFORE_ID = "pq" + (Convert.ToInt64(dt.Rows[0]["C_GP_BEFORE_ID"].ToString()) + 1).ToString();
                                }

                                if (!dalTrcRollProduct.Update_Trans(C_MASTER_ID, C_GP_BEFORE_ID, dt_Group.Rows[i]["C_STD_CODE"].ToString(), dt_Group.Rows[i]["C_MAT_CODE"].ToString(), dt_Group.Rows[i]["C_ZYX1"].ToString(), dt_Group.Rows[i]["C_ZYX2"].ToString(), strBatchNo))
                                {
                                    TransactionHelper.RollBack();
                                    TransactionHelper_SQL.RollBack();
                                    return "操作失败！";
                                }

                                #endregion

                                #region 上传条码

                                DataTable dt_Details = dalTrcRollProduct.Get_Details(strBatchNo, dt_Group.Rows[i]["C_STD_CODE"].ToString(), dt_Group.Rows[i]["C_MAT_CODE"].ToString(), dt_Group.Rows[i]["C_ZYX1"].ToString(), dt_Group.Rows[i]["C_ZYX2"].ToString()).Tables[0];


                                if (dt_Details.Rows.Count > 0)
                                {
                                    string sql = "";

                                    for (int kk = 0; kk < dt_Details.Rows.Count; kk++)
                                    {
                                        sql = "insert into ReZJB_GPD(Barcode,WGDH,CK,HW,PCH,WLH,WLMC,SX,PH,GG,BB,GH,ZL,BZ,RQ,RKType,RKRY,WeightRQ,ProduceData,PCInfo,vfree0,vfree3,GPTYPE,ZJBstatus,CAPPK,insertts,vfree1,vfree2) values('" + dt_Details.Rows[kk]["C_BARCODE"] + "','" + dt_Details.Rows[kk]["C_TRC_ROLL_MAIN_ID"] + "','" + dt_Details.Rows[kk]["C_LINEWH_CODE"] + "','" + dt_Details.Rows[kk]["C_LINEWH_LOC_CODE"] + "','" + dt_Details.Rows[kk]["C_BATCH_NO"] + "','" + dt_Details.Rows[kk]["C_MAT_CODE"] + "','" + dt_Details.Rows[kk]["C_MAT_DESC"] + "','" + dt_Details.Rows[kk]["C_JUDGE_LEV_ZH"] + "','" + dt_Details.Rows[kk]["C_STL_GRD"] + "','" + dt_Details.Rows[kk]["C_SPEC"] + "mm','" + dt_Details.Rows[kk]["C_GROUP"] + "','" + dt_Details.Rows[kk]["C_TICK_NO"] + "','" + dt_Details.Rows[kk]["N_WGT"] + "','" + dt_Details.Rows[kk]["C_STD_CODE"] + "','" + dt_Details.Rows[kk]["D_RKRQ"] + "','" + dt_Details.Rows[kk]["C_MOVE_DESC"] + "','" + dt_Details.Rows[kk]["C_RKRY"] + "','" + dt_Details.Rows[kk]["D_WEIGHT_DT"] + "','" + dt_Details.Rows[kk]["D_PRODUCE_DATE"] + "','" + dt_Details.Rows[kk]["C_PCINFO"] + "','" + dt_Details.Rows[kk]["C_STOVE"] + "','" + dt_Details.Rows[kk]["C_BZYQ"] + "','','0','" + dt_Details.Rows[kk]["C_ID"] + "','" + time + "','" + dt_Details.Rows[kk]["C_ZYX1"].ToString() + "','" + dt_Details.Rows[kk]["C_ZYX2"].ToString() + "')";

                                        if (TransactionHelper_SQL.ExecuteSql(sql) == 0)
                                        {
                                            TransactionHelper.RollBack();
                                            TransactionHelper_SQL.RollBack();
                                            return "信息传到条码时出错！";
                                        }
                                    }
                                }
                                else
                                {
                                    TransactionHelper.RollBack();
                                    TransactionHelper_SQL.RollBack();
                                    return "信息传到条码时出错！";
                                }

                                #endregion

                                #region 上传NC

                                string sql_NC = "select count(distinct t.STORCODE) from XGERP50.V_ONHAND_XC t where t.批次号='" + strBatchNo + "' AND T.INVTYPE='" + dt_Group.Rows[i]["C_STL_GRD"].ToString() + "' AND T.INVCODE='" + dt_Group.Rows[i]["C_MAT_CODE"].ToString() + "'  ";

                                int countNC = dal.Get_NC_Batch_Count(sql_NC);
                                if (countNC > 1)
                                {
                                    TransactionHelper.RollBack();
                                    TransactionHelper_SQL.RollBack();
                                    return "该批次信息不在同一个仓库，不能判定！";
                                }
                                else if (countNC == 0)
                                {
                                    TransactionHelper.RollBack();
                                    TransactionHelper_SQL.RollBack();
                                    return "该批次信息还没有入库！";
                                }

                                string interface_nc = dal_interface_No_Wgd.SendXml_GP(strUrl, strBatchNo, C_MASTER_ID, dt_Group.Rows[i]["C_MAT_CODE"].ToString(), dt_Group.Rows[i]["N_WGT"].ToString(), dt_Group.Rows[i]["QUA"].ToString(), dt_Group.Rows[i]["C_ZYX1"].ToString(), dt_Group.Rows[i]["C_ZYX2"].ToString(), C_GP_BEFORE_ID);

                                if (interface_nc != "1")
                                {
                                    TransactionHelper.RollBack();
                                    TransactionHelper_SQL.RollBack();
                                    return interface_nc;
                                }

                                #endregion
                            }
                        }
                    }
                    else
                    {
                        TransactionHelper.RollBack();
                        TransactionHelper_SQL.RollBack();
                        return "信息有误！";
                    }
                }

                TransactionHelper.Commit();
                TransactionHelper_SQL.Commit();
            }
            catch (Exception ex)
            {
                TransactionHelper.RollBack();
                TransactionHelper_SQL.RollBack();
                return ex.Message;
            }

            return result;
        }

        /// <summary>
        /// 复检确认
        /// </summary>
        /// <param name="dr">需要确认的数据</param>
        /// <param name="TickNo">钩号</param>
        /// <returns></returns>
        public string Recheck_SL(DataTable dt_main, int[] rownumber, string[] str_tick_no, string strQRZT, int Type)
        {
            string result = "1";

            try
            {
                TransactionHelper.BeginTransaction();

                string userID = RV.UI.UserInfo.UserID;
                DateTime dTime = RV.UI.ServerTime.timeNow();

                Dal_TQC_RECHECK dalRecheck = new Dal_TQC_RECHECK();
                Dal_TQC_PHYSICS_RESULT_MAIN dalPhysicsResultMain = new Dal_TQC_PHYSICS_RESULT_MAIN();
                Dal_TQB_PHYSICS_GROUP dalTqbPhysicsGroup = new Dal_TQB_PHYSICS_GROUP();
                Dal_TQC_RESULT_MAIN_ZJB dalResultMainZJB = new Dal_TQC_RESULT_MAIN_ZJB();
                for (int i = 0; i < rownumber.Length; i++)
                {
                    Mod_TQC_RECHECK mod = dalRecheck.GetModel(dt_main.Rows[rownumber[i]]["C_ID"].ToString());
                    mod.N_IS_QR = Type;
                    mod.C_TICK_NO = str_tick_no[i];
                    mod.C_QR_USER_ID = userID;
                    mod.D_QR_MOD = dTime;
                    if (!dalRecheck.Update_Trans(mod))
                    {
                        TransactionHelper.RollBack();
                        return "0";
                    }
                    else
                    {
                        string str_PHYSICS_GROUP_ID = dalTqbPhysicsGroup.Get_ID(dt_main.Rows[rownumber[i]]["C_PHYSICS_CODE"].ToString());

                        if (str_PHYSICS_GROUP_ID == "0")
                        {
                            TransactionHelper.RollBack();
                            return "0";
                        }

                        Mod_TQC_RESULT_MAIN_ZJB mod_zjb = new Mod_TQC_RESULT_MAIN_ZJB();
                        mod_zjb.C_BATCH_NO = dt_main.Rows[rownumber[i]]["C_BATCH_NO"].ToString();
                        mod_zjb.C_TICK_NO = str_tick_no[i];
                        mod_zjb.C_STL_GRD = dt_main.Rows[rownumber[i]]["C_STL_GRD"].ToString();
                        mod_zjb.C_SPEC = dt_main.Rows[rownumber[i]]["C_SPEC"].ToString();
                        mod_zjb.C_EMP_ID = dt_main.Rows[rownumber[i]]["C_EMP_ID"].ToString();
                        mod_zjb.D_MOD_DT = Convert.ToDateTime(dt_main.Rows[rownumber[i]]["D_MOD_DT"].ToString());
                        mod_zjb.C_EMP_ID_ZY = userID;
                        mod_zjb.D_MOD_DT_ZY = Convert.ToDateTime(dTime);
                        mod_zjb.C_EMP_ID_JS = userID;
                        mod_zjb.D_MOD_DT_JS = Convert.ToDateTime(dTime);
                        mod_zjb.C_PHYSICS_GROUP_ID = str_PHYSICS_GROUP_ID;
                        mod_zjb.C_CHECK_STATE = "1";
                        mod_zjb.N_RECHECK = mod.N_RECHECK;
                        mod_zjb.C_ITEM_NAME = mod.C_ITEM_NAME;
                        mod_zjb.C_QRZT = strQRZT;
                        mod_zjb.C_DISPOSAL = mod.C_DISPOSAL;
                        if (!dalResultMainZJB.Add_Trans(mod_zjb))
                        {
                            TransactionHelper.RollBack();
                            return "0";
                        }
                    }
                }
                TransactionHelper.Commit();
            }
            catch (Exception ex)
            {
                TransactionHelper.RollBack();
                return "0";
            }

            return result;
        }

        /// <summary>
        /// 复检确认
        /// </summary>
        /// <param name="dr">需要确认的数据</param>
        /// <param name="TickNo">钩号</param>
        /// <returns></returns>
        public string Recheck_QR(DataTable dt_main, int[] rownumber, string[] str_tick_no, string strQRZT, int Type)
        {
            string result = "1";

            try
            {
                TransactionHelper.BeginTransaction();

                string userID = RV.UI.UserInfo.UserID;
                DateTime dTime = RV.UI.ServerTime.timeNow();

                Dal_TQC_RECHECK dalRecheck = new Dal_TQC_RECHECK();
                Dal_TQC_PHYSICS_RESULT_MAIN dalPhysicsResultMain = new Dal_TQC_PHYSICS_RESULT_MAIN();
                Dal_TQB_PHYSICS_GROUP dalTqbPhysicsGroup = new Dal_TQB_PHYSICS_GROUP();
                Dal_TQC_RESULT_MAIN_ZJB dalResultMainZJB = new Dal_TQC_RESULT_MAIN_ZJB();
                for (int i = 0; i < rownumber.Length; i++)
                {
                    Mod_TQC_RECHECK mod = dalRecheck.GetModel(str_tick_no[i]);
                    mod.N_IS_QR = Type;
                    mod.C_ZZ_USER_ID = userID;
                    mod.D_ZZ_MOD = dTime;
                    mod.C_ZZJG = strQRZT;
                    if (!dalRecheck.Update_Trans(mod))
                    {
                        TransactionHelper.RollBack();
                        return "0";
                    }

                }
                TransactionHelper.Commit();
            }
            catch (Exception ex)
            {
                TransactionHelper.RollBack();
                return "0";
            }

            return result;
        }
        /// <summary>
        /// 保存特殊信息
        /// </summary>
        /// <param name="dr">需要添加特殊信息的批号信息</param>
        /// <param name="strTSXX">特殊信息</param>
        /// <returns></returns>
        public string Save_TSXX(DataRow dr, string strTSXX)
        {
            string result = "1";

            try
            {
                TransactionHelper.BeginTransaction();

                string userID = RV.UI.UserInfo.UserID;
                DateTime dTime = RV.UI.ServerTime.timeNow();

                Dal_TRC_ROLL_PRODCUT dalTrcRollProduct = new Dal_TRC_ROLL_PRODCUT();

                Mod_TQC_COMPRE_ROLL model = dal.GetModel(dr["C_ID"].ToString());
                if (model != null)
                {
                    model.C_PCINFO = strTSXX;

                    if (!dal.Update_Trans(model))
                    {
                        TransactionHelper.RollBack();
                        return "保存特殊信息失败！";
                    }

                    DataTable dt_Details = dalTrcRollProduct.Get_Details(dr["批号"].ToString(), dr["执行标准"].ToString(), dr["物料编码"].ToString(), dr["钢种"].ToString(), dr["炉号"].ToString(), dr["表判结果"].ToString(), dr["不合格原因"].ToString()).Tables[0];

                    if (dt_Details.Rows.Count > 0)
                    {
                        string sql = "";

                        for (int kk = 0; kk < dt_Details.Rows.Count; kk++)
                        {
                            Mod_TRC_ROLL_PRODCUT modProduct = dalTrcRollProduct.GetModel(dt_Details.Rows[kk]["C_ID"].ToString());

                            if (modProduct != null)
                            {
                                if (!modProduct.C_PCINFO.Contains(strTSXX))
                                {
                                    modProduct.C_PCINFO = modProduct.C_PCINFO + strTSXX;
                                }

                                string strDJ = "";
                                if (string.IsNullOrEmpty(modProduct.C_JUDGE_LEV_ZH))
                                {
                                    strDJ = "DP";
                                }
                                else
                                {
                                    strDJ = modProduct.C_JUDGE_LEV_ZH;
                                }

                                sql = "insert into ReZJB_GPD(Barcode,WGDH,CK,HW,PCH,WLH,WLMC,SX,PH,GG,BB,GH,ZL,BZ,RQ,RKType,RKRY,WeightRQ,ProduceData,PCInfo,vfree0,vfree3,GPTYPE,ZJBstatus,CAPPK,insertts,vfree1,vfree2) values('" + modProduct.C_BARCODE + "','" + modProduct.C_TRC_ROLL_MAIN_ID + "','" + modProduct.C_LINEWH_CODE + "','" + modProduct.C_LINEWH_LOC_CODE + "','" + modProduct.C_BATCH_NO + "','" + modProduct.C_MAT_CODE + "','" + modProduct.C_MAT_DESC + "','" + strDJ + "','" + modProduct.C_STL_GRD + "','" + modProduct.C_SPEC + "mm','" + modProduct.C_GROUP + "','" + modProduct.C_TICK_NO + "','" + modProduct.N_WGT + "','" + modProduct.C_STD_CODE + "','" + modProduct.D_RKRQ + "','" + modProduct.C_MOVE_DESC + "','" + modProduct.C_RKRY + "','" + modProduct.D_WEIGHT_DT + "','" + modProduct.D_PRODUCE_DATE + "','" + modProduct.C_PCINFO + "','" + modProduct.C_STOVE + "','" + modProduct.C_BZYQ + "','','0','" + modProduct.C_ID + "','" + dTime + "','" + modProduct.C_ZYX1.ToString() + "','" + modProduct.C_ZYX2.ToString() + "')";

                                if (TransactionHelper_SQL.ExecuteSql(sql) == 0)
                                {
                                    TransactionHelper.RollBack();
                                    return "特殊信息传到条码时出错！";
                                }

                                modProduct.C_EMP_ID = userID;
                                modProduct.C_PLANT_DESC = dTime.ToString();

                                if (!dalTrcRollProduct.Update_Trans_XL(modProduct))
                                {
                                    TransactionHelper.RollBack();
                                    return "保存特殊信息出错！";
                                }
                            }
                            else
                            {
                                TransactionHelper.RollBack();
                                return "没有找到线材信息！";
                            }

                        }
                    }
                    else
                    {
                        TransactionHelper.RollBack();
                        return "特殊信息传到条码时出错！";
                    }

                }

                TransactionHelper.Commit();
            }
            catch (Exception ex)
            {
                TransactionHelper.RollBack();
                return "0";
            }

            return result;
        }


        /// <summary>
        /// 保存特殊信息
        /// </summary>
        /// <param name="dr">需要添加特殊信息的批号信息</param>
        /// <param name="strTSXX">特殊信息</param>
        /// <returns></returns>
        public string Cancle_TSXX(DataRow dr)
        {
            string result = "1";

            try
            {
                TransactionHelper.BeginTransaction();

                string userID = RV.UI.UserInfo.UserID;
                DateTime dTime = RV.UI.ServerTime.timeNow();

                Dal_TRC_ROLL_PRODCUT dalTrcRollProduct = new Dal_TRC_ROLL_PRODCUT();

                Mod_TQC_COMPRE_ROLL model = dal.GetModel(dr["C_ID"].ToString());
                if (model != null)
                {
                    model.C_PCINFO = "";

                    if (!dal.Update_Trans(model))
                    {
                        TransactionHelper.RollBack();
                        return "保存特殊信息失败！";
                    }

                    DataTable dt_Details = dalTrcRollProduct.Get_Details(dr["批号"].ToString(), dr["执行标准"].ToString(), dr["物料编码"].ToString(), dr["钢种"].ToString(), dr["炉号"].ToString(), dr["表判结果"].ToString(), dr["不合格原因"].ToString()).Tables[0];

                    if (dt_Details.Rows.Count > 0)
                    {
                        string sql = "";

                        for (int kk = 0; kk < dt_Details.Rows.Count; kk++)
                        {
                            Mod_TRC_ROLL_PRODCUT modProduct = dalTrcRollProduct.GetModel(dt_Details.Rows[kk]["C_ID"].ToString());

                            if (modProduct != null)
                            {
                                modProduct.C_PCINFO = modProduct.C_PCINFO.Replace("厂外时效", "");

                                string strDJ = "";
                                if (string.IsNullOrEmpty(modProduct.C_JUDGE_LEV_ZH))
                                {
                                    strDJ = "DP";
                                }
                                else
                                {
                                    strDJ = modProduct.C_JUDGE_LEV_ZH;
                                }

                                sql = "insert into ReZJB_GPD(Barcode,WGDH,CK,HW,PCH,WLH,WLMC,SX,PH,GG,BB,GH,ZL,BZ,RQ,RKType,RKRY,WeightRQ,ProduceData,PCInfo,vfree0,vfree3,GPTYPE,ZJBstatus,CAPPK,insertts,vfree1,vfree2) values('" + modProduct.C_BARCODE + "','" + modProduct.C_TRC_ROLL_MAIN_ID + "','" + modProduct.C_LINEWH_CODE + "','" + modProduct.C_LINEWH_LOC_CODE + "','" + modProduct.C_BATCH_NO + "','" + modProduct.C_MAT_CODE + "','" + modProduct.C_MAT_DESC + "','" + strDJ + "','" + modProduct.C_STL_GRD + "','" + modProduct.C_SPEC + "mm','" + modProduct.C_GROUP + "','" + modProduct.C_TICK_NO + "','" + modProduct.N_WGT + "','" + modProduct.C_STD_CODE + "','" + modProduct.D_RKRQ + "','" + modProduct.C_MOVE_DESC + "','" + modProduct.C_RKRY + "','" + modProduct.D_WEIGHT_DT + "','" + modProduct.D_PRODUCE_DATE + "','" + modProduct.C_PCINFO + "','" + modProduct.C_STOVE + "','" + modProduct.C_BZYQ + "','','0','" + modProduct.C_ID + "','" + dTime + "','" + modProduct.C_ZYX1.ToString() + "','" + modProduct.C_ZYX2.ToString() + "')";

                                if (TransactionHelper_SQL.ExecuteSql(sql) == 0)
                                {
                                    TransactionHelper.RollBack();
                                    return "特殊信息传到条码时出错！";
                                }

                                modProduct.C_EMP_ID = userID;
                                modProduct.C_PLANT_DESC = dTime.ToString();

                                if (!dalTrcRollProduct.Update_Trans_XL(modProduct))
                                {
                                    TransactionHelper.RollBack();
                                    return "保存特殊信息出错！";
                                }
                            }
                            else
                            {
                                TransactionHelper.RollBack();
                                return "没有找到线材信息！";
                            }

                        }
                    }
                    else
                    {
                        TransactionHelper.RollBack();
                        return "特殊信息传到条码时出错！";
                    }

                }

                TransactionHelper.Commit();
            }
            catch (Exception ex)
            {
                TransactionHelper.RollBack();
                return "0";
            }

            return result;
        }

        #endregion  ExtensionMethod
    }
}

