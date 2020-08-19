using System;
using System.Data;
using System.Collections.Generic;
using DAL;
using MODEL;
namespace BLL
{
	/// <summary>
	/// 生产工位机时产能
	/// </summary>
	public partial class Bll_TPB_GL_CAPACITY
    {
		private readonly Dal_TPB_GL_CAPACITY dal=new Dal_TPB_GL_CAPACITY();
		public Bll_TPB_GL_CAPACITY()
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
		public bool Add(Mod_TPB_GL_CAPACITY model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Mod_TPB_GL_CAPACITY model)
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
		public Mod_TPB_GL_CAPACITY GetModel(string C_ID)
		{
			
			return dal.GetModel(C_ID);
		}

		

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string C_PRO_ID, string C_STA_CODE, int N_STATUS)
		{
			return dal.GetList(C_PRO_ID, C_STA_CODE, N_STATUS);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Mod_TPB_GL_CAPACITY> GetModelList(string C_PRO_ID, string C_STA_ID, int N_STATUS)
		{
			DataSet ds = dal.GetList(C_PRO_ID,C_STA_ID, N_STATUS);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Mod_TPB_GL_CAPACITY> DataTableToList(DataTable dt)
		{
			List<Mod_TPB_GL_CAPACITY> modelList = new List<Mod_TPB_GL_CAPACITY>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Mod_TPB_GL_CAPACITY model;
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




        #endregion  BasicMethod
        #region  ExtensionMethod
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string C_STA_ID, int N_STATUS)
        {
            return dal.GetList(C_STA_ID, N_STATUS);
        }
            #endregion  ExtensionMethod
        }
}

