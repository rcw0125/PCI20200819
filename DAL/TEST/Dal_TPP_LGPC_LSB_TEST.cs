using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;
namespace DAL
{
	/// <summary>
	/// 数据访问类:TPP_LGPC_LSB_TEST
	/// </summary>
	public partial class Dal_TPP_LGPC_LSB_TEST
    {
		public Dal_TPP_LGPC_LSB_TEST()
		{}

        /// <summary>
        /// 获取浇次列表
        /// </summary>
        /// <returns></returns>
        public DataSet Get_JC_List_Trans()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from TPP_LGPC_LSB_TEST t where t.c_ccm_code<>'5#CC' ");

            return TransactionHelper.Query(strSql.ToString());
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Mod_TPP_LGPC_LSB_TEST DataRowToModel(DataRow row)
        {
            Mod_TPP_LGPC_LSB_TEST model = new Mod_TPP_LGPC_LSB_TEST();
            if (row != null)
            {
                if (row["C_ID"] != null)
                {
                    model.C_ID = row["C_ID"].ToString();
                }
                if (row["C_CCM_ID"] != null)
                {
                    model.C_CCM_ID = row["C_CCM_ID"].ToString();
                }
                if (row["C_CCM_CODE"] != null)
                {
                    model.C_CCM_CODE = row["C_CCM_CODE"].ToString();
                }
                if (row["N_GROUP"] != null && row["N_GROUP"].ToString() != "")
                {
                    model.N_GROUP = decimal.Parse(row["N_GROUP"].ToString());
                }
                if (row["N_TOTAL_WGT"] != null && row["N_TOTAL_WGT"].ToString() != "")
                {
                    model.N_TOTAL_WGT = decimal.Parse(row["N_TOTAL_WGT"].ToString());
                }
                if (row["N_ZJCLS"] != null && row["N_ZJCLS"].ToString() != "")
                {
                    model.N_ZJCLS = decimal.Parse(row["N_ZJCLS"].ToString());
                }
                if (row["N_ZJCLZL"] != null && row["N_ZJCLZL"].ToString() != "")
                {
                    model.N_ZJCLZL = decimal.Parse(row["N_ZJCLZL"].ToString());
                }
                if (row["N_MLZL"] != null && row["N_MLZL"].ToString() != "")
                {
                    model.N_MLZL = decimal.Parse(row["N_MLZL"].ToString());
                }
                if (row["N_SORT"] != null && row["N_SORT"].ToString() != "")
                {
                    model.N_SORT = decimal.Parse(row["N_SORT"].ToString());
                }
                if (row["C_STL_GRD"] != null)
                {
                    model.C_STL_GRD = row["C_STL_GRD"].ToString();
                }
                if (row["N_PRODUCE_TIME"] != null && row["N_PRODUCE_TIME"].ToString() != "")
                {
                    model.N_PRODUCE_TIME = decimal.Parse(row["N_PRODUCE_TIME"].ToString());
                }
                if (row["N_JSCN"] != null && row["N_JSCN"].ToString() != "")
                {
                    model.N_JSCN = decimal.Parse(row["N_JSCN"].ToString());
                }
                if (row["C_BY1"] != null)
                {
                    model.C_BY1 = row["C_BY1"].ToString();
                }
                if (row["C_BY2"] != null)
                {
                    model.C_BY2 = row["C_BY2"].ToString();
                }
                if (row["C_BY3"] != null)
                {
                    model.C_BY3 = row["C_BY3"].ToString();
                }
                if (row["C_RH"] != null)
                {
                    model.C_RH = row["C_RH"].ToString();
                }
                if (row["C_DFP_HL"] != null)
                {
                    model.C_DFP_HL = row["C_DFP_HL"].ToString();
                }
                if (row["C_HL"] != null)
                {
                    model.C_HL = row["C_HL"].ToString();
                }
                if (row["C_XM"] != null)
                {
                    model.C_XM = row["C_XM"].ToString();
                }
                if (row["N_ORDER_LS"] != null && row["N_ORDER_LS"].ToString() != "")
                {
                    model.N_ORDER_LS = decimal.Parse(row["N_ORDER_LS"].ToString());
                }
                if (row["D_DFPHL_START_TIME"] != null && row["D_DFPHL_START_TIME"].ToString() != "")
                {
                    model.D_DFPHL_START_TIME = DateTime.Parse(row["D_DFPHL_START_TIME"].ToString());
                }
                if (row["D_DFPHL_END_TIME"] != null && row["D_DFPHL_END_TIME"].ToString() != "")
                {
                    model.D_DFPHL_END_TIME = DateTime.Parse(row["D_DFPHL_END_TIME"].ToString());
                }
                if (row["D_KP_START_TIME"] != null && row["D_KP_START_TIME"].ToString() != "")
                {
                    model.D_KP_START_TIME = DateTime.Parse(row["D_KP_START_TIME"].ToString());
                }
                if (row["D_KP_END_TIME"] != null && row["D_KP_END_TIME"].ToString() != "")
                {
                    model.D_KP_END_TIME = DateTime.Parse(row["D_KP_END_TIME"].ToString());
                }
                if (row["D_HL_START_TIME"] != null && row["D_HL_START_TIME"].ToString() != "")
                {
                    model.D_HL_START_TIME = DateTime.Parse(row["D_HL_START_TIME"].ToString());
                }
                if (row["D_HL_END_TIME"] != null && row["D_HL_END_TIME"].ToString() != "")
                {
                    model.D_HL_END_TIME = DateTime.Parse(row["D_HL_END_TIME"].ToString());
                }
                if (row["D_PLAN_KY_TIME"] != null && row["D_PLAN_KY_TIME"].ToString() != "")
                {
                    model.D_PLAN_KY_TIME = DateTime.Parse(row["D_PLAN_KY_TIME"].ToString());
                }
                if (row["C_PLAN_ROLL"] != null)
                {
                    model.C_PLAN_ROLL = row["C_PLAN_ROLL"].ToString();
                }
                if (row["D_ZZ_START_TIME"] != null && row["D_ZZ_START_TIME"].ToString() != "")
                {
                    model.D_ZZ_START_TIME = DateTime.Parse(row["D_ZZ_START_TIME"].ToString());
                }
                if (row["D_ZZ_END_TIME"] != null && row["D_ZZ_END_TIME"].ToString() != "")
                {
                    model.D_ZZ_END_TIME = DateTime.Parse(row["D_ZZ_END_TIME"].ToString());
                }
                if (row["D_XM_START_TIME"] != null && row["D_XM_START_TIME"].ToString() != "")
                {
                    model.D_XM_START_TIME = DateTime.Parse(row["D_XM_START_TIME"].ToString());
                }
                if (row["D_XM_END_TIME"] != null && row["D_XM_END_TIME"].ToString() != "")
                {
                    model.D_XM_END_TIME = DateTime.Parse(row["D_XM_END_TIME"].ToString());
                }
                if (row["C_STD_CODE"] != null)
                {
                    model.C_STD_CODE = row["C_STD_CODE"].ToString();
                }
                if (row["C_SLAB_TYPE"] != null)
                {
                    model.C_SLAB_TYPE = row["C_SLAB_TYPE"].ToString();
                }
                if (row["C_STL_GRD_TYPE"] != null)
                {
                    model.C_STL_GRD_TYPE = row["C_STL_GRD_TYPE"].ToString();
                }
                if (row["C_PROD_NAME"] != null)
                {
                    model.C_PROD_NAME = row["C_PROD_NAME"].ToString();
                }
                if (row["C_PROD_KIND"] != null)
                {
                    model.C_PROD_KIND = row["C_PROD_KIND"].ToString();
                }
                if (row["N_DFP_HL_TIME"] != null && row["N_DFP_HL_TIME"].ToString() != "")
                {
                    model.N_DFP_HL_TIME = decimal.Parse(row["N_DFP_HL_TIME"].ToString());
                }
                if (row["N_HL_TIME"] != null && row["N_HL_TIME"].ToString() != "")
                {
                    model.N_HL_TIME = decimal.Parse(row["N_HL_TIME"].ToString());
                }
                if (row["N_XM_TIME"] != null && row["N_XM_TIME"].ToString() != "")
                {
                    model.N_XM_TIME = decimal.Parse(row["N_XM_TIME"].ToString());
                }
                if (row["N_GG"] != null && row["N_GG"].ToString() != "")
                {
                    model.N_GG = decimal.Parse(row["N_GG"].ToString());
                }
                if (row["N_CCM_TIME"] != null && row["N_CCM_TIME"].ToString() != "")
                {
                    model.N_CCM_TIME = decimal.Parse(row["N_CCM_TIME"].ToString());
                }
                if (row["C_TJ_REMARK"] != null)
                {
                    model.C_TJ_REMARK = row["C_TJ_REMARK"].ToString();
                }
                if (row["C_TL"] != null)
                {
                    model.C_TL = row["C_TL"].ToString();
                }
                if (row["N_RH"] != null && row["N_RH"].ToString() != "")
                {
                    model.N_RH = decimal.Parse(row["N_RH"].ToString());
                }
                if (row["N_TL"] != null && row["N_TL"].ToString() != "")
                {
                    model.N_TL = decimal.Parse(row["N_TL"].ToString());
                }
                if (row["N_GZSL"] != null && row["N_GZSL"].ToString() != "")
                {
                    model.N_GZSL = decimal.Parse(row["N_GZSL"].ToString());
                }
                if (row["C_REMARK"] != null)
                {
                    model.C_REMARK = row["C_REMARK"].ToString();
                }
                if (row["N_XM"] != null && row["N_XM"].ToString() != "")
                {
                    model.N_XM = decimal.Parse(row["N_XM"].ToString());
                }
                if (row["N_DHL"] != null && row["N_DHL"].ToString() != "")
                {
                    model.N_DHL = decimal.Parse(row["N_DHL"].ToString());
                }
                if (row["N_HL"] != null && row["N_HL"].ToString() != "")
                {
                    model.N_HL = decimal.Parse(row["N_HL"].ToString());
                }
                if (row["N_STATUS"] != null && row["N_STATUS"].ToString() != "")
                {
                    model.N_STATUS = decimal.Parse(row["N_STATUS"].ToString());
                }
                if (row["D_P_START_TIME"] != null && row["D_P_START_TIME"].ToString() != "")
                {
                    model.D_P_START_TIME = DateTime.Parse(row["D_P_START_TIME"].ToString());
                }
                if (row["D_P_END_TIME"] != null && row["D_P_END_TIME"].ToString() != "")
                {
                    model.D_P_END_TIME = DateTime.Parse(row["D_P_END_TIME"].ToString());
                }
                if (row["N_DFP_RZ"] != null && row["N_DFP_RZ"].ToString() != "")
                {
                    model.N_DFP_RZ = decimal.Parse(row["N_DFP_RZ"].ToString());
                }
                if (row["N_RZP_RZ"] != null && row["N_RZP_RZ"].ToString() != "")
                {
                    model.N_RZP_RZ = decimal.Parse(row["N_RZP_RZ"].ToString());
                }
                if (row["C_RH_SFJS"] != null)
                {
                    model.C_RH_SFJS = row["C_RH_SFJS"].ToString();
                }

            }
            return model;
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Delete_Trans()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from TPP_LGPC_LSB_TEST t where t.c_id not in(select ta.c_fk from Tpp_Lgpc_Lclsb_Test ta where ta.c_fk is not null) and t.c_ccm_code<>'5#CC' ");

            int rows = TransactionHelper.ExecuteSql(strSql.ToString());
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

