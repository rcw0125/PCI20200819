using System;
using System.Data;
using System.Collections.Generic;
using DAL;
using MODEL;
namespace BLL
{
    /// <summary>
    /// 执行标准信息主表
    /// </summary>
    public partial class Bll_TQB_STD_MAIN
    {
        private readonly Dal_TQB_STD_MAIN dal = new Dal_TQB_STD_MAIN();
        public Bll_TQB_STD_MAIN()
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
        public bool Add(Mod_TQB_STD_MAIN model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Mod_TQB_STD_MAIN model)
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
        public Mod_TQB_STD_MAIN GetModel(string C_ID)
        {

            return dal.GetModel(C_ID);
        }
        /// <summary>
        /// 获取标准列表
        /// </summary>              
        /// <param name="C_STL_GRD">钢种</param>
        /// <param name="C_IS_BXG">是否不锈钢</param>
        /// <returns></returns>
		public DataSet GetList_Type(string C_STL_GRD, string C_IS_BXG)
        {
            return dal.GetList_Type(C_STL_GRD, C_IS_BXG);
        }
        /// <summary>
        /// 获取标准列表
        /// </summary>
        /// <param name="C_IS_BXG">是否为不锈钢</param>
        /// <param name="C_STL_GRD">钢种</param>
        /// <returns></returns>
        public DataSet GetList_Std(string C_IS_BXG, string C_STL_GRD)
        {
            return dal.GetList_Std(C_IS_BXG, C_STL_GRD);
        }

        /// <summary>
        /// 获取标准列表
        /// </summary>      
        /// <param name="C_STD_CODE">标准代码</param>
        /// <param name="C_STL_GRD">钢种</param>
        /// <returns></returns>
        public DataSet GetList_ID(string C_STD_CODE, string C_STL_GRD)
        {
            return dal.GetList_ID(C_STD_CODE, C_STL_GRD);
        }

