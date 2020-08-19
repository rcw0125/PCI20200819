using System;
using System.Data;
using System.Collections.Generic;
using DAL;
using MODEL;
namespace BLL
{
    /// <summary>
    /// 钢坯修磨表
    /// </summary>
    public partial class Bll_TSC_SLAB_MAIN_XM
    {
        private readonly Dal_TSC_SLAB_MAIN_XM dal = new Dal_TSC_SLAB_MAIN_XM();
        public Bll_TSC_SLAB_MAIN_XM()
        { }
        #region  BasicMethod

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Mod_TSC_SLAB_MAIN_XM model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Mod_TSC_SLAB_MAIN_XM model)
        {
            return dal.Update(model);
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


        #endregion  BasicMethod
        #region  ExtensionMethod
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string sta, string xmgx, string lh, string grd, string std, DateTime time, int status)
        {
            return dal.GetList(sta,xmgx,lh,grd,std,time,status);
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(string cid, string status)
        {
            return dal.Update(cid,status);
        }
            #endregion  ExtensionMethod
        }
}
