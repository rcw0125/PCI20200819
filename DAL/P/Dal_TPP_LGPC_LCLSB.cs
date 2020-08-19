using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;
namespace DAL
{
    /// <summary>
    /// 数据访问类:TPP_LGPC_LCLSB
    /// </summary>
    public partial class Dal_TPP_LGPC_LCLSB
    {
        public Dal_TPP_LGPC_LCLSB()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string C_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TPP_LGPC_LCLSB");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)            };
            parameters[0].Value = C_ID;

            return DbHelperOra.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Mod_TPP_LGPC_LCLSB model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TPP_LGPC_LCLSB(");
            strSql.Append("C_ID,C_FK,C_ORDER_NO,C_DESIGN_NO,N_SLAB_WGT,C_CTRL_NO,C_CCM_ID,C_CCM_DESC,C_PROD_NAME,C_STL_GRD,C_SPEC_CODE,C_LENGTH,C_MATRL_NO,C_MATRL_NAME,C_SLAB_SIZE,C_SLAB_LENGTH,C_STATE,C_STD_CODE,C_INITIALIZE_ITEM_ID,D_P_START_TIME,D_P_END_TIME,N_PROD_TIME,N_SORT,C_CAST_NO,N_STATUS,C_EMP_ID,D_MOD_DT,C_REMARK,N_CREAT_PLAN,N_CREAT_ZG_PLAN,N_PRODUCE_TIME,C_ZL_ID,C_LF_ID,C_RH_ID,C_LGJH,C_QUA,D_ARRIVE_ZG_TIME,C_BY1,C_BY2,C_BY3,C_RH,C_DFP_HL,C_HL,C_XM,D_DFPHL_START_TIME,D_DFPHL_END_TIME,D_KP_START_TIME,D_KP_END_TIME,D_HL_START_TIME,D_HL_END_TIME,D_PLAN_KY_TIME,C_PLAN_ROLL,D_ZZ_START_TIME,D_ZZ_END_TIME,D_XM_START_TIME,D_XM_END_TIME,C_STOVE_NO,D_DFPHL_START_TIME_SJ,D_DFPHL_END_TIME_SJ,D_KP_START_TIME_SJ,D_KP_END_TIME_SJ,D_HL_START_TIME_SJ,D_HL_END_TIME_SJ,D_XM_START_TIME_SJ,D_XM_END_TIME_SJ,N_SJ_WGT,D_START_TIME_SJ,D_END_TIME_SJ,N_DFP_HL_TIME,N_HL_TIME,C_ROUTE,N_SLAB_PW,C_MATRL_CODE_KP,C_MATRL_NAME_KP,C_KP_SIZE,N_KP_LENGTH,N_KP_PW,N_USE_WGT,D_USE_START_TIME_SJ,D_USE_END_TIME_SJ,D_CAN_USE_TIME,N_RH_NUM,N_KP_WGT,N_XM_WGT,C_DFP_RZ,C_RZP_RZ,C_DFP_YQ,C_RZP_YQ,C_STL_GRD_TYPE,C_PROD_KIND,C_TL,N_JSCN,C_FREE2,N_GROUP,N_ZJCLS,N_ZJCLS_MIN,N_ZJCLS_MAX,C_SL,C_WL,C_SLAB_TYPE,N_JC_SORT,C_FREE1)");
            strSql.Append(" values (");
            strSql.Append(":C_ID,:C_FK,:C_ORDER_NO,:C_DESIGN_NO,:N_SLAB_WGT,:C_CTRL_NO,:C_CCM_ID,:C_CCM_DESC,:C_PROD_NAME,:C_STL_GRD,:C_SPEC_CODE,:C_LENGTH,:C_MATRL_NO,:C_MATRL_NAME,:C_SLAB_SIZE,:C_SLAB_LENGTH,:C_STATE,:C_STD_CODE,:C_INITIALIZE_ITEM_ID,:D_P_START_TIME,:D_P_END_TIME,:N_PROD_TIME,:N_SORT,:C_CAST_NO,:N_STATUS,:C_EMP_ID,:D_MOD_DT,:C_REMARK,:N_CREAT_PLAN,:N_CREAT_ZG_PLAN,:N_PRODUCE_TIME,:C_ZL_ID,:C_LF_ID,:C_RH_ID,:C_LGJH,:C_QUA,:D_ARRIVE_ZG_TIME,:C_BY1,:C_BY2,:C_BY3,:C_RH,:C_DFP_HL,:C_HL,:C_XM,:D_DFPHL_START_TIME,:D_DFPHL_END_TIME,:D_KP_START_TIME,:D_KP_END_TIME,:D_HL_START_TIME,:D_HL_END_TIME,:D_PLAN_KY_TIME,:C_PLAN_ROLL,:D_ZZ_START_TIME,:D_ZZ_END_TIME,:D_XM_START_TIME,:D_XM_END_TIME,:C_STOVE_NO,:D_DFPHL_START_TIME_SJ,:D_DFPHL_END_TIME_SJ,:D_KP_START_TIME_SJ,:D_KP_END_TIME_SJ,:D_HL_START_TIME_SJ,:D_HL_END_TIME_SJ,:D_XM_START_TIME_SJ,:D_XM_END_TIME_SJ,:N_SJ_WGT,:D_START_TIME_SJ,:D_END_TIME_SJ,:N_DFP_HL_TIME,:N_HL_TIME,:C_ROUTE,:N_SLAB_PW,:C_MATRL_CODE_KP,:C_MATRL_NAME_KP,:C_KP_SIZE,:N_KP_LENGTH,:N_KP_PW,:N_USE_WGT,:D_USE_START_TIME_SJ,:D_USE_END_TIME_SJ,:D_CAN_USE_TIME,:N_RH_NUM,:N_KP_WGT,:N_XM_WGT,:C_DFP_RZ,:C_RZP_RZ,:C_DFP_YQ,:C_RZP_YQ,:C_STL_GRD_TYPE,:C_PROD_KIND,:C_TL,:N_JSCN,:C_FREE2,:N_GROUP,:N_ZJCLS,:N_ZJCLS_MIN,:N_ZJCLS_MAX,:C_SL,:C_WL,:C_SLAB_TYPE,:N_JC_SORT,:C_FREE1)");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_FK", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ORDER_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_DESIGN_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_SLAB_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":C_CTRL_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CCM_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CCM_DESC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PROD_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STL_GRD", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SPEC_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_LENGTH", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MATRL_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MATRL_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SLAB_SIZE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SLAB_LENGTH", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STATE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STD_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_INITIALIZE_ITEM_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_P_START_TIME", OracleDbType.Date),
                    new OracleParameter(":D_P_END_TIME", OracleDbType.Date),
                    new OracleParameter(":N_PROD_TIME", OracleDbType.Decimal,5),
                    new OracleParameter(":N_SORT", OracleDbType.Decimal,20),
                    new OracleParameter(":C_CAST_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
                    new OracleParameter(":N_CREAT_PLAN", OracleDbType.Decimal,5),
                    new OracleParameter(":N_CREAT_ZG_PLAN", OracleDbType.Decimal,5),
                    new OracleParameter(":N_PRODUCE_TIME", OracleDbType.Decimal,5),
                    new OracleParameter(":C_ZL_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_LF_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_RH_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_LGJH", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_QUA", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_ARRIVE_ZG_TIME", OracleDbType.Date),
                    new OracleParameter(":C_BY1", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_BY2", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_BY3", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_RH", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_DFP_HL", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_HL", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_XM", OracleDbType.Varchar2,100),
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
                    new OracleParameter(":C_STOVE_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_DFPHL_START_TIME_SJ", OracleDbType.Date),
                    new OracleParameter(":D_DFPHL_END_TIME_SJ", OracleDbType.Date),
                    new OracleParameter(":D_KP_START_TIME_SJ", OracleDbType.Date),
                    new OracleParameter(":D_KP_END_TIME_SJ", OracleDbType.Date),
                    new OracleParameter(":D_HL_START_TIME_SJ", OracleDbType.Date),
                    new OracleParameter(":D_HL_END_TIME_SJ", OracleDbType.Date),
                    new OracleParameter(":D_XM_START_TIME_SJ", OracleDbType.Date),
                    new OracleParameter(":D_XM_END_TIME_SJ", OracleDbType.Date),
                    new OracleParameter(":N_SJ_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":D_START_TIME_SJ", OracleDbType.Date),
                    new OracleParameter(":D_END_TIME_SJ", OracleDbType.Date),
                    new OracleParameter(":N_DFP_HL_TIME", OracleDbType.Decimal,10),
                    new OracleParameter(":N_HL_TIME", OracleDbType.Decimal,10),
                    new OracleParameter(":C_ROUTE", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_SLAB_PW", OracleDbType.Decimal,15),
                    new OracleParameter(":C_MATRL_CODE_KP", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MATRL_NAME_KP", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_KP_SIZE", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_KP_LENGTH", OracleDbType.Decimal,15),
                    new OracleParameter(":N_KP_PW", OracleDbType.Decimal,15),
                    new OracleParameter(":N_USE_WGT", OracleDbType.Decimal,5),
                    new OracleParameter(":D_USE_START_TIME_SJ", OracleDbType.Date),
                    new OracleParameter(":D_USE_END_TIME_SJ", OracleDbType.Date),
                    new OracleParameter(":D_CAN_USE_TIME", OracleDbType.Date),
                    new OracleParameter(":N_RH_NUM", OracleDbType.Decimal,5),
                    new OracleParameter(":N_KP_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":N_XM_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":C_DFP_RZ", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_RZP_RZ", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_DFP_YQ", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_RZP_YQ", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STL_GRD_TYPE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PROD_KIND", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_TL", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_JSCN", OracleDbType.Decimal,5),
                    new OracleParameter(":C_FREE2", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_GROUP", OracleDbType.Decimal,5),
                    new OracleParameter(":N_ZJCLS", OracleDbType.Decimal,4),
                    new OracleParameter(":N_ZJCLS_MIN", OracleDbType.Decimal,4),
                    new OracleParameter(":N_ZJCLS_MAX", OracleDbType.Decimal,4),
                    new OracleParameter(":C_SL", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_WL", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SLAB_TYPE", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_JC_SORT", OracleDbType.Decimal,20),
                    new OracleParameter(":C_FREE1", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.C_ID;
            parameters[1].Value = model.C_FK;
            parameters[2].Value = model.C_ORDER_NO;
            parameters[3].Value = model.C_DESIGN_NO;
            parameters[4].Value = model.N_SLAB_WGT;
            parameters[5].Value = model.C_CTRL_NO;
            parameters[6].Value = model.C_CCM_ID;
            parameters[7].Value = model.C_CCM_DESC;
            parameters[8].Value = model.C_PROD_NAME;
            parameters[9].Value = model.C_STL_GRD;
            parameters[10].Value = model.C_SPEC_CODE;
            parameters[11].Value = model.C_LENGTH;
            parameters[12].Value = model.C_MATRL_NO;
            parameters[13].Value = model.C_MATRL_NAME;
            parameters[14].Value = model.C_SLAB_SIZE;
            parameters[15].Value = model.C_SLAB_LENGTH;
            parameters[16].Value = model.C_STATE;
            parameters[17].Value = model.C_STD_CODE;
            parameters[18].Value = model.C_INITIALIZE_ITEM_ID;
            parameters[19].Value = model.D_P_START_TIME;
            parameters[20].Value = model.D_P_END_TIME;
            parameters[21].Value = model.N_PROD_TIME;
            parameters[22].Value = model.N_SORT;
            parameters[23].Value = model.C_CAST_NO;
            parameters[24].Value = model.N_STATUS;
            parameters[25].Value = model.C_EMP_ID;
            parameters[26].Value = model.D_MOD_DT;
            parameters[27].Value = model.C_REMARK;
            parameters[28].Value = model.N_CREAT_PLAN;
            parameters[29].Value = model.N_CREAT_ZG_PLAN;
            parameters[30].Value = model.N_PRODUCE_TIME;
            parameters[31].Value = model.C_ZL_ID;
            parameters[32].Value = model.C_LF_ID;
            parameters[33].Value = model.C_RH_ID;
            parameters[34].Value = model.C_LGJH;
            parameters[35].Value = model.C_QUA;
            parameters[36].Value = model.D_ARRIVE_ZG_TIME;
            parameters[37].Value = model.C_BY1;
            parameters[38].Value = model.C_BY2;
            parameters[39].Value = model.C_BY3;
            parameters[40].Value = model.C_RH;
            parameters[41].Value = model.C_DFP_HL;
            parameters[42].Value = model.C_HL;
            parameters[43].Value = model.C_XM;
            parameters[44].Value = model.D_DFPHL_START_TIME;
            parameters[45].Value = model.D_DFPHL_END_TIME;
            parameters[46].Value = model.D_KP_START_TIME;
            parameters[47].Value = model.D_KP_END_TIME;
            parameters[48].Value = model.D_HL_START_TIME;
            parameters[49].Value = model.D_HL_END_TIME;
            parameters[50].Value = model.D_PLAN_KY_TIME;
            parameters[51].Value = model.C_PLAN_ROLL;
            parameters[52].Value = model.D_ZZ_START_TIME;
            parameters[53].Value = model.D_ZZ_END_TIME;
            parameters[54].Value = model.D_XM_START_TIME;
            parameters[55].Value = model.D_XM_END_TIME;
            parameters[56].Value = model.C_STOVE_NO;
            parameters[57].Value = model.D_DFPHL_START_TIME_SJ;
            parameters[58].Value = model.D_DFPHL_END_TIME_SJ;
            parameters[59].Value = model.D_KP_START_TIME_SJ;
            parameters[60].Value = model.D_KP_END_TIME_SJ;
            parameters[61].Value = model.D_HL_START_TIME_SJ;
            parameters[62].Value = model.D_HL_END_TIME_SJ;
            parameters[63].Value = model.D_XM_START_TIME_SJ;
            parameters[64].Value = model.D_XM_END_TIME_SJ;
            parameters[65].Value = model.N_SJ_WGT;
            parameters[66].Value = model.D_START_TIME_SJ;
            parameters[67].Value = model.D_END_TIME_SJ;
            parameters[68].Value = model.N_DFP_HL_TIME;
            parameters[69].Value = model.N_HL_TIME;
            parameters[70].Value = model.C_ROUTE;
            parameters[71].Value = model.N_SLAB_PW;
            parameters[72].Value = model.C_MATRL_CODE_KP;
            parameters[73].Value = model.C_MATRL_NAME_KP;
            parameters[74].Value = model.C_KP_SIZE;
            parameters[75].Value = model.N_KP_LENGTH;
            parameters[76].Value = model.N_KP_PW;
            parameters[77].Value = model.N_USE_WGT;
            parameters[78].Value = model.D_USE_START_TIME_SJ;
            parameters[79].Value = model.D_USE_END_TIME_SJ;
            parameters[80].Value = model.D_CAN_USE_TIME;
            parameters[81].Value = model.N_RH_NUM;
            parameters[82].Value = model.N_KP_WGT;
            parameters[83].Value = model.N_XM_WGT;
            parameters[84].Value = model.C_DFP_RZ;
            parameters[85].Value = model.C_RZP_RZ;
            parameters[86].Value = model.C_DFP_YQ;
            parameters[87].Value = model.C_RZP_YQ;
            parameters[88].Value = model.C_STL_GRD_TYPE;
            parameters[89].Value = model.C_PROD_KIND;
            parameters[90].Value = model.C_TL;
            parameters[91].Value = model.N_JSCN;
            parameters[92].Value = model.C_FREE2;
            parameters[93].Value = model.N_GROUP;
            parameters[94].Value = model.N_ZJCLS;
            parameters[95].Value = model.N_ZJCLS_MIN;
            parameters[96].Value = model.N_ZJCLS_MAX;
            parameters[97].Value = model.C_SL;
            parameters[98].Value = model.C_WL;
            parameters[99].Value = model.C_SLAB_TYPE;
            parameters[100].Value = model.N_JC_SORT;
            parameters[101].Value = model.C_FREE1;

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
        public bool Update(Mod_TPP_LGPC_LCLSB model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TPP_LGPC_LCLSB set ");
            strSql.Append("C_FK=:C_FK,");
            strSql.Append("C_ORDER_NO=:C_ORDER_NO,");
            strSql.Append("C_DESIGN_NO=:C_DESIGN_NO,");
            strSql.Append("N_SLAB_WGT=:N_SLAB_WGT,");
            strSql.Append("C_CTRL_NO=:C_CTRL_NO,");
            strSql.Append("C_CCM_ID=:C_CCM_ID,");
            strSql.Append("C_CCM_DESC=:C_CCM_DESC,");
            strSql.Append("C_PROD_NAME=:C_PROD_NAME,");
            strSql.Append("C_STL_GRD=:C_STL_GRD,");
            strSql.Append("C_SPEC_CODE=:C_SPEC_CODE,");
            strSql.Append("C_LENGTH=:C_LENGTH,");
            strSql.Append("C_MATRL_NO=:C_MATRL_NO,");
            strSql.Append("C_MATRL_NAME=:C_MATRL_NAME,");
            strSql.Append("C_SLAB_SIZE=:C_SLAB_SIZE,");
            strSql.Append("C_SLAB_LENGTH=:C_SLAB_LENGTH,");
            strSql.Append("C_STATE=:C_STATE,");
            strSql.Append("C_STD_CODE=:C_STD_CODE,");
            strSql.Append("C_INITIALIZE_ITEM_ID=:C_INITIALIZE_ITEM_ID,");
            strSql.Append("D_P_START_TIME=:D_P_START_TIME,");
            strSql.Append("D_P_END_TIME=:D_P_END_TIME,");
            strSql.Append("N_PROD_TIME=:N_PROD_TIME,");
            strSql.Append("N_SORT=:N_SORT,");
            strSql.Append("C_CAST_NO=:C_CAST_NO,");
            strSql.Append("N_STATUS=:N_STATUS,");
            strSql.Append("C_EMP_ID=:C_EMP_ID,");
            strSql.Append("D_MOD_DT=:D_MOD_DT,");
            strSql.Append("C_REMARK=:C_REMARK,");
            strSql.Append("N_CREAT_PLAN=:N_CREAT_PLAN,");
            strSql.Append("N_CREAT_ZG_PLAN=:N_CREAT_ZG_PLAN,");
            strSql.Append("N_PRODUCE_TIME=:N_PRODUCE_TIME,");
            strSql.Append("C_ZL_ID=:C_ZL_ID,");
            strSql.Append("C_LF_ID=:C_LF_ID,");
            strSql.Append("C_RH_ID=:C_RH_ID,");
            strSql.Append("C_LGJH=:C_LGJH,");
            strSql.Append("C_QUA=:C_QUA,");
            strSql.Append("D_ARRIVE_ZG_TIME=:D_ARRIVE_ZG_TIME,");
            strSql.Append("C_BY1=:C_BY1,");
            strSql.Append("C_BY2=:C_BY2,");
            strSql.Append("C_BY3=:C_BY3,");
            strSql.Append("C_RH=:C_RH,");
            strSql.Append("C_DFP_HL=:C_DFP_HL,");
            strSql.Append("C_HL=:C_HL,");
            strSql.Append("C_XM=:C_XM,");
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
            strSql.Append("C_STOVE_NO=:C_STOVE_NO,");
            strSql.Append("D_DFPHL_START_TIME_SJ=:D_DFPHL_START_TIME_SJ,");
            strSql.Append("D_DFPHL_END_TIME_SJ=:D_DFPHL_END_TIME_SJ,");
            strSql.Append("D_KP_START_TIME_SJ=:D_KP_START_TIME_SJ,");
            strSql.Append("D_KP_END_TIME_SJ=:D_KP_END_TIME_SJ,");
            strSql.Append("D_HL_START_TIME_SJ=:D_HL_START_TIME_SJ,");
            strSql.Append("D_HL_END_TIME_SJ=:D_HL_END_TIME_SJ,");
            strSql.Append("D_XM_START_TIME_SJ=:D_XM_START_TIME_SJ,");
            strSql.Append("D_XM_END_TIME_SJ=:D_XM_END_TIME_SJ,");
            strSql.Append("N_SJ_WGT=:N_SJ_WGT,");
            strSql.Append("D_START_TIME_SJ=:D_START_TIME_SJ,");
            strSql.Append("D_END_TIME_SJ=:D_END_TIME_SJ,");
            strSql.Append("N_DFP_HL_TIME=:N_DFP_HL_TIME,");
            strSql.Append("N_HL_TIME=:N_HL_TIME,");
            strSql.Append("C_ROUTE=:C_ROUTE,");
            strSql.Append("N_SLAB_PW=:N_SLAB_PW,");
            strSql.Append("C_MATRL_CODE_KP=:C_MATRL_CODE_KP,");
            strSql.Append("C_MATRL_NAME_KP=:C_MATRL_NAME_KP,");
            strSql.Append("C_KP_SIZE=:C_KP_SIZE,");
            strSql.Append("N_KP_LENGTH=:N_KP_LENGTH,");
            strSql.Append("N_KP_PW=:N_KP_PW,");
            strSql.Append("N_USE_WGT=:N_USE_WGT,");
            strSql.Append("D_USE_START_TIME_SJ=:D_USE_START_TIME_SJ,");
            strSql.Append("D_USE_END_TIME_SJ=:D_USE_END_TIME_SJ,");
            strSql.Append("D_CAN_USE_TIME=:D_CAN_USE_TIME,");
            strSql.Append("N_RH_NUM=:N_RH_NUM,");
            strSql.Append("N_KP_WGT=:N_KP_WGT,");
            strSql.Append("N_XM_WGT=:N_XM_WGT,");
            strSql.Append("C_DFP_RZ=:C_DFP_RZ,");
            strSql.Append("C_RZP_RZ=:C_RZP_RZ,");
            strSql.Append("C_DFP_YQ=:C_DFP_YQ,");
            strSql.Append("C_RZP_YQ=:C_RZP_YQ,");
            strSql.Append("C_STL_GRD_TYPE=:C_STL_GRD_TYPE,");
            strSql.Append("C_PROD_KIND=:C_PROD_KIND,");
            strSql.Append("C_TL=:C_TL,");
            strSql.Append("N_JSCN=:N_JSCN,");
            strSql.Append("C_FREE2=:C_FREE2,");
            strSql.Append("N_GROUP=:N_GROUP,");
            strSql.Append("N_ZJCLS=:N_ZJCLS,");
            strSql.Append("N_ZJCLS_MIN=:N_ZJCLS_MIN,");
            strSql.Append("N_ZJCLS_MAX=:N_ZJCLS_MAX,");
            strSql.Append("C_SL=:C_SL,");
            strSql.Append("C_WL=:C_WL,");
            strSql.Append("C_SLAB_TYPE=:C_SLAB_TYPE,");
            strSql.Append("N_JC_SORT=:N_JC_SORT,");
            strSql.Append("C_FREE1=:C_FREE1");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_FK", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ORDER_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_DESIGN_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_SLAB_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":C_CTRL_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CCM_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CCM_DESC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PROD_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STL_GRD", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SPEC_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_LENGTH", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MATRL_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MATRL_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SLAB_SIZE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SLAB_LENGTH", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STATE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STD_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_INITIALIZE_ITEM_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_P_START_TIME", OracleDbType.Date),
                    new OracleParameter(":D_P_END_TIME", OracleDbType.Date),
                    new OracleParameter(":N_PROD_TIME", OracleDbType.Decimal,5),
                    new OracleParameter(":N_SORT", OracleDbType.Decimal,20),
                    new OracleParameter(":C_CAST_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
                    new OracleParameter(":N_CREAT_PLAN", OracleDbType.Decimal,5),
                    new OracleParameter(":N_CREAT_ZG_PLAN", OracleDbType.Decimal,5),
                    new OracleParameter(":N_PRODUCE_TIME", OracleDbType.Decimal,5),
                    new OracleParameter(":C_ZL_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_LF_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_RH_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_LGJH", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_QUA", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_ARRIVE_ZG_TIME", OracleDbType.Date),
                    new OracleParameter(":C_BY1", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_BY2", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_BY3", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_RH", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_DFP_HL", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_HL", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_XM", OracleDbType.Varchar2,100),
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
                    new OracleParameter(":C_STOVE_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_DFPHL_START_TIME_SJ", OracleDbType.Date),
                    new OracleParameter(":D_DFPHL_END_TIME_SJ", OracleDbType.Date),
                    new OracleParameter(":D_KP_START_TIME_SJ", OracleDbType.Date),
                    new OracleParameter(":D_KP_END_TIME_SJ", OracleDbType.Date),
                    new OracleParameter(":D_HL_START_TIME_SJ", OracleDbType.Date),
                    new OracleParameter(":D_HL_END_TIME_SJ", OracleDbType.Date),
                    new OracleParameter(":D_XM_START_TIME_SJ", OracleDbType.Date),
                    new OracleParameter(":D_XM_END_TIME_SJ", OracleDbType.Date),
                    new OracleParameter(":N_SJ_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":D_START_TIME_SJ", OracleDbType.Date),
                    new OracleParameter(":D_END_TIME_SJ", OracleDbType.Date),
                    new OracleParameter(":N_DFP_HL_TIME", OracleDbType.Decimal,10),
                    new OracleParameter(":N_HL_TIME", OracleDbType.Decimal,10),
                    new OracleParameter(":C_ROUTE", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_SLAB_PW", OracleDbType.Decimal,15),
                    new OracleParameter(":C_MATRL_CODE_KP", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MATRL_NAME_KP", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_KP_SIZE", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_KP_LENGTH", OracleDbType.Decimal,15),
                    new OracleParameter(":N_KP_PW", OracleDbType.Decimal,15),
                    new OracleParameter(":N_USE_WGT", OracleDbType.Decimal,5),
                    new OracleParameter(":D_USE_START_TIME_SJ", OracleDbType.Date),
                    new OracleParameter(":D_USE_END_TIME_SJ", OracleDbType.Date),
                    new OracleParameter(":D_CAN_USE_TIME", OracleDbType.Date),
                    new OracleParameter(":N_RH_NUM", OracleDbType.Decimal,5),
                    new OracleParameter(":N_KP_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":N_XM_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":C_DFP_RZ", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_RZP_RZ", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_DFP_YQ", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_RZP_YQ", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STL_GRD_TYPE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PROD_KIND", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_TL", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_JSCN", OracleDbType.Decimal,5),
                    new OracleParameter(":C_FREE2", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_GROUP", OracleDbType.Decimal,5),
                    new OracleParameter(":N_ZJCLS", OracleDbType.Decimal,4),
                    new OracleParameter(":N_ZJCLS_MIN", OracleDbType.Decimal,4),
                    new OracleParameter(":N_ZJCLS_MAX", OracleDbType.Decimal,4),
                    new OracleParameter(":C_SL", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_WL", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SLAB_TYPE", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_JC_SORT", OracleDbType.Decimal,20),
                    new OracleParameter(":C_FREE1", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.C_FK;
            parameters[1].Value = model.C_ORDER_NO;
            parameters[2].Value = model.C_DESIGN_NO;
            parameters[3].Value = model.N_SLAB_WGT;
            parameters[4].Value = model.C_CTRL_NO;
            parameters[5].Value = model.C_CCM_ID;
            parameters[6].Value = model.C_CCM_DESC;
            parameters[7].Value = model.C_PROD_NAME;
            parameters[8].Value = model.C_STL_GRD;
            parameters[9].Value = model.C_SPEC_CODE;
            parameters[10].Value = model.C_LENGTH;
            parameters[11].Value = model.C_MATRL_NO;
            parameters[12].Value = model.C_MATRL_NAME;
            parameters[13].Value = model.C_SLAB_SIZE;
            parameters[14].Value = model.C_SLAB_LENGTH;
            parameters[15].Value = model.C_STATE;
            parameters[16].Value = model.C_STD_CODE;
            parameters[17].Value = model.C_INITIALIZE_ITEM_ID;
            parameters[18].Value = model.D_P_START_TIME;
            parameters[19].Value = model.D_P_END_TIME;
            parameters[20].Value = model.N_PROD_TIME;
            parameters[21].Value = model.N_SORT;
            parameters[22].Value = model.C_CAST_NO;
            parameters[23].Value = model.N_STATUS;
            parameters[24].Value = model.C_EMP_ID;
            parameters[25].Value = model.D_MOD_DT;
            parameters[26].Value = model.C_REMARK;
            parameters[27].Value = model.N_CREAT_PLAN;
            parameters[28].Value = model.N_CREAT_ZG_PLAN;
            parameters[29].Value = model.N_PRODUCE_TIME;
            parameters[30].Value = model.C_ZL_ID;
            parameters[31].Value = model.C_LF_ID;
            parameters[32].Value = model.C_RH_ID;
            parameters[33].Value = model.C_LGJH;
            parameters[34].Value = model.C_QUA;
            parameters[35].Value = model.D_ARRIVE_ZG_TIME;
            parameters[36].Value = model.C_BY1;
            parameters[37].Value = model.C_BY2;
            parameters[38].Value = model.C_BY3;
            parameters[39].Value = model.C_RH;
            parameters[40].Value = model.C_DFP_HL;
            parameters[41].Value = model.C_HL;
            parameters[42].Value = model.C_XM;
            parameters[43].Value = model.D_DFPHL_START_TIME;
            parameters[44].Value = model.D_DFPHL_END_TIME;
            parameters[45].Value = model.D_KP_START_TIME;
            parameters[46].Value = model.D_KP_END_TIME;
            parameters[47].Value = model.D_HL_START_TIME;
            parameters[48].Value = model.D_HL_END_TIME;
            parameters[49].Value = model.D_PLAN_KY_TIME;
            parameters[50].Value = model.C_PLAN_ROLL;
            parameters[51].Value = model.D_ZZ_START_TIME;
            parameters[52].Value = model.D_ZZ_END_TIME;
            parameters[53].Value = model.D_XM_START_TIME;
            parameters[54].Value = model.D_XM_END_TIME;
            parameters[55].Value = model.C_STOVE_NO;
            parameters[56].Value = model.D_DFPHL_START_TIME_SJ;
            parameters[57].Value = model.D_DFPHL_END_TIME_SJ;
            parameters[58].Value = model.D_KP_START_TIME_SJ;
            parameters[59].Value = model.D_KP_END_TIME_SJ;
            parameters[60].Value = model.D_HL_START_TIME_SJ;
            parameters[61].Value = model.D_HL_END_TIME_SJ;
            parameters[62].Value = model.D_XM_START_TIME_SJ;
            parameters[63].Value = model.D_XM_END_TIME_SJ;
            parameters[64].Value = model.N_SJ_WGT;
            parameters[65].Value = model.D_START_TIME_SJ;
            parameters[66].Value = model.D_END_TIME_SJ;
            parameters[67].Value = model.N_DFP_HL_TIME;
            parameters[68].Value = model.N_HL_TIME;
            parameters[69].Value = model.C_ROUTE;
            parameters[70].Value = model.N_SLAB_PW;
            parameters[71].Value = model.C_MATRL_CODE_KP;
            parameters[72].Value = model.C_MATRL_NAME_KP;
            parameters[73].Value = model.C_KP_SIZE;
            parameters[74].Value = model.N_KP_LENGTH;
            parameters[75].Value = model.N_KP_PW;
            parameters[76].Value = model.N_USE_WGT;
            parameters[77].Value = model.D_USE_START_TIME_SJ;
            parameters[78].Value = model.D_USE_END_TIME_SJ;
            parameters[79].Value = model.D_CAN_USE_TIME;
            parameters[80].Value = model.N_RH_NUM;
            parameters[81].Value = model.N_KP_WGT;
            parameters[82].Value = model.N_XM_WGT;
            parameters[83].Value = model.C_DFP_RZ;
            parameters[84].Value = model.C_RZP_RZ;
            parameters[85].Value = model.C_DFP_YQ;
            parameters[86].Value = model.C_RZP_YQ;
            parameters[87].Value = model.C_STL_GRD_TYPE;
            parameters[88].Value = model.C_PROD_KIND;
            parameters[89].Value = model.C_TL;
            parameters[90].Value = model.N_JSCN;
            parameters[91].Value = model.C_FREE2;
            parameters[92].Value = model.N_GROUP;
            parameters[93].Value = model.N_ZJCLS;
            parameters[94].Value = model.N_ZJCLS_MIN;
            parameters[95].Value = model.N_ZJCLS_MAX;
            parameters[96].Value = model.C_SL;
            parameters[97].Value = model.C_WL;
            parameters[98].Value = model.C_SLAB_TYPE;
            parameters[99].Value = model.N_JC_SORT;
            parameters[100].Value = model.C_FREE1;
            parameters[101].Value = model.C_ID;

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
            strSql.Append("delete from TPP_LGPC_LCLSB ");
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
        /// 批量删除数据
        /// </summary>
        public bool Delete(string C_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from TPP_LGPC_LCLSB ");
            strSql.Append(" where C_ID = '" + C_ID + "' ");
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
        /// 根据浇次主键删除炉次计划
        /// </summary>
        /// <param name="C_ID">浇次计划主键</param>
        /// <returns>删除结果</returns>
        public bool DeleteByJCID(string C_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from TPP_LGPC_LCLSB ");
            strSql.Append(" where C_FK = '" + C_ID + "' ");
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
        public Mod_TPP_LGPC_LCLSB GetModel(string C_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_FK,C_ORDER_NO,C_DESIGN_NO,N_SLAB_WGT,C_CTRL_NO,C_CCM_ID,C_CCM_DESC,C_PROD_NAME,C_STL_GRD,C_SPEC_CODE,C_LENGTH,C_MATRL_NO,C_MATRL_NAME,C_SLAB_SIZE,C_SLAB_LENGTH,C_STATE,C_STD_CODE,C_INITIALIZE_ITEM_ID,D_P_START_TIME,D_P_END_TIME,N_PROD_TIME,N_SORT,C_CAST_NO,N_STATUS,C_EMP_ID,D_MOD_DT,C_REMARK,N_CREAT_PLAN,N_CREAT_ZG_PLAN,N_PRODUCE_TIME,C_ZL_ID,C_LF_ID,C_RH_ID,C_LGJH,C_QUA,D_ARRIVE_ZG_TIME,C_BY1,C_BY2,C_BY3,C_RH,C_DFP_HL,C_HL,C_XM,D_DFPHL_START_TIME,D_DFPHL_END_TIME,D_KP_START_TIME,D_KP_END_TIME,D_HL_START_TIME,D_HL_END_TIME,D_PLAN_KY_TIME,C_PLAN_ROLL,D_ZZ_START_TIME,D_ZZ_END_TIME,D_XM_START_TIME,D_XM_END_TIME,C_STOVE_NO,D_DFPHL_START_TIME_SJ,D_DFPHL_END_TIME_SJ,D_KP_START_TIME_SJ,D_KP_END_TIME_SJ,D_HL_START_TIME_SJ,D_HL_END_TIME_SJ,D_XM_START_TIME_SJ,D_XM_END_TIME_SJ,N_SJ_WGT,D_START_TIME_SJ,D_END_TIME_SJ,N_DFP_HL_TIME,N_HL_TIME,C_ROUTE,N_SLAB_PW,C_MATRL_CODE_KP,C_MATRL_NAME_KP,C_KP_SIZE,N_KP_LENGTH,N_KP_PW,N_USE_WGT,D_USE_START_TIME_SJ,D_USE_END_TIME_SJ,D_CAN_USE_TIME,N_RH_NUM,N_KP_WGT,N_XM_WGT,C_DFP_RZ,C_RZP_RZ,C_DFP_YQ,C_RZP_YQ,C_STL_GRD_TYPE,C_PROD_KIND,C_TL,N_JSCN,C_FREE2,N_GROUP,N_ZJCLS,N_ZJCLS_MIN,N_ZJCLS_MAX,C_SL,C_WL,C_SLAB_TYPE,N_JC_SORT,C_FREE1 from TPP_LGPC_LCLSB ");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)            };
            parameters[0].Value = C_ID;

            Mod_TPP_LGPC_LCLSB model = new Mod_TPP_LGPC_LCLSB();
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
        public Mod_TPP_LGPC_LCLSB DataRowToModel(DataRow row)
        {
            Mod_TPP_LGPC_LCLSB model = new Mod_TPP_LGPC_LCLSB();
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
        /// 根据浇次、连铸查询排产的炉次计划
        /// </summary>
        /// <param name="C_FK">浇次计划主键</param>
        /// <param name="C_CCM_NO">连铸</param>
        /// <returns></returns>
        public DataSet GetList(string C_FK, string C_CCM_NO)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_FK,C_ORDER_NO,C_DESIGN_NO,N_SLAB_WGT,C_CTRL_NO,C_CCM_ID,C_CCM_DESC,C_PROD_NAME,C_STL_GRD,C_SPEC_CODE,C_LENGTH,C_MATRL_NO,C_MATRL_NAME,C_SLAB_SIZE,C_SLAB_LENGTH,C_STATE,C_STD_CODE,C_INITIALIZE_ITEM_ID,D_P_START_TIME,D_P_END_TIME,N_PROD_TIME,N_SORT,C_CAST_NO,N_STATUS,C_EMP_ID,D_MOD_DT,C_REMARK,N_CREAT_PLAN,N_CREAT_ZG_PLAN,N_PRODUCE_TIME,C_ZL_ID,C_LF_ID,C_RH_ID,C_LGJH,C_QUA,D_ARRIVE_ZG_TIME,C_BY1,C_BY2,C_BY3,C_RH,C_DFP_HL,C_HL,C_XM,D_DFPHL_START_TIME,D_DFPHL_END_TIME,D_KP_START_TIME,D_KP_END_TIME,D_HL_START_TIME,D_HL_END_TIME,D_PLAN_KY_TIME,C_PLAN_ROLL,D_ZZ_START_TIME,D_ZZ_END_TIME,D_XM_START_TIME,D_XM_END_TIME,C_STOVE_NO,D_DFPHL_START_TIME_SJ,D_DFPHL_END_TIME_SJ,D_KP_START_TIME_SJ,D_KP_END_TIME_SJ,D_HL_START_TIME_SJ,D_HL_END_TIME_SJ,D_XM_START_TIME_SJ,D_XM_END_TIME_SJ,N_SJ_WGT,D_START_TIME_SJ,D_END_TIME_SJ,N_DFP_HL_TIME,N_HL_TIME,C_ROUTE,N_SLAB_PW,C_MATRL_CODE_KP,C_MATRL_NAME_KP,C_KP_SIZE,N_KP_LENGTH,N_KP_PW,N_USE_WGT,D_USE_START_TIME_SJ,D_USE_END_TIME_SJ,D_CAN_USE_TIME,N_RH_NUM,N_KP_WGT,N_XM_WGT,C_DFP_RZ,C_RZP_RZ,C_DFP_YQ,C_RZP_YQ,C_STL_GRD_TYPE,C_PROD_KIND,C_TL,N_JSCN,C_FREE2,N_GROUP,N_ZJCLS,N_ZJCLS_MIN,N_ZJCLS_MAX,C_SL,C_WL,C_SLAB_TYPE,N_JC_SORT,C_FREE1  ");
            strSql.Append(" FROM TPP_LGPC_LCLSB where 1=1 ");
            if (C_FK.Trim() != "")
            {
                strSql.Append(" AND C_FK='" + C_FK + "' ");
            }
            if (C_CCM_NO.Trim() != "")
            {
                strSql.Append(" AND C_CCM_NO='" + C_CCM_NO + "' ");
            }
            strSql.Append(" ORDER BY N_JC_SORT,N_SORT,C_STATE ");
            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 根据浇次、连铸查询排产的炉次计划
        /// </summary>
        /// <param name="C_FK">浇次计划主键</param>
        /// <returns></returns>
        public DataSet GetListByJcID(string C_FK)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_FK,C_ORDER_NO,C_DESIGN_NO,N_SLAB_WGT,C_CTRL_NO,C_CCM_ID,C_CCM_DESC,C_PROD_NAME,C_STL_GRD,C_SPEC_CODE,C_LENGTH,C_MATRL_NO,C_MATRL_NAME,C_SLAB_SIZE,C_SLAB_LENGTH,C_STATE,C_STD_CODE,C_INITIALIZE_ITEM_ID,D_P_START_TIME,D_P_END_TIME,N_PROD_TIME,N_SORT,C_CAST_NO,N_STATUS,C_EMP_ID,D_MOD_DT,C_REMARK,N_CREAT_PLAN,N_CREAT_ZG_PLAN,N_PRODUCE_TIME,C_ZL_ID,C_LF_ID,C_RH_ID,C_LGJH,C_QUA,D_ARRIVE_ZG_TIME,C_BY1,C_BY2,C_BY3,C_RH,C_DFP_HL,C_HL,C_XM,D_DFPHL_START_TIME,D_DFPHL_END_TIME,D_KP_START_TIME,D_KP_END_TIME,D_HL_START_TIME,D_HL_END_TIME,D_PLAN_KY_TIME,C_PLAN_ROLL,D_ZZ_START_TIME,D_ZZ_END_TIME,D_XM_START_TIME,D_XM_END_TIME,C_STOVE_NO,D_DFPHL_START_TIME_SJ,D_DFPHL_END_TIME_SJ,D_KP_START_TIME_SJ,D_KP_END_TIME_SJ,D_HL_START_TIME_SJ,D_HL_END_TIME_SJ,D_XM_START_TIME_SJ,D_XM_END_TIME_SJ,N_SJ_WGT,D_START_TIME_SJ,D_END_TIME_SJ,N_DFP_HL_TIME,N_HL_TIME,C_ROUTE,N_SLAB_PW,C_MATRL_CODE_KP,C_MATRL_NAME_KP,C_KP_SIZE,N_KP_LENGTH,N_KP_PW,N_USE_WGT,D_USE_START_TIME_SJ,D_USE_END_TIME_SJ,D_CAN_USE_TIME,N_RH_NUM,N_KP_WGT,N_XM_WGT,C_DFP_RZ,C_RZP_RZ,C_DFP_YQ,C_RZP_YQ,C_STL_GRD_TYPE,C_PROD_KIND,C_TL,N_JSCN,C_FREE2,N_GROUP,N_ZJCLS,N_ZJCLS_MIN,N_ZJCLS_MAX,C_SL,C_WL,C_SLAB_TYPE,N_JC_SORT,C_FREE1  ");
            strSql.Append(" FROM TPP_LGPC_LCLSB where 1=1 ");
            if (C_FK.Trim() != "")
            {
                strSql.Append(" AND C_FK='" + C_FK + "' ");
            }
            strSql.Append(" ORDER BY N_JC_SORT,N_SORT,C_STATE ");
            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 根据浇次号获取炉次计划
        /// </summary>
        /// <param name="C_FK">浇次号</param>
        /// <returns></returns>
        public DataSet GetList_sms_group(string C_FK)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(T.C_ID) AS COU, t.c_stl_grd,t.c_std_code  ");
            strSql.Append(" FROM TPP_LGPC_LCLSB t ");
            if (C_FK.Trim() != "")
            {
                strSql.Append(" where t.c_fk = '" + C_FK + "' ");
            }
            strSql.Append(" group by t.c_stl_grd,t.c_std_code ");
            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 根据浇次、连铸查询排产的炉次计划
        /// </summary>
        /// <param name="C_FK">浇次计划主键</param>
        /// <param name="C_CCM_NO">连铸</param>
        /// <returns></returns>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_FK,C_ORDER_NO,C_DESIGN_NO,N_SLAB_WGT,C_CTRL_NO,C_CCM_ID,C_CCM_DESC,C_PROD_NAME,C_STL_GRD,C_SPEC_CODE,C_LENGTH,C_MATRL_NO,C_MATRL_NAME,C_SLAB_SIZE,C_SLAB_LENGTH,C_STATE,C_STD_CODE,C_INITIALIZE_ITEM_ID,D_P_START_TIME,D_P_END_TIME,N_PROD_TIME,N_SORT,C_CAST_NO,N_STATUS,C_EMP_ID,D_MOD_DT,C_REMARK,N_CREAT_PLAN,N_CREAT_ZG_PLAN,N_PRODUCE_TIME,C_ZL_ID,C_LF_ID,C_RH_ID,C_LGJH,C_QUA,D_ARRIVE_ZG_TIME,C_BY1,C_BY2,C_BY3,C_RH,C_DFP_HL,C_HL,C_XM,D_DFPHL_START_TIME,D_DFPHL_END_TIME,D_KP_START_TIME,D_KP_END_TIME,D_HL_START_TIME,D_HL_END_TIME,D_PLAN_KY_TIME,C_PLAN_ROLL,D_ZZ_START_TIME,D_ZZ_END_TIME,D_XM_START_TIME,D_XM_END_TIME,C_STOVE_NO,D_DFPHL_START_TIME_SJ,D_DFPHL_END_TIME_SJ,D_KP_START_TIME_SJ,D_KP_END_TIME_SJ,D_HL_START_TIME_SJ,D_HL_END_TIME_SJ,D_XM_START_TIME_SJ,D_XM_END_TIME_SJ,N_SJ_WGT,D_START_TIME_SJ,D_END_TIME_SJ,N_DFP_HL_TIME,N_HL_TIME,C_ROUTE,N_SLAB_PW,C_MATRL_CODE_KP,C_MATRL_NAME_KP,C_KP_SIZE,N_KP_LENGTH,N_KP_PW,N_USE_WGT,D_USE_START_TIME_SJ,D_USE_END_TIME_SJ,D_CAN_USE_TIME,N_RH_NUM,N_KP_WGT,N_XM_WGT,C_DFP_RZ,C_RZP_RZ,C_DFP_YQ,C_RZP_YQ,C_STL_GRD_TYPE,C_PROD_KIND,C_TL,N_JSCN,C_FREE2,N_GROUP,N_ZJCLS,N_ZJCLS_MIN,N_ZJCLS_MAX,C_SL,C_WL,C_SLAB_TYPE,N_JC_SORT,C_FREE1  ");
            strSql.Append(" FROM TPP_LGPC_LCLSB where 1=1 ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(strWhere);
            }

            strSql.Append(" ORDER BY N_JC_SORT,N_SORT,C_STATE ");
            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM TPP_LGPC_LCLSB ");
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
            strSql.Append(")AS Row, T.*  from TPP_LGPC_LCLSB T ");
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
					new OracleParameter(":PageSize", OracleDbType.Int16),
					new OracleParameter(":PageIndex", OracleDbType.Int16),
					new OracleParameter(":IsReCount", OracleDbType.Clob),
					new OracleParameter(":OrderType", OracleDbType.Clob),
					new OracleParameter(":strWhere", OracleDbType.Varchar2,1000),
					};
			parameters[0].Value = "TPP_LGPC_LCLSB";
			parameters[1].Value = "C_ID";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperOra.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

        #endregion  BasicMethod
        #region  ExtensionMethod


        /// <summary>
        /// 根据连铸删除炉次临时表数据
        /// </summary>
        /// <param name="C_CCM_NO">连铸</param>
        /// <returns>执行结果</returns>
        public bool DeleteByCCM(string C_CCM_NO)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from TPP_LGPC_LCLSB ");
            if (C_CCM_NO.Trim() != "")
            {
                strSql.Append(" where C_CCM_NO='" + C_CCM_NO + "' ");
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
        /// 根据浇次临时表获取最小序号
        /// </summary>
        /// <param name="C_FK"></param>
        /// <returns></returns>
        public int MinSortBy(string C_FK)
        {
            string strSql = @"SELECT MIN(T.N_SORT) N_SORT
  FROM TPP_LGPC_LCLSB T
 WHERE T.C_FK = '" + C_FK + "'";
            return Convert.ToInt32(DbHelperOra.Query(strSql.ToString()).Tables[0].Rows[0]["N_SORT"].ToString());

        }

        /// <summary>
        /// 根据浇次临时表获取最小序号
        /// </summary>
        /// <param name="C_FK"></param>
        /// <returns></returns>
        public int MaxSortBy(string C_FK)
        {
            string strSql = @"SELECT MAX(T.N_SORT) N_SORT
  FROM TPP_LGPC_LCLSB T
 WHERE T.C_FK = '" + C_FK + "'";
            return Convert.ToInt32(DbHelperOra.Query(strSql.ToString()).Tables[0].Rows[0]["N_SORT"].ToString());

        }

        /// <summary>
        /// 根据钢种标准获取能否用来调整混浇炉次的计划
        /// </summary>
        /// <param name="GZ">钢种</param>
        /// <param name="BZ">标准</param>
        /// <returns></returns>
        public Mod_TPP_LGPC_LCLSB GetChangeModel(string GZ, string BZ)
        {
            string strSql = "SELECT t.* FROM TPP_LGPC_LCLSB T WHERE t.C_STATE=1 AND  T.C_STL_GRD='" + GZ + "' AND C_STD_CODE='" + BZ + "' AND ROWNUM=1 ";
            Mod_TPP_LGPC_LCLSB model = new Mod_TPP_LGPC_LCLSB();
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
        /// 获取符合条件的浇次主键
        /// </summary>
        /// <param name="c_stl_grd">钢种</param>
        /// <param name="c_std_code">执行标准</param>
        /// <returns></returns>
        public DataSet Get_Cast_ID_Trans(string c_stl_grd, string c_std_code)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select distinct ta.C_FK from tpp_lgpc_lclsb ta inner join tpp_lgpc_lsb tb on ta.c_fk=tb.c_id where ta.N_STATUS=1 and tb.C_CCM_CODE<> '5#CC' and ta.C_FK is not null and ta.c_stl_grd='" + c_stl_grd + "' and ta.c_std_code='" + c_std_code + "' ");

            return TransactionHelper.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取炉次列表
        /// </summary>
        /// <param name="c_fk">浇次主键集合</param>
        /// <returns></returns>
        public DataSet Get_LC_List_Trans(string c_fk)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ta.* from tpp_lgpc_lclsb ta inner join tpp_lgpc_lsb tb on ta.c_fk=tb.c_id where ta.N_STATUS=1 and tb.C_CCM_CODE<> '5#CC' ");

            if (!string.IsNullOrEmpty(c_fk))
            {
                strSql.Append(" and ta.c_fk in(" + c_fk + ") ");
            }

            strSql.Append(" order by tb.d_p_start_time,ta.n_sort ");

            return TransactionHelper.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取炉次列表
        /// </summary>
        /// <param name="c_fk">浇次主键集合</param>
        /// <returns></returns>
        public DataSet Get_LC_List_Trans()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ta.* from tpp_lgpc_lclsb ta inner join tpp_lgpc_lsb tb on ta.c_fk=tb.c_id where ta.N_STATUS=1 and tb.C_CCM_CODE<> '5#CC' ");

            strSql.Append(" order by tb.d_p_start_time,ta.n_sort ");

            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update_Trans(string C_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TPP_LGPC_LCLSB t set N_STATUS=0 where T.C_FK in (" + C_ID + ") ");

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
        /// 更新一条数据
        /// </summary>
        public bool Update_ByID_Trans(string C_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TPP_LGPC_LCLSB t set N_STATUS=0 where T.C_ID in (" + C_ID + ") ");

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
        /// 获取浇次ID
        /// </summary>
        public string Get_Cast_Id()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select min(ta.c_fk) from tpp_lgpc_lclsb ta inner join tpp_lgpc_lsb tb on ta.c_fk=tb.c_id where ta.N_STATUS=1 and tb.C_CCM_CODE<> '5#CC' and  ta.c_fk is not null ");

            object obj = TransactionHelper.GetSingle(strSql.ToString());
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
        /// 批量删除数据
        /// </summary>
        public bool Delete_Trans(string C_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from TPP_LGPC_LCLSB ");
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

        #endregion  ExtensionMethod

        /// <summary>
        /// 获取已排产未完成的炼钢计划量
        /// </summary>
        /// <param name="C_STL_GRD">钢种</param>
        /// <param name="C_STD_CODE"></param>
        /// <param name="C_MATRL_NO"></param>
        /// <returns></returns>
        public decimal GetWWCJH(string C_STL_GRD, string C_STD_CODE, string C_MATRL_NO)
        {
            try
            {
                string sql = @"SELECT  NVL(SUM(T.N_SLAB_WGT), 0) N_SLAB_WGT
                             FROM TPP_LGPC_LCLSB T WHERE  T.C_STL_GRD = '" + C_STL_GRD + "'   AND T.C_STD_CODE = '" + C_STD_CODE + "'  ";
                if (C_MATRL_NO.Trim() != "")
                {
                    sql = sql + " AND T.C_MATRL_NO = '" + C_MATRL_NO + "' ";
                }

                return Convert.ToDecimal(DbHelperOra.Query(sql).Tables[0].Rows[0]["N_SLAB_WGT"].ToString());
            }
            catch (Exception)
            {

                return 0;
            }

        }

        /// <summary>
        /// 清空炉次临时表数据
        /// </summary>
        /// <returns></returns>
        public bool ClearTable(string C_CCM_ID, string C_IS_BXG)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from TPP_LGPC_LCLSB  T WHERE  T.C_SLAB_TYPE='" + C_IS_BXG + "'  ");
            if (C_CCM_ID.Trim()!="")
            {
                strSql.Append(" AND T.C_CCM_ID='" + C_CCM_ID + "' ");
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


        #region 调整连铸机时判断调整的浇次计划的炉次计划钢种信息
        /// <summary>
        /// 根据浇次号获取分组后的炉次计划
        /// </summary>
        /// <param name="C_FK">浇次主键</param>
        /// <returns></returns>
        public DataTable GetGroupPlan(string C_FK)
        {

            string sql = @"SELECT MAX(T.C_ORDER_NO) C_ORDER_NO,
       SUM(T.N_SLAB_WGT) N_SLAB_WGT,
       MAX(T.N_SORT) N_SORT,
       T.C_PROD_NAME,
       T.C_STL_GRD,
       T.C_MATRL_NO,
       T.C_MATRL_NAME,
       T.C_SLAB_SIZE,
       T.C_SLAB_LENGTH,
       T.C_STD_CODE,
       T.N_GROUP,
       T.C_BY1,
       T.C_BY2,
       T.C_RH,
       T.C_DFP_HL,
       T.C_HL,
       T.C_XM,
       T.C_ROUTE,
       T.N_SLAB_PW,
       T.C_MATRL_CODE_KP,
       T.C_MATRL_NAME_KP,
       T.C_KP_SIZE,
       T.N_KP_LENGTH,
       T.N_KP_PW,
       T.C_STL_GRD_TYPE,
       T.C_PROD_KIND,
       T.C_TL,
       T.C_FREE1,
       T.C_FREE2,
       T.C_SL,
       T.C_WL,
       T.C_SLAB_TYPE,
       T.C_LF,
       T.C_KP,
       T.C_STATE
  FROM TPP_LGPC_LCLSB T
 WHERE T.C_FK = '" + C_FK + "'";
            sql = sql + @"  AND T.N_STATUS = 1
 GROUP BY T.C_PROD_NAME,
          T.C_STL_GRD,
          T.C_MATRL_NO,
          T.C_MATRL_NAME,
          T.C_SLAB_SIZE,
          T.C_SLAB_LENGTH,
          T.C_STD_CODE,
          T.N_GROUP,
          T.C_BY1,
          T.C_BY2,
          T.C_RH,
          T.C_DFP_HL,
          T.C_HL,
          T.C_XM,
          T.C_ROUTE,
          T.N_SLAB_PW,
          T.C_MATRL_CODE_KP,
          T.C_MATRL_NAME_KP,
          T.C_KP_SIZE,
          T.N_KP_LENGTH,
          T.N_KP_PW,
          T.C_STL_GRD_TYPE,
          T.C_PROD_KIND,
          T.C_TL,
          T.C_FREE1,
          T.C_FREE2,
          T.C_SL,
          T.C_WL,
          T.C_SLAB_TYPE,
          T.C_LF,
          T.C_KP,
          T.C_STATE
 ORDER BY T.C_STATE";
            return DbHelperOra.Query(sql).Tables[0];
        }

        #endregion

    }
}
