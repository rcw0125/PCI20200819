using System;
using System.Data;
using System.Collections.Generic;
using DAL;
using MODEL;
namespace BLL
{
    /// <summary>
    /// 生产工位机时产能
    /// </summary>
    public partial class Bll_TPB_STEEL_SMELT_TIME
    {
        private readonly Dal_TPB_STEEL_SMELT_TIME dal = new Dal_TPB_STEEL_SMELT_TIME();
        public Bll_TPB_STEEL_SMELT_TIME()
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
        public bool Add(Mod_TPB_STEEL_SMELT_TIME model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Mod_TPB_STEEL_SMELT_TIME model)
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
        public Mod_TPB_STEEL_SMELT_TIME GetModel(string C_ID)
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
        public DataSet GetAllList()
        {
            return GetList("");
        }



        #endregion  BasicMethod
        #region  ExtensionMethod
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(int status, string pro, string sta, string grd, string std)
        {
            return dal.GetList(status, pro, sta, grd, std);
        }
        /// <summary>
        /// 是否存在相同数据
        /// </summary>
        public bool ExistsDate(string C_PRO_ID, string C_STA_ID)
        {
            return dal.ExistsDate(C_PRO_ID, C_STA_ID);
        }

            #endregion  ExtensionMethod
        }
}