using System;
using System.Data;
using System.Collections.Generic;
using System.Collections;
using DAL;
using MODEL;
namespace BLL
{
    /// <summary>
    /// 送样信息(技术中心)
    /// </summary>
    public partial class Bll_TQC_PRESENT_SAMPLES_JSZX
    {
        private readonly Dal_TQC_PRESENT_SAMPLES_JSZX dal = new Dal_TQC_PRESENT_SAMPLES_JSZX();
        public Bll_TQC_PRESENT_SAMPLES_JSZX()
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
        public bool Add(Mod_TQC_PRESENT_SAMPLES_JSZX model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Mod_TQC_PRESENT_SAMPLES_JSZX model)
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
        public Mod_TQC_PRESENT_SAMPLES_JSZX GetModel(string C_ID)
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
        public List<Mod_TQC_PRESENT_SAMPLES_JSZX> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Mod_TQC_PRESENT_SAMPLES_JSZX> DataTableToList(DataTable dt)
        {
            List<Mod_TQC_PRESENT_SAMPLES_JSZX> modelList = new List<Mod_TQC_PRESENT_SAMPLES_JSZX>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Mod_TQC_PRESENT_SAMPLES_JSZX model;
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
        /// 检测技术中心是否已接收
        /// </summary>
        /// <param name="c_present_samples_id">取样主表主键（tqc_present_samples）</param>
        /// <param name="strState">送样状态   0-未送样；1-已送样；2-接收送样；3-制样</param>
        /// <returns></returns>
        public int Get_Count(string c_present_samples_id, string N_ENTRUST_TYPE)
        {
            return dal.Get_Count(c_present_samples_id, N_ENTRUST_TYPE);
        }

        #endregion  BasicMethod
        #region  ExtensionMethod


        /// <summary>
        /// 保存性能值
        /// </summary>
        /// <returns></returns>
        public string Cancle_Sample(int[] rownumber, DataTable dt)
        {
            try
            {
                string result = "1";

                TransactionHelper.BeginTransaction();

                string strUserID = RV.UI.UserInfo.userID;
                DateTime time = RV.UI.ServerTime.timeNow();

                Dal_TQC_PRESENT_SAMPLES_JSZX dalJSZX = new Dal_TQC_PRESENT_SAMPLES_JSZX();
                Dal_TQC_PHYSICS_RESULT_MAIN dalMain = new Dal_TQC_PHYSICS_RESULT_MAIN();
                Dal_TQC_PHYSICS_RESULT dalResult = new Dal_TQC_PHYSICS_RESULT();

                for (int i = 0; i < rownumber.Length; i++)
                {
                    int selectedHandle = rownumber[i];

                    string strID = dt.Rows[selectedHandle]["取样主表主键"].ToString();

                    Mod_TQC_PRESENT_SAMPLES_JSZX modJSZX = dalJSZX.GetModel_Trans(strID);
                    if (modJSZX != null)
                    {
                        modJSZX.N_ENTRUST_TYPE = 2;
                        modJSZX.C_EMP_ID_ZY = "";
                        modJSZX.D_MOD_DT_ZY = null;

                        if (!dalJSZX.Update_Trans(modJSZX))
                        {
                            TransactionHelper.RollBack();
                            return "取消接样失败！";
                        }

                        Mod_TQC_PHYSICS_RESULT_MAIN modMain = dalMain.GetModel_Main(modJSZX.C_ID);

                        if (modMain != null)
                        {
                            int count = dalResult.Get_Count(modMain.C_ID);

                            if(count>0)
                            {
                                TransactionHelper.RollBack();
                                return modMain.C_BATCH_NO+"已录入性能值，不能取消接样！";
                            }
                            else
                            {
                                if(!dalMain.Delete_Trans(modMain.C_ID))
                                {
                                    TransactionHelper.RollBack();
                                    return "取消接样失败！";
                                }
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


        #endregion  ExtensionMethod
    }
}

