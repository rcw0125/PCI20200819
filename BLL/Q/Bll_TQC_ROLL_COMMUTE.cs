using System;
using System.Data;
using System.Collections.Generic;
using DAL;
using MODEL;
namespace BLL
{
    /// <summary>
    /// 线材改判记录
    /// </summary>
    public partial class Bll_TQC_ROLL_COMMUTE
    {
        private readonly Dal_TQC_ROLL_COMMUTE dal = new Dal_TQC_ROLL_COMMUTE();
        public Bll_TQC_ROLL_COMMUTE()
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
        public bool Add(Mod_TQC_ROLL_COMMUTE model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Mod_TQC_ROLL_COMMUTE model)
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
        public Mod_TQC_ROLL_COMMUTE GetModel(string C_ID)
        {

            return dal.GetModel(C_ID);
        }
        /// <summary>
        /// 获得数据列表-条件查询
        /// </summary>
        /// <param name="begin">开始时间</param>
        /// <param name="end">结束时间</param>
        /// <param name="C_BATCH_NO">批号</param>
        /// <returns></returns>
		public DataSet GetList_Query(DateTime begin, DateTime end, string C_BATCH_NO)
        {
            return dal.GetList_Query(begin, end, C_BATCH_NO);
        }
        /// <summary>
        /// 获得数据列表-条件查询
        /// </summary> 
        /// <param name="C_BATCH_NO">批号</param>
        /// <returns></returns>
		public DataSet GetList_Query_Cou(string C_BATCH_NO)
        {
            return dal.GetList_Query_Cou(C_BATCH_NO);
        }
        /// <summary>
        /// 获得数据列表-条件查询
        /// </summary>
        /// <param name="begin">开始时间</param>
        /// <param name="end">结束时间</param>
        /// <param name="C_BATCH_NO">批号</param>
        /// <param name="strTime">时间条件</param>
        /// <param name="strGZ">钢种条件</param>
        /// <param name="strPDDJ">判定等级条件</param>
        /// <param name="stl_grd">钢种</param>
        /// <param name="pddj">判定等级</param>
        /// <returns></returns>
        public DataSet GetList_Query_Group(DateTime begin, DateTime end, string C_BATCH_NO, string strTime, string strGZ, string strPDDJ, string stl_grd, string pddj)
        {
            return dal.GetList_Query_Group(begin, end, C_BATCH_NO, strTime, strGZ, strPDDJ, stl_grd, pddj);
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
        public List<Mod_TQC_ROLL_COMMUTE> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Mod_TQC_ROLL_COMMUTE> DataTableToList(DataTable dt)
        {
            List<Mod_TQC_ROLL_COMMUTE> modelList = new List<Mod_TQC_ROLL_COMMUTE>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Mod_TQC_ROLL_COMMUTE model;
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
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
        {
            return dal.GetListByPage(strWhere, orderby, startIndex, endIndex);
        }
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        //public DataSet GetList(int PageSize,int PageIndex,string strWhere)
        //{
        //return dal.GetList(PageSize,PageIndex,strWhere);
        //}

        #endregion  BasicMethod
        #region  ExtensionMethod
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList_max()
        {
            return dal.GetList_max();

        }


        /// <summary>
        /// 改判
        /// </summary>
        /// <param name="strs">已选择的数据ID数组</param>
        /// <param name="strGrd">钢种</param>
        /// <param name="strStdCode">执行标准</param>
        /// <param name="strMatCode">物料编码</param>
        /// <param name="strMatName">物料名称</param>
        /// <param name="strZrdwID">责任单位代码</param>
        /// <param name="strZrdwName">责任单位描述</param>
        /// <param name="strRemark">备注</param>
        /// <param name="strUrl">NC接口地址</param>
        /// <param name="strPDDJ">判定等级</param>
        /// <param name="strZYX1">自由项1</param>
        /// <param name="strZYX2">自由项2</param>
        /// <param name="strBZYQ">包装要求</param>
        /// <param name="strGPYY">改判原因</param>
        /// <returns></returns>
        public string Gp_Roll(string strs, string strGrd, string strStdCode, string strMatCode, string strMatName, string strZrdwID, string strZrdwName, string strRemark, string strUrl, string strPDDJ, string strZYX1, string strZYX2, string strBZYQ, string strGPYY)
        {
            string result = "1";
            try
            {
                Dal_TRC_ROLL_PRODCUT dalTrcRollProduct = new Dal_TRC_ROLL_PRODCUT();
                Dal_Interface_NC_Roll_KC4N dalInterface = new Dal_Interface_NC_Roll_KC4N();
                Dal_TB_STD_CONFIG dalTbStdConfig = new Dal_TB_STD_CONFIG();
                Dal_TQD_DESIGN dalDesign = new Dal_TQD_DESIGN();

                TransactionHelper.BeginTransaction();
                TransactionHelper_SQL.BeginTransaction();

                string strUserID = RV.UI.UserInfo.userID;
                DateTime time = RV.UI.ServerTime.timeNow();

                string strBatch = "";

                string C_MASTER_ID = "";
                string C_GP_BEFORE_ID = "";
                string C_GP_AFTER_ID = "";

                string strDesignNo = dalDesign.Get_Design_No(strStdCode, strGrd);
                if (string.IsNullOrEmpty(strDesignNo))
                {
                    return "改判失败，没有找到对应的执行标准信息！";
                }

                DataTable dt = dal.GetList_max().Tables[0];

                if (string.IsNullOrEmpty(dt.Rows[0]["C_MASTER_ID"].ToString()))
                {
                    C_MASTER_ID = "XJ" + time.ToString("yyMMdd00001");
                }
                else
                {
                    C_MASTER_ID = "XJ" + (Convert.ToInt64(dt.Rows[0]["C_MASTER_ID"].ToString()) + 1).ToString();

                }

                if (string.IsNullOrEmpty(dt.Rows[0]["C_GP_BEFORE_ID"].ToString()))
                {
                    C_GP_BEFORE_ID = "XQ" + time.ToString("yyMMdd00001");
                }
                else
                {
                    C_GP_BEFORE_ID = "XQ" + (Convert.ToInt64(dt.Rows[0]["C_GP_BEFORE_ID"].ToString()) + 1).ToString();

                }

                if (string.IsNullOrEmpty(dt.Rows[0]["C_GP_AFTER_ID"].ToString()))
                {
                    C_GP_AFTER_ID = "XH" + time.ToString("yyMMdd00001");
                }
                else
                {
                    C_GP_AFTER_ID = "XH" + (Convert.ToInt64(dt.Rows[0]["C_GP_AFTER_ID"].ToString()) + 1).ToString();
                }
                string[] strs_Product_ID = strs.Substring(0, strs.Length - 1).Split(',');
                if (strs_Product_ID.Length == 0) return "改判失败，请选择需要改判的数据！";

                for (int i = 0; i < strs_Product_ID.Length; i++)
                {
                    Mod_TRC_ROLL_PRODCUT modProduct = dalTrcRollProduct.GetModel(strs_Product_ID[i]);
                    strBatch = modProduct.C_BATCH_NO;
                    string sql = "";
                    sql += "insert into ReZJB_GPD(Barcode,WGDH,CK,HW,PCH,WLH,WLMC,SX,PH,GG,BB,GH,ZL,BZ,RQ,RKType,RKRY,WeightRQ,ProduceData,PCInfo,vfree0,vfree3,GPTYPE,ZJBstatus,CAPPK,vfree1,vfree2,insertts) values('" + modProduct.C_BARCODE + "','" + modProduct.C_TRC_ROLL_MAIN_ID + "','" + modProduct.C_LINEWH_CODE + "','" + modProduct.C_LINEWH_LOC_CODE + "','" + modProduct.C_BATCH_NO + "','" + strMatCode + "','" + strMatName + "','" + strPDDJ + "','" + strGrd + "','" + modProduct.C_SPEC + "mm','" + modProduct.C_GROUP + "','" + modProduct.C_TICK_NO + "','" + modProduct.N_WGT + "','" + strStdCode + "','" + modProduct.D_RKRQ + "','" + modProduct.C_MOVE_DESC + "','" + modProduct.C_RKRY + "','" + modProduct.D_WEIGHT_DT + "','" + modProduct.D_PRODUCE_DATE + "','" + modProduct.C_PCINFO + "','" + modProduct.C_STOVE + "','" + strBZYQ + "','','0','" + modProduct.C_ID + "','" + strZYX1 + "','" + strZYX2 + "','" + time + "')";
                    if (TransactionHelper_SQL.ExecuteSql(sql) == 0)
                    {
                        TransactionHelper_SQL.RollBack();
                        return "改判失败，信息传到条码时出错！";
                    }


                    if (modProduct != null)
                    {
                        Mod_TQC_ROLL_COMMUTE modTqcRollCommute = new Mod_TQC_ROLL_COMMUTE();
                        modTqcRollCommute.C_ROLL_ID = modProduct.C_ID;
                        modTqcRollCommute.C_STA_ID = modProduct.C_PLANT_ID;
                        //modTqcRollCommute.C_STA_DESC = modProduct.C_PLANT_DESC;
                        modTqcRollCommute.C_STOVE = modProduct.C_STOVE;
                        modTqcRollCommute.C_BATCH_NO = modProduct.C_BATCH_NO;
                        modTqcRollCommute.C_TICK_NO = modProduct.C_TICK_NO;
                        modTqcRollCommute.N_WGT = Convert.ToDecimal(modProduct.N_WGT);
                        modTqcRollCommute.C_STL_GRD_BEFORE = modProduct.C_STL_GRD;
                        modTqcRollCommute.C_STA_ID = modProduct.C_STA_ID;
                        modTqcRollCommute.C_STD_CODE_BEFORE = modProduct.C_STD_CODE;
                        modTqcRollCommute.C_SPEC_BEFORE = modProduct.C_SPEC;
                        modTqcRollCommute.C_MAT_CODE_BEFORE = modProduct.C_MAT_CODE;
                        modTqcRollCommute.C_MAT_DESC_BEFORE = modProduct.C_MAT_DESC;
                        modTqcRollCommute.C_ZYX1_BEFORE = modProduct.C_ZYX1;
                        modTqcRollCommute.C_ZYX2_BEFORE = modProduct.C_ZYX2;
                        modTqcRollCommute.C_JUDGE_LEV_BP_BEFORE = modProduct.C_JUDGE_LEV_ZH;
                        modTqcRollCommute.D_COMMUTE_DATE = time;
                        modTqcRollCommute.C_STL_GRD_AFTER = strGrd;
                        modTqcRollCommute.C_STD_CODE_AFTER = strStdCode;
                        modTqcRollCommute.C_SPEC_AFTER = modProduct.C_SPEC;
                        modTqcRollCommute.C_MAT_CODE_AFTER = strMatCode;
                        modTqcRollCommute.C_MAT_DESC_AFTER = strMatName;
                        modTqcRollCommute.C_REASON_DEPMT_ID = strZrdwID;
                        modTqcRollCommute.C_REASON_DEPMT_DESC = strZrdwName;
                        modTqcRollCommute.C_ZYX1_AFTER = strZYX1;
                        modTqcRollCommute.C_ZYX2_AFTER = strZYX2;
                        modTqcRollCommute.C_EMP_ID = strUserID;
                        modTqcRollCommute.C_REMARK = strRemark;
                        modTqcRollCommute.C_MASTER_ID = C_MASTER_ID;
                        modTqcRollCommute.C_GP_BEFORE_ID = C_GP_BEFORE_ID;
                        modTqcRollCommute.C_GP_AFTER_ID = C_GP_AFTER_ID;
                        modTqcRollCommute.C_JUDGE_LEV_BP_AFTER = strPDDJ;
                        modTqcRollCommute.C_BZYQ_AFTER = strBZYQ;
                        modTqcRollCommute.C_BZYQ_BEFORE = modProduct.C_BZYQ;
                        modTqcRollCommute.C_COMMUTE_REASON = strGPYY;

                        if (dal.Add_Trans(modTqcRollCommute))
                        {
                            modProduct.C_STD_CODE = strStdCode;
                            modProduct.C_STL_GRD = strGrd;
                            modProduct.C_MAT_DESC = strMatName;
                            modProduct.C_MAT_CODE = strMatCode;
                            modProduct.C_MASTER_ID = C_MASTER_ID;
                            modProduct.C_JUDGE_LEV_ZH = strPDDJ;
                            modProduct.C_GP_BEFORE_ID = C_GP_BEFORE_ID;
                            modProduct.C_GP_AFTER_ID = C_GP_AFTER_ID;
                            modProduct.C_ZYX1 = strZYX1;
                            modProduct.C_ZYX2 = strZYX2;
                            modProduct.C_BZYQ = strBZYQ;
                            modProduct.C_JUDGE_LEV_ZH = strPDDJ;
                            modProduct.C_IS_PD = "N";
                            modProduct.C_IS_QR = "Y";
                            modProduct.C_QR_USER = strUserID;
                            modProduct.D_QR_DATE = time;
                            modProduct.C_DESIGN_NO = strDesignNo;
                            modProduct.C_QGP_STATE = "Y";
                            modProduct.C_COMMUTE_REASON = strGPYY;

                            if (!dalTrcRollProduct.Update_Trans(modProduct))
                            {
                                TransactionHelper.RollBack();
                                TransactionHelper_SQL.RollBack();
                                return "改判失败，请检查改判的信息！";
                            }
                        }
                        else
                        {
                            TransactionHelper.RollBack();
                            TransactionHelper_SQL.RollBack();
                            return "改判失败，添加改判记录失败!";
                        }
                    }
                }

                //综合判定需要
                if (!dalTrcRollProduct.Update_Batch_No(strBatch))
                {
                    TransactionHelper.RollBack();
                    TransactionHelper_SQL.RollBack();
                    return "改判失败，请检查批号！";
                }


                string result_NC = dalInterface.SendXml_GP(strUrl, C_MASTER_ID, C_GP_BEFORE_ID, C_GP_AFTER_ID);

                if (result_NC != "1")
                {
                    TransactionHelper.RollBack();
                    TransactionHelper_SQL.RollBack();
                    return result_NC;
                }

                TransactionHelper_SQL.Commit();
                TransactionHelper.Commit();
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
        /// 改判
        /// </summary>
        /// <param name="strs">已选择的数据ID数组</param>
        /// <param name="strGrd">钢种</param>
        /// <param name="strStdCode">执行标准</param>
        /// <param name="strMatCode">物料编码</param>
        /// <param name="strMatName">物料名称</param>
        /// <param name="strZrdwID">责任单位代码</param>
        /// <param name="strZrdwName">责任单位描述</param>
        /// <param name="strRemark">备注</param>
        /// <param name="strUrl">NC接口地址</param>
        /// <param name="strPDDJ">判定等级</param>
        /// <param name="strZYX1">自由项1</param>
        /// <param name="strZYX2">自由项2</param>
        /// <param name="strBZYQ">包装要求</param>
        /// <param name="strGPYY">改判原因</param>
        /// <returns></returns>
        public string Gp_Roll_WW(string strs, string strGrd, string strStdCode, string strMatCode, string strMatName, string strZrdwID, string strZrdwName, string strRemark, string strUrl, string strPDDJ, string strZYX1, string strZYX2, string strBZYQ, string strGPYY)
        {
            string result = "1";
            try
            {
                Dal_TRC_ROLL_PRODCUT dalTrcRollProduct = new Dal_TRC_ROLL_PRODCUT();
                Dal_Interface_NC_Roll_KC4N dalInterface = new Dal_Interface_NC_Roll_KC4N();
                Dal_TB_STD_CONFIG dalTbStdConfig = new Dal_TB_STD_CONFIG();
                Dal_TQD_DESIGN dalDesign = new Dal_TQD_DESIGN();

                TransactionHelper.BeginTransaction();
                TransactionHelper_SQL.BeginTransaction();

                string strUserID = RV.UI.UserInfo.userID;
                DateTime time = RV.UI.ServerTime.timeNow();

                string strBatch = "";

                string C_MASTER_ID = "";
                string C_GP_BEFORE_ID = "";
                string C_GP_AFTER_ID = "";

                string strDesignNo = dalDesign.Get_Design_No(strStdCode, strGrd);
                if (string.IsNullOrEmpty(strDesignNo))
                {
                    return "改判失败，没有找到对应的执行标准信息！";
                }

                DataTable dt = dal.GetList_max().Tables[0];

                if (string.IsNullOrEmpty(dt.Rows[0]["C_MASTER_ID"].ToString()))
                {
                    C_MASTER_ID = "XJ" + time.ToString("yyMMdd00001");
                }
                else
                {
                    C_MASTER_ID = "XJ" + (Convert.ToInt64(dt.Rows[0]["C_MASTER_ID"].ToString()) + 1).ToString();

                }

                if (string.IsNullOrEmpty(dt.Rows[0]["C_GP_BEFORE_ID"].ToString()))
                {
                    C_GP_BEFORE_ID = "XQ" + time.ToString("yyMMdd00001");
                }
                else
                {
                    C_GP_BEFORE_ID = "XQ" + (Convert.ToInt64(dt.Rows[0]["C_GP_BEFORE_ID"].ToString()) + 1).ToString();

                }

                if (string.IsNullOrEmpty(dt.Rows[0]["C_GP_AFTER_ID"].ToString()))
                {
                    C_GP_AFTER_ID = "XH" + time.ToString("yyMMdd00001");
                }
                else
                {
                    C_GP_AFTER_ID = "XH" + (Convert.ToInt64(dt.Rows[0]["C_GP_AFTER_ID"].ToString()) + 1).ToString();
                }
                string[] strs_Product_ID = strs.Substring(0, strs.Length - 1).Split(',');
                if (strs_Product_ID.Length == 0) return "改判失败，请选择需要改判的数据！";

                for (int i = 0; i < strs_Product_ID.Length; i++)
                {
                    Mod_TRC_ROLL_PRODCUT modProduct = dalTrcRollProduct.GetModel(strs_Product_ID[i]);
                    strBatch = modProduct.C_BATCH_NO;

                    if (modProduct != null)
                    {
                        Mod_TQC_ROLL_COMMUTE modTqcRollCommute = new Mod_TQC_ROLL_COMMUTE();
                        modTqcRollCommute.C_ROLL_ID = modProduct.C_ID;
                        modTqcRollCommute.C_STA_ID = modProduct.C_PLANT_ID;
                        //modTqcRollCommute.C_STA_DESC = modProduct.C_PLANT_DESC;
                        modTqcRollCommute.C_STOVE = modProduct.C_STOVE;
                        modTqcRollCommute.C_BATCH_NO = modProduct.C_BATCH_NO;
                        modTqcRollCommute.C_TICK_NO = modProduct.C_TICK_NO;
                        modTqcRollCommute.N_WGT = Convert.ToDecimal(modProduct.N_WGT);
                        modTqcRollCommute.C_STL_GRD_BEFORE = modProduct.C_STL_GRD;
                        modTqcRollCommute.C_STA_ID = modProduct.C_STA_ID;
                        modTqcRollCommute.C_STD_CODE_BEFORE = modProduct.C_STD_CODE;
                        modTqcRollCommute.C_SPEC_BEFORE = modProduct.C_SPEC;
                        modTqcRollCommute.C_MAT_CODE_BEFORE = modProduct.C_MAT_CODE;
                        modTqcRollCommute.C_MAT_DESC_BEFORE = modProduct.C_MAT_DESC;
                        modTqcRollCommute.C_ZYX1_BEFORE = modProduct.C_ZYX1;
                        modTqcRollCommute.C_ZYX2_BEFORE = modProduct.C_ZYX2;
                        modTqcRollCommute.C_JUDGE_LEV_BP_BEFORE = modProduct.C_JUDGE_LEV_ZH;
                        modTqcRollCommute.D_COMMUTE_DATE = time;
                        modTqcRollCommute.C_STL_GRD_AFTER = strGrd;
                        modTqcRollCommute.C_STD_CODE_AFTER = strStdCode;
                        modTqcRollCommute.C_SPEC_AFTER = modProduct.C_SPEC;
                        modTqcRollCommute.C_MAT_CODE_AFTER = strMatCode;
                        modTqcRollCommute.C_MAT_DESC_AFTER = strMatName;
                        modTqcRollCommute.C_REASON_DEPMT_ID = strZrdwID;
                        modTqcRollCommute.C_REASON_DEPMT_DESC = strZrdwName;
                        modTqcRollCommute.C_ZYX1_AFTER = strZYX1;
                        modTqcRollCommute.C_ZYX2_AFTER = strZYX2;
                        modTqcRollCommute.C_EMP_ID = strUserID;
                        modTqcRollCommute.C_REMARK = strRemark;
                        modTqcRollCommute.C_MASTER_ID = C_MASTER_ID;
                        modTqcRollCommute.C_GP_BEFORE_ID = C_GP_BEFORE_ID;
                        modTqcRollCommute.C_GP_AFTER_ID = C_GP_AFTER_ID;
                        modTqcRollCommute.C_JUDGE_LEV_BP_AFTER = strPDDJ;
                        modTqcRollCommute.C_BZYQ_AFTER = strBZYQ;
                        modTqcRollCommute.C_BZYQ_BEFORE = modProduct.C_BZYQ;
                        modTqcRollCommute.C_COMMUTE_REASON = strGPYY;

                        if (dal.Add_Trans(modTqcRollCommute))
                        {
                            modProduct.C_STD_CODE = strStdCode;
                            modProduct.C_STL_GRD = strGrd;
                            modProduct.C_MAT_DESC = strMatName;
                            modProduct.C_MAT_CODE = strMatCode;
                            modProduct.C_MASTER_ID = C_MASTER_ID;
                            modProduct.C_JUDGE_LEV_ZH = strPDDJ;
                            modProduct.C_GP_BEFORE_ID = C_GP_BEFORE_ID;
                            modProduct.C_GP_AFTER_ID = C_GP_AFTER_ID;
                            modProduct.C_ZYX1 = strZYX1;
                            modProduct.C_ZYX2 = strZYX2;
                            modProduct.C_BZYQ = strBZYQ;
                            modProduct.C_JUDGE_LEV_ZH = strPDDJ;
                            modProduct.C_IS_PD = "N";
                            modProduct.C_IS_QR = "Y";
                            modProduct.C_QR_USER = strUserID;
                            modProduct.D_QR_DATE = time;
                            modProduct.C_DESIGN_NO = strDesignNo;
                            modProduct.C_QGP_STATE = "Y";
                            modProduct.C_COMMUTE_REASON = strGPYY;

                            if (!dalTrcRollProduct.Update_Trans(modProduct))
                            {
                                TransactionHelper.RollBack();
                                TransactionHelper_SQL.RollBack();
                                return "改判失败，请检查改判的信息！";
                            }
                        }
                        else
                        {
                            TransactionHelper.RollBack();
                            TransactionHelper_SQL.RollBack();
                            return "改判失败，添加改判记录失败!";
                        }
                    }
                }

                //综合判定需要
                if (!dalTrcRollProduct.Update_Batch_No(strBatch))
                {
                    TransactionHelper.RollBack();
                    TransactionHelper_SQL.RollBack();
                    return "改判失败，请检查批号！";
                }


                string result_NC = dalInterface.SendXml_GP(strUrl, C_MASTER_ID, C_GP_BEFORE_ID, C_GP_AFTER_ID);

                if (result_NC != "1")
                {
                    TransactionHelper.RollBack();
                    TransactionHelper_SQL.RollBack();
                    return result_NC;
                }

                TransactionHelper_SQL.Commit();
                TransactionHelper.Commit();
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
        /// 修料
        /// </summary>
        /// <param name="strs">线材实绩主键</param>
        /// <param name="Type">修料状态</param>
        /// <param name="PCINFO">特殊信息</param>
        /// <returns></returns>
        public int TransaTSXX(string strs, string Type, string PCINFO, string rollID, string strSFHG)
        {
            try
            {
                Dal_TRC_ROLL_PRODCUT dalTrcRollProduct = new Dal_TRC_ROLL_PRODCUT();
                Dal_TQC_UPDATE_MATERIAL dal_Update = new Dal_TQC_UPDATE_MATERIAL();
                Dal_TQC_UPDATE_MATERIAL_LOG dal_update_log = new Dal_TQC_UPDATE_MATERIAL_LOG();
                Dal_TQC_UPD_MATERIAL_MAIN dalUpdMain = new Dal_TQC_UPD_MATERIAL_MAIN();
                Dal_Interface_FR dalInterface_FR = new Dal_Interface_FR();
                Dal_TQC_SPECIFIC_CONTENT_LOG dalLog = new Dal_TQC_SPECIFIC_CONTENT_LOG();
                TransactionHelper.BeginTransaction();
                TransactionHelper_SQL.BeginTransaction();


                string strUserID = RV.UI.UserInfo.UserID;
                DateTime dTime = RV.UI.ServerTime.timeNow();

                string[] strs_Product_ID = strs.Substring(0, strs.Length - 1).Split(',');
                string[] strs_ID = null;
                if (rollID != "")
                {
                    strs_ID = rollID.Substring(0, rollID.Length - 1).Split(',');
                }


                if (strs_Product_ID.Length == 0)
                {
                    TransactionHelper_SQL.RollBack();
                    TransactionHelper.RollBack();
                    return 0;
                }
                for (int i = 0; i < strs_Product_ID.Length; i++)
                {
                    Mod_TRC_ROLL_PRODCUT modProduct = dalTrcRollProduct.GetModel(strs_Product_ID[i]);
                    Mod_TQC_UPDATE_MATERIAL_LOG mod_log = new Mod_TQC_UPDATE_MATERIAL_LOG();

                    decimal? wgt = modProduct.N_WGT;
                    DataTable dt = dalInterface_FR.Get_TM_XL_List(modProduct.C_BATCH_NO, modProduct.C_TICK_NO).Tables[0];
                    if (dt == null)
                    {
                        TransactionHelper_SQL.RollBack();
                        TransactionHelper.RollBack();
                        return 0;
                    }
                    if (rollID == "")
                    {
                        Mod_TQC_UPDATE_MATERIAL mod = new Mod_TQC_UPDATE_MATERIAL();

                        mod.C_ROLL_PRODUCT_ID = modProduct.C_ID;
                        mod.C_TYPE = Type;
                        mod.C_EMP_ID = strUserID;
                        mod.C_SFHG = strSFHG;
                        mod_log.C_TYPE = mod.C_TYPE;
                        dalUpdMain.Update_BATCH_NO(modProduct.C_BATCH_NO);

                        if (!dal_Update.Add_Trans(mod))
                        {
                            TransactionHelper_SQL.RollBack();
                            TransactionHelper.RollBack();
                            return 0;
                        }
                    }
                    else
                    {
                        Mod_TQC_UPDATE_MATERIAL mod = dal_Update.GetModel(strs_ID[i]);
                        if (Type == "2")
                        {
                            if (mod.C_TYPE == "3")
                            {
                                mod.C_TYPE = "6";
                                PCINFO = "0";
                                Mod_TQC_UPDATE_MATERIAL_LOG mod_logs = new Mod_TQC_UPDATE_MATERIAL_LOG();
                                mod_logs.C_TYPE = "2";
                                mod_logs.N_WGT = wgt;
                                mod_logs.N_WGT_DIFFERENCE = wgt - Convert.ToDecimal(dt.Rows[0]["ZL"]);
                                mod_logs.C_SFHG = mod.C_SFHG;
                                mod_logs.C_ROLL_PRODUCT_ID = modProduct.C_ID;
                                mod_logs.C_EMP_ID = strUserID;

                                if (!dal_update_log.Add_Trans(mod_logs))
                                {
                                    TransactionHelper_SQL.RollBack();
                                    TransactionHelper.RollBack();
                                    return 0;
                                }
                            }
                            else
                            {
                                mod.C_TYPE = Type;
                            }
                        }
                        if (Type == "3")
                        {
                            if (mod.C_TYPE == "2")
                            {
                                mod.C_TYPE = "6";
                                PCINFO = "0";
                                Mod_TQC_UPDATE_MATERIAL_LOG mod_logs = new Mod_TQC_UPDATE_MATERIAL_LOG();
                                mod_logs.C_TYPE = "3";
                                mod_logs.N_WGT = wgt;
                                mod_logs.N_WGT_DIFFERENCE = wgt - Convert.ToDecimal(dt.Rows[0]["ZL"]);
                                mod_logs.C_SFHG = mod.C_SFHG;
                                mod_logs.C_ROLL_PRODUCT_ID = modProduct.C_ID;
                                mod_logs.C_EMP_ID = strUserID;

                                if (!dal_update_log.Add_Trans(mod_logs))
                                {
                                    TransactionHelper_SQL.RollBack();
                                    TransactionHelper.RollBack();
                                    return 0;
                                }
                            }
                            else
                            {
                                mod.C_TYPE = Type;
                            }
                        }
                        mod.C_EMP_ID = strUserID;
                        mod.D_MOD_DT = dTime;
                        mod.N_WGT = wgt;
                        mod.C_SFHG = strSFHG;
                        mod.N_WGT_DIFFERENCE = wgt - Convert.ToDecimal(dt.Rows[0]["ZL"]);
                        mod_log.C_TYPE = mod.C_TYPE;
                        mod_log.N_WGT = wgt;
                        mod_log.N_WGT_DIFFERENCE = wgt - Convert.ToDecimal(dt.Rows[0]["ZL"]);
                        mod_log.C_SFHG = mod.C_SFHG;
                        modProduct.N_WGT = Convert.ToDecimal(dt.Rows[0]["ZL"]);

                        if (!dal_Update.Update_Trans(mod))
                        {
                            TransactionHelper_SQL.RollBack();
                            TransactionHelper.RollBack();
                            return 0;
                        }
                    }
                    if (PCINFO == "0")
                    {
                        if (modProduct.C_PCINFO.Contains("待修料;"))
                        {
                            modProduct.C_PCINFO = modProduct.C_PCINFO.Replace("待修料;", "");
                        }

                    }
                    else
                    {
                        if (modProduct.C_PCINFO == "")
                        {
                            modProduct.C_PCINFO = PCINFO + ";";
                        }
                        else if (modProduct.C_PCINFO.Contains("待修料"))
                        {
                            modProduct.C_PCINFO = modProduct.C_PCINFO;
                        }
                        else
                        {
                            modProduct.C_PCINFO = modProduct.C_PCINFO + PCINFO + ";";
                        }
                    }


                    modProduct.C_EMP_ID = strUserID;
                    modProduct.C_PLANT_DESC = dTime.ToString();

                    if (!dalTrcRollProduct.Update_Trans_XL(modProduct))
                    {
                        TransactionHelper_SQL.RollBack();
                        TransactionHelper.RollBack();
                        return 0;
                    }

                    mod_log.C_ROLL_PRODUCT_ID = modProduct.C_ID;
                    mod_log.C_EMP_ID = strUserID;

                    if (!dal_update_log.Add_Trans(mod_log))
                    {
                        TransactionHelper_SQL.RollBack();
                        TransactionHelper.RollBack();
                        return 0;
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

                    string sql = "";
                    sql += "insert into ReZJB_GPD(Barcode,WGDH,CK,HW,PCH,WLH,WLMC,SX,PH,GG,BB,GH,ZL,BZ,RQ,RKType,RKRY,WeightRQ,ProduceData,PCInfo,vfree0,vfree3,GPTYPE,ZJBstatus,CAPPK,vfree1,vfree2,insertts) values('" + modProduct.C_BARCODE + "','" + modProduct.C_TRC_ROLL_MAIN_ID + "','" + modProduct.C_LINEWH_CODE + "','" + modProduct.C_LINEWH_LOC_CODE + "','" + modProduct.C_BATCH_NO + "','" + modProduct.C_MAT_CODE + "','" + modProduct.C_MAT_DESC + "','" + strDJ + "','" + modProduct.C_STL_GRD + "','" + modProduct.C_SPEC + "mm','" + modProduct.C_GROUP + "','" + modProduct.C_TICK_NO + "','" + modProduct.N_WGT + "','" + modProduct.C_STD_CODE + "','" + modProduct.D_RKRQ + "','" + modProduct.C_MOVE_DESC + "','" + modProduct.C_RKRY + "','" + modProduct.D_WEIGHT_DT + "','" + modProduct.D_PRODUCE_DATE + "','" + modProduct.C_PCINFO + "','" + modProduct.C_STOVE + "','" + modProduct.C_BZYQ + "','','0','" + modProduct.C_ID + "','" + modProduct.C_ZYX1 + "','" + modProduct.C_ZYX2 + "','" + RV.UI.ServerTime.timeNow() + "')";
                    if (TransactionHelper_SQL.ExecuteSql(sql) == 0)
                    {
                        TransactionHelper_SQL.RollBack();
                        TransactionHelper.RollBack();
                        return 0;
                    }
                    else
                    {
                        if (rollID != "")
                        {
                            Mod_TQC_UPDATE_MATERIAL mod = dal_Update.GetModel(strs_ID[i]);
                            if (Type == "2")
                            {
                                if (mod.C_TYPE == "3")
                                {
                                    Mod_TQC_SPECIFIC_CONTENT_LOG modLog = new Mod_TQC_SPECIFIC_CONTENT_LOG();
                                    modLog.C_BATCH_NO = modProduct.C_BATCH_NO;
                                    modLog.C_CONTENT = "取消待修料";
                                    modLog.C_TICK_NO = modProduct.C_TICK_NO;
                                    modLog.C_EMP_ID = strUserID;
                                    if (!dalLog.Add_Trans(modLog))
                                    {
                                        TransactionHelper.RollBack();
                                        TransactionHelper_SQL.RollBack();
                                        return 0;
                                    }
                                }
                            }
                            if (Type == "3")
                            {
                                if (mod.C_TYPE == "2")
                                {
                                    Mod_TQC_SPECIFIC_CONTENT_LOG modLog = new Mod_TQC_SPECIFIC_CONTENT_LOG();
                                    modLog.C_BATCH_NO = modProduct.C_BATCH_NO;
                                    modLog.C_CONTENT = "取消待修料";
                                    modLog.C_TICK_NO = modProduct.C_TICK_NO;
                                    modLog.C_EMP_ID = strUserID;
                                    if (!dalLog.Add_Trans(modLog))
                                    {
                                        TransactionHelper.RollBack();
                                        TransactionHelper_SQL.RollBack();
                                        return 0;
                                    }
                                }
                            }


                        }
                    }
                }
                TransactionHelper_SQL.Commit();
                TransactionHelper.Commit();
                return 1;
            }
            catch (Exception ex)
            {
                TransactionHelper_SQL.RollBack();
                TransactionHelper.RollBack();
                return 0;
            }
        }

        #endregion  ExtensionMethod
    }
}

