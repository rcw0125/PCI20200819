using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;
namespace DAL
{
    /// <summary>
    /// 数据访问类:TSP_CAST_PLAN
    /// </summary>
    public partial class Dal_TSP_CAST_PLAN
    {
        public Dal_TSP_CAST_PLAN()
        { }
        #region  BasicMethod


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Mod_TSP_CAST_PLAN model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TSP_CAST_PLAN(");
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
                    new OracleParameter(":C_TZ_REMARK", OracleDbType.Varchar2,1000)};//C_TZ_REMARK
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
            parameters[56].Value = model.C_RH_SFJS;
            parameters[57].Value = model.C_TZ_REMARK; //C_TZ_REMARK

            int rows = DbHelperOra.ExecuteSql(strSql.ToString(), parameters);
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
        /// 增加一条数据
        /// </summary>
        public bool Add_Trans(Mod_TSP_CAST_PLAN model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TSP_CAST_PLAN(");
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
        /// 更新一条数据
        /// </summary>
        public bool Update(Mod_TSP_CAST_PLAN model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TSP_CAST_PLAN set ");
            strSql.Append("C_CCM_ID=:C_CCM_ID,");
            strSql.Append("C_CCM_CODE=:C_CCM_CODE,");
            strSql.Append("N_GROUP=:N_GROUP,");
            strSql.Append("N_TOTAL_WGT=:N_TOTAL_WGT,");
            strSql.Append("N_ZJCLS=:N_ZJCLS,");
            strSql.Append("N_ZJCLZL=:N_ZJCLZL,");
            strSql.Append("N_MLZL=:N_MLZL,");
            strSql.Append("N_SORT=:N_SORT,");
            strSql.Append("C_STL_GRD=:C_STL_GRD,");
            strSql.Append("N_PRODUCE_TIME=:N_PRODUCE_TIME,");
            strSql.Append("N_JSCN=:N_JSCN,");
            strSql.Append("C_BY1=:C_BY1,");
            strSql.Append("C_BY2=:C_BY2,");
            strSql.Append("C_BY3=:C_BY3,");
            strSql.Append("C_RH=:C_RH,");
            strSql.Append("C_DFP_HL=:C_DFP_HL,");
            strSql.Append("C_HL=:C_HL,");
            strSql.Append("C_XM=:C_XM,");
            strSql.Append("N_ORDER_LS=:N_ORDER_LS,");
            strSql.Append("D_DFPHL_START_TIME=:D_DFPHL_START_TIME,");
            strSql.Append("D_DFPHL_END_TIME=:D_DFPHL_END_TIME,");
            strSql.Append("D_KP_START_TIME=:D_KP_START_TIME,");
            strSql.Append("D_KP_END_TIME=:D_KP_END_TIME,");
            strSql.Append("D_HL_START_TIME=:D_HL_START_TIME,");
            strSql.Append("D_HL_END_TIME=:D_HL_END_TIME,");
            strSql.Append("D_PLAN_KY_TIME=:D_PLAN_KY_TIME,");
            strSql.Append("C_PLAN_ROLL=:C_PLAN_ROLL,");
            strSql.Append("D_ZZ_START_TIME=:D_ZZ_START_TIME,");
            strSql.Append("D_ZZ_END_TIME=:D_ZZ_END_TIME,");
            strSql.Append("D_XM_START_TIME=:D_XM_START_TIME,");
            strSql.Append("D_XM_END_TIME=:D_XM_END_TIME,");
            strSql.Append("C_STD_CODE=:C_STD_CODE,");
            strSql.Append("C_SLAB_TYPE=:C_SLAB_TYPE,");
            strSql.Append("C_STL_GRD_TYPE=:C_STL_GRD_TYPE,");
            strSql.Append("C_PROD_NAME=:C_PROD_NAME,");
            strSql.Append("C_PROD_KIND=:C_PROD_KIND,");
            strSql.Append("N_DFP_HL_TIME=:N_DFP_HL_TIME,");
            strSql.Append("N_HL_TIME=:N_HL_TIME,");
            strSql.Append("N_XM_TIME=:N_XM_TIME,");
            strSql.Append("N_GG=:N_GG,");
            strSql.Append("N_CCM_TIME=:N_CCM_TIME,");
            strSql.Append("C_TJ_REMARK=:C_TJ_REMARK,");
            strSql.Append("C_TL=:C_TL,");
            strSql.Append("N_RH=:N_RH,");
            strSql.Append("N_TL=:N_TL,");
            strSql.Append("N_GZSL=:N_GZSL,");
            strSql.Append("C_REMARK=:C_REMARK,");
            strSql.Append("N_XM=:N_XM,");
            strSql.Append("N_DHL=:N_DHL,");
            strSql.Append("N_HL=:N_HL,");
            strSql.Append("N_STATUS=:N_STATUS,");
            strSql.Append("D_P_START_TIME=:D_P_START_TIME,");
            strSql.Append("D_P_END_TIME=:D_P_END_TIME,");
            strSql.Append("N_DFP_RZ=:N_DFP_RZ,");
            strSql.Append("N_RZP_RZ=:N_RZP_RZ,");
            strSql.Append("C_RH_SFJS=:C_RH_SFJS,");
            strSql.Append("C_TZ_REMARK=:C_TZ_REMARK ");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
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
                    new OracleParameter(":C_TZ_REMARK", OracleDbType.Varchar2,1000),//C_TZ_REMARK
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.C_CCM_ID;
            parameters[1].Value = model.C_CCM_CODE;
            parameters[2].Value = model.N_GROUP;
            parameters[3].Value = model.N_TOTAL_WGT;
            parameters[4].Value = model.N_ZJCLS;
            parameters[5].Value = model.N_ZJCLZL;
            parameters[6].Value = model.N_MLZL;
            parameters[7].Value = model.N_SORT;
            parameters[8].Value = model.C_STL_GRD;
            parameters[9].Value = model.N_PRODUCE_TIME;
            parameters[10].Value = model.N_JSCN;
            parameters[11].Value = model.C_BY1;
            parameters[12].Value = model.C_BY2;
            parameters[13].Value = model.C_BY3;
            parameters[14].Value = model.C_RH;
            parameters[15].Value = model.C_DFP_HL;
            parameters[16].Value = model.C_HL;
            parameters[17].Value = model.C_XM;
            parameters[18].Value = model.N_ORDER_LS;
            parameters[19].Value = model.D_DFPHL_START_TIME;
            parameters[20].Value = model.D_DFPHL_END_TIME;
            parameters[21].Value = model.D_KP_START_TIME;
            parameters[22].Value = model.D_KP_END_TIME;
            parameters[23].Value = model.D_HL_START_TIME;
            parameters[24].Value = model.D_HL_END_TIME;
            parameters[25].Value = model.D_PLAN_KY_TIME;
            parameters[26].Value = model.C_PLAN_ROLL;
            parameters[27].Value = model.D_ZZ_START_TIME;
            parameters[28].Value = model.D_ZZ_END_TIME;
            parameters[29].Value = model.D_XM_START_TIME;
            parameters[30].Value = model.D_XM_END_TIME;
            parameters[31].Value = model.C_STD_CODE;
            parameters[32].Value = model.C_SLAB_TYPE;
            parameters[33].Value = model.C_STL_GRD_TYPE;
            parameters[34].Value = model.C_PROD_NAME;
            parameters[35].Value = model.C_PROD_KIND;
            parameters[36].Value = model.N_DFP_HL_TIME;
            parameters[37].Value = model.N_HL_TIME;
            parameters[38].Value = model.N_XM_TIME;
            parameters[39].Value = model.N_GG;
            parameters[40].Value = model.N_CCM_TIME;
            parameters[41].Value = model.C_TJ_REMARK;
            parameters[42].Value = model.C_TL;
            parameters[43].Value = model.N_RH;
            parameters[44].Value = model.N_TL;
            parameters[45].Value = model.N_GZSL;
            parameters[46].Value = model.C_REMARK;
            parameters[47].Value = model.N_XM;
            parameters[48].Value = model.N_DHL;
            parameters[49].Value = model.N_HL;
            parameters[50].Value = model.N_STATUS;
            parameters[51].Value = model.D_P_START_TIME;
            parameters[52].Value = model.D_P_END_TIME;
            parameters[53].Value = model.N_DFP_RZ;
            parameters[54].Value = model.N_RZP_RZ;
            parameters[55].Value = model.C_RH_SFJS;
            parameters[56].Value = model.C_TZ_REMARK;//C_TZ_REMARK
            parameters[57].Value = model.C_ID;

            int rows = DbHelperOra.ExecuteSql(strSql.ToString(), parameters);
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
        /// 更新一条数据
        /// </summary>
        public bool Update_Trans(Mod_TSP_CAST_PLAN model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TSP_CAST_PLAN set ");
            strSql.Append("C_CCM_ID=:C_CCM_ID,");
            strSql.Append("C_CCM_CODE=:C_CCM_CODE,");
            strSql.Append("N_GROUP=:N_GROUP,");
            strSql.Append("N_TOTAL_WGT=:N_TOTAL_WGT,");
            strSql.Append("N_ZJCLS=:N_ZJCLS,");
            strSql.Append("N_ZJCLZL=:N_ZJCLZL,");
            strSql.Append("N_MLZL=:N_MLZL,");
            strSql.Append("N_SORT=:N_SORT,");
            strSql.Append("C_STL_GRD=:C_STL_GRD,");
            strSql.Append("N_PRODUCE_TIME=:N_PRODUCE_TIME,");
            strSql.Append("N_JSCN=:N_JSCN,");
            strSql.Append("C_BY1=:C_BY1,");
            strSql.Append("C_BY2=:C_BY2,");
            strSql.Append("C_BY3=:C_BY3,");
            strSql.Append("C_RH=:C_RH,");
            strSql.Append("C_DFP_HL=:C_DFP_HL,");
            strSql.Append("C_HL=:C_HL,");
            strSql.Append("C_XM=:C_XM,");
            strSql.Append("N_ORDER_LS=:N_ORDER_LS,");
            strSql.Append("D_DFPHL_START_TIME=:D_DFPHL_START_TIME,");
            strSql.Append("D_DFPHL_END_TIME=:D_DFPHL_END_TIME,");
            strSql.Append("D_KP_START_TIME=:D_KP_START_TIME,");
            strSql.Append("D_KP_END_TIME=:D_KP_END_TIME,");
            strSql.Append("D_HL_START_TIME=:D_HL_START_TIME,");
            strSql.Append("D_HL_END_TIME=:D_HL_END_TIME,");
            strSql.Append("D_PLAN_KY_TIME=:D_PLAN_KY_TIME,");
            strSql.Append("C_PLAN_ROLL=:C_PLAN_ROLL,");
            strSql.Append("D_ZZ_START_TIME=:D_ZZ_START_TIME,");
            strSql.Append("D_ZZ_END_TIME=:D_ZZ_END_TIME,");
            strSql.Append("D_XM_START_TIME=:D_XM_START_TIME,");
            strSql.Append("D_XM_END_TIME=:D_XM_END_TIME,");
            strSql.Append("C_STD_CODE=:C_STD_CODE,");
            strSql.Append("C_SLAB_TYPE=:C_SLAB_TYPE,");
            strSql.Append("C_STL_GRD_TYPE=:C_STL_GRD_TYPE,");
            strSql.Append("C_PROD_NAME=:C_PROD_NAME,");
            strSql.Append("C_PROD_KIND=:C_PROD_KIND,");
            strSql.Append("N_DFP_HL_TIME=:N_DFP_HL_TIME,");
            strSql.Append("N_HL_TIME=:N_HL_TIME,");
            strSql.Append("N_XM_TIME=:N_XM_TIME,");
            strSql.Append("N_GG=:N_GG,");
            strSql.Append("N_CCM_TIME=:N_CCM_TIME,");
            strSql.Append("C_TJ_REMARK=:C_TJ_REMARK,");
            strSql.Append("C_TL=:C_TL,");
            strSql.Append("N_RH=:N_RH,");
            strSql.Append("N_TL=:N_TL,");
            strSql.Append("N_GZSL=:N_GZSL,");
            strSql.Append("C_REMARK=:C_REMARK,");
            strSql.Append("N_XM=:N_XM,");
            strSql.Append("N_DHL=:N_DHL,");
            strSql.Append("N_HL=:N_HL,");
            strSql.Append("N_STATUS=:N_STATUS,");
            strSql.Append("D_P_START_TIME=:D_P_START_TIME,");
            strSql.Append("D_P_END_TIME=:D_P_END_TIME,");
            strSql.Append("N_DFP_RZ=:N_DFP_RZ,");
            strSql.Append("N_RZP_RZ=:N_RZP_RZ,");
            strSql.Append("C_RH_SFJS=:C_RH_SFJS,");
            strSql.Append("C_TZ_REMARK=:C_TZ_REMARK ");//C_TZ_REMARK
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
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
                    new OracleParameter(":C_TZ_REMARK", OracleDbType.Varchar2,1000),//C_TZ_REMARK
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.C_CCM_ID;
            parameters[1].Value = model.C_CCM_CODE;
            parameters[2].Value = model.N_GROUP;
            parameters[3].Value = model.N_TOTAL_WGT;
            parameters[4].Value = model.N_ZJCLS;
            parameters[5].Value = model.N_ZJCLZL;
            parameters[6].Value = model.N_MLZL;
            parameters[7].Value = model.N_SORT;
            parameters[8].Value = model.C_STL_GRD;
            parameters[9].Value = model.N_PRODUCE_TIME;
            parameters[10].Value = model.N_JSCN;
            parameters[11].Value = model.C_BY1;
            parameters[12].Value = model.C_BY2;
            parameters[13].Value = model.C_BY3;
            parameters[14].Value = model.C_RH;
            parameters[15].Value = model.C_DFP_HL;
            parameters[16].Value = model.C_HL;
            parameters[17].Value = model.C_XM;
            parameters[18].Value = model.N_ORDER_LS;
            parameters[19].Value = model.D_DFPHL_START_TIME;
            parameters[20].Value = model.D_DFPHL_END_TIME;
            parameters[21].Value = model.D_KP_START_TIME;
            parameters[22].Value = model.D_KP_END_TIME;
            parameters[23].Value = model.D_HL_START_TIME;
            parameters[24].Value = model.D_HL_END_TIME;
            parameters[25].Value = model.D_PLAN_KY_TIME;
            parameters[26].Value = model.C_PLAN_ROLL;
            parameters[27].Value = model.D_ZZ_START_TIME;
            parameters[28].Value = model.D_ZZ_END_TIME;
            parameters[29].Value = model.D_XM_START_TIME;
            parameters[30].Value = model.D_XM_END_TIME;
            parameters[31].Value = model.C_STD_CODE;
            parameters[32].Value = model.C_SLAB_TYPE;
            parameters[33].Value = model.C_STL_GRD_TYPE;
            parameters[34].Value = model.C_PROD_NAME;
            parameters[35].Value = model.C_PROD_KIND;
            parameters[36].Value = model.N_DFP_HL_TIME;
            parameters[37].Value = model.N_HL_TIME;
            parameters[38].Value = model.N_XM_TIME;
            parameters[39].Value = model.N_GG;
            parameters[40].Value = model.N_CCM_TIME;
            parameters[41].Value = model.C_TJ_REMARK;
            parameters[42].Value = model.C_TL;
            parameters[43].Value = model.N_RH;
            parameters[44].Value = model.N_TL;
            parameters[45].Value = model.N_GZSL;
            parameters[46].Value = model.C_REMARK;
            parameters[47].Value = model.N_XM;
            parameters[48].Value = model.N_DHL;
            parameters[49].Value = model.N_HL;
            parameters[50].Value = model.N_STATUS;
            parameters[51].Value = model.D_P_START_TIME;
            parameters[52].Value = model.D_P_END_TIME;
            parameters[53].Value = model.N_DFP_RZ;
            parameters[54].Value = model.N_RZP_RZ;
            parameters[55].Value = model.C_RH_SFJS;
            parameters[56].Value = model.C_TZ_REMARK;//C_TZ_REMARK
            parameters[57].Value = model.C_ID;

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
        /// 删除一条数据
        /// </summary>
        public bool Delete(string C_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from TSP_CAST_PLAN ");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)            };
            parameters[0].Value = C_ID;

            int rows = DbHelperOra.ExecuteSql(strSql.ToString(), parameters);
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
        /// 更新浇次计划
        /// </summary>
        /// <param name="C_ID">浇次主键</param>
        /// <param name="num">炉次数量</param>
        /// <returns></returns>
        public bool Update(string C_ID, int num)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TSP_CAST_PLAN set N_ZJCLS= " + num);
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)            };
            parameters[0].Value = C_ID;

            int rows = DbHelperOra.ExecuteSql(strSql.ToString(), parameters);
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
        /// 得到一个对象实体
        /// </summary>
        public Mod_TSP_CAST_PLAN GetModel(string C_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from TSP_CAST_PLAN ");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)            };
            parameters[0].Value = C_ID;

            Mod_TSP_CAST_PLAN model = new Mod_TSP_CAST_PLAN();
            DataSet ds = DbHelperOra.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                return DataRowToModel(ds.Tables[0].Rows[0]);
            }
            else
            {
                return null;
            }
        }
        /// <summary>
        /// 获取下一个浇次计划
        /// </summary>
        /// <param name="C_CCM_ID">连铸机主键</param>
        /// <param name="N_SORT">当前计划排序号</param>
        /// <returns>下一个浇次计划</returns>
        public Mod_TSP_CAST_PLAN GetNextModel(string C_CCM_ID, int N_SORT)
        {
            string sql = @"SELECT T.*  FROM TSP_CAST_PLAN T WHERE T.N_STATUS > 0 and T.C_CCM_ID = '" + C_CCM_ID + "'   AND T.N_SORT > " + N_SORT + " ORDER BY T.N_SORT";
            DataSet ds = DbHelperOra.Query(sql);
            if (ds.Tables[0].Rows.Count > 0)
            {
                return DataRowToModel(ds.Tables[0].Rows[0]);
            }
            else
            {
                return null;
            }
        }


        /// <summary>
        /// 获取下一个浇次计划
        /// </summary>
        /// <param name="C_CCM_ID">连铸机主键</param>
        /// <param name="N_SORT">当前计划排序号</param>
        /// <returns>下一个浇次计划</returns>
        public Mod_TSP_CAST_PLAN GetLastModel(string C_CCM_ID, int N_SORT)
        {
            string sql = @"SELECT T.*  FROM TSP_CAST_PLAN T WHERE   T.N_STATUS <> 0 AND T.C_CCM_ID = '" + C_CCM_ID + "'   AND T.N_SORT < " + N_SORT + " ORDER BY T.N_SORT DESC";
            DataSet ds = DbHelperOra.Query(sql);
            if (ds.Tables[0].Rows.Count > 0)
            {
                return DataRowToModel(ds.Tables[0].Rows[0]);
            }
            else
            {
                return null;
            }
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Mod_TSP_CAST_PLAN DataRowToModel(DataRow row)
        {
            Mod_TSP_CAST_PLAN model = new Mod_TSP_CAST_PLAN();
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
                if (row["C_TZ_REMARK"] != null)
                {
                    model.C_TZ_REMARK = row["C_TZ_REMARK"].ToString();
                }

            }
            return model;
        }


        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string C_CCM_ID, int? N_STATUS, string dt)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * ");
            strSql.Append(" FROM TSP_CAST_PLAN where 1=1 ");
            if (N_STATUS != null)
            {
                strSql.Append("  AND N_STATUS= " + N_STATUS);
            }
            if (C_CCM_ID.Trim() != "")
            {
                strSql.Append("  AND C_CCM_ID='" + C_CCM_ID + "' ");
            }
            if (dt.Trim() != "")
            {
                strSql.Append("  AND  D_P_START_TIME > TO_DATE('" + dt + "', 'yyyy-mm-dd hh24:mi:ss') ");
            }
            strSql.Append("  ORDER BY N_SORT ");
            return DbHelperOra.Query(strSql.ToString());
        }

