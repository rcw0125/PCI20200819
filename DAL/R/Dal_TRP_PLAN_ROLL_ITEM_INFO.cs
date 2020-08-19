using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;
namespace DAL
{
    public class Dal_TRP_PLAN_ROLL_ITEM_INFO
    {
        public Dal_TRP_PLAN_ROLL_ITEM_INFO()
        { }
        #region  BasicMethod



        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Mod_TRP_PLAN_ROLL_ITEM_INFO model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TRP_PLAN_ROLL_ITEM_INFO(");
            strSql.Append("C_PLAN_ROLL_ID,N_STATUS,C_INITIALIZE_ITEM_ID,C_ORDER_NO,N_WGT,C_MAT_CODE,C_MAT_NAME,C_TECH_PROT,C_SPEC,C_STL_GRD,C_STD_CODE,N_USER_LEV,N_STL_GRD_LEV,N_ORDER_LEV,C_QUALIRY_LEV,D_NEED_DT,D_DELIVERY_DT,D_DT,C_LINE_DESC,C_LINE_CODE,D_P_START_TIME,D_P_END_TIME,N_PROD_TIME,N_SORT,N_ROLL_PROD_WGT,C_ROLL_PROD_EMP_ID,C_STL_ROL_DT,N_PROD_WGT,N_WARE_WGT,N_WARE_OUT_WGT,N_FLAG,N_ISSUE_WGT,C_CUST_NO,C_CUST_NAME,C_SALE_CHANNEL,C_PACK,C_DESIGN_NO,N_GROUP_WGT,C_STA_ID,D_START_TIME,D_END_TIME,C_EMP_ID,D_MOD_DT,N_ROLL_WGT,N_MACH_WGT,C_CAST_NO,C_INITIALIZE_ID,C_FREE_TERM,C_FREE_TERM2,C_AREA,C_PCLX,C_SFHL,D_HL_START_TIME,D_HL_END_TIME,C_SFHL_D,D_DHL_START_TIME,D_DHL_END_TIME,C_SFKP,D_KP_START_TIME,D_KP_END_TIME,C_SFXM,D_XM_START_TIME,D_XM_END_TIME,N_UPLOADSTATUS,C_MATRL_CODE_SLAB,C_MATRL_NAME_SLAB,C_SLAB_SIZE,N_SLAB_LENGTH,N_SLAB_PW,D_CAN_ROLL_TIME,C_ROUTE,N_DIAMETER,C_XM_YQ,N_JRL_WD,N_JRL_SJ,C_STL_GRD_SLAB,C_STD_CODE_SLAB,C_REMARK,N_HG_WGT,N_DP_WGT,N_GP_WGT,N_XY_WGT,N_TW_WGT,N_BHG_WGT,N_HG_WGT_IN,N_GP_WGT_IN,N_XY_WGT_IN,N_TW_WGT_IN,N_BHG_WGT_IN,N_HG_WGT_OUT,N_GP_WGT_OUT,N_XY_WGT_OUT,N_TW_WGT_OUT,N_BHG_WGT_OUT,D_SALE_TIME_MIN,D_SALE_TIME_MAX,D_PRODUCE_DATE_MIN,D_PRODUCE_DATE_MAX,N_SLAB_XH_WGT,C_SLAB_TYPE,C_REMARK1,C_REMARK2,C_REMARK3,C_REMARK4,C_REMARK5,C_ITEM_ID)");
            strSql.Append(" values (");
            strSql.Append(":C_PLAN_ROLL_ID,:N_STATUS,:C_INITIALIZE_ITEM_ID,:C_ORDER_NO,:N_WGT,:C_MAT_CODE,:C_MAT_NAME,:C_TECH_PROT,:C_SPEC,:C_STL_GRD,:C_STD_CODE,:N_USER_LEV,:N_STL_GRD_LEV,:N_ORDER_LEV,:C_QUALIRY_LEV,:D_NEED_DT,:D_DELIVERY_DT,:D_DT,:C_LINE_DESC,:C_LINE_CODE,:D_P_START_TIME,:D_P_END_TIME,:N_PROD_TIME,:N_SORT,:N_ROLL_PROD_WGT,:C_ROLL_PROD_EMP_ID,:C_STL_ROL_DT,:N_PROD_WGT,:N_WARE_WGT,:N_WARE_OUT_WGT,:N_FLAG,:N_ISSUE_WGT,:C_CUST_NO,:C_CUST_NAME,:C_SALE_CHANNEL,:C_PACK,:C_DESIGN_NO,:N_GROUP_WGT,:C_STA_ID,:D_START_TIME,:D_END_TIME,:C_EMP_ID,:D_MOD_DT,:N_ROLL_WGT,:N_MACH_WGT,:C_CAST_NO,:C_INITIALIZE_ID,:C_FREE_TERM,:C_FREE_TERM2,:C_AREA,:C_PCLX,:C_SFHL,:D_HL_START_TIME,:D_HL_END_TIME,:C_SFHL_D,:D_DHL_START_TIME,:D_DHL_END_TIME,:C_SFKP,:D_KP_START_TIME,:D_KP_END_TIME,:C_SFXM,:D_XM_START_TIME,:D_XM_END_TIME,:N_UPLOADSTATUS,:C_MATRL_CODE_SLAB,:C_MATRL_NAME_SLAB,:C_SLAB_SIZE,:N_SLAB_LENGTH,:N_SLAB_PW,:D_CAN_ROLL_TIME,:C_ROUTE,:N_DIAMETER,:C_XM_YQ,:N_JRL_WD,:N_JRL_SJ,:C_STL_GRD_SLAB,:C_STD_CODE_SLAB,:C_REMARK,:N_HG_WGT,:N_DP_WGT,:N_GP_WGT,:N_XY_WGT,:N_TW_WGT,:N_BHG_WGT,:N_HG_WGT_IN,:N_GP_WGT_IN,:N_XY_WGT_IN,:N_TW_WGT_IN,:N_BHG_WGT_IN,:N_HG_WGT_OUT,:N_GP_WGT_OUT,:N_XY_WGT_OUT,:N_TW_WGT_OUT,:N_BHG_WGT_OUT,:D_SALE_TIME_MIN,:D_SALE_TIME_MAX,:D_PRODUCE_DATE_MIN,:D_PRODUCE_DATE_MAX,:N_SLAB_XH_WGT,:C_SLAB_TYPE,:C_REMARK1,:C_REMARK2,:C_REMARK3,:C_REMARK4,:C_REMARK5,:C_ITEM_ID)");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_PLAN_ROLL_ID", OracleDbType.Varchar2,100),
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
                    new OracleParameter(":N_SORT", OracleDbType.Decimal,5),
                    new OracleParameter(":N_ROLL_PROD_WGT", OracleDbType.Decimal,5),
                    new OracleParameter(":C_ROLL_PROD_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STL_ROL_DT", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_PROD_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":N_WARE_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":N_WARE_OUT_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":N_FLAG", OracleDbType.Decimal,15),
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
                    new OracleParameter(":C_SFXM", OracleDbType.Varchar2,100),
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
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_HG_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":N_DP_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":N_GP_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":N_XY_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":N_TW_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":N_BHG_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":N_HG_WGT_IN", OracleDbType.Decimal,15),
                    new OracleParameter(":N_GP_WGT_IN", OracleDbType.Decimal,15),
                    new OracleParameter(":N_XY_WGT_IN", OracleDbType.Decimal,15),
                    new OracleParameter(":N_TW_WGT_IN", OracleDbType.Decimal,15),
                    new OracleParameter(":N_BHG_WGT_IN", OracleDbType.Decimal,15),
                    new OracleParameter(":N_HG_WGT_OUT", OracleDbType.Decimal,15),
                    new OracleParameter(":N_GP_WGT_OUT", OracleDbType.Decimal,15),
                    new OracleParameter(":N_XY_WGT_OUT", OracleDbType.Decimal,15),
                    new OracleParameter(":N_TW_WGT_OUT", OracleDbType.Decimal,15),
                    new OracleParameter(":N_BHG_WGT_OUT", OracleDbType.Decimal,15),
                    new OracleParameter(":D_SALE_TIME_MIN", OracleDbType.Date),
                    new OracleParameter(":D_SALE_TIME_MAX", OracleDbType.Date),
                    new OracleParameter(":D_PRODUCE_DATE_MIN", OracleDbType.Date),
                    new OracleParameter(":D_PRODUCE_DATE_MAX", OracleDbType.Date),
                    new OracleParameter(":N_SLAB_XH_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":C_SLAB_TYPE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_REMARK1", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_REMARK2", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_REMARK3", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_REMARK4", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_REMARK5", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_ITEM_ID", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.C_PLAN_ROLL_ID;
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
            parameters[77].Value = model.C_REMARK;
            parameters[78].Value = model.N_HG_WGT;
            parameters[79].Value = model.N_DP_WGT;
            parameters[80].Value = model.N_GP_WGT;
            parameters[81].Value = model.N_XY_WGT;
            parameters[82].Value = model.N_TW_WGT;
            parameters[83].Value = model.N_BHG_WGT;
            parameters[84].Value = model.N_HG_WGT_IN;
            parameters[85].Value = model.N_GP_WGT_IN;
            parameters[86].Value = model.N_XY_WGT_IN;
            parameters[87].Value = model.N_TW_WGT_IN;
            parameters[88].Value = model.N_BHG_WGT_IN;
            parameters[89].Value = model.N_HG_WGT_OUT;
            parameters[90].Value = model.N_GP_WGT_OUT;
            parameters[91].Value = model.N_XY_WGT_OUT;
            parameters[92].Value = model.N_TW_WGT_OUT;
            parameters[93].Value = model.N_BHG_WGT_OUT;
            parameters[94].Value = model.D_SALE_TIME_MIN;
            parameters[95].Value = model.D_SALE_TIME_MAX;
            parameters[96].Value = model.D_PRODUCE_DATE_MIN;
            parameters[97].Value = model.D_PRODUCE_DATE_MAX;
            parameters[98].Value = model.N_SLAB_XH_WGT;
            parameters[99].Value = model.C_SLAB_TYPE;
            parameters[100].Value = model.C_REMARK1;
            parameters[101].Value = model.C_REMARK2;
            parameters[102].Value = model.C_REMARK3;
            parameters[103].Value = model.C_REMARK4;
            parameters[104].Value = model.C_REMARK5;
            parameters[105].Value = model.C_ITEM_ID;

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
        public bool Add_Trans(Mod_TRP_PLAN_ROLL_ITEM_INFO model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TRP_PLAN_ROLL_ITEM_INFO(");
            strSql.Append("C_PLAN_ROLL_ID,N_STATUS,C_INITIALIZE_ITEM_ID,C_ORDER_NO,N_WGT,C_MAT_CODE,C_MAT_NAME,C_TECH_PROT,C_SPEC,C_STL_GRD,C_STD_CODE,N_USER_LEV,N_STL_GRD_LEV,N_ORDER_LEV,C_QUALIRY_LEV,D_NEED_DT,D_DELIVERY_DT,D_DT,C_LINE_DESC,C_LINE_CODE,D_P_START_TIME,D_P_END_TIME,N_PROD_TIME,N_SORT,N_ROLL_PROD_WGT,C_ROLL_PROD_EMP_ID,C_STL_ROL_DT,N_PROD_WGT,N_WARE_WGT,N_WARE_OUT_WGT,N_FLAG,N_ISSUE_WGT,C_CUST_NO,C_CUST_NAME,C_SALE_CHANNEL,C_PACK,C_DESIGN_NO,N_GROUP_WGT,C_STA_ID,D_START_TIME,D_END_TIME,C_EMP_ID,D_MOD_DT,N_ROLL_WGT,N_MACH_WGT,C_CAST_NO,C_INITIALIZE_ID,C_FREE_TERM,C_FREE_TERM2,C_AREA,C_PCLX,C_SFHL,D_HL_START_TIME,D_HL_END_TIME,C_SFHL_D,D_DHL_START_TIME,D_DHL_END_TIME,C_SFKP,D_KP_START_TIME,D_KP_END_TIME,C_SFXM,D_XM_START_TIME,D_XM_END_TIME,N_UPLOADSTATUS,C_MATRL_CODE_SLAB,C_MATRL_NAME_SLAB,C_SLAB_SIZE,N_SLAB_LENGTH,N_SLAB_PW,D_CAN_ROLL_TIME,C_ROUTE,N_DIAMETER,C_XM_YQ,N_JRL_WD,N_JRL_SJ,C_STL_GRD_SLAB,C_STD_CODE_SLAB,C_REMARK,N_HG_WGT,N_DP_WGT,N_GP_WGT,N_XY_WGT,N_TW_WGT,N_BHG_WGT,N_HG_WGT_IN,N_GP_WGT_IN,N_XY_WGT_IN,N_TW_WGT_IN,N_BHG_WGT_IN,N_HG_WGT_OUT,N_GP_WGT_OUT,N_XY_WGT_OUT,N_TW_WGT_OUT,N_BHG_WGT_OUT,D_SALE_TIME_MIN,D_SALE_TIME_MAX,D_PRODUCE_DATE_MIN,D_PRODUCE_DATE_MAX,N_SLAB_XH_WGT,C_SLAB_TYPE,C_REMARK1,C_REMARK2,C_REMARK3,C_REMARK4,C_REMARK5,C_ITEM_ID)");
            strSql.Append(" values (");
            strSql.Append(":C_PLAN_ROLL_ID,:N_STATUS,:C_INITIALIZE_ITEM_ID,:C_ORDER_NO,:N_WGT,:C_MAT_CODE,:C_MAT_NAME,:C_TECH_PROT,:C_SPEC,:C_STL_GRD,:C_STD_CODE,:N_USER_LEV,:N_STL_GRD_LEV,:N_ORDER_LEV,:C_QUALIRY_LEV,:D_NEED_DT,:D_DELIVERY_DT,:D_DT,:C_LINE_DESC,:C_LINE_CODE,:D_P_START_TIME,:D_P_END_TIME,:N_PROD_TIME,:N_SORT,:N_ROLL_PROD_WGT,:C_ROLL_PROD_EMP_ID,:C_STL_ROL_DT,:N_PROD_WGT,:N_WARE_WGT,:N_WARE_OUT_WGT,:N_FLAG,:N_ISSUE_WGT,:C_CUST_NO,:C_CUST_NAME,:C_SALE_CHANNEL,:C_PACK,:C_DESIGN_NO,:N_GROUP_WGT,:C_STA_ID,:D_START_TIME,:D_END_TIME,:C_EMP_ID,:D_MOD_DT,:N_ROLL_WGT,:N_MACH_WGT,:C_CAST_NO,:C_INITIALIZE_ID,:C_FREE_TERM,:C_FREE_TERM2,:C_AREA,:C_PCLX,:C_SFHL,:D_HL_START_TIME,:D_HL_END_TIME,:C_SFHL_D,:D_DHL_START_TIME,:D_DHL_END_TIME,:C_SFKP,:D_KP_START_TIME,:D_KP_END_TIME,:C_SFXM,:D_XM_START_TIME,:D_XM_END_TIME,:N_UPLOADSTATUS,:C_MATRL_CODE_SLAB,:C_MATRL_NAME_SLAB,:C_SLAB_SIZE,:N_SLAB_LENGTH,:N_SLAB_PW,:D_CAN_ROLL_TIME,:C_ROUTE,:N_DIAMETER,:C_XM_YQ,:N_JRL_WD,:N_JRL_SJ,:C_STL_GRD_SLAB,:C_STD_CODE_SLAB,:C_REMARK,:N_HG_WGT,:N_DP_WGT,:N_GP_WGT,:N_XY_WGT,:N_TW_WGT,:N_BHG_WGT,:N_HG_WGT_IN,:N_GP_WGT_IN,:N_XY_WGT_IN,:N_TW_WGT_IN,:N_BHG_WGT_IN,:N_HG_WGT_OUT,:N_GP_WGT_OUT,:N_XY_WGT_OUT,:N_TW_WGT_OUT,:N_BHG_WGT_OUT,:D_SALE_TIME_MIN,:D_SALE_TIME_MAX,:D_PRODUCE_DATE_MIN,:D_PRODUCE_DATE_MAX,:N_SLAB_XH_WGT,:C_SLAB_TYPE,:C_REMARK1,:C_REMARK2,:C_REMARK3,:C_REMARK4,:C_REMARK5,:C_ITEM_ID)");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_PLAN_ROLL_ID", OracleDbType.Varchar2,100),
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
                    new OracleParameter(":N_SORT", OracleDbType.Decimal,5),
                    new OracleParameter(":N_ROLL_PROD_WGT", OracleDbType.Decimal,5),
                    new OracleParameter(":C_ROLL_PROD_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STL_ROL_DT", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_PROD_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":N_WARE_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":N_WARE_OUT_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":N_FLAG", OracleDbType.Decimal,15),
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
                    new OracleParameter(":C_SFXM", OracleDbType.Varchar2,100),
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
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_HG_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":N_DP_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":N_GP_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":N_XY_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":N_TW_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":N_BHG_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":N_HG_WGT_IN", OracleDbType.Decimal,15),
                    new OracleParameter(":N_GP_WGT_IN", OracleDbType.Decimal,15),
                    new OracleParameter(":N_XY_WGT_IN", OracleDbType.Decimal,15),
                    new OracleParameter(":N_TW_WGT_IN", OracleDbType.Decimal,15),
                    new OracleParameter(":N_BHG_WGT_IN", OracleDbType.Decimal,15),
                    new OracleParameter(":N_HG_WGT_OUT", OracleDbType.Decimal,15),
                    new OracleParameter(":N_GP_WGT_OUT", OracleDbType.Decimal,15),
                    new OracleParameter(":N_XY_WGT_OUT", OracleDbType.Decimal,15),
                    new OracleParameter(":N_TW_WGT_OUT", OracleDbType.Decimal,15),
                    new OracleParameter(":N_BHG_WGT_OUT", OracleDbType.Decimal,15),
                    new OracleParameter(":D_SALE_TIME_MIN", OracleDbType.Date),
                    new OracleParameter(":D_SALE_TIME_MAX", OracleDbType.Date),
                    new OracleParameter(":D_PRODUCE_DATE_MIN", OracleDbType.Date),
                    new OracleParameter(":D_PRODUCE_DATE_MAX", OracleDbType.Date),
                    new OracleParameter(":N_SLAB_XH_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":C_SLAB_TYPE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_REMARK1", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_REMARK2", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_REMARK3", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_REMARK4", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_REMARK5", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_ITEM_ID", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.C_PLAN_ROLL_ID;
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
            parameters[77].Value = model.C_REMARK;
            parameters[78].Value = model.N_HG_WGT;
            parameters[79].Value = model.N_DP_WGT;
            parameters[80].Value = model.N_GP_WGT;
            parameters[81].Value = model.N_XY_WGT;
            parameters[82].Value = model.N_TW_WGT;
            parameters[83].Value = model.N_BHG_WGT;
            parameters[84].Value = model.N_HG_WGT_IN;
            parameters[85].Value = model.N_GP_WGT_IN;
            parameters[86].Value = model.N_XY_WGT_IN;
            parameters[87].Value = model.N_TW_WGT_IN;
            parameters[88].Value = model.N_BHG_WGT_IN;
            parameters[89].Value = model.N_HG_WGT_OUT;
            parameters[90].Value = model.N_GP_WGT_OUT;
            parameters[91].Value = model.N_XY_WGT_OUT;
            parameters[92].Value = model.N_TW_WGT_OUT;
            parameters[93].Value = model.N_BHG_WGT_OUT;
            parameters[94].Value = model.D_SALE_TIME_MIN;
            parameters[95].Value = model.D_SALE_TIME_MAX;
            parameters[96].Value = model.D_PRODUCE_DATE_MIN;
            parameters[97].Value = model.D_PRODUCE_DATE_MAX;
            parameters[98].Value = model.N_SLAB_XH_WGT;
            parameters[99].Value = model.C_SLAB_TYPE;
            parameters[100].Value = model.C_REMARK1;
            parameters[101].Value = model.C_REMARK2;
            parameters[102].Value = model.C_REMARK3;
            parameters[103].Value = model.C_REMARK4;
            parameters[104].Value = model.C_REMARK5;
            parameters[105].Value = model.C_ITEM_ID;

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
        public bool Update(Mod_TRP_PLAN_ROLL_ITEM_INFO model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TRP_PLAN_ROLL_ITEM_INFO set ");
            strSql.Append("C_PLAN_ROLL_ID=:C_PLAN_ROLL_ID,");
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
            strSql.Append("C_REMARK=:C_REMARK,");
            strSql.Append("N_HG_WGT=:N_HG_WGT,");
            strSql.Append("N_DP_WGT=:N_DP_WGT,");
            strSql.Append("N_GP_WGT=:N_GP_WGT,");
            strSql.Append("N_XY_WGT=:N_XY_WGT,");
            strSql.Append("N_TW_WGT=:N_TW_WGT,");
            strSql.Append("N_BHG_WGT=:N_BHG_WGT,");
            strSql.Append("N_HG_WGT_IN=:N_HG_WGT_IN,");
            strSql.Append("N_GP_WGT_IN=:N_GP_WGT_IN,");
            strSql.Append("N_XY_WGT_IN=:N_XY_WGT_IN,");
            strSql.Append("N_TW_WGT_IN=:N_TW_WGT_IN,");
            strSql.Append("N_BHG_WGT_IN=:N_BHG_WGT_IN,");
            strSql.Append("N_HG_WGT_OUT=:N_HG_WGT_OUT,");
            strSql.Append("N_GP_WGT_OUT=:N_GP_WGT_OUT,");
            strSql.Append("N_XY_WGT_OUT=:N_XY_WGT_OUT,");
            strSql.Append("N_TW_WGT_OUT=:N_TW_WGT_OUT,");
            strSql.Append("N_BHG_WGT_OUT=:N_BHG_WGT_OUT,");
            strSql.Append("D_SALE_TIME_MIN=:D_SALE_TIME_MIN,");
            strSql.Append("D_SALE_TIME_MAX=:D_SALE_TIME_MAX,");
            strSql.Append("D_PRODUCE_DATE_MIN=:D_PRODUCE_DATE_MIN,");
            strSql.Append("D_PRODUCE_DATE_MAX=:D_PRODUCE_DATE_MAX,");
            strSql.Append("N_SLAB_XH_WGT=:N_SLAB_XH_WGT,");
            strSql.Append("C_SLAB_TYPE=:C_SLAB_TYPE,");
            strSql.Append("C_REMARK1=:C_REMARK1,");
            strSql.Append("C_REMARK2=:C_REMARK2,");
            strSql.Append("C_REMARK3=:C_REMARK3,");
            strSql.Append("C_REMARK4=:C_REMARK4,");
            strSql.Append("C_REMARK5=:C_REMARK5,");
            strSql.Append("C_ITEM_ID=:C_ITEM_ID");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_PLAN_ROLL_ID", OracleDbType.Varchar2,100),
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
                    new OracleParameter(":N_SORT", OracleDbType.Decimal,5),
                    new OracleParameter(":N_ROLL_PROD_WGT", OracleDbType.Decimal,5),
                    new OracleParameter(":C_ROLL_PROD_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STL_ROL_DT", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_PROD_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":N_WARE_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":N_WARE_OUT_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":N_FLAG", OracleDbType.Decimal,15),
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
                    new OracleParameter(":C_SFXM", OracleDbType.Varchar2,100),
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
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_HG_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":N_DP_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":N_GP_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":N_XY_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":N_TW_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":N_BHG_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":N_HG_WGT_IN", OracleDbType.Decimal,15),
                    new OracleParameter(":N_GP_WGT_IN", OracleDbType.Decimal,15),
                    new OracleParameter(":N_XY_WGT_IN", OracleDbType.Decimal,15),
                    new OracleParameter(":N_TW_WGT_IN", OracleDbType.Decimal,15),
                    new OracleParameter(":N_BHG_WGT_IN", OracleDbType.Decimal,15),
                    new OracleParameter(":N_HG_WGT_OUT", OracleDbType.Decimal,15),
                    new OracleParameter(":N_GP_WGT_OUT", OracleDbType.Decimal,15),
                    new OracleParameter(":N_XY_WGT_OUT", OracleDbType.Decimal,15),
                    new OracleParameter(":N_TW_WGT_OUT", OracleDbType.Decimal,15),
                    new OracleParameter(":N_BHG_WGT_OUT", OracleDbType.Decimal,15),
                    new OracleParameter(":D_SALE_TIME_MIN", OracleDbType.Date),
                    new OracleParameter(":D_SALE_TIME_MAX", OracleDbType.Date),
                    new OracleParameter(":D_PRODUCE_DATE_MIN", OracleDbType.Date),
                    new OracleParameter(":D_PRODUCE_DATE_MAX", OracleDbType.Date),
                    new OracleParameter(":N_SLAB_XH_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":C_SLAB_TYPE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_REMARK1", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_REMARK2", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_REMARK3", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_REMARK4", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_REMARK5", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_ITEM_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.C_PLAN_ROLL_ID;
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
            parameters[77].Value = model.C_REMARK;
            parameters[78].Value = model.N_HG_WGT;
            parameters[79].Value = model.N_DP_WGT;
            parameters[80].Value = model.N_GP_WGT;
            parameters[81].Value = model.N_XY_WGT;
            parameters[82].Value = model.N_TW_WGT;
            parameters[83].Value = model.N_BHG_WGT;
            parameters[84].Value = model.N_HG_WGT_IN;
            parameters[85].Value = model.N_GP_WGT_IN;
            parameters[86].Value = model.N_XY_WGT_IN;
            parameters[87].Value = model.N_TW_WGT_IN;
            parameters[88].Value = model.N_BHG_WGT_IN;
            parameters[89].Value = model.N_HG_WGT_OUT;
            parameters[90].Value = model.N_GP_WGT_OUT;
            parameters[91].Value = model.N_XY_WGT_OUT;
            parameters[92].Value = model.N_TW_WGT_OUT;
            parameters[93].Value = model.N_BHG_WGT_OUT;
            parameters[94].Value = model.D_SALE_TIME_MIN;
            parameters[95].Value = model.D_SALE_TIME_MAX;
            parameters[96].Value = model.D_PRODUCE_DATE_MIN;
            parameters[97].Value = model.D_PRODUCE_DATE_MAX;
            parameters[98].Value = model.N_SLAB_XH_WGT;
            parameters[99].Value = model.C_SLAB_TYPE;
            parameters[100].Value = model.C_REMARK1;
            parameters[101].Value = model.C_REMARK2;
            parameters[102].Value = model.C_REMARK3;
            parameters[103].Value = model.C_REMARK4;
            parameters[104].Value = model.C_REMARK5;
            parameters[105].Value = model.C_ITEM_ID;
            parameters[106].Value = model.C_ID;

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
            strSql.Append("delete from TRP_PLAN_ROLL_ITEM_INFO ");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)
            };
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
        /// 删除一条数据
        /// </summary>
        public bool DeleteItem(string C_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from TRP_PLAN_ROLL_ITEM_INFO ");
            strSql.Append(" where C_ITEM_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)
            };
            parameters[0].Value = C_ID;

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
        public bool Delete_Trans(string C_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from TRP_PLAN_ROLL_ITEM_INFO ");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)
            };
            parameters[0].Value = C_ID;

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
        /// 得到一个对象实体
        /// </summary>
        public Mod_TRP_PLAN_ROLL_ITEM_INFO GetModel(string C_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_PLAN_ROLL_ID,N_STATUS,C_INITIALIZE_ITEM_ID,C_ORDER_NO,N_WGT,C_MAT_CODE,C_MAT_NAME,C_TECH_PROT,C_SPEC,C_STL_GRD,C_STD_CODE,N_USER_LEV,N_STL_GRD_LEV,N_ORDER_LEV,C_QUALIRY_LEV,D_NEED_DT,D_DELIVERY_DT,D_DT,C_LINE_DESC,C_LINE_CODE,D_P_START_TIME,D_P_END_TIME,N_PROD_TIME,N_SORT,N_ROLL_PROD_WGT,C_ROLL_PROD_EMP_ID,C_STL_ROL_DT,N_PROD_WGT,N_WARE_WGT,N_WARE_OUT_WGT,N_FLAG,N_ISSUE_WGT,C_CUST_NO,C_CUST_NAME,C_SALE_CHANNEL,C_PACK,C_DESIGN_NO,N_GROUP_WGT,C_STA_ID,D_START_TIME,D_END_TIME,C_EMP_ID,D_MOD_DT,N_ROLL_WGT,N_MACH_WGT,C_CAST_NO,C_INITIALIZE_ID,C_FREE_TERM,C_FREE_TERM2,C_AREA,C_PCLX,C_SFHL,D_HL_START_TIME,D_HL_END_TIME,C_SFHL_D,D_DHL_START_TIME,D_DHL_END_TIME,C_SFKP,D_KP_START_TIME,D_KP_END_TIME,C_SFXM,D_XM_START_TIME,D_XM_END_TIME,N_UPLOADSTATUS,C_MATRL_CODE_SLAB,C_MATRL_NAME_SLAB,C_SLAB_SIZE,N_SLAB_LENGTH,N_SLAB_PW,D_CAN_ROLL_TIME,C_ROUTE,N_DIAMETER,C_XM_YQ,N_JRL_WD,N_JRL_SJ,C_STL_GRD_SLAB,C_STD_CODE_SLAB,C_REMARK,N_HG_WGT,N_DP_WGT,N_GP_WGT,N_XY_WGT,N_TW_WGT,N_BHG_WGT,N_HG_WGT_IN,N_GP_WGT_IN,N_XY_WGT_IN,N_TW_WGT_IN,N_BHG_WGT_IN,N_HG_WGT_OUT,N_GP_WGT_OUT,N_XY_WGT_OUT,N_TW_WGT_OUT,N_BHG_WGT_OUT,D_SALE_TIME_MIN,D_SALE_TIME_MAX,D_PRODUCE_DATE_MIN,D_PRODUCE_DATE_MAX,N_SLAB_XH_WGT,C_SLAB_TYPE,C_REMARK1,C_REMARK2,C_REMARK3,C_REMARK4,C_REMARK5,C_ITEM_ID from TRP_PLAN_ROLL_ITEM_INFO ");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)
            };
            parameters[0].Value = C_ID;

            Mod_TRP_PLAN_ROLL_ITEM_INFO model = new Mod_TRP_PLAN_ROLL_ITEM_INFO();
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
        public Mod_TRP_PLAN_ROLL_ITEM_INFO DataRowToModel(DataRow row)
        {
            Mod_TRP_PLAN_ROLL_ITEM_INFO model = new Mod_TRP_PLAN_ROLL_ITEM_INFO();
            if (row != null)
            {
                if (row["C_ID"] != null)
                {
                    model.C_ID = row["C_ID"].ToString();
                }
                if (row["C_PLAN_ROLL_ID"] != null)
                {
                    model.C_PLAN_ROLL_ID = row["C_PLAN_ROLL_ID"].ToString();
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
                if (row["C_REMARK"] != null)
                {
                    model.C_REMARK = row["C_REMARK"].ToString();
                }
                if (row["N_HG_WGT"] != null && row["N_HG_WGT"].ToString() != "")
                {
                    model.N_HG_WGT = decimal.Parse(row["N_HG_WGT"].ToString());
                }
                if (row["N_DP_WGT"] != null && row["N_DP_WGT"].ToString() != "")
                {
                    model.N_DP_WGT = decimal.Parse(row["N_DP_WGT"].ToString());
                }
                if (row["N_GP_WGT"] != null && row["N_GP_WGT"].ToString() != "")
                {
                    model.N_GP_WGT = decimal.Parse(row["N_GP_WGT"].ToString());
                }
                if (row["N_XY_WGT"] != null && row["N_XY_WGT"].ToString() != "")
                {
                    model.N_XY_WGT = decimal.Parse(row["N_XY_WGT"].ToString());
                }
                if (row["N_TW_WGT"] != null && row["N_TW_WGT"].ToString() != "")
                {
                    model.N_TW_WGT = decimal.Parse(row["N_TW_WGT"].ToString());
                }
                if (row["N_BHG_WGT"] != null && row["N_BHG_WGT"].ToString() != "")
                {
                    model.N_BHG_WGT = decimal.Parse(row["N_BHG_WGT"].ToString());
                }
                if (row["N_HG_WGT_IN"] != null && row["N_HG_WGT_IN"].ToString() != "")
                {
                    model.N_HG_WGT_IN = decimal.Parse(row["N_HG_WGT_IN"].ToString());
                }
                if (row["N_GP_WGT_IN"] != null && row["N_GP_WGT_IN"].ToString() != "")
                {
                    model.N_GP_WGT_IN = decimal.Parse(row["N_GP_WGT_IN"].ToString());
                }
                if (row["N_XY_WGT_IN"] != null && row["N_XY_WGT_IN"].ToString() != "")
                {
                    model.N_XY_WGT_IN = decimal.Parse(row["N_XY_WGT_IN"].ToString());
                }
                if (row["N_TW_WGT_IN"] != null && row["N_TW_WGT_IN"].ToString() != "")
                {
                    model.N_TW_WGT_IN = decimal.Parse(row["N_TW_WGT_IN"].ToString());
                }
                if (row["N_BHG_WGT_IN"] != null && row["N_BHG_WGT_IN"].ToString() != "")
                {
                    model.N_BHG_WGT_IN = decimal.Parse(row["N_BHG_WGT_IN"].ToString());
                }
                if (row["N_HG_WGT_OUT"] != null && row["N_HG_WGT_OUT"].ToString() != "")
                {
                    model.N_HG_WGT_OUT = decimal.Parse(row["N_HG_WGT_OUT"].ToString());
                }
                if (row["N_GP_WGT_OUT"] != null && row["N_GP_WGT_OUT"].ToString() != "")
                {
                    model.N_GP_WGT_OUT = decimal.Parse(row["N_GP_WGT_OUT"].ToString());
                }
                if (row["N_XY_WGT_OUT"] != null && row["N_XY_WGT_OUT"].ToString() != "")
                {
                    model.N_XY_WGT_OUT = decimal.Parse(row["N_XY_WGT_OUT"].ToString());
                }
                if (row["N_TW_WGT_OUT"] != null && row["N_TW_WGT_OUT"].ToString() != "")
                {
                    model.N_TW_WGT_OUT = decimal.Parse(row["N_TW_WGT_OUT"].ToString());
                }
                if (row["N_BHG_WGT_OUT"] != null && row["N_BHG_WGT_OUT"].ToString() != "")
                {
                    model.N_BHG_WGT_OUT = decimal.Parse(row["N_BHG_WGT_OUT"].ToString());
                }
                if (row["D_SALE_TIME_MIN"] != null && row["D_SALE_TIME_MIN"].ToString() != "")
                {
                    model.D_SALE_TIME_MIN = DateTime.Parse(row["D_SALE_TIME_MIN"].ToString());
                }
                if (row["D_SALE_TIME_MAX"] != null && row["D_SALE_TIME_MAX"].ToString() != "")
                {
                    model.D_SALE_TIME_MAX = DateTime.Parse(row["D_SALE_TIME_MAX"].ToString());
                }
                if (row["D_PRODUCE_DATE_MIN"] != null && row["D_PRODUCE_DATE_MIN"].ToString() != "")
                {
                    model.D_PRODUCE_DATE_MIN = DateTime.Parse(row["D_PRODUCE_DATE_MIN"].ToString());
                }
                if (row["D_PRODUCE_DATE_MAX"] != null && row["D_PRODUCE_DATE_MAX"].ToString() != "")
                {
                    model.D_PRODUCE_DATE_MAX = DateTime.Parse(row["D_PRODUCE_DATE_MAX"].ToString());
                }
                if (row["N_SLAB_XH_WGT"] != null && row["N_SLAB_XH_WGT"].ToString() != "")
                {
                    model.N_SLAB_XH_WGT = decimal.Parse(row["N_SLAB_XH_WGT"].ToString());
                }
                if (row["C_SLAB_TYPE"] != null)
                {
                    model.C_SLAB_TYPE = row["C_SLAB_TYPE"].ToString();
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
                if (row["C_ITEM_ID"] != null)
                {
                    model.C_ITEM_ID = row["C_ITEM_ID"].ToString();
                }
            }
            return model;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_PLAN_ROLL_ID,N_STATUS,C_INITIALIZE_ITEM_ID,C_ORDER_NO,N_WGT,C_MAT_CODE,C_MAT_NAME,C_TECH_PROT,C_SPEC,C_STL_GRD,C_STD_CODE,N_USER_LEV,N_STL_GRD_LEV,N_ORDER_LEV,C_QUALIRY_LEV,D_NEED_DT,D_DELIVERY_DT,D_DT,C_LINE_DESC,C_LINE_CODE,D_P_START_TIME,D_P_END_TIME,N_PROD_TIME,N_SORT,N_ROLL_PROD_WGT,C_ROLL_PROD_EMP_ID,C_STL_ROL_DT,N_PROD_WGT,N_WARE_WGT,N_WARE_OUT_WGT,N_FLAG,N_ISSUE_WGT,C_CUST_NO,C_CUST_NAME,C_SALE_CHANNEL,C_PACK,C_DESIGN_NO,N_GROUP_WGT,C_STA_ID,D_START_TIME,D_END_TIME,C_EMP_ID,D_MOD_DT,N_ROLL_WGT,N_MACH_WGT,C_CAST_NO,C_INITIALIZE_ID,C_FREE_TERM,C_FREE_TERM2,C_AREA,C_PCLX,C_SFHL,D_HL_START_TIME,D_HL_END_TIME,C_SFHL_D,D_DHL_START_TIME,D_DHL_END_TIME,C_SFKP,D_KP_START_TIME,D_KP_END_TIME,C_SFXM,D_XM_START_TIME,D_XM_END_TIME,N_UPLOADSTATUS,C_MATRL_CODE_SLAB,C_MATRL_NAME_SLAB,C_SLAB_SIZE,N_SLAB_LENGTH,N_SLAB_PW,D_CAN_ROLL_TIME,C_ROUTE,N_DIAMETER,C_XM_YQ,N_JRL_WD,N_JRL_SJ,C_STL_GRD_SLAB,C_STD_CODE_SLAB,C_REMARK,N_HG_WGT,N_DP_WGT,N_GP_WGT,N_XY_WGT,N_TW_WGT,N_BHG_WGT,N_HG_WGT_IN,N_GP_WGT_IN,N_XY_WGT_IN,N_TW_WGT_IN,N_BHG_WGT_IN,N_HG_WGT_OUT,N_GP_WGT_OUT,N_XY_WGT_OUT,N_TW_WGT_OUT,N_BHG_WGT_OUT,D_SALE_TIME_MIN,D_SALE_TIME_MAX,D_PRODUCE_DATE_MIN,D_PRODUCE_DATE_MAX,N_SLAB_XH_WGT,C_SLAB_TYPE,C_REMARK1,C_REMARK2,C_REMARK3,C_REMARK4,C_REMARK5,C_ITEM_ID ");
            strSql.Append(" FROM TRP_PLAN_ROLL_ITEM_INFO ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }

            strSql.Append(" ORDER BY N_WGT  DESC ");

            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string timeS, string timeE, string c_stl_grd, string c_std_code, string c_sta_id, string n_status)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * ");
            strSql.Append(" FROM TRP_PLAN_ROLL_ITEM_INFO t where 1=1 ");

            if (timeS.Trim() != "" && timeE.Trim() != "")
            {
                strSql.Append(" and  t.D_MOD_DT between to_date('" + timeS + "','yyyy-mm-dd hh24:mi:ss') and to_date('" + timeE + "','yyyy-mm-dd hh24:mi:ss')");
            }

            if (c_stl_grd.Trim() != "")
            {
                strSql.Append(" and t.c_stl_grd like '%" + c_stl_grd + "%' ");
            }

            if (c_std_code.Trim() != "")
            {
                strSql.Append(" and t.c_std_code like '%" + c_std_code + "%' ");
            }

            if (c_sta_id.Trim() != "")
            {
                strSql.Append(" and t.c_sta_id ='" + c_sta_id + "' ");
            }

            if (n_status.Trim() != "")
            {
                strSql.Append(" and t.n_status ='" + n_status + "' ");
            }
            strSql.Append(" ORDER BY T.D_P_START_TIME ");

            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM TRP_PLAN_ROLL_ITEM_INFO ");
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
                strSql.Append("order by T. desc");
            }
            strSql.Append(")AS Row, T.*  from TRP_PLAN_ROLL_ITEM_INFO T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            return DbHelperOra.Query(strSql.ToString());
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Mod_TRP_PLAN_ROLL_ITEM_INFO GetModel_Up(string c_line_code)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from(SELECT * FROM TRP_PLAN_ROLL_ITEM_INFO T where t.C_STA_ID = '" + c_line_code + "' and t.d_p_end_time is not null and t.n_status not in (2,3) order by t.d_p_end_time desc)where rownum = 1 ");

            Mod_TRP_PLAN_ROLL_ITEM_INFO model = new Mod_TRP_PLAN_ROLL_ITEM_INFO();
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

        #endregion  BasicMethod
        #region  ExtensionMethod
        /// <summary>
        /// 保存排序后的计划
        /// </summary>
        /// <param name="C_ID">计划主键</param>
        /// <param name="D_P_START_TIME">开始时间</param>
        /// <param name="D_P_END_TIME">结束时间</param>
        /// <param name="N_SORT">排序号</param>
        /// <returns>是否成功</returns>
        public bool UpdateSort(string C_ID, DateTime D_P_START_TIME, DateTime D_P_END_TIME, int N_SORT)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TRP_PLAN_ROLL_ITEM_INFO set ");
            strSql.Append("D_P_START_TIME=:D_P_START_TIME,");
            strSql.Append("D_P_END_TIME=:D_P_END_TIME,");
            strSql.Append("N_SORT=:N_SORT");
            strSql.Append(" where C_ID=:C_ID");
            OracleParameter[] parameters = {
                    new OracleParameter(":D_P_START_TIME", OracleDbType.Date),
                    new OracleParameter(":D_P_END_TIME", OracleDbType.Date),
                    new OracleParameter(":N_SORT", OracleDbType.Decimal,5),
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)};
            parameters[0].Value = D_P_START_TIME;
            parameters[1].Value = D_P_END_TIME;
            parameters[2].Value = N_SORT;
            parameters[3].Value = C_ID;
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
        /// 获取订单计划中间表
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public DataTable GetItemInfo(string id)
        {
            string sql = @"SELECT T.*,T.ROWID FROM TRP_PLAN_ROLL_ITEM_INFO   T  
                            WHERE T.C_ITEM_ID='" + id + "' ORDER BY T.N_ISSUE_WGT DESC  ";
            return DbHelperOra.Query(sql).Tables[0];
        }

        /// <summary>
        /// 获取订单计划中间表
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public DataTable GetItemInfoAsc(string id)
        {
            string sql = @"SELECT T.*,T.ROWID FROM TRP_PLAN_ROLL_ITEM_INFO   T  
                            WHERE T.C_ITEM_ID='" + id + "' AND T.N_STATUS=3 ORDER BY T.N_ISSUE_WGT    ";
            return DbHelperOra.Query(sql).Tables[0];
        }

        /// <summary>
        /// 获取订单计划中间表
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public DataTable GetItemInfoAsc(string id, decimal wgt)
        {
            string sql = @"   SELECT * FROM  
                              (
                              SELECT  TRUNC(( NVL(T.N_PROD_WGT, 0))/T.N_ISSUE_WGT,5)  PRESENTAGE, T.*,T.ROWID
                                        FROM TRP_PLAN_ROLL_ITEM_INFO T
                                       WHERE T.C_ITEM_ID = '" + id + "'  AND T.N_STATUS=3   ) M  ORDER BY M.PRESENTAGE,  M.N_WGT DESC ";
            return DbHelperOra.Query(sql).Tables[0];
        }



        /// <summary>
        /// 获取订单计划中间表(组坯)
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public DataTable GetItemInfo_Assm(string id)
        {
            string sql = @"SELECT T.*,T.ROWID FROM TRP_PLAN_ROLL_ITEM_INFO   T  
                            WHERE T.C_ITEM_ID='" + id + "' AND T.C_REMARK1='1' ORDER BY T.N_ISSUE_WGT DESC  ";
            return DbHelperOra.Query(sql).Tables[0];
        }

        /// <summary>
        /// 获取订单计划中间表(组坯)
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public DataTable GetItemInfo_Assm_Two(string id)
        {
            string sql = @"SELECT T.*,T.ROWID FROM TRP_PLAN_ROLL_ITEM_INFO   T  
                            WHERE T.C_ITEM_ID='" + id + "'  ORDER BY T.N_ISSUE_WGT DESC  ";
            return DbHelperOra.Query(sql).Tables[0];
        }

        /// <summary>
        /// 获取订单计划中间表(组坯)
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public DataTable GetItemInfoAsc_Assm(string id)
        {
            string sql = @"SELECT T.*,T.ROWID FROM TRP_PLAN_ROLL_ITEM_INFO   T  
                            WHERE T.C_ITEM_ID='" + id + "' AND T.C_REMARK1='0' ORDER BY T.N_ISSUE_WGT    ";
            return DbHelperOra.Query(sql).Tables[0];
        }

        /// <summary>
        /// 获取合并订单号
        /// </summary>
        /// <param name="id">合并ItemID</param>
        /// <returns></returns>
        public DataTable GetJoinOrder(string id)
        {
            string sql = @"SELECT  T.* FROM 
TRP_PLAN_ROLL_ITEM_INFO T WHERE T.C_ITEM_ID='" + id + "' ";
            return DbHelperOra.Query(sql).Tables[0];
        }

        /// <summary>
        /// 获取批次回执关联订单
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public DataTable GetRelationOrder(string id)
        {
            string sql = @" SELECT * FROM TRP_WGD_ITEMINFO  T 
LEFT JOIN TRP_PLAN_ROLL_ITEM_INFO N ON N.C_ID=T.C_ITEM_INFO_ID
WHERE T.C_WGD_ID='"+ id + "' ";
            return DbHelperOra.Query(sql).Tables[0];
        }


        /// <summary>
        /// 修改计划量
        /// </summary>
        /// <param name="id"></param>
        /// <param name="wgt"></param>
        /// <returns></returns>
        public bool UpdateGroupWgt(string id, decimal? wgt)
        {
            string sql = @"UPDATE TRP_PLAN_ROLL_ITEM_INFO TPR SET TPR.N_GROUP_WGT=TPR.N_GROUP_WGT+" + wgt.Value + "  WHERE TPR.C_ID='" + id + "'";

            int rows = DbHelperOra.ExecuteSql(sql);
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
        /// 修改计划量
        /// </summary>
        /// <param name="id"></param>
        /// <param name="wgt"></param>
        /// <returns></returns>
        public bool UpdateGroupWgtTwo(string id, decimal? wgt)
        {
            string sql = @" UPDATE TRP_PLAN_ROLL_ITEM_INFO TPR SET TPR.N_GROUP_WGT=TPR.N_GROUP_WGT-" + wgt.Value + "  WHERE TPR.C_ID='" + id + "'";

            int rows = DbHelperOra.ExecuteSql(sql);
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
        /// 修改计划状态（remark1）
        /// </summary>
        /// <param name="id"></param>
        /// <param name="wgt"></param>
        /// <returns></returns>
        public bool UpdateAssmStatus(string id)
        {
            string sql = @"UPDATE TRP_PLAN_ROLL_ITEM_INFO TPR SET TPR.C_REMARK1='1' WHERE TPR.C_ID='" + id + "' AND TPR.N_GROUP_WGT>=TPR.N_WGT";

            int rows = DbHelperOra.ExecuteSql(sql);
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
        /// 修改计划状态（remark1）
        /// </summary>
        /// <param name="id"></param>
        /// <param name="wgt"></param>
        /// <returns></returns>
        public bool UpdateAssmStatusTwo(string id)
        {
            string sql = @" UPDATE TRP_PLAN_ROLL_ITEM_INFO TPR SET TPR.C_REMARK1='0' WHERE TPR.C_ID='" + id + "' AND TPR.N_GROUP_WGT<=0 ";

            int rows = DbHelperOra.ExecuteSql(sql);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        #endregion  ExtensionMethod
    }
}
