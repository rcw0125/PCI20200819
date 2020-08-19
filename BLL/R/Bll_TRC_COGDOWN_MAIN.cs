using System;
using System.Data;
using System.Collections.Generic;
using DAL;
using MODEL;
using RV.UI;

namespace BLL
{
    public partial class Bll_TRC_COGDOWN_MAIN
    {
        private readonly Bll_TB_MATRL_MAIN bll_TB_MATRL_MAIN = new Bll_TB_MATRL_MAIN();
        private readonly Dal_TSC_SLAB_MAIN slabMainDal = new Dal_TSC_SLAB_MAIN();
        private readonly Dal_TRP_PLAN_COGDOWN planDal = new Dal_TRP_PLAN_COGDOWN();
        private readonly Dal_TRC_COGDOWN_MAIN dal = new Dal_TRC_COGDOWN_MAIN();
        private readonly Dal_TRC_COGDOWN_MAIN_ITEM itemDal = new Dal_TRC_COGDOWN_MAIN_ITEM();
        private readonly Dal_TRC_COGDOWN_LOG dalLog = new Dal_TRC_COGDOWN_LOG();
        private readonly Dal_TRC_WARM_FURNACE warmFurnaceDal = new Dal_TRC_WARM_FURNACE();
        private readonly Dal_TRC_WARM_FURNACE_LOG warmFurnaceLogDal = new Dal_TRC_WARM_FURNACE_LOG();
        private readonly Dal_TRC_COGDOWN_PRODUCT productDal = new Dal_TRC_COGDOWN_PRODUCT();
        private readonly Dal_TRC_COGDOWN_PRODUCT_LOG productLogDal = new Dal_TRC_COGDOWN_PRODUCT_LOG();
        private readonly Bll_TB_STD_CONFIG bll_TB_STD_CONFIG = new Bll_TB_STD_CONFIG();
        private readonly Bll_TPB_SLABWH bll_TPB_SLABWH = new Bll_TPB_SLABWH();
        private readonly Bll_TB_STA bll_TB_STA = new Bll_TB_STA();
        private readonly Bll_Interface_NC_Roll_A1 bll_Interface_NC_Roll_A1 = new Bll_Interface_NC_Roll_A1();
        private readonly Bll_Interface_NC_Roll_A2 bll_Interface_NC_Roll_A2 = new Bll_Interface_NC_Roll_A2();
        private readonly Bll_Interface_NC_Roll_A3 bll_Interface_NC_Roll_A3 = new Bll_Interface_NC_Roll_A3();
        private readonly Bll_Interface_NC_Roll_A4 bll_Interface_NC_Roll_A4 = new Bll_Interface_NC_Roll_A4();
        private readonly Bll_Interface_NC_Roll_46 bll_Interface_NC_Roll_46 = new Bll_Interface_NC_Roll_46();
        private readonly Dal_TS_USER dal_TS_USER = new Dal_TS_USER();
        private readonly Dal_TRC_ROLL_MAIN dal_TRC_ROLL_MAIN = new Dal_TRC_ROLL_MAIN();
        private readonly Dal_TRC_ROLL_WGD dal_TRC_ROLL_WGD = new Dal_TRC_ROLL_WGD();

