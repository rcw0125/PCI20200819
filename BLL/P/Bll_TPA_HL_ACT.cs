using System;
using System.Data;
using System.Collections.Generic;
using DAL;
using MODEL;
namespace BLL
{
    /// <summary>
    /// 钢坯缓冷实绩表
    /// </summary>
    public partial class Bll_TPA_HL_ACT
	{
		private readonly Dal_TPA_HL_ACT dal=new Dal_TPA_HL_ACT();
		public Bll_TPA_HL_ACT()
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
		public bool Add(Mod_TPA_HL_ACT model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Mod_TPA_HL_ACT model)
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
		public Mod_TPA_HL_ACT GetModel(string C_ID)
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
		public List<Mod_TPA_HL_ACT> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}

        /// <summary>
        /// 初始化缓冷实际
        /// </summary>
        /// <returns>执行结果1成功0失败</returns>
        public string RstHLACT()
        {
            return dal.RstHLACT();
        }

        /// <summary>
        /// 初始化工序计划表
        /// </summary>
        /// <returns>执行结果1成功0失败</returns>
        public string CleanGXPlan()
        {
            return dal.CleanGXPlan();
        }
            /// <summary>
            /// 获得数据列表
            /// </summary>
            public List<Mod_TPA_HL_ACT> DataTableToList(DataTable dt)
		{
			List<Mod_TPA_HL_ACT> modelList = new List<Mod_TPA_HL_ACT>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Mod_TPA_HL_ACT model;
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

