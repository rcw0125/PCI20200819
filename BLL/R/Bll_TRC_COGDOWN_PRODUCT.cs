using DAL;
using MODEL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace BLL
{
    public partial class Bll_TRC_COGDOWN_PRODUCT
    {
        private readonly Dal_TRC_COGDOWN_PRODUCT dal = new Dal_TRC_COGDOWN_PRODUCT();
        public Bll_TRC_COGDOWN_PRODUCT()
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
        public bool Add(Mod_TRC_COGDOWN_PRODUCT model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Mod_TRC_COGDOWN_PRODUCT model)
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
        /// 得到一个对象实体
        /// </summary>
        public Mod_TRC_COGDOWN_PRODUCT GetModel(string C_ID)
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
        public List<Mod_TRC_COGDOWN_PRODUCT> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Mod_TRC_COGDOWN_PRODUCT> DataTableToList(DataTable dt)
        {
            List<Mod_TRC_COGDOWN_PRODUCT> modelList = new List<Mod_TRC_COGDOWN_PRODUCT>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Mod_TRC_COGDOWN_PRODUCT model;
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
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
        {
            return dal.GetListByPage(strWhere, orderby, startIndex, endIndex);
        }

        #endregion  BasicMethod
        #region  ExtensionMethod
        /// <summary>
        /// 获取开坯班次记录
        /// </summary>
        /// <returns></returns>
        public DataTable GetBcJl(string rqStart, string rqEnd, string shift,string prodLine)
        {
            return dal.GetBcJl(rqStart, rqEnd, shift, prodLine);
        }

        /// <summary>
        /// 获取开坯消耗
        /// </summary>
        /// <returns></returns>
        public DataTable GetConSume(DataTable dt)
        {
            return dal.GetConSume(dt);
        }

        /// <summary>
        /// 获取产线
        /// </summary>
        /// <param name="codeLike">模糊查询产线编码字符串</param>
        /// <returns>获取工位表格</returns>
        public DataTable GetProdLine(string codeLike)
        {
            return dal.GetProdLine(codeLike);
        }
        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Mod_TRC_COGDOWN_PRODUCT GetModelByCOGID(string C_COGDOWN_ID)
        {
            return dal.GetModelByCOGID(C_COGDOWN_ID);
        }
            #endregion  ExtensionMethod
        }
}
