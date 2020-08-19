using System;
using System.Data;
using System.Collections.Generic;
using MODEL;
using DAL;
using System.Collections;

namespace BLL
{
    /// <summary>
    /// 性能结果表
    /// </summary>
    public partial class Bll_TQC_PHYSICS_RESULT
    {
        private readonly Dal_TQC_PHYSICS_RESULT dal = new Dal_TQC_PHYSICS_RESULT();
        public Bll_TQC_PHYSICS_RESULT()
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
        public bool Add(Mod_TQC_PHYSICS_RESULT model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Mod_TQC_PHYSICS_RESULT model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(string C_PHYSICS_GROUP_ID, string C_PRESENT_SAMPLES_ID)
        {

            return dal.Delete(C_PHYSICS_GROUP_ID, C_PRESENT_SAMPLES_ID);
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
        public Mod_TQC_PHYSICS_RESULT GetModel(string C_ID)
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
        /// 按时间和批号获取物理性能详细信息
        /// </summary>
        /// <param name="P_CODE">物理分组编码</param>
        /// <param name="P_BATCH">批号</param>
        /// <param name="P_START">制样时间（最小）</param>
        /// <param name="P_END">制样时间（最大）</param>
        /// <param name="P_TYPE">类型 0未同步综合判定的数据；1所有数据</param>
        /// <returns></returns>
		public DataSet Get_List(string P_CODE, string P_BATCH, string P_START, string P_END, string P_TYPE)
        {
            return dal.Get_List(P_CODE, P_BATCH, P_START, P_END, P_TYPE);
        }

        /// <summary>
        /// 按时间和批号获取物理性能详细信息
        /// </summary>
        /// <param name="P_CODE">物理分组编码</param>
        /// <param name="P_BATCH">批号</param>
        /// <param name="P_START">制样时间（最小）</param>
        /// <param name="P_END">制样时间（最大）</param>
        /// <param name="P_TYPE">类型 0未同步综合判定的数据；1所有数据</param>
        /// <returns></returns>
		public DataSet Get_Result_List(string P_CODE, string P_BATCH, string P_START, string P_END, string P_TYPE, string P_STLGRD)
        {
            return dal.Get_Result_List(P_CODE, P_BATCH, P_START, P_END, P_TYPE, P_STLGRD);
        }

        /// <summary>
        /// 按时间和批号获取物理性能修改信息
        /// </summary>
        /// <param name="P_CODE">物理分组编码</param>
        /// <param name="P_BATCH">批号</param>
        /// <param name="P_START">制样时间（最小）</param>
        /// <param name="P_END">制样时间（最大）</param>
        /// <param name="P_CHECK_STATE">检验状态；0-初检；1-复检；2-评审</param>
        /// <returns></returns>
		public DataSet Get_Log_List(string P_CODE, string P_BATCH, string P_START, string P_END, string P_CHECK_STATE)
        {
            return dal.Get_Log_List(P_CODE, P_BATCH, P_START, P_END, P_CHECK_STATE);
        }

        /// <summary>
        /// 物理性能详细信息
        /// </summary>
        /// <param name="P_CODE">物理分组编码</param>
        /// <returns></returns>
        public DataSet Get_List(string P_CODE)
        {
            return dal.Get_List(P_CODE);
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Mod_TQC_PHYSICS_RESULT> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Mod_TQC_PHYSICS_RESULT> DataTableToList(DataTable dt)
        {
            List<Mod_TQC_PHYSICS_RESULT> modelList = new List<Mod_TQC_PHYSICS_RESULT>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Mod_TQC_PHYSICS_RESULT model;
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
        /// 保存性能结果信息
        /// </summary>
        public bool SaveResult(ArrayList SQLStringList)
        {
            return dal.SaveResult(SQLStringList);
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet Get_XNList(string C_CODE, string C_PRESENT_SAMPLES_ID)
        {
            return dal.Get_XNList(C_CODE, C_PRESENT_SAMPLES_ID);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet Get_XN(string C_PRESENT_SAMPLES_ID)
        {
            return dal.Get_XN(C_PRESENT_SAMPLES_ID);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet Get_XNAllList(string BatchNo)
        {
            return dal.Get_XNAllList(BatchNo);
        }
        /// <summary>
        /// 性能结果信息列表
        /// </summary>
        /// <param name="time_Start">开始时间</param>
        /// <param name="time_End">结束时间</param>
        /// <param name="strBatch">批号</param>
        /// <param name="str_PHYSICS_GROUP_ID">物理性能分组ID</param>
        /// <param name="C_CHECK_DEPMT">部门</param>
        /// <returns></returns>
        public DataSet Get_XN_List(string time_Start, string time_End, string strBatch, string C_CHECK_DEPMT)
        {
            return dal.Get_XN_List(time_Start, time_End, strBatch, C_CHECK_DEPMT);
        }
        /// <summary>
        /// 性能结果信息列表
        /// </summary>
        /// <param name="time_Start">开始时间</param>
        /// <param name="time_End">结束时间</param>
        /// <param name="strBatch">批号</param> 
        /// <returns></returns>
        public DataSet Get_XN_CWSX_List(string time_Start, string time_End, string strBatch)
        {
            return dal.Get_XN_CWSX_List(time_Start, time_End, strBatch);
        }
        #endregion  BasicMethod
        #region  ExtensionMethod

        /// <summary>
        /// 保存性能值
        /// </summary>
        /// <returns></returns>
        public string Save_Result_Old(DataRow dr, DataTable dt_result, string strPhyCode, string strSB, string strWD, string strSD, string strBC, string strBZ, string strSHR)
        {
            try
            {
                string result = "1";

                TransactionHelper.BeginTransaction();

                Dal_TQC_PHYSICS_RESULT_MAIN dalTqcPhyResultMain = new Dal_TQC_PHYSICS_RESULT_MAIN();
                Dal_TQB_PHYSICS_GROUP dalTqbPhysicsGroup = new Dal_TQB_PHYSICS_GROUP();

                string strUserID = RV.UI.UserInfo.userID;
                DateTime time = RV.UI.ServerTime.timeNow();

                string C_PRESENT_SAMPLES_ID = dr["取样主表主键"].ToString();
                Mod_TQC_PHYSICS_RESULT_MAIN mod = dalTqcPhyResultMain.GetModel(C_PRESENT_SAMPLES_ID);

                string strCheckState = dr["检验状态"].ToString();
                if (strCheckState == "初检")
                {
                    strCheckState = "0";
                }
                else if (strCheckState == "复检")
                {
                    strCheckState = "1";
                }

                string str_PHYSICS_GROUP_ID = dalTqbPhysicsGroup.Get_ID(strPhyCode);

                DataTable dt_DB = new DataTable();

                if (strPhyCode == "R01")
                {
                    dt_DB = dalTqcPhyResultMain.Get_DB_List(dr["批号"].ToString(), str_PHYSICS_GROUP_ID, strCheckState, mod.C_IS_PD).Tables[0];
                }
                else
                {
                    dt_DB = dalTqcPhyResultMain.Get_DB_List(C_PRESENT_SAMPLES_ID).Tables[0];
                }

                for (int i = 0; i < dt_DB.Rows.Count; i++)
                {
                    Mod_TQC_PHYSICS_RESULT_MAIN mod_Main = dalTqcPhyResultMain.GetModel(dt_DB.Rows[i]["C_ID"].ToString());
                    if (mod_Main != null)
                    {
                        mod_Main.C_EQ_NAME = strSB;
                        mod_Main.C_TEMP = strWD;
                        mod_Main.C_HUMIDITY = strSD;
                        mod_Main.N_IS_LR = 1;
                        mod_Main.C_BC = strBC;
                        mod_Main.C_BZ = strBZ;
                        mod_Main.C_CHECK_USER = strSHR;

                        if (!dalTqcPhyResultMain.Update_Trans(mod_Main))
                        {
                            TransactionHelper.RollBack();
                            return "保存设备信息失败！";
                        }
                    }

                    dal.Delete_Trans(str_PHYSICS_GROUP_ID, dt_DB.Rows[i]["C_ID"].ToString());

                    for (int mm = 0; mm < dt_result.Rows.Count; mm++)
                    {
                        if (!string.IsNullOrEmpty(dt_result.Rows[mm]["C_VALUE"].ToString()))
                        {

                            int i_Type = 0;

                            if (dt_result.Rows[mm]["C_CODE"].ToString().Contains("000GCL"))
                            {
                                i_Type = 0;
                            }
                            else
                            {
                                i_Type = 1;
                            }

                            Mod_TQC_PHYSICS_RESULT modResult = new Mod_TQC_PHYSICS_RESULT();
                            modResult.C_PHYSICS_GROUP_ID = str_PHYSICS_GROUP_ID;
                            modResult.C_PRESENT_SAMPLES_ID = dt_DB.Rows[i]["C_ID"].ToString();
                            modResult.C_CHARACTER_ID = dt_result.Rows[mm]["C_CHARACTER_ID"].ToString();
                            modResult.C_CHARACTER_CODE = dt_result.Rows[mm]["C_CODE"].ToString();
                            modResult.C_CHARACTER_NAME = dt_result.Rows[mm]["C_NAME"].ToString();
                            modResult.C_VALUE = dt_result.Rows[mm]["C_VALUE"].ToString();
                            modResult.C_EMP_ID = strUserID;
                            modResult.D_MOD_DT = time;
                            modResult.N_SPLIT = 0;
                            modResult.N_TYPE = i_Type;
                            modResult.C_CHECK_STATE = strCheckState;
                            modResult.C_TICK_NO = dt_DB.Rows[i]["C_TICK_NO"].ToString();

                            if (!dal.Add_Trans(modResult))
                            {
                                TransactionHelper.RollBack();
                                return "保存结果失败！";
                            }
                        }
                    }

                }


                TransactionHelper.Commit();
                return result;
            }
            catch (Exception ex)
            {
                TransactionHelper.RollBack();
                return ex.Message;
            }
        }

        /// <summary>
        /// 保存性能值
        /// </summary>
        /// <returns></returns>
        public string Save_Result(DataTable dt_result, string strPhyCode)
        {
            try
            {
                string result = "1";

                TransactionHelper.BeginTransaction();

                string strUserID = RV.UI.UserInfo.userID;
                DateTime time = RV.UI.ServerTime.timeNow();

                Dal_TQB_PHYSICS_GROUP daltqbPhysicsGroup = new Dal_TQB_PHYSICS_GROUP();
                Dal_TQC_PHYSICS_RESULT_MAIN dalResultMain = new Dal_TQC_PHYSICS_RESULT_MAIN();

                Mod_TQC_PHYSICS_RESULT model;

                DataTable dt_Character = dal.Get_Character_List(strPhyCode).Tables[0];

                if (dt_Character.Rows.Count == 0)
                {
                    TransactionHelper.RollBack();
                    return "性能基础数据有误,保存失败！";
                }

                string str_PHYSICS_GROUP_ID = dt_Character.Rows[0]["C_PHYSICS_GROUP_ID"].ToString();

                for (int irow = 0; irow < dt_result.Rows.Count; irow++)
                {
                    string val = dt_result.Rows[irow]["chk"].ToString();
                    if (val == "False")
                    {
                        continue;
                    }

                    string C_PRESENT_SAMPLES_ID = dt_result.Rows[irow]["取样主表主键"].ToString();

                    dal.Delete_Trans(str_PHYSICS_GROUP_ID, C_PRESENT_SAMPLES_ID);

                    Mod_TQC_PHYSICS_RESULT_MAIN modelMain = dalResultMain.GetModel(C_PRESENT_SAMPLES_ID);
                    if (modelMain != null)
                    {
                        modelMain.N_IS_LR = 1;
                        modelMain.C_EQ_NAME = dt_result.Rows[irow]["设备信息"].ToString();

                        if (!dalResultMain.Update_Trans(modelMain))
                        {
                            TransactionHelper.RollBack();
                            return "保存失败！";
                        }
                    }

                    for (int icol = 13; icol < dt_result.Columns.Count; icol++)
                    {
                        int iType = 2;

                        if (dt_Character.Rows[icol - 13]["C_CODE"].ToString().Contains("000GCL"))
                        {
                            iType = 0;
                        }
                        else
                        {
                            iType = 1;
                        }

                        if (!string.IsNullOrEmpty(dt_result.Rows[irow][icol].ToString()))
                        {
                            model = new Mod_TQC_PHYSICS_RESULT();

                            model.C_PHYSICS_GROUP_ID = str_PHYSICS_GROUP_ID;//物理分组表主键
                            model.C_PRESENT_SAMPLES_ID = C_PRESENT_SAMPLES_ID;//tqc_physics_result_main主键
                            model.C_CHARACTER_ID = dt_Character.Rows[icol - 13]["C_CHARACTER_ID"].ToString(); //检验基础数据表主键
                            model.C_CHARACTER_CODE = dt_Character.Rows[icol - 13]["C_CODE"].ToString();//性能代码
                            model.C_CHARACTER_NAME = dt_Character.Rows[icol - 13]["C_NAME"].ToString();//性能名称
                            model.C_VALUE = dt_result.Rows[irow][icol].ToString();//性能值
                            model.C_EMP_ID = strUserID;//录入人
                            model.N_TYPE = iType;//0过程量；1检验量
                            model.C_CHECK_STATE = dt_result.Rows[irow]["检验状态"].ToString() == "初检" ? "0" : "1";// 状态；0-初检；1-复检；2-评审
                            model.C_TICK_NO = dt_result.Rows[irow]["钩号"].ToString();//钩号

                            if (!dal.Add_Trans(model))
                            {
                                TransactionHelper.RollBack();
                                return "保存失败！";
                            }
                        }
                    }
                }

                TransactionHelper.Commit();
                return result;
            }
            catch (Exception ex)
            {
                TransactionHelper.RollBack();
                return ex.Message;
            }
        }



        /// <summary>
        /// 修改性能值
        /// </summary>
        /// <returns></returns>
        public string Edit_Result(DataRow dr, DataTable dt_result, string str_PHYSICS_GROUP_ID, string strSB, string strWD, string strSD, string strBC, string strBZ, string strSHR)
        {
            try
            {
                string result = "1";

                TransactionHelper.BeginTransaction();

                string strUserID = RV.UI.UserInfo.userID;
                DateTime time = RV.UI.ServerTime.timeNow();

                Dal_TQC_PHYSICS_RESULT_MAIN dalTqcPhyResultMain = new Dal_TQC_PHYSICS_RESULT_MAIN();
                Dal_TQC_PHYSICS_RESULT_LOG dalResultLog = new Dal_TQC_PHYSICS_RESULT_LOG();
                Dal_TQC_COMPRE_ROLL dalTqcCompreRoll = new Dal_TQC_COMPRE_ROLL();
                Dal_TQB_PHYSICS_GROUP dalGroup = new Dal_TQB_PHYSICS_GROUP();

                if (dr != null)
                {
                    string C_PRESENT_SAMPLES_ID = dr["取样主表主键"].ToString();

                    string strCheckState = dr["检验状态"].ToString();
                    if (strCheckState == "初检")
                    {
                        strCheckState = "0";
                    }
                    else if (strCheckState == "复检")
                    {
                        strCheckState = "1";
                    }

                    string strCode = dalGroup.Get_Code(str_PHYSICS_GROUP_ID);

                    Mod_TQC_PHYSICS_RESULT_MAIN mod = dalTqcPhyResultMain.GetModel(C_PRESENT_SAMPLES_ID);

                    DataTable dt_DB = new DataTable();

                    if (strCode == "R01")
                    {
                        dt_DB = dalTqcPhyResultMain.Get_DB_List(dr["批号"].ToString(), str_PHYSICS_GROUP_ID, strCheckState, mod.C_IS_PD).Tables[0];
                    }
                    else
                    {
                        dt_DB = dalTqcPhyResultMain.Get_DB_List(C_PRESENT_SAMPLES_ID).Tables[0];
                    }

                    for (int mm = 0; mm < dt_DB.Rows.Count; mm++)
                    {
                        Mod_TQC_PHYSICS_RESULT_MAIN mod_Main = dalTqcPhyResultMain.GetModel(dt_DB.Rows[mm]["C_ID"].ToString());
                        if (mod_Main != null)
                        {
                            mod_Main.C_EQ_NAME = strSB;
                            mod_Main.C_TEMP = strWD;
                            mod_Main.C_HUMIDITY = strSD;
                            mod_Main.N_IS_LR = 1;
                            mod_Main.C_BC = strBC;
                            mod_Main.C_BZ = strBZ;
                            mod_Main.C_CHECK_USER = strSHR;

                            if (!dalTqcPhyResultMain.Update_Trans(mod_Main))
                            {
                                TransactionHelper.RollBack();
                                return "保存设备信息失败！";
                            }
                        }

                        int num_Edit = dalResultLog.Get_Max_EditNum(str_PHYSICS_GROUP_ID, dt_DB.Rows[mm]["C_ID"].ToString());//修改次数

                        num_Edit++;

                        DataTable dt_Old = dal.Get_XNList(strCode, dt_DB.Rows[mm]["C_ID"].ToString()).Tables[0];

                        for (int i = 0; i < dt_Old.Rows.Count; i++)
                        {
                            int strType = 0;

                            if (dt_Old.Rows[i]["C_CODE"].ToString().Contains("000GCL"))
                            {
                                strType = 0;
                            }
                            else
                            {
                                strType = 1;
                            }

                            if (!string.IsNullOrEmpty(dt_Old.Rows[i]["C_VALUE"].ToString()))
                            {
                                Mod_TQC_PHYSICS_RESULT_LOG modResult_Log = new Mod_TQC_PHYSICS_RESULT_LOG();
                                modResult_Log.C_PHYSICS_GROUP_ID = str_PHYSICS_GROUP_ID;
                                modResult_Log.C_PRESENT_SAMPLES_ID = dt_DB.Rows[mm]["C_ID"].ToString();
                                modResult_Log.C_CHARACTER_ID = dt_Old.Rows[i]["C_CHARACTER_ID"].ToString();
                                modResult_Log.C_CHARACTER_CODE = dt_Old.Rows[i]["C_CODE"].ToString();
                                modResult_Log.C_CHARACTER_NAME = dt_Old.Rows[i]["C_NAME"].ToString();
                                modResult_Log.C_VALUE = dt_Old.Rows[i]["C_VALUE"].ToString();
                                modResult_Log.C_EMP_ID = strUserID;
                                modResult_Log.N_TYPE = strType;
                                modResult_Log.C_TICK_NO = dr["钩号"].ToString();
                                modResult_Log.C_CHECK_STATE = strCheckState;
                                modResult_Log.C_EDIT_NUM = num_Edit.ToString();

                                if (!dalResultLog.Add_Trans(modResult_Log))
                                {
                                    TransactionHelper.RollBack();
                                    return "保存修改记录出错！";
                                }
                            }
                        }

                        dal.Delete_Trans(str_PHYSICS_GROUP_ID, dt_DB.Rows[mm]["C_ID"].ToString());

                        for (int k = 0; k < dt_result.Rows.Count; k++)
                        {
                            int strType = 0;

                            if (dt_result.Rows[k]["C_CODE"].ToString().Contains("000GCL"))
                            {
                                strType = 0;
                            }
                            else
                            {
                                strType = 1;
                            }

                            if (dt_result.Rows[k]["C_VALUE"].ToString() != "")
                            {
                                Mod_TQC_PHYSICS_RESULT modResult = new Mod_TQC_PHYSICS_RESULT();
                                modResult.C_PHYSICS_GROUP_ID = str_PHYSICS_GROUP_ID;
                                modResult.C_PRESENT_SAMPLES_ID = dt_DB.Rows[mm]["C_ID"].ToString();
                                modResult.C_CHARACTER_ID = dt_result.Rows[k]["C_CHARACTER_ID"].ToString();
                                modResult.C_CHARACTER_CODE = dt_result.Rows[k]["C_CODE"].ToString();
                                modResult.C_CHARACTER_NAME = dt_result.Rows[k]["C_NAME"].ToString();
                                modResult.C_VALUE = dt_result.Rows[k]["C_VALUE"].ToString();
                                modResult.C_EMP_ID = strUserID;
                                modResult.N_TYPE = strType;
                                modResult.C_TICK_NO = dr["钩号"].ToString();
                                modResult.C_CHECK_STATE = strCheckState;

                                if (!dal.Add_Trans(modResult))
                                {
                                    TransactionHelper.RollBack();
                                    return "修改数据出错！";
                                }
                            }
                        }
                    }
                }



                TransactionHelper.Commit();

                dalTqcCompreRoll.JUDGE_ROLL_BATCH(dr["批号"].ToString());

                return result;

            }
            catch (Exception ex)
            {
                TransactionHelper.RollBack();
                return ex.Message;
            }
        }

        /// <summary>
        /// 获取厂外时效性能结果
        /// </summary>
        /// <param name="P_CODE">物理分组编码</param>
        /// <param name="P_BATCH">批号</param>
        /// <param name="P_START">制样时间（最小）</param>
        /// <param name="P_END">制样时间（最大）</param>
        /// <param name="P_TYPE">类型 0未同步综合判定的数据；1所有数据</param>
        /// <returns></returns>
		public DataSet Get_CWSX_List(string P_CODE, string P_BATCH, string P_START, string P_END, string P_TYPE)
        {
            return dal.Get_CWSX_List(P_CODE, P_BATCH, P_START, P_END, P_TYPE);
        }

        #endregion  ExtensionMethod
    }
}

