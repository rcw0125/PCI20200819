using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;
namespace DAL
{
    /// <summary>
    /// 数据访问类:TMO_ORDER
    /// </summary>
    public partial class Dal_TMO_ORDER
    {
        public Dal_TMO_ORDER()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string C_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TMO_ORDER");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)         };
            parameters[0].Value = C_ID;

            return DbHelperOra.Exists(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 验证能否修改订单计划
        /// </summary>
        /// <param name="C_ID"></param>
        /// <returns></returns>
        public bool IsCanUpdate(string C_ID)
        {
            string sql = "SELECT N_EXEC_STATUS, N_STATUS, T.C_ORDER_NO, T.C_ID  FROM TMO_ORDER T WHERE T.N_STATUS = 2   AND T.N_EXEC_STATUS = 0   AND T.C_ID ='" + C_ID + "'";
            DataTable dt = DbHelperOra.Query(sql).Tables[0];
            if (dt.Rows.Count==1)
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
        public bool Add(Mod_TMO_ORDER model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TMO_ORDER(");
            strSql.Append("C_ID,C_ORDER_NO,C_CON_NO,C_CON_NAME,C_AREA,C_CUST_NO,C_CUST_NAME,C_SALE_CHANNEL,C_CURRENCYTYPEID,C_RECEIPTAREAID,C_RECEIVEADDRESS,C_RECEIPTCORPID,C_PROD_NAME,C_PROD_KIND,C_INVBASDOCID,C_INVENTORYID,C_MAT_CODE,C_MAT_NAME,C_STL_GRD,C_SPEC,C_TECH_PROT,C_FREE1,C_FREE2,C_PACK,C_STD_CODE,C_DESIGN_NO,C_STDID,C_DESIGNID,C_VDEF1,C_PRO_USE,C_CUST_SQ,C_FUNITID,C_UNITID,N_HSL,N_FNUM,N_WGT,N_PROFIT,N_COST,N_TAXRATE,N_ORIGINALCURPRICE,N_ORIGINALCURTAXPRICE,N_ORIGINALCURTAXMNY,N_ORIGINALCURMNY,N_ORIGINALCURSUMMNY,D_NEED_DT,D_DELIVERY_DT,D_DT,N_STATUS,N_TYPE,N_FLAG,N_EXEC_STATUS,N_USER_LEV,C_LEV,C_ORDER_LEV,C_REMARK,C_EMP_ID,C_EMP_NAME,D_MOD_DT,N_SLAB_MATCH_WGT,N_LINE_MATCH_WGT,N_PROD_WGT,N_WARE_WGT,N_WARE_OUT_WGT,N_MACH_WGT,C_ISSUE_EMP_ID,C_PRD_EMP_ID,C_DESIGN_PROG,N_SMS_PROD_WGT,C_SMS_PROD_EMP_ID,D_SMS_PROD_DT,N_ROLL_PROD_WGT,C_ROLL_PROD_EMP_ID,D_STL_ROL_DT,C_LINE_NO,C_CCM_NO,N_ISSUE_WGT,C_RH,C_LF,C_KP,N_HL_TIME,C_HL,N_DFP_HL_TIME,C_DFP_HL,C_XM,C_ROUTE,C_MATRL_CODE_SLAB,C_MATRL_NAME_SLAB,C_SLAB_SIZE,N_SLAB_LENGTH,N_SLAB_PW,C_MATRL_CODE_KP,C_MATRL_NAME_KP,C_KP_SIZE,N_KP_LENGTH,N_KP_PW,N_GROUP,N_SORT,C_XC,C_SL,C_WL,C_SFPJ,C_TRANSMODE,N_MACH_WGT_CCM,C_XGID,N_ZJCLS,C_BY1,C_BY2,C_BY3,C_BY4,C_BY5,C_NC_ID,C_LGJH,C_ZLDJ_ID,C_ZL_ID,C_LF_ID,C_RH_ID,N_SLAB_WIDTH,N_SLAB_THICK,N_DIAMETER,D_NC_DATE,C_YWY,C_NC_SALECODE,C_TRANSMODEID,C_DFP_RZ,C_RZP_RZ,C_DFP_YQ,C_RZP_YQ,C_XM_YQ,N_JRL_WD,N_JRL_SJ,N_KPJRL_WD,N_KPJRL_SJ,N_TSL,C_ROLL_CODE,C_CCM_CODE,C_ROLL_DESC,C_CCM_DESC,C_TL,N_ZJCLS_MIN,N_ZJCLS_MAX,C_NCSTATUS,C_PCLX,C_STL_GRD_TYPE,D_NS_SEND_DT,C_ORDER_NO_OLD,C_STL_GRD_SLAB,C_STD_CODE_SLAB,C_PCTBEMP,D_PCTBTS,C_SFJK,C_STL_GRD_CLASS,N_LENGTH,N_HG_WGT,N_DP_WGT,N_GP_WGT,N_XY_WGT,N_TW_WGT,N_BHG_WGT,N_HG_WGT_IN,N_GP_WGT_IN,N_XY_WGT_IN,N_TW_WGT_IN,N_BHG_WGT_IN,N_HG_WGT_OUT,N_GP_WGT_OUT,N_XY_WGT_OUT,N_TW_WGT_OUT,N_BHG_WGT_OUT,D_SALE_TIME_MIN,D_SALE_TIME_MAX,D_PRODUCE_DATE_MIN,D_PRODUCE_DATE_MAX,N_SLAB_XC_WGT,N_ROLL_XC_WGT,D_OLD_DATE,N_ROLL_WGT,C_REMARK1,C_REMARK2,C_REMARK3,C_REMARK4,C_REMARK5,D_SC_MOD_DT,N_SLAB_XH_WGT,C_SLAB_TYPE,D_OLD_NEED_DATE,D_PJ_DATE,D_DATE_BY1,D_DATE_BY2,D_DATE_BY3,D_DATE_BY4,D_DATE_BY5,D_DATE_BY6)");
            strSql.Append(" values (");
            strSql.Append(":C_ID,:C_ORDER_NO,:C_CON_NO,:C_CON_NAME,:C_AREA,:C_CUST_NO,:C_CUST_NAME,:C_SALE_CHANNEL,:C_CURRENCYTYPEID,:C_RECEIPTAREAID,:C_RECEIVEADDRESS,:C_RECEIPTCORPID,:C_PROD_NAME,:C_PROD_KIND,:C_INVBASDOCID,:C_INVENTORYID,:C_MAT_CODE,:C_MAT_NAME,:C_STL_GRD,:C_SPEC,:C_TECH_PROT,:C_FREE1,:C_FREE2,:C_PACK,:C_STD_CODE,:C_DESIGN_NO,:C_STDID,:C_DESIGNID,:C_VDEF1,:C_PRO_USE,:C_CUST_SQ,:C_FUNITID,:C_UNITID,:N_HSL,:N_FNUM,:N_WGT,:N_PROFIT,:N_COST,:N_TAXRATE,:N_ORIGINALCURPRICE,:N_ORIGINALCURTAXPRICE,:N_ORIGINALCURTAXMNY,:N_ORIGINALCURMNY,:N_ORIGINALCURSUMMNY,:D_NEED_DT,:D_DELIVERY_DT,:D_DT,:N_STATUS,:N_TYPE,:N_FLAG,:N_EXEC_STATUS,:N_USER_LEV,:C_LEV,:C_ORDER_LEV,:C_REMARK,:C_EMP_ID,:C_EMP_NAME,:D_MOD_DT,:N_SLAB_MATCH_WGT,:N_LINE_MATCH_WGT,:N_PROD_WGT,:N_WARE_WGT,:N_WARE_OUT_WGT,:N_MACH_WGT,:C_ISSUE_EMP_ID,:C_PRD_EMP_ID,:C_DESIGN_PROG,:N_SMS_PROD_WGT,:C_SMS_PROD_EMP_ID,:D_SMS_PROD_DT,:N_ROLL_PROD_WGT,:C_ROLL_PROD_EMP_ID,:D_STL_ROL_DT,:C_LINE_NO,:C_CCM_NO,:N_ISSUE_WGT,:C_RH,:C_LF,:C_KP,:N_HL_TIME,:C_HL,:N_DFP_HL_TIME,:C_DFP_HL,:C_XM,:C_ROUTE,:C_MATRL_CODE_SLAB,:C_MATRL_NAME_SLAB,:C_SLAB_SIZE,:N_SLAB_LENGTH,:N_SLAB_PW,:C_MATRL_CODE_KP,:C_MATRL_NAME_KP,:C_KP_SIZE,:N_KP_LENGTH,:N_KP_PW,:N_GROUP,:N_SORT,:C_XC,:C_SL,:C_WL,:C_SFPJ,:C_TRANSMODE,:N_MACH_WGT_CCM,:C_XGID,:N_ZJCLS,:C_BY1,:C_BY2,:C_BY3,:C_BY4,:C_BY5,:C_NC_ID,:C_LGJH,:C_ZLDJ_ID,:C_ZL_ID,:C_LF_ID,:C_RH_ID,:N_SLAB_WIDTH,:N_SLAB_THICK,:N_DIAMETER,:D_NC_DATE,:C_YWY,:C_NC_SALECODE,:C_TRANSMODEID,:C_DFP_RZ,:C_RZP_RZ,:C_DFP_YQ,:C_RZP_YQ,:C_XM_YQ,:N_JRL_WD,:N_JRL_SJ,:N_KPJRL_WD,:N_KPJRL_SJ,:N_TSL,:C_ROLL_CODE,:C_CCM_CODE,:C_ROLL_DESC,:C_CCM_DESC,:C_TL,:N_ZJCLS_MIN,:N_ZJCLS_MAX,:C_NCSTATUS,:C_PCLX,:C_STL_GRD_TYPE,:D_NS_SEND_DT,:C_ORDER_NO_OLD,:C_STL_GRD_SLAB,:C_STD_CODE_SLAB,:C_PCTBEMP,:D_PCTBTS,:C_SFJK,:C_STL_GRD_CLASS,:N_LENGTH,:N_HG_WGT,:N_DP_WGT,:N_GP_WGT,:N_XY_WGT,:N_TW_WGT,:N_BHG_WGT,:N_HG_WGT_IN,:N_GP_WGT_IN,:N_XY_WGT_IN,:N_TW_WGT_IN,:N_BHG_WGT_IN,:N_HG_WGT_OUT,:N_GP_WGT_OUT,:N_XY_WGT_OUT,:N_TW_WGT_OUT,:N_BHG_WGT_OUT,:D_SALE_TIME_MIN,:D_SALE_TIME_MAX,:D_PRODUCE_DATE_MIN,:D_PRODUCE_DATE_MAX,:N_SLAB_XC_WGT,:N_ROLL_XC_WGT,:D_OLD_DATE,:N_ROLL_WGT,:C_REMARK1,:C_REMARK2,:C_REMARK3,:C_REMARK4,:C_REMARK5,:D_SC_MOD_DT,:N_SLAB_XH_WGT,:C_SLAB_TYPE,:D_OLD_NEED_DATE,:D_PJ_DATE,:D_DATE_BY1,:D_DATE_BY2,:D_DATE_BY3,:D_DATE_BY4,:D_DATE_BY5,:D_DATE_BY6)");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ORDER_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CON_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CON_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_AREA", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CUST_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CUST_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SALE_CHANNEL", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CURRENCYTYPEID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_RECEIPTAREAID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_RECEIVEADDRESS", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_RECEIPTCORPID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PROD_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PROD_KIND", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_INVBASDOCID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_INVENTORYID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MAT_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MAT_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STL_GRD", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SPEC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_TECH_PROT", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_FREE1", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_FREE2", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PACK", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STD_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_DESIGN_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STDID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_DESIGNID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_VDEF1", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PRO_USE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CUST_SQ", OracleDbType.Varchar2,1000),
                    new OracleParameter(":C_FUNITID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_UNITID", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_HSL", OracleDbType.Decimal,25),
                    new OracleParameter(":N_FNUM", OracleDbType.Decimal,25),
                    new OracleParameter(":N_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":N_PROFIT", OracleDbType.Decimal,25),
                    new OracleParameter(":N_COST", OracleDbType.Decimal,25),
                    new OracleParameter(":N_TAXRATE", OracleDbType.Decimal,25),
                    new OracleParameter(":N_ORIGINALCURPRICE", OracleDbType.Decimal,25),
                    new OracleParameter(":N_ORIGINALCURTAXPRICE", OracleDbType.Decimal,25),
                    new OracleParameter(":N_ORIGINALCURTAXMNY", OracleDbType.Decimal,25),
                    new OracleParameter(":N_ORIGINALCURMNY", OracleDbType.Decimal,25),
                    new OracleParameter(":N_ORIGINALCURSUMMNY", OracleDbType.Decimal,25),
                    new OracleParameter(":D_NEED_DT", OracleDbType.Date),
                    new OracleParameter(":D_DELIVERY_DT", OracleDbType.Date),
                    new OracleParameter(":D_DT", OracleDbType.Date),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,2),
                    new OracleParameter(":N_TYPE", OracleDbType.Decimal,15),
                    new OracleParameter(":N_FLAG", OracleDbType.Decimal,2),
                    new OracleParameter(":N_EXEC_STATUS", OracleDbType.Decimal,2),
                    new OracleParameter(":N_USER_LEV", OracleDbType.Decimal,2),
                    new OracleParameter(":C_LEV", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ORDER_LEV", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_EMP_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":N_SLAB_MATCH_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":N_LINE_MATCH_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":N_PROD_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":N_WARE_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":N_WARE_OUT_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":N_MACH_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":C_ISSUE_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PRD_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_DESIGN_PROG", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_SMS_PROD_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":C_SMS_PROD_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_SMS_PROD_DT", OracleDbType.Date),
                    new OracleParameter(":N_ROLL_PROD_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":C_ROLL_PROD_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_STL_ROL_DT", OracleDbType.Date),
                    new OracleParameter(":C_LINE_NO", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_CCM_NO", OracleDbType.Varchar2,500),
                    new OracleParameter(":N_ISSUE_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":C_RH", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_LF", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_KP", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_HL_TIME", OracleDbType.Decimal,10),
                    new OracleParameter(":C_HL", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_DFP_HL_TIME", OracleDbType.Decimal,10),
                    new OracleParameter(":C_DFP_HL", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_XM", OracleDbType.Varchar2,2),
                    new OracleParameter(":C_ROUTE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MATRL_CODE_SLAB", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MATRL_NAME_SLAB", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SLAB_SIZE", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_SLAB_LENGTH", OracleDbType.Decimal,15),
                    new OracleParameter(":N_SLAB_PW", OracleDbType.Decimal,15),
                    new OracleParameter(":C_MATRL_CODE_KP", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MATRL_NAME_KP", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_KP_SIZE", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_KP_LENGTH", OracleDbType.Decimal,15),
                    new OracleParameter(":N_KP_PW", OracleDbType.Decimal,15),
                    new OracleParameter(":N_GROUP", OracleDbType.Decimal,4),
                    new OracleParameter(":N_SORT", OracleDbType.Decimal,4),
                    new OracleParameter(":C_XC", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_SL", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_WL", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SFPJ", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_TRANSMODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_MACH_WGT_CCM", OracleDbType.Decimal,15),
                    new OracleParameter(":C_XGID", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_ZJCLS", OracleDbType.Decimal,4),
                    new OracleParameter(":C_BY1", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_BY2", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_BY3", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_BY4", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_BY5", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_NC_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_LGJH", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ZLDJ_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ZL_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_LF_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_RH_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_SLAB_WIDTH", OracleDbType.Decimal,4),
                    new OracleParameter(":N_SLAB_THICK", OracleDbType.Decimal,4),
                    new OracleParameter(":N_DIAMETER", OracleDbType.Decimal,4),
                    new OracleParameter(":D_NC_DATE", OracleDbType.Date),
                    new OracleParameter(":C_YWY", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_NC_SALECODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_TRANSMODEID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_DFP_RZ", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_RZP_RZ", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_DFP_YQ", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_RZP_YQ", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_XM_YQ", OracleDbType.Varchar2,1000),
                    new OracleParameter(":N_JRL_WD", OracleDbType.Decimal,10),
                    new OracleParameter(":N_JRL_SJ", OracleDbType.Decimal,10),
                    new OracleParameter(":N_KPJRL_WD", OracleDbType.Decimal,10),
                    new OracleParameter(":N_KPJRL_SJ", OracleDbType.Decimal,10),
                    new OracleParameter(":N_TSL", OracleDbType.Decimal,10),
                    new OracleParameter(":C_ROLL_CODE", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_CCM_CODE", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_ROLL_DESC", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_CCM_DESC", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_TL", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_ZJCLS_MIN", OracleDbType.Decimal,4),
                    new OracleParameter(":N_ZJCLS_MAX", OracleDbType.Decimal,4),
                    new OracleParameter(":C_NCSTATUS", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PCLX", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STL_GRD_TYPE", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_NS_SEND_DT", OracleDbType.Date),
                    new OracleParameter(":C_ORDER_NO_OLD", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STL_GRD_SLAB", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STD_CODE_SLAB", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PCTBEMP", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_PCTBTS", OracleDbType.Date),
                    new OracleParameter(":C_SFJK", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_STL_GRD_CLASS", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_LENGTH", OracleDbType.Decimal,15),
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
                    new OracleParameter(":N_SLAB_XC_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":N_ROLL_XC_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":D_OLD_DATE", OracleDbType.Date),
                    new OracleParameter(":N_ROLL_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":C_REMARK1", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_REMARK2", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_REMARK3", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_REMARK4", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_REMARK5", OracleDbType.Varchar2,500),
                    new OracleParameter(":D_SC_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":N_SLAB_XH_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":C_SLAB_TYPE", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_OLD_NEED_DATE", OracleDbType.Date),
                    new OracleParameter(":D_PJ_DATE", OracleDbType.Date),
                    new OracleParameter(":D_DATE_BY1", OracleDbType.Date),
                    new OracleParameter(":D_DATE_BY2", OracleDbType.Date),
                    new OracleParameter(":D_DATE_BY3", OracleDbType.Date),
                    new OracleParameter(":D_DATE_BY4", OracleDbType.Date),
                    new OracleParameter(":D_DATE_BY5", OracleDbType.Date),
                    new OracleParameter(":D_DATE_BY6", OracleDbType.Date)};
            parameters[0].Value = model.C_ID;
            parameters[1].Value = model.C_ORDER_NO;
            parameters[2].Value = model.C_CON_NO;
            parameters[3].Value = model.C_CON_NAME;
            parameters[4].Value = model.C_AREA;
            parameters[5].Value = model.C_CUST_NO;
            parameters[6].Value = model.C_CUST_NAME;
            parameters[7].Value = model.C_SALE_CHANNEL;
            parameters[8].Value = model.C_CURRENCYTYPEID;
            parameters[9].Value = model.C_RECEIPTAREAID;
            parameters[10].Value = model.C_RECEIVEADDRESS;
            parameters[11].Value = model.C_RECEIPTCORPID;
            parameters[12].Value = model.C_PROD_NAME;
            parameters[13].Value = model.C_PROD_KIND;
            parameters[14].Value = model.C_INVBASDOCID;
            parameters[15].Value = model.C_INVENTORYID;
            parameters[16].Value = model.C_MAT_CODE;
            parameters[17].Value = model.C_MAT_NAME;
            parameters[18].Value = model.C_STL_GRD;
            parameters[19].Value = model.C_SPEC;
            parameters[20].Value = model.C_TECH_PROT;
            parameters[21].Value = model.C_FREE1;
            parameters[22].Value = model.C_FREE2;
            parameters[23].Value = model.C_PACK;
            parameters[24].Value = model.C_STD_CODE;
            parameters[25].Value = model.C_DESIGN_NO;
            parameters[26].Value = model.C_STDID;
            parameters[27].Value = model.C_DESIGNID;
            parameters[28].Value = model.C_VDEF1;
            parameters[29].Value = model.C_PRO_USE;
            parameters[30].Value = model.C_CUST_SQ;
            parameters[31].Value = model.C_FUNITID;
            parameters[32].Value = model.C_UNITID;
            parameters[33].Value = model.N_HSL;
            parameters[34].Value = model.N_FNUM;
            parameters[35].Value = model.N_WGT;
            parameters[36].Value = model.N_PROFIT;
            parameters[37].Value = model.N_COST;
            parameters[38].Value = model.N_TAXRATE;
            parameters[39].Value = model.N_ORIGINALCURPRICE;
            parameters[40].Value = model.N_ORIGINALCURTAXPRICE;
            parameters[41].Value = model.N_ORIGINALCURTAXMNY;
            parameters[42].Value = model.N_ORIGINALCURMNY;
            parameters[43].Value = model.N_ORIGINALCURSUMMNY;
            parameters[44].Value = model.D_NEED_DT;
            parameters[45].Value = model.D_DELIVERY_DT;
            parameters[46].Value = model.D_DT;
            parameters[47].Value = model.N_STATUS;
            parameters[48].Value = model.N_TYPE;
            parameters[49].Value = model.N_FLAG;
            parameters[50].Value = model.N_EXEC_STATUS;
            parameters[51].Value = model.N_USER_LEV;
            parameters[52].Value = model.C_LEV;
            parameters[53].Value = model.C_ORDER_LEV;
            parameters[54].Value = model.C_REMARK;
            parameters[55].Value = model.C_EMP_ID;
            parameters[56].Value = model.C_EMP_NAME;
            parameters[57].Value = model.D_MOD_DT;
            parameters[58].Value = model.N_SLAB_MATCH_WGT;
            parameters[59].Value = model.N_LINE_MATCH_WGT;
            parameters[60].Value = model.N_PROD_WGT;
            parameters[61].Value = model.N_WARE_WGT;
            parameters[62].Value = model.N_WARE_OUT_WGT;
            parameters[63].Value = model.N_MACH_WGT;
            parameters[64].Value = model.C_ISSUE_EMP_ID;
            parameters[65].Value = model.C_PRD_EMP_ID;
            parameters[66].Value = model.C_DESIGN_PROG;
            parameters[67].Value = model.N_SMS_PROD_WGT;
            parameters[68].Value = model.C_SMS_PROD_EMP_ID;
            parameters[69].Value = model.D_SMS_PROD_DT;
            parameters[70].Value = model.N_ROLL_PROD_WGT;
            parameters[71].Value = model.C_ROLL_PROD_EMP_ID;
            parameters[72].Value = model.D_STL_ROL_DT;
            parameters[73].Value = model.C_LINE_NO;
            parameters[74].Value = model.C_CCM_NO;
            parameters[75].Value = model.N_ISSUE_WGT;
            parameters[76].Value = model.C_RH;
            parameters[77].Value = model.C_LF;
            parameters[78].Value = model.C_KP;
            parameters[79].Value = model.N_HL_TIME;
            parameters[80].Value = model.C_HL;
            parameters[81].Value = model.N_DFP_HL_TIME;
            parameters[82].Value = model.C_DFP_HL;
            parameters[83].Value = model.C_XM;
            parameters[84].Value = model.C_ROUTE;
            parameters[85].Value = model.C_MATRL_CODE_SLAB;
            parameters[86].Value = model.C_MATRL_NAME_SLAB;
            parameters[87].Value = model.C_SLAB_SIZE;
            parameters[88].Value = model.N_SLAB_LENGTH;
            parameters[89].Value = model.N_SLAB_PW;
            parameters[90].Value = model.C_MATRL_CODE_KP;
            parameters[91].Value = model.C_MATRL_NAME_KP;
            parameters[92].Value = model.C_KP_SIZE;
            parameters[93].Value = model.N_KP_LENGTH;
            parameters[94].Value = model.N_KP_PW;
            parameters[95].Value = model.N_GROUP;
            parameters[96].Value = model.N_SORT;
            parameters[97].Value = model.C_XC;
            parameters[98].Value = model.C_SL;
            parameters[99].Value = model.C_WL;
            parameters[100].Value = model.C_SFPJ;
            parameters[101].Value = model.C_TRANSMODE;
            parameters[102].Value = model.N_MACH_WGT_CCM;
            parameters[103].Value = model.C_XGID;
            parameters[104].Value = model.N_ZJCLS;
            parameters[105].Value = model.C_BY1;
            parameters[106].Value = model.C_BY2;
            parameters[107].Value = model.C_BY3;
            parameters[108].Value = model.C_BY4;
            parameters[109].Value = model.C_BY5;
            parameters[110].Value = model.C_NC_ID;
            parameters[111].Value = model.C_LGJH;
            parameters[112].Value = model.C_ZLDJ_ID;
            parameters[113].Value = model.C_ZL_ID;
            parameters[114].Value = model.C_LF_ID;
            parameters[115].Value = model.C_RH_ID;
            parameters[116].Value = model.N_SLAB_WIDTH;
            parameters[117].Value = model.N_SLAB_THICK;
            parameters[118].Value = model.N_DIAMETER;
            parameters[119].Value = model.D_NC_DATE;
            parameters[120].Value = model.C_YWY;
            parameters[121].Value = model.C_NC_SALECODE;
            parameters[122].Value = model.C_TRANSMODEID;
            parameters[123].Value = model.C_DFP_RZ;
            parameters[124].Value = model.C_RZP_RZ;
            parameters[125].Value = model.C_DFP_YQ;
            parameters[126].Value = model.C_RZP_YQ;
            parameters[127].Value = model.C_XM_YQ;
            parameters[128].Value = model.N_JRL_WD;
            parameters[129].Value = model.N_JRL_SJ;
            parameters[130].Value = model.N_KPJRL_WD;
            parameters[131].Value = model.N_KPJRL_SJ;
            parameters[132].Value = model.N_TSL;
            parameters[133].Value = model.C_ROLL_CODE;
            parameters[134].Value = model.C_CCM_CODE;
            parameters[135].Value = model.C_ROLL_DESC;
            parameters[136].Value = model.C_CCM_DESC;
            parameters[137].Value = model.C_TL;
            parameters[138].Value = model.N_ZJCLS_MIN;
            parameters[139].Value = model.N_ZJCLS_MAX;
            parameters[140].Value = model.C_NCSTATUS;
            parameters[141].Value = model.C_PCLX;
            parameters[142].Value = model.C_STL_GRD_TYPE;
            parameters[143].Value = model.D_NS_SEND_DT;
            parameters[144].Value = model.C_ORDER_NO_OLD;
            parameters[145].Value = model.C_STL_GRD_SLAB;
            parameters[146].Value = model.C_STD_CODE_SLAB;
            parameters[147].Value = model.C_PCTBEMP;
            parameters[148].Value = model.D_PCTBTS;
            parameters[149].Value = model.C_SFJK;
            parameters[150].Value = model.C_STL_GRD_CLASS;
            parameters[151].Value = model.N_LENGTH;
            parameters[152].Value = model.N_HG_WGT;
            parameters[153].Value = model.N_DP_WGT;
            parameters[154].Value = model.N_GP_WGT;
            parameters[155].Value = model.N_XY_WGT;
            parameters[156].Value = model.N_TW_WGT;
            parameters[157].Value = model.N_BHG_WGT;
            parameters[158].Value = model.N_HG_WGT_IN;
            parameters[159].Value = model.N_GP_WGT_IN;
            parameters[160].Value = model.N_XY_WGT_IN;
            parameters[161].Value = model.N_TW_WGT_IN;
            parameters[162].Value = model.N_BHG_WGT_IN;
            parameters[163].Value = model.N_HG_WGT_OUT;
            parameters[164].Value = model.N_GP_WGT_OUT;
            parameters[165].Value = model.N_XY_WGT_OUT;
            parameters[166].Value = model.N_TW_WGT_OUT;
            parameters[167].Value = model.N_BHG_WGT_OUT;
            parameters[168].Value = model.D_SALE_TIME_MIN;
            parameters[169].Value = model.D_SALE_TIME_MAX;
            parameters[170].Value = model.D_PRODUCE_DATE_MIN;
            parameters[171].Value = model.D_PRODUCE_DATE_MAX;
            parameters[172].Value = model.N_SLAB_XC_WGT;
            parameters[173].Value = model.N_ROLL_XC_WGT;
            parameters[174].Value = model.D_OLD_DATE;
            parameters[175].Value = model.N_ROLL_WGT;
            parameters[176].Value = model.C_REMARK1;
            parameters[177].Value = model.C_REMARK2;
            parameters[178].Value = model.C_REMARK3;
            parameters[179].Value = model.C_REMARK4;
            parameters[180].Value = model.C_REMARK5;
            parameters[181].Value = model.D_SC_MOD_DT;
            parameters[182].Value = model.N_SLAB_XH_WGT;
            parameters[183].Value = model.C_SLAB_TYPE;
            parameters[184].Value = model.D_OLD_NEED_DATE;
            parameters[185].Value = model.D_PJ_DATE;
            parameters[186].Value = model.D_DATE_BY1;
            parameters[187].Value = model.D_DATE_BY2;
            parameters[188].Value = model.D_DATE_BY3;
            parameters[189].Value = model.D_DATE_BY4;
            parameters[190].Value = model.D_DATE_BY5;
            parameters[191].Value = model.D_DATE_BY6;

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
        public bool Update(Mod_TMO_ORDER model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TMO_ORDER set ");
            strSql.Append("C_ORDER_NO=:C_ORDER_NO,");
            strSql.Append("C_CON_NO=:C_CON_NO,");
            strSql.Append("C_CON_NAME=:C_CON_NAME,");
            strSql.Append("C_AREA=:C_AREA,");
            strSql.Append("C_CUST_NO=:C_CUST_NO,");
            strSql.Append("C_CUST_NAME=:C_CUST_NAME,");
            strSql.Append("C_SALE_CHANNEL=:C_SALE_CHANNEL,");
            strSql.Append("C_CURRENCYTYPEID=:C_CURRENCYTYPEID,");
            strSql.Append("C_RECEIPTAREAID=:C_RECEIPTAREAID,");
            strSql.Append("C_RECEIVEADDRESS=:C_RECEIVEADDRESS,");
            strSql.Append("C_RECEIPTCORPID=:C_RECEIPTCORPID,");
            strSql.Append("C_PROD_NAME=:C_PROD_NAME,");
            strSql.Append("C_PROD_KIND=:C_PROD_KIND,");
            strSql.Append("C_INVBASDOCID=:C_INVBASDOCID,");
            strSql.Append("C_INVENTORYID=:C_INVENTORYID,");
            strSql.Append("C_MAT_CODE=:C_MAT_CODE,");
            strSql.Append("C_MAT_NAME=:C_MAT_NAME,");
            strSql.Append("C_STL_GRD=:C_STL_GRD,");
            strSql.Append("C_SPEC=:C_SPEC,");
            strSql.Append("C_TECH_PROT=:C_TECH_PROT,");
            strSql.Append("C_FREE1=:C_FREE1,");
            strSql.Append("C_FREE2=:C_FREE2,");
            strSql.Append("C_PACK=:C_PACK,");
            strSql.Append("C_STD_CODE=:C_STD_CODE,");
            strSql.Append("C_DESIGN_NO=:C_DESIGN_NO,");
            strSql.Append("C_STDID=:C_STDID,");
            strSql.Append("C_DESIGNID=:C_DESIGNID,");
            strSql.Append("C_VDEF1=:C_VDEF1,");
            strSql.Append("C_PRO_USE=:C_PRO_USE,");
            strSql.Append("C_CUST_SQ=:C_CUST_SQ,");
            strSql.Append("C_FUNITID=:C_FUNITID,");
            strSql.Append("C_UNITID=:C_UNITID,");
            strSql.Append("N_HSL=:N_HSL,");
            strSql.Append("N_FNUM=:N_FNUM,");
            strSql.Append("N_WGT=:N_WGT,");
            strSql.Append("N_PROFIT=:N_PROFIT,");
            strSql.Append("N_COST=:N_COST,");
            strSql.Append("N_TAXRATE=:N_TAXRATE,");
            strSql.Append("N_ORIGINALCURPRICE=:N_ORIGINALCURPRICE,");
            strSql.Append("N_ORIGINALCURTAXPRICE=:N_ORIGINALCURTAXPRICE,");
            strSql.Append("N_ORIGINALCURTAXMNY=:N_ORIGINALCURTAXMNY,");
            strSql.Append("N_ORIGINALCURMNY=:N_ORIGINALCURMNY,");
            strSql.Append("N_ORIGINALCURSUMMNY=:N_ORIGINALCURSUMMNY,");
            strSql.Append("D_NEED_DT=:D_NEED_DT,");
            strSql.Append("D_DELIVERY_DT=:D_DELIVERY_DT,");
            strSql.Append("D_DT=:D_DT,");
            strSql.Append("N_STATUS=:N_STATUS,");
            strSql.Append("N_TYPE=:N_TYPE,");
            strSql.Append("N_FLAG=:N_FLAG,");
            strSql.Append("N_EXEC_STATUS=:N_EXEC_STATUS,");
            strSql.Append("N_USER_LEV=:N_USER_LEV,");
            strSql.Append("C_LEV=:C_LEV,");
            strSql.Append("C_ORDER_LEV=:C_ORDER_LEV,");
            strSql.Append("C_REMARK=:C_REMARK,");
            strSql.Append("C_EMP_ID=:C_EMP_ID,");
            strSql.Append("C_EMP_NAME=:C_EMP_NAME,");
            strSql.Append("D_MOD_DT=:D_MOD_DT,");
            strSql.Append("N_SLAB_MATCH_WGT=:N_SLAB_MATCH_WGT,");
            strSql.Append("N_LINE_MATCH_WGT=:N_LINE_MATCH_WGT,");
            strSql.Append("N_PROD_WGT=:N_PROD_WGT,");
            strSql.Append("N_WARE_WGT=:N_WARE_WGT,");
            strSql.Append("N_WARE_OUT_WGT=:N_WARE_OUT_WGT,");
            strSql.Append("N_MACH_WGT=:N_MACH_WGT,");
            strSql.Append("C_ISSUE_EMP_ID=:C_ISSUE_EMP_ID,");
            strSql.Append("C_PRD_EMP_ID=:C_PRD_EMP_ID,");
            strSql.Append("C_DESIGN_PROG=:C_DESIGN_PROG,");
            strSql.Append("N_SMS_PROD_WGT=:N_SMS_PROD_WGT,");
            strSql.Append("C_SMS_PROD_EMP_ID=:C_SMS_PROD_EMP_ID,");
            strSql.Append("D_SMS_PROD_DT=:D_SMS_PROD_DT,");
            strSql.Append("N_ROLL_PROD_WGT=:N_ROLL_PROD_WGT,");
            strSql.Append("C_ROLL_PROD_EMP_ID=:C_ROLL_PROD_EMP_ID,");
            strSql.Append("D_STL_ROL_DT=:D_STL_ROL_DT,");
            strSql.Append("C_LINE_NO=:C_LINE_NO,");
            strSql.Append("C_CCM_NO=:C_CCM_NO,");
            strSql.Append("N_ISSUE_WGT=:N_ISSUE_WGT,");
            strSql.Append("C_RH=:C_RH,");
            strSql.Append("C_LF=:C_LF,");
            strSql.Append("C_KP=:C_KP,");
            strSql.Append("N_HL_TIME=:N_HL_TIME,");
            strSql.Append("C_HL=:C_HL,");
            strSql.Append("N_DFP_HL_TIME=:N_DFP_HL_TIME,");
            strSql.Append("C_DFP_HL=:C_DFP_HL,");
            strSql.Append("C_XM=:C_XM,");
            strSql.Append("C_ROUTE=:C_ROUTE,");
            strSql.Append("C_MATRL_CODE_SLAB=:C_MATRL_CODE_SLAB,");
            strSql.Append("C_MATRL_NAME_SLAB=:C_MATRL_NAME_SLAB,");
            strSql.Append("C_SLAB_SIZE=:C_SLAB_SIZE,");
            strSql.Append("N_SLAB_LENGTH=:N_SLAB_LENGTH,");
            strSql.Append("N_SLAB_PW=:N_SLAB_PW,");
            strSql.Append("C_MATRL_CODE_KP=:C_MATRL_CODE_KP,");
            strSql.Append("C_MATRL_NAME_KP=:C_MATRL_NAME_KP,");
            strSql.Append("C_KP_SIZE=:C_KP_SIZE,");
            strSql.Append("N_KP_LENGTH=:N_KP_LENGTH,");
            strSql.Append("N_KP_PW=:N_KP_PW,");
            strSql.Append("N_GROUP=:N_GROUP,");
            strSql.Append("N_SORT=:N_SORT,");
            strSql.Append("C_XC=:C_XC,");
            strSql.Append("C_SL=:C_SL,");
            strSql.Append("C_WL=:C_WL,");
            strSql.Append("C_SFPJ=:C_SFPJ,");
            strSql.Append("C_TRANSMODE=:C_TRANSMODE,");
            strSql.Append("N_MACH_WGT_CCM=:N_MACH_WGT_CCM,");
            strSql.Append("C_XGID=:C_XGID,");
            strSql.Append("N_ZJCLS=:N_ZJCLS,");
            strSql.Append("C_BY1=:C_BY1,");
            strSql.Append("C_BY2=:C_BY2,");
            strSql.Append("C_BY3=:C_BY3,");
            strSql.Append("C_BY4=:C_BY4,");
            strSql.Append("C_BY5=:C_BY5,");
            strSql.Append("C_NC_ID=:C_NC_ID,");
            strSql.Append("C_LGJH=:C_LGJH,");
            strSql.Append("C_ZLDJ_ID=:C_ZLDJ_ID,");
            strSql.Append("C_ZL_ID=:C_ZL_ID,");
            strSql.Append("C_LF_ID=:C_LF_ID,");
            strSql.Append("C_RH_ID=:C_RH_ID,");
            strSql.Append("N_SLAB_WIDTH=:N_SLAB_WIDTH,");
            strSql.Append("N_SLAB_THICK=:N_SLAB_THICK,");
            strSql.Append("N_DIAMETER=:N_DIAMETER,");
            strSql.Append("D_NC_DATE=:D_NC_DATE,");
            strSql.Append("C_YWY=:C_YWY,");
            strSql.Append("C_NC_SALECODE=:C_NC_SALECODE,");
            strSql.Append("C_TRANSMODEID=:C_TRANSMODEID,");
            strSql.Append("C_DFP_RZ=:C_DFP_RZ,");
            strSql.Append("C_RZP_RZ=:C_RZP_RZ,");
            strSql.Append("C_DFP_YQ=:C_DFP_YQ,");
            strSql.Append("C_RZP_YQ=:C_RZP_YQ,");
            strSql.Append("C_XM_YQ=:C_XM_YQ,");
            strSql.Append("N_JRL_WD=:N_JRL_WD,");
            strSql.Append("N_JRL_SJ=:N_JRL_SJ,");
            strSql.Append("N_KPJRL_WD=:N_KPJRL_WD,");
            strSql.Append("N_KPJRL_SJ=:N_KPJRL_SJ,");
            strSql.Append("N_TSL=:N_TSL,");
            strSql.Append("C_ROLL_CODE=:C_ROLL_CODE,");
            strSql.Append("C_CCM_CODE=:C_CCM_CODE,");
            strSql.Append("C_ROLL_DESC=:C_ROLL_DESC,");
            strSql.Append("C_CCM_DESC=:C_CCM_DESC,");
            strSql.Append("C_TL=:C_TL,");
            strSql.Append("N_ZJCLS_MIN=:N_ZJCLS_MIN,");
            strSql.Append("N_ZJCLS_MAX=:N_ZJCLS_MAX,");
            strSql.Append("C_NCSTATUS=:C_NCSTATUS,");
            strSql.Append("C_PCLX=:C_PCLX,");
            strSql.Append("C_STL_GRD_TYPE=:C_STL_GRD_TYPE,");
            strSql.Append("D_NS_SEND_DT=:D_NS_SEND_DT,");
            strSql.Append("C_ORDER_NO_OLD=:C_ORDER_NO_OLD,");
            strSql.Append("C_STL_GRD_SLAB=:C_STL_GRD_SLAB,");
            strSql.Append("C_STD_CODE_SLAB=:C_STD_CODE_SLAB,");
            strSql.Append("C_PCTBEMP=:C_PCTBEMP,");
            strSql.Append("D_PCTBTS=:D_PCTBTS,");
            strSql.Append("C_SFJK=:C_SFJK,");
            strSql.Append("C_STL_GRD_CLASS=:C_STL_GRD_CLASS,");
            strSql.Append("N_LENGTH=:N_LENGTH,");
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
            strSql.Append("N_SLAB_XC_WGT=:N_SLAB_XC_WGT,");
            strSql.Append("N_ROLL_XC_WGT=:N_ROLL_XC_WGT,");
            strSql.Append("D_OLD_DATE=:D_OLD_DATE,");
            strSql.Append("N_ROLL_WGT=:N_ROLL_WGT,");
            strSql.Append("C_REMARK1=:C_REMARK1,");
            strSql.Append("C_REMARK2=:C_REMARK2,");
            strSql.Append("C_REMARK3=:C_REMARK3,");
            strSql.Append("C_REMARK4=:C_REMARK4,");
            strSql.Append("C_REMARK5=:C_REMARK5,");
            strSql.Append("D_SC_MOD_DT=:D_SC_MOD_DT,");
            strSql.Append("N_SLAB_XH_WGT=:N_SLAB_XH_WGT,");
            strSql.Append("C_SLAB_TYPE=:C_SLAB_TYPE,");
            strSql.Append("D_OLD_NEED_DATE=:D_OLD_NEED_DATE,");
            strSql.Append("D_PJ_DATE=:D_PJ_DATE,");
            strSql.Append("D_DATE_BY1=:D_DATE_BY1,");
            strSql.Append("D_DATE_BY2=:D_DATE_BY2,");
            strSql.Append("D_DATE_BY3=:D_DATE_BY3,");
            strSql.Append("D_DATE_BY4=:D_DATE_BY4,");
            strSql.Append("D_DATE_BY5=:D_DATE_BY5,");
            strSql.Append("D_DATE_BY6=:D_DATE_BY6");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ORDER_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CON_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CON_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_AREA", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CUST_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CUST_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SALE_CHANNEL", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CURRENCYTYPEID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_RECEIPTAREAID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_RECEIVEADDRESS", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_RECEIPTCORPID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PROD_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PROD_KIND", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_INVBASDOCID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_INVENTORYID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MAT_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MAT_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STL_GRD", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SPEC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_TECH_PROT", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_FREE1", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_FREE2", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PACK", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STD_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_DESIGN_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STDID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_DESIGNID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_VDEF1", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PRO_USE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CUST_SQ", OracleDbType.Varchar2,1000),
                    new OracleParameter(":C_FUNITID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_UNITID", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_HSL", OracleDbType.Decimal,25),
                    new OracleParameter(":N_FNUM", OracleDbType.Decimal,25),
                    new OracleParameter(":N_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":N_PROFIT", OracleDbType.Decimal,25),
                    new OracleParameter(":N_COST", OracleDbType.Decimal,25),
                    new OracleParameter(":N_TAXRATE", OracleDbType.Decimal,25),
                    new OracleParameter(":N_ORIGINALCURPRICE", OracleDbType.Decimal,25),
                    new OracleParameter(":N_ORIGINALCURTAXPRICE", OracleDbType.Decimal,25),
                    new OracleParameter(":N_ORIGINALCURTAXMNY", OracleDbType.Decimal,25),
                    new OracleParameter(":N_ORIGINALCURMNY", OracleDbType.Decimal,25),
                    new OracleParameter(":N_ORIGINALCURSUMMNY", OracleDbType.Decimal,25),
                    new OracleParameter(":D_NEED_DT", OracleDbType.Date),
                    new OracleParameter(":D_DELIVERY_DT", OracleDbType.Date),
                    new OracleParameter(":D_DT", OracleDbType.Date),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,2),
                    new OracleParameter(":N_TYPE", OracleDbType.Decimal,15),
                    new OracleParameter(":N_FLAG", OracleDbType.Decimal,2),
                    new OracleParameter(":N_EXEC_STATUS", OracleDbType.Decimal,2),
                    new OracleParameter(":N_USER_LEV", OracleDbType.Decimal,2),
                    new OracleParameter(":C_LEV", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ORDER_LEV", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_EMP_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":N_SLAB_MATCH_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":N_LINE_MATCH_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":N_PROD_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":N_WARE_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":N_WARE_OUT_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":N_MACH_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":C_ISSUE_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PRD_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_DESIGN_PROG", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_SMS_PROD_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":C_SMS_PROD_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_SMS_PROD_DT", OracleDbType.Date),
                    new OracleParameter(":N_ROLL_PROD_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":C_ROLL_PROD_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_STL_ROL_DT", OracleDbType.Date),
                    new OracleParameter(":C_LINE_NO", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_CCM_NO", OracleDbType.Varchar2,500),
                    new OracleParameter(":N_ISSUE_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":C_RH", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_LF", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_KP", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_HL_TIME", OracleDbType.Decimal,10),
                    new OracleParameter(":C_HL", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_DFP_HL_TIME", OracleDbType.Decimal,10),
                    new OracleParameter(":C_DFP_HL", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_XM", OracleDbType.Varchar2,2),
                    new OracleParameter(":C_ROUTE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MATRL_CODE_SLAB", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MATRL_NAME_SLAB", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SLAB_SIZE", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_SLAB_LENGTH", OracleDbType.Decimal,15),
                    new OracleParameter(":N_SLAB_PW", OracleDbType.Decimal,15),
                    new OracleParameter(":C_MATRL_CODE_KP", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MATRL_NAME_KP", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_KP_SIZE", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_KP_LENGTH", OracleDbType.Decimal,15),
                    new OracleParameter(":N_KP_PW", OracleDbType.Decimal,15),
                    new OracleParameter(":N_GROUP", OracleDbType.Decimal,4),
                    new OracleParameter(":N_SORT", OracleDbType.Decimal,4),
                    new OracleParameter(":C_XC", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_SL", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_WL", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SFPJ", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_TRANSMODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_MACH_WGT_CCM", OracleDbType.Decimal,15),
                    new OracleParameter(":C_XGID", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_ZJCLS", OracleDbType.Decimal,4),
                    new OracleParameter(":C_BY1", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_BY2", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_BY3", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_BY4", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_BY5", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_NC_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_LGJH", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ZLDJ_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ZL_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_LF_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_RH_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_SLAB_WIDTH", OracleDbType.Decimal,4),
                    new OracleParameter(":N_SLAB_THICK", OracleDbType.Decimal,4),
                    new OracleParameter(":N_DIAMETER", OracleDbType.Decimal,4),
                    new OracleParameter(":D_NC_DATE", OracleDbType.Date),
                    new OracleParameter(":C_YWY", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_NC_SALECODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_TRANSMODEID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_DFP_RZ", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_RZP_RZ", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_DFP_YQ", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_RZP_YQ", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_XM_YQ", OracleDbType.Varchar2,1000),
                    new OracleParameter(":N_JRL_WD", OracleDbType.Decimal,10),
                    new OracleParameter(":N_JRL_SJ", OracleDbType.Decimal,10),
                    new OracleParameter(":N_KPJRL_WD", OracleDbType.Decimal,10),
                    new OracleParameter(":N_KPJRL_SJ", OracleDbType.Decimal,10),
                    new OracleParameter(":N_TSL", OracleDbType.Decimal,10),
                    new OracleParameter(":C_ROLL_CODE", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_CCM_CODE", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_ROLL_DESC", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_CCM_DESC", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_TL", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_ZJCLS_MIN", OracleDbType.Decimal,4),
                    new OracleParameter(":N_ZJCLS_MAX", OracleDbType.Decimal,4),
                    new OracleParameter(":C_NCSTATUS", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PCLX", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STL_GRD_TYPE", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_NS_SEND_DT", OracleDbType.Date),
                    new OracleParameter(":C_ORDER_NO_OLD", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STL_GRD_SLAB", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STD_CODE_SLAB", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PCTBEMP", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_PCTBTS", OracleDbType.Date),
                    new OracleParameter(":C_SFJK", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_STL_GRD_CLASS", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_LENGTH", OracleDbType.Decimal,15),
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
                    new OracleParameter(":N_SLAB_XC_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":N_ROLL_XC_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":D_OLD_DATE", OracleDbType.Date),
                    new OracleParameter(":N_ROLL_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":C_REMARK1", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_REMARK2", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_REMARK3", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_REMARK4", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_REMARK5", OracleDbType.Varchar2,500),
                    new OracleParameter(":D_SC_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":N_SLAB_XH_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":C_SLAB_TYPE", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_OLD_NEED_DATE", OracleDbType.Date),
                    new OracleParameter(":D_PJ_DATE", OracleDbType.Date),
                    new OracleParameter(":D_DATE_BY1", OracleDbType.Date),
                    new OracleParameter(":D_DATE_BY2", OracleDbType.Date),
                    new OracleParameter(":D_DATE_BY3", OracleDbType.Date),
                    new OracleParameter(":D_DATE_BY4", OracleDbType.Date),
                    new OracleParameter(":D_DATE_BY5", OracleDbType.Date),
                    new OracleParameter(":D_DATE_BY6", OracleDbType.Date),
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.C_ORDER_NO;
            parameters[1].Value = model.C_CON_NO;
            parameters[2].Value = model.C_CON_NAME;
            parameters[3].Value = model.C_AREA;
            parameters[4].Value = model.C_CUST_NO;
            parameters[5].Value = model.C_CUST_NAME;
            parameters[6].Value = model.C_SALE_CHANNEL;
            parameters[7].Value = model.C_CURRENCYTYPEID;
            parameters[8].Value = model.C_RECEIPTAREAID;
            parameters[9].Value = model.C_RECEIVEADDRESS;
            parameters[10].Value = model.C_RECEIPTCORPID;
            parameters[11].Value = model.C_PROD_NAME;
            parameters[12].Value = model.C_PROD_KIND;
            parameters[13].Value = model.C_INVBASDOCID;
            parameters[14].Value = model.C_INVENTORYID;
            parameters[15].Value = model.C_MAT_CODE;
            parameters[16].Value = model.C_MAT_NAME;
            parameters[17].Value = model.C_STL_GRD;
            parameters[18].Value = model.C_SPEC;
            parameters[19].Value = model.C_TECH_PROT;
            parameters[20].Value = model.C_FREE1;
            parameters[21].Value = model.C_FREE2;
            parameters[22].Value = model.C_PACK;
            parameters[23].Value = model.C_STD_CODE;
            parameters[24].Value = model.C_DESIGN_NO;
            parameters[25].Value = model.C_STDID;
            parameters[26].Value = model.C_DESIGNID;
            parameters[27].Value = model.C_VDEF1;
            parameters[28].Value = model.C_PRO_USE;
            parameters[29].Value = model.C_CUST_SQ;
            parameters[30].Value = model.C_FUNITID;
            parameters[31].Value = model.C_UNITID;
            parameters[32].Value = model.N_HSL;
            parameters[33].Value = model.N_FNUM;
            parameters[34].Value = model.N_WGT;
            parameters[35].Value = model.N_PROFIT;
            parameters[36].Value = model.N_COST;
            parameters[37].Value = model.N_TAXRATE;
            parameters[38].Value = model.N_ORIGINALCURPRICE;
            parameters[39].Value = model.N_ORIGINALCURTAXPRICE;
            parameters[40].Value = model.N_ORIGINALCURTAXMNY;
            parameters[41].Value = model.N_ORIGINALCURMNY;
            parameters[42].Value = model.N_ORIGINALCURSUMMNY;
            parameters[43].Value = model.D_NEED_DT;
            parameters[44].Value = model.D_DELIVERY_DT;
            parameters[45].Value = model.D_DT;
            parameters[46].Value = model.N_STATUS;
            parameters[47].Value = model.N_TYPE;
            parameters[48].Value = model.N_FLAG;
            parameters[49].Value = model.N_EXEC_STATUS;
            parameters[50].Value = model.N_USER_LEV;
            parameters[51].Value = model.C_LEV;
            parameters[52].Value = model.C_ORDER_LEV;
            parameters[53].Value = model.C_REMARK;
            parameters[54].Value = model.C_EMP_ID;
            parameters[55].Value = model.C_EMP_NAME;
            parameters[56].Value = model.D_MOD_DT;
            parameters[57].Value = model.N_SLAB_MATCH_WGT;
            parameters[58].Value = model.N_LINE_MATCH_WGT;
            parameters[59].Value = model.N_PROD_WGT;
            parameters[60].Value = model.N_WARE_WGT;
            parameters[61].Value = model.N_WARE_OUT_WGT;
            parameters[62].Value = model.N_MACH_WGT;
            parameters[63].Value = model.C_ISSUE_EMP_ID;
            parameters[64].Value = model.C_PRD_EMP_ID;
            parameters[65].Value = model.C_DESIGN_PROG;
            parameters[66].Value = model.N_SMS_PROD_WGT;
            parameters[67].Value = model.C_SMS_PROD_EMP_ID;
            parameters[68].Value = model.D_SMS_PROD_DT;
            parameters[69].Value = model.N_ROLL_PROD_WGT;
            parameters[70].Value = model.C_ROLL_PROD_EMP_ID;
            parameters[71].Value = model.D_STL_ROL_DT;
            parameters[72].Value = model.C_LINE_NO;
            parameters[73].Value = model.C_CCM_NO;
            parameters[74].Value = model.N_ISSUE_WGT;
            parameters[75].Value = model.C_RH;
            parameters[76].Value = model.C_LF;
            parameters[77].Value = model.C_KP;
            parameters[78].Value = model.N_HL_TIME;
            parameters[79].Value = model.C_HL;
            parameters[80].Value = model.N_DFP_HL_TIME;
            parameters[81].Value = model.C_DFP_HL;
            parameters[82].Value = model.C_XM;
            parameters[83].Value = model.C_ROUTE;
            parameters[84].Value = model.C_MATRL_CODE_SLAB;
            parameters[85].Value = model.C_MATRL_NAME_SLAB;
            parameters[86].Value = model.C_SLAB_SIZE;
            parameters[87].Value = model.N_SLAB_LENGTH;
            parameters[88].Value = model.N_SLAB_PW;
            parameters[89].Value = model.C_MATRL_CODE_KP;
            parameters[90].Value = model.C_MATRL_NAME_KP;
            parameters[91].Value = model.C_KP_SIZE;
            parameters[92].Value = model.N_KP_LENGTH;
            parameters[93].Value = model.N_KP_PW;
            parameters[94].Value = model.N_GROUP;
            parameters[95].Value = model.N_SORT;
            parameters[96].Value = model.C_XC;
            parameters[97].Value = model.C_SL;
            parameters[98].Value = model.C_WL;
            parameters[99].Value = model.C_SFPJ;
            parameters[100].Value = model.C_TRANSMODE;
            parameters[101].Value = model.N_MACH_WGT_CCM;
            parameters[102].Value = model.C_XGID;
            parameters[103].Value = model.N_ZJCLS;
            parameters[104].Value = model.C_BY1;
            parameters[105].Value = model.C_BY2;
            parameters[106].Value = model.C_BY3;
            parameters[107].Value = model.C_BY4;
            parameters[108].Value = model.C_BY5;
            parameters[109].Value = model.C_NC_ID;
            parameters[110].Value = model.C_LGJH;
            parameters[111].Value = model.C_ZLDJ_ID;
            parameters[112].Value = model.C_ZL_ID;
            parameters[113].Value = model.C_LF_ID;
            parameters[114].Value = model.C_RH_ID;
            parameters[115].Value = model.N_SLAB_WIDTH;
            parameters[116].Value = model.N_SLAB_THICK;
            parameters[117].Value = model.N_DIAMETER;
            parameters[118].Value = model.D_NC_DATE;
            parameters[119].Value = model.C_YWY;
            parameters[120].Value = model.C_NC_SALECODE;
            parameters[121].Value = model.C_TRANSMODEID;
            parameters[122].Value = model.C_DFP_RZ;
            parameters[123].Value = model.C_RZP_RZ;
            parameters[124].Value = model.C_DFP_YQ;
            parameters[125].Value = model.C_RZP_YQ;
            parameters[126].Value = model.C_XM_YQ;
            parameters[127].Value = model.N_JRL_WD;
            parameters[128].Value = model.N_JRL_SJ;
            parameters[129].Value = model.N_KPJRL_WD;
            parameters[130].Value = model.N_KPJRL_SJ;
            parameters[131].Value = model.N_TSL;
            parameters[132].Value = model.C_ROLL_CODE;
            parameters[133].Value = model.C_CCM_CODE;
            parameters[134].Value = model.C_ROLL_DESC;
            parameters[135].Value = model.C_CCM_DESC;
            parameters[136].Value = model.C_TL;
            parameters[137].Value = model.N_ZJCLS_MIN;
            parameters[138].Value = model.N_ZJCLS_MAX;
            parameters[139].Value = model.C_NCSTATUS;
            parameters[140].Value = model.C_PCLX;
            parameters[141].Value = model.C_STL_GRD_TYPE;
            parameters[142].Value = model.D_NS_SEND_DT;
            parameters[143].Value = model.C_ORDER_NO_OLD;
            parameters[144].Value = model.C_STL_GRD_SLAB;
            parameters[145].Value = model.C_STD_CODE_SLAB;
            parameters[146].Value = model.C_PCTBEMP;
            parameters[147].Value = model.D_PCTBTS;
            parameters[148].Value = model.C_SFJK;
            parameters[149].Value = model.C_STL_GRD_CLASS;
            parameters[150].Value = model.N_LENGTH;
            parameters[151].Value = model.N_HG_WGT;
            parameters[152].Value = model.N_DP_WGT;
            parameters[153].Value = model.N_GP_WGT;
            parameters[154].Value = model.N_XY_WGT;
            parameters[155].Value = model.N_TW_WGT;
            parameters[156].Value = model.N_BHG_WGT;
            parameters[157].Value = model.N_HG_WGT_IN;
            parameters[158].Value = model.N_GP_WGT_IN;
            parameters[159].Value = model.N_XY_WGT_IN;
            parameters[160].Value = model.N_TW_WGT_IN;
            parameters[161].Value = model.N_BHG_WGT_IN;
            parameters[162].Value = model.N_HG_WGT_OUT;
            parameters[163].Value = model.N_GP_WGT_OUT;
            parameters[164].Value = model.N_XY_WGT_OUT;
            parameters[165].Value = model.N_TW_WGT_OUT;
            parameters[166].Value = model.N_BHG_WGT_OUT;
            parameters[167].Value = model.D_SALE_TIME_MIN;
            parameters[168].Value = model.D_SALE_TIME_MAX;
            parameters[169].Value = model.D_PRODUCE_DATE_MIN;
            parameters[170].Value = model.D_PRODUCE_DATE_MAX;
            parameters[171].Value = model.N_SLAB_XC_WGT;
            parameters[172].Value = model.N_ROLL_XC_WGT;
            parameters[173].Value = model.D_OLD_DATE;
            parameters[174].Value = model.N_ROLL_WGT;
            parameters[175].Value = model.C_REMARK1;
            parameters[176].Value = model.C_REMARK2;
            parameters[177].Value = model.C_REMARK3;
            parameters[178].Value = model.C_REMARK4;
            parameters[179].Value = model.C_REMARK5;
            parameters[180].Value = model.D_SC_MOD_DT;
            parameters[181].Value = model.N_SLAB_XH_WGT;
            parameters[182].Value = model.C_SLAB_TYPE;
            parameters[183].Value = model.D_OLD_NEED_DATE;
            parameters[184].Value = model.D_PJ_DATE;
            parameters[185].Value = model.D_DATE_BY1;
            parameters[186].Value = model.D_DATE_BY2;
            parameters[187].Value = model.D_DATE_BY3;
            parameters[188].Value = model.D_DATE_BY4;
            parameters[189].Value = model.D_DATE_BY5;
            parameters[190].Value = model.D_DATE_BY6;
            parameters[191].Value = model.C_ID;


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
        public bool Delete(string C_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from TMO_ORDER ");
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
            strSql.Append("delete from TMO_ORDER ");
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
        public Mod_TMO_ORDER GetModel(string C_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from TMO_ORDER ");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)            };
            parameters[0].Value = C_ID;

            Mod_TMO_ORDER model = new Mod_TMO_ORDER();
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
        public Mod_TMO_ORDER GetModelByORDERNO(string C_ORDER_NO)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from TMO_ORDER ");
            strSql.Append(" where C_ORDER_NO=:C_ORDER_NO ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ORDER_NO", OracleDbType.Varchar2,100)         };
            parameters[0].Value = C_ORDER_NO;

            Mod_TMO_ORDER model = new Mod_TMO_ORDER();
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
        public Mod_TMO_ORDER GetModelByORDERNO_Trans(string C_ORDER_NO)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from TMO_ORDER ");
            strSql.Append(" where C_ORDER_NO=:C_ORDER_NO ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ORDER_NO", OracleDbType.Varchar2,100)         };
            parameters[0].Value = C_ORDER_NO;

            Mod_TMO_ORDER model = new Mod_TMO_ORDER();
            DataSet ds = TransactionHelper.Query(strSql.ToString(), parameters);
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
        public Mod_TMO_ORDER DataRowToModel(DataRow row)
        {
            Mod_TMO_ORDER model = new Mod_TMO_ORDER();
            if (row != null)
            {
                if (row["C_ID"] != null)
                {
                    model.C_ID = row["C_ID"].ToString();
                }
                if (row["C_ORDER_NO"] != null)
                {
                    model.C_ORDER_NO = row["C_ORDER_NO"].ToString();
                }
                if (row["C_CON_NO"] != null)
                {
                    model.C_CON_NO = row["C_CON_NO"].ToString();
                }
                if (row["C_CON_NAME"] != null)
                {
                    model.C_CON_NAME = row["C_CON_NAME"].ToString();
                }
                if (row["C_AREA"] != null)
                {
                    model.C_AREA = row["C_AREA"].ToString();
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
                if (row["C_CURRENCYTYPEID"] != null)
                {
                    model.C_CURRENCYTYPEID = row["C_CURRENCYTYPEID"].ToString();
                }
                if (row["C_RECEIPTAREAID"] != null)
                {
                    model.C_RECEIPTAREAID = row["C_RECEIPTAREAID"].ToString();
                }
                if (row["C_RECEIVEADDRESS"] != null)
                {
                    model.C_RECEIVEADDRESS = row["C_RECEIVEADDRESS"].ToString();
                }
                if (row["C_RECEIPTCORPID"] != null)
                {
                    model.C_RECEIPTCORPID = row["C_RECEIPTCORPID"].ToString();
                }
                if (row["C_PROD_NAME"] != null)
                {
                    model.C_PROD_NAME = row["C_PROD_NAME"].ToString();
                }
                if (row["C_PROD_KIND"] != null)
                {
                    model.C_PROD_KIND = row["C_PROD_KIND"].ToString();
                }
                if (row["C_INVBASDOCID"] != null)
                {
                    model.C_INVBASDOCID = row["C_INVBASDOCID"].ToString();
                }
                if (row["C_INVENTORYID"] != null)
                {
                    model.C_INVENTORYID = row["C_INVENTORYID"].ToString();
                }
                if (row["C_MAT_CODE"] != null)
                {
                    model.C_MAT_CODE = row["C_MAT_CODE"].ToString();
                }
                if (row["C_MAT_NAME"] != null)
                {
                    model.C_MAT_NAME = row["C_MAT_NAME"].ToString();
                }
                if (row["C_STL_GRD"] != null)
                {
                    model.C_STL_GRD = row["C_STL_GRD"].ToString();
                }
                if (row["C_SPEC"] != null)
                {
                    model.C_SPEC = row["C_SPEC"].ToString();
                }
                if (row["C_TECH_PROT"] != null)
                {
                    model.C_TECH_PROT = row["C_TECH_PROT"].ToString();
                }
                if (row["C_FREE1"] != null)
                {
                    model.C_FREE1 = row["C_FREE1"].ToString();
                }
                if (row["C_FREE2"] != null)
                {
                    model.C_FREE2 = row["C_FREE2"].ToString();
                }
                if (row["C_PACK"] != null)
                {
                    model.C_PACK = row["C_PACK"].ToString();
                }
                if (row["C_STD_CODE"] != null)
                {
                    model.C_STD_CODE = row["C_STD_CODE"].ToString();
                }
                if (row["C_DESIGN_NO"] != null)
                {
                    model.C_DESIGN_NO = row["C_DESIGN_NO"].ToString();
                }
                if (row["C_STDID"] != null)
                {
                    model.C_STDID = row["C_STDID"].ToString();
                }
                if (row["C_DESIGNID"] != null)
                {
                    model.C_DESIGNID = row["C_DESIGNID"].ToString();
                }
                if (row["C_VDEF1"] != null)
                {
                    model.C_VDEF1 = row["C_VDEF1"].ToString();
                }
                if (row["C_PRO_USE"] != null)
                {
                    model.C_PRO_USE = row["C_PRO_USE"].ToString();
                }
                if (row["C_CUST_SQ"] != null)
                {
                    model.C_CUST_SQ = row["C_CUST_SQ"].ToString();
                }
                if (row["C_FUNITID"] != null)
                {
                    model.C_FUNITID = row["C_FUNITID"].ToString();
                }
                if (row["C_UNITID"] != null)
                {
                    model.C_UNITID = row["C_UNITID"].ToString();
                }
                if (row["N_HSL"] != null && row["N_HSL"].ToString() != "")
                {
                    model.N_HSL = decimal.Parse(row["N_HSL"].ToString());
                }
                if (row["N_FNUM"] != null && row["N_FNUM"].ToString() != "")
                {
                    model.N_FNUM = decimal.Parse(row["N_FNUM"].ToString());
                }
                if (row["N_WGT"] != null && row["N_WGT"].ToString() != "")
                {
                    model.N_WGT = decimal.Parse(row["N_WGT"].ToString());
                }
                if (row["N_PROFIT"] != null && row["N_PROFIT"].ToString() != "")
                {
                    model.N_PROFIT = decimal.Parse(row["N_PROFIT"].ToString());
                }
                if (row["N_COST"] != null && row["N_COST"].ToString() != "")
                {
                    model.N_COST = decimal.Parse(row["N_COST"].ToString());
                }
                if (row["N_TAXRATE"] != null && row["N_TAXRATE"].ToString() != "")
                {
                    model.N_TAXRATE = decimal.Parse(row["N_TAXRATE"].ToString());
                }
                if (row["N_ORIGINALCURPRICE"] != null && row["N_ORIGINALCURPRICE"].ToString() != "")
                {
                    model.N_ORIGINALCURPRICE = decimal.Parse(row["N_ORIGINALCURPRICE"].ToString());
                }
                if (row["N_ORIGINALCURTAXPRICE"] != null && row["N_ORIGINALCURTAXPRICE"].ToString() != "")
                {
                    model.N_ORIGINALCURTAXPRICE = decimal.Parse(row["N_ORIGINALCURTAXPRICE"].ToString());
                }
                if (row["N_ORIGINALCURTAXMNY"] != null && row["N_ORIGINALCURTAXMNY"].ToString() != "")
                {
                    model.N_ORIGINALCURTAXMNY = decimal.Parse(row["N_ORIGINALCURTAXMNY"].ToString());
                }
                if (row["N_ORIGINALCURMNY"] != null && row["N_ORIGINALCURMNY"].ToString() != "")
                {
                    model.N_ORIGINALCURMNY = decimal.Parse(row["N_ORIGINALCURMNY"].ToString());
                }
                if (row["N_ORIGINALCURSUMMNY"] != null && row["N_ORIGINALCURSUMMNY"].ToString() != "")
                {
                    model.N_ORIGINALCURSUMMNY = decimal.Parse(row["N_ORIGINALCURSUMMNY"].ToString());
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
                if (row["N_STATUS"] != null && row["N_STATUS"].ToString() != "")
                {
                    model.N_STATUS = decimal.Parse(row["N_STATUS"].ToString());
                }
                if (row["N_TYPE"] != null && row["N_TYPE"].ToString() != "")
                {
                    model.N_TYPE = decimal.Parse(row["N_TYPE"].ToString());
                }
                if (row["N_FLAG"] != null && row["N_FLAG"].ToString() != "")
                {
                    model.N_FLAG = decimal.Parse(row["N_FLAG"].ToString());
                }
                if (row["N_EXEC_STATUS"] != null && row["N_EXEC_STATUS"].ToString() != "")
                {
                    model.N_EXEC_STATUS = decimal.Parse(row["N_EXEC_STATUS"].ToString());
                }
                if (row["N_USER_LEV"] != null && row["N_USER_LEV"].ToString() != "")
                {
                    model.N_USER_LEV = decimal.Parse(row["N_USER_LEV"].ToString());
                }
                if (row["C_LEV"] != null)
                {
                    model.C_LEV = row["C_LEV"].ToString();
                }
                if (row["C_ORDER_LEV"] != null)
                {
                    model.C_ORDER_LEV = row["C_ORDER_LEV"].ToString();
                }
                if (row["C_REMARK"] != null)
                {
                    model.C_REMARK = row["C_REMARK"].ToString();
                }
                if (row["C_EMP_ID"] != null)
                {
                    model.C_EMP_ID = row["C_EMP_ID"].ToString();
                }
                if (row["C_EMP_NAME"] != null)
                {
                    model.C_EMP_NAME = row["C_EMP_NAME"].ToString();
                }
                if (row["D_MOD_DT"] != null && row["D_MOD_DT"].ToString() != "")
                {
                    model.D_MOD_DT = DateTime.Parse(row["D_MOD_DT"].ToString());
                }
                if (row["N_SLAB_MATCH_WGT"] != null && row["N_SLAB_MATCH_WGT"].ToString() != "")
                {
                    model.N_SLAB_MATCH_WGT = decimal.Parse(row["N_SLAB_MATCH_WGT"].ToString());
                }
                if (row["N_LINE_MATCH_WGT"] != null && row["N_LINE_MATCH_WGT"].ToString() != "")
                {
                    model.N_LINE_MATCH_WGT = decimal.Parse(row["N_LINE_MATCH_WGT"].ToString());
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
                if (row["N_MACH_WGT"] != null && row["N_MACH_WGT"].ToString() != "")
                {
                    model.N_MACH_WGT = decimal.Parse(row["N_MACH_WGT"].ToString());
                }
                if (row["C_ISSUE_EMP_ID"] != null)
                {
                    model.C_ISSUE_EMP_ID = row["C_ISSUE_EMP_ID"].ToString();
                }
                if (row["C_PRD_EMP_ID"] != null)
                {
                    model.C_PRD_EMP_ID = row["C_PRD_EMP_ID"].ToString();
                }
                if (row["C_DESIGN_PROG"] != null)
                {
                    model.C_DESIGN_PROG = row["C_DESIGN_PROG"].ToString();
                }
                if (row["N_SMS_PROD_WGT"] != null && row["N_SMS_PROD_WGT"].ToString() != "")
                {
                    model.N_SMS_PROD_WGT = decimal.Parse(row["N_SMS_PROD_WGT"].ToString());
                }
                if (row["C_SMS_PROD_EMP_ID"] != null)
                {
                    model.C_SMS_PROD_EMP_ID = row["C_SMS_PROD_EMP_ID"].ToString();
                }
                if (row["D_SMS_PROD_DT"] != null && row["D_SMS_PROD_DT"].ToString() != "")
                {
                    model.D_SMS_PROD_DT = DateTime.Parse(row["D_SMS_PROD_DT"].ToString());
                }
                if (row["N_ROLL_PROD_WGT"] != null && row["N_ROLL_PROD_WGT"].ToString() != "")
                {
                    model.N_ROLL_PROD_WGT = decimal.Parse(row["N_ROLL_PROD_WGT"].ToString());
                }
                if (row["C_ROLL_PROD_EMP_ID"] != null)
                {
                    model.C_ROLL_PROD_EMP_ID = row["C_ROLL_PROD_EMP_ID"].ToString();
                }
                if (row["D_STL_ROL_DT"] != null && row["D_STL_ROL_DT"].ToString() != "")
                {
                    model.D_STL_ROL_DT = DateTime.Parse(row["D_STL_ROL_DT"].ToString());
                }
                if (row["C_LINE_NO"] != null)
                {
                    model.C_LINE_NO = row["C_LINE_NO"].ToString();
                }
                if (row["C_CCM_NO"] != null)
                {
                    model.C_CCM_NO = row["C_CCM_NO"].ToString();
                }
                if (row["N_ISSUE_WGT"] != null && row["N_ISSUE_WGT"].ToString() != "")
                {
                    model.N_ISSUE_WGT = decimal.Parse(row["N_ISSUE_WGT"].ToString());
                }
                if (row["C_RH"] != null)
                {
                    model.C_RH = row["C_RH"].ToString();
                }
                if (row["C_LF"] != null)
                {
                    model.C_LF = row["C_LF"].ToString();
                }
                if (row["C_KP"] != null)
                {
                    model.C_KP = row["C_KP"].ToString();
                }
                if (row["N_HL_TIME"] != null && row["N_HL_TIME"].ToString() != "")
                {
                    model.N_HL_TIME = decimal.Parse(row["N_HL_TIME"].ToString());
                }
                if (row["C_HL"] != null)
                {
                    model.C_HL = row["C_HL"].ToString();
                }
                if (row["N_DFP_HL_TIME"] != null && row["N_DFP_HL_TIME"].ToString() != "")
                {
                    model.N_DFP_HL_TIME = decimal.Parse(row["N_DFP_HL_TIME"].ToString());
                }
                if (row["C_DFP_HL"] != null)
                {
                    model.C_DFP_HL = row["C_DFP_HL"].ToString();
                }
                if (row["C_XM"] != null)
                {
                    model.C_XM = row["C_XM"].ToString();
                }
                if (row["C_ROUTE"] != null)
                {
                    model.C_ROUTE = row["C_ROUTE"].ToString();
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
                if (row["N_SORT"] != null && row["N_SORT"].ToString() != "")
                {
                    model.N_SORT = decimal.Parse(row["N_SORT"].ToString());
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
                if (row["C_SFPJ"] != null)
                {
                    model.C_SFPJ = row["C_SFPJ"].ToString();
                }
                if (row["C_TRANSMODE"] != null)
                {
                    model.C_TRANSMODE = row["C_TRANSMODE"].ToString();
                }
                if (row["N_MACH_WGT_CCM"] != null && row["N_MACH_WGT_CCM"].ToString() != "")
                {
                    model.N_MACH_WGT_CCM = decimal.Parse(row["N_MACH_WGT_CCM"].ToString());
                }
                if (row["C_XGID"] != null)
                {
                    model.C_XGID = row["C_XGID"].ToString();
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
                if (row["C_NC_ID"] != null)
                {
                    model.C_NC_ID = row["C_NC_ID"].ToString();
                }
                if (row["C_LGJH"] != null)
                {
                    model.C_LGJH = row["C_LGJH"].ToString();
                }
                if (row["C_ZLDJ_ID"] != null)
                {
                    model.C_ZLDJ_ID = row["C_ZLDJ_ID"].ToString();
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
                if (row["N_DIAMETER"] != null && row["N_DIAMETER"].ToString() != "")
                {
                    model.N_DIAMETER = decimal.Parse(row["N_DIAMETER"].ToString());
                }
                if (row["D_NC_DATE"] != null && row["D_NC_DATE"].ToString() != "")
                {
                    model.D_NC_DATE = DateTime.Parse(row["D_NC_DATE"].ToString());
                }
                if (row["C_YWY"] != null)
                {
                    model.C_YWY = row["C_YWY"].ToString();
                }
                if (row["C_NC_SALECODE"] != null)
                {
                    model.C_NC_SALECODE = row["C_NC_SALECODE"].ToString();
                }
                if (row["C_TRANSMODEID"] != null)
                {
                    model.C_TRANSMODEID = row["C_TRANSMODEID"].ToString();
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
                if (row["C_ROLL_CODE"] != null)
                {
                    model.C_ROLL_CODE = row["C_ROLL_CODE"].ToString();
                }
                if (row["C_CCM_CODE"] != null)
                {
                    model.C_CCM_CODE = row["C_CCM_CODE"].ToString();
                }
                if (row["C_ROLL_DESC"] != null)
                {
                    model.C_ROLL_DESC = row["C_ROLL_DESC"].ToString();
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
                if (row["C_NCSTATUS"] != null)
                {
                    model.C_NCSTATUS = row["C_NCSTATUS"].ToString();
                }
                if (row["C_PCLX"] != null)
                {
                    model.C_PCLX = row["C_PCLX"].ToString();
                }
                if (row["C_STL_GRD_TYPE"] != null)
                {
                    model.C_STL_GRD_TYPE = row["C_STL_GRD_TYPE"].ToString();
                }
                if (row["D_NS_SEND_DT"] != null && row["D_NS_SEND_DT"].ToString() != "")
                {
                    model.D_NS_SEND_DT = DateTime.Parse(row["D_NS_SEND_DT"].ToString());
                }
                if (row["C_ORDER_NO_OLD"] != null)
                {
                    model.C_ORDER_NO_OLD = row["C_ORDER_NO_OLD"].ToString();
                }
                if (row["C_STL_GRD_SLAB"] != null)
                {
                    model.C_STL_GRD_SLAB = row["C_STL_GRD_SLAB"].ToString();
                }
                if (row["C_STD_CODE_SLAB"] != null)
                {
                    model.C_STD_CODE_SLAB = row["C_STD_CODE_SLAB"].ToString();
                }
                if (row["C_PCTBEMP"] != null)
                {
                    model.C_PCTBEMP = row["C_PCTBEMP"].ToString();
                }
                if (row["D_PCTBTS"] != null && row["D_PCTBTS"].ToString() != "")
                {
                    model.D_PCTBTS = DateTime.Parse(row["D_PCTBTS"].ToString());
                }
                if (row["C_SFJK"] != null)
                {
                    model.C_SFJK = row["C_SFJK"].ToString();
                }
                if (row["C_STL_GRD_CLASS"] != null)
                {
                    model.C_STL_GRD_CLASS = row["C_STL_GRD_CLASS"].ToString();
                }
                if (row["N_LENGTH"] != null && row["N_LENGTH"].ToString() != "")
                {
                    model.N_LENGTH = decimal.Parse(row["N_LENGTH"].ToString());
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
                if (row["N_SLAB_XC_WGT"] != null && row["N_SLAB_XC_WGT"].ToString() != "")
                {
                    model.N_SLAB_XC_WGT = decimal.Parse(row["N_SLAB_XC_WGT"].ToString());
                }
                if (row["N_ROLL_XC_WGT"] != null && row["N_ROLL_XC_WGT"].ToString() != "")
                {
                    model.N_ROLL_XC_WGT = decimal.Parse(row["N_ROLL_XC_WGT"].ToString());
                }
                if (row["D_OLD_DATE"] != null && row["D_OLD_DATE"].ToString() != "")
                {
                    model.D_OLD_DATE = DateTime.Parse(row["D_OLD_DATE"].ToString());
                }
                if (row["N_ROLL_WGT"] != null && row["N_ROLL_WGT"].ToString() != "")
                {
                    model.N_ROLL_WGT = decimal.Parse(row["N_ROLL_WGT"].ToString());
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
                if (row["D_SC_MOD_DT"] != null && row["D_SC_MOD_DT"].ToString() != "")
                {
                    model.D_SC_MOD_DT = DateTime.Parse(row["D_SC_MOD_DT"].ToString());
                }
                if (row["N_SLAB_XH_WGT"] != null && row["N_SLAB_XH_WGT"].ToString() != "")
                {
                    model.N_SLAB_XH_WGT = decimal.Parse(row["N_SLAB_XH_WGT"].ToString());
                }
                if (row["C_SLAB_TYPE"] != null)
                {
                    model.C_SLAB_TYPE = row["C_SLAB_TYPE"].ToString();
                }
                if (row["D_OLD_NEED_DATE"] != null && row["D_OLD_NEED_DATE"].ToString() != "")
                {
                    model.D_OLD_NEED_DATE = DateTime.Parse(row["D_OLD_NEED_DATE"].ToString());
                }
                if (row["D_PJ_DATE"] != null && row["D_PJ_DATE"].ToString() != "")
                {
                    model.D_PJ_DATE = DateTime.Parse(row["D_PJ_DATE"].ToString());
                }
                if (row["D_DATE_BY1"] != null && row["D_DATE_BY1"].ToString() != "")
                {
                    model.D_DATE_BY1 = DateTime.Parse(row["D_DATE_BY1"].ToString());
                }
                if (row["D_DATE_BY2"] != null && row["D_DATE_BY2"].ToString() != "")
                {
                    model.D_DATE_BY2 = DateTime.Parse(row["D_DATE_BY2"].ToString());
                }
                if (row["D_DATE_BY3"] != null && row["D_DATE_BY3"].ToString() != "")
                {
                    model.D_DATE_BY3 = DateTime.Parse(row["D_DATE_BY3"].ToString());
                }
                if (row["D_DATE_BY4"] != null && row["D_DATE_BY4"].ToString() != "")
                {
                    model.D_DATE_BY4 = DateTime.Parse(row["D_DATE_BY4"].ToString());
                }
                if (row["D_DATE_BY5"] != null && row["D_DATE_BY5"].ToString() != "")
                {
                    model.D_DATE_BY5 = DateTime.Parse(row["D_DATE_BY5"].ToString());
                }
                if (row["D_DATE_BY6"] != null && row["D_DATE_BY6"].ToString() != "")
                {
                    model.D_DATE_BY6 = DateTime.Parse(row["D_DATE_BY6"].ToString());
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
            strSql.Append(" FROM TMO_ORDER ");
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
            strSql.Append("select count(1) FROM TMO_ORDER ");
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
            strSql.Append(")AS Row, T.*  from TMO_ORDER T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList_TWOrderAdd( string STLGRD,string std)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT CASE WHEN  N_ROLL_PROD_WGT>0 THEN '已下达' ELSE '未下达' END C_EXEC_STATUS ,decode( C_SFPJ,'Y','已评价','未评价') C_SFPJ,T.C_ID,T.C_ORDER_NO,T.C_MAT_CODE,T.C_MAT_NAME,T.C_STL_GRD,T.C_STD_CODE,T.C_SPEC,T.C_FREE1,T.C_FREE2,T.N_WGT,T.D_MOD_DT,T.C_EMP_NAME,T.N_GROUP  FROM TMO_ORDER T WHERE T.N_TYPE = 10 ");
          
            if (!string.IsNullOrEmpty(STLGRD))
            {
                strSql.Append(" AND T.C_STL_GRD LIKE '%"+STLGRD+"%' ");
            }
            if (!string.IsNullOrEmpty(std))
            {
                strSql.Append(" and t.C_STD_CODE like '%"+std+"%' ");
            }
            strSql.Append("  ORDER BY T.D_MOD_DT  ");
            return DbHelperOra.Query(strSql.ToString());
        }
        #endregion  BasicMethod
        #region  ExtensionMethod

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string N_EXEC_STATUS, string N_STATUS)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * ");
            strSql.Append(" FROM TMO_ORDER WHERE 1=1");
            if (N_EXEC_STATUS.Trim() != "")
            {
                strSql.Append(" AND  N_EXEC_STATUS='" + N_EXEC_STATUS + "'");
            }
            if (N_STATUS.Trim() != "")
            {
                strSql.Append(" AND  N_STATUS='" + N_STATUS + "'");
            }
            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList_ByOrderNO(string c_order_no)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from TMO_ORDER t WHERE t.c_order_no='"+ c_order_no + "' ");

            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 变更订单状态
        /// </summary>
        public bool UpByStatus(string N_STATUS)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("update tmo_order set N_EXEC_STATUS=1");
            strSql.Append(" where N_STATUS=2");
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
        /// 查询该方案未初始化订单信息
        /// </summary>
        /// <param name="strIniID">方案主键</param>
        /// <param name="type">是否初始化：是/否</param>
        public DataTable GetWCSHOrderByIni(string strIniID, string type)
        {
            string sql = "SELECT C_CUST_NAME,C_CUST_NO, N_WGT,N_INI_WGT, M.C_ID, M.C_ORDER_NO, M.C_CON_NO, M.C_CON_NAME, M.C_AREA, M.C_MAT_CODE, M.C_MAT_NAME, M.C_TECH_PROT, M.C_SPEC, M.C_STL_GRD, M.C_STD_CODE, M.C_FREE_TERM, M.C_FREE_TERM2, M.C_PRO_USE, M.D_NEED_DT, M.D_DELIVERY_DT, M.C_PACK, M.C_LEV FROM (SELECT C_CUST_NAME,C_CUST_NO,  T.N_WGT, NVL((SELECT SUM(NVL(A.N_WGT, 0)) FROM TPP_INITIALIZE_ORDER A WHERE A.C_ORDER_ID = T.C_ID AND A.C_INITIALIZE_ID = '" + strIniID + "' GROUP BY A.C_ORDER_ID, C_INITIALIZE_ID), 0) N_INI_WGT, T.C_ID, T.C_ORDER_NO, T.C_CON_NO, T.C_CON_NAME, T.C_AREA, T.C_MAT_CODE, T.C_MAT_NAME, T.C_TECH_PROT, T.C_SPEC, T.C_STL_GRD, T.C_STD_CODE, T.C_FREE_TERM, T.C_FREE_TERM2, T.C_PRO_USE, T.D_NEED_DT, T.D_DELIVERY_DT, T.C_PACK, T.C_LEV FROM TMO_ORDER T WHERE T.N_STATUS = 2 AND T.N_EXEC_STATUS in (0,2,5,6)) M WHERE 1=1 ";
            if (type == "否")
            {
                sql = sql + " AND M.N_WGT > M.N_INI_WGT ";
            }
            else
            {
                sql = sql + " AND  M.N_WGT = M.N_INI_WGT ";
            }
            sql = sql + " AND C_ORDER_NO NOT LIKE '%XG%'  ";

            sql = sql + " ORDER BY C_ORDER_NO  ";

            return DbHelperOra.Query(sql).Tables[0];
        }
        /// <summary>
        /// 查询该方案未初始化订单信息
        /// </summary>
        /// <param name="strIniID">方案主键</param>
        /// <param name="type">是否初始化：是/否</param>
        /// <param name="IntDT">计划类型0未分1月排产2旬排产</param>
        /// <returns></returns>
        public DataTable GetWCSHOrderByIni(string strIniID, string type, string strDT)
        {
            string sql = "SELECT C_CUST_NAME,C_CUST_NO, N_WGT,N_INI_WGT,M.N_FLAG, M.C_ID, M.C_ORDER_NO, M.C_CON_NO, M.C_CON_NAME, M.C_AREA, M.C_MAT_CODE, M.C_MAT_NAME, M.C_TECH_PROT, M.C_SPEC, M.C_STL_GRD, M.C_STD_CODE, M.C_FREE_TERM, M.C_FREE_TERM2, M.C_PRO_USE, M.D_NEED_DT, M.D_DELIVERY_DT, M.C_PACK, M.C_LEV FROM (SELECT C_CUST_NAME,C_CUST_NO,  T.N_WGT,";
            if (strIniID.Trim().Length > 0)
            {
                sql = sql + " NVL((SELECT SUM(NVL(A.N_WGT, 0)) FROM TPP_INITIALIZE_ORDER A WHERE A.C_ORDER_ID = T.C_ID AND A.C_INITIALIZE_ID = '" + strIniID + "' GROUP BY A.C_ORDER_ID, C_INITIALIZE_ID), 0) N_INI_WGT,";
            }
            else
            {
                sql = sql + " T.N_WGT  N_INI_WGT,";
            }

            sql = sql + "  T.C_ID, T.C_ORDER_NO, T.C_CON_NO, T.C_CON_NAME, T.C_AREA, T.C_MAT_CODE, T.C_MAT_NAME, T.C_TECH_PROT, T.C_SPEC, T.C_STL_GRD, T.C_STD_CODE, T.C_FREE_TERM, T.C_FREE_TERM2, T.C_PRO_USE, T.D_NEED_DT, T.D_DELIVERY_DT, T.C_PACK, T.C_LEV,T.N_FLAG FROM TMO_ORDER T WHERE T.N_STATUS = 2 AND T.N_EXEC_STATUS = 0) M WHERE 1=1 ";
            if (type.Trim().Length > 0)
            {
                if (type == "否")
                {
                    sql = sql + " AND M.N_WGT > M.N_INI_WGT ";
                }
                else
                {
                    sql = sql + " AND  M.N_WGT = M.N_INI_WGT ";
                }
            }
            //sql = sql + " AND C_ORDER_NO NOT LIKE '%XG%'  ";

            if (strDT.Trim().Length > 0)
            {
                sql = sql + " AND M.N_FLAG=" + strDT + " ";
            }

            sql = sql + " ORDER BY C_ORDER_NO  ";

            return DbHelperOra.Query(sql).Tables[0];
        }


        /// <summary>
        /// 查询该方案未初始化订单信息
        /// </summary>
        /// <param name="strIniID">方案主键</param>
        /// <param name="type">是否初始化：是/否</param>
        /// <param name="IntDT">计划类型0未分1月排产2旬排产</param>
        /// <param name="N_STATUS">是否审核 默认0，2生效</param>
        /// <param name="N_EXEC_STATUS">执行状态:0未排产，1已排产</param>
        /// <returns></returns>
        public DataTable GetWCSHOrderByIni(string strIniID, string type, string strDT, int N_STATUS, int N_EXEC_STATUS)
        {
            string sql = "SELECT C_CUST_NAME,C_CUST_NO, N_WGT,N_INI_WGT,M.N_FLAG, M.C_ID, M.C_ORDER_NO, M.C_CON_NO, M.C_CON_NAME, M.C_AREA, M.C_MAT_CODE, M.C_MAT_NAME, M.C_TECH_PROT, M.C_SPEC, M.C_STL_GRD, M.C_STD_CODE, M.C_FREE_TERM, M.C_FREE_TERM2, M.C_PRO_USE, M.D_NEED_DT, M.D_DELIVERY_DT, M.C_PACK, M.C_LEV FROM (SELECT C_CUST_NAME,C_CUST_NO,  T.N_WGT,";
            if (strIniID.Trim().Length > 0)
            {
                sql = sql + " NVL((SELECT SUM(NVL(A.N_WGT, 0)) FROM TPP_INITIALIZE_ORDER A WHERE A.C_ORDER_ID = T.C_ID AND A.C_INITIALIZE_ID = '" + strIniID + "' GROUP BY A.C_ORDER_ID, C_INITIALIZE_ID), 0) N_INI_WGT,";
            }
            else
            {
                sql = sql + " T.N_WGT  N_INI_WGT,";
            }

            sql = sql + "  T.C_ID, T.C_ORDER_NO, T.C_CON_NO, T.C_CON_NAME, T.C_AREA, T.C_MAT_CODE, T.C_MAT_NAME, T.C_TECH_PROT, T.C_SPEC, T.C_STL_GRD, T.C_STD_CODE, T.C_FREE_TERM, T.C_FREE_TERM2, T.C_PRO_USE, T.D_NEED_DT, T.D_DELIVERY_DT, T.C_PACK, T.C_LEV,T.N_FLAG FROM TMO_ORDER T WHERE ";

            sql = sql + "   T.N_STATUS = " + N_STATUS + "  ";
            sql = sql + "   AND T.N_EXEC_STATUS = " + N_EXEC_STATUS + " ";
            sql = sql + "  ) M WHERE 1=1 ";
            if (type.Trim().Length > 0)
            {
                if (type == "否")
                {
                    sql = sql + " AND M.N_WGT > M.N_INI_WGT ";
                }
                else
                {
                    sql = sql + " AND  M.N_WGT = M.N_INI_WGT ";
                }
            }
            //sql = sql + " AND C_ORDER_NO NOT LIKE '%XG%'  ";

            if (strDT.Trim().Length > 0)
            {
                sql = sql + " AND M.N_FLAG=" + strDT + " ";
            }

            sql = sql + " ORDER BY C_ORDER_NO  ";

            return DbHelperOra.Query(sql).Tables[0];
        }


        /// <summary>
        /// 获取订单主键
        /// </summary>
        public string Get_ID(string C_ORDER_NO, string C_CON_NO, string C_STL_GRD, string C_STD_CODE)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select max(C_ID) FROM TMO_ORDER where C_ORDER_NO='" + C_ORDER_NO + "' and C_CON_NO='" + C_CON_NO + "' and C_STL_GRD='" + C_STL_GRD + "' and C_STD_CODE='" + C_STD_CODE + "' ");

            object obj = DbHelperOra.GetSingle(strSql.ToString());
            if (obj == null)
            {
                return "0";
            }
            else
            {
                return obj.ToString();
            }
        }



        /// <summary>
        /// 根据条件查询销售订单信息
        /// </summary>
        /// <param name="C_SFPJ">是否已经评价</param>
        /// <param name="N_STATUS">订单状态</param>
        /// <param name="N_EXEC_STATUS">执行状态:-2人为关闭-1刚导入，0自由状态 1生成销售订单，2销售订单上传NC</param>
        /// <param name="N_SFPW">是否排产完0未排完1已排完 NULL未排（(N_WGT-N_ROLL_PROD_WGT-N_LINE_MATCH_WGT)=0&&(N_WGT-N_SMS_PROD_WGT-N_SLAB_MATCH_WGT)=0）</param>
        /// <param name="C_ORDER_NO">订单号</param>
        /// <param name="C_CON_NO">合同号</param>
        /// <param name="C_AREA">销售区域</param>
        /// <param name="C_STL_GRD">钢种</param>
        /// <param name="C_STD_CODE">执行标准</param>
        /// <param name="C_SPEC">规格</param>
        /// <param name="D_SPEC_MIN">规格最小</param>
        /// <param name="D_SPEC_MAX">规格最大</param>
        /// <param name="C_LINE_NO">产线号</param>
        /// <param name="C_CCM_NO">连铸号</param>
        /// <param name="C_CUST_NAME">客户名称</param>
        /// <param name="C_SALE_CHANNEL">销售类型</param>
        /// <param name="C_PRO_USE">产品用途</param>
        /// <param name="C_RH">是否真空</param>
        /// <param name="C_HL">是否缓冷</param>
        ///  <param name="C_JQ_MIN">交货日期最小值</param>
        ///  <param name="C_JQ_MAX">交货日期最大值</param>
        /// <returns>销售订单列表</returns>
        public DataSet GetListByWhere(string C_SFPJ, int? N_STATUS, int? N_EXEC_STATUS, int? N_SFPW, string C_ORDER_NO, string C_CON_NO, string C_AREA, string C_STL_GRD, string C_STD_CODE, string C_SPEC, double? D_SPEC_MIN, double? D_SPEC_MAX, string C_LINE_NO, string C_CCM_NO, string C_CUST_NAME, string C_SALE_CHANNEL, string C_PRO_USE, string C_RH, string C_HL, string C_JQ_MIN, string C_JQ_MAX)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_ORDER_NO,C_CON_NO,C_CON_NAME,C_AREA,C_CUST_NO, (N_WGT-nvl(N_PROD_WGT,0) - N_ROLL_PROD_WGT - N_LINE_MATCH_WGT) N_R_WGT,(N_WGT-N_SMS_PROD_WGT-N_SLAB_MATCH_WGT) N_R_WGT_SLAB,C_CUST_NAME,C_SALE_CHANNEL,C_CURRENCYTYPEID,C_RECEIPTAREAID,C_RECEIVEADDRESS,C_RECEIPTCORPID,C_PROD_NAME,C_PROD_KIND,C_INVBASDOCID,C_INVENTORYID,C_MAT_CODE,C_MAT_NAME,C_STL_GRD,C_SPEC,C_TECH_PROT,C_FREE1,C_FREE2,C_PACK,C_STD_CODE,C_DESIGN_NO,C_STDID,C_DESIGNID,C_VDEF1,C_PRO_USE,C_CUST_SQ,C_FUNITID,C_UNITID,N_HSL,N_FNUM,N_WGT,N_PROFIT,N_COST,N_TAXRATE,N_ORIGINALCURPRICE,N_ORIGINALCURTAXPRICE,N_ORIGINALCURTAXMNY,N_ORIGINALCURMNY,N_ORIGINALCURSUMMNY,D_NEED_DT,D_DELIVERY_DT,D_DT,N_STATUS,N_TYPE,N_FLAG,N_EXEC_STATUS,N_USER_LEV,C_LEV,C_ORDER_LEV,C_REMARK,C_EMP_ID,C_EMP_NAME,D_MOD_DT,N_SLAB_MATCH_WGT,N_LINE_MATCH_WGT,N_PROD_WGT,N_WARE_WGT,N_WARE_OUT_WGT,N_MACH_WGT,C_ISSUE_EMP_ID,C_PRD_EMP_ID,C_DESIGN_PROG,N_SMS_PROD_WGT,C_SMS_PROD_EMP_ID,D_SMS_PROD_DT,N_ROLL_PROD_WGT,C_ROLL_PROD_EMP_ID,D_STL_ROL_DT,(SELECT A.C_STA_DESC FROM TB_STA A WHERE A.C_ID= T.C_LINE_NO ) C_LINE_NO,(SELECT A.C_STA_DESC FROM TB_STA A WHERE A.C_ID= T.C_CCM_NO )C_CCM_NO,N_ISSUE_WGT,C_RH,C_LF,C_KP,N_HL_TIME,C_HL,N_DFP_HL_TIME,C_DFP_HL,C_XM,C_ROUTE,C_MATRL_CODE_SLAB,C_MATRL_NAME_SLAB,C_SLAB_SIZE,N_SLAB_LENGTH,N_SLAB_PW,C_MATRL_CODE_KP,C_MATRL_NAME_KP,C_KP_SIZE,N_KP_LENGTH,N_KP_PW,N_GROUP,N_SORT,C_XC,C_SL,C_WL,C_SFPJ,C_TRANSMODE,N_MACH_WGT_CCM,C_XGID,N_ZJCLS,C_BY1,C_BY2,C_BY3,C_BY4,C_BY5,C_NC_ID,C_LGJH,C_ZLDJ_ID,C_ZL_ID,C_LF_ID,C_RH_ID,N_SLAB_WIDTH,N_SLAB_THICK,N_DIAMETER ");
            strSql.Append(" FROM TMO_ORDER T WHERE 1=1");
            if (C_SFPJ.Trim() != "")
            {
                strSql.Append(" AND   C_SFPJ ='" + C_SFPJ + "'");
            }
            if (N_STATUS != null)
            {
                strSql.Append(" AND   N_STATUS =" + N_STATUS);
            }
            if (N_EXEC_STATUS != null)
            {
                strSql.Append(" AND   N_EXEC_STATUS =" + N_EXEC_STATUS);
            }
            else
            {
                strSql.Append(" AND   N_EXEC_STATUS>=0 ");
            }

            if (N_SFPW == 1)
            {
                strSql.Append(" AND  (N_WGT-nvl(N_PROD_WGT,0) - N_ROLL_PROD_WGT - N_LINE_MATCH_WGT)=0 AND (N_WGT-N_SMS_PROD_WGT-N_SLAB_MATCH_WGT)=0");
            }
            if (N_SFPW == 0)
            {
                strSql.Append(" AND  (N_WGT-nvl(N_PROD_WGT,0) - N_ROLL_PROD_WGT - N_LINE_MATCH_WGT)>0 OR (N_WGT-N_SMS_PROD_WGT-N_SLAB_MATCH_WGT)>0 )");
            }
            else
            {
                strSql.Append(" AND  NVL(N_ROLL_PROD_WGT, 0) = 0 AND NVL(N_SMS_PROD_WGT,0)= 0");
            }
            if (C_ORDER_NO.Trim() != "")
            {
                strSql.Append(" AND   C_ORDER_NO  LIKE '%" + C_ORDER_NO + "%'");
            }
            if (C_CON_NO.Trim() != "")
            {
                strSql.Append(" AND   C_CON_NO LIKE '%" + C_CON_NO + "%'");
            }
            if (C_AREA.Trim() != "")
            {
                strSql.Append(" AND   C_AREA LIKE '%" + C_AREA + "%'");

            }
            if (C_STL_GRD.Trim() != "")
            {
                strSql.Append(" AND   C_STL_GRD LIKE '%" + C_STL_GRD + "%'");
            }

            if (C_STD_CODE.Trim() != "")
            {
                strSql.Append(" AND   C_STD_CODE LIKE '%" + C_STD_CODE + "%'");
            }
            if (C_SPEC.Trim() != "")
            {
                strSql.Append(" AND   C_SPEC LIKE '%" + C_SPEC + "%'");
            }
            if (D_SPEC_MIN != null)
            {
                strSql.Append("   AND ((T.C_SPEC LIKE '%φ%' AND TO_NUMBER(REPLACE(T.C_SPEC, 'φ', '')) >= " + D_SPEC_MIN + ") OR  (T.C_SPEC LIKE '%*%' AND TO_NUMBER(GET_STRARRAYSTROFINDEX(T.C_SPEC, '*', 0)) >= " + D_SPEC_MIN + "))");
            }

            if (D_SPEC_MAX != null)
            {
                strSql.Append("   AND ((T.C_SPEC LIKE '%φ%' AND TO_NUMBER(REPLACE(T.C_SPEC, 'φ', '')) <= " + D_SPEC_MAX + ") OR  (T.C_SPEC LIKE '%*%' AND TO_NUMBER(GET_STRARRAYSTROFINDEX(T.C_SPEC, '*', 0)) <= " + D_SPEC_MAX + "))");
            }

            if (C_LINE_NO.Trim() != "")
            {
                strSql.Append(" AND   C_LINE_NO = '" + C_LINE_NO + "'");
            }
            if (C_CCM_NO.Trim() != "")
            {
                strSql.Append(" AND   C_CCM_NO = '" + C_CCM_NO + "'");
            }
            if (C_CUST_NAME.Trim() != "")
            {
                strSql.Append(" AND   C_CUST_NAME LIKE  '%" + C_CUST_NAME + "%'");
            }
            if (C_SALE_CHANNEL.Trim() != "")
            {
                strSql.Append(" AND   C_SALE_CHANNEL =  '" + C_SALE_CHANNEL + "%'");
            }

            if (C_PRO_USE.Trim() != "")
            {
                strSql.Append(" AND   C_PRO_USE LIKE  '%" + C_PRO_USE + "%'");
            }
            if (C_RH.Trim() != "")
            {
                strSql.Append(" AND   C_RH =  '" + C_RH + "'");
            }
            if (C_HL.Trim() != "")
            {
                strSql.Append(" AND   C_HL =  '" + C_HL + "'");
            }
            if (C_JQ_MIN.Trim() != "")
            {
                strSql.Append(" AND  D_DELIVERY_DT >=TO_DATE('" + C_JQ_MIN + "','yyyy-mm-dd hh24:mi:ss')");
            }
            if (C_JQ_MAX.Trim() != "")
            {
                strSql.Append("  AND  D_DELIVERY_DT >=TO_DATE('" + C_JQ_MAX + "','yyyy-mm-dd hh24:mi:ss')");
            }
            strSql.Append(" ORDER BY D_DELIVERY_DT,C_ORDER_LEV,C_LEV,N_USER_LEV,C_STL_GRD,C_STD_CODE");
            return DbHelperOra.Query(strSql.ToString());
        }




        /// <summary>
        /// 根据条件查询销售订单信息
        /// </summary>
        /// <param name="n_type">0全部，1碳钢，2不锈钢，3钢坯</param>
        /// <param name="C_SFPJ">是否已经评价</param>
        /// <param name="N_STATUS">订单状态</param>
        /// <param name="N_EXEC_STATUS">执行状态:0未完成，1已完成</param>
        /// <param name="N_SFPW">是否排产完0未排完1已排完 null全部</param>
        /// <param name="C_ORDER_NO">订单号</param>
        /// <param name="C_CON_NO">合同号</param>
        /// <param name="C_STL_GRD">钢种</param>
        /// <param name="C_STD_CODE">执行标准</param>
        /// <param name="C_SPEC">规格</param>

        /// <param name="C_LINE_NO">产线号</param>
        /// <param name="C_CCM_NO">连铸号</param>
        /// <param name="C_CUST_NAME">客户名称</param>
        ///  <param name="C_JQ_MIN">计划日期最小值</param>
        ///  <param name="C_JQ_MAX">计划日期最大值</param>
        ///  <param name="C_DD_MIN">订单日期最小值</param>
        ///  <param name="C_DD_MAX">订单日期最大值</param>
        /// <returns>销售订单列表</returns>
        public DataSet GetOrderByWhere(int n_type, string C_SFPJ, int? N_EXEC_STATUS, int? N_SFPW, string C_ORDER_NO, string C_CON_NO, string C_STL_GRD, string C_STD_CODE, string C_SPEC, string C_CUST_NAME, string C_JQ_MIN, string C_JQ_MAX, string C_DD_MIN, string C_DD_MAX, string C_LINE_NO)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(@"SELECT   T.C_ID,
       T.C_ORDER_NO,
       T.C_CON_NO,
       T.C_CON_NAME,
       T.C_AREA,
       T.C_CUST_NO,
       T.C_CUST_NAME,
       T.C_SALE_CHANNEL,
       T.C_CURRENCYTYPEID,
       T.C_RECEIPTAREAID,
       T.C_RECEIVEADDRESS,
       T.C_RECEIPTCORPID,
       T.C_PROD_NAME,
       T.C_PROD_KIND,
       T.C_INVBASDOCID,
       T.C_INVENTORYID,
       T.C_MAT_CODE,
       T.C_MAT_NAME,
       T.C_STL_GRD,
       T.C_SPEC,
       T.C_TECH_PROT,
       T.C_FREE1,
       T.C_FREE2,
       T.C_PACK,
       T.C_STD_CODE,
       T.C_DESIGN_NO,
       T.C_STDID,
       T.C_DESIGNID,
       T.C_VDEF1,
       T.C_PRO_USE,
       T.C_CUST_SQ,
       T.C_FUNITID,
       T.C_UNITID,
       T.N_HSL,
       T.N_FNUM,
       T.N_WGT,
       T.N_PROFIT,
       T.N_COST,
       T.N_TAXRATE,
       T.N_ORIGINALCURPRICE,
       T.N_ORIGINALCURTAXPRICE,
       T.N_ORIGINALCURTAXMNY,
       T.N_ORIGINALCURMNY,
       T.N_ORIGINALCURSUMMNY,
       T.D_NEED_DT,
       T.D_DELIVERY_DT,
       T.D_DT,
       T.N_STATUS,
       T.N_TYPE,
       T.N_FLAG,
      T.N_EXEC_STATUS ,
       T.N_USER_LEV,
       T.C_LEV,
       T.C_ORDER_LEV,
       T.C_REMARK,
       T.C_EMP_ID,
       T.C_EMP_NAME,
       T.D_MOD_DT,
       T.N_SLAB_MATCH_WGT,
       T.N_LINE_MATCH_WGT,
       T.N_PROD_WGT,
       T.N_WARE_WGT,
       T.N_WARE_OUT_WGT,
       T.N_MACH_WGT,
       T.C_ISSUE_EMP_ID,
       T.C_PRD_EMP_ID,
       T.C_DESIGN_PROG,
       T.N_SMS_PROD_WGT,
       T.C_SMS_PROD_EMP_ID,
       T.D_SMS_PROD_DT,
       T.N_ROLL_PROD_WGT,
       T.C_ROLL_PROD_EMP_ID,
       T.D_STL_ROL_DT,
       T.C_LINE_NO,
       T.C_CCM_NO,
       T.N_ISSUE_WGT,
       T.C_RH,
       T.C_LF,
       T.C_KP,
       T.N_HL_TIME,
       T.C_HL,
       T.N_DFP_HL_TIME,
       T.C_DFP_HL,
       T.C_XM,
       T.C_ROUTE,
       T.C_MATRL_CODE_SLAB,
       T.C_MATRL_NAME_SLAB,
       T.C_SLAB_SIZE,
       T.N_SLAB_LENGTH,
       T.N_SLAB_PW,
       T.C_MATRL_CODE_KP,
       T.C_MATRL_NAME_KP,
       T.C_KP_SIZE,
       T.N_KP_LENGTH,
       T.N_KP_PW,
       T.N_GROUP,
       T.N_SORT,
       T.C_XC,
       T.C_SL,
       T.C_WL,
       T.C_SFPJ,
       T.C_TRANSMODE,
       T.N_MACH_WGT_CCM,
       T.C_XGID,
       T.N_ZJCLS,
       T.C_BY1,
       T.C_BY2,
       T.C_BY3,
       T.C_BY4,
       T.C_BY5,
       T.C_NC_ID,
       T.C_LGJH,
       T.C_ZLDJ_ID,
       T.C_ZL_ID,
       T.C_LF_ID,
       T.C_RH_ID,
       T.N_SLAB_WIDTH,
       T.N_SLAB_THICK,
       T.N_DIAMETER,
       T.D_NC_DATE,
       T.C_YWY,
       T.C_NC_SALECODE,
       T.C_TRANSMODEID,
       T.C_DFP_RZ,
       T.C_RZP_RZ,
       T.C_DFP_YQ,
       T.C_RZP_YQ,
       T.C_XM_YQ,
       T.N_JRL_WD,
       T.N_JRL_SJ,
       T.N_KPJRL_WD,
       T.N_KPJRL_SJ,
       T.N_TSL,
       T.C_ROLL_CODE,
       T.C_CCM_CODE,
       T.C_ROLL_DESC,
       T.C_CCM_DESC,
       T.C_TL,
       T.N_ZJCLS_MIN,
       T.N_ZJCLS_MAX,
       T.C_NCSTATUS,
       T.C_PCLX,
       T.C_STL_GRD_TYPE,
       T.D_NS_SEND_DT,
       T.C_ORDER_NO_OLD,
       T.C_STL_GRD_SLAB,
       T.C_STD_CODE_SLAB,
       T.C_PCTBEMP,
      TO_CHAR( T.D_PCTBTS,'yyyy-mm-dd') D_PCTBTS,
       T.C_SFJK,
       T.C_STL_GRD_CLASS,
       T.N_LENGTH,
       T.N_HG_WGT,
       T.N_DP_WGT,
       T.N_GP_WGT,
       T.N_XY_WGT,
       T.N_TW_WGT,
       T.N_BHG_WGT,
       T.N_HG_WGT_IN,
       T.N_GP_WGT_IN,
       T.N_XY_WGT_IN,
       T.N_TW_WGT_IN,
       T.N_BHG_WGT_IN,
       T.N_HG_WGT_OUT,
       T.N_GP_WGT_OUT,
       T.N_XY_WGT_OUT,
       T.N_TW_WGT_OUT,
       T.N_BHG_WGT_OUT,
       T.D_SALE_TIME_MIN,
       T.D_SALE_TIME_MAX,
       T.D_PRODUCE_DATE_MIN,
       T.D_PRODUCE_DATE_MAX,
       T.D_OLD_DATE,
       T.N_ROLL_WGT,
       (SELECT SUM(A.N_WGT)
          FROM TSC_SLAB_MAIN A
         WHERE A.C_STL_GRD = T.C_STL_GRD_SLAB
           AND A.C_STD_CODE = T.C_STD_CODE_SLAB
           AND A.C_MOVE_TYPE IN ('E','M','DZ','NP','R','DX')) N_SLAB_XC_WGT,
       (SELECT SUM(A.N_WGT)
          FROM TRC_ROLL_PRODCUT A
         WHERE A.C_STL_GRD = T.C_STL_GRD
           AND A.C_MOVE_TYPE IN('E', 'M')
           AND A.C_STD_CODE = T.C_STD_CODE
           AND A.C_SPEC = T.C_SPEC
           AND A.C_ZYX1 = T.C_FREE1
           AND A.C_ZYX2 = T.C_FREE2
           AND A.C_BZYQ = T.C_PACK) N_ROLL_XC_WGT,C_REMARK1,
C_REMARK2,
C_REMARK3,
C_REMARK4,
C_REMARK5,
D_SC_MOD_DT,
N_SLAB_XH_WGT,
C_SLAB_TYPE,
D_OLD_NEED_DATE,
D_PJ_DATE,
D_DATE_BY1,
D_DATE_BY2,
D_DATE_BY3,
D_DATE_BY4,
D_DATE_BY5,
D_DATE_BY6


  FROM TMO_ORDER T ");
            strSql.Append("  WHERE      N_STATUS=2   AND nvl(C_REMARK,1) <> '人工关闭'   AND T.N_TYPE IN (6, 8)  ");

            if (n_type == 1)
            {
                strSql.Append("  AND T.N_TYPE =8 AND T.C_BY4='0' ");
            }
            else if (n_type == 2)
            {
                strSql.Append("  AND T.N_TYPE =8 AND T.C_BY4='1' ");
            }
            else if (n_type == 3)
            {
                strSql.Append("  AND T.N_TYPE =6  ");
            }
            if (C_SFPJ.Trim() != "")
            {
                strSql.Append(" AND   nvl(C_SFPJ,'N') ='" + C_SFPJ + "'");
            }



            if (C_LINE_NO.Trim() != "all")
            {
                if (C_LINE_NO.Trim() == "")
                {
                    strSql.Append(" AND   C_LINE_NO IS NULL ");
                }
                else
                {
                    strSql.Append(" AND   C_LINE_NO='" + C_LINE_NO + "'");
                }

            }
            if (N_EXEC_STATUS == 0)//未完成
            {
                strSql.Append(" AND   N_EXEC_STATUS  IN (0,2,6,8)");

            }
            else if (N_EXEC_STATUS == 1)//已完成
            {
                strSql.Append(" AND   N_EXEC_STATUS  IN (0,2)");

            }
            else if (N_EXEC_STATUS == 2)
            {
                strSql.Append(" AND   N_EXEC_STATUS=6");
            }

            else if (N_EXEC_STATUS ==3)
            {
                strSql.Append(" AND   N_EXEC_STATUS=8  ");
            }
            if (N_SFPW == 2)//已下达轧钢
            {
                strSql.Append("  AND N_ROLL_PROD_WGT>0 ");

            }
            else if (N_SFPW == 1)//未下达
            {
                strSql.Append("  AND N_ROLL_PROD_WGT=0 ");
            }

            //if (C_ORDER_NO.Trim() != "")
            //{
            //    strSql.Append(" AND INSTR('" + C_ORDER_NO + "',C_ORDER_NO )>0");
            //}

            if (C_ORDER_NO.Trim() != "")
            {
                strSql.Append(" AND C_ORDER_NO IN("+ C_ORDER_NO + ")");
            }

            if (C_CON_NO.Trim() != "")
            {
                strSql.Append(" AND   C_CON_NO LIKE '%" + C_CON_NO + "%'");
            }

            if (C_STL_GRD.Trim() != "")
            {
                strSql.Append(" AND   C_STL_GRD LIKE '%" + C_STL_GRD + "%'");
            }

            if (C_STD_CODE.Trim() != "")
            {
                strSql.Append(" AND   C_STD_CODE LIKE '%" + C_STD_CODE + "%'");
            }

            if (C_SPEC.Trim() != "")
            {
                strSql.Append("   AND  INSTR('" + C_SPEC + "',C_SPEC)>0 ");
            }

            if (C_CUST_NAME.Trim() != "")
            {
                strSql.Append(" AND   C_MAT_NAME LIKE  '%" + C_CUST_NAME + "%'");
            }

            if (C_JQ_MIN.Trim() != "")
            {
                strSql.Append(" AND  D_PCTBTS >=TO_DATE('" + C_JQ_MIN + "','yyyy-mm-dd hh24:mi:ss')");
            }
            if (C_JQ_MAX.Trim() != "")
            {
                strSql.Append("  AND  D_PCTBTS <=TO_DATE('" + C_JQ_MAX + "','yyyy-mm-dd hh24:mi:ss')");
            }

            if (C_DD_MIN.Trim() != "")
            {
                strSql.Append(" AND  D_DT >=TO_DATE('" + C_DD_MIN + "','yyyy-mm-dd hh24:mi:ss')");
            }
            if (C_DD_MAX.Trim() != "")
            {
                strSql.Append("  AND  D_DT<=TO_DATE('" + C_DD_MAX + "','yyyy-mm-dd hh24:mi:ss')");
            }

            strSql.Append(" ORDER BY D_DELIVERY_DT,C_ORDER_LEV,C_LEV,N_USER_LEV,C_STL_GRD,C_STD_CODE");
            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取订单物料名称
        /// </summary>
        ///  <param name="C_JQ_MIN">交货日期最小值</param>
        ///  <param name="C_JQ_MAX">交货日期最大值</param>
        ///  <param name="C_DD_MIN">订单日期最小值</param>
        ///  <param name="C_DD_MAX">订单日期最大值</param>
        /// <returns></returns>
        public DataTable GetMatrelName(string C_JQ_MIN, string C_JQ_MAX, string C_DD_MIN, string C_DD_MAX)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("   SELECT Distinct t.c_mat_name from TMO_ORDER t WHERE  t.n_TYPE IN (6,8) ");
            if (C_JQ_MIN.Trim() != "")
            {
                strSql.Append(" AND  D_DELIVERY_DT >=TO_DATE('" + C_JQ_MIN + "','yyyy-mm-dd hh24:mi:ss')");
            }
            if (C_JQ_MAX.Trim() != "")
            {
                strSql.Append("  AND  D_DELIVERY_DT >=TO_DATE('" + C_JQ_MAX + "','yyyy-mm-dd hh24:mi:ss')");
            }

            if (C_DD_MIN.Trim() != "")
            {
                strSql.Append(" AND  D_DT >=TO_DATE('" + C_DD_MIN + "','yyyy-mm-dd hh24:mi:ss')");
            }
            if (C_DD_MAX.Trim() != "")
            {
                strSql.Append("  AND  D_DT >=TO_DATE('" + C_DD_MAX + "','yyyy-mm-dd hh24:mi:ss')");
            }
            return DbHelperOra.Query(strSql.ToString()).Tables[0];
        }




        /// <summary>
        /// 根据条件查询销售订单评价失败日志列表
        /// </summary>
        /// <returns>销售订单评价失败日志列表</returns>
        public DataSet GetListPJLOG()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  (SELECT A.C_STA_DESC FROM TB_STA A WHERE A.C_ID= T.C_LINE_NO ) C_LINE_NO,(SELECT A.C_STA_DESC FROM TB_STA A WHERE A.C_ID= T.C_CCM_NO )C_CCM_NO  , T.N_MACH_WGT,  T.C_SLAB_SIZE, T.N_SLAB_LENGTH, T.N_MACH_WGT_CCM, T.C_ROUTE, T.C_RH, T.C_HL, T.C_XM, t.C_STL_GRD,T.C_STD_CODE,t.C_SPEC,T.C_FREE1, T.C_FREE2, t.C_TECH_PROT, T.C_ID,t.C_ORDER_NO, A.C_TYPE,A.C_MSG,A.C_ORDER_NO,A.D_MOD_DT ");
            strSql.Append(" FROM TMO_ORDER T, TMO_ORDER_PJ_LOG A WHERE T.C_ORDER_NO=A.C_ORDER_NO  ");

            strSql.Append(" ORDER BY D_DELIVERY_DT,C_ORDER_LEV,C_LEV,N_USER_LEV,C_STL_GRD,C_STD_CODE");
            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 炼钢浇次分组信息
        /// </summary>
        /// <param name="C_CCM_NO">连铸</param>
        /// <param name="C_STL_GRD">钢种</param>
        /// <param name="C_STD_CODE">标准</param>
        /// <param name="N_GROUP">组号</param>
        /// <returns></returns>
        public DataSet GetPCorder(string C_CCM_NO, string C_STL_GRD, string C_STD_CODE, int? N_GROUP)
        {
            string sql = @"   SELECT T.钢种,
       T.标准,
       T.连铸,
       T.连铸代码,
       T.连铸主键,
       T.组号,
       T.交期,
       T.订单总量,
       CASE
         WHEN T.需排产量 > 0 THEN
          CEIL(T.需排产量 / DECODE(T.连铸代码, '5#CC', 75, '7#CC', 75, 46))
         ELSE
          0
       END 炉数,
        DECODE(T.整浇次炉数, 0, 20, T.整浇次炉数) 整浇次炉数,
       DECODE(T.整浇次炉数, 0, 20, T.整浇次炉数) * DECODE(T.连铸代码, '5#CC', 75, '7#CC', 75, 46) 整浇次重量,
 T.机时产能
  FROM V_KPCDDFX T
 WHERE 1=1    ";

            if (C_CCM_NO.Trim() != "")
            {
                sql = sql + "  AND T.连铸主键 = '" + C_CCM_NO + "' ";
            }
            if (C_STL_GRD.Trim() != "")
            {
                sql = sql + " AND A.C_STL_GRD='" + C_STL_GRD + "' ";
            }

            if (C_STD_CODE.Trim() != "")
            {
                sql = sql + " AND A.C_STD_CODE='" + C_STD_CODE + "' ";
            }
            if (N_GROUP != null)
            {
                sql = sql + " AND T.组号 = " + N_GROUP + " ";
            }


            sql = sql + "   ORDER BY T.订单总量, T.交期, T.钢种,T.标准  ";
            return DbHelperOra.Query(sql.ToString());

        }


        /// <summary>
        /// 按分组后订单查询浇次信息
        /// </summary>
        /// <returns></returns>
        public DataSet GetInfoByGroup(string C_CCM_NO)
        {
            string sql = @" SELECT A.连铸,
       A.连铸代码,
       A.连铸主键,
       A.组号,
       NVL(A.C_BY3, '白色') C_BY3,
       A.C_RH,
       A.C_DFP_HL,
       A.C_HL,
       A.C_XM,
       MIN(A.交期) 交期,
       SUM(A.订单总量) 订单总量,
       SUM(A.待产总量) 待产总量,
       SUM(A.炉数) 炉数,
       MAX(A.整浇次炉数) 整浇次炉数,
       MIN(A.机时产能) 机时产能,
       LISTAGG(A.钢种 || '~' || A.标准,
                ',
') WITHIN GROUP(ORDER BY A.组号) 牌号
  FROM (SELECT A.钢种,
               A.标准,
               A.连铸,
               A.连铸代码,
               A.连铸主键,
               A.组号,
               A.C_BY3,
               A.C_RH,
               A.C_DFP_HL,
               A.C_HL,
               A.C_XM, MIN(A.交期) 交期,
               SUM(A.订单总量) 订单总量,
               SUM((CASE
                     WHEN A.需排产量 > 0 THEN
                      CEIL(A.需排产量 / DECODE(A.连铸代码, '5#CC', 75, '7#CC', 75, 46))
                     ELSE
                      0
                   END) * DECODE(A.连铸代码, '5#CC', 75, '7#CC', 75, 46)) 待产总量,
               
               SUM(CASE
                     WHEN A.需排产量 > 0 THEN
                      CEIL(A.需排产量 / DECODE(A.连铸代码, '5#CC', 75, '7#CC', 75, 46))
                     ELSE
                      0
                   END) 炉数,
               MAX(A.整浇次炉数) 整浇次炉数,
               MIN(A.机时产能) 机时产能
          FROM V_KPCDDFX A
         WHERE 1 = 1 ";
            if (C_CCM_NO.Trim() != "")
            {
                sql = sql + " AND  A.连铸主键 = '" + C_CCM_NO + "' ";
            }

            sql = sql + @"   AND A.需排产量 > 0
         GROUP BY A.钢种,
                  A.标准,
                  A.连铸,
                  A.连铸代码,
                  A.连铸主键,
                  A.C_BY3,
                  A.C_RH,
                  A.组号,
                  A.C_DFP_HL,
                  A.C_HL,
                  A.C_XM
         ORDER BY A.组号) A
 GROUP BY A.连铸,
          A.连铸代码,
          A.连铸主键,
          A.C_BY3,
          A.C_RH,
          A.C_DFP_HL,
          A.C_HL,
          A.C_XM,
          A.组号 ";
            //          string sql = @"SELECT A.连铸,
            //     A.连铸代码,
            //     A.连铸主键,
            //     A.组号,
            //     MIN(A.交期) 交期,
            //     SUM(A.订单总量) 订单总量,
            //     SUM(A.待产总量) 待产总量,
            //     SUM(A.炉数) 炉数,
            //     MAX(A.整浇次炉数) 整浇次炉数,
            //     MIN(A.机时产能) 机时产能,
            //     LISTAGG(A.钢种 || '|' || A.标准, ',') WITHIN GROUP(ORDER BY A.组号) 牌号
            //FROM(SELECT A.C_STL_GRD 钢种,
            //             A.C_STD_CODE 标准,
            //             TB.C_STA_DESC 连铸,
            //             TB.C_STA_CODE 连铸代码,
            //             TB.C_ID 连铸主键,
            //             A.N_GROUP 组号,
            //             MIN(A.D_DELIVERY_DT) 交期,
            //             SUM(A.N_WGT - A.N_SMS_PROD_WGT - A.N_SLAB_MATCH_WGT) 订单总量,
            //             (CEIL(SUM(A.N_WGT - A.N_SMS_PROD_WGT - A.N_SLAB_MATCH_WGT) /
            //                   DECODE(TB.C_STA_CODE, '5#CC', 75, '7#CC', 75, 46)) *
            //             DECODE(TB.C_STA_CODE, '5#CC', 75, '7#CC', 75, 46)) 待产总量,

            //             CEIL(SUM(A.N_WGT - A.N_SMS_PROD_WGT - A.N_SLAB_MATCH_WGT) /
            //                  DECODE(TB.C_STA_CODE, '5#CC', 75, '7#CC', 75, 46)) 炉数,
            //             MAX(A.N_ZJCLS) 整浇次炉数,
            //             MIN(A.N_MACH_WGT_CCM) 机时产能
            //        FROM TMO_ORDER A
            //       INNER JOIN TB_STA TB
            //          ON A.C_CCM_NO = TB.C_ID
            //       WHERE A.C_SFPJ = 'Y' ";
            //          if (C_CCM_NO.Trim() != "")
            //          {
            //              sql = sql + "  AND A.C_CCM_NO='" + C_CCM_NO + "'";
            //          }

            //          sql = sql + " AND A.N_STATUS = 2 AND (N_WGT - N_SMS_PROD_WGT - N_SLAB_MATCH_WGT) > 0 GROUP BY A.N_GROUP, A.C_CCM_NO, A.C_STL_GRD, A.C_STD_CODE, TB.C_STA_DESC, TB.C_STA_CODE, TB.C_ID ORDER BY A.C_CCM_NO, A.N_GROUP, MIN(A.D_DELIVERY_DT)) A GROUP BY A.连铸, A.连铸代码, A.连铸主键, A.组号 ";


            return DbHelperOra.Query(sql.ToString());

        }

        /// <summary>
        /// 获取需要排产的订单分组信息
        /// </summary>
        /// <returns></returns>
        public DataSet Get_PC_GROUP()
        {
            string sql = " SELECT TB.C_STA_DESC 连铸, TB.C_STA_CODE 连铸代码, TB.C_ID 连铸主键, A.N_GROUP 组号, MIN(A.D_DELIVERY_DT) 交期, SUM(A.N_WGT - A.N_SMS_PROD_WGT - A.N_SLAB_MATCH_WGT) 待产总量, DECODE(NVL(MAX(A.N_ZJCLS), 0), 0, 20, MAX(A.N_ZJCLS)) 整浇次炉数,       CEIL(SUM(A.N_WGT - A.N_SMS_PROD_WGT - A.N_SLAB_MATCH_WGT) / (DECODE(TB.C_STA_CODE, '5#CC', 75, '7#CC', 75, 46) * DECODE(NVL(MAX(A.N_ZJCLS), 0), 0, 20, MAX(A.N_ZJCLS)))) 排产浇次数, (DECODE(TB.C_STA_CODE, '5#CC', 75, '7#CC', 75, 46) * DECODE(NVL(MAX(A.N_ZJCLS), 0), 0, 20, MAX(A.N_ZJCLS))) 整浇次重量, MIN(A.N_MACH_WGT_CCM) 机时产能, A.C_SL 首尾炉  FROM TMO_ORDER A INNER JOIN TB_STA TB    ON A.C_CCM_NO = TB.C_ID WHERE A.C_SFPJ = 'Y' ";

            sql = sql + " AND A.N_STATUS = 2 AND a.N_TYPE IN ('6', '8') AND (N_WGT - N_SMS_PROD_WGT - N_SLAB_MATCH_WGT) > 0";

            sql = sql + " GROUP BY A.N_GROUP, A.C_CCM_NO, A.C_STL_GRD, A.C_STD_CODE,TB.C_STA_DESC,TB.C_STA_CODE,TB.C_ID ORDER BY A.C_CCM_NO, A.N_GROUP, MIN(A.D_DELIVERY_DT) ";
            return DbHelperOra.Query(sql.ToString());

        }

        /// <summary>
        /// 获取分组的订单详细信息
        /// </summary>
        /// <returns></returns>
        public Mod_TMO_ORDER Get_PC_ORDER(string str_GROUP)
        {
            string sql = "SELECT *  FROM(SELECT T.* FROM TMO_ORDER T WHERE T.N_GROUP = '" + str_GROUP + "' and t.c_by5 is null ORDER BY T.C_SL, T.D_NEED_DT DESC) WHERE ROWNUM = 1 ";

            Mod_TMO_ORDER model = new Mod_TMO_ORDER();
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
        /// 按产线统计
        /// </summary>
        /// <returns></returns>
        public DataSet Get_List_ACX(string CX)
        {
            string sql = " SELECT (SELECT A.C_STA_DESC FROM TB_STA A WHERE A.C_ID = T.C_LINE_NO) C_LINE_NO, SUM(N_WGT - N_ROLL_PROD_WGT - N_LINE_MATCH_WGT) N_PC_WGT, SUM(N_WGT) ORDER_WGT, SUM(T.N_LINE_MATCH_WGT) MATCH_WGT FROM TMO_ORDER T WHERE C_SFPJ = 'Y' AND T.N_TYPE IN ('6', '8') AND N_STATUS = 2 AND N_EXEC_STATUS = 0 AND NVL(N_ROLL_PROD_WGT, 0) = 0 AND NVL(N_SMS_PROD_WGT, 0) = 0 GROUP BY C_LINE_NO ORDER BY (SELECT A.C_STA_DESC FROM TB_STA A WHERE A.C_ID = T.C_LINE_NO) ";
            return DbHelperOra.Query(sql.ToString());
        }

        /// <summary>
        /// 按产线规格统计
        /// </summary>
        /// <returns></returns>
        public DataSet Get_List_ACXGG(string CX)
        {
            string sql = " SELECT (SELECT A.C_STA_DESC FROM TB_STA A WHERE A.C_ID = T.C_LINE_NO) C_LINE_NO, T.C_SPEC, SUM(N_WGT - N_ROLL_PROD_WGT - N_LINE_MATCH_WGT) N_PC_WGT, SUM(N_WGT) ORDER_WGT, SUM(T.N_LINE_MATCH_WGT) MATCH_WGT FROM TMO_ORDER T WHERE C_SFPJ = 'Y' AND N_STATUS = 2 AND N_EXEC_STATUS = 0 AND NVL(N_ROLL_PROD_WGT, 0) = 0 AND T.N_TYPE IN ('6', '8') AND NVL(N_SMS_PROD_WGT, 0) = 0 GROUP BY C_LINE_NO, T.C_SPEC ORDER BY (SELECT A.C_STA_DESC FROM TB_STA A WHERE A.C_ID = T.C_LINE_NO), to_number(REPLACE( T.C_SPEC,'φ','')) ";
            return DbHelperOra.Query(sql.ToString());
        }


        /// <summary>
        /// 按连铸统计
        /// </summary>
        /// <returns></returns>
        public DataSet Get_List_ALZ(string LZ)
        {
            string sql = " SELECT (SELECT A.C_STA_DESC FROM TB_STA A WHERE A.C_ID = T.C_CCM_NO) C_CCM_NO, SUM(N_WGT - N_SMS_PROD_WGT - N_SLAB_MATCH_WGT) N_PC_WGT, SUM(N_WGT) ORDER_WGT, SUM(T.N_SLAB_MATCH_WGT) MATCH_WGT FROM TMO_ORDER T WHERE C_SFPJ = 'Y' AND T.N_TYPE IN ('6', '8') AND N_STATUS = 2 AND N_EXEC_STATUS = 0 AND NVL(N_ROLL_PROD_WGT, 0) = 0 AND NVL(N_SMS_PROD_WGT, 0) = 0 GROUP BY C_CCM_NO ORDER BY (SELECT A.C_STA_DESC FROM TB_STA A WHERE A.C_ID = T.C_CCM_NO) ";
            return DbHelperOra.Query(sql.ToString());
        }

        /// <summary>
        /// 按连铸钢种统计
        /// </summary>
        /// <returns></returns>
        public DataSet Get_List_ALZGZ(string LZ)
        {
            string sql = " SELECT (SELECT A.C_STA_DESC FROM TB_STA A WHERE A.C_ID = T.C_CCM_NO) C_CCM_NO, T.C_STL_GRD, T.C_STD_CODE, SUM(N_WGT - N_SMS_PROD_WGT - N_SLAB_MATCH_WGT) N_PC_WGT, SUM(N_WGT) ORDER_WGT, SUM(T.N_SLAB_MATCH_WGT) MATCH_WGT FROM TMO_ORDER T WHERE C_SFPJ = 'Y' AND N_STATUS = 2 AND N_EXEC_STATUS = 0 AND NVL(N_ROLL_PROD_WGT, 0) = 0 AND NVL(N_SMS_PROD_WGT, 0) = 0 GROUP BY C_CCM_NO, T.C_STL_GRD, T.C_STD_CODE ORDER BY (SELECT A.C_STA_DESC FROM TB_STA A WHERE A.C_ID = T.C_CCM_NO) ";
            return DbHelperOra.Query(sql.ToString());
        }

        /// <summary>
        /// 根据临时表中组号获取整浇次炉数,没有维护返回0
        /// </summary>
        /// <param name="N_GROUP">组号</param>
        /// <returns>炉数</returns>
        public int GetZJCLS(int N_GROUP)
        {
            string sql = @"SELECT MAX(NVL(N_ZJCLS, 0)) N_ZJCLS
  FROM TMO_ORDER T
 WHERE C_SFPJ = 'Y'
   AND N_STATUS = 2 AND T.N_TYPE IN ('6', '8')
   AND(N_WGT - N_SMS_PROD_WGT - N_SLAB_MATCH_WGT) > 0
   AND T.N_GROUP = " + N_GROUP;
            DataTable dt = DbHelperOra.Query(sql.ToString()).Tables[0];
            if (dt.Rows.Count > 0)
            {
                return Convert.ToInt32(dt.Rows[0]["N_ZJCLS"].ToString());
            }
            else
            {
                return 0;
            }
        }

        /// <summary>
        /// 获取待排炼钢计划订单
        /// </summary>
        /// <param name="strGZ">钢种</param>
        /// <param name="strBZ">执行标准</param>
        /// <param name="strCCM">连铸主键</param>
        /// <returns></returns>
        public DataTable GetLGPCOrder(string strGZ, string strBZ, string strCCM)
        {
            string sql = @"  SELECT C_ID,
       C_ORDER_NO,
       C_CON_NO,
       C_CON_NAME,
       C_AREA,
       C_CUST_NO,
        (N_WGT-nvl(N_PROD_WGT,0) - N_ROLL_PROD_WGT - N_LINE_MATCH_WGT) N_R_WGT,
       (N_WGT-nvl(N_PROD_WGT,0) - N_SMS_PROD_WGT - N_SLAB_MATCH_WGT) N_R_WGT_SLAB,
       C_CUST_NAME,
       C_SALE_CHANNEL,
       C_CURRENCYTYPEID,
       C_RECEIPTAREAID,
       C_RECEIVEADDRESS,
       C_RECEIPTCORPID,
       C_PROD_NAME,
       C_PROD_KIND,
       C_INVBASDOCID,
       C_INVENTORYID,
       C_MAT_CODE,
       C_MAT_NAME,
       C_STL_GRD,
       C_SPEC,
       C_TECH_PROT,
       C_FREE1,
       C_FREE2,
       C_PACK,
       C_STD_CODE,
       C_DESIGN_NO,
       C_STDID,
       C_DESIGNID,
       C_VDEF1,
       C_PRO_USE,
       C_CUST_SQ,
       C_FUNITID,
       C_UNITID,
       N_HSL,
       N_FNUM,
       N_WGT,
       N_PROFIT,
       N_COST,
       N_TAXRATE,
       N_ORIGINALCURPRICE,
       N_ORIGINALCURTAXPRICE,
       N_ORIGINALCURTAXMNY,
       N_ORIGINALCURMNY,
       N_ORIGINALCURSUMMNY,
       D_NEED_DT,
       D_DELIVERY_DT,
       D_DT,
       N_STATUS,
       N_TYPE,
       N_FLAG,
       N_EXEC_STATUS,
       N_USER_LEV,
       C_LEV,
       C_ORDER_LEV,
       C_REMARK,
       C_EMP_ID,
       C_EMP_NAME,
       D_MOD_DT,
       N_SLAB_MATCH_WGT,
       N_LINE_MATCH_WGT,
       N_PROD_WGT,
       N_WARE_WGT,
       N_WARE_OUT_WGT,
       N_MACH_WGT,
       C_ISSUE_EMP_ID,
       C_PRD_EMP_ID,
       C_DESIGN_PROG,
       N_SMS_PROD_WGT,
       C_SMS_PROD_EMP_ID,
       D_SMS_PROD_DT,
       N_ROLL_PROD_WGT,
       C_ROLL_PROD_EMP_ID,
       D_STL_ROL_DT,
       (SELECT A.C_STA_DESC FROM TB_STA A WHERE A.C_ID = T.C_LINE_NO) C_LINE_NO,
       (SELECT A.C_STA_DESC FROM TB_STA A WHERE A.C_ID = T.C_CCM_NO) C_CCM_NO,
       N_ISSUE_WGT,
       C_RH,
       C_LF,
       C_KP,
       N_HL_TIME,
       C_HL,
       N_DFP_HL_TIME,
       C_DFP_HL,
       C_XM,
       C_ROUTE,
       C_MATRL_CODE_SLAB,
       C_MATRL_NAME_SLAB,
       C_SLAB_SIZE,
       N_SLAB_LENGTH,
       N_SLAB_PW,
       C_MATRL_CODE_KP,
       C_MATRL_NAME_KP,
       C_KP_SIZE,
       N_KP_LENGTH,
       N_KP_PW,
       N_GROUP,
       N_SORT,
       C_XC,
       C_SL,
       C_WL,
       C_SFPJ,
       C_TRANSMODE,
       N_MACH_WGT_CCM,
       C_XGID,
       N_ZJCLS,
       C_BY1,
       C_BY2,
       C_BY3,
       C_BY4,
       C_BY5,C_NC_ID,C_LGJH,C_ZLDJ_ID,C_ZL_ID,C_LF_ID,C_RH_ID,N_SLAB_WIDTH,N_SLAB_THICK,N_DIAMETER
  FROM TMO_ORDER T
 WHERE  T.C_SFPJ = 'Y' AND T.N_TYPE IN ('6', '8')
           AND T.N_STATUS = 2
           AND (N_WGT-nvl(N_PROD_WGT,0) - N_SMS_PROD_WGT- N_SLAB_MATCH_WGT) > 0 ";

            if (strGZ.Trim() != "")
            {
                sql = sql + " AND C_STL_GRD = '" + strGZ + "'";
            }
            if (strBZ.Trim() != "")
            {
                sql = sql + " AND C_STD_CODE = '" + strBZ + "'";
            }
            if (strCCM.Trim() != "")
            {
                sql = sql + " AND C_CCM_NO = '" + strCCM + "'";
            }
            sql = sql + " ORDER BY D_DELIVERY_DT, C_ORDER_LEV,  C_LEV,   N_USER_LEV, C_STL_GRD,  C_STD_CODE ,C_ORDER_NO";//订单系统排序
            return DbHelperOra.Query(sql.ToString()).Tables[0];
        }

        /// <summary>
        /// 批量更新订单库存匹配量
        /// </summary>
        /// <param name="strCCM">连铸机信息</param>
        /// <returns>执行行数</returns>
        public int UpdateOrderSmsMatchWgt(string strCCM)
        {
            string sql = @"UPDATE TMO_ORDER T
   SET T.N_SLAB_MATCH_WGT =
       (N_WGT -nvl(N_PROD_WGT,0)- N_SMS_PROD_WGT) WHERE T.C_SFPJ = 'Y' AND T.N_STATUS = 2 AND T.N_TYPE IN ('6', '8') AND (N_WGT -nvl(N_PROD_WGT,0) - N_SMS_PROD_WGT - N_SLAB_MATCH_WGT) > 0 ";
            if (strCCM.Trim() != "")
            {
                sql = sql + " AND C_CCM_NO = '" + strCCM + "'";
            }
            return DbHelperOra.ExecuteSql(sql);

        }

        /// <summary>
        /// 得到订单主键
        /// </summary>
        /// <param name="N_GROUP">订单分组号</param>
        /// <param name="C_STL_GRD">钢种</param>
        /// <param name="C_STD_CODE">执行标准</param>
        /// <returns>订单表主键</returns>
        public string GetOrderID(string N_GROUP, string C_STL_GRD, string C_STD_CODE)
        {
            string sql = @"SELECT MAX(T.C_ID) C_ID
                           FROM TMO_ORDER T
                           WHERE T.N_GROUP = " + N_GROUP;
            sql = sql + "  AND T.C_STL_GRD = '" + C_STL_GRD + "'";
            sql = sql + "  AND T.C_STD_CODE = '" + C_STD_CODE + "'";
            return DbHelperOra.Query(sql.ToString()).Tables[0].Rows[0]["C_ID"].ToString();
        }


        /// <summary>
        /// 获取待排轧钢计划订单
        /// </summary>
        /// <param name="strGZ">钢种</param>
        /// <param name="strBZ">执行标准</param>
        /// <param name="C_LINE_NO">轧线主键</param>
        /// <param name="kpc">系统有钢坯可排产 Y 有库存钢坯或已排连铸计划的订单 排产量=（N_SMS_PROD_WGT + N_SLAB_MATCH_WGT）</param>
        /// <returns></returns>
        public DataTable GetZGPCOrder(string strGZ, string strBZ, string C_LINE_NO, string kpc)
        {
            string sql = @"  SELECT C_ID,
       C_ORDER_NO,
       C_CON_NO,
       C_CON_NAME,
       C_AREA,
       C_CUST_NO,
       (N_WGT-nvl(N_PROD_WGT,0) - N_ROLL_PROD_WGT - N_LINE_MATCH_WGT) N_R_WGT,
       (N_WGT-nvl(N_PROD_WGT,0) - N_SMS_PROD_WGT - N_SLAB_MATCH_WGT) N_R_WGT_SLAB,
       (N_SMS_PROD_WGT + N_SLAB_MATCH_WGT) N_R_KP_WGT,
       C_CUST_NAME,
       C_SALE_CHANNEL,
       C_CURRENCYTYPEID,
       C_RECEIPTAREAID,
       C_RECEIVEADDRESS,
       C_RECEIPTCORPID,
       C_PROD_NAME,
       C_PROD_KIND,
       C_INVBASDOCID,
       C_INVENTORYID,
       C_MAT_CODE,
       C_MAT_NAME,
       C_STL_GRD,
       C_SPEC,
       C_TECH_PROT,
       C_FREE1,
       C_FREE2,
       C_PACK,
       C_STD_CODE,
       C_DESIGN_NO,
       C_STDID,
       C_DESIGNID,
       C_VDEF1,
       C_PRO_USE,
       C_CUST_SQ,
       C_FUNITID,
       C_UNITID,
       N_HSL,
       N_FNUM,
       N_WGT,
       N_PROFIT,
       N_COST,
       N_TAXRATE,
       N_ORIGINALCURPRICE,
       N_ORIGINALCURTAXPRICE,
       N_ORIGINALCURTAXMNY,
       N_ORIGINALCURMNY,
       N_ORIGINALCURSUMMNY,
       D_NEED_DT,
       D_DELIVERY_DT,
       D_DT,
       N_STATUS,
       N_TYPE,
       N_FLAG,
       N_EXEC_STATUS,
       N_USER_LEV,
       C_LEV,
       C_ORDER_LEV,
       C_REMARK,
       C_EMP_ID,
       C_EMP_NAME,
       D_MOD_DT,
       N_SLAB_MATCH_WGT,
       N_LINE_MATCH_WGT,
       N_PROD_WGT,
       N_WARE_WGT,
       N_WARE_OUT_WGT,
       N_MACH_WGT,
       C_ISSUE_EMP_ID,
       C_PRD_EMP_ID,
       C_DESIGN_PROG,
       N_SMS_PROD_WGT,
       C_SMS_PROD_EMP_ID,
       D_SMS_PROD_DT,
       N_ROLL_PROD_WGT,
       C_ROLL_PROD_EMP_ID,
       D_STL_ROL_DT,
       C_LINE_NO C_STA_ID,
       (SELECT A.C_STA_DESC FROM TB_STA A WHERE A.C_ID = T.C_LINE_NO) C_LINE_NO,
       (SELECT A.C_STA_DESC FROM TB_STA A WHERE A.C_ID = T.C_CCM_NO) C_CCM_NO,
       N_ISSUE_WGT,
       C_RH,
       C_LF,
       C_KP,
       N_HL_TIME,
       C_HL,
       N_DFP_HL_TIME,
       C_DFP_HL,
       C_XM,
       C_ROUTE,
       C_MATRL_CODE_SLAB,
       C_MATRL_NAME_SLAB,
       C_SLAB_SIZE,
       N_SLAB_LENGTH,
       N_SLAB_PW,
       C_MATRL_CODE_KP,
       C_MATRL_NAME_KP,
       C_KP_SIZE,
       N_KP_LENGTH,
       N_KP_PW,
       N_GROUP,
       N_SORT,
       C_XC,
       C_SL,
       C_WL,
       C_SFPJ,
       C_TRANSMODE,
       N_MACH_WGT_CCM,
       C_XGID,
       N_ZJCLS,
       C_BY1,
       C_BY2,
       C_BY3,
       C_BY4,
       C_BY5,C_NC_ID,C_LGJH,C_ZLDJ_ID,C_ZL_ID,C_LF_ID,C_RH_ID,N_SLAB_WIDTH,N_SLAB_THICK,N_DIAMETER
  FROM TMO_ORDER T
 WHERE C_SFPJ = 'Y'
   AND N_STATUS = 2 AND T.N_TYPE IN ('6', '8')
   AND N_EXEC_STATUS >= 0 AND N_EXEC_STATUS IN (0,2,5,6) ";


            if (strGZ.Trim() != "")
            {
                sql = sql + " AND C_STL_GRD = '" + strGZ + "'";
            }
            if (strBZ.Trim() != "")
            {
                sql = sql + " AND C_STD_CODE = '" + strBZ + "'";
            }
            if (kpc.Trim() == "Y")
            {
                sql = sql + " AND  (N_WGT-nvl(N_PROD_WGT,0) - N_ROLL_PROD_WGT - N_LINE_MATCH_WGT) > 0";
                sql = sql + " AND (N_SMS_PROD_WGT + N_SLAB_MATCH_WGT)>0 ";
            }
            else if (kpc.Trim() == "YP")
            {
                sql = sql + " AND  (N_WGT-nvl(N_PROD_WGT,0) - N_ROLL_PROD_WGT - N_LINE_MATCH_WGT)<= 0";
            }
            else
            {
                sql = sql + " AND  (N_WGT-nvl(N_PROD_WGT,0) - N_ROLL_PROD_WGT - N_LINE_MATCH_WGT) > 0";
            }
            if (C_LINE_NO.Trim() != "")
            {
                sql = sql + " AND C_LINE_NO = '" + C_LINE_NO + "'";
            }
            sql = sql + " ORDER BY D_DELIVERY_DT, C_ORDER_LEV,  C_LEV,   N_USER_LEV, C_STL_GRD,  C_STD_CODE ,C_ORDER_NO";//订单系统排序
            return DbHelperOra.Query(sql.ToString()).Tables[0];
        }


        /// <summary>
        /// 获取待排炼钢计划订单
        /// </summary>
        /// <param name="strGZ">钢种</param>
        /// <param name="strBZ">执行标准</param>
        /// <param name="C_LINE_NO">轧线主键</param>
        /// <param name="SFPC">系统有钢坯可排产 Y (N_WGT - N_SMS_PROD_WGT - N_SLAB_MATCH_WGT)>0</param>
        /// <returns></returns>
        public DataTable GetLGPCOrder(string strGZ, string strBZ, string C_CCM_NO, string SFPC)
        {
            string sql = @"  SELECT C_ID,
       C_ORDER_NO,
       C_CON_NO,
       C_CON_NAME,
       C_AREA,
       C_CUST_NO,
       (N_WGT-nvl(N_PROD_WGT,0) - N_ROLL_PROD_WGT - N_LINE_MATCH_WGT) N_R_WGT,
       (N_WGT -nvl(N_PROD_WGT,0)- N_SMS_PROD_WGT - N_SLAB_MATCH_WGT) N_R_WGT_SLAB,
       C_CUST_NAME,
       C_SALE_CHANNEL,
       C_CURRENCYTYPEID,
       C_RECEIPTAREAID,
       C_RECEIVEADDRESS,
       C_RECEIPTCORPID,
       C_PROD_NAME,
       C_PROD_KIND,
       C_INVBASDOCID,
       C_INVENTORYID,
       C_MAT_CODE,
       C_MAT_NAME,
       C_STL_GRD,
       C_SPEC,
       C_TECH_PROT,
       C_FREE1,
       C_FREE2,
       C_PACK,
       C_STD_CODE,
       C_DESIGN_NO,
       C_STDID,
       C_DESIGNID,
       C_VDEF1,
       C_PRO_USE,
       C_CUST_SQ,
       C_FUNITID,
       C_UNITID,
       N_HSL,
       N_FNUM,
       N_WGT,
       N_PROFIT,
       N_COST,
       N_TAXRATE,
       N_ORIGINALCURPRICE,
       N_ORIGINALCURTAXPRICE,
       N_ORIGINALCURTAXMNY,
       N_ORIGINALCURMNY,
       N_ORIGINALCURSUMMNY,
       D_NEED_DT,
       D_DELIVERY_DT,
       D_DT,
       N_STATUS,
       N_TYPE,
       N_FLAG,
       N_EXEC_STATUS,
       N_USER_LEV,
       C_LEV,
       C_ORDER_LEV,
       C_REMARK,
       C_EMP_ID,
       C_EMP_NAME,
       D_MOD_DT,
       N_SLAB_MATCH_WGT,
       N_LINE_MATCH_WGT,
       N_PROD_WGT,
       N_WARE_WGT,
       N_WARE_OUT_WGT,
       N_MACH_WGT,
       C_ISSUE_EMP_ID,
       C_PRD_EMP_ID,
       C_DESIGN_PROG,
       N_SMS_PROD_WGT,
       C_SMS_PROD_EMP_ID,
       D_SMS_PROD_DT,
       N_ROLL_PROD_WGT,
       C_ROLL_PROD_EMP_ID,
       D_STL_ROL_DT,
       C_LINE_NO C_STA_ID,
       (SELECT A.C_STA_DESC FROM TB_STA A WHERE A.C_ID = T.C_LINE_NO) C_LINE_NO,
       (SELECT A.C_STA_DESC FROM TB_STA A WHERE A.C_ID = T.C_CCM_NO) C_CCM_NO,
       N_ISSUE_WGT,
       C_RH,
       C_LF,
       C_KP,
       N_HL_TIME,
       C_HL,
       N_DFP_HL_TIME,
       C_DFP_HL,
       C_XM,
       C_ROUTE,
       C_MATRL_CODE_SLAB,
       C_MATRL_NAME_SLAB,
       C_SLAB_SIZE,
       N_SLAB_LENGTH,
       N_SLAB_PW,
       C_MATRL_CODE_KP,
       C_MATRL_NAME_KP,
       C_KP_SIZE,
       N_KP_LENGTH,
       N_KP_PW,
       N_GROUP,
       N_SORT,
       C_XC,
       C_SL,
       C_WL,
       C_SFPJ,
       C_TRANSMODE,
       N_MACH_WGT_CCM,
       C_XGID,
       N_ZJCLS,
       C_BY1,
       C_BY2,
       C_BY3,
       C_BY4,
       C_BY5,C_NC_ID,C_LGJH,C_ZLDJ_ID,C_ZL_ID,C_LF_ID,C_RH_ID,N_SLAB_WIDTH,N_SLAB_THICK,N_DIAMETER
  FROM TMO_ORDER T
 WHERE C_SFPJ = 'Y'
   AND N_STATUS = 2 AND T.N_TYPE IN ('6', '8')
   AND N_EXEC_STATUS >= 0  AND N_EXEC_STATUS  IN (0,2,5,6) ";
            if (SFPC.Trim() == "Y")
            {
                sql = sql + " AND (N_WGT-nvl(N_PROD_WGT,0) - N_SMS_PROD_WGT - N_SLAB_MATCH_WGT) > 0";
            }
            if (SFPC.Trim() == "N")
            {
                sql = sql + " AND (N_WGT-nvl(N_PROD_WGT,0) - N_SMS_PROD_WGT - N_SLAB_MATCH_WGT)<= 0";
            }

            if (strGZ.Trim() != "")
            {
                sql = sql + " AND C_STL_GRD = '" + strGZ + "'";
            }
            if (strBZ.Trim() != "")
            {
                sql = sql + " AND C_STD_CODE = '" + strBZ + "'";
            }
            if (C_CCM_NO.Trim() != "")
            {
                sql = sql + " AND C_CCM_NO = '" + C_CCM_NO + "'";
            }
            sql = sql + " ORDER BY D_DELIVERY_DT, C_ORDER_LEV,  C_LEV,   N_USER_LEV, C_STL_GRD,  C_STD_CODE ,C_ORDER_NO";//订单系统排序
            return DbHelperOra.Query(sql.ToString()).Tables[0];
        }

        /// <summary>
        /// 根据订单主键返回炼钢排产的重量
        /// </summary>
        /// <param name="C_ORDER_ID">订单号</param>
        /// <param name="N_WGT">返回量</param>
        /// <returns></returns>
        public int BackLGWGT(string C_ORDER_ID, Decimal N_WGT)
        {
            string sql = "UPDATE TMO_ORDER T SET T.N_SMS_PROD_WGT = T.N_SMS_PROD_WGT - " + N_WGT + "   WHERE T.C_ID = '" + C_ORDER_ID + "' ";

            return DbHelperOra.ExecuteSql(sql);


        }


        /// <summary>
        /// 根据订单主键返回轧钢排产的重量
        /// </summary>
        /// <param name="C_ORDER_ID">订单号</param>
        /// <param name="N_WGT">返回量</param>
        /// <returns></returns>
        public int BackZGWGT(string C_ORDER_ID, Decimal N_WGT)
        {
            string sql = "UPDATE TMO_ORDER T SET T.N_ROLL_PROD_WGT = T.N_ROLL_PROD_WGT - " + N_WGT + "   WHERE T.C_ID = '" + C_ORDER_ID + "' ";

            return DbHelperOra.ExecuteSql(sql);


        }


        /// <summary>
        /// 根据条件查询销售订单信息
        /// </summary>
        /// <param name="C_SFPJ">是否已经评价</param>
        /// <param name="N_STATUS">订单状态</param>
        /// <param name="N_EXEC_STATUS">订单执行状态2人工确认完成</param>
        /// <param name="C_STL_GRD">钢种</param>
        /// <param name="C_STD_CODE">执行标准</param>
        /// <param name="D_SPEC_MIN">规格最小</param>
        /// <param name="D_SPEC_MAX">规格最大</param>
        /// <param name="C_REMARK">备注</param>
        ///  <param name="C_JQ_MIN">交货日期最小值</param>
        ///  <param name="C_JQ_MAX">交货日期最大值</param>
        /// <returns>销售订单列表</returns>
        public DataSet GetImporyOrder(string C_SFPJ, int? N_STATUS, int? N_EXEC_STATUS, string C_STL_GRD, string C_STD_CODE, double? D_SPEC_MIN, double? D_SPEC_MAX, string C_REMARK, string C_JQ_MIN, string C_JQ_MAX)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_ORDER_NO,C_CON_NO,C_CON_NAME,C_AREA,C_CUST_NO,(N_WGT-N_ROLL_PROD_WGT-N_LINE_MATCH_WGT) N_R_WGT,ROUND( NVL(N_PROD_WGT,0)/N_WGT,2) WCL,C_CUST_NAME,C_SALE_CHANNEL,C_CURRENCYTYPEID,C_RECEIPTAREAID,C_RECEIVEADDRESS,C_RECEIPTCORPID,C_PROD_NAME,C_PROD_KIND,C_INVBASDOCID,C_INVENTORYID,C_MAT_CODE,C_MAT_NAME,C_STL_GRD,C_SPEC,C_TECH_PROT,C_FREE1,C_FREE2,C_PACK,C_STD_CODE,C_DESIGN_NO,C_STDID,C_DESIGNID,C_VDEF1,C_PRO_USE,C_CUST_SQ,C_FUNITID,C_UNITID,N_HSL,N_FNUM,N_WGT,N_PROFIT,N_COST,N_TAXRATE,N_ORIGINALCURPRICE,N_ORIGINALCURTAXPRICE,N_ORIGINALCURTAXMNY,N_ORIGINALCURMNY,N_ORIGINALCURSUMMNY,D_NEED_DT,D_DELIVERY_DT,D_DT,N_STATUS,    DECODE(N_TYPE,8,'线材',6,'钢坯','') N_TYPE,N_FLAG,N_EXEC_STATUS,N_USER_LEV,C_LEV,C_ORDER_LEV,C_REMARK,C_EMP_ID,C_EMP_NAME,D_MOD_DT,N_SLAB_MATCH_WGT,N_LINE_MATCH_WGT,N_PROD_WGT,N_WARE_WGT,N_WARE_OUT_WGT,N_MACH_WGT,C_ISSUE_EMP_ID,C_PRD_EMP_ID,C_DESIGN_PROG,N_SMS_PROD_WGT,C_SMS_PROD_EMP_ID,D_SMS_PROD_DT,N_ROLL_PROD_WGT,C_ROLL_PROD_EMP_ID,D_STL_ROL_DT,(SELECT A.C_STA_DESC FROM TB_STA A WHERE A.C_ID= T.C_LINE_NO ) C_LINE_NO,(SELECT A.C_STA_DESC FROM TB_STA A WHERE A.C_ID= T.C_CCM_NO )C_CCM_NO,N_ISSUE_WGT,C_RH,C_LF,C_KP,N_HL_TIME,C_HL,N_DFP_HL_TIME,C_DFP_HL,C_XM,C_ROUTE,C_MATRL_CODE_SLAB,C_MATRL_NAME_SLAB,C_SLAB_SIZE,N_SLAB_LENGTH,N_SLAB_PW,C_MATRL_CODE_KP,C_MATRL_NAME_KP,C_KP_SIZE,N_KP_LENGTH,N_KP_PW,N_GROUP,N_SORT,C_XC,C_SL,C_WL,C_SFPJ,C_TRANSMODE,N_MACH_WGT_CCM,C_XGID,N_ZJCLS,C_BY1,C_BY2,C_BY3,C_BY4,C_BY5,C_NC_ID,C_LGJH,C_ZLDJ_ID,C_ZL_ID,C_LF_ID,C_RH_ID,N_SLAB_WIDTH,N_SLAB_THICK,N_DIAMETER ");
            strSql.Append(" FROM TMO_ORDER T WHERE 1=1 AND T.N_TYPE IN ('6', '8') ");
            if (C_SFPJ.Trim() != "")
            {
                strSql.Append(" AND   C_SFPJ ='" + C_SFPJ + "'");
            }
            if (N_STATUS != null)
            {
                strSql.Append(" AND   N_STATUS =" + N_STATUS);
            }
            if (N_EXEC_STATUS != null)
            {
                strSql.Append(" AND   N_EXEC_STATUS =" + N_EXEC_STATUS);
            }
            else
            {
                strSql.Append(" AND   N_EXEC_STATUS>=0 ");
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

            if (C_JQ_MIN.Trim() != "")
            {
                strSql.Append(" AND  D_DELIVERY_DT >=TO_DATE('" + C_JQ_MIN + "','yyyy-mm-dd hh24:mi:ss')");
            }
            if (C_JQ_MAX.Trim() != "")
            {
                strSql.Append(" AND D_DELIVERY_DT >=TO_DATE('" + C_JQ_MAX + "','yyyy-mm-dd hh24:mi:ss')");
            }
            strSql.Append(" ORDER BY D_DELIVERY_DT,C_ORDER_LEV,C_LEV,N_USER_LEV,C_STL_GRD,C_STD_CODE");
            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 按规格获取产线代码
        /// </summary>
        /// <param name="C_SPEC">规格</param>
        /// <returns>产线代码</returns>
        public string GetLine(string C_SPEC)
        {
            string strSql = "SELECT MAX(T.C_LINE_NO)C_LINE_NO FROM TMO_ORDER T WHERE T.C_SFPJ = 'Y' AND T.N_TYPE IN ('6', '8') AND T.N_ROLL_PROD_WGT = 0 AND T.C_SPEC = '" + C_SPEC + "'";
            return DbHelperOra.Query(strSql.ToString()).Tables[0].Rows[0]["C_LINE_NO"].ToString();
        }
        /// <summary>
        /// 清除炼钢待排产订单分组号
        /// </summary>
        /// <returns>执行结果</returns>
        public bool ClearGroupNo()
        {
            string sql = @"UPDATE TMO_ORDER T
   SET T.N_GROUP = NULL
 WHERE T.N_STATUS = 2 AND T.N_TYPE IN ('6', '8') AND N_EXEC_STATUS  IN (0,2,5,6)
   AND(T.N_WGT - T.N_SMS_PROD_WGT - T.N_SLAB_MATCH_WGT) > 0";
            return DbHelperOra.Exists(sql);

        }
        /// <summary>
        ///查询所有炼钢待排产的订单
        /// </summary>
        /// <returns></returns>
        public DataTable GetLGWPOrder()
        {
            string sql = "select t.* from tmo_order t  where t.N_STATUS = 2 AND T.N_TYPE IN ('6', '8') and (T.N_WGT - T.N_SMS_PROD_WGT - T.N_SLAB_MATCH_WGT) > 0 ";
            return DbHelperOra.Query(sql).Tables[0];

        }


        /// <summary>
        /// 可排产订单分析
        /// </summary>
        /// <returns></returns>
        public DataTable KPC_DD_FX(string C_CCM_NO)
        {
            string sql = @"SELECT T.连铸,
       T.连铸代码,
       T.连铸主键,
       T.组号,
       T.交期,
       T.订单总量,
       T.轧钢剩余量,
       T.钢坯未完成量,
       T.现有钢坯库存量,
       T.需排产量,
       (CASE
         WHEN T.需排产量 > 0 THEN
          CEIL(T.需排产量 / DECODE(T.连铸代码, '5#CC', 75, '7#CC', 75, 46))
         ELSE
          0
       END) * DECODE(T.连铸代码, '5#CC', 75, '7#CC', 75, 46) 钢坯待产量,
       CASE
         WHEN T.需排产量 > 0 THEN
          CEIL(T.需排产量 / DECODE(T.连铸代码, '5#CC', 75, '7#CC', 75, 46))
         ELSE
          0
       END 需排炉数,
       T.整浇次炉数,
       T.机时产能,
       T.钢种,
       T.标准
  FROM V_KPCDDFX T  WHERE 1=1 AND  T.订单总量 >0 ";
            if (C_CCM_NO.Trim().Length > 0)
            {
                sql = sql + " AND  t.连铸主键='" + C_CCM_NO + "' ";
            }
            sql = sql + "  ORDER BY t.连铸 ,t.组号";
            return DbHelperOra.Query(sql).Tables[0];
        }


        /// <summary>
        /// 获取待排轧钢计划订单
        /// </summary>
        /// <param name="C_CCM_NO">连铸主键</param>
        /// <returns></returns>
        public DataTable GetZGPCOrder(string C_CCM_NO)
        {
            string sql = @"  SELECT C_ID,
       C_ORDER_NO,
       C_CON_NO,
       C_CON_NAME,
       C_AREA,
       C_CUST_NO,
       (N_WGT-nvl(N_PROD_WGT,0) - N_ROLL_PROD_WGT - N_LINE_MATCH_WGT) N_R_WGT,
       (N_WGT-nvl(N_PROD_WGT,0) - N_SMS_PROD_WGT - N_SLAB_MATCH_WGT) N_R_WGT_SLAB,
       (N_SMS_PROD_WGT + N_SLAB_MATCH_WGT) N_R_KP_WGT,
       C_CUST_NAME,
       C_SALE_CHANNEL,
       C_CURRENCYTYPEID,
       C_RECEIPTAREAID,
       C_RECEIVEADDRESS,
       C_RECEIPTCORPID,
       C_PROD_NAME,
       C_PROD_KIND,
       C_INVBASDOCID,
       C_INVENTORYID,
       C_MAT_CODE,
       C_MAT_NAME,
       C_STL_GRD,
       C_SPEC,
       C_TECH_PROT,
       C_FREE1,
       C_FREE2,
       C_PACK,
       C_STD_CODE,
       C_DESIGN_NO,
       C_STDID,
       C_DESIGNID,
       C_VDEF1,
       C_PRO_USE,
       C_CUST_SQ,
       C_FUNITID,
       C_UNITID,
       N_HSL,
       N_FNUM,
       N_WGT,
       N_PROFIT,
       N_COST,
       N_TAXRATE,
       N_ORIGINALCURPRICE,
       N_ORIGINALCURTAXPRICE,
       N_ORIGINALCURTAXMNY,
       N_ORIGINALCURMNY,
       N_ORIGINALCURSUMMNY,
       D_NEED_DT,
       D_DELIVERY_DT,
       D_DT,
       N_STATUS,
       N_TYPE,
       N_FLAG,
       N_EXEC_STATUS,
       N_USER_LEV,
       C_LEV,
       C_ORDER_LEV,
       C_REMARK,
       C_EMP_ID,
       C_EMP_NAME,
       D_MOD_DT,
       N_SLAB_MATCH_WGT,
       N_LINE_MATCH_WGT,
       N_PROD_WGT,
       N_WARE_WGT,
       N_WARE_OUT_WGT,
       N_MACH_WGT,
       C_ISSUE_EMP_ID,
       C_PRD_EMP_ID,
       C_DESIGN_PROG,
       N_SMS_PROD_WGT,
       C_SMS_PROD_EMP_ID,
       D_SMS_PROD_DT,
       N_ROLL_PROD_WGT,
       C_ROLL_PROD_EMP_ID,
       D_STL_ROL_DT,
       C_LINE_NO C_STA_ID,
       (SELECT A.C_STA_DESC FROM TB_STA A WHERE A.C_ID = T.C_LINE_NO) C_LINE_NO,
       (SELECT A.C_STA_DESC FROM TB_STA A WHERE A.C_ID = T.C_CCM_NO) C_CCM_NO,
       N_ISSUE_WGT,
       C_RH,
       C_LF,
       C_KP,
       N_HL_TIME,
       C_HL,
       N_DFP_HL_TIME,
       C_DFP_HL,
       C_XM,
       C_ROUTE,
       C_MATRL_CODE_SLAB,
       C_MATRL_NAME_SLAB,
       C_SLAB_SIZE,
       N_SLAB_LENGTH,
       N_SLAB_PW,
       C_MATRL_CODE_KP,
       C_MATRL_NAME_KP,
       C_KP_SIZE,
       N_KP_LENGTH,
       N_KP_PW,
       N_GROUP,
       N_SORT,
       C_XC,
       C_SL,
       C_WL,
       C_SFPJ,
       C_TRANSMODE,
       N_MACH_WGT_CCM,
       C_XGID,
       N_ZJCLS,
       C_BY1,
       C_BY2,
       C_BY3,
       C_BY4,
       C_BY5,C_NC_ID,C_LGJH,C_ZLDJ_ID,C_ZL_ID,C_LF_ID,C_RH_ID,N_SLAB_WIDTH,N_SLAB_THICK,N_DIAMETER
  FROM TMO_ORDER T
 WHERE C_SFPJ = 'Y' AND T.N_TYPE IN ('6', '8')
   AND N_STATUS = 2
   AND N_EXEC_STATUS >= 0 AND N_EXEC_STATUS IN (0,2,5,6) ";


            sql = sql + " AND  (N_WGT-nvl(N_PROD_WGT,0) - N_ROLL_PROD_WGT - N_LINE_MATCH_WGT) > 0";
            sql = sql + " AND (N_SMS_PROD_WGT + N_SLAB_MATCH_WGT)>0 ";

            if (C_CCM_NO.Trim() != "")
            {
                sql = sql + " AND C_LINE_NO = '" + C_CCM_NO + "'";
            }
            sql = sql + " ORDER BY D_DELIVERY_DT, C_ORDER_LEV,  C_LEV,   N_USER_LEV, C_STL_GRD,  C_STD_CODE ,C_ORDER_NO";//订单系统排序
            return DbHelperOra.Query(sql.ToString()).Tables[0];
        }


        /// <summary>
        /// 待排产订单按可混浇分组
        /// </summary>
        /// <returns></returns>
        public string GroupingOrder()
        {
            OracleParameter[] parameters = {
            new OracleParameter("P_MSG", OracleDbType.Varchar2,100)};
            parameters[0].Value = "失败！";
            return DbHelperOra.RunProcedureOut("PKG_UPDATE_SORT.P_ORDER_GROUPING", parameters);
        }

        /// <summary>
        /// 订单分析
        /// </summary>
        /// <returns></returns>
        public string ManageOrder()
        {
            OracleParameter[] parameters = {
            new OracleParameter("P_MSG", OracleDbType.Varchar2,500)};
            parameters[0].Value = "失败";
            return DbHelperOra.RunProcedureOut("PKG_UPDATE_SORT.P_ORDER_MANAGE", parameters);
        }

        /// <summary>
        /// 订单评价
        /// </summary>
        /// <returns></returns>
        public string PJOrder()
        {
            OracleParameter[] parameters = {
            new OracleParameter("P_MSG", OracleDbType.Varchar2,500)};
            parameters[0].Value = "失败";
            return DbHelperOra.RunProcedureOut("PKG_UPDATE_SORT.P_ORDER_PJ", parameters);
        }

        /// <summary>
        /// 订单确认
        /// </summary>
        /// <returns></returns>
        public string QROrder()
        {
            OracleParameter[] parameters = {
            new OracleParameter("P_MSG", OracleDbType.Varchar2,500)};
            parameters[0].Value = "0";
            return DbHelperOra.RunProcedureOut("PKG_UPDATE_SORT.P_ORDER_DOWN_ALL", parameters);
        }


        /// <summary>
        /// 取消排产
        /// </summary>
        /// <returns></returns>
        public string qxOrder_roll(string C_ID)
        {
            OracleParameter[] parameters = {
            new OracleParameter("P_MSG", OracleDbType.Varchar2,500),
                new OracleParameter("P_ORDER_NO", OracleDbType.Varchar2,500)};
            parameters[0].Value = "0";
            parameters[1].Value = C_ID;
            return DbHelperOra.RunProcedureOut("PKG_UPDATE_SORT.P_DELETE_PLAN_ROLL", parameters);
            //return DbHelperOra.RunProcedureOut("PKG_UPDATE_SORT.P_DELETE_PLAN_SMS", parameters);
        }

        /// <summary>
        /// 取消排产
        /// </summary>
        /// <returns></returns>
        public string qxOrder_sms(string C_ID)
        {
            OracleParameter[] parameters = {
            new OracleParameter("P_MSG", OracleDbType.Varchar2,500),
                new OracleParameter("P_ORDER_NO", OracleDbType.Varchar2,500)};
            parameters[0].Value = "0";
            parameters[1].Value = C_ID;

            return DbHelperOra.RunProcedureOut("PKG_UPDATE_SORT.P_DELETE_PLAN_SMS", parameters);
        }


        /// <summary>
        /// 订单下发
        /// </summary>
        /// <param name="P_ID">订单主键</param>
        /// <param name="P_WGT">订单下发两</param>
        /// <returns>执行结果1成功0失败</returns>
        public string QROrder(string P_ID, decimal P_WGT)
        {
            OracleParameter[] parameters = {
            new OracleParameter("P_MSG", OracleDbType.Varchar2,500),
            new OracleParameter("P_ID", OracleDbType.Varchar2,500),
            new OracleParameter("P_WGT", OracleDbType.Decimal,15)};
            parameters[0].Value = "0";
            parameters[1].Value = P_ID;
            parameters[2].Value = P_WGT;
            return DbHelperOra.RunProcedureOut("PKG_UPDATE_SORT.P_ORDER_DOWN", parameters);
        }

        /// <summary>
        /// 查询待确认订单
        /// </summary>
        /// <param name="C_ORDER_NO">订单号</param>
        /// <param name="C_CON_NO">合同号</param>
        /// <param name="C_STL_GRD">钢种</param>
        /// <param name="C_STD_CODE">执行标准</param>
        /// <param name="D_SPEC_MIN">规格最小</param>
        /// <param name="D_SPEC_MAX">规格最大</param>
        /// <param name="C_LINE_NO">产线主键</param>
        /// <param name="C_CCM_NO">连铸主键</param>
        /// <param name="C_JQ_MIN">交期最小</param>
        /// <param name="C_JQ_MAX">交期最大</param>
        /// <returns>订单列表</returns>
        public DataSet GetListByWhere1(string C_ORDER_NO, string C_CON_NO, string C_STL_GRD, string C_STD_CODE, double? D_SPEC_MIN, double? D_SPEC_MAX, string C_LINE_NO, string C_CCM_NO, string C_JQ_MIN, string C_JQ_MAX)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select t.*  ");
            strSql.Append(" FROM TMO_ORDER T WHERE 1=1 AND C_SFPJ='N'  AND   N_EXEC_STATUS  IN (0,2,5,6) AND   N_STATUS =2");


            if (C_ORDER_NO.Trim() != "")
            {
                strSql.Append(" AND   C_ORDER_NO  LIKE '%" + C_ORDER_NO + "%'");
            }
            if (C_CON_NO.Trim() != "")
            {
                strSql.Append(" AND   C_CON_NO LIKE '%" + C_CON_NO + "%'");
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

            if (C_LINE_NO.Trim() != "")
            {
                strSql.Append(" AND   C_LINE_NO = '" + C_LINE_NO + "'");
            }
            if (C_CCM_NO.Trim() != "")
            {
                strSql.Append(" AND   C_CCM_NO = '" + C_CCM_NO + "'");
            }

            if (C_JQ_MIN.Trim() != "")
            {
                strSql.Append(" AND  D_DELIVERY_DT >=TO_DATE('" + C_JQ_MIN + "','yyyy-mm-dd hh24:mi:ss')");
            }
            if (C_JQ_MAX.Trim() != "")
            {
                strSql.Append("  AND  D_DELIVERY_DT >=TO_DATE('" + C_JQ_MAX + "','yyyy-mm-dd hh24:mi:ss')");
            }
            strSql.Append(" ORDER BY D_DELIVERY_DT,C_ORDER_LEV,C_LEV,N_USER_LEV,C_STL_GRD,C_STD_CODE");
            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 查找订单最大交期
        /// </summary>
        /// <returns></returns>
        public string GetMaxJQ(string sfkp)
        {

            string sql = "SELECT to_char( MAX(A.D_DELIVERY_DT),'yyyy-mm-dd') D_DELIVERY_DT FROM TMO_ORDER A where 1=1 ";
            if (sfkp.Trim() == "Y")
            {
                sql = sql + " AND  A.C_KP='Y'";
            }
            if (sfkp.Trim() == "N")
            {
                sql = sql + " AND  A.C_KP='N'";
            }

            return DbHelperOra.Query(sql).Tables[0].Rows[0]["D_DELIVERY_DT"].ToString();
        }




        #endregion  ExtensionMethod

        #region 计划跟踪

        /// <summary>
        ///销售计划跟踪
        /// </summary>
        /// <param name="C_ORDER_NO">订单号</param>
        /// <param name="C_STL_GRD">钢种</param>
        /// <param name="C_SPEC">规格</param>
        /// <param name="C_STD_CODE">执行标准</param>
        /// <param name="D_DT_B">订单日期起</param>
        /// <param name="D_DT_E">订单日期终</param>
        ///  <param name="D_DT_jh_B">计划日期起</param>
        /// <param name="D_DT_jh_E">计划日期终</param>
        /// <param name="C_LINE_NO">轧线主键</param>
        /// <returns></returns>
        public DataTable GetPlanZX(string C_SFPJ, int? N_EXEC_STATUS, int? N_SFPW, string C_ORDER_NO, string C_CON_NO, string C_STL_GRD, string C_STD_CODE, double? D_SPEC_MIN, double? D_SPEC_MAX, string C_CUST_NAME, string C_JQ_MIN, string C_JQ_MAX, string C_DD_MIN, string C_DD_MAX, string C_LINE_NO)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(@"SELECT T.C_ORDER_NO 订单号,
      to_char( T.D_DT,'yyyy-mm-dd') 订单日期,
      to_char( T.D_PCTBTS,'yyyy-mm-dd') 计划日期,
       to_char(T.D_NEED_DT,'yyyy-mm-dd') 需求日期,
      to_char( T.D_DELIVERY_DT,'yyyy-mm-dd') 交期,
       T.C_MAT_NAME 物料名称,
       T.C_MAT_CODE 物料编码,
       T.C_SPEC 规格,
       T.C_STL_GRD 钢种,
       T.C_FREE1 自由项1,
       T.C_FREE2 自由项2,
       T.C_STD_CODE 执行标准,
       T.C_PACK 包装要求,
       T.N_WGT 需求数量,
       CASE WHEN  T.N_ROLL_PROD_WGT=0 THEN   T.N_WGT ELSE  T.N_ROLL_PROD_WGT END   实际需求量,
       t.N_ROLL_PROD_WGT 确认数量,
       T.N_SLAB_MATCH_WGT+T.n_prod_wgt 完工数量,
       T.N_SLAB_MATCH_WGT+T.n_prod_wgt- T.N_WGT 订单执行情况,
       T.N_WARE_OUT_WGT 发运数量, 
       T.N_DP_WGT 待检数量,
       T.N_HG_WGT_IN 合格入库数量,
       (SELECT SUM(A.N_WGT)
          FROM TSC_SLAB_MAIN A
         WHERE A.C_STL_GRD = T.C_STL_GRD_SLAB
           AND A.C_STD_CODE = T.C_STD_CODE_SLAB
           AND A.C_MOVE_TYPE IN ('E','M','DZ','NP','R','DX')) 钢坯现存量,
       (SELECT SUM(A.N_WGT)
          FROM TRC_ROLL_PRODCUT A
         WHERE A.C_STL_GRD = T.C_STL_GRD AND A.C_MOVE_TYPE IN ('E','M')
           AND A.C_STD_CODE = T.C_STD_CODE
           AND A.C_SPEC = T.C_SPEC
           AND A.C_ZYX1 = T.C_FREE1
           AND A.C_ZYX2 = T.C_FREE2
           AND A.C_BZYQ = T.C_PACK) 线材库存量,
       T.C_AREA 销售区域,
       T.C_TRANSMODE 运输方式,
       T.C_ORDER_LEV 订单等级,
       T.C_PRO_USE 用途,
       T.C_CON_NAME 合同号,
 DECODE( t.N_EXEC_STATUS,0,'未完成','2','未完成',5,'已关闭',6,'已完成') 订单状态  ");
            strSql.Append(" FROM TMO_ORDER T WHERE      N_STATUS=2   AND  nvl(C_REMARK,1) <> '人工关闭'   AND T.N_TYPE =8  ");

            if (C_SFPJ.Trim() != "")
            {
                strSql.Append(" AND   nvl(C_SFPJ,'N') ='" + C_SFPJ + "'");
            }

            if (N_EXEC_STATUS == 0)
            {
                strSql.Append(" AND   N_EXEC_STATUS  IN (0,2)");

            }

            if (C_LINE_NO.Trim() != "all")
            {
                if (C_LINE_NO.Trim() == "")
                {
                    strSql.Append(" AND   C_LINE_NO IS NULL ");
                }
                else
                {
                    strSql.Append(" AND   C_LINE_NO='" + C_LINE_NO + "'");
                }

            }

            else if (N_EXEC_STATUS == 1)
            {
                strSql.Append(" AND   N_EXEC_STATUS=6");

            }
            else if (N_EXEC_STATUS == 2)
            {
                strSql.Append(" AND   N_EXEC_STATUS=5");
            }
            else
            {
                strSql.Append(" AND   N_EXEC_STATUS  IN (0,2,5,6)");
            }
            if (N_SFPW == 2)
            {
                strSql.Append("  AND N_ROLL_PROD_WGT>0 ");

            }
            else if (N_SFPW == 1)
            {
                strSql.Append("  AND N_ROLL_PROD_WGT=0 ");
            }

            if (C_ORDER_NO.Trim() != "")
            {
                strSql.Append(" AND   C_ORDER_NO  LIKE '%" + C_ORDER_NO + "%'");
            }
            if (C_CON_NO.Trim() != "")
            {
                strSql.Append(" AND   C_CON_NO LIKE '%" + C_CON_NO + "%'");
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
                strSql.Append("   AND  N_DIAMETER >= " + D_SPEC_MIN + " ");
            }

            if (D_SPEC_MAX != null)
            {
                strSql.Append("   AND N_DIAMETER <= " + D_SPEC_MAX + " ");
            }

            if (C_CUST_NAME.Trim() != "")
            {
                strSql.Append(" AND   C_MAT_NAME LIKE  '%" + C_CUST_NAME + "%'");
            }

            if (C_JQ_MIN.Trim() != "")
            {
                strSql.Append(" AND  D_PCTBTS >=TO_DATE('" + C_JQ_MIN + "','yyyy-mm-dd hh24:mi:ss')");
            }
            if (C_JQ_MAX.Trim() != "")
            {
                strSql.Append("  AND  D_PCTBTS <=TO_DATE('" + C_JQ_MAX + "','yyyy-mm-dd hh24:mi:ss')");
            }

            if (C_DD_MIN.Trim() != "")
            {
                strSql.Append(" AND  D_DT >=TO_DATE('" + C_DD_MIN + "','yyyy-mm-dd hh24:mi:ss')");
            }
            if (C_DD_MAX.Trim() != "")
            {
                strSql.Append("  AND  D_DT<=TO_DATE('" + C_DD_MAX + "','yyyy-mm-dd hh24:mi:ss')");
            }

            strSql.Append(" ORDER BY D_DELIVERY_DT,C_ORDER_LEV,C_LEV,N_USER_LEV,C_STL_GRD,C_STD_CODE");

            return DbHelperOra.Query(strSql.ToString()).Tables[0];

        }

        public bool ifcz(string order_no)
        {
            string sql = "SELECT * FROM tmo_order t WHERE t.c_order_no='" + order_no + "'";
            DataTable dt = DbHelperOra.Query(sql.ToString()).Tables[0];
            if (dt.Rows.Count > 0)
            {
                return false;
            }
            else
            {
                return true;
            }

        }
        /// <summary>
        /// 线材计划汇总
        /// </summary>
        /// <param name="dt1">开始时间</param>
        /// <param name="dt2">结束时间</param>
        /// <returns></returns>
        public DataTable GetXCTJ(string dt1, string dt2)
        {
            //            string sql = @"SELECT N.C_TYPE C_STL_TYPE, N.C_STL_GRD,N.WGT1 N_WGT,N.N_SLAB_WGT N_SLAB_XCL,N_LAST_LEFT_WGT,CASE WHEN  (N_SLAB_WGT-N_LAST_LEFT_WGT)<=0 THEN 0 ELSE  CASE WHEN    N_SLAB_WGT - N_LAST_LEFT_WGT>N.WGT1 THEN N.WGT1 ELSE   N_SLAB_WGT - N_LAST_LEFT_WGT END  END N_SLAB_KZ,CASE WHEN N.WGT1-(CASE WHEN  (N_SLAB_WGT-N_LAST_LEFT_WGT)<=0 THEN 0 ELSE N_SLAB_WGT-N_LAST_LEFT_WGT END)<0 THEN 0 ELSE N.WGT1-(CASE WHEN  (N_SLAB_WGT-N_LAST_LEFT_WGT)<=0 THEN 0 ELSE N_SLAB_WGT-N_LAST_LEFT_WGT END) END N_SLAB_NEED  FROM (
            //SELECT M.C_STL_GRD,
            //       SUM(M.N_LEFT_WGT) WGT1,
            //       M.C_TYPE,
            //       NVL((SELECT A.N_WGT
            //             FROM V_SLAB_XC A
            //            WHERE A.C_STL_GRD = M.C_STL_GRD
            //              AND A.C_TYPE = M.C_TYPE),
            //           0) N_SLAB_WGT,
            //       NVL((SELECT X.N_LAST_LEFT_WGT
            //             FROM (SELECT SUM(T.N_LEFT_WGT) N_LAST_LEFT_WGT,
            //                          T.C_STL_GRD,
            //                          T.C_TYPE
            //                     FROM V_ORDER_ZX T
            //                    WHERE T.D_PCTBTS <=";
            //            sql = sql + "      TO_DATE('" + dt1 + "', 'yyyy-mm-dd hh24:mi:ss')";
            //            sql = sql + "           AND T.D_PCTBTS >= TO_DATE('" + dt1 + "','yyyy-mm-dd hh24:mi:ss') - 30";
            //            sql = sql + @"         GROUP BY T.C_STL_GRD, T.C_TYPE) X
            //            WHERE X.C_STL_GRD = M.C_STL_GRD
            //              AND X.C_TYPE = M.C_TYPE),
            //           0) N_LAST_LEFT_WGT
            //  FROM (SELECT T.D_PCTBTS,
            //               T.C_STL_GRD,
            //               T.C_STD_CODE,
            //               T.C_STL_TYPE,
            //               T.N_WGT, ---订单需求量
            //               T.N_PROD_WGT, ---订单完成量
            //               T.C_TYPE,
            //               T.N_LEFT_WGT
            //          FROM V_ORDER_ZX T
            //         WHERE T.D_PCTBTS >=
            //               TO_DATE('" + dt1 + "', 'yyyy-mm-dd hh24:mi:ss')";
            //            sql = sql + @"  AND T.D_PCTBTS <= TO_DATE('" + dt2 + "', 'yyyy-mm-dd hh24:mi:ss')) M GROUP BY M.C_STL_GRD, M.C_TYPE ) N ORDER BY DECODE( N.C_TYPE,'普碳钢',1,'高速线材',2,'精品线材',3,4),N.C_STL_GRD ";



            string sql = @"SELECT N.N_WGT N_ORDER_WGT, ---订单需求量
       N.N_PROD_WGT, ---订单完成量
       N.C_TYPE C_STL_TYPE,
       N.C_STL_GRD,
       N.WGT1 N_WGT,
       N.N_SLAB_WGT N_SLAB_XCL,
       N_LAST_LEFT_WGT,
       CASE
         WHEN (N_SLAB_WGT - N_LAST_LEFT_WGT) <= 0 THEN
          0
         ELSE
          CASE
            WHEN N_SLAB_WGT - N_LAST_LEFT_WGT > N.WGT1 THEN
             N.WGT1
            ELSE
             N_SLAB_WGT - N_LAST_LEFT_WGT
          END
       END N_SLAB_KZ,
       CASE
         WHEN N.WGT1 - (CASE
                WHEN (N_SLAB_WGT - N_LAST_LEFT_WGT) <= 0 THEN
                 0
                ELSE
                 N_SLAB_WGT - N_LAST_LEFT_WGT
              END) < 0 THEN
          0
         ELSE
          N.WGT1 - (CASE
            WHEN (N_SLAB_WGT - N_LAST_LEFT_WGT) <= 0 THEN
             0
            ELSE
             N_SLAB_WGT - N_LAST_LEFT_WGT
          END)
       END N_SLAB_NEED
  FROM (SELECT SUM(M.N_WGT) N_WGT, ---订单需求量
               SUM(M.N_PROD_WGT) N_PROD_WGT, ---订单完成量
               M.C_STL_GRD,
               SUM(M.N_LEFT_WGT) WGT1,
               M.C_TYPE,
               NVL((SELECT A.N_WGT
                     FROM V_SLAB_XC A
                    WHERE A.C_STL_GRD = M.C_STL_GRD
                      AND A.C_TYPE = M.C_TYPE),
                   0) N_SLAB_WGT,
               NVL((SELECT X.N_LAST_LEFT_WGT
                     FROM (SELECT SUM(T.N_LEFT_WGT) N_LAST_LEFT_WGT,
                                  T.C_STL_GRD,
                                  T.C_TYPE
                             FROM V_ORDER_ZX T
                            WHERE T.D_PCTBTS < TO_DATE('" + dt1 + "',  'yyyy-mm-dd hh24:mi:ss')  AND T.D_PCTBTS >=  TO_DATE('" + dt1 + "',  'yyyy-mm-dd hh24:mi:ss') - 30     GROUP BY T.C_STL_GRD, T.C_TYPE) X  WHERE X.C_STL_GRD = M.C_STL_GRD   AND X.C_TYPE = M.C_TYPE),    0) N_LAST_LEFT_WGT          FROM (SELECT T.D_PCTBTS,                       T.C_STL_GRD,                       T.C_STD_CODE,                       T.C_STL_TYPE,";
            sql = sql + @"    T.N_WGT, ---订单需求量
                       T.N_PROD_WGT, ---订单完成量
                       T.C_TYPE,
                       T.N_LEFT_WGT
                  FROM V_ORDER_ZX T
                 WHERE T.D_PCTBTS >=
                       TO_DATE('" + dt1 + "', 'yyyy-mm-dd hh24:mi:ss')                   AND T.D_PCTBTS <= TO_DATE('" + dt2 + "', 'yyyy-mm-dd hh24:mi:ss')) M         GROUP BY M.C_STL_GRD, M.C_TYPE) N ORDER BY DECODE(N.C_TYPE, '普碳钢', 1, '高速线材', 2, '精品线材', 3, 4),  N.C_STL_GRD";

            return DbHelperOra.Query(sql).Tables[0];

        }
        /// <summary>
        /// 线材订单执行情况查询
        /// </summary>
        /// <param name="begin">开始时间</param>
        /// <param name="end">结束时间</param>
        /// <param name="strSTLGRD">钢种</param>
        /// <param name="strSTD">执行标准</param>
        /// <param name="strSpec">规格</param>
        /// <param name="strCust">工艺路线</param>
        /// <param name="strOrderNo">订单号</param>
        /// <param name="N_EXEC_STATUS">执行状态</param>
        /// <param name="N_SFPW">是否下达</param>
        /// <returns></returns>
        public DataTable GetPlanZX_Query(DateTime begin, DateTime end, string strSTLGRD, string strSTD, string strSpec, string strCust, string strOrderNo, string SFPJ, int? N_EXEC_STATUS, int? N_SFPW, string C_LINE_NO, string c_type)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from V_ORDER_PRODUCE_INFO t where 1=1");
            if (begin != null && end != null)
            {
                strSql.Append(" and t.计划日期 between to_date('" + Convert.ToDateTime(begin) + "','yyyy-mm-dd hh24:mi:ss') and to_date('" + Convert.ToDateTime(end) + "','yyyy-mm-dd hh24:mi:ss') ");
            }
            if (!string.IsNullOrEmpty(strSTLGRD))
            {
                strSql.Append(" and t.钢种 like '%" + strSTLGRD + "%' ");
            }
            if (!string.IsNullOrEmpty(strSTD))
            {
                strSql.Append(" and t.执行标准 like '%" + strSTD + "%' ");
            }
            if (!string.IsNullOrEmpty(strSpec))
            {
                strSql.Append(" and INSTR(  '" + strSpec + "',t.规格)>0 ");
            }
            if (!string.IsNullOrEmpty(strCust))
            {
                strSql.Append("   AND t.工艺路线 like '%" + strCust + "%' ");
            }
            if (!string.IsNullOrEmpty(strOrderNo))
            {
                strSql.Append("   AND t.计划订单号 like '%" + strOrderNo + "%' ");
            }
            if (!string.IsNullOrEmpty(SFPJ))
            {
                strSql.Append(" AND   nvl(t.是否评价,'N') ='" + strOrderNo + "'");
            }

            if (N_EXEC_STATUS == 1)
            {
                strSql.Append(" AND   t.执行状态='未完成'");

            }
            if (N_EXEC_STATUS == 2)
            {
                strSql.Append(" AND   t.执行状态='已完成'");
            }

            if (N_SFPW == 2)
            {
                strSql.Append("  AND t.计划下达量>0 ");

            }
            else if (N_SFPW == 1)
            {
                strSql.Append("  AND t.计划下达量=0 ");
            }

            if (c_type != "")
            {
                strSql.Append("  AND t.是否不锈钢='" + c_type + "' ");

            }

            if (C_LINE_NO.Trim() != "all")
            {
                if (C_LINE_NO.Trim() == "")
                {
                    strSql.Append(" AND   C_LINE_NO IS NULL ");
                }
                else
                {
                    strSql.Append(" AND   C_LINE_NO='" + C_LINE_NO + "'");
                }

            }
            return DbHelperOra.Query(strSql.ToString()).Tables[0];

        }


        /// <summary>
        /// 线材订单执行情况查询
        /// </summary>
        /// <param name="begin">开始时间</param>
        /// <param name="end">结束时间</param>
        /// <param name="strSTLGRD">钢种</param>
        /// <param name="strSTD">执行标准</param>
        /// <param name="strSpec">规格</param>
        /// <param name="strCust">工艺路线</param>
        /// <param name="strOrderNo">订单号</param>
        /// <param name="N_EXEC_STATUS">执行状态</param>
        /// <param name="N_SFPW">是否下达</param>
        /// <returns></returns>
        public DataTable GetPlanZX_Query_ZG(DateTime begin, DateTime end, string strSTLGRD, string strSTD, string strSpec, string strCust, string strOrderNo, string SFPJ, int? N_EXEC_STATUS, int? N_SFPW, string C_LINE_NO, string c_type)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from V_ORDER_PRODUCE_INFO t where 1=1");
            if (begin != null && end != null)
            {
                strSql.Append(" and t.计划日期 between to_date('" + Convert.ToDateTime(begin) + "','yyyy-mm-dd hh24:mi:ss') and to_date('" + Convert.ToDateTime(end) + "','yyyy-mm-dd hh24:mi:ss') ");
            }
            if (!string.IsNullOrEmpty(strSTLGRD))
            {
                strSql.Append(" and t.钢种 like '%" + strSTLGRD + "%' ");
            }
            if (!string.IsNullOrEmpty(strSTD))
            {
                strSql.Append(" and t.执行标准 like '%" + strSTD + "%' ");
            }
            if (!string.IsNullOrEmpty(strSpec))
            {
                strSql.Append(" and INSTR(  '" + strSpec + "',t.规格)>0 ");
            }
            if (!string.IsNullOrEmpty(strCust))
            {
                strSql.Append("   AND t.工艺路线 like '%" + strCust + "%' ");
            }
            if (!string.IsNullOrEmpty(strOrderNo))
            {
                strSql.Append("   AND t.计划订单号 like '%" + strOrderNo + "%' ");
            }
            if (!string.IsNullOrEmpty(SFPJ))
            {
                strSql.Append(" AND   nvl(t.是否评价,'N') ='" + strOrderNo + "'");
            }

            if (N_EXEC_STATUS == 1)
            {
                strSql.Append(" AND   t.执行状态='未完成'");

            }
            if (N_EXEC_STATUS == 2)
            {
                strSql.Append(" AND   t.执行状态='已完成'");
            }

            if (N_SFPW == 2)
            {
                strSql.Append("  AND t.计划下达量>0 ");

            }
            else if (N_SFPW == 1)
            {
                strSql.Append("  AND t.计划下达量=0 ");
            }

            if (c_type != "")
            {
                strSql.Append("  AND t.是否不锈钢='" + c_type + "' ");

            }

            if (C_LINE_NO.Trim() != "all")
            {
                if (C_LINE_NO.Trim() == "")
                {
                    strSql.Append(" AND   C_LINE_NO IS NULL ");
                }
                else
                {
                    strSql.Append(" AND   C_LINE_NO='" + C_LINE_NO + "'");
                }

            }

            strSql.Append("  ORDER BY DECODE(T.车间,'一线',1,'四线',2,'二线',3,'三线',4,'五线',5),直径,型号 ");
            return DbHelperOra.Query(strSql.ToString()).Tables[0];

        }


        /// <summary>
        /// 订单线材监控按车间
        /// </summary>
        /// <returns></returns>
        public DataTable GetOrderMonitor_Roll(DateTime start, DateTime end, string roll)
        {
            string sql = @"SELECT 
                           T.C_STL_GRD,
                           T.C_SPEC,SUM(N_WGT)N_WGT,
                           T.C_ROLL_CODE ,
                           SUM(T.N_PROD_WGT) N_PROD_WGT,
                           SUM(N_PROD_WGT)-SUM(N_WGT)EXEC_WGT,
                          SUM(T.STAN_WGT)STAN_WGT,
                           SUM(T.STAN_WET2)STAN_WET2 
                           FROM 
                           (
                           SELECT O.N_WGT,
                                  O.N_PROD_WGT,       
                                  O.C_STL_GRD,
                                  O.C_SPEC,   
                                 O.C_ROLL_CODE, 
                                  (SELECT SUM(TRP.N_WGT)
                                     FROM TRC_ROLL_PRODCUT TRP
                                    WHERE TRP.C_STL_GRD = O.C_STL_GRD
                                      AND TRP.C_SPEC = O.C_SPEC
                                      AND (TRP.C_MOVE_TYPE ='E' OR TRP.C_MOVE_TYPE ='M')
                                   )STAN_WGT,
                                   (SELECT SUM(TSM.N_WGT) FROM TSC_SLAB_MAIN  TSM 
                                      WHERE TSM.C_STL_GRD= O.C_STL_GRD  
                                      AND (TSM.C_MOVE_TYPE ='E' OR TSM.C_MOVE_TYPE ='M')
                                     ) STAN_WET2
                             FROM TMO_ORDER O
                            WHERE O.D_PCTBTS >= TO_DATE('" + start.ToString("yyyy-MM-dd") + "', 'yyyy-mm-dd')";
            sql += "   AND O.D_PCTBTS <=TO_DATE('" + end.ToString("yyyy-MM-dd") + "', 'yyyy-mm-dd')  ";
            if (roll != "全部" && !string.IsNullOrWhiteSpace(roll))
            {
                sql += " AND O.C_ROLL_CODE='" + roll + "' ";
            }
            sql += "    )T    ";
            sql += "    GROUP BY T.C_STL_GRD,T.C_SPEC,T.C_ROLL_CODE    ORDER BY T.C_STL_GRD,T.C_SPEC  ";
            return DbHelperOra.Query(sql).Tables[0];
        }
        #endregion

        #region 查询不锈钢订单
        /// <summary>
        /// 查询不锈钢未完成的计划
        /// </summary>
        /// <param name="dt1">计划查询开始时间</param>
        /// <param name="dt2">计划查询截止时间</param>
        /// <param name="C_STL_GRD">钢种</param>
        /// <param name="C_STD_CODE">执行标准</param>
        /// <param name="C_SPEC">规格</param>
        /// <param name="C_ORDER_NO">订单号</param>
        /// <returns></returns>
        public DataTable GetBXGOrder(string dt1,string dt2,string C_STL_GRD,string C_STD_CODE,string C_SPEC,string C_ORDER_NO)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(@"  SELECT   T.C_ID,
       T.C_ORDER_NO,
       T.C_CON_NO,
       T.C_CON_NAME,
       T.C_AREA,
       T.C_CUST_NO,
       T.C_CUST_NAME,
       T.C_SALE_CHANNEL,
       T.C_CURRENCYTYPEID,
       T.C_RECEIPTAREAID,
       T.C_RECEIVEADDRESS,
       T.C_RECEIPTCORPID,
       T.C_PROD_NAME,
       T.C_PROD_KIND,
       T.C_INVBASDOCID,
       T.C_INVENTORYID,
       T.C_MAT_CODE,
       T.C_MAT_NAME,
       T.C_STL_GRD,
       T.C_SPEC,
       T.C_TECH_PROT,
       T.C_FREE1,
       T.C_FREE2,
       T.C_PACK,
       T.C_STD_CODE,
       T.C_DESIGN_NO,
       T.C_STDID,
       T.C_DESIGNID,
       T.C_VDEF1,
       T.C_PRO_USE,
       T.C_CUST_SQ,
       T.C_FUNITID,
       T.C_UNITID,
       T.N_HSL,
       T.N_FNUM,
       T.N_WGT,
       T.N_PROFIT,
       T.N_COST,
       T.N_TAXRATE,
       T.N_ORIGINALCURPRICE,
       T.N_ORIGINALCURTAXPRICE,
       T.N_ORIGINALCURTAXMNY,
       T.N_ORIGINALCURMNY,
       T.N_ORIGINALCURSUMMNY,
       T.D_NEED_DT,
       T.D_DELIVERY_DT,
       T.D_DT,
       T.N_STATUS,
       T.N_TYPE,
       T.N_FLAG,
      T.N_EXEC_STATUS,
       T.N_USER_LEV,
       T.C_LEV,
       T.C_ORDER_LEV,
       T.C_REMARK,
       T.C_EMP_ID,
       T.C_EMP_NAME,
       T.D_MOD_DT,
       T.N_SLAB_MATCH_WGT,
       T.N_LINE_MATCH_WGT,
       T.N_PROD_WGT,
       T.N_WARE_WGT,
       T.N_WARE_OUT_WGT,
       T.N_MACH_WGT,
       T.C_ISSUE_EMP_ID,
       T.C_PRD_EMP_ID,
       T.C_DESIGN_PROG,
       T.N_SMS_PROD_WGT,
       T.C_SMS_PROD_EMP_ID,
       T.D_SMS_PROD_DT,
       T.N_ROLL_PROD_WGT,
       T.C_ROLL_PROD_EMP_ID,
       T.D_STL_ROL_DT,
       T.C_LINE_NO,
       T.C_CCM_NO,
       T.N_ISSUE_WGT,
       T.C_RH,
       T.C_LF,
       T.C_KP,
       T.N_HL_TIME,
       T.C_HL,
       T.N_DFP_HL_TIME,
       T.C_DFP_HL,
       T.C_XM,
       T.C_ROUTE,
       T.C_MATRL_CODE_SLAB,
       T.C_MATRL_NAME_SLAB,
       T.C_SLAB_SIZE,
       T.N_SLAB_LENGTH,
       T.N_SLAB_PW,
       T.C_MATRL_CODE_KP,
       T.C_MATRL_NAME_KP,
       T.C_KP_SIZE,
       T.N_KP_LENGTH,
       T.N_KP_PW,
       T.N_GROUP,
       T.N_SORT,
       T.C_XC,
       T.C_SL,
       T.C_WL,
       T.C_SFPJ,
       T.C_TRANSMODE,
       T.N_MACH_WGT_CCM,
       T.C_XGID,
       T.N_ZJCLS,
       T.C_BY1,
       T.C_BY2,
       T.C_BY3,
       T.C_BY4,
       T.C_BY5,
       T.C_NC_ID,
       T.C_LGJH,
       T.C_ZLDJ_ID,
       T.C_ZL_ID,
       T.C_LF_ID,
       T.C_RH_ID,
       T.N_SLAB_WIDTH,
       T.N_SLAB_THICK,
       T.N_DIAMETER,
       T.D_NC_DATE,
       T.C_YWY,
       T.C_NC_SALECODE,
       T.C_TRANSMODEID,
       T.C_DFP_RZ,
       T.C_RZP_RZ,
       T.C_DFP_YQ,
       T.C_RZP_YQ,
       T.C_XM_YQ,
       T.N_JRL_WD,
       T.N_JRL_SJ,
       T.N_KPJRL_WD,
       T.N_KPJRL_SJ,
       T.N_TSL,
       T.C_ROLL_CODE,
       T.C_CCM_CODE,
       T.C_ROLL_DESC,
       T.C_CCM_DESC,
       T.C_TL,
       T.N_ZJCLS_MIN,
       T.N_ZJCLS_MAX,
       T.C_NCSTATUS,
       T.C_PCLX,
       T.C_STL_GRD_TYPE,
       T.D_NS_SEND_DT,
       T.C_ORDER_NO_OLD,
       T.C_STL_GRD_SLAB,
       T.C_STD_CODE_SLAB,
       T.C_PCTBEMP,
      TO_CHAR(T.D_PCTBTS, 'yyyy-mm-dd') D_PCTBTS,
       T.C_SFJK,
       T.C_STL_GRD_CLASS,
       T.N_LENGTH,
       T.N_HG_WGT,
       T.N_DP_WGT,
       T.N_GP_WGT,
       T.N_XY_WGT,
       T.N_TW_WGT,
       T.N_BHG_WGT,
       T.N_HG_WGT_IN,
       T.N_GP_WGT_IN,
       T.N_XY_WGT_IN,
       T.N_TW_WGT_IN,
       T.N_BHG_WGT_IN,
       T.N_HG_WGT_OUT,
       T.N_GP_WGT_OUT,
       T.N_XY_WGT_OUT,
       T.N_TW_WGT_OUT,
       T.N_BHG_WGT_OUT,
       T.D_SALE_TIME_MIN,
       T.D_SALE_TIME_MAX,
       T.D_PRODUCE_DATE_MIN,
       T.D_PRODUCE_DATE_MAX,
       T.D_OLD_DATE,
       T.N_ROLL_WGT,
       (SELECT SUM(A.N_WGT)
          FROM TSC_SLAB_MAIN A
         WHERE A.C_STL_GRD = T.C_STL_GRD_SLAB
           AND A.C_STD_CODE = T.C_STD_CODE_SLAB
           AND A.C_MOVE_TYPE IN('E', 'M', 'DZ', 'NP', 'R', 'DX')) N_SLAB_XC_WGT,
       (SELECT SUM(A.N_WGT)
          FROM TRC_ROLL_PRODCUT A
         WHERE A.C_STL_GRD = T.C_STL_GRD
           AND A.C_MOVE_TYPE IN('E', 'M')
           AND A.C_STD_CODE = T.C_STD_CODE
           AND A.C_SPEC = T.C_SPEC
           AND A.C_ZYX1 = T.C_FREE1
           AND A.C_ZYX2 = T.C_FREE2
           AND A.C_BZYQ = T.C_PACK) N_ROLL_XC_WGT,C_REMARK1,
C_REMARK2,
C_REMARK3,
C_REMARK4,
C_REMARK5,
D_SC_MOD_DT,
N_SLAB_XH_WGT,
C_SLAB_TYPE,
D_OLD_NEED_DATE,
D_PJ_DATE,
D_DATE_BY1,
D_DATE_BY2,
D_DATE_BY3,
D_DATE_BY4,
D_DATE_BY5,
D_DATE_BY6 FROM TMO_ORDER T WHERE T.N_STATUS = 2   AND T.N_EXEC_STATUS IN (0, 2)   AND T.C_BY4 = '1'   AND T.C_SFPJ = 'Y' ");
            if (dt1.Trim() != "")
            {
                strSql.Append(" AND  D_PCTBTS >=TO_DATE('" + dt1 + "','yyyy-mm-dd hh24:mi:ss')");
            }
            if (dt2.Trim() != "")
            {
                strSql.Append("  AND  D_PCTBTS <=TO_DATE('" + dt2 + "','yyyy-mm-dd hh24:mi:ss')");
            }
            if (C_STL_GRD.Trim() != "")
            {
                strSql.Append(" AND   C_STL_GRD LIKE '%" + C_STL_GRD + "%'");
            }

            if (C_STD_CODE.Trim() != "")
            {
                strSql.Append(" AND   C_STD_CODE LIKE '%" + C_STD_CODE + "%'");
            }
            if (C_SPEC.Trim() != "")
            {
                strSql.Append("   AND  INSTR('" + C_SPEC + "',C_SPEC)>0 ");
            }

            if (C_ORDER_NO.Trim() != "")
            {
                strSql.Append("   AND  (INSTR('" + C_ORDER_NO + "',C_ORDER_NO)>0   OR C_ORDER_NO LIKE '%"+ C_ORDER_NO + "%')");
            }

            strSql.Append("  ORDER BY D_PCTBTS  ");

            return DbHelperOra.Query(strSql.ToString()).Tables[0];
        }
        #endregion
    }
}
