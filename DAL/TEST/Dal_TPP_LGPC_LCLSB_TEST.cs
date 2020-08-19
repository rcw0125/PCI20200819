using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;
namespace DAL
{
	/// <summary>
	/// 数据访问类:TPP_LGPC_LCLSB_TEST
	/// </summary>
	public partial class Dal_TPP_LGPC_LCLSB_TEST
    {
		public Dal_TPP_LGPC_LCLSB_TEST()
		{}

        /// <summary>
        /// 获取炉次列表
        /// </summary>
        /// <param name="c_fk">浇次主键集合</param>
        /// <returns></returns>
        public DataSet Get_LC_List_Trans()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ta.* from TPP_LGPC_LCLSB_TEST ta inner join tpp_lgpc_lsb_test tb on ta.c_fk=tb.c_id where ta.N_STATUS=1 and tb.C_CCM_CODE<> '5#CC' ");

            strSql.Append(" order by tb.d_p_start_time,ta.n_sort ");

            return TransactionHelper.Query(strSql.ToString());
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Mod_TPP_LGPC_LCLSB_TEST DataRowToModel(DataRow row)
        {
            Mod_TPP_LGPC_LCLSB_TEST model = new Mod_TPP_LGPC_LCLSB_TEST();
            if (row != null)
            {
                if (row["C_ID"] != null)
                {
                    model.C_ID = row["C_ID"].ToString();
                }
                if (row["C_FK"] != null)
                {
                    model.C_FK = row["C_FK"].ToString();
                }
                if (row["C_ORDER_NO"] != null)
                {
                    model.C_ORDER_NO = row["C_ORDER_NO"].ToString();
                }
                if (row["C_DESIGN_NO"] != null)
                {
                    model.C_DESIGN_NO = row["C_DESIGN_NO"].ToString();
                }
                if (row["N_SLAB_WGT"] != null && row["N_SLAB_WGT"].ToString() != "")
                {
                    model.N_SLAB_WGT = decimal.Parse(row["N_SLAB_WGT"].ToString());
                }
                if (row["C_CTRL_NO"] != null)
                {
                    model.C_CTRL_NO = row["C_CTRL_NO"].ToString();
                }
                if (row["C_CCM_ID"] != null)
                {
                    model.C_CCM_ID = row["C_CCM_ID"].ToString();
                }
                if (row["C_CCM_DESC"] != null)
                {
                    model.C_CCM_DESC = row["C_CCM_DESC"].ToString();
                }
                if (row["C_PROD_NAME"] != null)
                {
                    model.C_PROD_NAME = row["C_PROD_NAME"].ToString();
                }
                if (row["C_STL_GRD"] != null)
                {
                    model.C_STL_GRD = row["C_STL_GRD"].ToString();
                }
                if (row["C_SPEC_CODE"] != null)
                {
                    model.C_SPEC_CODE = row["C_SPEC_CODE"].ToString();
                }
                if (row["C_LENGTH"] != null)
                {
                    model.C_LENGTH = row["C_LENGTH"].ToString();
                }
                if (row["C_MATRL_NO"] != null)
                {
                    model.C_MATRL_NO = row["C_MATRL_NO"].ToString();
                }
                if (row["C_MATRL_NAME"] != null)
                {
                    model.C_MATRL_NAME = row["C_MATRL_NAME"].ToString();
                }
                if (row["C_SLAB_SIZE"] != null)
                {
                    model.C_SLAB_SIZE = row["C_SLAB_SIZE"].ToString();
                }
                if (row["C_SLAB_LENGTH"] != null)
                {
                    model.C_SLAB_LENGTH = row["C_SLAB_LENGTH"].ToString();
                }
                if (row["C_STATE"] != null)
                {
                    model.C_STATE = row["C_STATE"].ToString();
                }
                if (row["C_STD_CODE"] != null)
                {
                    model.C_STD_CODE = row["C_STD_CODE"].ToString();
                }
                if (row["C_INITIALIZE_ITEM_ID"] != null)
                {
                    model.C_INITIALIZE_ITEM_ID = row["C_INITIALIZE_ITEM_ID"].ToString();
                }
                if (row["D_P_START_TIME"] != null && row["D_P_START_TIME"].ToString() != "")
                {
                    model.D_P_START_TIME = DateTime.Parse(row["D_P_START_TIME"].ToString());
                }
                if (row["D_P_END_TIME"] != null && row["D_P_END_TIME"].ToString() != "")
                {
                    model.D_P_END_TIME = DateTime.Parse(row["D_P_END_TIME"].ToString());
                }
                if (row["N_PROD_TIME"] != null && row["N_PROD_TIME"].ToString() != "")
                {
                    model.N_PROD_TIME = decimal.Parse(row["N_PROD_TIME"].ToString());
                }
                if (row["N_SORT"] != null && row["N_SORT"].ToString() != "")
                {
                    model.N_SORT = decimal.Parse(row["N_SORT"].ToString());
                }
                if (row["C_CAST_NO"] != null)
                {
                    model.C_CAST_NO = row["C_CAST_NO"].ToString();
                }
                if (row["N_STATUS"] != null && row["N_STATUS"].ToString() != "")
                {
                    model.N_STATUS = decimal.Parse(row["N_STATUS"].ToString());
                }
                if (row["C_EMP_ID"] != null)
                {
                    model.C_EMP_ID = row["C_EMP_ID"].ToString();
                }
                if (row["D_MOD_DT"] != null && row["D_MOD_DT"].ToString() != "")
                {
                    model.D_MOD_DT = DateTime.Parse(row["D_MOD_DT"].ToString());
                }
                if (row["C_REMARK"] != null)
                {
                    model.C_REMARK = row["C_REMARK"].ToString();
                }
                if (row["N_CREAT_PLAN"] != null && row["N_CREAT_PLAN"].ToString() != "")
                {
                    model.N_CREAT_PLAN = decimal.Parse(row["N_CREAT_PLAN"].ToString());
                }
                if (row["N_CREAT_ZG_PLAN"] != null && row["N_CREAT_ZG_PLAN"].ToString() != "")
                {
                    model.N_CREAT_ZG_PLAN = decimal.Parse(row["N_CREAT_ZG_PLAN"].ToString());
                }
                if (row["N_PRODUCE_TIME"] != null && row["N_PRODUCE_TIME"].ToString() != "")
                {
                    model.N_PRODUCE_TIME = decimal.Parse(row["N_PRODUCE_TIME"].ToString());
                }
                if (row["C_ZL_ID"] != null)
                {
                    model.C_ZL_ID = row["C_ZL_ID"].ToString();
                }
                if (row["C_LF_ID"] != null)
                {
                    model.C_LF_ID = row["C_LF_ID"].ToString();
                }
                if (row["C_RH_ID"] != null)
                {
                    model.C_RH_ID = row["C_RH_ID"].ToString();
                }
                if (row["C_LGJH"] != null)
                {
                    model.C_LGJH = row["C_LGJH"].ToString();
                }
                if (row["C_QUA"] != null)
                {
                    model.C_QUA = row["C_QUA"].ToString();
                }
                if (row["D_ARRIVE_ZG_TIME"] != null && row["D_ARRIVE_ZG_TIME"].ToString() != "")
                {
                    model.D_ARRIVE_ZG_TIME = DateTime.Parse(row["D_ARRIVE_ZG_TIME"].ToString());
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
                if (row["C_STOVE_NO"] != null)
                {
                    model.C_STOVE_NO = row["C_STOVE_NO"].ToString();
                }
                if (row["D_DFPHL_START_TIME_SJ"] != null && row["D_DFPHL_START_TIME_SJ"].ToString() != "")
                {
                    model.D_DFPHL_START_TIME_SJ = DateTime.Parse(row["D_DFPHL_START_TIME_SJ"].ToString());
                }
                if (row["D_DFPHL_END_TIME_SJ"] != null && row["D_DFPHL_END_TIME_SJ"].ToString() != "")
                {
                    model.D_DFPHL_END_TIME_SJ = DateTime.Parse(row["D_DFPHL_END_TIME_SJ"].ToString());
                }
                if (row["D_KP_START_TIME_SJ"] != null && row["D_KP_START_TIME_SJ"].ToString() != "")
                {
                    model.D_KP_START_TIME_SJ = DateTime.Parse(row["D_KP_START_TIME_SJ"].ToString());
                }
                if (row["D_KP_END_TIME_SJ"] != null && row["D_KP_END_TIME_SJ"].ToString() != "")
                {
                    model.D_KP_END_TIME_SJ = DateTime.Parse(row["D_KP_END_TIME_SJ"].ToString());
                }
                if (row["D_HL_START_TIME_SJ"] != null && row["D_HL_START_TIME_SJ"].ToString() != "")
                {
                    model.D_HL_START_TIME_SJ = DateTime.Parse(row["D_HL_START_TIME_SJ"].ToString());
                }
                if (row["D_HL_END_TIME_SJ"] != null && row["D_HL_END_TIME_SJ"].ToString() != "")
                {
                    model.D_HL_END_TIME_SJ = DateTime.Parse(row["D_HL_END_TIME_SJ"].ToString());
                }
                if (row["D_XM_START_TIME_SJ"] != null && row["D_XM_START_TIME_SJ"].ToString() != "")
                {
                    model.D_XM_START_TIME_SJ = DateTime.Parse(row["D_XM_START_TIME_SJ"].ToString());
                }
                if (row["D_XM_END_TIME_SJ"] != null && row["D_XM_END_TIME_SJ"].ToString() != "")
                {
                    model.D_XM_END_TIME_SJ = DateTime.Parse(row["D_XM_END_TIME_SJ"].ToString());
                }
                if (row["N_SJ_WGT"] != null && row["N_SJ_WGT"].ToString() != "")
                {
                    model.N_SJ_WGT = decimal.Parse(row["N_SJ_WGT"].ToString());
                }
                if (row["D_START_TIME_SJ"] != null && row["D_START_TIME_SJ"].ToString() != "")
                {
                    model.D_START_TIME_SJ = DateTime.Parse(row["D_START_TIME_SJ"].ToString());
                }
                if (row["D_END_TIME_SJ"] != null && row["D_END_TIME_SJ"].ToString() != "")
                {
                    model.D_END_TIME_SJ = DateTime.Parse(row["D_END_TIME_SJ"].ToString());
                }
                if (row["N_DFP_HL_TIME"] != null && row["N_DFP_HL_TIME"].ToString() != "")
                {
                    model.N_DFP_HL_TIME = decimal.Parse(row["N_DFP_HL_TIME"].ToString());
                }
                if (row["N_HL_TIME"] != null && row["N_HL_TIME"].ToString() != "")
                {
                    model.N_HL_TIME = decimal.Parse(row["N_HL_TIME"].ToString());
                }
                if (row["C_ROUTE"] != null)
                {
                    model.C_ROUTE = row["C_ROUTE"].ToString();
                }
                if (row["N_SLAB_PW"] != null && row["N_SLAB_PW"].ToString() != "")
                {
                    model.N_SLAB_PW = decimal.Parse(row["N_SLAB_PW"].ToString());
                }
                if (row["C_MATRL_CODE_KP"] != null)
                {
                    model.C_MATRL_CODE_KP = row["C_MATRL_CODE_KP"].ToString();
                }
                if (row["C_MATRL_NAME_KP"] != null)
                {
                    model.C_MATRL_NAME_KP = row["C_MATRL_NAME_KP"].ToString();
                }
                if (row["C_KP_SIZE"] != null)
                {
                    model.C_KP_SIZE = row["C_KP_SIZE"].ToString();
                }
                if (row["N_KP_LENGTH"] != null && row["N_KP_LENGTH"].ToString() != "")
                {
                    model.N_KP_LENGTH = decimal.Parse(row["N_KP_LENGTH"].ToString());
                }
                if (row["N_KP_PW"] != null && row["N_KP_PW"].ToString() != "")
                {
                    model.N_KP_PW = decimal.Parse(row["N_KP_PW"].ToString());
                }
                if (row["N_USE_WGT"] != null && row["N_USE_WGT"].ToString() != "")
                {
                    model.N_USE_WGT = decimal.Parse(row["N_USE_WGT"].ToString());
                }
                if (row["D_USE_START_TIME_SJ"] != null && row["D_USE_START_TIME_SJ"].ToString() != "")
                {
                    model.D_USE_START_TIME_SJ = DateTime.Parse(row["D_USE_START_TIME_SJ"].ToString());
                }
                if (row["D_USE_END_TIME_SJ"] != null && row["D_USE_END_TIME_SJ"].ToString() != "")
                {
                    model.D_USE_END_TIME_SJ = DateTime.Parse(row["D_USE_END_TIME_SJ"].ToString());
                }
                if (row["D_CAN_USE_TIME"] != null && row["D_CAN_USE_TIME"].ToString() != "")
                {
                    model.D_CAN_USE_TIME = DateTime.Parse(row["D_CAN_USE_TIME"].ToString());
                }
                if (row["N_RH_NUM"] != null && row["N_RH_NUM"].ToString() != "")
                {
                    model.N_RH_NUM = decimal.Parse(row["N_RH_NUM"].ToString());
                }
                if (row["N_KP_WGT"] != null && row["N_KP_WGT"].ToString() != "")
                {
                    model.N_KP_WGT = decimal.Parse(row["N_KP_WGT"].ToString());
                }
                if (row["N_XM_WGT"] != null && row["N_XM_WGT"].ToString() != "")
                {
                    model.N_XM_WGT = decimal.Parse(row["N_XM_WGT"].ToString());
                }
                if (row["C_DFP_RZ"] != null)
                {
                    model.C_DFP_RZ = row["C_DFP_RZ"].ToString();
                }
                if (row["C_RZP_RZ"] != null)
                {
                    model.C_RZP_RZ = row["C_RZP_RZ"].ToString();
                }
                if (row["C_DFP_YQ"] != null)
                {
                    model.C_DFP_YQ = row["C_DFP_YQ"].ToString();
                }
                if (row["C_RZP_YQ"] != null)
                {
                    model.C_RZP_YQ = row["C_RZP_YQ"].ToString();
                }
                if (row["C_STL_GRD_TYPE"] != null)
                {
                    model.C_STL_GRD_TYPE = row["C_STL_GRD_TYPE"].ToString();
                }
                if (row["C_PROD_KIND"] != null)
                {
                    model.C_PROD_KIND = row["C_PROD_KIND"].ToString();
                }
                if (row["C_TL"] != null)
                {
                    model.C_TL = row["C_TL"].ToString();
                }
                if (row["N_JSCN"] != null && row["N_JSCN"].ToString() != "")
                {
                    model.N_JSCN = decimal.Parse(row["N_JSCN"].ToString());
                }
                if (row["C_FREE2"] != null)
                {
                    model.C_FREE2 = row["C_FREE2"].ToString();
                }
                if (row["N_GROUP"] != null && row["N_GROUP"].ToString() != "")
                {
                    model.N_GROUP = decimal.Parse(row["N_GROUP"].ToString());
                }
                if (row["N_ZJCLS"] != null && row["N_ZJCLS"].ToString() != "")
                {
                    model.N_ZJCLS = decimal.Parse(row["N_ZJCLS"].ToString());
                }
                if (row["N_ZJCLS_MIN"] != null && row["N_ZJCLS_MIN"].ToString() != "")
                {
                    model.N_ZJCLS_MIN = decimal.Parse(row["N_ZJCLS_MIN"].ToString());
                }
                if (row["N_ZJCLS_MAX"] != null && row["N_ZJCLS_MAX"].ToString() != "")
                {
                    model.N_ZJCLS_MAX = decimal.Parse(row["N_ZJCLS_MAX"].ToString());
                }
                if (row["C_SL"] != null)
                {
                    model.C_SL = row["C_SL"].ToString();
                }
                if (row["C_WL"] != null)
                {
                    model.C_WL = row["C_WL"].ToString();
                }
                if (row["C_SLAB_TYPE"] != null)
                {
                    model.C_SLAB_TYPE = row["C_SLAB_TYPE"].ToString();
                }
                if (row["N_JC_SORT"] != null && row["N_JC_SORT"].ToString() != "")
                {
                    model.N_JC_SORT = decimal.Parse(row["N_JC_SORT"].ToString());
                }
                if (row["C_FREE1"] != null)
                {
                    model.C_FREE1 = row["C_FREE1"].ToString();
                }
            }
            return model;
        }

        /// <summary>
        /// 批量删除数据
        /// </summary>
        public bool Delete_Trans(string C_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from TPP_LGPC_LCLSB_TEST ");
            strSql.Append(" where C_ID = '" + C_ID + "' ");
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

