using System;
using System.Data;
using System.Collections.Generic;
using DAL;
using MODEL;
namespace BLL
{
    /// <summary>
    /// 线材表面判定信息表
    /// </summary>
    public partial class Bll_TQC_FACE_ROLL
    {
        private readonly Dal_TQC_FACE_ROLL dal = new Dal_TQC_FACE_ROLL();
        public Bll_TQC_FACE_ROLL()
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
        public bool Add(Mod_TQC_FACE_ROLL model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Mod_TQC_FACE_ROLL model)
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
        public Mod_TQC_FACE_ROLL GetModel(string C_ID)
        {

            return dal.GetModel(C_ID);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList_ID(string strWhere)
        {
            return dal.GetList_ID(strWhere);
        }
        /// <summary>
        /// 通过线材实绩表外键获得数据列表
        /// </summary>
        public DataSet GetList_C_ROLL_ID(string C_ROLL_ID)
        {
            return dal.GetList_C_ROLL_ID(C_ROLL_ID);
        }
        /// <summary>
        /// 获得数据列表-判定时间
        /// </summary>
        /// <param name="begin">开始时间</param>
        /// <param name="end">结束时间</param>
        /// <param name="strWhere">批号</param>
        /// <returns></returns>
        public DataSet GetList_DTE(DateTime begin, DateTime end, string strWhere)
        {
            return dal.GetList_DTE(begin, end, strWhere);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(DateTime begin, DateTime end, string strWhere)
        {
            return dal.GetList( begin, end, strWhere);
        }
         
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Mod_TQC_FACE_ROLL> DataTableToList(DataTable dt)
        {
            List<Mod_TQC_FACE_ROLL> modelList = new List<Mod_TQC_FACE_ROLL>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Mod_TQC_FACE_ROLL model;
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

