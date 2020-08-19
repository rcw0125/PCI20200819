using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;
using System.Collections.Generic;

namespace DAL
{
    /// <summary>
    /// 数据访问类:TSC_SLAB_MAIN
    /// </summary>
    public partial class Dal_TSC_SLAB_MAIN
    {
        public Dal_TSC_SLAB_MAIN()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string C_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TSC_SLAB_MAIN");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)          };
            parameters[0].Value = C_ID;

            return DbHelperOra.Exists(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Mod_TSC_SLAB_MAIN model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TSC_SLAB_MAIN(");
            strSql.Append("C_ID,C_PLAN_ID,C_BATCH_NO,C_ORD_NO,C_STOVE,C_STA_ID,C_STA_CODE,C_STA_DESC,C_STL_GRD,C_STL_GRD_PRE,C_MAT_CODE,C_MAT_NAME,C_SPEC,N_LEN,N_QUA,N_WGT,C_STD_CODE,C_SLAB_TYPE,D_CCM_DATE,C_CCM_SHIFT,C_CCM_GROUP,C_CCM_EMP_ID,C_MOVE_TYPE,C_SC_STATE,D_ESC_DATE,D_LSC_DATE,C_QKP_STATE,C_KP_ID,C_CON_NO,C_CUS_NO,C_CUS_NAME,D_WL_DATE,C_WL_SHIFT,C_WL_GROUP,C_WL_EMP_ID,D_WE_DATE,C_WE_SHIFT,C_WE_GROUP,C_WE_EMP_ID,C_STOCK_STATE,C_MAT_TYPE,C_QGP_STATE,C_SLABWH_CODE,C_SLABWH_AREA_CODE,C_SLABWH_LOC_CODE,C_SLABWH_TIER_CODE,N_WGT_METER,C_QF_NAME,C_DESIGN_NO,C_ZRBM,C_IS_DEPOT,C_ISXM,C_XMGX,C_ISFREE,C_JUDGE_LEV_CF,C_JUDGE_LEV_XN,C_JUDGE_LEV_ZH,C_JUDGE_LEV_ZH_PEOPLE,D_JUDGE_DATE,C_IS_QR,C_QR_USER,D_QR_DATE,D_Q_DATE,C_SCUTCHEON,C_GP_TYPE,C_REMARK,C_IS_TB,C_MASTER_ID,C_GP_BEFORE_ID,C_GP_AFTER_ID,D_STACK_DATE,C_STACK_USER,C_STACK_SHIFT,C_STACK_GROUP,C_IS_PD,C_REASON_NAME,C_FYDH,C_SLAB_STATUS,C_ZKDH,C_ZKDHID,C_LGJH,C_MES_FLOOR,N_JZ,C_HL,N_HL_TIME,C_HLYQ,C_DFP_HL,N_DFP_HL_TIME,C_ROUTE,C_ZYX1,C_ZYX2,C_COMMUTE_REASON,C_DEPOT_TYPE,C_SLAB_TYPE_R)");
            strSql.Append(" values (");
            strSql.Append(":C_ID,:C_PLAN_ID,:C_BATCH_NO,:C_ORD_NO,:C_STOVE,:C_STA_ID,:C_STA_CODE,:C_STA_DESC,:C_STL_GRD,:C_STL_GRD_PRE,:C_MAT_CODE,:C_MAT_NAME,:C_SPEC,:N_LEN,:N_QUA,:N_WGT,:C_STD_CODE,:C_SLAB_TYPE,:D_CCM_DATE,:C_CCM_SHIFT,:C_CCM_GROUP,:C_CCM_EMP_ID,:C_MOVE_TYPE,:C_SC_STATE,:D_ESC_DATE,:D_LSC_DATE,:C_QKP_STATE,:C_KP_ID,:C_CON_NO,:C_CUS_NO,:C_CUS_NAME,:D_WL_DATE,:C_WL_SHIFT,:C_WL_GROUP,:C_WL_EMP_ID,:D_WE_DATE,:C_WE_SHIFT,:C_WE_GROUP,:C_WE_EMP_ID,:C_STOCK_STATE,:C_MAT_TYPE,:C_QGP_STATE,:C_SLABWH_CODE,:C_SLABWH_AREA_CODE,:C_SLABWH_LOC_CODE,:C_SLABWH_TIER_CODE,:N_WGT_METER,:C_QF_NAME,:C_DESIGN_NO,:C_ZRBM,:C_IS_DEPOT,:C_ISXM,:C_XMGX,:C_ISFREE,:C_JUDGE_LEV_CF,:C_JUDGE_LEV_XN,:C_JUDGE_LEV_ZH,:C_JUDGE_LEV_ZH_PEOPLE,:D_JUDGE_DATE,:C_IS_QR,:C_QR_USER,:D_QR_DATE,:D_Q_DATE,:C_SCUTCHEON,:C_GP_TYPE,:C_REMARK,:C_IS_TB,:C_MASTER_ID,:C_GP_BEFORE_ID,:C_GP_AFTER_ID,:D_STACK_DATE,:C_STACK_USER,:C_STACK_SHIFT,:C_STACK_GROUP,:C_IS_PD,:C_REASON_NAME,:C_FYDH,:C_SLAB_STATUS,:C_ZKDH,:C_ZKDHID,:C_LGJH,:C_MES_FLOOR,:N_JZ,:C_HL,:N_HL_TIME,:C_HLYQ,:C_DFP_HL,:N_DFP_HL_TIME,:C_ROUTE,:C_ZYX1,:C_ZYX2,:C_COMMUTE_REASON,:C_DEPOT_TYPE,:C_SLAB_TYPE_R)");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PLAN_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_BATCH_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ORD_NO", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_STOVE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STA_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STA_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STA_DESC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STL_GRD", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STL_GRD_PRE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MAT_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MAT_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SPEC", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_LEN", OracleDbType.Decimal,5),
                    new OracleParameter(":N_QUA", OracleDbType.Decimal,5),
                    new OracleParameter(":N_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":C_STD_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SLAB_TYPE", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_CCM_DATE", OracleDbType.Date),
                    new OracleParameter(":C_CCM_SHIFT", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CCM_GROUP", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CCM_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MOVE_TYPE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SC_STATE", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_ESC_DATE", OracleDbType.Date),
                    new OracleParameter(":D_LSC_DATE", OracleDbType.Date),
                    new OracleParameter(":C_QKP_STATE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_KP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CON_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CUS_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CUS_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_WL_DATE", OracleDbType.Date),
                    new OracleParameter(":C_WL_SHIFT", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_WL_GROUP", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_WL_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_WE_DATE", OracleDbType.Date),
                    new OracleParameter(":C_WE_SHIFT", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_WE_GROUP", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_WE_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STOCK_STATE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MAT_TYPE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_QGP_STATE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SLABWH_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SLABWH_AREA_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SLABWH_LOC_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SLABWH_TIER_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_WGT_METER", OracleDbType.Decimal,5),
                    new OracleParameter(":C_QF_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_DESIGN_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ZRBM", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_IS_DEPOT", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ISXM", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_XMGX", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ISFREE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_JUDGE_LEV_CF", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_JUDGE_LEV_XN", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_JUDGE_LEV_ZH", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_JUDGE_LEV_ZH_PEOPLE", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_JUDGE_DATE", OracleDbType.Date),
                    new OracleParameter(":C_IS_QR", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_QR_USER", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_QR_DATE", OracleDbType.Date),
                    new OracleParameter(":D_Q_DATE", OracleDbType.Date),
                    new OracleParameter(":C_SCUTCHEON", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_GP_TYPE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_IS_TB", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_MASTER_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_GP_BEFORE_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_GP_AFTER_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_STACK_DATE", OracleDbType.Date),
                    new OracleParameter(":C_STACK_USER", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STACK_SHIFT", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STACK_GROUP", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_IS_PD", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_REASON_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_FYDH", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SLAB_STATUS", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ZKDH", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ZKDHID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_LGJH", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MES_FLOOR", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_JZ", OracleDbType.Decimal,15),
                    new OracleParameter(":C_HL", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_HL_TIME", OracleDbType.Decimal,15),
                    new OracleParameter(":C_HLYQ", OracleDbType.Varchar2,400),
                    new OracleParameter(":C_DFP_HL", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_DFP_HL_TIME", OracleDbType.Decimal,10),
                    new OracleParameter(":C_ROUTE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ZYX1", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ZYX2", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_COMMUTE_REASON", OracleDbType.Varchar2,200),
                    new OracleParameter(":C_DEPOT_TYPE", OracleDbType.Varchar2,200),
                    new OracleParameter(":C_SLAB_TYPE_R", OracleDbType.Varchar2,50)};
            parameters[0].Value = model.C_ID;
            parameters[1].Value = model.C_PLAN_ID;
            parameters[2].Value = model.C_BATCH_NO;
            parameters[3].Value = model.C_ORD_NO;
            parameters[4].Value = model.C_STOVE;
            parameters[5].Value = model.C_STA_ID;
            parameters[6].Value = model.C_STA_CODE;
            parameters[7].Value = model.C_STA_DESC;
            parameters[8].Value = model.C_STL_GRD;
            parameters[9].Value = model.C_STL_GRD_PRE;
            parameters[10].Value = model.C_MAT_CODE;
            parameters[11].Value = model.C_MAT_NAME;
            parameters[12].Value = model.C_SPEC;
            parameters[13].Value = model.N_LEN;
            parameters[14].Value = model.N_QUA;
            parameters[15].Value = model.N_WGT;
            parameters[16].Value = model.C_STD_CODE;
            parameters[17].Value = model.C_SLAB_TYPE;
            parameters[18].Value = model.D_CCM_DATE;
            parameters[19].Value = model.C_CCM_SHIFT;
            parameters[20].Value = model.C_CCM_GROUP;
            parameters[21].Value = model.C_CCM_EMP_ID;
            parameters[22].Value = model.C_MOVE_TYPE;
            parameters[23].Value = model.C_SC_STATE;
            parameters[24].Value = model.D_ESC_DATE;
            parameters[25].Value = model.D_LSC_DATE;
            parameters[26].Value = model.C_QKP_STATE;
            parameters[27].Value = model.C_KP_ID;
            parameters[28].Value = model.C_CON_NO;
            parameters[29].Value = model.C_CUS_NO;
            parameters[30].Value = model.C_CUS_NAME;
            parameters[31].Value = model.D_WL_DATE;
            parameters[32].Value = model.C_WL_SHIFT;
            parameters[33].Value = model.C_WL_GROUP;
            parameters[34].Value = model.C_WL_EMP_ID;
            parameters[35].Value = model.D_WE_DATE;
            parameters[36].Value = model.C_WE_SHIFT;
            parameters[37].Value = model.C_WE_GROUP;
            parameters[38].Value = model.C_WE_EMP_ID;
            parameters[39].Value = model.C_STOCK_STATE;
            parameters[40].Value = model.C_MAT_TYPE;
            parameters[41].Value = model.C_QGP_STATE;
            parameters[42].Value = model.C_SLABWH_CODE;
            parameters[43].Value = model.C_SLABWH_AREA_CODE;
            parameters[44].Value = model.C_SLABWH_LOC_CODE;
            parameters[45].Value = model.C_SLABWH_TIER_CODE;
            parameters[46].Value = model.N_WGT_METER;
            parameters[47].Value = model.C_QF_NAME;
            parameters[48].Value = model.C_DESIGN_NO;
            parameters[49].Value = model.C_ZRBM;
            parameters[50].Value = model.C_IS_DEPOT;
            parameters[51].Value = model.C_ISXM;
            parameters[52].Value = model.C_XMGX;
            parameters[53].Value = model.C_ISFREE;
            parameters[54].Value = model.C_JUDGE_LEV_CF;
            parameters[55].Value = model.C_JUDGE_LEV_XN;
            parameters[56].Value = model.C_JUDGE_LEV_ZH;
            parameters[57].Value = model.C_JUDGE_LEV_ZH_PEOPLE;
            parameters[58].Value = model.D_JUDGE_DATE;
            parameters[59].Value = model.C_IS_QR;
            parameters[60].Value = model.C_QR_USER;
            parameters[61].Value = model.D_QR_DATE;
            parameters[62].Value = model.D_Q_DATE;
            parameters[63].Value = model.C_SCUTCHEON;
            parameters[64].Value = model.C_GP_TYPE;
            parameters[65].Value = model.C_REMARK;
            parameters[66].Value = model.C_IS_TB;
            parameters[67].Value = model.C_MASTER_ID;
            parameters[68].Value = model.C_GP_BEFORE_ID;
            parameters[69].Value = model.C_GP_AFTER_ID;
            parameters[70].Value = model.D_STACK_DATE;
            parameters[71].Value = model.C_STACK_USER;
            parameters[72].Value = model.C_STACK_SHIFT;
            parameters[73].Value = model.C_STACK_GROUP;
            parameters[74].Value = model.C_IS_PD;
            parameters[75].Value = model.C_REASON_NAME;
            parameters[76].Value = model.C_FYDH;
            parameters[77].Value = model.C_SLAB_STATUS;
            parameters[78].Value = model.C_ZKDH;
            parameters[79].Value = model.C_ZKDHID;
            parameters[80].Value = model.C_LGJH;
            parameters[81].Value = model.C_MES_FLOOR;
            parameters[82].Value = model.N_JZ;
            parameters[83].Value = model.C_HL;
            parameters[84].Value = model.N_HL_TIME;
            parameters[85].Value = model.C_HLYQ;
            parameters[86].Value = model.C_DFP_HL;
            parameters[87].Value = model.N_DFP_HL_TIME;
            parameters[88].Value = model.C_ROUTE;
            parameters[89].Value = model.C_ZYX1;
            parameters[90].Value = model.C_ZYX2;
            parameters[91].Value = model.C_COMMUTE_REASON;
            parameters[92].Value = model.C_DEPOT_TYPE;
            parameters[93].Value = model.C_SLAB_TYPE_R;

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
        public bool AddTran(Mod_TSC_SLAB_MAIN model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TSC_SLAB_MAIN(");
            strSql.Append("C_ID,C_PLAN_ID,C_BATCH_NO,C_ORD_NO,C_STOVE,C_STA_ID,C_STA_CODE,C_STA_DESC,C_STL_GRD,C_STL_GRD_PRE,C_MAT_CODE,C_MAT_NAME,C_SPEC,N_LEN,N_QUA,N_WGT,C_STD_CODE,C_SLAB_TYPE,D_CCM_DATE,C_CCM_SHIFT,C_CCM_GROUP,C_CCM_EMP_ID,C_MOVE_TYPE,C_SC_STATE,D_ESC_DATE,D_LSC_DATE,C_QKP_STATE,C_KP_ID,C_CON_NO,C_CUS_NO,C_CUS_NAME,D_WL_DATE,C_WL_SHIFT,C_WL_GROUP,C_WL_EMP_ID,D_WE_DATE,C_WE_SHIFT,C_WE_GROUP,C_WE_EMP_ID,C_STOCK_STATE,C_MAT_TYPE,C_QGP_STATE,C_SLABWH_CODE,C_SLABWH_AREA_CODE,C_SLABWH_LOC_CODE,C_SLABWH_TIER_CODE,N_WGT_METER,C_QF_NAME,C_DESIGN_NO,C_ZRBM,C_IS_DEPOT,C_ISXM,C_XMGX,C_ISFREE,C_JUDGE_LEV_CF,C_JUDGE_LEV_XN,C_JUDGE_LEV_ZH,C_JUDGE_LEV_ZH_PEOPLE,D_JUDGE_DATE,C_IS_QR,C_QR_USER,D_QR_DATE,D_Q_DATE,C_SCUTCHEON,C_GP_TYPE,C_REMARK,C_IS_TB,C_MASTER_ID,C_GP_BEFORE_ID,C_GP_AFTER_ID,D_STACK_DATE,C_STACK_USER,C_STACK_SHIFT,C_STACK_GROUP,C_IS_PD,C_REASON_NAME,C_FYDH,C_SLAB_STATUS,C_ZKDH,C_ZKDHID,C_LGJH,C_MES_FLOOR,N_JZ,C_HL,N_HL_TIME,C_HLYQ,C_DFP_HL,N_DFP_HL_TIME,C_ROUTE,C_ZYX1,C_ZYX2,C_COMMUTE_REASON,C_DEPOT_TYPE,C_SLAB_TYPE_R)");
            strSql.Append(" values (");
            strSql.Append(":C_ID,:C_PLAN_ID,:C_BATCH_NO,:C_ORD_NO,:C_STOVE,:C_STA_ID,:C_STA_CODE,:C_STA_DESC,:C_STL_GRD,:C_STL_GRD_PRE,:C_MAT_CODE,:C_MAT_NAME,:C_SPEC,:N_LEN,:N_QUA,:N_WGT,:C_STD_CODE,:C_SLAB_TYPE,:D_CCM_DATE,:C_CCM_SHIFT,:C_CCM_GROUP,:C_CCM_EMP_ID,:C_MOVE_TYPE,:C_SC_STATE,:D_ESC_DATE,:D_LSC_DATE,:C_QKP_STATE,:C_KP_ID,:C_CON_NO,:C_CUS_NO,:C_CUS_NAME,:D_WL_DATE,:C_WL_SHIFT,:C_WL_GROUP,:C_WL_EMP_ID,:D_WE_DATE,:C_WE_SHIFT,:C_WE_GROUP,:C_WE_EMP_ID,:C_STOCK_STATE,:C_MAT_TYPE,:C_QGP_STATE,:C_SLABWH_CODE,:C_SLABWH_AREA_CODE,:C_SLABWH_LOC_CODE,:C_SLABWH_TIER_CODE,:N_WGT_METER,:C_QF_NAME,:C_DESIGN_NO,:C_ZRBM,:C_IS_DEPOT,:C_ISXM,:C_XMGX,:C_ISFREE,:C_JUDGE_LEV_CF,:C_JUDGE_LEV_XN,:C_JUDGE_LEV_ZH,:C_JUDGE_LEV_ZH_PEOPLE,:D_JUDGE_DATE,:C_IS_QR,:C_QR_USER,:D_QR_DATE,:D_Q_DATE,:C_SCUTCHEON,:C_GP_TYPE,:C_REMARK,:C_IS_TB,:C_MASTER_ID,:C_GP_BEFORE_ID,:C_GP_AFTER_ID,:D_STACK_DATE,:C_STACK_USER,:C_STACK_SHIFT,:C_STACK_GROUP,:C_IS_PD,:C_REASON_NAME,:C_FYDH,:C_SLAB_STATUS,:C_ZKDH,:C_ZKDHID,:C_LGJH,:C_MES_FLOOR,:N_JZ,:C_HL,:N_HL_TIME,:C_HLYQ,:C_DFP_HL,:N_DFP_HL_TIME,:C_ROUTE,:C_ZYX1,:C_ZYX2,:C_COMMUTE_REASON,:C_DEPOT_TYPE,:C_SLAB_TYPE_R)");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PLAN_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_BATCH_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ORD_NO", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_STOVE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STA_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STA_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STA_DESC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STL_GRD", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STL_GRD_PRE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MAT_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MAT_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SPEC", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_LEN", OracleDbType.Decimal,5),
                    new OracleParameter(":N_QUA", OracleDbType.Decimal,5),
                    new OracleParameter(":N_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":C_STD_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SLAB_TYPE", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_CCM_DATE", OracleDbType.Date),
                    new OracleParameter(":C_CCM_SHIFT", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CCM_GROUP", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CCM_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MOVE_TYPE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SC_STATE", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_ESC_DATE", OracleDbType.Date),
                    new OracleParameter(":D_LSC_DATE", OracleDbType.Date),
                    new OracleParameter(":C_QKP_STATE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_KP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CON_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CUS_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CUS_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_WL_DATE", OracleDbType.Date),
                    new OracleParameter(":C_WL_SHIFT", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_WL_GROUP", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_WL_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_WE_DATE", OracleDbType.Date),
                    new OracleParameter(":C_WE_SHIFT", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_WE_GROUP", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_WE_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STOCK_STATE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MAT_TYPE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_QGP_STATE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SLABWH_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SLABWH_AREA_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SLABWH_LOC_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SLABWH_TIER_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_WGT_METER", OracleDbType.Decimal,5),
                    new OracleParameter(":C_QF_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_DESIGN_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ZRBM", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_IS_DEPOT", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ISXM", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_XMGX", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ISFREE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_JUDGE_LEV_CF", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_JUDGE_LEV_XN", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_JUDGE_LEV_ZH", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_JUDGE_LEV_ZH_PEOPLE", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_JUDGE_DATE", OracleDbType.Date),
                    new OracleParameter(":C_IS_QR", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_QR_USER", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_QR_DATE", OracleDbType.Date),
                    new OracleParameter(":D_Q_DATE", OracleDbType.Date),
                    new OracleParameter(":C_SCUTCHEON", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_GP_TYPE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_IS_TB", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_MASTER_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_GP_BEFORE_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_GP_AFTER_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_STACK_DATE", OracleDbType.Date),
                    new OracleParameter(":C_STACK_USER", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STACK_SHIFT", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STACK_GROUP", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_IS_PD", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_REASON_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_FYDH", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SLAB_STATUS", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ZKDH", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ZKDHID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_LGJH", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MES_FLOOR", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_JZ", OracleDbType.Decimal,15),
                    new OracleParameter(":C_HL", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_HL_TIME", OracleDbType.Decimal,15),
                    new OracleParameter(":C_HLYQ", OracleDbType.Varchar2,400),
                    new OracleParameter(":C_DFP_HL", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_DFP_HL_TIME", OracleDbType.Decimal,10),
                    new OracleParameter(":C_ROUTE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ZYX1", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ZYX2", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_COMMUTE_REASON", OracleDbType.Varchar2,200),
                    new OracleParameter(":C_DEPOT_TYPE", OracleDbType.Varchar2,200),
                    new OracleParameter(":C_SLAB_TYPE_R", OracleDbType.Varchar2,50)};
            parameters[0].Value = model.C_ID;
            parameters[1].Value = model.C_PLAN_ID;
            parameters[2].Value = model.C_BATCH_NO;
            parameters[3].Value = model.C_ORD_NO;
            parameters[4].Value = model.C_STOVE;
            parameters[5].Value = model.C_STA_ID;
            parameters[6].Value = model.C_STA_CODE;
            parameters[7].Value = model.C_STA_DESC;
            parameters[8].Value = model.C_STL_GRD;
            parameters[9].Value = model.C_STL_GRD_PRE;
            parameters[10].Value = model.C_MAT_CODE;
            parameters[11].Value = model.C_MAT_NAME;
            parameters[12].Value = model.C_SPEC;
            parameters[13].Value = model.N_LEN;
            parameters[14].Value = model.N_QUA;
            parameters[15].Value = model.N_WGT;
            parameters[16].Value = model.C_STD_CODE;
            parameters[17].Value = model.C_SLAB_TYPE;
            parameters[18].Value = model.D_CCM_DATE;
            parameters[19].Value = model.C_CCM_SHIFT;
            parameters[20].Value = model.C_CCM_GROUP;
            parameters[21].Value = model.C_CCM_EMP_ID;
            parameters[22].Value = model.C_MOVE_TYPE;
            parameters[23].Value = model.C_SC_STATE;
            parameters[24].Value = model.D_ESC_DATE;
            parameters[25].Value = model.D_LSC_DATE;
            parameters[26].Value = model.C_QKP_STATE;
            parameters[27].Value = model.C_KP_ID;
            parameters[28].Value = model.C_CON_NO;
            parameters[29].Value = model.C_CUS_NO;
            parameters[30].Value = model.C_CUS_NAME;
            parameters[31].Value = model.D_WL_DATE;
            parameters[32].Value = model.C_WL_SHIFT;
            parameters[33].Value = model.C_WL_GROUP;
            parameters[34].Value = model.C_WL_EMP_ID;
            parameters[35].Value = model.D_WE_DATE;
            parameters[36].Value = model.C_WE_SHIFT;
            parameters[37].Value = model.C_WE_GROUP;
            parameters[38].Value = model.C_WE_EMP_ID;
            parameters[39].Value = model.C_STOCK_STATE;
            parameters[40].Value = model.C_MAT_TYPE;
            parameters[41].Value = model.C_QGP_STATE;
            parameters[42].Value = model.C_SLABWH_CODE;
            parameters[43].Value = model.C_SLABWH_AREA_CODE;
            parameters[44].Value = model.C_SLABWH_LOC_CODE;
            parameters[45].Value = model.C_SLABWH_TIER_CODE;
            parameters[46].Value = model.N_WGT_METER;
            parameters[47].Value = model.C_QF_NAME;
            parameters[48].Value = model.C_DESIGN_NO;
            parameters[49].Value = model.C_ZRBM;
            parameters[50].Value = model.C_IS_DEPOT;
            parameters[51].Value = model.C_ISXM;
            parameters[52].Value = model.C_XMGX;
            parameters[53].Value = model.C_ISFREE;
            parameters[54].Value = model.C_JUDGE_LEV_CF;
            parameters[55].Value = model.C_JUDGE_LEV_XN;
            parameters[56].Value = model.C_JUDGE_LEV_ZH;
            parameters[57].Value = model.C_JUDGE_LEV_ZH_PEOPLE;
            parameters[58].Value = model.D_JUDGE_DATE;
            parameters[59].Value = model.C_IS_QR;
            parameters[60].Value = model.C_QR_USER;
            parameters[61].Value = model.D_QR_DATE;
            parameters[62].Value = model.D_Q_DATE;
            parameters[63].Value = model.C_SCUTCHEON;
            parameters[64].Value = model.C_GP_TYPE;
            parameters[65].Value = model.C_REMARK;
            parameters[66].Value = model.C_IS_TB;
            parameters[67].Value = model.C_MASTER_ID;
            parameters[68].Value = model.C_GP_BEFORE_ID;
            parameters[69].Value = model.C_GP_AFTER_ID;
            parameters[70].Value = model.D_STACK_DATE;
            parameters[71].Value = model.C_STACK_USER;
            parameters[72].Value = model.C_STACK_SHIFT;
            parameters[73].Value = model.C_STACK_GROUP;
            parameters[74].Value = model.C_IS_PD;
            parameters[75].Value = model.C_REASON_NAME;
            parameters[76].Value = model.C_FYDH;
            parameters[77].Value = model.C_SLAB_STATUS;
            parameters[78].Value = model.C_ZKDH;
            parameters[79].Value = model.C_ZKDHID;
            parameters[80].Value = model.C_LGJH;
            parameters[81].Value = model.C_MES_FLOOR;
            parameters[82].Value = model.N_JZ;
            parameters[83].Value = model.C_HL;
            parameters[84].Value = model.N_HL_TIME;
            parameters[85].Value = model.C_HLYQ;
            parameters[86].Value = model.C_DFP_HL;
            parameters[87].Value = model.N_DFP_HL_TIME;
            parameters[88].Value = model.C_ROUTE;
            parameters[89].Value = model.C_ZYX1;
            parameters[90].Value = model.C_ZYX2;
            parameters[91].Value = model.C_COMMUTE_REASON;
            parameters[92].Value = model.C_DEPOT_TYPE;
            parameters[93].Value = model.C_SLAB_TYPE_R;

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
        /// <param name="stove">炉号</param>
        /// <param name="strGrd">钢种</param>
        /// <param name="strStdCode">执行标准</param>
        /// <param name="strMatCode">物料编码</param>
        /// <param name="strMatName">物料描述</param>
        /// <param name="spec">规格</param>
        /// <param name="max_C_MASTER_ID">实绩主键</param>
        /// <param name="max_C_GP_BEFORE_ID">改判前主键</param>
        /// <param name="max_C_GP_AFTER_ID">改判后主键</param>
        /// <param name="strLGJH">炼钢记号</param>
        /// <param name="PDDJ">判定等级</param>
        /// <param name="strZYX1">自由项1</param>
        /// <param name="strZYX2">自由项2</param>
        /// <param name="strGPYY">改判原因</param>
        /// <param name="strDesignNo">质量设计号</param>
        /// <returns></returns>
        public bool Update_Trans(string C_ID, string C_BATCH_NO, string strGrd, string strStdCode, string strMatCode, string strMatName, string spec, string max_C_MASTER_ID, string max_C_GP_BEFORE_ID, string max_C_GP_AFTER_ID, string strLGJH, string PDDJ, string strZYX1, string strZYX2, string strGPYY, string Len, string strDesignNo)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TSC_SLAB_MAIN t set ");
            strSql.Append("t.C_IS_TB= 'N',");
            strSql.Append("t.C_IS_PD= 'N',");
            strSql.Append("t.C_DESIGN_NO= '" + strDesignNo + "',");
            strSql.Append("t.C_QGP_STATE='Y',");
            strSql.Append("t.c_stl_grd= '" + strGrd + "',");
            strSql.Append("t.c_std_code= '" + strStdCode + "',");
            strSql.Append("t.c_mat_code= '" + strMatCode + "',");
            strSql.Append("t.c_mat_name= '" + strMatName + "',");
            strSql.Append("t.N_LEN='" + Len + "',");
            strSql.Append("t.c_spec= '" + spec + "',");
            strSql.Append("t.c_master_id= '" + max_C_MASTER_ID + "',");
            strSql.Append("t.c_gp_before_id= '" + max_C_GP_BEFORE_ID + "',");
            strSql.Append("t.c_gp_after_id= '" + max_C_GP_AFTER_ID + "',");
            strSql.Append("t.C_LGJH='" + strLGJH + "', ");
            strSql.Append("t.C_ZYX1='" + strZYX1 + "', ");
            strSql.Append("t.C_ZYX2='" + strZYX2 + "', ");
            strSql.Append("t.C_JUDGE_LEV_ZH='" + PDDJ + "', ");
            strSql.Append("t.C_COMMUTE_REASON='" + strGPYY + "' ");
            strSql.Append(" where t.C_ID = '" + C_ID + "'");

            if (!string.IsNullOrEmpty(C_BATCH_NO))
            {
                strSql.Append(" and t.C_BATCH_NO = '" + C_BATCH_NO + "'");
            }
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
        /// <param name="C_ID">主键ID</param>
        /// <param name="C_BATCH_NO">开坯号</param>
        /// <returns></returns>
        public bool UpdateTP_Trans(string C_ID, string C_BATCH_NO)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TSC_SLAB_MAIN t set ");
            strSql.Append("t.C_MOVE_TYPE= 'TP'");
            strSql.Append(" where t.C_ID = '" + C_ID + "'");

            if (!string.IsNullOrEmpty(C_BATCH_NO))
            {
                strSql.Append(" and t.C_BATCH_NO = '" + C_BATCH_NO + "'");
            }
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
        public bool Update(Mod_TSC_SLAB_MAIN model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TSC_SLAB_MAIN set ");
            strSql.Append("C_PLAN_ID=:C_PLAN_ID,");
            strSql.Append("C_BATCH_NO=:C_BATCH_NO,");
            strSql.Append("C_ORD_NO=:C_ORD_NO,");
            strSql.Append("C_STOVE=:C_STOVE,");
            strSql.Append("C_STA_ID=:C_STA_ID,");
            strSql.Append("C_STA_CODE=:C_STA_CODE,");
            strSql.Append("C_STA_DESC=:C_STA_DESC,");
            strSql.Append("C_STL_GRD=:C_STL_GRD,");
            strSql.Append("C_STL_GRD_PRE=:C_STL_GRD_PRE,");
            strSql.Append("C_MAT_CODE=:C_MAT_CODE,");
            strSql.Append("C_MAT_NAME=:C_MAT_NAME,");
            strSql.Append("C_SPEC=:C_SPEC,");
            strSql.Append("N_LEN=:N_LEN,");
            strSql.Append("N_QUA=:N_QUA,");
            strSql.Append("N_WGT=:N_WGT,");
            strSql.Append("C_STD_CODE=:C_STD_CODE,");
            strSql.Append("C_SLAB_TYPE=:C_SLAB_TYPE,");
            strSql.Append("D_CCM_DATE=:D_CCM_DATE,");
            strSql.Append("C_CCM_SHIFT=:C_CCM_SHIFT,");
            strSql.Append("C_CCM_GROUP=:C_CCM_GROUP,");
            strSql.Append("C_CCM_EMP_ID=:C_CCM_EMP_ID,");
            strSql.Append("C_MOVE_TYPE=:C_MOVE_TYPE,");
            strSql.Append("C_SC_STATE=:C_SC_STATE,");
            strSql.Append("D_ESC_DATE=:D_ESC_DATE,");
            strSql.Append("D_LSC_DATE=:D_LSC_DATE,");
            strSql.Append("C_QKP_STATE=:C_QKP_STATE,");
            strSql.Append("C_KP_ID=:C_KP_ID,");
            strSql.Append("C_CON_NO=:C_CON_NO,");
            strSql.Append("C_CUS_NO=:C_CUS_NO,");
            strSql.Append("C_CUS_NAME=:C_CUS_NAME,");
            strSql.Append("D_WL_DATE=:D_WL_DATE,");
            strSql.Append("C_WL_SHIFT=:C_WL_SHIFT,");
            strSql.Append("C_WL_GROUP=:C_WL_GROUP,");
            strSql.Append("C_WL_EMP_ID=:C_WL_EMP_ID,");
            strSql.Append("D_WE_DATE=:D_WE_DATE,");
            strSql.Append("C_WE_SHIFT=:C_WE_SHIFT,");
            strSql.Append("C_WE_GROUP=:C_WE_GROUP,");
            strSql.Append("C_WE_EMP_ID=:C_WE_EMP_ID,");
            strSql.Append("C_STOCK_STATE=:C_STOCK_STATE,");
            strSql.Append("C_MAT_TYPE=:C_MAT_TYPE,");
            strSql.Append("C_QGP_STATE=:C_QGP_STATE,");
            strSql.Append("C_SLABWH_CODE=:C_SLABWH_CODE,");
            strSql.Append("C_SLABWH_AREA_CODE=:C_SLABWH_AREA_CODE,");
            strSql.Append("C_SLABWH_LOC_CODE=:C_SLABWH_LOC_CODE,");
            strSql.Append("C_SLABWH_TIER_CODE=:C_SLABWH_TIER_CODE,");
            strSql.Append("N_WGT_METER=:N_WGT_METER,");
            strSql.Append("C_QF_NAME=:C_QF_NAME,");
            strSql.Append("C_DESIGN_NO=:C_DESIGN_NO,");
            strSql.Append("C_ZRBM=:C_ZRBM,");
            strSql.Append("C_IS_DEPOT=:C_IS_DEPOT,");
            strSql.Append("C_ISXM=:C_ISXM,");
            strSql.Append("C_XMGX=:C_XMGX,");
            strSql.Append("C_ISFREE=:C_ISFREE,");
            strSql.Append("C_JUDGE_LEV_CF=:C_JUDGE_LEV_CF,");
            strSql.Append("C_JUDGE_LEV_XN=:C_JUDGE_LEV_XN,");
            strSql.Append("C_JUDGE_LEV_ZH=:C_JUDGE_LEV_ZH,");
            strSql.Append("C_JUDGE_LEV_ZH_PEOPLE=:C_JUDGE_LEV_ZH_PEOPLE,");
            strSql.Append("D_JUDGE_DATE=:D_JUDGE_DATE,");
            strSql.Append("C_IS_QR=:C_IS_QR,");
            strSql.Append("C_QR_USER=:C_QR_USER,");
            strSql.Append("D_QR_DATE=:D_QR_DATE,");
            strSql.Append("D_Q_DATE=:D_Q_DATE,");
            strSql.Append("C_SCUTCHEON=:C_SCUTCHEON,");
            strSql.Append("C_GP_TYPE=:C_GP_TYPE,");
            strSql.Append("C_REMARK=:C_REMARK,");
            strSql.Append("C_IS_TB=:C_IS_TB,");
            strSql.Append("C_MASTER_ID=:C_MASTER_ID,");
            strSql.Append("C_GP_BEFORE_ID=:C_GP_BEFORE_ID,");
            strSql.Append("C_GP_AFTER_ID=:C_GP_AFTER_ID,");
            strSql.Append("D_STACK_DATE=:D_STACK_DATE,");
            strSql.Append("C_STACK_USER=:C_STACK_USER,");
            strSql.Append("C_STACK_SHIFT=:C_STACK_SHIFT,");
            strSql.Append("C_STACK_GROUP=:C_STACK_GROUP,");
            strSql.Append("C_IS_PD=:C_IS_PD,");
            strSql.Append("C_REASON_NAME=:C_REASON_NAME,");
            strSql.Append("C_FYDH=:C_FYDH,");
            strSql.Append("C_SLAB_STATUS=:C_SLAB_STATUS,");
            strSql.Append("C_ZKDH=:C_ZKDH,");
            strSql.Append("C_ZKDHID=:C_ZKDHID,");
            strSql.Append("C_LGJH=:C_LGJH,");
            strSql.Append("C_MES_FLOOR=:C_MES_FLOOR,");
            strSql.Append("N_JZ=:N_JZ,");
            strSql.Append("C_HL=:C_HL,");
            strSql.Append("N_HL_TIME=:N_HL_TIME,");
            strSql.Append("C_HLYQ=:C_HLYQ,");
            strSql.Append("C_DFP_HL=:C_DFP_HL,");
            strSql.Append("N_DFP_HL_TIME=:N_DFP_HL_TIME,");
            strSql.Append("C_ROUTE=:C_ROUTE,");
            strSql.Append("C_ZYX1=:C_ZYX1,");
            strSql.Append("C_ZYX2=:C_ZYX2,");
            strSql.Append("C_COMMUTE_REASON=:C_COMMUTE_REASON,");
            strSql.Append("C_DEPOT_TYPE=:C_DEPOT_TYPE,");
            strSql.Append("C_SLAB_TYPE_R=:C_SLAB_TYPE_R");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_PLAN_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_BATCH_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ORD_NO", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_STOVE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STA_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STA_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STA_DESC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STL_GRD", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STL_GRD_PRE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MAT_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MAT_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SPEC", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_LEN", OracleDbType.Decimal,5),
                    new OracleParameter(":N_QUA", OracleDbType.Decimal,5),
                    new OracleParameter(":N_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":C_STD_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SLAB_TYPE", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_CCM_DATE", OracleDbType.Date),
                    new OracleParameter(":C_CCM_SHIFT", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CCM_GROUP", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CCM_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MOVE_TYPE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SC_STATE", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_ESC_DATE", OracleDbType.Date),
                    new OracleParameter(":D_LSC_DATE", OracleDbType.Date),
                    new OracleParameter(":C_QKP_STATE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_KP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CON_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CUS_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CUS_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_WL_DATE", OracleDbType.Date),
                    new OracleParameter(":C_WL_SHIFT", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_WL_GROUP", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_WL_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_WE_DATE", OracleDbType.Date),
                    new OracleParameter(":C_WE_SHIFT", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_WE_GROUP", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_WE_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STOCK_STATE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MAT_TYPE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_QGP_STATE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SLABWH_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SLABWH_AREA_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SLABWH_LOC_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SLABWH_TIER_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_WGT_METER", OracleDbType.Decimal,5),
                    new OracleParameter(":C_QF_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_DESIGN_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ZRBM", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_IS_DEPOT", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ISXM", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_XMGX", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ISFREE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_JUDGE_LEV_CF", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_JUDGE_LEV_XN", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_JUDGE_LEV_ZH", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_JUDGE_LEV_ZH_PEOPLE", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_JUDGE_DATE", OracleDbType.Date),
                    new OracleParameter(":C_IS_QR", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_QR_USER", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_QR_DATE", OracleDbType.Date),
                    new OracleParameter(":D_Q_DATE", OracleDbType.Date),
                    new OracleParameter(":C_SCUTCHEON", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_GP_TYPE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_IS_TB", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_MASTER_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_GP_BEFORE_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_GP_AFTER_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_STACK_DATE", OracleDbType.Date),
                    new OracleParameter(":C_STACK_USER", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STACK_SHIFT", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STACK_GROUP", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_IS_PD", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_REASON_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_FYDH", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SLAB_STATUS", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ZKDH", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ZKDHID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_LGJH", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MES_FLOOR", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_JZ", OracleDbType.Decimal,15),
                    new OracleParameter(":C_HL", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_HL_TIME", OracleDbType.Decimal,15),
                    new OracleParameter(":C_HLYQ", OracleDbType.Varchar2,400),
                    new OracleParameter(":C_DFP_HL", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_DFP_HL_TIME", OracleDbType.Decimal,10),
                    new OracleParameter(":C_ROUTE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ZYX1", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ZYX2", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_COMMUTE_REASON", OracleDbType.Varchar2,200),
                    new OracleParameter(":C_DEPOT_TYPE", OracleDbType.Varchar2,200),
                    new OracleParameter(":C_SLAB_TYPE_R", OracleDbType.Varchar2,50),
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.C_PLAN_ID;
            parameters[1].Value = model.C_BATCH_NO;
            parameters[2].Value = model.C_ORD_NO;
            parameters[3].Value = model.C_STOVE;
            parameters[4].Value = model.C_STA_ID;
            parameters[5].Value = model.C_STA_CODE;
            parameters[6].Value = model.C_STA_DESC;
            parameters[7].Value = model.C_STL_GRD;
            parameters[8].Value = model.C_STL_GRD_PRE;
            parameters[9].Value = model.C_MAT_CODE;
            parameters[10].Value = model.C_MAT_NAME;
            parameters[11].Value = model.C_SPEC;
            parameters[12].Value = model.N_LEN;
            parameters[13].Value = model.N_QUA;
            parameters[14].Value = model.N_WGT;
            parameters[15].Value = model.C_STD_CODE;
            parameters[16].Value = model.C_SLAB_TYPE;
            parameters[17].Value = model.D_CCM_DATE;
            parameters[18].Value = model.C_CCM_SHIFT;
            parameters[19].Value = model.C_CCM_GROUP;
            parameters[20].Value = model.C_CCM_EMP_ID;
            parameters[21].Value = model.C_MOVE_TYPE;
            parameters[22].Value = model.C_SC_STATE;
            parameters[23].Value = model.D_ESC_DATE;
            parameters[24].Value = model.D_LSC_DATE;
            parameters[25].Value = model.C_QKP_STATE;
            parameters[26].Value = model.C_KP_ID;
            parameters[27].Value = model.C_CON_NO;
            parameters[28].Value = model.C_CUS_NO;
            parameters[29].Value = model.C_CUS_NAME;
            parameters[30].Value = model.D_WL_DATE;
            parameters[31].Value = model.C_WL_SHIFT;
            parameters[32].Value = model.C_WL_GROUP;
            parameters[33].Value = model.C_WL_EMP_ID;
            parameters[34].Value = model.D_WE_DATE;
            parameters[35].Value = model.C_WE_SHIFT;
            parameters[36].Value = model.C_WE_GROUP;
            parameters[37].Value = model.C_WE_EMP_ID;
            parameters[38].Value = model.C_STOCK_STATE;
            parameters[39].Value = model.C_MAT_TYPE;
            parameters[40].Value = model.C_QGP_STATE;
            parameters[41].Value = model.C_SLABWH_CODE;
            parameters[42].Value = model.C_SLABWH_AREA_CODE;
            parameters[43].Value = model.C_SLABWH_LOC_CODE;
            parameters[44].Value = model.C_SLABWH_TIER_CODE;
            parameters[45].Value = model.N_WGT_METER;
            parameters[46].Value = model.C_QF_NAME;
            parameters[47].Value = model.C_DESIGN_NO;
            parameters[48].Value = model.C_ZRBM;
            parameters[49].Value = model.C_IS_DEPOT;
            parameters[50].Value = model.C_ISXM;
            parameters[51].Value = model.C_XMGX;
            parameters[52].Value = model.C_ISFREE;
            parameters[53].Value = model.C_JUDGE_LEV_CF;
            parameters[54].Value = model.C_JUDGE_LEV_XN;
            parameters[55].Value = model.C_JUDGE_LEV_ZH;
            parameters[56].Value = model.C_JUDGE_LEV_ZH_PEOPLE;
            parameters[57].Value = model.D_JUDGE_DATE;
            parameters[58].Value = model.C_IS_QR;
            parameters[59].Value = model.C_QR_USER;
            parameters[60].Value = model.D_QR_DATE;
            parameters[61].Value = model.D_Q_DATE;
            parameters[62].Value = model.C_SCUTCHEON;
            parameters[63].Value = model.C_GP_TYPE;
            parameters[64].Value = model.C_REMARK;
            parameters[65].Value = model.C_IS_TB;
            parameters[66].Value = model.C_MASTER_ID;
            parameters[67].Value = model.C_GP_BEFORE_ID;
            parameters[68].Value = model.C_GP_AFTER_ID;
            parameters[69].Value = model.D_STACK_DATE;
            parameters[70].Value = model.C_STACK_USER;
            parameters[71].Value = model.C_STACK_SHIFT;
            parameters[72].Value = model.C_STACK_GROUP;
            parameters[73].Value = model.C_IS_PD;
            parameters[74].Value = model.C_REASON_NAME;
            parameters[75].Value = model.C_FYDH;
            parameters[76].Value = model.C_SLAB_STATUS;
            parameters[77].Value = model.C_ZKDH;
            parameters[78].Value = model.C_ZKDHID;
            parameters[79].Value = model.C_LGJH;
            parameters[80].Value = model.C_MES_FLOOR;
            parameters[81].Value = model.N_JZ;
            parameters[82].Value = model.C_HL;
            parameters[83].Value = model.N_HL_TIME;
            parameters[84].Value = model.C_HLYQ;
            parameters[85].Value = model.C_DFP_HL;
            parameters[86].Value = model.N_DFP_HL_TIME;
            parameters[87].Value = model.C_ROUTE;
            parameters[88].Value = model.C_ZYX1;
            parameters[89].Value = model.C_ZYX2;
            parameters[90].Value = model.C_COMMUTE_REASON;
            parameters[91].Value = model.C_DEPOT_TYPE;
            parameters[92].Value = model.C_SLAB_TYPE_R;
            parameters[93].Value = model.C_ID;

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
        public bool Update_Trans(Mod_TSC_SLAB_MAIN model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TSC_SLAB_MAIN set ");
            strSql.Append("C_PLAN_ID=:C_PLAN_ID,");
            strSql.Append("C_BATCH_NO=:C_BATCH_NO,");
            strSql.Append("C_ORD_NO=:C_ORD_NO,");
            strSql.Append("C_STOVE=:C_STOVE,");
            strSql.Append("C_STA_ID=:C_STA_ID,");
            strSql.Append("C_STA_CODE=:C_STA_CODE,");
            strSql.Append("C_STA_DESC=:C_STA_DESC,");
            strSql.Append("C_STL_GRD=:C_STL_GRD,");
            strSql.Append("C_STL_GRD_PRE=:C_STL_GRD_PRE,");
            strSql.Append("C_MAT_CODE=:C_MAT_CODE,");
            strSql.Append("C_MAT_NAME=:C_MAT_NAME,");
            strSql.Append("C_SPEC=:C_SPEC,");
            strSql.Append("N_LEN=:N_LEN,");
            strSql.Append("N_QUA=:N_QUA,");
            strSql.Append("N_WGT=:N_WGT,");
            strSql.Append("C_STD_CODE=:C_STD_CODE,");
            strSql.Append("C_SLAB_TYPE=:C_SLAB_TYPE,");
            strSql.Append("D_CCM_DATE=:D_CCM_DATE,");
            strSql.Append("C_CCM_SHIFT=:C_CCM_SHIFT,");
            strSql.Append("C_CCM_GROUP=:C_CCM_GROUP,");
            strSql.Append("C_CCM_EMP_ID=:C_CCM_EMP_ID,");
            strSql.Append("C_MOVE_TYPE=:C_MOVE_TYPE,");
            strSql.Append("C_SC_STATE=:C_SC_STATE,");
            strSql.Append("D_ESC_DATE=:D_ESC_DATE,");
            strSql.Append("D_LSC_DATE=:D_LSC_DATE,");
            strSql.Append("C_QKP_STATE=:C_QKP_STATE,");
            strSql.Append("C_KP_ID=:C_KP_ID,");
            strSql.Append("C_CON_NO=:C_CON_NO,");
            strSql.Append("C_CUS_NO=:C_CUS_NO,");
            strSql.Append("C_CUS_NAME=:C_CUS_NAME,");
            strSql.Append("D_WL_DATE=:D_WL_DATE,");
            strSql.Append("C_WL_SHIFT=:C_WL_SHIFT,");
            strSql.Append("C_WL_GROUP=:C_WL_GROUP,");
            strSql.Append("C_WL_EMP_ID=:C_WL_EMP_ID,");
            strSql.Append("D_WE_DATE=:D_WE_DATE,");
            strSql.Append("C_WE_SHIFT=:C_WE_SHIFT,");
            strSql.Append("C_WE_GROUP=:C_WE_GROUP,");
            strSql.Append("C_WE_EMP_ID=:C_WE_EMP_ID,");
            strSql.Append("C_STOCK_STATE=:C_STOCK_STATE,");
            strSql.Append("C_MAT_TYPE=:C_MAT_TYPE,");
            strSql.Append("C_QGP_STATE=:C_QGP_STATE,");
            strSql.Append("C_SLABWH_CODE=:C_SLABWH_CODE,");
            strSql.Append("C_SLABWH_AREA_CODE=:C_SLABWH_AREA_CODE,");
            strSql.Append("C_SLABWH_LOC_CODE=:C_SLABWH_LOC_CODE,");
            strSql.Append("C_SLABWH_TIER_CODE=:C_SLABWH_TIER_CODE,");
            strSql.Append("N_WGT_METER=:N_WGT_METER,");
            strSql.Append("C_QF_NAME=:C_QF_NAME,");
            strSql.Append("C_DESIGN_NO=:C_DESIGN_NO,");
            strSql.Append("C_ZRBM=:C_ZRBM,");
            strSql.Append("C_IS_DEPOT=:C_IS_DEPOT,");
            strSql.Append("C_ISXM=:C_ISXM,");
            strSql.Append("C_XMGX=:C_XMGX,");
            strSql.Append("C_ISFREE=:C_ISFREE,");
            strSql.Append("C_JUDGE_LEV_CF=:C_JUDGE_LEV_CF,");
            strSql.Append("C_JUDGE_LEV_XN=:C_JUDGE_LEV_XN,");
            strSql.Append("C_JUDGE_LEV_ZH=:C_JUDGE_LEV_ZH,");
            strSql.Append("C_JUDGE_LEV_ZH_PEOPLE=:C_JUDGE_LEV_ZH_PEOPLE,");
            strSql.Append("D_JUDGE_DATE=:D_JUDGE_DATE,");
            strSql.Append("C_IS_QR=:C_IS_QR,");
            strSql.Append("C_QR_USER=:C_QR_USER,");
            strSql.Append("D_QR_DATE=:D_QR_DATE,");
            strSql.Append("D_Q_DATE=:D_Q_DATE,");
            strSql.Append("C_SCUTCHEON=:C_SCUTCHEON,");
            strSql.Append("C_GP_TYPE=:C_GP_TYPE,");
            strSql.Append("C_REMARK=:C_REMARK,");
            strSql.Append("C_IS_TB=:C_IS_TB,");
            strSql.Append("C_MASTER_ID=:C_MASTER_ID,");
            strSql.Append("C_GP_BEFORE_ID=:C_GP_BEFORE_ID,");
            strSql.Append("C_GP_AFTER_ID=:C_GP_AFTER_ID,");
            strSql.Append("D_STACK_DATE=:D_STACK_DATE,");
            strSql.Append("C_STACK_USER=:C_STACK_USER,");
            strSql.Append("C_STACK_SHIFT=:C_STACK_SHIFT,");
            strSql.Append("C_STACK_GROUP=:C_STACK_GROUP,");
            strSql.Append("C_IS_PD=:C_IS_PD,");
            strSql.Append("C_REASON_NAME=:C_REASON_NAME,");
            strSql.Append("C_FYDH=:C_FYDH,");
            strSql.Append("C_SLAB_STATUS=:C_SLAB_STATUS,");
            strSql.Append("C_ZKDH=:C_ZKDH,");
            strSql.Append("C_ZKDHID=:C_ZKDHID,");
            strSql.Append("C_LGJH=:C_LGJH,");
            strSql.Append("C_MES_FLOOR=:C_MES_FLOOR,");
            strSql.Append("N_JZ=:N_JZ,");
            strSql.Append("C_HL=:C_HL,");
            strSql.Append("N_HL_TIME=:N_HL_TIME,");
            strSql.Append("C_HLYQ=:C_HLYQ,");
            strSql.Append("C_DFP_HL=:C_DFP_HL,");
            strSql.Append("N_DFP_HL_TIME=:N_DFP_HL_TIME,");
            strSql.Append("C_ROUTE=:C_ROUTE,");
            strSql.Append("C_ZYX1=:C_ZYX1,");
            strSql.Append("C_ZYX2=:C_ZYX2,");
            strSql.Append("C_COMMUTE_REASON=:C_COMMUTE_REASON,");
            strSql.Append("C_DEPOT_TYPE=:C_DEPOT_TYPE,");
            strSql.Append("C_SLAB_TYPE_R=:C_SLAB_TYPE_R");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_PLAN_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_BATCH_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ORD_NO", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_STOVE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STA_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STA_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STA_DESC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STL_GRD", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STL_GRD_PRE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MAT_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MAT_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SPEC", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_LEN", OracleDbType.Decimal,5),
                    new OracleParameter(":N_QUA", OracleDbType.Decimal,5),
                    new OracleParameter(":N_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":C_STD_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SLAB_TYPE", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_CCM_DATE", OracleDbType.Date),
                    new OracleParameter(":C_CCM_SHIFT", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CCM_GROUP", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CCM_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MOVE_TYPE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SC_STATE", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_ESC_DATE", OracleDbType.Date),
                    new OracleParameter(":D_LSC_DATE", OracleDbType.Date),
                    new OracleParameter(":C_QKP_STATE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_KP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CON_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CUS_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CUS_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_WL_DATE", OracleDbType.Date),
                    new OracleParameter(":C_WL_SHIFT", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_WL_GROUP", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_WL_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_WE_DATE", OracleDbType.Date),
                    new OracleParameter(":C_WE_SHIFT", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_WE_GROUP", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_WE_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STOCK_STATE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MAT_TYPE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_QGP_STATE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SLABWH_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SLABWH_AREA_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SLABWH_LOC_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SLABWH_TIER_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_WGT_METER", OracleDbType.Decimal,5),
                    new OracleParameter(":C_QF_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_DESIGN_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ZRBM", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_IS_DEPOT", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ISXM", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_XMGX", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ISFREE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_JUDGE_LEV_CF", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_JUDGE_LEV_XN", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_JUDGE_LEV_ZH", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_JUDGE_LEV_ZH_PEOPLE", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_JUDGE_DATE", OracleDbType.Date),
                    new OracleParameter(":C_IS_QR", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_QR_USER", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_QR_DATE", OracleDbType.Date),
                    new OracleParameter(":D_Q_DATE", OracleDbType.Date),
                    new OracleParameter(":C_SCUTCHEON", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_GP_TYPE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_IS_TB", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_MASTER_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_GP_BEFORE_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_GP_AFTER_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_STACK_DATE", OracleDbType.Date),
                    new OracleParameter(":C_STACK_USER", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STACK_SHIFT", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STACK_GROUP", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_IS_PD", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_REASON_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_FYDH", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SLAB_STATUS", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ZKDH", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ZKDHID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_LGJH", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MES_FLOOR", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_JZ", OracleDbType.Decimal,15),
                    new OracleParameter(":C_HL", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_HL_TIME", OracleDbType.Decimal,15),
                    new OracleParameter(":C_HLYQ", OracleDbType.Varchar2,400),
                    new OracleParameter(":C_DFP_HL", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_DFP_HL_TIME", OracleDbType.Decimal,10),
                    new OracleParameter(":C_ROUTE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ZYX1", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ZYX2", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_COMMUTE_REASON", OracleDbType.Varchar2,200),
                    new OracleParameter(":C_DEPOT_TYPE", OracleDbType.Varchar2,200),
                    new OracleParameter(":C_SLAB_TYPE_R", OracleDbType.Varchar2,50),
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.C_PLAN_ID;
            parameters[1].Value = model.C_BATCH_NO;
            parameters[2].Value = model.C_ORD_NO;
            parameters[3].Value = model.C_STOVE;
            parameters[4].Value = model.C_STA_ID;
            parameters[5].Value = model.C_STA_CODE;
            parameters[6].Value = model.C_STA_DESC;
            parameters[7].Value = model.C_STL_GRD;
            parameters[8].Value = model.C_STL_GRD_PRE;
            parameters[9].Value = model.C_MAT_CODE;
            parameters[10].Value = model.C_MAT_NAME;
            parameters[11].Value = model.C_SPEC;
            parameters[12].Value = model.N_LEN;
            parameters[13].Value = model.N_QUA;
            parameters[14].Value = model.N_WGT;
            parameters[15].Value = model.C_STD_CODE;
            parameters[16].Value = model.C_SLAB_TYPE;
            parameters[17].Value = model.D_CCM_DATE;
            parameters[18].Value = model.C_CCM_SHIFT;
            parameters[19].Value = model.C_CCM_GROUP;
            parameters[20].Value = model.C_CCM_EMP_ID;
            parameters[21].Value = model.C_MOVE_TYPE;
            parameters[22].Value = model.C_SC_STATE;
            parameters[23].Value = model.D_ESC_DATE;
            parameters[24].Value = model.D_LSC_DATE;
            parameters[25].Value = model.C_QKP_STATE;
            parameters[26].Value = model.C_KP_ID;
            parameters[27].Value = model.C_CON_NO;
            parameters[28].Value = model.C_CUS_NO;
            parameters[29].Value = model.C_CUS_NAME;
            parameters[30].Value = model.D_WL_DATE;
            parameters[31].Value = model.C_WL_SHIFT;
            parameters[32].Value = model.C_WL_GROUP;
            parameters[33].Value = model.C_WL_EMP_ID;
            parameters[34].Value = model.D_WE_DATE;
            parameters[35].Value = model.C_WE_SHIFT;
            parameters[36].Value = model.C_WE_GROUP;
            parameters[37].Value = model.C_WE_EMP_ID;
            parameters[38].Value = model.C_STOCK_STATE;
            parameters[39].Value = model.C_MAT_TYPE;
            parameters[40].Value = model.C_QGP_STATE;
            parameters[41].Value = model.C_SLABWH_CODE;
            parameters[42].Value = model.C_SLABWH_AREA_CODE;
            parameters[43].Value = model.C_SLABWH_LOC_CODE;
            parameters[44].Value = model.C_SLABWH_TIER_CODE;
            parameters[45].Value = model.N_WGT_METER;
            parameters[46].Value = model.C_QF_NAME;
            parameters[47].Value = model.C_DESIGN_NO;
            parameters[48].Value = model.C_ZRBM;
            parameters[49].Value = model.C_IS_DEPOT;
            parameters[50].Value = model.C_ISXM;
            parameters[51].Value = model.C_XMGX;
            parameters[52].Value = model.C_ISFREE;
            parameters[53].Value = model.C_JUDGE_LEV_CF;
            parameters[54].Value = model.C_JUDGE_LEV_XN;
            parameters[55].Value = model.C_JUDGE_LEV_ZH;
            parameters[56].Value = model.C_JUDGE_LEV_ZH_PEOPLE;
            parameters[57].Value = model.D_JUDGE_DATE;
            parameters[58].Value = model.C_IS_QR;
            parameters[59].Value = model.C_QR_USER;
            parameters[60].Value = model.D_QR_DATE;
            parameters[61].Value = model.D_Q_DATE;
            parameters[62].Value = model.C_SCUTCHEON;
            parameters[63].Value = model.C_GP_TYPE;
            parameters[64].Value = model.C_REMARK;
            parameters[65].Value = model.C_IS_TB;
            parameters[66].Value = model.C_MASTER_ID;
            parameters[67].Value = model.C_GP_BEFORE_ID;
            parameters[68].Value = model.C_GP_AFTER_ID;
            parameters[69].Value = model.D_STACK_DATE;
            parameters[70].Value = model.C_STACK_USER;
            parameters[71].Value = model.C_STACK_SHIFT;
            parameters[72].Value = model.C_STACK_GROUP;
            parameters[73].Value = model.C_IS_PD;
            parameters[74].Value = model.C_REASON_NAME;
            parameters[75].Value = model.C_FYDH;
            parameters[76].Value = model.C_SLAB_STATUS;
            parameters[77].Value = model.C_ZKDH;
            parameters[78].Value = model.C_ZKDHID;
            parameters[79].Value = model.C_LGJH;
            parameters[80].Value = model.C_MES_FLOOR;
            parameters[81].Value = model.N_JZ;
            parameters[82].Value = model.C_HL;
            parameters[83].Value = model.N_HL_TIME;
            parameters[84].Value = model.C_HLYQ;
            parameters[85].Value = model.C_DFP_HL;
            parameters[86].Value = model.N_DFP_HL_TIME;
            parameters[87].Value = model.C_ROUTE;
            parameters[88].Value = model.C_ZYX1;
            parameters[89].Value = model.C_ZYX2;
            parameters[90].Value = model.C_COMMUTE_REASON;
            parameters[91].Value = model.C_DEPOT_TYPE;
            parameters[92].Value = model.C_SLAB_TYPE_R;
            parameters[93].Value = model.C_ID;

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
        /// 更新一条数据_炉号
        /// </summary>
        public bool Update_Stove_Trans(string stove)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TSC_SLAB_MAIN set ");
            strSql.Append("C_IS_TB ='N' ");
            strSql.Append("where C_STOVE='" + stove + "'");

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
        public bool Update_Stove(string C_SCUTCHEON, string stove)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TSC_SLAB_MAIN set ");
            strSql.Append("C_SCUTCHEON ='" + C_SCUTCHEON + "', ");
            strSql.Append("C_GP_TYPE ='修改标牌' ");
            strSql.Append(" where C_STOVE='" + stove + "'");

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
        /// 删除一条数据
        /// </summary>
        public bool Delete(string C_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from TSC_SLAB_MAIN ");
            strSql.Append(" where C_ID=:C_ID    ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)          };
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
            strSql.Append("delete from TSC_SLAB_MAIN ");
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
        public Mod_TSC_SLAB_MAIN GetModel(string C_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from TSC_SLAB_MAIN ");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)            };
            parameters[0].Value = C_ID;

            Mod_TSC_SLAB_MAIN model = new Mod_TSC_SLAB_MAIN();
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
        public Mod_TSC_SLAB_MAIN GetModel_Trans(string C_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from TSC_SLAB_MAIN ");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)            };
            parameters[0].Value = C_ID;

            Mod_TSC_SLAB_MAIN model = new Mod_TSC_SLAB_MAIN();
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
        /// 获取可轧钢坯库存
        /// </summary>
        /// <param name="C_STOVE">炉号</param>
        /// <param name="C_BATCH_NO">批号</param>
        /// <param name="C_STL_GRD">钢种</param>
        /// <param name="C_STD_CODE">执行标准</param>
        /// <returns></returns>
        public DataTable GetKZgp(string C_STOVE, string C_BATCH_NO, string C_STL_GRD, string C_STD_CODE)
        {
            string sql = @"SELECT T.C_STOVE,
       T.C_BATCH_NO,
       T.C_STL_GRD,
       T.C_STD_CODE,
       T.C_SPEC,
       T.N_LEN,
       T.N_WGT,
       T.N_QUA,
       C_ISXM,
       T.C_MOVE_TYPE,
       T.D_WE_DATE_MIN,
       (SELECT A.C_SLABWH_NAME
          FROM TPB_SLABWH A
         WHERE A.C_SLABWH_CODE = T.C_SLABWH_CODE
           AND A.N_STATUS = 1) C_SLABWH_NAME,
       (SELECT B.C_SLABWH_LOC_NAME
          FROM TPB_SLABWH_LOC B
         WHERE B.C_SLABWH_LOC_CODE = T.C_SLABWH_LOC_CODE
           AND B.N_STATUS = 1) C_SLABWH_LOC_NAME
  FROM V_SLAB_KC T
  LEFT JOIN TPB_SLABWH_LOC H
    ON T.C_SLABWH_LOC_CODE = H.C_SLABWH_LOC_CODE
 WHERE T.C_MOVE_TYPE IN('在库', '调拨中')";
            if (C_STOVE.Trim() != "")
            {
                sql = sql + @" AND T.C_STOVE='" + C_STOVE + "'";
            }
            if (C_BATCH_NO.Trim() != "")
            {
                sql = sql + @" AND T.C_BATCH_NO='" + C_BATCH_NO + "'";
            }
            if (C_STL_GRD.Trim() != "")
            {
                sql = sql + @" AND UPPER(T.C_STL_GRD)='" + C_STL_GRD + "'";
            }
            if (C_STD_CODE.Trim() != "")
            {
                sql = sql + @" AND T.C_STD_CODE='" + C_STD_CODE + "'";
            }

            sql = sql + @"  AND NVL(C_ISXM, '已修磨') = '已修磨'
   AND T.C_SPEC <> '280*325'
   AND T.C_MAT_TYPE = '合格品'
   AND((CASE
         WHEN H.C_SLABWH_TYPE = '缓冷坑' AND T.C_MOVE_TYPE = 'E' THEN
          (SELECT MAX(A.D_ESC_DATE + A.N_HL_TIME / 24)
             FROM TSC_SLAB_MAIN A
            WHERE A.C_SLABWH_LOC_CODE = T.C_SLABWH_LOC_CODE
              AND A.C_MOVE_TYPE = 'E'
              AND(C_ISXM = 'N' OR C_XMGX IS NULL)
              AND T.C_SPEC <> '280*325')
         WHEN T.C_MOVE_TYPE = 'M' AND T.N_HL_TIME IS NOT NULL THEN
          T.D_WE_DATE_MIN + T.N_HL_TIME / 24
         ELSE
          SYSDATE
       END) <= SYSDATE) AND t.C_SLABWH_CODE IS NOT NULL";
            return DbHelperOra.Query(sql).Tables[0];
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Mod_TSC_SLAB_MAIN GetModel_Interface_Trans(string C_STOVE)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from TSC_SLAB_MAIN ");
            strSql.Append(" where C_STOVE=:C_STOVE and C_BATCH_NO IS NULL AND c_move_type in ('TP','E','N','DX') ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_STOVE", OracleDbType.Varchar2,100)            };
            parameters[0].Value = C_STOVE;

            Mod_TSC_SLAB_MAIN model = new Mod_TSC_SLAB_MAIN();
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
        public Mod_TSC_SLAB_MAIN GetModel_Interface_Batch_Trans(string C_BATCH_NO)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from TSC_SLAB_MAIN ");
            strSql.Append(" where C_BATCH_NO=:C_BATCH_NO  AND c_move_type in ('E','N','DX','TP') ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_BATCH_NO", OracleDbType.Varchar2,100)            };
            parameters[0].Value = C_BATCH_NO;

            Mod_TSC_SLAB_MAIN model = new Mod_TSC_SLAB_MAIN();
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
        /// <param name="C_STOVE">炉号</param>
        /// <returns></returns>
        public Mod_TSC_SLAB_MAIN GetModel_Stove_Trans(string C_STOVE)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from TSC_SLAB_MAIN ");
            strSql.Append(" where C_STOVE=:C_STOVE ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_STOVE", OracleDbType.Varchar2,100)            };
            parameters[0].Value = C_STOVE;

            Mod_TSC_SLAB_MAIN model = new Mod_TSC_SLAB_MAIN();
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
        public Mod_TSC_SLAB_MAIN DataRowToModel(DataRow row)
        {
            Mod_TSC_SLAB_MAIN model = new Mod_TSC_SLAB_MAIN();
            if (row != null)
            {
                if (row["C_ID"] != null)
                {
                    model.C_ID = row["C_ID"].ToString();
                }
                if (row["C_PLAN_ID"] != null)
                {
                    model.C_PLAN_ID = row["C_PLAN_ID"].ToString();
                }
                if (row["C_BATCH_NO"] != null)
                {
                    model.C_BATCH_NO = row["C_BATCH_NO"].ToString();
                }
                if (row["C_ORD_NO"] != null)
                {
                    model.C_ORD_NO = row["C_ORD_NO"].ToString();
                }
                if (row["C_STOVE"] != null)
                {
                    model.C_STOVE = row["C_STOVE"].ToString();
                }
                if (row["C_STA_ID"] != null)
                {
                    model.C_STA_ID = row["C_STA_ID"].ToString();
                }
                if (row["C_STA_CODE"] != null)
                {
                    model.C_STA_CODE = row["C_STA_CODE"].ToString();
                }
                if (row["C_STA_DESC"] != null)
                {
                    model.C_STA_DESC = row["C_STA_DESC"].ToString();
                }
                if (row["C_STL_GRD"] != null)
                {
                    model.C_STL_GRD = row["C_STL_GRD"].ToString();
                }
                if (row["C_STL_GRD_PRE"] != null)
                {
                    model.C_STL_GRD_PRE = row["C_STL_GRD_PRE"].ToString();
                }
                if (row["C_MAT_CODE"] != null)
                {
                    model.C_MAT_CODE = row["C_MAT_CODE"].ToString();
                }
                if (row["C_MAT_NAME"] != null)
                {
                    model.C_MAT_NAME = row["C_MAT_NAME"].ToString();
                }
                if (row["C_SPEC"] != null)
                {
                    model.C_SPEC = row["C_SPEC"].ToString();
                }
                if (row["N_LEN"] != null && row["N_LEN"].ToString() != "")
                {
                    model.N_LEN = decimal.Parse(row["N_LEN"].ToString());
                }
                if (row["N_QUA"] != null && row["N_QUA"].ToString() != "")
                {
                    model.N_QUA = decimal.Parse(row["N_QUA"].ToString());
                }
                if (row["N_WGT"] != null && row["N_WGT"].ToString() != "")
                {
                    model.N_WGT = decimal.Parse(row["N_WGT"].ToString());
                }
                if (row["C_STD_CODE"] != null)
                {
                    model.C_STD_CODE = row["C_STD_CODE"].ToString();
                }
                if (row["C_SLAB_TYPE"] != null)
                {
                    model.C_SLAB_TYPE = row["C_SLAB_TYPE"].ToString();
                }
                if (row["D_CCM_DATE"] != null && row["D_CCM_DATE"].ToString() != "")
                {
                    model.D_CCM_DATE = DateTime.Parse(row["D_CCM_DATE"].ToString());
                }
                if (row["C_CCM_SHIFT"] != null)
                {
                    model.C_CCM_SHIFT = row["C_CCM_SHIFT"].ToString();
                }
                if (row["C_CCM_GROUP"] != null)
                {
                    model.C_CCM_GROUP = row["C_CCM_GROUP"].ToString();
                }
                if (row["C_CCM_EMP_ID"] != null)
                {
                    model.C_CCM_EMP_ID = row["C_CCM_EMP_ID"].ToString();
                }
                if (row["C_MOVE_TYPE"] != null)
                {
                    model.C_MOVE_TYPE = row["C_MOVE_TYPE"].ToString();
                }
                if (row["C_SC_STATE"] != null)
                {
                    model.C_SC_STATE = row["C_SC_STATE"].ToString();
                }
                if (row["D_ESC_DATE"] != null && row["D_ESC_DATE"].ToString() != "")
                {
                    model.D_ESC_DATE = DateTime.Parse(row["D_ESC_DATE"].ToString());
                }
                if (row["D_LSC_DATE"] != null && row["D_LSC_DATE"].ToString() != "")
                {
                    model.D_LSC_DATE = DateTime.Parse(row["D_LSC_DATE"].ToString());
                }
                if (row["C_QKP_STATE"] != null)
                {
                    model.C_QKP_STATE = row["C_QKP_STATE"].ToString();
                }
                if (row["C_KP_ID"] != null)
                {
                    model.C_KP_ID = row["C_KP_ID"].ToString();
                }
                if (row["C_CON_NO"] != null)
                {
                    model.C_CON_NO = row["C_CON_NO"].ToString();
                }
                if (row["C_CUS_NO"] != null)
                {
                    model.C_CUS_NO = row["C_CUS_NO"].ToString();
                }
                if (row["C_CUS_NAME"] != null)
                {
                    model.C_CUS_NAME = row["C_CUS_NAME"].ToString();
                }
                if (row["D_WL_DATE"] != null && row["D_WL_DATE"].ToString() != "")
                {
                    model.D_WL_DATE = DateTime.Parse(row["D_WL_DATE"].ToString());
                }
                if (row["C_WL_SHIFT"] != null)
                {
                    model.C_WL_SHIFT = row["C_WL_SHIFT"].ToString();
                }
                if (row["C_WL_GROUP"] != null)
                {
                    model.C_WL_GROUP = row["C_WL_GROUP"].ToString();
                }
                if (row["C_WL_EMP_ID"] != null)
                {
                    model.C_WL_EMP_ID = row["C_WL_EMP_ID"].ToString();
                }
                if (row["D_WE_DATE"] != null && row["D_WE_DATE"].ToString() != "")
                {
                    model.D_WE_DATE = DateTime.Parse(row["D_WE_DATE"].ToString());
                }
                if (row["C_WE_SHIFT"] != null)
                {
                    model.C_WE_SHIFT = row["C_WE_SHIFT"].ToString();
                }
                if (row["C_WE_GROUP"] != null)
                {
                    model.C_WE_GROUP = row["C_WE_GROUP"].ToString();
                }
                if (row["C_WE_EMP_ID"] != null)
                {
                    model.C_WE_EMP_ID = row["C_WE_EMP_ID"].ToString();
                }
                if (row["C_STOCK_STATE"] != null)
                {
                    model.C_STOCK_STATE = row["C_STOCK_STATE"].ToString();
                }
                if (row["C_MAT_TYPE"] != null)
                {
                    model.C_MAT_TYPE = row["C_MAT_TYPE"].ToString();
                }
                if (row["C_QGP_STATE"] != null)
                {
                    model.C_QGP_STATE = row["C_QGP_STATE"].ToString();
                }
                if (row["C_SLABWH_CODE"] != null)
                {
                    model.C_SLABWH_CODE = row["C_SLABWH_CODE"].ToString();
                }
                if (row["C_SLABWH_AREA_CODE"] != null)
                {
                    model.C_SLABWH_AREA_CODE = row["C_SLABWH_AREA_CODE"].ToString();
                }
                if (row["C_SLABWH_LOC_CODE"] != null)
                {
                    model.C_SLABWH_LOC_CODE = row["C_SLABWH_LOC_CODE"].ToString();
                }
                if (row["C_SLABWH_TIER_CODE"] != null)
                {
                    model.C_SLABWH_TIER_CODE = row["C_SLABWH_TIER_CODE"].ToString();
                }
                if (row["N_WGT_METER"] != null && row["N_WGT_METER"].ToString() != "")
                {
                    model.N_WGT_METER = decimal.Parse(row["N_WGT_METER"].ToString());
                }
                if (row["C_QF_NAME"] != null)
                {
                    model.C_QF_NAME = row["C_QF_NAME"].ToString();
                }
                if (row["C_DESIGN_NO"] != null)
                {
                    model.C_DESIGN_NO = row["C_DESIGN_NO"].ToString();
                }
                if (row["C_ZRBM"] != null)
                {
                    model.C_ZRBM = row["C_ZRBM"].ToString();
                }
                if (row["C_IS_DEPOT"] != null)
                {
                    model.C_IS_DEPOT = row["C_IS_DEPOT"].ToString();
                }
                if (row["C_ISXM"] != null)
                {
                    model.C_ISXM = row["C_ISXM"].ToString();
                }
                if (row["C_XMGX"] != null)
                {
                    model.C_XMGX = row["C_XMGX"].ToString();
                }
                if (row["C_ISFREE"] != null)
                {
                    model.C_ISFREE = row["C_ISFREE"].ToString();
                }
                if (row["C_JUDGE_LEV_CF"] != null)
                {
                    model.C_JUDGE_LEV_CF = row["C_JUDGE_LEV_CF"].ToString();
                }
                if (row["C_JUDGE_LEV_XN"] != null)
                {
                    model.C_JUDGE_LEV_XN = row["C_JUDGE_LEV_XN"].ToString();
                }
                if (row["C_JUDGE_LEV_ZH"] != null)
                {
                    model.C_JUDGE_LEV_ZH = row["C_JUDGE_LEV_ZH"].ToString();
                }
                if (row["C_JUDGE_LEV_ZH_PEOPLE"] != null)
                {
                    model.C_JUDGE_LEV_ZH_PEOPLE = row["C_JUDGE_LEV_ZH_PEOPLE"].ToString();
                }
                if (row["D_JUDGE_DATE"] != null && row["D_JUDGE_DATE"].ToString() != "")
                {
                    model.D_JUDGE_DATE = DateTime.Parse(row["D_JUDGE_DATE"].ToString());
                }
                if (row["C_IS_QR"] != null)
                {
                    model.C_IS_QR = row["C_IS_QR"].ToString();
                }
                if (row["C_QR_USER"] != null)
                {
                    model.C_QR_USER = row["C_QR_USER"].ToString();
                }
                if (row["D_QR_DATE"] != null && row["D_QR_DATE"].ToString() != "")
                {
                    model.D_QR_DATE = DateTime.Parse(row["D_QR_DATE"].ToString());
                }
                if (row["D_Q_DATE"] != null && row["D_Q_DATE"].ToString() != "")
                {
                    model.D_Q_DATE = DateTime.Parse(row["D_Q_DATE"].ToString());
                }
                if (row["C_SCUTCHEON"] != null)
                {
                    model.C_SCUTCHEON = row["C_SCUTCHEON"].ToString();
                }
                if (row["C_GP_TYPE"] != null)
                {
                    model.C_GP_TYPE = row["C_GP_TYPE"].ToString();
                }
                if (row["C_REMARK"] != null)
                {
                    model.C_REMARK = row["C_REMARK"].ToString();
                }
                if (row["C_IS_TB"] != null)
                {
                    model.C_IS_TB = row["C_IS_TB"].ToString();
                }
                if (row["C_MASTER_ID"] != null)
                {
                    model.C_MASTER_ID = row["C_MASTER_ID"].ToString();
                }
                if (row["C_GP_BEFORE_ID"] != null)
                {
                    model.C_GP_BEFORE_ID = row["C_GP_BEFORE_ID"].ToString();
                }
                if (row["C_GP_AFTER_ID"] != null)
                {
                    model.C_GP_AFTER_ID = row["C_GP_AFTER_ID"].ToString();
                }
                if (row["D_STACK_DATE"] != null && row["D_STACK_DATE"].ToString() != "")
                {
                    model.D_STACK_DATE = DateTime.Parse(row["D_STACK_DATE"].ToString());
                }
                if (row["C_STACK_USER"] != null)
                {
                    model.C_STACK_USER = row["C_STACK_USER"].ToString();
                }
                if (row["C_STACK_SHIFT"] != null)
                {
                    model.C_STACK_SHIFT = row["C_STACK_SHIFT"].ToString();
                }
                if (row["C_STACK_GROUP"] != null)
                {
                    model.C_STACK_GROUP = row["C_STACK_GROUP"].ToString();
                }
                if (row["C_IS_PD"] != null)
                {
                    model.C_IS_PD = row["C_IS_PD"].ToString();
                }
                if (row["C_REASON_NAME"] != null)
                {
                    model.C_REASON_NAME = row["C_REASON_NAME"].ToString();
                }
                if (row["C_FYDH"] != null)
                {
                    model.C_FYDH = row["C_FYDH"].ToString();
                }
                if (row["C_SLAB_STATUS"] != null)
                {
                    model.C_SLAB_STATUS = row["C_SLAB_STATUS"].ToString();
                }
                if (row["C_ZKDH"] != null)
                {
                    model.C_ZKDH = row["C_ZKDH"].ToString();
                }
                if (row["C_ZKDHID"] != null)
                {
                    model.C_ZKDHID = row["C_ZKDHID"].ToString();
                }
                if (row["C_LGJH"] != null)
                {
                    model.C_LGJH = row["C_LGJH"].ToString();
                }
                if (row["C_MES_FLOOR"] != null)
                {
                    model.C_MES_FLOOR = row["C_MES_FLOOR"].ToString();
                }
                if (row["N_JZ"] != null && row["N_JZ"].ToString() != "")
                {
                    model.N_JZ = decimal.Parse(row["N_JZ"].ToString());
                }
                if (row["C_HL"] != null)
                {
                    model.C_HL = row["C_HL"].ToString();
                }
                if (row["N_HL_TIME"] != null && row["N_HL_TIME"].ToString() != "")
                {
                    model.N_HL_TIME = decimal.Parse(row["N_HL_TIME"].ToString());
                }
                if (row["C_HLYQ"] != null)
                {
                    model.C_HLYQ = row["C_HLYQ"].ToString();
                }
                if (row["C_DFP_HL"] != null)
                {
                    model.C_DFP_HL = row["C_DFP_HL"].ToString();
                }
                if (row["N_DFP_HL_TIME"] != null && row["N_DFP_HL_TIME"].ToString() != "")
                {
                    model.N_DFP_HL_TIME = decimal.Parse(row["N_DFP_HL_TIME"].ToString());
                }
                if (row["C_ROUTE"] != null)
                {
                    model.C_ROUTE = row["C_ROUTE"].ToString();
                }
                if (row["C_ZYX1"] != null)
                {
                    model.C_ZYX1 = row["C_ZYX1"].ToString();
                }
                if (row["C_ZYX2"] != null)
                {
                    model.C_ZYX2 = row["C_ZYX2"].ToString();
                }
                if (row["C_COMMUTE_REASON"] != null)
                {
                    model.C_COMMUTE_REASON = row["C_COMMUTE_REASON"].ToString();
                }
                if (row["C_DEPOT_TYPE"] != null)
                {
                    model.C_DEPOT_TYPE = row["C_DEPOT_TYPE"].ToString();
                }
                if (row["C_SLAB_TYPE_R"] != null)
                {
                    model.C_SLAB_TYPE_R = row["C_SLAB_TYPE_R"].ToString();
                }

            }
            return model;
        }



        /// <summary>
        /// 获得数据列表-入库时间
        /// </summary>
        /// <param name="begin">开始时间</param>
        /// <param name="end">结束时间</param>
        /// <param name="STA">铸机号</param>
        /// <param name="Stove">炉号</param>
        /// <returns></returns>
        public DataSet GetList_Query(DateTime begin, DateTime end, string STA, string Stove)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select t.c_sta_desc ,t.c_stove , t.c_stl_grd ,t.c_spec ,t.n_len ,t.n_qua ,t.c_std_code ,t.c_mat_code ,t.c_mat_name  ,count(1) COU ,sum(n_wgt) WGT,max(D_CCM_DATE) DTE ");
            strSql.Append(" FROM TSC_SLAB_MAIN t where t.c_move_type='E' and t.c_stock_state='W' ");
            if (begin != null && end != null)
            {
                strSql.Append(" and D_CCM_DATE between to_date('" + Convert.ToDateTime(begin) + "','yyyy-mm-dd hh24:mi:ss') and to_date('" + Convert.ToDateTime(end) + "','yyyy-mm-dd hh24:mi:ss') ");
            }
            if (STA != "全部")
            {
                strSql.Append(" and c_sta_id ='" + STA + "' ");
            }
            if (!string.IsNullOrEmpty(Stove))
            {
                strSql.Append(" and c_stove ='" + Stove + "' ");
            }
            strSql.Append(" group by t.c_sta_desc ,t.c_stove , t.c_stl_grd ,t.c_spec ,t.n_len ,t.n_qua ,t.c_std_code ,t.c_mat_code ,t.c_mat_name  ");
            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得数据列表-支数
        /// </summary> 
        /// <returns></returns>
        public DataSet GetList_count(string c_sta_id, string c_stove, string c_stl_grd, string c_spec, string n_len, string c_std_code, string c_mat_code, string c_mat_name, int cou)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  t.c_id,t.c_sta_id  ");
            strSql.Append(" FROM TSC_SLAB_MAIN t WHERE 1=1   ");
            if (!string.IsNullOrEmpty(c_sta_id.Trim()))
            {
                strSql.Append(" and t.c_sta_id = '" + c_sta_id + "' ");
            }
            if (!string.IsNullOrEmpty(c_stove.Trim()))
            {
                strSql.Append(" and t.c_stove = '" + c_stove + "' ");
            }
            if (!string.IsNullOrEmpty(c_stl_grd.Trim()))
            {
                strSql.Append(" and t.c_stl_grd = '" + c_stl_grd + "' ");
            }
            if (!string.IsNullOrEmpty(c_spec.Trim()))
            {
                strSql.Append(" and t.c_spec = '" + c_spec + "' ");
            }
            if (!string.IsNullOrEmpty(n_len.Trim()))
            {
                strSql.Append(" and t.n_len = '" + n_len + "' ");
            }

            if (!string.IsNullOrEmpty(c_std_code.Trim()))
            {
                strSql.Append(" and t.c_std_code = '" + c_std_code + "' ");
            }
            if (!string.IsNullOrEmpty(c_mat_code.Trim()))
            {
                strSql.Append(" and t.c_mat_code = '" + c_mat_code + "' ");
            }
            if (!string.IsNullOrEmpty(c_mat_name.Trim()))
            {
                strSql.Append(" and t.c_mat_name = '" + c_mat_name + "' ");
            }
            if (cou != 0)
            {
                strSql.Append(" and rownum <= " + cou + "  ");
            }
            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 根据炉号 查询
        /// </summary>
        /// <param name="stove"></param>
        /// <returns></returns>
        public DataSet GetList_stove(string stove)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select *  ");
            strSql.Append(" FROM TSC_SLAB_MAIN  ");
            if (!string.IsNullOrEmpty(stove))
            {
                strSql.Append(" where C_STOVE ='" + stove + "' ");
            }

            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 根据库位 查询
        /// </summary>
        /// <param name="c_slabwh_loc_code"></param>
        /// <returns></returns>
        public DataSet GetList_LocNum(string c_slabwh_loc_code)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count( distinct t.c_stove) as cou   ");
            strSql.Append(" FROM TSC_SLAB_MAIN t where t.c_move_type='E' ");
            if (!string.IsNullOrEmpty(c_slabwh_loc_code))
            {
                strSql.Append(" and t.c_slabwh_loc_code ='" + c_slabwh_loc_code + "' ");
            }

            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        ///  获得数据列表-库检
        /// </summary>
        /// <param name="begin">开始时间</param>
        /// <param name="end">结束时间</param>
        /// <param name="stl">钢种</param>
        /// <param name="spec">断面</param>
        /// <param name="stove">炉号</param>
        /// <returns></returns>
        public DataSet GetList_Stove(string begin, string end, string stl, string spec, string stove)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select t.C_ID,t.C_PLAN_ID,t.C_ORD_NO,t.C_STOVE,b.c_sta_desc,t.C_STA_CODE,t.C_STA_DESC,t.C_STL_GRD,t.C_STL_GRD_PRE,t.C_MAT_CODE,t.C_MAT_NAME,t.C_SPEC,t.N_LEN,t.N_QUA,t.N_WGT,t.C_STD_CODE,t.C_SLAB_TYPE,t.D_CCM_DATE,t.C_CCM_SHIFT,t.C_CCM_GROUP,t.C_CCM_EMP_ID,t.C_MOVE_TYPE,t.C_SC_STATE,t.D_ESC_DATE,t.D_LSC_DATE,t.C_QKP_STATE,t.C_KP_ID,t.C_CON_NO,t.C_CUS_NO,t.C_CUS_NAME,t.D_WL_DATE,t.C_WL_SHIFT,t.C_WL_GROUP,t.C_WL_EMP_ID,t.D_WE_DATE,t.C_WE_SHIFT,t.C_WE_GROUP,t.C_WE_EMP_ID,t.C_STOCK_STATE,t.C_MAT_TYPE,t.C_QGP_STATE,t.C_SLABWH_CODE,t.C_SLABWH_AREA_CODE,t.C_SLABWH_LOC_CODE,t.C_SLABWH_TIER_CODE,t.N_WGT_METER,t.C_QF_NAME,t.C_DESIGN_NO,t.C_ZRBM,t.C_IS_DEPOT,t.C_ISXM,t.C_XMGX,t.C_ISFREE,t.C_JUDGE_LEV_CF,t.C_JUDGE_LEV_XN,t.C_JUDGE_LEV_ZH,t.C_JUDGE_LEV_ZH_PEOPLE,t.D_JUDGE_DATE,t.C_IS_QR,t.C_QR_USER,t.D_QR_DATE ");
            strSql.Append(" FROM TSC_SLAB_MAIN t  inner  join tb_sta b on t.c_sta_id=b.c_id where t.C_MOVE_TYPE ='E' ");
            if (begin != null && end != null)
            {
                strSql.Append(" and D_CCM_DATE between to_date('" + Convert.ToDateTime(begin) + "','yyyy-mm-dd hh24:mi:ss') and to_date('" + Convert.ToDateTime(end) + "','yyyy-mm-dd hh24:mi:ss') ");
            }
            if (stl.Trim() != "")
            {
                strSql.Append(" and  t.C_STL_GRD like '" + stl + "%' ");
            }
            if (spec.Trim() != "")
            {
                strSql.Append(" and  t.C_SPEC like '" + spec + "%' ");
            }
            if (stove.Trim() != "")
            {
                strSql.Append(" and  t.C_STOVE like '" + stove + "%' ");
            }
            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得数据列表-炉号
        /// </summary>
        /// <param name="stove">炉号</param>
        /// <param name="begin">开始时间</param>
        /// <param name="end">结束时间</param>
        /// <returns></returns>
        //public DataSet GetList_Stove1(DateTime begin, DateTime end, string stove)
        //{
        //    StringBuilder strSql = new StringBuilder();
        //    strSql.Append("select b.c_sta_desc ,t.c_stove ,t.C_BATCH_NO, t.c_stl_grd ,t.c_spec,max(t.n_len)N_LEN,t.c_std_code ,t.c_mat_code ,t.c_mat_name  ,count(1) COU ,sum(n_wgt) WGT,max(D_CCM_DATE) DT,t.C_SCUTCHEON,t.C_LGJH,t.C_ORD_NO,t.C_MAT_TYPE ,t.C_ZYX1,t.C_ZYX2,t.C_JUDGE_LEV_ZH,t.c_move_type ");
        //    strSql.Append(" FROM TSC_SLAB_MAIN t left join tb_sta b on t.c_sta_id=b.c_id where t.c_move_type in ('E','N','DX') ");
        //    if (begin != null && end != null)
        //    {
        //        strSql.Append(" and T.D_CCM_DATE between to_date('" + Convert.ToDateTime(begin) + "','yyyy-mm-dd hh24:mi:ss') and to_date('" + Convert.ToDateTime(end) + "','yyyy-mm-dd hh24:mi:ss') ");
        //    }
        //    if (stove.Trim() != "")
        //    {
        //        strSql.Append(" and (t.C_STOVE = '" + stove + "' or t.C_BATCH_NO = '" + stove + "') ");
        //    }
        //    strSql.Append(" group by b.c_sta_desc,t.c_sta_id ,t.c_stove ,t.C_BATCH_NO, t.c_stl_grd ,t.c_spec ,t.c_std_code ,t.c_mat_code ,t.c_mat_name,t.C_SCUTCHEON,t.C_LGJH,t.C_ORD_NO ,t.C_MAT_TYPE,t.C_ZYX1,t.C_ZYX2,t.C_JUDGE_LEV_ZH,t.c_move_type  ");
        //    strSql.Append(" order by T.C_STOVE ");
        //    return DbHelperOra.Query(strSql.ToString());
        //}
        /// <summary>
        /// 获得数据列表-炉号
        /// </summary>
        /// <param name="stove">炉号</param>
        /// <param name="begin">开始时间</param>
        /// <param name="end">结束时间</param>
        /// <returns></returns>
        public DataSet GetList_Stove1(DateTime begin, DateTime end, string stove)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select t1.c_id as SLABID,t1.c_slabwh_name,t.C_SLABWH_CODE,T.C_ID,b.c_sta_desc ,t.c_stove ,t.C_BATCH_NO,t.c_stl_grd ,t.c_spec,t.n_len,t.c_std_code ,t.c_mat_code ,t.c_mat_name  ,t.n_wgt,t.D_CCM_DATE,t.C_SCUTCHEON,t.C_LGJH,t.C_ORD_NO, Decode(T.C_MOVE_TYPE,'S','已销售','N','待入库','DZ','待轧','NP','待开坯','R','入炉','C','出炉','EX','消耗','M','调拨中','E','入库','DX','待修磨','0','销售占用','1','销售实绩')C_MOVE_TYPE, t.C_ZYX1,t.C_ZYX2,t.C_JUDGE_LEV_ZH,t.c_move_type FROM TSC_SLAB_MAIN t left join tb_sta b on t.c_sta_id=b.c_id left join tpb_slabwh t1 on  t.c_slabwh_code=t1.c_slabwh_code  where t.c_move_type in ('E','DX')  ");
            if (begin != null && end != null)
            {
                strSql.Append(" and T.D_CCM_DATE between to_date('" + Convert.ToDateTime(begin) + "','yyyy-mm-dd hh24:mi:ss') and to_date('" + Convert.ToDateTime(end) + "','yyyy-mm-dd hh24:mi:ss') ");
            }
            if (stove.Trim() != "")
            {
                strSql.Append(" and (t.C_STOVE = '" + stove + "' or t.C_BATCH_NO = '" + stove + "') ");
            }
            strSql.Append(" order by T.C_STOVE ");
            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得数据列表-炉号
        /// </summary>
        /// <param name="stove">炉号</param> 
        /// <returns></returns>
        public DataSet GetList_StoveYCGP(string stove)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT B.C_STA_DESC,  T.C_STOVE, T.C_STL_GRD, T.C_SPEC,  T.N_LEN,  T.C_STD_CODE, T.C_MAT_CODE, T.C_MAT_NAME,  MAX(T.N_WGT) N_WGT, MAX(T.D_CCM_DATE) D_CCM_DATE ,  COUNT(1)COU,  DECODE(T.C_MOVE_TYPE,  'S', '已销售', 'N',  '待入库', 'DZ', '待轧', 'NP', '待开坯', 'R', '入炉', 'C', '出炉', 'EX',  '消耗', 'M', '调拨中', 'E', '入库', 'DX', '待修磨', '0',  '销售占用',  '1', '销售实绩') C_MOVE_TYPE, T.C_ZYX1, T.C_ZYX2  FROM TSC_SLAB_MAIN T  LEFT JOIN TB_STA B ON T.C_STA_ID = B.C_ID  WHERE T.C_MOVE_TYPE IN ('N', 'E', 'M', 'DX') AND T.C_BATCH_NO IS NULL  ");

            if (stove.Trim() != "")
            {
                strSql.Append(" and  t.C_STOVE = '" + stove + "'  ");
            }
            strSql.Append(" GROUP BY B.C_STA_DESC,T.C_STOVE,T.C_BATCH_NO,T.C_STL_GRD,T.C_SPEC, T.N_LEN, T.C_STD_CODE,T.C_MAT_CODE,T.C_MAT_NAME ,C_MOVE_TYPE, T.C_ZYX1, T.C_ZYX2 ");
            strSql.Append(" order by T.C_STOVE ");
            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得数据列表-炉号
        /// </summary>
        /// <param name="stove">炉号</param>
        /// <param name="begin">开始时间</param>
        /// <param name="end">结束时间</param>
        /// <returns></returns>
        public DataSet GetList_StoveBetween(DateTime begin, DateTime end, string stove, string stoveEnd)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select t1.c_id as SLABID,t1.c_slabwh_name,t.C_SLABWH_CODE,T.C_ID,b.c_sta_desc ,t.c_stove ,t.C_BATCH_NO,t.c_stl_grd ,t.c_spec,t.n_len,t.c_std_code ,t.c_mat_code ,t.c_mat_name  ,t.n_wgt,t.D_CCM_DATE,t.C_SCUTCHEON,t.C_LGJH,t.C_ORD_NO, Decode(T.C_MOVE_TYPE,'S','已销售','N','待入库','DZ','待轧','NP','待开坯','R','入炉','C','出炉','EX','消耗','M','调拨中','E','入库','DX','待修磨','0','销售占用','1','销售实绩')C_MOVE_TYPE, t.C_ZYX1,t.C_ZYX2,t.C_JUDGE_LEV_ZH,t.c_move_type FROM TSC_SLAB_MAIN t left join tb_sta b on t.c_sta_id=b.c_id left join tpb_slabwh t1 on  t.c_slabwh_code=t1.c_slabwh_code  where t.c_move_type in ('E','DX')  ");
            if (begin != null && end != null)
            {
                strSql.Append(" and T.D_CCM_DATE between to_date('" + Convert.ToDateTime(begin) + "','yyyy-mm-dd hh24:mi:ss') and to_date('" + Convert.ToDateTime(end) + "','yyyy-mm-dd hh24:mi:ss') ");
            }
            if (stove.Trim() != "")
            {
                if (stove.Substring(0, 1) == "2")
                {
                    strSql.Append(" and t.C_STOVE >= '" + stove + "' ");
                }
                if (stove.Substring(0, 1) == "4")
                {
                    strSql.Append(" and  t.C_BATCH_NO >= '" + stove + "'  ");
                }
            }
            if (stoveEnd.Trim() != "")
            {
                if (stove.Substring(0, 1) == "2")
                {
                    strSql.Append(" and t.C_STOVE <= '" + stoveEnd + "' ");
                }
                if (stove.Substring(0, 1) == "4")
                {
                    strSql.Append(" and  t.C_BATCH_NO <= '" + stoveEnd + "' ");
                }
            }
            if (stove.Trim() != "")
            {
                if (stove.Substring(0, 1) == "2")
                {
                    strSql.Append(" order by T.C_STOVE ");
                }
                if (stove.Substring(0, 1) == "4")
                {
                    strSql.Append(" order by t.c_batch_no ");
                }
            }


            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 获得数据列表-炉号
        /// </summary>
        /// <param name="stove">炉号</param> 
        /// <returns></returns>
        public DataSet GetList_Stove2(string stove)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select t.C_DESIGN_NO,b.c_sta_desc ,t.c_stove , t.c_stl_grd ,t.c_spec,max(t.n_len)N_LEN,t.c_std_code ,t.c_mat_code ,t.c_mat_name  ,count(1) COU ,sum(n_wgt) WGT,max(D_CCM_DATE) DT,t.C_SCUTCHEON,t.C_LGJH,t.C_ORD_NO,t.C_MAT_TYPE ,t.C_ZYX1,t.C_ZYX2,t.C_JUDGE_LEV_ZH,t.c_move_type ");
            strSql.Append(" FROM TSC_SLAB_MAIN t left join tb_sta b on t.c_sta_id=b.c_id where 1=1");
            strSql.Append(" and t.C_STOVE = '" + stove + "' ");
            strSql.Append(" group by t.C_DESIGN_NO,b.c_sta_desc,t.c_sta_id ,t.c_stove , t.c_stl_grd ,t.c_spec ,t.c_std_code ,t.c_mat_code ,t.c_mat_name,t.C_SCUTCHEON,t.C_LGJH,t.C_ORD_NO ,t.C_MAT_TYPE,t.C_ZYX1,t.C_ZYX2,t.C_JUDGE_LEV_ZH,t.c_move_type  ");
            strSql.Append(" order by T.C_STOVE ");
            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 获得数据列表-炉号-库位
        /// </summary>
        /// <param name="stove">炉号</param>
        /// <param name="C_SLABWH_AREA_CODE">区域</param>
        /// <returns></returns>
        public DataSet GetList_LH_KW(string stove, string C_SLABWH_AREA_CODE)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  a.c_sta_desc,t.C_STA_ID,t.C_STOVE,t.C_STL_GRD,t.C_SPEC,t.N_LEN,t.N_WGT,t.C_STD_CODE,t.C_MAT_CODE,t.C_MAT_NAME,MAX(D_WE_DATE) ,count(1)COU  ");
            strSql.Append(" FROM TSC_SLAB_MAIN t left join tb_sta a on t.c_sta_id=a.c_id where t.C_MOVE_TYPE = 'E'  ");
            if (stove.Trim() != "")
            {
                strSql.Append(" and  t.C_STOVE like '" + stove + "%' ");
            }
            if (C_SLABWH_AREA_CODE.Trim() != "")
            {
                strSql.Append(" and  t.C_SLABWH_AREA_CODE = '" + C_SLABWH_AREA_CODE + "' ");
            }
            strSql.Append(" group by  a.c_sta_desc,t.C_STA_ID,t.C_STOVE,t.C_STL_GRD,t.C_SPEC,t.N_LEN,t.N_WGT,t.C_STD_CODE,t.C_MAT_CODE,t.C_MAT_NAME ");

            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得数据列表-炉号-库位
        /// </summary>
        /// <param name="C_SLABWH_CODE">仓库</param>
        /// <param name="C_SLABWH_LOC_CODE">库位</param>
        /// <returns></returns>
        public DataSet GetList_KW(string C_SLABWH_CODE, string C_SLABWH_LOC_CODE)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select b.C_SLABWH_CODE,T1.C_SLABWH_AREA_NAME,T2.C_SLABWH_LOC_NAME,T.C_SLABWH_TIER_CODE,t.c_batch_no,a.c_sta_desc, t.C_STA_ID,t.C_STOVE,t.C_STL_GRD,t.C_SPEC,t.N_LEN,sum(t.N_WGT)N_WGT,t.C_STD_CODE,t.C_MAT_CODE,t.C_MAT_NAME,MAX(D_WE_DATE) DT，count(1)COU ,(select max(tsc.c_slabwh_tier_code)as c_slabwh_loc_code from tsc_slab_main tsc where tsc.c_slabwh_loc_code=t.c_slabwh_loc_code ) as max_loccode  FROM TSC_SLAB_MAIN t  ");
            strSql.Append(" left join tb_sta a on t.c_sta_id=a.c_id  left join tpb_slabwh b on t.c_slabwh_code = b.c_slabwh_code LEFT JOIN TPB_SLABWH_AREA T1 ON T.C_SLABWH_AREA_CODE=T1.C_SLABWH_AREA_CODE LEFT JOIN TPB_SLABWH_LOC T2  ON T.C_SLABWH_LOC_CODE=T2.C_SLABWH_LOC_CODE where t.C_MOVE_TYPE = 'E' AND B.N_STATUS=1 AND T1.N_STATUS=1 AND T2.N_STATUS=1 ");
            if (C_SLABWH_CODE.Trim() != "")
            {
                strSql.Append(" and  t.C_SLABWH_CODE  = '" + C_SLABWH_CODE + "' ");
            }
            if (C_SLABWH_LOC_CODE.Trim() != "")
            {
                strSql.Append(" and  t.C_SLABWH_LOC_CODE  = '" + C_SLABWH_LOC_CODE + "'");
            }

            strSql.Append(" group by  b.C_SLABWH_CODE,t.c_slabwh_loc_code,T1.C_SLABWH_AREA_NAME,T2.C_SLABWH_LOC_NAME,T.C_SLABWH_TIER_CODE,t.c_batch_no,a.c_sta_desc, t.C_STA_ID,t.C_STOVE,t.C_STL_GRD,t.C_SPEC,t.N_LEN, t.C_STD_CODE,t.C_MAT_CODE,t.C_MAT_NAME  ");
            strSql.Append(" order by to_number( t.C_SLABWH_TIER_CODE)  desc ");
            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * ");
            strSql.Append(" FROM TSC_SLAB_MAIN ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList_WLGP(DateTime begin,DateTime end,string str_Stove, string str_STLGRD)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT T.C_ID,t.C_STOVE，t.c_mat_code,t.c_mat_name,t.C_STL_GRD,t.C_STD_CODE,t.C_SPEC,t.N_LEN,t.N_WGT,t.D_CCM_DATE,t.C_CCM_EMP_ID AS C_EMP_ID,T.C_SLABWH_CODE ,T.C_SLAB_TYPE_R , t.C_MOVE_TYPE,t.c_zyx1,t.c_zyx2   FROM  tsc_slab_main t where t.C_SLAB_TYPE_R='外来钢坯' ");
            if (begin != null && end != null)
            {
                strSql.Append(" and D_CCM_DATE between to_date('" + Convert.ToDateTime(begin) + "','yyyy-mm-dd hh24:mi:ss') and to_date('" + Convert.ToDateTime(end) + "','yyyy-mm-dd hh24:mi:ss') ");
            }
            if (str_Stove.Trim() != "")
            {
                strSql.Append(" AND T.C_STOVE LIKE '%"+ str_Stove + "%' ");
            }
            if (str_STLGRD.Trim() != "")
            {
                strSql.Append(" AND T.C_STL_GRD LIKE '%" + str_STLGRD + "%' ");
            }
            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM TSC_SLAB_MAIN ");
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
            strSql.Append(")AS Row, T.*  from TSC_SLAB_MAIN T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 查询钢坯综合判定数据
        /// </summary>
        /// <param name="stove">炉号</param>
        /// <param name="strTime1">生产开始时间</param>
        /// <param name="strTime2">生产结束时间</param>
        /// <returns></returns>
        public DataSet GetList(string stove, string strTime1, string strTime2)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT T.C_STOVE AS 炉号, T.C_STL_GRD AS 钢种, T.C_SPEC AS 断面, T.C_STD_CODE AS 执行标准, T.C_MAT_CODE AS 物料编码, T.C_MAT_NAME AS 物料名称, T.N_LEN AS 长度, T.N_QUA AS 件数, T.N_WGT AS 重量, T.C_RESULT_FACE AS 表判结果, T.C_REASON_NAME AS 不合格原因, T.C_RESULT_ELE AS 成分结果, T.C_RESULT_ALL AS 综合判定结果, T.C_RESULT_PEOPLE AS 人工判定结果, T.D_RESPEO_DT AS 判定时间,T.C_QR_STATE AS 是否确认, T.C_EMP_ID AS 确认人, T.D_MOD_DT AS 确认时间, T.D_DP_DT AS 生产时间, T.C_DESIGN_NO AS 质量设计号 FROM TQC_COMPRE_SLAB T where N_STATUS=1 ");

            if (stove.Trim() != "")
            {
                strSql.Append(" and t.C_STOVE like '" + stove + "%' ");
            }

            if (strTime1.Trim() != "" && strTime2.Trim() != "")
            {
                strSql.Append(" and t.D_DP_DT between to_date('" + strTime1 + "','yyyy-mm-dd hh24:mi:ss') and to_date('" + strTime2 + "','yyyy-mm-dd hh24:mi:ss') ");
            }

            strSql.Append(" ORDER BY T.D_DP_DT desc ");

            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取钢坯实绩库存数
        /// </summary>
        /// <param name="c_slabwh_code">仓库编码</param>
        /// <returns></returns>
        public DataSet Get_KC_COUNt(string c_slabwh_code)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT t.C_SLABWH_LOC_CODE,count(1)as SLAB_NUM FROM tsc_slab_main t where t.C_MOVE_TYPE = 'E' and t.c_slabwh_code='" + c_slabwh_code + "' group by t.C_SLABWH_LOC_CODE ");

            return DbHelperOra.Query(strSql.ToString());
        }


        #endregion  BasicMethod

        #region  ExtensionMethod
        /// <summary>
        /// 根据发运单号获取已做实绩数量
        /// </summary>
        /// <param name="fydh">发运单号</param>
        /// <returns></returns>
        public int GetSJCount(string fydh)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM TSC_SLAB_MAIN WHERE C_MOVE_TYPE='1'");
            if (fydh.Trim() != "")
            {
                strSql.Append(" AND C_FYDH='" + fydh + "' ");
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
        /// 通过转库单号获取实体
        /// </summary>
        /// <param name="dh">转库单号</param>
        /// <returns></returns>
        public Mod_TSC_SLAB_MAIN GetModelbydh(string dh)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_PLAN_ID,C_BATCH_NO,C_ORD_NO,C_STOVE,C_STA_ID,C_STA_CODE,C_STA_DESC,C_STL_GRD,C_STL_GRD_PRE,C_MAT_CODE,C_MAT_NAME,C_SPEC,N_LEN,N_QUA,N_WGT,C_STD_CODE,C_SLAB_TYPE,D_CCM_DATE,C_CCM_SHIFT,C_CCM_GROUP,C_CCM_EMP_ID,C_MOVE_TYPE,C_SC_STATE,D_ESC_DATE,D_LSC_DATE,C_QKP_STATE,C_KP_ID,C_CON_NO,C_CUS_NO,C_CUS_NAME,D_WL_DATE,C_WL_SHIFT,C_WL_GROUP,C_WL_EMP_ID,D_WE_DATE,C_WE_SHIFT,C_WE_GROUP,C_WE_EMP_ID,C_STOCK_STATE,C_MAT_TYPE,C_QGP_STATE,C_SLABWH_CODE,C_SLABWH_AREA_CODE,C_SLABWH_LOC_CODE,C_SLABWH_TIER_CODE,N_WGT_METER,C_QF_NAME,C_DESIGN_NO,C_ZRBM,C_IS_DEPOT,C_ISXM,C_XMGX,C_ISFREE,C_JUDGE_LEV_CF,C_JUDGE_LEV_XN,C_JUDGE_LEV_ZH,C_JUDGE_LEV_ZH_PEOPLE,D_JUDGE_DATE,C_IS_QR,C_QR_USER,D_QR_DATE,D_Q_DATE,C_SCUTCHEON,C_GP_TYPE,C_REMARK,C_IS_TB,C_MASTER_ID,C_GP_BEFORE_ID,C_GP_AFTER_ID,D_STACK_DATE,C_STACK_USER,C_STACK_SHIFT,C_STACK_GROUP,C_IS_PD,C_REASON_NAME,C_ZKDH,C_ZKDHID from TSC_SLAB_MAIN ");
            strSql.Append(" where C_ZKDH=:dh ");
            OracleParameter[] parameters = {
                    new OracleParameter(":dh", OracleDbType.Varchar2,100)            };
            parameters[0].Value = dh;

            Mod_TSC_SLAB_MAIN model = new Mod_TSC_SLAB_MAIN();
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
        /// 钢坯库存状态
        /// </summary>
        /// <param name="C_MOVE_TYPE">库存状态</param>
        /// <param name="C_STOCK_STATE"></param>
        /// <param name="C_STOVE"></param>
        /// <param name="C_STL_GRD"></param>
        /// <param name="C_STD_CODE"></param>
        /// <returns></returns>
        public DataSet GetList(string C_MOVE_TYPE, string C_STOCK_STATE, string C_STOVE, string C_STL_GRD, string C_STD_CODE)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_PLAN_ID,C_ORD_NO,C_STOVE,C_STA_ID,C_STA_CODE,C_STA_DESC,C_STL_GRD,C_STL_GRD_PRE,C_MAT_CODE,C_MAT_NAME,C_SPEC,N_LEN,N_QUA,N_WGT,C_STD_CODE,C_SLAB_TYPE,D_CCM_DATE,C_CCM_SHIFT,C_CCM_GROUP,C_CCM_EMP_ID,C_MOVE_TYPE,C_SC_STATE,D_ESC_DATE,D_LSC_DATE,C_QKP_STATE,C_KP_ID,C_CON_NO,C_CUS_NO,C_CUS_NAME,D_WL_DATE,C_WL_SHIFT,C_WL_GROUP,C_WL_EMP_ID,D_WE_DATE,C_WE_SHIFT,C_WE_GROUP,C_WE_EMP_ID,C_STOCK_STATE,C_MAT_TYPE,C_QGP_STATE,C_SLABWH_CODE,C_SLABWH_AREA_CODE,C_SLABWH_LOC_CODE,C_SLABWH_TIER_CODE,N_WGT_METER,C_QF_NAME,C_DESIGN_NO,C_ZRBM,C_IS_DEPOT,C_ISXM,C_XMGX ");
            strSql.Append(" FROM TSC_SLAB_MAIN Where C_MOVE_TYPE='" + C_MOVE_TYPE + "' ");

            if (C_STOCK_STATE.Trim() != "")
            {
                strSql.Append("  AND C_STOCK_STATE='" + C_STOCK_STATE + "' ");
            }

            if (C_STOVE.Trim() != "")
            {
                strSql.Append(" AND C_STOVE LIKE '" + C_STOVE + "%' ");
            }
            if (C_STL_GRD.Trim() != "")
            {
                strSql.Append(" AND C_STL_GRD LIKE '%" + C_STL_GRD + "%' ");
            }
            if (C_STD_CODE.Trim() != "")
            {
                strSql.Append(" AND C_STD_CODE LIKE '%" + C_STD_CODE + "%' ");
            }
            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(string id, string status, string ck, string qy, string kw, string c)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TSC_SLAB_MAIN set ");
            strSql.Append(" C_MOVE_TYPE = '" + status + "'");
            if (ck.Trim() != "")
            {
                strSql.Append(" ,C_SLABWH_CODE = '" + ck + "'");
            }
            if (qy.Trim() != "")
            {
                strSql.Append(" ,C_SLABWH_AREA_CODE = '" + qy + "'");
            }
            if (kw.Trim() != "")
            {
                strSql.Append(" ,C_SLABWH_LOC_CODE = '" + kw + "'");
            }
            if (c.Trim() != "")
            {
                strSql.Append(" ,C_SLABWH_TIER_CODE = '" + c + "'");
            }
            strSql.Append(" WHERE C_ID= '" + id + "'");
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
        public bool Update(string id, string status, string ck, string qy, string kw, string c, string C_SC_STATE, DateTime D_ESC_DATE, DateTime D_LSC_DATE)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TSC_SLAB_MAIN set ");
            strSql.Append(" C_MOVE_TYPE = '" + status + "'");
            if (ck.Trim() != "")
            {
                strSql.Append(" ,C_SLABWH_CODE = '" + ck + "'");
            }
            if (qy.Trim() != "")
            {
                strSql.Append(" ,C_SLABWH_AREA_CODE = '" + qy + "'");
            }
            if (kw.Trim() != "")
            {
                strSql.Append(" ,C_SLABWH_LOC_CODE = '" + kw + "'");
            }
            if (c.Trim() != "")
            {
                strSql.Append(" ,C_SLABWH_TIER_CODE = '" + c + "'");
            }
            strSql.Append(" ,C_SC_STATE = '" + C_SC_STATE + "'");
            strSql.Append(" ,D_ESC_DATE = to_date('" + D_ESC_DATE + "','yyyy - mm - dd HH24:MI:SS')");
            strSql.Append(" ,D_LSC_DATE = to_date('" + D_LSC_DATE + "','yyyy - mm - dd HH24:MI:SS')");
            strSql.Append(" WHERE C_ID= '" + id + "'");
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
        /// 获取钢坯库存数据
        /// </summary>
        /// <param name="C_MOVE_TYPE">状态</param>
        /// <param name="C_STOVE">炉号</param>
        /// <param name="C_MAT_CODE">物料号</param>
        /// <param name="C_STD_CODE">执行标准</param>
        /// <param name="C_SLABWH_CODE">仓库</param>
        /// <param name="C_BATCH_NO">开坯号</param>
        /// <param name="C_JUDGE_LEV_ZH">质量等级</param>
        /// <returns></returns>
        public DataSet GetList(string C_MOVE_TYPE, string C_STOVE, string C_MAT_CODE, string C_STD_CODE, string C_SLABWH_CODE, string C_BATCH_NO, string C_JUDGE_LEV_ZH)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select SUM(N_QUA) N_QUA,SUM(N_QUA) N_SNUM,SUM(N_WGT) N_WGT, C_STOVE,C_STL_GRD,C_MAT_CODE,C_MAT_NAME,C_SPEC,N_LEN,C_STD_CODE,C_SLAB_TYPE,C_SLABWH_CODE,C_SLABWH_AREA_CODE,C_SLABWH_LOC_CODE,C_BATCH_NO,C_JUDGE_LEV_ZH");
            strSql.Append(" FROM TSC_SLAB_MAIN Where C_JUDGE_LEV_ZH is not null");
            if (C_MOVE_TYPE != "")
            {
                strSql.Append(" AND C_MOVE_TYPE='" + C_MOVE_TYPE + "' ");
            }
            if (C_BATCH_NO.Trim() != "")
            {
                strSql.Append(" AND C_BATCH_NO LIKE '" + C_BATCH_NO + "%' ");
            }
            if (C_MAT_CODE.Trim() != "")
            {
                strSql.Append(" AND C_MAT_CODE LIKE '%" + C_MAT_CODE + "%' ");
            }
            if (!string.IsNullOrWhiteSpace(C_STD_CODE))
            {
                strSql.Append(" AND C_STD_CODE LIKE '%" + C_STD_CODE + "%' ");
            }
            if (C_SLABWH_CODE.Trim() != "")
            {
                strSql.Append(" AND C_SLABWH_CODE ='" + C_SLABWH_CODE + "' ");
            }
            if (C_JUDGE_LEV_ZH.Trim() != "")
            {
                strSql.Append(" AND C_JUDGE_LEV_ZH ='" + C_JUDGE_LEV_ZH + "' ");
            }
            strSql.Append(" GROUP BY  C_STOVE,C_STL_GRD,C_MAT_CODE,C_MAT_NAME,C_SPEC,N_LEN,C_STD_CODE,C_SLAB_TYPE,C_SLABWH_CODE,C_SLABWH_AREA_CODE,C_SLABWH_LOC_CODE,C_BATCH_NO,C_JUDGE_LEV_ZH");
            strSql.Append(" ORDER BY  C_STOVE,C_BATCH_NO");
            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        ///根据判定情况，钢坯状态获取数据列表
        /// </summary>
        public DataSet GetList(string slabid, string C_SC_STATE, string C_MOVE_TYPE, string C_STOCK_STATE, string C_STOVE, string C_STL_GRD, string C_STD_CODE, string type, string C_SLABWH_CODE)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_PLAN_ID,C_ORD_NO,C_STOVE,C_STA_ID,C_STA_CODE,C_STA_DESC,C_STL_GRD,C_STL_GRD_PRE,C_MAT_CODE,C_MAT_NAME,C_SPEC,N_LEN,N_QUA,N_WGT,C_STD_CODE,C_SLAB_TYPE,D_CCM_DATE,C_CCM_SHIFT,C_CCM_GROUP,C_CCM_EMP_ID,C_MOVE_TYPE,C_SC_STATE,D_ESC_DATE,D_LSC_DATE,C_QKP_STATE,C_KP_ID,C_CON_NO,C_CUS_NO,C_CUS_NAME,D_WL_DATE,C_WL_SHIFT,C_WL_GROUP,C_WL_EMP_ID,D_WE_DATE,C_WE_SHIFT,C_WE_GROUP,C_WE_EMP_ID,C_STOCK_STATE,C_MAT_TYPE,C_QGP_STATE,C_SLABWH_CODE,C_SLABWH_AREA_CODE,C_SLABWH_LOC_CODE,C_SLABWH_TIER_CODE,N_WGT_METER,C_QF_NAME,C_DESIGN_NO,C_ZRBM,C_IS_DEPOT,C_ISXM,C_XMGX,N_JZ,C_BATCH_NO");
            strSql.Append(" FROM TSC_SLAB_MAIN Where 1=1 ");
            if (C_SC_STATE != "")
            {
                strSql.Append(" AND C_SC_STATE='" + C_SC_STATE + "' ");
            }
            if (C_MOVE_TYPE != "")
            {
                strSql.Append(" AND C_MOVE_TYPE='" + C_MOVE_TYPE + "' ");
            }
            if (type != "")
            {
                strSql.Append(" AND C_MOVE_TYPE LIKE '%" + type + "%' ");
            }
            if (C_STOCK_STATE != "")
            {
                strSql.Append(" AND C_STOCK_STATE='" + C_STOCK_STATE + "' ");
            }

            if (slabid != "")
            {
                strSql.Append(" AND C_ID ='" + slabid + "' ");
            }
            if (C_STOVE.Trim() != "")
            {
                strSql.Append(" AND C_STOVE LIKE '" + C_STOVE + "%' ");
            }
            if (C_STL_GRD.Trim() != "")
            {
                strSql.Append(" AND C_STL_GRD LIKE '%" + C_STL_GRD + "%' ");
            }
            if (C_STD_CODE.Trim() != "")
            {
                strSql.Append(" AND C_STD_CODE LIKE '%" + C_STD_CODE + "%' ");
            }
            if (C_SLABWH_CODE.Trim() != "")
            {
                strSql.Append(" AND C_SLABWH_CODE in('" + C_SLABWH_CODE + "') ");
            }
            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 根据发运单号获取数据
        /// </summary>
        /// <param name="C_FYDH">发运单号</param>
        /// <param name="C_MOVE_TYPE">状态</param>
        /// <param name="C_STOVE">炉号</param>
        /// <param name="C_BATCH_NO">批号</param>
        /// <param name="C_SLABWH_CODE">仓库</param>
        /// <returns></returns>
        public DataSet GetListByFYDH(string C_FYDH, string C_MOVE_TYPE, string C_STOVE, string C_BATCH_NO, string C_SLABWH_CODE)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_STOVE,C_STL_GRD,C_MAT_CODE,C_MAT_NAME,C_SPEC,N_LEN,N_QUA,N_WGT,C_STD_CODE,C_MOVE_TYPE,C_SLABWH_CODE,C_SLABWH_AREA_CODE,C_SLABWH_LOC_CODE,C_SLABWH_TIER_CODE,N_WGT_METER,C_QF_NAME,C_DESIGN_NO,C_ZRBM,C_IS_DEPOT,C_ISXM,C_XMGX,N_JZ,C_BATCH_NO，C_FYDH,c_Judge_Lev_Zh");
            strSql.Append(" FROM TSC_SLAB_MAIN Where C_MOVE_TYPE='" + C_MOVE_TYPE + "' AND C_FYDH IS NOT NULL ");
            if (C_FYDH != "")
            {
                strSql.Append(" AND C_FYDH='" + C_FYDH + "' ");
            }
            if (C_STOVE != "")
            {
                strSql.Append(" AND C_STOVE='" + C_STOVE + "' ");
            }
            if (C_BATCH_NO != "")
            {
                strSql.Append(" AND C_BATCH_NO='" + C_BATCH_NO + "' ");
            }
            if (C_SLABWH_CODE.Trim() != "")
            {
                strSql.Append(" AND C_SLABWH_CODE in('" + C_SLABWH_CODE + "') ");
            }
            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取可组批钢坯
        /// </summary>
        ///  <param name="ordergrd">原计划钢种</param>
        ///  <param name="orderstd">原计划标准</param>
        /// <param name="replaceStl">可代轧钢种</param>
        /// <param name="grd">钢种</param>
        /// <param name="std">执行标准</param>
        /// <param name="spec">规格</param>
        /// <param name="stove">炉号</param>
        /// <param name="slbwhCode">钢坯仓库编码</param>
        /// <param name="matCode">物料编码</param>
        /// <returns></returns>
        public DataSet GetRepalceStl(string ordergrd,string orderstd, DataTable replaceGrd, string grd, string std, string spec, string stove, string length, string matCode, string slbwhCode = "555")
        {
            List<OracleParameter> paras = new List<OracleParameter>();

            string sql = @"SELECT 
                                    TSM.C_STOVE
                                    ,TSM.C_BATCH_NO
                                    ,COUNT(TSM.C_STOVE) N_QUA
                                    ,MAX(TSM.C_STL_GRD)  C_STL_GRD
                                    ,MAX(TSM.C_SPEC) C_SPEC
                                    ,MAX(TSM.N_LEN) N_LEN
                                    ,TSM.C_STD_CODE C_STD_CODE
                                    ,SUM(TSM.N_WGT) WGTSUM
                                    ,MIN(TSM.N_WGT) N_WGT                                 
                                    ,TSM.C_MAT_CODE
                                    ,TSM.C_MAT_NAME
                                    ,TSM.C_REMARK
                                    FROM TSC_SLAB_MAIN TSM 
                                    LEFT JOIN  TB_STA TSA ON TSA.C_ID=TSM.C_STA_ID
                                    WHERE TSM.c_Move_Type='E'   AND TSM.C_SPEC!='280*325'                                                            
                                    ";



            sql += "  AND  TSM.C_STOVE NOT IN (SELECT T.C_STOVE FROM TQC_SLAB_YC T ) ";

            if (!string.IsNullOrWhiteSpace(slbwhCode))
            {
                sql += @"  AND TSM.C_SLABWH_CODE=:slbwhCode ";
                paras.Add(new OracleParameter() { ParameterName = ":slbwhCode", Value = slbwhCode });
            }

            if (!string.IsNullOrWhiteSpace(stove))
            {
                sql += @"  AND TSM.C_STOVE like :C_STOVE ";
                paras.Add(new OracleParameter() { ParameterName = ":C_STOVE", Value = "%" + stove + "%" });
            }

            //if (!string.IsNullOrWhiteSpace(spec))
            //{
            //    sql += @"  AND TSM.C_SPEC = :C_SPEC ";
            //    paras.Add(new OracleParameter() { ParameterName = ":C_SPEC", Value = spec });
            //}

            //if (!string.IsNullOrWhiteSpace(length))
            //{
            //    sql += @"  AND TSM.N_LEN = :N_LEN ";
            //    paras.Add(new OracleParameter() { ParameterName = ":N_LEN", Value = length });
            //}

            //if (!string.IsNullOrWhiteSpace(matCode))
            //{
            //    sql += @"  AND TSM.C_MAT_CODE = :C_MAT_CODE ";
            //    paras.Add(new OracleParameter() { ParameterName = ":C_MAT_CODE", Value = matCode });
            //}

            sql += "  AND   (  ";
            sql += "  (TSM.C_STL_GRD='" + grd + "' AND TSM.C_STD_CODE='" + std + "')  ";
            if (replaceGrd != null && replaceGrd.Rows.Count > 0)
            {
                for (int i = 0; i < replaceGrd.Rows.Count; i++)
                {
                    sql += "OR  (TSM.C_STL_GRD='" + replaceGrd.Rows[i]["C_REPLACE_GRD"] + "' AND TSM.C_STD_CODE='" + replaceGrd.Rows[i]["C_REPLACE_STD_CODE"] + "')  ";
                }
            }
            sql += "OR  (TSM.C_STL_GRD='" +ordergrd + "' AND TSM.C_STD_CODE='" + orderstd + "')  ";

            sql += ") ";

            sql += " GROUP BY TSM.C_BATCH_NO,TSM.C_STOVE ,TSM.C_STD_CODE,TSM.C_MAT_CODE,TSM.C_MAT_NAME,TSM.C_REMARK ";
            sql += " ORDER BY TSM.C_BATCH_NO  DESC ";

            return DbHelperOra.Query(sql, paras.ToArray());
        }

        /// <summary>
        /// 获取开坯可组批钢坯
        /// </summary>
        /// <param name="grd">物料编码</param>
        /// <param name="std">执行标准</param>
        /// <param name="stove">炉号</param>
        /// <param name="slbwhCode">钢坯仓库编码</param>
        /// <returns></returns>
        public DataSet GetRepalceStl(string matCode, string std, string spec, string length, string stove, string slbwhCode = "500")
        {
            List<OracleParameter> paras = new List<OracleParameter>();

            string sql = @"SELECT 
                                    TSM.C_STOVE
                                    ,COUNT(TSM.C_STOVE) N_QUA
                                    ,MAX(TSM.C_STL_GRD)  C_STL_GRD
                                    ,MAX(TSM.C_SPEC) C_SPEC
                                    ,MAX(TSM.N_LEN) N_LEN
                                    ,MAX(TSM.C_REMARK) C_REMARK
                                    ,MAX(TSM.C_STD_CODE) C_STD_CODE
                                    ,SUM(TSM.N_WGT) WGTSUM
                                    ,MIN(TSM.N_WGT) N_WGT
                                    ,TSM.C_MAT_CODE
                                    ,TSM.C_MAT_NAME  ";

            sql += @"  FROM TSC_SLAB_MAIN TSM 
                                    WHERE   TSM.c_qkp_state ='Y'
                                      AND     TSM.c_Move_Type='E'  
                                    ";

            sql += "  AND  TSM.C_STOVE NOT IN (SELECT T.C_STOVE FROM TQC_SLAB_YC T ) ";

            if (!string.IsNullOrWhiteSpace(slbwhCode))
            {
                sql += @"  AND TSM.c_Slabwh_Code=:slbwhCode ";
                paras.Add(new OracleParameter() { ParameterName = ":slbwhCode", Value = slbwhCode });
            }

            if (!string.IsNullOrWhiteSpace(stove))
            {
                sql += @"  AND TSM.C_STOVE like :C_STOVE ";
                paras.Add(new OracleParameter() { ParameterName = ":C_STOVE", Value = "%" + stove + "%" });
            }


            sql += "  AND TSM.C_STD_CODE = '" + std + "'  ";


            sql += "  AND TSM.C_SPEC = '" + spec + "'  ";



            sql += "  AND TSM.C_MAT_CODE = '" + matCode + "'  ";


            sql += "  AND TSM.N_LEN = '" + length + "'  ";


            sql += " GROUP BY TSM.C_STOVE,TSM.C_MAT_CODE,TSM.C_MAT_NAME ";
            sql += "  ORDER BY TSM.C_STOVE  ";

            return DbHelperOra.Query(sql, paras.ToArray());
        }



        /// <summary>
        /// 获取钢坯明细
        /// </summary>
        /// <param name="grd">钢种</param>
        /// <param name="std">执行标准</param>
        /// <param name="stove">炉号</param>
        /// <param name="asseNum">组批支数</param>
        /// <param name="slbwhCode">待轧钢坯仓库库位编码</param>
        /// <returns></returns>
        public DataSet GetRepalceStl(string grd, string std, string stove, int asseNum, string kpBatchNo, string slbwhCode = "555")
        {
            List<OracleParameter> paras = new List<OracleParameter>();

            string sql = @"SELECT * FROM TSC_SLAB_MAIN TSM
                                    WHERE TSM.c_Move_Type ='E'                                                     
                                    ";

            if (!string.IsNullOrWhiteSpace(grd))
            {
                sql += @"  AND TSM.C_STL_GRD=:grd ";
                paras.Add(new OracleParameter() { ParameterName = ":grd", Value = grd });
            }

            if (!string.IsNullOrWhiteSpace(std))
            {
                sql += @"  AND TSM.C_STD_CODE=:std ";
                paras.Add(new OracleParameter() { ParameterName = ":std", Value = std });
            }

            if (!string.IsNullOrWhiteSpace(slbwhCode))
            {
                sql += @"  AND TSM.C_SLABWH_CODE=:slbwhCode ";
                paras.Add(new OracleParameter() { ParameterName = ":slbwhCode", Value = slbwhCode });
            }

            if (!string.IsNullOrWhiteSpace(stove))
            {
                sql += @"  AND TSM.C_STOVE = :C_STOVE ";
                paras.Add(new OracleParameter() { ParameterName = ":C_STOVE", Value = stove });
            }

            if (!string.IsNullOrWhiteSpace(kpBatchNo))
            {
                sql += @"  AND TSM.C_BATCH_NO = :kpBatchNo ";
                paras.Add(new OracleParameter() { ParameterName = ":kpBatchNo", Value = kpBatchNo });
            }

            if (asseNum != 0)
            {
                sql += @" AND ROWNUM<=:asseNum ";
                paras.Add(new OracleParameter() { ParameterName = ":asseNum", Value = asseNum });
            }

            return DbHelperOra.Query(sql, paras.ToArray());
        }

        /// <summary>
        /// 获取钢坯明细
        /// </summary>
        /// <param name="grd">钢种</param>
        /// <param name="std">执行标准</param>
        /// <param name="stove">炉号</param>
        /// <param name="asseNum">组批支数</param>
        /// <param name="slbwhCode">待轧钢坯仓库库位编码</param>
        /// <returns></returns>
        public DataSet GetRepalceStl(string grd, string std, string stove, int asseNum, string slbwhCode = "555")
        {
            List<OracleParameter> paras = new List<OracleParameter>();

            string sql = @"SELECT * FROM TSC_SLAB_MAIN TSM
                                    WHERE TSM.c_Move_Type ='E'                                                     
                                    ";

            if (!string.IsNullOrWhiteSpace(grd))
            {
                sql += @"  AND TSM.C_STL_GRD=:grd ";
                paras.Add(new OracleParameter() { ParameterName = ":grd", Value = grd });
            }

            if (!string.IsNullOrWhiteSpace(std))
            {
                sql += @"  AND TSM.C_STD_CODE=:std ";
                paras.Add(new OracleParameter() { ParameterName = ":std", Value = std });
            }

            if (!string.IsNullOrWhiteSpace(slbwhCode))
            {
                sql += @"  AND TSM.C_SLABWH_CODE=:slbwhCode ";
                paras.Add(new OracleParameter() { ParameterName = ":slbwhCode", Value = slbwhCode });
            }

            if (!string.IsNullOrWhiteSpace(stove))
            {
                sql += @"  AND TSM.C_STOVE = :C_STOVE ";
                paras.Add(new OracleParameter() { ParameterName = ":C_STOVE", Value = stove });
            }

            if (asseNum != 0)
            {
                sql += @" AND ROWNUM<=:asseNum ";
                paras.Add(new OracleParameter() { ParameterName = ":asseNum", Value = asseNum });
            }

            return DbHelperOra.Query(sql, paras.ToArray());
        }

        /// <summary>
        /// 获取开坯钢坯明细
        /// </summary>
        /// <param name="grd">钢种</param>
        /// <param name="std">执行标准</param>
        /// <param name="stove">炉号</param>
        /// <param name="asseNum">组批支数</param>
        /// <param name="slbwhCode">待轧钢坯仓库库位编码</param>
        /// <param name="type"></param>
        /// <returns></returns>
        public DataSet GetRepalceStl(string grd, string std, string stove, int asseNum, int type, string slbwhCode = "500")
        {
            List<OracleParameter> paras = new List<OracleParameter>();

            string sql = @"SELECT * FROM TSC_SLAB_MAIN TSM
                                    WHERE   TSM.c_qkp_state= 'Y'
                                    and TSM.c_move_type='E'
                                    ";

            if (!string.IsNullOrWhiteSpace(grd))
            {
                sql += @"  AND TSM.C_STL_GRD=:grd ";
                paras.Add(new OracleParameter() { ParameterName = ":grd", Value = grd });
            }

            if (!string.IsNullOrWhiteSpace(std))
            {
                sql += @"  AND TSM.C_STD_CODE=:std ";
                paras.Add(new OracleParameter() { ParameterName = ":std", Value = std });
            }

            if (!string.IsNullOrWhiteSpace(slbwhCode))
            {
                sql += @"  AND TSM.c_Slabwh_Code=:slbwhCode ";
                paras.Add(new OracleParameter() { ParameterName = ":slbwhCode", Value = slbwhCode });
            }

            if (!string.IsNullOrWhiteSpace(stove))
            {
                sql += @"  AND TSM.C_STOVE = :C_STOVE ";
                paras.Add(new OracleParameter() { ParameterName = ":C_STOVE", Value = stove });
            }

            if (asseNum != 0)
            {
                sql += @" AND ROWNUM<=:asseNum ";
                paras.Add(new OracleParameter() { ParameterName = ":asseNum", Value = asseNum });
            }

            return DbHelperOra.Query(sql, paras.ToArray());
        }


        /// <summary>
        ///根据判定情况，钢坯状态获取数据列表
        /// </summary>
        public DataSet GetList_ZPID(string slabid, string C_SC_STATE, string C_MOVE_TYPE, string C_STOCK_STATE, string C_STOVE, string C_STL_GRD, string C_STD_CODE, string type, string C_SLABWH_CODE, int N_ZS, string C_STA_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select WMSYS.WM_CONCAT(t.c_id) as c_id from tsc_slab_main t where rownum <=" + N_ZS);
            if (C_SC_STATE != "")
            {
                strSql.Append(" AND C_SC_STATE='" + C_SC_STATE + "' ");
            }
            if (C_MOVE_TYPE != "")
            {
                strSql.Append(" AND C_MOVE_TYPE='" + C_MOVE_TYPE + "' ");
            }
            if (type != "")
            {
                strSql.Append(" AND C_MOVE_TYPE LIKE '%" + type + "%' ");
            }
            if (C_STOCK_STATE != "")
            {
                strSql.Append(" AND C_STOCK_STATE='" + C_STOCK_STATE + "' ");
            }

            if (slabid != "")
            {
                strSql.Append(" AND C_ID ='" + slabid + "' ");
            }
            if (C_STOVE.Trim() != "")
            {
                strSql.Append(" AND C_STOVE LIKE'%" + C_STOVE + "%' ");
            }
            if (C_STL_GRD.Trim() != "")
            {
                strSql.Append(" AND C_STL_GRD LIKE'%" + C_STL_GRD + "%' ");
            }
            if (C_STD_CODE.Trim() != "")
            {
                strSql.Append(" AND C_STD_CODE LIKE'%" + C_STD_CODE + "%' ");
            }
            if (C_SLABWH_CODE.Trim() != "")
            {
                strSql.Append(" AND C_SLABWH_CODE in('" + C_SLABWH_CODE + "') ");
            }
            if (C_STA_ID.Trim() != "")
            {
                strSql.Append(" AND C_STA_ID LIKE'%" + C_STA_ID + "%' ");
            }


            strSql.Append(" group by C_STOVE,C_STA_ID,C_STL_GRD,C_SPEC,N_LEN,N_WGT order by C_STOVE ");

            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 更新钢坯状态(组批)
        /// </summary>
        /// <param name="id">钢坯id</param>
        /// <param name = "slbwhCode" >仓库编码 </ param >
        /// <returns></returns>
        public int UpdateGrdMoveType(string id, string slbwhCode)
        {
            string[] arr = id.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

            string sql = @"  Update TSC_SLAB_MAIN TSM  
                                                    SET TSM.C_MOVE_TYPE='DZ'
                                                    WHERE  TSM.C_ID IN( ";

            for (int i = 0; i < arr.Length; i++)
            {
                if (i == arr.Length - 1)
                    sql += "'" + arr[i] + "'";
                else
                    sql += "'" + arr[i] + "',";
            }

            sql += ")  AND TSM.C_SLABWH_CODE=" + slbwhCode + "   AND TSM.C_MOVE_TYPE='E'     ";

            return TransactionHelper.ExecuteSql(sql);
        }

        /// <summary>
        /// 更新钢坯状态(开坯组批)
        /// </summary>
        /// <param name="id">钢坯id</param>
        /// <param name="type">开坯组批</param>
        ///  <param name="slbwhCode">仓库</param>
        /// <returns></returns>
        public int UpdateGrdMoveType(string id, int type, string slbwhCode)
        {
            string[] arr = id.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

            string sql = @"  Update TSC_SLAB_MAIN TSM  
                                                    SET TSM.C_MOVE_TYPE='NP'
                                                    WHERE  TSM.C_ID IN( ";

            for (int i = 0; i < arr.Length; i++)
            {
                if (i == arr.Length - 1)
                    sql += "'" + arr[i] + "'";
                else
                    sql += "'" + arr[i] + "',";
            }

            sql += ")    AND TSM.c_Slabwh_Code=" + slbwhCode + "  AND   TSM.C_MOVE_TYPE='E'   ";

            return TransactionHelper.ExecuteSql(sql);
        }

        /// <summary>
        /// 更新钢坯状态(撤回)
        /// </summary>
        /// <param name="id">组批主表id</param>
        /// <returns></returns>
        public bool BackOutGrdMoveType(string asseID)
        {
            bool bol = false;

            #region 根据组批主表ID查询子表全部关联钢坯ID
            string sqlQuery = @"  SELECT * FROM TRC_ROLL_MAIN_ITEM TRMI
                                                WHERE TRMI.C_ROLL_MAIN_ID='" + asseID + "'  ";
            DataTable dt = DbHelperOra.Query(sqlQuery).Tables[0];
            int count = dt.Rows.Count;
            #endregion

            #region 撤回全部钢坯状态 DZ(待轧) N()
            string sqlExec = @"  Update TSC_SLAB_MAIN TSM  
                                                    SET TSM.C_MOVE_TYPE='E'
                                                    WHERE  TSM.C_ID IN( ";
            if (dt != null && dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (i == dt.Rows.Count - 1)
                        sqlExec += "'" + dt.Rows[i]["C_SLAB_MAIN_ID"] + "'";
                    else
                        sqlExec += "'" + dt.Rows[i]["C_SLAB_MAIN_ID"] + "',";
                }
            }
            sqlExec += ")   AND TSM.C_MOVE_TYPE='DZ'   ";

            int resultCount = TransactionHelper.ExecuteSql(sqlExec);

            #endregion

            if (count == resultCount)
                bol = true;

            return bol;
        }

        /// <summary>
        /// 更新钢坯状态(开坯撤回)
        /// </summary>
        /// <param name="id">组批主表id</param>
        /// <returns></returns>
        public bool BackOutGrdMoveType(string asseID, int type)
        {
            bool bol = false;

            #region 根据组批主表ID查询子表全部关联钢坯ID
            string sqlQuery = @"  SELECT * FROM TRC_COGDOWN_MAIN_ITEM TRMI
                                                WHERE TRMI.C_COGDOWN_MAIN_ID='" + asseID + "'  ";
            DataTable dt = DbHelperOra.Query(sqlQuery).Tables[0];
            int count = dt.Rows.Count;
            #endregion

            #region 撤回全部钢坯状态 NP(待开坯) DR(待入炉)
            string sqlExec = @"  Update TSC_SLAB_MAIN TSM  
                                                    SET TSM.C_MOVE_TYPE='E'
                                                    WHERE  TSM.C_ID IN( ";
            if (dt != null && dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (i == dt.Rows.Count - 1)
                        sqlExec += "'" + dt.Rows[i]["C_SLAB_MAIN_ID"] + "'";
                    else
                        sqlExec += "'" + dt.Rows[i]["C_SLAB_MAIN_ID"] + "',";
                }
            }
            sqlExec += ")   AND TSM.C_MOVE_TYPE='NP'   ";

            int resultCount = TransactionHelper.ExecuteSql(sqlExec);

            #endregion

            if (count == resultCount)
                bol = true;

            return bol;
        }

        /// <summary>
        /// 获取调拨数据
        /// </summary>
        /// <param name="staID"></param>
        /// <returns></returns>
        public DataSet GetAllotData(string staID)
        {
            List<OracleParameter> paras = new List<OracleParameter>();
            string sql = @"SELECT TSM.C_STOVE,
                                    COUNT(C_ID) N_QUA,
                                    TSM.C_STL_GRD,
                                    TSM.C_STD_CODE,
                                    TSM.C_SPEC,
                                    TSM.C_MAT_CODE,
                                    TSM.C_MAT_NAME,
                                    (SELECT C_STA_DESC FROM TB_STA WHERE C_ID=:id)C_STA_DESC
                             FROM TSC_SLAB_MAIN TSM
                             WHERE TSM.C_STA_ID=:id
                             AND   TSM.C_MOVE_TYPE ='N'
                             AND   TSM.C_SLABWH_CODE IS NULL
                             GROUP BY TSM.C_STOVE,
                                      TSM.C_STL_GRD,
                                      TSM.C_STD_CODE,
                                      TSM.C_SPEC,
                                      TSM.C_MAT_CODE,
                                      TSM.C_MAT_NAME";
            paras.Add(new OracleParameter() { ParameterName = ":id", Value = staID });
            return DbHelperOra.Query(sql, paras.ToArray());
        }

        /// <summary>
        /// 获取调拨数据
        /// </summary>
        /// <param name="staID"></param>
        /// <returns></returns>
        public DataSet GetAllotCenterData(string staID, int type)
        {
            List<OracleParameter> paras = new List<OracleParameter>();
            string sql = @"SELECT 
                                     TSM.C_STOVE,
                                     COUNT(TSM.C_ID) N_QUA,
                                     TSM.C_STL_GRD,
                                     TSM.C_STD_CODE,
                                     TSM.C_SPEC,
                                     TSM.C_MAT_CODE,
                                     TSM.C_MAT_NAME,
                                     TSM.D_WE_DATE,
                                     (SELECT C_STA_DESC FROM TB_STA WHERE C_ID=:id)C_STA_DESC,
                                     MAX(TAL.C_SLABWH_CODE)C_SLABWH_CODE 
                                     FROM  TSC_ALLOT_CENTER TAL
                                     LEFT JOIN  TSC_SLAB_MAIN TSM ON TSM.C_ID=TAL.C_SLAB_MAIN_ID
                                     WHERE TAL.C_STA_ID=:id
                                     AND TAL.N_TYPE=1
                                     GROUP BY 
                                     TSM.C_STOVE,
                                     TSM.C_STL_GRD,
                                     TSM.C_STD_CODE,
                                     TSM.C_SPEC,
                                     TSM.C_MAT_CODE,
                                     TSM.C_MAT_NAME,
                                     TSM.D_WE_DATE";
            paras.Add(new OracleParameter() { ParameterName = ":id", Value = staID });
            return DbHelperOra.Query(sql, paras.ToArray());
        }

        /// <summary>
        /// 更新钢坯调拨状态
        /// </summary>
        /// <param name="staID">工位</param>
        /// <param name="stove">炉号</param>
        /// <param name="grd">钢种</param>
        /// <param name="spec">规格</param>
        /// <param name="std">执行标准</param>
        /// <param name="matCode">物料编码</param>
        /// <param name="num">支数</param>
        /// <param name="slabwhCode">仓库</param>
        /// <param name="shift">班组</param>
        /// <param name="group">班次</param>
        /// <param name="billet">钢坯</param>
        /// <returns></returns>
        public int AllotGrdType(string staID, string stove, string grd, string spec, string std,
            string matCode, int num, string slabwhCode, string shift, string group, out DataTable billet)
        {
            List<OracleParameter> paras = new List<OracleParameter>();

            string querySql = @"SELECT * FROM TSC_SLAB_MAIN TSM
                                                WHERE TSM.C_STA_ID=:staID  AND  TSM.C_MOVE_TYPE='N'   ";
            paras.Add(new OracleParameter() { ParameterName = ":staID", Value = staID });

            if (!string.IsNullOrWhiteSpace(stove))
            {

                querySql += "  AND   TSM.C_STOVE =:stove  ";
                paras.Add(new OracleParameter() { ParameterName = ":stove", Value = stove });
            }

            if (!string.IsNullOrWhiteSpace(grd))
            {
                querySql += "  AND TSM.C_STL_GRD =:grd ";
                paras.Add(new OracleParameter() { ParameterName = ":grd", Value = grd });
            }

            if (!string.IsNullOrWhiteSpace(spec))
            {
                querySql += "  AND   TSM.C_SPEC =:spec ";
                paras.Add(new OracleParameter() { ParameterName = ":spec", Value = spec });
            }

            if (!string.IsNullOrWhiteSpace(std))
            {
                querySql += "   AND   TSM.C_STD_CODE =:std ";
                paras.Add(new OracleParameter() { ParameterName = ":std", Value = std });
            }

            if (!string.IsNullOrWhiteSpace(matCode))
            {
                querySql += "   AND   TSM.C_MAT_CODE =:matCode ";
                paras.Add(new OracleParameter() { ParameterName = ":matCode", Value = matCode });
            }

            querySql += "   AND   ROWNUM <=:num";
            paras.Add(new OracleParameter() { ParameterName = ":num", Value = num });

            DataTable slabDt = DbHelperOra.Query(querySql, paras.ToArray()).Tables[0];
            billet = slabDt;
            if (slabDt == null || slabDt.Rows.Count == 0)
                return 0;

            List<OracleParameter> parasSecond = new List<OracleParameter>();
            string sql = @"UPDATE TSC_SLAB_MAIN TSM
                                    SET TSM.C_MOVE_TYPE='M'   ";

            //if (!string.IsNullOrWhiteSpace(slabwhCode))
            //{
            //    sql += "  ,TSM.C_SLABWH_CODE=:slabwhCode ";
            //    parasSecond.Add(new OracleParameter() { ParameterName = ":slabwhCode", Value = slabwhCode });
            //}

            sql += "  ,TSM.D_WE_DATE=:t  ";
            parasSecond.Add(new OracleParameter() { ParameterName = ":t", Value = DateTime.Now });

            if (!string.IsNullOrWhiteSpace(shift))
            {
                sql += "  ,TSM.C_WE_SHIFT=:shift  ";
                parasSecond.Add(new OracleParameter() { ParameterName = ":shift", Value = shift });
            }

            if (!string.IsNullOrWhiteSpace(group))
            {
                sql += "  ,TSM.C_WE_GROUP=:group ";
                parasSecond.Add(new OracleParameter() { ParameterName = ":group", Value = group });
            }

            sql += " WHERE TSM.C_ID IN( ";
            if (slabDt != null && slabDt.Rows.Count > 0)
            {
                for (int i = 0; i < slabDt.Rows.Count; i++)
                {
                    if (i == slabDt.Rows.Count - 1)
                        sql += "'" + slabDt.Rows[i]["C_ID"] + "'";
                    else
                        sql += "'" + slabDt.Rows[i]["C_ID"] + "',";
                }
            }
            sql += ") ";

            sql += " AND TSM.C_STA_ID=:staID ";
            parasSecond.Add(new OracleParameter() { ParameterName = ":staID", Value = staID });

            sql += " AND TSM.C_MOVE_TYPE ='N' ";


            return TransactionHelper.ExecuteSql(sql, parasSecond.ToArray());
        }

        /// <summary>
        /// 撤销钢坯调拨
        /// </summary>
        /// <param name="staID">工位</param>
        /// <param name="stove">炉号</param>
        /// <param name="grd">钢种</param>
        /// <param name="spec">规格</param>
        /// <param name="std">执行标准</param>
        /// <param name="matCode">物料编码</param>
        /// <param name="num">支数</param>
        /// <returns></returns>
        public int BackAllotGrdType(string staID, string stove, string grd, string spec, string std,
            string matCode, int num, out DataTable billet)
        {
            List<OracleParameter> paras = new List<OracleParameter>();

            string querySql = @"SELECT * FROM TSC_SLAB_MAIN TSM
                                                WHERE TSM.C_STA_ID=:staID  AND  TSM.C_MOVE_TYPE='M'  ";
            paras.Add(new OracleParameter() { ParameterName = ":staID", Value = staID });

            if (!string.IsNullOrWhiteSpace(stove))
            {

                querySql += "  AND   TSM.C_STOVE =:stove  ";
                paras.Add(new OracleParameter() { ParameterName = ":stove", Value = stove });
            }

            if (!string.IsNullOrWhiteSpace(grd))
            {
                querySql += "  AND TSM.C_STL_GRD =:grd ";
                paras.Add(new OracleParameter() { ParameterName = ":grd", Value = grd });
            }

            if (!string.IsNullOrWhiteSpace(spec))
            {
                querySql += "  AND   TSM.C_SPEC =:spec ";
                paras.Add(new OracleParameter() { ParameterName = ":spec", Value = spec });
            }

            if (!string.IsNullOrWhiteSpace(std))
            {
                querySql += "   AND   TSM.C_STD_CODE =:std ";
                paras.Add(new OracleParameter() { ParameterName = ":std", Value = std });
            }

            if (!string.IsNullOrWhiteSpace(matCode))
            {
                querySql += "   AND   TSM.C_MAT_CODE =:matCode ";
                paras.Add(new OracleParameter() { ParameterName = ":matCode", Value = matCode });
            }

            querySql += "   AND   ROWNUM <=:num";
            paras.Add(new OracleParameter() { ParameterName = ":num", Value = num });

            DataTable slabDt = DbHelperOra.Query(querySql, paras.ToArray()).Tables[0];
            billet = slabDt;
            if (slabDt == null || slabDt.Rows.Count == 0)
                return 0;

            List<OracleParameter> parasSecond = new List<OracleParameter>();
            string sql = @"UPDATE TSC_SLAB_MAIN TSM
                                    SET TSM.C_MOVE_TYPE='N'   ";

            sql += "  ,TSM.C_SLABWH_CODE=NULL ";

            sql += "  ,TSM.D_WE_DATE=NULL  ";

            sql += "  ,TSM.C_WE_SHIFT=NULL  ";

            sql += "  ,TSM.C_WE_GROUP=NULL ";


            sql += " WHERE TSM.C_ID IN( ";
            if (slabDt != null && slabDt.Rows.Count > 0)
            {
                for (int i = 0; i < slabDt.Rows.Count; i++)
                {
                    if (i == slabDt.Rows.Count - 1)
                        sql += "'" + slabDt.Rows[i]["C_ID"] + "'";
                    else
                        sql += "'" + slabDt.Rows[i]["C_ID"] + "',";
                }
            }
            sql += ") ";

            sql += " AND TSM.C_STA_ID=:staID ";
            parasSecond.Add(new OracleParameter() { ParameterName = ":staID", Value = staID });

            sql += " AND TSM.C_MOVE_TYPE ='M' ";


            return TransactionHelper.ExecuteSql(sql, parasSecond.ToArray());
        }

        /// <summary>
        /// 撤销钢坯调拨更新中间表
        /// </summary>
        /// <param name="billet"></param>
        /// <returns></returns>
        public int BackAllotUpdateCenter(DataTable billet)
        {
            string sql = @"UPDATE  TSC_ALLOT_CENTER TAC
                                    SET TAC.N_TYPE=3
                                    ";
            sql += " WHERE TAC.C_SLAB_MAIN_ID IN( ";
            if (billet != null && billet.Rows.Count > 0)
            {
                for (int i = 0; i < billet.Rows.Count; i++)
                {
                    if (i == billet.Rows.Count - 1)
                        sql += "'" + billet.Rows[i]["C_ID"] + "'";
                    else
                        sql += "'" + billet.Rows[i]["C_ID"] + "',";
                }
            }
            sql += ")   AND TAC.N_TYPE=1";

            return TransactionHelper.ExecuteSql(sql);
        }

        /// <summary>
        /// 获取调拨数据
        /// </summary>
        /// <param name="slabwhCode">仓库编码</param>
        /// <param name="grd">钢种</param>
        /// <param name="std">执行标准</param>
        /// <param name="spec">规格</param>
        /// <returns></returns>
        public DataSet GetAllotData(string slabwhCode, string grd, string std, string spec)
        {
            List<OracleParameter> paras = new List<OracleParameter>();
            string sql = @"SELECT 
                                     TSM.C_STOVE,
                                     COUNT(TSM.C_ID) N_QUA,
                                     TSM.C_STL_GRD,
                                     TSM.C_STD_CODE,
                                     TSM.C_SPEC,
                                     TSM.C_MAT_CODE,
                                     TSM.C_MAT_NAME,
                                     TSM.D_WE_DATE,
                                     MAX(TAL.C_SLABWH_CODE)C_SLABWH_CODE 
                                     FROM  TSC_ALLOT_CENTER TAL
                                     LEFT JOIN  TSC_SLAB_MAIN TSM ON TSM.C_ID=TAL.C_SLAB_MAIN_ID
                                     WHERE TAL.C_SLABWH_CODE=:slabwhCode ";

            if (!string.IsNullOrWhiteSpace(grd))
            {
                sql += "  AND TSM.C_STL_GRD =:grd ";
                paras.Add(new OracleParameter() { ParameterName = ":grd", Value = grd });
            }

            if (!string.IsNullOrWhiteSpace(spec))
            {
                sql += "  AND   TSM.C_SPEC =:spec ";
                paras.Add(new OracleParameter() { ParameterName = ":spec", Value = spec });
            }

            if (!string.IsNullOrWhiteSpace(std))
            {
                sql += "   AND   TSM.C_STD_CODE =:std ";
                paras.Add(new OracleParameter() { ParameterName = ":std", Value = std });
            }

            sql += @"     AND TAL.N_TYPE=1
                                     GROUP BY 
                                     TSM.C_STOVE,
                                     TSM.C_STL_GRD,
                                     TSM.C_STD_CODE,
                                     TSM.C_SPEC,
                                     TSM.C_MAT_CODE,
                                     TSM.C_MAT_NAME,
                                     TSM.D_WE_DATE";
            paras.Add(new OracleParameter() { ParameterName = ":slabwhCode", Value = slabwhCode });
            return DbHelperOra.Query(sql, paras.ToArray());
        }



        /// <summary>
        /// 获取入库信息
        /// </summary>
        /// <param name="stove">炉号</param>
        /// <param name="num">支数</param>
        /// <param name="grd">钢种</param>
        /// <param name="std">执行标准</param>
        /// <param name="spec">规格</param>
        /// <param name="matCode">物料编码</param>
        /// <param name="slabwhCode">仓库编码</param>
        /// <returns></returns>
        public DataSet GetPutData(string stove, int num, string grd, string std, string spec, string matCode, string slabwhCode)
        {
            List<OracleParameter> paras = new List<OracleParameter>();
            string sql = @"SELECT * FROM TSC_ALLOT_CENTER TAC
                                    WHERE TAC.N_TYPE=1 ";

            if (!string.IsNullOrWhiteSpace(stove))
            {
                sql += " AND TAC.C_STOVE =:stove ";
                paras.Add(new OracleParameter() { ParameterName = ":stove", Value = stove });
            }

            if (!string.IsNullOrWhiteSpace(grd))
            {
                sql += " AND TAC.C_STL_GRD=:grd ";
                paras.Add(new OracleParameter() { ParameterName = ":grd", Value = grd });
            }

            if (!string.IsNullOrWhiteSpace(spec))
            {
                sql += " AND TAC.C_SPEC =:spec ";
                paras.Add(new OracleParameter() { ParameterName = ":spec", Value = spec });
            }

            if (!string.IsNullOrWhiteSpace(std))
            {
                sql += " AND TAC.C_STD_CODE =:std ";
                paras.Add(new OracleParameter() { ParameterName = ":std", Value = std });
            }

            if (!string.IsNullOrWhiteSpace(matCode))
            {
                sql += " AND TAC.C_MAT_CODE =:matcode ";
                paras.Add(new OracleParameter() { ParameterName = ":matcode", Value = matCode });
            }

            if (!string.IsNullOrWhiteSpace(slabwhCode))
            {
                sql += " AND TAC.C_SLABWH_CODE =:slabwhcode ";
                paras.Add(new OracleParameter() { ParameterName = ":slabwhcode", Value = slabwhCode });
            }

            sql += " AND ROWNUM <=:num  ";
            paras.Add(new OracleParameter() { ParameterName = ":num", Value = num });

            return DbHelperOra.Query(sql, paras.ToArray());
        }

        /// <summary>
        /// 调拨入库更新中间表
        /// </summary>
        /// <param name="dt">需要更新数据</param>
        /// <param name="slabwhCode">仓库编码</param>
        /// <param name="area">区域</param>
        /// <param name="loc">库位</param>
        /// <param name="tier">层</param>
        /// <returns></returns>
        public int AllotPutUpdateCenter(DataTable dt, string slabwhCode, string area, string loc, string tier)
        {
            List<OracleParameter> paras = new List<OracleParameter>();

            string sql = @"UPDATE  TSC_ALLOT_CENTER TAC
                                    SET TAC.N_TYPE=2 ";

            sql += "  ,TAC.C_SLABWH_CODE=:slabwhCode ";
            paras.Add(new OracleParameter() { ParameterName = ":slabwhCode", Value = slabwhCode });

            sql += "  ,TAC.D_MOD_DT=:t  ";
            paras.Add(new OracleParameter() { ParameterName = ":t", Value = DateTime.Now });

            sql += "  ,TAC.C_SLABWH_AREA_CODE=:area ";
            paras.Add(new OracleParameter() { ParameterName = ":area", Value = area });

            sql += "  ,TAC.C_SLABWH_LOC_CODE=:loc ";
            paras.Add(new OracleParameter() { ParameterName = ":loc", Value = loc });

            sql += "  ,TAC.C_SLABWH_TIER_CODE=:tier ";
            paras.Add(new OracleParameter() { ParameterName = ":tier", Value = tier });

            sql += " WHERE TAC.C_SLAB_MAIN_ID IN( ";
            if (dt != null && dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (i == dt.Rows.Count - 1)
                        sql += "'" + dt.Rows[i]["C_SLAB_MAIN_ID"] + "'";
                    else
                        sql += "'" + dt.Rows[i]["C_SLAB_MAIN_ID"] + "',";
                }
            }
            sql += ")   AND TAC.N_TYPE=1";

            return TransactionHelper.ExecuteSql(sql, paras.ToArray());
        }

        /// <summary>
        /// 调拨入库更新钢坯表
        /// </summary>
        /// <param name="dt">需要修改数据</param>
        /// <returns></returns>
        public int AllotPutUpdateSlab(DataTable dt, string slabwhCode, string area, string loc, string tier, string shift, string group)
        {
            List<OracleParameter> paras = new List<OracleParameter>();

            string sql = @"UPDATE TSC_SLAB_MAIN TSM
                                    SET TSM.C_MOVE_TYPE='NR'   ";

            sql += "  ,TSM.C_SLABWH_CODE=:slabwhCode ";
            paras.Add(new OracleParameter() { ParameterName = ":slabwhCode", Value = slabwhCode });

            sql += "  ,TSM.D_WE_DATE=:t  ";
            paras.Add(new OracleParameter() { ParameterName = ":t", Value = DateTime.Now });

            if (!string.IsNullOrWhiteSpace(shift))
            {
                sql += "  ,TSM.C_WE_SHIFT=:shift  ";
                paras.Add(new OracleParameter() { ParameterName = ":shift", Value = shift });
            }

            if (!string.IsNullOrWhiteSpace(group))
            {
                sql += "  ,TSM.C_WE_GROUP=:group ";
                paras.Add(new OracleParameter() { ParameterName = ":group", Value = group });
            }

            sql += "  ,TSM.C_SLABWH_AREA_CODE=:area ";
            paras.Add(new OracleParameter() { ParameterName = ":area", Value = area });

            sql += "  ,TSM.C_SLABWH_LOC_CODE=:loc ";
            paras.Add(new OracleParameter() { ParameterName = ":loc", Value = loc });

            sql += "  ,TSM.C_SLABWH_TIER_CODE=:tier ";
            paras.Add(new OracleParameter() { ParameterName = ":tier", Value = tier });

            sql += " WHERE TSM.C_ID IN( ";
            if (dt != null && dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (i == dt.Rows.Count - 1)
                        sql += "'" + dt.Rows[i]["C_SLAB_MAIN_ID"] + "'";
                    else
                        sql += "'" + dt.Rows[i]["C_SLAB_MAIN_ID"] + "',";
                }
            }
            sql += ") ";

            sql += " AND TSM.C_MOVE_TYPE ='M' ";

            return TransactionHelper.ExecuteSql(sql, paras.ToArray());
        }

        /// <summary>
        /// 入库信息
        /// </summary>
        /// <param name="slabwhCode"></param>
        /// <returns></returns>
        public DataSet GetPutData(string slabwhCode, DateTime start, DateTime end)
        {
            List<OracleParameter> paras = new List<OracleParameter>();
            string sql = @"SELECT 
                                    COUNT(TAL.C_ID) N_QUA,
                                    TAL.C_STOVE,
                                    TAL.C_STL_GRD,
                                    TAL.C_STD_CODE,
                                    TAL.C_SPEC,
                                    TAL.C_MAT_CODE,
                                    TAL.C_MAT_NAME,
                                    MAX(TAL.C_SLABWH_CODE)C_SLABWH_CODE,
                                    MAX(TAL.C_SLABWH_AREA_CODE)C_SLABWH_AREA_CODE,
                                    MAX(TAL.C_SLABWH_LOC_CODE)C_SLABWH_LOC_CODE,
                                    MAX(TAL.C_SLABWH_TIER_CODE)C_SLABWH_TIER_CODE,
                                    MAX(TAL.D_MOD_DT) D_MOD_DT
                                    FROM TSC_ALLOT_CENTER TAL 
                                    WHERE TAL.N_TYPE=2  ";
            sql += "  AND TAL.C_SLABWH_CODE=:slabwhCode ";

            sql += " AND  TAL.D_MOD_DT>to_date('" + start.ToString("yyyyMMdd") + "','yyyy-mm-dd') ";

            sql += " AND  TAL.D_MOD_DT<to_date('" + end.AddDays(1).ToString("yyyyMMdd") + "','yyyy-mm-dd') ";

            sql += @"        GROUP BY 
                                    TAL.C_STOVE,
                                    TAL.C_STL_GRD,
                                    TAL.C_STD_CODE,
                                    TAL.C_SPEC,
                                    TAL.C_MAT_CODE,
                                    TAL.C_MAT_NAME,
                                    TAL.D_MOD_DT
                                    ORDER BY TAL.D_MOD_DT";
            paras.Add(new OracleParameter() { ParameterName = ":slabwhCode", Value = slabwhCode });
            return DbHelperOra.Query(sql, paras.ToArray());
        }


        /// <summary>
        /// 获取需要分库的钢坯数据
        /// </summary>
        /// <param name="staID">连铸工位ID</param>
        /// <param name="strGZ">钢种</param>
        /// <param name="strStove">炉号</param>
        /// <param name="strGG">规格</param>
        /// <param name="strTimeStart">开始时间</param>
        /// <param name="strTimeEnd">结束时间</param>
        /// <returns></returns>
        public DataSet Get_FK_List(string staID, string strGZ, string strStove, string strGG, string strTimeStart, string strTimeEnd)
        {
            StringBuilder strSql = new StringBuilder();

            strSql.Append(" SELECT TSM.C_STOVE, COUNT(1) N_QUA, TSM.C_STL_GRD, TSM.C_STD_CODE, TSM.C_SPEC, TSM.C_MAT_CODE, TSM.C_MAT_NAME, TB.C_STA_DESC, TSM.N_LEN,TSM.C_SLABWH_CODE,SUM(TSM.N_WGT) AS N_WGT, MAX(TSM.D_CCM_DATE) AS D_CCM_DATE, MAX(TSM.C_CCM_SHIFT)AS C_CCM_SHIFT, MAX(TSM.C_CCM_GROUP)AS C_CCM_GROUP, MAX(TSM.C_CCM_EMP_ID)AS C_CCM_EMP_ID ");

            strSql.Append(" FROM TSC_SLAB_MAIN TSM INNER JOIN TB_STA TB ON TB.C_ID = TSM.C_STA_ID ");

            strSql.Append(" WHERE TSM.C_STOCK_STATE='F' and TSM.C_STA_ID = '" + staID + "' AND TSM.C_MOVE_TYPE = 'N' AND TSM.C_SLABWH_CODE IS NULL ");

            if (strTimeStart.Trim() != "" && strTimeEnd.Trim() != "")
            {
                strSql.Append(" AND TSM.D_CCM_DATE BETWEEN TO_DATE('" + strTimeStart + "', 'yyyy-mm-dd hh24:mi:ss') and TO_DATE('" + strTimeEnd + "', 'yyyy-mm-dd hh24:mi:ss') ");
            }

            if (strGZ.Trim() != "")
            {
                strSql.Append(" AND TSM.C_STL_GRD like '" + strGZ + "%' ");
            }

            if (strStove.Trim() != "")
            {
                strSql.Append(" AND TSM.C_STOVE like '" + strStove + "%' ");
            }

            if (strGG.Trim() != "")
            {
                strSql.Append(" AND TSM.C_SPEC like '" + strGG + "%' ");
            }

            strSql.Append("  GROUP BY TSM.C_STOVE, TSM.C_STL_GRD, TSM.C_STD_CODE, TSM.C_SPEC, TSM.C_MAT_CODE, TSM.C_MAT_NAME, TB.C_STA_DESC, TSM.N_LEN,TSM.C_SLABWH_CODE ");

            strSql.Append("  order by MAX(TSM.D_CCM_DATE),TSM.C_STOVE ");

            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取调拨的钢坯数据
        /// </summary>
        /// <param name="strGZ">钢种</param>
        /// <param name="strStove">炉号</param>
        /// <param name="strGG">规格</param>
        /// <param name="strKW">库位</param>
        /// <param name="strTimeStart">开始时间</param>
        /// <param name="strTimeEnd">结束时间</param>
        /// <returns></returns>
        public DataSet Get_DB_List(string strGZ, string strStove, string strGG, string strKW, string strTimeStart, string strTimeEnd)
        {
            StringBuilder strSql = new StringBuilder();

            strSql.Append(@" SELECT 
       TSM.C_SLABWH_TIER_CODE,
       TSM.C_SLABWH_LOC_CODE,
       TSM.C_SLABWH_CODE,
       TSM.C_SLABWH_AREA_CODE,
 (SELECT MAX(TO_NUMBER(TT.C_SLABWH_TIER_CODE))
          FROM TSC_SLAB_MAIN TT
         WHERE TT.C_SLABWH_LOC_CODE = TSM.C_SLABWH_LOC_CODE
           AND (  TT.C_MOVE_TYPE = 'M')) MAXTIER,
       (SELECT TS.C_SLABWH_NAME
          FROM TPB_SLABWH TS
         WHERE TS.C_SLABWH_CODE = TSM.C_SLABWH_CODE
           AND TS.N_STATUS = 1) C_SLABWH_CODE_NAME,
       (SELECT TSA.C_SLABWH_AREA_NAME
          FROM TPB_SLABWH_AREA TSA
         WHERE TSA.C_SLABWH_AREA_CODE = TSM.C_SLABWH_AREA_CODE
           AND TSA.N_STATUS = 1) C_SLABWH_AREA_CODE_NAME,
       (SELECT TST.C_SLABWH_LOC_NAME
          FROM TPB_SLABWH_LOC TST
         WHERE TST.C_SLABWH_LOC_CODE = TSM.C_SLABWH_LOC_CODE
           AND TST.N_STATUS = 1) C_SLABWH_LOC_CODE_NAME,
       TSM.C_STOVE,
       TSM.C_BATCH_NO,
       COUNT(1) N_QUA,
       TSM.C_STL_GRD,
       TSM.C_STD_CODE,
       TSM.C_SPEC,
       TSM.C_MAT_CODE,
       TSM.C_MAT_NAME,    
       TSM.N_LEN,     
       SUM(TSM.N_WGT) AS N_WGT,
       MAX(TSM.D_WL_DATE) AS D_WL_DATE,
       MAX(TSM.C_WL_SHIFT) AS C_WL_SHIFT,
       MAX(TSM.C_WL_GROUP) AS C_WL_GROUP,
       MAX(TSM.C_WL_EMP_ID) AS C_EMP_ID,
       TSM.C_ZKDH,
       TSM.C_ZKDHID,
       CASE TSM.C_SLAB_STATUS
         WHEN 'Y' THEN
          '是'
         ELSE
          '否'
       END AS C_SLAB_STATUS,
       CASE TSM.C_ISXM
         WHEN 'N' THEN
          '已修'
         ELSE
          '未修'
       END AS C_ISXM,
       TSM.C_XMGX,
       CASE TSM.C_QKP_STATE
         WHEN 'N' THEN
          '是'
         ELSE
          '否'
       END AS C_QKP_STATE,
       TSM.C_REMARK,
       MAX(TSM.C_WL_SHIFT) AS C_SHIFT,
       MAX(TSM.C_WL_GROUP) AS C_GROUP");

            strSql.Append(" FROM TSC_SLAB_MAIN TSM ");

            //strSql.Append(" WHERE TSM.C_STOCK_STATE='F' and TSM.C_MOVE_TYPE = 'M' ");
            strSql.Append(" WHERE  TSM.C_MOVE_TYPE = 'M' ");
            if (strTimeStart.Trim() != "" && strTimeEnd.Trim() != "")
            {
                strSql.Append(" AND TSM.D_CCM_DATE BETWEEN TO_DATE('" + strTimeStart + "', 'yyyy-mm-dd hh24:mi:ss') and TO_DATE('" + strTimeEnd + "', 'yyyy-mm-dd hh24:mi:ss') ");
            }

            if (strKW.Trim() != "")
            {
                strSql.Append(" AND TSM.C_SLABWH_CODE = '" + strKW + "' ");
            }

            if (strGZ.Trim() != "")
            {
                strSql.Append(" AND upper(TSM.C_STL_GRD) like upper('%" + strGZ + "%') ");
            }

            if (strStove.Trim() != "")
            {
                strSql.Append(" AND (TSM.C_STOVE like '%" + strStove + "%' or TSM.C_BATCH_NO like '%" + strStove + "%' ) ");
            }

            if (strGG.Trim() != "")
            {
                strSql.Append(" AND TSM.C_SPEC like '%" + strGG + "%' ");
            }

            strSql.Append(@"  GROUP BY
          TSM.C_SLABWH_CODE,
          TSM.C_SLABWH_AREA_CODE,
          TSM.C_SLABWH_LOC_CODE,
          TSM.C_SLABWH_TIER_CODE,
          TSM.C_STOVE,
          TSM.C_BATCH_NO,
          TSM.C_STL_GRD,
          TSM.C_STD_CODE,
          TSM.C_SPEC,
          TSM.C_MAT_CODE,
          TSM.C_MAT_NAME,         
          TSM.N_LEN,
          TSM.C_ZKDH,
          TSM.C_ZKDHID,
          TSM.C_ZKDHID,
          TSM.C_SLAB_STATUS,
          TSM.C_ISXM,
          TSM.C_XMGX,
          TSM.C_QKP_STATE,
          TSM.C_REMARK          
 ORDER BY  TO_NUMBER(NVL(TSM.C_SLABWH_TIER_CODE, '0')) DESC ");



            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取库存钢坯数据
        /// </summary>
        /// <param name="slabwhCode">仓库代码</param>
        /// <param name="strGZ">钢种</param>
        /// <param name="strStove">炉号</param>
        /// <param name="strGG">规格</param>
        /// <param name="strTimeStart">开始时间</param>
        /// <param name="strTimeEnd">结束时间</param>
        /// <returns></returns>
        public DataSet Get_KC_List(string slabwhCode, string strGZ, string strStove, string strGG, string strTimeStart, string strTimeEnd)
        {
            StringBuilder strSql = new StringBuilder();

            strSql.Append(@" SELECT TSM.C_SLABWH_TIER_CODE,
       TSM.C_SLABWH_LOC_CODE,
       TSM.C_SLABWH_CODE,
       TSM.C_SLABWH_AREA_CODE,
       MAX(TSM.D_ESC_DATE) AS DEC_DATE,
       MAX(TSM.N_HL_TIME) AS HL_TIME,
       TSM.C_STOVE,
       TSM.C_BATCH_NO,
       COUNT(1) N_QUA,
       TSM.C_STL_GRD,
       TSM.C_STD_CODE,
       TSM.C_SPEC,
       TSM.C_MAT_CODE,
       TSM.C_MAT_NAME,
       TSM.N_LEN,
       (SELECT max(TS.C_SLABWH_NAME)
          FROM TPB_SLABWH TS
         WHERE TS.C_SLABWH_CODE = TSM.C_SLABWH_CODE
           AND TS.N_STATUS = 1) C_SLABWH_CODE_NAME,
       (SELECT max(TSA.C_SLABWH_AREA_NAME)
          FROM TPB_SLABWH_AREA TSA
         WHERE TSA.C_SLABWH_AREA_CODE = TSM.C_SLABWH_AREA_CODE
           AND TSA.N_STATUS = 1) C_SLABWH_AREA_CODE_NAME,
       (SELECT max(TST.C_SLABWH_LOC_NAME)
          FROM TPB_SLABWH_LOC TST
         WHERE TST.C_SLABWH_LOC_CODE = TSM.C_SLABWH_LOC_CODE
           AND TST.N_STATUS = 1) C_SLABWH_LOC_CODE_NAME,
       TSM.C_SLABWH_TIER_CODE,
       (SELECT MAX(TO_NUMBER(TT.C_SLABWH_TIER_CODE))
          FROM TSC_SLAB_MAIN TT
         WHERE TT.C_SLABWH_LOC_CODE = TSM.C_SLABWH_LOC_CODE
           AND (TT.C_MOVE_TYPE = 'E')) MAXTIER,
       SUM(TSM.N_WGT) AS N_WGT,
       MAX(TSM.D_WE_DATE) AS D_WE_DATE,
       MAX(TSM.C_WE_SHIFT) AS C_WE_SHIFT,
       MAX(TSM.C_WE_GROUP) AS C_WE_GROUP,
       MAX(TSM.C_WE_EMP_ID) AS C_EMP_ID,
       CASE TSM.C_SLAB_STATUS
         WHEN 'Y' THEN
          '是'
         ELSE
          '否'
       END AS C_SLAB_STATUS,
       CASE TSM.C_ISXM
         WHEN 'N' THEN
          '已修'
         ELSE
          '未修'
       END AS C_ISXM,
       TSM.C_XMGX,
       CASE TSM.C_QKP_STATE
         WHEN 'N' THEN
          '是'
         ELSE
          '否'
       END AS C_QKP_STATE,
       TSM.C_REMARK,
       MAX(TSM.C_WE_SHIFT) AS C_SHIFT,
       MAX(TSM.C_WE_GROUP) AS C_GROUP,
       CASE TSM.C_HL
         WHEN 'N' THEN
          '否'
         ELSE
          '是'
       END AS C_HL,
       TSM.C_JUDGE_LEV_ZH_PEOPLE  ");

            strSql.Append(" FROM TSC_SLAB_MAIN TSM ");

            strSql.Append(" WHERE TSM.C_STOCK_STATE='F' AND TSM.C_SLABWH_CODE = '" + slabwhCode + "' AND TSM.C_MOVE_TYPE = 'E' ");

            if (strTimeStart.Trim() != "" && strTimeEnd.Trim() != "")
            {
                strSql.Append(" AND TSM.D_CCM_DATE BETWEEN TO_DATE('" + strTimeStart + "', 'yyyy-mm-dd hh24:mi:ss') and TO_DATE('" + strTimeEnd + "', 'yyyy-mm-dd hh24:mi:ss') ");
            }

            if (strGZ.Trim() != "")
            {
                strSql.Append(" AND upper(TSM.C_STL_GRD) like upper('" + strGZ + "%') ");
            }

            if (strStove.Trim() != "")
            {
                strSql.Append(" AND (TSM.C_STOVE like '" + strStove + "%' OR TSM.C_BATCH_NO like '" + strStove + "%') ");
            }

            if (strGG.Trim() != "")
            {
                strSql.Append(" AND TSM.C_SPEC like '" + strGG + "%' ");
            }

            strSql.Append(@"   GROUP BY TSM.C_STOVE,
          TSM.C_BATCH_NO,
          TSM.C_STL_GRD,
          TSM.C_STD_CODE,
          TSM.C_SPEC,
          TSM.C_MAT_CODE,
          TSM.C_MAT_NAME,
          TSM.N_LEN,
          TSM.C_SLABWH_CODE,
          TSM.C_SLABWH_AREA_CODE,
          TSM.C_SLABWH_LOC_CODE,
          TSM.C_SLABWH_TIER_CODE,
          TSM.C_SLAB_STATUS,
          TSM.C_ISXM,
          TSM.C_XMGX,
          TSM.C_QKP_STATE,
          TSM.C_REMARK,
          TSM.C_HL,
          TSM.C_JUDGE_LEV_ZH_PEOPLE ");

            strSql.Append("  ORDER BY TO_NUMBER(NVL(TSM.C_SLABWH_TIER_CODE, '0')) DESC ");

            return DbHelperOra.Query(strSql.ToString());
        }


        /// <summary>
        /// 获取库存钢坯数据(倒垛)
        /// </summary>
        /// <param name="slabwhCode">仓库代码</param>
        /// <param name="strGZ">钢种</param>
        /// <param name="strStove">炉号</param>
        /// <param name="strGG">规格</param>
        /// <param name="strTimeStart">开始时间</param>
        /// <param name="strTimeEnd">结束时间</param>
        /// <returns></returns>
        public DataSet Get_DD_KC_List(string slabwhCode, string strGZ, string strStove, string strGG, string strTimeStart, string strTimeEnd)
        {
            StringBuilder strSql = new StringBuilder();

            strSql.Append(" SELECT (select max(tsc.c_slabwh_tier_code)as c_slabwh_loc_code from tsc_slab_main tsc where tsc.c_slabwh_loc_code=tsm.c_slabwh_loc_code ) as max_loccode, TSM.C_STOVE,TSM.C_BATCH_NO, COUNT(1) N_QUA, TSM.C_STL_GRD, TSM.C_STD_CODE, TSM.C_SPEC, TSM.C_MAT_CODE, TSM.C_MAT_NAME, TB.C_STA_DESC, TSM.N_LEN,TSM.C_SLABWH_CODE,TSM.C_SLABWH_AREA_CODE, TSM.C_SLABWH_LOC_CODE, TSM.C_SLABWH_TIER_CODE, SUM(TSM.N_WGT) AS N_WGT, MAX(TSM.D_WE_DATE) AS D_WE_DATE, MAX(TSM.C_WE_SHIFT)AS C_WE_SHIFT, MAX(TSM.C_WE_GROUP)AS C_WE_GROUP, MAX(TSM.C_WE_EMP_ID)AS C_WE_EMP_ID,MAX(TSU.C_NAME) AS C_WE_EMP_NAME, CASE TSM.C_SLAB_STATUS  WHEN 'Y' THEN '是' ELSE '否' END  AS C_SLAB_STATUS ,   CASE TSM.C_ISXM  WHEN 'N' THEN    '已修'    ELSE  '未修'   END AS C_ISXM,TSM.C_XMGX,CASE TSM.C_QKP_STATE  WHEN 'N' THEN  '是'  ELSE  '否' END AS C_QKP_STATE,     MAX(TSM.C_WE_SHIFT) AS C_SHIFT,MAX(TSM.C_WE_GROUP) AS C_GROUP,   MAX(TSM.C_WE_GROUP) AS C_GROUP,  (SELECT TS.C_SLABWH_NAME FROM TPB_SLABWH TS WHERE TS.C_SLABWH_CODE= TSM.C_SLABWH_CODE AND TS.N_STATUS=1)C_SLABWH_CODE_NAME, (SELECT TSA.C_SLABWH_AREA_NAME FROM TPB_SLABWH_AREA TSA WHERE TSA.C_SLABWH_AREA_CODE= TSM.C_SLABWH_AREA_CODE AND TSA.N_STATUS=1)C_SLABWH_AREA_CODE_NAME,   (SELECT TST.C_SLABWH_LOC_NAME FROM TPB_SLABWH_LOC TST WHERE TST.C_SLABWH_LOC_CODE= TSM.C_SLABWH_LOC_CODE AND TST.N_STATUS=1)C_SLABWH_LOC_CODE_NAME,   substr(TSM.C_SLABWH_TIER_CODE,-2,3)C_SLABWH_TIER_CODE_NAME,TSM.C_REMARK");

            strSql.Append(" FROM TSC_SLAB_MAIN TSM INNER JOIN TB_STA TB ON TB.C_ID = TSM.C_STA_ID LEFT JOIN TS_USER TSU ON TSU.C_ID = TSM.C_WE_EMP_ID ");

            strSql.Append(" WHERE TSM.C_STOCK_STATE='F' and TSM.C_SLABWH_CODE = '" + slabwhCode + "' AND TSM.C_MOVE_TYPE = 'E' ");

            if (strTimeStart.Trim() != "" && strTimeEnd.Trim() != "")
            {
                strSql.Append(" AND TSM.D_CCM_DATE BETWEEN TO_DATE('" + strTimeStart + "', 'yyyy-mm-dd hh24:mi:ss') and TO_DATE('" + strTimeEnd + "', 'yyyy-mm-dd hh24:mi:ss') ");
            }

            if (strGZ.Trim() != "")
            {
                strSql.Append(" AND upper(TSM.C_STL_GRD) like upper('%" + strGZ + "%') ");
            }

            if (strStove.Trim() != "")
            {
                strSql.Append(" AND (TSM.C_STOVE like '%" + strStove + "%' or TSM.C_BATCH_NO like '%" + strStove + "%') ");
            }

            if (strGG.Trim() != "")
            {
                strSql.Append(" AND TSM.C_SPEC like '%" + strGG + "%' ");
            }

            strSql.Append("  GROUP BY TSM.C_STOVE,TSM.C_BATCH_NO, TSM.C_STL_GRD, TSM.C_STD_CODE, TSM.C_SPEC, TSM.C_MAT_CODE, TSM.C_MAT_NAME, TB.C_STA_DESC, TSM.N_LEN,TSM.C_SLABWH_CODE,TSM.C_SLABWH_AREA_CODE, TSM.C_SLABWH_LOC_CODE, TSM.C_SLABWH_TIER_CODE,TSM.C_ZKDHID,TSM.C_SLAB_STATUS, TSM.C_ISXM ,TSM.C_XMGX,TSM.C_QKP_STATE,TSM.C_REMARK ");

            strSql.Append(" order by  C_SLABWH_LOC_CODE_NAME, to_number(nvl(tsm.C_SLABWH_TIER_CODE,'0')) desc ");

            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取缓冷坑理论出坑时间
        /// </summary>
        /// <param name="slablocCode">货位</param>
        /// <returns></returns>
        public DataSet Get_DB_HL_TIME(string slablocCode)
        {
            StringBuilder strSql = new StringBuilder();

            strSql.Append(" select MAX(MAX_HL)HL_TIME from (SELECT  max(to_char(TSM.D_ESC_DATE+TSM.N_HL_TIME/24,'yyyy-mm-dd HH24:MI:SS'))as MAX_HL, max(TSM.D_ESC_DATE)AS DEC_DATE , MAX( TSM.N_HL_TIME) AS HL_TIME, TSM.C_STOVE,  t1.c_slabwh_name,  t2.c_slabwh_loc_CODE   FROM TSC_SLAB_MAIN TSM  INNER JOIN TB_STA TB ON TB.C_ID = TSM.C_STA_ID    left join tpb_slabwh t1 on tsm.c_slabwh_code = t1.c_slabwh_code left join tpb_slabwh_loc t2 on tsm.c_slabwh_loc_code = t2.c_slabwh_loc_code WHERE  TSM.C_MOVE_TYPE = 'E' and t2.c_slabwh_type ='缓冷坑' GROUP BY TSM.C_STOVE, t1.c_slabwh_name, t2.c_slabwh_loc_CODE, TSM.C_BATCH_NO, TSM.C_STL_GRD, TSM.C_STD_CODE, TSM.C_SPEC, TSM.C_MAT_CODE, TSM.C_MAT_NAME, TB.C_STA_DESC, TSM.N_LEN, TSM.C_SLABWH_CODE, TSM.C_SLAB_STATUS, TSM.C_ISXM, TSM.C_XMGX, TSM.C_QKP_STATE, TSM.C_SLABWH_AREA_CODE, TSM.C_REMARK order by MAX(TSM.D_CCM_DATE), TSM.C_STOVE)a1 WHERE A1.C_SLABWH_LOC_CODE='" + slablocCode + "' ");

            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update_Trans(string strResult, string strUserID, Mod_TQC_COMPRE_SLAB model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("UPDATE TSC_SLAB_MAIN T SET T.C_JUDGE_LEV_ZH = '" + strResult + "', T.C_IS_QR = 'Y', T.C_QR_USER = '" + strUserID + "', T.D_QR_DATE = sysdate,T.C_IS_TB='Y',T.C_IS_PD='Y' WHERE T.C_DESIGN_NO = '" + model.C_DESIGN_NO + "' AND T.C_STL_GRD = '" + model.C_STL_GRD + "' AND nvl(T.C_SPEC,'0') = nvl('" + model.C_SPEC + "','0') AND T.C_STD_CODE = '" + model.C_STD_CODE + "' AND T.C_MAT_CODE = '" + model.C_MAT_CODE + "' AND T.C_MAT_TYPE = '" + model.C_RESULT_FACE + "' AND NVL(T.C_REASON_NAME,'0') = NVL('" + model.C_REASON_NAME + "','0') AND T.C_STOVE = '" + model.C_STOVE + "' ");


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
        /// 获得数据列表-炉号-库位
        /// </summary> 
        /// <param name="C_SLABWH_LOC_CODE">库位</param>
        /// <returns></returns>
        public DataSet GetList_KW_Group(string C_SLABWH_LOC_CODE)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  a.c_sta_desc,t.C_STA_ID,t.C_STOVE,t.C_STL_GRD,t.C_SPEC,t.N_LEN,t.N_WGT,t.C_STD_CODE,t.C_MAT_CODE,t.C_MAT_NAME,MAX(D_WE_DATE) ,count(1)COU  ");
            strSql.Append(" FROM TSC_SLAB_MAIN t left join tb_sta a on t.c_sta_id=a.c_id where t.C_MOVE_TYPE = 'E' ");

            if (C_SLABWH_LOC_CODE.Trim() != "")
            {
                strSql.Append(" and  C_SLABWH_LOC_CODE = '" + C_SLABWH_LOC_CODE + "' ");
            }
            strSql.Append("  group by   t.C_STA_ID,t.C_STOVE,t.C_STL_GRD,t.C_SPEC,t.N_LEN,t.N_WGT,t.C_STD_CODE,t.C_MAT_CODE,t.C_MAT_NAME ,a.c_sta_desc");

            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 获得数据列表- 实绩信息
        /// </summary>
        /// <param name="begin">开始时间</param>
        /// <param name="end">结束时间</param>
        /// <param name="C_STOVE">炉号</param> 
        /// <param name="stl">钢种</param>
        /// <param name="std">执行标准</param>
        /// <returns></returns>
        public DataSet GetList_SJ_Group(DateTime begin, DateTime end, string C_STOVE, string stl, string std)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  a.c_sta_desc,b.c_slabwh_name,t.C_STA_ID,t.C_STOVE,t.C_STL_GRD,t.C_SPEC,t.N_LEN,t.N_WGT,t.C_STD_CODE,t.C_MAT_CODE,t.C_MAT_NAME,MAX(D_WE_DATE)DT,count(1)COU,t.C_SLABWH_CODE,t.C_MAT_TYPE,t.C_JUDGE_LEV_ZH ,t.c_remark, t.c_we_shift, t.c_we_group,t.c_we_shift C_SHIFT, t.c_we_group C_GROUP ");
            strSql.Append("  FROM TSC_SLAB_MAIN t left join tb_sta a on t.c_sta_id=a.c_id left join tpb_slabwh b on t.c_slabwh_code = b.c_slabwh_code  where t.C_MOVE_TYPE = 'E' ");

            if (begin != null && end != null)
            {
                strSql.Append("and t.D_WE_DATE between to_date('" + Convert.ToDateTime(begin) + "','yyyy-mm-dd hh24:mi:ss') and to_date('" + Convert.ToDateTime(end) + "','yyyy-mm-dd hh24:mi:ss') ");
            }
            if (!string.IsNullOrEmpty(C_STOVE))
            {
                strSql.Append(" and  t.C_STOVE like '%" + C_STOVE + "%' ");
            }
            if (!string.IsNullOrEmpty(stl))
            {
                strSql.Append(" and  t.C_STL_GRD like '%" + stl + "%' ");
            }
            if (!string.IsNullOrEmpty(std))
            {
                strSql.Append(" and  t.C_STD_CODE like '%" + std + "%' ");
            }
            strSql.Append("  group by   t.C_STA_ID,b.c_slabwh_name,t.C_STOVE,t.C_STL_GRD,t.C_SPEC,t.N_LEN,t.N_WGT,t.C_STD_CODE,t.C_MAT_CODE,t.C_MAT_NAME ,a.c_sta_desc,t.c_we_shift, t.c_we_group,t.C_SLABWH_CODE,t.C_MAT_TYPE,t.C_JUDGE_LEV_ZH,t.c_remark ");

            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取转库单详细信息
        /// </summary>
        /// <param name="C_ZKDH">转库单号</param>
        /// <param name="C_ZKDHID">转库单ID</param>
        /// <returns></returns>
        public DataSet Get_ZK_List_Trans(string C_ZKDH, string C_ZKDHID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT TA.C_STOVE, TB.C_BATCH_NO, TA.C_SPEC, TA.C_STOCK_CODE, TA.C_STOCK_CODE_TO, TA.C_STL_GRD, TA.C_STD_CODE, TA.C_MAT_CODE,TA.C_MAT_NAME, NVL(TB.C_JUDGE_LEV_ZH, TB.C_MAT_TYPE) AS ZLDJ, TA.C_ZKDH, TA.C_ZKDHID, count(1) as qua, sum(TA.n_wgt) as wgt ");

            strSql.Append("   FROM TSC_SLAB_MOVE TA INNER JOIN TSC_SLAB_MAIN TB ON TA.C_SLAB_MAIN_ID = TB.C_ID ");

            strSql.Append("   where TA.C_ZKDH='" + C_ZKDH + "' and TA.C_ZKDHID='" + C_ZKDHID + "' AND TA.c_Move_Type='M' ");

            strSql.Append("  group by TA.C_STOVE, TA.C_SPEC, TA.C_STOCK_CODE,TB.C_BATCH_NO, TA.C_STOCK_CODE_TO, TA.C_STL_GRD, TA.C_STD_CODE, TA.C_MAT_CODE,TA.C_MAT_NAME, NVL(TB.C_JUDGE_LEV_ZH, TB.C_MAT_TYPE), TA.C_ZKDH, TA.C_ZKDHID");

            return TransactionHelper.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取转库单详细信息
        /// </summary>
        /// <param name="C_ZKDH">转库单号</param>
        /// <param name="C_ZKDHID">转库单ID</param>
        /// <returns></returns>
        public DataSet Get_RK_List(string C_ZKDH, string C_ZKDHID, int rownum)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT TB.C_STOVE, TB.C_BATCH_NO,TB.C_SPEC, TA.C_STOCK_CODE, TA.C_STOCK_CODE_TO, TB.C_STL_GRD, TB.C_STD_CODE, TB.C_MAT_CODE,       TB.C_MAT_NAME, NVL(TB.C_JUDGE_LEV_ZH, TB.C_MAT_TYPE) AS ZLDJ, TB.C_ZKDH, TB.C_ZKDHID, count(1) as qua, sum(tb.n_wgt) as wgt ");

            strSql.Append("   FROM TSC_SLAB_MOVE TA INNER JOIN TSC_SLAB_MAIN TB ON TA.C_SLAB_MAIN_ID = TB.C_ID ");

            strSql.Append("   where Ta.C_ZKDH='" + C_ZKDH + "' and Ta.C_ZKDHID='" + C_ZKDHID + "' AND TA.c_Move_Type='M' and  ROWNUM <=" + rownum + " ");

            strSql.Append("  group by TB.C_STOVE,TB.C_BATCH_NO,TB.C_SPEC, TA.C_STOCK_CODE, TA.C_STOCK_CODE_TO, TB.C_STL_GRD, TB.C_STD_CODE, TB.C_MAT_CODE, TB.C_MAT_NAME, NVL(TB.C_JUDGE_LEV_ZH, TB.C_MAT_TYPE), TB.C_ZKDH, TB.C_ZKDHID ");

            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 通过炉号获取物料编码
        /// </summary>
        /// <param name="stove"></param>
        /// <returns></returns>
        public Object GetMatCode(string stove)
        {
            string sql = @"SELECT MAX(C_MAT_CODE)C_MAT_CODE FROM TSC_SLAB_MAIN T
                                    WHERE T.C_STOVE='" + stove + "'";
            return DbHelperOra.GetSingle(sql);
        }


        /// <summary>
        ///返回NC测试库钢坯库存数据
        /// </summary>
        /// <returns></returns>
        public DataTable GetNCCSGPK()
        {
            //string strSql = @"SELECT IC_ONHANDNUM.NONHANDNUM AS 数量,
            //      IC_ONHANDNUM.NONHANDASTNUM AS 辅数量,
            //      IC_ONHANDNUM.VFREE1,
            //      IC_ONHANDNUM.VFREE2,
            //      IC_ONHANDNUM.VFREE3,
            //      IC_ONHANDNUM.VLOT AS 批次号,  
            //      '' 连铸炉号,
            //      BD_INVBASDOC.INVNAME,
            //      BD_INVBASDOC.INVCODE,
            //      BD_INVBASDOC.INVSPEC,
            //      BD_INVBASDOC.INVTYPE,
            //      BD_STORDOC.STORCODE,
            //      BD_STORDOC.STORNAME
            // FROM IC_ONHANDNUM @CAP_NC_CS, BD_INVBASDOC@CAP_NC_CS, BD_STORDOC @CAP_NC_CS
            //WHERE IC_ONHANDNUM.CINVBASID = BD_INVBASDOC.PK_INVBASDOC
            //  AND IC_ONHANDNUM.CWAREHOUSEID = BD_STORDOC.PK_STORDOC
            //  AND IC_ONHANDNUM.PK_CORP = '1001'
            //  AND IC_ONHANDNUM.DR = 0
            //  AND BD_INVBASDOC.INVCODE LIKE '6%'
            //  AND IC_ONHANDNUM.NONHANDNUM <> 0
            //  AND IC_ONHANDNUM.VFREE1 IS NOT NULL
            //  AND IC_ONHANDNUM.VFREE2 IS NOT NULL
            //  AND IC_ONHANDNUM.VLOT IS NOT NULL  AND IC_ONHANDNUM.NONHANDASTNUM>0 ";

            string strSql = " select * from V_ONHAND @CAP_NC_CS t ";
            return DbHelperOra.Query(strSql.ToString()).Tables[0];
        }


        /// <summary>
        /// 获取NC钢坯库数据
        /// </summary>
        /// <returns></returns>
        public DataTable GetNCGPK()
        {
            string strSql = "select * from XGERP50.V_ONHAND@CAP_ERP t ";
            return DbHelperOra.Query(strSql.ToString()).Tables[0];
        }

        /// <summary>
        /// 获取NC钢坯库数据
        /// </summary>
        /// <returns></returns>
        public DataTable GetNCGPK(string C_BATCH_NO, string C_STOVE, string C_STL_GRD, string C_MAT_CODE, string C_SLABWH_CODE, string C_ZYX1, string C_ZYX2)
        {
            string strSql = "SELECT *  FROM XGERP50.V_ONHAND@CAP_ERP T WHERE nvl(T.批次号,'0') = '" + C_BATCH_NO + "'   AND T.连铸炉号 = '" + C_STOVE + "'   AND T.INVTYPE = '" + C_STL_GRD + "'   AND T.INVCODE = '" + C_MAT_CODE + "'   AND T.STORCODE = '" + C_SLABWH_CODE + "'   AND T.VFREE1 = '" + C_ZYX1 + "'   AND T.VFREE2 = '" + C_ZYX2 + "' ";
            return DbHelperOra.Query(strSql.ToString()).Tables[0];

        }

        /// <summary>
        /// 获取炼钢记号
        /// </summary>
        public string Get_LGJH(string stove)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select max(C_LGJH) FROM TSC_SLAB_MAIN where C_STOVE ='" + stove + "' AND C_BATCH_NO IS NULL ");

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
        /// 获取钢坯数据状态
        /// </summary>
        /// <param name="gzlx">钢种类型</param>
        /// <param name="wlh">物料号</param>
        /// <param name="gz">钢种</param>
        /// <param name="zxbz">执行标准</param>
        /// <param name="lh">炉号</param> 
        /// <param name="ck">仓库</param>
        /// <param name="zt">状态</param>
        /// <param name="hlzt">缓冷状态</param>
        /// <param name="xmzt">修磨状态</param>
        /// <param name="pdzt">判断状态</param>
        /// <returns></returns>
        public DataSet GetSJ(string gzlx, string wlh, string gz, string zxbz, string lh, string ck, string zt, string hlzt, string xmzt, string pdzt)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from V_SLAB_KC t WHERE 1=1");
            if (gzlx != "全部")
            {
                strSql.Append(" AND C_SLAB_TYPE LIKE '%" + gzlx + "%'");
            }
            if (!string.IsNullOrEmpty(wlh))
            {
                strSql.Append(" AND C_MAT_CODE LIKE '%" + wlh + "%'");
            }
            if (!string.IsNullOrEmpty(gz))
            {
                strSql.Append(" AND upper(C_STL_GRD) = upper('" + gz + "')");
            }
            if (!string.IsNullOrEmpty(zxbz))
            {
                strSql.Append(" AND C_STD_CODE LIKE '%" + zxbz + "%'");
            }
            if (!string.IsNullOrEmpty(lh))
            {
                strSql.Append(" AND C_STOVE LIKE '%" + lh + "%' or C_BATCH_NO LIKE '%" + lh + "%' ");
            }
            if (ck != "全部")
            {
                strSql.Append(" AND C_SLABWH_CODE = '" + ck + "'");
            }
            if (zt != "全部")
            {
                strSql.Append(" AND C_MOVE_TYPE = '" + zt + "'");
            }
            if (xmzt != "全部")
            {
                strSql.Append(" AND C_ISXM = '" + xmzt + "'");
            }
            if (hlzt != "全部")
            {
                strSql.Append(" AND C_HL_TYPE = '" + hlzt + "'");
            }
            if (pdzt != "全部")
            {
                strSql.Append(" AND C_STOCK_STATE = '" + pdzt + "'");
            }

            strSql.Append(" ORDER BY C_STL_GRD, C_STOVE ");
            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 修改钢坯状态
        /// </summary>
        /// <param name="list">List<CommonKC>通用库存处理类</param>
        /// <param name="status">状态</param>
        /// <returns>0失败1成功</returns>
        public int UPSLABSTATUS(List<CommonKC> list, string fydh, string status)
        {
            TransactionHelper.BeginTransaction();
            foreach (CommonKC item in list)
            {
                StringBuilder strSql = new StringBuilder();
                strSql.Append("UPDATE TSC_SLAB_MAIN   SET C_MOVE_TYPE='" + status + "',C_FYDH='" + fydh + "' WHERE C_MOVE_TYPE='E'");
                if (item.mat.Trim() != "")
                {
                    strSql.Append(" and C_MAT_CODE='" + item.mat + "'");
                }
                if (item.ck.Trim() != "")
                {
                    strSql.Append(" and C_SLABWH_CODE='" + item.ck + "'");
                }
                if (item.qy.Trim() != "")
                {
                    strSql.Append(" and C_SLABWH_AREA_CODE='" + item.qy + "'");
                }
                if (item.kw.Trim() != "")
                {
                    strSql.Append(" and C_SLABWH_LOC_CODE='" + item.kw + "'");
                }
                if (item.batch.Trim() != "")
                {
                    strSql.Append(" and C_BATCH_NO='" + item.batch + "'");
                }
                if (item.stove.Trim() != "")
                {
                    strSql.Append(" and C_STOVE='" + item.stove + "'");
                }
                strSql.Append(" and ROWNUM<='" + item.num + "'");
                if (TransactionHelper.ExecuteSql(strSql.ToString()) != item.num)
                {
                    TransactionHelper.RollBack();
                    return 0;
                }
            }
            TransactionHelper.Commit();
            return 1;
        }
        /// <summary>
        /// 检测库存是否变更
        /// </summary>
        /// <param name="mat">物料号</param>
        /// <param name="ck">仓库</param>
        /// <param name="ckarea">区域</param>
        /// <param name="ckloc">库位</param>
        /// <param name="stove">炉号</param>
        /// <param name="batch">批号</param>
        /// <returns></returns>
        public int CKKC(string mat, string ck, string stove, string batch)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT count(1) N_NUM FROM TSC_SLAB_MAIN WHERE C_MOVE_TYPE='E'");
            if (mat.Trim() != "")
            {
                strSql.Append(" and C_MAT_CODE='" + mat + "'");
            }
            if (ck.Trim() != "")
            {
                strSql.Append(" and C_SLABWH_CODE='" + ck + "'");
            }
            if (batch.Trim() != "")
            {
                strSql.Append(" and C_BATCH_NO='" + batch + "'");
            }
            if (stove.Trim() != "")
            {
                strSql.Append(" and C_STOVE='" + stove + "'");
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
        /// 数据盘点差量1
        /// </summary>
        /// <returns></returns>
        public DataTable Get_MINUS1()
        {
            string sql = @"SELECT 
       T.N_QUA,
       T.C_BATCH_NO,
       T.C_STOVE,
       T.C_STL_GRD,
       T.C_MAT_CODE,
       round(T.N_WGT,4) N_WGT,
       T.C_SLABWH_CODE,
       T.C_ZYX1,
       T.C_ZYX2
  FROM TSC_SLAB_NC T
 WHERE T.C_PLAN_ID = 'NC正式库'
MINUS
SELECT 
       SUM(T.N_QUA) N_QUA,
       T.C_BATCH_NO,
       T.C_STOVE,
       T.C_STL_GRD,
       T.C_MAT_CODE,
       round(SUM(T.N_WGT),4) N_WGT,
       T.C_SLABWH_CODE,
       T.C_ZYX1,
       T.C_ZYX2
  FROM TSC_SLAB_MAIN T
 WHERE T.C_PLAN_ID = 'NC正式库' and C_MOVE_TYPE IN ('E','M','DZ','NP','R','DX')
 GROUP BY T.C_PLAN_ID,
          T.C_BATCH_NO,
          T.C_STOVE,
          T.C_STL_GRD,
          T.C_STD_CODE,
          T.C_MAT_CODE,
          T.C_SLABWH_CODE,
          T.C_ZYX1,
          T.C_ZYX2";
            return DbHelperOra.Query(sql).Tables[0];
        }


        /// <summary>
        /// 数据盘点差量1
        /// </summary>
        /// <returns></returns>
        public DataTable Get_MINUS2()
        {
            string sql = @"SELECT SUM(T.N_QUA) N_QUA,
       T.C_BATCH_NO,
       T.C_STOVE,
       T.C_STL_GRD,
       T.C_MAT_CODE,
       round(SUM(T.N_WGT),4) N_WGT,
      
       T.C_SLABWH_CODE,
       T.C_ZYX1,
       T.C_ZYX2
  FROM TSC_SLAB_MAIN T
 WHERE T.C_PLAN_ID = 'NC正式库' and C_MOVE_TYPE  IN ('E','M','DZ','NP','R','DX')
 GROUP BY T.C_PLAN_ID,
          T.C_BATCH_NO,
          T.C_STOVE,
          T.C_STL_GRD,
          T.C_STD_CODE,
          T.C_MAT_CODE,
          T.C_SLABWH_CODE,
          T.C_ZYX1,
          T.C_ZYX2
MINUS
SELECT 
       T.N_QUA,
       T.C_BATCH_NO,
       T.C_STOVE,
       T.C_STL_GRD,
       T.C_MAT_CODE,
       round(T.N_WGT,4) N_WGT,
       T.C_SLABWH_CODE,
       T.C_ZYX1,
       T.C_ZYX2
  FROM TSC_SLAB_NC T
 WHERE T.C_PLAN_ID = 'NC正式库'";
            return DbHelperOra.Query(sql).Tables[0];
        }

        public int deletebywhere(string C_BATCH_NO, string C_STOVE, string C_STL_GRD, string C_MAT_CODE, string C_SLABWH_CODE, string C_ZYX1, string C_ZYX2)
        {
            string sql = @"DELETE FROM TSC_SLAB_MAIN T WHERE 1=1 ";
            if (C_BATCH_NO.Trim() != "")
            {
                sql = sql + "  AND T.C_BATCH_NO = '" + C_BATCH_NO + "'  ";
            }
            if (C_STOVE.Trim() != "")
            {
                sql = sql + "   AND T.C_STOVE = '" + C_STOVE + "'  ";
            }
            if (C_STL_GRD.Trim() != "")
            {
                sql = sql + "    AND T.C_STL_GRD = '" + C_STL_GRD + "'  ";
            }
            if (C_MAT_CODE.Trim() != "")
            {
                sql = sql + "     AND T.C_MAT_CODE = '" + C_MAT_CODE + "' ";
            }
            if (C_SLABWH_CODE.Trim() != "")
            {
                sql = sql + "   AND T.C_SLABWH_CODE = '" + C_SLABWH_CODE + "'  ";
            }
            if (C_ZYX1.Trim() != "")
            {
                sql = sql + "   AND T.C_ZYX1 = '" + C_ZYX1 + "'  ";
            }
            if (C_ZYX2.Trim() != "")
            {
                sql = sql + "   AND T.C_ZYX2 = '" + C_ZYX2 + "'  ";
            }

            return DbHelperOra.ExecuteSql(sql);

        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Mod_TSC_SLAB_MAIN GetModel(string C_STD_CODE, string C_STL_GRD, string C_STOVE)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from tsc_slab_main ");
            strSql.Append(" where C_STOVE='" + C_STOVE + "' and C_STD_CODE='" + C_STD_CODE + "' and C_STL_GRD='" + C_STL_GRD + "' and rownum=1  AND C_MOVE_TYPE!='EX' ");

            Mod_TSP_PLAN_SMS model = new Mod_TSP_PLAN_SMS();
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
        public Mod_TSC_SLAB_MAIN GetModel_Batch(string C_STD_CODE, string C_STL_GRD, string C_BATCH_NO)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from tsc_slab_main ");
            strSql.Append(" where C_BATCH_NO='" + C_BATCH_NO + "' and C_STD_CODE='" + C_STD_CODE + "' and C_STL_GRD='" + C_STL_GRD + "' and rownum=1  AND C_MOVE_TYPE!='EX' ");

            Mod_TSP_PLAN_SMS model = new Mod_TSP_PLAN_SMS();
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

        #endregion  ExtensionMethod

        /// <summary>
        /// 获取库存钢坯数量
        /// </summary>
        /// <param name="C_STL_GRD">钢种</param>
        /// <param name="C_STD_CODE">执行标准</param>
        /// <param name="C_MAT_CODE">物料编码</param>
        /// <returns>库存钢坯数量</returns>
        public decimal GetSlabKC(string C_STL_GRD, string C_STD_CODE, string C_MAT_CODE)
        {
            try
            {
                string sql = @" SELECT NVL(SUM(T.N_WGT), 0) N_WGT  FROM TSC_SLAB_MAIN T WHERE C_MOVE_TYPE IN ('E','M','DZ','NP','R','DX') AND T.C_STL_GRD = '" + C_STL_GRD + "'   AND T.C_STD_CODE = '" + C_STD_CODE + "' ";
                if (C_MAT_CODE.Trim() != "")
                {
                    sql = sql + "  AND T.C_MAT_CODE = '" + C_MAT_CODE + "' ";
                }

                return Convert.ToDecimal(DbHelperOra.Query(sql).Tables[0].Rows[0]["N_WGT"]);

            }
            catch (Exception)
            {

                return 0;
            }
        }

        /// <summary>
        /// 获取需要开坯的信息
        /// </summary>
        /// <returns></returns>
        public DataSet Get_List_Kp(string C_STL_GRD, string C_STD_CODE, string C_STOVE)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT C_STA_DESC, C_STOVE, C_STD_CODE, C_STL_GRD, C_MAT_CODE, C_MAT_NAME, C_SPEC, N_LEN, QUA, N_WGT, C_ZYX1, C_ZYX2, D_CCM_DATE, C_MATRL_CODE_KP, C_MATRL_NAME_KP, C_KP_SIZE, N_KP_LENGTH, N_KP_PW  FROM(select TB.C_STA_DESC, T.C_STOVE, T.C_STD_CODE, T.C_STL_GRD, T.C_MAT_CODE, T.C_MAT_NAME, T.C_SPEC, T.N_LEN, COUNT(1) AS QUA, SUM(T.N_WGT) AS N_WGT, T.C_ZYX1, T.C_ZYX2, MAX(T.D_CCM_DATE) AS D_CCM_DATE, TS.C_MATRL_CODE_KP, TS.C_MATRL_NAME_KP, TS.C_KP_SIZE, TS.N_KP_LENGTH, TS.N_KP_PW, MIN(TT.N_STATUS) AS YXF_STATUS from tsc_slab_main t INNER JOIN TB_STA TB ON T.C_STA_ID = TB.C_ID LEFT JOIN TSP_PLAN_SMS TS ON TS.C_STOVE_NO = T.C_STOVE AND TS.C_STL_GRD = T.C_STL_GRD AND TS.C_STD_CODE = T.C_STD_CODE AND TS.C_KP = 'Y' AND TS.N_STATUS = 1 LEFT JOIN TRP_PLAN_COGDOWN TT ON TT.C_CAST_NO = T.C_STOVE AND TT.C_STL_GRD = T.C_STL_GRD AND TT.C_STD_CODE = T.C_STD_CODE where T.C_BATCH_NO IS NULL AND T.C_STL_GRD LIKE '%" + C_STL_GRD + "%' AND T.C_STD_CODE LIKE '%" + C_STD_CODE + "%' AND t.c_spec = '280*325' AND T.C_STOVE like '%" + C_STOVE + "%' and t.c_move_type in ('E', 'M') GROUP BY T.C_STOVE, T.C_STD_CODE, T.C_STL_GRD, T.C_MAT_CODE, T.C_MAT_NAME, T.C_SPEC, T.N_LEN, T.C_ZYX1, T.C_ZYX2, TB.C_STA_DESC, TS.C_MATRL_CODE_KP, TS.C_MATRL_NAME_KP, TS.C_KP_SIZE, TS.N_KP_LENGTH, TS.N_KP_PW ORDER BY T.C_STOVE) WHERE NVL(YXF_STATUS, 99) NOT IN(1) ");

            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 更新开坯物料信息
        /// </summary>
        /// <returns></returns>
        public string P_UPDATE_KP_MATRAL()
        {
            OracleParameter[] parameters = {
            new OracleParameter("P_MSG", OracleDbType.Varchar2,100)};

            parameters[0].Value = "1";

            return DbHelperOra.RunProcedureOut("PKG_INI_PLAN_SMS.P_UPDATE_KP_MATRAL", parameters);
        }


        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet Get_List(string c_stove, string c_stl_grd, string c_batch_no, string c_mat_code, string c_zyx1, string c_zyx2, string C_JUDGE_LEV_ZH, string c_slabwh_code)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from tsc_slab_main t where t.c_stove='" + c_stove + "' and t.c_stl_grd='" + c_stl_grd + "' and nvl(t.c_batch_no,' ')=nvl('" + c_batch_no + "',' ') and t.c_mat_code='" + c_mat_code + "' and t.c_zyx1='" + c_zyx1 + "' and t.c_zyx2='" + c_zyx2 + "' and T.C_JUDGE_LEV_ZH='" + C_JUDGE_LEV_ZH + "' and T.C_MOVE_TYPE = 'E' and t.c_slabwh_code='" + c_slabwh_code + "' ");

            return DbHelperOra.Query(strSql.ToString());
        }


        /// <summary>
        /// 根据炉号查询
        /// </summary>
        /// <param name="stove">炉号</param>
        /// <returns></returns>
        public DataSet Get_List_ByStove(string stove)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" SELECT T.C_STA_DESC, T.C_STOVE, T.C_STL_GRD, T.C_STD_CODE, T.C_SPEC, T.N_LEN, T.C_MAT_CODE, T.C_MAT_NAME, COUNT(1) AS N_QUA, SUM(T.N_WGT) AS N_WGT, T.C_BATCH_NO  FROM TSC_SLAB_MAIN T WHERE T.C_MOVE_TYPE = 'N' AND T.C_STOVE = '" + stove + "' GROUP BY T.C_STA_DESC, T.C_STOVE, T.C_STL_GRD, T.C_STD_CODE, T.C_SPEC, T.N_LEN, T.C_MAT_CODE, T.C_MAT_NAME, T.C_BATCH_NO  ");

            return DbHelperOra.Query(strSql.ToString());
        }


        /// <summary>
        /// 同步钢坯实绩(指定炉号)
        /// </summary>
        /// <param name="P_STOVE">炉号</param>
        /// <returns></returns>
        public string TB_SLAB_SJ_STOVE(string P_STOVE)
        {
            OracleParameter[] parameters = {
            new OracleParameter("P_STOVE", OracleDbType.Varchar2,100),
            new OracleParameter("P_MSG", OracleDbType.Varchar2,100)};

            parameters[0].Value = P_STOVE;
            parameters[1].Value = "失败";

            return DbHelperOra.RunProcedureOut("PKG_LG_MES.P_TB_SLAB_SJ_STOVE", parameters);
        }

        /// <summary>
        /// 同步钢坯实绩到TSC_SLAB_MAIN(指定炉号)
        /// </summary>
        /// <param name="P_STOVE">炉号</param>
        /// <returns></returns>
        public string TB_SLAB_MAIN_STOVE(string P_STOVE)
        {
            OracleParameter[] parameters = {
            new OracleParameter("P_STOVE", OracleDbType.Varchar2,100),
            new OracleParameter("P_MSG", OracleDbType.Varchar2,100)};

            parameters[0].Value = P_STOVE;
            parameters[1].Value = "失败";

            return DbHelperOra.RunProcedureOut("PKG_LG_MES.P_TB_SLAB_MAIN_STOVE", parameters);
        }


        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update_Trans(string C_REMARK, string C_STOVE)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TSC_SLAB_MAIN set C_REMARK='" + C_REMARK + "' where C_STOVE='" + C_STOVE + "' ");

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
        /// 钢坯调层数据
        /// </summary>
        /// <returns></returns>
        public DataTable GetTCInfo(string slabCode, string slabAreaCode, string slabLocCode)
        {
            string sql = @"SELECT T.C_STOVE, 
                           T.C_BATCH_NO,
                           T.C_STL_GRD,
                           T.C_STD_CODE,
                           SUM(T.N_QUA) N_QUA,
                           T.C_SLABWH_CODE,
                           T.C_SLABWH_AREA_CODE,
                           T.C_SLABWH_LOC_CODE,
       (SELECT MAX(TS.C_SLABWH_NAME)
          FROM TPB_SLABWH TS
         WHERE TS.C_SLABWH_CODE = T.C_SLABWH_CODE
           AND TS.N_STATUS = 1) C_SLABWH_CODE_NAME,
       (SELECT MAX(TSA.C_SLABWH_AREA_NAME)
          FROM TPB_SLABWH_AREA TSA
         WHERE TSA.C_SLABWH_AREA_CODE = T.C_SLABWH_AREA_CODE
           AND TSA.N_STATUS = 1) C_SLABWH_AREA_CODE_NAME,
       (SELECT MAX(TST.C_SLABWH_LOC_NAME)
          FROM TPB_SLABWH_LOC TST
         WHERE TST.C_SLABWH_LOC_CODE = T.C_SLABWH_LOC_CODE
           AND TST.N_STATUS = 1) C_SLABWH_LOC_CODE_NAME,
                           T.C_SLABWH_TIER_CODE
                           FROM TSC_SLAB_MAIN T 
                    WHERE T.C_MOVE_TYPE IN ('R', 'M', 'E', 'DX','DZ')    AND T.C_SLABWH_CODE='" + slabCode + "' AND T.C_SLABWH_AREA_CODE='" + slabAreaCode + "'  AND T.C_SLABWH_LOC_CODE='" + slabLocCode + "' ";
            sql += @"   GROUP BY  T.C_STOVE,
                              T.C_BATCH_NO,
                              T.C_STL_GRD,
                              T.C_STD_CODE,
                              T.C_SLABWH_AREA_CODE,
                              T.C_SLABWH_CODE,
                              T.C_SLABWH_LOC_CODE,
                              T.C_SLABWH_TIER_CODE
                              ORDER BY       
                              TO_NUMBER(translate(T.C_SLABWH_TIER_CODE, '0123456789.' || T.C_SLABWH_TIER_CODE, '0123456789.'))
                            ";
            return DbHelperOra.Query(sql).Tables[0];
        }

        /// <summary>
        /// 修改钢坯层
        /// </summary>
        /// <returns></returns>
        public bool UpdateSlabTier(string count, string stove, string slabCode, string slabArea, string slabLoc, string slabTier)
        {
            string sql = @"  UPDATE TSC_SLAB_MAIN T  SET T.C_SLABWH_TIER_CODE = '" + count + "' WHERE T.C_STOVE = '" + stove + "' AND T.C_SLABWH_CODE = '" + slabCode + "'  AND T.C_SLABWH_AREA_CODE = '" + slabArea + "'  AND T.C_SLABWH_LOC_CODE = '" + slabLoc + "' AND  T.C_SLABWH_TIER_CODE = '" + slabTier + "' ";

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
        /// 获取异常炉次信息
        /// </summary>
        /// <param name="begin">开始时间</param>
        /// <param name="end">结束时间</param>
        /// <param name="Stove">炉号</param>
        /// <param name="str_Gz">钢种</param>
        /// <returns></returns>
        public DataSet Get_Slab_YC(DateTime begin, DateTime end, string Stove,string str_Gz)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select *  from v_slab_yc t where 1 = 1   and t.钢坯生产时间 between       to_date('"+ begin + "', 'yyyy-mm-dd hh24:mi:ss') and   to_date('"+ end + "', 'yyyy-mm-dd hh24:mi:ss') ");

            if (!string.IsNullOrEmpty(Stove))
            {
                strSql.Append(" and(t.炉号 like '"+ Stove + "%' or t.开坯号 like '" + Stove + "%' or t.批号 like '" + Stove + "%') ");
            }
            if (!string.IsNullOrEmpty(str_Gz))
            {
                strSql.Append(" and(t.钢坯钢种 like '%" + str_Gz + "%' or t.开坯钢种 like '%" + str_Gz + "%' or t.轧制钢种 like '%" + str_Gz + "%') ");
            }
            
            return DbHelperOra.Query(strSql.ToString());
        }
    }
}

