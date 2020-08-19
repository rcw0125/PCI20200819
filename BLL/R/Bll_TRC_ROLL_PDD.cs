using System;
using System.Data;
using System.Collections.Generic;
using DAL;
using MODEL;
namespace BLL
{
    /// <summary>
    /// 线材盘点主表
    /// </summary>
    public partial class Bll_TRC_ROLL_PDD
    {
        private readonly Dal_TRC_ROLL_PDD dal = new Dal_TRC_ROLL_PDD();
        public Bll_TRC_ROLL_PDD()
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
        public bool Add(Mod_TRC_ROLL_PDD model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Mod_TRC_ROLL_PDD model)
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
        public Mod_TRC_ROLL_PDD GetModel(string C_ID)
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
        public List<Mod_TRC_ROLL_PDD> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Mod_TRC_ROLL_PDD> DataTableToList(DataTable dt)
        {
            List<Mod_TRC_ROLL_PDD> modelList = new List<Mod_TRC_ROLL_PDD>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Mod_TRC_ROLL_PDD model;
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
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strTime1, string strTime2)
        {
            return dal.GetList(strTime1, strTime2);
        }

        #endregion  BasicMethod
        #region  ExtensionMethod


        /// <summary>
        /// 下发条码
        /// </summary>
        /// <returns></returns>
        public string Down_RF(DataTable dt)
        {
            string result = "1";

            try
            {
                TransactionHelper.BeginTransaction();
                TransactionHelper_SQL.BeginTransaction();

                string userID = RV.UI.UserInfo.UserID;
                DateTime dTime = RV.UI.ServerTime.timeNow();

                Dal_TRC_ROLL_PDD_ITEM dalRollPddItem = new Dal_TRC_ROLL_PDD_ITEM();
                Dal_TPB_LINEWH dalTpbLineWh = new Dal_TPB_LINEWH();

                Int64 i_ID_Main = 0;
                Int64 i_ID_Item = 0;

                string s_id_main = dal.Get_Max_ID();
                if (string.IsNullOrEmpty(s_id_main))
                {
                    i_ID_Main = 20190200000;
                }
                else
                {
                    i_ID_Main = Convert.ToInt64(s_id_main) + 1;
                }

                string s_id_item = dalRollPddItem.Get_Max_ID();
                if (string.IsNullOrEmpty(s_id_item))
                {
                    i_ID_Item = 2019022500000;
                }
                else
                {
                    i_ID_Item = Convert.ToInt64(s_id_item) + 1;
                }

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (dt.Rows[i]["条码账存卷数"].ToString() == "0")
                    {
                        continue;
                    }

                    string NC_CK_ID = dalTpbLineWh.GetList_id(dt.Rows[i]["仓库"].ToString()).ToString();

                    string strDH = dal.Get_PDDH(dTime.ToString(), dt.Rows[i]["仓库"].ToString());

                    if (string.IsNullOrEmpty(strDH))
                    {
                        strDH = dal.Get_Max_PDDH(dTime.ToString());
                        if (string.IsNullOrEmpty(strDH))
                        {
                            strDH = "PD" + dTime.ToString("yyyyMMdd") + "0001";
                        }
                        else
                        {
                            strDH = "PD" + (Convert.ToUInt64(strDH) + 1).ToString();
                        }

                        i_ID_Main++;

                        Mod_TRC_ROLL_PDD modPdd = new Mod_TRC_ROLL_PDD();
                        modPdd.C_ID = i_ID_Main.ToString();
                        modPdd.C_CK = dt.Rows[i]["仓库"].ToString();
                        modPdd.D_PDRQ = dTime;
                        modPdd.C_YSDH = strDH;
                        modPdd.D_INSERT = dTime;
                        if (!dal.Add_Trans(modPdd))
                        {
                            TransactionHelper.RollBack();
                            TransactionHelper_SQL.RollBack();
                            return "往CAP盘点主表插入失败！";
                        }


                        string strSql = "insert into ReZJB_PDD(ZJBstatus,CAPPK,ck,pdrq,ysdh,insertts,beizhu)values('0','" + i_ID_Main.ToString() + "','" + NC_CK_ID + "','" + dTime + "','" + strDH + "','" + dTime + "','') ";

                        if (!dal.Add_RF_Trans(strSql))
                        {
                            TransactionHelper.RollBack();
                            TransactionHelper_SQL.RollBack();
                            return "往RF盘点主表插入失败！";
                        }
                    }

                    i_ID_Item++;

                    Mod_TRC_ROLL_PDD_ITEM modItem = new Mod_TRC_ROLL_PDD_ITEM();
                    modItem.C_YSDH = strDH;
                    modItem.C_MATCODE = dt.Rows[i]["物料号"].ToString();
                    modItem.C_PCH = dt.Rows[i]["批次号"].ToString();
                    modItem.C_SX = dt.Rows[i]["质量等级"].ToString();
                    //modItem.C_ZCSL = dt.Rows[i]["仓库"].ToString();
                    //modItem.C_FZCZL = dt.Rows[i]["仓库"].ToString();
                    //modItem.C_FREE0 = "";
                    modItem.C_FREE1 = dt.Rows[i]["自由项1"].ToString();
                    modItem.C_FREE2 = dt.Rows[i]["自由项2"].ToString();
                    modItem.C_FREE3 = dt.Rows[i]["自由项3"].ToString();
                    //modItem.C_FREE4 = "";
                    modItem.C_ID = i_ID_Item.ToString();
                    modItem.D_INSERT = dTime;
                    //modItem.C_REMARK = "";
                    modItem.C_CK = dt.Rows[i]["仓库"].ToString();
                    modItem.C_MATDESC = dt.Rows[i]["物料名称"].ToString();
                    modItem.C_SPEC = dt.Rows[i]["规格"].ToString();
                    modItem.C_STL_GRD = dt.Rows[i]["钢种"].ToString();
                    modItem.C_NC_SL = Convert.ToDecimal(dt.Rows[i]["NC账存卷数"].ToString());
                    modItem.C_NC_ZL = Convert.ToDecimal(dt.Rows[i]["NC账存数量"].ToString());
                    modItem.C_CAP_SL = Convert.ToDecimal(dt.Rows[i]["CAP账存卷数"].ToString());
                    modItem.C_CAP_ZL = Convert.ToDecimal(dt.Rows[i]["CAP账存数量"].ToString());
                    modItem.C_RF_SL = Convert.ToDecimal(dt.Rows[i]["条码账存卷数"].ToString());
                    modItem.C_RF_ZL = Convert.ToDecimal(dt.Rows[i]["条码账存数量"].ToString());
                    //modItem.C_RF_SJ_SL = dt.Rows[i]["仓库"].ToString();
                    //modItem.C_RF_SJ_ZL = dt.Rows[i]["仓库"].ToString();
                    modItem.C_NC_CAP_SL = Convert.ToDecimal(dt.Rows[i]["NC与CAP卷数账差"].ToString());
                    modItem.C_NC_CAP_ZL = Convert.ToDecimal(dt.Rows[i]["NC与CAP数量账差"].ToString());
                    modItem.C_RF_CAP_SL = Convert.ToDecimal(dt.Rows[i]["条码与CAP卷数账差"].ToString());
                    modItem.C_RF_CAP_ZL = Convert.ToDecimal(dt.Rows[i]["条码与CAP数量账差"].ToString());
                    //modItem.C_CAP_SJ_SL = Convert.ToDecimal(dt.Rows[i]["CAP与实盘卷数差异"].ToString());
                    //modItem.C_CAP_SJ_ZL = Convert.ToDecimal(dt.Rows[i]["CAP与实盘数量差异"].ToString());

                    if (!dalRollPddItem.Add_Trans(modItem))
                    {
                        TransactionHelper.RollBack();
                        TransactionHelper_SQL.RollBack();
                        return "往CAP盘点明细表插入失败！";
                    }


                    string strSql_Item = "insert into ReZJB_PDD_Item(ysdh,BARCODE,PCH,SX,ZCSL,FZCZL,vfree0,vfree1,vfree2,vfree3,vfree4,ZJBstatus,CAPPK,insertts)values('" + strDH + "','" + dt.Rows[i]["物料号"].ToString() + "','" + dt.Rows[i]["批次号"].ToString() + "','" + dt.Rows[i]["质量等级"].ToString() + "','" + dt.Rows[i]["条码账存卷数"].ToString() + "','" + dt.Rows[i]["条码账存数量"].ToString() + "','','" + dt.Rows[i]["自由项1"].ToString() + "','" + dt.Rows[i]["自由项2"].ToString() + "','" + dt.Rows[i]["自由项3"].ToString() + "','','0','" + i_ID_Item.ToString() + "','" + dTime + "' ) ";

                    if (!dal.Add_RF_Trans(strSql_Item))
                    {
                        TransactionHelper.RollBack();
                        TransactionHelper_SQL.RollBack();
                        return "往RF盘点主表插入失败！";
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
        /// 同步条码盘点结果信息
        /// </summary>
        /// <returns></returns>
        public string TB_RF_PD_Result()
        {
            string result = "1";

            try
            {
                TransactionHelper.BeginTransaction();
                TransactionHelper_SQL.BeginTransaction();

                string userID = RV.UI.UserInfo.UserID;
                DateTime dTime = RV.UI.ServerTime.timeNow();

                Dal_TRC_ROLL_PDD_ITEM dalRollPddItem = new Dal_TRC_ROLL_PDD_ITEM();

                DataTable dtMain = dal.Get_PD_List().Tables[0];

                if (dtMain.Rows.Count > 0)
                {
                    for (int i = 0; i < dtMain.Rows.Count; i++)
                    {
                        DataTable dtItem = dal.Get_PD_ITEM_List(dtMain.Rows[i]["ysdh"].ToString()).Tables[0];

                        for (int mm = 0; mm < dtItem.Rows.Count; mm++)
                        {
                            Mod_TRC_ROLL_PDD_ITEM model_Item = dalRollPddItem.GetModel(dtItem.Rows[mm]["YSDH"].ToString(), dtItem.Rows[mm]["BARCODE"].ToString(), dtItem.Rows[mm]["PCH"].ToString(), dtItem.Rows[mm]["SX"].ToString(), dtItem.Rows[mm]["vfree1"].ToString(), dtItem.Rows[mm]["vfree2"].ToString(), dtItem.Rows[mm]["vfree3"].ToString());
                            if (model_Item != null)
                            {
                                model_Item.C_RF_SJ_SL = Convert.ToDecimal(dtItem.Rows[mm]["SPSL"].ToString());
                                model_Item.C_RF_SJ_ZL = Convert.ToDecimal(dtItem.Rows[mm]["SPZL"].ToString());

                                model_Item.C_CAP_SJ_SL = model_Item.C_CAP_SL - model_Item.C_RF_SJ_SL;
                                model_Item.C_CAP_SJ_ZL = model_Item.C_CAP_ZL - model_Item.C_RF_SJ_ZL;

                                if (!dalRollPddItem.Update_Trans(model_Item))
                                {
                                    TransactionHelper.RollBack();
                                    TransactionHelper_SQL.RollBack();
                                    return "更新实盘重量失败！";
                                }
                            }
                        }

                        string strSql = "update SeZJB_PDD_FINISHED set ZJBstatus=1 where ysdh='" + dtMain.Rows[i]["ysdh"].ToString() + "' ";

                        if (!dal.Update_RF_Trans(strSql))
                        {
                            TransactionHelper.RollBack();
                            TransactionHelper_SQL.RollBack();
                            return "更新条码盘点表状态失败！";
                        }
                    }
                }
                else
                {
                    TransactionHelper.RollBack();
                    TransactionHelper_SQL.RollBack();
                    return "没有需要同步的盘点信息！";
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

        #endregion  ExtensionMethod
    }
}

