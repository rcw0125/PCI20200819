using System;
using System.Data;
using System.Collections.Generic;
using DAL;
using MODEL;
namespace BLL
{
    /// <summary>
    /// 物理检验项目配置-设备
    /// </summary>
    public partial class Bll_TQB_PHYSICS_EQUIPMENT
    {
        private readonly Dal_TQB_PHYSICS_EQUIPMENT dal = new Dal_TQB_PHYSICS_EQUIPMENT();
        public Bll_TQB_PHYSICS_EQUIPMENT()
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
        public bool Add(Mod_TQB_PHYSICS_EQUIPMENT model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Mod_TQB_PHYSICS_EQUIPMENT model)
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
        public Mod_TQB_PHYSICS_EQUIPMENT GetModel(string C_ID)
        {

            return dal.GetModel(C_ID);
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        /// <param name="strWhere">设备编号</param>
        /// <returns></returns>
        public DataSet GetList_Query(string strWhere)
        {
            return dal.GetList_Query(strWhere);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        /// <param name="strWhere">外键</param>
        /// <returns></returns>
        public DataSet GetList_Fid(string strWhere)
        {

            return dal.GetList_Fid(strWhere);
        }
        /// <summary>
        /// 根据设备名称获得数据列表
        /// </summary>
        public DataSet GetList(string C_EQ_NAME)
        {
            return dal.GetList(C_EQ_NAME);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Mod_TQB_PHYSICS_EQUIPMENT> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Mod_TQB_PHYSICS_EQUIPMENT> DataTableToList(DataTable dt)
        {
            List<Mod_TQB_PHYSICS_EQUIPMENT> modelList = new List<Mod_TQB_PHYSICS_EQUIPMENT>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Mod_TQB_PHYSICS_EQUIPMENT model;
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
        /// 获得数据列表
        /// </summary>
        /// <param name="C_PHYSICS_GROUP_ID">外键</param>
        /// <param name="C_EQ_NAME">设备名称</param>
        /// <returns></returns>
        public DataSet GetList_Number(string C_PHYSICS_GROUP_ID, string C_EQ_NAME)
        {
            return dal.GetList_Number(C_PHYSICS_GROUP_ID, C_EQ_NAME);

        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        /// <param name="C_PHYSICS_GROUP_ID">外键</param>
        /// <param name="C_EQ_NAME">设备名称</param>
        /// <param name="C_EQ_Number">设备编号</param>
        /// <returns></returns>
        public DataSet GetList_Code(string C_PHYSICS_GROUP_ID, string C_EQ_NAME, string C_EQ_Number)
        {

            return dal.GetList_Code(C_PHYSICS_GROUP_ID, C_EQ_NAME, C_EQ_Number);

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

        #endregion  ExtensionMethod
    }
}