        public Bll_TRC_COGDOWN_MAIN()
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
        public bool Add(Mod_TRC_COGDOWN_MAIN model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Mod_TRC_COGDOWN_MAIN model)
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
        /// 得到一个对象实体
        /// </summary>
        public Mod_TRC_COGDOWN_MAIN GetModel(string C_ID)
        {

            return dal.GetModel(C_ID);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Mod_TRC_COGDOWN_MAIN GetModels(string batchNo)
        {
            return dal.GetModels(batchNo);
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
        /// 获得开坯数据列表
        /// </summary>
        public DataSet GetCogDownList(string strWhere)
        {
            return dal.GetCogDownList(strWhere);
        }

        /// <summary>
        /// 获取开坯实绩数据列表
        /// </summary>
        /// <param name="staID">工位</param>
        /// <returns></returns>
        public DataSet GetCogDownFact(string staID, DateTime start, DateTime end)
        {
            return dal.GetCogDownFact(staID, start, end);
        }

        /// <summary>
        /// 获取开坯实绩数据列表
        /// </summary>
        /// <param name="staID">工位</param>
        /// <param name="desc">排序</param>
        /// <returns></returns>
        public DataSet GetCogDownFact(string staID, bool desc)
        {
            return dal.GetCogDownFact(staID, desc);
        }


        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Mod_TRC_COGDOWN_MAIN> DataTableToList(DataTable dt)
        {
            List<Mod_TRC_COGDOWN_MAIN> modelList = new List<Mod_TRC_COGDOWN_MAIN>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Mod_TRC_COGDOWN_MAIN model;
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
        #endregion  BasicMethod

        #region  ExtensionMethod
        /// <summary>
        /// 生成批号
        /// </summary>
        /// <param name="staID"></param>
        /// <returns></returns>
        public string CreateBranchNo(string staID)
        {
            return dal.CreateBranchNo(staID);
        }

        /// <summary>
        /// 组批处理
        /// </summary>
        /// <param name="model">组批主表数据</param>
        /// <param name="grd">可轧钢坯钢种</param>
        /// <param name="std">可轧钢坯执行标准</param>
        /// <param name="slbwhCode">待轧钢坯仓库库位编码</param>
        /// <returns></returns>
        public string AssemblyHandler(Mod_TRC_COGDOWN_MAIN model, string grd, string std, string slbwhCode, string path)
        {
            try
            {
                TransactionHelper.BeginTransaction();
                if (!dal.Add(model))
                {
                    TransactionHelper.RollBack();
                    return "0";
                }

                //钢坯ID
                string grdID = "";
                ///钢坯明细
                DataTable assembly = slabMainDal.GetRepalceStl(grd, std, model.C_STOVE, (int)model.N_QUA_TOTAL, 1, slbwhCode).Tables[0];
                //添加组批子表
                if (assembly == null || assembly.Rows.Count == 0)
                {
                    TransactionHelper.RollBack();
                    return "0";
                }
                for (int i = 0; i < assembly.Rows.Count; i++)
                {
                    Mod_TRC_COGDOWN_MAIN_ITEM item = new Mod_TRC_COGDOWN_MAIN_ITEM();
                    item.C_COGDOWN_MAIN_ID = model.C_ID;
                    item.C_SLAB_MAIN_ID = assembly.Rows[i]["C_ID"].ToString();
                    grdID += item.C_SLAB_MAIN_ID + ",";
                    if (!itemDal.Add(item))
                    {
                        TransactionHelper.RollBack();
                        return "0";
                    }
                }

                //钢坯状态有DR的 回滚全部操作
                if (assembly.Rows.Count != slabMainDal.UpdateGrdMoveType(grdID, 1, slbwhCode))
                {
                    TransactionHelper.RollBack();
                    return "0";
                }

                //修改计划组批量
                if (planDal.UpdateGroupWgt(model.C_PLAN_ID, (decimal)model.N_WGT_TOTAL) == 0)
                {
                    TransactionHelper.RollBack();
                    return "0";
                }

                #region 新增日志
                Mod_TRC_COGDOWN_LOG log = new Mod_TRC_COGDOWN_LOG();
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

                #region NC发送A1
                NcRollA1 ncA1 = new NcRollA1();
                var plan = planDal.GetModel(model.C_PLAN_ID);
                var a1Sta = bll_TB_STA.GetModel(plan.C_STA_ID);
                ncA1.bmid = "1001NC1000000000038P";
                ncA1.jhrq = DateTime.Parse(plan.D_P_START_TIME == null ? DateTime.Now.ToString() : plan.D_P_START_TIME.ToString());
                ncA1.jhxxsl = plan.N_WGT.ToString();
                var matrl = bll_TB_MATRL_MAIN.GetModel(plan.C_MAT_CODE);
                ncA1.jhyid = matrl.C_PLANEMP;
                ncA1.jldwid = matrl.C_PK_MEASDOC;
                ncA1.pk_produce = matrl.C_PK_PRODUCE;
                ncA1.scbmid = a1Sta.C_SSBMID;
                ncA1.shrid = RV.UI.UserInfo.userID;
                ncA1.shrq = DateTime.Parse(plan.D_P_START_TIME == null ? DateTime.Now.ToString() : plan.D_P_START_TIME.ToString());
                ncA1.slrq = DateTime.Parse(plan.D_NEED_DT == null ? DateTime.Now.ToString() : plan.D_NEED_DT.ToString());
                ncA1.wlbmid = matrl.C_PK_INVBASDOC;
                ncA1.xdrq = DateTime.Parse(plan.D_P_START_TIME == null ? DateTime.Now.ToString() : plan.D_P_START_TIME.ToString());
                ncA1.xqrq = DateTime.Parse(plan.D_DELIVERY_DT == null ? DateTime.Now.ToString() : plan.D_DELIVERY_DT.ToString());
                ncA1.xqsl = plan.N_WGT.ToString();
                ncA1.zdrq = DateTime.Now;
                ncA1.zyx1 = plan.C_FREE1;
                ncA1.zyx2 = plan.C_FREE2;
                ncA1.zyx3 = plan.C_PACK;
                ncA1.zyx5 = plan.C_ID;
                ncA1.jhfaid = matrl.C_PK_PSID;
                string a1Name = plan.C_ID + "_A1.xml";
                var arrReault = bll_Interface_NC_Roll_A1.SendXml_ROLL_A1("", a1Name, ncA1, path);
                //if (arrReault[0] != "1")
                //{
                //    dal.UpdateIfStatus(2, model.C_BATCH_NO, arrReault[1]);
                //}
                #endregion

                planDal.AccomplishPlan(model.C_PLAN_ID, 2);

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

                if (!slabMainDal.BackOutGrdMoveType(asseID, 1))
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
                Mod_TRC_COGDOWN_LOG log = new Mod_TRC_COGDOWN_LOG();
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

                planDal.UnAccomplishPlan(model.C_PLAN_ID, 1);
            }
            catch (Exception ex)
            {
                TransactionHelper.RollBack();
                return "0";
            }

            return "1";
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
        /// <param name="planID">计划主键</param>
        /// <returns></returns>
        public string PutFurnaceHandler(string id, int putNum, string batchNo, string staID, string shift, string group, string remark, string planID, decimal pw, DateTime putTime)
        {

            try
            {
                TransactionHelper.BeginTransaction();

                DataTable slabDt = new DataTable();
                int reNum = dal.UpdatePutFurnaceType(id, putNum, out slabDt);
                if (reNum != putNum)
                {
                    TransactionHelper.RollBack();
                    return "0";
                }

                if (dal.UpdatePut(id, putNum, pw, remark) == 0)
                {
                    TransactionHelper.RollBack();
                    return "0";
                }


                if (slabDt != null && slabDt.Rows.Count > 0)
                {
                    var slab = slabMainDal.GetModel(slabDt.Rows[0]["C_SLAB_MAIN_ID"].ToString());
                    var plan = planDal.GetModel(planID);

                    for (int i = 0; i < slabDt.Rows.Count; i++)
                    {
                        Mod_TRC_WARM_FURNACE warmModel = new Mod_TRC_WARM_FURNACE();
                        warmModel.C_TRC_ROLL_MAIN_ID = id;
                        warmModel.N_QUA_JOIN = putNum;
                        warmModel.N_WGT_JOIN = pw;
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
                        logModel.N_WGT_JOIN = pw;
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
                        logModel.D_MOD_DT = putTime;
                        if (!warmFurnaceLogDal.Add(logModel))
                        {
                            TransactionHelper.RollBack();
                            return "0";
                        }
                    }
                }

                dal.UpdateFurnaceTime(id, putTime);

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
                DataTable pwDt = dal_TRC_ROLL_MAIN.GetSlabInfo(dr["C_SLAB_MAIN_ID"].ToString());
                decimal wgt = decimal.Parse(pwDt.Rows[0]["N_WGT"].ToString());

                if (num != dal.UpdateSlabMoveType(putDt, "NP", "R", null))
                {
                    TransactionHelper.RollBack();
                    return "0";
                }

                if (dal.BackPut(dr["C_TRC_ROLL_MAIN_ID"].ToString(), num, num * wgt, remark) == 0)
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
                    logModel.N_WGT_JOIN = num * wgt;
                    logModel.C_BATCH_NO = dr["C_BATCH_NO"] == null ? "" : dr["C_BATCH_NO"].ToString();
                    logModel.C_STA_ID = staID;
                    logModel.N_ROLL_STATE = 1;
                    logModel.C_EMP_ID = UserInfo.userID;
                    logModel.C_SHIFT = dr["C_SHIFT"] == null ? "" : dr["C_SHIFT"].ToString();
                    logModel.C_GROUP = dr["C_GROUP"] == null ? "" : dr["C_GROUP"].ToString();
                    logModel.N_TYPE = 2;
                    logModel.C_REMARK = remark;
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
            DataTable putDt = dal.GetCogMainSlabIds(id, num);

            if (putDt == null || putDt.Rows.Count == 0)
                return "0";

            TransactionHelper.BeginTransaction();
            try
            {
                DataRow dr = putDt.Rows[0];
                DataTable pwDt = dal_TRC_ROLL_MAIN.GetSlabInfo(dr["C_SLAB_MAIN_ID"].ToString());
                decimal wgt = decimal.Parse(pwDt.Rows[0]["N_WGT"].ToString());
                var rollMain = dal.GetModel(id);

                if (num != dal.UpdateSlabMoveType(putDt, "E", "NP", "Y", slabwhCode, shift, group, userID))
                {
                    TransactionHelper.RollBack();
                    return "0";
                }

                if (dal.ElimPut(id, num, num * wgt, remark) == 0)
                {
                    TransactionHelper.RollBack();
                    return "0";
                }

                if (planDal.BackOutGroupWgt(rollMain.C_PLAN_ID, num * wgt) == 0)
                {
                    TransactionHelper.RollBack();
                    return "0";
                }

                for (int i = 0; i < putDt.Rows.Count; i++)
                {
                    var slab = dal_TRC_ROLL_MAIN.GetSlabInfo(putDt.Rows[i]["C_SLAB_MAIN_ID"].ToString());
                    Mod_TRC_WARM_FURNACE_LOG logModel = new Mod_TRC_WARM_FURNACE_LOG();
                    logModel.C_TRC_ROLL_MAIN_ID = id;
                    logModel.N_QUA_JOIN = num;
                    logModel.N_WGT_JOIN = num * wgt;
                    logModel.C_BATCH_NO = slab.Rows[0]["C_BATCH_NO"] == null ? "" : slab.Rows[0]["C_BATCH_NO"].ToString();
                    logModel.C_STA_ID = staID;
                    logModel.N_ROLL_STATE = 3;
                    logModel.C_EMP_ID = UserInfo.userID;
                    logModel.C_SHIFT = shift;
                    logModel.C_GROUP = group;
                    logModel.C_REMARK = remark;
                    logModel.C_SLAB_MAIN_ID = putDt.Rows[i]["C_SLAB_MAIN_ID"].ToString();
                    if (!warmFurnaceLogDal.Add(logModel))
                    {
                        TransactionHelper.RollBack();
                        return "0";
                    }

                    if (dal.DelCogMainItem(id, putDt.Rows[i]["C_SLAB_MAIN_ID"].ToString()) == 0)
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
        /// <param name="putNum">组批支数</param>
        /// <param name="batchNo">批号</param>
        /// <param name="staID">工位号</param>
        /// <param name="shift">班次</param>
        /// <param name="group">班组</param>
        /// <param name="remark">备注</param>
        /// <returns></returns>
        public string OutFurnaceHandler(string id, int putNum, string batchNo, string staID, string shift, string group, string remark, string planID, decimal pw, DateTime outTime)
        {
            try
            {
                TransactionHelper.BeginTransaction();

                DataTable slabDt = new DataTable();
                int reNum = dal.UpdateOutFurnaceType(id, putNum, out slabDt);
                if (reNum != putNum)
                {
                    TransactionHelper.RollBack();
                    return "0";
                }

                if (dal.UpdateOut(id, putNum, pw, remark) == 0)
                {
                    TransactionHelper.RollBack();
                    return "0";
                }

                if (dal.UpdateWarmFurnaceStatus(slabDt, 2, shift, group, id) != putNum)
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
                        logModel.N_WGT_EXIT = pw;
                        logModel.C_BATCH_NO = batchNo;
                        logModel.C_STA_ID = staID;
                        logModel.N_ROLL_STATE = 2;
                        logModel.C_EMP_ID = UserInfo.userID;
                        logModel.C_SHIFT = shift;
                        logModel.C_GROUP = group;
                        logModel.N_TYPE = 1;
                        logModel.C_REMARK = remark;
                        logModel.C_SLAB_MAIN_ID = slabDt.Rows[i]["C_SLAB_MAIN_ID"].ToString();
                        if (!warmFurnaceLogDal.Add(logModel))
                        {
                            TransactionHelper.RollBack();
                            return "0";
                        }
                    }
                }

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
        /// <param name="shift">班次</param>
        /// <param name="group">班组</param>
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
                DataTable pwDt = dal_TRC_ROLL_MAIN.GetSlabInfo(dr["C_SLAB_MAIN_ID"].ToString());
                decimal wgt = decimal.Parse(pwDt.Rows[0]["N_WGT"].ToString());

                if (num != dal.UpdateSlabMoveType(outDt, "R", "C", null))
                {
                    TransactionHelper.RollBack();
                    return "0";
                }


                if (dal.BackOut(dr["C_TRC_ROLL_MAIN_ID"].ToString(), num, num * wgt, remark) == 0)
                {
                    TransactionHelper.RollBack();
                    return "0";
                }

                if (dal.UpdateWarmFurnaceStatus(outDt, 1, shift, group, dr["C_TRC_ROLL_MAIN_ID"].ToString()) != num)
                {
                    TransactionHelper.RollBack();
                    return "0";
                }

                for (int i = 0; i < outDt.Rows.Count; i++)
                {
                    Mod_TRC_WARM_FURNACE_LOG logModel = new Mod_TRC_WARM_FURNACE_LOG();
                    logModel.C_TRC_ROLL_MAIN_ID = dr["C_TRC_ROLL_MAIN_ID"].ToString();
                    logModel.N_QUA_EXIT = num;
                    logModel.N_WGT_EXIT = num * wgt;
                    logModel.C_BATCH_NO = dr["C_BATCH_NO"] == null ? "" : dr["C_BATCH_NO"].ToString();
                    logModel.C_STA_ID = staID;
                    logModel.N_ROLL_STATE = 1;
                    logModel.C_EMP_ID = UserInfo.userID;
                    logModel.C_SHIFT = dr["C_SHIFT"] == null ? "" : dr["C_SHIFT"].ToString();
                    logModel.C_GROUP = dr["C_GROUP"] == null ? "" : dr["C_GROUP"].ToString();
                    logModel.N_TYPE = 2;
                    logModel.C_REMARK = remark;
                    logModel.C_SLAB_MAIN_ID = outDt.Rows[i]["C_SLAB_MAIN_ID"].ToString();
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
        /// 出炉剔除
        /// </summary>
        /// <param name="staID">工位ID</param>
        /// <param name="remark">备注</param>
        /// <param name="num">支数</param>
        /// <returns></returns>
        public string OutElimHandler(string staID, string remark, int num, string slabwhCode, string shift, string group, string userID)
        {
            DataTable outDt = dal.GetFurnace(staID, num, 2).Tables[0];

            if (outDt == null || outDt.Rows.Count == 0)
                return "0";

            TransactionHelper.BeginTransaction();
            try
            {
                DataRow dr = outDt.Rows[0];
                DataTable pwDt = dal_TRC_ROLL_MAIN.GetSlabInfo(dr["C_SLAB_MAIN_ID"].ToString());
                decimal wgt = decimal.Parse(pwDt.Rows[0]["N_WGT"].ToString());
                var cogdownModel = dal.GetModel(dr["C_TRC_ROLL_MAIN_ID"].ToString());

                if (num != dal.UpdateSlabMoveType(outDt, "E", "C", "Y", slabwhCode, shift, group, userID))
                {
                    TransactionHelper.RollBack();
                    return "0";
                }

                if (dal.ElimOut(dr["C_TRC_ROLL_MAIN_ID"].ToString(), num, num * wgt, remark) == 0)
                {
                    TransactionHelper.RollBack();
                    return "0";
                }

                if (planDal.BackOutGroupWgt(cogdownModel.C_PLAN_ID, num * wgt) == 0)
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

                    if (dal.DelCogMainItem(cogdownModel.C_ID, outDt.Rows[i]["C_SLAB_MAIN_ID"].ToString()) == 0)
                    {
                        TransactionHelper.RollBack();
                        return "0";
                    }

                    Mod_TRC_WARM_FURNACE_LOG logModel = new Mod_TRC_WARM_FURNACE_LOG();
                    logModel.C_TRC_ROLL_MAIN_ID = dr["C_TRC_ROLL_MAIN_ID"].ToString();
                    logModel.N_QUA_EXIT = num;
                    logModel.N_WGT_EXIT = num * wgt;
                    logModel.C_BATCH_NO = dr["C_BATCH_NO"] == null ? "" : dr["C_BATCH_NO"].ToString();
                    logModel.C_STA_ID = staID;
                    logModel.N_ROLL_STATE = 3;
                    logModel.C_EMP_ID = UserInfo.userID;
                    logModel.C_SHIFT = dr["C_SHIFT"] == null ? "" : dr["C_SHIFT"].ToString();
                    logModel.C_GROUP = dr["C_GROUP"] == null ? "" : dr["C_GROUP"].ToString();
                    logModel.C_REMARK = remark;
                    logModel.C_SLAB_MAIN_ID = outDt.Rows[i]["C_SLAB_MAIN_ID"].ToString();
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
        /// 开坯实绩处理
        /// </summary>
        /// <param name="model">开坯实绩主表</param>
        /// <param name="planNum">计划支数</param>
        /// <param name="cogDown">开坯支数</param>
        /// <param name="scrapNum">报废支数</param>
        /// <param name="pw">单重</param>
        /// <param name="wgt">开坯单重</param>
        /// <param name="path">路径</param>
        /// <returns></returns>
        public string CogDownFactHandler(Mod_TRC_COGDOWN_PRODUCT model, int planNum, int cogDown, int scrapNum, decimal pw, decimal wgt, string path)
        {
            string result = "1";

            try
            {
                TransactionHelper.BeginTransaction();

                string slabID = "";
                DataTable slabDt = new DataTable();
                if (dal.UpdateExpendFact(model.C_COGDOWN_ID, planNum, out slabID, out slabDt) != planNum)
                {
                    TransactionHelper.RollBack();
                    return "0";
                }

                int index = 0;

                for (int i = 0; i < (cogDown + scrapNum); i++)
                {
                    //添加不合格品（当前索引大于合格品支数）
                    if (i >= cogDown)
                    {
                        model.C_MAT_TYPE = "不合格品";
                        model.C_STA_ID = slabDt.Rows[0]["C_STA_ID"] == null ? "" : slabDt.Rows[0]["C_STA_ID"].ToString();
                        model.C_STA_CODE = slabDt.Rows[0]["C_STA_CODE"] == null ? "" : slabDt.Rows[0]["C_STA_CODE"].ToString();
                        model.C_STA_DESC = slabDt.Rows[0]["C_STA_DESC"] == null ? "" : slabDt.Rows[0]["C_STA_DESC"].ToString();
                        if (!productDal.Add(model))
                        {
                            TransactionHelper.RollBack();
                            return "0";
                        }
                    }
                    else
                    {
                        //赋值 cc
                        model.C_STA_ID = slabDt.Rows[0]["C_STA_ID"] == null ? "" : slabDt.Rows[0]["C_STA_ID"].ToString();
                        model.C_STA_CODE = slabDt.Rows[0]["C_STA_CODE"] == null ? "" : slabDt.Rows[0]["C_STA_CODE"].ToString();
                        model.C_STA_DESC = slabDt.Rows[0]["C_STA_DESC"] == null ? "" : slabDt.Rows[0]["C_STA_DESC"].ToString();
                        model.C_MAT_TYPE = "合格品";
                        if (!productDal.Add(model))
                        {
                            TransactionHelper.RollBack();
                            return "0";
                        }
                    }

                    //被开坯大钢坯索引
                    if (i / 2 == 0)
                        index++;
                }


                if (dal.UpdateCogDownFact(model.C_COGDOWN_ID, planNum, wgt, model.C_REMARK) == 0)
                {
                    TransactionHelper.RollBack();
                    return "0";
                }

                //if (dal.UpdatePlanSms(model.C_STOVE, planNum, wgt, model.D_START_DATE, model.D_END_DATE, 1) == 0)
                //{
                //    TransactionHelper.RollBack();
                //    return "0";
                //}

                Mod_TRC_COGDOWN_PRODUCT_LOG log = new Mod_TRC_COGDOWN_PRODUCT_LOG();
                log.C_BATCH_NO = model.C_BATCH_NO;
                log.N_QUA = cogDown;
                log.N_WGT = log.N_QUA * wgt;
                log.C_TRC_COGDOWN_MAIN_ID = model.C_COGDOWN_ID;
                log.D_MOD_DT = DateTime.Now;
                log.C_EMP_ID = model.C_WE_EMP_ID;
                log.C_STA_ID = model.C_STA_ID;
                log.N_TYPE = 1;
                log.C_SHIFT = model.C_COGDOWN_SHIFT;
                log.C_GROUP = model.C_COGDOWN_GROUP;
                log.C_REMARK = model.C_REMARK;
                log.C_SCRAP = scrapNum;
                log.C_SLAB_MAIN_ID = slabID;
                log.N_PLANQUA = planNum;
                log.N_PLANWGT = planNum * pw;
                if (!productLogDal.Add(log))
                {
                    TransactionHelper.RollBack();
                    return "0";
                }

                if (warmFurnaceDal.UpdateWarmFurnaceRolleStateTran(model.C_COGDOWN_ID, 3, 2) == 0)
                {
                    TransactionHelper.RollBack();
                    return "0";
                }

                if (dal.UpdateCogDownTran(model.C_COGDOWN_ID, 0) == 0)
                {
                    TransactionHelper.RollBack();
                    return "0";
                }
                #endregion

                #region 上传NC

                #endregion


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
        /// 开坯实绩撤回处理
        /// </summary>
        /// <param name="id">开坯组批主表id</param>
        /// <param name="remark">备注</param>
        /// <returns></returns>
        public string CogDownBackFactHandler(string id, string remark)
        {
            string result = "1";
            DataTable dt = dal.GetCogDownInfo(id).Tables[0];

            //完工支数
            decimal wgQua = decimal.Parse(dt.Rows[0]["N_ACCOM_TOTAL"].ToString());
            //完工重量
            decimal wgWgt = decimal.Parse(dt.Rows[0]["N_ACCOM_WGT_TOTAL"].ToString());
            //计划单重
            decimal pw = decimal.Parse(dt.Rows[0]["N_PW"].ToString());

            object obj = dal.GetCogDownPlanNum(id);
            int num = 0;//计划支数
            if (obj != null && obj.ToString() != "")
                num = Convert.ToInt32(obj.ToString());

            TransactionHelper.BeginTransaction();
            string slabID = "";
            if (dal.BackExpendFact(id, int.Parse(wgQua.ToString()), out slabID) != int.Parse(wgQua.ToString()))
            {
                TransactionHelper.RollBack();
                return "0";
            }

            if (dal.BackCogDownFact(id, int.Parse(wgQua.ToString()), wgWgt, remark) == 0)
            {
                TransactionHelper.RollBack();
                return "0";
            }

            if (dal.DeleteCogDownFact(id) != num)
            {
                TransactionHelper.RollBack();
                return "0";
            }

            if (warmFurnaceDal.UpdateWarmFurnaceRolleStateTran(id, 2, 3) == 0)
            {
                TransactionHelper.RollBack();
                return "0";
            }

            if (dal.UpdateCogDownTran(id, 1) == 0)
            {
                TransactionHelper.RollBack();
                return "0";
            }

            //if (dal.UpdatePlanSms(dt.Rows[0]["C_STOVE"].ToString(), 1, wgWgt, DateTime.Now, DateTime.Now, 2) == 0)
            //{
            //    TransactionHelper.RollBack();
            //    return "0";
            //}

            var model = productDal.GetModel(id);
            Mod_TRC_COGDOWN_PRODUCT_LOG log = new Mod_TRC_COGDOWN_PRODUCT_LOG();
            log.C_BATCH_NO = model.C_BATCH_NO;
            log.N_QUA = wgQua;
            log.N_WGT = wgWgt;
            log.C_TRC_COGDOWN_MAIN_ID = id;
            log.D_MOD_DT = DateTime.Now;
            log.C_EMP_ID = model.C_WE_EMP_ID;
            log.C_STA_ID = model.C_STA_ID;
            log.N_TYPE = 2;
            log.C_SHIFT = model.C_COGDOWN_SHIFT;
            log.C_GROUP = model.C_COGDOWN_GROUP;
            log.C_REMARK = model.C_REMARK;
            log.C_SLAB_MAIN_ID = slabID;
            log.N_PLANQUA = num;
            log.N_PLANWGT = num * pw;
            if (!productLogDal.Add(log))
            {
                TransactionHelper.RollBack();
                return "0";
            }


            TransactionHelper.Commit();
            return result;
        }

        /// <summary>
        /// 获取开坯实绩
        /// </summary>
        /// <returns></returns>
        public DataSet GetCogDownFact(int status, string staID)
        {
            return dal.GetCogDownFactSum(status, staID);
        }

        /// <summary>
        /// 获取开坯实绩
        /// </summary>
        /// <returns></returns>
        public DataSet GetCogDownFact(int status, string staID, int type)
        {
            return dal.GetCogDownFactSum(status, staID, type);
        }

        /// <summary>
        /// 获取开坯实绩合计
        /// </summary>
        /// <param name="status">启用状态</param>
        /// <param name="strTimeStart">开始时间</param>
        /// <param name="strTimeEnd">结束时间</param>
        /// <param name="staID">组批主键</param>
        /// <param name="stove">炉号</param>
        /// <param name="stlgrd">钢种</param>
        /// <param name="spec">规格</param>
        /// <returns></returns>
        public DataSet GetCogDownFact_Stove(int status, string staID, string strTimeStart, string strTimeEnd, string stove, string stlgrd, string spec)
        {
            return dal.GetCogDownFact_Stove(status, staID, strTimeStart, strTimeEnd, stove, stlgrd, spec);
        }
        /// <summary>
        /// 获取开坯实绩合计
        /// </summary>
        /// <returns></returns>
        public DataSet GetCogDownFact(int status, string staID, string sqlWhere)
        {
            return dal.GetCogDownFactSum(status, staID, sqlWhere);
        }

        /// <summary>
        /// 开坯分库处理
        /// </summary>
        /// <param name="dr"></param>
        /// <param name="num"></param>
        /// <param name="slabwhCode"></param>
        /// <param name="shift"></param>
        /// <param name="group"></param>
        /// <param name="staID"></param>
        /// <returns></returns>
        public string CogDownFkHandler(DataRow dr, int num, string slabwhCode, string shift, string group, string staID, DateTime start, DateTime end, string empID, DateTime ccmDate
            , string area, string kw, string floor, string remark)
        {
            string result = "1";
            string cogID = dr["C_COGDOWN_ID"].ToString();
            DataTable dt = dal.GetCogDownData(cogID, staID, num).Tables[0];
            if (dt == null || dt.Rows.Count == 0)
                return "0";
            try
            {
                TransactionHelper.BeginTransaction();
                foreach (DataRow item in dt.Rows)
                {
                    Mod_TSC_SLAB_MAIN model = new Mod_TSC_SLAB_MAIN();
                    model.C_PLAN_ID = item["C_PLAN_ID"].ToString();
                    model.C_BATCH_NO = item["C_BATCH_NO"].ToString();
                    model.C_STOVE = item["C_STOVE"].ToString();
                    model.C_STL_GRD = item["C_STL_GRD"].ToString();
                    model.C_MAT_CODE = item["C_MAT_CODE"].ToString();
                    model.C_MAT_NAME = item["C_MAT_NAME"].ToString();
                    model.C_SPEC = item["C_SPEC"].ToString();
                    model.N_LEN = decimal.Parse(item["N_LEN"].ToString());
                    model.N_QUA = 1;
                    model.N_WGT = decimal.Parse(item["N_WGT"].ToString());
                    model.C_STD_CODE = item["C_STD_CODE"].ToString();
                    model.C_STA_ID = item["C_STA_ID"].ToString();
                    model.C_STA_CODE = item["C_STA_CODE"].ToString();
                    model.C_STA_DESC = item["C_STA_DESC"].ToString();
                    model.C_MOVE_TYPE = "M";
                    model.C_MAT_TYPE = item["C_MAT_TYPE"].ToString();
                    model.C_SLABWH_CODE = slabwhCode;
                    model.C_SLABWH_AREA_CODE = area;
                    model.C_SLABWH_LOC_CODE = kw;
                    model.C_SLABWH_TIER_CODE = floor;
                    model.D_CCM_DATE = ccmDate;
                    model.C_STOCK_STATE = "F";
                    model.D_WE_DATE = start;
                    model.C_WE_SHIFT = shift;
                    model.C_WE_GROUP = group;
                    model.C_WE_EMP_ID = empID;
                    model.C_REMARK = remark;
                    model.C_QKP_STATE = "N";
                    model.C_ZYX1 = item["C_ZYX1"].ToString();
                    model.C_ZYX2 = item["C_ZYX2"].ToString();
                    model.C_JUDGE_LEV_ZH = model.C_MAT_TYPE;
                    model.C_IS_QR = "Y";
                    model.C_IS_PD = "Y";
                    model.C_IS_TB = "Y";

                    if (!slabMainDal.AddTran(model))
                    {
                        TransactionHelper.RollBack();
                        return "0";
                    }
                }
                if (dal.UpCogDownStatus(cogID, num, shift, group, start, end, empID, slabwhCode, remark) != num)
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
            return result;
        }

        /// <summary>
        /// 生成开坯组批ID
        /// </summary>
        /// <returns></returns>
        public string CreateID()
        {
            return dal.CreateID();
        }

        /// <summary>
        /// KP完工报告NC
        /// </summary>
        /// <param name="cogID"></param>
        /// <param name="slabwhCode"></param>
        /// <returns></returns>
        public string KpSyncNc(string cogID, string slabwhCode, string staID, string path, string shift, string group)
        {
            string result = "1";
            string errorBatchNo = "";
            int status = 2;
            try
            {
                #region NC发送A1 A2 A3 A4 46

                NcRollA2 ncA2 = new NcRollA2();
                NcRollA3 ncA3 = new NcRollA3();
                NcRollA4 ncA4 = new NcRollA4();
                NcRollA1 ncA1 = new NcRollA1();
                var main = dal.GetModel(cogID);
                var plan = planDal.GetModel(main.C_PLAN_ID);
                var a1Sta = bll_TB_STA.GetModel(plan.C_STA_ID);
                ncA1.bmid = "1001NC1000000000038P";
                ncA1.jhrq = DateTime.Parse(plan.D_P_START_TIME == null ? DateTime.Now.ToString() : plan.D_P_START_TIME.ToString());
                ncA1.jhxxsl = plan.N_WGT.ToString();
                var matrl = bll_TB_MATRL_MAIN.GetModel(plan.C_MAT_CODE);
                ncA1.jhyid = matrl.C_PLANEMP;
                ncA1.jldwid = matrl.C_PK_MEASDOC;
                ncA1.pk_produce = matrl.C_PK_PRODUCE;
                ncA1.scbmid = a1Sta.C_SSBMID;
                ncA1.shrid = RV.UI.UserInfo.userID;
                ncA1.shrq = DateTime.Parse(plan.D_P_START_TIME == null ? DateTime.Now.ToString() : plan.D_P_START_TIME.ToString());
                ncA1.slrq = DateTime.Parse(plan.D_NEED_DT == null ? DateTime.Now.ToString() : plan.D_NEED_DT.ToString());
                ncA1.wlbmid = matrl.C_PK_INVBASDOC;
                ncA1.xdrq = DateTime.Parse(plan.D_P_START_TIME == null ? DateTime.Now.ToString() : plan.D_P_START_TIME.ToString());
                ncA1.xqrq = DateTime.Parse(plan.D_DELIVERY_DT == null ? DateTime.Now.ToString() : plan.D_DELIVERY_DT.ToString());
                ncA1.xqsl = plan.N_WGT.ToString();
                ncA1.zdrq = DateTime.Now;
                ncA1.zyx1 = plan.C_FREE1;
                ncA1.zyx2 = plan.C_FREE2;
                ncA1.zyx3 = plan.C_PACK;
                ncA1.zyx5 = plan.C_ID;
                ncA1.jhfaid = matrl.C_PK_PSID;
                string a1Name = plan.C_ID + "_A1.xml";
                var arrReault = bll_Interface_NC_Roll_A1.SendXml_ROLL_A1("", a1Name, ncA1, path);
                if (arrReault[0] != "1")
                {
                    dal.UpdateIfStatus(2, main.C_BATCH_NO, arrReault[1]);
                }

                var matrl2 = bll_TB_MATRL_MAIN.GetModel(main.C_MAT_SLAB_CODE);
                var a2Sta = bll_TB_STA.GetModel(main.C_STA_ID);
                var product = productDal.GetModel(cogID);
                errorBatchNo = product.C_BATCH_NO;
                ncA2.wlbmid = matrl.C_PK_INVBASDOC;
                ncA2.pk_produce = matrl.C_PK_PRODUCE;
                ncA2.invcode = matrl.C_ID;
                ncA2.pch = main.C_BATCH_NO;
                ncA2.scbmid = a2Sta.C_SSBMID;
                ncA2.gzzxid = a2Sta.C_ERP_PK;
                ncA2.bcid = product.C_COGDOWN_SHIFT;
                ncA2.bzid = product.C_COGDOWN_GROUP;
                ncA2.jhkgrq = DateTime.Parse(product.D_START_DATE == null ? DateTime.Now.ToString() : product.D_START_DATE.ToString());
                ncA2.jhwgrq = DateTime.Parse(product.D_END_DATE == null ? DateTime.Now.ToString() : product.D_END_DATE.ToString());
                ncA2.jhkssj = DateTime.Parse(product.D_START_DATE == null ? DateTime.Now.ToString() : product.D_START_DATE.ToString());
                ncA2.jhjssj = DateTime.Parse(product.D_END_DATE == null ? DateTime.Now.ToString() : product.D_END_DATE.ToString());
                ncA2.sjkgrq = DateTime.Parse(product.D_START_DATE == null ? DateTime.Now.ToString() : product.D_START_DATE.ToString());
                ncA2.sjwgrq = DateTime.Parse(product.D_END_DATE == null ? DateTime.Now.ToString() : product.D_END_DATE.ToString());
                ncA2.sjkssj = DateTime.Parse(product.D_START_DATE == null ? DateTime.Now.ToString() : product.D_START_DATE.ToString());
                ncA2.sjjssj = DateTime.Parse(product.D_END_DATE == null ? DateTime.Now.ToString() : product.D_END_DATE.ToString());
                ncA2.jhwgsl = main.N_WGT_TOTAL_VIRTUAL.ToString();
                ncA2.fjhsl = main.N_QUA_TOTAL_VIRTUAL.ToString();
                ncA2.jldwid = matrl.C_PK_MEASDOC;
                ncA2.fjlid = matrl.C_FJLDW;
                ncA2.sjwgsl = main.N_ACCOM_WGT_TOTAL.ToString();
                ncA2.freeitemvalue1 = plan.C_FREE1;
                ncA2.freeitemvalue2 = plan.C_FREE2;
                ncA2.freeitemvalue3 = plan.C_PACK;
                ncA2.zdrid = RV.UI.UserInfo.userAccount;
                ncA2.freeitemvalue5 = plan.C_ID;
                string a2Name = Guid.NewGuid() + "_A2.xml";
                if (dal_TRC_ROLL_WGD.IsA2Repeat(main.C_BATCH_NO, "") > 0)
                {

                }
                var resultA2 = bll_Interface_NC_Roll_A2.SendXml_ROLL_A2("", a2Name, ncA2, path);
                if (resultA2[0] != "1")
                {
                    dal.UpdateIfStatus(2, product.C_BATCH_NO, resultA2[1]);

                }

                status = 3;
                ncA3.hpch = main.C_BATCH_NO;
                ncA3.hzdrid = RV.UI.UserInfo.userAccount;
                ncA3.hwlbmid = matrl.C_PK_INVBASDOC;
                ncA3.hjldwid = matrl.C_PK_MEASDOC;
                ncA3.hzdrq = DateTime.Parse(product.D_QR_DATE == null ? DateTime.Now.ToString() : product.D_QR_DATE.ToString());
                ncA3.hfreeitemvalue1 = plan.C_FREE1;
                ncA3.hfreeitemvalue2 = plan.C_FREE2;
                ncA3.hfreeitemvalue3 = plan.C_PACK;

                DataTable a3Dt = warmFurnaceDal.GetSlabMainInfoKp(main.C_ID);
                //DataTable a3DtZyx = bll_TB_STD_CONFIG.GetZYX(a3Dt.Rows[0]["C_STL_GRD"].ToString(), a3Dt.Rows[0]["C_STD_CODE"].ToString()).Tables[0];
                var m = bll_TB_MATRL_MAIN.GetModel(a3Dt.Rows[0]["C_MAT_CODE"].ToString());
                ncA3.kgyid = RV.UI.UserInfo.userAccount;
                ncA3.ckckid = bll_TPB_SLABWH.GetList_id(slabwhCode);
                ncA3.wlbmid = matrl2.C_PK_INVBASDOC;
                ncA3.jldwid = matrl2.C_PK_MEASDOC;
                ncA3.fjldwid = matrl2.C_FJLDW;
                ncA3.ljcksl = a3Dt.Rows[0]["N_WGT"].ToString();
                ncA3.fljcksl = a3Dt.Rows[0]["N_QUA"].ToString();
                ncA3.pch = a3Dt.Rows[0]["C_STOVE"].ToString();
                ncA3.gzzxid = a2Sta.C_ERP_PK;
                ncA3.freeitemvalue1 = a3Dt.Rows[0]["C_ZYX1"].ToString();
                ncA3.freeitemvalue2 = a3Dt.Rows[0]["C_ZYX2"].ToString();
                object objOutTime = warmFurnaceDal.GetOutTime(main.C_ID);
                ncA3.flrq = product.D_QR_DATE == null ? DateTime.Now.ToString() : product.D_QR_DATE.Value.ToString("yyyy-MM-dd");
                string a3Name = Guid.NewGuid() + "_A3.xml";
                if (dal_TRC_ROLL_WGD.IsA3Repeat(main.C_BATCH_NO, "") > 0)
                {
                    return "1";
                }
                var resultA3 = bll_Interface_NC_Roll_A3.SendXml_ROLL_A3("", a3Name, ncA3, path);
                if (resultA3[0] != "1")
                {
                    dal.UpdateIfStatus(3, product.C_BATCH_NO, resultA3[1]);

                }

                status = 4;
                var a4Fact = productDal.GetProductFact(product.C_BATCH_NO, 2, staID).Tables[0];
                var a4M = bll_TB_MATRL_MAIN.GetModel(product.C_MAT_CODE);
                var a4Sta = bll_TB_STA.GetModel(product.C_COG_STA_ID);
                ncA4.zdrid = RV.UI.UserInfo.userAccount;
                ncA4.rq = DateTime.Parse(product.D_START_DATE == null ? DateTime.Now.ToString() : product.D_START_DATE.ToString());
                ncA4.gzzxbmid = a4Sta.C_STA_ERPCODE;
                ncA4.scbmid = a4Sta.C_SSBMID;
                ncA4.pch = product.C_BATCH_NO;
                ncA4.wlbmid = a4M.C_PK_INVBASDOC;
                ncA4.jldwid = a4M.C_PK_MEASDOC;
                ncA4.gzzxid = a4Sta.C_ERP_PK;
                ncA4.ccxh = product.C_BATCH_NO;
                ncA4.pk_produce = a4M.C_PK_PRODUCE;
                ncA4.ksrq = DateTime.Parse(product.D_START_DATE == null ? DateTime.Now.ToString() : product.D_START_DATE.ToString());
                ncA4.jsrq = DateTime.Parse(product.D_END_DATE == null ? DateTime.Now.ToString() : product.D_END_DATE.ToString());
                ncA4.hgsl = a4Fact.Rows[0]["N_WGT"].ToString();
                ncA4.fhgsl = a4Fact.Rows[0]["N_QUA"].ToString();
                ncA4.sflfcp = "N";
                ncA4.sffsgp = "N";
                //DataTable a4DtZyx = bll_TB_STD_CONFIG.GetZYX(product.C_STL_GRD, product.C_STD_CODE).Tables[0];
                ncA4.freeitemvalue1 = plan.C_FREE1;
                ncA4.freeitemvalue2 = plan.C_FREE2;
                ncA4.freeitemvalue3 = plan.C_PACK;
                string a4Name = Guid.NewGuid() + "_A4.xml";
                if (dal_TRC_ROLL_WGD.IsA4Repeat(main.C_BATCH_NO, "") > 0)
                {

                }
                var resultA4 = bll_Interface_NC_Roll_A4.SendXml_ROLL_A4("", a4Name, ncA4, path);
                if (resultA4[0] != "1")
                {
                    dal.UpdateIfStatus(4, product.C_BATCH_NO, resultA4[1]);

                }

                status = 5;
                List<NcRoll46> nc46s = new List<NcRoll46>();
                var a46Fact = productDal.GetProductFactGroup(product.C_BATCH_NO, 2, staID).Tables[0];
                decimal wgt = 0;
                if (a46Fact != null && a46Fact.Rows.Count > 0)
                {
                    for (int i = 0; i < a46Fact.Rows.Count; i++)
                    {
                        NcRoll46 nc46 = new NcRoll46();
                        var a46M = bll_TB_MATRL_MAIN.GetModel(a46Fact.Rows[i]["C_MAT_CODE"].ToString());
                        nc46.cwarehouseid = bll_TPB_SLABWH.GetList_id(product.C_SLABWH_CODE).ToString();
                        nc46.taccounttime = DateTime.Parse(product.D_QR_DATE == null ? DateTime.Now.ToString() : product.D_QR_DATE.ToString());
                        nc46.coperatorid = dal_TS_USER.GetAccount(product.C_MOVE_ID).ToString(); //factDt.Rows[i]["C_RKRY"].ToString();
                        if (a46Fact.Rows[i]["C_MAT_TYPE"].ToString() == "合格品")
                            nc46.ccheckstate_bid = "1001NC100000000052Z3";
                        else
                            nc46.ccheckstate_bid = "1001NC100000000052Z6";
                        nc46.cworkcenterid = bll_TB_STA.Get_NC_ID(product.C_COG_STA_ID);
                        nc46.dbizdate = DateTime.Parse(product.D_QR_DATE == null ? DateTime.Now.ToString() : product.D_QR_DATE.ToString());
                        nc46.vbatchcode = product.C_BATCH_NO;
                        nc46.cinvbasid = a46M.C_PK_INVBASDOC;
                        nc46.pk_produce = a46M.C_PK_PRODUCE;
                        nc46.ninnum = a46Fact.Rows[i]["N_WGT"].ToString();
                        nc46.ninassistnum = a46Fact.Rows[i]["N_QUA"].ToString();
                        nc46.castunitid = matrl.C_FJLDW;
                        nc46.vfree1 = plan.C_FREE1;
                        nc46.vfree2 = plan.C_FREE2;
                        nc46.vfree3 = plan.C_PACK;
                        nc46s.Add(nc46);
                        wgt += decimal.Parse(a46Fact.Rows[i]["N_WGT"].ToString());
                    }
                    string a46Name = Guid.NewGuid() + "_A46.xml";

                    var resultA46 = bll_Interface_NC_Roll_46.SendXml_ROLL_46("", a46Name, nc46s, path);
                    if (resultA46[0] != "1")
                    {
                        dal.UpdateIfStatus(5, product.C_BATCH_NO, resultA46[1]);

                    }


                    if (dal_TRC_ROLL_WGD.Is46Repeat(main.C_BATCH_NO, "") > 0)
                    {
                        dal.UpdatePlanWgt(plan.C_ID, wgt);

                        if (dal.UpdateProductStatus(3, product.C_BATCH_NO) > 0)
                            return result = "0";
                    }

                }
                #endregion
            }
            catch (Exception ex)
            {
                dal.UpdateIfStatus(status, errorBatchNo, ex.Message);
                return "1";
            }
            return result;
        }

        /// <summary>
        /// KP完工报告NC
        /// </summary>
        /// <param name="cogID"></param>
        /// <param name="slabwhCode"></param>
        /// <returns></returns>
        public string KpSyncNcA2(string cogID, string slabwhCode, string staID, string path, string shift, string group)
        {
            string result = "1";
            string errorBatchNo = "";
            int status = 2;
            try
            {
                #region NC发送 A2 A3 A4 46
                NcRollA2 ncA2 = new NcRollA2();
                NcRollA3 ncA3 = new NcRollA3();
                NcRollA4 ncA4 = new NcRollA4();
                NcRollA1 ncA1 = new NcRollA1();
                var main = dal.GetModel(cogID);
                var plan = planDal.GetModel(main.C_PLAN_ID);
                var a1Sta = bll_TB_STA.GetModel(plan.C_STA_ID);
                ncA1.bmid = "1001NC1000000000038P";
                ncA1.jhrq = DateTime.Parse(plan.D_P_START_TIME == null ? DateTime.Now.ToString() : plan.D_P_START_TIME.ToString());
                ncA1.jhxxsl = plan.N_WGT.ToString();
                var matrl = bll_TB_MATRL_MAIN.GetModel(plan.C_MAT_CODE);
                ncA1.jhyid = matrl.C_PLANEMP;
                ncA1.jldwid = matrl.C_PK_MEASDOC;
                ncA1.pk_produce = matrl.C_PK_PRODUCE;
                ncA1.scbmid = a1Sta.C_SSBMID;
                ncA1.shrid = RV.UI.UserInfo.userID;
                ncA1.shrq = DateTime.Parse(plan.D_P_START_TIME == null ? DateTime.Now.ToString() : plan.D_P_START_TIME.ToString());
                ncA1.slrq = DateTime.Parse(plan.D_NEED_DT == null ? DateTime.Now.ToString() : plan.D_NEED_DT.ToString());
                ncA1.wlbmid = matrl.C_PK_INVBASDOC;
                ncA1.xdrq = DateTime.Parse(plan.D_P_START_TIME == null ? DateTime.Now.ToString() : plan.D_P_START_TIME.ToString());
                ncA1.xqrq = DateTime.Parse(plan.D_DELIVERY_DT == null ? DateTime.Now.ToString() : plan.D_DELIVERY_DT.ToString());
                ncA1.xqsl = plan.N_WGT.ToString();
                ncA1.zdrq = DateTime.Now;
                ncA1.zyx1 = plan.C_FREE1;
                ncA1.zyx2 = plan.C_FREE2;
                ncA1.zyx3 = plan.C_PACK;
                ncA1.zyx5 = plan.C_ID;
                ncA1.jhfaid = matrl.C_PK_PSID;
                string a1Name = plan.C_ID + "_A1.xml";
                var arrReault = bll_Interface_NC_Roll_A1.SendXml_ROLL_A1("", a1Name, ncA1, path);
                if (arrReault[0] != "1")
                {
                    dal.UpdateIfStatus(2, main.C_BATCH_NO, arrReault[1]);
                }

                var a2Sta = bll_TB_STA.GetModel(main.C_STA_ID);
                var matrl2 = bll_TB_MATRL_MAIN.GetModel(main.C_MAT_SLAB_CODE);
                var product = productDal.GetModel(cogID);
                errorBatchNo = product.C_BATCH_NO;
                ncA2.wlbmid = matrl.C_PK_INVBASDOC;
                ncA2.pk_produce = matrl.C_PK_PRODUCE;
                ncA2.invcode = matrl.C_ID;
                ncA2.pch = main.C_BATCH_NO;
                ncA2.scbmid = a2Sta.C_SSBMID;
                ncA2.gzzxid = a2Sta.C_ERP_PK;
                ncA2.bcid = product.C_COGDOWN_SHIFT;
                ncA2.bzid = product.C_COGDOWN_GROUP;
                ncA2.jhkgrq = DateTime.Parse(product.D_START_DATE == null ? DateTime.Now.ToString() : product.D_START_DATE.ToString());
                ncA2.jhwgrq = DateTime.Parse(product.D_END_DATE == null ? DateTime.Now.ToString() : product.D_END_DATE.ToString());
                ncA2.jhkssj = DateTime.Parse(product.D_START_DATE == null ? DateTime.Now.ToString() : product.D_START_DATE.ToString());
                ncA2.jhjssj = DateTime.Parse(product.D_END_DATE == null ? DateTime.Now.ToString() : product.D_END_DATE.ToString());
                ncA2.sjkgrq = DateTime.Parse(product.D_START_DATE == null ? DateTime.Now.ToString() : product.D_START_DATE.ToString());
                ncA2.sjwgrq = DateTime.Parse(product.D_END_DATE == null ? DateTime.Now.ToString() : product.D_END_DATE.ToString());
                ncA2.sjkssj = DateTime.Parse(product.D_START_DATE == null ? DateTime.Now.ToString() : product.D_START_DATE.ToString());
                ncA2.sjjssj = DateTime.Parse(product.D_END_DATE == null ? DateTime.Now.ToString() : product.D_END_DATE.ToString());
                ncA2.jhwgsl = main.N_WGT_TOTAL_VIRTUAL.ToString();
                ncA2.fjhsl = main.N_QUA_TOTAL_VIRTUAL.ToString();
                ncA2.jldwid = matrl.C_PK_MEASDOC;
                ncA2.fjlid = matrl.C_FJLDW;
                ncA2.sjwgsl = main.N_ACCOM_WGT_TOTAL.ToString();
                ncA2.freeitemvalue1 = plan.C_FREE1;
                ncA2.freeitemvalue2 = plan.C_FREE2;
                ncA2.freeitemvalue3 = plan.C_PACK;
                ncA2.zdrid = RV.UI.UserInfo.userAccount;
                ncA2.freeitemvalue5 = plan.C_ID;
                string a2Name = Guid.NewGuid() + "_A2.xml";
                if (dal_TRC_ROLL_WGD.IsA2Repeat(main.C_BATCH_NO, "") > 0)
                {
                    return "1";
                }
                var resultA2 = bll_Interface_NC_Roll_A2.SendXml_ROLL_A2("", a2Name, ncA2, path);
                if (resultA2[0] != "1")
                {
                    dal.UpdateIfStatus(2, product.C_BATCH_NO, resultA2[1]);
                    return "1";
                }

                status = 3;
                ncA3.hpch = main.C_BATCH_NO;
                ncA3.hzdrid = RV.UI.UserInfo.userAccount;
                ncA3.hwlbmid = matrl.C_PK_INVBASDOC;
                ncA3.hjldwid = matrl.C_PK_MEASDOC;
                ncA3.hzdrq = DateTime.Parse(product.D_QR_DATE == null ? DateTime.Now.ToString() : product.D_QR_DATE.ToString());
                ncA3.hfreeitemvalue1 = plan.C_FREE1;
                ncA3.hfreeitemvalue2 = plan.C_FREE2;
                ncA3.hfreeitemvalue3 = plan.C_PACK;

                DataTable a3Dt = warmFurnaceDal.GetSlabMainInfoKp(main.C_ID);
                //DataTable a3DtZyx = bll_TB_STD_CONFIG.GetZYX(a3Dt.Rows[0]["C_STL_GRD"].ToString(), a3Dt.Rows[0]["C_STD_CODE"].ToString()).Tables[0];
                var m = bll_TB_MATRL_MAIN.GetModel(a3Dt.Rows[0]["C_MAT_CODE"].ToString());
                ncA3.kgyid = RV.UI.UserInfo.userAccount;
                ncA3.ckckid = bll_TPB_SLABWH.GetList_id(slabwhCode);
                ncA3.wlbmid = matrl2.C_PK_INVBASDOC;
                ncA3.jldwid = matrl2.C_PK_MEASDOC;
                ncA3.fjldwid = matrl2.C_FJLDW;
                ncA3.ljcksl = a3Dt.Rows[0]["N_WGT"].ToString();
                ncA3.fljcksl = a3Dt.Rows[0]["N_QUA"].ToString();
                ncA3.pch = a3Dt.Rows[0]["C_STOVE"].ToString();
                ncA3.gzzxid = a2Sta.C_ERP_PK;
                ncA3.freeitemvalue1 = a3Dt.Rows[0]["C_ZYX1"].ToString();
                ncA3.freeitemvalue2 = a3Dt.Rows[0]["C_ZYX2"].ToString();
                object objOutTime = warmFurnaceDal.GetOutTime(main.C_ID);
                ncA3.flrq = product.D_QR_DATE == null ? DateTime.Now.ToString() : product.D_QR_DATE.Value.ToString("yyyy-MM-dd");
                string a3Name = Guid.NewGuid() + "_A3.xml";
                if (dal_TRC_ROLL_WGD.IsA3Repeat(main.C_BATCH_NO, "") > 0)
                {
                    return "1";
                }
                var resultA3 = bll_Interface_NC_Roll_A3.SendXml_ROLL_A3("", a3Name, ncA3, path);
                if (resultA3[0] != "1")
                {
                    dal.UpdateIfStatus(3, product.C_BATCH_NO, resultA3[1]);
                    return "1";
                }

                status = 4;
                var a4Fact = productDal.GetProductFact(product.C_BATCH_NO, 2, staID).Tables[0];
                var a4M = bll_TB_MATRL_MAIN.GetModel(product.C_MAT_CODE);
                var a4Sta = bll_TB_STA.GetModel(product.C_COG_STA_ID);
                ncA4.zdrid = RV.UI.UserInfo.userAccount;
                ncA4.rq = DateTime.Parse(product.D_START_DATE == null ? DateTime.Now.ToString() : product.D_START_DATE.ToString());
                ncA4.gzzxbmid = a4Sta.C_STA_ERPCODE;
                ncA4.scbmid = a4Sta.C_SSBMID;
                ncA4.pch = product.C_BATCH_NO;
                ncA4.wlbmid = a4M.C_PK_INVBASDOC;
                ncA4.jldwid = a4M.C_PK_MEASDOC;
                ncA4.gzzxid = a4Sta.C_ERP_PK;
                ncA4.ccxh = product.C_BATCH_NO;
                ncA4.pk_produce = a4M.C_PK_PRODUCE;
                ncA4.ksrq = DateTime.Parse(product.D_START_DATE == null ? DateTime.Now.ToString() : product.D_START_DATE.ToString());
                ncA4.jsrq = DateTime.Parse(product.D_END_DATE == null ? DateTime.Now.ToString() : product.D_END_DATE.ToString());
                ncA4.hgsl = a4Fact.Rows[0]["N_WGT"].ToString();
                ncA4.fhgsl = a4Fact.Rows[0]["N_QUA"].ToString();
                ncA4.sflfcp = "N";
                ncA4.sffsgp = "N";
                //DataTable a4DtZyx = bll_TB_STD_CONFIG.GetZYX(product.C_STL_GRD, product.C_STD_CODE).Tables[0];
                ncA4.freeitemvalue1 = plan.C_FREE1;
                ncA4.freeitemvalue2 = plan.C_FREE2;
                ncA4.freeitemvalue3 = plan.C_PACK;
                string a4Name = Guid.NewGuid() + "_A4.xml";
                if (dal_TRC_ROLL_WGD.IsA4Repeat(main.C_BATCH_NO, "") > 0)
                {
                    return "1";
                }
                var resultA4 = bll_Interface_NC_Roll_A4.SendXml_ROLL_A4("", a4Name, ncA4, path);
                if (resultA4[0] != "1")
                {
                    dal.UpdateIfStatus(4, product.C_BATCH_NO, resultA4[1]);
                    return "1";
                }

                status = 5;
                List<NcRoll46> nc46s = new List<NcRoll46>();
                var a46Fact = productDal.GetProductFactGroup(product.C_BATCH_NO, 2, staID).Tables[0];
                decimal wgt = 0;
                if (a46Fact != null && a46Fact.Rows.Count > 0)
                {
                    for (int i = 0; i < a46Fact.Rows.Count; i++)
                    {
                        NcRoll46 nc46 = new NcRoll46();
                        var a46M = bll_TB_MATRL_MAIN.GetModel(a46Fact.Rows[i]["C_MAT_CODE"].ToString());
                        nc46.cwarehouseid = bll_TPB_SLABWH.GetList_id(product.C_SLABWH_CODE).ToString();
                        nc46.taccounttime = DateTime.Parse(product.D_QR_DATE == null ? DateTime.Now.ToString() : product.D_QR_DATE.ToString());
                        nc46.coperatorid = dal_TS_USER.GetAccount(product.C_MOVE_ID).ToString(); //factDt.Rows[i]["C_RKRY"].ToString();
                        if (a46Fact.Rows[i]["C_MAT_TYPE"].ToString() == "合格品")
                            nc46.ccheckstate_bid = "1001NC100000000052Z3";
                        else
                            nc46.ccheckstate_bid = "1001NC100000000052Z6";
                        nc46.cworkcenterid = bll_TB_STA.Get_NC_ID(product.C_COG_STA_ID);
                        nc46.dbizdate = DateTime.Parse(product.D_QR_DATE == null ? DateTime.Now.ToString() : product.D_QR_DATE.ToString());
                        nc46.vbatchcode = product.C_BATCH_NO;
                        nc46.cinvbasid = a46M.C_PK_INVBASDOC;
                        nc46.pk_produce = a46M.C_PK_PRODUCE;
                        nc46.ninnum = a46Fact.Rows[i]["N_WGT"].ToString();
                        nc46.ninassistnum = a46Fact.Rows[i]["N_QUA"].ToString();
                        nc46.castunitid = matrl.C_FJLDW;
                        nc46.vfree1 = plan.C_FREE1;
                        nc46.vfree2 = plan.C_FREE2;
                        nc46.vfree3 = plan.C_PACK;
                        nc46s.Add(nc46);
                        wgt += decimal.Parse(a46Fact.Rows[i]["N_WGT"].ToString());
                    }
                    string a46Name = Guid.NewGuid() + "_A46.xml";
                    if (dal_TRC_ROLL_WGD.Is46Repeat(main.C_BATCH_NO, "") > 0)
                    {
                        return "1";
                    }
                    var resultA46 = bll_Interface_NC_Roll_46.SendXml_ROLL_46("", a46Name, nc46s, path);
                    if (resultA46[0] != "1")
                    {
                        dal.UpdateIfStatus(5, product.C_BATCH_NO, resultA46[1]);
                        return "1";
                    }


                    dal.UpdatePlanWgt(plan.C_ID, wgt);

                    if (dal.UpdateProductStatus(3, product.C_BATCH_NO) > 0)
                        return result = "0";

                }
                #endregion
            }
            catch (Exception ex)
            {
                dal.UpdateIfStatus(status, errorBatchNo, ex.Message);
                return "1";
            }
            return result;
        }

        /// <summary>
        /// KP完工报告NC
        /// </summary>
        /// <param name="cogID"></param>
        /// <param name="slabwhCode"></param>
        /// <returns></returns>
        public string KpSyncNcA3(string cogID, string slabwhCode, string staID, string path, string shift, string group)
        {
            string result = "1";
            string errorBatchNo = "";
            int status = 3;

            try
            {
                #region NC发送  A3 A4 46
                NcRollA2 ncA2 = new NcRollA2();
                NcRollA3 ncA3 = new NcRollA3();
                NcRollA4 ncA4 = new NcRollA4();

                var main = dal.GetModel(cogID);
                var a2Sta = bll_TB_STA.GetModel(main.C_STA_ID);
                var plan = planDal.GetModel(main.C_PLAN_ID);
                var matrl = bll_TB_MATRL_MAIN.GetModel(plan.C_MAT_CODE);
                var product = productDal.GetModel(cogID);
                errorBatchNo = product.C_BATCH_NO;

                ncA3.hpch = main.C_BATCH_NO;
                ncA3.hzdrid = RV.UI.UserInfo.userAccount;
                ncA3.hwlbmid = matrl.C_PK_INVBASDOC;
                ncA3.hjldwid = matrl.C_PK_MEASDOC;
                ncA3.hzdrq = DateTime.Parse(product.D_QR_DATE == null ? DateTime.Now.ToString() : product.D_QR_DATE.ToString());
                ncA3.hfreeitemvalue1 = plan.C_FREE1;
                ncA3.hfreeitemvalue2 = plan.C_FREE2;
                ncA3.hfreeitemvalue3 = plan.C_PACK;

                var matrl2 = bll_TB_MATRL_MAIN.GetModel(main.C_MAT_SLAB_CODE);
                DataTable a3Dt = warmFurnaceDal.GetSlabMainInfoKp(main.C_ID);
                //DataTable a3DtZyx = bll_TB_STD_CONFIG.GetZYX(a3Dt.Rows[0]["C_STL_GRD"].ToString(), a3Dt.Rows[0]["C_STD_CODE"].ToString()).Tables[0];
                var m = bll_TB_MATRL_MAIN.GetModel(a3Dt.Rows[0]["C_MAT_CODE"].ToString());
                ncA3.kgyid = RV.UI.UserInfo.userAccount;
                ncA3.ckckid = bll_TPB_SLABWH.GetList_id(slabwhCode);
                ncA3.wlbmid = matrl2.C_PK_INVBASDOC;
                ncA3.jldwid = matrl2.C_PK_MEASDOC;
                ncA3.fjldwid = matrl2.C_FJLDW;
                ncA3.ljcksl = a3Dt.Rows[0]["N_WGT"].ToString();
                ncA3.fljcksl = a3Dt.Rows[0]["N_QUA"].ToString();
                ncA3.pch = a3Dt.Rows[0]["C_STOVE"].ToString();
                ncA3.gzzxid = a2Sta.C_ERP_PK;
                ncA3.freeitemvalue1 = a3Dt.Rows[0]["C_ZYX1"].ToString();
                ncA3.freeitemvalue2 = a3Dt.Rows[0]["C_ZYX2"].ToString();
                object objOutTime = warmFurnaceDal.GetOutTime(main.C_ID);
                ncA3.flrq = product.D_QR_DATE == null ? DateTime.Now.ToString() : product.D_QR_DATE.Value.ToString("yyyy-MM-dd");
                string a3Name = Guid.NewGuid() + "_A3.xml";
                if (dal_TRC_ROLL_WGD.IsA3Repeat(main.C_BATCH_NO, "") > 0)
                {
                    return "1";
                }
                var resultA3 = bll_Interface_NC_Roll_A3.SendXml_ROLL_A3("", a3Name, ncA3, path);
                if (resultA3[0] != "1")
                {
                    dal.UpdateIfStatus(3, product.C_BATCH_NO, resultA3[1]);
                    return "1";
                }

                status = 4;
                var a4Fact = productDal.GetProductFact(product.C_BATCH_NO, 2, staID).Tables[0];
                var a4M = bll_TB_MATRL_MAIN.GetModel(product.C_MAT_CODE);
                var a4Sta = bll_TB_STA.GetModel(product.C_COG_STA_ID);
                ncA4.zdrid = RV.UI.UserInfo.userAccount;
                ncA4.rq = DateTime.Parse(product.D_START_DATE == null ? DateTime.Now.ToString() : product.D_START_DATE.ToString());
                ncA4.gzzxbmid = a4Sta.C_STA_ERPCODE;
                ncA4.scbmid = a4Sta.C_SSBMID;
                ncA4.pch = product.C_BATCH_NO;
                ncA4.wlbmid = a4M.C_PK_INVBASDOC;
                ncA4.jldwid = a4M.C_PK_MEASDOC;
                ncA4.gzzxid = a4Sta.C_ERP_PK;
                ncA4.ccxh = product.C_BATCH_NO;
                ncA4.pk_produce = a4M.C_PK_PRODUCE;
                ncA4.ksrq = DateTime.Parse(product.D_START_DATE == null ? DateTime.Now.ToString() : product.D_START_DATE.ToString());
                ncA4.jsrq = DateTime.Parse(product.D_END_DATE == null ? DateTime.Now.ToString() : product.D_END_DATE.ToString());
                ncA4.hgsl = a4Fact.Rows[0]["N_WGT"].ToString();
                ncA4.fhgsl = a4Fact.Rows[0]["N_QUA"].ToString();
                ncA4.sflfcp = "N";
                ncA4.sffsgp = "N";
                //DataTable a4DtZyx = bll_TB_STD_CONFIG.GetZYX(product.C_STL_GRD, product.C_STD_CODE).Tables[0];
                ncA4.freeitemvalue1 = plan.C_FREE1;
                ncA4.freeitemvalue2 = plan.C_FREE2;
                ncA4.freeitemvalue3 = plan.C_PACK;
                string a4Name = Guid.NewGuid() + "_A4.xml";
                if (dal_TRC_ROLL_WGD.IsA4Repeat(main.C_BATCH_NO, "") > 0)
                {
                    return "1";
                }
                var resultA4 = bll_Interface_NC_Roll_A4.SendXml_ROLL_A4("", a4Name, ncA4, path);
                if (resultA4[0] != "1")
                {
                    dal.UpdateIfStatus(4, product.C_BATCH_NO, resultA4[1]);
                    return "1";
                }

                status = 5;
                List<NcRoll46> nc46s = new List<NcRoll46>();
                var a46Fact = productDal.GetProductFactGroup(product.C_BATCH_NO, 2, staID).Tables[0];
                decimal wgt = 0;
                if (a46Fact != null && a46Fact.Rows.Count > 0)
                {
                    for (int i = 0; i < a46Fact.Rows.Count; i++)
                    {
                        NcRoll46 nc46 = new NcRoll46();
                        var a46M = bll_TB_MATRL_MAIN.GetModel(a46Fact.Rows[i]["C_MAT_CODE"].ToString());
                        nc46.cwarehouseid = bll_TPB_SLABWH.GetList_id(product.C_SLABWH_CODE).ToString();
                        nc46.taccounttime = DateTime.Parse(product.D_QR_DATE == null ? DateTime.Now.ToString() : product.D_QR_DATE.ToString());
                        nc46.coperatorid = dal_TS_USER.GetAccount(product.C_MOVE_ID).ToString(); //factDt.Rows[i]["C_RKRY"].ToString();
                        if (a46Fact.Rows[i]["C_MAT_TYPE"].ToString() == "合格品")
                            nc46.ccheckstate_bid = "1001NC100000000052Z3";
                        else
                            nc46.ccheckstate_bid = "1001NC100000000052Z6";
                        nc46.cworkcenterid = bll_TB_STA.Get_NC_ID(product.C_COG_STA_ID);
                        nc46.dbizdate = DateTime.Parse(product.D_QR_DATE == null ? DateTime.Now.ToString() : product.D_QR_DATE.ToString());
                        nc46.vbatchcode = product.C_BATCH_NO;
                        nc46.cinvbasid = a46M.C_PK_INVBASDOC;
                        nc46.pk_produce = a46M.C_PK_PRODUCE;
                        nc46.ninnum = a46Fact.Rows[i]["N_WGT"].ToString();
                        nc46.ninassistnum = a46Fact.Rows[i]["N_QUA"].ToString();
                        nc46.castunitid = matrl.C_FJLDW;
                        nc46.vfree1 = plan.C_FREE1;
                        nc46.vfree2 = plan.C_FREE2;
                        nc46.vfree3 = plan.C_PACK;
                        nc46s.Add(nc46);
                        wgt += decimal.Parse(a46Fact.Rows[i]["N_WGT"].ToString());
                    }
                    string a46Name = Guid.NewGuid() + "_A46.xml";
                    if (dal_TRC_ROLL_WGD.Is46Repeat(main.C_BATCH_NO, "") > 0)
                    {
                        return "1";
                    }
                    var resultA46 = bll_Interface_NC_Roll_46.SendXml_ROLL_46("", a46Name, nc46s, path);
                    if (resultA46[0] != "1")
                    {
                        dal.UpdateIfStatus(5, product.C_BATCH_NO, resultA46[1]);
                        return "1";
                    }

                    dal.UpdatePlanWgt(plan.C_ID, wgt);

                    if (dal.UpdateProductStatus(3, product.C_BATCH_NO) > 0)
                        return result = "0";

                }
                #endregion
            }
            catch (Exception ex)
            {
                dal.UpdateIfStatus(status, errorBatchNo, ex.Message);
                return "1";
            }
            return result;
        }


        /// <summary>
        /// KP完工报告NC
        /// </summary>
        /// <param name="cogID"></param>
        /// <param name="slabwhCode"></param>
        /// <returns></returns>
        public string KpSyncNcA4(string cogID, string slabwhCode, string staID, string path, string shift, string group)
        {
            string result = "1";
            string errorBatchNo = "";
            int status = 4;

            try
            {
                #region NC发送  A4 46
                NcRollA2 ncA2 = new NcRollA2();
                NcRollA3 ncA3 = new NcRollA3();
                NcRollA4 ncA4 = new NcRollA4();

                var main = dal.GetModel(cogID);
                var a2Sta = bll_TB_STA.GetModel(main.C_STA_ID);
                var plan = planDal.GetModel(main.C_PLAN_ID);
                var matrl = bll_TB_MATRL_MAIN.GetModel(plan.C_MAT_CODE);
                var product = productDal.GetModel(cogID);
                errorBatchNo = product.C_BATCH_NO;


                var a4Fact = productDal.GetProductFact(product.C_BATCH_NO, 2, staID).Tables[0];
                var a4M = bll_TB_MATRL_MAIN.GetModel(product.C_MAT_CODE);
                var a4Sta = bll_TB_STA.GetModel(product.C_COG_STA_ID);
                ncA4.zdrid = RV.UI.UserInfo.userAccount;
                ncA4.rq = DateTime.Parse(product.D_START_DATE == null ? DateTime.Now.ToString() : product.D_START_DATE.ToString());
                ncA4.gzzxbmid = a4Sta.C_STA_ERPCODE;
                ncA4.scbmid = a4Sta.C_SSBMID;
                ncA4.pch = product.C_BATCH_NO;
                ncA4.wlbmid = a4M.C_PK_INVBASDOC;
                ncA4.jldwid = a4M.C_PK_MEASDOC;
                ncA4.gzzxid = a4Sta.C_ERP_PK;
                ncA4.ccxh = product.C_BATCH_NO;
                ncA4.pk_produce = a4M.C_PK_PRODUCE;
                ncA4.ksrq = DateTime.Parse(product.D_START_DATE == null ? DateTime.Now.ToString() : product.D_START_DATE.ToString());
                ncA4.jsrq = DateTime.Parse(product.D_END_DATE == null ? DateTime.Now.ToString() : product.D_END_DATE.ToString());
                ncA4.hgsl = a4Fact.Rows[0]["N_WGT"].ToString();
                ncA4.fhgsl = a4Fact.Rows[0]["N_QUA"].ToString();
                ncA4.sflfcp = "N";
                ncA4.sffsgp = "N";
                //DataTable a4DtZyx = bll_TB_STD_CONFIG.GetZYX(product.C_STL_GRD, product.C_STD_CODE).Tables[0];
                ncA4.freeitemvalue1 = plan.C_FREE1;
                ncA4.freeitemvalue2 = plan.C_FREE2;
                ncA4.freeitemvalue3 = plan.C_PACK;
                string a4Name = Guid.NewGuid() + "_A4.xml";
                if (dal_TRC_ROLL_WGD.IsA4Repeat(main.C_BATCH_NO, "") > 0)
                {
                    return "1";
                }
                var resultA4 = bll_Interface_NC_Roll_A4.SendXml_ROLL_A4("", a4Name, ncA4, path);
                if (resultA4[0] != "1")
                {
                    dal.UpdateIfStatus(4, product.C_BATCH_NO, resultA4[1]);
                    return "1";
                }

                status = 5;
                List<NcRoll46> nc46s = new List<NcRoll46>();
                var a46Fact = productDal.GetProductFactGroup(product.C_BATCH_NO, 2, staID).Tables[0];
                decimal wgt = 0;
                if (a46Fact != null && a46Fact.Rows.Count > 0)
                {
                    for (int i = 0; i < a46Fact.Rows.Count; i++)
                    {
                        NcRoll46 nc46 = new NcRoll46();
                        var a46M = bll_TB_MATRL_MAIN.GetModel(a46Fact.Rows[i]["C_MAT_CODE"].ToString());
                        nc46.cwarehouseid = bll_TPB_SLABWH.GetList_id(product.C_SLABWH_CODE).ToString();
                        nc46.taccounttime = DateTime.Parse(product.D_QR_DATE == null ? DateTime.Now.ToString() : product.D_QR_DATE.ToString());
                        nc46.coperatorid = dal_TS_USER.GetAccount(product.C_MOVE_ID).ToString(); //factDt.Rows[i]["C_RKRY"].ToString();
                        if (a46Fact.Rows[i]["C_MAT_TYPE"].ToString() == "合格品")
                            nc46.ccheckstate_bid = "1001NC100000000052Z3";
                        else
                            nc46.ccheckstate_bid = "1001NC100000000052Z6";
                        nc46.cworkcenterid = bll_TB_STA.Get_NC_ID(product.C_COG_STA_ID);
                        nc46.dbizdate = DateTime.Parse(product.D_QR_DATE == null ? DateTime.Now.ToString() : product.D_QR_DATE.ToString());
                        nc46.vbatchcode = product.C_BATCH_NO;
                        nc46.cinvbasid = a46M.C_PK_INVBASDOC;
                        nc46.pk_produce = a46M.C_PK_PRODUCE;
                        nc46.ninnum = a46Fact.Rows[i]["N_WGT"].ToString();
                        nc46.ninassistnum = a46Fact.Rows[i]["N_QUA"].ToString();
                        nc46.castunitid = matrl.C_FJLDW;
                        nc46.vfree1 = plan.C_FREE1;
                        nc46.vfree2 = plan.C_FREE2;
                        nc46.vfree3 = plan.C_PACK;
                        nc46s.Add(nc46);
                        wgt += decimal.Parse(a46Fact.Rows[i]["N_WGT"].ToString());
                    }
                    string a46Name = Guid.NewGuid() + "_A46.xml";
                    if (dal_TRC_ROLL_WGD.Is46Repeat(main.C_BATCH_NO, "") > 0)
                    {
                        return "1";
                    }
                    var resultA46 = bll_Interface_NC_Roll_46.SendXml_ROLL_46("", a46Name, nc46s, path);
                    if (resultA46[0] != "1")
                    {
                        dal.UpdateIfStatus(5, product.C_BATCH_NO, resultA46[1]);
                        return "1";
                    }

                    dal.UpdatePlanWgt(plan.C_ID, wgt);

                    if (dal.UpdateProductStatus(3, product.C_BATCH_NO) > 0)
                        return result = "0";

                }
                #endregion
            }
            catch (Exception ex)
            {
                dal.UpdateIfStatus(status, errorBatchNo, ex.Message);
                return "1";
            }
            return result;
        }


        /// <summary>
        /// KP完工报告NC
        /// </summary>
        /// <param name="cogID"></param>
        /// <param name="slabwhCode"></param>
        /// <returns></returns>
        public string KpSyncNc46(string cogID, string slabwhCode, string staID, string path, string shift, string group)
        {
            string result = "1";
            string errorBatchNo = "";
            int status = 5;

            try
            {
                #region NC发送 46
                NcRollA2 ncA2 = new NcRollA2();
                NcRollA3 ncA3 = new NcRollA3();
                NcRollA4 ncA4 = new NcRollA4();

                var main = dal.GetModel(cogID);
                var a2Sta = bll_TB_STA.GetModel(main.C_STA_ID);
                var plan = planDal.GetModel(main.C_PLAN_ID);
                var matrl = bll_TB_MATRL_MAIN.GetModel(plan.C_MAT_CODE);
                var product = productDal.GetModel(cogID);
                errorBatchNo = product.C_BATCH_NO;

                List<NcRoll46> nc46s = new List<NcRoll46>();
                var a46Fact = productDal.GetProductFactGroup(product.C_BATCH_NO, 2, staID).Tables[0];
                decimal wgt = 0;
                if (a46Fact != null && a46Fact.Rows.Count > 0)
                {
                    for (int i = 0; i < a46Fact.Rows.Count; i++)
                    {
                        NcRoll46 nc46 = new NcRoll46();
                        var a46M = bll_TB_MATRL_MAIN.GetModel(a46Fact.Rows[i]["C_MAT_CODE"].ToString());
                        nc46.cwarehouseid = bll_TPB_SLABWH.GetList_id(product.C_SLABWH_CODE).ToString();
                        nc46.taccounttime = DateTime.Parse(product.D_QR_DATE == null ? DateTime.Now.ToString() : product.D_QR_DATE.ToString());
                        nc46.coperatorid = dal_TS_USER.GetAccount(product.C_MOVE_ID).ToString(); //factDt.Rows[i]["C_RKRY"].ToString();
                        if (a46Fact.Rows[i]["C_MAT_TYPE"].ToString() == "合格品")
                            nc46.ccheckstate_bid = "1001NC100000000052Z3";
                        else
                            nc46.ccheckstate_bid = "1001NC100000000052Z6";
                        nc46.cworkcenterid = bll_TB_STA.Get_NC_ID(product.C_COG_STA_ID);
                        nc46.dbizdate = DateTime.Parse(product.D_QR_DATE == null ? DateTime.Now.ToString() : product.D_QR_DATE.ToString());
                        nc46.vbatchcode = product.C_BATCH_NO;
                        nc46.cinvbasid = a46M.C_PK_INVBASDOC;
                        nc46.pk_produce = a46M.C_PK_PRODUCE;
                        nc46.ninnum = a46Fact.Rows[i]["N_WGT"].ToString();
                        nc46.ninassistnum = a46Fact.Rows[i]["N_QUA"].ToString();
                        nc46.castunitid = matrl.C_FJLDW;
                        nc46.vfree1 = plan.C_FREE1;
                        nc46.vfree2 = plan.C_FREE2;
                        nc46.vfree3 = plan.C_PACK;
                        nc46s.Add(nc46);
                        wgt += decimal.Parse(a46Fact.Rows[i]["N_WGT"].ToString());
                    }
                    string a46Name = Guid.NewGuid() + "_A46.xml";
                    if (dal_TRC_ROLL_WGD.Is46Repeat(main.C_BATCH_NO, "") > 0)
                    {
                        return "1";
                    }
                    var resultA46 = bll_Interface_NC_Roll_46.SendXml_ROLL_46("", a46Name, nc46s, path);
                    if (resultA46[0] != "1")
                    {
                        dal.UpdateIfStatus(5, product.C_BATCH_NO, resultA46[1]);
                        return "1";
                    }

                    dal.UpdatePlanWgt(plan.C_ID, wgt);

                    if (dal.UpdateProductStatus(3, product.C_BATCH_NO) > 0)
                        return result = "0";

                }
                #endregion
            }
            catch (Exception ex)
            {
                dal.UpdateIfStatus(status, errorBatchNo, ex.Message);
                return "1";
            }
            return result;
        }

        /// <summary>
        /// 关闭计划
        /// </summary>
        /// <param name="planID"></param>
        /// <returns></returns>
        public string ClosePlan(string planID)
        {
            string result = "1";
            if (!dal.ClosePlan(planID))
                result = "0";
            return result;
        }

        /// <summary>
        /// 完成计划
        /// </summary>
        /// <param name="planID"></param>
        /// <returns></returns>
        public string SuccessPlan(string planID)
        {
            string result = "1";
            if (!dal.SuccessPlan(planID))
                result = "0";
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


        /// 完成组坯计划
        /// </summary>
        /// <param name="planID"></param>
        /// <returns></returns>
        public int UpdateCogDown(string id)
        {
            return dal.UpdateCogDown(id);
        }

        /// <summary>
        /// 修改开坯实绩中间表状态
        /// </summary>
        /// <param name="status"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public int UpdateIfStatus(int status, string batchNo, string remark)
        {
            return dal.UpdateIfStatus(status, batchNo, remark);
        }

        /// <summary>
        /// wgd未上传NC条数
        /// </summary>
        /// <returns></returns>
        public object GetNotUpLoadWgdCount(string staID)
        {
            return dal.GetNotUpLoadWgdCount(staID);
        }

        /// <summary>
        /// 获取开坯可组批钢坯
        /// </summary>
        /// <param name="stove">炉号</param>
        /// <returns></returns>
        public DataSet GetStl(string stove)
        {
            return dal.GetStl(stove);
        }

        /// <summary>
        /// 获取开坯可组批钢坯
        /// </summary>
        /// <param name="stove">炉号</param>
        /// <returns></returns>
        public DataSet GetStlIds(string stove)
        {
            return dal.GetStlIds(stove);
        }

        /// <summary>
        /// 获取开坯中间表
        /// </summary>
        /// <param name="id">组坯主键</param>
        /// <returns></returns>
        public DataTable GetCogdownMainItem(string id)
        {
            return dal.GetCogdownMainItem(id);
        }

        /// <summary>
        /// 补单
        /// </summary>
        /// <param name="id">组坯主键</param>
        /// <param name="dt">钢坯</param>
        /// <returns></returns>
        public string SupplementSlab(string id, DataTable slabTable)
        {
            string result = "1";

            try
            {
                TransactionHelper.BeginTransaction();
                if (slabTable != null && slabTable.Rows.Count > 0)
                {
                    //1.添加开坯子表
                    Bll_TRC_COGDOWN_MAIN_ITEM bll = new Bll_TRC_COGDOWN_MAIN_ITEM();
                    for (int i = 0; i < slabTable.Rows.Count; i++)
                    {
                        Mod_TRC_COGDOWN_MAIN_ITEM cogdownMainItem = new Mod_TRC_COGDOWN_MAIN_ITEM();
                        cogdownMainItem.C_COGDOWN_MAIN_ID = id;
                        cogdownMainItem.C_SLAB_MAIN_ID = slabTable.Rows[i]["C_ID"].ToString();
                        if (!bll.Add(cogdownMainItem))
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

                    //3.修改组坯表信息
                    var rollM = dal.GetModel(id);
                    decimal wgt = rollM.N_WGT_TOTAL_VIRTUAL.Value / rollM.N_QUA_TOTAL_VIRTUAL.Value;
                    decimal qua = slabTable.Rows.Count;
                    rollM.N_QUA_TOTAL_VIRTUAL += qua;
                    rollM.N_WGT_TOTAL_VIRTUAL += qua * wgt;
                    rollM.N_QUA_EXIT += qua;
                    rollM.N_WGT_EXIT += qua * wgt;
                    if (!dal.UpdateTran(rollM))
                    {
                        TransactionHelper.RollBack();
                        return "0";
                    }


                    //修改计划组批量
                    if (planDal.UpdateGroupWgt(rollM.C_PLAN_ID, (decimal)rollM.N_WGT_TOTAL_VIRTUAL) == 0)
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


                }
            }
            catch (Exception ex)
            {
                TransactionHelper.RollBack();
                return "0";
            }

            return result;
        }

        /// <summary>
        /// 剔除钢坯
        /// </summary>
        /// <param name="id">组坯主键</param>
        /// <param name="asseNum">剔除支数</param>
        /// <returns></returns>
        public string ElimSlab(string id, int asseNum)
        {
            string result = "1";
            try
            {
                TransactionHelper.BeginTransaction();
                var dt = dal.GetCogdownMainItem(id, asseNum);
                var rollMainM = dal.GetModel(id);


                //1.删除开坯子表
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (dal.DelCogMainItem(id, dt.Rows[i]["C_SLAB_MAIN_ID"].ToString()) == 0)
                    {
                        TransactionHelper.RollBack();
                        return "0";
                    }
                }

                //出炉剔除
                var num = dt.Rows.Count;
                var wgt = rollMainM.N_WGT_TOTAL_VIRTUAL / rollMainM.N_QUA_TOTAL_VIRTUAL;
                if (dal.ElimOut(id, num, num * wgt.Value, "补批管理剔除") == 0)
                {
                    TransactionHelper.RollBack();
                    return "0";
                }

                //修改大计划量
                if (planDal.BackOutGroupWgt(rollMainM.C_PLAN_ID, num * wgt.Value) == 0)
                {
                    TransactionHelper.RollBack();
                    return "0";
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


            }
            catch (Exception e)
            {
                TransactionHelper.RollBack();
                return "0";
            }
            return result;
        }

        /// <summary>
        /// 获取自动同步执行人
        /// </summary>
        /// <returns></returns>
        public string GetUser()
        {
            return dal.GetUser();
        }
        /// <summary>
        /// 获取出炉时间
        /// </summary>
        /// <returns></returns>
        public object GetOutTimeKp(string id)
        {
            return dal.GetOutTimeKp(id);
        }
        /// <summary>
        /// A3是否已传
        /// </summary>
        /// <param name="batchNO">批次号</param>
        /// <param name="commpany">公司编码</param>
        /// <returns></returns>
        public int IsA3Repeat(string batchNO, string commpany)
        {
            return dal.IsA3Repeat(batchNO, commpany);
        }
        /// <summary>
        /// 修改开坯实绩中间表状态
        /// </summary>
        /// <param name="status"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public int UpdateIfStatusCogDown(int status, string batchNo, string remark)
        {
            return dal.UpdateIfStatusCogDown(status, batchNo, remark);
        }
        public void InsertLog(string wgdId, string error)
        {
             dal.InsertLog(wgdId, error);
        }

        }
}
