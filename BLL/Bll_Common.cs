using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using DAL;
using System.Data;
using System.Collections;
using MODEL;

namespace BLL
{
    public class Bll_Common
    {
        private readonly Dal_Common dal = new Dal_Common();

        public Bll_Common()
        { }


        /// <summary>
        /// 根据钢种、执行标准获取NC自由项1和自由项2信息
        /// </summary>
        /// <param name="C_STL_GRD">钢种</param>
        /// <param name="C_STD_CODE">执行标准</param>
        /// <returns>自由项信息</returns>
        public DataTable GetZYX(string C_STL_GRD, string C_STD_CODE)
        {
            return dal.GetZYX(C_STL_GRD, C_STD_CODE);
        }

        /// <summary>
        /// 停用
        /// </summary>
        /// <param name="str_TableName">表名</param>
        /// <param name="C_ID">主键</param>
        /// <param name="C_EMP_ID">维护人</param>
        /// <param name="dtime">维护时间</param>
        /// <returns></returns>
        public bool DataDisabled(string str_TableName, string C_ID, string C_EMP_ID, DateTime dtime)
        {
            return dal.DataDisabled(str_TableName, C_ID, C_EMP_ID, dtime);
        }

        /// <summary>
        /// 查询是否有重复
        /// </summary>
        /// <param name="str">语句</param>
        /// <returns></returns>
        public int CheckTable(string str)
        {
            return dal.CheckTable(str);
        }

        /// <summary>
        /// 获取条码库存信息
        /// </summary>
        public DataSet Get_TM_KCList()
        {
            return dal.Get_TM_KCList();
        }

        /// <summary>
        /// 获取条码库存信息
        /// </summary>
        public DataSet Get_NC_KCList()
        {
            return dal.Get_NC_KCList();
        }

        /// <summary>
        /// 获取条码库存信息
        /// </summary>
        public DataSet Get_PCI_KCList()
        {
            return dal.Get_PCI_KCList();
        }

        /// <summary>
        /// 获取NC钢坯库存信息
        /// </summary>
        public DataSet Get_NC_Slab_KCList()
        {
            return dal.Get_NC_Slab_KCList();
        }

        /// <summary>
        /// 获取CAP钢坯库存信息
        /// </summary>
        public DataSet Get_PCI_Slab_KCList()
        {
            return dal.Get_PCI_Slab_KCList();
        }

        /// <summary>
        /// 更新一条数据_炉号
        /// </summary>
        public bool Update_Stove(string stove, string stlgrd, string matcode, string zyx1, string zyx2, string ckcode)
        {
            return dal.Update_Stove(stove, stlgrd, matcode, zyx1, zyx2, ckcode);
        }


        #region 下发轧钢计划

        /// <summary>
        /// 下发轧钢计划
        /// </summary>
        /// <returns></returns>
        public string UpdateWgt(DataRow[] rows)
        {
            try
            {
                string result = "1";

                TransactionHelper.BeginTransaction();

                Dal_TSC_SLAB_MAIN dalMain = new Dal_TSC_SLAB_MAIN();

                int a = 0;

                foreach (var item in rows)
                {
                    a++;

                    decimal cou = Convert.ToDecimal(item["NC账存支数"].ToString());
                    decimal wgt = Convert.ToDecimal(item["NC与CAP重量账差"].ToString());

                    if (cou == 0 || wgt == 0)
                        continue;

                    decimal wgt_ave = Math.Round(wgt / cou, 3);
                    decimal wgt_sy = 0;
                    if (cou > 1)
                    {
                        wgt_sy = wgt - wgt_ave * (cou - 1);
                    }

                    DataTable dt = dalMain.Get_List(item["炉号"].ToString(), item["钢种"].ToString(), item["开坯号"].ToString(), item["物料号"].ToString(), item["自由项1"].ToString(), item["自由项2"].ToString(), item["质量等级"].ToString(), item["仓库"].ToString()).Tables[0];

                    if (dt.Rows.Count == cou)
                    {
                        for (int kk = 0; kk < dt.Rows.Count; kk++)
                        {
                            Mod_TSC_SLAB_MAIN model = dalMain.GetModel_Trans(dt.Rows[kk]["C_ID"].ToString());

                            if (kk == dt.Rows.Count - 1)
                            {
                                if (cou == 1)
                                {
                                    model.N_WGT = model.N_WGT + wgt_ave;
                                }
                                else
                                {
                                    model.N_WGT = model.N_WGT + wgt_sy;
                                }
                            }
                            else
                            {
                                model.N_WGT = model.N_WGT + wgt_ave;
                            }

                            if (!dalMain.Update_Trans(model))
                            {
                                TransactionHelper.RollBack();
                                return "重量更新失败！";
                            }
                        }
                    }
                    else
                    {
                        continue;
                    }

                }

                TransactionHelper.Commit();
                return result;
            }
            catch (Exception ex)
            {
                TransactionHelper.RollBack();
                return ex.Message;
            }
        }

        #endregion


        /// <summary>
        /// 返回数据库表清单及数据表字段说明
        /// </summary>
        /// <returns></returns>
        public DataTable bind()
        {
            return dal.bind();
        }
    }
}
