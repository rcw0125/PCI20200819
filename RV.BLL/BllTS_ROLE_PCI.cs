using System;
using System.Data;
using System.Collections.Generic;
using RV.MODEL;
using RV.DAL;

namespace RV.BLL
{
	/// <summary>
	/// 角色信息
	/// </summary>
	public partial class BllTS_ROLE_PCI
	{
		private readonly DalTS_ROLE_PCI dal=new DalTS_ROLE_PCI();
		public BllTS_ROLE_PCI()
		{}
		#region  BasicMethod
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string C_ROLE_NAME)
		{
			return dal.Exists(C_ROLE_NAME);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(ModTS_ROLE_PCI model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(ModTS_ROLE_PCI model)
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
		public ModTS_ROLE_PCI GetModel(string C_ID)
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
        /// 获得角色列表
        /// </summary>
        public DataSet GetRoleList()
        {
            return dal.GetRoleList();
        }

        /// <summary>
        /// 获得角色列表
        /// </summary>
        public DataSet GetUserRoleList(string strUserID)
        {
            return dal.GetUserRoleList(strUserID);
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<ModTS_ROLE_PCI> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<ModTS_ROLE_PCI> DataTableToList(DataTable dt)
		{
			List<ModTS_ROLE_PCI> modelList = new List<ModTS_ROLE_PCI>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				ModTS_ROLE_PCI model;
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

