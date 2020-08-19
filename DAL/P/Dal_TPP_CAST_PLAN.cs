using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;
namespace DAL
{
    /// <summary>
    /// 数据访问类:TPP_CAST_PLAN
    /// </summary>
    public partial class Dal_TPP_CAST_PLAN
    {
        public Dal_TPP_CAST_PLAN()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string C_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TPP_CAST_PLAN");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)          };
            parameters[0].Value = C_ID;

            return DbHelperOra.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Mod_TPP_CAST_PLAN model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TPP_CAST_PLAN(");
            strSql.Append("C_PLAN_ID,C_CONTRACT_ID,C_PLAN_DEPT,C_EXECUTE_DEPT,D_PLANEXECUTE_DATE,D_ACTUALEXECUTE_DATE,C_PLANNER,C_PRE_LOTNO,C_PRE_HEAT_ID,C_PRE_STEELGRADEINDEX,C_PRE_STEELGRADE,N_AIM_TAPPED_WEIGHT,C_CASTER_ID,C_BOF_ID,C_LF_ID,C_RH_ID,N_BOF_STATUS,N_LF_STATUS,N_RH_STATUS,N_CASTER_STATUS,N_S_IDE_STATUS,C_HEAT_ID,C_CASTER_NO,C_CASTING_HEAT_CNT,D_AIM_IRONPREPARED_TIME,D_AIM_BOFSTART_TIME,D_AIM_BOFTAPPED_TIME,D_AIM_TAPPEDSIDEEND_TIME,D_AIM_LFARRIVAL_TIME,D_AIM_LFSTART_TIME,D_AIM_LFEND_TIME,D_AIM_LFLEAVE_TIME,D_AIM_RHARRIVAL_TIME,D_AIM_RHSTART_TIME,D_AIM_RHEND_TIME,D_AIM_RHLEAVE_TIME,D_AIM_CASTERARRIVAL_TIME,D_AIM_CASTINGSTART_TIME,D_AIM_CASTINGEND_TIME,C_FIR_HEAT_FLAG,DIV_HEAT_ID,C_TEAM_ID,C_SHIFT_ID,STEELGRADEINDEX,C_PLAN_ORD__ID,C_HOT_SEND_FLAG,C_STEEL_RETURN_FLAG,C_STEEL_BACK_FLAG,C_TREAT_SEQ,C_DESTITATION,C_NEW_BOF_FLAG,C_REFINE_TYPE,C_LENGTH,C_W_IDTH,C_THICKNESS,C_AOD_ID,C_DEP_ID,C_RHL_ID,C_DEP_STATUS,C_RHL_STATUS,C_AOD_STATUS,C_INITIALIZE_ITEM,C_IS_TO_MES,C_MES_PLAN_ID,C_LD_DESC,C_LF_DESC,C_RH_DESC,C_CC_DESC,D_DOWN_TIME)");
            strSql.Append(" values (");
            strSql.Append(":C_PLAN_ID,:C_CONTRACT_ID,:C_PLAN_DEPT,:C_EXECUTE_DEPT,:D_PLANEXECUTE_DATE,:D_ACTUALEXECUTE_DATE,:C_PLANNER,:C_PRE_LOTNO,:C_PRE_HEAT_ID,:C_PRE_STEELGRADEINDEX,:C_PRE_STEELGRADE,:N_AIM_TAPPED_WEIGHT,:C_CASTER_ID,:C_BOF_ID,:C_LF_ID,:C_RH_ID,:N_BOF_STATUS,:N_LF_STATUS,:N_RH_STATUS,:N_CASTER_STATUS,:N_S_IDE_STATUS,:C_HEAT_ID,:C_CASTER_NO,:C_CASTING_HEAT_CNT,:D_AIM_IRONPREPARED_TIME,:D_AIM_BOFSTART_TIME,:D_AIM_BOFTAPPED_TIME,:D_AIM_TAPPEDSIDEEND_TIME,:D_AIM_LFARRIVAL_TIME,:D_AIM_LFSTART_TIME,:D_AIM_LFEND_TIME,:D_AIM_LFLEAVE_TIME,:D_AIM_RHARRIVAL_TIME,:D_AIM_RHSTART_TIME,:D_AIM_RHEND_TIME,:D_AIM_RHLEAVE_TIME,:D_AIM_CASTERARRIVAL_TIME,:D_AIM_CASTINGSTART_TIME,:D_AIM_CASTINGEND_TIME,:C_FIR_HEAT_FLAG,:DIV_HEAT_ID,:C_TEAM_ID,:C_SHIFT_ID,:STEELGRADEINDEX,:C_PLAN_ORD__ID,:C_HOT_SEND_FLAG,:C_STEEL_RETURN_FLAG,:C_STEEL_BACK_FLAG,:C_TREAT_SEQ,:C_DESTITATION,:C_NEW_BOF_FLAG,:C_REFINE_TYPE,:C_LENGTH,:C_W_IDTH,:C_THICKNESS,:C_AOD_ID,:C_DEP_ID,:C_RHL_ID,:C_DEP_STATUS,:C_RHL_STATUS,:C_AOD_STATUS,:C_INITIALIZE_ITEM,:C_IS_TO_MES,:C_MES_PLAN_ID,:C_LD_DESC,:C_LF_DESC,:C_RH_DESC,:C_CC_DESC,:D_DOWN_TIME)");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_PLAN_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CONTRACT_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PLAN_DEPT", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_EXECUTE_DEPT", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_PLANEXECUTE_DATE", OracleDbType.Date),
                    new OracleParameter(":D_ACTUALEXECUTE_DATE", OracleDbType.Date),
                    new OracleParameter(":C_PLANNER", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PRE_LOTNO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PRE_HEAT_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PRE_STEELGRADEINDEX", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PRE_STEELGRADE", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_AIM_TAPPED_WEIGHT", OracleDbType.Decimal,15),
                    new OracleParameter(":C_CASTER_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_BOF_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_LF_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_RH_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_BOF_STATUS", OracleDbType.Varchar2,5),
                    new OracleParameter(":N_LF_STATUS", OracleDbType.Varchar2,5),
                    new OracleParameter(":N_RH_STATUS", OracleDbType.Varchar2,5),
                    new OracleParameter(":N_CASTER_STATUS", OracleDbType.Varchar2,5),
                    new OracleParameter(":N_S_IDE_STATUS", OracleDbType.Varchar2,5),
                    new OracleParameter(":C_HEAT_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CASTER_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CASTING_HEAT_CNT", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_AIM_IRONPREPARED_TIME", OracleDbType.Date),
                    new OracleParameter(":D_AIM_BOFSTART_TIME", OracleDbType.Date),
                    new OracleParameter(":D_AIM_BOFTAPPED_TIME", OracleDbType.Date),
                    new OracleParameter(":D_AIM_TAPPEDSIDEEND_TIME", OracleDbType.Date),
                    new OracleParameter(":D_AIM_LFARRIVAL_TIME", OracleDbType.Date),
                    new OracleParameter(":D_AIM_LFSTART_TIME", OracleDbType.Date),
                    new OracleParameter(":D_AIM_LFEND_TIME", OracleDbType.Date),
                    new OracleParameter(":D_AIM_LFLEAVE_TIME", OracleDbType.Date),
                    new OracleParameter(":D_AIM_RHARRIVAL_TIME", OracleDbType.Date),
                    new OracleParameter(":D_AIM_RHSTART_TIME", OracleDbType.Date),
                    new OracleParameter(":D_AIM_RHEND_TIME", OracleDbType.Date),
                    new OracleParameter(":D_AIM_RHLEAVE_TIME", OracleDbType.Date),
                    new OracleParameter(":D_AIM_CASTERARRIVAL_TIME", OracleDbType.Date),
                    new OracleParameter(":D_AIM_CASTINGSTART_TIME", OracleDbType.Date),
                    new OracleParameter(":D_AIM_CASTINGEND_TIME", OracleDbType.Date),
                    new OracleParameter(":C_FIR_HEAT_FLAG", OracleDbType.Varchar2,100),
                    new OracleParameter(":DIV_HEAT_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_TEAM_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SHIFT_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":STEELGRADEINDEX", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PLAN_ORD__ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_HOT_SEND_FLAG", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STEEL_RETURN_FLAG", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STEEL_BACK_FLAG", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_TREAT_SEQ", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_DESTITATION", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_NEW_BOF_FLAG", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_REFINE_TYPE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_LENGTH", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_W_IDTH", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_THICKNESS", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_AOD_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_DEP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_RHL_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_DEP_STATUS", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_RHL_STATUS", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_AOD_STATUS", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_INITIALIZE_ITEM", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_IS_TO_MES", OracleDbType.Varchar2,5),
                    new OracleParameter(":C_MES_PLAN_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_LD_DESC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_LF_DESC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_RH_DESC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CC_DESC", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_DOWN_TIME", OracleDbType.Date)};
            parameters[0].Value = model.C_PLAN_ID;
            parameters[1].Value = model.C_CONTRACT_ID;
            parameters[2].Value = model.C_PLAN_DEPT;
            parameters[3].Value = model.C_EXECUTE_DEPT;
            parameters[4].Value = model.D_PLANEXECUTE_DATE;
            parameters[5].Value = model.D_ACTUALEXECUTE_DATE;
            parameters[6].Value = model.C_PLANNER;
            parameters[7].Value = model.C_PRE_LOTNO;
            parameters[8].Value = model.C_PRE_HEAT_ID;
            parameters[9].Value = model.C_PRE_STEELGRADEINDEX;
            parameters[10].Value = model.C_PRE_STEELGRADE;
            parameters[11].Value = model.N_AIM_TAPPED_WEIGHT;
            parameters[12].Value = model.C_CASTER_ID;
            parameters[13].Value = model.C_BOF_ID;
            parameters[14].Value = model.C_LF_ID;
            parameters[15].Value = model.C_RH_ID;
            parameters[16].Value = model.N_BOF_STATUS;
            parameters[17].Value = model.N_LF_STATUS;
            parameters[18].Value = model.N_RH_STATUS;
            parameters[19].Value = model.N_CASTER_STATUS;
            parameters[20].Value = model.N_S_IDE_STATUS;
            parameters[21].Value = model.C_HEAT_ID;
            parameters[22].Value = model.C_CASTER_NO;
            parameters[23].Value = model.C_CASTING_HEAT_CNT;
            parameters[24].Value = model.D_AIM_IRONPREPARED_TIME;
            parameters[25].Value = model.D_AIM_BOFSTART_TIME;
            parameters[26].Value = model.D_AIM_BOFTAPPED_TIME;
            parameters[27].Value = model.D_AIM_TAPPEDSIDEEND_TIME;
            parameters[28].Value = model.D_AIM_LFARRIVAL_TIME;
            parameters[29].Value = model.D_AIM_LFSTART_TIME;
            parameters[30].Value = model.D_AIM_LFEND_TIME;
            parameters[31].Value = model.D_AIM_LFLEAVE_TIME;
            parameters[32].Value = model.D_AIM_RHARRIVAL_TIME;
            parameters[33].Value = model.D_AIM_RHSTART_TIME;
            parameters[34].Value = model.D_AIM_RHEND_TIME;
            parameters[35].Value = model.D_AIM_RHLEAVE_TIME;
            parameters[36].Value = model.D_AIM_CASTERARRIVAL_TIME;
            parameters[37].Value = model.D_AIM_CASTINGSTART_TIME;
            parameters[38].Value = model.D_AIM_CASTINGEND_TIME;
            parameters[39].Value = model.C_FIR_HEAT_FLAG;
            parameters[40].Value = model.DIV_HEAT_ID;
            parameters[41].Value = model.C_TEAM_ID;
            parameters[42].Value = model.C_SHIFT_ID;
            parameters[43].Value = model.STEELGRADEINDEX;
            parameters[44].Value = model.C_PLAN_ORD__ID;
            parameters[45].Value = model.C_HOT_SEND_FLAG;
            parameters[46].Value = model.C_STEEL_RETURN_FLAG;
            parameters[47].Value = model.C_STEEL_BACK_FLAG;
            parameters[48].Value = model.C_TREAT_SEQ;
            parameters[49].Value = model.C_DESTITATION;
            parameters[50].Value = model.C_NEW_BOF_FLAG;
            parameters[51].Value = model.C_REFINE_TYPE;
            parameters[52].Value = model.C_LENGTH;
            parameters[53].Value = model.C_W_IDTH;
            parameters[54].Value = model.C_THICKNESS;
            parameters[55].Value = model.C_AOD_ID;
            parameters[56].Value = model.C_DEP_ID;
            parameters[57].Value = model.C_RHL_ID;
            parameters[58].Value = model.C_DEP_STATUS;
            parameters[59].Value = model.C_RHL_STATUS;
            parameters[60].Value = model.C_AOD_STATUS;
            parameters[61].Value = model.C_INITIALIZE_ITEM;
            parameters[62].Value = model.C_IS_TO_MES;
            parameters[63].Value = model.C_MES_PLAN_ID;
            parameters[64].Value = model.C_LD_DESC;
            parameters[65].Value = model.C_LF_DESC;
            parameters[66].Value = model.C_RH_DESC;
            parameters[67].Value = model.C_CC_DESC;
            parameters[68].Value = model.D_DOWN_TIME;

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
        public bool Add_Trans(Mod_TPP_CAST_PLAN model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TPP_CAST_PLAN(");
            strSql.Append("C_PLAN_ID,C_CONTRACT_ID,C_PLAN_DEPT,C_EXECUTE_DEPT,D_PLANEXECUTE_DATE,D_ACTUALEXECUTE_DATE,C_PLANNER,C_PRE_LOTNO,C_PRE_HEAT_ID,C_PRE_STEELGRADEINDEX,C_PRE_STEELGRADE,N_AIM_TAPPED_WEIGHT,C_CASTER_ID,C_BOF_ID,C_LF_ID,C_RH_ID,N_BOF_STATUS,N_LF_STATUS,N_RH_STATUS,N_CASTER_STATUS,N_S_IDE_STATUS,C_HEAT_ID,C_CASTER_NO,C_CASTING_HEAT_CNT,D_AIM_IRONPREPARED_TIME,D_AIM_BOFSTART_TIME,D_AIM_BOFTAPPED_TIME,D_AIM_TAPPEDSIDEEND_TIME,D_AIM_LFARRIVAL_TIME,D_AIM_LFSTART_TIME,D_AIM_LFEND_TIME,D_AIM_LFLEAVE_TIME,D_AIM_RHARRIVAL_TIME,D_AIM_RHSTART_TIME,D_AIM_RHEND_TIME,D_AIM_RHLEAVE_TIME,D_AIM_CASTERARRIVAL_TIME,D_AIM_CASTINGSTART_TIME,D_AIM_CASTINGEND_TIME,C_FIR_HEAT_FLAG,DIV_HEAT_ID,C_TEAM_ID,C_SHIFT_ID,STEELGRADEINDEX,C_PLAN_ORD__ID,C_HOT_SEND_FLAG,C_STEEL_RETURN_FLAG,C_STEEL_BACK_FLAG,C_TREAT_SEQ,C_DESTITATION,C_NEW_BOF_FLAG,C_REFINE_TYPE,C_LENGTH,C_W_IDTH,C_THICKNESS,C_AOD_ID,C_DEP_ID,C_RHL_ID,C_DEP_STATUS,C_RHL_STATUS,C_AOD_STATUS,C_INITIALIZE_ITEM,C_IS_TO_MES,C_MES_PLAN_ID,C_LD_DESC,C_LF_DESC,C_RH_DESC,C_CC_DESC,D_DOWN_TIME)");
            strSql.Append(" values (");
            strSql.Append(":C_PLAN_ID,:C_CONTRACT_ID,:C_PLAN_DEPT,:C_EXECUTE_DEPT,:D_PLANEXECUTE_DATE,:D_ACTUALEXECUTE_DATE,:C_PLANNER,:C_PRE_LOTNO,:C_PRE_HEAT_ID,:C_PRE_STEELGRADEINDEX,:C_PRE_STEELGRADE,:N_AIM_TAPPED_WEIGHT,:C_CASTER_ID,:C_BOF_ID,:C_LF_ID,:C_RH_ID,:N_BOF_STATUS,:N_LF_STATUS,:N_RH_STATUS,:N_CASTER_STATUS,:N_S_IDE_STATUS,:C_HEAT_ID,:C_CASTER_NO,:C_CASTING_HEAT_CNT,:D_AIM_IRONPREPARED_TIME,:D_AIM_BOFSTART_TIME,:D_AIM_BOFTAPPED_TIME,:D_AIM_TAPPEDSIDEEND_TIME,:D_AIM_LFARRIVAL_TIME,:D_AIM_LFSTART_TIME,:D_AIM_LFEND_TIME,:D_AIM_LFLEAVE_TIME,:D_AIM_RHARRIVAL_TIME,:D_AIM_RHSTART_TIME,:D_AIM_RHEND_TIME,:D_AIM_RHLEAVE_TIME,:D_AIM_CASTERARRIVAL_TIME,:D_AIM_CASTINGSTART_TIME,:D_AIM_CASTINGEND_TIME,:C_FIR_HEAT_FLAG,:DIV_HEAT_ID,:C_TEAM_ID,:C_SHIFT_ID,:STEELGRADEINDEX,:C_PLAN_ORD__ID,:C_HOT_SEND_FLAG,:C_STEEL_RETURN_FLAG,:C_STEEL_BACK_FLAG,:C_TREAT_SEQ,:C_DESTITATION,:C_NEW_BOF_FLAG,:C_REFINE_TYPE,:C_LENGTH,:C_W_IDTH,:C_THICKNESS,:C_AOD_ID,:C_DEP_ID,:C_RHL_ID,:C_DEP_STATUS,:C_RHL_STATUS,:C_AOD_STATUS,:C_INITIALIZE_ITEM,:C_IS_TO_MES,:C_MES_PLAN_ID,:C_LD_DESC,:C_LF_DESC,:C_RH_DESC,:C_CC_DESC,:D_DOWN_TIME)");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_PLAN_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CONTRACT_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PLAN_DEPT", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_EXECUTE_DEPT", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_PLANEXECUTE_DATE", OracleDbType.Date),
                    new OracleParameter(":D_ACTUALEXECUTE_DATE", OracleDbType.Date),
                    new OracleParameter(":C_PLANNER", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PRE_LOTNO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PRE_HEAT_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PRE_STEELGRADEINDEX", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PRE_STEELGRADE", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_AIM_TAPPED_WEIGHT", OracleDbType.Decimal,15),
                    new OracleParameter(":C_CASTER_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_BOF_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_LF_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_RH_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_BOF_STATUS", OracleDbType.Varchar2,5),
                    new OracleParameter(":N_LF_STATUS", OracleDbType.Varchar2,5),
                    new OracleParameter(":N_RH_STATUS", OracleDbType.Varchar2,5),
                    new OracleParameter(":N_CASTER_STATUS", OracleDbType.Varchar2,5),
                    new OracleParameter(":N_S_IDE_STATUS", OracleDbType.Varchar2,5),
                    new OracleParameter(":C_HEAT_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CASTER_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CASTING_HEAT_CNT", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_AIM_IRONPREPARED_TIME", OracleDbType.Date),
                    new OracleParameter(":D_AIM_BOFSTART_TIME", OracleDbType.Date),
                    new OracleParameter(":D_AIM_BOFTAPPED_TIME", OracleDbType.Date),
                    new OracleParameter(":D_AIM_TAPPEDSIDEEND_TIME", OracleDbType.Date),
                    new OracleParameter(":D_AIM_LFARRIVAL_TIME", OracleDbType.Date),
                    new OracleParameter(":D_AIM_LFSTART_TIME", OracleDbType.Date),
                    new OracleParameter(":D_AIM_LFEND_TIME", OracleDbType.Date),
                    new OracleParameter(":D_AIM_LFLEAVE_TIME", OracleDbType.Date),
                    new OracleParameter(":D_AIM_RHARRIVAL_TIME", OracleDbType.Date),
                    new OracleParameter(":D_AIM_RHSTART_TIME", OracleDbType.Date),
                    new OracleParameter(":D_AIM_RHEND_TIME", OracleDbType.Date),
                    new OracleParameter(":D_AIM_RHLEAVE_TIME", OracleDbType.Date),
                    new OracleParameter(":D_AIM_CASTERARRIVAL_TIME", OracleDbType.Date),
                    new OracleParameter(":D_AIM_CASTINGSTART_TIME", OracleDbType.Date),
                    new OracleParameter(":D_AIM_CASTINGEND_TIME", OracleDbType.Date),
                    new OracleParameter(":C_FIR_HEAT_FLAG", OracleDbType.Varchar2,100),
                    new OracleParameter(":DIV_HEAT_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_TEAM_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SHIFT_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":STEELGRADEINDEX", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PLAN_ORD__ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_HOT_SEND_FLAG", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STEEL_RETURN_FLAG", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STEEL_BACK_FLAG", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_TREAT_SEQ", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_DESTITATION", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_NEW_BOF_FLAG", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_REFINE_TYPE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_LENGTH", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_W_IDTH", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_THICKNESS", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_AOD_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_DEP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_RHL_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_DEP_STATUS", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_RHL_STATUS", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_AOD_STATUS", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_INITIALIZE_ITEM", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_IS_TO_MES", OracleDbType.Varchar2,5),
                    new OracleParameter(":C_MES_PLAN_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_LD_DESC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_LF_DESC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_RH_DESC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CC_DESC", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_DOWN_TIME", OracleDbType.Date)};
            parameters[0].Value = model.C_PLAN_ID;
            parameters[1].Value = model.C_CONTRACT_ID;
            parameters[2].Value = model.C_PLAN_DEPT;
            parameters[3].Value = model.C_EXECUTE_DEPT;
            parameters[4].Value = model.D_PLANEXECUTE_DATE;
            parameters[5].Value = model.D_ACTUALEXECUTE_DATE;
            parameters[6].Value = model.C_PLANNER;
            parameters[7].Value = model.C_PRE_LOTNO;
            parameters[8].Value = model.C_PRE_HEAT_ID;
            parameters[9].Value = model.C_PRE_STEELGRADEINDEX;
            parameters[10].Value = model.C_PRE_STEELGRADE;
            parameters[11].Value = model.N_AIM_TAPPED_WEIGHT;
            parameters[12].Value = model.C_CASTER_ID;
            parameters[13].Value = model.C_BOF_ID;
            parameters[14].Value = model.C_LF_ID;
            parameters[15].Value = model.C_RH_ID;
            parameters[16].Value = model.N_BOF_STATUS;
            parameters[17].Value = model.N_LF_STATUS;
            parameters[18].Value = model.N_RH_STATUS;
            parameters[19].Value = model.N_CASTER_STATUS;
            parameters[20].Value = model.N_S_IDE_STATUS;
            parameters[21].Value = model.C_HEAT_ID;
            parameters[22].Value = model.C_CASTER_NO;
            parameters[23].Value = model.C_CASTING_HEAT_CNT;
            parameters[24].Value = model.D_AIM_IRONPREPARED_TIME;
            parameters[25].Value = model.D_AIM_BOFSTART_TIME;
            parameters[26].Value = model.D_AIM_BOFTAPPED_TIME;
            parameters[27].Value = model.D_AIM_TAPPEDSIDEEND_TIME;
            parameters[28].Value = model.D_AIM_LFARRIVAL_TIME;
            parameters[29].Value = model.D_AIM_LFSTART_TIME;
            parameters[30].Value = model.D_AIM_LFEND_TIME;
            parameters[31].Value = model.D_AIM_LFLEAVE_TIME;
            parameters[32].Value = model.D_AIM_RHARRIVAL_TIME;
            parameters[33].Value = model.D_AIM_RHSTART_TIME;
            parameters[34].Value = model.D_AIM_RHEND_TIME;
            parameters[35].Value = model.D_AIM_RHLEAVE_TIME;
            parameters[36].Value = model.D_AIM_CASTERARRIVAL_TIME;
            parameters[37].Value = model.D_AIM_CASTINGSTART_TIME;
            parameters[38].Value = model.D_AIM_CASTINGEND_TIME;
            parameters[39].Value = model.C_FIR_HEAT_FLAG;
            parameters[40].Value = model.DIV_HEAT_ID;
            parameters[41].Value = model.C_TEAM_ID;
            parameters[42].Value = model.C_SHIFT_ID;
            parameters[43].Value = model.STEELGRADEINDEX;
            parameters[44].Value = model.C_PLAN_ORD__ID;
            parameters[45].Value = model.C_HOT_SEND_FLAG;
            parameters[46].Value = model.C_STEEL_RETURN_FLAG;
            parameters[47].Value = model.C_STEEL_BACK_FLAG;
            parameters[48].Value = model.C_TREAT_SEQ;
            parameters[49].Value = model.C_DESTITATION;
            parameters[50].Value = model.C_NEW_BOF_FLAG;
            parameters[51].Value = model.C_REFINE_TYPE;
            parameters[52].Value = model.C_LENGTH;
            parameters[53].Value = model.C_W_IDTH;
            parameters[54].Value = model.C_THICKNESS;
            parameters[55].Value = model.C_AOD_ID;
            parameters[56].Value = model.C_DEP_ID;
            parameters[57].Value = model.C_RHL_ID;
            parameters[58].Value = model.C_DEP_STATUS;
            parameters[59].Value = model.C_RHL_STATUS;
            parameters[60].Value = model.C_AOD_STATUS;
            parameters[61].Value = model.C_INITIALIZE_ITEM;
            parameters[62].Value = model.C_IS_TO_MES;
            parameters[63].Value = model.C_MES_PLAN_ID;
            parameters[64].Value = model.C_LD_DESC;
            parameters[65].Value = model.C_LF_DESC;
            parameters[66].Value = model.C_RH_DESC;
            parameters[67].Value = model.C_CC_DESC;
            parameters[68].Value = model.D_DOWN_TIME;

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
        public bool Update(Mod_TPP_CAST_PLAN model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TPP_CAST_PLAN set ");
            strSql.Append("C_PLAN_ID=:C_PLAN_ID,");
            strSql.Append("C_CONTRACT_ID=:C_CONTRACT_ID,");
            strSql.Append("C_PLAN_DEPT=:C_PLAN_DEPT,");
            strSql.Append("C_EXECUTE_DEPT=:C_EXECUTE_DEPT,");
            strSql.Append("D_PLANEXECUTE_DATE=:D_PLANEXECUTE_DATE,");
            strSql.Append("D_ACTUALEXECUTE_DATE=:D_ACTUALEXECUTE_DATE,");
            strSql.Append("C_PLANNER=:C_PLANNER,");
            strSql.Append("C_PRE_LOTNO=:C_PRE_LOTNO,");
            strSql.Append("C_PRE_HEAT_ID=:C_PRE_HEAT_ID,");
            strSql.Append("C_PRE_STEELGRADEINDEX=:C_PRE_STEELGRADEINDEX,");
            strSql.Append("C_PRE_STEELGRADE=:C_PRE_STEELGRADE,");
            strSql.Append("N_AIM_TAPPED_WEIGHT=:N_AIM_TAPPED_WEIGHT,");
            strSql.Append("C_CASTER_ID=:C_CASTER_ID,");
            strSql.Append("C_BOF_ID=:C_BOF_ID,");
            strSql.Append("C_LF_ID=:C_LF_ID,");
            strSql.Append("C_RH_ID=:C_RH_ID,");
            strSql.Append("N_BOF_STATUS=:N_BOF_STATUS,");
            strSql.Append("N_LF_STATUS=:N_LF_STATUS,");
            strSql.Append("N_RH_STATUS=:N_RH_STATUS,");
            strSql.Append("N_CASTER_STATUS=:N_CASTER_STATUS,");
            strSql.Append("N_S_IDE_STATUS=:N_S_IDE_STATUS,");
            strSql.Append("C_HEAT_ID=:C_HEAT_ID,");
            strSql.Append("C_CASTER_NO=:C_CASTER_NO,");
            strSql.Append("C_CASTING_HEAT_CNT=:C_CASTING_HEAT_CNT,");
            strSql.Append("D_AIM_IRONPREPARED_TIME=:D_AIM_IRONPREPARED_TIME,");
            strSql.Append("D_AIM_BOFSTART_TIME=:D_AIM_BOFSTART_TIME,");
            strSql.Append("D_AIM_BOFTAPPED_TIME=:D_AIM_BOFTAPPED_TIME,");
            strSql.Append("D_AIM_TAPPEDSIDEEND_TIME=:D_AIM_TAPPEDSIDEEND_TIME,");
            strSql.Append("D_AIM_LFARRIVAL_TIME=:D_AIM_LFARRIVAL_TIME,");
            strSql.Append("D_AIM_LFSTART_TIME=:D_AIM_LFSTART_TIME,");
            strSql.Append("D_AIM_LFEND_TIME=:D_AIM_LFEND_TIME,");
            strSql.Append("D_AIM_LFLEAVE_TIME=:D_AIM_LFLEAVE_TIME,");
            strSql.Append("D_AIM_RHARRIVAL_TIME=:D_AIM_RHARRIVAL_TIME,");
            strSql.Append("D_AIM_RHSTART_TIME=:D_AIM_RHSTART_TIME,");
            strSql.Append("D_AIM_RHEND_TIME=:D_AIM_RHEND_TIME,");
            strSql.Append("D_AIM_RHLEAVE_TIME=:D_AIM_RHLEAVE_TIME,");
            strSql.Append("D_AIM_CASTERARRIVAL_TIME=:D_AIM_CASTERARRIVAL_TIME,");
            strSql.Append("D_AIM_CASTINGSTART_TIME=:D_AIM_CASTINGSTART_TIME,");
            strSql.Append("D_AIM_CASTINGEND_TIME=:D_AIM_CASTINGEND_TIME,");
            strSql.Append("C_FIR_HEAT_FLAG=:C_FIR_HEAT_FLAG,");
            strSql.Append("DIV_HEAT_ID=:DIV_HEAT_ID,");
            strSql.Append("C_TEAM_ID=:C_TEAM_ID,");
            strSql.Append("C_SHIFT_ID=:C_SHIFT_ID,");
            strSql.Append("STEELGRADEINDEX=:STEELGRADEINDEX,");
            strSql.Append("C_PLAN_ORD__ID=:C_PLAN_ORD__ID,");
            strSql.Append("C_HOT_SEND_FLAG=:C_HOT_SEND_FLAG,");
            strSql.Append("C_STEEL_RETURN_FLAG=:C_STEEL_RETURN_FLAG,");
            strSql.Append("C_STEEL_BACK_FLAG=:C_STEEL_BACK_FLAG,");
            strSql.Append("C_TREAT_SEQ=:C_TREAT_SEQ,");
            strSql.Append("C_DESTITATION=:C_DESTITATION,");
            strSql.Append("C_NEW_BOF_FLAG=:C_NEW_BOF_FLAG,");
            strSql.Append("C_REFINE_TYPE=:C_REFINE_TYPE,");
            strSql.Append("C_LENGTH=:C_LENGTH,");
            strSql.Append("C_W_IDTH=:C_W_IDTH,");
            strSql.Append("C_THICKNESS=:C_THICKNESS,");
            strSql.Append("C_AOD_ID=:C_AOD_ID,");
            strSql.Append("C_DEP_ID=:C_DEP_ID,");
            strSql.Append("C_RHL_ID=:C_RHL_ID,");
            strSql.Append("C_DEP_STATUS=:C_DEP_STATUS,");
            strSql.Append("C_RHL_STATUS=:C_RHL_STATUS,");
            strSql.Append("C_AOD_STATUS=:C_AOD_STATUS,");
            strSql.Append("C_INITIALIZE_ITEM=:C_INITIALIZE_ITEM,");
            strSql.Append("C_IS_TO_MES=:C_IS_TO_MES,");
            strSql.Append("C_MES_PLAN_ID=:C_MES_PLAN_ID,");
            strSql.Append("C_LD_DESC=:C_LD_DESC,");
            strSql.Append("C_LF_DESC=:C_LF_DESC,");
            strSql.Append("C_RH_DESC=:C_RH_DESC,");
            strSql.Append("C_CC_DESC=:C_CC_DESC,");
            strSql.Append("D_DOWN_TIME=:D_DOWN_TIME");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_PLAN_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CONTRACT_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PLAN_DEPT", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_EXECUTE_DEPT", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_PLANEXECUTE_DATE", OracleDbType.Date),
                    new OracleParameter(":D_ACTUALEXECUTE_DATE", OracleDbType.Date),
                    new OracleParameter(":C_PLANNER", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PRE_LOTNO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PRE_HEAT_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PRE_STEELGRADEINDEX", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PRE_STEELGRADE", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_AIM_TAPPED_WEIGHT", OracleDbType.Decimal,15),
                    new OracleParameter(":C_CASTER_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_BOF_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_LF_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_RH_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_BOF_STATUS", OracleDbType.Varchar2,5),
                    new OracleParameter(":N_LF_STATUS", OracleDbType.Varchar2,5),
                    new OracleParameter(":N_RH_STATUS", OracleDbType.Varchar2,5),
                    new OracleParameter(":N_CASTER_STATUS", OracleDbType.Varchar2,5),
                    new OracleParameter(":N_S_IDE_STATUS", OracleDbType.Varchar2,5),
                    new OracleParameter(":C_HEAT_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CASTER_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CASTING_HEAT_CNT", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_AIM_IRONPREPARED_TIME", OracleDbType.Date),
                    new OracleParameter(":D_AIM_BOFSTART_TIME", OracleDbType.Date),
                    new OracleParameter(":D_AIM_BOFTAPPED_TIME", OracleDbType.Date),
                    new OracleParameter(":D_AIM_TAPPEDSIDEEND_TIME", OracleDbType.Date),
                    new OracleParameter(":D_AIM_LFARRIVAL_TIME", OracleDbType.Date),
                    new OracleParameter(":D_AIM_LFSTART_TIME", OracleDbType.Date),
                    new OracleParameter(":D_AIM_LFEND_TIME", OracleDbType.Date),
                    new OracleParameter(":D_AIM_LFLEAVE_TIME", OracleDbType.Date),
                    new OracleParameter(":D_AIM_RHARRIVAL_TIME", OracleDbType.Date),
                    new OracleParameter(":D_AIM_RHSTART_TIME", OracleDbType.Date),
                    new OracleParameter(":D_AIM_RHEND_TIME", OracleDbType.Date),
                    new OracleParameter(":D_AIM_RHLEAVE_TIME", OracleDbType.Date),
                    new OracleParameter(":D_AIM_CASTERARRIVAL_TIME", OracleDbType.Date),
                    new OracleParameter(":D_AIM_CASTINGSTART_TIME", OracleDbType.Date),
                    new OracleParameter(":D_AIM_CASTINGEND_TIME", OracleDbType.Date),
                    new OracleParameter(":C_FIR_HEAT_FLAG", OracleDbType.Varchar2,100),
                    new OracleParameter(":DIV_HEAT_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_TEAM_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SHIFT_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":STEELGRADEINDEX", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PLAN_ORD__ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_HOT_SEND_FLAG", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STEEL_RETURN_FLAG", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STEEL_BACK_FLAG", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_TREAT_SEQ", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_DESTITATION", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_NEW_BOF_FLAG", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_REFINE_TYPE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_LENGTH", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_W_IDTH", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_THICKNESS", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_AOD_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_DEP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_RHL_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_DEP_STATUS", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_RHL_STATUS", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_AOD_STATUS", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_INITIALIZE_ITEM", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_IS_TO_MES", OracleDbType.Varchar2,5),
                    new OracleParameter(":C_MES_PLAN_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_LD_DESC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_LF_DESC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_RH_DESC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CC_DESC", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_DOWN_TIME", OracleDbType.Date),
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.C_PLAN_ID;
            parameters[1].Value = model.C_CONTRACT_ID;
            parameters[2].Value = model.C_PLAN_DEPT;
            parameters[3].Value = model.C_EXECUTE_DEPT;
            parameters[4].Value = model.D_PLANEXECUTE_DATE;
            parameters[5].Value = model.D_ACTUALEXECUTE_DATE;
            parameters[6].Value = model.C_PLANNER;
            parameters[7].Value = model.C_PRE_LOTNO;
            parameters[8].Value = model.C_PRE_HEAT_ID;
            parameters[9].Value = model.C_PRE_STEELGRADEINDEX;
            parameters[10].Value = model.C_PRE_STEELGRADE;
            parameters[11].Value = model.N_AIM_TAPPED_WEIGHT;
            parameters[12].Value = model.C_CASTER_ID;
            parameters[13].Value = model.C_BOF_ID;
            parameters[14].Value = model.C_LF_ID;
            parameters[15].Value = model.C_RH_ID;
            parameters[16].Value = model.N_BOF_STATUS;
            parameters[17].Value = model.N_LF_STATUS;
            parameters[18].Value = model.N_RH_STATUS;
            parameters[19].Value = model.N_CASTER_STATUS;
            parameters[20].Value = model.N_S_IDE_STATUS;
            parameters[21].Value = model.C_HEAT_ID;
            parameters[22].Value = model.C_CASTER_NO;
            parameters[23].Value = model.C_CASTING_HEAT_CNT;
            parameters[24].Value = model.D_AIM_IRONPREPARED_TIME;
            parameters[25].Value = model.D_AIM_BOFSTART_TIME;
            parameters[26].Value = model.D_AIM_BOFTAPPED_TIME;
            parameters[27].Value = model.D_AIM_TAPPEDSIDEEND_TIME;
            parameters[28].Value = model.D_AIM_LFARRIVAL_TIME;
            parameters[29].Value = model.D_AIM_LFSTART_TIME;
            parameters[30].Value = model.D_AIM_LFEND_TIME;
            parameters[31].Value = model.D_AIM_LFLEAVE_TIME;
            parameters[32].Value = model.D_AIM_RHARRIVAL_TIME;
            parameters[33].Value = model.D_AIM_RHSTART_TIME;
            parameters[34].Value = model.D_AIM_RHEND_TIME;
            parameters[35].Value = model.D_AIM_RHLEAVE_TIME;
            parameters[36].Value = model.D_AIM_CASTERARRIVAL_TIME;
            parameters[37].Value = model.D_AIM_CASTINGSTART_TIME;
            parameters[38].Value = model.D_AIM_CASTINGEND_TIME;
            parameters[39].Value = model.C_FIR_HEAT_FLAG;
            parameters[40].Value = model.DIV_HEAT_ID;
            parameters[41].Value = model.C_TEAM_ID;
            parameters[42].Value = model.C_SHIFT_ID;
            parameters[43].Value = model.STEELGRADEINDEX;
            parameters[44].Value = model.C_PLAN_ORD__ID;
            parameters[45].Value = model.C_HOT_SEND_FLAG;
            parameters[46].Value = model.C_STEEL_RETURN_FLAG;
            parameters[47].Value = model.C_STEEL_BACK_FLAG;
            parameters[48].Value = model.C_TREAT_SEQ;
            parameters[49].Value = model.C_DESTITATION;
            parameters[50].Value = model.C_NEW_BOF_FLAG;
            parameters[51].Value = model.C_REFINE_TYPE;
            parameters[52].Value = model.C_LENGTH;
            parameters[53].Value = model.C_W_IDTH;
            parameters[54].Value = model.C_THICKNESS;
            parameters[55].Value = model.C_AOD_ID;
            parameters[56].Value = model.C_DEP_ID;
            parameters[57].Value = model.C_RHL_ID;
            parameters[58].Value = model.C_DEP_STATUS;
            parameters[59].Value = model.C_RHL_STATUS;
            parameters[60].Value = model.C_AOD_STATUS;
            parameters[61].Value = model.C_INITIALIZE_ITEM;
            parameters[62].Value = model.C_IS_TO_MES;
            parameters[63].Value = model.C_MES_PLAN_ID;
            parameters[64].Value = model.C_LD_DESC;
            parameters[65].Value = model.C_LF_DESC;
            parameters[66].Value = model.C_RH_DESC;
            parameters[67].Value = model.C_CC_DESC;
            parameters[68].Value = model.D_DOWN_TIME;
            parameters[69].Value = model.C_ID;

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
            strSql.Append("delete from TPP_CAST_PLAN ");
            strSql.Append(" where C_ID=:C_ID ");
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
            strSql.Append("delete from TPP_CAST_PLAN ");
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
        public Mod_TPP_CAST_PLAN GetModel(string C_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_PLAN_ID,C_CONTRACT_ID,C_PLAN_DEPT,C_EXECUTE_DEPT,D_PLANEXECUTE_DATE,D_ACTUALEXECUTE_DATE,C_PLANNER,C_PRE_LOTNO,C_PRE_HEAT_ID,C_PRE_STEELGRADEINDEX,C_PRE_STEELGRADE,N_AIM_TAPPED_WEIGHT,C_CASTER_ID,C_BOF_ID,C_LF_ID,C_RH_ID,N_BOF_STATUS,N_LF_STATUS,N_RH_STATUS,N_CASTER_STATUS,N_S_IDE_STATUS,C_HEAT_ID,C_CASTER_NO,C_CASTING_HEAT_CNT,D_AIM_IRONPREPARED_TIME,D_AIM_BOFSTART_TIME,D_AIM_BOFTAPPED_TIME,D_AIM_TAPPEDSIDEEND_TIME,D_AIM_LFARRIVAL_TIME,D_AIM_LFSTART_TIME,D_AIM_LFEND_TIME,D_AIM_LFLEAVE_TIME,D_AIM_RHARRIVAL_TIME,D_AIM_RHSTART_TIME,D_AIM_RHEND_TIME,D_AIM_RHLEAVE_TIME,D_AIM_CASTERARRIVAL_TIME,D_AIM_CASTINGSTART_TIME,D_AIM_CASTINGEND_TIME,C_FIR_HEAT_FLAG,DIV_HEAT_ID,C_TEAM_ID,C_SHIFT_ID,STEELGRADEINDEX,C_PLAN_ORD__ID,C_HOT_SEND_FLAG,C_STEEL_RETURN_FLAG,C_STEEL_BACK_FLAG,C_TREAT_SEQ,C_DESTITATION,C_NEW_BOF_FLAG,C_REFINE_TYPE,C_LENGTH,C_W_IDTH,C_THICKNESS,C_AOD_ID,C_DEP_ID,C_RHL_ID,C_DEP_STATUS,C_RHL_STATUS,C_AOD_STATUS,C_INITIALIZE_ITEM,C_IS_TO_MES,C_MES_PLAN_ID,C_LD_DESC,C_LF_DESC,C_RH_DESC,C_CC_DESC,D_DOWN_TIME from TPP_CAST_PLAN ");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)          };
            parameters[0].Value = C_ID;

            Mod_TPP_CAST_PLAN model = new Mod_TPP_CAST_PLAN();
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
        public Mod_TPP_CAST_PLAN GetModel_PLAN_ID(string C_PLAN_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_PLAN_ID,C_CONTRACT_ID,C_PLAN_DEPT,C_EXECUTE_DEPT,D_PLANEXECUTE_DATE,D_ACTUALEXECUTE_DATE,C_PLANNER,C_PRE_LOTNO,C_PRE_HEAT_ID,C_PRE_STEELGRADEINDEX,C_PRE_STEELGRADE,N_AIM_TAPPED_WEIGHT,C_CASTER_ID,C_BOF_ID,C_LF_ID,C_RH_ID,N_BOF_STATUS,N_LF_STATUS,N_RH_STATUS,N_CASTER_STATUS,N_S_IDE_STATUS,C_HEAT_ID,C_CASTER_NO,C_CASTING_HEAT_CNT,D_AIM_IRONPREPARED_TIME,D_AIM_BOFSTART_TIME,D_AIM_BOFTAPPED_TIME,D_AIM_TAPPEDSIDEEND_TIME,D_AIM_LFARRIVAL_TIME,D_AIM_LFSTART_TIME,D_AIM_LFEND_TIME,D_AIM_LFLEAVE_TIME,D_AIM_RHARRIVAL_TIME,D_AIM_RHSTART_TIME,D_AIM_RHEND_TIME,D_AIM_RHLEAVE_TIME,D_AIM_CASTERARRIVAL_TIME,D_AIM_CASTINGSTART_TIME,D_AIM_CASTINGEND_TIME,C_FIR_HEAT_FLAG,DIV_HEAT_ID,C_TEAM_ID,C_SHIFT_ID,STEELGRADEINDEX,C_PLAN_ORD__ID,C_HOT_SEND_FLAG,C_STEEL_RETURN_FLAG,C_STEEL_BACK_FLAG,C_TREAT_SEQ,C_DESTITATION,C_NEW_BOF_FLAG,C_REFINE_TYPE,C_LENGTH,C_W_IDTH,C_THICKNESS,C_AOD_ID,C_DEP_ID,C_RHL_ID,C_DEP_STATUS,C_RHL_STATUS,C_AOD_STATUS,C_INITIALIZE_ITEM,C_IS_TO_MES,C_MES_PLAN_ID,C_LD_DESC,C_LF_DESC,C_RH_DESC,C_CC_DESC,D_DOWN_TIME from TPP_CAST_PLAN ");
            strSql.Append(" where C_PLAN_ID=:C_PLAN_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_PLAN_ID", OracleDbType.Varchar2,100)          };
            parameters[0].Value = C_PLAN_ID;

            Mod_TPP_CAST_PLAN model = new Mod_TPP_CAST_PLAN();
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
        public Mod_TPP_CAST_PLAN DataRowToModel(DataRow row)
        {
            Mod_TPP_CAST_PLAN model = new Mod_TPP_CAST_PLAN();
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
                if (row["C_CONTRACT_ID"] != null)
                {
                    model.C_CONTRACT_ID = row["C_CONTRACT_ID"].ToString();
                }
                if (row["C_PLAN_DEPT"] != null)
                {
                    model.C_PLAN_DEPT = row["C_PLAN_DEPT"].ToString();
                }
                if (row["C_EXECUTE_DEPT"] != null)
                {
                    model.C_EXECUTE_DEPT = row["C_EXECUTE_DEPT"].ToString();
                }
                if (row["D_PLANEXECUTE_DATE"] != null && row["D_PLANEXECUTE_DATE"].ToString() != "")
                {
                    model.D_PLANEXECUTE_DATE = DateTime.Parse(row["D_PLANEXECUTE_DATE"].ToString());
                }
                if (row["D_ACTUALEXECUTE_DATE"] != null && row["D_ACTUALEXECUTE_DATE"].ToString() != "")
                {
                    model.D_ACTUALEXECUTE_DATE = DateTime.Parse(row["D_ACTUALEXECUTE_DATE"].ToString());
                }
                if (row["C_PLANNER"] != null)
                {
                    model.C_PLANNER = row["C_PLANNER"].ToString();
                }
                if (row["C_PRE_LOTNO"] != null)
                {
                    model.C_PRE_LOTNO = row["C_PRE_LOTNO"].ToString();
                }
                if (row["C_PRE_HEAT_ID"] != null)
                {
                    model.C_PRE_HEAT_ID = row["C_PRE_HEAT_ID"].ToString();
                }
                if (row["C_PRE_STEELGRADEINDEX"] != null)
                {
                    model.C_PRE_STEELGRADEINDEX = row["C_PRE_STEELGRADEINDEX"].ToString();
                }
                if (row["C_PRE_STEELGRADE"] != null)
                {
                    model.C_PRE_STEELGRADE = row["C_PRE_STEELGRADE"].ToString();
                }
                if (row["N_AIM_TAPPED_WEIGHT"] != null && row["N_AIM_TAPPED_WEIGHT"].ToString() != "")
                {
                    model.N_AIM_TAPPED_WEIGHT = decimal.Parse(row["N_AIM_TAPPED_WEIGHT"].ToString());
                }
                if (row["C_CASTER_ID"] != null)
                {
                    model.C_CASTER_ID = row["C_CASTER_ID"].ToString();
                }
                if (row["C_BOF_ID"] != null)
                {
                    model.C_BOF_ID = row["C_BOF_ID"].ToString();
                }
                if (row["C_LF_ID"] != null)
                {
                    model.C_LF_ID = row["C_LF_ID"].ToString();
                }
                if (row["C_RH_ID"] != null)
                {
                    model.C_RH_ID = row["C_RH_ID"].ToString();
                }
                if (row["N_BOF_STATUS"] != null)
                {
                    model.N_BOF_STATUS = row["N_BOF_STATUS"].ToString();
                }
                if (row["N_LF_STATUS"] != null)
                {
                    model.N_LF_STATUS = row["N_LF_STATUS"].ToString();
                }
                if (row["N_RH_STATUS"] != null)
                {
                    model.N_RH_STATUS = row["N_RH_STATUS"].ToString();
                }
                if (row["N_CASTER_STATUS"] != null)
                {
                    model.N_CASTER_STATUS = row["N_CASTER_STATUS"].ToString();
                }
                if (row["N_S_IDE_STATUS"] != null)
                {
                    model.N_S_IDE_STATUS = row["N_S_IDE_STATUS"].ToString();
                }
                if (row["C_HEAT_ID"] != null)
                {
                    model.C_HEAT_ID = row["C_HEAT_ID"].ToString();
                }
                if (row["C_CASTER_NO"] != null)
                {
                    model.C_CASTER_NO = row["C_CASTER_NO"].ToString();
                }
                if (row["C_CASTING_HEAT_CNT"] != null)
                {
                    model.C_CASTING_HEAT_CNT = row["C_CASTING_HEAT_CNT"].ToString();
                }
                if (row["D_AIM_IRONPREPARED_TIME"] != null && row["D_AIM_IRONPREPARED_TIME"].ToString() != "")
                {
                    model.D_AIM_IRONPREPARED_TIME = DateTime.Parse(row["D_AIM_IRONPREPARED_TIME"].ToString());
                }
                if (row["D_AIM_BOFSTART_TIME"] != null && row["D_AIM_BOFSTART_TIME"].ToString() != "")
                {
                    model.D_AIM_BOFSTART_TIME = DateTime.Parse(row["D_AIM_BOFSTART_TIME"].ToString());
                }
                if (row["D_AIM_BOFTAPPED_TIME"] != null && row["D_AIM_BOFTAPPED_TIME"].ToString() != "")
                {
                    model.D_AIM_BOFTAPPED_TIME = DateTime.Parse(row["D_AIM_BOFTAPPED_TIME"].ToString());
                }
                if (row["D_AIM_TAPPEDSIDEEND_TIME"] != null && row["D_AIM_TAPPEDSIDEEND_TIME"].ToString() != "")
                {
                    model.D_AIM_TAPPEDSIDEEND_TIME = DateTime.Parse(row["D_AIM_TAPPEDSIDEEND_TIME"].ToString());
                }
                if (row["D_AIM_LFARRIVAL_TIME"] != null && row["D_AIM_LFARRIVAL_TIME"].ToString() != "")
                {
                    model.D_AIM_LFARRIVAL_TIME = DateTime.Parse(row["D_AIM_LFARRIVAL_TIME"].ToString());
                }
                if (row["D_AIM_LFSTART_TIME"] != null && row["D_AIM_LFSTART_TIME"].ToString() != "")
                {
                    model.D_AIM_LFSTART_TIME = DateTime.Parse(row["D_AIM_LFSTART_TIME"].ToString());
                }
                if (row["D_AIM_LFEND_TIME"] != null && row["D_AIM_LFEND_TIME"].ToString() != "")
                {
                    model.D_AIM_LFEND_TIME = DateTime.Parse(row["D_AIM_LFEND_TIME"].ToString());
                }
                if (row["D_AIM_LFLEAVE_TIME"] != null && row["D_AIM_LFLEAVE_TIME"].ToString() != "")
                {
                    model.D_AIM_LFLEAVE_TIME = DateTime.Parse(row["D_AIM_LFLEAVE_TIME"].ToString());
                }
                if (row["D_AIM_RHARRIVAL_TIME"] != null && row["D_AIM_RHARRIVAL_TIME"].ToString() != "")
                {
                    model.D_AIM_RHARRIVAL_TIME = DateTime.Parse(row["D_AIM_RHARRIVAL_TIME"].ToString());
                }
                if (row["D_AIM_RHSTART_TIME"] != null && row["D_AIM_RHSTART_TIME"].ToString() != "")
                {
                    model.D_AIM_RHSTART_TIME = DateTime.Parse(row["D_AIM_RHSTART_TIME"].ToString());
                }
                if (row["D_AIM_RHEND_TIME"] != null && row["D_AIM_RHEND_TIME"].ToString() != "")
                {
                    model.D_AIM_RHEND_TIME = DateTime.Parse(row["D_AIM_RHEND_TIME"].ToString());
                }
                if (row["D_AIM_RHLEAVE_TIME"] != null && row["D_AIM_RHLEAVE_TIME"].ToString() != "")
                {
                    model.D_AIM_RHLEAVE_TIME = DateTime.Parse(row["D_AIM_RHLEAVE_TIME"].ToString());
                }
                if (row["D_AIM_CASTERARRIVAL_TIME"] != null && row["D_AIM_CASTERARRIVAL_TIME"].ToString() != "")
                {
                    model.D_AIM_CASTERARRIVAL_TIME = DateTime.Parse(row["D_AIM_CASTERARRIVAL_TIME"].ToString());
                }
                if (row["D_AIM_CASTINGSTART_TIME"] != null && row["D_AIM_CASTINGSTART_TIME"].ToString() != "")
                {
                    model.D_AIM_CASTINGSTART_TIME = DateTime.Parse(row["D_AIM_CASTINGSTART_TIME"].ToString());
                }
                if (row["D_AIM_CASTINGEND_TIME"] != null && row["D_AIM_CASTINGEND_TIME"].ToString() != "")
                {
                    model.D_AIM_CASTINGEND_TIME = DateTime.Parse(row["D_AIM_CASTINGEND_TIME"].ToString());
                }
                if (row["C_FIR_HEAT_FLAG"] != null)
                {
                    model.C_FIR_HEAT_FLAG = row["C_FIR_HEAT_FLAG"].ToString();
                }
                if (row["DIV_HEAT_ID"] != null)
                {
                    model.DIV_HEAT_ID = row["DIV_HEAT_ID"].ToString();
                }
                if (row["C_TEAM_ID"] != null)
                {
                    model.C_TEAM_ID = row["C_TEAM_ID"].ToString();
                }
                if (row["C_SHIFT_ID"] != null)
                {
                    model.C_SHIFT_ID = row["C_SHIFT_ID"].ToString();
                }
                if (row["STEELGRADEINDEX"] != null)
                {
                    model.STEELGRADEINDEX = row["STEELGRADEINDEX"].ToString();
                }
                if (row["C_PLAN_ORD__ID"] != null)
                {
                    model.C_PLAN_ORD__ID = row["C_PLAN_ORD__ID"].ToString();
                }
                if (row["C_HOT_SEND_FLAG"] != null)
                {
                    model.C_HOT_SEND_FLAG = row["C_HOT_SEND_FLAG"].ToString();
                }
                if (row["C_STEEL_RETURN_FLAG"] != null)
                {
                    model.C_STEEL_RETURN_FLAG = row["C_STEEL_RETURN_FLAG"].ToString();
                }
                if (row["C_STEEL_BACK_FLAG"] != null)
                {
                    model.C_STEEL_BACK_FLAG = row["C_STEEL_BACK_FLAG"].ToString();
                }
                if (row["C_TREAT_SEQ"] != null)
                {
                    model.C_TREAT_SEQ = row["C_TREAT_SEQ"].ToString();
                }
                if (row["C_DESTITATION"] != null)
                {
                    model.C_DESTITATION = row["C_DESTITATION"].ToString();
                }
                if (row["C_NEW_BOF_FLAG"] != null)
                {
                    model.C_NEW_BOF_FLAG = row["C_NEW_BOF_FLAG"].ToString();
                }
                if (row["C_REFINE_TYPE"] != null)
                {
                    model.C_REFINE_TYPE = row["C_REFINE_TYPE"].ToString();
                }
                if (row["C_LENGTH"] != null)
                {
                    model.C_LENGTH = row["C_LENGTH"].ToString();
                }
                if (row["C_W_IDTH"] != null)
                {
                    model.C_W_IDTH = row["C_W_IDTH"].ToString();
                }
                if (row["C_THICKNESS"] != null)
                {
                    model.C_THICKNESS = row["C_THICKNESS"].ToString();
                }
                if (row["C_AOD_ID"] != null)
                {
                    model.C_AOD_ID = row["C_AOD_ID"].ToString();
                }
                if (row["C_DEP_ID"] != null)
                {
                    model.C_DEP_ID = row["C_DEP_ID"].ToString();
                }
                if (row["C_RHL_ID"] != null)
                {
                    model.C_RHL_ID = row["C_RHL_ID"].ToString();
                }
                if (row["C_DEP_STATUS"] != null)
                {
                    model.C_DEP_STATUS = row["C_DEP_STATUS"].ToString();
                }
                if (row["C_RHL_STATUS"] != null)
                {
                    model.C_RHL_STATUS = row["C_RHL_STATUS"].ToString();
                }
                if (row["C_AOD_STATUS"] != null)
                {
                    model.C_AOD_STATUS = row["C_AOD_STATUS"].ToString();
                }
                if (row["C_INITIALIZE_ITEM"] != null)
                {
                    model.C_INITIALIZE_ITEM = row["C_INITIALIZE_ITEM"].ToString();
                }
                if (row["C_IS_TO_MES"] != null)
                {
                    model.C_IS_TO_MES = row["C_IS_TO_MES"].ToString();
                }
                if (row["C_MES_PLAN_ID"] != null)
                {
                    model.C_MES_PLAN_ID = row["C_MES_PLAN_ID"].ToString();
                }
                if (row["C_LD_DESC"] != null)
                {
                    model.C_LD_DESC = row["C_LD_DESC"].ToString();
                }
                if (row["C_LF_DESC"] != null)
                {
                    model.C_LF_DESC = row["C_LF_DESC"].ToString();
                }
                if (row["C_RH_DESC"] != null)
                {
                    model.C_RH_DESC = row["C_RH_DESC"].ToString();
                }
                if (row["C_CC_DESC"] != null)
                {
                    model.C_CC_DESC = row["C_CC_DESC"].ToString();
                }
                if (row["D_DOWN_TIME"] != null && row["D_DOWN_TIME"].ToString() != "")
                {
                    model.D_DOWN_TIME = DateTime.Parse(row["D_DOWN_TIME"].ToString());
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
            strSql.Append("select C_ID,C_PLAN_ID,C_CONTRACT_ID,C_PLAN_DEPT,C_EXECUTE_DEPT,D_PLANEXECUTE_DATE,D_ACTUALEXECUTE_DATE,C_PLANNER,C_PRE_LOTNO,C_PRE_HEAT_ID,C_PRE_STEELGRADEINDEX,C_PRE_STEELGRADE,N_AIM_TAPPED_WEIGHT,C_CASTER_ID,C_BOF_ID,C_LF_ID,C_RH_ID,N_BOF_STATUS,N_LF_STATUS,N_RH_STATUS,N_CASTER_STATUS,N_S_IDE_STATUS,C_HEAT_ID,C_CASTER_NO,C_CASTING_HEAT_CNT,D_AIM_IRONPREPARED_TIME,D_AIM_BOFSTART_TIME,D_AIM_BOFTAPPED_TIME,D_AIM_TAPPEDSIDEEND_TIME,D_AIM_LFARRIVAL_TIME,D_AIM_LFSTART_TIME,D_AIM_LFEND_TIME,D_AIM_LFLEAVE_TIME,D_AIM_RHARRIVAL_TIME,D_AIM_RHSTART_TIME,D_AIM_RHEND_TIME,D_AIM_RHLEAVE_TIME,D_AIM_CASTERARRIVAL_TIME,D_AIM_CASTINGSTART_TIME,D_AIM_CASTINGEND_TIME,C_FIR_HEAT_FLAG,DIV_HEAT_ID,C_TEAM_ID,C_SHIFT_ID,STEELGRADEINDEX,C_PLAN_ORD__ID,C_HOT_SEND_FLAG,C_STEEL_RETURN_FLAG,C_STEEL_BACK_FLAG,C_TREAT_SEQ,C_DESTITATION,C_NEW_BOF_FLAG,C_REFINE_TYPE,C_LENGTH,C_W_IDTH,C_THICKNESS,C_AOD_ID,C_DEP_ID,C_RHL_ID,C_DEP_STATUS,C_RHL_STATUS,C_AOD_STATUS,C_INITIALIZE_ITEM,C_IS_TO_MES,C_MES_PLAN_ID,C_LD_DESC,C_LF_DESC,C_RH_DESC,C_CC_DESC,D_DOWN_TIME ");
            strSql.Append(" FROM TPP_CAST_PLAN ");
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
            strSql.Append("select count(1) FROM TPP_CAST_PLAN ");
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
            strSql.Append(")AS Row, T.*  from TPP_CAST_PLAN T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 向炼钢MES推送炼钢计划
        /// </summary>
        /// <param name="P_CC_ID">连铸主键</param>
        /// <param name="P_ROW_COUNT">计划数</param>
        /// <returns></returns>
        public int Down_Plan_To_Mes(string P_CC_ID, int P_ROW_COUNT)
        {
            OracleParameter[] parameters = {
            new OracleParameter("P_CC_ID", OracleDbType.Varchar2,100),
            new OracleParameter("P_ROW_COUNT", OracleDbType.Int32,10)};

            parameters[0].Value = P_CC_ID;
            parameters[1].Value = P_ROW_COUNT;

            return DbHelperOra.RunProcedure("pkg_lg_mes.P_SEND_PLAN", parameters);
        }

        /// <summary>
        /// 获取符合条件炉数
        /// </summary>
        /// <param name="C_CCM_ID">连铸ID</param>
        /// <param name="n_sort">顺序号</param>
        /// <returns></returns>
        public int GetStoveCount(string C_CCM_ID, int n_sort)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT count(1)  FROM TSP_PLAN_SMS T INNER JOIN TPP_CAST_PLAN TB ON T.C_ID = TB.C_PLAN_ID WHERE T.N_STATUS = 1 AND T.C_CCM_ID = '" + C_CCM_ID + "' and tb.c_is_to_mes = '0' and t.n_creat_plan='2'  and t.n_sort > " + n_sort + " ORDER BY T.N_SORT ");

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
        /// 删除一条数据
        /// </summary>
        public bool BackPlan(string C_CTRL_NO)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from tpp_cast_plan t where t.c_is_to_mes='0' and t.c_plan_id in (select tp.c_id from tsp_plan_sms tp where tp.N_STATUS=1 and tp.c_ctrl_no='" + C_CTRL_NO + "')");

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
        /// 获取需要下发到MES的计划
        /// </summary>
        /// <param name="P_CC_ID">连铸ID</param>
        /// <param name="P_ROW_COUNT">计划数</param>
        /// <returns></returns>
        public DataSet Get_List(string P_CC_ID, int P_ROW_COUNT)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT * FROM(select t.* from TPP_CAST_PLAN t INNER JOIN TSP_PLAN_SMS TB ON T.C_PLAN_ID = TB.C_ID ");

            strSql.Append(" WHERE TB.N_STATUS = 1   ");

            strSql.Append(" AND T.C_IS_TO_MES = '0' ");

            strSql.Append(" AND T.C_MES_PLAN_ID IS NULL ");

            strSql.Append(" AND T.C_CASTER_ID = '" + P_CC_ID + "' ");

            //strSql.Append(" and t.c_pre_steelgradeindex is not null ");

            strSql.Append(" ORDER BY TB.N_SORT) tl WHERE ROWNUM <= " + P_ROW_COUNT + " ");

            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取需要下发到MES的计划
        /// </summary>
        /// <param name="P_CC_ID">连铸ID</param>
        /// <returns></returns>
        public DataSet Get_List(string P_CC_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" select t.* from TPP_CAST_PLAN t INNER JOIN TSP_PLAN_SMS TB ON T.C_PLAN_ID = TB.C_ID ");

            strSql.Append(" WHERE TB.N_STATUS = 1   ");

            strSql.Append(" AND T.C_IS_TO_MES = '0' ");

            strSql.Append(" AND T.C_MES_PLAN_ID IS NULL ");

            strSql.Append(" AND T.C_CASTER_ID = '" + P_CC_ID + "' ");

            //strSql.Append(" and t.c_pre_steelgradeindex is not null ");

            strSql.Append(" ORDER BY TB.N_SORT ");

            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool delete_CAST_PLAN_Trans(string C_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from TPP_CAST_PLAN WHERE C_ID = '" + C_ID + "' ");

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
        public bool Update_CAST_PLAN_Trans(string C_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("UPDATE TPP_CAST_PLAN SET C_HEAT_ID=null,C_IS_TO_MES='0',C_MES_PLAN_ID=null,D_DOWN_TIME=null  WHERE C_ID = '" + C_ID + "' ");

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
        public bool Update_CAST_PLAN_Trans(string C_ID, string C_PRE_STEELGRADEINDEX, string C_ORDER_NO, string C_REFINE_TYPE, string C_PRE_STEELGRADE, string C_LENGTH, string C_W_IDTH, string C_THICKNESS, string C_CASTER_ID, string C_BOF_ID, string C_LF_ID, string C_RH_ID, string C_LD_DESC, string C_LF_DESC, string C_RH_DESC, string C_CC_DESC)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("UPDATE TPP_CAST_PLAN SET C_PRE_STEELGRADEINDEX='" + C_PRE_STEELGRADEINDEX + "',C_PLAN_ORD__ID='" + C_ORDER_NO + "',C_REFINE_TYPE='" + C_REFINE_TYPE + "',C_PRE_STEELGRADE='" + C_PRE_STEELGRADE + "',C_LENGTH='" + C_LENGTH + "',C_W_IDTH='" + C_W_IDTH + "',C_THICKNESS='" + C_THICKNESS + "',C_CASTER_ID='" + C_CASTER_ID + "',C_LF_ID='" + C_LF_ID + "',C_RH_ID='" + C_RH_ID + "',C_LF_DESC='" + C_LF_DESC + "',C_RH_DESC='" + C_RH_DESC + "',C_CC_DESC='" + C_CC_DESC + "' WHERE C_ID='" + C_ID + "' ");

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
        /// 获取最大炉号
        /// </summary>
        /// <param name="C_LD_ID">转炉ID</param>
        /// <returns></returns>
        public string Get_Max_Stove_Trans(string C_LD_ID, string str_Is_BXG)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT MAX(TC.C_HEAT_ID)  FROM TPP_CAST_PLAN TC WHERE TC.C_BOF_ID = '" + C_LD_ID + "' ");

            if (str_Is_BXG == "N")
            {
                strSql.Append(" and TC.C_HEAT_ID like '2%' ");
            }
            else
            {
                strSql.Append(" and TC.C_HEAT_ID like '6%' ");
            }

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
        /// 更新一条数据
        /// </summary>
        public bool Update_Stove_Trans(string C_ID, string stove, string lgjh)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("UPDATE TPP_CAST_PLAN SET C_HEAT_ID = '" + stove + "',C_PRE_STEELGRADEINDEX='" + lgjh + "'  WHERE C_ID = '" + C_ID + "' ");

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
        /// 获取最大计划号
        /// </summary>
        /// <param name="V_CC_CODE">MES连铸代码</param>
        /// <returns></returns>
        public string Get_Max_PLANID(string V_CC_CODE)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT MAX(T.PLANID) FROM CPLAN_CASTING@cap_mes T WHERE T.PLANID LIKE '%" + V_CC_CODE + "%' ");

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
        /// 查询订单数
        /// </summary>
        /// <param name="C_PLAN_ORD__ID">订单号</param>
        /// <returns></returns>
        public int Get_Order_Num(string C_PLAN_ORD__ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT count(1)  FROM CPLAN_ORDER@cap_mes WHERE PLANID = '" + C_PLAN_ORD__ID + "' ");

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
        /// 更新一条数据
        /// </summary>
        public bool Insert_Mes_Trans(string sql)
        {
            int rows = TransactionHelper.ExecuteSql(sql);
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
        public bool Update_Plan_State_Trans(string C_ID, string V_PLANID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("UPDATE TPP_CAST_PLAN T SET T.C_IS_TO_MES = '1', T.C_MES_PLAN_ID = '" + V_PLANID + "', T.D_DOWN_TIME = SYSDATE WHERE T.C_ID = '" + C_ID + "' ");

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
        /// 获取需要撤销计划
        /// </summary>
        /// <param name="P_CC_ID">连铸ID</param>
        /// <param name="N_SORT">顺序号</param>
        /// <returns></returns>
        public DataSet Get_Back_List_WXF(string P_CC_ID, int N_SORT)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select t.* from TPP_CAST_PLAN t INNER JOIN TSP_PLAN_SMS TB ON T.C_PLAN_ID = TB.C_ID ");

            strSql.Append(" WHERE TB.N_STATUS = 1   ");

            strSql.Append(" AND T.C_IS_TO_MES = '0' ");

            strSql.Append(" AND T.C_CASTER_ID = '" + P_CC_ID + "' ");

            strSql.Append(" and TB.N_SORT >=" + N_SORT + " ");

            strSql.Append(" ORDER BY TB.N_SORT asc ");

            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取需要撤销计划
        /// </summary>
        /// <param name="P_CC_ID">连铸ID</param>
        /// <param name="N_SORT">顺序号</param>
        /// <returns></returns>
        public DataSet Get_Back_List_WXF(string P_CC_ID, string c_fk)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select t.* from TPP_CAST_PLAN t INNER JOIN TSP_PLAN_SMS TB ON T.C_PLAN_ID = TB.C_ID ");

            strSql.Append(" WHERE TB.N_STATUS = 1   ");

            strSql.Append(" AND T.C_IS_TO_MES = '0' ");

            strSql.Append(" AND T.C_CASTER_ID = '" + P_CC_ID + "' ");

            strSql.Append(" and TB.c_fk='" + c_fk + "' ");

            strSql.Append(" ORDER BY TB.N_SORT asc ");

            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取需要撤销计划的状态
        /// </summary>
        /// <param name="C_PLAN_ID">tsp_plan_sms主键</param>
        /// <returns></returns>
        public int Get_Plan_State(string C_PLAN_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT count(1)  FROM TPP_CAST_PLAN T ");

            strSql.Append(" WHERE 1=1  ");

            strSql.Append(" AND T.C_IS_TO_MES = '1' ");

            strSql.Append(" AND T.C_PLAN_ID = '" + C_PLAN_ID + "' ");

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
        /// 获取指定炉号计划；MES是否执行
        /// </summary>
        /// <param name="stove">炉号</param>
        /// <returns></returns>
        public int Get_Stove_State(string stove)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT count(1) FROM CPLAN_TAPPING@cap_mes T where t.status<>'10' and t.heatid='" + stove + "' ");

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
        /// 获取指定炉号是否开吹
        /// </summary>
        /// <param name="stove">炉号</param>
        /// <returns></returns>
        public int Get_Stove_Is_KC(string stove)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT count(1) FROM CPLAN_TAPPING@cap_mes T where t.status>11 and t.heatid='" + stove + "' ");

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
        /// 获取指定炉号是否已生产
        /// </summary>
        /// <param name="stove">炉号</param>
        /// <returns></returns>
        public int Get_Stove_Count(string stove)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select Count(1) from CBloom_Data@cap_mes where HeatID='" + stove + "' ");

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
        /// 获取指定炉号是否已生产
        /// </summary>
        /// <param name="stove">炉号</param>
        /// <returns></returns>
        public string Get_Mes_PreHeatId(string stove)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select preheatid from CPlan_Tapping@cap_mes where HeatID='" + stove + "' ");

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
        /// 获取需要撤销计划
        /// </summary>
        /// <param name="P_ZL_ID">转炉ID</param>
        /// <param name="stove">炉号</param>
        /// <returns></returns>
        public DataSet Get_Back_List_YXF(string P_ZL_ID, string stove)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT T.*  FROM TPP_CAST_PLAN T ");

            strSql.Append(" WHERE 1=1  ");

            strSql.Append(" AND T.C_IS_TO_MES = '1' ");

            strSql.Append(" AND T.C_BOF_ID = '" + P_ZL_ID + "' ");

            strSql.Append(" AND T.C_HEAT_ID >= '" + stove + "' ");

            strSql.Append(" ORDER BY T.C_HEAT_ID ASC ");

            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Delete_Mes_Trans(string sql)
        {
            int rows = TransactionHelper.ExecuteSql(sql);
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
        public bool Update_Mes_Trans(string sql)
        {
            int rows = TransactionHelper.ExecuteSql(sql);
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
        /// 查询订单数
        /// </summary>
        /// <returns></returns>
        public int Get_NC_Count(string strSql)
        {
            object obj = DbHelperOra.GetSingle(strSql);
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
        /// 查询订单数
        /// </summary>
        /// <returns></returns>
        public int Get_Mes_Count(string strSql)
        {
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

        #endregion  BasicMethod

        #region 炼钢计划排产
        /// <summary>
        /// 删除已下调度计划
        /// </summary>
        /// <param name="C_PLAN_ID">炉次计划主键</param>
        /// <returns></returns>
        public bool DeletePlan(string C_PLAN_ID)
        {
            string sql = @"SELECT COUNT(1)  FROM TPP_CAST_PLAN T WHERE T.C_IS_TO_MES = 0   AND T.C_PLAN_ID = '" + C_PLAN_ID + "'";

            object obj = DbHelperOra.GetSingle(sql);
            if (obj == null)
            {
                return false;
            }
            else
            {
                string strSql = " DELETE FROM TPP_CAST_PLAN T WHERE T.C_IS_TO_MES = 0   AND T.C_PLAN_ID = '" + C_PLAN_ID + "'";
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


        }

        #endregion
    }
}

