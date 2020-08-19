using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;
using System.Collections.Generic;

namespace DAL
{
    /// <summary>
    /// 数据访问类:TSP_PLAN_SMS
    /// </summary>
    public partial class Dal_TSP_PLAN_SMS
    {
        public Dal_TSP_PLAN_SMS()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string C_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TSP_PLAN_SMS");
            strSql.Append(" where N_STATUS = 1 AND C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)         };
            parameters[0].Value = C_ID;

            return DbHelperOra.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Mod_TSP_PLAN_SMS model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TSP_PLAN_SMS(");
            strSql.Append("C_ID,C_ORDER_NO,C_DESIGN_NO,N_SLAB_WGT,C_CTRL_NO,C_CCM_ID,C_CCM_DESC,C_PROD_NAME,C_STL_GRD,C_SPEC_CODE,C_LENGTH,C_MATRL_NO,C_MATRL_NAME,C_SLAB_SIZE,C_SLAB_LENGTH,C_STATE,C_STD_CODE,C_INITIALIZE_ITEM_ID,D_P_START_TIME,D_P_END_TIME,N_PROD_TIME,N_SORT,C_CAST_NO,N_STATUS,C_EMP_ID,D_MOD_DT,C_REMARK,N_CREAT_PLAN,N_CREAT_ZG_PLAN,N_PRODUCE_TIME,C_ZL_ID,C_LF_ID,C_RH_ID,C_LGJH,C_QUA,D_ARRIVE_ZG_TIME,C_BY1,C_BY2,C_BY3,C_RH,C_DFP_HL,C_HL,C_XM,D_DFPHL_START_TIME,D_DFPHL_END_TIME,D_KP_START_TIME,D_KP_END_TIME,D_HL_START_TIME,D_HL_END_TIME,D_PLAN_KY_TIME,C_PLAN_ROLL,D_ZZ_START_TIME,D_ZZ_END_TIME,D_XM_START_TIME,D_XM_END_TIME,C_STOVE_NO,D_DFPHL_START_TIME_SJ,D_DFPHL_END_TIME_SJ,D_KP_START_TIME_SJ,D_KP_END_TIME_SJ,D_HL_START_TIME_SJ,D_HL_END_TIME_SJ,D_XM_START_TIME_SJ,D_XM_END_TIME_SJ,N_SJ_WGT,D_START_TIME_SJ,D_END_TIME_SJ,N_DFP_HL_TIME,N_HL_TIME,C_ROUTE,N_SLAB_PW,C_MATRL_CODE_KP,C_MATRL_NAME_KP,C_KP_SIZE,N_KP_LENGTH,N_KP_PW,N_USE_WGT,D_USE_START_TIME_SJ,D_USE_END_TIME_SJ,D_CAN_USE_TIME,N_RH_NUM,N_KP_WGT,N_XM_WGT,C_DFP_RZ,C_RZP_RZ,C_DFP_YQ,C_RZP_YQ,C_STL_GRD_TYPE,C_PROD_KIND,C_TL,N_JSCN,C_FREE1,C_FREE2,N_GROUP,C_FK,N_ZJCLS,N_ZJCLS_MIN,N_ZJCLS_MAX,C_SL,C_WL,C_SLAB_TYPE,N_JC_SORT,C_LF,C_KP,C_REMARK1,C_REMARK2,C_REMARK3,C_REMARK4,C_REMARK5,N_KP_SORT,N_XM_SORT,C_KP_ID,C_XM_ID)");
            strSql.Append(" values (");
            strSql.Append(":C_ID,:C_ORDER_NO,:C_DESIGN_NO,:N_SLAB_WGT,:C_CTRL_NO,:C_CCM_ID,:C_CCM_DESC,:C_PROD_NAME,:C_STL_GRD,:C_SPEC_CODE,:C_LENGTH,:C_MATRL_NO,:C_MATRL_NAME,:C_SLAB_SIZE,:C_SLAB_LENGTH,:C_STATE,:C_STD_CODE,:C_INITIALIZE_ITEM_ID,:D_P_START_TIME,:D_P_END_TIME,:N_PROD_TIME,:N_SORT,:C_CAST_NO,:N_STATUS,:C_EMP_ID,:D_MOD_DT,:C_REMARK,:N_CREAT_PLAN,:N_CREAT_ZG_PLAN,:N_PRODUCE_TIME,:C_ZL_ID,:C_LF_ID,:C_RH_ID,:C_LGJH,:C_QUA,:D_ARRIVE_ZG_TIME,:C_BY1,:C_BY2,:C_BY3,:C_RH,:C_DFP_HL,:C_HL,:C_XM,:D_DFPHL_START_TIME,:D_DFPHL_END_TIME,:D_KP_START_TIME,:D_KP_END_TIME,:D_HL_START_TIME,:D_HL_END_TIME,:D_PLAN_KY_TIME,:C_PLAN_ROLL,:D_ZZ_START_TIME,:D_ZZ_END_TIME,:D_XM_START_TIME,:D_XM_END_TIME,:C_STOVE_NO,:D_DFPHL_START_TIME_SJ,:D_DFPHL_END_TIME_SJ,:D_KP_START_TIME_SJ,:D_KP_END_TIME_SJ,:D_HL_START_TIME_SJ,:D_HL_END_TIME_SJ,:D_XM_START_TIME_SJ,:D_XM_END_TIME_SJ,:N_SJ_WGT,:D_START_TIME_SJ,:D_END_TIME_SJ,:N_DFP_HL_TIME,:N_HL_TIME,:C_ROUTE,:N_SLAB_PW,:C_MATRL_CODE_KP,:C_MATRL_NAME_KP,:C_KP_SIZE,:N_KP_LENGTH,:N_KP_PW,:N_USE_WGT,:D_USE_START_TIME_SJ,:D_USE_END_TIME_SJ,:D_CAN_USE_TIME,:N_RH_NUM,:N_KP_WGT,:N_XM_WGT,:C_DFP_RZ,:C_RZP_RZ,:C_DFP_YQ,:C_RZP_YQ,:C_STL_GRD_TYPE,:C_PROD_KIND,:C_TL,:N_JSCN,:C_FREE1,:C_FREE2,:N_GROUP,:C_FK,:N_ZJCLS,:N_ZJCLS_MIN,:N_ZJCLS_MAX,:C_SL,:C_WL,:C_SLAB_TYPE,:N_JC_SORT,:C_LF,:C_KP,:C_REMARK1,:C_REMARK2,:C_REMARK3,:C_REMARK4,:C_REMARK5,:N_KP_SORT,:N_XM_SORT,:C_KP_ID,:C_XM_ID)");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ORDER_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_DESIGN_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_SLAB_WGT",OracleDbType.Decimal,15),
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
                    new OracleParameter(":N_PROD_TIME",OracleDbType.Decimal,5),
                    new OracleParameter(":N_SORT",OracleDbType.Decimal,20),
                    new OracleParameter(":C_CAST_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_STATUS",OracleDbType.Decimal,1),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
                    new OracleParameter(":N_CREAT_PLAN",OracleDbType.Decimal,5),
                    new OracleParameter(":N_CREAT_ZG_PLAN",OracleDbType.Decimal,5),
                    new OracleParameter(":N_PRODUCE_TIME",OracleDbType.Decimal,5),
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
                    new OracleParameter(":N_SJ_WGT",OracleDbType.Decimal,15),
                    new OracleParameter(":D_START_TIME_SJ", OracleDbType.Date),
                    new OracleParameter(":D_END_TIME_SJ", OracleDbType.Date),
                    new OracleParameter(":N_DFP_HL_TIME",OracleDbType.Decimal,10),
                    new OracleParameter(":N_HL_TIME",OracleDbType.Decimal,10),
                    new OracleParameter(":C_ROUTE", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_SLAB_PW",OracleDbType.Decimal,15),
                    new OracleParameter(":C_MATRL_CODE_KP", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MATRL_NAME_KP", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_KP_SIZE", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_KP_LENGTH",OracleDbType.Decimal,15),
                    new OracleParameter(":N_KP_PW",OracleDbType.Decimal,15),
                    new OracleParameter(":N_USE_WGT",OracleDbType.Decimal,5),
                    new OracleParameter(":D_USE_START_TIME_SJ", OracleDbType.Date),
                    new OracleParameter(":D_USE_END_TIME_SJ", OracleDbType.Date),
                    new OracleParameter(":D_CAN_USE_TIME", OracleDbType.Date),
                    new OracleParameter(":N_RH_NUM",OracleDbType.Decimal,5),
                    new OracleParameter(":N_KP_WGT",OracleDbType.Decimal,15),
                    new OracleParameter(":N_XM_WGT",OracleDbType.Decimal,15),
                    new OracleParameter(":C_DFP_RZ", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_RZP_RZ", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_DFP_YQ", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_RZP_YQ", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STL_GRD_TYPE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PROD_KIND", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_TL", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_JSCN",OracleDbType.Decimal,5),
                    new OracleParameter(":C_FREE1", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_FREE2", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_GROUP",OracleDbType.Decimal,5),
                    new OracleParameter(":C_FK", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_ZJCLS",OracleDbType.Decimal,4),
                    new OracleParameter(":N_ZJCLS_MIN",OracleDbType.Decimal,4),
                    new OracleParameter(":N_ZJCLS_MAX",OracleDbType.Decimal,4),
                    new OracleParameter(":C_SL", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_WL", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SLAB_TYPE", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_JC_SORT",OracleDbType.Decimal,20),
                    new OracleParameter(":C_LF", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_KP", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_REMARK1", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_REMARK2", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_REMARK3", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_REMARK4", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_REMARK5", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_KP_SORT", OracleDbType.Decimal,20),
                    new OracleParameter(":N_XM_SORT", OracleDbType.Decimal,20),
                    new OracleParameter(":C_KP_ID", OracleDbType.Varchar2,50),
                    new OracleParameter(":C_XM_ID", OracleDbType.Varchar2,50)};
            parameters[0].Value = model.C_ID;
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
            parameters[91].Value = model.C_FREE1;
            parameters[92].Value = model.C_FREE2;
            parameters[93].Value = model.N_GROUP;
            parameters[94].Value = model.C_FK;
            parameters[95].Value = model.N_ZJCLS;
            parameters[96].Value = model.N_ZJCLS_MIN;
            parameters[97].Value = model.N_ZJCLS_MAX;
            parameters[98].Value = model.C_SL;
            parameters[99].Value = model.C_WL;
            parameters[100].Value = model.C_SLAB_TYPE;
            parameters[101].Value = model.N_JC_SORT;
            parameters[102].Value = model.C_LF;
            parameters[103].Value = model.C_KP;
            parameters[104].Value = model.C_REMARK1;
            parameters[105].Value = model.C_REMARK2;
            parameters[106].Value = model.C_REMARK3;
            parameters[107].Value = model.C_REMARK4;
            parameters[108].Value = model.C_REMARK5;
            parameters[109].Value = model.N_KP_SORT;
            parameters[110].Value = model.N_XM_SORT;
            parameters[111].Value = model.C_KP_ID;
            parameters[112].Value = model.C_XM_ID;

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
        public bool Update(Mod_TSP_PLAN_SMS model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TSP_PLAN_SMS set ");
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
            strSql.Append("C_FREE1=:C_FREE1,");
            strSql.Append("C_FREE2=:C_FREE2,");
            strSql.Append("N_GROUP=:N_GROUP,");
            strSql.Append("C_FK=:C_FK,");
            strSql.Append("N_ZJCLS=:N_ZJCLS,");
            strSql.Append("N_ZJCLS_MIN=:N_ZJCLS_MIN,");
            strSql.Append("N_ZJCLS_MAX=:N_ZJCLS_MAX,");
            strSql.Append("C_SL=:C_SL,");
            strSql.Append("C_WL=:C_WL,");
            strSql.Append("C_SLAB_TYPE=:C_SLAB_TYPE,");
            strSql.Append("N_JC_SORT=:N_JC_SORT,");
            strSql.Append("C_LF=:C_LF,");
            strSql.Append("C_KP=:C_KP,");
            strSql.Append("C_REMARK1=:C_REMARK1,");
            strSql.Append("C_REMARK2=:C_REMARK2,");
            strSql.Append("C_REMARK3=:C_REMARK3,");
            strSql.Append("C_REMARK4=:C_REMARK4,");
            strSql.Append("C_REMARK5=:C_REMARK5,");
            strSql.Append("N_KP_SORT=:N_KP_SORT,");
            strSql.Append("N_XM_SORT=:N_XM_SORT,");
            strSql.Append("C_KP_ID=:C_KP_ID,");
            strSql.Append("C_XM_ID=:C_XM_ID,");
            strSql.Append("D_KP_CAN_START_TIME=:D_KP_CAN_START_TIME,");
            strSql.Append("D_XM_CAN_START_TIME=:D_XM_CAN_START_TIME,");
            strSql.Append("N_KP_JRL_HOUR=:N_KP_JRL_HOUR,");
            strSql.Append("C_DQ_ORDER=:C_DQ_ORDER,");
            strSql.Append("N_NEW_STATUS=:N_NEW_STATUS,");
            strSql.Append("N_KP_STATUS=:N_KP_STATUS,");
            strSql.Append("N_XM_STATUS=:N_XM_STATUS,");
            strSql.Append("N_DHL_STATUS=:N_DHL_STATUS,");
            strSql.Append("N_HL_STATUS=:N_HL_STATUS,");
            strSql.Append("N_ORDER_WGT=:N_ORDER_WGT,");
            strSql.Append("C_BXGGZ=:C_BXGGZ,");
            strSql.Append("N_SFKPPC=:N_SFKPPC");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ORDER_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_DESIGN_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_SLAB_WGT",OracleDbType.Decimal,15),
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
                    new OracleParameter(":N_PROD_TIME",OracleDbType.Decimal,5),
                    new OracleParameter(":N_SORT",OracleDbType.Decimal,20),
                    new OracleParameter(":C_CAST_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_STATUS",OracleDbType.Decimal,1),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
                    new OracleParameter(":N_CREAT_PLAN",OracleDbType.Decimal,5),
                    new OracleParameter(":N_CREAT_ZG_PLAN",OracleDbType.Decimal,5),
                    new OracleParameter(":N_PRODUCE_TIME",OracleDbType.Decimal,5),
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
                    new OracleParameter(":N_SJ_WGT",OracleDbType.Decimal,15),
                    new OracleParameter(":D_START_TIME_SJ", OracleDbType.Date),
                    new OracleParameter(":D_END_TIME_SJ", OracleDbType.Date),
                    new OracleParameter(":N_DFP_HL_TIME",OracleDbType.Decimal,10),
                    new OracleParameter(":N_HL_TIME",OracleDbType.Decimal,10),
                    new OracleParameter(":C_ROUTE", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_SLAB_PW",OracleDbType.Decimal,15),
                    new OracleParameter(":C_MATRL_CODE_KP", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MATRL_NAME_KP", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_KP_SIZE", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_KP_LENGTH",OracleDbType.Decimal,15),
                    new OracleParameter(":N_KP_PW",OracleDbType.Decimal,15),
                    new OracleParameter(":N_USE_WGT",OracleDbType.Decimal,5),
                    new OracleParameter(":D_USE_START_TIME_SJ", OracleDbType.Date),
                    new OracleParameter(":D_USE_END_TIME_SJ", OracleDbType.Date),
                    new OracleParameter(":D_CAN_USE_TIME", OracleDbType.Date),
                    new OracleParameter(":N_RH_NUM",OracleDbType.Decimal,5),
                    new OracleParameter(":N_KP_WGT",OracleDbType.Decimal,15),
                    new OracleParameter(":N_XM_WGT",OracleDbType.Decimal,15),
                    new OracleParameter(":C_DFP_RZ", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_RZP_RZ", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_DFP_YQ", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_RZP_YQ", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STL_GRD_TYPE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PROD_KIND", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_TL", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_JSCN",OracleDbType.Decimal,5),
                    new OracleParameter(":C_FREE1", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_FREE2", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_GROUP",OracleDbType.Decimal,5),
                    new OracleParameter(":C_FK", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_ZJCLS",OracleDbType.Decimal,4),
                    new OracleParameter(":N_ZJCLS_MIN",OracleDbType.Decimal,4),
                    new OracleParameter(":N_ZJCLS_MAX",OracleDbType.Decimal,4),
                    new OracleParameter(":C_SL", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_WL", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SLAB_TYPE", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_JC_SORT",OracleDbType.Decimal,20),
                    new OracleParameter(":C_LF", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_KP", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_REMARK1", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_REMARK2", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_REMARK3", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_REMARK4", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_REMARK5", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_KP_SORT", OracleDbType.Decimal,20),
                    new OracleParameter(":N_XM_SORT", OracleDbType.Decimal,20),
                    new OracleParameter(":C_KP_ID", OracleDbType.Varchar2,50),
                    new OracleParameter(":C_XM_ID", OracleDbType.Varchar2,50),
                    new OracleParameter(":D_KP_CAN_START_TIME", OracleDbType.Date),
                    new OracleParameter(":D_XM_CAN_START_TIME", OracleDbType.Date),
                    new OracleParameter(":N_KP_JRL_HOUR", OracleDbType.Decimal,4),
                    new OracleParameter(":C_DQ_ORDER", OracleDbType.Varchar2,10),
                    new OracleParameter(":N_NEW_STATUS", OracleDbType.Decimal,4),
                    new OracleParameter(":N_KP_STATUS", OracleDbType.Decimal,4),
                    new OracleParameter(":N_XM_STATUS", OracleDbType.Decimal,4),
                    new OracleParameter(":N_DHL_STATUS", OracleDbType.Decimal,4),
                    new OracleParameter(":N_HL_STATUS", OracleDbType.Decimal,4),
                    new OracleParameter(":N_ORDER_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":C_BXGGZ", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_SFKPPC", OracleDbType.Decimal,4),
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.C_ORDER_NO;
            parameters[1].Value = model.C_DESIGN_NO;
            parameters[2].Value = model.N_SLAB_WGT;
            parameters[3].Value = model.C_CTRL_NO;
            parameters[4].Value = model.C_CCM_ID;
            parameters[5].Value = model.C_CCM_DESC;
            parameters[6].Value = model.C_PROD_NAME;
            parameters[7].Value = model.C_STL_GRD;
            parameters[8].Value = model.C_SPEC_CODE;
            parameters[9].Value = model.C_LENGTH;
            parameters[10].Value = model.C_MATRL_NO;
            parameters[11].Value = model.C_MATRL_NAME;
            parameters[12].Value = model.C_SLAB_SIZE;
            parameters[13].Value = model.C_SLAB_LENGTH;
            parameters[14].Value = model.C_STATE;
            parameters[15].Value = model.C_STD_CODE;
            parameters[16].Value = model.C_INITIALIZE_ITEM_ID;
            parameters[17].Value = model.D_P_START_TIME;
            parameters[18].Value = model.D_P_END_TIME;
            parameters[19].Value = model.N_PROD_TIME;
            parameters[20].Value = model.N_SORT;
            parameters[21].Value = model.C_CAST_NO;
            parameters[22].Value = model.N_STATUS;
            parameters[23].Value = model.C_EMP_ID;
            parameters[24].Value = model.D_MOD_DT;
            parameters[25].Value = model.C_REMARK;
            parameters[26].Value = model.N_CREAT_PLAN;
            parameters[27].Value = model.N_CREAT_ZG_PLAN;
            parameters[28].Value = model.N_PRODUCE_TIME;
            parameters[29].Value = model.C_ZL_ID;
            parameters[30].Value = model.C_LF_ID;
            parameters[31].Value = model.C_RH_ID;
            parameters[32].Value = model.C_LGJH;
            parameters[33].Value = model.C_QUA;
            parameters[34].Value = model.D_ARRIVE_ZG_TIME;
            parameters[35].Value = model.C_BY1;
            parameters[36].Value = model.C_BY2;
            parameters[37].Value = model.C_BY3;
            parameters[38].Value = model.C_RH;
            parameters[39].Value = model.C_DFP_HL;
            parameters[40].Value = model.C_HL;
            parameters[41].Value = model.C_XM;
            parameters[42].Value = model.D_DFPHL_START_TIME;
            parameters[43].Value = model.D_DFPHL_END_TIME;
            parameters[44].Value = model.D_KP_START_TIME;
            parameters[45].Value = model.D_KP_END_TIME;
            parameters[46].Value = model.D_HL_START_TIME;
            parameters[47].Value = model.D_HL_END_TIME;
            parameters[48].Value = model.D_PLAN_KY_TIME;
            parameters[49].Value = model.C_PLAN_ROLL;
            parameters[50].Value = model.D_ZZ_START_TIME;
            parameters[51].Value = model.D_ZZ_END_TIME;
            parameters[52].Value = model.D_XM_START_TIME;
            parameters[53].Value = model.D_XM_END_TIME;
            parameters[54].Value = model.C_STOVE_NO;
            parameters[55].Value = model.D_DFPHL_START_TIME_SJ;
            parameters[56].Value = model.D_DFPHL_END_TIME_SJ;
            parameters[57].Value = model.D_KP_START_TIME_SJ;
            parameters[58].Value = model.D_KP_END_TIME_SJ;
            parameters[59].Value = model.D_HL_START_TIME_SJ;
            parameters[60].Value = model.D_HL_END_TIME_SJ;
            parameters[61].Value = model.D_XM_START_TIME_SJ;
            parameters[62].Value = model.D_XM_END_TIME_SJ;
            parameters[63].Value = model.N_SJ_WGT;
            parameters[64].Value = model.D_START_TIME_SJ;
            parameters[65].Value = model.D_END_TIME_SJ;
            parameters[66].Value = model.N_DFP_HL_TIME;
            parameters[67].Value = model.N_HL_TIME;
            parameters[68].Value = model.C_ROUTE;
            parameters[69].Value = model.N_SLAB_PW;
            parameters[70].Value = model.C_MATRL_CODE_KP;
            parameters[71].Value = model.C_MATRL_NAME_KP;
            parameters[72].Value = model.C_KP_SIZE;
            parameters[73].Value = model.N_KP_LENGTH;
            parameters[74].Value = model.N_KP_PW;
            parameters[75].Value = model.N_USE_WGT;
            parameters[76].Value = model.D_USE_START_TIME_SJ;
            parameters[77].Value = model.D_USE_END_TIME_SJ;
            parameters[78].Value = model.D_CAN_USE_TIME;
            parameters[79].Value = model.N_RH_NUM;
            parameters[80].Value = model.N_KP_WGT;
            parameters[81].Value = model.N_XM_WGT;
            parameters[82].Value = model.C_DFP_RZ;
            parameters[83].Value = model.C_RZP_RZ;
            parameters[84].Value = model.C_DFP_YQ;
            parameters[85].Value = model.C_RZP_YQ;
            parameters[86].Value = model.C_STL_GRD_TYPE;
            parameters[87].Value = model.C_PROD_KIND;
            parameters[88].Value = model.C_TL;
            parameters[89].Value = model.N_JSCN;
            parameters[90].Value = model.C_FREE1;
            parameters[91].Value = model.C_FREE2;
            parameters[92].Value = model.N_GROUP;
            parameters[93].Value = model.C_FK;
            parameters[94].Value = model.N_ZJCLS;
            parameters[95].Value = model.N_ZJCLS_MIN;
            parameters[96].Value = model.N_ZJCLS_MAX;
            parameters[97].Value = model.C_SL;
            parameters[98].Value = model.C_WL;
            parameters[99].Value = model.C_SLAB_TYPE;
            parameters[100].Value = model.N_JC_SORT;
            parameters[101].Value = model.C_LF;
            parameters[102].Value = model.C_KP;
            parameters[103].Value = model.C_REMARK1;
            parameters[104].Value = model.C_REMARK2;
            parameters[105].Value = model.C_REMARK3;
            parameters[106].Value = model.C_REMARK4;
            parameters[107].Value = model.C_REMARK5;
            parameters[108].Value = model.N_KP_SORT;
            parameters[109].Value = model.N_XM_SORT;
            parameters[110].Value = model.C_KP_ID;
            parameters[111].Value = model.C_XM_ID;
            parameters[112].Value = model.D_KP_CAN_START_TIME;
            parameters[113].Value = model.D_XM_CAN_START_TIME;
            parameters[114].Value = model.N_KP_JRL_HOUR;
            parameters[115].Value = model.C_DQ_ORDER;
            parameters[116].Value = model.N_NEW_STATUS;
            parameters[117].Value = model.N_KP_STATUS;
            parameters[118].Value = model.N_XM_STATUS;
            parameters[119].Value = model.N_DHL_STATUS;
            parameters[120].Value = model.N_HL_STATUS;
            parameters[121].Value = model.N_ORDER_WGT;
            parameters[122].Value = model.C_BXGGZ;
            parameters[123].Value = model.N_SFKPPC;
            parameters[124].Value = model.C_ID;

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
        public bool TranAdd(Mod_TSP_PLAN_SMS model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TSP_PLAN_SMS(");
            strSql.Append("C_ID,C_ORDER_NO,C_DESIGN_NO,N_SLAB_WGT,C_CTRL_NO,C_CCM_ID,C_CCM_DESC,C_PROD_NAME,C_STL_GRD,C_SPEC_CODE,C_LENGTH,C_MATRL_NO,C_MATRL_NAME,C_SLAB_SIZE,C_SLAB_LENGTH,C_STATE,C_STD_CODE,C_INITIALIZE_ITEM_ID,D_P_START_TIME,D_P_END_TIME,N_PROD_TIME,N_SORT,C_CAST_NO,N_STATUS,C_EMP_ID,D_MOD_DT,C_REMARK,N_CREAT_PLAN,N_CREAT_ZG_PLAN,N_PRODUCE_TIME,C_ZL_ID,C_LF_ID,C_RH_ID,C_LGJH,C_QUA,D_ARRIVE_ZG_TIME,C_BY1,C_BY2,C_BY3,C_RH,C_DFP_HL,C_HL,C_XM,D_DFPHL_START_TIME,D_DFPHL_END_TIME,D_KP_START_TIME,D_KP_END_TIME,D_HL_START_TIME,D_HL_END_TIME,D_PLAN_KY_TIME,C_PLAN_ROLL,D_ZZ_START_TIME,D_ZZ_END_TIME,D_XM_START_TIME,D_XM_END_TIME,C_STOVE_NO,D_DFPHL_START_TIME_SJ,D_DFPHL_END_TIME_SJ,D_KP_START_TIME_SJ,D_KP_END_TIME_SJ,D_HL_START_TIME_SJ,D_HL_END_TIME_SJ,D_XM_START_TIME_SJ,D_XM_END_TIME_SJ,N_SJ_WGT,D_START_TIME_SJ,D_END_TIME_SJ,N_DFP_HL_TIME,N_HL_TIME,C_ROUTE,N_SLAB_PW,C_MATRL_CODE_KP,C_MATRL_NAME_KP,C_KP_SIZE,N_KP_LENGTH,N_KP_PW,N_USE_WGT,D_USE_START_TIME_SJ,D_USE_END_TIME_SJ,D_CAN_USE_TIME,N_RH_NUM,N_KP_WGT,N_XM_WGT,C_DFP_RZ,C_RZP_RZ,C_DFP_YQ,C_RZP_YQ,C_STL_GRD_TYPE,C_PROD_KIND,C_TL,N_JSCN,C_FREE1,C_FREE2,N_GROUP,C_FK,N_ZJCLS,N_ZJCLS_MIN,N_ZJCLS_MAX,C_SL,C_WL,C_SLAB_TYPE,N_JC_SORT,C_LF,C_KP,C_REMARK1,C_REMARK2,C_REMARK3,C_REMARK4,C_REMARK5,N_KP_SORT,N_XM_SORT,C_KP_ID,C_XM_ID)");
            strSql.Append(" values (");
            strSql.Append(":C_ID,:C_ORDER_NO,:C_DESIGN_NO,:N_SLAB_WGT,:C_CTRL_NO,:C_CCM_ID,:C_CCM_DESC,:C_PROD_NAME,:C_STL_GRD,:C_SPEC_CODE,:C_LENGTH,:C_MATRL_NO,:C_MATRL_NAME,:C_SLAB_SIZE,:C_SLAB_LENGTH,:C_STATE,:C_STD_CODE,:C_INITIALIZE_ITEM_ID,:D_P_START_TIME,:D_P_END_TIME,:N_PROD_TIME,:N_SORT,:C_CAST_NO,:N_STATUS,:C_EMP_ID,:D_MOD_DT,:C_REMARK,:N_CREAT_PLAN,:N_CREAT_ZG_PLAN,:N_PRODUCE_TIME,:C_ZL_ID,:C_LF_ID,:C_RH_ID,:C_LGJH,:C_QUA,:D_ARRIVE_ZG_TIME,:C_BY1,:C_BY2,:C_BY3,:C_RH,:C_DFP_HL,:C_HL,:C_XM,:D_DFPHL_START_TIME,:D_DFPHL_END_TIME,:D_KP_START_TIME,:D_KP_END_TIME,:D_HL_START_TIME,:D_HL_END_TIME,:D_PLAN_KY_TIME,:C_PLAN_ROLL,:D_ZZ_START_TIME,:D_ZZ_END_TIME,:D_XM_START_TIME,:D_XM_END_TIME,:C_STOVE_NO,:D_DFPHL_START_TIME_SJ,:D_DFPHL_END_TIME_SJ,:D_KP_START_TIME_SJ,:D_KP_END_TIME_SJ,:D_HL_START_TIME_SJ,:D_HL_END_TIME_SJ,:D_XM_START_TIME_SJ,:D_XM_END_TIME_SJ,:N_SJ_WGT,:D_START_TIME_SJ,:D_END_TIME_SJ,:N_DFP_HL_TIME,:N_HL_TIME,:C_ROUTE,:N_SLAB_PW,:C_MATRL_CODE_KP,:C_MATRL_NAME_KP,:C_KP_SIZE,:N_KP_LENGTH,:N_KP_PW,:N_USE_WGT,:D_USE_START_TIME_SJ,:D_USE_END_TIME_SJ,:D_CAN_USE_TIME,:N_RH_NUM,:N_KP_WGT,:N_XM_WGT,:C_DFP_RZ,:C_RZP_RZ,:C_DFP_YQ,:C_RZP_YQ,:C_STL_GRD_TYPE,:C_PROD_KIND,:C_TL,:N_JSCN,:C_FREE1,:C_FREE2,:N_GROUP,:C_FK,:N_ZJCLS,:N_ZJCLS_MIN,:N_ZJCLS_MAX,:C_SL,:C_WL,:C_SLAB_TYPE,:N_JC_SORT,:C_LF,:C_KP,:C_REMARK1,:C_REMARK2,:C_REMARK3,:C_REMARK4,:C_REMARK5,:N_KP_SORT,:N_XM_SORT,:C_KP_ID,:C_XM_ID)");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ORDER_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_DESIGN_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_SLAB_WGT",OracleDbType.Decimal,15),
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
                    new OracleParameter(":N_PROD_TIME",OracleDbType.Decimal,5),
                    new OracleParameter(":N_SORT",OracleDbType.Decimal,20),
                    new OracleParameter(":C_CAST_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_STATUS",OracleDbType.Decimal,1),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
                    new OracleParameter(":N_CREAT_PLAN",OracleDbType.Decimal,5),
                    new OracleParameter(":N_CREAT_ZG_PLAN",OracleDbType.Decimal,5),
                    new OracleParameter(":N_PRODUCE_TIME",OracleDbType.Decimal,5),
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
                    new OracleParameter(":N_SJ_WGT",OracleDbType.Decimal,15),
                    new OracleParameter(":D_START_TIME_SJ", OracleDbType.Date),
                    new OracleParameter(":D_END_TIME_SJ", OracleDbType.Date),
                    new OracleParameter(":N_DFP_HL_TIME",OracleDbType.Decimal,10),
                    new OracleParameter(":N_HL_TIME",OracleDbType.Decimal,10),
                    new OracleParameter(":C_ROUTE", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_SLAB_PW",OracleDbType.Decimal,15),
                    new OracleParameter(":C_MATRL_CODE_KP", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MATRL_NAME_KP", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_KP_SIZE", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_KP_LENGTH",OracleDbType.Decimal,15),
                    new OracleParameter(":N_KP_PW",OracleDbType.Decimal,15),
                    new OracleParameter(":N_USE_WGT",OracleDbType.Decimal,5),
                    new OracleParameter(":D_USE_START_TIME_SJ", OracleDbType.Date),
                    new OracleParameter(":D_USE_END_TIME_SJ", OracleDbType.Date),
                    new OracleParameter(":D_CAN_USE_TIME", OracleDbType.Date),
                    new OracleParameter(":N_RH_NUM",OracleDbType.Decimal,5),
                    new OracleParameter(":N_KP_WGT",OracleDbType.Decimal,15),
                    new OracleParameter(":N_XM_WGT",OracleDbType.Decimal,15),
                    new OracleParameter(":C_DFP_RZ", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_RZP_RZ", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_DFP_YQ", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_RZP_YQ", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STL_GRD_TYPE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PROD_KIND", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_TL", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_JSCN",OracleDbType.Decimal,5),
                    new OracleParameter(":C_FREE1", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_FREE2", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_GROUP",OracleDbType.Decimal,5),
                    new OracleParameter(":C_FK", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_ZJCLS",OracleDbType.Decimal,4),
                    new OracleParameter(":N_ZJCLS_MIN",OracleDbType.Decimal,4),
                    new OracleParameter(":N_ZJCLS_MAX",OracleDbType.Decimal,4),
                    new OracleParameter(":C_SL", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_WL", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SLAB_TYPE", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_JC_SORT",OracleDbType.Decimal,20),
                    new OracleParameter(":C_LF", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_KP", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_REMARK1", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_REMARK2", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_REMARK3", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_REMARK4", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_REMARK5", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_KP_SORT", OracleDbType.Decimal,20),
                    new OracleParameter(":N_XM_SORT", OracleDbType.Decimal,20),
                    new OracleParameter(":C_KP_ID", OracleDbType.Varchar2,50),
                    new OracleParameter(":C_XM_ID", OracleDbType.Varchar2,50)};
            parameters[0].Value = model.C_ID;
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
            parameters[91].Value = model.C_FREE1;
            parameters[92].Value = model.C_FREE2;
            parameters[93].Value = model.N_GROUP;
            parameters[94].Value = model.C_FK;
            parameters[95].Value = model.N_ZJCLS;
            parameters[96].Value = model.N_ZJCLS_MIN;
            parameters[97].Value = model.N_ZJCLS_MAX;
            parameters[98].Value = model.C_SL;
            parameters[99].Value = model.C_WL;
            parameters[100].Value = model.C_SLAB_TYPE;
            parameters[101].Value = model.N_JC_SORT;
            parameters[102].Value = model.C_LF;
            parameters[103].Value = model.C_KP;
            parameters[104].Value = model.C_REMARK1;
            parameters[105].Value = model.C_REMARK2;
            parameters[106].Value = model.C_REMARK3;
            parameters[107].Value = model.C_REMARK4;
            parameters[108].Value = model.C_REMARK5;
            parameters[109].Value = model.N_KP_SORT;
            parameters[110].Value = model.N_XM_SORT;
            parameters[111].Value = model.C_KP_ID;
            parameters[112].Value = model.C_XM_ID;


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
            strSql.Append("delete from TSP_PLAN_SMS ");
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
        /// 删除一条数据
        /// </summary>
        public bool DeleteByjcid(string C_FK)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from TSP_PLAN_SMS ");
            strSql.Append(" where N_CREAT_PLAN=1 and  C_FK=:C_FK ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_FK", OracleDbType.Varchar2,100)         };
            parameters[0].Value = C_FK;

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
            strSql.Append("delete from TSP_PLAN_SMS ");
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
        public Mod_TSP_PLAN_SMS GetModel(string C_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from TSP_PLAN_SMS ");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)            };
            parameters[0].Value = C_ID;

            Mod_TSP_PLAN_SMS model = new Mod_TSP_PLAN_SMS();
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
        public Mod_TSP_PLAN_SMS GetModel_Trans(string C_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from TSP_PLAN_SMS ");
            strSql.Append(" where C_ID='" + C_ID + "' ");

            Mod_TSP_PLAN_SMS model = new Mod_TSP_PLAN_SMS();
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
        public Mod_TSP_PLAN_SMS DataRowToModel(DataRow row)
        {
            Mod_TSP_PLAN_SMS model = new Mod_TSP_PLAN_SMS();
            if (row != null)
            {
                if (row["C_ID"] != null)
                {
                    model.C_ID = row["C_ID"].ToString();
                }
                if (row["C_BXGGZ"] != null)
                {
                    model.C_BXGGZ = row["C_BXGGZ"].ToString();
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
                if (row["C_FREE1"] != null)
                {
                    model.C_FREE1 = row["C_FREE1"].ToString();
                }
                if (row["C_FREE2"] != null)
                {
                    model.C_FREE2 = row["C_FREE2"].ToString();
                }
                if (row["N_GROUP"] != null && row["N_GROUP"].ToString() != "")
                {
                    model.N_GROUP = decimal.Parse(row["N_GROUP"].ToString());
                }
                if (row["C_FK"] != null)
                {
                    model.C_FK = row["C_FK"].ToString();
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
                if (row["C_LF"] != null)
                {
                    model.C_LF = row["C_LF"].ToString();
                }
                if (row["C_KP"] != null)
                {
                    model.C_KP = row["C_KP"].ToString();
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
                if (row["N_KP_SORT"] != null && row["N_KP_SORT"].ToString() != "")
                {
                    model.N_KP_SORT = decimal.Parse(row["N_KP_SORT"].ToString());
                }
                if (row["N_XM_SORT"] != null && row["N_XM_SORT"].ToString() != "")
                {
                    model.N_XM_SORT = decimal.Parse(row["N_XM_SORT"].ToString());
                }
                if (row["C_KP_ID"] != null)
                {
                    model.C_KP_ID = row["C_KP_ID"].ToString();
                }
                if (row["C_XM_ID"] != null)
                {
                    model.C_XM_ID = row["C_XM_ID"].ToString();
                }
                if (row["D_KP_CAN_START_TIME"] != null && row["D_KP_CAN_START_TIME"].ToString() != "")
                {
                    model.D_KP_CAN_START_TIME = DateTime.Parse(row["D_KP_CAN_START_TIME"].ToString());
                }
                if (row["D_XM_CAN_START_TIME"] != null && row["D_XM_CAN_START_TIME"].ToString() != "")
                {
                    model.D_XM_CAN_START_TIME = DateTime.Parse(row["D_XM_CAN_START_TIME"].ToString());
                }
                if (row["N_KP_JRL_HOUR"] != null && row["N_KP_JRL_HOUR"].ToString() != "")
                {
                    model.N_KP_JRL_HOUR = decimal.Parse(row["N_KP_JRL_HOUR"].ToString());
                }
                if (row["C_DQ_ORDER"] != null)
                {
                    model.C_DQ_ORDER = row["C_DQ_ORDER"].ToString();
                }
                if (row["N_NEW_STATUS"] != null && row["N_NEW_STATUS"].ToString() != "")
                {
                    model.N_NEW_STATUS = decimal.Parse(row["N_NEW_STATUS"].ToString());
                }
                if (row["N_KP_STATUS"] != null && row["N_KP_STATUS"].ToString() != "")
                {
                    model.N_KP_STATUS = decimal.Parse(row["N_KP_STATUS"].ToString());
                }
                if (row["N_XM_STATUS"] != null && row["N_XM_STATUS"].ToString() != "")
                {
                    model.N_XM_STATUS = decimal.Parse(row["N_XM_STATUS"].ToString());
                }
                if (row["N_DHL_STATUS"] != null && row["N_DHL_STATUS"].ToString() != "")
                {
                    model.N_DHL_STATUS = decimal.Parse(row["N_DHL_STATUS"].ToString());
                }
                if (row["N_HL_STATUS"] != null && row["N_HL_STATUS"].ToString() != "")
                {
                    model.N_HL_STATUS = decimal.Parse(row["N_HL_STATUS"].ToString());
                }
                if (row["N_ORDER_WGT"] != null && row["N_ORDER_WGT"].ToString() != "")
                {
                    model.N_ORDER_WGT = decimal.Parse(row["N_ORDER_WGT"].ToString());
                }
                if (row["C_BXGGZ"] != null)
                {
                    model.C_BXGGZ = row["C_BXGGZ"].ToString();
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
            strSql.Append(" FROM TSP_PLAN_SMS ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where  " + strWhere);
            }
            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet Get_List()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT TS.C_ID,TT.C_ORDER_NO FROM tmo_order tt INNER JOIN tsp_plan_sms ts ON ts.c_order_no=tt.c_id WHERE tt.c_order_no IN(SELECT c_order_no FROM(SELECT t.c_order_no, COUNT(1)AS num1 FROM tmo_order t  GROUP BY t.c_order_no) WHERE num1 > 1)  ");


            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取可以混浇的钢种炉次计划
        /// </summary>
        /// <param name="N_GROUP">混浇分组号</param>
        /// <param name="C_STL_GRD">钢种</param>
        /// <param name="C_STD_CODE">执行标准</param>
        /// <param name="C_MATRL_NO">物料编码</param>
        /// <returns></returns>
        public DataTable GetList(int N_GROUP, string C_STL_GRD, string C_STD_CODE, string C_MATRL_NO)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * ");
            strSql.Append(" FROM TSP_PLAN_SMS  WHERE 1=1 and N_STATUS=1 ");

            strSql.Append(" AND N_GROUP= " + N_GROUP);
            strSql.Append(" AND C_STL_GRD=  '" + C_STL_GRD + "'");
            strSql.Append(" AND C_STD_CODE= '" + C_STD_CODE + "'");
            strSql.Append(" AND C_MATRL_NO= '" + C_MATRL_NO + "'");

            return DbHelperOra.Query(strSql.ToString()).Tables[0];
        }
        /// <summary>
        /// 根据浇次、连铸查询排产的炉次计划
        /// </summary>
        /// <param name="C_FK">浇次计划主键</param>
        /// <returns></returns>
        public DataSet GetListByJcID(string C_FK)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(@"SELECT T.C_ID,
       T.C_ORDER_NO,
       T.C_DESIGN_NO,
       T.N_SLAB_WGT,
       T.C_CTRL_NO,
       T.C_CCM_ID,
       T.C_CCM_DESC,
       T.C_PROD_NAME,
       T.C_STL_GRD,
       T.C_SPEC_CODE,
       T.C_LENGTH,
       T.C_MATRL_NO,
       T.C_MATRL_NAME,
       T.C_SLAB_SIZE,
       T.C_SLAB_LENGTH,
       T.C_STATE,
       T.C_STD_CODE,
       T.C_INITIALIZE_ITEM_ID,
       T.D_P_START_TIME,
       T.D_P_END_TIME,
       T.N_PROD_TIME,
       T.N_SORT,
       T.C_CAST_NO,
       T.N_STATUS,
       T.C_EMP_ID,
       T.D_MOD_DT,
       T.C_REMARK,
       T.N_CREAT_PLAN,
       T.N_CREAT_ZG_PLAN,
       T.N_PRODUCE_TIME,
       T.C_ZL_ID,
       T.C_LF_ID,
       T.C_RH_ID,
       T.C_LGJH,
       T.C_QUA,
       T.D_ARRIVE_ZG_TIME,
       T.C_BY1,
       T.C_BY2,
       T.C_BY3,
       T.C_RH,
       T.C_DFP_HL,
       T.C_HL,
       T.C_XM,
       T.D_DFPHL_START_TIME,
       T.D_DFPHL_END_TIME,
       T.D_KP_START_TIME,
       T.D_KP_END_TIME,
       T.D_HL_START_TIME,
       T.D_HL_END_TIME,
       T.D_PLAN_KY_TIME,
       T.C_PLAN_ROLL,
       T.D_ZZ_START_TIME,
       T.D_ZZ_END_TIME,
       T.D_XM_START_TIME,
       T.D_XM_END_TIME,
      TA.HEATID  C_STOVE_NO,
       T.D_DFPHL_START_TIME_SJ,
       T.D_DFPHL_END_TIME_SJ,
       T.D_KP_START_TIME_SJ,
       T.D_KP_END_TIME_SJ,
       T.D_HL_START_TIME_SJ,
       T.D_HL_END_TIME_SJ,
       T.D_XM_START_TIME_SJ,
       T.D_XM_END_TIME_SJ,
       T.N_SJ_WGT,
       T.D_START_TIME_SJ,
       T.D_END_TIME_SJ,
       T.N_DFP_HL_TIME,
       T.N_HL_TIME,
       T.C_ROUTE,
       T.N_SLAB_PW,
       T.C_MATRL_CODE_KP,
       T.C_MATRL_NAME_KP,
       T.C_KP_SIZE,
       T.N_KP_LENGTH,
       T.N_KP_PW,
       T.N_USE_WGT,
       T.D_USE_START_TIME_SJ,
       T.D_USE_END_TIME_SJ,
       T.D_CAN_USE_TIME,
       T.N_RH_NUM,
       T.N_KP_WGT,
       T.N_XM_WGT,
       T.C_DFP_RZ,
       T.C_RZP_RZ,
       T.C_DFP_YQ,
       T.C_RZP_YQ,
       T.C_STL_GRD_TYPE,
       T.C_PROD_KIND,
       T.C_TL,
       T.N_JSCN,
       T.C_FREE1,
       T.C_FREE2,
       T.N_GROUP,
       T.C_FK,
       T.N_ZJCLS,
       T.N_ZJCLS_MIN,
       T.N_ZJCLS_MAX,
       T.C_SL,
       T.C_WL,
       T.C_SLAB_TYPE,
       T.N_JC_SORT,
       T.C_LF,
       T.C_KP,
       T.C_REMARK1,
       T.C_REMARK2,
       T.C_REMARK3,
       T.C_REMARK4,
       T.C_REMARK5,
       T.N_KP_SORT,
       T.N_XM_SORT,
       T.C_KP_ID,
       T.C_XM_ID,
       T.D_KP_CAN_START_TIME,
       T.D_XM_CAN_START_TIME,
       T.N_KP_JRL_HOUR,
       T.C_DQ_ORDER,
       T.N_NEW_STATUS,
       T.N_KP_STATUS,
       T.N_XM_STATUS,
       T.N_DHL_STATUS,
       T.N_HL_STATUS,
t.C_BXGGZ,
       T.N_ORDER_WGT FROM TSP_PLAN_SMS T LEFT JOIN  TSC_STOVE_TIME TA ON T.C_ID = TA.C_PLAN_SMS_ID  ");
            strSql.Append("  where T.N_STATUS=1 ");

            strSql.Append(" AND T.C_FK='" + C_FK + "' ");

            strSql.Append(" ORDER BY T.N_SORT ");
            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 根据混浇分组号获取炉次计划
        /// </summary>
        /// <param name="N_GROUP">浇次计划主键</param>
        /// <returns></returns>
        public DataSet GetListByJcGroup(int N_GROUP)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * ");
            strSql.Append(" FROM TSP_PLAN_SMS where n_group= " + N_GROUP);
            strSql.Append(" ORDER BY N_JC_SORT,N_SORT,C_STATE ");
            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 获得数据列表-浇次号
        /// </summary>
        public DataSet GetList_CAST_NO(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * ");
            strSql.Append(" FROM TSP_PLAN_SMS ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where C_CAST_NO = '" + strWhere + "' ");
            }
            strSql.Append(" order by N_SORT ");
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
            strSql.Append(" FROM TSP_PLAN_SMS t ");
            if (C_FK.Trim() != "")
            {
                strSql.Append(" where t.c_fk = '" + C_FK + "' ");
            }
            strSql.Append(" group by t.c_stl_grd,t.c_std_code ");
            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 获得数据列表-浇次号
        /// </summary>
        public DataSet GetList_Number(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  N_SORT ");
            strSql.Append(" FROM TSP_PLAN_SMS ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where C_CAST_NO = '" + strWhere + "' ");
            }
            strSql.Append(" order by N_SORT ");
            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM TSP_PLAN_SMS ");
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
            strSql.Append(")AS Row, T.*  from TSP_PLAN_SMS T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 修改生产顺序
        /// </summary>
        /// <param name="c_id">主键</param>
        /// <param name="C_CAST_NO">浇次</param>         
        /// <param name="sort_new">顺序-新</param>
        /// <param name="sort_old">顺序-旧</param>
        /// <param name="stype">判断大小</param>
        /// <returns></returns>
        public bool Update_SX(string c_id, string C_CAST_NO, int sort_new, int sort_old, string stype)
        {
            StringBuilder strSql = new StringBuilder();

            if (stype == "1")
            {
                strSql.Append(" update TSP_PLAN_SMS t set t.n_sort=t.n_sort+1 where t.c_id not in ('" + c_id + "') and C_CAST_NO='" + C_CAST_NO + "'  and t.n_sort>=" + sort_new + " and t.n_sort<=" + sort_old + " ");
            }

            if (stype == "0")
            {
                strSql.Append(" update TSP_PLAN_SMS t set t.n_sort=t.n_sort-1 where t.c_id not in ('" + c_id + "') and t.n_sort>" + sort_old + " and t.n_sort<=" + sort_new + " and C_CAST_NO='" + C_CAST_NO + "'   ");
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
        #endregion  BasicMethod
        #region  ExtensionMethod

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(string C_CCM_ID, string C_INITIALIZE_ITEM_ID, int sort_old)
        {
            StringBuilder strSql = new StringBuilder();

            strSql.Append(" update tsp_plan_sms t set t.n_sort=t.n_sort-1 where C_CCM_ID='" + C_CCM_ID + "' and t.C_INITIALIZE_ITEM_ID='" + C_INITIALIZE_ITEM_ID + "' and n_sort>" + sort_old + " ");

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
        /// 重新计算连铸计划执行时间
        /// </summary>
        /// <param name="D_START_TIME">指定开始时间</param>
        /// <param name="C_CCM_ID">连铸id</param>
        /// <returns></returns>
        public int ResetTime(string D_START_TIME, string C_CCM_ID)
        {
            OracleParameter[] parameters = {
                    new OracleParameter("P_START_TIME", OracleDbType.Varchar2,100),
            new OracleParameter("P_CC_ID", OracleDbType.Varchar2,100)};
            parameters[0].Value = D_START_TIME;
            parameters[1].Value = C_CCM_ID;
            return DbHelperOra.RunProcedure("pkg_p_plan.P_UPDATE_LG_PLAN_TIME", parameters);



        }

        /// <summary>
        /// 撤销炼钢计划
        /// </summary>
        /// <param name="P_INITIALIZE_ITEM_ID">订单方案号</param>
        /// <param name="P_CAST_NO">浇次号</param>
        /// <param name="P_CCM_CODE">连铸机代码</param>
        /// <returns></returns>
        public int Delete_LG_Plan(string P_INITIALIZE_ITEM_ID, string P_CAST_NO, string P_CCM_CODE)
        {
            OracleParameter[] parameters = {
                    new OracleParameter("P_INITIALIZE_ITEM_ID", OracleDbType.Varchar2,100),
            new OracleParameter("P_CAST_NO", OracleDbType.Varchar2,100),
            new OracleParameter("P_CCM_CODE", OracleDbType.Varchar2,100)};

            parameters[0].Value = P_INITIALIZE_ITEM_ID;
            parameters[1].Value = P_CAST_NO;
            parameters[2].Value = P_CCM_CODE;

            return DbHelperOra.RunProcedure("pkg_p_plan.P_DELETE_LG_PLAN", parameters);
        }

        /// <summary>
        ///  获取最大计划号
        /// </summary>
        /// <returns></returns>
        public string GetMax_PlanID()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select max(t.c_plan_sms_id) from tsp_plan_sms t WHERE T.N_STATUS = 1  ");

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
        ///  获取上个计划结束时间
        /// </summary>
        /// <returns></returns>
        public string Get_EndTime(string c_cast_no, string n_sort)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" select t.D_P_END_TIME from tsp_plan_sms t where T.N_STATUS = 1  and t.n_sort='" + n_sort + "' ");

            if (!string.IsNullOrEmpty(c_cast_no))
            {
                strSql.Append(" and t.c_cast_no='" + c_cast_no + "'  ");
            }

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
        /// 查询已生成的浇次计划
        /// </summary>
        /// <param name="C_CCM_ID">连铸主键</param>
        /// <param name="C_TYPE">是否已经下发mes0未下1已下</param>
        /// <param name="dt1">排产时间（开始）</param>
        /// <param name="dt2">排产时间（结束）</param>
        /// <returns>浇次计划表</returns>
        public DataTable GetJCJH(string C_CCM_ID, int C_TYPE, DateTime? dt1, DateTime? dt2)
        {
            string sql = @"SELECT * FROM(SELECT";
            sql = sql + "  MAX(TO_NUMBER(T.C_CTRL_NO)) C_CTRL_NO,";//浇次序号
            sql = sql + "   T.C_CAST_NO, ";//浇次号
            sql = sql + "   SUM(T.N_SLAB_WGT) N_SLAB_WGT, ";//浇次重量
            sql = sql + "   SUM(1) N_LS, ";//炉数
            sql = sql + "   T.C_CCM_ID, ";//连铸主键
            sql = sql + "   T.C_CCM_DESC, ";//连铸号
            sql = sql + "   MAX(T.C_STL_GRD || '|' || T.C_STD_CODE) C_STL_GRD, ";//钢种
            sql = sql + "   MIN(T.D_MOD_DT) D_MOD_DT, ";//排产时间
            sql = sql + "   MAX(NVL(T.N_PRODUCE_TIME, 0)) N_PRODUCE_TIME, ";//停机时间
            sql = sql + "   MIN(T.D_P_START_TIME) D_P_START_TIME, ";//计划开始时间
            sql = sql + "   MAX(T.D_P_END_TIME) D_P_END_TIME, ";//计划结束时间
            sql = sql + "    MIN(DECODE(N_CREAT_PLAN, 0, 0, 1,0,1))  C_TYPE ,nvl(C_BY3,'白色') C_BY3";//类型 0未下发MES，1已下发MES

            sql = sql + "  FROM TSP_PLAN_SMS T";//
            sql = sql + "  WHERE T.N_STATUS = 1 AND T.C_CCM_ID = '" + C_CCM_ID + "'";//
            sql = sql + "   GROUP BY T.C_CAST_NO, T.C_CCM_ID, T.C_CCM_DESC,nvl(C_BY3,'白色')) A";//
            sql = sql + "  WHERE A.C_TYPE = " + C_TYPE + "";//
            if (dt1 != null)
            {
                sql = sql + "  AND  A.D_MOD_DT >=TO_DATE( '" + dt1.ToString() + "','yyyy-mm-dd hh24:mi:ss')";//
            }
            if (dt2 != null)
            {
                sql = sql + "  AND  A.D_MOD_DT <=TO_DATE( '" + dt2.ToString() + "','yyyy-mm-dd hh24:mi:ss')";//
            }
            sql = sql + "  ORDER BY TO_NUMBER(A.C_CTRL_NO)";
            return DbHelperOra.Query(sql.ToString()).Tables[0];
        }

        /// <summary>
        /// 查询浇次计划
        /// </summary>
        /// <param name="c_ccm">连铸号</param>
        /// <param name="dt1">查询开始日期</param>
        /// <param name="dt2">查询截止日期</param>
        /// <returns></returns>
        public DataTable GetJCJH(string c_ccm, string dt1, string dt2)
        {
            string sql = @"SELECT *
  FROM(SELECT MAX(TO_NUMBER(T.C_CTRL_NO)) C_CTRL_NO,
               T.C_CAST_NO,
               SUM(T.N_SLAB_WGT) N_SLAB_WGT,
               SUM(1) N_LS,
               T.C_CCM_ID,
               T.C_CCM_DESC,
               MAX(T.C_STL_GRD || '|' || T.C_STD_CODE) C_STL_GRD,
               MIN(T.D_MOD_DT) D_MOD_DT,
               MAX(NVL(T.N_PRODUCE_TIME, 0)) N_PRODUCE_TIME,
               MIN(T.D_P_START_TIME) D_P_START_TIME,
               MAX(T.D_P_END_TIME) D_P_END_TIME,
               MIN(DECODE(N_CREAT_PLAN, 0, 0, 1, 0, 1)) C_TYPE
          FROM TSP_PLAN_SMS T
         WHERE 1 = 1 ";
            if (c_ccm.Trim() != "")
            {
                sql = sql + " AND C_CCM_DESC = '" + c_ccm + "'";
            }
            sql = sql + "  GROUP BY T.C_CAST_NO, T.C_CCM_ID, T.C_CCM_DESC) A WHERE 1=1  ";// A.C_TYPE = 0
            if (dt1.Trim() != "")
            {
                sql = sql + " AND A.D_MOD_DT >= TO_DATE('" + dt1 + " ', 'YYYY-MM-DD HH24:MI:SS')";
            }

            if (dt2.Trim() != "")
            {
                sql = sql + "  AND A.D_MOD_DT <= TO_DATE('" + dt2 + " ', 'YYYY-MM-DD HH24:MI:SS')";
            }

            sql = sql + " ORDER BY TO_NUMBER(A.C_CTRL_NO)";

            return DbHelperOra.Query(sql.ToString()).Tables[0];
        }

        /// <summary>
        /// 根据浇次号得到对应的炉次号
        /// </summary>
        /// <param name="C_CCM_ID">连铸主键</param>
        /// <param name="C_CAST_NO">浇次号</param>
        /// <returns>炉次计划</returns>
        public DataTable GetLCJH(string C_CCM_ID, string C_CAST_NO)
        {
            string sql = @" SELECT T.C_ID, ";
            sql = sql + "  T.C_CTRL_NO, ";//浇次序号 */
            sql = sql + "  T.C_CAST_NO,  ";//浇次号
            sql = sql + "  T.C_ORDER_NO,  ";//订单主键
            sql = sql + "  T.N_SLAB_WGT,  ";//炉次重量
            sql = sql + "  T.C_CCM_ID,  ";//连铸主键
            sql = sql + "  T.C_CCM_DESC,  ";//连铸号
            sql = sql + "  T.C_STL_GRD,  ";//钢种
            sql = sql + "  T.C_STD_CODE,  ";//执行标准
            sql = sql + "  T.C_INITIALIZE_ITEM_ID,  ";//组号
            sql = sql + "  T.N_SORT,  ";//炉次顺序号
            sql = sql + "  T.D_MOD_DT,  ";//排产时间
            sql = sql + "  T.N_PRODUCE_TIME,  ";//停机时间
            sql = sql + "  T.D_P_START_TIME,  ";//计划开始时间
            sql = sql + "  T.D_P_END_TIME,  ";//计划结束时间
            sql = sql + "   C_STATE,  ";//0有订单1没有订单
            sql = sql + "   DECODE(N_CREAT_PLAN,0,0,1,0,1)  C_TYPE  ";//类型 0未下发MES，1已下发MES
            sql = sql + "   FROM TSP_PLAN_SMS T ";//
            sql = sql + " WHERE T.N_STATUS = 1 AND  T.C_CAST_NO = '" + C_CAST_NO + "' ";//
            if (C_CCM_ID.Trim() != "")
            {
                sql = sql + " AND T.C_CCM_ID = '" + C_CCM_ID + "'  ";
            }
            sql = sql + "  ORDER BY T.N_SORT";
            return DbHelperOra.Query(sql.ToString()).Tables[0];
        }



        /// <summary>
        /// 获取当前连铸炉次计划最大序号
        /// </summary>
        /// <param name="C_CCM_ID">连铸</param>
        /// <returns>最大序号</returns>
        public int GetMaxSortYXMES(string C_CCM_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select MAX(N_SORT) N_SORT  from TSP_PLAN_SMS");
            strSql.Append(" where N_STATUS = 1 AND N_CREAT_PLAN>=3 AND C_CCM_ID=:C_CCM_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_CCM_ID", OracleDbType.Varchar2,100)         };
            parameters[0].Value = C_CCM_ID;

            DataTable dt = DbHelperOra.Query(strSql.ToString(), parameters).Tables[0];
            if (dt.Rows.Count > 0)
            {
                if (dt.Rows[0]["N_SORT"].ToString().Trim() == "")
                {
                    return 0;

                }
                else
                {
                    return Convert.ToInt32(dt.Rows[0]["N_SORT"].ToString().Trim());
                }
            }
            else
            {
                return 0;
            }
        }


        /// <summary>
        /// 查询已生成炉号的计划
        /// </summary>
        /// <param name="C_CCM_ID">连铸主键</param>
        /// <param name="strType">状态；2已生成炉次计划；3-发送炼钢MES；4计划已完成</param>
        /// <returns></returns>
        public DataTable Get_Stove_JH(string C_CCM_ID, string strType)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" SELECT *  FROM(SELECT MAX(TO_NUMBER(T.C_CTRL_NO)) C_CTRL_NO, T.C_CAST_NO, SUM(T.N_SLAB_WGT) N_SLAB_WGT, SUM(1) N_LS, T.C_CCM_ID, T.C_CCM_DESC, MAX(T.C_STL_GRD || '  ' || T.C_STD_CODE) C_STL_GRD, MIN(T.D_MOD_DT) D_MOD_DT, MAX(NVL(T.N_PRODUCE_TIME, 0)) N_PRODUCE_TIME, MIN(T.D_P_START_TIME) D_P_START_TIME, MAX(T.D_P_END_TIME) D_P_END_TIME, MIN(TO_NUMBER(TB.C_IS_TO_MES)) C_TYPE FROM TSP_PLAN_SMS T INNER JOIN TPP_CAST_PLAN TB ON T.C_ID=TB.C_PLAN_ID WHERE T.C_CCM_ID = '" + C_CCM_ID + "' GROUP BY T.C_CAST_NO, T.C_CCM_ID, T.C_CCM_DESC) A ");

            strSql.Append(" WHERE T.N_STATUS = 1 AND A.C_TYPE in ('" + strType + "') ");

            strSql.Append("  ORDER BY TO_NUMBER(A.C_CTRL_NO) ");

            return DbHelperOra.Query(strSql.ToString()).Tables[0];
        }


        /// <summary>
        /// 查询已生成炉号的计划详细信息
        /// </summary>
        /// <param name="C_CCM_ID">连铸主键</param>
        /// <param name="C_CAST_NO">浇次主键</param>
        /// <param name="C_IS_TO_MES">0未传mes，1已传mes</param>
        /// <param name="strStartTime">计划下发时间（开始）</param>
        /// <param name="strEndTime">计划下发时间（结束）</param>
        /// <returns></returns>
        public DataTable Get_Stove_JH_ITEM(string C_CCM_ID, string C_CAST_NO, string C_IS_TO_MES, string strStartTime, string strEndTime)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" SELECT TB.C_ID, T.C_CTRL_NO AS 浇次号, T.C_CAST_NO AS 浇次主键, T.C_ORDER_NO AS 订单主键, T.N_SLAB_WGT AS 计划量, T.C_CCM_ID, T.C_CCM_DESC, T.C_STL_GRD AS 钢种, T.C_STD_CODE AS 执行标准,T.C_SLAB_SIZE as 断面,T.C_SLAB_LENGTH AS 定尺, T.N_SORT, T.D_MOD_DT AS 排产时间, DECODE(TB.C_IS_TO_MES, '0', '未下发', '1', '已下发','2','进行中','3','已完成', '') AS 计划状态, TB.C_LD_DESC AS 转炉, TB.C_LF_DESC AS 精炼, TB.C_RH_DESC AS 真空, TB.C_CC_DESC AS 连铸, TB.D_AIM_BOFSTART_TIME AS 转炉开始, TB.D_AIM_BOFTAPPED_TIME AS 转炉结束, TB.D_AIM_LFSTART_TIME AS 精炼开始, TB.D_AIM_LFEND_TIME AS 精炼结束, TB.D_AIM_RHSTART_TIME AS 真空开始, TB.D_AIM_RHEND_TIME AS 真空结束, TB.D_AIM_CASTINGSTART_TIME AS 连铸开始, TB.D_AIM_CASTINGEND_TIME AS 连铸结束,TB.C_HEAT_ID AS 炉号,T.C_ZL_ID,T.C_LF_ID,T.C_RH_ID,TB.C_PLAN_ID ");

            strSql.Append(" FROM TSP_PLAN_SMS T INNER JOIN TPP_CAST_PLAN TB ON T.C_ID = TB.C_PLAN_ID ");

            strSql.Append(" WHERE T.N_STATUS = 1  ");

            if (!string.IsNullOrEmpty(C_CCM_ID.Trim()))
            {
                strSql.Append(" and T.C_CCM_ID = '" + C_CCM_ID + "' ");
            }

            if (!string.IsNullOrEmpty(C_CAST_NO.Trim()))
            {
                strSql.Append(" and T.C_CAST_NO = '" + C_CAST_NO + "' ");
            }

            if (!string.IsNullOrEmpty(C_IS_TO_MES.Trim()))
            {
                strSql.Append(" and Tb.C_IS_TO_MES = '" + C_IS_TO_MES + "' ");
            }

            if (!string.IsNullOrEmpty(strStartTime.Trim()) && !string.IsNullOrEmpty(strEndTime.Trim()))
            {
                strSql.Append(" and Tb.D_DOWN_TIME between to_date('" + strStartTime.Trim() + "','yyyy-mm-dd hh24:mi:ss') and to_date('" + strEndTime.Trim() + "','yyyy-mm-dd hh24:mi:ss') ");
            }

            strSql.Append("   ORDER BY T.N_SORT ");

            return DbHelperOra.Query(strSql.ToString()).Tables[0];
        }

        /// <summary>
        /// 查询已生成炉号的计划详细信息
        /// </summary>
        /// <param name="C_ZL_ID">转炉主键</param>
        /// <param name="C_CAST_NO">浇次主键</param>
        /// <param name="C_IS_TO_MES">0未传mes，1已传mes</param>
        /// <param name="strStartTime">计划下发时间（开始）</param>
        /// <param name="strEndTime">计划下发时间（结束）</param>
        /// <returns></returns>
        public DataTable Get_Stove_JH_YXF_ITEM(string C_ZL_ID, string C_CAST_NO, string C_IS_TO_MES, string strStartTime, string strEndTime)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" SELECT TB.C_ID, T.C_CTRL_NO AS 浇次号, T.C_CAST_NO AS 浇次主键, T.C_ORDER_NO AS 订单主键, T.N_SLAB_WGT AS 计划量, T.C_CCM_ID, T.C_CCM_DESC, T.C_STL_GRD AS 钢种, T.C_STD_CODE AS 执行标准,T.C_SLAB_SIZE as 断面,T.C_SLAB_LENGTH AS 定尺, T.N_SORT, T.D_MOD_DT AS 排产时间, DECODE(T.N_CREAT_PLAN, '3', '已下发','4','已完成', '') AS 计划状态, TB.C_LD_DESC AS 转炉, TB.C_LF_DESC AS 精炼, TB.C_RH_DESC AS 真空, TB.C_CC_DESC AS 连铸, TB.D_AIM_BOFSTART_TIME AS 转炉开始, TB.D_AIM_BOFTAPPED_TIME AS 转炉结束, TB.D_AIM_LFSTART_TIME AS 精炼开始, TB.D_AIM_LFEND_TIME AS 精炼结束, TB.D_AIM_RHSTART_TIME AS 真空开始, TB.D_AIM_RHEND_TIME AS 真空结束, TB.D_AIM_CASTINGSTART_TIME AS 连铸开始, TB.D_AIM_CASTINGEND_TIME AS 连铸结束,TB.C_HEAT_ID AS 炉号,TB.C_BOF_ID AS C_ZL_ID,TB.C_LF_ID AS C_LF_ID,TB.C_RH_ID AS C_RH_ID, TB.C_PLAN_ID ");

            strSql.Append(" FROM TSP_PLAN_SMS T INNER JOIN TPP_CAST_PLAN TB ON T.C_ID = TB.C_PLAN_ID ");

            strSql.Append(" WHERE T.N_STATUS = 1  ");

            if (!string.IsNullOrEmpty(C_ZL_ID.Trim()))
            {
                strSql.Append(" and TB.C_BOF_ID = '" + C_ZL_ID + "' ");
            }

            if (!string.IsNullOrEmpty(C_CAST_NO.Trim()))
            {
                strSql.Append(" and T.C_CAST_NO = '" + C_CAST_NO + "' ");
            }

            if (!string.IsNullOrEmpty(C_IS_TO_MES.Trim()))
            {
                strSql.Append(" and Tb.C_IS_TO_MES = '" + C_IS_TO_MES + "' ");
            }

            if (!string.IsNullOrEmpty(strStartTime.Trim()) && !string.IsNullOrEmpty(strEndTime.Trim()))
            {
                strSql.Append(" and Tb.D_DOWN_TIME between to_date('" + strStartTime.Trim() + "','yyyy-mm-dd hh24:mi:ss') and to_date('" + strEndTime.Trim() + "','yyyy-mm-dd hh24:mi:ss') ");
            }

            strSql.Append("   ORDER BY TB.C_HEAT_ID asc ");

            return DbHelperOra.Query(strSql.ToString()).Tables[0];
        }

        /// <summary>
        /// 根据订单主键获取该订单连铸计划生产时间段
        /// </summary>
        /// <param name="c_order_id">订单主键</param>
        /// <returns></returns>
        public DataTable GetOrderCCTime(string c_order_id)
        {

            string sql = @"SELECT MIN(TA.D_P_START_TIME) D_P_START_TIME,
       MAX(TA.D_P_END_TIME) D_P_END_TIME
  FROM TSP_PLAN_SMS TA, TSP_PLAN_SMS_ITEM TB
 WHERE TA.N_STATUS = 1 AND TB.C_PLAN_SMS_ID = TA.C_ID
   AND TB.C_PRODUCTION_PLAN_ID = '" + c_order_id + "'";
            return DbHelperOra.Query(sql.ToString()).Tables[0];
        }


        /// <summary>
        /// 获取计划数量
        /// </summary>
        /// <param name="c_is_to_mes">0未传mes，1已传mes</param>
        /// <returns></returns>
        public int Get_Plan_Count(string c_is_to_mes)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT count(1)  FROM TSP_PLAN_SMS t inner join tpp_cast_plan tb on t.c_id = tb.c_plan_id WHERE T.N_STATUS = 1 AND t.n_creat_plan = '2' and tb.c_is_to_mes = '" + c_is_to_mes + "' ");

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
        /// 获得未生成各个工序计划的连铸计划
        /// </summary>
        /// <param name="C_CCM_ID">连铸ID</param>
        /// <param name="C_FK">浇次主键</param>
        /// <returns></returns>
        public DataSet Get_Plan_List_Trans(string C_CCM_ID, string C_FK)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT C_ID,C_ORDER_NO,C_DESIGN_NO,N_SLAB_WGT,C_CTRL_NO,C_PROD_NAME,C_STL_GRD,C_SPEC_CODE,C_LENGTH,C_MATRL_NO,C_MATRL_NAME,C_SLAB_SIZE,C_SLAB_LENGTH,C_STATE,C_STD_CODE,C_INITIALIZE_ITEM_ID,D_P_START_TIME,D_P_END_TIME,N_PROD_TIME,N_SORT,C_CAST_NO,N_STATUS,C_EMP_ID,D_MOD_DT,C_REMARK,N_CREAT_PLAN,N_CREAT_ZG_PLAN,N_PRODUCE_TIME,C_ZL_ID,C_LF_ID,C_RH_ID,C_LGJH,C_CCM_ID, (SELECT TB.C_STA_CODE FROM TB_STA TB WHERE TB.C_ID = C_CCM_ID)AS C_CCM_CODE, (SELECT TB.C_STA_DESC FROM TB_STA TB WHERE TB.C_ID = C_CCM_ID)AS C_CCM_DESC, C_ZL_ID, (SELECT TB.C_STA_CODE FROM TB_STA TB WHERE TB.C_ID = C_ZL_ID) AS C_ZL_CODE, (SELECT TB.C_STA_DESC FROM TB_STA TB WHERE TB.C_ID = C_ZL_ID) AS C_ZL_DESC, C_LF_ID, (SELECT TB.C_STA_CODE FROM TB_STA TB WHERE TB.C_ID = C_LF_ID)AS C_LF_CODE, (SELECT TB.C_STA_DESC FROM TB_STA TB WHERE TB.C_ID = C_LF_ID)AS C_LF_DESC, C_RH_ID, (SELECT TB.C_STA_CODE FROM TB_STA TB WHERE TB.C_ID = C_RH_ID)AS C_RH_CODE, (SELECT TB.C_STA_DESC FROM TB_STA TB WHERE TB.C_ID = C_RH_ID)AS C_RH_DESC ");

            strSql.Append(" FROM TSP_PLAN_SMS t where T.N_STATUS = 1  ");

            strSql.Append(" and T.N_CREAT_PLAN = 1 ");

            strSql.Append(" and T.C_CCM_ID = '" + C_CCM_ID + "' ");

            strSql.Append(" and T.C_FK = '" + C_FK + "' ");

            strSql.Append(" ORDER BY T.N_SORT ");

            return TransactionHelper.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得未生成各个工序计划的连铸计划(修改路线时使用)
        /// </summary>
        /// <param name="C_CCM_ID">连铸ID</param>
        /// <returns></returns>
        public DataSet Get_Plan_List_Back_Trans(string C_CCM_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT C_ID,C_ORDER_NO,C_DESIGN_NO,N_SLAB_WGT,C_CTRL_NO,C_PROD_NAME,C_STL_GRD,C_SPEC_CODE,C_LENGTH,C_MATRL_NO,C_MATRL_NAME,C_SLAB_SIZE,C_SLAB_LENGTH,C_STATE,C_STD_CODE,C_INITIALIZE_ITEM_ID,D_P_START_TIME,D_P_END_TIME,N_PROD_TIME,N_SORT,C_CAST_NO,N_STATUS,C_EMP_ID,D_MOD_DT,C_REMARK,N_CREAT_PLAN,N_CREAT_ZG_PLAN,N_PRODUCE_TIME,C_ZL_ID,C_LF_ID,C_RH_ID,C_LGJH,C_CCM_ID, (SELECT TB.C_STA_CODE FROM TB_STA TB WHERE TB.C_ID = C_CCM_ID)AS C_CCM_CODE, (SELECT TB.C_STA_DESC FROM TB_STA TB WHERE TB.C_ID = C_CCM_ID)AS C_CCM_DESC, C_ZL_ID, (SELECT TB.C_STA_CODE FROM TB_STA TB WHERE TB.C_ID = C_ZL_ID) AS C_ZL_CODE, (SELECT TB.C_STA_DESC FROM TB_STA TB WHERE TB.C_ID = C_ZL_ID) AS C_ZL_DESC, C_LF_ID, (SELECT TB.C_STA_CODE FROM TB_STA TB WHERE TB.C_ID = C_LF_ID)AS C_LF_CODE, (SELECT TB.C_STA_DESC FROM TB_STA TB WHERE TB.C_ID = C_LF_ID)AS C_LF_DESC, C_RH_ID, (SELECT TB.C_STA_CODE FROM TB_STA TB WHERE TB.C_ID = C_RH_ID)AS C_RH_CODE, (SELECT TB.C_STA_DESC FROM TB_STA TB WHERE TB.C_ID = C_RH_ID)AS C_RH_DESC ");

            strSql.Append(" FROM TSP_PLAN_SMS t where T.N_STATUS = 1  ");

            strSql.Append(" and T.N_CREAT_PLAN = 2 ");

            strSql.Append(" and T.C_CCM_ID = '" + C_CCM_ID + "' ");

            strSql.Append(" ORDER BY T.N_SORT ");

            return TransactionHelper.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取需要下发的浇次信息
        /// </summary>
        /// <param name="C_CCM_ID">连铸ID</param>
        /// <param name="rowNum">浇次数量</param>
        /// <returns></returns>
        public DataSet Get_Cast_List_Trans(string C_CCM_ID, int rowNum)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT C_CTRL_NO  FROM(SELECT T.C_CTRL_NO FROM TSP_PLAN_SMS T WHERE T.N_STATUS = 1 AND T.C_CCM_ID = '" + C_CCM_ID + "' GROUP BY T.C_CTRL_NO ORDER BY T.C_CTRL_NO ASC) WHERE ROWNUM <= " + rowNum + " ");

            return TransactionHelper.Query(strSql.ToString());
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update_State_Trans(string C_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("UPDATE TSP_PLAN_SMS SET N_CREAT_PLAN = 2 WHERE C_ID = '" + C_ID + "' ");

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
        public bool Update_State_XF_Trans(string C_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("UPDATE TSP_PLAN_SMS SET N_CREAT_PLAN = 3 WHERE C_ID = '" + C_ID + "' ");

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
        /// 获得未计算计划时间的连铸计划
        /// </summary>
        public DataSet Get_CC_Plan_List_Trans(string V_CC_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT T.C_ID,T.C_STL_GRD,T.N_SORT,T.N_SLAB_WGT,T.C_STD_CODE,TB.N_MACH_WGT_CCM,t.C_ORDER_NO   ");

            strSql.Append(" from tsp_plan_sms t inner join tmo_order tb on t.c_order_no=tb.c_id where T.N_STATUS = 1  ");

            strSql.Append(" and t.N_CREAT_PLAN = 0 and t.C_CCM_ID = '" + V_CC_ID + "' ");

            strSql.Append(" ORDER BY T.N_SORT ");

            return TransactionHelper.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取上个计划结束时间
        /// </summary>
        public DataSet Get_Time_Trans(int n_sort, string V_CC_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select D_P_END_TIME, N_PRODUCE_TIME   ");

            strSql.Append(" FROM TSP_PLAN_SMS a WHERE a.N_STATUS = 1 ");

            strSql.Append(" AND a.N_SORT = " + (n_sort - 1) + " AND a.C_CCM_ID = '" + V_CC_ID + "' and rownum = 1 ");

            return TransactionHelper.Query(strSql.ToString());
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update_Time_Trans(string C_ID, DateTime TimeStart, DateTime TimeEnd, DateTime TimeZG)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("UPDATE TSP_PLAN_SMS SET D_P_START_TIME = to_date('" + TimeStart + "','yyyy-mm-dd hh24:mi:ss'),D_P_END_TIME =to_date('" + TimeEnd + "','yyyy-mm-dd hh24:mi:ss'),D_ARRIVE_ZG_TIME=to_date('" + TimeZG + "','yyyy-mm-dd hh24:mi:ss'),N_CREAT_PLAN=1  WHERE C_ID = '" + C_ID + "' ");

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
        /// 坯量更新炉次计划序号
        /// </summary>
        /// <param name="C_CCM_ID">连铸id</param>
        /// <param name="sort">起始序号</param>
        /// <returns></returns>
        public bool UpdateSort(string C_CCM_ID, int sort)
        {

            string strSql = @"UPDATE TSP_PLAN_SMS T
   SET T.N_SORT = T.N_SORT - 1
 WHERE T.N_SORT > " + sort;
            strSql = strSql + " AND T.C_CCM_ID = '" + C_CCM_ID + "'";
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
        /// 坯量更新炉次计划序号
        /// </summary>
        /// <param name="C_CCM_ID">连铸id</param>
        /// <param name="sort">起始序号</param>
        /// <returns></returns>
        public DataTable GetWPLC(string C_CCM_ID, string C_STL_GRD, string C_STD_CODE, int sort, string C_CAST_NO)
        {

            string strSql = @"SELECT T.*
                               FROM TSP_PLAN_SMS T";
            strSql = strSql + " WHERE T.C_CCM_ID = '" + C_CCM_ID + "'";
            strSql = strSql + "  AND T.N_CREAT_PLAN < 2";
            strSql = strSql + "  AND T.C_STATE = '1'";
            strSql = strSql + "  AND T.C_STL_GRD = '" + C_STL_GRD + "'";
            strSql = strSql + "  AND T.C_STD_CODE = '" + C_STD_CODE + "'";
            strSql = strSql + "  AND T.N_SORT > " + sort;
            if (C_CAST_NO.Trim() != "")
            {
                strSql = strSql + "   AND T.C_CAST_NO = '" + C_CAST_NO + "'";
            }
            strSql = strSql + "   ORDER BY T.N_SORT ";


            return DbHelperOra.Query(strSql).Tables[0];

        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update_sta_Trans(string C_ID, string new_ld_id, string new_lf_id, string new_rh_id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("UPDATE TSP_PLAN_SMS SET C_ZL_ID='" + new_ld_id + "',C_LF_ID='" + new_lf_id + "',C_RH_ID='" + new_rh_id + "', N_CREAT_PLAN=2  WHERE C_ID = '" + C_ID + "' ");

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
        public bool Update_Plan_Trans(string C_ID, string new_zl_id, string new_lf_id, string new_rh_id, string new_cc_id, string C_ORDER_ID, string C_STL_GRD, string C_MATRL_NO, string C_MATRL_NAME, string C_SLAB_SIZE, string C_SLAB_LENGTH, string C_STD_CODE, string C_FREE1, string C_FREE2)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("UPDATE TSP_PLAN_SMS SET C_LF_ID='" + new_lf_id + "',C_RH_ID='" + new_rh_id + "',C_CCM_ID='" + new_cc_id + "', C_ORDER_NO='" + C_ORDER_ID + "',C_STL_GRD='" + C_STL_GRD + "',C_MATRL_NO='" + C_MATRL_NO + "',C_MATRL_NAME='" + C_MATRL_NAME + "',C_SLAB_SIZE='" + C_SLAB_SIZE + "',C_SLAB_LENGTH='" + C_SLAB_LENGTH + "',C_STD_CODE='" + C_STD_CODE + "',C_FREE1='" + C_FREE1 + "',C_FREE2='" + C_FREE2 + "' WHERE C_ID = '" + C_ID + "' ");

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
        public bool Update_plan_Trans(string C_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("UPDATE TSP_PLAN_SMS SET N_CREAT_PLAN=1  WHERE C_ID = '" + C_ID + "' ");

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
        public bool Update_plan_YXF_Trans(string C_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("UPDATE TSP_PLAN_SMS SET N_CREAT_PLAN=2  WHERE C_ID = '" + C_ID + "' ");

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
        /// 获取当前连铸所有未排产的炉次加护
        /// </summary>
        /// <param name="C_CCM_ID">连铸主键</param>
        /// <returns></returns>
        public DataTable GetWPC(string C_CCM_ID)
        {
            string sql = @"SELECT *
  FROM TSP_PLAN_SMS T
 WHERE T.N_STATUS = 1 AND T.C_CCM_ID = '" + C_CCM_ID + "' AND T.N_CREAT_PLAN < 2 ORDER BY T.N_SORT DESC";

            return DbHelperOra.Query(sql).Tables[0];
        }

        /// <summary>
        ///查询开坯计划
        /// </summary>
        /// <param name="C_STL_GRD">钢种</param>
        /// <param name="C_STD_CODE">执行标准</param>
        /// <param name="status">Y/N</param>
        /// <returns>开坯计划</returns>
        public DataTable GetKP_Plan(string C_STL_GRD, string C_STD_CODE, int STATUS)
        {
            string sql = @"SELECT T.N_JC_SORT,
       COUNT(1) LS,
       MIN(T.N_SORT) N_SORT,
       SUM(T.N_SLAB_WGT) N_SLAB_WGT,
       T.C_STL_GRD,
       T.C_MATRL_NO,
(SELECT A.N_HSL FROM TB_MATRL_MAIN A WHERE A.C_ID=T.C_MATRL_NO) N_SLAB_PW,
       T.C_MATRL_NAME,
       T.C_SLAB_SIZE,
       T.C_SLAB_LENGTH,
       T.C_STD_CODE,
       MIN(T.D_P_START_TIME) D_P_START_TIME,
       MAX(T.D_P_END_TIME) D_P_END_TIME,
       T.N_STATUS,
       T.N_CREAT_ZG_PLAN,
       T.C_DFP_HL,
       T.C_HL,
       T.C_XM,
       MIN(T.D_KP_START_TIME) D_KP_START_TIME,
       MAX(T.D_KP_END_TIME) D_KP_END_TIME,
       T.N_SLAB_PW,
       T.C_MATRL_CODE_KP,
       T.C_MATRL_NAME_KP,
       T.C_KP_SIZE,
       T.N_KP_LENGTH,
       T.N_KP_PW,
       T.C_FREE1,
       T.C_FREE2
  FROM TSP_PLAN_SMS T
 WHERE T.N_STATUS = 1 AND  T.C_SLAB_SIZE = '280*325'
   AND T.N_CREAT_ZG_PLAN = " + STATUS;

            if (C_STL_GRD.Trim() != "")
            {
                sql = sql + " AND T.C_STL_GRD='" + C_STL_GRD + "'";
            }
            if (C_STD_CODE.Trim() != "")
            {
                sql = sql + " AND T.C_STD_CODE='" + C_STD_CODE + "'";
            }
            sql = sql + @" GROUP BY T.C_PROD_NAME,
          T.C_STL_GRD,
          T.C_MATRL_NO,
          T.C_MATRL_NAME,
          T.C_SLAB_SIZE,
          T.C_SLAB_LENGTH,
          T.C_STD_CODE,
          T.N_STATUS,
          T.N_CREAT_ZG_PLAN,
          T.C_DFP_HL,
          T.C_HL,
          T.C_XM,
          T.N_SLAB_PW,
          T.C_MATRL_CODE_KP,
          T.C_MATRL_NAME_KP,
          T.C_KP_SIZE,
          T.N_KP_LENGTH,
          T.N_KP_PW,
          T.C_FREE1,
          T.C_FREE2,
          T.N_JC_SORT
 ORDER BY T.N_JC_SORT, MIN(T.N_SORT)";
            return DbHelperOra.Query(sql).Tables[0];
        }

        /// <summary>
        ///查询开坯计划
        /// </summary>
        /// <param name="C_STL_GRD">钢种</param>
        /// <param name="C_STD_CODE">执行标准</param>
        /// <param name="status">Y/N</param>
        /// <param name="EXCESTATUS">0,全部，1可开坯，2待生产</param>
        /// <returns>开坯计划</returns>
        public DataTable GetKP_PlanBySms(string C_STL_GRD, string C_STD_CODE, int STATUS, int EXCESTATUS)
        {
            string sql = "select * from TSP_PLAN_SMS t";

            sql = sql + "   WHERE  T.N_STATUS = 1 AND  T.C_SLAB_SIZE = '280*325'  AND T.C_MATRL_CODE_KP IS NOT NULL   AND T.N_CREAT_ZG_PLAN = " + STATUS;
            if (EXCESTATUS == 1)
            {

                sql = sql + "  AND N_CREAT_PLAN = 4 ";
            }
            if (EXCESTATUS == 2)
            {
                sql = sql + "  AND N_CREAT_PLAN <> 4 ";
            }
            if (C_STL_GRD.Trim() != "")
            {
                sql = sql + " AND T.C_STL_GRD='" + C_STL_GRD + "'";
            }
            if (C_STD_CODE.Trim() != "")
            {
                sql = sql + " AND T.C_STD_CODE='" + C_STD_CODE + "'";
            }
            sql = sql + @" ORDER BY T.N_JC_SORT,D_KP_START_TIME ";
            return DbHelperOra.Query(sql).Tables[0];
        }


        /// <summary>
        /// 标记已下开坯计划的炉次计划
        /// </summary>
        /// <param name="C_STL_GRD">钢种</param>
        /// <param name="C_MATRL_NO">物料编码</param>
        /// <param name="C_STD_CODE">执行标准</param>
        /// <param name="C_MATRL_CODE_KP">开坯物料编码</param>
        /// <param name="N_JC_SORT">浇次序号</param>
        public int Down_KP(string C_STL_GRD, string C_MATRL_NO, string C_STD_CODE, string C_MATRL_CODE_KP, string N_JC_SORT)
        {
            string sql = "UPDATE TSP_PLAN_SMS T   SET T.N_CREAT_ZG_PLAN = 1 WHERE T.N_CREAT_ZG_PLAN = 0";
            sql = sql + " AND T.C_STL_GRD = '" + C_STL_GRD + "'";
            sql = sql + "  AND T.C_MATRL_NO = '" + C_MATRL_NO + "'";
            sql = sql + "  AND T.C_STD_CODE = '" + C_STD_CODE + "'";
            sql = sql + "  AND T.C_MATRL_CODE_KP = '" + C_MATRL_CODE_KP + "'";
            sql = sql + "  AND T.N_JC_SORT = '" + N_JC_SORT + "'";
            return DbHelperOra.ExecuteSql(sql);
        }

        /// <summary>
        ///查询开坯计划
        /// </summary>
        /// <param name="C_STL_GRD">钢种</param>
        /// <param name="C_STD_CODE">执行标准</param>
        /// <param name="status">Y/N</param>
        /// <returns>开坯计划</returns>
        public DataTable GetKPJH(string C_STL_GRD, string C_STD_CODE, int STATUS)
        {

            string strSql = @" SELECT *  FROM TSP_PLAN_SMS T WHERE T.N_STATUS = 1 AND  T.C_KP_SIZE IS NOT NULL AND  T.N_CREAT_ZG_PLAN= " + STATUS;

            if (C_STL_GRD.Trim() != "")
            {
                strSql = strSql + " AND T.C_STL_GRD='" + C_STL_GRD + "'";
            }
            if (C_STD_CODE.Trim() != "")
            {
                strSql = strSql + " AND T.C_STD_CODE='" + C_STD_CODE + "'";
            }
            strSql = strSql + "  ORDER BY T.N_JC_SORT,T.D_KP_START_TIME ";


            return DbHelperOra.Query(strSql).Tables[0];
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet Get_ZG_List_Trans()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_ORDER_NO,C_DESIGN_NO,N_SLAB_WGT,C_CTRL_NO,C_CCM_ID,C_CCM_DESC,C_PROD_NAME,C_STL_GRD,C_SPEC_CODE,C_LENGTH,C_MATRL_NO,C_MATRL_NAME,C_SLAB_SIZE,C_SLAB_LENGTH,C_STATE,C_STD_CODE,C_INITIALIZE_ITEM_ID,D_P_START_TIME,D_P_END_TIME,N_PROD_TIME,N_SORT,C_CAST_NO,N_STATUS,C_EMP_ID,D_MOD_DT,C_REMARK,N_CREAT_PLAN,N_CREAT_ZG_PLAN,N_PRODUCE_TIME,C_ZL_ID,C_LF_ID,C_RH_ID,C_LGJH,C_QUA,D_ARRIVE_ZG_TIME ");
            strSql.Append(" FROM TSP_PLAN_SMS t WHERE T.N_STATUS = 1 AND  T.N_CREAT_PLAN = '1' AND T.N_CREAT_ZG_PLAN = '0' order by t.d_arrive_zg_time");

            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        ///获取最大浇次号
        /// </summary>
        /// <param name="C_CCM_ID">连铸主键</param>
        public int GetMaxCastNo(string C_CCM_ID)
        {
            string strSql = "SELECT MAX(TO_NUMBER(T.C_CTRL_NO)) C_CTRL_NO FROM TSP_PLAN_SMS T WHERE T.N_STATUS = 1 AND  t.c_ccm_id = '" + C_CCM_ID + "'";
            DataTable DT = DbHelperOra.Query(strSql.ToString()).Tables[0];
            if (DT.Rows.Count > 0)
            {
                try
                {
                    return Convert.ToInt32(DT.Rows[0]["C_CTRL_NO"].ToString());
                }
                catch (Exception)
                {

                    return 10000000;
                }

            }
            else
            {
                return 10000000;
            }

        }

        /// <summary>
        /// 整浇次上移
        /// </summary>
        /// <param name="C_CAST_NO">浇次号</param>
        /// <param name="C_CTRL_NO">上个浇次的浇次序号</param>
        /// <param name="COUNT">上移炉数</param>
        public void JCSY(string C_CAST_NO, string C_CTRL_NO, int COUNT)
        {
            string sql = "UPDATE TSP_PLAN_SMS T   SET T.C_CTRL_NO = '" + C_CTRL_NO + "', T.N_SORT = T.N_SORT - " + COUNT + " WHERE T.C_CAST_NO = '" + C_CAST_NO + "'";
            DbHelperOra.ExecuteSql(sql.ToString());
        }

        /// <summary>
        /// 整浇次下移
        /// </summary>
        /// <param name="C_CAST_NO">浇次号</param>
        /// <param name="C_CTRL_NO">下个浇次的浇次序号</param>
        /// <param name="COUNT">下移炉数</param>
        public void JCXY(string C_CAST_NO, string C_CTRL_NO, int COUNT)
        {
            string sql = "UPDATE TSP_PLAN_SMS T   SET T.C_CTRL_NO = '" + C_CTRL_NO + "', T.N_SORT = T.N_SORT + " + COUNT + " WHERE T.C_CAST_NO = '" + C_CAST_NO + "'";
            DbHelperOra.ExecuteSql(sql.ToString());
        }

        /// <summary>
        /// 清除未下发浇次计划的计划时间
        /// </summary>
        /// <param name="C_CCM_ID">连铸</param>
        public void ClearTime(string C_CCM_ID)
        {
            string sql = "UPDATE TSP_PLAN_SMS T   SET t.N_CREAT_PLAN=0,t.d_p_start_time=NULL,t.d_p_end_time=NULL  WHERE T.C_CCM_ID = '890EAA2949E743AFB26C06B8D4209B17' AND  t.N_CREAT_PLAN=1";
            DbHelperOra.ExecuteSql(sql.ToString());

        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update_zg_plan_Trans(string C_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("UPDATE TSP_PLAN_SMS SET N_CREAT_ZG_PLAN=1  WHERE C_ID = '" + C_ID + "' ");

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
        /// 获取已排连铸计划的铁水计划
        /// </summary>
        /// <param name="dt1">查询开始日期</param>
        /// <param name="dt2">查询截止日期</param>
        /// <param name="C_ZL_ID">转炉主键</param>
        /// <param name="type">是否按产品统计Y/N</param>
        /// <returns></returns>
        public DataTable GetTSPlan(string dt1, string dt2, string C_ZL_ID, string type)
        {
            string sql = "";
            if (type == "Y")
            {
                sql = @"SELECT  TB.C_STA_DESC,
       SUM(T.N_SLAB_WGT) N_SLAB_WGT,
       SUM(NVL(TS.N_IRON_RATIO, T.N_SLAB_WGT)) N_IRON_RATIO,
       SUM(NVL(TS.N_SCRAP_RATIO, 0)) N_SCRAP_RATIO,
       T.C_STD_CODE,
       T.C_STL_GRD,
       TO_CHAR(T.D_P_START_TIME, 'yyyy-mm-dd') D_P_START_TIME
  FROM TSP_PLAN_SMS T
  LEFT JOIN TPB_WASTE_RATIO TS
    ON T.C_ZL_ID = TS.C_STA_ID
 LEFT JOIN TB_STA TB
    ON T.C_ZL_ID = TB.C_ID
 WHERE T.N_STATUS = 1 AND   T.D_P_START_TIME BETWEEN
 TO_DATE('" + dt1 + "', 'yyyy-mm-dd hh24:mi:ss') AND TO_DATE('" + dt2 + "', 'yyyy-mm-dd hh24:mi:ss')";
                if (C_ZL_ID.Trim() != "")
                {
                    sql = sql + " AND C_ZL_ID ='" + C_ZL_ID + "'";
                }
                sql = sql + "  GROUP BY TB.C_STA_DESC, TO_CHAR(T.D_P_START_TIME, 'yyyy-mm-dd'),  T.C_STD_CODE, T.C_STL_GRD ORDER BY TO_CHAR(T.D_P_START_TIME, 'yyyy-mm-dd') , T.C_STL_GRD";
            }
            else
            {
                sql = @"SELECT TB.C_STA_DESC,
       SUM(T.N_SLAB_WGT) N_SLAB_WGT,
       SUM(NVL(TS.N_IRON_RATIO, T.N_SLAB_WGT)) N_IRON_RATIO,
       SUM(NVL(TS.N_SCRAP_RATIO, 0)) N_SCRAP_RATIO,
       TO_CHAR(T.D_P_START_TIME, 'yyyy-mm-dd') D_P_START_TIME
  FROM TSP_PLAN_SMS T
  LEFT JOIN TPB_WASTE_RATIO TS
    ON T.C_ZL_ID = TS.C_STA_ID
 LEFT JOIN TB_STA TB
    ON T.C_ZL_ID = TB.C_ID
 WHERE T.N_STATUS = 1 AND  T.D_P_START_TIME BETWEEN
 TO_DATE('" + dt1 + "', 'yyyy-mm-dd hh24:mi:ss') AND TO_DATE('" + dt2 + "', 'yyyy-mm-dd hh24:mi:ss')";
                if (C_ZL_ID.Trim() != "")
                {
                    sql = sql + " AND C_ZL_ID = '" + C_ZL_ID + "'";
                }
                sql = sql + "  GROUP BY TB.C_STA_DESC, TO_CHAR(T.D_P_START_TIME, 'yyyy-mm-dd')  ORDER BY TO_CHAR(T.D_P_START_TIME, 'yyyy-mm-dd') , TB.C_STA_DESC ";
            }
            return DbHelperOra.Query(sql.ToString()).Tables[0];

        }

        /// <summary>
        /// 获取炼钢计划铁水成分要求
        /// </summary>
        /// <param name="dt1">查询开始日期</param>
        /// <param name="dt2">查询截止日期</param>
        /// <param name="C_ZL_ID">转炉主键</param>
        /// <returns></returns>
        public DataTable GetTSPlanCF(string dt1, string dt2, string C_ZL_ID)
        {
            string sql = @"SELECT T.C_NAME, MIN(T.N_TARGET_VALUE) N_TARGET_VALUE
        FROM TQB_TSBZ_CF T,
       TPB_STEEL_PRO_CONDITION A,
       (SELECT T.C_STD_CODE,
               T.C_STL_GRD,
               TO_CHAR(T.D_P_START_TIME, 'yyyy-mm-dd') D_P_START_TIME
          FROM TSP_PLAN_SMS T
          LEFT JOIN TPB_WASTE_RATIO TS
            ON T.C_ZL_ID = TS.C_STA_ID
         WHERE T.D_P_START_TIME BETWEEN
               TO_DATE('" + dt1 + "', 'yyyy-mm-dd hh24:mi:ss') AND  TO_DATE('" + dt2 + "', 'yyyy-mm-dd hh24:mi:ss')       ";
            if (C_ZL_ID.Trim().Length > 0)
            {
                sql = sql + "    AND C_ZL_ID = '" + C_ZL_ID + "' ";
            }
            sql = sql + @" GROUP BY  TO_CHAR(T.D_P_START_TIME, 'yyyy-mm-dd'),T.C_STD_CODE,                  T.C_STL_GRD) X
              WHERE   T.C_STL_GRD = A.C_STL_GRD
              AND T.C_STD_CODE = A.C_STD_CODE
              AND A.C_STL_GRD = X.C_STL_GRD
              AND A.C_STD_CODE = X.C_STD_CODE
              AND T.N_STATUS = 1
              GROUP BY C_NAME";
            return DbHelperOra.Query(sql.ToString()).Tables[0];
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
        /// 按炉获取可轧钢坯日历
        /// </summary>
        /// <param name="C_STL_GRD">钢种</param>
        /// <param name="C_STD_CODE">执行标准</param>
        /// <returns>钢坯日历数据</returns>
        public DataTable GetKZ_Slab_Calendar(string C_STL_GRD, string C_STD_CODE)
        {
            string sql = @"SELECT T.C_ID,
       T.C_STOVE_NO,
       T.C_STL_GRD,
       T.C_STD_CODE,
       T.C_QUA,
       NVL(T.N_SJ_WGT, T.N_SLAB_WGT) N_WGT,
       T.D_CAN_USE_TIME
  FROM TSP_PLAN_SMS T  WHERE T.N_STATUS = 1  ";
            if (C_STL_GRD.Trim() != "")
            {
                sql = sql + " AND T.C_STL_GRD LIKE '%" + C_STL_GRD + "%'";
            }
            if (C_STD_CODE.Trim() != "")
            {
                sql = sql + " AND T.C_STD_CODE LIKE '%" + C_STD_CODE + "%'";
            }
            sql = sql + " ORDER BY T.D_CAN_USE_TIME ";
            return DbHelperOra.Query(sql.ToString()).Tables[0];
        }

        /// <summary>
        /// 获取已下发调度，未下发MES的炉次计划数
        /// </summary>
        public int Get_Count(string c_fk)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TSP_PLAN_SMS t where T.N_STATUS = 1 AND  t.n_creat_plan=2 and t.c_fk='" + c_fk + "' ");

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
        /// 已下发MES的炉次计划数
        /// </summary>
        public int Get_Count_XF(string c_fk)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TSP_PLAN_SMS t where T.N_STATUS = 1 AND  t.n_creat_plan=3 and t.c_fk='" + c_fk + "' ");

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

        #region APS
        /// <summary>
        /// 返回上期排产的RH炉连续生产数量
        /// </summary>
        /// <returns>连续生产数量</returns>
        public int GetYPRH()
        {
            OracleParameter[] parameters = {
            new OracleParameter("P_MSG", OracleDbType.Varchar2,100)};
            parameters[0].Value = "0";
            return Convert.ToInt32(DbHelperOra.RunProcedureOut("PKG_LG_JCJH.P_RETURN_RHLS", parameters));
        }

        /// <summary>
        /// 获取钢坯列表
        /// </summary>
        public DataSet Get_Slab_List_Trans(string C_STL_GRD, string C_STD_CODE, string D_CAN_USE_TIME)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT T.N_USE_WGT,T.C_ID,T.C_ORDER_NO FROM TSP_PLAN_SMS T WHERE T.N_STATUS = 1 AND  T.N_USE_WGT>0 ");

            if (!string.IsNullOrEmpty(C_STL_GRD))
            {
                strSql.Append(" AND T.C_STL_GRD='" + C_STL_GRD + "' ");
            }

            if (!string.IsNullOrEmpty(C_STD_CODE))
            {
                strSql.Append(" AND T.C_STD_CODE='" + C_STD_CODE + "' ");
            }

            if (!string.IsNullOrEmpty(D_CAN_USE_TIME))
            {
                strSql.Append(" AND T.D_CAN_USE_TIME<to_date('" + D_CAN_USE_TIME + "','yyyy-mm-dd hh24:mi:ss')+30/(24*60) ");
            }

            return TransactionHelper.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取钢坯列表
        /// </summary>
        public DataSet Get_Slab_List_Trans(string C_STL_GRD, string C_STD_CODE)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select t.* from TSP_PLAN_SMS T WHERE T.N_STATUS = 1 AND  T.N_USE_WGT > 0 ");

            if (!string.IsNullOrEmpty(C_STL_GRD))
            {
                strSql.Append(" AND T.C_STL_GRD='" + C_STL_GRD + "' ");
            }

            if (!string.IsNullOrEmpty(C_STD_CODE))
            {
                strSql.Append(" AND T.C_STD_CODE='" + C_STD_CODE + "' ");
            }

            return TransactionHelper.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取钢坯列表
        /// </summary>
        public DataSet Get_Slab_List(string C_STL_GRD, string C_STD_CODE)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select t.* from TSP_PLAN_SMS T WHERE T.N_STATUS = 1 AND  T.N_USE_WGT > 0 ");

            if (!string.IsNullOrEmpty(C_STL_GRD))
            {
                strSql.Append(" AND T.C_STL_GRD='" + C_STL_GRD + "' ");
            }

            if (!string.IsNullOrEmpty(C_STD_CODE))
            {
                strSql.Append(" AND T.C_STD_CODE='" + C_STD_CODE + "' ");
            }

            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 更新可用量
        /// </summary>
        public bool Update_Trans(string C_ID, decimal N_USE_WGT)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TSP_PLAN_SMS set N_USE_WGT=N_USE_WGT-" + N_USE_WGT + " where C_ID='" + C_ID + "' ");

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
        /// 更新可用量
        /// </summary>
        public bool Update_Trans(string C_ID, decimal N_USE_WGT, string Order_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TSP_PLAN_SMS set N_USE_WGT=N_USE_WGT-" + N_USE_WGT + ",C_ORDER_NO='" + Order_ID + "' where C_ID='" + C_ID + "' ");

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
        /// 更新可用量
        /// </summary>
        public bool Update_New_Trans(string C_ID, decimal N_USE_WGT, string Order_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TSP_PLAN_SMS set N_USE_WGT=" + N_USE_WGT + ",C_ORDER_NO='" + Order_ID + "' where C_ID='" + C_ID + "' ");

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
        /// 获取钢坯可用时间
        /// </summary>
        /// <returns></returns>
        public DataSet Get_Time_Trans()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select T.D_CAN_USE_TIME from tsp_plan_sms t where T.N_STATUS = 1 AND  t.n_use_wgt > 0 AND NVL(T.C_REMARK,' ')<>'库存坯' order by T.D_CAN_USE_TIME asc ");

            return TransactionHelper.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取最大顺序号
        /// </summary>
        /// <returns></returns>
        public DataSet Get_Max_Sort_Trans()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select NVL(MAX(T.N_SORT),0) AS N_SORT,T.C_CCM_ID,MAX(T.D_P_END_TIME)AS D_P_END_TIME from TSP_PLAN_SMS t WHERE T.N_STATUS = 1 AND  T.C_CCM_ID IS NOT NULL GROUP BY T.C_CCM_ID ");

            return TransactionHelper.Query(strSql.ToString());
        }

        /// <summary>
        /// 批量删除数据
        /// </summary>
        public bool Delete_Trans(string C_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from TSP_PLAN_SMS ");
            strSql.Append(" where C_ID ='" + C_ID + "'  ");
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
        /// 更新可用量
        /// </summary>
        public bool Update_Trans()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("UPDATE TSP_PLAN_SMS T SET T.N_USE_WGT=round(T.N_SLAB_WGT),t.C_ORDER_NO='' where T.N_SLAB_WGT>0 ");

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
        /// 更新炼钢计划钢坯可使用量
        /// </summary>
        /// <returns></returns>
        public string TB_LG_PLAN_WGT()
        {
            OracleParameter[] parameters = {
            new OracleParameter("P_MSG", OracleDbType.Varchar2,100)};

            parameters[0].Value = "成功";

            return DbHelperOra.RunProcedureOut("pkg_p_plan.P_TB_LG_PLAN_WGT", parameters);
        }

        /// <summary>
        /// 初始化排产数据
        /// </summary>
        /// <returns></returns>
        public string PLAN_INITIALIZE()
        {
            OracleParameter[] parameters = {
            new OracleParameter("P_MSG", OracleDbType.Varchar2,100)};

            parameters[0].Value = "成功";

            return DbHelperOra.RunProcedureOut("pkg_p_plan.P_PLAN_INITIALIZE", parameters);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add_Trans(Mod_TSP_PLAN_SMS model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TSP_PLAN_SMS(");
            strSql.Append("C_ID,C_ORDER_NO,C_DESIGN_NO,N_SLAB_WGT,C_CTRL_NO,C_CCM_ID,C_CCM_DESC,C_PROD_NAME,C_STL_GRD,C_SPEC_CODE,C_LENGTH,C_MATRL_NO,C_MATRL_NAME,C_SLAB_SIZE,C_SLAB_LENGTH,C_STATE,C_STD_CODE,C_INITIALIZE_ITEM_ID,D_P_START_TIME,D_P_END_TIME,N_PROD_TIME,N_SORT,C_CAST_NO,N_STATUS,C_EMP_ID,D_MOD_DT,C_REMARK,N_CREAT_PLAN,N_CREAT_ZG_PLAN,N_PRODUCE_TIME,C_ZL_ID,C_LF_ID,C_RH_ID,C_LGJH,C_QUA,D_ARRIVE_ZG_TIME,C_BY1,C_BY2,C_BY3,C_RH,C_DFP_HL,C_HL,C_XM,D_DFPHL_START_TIME,D_DFPHL_END_TIME,D_KP_START_TIME,D_KP_END_TIME,D_HL_START_TIME,D_HL_END_TIME,D_PLAN_KY_TIME,C_PLAN_ROLL,D_ZZ_START_TIME,D_ZZ_END_TIME,D_XM_START_TIME,D_XM_END_TIME,C_STOVE_NO,D_DFPHL_START_TIME_SJ,D_DFPHL_END_TIME_SJ,D_KP_START_TIME_SJ,D_KP_END_TIME_SJ,D_HL_START_TIME_SJ,D_HL_END_TIME_SJ,D_XM_START_TIME_SJ,D_XM_END_TIME_SJ,N_SJ_WGT,D_START_TIME_SJ,D_END_TIME_SJ,N_DFP_HL_TIME,N_HL_TIME,C_ROUTE,N_SLAB_PW,C_MATRL_CODE_KP,C_MATRL_NAME_KP,C_KP_SIZE,N_KP_LENGTH,N_KP_PW,N_USE_WGT,D_USE_START_TIME_SJ,D_USE_END_TIME_SJ,D_CAN_USE_TIME,N_RH_NUM,N_KP_WGT,N_XM_WGT,C_DFP_RZ,C_RZP_RZ,C_DFP_YQ,C_RZP_YQ,C_STL_GRD_TYPE,C_PROD_KIND,C_TL,N_JSCN,C_FREE1,C_FREE2,N_GROUP,C_FK,N_ZJCLS,N_ZJCLS_MIN,N_ZJCLS_MAX,C_SL,C_WL,C_SLAB_TYPE,N_JC_SORT)");
            strSql.Append(" values (");
            strSql.Append(":C_ID,:C_ORDER_NO,:C_DESIGN_NO,:N_SLAB_WGT,:C_CTRL_NO,:C_CCM_ID,:C_CCM_DESC,:C_PROD_NAME,:C_STL_GRD,:C_SPEC_CODE,:C_LENGTH,:C_MATRL_NO,:C_MATRL_NAME,:C_SLAB_SIZE,:C_SLAB_LENGTH,:C_STATE,:C_STD_CODE,:C_INITIALIZE_ITEM_ID,:D_P_START_TIME,:D_P_END_TIME,:N_PROD_TIME,:N_SORT,:C_CAST_NO,:N_STATUS,:C_EMP_ID,:D_MOD_DT,:C_REMARK,:N_CREAT_PLAN,:N_CREAT_ZG_PLAN,:N_PRODUCE_TIME,:C_ZL_ID,:C_LF_ID,:C_RH_ID,:C_LGJH,:C_QUA,:D_ARRIVE_ZG_TIME,:C_BY1,:C_BY2,:C_BY3,:C_RH,:C_DFP_HL,:C_HL,:C_XM,:D_DFPHL_START_TIME,:D_DFPHL_END_TIME,:D_KP_START_TIME,:D_KP_END_TIME,:D_HL_START_TIME,:D_HL_END_TIME,:D_PLAN_KY_TIME,:C_PLAN_ROLL,:D_ZZ_START_TIME,:D_ZZ_END_TIME,:D_XM_START_TIME,:D_XM_END_TIME,:C_STOVE_NO,:D_DFPHL_START_TIME_SJ,:D_DFPHL_END_TIME_SJ,:D_KP_START_TIME_SJ,:D_KP_END_TIME_SJ,:D_HL_START_TIME_SJ,:D_HL_END_TIME_SJ,:D_XM_START_TIME_SJ,:D_XM_END_TIME_SJ,:N_SJ_WGT,:D_START_TIME_SJ,:D_END_TIME_SJ,:N_DFP_HL_TIME,:N_HL_TIME,:C_ROUTE,:N_SLAB_PW,:C_MATRL_CODE_KP,:C_MATRL_NAME_KP,:C_KP_SIZE,:N_KP_LENGTH,:N_KP_PW,:N_USE_WGT,:D_USE_START_TIME_SJ,:D_USE_END_TIME_SJ,:D_CAN_USE_TIME,:N_RH_NUM,:N_KP_WGT,:N_XM_WGT,:C_DFP_RZ,:C_RZP_RZ,:C_DFP_YQ,:C_RZP_YQ,:C_STL_GRD_TYPE,:C_PROD_KIND,:C_TL,:N_JSCN,:C_FREE1,:C_FREE2,:N_GROUP,:C_FK,:N_ZJCLS,:N_ZJCLS_MIN,:N_ZJCLS_MAX,:C_SL,:C_WL,:C_SLAB_TYPE,:N_JC_SORT)");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100),
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
                    new OracleParameter(":C_FREE1", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_FREE2", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_GROUP", OracleDbType.Decimal,5),
                    new OracleParameter(":C_FK", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_ZJCLS", OracleDbType.Decimal,4),
                    new OracleParameter(":N_ZJCLS_MIN", OracleDbType.Decimal,4),
                    new OracleParameter(":N_ZJCLS_MAX", OracleDbType.Decimal,4),
                    new OracleParameter(":C_SL", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_WL", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SLAB_TYPE", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_JC_SORT", OracleDbType.Decimal,20)
            };
            parameters[0].Value = model.C_ID;
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
            parameters[91].Value = model.C_FREE1;
            parameters[92].Value = model.C_FREE2;
            parameters[93].Value = model.N_GROUP;
            parameters[94].Value = model.C_FK;
            parameters[95].Value = model.N_ZJCLS;
            parameters[96].Value = model.N_ZJCLS_MIN;
            parameters[97].Value = model.N_ZJCLS_MAX;
            parameters[98].Value = model.C_SL;
            parameters[99].Value = model.C_WL;
            parameters[100].Value = model.C_SLAB_TYPE;
            parameters[101].Value = model.N_JC_SORT;

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

        #endregion

        #region MyRegion
        /// <summary>
        /// 该混浇组号
        /// </summary>
        /// <param name="c_stl_grd">钢种</param>
        /// <param name="c_std_code">执行标准</param>
        /// <param name="n_group">组号</param>
        /// <returns>是否成功</returns>
        public bool ChangeGroup(string c_stl_grd, string c_std_code, int n_group)
        {
            string sql = "UPDATE TPC_PLAN_SMS A   SET A.N_GROUP = " + n_group + " WHERE A.N_STATUS = 0   AND A.C_STL_GRD = '" + c_stl_grd + "'   AND A.C_STD_CODE = '" + c_std_code + "'";

            int rows = TransactionHelper.ExecuteSql(sql.ToString());
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public int GetMaxSort(int jc_sort, string c_ccmid)
        {

            string sql = "SELECT MAX(T.N_SORT) N_SORT FROM TSP_PLAN_SMS T WHERE T.N_STATUS = 1 AND  T.N_JC_SORT<" + jc_sort + " AND T.C_CCM_ID='" + c_ccmid + "'";

            object obj = DbHelperOra.GetSingle(sql.ToString());
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
        /// 获取当前连铸炉次计划最大序号
        /// </summary>
        /// <param name="C_CCM_ID">连铸</param>
        /// <returns>最大序号</returns>
        public int GetMaxSort(string C_CCM_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select MAX(N_SORT) N_SORT  from TSP_PLAN_SMS");
            strSql.Append(" where N_STATUS = 1 AND C_CCM_ID=:C_CCM_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_CCM_ID", OracleDbType.Varchar2,100)         };
            parameters[0].Value = C_CCM_ID;

            DataTable dt = DbHelperOra.Query(strSql.ToString(), parameters).Tables[0];
            if (dt.Rows.Count > 0)
            {
                if (dt.Rows[0]["N_SORT"].ToString().Trim() == "")
                {
                    return 0;

                }
                else
                {
                 
                    return Convert.ToInt32(dt.Rows[0]["N_SORT"].ToString().Trim());
                }
            }
            else
            {
                return 0;
            }
        }


        /// <summary>
        /// 获取当前浇次计划的最小序号
        /// </summary>
        /// <param name="c_jc_id">浇次主键</param>
        /// <returns>最小序号</returns>
        public int GetMinSort(string c_jc_id)
        {

            string sql = "SELECT MIN(T.N_SORT) N_SORT FROM TSP_PLAN_SMS T WHERE T.N_STATUS = 1 AND  T.C_FK='" + c_jc_id + "'";
            object obj = DbHelperOra.GetSingle(sql.ToString());
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
  FROM TSP_PLAN_SMS T
 WHERE T.N_STATUS = 1 AND  T.C_ORDER_NO IS NOT NULL
   AND T.N_CREAT_PLAN < 4
   AND T.C_FK IS NOT NULL
   AND T.C_STL_GRD = '" + C_STL_GRD + "'   AND T.C_STD_CODE = '" + C_STD_CODE + "'  ";
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
        #endregion

        /// <summary>
        /// 查询需要修改计划的炉号
        /// </summary>
        /// <param name="str_Stove">炉号</param>
        /// <returns></returns>
        public DataTable Get_Plan_ByStove(string str_Stove)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" SELECT TB.C_ID, T.C_ORDER_NO AS 订单主键,T.C_MATRL_NO,T.C_MATRL_NAME,T.C_CCM_ID, T.C_CCM_DESC, T.C_STL_GRD AS 钢种, T.C_STD_CODE AS 执行标准,T.C_SLAB_SIZE as 断面,T.C_SLAB_LENGTH AS 定尺, TB.C_LD_DESC AS 转炉, TB.C_LF_DESC AS 精炼, TB.C_RH_DESC AS 真空, TB.C_CC_DESC AS 连铸,TB.C_HEAT_ID AS 炉号,T.C_ZL_ID,T.C_LF_ID,T.C_RH_ID,TB.C_PLAN_ID,TC.C_PK_INVBASDOC ");

            strSql.Append(" FROM TSP_PLAN_SMS T INNER JOIN TPP_CAST_PLAN TB ON T.C_ID = TB.C_PLAN_ID  INNER JOIN TB_MATRL_MAIN TC ON TC.C_MAT_CODE=T.C_MATRL_NO ");

            strSql.Append(" WHERE T.N_STATUS = 1 AND  TB.C_HEAT_ID='" + str_Stove + "' ");

            return DbHelperOra.Query(strSql.ToString()).Tables[0];
        }



        /// <summary>
        /// 同步炼钢记号
        /// </summary>
        /// <returns></returns>
        public int P_TB_LGJH()
        {
            OracleParameter[] parameters = {
            new OracleParameter("P_MSG", OracleDbType.Varchar2,100)};
            parameters[0].Value = "0";
            return DbHelperOra.RunProcedure("PKG_S_TB_LGJH.P_Q_TB_LGJH", parameters);
        }

        /// <summary>
        /// 获取已下发的计划
        /// </summary>
        /// <param name="C_PLAN_ID">计划主键</param>
        /// <returns></returns>
        public DataTable GetDownPlan(string C_PLAN_ID)
        {
            string sql = @"SELECT T.C_PRE_STEELGRADE,
       T.C_HEAT_ID,
       T.C_PLAN_ID,
       T.D_AIM_CASTINGSTART_TIME,
       T.D_AIM_CASTINGEND_TIME,
       TA.N_CREAT_PLAN,
       TA.C_STD_CODE,
       TA.N_SORT,
       TA.C_FK
  FROM TPP_CAST_PLAN T
  LEFT JOIN TSP_PLAN_SMS TA
    ON T.C_PLAN_ID = TA.C_ID
 WHERE T.C_PLAN_ID = '" + C_PLAN_ID + "'";
            return DbHelperOra.Query(sql).Tables[0];

        }

        /// <summary>
        /// 获取炉次计划
        /// </summary>
        /// <param name="C_CCM_ID">连铸主键</param>
        /// <param name="N_CREAT_PLAN">炉次计划状态</param>
        /// <returns>炉次计划列表</returns>
        public DataTable GetLCPlan(string C_CCM_ID, int N_CREAT_PLAN)
        {
            string sql = "  SELECT  T.*  FROM TSP_PLAN_SMS T WHERE T.N_STATUS = 1 AND  T.N_CREAT_PLAN = " + N_CREAT_PLAN + "   AND T.C_CCM_ID = '" + C_CCM_ID + "' ORDER BY T.N_SORT DESC";
            return DbHelperOra.Query(sql).Tables[0];
        }


        /// <summary>
        /// 获取未完成的炉次计划
        /// </summary>
        /// <param name="C_CCM_ID">连铸主键</param>
        /// <returns>炉次计划列表</returns>
        public DataTable GetLCPlan(string C_CCM_ID)
        {
            string sql = "  SELECT  T.*  FROM TSP_PLAN_SMS T WHERE T.N_STATUS = 1 AND  T.N_CREAT_PLAN <4   AND T.C_CCM_ID = '" + C_CCM_ID + "' ORDER BY T.N_SORT ";
            return DbHelperOra.Query(sql).Tables[0];
        }


        /// <summary>
        /// 获取炼钢计划完成量信息
        /// </summary>
        /// <param name="strTime1">时间1</param>
        /// <param name="strTime2">时间2</param>
        /// <returns></returns>
        public DataSet Get_Lgfx(string strTime1, string strTime2)
        {
            string sql = @" SELECT *
                            FROM (SELECT TP.C_STA_DESC as 工位,
                            NVL(TP.COU_PLAN, 0) AS 计划炉数,
                            NVL(TP.WGT_PLAN, 0) AS 计划量,
                            NVL(TPA.COU_PLAN_ACT, 0) AS 计划完成炉数,
                            NVL(TPA.WGT_PLAN_ACT, 0) AS 计划完成量,
                            NVL(TA.COU_ACT, 0) AS 实际完成炉数,
                            NVL(TA.WGT_ACT, 0) AS 实际完成量,
                            (CASE NVL(TP.COU_PLAN, 0) WHEN 0 THEN 0 ELSE ROUND(NVL(TPA.COU_PLAN_ACT, 0) / NVL(TP.COU_PLAN, 0) * 100, 2) END) AS 计划炉数完成率,
               (CASE NVL(TP.WGT_PLAN, 0) WHEN 0 THEN 0 ELSE ROUND(NVL(TPA.WGT_PLAN_ACT, 0) / NVL(TP.WGT_PLAN, 0) * 100, 2) END) AS 计划量完成率,
               (CASE NVL(TP.COU_PLAN, 0) WHEN 0 THEN 0 ELSE ROUND(NVL(TA.COU_ACT, 0) / NVL(TP.COU_PLAN, 0) * 100, 2) END) AS 实际炉数完成率,
               (CASE NVL(TP.WGT_PLAN, 0) WHEN 0 THEN 0 ELSE ROUND(NVL(TA.WGT_ACT, 0) / NVL(TP.WGT_PLAN, 0) * 100, 2) END) AS 实际量完成率
                            FROM (select tb.c_sta_desc,
                            count(1) as COU_PLAN,
                            round(sum(tc.n_slab_wgt)) AS WGT_PLAN
                            from tsp_plan_sms tc
                            inner join tb_sta tb
                            on tc.c_ccm_id = tb.c_id
                            where tc.n_status = 1 ";

            sql += " and tc.d_p_start_time between to_date('" + strTime1 + "', 'yyyy-mm-dd hh24:mi:ss') and to_date('" + strTime2 + "', 'yyyy-mm-dd hh24:mi:ss')";

            sql += @" group by tb.c_sta_desc
                      order by tb.c_sta_desc) TP
                      LEFT JOIN(select tb.c_sta_desc,
                      count(1) AS COU_PLAN_ACT,
                      round(sum(tc.n_slab_wgt)) AS WGT_PLAN_ACT
                      from tsp_plan_sms tc
                      inner join tb_sta tb
                      on tc.c_ccm_id = tb.c_id
                      inner join tsc_stove_time td
                      on td.heatid = tc.c_stove_no
                      where tc.n_status = 1 ";

            sql += " and tc.d_p_start_time between to_date('" + strTime1 + "', 'yyyy-mm-dd hh24:mi:ss') and to_date('" + strTime2 + "', 'yyyy-mm-dd hh24:mi:ss') AND td.act_time_castingstart between to_date('" + strTime1 + "', 'yyyy-mm-dd hh24:mi:ss') and to_date('" + strTime2 + "', 'yyyy-mm-dd hh24:mi:ss') ";

            sql += @" group by tb.c_sta_desc
                      order by tb.c_sta_desc) TPA
                      ON TP.c_sta_desc = TPA.c_sta_desc
                      LEFT JOIN(select tb.c_sta_desc,
                      count(1) AS COU_ACT,
                      round(sum(tc.n_slab_wgt)) AS WGT_ACT
                      from tsp_plan_sms tc
                      inner join tb_sta tb 
                      on tc.c_ccm_id = tb.c_id 
                      inner join tsc_stove_time td 
                      on td.heatid = tc.c_stove_no
                      where tc.n_status = 1 ";

            sql += " AND td.act_time_castingstart between to_date('" + strTime1 + "', 'yyyy-mm-dd hh24:mi:ss') and to_date('" + strTime2 + "', 'yyyy-mm-dd hh24:mi:ss') ";

            sql += @" group by tb.c_sta_desc
                      order by tb.c_sta_desc) TA
                      ON TP.c_sta_desc = TA.c_sta_desc)
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
                      WHERE t.c_slab_type = 2 ";

            sql += " and T.D_QR_DATE >= TO_DATE('" + strTime1 + "', 'yyyy-mm-dd hh24:mi:ss') AND T.D_QR_DATE <= TO_DATE('" + strTime2 + "', 'yyyy-mm-dd hh24:mi:ss')) ";

            return DbHelperOra.Query(sql);
        }

        /// <summary>
        /// 开坯计划排产初始化
        /// </summary> 
        /// <returns></returns>
        public string P_INI_SMS()
        {
            OracleParameter[] parameters = {
            new OracleParameter("P_MSG", OracleDbType.Varchar2,100)};

            parameters[0].Value = "0";

            return DbHelperOra.RunProcedureOut("PKG_INI_PLAN_SMS.P_INI_SMS", parameters);
        }

        /// <summary>
        /// 炼钢计划排产初始化
        /// </summary> 
        /// <returns></returns>
        public string P_INI_LGPC()
        {
            OracleParameter[] parameters = {
            new OracleParameter("P_MSG", OracleDbType.Varchar2,100)};

            parameters[0].Value = "0";

            return DbHelperOra.RunProcedureOut("PKG_INI_PLAN_SMS.P_INI_LGPC", parameters);
        }

        /// <summary>
        /// 开坯计划排序
        /// </summary> 
        /// <returns></returns>
        public string P_KP_PLAN_SORTING()
        {
            OracleParameter[] parameters = {
            new OracleParameter("P_MSG", OracleDbType.Varchar2,100)};

            parameters[0].Value = "0";

            return DbHelperOra.RunProcedureOut("PKG_INI_PLAN_SMS.P_KP_PLAN_SORTING", parameters);
        }
        /// <summary>
        /// 批量更新浇次计划开始结束时间
        /// </summary>
        /// <param name="C_CCM_ID"></param>
        public int UpdateCCMTime(string C_CCM_ID)
        {

            string sql = @"UPDATE TSP_CAST_PLAN T
   SET(T.D_P_START_TIME, T.D_P_END_TIME) =
       (SELECT MIN(A.D_P_START_TIME), MAX(A.D_P_END_TIME)
          FROM TSP_PLAN_SMS A
         WHERE A.C_FK = T.C_ID
           AND A.N_STATUS = 1)
 WHERE T.N_STATUS IN(1, 2)
   AND T.C_CCM_ID = '" + C_CCM_ID + "'";

            return DbHelperOra.ExecuteSql(sql);

        }
        /// <summary>
        /// 
        /// </summary> 
        /// <returns></returns>
        public string P_SLAB_CAN_USETIMEG()
        {
            OracleParameter[] parameters = {
            new OracleParameter("P_MSG", OracleDbType.Varchar2,100)};

            parameters[0].Value = "0";

            return DbHelperOra.RunProcedureOut("PKG_INI_PLAN_SMS.P_SLAB_CAN_USETIMEG", parameters);
        }



        #region KPJHCX
        /// <summary>
        /// 查询开坯计划
        /// </summary>
        /// <param name="sta">工位</param>
        /// <param name="stove">炉号</param>
        /// <param name="grd">钢种</param>
        /// <param name="st">连铸开始时间</param>
        /// <param name="et">连铸结束时间</param>
        /// <returns></returns>
        public DataSet GetQuery(string sta, string stove, string grd, DateTime st, DateTime et)
        {
            string sql = "SELECT T.*,decode(D_DFPHL_END_TIME, '', D_P_END_TIME, D_DFPHL_END_TIME) D_DATE FROM TSP_PLAN_SMS T WHERE NVL(T.N_SJ_WGT, 0) > 0 AND NVL(T.N_KP_WGT, 0) > 0 AND SUBSTR(T.C_MATRL_NO, 0, 3) IN('611', '612', '613', '614') AND T.N_STATUS = 1 AND T.C_KP = 'Y' ";
            if (sta != "")
            {
                sql += " AND T.C_KP_ID='" + sta + "'";
            }
            if (stove != "")
            {
                sql += " AND T.C_STOVE_NO='" + stove + "'";
            }
            if (grd != "")
            {
                sql += " AND T.C_STL_GRD='" + grd + "'";
            }
            sql += " AND T.D_P_START_TIME>to_date('" + st.ToShortDateString() + "','yyyy-mm-dd')";
            sql += " AND T.D_P_START_TIME<to_date('" + et.ToShortDateString() + "','yyyy-mm-dd')";
            sql += " ORDER BY T.N_KP_SORT";
            return DbHelperOra.Query(sql);
        }
        /// <summary>
        /// 查询开坯计划
        /// </summary>
        /// <param name="sta">开坯机</param>
        /// <param name="lzendtime">连铸结束时间</param>
        /// <param name="ddstatus">订单状态区分是否有订单</param>
        /// <param name="rzpstatus">热轧坯状态区分是否为热轧坯</param>
        /// <param name="jrstatus">加热状态区分6小时和4小时</param>
        /// <returns></returns>
        public DataSet GetQuery(string sta, DateTime lzendtime, int ddstatus, int rzpstatus, int jrstatus)
        {
            string sql = "SELECT T.*,decode(D_DFPHL_END_TIME, '', D_P_END_TIME, D_DFPHL_END_TIME) D_DATE FROM TSP_PLAN_SMS T WHERE NVL(T.N_SJ_WGT, 0) > 0 AND NVL(T.N_KP_WGT, 0) > 0 AND SUBSTR(T.C_MATRL_NO, 0, 3) IN('611', '612', '613', '614') AND T.N_STATUS = 1 AND T.C_KP = 'Y' AND NVL(T.N_SFKPPC,0)=0 AND t.d_p_Start_Time IS NOT NULL ";
            if (sta != "")
            {
                sql += " AND T.C_KP_ID='" + sta + "'";
            }
            if (jrstatus == 6)
            {
                sql += " AND T.N_KP_JRL_HOUR=6";
            }
            else if (jrstatus == 4)
            {
                sql += " AND T.N_KP_JRL_HOUR=4";
            }
            if (ddstatus == 1)
            {
                sql += " AND T.N_ORDER_WGT>0";
            }
            else if(ddstatus==0)
            {
                sql += " AND T.N_ORDER_WGT=0";
            }
            if (rzpstatus > 0)
            {
                sql += " AND T.D_P_END_TIME>to_date('" + lzendtime.AddHours(2) + "','yyyy-MM-dd HH24:mi:ss') AND T.D_P_END_TIME<to_date('" + lzendtime.AddHours(10) + "','yyyy-MM-dd HH24:mi:ss')";
            }
            sql += " ORDER BY T.D_P_END_TIME";
            return DbHelperOra.Query(sql);
        }
        /// <summary>
        /// 查询开坯计划
        /// </summary>
        /// <param name="sta">工位</param>
        /// <returns></returns>
        public DataSet GetKPSTA()
        {
            string sql = "SELECT distinct C_KP_ID FROM TSP_PLAN_SMS where C_KP_ID is not null";
            return DbHelperOra.Query(sql);
        }
        /// <summary>
        /// 查询开坯计划
        /// </summary>
        /// <param name="sta">工位</param>
        /// <returns></returns>
        public DataSet GetListByKP(string sta)
        {
            string sql = "SELECT T.*,decode(D_DFPHL_END_TIME, '', D_P_END_TIME, D_DFPHL_END_TIME) D_DATE FROM TSP_PLAN_SMS T WHERE NVL(T.N_SJ_WGT, 0) > 0 AND NVL(T.N_KP_WGT, 0) > 0 AND SUBSTR(T.C_MATRL_NO, 0, 3) IN('611', '612', '613', '614') AND T.N_STATUS = 1 ";
            if (sta != "")
            {
                sql += " AND t.C_KP_ID='" + sta + "'";
            }
            sql += " ORDER BY D_DATE,t.N_KP_SORT";
            return DbHelperOra.Query(sql);
        }
        /// <summary>
        /// 获取指定开坯机最新的计划完成情况
        /// </summary>
        /// <param name="C_KP_ID">开坯机主键</param>
        /// <returns></returns>
        public DataTable GetNewKPPlan(string C_KP_ID)
        {
            string sql = "SELECT M.C_STL_GRD, M.N_KP_JRL_HOUR, M.D_KP_END_TIME_SJ FROM(SELECT T.C_ID, T.D_KP_START_TIME_SJ, T.D_KP_END_TIME_SJ, T.N_KP_JRL_HOUR, T.C_STL_GRD, T.C_STD_CODE, T.D_P_START_TIME, T.D_P_END_TIME, T.N_ORDER_WGT, T.N_SORT FROM TSP_PLAN_SMS T WHERE T.D_KP_END_TIME_SJ IS NOT NULL AND T.C_KP = 'Y' AND T.N_STATUS = 1 AND T.C_KP_ID = '" + C_KP_ID + "' ORDER BY T.D_KP_END_TIME_SJ DESC) M WHERE ROWNUM = 1";
            return DbHelperOra.Query(sql).Tables[0];

        }
        /// <summary>
        /// 获取指定开坯机最新的计划完成情况
        /// </summary>
        /// <param name="C_KP_ID">开坯机</param>
        /// <param name="sort">顺序</param>
        /// <returns></returns>
        public DataTable GetLastsort(string C_KP_ID,int sort)
        {
            string sql = "SELECT T.C_ID, T.D_KP_START_TIME_SJ, T.D_KP_END_TIME_SJ, T.N_KP_JRL_HOUR, T.C_STL_GRD, T.C_STD_CODE, T.D_P_START_TIME, T.D_P_END_TIME, T.N_ORDER_WGT, T.N_SORT FROM TSP_PLAN_SMS T WHERE T.C_KP = 'Y' AND T.N_STATUS = 1 AND T.C_KP_ID = '" + C_KP_ID + "' AND T.N_KP_SORT='"+ sort + "'";
            return DbHelperOra.Query(sql).Tables[0];

        }
        /// <summary>
        /// 清空开坯计划排产状态
        /// </summary>
        /// <returns></returns>
        public int UPsortstatus()
        {
            string sql = "update TSP_PLAN_SMS set N_SFKPPC=0 ";
            return DbHelperOra.ExecuteSql(sql);
        }
        #endregion
        #region XMJHCX
        /// <summary>
        /// 查询修磨计划
        /// </summary>
        /// <param name="sta">工位</param>
        /// <param name="stove">炉号</param>
        /// <param name="grd">钢种</param>
        /// <param name="st">连铸开始时间</param>
        /// <param name="et">连铸结束时间</param>
        /// <returns></returns>
        public DataSet GetXMQuery(string sta, string stove, string grd, DateTime st, DateTime et, string type)
        {
            string sql = "select t.* from TSP_PLAN_SMS t  WHERE T.N_STATUS = 1 AND t.C_XM = 'Y' AND NVL(T.N_XM_WGT, 0) > 0  AND SUBSTR(T.C_MATRL_NO, 0, 3) IN ('611', '612', '613', '614')  AND C_Slab_Type='" + type + "'";
            if (sta != "")
            {
                sql += " AND C_XM_ID='" + sta + "'";
            }
            if (stove != "")
            {
                sql += " AND C_STOVE_NO='" + stove + "'";
            }
            if (grd != "")
            {
                sql += " AND C_STL_GRD='" + grd + "'";
            }
            sql += " AND D_P_START_TIME>to_date('" + st.ToShortDateString() + "','yyyy-mm-dd')";
            sql += " AND D_P_START_TIME<to_date('" + et.ToShortDateString() + "','yyyy-mm-dd')";
            sql += " ORDER BY N_XM_SORT";
            return DbHelperOra.Query(sql);
        }
        /// <summary>
        /// 查询修磨计划
        /// </summary>
        /// <param name="sta">工位</param>
        /// <returns></returns>
        public DataSet GetXMSTA()
        {
            string sql = "SELECT distinct C_XM_ID FROM TSP_PLAN_SMS where C_XM_ID is not null";
            return DbHelperOra.Query(sql);
        }
        /// <summary>
        /// 查询开坯计划
        /// </summary>
        /// <param name="sta">工位</param>
        /// <returns></returns>
        public DataSet GetListByXM(string sta, string type)
        {
            string sql = "select t.*,decode(D_HL_END_TIME,'', decode(D_KP_END_TIME, '', D_P_END_TIME, D_KP_END_TIME), D_HL_END_TIME) D_DATE from TSP_PLAN_SMS t  WHERE T.N_STATUS = 1 AND t.C_XM = 'Y' AND NVL(T.N_XM_WGT, 0) > 0  AND SUBSTR(T.C_MATRL_NO, 0, 3) IN ('611', '612', '613', '614') AND C_Slab_Type='" + type + "'";
            if (sta != "")
            {
                sql += " AND C_XM_ID='" + sta + "'";
            }
            sql += " ORDER BY D_DATE,N_XM_SORT";
            return DbHelperOra.Query(sql);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="c_ccm_id"></param>
        /// <returns></returns>
        public DataTable GetStartTime(string c_ccm_id)
        {
            string sql = "SELECT MAX(T.D_P_END_TIME + T.N_PRODUCE_TIME * 60 / 1440) D_P_END_TIME FROM tsp_plan_sms t WHERE t.c_ccm_id='" + c_ccm_id + "' AND t.n_creat_plan>1 AND T.D_P_END_TIME IS NOT NULL AND t.n_status=1 ";
            return DbHelperOra.Query(sql).Tables[0];
        }
        /// <summary>
        /// 获取不锈钢修磨机时产能
        /// </summary>
        /// <param name="C_STL_GRD">钢种</param>
        /// <param name="C_SLAB_SIE">断面</param>
        /// <param name="N_LTH">定尺</param>
        /// <param name="C_GZLX">修磨标准</param>
        /// <returns></returns>
        public string GetBXGXMJSCN(string C_STL_GRD, string C_SLAB_SIE, int N_LTH, string C_GZLX)
        {
            string sql = "SELECT T.N_JSCN  FROM TPB_BXGXMGZ T WHERE T.C_STL_GRD = '" + C_STL_GRD + "'   AND T.C_SLAB_SIZE = '" + C_SLAB_SIE + "'   AND T.N_LTH = " + N_LTH + " AND t.C_GZLX='" + C_GZLX + "' ORDER BY T.D_MOD_DT DESC";
            var obj = DbHelperOra.GetSingle(sql);
            if (obj == null)
            {
                return "";
            }
            else
            {
                return obj.ToString();
            }
        }
        #endregion

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
  FROM TSP_PLAN_SMS T
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

        /// <summary>
        /// 批量更新浇次计划序号
        /// </summary>
        /// <returns></returns>
        public int UpdateJcSort()
        {
            string sql = "UPDATE tsp_plan_sms t SET t.n_jc_sort = (SELECT a.n_sort FROM tsp_cast_plan a WHERE t.c_fk = a.c_id) WHERE t.n_jc_sort IS NULL AND t.c_remark NOT IN('改判坯', '库存坯')";
            return DbHelperOra.ExecuteSql(sql);
        }
        /// <summary>
        /// 更新炉次计划的机时产能
        /// </summary>
        /// <returns></returns>
        public int UpdateLCJSCN()
        {
            string sql = "UPDATE tsp_plan_sms t SET t.n_jscn=NVL((SELECT a.n_capacity FROM TPB_SLAB_CAPACITY a   WHERE  a.N_STATUS=1 AND a.c_sta_id=t.c_ccm_id AND a.c_stl_grd=t.c_stl_grd AND a.c_std_code=t.c_std_code),DECODE(t.c_ccm_id,'77B9FDA79B884D07AA2B3601D1DA11A2',114,88)) WHERE t.n_status=1 AND t.d_mod_dt>Sysdate-20";
            return DbHelperOra.ExecuteSql(sql);

        }

    }
}

