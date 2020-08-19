using System;
using System.Data;
using System.Collections.Generic;
using MODEL;
using DAL;
namespace BLL
{
    /// <summary>
    /// 钢坯综合判定信息表
    /// </summary>
    public partial class Bll_TQC_COMPRE_SLAB
    {
        private readonly Dal_TQC_COMPRE_SLAB dal = new Dal_TQC_COMPRE_SLAB();
        public Bll_TQC_COMPRE_SLAB()
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
        public bool Add(Mod_TQC_COMPRE_SLAB model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Mod_TQC_COMPRE_SLAB model)
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
        public Mod_TQC_COMPRE_SLAB GetModel(string C_ID)
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
        /// 查询钢坯综合判定数据
        /// </summary>
        /// <param name="stove">炉号</param>
        /// <param name="strTime1">生产开始时间</param>
        /// <param name="strTime2">生产结束时间</param>
        /// <param name="strState">确认状态；全部，已确认，未确认</param>
        /// <returns></returns>
        public DataSet GetList(string stove, string strTime1, string strTime2, string strState)
        {
            return dal.GetList(stove, strTime1, strTime2, strState);
        }

        /// <summary>
        /// 查询钢坯综合判定数据
        /// </summary>
        /// <param name="stove">炉号</param>
        /// <param name="strTime1">生产开始时间</param>
        /// <param name="strTime2">生产结束时间</param>
        /// <param name="strState">确认状态；全部，已确认，未确认</param>
        /// <param name="strGZ">钢种</param>
        /// <param name="strBZ">标准</param>
        /// <returns></returns>
        public DataSet GetList_CX(string stoveMin, string stoveMax, string strTime1, string strTime2, string strState, string strGZ, string strBZ)
        {
            return dal.GetList_CX(stoveMin, stoveMax, strTime1, strTime2, strState, strGZ, strBZ);
        }

        #endregion  BasicMethod
        #region  ExtensionMethod