        public DataSet GetList_STD(string C_STL_GRD)
        {
            return dal.GetList_STD(C_STL_GRD);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        /// <param name="c_is_bxg">是否为不锈钢</param>
        /// <param name="is_check">是否审核</param>
        /// <param name="C_STD_TYPE">类型</param>
        /// <param name="C_STD_CODE">执行标准</param>
        /// <param name="C_STL_GRD">钢种</param>
        /// <returns></returns>
        public DataSet GetList(string c_is_bxg, int is_check, string C_STD_TYPE, string C_STD_CODE, string C_STL_GRD)
        {
            return dal.GetList(c_is_bxg, is_check, C_STD_TYPE, C_STD_CODE, C_STL_GRD);
        }
        /// <summary>
        /// 获得数据列表-
        /// </summary> 
        /// <param name="is_check">是否审核</param> 
        /// <param name="C_STD_CODE">执行标准</param>
        /// <param name="C_STL_GRD">钢种</param>
        /// <returns></returns>
        public DataSet GetList_GZ(int is_check, string C_STD_CODE, string C_STL_GRD)
        {
            return dal.GetList_GZ(is_check, C_STD_CODE, C_STL_GRD);
        }
        /// <summary>
        /// 获取标准列表
        /// </summary>
        /// <param name="C_STD_CODE">标准代码</param>
        /// <param name="C_STL_GRD">钢种</param>
        /// <returns></returns>
		public DataSet GetList(string C_STD_CODE, string C_STL_GRD)
        {
            return dal.GetList(C_STD_CODE, C_STL_GRD);
        }

        /// <summary>
        /// 获取标准列表
        /// </summary>
        /// <param name="C_STD_CODE">标准代码</param>
        /// <param name="C_STL_GRD">钢种</param>
        /// <param name="C_MAT_CODE">物料编码</param>
        /// <param name="C_MAT_NAME">物料名称</param>
        /// <returns></returns>
        public DataSet GetList(string C_STD_CODE, string C_STL_GRD, string C_MAT_CODE, string C_MAT_NAME)
        {
            return dal.GetList(C_STD_CODE, C_STL_GRD, C_MAT_CODE, C_MAT_NAME);
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Mod_TQB_STD_MAIN> DataTableToList(DataTable dt)
        {
            List<Mod_TQB_STD_MAIN> modelList = new List<Mod_TQB_STD_MAIN>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Mod_TQB_STD_MAIN model;
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
        /// <summary>
        /// 获取可代轧钢种标准列表
        /// </summary>
        /// <param name="C_STD_CODE">标准代码</param>
        /// <param name="C_STL_GRD">钢种</param>
        /// <returns></returns>
        public DataSet GetListByGZ(string C_STL_GRD, string C_STD_CODE)
        {
            return dal.GetListByGZ(C_STL_GRD, C_STD_CODE);
        }
        /// <summary>
        /// 获取标准列表
        /// </summary>
        /// <param name="C_PROD_NAME">钢类</param>
        /// <param name="C_STL_GRD">钢种</param>
        /// <returns></returns>
        public DataSet GetGLList(string C_STL_GRD, string C_PROD_NAME, string C_STD_CODE)
        {
            return dal.GetGLList(C_STL_GRD, C_PROD_NAME, C_STD_CODE);
        }
        /// <summary>
        /// 获得所有钢类
        /// </summary>
        public DataSet GetPMList(string C_PROD_NAME)
        {
            return dal.GetPMList(C_PROD_NAME);
        }
        /// <summary>
        /// 获得所有钢种
        /// </summary>
        public DataSet GetGZList(string grd)
        {
            return dal.GetGZList(grd);
        }

        /// <summary>
        /// 获取标准列表(可代轧钢种维护)
        /// </summary>
        /// <param name="C_STD_CODE">标准代码</param>
        /// <param name="C_STL_GRD">钢种</param>
        /// <param name="C_ID">主键</param>
        /// <returns></returns>
        public DataSet GetListKDZ(string C_STD_CODE, string C_STL_GRD, string C_ID)
        {
            return dal.GetListKDZ(C_STD_CODE, C_STL_GRD, C_ID);
        }
        /// <summary>
        /// 获得所有品种
        /// </summary>
        public DataSet GetPZList()
        {
            return dal.GetPZList();
        }
        /// <summary>
        /// 获得所有品种
        /// </summary>
        public DataSet GetPZList(string PZ)
        {
            return dal.GetPZList(PZ);
        }
        /// <summary>
        /// 根据品名获得执行标准
        /// </summary>
        public DataSet GetGZListByPM(string PM)
        {
            return dal.GetGZListByPM(PM);
        }
        /// <summary>
        /// 根据执行标准获得钢种
        /// </summary>
        public DataSet GetBZListByGZ(string BZ)
        {
            return dal.GetBZListByGZ(BZ);
        }

        /// <summary>
        /// 获取标准列表
        /// </summary>
        /// <param name="C_STD_CODE">标准代码</param>
        /// <param name="C_STL_GRD">钢种</param>
        /// <returns></returns>
        public DataSet GetList_TANK(string C_STD_CODE, string C_STL_GRD)
        {
            return dal.GetList_TANK(C_STD_CODE, C_STL_GRD);

        }
        /// <summary>
        /// 获取未维护工艺路线数据
        /// </summary>
        /// <returns></returns>
        public DataSet GetListByWWH()
        {
            return dal.GetListByWWH();
        }
        /// <summary>
        /// 获取未维护钢坯定尺数据
        /// </summary>
        /// <returns></returns>
        public DataSet GetListByWWHGPDC()
        {
            return dal.GetListByWWHGPDC();
        }
        /// <summary>
        /// 获取未维护铁水条件数据
        /// </summary>
        /// <returns></returns>
        public DataSet GetListByWWHTSTJ()
        {
            return dal.GetListByWWHTSTJ();
        }
        /// <summary>
        /// 获取未维护钢坯机时产能数据
        /// </summary>
        /// <returns></returns>
        public DataSet GetListByWWHGPCN()
        {
            return dal.GetListByWWHGPCN();
        }
        /// <summary>
        /// 获取未维护轧线产能数据
        /// </summary>
        /// <returns></returns>
        public DataSet GetListByWWHZXCN()
        {
            return dal.GetListByWWHZXCN();
        }

        /// <summary>
        /// 根据钢种、自由项获取标准
        /// </summary>
        /// <param name="C_STL_GRD">钢种</param>
        /// <param name="zyx1">自由项1</param>
        /// <param name="zyx2">自由项2</param>
        /// <returns></returns>
        public Mod_TQB_STD_MAIN GetModel(string C_STL_GRD, string zyx1, string zyx2)
        {
            return dal.GetModel(C_STL_GRD, zyx1, zyx2);
        }

        /// <summary>
        /// 根据钢种、标准获取自由项（连接NC数据库）
        /// </summary>
        /// <param name="GZ">钢种</param>
        /// <param name="BZ">标准</param>
        /// <returns></returns>
        public DataTable GetZYX(string GZ, string BZ)
        {
            return dal.GetZYX(GZ, BZ);
        }


        /// <summary>
        /// 生成质量设计号
        /// </summary>
        /// <param name="P_STD_ID">执行标准主键</param>
        /// <returns></returns>
        public string Creat_Design(string P_STD_ID)
        {
            return dal.Creat_Design(P_STD_ID);
        }
        /// <summary>
        /// 获取标准列表
        /// </summary>
        /// <param name="C_IS_BXG">是否为不锈钢</param>
        /// <param name="Type">标准类型</param>
        /// <param name="C_STD_CODE">执行标准</param>
        /// <param name="C_STL_GRD">钢种</param>
        /// <returns></returns>
        public DataSet GetList_GPDC(string C_IS_BXG, string Type, string C_STD_CODE, string C_STL_GRD)
        {
            return dal.GetList_GPDC(C_IS_BXG, Type, C_STD_CODE, C_STL_GRD);
        }
        /// <summary>
        /// 获取标准列表
        /// </summary>
        /// <param name="C_IS_BXG">是否为不锈钢</param> 
        /// <param name="C_STD_CODE">执行标准</param>
        /// <param name="C_STL_GRD">钢种</param>
        /// <returns></returns>
        public DataSet GetList_GYLX(string C_IS_BXG, string C_STD_CODE, string C_STL_GRD)
        {
            return dal.GetList_GYLX(C_IS_BXG, C_STD_CODE, C_STL_GRD);
        }
        /// <summary>
        /// 获取标准列表
        /// </summary>
        /// <param name="C_STD_CODE">标准代码</param>
        /// <param name="C_STL_GRD">钢种</param>
        /// <returns></returns>
        public DataSet Get_List(string C_STD_CODE, string C_STL_GRD)
        {
            return dal.Get_List(C_STD_CODE, C_STL_GRD);
        }
        /// <summary>
        /// 查询生产标准数据是否维护
        /// </summary>
        /// <param name="C_IS_BXG">0碳钢1不锈钢</param>
        /// <param name="C_ROUTE_DESC">工艺路线是否维护N</param>
        /// <param name="C_STL_GRD_TYPE">钢种生产条件是否维护N</param>
        ///  <param name="C_STL_GRD">钢种</param>
        ///  <param name="C_STD_CODE">执行标准</param>
        /// <returns>查询结果</returns>
        public DataTable GetSCTJ(string C_IS_BXG, string C_ROUTE_DESC, string C_STL_GRD_TYPE, string C_STL_GRD, string C_STD_CODE)
        {
            return dal.GetSCTJ(C_IS_BXG, C_ROUTE_DESC, C_STL_GRD_TYPE, C_STL_GRD, C_STD_CODE);
        }
        /// <summary>
        /// 获得数据列表-
        /// </summary>  
        /// <param name="C_STD_CODE">执行标准</param>
        /// <param name="C_STL_GRD">钢种</param>
        /// <returns></returns>
        public DataSet GetList_QueryStdMatrl(string C_STD_CODE, string C_STL_GRD)
        {
            return dal.GetList_QueryStdMatrl(C_STD_CODE, C_STL_GRD);
        }

        /// <summary>
        /// 查询生产标准数据是否维护
        /// </summary>
        ///  <param name="C_STL_GRD">钢种</param>
        ///  <param name="C_STD_CODE">执行标准</param>
        /// <returns>查询结果</returns>
        public DataTable GetSCTJ(string C_STL_GRD, string C_STD_CODE)
        {
            return dal.GetSCTJ(C_STL_GRD, C_STD_CODE);
        }
        /// <summary>
        /// 获得数据列表-
        /// </summary>   
        /// <param name="C_STL_GRD">钢种</param>
        /// <returns></returns>
        public DataSet GetList_GroupStlGrd(string C_STL_GRD, string C_STD_CODE)
        {
            return dal.GetList_GroupStlGrd(C_STL_GRD, C_STD_CODE);
        }


        #endregion  ExtensionMethod

        #region lj
        /// <summary>
        /// 获取品种品名
        /// </summary>
        /// <param name="C_STL_GRD">钢种</param>
        /// <param name="C_STD_CODE">执行标准</param>
        /// <returns></returns>
        public DataTable GetProdType(string C_STL_GRD, string C_STD_CODE)
        {
            return dal.GetProdType(C_STL_GRD, C_STD_CODE);
        }

        /// <summary>
        /// 获取质量设计号
        /// </summary>
        /// <param name="C_STL_GRD">钢种</param>
        /// <param name="C_STD_CODE">执行标准</param>
        /// <returns>质量设计号</returns>
        public string GetDESIGN_NO(string C_STL_GRD, string C_STD_CODE)
        {
            return dal.GetDESIGN_NO(C_STL_GRD, C_STD_CODE);
        }

        #endregion
    }
}

