using System;
using System.Data;
using System.Collections.Generic;
using DAL;
using MODEL;
namespace BLL
{
    /// <summary>
    /// 钢坯出入库记录
    /// </summary>
    public partial class Bll_TSC_SLAB_MOVE
    {
        private readonly Dal_TSC_SLAB_MOVE dal = new Dal_TSC_SLAB_MOVE();
        public Bll_TSC_SLAB_MOVE()
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
        public bool Add(Mod_TSC_SLAB_MOVE model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Mod_TSC_SLAB_MOVE model)
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
        public Mod_TSC_SLAB_MOVE GetModel(string C_ID)
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
        /// 分库
        /// </summary>
        /// <returns></returns>
        public string Add_FK(DataRow dr, int num, string slabwhCode, string shift, string group, string strUrl, string remark)
        {
            string result = "1";
            try
            {
                Dal_TSC_SLAB_MOVE dalSlabMove = new Dal_TSC_SLAB_MOVE();
                Dal_Interface_NC_SLAB_A4 dalInterface = new Dal_Interface_NC_SLAB_A4();
                Dal_TSC_SLAB_MES dalTscSlabMes = new Dal_TSC_SLAB_MES();

                TransactionHelper.BeginTransaction();

                string strUserID = RV.UI.UserInfo.userID;
                DateTime time = RV.UI.ServerTime.timeNow();

                DataTable billet = new DataTable();
                if (dal.UpdateMoveType(dr["C_STOVE"].ToString(), dr["C_STL_GRD"].ToString(), dr["C_SPEC"].ToString(), dr["C_STD_CODE"].ToString(), dr["C_MAT_CODE"].ToString(), num, slabwhCode, shift, group, strUserID, time, out billet, remark) != num)
                {
                    TransactionHelper.RollBack();
                    return "0";
                }

                if (billet != null && billet.Rows.Count > 0)
                {
                    foreach (DataRow item in billet.Rows)
                    {
                        Mod_TSC_SLAB_MOVE model = new Mod_TSC_SLAB_MOVE();
                        model.C_MOVE_TYPE = "M";
                        model.C_SLAB_MAIN_ID = item["C_ID"].ToString();
                        model.C_STA_ID = item["C_STA_ID"].ToString();
                        model.C_STOVE = item["C_STOVE"].ToString();
                        model.C_STL_GRD = item["C_STL_GRD"].ToString();
                        model.C_SPEC = item["C_SPEC"].ToString();

                        if (!string.IsNullOrEmpty(item["N_LEN"].ToString()))
                        {
                            model.N_LEN = Convert.ToDecimal(item["N_LEN"].ToString());
                        }

                        model.C_STD_CODE = item["C_STD_CODE"].ToString();
                        model.C_MAT_CODE = item["C_MAT_CODE"].ToString();
                        model.C_MAT_NAME = item["C_MAT_NAME"].ToString();

                        if (!string.IsNullOrEmpty(item["N_WGT"].ToString()))
                        {
                            model.N_WGT = Convert.ToDecimal(item["N_WGT"].ToString());
                        }

                        //model.C_STOCK_CODE = item["C_SLABWH_CODE"].ToString();
                        model.C_STOCK_CODE_TO = slabwhCode;
                        //model.C_AREA_CODE = item["C_SLABWH_AREA_CODE"].ToString();
                        //model.C_KW_CODE = item["C_SLABWH_LOC_CODE"].ToString();
                        //model.C_FLOOD_CODE = item["C_SLABWH_TIER_CODE"].ToString();
                        model.D_MOVE_DATE = time;
                        model.C_MOVE_GROUP = group;
                        model.C_MOVE_SHIFT = shift;
                        model.C_MOVE_EMP_ID = strUserID;

                        if (!dalSlabMove.Add(model))
                        {
                            TransactionHelper.RollBack();
                            return "0";
                        }
                    }
                }

                //if (!dalTscSlabMes.Update_Trans(dr["C_STOVE"].ToString()))
                //{
                //    TransactionHelper.RollBack();
                //    return "0";
                //}

                //int wg_count = dalTscSlabMes.Get_Count(dr["C_STOVE"].ToString());

                //if (wg_count > 0)
                //{
                //    bool result_NC = dalInterface.SendXml_SLAB_A4(strUrl, dr["C_STOVE"].ToString(), strUserID);//上传完工报告A4

                //    if (!result_NC)
                //    {
                //        TransactionHelper.RollBack();
                //        return "0";
                //    }
                //}

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
        /// 获取分库记录
        /// </summary>
        /// <param name="strStaID">连铸工位ID</param>
        /// <param name="strStove">炉号</param>
        /// <param name="strTimeStart">开始时间</param>
        /// <param name="strTimeEnd">结束时间</param>
        /// <returns></returns>
        public DataSet Get_FK_Log(string strStaID, string strStove, string strTimeStart, string strTimeEnd)
        {
            return dal.Get_FK_Log(strStaID, strStove, strTimeStart, strTimeEnd);
        }

        /// <summary>
        /// 获取入库记录
        /// </summary>
        /// <param name="strKW">库位编码</param>
        /// <param name="strStove">炉号</param>
        /// <param name="strTimeStart">开始时间</param>
        /// <param name="strTimeEnd">结束时间</param>
        /// <param name="kwCode">区域</param>
        /// <returns></returns>
        public DataSet Get_RK_Log(string strKW, string strStove, string strTimeStart, string strTimeEnd, string area)
        {
            return dal.Get_RK_Log(strKW, strStove, strTimeStart, strTimeEnd, area );
        }


        /// <summary>
        /// 入库
        /// </summary>
        /// <returns></returns>
        public string Add_RK(DataRow dr, int num, string slabwhCode, string area, string kw, string floor, string shift, string group, string strUrl, string remark)
        {
            string result = "1";
            try
            {
                Dal_TSC_SLAB_MOVE dalSlabMove = new Dal_TSC_SLAB_MOVE();
                Dal_Interface_NC_SLAB_GP4A dalInterface_Slab_GP4A = new Dal_Interface_NC_SLAB_GP4A();
                Dal_Interface_NC_SLAB_46 dalInterface_Slab_46 = new Dal_Interface_NC_SLAB_46();

                TransactionHelper.BeginTransaction();

                string strUserID = RV.UI.UserInfo.userID;
                DateTime time = RV.UI.ServerTime.timeNow();

                DataTable billet = new DataTable();
                if (dal.UpdateMoveType(dr["C_STOVE"].ToString(), dr["C_STL_GRD"].ToString(), dr["C_SPEC"].ToString(), dr["C_STD_CODE"].ToString(), dr["C_MAT_CODE"].ToString(), num, slabwhCode, area, kw, floor, shift, group, strUserID, time, dr["C_ZKDH"].ToString(), dr["C_ZKDHID"].ToString(), out billet, dr["C_BATCH_NO"].ToString(), remark) != num)
                {
                    TransactionHelper.RollBack();
                    return "钢坯实绩库存状态更新失败";
                }

                if (billet != null && billet.Rows.Count > 0)
                {
                    foreach (DataRow item in billet.Rows)
                    {
                        Mod_TSC_SLAB_MOVE model = new Mod_TSC_SLAB_MOVE();
                        model.C_MOVE_TYPE = "E";
                        model.C_SLAB_MAIN_ID = item["C_ID"].ToString();
                        model.C_STA_ID = item["C_STA_ID"].ToString();
                        model.C_STOVE = item["C_STOVE"].ToString();
                        model.C_BATCH_NO = item["C_BATCH_NO"].ToString();
                        model.C_STL_GRD = item["C_STL_GRD"].ToString();
                        model.C_SPEC = item["C_SPEC"].ToString();
                        model.C_REMARK = remark;
                        if (!string.IsNullOrEmpty(item["N_LEN"].ToString()))
                        {
                            model.N_LEN = Convert.ToDecimal(item["N_LEN"].ToString());
                        }

                        model.C_STD_CODE = item["C_STD_CODE"].ToString();
                        model.C_MAT_CODE = item["C_MAT_CODE"].ToString();
                        model.C_MAT_NAME = item["C_MAT_NAME"].ToString();

                        if (!string.IsNullOrEmpty(item["N_WGT"].ToString()))
                        {
                            model.N_WGT = Convert.ToDecimal(item["N_WGT"].ToString());
                        }

                        model.C_STOCK_CODE = item["C_SLABWH_CODE"].ToString();
                        //model.C_STOCK_CODE_TO = item["C_SLABWH_CODE"].ToString();
                        model.C_AREA_CODE = area;
                        model.C_KW_CODE = kw;
                        model.C_FLOOD_CODE = floor;
                        model.D_MOVE_DATE = time;
                        model.C_MOVE_GROUP = group;
                        model.C_MOVE_SHIFT = shift;
                        model.C_MOVE_EMP_ID = strUserID;

                        model.C_ZKDH = dr["C_ZKDH"].ToString();
                        model.C_ZKDHID = dr["C_ZKDHID"].ToString();

                        if (!dalSlabMove.Add(model))
                        {
                            TransactionHelper.RollBack();
                            return "添加入库记录失败";
                        }
                    }
                }

                if (!string.IsNullOrEmpty(dr["C_ZKDH"].ToString()) && !string.IsNullOrEmpty(dr["C_ZKDHID"].ToString()))
                {
                    string result_NC = dalInterface_Slab_GP4A.SendXml_GP4A(strUrl, dr["C_ZKDH"].ToString(), dr["C_ZKDHID"].ToString(), num, kw, area);//上传入库信息4A

                    if (result_NC != "1")
                    {
                        TransactionHelper.RollBack();
                        return result_NC;
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
        /// 调拨
        /// </summary>
        /// <returns></returns>
        public string Add_DB(DataRow dr, int num, string slabwhCodeNEW, string shift, string group, string strUrl, string remark)
        {
            string result = "1";
            try
            {
                Dal_TSC_SLAB_MOVE dalSlabMove = new Dal_TSC_SLAB_MOVE();
                Dal_Interface_NC_SLAB_GP4I dalInterface = new Dal_Interface_NC_SLAB_GP4I();

                TransactionHelper.BeginTransaction();

                string strUserID = RV.UI.UserInfo.userID;
                DateTime time = RV.UI.ServerTime.timeNow();

                #region 获取转库单号

                string strZKDH = "";//转库单号
                string strZKDHID = "";//转库单ID

                DataTable dtZK = dalSlabMove.Get_Max_ZKDH().Tables[0];
                if (dtZK.Rows.Count > 0)
                {
                    strZKDH = dtZK.Rows[0]["C_ZKDH"].ToString();
                    strZKDHID = dtZK.Rows[0]["C_ZKDHID"].ToString();
                }

                if (string.IsNullOrEmpty(strZKDH))
                {
                    strZKDH = "gp" + time.ToString("yyyyMMdd") + "00001";
                }
                else
                {
                    strZKDH = "gp" + (Convert.ToInt64(strZKDH) + 1);
                }

                if (string.IsNullOrEmpty(strZKDHID))
                {
                    strZKDHID = "pk" + time.ToString("yyyyMMdd") + "00001";
                }
                else
                {
                    strZKDHID = "pk" + (Convert.ToInt64(strZKDHID) + 1);
                }

                #endregion

                DataTable billet = new DataTable();
                if (dal.UpdateMoveType(dr["C_STOVE"].ToString(), dr["C_STL_GRD"].ToString(), dr["C_SPEC"].ToString(), dr["C_STD_CODE"].ToString(), dr["C_MAT_CODE"].ToString(), num, dr["C_SLABWH_CODE"].ToString(), slabwhCodeNEW, dr["C_SLABWH_LOC_CODE"].ToString(), shift, group, strUserID, time, strZKDH, strZKDHID, out billet, dr["C_BATCH_NO"].ToString(), remark) != num)
                {
                    TransactionHelper.RollBack();
                    return "调拨失败";
                }

                if (billet != null && billet.Rows.Count > 0)
                {
                    foreach (DataRow item in billet.Rows)
                    {
                        Mod_TSC_SLAB_MOVE model = new Mod_TSC_SLAB_MOVE();
                        model.C_MOVE_TYPE = "M";
                        model.C_SLAB_MAIN_ID = item["C_ID"].ToString();
                        model.C_STA_ID = item["C_STA_ID"].ToString();
                        model.C_STOVE = item["C_STOVE"].ToString();
                        model.C_BATCH_NO = item["C_BATCH_NO"].ToString();
                        model.C_STL_GRD = item["C_STL_GRD"].ToString();
                        model.C_SPEC = item["C_SPEC"].ToString();
                        model.C_REMARK = remark;

                        if (!string.IsNullOrEmpty(item["N_LEN"].ToString()))
                        {
                            model.N_LEN = Convert.ToDecimal(item["N_LEN"].ToString());
                        }

                        model.C_STD_CODE = item["C_STD_CODE"].ToString();
                        model.C_MAT_CODE = item["C_MAT_CODE"].ToString();
                        model.C_MAT_NAME = item["C_MAT_NAME"].ToString();

                        if (!string.IsNullOrEmpty(item["N_WGT"].ToString()))
                        {
                            model.N_WGT = Convert.ToDecimal(item["N_WGT"].ToString());
                        }

                        model.C_STOCK_CODE = item["C_SLABWH_CODE"].ToString();
                        model.C_STOCK_CODE_TO = slabwhCodeNEW;
                        model.C_AREA_CODE = item["C_SLABWH_AREA_CODE"].ToString();
                        model.C_KW_CODE = item["C_SLABWH_LOC_CODE"].ToString();
                        model.C_FLOOD_CODE = item["C_SLABWH_TIER_CODE"].ToString();
                        model.D_MOVE_DATE = time;
                        model.C_MOVE_GROUP = group;
                        model.C_MOVE_SHIFT = shift;
                        model.C_MOVE_EMP_ID = strUserID;

                        model.C_ZKDH = strZKDH;
                        model.C_ZKDHID = strZKDHID;

                        if (!dalSlabMove.Add(model))
                        {
                            TransactionHelper.RollBack();
                            return "调拨失败";
                        }
                    }
                    DataTable dt = TransactionHelper.Query("SELECT * FROM TSC_SLAB_MOVE WHERE C_ZKDH='" + strZKDH + "'").Tables[0];


                }

                string result_NC = dalInterface.SendXml_GP4I(strUrl, strZKDH, strZKDHID, dr["C_SLABWH_LOC_CODE"].ToString(), dr["C_SLABWH_AREA_CODE"].ToString());//上传转库信息4I

                if (result_NC != "1")
                {
                    TransactionHelper.RollBack();
                    return result_NC;
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
        /// 获取调拨记录
        /// </summary>
        /// <param name="slabwhCode">仓库代码</param>
        /// <param name="strStove">炉号</param>
        /// <param name="strTimeStart">开始时间</param>
        /// <param name="strTimeEnd">结束时间</param>
        /// <returns></returns>
        public DataSet Get_DB_Log(string slabwhCode, string strStove, string strTimeStart, string strTimeEnd)
        {
            return dal.Get_DB_Log(slabwhCode, strStove, strTimeStart, strTimeEnd);
        }
        /// <summary>
        /// 获取出入库记录
        /// </summary>
        /// <param name="strTimeStart">开始时间</param>
        /// <param name="strTimeEnd">结束时间</param>
        /// <param name="strStove">炉号</param>
        /// <param name="strSTD">标准</param>
        /// <param name="strSTLGRD">钢种</param>
        /// <returns></returns>
        public DataSet Get_DB(string strTimeStart, string strTimeEnd, string strStove, string strSTD, string strSTLGRD)
        {
            return dal.Get_DB(strTimeStart, strTimeEnd, strStove, strSTD, strSTLGRD);
        }


        /// <summary>
        /// 装车
        /// </summary>
        /// <returns></returns>
        public string Loading(DataRow dr, int num, string slabwhCode, string shift, string group, string remark)
        {
            string result = "1";
            try
            {


                TransactionHelper.BeginTransaction();

                string strUserID = RV.UI.UserInfo.userID;
                DateTime time = RV.UI.ServerTime.timeNow();

                DataTable billet = new DataTable();
                if (dal.UpdateLodingType(dr["C_STOVE"].ToString(), dr["C_STL_GRD"].ToString(), dr["C_SPEC"].ToString(), dr["C_STD_CODE"].ToString(), dr["C_MAT_CODE"].ToString(), num, slabwhCode, shift, group, strUserID, time, out billet, dr["C_BATCH_NO"].ToString(), remark) != num)
                {
                    TransactionHelper.RollBack();
                    return "装车失败";
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

        #endregion  BasicMethod
    }
}