        ///// <summary>
        ///// 获得数据列表
        ///// </summary>
        //public DataSet GetList(string where)
        //{
        //    StringBuilder strSql = new StringBuilder();
        //    strSql.Append("select * ");
        //    strSql.Append(" FROM TSP_CAST_PLAN where 1=1 ");
        //    if (where != null)
        //    {
        //        strSql.Append("  AND  " + where);
        //    }
            
        //    strSql.Append("  ORDER BY N_SORT ");
        //    return DbHelperOra.Query(strSql.ToString());
        //}


        /// <summary>
        /// 获取未完成的浇次计划
        /// </summary>
        /// <param name="C_CCM_ID">连铸主键</param>
        /// <returns></returns>
        public DataSet GetListWWC(string C_CCM_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * ");
            strSql.Append(" FROM TSP_CAST_PLAN where 1=1 ");


            strSql.Append("  AND N_STATUS IN (0,1,2)");

            if (C_CCM_ID.Trim() != "")
            {
                strSql.Append("  AND C_CCM_ID='" + C_CCM_ID + "' ");
            }
            strSql.Append("  ORDER BY N_SORT ");
            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetListBySort(string C_CCM_ID, int N_SORT)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * ");
            strSql.Append(" FROM TSP_CAST_PLAN where N_SORT> " + N_SORT);
            if (C_CCM_ID.Trim() != "")
            {
                strSql.Append("  AND C_CCM_ID='" + C_CCM_ID + "' ");
            }
            strSql.Append("  ORDER BY N_SORT ");
            return DbHelperOra.Query(strSql.ToString());
        }


        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * ");
            strSql.Append(" FROM TSP_CAST_PLAN t where t.n_status>0 ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" and " + strWhere);
            }
            strSql.Append(" ORDER BY t.c_ccm_id, t.n_sort " );

            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM TSP_CAST_PLAN ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
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
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT * FROM ( ");
            strSql.Append(" SELECT ROW_NUMBER() OVER (");
            if (!string.IsNullOrEmpty(orderby.Trim()))
            {
                strSql.Append("order by T." + orderby);
            }
            else
            {
                strSql.Append("order by T.C_ID desc");
            }
            strSql.Append(")AS Row, T.*  from TSP_CAST_PLAN T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            return DbHelperOra.Query(strSql.ToString());
        }

        /*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			OracleParameter[] parameters = {
					new OracleParameter(":tblName", OracleDbType.Varchar2, 255),
					new OracleParameter(":fldName", OracleDbType.Varchar2, 255),
					new OracleParameter(":PageSize", OracleDbType.Decimal),
					new OracleParameter(":PageIndex", OracleDbType.Decimal),
					new OracleParameter(":IsReCount", OracleDbType.Clob),
					new OracleParameter(":OrderType", OracleDbType.Clob),
					new OracleParameter(":strWhere", OracleDbType.Varchar2,1000),
					};
			parameters[0].Value = "TSP_CAST_PLAN";
			parameters[1].Value = "C_ID";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperOra.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList_Max(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select max(t.n_group) AS GROUP_MAX,max(t.N_SORT) as SORT_MAX ");
            strSql.Append("  from  TSP_CAST_PLAN  t ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where t.c_ccm_id='" + strWhere + "' ");
            }
            return DbHelperOra.Query(strSql.ToString());
        }
        #endregion  BasicMethod
        #region  ExtensionMethod
        /// <summary>
        /// 获取浇次最大序号
        /// </summary>
        public int Max_jc_sort(string strCcm)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select max(N_SORT) FROM TSP_CAST_PLAN where N_STATUS>0 AND C_CCM_ID='" + strCcm + "' ");

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

        /// <summary>
        /// 获取已完成浇次的最大浇次序号
        /// </summary>
        /// <param name="strCcm">连铸机主键</param>
        /// <returns></returns>
        public int Max_jc_sortbywc(string strCcm)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select max(N_SORT) FROM TSP_CAST_PLAN where n_status=3 and C_CCM_ID='" + strCcm + "' ");

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

        /// <summary>
        /// 返回已排浇次计划的最后一条计划
        /// </summary>
        /// <param name="c_ccm">连铸主键</param>
        /// <returns></returns>
        public DataTable GetGGType(string c_ccm)
        {
            string sql = @"SELECT M.C_STL_GRD_TYPE, M.C_PROD_NAME, M.N_SORT
  FROM (SELECT T.C_STL_GRD_TYPE, T.C_PROD_NAME, T.N_SORT
          FROM TSP_CAST_PLAN T
         WHERE T.C_CCM_ID = '" + c_ccm + "' ORDER BY T.N_SORT DESC) M WHERE ROWNUM = 1 ";
            return DbHelperOra.Query(sql).Tables[0];
        }
        /// <summary>
        /// 获取RH炉的使用寿命
        /// </summary>
        /// <returns></returns>
        public int GetRHSM(string c_ccm)
        {
            string sql = @"SELECT SUM(T.N_RH)
  FROM TSP_CAST_PLAN T
 WHERE T.C_CCM_ID = '" + c_ccm + "'   AND T.C_RH = 'Y'   AND T.N_SORT > (SELECT MAX(T.N_SORT)  FROM TSP_CAST_PLAN T  WHERE T.C_CCM_ID = '" + c_ccm + "'                      AND T.C_RH_SFJS = 'Y')";

            object obj = DbHelperOra.GetSingle(sql);
            if (obj == null)
            {
                return 0;
            }
            else
            {
                return Convert.ToInt32(obj);
            }

        }


        /// <summary>
        /// 获取需要下发的浇次信息
        /// </summary>
        /// <param name="c_ccm_id">连铸机主键</param>
        /// <returns></returns>
        public Mod_TSP_CAST_PLAN GetModel_XF(string c_ccm_id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_CCM_ID,C_CCM_CODE,N_GROUP,N_TOTAL_WGT,N_ZJCLS,N_ZJCLZL,N_MLZL,N_SORT,C_STL_GRD,N_PRODUCE_TIME,N_JSCN,C_BY1,C_BY2,C_BY3,C_RH,C_DFP_HL,C_HL,C_XM,N_ORDER_LS,D_DFPHL_START_TIME,D_DFPHL_END_TIME,D_KP_START_TIME,D_KP_END_TIME,D_HL_START_TIME,D_HL_END_TIME,D_PLAN_KY_TIME,C_PLAN_ROLL,D_ZZ_START_TIME,D_ZZ_END_TIME,D_XM_START_TIME,D_XM_END_TIME,C_STD_CODE,C_SLAB_TYPE,C_STL_GRD_TYPE,C_PROD_NAME,C_PROD_KIND,N_DFP_HL_TIME,N_HL_TIME,N_XM_TIME,N_GG,N_CCM_TIME,C_TJ_REMARK,C_TL,N_RH,N_TL,N_GZSL,C_REMARK,N_XM,N_DHL,N_HL,N_STATUS,D_P_START_TIME,D_P_END_TIME,N_DFP_RZ,N_RZP_RZ,C_RH_SFJS,C_TZ_REMARK from(select * from tsp_cast_plan t where t.c_ccm_id = '" + c_ccm_id + "' and t.N_STATUS = 1 order by t.n_sort asc)where rownum = 1 ");

            Mod_TSP_CAST_PLAN model = new Mod_TSP_CAST_PLAN();
            DataSet ds = DbHelperOra.Query(strSql.ToString());
            if (ds.Tables[0].Rows.Count > 0)
            {
                return DataRowToModel(ds.Tables[0].Rows[0]);
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// 获取是最后一条下发调度的浇次
        /// </summary>
        /// <param name="c_ccm_id">连铸机主键</param>
        /// <param name="n_sort">浇次顺序号</param>
        /// <returns></returns>
        public int Get_YXF_Count(string c_ccm_id, int n_sort)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from tsp_cast_plan t where t.c_ccm_id='" + c_ccm_id + "' and t.n_sort>" + n_sort + " and t.N_STATUS>=2");

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

        #endregion  ExtensionMethod


        #region 根据炉次计划更新浇次计划
        /// <summary>
        /// 根据炉次计划更新浇次计划
        /// </summary>
        /// <param name="C_ID">浇次计划主键</param>
        /// <returns>返回影响行</returns>
        public int UpdateJCPlan(string C_ID)
        {
            string sql = @"UPDATE TSP_CAST_PLAN T
   SET (T.D_P_START_TIME,
        T.D_P_END_TIME,
        T.N_ZJCLS,
        T.N_ZJCLZL,
        T.N_TL,
        T.C_TL,
        T.N_RH,
        T.C_RH,
        T.N_XM,
        T.C_XM,
        T.N_DHL,
        T.C_DFP_HL,
        T.N_HL,
        T.C_HL) =
       (SELECT MIN(A.D_P_START_TIME),
               MAX(A.D_P_END_TIME),
               COUNT(1) N_COU,
               SUM(A.N_SLAB_WGT),
              NVL( SUM(CASE
                     WHEN A.C_TL = 'Y' THEN
                      1
                     ELSE
                      0
                   END),0) N_TL,
               CASE
                 WHEN SUM(CASE
                            WHEN A.C_TL = 'Y' THEN
                             1
                            ELSE
                             0
                          END) > 0 THEN
                  'Y'
                 ELSE
                  'N'
               END,
               
              NVL( SUM(CASE
                     WHEN A.C_RH = 'Y' THEN
                      1
                     ELSE
                      0
                   END),0) N_RH,
               CASE
                 WHEN SUM(CASE
                            WHEN A.C_RH = 'Y' THEN
                             1
                            ELSE
                             0
                          END) > 0 THEN
                  'Y'
                 ELSE
                  'N'
               END,
              NVL( SUM(CASE
                     WHEN A.C_XM = 'Y' THEN
                      1
                     ELSE
                      0
                   END),0) N_XM,
               
               CASE
                 WHEN SUM(CASE
                            WHEN A.C_XM = 'Y' THEN
                             1
                            ELSE
                             0
                          END) > 0 THEN
                  'Y'
                 ELSE
                  'N'
               END,
              NVL( SUM(CASE
                     WHEN A.C_DFP_HL = 'Y' THEN
                      1
                     ELSE
                      0
                   END),0) N_DHL,
               CASE
                 WHEN SUM(CASE
                            WHEN A.C_DFP_HL = 'Y' THEN
                             1
                            ELSE
                             0
                          END) > 0 THEN
                  'Y'
                 ELSE
                  'N'
               END,
              NVL( SUM(CASE
                     WHEN A.C_HL = 'Y' THEN
                      1
                     ELSE
                      0
                   END),0) N_HL,
               CASE
                 WHEN SUM(CASE
                            WHEN A.C_HL = 'Y' THEN
                             1
                            ELSE
                             0
                          END) > 0 THEN
                  'Y'
                 ELSE
                  'N'
               END
          FROM TSP_PLAN_SMS A
         WHERE A.C_FK = T.C_ID) WHERE T.C_ID='" + C_ID + "'";

            return DbHelperOra.ExecuteSql(sql);

        }


        #endregion


        /// <summary>
        /// 返回上一各浇次的主键
        /// </summary>
        /// <param name="c_ccm_id">连铸机</param>
        /// <param name="n_group"></param>
        /// <returns></returns>
        public string GetLastJCPlan(string c_ccm_id, int n_group)
        {
            string sql = @"SELECT N_SORT, C_ID  FROM(SELECT T.N_SORT, T.C_ID FROM TSP_CAST_PLAN T WHERE T.C_CCM_ID = '" + c_ccm_id + "'  AND T.N_SORT <" + n_group + "  ORDER BY T.N_SORT DESC) WHERE ROWNUM = 1";
            return DbHelperOra.Query(sql).Tables[0].Rows[0]["C_ID"].ToString();

        }
        /// <summary>
        /// 查询非计划浇次
        /// </summary>
        /// <param name="C_CCM_ID">连铸机主键</param>
        /// <param name="d_dt1">开始时间</param>
        /// <param name="d_dt2">结束时间</param>
        /// <returns></returns>
        public DataTable GetStopPlan(string C_CCM_ID, string d_dt1, string d_dt2)
        {
            string sql = @"SELECT (SELECT TB.C_STA_DESC FROM TB_STA TB WHERE TB.C_ID = T.C_CCM_ID) 连铸机,
       T.C_TZ_REMARK 原因,
       T.C_REMARK 牌号,
      T.D_PLAN_KY_TIME 终止计划时间
  FROM TSP_CAST_PLAN T
 WHERE T.C_TZ_REMARK IS NOT NULL ";
            if (C_CCM_ID.Trim() != "")
            {
                sql = sql + " AND T.C_CCM_ID = '" + C_CCM_ID + "'";
            }
            if (d_dt1.Trim() != "")
            {
                sql = sql + " AND T.D_PLAN_KY_TIME >= TO_DATE('" + d_dt1 + "', 'yyyy-mm-dd hh24:mi:ss')";
            }
            if (d_dt2.Trim() != "")
            {
                sql = sql + " AND T.D_PLAN_KY_TIME <= TO_DATE('" + d_dt2 + "', 'yyyy-mm-dd hh24:mi:ss')";
            }

            sql = sql + "  ORDER BY T.D_P_START_TIME";
            return DbHelperOra.Query(sql).Tables[0];
        }


        /// <summary>
        /// 炼钢计划存档日志
        /// </summary> 
        /// <returns></returns>
        public string P_CD_LOG(string P_IP, string P_OPER_CONTEXT, string P_EMP_ID, string P_CCM_ID, string P_TYPE)
        {
            OracleParameter[] parameters = {
            new OracleParameter("P_MSG", OracleDbType.Varchar2,200),
             new OracleParameter("P_IP", OracleDbType.Varchar2,300),
             new OracleParameter("P_OPER_CONTEXT", OracleDbType.Varchar2,400),
             new OracleParameter("P_EMP_ID", OracleDbType.Varchar2,400),
             new OracleParameter("P_CCM_ID", OracleDbType.Varchar2,400),
             new OracleParameter("P_TYPE", OracleDbType.Varchar2,400)};

            parameters[0].Value = "000000-000000";
            parameters[1].Value = P_IP;
            parameters[2].Value = P_OPER_CONTEXT;
            parameters[3].Value = P_EMP_ID;
            parameters[4].Value = P_CCM_ID;
            parameters[5].Value = P_TYPE;
            return DbHelperOra.RunProcedureOut("PKG_LG_JCJH.P_CD_LOG", parameters);
        }


        /// <summary>
        /// 炼钢计划存档
        /// </summary> 
        /// <returns></returns>
        public string P_LG_PLAN_CD(string C_CD_NO, string C_CD_TYPE, string C_LOG_EMP)
        {
            OracleParameter[] parameters = {
            new OracleParameter("P_MSG", OracleDbType.Varchar2,100),
             new OracleParameter("C_CD_NO", OracleDbType.Varchar2,100),
             new OracleParameter("C_CD_TYPE", OracleDbType.Varchar2,100),
             new OracleParameter("C_LOG_EMP", OracleDbType.Varchar2,100)};

            parameters[0].Value = "0";
            parameters[1].Value = C_CD_NO;
            parameters[2].Value = C_CD_TYPE;
            parameters[3].Value = C_LOG_EMP;
            return DbHelperOra.RunProcedureOut("PKG_LG_JCJH.P_JCJH_CD", parameters);
        }

        /// <summary>
        /// 记录炼钢浇次计划调整原因
        /// </summary>
        /// <param name="P_FK">浇次计划主键（终止计划时不能为空）</param>
        /// <param name="P_OPER_CONTEXT">详细说明</param>
        /// <param name="P_EMP_ID">操作人员</param>
        /// <param name="P_CCM_ID">操作时连铸主键</param>
        /// <param name="P_TYPE">类型：计划调整、终止计划</param>
        /// <param name="P_REASON">原因</param>
        /// <returns></returns>
        public string P_LG_PLAN_REMARK(string P_FK, string P_OPER_CONTEXT, string P_EMP_ID, string P_CCM_ID, string P_TYPE, string P_REASON)
        {

            string sql = "  INSERT INTO TSP_CAST_REMARK      (C_FK, C_OPER_CONTEXT, C_EMP_ID, C_CCM_ID, C_TYPE, C_REASON)    VALUES      ('" + P_FK + "', '" + P_OPER_CONTEXT + "','" + P_EMP_ID + "' ,'" + P_CCM_ID + "' ,'" + P_TYPE + "' ,'" + P_REASON + "' )";
            return DbHelperOra.ExecuteSql(sql).ToString();
            
        }

        /// <summary>
        /// 查看终止计划原因和说明
        /// </summary>
        /// <param name="C_CCM_ID">连铸机主键</param>
        /// <param name="d_dt_b">操作开始时间</param>
        /// <param name="d_dt_e">操作结束时间</param>
        /// <returns></returns>
        public DataTable GetZZPlan(string C_CCM_ID, string d_dt_b, string d_dt_e)
        {
            string sql = @"SELECT TB.N_SORT         浇次序号,
       TB.C_REMARK 牌号,
       TB.C_CCM_CODE 连铸机,
       T.C_REASON 原因,
       T.C_OPER_CONTEXT 详细说明,
       TO_CHAR(T.D_MOD_DT, 'yyyy-mm-dd hh24:mi:ss') 操作时间,
       T.C_EMP_ID 操作人,
       TB.D_P_START_TIME 浇次开始时间,
       TB.D_P_END_TIME 浇次结束时间
  FROM TSP_CAST_REMARK T
  LEFT JOIN TSP_CAST_PLAN TB
    ON T.C_FK = TB.C_ID
 WHERE T.C_TYPE = '终止计划'";
            if (C_CCM_ID.Trim() != "")
            {
                sql = sql + "  AND T.C_CCM_ID = '" + C_CCM_ID + "'";
            }
            if (d_dt_b.Trim() != "")
            {
                sql = sql + "  AND T.D_MOD_DT >=       TO_DATE('" + d_dt_b + "', 'yyyy-mm-dd hh24:mi:ss') ";
            }
            if (d_dt_e.Trim() != "")
            {
                sql = sql + "  AND T.D_MOD_DT <=       TO_DATE('" + d_dt_e + "', 'yyyy-mm-dd hh24:mi:ss')";
            }
            sql = sql + "  ORDER BY TB.N_SORT";

            return DbHelperOra.Query(sql).Tables[0];
        }

        /// <summary>
        /// 查看终止计划原因和说明
        /// </summary>
        /// <param name="C_CCM_ID">连铸机主键</param>
        /// <param name="d_dt_b">操作开始时间</param>
        /// <param name="d_dt_e">操作结束时间</param>
        /// <returns></returns>
        public DataTable GetTZPlan(string C_CCM_ID, string d_dt_b, string d_dt_e)
        {
            string sql = @"SELECT T.C_REASON 原因,
       T.C_OPER_CONTEXT 详细说明,
       TB.C_STA_DESC 连铸机,
       T.C_EMP_ID 操作人,
       TO_CHAR(T.D_MOD_DT, 'yyyy-mm-dd hh24:mi:ss') 操作时间
  FROM TSP_CAST_REMARK T
  LEFT JOIN TB_STA TB
    ON T.C_CCM_ID = TB.C_ID
 WHERE T.C_TYPE = '计划调整'";
            if (C_CCM_ID.Trim() != "")
            {
                sql = sql + "  AND T.C_CCM_ID = '" + C_CCM_ID + "'";
            }
            if (d_dt_b.Trim() != "")
            {
                sql = sql + "  AND T.D_MOD_DT >=       TO_DATE('" + d_dt_b + "', 'yyyy-mm-dd hh24:mi:ss') ";
            }
            if (d_dt_e.Trim() != "")
            {
                sql = sql + "  AND T.D_MOD_DT <=       TO_DATE('" + d_dt_e + "', 'yyyy-mm-dd hh24:mi:ss')";
            }
            sql = sql + "  ORDER BY T.D_MOD_DT";
            return DbHelperOra.Query(sql).Tables[0];
        }

    }
}

