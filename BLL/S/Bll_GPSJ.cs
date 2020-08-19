using System;
using System.Data;
using System.Collections.Generic;
using DAL;
using MODEL;
namespace BLL
{
    public class Bll_GPSJ
    {

        Dal_GPSJ dal = new Dal_GPSJ();

        /// <summary>
        /// 获得数据列表- 实绩信息
        /// </summary>
        /// <param name="begin">开始时间</param>
        /// <param name="end">结束时间</param>
        /// <param name="C_STOVE">炉号</param> 
        /// <param name="stl">钢种</param>
        /// <param name="std">执行标准</param>
        /// <param name="slabwhCode">仓库编码</param>
        /// <param name="code">仓库编码</param>
        /// <param name="matType">表判</param>
        /// <returns></returns>
        public DataSet GetList_SJ_Group(string C_STOVE, string stl, string std, string slabwhCode, string code, string matType, string strZT)
        {
            return dal.GetList_SJ_Group(C_STOVE, stl, std, slabwhCode, code, matType, strZT);
        }

        /// <summary>
        /// 炉号，物料编码，仓库编码，备注
        /// </summary>
        /// <param name="stove"></param>
        /// <param name="matCode"></param>
        /// <param name="slabwhCode"></param>
        /// <param name="remark"></param>
        /// <returns></returns>
        public string UpdateSlabRemark(string stove, string matCode, string slabwhCode, string remark, string batchNo)
        {
            string result = "1";
            if (!dal.UpdateSlabRemark(stove, matCode, slabwhCode, remark, batchNo))
                result = "0";
            return result;
        }


        /// <summary>
        /// 标记钢坯异常原因
        /// </summary>
        /// <param name="stove">炉号</param>
        /// <param name="matCode">物料编码</param>
        /// <param name="slabwhCode">仓库编码</param>
        /// <param name="remark">异常原因</param>
        /// <returns>标记是否成功</returns>
        public string UpdateSlabYC(string stove, string matCode, string slabwhCode, string remark, string batchNo)
        {
            string result = "1";
            if (!dal.UpdateSlabYC(stove, matCode, slabwhCode, remark, batchNo))
                result = "0";
            return result;
        }


        /// <summary>
        /// 标记钢坯异常原因
        /// </summary>
        /// <param name="stove">炉号</param>
        /// <param name="matCode">物料编码</param>
        /// <param name="slabwhCode">仓库编码</param>
        /// <param name="remark">异常原因</param>
        /// <returns>标记是否成功</returns>
        public string UpdateSlabCancleYC(string stove, string matCode, string slabwhCode, string batchNo)
        {
            string result = "1";
            if (!dal.UpdateSlabCancleYC(stove, matCode, slabwhCode, batchNo))
                result = "0";
            return result;
        }

        /// <summary>
        /// 获取钢坯信息
        /// </summary>
        /// <returns></returns>
        public DataTable GetSlabInfo(string stove)
        {
            return dal.GetSlabInfo(stove);
        }

    }
}
