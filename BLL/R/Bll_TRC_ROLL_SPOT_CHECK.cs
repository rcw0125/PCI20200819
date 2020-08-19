using System;
using System.Data;
using System.Collections.Generic;
using DAL;
using MODEL;
namespace BLL
{
	/// <summary>
	/// 抽查线材实绩信息
	/// </summary>
	public partial class Bll_TRC_ROLL_SPOT_CHECK
	{
		private readonly Dal_TRC_ROLL_SPOT_CHECK dal=new Dal_TRC_ROLL_SPOT_CHECK();
		public Bll_TRC_ROLL_SPOT_CHECK()
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
		public bool Add(Mod_TRC_ROLL_SPOT_CHECK model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Mod_TRC_ROLL_SPOT_CHECK model)
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
		public Mod_TRC_ROLL_SPOT_CHECK GetModel(string C_ID)
		{
			
			return dal.GetModel(C_ID);
		}
       
        /// <summary>
        /// 条件获得数据列表
        /// </summary>
        /// <param name="begin">生产时间 开始</param>
        /// <param name="end">生产时间 结束</param>         
        /// <param name="batch">批号</param>
        /// <returns></returns>
        public DataSet GetList_Query(DateTime begin, DateTime end, string batch)
        {
            return dal.GetList_Query(begin, end, batch);
        }
        /// <summary>
        /// 获得数据列表-主键
        /// </summary>
        public DataSet GetList_ID(string strWhere)
        {
            return dal.GetList_ID(strWhere);
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
		public List<Mod_TRC_ROLL_SPOT_CHECK> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Mod_TRC_ROLL_SPOT_CHECK> DataTableToList(DataTable dt)
		{
			List<Mod_TRC_ROLL_SPOT_CHECK> modelList = new List<Mod_TRC_ROLL_SPOT_CHECK>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Mod_TRC_ROLL_SPOT_CHECK model;
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

		#endregion  ExtensionMethod
	}
}

