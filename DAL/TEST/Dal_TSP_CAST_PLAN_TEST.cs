using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;
namespace DAL
{
	/// <summary>
	/// 数据访问类:TSP_CAST_PLAN_TEST
	/// </summary>
	public partial class Dal_TSP_CAST_PLAN_TEST
	{
		public Dal_TSP_CAST_PLAN_TEST()
		{}

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add_Trans(Mod_TSP_CAST_PLAN_TEST model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TSP_CAST_PLAN_TEST(");
            strSql.Append("C_ID,C_CCM_ID,C_CCM_CODE,N_GROUP,N_TOTAL_WGT,N_ZJCLS,N_ZJCLZL,N_MLZL,N_SORT,C_STL_GRD,N_PRODUCE_TIME,N_JSCN,C_BY1,C_BY2,C_BY3,C_RH,C_DFP_HL,C_HL,C_XM,N_ORDER_LS,D_DFPHL_START_TIME,D_DFPHL_END_TIME,D_KP_START_TIME,D_KP_END_TIME,D_HL_START_TIME,D_HL_END_TIME,D_PLAN_KY_TIME,C_PLAN_ROLL,D_ZZ_START_TIME,D_ZZ_END_TIME,D_XM_START_TIME,D_XM_END_TIME,C_STD_CODE,C_SLAB_TYPE,C_STL_GRD_TYPE,C_PROD_NAME,C_PROD_KIND,N_DFP_HL_TIME,N_HL_TIME,N_XM_TIME,N_GG,N_CCM_TIME,C_TJ_REMARK,C_TL,N_RH,N_TL,N_GZSL,C_REMARK,N_XM,N_DHL,N_HL,N_STATUS,D_P_START_TIME,D_P_END_TIME,N_DFP_RZ,N_RZP_RZ,C_RH_SFJS,C_TZ_REMARK)");
            strSql.Append(" values (");
            strSql.Append(":C_ID,:C_CCM_ID,:C_CCM_CODE,:N_GROUP,:N_TOTAL_WGT,:N_ZJCLS,:N_ZJCLZL,:N_MLZL,:N_SORT,:C_STL_GRD,:N_PRODUCE_TIME,:N_JSCN,:C_BY1,:C_BY2,:C_BY3,:C_RH,:C_DFP_HL,:C_HL,:C_XM,:N_ORDER_LS,:D_DFPHL_START_TIME,:D_DFPHL_END_TIME,:D_KP_START_TIME,:D_KP_END_TIME,:D_HL_START_TIME,:D_HL_END_TIME,:D_PLAN_KY_TIME,:C_PLAN_ROLL,:D_ZZ_START_TIME,:D_ZZ_END_TIME,:D_XM_START_TIME,:D_XM_END_TIME,:C_STD_CODE,:C_SLAB_TYPE,:C_STL_GRD_TYPE,:C_PROD_NAME,:C_PROD_KIND,:N_DFP_HL_TIME,:N_HL_TIME,:N_XM_TIME,:N_GG,:N_CCM_TIME,:C_TJ_REMARK,:C_TL,:N_RH,:N_TL,:N_GZSL,:C_REMARK,:N_XM,:N_DHL,:N_HL,:N_STATUS,:D_P_START_TIME,:D_P_END_TIME,:N_DFP_RZ,:N_RZP_RZ,:C_RH_SFJS,:C_TZ_REMARK)");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CCM_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CCM_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_GROUP", OracleDbType.Decimal,4),
                    new OracleParameter(":N_TOTAL_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":N_ZJCLS", OracleDbType.Decimal,4),
                    new OracleParameter(":N_ZJCLZL", OracleDbType.Decimal,4),
                    new OracleParameter(":N_MLZL", OracleDbType.Decimal,15),
                    new OracleParameter(":N_SORT", OracleDbType.Decimal,10),
                    new OracleParameter(":C_STL_GRD", OracleDbType.Varchar2,500),
                    new OracleParameter(":N_PRODUCE_TIME", OracleDbType.Decimal,15),
                    new OracleParameter(":N_JSCN", OracleDbType.Decimal,4),
                    new OracleParameter(":C_BY1", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_BY2", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_BY3", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_RH", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_DFP_HL", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_HL", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_XM", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_ORDER_LS", OracleDbType.Decimal,4),
                    new OracleParameter(":D_DFPHL_START_TIME", OracleDbType.Date),
                    new OracleParameter(":D_DFPHL_END_TIME", OracleDbType.Date),
                    new OracleParameter(":D_KP_START_TIME", OracleDbType.Date),
                    new OracleParameter(":D_KP_END_TIME", OracleDbType.Date),
                    new OracleParameter(":D_HL_START_TIME", OracleDbType.Date),
                    new OracleParameter(":D_HL_END_TIME", OracleDbType.Date),
                    new OracleParameter(":D_PLAN_KY_TIME", OracleDbType.Date),
                    new OracleParameter(":C_PLAN_ROLL", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_ZZ_START_TIME", OracleDbType.Date),
                    new OracleParameter(":D_ZZ_END_TIME", OracleDbType.Date),
                    new OracleParameter(":D_XM_START_TIME", OracleDbType.Date),
                    new OracleParameter(":D_XM_END_TIME", OracleDbType.Date),
                    new OracleParameter(":C_STD_CODE", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_SLAB_TYPE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STL_GRD_TYPE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PROD_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PROD_KIND", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_DFP_HL_TIME", OracleDbType.Decimal,10),
                    new OracleParameter(":N_HL_TIME", OracleDbType.Decimal,10),
                    new OracleParameter(":N_XM_TIME", OracleDbType.Decimal,10),
                    new OracleParameter(":N_GG", OracleDbType.Decimal,10),
                    new OracleParameter(":N_CCM_TIME", OracleDbType.Decimal,10),
                    new OracleParameter(":C_TJ_REMARK", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_TL", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_RH", OracleDbType.Decimal,5),
                    new OracleParameter(":N_TL", OracleDbType.Decimal,5),
                    new OracleParameter(":N_GZSL", OracleDbType.Decimal,5),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,1000),
                    new OracleParameter(":N_XM", OracleDbType.Decimal,5),
                    new OracleParameter(":N_DHL", OracleDbType.Decimal,5),
                    new OracleParameter(":N_HL", OracleDbType.Decimal,5),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,5),
                    new OracleParameter(":D_P_START_TIME", OracleDbType.Date),
                    new OracleParameter(":D_P_END_TIME", OracleDbType.Date),
                    new OracleParameter(":N_DFP_RZ", OracleDbType.Decimal,5),
                    new OracleParameter(":N_RZP_RZ", OracleDbType.Decimal,5),
                    new OracleParameter(":C_RH_SFJS", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_TZ_REMARK", OracleDbType.Varchar2,1000)};
            parameters[0].Value = model.C_ID;
            parameters[1].Value = model.C_CCM_ID;
            parameters[2].Value = model.C_CCM_CODE;
            parameters[3].Value = model.N_GROUP;
            parameters[4].Value = model.N_TOTAL_WGT;
            parameters[5].Value = model.N_ZJCLS;
            parameters[6].Value = model.N_ZJCLZL;
            parameters[7].Value = model.N_MLZL;
            parameters[8].Value = model.N_SORT;
            parameters[9].Value = model.C_STL_GRD;
            parameters[10].Value = model.N_PRODUCE_TIME;
            parameters[11].Value = model.N_JSCN;
            parameters[12].Value = model.C_BY1;
            parameters[13].Value = model.C_BY2;
            parameters[14].Value = model.C_BY3;
            parameters[15].Value = model.C_RH;
            parameters[16].Value = model.C_DFP_HL;
            parameters[17].Value = model.C_HL;
            parameters[18].Value = model.C_XM;
            parameters[19].Value = model.N_ORDER_LS;
            parameters[20].Value = model.D_DFPHL_START_TIME;
            parameters[21].Value = model.D_DFPHL_END_TIME;
            parameters[22].Value = model.D_KP_START_TIME;
            parameters[23].Value = model.D_KP_END_TIME;
            parameters[24].Value = model.D_HL_START_TIME;
            parameters[25].Value = model.D_HL_END_TIME;
            parameters[26].Value = model.D_PLAN_KY_TIME;
            parameters[27].Value = model.C_PLAN_ROLL;
            parameters[28].Value = model.D_ZZ_START_TIME;
            parameters[29].Value = model.D_ZZ_END_TIME;
            parameters[30].Value = model.D_XM_START_TIME;
            parameters[31].Value = model.D_XM_END_TIME;
            parameters[32].Value = model.C_STD_CODE;
            parameters[33].Value = model.C_SLAB_TYPE;
            parameters[34].Value = model.C_STL_GRD_TYPE;
            parameters[35].Value = model.C_PROD_NAME;
            parameters[36].Value = model.C_PROD_KIND;
            parameters[37].Value = model.N_DFP_HL_TIME;
            parameters[38].Value = model.N_HL_TIME;
            parameters[39].Value = model.N_XM_TIME;
            parameters[40].Value = model.N_GG;
            parameters[41].Value = model.N_CCM_TIME;
            parameters[42].Value = model.C_TJ_REMARK;
            parameters[43].Value = model.C_TL;
            parameters[44].Value = model.N_RH;
            parameters[45].Value = model.N_TL;
            parameters[46].Value = model.N_GZSL;
            parameters[47].Value = model.C_REMARK;
            parameters[48].Value = model.N_XM;
            parameters[49].Value = model.N_DHL;
            parameters[50].Value = model.N_HL;
            parameters[51].Value = model.N_STATUS;
            parameters[52].Value = model.D_P_START_TIME;
            parameters[53].Value = model.D_P_END_TIME;
            parameters[54].Value = model.N_DFP_RZ;
            parameters[55].Value = model.N_RZP_RZ;
            parameters[56].Value = model.C_RH_SFJS;//
            parameters[57].Value = model.C_TZ_REMARK;
            int rows = TransactionHelper.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 获取浇次最大序号
        /// </summary>
        public int Max_jc_sort(string strCcm)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select max(N_SORT) FROM TSP_CAST_PLAN_TEST where C_CCM_ID='" + strCcm + "' ");

            object obj = DbHelperOra.GetSingle(strSql.ToString());
            if (obj == null)
            {
                return 0;
            }
            else
            {
                return Convert.ToInt32(obj);
            }
        }
    }
}

