using System;
using System.Data;
using System.Collections.Generic;
using DAL;
using MODEL;
namespace BLL
{
    /// <summary>
    /// 钢坯倒垛信息
    /// </summary>
    public partial class Bll_TSC_SLAB_STACK
    {
        private readonly Dal_TSC_SLAB_STACK dal = new Dal_TSC_SLAB_STACK();
        public Bll_TSC_SLAB_STACK()
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
        public bool Add(Mod_TSC_SLAB_STACK model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Mod_TSC_SLAB_STACK model)
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
        public Mod_TSC_SLAB_STACK GetModel(string C_ID)
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
        public List<Mod_TSC_SLAB_STACK> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Mod_TSC_SLAB_STACK> DataTableToList(DataTable dt)
        {
            List<Mod_TSC_SLAB_STACK> modelList = new List<Mod_TSC_SLAB_STACK>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Mod_TSC_SLAB_STACK model;
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
        /// 倒垛
        /// </summary>
        /// <returns></returns>
        public string Add_DD(DataRow dr, int num, string slabwhCode, string area, string kw, string floor, string shift, string group, string remark)
        {
            string result = "1";
            try
            {
                TransactionHelper.BeginTransaction();

                string strUserID = RV.UI.UserInfo.userID;
                DateTime time = RV.UI.ServerTime.timeNow();

                DataTable billet = new DataTable();
                if (dal.UpdateMoveType(dr["C_STOVE"].ToString(), dr["C_STL_GRD"].ToString(), dr["C_SPEC"].ToString(), dr["C_STD_CODE"].ToString(), dr["C_MAT_CODE"].ToString(), num, slabwhCode, dr["C_SLABWH_AREA_CODE"].ToString(), dr["C_SLABWH_LOC_CODE"].ToString(), dr["C_SLABWH_TIER_CODE"].ToString(), area, kw, floor, shift, group, strUserID, time, out billet, dr["C_BATCH_NO"].ToString(), remark) != num)
                {
                    TransactionHelper.RollBack();
                    return "0";
                }

                if (billet != null && billet.Rows.Count > 0)
                {
                    foreach (DataRow item in billet.Rows)
                    {
                        Mod_TSC_SLAB_STACK model = new Mod_TSC_SLAB_STACK();
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

                        model.C_STOCK_CODE_OLD = item["C_SLABWH_CODE"].ToString();
                        model.C_AREA_CODE_OLD = item["C_SLABWH_AREA_CODE"].ToString();
                        model.C_KW_CODE_OLD = item["C_SLABWH_LOC_CODE"].ToString();
                        model.C_FLOOD_CODE_OLD = item["C_SLABWH_TIER_CODE"].ToString();

                        model.C_STOCK_CODE_NEW = item["C_SLABWH_CODE"].ToString();
                        model.C_AREA_CODE_NEW = area;
                        model.C_KW_CODE_NEW = kw;
                        model.C_FLOOD_CODE_NEW = floor;

                        model.D_STACK_DATE = time;
                        model.C_STACK_GROUP = group;
                        model.C_STACK_SHIFT = shift;
                        model.C_STACK_EMP_ID = strUserID;

                        if (!dal.Add(model))
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
        /// 获取入库记录
        /// </summary>
        /// <param name="strKW">库位编码</param>
        /// <param name="strStove">炉号</param>
        /// <param name="strTimeStart">开始时间</param>
        /// <param name="strTimeEnd">结束时间</param>
        /// <returns></returns>
        public DataSet Get_DD_Log(string strKW, string strStove, string strTimeStart, string strTimeEnd, string kwCode)
        {
            return dal.Get_DD_Log(strKW, strStove, strTimeStart, strTimeEnd, kwCode);
        }
        /// <summary>
        /// 获取倒垛记录
        /// </summary>
        /// <param name="strTimeStart">开始时间</param>
        /// <param name="strTimeEnd">结束时间</param>
        /// <param name="strStove">炉号</param>
        /// <param name="strSTLGRD">钢种</param>
        /// <param name="strSTD">执行标准</param>
        /// <returns></returns>
        public DataSet Get_DD(string strTimeStart, string strTimeEnd, string strStove, string strSTLGRD, string strSTD)
        {
            return dal.Get_DD(strTimeStart, strTimeEnd, strStove, strSTLGRD, strSTD);
        }
        #endregion  BasicMethod

    }
}

