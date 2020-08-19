using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;
namespace DAL
{
    /// <summary>
    /// 数据访问类:TRP_PLAN_ROLL_ITEM
    /// </summary>
    public partial class Dal_TRP_PLAN_ROLL_ITEM
    {
        public Dal_TRP_PLAN_ROLL_ITEM()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string C_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TRP_PLAN_ROLL_ITEM");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)         };
            parameters[0].Value = C_ID;

            return DbHelperOra.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Mod_TRP_PLAN_ROLL_ITEM model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TRP_PLAN_ROLL_ITEM(");
            strSql.Append("C_PLAN_ROLL_ID,N_STATUS,C_INITIALIZE_ITEM_ID,C_ORDER_NO,N_WGT,C_MAT_CODE,C_MAT_NAME,C_TECH_PROT,C_SPEC,C_STL_GRD,C_STD_CODE,N_USER_LEV,N_STL_GRD_LEV,N_ORDER_LEV,C_QUALIRY_LEV,D_NEED_DT,D_DELIVERY_DT,D_DT,C_LINE_DESC,C_LINE_CODE,D_P_START_TIME,D_P_END_TIME,N_PROD_TIME,N_SORT,N_ROLL_PROD_WGT,C_ROLL_PROD_EMP_ID,C_STL_ROL_DT,N_PROD_WGT,N_WARE_WGT,N_WARE_OUT_WGT,N_FLAG,N_ISSUE_WGT,C_CUST_NO,C_CUST_NAME,C_SALE_CHANNEL,C_PACK,C_DESIGN_NO,N_GROUP_WGT,C_STA_ID,D_START_TIME,D_END_TIME,C_EMP_ID,D_MOD_DT,N_ROLL_WGT,N_MACH_WGT,C_CAST_NO,C_INITIALIZE_ID,C_FREE_TERM,C_FREE_TERM2,C_AREA,C_PCLX,C_SFHL,D_HL_START_TIME,D_HL_END_TIME,C_SFHL_D,D_DHL_START_TIME,D_DHL_END_TIME,C_SFKP,D_KP_START_TIME,D_KP_END_TIME,C_SFXM,D_XM_START_TIME,D_XM_END_TIME,N_UPLOADSTATUS,C_MATRL_CODE_SLAB,C_MATRL_NAME_SLAB,C_SLAB_SIZE,N_SLAB_LENGTH,N_SLAB_PW,D_CAN_ROLL_TIME,C_ROUTE,N_DIAMETER,C_XM_YQ,N_JRL_WD,N_JRL_SJ,C_STL_GRD_SLAB,C_STD_CODE_SLAB,C_REMARK,N_HG_WGT,N_DP_WGT,N_GP_WGT,N_XY_WGT,N_TW_WGT,N_BHG_WGT,N_HG_WGT_IN,N_GP_WGT_IN,N_XY_WGT_IN,N_TW_WGT_IN,N_BHG_WGT_IN,N_HG_WGT_OUT,N_GP_WGT_OUT,N_XY_WGT_OUT,N_TW_WGT_OUT,N_BHG_WGT_OUT,D_SALE_TIME_MIN,D_SALE_TIME_MAX,D_PRODUCE_DATE_MIN,D_PRODUCE_DATE_MAX,N_SLAB_XH_WGT,C_SLAB_TYPE,C_REMARK1,C_REMARK2,C_REMARK3,C_REMARK4,C_REMARK5,N_IS_MERGE)");
            strSql.Append(" values (");
            strSql.Append(":C_PLAN_ROLL_ID,:N_STATUS,:C_INITIALIZE_ITEM_ID,:C_ORDER_NO,:N_WGT,:C_MAT_CODE,:C_MAT_NAME,:C_TECH_PROT,:C_SPEC,:C_STL_GRD,:C_STD_CODE,:N_USER_LEV,:N_STL_GRD_LEV,:N_ORDER_LEV,:C_QUALIRY_LEV,:D_NEED_DT,:D_DELIVERY_DT,:D_DT,:C_LINE_DESC,:C_LINE_CODE,:D_P_START_TIME,:D_P_END_TIME,:N_PROD_TIME,:N_SORT,:N_ROLL_PROD_WGT,:C_ROLL_PROD_EMP_ID,:C_STL_ROL_DT,:N_PROD_WGT,:N_WARE_WGT,:N_WARE_OUT_WGT,:N_FLAG,:N_ISSUE_WGT,:C_CUST_NO,:C_CUST_NAME,:C_SALE_CHANNEL,:C_PACK,:C_DESIGN_NO,:N_GROUP_WGT,:C_STA_ID,:D_START_TIME,:D_END_TIME,:C_EMP_ID,:D_MOD_DT,:N_ROLL_WGT,:N_MACH_WGT,:C_CAST_NO,:C_INITIALIZE_ID,:C_FREE_TERM,:C_FREE_TERM2,:C_AREA,:C_PCLX,:C_SFHL,:D_HL_START_TIME,:D_HL_END_TIME,:C_SFHL_D,:D_DHL_START_TIME,:D_DHL_END_TIME,:C_SFKP,:D_KP_START_TIME,:D_KP_END_TIME,:C_SFXM,:D_XM_START_TIME,:D_XM_END_TIME,:N_UPLOADSTATUS,:C_MATRL_CODE_SLAB,:C_MATRL_NAME_SLAB,:C_SLAB_SIZE,:N_SLAB_LENGTH,:N_SLAB_PW,:D_CAN_ROLL_TIME,:C_ROUTE,:N_DIAMETER,:C_XM_YQ,:N_JRL_WD,:N_JRL_SJ,:C_STL_GRD_SLAB,:C_STD_CODE_SLAB,:C_REMARK,:N_HG_WGT,:N_DP_WGT,:N_GP_WGT,:N_XY_WGT,:N_TW_WGT,:N_BHG_WGT,:N_HG_WGT_IN,:N_GP_WGT_IN,:N_XY_WGT_IN,:N_TW_WGT_IN,:N_BHG_WGT_IN,:N_HG_WGT_OUT,:N_GP_WGT_OUT,:N_XY_WGT_OUT,:N_TW_WGT_OUT,:N_BHG_WGT_OUT,:D_SALE_TIME_MIN,:D_SALE_TIME_MAX,:D_PRODUCE_DATE_MIN,:D_PRODUCE_DATE_MAX,:N_SLAB_XH_WGT,:C_SLAB_TYPE,:C_REMARK1,:C_REMARK2,:C_REMARK3,:C_REMARK4,:C_REMARK5,:N_IS_MERGE)");
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
                    new OracleParameter(":N_IS_MERGE", OracleDbType.Decimal,1)};
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
            parameters[105].Value = model.N_IS_MERGE;

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
        public bool Add_Tran(Mod_TRP_PLAN_ROLL_ITEM model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TRP_PLAN_ROLL_ITEM(");
            strSql.Append("C_ID,C_PLAN_ROLL_ID,N_STATUS,C_INITIALIZE_ITEM_ID,C_ORDER_NO,N_WGT,C_MAT_CODE,C_MAT_NAME,C_TECH_PROT,C_SPEC,C_STL_GRD,C_STD_CODE,N_USER_LEV,N_STL_GRD_LEV,N_ORDER_LEV,C_QUALIRY_LEV,D_NEED_DT,D_DELIVERY_DT,D_DT,C_LINE_DESC,C_LINE_CODE,D_P_START_TIME,D_P_END_TIME,N_PROD_TIME,N_SORT,N_ROLL_PROD_WGT,C_ROLL_PROD_EMP_ID,C_STL_ROL_DT,N_PROD_WGT,N_WARE_WGT,N_WARE_OUT_WGT,N_FLAG,N_ISSUE_WGT,C_CUST_NO,C_CUST_NAME,C_SALE_CHANNEL,C_PACK,C_DESIGN_NO,N_GROUP_WGT,C_STA_ID,D_START_TIME,D_END_TIME,C_EMP_ID,D_MOD_DT,N_ROLL_WGT,N_MACH_WGT,C_CAST_NO,C_INITIALIZE_ID,C_FREE_TERM,C_FREE_TERM2,C_AREA,C_PCLX,C_SFHL,D_HL_START_TIME,D_HL_END_TIME,C_SFHL_D,D_DHL_START_TIME,D_DHL_END_TIME,C_SFKP,D_KP_START_TIME,D_KP_END_TIME,C_SFXM,D_XM_START_TIME,D_XM_END_TIME,N_UPLOADSTATUS,C_MATRL_CODE_SLAB,C_MATRL_NAME_SLAB,C_SLAB_SIZE,N_SLAB_LENGTH,N_SLAB_PW,D_CAN_ROLL_TIME,C_ROUTE,N_DIAMETER,C_XM_YQ,N_JRL_WD,N_JRL_SJ,C_STL_GRD_SLAB,C_STD_CODE_SLAB,C_REMARK,N_HG_WGT,N_DP_WGT,N_GP_WGT,N_XY_WGT,N_TW_WGT,N_BHG_WGT,N_HG_WGT_IN,N_GP_WGT_IN,N_XY_WGT_IN,N_TW_WGT_IN,N_BHG_WGT_IN,N_HG_WGT_OUT,N_GP_WGT_OUT,N_XY_WGT_OUT,N_TW_WGT_OUT,N_BHG_WGT_OUT,D_SALE_TIME_MIN,D_SALE_TIME_MAX,D_PRODUCE_DATE_MIN,D_PRODUCE_DATE_MAX,N_SLAB_XH_WGT,C_SLAB_TYPE,C_REMARK1,C_REMARK2,C_REMARK3,C_REMARK4,C_REMARK5,N_IS_MERGE)");
            strSql.Append(" values (");
            strSql.Append(":C_ID,:C_PLAN_ROLL_ID,:N_STATUS,:C_INITIALIZE_ITEM_ID,:C_ORDER_NO,:N_WGT,:C_MAT_CODE,:C_MAT_NAME,:C_TECH_PROT,:C_SPEC,:C_STL_GRD,:C_STD_CODE,:N_USER_LEV,:N_STL_GRD_LEV,:N_ORDER_LEV,:C_QUALIRY_LEV,:D_NEED_DT,:D_DELIVERY_DT,:D_DT,:C_LINE_DESC,:C_LINE_CODE,:D_P_START_TIME,:D_P_END_TIME,:N_PROD_TIME,:N_SORT,:N_ROLL_PROD_WGT,:C_ROLL_PROD_EMP_ID,:C_STL_ROL_DT,:N_PROD_WGT,:N_WARE_WGT,:N_WARE_OUT_WGT,:N_FLAG,:N_ISSUE_WGT,:C_CUST_NO,:C_CUST_NAME,:C_SALE_CHANNEL,:C_PACK,:C_DESIGN_NO,:N_GROUP_WGT,:C_STA_ID,:D_START_TIME,:D_END_TIME,:C_EMP_ID,:D_MOD_DT,:N_ROLL_WGT,:N_MACH_WGT,:C_CAST_NO,:C_INITIALIZE_ID,:C_FREE_TERM,:C_FREE_TERM2,:C_AREA,:C_PCLX,:C_SFHL,:D_HL_START_TIME,:D_HL_END_TIME,:C_SFHL_D,:D_DHL_START_TIME,:D_DHL_END_TIME,:C_SFKP,:D_KP_START_TIME,:D_KP_END_TIME,:C_SFXM,:D_XM_START_TIME,:D_XM_END_TIME,:N_UPLOADSTATUS,:C_MATRL_CODE_SLAB,:C_MATRL_NAME_SLAB,:C_SLAB_SIZE,:N_SLAB_LENGTH,:N_SLAB_PW,:D_CAN_ROLL_TIME,:C_ROUTE,:N_DIAMETER,:C_XM_YQ,:N_JRL_WD,:N_JRL_SJ,:C_STL_GRD_SLAB,:C_STD_CODE_SLAB,:C_REMARK,:N_HG_WGT,:N_DP_WGT,:N_GP_WGT,:N_XY_WGT,:N_TW_WGT,:N_BHG_WGT,:N_HG_WGT_IN,:N_GP_WGT_IN,:N_XY_WGT_IN,:N_TW_WGT_IN,:N_BHG_WGT_IN,:N_HG_WGT_OUT,:N_GP_WGT_OUT,:N_XY_WGT_OUT,:N_TW_WGT_OUT,:N_BHG_WGT_OUT,:D_SALE_TIME_MIN,:D_SALE_TIME_MAX,:D_PRODUCE_DATE_MIN,:D_PRODUCE_DATE_MAX,:N_SLAB_XH_WGT,:C_SLAB_TYPE,:C_REMARK1,:C_REMARK2,:C_REMARK3,:C_REMARK4,:C_REMARK5,:N_IS_MERGE)");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100),
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
                    new OracleParameter(":N_IS_MERGE", OracleDbType.Decimal,1)};


