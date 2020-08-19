using System;
using System.Data;
using System.Collections.Generic;
using DAL;
using MODEL;
using RV.UI;

namespace BLL
{
    /// <summary>
    /// 轧制主表
    /// </summary>
    public partial class Bll_TRC_ROLL_MAIN
    {
        private readonly Dal_TRC_ROLL_MAIN dal = new Dal_TRC_ROLL_MAIN();
        private readonly Dal_TSC_SLAB_MAIN slabMainDal = new Dal_TSC_SLAB_MAIN();
        private readonly Dal_TRC_ROLL_MAIN_ITEM itemDal = new Dal_TRC_ROLL_MAIN_ITEM();
        private readonly Dal_TRP_PLAN_ROLL planDal = new Dal_TRP_PLAN_ROLL();
        private readonly Dal_TRC_ROLL_WGD wgdDal = new Dal_TRC_ROLL_WGD();
        private readonly Dal_TRC_ROLL_WGD_ITEM wgdItemDal = new Dal_TRC_ROLL_WGD_ITEM();
        private readonly Dal_TRC_ROLL_WGD_LOG wgdDalLog = new Dal_TRC_ROLL_WGD_LOG();
        private readonly Dal_TRC_ROLL_WGD_ITEM_LOG wgdItemDalLog = new Dal_TRC_ROLL_WGD_ITEM_LOG();
        private readonly Dal_TRC_ROLL_LOG dalLog = new Dal_TRC_ROLL_LOG();
        private readonly Dal_TRC_WARM_FURNACE warmFurnaceDal = new Dal_TRC_WARM_FURNACE();
        private readonly Dal_TRC_WARM_FURNACE_LOG warmFurnaceLogDal = new Dal_TRC_WARM_FURNACE_LOG();
        private readonly Dal_Interface_FR Ifr = new Dal_Interface_FR();
        private Dal_TRP_PLAN_ROLL_ITEM planRollItem = new Dal_TRP_PLAN_ROLL_ITEM();
        private Dal_TRP_PLAN_ROLL_ITEM_INFO planRollItemInfo = new Dal_TRP_PLAN_ROLL_ITEM_INFO();
        Bll_TRC_ROLL_WGD bll_TRC_ROLL_WGD = new Bll_TRC_ROLL_WGD();
        private readonly Dal_TRC_ROLL_TIME dal_TRC_ROLL_TIME = new Dal_TRC_ROLL_TIME();
        private readonly Dal_TRC_ROLL_MAIN_CLOSE_LOG dal_TRC_ROLL_MAIN_CLOSE_LOG = new Dal_TRC_ROLL_MAIN_CLOSE_LOG();
        private Dal_TPB_CHANGESPEC_TIME dalChangeTime = new Dal_TPB_CHANGESPEC_TIME();//换规格时间
        private Bll_TPP_ZG_PLAN bllTppZgPlan = new Bll_TPP_ZG_PLAN();

        public Bll_TRC_ROLL_MAIN()
        { }

