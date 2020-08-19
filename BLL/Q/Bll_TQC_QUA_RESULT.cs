using System;
using System.Data;
using System.Collections.Generic;
using DAL;
using MODEL;
namespace BLL
{
    /// <summary>
    /// 成分结果表
    /// </summary>
    public partial class Bll_TQC_QUA_RESULT
    {
        private readonly Dal_TQC_QUA_RESULT dal = new Dal_TQC_QUA_RESULT();
        public Bll_TQC_QUA_RESULT()
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
        public bool Add(Mod_TQC_QUA_RESULT model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Mod_TQC_QUA_RESULT model)
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
        public Mod_TQC_QUA_RESULT GetModel(string C_ID)
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
        public List<Mod_TQC_QUA_RESULT> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Mod_TQC_QUA_RESULT> DataTableToList(DataTable dt)
        {
            List<Mod_TQC_QUA_RESULT> modelList = new List<Mod_TQC_QUA_RESULT>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Mod_TQC_QUA_RESULT model;
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
        /// 查询成分原始信息
        /// </summary>
        /// <param name="P_STOVE">炉号</param>
        /// <param name="P_START">时间（开始）</param>
        /// <param name="P_END">时间（结束）</param>
        /// <returns></returns>
        public DataSet Get_CF_List(string P_STOVE, string P_START, string P_END)
        {
            return dal.Get_CF_List(P_STOVE, P_START, P_END);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(string c_stove, string c_anano, string c_commissionid, string C_SAMPID, string stype)
        {
            return dal.Update(c_stove, c_anano, c_commissionid, C_SAMPID, stype);
        }

        /// <summary>
        /// 获取成分取样主信息列表
        /// </summary>
        /// <param name="C_STOVE"></param>
        /// <returns></returns>
        public DataSet Get_Main_List(string C_STOVE)
        {
            return dal.Get_Main_List(C_STOVE);
        }

        /// <summary>
        /// 获取成分详细信息
        /// </summary>
        /// <param name="C_STOVE"></param>
        /// <param name="C_ANANO"></param>
        /// <param name="C_COMMISSIONID"></param>
        /// <param name="C_SAMPID"></param>
        /// <returns></returns>
        public DataSet Get_Item_List(string C_STOVE, string C_ANANO, string C_COMMISSIONID, string C_SAMPID)
        {
            return dal.Get_Item_List(C_STOVE, C_ANANO, C_COMMISSIONID, C_SAMPID);
        }

        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int Get_CF_Count(string C_STOVE)
        {
            return dal.Get_CF_Count(C_STOVE);
        }

        /// <summary>
        /// 获取成分值
        /// </summary>
        public string Get_CF_Value(string C_STOVE, string V_CF_NAME)
        {
            return dal.Get_CF_Value(C_STOVE, V_CF_NAME);
        }


        /// <summary>
        /// 保存修改后的成分值
        /// </summary>
        /// <param name="dr">需要保存的成分信息</param>
        /// <param name="TickNo">钩号</param>
        /// <returns></returns>
        public string Save_CF(DataTable dt, string C_STOVE, string C_ANANO, string C_COMMISSIONID, string C_SAMPID)
        {
            string result = "1";

            try
            {
                TransactionHelper.BeginTransaction();

                string userID = RV.UI.UserInfo.UserID;
                DateTime dTime = RV.UI.ServerTime.timeNow();

                Dal_TQC_QUA_RESULT_LOG dalTqcQuaResultLog = new Dal_TQC_QUA_RESULT_LOG();

                Mod_TQC_QUA_RESULT mod_Result = dal.GetModel(C_STOVE, C_ANANO, C_COMMISSIONID, C_SAMPID);

                DataTable dt_Old = dal.Get_List(C_STOVE, C_ANANO, C_COMMISSIONID, C_SAMPID).Tables[0];//获取原信息

                int num_Edit = dalTqcQuaResultLog.Get_Max_EditNum(C_STOVE, C_ANANO, C_COMMISSIONID, C_SAMPID);
                num_Edit++;

                for (int mm = 0; mm < dt_Old.Rows.Count; mm++)
                {
                    Mod_TQC_QUA_RESULT_LOG model_Log = new Mod_TQC_QUA_RESULT_LOG();
                    model_Log.C_ANAITEM = dt_Old.Rows[mm]["C_ANAITEM"].ToString();
                    model_Log.N_ORIGINALVALUE = Convert.ToDecimal(dt_Old.Rows[mm]["N_ORIGINALVALUE"].ToString());
                    model_Log.D_CREATETIME = dTime;
                    model_Log.C_STOVE = C_STOVE;
                    model_Log.C_EDIT_NUM = num_Edit.ToString();
                    model_Log.C_EMP_ID = userID;
                    model_Log.D_MOD_DT = dTime;

                    if (!string.IsNullOrEmpty(C_ANANO))
                    {
                        model_Log.C_ANANO = Convert.ToDecimal(C_ANANO);
                    }

                    model_Log.C_COMMISSIONID = C_COMMISSIONID;
                    model_Log.C_SAMPID = C_SAMPID;

                    if (mod_Result != null)
                    {
                        model_Log.N_STATUS = mod_Result.N_STATUS;
                        model_Log.C_REMARK = mod_Result.C_REMARK;
                        model_Log.N_SPLIT = mod_Result.N_SPLIT;
                        model_Log.N_TYPE = mod_Result.N_TYPE;
                        model_Log.C_GROUP = mod_Result.C_GROUP;
                        model_Log.C_SHIFT = mod_Result.C_SHIFT;
                        model_Log.D_SHIFTDATE = mod_Result.D_SHIFTDATE;
                        model_Log.C_SAMPSORT = mod_Result.C_SAMPSORT;
                        model_Log.C_IS_PD = mod_Result.C_IS_PD;
                    }

                    if (!dalTqcQuaResultLog.Add_Trans(model_Log))
                    {
                        TransactionHelper.RollBack();
                        return "成分修改记录保存失败！";
                    }
                }

                dal.Delete_Trans(C_STOVE, C_ANANO, C_COMMISSIONID, C_SAMPID);//删除原信息

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Mod_TQC_QUA_RESULT model = new Mod_TQC_QUA_RESULT();
                    model.C_ANAITEM = dt.Rows[i]["C_ANAITEM"].ToString();
                    model.N_ORIGINALVALUE = Convert.ToDecimal(dt.Rows[i]["N_ORIGINALVALUE"].ToString());
                    model.D_CREATETIME = dTime;
                    model.C_STOVE = C_STOVE;

                    if (!string.IsNullOrEmpty(C_ANANO))
                    {
                        model.C_ANANO = Convert.ToDecimal(C_ANANO);
                    }

                    model.C_COMMISSIONID = C_COMMISSIONID;
                    model.C_SAMPID = C_SAMPID;

                    if (mod_Result != null)
                    {
                        model.N_STATUS = mod_Result.N_STATUS;
                        model.C_REMARK = mod_Result.C_REMARK;
                        model.N_SPLIT = mod_Result.N_SPLIT;
                        model.N_TYPE = mod_Result.N_TYPE;
                        model.C_GROUP = mod_Result.C_GROUP;
                        model.C_SHIFT = mod_Result.C_SHIFT;
                        model.D_SHIFTDATE = mod_Result.D_SHIFTDATE;
                        model.C_SAMPSORT = mod_Result.C_SAMPSORT;
                        model.C_IS_PD = mod_Result.C_IS_PD;
                    }

                    if (!dal.Add_Trans(model))
                    {
                        TransactionHelper.RollBack();
                        return "成分保存失败！";
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


        #endregion  BasicMethod
        #region  ExtensionMethod

        #endregion  ExtensionMethod
    }
}

