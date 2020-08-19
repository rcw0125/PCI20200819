using System;
using System.Data;
using System.Collections.Generic;
using DAL;
using MODEL;
namespace BLL
{
    /// <summary>
    /// 检验基础数据
    /// </summary>
    public partial class Bll_TQB_CHARACTER
    {
        private readonly Dal_TQB_CHARACTER dal = new Dal_TQB_CHARACTER();
        public Bll_TQB_CHARACTER()
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
        public bool Add(Mod_TQB_CHARACTER model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Mod_TQB_CHARACTER model)
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
        public Mod_TQB_CHARACTER GetModel(string C_ID)
        {

            return dal.GetModel(C_ID);
        }


        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere, string c_type_id)
        {
            return dal.GetList(strWhere, c_type_id);
        }
        /// <summary>
		/// 获得数据列表_成分
		/// </summary>
		public DataSet GetList_JCSJ_CF(string strWhere)
        {
            return dal.GetList_JCSJ_CF(strWhere);
        }
        /// <summary>
        /// 获得数据列表_性能
        /// </summary>
        public DataSet GetList_JCSJ_XN(string strWhere)
        {
            return dal.GetList_JCSJ_XN(strWhere);
        }
        /// <summary>
        /// 获得数据列表_性能
        /// </summary>
        public DataSet GetList_JCSJ(string strWhere)
        {
            return dal.GetList_JCSJ(strWhere);
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetTypeAndCharacter(string C_ID)
        {
            return dal.GetTypeAndCharacter(C_ID);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList_TYPE_ID(string C_TYPE_ID)
        {

            return dal.GetList_TYPE_ID(C_TYPE_ID);

        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetCharacterNameList(string C_TYPE_ID)
        {
            return dal.GetCharacterNameList(C_TYPE_ID);
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetCharacterList(string C_CODE, string C_NAME)
        {
            return dal.GetCharacterList(C_CODE, C_NAME);
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Mod_TQB_CHARACTER> DataTableToList(DataTable dt)
        {
            List<Mod_TQB_CHARACTER> modelList = new List<Mod_TQB_CHARACTER>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Mod_TQB_CHARACTER model;
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
        /// 根据项目ID
        /// </summary>
        /// <param name="c_name">成分/性能 名称</param>
        /// <returns></returns>
        public string GetItemID(string c_name)
        {
            return dal.GetItemID(c_name);
        }

        /// <summary>
        /// 根据类别获取项目代码和名称
        /// </summary>
        /// <param name="strLB">类别：成分/性能</param>
        /// <returns></returns>
        public DataSet GetItemByLB(string strLB)
        {
            return dal.GetItemByLB(strLB);
        }
        /// <summary>
        /// 查询基础数据名称
        /// </summary>
        public DataSet GetList_Name(string strWhere, string type)
        {
            return dal.GetList_Name(strWhere, type);
        }
        /// <summary>
        /// 查询基础数据名称
        /// </summary>
        public DataSet GetList_CODE(string type, string code)
        {
            return dal.GetList_CODE(type, code);
        }
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            return dal.GetRecordCount(strWhere);
        }

        /// <summary>
        /// 查询基础数据名称
        /// </summary>
        public DataSet GetList_not_Name(string strWhere, string Name, string type)
        {
            return dal.GetList_not_Name(strWhere, Name, type);
        }

        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
        {
            return dal.GetListByPage(strWhere, orderby, startIndex, endIndex);
        }

        /// <summary>
		/// 获得数据列表_成分
		/// </summary>
		public DataSet GetList_CF(string C_NAME)
        {
            return dal.GetList_CF(C_NAME);
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList_Max()
        {
            return dal.GetList_Max();
        }

        #endregion  BasicMethod
    }
}

