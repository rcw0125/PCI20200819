using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XGCAP.UI.P.PP
{
  public   class Cls_ChangeSteel
    {
        /// <summary>
        /// MES计划改钢种
        /// </summary>
        /// <param name="heatid">炉号</param>
        /// <param name="planOrdid">订单号</param>
        /// <param name="steelgradeindex">炼钢计号</param>
        /// <param name="steelgrade">钢种</param>
        /// <param name="length">定尺</param>
        private void changeSteel(string heatid, string planOrdid, string steelgradeindex, string steelgrade, string length)
        {
            //cplan_order   MATERIALCODE_ID
            //Cplan_tapping thickness,width,length

            // 先查询是否已经甩废，如果大于0，则不允许改钢
            string sqlbloom = "select Count(1) cou from CBloom_Data where HeatID='" + heatid + "'";
            //没有甩废时，执行下面操作
            //使用下面的语句查询出来的就是preheatid
            string sqlpreheatid = "select preheatid from CPlan_Tapping where HeatID='" + heatid + "'";
            string preheatid = "";
            string sql = "Update CPlan_Casting set Plan_Ord_ID ='" + planOrdid + "', Pre_SteelGradeIndex='" + steelgradeindex + "', Pre_SteelGrade='" + steelgrade + "', Length='" + length + "'  where PreHeatID='" + preheatid + "'";
            string sql1 = "Update CPlan_Tapping set Plan_Ord_ID ='" + planOrdid + "', Pre_SteelGradeIndex='" + steelgradeindex + "', Pre_SteelGrade='" + steelgrade + "' , SteelGradeIndex ='" + steelgradeindex + "' , Length='" + length + "' where  HeatID='" + heatid + "'";
            string sql2 = "Update CCCM_Base_Data set SteelGrade ='" + steelgrade + "', Pre_SteelGradeIndex='" + steelgradeindex + "',SteelGradeIndex ='" + steelgradeindex + "',plan_SteelGrade ='" + steelgrade + "' , Length='" + length + "' where HeatID='" + heatid + "'";
            string sql9 = "Update CBOF_BASE_DATA set SteelGradeIndex ='" + steelgradeindex + "' ,SteelGrade ='" + steelgrade + "' where HeatID='" + heatid + "'";
            string sql10 = "Update CLF_BASE_DATA set SteelGradeIndex ='" + steelgradeindex + "' ,SteelGrade ='" + steelgrade + "' where HeatID='" + heatid + "'";
            string sql11 = "Update CRH_BASE_DATA set SteelGradeIndex ='" + steelgradeindex + "' ,SteelGrade ='" + steelgrade + "' where HeatID='" + heatid + "'";

        }
    }
}
