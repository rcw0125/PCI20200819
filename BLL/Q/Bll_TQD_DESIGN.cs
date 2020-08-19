using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DAL;

namespace BLL
{
    public class Bll_TQD_DESIGN
    {
        private readonly Dal_TQD_DESIGN dal = new Dal_TQD_DESIGN();

        public Bll_TQD_DESIGN()
        { }

        /// <summary>
        /// 查询线材质量设计结果
        /// </summary>
        /// <param name="strBatch">批号</param>
        /// <param name="strOrderID">订单号</param>
        /// <returns></returns>
		public DataSet GetDesignRoll(string strBatch, string strOrderID)
        {
            return dal.GetDesignRoll(strBatch, strOrderID);
        }

        /// <summary>
        /// 查询钢坯质量设计结果
        /// </summary>
        /// <param name="strStove">炉号</param>
        /// <param name="strOrderID">订单号</param>
        /// <returns></returns>
		public DataSet GetDesignSlab(string strStove, string strOrderID)
        {
            return dal.GetDesignSlab(strStove, strOrderID);
        }

        /// <summary>
        /// 查询质量设计结果明细
        /// </summary>
        /// <param name="strDesignNo">质量设计号</param>
        /// <param name="strStdCode">执行标准</param>
        /// <param name="strGrd">钢种</param>
        /// <param name="strType">类型,0-钢坯；1-线材</param>
        /// <returns></returns>
		public DataSet GetDesignItemRoll(string strDesignNo, string strStdCode, string strGrd, string strType)
        {
            return dal.GetDesignItemRoll(strDesignNo, strStdCode, strGrd, strType);
        }

        /// <summary>
        /// 获取质量设计号
        /// </summary>
        /// <param name="C_STD_CODE">执行标准</param>
        /// <param name="C_STL_GRD">钢种</param>
        /// <returns></returns>
        public string Get_Design_No(string C_STD_CODE, string C_STL_GRD)
        {
            return dal.Get_Design_No(C_STD_CODE, C_STL_GRD);
        }
    }
}
