using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;
namespace DAL
{
    /// <summary>
    /// 数据访问类:TRP_PLAN_ROLL
    /// </summary>
    public partial class Dal_TRP_PLAN_ROLL
    {
        public Dal_TRP_PLAN_ROLL()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string C_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TRP_PLAN_ROLL");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)            };
            parameters[0].Value = C_ID;

            return DbHelperOra.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Mod_TRP_PLAN_ROLL model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TRP_PLAN_ROLL(");
            strSql.Append("C_ID,N_STATUS,C_INITIALIZE_ITEM_ID,C_ORDER_NO,N_WGT,C_MAT_CODE,C_MAT_NAME,C_TECH_PROT,C_SPEC,C_STL_GRD,C_STD_CODE,N_USER_LEV,N_STL_GRD_LEV,N_ORDER_LEV,C_QUALIRY_LEV,D_NEED_DT,D_DELIVERY_DT,D_DT,C_LINE_DESC,C_LINE_CODE,D_P_START_TIME,D_P_END_TIME,N_PROD_TIME,N_SORT,N_ROLL_PROD_WGT,C_ROLL_PROD_EMP_ID,C_STL_ROL_DT,N_PROD_WGT,N_WARE_WGT,N_WARE_OUT_WGT,N_FLAG,N_ISSUE_WGT,C_CUST_NO,C_CUST_NAME,C_SALE_CHANNEL,C_PACK,C_DESIGN_NO,N_GROUP_WGT,C_STA_ID,D_START_TIME,D_END_TIME,C_EMP_ID,D_MOD_DT,N_ROLL_WGT,N_MACH_WGT,C_CAST_NO,C_INITIALIZE_ID,C_FREE_TERM,C_FREE_TERM2,C_AREA,C_PCLX,C_SFHL,D_HL_START_TIME,D_HL_END_TIME,C_SFHL_D,D_DHL_START_TIME,D_DHL_END_TIME,C_SFKP,D_KP_START_TIME,D_KP_END_TIME,C_SFXM,D_XM_START_TIME,D_XM_END_TIME,N_UPLOADSTATUS,C_MATRL_CODE_SLAB,C_MATRL_NAME_SLAB,C_SLAB_SIZE,N_SLAB_LENGTH,N_SLAB_PW,D_CAN_ROLL_TIME,C_ROUTE,N_DIAMETER,C_XM_YQ,N_JRL_WD,N_JRL_SJ,C_STL_GRD_SLAB,C_STD_CODE_SLAB,C_MATRL_CODE_KP,C_MATRL_NAME_KP,C_KP_SIZE,N_KP_LENGTH,N_KP_PW,N_GROUP,C_XC,C_SL,C_WL,N_MACH_WGT_CCM,N_ZJCLS,C_BY1,C_BY2,C_BY3,C_BY4,C_BY5,C_LGJH,C_ZL_ID,C_LF_ID,C_RH_ID,N_SLAB_WIDTH,N_SLAB_THICK,C_DFP_RZ,C_RZP_RZ,C_DFP_YQ,C_RZP_YQ,N_KPJRL_WD,N_KPJRL_SJ,N_TSL,C_CCM_CODE,C_CCM_DESC,C_TL,N_ZJCLS_MIN,N_ZJCLS_MAX,C_STL_GRD_TYPE,C_PROD_NAME,C_PROD_KIND,N_TYPE,C_RH,C_DFP_HL,C_HL,C_XM,C_CCM_ID,N_HL_TIME,N_DFP_HL_TIME,C_LF,C_KP,C_STL_GRD_CLASS,C_PRO_USE,C_CUST_SQ,C_TRANSMODE,C_REMARK1,C_REMARK2,C_REMARK3,C_REMARK4,C_REMARK5)");
            strSql.Append(" values (");
            strSql.Append(":C_ID,:N_STATUS,:C_INITIALIZE_ITEM_ID,:C_ORDER_NO,:N_WGT,:C_MAT_CODE,:C_MAT_NAME,:C_TECH_PROT,:C_SPEC,:C_STL_GRD,:C_STD_CODE,:N_USER_LEV,:N_STL_GRD_LEV,:N_ORDER_LEV,:C_QUALIRY_LEV,:D_NEED_DT,:D_DELIVERY_DT,:D_DT,:C_LINE_DESC,:C_LINE_CODE,:D_P_START_TIME,:D_P_END_TIME,:N_PROD_TIME,:N_SORT,:N_ROLL_PROD_WGT,:C_ROLL_PROD_EMP_ID,:C_STL_ROL_DT,:N_PROD_WGT,:N_WARE_WGT,:N_WARE_OUT_WGT,:N_FLAG,:N_ISSUE_WGT,:C_CUST_NO,:C_CUST_NAME,:C_SALE_CHANNEL,:C_PACK,:C_DESIGN_NO,:N_GROUP_WGT,:C_STA_ID,:D_START_TIME,:D_END_TIME,:C_EMP_ID,:D_MOD_DT,:N_ROLL_WGT,:N_MACH_WGT,:C_CAST_NO,:C_INITIALIZE_ID,:C_FREE_TERM,:C_FREE_TERM2,:C_AREA,:C_PCLX,:C_SFHL,:D_HL_START_TIME,:D_HL_END_TIME,:C_SFHL_D,:D_DHL_START_TIME,:D_DHL_END_TIME,:C_SFKP,:D_KP_START_TIME,:D_KP_END_TIME,:C_SFXM,:D_XM_START_TIME,:D_XM_END_TIME,:N_UPLOADSTATUS,:C_MATRL_CODE_SLAB,:C_MATRL_NAME_SLAB,:C_SLAB_SIZE,:N_SLAB_LENGTH,:N_SLAB_PW,:D_CAN_ROLL_TIME,:C_ROUTE,:N_DIAMETER,:C_XM_YQ,:N_JRL_WD,:N_JRL_SJ,:C_STL_GRD_SLAB,:C_STD_CODE_SLAB,:C_MATRL_CODE_KP,:C_MATRL_NAME_KP,:C_KP_SIZE,:N_KP_LENGTH,:N_KP_PW,:N_GROUP,:C_XC,:C_SL,:C_WL,:N_MACH_WGT_CCM,:N_ZJCLS,:C_BY1,:C_BY2,:C_BY3,:C_BY4,:C_BY5,:C_LGJH,:C_ZL_ID,:C_LF_ID,:C_RH_ID,:N_SLAB_WIDTH,:N_SLAB_THICK,:C_DFP_RZ,:C_RZP_RZ,:C_DFP_YQ,:C_RZP_YQ,:N_KPJRL_WD,:N_KPJRL_SJ,:N_TSL,:C_CCM_CODE,:C_CCM_DESC,:C_TL,:N_ZJCLS_MIN,:N_ZJCLS_MAX,:C_STL_GRD_TYPE,:C_PROD_NAME,:C_PROD_KIND,:N_TYPE,:C_RH,:C_DFP_HL,:C_HL,:C_XM,:C_CCM_ID,:N_HL_TIME,:N_DFP_HL_TIME,:C_LF,:C_KP,:C_STL_GRD_CLASS,:C_PRO_USE,:C_CUST_SQ,:C_TRANSMODE,:C_REMARK1,:C_REMARK2,:C_REMARK3,:C_REMARK4,:C_REMARK5)");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
                    new OracleParameter(":C_INITIALIZE_ITEM_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ORDER_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":C_MAT_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MAT_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_TECH_PROT", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SPEC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STL_GRD", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STD_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_USER_LEV", OracleDbType.Decimal,5),
                    new OracleParameter(":N_STL_GRD_LEV", OracleDbType.Decimal,5),
                    new OracleParameter(":N_ORDER_LEV", OracleDbType.Decimal,5),
                    new OracleParameter(":C_QUALIRY_LEV", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_NEED_DT", OracleDbType.Date),
                    new OracleParameter(":D_DELIVERY_DT", OracleDbType.Date),
                    new OracleParameter(":D_DT", OracleDbType.Date),
                    new OracleParameter(":C_LINE_DESC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_LINE_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_P_START_TIME", OracleDbType.Date),
                    new OracleParameter(":D_P_END_TIME", OracleDbType.Date),
                    new OracleParameter(":N_PROD_TIME", OracleDbType.Decimal,5),
                    new OracleParameter(":N_SORT", OracleDbType.Decimal,4),
                    new OracleParameter(":N_ROLL_PROD_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":C_ROLL_PROD_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STL_ROL_DT", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_PROD_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":N_WARE_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":N_WARE_OUT_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":N_FLAG", OracleDbType.Decimal,5),
                    new OracleParameter(":N_ISSUE_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":C_CUST_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CUST_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SALE_CHANNEL", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PACK", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_DESIGN_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_GROUP_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":C_STA_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_START_TIME", OracleDbType.Date),
                    new OracleParameter(":D_END_TIME", OracleDbType.Date),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":N_ROLL_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":N_MACH_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":C_CAST_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_INITIALIZE_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_FREE_TERM", OracleDbType.Varchar2,300),
                    new OracleParameter(":C_FREE_TERM2", OracleDbType.Varchar2,300),
                    new OracleParameter(":C_AREA", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PCLX", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_SFHL", OracleDbType.Varchar2,10),
                    new OracleParameter(":D_HL_START_TIME", OracleDbType.Date),
                    new OracleParameter(":D_HL_END_TIME", OracleDbType.Date),
                    new OracleParameter(":C_SFHL_D", OracleDbType.Varchar2,10),
                    new OracleParameter(":D_DHL_START_TIME", OracleDbType.Date),
                    new OracleParameter(":D_DHL_END_TIME", OracleDbType.Date),
                    new OracleParameter(":C_SFKP", OracleDbType.Varchar2,10),
                    new OracleParameter(":D_KP_START_TIME", OracleDbType.Date),
                    new OracleParameter(":D_KP_END_TIME", OracleDbType.Date),
                    new OracleParameter(":C_SFXM", OracleDbType.Varchar2,10),
                    new OracleParameter(":D_XM_START_TIME", OracleDbType.Date),
                    new OracleParameter(":D_XM_END_TIME", OracleDbType.Date),
                    new OracleParameter(":N_UPLOADSTATUS", OracleDbType.Decimal,1),
                    new OracleParameter(":C_MATRL_CODE_SLAB", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MATRL_NAME_SLAB", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SLAB_SIZE", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_SLAB_LENGTH", OracleDbType.Decimal,15),
                    new OracleParameter(":N_SLAB_PW", OracleDbType.Decimal,15),
                    new OracleParameter(":D_CAN_ROLL_TIME", OracleDbType.Date),
                    new OracleParameter(":C_ROUTE", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_DIAMETER", OracleDbType.Decimal,4),
                    new OracleParameter(":C_XM_YQ", OracleDbType.Varchar2,1000),
                    new OracleParameter(":N_JRL_WD", OracleDbType.Decimal,10),
                    new OracleParameter(":N_JRL_SJ", OracleDbType.Decimal,10),
                    new OracleParameter(":C_STL_GRD_SLAB", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STD_CODE_SLAB", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MATRL_CODE_KP", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MATRL_NAME_KP", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_KP_SIZE", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_KP_LENGTH", OracleDbType.Decimal,15),
                    new OracleParameter(":N_KP_PW", OracleDbType.Decimal,15),
                    new OracleParameter(":N_GROUP", OracleDbType.Decimal,4),
                    new OracleParameter(":C_XC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SL", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_WL", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_MACH_WGT_CCM", OracleDbType.Decimal,15),
                    new OracleParameter(":N_ZJCLS", OracleDbType.Decimal,4),
                    new OracleParameter(":C_BY1", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_BY2", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_BY3", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_BY4", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_BY5", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_LGJH", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ZL_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_LF_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_RH_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_SLAB_WIDTH", OracleDbType.Decimal,4),
                    new OracleParameter(":N_SLAB_THICK", OracleDbType.Decimal,4),
                    new OracleParameter(":C_DFP_RZ", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_RZP_RZ", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_DFP_YQ", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_RZP_YQ", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_KPJRL_WD", OracleDbType.Decimal,10),
                    new OracleParameter(":N_KPJRL_SJ", OracleDbType.Decimal,10),
                    new OracleParameter(":N_TSL", OracleDbType.Decimal,10),
                    new OracleParameter(":C_CCM_CODE", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_CCM_DESC", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_TL", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_ZJCLS_MIN", OracleDbType.Decimal,4),
                    new OracleParameter(":N_ZJCLS_MAX", OracleDbType.Decimal,4),
                    new OracleParameter(":C_STL_GRD_TYPE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PROD_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PROD_KIND", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_TYPE", OracleDbType.Decimal,15),
                    new OracleParameter(":C_RH", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_DFP_HL", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_HL", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_XM", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CCM_ID", OracleDbType.Varchar2,500),
                    new OracleParameter(":N_HL_TIME", OracleDbType.Decimal,10),
                    new OracleParameter(":N_DFP_HL_TIME", OracleDbType.Decimal,10),
                    new OracleParameter(":C_LF", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_KP", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STL_GRD_CLASS", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PRO_USE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CUST_SQ", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_TRANSMODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_REMARK1", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_REMARK2", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_REMARK3", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_REMARK4", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_REMARK5", OracleDbType.Varchar2,500)};
            parameters[0].Value = model.C_ID;
            parameters[1].Value = model.N_STATUS;
            parameters[2].Value = model.C_INITIALIZE_ITEM_ID;
            parameters[3].Value = model.C_ORDER_NO;
            parameters[4].Value = model.N_WGT;
            parameters[5].Value = model.C_MAT_CODE;
            parameters[6].Value = model.C_MAT_NAME;
            parameters[7].Value = model.C_TECH_PROT;
            parameters[8].Value = model.C_SPEC;
            parameters[9].Value = model.C_STL_GRD;
            parameters[10].Value = model.C_STD_CODE;
            parameters[11].Value = model.N_USER_LEV;
            parameters[12].Value = model.N_STL_GRD_LEV;
            parameters[13].Value = model.N_ORDER_LEV;
            parameters[14].Value = model.C_QUALIRY_LEV;
            parameters[15].Value = model.D_NEED_DT;
            parameters[16].Value = model.D_DELIVERY_DT;
            parameters[17].Value = model.D_DT;
            parameters[18].Value = model.C_LINE_DESC;
            parameters[19].Value = model.C_LINE_CODE;
            parameters[20].Value = model.D_P_START_TIME;
            parameters[21].Value = model.D_P_END_TIME;
            parameters[22].Value = model.N_PROD_TIME;
            parameters[23].Value = model.N_SORT;
            parameters[24].Value = model.N_ROLL_PROD_WGT;
            parameters[25].Value = model.C_ROLL_PROD_EMP_ID;
            parameters[26].Value = model.C_STL_ROL_DT;
            parameters[27].Value = model.N_PROD_WGT;
            parameters[28].Value = model.N_WARE_WGT;
            parameters[29].Value = model.N_WARE_OUT_WGT;
            parameters[30].Value = model.N_FLAG;
            parameters[31].Value = model.N_ISSUE_WGT;
            parameters[32].Value = model.C_CUST_NO;
            parameters[33].Value = model.C_CUST_NAME;
            parameters[34].Value = model.C_SALE_CHANNEL;
            parameters[35].Value = model.C_PACK;
            parameters[36].Value = model.C_DESIGN_NO;
            parameters[37].Value = model.N_GROUP_WGT;
            parameters[38].Value = model.C_STA_ID;
            parameters[39].Value = model.D_START_TIME;
            parameters[40].Value = model.D_END_TIME;
            parameters[41].Value = model.C_EMP_ID;
            parameters[42].Value = model.D_MOD_DT;
            parameters[43].Value = model.N_ROLL_WGT;
            parameters[44].Value = model.N_MACH_WGT;
            parameters[45].Value = model.C_CAST_NO;
            parameters[46].Value = model.C_INITIALIZE_ID;
            parameters[47].Value = model.C_FREE_TERM;
            parameters[48].Value = model.C_FREE_TERM2;
            parameters[49].Value = model.C_AREA;
            parameters[50].Value = model.C_PCLX;
            parameters[51].Value = model.C_SFHL;
            parameters[52].Value = model.D_HL_START_TIME;
            parameters[53].Value = model.D_HL_END_TIME;
            parameters[54].Value = model.C_SFHL_D;
            parameters[55].Value = model.D_DHL_START_TIME;
            parameters[56].Value = model.D_DHL_END_TIME;
            parameters[57].Value = model.C_SFKP;
            parameters[58].Value = model.D_KP_START_TIME;
            parameters[59].Value = model.D_KP_END_TIME;
            parameters[60].Value = model.C_SFXM;
            parameters[61].Value = model.D_XM_START_TIME;
            parameters[62].Value = model.D_XM_END_TIME;
            parameters[63].Value = model.N_UPLOADSTATUS;
            parameters[64].Value = model.C_MATRL_CODE_SLAB;
            parameters[65].Value = model.C_MATRL_NAME_SLAB;
            parameters[66].Value = model.C_SLAB_SIZE;
            parameters[67].Value = model.N_SLAB_LENGTH;
            parameters[68].Value = model.N_SLAB_PW;
            parameters[69].Value = model.D_CAN_ROLL_TIME;
            parameters[70].Value = model.C_ROUTE;
            parameters[71].Value = model.N_DIAMETER;
            parameters[72].Value = model.C_XM_YQ;
            parameters[73].Value = model.N_JRL_WD;
            parameters[74].Value = model.N_JRL_SJ;
            parameters[75].Value = model.C_STL_GRD_SLAB;
            parameters[76].Value = model.C_STD_CODE_SLAB;
            parameters[77].Value = model.C_MATRL_CODE_KP;
            parameters[78].Value = model.C_MATRL_NAME_KP;
            parameters[79].Value = model.C_KP_SIZE;
            parameters[80].Value = model.N_KP_LENGTH;
            parameters[81].Value = model.N_KP_PW;
            parameters[82].Value = model.N_GROUP;
            parameters[83].Value = model.C_XC;
            parameters[84].Value = model.C_SL;
            parameters[85].Value = model.C_WL;
            parameters[86].Value = model.N_MACH_WGT_CCM;
            parameters[87].Value = model.N_ZJCLS;
            parameters[88].Value = model.C_BY1;
            parameters[89].Value = model.C_BY2;
            parameters[90].Value = model.C_BY3;
            parameters[91].Value = model.C_BY4;
            parameters[92].Value = model.C_BY5;
            parameters[93].Value = model.C_LGJH;
            parameters[94].Value = model.C_ZL_ID;
            parameters[95].Value = model.C_LF_ID;
            parameters[96].Value = model.C_RH_ID;
            parameters[97].Value = model.N_SLAB_WIDTH;
            parameters[98].Value = model.N_SLAB_THICK;
            parameters[99].Value = model.C_DFP_RZ;
            parameters[100].Value = model.C_RZP_RZ;
            parameters[101].Value = model.C_DFP_YQ;
            parameters[102].Value = model.C_RZP_YQ;
            parameters[103].Value = model.N_KPJRL_WD;
            parameters[104].Value = model.N_KPJRL_SJ;
            parameters[105].Value = model.N_TSL;
            parameters[106].Value = model.C_CCM_CODE;
            parameters[107].Value = model.C_CCM_DESC;
            parameters[108].Value = model.C_TL;
            parameters[109].Value = model.N_ZJCLS_MIN;
            parameters[110].Value = model.N_ZJCLS_MAX;
            parameters[111].Value = model.C_STL_GRD_TYPE;
            parameters[112].Value = model.C_PROD_NAME;
            parameters[113].Value = model.C_PROD_KIND;
            parameters[114].Value = model.N_TYPE;
            parameters[115].Value = model.C_RH;
            parameters[116].Value = model.C_DFP_HL;
            parameters[117].Value = model.C_HL;
            parameters[118].Value = model.C_XM;
            parameters[119].Value = model.C_CCM_ID;
            parameters[120].Value = model.N_HL_TIME;
            parameters[121].Value = model.N_DFP_HL_TIME;
            parameters[122].Value = model.C_LF;
            parameters[123].Value = model.C_KP;
            parameters[124].Value = model.C_STL_GRD_CLASS;
            parameters[125].Value = model.C_PRO_USE;
            parameters[126].Value = model.C_CUST_SQ;
            parameters[127].Value = model.C_TRANSMODE;
            parameters[128].Value = model.C_REMARK1;
            parameters[129].Value = model.C_REMARK2;
            parameters[130].Value = model.C_REMARK3;
            parameters[131].Value = model.C_REMARK4;
            parameters[132].Value = model.C_REMARK5;

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
        public bool Update(Mod_TRP_PLAN_ROLL model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TRP_PLAN_ROLL set ");
            strSql.Append("N_STATUS=:N_STATUS,");
            strSql.Append("C_INITIALIZE_ITEM_ID=:C_INITIALIZE_ITEM_ID,");
            strSql.Append("C_ORDER_NO=:C_ORDER_NO,");
            strSql.Append("N_WGT=:N_WGT,");
            strSql.Append("C_MAT_CODE=:C_MAT_CODE,");
            strSql.Append("C_MAT_NAME=:C_MAT_NAME,");
            strSql.Append("C_TECH_PROT=:C_TECH_PROT,");
            strSql.Append("C_SPEC=:C_SPEC,");
            strSql.Append("C_STL_GRD=:C_STL_GRD,");
            strSql.Append("C_STD_CODE=:C_STD_CODE,");
            strSql.Append("N_USER_LEV=:N_USER_LEV,");
            strSql.Append("N_STL_GRD_LEV=:N_STL_GRD_LEV,");
            strSql.Append("N_ORDER_LEV=:N_ORDER_LEV,");
            strSql.Append("C_QUALIRY_LEV=:C_QUALIRY_LEV,");
            strSql.Append("D_NEED_DT=:D_NEED_DT,");
            strSql.Append("D_DELIVERY_DT=:D_DELIVERY_DT,");
            strSql.Append("D_DT=:D_DT,");
            strSql.Append("C_LINE_DESC=:C_LINE_DESC,");
            strSql.Append("C_LINE_CODE=:C_LINE_CODE,");
            strSql.Append("D_P_START_TIME=:D_P_START_TIME,");
            strSql.Append("D_P_END_TIME=:D_P_END_TIME,");
            strSql.Append("N_PROD_TIME=:N_PROD_TIME,");
            strSql.Append("N_SORT=:N_SORT,");
            strSql.Append("N_ROLL_PROD_WGT=:N_ROLL_PROD_WGT,");
            strSql.Append("C_ROLL_PROD_EMP_ID=:C_ROLL_PROD_EMP_ID,");
            strSql.Append("C_STL_ROL_DT=:C_STL_ROL_DT,");
            strSql.Append("N_PROD_WGT=:N_PROD_WGT,");
            strSql.Append("N_WARE_WGT=:N_WARE_WGT,");
            strSql.Append("N_WARE_OUT_WGT=:N_WARE_OUT_WGT,");
            strSql.Append("N_FLAG=:N_FLAG,");
            strSql.Append("N_ISSUE_WGT=:N_ISSUE_WGT,");
            strSql.Append("C_CUST_NO=:C_CUST_NO,");
            strSql.Append("C_CUST_NAME=:C_CUST_NAME,");
            strSql.Append("C_SALE_CHANNEL=:C_SALE_CHANNEL,");
            strSql.Append("C_PACK=:C_PACK,");
            strSql.Append("C_DESIGN_NO=:C_DESIGN_NO,");
            strSql.Append("N_GROUP_WGT=:N_GROUP_WGT,");
            strSql.Append("C_STA_ID=:C_STA_ID,");
            strSql.Append("D_START_TIME=:D_START_TIME,");
            strSql.Append("D_END_TIME=:D_END_TIME,");
            strSql.Append("C_EMP_ID=:C_EMP_ID,");
            strSql.Append("D_MOD_DT=:D_MOD_DT,");
            strSql.Append("N_ROLL_WGT=:N_ROLL_WGT,");
            strSql.Append("N_MACH_WGT=:N_MACH_WGT,");
            strSql.Append("C_CAST_NO=:C_CAST_NO,");
            strSql.Append("C_INITIALIZE_ID=:C_INITIALIZE_ID,");
            strSql.Append("C_FREE_TERM=:C_FREE_TERM,");
            strSql.Append("C_FREE_TERM2=:C_FREE_TERM2,");
            strSql.Append("C_AREA=:C_AREA,");
            strSql.Append("C_PCLX=:C_PCLX,");
            strSql.Append("C_SFHL=:C_SFHL,");
            strSql.Append("D_HL_START_TIME=:D_HL_START_TIME,");
            strSql.Append("D_HL_END_TIME=:D_HL_END_TIME,");
            strSql.Append("C_SFHL_D=:C_SFHL_D,");
            strSql.Append("D_DHL_START_TIME=:D_DHL_START_TIME,");
            strSql.Append("D_DHL_END_TIME=:D_DHL_END_TIME,");
            strSql.Append("C_SFKP=:C_SFKP,");
            strSql.Append("D_KP_START_TIME=:D_KP_START_TIME,");
            strSql.Append("D_KP_END_TIME=:D_KP_END_TIME,");
            strSql.Append("C_SFXM=:C_SFXM,");
            strSql.Append("D_XM_START_TIME=:D_XM_START_TIME,");
            strSql.Append("D_XM_END_TIME=:D_XM_END_TIME,");
            strSql.Append("N_UPLOADSTATUS=:N_UPLOADSTATUS,");
            strSql.Append("C_MATRL_CODE_SLAB=:C_MATRL_CODE_SLAB,");
            strSql.Append("C_MATRL_NAME_SLAB=:C_MATRL_NAME_SLAB,");
            strSql.Append("C_SLAB_SIZE=:C_SLAB_SIZE,");
            strSql.Append("N_SLAB_LENGTH=:N_SLAB_LENGTH,");
            strSql.Append("N_SLAB_PW=:N_SLAB_PW,");
            strSql.Append("D_CAN_ROLL_TIME=:D_CAN_ROLL_TIME,");
            strSql.Append("C_ROUTE=:C_ROUTE,");
            strSql.Append("N_DIAMETER=:N_DIAMETER,");
            strSql.Append("C_XM_YQ=:C_XM_YQ,");
            strSql.Append("N_JRL_WD=:N_JRL_WD,");
            strSql.Append("N_JRL_SJ=:N_JRL_SJ,");
            strSql.Append("C_STL_GRD_SLAB=:C_STL_GRD_SLAB,");
            strSql.Append("C_STD_CODE_SLAB=:C_STD_CODE_SLAB,");
            strSql.Append("C_MATRL_CODE_KP=:C_MATRL_CODE_KP,");
            strSql.Append("C_MATRL_NAME_KP=:C_MATRL_NAME_KP,");
            strSql.Append("C_KP_SIZE=:C_KP_SIZE,");
            strSql.Append("N_KP_LENGTH=:N_KP_LENGTH,");
            strSql.Append("N_KP_PW=:N_KP_PW,");
            strSql.Append("N_GROUP=:N_GROUP,");
            strSql.Append("C_XC=:C_XC,");
            strSql.Append("C_SL=:C_SL,");
            strSql.Append("C_WL=:C_WL,");
            strSql.Append("N_MACH_WGT_CCM=:N_MACH_WGT_CCM,");
            strSql.Append("N_ZJCLS=:N_ZJCLS,");
            strSql.Append("C_BY1=:C_BY1,");
            strSql.Append("C_BY2=:C_BY2,");
            strSql.Append("C_BY3=:C_BY3,");
            strSql.Append("C_BY4=:C_BY4,");
            strSql.Append("C_BY5=:C_BY5,");
            strSql.Append("C_LGJH=:C_LGJH,");
            strSql.Append("C_ZL_ID=:C_ZL_ID,");
            strSql.Append("C_LF_ID=:C_LF_ID,");
            strSql.Append("C_RH_ID=:C_RH_ID,");
            strSql.Append("N_SLAB_WIDTH=:N_SLAB_WIDTH,");
            strSql.Append("N_SLAB_THICK=:N_SLAB_THICK,");
            strSql.Append("C_DFP_RZ=:C_DFP_RZ,");
            strSql.Append("C_RZP_RZ=:C_RZP_RZ,");
            strSql.Append("C_DFP_YQ=:C_DFP_YQ,");
            strSql.Append("C_RZP_YQ=:C_RZP_YQ,");
            strSql.Append("N_KPJRL_WD=:N_KPJRL_WD,");
            strSql.Append("N_KPJRL_SJ=:N_KPJRL_SJ,");
            strSql.Append("N_TSL=:N_TSL,");
            strSql.Append("C_CCM_CODE=:C_CCM_CODE,");
            strSql.Append("C_CCM_DESC=:C_CCM_DESC,");
            strSql.Append("C_TL=:C_TL,");
            strSql.Append("N_ZJCLS_MIN=:N_ZJCLS_MIN,");
            strSql.Append("N_ZJCLS_MAX=:N_ZJCLS_MAX,");
            strSql.Append("C_STL_GRD_TYPE=:C_STL_GRD_TYPE,");
            strSql.Append("C_PROD_NAME=:C_PROD_NAME,");
            strSql.Append("C_PROD_KIND=:C_PROD_KIND,");
            strSql.Append("N_TYPE=:N_TYPE,");
            strSql.Append("C_RH=:C_RH,");
            strSql.Append("C_DFP_HL=:C_DFP_HL,");
            strSql.Append("C_HL=:C_HL,");
            strSql.Append("C_XM=:C_XM,");
            strSql.Append("C_CCM_ID=:C_CCM_ID,");
            strSql.Append("N_HL_TIME=:N_HL_TIME,");
            strSql.Append("N_DFP_HL_TIME=:N_DFP_HL_TIME,");
            strSql.Append("C_LF=:C_LF,");
            strSql.Append("C_KP=:C_KP,");
            strSql.Append("C_STL_GRD_CLASS=:C_STL_GRD_CLASS,");
            strSql.Append("C_PRO_USE=:C_PRO_USE,");
            strSql.Append("C_CUST_SQ=:C_CUST_SQ,");
            strSql.Append("C_TRANSMODE=:C_TRANSMODE,");
            strSql.Append("C_REMARK1=:C_REMARK1,");
            strSql.Append("C_REMARK2=:C_REMARK2,");
            strSql.Append("C_REMARK3=:C_REMARK3,");
            strSql.Append("C_REMARK4=:C_REMARK4,");
            strSql.Append("C_REMARK5=:C_REMARK5");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
                    new OracleParameter(":C_INITIALIZE_ITEM_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ORDER_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":C_MAT_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MAT_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_TECH_PROT", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SPEC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STL_GRD", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STD_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_USER_LEV", OracleDbType.Decimal,5),
                    new OracleParameter(":N_STL_GRD_LEV", OracleDbType.Decimal,5),
                    new OracleParameter(":N_ORDER_LEV", OracleDbType.Decimal,5),
                    new OracleParameter(":C_QUALIRY_LEV", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_NEED_DT", OracleDbType.Date),
                    new OracleParameter(":D_DELIVERY_DT", OracleDbType.Date),
                    new OracleParameter(":D_DT", OracleDbType.Date),
                    new OracleParameter(":C_LINE_DESC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_LINE_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_P_START_TIME", OracleDbType.Date),
                    new OracleParameter(":D_P_END_TIME", OracleDbType.Date),
                    new OracleParameter(":N_PROD_TIME", OracleDbType.Decimal,5),
                    new OracleParameter(":N_SORT", OracleDbType.Decimal,4),
                    new OracleParameter(":N_ROLL_PROD_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":C_ROLL_PROD_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STL_ROL_DT", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_PROD_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":N_WARE_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":N_WARE_OUT_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":N_FLAG", OracleDbType.Decimal,5),
                    new OracleParameter(":N_ISSUE_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":C_CUST_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CUST_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SALE_CHANNEL", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PACK", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_DESIGN_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_GROUP_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":C_STA_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_START_TIME", OracleDbType.Date),
                    new OracleParameter(":D_END_TIME", OracleDbType.Date),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":N_ROLL_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":N_MACH_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":C_CAST_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_INITIALIZE_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_FREE_TERM", OracleDbType.Varchar2,300),
                    new OracleParameter(":C_FREE_TERM2", OracleDbType.Varchar2,300),
                    new OracleParameter(":C_AREA", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PCLX", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_SFHL", OracleDbType.Varchar2,10),
                    new OracleParameter(":D_HL_START_TIME", OracleDbType.Date),
                    new OracleParameter(":D_HL_END_TIME", OracleDbType.Date),
                    new OracleParameter(":C_SFHL_D", OracleDbType.Varchar2,10),
                    new OracleParameter(":D_DHL_START_TIME", OracleDbType.Date),
                    new OracleParameter(":D_DHL_END_TIME", OracleDbType.Date),
                    new OracleParameter(":C_SFKP", OracleDbType.Varchar2,10),
                    new OracleParameter(":D_KP_START_TIME", OracleDbType.Date),
                    new OracleParameter(":D_KP_END_TIME", OracleDbType.Date),
                    new OracleParameter(":C_SFXM", OracleDbType.Varchar2,10),
                    new OracleParameter(":D_XM_START_TIME", OracleDbType.Date),
                    new OracleParameter(":D_XM_END_TIME", OracleDbType.Date),
                    new OracleParameter(":N_UPLOADSTATUS", OracleDbType.Decimal,1),
                    new OracleParameter(":C_MATRL_CODE_SLAB", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MATRL_NAME_SLAB", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SLAB_SIZE", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_SLAB_LENGTH", OracleDbType.Decimal,15),
                    new OracleParameter(":N_SLAB_PW", OracleDbType.Decimal,15),
                    new OracleParameter(":D_CAN_ROLL_TIME", OracleDbType.Date),
                    new OracleParameter(":C_ROUTE", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_DIAMETER", OracleDbType.Decimal,4),
                    new OracleParameter(":C_XM_YQ", OracleDbType.Varchar2,1000),
                    new OracleParameter(":N_JRL_WD", OracleDbType.Decimal,10),
                    new OracleParameter(":N_JRL_SJ", OracleDbType.Decimal,10),
                    new OracleParameter(":C_STL_GRD_SLAB", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STD_CODE_SLAB", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MATRL_CODE_KP", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MATRL_NAME_KP", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_KP_SIZE", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_KP_LENGTH", OracleDbType.Decimal,15),
                    new OracleParameter(":N_KP_PW", OracleDbType.Decimal,15),
                    new OracleParameter(":N_GROUP", OracleDbType.Decimal,4),
                    new OracleParameter(":C_XC", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_SL", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_WL", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_MACH_WGT_CCM", OracleDbType.Decimal,15),
                    new OracleParameter(":N_ZJCLS", OracleDbType.Decimal,4),
                    new OracleParameter(":C_BY1", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_BY2", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_BY3", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_BY4", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_BY5", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_LGJH", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ZL_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_LF_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_RH_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_SLAB_WIDTH", OracleDbType.Decimal,4),
                    new OracleParameter(":N_SLAB_THICK", OracleDbType.Decimal,4),
                    new OracleParameter(":C_DFP_RZ", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_RZP_RZ", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_DFP_YQ", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_RZP_YQ", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_KPJRL_WD", OracleDbType.Decimal,10),
                    new OracleParameter(":N_KPJRL_SJ", OracleDbType.Decimal,10),
                    new OracleParameter(":N_TSL", OracleDbType.Decimal,10),
                    new OracleParameter(":C_CCM_CODE", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_CCM_DESC", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_TL", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_ZJCLS_MIN", OracleDbType.Decimal,4),
                    new OracleParameter(":N_ZJCLS_MAX", OracleDbType.Decimal,4),
                    new OracleParameter(":C_STL_GRD_TYPE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PROD_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PROD_KIND", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_TYPE", OracleDbType.Decimal,15),
                    new OracleParameter(":C_RH", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_DFP_HL", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_HL", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_XM", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CCM_ID", OracleDbType.Varchar2,500),
                    new OracleParameter(":N_HL_TIME", OracleDbType.Decimal,10),
                    new OracleParameter(":N_DFP_HL_TIME", OracleDbType.Decimal,10),
                    new OracleParameter(":C_LF", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_KP", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STL_GRD_CLASS", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PRO_USE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CUST_SQ", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_TRANSMODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_REMARK1", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_REMARK2", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_REMARK3", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_REMARK4", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_REMARK5", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.N_STATUS;
            parameters[1].Value = model.C_INITIALIZE_ITEM_ID;
            parameters[2].Value = model.C_ORDER_NO;
            parameters[3].Value = model.N_WGT;
            parameters[4].Value = model.C_MAT_CODE;
            parameters[5].Value = model.C_MAT_NAME;
            parameters[6].Value = model.C_TECH_PROT;
            parameters[7].Value = model.C_SPEC;
            parameters[8].Value = model.C_STL_GRD;
            parameters[9].Value = model.C_STD_CODE;
            parameters[10].Value = model.N_USER_LEV;
            parameters[11].Value = model.N_STL_GRD_LEV;
            parameters[12].Value = model.N_ORDER_LEV;
            parameters[13].Value = model.C_QUALIRY_LEV;
            parameters[14].Value = model.D_NEED_DT;
            parameters[15].Value = model.D_DELIVERY_DT;
            parameters[16].Value = model.D_DT;
            parameters[17].Value = model.C_LINE_DESC;
            parameters[18].Value = model.C_LINE_CODE;
            parameters[19].Value = model.D_P_START_TIME;
            parameters[20].Value = model.D_P_END_TIME;
            parameters[21].Value = model.N_PROD_TIME;
            parameters[22].Value = model.N_SORT;
            parameters[23].Value = model.N_ROLL_PROD_WGT;
            parameters[24].Value = model.C_ROLL_PROD_EMP_ID;
            parameters[25].Value = model.C_STL_ROL_DT;
            parameters[26].Value = model.N_PROD_WGT;
            parameters[27].Value = model.N_WARE_WGT;
            parameters[28].Value = model.N_WARE_OUT_WGT;
            parameters[29].Value = model.N_FLAG;
            parameters[30].Value = model.N_ISSUE_WGT;
            parameters[31].Value = model.C_CUST_NO;
            parameters[32].Value = model.C_CUST_NAME;
            parameters[33].Value = model.C_SALE_CHANNEL;
            parameters[34].Value = model.C_PACK;
            parameters[35].Value = model.C_DESIGN_NO;
            parameters[36].Value = model.N_GROUP_WGT;
            parameters[37].Value = model.C_STA_ID;
            parameters[38].Value = model.D_START_TIME;
            parameters[39].Value = model.D_END_TIME;
            parameters[40].Value = model.C_EMP_ID;
            parameters[41].Value = model.D_MOD_DT;
            parameters[42].Value = model.N_ROLL_WGT;
            parameters[43].Value = model.N_MACH_WGT;
            parameters[44].Value = model.C_CAST_NO;
            parameters[45].Value = model.C_INITIALIZE_ID;
            parameters[46].Value = model.C_FREE_TERM;
            parameters[47].Value = model.C_FREE_TERM2;
            parameters[48].Value = model.C_AREA;
            parameters[49].Value = model.C_PCLX;
            parameters[50].Value = model.C_SFHL;
            parameters[51].Value = model.D_HL_START_TIME;
            parameters[52].Value = model.D_HL_END_TIME;
            parameters[53].Value = model.C_SFHL_D;
            parameters[54].Value = model.D_DHL_START_TIME;
            parameters[55].Value = model.D_DHL_END_TIME;
            parameters[56].Value = model.C_SFKP;
            parameters[57].Value = model.D_KP_START_TIME;
            parameters[58].Value = model.D_KP_END_TIME;
            parameters[59].Value = model.C_SFXM;
            parameters[60].Value = model.D_XM_START_TIME;
            parameters[61].Value = model.D_XM_END_TIME;
            parameters[62].Value = model.N_UPLOADSTATUS;
            parameters[63].Value = model.C_MATRL_CODE_SLAB;
            parameters[64].Value = model.C_MATRL_NAME_SLAB;
            parameters[65].Value = model.C_SLAB_SIZE;
            parameters[66].Value = model.N_SLAB_LENGTH;
            parameters[67].Value = model.N_SLAB_PW;
            parameters[68].Value = model.D_CAN_ROLL_TIME;
            parameters[69].Value = model.C_ROUTE;
            parameters[70].Value = model.N_DIAMETER;
            parameters[71].Value = model.C_XM_YQ;
            parameters[72].Value = model.N_JRL_WD;
            parameters[73].Value = model.N_JRL_SJ;
            parameters[74].Value = model.C_STL_GRD_SLAB;
            parameters[75].Value = model.C_STD_CODE_SLAB;
            parameters[76].Value = model.C_MATRL_CODE_KP;
            parameters[77].Value = model.C_MATRL_NAME_KP;
            parameters[78].Value = model.C_KP_SIZE;
            parameters[79].Value = model.N_KP_LENGTH;
            parameters[80].Value = model.N_KP_PW;
            parameters[81].Value = model.N_GROUP;
            parameters[82].Value = model.C_XC;
            parameters[83].Value = model.C_SL;
            parameters[84].Value = model.C_WL;
            parameters[85].Value = model.N_MACH_WGT_CCM;
            parameters[86].Value = model.N_ZJCLS;
            parameters[87].Value = model.C_BY1;
            parameters[88].Value = model.C_BY2;
            parameters[89].Value = model.C_BY3;
            parameters[90].Value = model.C_BY4;
            parameters[91].Value = model.C_BY5;
            parameters[92].Value = model.C_LGJH;
            parameters[93].Value = model.C_ZL_ID;
            parameters[94].Value = model.C_LF_ID;
            parameters[95].Value = model.C_RH_ID;
            parameters[96].Value = model.N_SLAB_WIDTH;
            parameters[97].Value = model.N_SLAB_THICK;
            parameters[98].Value = model.C_DFP_RZ;
            parameters[99].Value = model.C_RZP_RZ;
            parameters[100].Value = model.C_DFP_YQ;
            parameters[101].Value = model.C_RZP_YQ;
            parameters[102].Value = model.N_KPJRL_WD;
            parameters[103].Value = model.N_KPJRL_SJ;
            parameters[104].Value = model.N_TSL;
            parameters[105].Value = model.C_CCM_CODE;
            parameters[106].Value = model.C_CCM_DESC;
            parameters[107].Value = model.C_TL;
            parameters[108].Value = model.N_ZJCLS_MIN;
            parameters[109].Value = model.N_ZJCLS_MAX;
            parameters[110].Value = model.C_STL_GRD_TYPE;
            parameters[111].Value = model.C_PROD_NAME;
            parameters[112].Value = model.C_PROD_KIND;
            parameters[113].Value = model.N_TYPE;
            parameters[114].Value = model.C_RH;
            parameters[115].Value = model.C_DFP_HL;
            parameters[116].Value = model.C_HL;
            parameters[117].Value = model.C_XM;
            parameters[118].Value = model.C_CCM_ID;
            parameters[119].Value = model.N_HL_TIME;
            parameters[120].Value = model.N_DFP_HL_TIME;
            parameters[121].Value = model.C_LF;
            parameters[122].Value = model.C_KP;
            parameters[123].Value = model.C_STL_GRD_CLASS;
            parameters[124].Value = model.C_PRO_USE;
            parameters[125].Value = model.C_CUST_SQ;
            parameters[126].Value = model.C_TRANSMODE;
            parameters[127].Value = model.C_REMARK1;
            parameters[128].Value = model.C_REMARK2;
            parameters[129].Value = model.C_REMARK3;
            parameters[130].Value = model.C_REMARK4;
            parameters[131].Value = model.C_REMARK5;
            parameters[132].Value = model.C_ID;

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
        public bool Update_Trans(Mod_TRP_PLAN_ROLL model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TRP_PLAN_ROLL set ");
            strSql.Append("N_STATUS=:N_STATUS,");
            strSql.Append("C_INITIALIZE_ITEM_ID=:C_INITIALIZE_ITEM_ID,");
            strSql.Append("C_ORDER_NO=:C_ORDER_NO,");
            strSql.Append("N_WGT=:N_WGT,");
            strSql.Append("C_MAT_CODE=:C_MAT_CODE,");
            strSql.Append("C_MAT_NAME=:C_MAT_NAME,");
            strSql.Append("C_TECH_PROT=:C_TECH_PROT,");
            strSql.Append("C_SPEC=:C_SPEC,");
            strSql.Append("C_STL_GRD=:C_STL_GRD,");
            strSql.Append("C_STD_CODE=:C_STD_CODE,");
            strSql.Append("N_USER_LEV=:N_USER_LEV,");
            strSql.Append("N_STL_GRD_LEV=:N_STL_GRD_LEV,");
            strSql.Append("N_ORDER_LEV=:N_ORDER_LEV,");
            strSql.Append("C_QUALIRY_LEV=:C_QUALIRY_LEV,");
            strSql.Append("D_NEED_DT=:D_NEED_DT,");
            strSql.Append("D_DELIVERY_DT=:D_DELIVERY_DT,");
            strSql.Append("D_DT=:D_DT,");
            strSql.Append("C_LINE_DESC=:C_LINE_DESC,");
            strSql.Append("C_LINE_CODE=:C_LINE_CODE,");
            strSql.Append("D_P_START_TIME=:D_P_START_TIME,");
            strSql.Append("D_P_END_TIME=:D_P_END_TIME,");
            strSql.Append("N_PROD_TIME=:N_PROD_TIME,");
            strSql.Append("N_SORT=:N_SORT,");
            strSql.Append("N_ROLL_PROD_WGT=:N_ROLL_PROD_WGT,");
            strSql.Append("C_ROLL_PROD_EMP_ID=:C_ROLL_PROD_EMP_ID,");
            strSql.Append("C_STL_ROL_DT=:C_STL_ROL_DT,");
            strSql.Append("N_PROD_WGT=:N_PROD_WGT,");
            strSql.Append("N_WARE_WGT=:N_WARE_WGT,");
            strSql.Append("N_WARE_OUT_WGT=:N_WARE_OUT_WGT,");
            strSql.Append("N_FLAG=:N_FLAG,");
            strSql.Append("N_ISSUE_WGT=:N_ISSUE_WGT,");
            strSql.Append("C_CUST_NO=:C_CUST_NO,");
            strSql.Append("C_CUST_NAME=:C_CUST_NAME,");
            strSql.Append("C_SALE_CHANNEL=:C_SALE_CHANNEL,");
            strSql.Append("C_PACK=:C_PACK,");
            strSql.Append("C_DESIGN_NO=:C_DESIGN_NO,");
            strSql.Append("N_GROUP_WGT=:N_GROUP_WGT,");
            strSql.Append("C_STA_ID=:C_STA_ID,");
            strSql.Append("D_START_TIME=:D_START_TIME,");
            strSql.Append("D_END_TIME=:D_END_TIME,");
            strSql.Append("C_EMP_ID=:C_EMP_ID,");
            strSql.Append("D_MOD_DT=:D_MOD_DT,");
            strSql.Append("N_ROLL_WGT=:N_ROLL_WGT,");
            strSql.Append("N_MACH_WGT=:N_MACH_WGT,");
            strSql.Append("C_CAST_NO=:C_CAST_NO,");
            strSql.Append("C_INITIALIZE_ID=:C_INITIALIZE_ID,");
            strSql.Append("C_FREE_TERM=:C_FREE_TERM,");
            strSql.Append("C_FREE_TERM2=:C_FREE_TERM2,");
            strSql.Append("C_AREA=:C_AREA,");
            strSql.Append("C_PCLX=:C_PCLX,");
            strSql.Append("C_SFHL=:C_SFHL,");
            strSql.Append("D_HL_START_TIME=:D_HL_START_TIME,");
            strSql.Append("D_HL_END_TIME=:D_HL_END_TIME,");
            strSql.Append("C_SFHL_D=:C_SFHL_D,");
            strSql.Append("D_DHL_START_TIME=:D_DHL_START_TIME,");
            strSql.Append("D_DHL_END_TIME=:D_DHL_END_TIME,");
            strSql.Append("C_SFKP=:C_SFKP,");
            strSql.Append("D_KP_START_TIME=:D_KP_START_TIME,");
            strSql.Append("D_KP_END_TIME=:D_KP_END_TIME,");
            strSql.Append("C_SFXM=:C_SFXM,");
            strSql.Append("D_XM_START_TIME=:D_XM_START_TIME,");
            strSql.Append("D_XM_END_TIME=:D_XM_END_TIME,");
            strSql.Append("N_UPLOADSTATUS=:N_UPLOADSTATUS,");
            strSql.Append("C_MATRL_CODE_SLAB=:C_MATRL_CODE_SLAB,");
            strSql.Append("C_MATRL_NAME_SLAB=:C_MATRL_NAME_SLAB,");
            strSql.Append("C_SLAB_SIZE=:C_SLAB_SIZE,");
            strSql.Append("N_SLAB_LENGTH=:N_SLAB_LENGTH,");
            strSql.Append("N_SLAB_PW=:N_SLAB_PW,");
            strSql.Append("D_CAN_ROLL_TIME=:D_CAN_ROLL_TIME,");
            strSql.Append("C_ROUTE=:C_ROUTE,");
            strSql.Append("N_DIAMETER=:N_DIAMETER,");
            strSql.Append("C_XM_YQ=:C_XM_YQ,");
            strSql.Append("N_JRL_WD=:N_JRL_WD,");
            strSql.Append("N_JRL_SJ=:N_JRL_SJ,");
            strSql.Append("C_STL_GRD_SLAB=:C_STL_GRD_SLAB,");
            strSql.Append("C_STD_CODE_SLAB=:C_STD_CODE_SLAB,");
            strSql.Append("C_MATRL_CODE_KP=:C_MATRL_CODE_KP,");
            strSql.Append("C_MATRL_NAME_KP=:C_MATRL_NAME_KP,");
            strSql.Append("C_KP_SIZE=:C_KP_SIZE,");
            strSql.Append("N_KP_LENGTH=:N_KP_LENGTH,");
            strSql.Append("N_KP_PW=:N_KP_PW,");
            strSql.Append("N_GROUP=:N_GROUP,");
            strSql.Append("C_XC=:C_XC,");
            strSql.Append("C_SL=:C_SL,");
            strSql.Append("C_WL=:C_WL,");
            strSql.Append("N_MACH_WGT_CCM=:N_MACH_WGT_CCM,");
            strSql.Append("N_ZJCLS=:N_ZJCLS,");
            strSql.Append("C_BY1=:C_BY1,");
            strSql.Append("C_BY2=:C_BY2,");
            strSql.Append("C_BY3=:C_BY3,");
            strSql.Append("C_BY4=:C_BY4,");
            strSql.Append("C_BY5=:C_BY5,");
            strSql.Append("C_LGJH=:C_LGJH,");
            strSql.Append("C_ZL_ID=:C_ZL_ID,");
            strSql.Append("C_LF_ID=:C_LF_ID,");
            strSql.Append("C_RH_ID=:C_RH_ID,");
            strSql.Append("N_SLAB_WIDTH=:N_SLAB_WIDTH,");
            strSql.Append("N_SLAB_THICK=:N_SLAB_THICK,");
            strSql.Append("C_DFP_RZ=:C_DFP_RZ,");
            strSql.Append("C_RZP_RZ=:C_RZP_RZ,");
            strSql.Append("C_DFP_YQ=:C_DFP_YQ,");
            strSql.Append("C_RZP_YQ=:C_RZP_YQ,");
            strSql.Append("N_KPJRL_WD=:N_KPJRL_WD,");
            strSql.Append("N_KPJRL_SJ=:N_KPJRL_SJ,");
            strSql.Append("N_TSL=:N_TSL,");
            strSql.Append("C_CCM_CODE=:C_CCM_CODE,");
            strSql.Append("C_CCM_DESC=:C_CCM_DESC,");
            strSql.Append("C_TL=:C_TL,");
            strSql.Append("N_ZJCLS_MIN=:N_ZJCLS_MIN,");
            strSql.Append("N_ZJCLS_MAX=:N_ZJCLS_MAX,");
            strSql.Append("C_STL_GRD_TYPE=:C_STL_GRD_TYPE,");
            strSql.Append("C_PROD_NAME=:C_PROD_NAME,");
            strSql.Append("C_PROD_KIND=:C_PROD_KIND,");
            strSql.Append("N_TYPE=:N_TYPE,");
            strSql.Append("C_RH=:C_RH,");
            strSql.Append("C_DFP_HL=:C_DFP_HL,");
            strSql.Append("C_HL=:C_HL,");
            strSql.Append("C_XM=:C_XM,");
            strSql.Append("C_CCM_ID=:C_CCM_ID,");
            strSql.Append("N_HL_TIME=:N_HL_TIME,");
            strSql.Append("N_DFP_HL_TIME=:N_DFP_HL_TIME,");
            strSql.Append("C_LF=:C_LF,");
            strSql.Append("C_KP=:C_KP,");
            strSql.Append("C_STL_GRD_CLASS=:C_STL_GRD_CLASS,");
            strSql.Append("C_PRO_USE=:C_PRO_USE,");
            strSql.Append("C_CUST_SQ=:C_CUST_SQ,");
            strSql.Append("C_TRANSMODE=:C_TRANSMODE,");
            strSql.Append("C_REMARK1=:C_REMARK1,");
            strSql.Append("C_REMARK2=:C_REMARK2,");
            strSql.Append("C_REMARK3=:C_REMARK3,");
            strSql.Append("C_REMARK4=:C_REMARK4,");
            strSql.Append("C_REMARK5=:C_REMARK5");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
                    new OracleParameter(":C_INITIALIZE_ITEM_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ORDER_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":C_MAT_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MAT_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_TECH_PROT", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SPEC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STL_GRD", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STD_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_USER_LEV", OracleDbType.Decimal,5),
                    new OracleParameter(":N_STL_GRD_LEV", OracleDbType.Decimal,5),
                    new OracleParameter(":N_ORDER_LEV", OracleDbType.Decimal,5),
                    new OracleParameter(":C_QUALIRY_LEV", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_NEED_DT", OracleDbType.Date),
                    new OracleParameter(":D_DELIVERY_DT", OracleDbType.Date),
                    new OracleParameter(":D_DT", OracleDbType.Date),
                    new OracleParameter(":C_LINE_DESC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_LINE_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_P_START_TIME", OracleDbType.Date),
                    new OracleParameter(":D_P_END_TIME", OracleDbType.Date),
                    new OracleParameter(":N_PROD_TIME", OracleDbType.Decimal,5),
                    new OracleParameter(":N_SORT", OracleDbType.Decimal,4),
                    new OracleParameter(":N_ROLL_PROD_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":C_ROLL_PROD_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STL_ROL_DT", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_PROD_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":N_WARE_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":N_WARE_OUT_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":N_FLAG", OracleDbType.Decimal,5),
                    new OracleParameter(":N_ISSUE_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":C_CUST_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CUST_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SALE_CHANNEL", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PACK", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_DESIGN_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_GROUP_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":C_STA_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_START_TIME", OracleDbType.Date),
                    new OracleParameter(":D_END_TIME", OracleDbType.Date),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":N_ROLL_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":N_MACH_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":C_CAST_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_INITIALIZE_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_FREE_TERM", OracleDbType.Varchar2,300),
                    new OracleParameter(":C_FREE_TERM2", OracleDbType.Varchar2,300),
                    new OracleParameter(":C_AREA", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PCLX", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_SFHL", OracleDbType.Varchar2,10),
                    new OracleParameter(":D_HL_START_TIME", OracleDbType.Date),
                    new OracleParameter(":D_HL_END_TIME", OracleDbType.Date),
                    new OracleParameter(":C_SFHL_D", OracleDbType.Varchar2,10),
                    new OracleParameter(":D_DHL_START_TIME", OracleDbType.Date),
                    new OracleParameter(":D_DHL_END_TIME", OracleDbType.Date),
                    new OracleParameter(":C_SFKP", OracleDbType.Varchar2,10),
                    new OracleParameter(":D_KP_START_TIME", OracleDbType.Date),
                    new OracleParameter(":D_KP_END_TIME", OracleDbType.Date),
                    new OracleParameter(":C_SFXM", OracleDbType.Varchar2,10),
                    new OracleParameter(":D_XM_START_TIME", OracleDbType.Date),
                    new OracleParameter(":D_XM_END_TIME", OracleDbType.Date),
                    new OracleParameter(":N_UPLOADSTATUS", OracleDbType.Decimal,1),
                    new OracleParameter(":C_MATRL_CODE_SLAB", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MATRL_NAME_SLAB", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SLAB_SIZE", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_SLAB_LENGTH", OracleDbType.Decimal,15),
                    new OracleParameter(":N_SLAB_PW", OracleDbType.Decimal,15),
                    new OracleParameter(":D_CAN_ROLL_TIME", OracleDbType.Date),
                    new OracleParameter(":C_ROUTE", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_DIAMETER", OracleDbType.Decimal,4),
                    new OracleParameter(":C_XM_YQ", OracleDbType.Varchar2,1000),
                    new OracleParameter(":N_JRL_WD", OracleDbType.Decimal,10),
                    new OracleParameter(":N_JRL_SJ", OracleDbType.Decimal,10),
                    new OracleParameter(":C_STL_GRD_SLAB", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STD_CODE_SLAB", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MATRL_CODE_KP", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MATRL_NAME_KP", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_KP_SIZE", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_KP_LENGTH", OracleDbType.Decimal,15),
                    new OracleParameter(":N_KP_PW", OracleDbType.Decimal,15),
                    new OracleParameter(":N_GROUP", OracleDbType.Decimal,4),
                    new OracleParameter(":C_XC", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_SL", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_WL", OracleDbType.Varchar2,10),
                    new OracleParameter(":N_MACH_WGT_CCM", OracleDbType.Decimal,15),
                    new OracleParameter(":N_ZJCLS", OracleDbType.Decimal,4),
                    new OracleParameter(":C_BY1", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_BY2", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_BY3", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_BY4", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_BY5", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_LGJH", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ZL_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_LF_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_RH_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_SLAB_WIDTH", OracleDbType.Decimal,4),
                    new OracleParameter(":N_SLAB_THICK", OracleDbType.Decimal,4),
                    new OracleParameter(":C_DFP_RZ", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_RZP_RZ", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_DFP_YQ", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_RZP_YQ", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_KPJRL_WD", OracleDbType.Decimal,10),
                    new OracleParameter(":N_KPJRL_SJ", OracleDbType.Decimal,10),
                    new OracleParameter(":N_TSL", OracleDbType.Decimal,10),
                    new OracleParameter(":C_CCM_CODE", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_CCM_DESC", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_TL", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_ZJCLS_MIN", OracleDbType.Decimal,4),
                    new OracleParameter(":N_ZJCLS_MAX", OracleDbType.Decimal,4),
                    new OracleParameter(":C_STL_GRD_TYPE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PROD_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PROD_KIND", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_TYPE", OracleDbType.Decimal,15),
                    new OracleParameter(":C_RH", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_DFP_HL", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_HL", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_XM", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CCM_ID", OracleDbType.Varchar2,500),
                    new OracleParameter(":N_HL_TIME", OracleDbType.Decimal,10),
                    new OracleParameter(":N_DFP_HL_TIME", OracleDbType.Decimal,10),
                    new OracleParameter(":C_LF", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_KP", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STL_GRD_CLASS", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PRO_USE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CUST_SQ", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_TRANSMODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_REMARK1", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_REMARK2", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_REMARK3", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_REMARK4", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_REMARK5", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.N_STATUS;
            parameters[1].Value = model.C_INITIALIZE_ITEM_ID;
            parameters[2].Value = model.C_ORDER_NO;
            parameters[3].Value = model.N_WGT;
            parameters[4].Value = model.C_MAT_CODE;
            parameters[5].Value = model.C_MAT_NAME;
            parameters[6].Value = model.C_TECH_PROT;
            parameters[7].Value = model.C_SPEC;
            parameters[8].Value = model.C_STL_GRD;
            parameters[9].Value = model.C_STD_CODE;
            parameters[10].Value = model.N_USER_LEV;
            parameters[11].Value = model.N_STL_GRD_LEV;
            parameters[12].Value = model.N_ORDER_LEV;
            parameters[13].Value = model.C_QUALIRY_LEV;
            parameters[14].Value = model.D_NEED_DT;
            parameters[15].Value = model.D_DELIVERY_DT;
            parameters[16].Value = model.D_DT;
            parameters[17].Value = model.C_LINE_DESC;
            parameters[18].Value = model.C_LINE_CODE;
            parameters[19].Value = model.D_P_START_TIME;
            parameters[20].Value = model.D_P_END_TIME;
            parameters[21].Value = model.N_PROD_TIME;
            parameters[22].Value = model.N_SORT;
            parameters[23].Value = model.N_ROLL_PROD_WGT;
            parameters[24].Value = model.C_ROLL_PROD_EMP_ID;
            parameters[25].Value = model.C_STL_ROL_DT;
            parameters[26].Value = model.N_PROD_WGT;
            parameters[27].Value = model.N_WARE_WGT;
            parameters[28].Value = model.N_WARE_OUT_WGT;
            parameters[29].Value = model.N_FLAG;
            parameters[30].Value = model.N_ISSUE_WGT;
            parameters[31].Value = model.C_CUST_NO;
            parameters[32].Value = model.C_CUST_NAME;
            parameters[33].Value = model.C_SALE_CHANNEL;
            parameters[34].Value = model.C_PACK;
            parameters[35].Value = model.C_DESIGN_NO;
            parameters[36].Value = model.N_GROUP_WGT;
            parameters[37].Value = model.C_STA_ID;
            parameters[38].Value = model.D_START_TIME;
            parameters[39].Value = model.D_END_TIME;
            parameters[40].Value = model.C_EMP_ID;
            parameters[41].Value = model.D_MOD_DT;
            parameters[42].Value = model.N_ROLL_WGT;
            parameters[43].Value = model.N_MACH_WGT;
            parameters[44].Value = model.C_CAST_NO;
            parameters[45].Value = model.C_INITIALIZE_ID;
            parameters[46].Value = model.C_FREE_TERM;
            parameters[47].Value = model.C_FREE_TERM2;
            parameters[48].Value = model.C_AREA;
            parameters[49].Value = model.C_PCLX;
            parameters[50].Value = model.C_SFHL;
            parameters[51].Value = model.D_HL_START_TIME;
            parameters[52].Value = model.D_HL_END_TIME;
            parameters[53].Value = model.C_SFHL_D;
            parameters[54].Value = model.D_DHL_START_TIME;
            parameters[55].Value = model.D_DHL_END_TIME;
            parameters[56].Value = model.C_SFKP;
            parameters[57].Value = model.D_KP_START_TIME;
            parameters[58].Value = model.D_KP_END_TIME;
            parameters[59].Value = model.C_SFXM;
            parameters[60].Value = model.D_XM_START_TIME;
            parameters[61].Value = model.D_XM_END_TIME;
            parameters[62].Value = model.N_UPLOADSTATUS;
            parameters[63].Value = model.C_MATRL_CODE_SLAB;
            parameters[64].Value = model.C_MATRL_NAME_SLAB;
            parameters[65].Value = model.C_SLAB_SIZE;
            parameters[66].Value = model.N_SLAB_LENGTH;
            parameters[67].Value = model.N_SLAB_PW;
            parameters[68].Value = model.D_CAN_ROLL_TIME;
            parameters[69].Value = model.C_ROUTE;
            parameters[70].Value = model.N_DIAMETER;
            parameters[71].Value = model.C_XM_YQ;
            parameters[72].Value = model.N_JRL_WD;
            parameters[73].Value = model.N_JRL_SJ;
            parameters[74].Value = model.C_STL_GRD_SLAB;
            parameters[75].Value = model.C_STD_CODE_SLAB;
            parameters[76].Value = model.C_MATRL_CODE_KP;
            parameters[77].Value = model.C_MATRL_NAME_KP;
            parameters[78].Value = model.C_KP_SIZE;
            parameters[79].Value = model.N_KP_LENGTH;
            parameters[80].Value = model.N_KP_PW;
            parameters[81].Value = model.N_GROUP;
            parameters[82].Value = model.C_XC;
            parameters[83].Value = model.C_SL;
            parameters[84].Value = model.C_WL;
            parameters[85].Value = model.N_MACH_WGT_CCM;
            parameters[86].Value = model.N_ZJCLS;
            parameters[87].Value = model.C_BY1;
            parameters[88].Value = model.C_BY2;
            parameters[89].Value = model.C_BY3;
            parameters[90].Value = model.C_BY4;
            parameters[91].Value = model.C_BY5;
            parameters[92].Value = model.C_LGJH;
            parameters[93].Value = model.C_ZL_ID;
            parameters[94].Value = model.C_LF_ID;
            parameters[95].Value = model.C_RH_ID;
            parameters[96].Value = model.N_SLAB_WIDTH;
            parameters[97].Value = model.N_SLAB_THICK;
            parameters[98].Value = model.C_DFP_RZ;
            parameters[99].Value = model.C_RZP_RZ;
            parameters[100].Value = model.C_DFP_YQ;
            parameters[101].Value = model.C_RZP_YQ;
            parameters[102].Value = model.N_KPJRL_WD;
            parameters[103].Value = model.N_KPJRL_SJ;
            parameters[104].Value = model.N_TSL;
            parameters[105].Value = model.C_CCM_CODE;
            parameters[106].Value = model.C_CCM_DESC;
            parameters[107].Value = model.C_TL;
            parameters[108].Value = model.N_ZJCLS_MIN;
            parameters[109].Value = model.N_ZJCLS_MAX;
            parameters[110].Value = model.C_STL_GRD_TYPE;
            parameters[111].Value = model.C_PROD_NAME;
            parameters[112].Value = model.C_PROD_KIND;
            parameters[113].Value = model.N_TYPE;
            parameters[114].Value = model.C_RH;
            parameters[115].Value = model.C_DFP_HL;
            parameters[116].Value = model.C_HL;
            parameters[117].Value = model.C_XM;
            parameters[118].Value = model.C_CCM_ID;
            parameters[119].Value = model.N_HL_TIME;
            parameters[120].Value = model.N_DFP_HL_TIME;
            parameters[121].Value = model.C_LF;
            parameters[122].Value = model.C_KP;
            parameters[123].Value = model.C_STL_GRD_CLASS;
            parameters[124].Value = model.C_PRO_USE;
            parameters[125].Value = model.C_CUST_SQ;
            parameters[126].Value = model.C_TRANSMODE;
            parameters[127].Value = model.C_REMARK1;
            parameters[128].Value = model.C_REMARK2;
            parameters[129].Value = model.C_REMARK3;
            parameters[130].Value = model.C_REMARK4;
            parameters[131].Value = model.C_REMARK5;
            parameters[132].Value = model.C_ID;

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
        /// </summary>//,C_STL_GRD_SLAB,C_STD_CODE_SLAB
        public bool Delete(string C_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from TRP_PLAN_ROLL ");
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
        /// 根据订单号删除数据
        /// </summary>
        public bool DeleteByOrderNo(string C_INITIALIZE_ITEM_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from TRP_PLAN_ROLL ");
            strSql.Append(" where C_INITIALIZE_ITEM_ID=:C_INITIALIZE_ITEM_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_INITIALIZE_ITEM_ID", OracleDbType.Varchar2,100)            };
            parameters[0].Value = C_INITIALIZE_ITEM_ID;

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
        /// 批量删除数据
        /// </summary>
        public bool DeleteList(string C_IDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from TRP_PLAN_ROLL ");
            strSql.Append(" where C_ID in (" + C_IDlist + ")  ");
            int rows = DbHelperOra.ExecuteSql(strSql.ToString());
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
        public Mod_TRP_PLAN_ROLL GetModel(string C_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  *  from TRP_PLAN_ROLL ");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)            };
            parameters[0].Value = C_ID;

            Mod_TRP_PLAN_ROLL model = new Mod_TRP_PLAN_ROLL();
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
        /// 得到一个对象实体
        /// </summary>
        public Mod_TRP_PLAN_ROLL GetModelByOrderNo(string C_ORDER_NO)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  *  from TRP_PLAN_ROLL ");
            strSql.Append(" where C_ORDER_NO=:C_ORDER_NO ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ORDER_NO", OracleDbType.Varchar2,100)            };
            parameters[0].Value = C_ORDER_NO;

            Mod_TRP_PLAN_ROLL model = new Mod_TRP_PLAN_ROLL();
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
        /// 得到一个对象实体
        /// </summary>
        public Mod_TRP_PLAN_ROLL GetModel_Trans(string c_sta_id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from(select T.*  from TRP_PLAN_ROLL t where t.c_sta_id='" + c_sta_id + "' and t.d_p_end_time is not null and t.N_STATUS=1 order by t.d_p_end_time desc)where rownum=1");

            Mod_TRP_PLAN_ROLL model = new Mod_TRP_PLAN_ROLL();
            DataSet ds = TransactionHelper.Query(strSql.ToString());
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
        public Mod_TRP_PLAN_ROLL DataRowToModel(DataRow row)
        {
            Mod_TRP_PLAN_ROLL model = new Mod_TRP_PLAN_ROLL();
            if (row != null)
            {
                if (row["C_ID"] != null)
                {
                    model.C_ID = row["C_ID"].ToString();
                }
                if (row["N_STATUS"] != null && row["N_STATUS"].ToString() != "")
                {
                    model.N_STATUS = decimal.Parse(row["N_STATUS"].ToString());
                }
                if (row["C_INITIALIZE_ITEM_ID"] != null)
                {
                    model.C_INITIALIZE_ITEM_ID = row["C_INITIALIZE_ITEM_ID"].ToString();
                }
                if (row["C_ORDER_NO"] != null)
                {
                    model.C_ORDER_NO = row["C_ORDER_NO"].ToString();
                }
                if (row["N_WGT"] != null && row["N_WGT"].ToString() != "")
                {
                    model.N_WGT = decimal.Parse(row["N_WGT"].ToString());
                }
                if (row["C_MAT_CODE"] != null)
                {
                    model.C_MAT_CODE = row["C_MAT_CODE"].ToString();
                }
                if (row["C_MAT_NAME"] != null)
                {
                    model.C_MAT_NAME = row["C_MAT_NAME"].ToString();
                }
                if (row["C_TECH_PROT"] != null)
                {
                    model.C_TECH_PROT = row["C_TECH_PROT"].ToString();
                }
                if (row["C_SPEC"] != null)
                {
                    model.C_SPEC = row["C_SPEC"].ToString();
                }
                if (row["C_STL_GRD"] != null)
                {
                    model.C_STL_GRD = row["C_STL_GRD"].ToString();
                }
                if (row["C_STD_CODE"] != null)
                {
                    model.C_STD_CODE = row["C_STD_CODE"].ToString();
                }
                if (row["N_USER_LEV"] != null && row["N_USER_LEV"].ToString() != "")
                {
                    model.N_USER_LEV = decimal.Parse(row["N_USER_LEV"].ToString());
                }
                if (row["N_STL_GRD_LEV"] != null && row["N_STL_GRD_LEV"].ToString() != "")
                {
                    model.N_STL_GRD_LEV = decimal.Parse(row["N_STL_GRD_LEV"].ToString());
                }
                if (row["N_ORDER_LEV"] != null && row["N_ORDER_LEV"].ToString() != "")
                {
                    model.N_ORDER_LEV = decimal.Parse(row["N_ORDER_LEV"].ToString());
                }
                if (row["C_QUALIRY_LEV"] != null)
                {
                    model.C_QUALIRY_LEV = row["C_QUALIRY_LEV"].ToString();
                }
                if (row["D_NEED_DT"] != null && row["D_NEED_DT"].ToString() != "")
                {
                    model.D_NEED_DT = DateTime.Parse(row["D_NEED_DT"].ToString());
                }
                if (row["D_DELIVERY_DT"] != null && row["D_DELIVERY_DT"].ToString() != "")
                {
                    model.D_DELIVERY_DT = DateTime.Parse(row["D_DELIVERY_DT"].ToString());
                }
                if (row["D_DT"] != null && row["D_DT"].ToString() != "")
                {
                    model.D_DT = DateTime.Parse(row["D_DT"].ToString());
                }
                if (row["C_LINE_DESC"] != null)
                {
                    model.C_LINE_DESC = row["C_LINE_DESC"].ToString();
                }
                if (row["C_LINE_CODE"] != null)
                {
                    model.C_LINE_CODE = row["C_LINE_CODE"].ToString();
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
                if (row["N_ROLL_PROD_WGT"] != null && row["N_ROLL_PROD_WGT"].ToString() != "")
                {
                    model.N_ROLL_PROD_WGT = decimal.Parse(row["N_ROLL_PROD_WGT"].ToString());
                }
                if (row["C_ROLL_PROD_EMP_ID"] != null)
                {
                    model.C_ROLL_PROD_EMP_ID = row["C_ROLL_PROD_EMP_ID"].ToString();
                }
                if (row["C_STL_ROL_DT"] != null)
                {
                    model.C_STL_ROL_DT = row["C_STL_ROL_DT"].ToString();
                }
                if (row["N_PROD_WGT"] != null && row["N_PROD_WGT"].ToString() != "")
                {
                    model.N_PROD_WGT = decimal.Parse(row["N_PROD_WGT"].ToString());
                }
                if (row["N_WARE_WGT"] != null && row["N_WARE_WGT"].ToString() != "")
                {
                    model.N_WARE_WGT = decimal.Parse(row["N_WARE_WGT"].ToString());
                }
                if (row["N_WARE_OUT_WGT"] != null && row["N_WARE_OUT_WGT"].ToString() != "")
                {
                    model.N_WARE_OUT_WGT = decimal.Parse(row["N_WARE_OUT_WGT"].ToString());
                }
                if (row["N_FLAG"] != null && row["N_FLAG"].ToString() != "")
                {
                    model.N_FLAG = decimal.Parse(row["N_FLAG"].ToString());
                }
                if (row["N_ISSUE_WGT"] != null && row["N_ISSUE_WGT"].ToString() != "")
                {
                    model.N_ISSUE_WGT = decimal.Parse(row["N_ISSUE_WGT"].ToString());
                }
                if (row["C_CUST_NO"] != null)
                {
                    model.C_CUST_NO = row["C_CUST_NO"].ToString();
                }
                if (row["C_CUST_NAME"] != null)
                {
                    model.C_CUST_NAME = row["C_CUST_NAME"].ToString();
                }
                if (row["C_SALE_CHANNEL"] != null)
                {
                    model.C_SALE_CHANNEL = row["C_SALE_CHANNEL"].ToString();
                }
                if (row["C_PACK"] != null)
                {
                    model.C_PACK = row["C_PACK"].ToString();
                }
                if (row["C_DESIGN_NO"] != null)
                {
                    model.C_DESIGN_NO = row["C_DESIGN_NO"].ToString();
                }
                if (row["N_GROUP_WGT"] != null && row["N_GROUP_WGT"].ToString() != "")
                {
                    model.N_GROUP_WGT = decimal.Parse(row["N_GROUP_WGT"].ToString());
                }
                if (row["C_STA_ID"] != null)
                {
                    model.C_STA_ID = row["C_STA_ID"].ToString();
                }
                if (row["D_START_TIME"] != null && row["D_START_TIME"].ToString() != "")
                {
                    model.D_START_TIME = DateTime.Parse(row["D_START_TIME"].ToString());
                }
                if (row["D_END_TIME"] != null && row["D_END_TIME"].ToString() != "")
                {
                    model.D_END_TIME = DateTime.Parse(row["D_END_TIME"].ToString());
                }
                if (row["C_EMP_ID"] != null)
                {
                    model.C_EMP_ID = row["C_EMP_ID"].ToString();
                }
                if (row["D_MOD_DT"] != null && row["D_MOD_DT"].ToString() != "")
                {
                    model.D_MOD_DT = DateTime.Parse(row["D_MOD_DT"].ToString());
                }
                if (row["N_ROLL_WGT"] != null && row["N_ROLL_WGT"].ToString() != "")
                {
                    model.N_ROLL_WGT = decimal.Parse(row["N_ROLL_WGT"].ToString());
                }
                if (row["N_MACH_WGT"] != null && row["N_MACH_WGT"].ToString() != "")
                {
                    model.N_MACH_WGT = decimal.Parse(row["N_MACH_WGT"].ToString());
                }
                if (row["C_CAST_NO"] != null)
                {
                    model.C_CAST_NO = row["C_CAST_NO"].ToString();
                }
                if (row["C_INITIALIZE_ID"] != null)
                {
                    model.C_INITIALIZE_ID = row["C_INITIALIZE_ID"].ToString();
                }
                if (row["C_FREE_TERM"] != null)
                {
                    model.C_FREE_TERM = row["C_FREE_TERM"].ToString();
                }
                if (row["C_FREE_TERM2"] != null)
                {
                    model.C_FREE_TERM2 = row["C_FREE_TERM2"].ToString();
                }
                if (row["C_AREA"] != null)
                {
                    model.C_AREA = row["C_AREA"].ToString();
                }
                if (row["C_PCLX"] != null)
                {
                    model.C_PCLX = row["C_PCLX"].ToString();
                }
                if (row["C_SFHL"] != null)
                {
                    model.C_SFHL = row["C_SFHL"].ToString();
                }
                if (row["D_HL_START_TIME"] != null && row["D_HL_START_TIME"].ToString() != "")
                {
                    model.D_HL_START_TIME = DateTime.Parse(row["D_HL_START_TIME"].ToString());
                }
                if (row["D_HL_END_TIME"] != null && row["D_HL_END_TIME"].ToString() != "")
                {
                    model.D_HL_END_TIME = DateTime.Parse(row["D_HL_END_TIME"].ToString());
                }
                if (row["C_SFHL_D"] != null)
                {
                    model.C_SFHL_D = row["C_SFHL_D"].ToString();
                }
                if (row["D_DHL_START_TIME"] != null && row["D_DHL_START_TIME"].ToString() != "")
                {
                    model.D_DHL_START_TIME = DateTime.Parse(row["D_DHL_START_TIME"].ToString());
                }
                if (row["D_DHL_END_TIME"] != null && row["D_DHL_END_TIME"].ToString() != "")
                {
                    model.D_DHL_END_TIME = DateTime.Parse(row["D_DHL_END_TIME"].ToString());
                }
                if (row["C_SFKP"] != null)
                {
                    model.C_SFKP = row["C_SFKP"].ToString();
                }
                if (row["D_KP_START_TIME"] != null && row["D_KP_START_TIME"].ToString() != "")
                {
                    model.D_KP_START_TIME = DateTime.Parse(row["D_KP_START_TIME"].ToString());
                }
                if (row["D_KP_END_TIME"] != null && row["D_KP_END_TIME"].ToString() != "")
                {
                    model.D_KP_END_TIME = DateTime.Parse(row["D_KP_END_TIME"].ToString());
                }
                if (row["C_SFXM"] != null)
                {
                    model.C_SFXM = row["C_SFXM"].ToString();
                }
                if (row["D_XM_START_TIME"] != null && row["D_XM_START_TIME"].ToString() != "")
                {
                    model.D_XM_START_TIME = DateTime.Parse(row["D_XM_START_TIME"].ToString());
                }
                if (row["D_XM_END_TIME"] != null && row["D_XM_END_TIME"].ToString() != "")
                {
                    model.D_XM_END_TIME = DateTime.Parse(row["D_XM_END_TIME"].ToString());
                }
                if (row["N_UPLOADSTATUS"] != null && row["N_UPLOADSTATUS"].ToString() != "")
                {
                    model.N_UPLOADSTATUS = decimal.Parse(row["N_UPLOADSTATUS"].ToString());
                }
                if (row["C_MATRL_CODE_SLAB"] != null)
                {
                    model.C_MATRL_CODE_SLAB = row["C_MATRL_CODE_SLAB"].ToString();
                }
                if (row["C_MATRL_NAME_SLAB"] != null)
                {
                    model.C_MATRL_NAME_SLAB = row["C_MATRL_NAME_SLAB"].ToString();
                }
                if (row["C_SLAB_SIZE"] != null)
                {
                    model.C_SLAB_SIZE = row["C_SLAB_SIZE"].ToString();
                }
                if (row["N_SLAB_LENGTH"] != null && row["N_SLAB_LENGTH"].ToString() != "")
                {
                    model.N_SLAB_LENGTH = decimal.Parse(row["N_SLAB_LENGTH"].ToString());
                }
                if (row["N_SLAB_PW"] != null && row["N_SLAB_PW"].ToString() != "")
                {
                    model.N_SLAB_PW = decimal.Parse(row["N_SLAB_PW"].ToString());
                }
                if (row["D_CAN_ROLL_TIME"] != null && row["D_CAN_ROLL_TIME"].ToString() != "")
                {
                    model.D_CAN_ROLL_TIME = DateTime.Parse(row["D_CAN_ROLL_TIME"].ToString());
                }
                if (row["C_ROUTE"] != null)
                {
                    model.C_ROUTE = row["C_ROUTE"].ToString();
                }
                if (row["N_DIAMETER"] != null && row["N_DIAMETER"].ToString() != "")
                {
                    model.N_DIAMETER = decimal.Parse(row["N_DIAMETER"].ToString());
                }
                if (row["C_XM_YQ"] != null)
                {
                    model.C_XM_YQ = row["C_XM_YQ"].ToString();
                }
                if (row["N_JRL_WD"] != null && row["N_JRL_WD"].ToString() != "")
                {
                    model.N_JRL_WD = decimal.Parse(row["N_JRL_WD"].ToString());
                }
                if (row["N_JRL_SJ"] != null && row["N_JRL_SJ"].ToString() != "")
                {
                    model.N_JRL_SJ = decimal.Parse(row["N_JRL_SJ"].ToString());
                }
                if (row["C_STL_GRD_SLAB"] != null)
                {
                    model.C_STL_GRD_SLAB = row["C_STL_GRD_SLAB"].ToString();
                }
                if (row["C_STD_CODE_SLAB"] != null)
                {
                    model.C_STD_CODE_SLAB = row["C_STD_CODE_SLAB"].ToString();
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
                if (row["N_GROUP"] != null && row["N_GROUP"].ToString() != "")
                {
                    model.N_GROUP = decimal.Parse(row["N_GROUP"].ToString());
                }
                if (row["C_XC"] != null)
                {
                    model.C_XC = row["C_XC"].ToString();
                }
                if (row["C_SL"] != null)
                {
                    model.C_SL = row["C_SL"].ToString();
                }
                if (row["C_WL"] != null)
                {
                    model.C_WL = row["C_WL"].ToString();
                }
                if (row["N_MACH_WGT_CCM"] != null && row["N_MACH_WGT_CCM"].ToString() != "")
                {
                    model.N_MACH_WGT_CCM = decimal.Parse(row["N_MACH_WGT_CCM"].ToString());
                }
                if (row["N_ZJCLS"] != null && row["N_ZJCLS"].ToString() != "")
                {
                    model.N_ZJCLS = decimal.Parse(row["N_ZJCLS"].ToString());
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
                if (row["C_BY4"] != null)
                {
                    model.C_BY4 = row["C_BY4"].ToString();
                }
                if (row["C_BY5"] != null)
                {
                    model.C_BY5 = row["C_BY5"].ToString();
                }
                if (row["C_LGJH"] != null)
                {
                    model.C_LGJH = row["C_LGJH"].ToString();
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
                if (row["N_SLAB_WIDTH"] != null && row["N_SLAB_WIDTH"].ToString() != "")
                {
                    model.N_SLAB_WIDTH = decimal.Parse(row["N_SLAB_WIDTH"].ToString());
                }
                if (row["N_SLAB_THICK"] != null && row["N_SLAB_THICK"].ToString() != "")
                {
                    model.N_SLAB_THICK = decimal.Parse(row["N_SLAB_THICK"].ToString());
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
                if (row["N_KPJRL_WD"] != null && row["N_KPJRL_WD"].ToString() != "")
                {
                    model.N_KPJRL_WD = decimal.Parse(row["N_KPJRL_WD"].ToString());
                }
                if (row["N_KPJRL_SJ"] != null && row["N_KPJRL_SJ"].ToString() != "")
                {
                    model.N_KPJRL_SJ = decimal.Parse(row["N_KPJRL_SJ"].ToString());
                }
                if (row["N_TSL"] != null && row["N_TSL"].ToString() != "")
                {
                    model.N_TSL = decimal.Parse(row["N_TSL"].ToString());
                }
                if (row["C_CCM_CODE"] != null)
                {
                    model.C_CCM_CODE = row["C_CCM_CODE"].ToString();
                }
                if (row["C_CCM_DESC"] != null)
                {
                    model.C_CCM_DESC = row["C_CCM_DESC"].ToString();
                }
                if (row["C_TL"] != null)
                {
                    model.C_TL = row["C_TL"].ToString();
                }
                if (row["N_ZJCLS_MIN"] != null && row["N_ZJCLS_MIN"].ToString() != "")
                {
                    model.N_ZJCLS_MIN = decimal.Parse(row["N_ZJCLS_MIN"].ToString());
                }
                if (row["N_ZJCLS_MAX"] != null && row["N_ZJCLS_MAX"].ToString() != "")
                {
                    model.N_ZJCLS_MAX = decimal.Parse(row["N_ZJCLS_MAX"].ToString());
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
                if (row["N_TYPE"] != null && row["N_TYPE"].ToString() != "")
                {
                    model.N_TYPE = decimal.Parse(row["N_TYPE"].ToString());
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
                if (row["C_CCM_ID"] != null)
                {
                    model.C_CCM_ID = row["C_CCM_ID"].ToString();
                }
                if (row["N_HL_TIME"] != null && row["N_HL_TIME"].ToString() != "")
                {
                    model.N_HL_TIME = decimal.Parse(row["N_HL_TIME"].ToString());
                }
                if (row["N_DFP_HL_TIME"] != null && row["N_DFP_HL_TIME"].ToString() != "")
                {
                    model.N_DFP_HL_TIME = decimal.Parse(row["N_DFP_HL_TIME"].ToString());
                }
                if (row["C_LF"] != null)
                {
                    model.C_LF = row["C_LF"].ToString();
                }
                if (row["C_KP"] != null)
                {
                    model.C_KP = row["C_KP"].ToString();
                }
                if (row["C_STL_GRD_CLASS"] != null)
                {
                    model.C_STL_GRD_CLASS = row["C_STL_GRD_CLASS"].ToString();
                }
                if (row["C_PRO_USE"] != null)
                {
                    model.C_PRO_USE = row["C_PRO_USE"].ToString();
                }
                if (row["C_CUST_SQ"] != null)
                {
                    model.C_CUST_SQ = row["C_CUST_SQ"].ToString();
                }
                if (row["C_TRANSMODE"] != null)
                {
                    model.C_TRANSMODE = row["C_TRANSMODE"].ToString();
                }
                if (row["C_REMARK1"] != null)
                {
                    model.C_REMARK1 = row["C_REMARK1"].ToString();
                }
                if (row["C_REMARK2"] != null)
                {
                    model.C_REMARK2 = row["C_REMARK2"].ToString();
                }
                if (row["C_REMARK3"] != null)
                {
                    model.C_REMARK3 = row["C_REMARK3"].ToString();
                }
                if (row["C_REMARK4"] != null)
                {
                    model.C_REMARK4 = row["C_REMARK4"].ToString();
                }
                if (row["C_REMARK5"] != null)
                {
                    model.C_REMARK5 = row["C_REMARK5"].ToString();
                }
                if (row["N_KZ_WGT"] != null && row["N_KZ_WGT"].ToString() != "")
                {
                    model.N_KZ_WGT = decimal.Parse(row["N_KZ_WGT"].ToString());
                }

            }
            return model;
        }


        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetListTrp(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();

            strSql.Append("select T.*  ");

            strSql.Append(" FROM TRP_PLAN_ROLL  T ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }

            strSql.Append("  ORDER BY T.D_DT ");


            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();

            strSql.Append("select TPR.*,ROUND(TPR.N_WGT/TPR.N_SLAB_PW) S ");

            strSql.Append(" FROM TRP_PLAN_ROLL_ITEM  TPR ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }

            strSql.Append("  ORDER BY TPR.D_P_START_TIME ");


            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 根据分组号和连铸主键获取可混交的钢坯信息
        /// </summary>
        /// <param name="N_GROUP">组号</param>
        /// <param name="C_CCM_ID">连铸主键</param>
        /// <returns></returns>
        public DataSet GetListByGroup(int N_GROUP, string C_CCM_ID)
        {
            StringBuilder strSql = new StringBuilder();

            strSql.Append("SELECT MAX(T.C_INITIALIZE_ITEM_ID) C_INITIALIZE_ITEM_ID, T.C_SFHL, T.C_SFHL_D, T.C_SFKP, T.C_SFXM, T.C_MATRL_CODE_SLAB, T.C_MATRL_NAME_SLAB, T.C_SLAB_SIZE, T.N_SLAB_LENGTH, T.N_SLAB_PW, T.C_ROUTE, T.C_XM_YQ, T.C_STL_GRD_SLAB, T.C_STD_CODE_SLAB, T.C_MATRL_CODE_KP, T.C_MATRL_NAME_KP, T.C_KP_SIZE, T.N_KP_LENGTH, T.N_KP_PW, T.N_GROUP, T.C_XC, T.C_SL, T.C_WL, T.N_MACH_WGT_CCM, T.N_ZJCLS, T.C_BY1, T.C_BY2, T.C_BY3, T.C_BY4, T.C_DFP_RZ, T.C_RZP_RZ, T.C_DFP_YQ, T.C_RZP_YQ, T.C_CCM_CODE, T.C_CCM_DESC, T.C_TL, T.N_ZJCLS_MIN, T.N_ZJCLS_MAX, T.C_STL_GRD_TYPE, T.C_PROD_NAME, T.C_PROD_KIND, T.N_TYPE, T.C_RH, T.C_DFP_HL, T.C_HL, T.C_XM, T.C_CCM_ID, T.N_HL_TIME, T.N_DFP_HL_TIME, T.C_LF, T.C_KP FROM TRP_PLAN_ROLL T ");
            strSql.Append("   WHERE N_GROUP =   " + N_GROUP);
            strSql.Append("   AND t.n_status IN (0,1) AND T.C_CCM_ID = '" + C_CCM_ID + "' GROUP BY T.C_SFHL, T.C_SFHL_D, T.C_SFKP, T.C_SFXM, T.C_MATRL_CODE_SLAB, T.C_MATRL_NAME_SLAB, T.C_SLAB_SIZE, T.N_SLAB_LENGTH, T.N_SLAB_PW, T.C_ROUTE, T.C_XM_YQ, T.C_STL_GRD_SLAB, T.C_STD_CODE_SLAB, T.C_MATRL_CODE_KP, T.C_MATRL_NAME_KP, T.C_KP_SIZE, T.N_KP_LENGTH, T.N_KP_PW, T.N_GROUP, T.C_XC, T.C_SL, T.C_WL, T.N_MACH_WGT_CCM, T.N_ZJCLS, T.C_BY1, T.C_BY2, T.C_BY3, T.C_BY4, T.C_DFP_RZ, T.C_RZP_RZ, T.C_DFP_YQ, T.C_RZP_YQ, T.C_CCM_CODE, T.C_CCM_DESC, T.C_TL, T.N_ZJCLS_MIN, T.N_ZJCLS_MAX, T.C_STL_GRD_TYPE, T.C_PROD_NAME, T.C_PROD_KIND, T.N_TYPE, T.C_RH, T.C_DFP_HL, T.C_HL, T.C_XM, T.C_CCM_ID, T.N_HL_TIME, T.N_DFP_HL_TIME, T.C_LF, T.C_KP   ORDER BY T.C_STL_GRD_SLAB, T.C_STD_CODE_SLAB, T.C_MATRL_CODE_SLAB  ");
            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM TRP_PLAN_ROLL ");
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
            strSql.Append(")AS Row, T.*  from TRP_PLAN_ROLL T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            return DbHelperOra.Query(strSql.ToString());
        }

        #endregion  BasicMethod
        #region  ExtensionMethod
        /// <summary>
        /// 获取方案记录总数
        /// </summary>
        public int GetFACount(string C_INITIALIZE_ITEM_ID, string C_STA_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM TRP_PLAN_ROLL WHERE N_STATUS= 0");
            if (C_INITIALIZE_ITEM_ID.Trim() != "")
            {
                strSql.Append(" AND C_INITIALIZE_ID='" + C_INITIALIZE_ITEM_ID + "'");
            }
            if (C_STA_ID.Trim() != "")
            {
                strSql.Append(" AND C_STA_ID='" + C_STA_ID + "'");
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
        /// 获得数据列表C_MATRL_CODE_SLAB, C_MATRL_NAME_SLAB, C_SLAB_SIZE,N_SLAB_LENGTH,N_SLAB_PW

        /// </summary>
        public DataSet GetList(int N_SORT, string C_INITIALIZE_ID, string C_STA_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * ");
            strSql.Append(" FROM TRP_PLAN_ROLL WHERE N_STATUS =0 AND N_ROLL_PROD_WGT <>0 ");
            if (C_INITIALIZE_ID.Trim() != "")
            {
                strSql.Append(" AND C_INITIALIZE_ID='" + C_INITIALIZE_ID + "' ");
            }
            if (N_SORT != 0)
            {
                strSql.Append(" AND N_SORT='" + N_SORT + "'");
            }
            if (C_STA_ID.Trim() != "")
            {
                strSql.Append(" AND C_STA_ID='" + C_STA_ID + "'");
            }
            strSql.Append(" ORDER BY N_SORT");
            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string C_INITIALIZE_ITEM_ID, string C_STA_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * ");
            strSql.Append(" FROM TRP_PLAN_ROLL WHERE N_STATUS =0 ");
            if (C_INITIALIZE_ITEM_ID.Trim() != "")
            {
                strSql.Append(" AND C_INITIALIZE_ITEM_ID='" + C_INITIALIZE_ITEM_ID + "' ");
            }
            if (C_STA_ID.Trim() != "全部")
            {
                strSql.Append(" AND C_STA_ID='" + C_STA_ID + "'");
            }
            strSql.Append(" ORDER BY C_STL_GRD,to_number(replace(C_SPEC, 'φ', ''))");
            return DbHelperOra.Query(strSql.ToString());
        }


        /// <summary>
        /// 根据订单主键获取下达的计划
        /// </summary>
        /// <param name="C_INITIALIZE_ITEM_ID">订单主键</param>
        /// <returns></returns>
        public DataSet GetListByOrderID(string C_INITIALIZE_ITEM_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * ");
            strSql.Append(" FROM TRP_PLAN_ROLL WHERE 1=1 ");
            if (C_INITIALIZE_ITEM_ID.Trim() != "")
            {
                strSql.Append(" AND C_INITIALIZE_ITEM_ID='" + C_INITIALIZE_ITEM_ID + "' ");
            }

            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(string c_id, string C_STA_ID, string C_INITIALIZE_ITEM_ID, int sort_new, int sort_old, string stype)
        {
            StringBuilder strSql = new StringBuilder();

            if (stype == "1")
            {
                strSql.Append(" update trp_plan_roll t set t.n_sort=t.n_sort+1 where t.c_id not in ('" + c_id + "') and C_STA_ID='" + C_STA_ID + "' and t.C_INITIALIZE_ITEM_ID='" + C_INITIALIZE_ITEM_ID + "' and t.n_sort>=" + sort_new + " and t.n_sort<=" + sort_old + " ");
            }

            if (stype == "0")
            {
                strSql.Append(" update trp_plan_roll t set t.n_sort=t.n_sort-1 where t.c_id not in ('" + c_id + "') and t.n_sort>" + sort_old + " and t.n_sort<=" + sort_new + " and C_STA_ID='" + C_STA_ID + "' and t.C_INITIALIZE_ITEM_ID='" + C_INITIALIZE_ITEM_ID + "' ");
            }


            int rows = DbHelperOra.ExecuteSql(strSql.ToString());
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
        public bool Update(string c_id, string C_STA_ID, string C_INITIALIZE_ITEM_ID, int sort_new)
        {
            StringBuilder strSql = new StringBuilder();

            strSql.Append(" update trp_plan_roll t set t.n_sort=" + sort_new + " where t.c_id = '" + c_id + "' and C_STA_ID='" + C_STA_ID + "' and t.C_INITIALIZE_ITEM_ID='" + C_INITIALIZE_ITEM_ID + "' ");


            int rows = DbHelperOra.ExecuteSql(strSql.ToString());
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
        public bool Update(string C_STA_ID, string C_INITIALIZE_ITEM_ID, int sort_old)
        {
            StringBuilder strSql = new StringBuilder();

            strSql.Append(" update trp_plan_roll t set t.n_sort=t.n_sort-1 where C_STA_ID='" + C_STA_ID + "' and t.C_INITIALIZE_ITEM_ID='" + C_INITIALIZE_ITEM_ID + "' and n_sort>" + sort_old + " ");


            int rows = DbHelperOra.ExecuteSql(strSql.ToString());
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
        public bool Update_CX(string c_id, string C_STA_ID, string C_INITIALIZE_ITEM_ID, int sort_new, string stype)
        {
            StringBuilder strSql = new StringBuilder();

            if (stype == "1")
            {
                strSql.Append(" update trp_plan_roll t set t.n_sort=t.n_sort+1 where t.c_id not in ('" + c_id + "') and C_STA_ID='" + C_STA_ID + "' and t.C_INITIALIZE_ID='" + C_INITIALIZE_ITEM_ID + "' and t.n_sort>=" + sort_new + " ");
            }

            if (stype == "0")
            {
                strSql.Append(" update trp_plan_roll t set t.n_sort=" + sort_new + ",C_STA_ID='" + C_STA_ID + "' where t.c_id = '" + c_id + "' and t.C_INITIALIZE_ID='" + C_INITIALIZE_ITEM_ID + "' ");
            }


            int rows = DbHelperOra.ExecuteSql(strSql.ToString());
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
        public Mod_TRP_PLAN_ROLL GetModel(int N_SORT, string C_INITIALIZE_ITEM_ID, string C_STA_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from TRP_PLAN_ROLL ");
            strSql.Append(" where N_SORT=" + N_SORT + " and C_INITIALIZE_ID='" + C_INITIALIZE_ITEM_ID + "' and C_STA_ID='" + C_STA_ID + "' ");

            Mod_TRP_PLAN_ROLL model = new Mod_TRP_PLAN_ROLL();
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
        /// 重新计算轧钢计划时间
        /// </summary>
        /// <param name="P_INITIALIZE_ITEM_ID">订单方案号</param>
        /// <returns></returns>
        public int ResetTime(string P_INITIALIZE_ITEM_ID)
        {
            OracleParameter[] parameters = {
                    new OracleParameter("P_INITIALIZE_ITEM_ID", OracleDbType.Varchar2,100)};

            parameters[0].Value = P_INITIALIZE_ITEM_ID;

            return DbHelperOra.RunProcedure("PKG_P_PLAN.P_UPDATE_ZG_PLAN_TIME", parameters);
        }

        /// <summary>
        /// 获得产线数据列表
        /// </summary>
        public DataSet GetCXList(decimal hours, string C_INITIALIZE_ITEM)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT a.N_CAPACITY * " + hours + " as N_CAPACITY, a.C_STA_ID, b.N_ROLL_PROD_WGT FROM TPB_STA_HISTORY_CAP a RIGHT JOIN(SELECT SUM(N_ROLL_PROD_WGT) AS N_ROLL_PROD_WGT, C_STA_ID, C_INITIALIZE_ID FROM TRP_PLAN_ROLL  GROUP BY C_STA_ID, C_INITIALIZE_ID HAVING C_INITIALIZE_ID = '" + C_INITIALIZE_ITEM + "') b ON a.C_STA_ID = b.C_STA_ID  WHERE a.N_STATUS=1");

            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得产线下钢种规格数据列表
        /// </summary>
        public DataSet GetGZList(string C_STA_ID, string C_INITIALIZE_ITEM)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select T.C_STA_ID,sum(T.N_WGT) as N_WGT,T.C_STL_GRD,T.C_STD_CODE,T.C_SPEC from trp_plan_roll t WHERE 1=1");
            if (C_INITIALIZE_ITEM.Trim() != "")
            {
                strSql.Append(" AND t.C_INITIALIZE_ID='" + C_INITIALIZE_ITEM + "' ");
            }
            if (C_STA_ID.Trim() != "")
            {
                strSql.Append(" AND T.C_STA_ID='" + C_STA_ID + "'");
            }
            strSql.Append(" group by T.C_STA_ID, T.C_STL_GRD, T.C_STD_CODE, T.C_SPEC");
            strSql.Append(" ORDER by T.C_STL_GRD, T.C_STD_CODE,to_number(replace(T.C_SPEC, 'φ', ''))");
            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 重新计算炼钢计划时间
        /// </summary>
        /// <param name="P_INITIALIZE_ITEM_ID">订单方案号</param>
        /// <returns></returns>
        public int ZGPC(string P_INITIALIZE_ITEM_ID)
        {
            OracleParameter[] parameters = {
                    new OracleParameter("P_INITIALIZE_ITEM_ID", OracleDbType.Varchar2,100)};

            parameters[0].Value = P_INITIALIZE_ITEM_ID;

            return DbHelperOra.RunProcedure("pkg_p_plan.P_UPDATE_LG_PLAN_TIME", parameters);
        }

        /// <summary>
        /// 修改组批量
        /// </summary>
        /// <returns></returns>
        public int UpdateGroupWgt(string id, decimal? wgt)
        {
            string sql = @"UPDATE TRP_PLAN_ROLL_ITEM TPR
                                    SET TPR.N_GROUP_WGT=TPR.N_GROUP_WGT+:wgt
                                    ,TPR.N_STATUS=2
                                    WHERE TPR.C_ID=:id  AND (TPR.N_STATUS=1 OR TPR.N_STATUS=2  ) ";

            OracleParameter[] parameters = {
                    new OracleParameter(":wgt", OracleDbType.Decimal,2),
                    new OracleParameter(":id", OracleDbType.Varchar2,100),
            };
            parameters[0].Value = wgt;
            parameters[1].Value = id;

            return TransactionHelper.ExecuteSql(sql, parameters);
        }

        /// <summary>
        /// 修改组批量(撤回)
        /// </summary>
        /// <returns></returns>
        public int BackOutGroupWgt(string id, decimal wgt)
        {
            string sql = @"UPDATE TRP_PLAN_ROLL_ITEM TPR
                                    SET  TPR.N_GROUP_WGT=TPR.N_GROUP_WGT-:wgt
                                    WHERE TPR.C_ID=:id";


            OracleParameter[] parameters = {
                    new OracleParameter(":wgt", OracleDbType.Decimal,2),
                    new OracleParameter(":id", OracleDbType.Varchar2,100),
            };
            parameters[0].Value = wgt;
            parameters[1].Value = id;

            string sql2 = @"UPDATE TRP_PLAN_ROLL_ITEM T SET T.N_GROUP_WGT = 0 WHERE T.C_ID = '" + id + "' AND T.N_GROUP_WGT < 0";

            int result = TransactionHelper.ExecuteSql(sql, parameters);

            TransactionHelper.ExecuteSql(sql2);

            return result;
        }

        /// <summary>
        /// 自动排产计划
        /// </summary>
        /// <param name="P_INITIALIZE_ITEM_ID">订单方案号</param>
        /// <returns></returns>
        public int Add_ZG_Plan(string P_INITIALIZE_ID)
        {
            OracleParameter[] parameters = {
                    new OracleParameter("P_INITIALIZE_ID", OracleDbType.Varchar2,100)};

            parameters[0].Value = P_INITIALIZE_ID;

            return DbHelperOra.RunProcedure("pkg_roll_plan.P_ADD_ZG_PLAN", parameters);
        }


        /// <summary>
        /// 获取用自由坯的排产量
        /// </summary>
        /// <param name="C_INITIALIZE_ITEM_ID">订单表主键</param>
        /// <param name="C_INITIALIZE_ID">自由坯标识 1 </param>
        /// <returns></returns>
        public decimal GetZYPWgt(string C_INITIALIZE_ITEM_ID, string C_INITIALIZE_ID)
        {
            string sql = @"SELECT NVL(SUM(T.N_WGT), 0) N_WGT
  FROM TRP_PLAN_ROLL T
 WHERE T.C_INITIALIZE_ITEM_ID = '" + C_INITIALIZE_ITEM_ID + "'  AND T.C_INITIALIZE_ID = '" + C_INITIALIZE_ID + "'";
            return Convert.ToDecimal(DbHelperOra.Query(sql).Tables[0].Rows[0]["N_WGT"]);
        }


        /// <summary>
        /// 查询轧钢计划
        /// </summary>
        /// <param name="C_STA_ID">轧线主键</param>
        /// <param name="N_STATUS">计划状态</param>
        /// <param name="C_STL_GRD">钢种</param>
        /// <param name="C_SPEC">规格</param>
        /// <param name="C_STD_CODE">执行标准</param>
        /// <param name="C_ISZP">是否组批Y/N</param>
        /// <returns>轧钢计划</returns>
        public DataSet GetZGJH(string C_STA_ID, int? N_STATUS, string C_STL_GRD, string C_SPEC, string C_STD_CODE, string C_ISZP)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select *  ");
            strSql.Append(" FROM TRP_PLAN_ROLL   WHERE 1=1 ");
            if (N_STATUS != null)
            {
                if (N_STATUS == 6)
                {
                    strSql.Append("  AND N_STATUS in (0,6) ");
                }
                else
                {
                    strSql.Append("  AND N_STATUS=" + N_STATUS);
                }
            }
            if (C_ISZP.Trim() == "Y")
            {
                strSql.Append("  AND N_GROUP_WGT>0");
            }
            else
            {
                strSql.Append("  AND N_GROUP_WGT=0");
            }
            if (C_STA_ID.Trim() != "")
            {
                strSql.Append("  AND C_STA_ID='" + C_STA_ID + "'");
            }
            if (C_STL_GRD.Trim() != "")
            {
                strSql.Append("  AND C_STL_GRD='" + C_STL_GRD + "'");
            }
            if (C_SPEC.Trim() != "")
            {
                strSql.Append("  AND C_SPEC='" + C_SPEC + "'");
            }
            if (C_STD_CODE.Trim() != "")
            {
                strSql.Append("  AND C_STD_CODE='" + C_STD_CODE + "'");
            }
            strSql.Append("  ORDER BY C_STA_ID, N_SORT,D_P_START_TIME");
            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 返回当前产线的新的开始排序号
        /// </summary>
        /// <param name="C_STA_ID">产线主键</param>
        /// <returns>开始序号</returns>
        public int GetMaxSort(string C_STA_ID)
        {
            string sql = "SELECT NVL(MAX(T.N_SORT), 0) N_SORT  FROM TRP_PLAN_ROLL T WHERE T.C_STA_ID = '" + C_STA_ID + "'";
            return Convert.ToInt32(DbHelperOra.Query(sql.ToString()).Tables[0].Rows[0]["N_SORT"].ToString()) + 1;
        }


        public void DeletePlan(string C_ID)
        {


        }

        /// <summary>
        /// 获取未下发计划最大规格
        /// </summary>
        public string Get_Spec_Max(string c_line_code)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select max(to_number(substr(t.c_spec,2)))as spec_max from TRP_PLAN_ROLL t where t.n_group_wgt<t.n_wgt*0.9 and t.n_status=0 and t.c_line_code='" + c_line_code + "'");

            object obj = DbHelperOra.GetSingle(strSql.ToString());
            if (obj == null)
            {
                return "";
            }
            else
            {
                return obj.ToString();
            }
        }

        /// <summary>
        /// 获取未下发计划最小规格
        /// </summary>
        public string Get_Spec_Min(string c_line_code)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select min(to_number(substr(t.c_spec,2)))as spec_min from TRP_PLAN_ROLL t where t.n_group_wgt<t.n_wgt*0.9 and t.n_status=0 and t.c_line_code='" + c_line_code + "'");

            object obj = DbHelperOra.GetSingle(strSql.ToString());
            if (obj == null)
            {
                return "";
            }
            else
            {
                return obj.ToString();
            }
        }


        /// <summary>
        /// 按钢种和执行标准查询未下发计划的轧线
        /// </summary>
        public DataSet Get_Line_Lsit_Trans()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT T.C_LINE_CODE,T.C_STA_ID FROM TRP_PLAN_ROLL T WHERE t.c_line_code is not null and T.N_STATUS in (0,1) AND T.N_ISSUE_WGT < T.N_WGT GROUP BY T.C_LINE_CODE,T.C_STA_ID ORDER BY T.C_LINE_CODE ");

            return TransactionHelper.Query(strSql.ToString());
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Mod_TRP_PLAN_ROLL GetModel_Trans(string c_stl_grd, string c_std_code, string C_LINE_CODE, string C_SPEC)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * FROM (SELECT * FROM TRP_PLAN_ROLL T ");

            strSql.Append(" WHERE T.N_GROUP_WGT < T.N_WGT * 0.9 AND T.N_STATUS = 0 AND T.C_LINE_CODE = '" + C_LINE_CODE + "' ");

            if (!string.IsNullOrEmpty(c_stl_grd))
            {
                strSql.Append(" AND T.C_STL_GRD = '" + c_stl_grd + "' ");
            }

            if (!string.IsNullOrEmpty(c_std_code))
            {
                strSql.Append(" AND T.C_STD_CODE = '" + c_std_code + "' ");
            }

            if (!string.IsNullOrEmpty(C_SPEC))
            {
                strSql.Append(" AND T.C_SPEC = '" + C_SPEC + "' ");
            }

            strSql.Append(" ORDER BY TO_NUMBER(SUBSTR(T.C_SPEC, 2)), T.D_NEED_DT) WHERE ROWNUM = 1 ");

            Mod_TRP_PLAN_ROLL model = new Mod_TRP_PLAN_ROLL();
            DataSet ds = TransactionHelper.Query(strSql.ToString());
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
        /// 获取前两个计划
        /// </summary>
        public DataSet Get_Up_Plan_Trans(string c_line_code, int rowNum)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from( select * from trp_plan_roll t where t.c_line_code='" + c_line_code + "' AND T.D_P_END_TIME IS NOT NULL order by t.d_p_End_Time desc) where rownum<=" + rowNum + " ");

            return TransactionHelper.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取最大顺序号
        /// </summary>
        public int Get_Max_Sort(string c_line_code)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT MAX(T.N_SORT) FROM TRP_PLAN_ROLL T WHERE T.C_LINE_CODE = '" + c_line_code + "'");

            object obj = TransactionHelper.GetSingle(strSql.ToString());
            if (obj == null)
            {
                return 0;
            }
            else
            {
                return Convert.ToInt32(obj.ToString());
            }
        }

        /// <summary>
        /// 获取最大顺序号
        /// </summary>
        public int Get_Max_Sort_ByState(string c_line_code)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT MAX(T.N_SORT) FROM TRP_PLAN_ROLL T WHERE t.N_STATUS <> 0 and T.C_LINE_CODE = '" + c_line_code + "'");

            object obj = DbHelperOra.GetSingle(strSql.ToString());
            if (obj == null)
            {
                return 0;
            }
            else
            {
                return Convert.ToInt32(obj.ToString());
            }
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update_Trans(string c_line_code)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TRP_PLAN_ROLL set N_SORT=0 where N_STATUS in (0,5)  and C_LINE_CODE = '" + c_line_code + "' ");

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


        /// <summary>
        /// 查询轧钢计划
        /// </summary>
        /// <param name="C_LINT_ID">产线</param>
        /// <param name="N_STATUS">是否排产</param>
        /// <param name="C_ORDER_NO">订单号</param>
        /// <param name="C_STL_GRD">钢种</param>
        /// <param name="C_STD_CODE">执行标准</param>
        /// <param name="D_SPEC_MIN">规格最小</param>
        /// <param name="D_SPEC_MAX">规格最大</param>
        /// <param name="C_CUST_NAME">客户名称</param>
        /// <param name="C_JQ_MIN">交货日期最小</param>
        /// <param name="C_JQ_MAX">交货日期最大</param>
        /// <param name="C_DD_MIN">订单日期最小</param>
        /// <param name="C_DD_MAX">订单日期最大</param>
        /// <returns>轧钢计划</returns>
        public DataSet GetZGPlan(string C_LINT_ID, int? N_STATUS, string C_ORDER_NO, string C_STL_GRD, string C_STD_CODE, double? D_SPEC_MIN, double? D_SPEC_MAX, string C_CUST_NAME, string C_JQ_MIN, string C_JQ_MAX, string C_DD_MIN, string C_DD_MAX)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * ");
            strSql.Append(" FROM TRP_PLAN_ROLL T WHERE N_TYPE=8 ");

            if (C_LINT_ID.Trim() != "")
            {
                strSql.Append(" AND  C_STA_ID='" + C_LINT_ID + "' ");
            }

            if (N_STATUS != null)
            {
                if (N_STATUS == 1)//已确认排产
                {
                    strSql.Append(" AND  N_STATUS=1 ");
                }
                if (N_STATUS == 0)//未确认完排产
                {
                    strSql.Append(" AND   N_STATUS=0 ");
                }
            }
            if (C_ORDER_NO.Trim() != "")
            {
                strSql.Append(" AND   C_ORDER_NO  LIKE '%" + C_ORDER_NO + "%'");
            }

            if (C_STL_GRD.Trim() != "")
            {
                strSql.Append(" AND   C_STL_GRD LIKE '%" + C_STL_GRD + "%'");
            }

            if (C_STD_CODE.Trim() != "")
            {
                strSql.Append(" AND   C_STD_CODE LIKE '%" + C_STD_CODE + "%'");
            }

            if (D_SPEC_MIN != null)
            {
                strSql.Append("   AND ((T.C_SPEC LIKE '%φ%' AND TO_NUMBER(REPLACE(T.C_SPEC, 'φ', '')) >= " + D_SPEC_MIN + ") OR  (T.C_SPEC LIKE '%*%' AND TO_NUMBER(GET_STRARRAYSTROFINDEX(T.C_SPEC, '*', 0)) >= " + D_SPEC_MIN + "))");
            }

            if (D_SPEC_MAX != null)
            {
                strSql.Append("   AND ((T.C_SPEC LIKE '%φ%' AND TO_NUMBER(REPLACE(T.C_SPEC, 'φ', '')) <= " + D_SPEC_MAX + ") OR  (T.C_SPEC LIKE '%*%' AND TO_NUMBER(GET_STRARRAYSTROFINDEX(T.C_SPEC, '*', 0)) <= " + D_SPEC_MAX + "))");
            }

            if (C_CUST_NAME.Trim() != "")
            {
                strSql.Append(" AND   C_CUST_NAME LIKE  '%" + C_CUST_NAME + "%'");
            }

            if (C_JQ_MIN.Trim() != "")
            {
                strSql.Append(" AND  D_DELIVERY_DT >=TO_DATE('" + C_JQ_MIN + "','yyyy-mm-dd hh24:mi:ss')");
            }
            if (C_JQ_MAX.Trim() != "")
            {
                strSql.Append("  AND  D_DELIVERY_DT <=TO_DATE('" + C_JQ_MAX + "','yyyy-mm-dd hh24:mi:ss')");
            }

            if (C_DD_MIN.Trim() != "")
            {
                strSql.Append(" AND  D_DT >=TO_DATE('" + C_DD_MIN + "','yyyy-mm-dd hh24:mi:ss')");
            }
            if (C_DD_MAX.Trim() != "")
            {
                strSql.Append("  AND  D_DT <=TO_DATE('" + C_DD_MAX + "','yyyy-mm-dd hh24:mi:ss')");
            }

            strSql.Append(" ORDER BY substr(C_LINE_CODE,1,1),D_P_START_TIME");
            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 查询炼钢钢计划
        /// </summary>
        /// <param name="C_CCM_ID">连铸</param>
        /// <param name="N_STATUS">是否排产</param>
        /// <param name="C_ORDER_NO">订单号</param>
        /// <param name="C_STL_GRD">钢种</param>
        /// <param name="C_STD_CODE">执行标准</param>
        /// <param name="C_DD_MIN">订单日期最小</param>
        /// <param name="C_DD_MAX">订单日期最大</param>
        /// <returns>炼钢计划</returns>
        public DataSet GetLGPlan(string C_CCM_ID, int? N_STATUS, string C_ORDER_NO, string C_STL_GRD, string C_STD_CODE, string C_DD_MIN)
        {

            DateTime dt1 = System.DateTime.Now;
            DateTime dt = DateTime.Now.AddDays(1 - DateTime.Now.Day).Date;//本月第一天

            int dayC = (dt1 - dt).Days;
            if (dayC > 10)
            {
                C_DD_MIN = DateTime.Now.AddDays(1 - DateTime.Now.Day).Date.ToShortDateString();
            }
            else
            {
                C_DD_MIN = DateTime.Now.AddDays(1 - DateTime.Now.Day).Date.AddDays(-11).ToShortDateString();
            }

            StringBuilder strSql = new StringBuilder();
            strSql.Append(@"SELECT T.*, M.N_SLAB_WGT
  FROM TRP_PLAN_ROLL T
  LEFT JOIN(SELECT SUM(A.N_WGT) AS N_SLAB_WGT, C_STL_GRD, C_STD_CODE
               FROM TSC_SLAB_MAIN A
              WHERE A.C_MOVE_TYPE IN('E', 'M', 'DZ', 'NP', 'R', 'DX')
              GROUP BY C_STL_GRD, C_STD_CODE) M
    ON T.C_STL_GRD_SLAB = M.C_STL_GRD
   AND T.C_STD_CODE_SLAB = M.C_STD_CODE ");
            strSql.Append("  WHERE 1=1");

            if (N_STATUS == 0)
            {
                strSql.Append(" AND N_STATUS IN (0,1) ");
            }
            if (N_STATUS == 1)
            {
                strSql.Append(" AND N_STATUS =2 ");
            }
            if (C_CCM_ID.Trim() != "")
            {
                strSql.Append(" AND  C_CCM_ID='" + C_CCM_ID + "' ");
            }

            if (C_ORDER_NO.Trim() != "")
            {
                strSql.Append(" AND   C_ORDER_NO  LIKE '%" + C_ORDER_NO + "%'");
            }

            if (C_STL_GRD.Trim() != "")
            {
                strSql.Append(" AND   C_STL_GRD_SLAB LIKE '%" + C_STL_GRD + "%'");
            }

            if (C_STD_CODE.Trim() != "")
            {
                strSql.Append(" AND   C_STD_CODE_SLAB LIKE '%" + C_STD_CODE + "%'");
            }

            if (C_DD_MIN.Trim() != "")
            {
                strSql.Append(" AND  D_DT >=TO_DATE('" + C_DD_MIN + "','yyyy-mm-dd hh24:mi:ss')");
            }
            //if (C_DD_MAX.Trim() != "")
            //{
            //    strSql.Append("  AND  D_DT <=TO_DATE('" + C_DD_MAX + "','yyyy-mm-dd hh24:mi:ss')");
            //}

            strSql.Append(" ORDER BY substr(C_CCM_CODE,1,1),N_GROUP,C_STL_GRD_SLAB,C_STD_CODE_SLAB ");
            return DbHelperOra.Query(strSql.ToString());
        }


        /// <summary>
        /// 查询炼钢钢计划
        /// </summary>
        /// <param name="C_CCM_ID">连铸</param>
        /// <param name="N_STATUS">是否排产</param>
        /// <param name="C_ORDER_NO">订单号</param>
        /// <param name="C_STL_GRD">钢种</param>
        /// <param name="C_STD_CODE">执行标准</param>
        /// <param name="D_SPEC_MIN">规格最小</param>
        /// <param name="D_SPEC_MAX">规格最大</param>
        /// <param name="C_CUST_NAME">客户名称</param>
        /// <param name="C_JQ_MIN">交货日期最小</param>
        /// <param name="C_JQ_MAX">交货日期最大</param>
        /// <param name="C_DD_MIN">订单日期最小</param>
        /// <param name="C_DD_MAX">订单日期最大</param>
        /// <returns>炼钢计划</returns>
        public DataSet GetLGPlan(string C_CCM_ID, int? N_STATUS, string C_ORDER_NO, string C_STL_GRD, string C_STD_CODE, double? D_SPEC_MIN, double? D_SPEC_MAX, string C_CUST_NAME, string C_JQ_MIN, string C_JQ_MAX, string C_DD_MIN, string C_DD_MAX)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * ");
            strSql.Append(" FROM TRP_PLAN_ROLL T WHERE 1=1");

            if (N_STATUS == 0)
            {
                strSql.Append(" AND N_STATUS IN (0,1) ");
            }
            if (N_STATUS == 1)
            {
                strSql.Append(" AND N_STATUS IN (2,3) ");
            }
            if (C_CCM_ID.Trim() != "")
            {
                strSql.Append(" AND  C_CCM_ID='" + C_CCM_ID + "' ");
            }

            if (C_ORDER_NO.Trim() != "")
            {
                strSql.Append(" AND   C_ORDER_NO  LIKE '%" + C_ORDER_NO + "%'");
            }

            if (C_STL_GRD.Trim() != "")
            {
                strSql.Append(" AND   C_STL_GRD_SLAB LIKE '%" + C_STL_GRD + "%'");
            }

            if (C_STD_CODE.Trim() != "")
            {
                strSql.Append(" AND   C_STD_CODE_SLAB LIKE '%" + C_STD_CODE + "%'");
            }

            if (D_SPEC_MIN != null)
            {
                strSql.Append("   AND ((T.C_SPEC LIKE '%φ%' AND TO_NUMBER(REPLACE(T.C_SPEC, 'φ', '')) >= " + D_SPEC_MIN + ") OR  (T.C_SPEC LIKE '%*%' AND TO_NUMBER(GET_STRARRAYSTROFINDEX(T.C_SPEC, '*', 0)) >= " + D_SPEC_MIN + "))");
            }

            if (D_SPEC_MAX != null)
            {
                strSql.Append("   AND ((T.C_SPEC LIKE '%φ%' AND TO_NUMBER(REPLACE(T.C_SPEC, 'φ', '')) <= " + D_SPEC_MAX + ") OR  (T.C_SPEC LIKE '%*%' AND TO_NUMBER(GET_STRARRAYSTROFINDEX(T.C_SPEC, '*', 0)) <= " + D_SPEC_MAX + "))");
            }

            if (C_CUST_NAME.Trim() != "")
            {
                strSql.Append(" AND   C_CUST_NAME LIKE  '%" + C_CUST_NAME + "%'");
            }

            if (C_JQ_MIN.Trim() != "")
            {
                strSql.Append(" AND  D_DELIVERY_DT >=TO_DATE('" + C_JQ_MIN + "','yyyy-mm-dd hh24:mi:ss')");
            }
            if (C_JQ_MAX.Trim() != "")
            {
                strSql.Append("  AND  D_DELIVERY_DT <=TO_DATE('" + C_JQ_MAX + "','yyyy-mm-dd hh24:mi:ss')");
            }

            if (C_DD_MIN.Trim() != "")
            {
                strSql.Append(" AND  D_DT >=TO_DATE('" + C_DD_MIN + "','yyyy-mm-dd hh24:mi:ss')");
            }
            if (C_DD_MAX.Trim() != "")
            {
                strSql.Append("  AND  D_DT <=TO_DATE('" + C_DD_MAX + "','yyyy-mm-dd hh24:mi:ss')");
            }

            strSql.Append(" ORDER BY substr(C_CCM_CODE,1,1),N_GROUP,C_STL_GRD_SLAB,C_STD_CODE_SLAB ");
            return DbHelperOra.Query(strSql.ToString());
        }


        /// <summary>
        /// 系统对轧钢计划重新划分产线
        /// </summary>
        /// <returns></returns>
        public string GetLine()
        {
            OracleParameter[] parameters = {
            new OracleParameter("P_MSG", OracleDbType.Varchar2,500)};
            parameters[0].Value = "失败";
            return DbHelperOra.RunProcedureOut("PKG_UPDATE_SORT.P_ZG_PLAN_LINE", parameters);
        }

        /// <summary>
        /// 手动调整产线
        /// </summary>
        /// <param name="P_ID">计划主键</param>
        /// <param name="LINE_ID">产线主键</param>
        /// <returns>成功1失败0</returns>
        public string GetLineByID(string P_ID, string LINE_ID)
        {
            OracleParameter[] parameters = {
            new OracleParameter("P_MSG", OracleDbType.Varchar2,500),
             new OracleParameter("P_ID", OracleDbType.Varchar2,50),
              new OracleParameter("P_LINE_NO", OracleDbType.Varchar2,50)
            };
            parameters[0].Value = "0";
            parameters[1].Value = P_ID;
            parameters[2].Value = LINE_ID;
            return DbHelperOra.RunProcedureOut("PKG_UPDATE_SORT.P_ZG_PLAN_LINE_BYID", parameters);
        }

        /// <summary>
        /// 根据线材订单手动划分产线
        /// </summary>
        /// <param name="P_STL_GRD">钢种</param>
        /// <param name="P_SPEC">规格</param>
        /// <param name="P_STD_CODE">执行标准</param>
        /// <param name="P_LINE_NO">产线</param>
        /// <returns>划分结果</returns>
        public string ChangeLineByplan(string P_STL_GRD, string P_SPEC, string P_STD_CODE, string P_LINE_NO)
        {
            OracleParameter[] parameters = {
            new OracleParameter("P_MSG", OracleDbType.Varchar2,500),
             new OracleParameter("P_STL_GRD", OracleDbType.Varchar2,50),
              new OracleParameter("P_SPEC", OracleDbType.Varchar2,50),
              new OracleParameter("P_STD_CODE", OracleDbType.Varchar2,50),
              new OracleParameter("P_LINE_NO", OracleDbType.Varchar2,50)
            };
            parameters[0].Value = "0";
            parameters[1].Value = P_STL_GRD;
            parameters[2].Value = P_SPEC;
            parameters[3].Value = P_STD_CODE;
            parameters[4].Value = P_LINE_NO;
            return DbHelperOra.RunProcedureOut("PKG_UPDATE_SORT.P_CHANGE_LINE", parameters);
        }

        /// <summary>
        /// 获取轧钢计划中未维护机时产能的数据
        /// </summary>
        /// <returns></returns>
        public DataTable GetNJSCN()
        {
            string sql = "SELECT  Distinct t.C_STA_ID,t.c_line_desc,t.c_stl_grd,t.c_spec,t.n_mach_wgt FROM tRP_plan_roll t WHERE t.n_status=0  AND T.N_TYPE=8  AND t.n_mach_wgt=0 AND t.C_STA_ID IS NOT NULL ORDER BY t.C_STA_ID,to_number(REPLACE( t.c_spec,'φ',''))";
            return DbHelperOra.Query(sql).Tables[0];
        }



        /// <summary>
        /// 按订单钢种规格统计轧钢计划
        /// </summary>
        /// <param name="C_STA_ID">产线主键 全部时传all</param>
        /// <param name="C_SPEC">订单规格</param>
        /// <returns>查询未排产订单</returns>
        public DataTable GetNJSCN(string C_STA_ID, string C_SPEC)
        {
            string sql = @"SELECT T.C_STA_ID,
       T.C_LINE_CODE,
T.C_LINE_DESC,
       T.C_STL_GRD,
       T.C_STD_CODE,
       T.C_SPEC,
       T.N_MACH_WGT,
       SUM(T.N_WGT) N_WGT
  FROM TRP_PLAN_ROLL T
 WHERE T.N_STATUS = 0 AND T.N_TYPE=8  ";
            if (C_STA_ID.Trim() != "")
            {

                if (C_STA_ID.Trim() != "all")
                {
                    sql = sql + " AND T.C_STA_ID='" + C_STA_ID + "'";
                }

            }
            else
            {
                sql = sql + " AND T.C_STA_ID IS NULL ";
            }

            if (C_SPEC.Trim() != "")
            {
                sql = sql + " AND T.C_SPEC  LIKE '%" + C_SPEC + "%'";

            }

            sql = sql + @" GROUP BY T.C_STA_ID, T.C_LINE_CODE,T.C_LINE_DESC, T.C_STL_GRD,T.C_STD_CODE, T.C_SPEC, T.N_MACH_WGT
 ORDER BY T.C_STA_ID,
          --TO_NUMBER(REPLACE(T.C_SPEC, 'φ', '')),
          T.C_STL_GRD,
          T.C_STD_CODE";
            return DbHelperOra.Query(sql).Tables[0];
        }


        /// <summary>
        /// 按订单钢种规格统计轧钢计划
        /// </summary>
        /// <param name="C_STA_ID">产线主键 全部时传all</param>
        /// <returns>查询未排产订单</returns>
        public DataTable GetLineGZ(string C_STA_ID)
        {
            string sql = @"SELECT T.C_STA_ID,
       T.C_LINE_DESC,
       T.C_STL_GRD,
       T.C_STD_CODE,
       SUM(T.N_WGT) N_WGT
  FROM TRP_PLAN_ROLL T
 WHERE T.N_STATUS = 0  AND T.N_TYPE=8 ";
            if (C_STA_ID.Trim() != "")
            {
                sql = sql + " AND T.C_STA_ID='" + C_STA_ID + "'";

            }
            sql = sql + @" GROUP BY T.C_STA_ID, T.C_LINE_DESC, T.C_STL_GRD,T.C_STD_CODE
 ORDER BY T.C_STA_ID,
          T.C_STL_GRD,
          T.C_STD_CODE";
            return DbHelperOra.Query(sql).Tables[0];
        }

        /// <summary>
        /// 维护计划轧钢机时产能
        /// </summary>
        /// <param name="P_LINT_ID">产线主键</param>
        /// <param name="P_STL_GRD">钢种</param>
        /// <param name="P_SPEC">规格</param>
        /// <param name="P_MACH_WGT">机时产能</param>
        /// <param name="P_SFGX">是否更新到机时产能基础表</param>
        /// <returns>是否成功1，0失败</returns>
        public string UpdatePlanJSCN(string P_LINT_ID, string P_STL_GRD, string P_SPEC, decimal P_MACH_WGT, string P_SFGX)
        {
            OracleParameter[] parameters = {
            new OracleParameter("P_MSG", OracleDbType.Varchar2,500),
             new OracleParameter("P_LINT_ID", OracleDbType.Varchar2,50),
              new OracleParameter("P_STL_GRD", OracleDbType.Varchar2,50),
             new OracleParameter("P_SPEC", OracleDbType.Varchar2,50),
              new OracleParameter("P_MACH_WGT", OracleDbType.Decimal),
             new OracleParameter("P_SFGX", OracleDbType.Varchar2,50)
            };
            parameters[0].Value = "0";
            parameters[1].Value = P_LINT_ID;
            parameters[2].Value = P_STL_GRD;
            parameters[3].Value = P_SPEC;
            parameters[4].Value = P_MACH_WGT;
            parameters[5].Value = P_SFGX;
            return DbHelperOra.RunProcedureOut("PKG_UPDATE_SORT.P_ZG_JSCN", parameters);
        }

        /// <summary>
        /// 按产线规格统计订单
        /// </summary>
        /// <param name="C_STA_ID">产线主键 全部时传all</param>
        /// <param name="C_SPEC">规格</param>
        /// <returns>统计数据</returns>
        public DataTable GetWgtByLineAndGG(string C_STA_ID, string C_SPEC)
        {
            string sql = @"SELECT T.C_STA_ID,
       T.C_LINE_DESC,
       T.C_SPEC,
       SUM(T.N_WGT) N_WGT
  FROM TRP_PLAN_ROLL T
 WHERE T.N_STATUS = 0  AND T.N_TYPE=8 ";
            if (C_STA_ID.Trim() != "")
            {

                if (C_STA_ID.Trim() != "all")
                {
                    sql = sql + " AND T.C_STA_ID='" + C_STA_ID + "'";
                }

            }
            else
            {
                sql = sql + " AND T.C_STA_ID IS NULL ";
            }

            if (C_SPEC.Trim() != "")
            {
                sql = sql + " AND T.C_SPEC  LIKE '%" + C_SPEC + "%'";

            }

            sql = sql + @"  GROUP BY T.C_STA_ID, T.C_LINE_DESC, T.C_SPEC
 ORDER BY T.C_STA_ID, TO_NUMBER(REPLACE(T.C_SPEC, 'φ', ''))";
            return DbHelperOra.Query(sql).Tables[0];
        }

        /// <summary>
        /// 按产线规格统计订单
        /// </summary>
        /// <param name="C_STA_ID">产线主键 全部时传all</param>
        /// <returns>统计数据</returns>
        public DataTable GetWgtByLine(string C_STA_ID)
        {
            string sql = @"SELECT T.C_STA_ID,
       T.C_LINE_DESC,
       SUM(T.N_WGT) N_WGT
  FROM TRP_PLAN_ROLL T
 WHERE T.N_STATUS = 0  AND T.N_TYPE=8 ";
            if (C_STA_ID.Trim() != "")
            {
                sql = sql + " AND T.C_STA_ID='" + C_STA_ID + "'";
            }

            sql = sql + @"  GROUP BY T.C_STA_ID, T.C_LINE_DESC
 ORDER BY DECODE(T.C_LINE_DESC,'一线',1,'二线',2,'三线',3,'四线',4,5) ";
            return DbHelperOra.Query(sql).Tables[0];
        }


        /// <summary>
        /// 获取未排产的产线规格
        /// </summary>
        public DataSet Get_Spec_Max_Trans(string c_line_code, string C_SPEC)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT DISTINCT T.C_SPEC FROM TRP_PLAN_ROLL T WHERE T.N_STATUS=0   AND T.N_TYPE=8  AND T.C_LINE_CODE='" + c_line_code + "' AND T.n_roll_prod_wgt<T.N_WGT ");

            if (!string.IsNullOrEmpty(C_SPEC))
            {
                strSql.Append(" AND TO_NUMBER(SUBSTR(T.C_SPEC,2))>=TO_NUMBER(SUBSTR('" + C_SPEC + "',2)) ");
            }

            strSql.Append("ORDER BY TO_NUMBER(SUBSTR(T.C_SPEC,2)) ASC");

            return TransactionHelper.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取未排产的产线规格
        /// </summary>
        public DataSet Get_Spec_Min_Trans(string c_line_code, string C_SPEC)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT DISTINCT T.C_SPEC FROM TRP_PLAN_ROLL T WHERE T.N_STATUS=0  AND T.N_TYPE=8  AND T.C_LINE_CODE='" + c_line_code + "' AND T.n_roll_prod_wgt<T.N_WGT ");

            if (!string.IsNullOrEmpty(C_SPEC))
            {
                strSql.Append(" AND TO_NUMBER(SUBSTR(T.C_SPEC,2))<TO_NUMBER(SUBSTR('" + C_SPEC + "',2)) ");
            }

            strSql.Append("ORDER BY TO_NUMBER(SUBSTR(T.C_SPEC,2)) desc");

            return TransactionHelper.Query(strSql.ToString());
        }

        /// <summary>
        /// 判断订单量是否大于指定重量
        /// </summary>
        /// <param name="strSpec">规格</param>
        /// <param name="d_WGT">重量</param>
        /// <returns></returns>
        public int Get_Count_Trans(string c_line_code, string strSpec, decimal d_WGT)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select COUNT(1) from(select SUM(T.N_WGT-T.n_roll_prod_wgt)AS WGT from TRP_PLAN_ROLL t where t.c_line_code = '" + c_line_code + "' and t.n_status = 0 and t.c_spec = '" + strSpec + "' AND T.n_roll_prod_wgt<T.N_WGT) WHERE WGT> " + d_WGT + " ");

            object obj = TransactionHelper.GetSingle(strSql.ToString());
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
        /// 获取待轧的轧钢计划
        /// </summary>
        public DataSet Get_ZG_Plan_Trans(string C_LINE_CODE, string C_SPEC)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT (T.N_WGT-T.n_roll_prod_wgt)AS N_ZG_WGT,T.C_STD_CODE,T.C_STL_GRD,T.C_ID,T.D_P_START_TIME,T.D_P_END_TIME,T.N_MACH_WGT,t.C_INITIALIZE_ITEM_ID FROM TRP_PLAN_ROLL T WHERE T.N_STATUS=0 AND T.n_roll_prod_wgt<T.N_WGT   ");

            if (!string.IsNullOrEmpty(C_LINE_CODE))
            {
                strSql.Append(" and T.C_LINE_CODE='" + C_LINE_CODE + "'  ");
            }

            if (!string.IsNullOrEmpty(C_SPEC))
            {
                strSql.Append(" AND T.C_SPEC='" + C_SPEC + "'  ");
            }

            strSql.Append(" ORDER BY (T.N_WGT-T.n_roll_prod_wgt)DESC,t.C_STD_CODE,t.C_STL_GRD DESC  ");

            return TransactionHelper.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取待轧的轧钢计划（按钢种，执行标准，待轧量汇总）
        /// </summary>
        public DataSet Get_ZG_Plan_Trans()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT N_WGT,WGT_SY,C_STD_CODE,C_STL_GRD  FROM(SELECT SUM(T.N_WGT) AS N_WGT, SUM((T.N_WGT - T.N_ROLL_PROD_WGT)) AS WGT_SY, T.C_STD_CODE, T.C_STL_GRD FROM TRP_PLAN_ROLL T GROUP BY T.C_STD_CODE, T.C_STL_GRD) ORDER BY WGT_SY DESC   ");

            return TransactionHelper.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取待轧的轧钢计划的钢种和执行标准
        /// </summary>
        public DataSet Get_ZG_Std_Code_Trans(string C_LINE_CODE, string C_SPEC)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT DISTINCT T.C_STD_CODE, T.C_STL_GRD FROM TRP_PLAN_ROLL T WHERE T.N_STATUS=0 AND T.n_roll_prod_wgt<T.N_WGT   ");

            if (!string.IsNullOrEmpty(C_LINE_CODE))
            {
                strSql.Append(" and T.C_LINE_CODE='" + C_LINE_CODE + "'  ");
            }

            if (!string.IsNullOrEmpty(C_SPEC))
            {
                strSql.Append(" AND T.C_SPEC='" + C_SPEC + "'  ");
            }

            return TransactionHelper.Query(strSql.ToString());
        }


        /// <summary>
        /// 更新轧钢排产量
        /// </summary>
        public bool Update_Trans(string C_ID, decimal N_ZG_WGT, string timeStart, string timeEnd)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TRP_PLAN_ROLL set n_roll_prod_wgt=n_roll_prod_wgt+" + N_ZG_WGT + ",D_P_START_TIME=to_date('" + timeStart + "','yyyy-mm-dd hh24:mi:ss'),D_P_END_TIME=to_date('" + timeEnd + "','yyyy-mm-dd hh24:mi:ss') where C_ID='" + C_ID + "' ");

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

        /// <summary>
        /// 更新轧钢排产量
        /// </summary>
        public bool Update_ZG_Trans(string C_ID, decimal N_ZG_WGT, string timeStart, string timeEnd)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TRP_PLAN_ROLL set n_roll_prod_wgt=" + N_ZG_WGT + ",D_P_START_TIME=to_date('" + timeStart + "','yyyy-mm-dd hh24:mi:ss'),D_P_END_TIME=to_date('" + timeEnd + "','yyyy-mm-dd hh24:mi:ss') where C_ID='" + C_ID + "' ");

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

        /// <summary>
        /// 获取待轧的轧钢计划
        /// </summary>
        public DataSet Get_Plan_Roll_Trans()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from TRP_PLAN_ROLL WHERE N_TYPE=8 and N_STATUS in (0, 1) AND N_ROLL_PROD_WGT<N_WGT and n_mach_wgt<>0 and c_line_code is not null ");

            strSql.Append(" ORDER BY (N_WGT-N_ROLL_PROD_WGT)DESC,C_STL_GRD,C_STD_CODE DESC  ");

            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取要下发的轧钢计划
        /// </summary>
        /// <param name="C_STA_ID">轧线主键</param>
        /// <param name="num">下发计划量</param>
        /// <returns></returns>
        public DataSet Get_Plan_Down_Trans(string C_STA_ID, int num)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from(select C_ID, D_P_START_TIME FROM TRP_PLAN_ROLL WHERE N_STATUS = 0 AND n_roll_prod_wgt > 0 and D_P_START_TIME is not null and C_STA_ID = '" + C_STA_ID + "' ORDER BY D_P_START_TIME) where rownum<= " + num + "  ");

            return TransactionHelper.Query(strSql.ToString());
        }

        /// <summary>
        /// 修改轧钢计划状态
        /// </summary>
        /// <param name="C_ID">主键</param>
        /// <param name="N_STATUS">计划状态;0-未下发，1-已下发</param>
        /// <returns></returns>
        public bool Update_Status_Trans(string C_ID, int N_STATUS)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TRP_PLAN_ROLL set N_STATUS = " + N_STATUS + " where C_ID='" + C_ID + "' ");

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


        /// <summary>
        /// 排产初始化
        /// </summary>
        /// <returns></returns>
        public bool Update_Trans()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("UPDATE TRP_PLAN_ROLL T SET T.N_ROLL_PROD_WGT=round(t.n_prod_wgt),T.D_P_START_TIME=NULL,T.D_P_END_TIME=NULL  where t.N_STATUS in(0,1) and t.N_TYPE=8 and t.c_line_code is not null ");

            int rows = DbHelperOra.ExecuteSql(strSql.ToString());
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
        /// 获取要未发的轧钢计划
        /// </summary>
        /// <param name="C_STA_ID">轧线主键</param>
        /// <param name="strGZ">钢种</param>
        /// <param name="strBZ">标准</param>
        /// <param name="strState">0未下发，1已下发，2已完工，全部,9-未完工</param>
        /// <param name="strBZ">规格<param>
        /// <param name="iBXG">是否不锈钢<param>
        ///  <param name="c_order_no">订单号<param>
        /// <returns></returns>
        public DataSet Get_Plan_WXF(string C_STA_ID, string strGZ, string strBZ, string strState, string strGG, int iBXG, string c_order_no)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from V_ROLL_PLAN t WHERE 1=1");

            if (!string.IsNullOrEmpty(C_STA_ID))
            {
                strSql.Append(" and C_STA_ID = '" + C_STA_ID + "' ");
            }
            if (iBXG == 1)//碳钢
            {
                strSql.Append(" and C_BY4 = '0' ");
            }
            if (iBXG == 2)//不锈钢
            {
                strSql.Append(" and C_BY4 = '1' ");
            }


            if (!string.IsNullOrEmpty(strGZ))
            {
                strSql.Append(" and C_STL_GRD like '%" + strGZ + "%' ");
            }

            if (!string.IsNullOrEmpty(c_order_no))
            {
                strSql.Append(" and INSTR('" + c_order_no + "',C_ORDER_NO)>0 ");
            }

            if (!string.IsNullOrEmpty(strBZ))
            {
                strSql.Append(" and C_STD_CODE like '%" + strBZ + "%' ");
            }

            if (strState == "0") //未下发
            {
                strSql.Append(" and N_STATUS = '0' ");
            }
            if (strState == "1") //已下发
            {
                strSql.Append(" and N_STATUS = '1' ");
            }
            if (strState == "2") //已完工
            {
                strSql.Append(" and N_STATUS = '2' ");
            }

            if (strState == "9") //未完工
            {
                strSql.Append(" and (N_STATUS = '0' or N_STATUS='1') ");
            }

            if (!string.IsNullOrEmpty(strGG))
            {
                strSql.Append(" and  instr('" + strGG + "',C_SPEC)>0 ");
            }

            strSql.Append(" and N_TYPE=8 ");

            strSql.Append("  order by t.C_LINE_CODE,T.D_P_START_TIME ");

            return TransactionHelper.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取要未发的轧钢计划
        /// </summary>
        /// <param name="C_STA_ID">轧线主键</param>
        /// <param name="strGZ">钢种</param>
        /// <param name="strBZ">标准</param>
        /// <param name="strState">未下发，已下发，已完工，全部</param>
        /// <param name="strBZ">规格<param>
        /// <param name="iBXG">是否不锈钢<param>
        ///  <param name="c_order_no">订单号<param>
        /// <returns></returns>
        public DataSet Get_Plan_WXF_Test(string C_STA_ID, string strGZ, string strBZ, string strState, string strGG, int iBXG, string c_order_no)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from V_ROLL_PLAN_TEST t WHERE 1=1");

            if (!string.IsNullOrEmpty(C_STA_ID))
            {
                strSql.Append(" and C_STA_ID = '" + C_STA_ID + "' ");
            }
            if (iBXG == 1)//碳钢
            {
                strSql.Append(" and C_BY4 = '0' ");
            }
            if (iBXG == 2)//不锈钢
            {
                strSql.Append(" and C_BY4 = '1' ");
            }


            if (!string.IsNullOrEmpty(strGZ))
            {
                strSql.Append(" and C_STL_GRD like '%" + strGZ + "%' ");
            }

            if (!string.IsNullOrEmpty(c_order_no))
            {
                strSql.Append(" and INSTR('" + c_order_no + "',C_ORDER_NO)>0 ");
            }

            if (!string.IsNullOrEmpty(strBZ))
            {
                strSql.Append(" and C_STD_CODE like '%" + strBZ + "%' ");
            }

            if (strState == "0") //未下发，已下发，已完工，全部
            {
                strSql.Append(" and N_STATUS = '0' ");
            }
            if (strState == "1") //未下发，已下发，已完工，全部
            {
                strSql.Append(" and N_STATUS = '1' ");
            }
            if (strState == "2") //未下发，已下发，已完工，全部
            {
                strSql.Append(" and N_STATUS = '2' ");
            }

            if (!string.IsNullOrEmpty(strGG))
            {
                strSql.Append(" and  instr('" + strGG + "',C_SPEC)>0 ");
            }

            strSql.Append(" and N_TYPE=8 ");

            strSql.Append("  order by t.C_LINE_CODE,T.D_P_START_TIME ");

            return TransactionHelper.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取线材订单的规格
        /// </summary>
        public DataSet Get_Spec()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT Distinct T.C_SPEC, T.N_DIAMETER FROM tmo_order t WHERE t.d_pctbts>Sysdate-30 AND t.n_exec_status IN (0,2,6) AND T.N_TYPE=8 AND t.n_status=2 ORDER BY t.n_diameter  ");
            return TransactionHelper.Query(strSql.ToString());
        }


        /// <summary>
        /// 获取钢坯库存
        /// </summary>
        /// <param name="grd">钢种</param>
        /// <param name="spec">断面</param>
        /// <param name="std">执行标准</param>
        /// <param name="slabwhCode">仓库编码</param>
        /// <param name="matCode">物料编码</param>
        /// <param name="length">长度</param>
        /// <returns></returns>
        public DataTable GetSlabInventory(string grd, string spec, string std)
        {
            string sql = @"SELECT TSM.C_STOVE,
                                     COUNT(TSM.C_STOVE) N_QUA,
                                     MAX(TSM.C_STL_GRD) C_STL_GRD,
                                     MAX(TSM.C_SPEC) C_SPEC,
                                     MAX(TSM.N_LEN) N_LEN,
                                     TSM.C_STD_CODE C_STD_CODE,
                                     SUM(TSM.N_WGT) WGTSUM,
                                     MIN(TSM.N_WGT) N_WGT,
                                     TSM.C_SLABWH_CODE,
                                    (SELECT TS.C_SLABWH_NAME FROM   TPB_SLABWH TS WHERE TS.C_SLABWH_CODE=TSM.C_SLABWH_CODE AND TS.N_STATUS=1)C_SLABWH_CODE_NAME,
                                     MAX(TSM.C_SLABWH_LOC_CODE) C_SLABWH_LOC_CODE,
                                     MAX(TSM.C_SLABWH_AREA_CODE) C_SLABWH_AREA_CODE,
                                     MAX(TSA.C_STA_DESC) C_STA_ID,
                                     TSM.C_MAT_CODE,
                                     TSM.C_MAT_NAME,
                                     TSM.C_REMARK,
                                     TSM.C_MOVE_TYPE
                                FROM TSC_SLAB_MAIN TSM
                                LEFT JOIN TB_STA TSA
                                  ON TSA.C_ID = TSM.C_STA_ID
                               WHERE 1=1 ";


            if (!string.IsNullOrWhiteSpace(spec))
                sql += "  AND TSM.C_SPEC = '" + spec + "'  ";

            if (!string.IsNullOrWhiteSpace(grd))
                sql += "  AND TSM.C_STL_GRD = '" + grd + "'  ";

            if (!string.IsNullOrWhiteSpace(std))
                sql += "  AND TSM.C_STD_CODE = '" + std + "'  ";


            sql += @"  GROUP BY TSM.C_BATCH_NO,
                                        TSM.C_STOVE,
                                        TSM.C_STD_CODE,
                                        TSM.C_MAT_CODE,
                                        TSM.C_MAT_NAME,
                                        TSM.C_REMARK,
                                        TSM.C_SLABWH_CODE,
                                        TSM.C_MOVE_TYPE
                                            ";

            return DbHelperOra.Query(sql).Tables[0];
        }

        #endregion  ExtensionMethod

        #region 计划排产
        /// <summary>
        /// 获取炼钢可生成炉次计划的生产订单信息
        /// </summary>
        /// <param name="C_STL_GRD_SLAB">炼钢钢种</param>
        /// <param name="C_STD_CODE_SLAB">炼钢标准</param>
        /// <param name="C_SLAB_SIZE">断面</param>
        /// <param name="N_SLAB_LENGTH">定尺</param>
        /// <returns>查询结果</returns>
        public DataTable GetOrderLCInfo(string C_STL_GRD_SLAB, string C_STD_CODE_SLAB, string C_BY1, string C_BY2, string C_MATRL_CODE_SLAB)
        {
            string sql = @"SELECT T.C_ID, T.C_STL_GRD,
       T.C_STD_CODE,
       T.C_STL_GRD_SLAB,
       T.C_STD_CODE_SLAB,
       T.C_BY1 C_FREE_TERM,
       T.C_BY2 C_FREE_TERM2,
       T.N_WGT,
       NVL((SELECT SUM(A.N_SLAB_WGT)
             FROM TSP_PLAN_SMS A
            WHERE A.N_STATUS = 1 AND A.C_ORDER_NO = T.C_INITIALIZE_ITEM_ID),
           0) N_YPC_WGT,
       T.C_INITIALIZE_ITEM_ID,
       T.C_MATRL_CODE_SLAB,
       T.C_MATRL_NAME_SLAB,
       T.C_SLAB_SIZE,
       T.N_SLAB_LENGTH,
       T.N_SLAB_PW
  FROM TRP_PLAN_ROLL T
 WHERE ((T.N_STATUS IN(0, 1,2) AND T.D_DT>SYSDATE-30 ) or (T.N_STATUS =6)) ";
            sql = sql + @" AND T.C_STL_GRD_SLAB = '" + C_STL_GRD_SLAB + "'";
            sql = sql + @"   AND T.C_STD_CODE_SLAB = '" + C_STD_CODE_SLAB + "'";

            sql = sql + @"   AND T.C_BY1 = '" + C_BY1 + "'";
            sql = sql + @"   AND T.C_BY2 = '" + C_BY2 + "'";

            sql = sql + @"  AND T.C_MATRL_CODE_SLAB = '" + C_MATRL_CODE_SLAB + "'";
            sql = sql + @"  ORDER BY 
          T.N_WGT - NVL((SELECT SUM(A.N_SLAB_WGT)
                          FROM TSP_PLAN_SMS A
                         WHERE A.N_STATUS = 1 AND A.C_ORDER_NO = T.C_INITIALIZE_ITEM_ID),
                        0) DESC,T.N_WGT DESC";

            return DbHelperOra.Query(sql).Tables[0];


        }

        /// <summary>
        /// 根据组号加载可以生产的产品
        /// </summary>
        /// <param name="N_GROUP">分组号</param>
        /// <param name="C_CCM_ID">连铸号</param>
        /// <param name="SFWC">是否完成</param>
        /// <param name="D_DT_B">排产计划开始日期</param>
        /// <param name="D_DT_E">排产计划截止日期</param>
        /// <returns>可加载的计划</returns>
        public DataTable GetOrderMatInfo(int N_GROUP, string C_CCM_ID, int SFWC, string D_DT_B, string D_DT_E)
        {
            DateTime dt1 = System.DateTime.Now;
            DateTime dt = DateTime.Now.AddDays(1 - DateTime.Now.Day).Date;//本月第一天

            int dayC = (dt1 - dt).Days;
            if (dayC > 10)
            {
                D_DT_B = DateTime.Now.AddDays(1 - DateTime.Now.Day).Date.ToShortDateString();
            }
            else
            {
                D_DT_B = DateTime.Now.AddDays(1 - DateTime.Now.Day).Date.AddDays(-11).ToShortDateString();
            }

            string sql = @"SELECT DISTINCT 
                T.C_SLAB_SIZE || '*' || T.N_SLAB_LENGTH C_SPEC ,
                T.C_BY1,
                T.C_BY2,
                T.C_STL_GRD_SLAB,
                T.C_STD_CODE_SLAB,
                T.C_MATRL_CODE_SLAB,
                T.C_MATRL_NAME_SLAB,
                T.C_SLAB_SIZE,
                T.N_SLAB_LENGTH,
                T.N_SLAB_PW,
                T.C_MATRL_CODE_KP,
                T.C_MATRL_NAME_KP,
                T.C_KP_SIZE,
                T.N_KP_LENGTH,
                T.N_KP_PW
  FROM TRP_PLAN_ROLL T
 WHERE ((T.N_STATUS IN(0, 1,2) AND  T.C_MATRL_NAME_SLAB NOT LIKE '%来料%' AND T.D_DT >= TO_DATE('" + D_DT_B + "', 'yyyy-mm-dd hh24:mi:ss') ) or T.N_STATUS =6 )";

            sql = sql + "     AND T.N_GROUP = " + N_GROUP;

            if ((C_CCM_ID == "890EAA2949E743AFB26C06B8D4209B17" || C_CCM_ID == "5263048C90B44B4D9934C513CE028250" || C_CCM_ID == "01C145B259E740F6A258AF313DD9268C"))//3#4#6#
            {
                sql = sql + " AND T.C_CCM_ID  IN ('890EAA2949E743AFB26C06B8D4209B17','5263048C90B44B4D9934C513CE028250','01C145B259E740F6A258AF313DD9268C')";
            }
            else
            {
                sql = sql + "AND T.C_CCM_ID  IN ('77B9FDA79B884D07AA2B3601D1DA11A2','B531146364EE43AFA7D84B5C8B7EE2FC')";
            }


            return DbHelperOra.Query(sql).Tables[0];
        }


        /// <summary>
        /// 获取炼钢排产计划数据
        /// </summary>
        /// <param name="D_DT_B">排产订单开始时间</param>
        /// <param name="D_DT_E">排产订单结束时间</param>
        /// <param name="C_CCM_ID">连铸主键</param>
        /// <returns>按组合并后的炼钢计划</returns>
        public DataTable GetSlabOrder(string D_DT_B, string D_DT_E, string C_CCM_ID, string C_IS_BXG)
        {

            DateTime dt1 = System.DateTime.Now;
            DateTime dt = DateTime.Now.AddDays(1 - DateTime.Now.Day).Date;//本月第一天

            int dayC = (dt1 - dt).Days;
            if (dayC > 10)
            {
                D_DT_B = DateTime.Now.AddDays(1 - DateTime.Now.Day).Date.ToShortDateString();
            }
            else
            {
                D_DT_B = DateTime.Now.AddDays(1 - DateTime.Now.Day).Date.AddDays(-11).ToShortDateString();
            }

            string sql = @" SELECT T.N_GROUP,
       T.C_CCM_CODE,
       T.C_CCM_DESC,
       MAX(T.N_ZJCLS) N_ZJCLS,
       T.C_CCM_ID
  FROM TRP_PLAN_ROLL T
 WHERE T.N_STATUS IN(0, 1) AND T.C_MATRL_NAME_SLAB NOT LIKE '%来料%' AND C_BY4='" + C_IS_BXG + "'   AND T.C_CCM_ID IS NOT NULL and  T.N_GROUP  IS NOT NULL ";
            if (C_CCM_ID.Trim() != "")
            {
                sql = sql + "    AND T.C_CCM_ID ='" + C_CCM_ID + "' ";
            }
            sql = sql + "  AND T.D_DT >= TO_DATE('" + D_DT_B + "', 'yyyy-mm-dd hh24:mi:ss') ";
            // sql = sql + "   AND T.D_DT <= TO_DATE('" + D_DT_E + "', 'yyyy-mm-dd hh24:mi:ss')";
            sql = sql + " GROUP BY T.N_GROUP, T.C_CCM_CODE, T.C_CCM_DESC, T.C_CCM_ID  ORDER BY T.C_CCM_ID, T.N_GROUP";
            return DbHelperOra.Query(sql).Tables[0];

        }

        /// <summary>
        /// 获取炼钢排产计划数据
        /// </summary>
        /// <param name="D_DT_B">排产订单开始时间</param>
        /// <param name="D_DT_E">排产订单结束时间</param>
        /// <param name="C_CCM_ID">连铸主键</param>
        /// <returns>按组合并后的炼钢计划</returns>
        public DataTable GetSlabOrder(string D_DT_B, string D_DT_E, string C_CCM_ID, string C_IS_BXG, int N_GROUP)
        {

            DateTime dt1 = System.DateTime.Now;
            DateTime dt = DateTime.Now.AddDays(1 - DateTime.Now.Day).Date;//本月第一天

            int dayC = (dt1 - dt).Days;
            if (dayC > 10)
            {
                D_DT_B = DateTime.Now.AddDays(1 - DateTime.Now.Day).Date.ToShortDateString();
            }
            else
            {
                D_DT_B = DateTime.Now.AddDays(1 - DateTime.Now.Day).Date.AddDays(-11).ToShortDateString();
            }

            string sql = @" SELECT T.N_GROUP,
       T.C_CCM_CODE,
       T.C_CCM_DESC,
       MAX(T.N_ZJCLS) N_ZJCLS,
       T.C_CCM_ID
  FROM TRP_PLAN_ROLL T
 WHERE T.N_STATUS IN(0, 1) AND  T.C_MATRL_NAME_SLAB NOT LIKE '%来料%' AND C_BY4='" + C_IS_BXG + "' AND T.N_GROUP=" + N_GROUP + "   AND T.C_CCM_ID IS NOT NULL and  T.N_GROUP  IS NOT NULL ";
            if (C_CCM_ID.Trim() != "")
            {
                sql = sql + "    AND T.C_CCM_ID ='" + C_CCM_ID + "' ";
            }
            sql = sql + "  AND T.D_DT >= TO_DATE('" + D_DT_B + "', 'yyyy-mm-dd hh24:mi:ss') ";
            // sql = sql + "   AND T.D_DT <= TO_DATE('" + D_DT_E + "', 'yyyy-mm-dd hh24:mi:ss')";
            sql = sql + " GROUP BY T.N_GROUP, T.C_CCM_CODE, T.C_CCM_DESC, T.C_CCM_ID  ORDER BY T.C_CCM_ID, T.N_GROUP";
            return DbHelperOra.Query(sql).Tables[0];

        }



        /// <summary>
        /// 获取炼钢排产计划详细数据
        /// </summary>
        /// <param name="D_DT_B">排产订单开始时间</param>
        /// <param name="D_DT_E">排产订单结束时间</param>
        /// <param name="C_CCM_ID">连铸主键</param>
        ///  <param name="N_GROUP">分组号</param>
        /// <returns>按组合并后的炼钢详细计划</returns>
        public DataTable GetSlabOrderInfo(string D_DT_B, string D_DT_E, string C_CCM_ID, int? N_GROUP, string C_IS_BXG)
        {
            DateTime dt1 = System.DateTime.Now;
            DateTime dt = DateTime.Now.AddDays(1 - DateTime.Now.Day).Date;//本月第一天

            int dayC = (dt1 - dt).Days;
            if (dayC > 10)
            {
                D_DT_B = DateTime.Now.AddDays(1 - DateTime.Now.Day).Date.ToShortDateString();
            }
            else
            {
                D_DT_B = DateTime.Now.AddDays(1 - DateTime.Now.Day).Date.AddDays(-11).ToShortDateString();
            }

            string sql = @"SELECT (SELECT SUM(A.N_WGT)
          FROM TSC_SLAB_MAIN A
         WHERE A.C_STL_GRD = M.C_STL_GRD_SLAB
           AND A.C_STD_CODE = M.C_STD_CODE_SLAB
           AND A.C_MOVE_TYPE IN ('E', 'M')) N_SLAB_KC,
       (SELECT SUM(A.N_SLAB_WGT)
          FROM TSP_PLAN_SMS A
         WHERE A.N_STATUS = 1 AND A.N_CREAT_PLAN < 4
           AND A.C_STL_GRD = M.C_STL_GRD_SLAB
           AND A.C_STD_CODE = M.C_STD_CODE_SLAB) N_SLAB_WWC,
       M.*
  FROM (SELECT SUM(T.N_WGT) N_WGT,
               SUM(NVL(T.N_PROD_WGT, 0)) N_PROD_WGT,
               T.C_MATRL_CODE_SLAB,
               T.C_MATRL_NAME_SLAB,
               T.C_SLAB_SIZE,
               T.N_SLAB_LENGTH,
               MAX(T.N_SLAB_PW) N_SLAB_PW,
               T.C_ROUTE,
               T.C_STL_GRD_SLAB,
               T.C_STD_CODE_SLAB,
               T.C_MATRL_CODE_KP,
               T.C_MATRL_NAME_KP,
               T.C_KP_SIZE,
               T.N_KP_LENGTH,
               MAX(T.N_KP_PW) N_KP_PW,
               T.N_GROUP,
               T.C_BY1,
               MAX(T.C_BY2) C_BY2,
               T.C_SL,
                  T.C_WL,
               T.C_CCM_CODE,
               T.C_CCM_DESC,
               MAX(T.N_ZJCLS) N_ZJCLS,
               T.C_STL_GRD_TYPE,
               T.C_PROD_NAME,
               T.C_PROD_KIND,
               T.N_TYPE,
               T.C_CCM_ID,DECODE( t.c_by4,0,'碳钢',1,'不锈钢') c_by4
          FROM TRP_PLAN_ROLL T
         WHERE T.N_STATUS IN(0, 1) AND  T.C_MATRL_NAME_SLAB NOT LIKE '%来料%' AND T.C_MATRL_NAME_SLAB NOT LIKE '%来料%' AND C_BY4='" + C_IS_BXG + "'  AND T.C_CCM_ID IS NOT NULL ";
            if (N_GROUP != null)
            {
                sql = sql + "     AND N_GROUP=" + N_GROUP + " ";
            }
            if (C_CCM_ID.Trim() != "")
            {
                sql = sql + "    AND T.C_CCM_ID ='" + C_CCM_ID + "' ";
            }
            sql = sql + "  AND T.D_DT >= TO_DATE('" + D_DT_B + "', 'yyyy-mm-dd hh24:mi:ss')";
            //  sql = sql + "   AND T.D_DT <= TO_DATE('" + D_DT_E + "', 'yyyy-mm-dd hh24:mi:ss') ";
            sql = sql + @"     GROUP BY 
                  T.C_MATRL_CODE_SLAB,
                  T.C_MATRL_NAME_SLAB,
                  T.C_SLAB_SIZE,
                  T.N_SLAB_LENGTH,
                  --T.N_SLAB_PW,
                  T.C_ROUTE,
                  T.C_STL_GRD_SLAB,
                  T.C_STD_CODE_SLAB,
                  T.C_MATRL_CODE_KP,
                  T.C_MATRL_NAME_KP,
                  T.C_KP_SIZE,
                  T.N_KP_LENGTH,
                  --T.N_KP_PW,
                  T.N_GROUP,
                  T.C_BY1,
                  --T.C_BY2,
                  T.C_SL,
                  T.C_WL,
                  T.C_CCM_CODE,
                  T.C_CCM_DESC,
                  T.C_STL_GRD_TYPE,
                  T.C_PROD_NAME,
                  T.C_PROD_KIND,
                  T.N_TYPE,
                  T.C_CCM_ID,
                  T.C_CCM_CODE,
                  T.C_CCM_DESC,t.c_by4
         ORDER BY T.N_GROUP, T.C_STL_GRD, T.C_STD_CODE) M  ORDER BY M.N_GROUP, M.N_WGT ";

            return DbHelperOra.Query(sql).Tables[0];

        }


        /// <summary>
        /// 获取炼钢排产计划详细数据
        /// </summary>
        /// <param name="C_CCM_ID">连铸主键</param>
        ///  <param name="N_GROUP">分组号</param>
        /// <returns>按组合并后的炼钢详细计划</returns>
        public DataTable GetSlabOrderInfoDesc(string C_CCM_ID, int? N_GROUP)
        {
            DateTime dt1 = System.DateTime.Now;
            DateTime dt = DateTime.Now.AddDays(1 - DateTime.Now.Day).Date;//本月第一天
            string D_DT_B = "";
            int dayC = (dt1 - dt).Days;
            if (dayC > 10)
            {
                D_DT_B = DateTime.Now.AddDays(1 - DateTime.Now.Day).Date.ToShortDateString();
            }
            else
            {
                D_DT_B = DateTime.Now.AddDays(1 - DateTime.Now.Day).Date.AddDays(-11).ToShortDateString();
            }

            string sql = @"SELECT (SELECT SUM(A.N_WGT)
          FROM TSC_SLAB_MAIN A
         WHERE A.C_STL_GRD = M.C_STL_GRD_SLAB
           AND A.C_STD_CODE = M.C_STD_CODE_SLAB
           AND A.C_MOVE_TYPE IN ('E', 'M')) N_SLAB_KC,
       (SELECT SUM(A.N_SLAB_WGT)
          FROM TSP_PLAN_SMS A
         WHERE A.N_STATUS = 1 AND A.N_CREAT_PLAN < 4
           AND A.C_STL_GRD = M.C_STL_GRD_SLAB
           AND A.C_STD_CODE = M.C_STD_CODE_SLAB) N_SLAB_WWC,
       M.*
  FROM (SELECT SUM(T.N_WGT) N_WGT,
               SUM(NVL(T.N_PROD_WGT, 0)) N_PROD_WGT,
               T.C_STL_GRD,
               T.C_STD_CODE,
               T.C_FREE_TERM,
               T.C_FREE_TERM2,
               T.C_MATRL_CODE_SLAB,
               T.C_MATRL_NAME_SLAB,
               T.C_SLAB_SIZE,
               T.N_SLAB_LENGTH,
               T.N_SLAB_PW,
               T.C_ROUTE,
               T.C_STL_GRD_SLAB,
               T.C_STD_CODE_SLAB,
               T.C_MATRL_CODE_KP,
               T.C_MATRL_NAME_KP,
               T.C_KP_SIZE,
               T.N_KP_LENGTH,
               T.N_KP_PW,
               T.N_GROUP,
               T.C_BY1,
               T.C_BY2,
               T.C_SL,
               T.C_WL,
               T.C_CCM_CODE,
               T.C_CCM_DESC,
               MAX(T.N_ZJCLS) N_ZJCLS,
               T.C_STL_GRD_TYPE,
               T.C_PROD_NAME,
               T.C_PROD_KIND,
               T.N_TYPE,
               T.C_CCM_ID,DECODE( t.c_by4,0,'碳钢',1,'不锈钢') c_by4
          FROM TRP_PLAN_ROLL T
         WHERE T.N_STATUS IN(0, 1,2) AND  T.C_MATRL_NAME_SLAB NOT LIKE '%来料%'
           AND T.C_CCM_ID IS NOT NULL ";
            if (N_GROUP != null)
            {
                sql = sql + "     AND N_GROUP=" + N_GROUP + " ";
            }
            if (C_CCM_ID.Trim() != "")
            {
                sql = sql + "    AND T.C_CCM_ID ='" + C_CCM_ID + "' ";
            }
            sql = sql + "  AND T.D_DT >= TO_DATE('" + D_DT_B + "', 'yyyy-mm-dd hh24:mi:ss')";
            //  sql = sql + "   AND T.D_DT <= TO_DATE('" + D_DT_E + "', 'yyyy-mm-dd hh24:mi:ss') ";
            sql = sql + @"     GROUP BY T.C_STL_GRD,
                  T.C_STD_CODE,
                  T.C_FREE_TERM,
                  T.C_FREE_TERM2,
                  T.C_MATRL_CODE_SLAB,
                  T.C_MATRL_NAME_SLAB,
                  T.C_SLAB_SIZE,
                  T.N_SLAB_LENGTH,
                  T.N_SLAB_PW,
                  T.C_ROUTE,
                  T.C_STL_GRD_SLAB,
                  T.C_STD_CODE_SLAB,
                  T.C_MATRL_CODE_KP,
                  T.C_MATRL_NAME_KP,
                  T.C_KP_SIZE,
                  T.N_KP_LENGTH,
                  T.N_KP_PW,
                  T.N_GROUP,
                  T.C_BY1,
                  T.C_BY2,
                  T.C_SL,
                  T.C_WL,
                  T.C_CCM_CODE,
                  T.C_CCM_DESC,
                  T.C_STL_GRD_TYPE,
                  T.C_PROD_NAME,
                  T.C_PROD_KIND,
                  T.N_TYPE,
                  T.C_CCM_ID,
                  T.C_CCM_CODE,
                  T.C_CCM_DESC,t.c_by4
         ORDER BY T.N_GROUP, T.C_STL_GRD, T.C_STD_CODE) M  ORDER BY M.N_GROUP, M.N_WGT DESC ";

            return DbHelperOra.Query(sql).Tables[0];

        }


        /// <summary>
        /// 根据订单号获取已下发车间量
        /// </summary>
        /// <param name="C_INITIALIZE_ITEM_ID">订单号</param>
        /// <returns></returns>
        public decimal GetYPwgt(string C_INITIALIZE_ITEM_ID)
        {
            string sql = "SELECT NVL(SUM(T.N_ISSUE_WGT), 0) N_ISSUE_WGT  FROM TRP_PLAN_ROLL T WHERE T.C_INITIALIZE_ITEM_ID = '" + C_INITIALIZE_ITEM_ID + "'";
            return Convert.ToDecimal(DbHelperOra.Query(sql).Tables[0].Rows[0]["N_ISSUE_WGT"].ToString());
        }



        #endregion

        /// <summary>
        /// 获取之前计划未完成的计划
        /// </summary>
        /// <param name="D_DT">截止时间</param>
        /// <param name="C_STL_GRD">钢种</param>
        /// <param name="C_STD_CODE">执行标准</param>
        /// <param name="C_MATRL_CODE">物料名称</param>
        /// <returns></returns>
        public decimal GetLeftWgt(string D_DT, string C_STL_GRD, string C_STD_CODE, string C_MATRL_CODE)
        {
            DateTime dt1 = System.DateTime.Now;
            DateTime dt = DateTime.Now.AddDays(1 - DateTime.Now.Day).Date;//本月第一天
            string D_DT_B = "";
            int dayC = (dt1 - dt).Days;
            if (dayC > 10)
            {
                D_DT_B = DateTime.Now.AddDays(1 - DateTime.Now.Day).Date.ToShortDateString();
            }
            else
            {
                D_DT_B = DateTime.Now.AddDays(1 - DateTime.Now.Day).Date.AddDays(-11).ToShortDateString();
            }

            string sql = @"    SELECT NVL(SUM(T.N_WGT -NVL(T.N_PROD_WGT, 0)), 0) N_LEFT_WGT FROM TRP_PLAN_ROLL T
           WHERE NVL(T.N_PROD_WGT, 0) < T.N_WGT * 0.95   AND T.N_STATUS IN(0, 1) ";
            sql = sql + "  AND T.D_DT < TO_DATE('" + D_DT + "', 'yyyy-mm-dd hh24:mi:ss') ";
            sql = sql + "  AND t.d_dt>= TO_DATE('" + D_DT_B + "', 'yyyy-mm-dd hh24:mi:ss') ";
            sql = sql + "  AND T.C_STL_GRD_SLAB = '" + C_STL_GRD + "'";
            sql = sql + "      AND T.C_STD_CODE_SLAB ='" + C_STD_CODE + "'";
            if (C_MATRL_CODE.Trim() != "")
            {
                sql = sql + "      AND T.C_MATRL_CODE_SLAB ='" + C_MATRL_CODE + "' ";
            }
            return Convert.ToDecimal(DbHelperOra.Query(sql).Tables[0].Rows[0]["N_LEFT_WGT"].ToString());
        }


        /// <summary>
        /// 获取炉次计划可对应的订单
        /// </summary>
        /// <param name="D_DT_F">计划日期起</param>
        /// <param name="D_DT_E">计划日期终</param>
        /// <param name="C_STL_GRD_SLAB">钢种</param>
        /// <param name="C_STD_CODE_SLAB">执行标准</param>
        /// <param name="C_MATRL_CODE_SLAB">连铸坯物料编码</param>
        /// <param name="C_MATRL_CODE_KP">热轧坯物料编码</param>
        /// <param name="C_CCM_ID">连铸机主键</param>
        /// <param name="N_GROUP">分组号</param>
        /// <returns>炉次计划对应的订单</returns>
        public DataTable GetPlanInfo(string D_DT_F, string D_DT_E, string C_STL_GRD_SLAB, string C_STD_CODE_SLAB, string C_MATRL_CODE_SLAB, string C_MATRL_CODE_KP, string C_CCM_ID, int N_GROUP)
        {
            #region MyRegion

            DateTime dt1 = System.DateTime.Now;
            DateTime dt = DateTime.Now.AddDays(1 - DateTime.Now.Day).Date;//本月第一天
            string D_DT_B = "";
            int dayC = (dt1 - dt).Days;
            if (dayC > 10)
            {
                D_DT_B = DateTime.Now.AddDays(1 - DateTime.Now.Day).Date.ToShortDateString();
            }
            else
            {
                D_DT_B = DateTime.Now.AddDays(1 - DateTime.Now.Day).Date.AddDays(-11).ToShortDateString();
            }
            string sql = @"
SELECT *
  FROM (SELECT T.C_ID,
               T.N_STATUS,
               T.C_INITIALIZE_ITEM_ID,
               T.C_ORDER_NO,
               (T.N_WGT -
               (SELECT NVL(SUM(A.N_SLAB_WGT), 0)
                   FROM TSP_PLAN_SMS A
                  WHERE A.N_STATUS = 1 AND A.C_ORDER_NO = T.C_INITIALIZE_ITEM_ID) -
               (SELECT NVL(SUM(A.N_SLAB_WGT), 0)
                   FROM TPP_LGPC_LCLSB A
                  WHERE A.C_ORDER_NO = T.C_INITIALIZE_ITEM_ID)) N_WGT,
               T.C_MAT_CODE,
               T.C_MAT_NAME,
               T.C_TECH_PROT,
               T.C_SPEC,
               T.C_STL_GRD,
               T.C_STD_CODE,
               T.N_USER_LEV,
               T.N_STL_GRD_LEV,
               T.N_ORDER_LEV,
               T.C_QUALIRY_LEV,
               T.D_NEED_DT,
               T.D_DELIVERY_DT,
               T.D_DT,
               T.C_LINE_DESC,
               T.C_LINE_CODE,
               T.D_P_START_TIME,
               T.D_P_END_TIME,
               T.N_PROD_TIME,
               T.N_SORT,
               T.N_ROLL_PROD_WGT,
               T.C_ROLL_PROD_EMP_ID,
               T.C_STL_ROL_DT,
               T.N_PROD_WGT,
               T.N_WARE_WGT,
               T.N_WARE_OUT_WGT,
               T.N_FLAG,
               T.N_ISSUE_WGT,
               T.C_CUST_NO,
               T.C_CUST_NAME,
               T.C_SALE_CHANNEL,
               T.C_PACK,
               T.C_DESIGN_NO,
               T.N_GROUP_WGT,
               T.C_STA_ID,
               T.D_START_TIME,
               T.D_END_TIME,
               T.C_EMP_ID,
               T.D_MOD_DT,
               T.N_ROLL_WGT,
               T.N_MACH_WGT,
               T.C_CAST_NO,
               T.C_INITIALIZE_ID,
               T.C_FREE_TERM,
               T.C_FREE_TERM2,
               T.C_AREA,
               T.C_PCLX,
               T.C_SFHL,
               T.D_HL_START_TIME,
               T.D_HL_END_TIME,
               T.C_SFHL_D,
               T.D_DHL_START_TIME,
               T.D_DHL_END_TIME,
               T.C_SFKP,
               T.D_KP_START_TIME,
               T.D_KP_END_TIME,
               T.C_SFXM,
               T.D_XM_START_TIME,
               T.D_XM_END_TIME,
               T.N_UPLOADSTATUS,
               T.C_MATRL_CODE_SLAB,
               T.C_MATRL_NAME_SLAB,
               T.C_SLAB_SIZE,
               T.N_SLAB_LENGTH,
               T.N_SLAB_PW,
               T.D_CAN_ROLL_TIME,
               T.C_ROUTE,
               T.N_DIAMETER,
               T.C_XM_YQ,
               T.N_JRL_WD,
               T.N_JRL_SJ,
               T.C_STL_GRD_SLAB,
               T.C_STD_CODE_SLAB,
               T.C_MATRL_CODE_KP,
               T.C_MATRL_NAME_KP,
               T.C_KP_SIZE,
               T.N_KP_LENGTH,
               T.N_KP_PW,
               T.N_GROUP,
               T.C_XC,
               T.C_SL,
               T.C_WL,
               T.N_MACH_WGT_CCM,
               T.N_ZJCLS,
               T.C_BY1,
               T.C_BY2,
               T.C_BY3,
               T.C_BY4,
               T.C_BY5,
               T.C_LGJH,
               T.C_ZL_ID,
               T.C_LF_ID,
               T.C_RH_ID,
               T.N_SLAB_WIDTH,
               T.N_SLAB_THICK,
               T.C_DFP_RZ,
               T.C_RZP_RZ,
               T.C_DFP_YQ,
               T.C_RZP_YQ,
               T.N_KPJRL_WD,
               T.N_KPJRL_SJ,
               T.N_TSL,
               T.C_CCM_CODE,
               T.C_CCM_DESC,
               T.C_TL,
               T.N_ZJCLS_MIN,
               T.N_ZJCLS_MAX,
               T.C_STL_GRD_TYPE,
               T.C_PROD_NAME,
               T.C_PROD_KIND,
               T.N_TYPE,
               T.C_RH,
               T.C_DFP_HL,
               T.C_HL,
               T.C_XM,
               T.C_CCM_ID,
               T.N_HL_TIME,
               T.N_DFP_HL_TIME,
               T.C_LF,
               T.C_KP,
               T.C_STL_GRD_CLASS,
               T.C_PRO_USE,
               T.C_CUST_SQ,
               T.C_TRANSMODE,
               T.C_REMARK1,
               T.C_REMARK2,
               T.C_REMARK3,
               T.C_REMARK4,
               T.C_REMARK5,
               T.N_KZ_WGT
          FROM TRP_PLAN_ROLL T
         WHERE T.N_STATUS IN (0,1) AND  T.C_MATRL_NAME_SLAB NOT LIKE '%来料%' AND T.C_STL_GRD_SLAB = '" + C_STL_GRD_SLAB + "'";
            #endregion
            sql = sql + "   AND T.C_STD_CODE_SLAB = '" + C_STD_CODE_SLAB + "'";
            sql = sql + "   AND T.C_MATRL_CODE_SLAB = '" + C_MATRL_CODE_SLAB + "'";
            if (C_MATRL_CODE_KP.Trim() != "")
            {
                sql = sql + "   AND T.C_MATRL_CODE_KP ='" + C_MATRL_CODE_KP + "'";
            }
            else
            {
                sql = sql + "   AND T.C_MATRL_CODE_KP IS NULL";
            }
            sql = sql + "   AND T.C_CCM_ID ='" + C_CCM_ID + "'";
            sql = sql + "   AND T.N_GROUP =" + N_GROUP;
            sql = sql + "   AND T.D_DT >=TO_DATE('" + D_DT_B + "','yyyy-mm-dd hh24:mi:ss')";
            // sql = sql + "   AND T.D_DT <=TO_DATE('" + D_DT_E + "','yyyy-mm-dd hh24:mi:ss')";
            sql = sql + "   ) A";
            sql = sql + "  ORDER BY A.N_WGT DESC ";

            return DbHelperOra.Query(sql).Tables[0];

        }


        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet Get_Plan(string C_MATRL_CODE_SLAB, string C_SLAB_SIZE, string C_SLAB_LENGTH, string C_STL_GRD_SLAB, string C_STD_CODE_SLAB)
        {
            StringBuilder strSql = new StringBuilder();

            strSql.Append("SELECT * FROM ( SELECT T.C_INITIALIZE_ITEM_ID AS C_ORDER_ID, T.C_ORDER_NO FROM TRP_PLAN_ROLL T INNER JOIN TMO_ORDER TM ON T.C_INITIALIZE_ITEM_ID=TM.C_ID WHERE T.C_MATRL_CODE_SLAB = '" + C_MATRL_CODE_SLAB + "' AND T.C_SLAB_SIZE = '" + C_SLAB_SIZE + "' AND T.N_SLAB_LENGTH = '" + C_SLAB_LENGTH + "' AND T.C_STL_GRD_SLAB = '" + C_STL_GRD_SLAB + "' AND T.C_STD_CODE_SLAB = '" + C_STD_CODE_SLAB + "' AND T.N_STATUS<>3 AND TM.C_BY1 IS NOT NULL AND TM.C_BY2 IS NOT NULL ORDER BY T.D_DT DESC) WHERE ROWNUM = 1 ");

            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 根据计划号主键获取计划生产明细
        /// </summary>
        /// <param name="C_ID">计划号主键</param>
        /// <returns></returns>
        public DataTable GetOrderProInfo(string C_ID)
        {
            string sql = @"SELECT M.D_PRODUCE_DATE,
       M.C_BATCH_NO,
       M.C_STOVE,
       M.C_SPEC,
       M.C_STL_GRD,
       M.C_ZYX1,
       M.C_ZYX2,
       M.C_BZYQ,
       M.N_QUA,
       M.N_WGT,
       M.N_HG_WGT,
       M.N_TWC_WGT,
       M.N_XY_WGT,
       M.N_BHG_WGT,
       A.C_ID,
       A.C_PLAN_ROLL_ID
  FROM TRP_PLAN_ROLL T
  LEFT JOIN TRP_PLAN_ROLL_ITEM A
    ON T.C_ID = A.C_PLAN_ROLL_ID
  LEFT JOIN TRC_ROLL_MAIN B
    ON A.C_ID = B.C_PLAN_ID
  LEFT JOIN (SELECT X.C_STOVE,
                    X.C_BATCH_NO,
                    X.C_MAT_CODE,
                    X.C_MAT_DESC,
                    X.C_SPEC,
                    X.C_STL_GRD,
                    X.C_STD_CODE,
                    X.C_ZYX1,
                    X.C_ZYX2,
                    X.C_BZYQ,
                    MIN(X.D_PRODUCE_DATE) D_PRODUCE_DATE,
                    SUM(CASE
                          WHEN X.C_JUDGE_LEV_ZH IN ('CK', 'A1', 'A', 'AA', 'AAA') THEN
                           X.N_WGT
                          ELSE
                           0
                        END) N_HG_WGT,
                    SUM(CASE
                          WHEN X.C_JUDGE_LEV_ZH = 'D' THEN
                           X.N_WGT
                          ELSE
                           0
                        END) N_TWC_WGT,
                    SUM(CASE
                          WHEN X.C_JUDGE_LEV_ZH IN ('B1', 'B2') THEN
                           X.N_WGT
                          ELSE
                           0
                        END) N_XY_WGT,
                    SUM(CASE
                          WHEN X.C_JUDGE_LEV_ZH IN ('C1', 'C2') THEN
                           X.N_WGT
                          ELSE
                           0
                        END) N_BHG_WGT,
                    SUM(X.N_WGT) N_WGT,
                    COUNT(1) N_QUA
               FROM TRC_ROLL_PRODCUT X
              GROUP BY X.C_STOVE,
                       X.C_BATCH_NO,
                       X.C_MAT_CODE,
                       X.C_MAT_DESC,
                       X.C_SPEC,
                       X.C_STL_GRD,
                       X.C_STD_CODE,
                       X.C_ZYX1,
                       X.C_ZYX2,
                       X.C_BZYQ) M
    ON B.C_BATCH_NO = M.C_BATCH_NO
 WHERE  M.C_BATCH_NO IS NOT NULL AND T.C_ID = '" + C_ID + "' ORDER BY m.C_BATCH_NO";
            return DbHelperOra.Query(sql).Tables[0];

        }

        /// <summary>
        /// 根据订单号显示订单执行情况
        /// </summary>
        /// <param name="C_ORDER_NO"></param>
        /// <returns></returns>
        public DataTable GetOrderProInfoByOrderNo(string C_ORDER_NO)
        {

            string sql = @"SELECT M.D_PRODUCE_DATE,
       M.C_BATCH_NO,
       M.C_STOVE,
       M.C_SPEC,
       M.C_STL_GRD,
       M.C_ZYX1,
       M.C_ZYX2,
       M.C_BZYQ,
       M.N_QUA,
       M.N_WGT,
       M.N_HG_WGT,
       M.N_TWC_WGT,
       M.N_XY_WGT,
       M.N_BHG_WGT,
       A.C_ID,
       A.C_PLAN_ROLL_ID,
t.c_order_no
  FROM TRP_PLAN_ROLL T
  LEFT JOIN TRP_PLAN_ROLL_ITEM A
    ON T.C_ID = A.C_PLAN_ROLL_ID
  LEFT JOIN TRC_ROLL_MAIN B
    ON A.C_ID = B.C_PLAN_ID
  LEFT JOIN(SELECT X.C_STOVE,
                    X.C_BATCH_NO,
                    X.C_MAT_CODE,
                    X.C_MAT_DESC,
                    X.C_SPEC,
                    X.C_STL_GRD,
                    X.C_STD_CODE,
                    X.C_ZYX1,
                    X.C_ZYX2,
                    X.C_BZYQ,
                    MIN(X.D_PRODUCE_DATE) D_PRODUCE_DATE,
                    SUM(CASE
                          WHEN X.C_JUDGE_LEV_ZH IN ('CK', 'A1', 'A', 'AA', 'AAA') THEN
                           X.N_WGT
                          ELSE
                           0
                        END) N_HG_WGT,
                    SUM(CASE
                          WHEN X.C_JUDGE_LEV_ZH = 'D' THEN
                           X.N_WGT
                          ELSE
                           0
                        END) N_TWC_WGT,
                    SUM(CASE
                          WHEN X.C_JUDGE_LEV_ZH IN('B1', 'B2') THEN
                           X.N_WGT
                          ELSE
                           0
                        END) N_XY_WGT,
                    SUM(CASE
                          WHEN X.C_JUDGE_LEV_ZH IN('C1', 'C2') THEN
                           X.N_WGT
                          ELSE
                           0
                        END) N_BHG_WGT,
                    SUM(X.N_WGT) N_WGT,
                    COUNT(1) N_QUA
               FROM TRC_ROLL_PRODCUT X
              GROUP BY X.C_STOVE,
                       X.C_BATCH_NO,
                       X.C_MAT_CODE,
                       X.C_MAT_DESC,
                       X.C_SPEC,
                       X.C_STL_GRD,
                       X.C_STD_CODE,
                       X.C_ZYX1,
                       X.C_ZYX2,
                       X.C_BZYQ) M
    ON B.C_BATCH_NO = M.C_BATCH_NO
 WHERE M.C_BATCH_NO IS NOT NULL AND T.C_ORDER_NO = '" + C_ORDER_NO + "' ORDER BY m.C_BATCH_NO";

            return DbHelperOra.Query(sql).Tables[0];
        }


        /// <summary>
        /// 获取轧钢计划完成量信息
        /// </summary>
        /// <param name="strTime1">时间1</param>
        /// <param name="strTime2">时间2</param>
        /// <returns></returns>
        public DataSet Get_Zgfx(string strTime1, string strTime2)
        {
            string sql = @" SELECT *
                            FROM (SELECT TP.c_line_desc as 工位,
                            NVL(TP.COU_PLAN, 0) AS 订单数,
                            NVL(TP.WGT_PLAN, 0) AS 计划量,
                            NVL(TPA.COU_PLAN_ACT, 0) AS 订单计划完成数,
                            NVL(TPA.WGT_PLAN_ACT, 0) AS 计划完成量,
                            NVL(TA.COU_ACT, 0) AS 订单实际完成数,
                            NVL(TA.WGT_ACT, 0) AS 实际完成量,
                            (CASE NVL(TP.COU_PLAN,0) WHEN 0 THEN 0 ELSE ROUND(NVL(TPA.COU_PLAN_ACT, 0) / NVL(TP.COU_PLAN, 0) * 100, 2) END) AS 订单计划完成率,
                            (CASE NVL(TP.WGT_PLAN, 0) WHEN 0 THEN 0 ELSE ROUND(NVL(TPA.WGT_PLAN_ACT, 0) / NVL(TP.WGT_PLAN, 0) * 100, 2) END) AS 计划量完成率,
                            (CASE NVL(TP.COU_PLAN, 0) WHEN 0 THEN 0 ELSE ROUND(NVL(TA.COU_ACT, 0) / NVL(TP.COU_PLAN, 0) * 100, 2) END) AS 订单实际完成率,
                            (CASE NVL(TP.WGT_PLAN, 0) WHEN 0 THEN 0 ELSE ROUND(NVL(TA.WGT_ACT, 0) / NVL(TP.WGT_PLAN, 0) * 100, 2) END) AS 实际量完成率
                            FROM(select t.c_line_desc,
                            t.c_line_code,
                            count(distinct t.c_order_no) as COU_PLAN,
                            sum(t.n_roll_prod_wgt) as WGT_PLAN
                            from trp_plan_item t ";

            sql += " where t.d_p_start_time between to_date('" + strTime1 + "', 'yyyy-mm-dd hh24:mi:ss') and to_date('" + strTime2 + "', 'yyyy-mm-dd hh24:mi:ss') ";

            sql += @" group by t.c_line_desc, t.c_line_code
                      order by t.c_line_code) TP
                      LEFT JOIN
                      (select t.c_line_desc,
                      t.c_line_code,
                      count(distinct t.c_order_no) as COU_PLAN_ACT,
                      sum(td.n_Prod_Wgt) as WGT_PLAN_ACT
                      from trp_plan_item t
                      inner join trp_plan_roll_item tb
                      on tb.c_plan_roll_id = t.c_plan_roll_id
                      inner join trc_roll_main tc
                      on tc.c_plan_id = tb.c_id
                      inner join trc_roll_wgd td
                      on td.c_main_id = tc.c_id ";

            sql += " where t.d_p_start_time between to_date('" + strTime1 + "', 'yyyy-mm-dd hh24:mi:ss') and to_date('" + strTime2 + "', 'yyyy-mm-dd hh24:mi:ss') and td.d_Produce_Date between to_date('" + strTime1 + "', 'yyyy-mm-dd hh24:mi:ss') and to_date('" + strTime2 + "', 'yyyy-mm-dd hh24:mi:ss') ";

            sql += @" group by t.c_line_desc, t.c_line_code
                      order by t.c_line_code) TPA
                      ON TP.c_line_code = TPA.c_line_code
                      LEFT JOIN
                      (select tb.c_line_desc,
                      tb.c_line_code,
                      count(distinct tb.c_order_no) as COU_ACT,
                      sum(td.n_Prod_Wgt) as WGT_ACT
                      from trp_plan_roll_item tb
                      inner join trc_roll_main tc
                      on tc.c_plan_id = tb.c_id
                      inner join trc_roll_wgd td
                      on td.c_main_id = tc.c_id ";

            sql += " where td.d_Produce_Date between to_date('" + strTime1 + "', 'yyyy-mm-dd hh24:mi:ss') and to_date('" + strTime2 + "', 'yyyy-mm-dd hh24:mi:ss') ";

            sql += @" group by tb.c_line_desc, tb.c_line_code
                      order by tb.c_line_code) TA
                      ON TP.c_line_code = TA.c_line_code
                      order by tp.c_line_code)
                      UNION ALL
                      select '修磨' as 工位,
                      0 as 计划炉数,
                      0 as 计划量,
                      COUNT(C_STOVE) as 计划完成炉数,
                      NVL(sum(WGT), 0) as 计划完成量,
                      NVL(SUM(NUM_SJ), 0) as 实际完成炉数,
                      NVL(SUM(WGT_SJ), 0) as 实际完成量,
                      0,
                      0,
                      0,
                      0
                      from(SELECT T.C_BATCH_NO,
                      T.C_STOVE,
                      T.N_QUA * T.N_WGT AS WGT,
                      (SELECT COUNT(TT.C_ID) * T.N_WGT
                      FROM TRC_PLAN_REGROUND_ITEM TT
                      WHERE TT.C_PLAN_REGROUND_ID = T.C_ID
                      AND TT.N_STATUS = 2
                      AND TT.N_STEP = TT.N_TOTALSTEP) AS WGT_SJ,
                      (SELECT COUNT(DISTINCT TT.C_PLAN_REGROUND_ID)
                      FROM TRC_PLAN_REGROUND_ITEM TT
                      WHERE TT.C_PLAN_REGROUND_ID = T.C_ID
                      AND TT.N_STATUS = 2
                      AND TT.N_STEP = TT.N_TOTALSTEP) AS NUM_SJ
                      FROM TRC_PLAN_REGROUND T
                      WHERE t.c_slab_type = 1 ";

            sql += " and T.D_QR_DATE >= TO_DATE('" + strTime1 + "', 'yyyy-mm-dd hh24:mi:ss') AND T.D_QR_DATE <= TO_DATE('" + strTime2 + "', 'yyyy-mm-dd hh24:mi:ss')) ";

            sql += @" UNION ALL 
                      (SELECT TGW.C_STA_DESC,
                      NVL(TP.COU_PLAN,0),
                      NVL(TP.WGT_PLAN,0),
                      NVL(TPA.COU_PLAN_ACT,0),
                      NVL(TPA.WGT_PLAN_ACT,0),
                      NVL(TA.COU_ACT,0),
                      NVL(TA.WGT_ACT,0),
                      (CASE NVL(TP.COU_PLAN,0) WHEN 0 THEN 0 ELSE ROUND(NVL(TPA.COU_PLAN_ACT, 0) / NVL(TP.COU_PLAN, 0) * 100, 2) END) AS 订单计划完成率,
                      (CASE NVL(TP.WGT_PLAN, 0) WHEN 0 THEN 0 ELSE ROUND(NVL(TPA.WGT_PLAN_ACT, 0) / NVL(TP.WGT_PLAN, 0) * 100, 2) END) AS 计划量完成率,
                      (CASE NVL(TP.COU_PLAN, 0) WHEN 0 THEN 0 ELSE ROUND(NVL(TA.COU_ACT, 0) / NVL(TP.COU_PLAN, 0) * 100, 2) END) AS 订单实际完成率,
                      (CASE NVL(TP.WGT_PLAN, 0) WHEN 0 THEN 0 ELSE ROUND(NVL(TA.WGT_ACT, 0) / NVL(TP.WGT_PLAN, 0) * 100, 2) END) AS 实际量完成率
                      FROM (SELECT T.C_STA_DESC FROM TB_STA T WHERE T.C_STA_CODE LIKE '%KP') TGW
                      LEFT JOIN (SELECT TB.C_STA_DESC,
                      SUM(t.n_kp_wgt) AS WGT_PLAN,
                      COUNT(1) AS COU_PLAN
                      FROM tsp_plan_sms t
                      INNER JOIN TB_STA TB
                      ON T.C_KP_ID = TB.C_ID
                      WHERE t.n_kp_wgt > 0
                      AND t.c_kp = 'Y'
                      AND T.N_STATUS = 1 ";

            sql += " AND T.D_KP_START_TIME BETWEEN to_date('" + strTime1 + "', 'yyyy-mm-dd hh24:mi:ss') AND to_date('" + strTime2 + "', 'yyyy-mm-dd hh24:mi:ss') ";

            sql += @" GROUP BY TB.C_STA_DESC) TP
                      ON TP.C_STA_DESC = TGW.C_STA_DESC
                      LEFT JOIN (SELECT TB.C_LINE_DESC,
                      COUNT(DISTINCT T.C_STOVE) AS COU_PLAN_ACT,
                      SUM(T.N_WGT) AS WGT_PLAN_ACT
                      FROM TRC_COGDOWN_PRODUCT T
                      INNER JOIN TRP_PLAN_COGDOWN TB
                      ON T.C_PLAN_ID = TB.C_ID
                      INNER JOIN TSP_PLAN_SMS TS
                      ON T.C_STOVE = TS.C_STOVE_NO
                      AND T.C_STL_GRD = TS.C_STL_GRD
                      AND T.C_STD_CODE = TS.C_STD_CODE ";

            sql += " WHERE T.D_END_DATE BETWEEN to_date('" + strTime1 + "', 'yyyy-mm-dd hh24:mi:ss') AND to_date('" + strTime2 + "', 'yyyy-mm-dd hh24:mi:ss') AND TS.N_STATUS = 1 AND TS.D_KP_START_TIME BETWEEN to_date('" + strTime1 + "', 'yyyy-mm-dd hh24:mi:ss') AND to_date('" + strTime2 + "', 'yyyy-mm-dd hh24:mi:ss') ";

            sql += @" GROUP BY TB.C_LINE_DESC) TPA
                      ON TPA.C_LINE_DESC = TGW.C_STA_DESC
                      LEFT JOIN (SELECT TB.C_LINE_DESC,
                      COUNT(DISTINCT T.C_STOVE) AS COU_ACT,
                      SUM(T.N_WGT) AS WGT_ACT
                      FROM TRC_COGDOWN_PRODUCT T
                      INNER JOIN TRP_PLAN_COGDOWN TB
                      ON T.C_PLAN_ID = TB.C_ID ";

            sql += " WHERE T.D_END_DATE BETWEEN to_date('" + strTime1 + "', 'yyyy-mm-dd hh24:mi:ss') AND to_date('" + strTime2 + "', 'yyyy-mm-dd hh24:mi:ss') ";

            sql += @" GROUP BY TB.C_LINE_DESC) TA
                      ON TA.C_LINE_DESC = TGW.C_STA_DESC) ";

            return DbHelperOra.Query(sql);
        }

        /// <summary>
        /// 重置下发量
        /// </summary>
        /// <returns></returns>
        public void ResetSendWgt(string id)
        {
            try
            {
                string sql = @"UPDATE  TRP_PLAN_ROLL T SET T.N_ISSUE_WGT=T.N_PROD_WGT WHERE T.C_ID='" + id + "'";
                DbHelperOra.ExecuteSql(sql);

                string sql2 = @"UPDATE  TRP_PLAN_ROLL T SET T.N_STATUS=0 WHERE T.C_ID='" + id + "' AND T.N_WGT>T.N_ISSUE_WGT";
                DbHelperOra.ExecuteSql(sql2);
            }
            catch (Exception e)
            { }
        }

    }
}

