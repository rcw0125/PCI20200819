using System;
using System.Data;
using System.Collections.Generic;
using DAL;
using MODEL;
namespace BLL
{
	/// <summary>
	/// 订单评价日志
	/// </summary>
	public partial class Bll_TMO_ORDER_PJ_LOG
	{
		private readonly Dal_TMO_ORDER_PJ_LOG dal=new Dal_TMO_ORDER_PJ_LOG();
		public Bll_TMO_ORDER_PJ_LOG()
		{}
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
		public bool Add(Mod_TMO_ORDER_PJ_LOG model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Mod_TMO_ORDER_PJ_LOG model)
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
		public bool DeleteList(string C_IDlist )
		{
			return dal.DeleteList(C_IDlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Mod_TMO_ORDER_PJ_LOG GetModel(string C_ID)
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
		public List<Mod_TMO_ORDER_PJ_LOG> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Mod_TMO_ORDER_PJ_LOG> DataTableToList(DataTable dt)
		{
			List<Mod_TMO_ORDER_PJ_LOG> modelList = new List<Mod_TMO_ORDER_PJ_LOG>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Mod_TMO_ORDER_PJ_LOG model;
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
			return dal.GetListByPage( strWhere,  orderby,  startIndex,  endIndex);
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
        /// <summary>
        /// 删除订单评价失败信息表
        /// </summary>
        /// <returns></returns>
        public bool DeleteLog()
        {
        
            return dal.DeleteLog();
        }

        /// <summary>
        /// 获取未维护基础数据类型
        /// </summary>
        /// <returns>基础数据类型</returns>
        public DataSet GetLX()
        {
            return dal.GetLX();
        }
        /// <summary>
        /// 按组统计未维护数据
        /// </summary>
        /// <param name="type">分类</param>
        /// <returns></returns>
        public DataSet GetWPJ(string type)
        {
            return dal.GetWPJ(type);
        }

            #endregion  ExtensionMethod
        }
}

