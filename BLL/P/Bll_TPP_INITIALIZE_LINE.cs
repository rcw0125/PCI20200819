using System;
using System.Data;
using System.Collections.Generic;
using DAL;
using MODEL;
namespace BLL
{
    /// <summary>
    /// 方案炼钢产线
    /// </summary>
    public partial class Bll_TPP_INITIALIZE_LINE
    {
        private readonly Dal_TPP_INITIALIZE_LINE dal = new Dal_TPP_INITIALIZE_LINE();
        public Bll_TPP_INITIALIZE_LINE()
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
        public bool Add(Mod_TPP_INITIALIZE_LINE model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Mod_TPP_INITIALIZE_LINE model)
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
        public Mod_TPP_INITIALIZE_LINE GetModel(string C_ID)
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
        public List<Mod_TPP_INITIALIZE_LINE> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Mod_TPP_INITIALIZE_LINE> DataTableToList(DataTable dt)
        {
            List<Mod_TPP_INITIALIZE_LINE> modelList = new List<Mod_TPP_INITIALIZE_LINE>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Mod_TPP_INITIALIZE_LINE model;
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
        /// 分页获取数据列表
        /// </summary>
        //public DataSet GetList(int PageSize,int PageIndex,string strWhere)
        //{
        //return dal.GetList(PageSize,PageIndex,strWhere);
        //}

        #endregion  BasicMethod
        #region  ExtensionMethod
        /// <summary>
        /// 查询当前方案的炼钢工艺路线
        /// </summary>
        /// <param name="C_INITIALIZE_ITEM_ID">方案主键</param>
        /// <returns></returns>
        public DataSet GetListByIniID(string C_INITIALIZE_ITEM_ID)
        {
            return dal.GetListByIniID(C_INITIALIZE_ITEM_ID);
        }
        /// <summary>
        /// 查询产线
        /// </summary>
        /// <param name="C_INITIALIZE_ITEM_ID">方案</param>
        /// <returns></returns>

        public DataSet GetCXList(string C_INITIALIZE_ITEM_ID)
        {
            return dal.GetCXList(C_INITIALIZE_ITEM_ID);
        }

        /// <summary>
        /// 删除该方案下数据
        /// </summary>
        public bool DeleteByFa(string FID)
        {

            return dal.DeleteByFa(FID);
        }

        /// <summary>
        /// 根据连铸主键获取炼钢生产工位路线
        /// </summary>
        /// <param name="C_LZ_STA_DESC">连铸主键</param>
        /// <returns></returns>
        public Mod_TPP_INITIALIZE_LINE GetListByLZID(string C_LZ_STA_DESC)
        {
            return dal.GetListByLZID(C_LZ_STA_DESC);
        }
            #endregion  ExtensionMethod
        }
    }
