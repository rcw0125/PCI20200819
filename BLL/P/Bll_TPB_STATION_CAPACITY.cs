using System;
using System.Data;
using System.Collections.Generic;
using DAL;
using MODEL;
namespace BLL
{
	/// <summary>
	/// 工位（LF/RH/转
	/// </summary>
	public partial class Bll_TPB_STATION_CAPACITY
    {
		private readonly Dal_TPB_STATION_CAPACITY dal=new Dal_TPB_STATION_CAPACITY();
		public Bll_TPB_STATION_CAPACITY()
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
		public bool Add(Mod_TPB_STATION_CAPACITY model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Mod_TPB_STATION_CAPACITY model)
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
		public Mod_TPB_STATION_CAPACITY GetModel(string C_ID)
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
        public List<Mod_TPB_STATION_CAPACITY> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Mod_TPB_STATION_CAPACITY> DataTableToList(DataTable dt)
		{
			List<Mod_TPB_STATION_CAPACITY> modelList = new List<Mod_TPB_STATION_CAPACITY>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Mod_TPB_STATION_CAPACITY model;
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
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(int status ,string gx,string gw, string gz,string spec,string zxbz)
        {
            return dal.GetList(status, gx, gw,gz, spec, zxbz);
        }

        /// <summary>
        /// 是否存在相同数据
        /// </summary>
        public bool ExistsDate(string C_STA_ID, string C_STL_GRD, string C_SPEC)
        {
            return dal.ExistsDate(C_STA_ID, C_STL_GRD, C_SPEC);
        }
        /// <summary>
        /// 是否存在相同数据
        /// </summary>
        public bool Exists(string C_STA_ID, string C_SPEC)
        {
            return dal.Exists(C_STA_ID, C_SPEC);
        }
            #endregion  ExtensionMethod
        }
}

