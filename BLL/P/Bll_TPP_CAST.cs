using System;
using System.Data;
using System.Collections.Generic;
using DAL;
using MODEL;
namespace BLL
{
    /// <summary>
    /// 浇次计划表
    /// </summary>
    public partial class Bll_TPP_CAST
    {
        private readonly Dal_TPP_CAST dal = new Dal_TPP_CAST();
        public Bll_TPP_CAST()
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
        public bool Add(Mod_TPP_CAST model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Mod_TPP_CAST model)
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
        public Mod_TPP_CAST GetModel(string C_ID)
        {
            return dal.GetModel(C_ID);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Mod_TPP_CAST GetModel(string str_SORT, string C_CCM_ID)
        {
            return dal.GetModel(str_SORT, C_CCM_ID);
        }

        /// <summary>
        /// 获得数据列表-获得顺序号
        /// </summary>
        /// <param name="strWhere">工位</param>
        /// <param name="C_INITIALIZE_ITEM">方案号</param>
        /// <returns></returns>
        public DataSet GetList_Number(string strWhere, string C_INITIALIZE_ITEM)
        {
            return dal.GetList_Number(strWhere, C_INITIALIZE_ITEM);
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
        public List<Mod_TPP_CAST> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Mod_TPP_CAST> DataTableToList(DataTable dt)
        {
            List<Mod_TPP_CAST> modelList = new List<Mod_TPP_CAST>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Mod_TPP_CAST model;
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
        /// 获得数据列表-方案和工位查询
        /// </summary>
        /// <param name="C_INITIALIZE_ITEM">铸机号</param>
        /// <param name="C_CCM_CODE">工位</param>
        /// <returns></returns>
        public DataSet GetList_Code(string C_INITIALIZE_ITEM, string C_CCM_CODE)
        {
            return dal.GetList_Code(C_INITIALIZE_ITEM, C_CCM_CODE);

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
        /// 获取最大顺序号
        /// </summary>
        /// <param name="c_ccm_code"></param>
        /// <returns></returns>
        public int GetMaxSort(string c_ccm_code)
        {
            return dal.GetMaxSort(c_ccm_code);
        }

        /// <summary>
        /// 获取最大浇次号
        /// </summary>
        /// <param name="C_CCM_ID"></param>
        /// <returns></returns>
        public string GetMaxCastNo(string C_CCM_ID)
        {
            return dal.GetMaxCastNo(C_CCM_ID);
        }

        /// <summary>
        /// 获取浇次信息
        /// </summary>
        /// <param name="C_INITIALIZE_ITEM">方案号</param>
        /// <param name="C_CCM_CODE">工位</param>
        /// <returns></returns>
        public DataSet GetList_JC(string C_INITIALIZE_ITEM, string C_CCM_CODE)
        {
            return dal.GetList_JC(C_INITIALIZE_ITEM, C_CCM_CODE);
        }
        /// <summary>
        /// 修改生产顺序
        /// </summary>
        /// <param name="c_id">主键</param>
        /// <param name="C_CCM_CODE">工位</param>
        /// <param name="C_INITIALIZE_ITEM">方案</param>
        /// <param name="sort_new">顺序-新</param>
        /// <param name="sort_old">顺序-旧</param>
        /// <param name="stype">判断大小</param>
        /// <returns></returns>
        public bool Update_SX(string c_id, string C_CCM_CODE, string C_INITIALIZE_ITEM, int sort_new, int sort_old, string stype)
        {
            return dal.Update_SX(c_id, C_CCM_CODE, C_INITIALIZE_ITEM, sort_new, sort_old, stype);
        }

        /// <summary>
        /// 更新浇次子计划
        /// </summary>
        /// <param name="P_INITIALIZE_ITEM_ID">订单方案号</param>
        /// <param name="P_CCM_CODE">连铸机代码</param>
        /// <returns></returns>
        public int Update_LG_Plan(string P_INITIALIZE_ITEM_ID, string P_CCM_CODE)
        {
            return dal.Update_LG_Plan(P_INITIALIZE_ITEM_ID, P_CCM_CODE);
        }

        #endregion  BasicMethod

    }
}

