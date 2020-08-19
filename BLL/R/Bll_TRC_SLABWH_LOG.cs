using System;
using System.Data;
using System.Collections.Generic;
using DAL;
using MODEL;
namespace BLL
{/// <summary>
 /// 钢坯记录表
 /// </summary>
    public partial class Bll_TRC_SLABWH_LOG
    {
        private readonly Dal_TRC_SLABWH_LOG dal = new Dal_TRC_SLABWH_LOG();
        public Bll_TRC_SLABWH_LOG()
        { }
        #region  BasicMethod

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Mod_TRC_SLABWH_LOG model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Mod_TRC_SLABWH_LOG model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(string C_ID)
        {
            //该表无主键信息，请自定义主键/条件字段
            return dal.Delete(C_ID);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Mod_TRC_SLABWH_LOG GetModel(string C_ID)
        {
            //该表无主键信息，请自定义主键/条件字段
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

        #endregion  BasicMethod
        #region  ExtensionMethod
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(int status, string movetype, string grd, string std, string stove)
        {
            return dal.GetList(status, movetype, grd, std, stove);
        }
        /// <summary>
        /// 查询钢种记录
        /// </summary>
        public DataSet GetSLABCount(string slabid,string type)
        {
            return dal.GetSLABCount(slabid,type);
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Upstatus(string slabid, int status, int order)
        {
            return dal.Upstatus(slabid, status, order);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetListByID(string slabid,string type)
        {
            return dal.GetListByID(slabid, type);
        }
        /// <summary>
        /// 根据操作类型记录总数
        /// </summary>
        public int GetDBCount(string slabid, string type)
        {
            return dal.GetDBCount(slabid,type);
        }
            #endregion  ExtensionMethod
        }
}
