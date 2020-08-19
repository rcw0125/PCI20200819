using System;
using System.Data;
using System.Collections.Generic;
using DAL;
using MODEL;
namespace BLL
{
	/// <summary>
	/// 缓冷要求
	/// </summary>
	public partial class Bll_TQB_COOL
	{
		private readonly Dal_TQB_COOL dal=new Dal_TQB_COOL();
		public Bll_TQB_COOL()
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
		public bool Add(Mod_TQB_COOL model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Mod_TQB_COOL model)
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
		public Mod_TQB_COOL GetModel(string C_ID)
		{
			
			return dal.GetModel(C_ID);
		}



        /// <summary>
        /// 获得数据列表
        /// </summary>
        /// <param name="C_IS_BXG"></param>
        /// <param name="strWhere"></param>
        /// <returns></returns>
        public DataSet GetList(string C_IS_BXG, string stl_grd)
        {
            return dal.GetList(C_IS_BXG,stl_grd);
		}
		 
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Mod_TQB_COOL> DataTableToList(DataTable dt)
		{
			List<Mod_TQB_COOL> modelList = new List<Mod_TQB_COOL>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Mod_TQB_COOL model;
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