            parameters[0].Value = model.C_ID;
            parameters[1].Value = model.C_PLAN_ROLL_ID;
            parameters[2].Value = model.N_STATUS;
            parameters[3].Value = model.C_INITIALIZE_ITEM_ID;
            parameters[4].Value = model.C_ORDER_NO;
            parameters[5].Value = model.N_WGT;
            parameters[6].Value = model.C_MAT_CODE;
            parameters[7].Value = model.C_MAT_NAME;
            parameters[8].Value = model.C_TECH_PROT;
            parameters[9].Value = model.C_SPEC;
            parameters[10].Value = model.C_STL_GRD;
            parameters[11].Value = model.C_STD_CODE;
            parameters[12].Value = model.N_USER_LEV;
            parameters[13].Value = model.N_STL_GRD_LEV;
            parameters[14].Value = model.N_ORDER_LEV;
            parameters[15].Value = model.C_QUALIRY_LEV;
            parameters[16].Value = model.D_NEED_DT;
            parameters[17].Value = model.D_DELIVERY_DT;
            parameters[18].Value = model.D_DT;
            parameters[19].Value = model.C_LINE_DESC;
            parameters[20].Value = model.C_LINE_CODE;
            parameters[21].Value = model.D_P_START_TIME;
            parameters[22].Value = model.D_P_END_TIME;
            parameters[23].Value = model.N_PROD_TIME;
            parameters[24].Value = model.N_SORT;
            parameters[25].Value = model.N_ROLL_PROD_WGT;
            parameters[26].Value = model.C_ROLL_PROD_EMP_ID;
            parameters[27].Value = model.C_STL_ROL_DT;
            parameters[28].Value = model.N_PROD_WGT;
            parameters[29].Value = model.N_WARE_WGT;
            parameters[30].Value = model.N_WARE_OUT_WGT;
            parameters[31].Value = model.N_FLAG;
            parameters[32].Value = model.N_ISSUE_WGT;
            parameters[33].Value = model.C_CUST_NO;
            parameters[34].Value = model.C_CUST_NAME;
            parameters[35].Value = model.C_SALE_CHANNEL;
            parameters[36].Value = model.C_PACK;
            parameters[37].Value = model.C_DESIGN_NO;
            parameters[38].Value = model.N_GROUP_WGT;
            parameters[39].Value = model.C_STA_ID;
            parameters[40].Value = model.D_START_TIME;
            parameters[41].Value = model.D_END_TIME;
            parameters[42].Value = model.C_EMP_ID;
            parameters[43].Value = model.D_MOD_DT;
            parameters[44].Value = model.N_ROLL_WGT;
            parameters[45].Value = model.N_MACH_WGT;
            parameters[46].Value = model.C_CAST_NO;
            parameters[47].Value = model.C_INITIALIZE_ID;
            parameters[48].Value = model.C_FREE_TERM;
            parameters[49].Value = model.C_FREE_TERM2;
            parameters[50].Value = model.C_AREA;
            parameters[51].Value = model.C_PCLX;
            parameters[52].Value = model.C_SFHL;
            parameters[53].Value = model.D_HL_START_TIME;
            parameters[54].Value = model.D_HL_END_TIME;
            parameters[55].Value = model.C_SFHL_D;
            parameters[56].Value = model.D_DHL_START_TIME;
            parameters[57].Value = model.D_DHL_END_TIME;
            parameters[58].Value = model.C_SFKP;
            parameters[59].Value = model.D_KP_START_TIME;
            parameters[60].Value = model.D_KP_END_TIME;
            parameters[61].Value = model.C_SFXM;
            parameters[62].Value = model.D_XM_START_TIME;
            parameters[63].Value = model.D_XM_END_TIME;
            parameters[64].Value = model.N_UPLOADSTATUS;
            parameters[65].Value = model.C_MATRL_CODE_SLAB;
            parameters[66].Value = model.C_MATRL_NAME_SLAB;
            parameters[67].Value = model.C_SLAB_SIZE;
            parameters[68].Value = model.N_SLAB_LENGTH;
            parameters[69].Value = model.N_SLAB_PW;
            parameters[70].Value = model.D_CAN_ROLL_TIME;
            parameters[71].Value = model.C_ROUTE;
            parameters[72].Value = model.N_DIAMETER;
            parameters[73].Value = model.C_XM_YQ;
            parameters[74].Value = model.N_JRL_WD;
            parameters[75].Value = model.N_JRL_SJ;
            parameters[76].Value = model.C_STL_GRD_SLAB;
            parameters[77].Value = model.C_STD_CODE_SLAB;
            parameters[78].Value = model.C_REMARK;
            parameters[79].Value = model.N_HG_WGT;
            parameters[80].Value = model.N_DP_WGT;
            parameters[81].Value = model.N_GP_WGT;
            parameters[82].Value = model.N_XY_WGT;
            parameters[83].Value = model.N_TW_WGT;
            parameters[84].Value = model.N_BHG_WGT;
            parameters[85].Value = model.N_HG_WGT_IN;
            parameters[86].Value = model.N_GP_WGT_IN;
            parameters[87].Value = model.N_XY_WGT_IN;
            parameters[88].Value = model.N_TW_WGT_IN;
            parameters[89].Value = model.N_BHG_WGT_IN;
            parameters[90].Value = model.N_HG_WGT_OUT;
            parameters[91].Value = model.N_GP_WGT_OUT;
            parameters[92].Value = model.N_XY_WGT_OUT;
            parameters[93].Value = model.N_TW_WGT_OUT;
            parameters[94].Value = model.N_BHG_WGT_OUT;
            parameters[95].Value = model.D_SALE_TIME_MIN;
            parameters[96].Value = model.D_SALE_TIME_MAX;
            parameters[97].Value = model.D_PRODUCE_DATE_MIN;
            parameters[98].Value = model.D_PRODUCE_DATE_MAX;
            parameters[99].Value = model.N_SLAB_XH_WGT;
            parameters[100].Value = model.C_SLAB_TYPE;
            parameters[101].Value = model.C_REMARK1;
            parameters[102].Value = model.C_REMARK2;
            parameters[103].Value = model.C_REMARK3;
            parameters[104].Value = model.C_REMARK4;
            parameters[105].Value = model.C_REMARK5;
            parameters[106].Value = model.N_IS_MERGE;

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
        /// 增加一条数据
        /// </summary>
        public bool Add_Trans(Mod_TRP_PLAN_ROLL_ITEM model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TRP_PLAN_ROLL_ITEM(");
            strSql.Append("C_PLAN_ROLL_ID,N_STATUS,C_INITIALIZE_ITEM_ID,C_ORDER_NO,N_WGT,C_MAT_CODE,C_MAT_NAME,C_TECH_PROT,C_SPEC,C_STL_GRD,C_STD_CODE,N_USER_LEV,N_STL_GRD_LEV,N_ORDER_LEV,C_QUALIRY_LEV,D_NEED_DT,D_DELIVERY_DT,D_DT,C_LINE_DESC,C_LINE_CODE,D_P_START_TIME,D_P_END_TIME,N_PROD_TIME,N_SORT,N_ROLL_PROD_WGT,C_ROLL_PROD_EMP_ID,C_STL_ROL_DT,N_PROD_WGT,N_WARE_WGT,N_WARE_OUT_WGT,N_FLAG,N_ISSUE_WGT,C_CUST_NO,C_CUST_NAME,C_SALE_CHANNEL,C_PACK,C_DESIGN_NO,N_GROUP_WGT,C_STA_ID,D_START_TIME,D_END_TIME,C_EMP_ID,D_MOD_DT,N_ROLL_WGT,N_MACH_WGT,C_CAST_NO,C_INITIALIZE_ID,C_FREE_TERM,C_FREE_TERM2,C_AREA,C_PCLX,C_SFHL,D_HL_START_TIME,D_HL_END_TIME,C_SFHL_D,D_DHL_START_TIME,D_DHL_END_TIME,C_SFKP,D_KP_START_TIME,D_KP_END_TIME,C_SFXM,D_XM_START_TIME,D_XM_END_TIME,N_UPLOADSTATUS,C_MATRL_CODE_SLAB,C_MATRL_NAME_SLAB,C_SLAB_SIZE,N_SLAB_LENGTH,N_SLAB_PW,D_CAN_ROLL_TIME,C_ROUTE,N_DIAMETER,C_XM_YQ,N_JRL_WD,N_JRL_SJ,C_STL_GRD_SLAB,C_STD_CODE_SLAB,C_REMARK,N_HG_WGT,N_DP_WGT,N_GP_WGT,N_XY_WGT,N_TW_WGT,N_BHG_WGT,N_HG_WGT_IN,N_GP_WGT_IN,N_XY_WGT_IN,N_TW_WGT_IN,N_BHG_WGT_IN,N_HG_WGT_OUT,N_GP_WGT_OUT,N_XY_WGT_OUT,N_TW_WGT_OUT,N_BHG_WGT_OUT,D_SALE_TIME_MIN,D_SALE_TIME_MAX,D_PRODUCE_DATE_MIN,D_PRODUCE_DATE_MAX,N_SLAB_XH_WGT,C_SLAB_TYPE,C_REMARK1,C_REMARK2,C_REMARK3,C_REMARK4,C_REMARK5,N_IS_MERGE)");
            strSql.Append(" values (");
            strSql.Append(":C_PLAN_ROLL_ID,:N_STATUS,:C_INITIALIZE_ITEM_ID,:C_ORDER_NO,:N_WGT,:C_MAT_CODE,:C_MAT_NAME,:C_TECH_PROT,:C_SPEC,:C_STL_GRD,:C_STD_CODE,:N_USER_LEV,:N_STL_GRD_LEV,:N_ORDER_LEV,:C_QUALIRY_LEV,:D_NEED_DT,:D_DELIVERY_DT,:D_DT,:C_LINE_DESC,:C_LINE_CODE,:D_P_START_TIME,:D_P_END_TIME,:N_PROD_TIME,:N_SORT,:N_ROLL_PROD_WGT,:C_ROLL_PROD_EMP_ID,:C_STL_ROL_DT,:N_PROD_WGT,:N_WARE_WGT,:N_WARE_OUT_WGT,:N_FLAG,:N_ISSUE_WGT,:C_CUST_NO,:C_CUST_NAME,:C_SALE_CHANNEL,:C_PACK,:C_DESIGN_NO,:N_GROUP_WGT,:C_STA_ID,:D_START_TIME,:D_END_TIME,:C_EMP_ID,:D_MOD_DT,:N_ROLL_WGT,:N_MACH_WGT,:C_CAST_NO,:C_INITIALIZE_ID,:C_FREE_TERM,:C_FREE_TERM2,:C_AREA,:C_PCLX,:C_SFHL,:D_HL_START_TIME,:D_HL_END_TIME,:C_SFHL_D,:D_DHL_START_TIME,:D_DHL_END_TIME,:C_SFKP,:D_KP_START_TIME,:D_KP_END_TIME,:C_SFXM,:D_XM_START_TIME,:D_XM_END_TIME,:N_UPLOADSTATUS,:C_MATRL_CODE_SLAB,:C_MATRL_NAME_SLAB,:C_SLAB_SIZE,:N_SLAB_LENGTH,:N_SLAB_PW,:D_CAN_ROLL_TIME,:C_ROUTE,:N_DIAMETER,:C_XM_YQ,:N_JRL_WD,:N_JRL_SJ,:C_STL_GRD_SLAB,:C_STD_CODE_SLAB,:C_REMARK,:N_HG_WGT,:N_DP_WGT,:N_GP_WGT,:N_XY_WGT,:N_TW_WGT,:N_BHG_WGT,:N_HG_WGT_IN,:N_GP_WGT_IN,:N_XY_WGT_IN,:N_TW_WGT_IN,:N_BHG_WGT_IN,:N_HG_WGT_OUT,:N_GP_WGT_OUT,:N_XY_WGT_OUT,:N_TW_WGT_OUT,:N_BHG_WGT_OUT,:D_SALE_TIME_MIN,:D_SALE_TIME_MAX,:D_PRODUCE_DATE_MIN,:D_PRODUCE_DATE_MAX,:N_SLAB_XH_WGT,:C_SLAB_TYPE,:C_REMARK1,:C_REMARK2,:C_REMARK3,:C_REMARK4,:C_REMARK5,:N_IS_MERGE)");
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
                    new OracleParameter(":N_IS_MERGE", OracleDbType.Decimal,1)};
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
            parameters[105].Value = model.N_IS_MERGE;

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
        /// 保存排序后的计划
        /// </summary>
        /// <param name="C_ID">计划主键</param>
        /// <param name="D_P_START_TIME">开始时间</param>
        /// <param name="D_P_END_TIME">结束时间</param>
        /// <param name="N_SORT">排序号</param>
        /// <returns>是否成功</returns>
        public bool Update(string C_ID, DateTime D_P_START_TIME, DateTime D_P_END_TIME, int N_SORT)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TRP_PLAN_ROLL_ITEM set ");
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
        /// 更新一条数据
        /// </summary>
        public bool Update(Mod_TRP_PLAN_ROLL_ITEM model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TRP_PLAN_ROLL_ITEM set ");
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
            strSql.Append("N_IS_MERGE=:N_IS_MERGE");
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
                    new OracleParameter(":N_IS_MERGE", OracleDbType.Decimal,1),
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
            parameters[105].Value = model.N_IS_MERGE;
            parameters[106].Value = model.C_ID;
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
        public bool Update_Trans(Mod_TRP_PLAN_ROLL_ITEM model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TRP_PLAN_ROLL_ITEM set ");
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
            strSql.Append("C_REMARK5=:C_REMARK5");
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
            parameters[105].Value = model.C_ID;
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
            strSql.Append("delete from TRP_PLAN_ROLL_ITEM ");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)         };
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
        public bool Delete(string C_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from TRP_PLAN_ROLL_ITEM ");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)         };
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
        /// 批量删除数据
        /// </summary>
        public bool DeleteList(string C_IDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from TRP_PLAN_ROLL_ITEM ");
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
        public Mod_TRP_PLAN_ROLL_ITEM GetModel_Item(string C_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  *  from TRP_PLAN_ROLL_ITEM ");
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
        public Mod_TRP_PLAN_ROLL_ITEM GetModel(string C_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from TRP_PLAN_ROLL_ITEM ");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)         };
            parameters[0].Value = C_ID;

            Mod_TRP_PLAN_ROLL_ITEM model = new Mod_TRP_PLAN_ROLL_ITEM();
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
        public Mod_TRP_PLAN_ROLL_ITEM GetModel_Up(string c_line_code)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from(SELECT * FROM TRP_PLAN_ROLL_ITEM T where t.C_STA_ID = '" + c_line_code + "' and t.d_p_end_time is not null and t.n_status not in (4,8) order by t.d_p_end_time desc)where rownum = 1 ");

            Mod_TRP_PLAN_ROLL_ITEM model = new Mod_TRP_PLAN_ROLL_ITEM();
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
        /// 得到一个对象实体
        /// </summary>
        public Mod_TRP_PLAN_ROLL_ITEM DataRowToModel(DataRow row)
        {
            Mod_TRP_PLAN_ROLL_ITEM model = new Mod_TRP_PLAN_ROLL_ITEM();
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
                if (row["N_IS_MERGE"] != null && row["N_IS_MERGE"].ToString() != "")
                {
                    model.N_IS_MERGE = decimal.Parse(row["N_IS_MERGE"].ToString());
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
            strSql.Append("select * ");
            strSql.Append(" FROM TRP_PLAN_ROLL_ITEM ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM TRP_PLAN_ROLL_ITEM ");
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
        /// 计划完成
        /// </summary>
        /// <returns></returns>
        public int AccomplishPlan(string planID, int status, decimal pw)
        {
            Dal_TRP_PLAN_ROLL roll = new Dal_TRP_PLAN_ROLL();
            Dal_TRP_PLAN_ROLL_ITEM_INFO itemInfo = new Dal_TRP_PLAN_ROLL_ITEM_INFO();
            int result = 0;
            var model = GetModel_Item(planID);
            var rollModel = roll.GetModel(model.C_PLAN_ROLL_ID);
            if (rollModel == null)
            {
                var itemInfoDt = itemInfo.GetItemInfo(model.C_ID);
                rollModel = roll.GetModel(itemInfoDt.Rows[0]["C_PLAN_ROLL_ID"].ToString());
            }

            bool bol = false;
            decimal? wgt = model.N_WGT;
            decimal? groupWgt = model.N_GROUP_WGT;
            decimal? max = 0;

            Calculate(rollModel, wgt.Value, out bol, out max);

            max = Math.Ceiling(max.Value);

            if (wgt != null && groupWgt != null)
            {
                if (groupWgt >= max)
                {
                    string sql = "UPDATE  TRP_PLAN_ROLL_ITEM  TPC  SET TPC.N_STATUS =" + status + "  WHERE TPC.C_ID = '" + planID + "' ";
                    result = DbHelperOra.ExecuteSql(sql);
                }
            }
            return result;
        }

        /// <summary>
        /// 计划未完成
        /// </summary>
        /// <returns></returns>
        public int UnAccomplishPlan(string planID, int status)
        {
            int result = 0;
            var model = GetModel_Item(planID);
            decimal? wgt = model.N_WGT;
            decimal? groupWgt = model.N_GROUP_WGT;
            if (wgt != null && groupWgt != null)
            {
                if (groupWgt < wgt)
                {
                    string sql = "UPDATE  TRP_PLAN_ROLL_ITEM  TPC  SET TPC.N_STATUS =" + status + "  WHERE TPC.C_ID = '" + planID + "' ";
                    result = DbHelperOra.ExecuteSql(sql);
                }
            }
            return result;
        }

        /// <summary>
        /// 计划未完成
        /// </summary>
        /// <returns></returns>
        public int ResetPlan(string planID, int status)
        {
            int result = 0;
            var model = GetModel_Item(planID);
            decimal? groupWgt = model.N_GROUP_WGT;
            if (groupWgt <= 0)
            {
                string sql = "UPDATE  TRP_PLAN_ROLL_ITEM  TPC  SET TPC.N_STATUS =" + status + "  WHERE TPC.C_ID = '" + planID + "' ";
                result = DbHelperOra.ExecuteSql(sql);
            }
            return result;
        }


        /// <summary>
        /// 验证是否可以组坯
        /// </summary>
        /// <returns></returns>
        public bool ChckIfAsse(string planID, decimal pw)
        {
            Dal_TRP_PLAN_ROLL roll = new Dal_TRP_PLAN_ROLL();
            Dal_TRP_PLAN_ROLL_ITEM_INFO itemInfo = new Dal_TRP_PLAN_ROLL_ITEM_INFO();
            bool isJoinOrder = false;
            var model = GetModel_Item(planID);
            var rollModel = roll.GetModel(model.C_PLAN_ROLL_ID);
            if (rollModel == null)
            {
                var itemInfoDt = itemInfo.GetItemInfo(model.C_ID);
                rollModel = roll.GetModel(itemInfoDt.Rows[0]["C_PLAN_ROLL_ID"].ToString());
                isJoinOrder = true;
            }

            string notLimitSql = @"SELECT T.* FROM  TB_NOT_LIMIT T";
            var dt = DbHelperOra.Query(notLimitSql).Tables[0];

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i]["C_TYPE"].ToString() == "1")
                {
                    if (model.C_STL_GRD == dt.Rows[i]["C_NAME"].ToString())
                        return true;
                }
                if (dt.Rows[i]["C_TYPE"].ToString() == "2")
                {
                    if (rollModel.C_MAT_CODE.StartsWith(dt.Rows[i]["C_NAME"].ToString()))
                        return true;
                }
                if (dt.Rows[i]["C_TYPE"].ToString() == "3")
                {
                    if (rollModel.C_BY4 == dt.Rows[i]["C_NAME"].ToString())
                        return true;
                }
            }


            var CountWgt = rollModel.N_WGT.Value;//总量
            string sql = @"SELECT SUM(T.N_GROUP_WGT) FROM TRP_PLAN_ROLL_ITEM T where T.C_PLAN_ROLL_ID='" + rollModel.C_ID + "' AND (t.n_status=1 OR t.n_status=2 OR t.n_status=3)    ";
            var wgt = DbHelperOra.GetSingle(sql);
            if (isJoinOrder)
            {
                CountWgt = model.N_WGT.Value;
                wgt = model.N_GROUP_WGT.Value;
            }
            var GroupWgt = decimal.Parse(wgt == null ? "0" : wgt.ToString()) + pw;
            bool bol;
            decimal? max;
            Calculate(rollModel, CountWgt, out bol, out max);
            max = Math.Ceiling(max.Value);
            GroupWgt = Math.Floor(GroupWgt);
            if (GroupWgt > max)
                bol = false;
            return bol;
        }

        private static void Calculate(Mod_TRP_PLAN_ROLL rollModel, decimal CountWgt, out bool bol, out decimal? max)
        {
            var wgtDt1 = DbHelperOra.Query("SELECT * FROM TB_CONFIG_LIMIT T WHERE T.C_ID='82B88B5EE5180ED8E055000000000001'").Tables[0];
            var wgtDt2 = DbHelperOra.Query("SELECT * FROM TB_CONFIG_LIMIT T WHERE T.C_ID='82B88B5EE5190ED8E055000000000001'").Tables[0];
            var wgtDt3 = DbHelperOra.Query("SELECT * FROM TB_CONFIG_LIMIT T WHERE T.C_ID='82B88B5EE51A0ED8E055000000000001'").Tables[0];
            var wgtDt4 = DbHelperOra.Query("SELECT * FROM TB_CONFIG_LIMIT T WHERE T.C_ID='82B88B5EE51B0ED8E055000000000001'").Tables[0];

            var wgt01 = decimal.Parse(wgtDt1.Rows[0]["N_NUM"].ToString());
            var limitMin1 = int.Parse(wgtDt1.Rows[0]["N_SECTION_MIN"].ToString());
            var limitMax1 = int.Parse(wgtDt1.Rows[0]["N_SECTION_MAX"].ToString());

            var wgt02 = decimal.Parse(wgtDt2.Rows[0]["N_NUM"].ToString());
            var limitMin2 = int.Parse(wgtDt2.Rows[0]["N_SECTION_MIN"].ToString());
            var limitMax2 = int.Parse(wgtDt2.Rows[0]["N_SECTION_MAX"].ToString());

            var wgt03 = decimal.Parse(wgtDt3.Rows[0]["N_NUM"].ToString());
            var limitMin3 = int.Parse(wgtDt3.Rows[0]["N_SECTION_MIN"].ToString());
            var limitMax3 = int.Parse(wgtDt3.Rows[0]["N_SECTION_MAX"].ToString());

            var wgt04 = decimal.Parse(wgtDt4.Rows[0]["N_NUM"].ToString());
            var limitMin4 = int.Parse(wgtDt4.Rows[0]["N_SECTION_MIN"].ToString());
            //var limitMax4 = int.Parse(wgtDt4.Rows[0]["N_SECTION_MAX"].ToString());

            bol = true;
            decimal? min = 0;
            max = 0;
            if (CountWgt >= limitMin1 && CountWgt <= limitMax1)
            {
                max = CountWgt + wgt01;
                min = CountWgt - wgt01;
            }
            else if (CountWgt > limitMin2 && CountWgt <= limitMax2)
            {
                max = CountWgt + (CountWgt * wgt02);
                min = CountWgt - (CountWgt * wgt02);
            }
            else if (CountWgt > limitMin3 && CountWgt <= limitMax3)
            {
                max = CountWgt + (CountWgt * wgt03);
                min = CountWgt - (CountWgt * wgt03);
            }
            else if (CountWgt > limitMin4)
            {
                max = CountWgt + (CountWgt * wgt04);
                min = CountWgt - (CountWgt * wgt04);
            }

            //var percentageDt = DbHelperOra.Query("SELECT * FROM  TB_CONFIG_PERCENTAGE T").Tables[0];
            //if (percentageDt != null && percentageDt.Rows.Count > 0)
            //{
            //    for (int i = 0; i < percentageDt.Rows.Count; i++)
            //    {
            //        if (percentageDt.Rows[i]["N_TYPE"].ToString() == "1")
            //        {
            //            if (percentageDt.Rows[i]["C_CONDITION"].ToString() == "==")
            //            {
            //                if (rollModel.C_PROD_KIND == percentageDt.Rows[i]["C_PROD_KIND"].ToString())
            //                {
            //                    decimal percent = decimal.Parse(percentageDt.Rows[i]["C_PERCENTAGE"].ToString());
            //                    max = (max / percent) * 100;
            //                    break;
            //                }
            //            }
            //        }
            //        if (percentageDt.Rows[i]["N_TYPE"].ToString() == "2")
            //        {
            //            if (percentageDt.Rows[i]["C_CONDITION"].ToString() == "==" && percentageDt.Rows[i]["C_CONDITION2"].ToString() == "==")
            //            {
            //                if (rollModel.C_PROD_KIND == percentageDt.Rows[i]["C_PROD_KIND"].ToString() && rollModel.C_PROD_NAME == percentageDt.Rows[i]["C_PROD_NAME"].ToString())
            //                {
            //                    decimal percent = decimal.Parse(percentageDt.Rows[i]["C_PERCENTAGE"].ToString());
            //                    max = (max / percent) * 100;
            //                    break;
            //                }
            //            }
            //            if (percentageDt.Rows[i]["C_CONDITION"].ToString() == "==" && percentageDt.Rows[i]["C_CONDITION2"].ToString() == "!=")
            //            {
            //                if (rollModel.C_PROD_KIND == percentageDt.Rows[i]["C_PROD_KIND"].ToString() && rollModel.C_PROD_NAME != percentageDt.Rows[i]["C_PROD_NAME"].ToString())
            //                {
            //                    decimal percent = decimal.Parse(percentageDt.Rows[i]["C_PERCENTAGE"].ToString());
            //                    max = (max / percent) * 100;
            //                    break;
            //                }
            //            }
            //        }
            //        if (percentageDt.Rows[i]["N_TYPE"].ToString() == "3")
            //        {
            //            if (rollModel.C_PROD_KIND == percentageDt.Rows[i]["C_PROD_KIND"].ToString() && GetModelValue(percentageDt.Rows[i]["C_ELSETYPE"].ToString(), rollModel) == percentageDt.Rows[i]["C_ELSECON"].ToString())
            //            {
            //                decimal percent = decimal.Parse(percentageDt.Rows[i]["C_PERCENTAGE"].ToString());
            //                max = (max / percent) * 100;
            //                break;
            //            }
            //        }
            //    }
            //}

            //if (rollModel.C_PROD_KIND == "精品线材")
            //{
            //    max = (max / 96) * 100;
            //}
            //else if (rollModel.C_PROD_KIND == "高速线材" && rollModel.C_PROD_NAME == "普碳钢")
            //{
            //    max = (max / 97m) * 100;
            //}
            //else if (rollModel.C_PROD_KIND == "高速线材" && rollModel.C_PROD_NAME != "普碳钢")
            //{
            //    max = (max / 96.5m) * 100;
            //}
            //else if (rollModel.C_PROD_KIND == "精品线材" && rollModel.C_XM == "Y")
            //{
            //    max = (max / 92m) * 100;
            //}
        }


        /// <summary>
        /// 验证是否可以组坯
        /// </summary>
        /// <returns></returns>
        public bool ChckIfAsseSingle(string planID, decimal pw)
        {
            Dal_TRP_PLAN_ROLL roll = new Dal_TRP_PLAN_ROLL();
            Dal_TRP_PLAN_ROLL_ITEM_INFO itemInfo = new Dal_TRP_PLAN_ROLL_ITEM_INFO();
            bool bol = true;
            var model = GetModel_Item(planID);
            var rollModel = roll.GetModel(model.C_PLAN_ROLL_ID);

            if (rollModel == null)
            {
                var itemInfoDt = itemInfo.GetItemInfo(model.C_ID);
                rollModel = roll.GetModel(itemInfoDt.Rows[0]["C_PLAN_ROLL_ID"].ToString());
            }

            string notLimitSql = @"SELECT T.* FROM  TB_NOT_LIMIT T";
            var dt = DbHelperOra.Query(notLimitSql).Tables[0];

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i]["C_TYPE"].ToString() == "1")
                {
                    if (model.C_STL_GRD == dt.Rows[i]["C_NAME"].ToString())
                        return true;
                }
                if (dt.Rows[i]["C_TYPE"].ToString() == "2")
                {
                    if (rollModel.C_MAT_CODE.StartsWith(dt.Rows[i]["C_NAME"].ToString()))
                        return true;
                }
                if (dt.Rows[i]["C_TYPE"].ToString() == "3")
                {
                    if (rollModel.C_BY4 == dt.Rows[i]["C_NAME"].ToString())
                        return true;
                }
            }


            decimal? wgt = model.N_WGT;
            int groupWgt = (int)model.N_GROUP_WGT;
            groupWgt += (int)pw;
            decimal? max = 0;

            Calculate(rollModel, wgt.Value, out bol, out max);

            max = Math.Ceiling(max.Value);
            if (groupWgt > max)
                bol = false;
            return bol;
        }

        /// <summary>
        /// 获取最大上线值
        /// </summary>
        /// <returns></returns>
        public object GetLimitMax(string planID)
        {
            Dal_TRP_PLAN_ROLL roll = new Dal_TRP_PLAN_ROLL();
            Dal_TRP_PLAN_ROLL_ITEM_INFO itemInfo = new Dal_TRP_PLAN_ROLL_ITEM_INFO();

            bool bol = true;
            var model = GetModel_Item(planID);
            var rollModel = roll.GetModel(model.C_PLAN_ROLL_ID);
            if (rollModel == null)
            {
                var itemInfoDt = itemInfo.GetItemInfo(model.C_ID);
                rollModel = roll.GetModel(itemInfoDt.Rows[0]["C_PLAN_ROLL_ID"].ToString());
            }

            string notLimitSql = @"SELECT T.* FROM  TB_NOT_LIMIT T";
            var dt = DbHelperOra.Query(notLimitSql).Tables[0];

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i]["C_TYPE"].ToString() == "1")
                {
                    if (model.C_STL_GRD == dt.Rows[i]["C_NAME"].ToString())
                        return "不限";
                }
                if (dt.Rows[i]["C_TYPE"].ToString() == "2")
                {
                    if (rollModel.C_MAT_CODE.StartsWith(dt.Rows[i]["C_NAME"].ToString()))
                        return "不限";
                }
                if (dt.Rows[i]["C_TYPE"].ToString() == "3")
                {
                    if (rollModel.C_BY4 == dt.Rows[i]["C_NAME"].ToString())
                        return "不限";
                }
            }

