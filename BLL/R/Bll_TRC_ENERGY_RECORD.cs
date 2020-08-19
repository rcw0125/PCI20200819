using System;
using System.Data;
using System.Collections.Generic;
using DAL;
using MODEL;
namespace BLL
{
	/// <summary>
	/// 能源消耗实绩记录
	/// </summary>
	public partial class Bll_TRC_ENERGY_RECORD
	{
		private readonly Dal_TRC_ENERGY_RECORD dal=new Dal_TRC_ENERGY_RECORD();
		public Bll_TRC_ENERGY_RECORD()
		{}
		#region  BasicMethod

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Mod_TRC_ENERGY_RECORD model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Mod_TRC_ENERGY_RECORD model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(String ID)
		{
			//该表无主键信息，请自定义主键/条件字段
			return dal.Delete(ID);
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Mod_TRC_ENERGY_RECORD GetModel(String ID)
		{
			//该表无主键信息，请自定义主键/条件字段
			return dal.GetModel(ID);
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
		public List<Mod_TRC_ENERGY_RECORD> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Mod_TRC_ENERGY_RECORD> DataTableToList(DataTable dt)
		{
			List<Mod_TRC_ENERGY_RECORD> modelList = new List<Mod_TRC_ENERGY_RECORD>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Mod_TRC_ENERGY_RECORD model;
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
        /// 查询能源消耗实绩记录
        /// </summary>
        /// <param name="dtFrom">开始日期</param>
        /// <param name="dtTo">结束日期</param>
        /// <param name="strpro">工序</param>
        /// <param name="strsta">工位</param>
        /// <param name="strKind">能源种类</param>
        public DataSet BindRecode(DateTime? dtFrom, DateTime? dtTo, string strpro, string strsta, string strKind)
        {
            return dal.BindRecode(dtFrom, dtTo, strpro, strsta, strKind);

        }
            #endregion  ExtensionMethod
        }
}

