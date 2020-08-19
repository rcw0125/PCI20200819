using System;
using System.Data;
using System.Collections.Generic;
using DAL;
using MODEL;
namespace BLL
{
    /// <summary>
    /// 修磨计划
    /// </summary>
    public partial class Bll_TRC_PLAN_REGROUND
    {
        private readonly Dal_TRC_PLAN_REGROUND dal = new Dal_TRC_PLAN_REGROUND();
        private readonly Dal_TRC_PLAN_REGROUND_ITEM itemDal = new Dal_TRC_PLAN_REGROUND_ITEM();
        private readonly Dal_TRC_PLAN_REGROUND_HANDLER handlerDal = new Dal_TRC_PLAN_REGROUND_HANDLER();


        public Bll_TRC_PLAN_REGROUND()
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
        public bool Add(Mod_TRC_PLAN_REGROUND model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Mod_TRC_PLAN_REGROUND model)
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
        public Mod_TRC_PLAN_REGROUND GetModel(string C_ID)
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
        public DataSet GetList(string strWhere, string[] arr)
        {
            return dal.GetList(strWhere, arr);
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetListXm(string sqlWhere, string[] arr)
        {
            return dal.GetListXm(sqlWhere, arr);
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetListPw(string sqlWhere, string[] arr)
        {
            return dal.GetListPw(sqlWhere, arr);
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Mod_TRC_PLAN_REGROUND> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Mod_TRC_PLAN_REGROUND> DataTableToList(DataTable dt)
        {
            List<Mod_TRC_PLAN_REGROUND> modelList = new List<Mod_TRC_PLAN_REGROUND>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Mod_TRC_PLAN_REGROUND model;
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
        /// 获取可修磨钢坯
        /// </summary>
        /// <returns></returns>
        public DataSet GetWaitRegroudSlab(string[] slbwhCode, string sqlWhere)
        {
            return dal.GetWaitRegroudSlab(slbwhCode, sqlWhere);
        }

        /// <summary>
        /// 修磨计划
        /// </summary>
        /// <param name="stove">炉号</param>
        /// <param name="batchNo">批号</param>
        /// <param name="grd">钢种</param>
        /// <param name="spec">规格</param>
        /// <param name="std">执行标准</param>
        /// <param name="matCode">物料编码</param>
        /// <param name="matName">物料名称</param>
        /// <param name="len">长度</param>
        /// <param name="factNum">支数</param>
        /// <param name="reGroundWork">修磨工序</param>
        /// <param name="shift">班次</param>
        /// <param name="group">班组</param>
        /// <param name="remark">备注</param>
        /// <param name="slabwhCode">仓库编码</param>
        /// <param name="wgt">重量</param>
        /// <param name="grdXMGX"></param>
        /// <param name="store">仓库编码</param>
        /// <param name="area">区域编码</param>
        /// <param name="kw">库位</param>
        /// <param name="floor">层</param>
        /// <param name="dept">部门</param>
        /// <param name="slabArea">钢坯区域</param>
        /// <param name="slabLoc">钢坯地址</param>
        /// <param name="isxm">是否修磨</param>
        /// <param name="gx">标准</param>
        /// <param name="gw">工位</param>
        /// <param name="sl">砂轮</param>
        /// <returns></returns>
        public string CreateRegroundPlan(string stove, string batchNo, string grd,
            string spec, string std, string matCode, string matName, string len, string factNum,
            string reGroundWork, string shift, string group, string remark, string slabwhCode, decimal wgt
            , string grdXMGX, string store, string area, string kw, string floor, string dept, string slabArea, string slabLoc, string isxm
            , string gx, string gw, string sl,string xlloc,string emp)
        {


            DataTable dt = dal.GetWaitRegroudSlabs(slabwhCode, batchNo, stove, grd, spec, std, matCode, len, factNum, slabArea, slabLoc, isxm).Tables[0];

            string result = "1";
            TransactionHelper.BeginTransaction();
            try
            {
                Mod_TRC_PLAN_REGROUND reground = new Mod_TRC_PLAN_REGROUND();
                reground.C_ID = Guid.NewGuid().ToString();
                reground.C_BATCH_NO = batchNo;
                reground.C_STOVE = stove;
                reground.C_STL_GRD = grd;
                reground.C_MAT_CODE = matCode;
                reground.C_MAT_NAME = matName;
                reground.C_SPEC = spec;
                reground.N_LEN = decimal.Parse(len);
                reground.N_QUA = decimal.Parse(factNum);
                reground.N_WGT = wgt;
                reground.C_STD_CODE = std;
                reground.C_REMARK = remark;
                reground.C_XMGX = reGroundWork;
                var arr = reGroundWork.Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries);
                reground.N_TOTALSTEP = arr.Length;
                reground.N_QUA_VIRTUAL = decimal.Parse(factNum);
                reground.C_SLABWH_CODE = store;
                reground.C_SLABWH_AREA_CODE = area;
                reground.C_SLABWH_LOC_CODE = kw;
                reground.C_SLABWH_TIER_CODE = floor;
                reground.C_XMGX_GRD = grdXMGX;
                reground.C_SLAB_TYPE = dept;
                reground.C_EXTEND16 = gx;
                reground.C_EXTEND17 = gw;
                reground.C_EXTEND18 = sl;
                reground.C_EMP_CODE = emp;
                reground.C_SLABWH_XLLOC_CODE = xlloc;

                if (!dal.Add(reground))
                {
                    TransactionHelper.RollBack();
                    return "0";
                }


                if (dt == null || dt.Rows.Count == 0)
                {
                    TransactionHelper.RollBack();
                    return "0";
                }

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    for (int j = 0; j < arr.Length; j++)
                    {
                        Mod_TRC_PLAN_REGROUND_ITEM item = new Mod_TRC_PLAN_REGROUND_ITEM();
                        item.C_PLAN_REGROUND_ID = reground.C_ID;
                        item.C_SLAB_MAIN_ID = dt.Rows[i]["C_ID"].ToString();
                        item.N_TOTALSTEP = arr.Length;
                        item.N_STEP = j + 1;
                        item.N_STEPNAME = arr[j];
                        item.N_STATUS = item.N_STEP == 1 ? 1 : 0;
                        item.C_EMP_ID = RV.UI.UserInfo.userID;
                        if (!itemDal.Add(item))
                        {
                            TransactionHelper.RollBack();
                            return "0";
                        }
                    }
                }

                if (dal.UpdateSlabStatus(dt, "DX", "E", store, area, kw, floor) != int.Parse(factNum))
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
        /// 撤回修磨计划
        /// </summary>
        /// <param name="id">主键</param>
        /// <param name="slbwhCode">仓库编码</param>
        /// <param name="num">支数</param>
        /// <returns></returns>
        public string BackRegroundPlan(string id, string num, string slabCode)
        {
            string result = "1";
            TransactionHelper.BeginTransaction();
            try
            {
                DataTable dt = dal.GetRegroundSlab(id).Tables[0];
                if (dal.UpdateSlabStatus(dt, "E", "DX", slabCode, "", "", "") != int.Parse(num))
                {
                    TransactionHelper.RollBack();
                    return "0";
                }

                if (!dal.Delete(id))
                {
                    TransactionHelper.RollBack();
                    return "0";
                }

                if (!itemDal.Del(id))
                {
                    TransactionHelper.RollBack();
                    return "0";
                }

                handlerDal.Del(id);

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
        /// 修磨确认
        /// </summary>
        /// <param name="id">主键</param>
        ///  <param name="num">总支数</param>
        /// <param name="factNum">修磨支数</param>
        /// <param name="xmbz">修磨标准</param>
        /// <param name="sta">工位</param>
        /// <param name="remark">说明</param>
        /// <param name="emp">修磨人</param>
        /// <param name="hg">货管</param>
        /// <param name="batchNo">批次号</param>
        /// <param name="slbwhCode">仓库编码</param>
        /// <param name="grinWheel">砂轮</param>
        /// <returns></returns>
        public string RegroundConfirm(string id, string num, string factNum, string xmbz,
            string sta, string remark, string emp, string hg, string batchNo, string quality, string hw,
            string slbwhCode, string grinWheel, string group, string shift, DateTime operation, string area)
        {
            string result = "1";
            TransactionHelper.BeginTransaction();
            try
            {
                Mod_TRC_PLAN_REGROUND_HANDLER model = new Mod_TRC_PLAN_REGROUND_HANDLER();
                model.C_REGROUND_ID = id;
                model.C_EMP_NAME = emp;
                model.C_STA_ID = sta;
                model.C_XMBZ = xmbz;
                model.N_TOTAL_QUA = int.Parse(num);
                model.N_QUA = int.Parse(factNum);
                model.C_BATCH_NO = batchNo;
                model.C_QUALITY = quality;
                model.C_HW = hw;
                model.C_HG = hg;
                model.N_STATUS = 1;
                model.C_CAUSE = remark;
                model.C_GRINDING_WHEEL = grinWheel;
                model.C_SHIFT = shift;
                model.C_GROUP = group;
                model.D_DT = operation;
                if (!handlerDal.Add(model))
                {
                    TransactionHelper.RollBack();
                    return "0";
                }


                string columnName = "";
                if (area == "1")
                {
                    columnName = General.NameType[xmbz];
                }
                else
                {
                    columnName = General.NameTypes[xmbz];
                }

                if (!dal.UpdateRegroundProcedure(id, columnName, int.Parse(factNum), 1))
                {
                    TransactionHelper.RollBack();
                    return "0";
                }

                TransactionHelper.Commit();

                dal.UpdateRegroundType();

            }
            catch (Exception ex)
            {
                TransactionHelper.RollBack();
                return "0";
            }
            return result;
        }

        /// <summary>
        /// 获取修磨操作记录
        /// </summary>
        /// <param name="status">状态 1修磨 2抛丸探伤</param>
        /// <param name="id"></param>
        /// <returns></returns>
        public DataSet GetRegroundHandler(int status, string id)
        {
            return dal.GetRegroundHandler(status, id);
        }

        /// <summary>
        /// 获取修磨操作记录
        /// </summary>
        /// <param name="status">状态 1修磨 2抛丸探伤</param>
        /// <param name="id"></param>
        /// <returns></returns>
        public DataSet GetRegroundHandler(string id)
        {
            return dal.GetRegroundHandler(id);
        }

        /// <summary>
        /// 完成
        /// </summary>
        /// <param name="id">计划主键</param>
        /// <param name="factNum">完成支数</param>

        /// <param name="typeName">工序类型 修磨 抛丸探伤</param>
        /// <returns></returns>
        public string Accomplish(string id, string factNum, string typeName)
        {
            string result = "1";
            TransactionHelper.BeginTransaction();
            try
            {
                DataTable execDt = dal.GetRegroundStep(id, int.Parse(factNum), typeName).Tables[0];
                var regournd = dal.GetModel(id);

                if (execDt == null || execDt.Rows.Count == 0)
                {
                    TransactionHelper.RollBack();
                    return "0";
                }

                foreach (DataRow dr in execDt.Rows)
                {
                    string slabID = dr["C_SLAB_MAIN_ID"].ToString();
                    int step = Convert.ToInt32(dr["N_STEP"].ToString()) + 1;
                    DataTable nextDt = dal.GetRegroundNextStep(slabID, step, id).Tables[0];
                    //更新当前步骤状态
                    if (dal.UpdateRegroundStepStatus(dr["C_ID"].ToString(), 2) == 0)
                    {
                        TransactionHelper.RollBack();
                        return "0";
                    }
                    //更新下一步骤状态
                    if (nextDt != null && nextDt.Rows.Count > 0)
                    {
                        DataRow nextDr = nextDt.Rows[0];
                        if (dal.UpdateRegroundStepStatus(nextDr["C_ID"].ToString(), 1) == 0)
                        {
                            TransactionHelper.RollBack();
                            return "0";
                        }
                    }
                    else
                    {
                        //更新钢坯库库位 状态
                        if (dal.UpdateSlabStatus(slabID, "E", "DX") == 0)
                        {
                            TransactionHelper.RollBack();
                            return "0";
                        }
                    }
                }

                if (!dal.UpdateRegroundType(id, 3))
                {
                    TransactionHelper.RollBack();
                    return "0";
                }

                TransactionHelper.Commit();

                if (dal.CheckRegroundIsAllSet(id))
                {
                    dal.UpdatePlanRegroundStatus(id);
                    //if (execDt != null && execDt.Rows.Count > 0)
                    //{
                    //    dal.UpdatePlanSms(regournd.C_STOVE, (int)regournd.N_QUA, regournd.N_WGT.Value, regournd.D_Q_DATE, DateTime.Now, 1);
                    //}
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
        /// 剔除
        /// </summary>
        /// <param name="id">计划主键</param>
        /// <param name="factNum">完成支数</param>
        /// <param name="typeName">工序类型 修磨 抛丸探伤</param>
        /// <param name="remark">备注</param>
        /// <param name="slabCode">仓库</param>
        /// <returns></returns>
        public string Elim(string id, string factNum, string typeName, string remark, string slabCode)
        {
            string result = "1";
            TransactionHelper.BeginTransaction();
            try
            {
                DataTable execDt = dal.GetRegroundStep(id, int.Parse(factNum), typeName).Tables[0];
                var regournd = dal.GetModel(id);

                if (execDt == null || execDt.Rows.Count == 0)
                {
                    TransactionHelper.RollBack();
                    return "0";
                }

                foreach (DataRow dr in execDt.Rows)
                {
                    string slabID = dr["C_SLAB_MAIN_ID"].ToString();

                    //更新钢坯库库位 状态
                    if (dal.ElimSlabStatus(slabID, "E", "DX", remark, slabCode) == 0)
                    {
                        TransactionHelper.RollBack();
                        return "0";
                    }

                    if (!dal.ElimRegroundItem(id, slabID))
                    {
                        TransactionHelper.RollBack();
                        return "0";
                    }

                }


                if (!dal.ElimReground(id, int.Parse(factNum), remark))
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
        /// 探伤确认
        /// </summary>
        /// <param name="id">主键</param>
        /// <param name="num">总支数</param>
        /// <param name="factNum">探伤支数</param>
        /// <param name="notNum">未探支数</param>
        /// <param name="notBz">不合格原因</param>
        /// <param name="sta">工位</param>
        /// <param name="remark">备注</param>
        /// <param name="emp">探伤人</param>
        /// <param name="batchNo">批号</param>
        /// <param name="hw">货位</param>
        /// <param name="slbwhCode">仓库编号</param>
        /// <param name="notCause">未探原因</param>
        /// <returns></returns>
        public string ShotBlastingConfirm(string id, string num, string factNum, string notNum, string notBz,
            string sta, string remark, string emp, string batchNo, string hw, string notCause, string group, string shift, DateTime operation)
        {
            string result = "1";
            TransactionHelper.BeginTransaction();
            try
            {
                Mod_TRC_PLAN_REGROUND_HANDLER model = new Mod_TRC_PLAN_REGROUND_HANDLER();
                model.C_REGROUND_ID = id;
                model.C_EMP_NAME = emp;
                model.C_STA_ID = sta;
                model.C_XMBZ = notBz;
                model.N_TOTAL_QUA = int.Parse(num);
                model.N_QUA = int.Parse(factNum);
                model.C_BATCH_NO = batchNo;
                model.C_HW = hw;
                model.C_REMARK = remark;
                model.N_STATUS = 2;
                model.N_NOT_QUA = int.Parse(notNum);
                model.C_CAUSE = notCause;
                model.C_GROUP = group;
                model.C_SHIFT = shift;
                model.D_DT = operation;

                if (!handlerDal.Add(model))
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
        /// 获取修磨工位信息
        /// </summary>
        /// <returns></returns>
        public DataSet GetStaInfo()
        {
            return dal.GetStaInfo();
        }

        /// <summary>
        /// 获取抛丸工位信息
        /// </summary>
        /// <returns></returns>
        public DataSet GetStaInfo(int type)
        {
            return dal.GetStaInfo(1);
        }

        /// <summary>
        /// 删除修磨记录
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public string DelRegroundHandler(string id, string regroundid, string xmbz, string qua)
        {
            string result = "1";
            TransactionHelper.BeginTransaction();
            try
            {
                string columnName = General.NameType[xmbz];
                if (!dal.DelRegroundHandler(id))
                    return "0";
                if (!dal.UpdateRegroundProcedure(regroundid, columnName, int.Parse(qua), 2))
                    return "0";
                TransactionHelper.Commit();
                dal.UpdateRegroundType();
            }
            catch (Exception ex)
            {
                TransactionHelper.RollBack();
                return "0";
            }
            dal.ResetRegroundQua();
            return result;
        }

        #endregion  ExtensionMethod
    }
}