            decimal? wgt = model.N_WGT;
            decimal? max = 0;
            Calculate(rollModel, wgt.Value, out bol, out max);
            max = Math.Ceiling(max.Value);
            return max;
        }


        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string timeS, string timeE, string c_stl_grd, string c_std_code, string c_sta_id, string n_status)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * ");
            strSql.Append(" FROM TRP_PLAN_ROLL_ITEM t where 1=1 ");

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
        /// 得到一个对象实体
        /// </summary>
        public Mod_TRP_PLAN_ROLL_ITEM GetModel_By_PlanRollID(string c_plan_roll_id, string c_id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from(select * from trp_plan_roll_item t where t.c_plan_roll_id = '" + c_plan_roll_id + "' and t.n_status <> 8 and c_id <> '" + c_id + "' order by t.d_p_end_time desc)where rownum = 1 ");

            Mod_TRP_PLAN_ROLL_ITEM model = new Mod_TRP_PLAN_ROLL_ITEM();
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

        #endregion  ExtensionMethod

        /// <summary>
        /// 根据订单主键获取列表
        /// </summary>
        /// <param name="C_INITIALIZE_ITEM_ID">订单表主键</param>
        /// <returns></returns>
        public DataTable GetListByOrderID(string C_INITIALIZE_ITEM_ID)
        {
            string sql = "SELECT T.* FROM TRP_PLAN_ROLL_ITEM T WHERE T.C_INITIALIZE_ITEM_ID = '" + C_INITIALIZE_ITEM_ID + "'";
            return DbHelperOra.Query(sql).Tables[0];
        }

        /// <summary>
        /// 获取类中的属性值
        /// </summary>
        /// <param name="FieldName"></param>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static string GetModelValue(string FieldName, object obj)
        {
            try
            {
                Type Ts = obj.GetType();
                object o = Ts.GetProperty(FieldName).GetValue(obj, null);
                string Value = Convert.ToString(o);
                if (string.IsNullOrEmpty(Value)) return null;
                return Value;
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// 根据订单计算需要返回的量
        /// </summary>
        /// <returns></returns>
        public decimal GetNum(string id, string order)
        {
            string sql = @"SELECT  NVL(SUM(T.N_GROUP_WGT),0) WGT FROM  TRP_PLAN_ROLL_ITEM T WHERE T.C_ORDER_NO='" + order + "' AND(T.N_STATUS = 3 OR T.N_STATUS = 4) AND T.C_ID != '" + id + "' ";
            decimal num1 = decimal.Parse(DbHelperOra.GetSingle(sql).ToString());

            string sql2 = @"SELECT  NVL(SUM(T.N_WGT),0) WGT FROM  TRP_PLAN_ROLL_ITEM T WHERE T.C_ORDER_NO='" + order + "' AND   T.N_STATUS!=3 AND  T.N_STATUS!=4  AND T.C_ID!='" + id + "' ";
            decimal num2 = decimal.Parse(DbHelperOra.GetSingle(sql2).ToString());

            return num1 + num2;
        }

    }
}

