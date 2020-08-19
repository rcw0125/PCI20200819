using System;
using System.Data;
using System.Collections.Generic;
using DAL;
using MODEL;
namespace BLL
{
    /// <summary>
    /// 坯料主表
    /// </summary>
    public partial class Bll_TSC_SLAB_MAIN
    {
        private readonly Dal_TSC_SLAB_MAIN dal = new Dal_TSC_SLAB_MAIN();
        Dal_TSC_ALLOT_LOG logDal = new Dal_TSC_ALLOT_LOG();
        Dal_TSC_ALLOT_CENTER centerDal = new Dal_TSC_ALLOT_CENTER();


        public Bll_TSC_SLAB_MAIN()
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
        public bool Add(Mod_TSC_SLAB_MAIN model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Mod_TSC_SLAB_MAIN model)
        {
            return dal.Update(model);
        }
        /// <summary>
        /// 更新一条数据_炉号
        /// </summary>
        public bool Update_Stove_Trans(string stove)
        {
            return dal.Update_Stove_Trans(stove);
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
        public Mod_TSC_SLAB_MAIN GetModel(string C_ID)
        {

            return dal.GetModel(C_ID);
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        /// <param name="begin">开始时间</param>
        /// <param name="end">结束时间</param>
        /// <param name="STA">铸机号</param>
        /// <param name="Stove">炉号</param>
        /// <returns></returns>
        public DataSet GetList_Query(DateTime begin, DateTime end, string STA, string Stove)
        {
            return dal.GetList_Query(begin, end, STA, Stove);
        }
        /// <summary>
        ///  获得数据列表-库检
        /// </summary>
        /// <param name="begin">开始时间</param>
        /// <param name="end">结束时间</param>
        /// <param name="stl">钢种</param>
        /// <param name="spec">断面</param>
        /// <param name="stove">炉号</param>
        /// <returns></returns>
        public DataSet GetList_Stove(string begin, string end, string stl, string spec, string stove)
        {
            return dal.GetList_Stove(begin, end, stl, spec, stove);
        }
        /// <summary>
        /// 根据库位 查询
        /// </summary>
        /// <param name="c_slabwh_loc_code"></param>
        /// <returns></returns>
        public DataSet GetList_LocNum(string c_slabwh_loc_code)
        {
            return dal.GetList_LocNum(c_slabwh_loc_code);
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        /// <param name="c_sta_id">铸机号</param>
        /// <param name="cou">支数</param>
        /// <returns></returns>
        public DataSet GetList_count(string c_sta_id, string c_stove, string c_stl_grd, string c_spec, string n_len, string c_std_code, string c_mat_code, string c_mat_name, int cou)
        {
            return dal.GetList_count(c_sta_id, c_stove, c_stl_grd, c_spec, n_len, c_std_code, c_mat_code, c_mat_name, cou);
        }
        /// <summary>
        /// 获得数据列表-炉号
        /// </summary>
        /// <param name="stove">炉号</param>
        /// <param name="begin">开始时间</param>
        /// <param name="end">结束时间</param>
        /// <returns></returns>
        public DataSet GetList_Stove1(DateTime begin, DateTime end, string stove)
        {
            return dal.GetList_Stove1(begin, end, stove);
        }
        /// <summary>
        /// 获得数据列表-炉号
        /// </summary>
        /// <param name="stove">炉号</param> 
        /// <returns></returns>
        public DataSet GetList_StoveYCGP(string stove)
        {
            return dal.GetList_StoveYCGP(stove);
        }

        /// <summary>
        /// 获得数据列表-炉号
        /// </summary>
        /// <param name="stove">炉号</param>
        /// <param name="begin">开始时间</param>
        /// <param name="end">结束时间</param>
        /// <returns></returns>
        public DataSet GetList_StoveBetween(DateTime begin, DateTime end, string stove, string stoveEnd)
        {
            return dal.GetList_StoveBetween(begin, end, stove, stoveEnd);
        }

        /// <summary>
        /// 获得数据列表-炉号
        /// </summary>
        /// <param name="stove">炉号</param> 
        /// <returns></returns>
        public DataSet GetList_Stove2(string stove)
        {
            return dal.GetList_Stove2(stove);
        }

        /// <summary>
        /// 获得数据列表-炉号-库位
        /// </summary>
        /// <param name="stove">炉号</param>
        /// <param name="C_SLABWH_AREA_CODE">区域</param>
        /// <returns></returns>
        public DataSet GetList_LH_KW(string stove, string C_SLABWH_AREA_CODE)
        {
            return dal.GetList_LH_KW(stove, C_SLABWH_AREA_CODE);
        }
        /// <summary>
        /// 获得数据列表-炉号-库位
        /// </summary>
        /// <param name="C_SLABWH_CODE">仓库</param>
        /// <param name="C_SLABWH_LOC_CODE">库位</param>
        /// <returns></returns>
        public DataSet GetList_KW(string C_SLABWH_CODE, string C_SLABWH_LOC_CODE)
        {
            return dal.GetList_KW(C_SLABWH_CODE, C_SLABWH_LOC_CODE);

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
        public DataSet GetList_WLGP(DateTime begin, DateTime end, string str_Stove, string str_STLGRD)
        {
            return dal.GetList_WLGP(begin, end, str_Stove, str_STLGRD);

        }
        /// <summary>
        /// 根据炉号 查询
        /// </summary>
        /// <param name="stove"></param>
        /// <returns></returns>
        public DataSet GetList_stove(string stove)
        {
            return dal.GetList_stove(stove);
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Mod_TSC_SLAB_MAIN> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Mod_TSC_SLAB_MAIN> DataTableToList(DataTable dt)
        {
            List<Mod_TSC_SLAB_MAIN> modelList = new List<Mod_TSC_SLAB_MAIN>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Mod_TSC_SLAB_MAIN model;
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
        /// 查询钢坯综合判定数据
        /// </summary>
        /// <param name="stove">炉号</param>
        /// <param name="strTime1">生产开始时间</param>
        /// <param name="strTime2">生产结束时间</param>
        /// <returns></returns>
        public DataSet GetList(string stove, string strTime1, string strTime2)
        {
            return dal.GetList(stove, strTime1, strTime2);
        }

        /// <summary>
        /// 获取钢坯实绩库存数
        /// </summary>
        /// <param name="c_slabwh_code">仓库编码</param>
        /// <returns></returns>
        public DataSet Get_KC_COUNt(string c_slabwh_code)
        {
            return dal.Get_KC_COUNt(c_slabwh_code);
        }

        #endregion  BasicMethod
        #region  ExtensionMethod
        /// <summary>
        ///根据判定情况，钢坯状态获取数据列表
        /// </summary>
        public DataSet GetList(string slabid, string C_SC_STATE, string C_MOVE_TYPE, string C_STOCK_STATE, string C_STOVE, string C_STL_GRD, string C_STD_CODE, string type, string C_SLABWH_CODE)
        {
            return dal.GetList(slabid, C_SC_STATE, C_MOVE_TYPE, C_STOCK_STATE, C_STOVE, C_STL_GRD, C_STD_CODE, type, C_SLABWH_CODE);
        }
        /// <summary>
        /// 根据发运单号获取数据
        /// </summary>
        /// <param name="C_FYDH">发运单号</param>
        /// <param name="C_MOVE_TYPE">状态</param>
        /// <param name="C_STOVE">炉号</param>
        /// <param name="C_BATCH_NO">批号</param>
        /// <param name="C_SLABWH_CODE">仓库</param>
        /// <returns></returns>
        public DataSet GetListByFYDH(string C_FYDH, string C_MOVE_TYPE, string C_STOVE, string C_BATCH_NO, string C_SLABWH_CODE)
        {
            return dal.GetListByFYDH(C_FYDH, C_MOVE_TYPE, C_STOVE, C_BATCH_NO, C_SLABWH_CODE);
        }

        /// <summary>
        /// 获取可轧钢坯库存
        /// </summary>
        /// <param name="C_STOVE">炉号</param>
        /// <param name="C_BATCH_NO">批号</param>
        /// <param name="C_STL_GRD">钢种</param>
        /// <param name="C_STD_CODE">执行标准</param>
        /// <returns></returns>
        public DataTable GetKZgp(string C_STOVE, string C_BATCH_NO, string C_STL_GRD, string C_STD_CODE)
        {
            return dal.GetKZgp(C_STOVE, C_BATCH_NO, C_STL_GRD, C_STD_CODE);
        }
        /// <summary>
        /// 获取钢坯库存数据
        /// </summary>
        /// <param name="C_MOVE_TYPE">状态</param>
        /// <param name="C_STOVE">炉号</param>
        /// <param name="C_MAT_CODE">物料号</param>
        /// <param name="C_STD_CODE">执行标准</param>
        /// <param name="C_SLABWH_CODE">仓库</param>
        /// <param name="C_BATCH_NO">开坯号</param>
        /// <param name="C_JUDGE_LEV_ZH">质量等级</param>
        /// <returns></returns>
        public DataSet GetList(string C_MOVE_TYPE, string C_STOVE, string C_MAT_CODE, string C_STD_CODE, string C_SLABWH_CODE, string C_BATCH_NO, string C_JUDGE_LEV_ZH)
        {
            return dal.GetList(C_MOVE_TYPE, C_STOVE, C_MAT_CODE, C_STD_CODE, C_SLABWH_CODE, C_BATCH_NO, C_JUDGE_LEV_ZH);
        }
        /// <summary>
        /// 钢坯库存状态
        /// </summary>
        /// <param name="C_MOVE_TYPE">库存状态</param>
        /// <param name="C_STOCK_STATE"></param>
        /// <param name="C_STOVE"></param>
        /// <param name="C_STL_GRD"></param>
        /// <param name="C_STD_CODE"></param>
        /// <returns></returns>
        public DataSet GetList(string C_MOVE_TYPE, string C_STOCK_STATE, string C_STOVE, string C_STL_GRD, string C_STD_CODE)
        {
            return dal.GetList(C_MOVE_TYPE, C_STOCK_STATE, C_STOVE, C_STL_GRD, C_STD_CODE);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(string id, string status, string ck, string qy, string kw, string c)
        {
            return dal.Update(id, status, ck, qy, kw, c);
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(string id, string status, string ck, string qy, string kw, string c, string C_SC_STATE, DateTime D_ESC_DATE, DateTime D_LSC_DATE)
        {
            return dal.Update(id, status, ck, qy, kw, c, C_SC_STATE, D_ESC_DATE, D_LSC_DATE);
        }


        /// <summary>
        /// 获取可组批钢坯
        /// </summary>
        ///  <param name="ordergrd">原计划钢种</param>
        ///  <param name="orderstd">原计划标准</param>
        /// <param name="replaceGrd">可代轧钢种、执行标准</param>
        /// <param name="grd">钢种</param>
        /// <param name="std">执行标准</param>
        /// <param name="stove">炉号</param>
        /// <param name="slbwhCode">待轧钢坯仓库库位编码</param>
        /// <param name="length">长度</param>
        /// <returns></returns>
        public DataSet GetRepalceStl(string ordergrd, string orderstd, DataTable replaceGrd, string grd, string std, string spec, string stove, string length, string matCode, string slbwhCode)
        {
            return dal.GetRepalceStl(ordergrd, orderstd, replaceGrd, grd, std, spec, stove, length, matCode, slbwhCode);
        }

        /// <summary>
        /// 获取开坯可组批钢坯
        /// </summary>
        /// <param name="grd">物料编码</param>
        /// <param name="std">执行标准</param>
        /// <param name="stove">炉号</param>
        /// <param name="slbwhCode">待轧钢坯仓库库位编码</param>
        /// <returns></returns>
        public DataSet GetRepalceStl(string matCode, string std, string spec, string length, string stove, string slbwhCode)
        {
            return dal.GetRepalceStl(matCode, std, spec, length, stove, slbwhCode);
        }


        /// <summary>
        /// 获取钢坯明细
        /// </summary>
        /// <param name="grd">钢种</param>
        /// <param name="std">执行标准</param>
        /// <param name="stove">炉号</param>
        /// <param name="asseNum">组批支数</param>
        /// <returns></returns>
        public DataSet GetRepalceStl(string grd, string std, string stove, int asseNum)
        {
            return dal.GetRepalceStl(grd, std, stove, asseNum);
        }

        /// <summary>
        ///根据判定情况，钢坯状态获取数据列表
        /// </summary>
        public DataSet GetList_ZPID(string slabid, string C_SC_STATE, string C_MOVE_TYPE, string C_STOCK_STATE, string C_STOVE, string C_STL_GRD, string C_STD_CODE, string type, string C_SLABWH_CODE, int N_ZS, string C_STA_ID)
        {
            return dal.GetList_ZPID(slabid, C_SC_STATE, C_MOVE_TYPE, C_STOCK_STATE, C_STOVE, C_STL_GRD, C_STD_CODE, type, C_SLABWH_CODE, N_ZS, C_STA_ID);
        }

        /// <summary>
        /// 获取调拨数据
        /// </summary>
        /// <param name="staID"></param>
        /// <returns></returns>
        public DataSet GetAllotData(string staID)
        {
            return dal.GetAllotData(staID);
        }

        /// <summary>
        /// 获取调拨数据
        /// </summary>
        /// <param name="staID"></param>
        /// <returns></returns>
        public DataSet GetAllotData(string staID, int type)
        {
            return dal.GetAllotCenterData(staID, type);
        }

        /// <summary>
        /// 调拨处理
        /// </summary>
        /// <returns></returns>
        public string AllotHandler(string staID, string stove, string grd, string spec, string std,
            string matCode, int num, string slabwhCode, string shift, string group)
        {
            string result = "1";
            try
            {

                TransactionHelper.BeginTransaction();

                DataTable billet = new DataTable();
                if (dal.AllotGrdType(staID, stove, grd, spec, std, matCode, num, slabwhCode, shift, group, out billet) != num)
                {
                    TransactionHelper.RollBack();
                    return "0";
                }



                if (billet != null && billet.Rows.Count > 0)
                {
                    DateTime time = DateTime.Now;
                    foreach (DataRow item in billet.Rows)
                    {
                        Mod_TSC_ALLOT_CENTER model = new Mod_TSC_ALLOT_CENTER();
                        model.C_STL_GRD = grd;
                        model.C_SPEC = spec;
                        model.C_STD_CODE = std;
                        model.C_MAT_CODE = matCode;
                        model.C_STOVE = stove;
                        model.C_SLAB_MAIN_ID = item["C_ID"].ToString();
                        model.C_SLABWH_CODE = slabwhCode;
                        model.C_STA_ID = staID;
                        model.N_TYPE = 1;
                        model.D_MOD_DT = time;
                        model.C_EMP_ID = RV.UI.UserInfo.userID;
                        if (!centerDal.Add(model))
                        {
                            TransactionHelper.RollBack();
                            return "0";
                        }
                    }

                    foreach (DataRow item in billet.Rows)
                    {
                        Mod_TSC_ALLOT_LOG model = new Mod_TSC_ALLOT_LOG();
                        model.C_STL_GRD = grd;
                        model.C_SPEC = spec;
                        model.C_STD_CODE = std;
                        model.C_MAT_CODE = matCode;
                        model.C_STOVE = stove;
                        model.C_SLAB_MAIN_ID = item["C_ID"].ToString();
                        model.C_SLABWH_CODE = slabwhCode;
                        model.C_STA_ID = staID;
                        model.N_TYPE = 1;
                        model.D_MOD_DT = time;
                        model.C_EMP_ID = RV.UI.UserInfo.userID;
                        if (!logDal.Add(model))
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
        /// 根据发运单号获取已做实绩数量
        /// </summary>
        /// <param name="fydh">发运单号</param>
        /// <returns></returns>
        public int GetSJCount(string fydh)
        {
            return dal.GetSJCount(fydh);
        }
        /// <summary>
        ///撤销调拨处理
        /// </summary>
        /// <returns></returns>
        public string BackAllotHandler(string staID, string stove, string grd, string spec, string std,
        string matCode, int num)
        {
            string result = "1";
            try
            {
                TransactionHelper.BeginTransaction();

                DataTable billet = new DataTable();
                if (dal.BackAllotGrdType(staID, stove, grd, spec, std, matCode, num, out billet) != num)
                {
                    TransactionHelper.RollBack();
                    return "0";
                }

                if (dal.BackAllotUpdateCenter(billet) != num)
                {
                    TransactionHelper.RollBack();
                    return "0";
                }

                if (billet != null && billet.Rows.Count > 0)
                {
                    DateTime time = DateTime.Now;
                    foreach (DataRow item in billet.Rows)
                    {
                        Mod_TSC_ALLOT_LOG model = new Mod_TSC_ALLOT_LOG();
                        model.C_STL_GRD = grd;
                        model.C_SPEC = spec;
                        model.C_STD_CODE = std;
                        model.C_MAT_CODE = matCode;
                        model.C_STOVE = stove;
                        model.C_SLAB_MAIN_ID = item["C_ID"].ToString();
                        model.C_STA_ID = staID;
                        model.N_TYPE = 3;
                        model.D_MOD_DT = time;
                        model.C_EMP_ID = RV.UI.UserInfo.userID;
                        if (!logDal.Add(model))
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
        /// 获取入库数据
        /// </summary>
        /// <param name="slabwhCode">仓库编码</param>
        /// <param name="grd">钢种</param>
        /// <param name="std">执行标准</param>
        /// <param name="spec">规格</param>
        /// <returns></returns>
        public DataSet GetPutData(string slabwhCode, string grd, string std, string spec)
        {
            return dal.GetAllotData(slabwhCode, grd, std, spec);
        }


        /// <summary>
        /// 入库处理
        /// </summary>
        /// <param name="stove">炉号</param>
        /// <param name="num">支数</param>
        /// <param name="grd">钢种</param>
        /// <param name="std">执行标准</param>
        /// <param name="spec">规格</param>
        /// <param name="matCode">物料编码</param>
        /// <param name="area">区域</param>
        /// <param name="loc">库位</param>
        /// <param name="tier">层</param>
        /// <param name="shift">班次</param>
        /// <param name="group">班组</param>
        /// <param name="slabwhCode">仓库编码</param>
        /// <returns></returns>
        public string PutStoreHandler(string stove, int num, string grd, string std, string spec,
            string matCode, string area, string loc, string tier, string shift, string group, string slabwhCode)
        {
            string result = "1";
            DataTable dt = dal.GetPutData(stove, num, grd, std, spec, matCode, slabwhCode).Tables[0];

            try
            {
                TransactionHelper.BeginTransaction();

                if (dt == null && dt.Rows.Count == 0)
                {
                    return "0";
                }

                if (dal.AllotPutUpdateCenter(dt, slabwhCode, area, loc, tier) != num)
                {
                    TransactionHelper.RollBack();
                    return "0";
                }

                if (dal.AllotPutUpdateSlab(dt, slabwhCode, area, loc, tier, shift, group) != num)
                {
                    TransactionHelper.RollBack();
                    return "0";
                }

                DateTime time = DateTime.Now;
                foreach (DataRow item in dt.Rows)
                {
                    Mod_TSC_ALLOT_LOG model = new Mod_TSC_ALLOT_LOG();
                    model.C_STL_GRD = grd;
                    model.C_SPEC = spec;
                    model.C_STD_CODE = std;
                    model.C_MAT_CODE = matCode;
                    model.C_STOVE = stove;
                    model.C_SLAB_MAIN_ID = item["C_SLAB_MAIN_ID"].ToString();
                    model.N_TYPE = 2;
                    model.D_MOD_DT = time;
                    model.C_EMP_ID = RV.UI.UserInfo.userID;
                    if (!logDal.Add(model))
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
        /// 入库信息
        /// </summary>
        /// <param name="slabwhCode"></param>
        /// <returns></returns>
        public DataSet GetPutData(string slabwhCode, DateTime start, DateTime end)
        {
            return dal.GetPutData(slabwhCode, start, end);
        }

        /// <summary>
        /// 获取需要分库的钢坯数据
        /// </summary>
        /// <param name="staID">连铸工位ID</param>
        /// <param name="strGZ">钢种</param>
        /// <param name="strStove">炉号</param>
        /// <param name="strGG">规格</param>
        /// <param name="strTimeStart">开始时间</param>
        /// <param name="strTimeEnd">结束时间</param>
        /// <returns></returns>
        public DataSet Get_FK_List(string staID, string strGZ, string strStove, string strGG, string strTimeStart, string strTimeEnd)
        {
            return dal.Get_FK_List(staID, strGZ, strStove, strGG, strTimeStart, strTimeEnd);
        }

        /// <summary>
        /// 获取调拨的钢坯数据
        /// </summary>
        /// <param name="strGZ">钢种</param>
        /// <param name="strStove">炉号</param>
        /// <param name="strGG">规格</param>
        /// <param name="strKW">库位</param>
        /// <param name="strTimeStart">开始时间</param>
        /// <param name="strTimeEnd">结束时间</param>
        /// <returns></returns>
        public DataSet Get_DB_List(string strGZ, string strStove, string strGG, string strKW, string strTimeStart, string strTimeEnd)
        {
            return dal.Get_DB_List(strGZ, strStove, strGG, strKW, strTimeStart, strTimeEnd);
        }

        /// <summary>
        /// 获取库存钢坯数据
        /// </summary>
        /// <param name="slabwhCode">仓库代码</param>
        /// <param name="strGZ">钢种</param>
        /// <param name="strStove">炉号</param>
        /// <param name="strGG">规格</param>
        /// <param name="strTimeStart">开始时间</param>
        /// <param name="strTimeEnd">结束时间</param>
        /// <returns></returns>
        public DataSet Get_KC_List(string slabwhCode, string strGZ, string strStove, string strGG, string strTimeStart, string strTimeEnd)
        {
            return dal.Get_KC_List(slabwhCode, strGZ, strStove, strGG, strTimeStart, strTimeEnd);
        }

        /// <summary>
        /// 获取库存钢坯数据(倒垛)
        /// </summary>
        /// <param name="slabwhCode">仓库代码</param>
        /// <param name="strGZ">钢种</param>
        /// <param name="strStove">炉号</param>
        /// <param name="strGG">规格</param>
        /// <param name="strTimeStart">开始时间</param>
        /// <param name="strTimeEnd">结束时间</param>
        /// <returns></returns>
        public DataSet Get_DD_KC_List(string slabwhCode, string strGZ, string strStove, string strGG, string strTimeStart, string strTimeEnd)
        {
            return dal.Get_DD_KC_List(slabwhCode, strGZ, strStove, strGG, strTimeStart, strTimeEnd);
        }
        /// <summary>
        /// 获取缓冷坑理论出坑时间
        /// </summary>
        /// <param name="slablocCode">货位</param>
        /// <returns></returns>
        public DataSet Get_DB_HL_TIME(string slablocCode)
        {
            return dal.Get_DB_HL_TIME(slablocCode);
        }
        /// <summary>
        /// 钢坯改判
        /// </summary>
        /// <param name="row">选中的数据</param>
        /// <param name="strGrd">钢种</param>
        /// <param name="strStdCode">执行标准</param>
        /// <param name="strMatCode">物料编码</param>
        /// <param name="strMatName">物料描述</param>
        /// <param name="strZrdwID">责任单位代码</param>
        /// <param name="strZrdwName">责任代为描述</param>
        /// <param name="strPDDJ">判定等级</param>
        /// <param name="strRemark">备注</param>
        /// <param name="strUrl">地址</param>
        /// <param name="strZYX1">自由项1</param>
        /// <param name="strZYX2">自由项2</param>
        /// <param name="strGPYY">改判原因</param>
        /// <param name="strLen">定尺</param>
        /// <returns></returns>
        public string GP_Slab(string strs, string strGrd, string strStdCode, string strMatCode, string strMatName, string strZrdwID, string strZrdwName, string strPDDJ, string strRemark, string strUrl, string strZYX1, string strZYX2, string strGPYY, string strLen)
        {
            string result = "1";
            try
            {
                Dal_TSC_SLAB_MAIN dal_slab = new Dal_TSC_SLAB_MAIN();
                Dal_TQC_SLAB_COMMUTE dal_commute = new Dal_TQC_SLAB_COMMUTE();
                Dal_Interface_NC_SLAB_KC4N dal_interface = new Dal_Interface_NC_SLAB_KC4N();
                Dal_TPB_LGGYK dalTpbLggyk = new Dal_TPB_LGGYK();
                Dal_TMO_ORDER dalTmoOrder = new Dal_TMO_ORDER();
                Dal_TQD_DESIGN dalDesign = new Dal_TQD_DESIGN();
                Dal_TB_STD_CONFIG dalTbStdConfig = new Dal_TB_STD_CONFIG();

                TransactionHelper.BeginTransaction();

                string strUserID = RV.UI.UserInfo.userID;
                DateTime time = RV.UI.ServerTime.timeNow();
                string stove = "";
                string max_C_MASTER_ID = "";
                string max_C_GP_BEFORE_ID = "";
                string max_C_GP_AFTER_ID = "";
                string slabCode = "";
                string strLGJH = "";
                string strDesignNo = dalDesign.Get_Design_No(strStdCode, strGrd);
                if (string.IsNullOrEmpty(strDesignNo))
                {
                    return "改判失败，没有找到对应的执行标准信息！";
                }
                string[] strs_Slab_ID = strs.Substring(0, strs.Length - 1).Split(',');

                //Mod_TSC_SLAB_MAIN modSlabMain = dal_slab.GetModel(strs_Slab_ID[0]);
                //Mod_TPB_LGGYK modLggyk = dalTpbLggyk.GetModel_Trans(modSlabMain.C_LGJH);

                //if (modLggyk == null)
                //{
                //    TransactionHelper.RollBack();
                //    return "改判失败，获取炼钢记号时错误！";
                //}

                //DataTable dtLGJH = dalTpbLggyk.Get_LGJH(modLggyk.C_BOF_TYPE, modLggyk.C_LF_TYPE, modLggyk.C_RH_TYPE, modLggyk.C_CASTER_TYPE, strStdCode, strGrd).Tables[0];

                //if (dtLGJH.Rows.Count > 1)
                //{
                //    TransactionHelper.RollBack();
                //    return "标准：" + strStdCode + "；钢种：" + strGrd + "找到多个炼钢记号，请核查！";
                //}
                //else if (dtLGJH.Rows.Count == 0)
                //{
                //    TransactionHelper.RollBack();
                //    return "标准：" + strStdCode + "；钢种：" + strGrd + "没有找到炼钢记号！";
                //}

                //strLGJH = dtLGJH.Rows[0]["C_STEEL_SIGN"].ToString();




                DataTable dt = dal_commute.GetList_max().Tables[0];
                max_C_MASTER_ID = dt.Rows[0]["C_MASTER_ID"].ToString();
                max_C_GP_BEFORE_ID = dt.Rows[0]["C_GP_BEFORE_ID"].ToString();
                max_C_GP_AFTER_ID = dt.Rows[0]["C_GP_AFTER_ID"].ToString();

                if (string.IsNullOrEmpty(max_C_MASTER_ID))
                {
                    max_C_MASTER_ID = "GPsj" + RV.UI.ServerTime.timeNow().ToString("yyMMdd00001");
                }
                else
                {
                    max_C_MASTER_ID = "GPsj" + (Convert.ToInt64(max_C_MASTER_ID) + 1).ToString();

                }
                if (string.IsNullOrEmpty(max_C_GP_BEFORE_ID))
                {
                    max_C_GP_BEFORE_ID = "GPpq" + RV.UI.ServerTime.timeNow().ToString("yyMMdd00001");
                }
                else
                {
                    max_C_GP_BEFORE_ID = "GPpq" + (Convert.ToInt64(max_C_GP_BEFORE_ID) + 1).ToString();

                }
                if (string.IsNullOrEmpty(max_C_GP_AFTER_ID))
                {
                    max_C_GP_AFTER_ID = "GPph" + RV.UI.ServerTime.timeNow().ToString("yyMMdd00001");
                }
                else
                {
                    max_C_GP_AFTER_ID = "GPph" + (Convert.ToInt64(max_C_GP_AFTER_ID) + 1).ToString();

                }
                Bll_TB_MATRL_MAIN bll_matrl = new Bll_TB_MATRL_MAIN();

                for (int i = 0; i < strs_Slab_ID.Length; i++)
                {
                    Mod_TSC_SLAB_MAIN mod_slab = dal_slab.GetModel(strs_Slab_ID[i]);
                    stove = mod_slab.C_STOVE;
                    if (mod_slab != null)
                    {
                        Mod_TB_MATRL_MAIN mod_matrl = bll_matrl.GetModel(strMatCode);
                        stove = mod_slab.C_STOVE;
                        slabCode = mod_slab.C_SLABWH_CODE;
                        Mod_TQC_SLAB_COMMUTE mod = new Mod_TQC_SLAB_COMMUTE();
                        mod.C_STA_ID = mod_slab.C_STA_DESC;
                        mod.C_STOVE = mod_slab.C_STOVE;
                        mod.C_BATCH_NO = mod_slab.C_BATCH_NO;
                        mod.N_WGT = mod_slab.N_WGT;
                        mod.N_LEN = mod_slab.N_LEN;
                        mod.C_STL_GRD_BEFORE = mod_slab.C_STL_GRD;
                        mod.C_STD_CODE_BEFORE = mod_slab.C_STD_CODE;
                        mod.C_SPEC_BEFORE = mod_slab.C_SPEC;
                        mod.C_MAT_CODE_BEFORE = mod_slab.C_MAT_CODE;
                        mod.C_MAT_DESC_BEFORE = mod_slab.C_MAT_NAME;
                        mod.C_ZYX1_BEFORE = mod_slab.C_ZYX1;
                        mod.C_ZYX2_BEFORE = mod_slab.C_ZYX2;
                        mod.C_JUDGE_LEV_BP_BEFORE = mod_slab.C_MAT_TYPE;
                        mod.D_COMMUTE_DATE = RV.UI.ServerTime.timeNow();
                        mod.C_STL_GRD_AFTER = strGrd;
                        mod.C_STD_CODE_AFTER = strStdCode;
                        mod.C_SPEC_AFTER = mod_matrl.C_SLAB_SIZE;
                        mod.C_MAT_CODE_AFTER = strMatCode;
                        mod.C_MAT_DESC_AFTER = strMatName;
                        mod.C_REASON_DEPMT_ID = strZrdwID;
                        mod.C_REASON_DEPMT_DESC = strZrdwName;
                        mod.C_EMP_ID = RV.UI.UserInfo.UserID;
                        mod.C_REMARK = strRemark;
                        mod.C_MASTER_ID = max_C_MASTER_ID;
                        mod.C_GP_BEFORE_ID = max_C_GP_BEFORE_ID;
                        mod.C_GP_AFTER_ID = max_C_GP_AFTER_ID;
                        mod.C_ZYX1_AFTER = strZYX1;
                        mod.C_ZYX2_AFTER = strZYX2;
                        mod.C_JUDGE_LEV_BP_AFTER = strPDDJ;
                        mod.C_COMMUTE_REASON = strGPYY;
                        if (dal_commute.Add_Trans(mod))
                        {
                            if (!dal_slab.Update_Trans(mod_slab.C_ID, mod_slab.C_BATCH_NO, strGrd, strStdCode, strMatCode, strMatName, mod_matrl.C_SLAB_SIZE, max_C_MASTER_ID, max_C_GP_BEFORE_ID, max_C_GP_AFTER_ID, strLGJH, strPDDJ, strZYX1, strZYX2, strGPYY, strLen, strDesignNo))
                            {
                                TransactionHelper.RollBack();
                                return "改判失败，请检查修改后的内容！";
                            }
                        }
                        else
                        {
                            TransactionHelper.RollBack();
                            return "改判失败，添加改判记录时错误！";
                        }
                    }


                }
                string interface_nc = dal_interface.SendXml_GP(strUrl, max_C_MASTER_ID, max_C_GP_BEFORE_ID, max_C_GP_AFTER_ID, slabCode);
                if (interface_nc != "1")
                {
                    TransactionHelper.RollBack();
                    return interface_nc;
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
        /// 钢坯改判
        /// </summary>
        /// <param name="row">选中的数据</param>
        /// <param name="strGrd">钢种</param>
        /// <param name="strStdCode">执行标准</param>
        /// <param name="strMatCode">物料编码</param>
        /// <param name="strMatName">物料描述</param>
        /// <param name="strZrdwID">责任单位代码</param>
        /// <param name="strZrdwName">责任代为描述</param>
        /// <param name="strPDDJ">判定等级</param> 
        /// <param name="strZYX1">自由项1</param>
        /// <param name="strZYX2">自由项2</param>
        /// <param name="strGPYY">改判原因</param>
        /// <param name="strLen">定尺</param>
        /// <param name="strISSH">是否审核</param>
        /// <returns></returns>
        public string TPGP_Slab(string strs, string strGrd, string strStdCode, string strMatCode, string strMatName, string strZrdwID, string strZrdwName, string strPDDJ, string strZYX1, string strZYX2, string strGPYY, string strLen, decimal strISSH)
        {
            string result = "1";
            try
            {
                Dal_TQC_TP_SLAB_COMMUTE dalTP = new Dal_TQC_TP_SLAB_COMMUTE();
                Dal_TSC_SLAB_MAIN dal_slab = new Dal_TSC_SLAB_MAIN();
                Dal_TQD_DESIGN dalDesign = new Dal_TQD_DESIGN();

                TransactionHelper.BeginTransaction();

                string strUserID = RV.UI.UserInfo.userID;
                DateTime time = RV.UI.ServerTime.timeNow();
                string stove = "";

                string strDesignNo = dalDesign.Get_Design_No(strStdCode, strGrd);
                if (string.IsNullOrEmpty(strDesignNo))
                {
                    return "改判失败，没有找到对应的执行标准信息！";
                }
                string[] strs_Slab_ID = strs.Substring(0, strs.Length - 1).Split(',');

                Bll_TB_MATRL_MAIN bll_matrl = new Bll_TB_MATRL_MAIN();

                for (int i = 0; i < strs_Slab_ID.Length; i++)
                {
                    Mod_TSC_SLAB_MAIN mod_slab = dal_slab.GetModel(strs_Slab_ID[i]);
                    stove = mod_slab.C_STOVE;
                    if (mod_slab != null)
                    {
                        Mod_TB_MATRL_MAIN mod_matrl = bll_matrl.GetModel(strMatCode);
                        stove = mod_slab.C_STOVE;
                        Mod_TQC_TP_SLAB_COMMUTE mod = new Mod_TQC_TP_SLAB_COMMUTE();
                        mod.C_STA_ID = mod_slab.C_STA_DESC;
                        mod.C_SLAB_MAIN_ID = strs_Slab_ID[i];
                        mod.C_STOVE = mod_slab.C_STOVE;
                        mod.C_BATCH_NO = mod_slab.C_BATCH_NO;
                        mod.N_WGT = mod_slab.N_WGT;
                        mod.N_LEN_BEFORE = mod_slab.N_LEN;
                        mod.C_STL_GRD_BEFORE = mod_slab.C_STL_GRD;
                        mod.C_STD_CODE_BEFORE = mod_slab.C_STD_CODE;
                        mod.C_SPEC_BEFORE = mod_slab.C_SPEC;
                        mod.C_MAT_CODE_BEFORE = mod_slab.C_MAT_CODE;
                        mod.C_MAT_DESC_BEFORE = mod_slab.C_MAT_NAME;
                        mod.C_ZYX1_BEFORE = mod_slab.C_ZYX1;
                        mod.C_ZYX2_BEFORE = mod_slab.C_ZYX2;
                        mod.C_JUDGE_LEV_BP_BEFORE = mod_slab.C_MAT_TYPE;
                        mod.C_STL_GRD_AFTER = strGrd;
                        mod.C_STD_CODE_AFTER = strStdCode;
                        mod.C_SPEC_AFTER = mod_matrl.C_SLAB_SIZE;
                        mod.N_LEN_AFTER = Convert.ToDecimal(strLen);
                        mod.C_MAT_CODE_AFTER = strMatCode;
                        mod.C_MAT_DESC_AFTER = strMatName;
                        mod.C_REASON_DEPMT_ID = strZrdwID;
                        mod.C_REASON_DEPMT_DESC = strZrdwName;
                        mod.C_EMP_ID = RV.UI.UserInfo.UserName;
                        mod.C_ZYX1_AFTER = strZYX1;
                        mod.C_ZYX2_AFTER = strZYX2;
                        mod.C_JUDGE_LEV_BP_AFTER = strPDDJ;
                        mod.C_COMMUTE_SQ = strGPYY;
                        mod.N_IS_SH = strISSH;
                        mod.C_REMARK2 = mod_slab.C_MOVE_TYPE;
                        mod.C_REMARK3 = mod_slab.C_SLABWH_CODE;
                        if (dalTP.Add_Trans(mod))
                        {
                            if (!dal_slab.UpdateTP_Trans(mod_slab.C_ID, mod_slab.C_BATCH_NO))
                            {
                                TransactionHelper.RollBack();
                                return "改判失败，修改钢坯实绩状态时错误！";
                            }
                        }
                        else
                        {
                            TransactionHelper.RollBack();
                            return "改判失败，添加改判记录时错误！";
                        }
                    }



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
        /// 获得数据列表-炉号-库位
        /// </summary> 
        /// <param name="C_SLABWH_LOC_CODE">库位</param>
        /// <returns></returns>
        public DataSet GetList_KW_Group(string C_SLABWH_LOC_CODE)
        {
            return dal.GetList_KW_Group(C_SLABWH_LOC_CODE);
        }
        /// <summary>
        /// 获得数据列表- 实绩信息
        /// </summary>
        /// <param name="begin">开始时间</param>
        /// <param name="end">结束时间</param>
        /// <param name="C_STOVE">炉号</param> 
        /// <param name="stl">钢种</param>
        /// <param name="std">执行标准</param>
        /// <returns></returns>
        public DataSet GetList_SJ_Group(DateTime begin, DateTime end, string C_STOVE, string stl, string std)
        {
            return dal.GetList_SJ_Group(begin, end, C_STOVE, stl, std);
        }

        /// <summary>
        /// 获取物料编码
        /// </summary>
        /// <param name="stove"></param>
        /// <returns></returns>
        public Object GetMatCode(string stove)
        {
            return dal.GetMatCode(stove);
        }

        /// <summary>
        ///返回NC测试库钢坯库存数据
        /// </summary>
        /// <returns></returns>
        public DataTable GetNCCSGPK()
        {
            return dal.GetNCCSGPK();
        }

        /// <summary>
        /// 获取NC钢坯库数据
        /// </summary>
        /// <returns></returns>
        public DataTable GetNCGPK()
        {
            return dal.GetNCGPK();
        }

        /// <summary>
        /// 获取NC钢坯库数据
        /// </summary>
        /// <returns></returns>
        public DataTable GetNCGPK(string C_BATCH_NO, string C_STOVE, string C_STL_GRD, string C_MAT_CODE, string C_SLABWH_CODE, string C_ZYX1, string C_ZYX2)
        {
            return dal.GetNCGPK(C_BATCH_NO, C_STOVE, C_STL_GRD, C_MAT_CODE, C_SLABWH_CODE, C_ZYX1, C_ZYX2);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update_Stove(string C_SCUTCHEON, string stove)
        {
            return dal.Update_Stove(C_SCUTCHEON, stove);
        }
        /// <summary>
        /// 获取钢坯数据状态
        /// </summary>
        /// <param name="gzlx">钢种类型</param>
        /// <param name="wlh">物料号</param>
        /// <param name="gz">钢种</param>
        /// <param name="zxbz">执行标准</param>
        /// <param name="lh">炉号</param>
        /// <param name="ph">批号</param>
        /// <param name="ck">仓库</param>
        /// <param name="zt">状态</param>
        /// <param name="hlzt">缓冷状态</param>
        /// <param name="xmzt">修磨状态</param>
        /// <param name="pdzt">判断状态</param>
        /// <returns></returns>
        public DataSet GetSJ(string gzlx, string wlh, string gz, string zxbz, string lh, string ck, string zt, string hlzt, string xmzt, string pdzt)
        {
            return dal.GetSJ(gzlx, wlh, gz, zxbz, lh, ck, zt, hlzt, xmzt, pdzt);
        }
        /// <summary>
        /// 修改钢坯状态
        /// </summary>
        /// <param name="list">List<CommonKC>通用库存处理类</param>
        /// <param name="status">状态</param>
        /// <returns>0失败1成功</returns>
        public int UPSLABSTATUS(List<CommonKC> list, string fydh, string status)
        {
            return dal.UPSLABSTATUS(list, fydh, status);
        }
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
        public int CKKC(string mat, string ck, string stove, string batch)
        {
            return dal.CKKC(mat, ck, stove, batch);
        }


        /// <summary>
        /// 数据盘点差量1
        /// </summary>
        /// <returns></returns>
        public DataTable Get_MINUS1()
        {
            return dal.Get_MINUS1();
        }

        /// <summary>
        /// 数据盘点差量2
        /// </summary>
        /// <returns></returns>
        public DataTable Get_MINUS2()
        {
            return dal.Get_MINUS2();
        }


        public int deletebywhere(string C_BATCH_NO, string C_STOVE, string C_STL_GRD, string C_MAT_CODE, string C_SLABWH_CODE, string C_ZYX1, string C_ZYX2)
        {
            return dal.deletebywhere(C_BATCH_NO, C_STOVE, C_STL_GRD, C_MAT_CODE, C_SLABWH_CODE, C_ZYX1, C_ZYX2);
        }

        #endregion  ExtensionMethod

        /// <summary>
        /// 获取库存钢坯数量
        /// </summary>
        /// <param name="C_STL_GRD">钢种</param>
        /// <param name="C_STD_CODE">执行标准</param>
        /// <param name="C_MAT_CODE">物料编码</param>
        /// <returns>库存钢坯数量</returns>
        public decimal GetSlabKC(string C_STL_GRD, string C_STD_CODE, string C_MAT_CODE)
        {
            return dal.GetSlabKC(C_STL_GRD, C_STD_CODE, C_MAT_CODE);
        }

        /// <summary>
        /// 获取需要开坯的信息
        /// </summary>
        /// <returns></returns>
        public DataSet Get_List_Kp(string C_STL_GRD, string C_STD_CODE, string C_STOVE)
        {
            return dal.Get_List_Kp(C_STL_GRD, C_STD_CODE, C_STOVE);
        }

        /// <summary>
        /// 更新开坯物料信息
        /// </summary>
        /// <returns></returns>
        public string P_UPDATE_KP_MATRAL()
        {
            return dal.P_UPDATE_KP_MATRAL();
        }

        /// <summary>
        /// 根据炉号查询
        /// </summary>
        /// <param name="stove">炉号</param>
        /// <returns></returns>
        public DataSet Get_List_ByStove(string stove)
        {
            return dal.Get_List_ByStove(stove);
        }

        /// <summary>
        /// 同步钢坯实绩(指定炉号)
        /// </summary>
        /// <param name="P_STOVE">炉号</param>
        /// <returns></returns>
        public string TB_SLAB_SJ_STOVE(string P_STOVE)
        {
            return dal.TB_SLAB_SJ_STOVE(P_STOVE);
        }

        /// <summary>
        /// 同步钢坯实绩到TSC_SLAB_MAIN(指定炉号)
        /// </summary>
        /// <param name="P_STOVE">炉号</param>
        /// <returns></returns>
        public string TB_SLAB_MAIN_STOVE(string P_STOVE)
        {
            return dal.TB_SLAB_MAIN_STOVE(P_STOVE);
        }

        /// <summary>
        /// 钢坯调层数据
        /// </summary>
        /// <returns></returns>
        public DataTable GetTCInfo(string slabCode, string slabAreaCode, string slabLocCode)
        {
            return dal.GetTCInfo(slabCode, slabAreaCode, slabLocCode);
        }


        /// <summary>
        /// 修改钢坯层
        /// </summary>
        /// <returns></returns>
        public bool UpdateSlabTier(string count, string stove, string slabCode, string slabArea, string slabLoc, string slabTier)
        {
            return dal.UpdateSlabTier(count, stove, slabCode, slabArea, slabLoc, slabTier);
        }

        /// <summary>
        /// 获取异常炉次信息
        /// </summary>
        /// <param name="begin">开始时间</param>
        /// <param name="end">结束时间</param>
        /// <param name="Stove">炉号</param>
        /// <param name="str_Gz">钢种</param>
        /// <returns></returns>
        public DataSet Get_Slab_YC(DateTime begin, DateTime end, string Stove, string str_Gz)
        {
            return dal.Get_Slab_YC(begin, end, Stove, str_Gz);
        }
    }
}