        /// <summary>
        /// 钢坯综合判定确认
        /// </summary>
        /// <param name="modTqcCompreSlab">需要确认实体信息</param>
        /// <param name="strResult">判定结果</param>
        /// <returns></returns>
        public string Slab_Compre_OK(Mod_TQC_COMPRE_SLAB modTqcCompreSlab, string strResult)
        {
            string result = "1";
            try
            {
                Dal_TSC_SLAB_MAIN dalTscSlabMain = new Dal_TSC_SLAB_MAIN();
                Dal_TSC_SLAB_MES dalTscSLabMes = new Dal_TSC_SLAB_MES();
                Dal_TQC_QUA_RESULT dalTqcQuaResult = new Dal_TQC_QUA_RESULT();

                TransactionHelper.BeginTransaction();

                string strUserID = RV.UI.UserInfo.userID;
                DateTime time = RV.UI.ServerTime.timeNow();
                string strUserAccount = RV.UI.UserInfo.userAccount;

                if(strUserAccount== "system")
                {
                    TransactionHelper.RollBack();
                    return "不能用管理员账号确认！";
                }

                //string V_GUID = Guid.NewGuid().ToString();
                string V_GUID = Guid.NewGuid().ToString("B").ToUpper();

                modTqcCompreSlab.C_QR_STATE = "Y";
                modTqcCompreSlab.C_EMP_ID = strUserID;
                modTqcCompreSlab.D_MOD_DT = time;

                if (dal.Update_Trans(modTqcCompreSlab))
                {
                    if (dalTscSlabMain.Update_Trans(strResult, strUserID, modTqcCompreSlab))
                    {
                        Mod_TSC_SLAB_MES modTscSlabMes = dalTscSLabMes.GetModel(modTqcCompreSlab.C_STOVE);

                        string strLGJH = dalTscSlabMain.Get_LGJH(modTqcCompreSlab.C_STOVE);


                        #region   插入CQA_BLOOM_HOTJUDGE_DATA(表判)

                        int count_mes_bp = dal.Get_MES_BP_Count(modTqcCompreSlab.C_STOVE);
                        if (count_mes_bp == 0)
                        {
                            string sql_bp = "INSERT INTO CQA_BLOOM_HOTJUDGE_DATA@cap_mes";
                            sql_bp += " (GUID,";
                            sql_bp += " NAME, ";
                            sql_bp += " HEATID, ";
                            sql_bp += " CASTERID, ";
                            sql_bp += " STEELGRADEINDEX, ";
                            sql_bp += " LENGTH, ";
                            sql_bp += " WIDTH, ";
                            sql_bp += " THICKNESS,";
                            sql_bp += " BLOOM_COUNT,";
                            sql_bp += " CAL_WEIGHT, ";
                            sql_bp += " RIGHT_COUNT, ";
                            sql_bp += " RIGHT_WEIGHT, ";
                            sql_bp += " WASTER_COUNT, ";
                            sql_bp += " WASTER_WEIGHT, ";
                            sql_bp += " WASTER_COUNT1, ";
                            sql_bp += " WASTER_WEIGHT1, ";
                            sql_bp += " WASTER_REASON1, ";
                            sql_bp += " WASTER_COUNT2, ";
                            sql_bp += " WASTER_WEIGHT2, ";
                            sql_bp += " WASTER_REASON2, ";
                            sql_bp += " WASTER_COUNT3, ";
                            sql_bp += " WASTER_WEIGHT3, ";
                            sql_bp += " WASTER_REASON3, ";
                            sql_bp += " WRONG_COUNT, ";
                            sql_bp += " WRONG_WEIGHT, ";
                            sql_bp += " WRONG_COUNT1, ";
                            sql_bp += " WRONG_WEIGHT1, ";
                            sql_bp += " WRONG_REASON1, ";
                            sql_bp += " WRONG_COUNT2, ";
                            sql_bp += " WRONG_WEIGHT2, ";
                            sql_bp += " WRONG_REASON2, ";
                            sql_bp += " WRONG_COUNT3, ";
                            sql_bp += " WRONG_WEIGHT3, ";
                            sql_bp += " WRONG_REASON3, ";
                            sql_bp += " SUFACEDEFACTDES, ";
                            sql_bp += " HOTJUDGE_TIME, ";
                            sql_bp += " WAITCHECKFLAG, ";
                            sql_bp += " TEAM, ";
                            sql_bp += " SHIFT, ";
                            sql_bp += " OPERATOR ";
                            sql_bp += " ) ";
                            sql_bp += " values ";
                            sql_bp += " ('" + V_GUID + "',";
                            sql_bp += " '" + modTscSlabMes.NAME + "', ";
                            sql_bp += " '" + modTscSlabMes.MATERIALID + "', ";
                            sql_bp += " '" + modTscSlabMes.CASTERID + "', ";
                            sql_bp += " '" + strLGJH + "', ";
                            sql_bp += " '" + modTscSlabMes.LENGTH + "', ";
                            sql_bp += " '" + modTscSlabMes.WIDTH + "', ";
                            sql_bp += " '" + modTscSlabMes.THICKNESS + "',";
                            sql_bp += " '" + modTscSlabMes.BLOOM_COUNT + "',";
                            sql_bp += " '" + modTscSlabMes.CAL_WEIGHT + "', ";
                            sql_bp += " '" + modTscSlabMes.RIGHT_COUNT + "', ";
                            sql_bp += " '" + modTscSlabMes.RIGHT_WEIGHT + "', ";
                            sql_bp += " '" + modTscSlabMes.WASTER_COUNT + "', ";
                            sql_bp += " '" + modTscSlabMes.WASTER_WEIGHT + "', ";
                            sql_bp += " '" + modTscSlabMes.WASTER_COUNT1 + "', ";
                            sql_bp += " '" + modTscSlabMes.WASTER_WEIGHT1 + "', ";
                            sql_bp += " '" + modTscSlabMes.WASTER_REASON1 + "', ";
                            sql_bp += " '" + modTscSlabMes.WASTER_COUNT2 + "', ";
                            sql_bp += " '" + modTscSlabMes.WASTER_WEIGHT2 + "', ";
                            sql_bp += " '" + modTscSlabMes.WASTER_REASON2 + "', ";
                            sql_bp += " '" + modTscSlabMes.WASTER_COUNT3 + "', ";
                            sql_bp += " '" + modTscSlabMes.WASTER_WEIGHT3 + "', ";
                            sql_bp += " '" + modTscSlabMes.WASTER_REASON3 + "', ";
                            sql_bp += " '" + modTscSlabMes.WRONG_COUNT + "', ";
                            sql_bp += " '" + modTscSlabMes.WRONG_WEIGHT + "', ";
                            sql_bp += " '" + modTscSlabMes.WRONG_COUNT1 + "', ";
                            sql_bp += " '" + modTscSlabMes.WRONG_WEIGHT1 + "', ";
                            sql_bp += " '" + modTscSlabMes.WRONG_REASON1 + "', ";
                            sql_bp += " '" + modTscSlabMes.WRONG_COUNT2 + "', ";
                            sql_bp += " '" + modTscSlabMes.WRONG_WEIGHT2 + "', ";
                            sql_bp += " '" + modTscSlabMes.WRONG_REASON2 + "', ";
                            sql_bp += " '" + modTscSlabMes.WRONG_COUNT3 + "', ";
                            sql_bp += " '" + modTscSlabMes.WRONG_WEIGHT3 + "', ";
                            sql_bp += " '" + modTscSlabMes.WRONG_REASON3 + "', ";
                            sql_bp += " '" + modTscSlabMes.SUFACEDEFACTDES + "', ";
                            sql_bp += " to_date('" + time + "','yyyy-mm-dd hh24:mi:ss'), ";
                            sql_bp += " '0', ";
                            sql_bp += " '1', ";//班组
                            sql_bp += " '1', ";//班次
                            sql_bp += " '"+ strUserAccount + "' ";//操作人
                            sql_bp += " ) ";

                            if (!dal.Add_Mes_Trans(sql_bp))
                            {
                                TransactionHelper.RollBack();
                                //Transaction_MES.RollBack();
                                return "更新MES表判信息失败";
                            }
                        }

                        #endregion


                        #region   插入CQA_BLOOM_FINJUDGE_DATA(综判)

                        int count_mes_zp = dal.Get_MES_ZP_Count(modTqcCompreSlab.C_STOVE);
                        if (count_mes_zp == 0)
                        {
                            string sql_zp = "INSERT INTO CQA_BLOOM_FINJUDGE_DATA@cap_mes";
                            sql_zp += " (GUID, ";
                            sql_zp += " NAME, ";
                            sql_zp += " HEATID, ";
                            sql_zp += " CASTERID, ";
                            sql_zp += " PRE_STEELGRADEINDEX, ";
                            sql_zp += " STEELGRADEINDEX, ";
                            sql_zp += " CUT_STEELGRADEINDEX,";
                            sql_zp += " FINAL_STEELGRADEINDEX,";
                            sql_zp += " LENGTH, ";
                            sql_zp += " WIDTH, ";
                            sql_zp += " THICKNESS,";
                            sql_zp += " BLOOM_COUNT, ";
                            sql_zp += " CAL_WEIGHT, ";
                            sql_zp += " RIGHT_COUNT, ";
                            sql_zp += " RIGHT_WEIGHT, ";
                            sql_zp += " WASTER_COUNT, ";
                            sql_zp += " WASTER_WEIGHT, ";
                            sql_zp += " WASTER_COUNT1, ";
                            sql_zp += " WASTER_WEIGHT1, ";
                            sql_zp += " WASTER_REASON1, ";
                            sql_zp += " WASTER_COUNT2, ";
                            sql_zp += " WASTER_WEIGHT2, ";
                            sql_zp += " WASTER_REASON2, ";
                            sql_zp += " WASTER_COUNT3, ";
                            sql_zp += " WASTER_WEIGHT3, ";
                            sql_zp += " WASTER_REASON3, ";
                            sql_zp += " WRONG_COUNT, ";
                            sql_zp += " WRONG_WEIGHT, ";
                            sql_zp += " WRONG_COUNT1, ";
                            sql_zp += " WRONG_WEIGHT1, ";
                            sql_zp += " WRONG_REASON1, ";
                            sql_zp += " WRONG_COUNT2, ";
                            sql_zp += " WRONG_WEIGHT2, ";
                            sql_zp += " WRONG_REASON2, ";
                            sql_zp += " WRONG_COUNT3, ";
                            sql_zp += " WRONG_WEIGHT3, ";
                            sql_zp += " WRONG_REASON3, ";
                            sql_zp += " SUFACEDEFACTDES, ";
                            sql_zp += " FINISHEDTIME, ";
                            sql_zp += " FINALJUDGE_TIME,";
                            sql_zp += " PROCESS_TYPE, ";
                            sql_zp += " EXCEPTIONAL_CODE, ";
                            sql_zp += " DECIDE_CODE, ";
                            sql_zp += " TEAM, ";
                            sql_zp += " SHIFT, ";
                            sql_zp += " OPERATOR, ";
                            sql_zp += " TEST_ROLL_COUNT, ";
                            sql_zp += " TEST_ROLL_WEIGHT, ";
                            sql_zp += " NC_CONFIRM_FLAG, ";
                            sql_zp += " STORE_CHANGEJUDGE_FLAG";
                            sql_zp += " )";
                            sql_zp += " values";
                            sql_zp += " ('" + V_GUID + "', ";
                            sql_zp += " '" + modTscSlabMes.NAME + "', ";
                            sql_zp += " '" + modTscSlabMes.HEATID + "', ";
                            sql_zp += " '" + modTscSlabMes.CASTERID + "', ";
                            sql_zp += " '" + modTscSlabMes.PRE_STEELGRADEINDEX + "', ";
                            sql_zp += " '" + modTscSlabMes.STEELGRADEINDEX + "', ";
                            sql_zp += " '" + modTscSlabMes.CUT_STEELGRADEINDEX + "',";
                            sql_zp += " '" + strLGJH + "',";
                            sql_zp += " '" + modTscSlabMes.LENGTH + "', ";
                            sql_zp += " '" + modTscSlabMes.WIDTH + "', ";
                            sql_zp += " '" + modTscSlabMes.THICKNESS + "',";
                            sql_zp += " '" + modTscSlabMes.BLOOM_COUNT + "', ";
                            sql_zp += " '" + modTscSlabMes.CAL_WEIGHT + "', ";
                            sql_zp += " '" + modTscSlabMes.RIGHT_COUNT + "', ";
                            sql_zp += " '" + modTscSlabMes.RIGHT_WEIGHT + "', ";
                            sql_zp += " '" + modTscSlabMes.WASTER_COUNT + "', ";
                            sql_zp += " '" + modTscSlabMes.WASTER_WEIGHT + "', ";
                            sql_zp += " '" + modTscSlabMes.WASTER_COUNT1 + "', ";
                            sql_zp += " '" + modTscSlabMes.WASTER_WEIGHT1 + "', ";
                            sql_zp += " '" + modTscSlabMes.WASTER_REASON1 + "', ";
                            sql_zp += " '" + modTscSlabMes.WASTER_COUNT2 + "', ";
                            sql_zp += " '" + modTscSlabMes.WASTER_WEIGHT2 + "', ";
                            sql_zp += " '" + modTscSlabMes.WASTER_REASON2 + "', ";
                            sql_zp += " '" + modTscSlabMes.WASTER_COUNT3 + "', ";
                            sql_zp += " '" + modTscSlabMes.WASTER_WEIGHT3 + "', ";
                            sql_zp += " '" + modTscSlabMes.WASTER_REASON3 + "', ";
                            sql_zp += " '" + modTscSlabMes.WRONG_COUNT + "', ";
                            sql_zp += " '" + modTscSlabMes.WRONG_WEIGHT + "', ";
                            sql_zp += " '" + modTscSlabMes.WRONG_COUNT1 + "', ";
                            sql_zp += " '" + modTscSlabMes.WRONG_WEIGHT1 + "', ";
                            sql_zp += " '" + modTscSlabMes.WRONG_REASON1 + "', ";
                            sql_zp += " '" + modTscSlabMes.WRONG_COUNT2 + "', ";
                            sql_zp += " '" + modTscSlabMes.WRONG_WEIGHT2 + "', ";
                            sql_zp += " '" + modTscSlabMes.WRONG_REASON2 + "', ";
                            sql_zp += " '" + modTscSlabMes.WRONG_COUNT3 + "', ";
                            sql_zp += " '" + modTscSlabMes.WRONG_WEIGHT3 + "', ";
                            sql_zp += " '" + modTscSlabMes.WRONG_REASON3 + "', ";
                            sql_zp += " '" + modTscSlabMes.SUFACEDEFACTDES + "', ";
                            sql_zp += " to_date('" + modTscSlabMes.FINISHEDTIME + "', 'yyyy-mm-dd hh24:mi:ss'), ";
                            sql_zp += " to_date('" + time + "','yyyy-mm-dd hh24:mi:ss'),";
                            sql_zp += " '" + modTscSlabMes.PROCESS_TYPE + "', ";
                            sql_zp += " '', ";
                            sql_zp += " '', ";
                            sql_zp += " '1', ";//班组
                            sql_zp += " '1', ";//班次
                            sql_zp += " '"+ strUserAccount + "', ";
                            sql_zp += " '" + modTscSlabMes.TEST_ROLL_COUNT + "', ";
                            sql_zp += " '" + modTscSlabMes.TEST_ROLL_WEIGHT + "', ";
                            sql_zp += " '0', ";
                            sql_zp += " '0' ";
                            sql_zp += " )";

                            if (!dal.Add_Mes_Trans(sql_zp))
                            {
                                TransactionHelper.RollBack();
                                //Transaction_MES.RollBack();
                                return "更新MES综判信息失败";
                            }
                        }

                        #endregion


                        #region   更新CBLOOM_DATA

                        if (!dal.Update_LGJH_Trans(strLGJH, modTqcCompreSlab.C_STOVE))
                        {
                            TransactionHelper.RollBack();
                            //Transaction_MES.RollBack();
                            return "更新MES收料表失败";
                        }

                        #endregion


                        #region 更新CQA_LAB_ELEMENT(综判成分)

                        DataTable dtCF = dalTqcQuaResult.Get_PD_List(modTqcCompreSlab.C_STOVE).Tables[0];

                        if (dtCF.Rows.Count > 0)
                        {
                            int countCF = dal.Get_MES_CF_Count(dtCF.Rows[0]["C_COMMISSIONID"].ToString(), dtCF.Rows[0]["C_SAMPID"].ToString(), modTqcCompreSlab.C_STOVE);

                            if (countCF > 0)
                            {
                                if (!dal.Update_CF_Trans(dtCF.Rows[0]["C_COMMISSIONID"].ToString(), dtCF.Rows[0]["C_SAMPID"].ToString(), modTqcCompreSlab.C_STOVE))
                                {
                                    TransactionHelper.RollBack();
                                    //Transaction_MES.RollBack();
                                    return "更新MES判定成分信息失败";
                                }
                            }
                            else
                            {
                                TransactionHelper.RollBack();
                                return "获取MES判定成分失败";
                            }
                        }
                        else
                        {
                            TransactionHelper.RollBack();
                            return "获取CAP判定成分失败";
                        }

                        #endregion

                        modTscSlabMes.FINAL_STEELGRADEINDEX = strLGJH;

                        if (!dalTscSLabMes.Update_Trans(modTscSlabMes))
                        {
                            TransactionHelper.RollBack();
                            return "确认失败";
                        }
                    }
                    else
                    {
                        TransactionHelper.RollBack();
                        return "确认失败";
                    }
                }
                else
                {
                    TransactionHelper.RollBack();
                    return "确认失败";
                }

                TransactionHelper.Commit();
            }
            catch (Exception ex)
            {
                TransactionHelper.RollBack();
                return ex.Message;
            }

            return result;
        }

