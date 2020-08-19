using System;
using System.Data;
using System.Collections.Generic;
using DAL;
using MODEL;
namespace BLL
{
    /// <summary>
    /// 轧钢完工单表
    /// </summary>
    public partial class Bll_TRC_ROLL_WGD
    {
        private readonly Dal_TRC_ROLL_WGD dal = new Dal_TRC_ROLL_WGD();
        private readonly Dal_TRC_ROLL_WGD_HANDLER wgdHandlerDal = new Dal_TRC_ROLL_WGD_HANDLER();
        private readonly Dal_TRC_ROLL_WGD_HANDLER_LOG wgdHandlerLogDal = new Dal_TRC_ROLL_WGD_HANDLER_LOG();
        private readonly Dal_TRC_ROLL_WGD wgdDal = new Dal_TRC_ROLL_WGD();
        private readonly Dal_TRC_ROLL_WGD_ITEM wgdItemDal = new Dal_TRC_ROLL_WGD_ITEM();
        private readonly Dal_TRC_ROLL_WGD_LOG wgdDalLog = new Dal_TRC_ROLL_WGD_LOG();
        private readonly Dal_TRC_ROLL_WGD_ITEM_LOG wgdItemDalLog = new Dal_TRC_ROLL_WGD_ITEM_LOG();
        private readonly Dal_TRC_WARM_FURNACE dal_TRC_WARM_FURNACE = new Dal_TRC_WARM_FURNACE();
        private readonly Dal_TRP_PLAN_ROLL planDal = new Dal_TRP_PLAN_ROLL();
        private readonly Dal_TRP_PLAN_ROLL_ITEM planDalItem = new Dal_TRP_PLAN_ROLL_ITEM();
        private readonly Dal_Interface_FR Ifr = new Dal_Interface_FR();
        private readonly Dal_Interface_NC_Roll_A1 inr = new Dal_Interface_NC_Roll_A1();
        Dal_Interface_NC_Roll_A4 dal_Interface_NC_Roll_A4 = new Dal_Interface_NC_Roll_A4();
        Dal_Interface_NC_Roll_46 dal_Interface_NC_Roll_46 = new Dal_Interface_NC_Roll_46();
        private Dal_TRP_PLAN_ROLL_ITEM planRollItem = new Dal_TRP_PLAN_ROLL_ITEM();
        Dal_TB_STA dal_TB_STA = new Dal_TB_STA();
        Dal_TB_MATRL_MAIN dal_TB_MATRL_MAIN = new Dal_TB_MATRL_MAIN();
        Dal_TRC_ROLL_MAIN dal_TRC_ROLL_MAIN = new Dal_TRC_ROLL_MAIN();
        Dal_TPB_LINEWH dal_TPB_LINEWH = new Dal_TPB_LINEWH();
        Dal_TQB_CHECKSTATE dal_TQB_CHECKSTATE = new Dal_TQB_CHECKSTATE();