        #region  BasicMethod

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Mod_TRC_ROLL_MAIN model)
        {
            return dal.Update(model);
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(string ID)
        {
            //该表无主键信息，请自定义主键/条件字段
            return dal.Delete(ID);
        }
        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Mod_TRC_ROLL_MAIN model)
        {
            return dal.Add(model);
        }
        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Mod_TRC_ROLL_MAIN GetModel(string ID)
        {
            //该表无主键信息，请自定义主键/条件字段
            return dal.GetModel(ID);
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetListMain(string strWhere, bool desc)
        {
            return dal.GetListMain(strWhere, desc);
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere, bool desc, int status)
        {
            return dal.GetList(strWhere, desc, status);
        }


        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Mod_TRC_ROLL_MAIN> DataTableToList(DataTable dt)
        {
            List<Mod_TRC_ROLL_MAIN> modelList = new List<Mod_TRC_ROLL_MAIN>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Mod_TRC_ROLL_MAIN model;
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
        /// 获取最大批号
        /// </summary>
        public string GetMaxPH(string c_sta_id)
        {
            return dal.GetMaxPH(c_sta_id);
        }

        #endregion  BasicMethod

        #region  ExtensionMethod

        /// <summary>
        /// 组批处理
        /// </summary>
        /// <param name="model">组批主表数据</param>
        /// <param name="grd">可轧钢坯钢种</param>
        /// <param name="std">可轧钢坯执行标准</param>
        /// <param name="slbwhCode">待轧钢坯仓库库位编码</param>
        /// <returns></returns>
        public string AssemblyHandler(Mod_TRC_ROLL_MAIN model, string grd, string std, string slbwhCode, string kpBatchNo, string planMatCode, string staID, string maxWgt)
        {
            try
            {
                TransactionHelper.BeginTransaction();
                if (!dal.Add_Tran(model))
                {
                    TransactionHelper.RollBack();
                    return "0";
                }

                //钢坯ID
                string grdID = "";
                ///钢坯明细
                DataTable assembly = slabMainDal.GetRepalceStl(grd, std, model.C_STOVE, (int)model.N_QUA_TOTAL, kpBatchNo, slbwhCode).Tables[0];
                if (assembly == null || assembly.Rows.Count == 0)
                {
                    TransactionHelper.RollBack();
                    return "0";
                }
                //添加组批子表
                for (int i = 0; i < assembly.Rows.Count; i++)
                {
                    Mod_TRC_ROLL_MAIN_ITEM item = new Mod_TRC_ROLL_MAIN_ITEM();
                    item.C_ROLL_MAIN_ID = model.C_ID;
                    item.C_SLAB_MAIN_ID = assembly.Rows[i]["C_ID"].ToString();
                    grdID += item.C_SLAB_MAIN_ID + ",";
                    if (!itemDal.Add(item))
                    {
                        TransactionHelper.RollBack();
                        return "0";
                    }
                }

                //钢坯状态有DZ的 回滚全部操作
                if (assembly.Rows.Count != slabMainDal.UpdateGrdMoveType(grdID, slbwhCode))
                {
                    TransactionHelper.RollBack();
                    return "0";
                }



                //修改计划组批量
                if (planDal.UpdateGroupWgt(model.C_PLAN_ID, model.N_WGT_TOTAL) == 0)
                {
                    TransactionHelper.RollBack();
                    return "0";
                }



                if (!planRollItem.ChckIfAsse(model.C_PLAN_ID, model.N_WGT_TOTAL.Value))
                {
                    TransactionHelper.RollBack();
                    return "9";
                }

                if (!planRollItem.ChckIfAsseSingle(model.C_PLAN_ID, model.N_WGT_TOTAL.Value))
                {
                    TransactionHelper.RollBack();
                    return "8";
                }



                #region 新增日志
                Mod_TRC_ROLL_LOG log = new Mod_TRC_ROLL_LOG();
                log.C_TRC_PLAN_ROLL_ID = model.C_PLAN_ID;
                log.C_TRC_ROLL_MAIN_ID = model.C_ID;
                log.N_QUA_TOTAL = (decimal)model.N_QUA_TOTAL;
                log.N_WGT_TOTAL = (decimal)model.N_WGT_TOTAL;
                log.N_ROLL_STATE = 1;
                log.N_STATUS = 1;
                log.D_MOD_DT = DateTime.Now;
                log.C_BATCH_NO = model.C_BATCH_NO;
                if (!dalLog.Add(log))
                {
                    TransactionHelper.RollBack();
                    return "0";
                }
                #endregion

                TransactionHelper.Commit();


                //合并订单
                if (model.N_IS_MERGE == 1)
                {
                    Dal_TRP_PLAN_ROLL_ITEM_INFO itemInfo = new Dal_TRP_PLAN_ROLL_ITEM_INFO();
                    decimal? singleWgt = (model.N_WGT_TOTAL / model.N_QUA_TOTAL);
                    for (int i = 0; i < model.N_QUA_TOTAL; i++)
                    {
                        DataTable rollItemInfoDt = itemInfo.GetItemInfoAsc_Assm(model.C_PLAN_ID);
                        if (rollItemInfoDt == null || rollItemInfoDt.Rows.Count <= 0)
                        {
                            rollItemInfoDt = itemInfo.GetItemInfo_Assm_Two(model.C_PLAN_ID);
                        }

                        itemInfo.UpdateGroupWgt(rollItemInfoDt.Rows[0]["C_ID"].ToString(), singleWgt);
                        itemInfo.UpdateAssmStatus(rollItemInfoDt.Rows[0]["C_ID"].ToString());
                    }
                }


                if (maxWgt != "不限")
                    planRollItem.AccomplishPlan(model.C_PLAN_ID, 3, model.N_WGT_TOTAL.Value);


            }
            catch (Exception ex)
            {
                TransactionHelper.RollBack();
                return "0";
            }
            return "1";
        }

        /// <summary>
        /// 撤回组批
        /// </summary>
        /// <param name="asseID"></param>
        /// <param name="assemNum"></param>
        /// <param name="planID"></param>
        /// <returns></returns>
        public string BackOutHandler(string asseID, decimal wgt, string planID)
        {

            try
            {
                TransactionHelper.BeginTransaction();

                var model = dal.GetModel(asseID);
                var plan = planRollItem.GetModel(model.C_PLAN_ID);

                if (!slabMainDal.BackOutGrdMoveType(asseID))
                {
                    TransactionHelper.RollBack();
                    return "0";
                }

                if (!itemDal.Delete(asseID))
                {
                    TransactionHelper.RollBack();
                    return "0";
                }

                if (planDal.BackOutGroupWgt(planID, wgt) == 0)
                {
                    TransactionHelper.RollBack();
                    return "0";
                }


                if (!dal.Delete(asseID))
                {
                    TransactionHelper.RollBack();
                    return "0";
                }

                #region 新增日志
                Mod_TRC_ROLL_LOG log = new Mod_TRC_ROLL_LOG();
                log.C_TRC_PLAN_ROLL_ID = model.C_PLAN_ID;
                log.C_TRC_ROLL_MAIN_ID = model.C_ID;
                log.N_QUA_TOTAL = (decimal)model.N_QUA_TOTAL;
                log.N_WGT_TOTAL = (decimal)model.N_WGT_TOTAL;
                log.N_ROLL_STATE = 2;
                log.N_STATUS = 1;
                log.D_MOD_DT = DateTime.Now;
                log.C_BATCH_NO = model.C_BATCH_NO;
                if (!dalLog.Add(log))
                {
                    TransactionHelper.RollBack();
                    return "0";
                }
                #endregion

                TransactionHelper.Commit();

                if (plan.N_IS_MERGE == 1)
                {
                    Dal_TRP_PLAN_ROLL_ITEM_INFO itemInfo = new Dal_TRP_PLAN_ROLL_ITEM_INFO();
                    decimal? singleWgt = (model.N_WGT_TOTAL / model.N_QUA_TOTAL);
                    for (int i = 0; i < model.N_QUA_TOTAL; i++)
                    {
                        DataTable rollItemInfoDt = itemInfo.GetItemInfo_Assm(plan.C_ID);
                        if (rollItemInfoDt != null && rollItemInfoDt.Rows.Count > 0)
                        {
                            itemInfo.UpdateGroupWgtTwo(rollItemInfoDt.Rows[0]["C_ID"].ToString(), singleWgt);
                            itemInfo.UpdateAssmStatusTwo(rollItemInfoDt.Rows[0]["C_ID"].ToString());
                        }
                    }
                }

                planRollItem.UnAccomplishPlan(model.C_PLAN_ID, 2);

                planRollItem.ResetPlan(model.C_PLAN_ID, 1);
            }
            catch (Exception ex)
            {
                TransactionHelper.RollBack();
                return "0";
            }



            return "1";
        }

        public DataSet GetListByPidAndBid(string C_PLAN_ID, string C_BATCH_NO)
        {
            return dal.GetListByPidAndBid(C_PLAN_ID, C_BATCH_NO);
        }
        /// <summary>
        ///根据 批号获取数据列表
        /// </summary>
        public DataSet GetList_Batch(string C_BATCH_NO)
        {
            return dal.GetList_Batch(C_BATCH_NO);
        }
        /// <summary>
        /// 获取线材实绩信息
        /// </summary>
        /// <param name="begin">组批时间 开始</param>
        /// <param name="end">组批时间 结束</param>
        /// <param name="pland">车间</param>
        /// <param name="batch">批号</param>
        /// <returns></returns>
        public DataSet GetProductList(DateTime begin, DateTime end, string pland, string batch)
        {
            return dal.GetProductList(begin, end, pland, batch);
        }

        /// <summary>
        /// 生成批号
        /// </summary>
        /// <returns></returns>
        public string CreateBranchNo(string staID)
        {
            return dal.CreateBranchNo(staID);
        }

        /// <summary>
        /// 生成批号(插销)
        /// </summary>
        /// <returns></returns>
        public string CreateBranchNo(int type)
        {
            return dal.CreateBranchNo(type);
        }

        /// <summary>
        /// 入炉
        /// </summary>
        /// <param name="id">组批主键</param>
        /// <param name="putNum">组批支数</param>
        /// <param name="batchNo">批号</param>
        /// <param name="staID">工位号</param>
        /// <param name="shift">班次</param>
        /// <param name="group">班组</param>
        /// <param name="remark">备注</param>
        /// <param name="remark">计划主键</param>
        /// <param name="putTime">入炉时间</param>
        /// <returns></returns>
        public string PutFurnaceHandler(string id, int putNum, string batchNo, string staID, string shift, string group, string remark
           , string planID, DateTime putTime)
        {

            try
            {
                TransactionHelper.BeginTransaction();
                var plan = planRollItem.GetModel_Item(planID);
                DataTable slabDt = new DataTable();
                int reNum = dal.UpdatePutFurnaceType(id, putNum, out slabDt);
                if (reNum != putNum)
                {
                    TransactionHelper.RollBack();
                    return "0";
                }

                if (slabDt != null && slabDt.Rows.Count > 0)
                {
                    var slab = slabMainDal.GetModel(slabDt.Rows[0]["C_SLAB_MAIN_ID"].ToString());

                    if (dal.UpdatePut(id, putNum, remark, slab.N_WGT) == 0)
                    {
                        TransactionHelper.RollBack();
                        return "0";
                    }

                    for (int i = 0; i < slabDt.Rows.Count; i++)
                    {
                        Mod_TRC_WARM_FURNACE warmModel = new Mod_TRC_WARM_FURNACE();
                        warmModel.C_TRC_ROLL_MAIN_ID = id;
                        warmModel.N_QUA_JOIN = putNum;
                        warmModel.N_WGT_JOIN = slab.N_WGT;
                        warmModel.C_BATCH_NO = batchNo;
                        warmModel.C_STA_ID = staID;
                        warmModel.N_ROLL_STATE = 1;
                        warmModel.C_EMP_ID = UserInfo.userID;
                        warmModel.C_SHIFT = shift;
                        warmModel.C_GROUP = group;
                        warmModel.C_SLAB_MAIN_ID = slabDt.Rows[i]["C_SLAB_MAIN_ID"].ToString();
                        warmModel.C_STOVE = slab.C_STOVE;
                        warmModel.N_LEN = slab.N_LEN;
                        warmModel.C_MAT_CODE = plan.C_MAT_CODE;
                        warmModel.C_MAT_NAME = plan.C_MAT_NAME;
                        warmModel.D_MOD_DT = putTime;

                        if (!warmFurnaceDal.Add(warmModel))
                        {
                            TransactionHelper.RollBack();
                            return "0";
                        }

                        Mod_TRC_WARM_FURNACE_LOG logModel = new Mod_TRC_WARM_FURNACE_LOG();
                        logModel.C_TRC_ROLL_MAIN_ID = id;
                        logModel.N_QUA_JOIN = putNum;
                        logModel.N_WGT_JOIN = slab.N_WGT;
                        logModel.C_BATCH_NO = batchNo;
                        logModel.C_STA_ID = staID;
                        logModel.N_ROLL_STATE = 1;
                        logModel.C_EMP_ID = UserInfo.userID;
                        logModel.C_SHIFT = shift;
                        logModel.C_GROUP = group;
                        logModel.N_TYPE = 1;
                        logModel.C_REMARK = remark;
                        logModel.C_SLAB_MAIN_ID = slabDt.Rows[i]["C_SLAB_MAIN_ID"].ToString();
                        logModel.C_STOVE = slab.C_STOVE;
                        logModel.N_LEN = slab.N_LEN;
                        logModel.C_MAT_CODE = plan.C_MAT_CODE;
                        logModel.C_MAT_NAME = plan.C_MAT_NAME;
                        if (!warmFurnaceLogDal.Add(logModel))
                        {
                            TransactionHelper.RollBack();
                            return "0";
                        }
                    }

                    dal.UpdateFurnaceTime(id, putTime);

                }

                TransactionHelper.Commit();
            }
            catch (Exception ex)
            {
                TransactionHelper.RollBack();
                return "0";
            }

            return "1";
        }

        /// <summary>
        /// 入炉撤回
        /// </summary>
        /// <param name="staID">工位ID</param>
        /// <param name="remark">备注</param>
        /// <param name="num">支数</param>
        /// <returns></returns>
        public string PutBackHandler(string staID, string remark, int num)
        {
            DataTable putDt = dal.GetFurnace(staID, num, 1).Tables[0];

            if (putDt == null || putDt.Rows.Count == 0)
                return "0";

            TransactionHelper.BeginTransaction();
            try
            {
                DataRow dr = putDt.Rows[0];
                DataTable pwDt = dal.GetSlabInfo(dr["C_SLAB_MAIN_ID"].ToString());
                decimal pw = decimal.Parse(pwDt.Rows[0]["N_WGT"].ToString());

                if (num != dal.UpdateSlabMoveType(putDt, "DZ", "R", null))
                {
                    TransactionHelper.RollBack();
                    return "0";
                }

                if (dal.BackPut(dr["C_TRC_ROLL_MAIN_ID"].ToString(), num, pw, remark) == 0)
                {
                    TransactionHelper.RollBack();
                    return "0";
                }

                for (int i = 0; i < putDt.Rows.Count; i++)
                {
                    if (!warmFurnaceDal.Delete(putDt.Rows[i]["C_ID"].ToString()))
                    {
                        TransactionHelper.RollBack();
                        return "0";
                    }

                    Mod_TRC_WARM_FURNACE_LOG logModel = new Mod_TRC_WARM_FURNACE_LOG();
                    logModel.C_TRC_ROLL_MAIN_ID = dr["C_TRC_ROLL_MAIN_ID"].ToString();
                    logModel.N_QUA_JOIN = num;
                    logModel.N_WGT_JOIN = num * pw;
                    logModel.C_BATCH_NO = dr["C_BATCH_NO"] == null ? "" : dr["C_BATCH_NO"].ToString();
                    logModel.C_STA_ID = staID;
                    logModel.N_ROLL_STATE = 1;
                    logModel.C_EMP_ID = UserInfo.userID;
                    logModel.C_SHIFT = dr["C_SHIFT"] == null ? "" : dr["C_SHIFT"].ToString();
                    logModel.C_GROUP = dr["C_GROUP"] == null ? "" : dr["C_GROUP"].ToString();
                    logModel.N_TYPE = 2;
                    logModel.C_REMARK = remark;
                    logModel.C_SLAB_MAIN_ID = putDt.Rows[i]["C_SLAB_MAIN_ID"].ToString();
                    logModel.C_STOVE = pwDt.Rows[0]["C_STOVE"].ToString();
                    logModel.N_LEN = Convert.ToDecimal(pwDt.Rows[0]["N_LEN"]);
                    logModel.C_MAT_CODE = pwDt.Rows[0]["C_MAT_CODE"].ToString();
                    logModel.C_MAT_NAME = pwDt.Rows[0]["C_MAT_NAME"].ToString();

                    if (!warmFurnaceLogDal.Add(logModel))
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

            return "1";
        }

        /// <summary>
        /// 入炉剔除
        /// </summary>
        /// <param name="staID">工位ID</param>
        /// <param name="remark">备注</param>
        /// <param name="num">支数</param>
        /// <returns></returns>
        public string PutElimHandler(string staID, string remark, int num, string slabwhCode, string shift, string group, string userID
           , string id)
        {
            DataTable putDt = dal.GetRollMainSlabIds(id, num);

            if (putDt == null || putDt.Rows.Count == 0)
                return "0";


            TransactionHelper.BeginTransaction();
            try
            {
                DataRow dr = putDt.Rows[0];
                DataTable pwDt = dal.GetSlabInfo(dr["C_SLAB_MAIN_ID"].ToString());
                decimal pw = decimal.Parse(pwDt.Rows[0]["N_WGT"].ToString());
                var rollMain = dal.GetModel(id);

                if (num != dal.UpdateSlabMoveType(putDt, "E", "DZ", "Y", null, shift, group, userID))
                {
                    TransactionHelper.RollBack();
                    return "0";
                }

                if (dal.ElimPut(id, num, num * pw, remark) == 0)
                {
                    TransactionHelper.RollBack();
                    return "0";
                }


                if (planDal.BackOutGroupWgt(rollMain.C_PLAN_ID, num * pw) == 0)
                {
                    TransactionHelper.RollBack();
                    return "0";
                }

                for (int i = 0; i < putDt.Rows.Count; i++)
                {
                    var slab = dal.GetSlabInfo(putDt.Rows[i]["C_SLAB_MAIN_ID"].ToString());
                    Mod_TRC_WARM_FURNACE_LOG logModel = new Mod_TRC_WARM_FURNACE_LOG();
                    logModel.C_TRC_ROLL_MAIN_ID = id;
                    logModel.N_QUA_JOIN = num;
                    logModel.N_WGT_JOIN = num * pw;
                    logModel.C_BATCH_NO = slab.Rows[0]["C_BATCH_NO"] == null ? "" : slab.Rows[0]["C_BATCH_NO"].ToString();
                    logModel.C_STA_ID = staID;
                    logModel.N_ROLL_STATE = 3;
                    logModel.C_EMP_ID = UserInfo.userID;
                    logModel.C_SHIFT = shift;
                    logModel.C_GROUP = group;
                    logModel.C_REMARK = remark;
                    logModel.C_SLAB_MAIN_ID = putDt.Rows[i]["C_SLAB_MAIN_ID"].ToString();
                    logModel.C_STOVE = pwDt.Rows[0]["C_STOVE"].ToString();
                    logModel.N_LEN = Convert.ToDecimal(pwDt.Rows[0]["N_LEN"]);
                    logModel.C_MAT_CODE = pwDt.Rows[0]["C_MAT_CODE"].ToString();
                    logModel.C_MAT_NAME = pwDt.Rows[0]["C_MAT_NAME"].ToString();
                    if (!warmFurnaceLogDal.Add(logModel))
                    {
                        TransactionHelper.RollBack();
                        return "0";
                    }

                    if (dal.DelRollMainItem(id, putDt.Rows[i]["C_SLAB_MAIN_ID"].ToString()) == 0)
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

            return "1";
        }


        /// <summary>
        /// 出炉
        /// </summary>
        /// <param name="id">组批主键</param>
        /// <param name="putNum">支数</param>
        /// <param name="batchNo">批号</param>
        /// <param name="staID">工位号</param>
        /// <param name="shift">班次</param>
        /// <param name="group">班组</param>
        /// <param name="remark">备注</param>
        /// <param name="outTime">出炉时间</param>
        /// <returns></returns>
        public string OutFurnaceHandler(string id, int putNum, string batchNo, string staID, string shift, string group, string remark, DateTime outTime)
        {
            try
            {
                TransactionHelper.BeginTransaction();
                DataTable slabDt = new DataTable();
                DataRow dr = null;
                 
                decimal pw = 0;

                int reNum = dal.UpdateOutFurnaceType(id, putNum, out slabDt);

                if (reNum != putNum)
                {
                    TransactionHelper.RollBack();
                    return "0";
                }

                //获取单支重量
                if (slabDt != null && slabDt.Rows.Count > 0)
                {
                    dr = slabDt.Rows[0];
                }
                DataTable pwDt = dal.GetSlabInfo(dr["C_SLAB_MAIN_ID"].ToString());
                pw = decimal.Parse(pwDt.Rows[0]["N_WGT"].ToString());
                if (dal.UpdateOut(id, putNum, remark, pw) == 0)
                {
                    TransactionHelper.RollBack();
                    return "0";
                }

                //支数为0也可以出炉
                if (putNum == 0)
                {
                    dal.UpdateWarmFurnaceStatus(slabDt, 2, shift, group, outTime, id);
                }
                else if (dal.UpdateWarmFurnaceStatus(slabDt, 2, shift, group, outTime, id) != putNum)
                {
                    TransactionHelper.RollBack();
                    return "0";
                }



                if (slabDt != null && slabDt.Rows.Count > 0)
                {
                    for (int i = 0; i < slabDt.Rows.Count; i++)
                    {
                        Mod_TRC_WARM_FURNACE_LOG logModel = new Mod_TRC_WARM_FURNACE_LOG();
                        logModel.C_TRC_ROLL_MAIN_ID = id;
                        logModel.N_QUA_EXIT = putNum;
                        logModel.N_WGT_EXIT = putNum * pw;
                        logModel.C_BATCH_NO = batchNo;
                        logModel.C_STA_ID = staID;
                        logModel.N_ROLL_STATE = 2;
                        logModel.C_EMP_ID = UserInfo.userID;
                        logModel.C_SHIFT = shift;
                        logModel.C_GROUP = group;
                        logModel.N_TYPE = 1;
                        logModel.C_REMARK = remark;
                        logModel.C_SLAB_MAIN_ID = slabDt.Rows[i]["C_SLAB_MAIN_ID"].ToString();
                        logModel.C_STOVE = pwDt.Rows[0]["C_STOVE"].ToString();
                        logModel.N_LEN = Convert.ToDecimal(pwDt.Rows[0]["N_LEN"]);
                        logModel.C_MAT_CODE = pwDt.Rows[0]["C_MAT_CODE"].ToString();
                        logModel.C_MAT_NAME = pwDt.Rows[0]["C_MAT_NAME"].ToString();
                        if (!warmFurnaceLogDal.Add(logModel))
                        {
                            TransactionHelper.RollBack();
                            return "0";
                        }

                    }
                }



                string whereSql = " AND TRM.C_ID = '" + id + "' ";
                DataTable dt = bll_TRC_ROLL_WGD.GetAssePutStoreData(whereSql, true, 1).Tables[0];
                string stove = dt.Rows[0]["C_STOVE"].ToString();
                int elimNum = dt.Rows[0]["N_QUA_ELIM"] == DBNull.Value ? 0 : Convert.ToInt32(dt.Rows[0]["N_QUA_ELIM"]);
                int num = Convert.ToInt32(dt.Rows[0]["N_QUA_TOTAL_VIRTUAL"]) - elimNum;
                decimal wgt = pw;
                string grd = dt.Rows[0]["C_STL_GRD"].ToString();
                string spec = dt.Rows[0]["C_SPEC"].ToString();
                string std = dt.Rows[0]["C_STD_CODE"].ToString();
                if (!wgdDal.ExistsWgd(dt.Rows[0]["C_ID"].ToString()))
                {
                    if (WgdHandler(dt.Rows[0]["C_STOVE"].ToString(), dt.Rows[0]["C_BATCH_NO"].ToString(), dt.Rows[0]["C_PLAN_ID"].ToString(), num, wgt, grd, spec, std, dt.Rows[0]["C_ID"].ToString(), staID, outTime, DateTime.Now, shift, group, "", "") == "0")
                    {
                        return "0";
                    }
                }
                else
                {
                    if (!wgdDal.UpdateWgdQua(dt.Rows[0]["C_ID"].ToString(), num))
                    {
                        TransactionHelper.RollBack();
                        return "0";
                    }

                    if (!wgdDal.UpdateRollMainRollStatus(id))
                    {
                        TransactionHelper.RollBack();
                        return "0";
                    }
                }


                #region 更新换钢种规格时间
                //如果已经有出炉记录则不计算换规格钢种时间
                if (dal.GetOutFurnaceCount(batchNo) == 0)
                {
                    //获取比当前工位批号小一位的组坯记录
                    string smallBatchNo = (Convert.ToInt32(batchNo) - 1).ToString();
                    DataTable lastRoll = dal.GetLastRoll(staID, smallBatchNo);
                    //记录换规格、钢种时间
                    if (lastRoll != null && lastRoll.Rows.Count > 0)
                    {
                        //批号为最大的组坯记录
                        var lastRollDr = lastRoll.Rows[0];
                        //根据TRC_ROLL_TIME的数据确认新增或者是更新
                        DataTable rollTimeDt = dal.GetRollTime_Today(staID);

                        //修改
                        if (rollTimeDt != null && rollTimeDt.Rows.Count > 0)
                        {
                            var rollTimeModel = dal_TRC_ROLL_TIME.DataRowToModel(rollTimeDt.Rows[0]);
                            //换钢种
                            if (lastRollDr["C_STL_GRD"].ToString() != grd)
                            {
                                rollTimeModel.N_NUM_GRD += 1;
                            }
                            //换规格
                            if (lastRollDr["C_SPEC"].ToString() != spec)
                            {
                                //获取换规格时间如果为空则默认不加
                                var changeSpecTimeDt = dal.GetChangeSpecTime(staID, lastRollDr["C_SPEC"].ToString(), spec);
                                if (changeSpecTimeDt != null && changeSpecTimeDt.Rows.Count > 0)
                                {
                                    int timeSpec = Convert.ToInt32(rollTimeModel.C_TIME_SPEC);
                                    timeSpec += Convert.ToInt32(changeSpecTimeDt.Rows[0]["N_TIME"]);
                                    rollTimeModel.C_TIME_SPEC = timeSpec.ToString();
                                }
                                rollTimeModel.N_NUM_SPEC += 1;
                            }
                            if (!dal_TRC_ROLL_TIME.UpdateTran(rollTimeModel))
                            {
                                TransactionHelper.RollBack();
                                return "0";
                            }
                        }
                        //新增
                        else
                        {
                            Mod_TRC_ROLL_TIME rollTimeModel = new Mod_TRC_ROLL_TIME();
                            rollTimeModel.C_RQ = DateTime.Now.ToString("yyyy-MM-dd");
                            rollTimeModel.C_STA_ID = staID;
                            rollTimeModel.N_NUM_GRD = 0;
                            rollTimeModel.N_NUM_SPEC = 0;
                            rollTimeModel.C_TIME_SPEC = "0";
                            //换钢种
                            if (lastRollDr["C_STL_GRD"].ToString() != grd)
                            {
                                rollTimeModel.N_NUM_GRD += 1;
                            }
                            //换规格
                            if (lastRollDr["C_SPEC"].ToString() != spec)
                            {
                                //获取换规格时间如果为空则默认不加
                                var changeSpecTimeDt = dal.GetChangeSpecTime(staID, lastRollDr["C_SPEC"].ToString(), spec);
                                if (changeSpecTimeDt != null && changeSpecTimeDt.Rows.Count > 0)
                                {
                                    int timeSpec = Convert.ToInt32(rollTimeModel.C_TIME_SPEC);
                                    timeSpec += Convert.ToInt32(changeSpecTimeDt.Rows[0]["N_TIME"]);
                                    rollTimeModel.C_TIME_SPEC = timeSpec.ToString();
                                }
                                rollTimeModel.N_NUM_SPEC += 1;
                            }
                            if (!dal_TRC_ROLL_TIME.AddTran(rollTimeModel))
                            {
                                TransactionHelper.RollBack();
                                return "0";
                            }
                        }
                    }
                }
                #endregion

                dal.UpdateFurnaceTime(id, outTime);

                TransactionHelper.Commit();
            }
            catch (Exception ex)
            {
                TransactionHelper.RollBack();
                return "0";
            }

            return "1";
        }

        /// <summary>
        /// 出炉撤回
        /// </summary>
        /// <param name="staID">工位ID</param>
        /// <param name="remark">备注</param>
        /// <param name="num">支数</param>
        /// <param name="num">shift</param>
        /// <param name="num">group</param>
        /// <returns></returns>
        public string OutBackHandler(string staID, string remark, int num, string shift, string group)
        {
            DataTable outDt = dal.GetFurnace(staID, num, 2).Tables[0];

            if (outDt == null || outDt.Rows.Count == 0)
                return "0";

            TransactionHelper.BeginTransaction();
            try
            {
                DataRow dr = outDt.Rows[0];
                DataTable pwDt = dal.GetSlabInfo(dr["C_SLAB_MAIN_ID"].ToString());
                decimal pw = decimal.Parse(pwDt.Rows[0]["N_WGT"].ToString());

                if (num != dal.UpdateSlabMoveType(outDt, "R", "C", null))
                {
                    TransactionHelper.RollBack();
                    return "0";
                }

                if (dal.BackOut(dr["C_TRC_ROLL_MAIN_ID"].ToString(), num, pw, remark) == 0)
                {
                    TransactionHelper.RollBack();
                    return "0";
                }

                if (dal.UpdateWarmFurnaceStatus(outDt, 1, shift, group, DateTime.Now, dr["C_TRC_ROLL_MAIN_ID"].ToString()) != num)
                {
                    TransactionHelper.RollBack();
                    return "0";
                }

                for (int i = 0; i < outDt.Rows.Count; i++)
                {
                    Mod_TRC_WARM_FURNACE_LOG logModel = new Mod_TRC_WARM_FURNACE_LOG();
                    logModel.C_TRC_ROLL_MAIN_ID = dr["C_TRC_ROLL_MAIN_ID"].ToString();
                    logModel.N_QUA_EXIT = num;
                    logModel.N_WGT_EXIT = num * pw;
                    logModel.C_BATCH_NO = dr["C_BATCH_NO"] == null ? "" : dr["C_BATCH_NO"].ToString();
                    logModel.C_STA_ID = staID;
                    logModel.N_ROLL_STATE = 2;
                    logModel.C_EMP_ID = UserInfo.userID;
                    logModel.C_SHIFT = dr["C_SHIFT"] == null ? "" : dr["C_SHIFT"].ToString();
                    logModel.C_GROUP = dr["C_GROUP"] == null ? "" : dr["C_GROUP"].ToString();
                    logModel.N_TYPE = 2;
                    logModel.C_REMARK = remark;
                    logModel.C_SLAB_MAIN_ID = outDt.Rows[i]["C_SLAB_MAIN_ID"].ToString();
                    logModel.C_STOVE = pwDt.Rows[0]["C_STOVE"].ToString();
                    logModel.N_LEN = Convert.ToDecimal(pwDt.Rows[0]["N_LEN"]);
                    logModel.C_MAT_CODE = pwDt.Rows[0]["C_MAT_CODE"].ToString();
                    logModel.C_MAT_NAME = pwDt.Rows[0]["C_MAT_NAME"].ToString();
                    if (!warmFurnaceLogDal.Add(logModel))
                    {
                        TransactionHelper.RollBack();
                        return "0";
                    }
                }

                if (wgdDal.ExistsWgdSecond(dr["C_TRC_ROLL_MAIN_ID"].ToString()))
                {
                    TransactionHelper.RollBack();
                    return "0";
                }
                else
                {
                    wgdDal.DelWgd(dr["C_TRC_ROLL_MAIN_ID"].ToString());
                    wgdDal.DelWgdItem(dr["C_TRC_ROLL_MAIN_ID"].ToString());
                }

                #region 更新换钢种规格时间
                //如果已经有出炉记录则不计算换规格钢种时间
                if (dal.GetOutFurnaceCount(dr["C_BATCH_NO"].ToString()) == 0)
                {
                    //获取比当前工位批号小一位的组坯记录
                    string smallBatchNo = (Convert.ToInt32(dr["C_BATCH_NO"].ToString()) - 1).ToString();
                    DataTable lastRoll = dal.GetLastRoll(staID, smallBatchNo);
                    //记录换规格、钢种时间
                    if (lastRoll != null && lastRoll.Rows.Count > 0)
                    {
                        //批号为最大的组坯记录
                        var lastRollDr = lastRoll.Rows[0];
                        //根据TRC_ROLL_TIME的数据确认新增或者是更新
                        DataTable rollTimeDt = dal.GetRollTime_Today(staID);

                        //修改
                        if (rollTimeDt != null && rollTimeDt.Rows.Count > 0)
                        {
                            var rollTimeModel = dal_TRC_ROLL_TIME.DataRowToModel(rollTimeDt.Rows[0]);
                            //换钢种
                            if (lastRollDr["C_STL_GRD"].ToString() != dr["C_STL_GRD"].ToString())
                            {
                                rollTimeModel.N_NUM_GRD -= 1;
                            }
                            //换规格
                            if (lastRollDr["C_SPEC"].ToString() != dr["C_SPEC"].ToString())
                            {
                                //获取换规格时间如果为空则默认不加
                                var changeSpecTimeDt = dal.GetChangeSpecTime(staID, lastRollDr["C_STL_GRD"].ToString(), dr["C_SPEC"].ToString());
                                if (changeSpecTimeDt != null && changeSpecTimeDt.Rows.Count > 0)
                                {
                                    int timeSpec = Convert.ToInt32(rollTimeModel.C_TIME_SPEC);
                                    timeSpec -= Convert.ToInt32(changeSpecTimeDt.Rows[0]["N_TIME"]);
                                    rollTimeModel.C_TIME_SPEC = timeSpec.ToString();
                                }
                                rollTimeModel.N_NUM_SPEC -= 1;
                            }
                            if (!dal_TRC_ROLL_TIME.UpdateTran(rollTimeModel))
                            {
                                TransactionHelper.RollBack();
                                return "0";
                            }
                        }
                        //新增
                        else
                        {
                            Mod_TRC_ROLL_TIME rollTimeModel = new Mod_TRC_ROLL_TIME();
                            rollTimeModel.C_RQ = DateTime.Now.ToString("yyyy-MM-dd");
                            rollTimeModel.C_STA_ID = staID;
                            //换钢种
                            if (lastRollDr["C_STL_GRD"].ToString() != dr["C_STL_GRD"].ToString())
                            {
                                rollTimeModel.N_NUM_GRD -= 1;
                            }
                            //换规格
                            if (lastRollDr["C_SPEC"].ToString() != dr["C_SPEC"].ToString())
                            {
                                //获取换规格时间如果为空则默认不加
                                var changeSpecTimeDt = dal.GetChangeSpecTime(staID, lastRollDr["C_STL_GRD"].ToString(), dr["C_SPEC"].ToString());
                                if (changeSpecTimeDt != null && changeSpecTimeDt.Rows.Count > 0)
                                {
                                    int timeSpec = Convert.ToInt32(rollTimeModel.C_TIME_SPEC);
                                    timeSpec -= Convert.ToInt32(changeSpecTimeDt.Rows[0]["N_TIME"]);
                                    rollTimeModel.C_TIME_SPEC = timeSpec.ToString();
                                }
                                rollTimeModel.N_NUM_SPEC -= 1;
                            }
                            if (!dal_TRC_ROLL_TIME.AddTran(rollTimeModel))
                            {
                                TransactionHelper.RollBack();
                                return "0";
                            }
                        }
                    }
                }
                #endregion


                TransactionHelper.Commit();
            }
            catch (Exception ex)
            {
                TransactionHelper.RollBack();
                return "0";
            }

            return "1";
        }

        /// <summary>
        /// 出炉剔除
        /// </summary>
        /// <param name="staID">工位ID</param>
        /// <param name="remark">备注</param>
        /// <param name="num">支数</param>
        /// <returns></returns>
        public string OutElimHandler(string staID, string remark, int num, string slabwhCode, string shift, string group, string userID)
        {
            DataTable outDt = dal.GetFurnace(staID, num, 2).Tables[0];

            DataTable unQualifiedDt = dal.GetUnqualifiedSlabwhCode(slabwhCode);

            if (outDt == null || outDt.Rows.Count == 0)
                return "0";

            TransactionHelper.BeginTransaction();
            try
            {
                DataRow dr = outDt.Rows[0];
                DataTable pwDt = dal.GetSlabInfo(dr["C_SLAB_MAIN_ID"].ToString());
                decimal pw = decimal.Parse(pwDt.Rows[0]["N_WGT"].ToString());
                var rollMain = dal.GetModel(dr["C_TRC_ROLL_MAIN_ID"].ToString());

                if (num != dal.UpdateSlabMoveType(outDt, "E", "C", "Y", unQualifiedDt, shift, group, userID))
                {
                    TransactionHelper.RollBack();
                    return "0";
                }

                if (dal.ElimOut(dr["C_TRC_ROLL_MAIN_ID"].ToString(), num, num * pw, remark) == 0)
                {
                    TransactionHelper.RollBack();
                    return "0";
                }

                if (planDal.BackOutGroupWgt(rollMain.C_PLAN_ID, num * pw) == 0)
                {
                    TransactionHelper.RollBack();
                    return "0";
                }

                for (int i = 0; i < outDt.Rows.Count; i++)
                {
                    //int count = warmFurnaceDal.GetFurnaceCount(dr["C_TRC_ROLL_MAIN_ID"].ToString());

                    //if (count > 1)
                    //{
                    //    if (!warmFurnaceDal.Delete(outDt.Rows[i]["C_ID"].ToString()))
                    //    {
                    //        TransactionHelper.RollBack();
                    //        return "0";
                    //    }
                    //}
                    //else
                    //{
                    //    if (!warmFurnaceDal.Del(outDt.Rows[i]["C_ID"].ToString()))
                    //    {
                    //        TransactionHelper.RollBack();
                    //        return "0";
                    //    }
                    //}

                    if (!warmFurnaceDal.Del(outDt.Rows[i]["C_ID"].ToString()))
                    {
                        TransactionHelper.RollBack();
                        return "0";
                    }


                    if (dal.DelRollMainItem(rollMain.C_ID, outDt.Rows[i]["C_SLAB_MAIN_ID"].ToString()) == 0)
                    {
                        TransactionHelper.RollBack();
                        return "0";
                    }

                    Mod_TRC_WARM_FURNACE_LOG logModel = new Mod_TRC_WARM_FURNACE_LOG();
                    logModel.C_TRC_ROLL_MAIN_ID = dr["C_TRC_ROLL_MAIN_ID"].ToString();
                    logModel.N_QUA_EXIT = num;
                    logModel.N_WGT_EXIT = num * pw;
                    logModel.C_BATCH_NO = dr["C_BATCH_NO"] == null ? "" : dr["C_BATCH_NO"].ToString();
                    logModel.C_STA_ID = staID;
                    logModel.N_ROLL_STATE = 3;
                    logModel.C_EMP_ID = UserInfo.userID;
                    logModel.C_SHIFT = dr["C_SHIFT"] == null ? "" : dr["C_SHIFT"].ToString();
                    logModel.C_GROUP = dr["C_GROUP"] == null ? "" : dr["C_GROUP"].ToString();
                    logModel.C_REMARK = remark;
                    logModel.C_SLAB_MAIN_ID = outDt.Rows[i]["C_SLAB_MAIN_ID"].ToString();
                    logModel.C_STOVE = pwDt.Rows[0]["C_STOVE"].ToString();
                    logModel.N_LEN = Convert.ToDecimal(pwDt.Rows[0]["N_LEN"]);
                    logModel.C_MAT_CODE = pwDt.Rows[0]["C_MAT_CODE"].ToString();
                    logModel.C_MAT_NAME = pwDt.Rows[0]["C_MAT_NAME"].ToString();
                    if (!warmFurnaceLogDal.Add(logModel))
                    {
                        TransactionHelper.RollBack();
                        return "0";
                    }
                }

                if (!wgdDal.UpdateWgdQua(dr["C_TRC_ROLL_MAIN_ID"].ToString(), num, 1))
                {
                    TransactionHelper.RollBack();
                    return "0";
                }

                TransactionHelper.Commit();
            }
            catch (Exception ex)
            {
                TransactionHelper.RollBack();
                return "0";
            }

            return "1";
        }

        /// <summary>
        /// 创建ID
        /// </summary>
        /// <returns></returns>
        public string CreateID()
        {
            return dal.CreateID();
        }

        /// <summary>
        /// 关闭计划
        /// </summary>
        /// <param name="planID"></param>
        /// <returns></returns>
        public string ClosePlan(string planID, string orderNo, string remark, string userid, string username)
        {
            string result = "1";

            var model = planRollItem.GetModel(planID);
            var wgt = model.N_ROLL_PROD_WGT - model.N_PROD_WGT;

            TransactionHelper.BeginTransaction();

            if (!dal.UpdatePlanWgt(model.C_PLAN_ROLL_ID, wgt.Value))
            {
                TransactionHelper.RollBack();
                return "0";
            }

            if (!dal.ClosePlan(planID, remark))
            {
                TransactionHelper.RollBack();
                return "0";
            }

            Mod_TRC_ROLL_MAIN_CLOSE_LOG closeLog = new Mod_TRC_ROLL_MAIN_CLOSE_LOG();
            closeLog.C_ORDER_NO = orderNo;
            closeLog.C_REMARK = remark;
            closeLog.C_EMP_ID = userid;
            closeLog.C_EMP_NAME = username;
            closeLog.D_MOD_DT = DateTime.Now;
            if (!dal_TRC_ROLL_MAIN_CLOSE_LOG.Add(closeLog))
            {
                TransactionHelper.RollBack();
                return "0";
            }

            TransactionHelper.Commit();

            return result;
        }

        /// <summary>
        /// 关闭计划
        /// </summary>
        /// <param name="planID"></param>
        /// <returns></returns>
        public string ClosePlans(string planID, string orderNo, string remark, string userid, string username)
        {
            string result = "1";
            var model = planRollItem.GetModel(planID);
            var wgt = model.N_WGT - model.N_GROUP_WGT;
            TransactionHelper.BeginTransaction();

            //非合并订单
            if (model.N_IS_MERGE == 0)
            {
                //如果无组坯量直接撤回订单计划
                if (model.N_GROUP_WGT <= 0)
                {
                    try
                    {
                        if (model != null)
                        {
                            if (!planRollItem.Delete_Trans(model.C_ID))
                            {
                                TransactionHelper.RollBack();
                                return "撤销失败！";
                            }

                            Mod_TRP_PLAN_ROLL modPlan = planDal.GetModel(model.C_PLAN_ROLL_ID);
                            if (modPlan == null)
                            {
                                TransactionHelper.RollBack();
                                return "撤销失败！";
                            }
                            else
                            {
                                modPlan.N_STATUS = 0;
                                modPlan.N_ISSUE_WGT = modPlan.N_ISSUE_WGT - Convert.ToDecimal(model.N_WGT);

                                Mod_TRP_PLAN_ROLL_ITEM modOld = planRollItem.GetModel_By_PlanRollID(model.C_PLAN_ROLL_ID, model.C_ID);
                                if (modOld != null)
                                {
                                    modPlan.D_P_START_TIME = modOld.D_P_START_TIME;
                                    modPlan.D_P_END_TIME = modOld.D_P_END_TIME;
                                }
                                else
                                {
                                    modPlan.D_P_START_TIME = null;
                                    modPlan.D_P_END_TIME = null;
                                }

                                if (!planDal.Update_Trans(modPlan))
                                {
                                    TransactionHelper.RollBack();
                                    return "撤销失败！";
                                }
                            }

                            Mod_TRC_ROLL_MAIN_CLOSE_LOG closeLog1 = new Mod_TRC_ROLL_MAIN_CLOSE_LOG();
                            closeLog1.C_ORDER_NO = orderNo;
                            closeLog1.C_REMARK = remark;
                            closeLog1.C_EMP_ID = userid;
                            closeLog1.C_EMP_NAME = username;
                            closeLog1.D_MOD_DT = DateTime.Now;
                            if (!dal_TRC_ROLL_MAIN_CLOSE_LOG.Add(closeLog1))
                            {
                                TransactionHelper.RollBack();
                                return "0";
                            }

                            TransactionHelper.Commit();
                            return result;

                        }
                        else
                        {
                            TransactionHelper.RollBack();
                            return "撤销失败！";
                        }

                    }
                    catch
                    {
                        TransactionHelper.RollBack();
                        return "撤销失败！";
                    }
                }
                else
                {
                    model = planRollItem.GetModel(planID);
                    decimal resultNum = model.N_GROUP_WGT.Value + planRollItem.GetNum(model.C_ID, model.C_ORDER_NO);
                    if (!dal.UpdatePlanWgt(model.C_PLAN_ROLL_ID, resultNum))
                    {
                        TransactionHelper.RollBack();
                        return "0";
                    }
                }
            }
            //合并订单
            else
            {
                if (model.N_GROUP_WGT <= 0)
                {
                    Bll_TRP_PLAN_ROLL_ITEM_INFO trpPlanRollItemInfo = new Bll_TRP_PLAN_ROLL_ITEM_INFO();

                    List<Mod_TRP_PLAN_ROLL_ITEM_INFO> itemInfos = new List<Mod_TRP_PLAN_ROLL_ITEM_INFO>();
                    var itemInfoDt = trpPlanRollItemInfo.GetList("  C_ITEM_ID='" + model.C_ID + "'  ").Tables[0];
                    if (itemInfoDt != null && itemInfoDt.Rows.Count > 0)
                    {
                        for (int i = 0; i < itemInfoDt.Rows.Count; i++)
                        {
                            trpPlanRollItemInfo.BackPlanAdditional(itemInfoDt.Rows[i]["C_ID"].ToString());
                        }
                    }
                }
                else
                {
                    var dt = planRollItemInfo.GetList("  C_ITEM_ID='" + model.C_ID + "' ").Tables[0];
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        decimal issueWgt = decimal.Parse(dt.Rows[i]["N_ISSUE_WGT"].ToString());
                        string planRollID = dt.Rows[i]["C_PLAN_ROLL_ID"].ToString();
                        string id = dt.Rows[i]["C_ID"].ToString();
                        decimal? calculate = wgt - issueWgt;
                        if (calculate == 0)
                        {
                            if (!dal.UpdatePlanWgts(planRollID, issueWgt))
                            {
                                TransactionHelper.RollBack();
                                return "0";
                            }

                            if (!dal.ClosePlanRollItemInfo(id))
                            {
                                TransactionHelper.RollBack();
                                return "0";
                            }
                        }
                        else if (calculate > 0)
                        {
                            if (!dal.UpdatePlanWgts(planRollID, issueWgt))
                            {
                                TransactionHelper.RollBack();
                                return "0";
                            }

                            if (!dal.ClosePlanRollItemInfo(id))
                            {
                                TransactionHelper.RollBack();
                                return "0";
                            }
                            wgt = wgt - issueWgt;
                        }
                        else if (calculate < 0)
                        {
                            if (!dal.UpdatePlanWgts(planRollID, wgt.Value))
                            {
                                TransactionHelper.RollBack();
                                return "0";
                            }

                            if (!dal.ClosePlanRollItemInfo(id))
                            {
                                TransactionHelper.RollBack();
                                return "0";
                            }
                            break;
                        }
                    }
                }
            }

            if (!dal.ClosePlan(planID, remark))
            {
                TransactionHelper.RollBack();
                return "0";
            }

            Mod_TRC_ROLL_MAIN_CLOSE_LOG closeLog = new Mod_TRC_ROLL_MAIN_CLOSE_LOG();
            closeLog.C_ORDER_NO = orderNo;
            closeLog.C_REMARK = remark;
            closeLog.C_EMP_ID = userid;
            closeLog.C_EMP_NAME = username;
            closeLog.D_MOD_DT = DateTime.Now;
            if (!dal_TRC_ROLL_MAIN_CLOSE_LOG.Add(closeLog))
            {
                TransactionHelper.RollBack();
                return "0";
            }

            TransactionHelper.Commit();

            return result;
        }




        /// <summary>
        /// 关闭计划
        /// </summary>
        /// <param name="planID"></param>
        /// <returns></returns>
        public string SuccessPlan(string planID)
        {
            string result = "1";
            if (!dal.SuccessPlan(planID))
            {
                result = "0";
            }
            return result;
        }

        /// <summary>
        /// 获取钢坯库存
        /// </summary>
        /// <param name="grd">钢种</param>
        /// <param name="spec">断面</param>
        /// <param name="std">执行标准</param>
        /// <param name="slabwhCode">仓库</param>
        /// <param name="matCode">物料编码</param>
        /// <returns></returns>
        public DataTable GetSlabInventory(string grd, string spec, string std, string slabwhCode, string matCode, string length, DataTable replaceStl)
        {
            return dal.GetSlabInventory(grd, spec, std, slabwhCode, matCode, length, replaceStl);
        }

        /// <summary>
        /// 获取钢坯库存
        /// </summary>
        /// <param name="grd">钢种</param>
        /// <param name="std">执行标准</param>
        /// <param name="slabwhCode">仓库编码</param>
        /// <param name="matCode">物料编码</param>
        /// <returns></returns>
        public DataTable GetSlabInventory(string grd, string std, string slabwhCode, DataTable replaceStl)
        {
            return dal.GetSlabInventory(grd, std, slabwhCode, replaceStl);
        }

        public string WgdHandler(string stove, string batchNo, string planID, int num,
       decimal wgt, string grd, string spec, string std, string id, string staID, DateTime start, DateTime end
       , string shift, string group, string shiftName, string groupName)
        {
            string result = "1";
            Mod_TRC_ROLL_WGD model = new Mod_TRC_ROLL_WGD();
            var planM = planRollItem.GetModel_Item(planID);
            model.C_ID = Guid.NewGuid().ToString();
            model.C_STA_ID = staID;
            model.C_STOVE = stove;
            model.C_BATCH_NO = batchNo;
            model.C_PLAN_ID = planID;
            model.N_QUA_PRODUCE = num;
            model.N_WGT_PRODUCE = wgt;
            model.N_STATUS = 0;
            model.C_STD_CODE = std;
            model.C_STL_GRD = grd;
            model.C_SPEC = spec;
            model.C_MAIN_ID = id;
            model.D_PRODUCE_DATE_B = start;
            model.C_PRODUCE_SHIFT = shift;
            model.C_PRODUCE_GROUP = group;
            model.C_PRODUCE_EMP_ID = RV.UI.UserInfo.userID;
            model.D_MOD_DT = start;
            model.D_PRODUCE_DATE = start;
            model.C_FREE_TERM = planM.C_FREE_TERM;
            model.C_FREE_TERM2 = planM.C_FREE_TERM2;
            model.C_PACK = planM.C_PACK;
            model.C_AREA = planM.C_AREA;
            model.C_PCLX = planM.C_PCLX;
            model.C_MAT_CODE = planM.C_MAT_CODE;
            model.C_MAT_DESC = planM.C_MAT_NAME;
            model.C_PRODUCE_SHIFT_NAME = shiftName;
            model.C_PRODUCE_GROUP_NAME = groupName;
            model.N_IS_MERGE = planM.N_IS_MERGE;
            if (!wgdDal.Add(model))
            {
                TransactionHelper.RollBack();
                return "0";
            }


            Mod_TRC_ROLL_WGD_ITEM itemM = new Mod_TRC_ROLL_WGD_ITEM();
            itemM.C_MAIN_ID = model.C_MAIN_ID;
            itemM.C_ROLL_WGD_ID = model.C_ID;
            itemM.C_BATCH_NO = batchNo;
            itemM.N_STATUS = 0;
            itemM.C_STL_GRD = model.C_STL_GRD;
            itemM.C_STD_CODE = model.C_STD_CODE;
            itemM.C_SPEC = model.C_SPEC;
            itemM.C_MAT_CODE = planM.C_MAT_CODE;
            itemM.C_MAT_DESC = planM.C_MAT_NAME;
            itemM.C_ZYX1 = planM.C_FREE_TERM;
            itemM.C_ZYX2 = planM.C_FREE_TERM2;
            itemM.C_BZYQ = model.C_PACK;
            itemM.C_SALE_AREA = model.C_AREA;
            itemM.C_MRSX = model.C_MRSX;
            if (!wgdItemDal.Add(itemM))
            {
                TransactionHelper.RollBack();
                return "0";
            }

            DataTable dt = wgdDal.Get_Item_List(planM.C_MAT_CODE).Tables[0];
            if (dt != null && dt.Rows.Count > 0)
            {
                foreach (DataRow item in dt.Rows)
                {
                    Mod_TRC_ROLL_WGD_ITEM itemMM = new Mod_TRC_ROLL_WGD_ITEM();
                    itemMM.C_MAIN_ID = model.C_MAIN_ID;
                    itemMM.C_ROLL_WGD_ID = model.C_ID;
                    itemMM.C_BATCH_NO = batchNo;
                    itemMM.N_STATUS = 0;
                    itemMM.C_STL_GRD = item["钢种"].ToString();
                    itemMM.C_STD_CODE = item["执行标准"].ToString();
                    itemMM.C_SPEC = item["规格"].ToString();
                    itemMM.C_MAT_CODE = item["物料编码"].ToString();
                    itemMM.C_MAT_DESC = item["物料名称"].ToString();
                    itemMM.C_ZYX1 = item["自由项1"].ToString();
                    itemMM.C_ZYX2 = item["自由项2"].ToString();
                    itemMM.C_BZYQ = model.C_PACK;
                    itemMM.C_SALE_AREA = model.C_AREA;
                    itemMM.C_MRSX = model.C_MRSX;
                    if (!wgdItemDal.Add(itemMM))
                    {
                        {
                            TransactionHelper.RollBack();
                            return "0";
                        }
                    }
                }
            }

            return result;
        }

        /// <summary>
        /// 获取加热炉信息
        /// </summary>
        /// <param name="staID"></param>
        /// <param name="num"></param>
        /// <param name="rollStatus"></param>
        /// <returns></returns>
        public int GetFurnaceNum(string staID, int num, int rollStatus)
        {
            DataTable dt = dal.GetFurnace(staID, num, rollStatus).Tables[0];
            return dal.GetFurnaceNum(dt.Rows[0]["C_TRC_ROLL_MAIN_ID"].ToString(), rollStatus);
        }

        /// <summary>
        /// 验证是否可以组坯
        /// </summary>
        /// <returns></returns>
        public bool ChckIfAsse(string planID, decimal pw)
        {
            return planRollItem.ChckIfAsse(planID, pw);
        }

        /// <summary>
        /// 获取组批信息
        /// </summary>
        /// <param name="C_BATCH_NO">批号</param>
        /// <param name="strTime1">组批时间</param>
        /// <param name="strTime2">组批时间</param>
        /// <param name="C_STA_ID">轧线</param>
        /// <returns></returns>
        public DataSet GetList(string C_BATCH_NO, string strTime1, string strTime2, string C_STA_ID)
        {
            return dal.GetList(C_BATCH_NO, strTime1, strTime2, C_STA_ID);
        }

        /// <summary>
        /// 修改计划时间
        /// </summary>
        /// <param name="id">计划主键</param>
        /// <param name="start">计划开始时间</param>
        /// <param name="end">计划结束时间</param>
        /// <returns></returns>
        public bool UpdatePlanTime(string id, DateTime start, DateTime end)
        {
            return dal.UpdatePlanTime(id, start, end);
        }

        /// <summary>
        /// 重新计算订单执行时间
        /// </summary>
        /// <param name="dt"></param>
        /// <param name="staID">产线ID</param>
        public void OverAgainTime(DataTable dt, string staID)
        {
            if (dt != null && dt.Rows.Count > 1)
            {
                //循环订单计划
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    //如果是最后一条结束操作
                    if (i == dt.Rows.Count - 1)
                        return;
                    //从第二条开始重新计算执行时间
                    else
                    {
                        var preDr = dt.Rows[i];
                        var nexDr = dt.Rows[i + 1];
                        //获取换规格时间
                        int hggTime = dalChangeTime.Get_Time2(staID, preDr["C_SPEC"].ToString(), nexDr["C_SPEC"].ToString());//换规格时间
                        //获取第一条订单结束时间+换规格（时间）为第二条开始时间
                        DateTime startTime = DateTime.Parse(preDr["D_P_END_TIME"].ToString()).AddMinutes(hggTime);
                        nexDr["D_P_START_TIME"] = startTime;
                        //通过机时产能计算执行时间
                        double cn = double.Parse(nexDr["N_WGT"].ToString()) / double.Parse(nexDr["N_MACH_WGT"].ToString());
                        //第二条开始时间+机时产能(时间)
                        DateTime endTime = startTime.AddHours(cn);
                        nexDr["D_P_END_TIME"] = endTime;
                        dal.UpdatePlanTime(nexDr["C_ID"].ToString(), startTime, endTime);
                    }
                }
            }
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        /// <param name="batchNO"></param>
        /// <returns></returns>
        public Mod_TRC_ROLL_MAIN GetModels(string batchNO)
        {
            return dal.GetModels(batchNO);
        }

        /// <summary>
        /// 获取用户名称
        /// </summary>
        /// <returns></returns>
        public string GetUserName(string id)
        {
            return dal.GetUserName(id);
        }

        /// <summary>
        /// 获取钢坯长度
        /// </summary>
        /// <returns></returns>
        public DataTable GetSlab(string stove)
        {
            return dal.GetSlab(stove);
        }

        /// <summary>
        /// 获取钢坯长度
        /// </summary>
        /// <returns></returns>
        public DataTable GetSlabs(string stove)
        {
            return dal.GetSlabs(stove);
        }

        /// <summary>
        ///获取剔除记录
        /// </summary>
        /// <returns></returns>
        public DataTable GetTCJL(DateTime start)
        {
            return dal.GetTCJL(start);
        }

        /// <summary>
        /// 根据炉号获取钢坯
        /// </summary>
        /// <param name="stove"></param>
        /// <returns></returns>
        public DataTable GetStl(string stove)
        {
            return dal.GetStl(stove);
        }

        /// <summary>
        /// 根据炉号获取钢坯主键
        /// </summary>
        /// <param name="stove"></param>
        /// <returns></returns>
        public DataTable GetStlIds(string stove, int asseNum)
        {
            return dal.GetStlIds(stove, asseNum);
        }

        /// <summary>
        /// 组坯补坯
        /// </summary>
        /// <param name="slabTable">钢坯</param>
        /// <param name="id">组坯主键</param>
        /// <returns></returns>
        public string SupplementSlab(DataTable slabTable, string id)
        {
            string result = "1";
            try
            {
                TransactionHelper.BeginTransaction();
                if (slabTable != null && slabTable.Rows.Count > 0)
                {
                    //1.添加轧钢组批子表
                    Bll_TRC_ROLL_MAIN_ITEM bll = new Bll_TRC_ROLL_MAIN_ITEM();
                    for (int i = 0; i < slabTable.Rows.Count; i++)
                    {
                        Mod_TRC_ROLL_MAIN_ITEM rollMainItem = new Mod_TRC_ROLL_MAIN_ITEM();
                        rollMainItem.C_SLAB_MAIN_ID = slabTable.Rows[0]["C_ID"].ToString();
                        rollMainItem.C_ROLL_MAIN_ID = id;
                        if (!bll.Add(rollMainItem))
                        {
                            TransactionHelper.RollBack();
                            return "0";
                        }
                    }

                    string sql = @"  UPDATE TSC_SLAB_MAIN T
                                     SET T.C_MOVE_TYPE='C'
                                     WHERE  ";
                    //2.修改钢坯状态
                    for (int i = 0; i < slabTable.Rows.Count; i++)
                    {
                        if (i == slabTable.Rows.Count - 1)
                        {
                            sql += " T.C_ID='" + slabTable.Rows[i]["C_ID"].ToString() + "' ";
                        }
                        else
                        {
                            sql += " T.C_ID='" + slabTable.Rows[i]["C_ID"].ToString() + "' OR ";
                        }
                    }
                    if (!dal.UpdateSlabType(sql))
                    {
                        TransactionHelper.RollBack();
                        return "0";
                    }
                }

                //3.修改组坯表信息
                var rollM = dal.GetModel(id);
                decimal wgt = rollM.N_WGT_TOTAL_VIRTUAL.Value / rollM.N_QUA_TOTAL_VRITUAL.Value;
                decimal qua = slabTable.Rows.Count;
                rollM.N_QUA_TOTAL_VRITUAL += qua;
                rollM.N_WGT_TOTAL_VIRTUAL += qua * wgt;
                rollM.N_QUA_EXIT += qua;
                rollM.N_WGT_EXIT += qua * wgt;
                if (!dal.UpdateSupWgt(rollM))
                {
                    TransactionHelper.RollBack();
                    return "0";
                }

                //修改计划组批量
                if (planDal.UpdateGroupWgt(rollM.C_PLAN_ID, rollM.N_WGT_TOTAL) == 0)
                {
                    TransactionHelper.RollBack();
                    return "0";
                }


                //添加日志
                for (int i = 0; i < slabTable.Rows.Count; i++)
                {
                    Mod_TRC_WARM_FURNACE_LOG logModel = new Mod_TRC_WARM_FURNACE_LOG();
                    logModel.C_TRC_ROLL_MAIN_ID = id;
                    logModel.C_BATCH_NO = rollM.C_BATCH_NO;
                    logModel.N_ROLL_STATE = 4;
                    logModel.C_EMP_ID = UserInfo.userID;
                    logModel.C_SLAB_MAIN_ID = slabTable.Rows[i]["C_ID"].ToString();
                    if (!warmFurnaceLogDal.Add(logModel))
                    {
                        TransactionHelper.RollBack();
                        return "0";
                    }
                }

                TransactionHelper.Commit();


                //4.修改完工单表信息
                var wgdM = wgdDal.GetModel(id, 1);
                wgdM.N_QUA_PRODUCE = rollM.N_QUA_TOTAL_VRITUAL;
                wgdDal.Update(wgdM);

            }
            catch
            {
                TransactionHelper.RollBack();
                return "0";
            }
            return result;
        }

        /// <summary>
        /// 钢坯剔除
        /// </summary>
        /// <param name="id">组坯主键</param>
        /// <param name="asseNum">支数</param>
        /// <returns></returns>
        public string SlabElim(string id, int asseNum)
        {
            string result = "1";

            try
            {
                TransactionHelper.BeginTransaction();

                var dt = dal.GetRollMainItem(id, asseNum);
                var rollMainM = dal.GetModel(id);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    //1.删除钢坯中间表
                    if (dal.DelRollMainItem(id, dt.Rows[i]["C_SLAB_MAIN_ID"].ToString()) == 0)
                    {
                        TransactionHelper.RollBack();
                        return "0";
                    }
                }


                //2.修改钢坯状态
                string sql = @"  UPDATE TSC_SLAB_MAIN T
                                     SET T.C_MOVE_TYPE='E'
                                     WHERE  ";

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (i == dt.Rows.Count - 1)
                    {
                        sql += " T.C_ID='" + dt.Rows[i]["C_SLAB_MAIN_ID"].ToString() + "' ";
                    }
                    else
                    {
                        sql += " T.C_ID='" + dt.Rows[i]["C_SLAB_MAIN_ID"].ToString() + "' OR ";
                    }
                }
                if (!dal.UpdateSlabType(sql))
                {
                    TransactionHelper.RollBack();
                    return "0";
                }

                //3.修改组坯信息
                var count = dt.Rows.Count;
                var wgt = rollMainM.N_WGT_TOTAL_VIRTUAL.Value / rollMainM.N_QUA_TOTAL_VRITUAL.Value;
                if (dal.ElimPut(id, count, count * wgt, "补批管理剔除") == 0)
                {
                    TransactionHelper.RollBack();
                    return "0";
                }

                //修改计划组坯量
                if (planDal.BackOutGroupWgt(rollMainM.C_PLAN_ID, count * wgt) == 0)
                {
                    TransactionHelper.RollBack();
                    return "0";
                }

                //添加日志
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Mod_TRC_WARM_FURNACE_LOG logModel = new Mod_TRC_WARM_FURNACE_LOG();
                    logModel.C_TRC_ROLL_MAIN_ID = id;
                    logModel.C_BATCH_NO = rollMainM.C_BATCH_NO;
                    logModel.N_ROLL_STATE = 3;
                    logModel.C_EMP_ID = UserInfo.userID;
                    logModel.C_SLAB_MAIN_ID = dt.Rows[i]["C_SLAB_MAIN_ID"].ToString();
                    if (!warmFurnaceLogDal.Add(logModel))
                    {
                        TransactionHelper.RollBack();
                        return "0";
                    }
                }

                TransactionHelper.Commit();

                //4.修改完工单表信息
                var roll = dal.GetModel(id);
                var wgdM = wgdDal.GetModel(id, 1);
                wgdM.N_QUA_PRODUCE = roll.N_QUA_TOTAL_VRITUAL;
                wgdDal.Update(wgdM);

            }
            catch (Exception e) { }

            return result;
        }


        /// <summary>
        /// 获取轧钢中间表
        /// </summary>
        /// <param name="id">组坯主键</param>
        /// <returns></returns>
        public DataTable GetRollMainItem(string id)
        {
            return dal.GetRollMainItem(id);
        }

        #endregion  ExtensionMethod
    }
}

