using System;
using System.Data;
using System.Collections.Generic;
using DAL;
using MODEL;
namespace BLL
{
    /// <summary>
    /// 工位表
    /// </summary>
    public partial class Bll_TB_STA
    {
        private readonly Dal_TB_STA dal = new Dal_TB_STA();
        public Bll_TB_STA()
        { }
        #region  BasicMethod

        /// <summary>
        /// 根据工序id，数据状态加载数据列表
        /// </summary>
        /// <param name="iStatus">状态</param>
        /// <param name="strGXID">工序ID</param>
        /// <returns></returns>
        public DataSet GetListByStatus(int iStatus, string strGXID, string C_STA_DESC)
        {
            return dal.GetListByStatus(iStatus, strGXID, C_STA_DESC);
        }
        /// <summary>
        /// 根据备注，数据状态加载数据列表
        /// </summary>
        /// <param name="iStatus">状态</param>
        /// <param name="strBZ">备注</param>
        /// <returns></returns>
        public DataSet GetListByStatusAndBZ(int iStatus, string strBZ)
        {
            return dal.GetListByStatusANDBZ(iStatus, strBZ);
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
        public bool Add(Mod_TB_STA model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Mod_TB_STA model)
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
        public Mod_TB_STA GetModel(string C_ID)
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
        public List<Mod_TB_STA> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Mod_TB_STA> GetStaList(string strWHERE)
        {
            DataSet ds = dal.GetStaList(strWHERE);
            return DataTableToList(ds.Tables[0]);

        }


        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Mod_TB_STA> DataTableToList(DataTable dt)
        {
            List<Mod_TB_STA> modelList = new List<Mod_TB_STA>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Mod_TB_STA model;
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
            return dal.GetALLList();
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet Get_CN()
        {
            return dal.Get_CN();
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet Get_CN_CODE(string c_sta_code)
        {
            return dal.Get_CN_CODE(c_sta_code);
        }

        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public int GetRecordCount(string C_PRO_ID)
        {
            return dal.GetRecordCount(C_PRO_ID);
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
        /// 根据工序类型，数据状态加载数据列表
        /// </summary>
        /// <param name="iStatus">状态</param>
        /// <param name="strGXID">类型 炼钢/轧钢</param>
        /// <returns></returns>
        public DataSet GetListByType(int iStatus, string strType)
        {
            return dal.GetListByType(iStatus, strType);
        }
        /// <summary>
        /// 加载炼钢工位产能
        /// </summary>
        /// <returns></returns>
        public DataSet GetListGWCN(string grd, string std)
        {
            return dal.GetListGWCN(grd, std);
        }
        /// <summary>
        /// 加载钢坯机试产能
        /// </summary>
        /// <returns></returns>
        public DataSet GetListGPCN(string grd, string std, string spec)
        {
            return dal.GetListGPCN(grd, std, spec);
        }
        /// <summary>
        /// 根据工序加载工位
        /// </summary>
        /// <param name="strGX">工序： 轧制/开坯</param>
        /// <returns></returns>
        public DataSet GetListByGX(string strGX)
        {
            return dal.GetListByGX(strGX);

        }

        /// <summary>
        /// 加载转炉工位
        /// </summary>
        /// <returns></returns>
        public DataSet GetListByZLGX()
        {
            return dal.GetListByZLGX();
        }
        /// <summary>
        /// 根据工序代码加载工位
        /// </summary>
        /// <param name="strGXDM">工序代码</param>
        /// <returns></returns>
        public DataSet GetListByGXDM(string strGXDM)
        {
            return dal.GetListByGXDM(strGXDM);
        }
        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Mod_TB_STA GetModelByCODE(string C_STA_CODE)
        {
            return dal.GetModelByCODE(C_STA_CODE);
        }
        /// <summary>
        /// 检查是否存在重复数据
        /// </summary>
        /// <param name="strProCode">工序主键</param>
        /// <returns></returns>
        public bool ExistsBySTACode(string C_STA_CODE)
        {
            return dal.ExistsBySTACode(C_STA_CODE);
        }

        /// <summary>
        /// 根据工位代码获取工位主键
        /// </summary>
        /// <param name="C_STA_CODE">工位代码</param>
        /// <returns></returns>
        public string GetStaIdByCode(string C_STA_CODE)
        {
            return dal.GetStaIdByCode(C_STA_CODE);
        }
        /// <summary>
        /// 根据工位代码获取工序主键
        /// </summary>
        /// <param name="C_STA_CODE">工位代码</param>
        /// <returns></returns>
        public string GetproIdByCode(string C_STA_CODE)
        {
            return dal.GetproIdByCode(C_STA_CODE);
        }
            /// <summary>
            /// 根据工序描述加载工位
            /// </summary>
            /// <param name="strGX">工序： 轧制/开坯</param>
            /// <returns></returns>
            public DataSet GetListByGXStr(string strGX)
        {
            return dal.GetListByGXStr(strGX);
        }

        /// <summary>
        /// 根据工位主键获取工位代码
        /// </summary>
        /// <param name="C_ID">工位主键</param>
        /// <returns></returns>
        public string Get_STA_CODE(string C_ID)
        {
            return dal.Get_STA_CODE(C_ID);
        }

        /// <summary>
        /// 根据工位主键获取工位名称
        /// </summary>
        /// <param name="C_ID">工位主键</param>
        /// <returns>工位名称</returns>
        public string Get_STA_DESC(string C_ID)
        {

            return dal.Get_STA_DESC(C_ID);
        }

        /// <summary>
        /// 根据工位主键获取NC主键
        /// </summary>
        /// <param name="C_ID">工位主键</param>
        /// <returns>工位名称</returns>
        public string Get_NC_ID(string C_ID)
        {
            return dal.Get_NC_ID(C_ID);
        }


        /// <summary>
        /// 根据工位主键获取工位代码
        /// </summary>
        /// <param name="C_ID">工位主键</param>
        /// <returns></returns>
        public string Get_CODE(string C_ID)
        {
            return dal.Get_CODE(C_ID);
        }
        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Mod_TB_STA GetModelBySoft(string N_SORT, string C_PRO_ID)
        {
            return dal.GetModelBySoft(N_SORT, C_PRO_ID);
        }
        /// <summary>
        /// 重置顺序
        /// </summary>
        public int CZSORT(string pro)
        {
            return dal.CZSORT(pro);
        }
        #endregion  ExtensionMethod
    }
}

