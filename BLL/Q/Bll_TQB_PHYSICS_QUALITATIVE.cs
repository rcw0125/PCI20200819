using System;
using System.Data;
using System.Collections.Generic;
using DAL;
using MODEL;
namespace BLL
{
    /// <summary>
    /// 物理检验定性
    /// </summary>
    public partial class Bll_TQB_PHYSICS_QUALITATIVE
    {
        private readonly Dal_TQB_PHYSICS_QUALITATIVE dal = new Dal_TQB_PHYSICS_QUALITATIVE();
        public Bll_TQB_PHYSICS_QUALITATIVE()
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
        public bool Add(Mod_TQB_PHYSICS_QUALITATIVE model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Mod_TQB_PHYSICS_QUALITATIVE model)
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
        public Mod_TQB_PHYSICS_QUALITATIVE GetModel(string C_ID)
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
        public List<Mod_TQB_PHYSICS_QUALITATIVE> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Mod_TQB_PHYSICS_QUALITATIVE> DataTableToList(DataTable dt)
        {
            List<Mod_TQB_PHYSICS_QUALITATIVE> modelList = new List<Mod_TQB_PHYSICS_QUALITATIVE>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Mod_TQB_PHYSICS_QUALITATIVE model;
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
        /// 获取定性列表
        /// </summary>
        /// <param name="C_PHYSICS_GROUP_ID">物理性能分组ID</param>
        /// <returns></returns>
        public DataSet Get_List(string C_PHYSICS_GROUP_ID)
        {
            return dal.Get_List(C_PHYSICS_GROUP_ID);
        }

        /// <summary>
        /// 获取定性列表
        /// </summary>
        /// <param name="C_PHYSICS_GROUP_ID">物理性能分组ID</param>
        /// <returns></returns>
        public DataSet Get_DX_List(string C_PHYSICS_GROUP_ID)
        {
            return dal.Get_DX_List(C_PHYSICS_GROUP_ID);
        }

        #endregion  BasicMethod
        #region  ExtensionMethod

        #endregion  ExtensionMethod
    }
}

