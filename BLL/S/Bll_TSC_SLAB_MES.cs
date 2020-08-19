using System;
using System.Data;
using System.Collections.Generic;
using DAL;
using MODEL;
using System.Collections;

namespace BLL
{
    /// <summary>
    /// TSC_SLAB_MES
    /// </summary>
    public partial class Bll_TSC_SLAB_MES
    {
        private readonly Dal_TSC_SLAB_MES dal = new Dal_TSC_SLAB_MES();
        public Bll_TSC_SLAB_MES()
        { }
        #region  BasicMethod

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Mod_TSC_SLAB_MES model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Mod_TSC_SLAB_MES model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete()
        {
            //该表无主键信息，请自定义主键/条件字段
            return dal.Delete();
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Mod_TSC_SLAB_MES GetModel(string stove)
        {
            //该表无主键信息，请自定义主键/条件字段
            return dal.GetModel(stove);
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
        /// 获取钢坯实绩信息
        /// </summary>
        /// <param name="timeStart">生产时间（开始）</param>
        /// <param name="timeEnd">生产时间（结束）</param>
        /// <param name="stove">炉号</param>
        /// <param name="strGrd">钢种</param>
        /// <param name="strState">是否上传（Y/N）</param>
        /// <returns></returns>
        public DataSet GetList(string timeStart, string timeEnd, string stove, string strGrd, string strState)
        {
            return dal.GetList(timeStart, timeEnd, stove, strGrd, strState);
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet Get_List(string MATERIALID)
        {
            return dal.Get_List(MATERIALID);
        }

        #endregion  BasicMethod


        /// <summary>
        /// 保存送样信息
        /// </summary>
        public bool Del_Stove(ArrayList SQLStringList)
        {
            return dal.Del_Stove(SQLStringList);
        }
    }
}

