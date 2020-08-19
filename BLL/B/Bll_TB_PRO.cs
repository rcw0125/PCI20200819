using System;
using System.Data;
using System.Collections.Generic;
using DAL;
using MODEL;
namespace BLL
{
    /// <summary>
    /// 工序表
    /// </summary>
    public partial class Bll_TB_PRO
    {
        private readonly Dal_TB_PRO dal = new Dal_TB_PRO();
        public Bll_TB_PRO()
        { }
        #region  BasicMethod


        /// <summary>
        /// 检查是否存在重复数据
        /// </summary>
        /// <param name="strProCode">工序主键</param>
        /// <returns></returns>
        public bool ExistsByProCode(string strProCode)
        {
            return dal.ExistsByProCode(strProCode);

        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetListByStatus(int iStatus, string gx, string str)
        {
            return dal.GetListByStatus(iStatus, gx, str);
        }
        /// <summary>
        /// 查询该工序下工位是否全部停用
        /// </summary>
        /// <param name="C_PRO_ID">工序主键</param>
        /// <returns></returns>
        public bool ExistsNOSotpGX(string C_PRO_ID)
        {
            return dal.ExistsNOSotpGX(C_PRO_ID);
        }

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
        public bool Add(Mod_TB_PRO model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Mod_TB_PRO model)
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
        public Mod_TB_PRO GetModel(string C_ID)
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
        public List<Mod_TB_PRO> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Mod_TB_PRO> DataTableToList(DataTable dt)
        {
            List<Mod_TB_PRO> modelList = new List<Mod_TB_PRO>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Mod_TB_PRO model;
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
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount()
        {
            return dal.GetRecordCount();
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
        /// 工序主键
        /// </summary>
        /// <param name="strProCode">工序代码</param>
        /// <returns></returns>
        public string GetIDByProCode(string strProCode)
        {
            return dal.GetIDByProCode(strProCode);
        }
        /// <summary>
        /// 根据顺序号得到一个对象实体
        /// </summary>
        public Mod_TB_PRO GetModelBySoft(string N_SORT)
        {
            return dal.GetModelBySoft(N_SORT);
        }
        /// <summary>
        /// 重置顺序
        /// </summary>
        public int CZSORT()
        {
            return dal.CZSORT();
        }
            #endregion  ExtensionMethod
        }
}

