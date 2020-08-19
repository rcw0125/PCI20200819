using System;
using System.Data;
using System.Collections.Generic;
using DAL;
using MODEL;
namespace BLL
{
    /// <summary>
    /// 物理性能分组匹配执行
    /// </summary>
    public partial class Bll_TQB_PHYSICS_GROUP_STD
    {
        private readonly Dal_TQB_PHYSICS_GROUP_STD dal = new Dal_TQB_PHYSICS_GROUP_STD();
        public Bll_TQB_PHYSICS_GROUP_STD()
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
        public bool Add(Mod_TQB_PHYSICS_GROUP_STD model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Mod_TQB_PHYSICS_GROUP_STD model)
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
        public Mod_TQB_PHYSICS_GROUP_STD GetModel(string C_ID)
        {

            return dal.GetModel(C_ID);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Mod_TQB_PHYSICS_GROUP_STD GetModel(string C_PHYSICS_CODE, string C_STD_CODE, string C_STL_GRD)
        {
            return dal.GetModel(C_PHYSICS_CODE, C_STD_CODE, C_STL_GRD);
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

        /// <summary>
        /// 获取列表信息
        /// </summary>
        /// <param name="C_PHYSICS_CODE">物理性能分组代码</param>
        /// <returns></returns>
        public DataSet Get_List(string C_PHYSICS_CODE)
        {
            return dal.Get_List(C_PHYSICS_CODE);
        }

        #endregion  BasicMethod

    }
}

