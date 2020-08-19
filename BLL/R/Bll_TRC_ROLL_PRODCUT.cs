using System;
using System.Data;
using System.Collections.Generic;
using DAL;
using MODEL;
using System.Linq;

namespace BLL
{
    /// <summary>
    /// 轧钢实绩
    /// </summary>
    public partial class Bll_TRC_ROLL_PRODCUT
    {
        private readonly Dal_TRC_ROLL_PRODCUT dal = new Dal_TRC_ROLL_PRODCUT();
        public Bll_TRC_ROLL_PRODCUT()
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
        /// 是否存在该记录
        /// </summary>
        public Mod_TRC_ROLL_PRODCUT GetModel(string PH, string GH)
        {
            return dal.GetModel(PH, GH);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Mod_TRC_ROLL_PRODCUT model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Mod_TRC_ROLL_PRODCUT model)
        {
            return dal.Update(model);
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update_Batch_No(string C_BATCH_NO)
        {
            return dal.Update_Batch_No(C_BATCH_NO);
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
        public Mod_TRC_ROLL_PRODCUT GetModel(string C_ID)
        {
            return dal.GetModel(C_ID);
        }
        public DataSet GetList_ID(string C_ID)
        {
            return dal.GetList_ID(C_ID);
        }
        /// <summary>
        /// 获得数据列表-转库
        /// </summary>
        /// <param name="strWhere">批号</param>
        /// <returns></returns>
        public DataSet GetList_ZK(string strWhere)
        {
            return dal.GetList_ZK(strWhere);
        }
        /// <summary>
        /// 获得数据列表-未入库
        /// </summary>
        /// <param name="strWhere">批号</param>
        /// <returns></returns>
        public DataSet GetList_WRK(string strWhere)
        {
            return dal.GetList_WRK(strWhere);
        }
        /// <summary>
        /// 获得数据列表-已入库
        /// </summary>
        /// <param name="strWhere">批号</param>
        /// <returns></returns>
        public DataSet GetList_RK(string strWhere)
        {
            return dal.GetList_RK(strWhere);
        }

        /// <summary>
        /// 获得数据列表-零星材已入库
        /// </summary>
        /// <param name="C_LINEWH_AREA_CODE">区域</param>
        /// <param name="begin">起始库位</param>
        /// <param name="end">截止库位</param>
        /// <returns></returns>
        public DataSet GetList_LXC(string C_LINEWH_AREA_CODE, string begin, string end)
        {
            return dal.GetList_LXC(C_LINEWH_AREA_CODE, begin, end);
        }
        /// <summary>
        /// 获得数据列表-已入库-13库到21库
        /// </summary>        
        /// <returns></returns>
        public DataSet GetList_RK_KW_13_21()
        {
            return dal.GetList_RK_KW_13_21();
        }

        /// <summary>
        /// 获得数据列表-已入库
        /// </summary>
        /// <param name="strWhere">批号</param>
        /// <param name="C_LINEWH_LOC_CODE">库位</param>
        /// <param name="C_LINEWH_AREA_CODE">区域</param>
        /// <param name="C_LINEWH_CODE">仓库</param>
        /// <returns></returns>
        public DataSet GetList_RK_KW(string strWhere, string C_LINEWH_LOC_CODE, string C_LINEWH_AREA_CODE, string C_LINEWH_CODE)
        {
            return dal.GetList_RK_KW(strWhere, C_LINEWH_LOC_CODE, C_LINEWH_AREA_CODE, C_LINEWH_CODE);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        /// <param name="strWhere">批号</param>
        /// <returns></returns>
        public DataSet GetList(string strWhere)
        {
            return dal.GetList(strWhere);
        }
        /// <summary>
        /// 条件获得数据列表
        /// </summary>
        /// <param name="begin">生产时间 开始</param>
        /// <param name="end">生产时间 结束</param>
        /// <param name="pland">车间</param>
        /// <param name="batch">批号</param>
        /// <returns></returns>
        public DataSet GetList_Query(DateTime begin, DateTime end, string pland, string batch)
        {
            return dal.GetList_Query(begin, end, pland, batch);
        }

        /// <summary>
        /// 获取线材实绩信息
        /// </summary>
        /// <param name="begin">生产时间 开始</param>
        /// <param name="end">生产时间 结束</param>
        /// <param name="pland">车间</param>
        /// <param name="batch">批号</param>
        /// <returns></returns>
        public DataSet GetProductList(DateTime begin, DateTime end, string pland, string batch)
        {
            return dal.GetProductList(begin, end, pland, batch);
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        /// <param name="C_PLANT_DESC">工厂描述</param>
        /// <param name="c_batch_no">批号</param>
        /// <param name="C_STOVE">炉号</param>
        /// <param name="C_STL_GRD">钢种</param>
        /// <param name="C_STD_CODE">执行标准</param>
        /// <param name="C_SPEC">规格</param>
        /// <param name="C_SHIFT">班次</param>
        /// <param name="C_GROUP">班组</param>
        /// <returns></returns>
        public DataSet GetList_Tick_No(string C_PLANT_DESC, string c_batch_no, string C_STOVE, string C_STL_GRD, string C_STD_CODE, string C_SPEC, string C_SHIFT, string C_GROUP)
        {
            return dal.GetList_Tick_No(C_PLANT_DESC, c_batch_no, C_STOVE, C_STL_GRD, C_STD_CODE, C_SPEC, C_SHIFT, C_GROUP);
        }

        /// <summary>
        /// 获取批号所有钩号信息
        /// </summary>
        /// <param name="C_PLANT_DESC">工厂描述</param>
        /// <param name="c_batch_no">批号</param>
        /// <param name="C_STOVE">炉号</param>
        /// <param name="C_STL_GRD">钢种</param>
        /// <param name="C_STD_CODE">执行标准</param>
        /// <param name="C_SPEC">规格</param>
        /// <param name="C_SHIFT">班次</param>
        /// <param name="C_GROUP">班组</param>
        /// <returns></returns>
        public DataSet GetList_Tick_No_All(string C_PLANT_DESC, string c_batch_no, string C_STOVE, string C_STL_GRD, string C_STD_CODE, string C_SPEC, string C_SHIFT, string C_GROUP)
        {
            return dal.GetList_Tick_No_All(C_PLANT_DESC, c_batch_no, C_STOVE, C_STL_GRD, C_STD_CODE, C_SPEC, C_SHIFT, C_GROUP);
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Mod_TRC_ROLL_PRODCUT> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Mod_TRC_ROLL_PRODCUT> DataTableToList(DataTable dt)
        {
            List<Mod_TRC_ROLL_PRODCUT> modelList = new List<Mod_TRC_ROLL_PRODCUT>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Mod_TRC_ROLL_PRODCUT model;
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
        /// 查询线材综合判定数据
        /// </summary>
        /// <param name="batchNo">批号</param>
        /// <param name="stove">炉号</param>
        /// <param name="strTime1">生产开始时间</param>
        /// <param name="strTime2">生产结束时间</param>
        /// <returns></returns>
        public DataSet GetList(string batchNo, string stove, string strTime1, string strTime2)
        {
            return dal.GetList(batchNo, stove, strTime1, strTime2);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        /// <param name="C_BATCH_NO">批号</param>
        /// <param name="begin">开始时间</param>
        /// <param name="end">结束时间</param> 
        /// <returns></returns>
        public DataSet GetList_GP(DateTime begin, DateTime end, string C_BATCH_NO)
        {
            return dal.GetList_GP(begin, end, C_BATCH_NO);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        /// <param name="C_BATCH_NO">批号</param>
        /// <param name="begin">开始时间</param>
        /// <param name="end">结束时间</param>
        /// <param name="lenwhCode">仓库</param>
        /// <returns></returns>
        public DataSet GetList_WWGP(DateTime begin, DateTime end, string C_BATCH_NO, string lenwhCode)
        {
            return dal.GetList_WWGP(begin, end, C_BATCH_NO, lenwhCode);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        /// <param name="C_BATCH_NO">批号</param>
        /// <param name="begin">开始时间</param>
        /// <param name="end">结束时间</param>
        /// <returns></returns>
        public DataSet GetList_XLSQ(DateTime begin, DateTime end, string C_BATCH_NO)
        {
            return dal.GetList_XLSQ(begin, end, C_BATCH_NO);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        /// <param name="C_BATCH_NO">批号</param> 
        /// <returns></returns>
        public DataSet GetList_TSXX(string C_BATCH_NO, string strTime1, string strTime2, string strTsxx, string strLineCode)
        {
            return dal.GetList_TSXX(C_BATCH_NO, strTime1, strTime2, strTsxx, strLineCode);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        /// <param name="begin">开始时间</param>
        /// <param name="end">结束时间</param>
        /// <param name="C_BATCH_NO">批号</param> 
        /// <returns></returns>
        public DataSet GetList_XL(DateTime begin, DateTime end, string C_BATCH_NO)
        {
            return dal.GetList_XL(begin, end, C_BATCH_NO);
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        /// <param name="C_BATCH_NO">批号</param>
        /// <param name="begin">开始时间</param>
        /// <param name="end">结束时间</param>
        /// <returns></returns>
        public DataSet GetList_PJGX(DateTime begin, DateTime end, string C_BATCH_NO)
        {
            return dal.GetList_PJGX(begin, end, C_BATCH_NO);
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        /// <param name="begin">开始时间</param>
        /// <param name="end">结束时间</param>
        /// <param name="C_BATCH_NO">批号</param>
        /// <returns></returns>
        public DataSet GetList_KJ(DateTime begin, DateTime end, string C_BATCH_NO)
        {
            return dal.GetList_KJ(begin, end, C_BATCH_NO);
        }
        /// <summary>
        /// 获取线材实绩库存数
        /// </summary>
        /// <param name="C_LINEWH_CODE">仓库编码</param>
        /// <returns></returns>
        public DataSet Get_KC_COUNt(string C_LINEWH_CODE)
        {
            return dal.Get_KC_COUNt(C_LINEWH_CODE);
        }
        /// <summary>
        /// 根据idstr获取数据列表
        /// </summary>
        /// <param name="idstr"></param>
        /// <returns></returns>
        public DataSet GetListbyIDORDERBY(string idstr)
        {
            return dal.GetListbyIDORDERBY(idstr);
        }

        /// <summary>
        /// 根据批号获取数据列表
        /// </summary>
        /// <param name="idstr"></param>
        /// <returns></returns>
        public DataSet GetQueryBatch(string batch)
        {
            return dal.GetQueryBatch(batch);
        }
        /// <summary>
        /// 获取数据列表
        /// </summary>
        /// <param name="grd">钢种</param>
        /// <param name="std">执行标准</param>
        /// <param name="ck">仓库</param>
        /// <param name="qy">区域</param>
        /// <param name="kw">库位</param>
        /// <returns></returns>
        public DataSet GetXCKList(string ph, string grd, string std, string ck, string qy, string kw, string status)
        {
            return dal.GetXCKList(ph, grd, std, ck, qy, kw, status);
        }
        /// <summary>
        /// 条件获得数据列表
        /// </summary>
        /// <param name="begin">时间 开始</param>
        /// <param name="end">时间 结束</param>
        /// <param name="pland">车间</param>
        /// <param name="batch">批号</param>
        /// <param name="stl">钢种</param>
        /// <param name="std">执行标准</param>
        /// <returns></returns>
        public DataSet GetList_Query1(DateTime begin, DateTime end, string pland, string batch, string stl, string std)
        {
            return dal.GetList_Query1(begin, end, pland, batch, stl, std);

        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        /// <param name="C_BATCH_NO">批号</param>
        /// <returns></returns>
        public DataSet GetList_Batch(string C_BATCH_NO)
        {
            return dal.GetList_Batch(C_BATCH_NO);
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(string strUserID, Mod_TQC_COMPRE_ROLL model)
        {
            return dal.Update(strUserID, model);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        /// <param name="C_BATCH_NO">批号</param>
        /// <returns></returns>
        public DataSet GetList_Tick_No(string C_BATCH_NO)
        {
            return dal.GetList_Tick_No(C_BATCH_NO);
        }

        /// <summary>
        /// 获得数据列表-已入库
        /// </summary> 
        /// <param name="C_LINEWH_LOC_CODE">库位</param> 
        /// <returns></returns>
        public DataSet GetList_KW_Group(string C_LINEWH_LOC_CODE)
        {
            return dal.GetList_KW_Group(C_LINEWH_LOC_CODE);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        /// <param name="C_BATCH_NO">批号</param>
        /// <returns></returns>
        public DataSet GetList_TickNo_Check(string C_BATCH_NO)
        {
            return dal.GetList_TickNo_Check(C_BATCH_NO);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        /// <param name="C_BATCH_NO">批号</param>
        /// <returns></returns>
        public DataSet Get_All_ByBatch_Trans(string C_BATCH_NO, string C_MASTER_ID)
        {
            return dal.Get_All_ByBatch_Trans(C_BATCH_NO, C_MASTER_ID);
        }
        /// <summary>
        /// 获取库存信息
        /// </summary>
        /// <param name="ph">批号</param>
        /// <param name="grd">钢种</param>
        /// <param name="std">执行标准</param>
        /// <param name="ck">仓库</param>
        /// <param name="qy">区域</param>
        /// <param name="kw">库位</param>
        /// <returns></returns>
        public DataSet GetXCKC(string ph, string grd, string std, string ck, string qy, string kw, string status, string C_QTCKD, string C_ZKD)
        {
            return dal.GetXCKC(ph, grd, std, ck, qy, kw, status, C_QTCKD, C_ZKD);
        }
        /// <summary>
        /// 获取PCI库存差异数据
        /// </summary>
        /// <returns></returns>
        public DataSet GetTMM()
        {
            return dal.GetTMM();
        }
        /// <summary>
        /// 获取条码库存差异数据
        /// </summary>
        /// <returns></returns>
        public DataSet GetPCIM()
        {
            return dal.GetPCIM();
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        /// <param name="begin">开始时间</param>
        /// <param name="end">结束时间</param>
        /// <param name="C_BATCH_NO">批号</param>
        /// <returns></returns>
        public DataSet GetList_TB(string begin, string end, string C_BATCH_NO)
        {
            return dal.GetList_TB(begin, end, C_BATCH_NO);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update_Design(string c_design_no, String C_STD_CODE, string C_STL_GRD)
        {
            return dal.Update_Design(c_design_no, C_STD_CODE, C_STL_GRD);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update_Order_Design(string c_design_no, String C_STD_CODE, string C_STL_GRD)
        {
            return dal.Update_Order_Design(c_design_no, C_STD_CODE, C_STL_GRD);
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Mod_TRC_ROLL_PRODCUT> GetList_WGT_All(string batchno, string strSTLGRD, string strSTDCode, string strDJ, string strMatCode, string strPack, string strLineWHCode)
        {
            DataSet ds = dal.GetList_WGT_All(batchno, strSTLGRD, strSTDCode, strDJ, strMatCode, strPack, strLineWHCode);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet Getlist_Wgt(string batchno, string strSTLGRD, string strSTDCode, string strDJ, string strMatCode, string strPack, string strLineWHCode)
        {
            return dal.GetList_WGT_All(batchno, strSTLGRD, strSTDCode, strDJ, strMatCode, strPack, strLineWHCode);
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public void Update_WGT(string batchno, string strSTLGRD, string strSTDCode, string strDJ, string strMatCode, string strPack, string strLineWHCode, decimal amt, int num)
        {
            List<Mod_TRC_ROLL_PRODCUT> list = GetList_WGT_All(batchno, strSTLGRD, strSTDCode, strDJ, strMatCode, strPack, strLineWHCode);
            if (list.Count > num)
            {
                dal.UpdateInventory(list, amt, num);
            }
        }
        /// <summary>
        /// 修改批号
        /// </summary>
        /// <param name="lineCode">仓库编码</param>
        /// <param name="stlGrd">钢种</param>
        /// <param name="stdCode">执行标准</param>
        /// <param name="sepc">规格</param>
        /// <param name="batchNo">批号</param>
        /// <param name="mtrlCode">物料编码</param>
        /// <param name="zldj">综判等级</param>
        /// <param name="bzyq">包装要求</param>
        /// <param name="batchInfos">改判数据ID</param>
        public void UpdateBatchSameToNc(string lineCode, string stlGrd, string stdCode, string sepc, string batchNo, string mtrlCode, string zldj, string bzyq, List<string> batchInfos, List<string> liststrid)
        {
            dal.UpdateBatchSameToNc(lineCode, stlGrd, stdCode, sepc, batchNo, mtrlCode, zldj, bzyq, batchInfos, liststrid);
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        /// <returns></returns>
        public DataSet GetList_WGD()
        {
            return dal.GetList_WGD();
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        /// <returns></returns>
        public DataSet Get_List_Details(string C_BATCH_NO, string C_STL_GRD, string C_STD_CODE, string C_JUDGE_LEV_BP, string C_JUDGE_LEV_ZH, string C_MAT_CODE)
        {
            return dal.Get_List_Details(C_BATCH_NO, C_STL_GRD, C_STD_CODE, C_JUDGE_LEV_BP, C_JUDGE_LEV_ZH, C_MAT_CODE);
        }


        /// <summary>
        /// 获取在线改判信息列表
        /// </summary>
        /// <param name="C_BATCH_NO">批号</param>
        /// <param name="C_STL_GRD">钢种</param>
        /// <param name="C_STD_CODE">标准</param>
        /// <param name="strTime1">生产开始时间</param>
        /// <param name="strTime2">生产结束时间</param>
        /// <returns></returns>
        public DataSet Get_ZXGP_List(string C_BATCH_NO, string C_STL_GRD, string C_STD_CODE, string strTime1, string strTime2)
        {
            return dal.Get_ZXGP_List(C_BATCH_NO, C_STL_GRD, C_STD_CODE, strTime1, strTime2);
        }

        #endregion  BasicMethod



        /// <summary>
        /// 特殊信息
        /// </summary>
        /// <param name="dt_Batch">需要确认的数据</param>
        /// <param name="TickNo">钩号</param>
        /// <returns></returns>
        public string Send_PcInfo(DataTable dt_Batch, int[] rownumber, string strPcInfo, string strDel)
        {
            string result = "1";

            try
            {
                TransactionHelper.BeginTransaction();
                TransactionHelper_SQL.BeginTransaction();

                Dal_TQC_SPECIFIC_CONTENT_LOG dalLog = new Dal_TQC_SPECIFIC_CONTENT_LOG();

                string pcinfo = strPcInfo + ";";
                string userID = RV.UI.UserInfo.UserID;
                DateTime dTime = RV.UI.ServerTime.timeNow();

                for (int i = 0; i < rownumber.Length; i++)
                {

                    int i_index = rownumber[i];
                    string strID = dt_Batch.Rows[i_index]["C_ID"].ToString();
                    Mod_TRC_ROLL_PRODCUT mod_roll_prodcut = dal.GetModel(strID);

                    if (strDel == "0")
                    {
                        if (dt_Batch.Rows[i_index]["C_PCINFO"].ToString().Contains(pcinfo))
                        {
                            mod_roll_prodcut.C_PCINFO = dt_Batch.Rows[i_index]["C_PCINFO"].ToString().Replace(pcinfo, "");
                        }
                    }
                    else
                    {
                        mod_roll_prodcut.C_PCINFO = mod_roll_prodcut.C_PCINFO + pcinfo;
                    }
                    string strDJ = "";
                    if (string.IsNullOrEmpty(mod_roll_prodcut.C_JUDGE_LEV_ZH))
                    {
                        strDJ = "DP";
                    }
                    else
                    {
                        strDJ = mod_roll_prodcut.C_JUDGE_LEV_ZH;
                    }

                    string sql = "";
                    sql += "insert into ReZJB_GPD(Barcode,WGDH,CK,HW,PCH,WLH,WLMC,SX,PH,GG,BB,GH,ZL,BZ,RQ,RKType,RKRY,WeightRQ,ProduceData,PCInfo,vfree0,vfree3,GPTYPE,ZJBstatus,CAPPK,vfree1,vfree2,insertts) values('" + mod_roll_prodcut.C_BARCODE + "','" + mod_roll_prodcut.C_TRC_ROLL_MAIN_ID + "','" + mod_roll_prodcut.C_LINEWH_CODE + "','" + mod_roll_prodcut.C_LINEWH_LOC_CODE + "','" + mod_roll_prodcut.C_BATCH_NO + "','" + mod_roll_prodcut.C_MAT_CODE + "','" + mod_roll_prodcut.C_MAT_DESC + "','" + strDJ + "','" + mod_roll_prodcut.C_STL_GRD + "','" + mod_roll_prodcut.C_SPEC + "mm','" + mod_roll_prodcut.C_GROUP + "','" + mod_roll_prodcut.C_TICK_NO + "','" + mod_roll_prodcut.N_WGT + "','" + mod_roll_prodcut.C_STD_CODE + "','" + mod_roll_prodcut.D_RKRQ + "','" + mod_roll_prodcut.C_MOVE_DESC + "','" + mod_roll_prodcut.C_RKRY + "','" + mod_roll_prodcut.D_WEIGHT_DT + "','" + mod_roll_prodcut.D_PRODUCE_DATE + "','" + mod_roll_prodcut.C_PCINFO + "','" + mod_roll_prodcut.C_STOVE + "','" + mod_roll_prodcut.C_BZYQ + "','','0','" + mod_roll_prodcut.C_ID + "','" + mod_roll_prodcut.C_ZYX1 + "','" + mod_roll_prodcut.C_ZYX2 + "','" + dTime + "')";

                    if (TransactionHelper_SQL.ExecuteSql(sql) == 0)
                    {
                        TransactionHelper.RollBack();
                        TransactionHelper_SQL.RollBack();
                        return "特殊信息传到条码时出错！";
                    }

                    mod_roll_prodcut.C_EMP_ID = userID;
                    mod_roll_prodcut.C_PLANT_DESC = dTime.ToString();

                    if (!dal.Update_Trans_XL(mod_roll_prodcut))
                    {
                        TransactionHelper.RollBack();
                        TransactionHelper_SQL.RollBack();
                        return "特殊信息保存时出错！";
                    }

                    Mod_TQC_SPECIFIC_CONTENT_LOG modLog = new Mod_TQC_SPECIFIC_CONTENT_LOG();
                    modLog.C_BATCH_NO = mod_roll_prodcut.C_BATCH_NO;
                    if (strDel == "0")
                    {
                        modLog.C_CONTENT = "取消" + strPcInfo;
                    }
                    else
                    {
                        modLog.C_CONTENT = "添加" + strPcInfo;
                    }

                    modLog.C_TICK_NO = mod_roll_prodcut.C_TICK_NO;
                    modLog.C_EMP_ID = userID;

                    if (!dalLog.Add_Trans(modLog))
                    {
                        TransactionHelper.RollBack();
                        TransactionHelper_SQL.RollBack();
                        return "特殊信息保存日志失败！";
                    }

                }

                TransactionHelper.Commit();
                TransactionHelper_SQL.Commit();

                return result;
            }
            catch (Exception ex)
            {
                TransactionHelper.RollBack();
                TransactionHelper_SQL.RollBack();
                return ex.Message;
            }

        }

    }
}

