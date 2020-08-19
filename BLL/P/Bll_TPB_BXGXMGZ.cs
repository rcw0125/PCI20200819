using DAL;
using MODEL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;

namespace BLL
{
    /// <summary>
    /// 不锈钢修磨规则
    /// </summary>
    public partial class Bll_TPB_BXGXMGZ
    {
        private readonly Dal_TPB_BXGXMGZ dal = new Dal_TPB_BXGXMGZ();
        public Bll_TPB_BXGXMGZ()
        { }
        #region  BasicMethod
        

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Mod_TPB_BXGXMGZ model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Mod_TPB_BXGXMGZ model)
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
        public Mod_TPB_BXGXMGZ GetModel(string C_ID)
        {

            return dal.GetModel(C_ID);
        }
        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Mod_TPB_BXGXMGZ GetModel(string C_STL_GRD, string C_SLAB_SIZE, decimal N_LTH, string C_GZLX)
        {
            return dal.GetModel( C_STL_GRD,  C_SLAB_SIZE,  N_LTH,  C_GZLX);
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
        public List<Mod_TPB_BXGXMGZ> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Mod_TPB_BXGXMGZ> DataTableToList(DataTable dt)
        {
            List<Mod_TPB_BXGXMGZ> modelList = new List<Mod_TPB_BXGXMGZ>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Mod_TPB_BXGXMGZ model;
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
        
        #endregion  BasicMethod
        #region  ExtensionMethod

        #endregion  ExtensionMethod
    }
}