        /// <summary>
        /// 钢坯综合判定
        /// </summary>
        /// <returns></returns>
        public int JUDGE_SLAB()
        {
            return dal.JUDGE_SLAB();
        }

        /// <summary>
        /// 同步钢坯综合判定数据
        /// </summary>
        /// <returns></returns>
        public int TB_SLAB()
        {
            return dal.TB_SLAB();
        }

        /// <summary>
        /// 钢坯综合判定(指定炉号)
        /// </summary>
        /// <param name="P_STOVE">炉号</param>
        /// <returns></returns>
        public string JUDGE_SLAB_STOVE(string P_STOVE)
        {
            return dal.JUDGE_SLAB_STOVE(P_STOVE);
        }

        /// <summary>
        /// 同步钢坯信息到综合判定表(指定炉号)
        /// </summary>
        /// <param name="P_STOVE">炉号</param>
        /// <returns></returns>
        public string TB_SLAB_STOVE(string P_STOVE)
        {
            return dal.TB_SLAB_STOVE(P_STOVE);
        }


        /// <summary>
        /// 钢坯添加备注
        /// </summary>
        /// <param name="modTqcCompreSlab">需要添加备注的实体信息</param>
        /// <param name="strRemark">备注</param>
        /// <returns></returns>
        public string Slab_Remark(Mod_TQC_COMPRE_SLAB modTqcCompreSlab, string strRemark)
        {
            string result = "1";
            try
            {
                Dal_TSC_SLAB_MAIN dalTscSlabMain = new Dal_TSC_SLAB_MAIN();

                TransactionHelper.BeginTransaction();

                string strUserID = RV.UI.UserInfo.userID;
                DateTime time = RV.UI.ServerTime.timeNow();
                string strUserAccount = RV.UI.UserInfo.userAccount;

                modTqcCompreSlab.C_REMARK = strRemark;

                if (dal.Update_Trans(modTqcCompreSlab))
                {
                    if(!dalTscSlabMain.Update_Trans(strRemark,modTqcCompreSlab.C_STOVE))
                    {
                        TransactionHelper.RollBack();
                        return "备注添加失败";
                    }
                }
                else
                {
                    TransactionHelper.RollBack();
                    return "备注添加失败";
                }

                TransactionHelper.Commit();
            }
            catch (Exception ex)
            {
                TransactionHelper.RollBack();
                return ex.Message;
            }

            return result;
        }

        #endregion  ExtensionMethod
    }
}

