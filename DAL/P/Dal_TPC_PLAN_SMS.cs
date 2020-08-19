using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;
namespace DAL
{
    /// <summary>
    /// 数据访问类:TPC_PLAN_SMS
    /// </summary>
    public partial class Dal_TPC_PLAN_SMS
    {
        public Dal_TPC_PLAN_SMS()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string C_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TPC_PLAN_SMS");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)         };
            parameters[0].Value = C_ID;

            return DbHelperOra.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Mod_TPC_PLAN_SMS model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TPC_PLAN_SMS(");
            strSql.Append("C_ID,C_ORDER_NO,C_CON_NO,C_STL_GRD,C_SPEC,C_FREE1,C_FREE2,C_STD_CODE,C_DESIGN_NO,N_WGT,D_NEED_DT,D_DELIVERY_DT,D_DT,N_STATUS,N_TYPE,C_EMP_ID,C_EMP_NAME,D_MOD_DT,C_ISSUE_EMP_ID,C_PRD_EMP_ID,C_CCM_NO,C_RH,C_LF,C_KP,N_HL_TIME,C_HL,N_DFP_HL_TIME,C_DFP_HL,C_XM,C_ROUTE,C_MATRL_CODE_SLAB,C_MATRL_NAME_SLAB,C_SLAB_SIZE,N_SLAB_LENGTH,N_SLAB_PW,C_MATRL_CODE_KP,C_MATRL_NAME_KP,C_KP_SIZE,N_KP_LENGTH,N_KP_PW,N_GROUP,N_SORT,C_XC,C_SL,C_WL,N_MACH_WGT_CCM,N_ZJCLS,C_BY1,C_BY2,C_BY3,C_BY4,C_BY5,C_LGJH,C_ZL_ID,C_LF_ID,C_RH_ID,N_SLAB_WIDTH,N_SLAB_THICK,C_DFP_RZ,C_RZP_RZ,C_DFP_YQ,C_RZP_YQ,C_XM_YQ,N_KPJRL_WD,N_KPJRL_SJ,N_TSL,C_CCM_CODE,C_CCM_DESC,C_TL,N_ZJCLS_MIN,N_ZJCLS_MAX,C_STL_GRD_TYPE,C_PROD_NAME,C_PROD_KIND)");
            strSql.Append(" values (");
            strSql.Append(":C_ID,:C_ORDER_NO,:C_CON_NO,:C_STL_GRD,:C_SPEC,:C_FREE1,:C_FREE2,:C_STD_CODE,:C_DESIGN_NO,:N_WGT,:D_NEED_DT,:D_DELIVERY_DT,:D_DT,:N_STATUS,:N_TYPE,:C_EMP_ID,:C_EMP_NAME,:D_MOD_DT,:C_ISSUE_EMP_ID,:C_PRD_EMP_ID,:C_CCM_NO,:C_RH,:C_LF,:C_KP,:N_HL_TIME,:C_HL,:N_DFP_HL_TIME,:C_DFP_HL,:C_XM,:C_ROUTE,:C_MATRL_CODE_SLAB,:C_MATRL_NAME_SLAB,:C_SLAB_SIZE,:N_SLAB_LENGTH,:N_SLAB_PW,:C_MATRL_CODE_KP,:C_MATRL_NAME_KP,:C_KP_SIZE,:N_KP_LENGTH,:N_KP_PW,:N_GROUP,:N_SORT,:C_XC,:C_SL,:C_WL,:N_MACH_WGT_CCM,:N_ZJCLS,:C_BY1,:C_BY2,:C_BY3,:C_BY4,:C_BY5,:C_LGJH,:C_ZL_ID,:C_LF_ID,:C_RH_ID,:N_SLAB_WIDTH,:N_SLAB_THICK,:C_DFP_RZ,:C_RZP_RZ,:C_DFP_YQ,:C_RZP_YQ,:C_XM_YQ,:N_KPJRL_WD,:N_KPJRL_SJ,:N_TSL,:C_CCM_CODE,:C_CCM_DESC,:C_TL,:N_ZJCLS_MIN,:N_ZJCLS_MAX,:C_STL_GRD_TYPE,:C_PROD_NAME,:C_PROD_KIND)");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ORDER_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CON_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STL_GRD", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SPEC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_FREE1", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_FREE2", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STD_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_DESIGN_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":D_NEED_DT", OracleDbType.Date),
                    new OracleParameter(":D_DELIVERY_DT", OracleDbType.Date),
                    new OracleParameter(":D_DT", OracleDbType.Date),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,2),
                    new OracleParameter(":N_TYPE", OracleDbType.Decimal,15),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_EMP_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":C_ISSUE_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PRD_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CCM_NO", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_RH", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_LF", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_KP", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_HL_TIME", OracleDbType.Decimal,10),
                    new OracleParameter(":C_HL", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_DFP_HL_TIME", OracleDbType.Decimal,10),
                    new OracleParameter(":C_DFP_HL", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_XM", OracleDbType.Varchar2,500),
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
                    new OracleParameter(":C_XM_YQ", OracleDbType.Varchar2,1000),
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
                    new OracleParameter(":C_PROD_KIND", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.C_ID;
            parameters[1].Value = model.C_ORDER_NO;
            parameters[2].Value = model.C_CON_NO;
            parameters[3].Value = model.C_STL_GRD;
            parameters[4].Value = model.C_SPEC;
            parameters[5].Value = model.C_FREE1;
            parameters[6].Value = model.C_FREE2;
            parameters[7].Value = model.C_STD_CODE;
            parameters[8].Value = model.C_DESIGN_NO;
            parameters[9].Value = model.N_WGT;
            parameters[10].Value = model.D_NEED_DT;
            parameters[11].Value = model.D_DELIVERY_DT;
            parameters[12].Value = model.D_DT;
            parameters[13].Value = model.N_STATUS;
            parameters[14].Value = model.N_TYPE;
            parameters[15].Value = model.C_EMP_ID;
            parameters[16].Value = model.C_EMP_NAME;
            parameters[17].Value = model.D_MOD_DT;
            parameters[18].Value = model.C_ISSUE_EMP_ID;
            parameters[19].Value = model.C_PRD_EMP_ID;
            parameters[20].Value = model.C_CCM_NO;
            parameters[21].Value = model.C_RH;
            parameters[22].Value = model.C_LF;
            parameters[23].Value = model.C_KP;
            parameters[24].Value = model.N_HL_TIME;
            parameters[25].Value = model.C_HL;
            parameters[26].Value = model.N_DFP_HL_TIME;
            parameters[27].Value = model.C_DFP_HL;
            parameters[28].Value = model.C_XM;
            parameters[29].Value = model.C_ROUTE;
            parameters[30].Value = model.C_MATRL_CODE_SLAB;
            parameters[31].Value = model.C_MATRL_NAME_SLAB;
            parameters[32].Value = model.C_SLAB_SIZE;
            parameters[33].Value = model.N_SLAB_LENGTH;
            parameters[34].Value = model.N_SLAB_PW;
            parameters[35].Value = model.C_MATRL_CODE_KP;
            parameters[36].Value = model.C_MATRL_NAME_KP;
            parameters[37].Value = model.C_KP_SIZE;
            parameters[38].Value = model.N_KP_LENGTH;
            parameters[39].Value = model.N_KP_PW;
            parameters[40].Value = model.N_GROUP;
            parameters[41].Value = model.N_SORT;
            parameters[42].Value = model.C_XC;
            parameters[43].Value = model.C_SL;
            parameters[44].Value = model.C_WL;
            parameters[45].Value = model.N_MACH_WGT_CCM;
            parameters[46].Value = model.N_ZJCLS;
            parameters[47].Value = model.C_BY1;
            parameters[48].Value = model.C_BY2;
            parameters[49].Value = model.C_BY3;
            parameters[50].Value = model.C_BY4;
            parameters[51].Value = model.C_BY5;
            parameters[52].Value = model.C_LGJH;
            parameters[53].Value = model.C_ZL_ID;
            parameters[54].Value = model.C_LF_ID;
            parameters[55].Value = model.C_RH_ID;
            parameters[56].Value = model.N_SLAB_WIDTH;
            parameters[57].Value = model.N_SLAB_THICK;
            parameters[58].Value = model.C_DFP_RZ;
            parameters[59].Value = model.C_RZP_RZ;
            parameters[60].Value = model.C_DFP_YQ;
            parameters[61].Value = model.C_RZP_YQ;
            parameters[62].Value = model.C_XM_YQ;
            parameters[63].Value = model.N_KPJRL_WD;
            parameters[64].Value = model.N_KPJRL_SJ;
            parameters[65].Value = model.N_TSL;
            parameters[66].Value = model.C_CCM_CODE;
            parameters[67].Value = model.C_CCM_DESC;
            parameters[68].Value = model.C_TL;
            parameters[69].Value = model.N_ZJCLS_MIN;
            parameters[70].Value = model.N_ZJCLS_MAX;
            parameters[71].Value = model.C_STL_GRD_TYPE;
            parameters[72].Value = model.C_PROD_NAME;
            parameters[73].Value = model.C_PROD_KIND;

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
        public bool Update(Mod_TPC_PLAN_SMS model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TPC_PLAN_SMS set ");
            strSql.Append("C_ORDER_NO=:C_ORDER_NO,");
            strSql.Append("C_CON_NO=:C_CON_NO,");
            strSql.Append("C_STL_GRD=:C_STL_GRD,");
            strSql.Append("C_SPEC=:C_SPEC,");
            strSql.Append("C_FREE1=:C_FREE1,");
            strSql.Append("C_FREE2=:C_FREE2,");
            strSql.Append("C_STD_CODE=:C_STD_CODE,");
            strSql.Append("C_DESIGN_NO=:C_DESIGN_NO,");
            strSql.Append("N_WGT=:N_WGT,");
            strSql.Append("D_NEED_DT=:D_NEED_DT,");
            strSql.Append("D_DELIVERY_DT=:D_DELIVERY_DT,");
            strSql.Append("D_DT=:D_DT,");
            strSql.Append("N_STATUS=:N_STATUS,");
            strSql.Append("N_TYPE=:N_TYPE,");
            strSql.Append("C_EMP_ID=:C_EMP_ID,");
            strSql.Append("C_EMP_NAME=:C_EMP_NAME,");
            strSql.Append("D_MOD_DT=:D_MOD_DT,");
            strSql.Append("C_ISSUE_EMP_ID=:C_ISSUE_EMP_ID,");
            strSql.Append("C_PRD_EMP_ID=:C_PRD_EMP_ID,");
            strSql.Append("C_CCM_NO=:C_CCM_NO,");
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
            strSql.Append("C_XM_YQ=:C_XM_YQ,");
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
            strSql.Append("C_PROD_KIND=:C_PROD_KIND");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ORDER_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CON_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STL_GRD", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SPEC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_FREE1", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_FREE2", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STD_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_DESIGN_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":D_NEED_DT", OracleDbType.Date),
                    new OracleParameter(":D_DELIVERY_DT", OracleDbType.Date),
                    new OracleParameter(":D_DT", OracleDbType.Date),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,2),
                    new OracleParameter(":N_TYPE", OracleDbType.Decimal,15),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_EMP_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":C_ISSUE_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PRD_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CCM_NO", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_RH", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_LF", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_KP", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_HL_TIME", OracleDbType.Decimal,10),
                    new OracleParameter(":C_HL", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_DFP_HL_TIME", OracleDbType.Decimal,10),
                    new OracleParameter(":C_DFP_HL", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_XM", OracleDbType.Varchar2,500),
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
                    new OracleParameter(":C_XM_YQ", OracleDbType.Varchar2,1000),
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
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.C_ORDER_NO;
            parameters[1].Value = model.C_CON_NO;
            parameters[2].Value = model.C_STL_GRD;
            parameters[3].Value = model.C_SPEC;
            parameters[4].Value = model.C_FREE1;
            parameters[5].Value = model.C_FREE2;
            parameters[6].Value = model.C_STD_CODE;
            parameters[7].Value = model.C_DESIGN_NO;
            parameters[8].Value = model.N_WGT;
            parameters[9].Value = model.D_NEED_DT;
            parameters[10].Value = model.D_DELIVERY_DT;
            parameters[11].Value = model.D_DT;
            parameters[12].Value = model.N_STATUS;
            parameters[13].Value = model.N_TYPE;
            parameters[14].Value = model.C_EMP_ID;
            parameters[15].Value = model.C_EMP_NAME;
            parameters[16].Value = model.D_MOD_DT;
            parameters[17].Value = model.C_ISSUE_EMP_ID;
            parameters[18].Value = model.C_PRD_EMP_ID;
            parameters[19].Value = model.C_CCM_NO;
            parameters[20].Value = model.C_RH;
            parameters[21].Value = model.C_LF;
            parameters[22].Value = model.C_KP;
            parameters[23].Value = model.N_HL_TIME;
            parameters[24].Value = model.C_HL;
            parameters[25].Value = model.N_DFP_HL_TIME;
            parameters[26].Value = model.C_DFP_HL;
            parameters[27].Value = model.C_XM;
            parameters[28].Value = model.C_ROUTE;
            parameters[29].Value = model.C_MATRL_CODE_SLAB;
            parameters[30].Value = model.C_MATRL_NAME_SLAB;
            parameters[31].Value = model.C_SLAB_SIZE;
            parameters[32].Value = model.N_SLAB_LENGTH;
            parameters[33].Value = model.N_SLAB_PW;
            parameters[34].Value = model.C_MATRL_CODE_KP;
            parameters[35].Value = model.C_MATRL_NAME_KP;
            parameters[36].Value = model.C_KP_SIZE;
            parameters[37].Value = model.N_KP_LENGTH;
            parameters[38].Value = model.N_KP_PW;
            parameters[39].Value = model.N_GROUP;
            parameters[40].Value = model.N_SORT;
            parameters[41].Value = model.C_XC;
            parameters[42].Value = model.C_SL;
            parameters[43].Value = model.C_WL;
            parameters[44].Value = model.N_MACH_WGT_CCM;
            parameters[45].Value = model.N_ZJCLS;
            parameters[46].Value = model.C_BY1;
            parameters[47].Value = model.C_BY2;
            parameters[48].Value = model.C_BY3;
            parameters[49].Value = model.C_BY4;
            parameters[50].Value = model.C_BY5;
            parameters[51].Value = model.C_LGJH;
            parameters[52].Value = model.C_ZL_ID;
            parameters[53].Value = model.C_LF_ID;
            parameters[54].Value = model.C_RH_ID;
            parameters[55].Value = model.N_SLAB_WIDTH;
            parameters[56].Value = model.N_SLAB_THICK;
            parameters[57].Value = model.C_DFP_RZ;
            parameters[58].Value = model.C_RZP_RZ;
            parameters[59].Value = model.C_DFP_YQ;
            parameters[60].Value = model.C_RZP_YQ;
            parameters[61].Value = model.C_XM_YQ;
            parameters[62].Value = model.N_KPJRL_WD;
            parameters[63].Value = model.N_KPJRL_SJ;
            parameters[64].Value = model.N_TSL;
            parameters[65].Value = model.C_CCM_CODE;
            parameters[66].Value = model.C_CCM_DESC;
            parameters[67].Value = model.C_TL;
            parameters[68].Value = model.N_ZJCLS_MIN;
            parameters[69].Value = model.N_ZJCLS_MAX;
            parameters[70].Value = model.C_STL_GRD_TYPE;
            parameters[71].Value = model.C_PROD_NAME;
            parameters[72].Value = model.C_PROD_KIND;
            parameters[73].Value = model.C_ID;

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
            strSql.Append("delete from TPC_PLAN_SMS ");
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
            strSql.Append("delete from TPC_PLAN_SMS ");
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
        public Mod_TPC_PLAN_SMS GetModel(string C_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_ORDER_NO,C_CON_NO,C_STL_GRD,C_SPEC,C_FREE1,C_FREE2,C_STD_CODE,C_DESIGN_NO,N_WGT,D_NEED_DT,D_DELIVERY_DT,D_DT,N_STATUS,N_TYPE,C_EMP_ID,C_EMP_NAME,D_MOD_DT,C_ISSUE_EMP_ID,C_PRD_EMP_ID,C_CCM_NO,C_RH,C_LF,C_KP,N_HL_TIME,C_HL,N_DFP_HL_TIME,C_DFP_HL,C_XM,C_ROUTE,C_MATRL_CODE_SLAB,C_MATRL_NAME_SLAB,C_SLAB_SIZE,N_SLAB_LENGTH,N_SLAB_PW,C_MATRL_CODE_KP,C_MATRL_NAME_KP,C_KP_SIZE,N_KP_LENGTH,N_KP_PW,N_GROUP,N_SORT,C_XC,C_SL,C_WL,N_MACH_WGT_CCM,N_ZJCLS,C_BY1,C_BY2,C_BY3,C_BY4,C_BY5,C_LGJH,C_ZL_ID,C_LF_ID,C_RH_ID,N_SLAB_WIDTH,N_SLAB_THICK,C_DFP_RZ,C_RZP_RZ,C_DFP_YQ,C_RZP_YQ,C_XM_YQ,N_KPJRL_WD,N_KPJRL_SJ,N_TSL,C_CCM_CODE,C_CCM_DESC,C_TL,N_ZJCLS_MIN,N_ZJCLS_MAX,C_STL_GRD_TYPE,C_PROD_NAME,C_PROD_KIND from TPC_PLAN_SMS ");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)         };
            parameters[0].Value = C_ID;

            Mod_TPC_PLAN_SMS model = new Mod_TPC_PLAN_SMS();
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
        public Mod_TPC_PLAN_SMS DataRowToModel(DataRow row)
        {
            Mod_TPC_PLAN_SMS model = new Mod_TPC_PLAN_SMS();
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
                if (row["C_STL_GRD"] != null)
                {
                    model.C_STL_GRD = row["C_STL_GRD"].ToString();
                }
                if (row["C_SPEC"] != null)
                {
                    model.C_SPEC = row["C_SPEC"].ToString();
                }
                if (row["C_FREE1"] != null)
                {
                    model.C_FREE1 = row["C_FREE1"].ToString();
                }
                if (row["C_FREE2"] != null)
                {
                    model.C_FREE2 = row["C_FREE2"].ToString();
                }
                if (row["C_STD_CODE"] != null)
                {
                    model.C_STD_CODE = row["C_STD_CODE"].ToString();
                }
                if (row["C_DESIGN_NO"] != null)
                {
                    model.C_DESIGN_NO = row["C_DESIGN_NO"].ToString();
                }
                if (row["N_WGT"] != null && row["N_WGT"].ToString() != "")
                {
                    model.N_WGT = decimal.Parse(row["N_WGT"].ToString());
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
                if (row["C_ISSUE_EMP_ID"] != null)
                {
                    model.C_ISSUE_EMP_ID = row["C_ISSUE_EMP_ID"].ToString();
                }
                if (row["C_PRD_EMP_ID"] != null)
                {
                    model.C_PRD_EMP_ID = row["C_PRD_EMP_ID"].ToString();
                }
                if (row["C_CCM_NO"] != null)
                {
                    model.C_CCM_NO = row["C_CCM_NO"].ToString();
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
                if (row["C_XM_YQ"] != null)
                {
                    model.C_XM_YQ = row["C_XM_YQ"].ToString();
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
            }
            return model;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select *  ");
            strSql.Append(" FROM TPC_PLAN_SMS ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 查询炼钢计划
        /// </summary>
        /// <param name="C_CCM_NO">连铸主键</param>
        /// <param name="C_STL_GRD">钢种</param>
        /// <param name="C_STD_CODE">执行标准</param>
        /// <param name="N_STATUS">订单状态</param>
        /// <param name="Dtb">订单日期始</param>
        /// <param name="Dte">订单日期终</param>
        /// <returns></returns>
        public DataSet GetListByWhere(string C_CCM_NO, string C_STL_GRD, string C_STD_CODE, int N_STATUS, DateTime? Dtb, DateTime? Dte)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select *  ");
            strSql.Append(" FROM TPC_PLAN_SMS t  where  N_STATUS =" + N_STATUS);
            if (C_CCM_NO.Trim() != "")
            {
                strSql.Append(" AND  C_CCM_NO ='" + C_CCM_NO + "'");
            }
            if (C_STL_GRD.Trim() != "")
            {
                strSql.Append(" AND  C_STL_GRD ='" + C_STL_GRD + "'");
            }
            if (C_STD_CODE.Trim() != "")
            {
                strSql.Append(" AND  C_STD_CODE ='" + C_STD_CODE + "'");
            }
            if (Dtb != null)
            {
                strSql.Append(" AND  D_DT >=to_date('" + Dtb.ToString() + "','yyyy-mm-dd hh24:mi:ss')");
            }
            if (Dte != null)
            {
                strSql.Append(" AND  D_DT <=to_date('" + Dte.ToString() + "','yyyy-mm-dd hh24:mi:ss')");
            }

            strSql.Append("  ORDER BY  C_CCM_NO,C_STL_GRD,C_STD_CODE  ");
            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM TPC_PLAN_SMS ");
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



        #endregion  BasicMethod
        #region  ExtensionMethod



        /// <summary>
        /// 查询待排炼钢计划分析
        /// </summary>
        ///  <param name="d_dtf">订单日期</param>
        ///   <param name="d_dte">订单日期</param>
        /// <param name="C_CCM_NO">连铸主键</param>
        /// <param name="C_STL_GRD">钢种</param>
        /// <param name="C_STD_CODE">执行标准</param>
        /// <returns>炼钢计划</returns>
        public DataTable GetLgPlan(string d_dtf, string d_dte, string C_CCM_NO, string C_STL_GRD, string C_STD_CODE, string C_BY4)
        {

            DateTime dt1 = System.DateTime.Now;
            DateTime dt = DateTime.Now.AddDays(1 - DateTime.Now.Day).Date;//本月第一天

            int dayC = (dt1 - dt).Days;
            if (dayC > 10)
            {
                d_dtf = DateTime.Now.AddDays(1 - DateTime.Now.Day).Date.ToShortDateString();
            }
            else
            {
                d_dtf = DateTime.Now.AddDays(1 - DateTime.Now.Day).Date.AddDays(-11).ToShortDateString();
            }

            string sql1 = @"SELECT (SELECT SUM(A.N_WGT)
          FROM TSC_SLAB_MAIN A
         WHERE A.C_STL_GRD = M.C_STL_GRD_SLAB
           AND A.C_STD_CODE = M.C_STD_CODE_SLAB
           AND A.C_MOVE_TYPE IN ('E','M','DZ','NP','R','DX')) N_SLAB_KC,
       (SELECT SUM(A.N_SLAB_WGT)
          FROM TSP_PLAN_SMS A
         WHERE A.N_CREAT_PLAN < 4 and a.N_STATUS=1
           AND A.C_STL_GRD = M.C_STL_GRD_SLAB
           AND A.C_STD_CODE = M.C_STD_CODE_SLAB) N_SLAB_WWC,
       M.*
  FROM(SELECT SUM(T.N_WGT) N_WGT,
               SUM(NVL(T.N_PROD_WGT, 0)) N_PROD_WGT,
               T.C_MATRL_CODE_SLAB,
               T.C_MATRL_NAME_SLAB,
               T.C_SLAB_SIZE,
               T.N_SLAB_LENGTH,
                MAX( T.N_SLAB_PW) N_SLAB_PW,
               T.C_ROUTE,
               T.C_STL_GRD_SLAB,
               T.C_STD_CODE_SLAB,
               T.C_MATRL_CODE_KP,
               T.C_MATRL_NAME_KP,
               T.C_KP_SIZE,
               T.N_KP_LENGTH,
              MAX( T.N_KP_PW) N_KP_PW,
               T.N_GROUP,
               T.C_BY1,
              MAX( T.C_BY2) C_BY2,
               T.C_CCM_CODE,
               T.C_CCM_DESC,
               MAX(T.N_ZJCLS) N_ZJCLS,
               T.C_STL_GRD_TYPE,
               T.C_PROD_NAME,
               T.C_PROD_KIND,
              -- T.N_TYPE,
               T.C_CCM_ID
          FROM TRP_PLAN_ROLL T
         WHERE  T.N_STATUS IN(0, 1) AND T.C_MATRL_NAME_SLAB NOT LIKE '%来料%'
           AND T.D_DT >= TO_DATE('" + d_dtf + "', 'yyyy-mm-dd hh24:mi:ss') ";
            //  sql1 = sql1 + @" AND T.D_DT <= TO_DATE('" + d_dte + "', 'yyyy-mm-dd hh24:mi:ss')";

            if (C_CCM_NO.Trim() != "")
            {
                sql1 = sql1 + @" AND T.C_CCM_ID='" + C_CCM_NO + "'";
            }
            if (C_STL_GRD.Trim() != "")
            {
                sql1 = sql1 + @" AND T.C_STL_GRD_SLAB='" + C_STL_GRD + "'";
            }
            if (C_STD_CODE.Trim() != "")
            {
                sql1 = sql1 + @" AND T.C_STD_CODE_SLAB='" + C_STD_CODE + "'";
            }

            if (C_BY4.Trim() != "")
            {
                sql1 = sql1 + @" AND T.C_BY4='" + C_BY4 + "'";
            }

            sql1 = sql1 + @"   GROUP BY 
                  T.C_MATRL_CODE_SLAB,
                  T.C_MATRL_NAME_SLAB,
                  T.C_SLAB_SIZE,
                  T.N_SLAB_LENGTH,
                
                  T.C_ROUTE,
                  T.C_STL_GRD_SLAB,
                  T.C_STD_CODE_SLAB,
                  T.C_MATRL_CODE_KP,
                  T.C_MATRL_NAME_KP,
                  T.C_KP_SIZE,
                  T.N_KP_LENGTH,
                 
                  T.N_GROUP,
                  T.C_BY1,
                 -- T.C_BY2,
                  T.C_CCM_CODE,
                  T.C_CCM_DESC,
                  T.C_STL_GRD_TYPE,
                  T.C_PROD_NAME,
                  T.C_PROD_KIND,
                 -- T.N_TYPE,
                  T.C_CCM_ID,
                  T.C_CCM_CODE,
                  T.C_CCM_DESC
         ORDER BY T.N_GROUP, T.C_STL_GRD_SLAB, T.C_STD_CODE_SLAB ) M ";

            //           string sql = @"SELECT t.N_GROUP,
            //      t.C_CCM_NO,
            //      t.C_CCM_CODE,
            //      t.C_CCM_DESC,
            //      t.C_STL_GRD,
            //      t.C_STD_CODE,
            //     SUM( t.N_WGT) N_WGT,
            //     SUM( t.N_ROLL_LEFT) N_ROLL_LEFT,
            //      SUM(t.N_LG_LEFT) N_LG_LEFT,
            //      SUM(t.N_KC_WGT) N_KC_WGT,
            //      t.C_SLAB_TYPE,
            //      t.C_RH,
            //      t.N_DFP_HL_TIME,
            //      t.C_DFP_HL,
            //      t.N_HL_TIME,
            //      t.C_HL,
            //     SUM( t.N_ZL_WGT) N_ZL_WGT,
            //     SUM( t.N_YP_WGT) N_YP_WGT,
            //     SUM( t.N_ORDER_LS)N_ORDER_LS,
            //     SUM( t.N_YP_LS) N_YP_LS,
            //      t.C_XM,
            //      t.C_TL,
            //      t.C_SL,
            //      t.C_BY1,
            //      t.C_WL,
            //      t.C_BY2,
            //      t.C_PROD_NAME,
            //      t.C_PROD_KIND,
            //      t.C_STL_GRD_TYPE,
            //       MIN(T.MIND_DELIVERY_DT) MIND_DELIVERY_DT,
            //      MAX(T.MAXD_DELIVERY_DT) MIND_DELIVERY_DT,
            //      t.C_BY3,
            //      t.N_ZJCLS,
            //      t.N_ZJCLS_MIN,
            //      t.N_ZJCLS_MAX,
            //      t.N_MACH_WGT_CCM,
            //      t.C_MATRL_CODE_SLAB,
            //      t.C_MATRL_NAME_SLAB,
            //      t.C_SLAB_SIZE,
            //      t.N_SLAB_LENGTH,
            //      t.N_SLAB_PW,
            //      t.C_MATRL_CODE_KP,
            //      t.C_MATRL_NAME_KP,
            //      t.C_KP_SIZE,
            //      t.N_KP_LENGTH,
            //      t.N_KP_PW,MIN(t.D_DT)D_DT
            // FROM V_LGJC_PC T WHERE 1=1  AND D_DT >=TO_DATE('" + d_dtf + "','yyyy-mm-dd hh24:mi:ss') AND D_DT <=TO_DATE('" + d_dte + "','yyyy-mm-dd hh24:mi:ss') ";
            //           if (C_CCM_NO.Trim() != "")
            //           {
            //               sql = sql + " AND C_CCM_NO='" + C_CCM_NO + "' ";
            //           }
            //           if (C_STL_GRD.Trim() != "")
            //           {
            //               sql = sql + " AND C_STL_GRD LIKE '%" + C_STL_GRD + "%'";
            //           }
            //           if (C_STD_CODE.Trim() != "")
            //           {
            //               sql = sql + "  AND C_STD_CODE LIKE '%" + C_STD_CODE + "%' ";
            //           }

            //           sql = sql + @" GROUP BY t.N_GROUP,
            //      t.C_CCM_NO,
            //      t.C_CCM_CODE,
            //t.C_CCM_DESC,
            //      t.C_STL_GRD,
            //      t.C_STD_CODE,

            //      t.C_SLAB_TYPE,
            //      t.C_RH,
            //      t.N_DFP_HL_TIME,
            //      t.C_DFP_HL,
            //      t.N_HL_TIME,
            //      t.C_HL,

            //      t.C_XM,
            //      t.C_TL,
            //      t.C_SL,
            //      t.C_BY1,
            //      t.C_WL,
            //      t.C_BY2,
            //      t.C_PROD_NAME,
            //      t.C_PROD_KIND,
            //      t.C_STL_GRD_TYPE,
            //      t.C_BY3,
            //      t.N_ZJCLS,
            //      t.N_ZJCLS_MIN,
            //      t.N_ZJCLS_MAX,
            //      t.N_MACH_WGT_CCM,
            //      t.C_MATRL_CODE_SLAB,
            //      t.C_MATRL_NAME_SLAB,
            //      t.C_SLAB_SIZE,
            //      t.N_SLAB_LENGTH,
            //      t.N_SLAB_PW,
            //      t.C_MATRL_CODE_KP,
            //      t.C_MATRL_NAME_KP,
            //      t.C_KP_SIZE,
            //      t.N_KP_LENGTH,
            //      t.N_KP_PW ORDER BY T.C_CCM_NO, T.N_GROUP, T.C_STL_GRD, T.C_STD_CODE ";
            return DbHelperOra.Query(sql1).Tables[0];
        }

        /// <summary>
        /// 炼钢计划手动调整连铸
        /// </summary>
        /// <param name="C_STL_GRD">钢种</param>
        /// <param name="C_STD_CODE">执行标准</param>
        /// <param name="C_CCM_ID">连铸</param>
        /// <returns>执行结果</returns>
        public string GetCcm(string C_STL_GRD, string C_STD_CODE, string C_CCM_ID)
        {
            OracleParameter[] parameters = {
            new OracleParameter("P_MSG", OracleDbType.Varchar2,500),
             new OracleParameter("P_STL_GRD", OracleDbType.Varchar2,50),
              new OracleParameter("P_STD_CODE", OracleDbType.Varchar2,50),
              new OracleParameter("P_CCM_ID", OracleDbType.Varchar2,50) };
            parameters[0].Value = "0";
            parameters[1].Value = C_STL_GRD;
            parameters[2].Value = C_STD_CODE;
            parameters[3].Value = C_CCM_ID;
            return DbHelperOra.RunProcedureOut("PKG_UPDATE_SORT.P_LG_PLAN_CCM", parameters);
        }




        /// <summary>
        /// 生成浇次计划
        /// </summary>
        /// <returns>成功1失败0</returns>
        public string P_JCJH(DateTime P_DTFROM, DateTime P_DTEND)
        {
            OracleParameter[] parameters = {
            new OracleParameter("P_MSG", OracleDbType.Varchar2,500),
                new OracleParameter("P_DTFROM", OracleDbType.Date),
                new OracleParameter("P_DTEND", OracleDbType.Date)             };
            parameters[0].Value = "0";
            parameters[1].Value = P_DTFROM;
            parameters[2].Value = P_DTEND;
            return DbHelperOra.RunProcedureOut("PKG_LG_JCJH.P_JCJH", parameters);
        }

        /// <summary>
        /// 将选中的计划重新分组
        /// </summary>
        /// <param name="N_GROUP">混浇组号</param>
        /// <param name="C_STL_GRD">钢种</param>
        /// <param name="C_STD_CODE">执行标准</param>
        /// <returns></returns>
        public int UpdateGroup(int N_GROUP, string C_STL_GRD, string C_STD_CODE)
        {
            string sql = "UPDATE TRP_PLAN_ROLL T SET T.N_GROUP= " + N_GROUP + "  WHERE T.C_STL_GRD_SLAB='" + C_STL_GRD + "' AND T.C_STD_CODE_SLAB ='" + C_STD_CODE + "' AND T.N_STATUS=0";
            return DbHelperOra.ExecuteSql(sql);

        }

        /// <summary>
        /// 按连铸机将计划进行排产
        /// </summary>
        /// <param name="strCcm">连铸机主键</param>
        public int DownPlanByCCM(string strCcm)
        {
            string sql = "UPDATE TPC_PLAN_SMS A   SET A.N_STATUS = 1 WHERE A.N_STATUS = 0   AND A.C_CCM_NO = '" + strCcm + "'";
            return DbHelperOra.ExecuteSql(sql);
        }
        /// <summary>
        /// 查询开坯修磨计划时间
        /// </summary>
        /// <param name="stove">连铸机主键</param>
        public DataSet GetQuery()
        {
            string sql = "SELECT T.C_STL_GRD,T.C_STD_CODE,T.C_CCM_DESC,T.N_SLAB_WGT,T.C_PROD_NAME,T.C_MATRL_NO,T.C_MATRL_NAME,T.C_STOVE_NO,T.D_P_START_TIME,T.D_P_END_TIME,T.D_KP_START_TIME,T.D_KP_END_TIME,T.D_XM_START_TIME,T.D_XM_END_TIME   FROM TSP_PLAN_SMS T WHERE T.C_STOVE_NO IS NULL AND N_STATUS = 1 UNION ALL SELECT T.C_STL_GRD,T.C_STD_CODE,T.C_CCM_DESC,T.N_SLAB_WGT,T.C_PROD_NAME,T.C_MATRL_NO,T.C_MATRL_NAME,T.C_STOVE_NO,T.D_P_START_TIME,T.D_P_END_TIME,T.D_KP_START_TIME,T.D_KP_END_TIME,T.D_XM_START_TIME,T.D_XM_END_TIME FROM TSP_PLAN_SMS T WHERE T.C_STOVE_NO IN  (SELECT C_STOVE FROM TSC_SLAB_MAIN WHERE C_MOVE_TYPE IN ('E', 'M', 'DZ', 'NP', 'R', 'DX')) AND T.N_STATUS = 1  ORDER BY D_P_START_TIME";
            return DbHelperOra.Query(sql);
        }
        #endregion  ExtensionMethod


        #region 炼钢计划排产


        /// <summary>
        /// 查询待排炼钢计划分析
        /// </summary>
        ///  <param name="d_dtf">订单日期</param>
        ///   <param name="d_dte">订单日期</param>
        /// <param name="C_CCM_NO">连铸主键</param>
        /// <param name="C_STL_GRD">钢种</param>
        /// <param name="C_STD_CODE">执行标准</param>
        /// <returns>炼钢计划</returns>
        public DataTable GetLgJH(string d_dtf, string d_dte, string C_CCM_NO, string C_STL_GRD, string C_STD_CODE)
        {
            string sql1 = @"SELECT (SELECT SUM(A.N_WGT)
          FROM TSC_SLAB_MAIN A
         WHERE A.C_STL_GRD = M.C_STL_GRD_SLAB
           AND A.C_STD_CODE = M.C_STD_CODE_SLAB
           AND A.C_MOVE_TYPE IN('E', 'M')) N_SLAB_KC,
       (SELECT SUM(A.N_SLAB_WGT)
          FROM TSP_PLAN_SMS A
         WHERE A.N_CREAT_PLAN < 4 and a.N_STATUS=1
           AND A.C_STL_GRD = M.C_STL_GRD_SLAB
           AND A.C_STD_CODE = M.C_STD_CODE_SLAB) N_SLAB_WWC,
       M.*
  FROM(SELECT SUM(T.N_WGT) N_WGT,
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
               T.C_CCM_CODE,
               T.C_CCM_DESC,
               MAX(T.N_ZJCLS) N_ZJCLS,
               T.C_STL_GRD_TYPE,
               T.C_PROD_NAME,
               T.C_PROD_KIND,
               T.N_TYPE,
               T.C_CCM_ID
          FROM TRP_PLAN_ROLL T
         WHERE T.N_STATUS IN(0, 1)
           AND T.D_DT >= TO_DATE('2019-01-01', 'yyyy-mm-dd hh24:mi:ss')
           AND T.D_DT <= TO_DATE('2019-01-01', 'yyyy-mm-dd hh24:mi:ss')
         GROUP BY T.C_STL_GRD,
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
                  T.C_CCM_CODE,
                  T.C_CCM_DESC,
                  T.C_STL_GRD_TYPE,
                  T.C_PROD_NAME,
                  T.C_PROD_KIND,
                  T.N_TYPE,
                  T.C_CCM_ID,
                  T.C_CCM_CODE,
                  T.C_CCM_DESC
         ORDER BY T.N_GROUP, T.C_STL_GRD, T.C_STD_CODE) M";
            return DbHelperOra.Query(sql1).Tables[0];

        }


        #endregion

        #region 甘特图
        /// <summary>
        /// 获取炼钢计划任务
        /// </summary>
        /// <returns></returns>
        public DataSet GetTaskPlan()
        {
            DataSet ds = new DataSet();
            string cdSql = @"SELECT T.* FROM TSP_CAST_CD_LOG T  WHERE T.C_TYPE='计划存档' ORDER BY T.D_MOD_DT DESC ";
            var cd = DbHelperOra.Query(cdSql).Tables[0];
            if (cd != null && cd.Rows.Count > 0)
            {
                var cdRow = cd.Rows[0];
                var id = cdRow["C_ID"].ToString();
                string planSql = " SELECT * FROM ( SELECT t.C_CCM_ID ID,  (SELECT TT.C_STA_DESC FROM TB_STA TT WHERE TT.C_ID = T.C_CCM_ID) NAME  FROM TSP_CAST_PLAN_LOG t WHERE T.C_LOG_ID = '" + id + "' GROUP BY  T.C_CCM_ID )M ORDER BY M.NAME ";
                var dt = DbHelperOra.Query(planSql).Tables[0];
                dt.TableName = "1";
                ds.Tables.Add(dt.Copy());

                string planDetailsSql = @" SELECT T.*,T.ROWID FROM  TSP_PLAN_SMS_LOG T WHERE T.C_LOG_ID='" + id + "' and t.d_p_start_time is not null and t.d_p_end_time is not null ";
                var dt2 = DbHelperOra.Query(planDetailsSql).Tables[0];
                dt2.TableName = "2";
                ds.Tables.Add(dt2.Copy());

                DateTime start = DateTime.Parse(cd.Rows[0]["D_MOD_DT"].ToString()).AddDays(-1);
                string factSql = " SELECT * FROM TSP_PLAN_SMS T WHERE T.d_p_Start_Time>= to_date('" + start.ToString() + "','yyyy-MM-dd HH24:mi:ss')     AND T.N_CREAT_PLAN=4 AND T.N_STATUS=1 AND d_p_Start_Time IS NOT NULL  ";
                var dt3 = DbHelperOra.Query(factSql).Tables[0];
                dt3.TableName = "3";
                ds.Tables.Add(dt3.Copy());
            }
            return ds;
        }

        /// <summary>
        /// 获取炼钢计划任务
        /// </summary>
        /// <returns></returns>
        public DataSet GetTaskPlans()
        {
            DataSet ds = new DataSet();
            string cdSql = @"SELECT T.* FROM TSP_CAST_CD_LOG T  WHERE T.C_TYPE='计划存档' ORDER BY T.D_MOD_DT DESC ";
            var cd = DbHelperOra.Query(cdSql).Tables[0];
            if (cd != null && cd.Rows.Count > 0)
            {
                var cdRow = cd.Rows[0];
                var id = cdRow["C_ID"].ToString();
                string planSql = " SELECT * FROM ( SELECT t.C_CCM_ID ID,  (SELECT TT.C_STA_DESC FROM TB_STA TT WHERE TT.C_ID = T.C_CCM_ID) NAME  FROM TSP_CAST_PLAN_LOG t WHERE T.C_LOG_ID = '" + id + "' GROUP BY  T.C_CCM_ID )M ORDER BY M.NAME ";
                var dt = DbHelperOra.Query(planSql).Tables[0];
                dt.TableName = "1";
                ds.Tables.Add(dt.Copy());

                string planDetailsSql = @" SELECT T.*,T.ROWID FROM  tsp_cast_plan_log T WHERE T.C_LOG_ID='" + id + "' and t.d_p_start_time is not null and t.d_p_end_time is not null ";
                var dt2 = DbHelperOra.Query(planDetailsSql).Tables[0];
                dt2.TableName = "2";
                ds.Tables.Add(dt2.Copy());

                DateTime start = DateTime.Parse(cd.Rows[0]["D_MOD_DT"].ToString()).AddDays(-1);
                string factSql = " SELECT MAX(t.c_stl_grd)||'['||COUNT(1)||']' C_REMARK,MIN(t.d_p_start_time) d_p_start_time ,MAX(t.d_p_end_time) d_p_end_time,MAX(t.c_ccm_id)c_ccm_id FROM TSP_PLAN_SMS T WHERE T.d_p_Start_Time>= to_date('" + start.ToString() + "','yyyy-MM-dd HH24:mi:ss') AND T.N_CREAT_PLAN=4 AND T.N_STATUS=1  GROUP BY t.c_fk ";
                var dt3 = DbHelperOra.Query(factSql).Tables[0];
                dt3.TableName = "3";
                ds.Tables.Add(dt3.Copy());
            }
            return ds;
        }
        #endregion

    }
}