        public Bll_TRC_ROLL_WGD()
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
        public bool Add(Mod_TRC_ROLL_WGD model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Mod_TRC_ROLL_WGD model)
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
        public Mod_TRC_ROLL_WGD GetModel(string C_ID)
        {

            return dal.GetModel(C_ID);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Mod_TRC_ROLL_WGD GetModel(string C_MAIN_ID, int type)
        {
            return dal.GetModel(C_MAIN_ID, type);
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
        public List<Mod_TRC_ROLL_WGD> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Mod_TRC_ROLL_WGD> DataTableToList(DataTable dt)
        {
            List<Mod_TRC_ROLL_WGD> modelList = new List<Mod_TRC_ROLL_WGD>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Mod_TRC_ROLL_WGD model;
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
        #endregion  BasicMethod
        #region  ExtensionMethod

        /// <summary>
        /// 完工单处理
        /// </summary>
        /// <param name="id">完工单主键id</param>
        /// <param name="staID">工位</param>
        /// <param name="stove">炉号</param>
        /// <param name="batchNo">批号</param>
        /// <param name="planID">计划号</param>
        /// <param name="grd">钢种</param>
        /// <param name="std">执行标准</param>
        /// <param name="spec">规格</param>
        /// <param name="pack">包装标准</param>
        /// <param name="zyx">自由项</param>
        /// <param name="zyx2">自由项2</param>
        /// <param name="mrsx">批次属性</param>
        /// <param name="matCode">物料编码</param>
        /// <param name="matDesc">物料名称</param>
        /// <param name="pclx">批次类型</param>
        /// <param name="newMrsx">确认批次属性</param>
        /// <param name="newPclx">确认批次类型</param>
        /// <param name="status">状态1 完工 2改判 3撤销</param>
        /// <param name="newStd"></param>
        /// <param name="newGrd"></param>
        /// <param name="newSpec"></param>
        /// <param name="newMatCode"></param>
        /// <param name="newMatDesc"></param>
        /// <param name="newZyx"></param>
        /// <param name="newZyx2"></param>
        /// <param name="newPack"></param>
        /// <param name="start"></param>
        /// <param name="status"></param>
        /// <returns></returns>
        public string WgdHandler(string id, string staID, string stove, string batchNo, string planID,
             string grd, string std, string spec, string pack, string zyx, string zyx2, string mrsx, string matCode,
             string matDesc, string pclx, string newMrsx, string newPclx, string newStd, string newGrd, string newSpec, string newMatCode, string newMatDesc, string newZyx, string newZyx2, string newPack, DateTime start, int status, string sx, string itemID)
        {
            string result = "1";
            try
            {
                TransactionHelper.BeginTransaction();
                Mod_TRC_ROLL_WGD_HANDLER model = new Mod_TRC_ROLL_WGD_HANDLER();
                model.C_WGD_ID = id;
                model.C_STA_ID = staID;
                model.C_STOVE = stove;
                model.C_BATCH_NO = batchNo;
                model.C_PLAN_ID = planID;
                model.D_MOD_DT = start;
                model.C_STD_CODE = std;
                model.C_STL_GRD = grd;
                model.C_SPEC = spec;
                model.C_PACK = pack;
                model.C_FREE_TERM = zyx;
                model.C_FREE_TERM2 = zyx2;
                model.C_MRSX = mrsx;
                model.C_MAT_CODE = matCode;
                model.C_MAT_DESC = matDesc;
                model.C_PCLX = pclx;
                model.N_STATUS = status;
                model.C_NEWMRSX = newMrsx;
                model.C_NEWPCLX = newPclx;
                model.C_NEW_STL_GRD = newGrd;
                model.C_NEW_SPEC = newSpec;
                model.C_NEW_STD_CODE = newStd;
                model.C_NEW_MAT_CODE = newMatCode;
                model.C_NEW_MAT_DESC = newMatDesc;
                model.C_NEW_PACK = newPack;
                model.C_NEW_FREE_TERM = newZyx;
                model.C_NEW_FREE_TERM2 = newZyx2;
                model.C_SX = sx;
                string zpdjbz = "0";
                if (newMrsx == "DP")
                    zpdjbz = "1";

                if (!wgdHandlerDal.Add(model))
                {
                    TransactionHelper.RollBack();
                    return "0";
                }

                if (status == 1)
                {
                    if (!dal.UpdateWgd(model.C_WGD_ID, model.C_NEWMRSX, model.C_NEWPCLX, 1, model.C_SX, zpdjbz))
                    {
                        TransactionHelper.RollBack();
                        return "0";
                    }
                }
                else
                {
                    if (!dal.UpdateWgd(model.C_WGD_ID, model.C_NEWMRSX, model.C_NEWPCLX, newGrd, newSpec, newStd, newMatCode, newMatDesc, newZyx, newZyx2, 1, model.C_SX, zpdjbz))
                    {
                        TransactionHelper.RollBack();
                        return "0";
                    }
                }

                //出口才更新子表
                if (newPclx == "1")
                {
                    if (!dal.UpdateWgdItem(itemID, sx, 1))
                    {
                        TransactionHelper.RollBack();
                        return "0";
                    }
                }

                TransactionHelper.Commit();

                Mod_TRC_ROLL_WGD_HANDLER_LOG modelLog = new Mod_TRC_ROLL_WGD_HANDLER_LOG();
                modelLog.C_WGD_ID = id;
                modelLog.C_STA_ID = staID;
                modelLog.C_STOVE = stove;
                modelLog.C_BATCH_NO = batchNo;
                modelLog.C_PLAN_ID = planID;
                modelLog.D_MOD_DT = DateTime.Now;
                modelLog.C_STD_CODE = std;
                modelLog.C_STL_GRD = grd;
                modelLog.C_SPEC = spec;
                modelLog.C_PACK = pack;
                modelLog.C_FREE_TERM = zyx;
                modelLog.C_FREE_TERM2 = zyx2;
                modelLog.C_MRSX = mrsx;
                modelLog.C_MAT_CODE = matCode;
                modelLog.C_MAT_DESC = matDesc;
                modelLog.C_PCLX = pclx;
                modelLog.N_STATUS = status;
                modelLog.C_NEWMRSX = newMrsx;
                modelLog.C_NEWPCLX = newPclx;
                modelLog.C_NEW_STL_GRD = newGrd;
                modelLog.C_NEW_SPEC = newSpec;
                modelLog.C_NEW_STD_CODE = newStd;
                modelLog.C_NEW_MAT_CODE = newMatCode;
                modelLog.C_NEW_MAT_DESC = newMatDesc;
                modelLog.C_NEW_PACK = newPack;
                modelLog.C_NEW_FREE_TERM = newZyx;
                modelLog.C_NEW_FREE_TERM2 = newZyx2;
                modelLog.C_SX = sx;
                wgdHandlerLogDal.Add(modelLog);
            }
            catch (Exception ex)
            {
                TransactionHelper.RollBack();
                return "0";
            }
            return result;
        }

        /// <summary>
        /// 撤回完工单
        /// </summary>
        /// <param name="id">完工单ID</param>
        /// <returns></returns>
        public string WgdBackHandler(string id, int status)
        {
            string result = "1";
            try
            {
                DataTable dt = dal.GetWgdHandler(id).Tables[0];
                if (dt != null && dt.Rows.Count > 0)
                {
                    DataRow dr = dt.Rows[0];
                    TransactionHelper.BeginTransaction();
                    var model = wgdHandlerDal.DataRowToModel(dr);
                    if (!dal.UpdateWgd(id, model.C_MRSX, model.C_PCLX, model.C_STL_GRD, model.C_SPEC, model.C_STD_CODE
                         , model.C_MAT_CODE, model.C_MAT_DESC, model.C_FREE_TERM, model.C_FREE_TERM2, 0, model.C_SX, ""))
                    {
                        TransactionHelper.RollBack();
                        return "0";
                    }
                    if (!wgdHandlerDal.Delete(model.C_ID))
                    {
                        TransactionHelper.RollBack();
                        return "0";
                    }

                    if (!dal.UpdateWgdItemSecond(id, "A", 0))
                    {
                        TransactionHelper.RollBack();
                        return "0";
                    }

                    TransactionHelper.Commit();

                    Mod_TRC_ROLL_WGD_HANDLER_LOG modelLog = new Mod_TRC_ROLL_WGD_HANDLER_LOG();
                    modelLog.C_WGD_ID = id;
                    modelLog.C_STA_ID = model.C_STA_ID;
                    modelLog.C_STOVE = model.C_STOVE;
                    modelLog.C_BATCH_NO = model.C_BATCH_NO;
                    modelLog.C_PLAN_ID = model.C_PLAN_ID;
                    modelLog.D_MOD_DT = DateTime.Now;
                    modelLog.C_STD_CODE = model.C_NEW_STD_CODE;
                    modelLog.C_STL_GRD = model.C_NEW_STL_GRD;
                    modelLog.C_SPEC = model.C_NEW_SPEC;
                    modelLog.C_PACK = model.C_NEW_PACK;
                    modelLog.C_FREE_TERM = model.C_NEW_FREE_TERM;
                    modelLog.C_FREE_TERM2 = model.C_NEW_FREE_TERM2;
                    modelLog.C_MRSX = model.C_NEWMRSX;
                    modelLog.C_MAT_CODE = model.C_NEW_MAT_CODE;
                    modelLog.C_MAT_DESC = model.C_NEW_MAT_DESC;
                    modelLog.C_PCLX = model.C_NEWPCLX;
                    modelLog.N_STATUS = status;
                    modelLog.C_NEWMRSX = model.C_MRSX;
                    modelLog.C_NEWPCLX = model.C_PCLX;
                    modelLog.C_NEW_STL_GRD = model.C_STL_GRD;
                    modelLog.C_NEW_SPEC = model.C_SPEC;
                    modelLog.C_NEW_STD_CODE = model.C_STD_CODE;
                    modelLog.C_NEW_MAT_CODE = model.C_MAT_CODE;
                    modelLog.C_NEW_MAT_DESC = model.C_MAT_DESC;
                    modelLog.C_NEW_PACK = model.C_PACK;
                    modelLog.C_NEW_FREE_TERM = model.C_FREE_TERM;
                    modelLog.C_NEW_FREE_TERM2 = model.C_FREE_TERM2;
                    wgdHandlerLogDal.Add(modelLog);
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
        /// 上传条码系统
        /// </summary>
        /// <returns></returns>
        public string UpLoadCodeSys(string id)
        {
            string result = "1";
            try
            {
                var model = wgdDal.GetModel(id);
                var modelItems = wgdItemDal.GetModels(id);
                if (Ifr.SENDWGD(model) == 0)
                    return "0";
                if (Ifr.SENDWGDITEM(modelItems, model) == 0)
                    return "0";
                if (wgdDal.UpdateUpLoadStatus(id, 1) == 0)
                    return "0";
            }
            catch (Exception ex)
            {
                return "0";
            }
            return result;
        }

        /// <summary>
        /// 完工单确认
        /// </summary>
        /// <param name="stove">炉号</param>
        /// <param name="batchNo">批号</param>
        /// <param name="planID">计划id</param>
        /// <param name="num">支数</param>
        /// <param name="wgt">重量</param>
        /// <param name="grd">钢种</param>
        /// <param name="spec">规格</param>
        /// <param name="std">执行标准</param>
        /// <param name="id">主表id</param>
        /// <param name="staID">工位号</param>
        /// <param name="start">start</param>
        /// <param name="end">start</param>
        /// <param name="shift">班次ID</param>
        /// <param name="group">班组ID</param>
        /// <param name="shiftName">班次</param>
        /// <param name="groupName">班组</param>
        /// <param name="castOffQua">甩废</param>
        /// <param name="cuttingQua">切废</param>
        /// <returns></returns>
        public string WgdHandler(string stove, string batchNo, string planID, int num,
            decimal wgt, string grd, string spec, string std, string id, string staID, DateTime start, DateTime end
            , string shift, string group, string shiftName, string groupName, string castOffQua, string cuttingQua)
        {
            string result = "1";
            try
            {
                TransactionHelper.BeginTransaction();
                decimal successQua = num - decimal.Parse(castOffQua) - decimal.Parse(cuttingQua);
                wgdDal.UpdateWgd(start, end, num, id, decimal.Parse(castOffQua), decimal.Parse(cuttingQua), successQua, shift, group, shiftName, groupName);

                if (!wgdDal.UpdateRollStatus(id, 1))
                {
                    TransactionHelper.RollBack();
                    return "0";
                }

                if (dal_TRC_WARM_FURNACE.UpdateWarmFurnaceRolleState(id, 3, 2) == 0)
                {
                    TransactionHelper.RollBack();
                    return "0";
                }

                TransactionHelper.Commit();

                #region 日志模型
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
                model.D_PRODUCE_DATE_E = RV.UI.ServerTime.timeNow();
                model.C_PRODUCE_SHIFT = shift;
                model.C_PRODUCE_GROUP = group;
                model.C_PRODUCE_EMP_ID = RV.UI.UserInfo.userID;
                model.D_MOD_DT = start;
                model.D_PRODUCE_DATE = model.D_PRODUCE_DATE_B;
                model.C_FREE_TERM = planM.C_FREE_TERM;
                model.C_FREE_TERM2 = planM.C_FREE_TERM2;
                model.C_PACK = planM.C_PACK;
                model.C_AREA = planM.C_AREA;
                model.C_PCLX = planM.C_PCLX;
                model.C_MAT_CODE = planM.C_MAT_CODE;
                model.C_MAT_DESC = planM.C_MAT_NAME;
                model.C_PRODUCE_SHIFT_NAME = shiftName;
                model.C_PRODUCE_GROUP_NAME = groupName;


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
                    }
                }
                #endregion

                AddLog(stove, batchNo, planID, num, wgt, grd, spec, std, id, staID, start, end, shift, group, model, planM, dt);

            }
            catch (Exception ex)
            {
                TransactionHelper.RollBack();
                return "0";
            }
            return result;
        }

        private void AddLog(string stove, string batchNo, string planID, int num, decimal wgt, string grd, string spec, string std, string id, string staID, DateTime start, DateTime end, string shift, string group, Mod_TRC_ROLL_WGD model, Mod_TRP_PLAN_ROLL_ITEM planM, DataTable dt)
        {
            Mod_TRC_ROLL_WGD_LOG modelLog = new Mod_TRC_ROLL_WGD_LOG();
            modelLog.C_ID = Guid.NewGuid().ToString();
            modelLog.C_STA_ID = staID;
            modelLog.C_STOVE = stove;
            modelLog.C_BATCH_NO = batchNo;
            modelLog.C_PLAN_ID = planID;
            modelLog.N_QUA_PRODUCE = num;
            modelLog.N_WGT_PRODUCE = wgt;
            modelLog.N_STATUS = 2;
            modelLog.C_STD_CODE = std;
            modelLog.C_STL_GRD = grd;
            modelLog.C_SPEC = spec;
            modelLog.C_MAIN_ID = id;
            modelLog.D_PRODUCE_DATE_B = start;
            modelLog.D_PRODUCE_DATE_E = end;
            modelLog.C_PRODUCE_SHIFT = shift;
            modelLog.C_PRODUCE_GROUP = group;
            modelLog.C_PRODUCE_EMP_ID = RV.UI.UserInfo.userID;
            modelLog.D_MOD_DT = DateTime.Now;
            modelLog.D_PRODUCE_DATE = model.D_PRODUCE_DATE_B;
            modelLog.C_FREE_TERM = planM.C_FREE_TERM;
            modelLog.C_FREE_TERM2 = planM.C_FREE_TERM2;
            modelLog.C_PACK = planM.C_PACK;
            modelLog.C_AREA = planM.C_AREA;
            modelLog.C_PCLX = planM.C_PCLX;
            modelLog.C_MAT_CODE = planM.C_MAT_CODE;
            modelLog.C_MAT_DESC = planM.C_MAT_NAME;
            wgdDalLog.Add(modelLog);

            if (dt != null && dt.Rows.Count > 0)
            {
                Mod_TRC_ROLL_WGD_ITEM_LOG itemM = new Mod_TRC_ROLL_WGD_ITEM_LOG();
                itemM.C_MAIN_ID = model.C_MAIN_ID;
                itemM.C_ROLL_WGD_ID = model.C_ID;
                itemM.C_BATCH_NO = batchNo;
                itemM.N_STATUS = 2;
                itemM.C_STL_GRD = model.C_STL_GRD;
                itemM.C_STD_CODE = model.C_STD_CODE;
                itemM.C_SPEC = model.C_SPEC;
                itemM.C_MAT_CODE = planM.C_MAT_CODE;
                itemM.C_MAT_DESC = planM.C_MAT_NAME;
                itemM.C_ZYX1 = planM.C_FREE_TERM;
                itemM.C_ZYX2 = planM.C_FREE_TERM2;
                itemM.C_BZYQ = model.C_PACK;
                itemM.C_SALE_AREA = model.C_AREA;
                wgdItemDalLog.Add(itemM);

                foreach (DataRow item in dt.Rows)
                {
                    Mod_TRC_ROLL_WGD_ITEM_LOG itemMM = new Mod_TRC_ROLL_WGD_ITEM_LOG();
                    itemMM.C_MAIN_ID = model.C_MAIN_ID;
                    itemMM.C_ROLL_WGD_ID = model.C_ID;
                    itemMM.C_BATCH_NO = batchNo;
                    itemMM.N_STATUS = 2;
                    itemMM.C_STL_GRD = item["钢种"].ToString();
                    itemMM.C_STD_CODE = item["执行标准"].ToString();
                    itemMM.C_SPEC = item["规格"].ToString();
                    itemMM.C_MAT_CODE = item["物料编码"].ToString();
                    itemMM.C_MAT_DESC = item["物料名称"].ToString();
                    itemMM.C_ZYX1 = item["自由项1"].ToString();
                    itemMM.C_ZYX2 = item["自由项2"].ToString();
                    itemMM.C_BZYQ = model.C_PACK;
                    itemMM.C_SALE_AREA = model.C_AREA;
                    wgdItemDalLog.Add(itemMM);
                }
            }
        }

        public string WgdBackHandler(DataRow dr)
        {
            string result = "1";
            try
            {
                Mod_TRC_ROLL_WGD_LOG modelLog = new Mod_TRC_ROLL_WGD_LOG();
                modelLog.C_ID = Guid.NewGuid().ToString();
                modelLog.C_STA_ID = dr["C_STA_ID"].ToString();
                modelLog.C_STOVE = dr["C_STOVE"].ToString();
                modelLog.C_BATCH_NO = dr["C_BATCH_NO"].ToString();
                modelLog.C_PLAN_ID = dr["C_PLAN_ID"].ToString();
                modelLog.N_QUA_PRODUCE = decimal.Parse(dr["N_QUA_PRODUCE"].ToString());
                modelLog.N_WGT_PRODUCE = decimal.Parse(dr["N_WGT_PRODUCE"].ToString());
                modelLog.N_STATUS = 3;
                modelLog.C_STD_CODE = dr["C_STD_CODE"].ToString();
                modelLog.C_STL_GRD = dr["C_STL_GRD"].ToString();
                modelLog.C_SPEC = dr["C_SPEC"].ToString();
                modelLog.C_MAIN_ID = dr["C_MAIN_ID"].ToString();
                modelLog.D_PRODUCE_DATE_B = DateTime.Parse(dr["D_PRODUCE_DATE_B"].ToString());
                modelLog.D_PRODUCE_DATE_E = DateTime.Parse(dr["D_PRODUCE_DATE_E"].ToString());
                modelLog.C_PRODUCE_SHIFT = dr["C_PRODUCE_SHIFT"].ToString();
                modelLog.C_PRODUCE_GROUP = dr["C_PRODUCE_GROUP"].ToString();
                modelLog.C_PRODUCE_EMP_ID = RV.UI.UserInfo.userID;
                modelLog.D_MOD_DT = DateTime.Now;
                modelLog.D_PRODUCE_DATE = DateTime.Parse(dr["D_PRODUCE_DATE"].ToString());
                modelLog.C_FREE_TERM = dr["C_FREE_TERM"].ToString();
                modelLog.C_FREE_TERM2 = dr["C_FREE_TERM2"].ToString();
                modelLog.C_PACK = dr["C_PACK"].ToString();
                modelLog.C_AREA = dr["C_AREA"].ToString();
                modelLog.C_PCLX = dr["C_PCLX"].ToString();
                wgdDalLog.Add(modelLog);

                TransactionHelper.BeginTransaction();

                if (!wgdDal.UpdateRollStatus(modelLog.C_MAIN_ID, 0))
                {
                    TransactionHelper.RollBack();
                    return "0";
                }

                //if (!wgdDal.Delete(dr["C_ID"].ToString()))
                //{
                //    TransactionHelper.RollBack();
                //    return "0";
                //}

                //if (!wgdItemDal.Delete(dr["C_ID"].ToString()))
                //{
                //    TransactionHelper.RollBack();
                //    return "0";
                //}

                if (dal_TRC_WARM_FURNACE.UpdateWarmFurnaceRolleState(dr["C_MAIN_ID"].ToString(), 2, 3) == 0)
                {
                    TransactionHelper.RollBack();
                    return "0";
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
        /// 获取完工单记录
        /// </summary>
        /// <returns></returns>
        public DataSet GetWgdData(string staID, DateTime start, DateTime end, string stove)
        {
            return dal.GetWgdData(staID, start, end, stove);
        }

        /// <summary>
        /// 获取组坯已出炉轧钢记录
        /// </summary>
        /// <param name="strWhere">条件</param>
        /// <param name="IsOrderDesc">排序 </param>
        /// <returns></returns>
        public DataSet GetAssePutStoreData(string strWhere, bool IsOrderDesc)
        {
            return dal.GetAssePutStoreData(strWhere, IsOrderDesc);
        }

        /// <summary>
        /// 获取组坯已出炉轧钢记录
        /// </summary>
        /// <param name="strWhere">条件</param>
        /// <param name="IsOrderDesc">排序 </param>
        /// <returns></returns>
        public DataSet GetAssePutStoreData(string strWhere, bool IsOrderDesc, int status)
        {
            return dal.GetAssePutStoreData(strWhere, IsOrderDesc, status);
        }

        /// <summary>
        ///完工单条码回传信息
        /// </summary>
        /// <returns></returns>
        public DataSet GetWgdFinished(int status)
        {
            return dal.GetWgdFinished(status);
        }

        /// <summary>
        ///完工单条码回传信息
        /// </summary>
        /// <returns></returns>
        public DataTable GetWgdFinishedLoc(string staID, DataTable ids)
        {
            return dal.GetWgdFinishedLoc(staID, ids);
        }

        /// <summary>
        /// 更新上传状态
        /// </summary>
        /// <returns></returns>
        public int UpdateUpLoadStatus(string id, int status)
        {
            return dal.UpdateUpLoadStatus(id, status);
        }

        /// <summary>
        /// 更新上传状态
        /// </summary>
        /// <returns></returns>
        public int UpdateUpLoadStatus(int status, string id)
        {
            return dal.UpdateUpLoadStatus(status, id);
        }

        /// <summary>
        /// 获取线材入库实绩
        /// </summary>
        /// <param name="batchNo">批次号</param>
        /// <returns></returns>
        public DataSet GetWgdFact(string batchNo)
        {
            return dal.GetWgdFact(batchNo);
        }

        /// <summary>
        /// 获取线材入库实绩
        /// </summary>
        /// <param name="batchNo">批次号</param>
        /// <param name="type"></param>
        /// <returns></returns>
        public DataSet GetWgdFact(string batchNo, int type)
        {
            return dal.GetWgdFact(batchNo, type);
        }

        /// <summary>
        /// 获取线材入库实绩
        /// </summary>
        /// <param name="batchNo">批次号</param>
        /// <returns></returns>
        public DataSet GetWgdFactAttrDP(string batchNo)
        {
            return dal.GetWgdFactAttrDP(batchNo);
        }

        /// <summary>
        /// 更新上传状态
        /// </summary>
        /// <returns></returns>
        public int UpdateIfStatus(int status, string id, string remark)
        {
            return dal.UpdateIfStatus(status, id, remark);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        /// <param name="strBatchNo">批号</param>
        /// <returns></returns>
        public Mod_TRC_ROLL_WGD Get_WGD_Modle(string strBatchNo)
        {
            return dal.Get_WGD_Modle(strBatchNo);
        }

        /// <summary>
        /// 获取出炉时间
        /// </summary>
        /// <returns></returns>
        public object GetOutTime(string id)
        {
            return dal.GetOutTime(id);
        }

        /// <summary>
        /// 更新计划完工量
        /// </summary>
        /// <param name="id"></param>
        /// <param name="wgt"></param>
        /// <returns></returns>
        public bool UpdateRollPlanItemWgt(string id, decimal wgt)
        {
            return dal.UpdateRollPlanItemWgt(id, wgt);
        }

        /// <summary>
        /// 修改完工支数
        /// </summary>
        /// <param name="id"></param>
        /// <param name="qua">出炉支数</param>
        /// <param name="castOffQua">甩废</param>
        /// <param name="CuttingQua">切割</param>
        /// <param name="userID">用户ID</param>
        /// <returns></returns>
        public bool UpdateWgdQua(string id, decimal qua, decimal castOffQua, decimal CuttingQua, string userID, DateTime start, DateTime end)
        {
            return dal.UpdateWgdQua(id, qua, castOffQua, CuttingQua, userID, start, end);
        }

        /// <summary>
        /// 查询完工单信息
        /// </summary>
        /// <param name="strTime1">开始时间</param>
        /// <param name="strTime2">结束时间</param>
        /// <param name="strBatch">批号</param>
        /// <param name="strStaID">轧线ID</param>
        /// <returns></returns>
        public DataSet Get_WGD_List(string strTime1, string strTime2, string strBatch, string strStaID)
        {
            return dal.Get_WGD_List(strTime1, strTime2, strBatch, strStaID);
        }

        /// <summary>
        /// 撤销完工单状态
        /// </summary>
        /// <param name="batchNo"></param>
        /// <returns></returns>
        public bool BackWgd(string batchNo)
        {
            return dal.BackWgd(batchNo);
        }

        /// <summary>
        /// 完工单班次记录
        /// </summary>
        /// <returns></returns>
        public DataTable GetWgdBCJL(string rqStart, string rqEnd, string shift, string prodLine)
        {
            return dal.GetWgdBCJL(rqStart, rqEnd, shift, prodLine);
        }

        /// <summary>
        /// 获取产线
        /// </summary>
        /// <param name="codeLike">模糊查询产线编码字符串</param>
        /// <returns>获取工位表格</returns>
        public DataTable GetProdLine(string codeLike)
        {
            return dal.GetProdLine(codeLike);
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
        /// A2是否已传
        /// </summary>
        /// <param name="batchNO">批次号</param>
        /// <param name="commpany">公司编码</param>
        /// <returns></returns>
        public int IsA2Repeat(string batchNO, string commpany)
        {
            return dal.IsA2Repeat(batchNO, commpany);
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
        /// A4是否已传
        /// </summary>
        /// <param name="batchNO">批次号</param>
        /// <param name="commpany">公司编码</param>
        /// <returns></returns>
        public int IsA4Repeat(string batchNO, string commpany)
        {
            return dal.IsA4Repeat(batchNO, commpany);
        }

        /// <summary>
        /// 46是否已传
        /// </summary>
        /// <param name="batchNO">批次号</param>
        /// <param name="commpany">公司编码</param>
        /// <returns></returns>
        public int Is46Repeat(string batchNO, string commpany)
        {
            return dal.Is46Repeat(batchNO, commpany);
        }

        /// <summary>
        /// 删除线材
        /// </summary>
        /// <param name="ids">主键</param>
        /// <returns></returns>
        public int DelRollProduct(List<string> ids, string batchNo, string path)
        {

          

            TransactionHelper.BeginTransaction();
            decimal bWgt = dal.GetRollProductWgt(batchNo);
            string id = dal.GetRollMain(batchNo);
            string planId = "";

            if (dal.DelRollProduct(ids) <= 0)
            {
                TransactionHelper.RollBack();
                return 0;
            }

            NcRollA1 ncA1 = new NcRollA1();
            NcRollA2 ncA2 = new NcRollA2();
            NcRollA3 ncA3 = new NcRollA3();
            NcRollA4 ncA4 = new NcRollA4();
            int errorStatus = 4;
            string errorId = "";

            try
            {
                errorId = id;
                var wgd = dal.GetModel(id, 1);
                var plan = planDalItem.GetModel_Item(wgd.C_PLAN_ID);
                planId = wgd.C_PLAN_ID;
                var a1Sta = dal_TB_STA.GetModel(plan.C_STA_ID);
                var matrl = dal_TB_MATRL_MAIN.GetModel(plan.C_MAT_CODE);
                var main = dal_TRC_ROLL_MAIN.GetModel(id);
                var a2Sta = dal_TB_STA.GetModel(main.C_STA_ID);

                //DataTable factDt2 = dal.GetWgdFactAttrDP(wgd.C_BATCH_NO).Tables[0];
                //for (int j = 0; j < factDt2.Rows.Count; j++)
                //{
                //    string slabWh = dal_TPB_LINEWH.GetList_id(factDt2.Rows[j]["C_LINEWH_CODE"].ToString()).ToString();
                //    if (string.IsNullOrEmpty(slabWh))
                //    {
                //        return 0;
                //    }
                //}

                DataTable a4FactDt = dal.GetWgdFactTran(wgd.C_BATCH_NO, 1, ids).Tables[0];
                var a4M = dal_TB_MATRL_MAIN.GetModel(wgd.C_MAT_CODE);
                var a4Sta = dal_TB_STA.GetModel(wgd.C_STA_ID);
                ncA4.zdrid = RV.UI.UserInfo.userAccount;
                ncA4.rq = DateTime.Parse(wgd.D_PRODUCE_DATE_B == null ? DateTime.Now.ToString() : wgd.D_PRODUCE_DATE_B.ToString());
                ncA4.gzzxbmid = a4Sta.C_STA_ERPCODE;
                ncA4.scbmid = a4Sta.C_SSBMID;
                ncA4.pch = wgd.C_BATCH_NO;
                ncA4.wlbmid = a4M.C_PK_INVBASDOC;
                ncA4.jldwid = a4M.C_PK_MEASDOC;
                ncA4.gzzxid = a4Sta.C_ERP_PK;
                ncA4.ccxh = wgd.C_BATCH_NO;
                ncA4.pk_produce = a4M.C_PK_PRODUCE;
                ncA4.ksrq = DateTime.Parse(wgd.D_PRODUCE_DATE_B == null ? DateTime.Now.ToString() : wgd.D_PRODUCE_DATE_B.ToString());
                ncA4.jsrq = DateTime.Parse(wgd.D_PRODUCE_DATE_E == null ? DateTime.Now.ToString() : wgd.D_PRODUCE_DATE_E.ToString());
                ncA4.hgsl = a4FactDt.Rows[0]["WGT"].ToString();
                ncA4.fhgsl = a4FactDt.Rows[0]["QUA"].ToString();
                object wgdHandlerStatus = wgdHandlerDal.GetWgdHandlerStatus(wgd.C_ID);
                if (wgdHandlerStatus != null)
                {
                    string status = wgdHandlerStatus.ToString();
                    ncA4.sflfcp = int.Parse(status) == 2 ? "Y" : "N";
                    ncA4.sffsgp = int.Parse(status) == 2 ? "Y" : "N";
                }
                else
                {
                    ncA4.sflfcp = "N";
                    ncA4.sffsgp = "N";
                }
                ncA4.freeitemvalue1 = wgd.C_FREE_TERM;
                ncA4.freeitemvalue2 = wgd.C_FREE_TERM2;
                ncA4.freeitemvalue3 = wgd.C_PACK;
                string a4Name = Guid.NewGuid() + "_A4.xml";
                if (dal.IsA4Repeat(main.C_BATCH_NO, "") > 0)
                {
                    TransactionHelper.RollBack();
                    return 0;
                }
                var resultA4 = dal_Interface_NC_Roll_A4.SendXml_ROLL_A4("", a4Name, ncA4, path);
                if (resultA4[0] != "1")
                {
                    dal.UpdateIfStatus(4, id, resultA4[1]);
                    TransactionHelper.RollBack();
                    return 0;
                }

                errorStatus = 5;
                DataTable factDt = factDt = dal.GetWgdFactAttrDPTran(wgd.C_BATCH_NO, ids).Tables[0];
                List<NcRoll46> nc46s = new List<NcRoll46>();
                decimal wgdWgt = 0;
                for (int j = 0; j < factDt.Rows.Count; j++)
                {
                    NcRoll46 nc46 = new NcRoll46();
                    var a46M = dal_TB_MATRL_MAIN.GetModel(factDt.Rows[j]["C_MAT_CODE"].ToString());
                    nc46.cwarehouseid = dal_TPB_LINEWH.GetList_id(factDt.Rows[j]["C_LINEWH_CODE"].ToString()).ToString();
                    nc46.taccounttime = DateTime.Parse(wgd.D_MOD_DT == null ? DateTime.Now.ToString() : wgd.D_MOD_DT.ToString());
                    nc46.coperatorid = RV.UI.UserInfo.userAccount;
                    //if (wgd.C_MRSX == "DP")
                    //{ }
                    nc46.ccheckstate_bid = dal_TQB_CHECKSTATE.GetModelByName("DP", "1001").C_ID;
                    //else
                    //    nc46.ccheckstate_bid = bll_TQB_CHECKSTATE.GetModelByName(factDt.Rows[j]["C_JUDGE_LEV_BP"].ToString(), "1001").C_ID;
                    nc46.cworkcenterid = dal_TB_STA.Get_NC_ID(wgd.C_STA_ID);
                    nc46.dbizdate = DateTime.Parse(wgd.D_MOD_DT == null ? DateTime.Now.ToString() : wgd.D_MOD_DT.ToString());
                    nc46.vbatchcode = wgd.C_BATCH_NO;
                    nc46.cinvbasid = a46M.C_PK_INVBASDOC;
                    nc46.pk_produce = a46M.C_PK_PRODUCE;
                    nc46.ninnum = factDt.Rows[j]["WGT"].ToString();
                    nc46.ninassistnum = factDt.Rows[j]["QUA"].ToString();
                    nc46.castunitid = a46M.C_FJLDW;
                    nc46.vfree1 = factDt.Rows[j]["C_ZYX1"].ToString();
                    nc46.vfree2 = factDt.Rows[j]["C_ZYX2"].ToString();
                    nc46.vfree3 = factDt.Rows[j]["C_BZYQ"].ToString();
                    nc46s.Add(nc46);
                    wgdWgt += decimal.Parse(factDt.Rows[j]["WGT"].ToString());
                }
                string a46Name = Guid.NewGuid() + "_A46.xml";
                if (dal.Is46Repeat(main.C_BATCH_NO, "") > 0)
                {
                    TransactionHelper.RollBack();
                    return 0;
                }
                var resultA46 = dal_Interface_NC_Roll_46.SendXml_ROLL_46("", a46Name, nc46s, path);
                if (resultA46[0] != "1")
                {
                    dal.UpdateIfStatus(5, id, resultA46[1]);
                    TransactionHelper.RollBack();
                    return 0;
                }
                TransactionHelper.Commit();

            }
            catch (Exception ex)
            {
                TransactionHelper.RollBack();
                dal.UpdateIfStatus(errorStatus, errorId, ex.Message);
            }

            decimal eWgt = dal.GetRollProductWgt(batchNo);
            dal.UpdateRollPlanItemWgt(planId, bWgt, 1);
            dal.UpdateRollPlanItemWgt(planId, eWgt);
            return 1;
        }

        /// <summary>
        /// 获取上传NC明细
        /// </summary>
        /// <returns></returns>
        public DataTable GetSyncDetail(string id)
        {
            return dal.GetSyncDetail(id);
        }

        /// <summary>
        /// 未同步A3批次号
        /// </summary>
        /// <returns></returns>
        public DataTable GetNotA3(string status)
        {
            return dal.GetNotA3(status);
        }

            #endregion  ExtensionMethod
        }
}

