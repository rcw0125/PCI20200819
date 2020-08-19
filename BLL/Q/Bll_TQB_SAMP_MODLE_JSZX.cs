using System;
using System.Data;
using System.Collections.Generic;
using DAL;
using MODEL;
namespace BLL
{
    /// <summary>
    /// 取样模板（技术中心）
    /// </summary>
    public partial class Bll_TQB_SAMP_MODLE_JSZX
    {
        private readonly Dal_TQB_SAMP_MODLE_JSZX dal = new Dal_TQB_SAMP_MODLE_JSZX();
        public Bll_TQB_SAMP_MODLE_JSZX()
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
        public bool Add(Mod_TQB_SAMP_MODLE_JSZX model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Mod_TQB_SAMP_MODLE_JSZX model)
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
        public Mod_TQB_SAMP_MODLE_JSZX GetModel(string C_ID)
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
        public List<Mod_TQB_SAMP_MODLE_JSZX> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Mod_TQB_SAMP_MODLE_JSZX> DataTableToList(DataTable dt)
        {
            List<Mod_TQB_SAMP_MODLE_JSZX> modelList = new List<Mod_TQB_SAMP_MODLE_JSZX>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Mod_TQB_SAMP_MODLE_JSZX model;
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
        public DataSet GetList(string C_STD_CODE, string C_STL_GRD)
        {
            return dal.GetList(C_STD_CODE, C_STL_GRD);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool update_status(string c_std_code, string c_stl_grd, string c_spec_min, string c_spec_max)
        {
            return dal.update_status(c_std_code, c_stl_grd, c_spec_min, c_spec_max);
        }

        #endregion  BasicMethod


        /// <summary>
        /// 保存模板信息
        /// </summary>
        /// <returns></returns>
        public string Save_Modle(DataTable dt)
        {
            try
            {
                string result = "1";

                TransactionHelper.BeginTransaction();

                string strUserID = RV.UI.UserInfo.userID;
                DateTime time = RV.UI.ServerTime.timeNow();

                Dal_TQB_SAMP_ITEM_MODLE_JSZX dalTqbItem = new Dal_TQB_SAMP_ITEM_MODLE_JSZX();
                Dal_TQB_SAMPLING dalTqbSampling = new Dal_TQB_SAMPLING();

                dalTqbItem.Update_Trans(dt.Rows[0]["执行标准"].ToString(), dt.Rows[0]["钢种"].ToString(), dt.Rows[0]["规格最小值"].ToString(), dt.Rows[0]["规格最大值"].ToString());

                if (!dal.update_Trans(dt.Rows[0]["执行标准"].ToString(), dt.Rows[0]["钢种"].ToString(), dt.Rows[0]["规格最小值"].ToString(), dt.Rows[0]["规格最大值"].ToString()))
                {
                    TransactionHelper.RollBack();
                    return "保存失败！";
                }

                for (int irow = 0; irow < dt.Rows.Count; irow++)
                {
                    Int64 i_ID = dal.Get_Max_ID_Trans();
                    i_ID++;
                    Mod_TQB_SAMP_MODLE_JSZX modMain = new Mod_TQB_SAMP_MODLE_JSZX();
                    modMain.C_ID = i_ID.ToString();
                    modMain.C_STD_CODE = dt.Rows[irow]["执行标准"].ToString();
                    modMain.C_STL_GRD = dt.Rows[irow]["钢种"].ToString();
                    modMain.C_SPEC_MIN = dt.Rows[irow]["规格最小值"].ToString();
                    modMain.C_SPEC_MAX = dt.Rows[irow]["规格最大值"].ToString();
                    modMain.C_EMP_ID = strUserID;
                    modMain.D_MOD_DT = time;

                    if (!dal.Add_Trans(modMain))
                    {
                        TransactionHelper.RollBack();
                        return "保存失败！";
                    }

                    for (int icol = 5; icol < dt.Columns.Count; icol++)
                    {
                        if (!string.IsNullOrEmpty(dt.Rows[irow][icol].ToString().Trim()))
                        {
                            Mod_TQB_SAMP_ITEM_MODLE_JSZX modItem = new Mod_TQB_SAMP_ITEM_MODLE_JSZX();

                            string SampId = dalTqbSampling.GetSampId(dt.Columns[icol].ColumnName, "技术中心");

                            modItem.C_SAMP_MODLE_ID = i_ID.ToString();
                            modItem.C_SAMPLES_ID = SampId;
                            modItem.C_SAM_NUM = dt.Rows[irow][icol].ToString();
                            modItem.C_EMP_ID = strUserID;
                            modItem.D_MOD_DT = time;
                            modItem.C_SAMPLES_NAME = dt.Columns[icol].ColumnName;

                            if (!dalTqbItem.Add_Trans(modItem))
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
    }
}

