using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;
using System.Collections;

namespace DAL
{
    /// <summary>
    /// 数据访问类:TSC_SLAB_MES
    /// </summary>
    public partial class Dal_TSC_SLAB_MES
    {
        public Dal_TSC_SLAB_MES()
        { }
        #region  BasicMethod



        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Mod_TSC_SLAB_MES model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TSC_SLAB_MES(");
            strSql.Append("GUID,NAME,MATERIALID,STATUS,POSITION,QASTATUS,QALEVEL,ORDERCONTRACTID,PRODUCECONTRACTID,SALESCONTRACTID,CASTERID,CASTING_NO,CASTING_HEAT_CNT,PRE_STEELGRADEINDEX,STEELGRADEINDEX,CUT_STEELGRADEINDEX,FINAL_STEELGRADEINDEX,LENGTH,WIDTH,THICKNESS,CUR_SECTION_ID,CUR_PILE_ID,CUR_LAYER_ID,CUR_SEQ_ID,CUR_BAY_ID,DESTINATION,HOT_SEND_FLAG,PROCESS_TYPE,PLAN_ORD_ID,PRODUCE_DATE,FINISH_FLAG,FINISHEDTIME,BLOOM_COUNT,CAL_WEIGHT,RIGHT_COUNT,RIGHT_WEIGHT,WASTER_COUNT,WASTER_WEIGHT,WASTER_COUNT1,WASTER_WEIGHT1,WASTER_REASON1,WASTER_COUNT2,WASTER_WEIGHT2,WASTER_REASON2,WASTER_COUNT3,WASTER_WEIGHT3,WASTER_REASON3,WRONG_COUNT,WRONG_WEIGHT,WRONG_COUNT1,WRONG_WEIGHT1,WRONG_REASON1,WRONG_COUNT2,WRONG_WEIGHT2,WRONG_REASON2,WRONG_COUNT3,WRONG_WEIGHT3,WRONG_REASON3,SUFACEDEFACTDES,REASON,HEATID,TEST_ROLL_COUNT,TEST_ROLL_WEIGHT,BACK_FLAG,BACK_DATE,ADD_BLOOM_COUNT,DIV_BLOOM_COUNT,PLAN_BLOOM_COUNT,ADD_DIV_HEATID,ADD_HEATID1,ADD_HEATID2,ADD_BLOOM_COUNT2,D_INSERT_TIME,C_UP_STATE)");
            strSql.Append(" values (");
            strSql.Append(":GUID,:NAME,:MATERIALID,:STATUS,:POSITION,:QASTATUS,:QALEVEL,:ORDERCONTRACTID,:PRODUCECONTRACTID,:SALESCONTRACTID,:CASTERID,:CASTING_NO,:CASTING_HEAT_CNT,:PRE_STEELGRADEINDEX,:STEELGRADEINDEX,:CUT_STEELGRADEINDEX,:FINAL_STEELGRADEINDEX,:LENGTH,:WIDTH,:THICKNESS,:CUR_SECTION_ID,:CUR_PILE_ID,:CUR_LAYER_ID,:CUR_SEQ_ID,:CUR_BAY_ID,:DESTINATION,:HOT_SEND_FLAG,:PROCESS_TYPE,:PLAN_ORD_ID,:PRODUCE_DATE,:FINISH_FLAG,:FINISHEDTIME,:BLOOM_COUNT,:CAL_WEIGHT,:RIGHT_COUNT,:RIGHT_WEIGHT,:WASTER_COUNT,:WASTER_WEIGHT,:WASTER_COUNT1,:WASTER_WEIGHT1,:WASTER_REASON1,:WASTER_COUNT2,:WASTER_WEIGHT2,:WASTER_REASON2,:WASTER_COUNT3,:WASTER_WEIGHT3,:WASTER_REASON3,:WRONG_COUNT,:WRONG_WEIGHT,:WRONG_COUNT1,:WRONG_WEIGHT1,:WRONG_REASON1,:WRONG_COUNT2,:WRONG_WEIGHT2,:WRONG_REASON2,:WRONG_COUNT3,:WRONG_WEIGHT3,:WRONG_REASON3,:SUFACEDEFACTDES,:REASON,:HEATID,:TEST_ROLL_COUNT,:TEST_ROLL_WEIGHT,:BACK_FLAG,:BACK_DATE,:ADD_BLOOM_COUNT,:DIV_BLOOM_COUNT,:PLAN_BLOOM_COUNT,:ADD_DIV_HEATID,:ADD_HEATID1,:ADD_HEATID2,:ADD_BLOOM_COUNT2,:D_INSERT_TIME,:C_UP_STATE)");
            OracleParameter[] parameters = {
                    new OracleParameter(":GUID", OracleDbType.Varchar2,250),
                    new OracleParameter(":NAME", OracleDbType.Varchar2,250),
                    new OracleParameter(":MATERIALID", OracleDbType.Varchar2,250),
                    new OracleParameter(":STATUS", OracleDbType.Decimal,10),
                    new OracleParameter(":POSITION", OracleDbType.Varchar2,250),
                    new OracleParameter(":QASTATUS", OracleDbType.Decimal,10),
                    new OracleParameter(":QALEVEL", OracleDbType.Decimal,10),
                    new OracleParameter(":ORDERCONTRACTID", OracleDbType.Varchar2,250),
                    new OracleParameter(":PRODUCECONTRACTID", OracleDbType.Varchar2,250),
                    new OracleParameter(":SALESCONTRACTID", OracleDbType.Varchar2,250),
                    new OracleParameter(":CASTERID", OracleDbType.Varchar2,250),
                    new OracleParameter(":CASTING_NO", OracleDbType.Varchar2,250),
                    new OracleParameter(":CASTING_HEAT_CNT", OracleDbType.Decimal,10),
                    new OracleParameter(":PRE_STEELGRADEINDEX", OracleDbType.Varchar2,250),
                    new OracleParameter(":STEELGRADEINDEX", OracleDbType.Varchar2,250),
                    new OracleParameter(":CUT_STEELGRADEINDEX", OracleDbType.Varchar2,250),
                    new OracleParameter(":FINAL_STEELGRADEINDEX", OracleDbType.Varchar2,250),
                    new OracleParameter(":LENGTH", OracleDbType.Decimal,10),
                    new OracleParameter(":WIDTH", OracleDbType.Decimal,10),
                    new OracleParameter(":THICKNESS", OracleDbType.Decimal,10),
                    new OracleParameter(":CUR_SECTION_ID", OracleDbType.Varchar2,250),
                    new OracleParameter(":CUR_PILE_ID", OracleDbType.Varchar2,250),
                    new OracleParameter(":CUR_LAYER_ID", OracleDbType.Varchar2,250),
                    new OracleParameter(":CUR_SEQ_ID", OracleDbType.Decimal,10),
                    new OracleParameter(":CUR_BAY_ID", OracleDbType.Varchar2,250),
                    new OracleParameter(":DESTINATION", OracleDbType.Varchar2,250),
                    new OracleParameter(":HOT_SEND_FLAG", OracleDbType.Decimal,10),
                    new OracleParameter(":PROCESS_TYPE", OracleDbType.Decimal,10),
                    new OracleParameter(":PLAN_ORD_ID", OracleDbType.Varchar2,250),
                    new OracleParameter(":PRODUCE_DATE", OracleDbType.Date),
                    new OracleParameter(":FINISH_FLAG", OracleDbType.Decimal,10),
                    new OracleParameter(":FINISHEDTIME", OracleDbType.Date),
                    new OracleParameter(":BLOOM_COUNT", OracleDbType.Decimal,10),
                    new OracleParameter(":CAL_WEIGHT", OracleDbType.Decimal,10),
                    new OracleParameter(":RIGHT_COUNT", OracleDbType.Decimal,10),
                    new OracleParameter(":RIGHT_WEIGHT", OracleDbType.Decimal,10),
                    new OracleParameter(":WASTER_COUNT", OracleDbType.Decimal,10),
                    new OracleParameter(":WASTER_WEIGHT", OracleDbType.Decimal,10),
                    new OracleParameter(":WASTER_COUNT1", OracleDbType.Decimal,10),
                    new OracleParameter(":WASTER_WEIGHT1", OracleDbType.Decimal,10),
                    new OracleParameter(":WASTER_REASON1", OracleDbType.Varchar2,250),
                    new OracleParameter(":WASTER_COUNT2", OracleDbType.Decimal,10),
                    new OracleParameter(":WASTER_WEIGHT2", OracleDbType.Decimal,10),
                    new OracleParameter(":WASTER_REASON2", OracleDbType.Varchar2,250),
                    new OracleParameter(":WASTER_COUNT3", OracleDbType.Decimal,10),
                    new OracleParameter(":WASTER_WEIGHT3", OracleDbType.Decimal,10),
                    new OracleParameter(":WASTER_REASON3", OracleDbType.Varchar2,250),
                    new OracleParameter(":WRONG_COUNT", OracleDbType.Decimal,10),
                    new OracleParameter(":WRONG_WEIGHT", OracleDbType.Decimal,10),
                    new OracleParameter(":WRONG_COUNT1", OracleDbType.Decimal,10),
                    new OracleParameter(":WRONG_WEIGHT1", OracleDbType.Decimal,10),
                    new OracleParameter(":WRONG_REASON1", OracleDbType.Varchar2,250),
                    new OracleParameter(":WRONG_COUNT2", OracleDbType.Decimal,10),
                    new OracleParameter(":WRONG_WEIGHT2", OracleDbType.Decimal,10),
                    new OracleParameter(":WRONG_REASON2", OracleDbType.Varchar2,250),
                    new OracleParameter(":WRONG_COUNT3", OracleDbType.Decimal,10),
                    new OracleParameter(":WRONG_WEIGHT3", OracleDbType.Decimal,10),
                    new OracleParameter(":WRONG_REASON3", OracleDbType.Varchar2,250),
                    new OracleParameter(":SUFACEDEFACTDES", OracleDbType.Varchar2,250),
                    new OracleParameter(":REASON", OracleDbType.Varchar2,250),
                    new OracleParameter(":HEATID", OracleDbType.Varchar2,250),
                    new OracleParameter(":TEST_ROLL_COUNT", OracleDbType.Decimal,10),
                    new OracleParameter(":TEST_ROLL_WEIGHT", OracleDbType.Decimal,10),
                    new OracleParameter(":BACK_FLAG", OracleDbType.Decimal,10),
                    new OracleParameter(":BACK_DATE", OracleDbType.Date),
                    new OracleParameter(":ADD_BLOOM_COUNT", OracleDbType.Decimal,10),
                    new OracleParameter(":DIV_BLOOM_COUNT", OracleDbType.Decimal,10),
                    new OracleParameter(":PLAN_BLOOM_COUNT", OracleDbType.Decimal,10),
                    new OracleParameter(":ADD_DIV_HEATID", OracleDbType.Varchar2,250),
                    new OracleParameter(":ADD_HEATID1", OracleDbType.Varchar2,250),
                    new OracleParameter(":ADD_HEATID2", OracleDbType.Varchar2,250),
                    new OracleParameter(":ADD_BLOOM_COUNT2", OracleDbType.Decimal,10),
                    new OracleParameter(":D_INSERT_TIME", OracleDbType.Date),
                    new OracleParameter(":C_UP_STATE", OracleDbType.Varchar2,10)};
            parameters[0].Value = model.GUID;
            parameters[1].Value = model.NAME;
            parameters[2].Value = model.MATERIALID;
            parameters[3].Value = model.STATUS;
            parameters[4].Value = model.POSITION;
            parameters[5].Value = model.QASTATUS;
            parameters[6].Value = model.QALEVEL;
            parameters[7].Value = model.ORDERCONTRACTID;
            parameters[8].Value = model.PRODUCECONTRACTID;
            parameters[9].Value = model.SALESCONTRACTID;
            parameters[10].Value = model.CASTERID;
            parameters[11].Value = model.CASTING_NO;
            parameters[12].Value = model.CASTING_HEAT_CNT;
            parameters[13].Value = model.PRE_STEELGRADEINDEX;
            parameters[14].Value = model.STEELGRADEINDEX;
            parameters[15].Value = model.CUT_STEELGRADEINDEX;
            parameters[16].Value = model.FINAL_STEELGRADEINDEX;
            parameters[17].Value = model.LENGTH;
            parameters[18].Value = model.WIDTH;
            parameters[19].Value = model.THICKNESS;
            parameters[20].Value = model.CUR_SECTION_ID;
            parameters[21].Value = model.CUR_PILE_ID;
            parameters[22].Value = model.CUR_LAYER_ID;
            parameters[23].Value = model.CUR_SEQ_ID;
            parameters[24].Value = model.CUR_BAY_ID;
            parameters[25].Value = model.DESTINATION;
            parameters[26].Value = model.HOT_SEND_FLAG;
            parameters[27].Value = model.PROCESS_TYPE;
            parameters[28].Value = model.PLAN_ORD_ID;
            parameters[29].Value = model.PRODUCE_DATE;
            parameters[30].Value = model.FINISH_FLAG;
            parameters[31].Value = model.FINISHEDTIME;
            parameters[32].Value = model.BLOOM_COUNT;
            parameters[33].Value = model.CAL_WEIGHT;
            parameters[34].Value = model.RIGHT_COUNT;
            parameters[35].Value = model.RIGHT_WEIGHT;
            parameters[36].Value = model.WASTER_COUNT;
            parameters[37].Value = model.WASTER_WEIGHT;
            parameters[38].Value = model.WASTER_COUNT1;
            parameters[39].Value = model.WASTER_WEIGHT1;
            parameters[40].Value = model.WASTER_REASON1;
            parameters[41].Value = model.WASTER_COUNT2;
            parameters[42].Value = model.WASTER_WEIGHT2;
            parameters[43].Value = model.WASTER_REASON2;
            parameters[44].Value = model.WASTER_COUNT3;
            parameters[45].Value = model.WASTER_WEIGHT3;
            parameters[46].Value = model.WASTER_REASON3;
            parameters[47].Value = model.WRONG_COUNT;
            parameters[48].Value = model.WRONG_WEIGHT;
            parameters[49].Value = model.WRONG_COUNT1;
            parameters[50].Value = model.WRONG_WEIGHT1;
            parameters[51].Value = model.WRONG_REASON1;
            parameters[52].Value = model.WRONG_COUNT2;
            parameters[53].Value = model.WRONG_WEIGHT2;
            parameters[54].Value = model.WRONG_REASON2;
            parameters[55].Value = model.WRONG_COUNT3;
            parameters[56].Value = model.WRONG_WEIGHT3;
            parameters[57].Value = model.WRONG_REASON3;
            parameters[58].Value = model.SUFACEDEFACTDES;
            parameters[59].Value = model.REASON;
            parameters[60].Value = model.HEATID;
            parameters[61].Value = model.TEST_ROLL_COUNT;
            parameters[62].Value = model.TEST_ROLL_WEIGHT;
            parameters[63].Value = model.BACK_FLAG;
            parameters[64].Value = model.BACK_DATE;
            parameters[65].Value = model.ADD_BLOOM_COUNT;
            parameters[66].Value = model.DIV_BLOOM_COUNT;
            parameters[67].Value = model.PLAN_BLOOM_COUNT;
            parameters[68].Value = model.ADD_DIV_HEATID;
            parameters[69].Value = model.ADD_HEATID1;
            parameters[70].Value = model.ADD_HEATID2;
            parameters[71].Value = model.ADD_BLOOM_COUNT2;
            parameters[72].Value = model.D_INSERT_TIME;
            parameters[73].Value = model.C_UP_STATE;

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
        public bool Update(Mod_TSC_SLAB_MES model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TSC_SLAB_MES set ");
            strSql.Append("GUID=:GUID,");
            strSql.Append("NAME=:NAME,");
            strSql.Append("MATERIALID=:MATERIALID,");
            strSql.Append("STATUS=:STATUS,");
            strSql.Append("POSITION=:POSITION,");
            strSql.Append("QASTATUS=:QASTATUS,");
            strSql.Append("QALEVEL=:QALEVEL,");
            strSql.Append("ORDERCONTRACTID=:ORDERCONTRACTID,");
            strSql.Append("PRODUCECONTRACTID=:PRODUCECONTRACTID,");
            strSql.Append("SALESCONTRACTID=:SALESCONTRACTID,");
            strSql.Append("CASTERID=:CASTERID,");
            strSql.Append("CASTING_NO=:CASTING_NO,");
            strSql.Append("CASTING_HEAT_CNT=:CASTING_HEAT_CNT,");
            strSql.Append("PRE_STEELGRADEINDEX=:PRE_STEELGRADEINDEX,");
            strSql.Append("STEELGRADEINDEX=:STEELGRADEINDEX,");
            strSql.Append("CUT_STEELGRADEINDEX=:CUT_STEELGRADEINDEX,");
            strSql.Append("FINAL_STEELGRADEINDEX=:FINAL_STEELGRADEINDEX,");
            strSql.Append("LENGTH=:LENGTH,");
            strSql.Append("WIDTH=:WIDTH,");
            strSql.Append("THICKNESS=:THICKNESS,");
            strSql.Append("CUR_SECTION_ID=:CUR_SECTION_ID,");
            strSql.Append("CUR_PILE_ID=:CUR_PILE_ID,");
            strSql.Append("CUR_LAYER_ID=:CUR_LAYER_ID,");
            strSql.Append("CUR_SEQ_ID=:CUR_SEQ_ID,");
            strSql.Append("CUR_BAY_ID=:CUR_BAY_ID,");
            strSql.Append("DESTINATION=:DESTINATION,");
            strSql.Append("HOT_SEND_FLAG=:HOT_SEND_FLAG,");
            strSql.Append("PROCESS_TYPE=:PROCESS_TYPE,");
            strSql.Append("PLAN_ORD_ID=:PLAN_ORD_ID,");
            strSql.Append("PRODUCE_DATE=:PRODUCE_DATE,");
            strSql.Append("FINISH_FLAG=:FINISH_FLAG,");
            strSql.Append("FINISHEDTIME=:FINISHEDTIME,");
            strSql.Append("BLOOM_COUNT=:BLOOM_COUNT,");
            strSql.Append("CAL_WEIGHT=:CAL_WEIGHT,");
            strSql.Append("RIGHT_COUNT=:RIGHT_COUNT,");
            strSql.Append("RIGHT_WEIGHT=:RIGHT_WEIGHT,");
            strSql.Append("WASTER_COUNT=:WASTER_COUNT,");
            strSql.Append("WASTER_WEIGHT=:WASTER_WEIGHT,");
            strSql.Append("WASTER_COUNT1=:WASTER_COUNT1,");
            strSql.Append("WASTER_WEIGHT1=:WASTER_WEIGHT1,");
            strSql.Append("WASTER_REASON1=:WASTER_REASON1,");
            strSql.Append("WASTER_COUNT2=:WASTER_COUNT2,");
            strSql.Append("WASTER_WEIGHT2=:WASTER_WEIGHT2,");
            strSql.Append("WASTER_REASON2=:WASTER_REASON2,");
            strSql.Append("WASTER_COUNT3=:WASTER_COUNT3,");
            strSql.Append("WASTER_WEIGHT3=:WASTER_WEIGHT3,");
            strSql.Append("WASTER_REASON3=:WASTER_REASON3,");
            strSql.Append("WRONG_COUNT=:WRONG_COUNT,");
            strSql.Append("WRONG_WEIGHT=:WRONG_WEIGHT,");
            strSql.Append("WRONG_COUNT1=:WRONG_COUNT1,");
            strSql.Append("WRONG_WEIGHT1=:WRONG_WEIGHT1,");
            strSql.Append("WRONG_REASON1=:WRONG_REASON1,");
            strSql.Append("WRONG_COUNT2=:WRONG_COUNT2,");
            strSql.Append("WRONG_WEIGHT2=:WRONG_WEIGHT2,");
            strSql.Append("WRONG_REASON2=:WRONG_REASON2,");
            strSql.Append("WRONG_COUNT3=:WRONG_COUNT3,");
            strSql.Append("WRONG_WEIGHT3=:WRONG_WEIGHT3,");
            strSql.Append("WRONG_REASON3=:WRONG_REASON3,");
            strSql.Append("SUFACEDEFACTDES=:SUFACEDEFACTDES,");
            strSql.Append("REASON=:REASON,");
            strSql.Append("HEATID=:HEATID,");
            strSql.Append("TEST_ROLL_COUNT=:TEST_ROLL_COUNT,");
            strSql.Append("TEST_ROLL_WEIGHT=:TEST_ROLL_WEIGHT,");
            strSql.Append("BACK_FLAG=:BACK_FLAG,");
            strSql.Append("BACK_DATE=:BACK_DATE,");
            strSql.Append("ADD_BLOOM_COUNT=:ADD_BLOOM_COUNT,");
            strSql.Append("DIV_BLOOM_COUNT=:DIV_BLOOM_COUNT,");
            strSql.Append("PLAN_BLOOM_COUNT=:PLAN_BLOOM_COUNT,");
            strSql.Append("ADD_DIV_HEATID=:ADD_DIV_HEATID,");
            strSql.Append("ADD_HEATID1=:ADD_HEATID1,");
            strSql.Append("ADD_HEATID2=:ADD_HEATID2,");
            strSql.Append("ADD_BLOOM_COUNT2=:ADD_BLOOM_COUNT2,");
            strSql.Append("D_INSERT_TIME=:D_INSERT_TIME,");
            strSql.Append("C_UP_STATE=:C_UP_STATE");
            strSql.Append(" where ");
            OracleParameter[] parameters = {
                    new OracleParameter(":GUID", OracleDbType.Varchar2,250),
                    new OracleParameter(":NAME", OracleDbType.Varchar2,250),
                    new OracleParameter(":MATERIALID", OracleDbType.Varchar2,250),
                    new OracleParameter(":STATUS", OracleDbType.Decimal,10),
                    new OracleParameter(":POSITION", OracleDbType.Varchar2,250),
                    new OracleParameter(":QASTATUS", OracleDbType.Decimal,10),
                    new OracleParameter(":QALEVEL", OracleDbType.Decimal,10),
                    new OracleParameter(":ORDERCONTRACTID", OracleDbType.Varchar2,250),
                    new OracleParameter(":PRODUCECONTRACTID", OracleDbType.Varchar2,250),
                    new OracleParameter(":SALESCONTRACTID", OracleDbType.Varchar2,250),
                    new OracleParameter(":CASTERID", OracleDbType.Varchar2,250),
                    new OracleParameter(":CASTING_NO", OracleDbType.Varchar2,250),
                    new OracleParameter(":CASTING_HEAT_CNT", OracleDbType.Decimal,10),
                    new OracleParameter(":PRE_STEELGRADEINDEX", OracleDbType.Varchar2,250),
                    new OracleParameter(":STEELGRADEINDEX", OracleDbType.Varchar2,250),
                    new OracleParameter(":CUT_STEELGRADEINDEX", OracleDbType.Varchar2,250),
                    new OracleParameter(":FINAL_STEELGRADEINDEX", OracleDbType.Varchar2,250),
                    new OracleParameter(":LENGTH", OracleDbType.Decimal,10),
                    new OracleParameter(":WIDTH", OracleDbType.Decimal,10),
                    new OracleParameter(":THICKNESS", OracleDbType.Decimal,10),
                    new OracleParameter(":CUR_SECTION_ID", OracleDbType.Varchar2,250),
                    new OracleParameter(":CUR_PILE_ID", OracleDbType.Varchar2,250),
                    new OracleParameter(":CUR_LAYER_ID", OracleDbType.Varchar2,250),
                    new OracleParameter(":CUR_SEQ_ID", OracleDbType.Decimal,10),
                    new OracleParameter(":CUR_BAY_ID", OracleDbType.Varchar2,250),
                    new OracleParameter(":DESTINATION", OracleDbType.Varchar2,250),
                    new OracleParameter(":HOT_SEND_FLAG", OracleDbType.Decimal,10),
                    new OracleParameter(":PROCESS_TYPE", OracleDbType.Decimal,10),
                    new OracleParameter(":PLAN_ORD_ID", OracleDbType.Varchar2,250),
                    new OracleParameter(":PRODUCE_DATE", OracleDbType.Date),
                    new OracleParameter(":FINISH_FLAG", OracleDbType.Decimal,10),
                    new OracleParameter(":FINISHEDTIME", OracleDbType.Date),
                    new OracleParameter(":BLOOM_COUNT", OracleDbType.Decimal,10),
                    new OracleParameter(":CAL_WEIGHT", OracleDbType.Decimal,10),
                    new OracleParameter(":RIGHT_COUNT", OracleDbType.Decimal,10),
                    new OracleParameter(":RIGHT_WEIGHT", OracleDbType.Decimal,10),
                    new OracleParameter(":WASTER_COUNT", OracleDbType.Decimal,10),
                    new OracleParameter(":WASTER_WEIGHT", OracleDbType.Decimal,10),
                    new OracleParameter(":WASTER_COUNT1", OracleDbType.Decimal,10),
                    new OracleParameter(":WASTER_WEIGHT1", OracleDbType.Decimal,10),
                    new OracleParameter(":WASTER_REASON1", OracleDbType.Varchar2,250),
                    new OracleParameter(":WASTER_COUNT2", OracleDbType.Decimal,10),
                    new OracleParameter(":WASTER_WEIGHT2", OracleDbType.Decimal,10),
                    new OracleParameter(":WASTER_REASON2", OracleDbType.Varchar2,250),
                    new OracleParameter(":WASTER_COUNT3", OracleDbType.Decimal,10),
                    new OracleParameter(":WASTER_WEIGHT3", OracleDbType.Decimal,10),
                    new OracleParameter(":WASTER_REASON3", OracleDbType.Varchar2,250),
                    new OracleParameter(":WRONG_COUNT", OracleDbType.Decimal,10),
                    new OracleParameter(":WRONG_WEIGHT", OracleDbType.Decimal,10),
                    new OracleParameter(":WRONG_COUNT1", OracleDbType.Decimal,10),
                    new OracleParameter(":WRONG_WEIGHT1", OracleDbType.Decimal,10),
                    new OracleParameter(":WRONG_REASON1", OracleDbType.Varchar2,250),
                    new OracleParameter(":WRONG_COUNT2", OracleDbType.Decimal,10),
                    new OracleParameter(":WRONG_WEIGHT2", OracleDbType.Decimal,10),
                    new OracleParameter(":WRONG_REASON2", OracleDbType.Varchar2,250),
                    new OracleParameter(":WRONG_COUNT3", OracleDbType.Decimal,10),
                    new OracleParameter(":WRONG_WEIGHT3", OracleDbType.Decimal,10),
                    new OracleParameter(":WRONG_REASON3", OracleDbType.Varchar2,250),
                    new OracleParameter(":SUFACEDEFACTDES", OracleDbType.Varchar2,250),
                    new OracleParameter(":REASON", OracleDbType.Varchar2,250),
                    new OracleParameter(":HEATID", OracleDbType.Varchar2,250),
                    new OracleParameter(":TEST_ROLL_COUNT", OracleDbType.Decimal,10),
                    new OracleParameter(":TEST_ROLL_WEIGHT", OracleDbType.Decimal,10),
                    new OracleParameter(":BACK_FLAG", OracleDbType.Decimal,10),
                    new OracleParameter(":BACK_DATE", OracleDbType.Date),
                    new OracleParameter(":ADD_BLOOM_COUNT", OracleDbType.Decimal,10),
                    new OracleParameter(":DIV_BLOOM_COUNT", OracleDbType.Decimal,10),
                    new OracleParameter(":PLAN_BLOOM_COUNT", OracleDbType.Decimal,10),
                    new OracleParameter(":ADD_DIV_HEATID", OracleDbType.Varchar2,250),
                    new OracleParameter(":ADD_HEATID1", OracleDbType.Varchar2,250),
                    new OracleParameter(":ADD_HEATID2", OracleDbType.Varchar2,250),
                    new OracleParameter(":ADD_BLOOM_COUNT2", OracleDbType.Decimal,10),
                    new OracleParameter(":D_INSERT_TIME", OracleDbType.Date),
                    new OracleParameter(":C_UP_STATE", OracleDbType.Varchar2,10)};
            parameters[0].Value = model.GUID;
            parameters[1].Value = model.NAME;
            parameters[2].Value = model.MATERIALID;
            parameters[3].Value = model.STATUS;
            parameters[4].Value = model.POSITION;
            parameters[5].Value = model.QASTATUS;
            parameters[6].Value = model.QALEVEL;
            parameters[7].Value = model.ORDERCONTRACTID;
            parameters[8].Value = model.PRODUCECONTRACTID;
            parameters[9].Value = model.SALESCONTRACTID;
            parameters[10].Value = model.CASTERID;
            parameters[11].Value = model.CASTING_NO;
            parameters[12].Value = model.CASTING_HEAT_CNT;
            parameters[13].Value = model.PRE_STEELGRADEINDEX;
            parameters[14].Value = model.STEELGRADEINDEX;
            parameters[15].Value = model.CUT_STEELGRADEINDEX;
            parameters[16].Value = model.FINAL_STEELGRADEINDEX;
            parameters[17].Value = model.LENGTH;
            parameters[18].Value = model.WIDTH;
            parameters[19].Value = model.THICKNESS;
            parameters[20].Value = model.CUR_SECTION_ID;
            parameters[21].Value = model.CUR_PILE_ID;
            parameters[22].Value = model.CUR_LAYER_ID;
            parameters[23].Value = model.CUR_SEQ_ID;
            parameters[24].Value = model.CUR_BAY_ID;
            parameters[25].Value = model.DESTINATION;
            parameters[26].Value = model.HOT_SEND_FLAG;
            parameters[27].Value = model.PROCESS_TYPE;
            parameters[28].Value = model.PLAN_ORD_ID;
            parameters[29].Value = model.PRODUCE_DATE;
            parameters[30].Value = model.FINISH_FLAG;
            parameters[31].Value = model.FINISHEDTIME;
            parameters[32].Value = model.BLOOM_COUNT;
            parameters[33].Value = model.CAL_WEIGHT;
            parameters[34].Value = model.RIGHT_COUNT;
            parameters[35].Value = model.RIGHT_WEIGHT;
            parameters[36].Value = model.WASTER_COUNT;
            parameters[37].Value = model.WASTER_WEIGHT;
            parameters[38].Value = model.WASTER_COUNT1;
            parameters[39].Value = model.WASTER_WEIGHT1;
            parameters[40].Value = model.WASTER_REASON1;
            parameters[41].Value = model.WASTER_COUNT2;
            parameters[42].Value = model.WASTER_WEIGHT2;
            parameters[43].Value = model.WASTER_REASON2;
            parameters[44].Value = model.WASTER_COUNT3;
            parameters[45].Value = model.WASTER_WEIGHT3;
            parameters[46].Value = model.WASTER_REASON3;
            parameters[47].Value = model.WRONG_COUNT;
            parameters[48].Value = model.WRONG_WEIGHT;
            parameters[49].Value = model.WRONG_COUNT1;
            parameters[50].Value = model.WRONG_WEIGHT1;
            parameters[51].Value = model.WRONG_REASON1;
            parameters[52].Value = model.WRONG_COUNT2;
            parameters[53].Value = model.WRONG_WEIGHT2;
            parameters[54].Value = model.WRONG_REASON2;
            parameters[55].Value = model.WRONG_COUNT3;
            parameters[56].Value = model.WRONG_WEIGHT3;
            parameters[57].Value = model.WRONG_REASON3;
            parameters[58].Value = model.SUFACEDEFACTDES;
            parameters[59].Value = model.REASON;
            parameters[60].Value = model.HEATID;
            parameters[61].Value = model.TEST_ROLL_COUNT;
            parameters[62].Value = model.TEST_ROLL_WEIGHT;
            parameters[63].Value = model.BACK_FLAG;
            parameters[64].Value = model.BACK_DATE;
            parameters[65].Value = model.ADD_BLOOM_COUNT;
            parameters[66].Value = model.DIV_BLOOM_COUNT;
            parameters[67].Value = model.PLAN_BLOOM_COUNT;
            parameters[68].Value = model.ADD_DIV_HEATID;
            parameters[69].Value = model.ADD_HEATID1;
            parameters[70].Value = model.ADD_HEATID2;
            parameters[71].Value = model.ADD_BLOOM_COUNT2;
            parameters[72].Value = model.D_INSERT_TIME;
            parameters[73].Value = model.C_UP_STATE;

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
        public bool Delete()
        {
            //该表无主键信息，请自定义主键/条件字段
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from TSC_SLAB_MES ");
            strSql.Append(" where ");
            OracleParameter[] parameters = {
            };

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
        public Mod_TSC_SLAB_MES GetModel(string stove)
        {
            //该表无主键信息，请自定义主键/条件字段
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select GUID,NAME,MATERIALID,STATUS,POSITION,QASTATUS,QALEVEL,ORDERCONTRACTID,PRODUCECONTRACTID,SALESCONTRACTID,CASTERID,CASTING_NO,CASTING_HEAT_CNT,PRE_STEELGRADEINDEX,STEELGRADEINDEX,CUT_STEELGRADEINDEX,FINAL_STEELGRADEINDEX,LENGTH,WIDTH,THICKNESS,CUR_SECTION_ID,CUR_PILE_ID,CUR_LAYER_ID,CUR_SEQ_ID,CUR_BAY_ID,DESTINATION,HOT_SEND_FLAG,PROCESS_TYPE,PLAN_ORD_ID,PRODUCE_DATE,FINISH_FLAG,FINISHEDTIME,BLOOM_COUNT,CAL_WEIGHT,RIGHT_COUNT,RIGHT_WEIGHT,WASTER_COUNT,WASTER_WEIGHT,WASTER_COUNT1,WASTER_WEIGHT1,WASTER_REASON1,WASTER_COUNT2,WASTER_WEIGHT2,WASTER_REASON2,WASTER_COUNT3,WASTER_WEIGHT3,WASTER_REASON3,WRONG_COUNT,WRONG_WEIGHT,WRONG_COUNT1,WRONG_WEIGHT1,WRONG_REASON1,WRONG_COUNT2,WRONG_WEIGHT2,WRONG_REASON2,WRONG_COUNT3,WRONG_WEIGHT3,WRONG_REASON3,SUFACEDEFACTDES,REASON,HEATID,TEST_ROLL_COUNT,TEST_ROLL_WEIGHT,BACK_FLAG,BACK_DATE,ADD_BLOOM_COUNT,DIV_BLOOM_COUNT,PLAN_BLOOM_COUNT,ADD_DIV_HEATID,ADD_HEATID1,ADD_HEATID2,ADD_BLOOM_COUNT2,D_INSERT_TIME,C_UP_STATE from TSC_SLAB_MES ");

            strSql.Append(" where MATERIALID ='" + stove + "' ");

            Mod_TSC_SLAB_MES model = new Mod_TSC_SLAB_MES();
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
        public Mod_TSC_SLAB_MES DataRowToModel(DataRow row)
        {
            Mod_TSC_SLAB_MES model = new Mod_TSC_SLAB_MES();
            if (row != null)
            {
                if (row["GUID"] != null)
                {
                    model.GUID = row["GUID"].ToString();
                }
                if (row["NAME"] != null)
                {
                    model.NAME = row["NAME"].ToString();
                }
                if (row["MATERIALID"] != null)
                {
                    model.MATERIALID = row["MATERIALID"].ToString();
                }
                if (row["STATUS"] != null && row["STATUS"].ToString() != "")
                {
                    model.STATUS = decimal.Parse(row["STATUS"].ToString());
                }
                if (row["POSITION"] != null)
                {
                    model.POSITION = row["POSITION"].ToString();
                }
                if (row["QASTATUS"] != null && row["QASTATUS"].ToString() != "")
                {
                    model.QASTATUS = decimal.Parse(row["QASTATUS"].ToString());
                }
                if (row["QALEVEL"] != null && row["QALEVEL"].ToString() != "")
                {
                    model.QALEVEL = decimal.Parse(row["QALEVEL"].ToString());
                }
                if (row["ORDERCONTRACTID"] != null)
                {
                    model.ORDERCONTRACTID = row["ORDERCONTRACTID"].ToString();
                }
                if (row["PRODUCECONTRACTID"] != null)
                {
                    model.PRODUCECONTRACTID = row["PRODUCECONTRACTID"].ToString();
                }
                if (row["SALESCONTRACTID"] != null)
                {
                    model.SALESCONTRACTID = row["SALESCONTRACTID"].ToString();
                }
                if (row["CASTERID"] != null)
                {
                    model.CASTERID = row["CASTERID"].ToString();
                }
                if (row["CASTING_NO"] != null)
                {
                    model.CASTING_NO = row["CASTING_NO"].ToString();
                }
                if (row["CASTING_HEAT_CNT"] != null && row["CASTING_HEAT_CNT"].ToString() != "")
                {
                    model.CASTING_HEAT_CNT = decimal.Parse(row["CASTING_HEAT_CNT"].ToString());
                }
                if (row["PRE_STEELGRADEINDEX"] != null)
                {
                    model.PRE_STEELGRADEINDEX = row["PRE_STEELGRADEINDEX"].ToString();
                }
                if (row["STEELGRADEINDEX"] != null)
                {
                    model.STEELGRADEINDEX = row["STEELGRADEINDEX"].ToString();
                }
                if (row["CUT_STEELGRADEINDEX"] != null)
                {
                    model.CUT_STEELGRADEINDEX = row["CUT_STEELGRADEINDEX"].ToString();
                }
                if (row["FINAL_STEELGRADEINDEX"] != null)
                {
                    model.FINAL_STEELGRADEINDEX = row["FINAL_STEELGRADEINDEX"].ToString();
                }
                if (row["LENGTH"] != null && row["LENGTH"].ToString() != "")
                {
                    model.LENGTH = decimal.Parse(row["LENGTH"].ToString());
                }
                if (row["WIDTH"] != null && row["WIDTH"].ToString() != "")
                {
                    model.WIDTH = decimal.Parse(row["WIDTH"].ToString());
                }
                if (row["THICKNESS"] != null && row["THICKNESS"].ToString() != "")
                {
                    model.THICKNESS = decimal.Parse(row["THICKNESS"].ToString());
                }
                if (row["CUR_SECTION_ID"] != null)
                {
                    model.CUR_SECTION_ID = row["CUR_SECTION_ID"].ToString();
                }
                if (row["CUR_PILE_ID"] != null)
                {
                    model.CUR_PILE_ID = row["CUR_PILE_ID"].ToString();
                }
                if (row["CUR_LAYER_ID"] != null)
                {
                    model.CUR_LAYER_ID = row["CUR_LAYER_ID"].ToString();
                }
                if (row["CUR_SEQ_ID"] != null && row["CUR_SEQ_ID"].ToString() != "")
                {
                    model.CUR_SEQ_ID = decimal.Parse(row["CUR_SEQ_ID"].ToString());
                }
                if (row["CUR_BAY_ID"] != null)
                {
                    model.CUR_BAY_ID = row["CUR_BAY_ID"].ToString();
                }
                if (row["DESTINATION"] != null)
                {
                    model.DESTINATION = row["DESTINATION"].ToString();
                }
                if (row["HOT_SEND_FLAG"] != null && row["HOT_SEND_FLAG"].ToString() != "")
                {
                    model.HOT_SEND_FLAG = decimal.Parse(row["HOT_SEND_FLAG"].ToString());
                }
                if (row["PROCESS_TYPE"] != null && row["PROCESS_TYPE"].ToString() != "")
                {
                    model.PROCESS_TYPE = decimal.Parse(row["PROCESS_TYPE"].ToString());
                }
                if (row["PLAN_ORD_ID"] != null)
                {
                    model.PLAN_ORD_ID = row["PLAN_ORD_ID"].ToString();
                }
                if (row["PRODUCE_DATE"] != null && row["PRODUCE_DATE"].ToString() != "")
                {
                    model.PRODUCE_DATE = DateTime.Parse(row["PRODUCE_DATE"].ToString());
                }
                if (row["FINISH_FLAG"] != null && row["FINISH_FLAG"].ToString() != "")
                {
                    model.FINISH_FLAG = decimal.Parse(row["FINISH_FLAG"].ToString());
                }
                if (row["FINISHEDTIME"] != null && row["FINISHEDTIME"].ToString() != "")
                {
                    model.FINISHEDTIME = DateTime.Parse(row["FINISHEDTIME"].ToString());
                }
                if (row["BLOOM_COUNT"] != null && row["BLOOM_COUNT"].ToString() != "")
                {
                    model.BLOOM_COUNT = decimal.Parse(row["BLOOM_COUNT"].ToString());
                }
                if (row["CAL_WEIGHT"] != null && row["CAL_WEIGHT"].ToString() != "")
                {
                    model.CAL_WEIGHT = decimal.Parse(row["CAL_WEIGHT"].ToString());
                }
                if (row["RIGHT_COUNT"] != null && row["RIGHT_COUNT"].ToString() != "")
                {
                    model.RIGHT_COUNT = decimal.Parse(row["RIGHT_COUNT"].ToString());
                }
                if (row["RIGHT_WEIGHT"] != null && row["RIGHT_WEIGHT"].ToString() != "")
                {
                    model.RIGHT_WEIGHT = decimal.Parse(row["RIGHT_WEIGHT"].ToString());
                }
                if (row["WASTER_COUNT"] != null && row["WASTER_COUNT"].ToString() != "")
                {
                    model.WASTER_COUNT = decimal.Parse(row["WASTER_COUNT"].ToString());
                }
                if (row["WASTER_WEIGHT"] != null && row["WASTER_WEIGHT"].ToString() != "")
                {
                    model.WASTER_WEIGHT = decimal.Parse(row["WASTER_WEIGHT"].ToString());
                }
                if (row["WASTER_COUNT1"] != null && row["WASTER_COUNT1"].ToString() != "")
                {
                    model.WASTER_COUNT1 = decimal.Parse(row["WASTER_COUNT1"].ToString());
                }
                if (row["WASTER_WEIGHT1"] != null && row["WASTER_WEIGHT1"].ToString() != "")
                {
                    model.WASTER_WEIGHT1 = decimal.Parse(row["WASTER_WEIGHT1"].ToString());
                }
                if (row["WASTER_REASON1"] != null)
                {
                    model.WASTER_REASON1 = row["WASTER_REASON1"].ToString();
                }
                if (row["WASTER_COUNT2"] != null && row["WASTER_COUNT2"].ToString() != "")
                {
                    model.WASTER_COUNT2 = decimal.Parse(row["WASTER_COUNT2"].ToString());
                }
                if (row["WASTER_WEIGHT2"] != null && row["WASTER_WEIGHT2"].ToString() != "")
                {
                    model.WASTER_WEIGHT2 = decimal.Parse(row["WASTER_WEIGHT2"].ToString());
                }
                if (row["WASTER_REASON2"] != null)
                {
                    model.WASTER_REASON2 = row["WASTER_REASON2"].ToString();
                }
                if (row["WASTER_COUNT3"] != null && row["WASTER_COUNT3"].ToString() != "")
                {
                    model.WASTER_COUNT3 = decimal.Parse(row["WASTER_COUNT3"].ToString());
                }
                if (row["WASTER_WEIGHT3"] != null && row["WASTER_WEIGHT3"].ToString() != "")
                {
                    model.WASTER_WEIGHT3 = decimal.Parse(row["WASTER_WEIGHT3"].ToString());
                }
                if (row["WASTER_REASON3"] != null)
                {
                    model.WASTER_REASON3 = row["WASTER_REASON3"].ToString();
                }
                if (row["WRONG_COUNT"] != null && row["WRONG_COUNT"].ToString() != "")
                {
                    model.WRONG_COUNT = decimal.Parse(row["WRONG_COUNT"].ToString());
                }
                if (row["WRONG_WEIGHT"] != null && row["WRONG_WEIGHT"].ToString() != "")
                {
                    model.WRONG_WEIGHT = decimal.Parse(row["WRONG_WEIGHT"].ToString());
                }
                if (row["WRONG_COUNT1"] != null && row["WRONG_COUNT1"].ToString() != "")
                {
                    model.WRONG_COUNT1 = decimal.Parse(row["WRONG_COUNT1"].ToString());
                }
                if (row["WRONG_WEIGHT1"] != null && row["WRONG_WEIGHT1"].ToString() != "")
                {
                    model.WRONG_WEIGHT1 = decimal.Parse(row["WRONG_WEIGHT1"].ToString());
                }
                if (row["WRONG_REASON1"] != null)
                {
                    model.WRONG_REASON1 = row["WRONG_REASON1"].ToString();
                }
                if (row["WRONG_COUNT2"] != null && row["WRONG_COUNT2"].ToString() != "")
                {
                    model.WRONG_COUNT2 = decimal.Parse(row["WRONG_COUNT2"].ToString());
                }
                if (row["WRONG_WEIGHT2"] != null && row["WRONG_WEIGHT2"].ToString() != "")
                {
                    model.WRONG_WEIGHT2 = decimal.Parse(row["WRONG_WEIGHT2"].ToString());
                }
                if (row["WRONG_REASON2"] != null)
                {
                    model.WRONG_REASON2 = row["WRONG_REASON2"].ToString();
                }
                if (row["WRONG_COUNT3"] != null && row["WRONG_COUNT3"].ToString() != "")
                {
                    model.WRONG_COUNT3 = decimal.Parse(row["WRONG_COUNT3"].ToString());
                }
                if (row["WRONG_WEIGHT3"] != null && row["WRONG_WEIGHT3"].ToString() != "")
                {
                    model.WRONG_WEIGHT3 = decimal.Parse(row["WRONG_WEIGHT3"].ToString());
                }
                if (row["WRONG_REASON3"] != null)
                {
                    model.WRONG_REASON3 = row["WRONG_REASON3"].ToString();
                }
                if (row["SUFACEDEFACTDES"] != null)
                {
                    model.SUFACEDEFACTDES = row["SUFACEDEFACTDES"].ToString();
                }
                if (row["REASON"] != null)
                {
                    model.REASON = row["REASON"].ToString();
                }
                if (row["HEATID"] != null)
                {
                    model.HEATID = row["HEATID"].ToString();
                }
                if (row["TEST_ROLL_COUNT"] != null && row["TEST_ROLL_COUNT"].ToString() != "")
                {
                    model.TEST_ROLL_COUNT = decimal.Parse(row["TEST_ROLL_COUNT"].ToString());
                }
                if (row["TEST_ROLL_WEIGHT"] != null && row["TEST_ROLL_WEIGHT"].ToString() != "")
                {
                    model.TEST_ROLL_WEIGHT = decimal.Parse(row["TEST_ROLL_WEIGHT"].ToString());
                }
                if (row["BACK_FLAG"] != null && row["BACK_FLAG"].ToString() != "")
                {
                    model.BACK_FLAG = decimal.Parse(row["BACK_FLAG"].ToString());
                }
                if (row["BACK_DATE"] != null && row["BACK_DATE"].ToString() != "")
                {
                    model.BACK_DATE = DateTime.Parse(row["BACK_DATE"].ToString());
                }
                if (row["ADD_BLOOM_COUNT"] != null && row["ADD_BLOOM_COUNT"].ToString() != "")
                {
                    model.ADD_BLOOM_COUNT = decimal.Parse(row["ADD_BLOOM_COUNT"].ToString());
                }
                if (row["DIV_BLOOM_COUNT"] != null && row["DIV_BLOOM_COUNT"].ToString() != "")
                {
                    model.DIV_BLOOM_COUNT = decimal.Parse(row["DIV_BLOOM_COUNT"].ToString());
                }
                if (row["PLAN_BLOOM_COUNT"] != null && row["PLAN_BLOOM_COUNT"].ToString() != "")
                {
                    model.PLAN_BLOOM_COUNT = decimal.Parse(row["PLAN_BLOOM_COUNT"].ToString());
                }
                if (row["ADD_DIV_HEATID"] != null)
                {
                    model.ADD_DIV_HEATID = row["ADD_DIV_HEATID"].ToString();
                }
                if (row["ADD_HEATID1"] != null)
                {
                    model.ADD_HEATID1 = row["ADD_HEATID1"].ToString();
                }
                if (row["ADD_HEATID2"] != null)
                {
                    model.ADD_HEATID2 = row["ADD_HEATID2"].ToString();
                }
                if (row["ADD_BLOOM_COUNT2"] != null && row["ADD_BLOOM_COUNT2"].ToString() != "")
                {
                    model.ADD_BLOOM_COUNT2 = decimal.Parse(row["ADD_BLOOM_COUNT2"].ToString());
                }
                if (row["D_INSERT_TIME"] != null && row["D_INSERT_TIME"].ToString() != "")
                {
                    model.D_INSERT_TIME = DateTime.Parse(row["D_INSERT_TIME"].ToString());
                }
                if (row["C_UP_STATE"] != null)
                {
                    model.C_UP_STATE = row["C_UP_STATE"].ToString();
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
            strSql.Append("select GUID,NAME,MATERIALID,STATUS,POSITION,QASTATUS,QALEVEL,ORDERCONTRACTID,PRODUCECONTRACTID,SALESCONTRACTID,CASTERID,CASTING_NO,CASTING_HEAT_CNT,PRE_STEELGRADEINDEX,STEELGRADEINDEX,CUT_STEELGRADEINDEX,FINAL_STEELGRADEINDEX,LENGTH,WIDTH,THICKNESS,CUR_SECTION_ID,CUR_PILE_ID,CUR_LAYER_ID,CUR_SEQ_ID,CUR_BAY_ID,DESTINATION,HOT_SEND_FLAG,PROCESS_TYPE,PLAN_ORD_ID,PRODUCE_DATE,FINISH_FLAG,FINISHEDTIME,BLOOM_COUNT,CAL_WEIGHT,RIGHT_COUNT,RIGHT_WEIGHT,WASTER_COUNT,WASTER_WEIGHT,WASTER_COUNT1,WASTER_WEIGHT1,WASTER_REASON1,WASTER_COUNT2,WASTER_WEIGHT2,WASTER_REASON2,WASTER_COUNT3,WASTER_WEIGHT3,WASTER_REASON3,WRONG_COUNT,WRONG_WEIGHT,WRONG_COUNT1,WRONG_WEIGHT1,WRONG_REASON1,WRONG_COUNT2,WRONG_WEIGHT2,WRONG_REASON2,WRONG_COUNT3,WRONG_WEIGHT3,WRONG_REASON3,SUFACEDEFACTDES,REASON,HEATID,TEST_ROLL_COUNT,TEST_ROLL_WEIGHT,BACK_FLAG,BACK_DATE,ADD_BLOOM_COUNT,DIV_BLOOM_COUNT,PLAN_BLOOM_COUNT,ADD_DIV_HEATID,ADD_HEATID1,ADD_HEATID2,ADD_BLOOM_COUNT2,D_INSERT_TIME,C_UP_STATE ");
            strSql.Append(" FROM TSC_SLAB_MES ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet Get_List(string MATERIALID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select MATERIALID,BLOOM_COUNT,CAL_WEIGHT ");
            strSql.Append(" FROM TSC_SLAB_MES where MATERIALID='"+ MATERIALID + "' ");

            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM TSC_SLAB_MES ");
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
            strSql.Append(")AS Row, T.*  from TSC_SLAB_MES T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            return DbHelperOra.Query(strSql.ToString());
        }


        /// <summary>
        /// 获取钢坯实绩信息
        /// </summary>
        /// <param name="timeStart">生产时间（开始）</param>
        /// <param name="timeEnd">生产时间（结束）</param>
        /// <param name="stove">炉号</param>
        /// <param name="strGrd">钢种</param>
        /// <param name="strState">是否上传（Y/N）</param>
        /// <returns></returns>
        public DataSet GetList(string timeStart, string timeEnd, string stove, string strGrd, string strState)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" select ta.C_PLAN_ID,tb.materialid as 炉号, td.c_std_code as 执行标准, td.c_stl_grd as 钢种, (tb.thickness || '*' || tb.width) as 断面, tb.length as 长度, tb.bloom_count as 支数, tb.cal_weight as 重量, td.c_zyx1 as 自由项1, td.c_zyx2 as 自由项2, tb.d_insert_time as 生产时间, tb.c_up_state as 是否上传, tc.C_MATRL_NO as 物料编码, tc.C_MATRL_NAME as 物料名称, tc.d_p_start_time as 计划开始时间, tc.d_p_end_time as 计划结束时间, ta.D_AIM_CASTINGSTART_TIME as 实际开始时间, ta.D_AIM_CASTINGEND_TIME as 实际结束时间, TE.C_ERP_PK AS 连铸主键, TE.C_STA_DESC AS 连铸机,TE.C_STA_ERPCODE AS 连铸代码,tc.C_EMP_ID as 操作人  ");

            strSql.Append(" from tpp_cast_plan ta inner  join tsc_slab_mes tb on ta.c_heat_id = tb.materialid inner join tsp_plan_sms tc on tc.c_id = ta.c_plan_id inner join tpb_lgjh td on td.c_steel_sign = tb.cut_steelgradeindex INNER JOIN TB_STA TE ON TE.C_ID=TC.C_CCM_ID ");

            strSql.Append(" where TC.N_STATUS = 1   ");

            if (timeStart.Trim() != "" && timeEnd.Trim() != "")
            {
                strSql.Append(" and tb.d_insert_time between ('" + timeStart + "','yyyy-mm-dd hh24:mi:ss') and ('" + timeEnd + "','yyyy-mm-dd hh24:mi:ss') ");
            }

            if (!string.IsNullOrEmpty(stove))
            {
                strSql.Append(" and tb.materialid like '" + stove + "%' ");
            }

            if (!string.IsNullOrEmpty(strGrd))
            {
                strSql.Append(" and td.c_stl_grd like '" + strGrd + "%' ");
            }

            if (strState != "全部")
            {
                strSql.Append(" and tb.c_up_state='" + strState + "' ");
            }

            strSql.Append(" order by tb.d_insert_time desc ");

            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取该炉号完工报告是否已上传NC
        /// </summary>
        /// <param name="materialid">炉号</param>
        /// <returns></returns>
        public int Get_Count(string materialid)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from tsc_slab_mes t where t.materialid='" + materialid + "' and t.c_up_state='N' ");

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
        /// 更新一条数据
        /// </summary>
        public bool Update_Trans(string MATERIALID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TSC_SLAB_MES set c_up_state='Y' ");
            strSql.Append(" where MATERIALID='" + MATERIALID + "'");


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
        public bool Update_Trans(Mod_TSC_SLAB_MES model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TSC_SLAB_MES set ");
            strSql.Append("GUID=:GUID,");
            strSql.Append("NAME=:NAME,");
            strSql.Append("STATUS=:STATUS,");
            strSql.Append("POSITION=:POSITION,");
            strSql.Append("QASTATUS=:QASTATUS,");
            strSql.Append("QALEVEL=:QALEVEL,");
            strSql.Append("ORDERCONTRACTID=:ORDERCONTRACTID,");
            strSql.Append("PRODUCECONTRACTID=:PRODUCECONTRACTID,");
            strSql.Append("SALESCONTRACTID=:SALESCONTRACTID,");
            strSql.Append("CASTERID=:CASTERID,");
            strSql.Append("CASTING_NO=:CASTING_NO,");
            strSql.Append("CASTING_HEAT_CNT=:CASTING_HEAT_CNT,");
            strSql.Append("PRE_STEELGRADEINDEX=:PRE_STEELGRADEINDEX,");
            strSql.Append("STEELGRADEINDEX=:STEELGRADEINDEX,");
            strSql.Append("CUT_STEELGRADEINDEX=:CUT_STEELGRADEINDEX,");
            strSql.Append("FINAL_STEELGRADEINDEX=:FINAL_STEELGRADEINDEX,");
            strSql.Append("LENGTH=:LENGTH,");
            strSql.Append("WIDTH=:WIDTH,");
            strSql.Append("THICKNESS=:THICKNESS,");
            strSql.Append("CUR_SECTION_ID=:CUR_SECTION_ID,");
            strSql.Append("CUR_PILE_ID=:CUR_PILE_ID,");
            strSql.Append("CUR_LAYER_ID=:CUR_LAYER_ID,");
            strSql.Append("CUR_SEQ_ID=:CUR_SEQ_ID,");
            strSql.Append("CUR_BAY_ID=:CUR_BAY_ID,");
            strSql.Append("DESTINATION=:DESTINATION,");
            strSql.Append("HOT_SEND_FLAG=:HOT_SEND_FLAG,");
            strSql.Append("PROCESS_TYPE=:PROCESS_TYPE,");
            strSql.Append("PLAN_ORD_ID=:PLAN_ORD_ID,");
            strSql.Append("PRODUCE_DATE=:PRODUCE_DATE,");
            strSql.Append("FINISH_FLAG=:FINISH_FLAG,");
            strSql.Append("FINISHEDTIME=:FINISHEDTIME,");
            strSql.Append("BLOOM_COUNT=:BLOOM_COUNT,");
            strSql.Append("CAL_WEIGHT=:CAL_WEIGHT,");
            strSql.Append("RIGHT_COUNT=:RIGHT_COUNT,");
            strSql.Append("RIGHT_WEIGHT=:RIGHT_WEIGHT,");
            strSql.Append("WASTER_COUNT=:WASTER_COUNT,");
            strSql.Append("WASTER_WEIGHT=:WASTER_WEIGHT,");
            strSql.Append("WASTER_COUNT1=:WASTER_COUNT1,");
            strSql.Append("WASTER_WEIGHT1=:WASTER_WEIGHT1,");
            strSql.Append("WASTER_REASON1=:WASTER_REASON1,");
            strSql.Append("WASTER_COUNT2=:WASTER_COUNT2,");
            strSql.Append("WASTER_WEIGHT2=:WASTER_WEIGHT2,");
            strSql.Append("WASTER_REASON2=:WASTER_REASON2,");
            strSql.Append("WASTER_COUNT3=:WASTER_COUNT3,");
            strSql.Append("WASTER_WEIGHT3=:WASTER_WEIGHT3,");
            strSql.Append("WASTER_REASON3=:WASTER_REASON3,");
            strSql.Append("WRONG_COUNT=:WRONG_COUNT,");
            strSql.Append("WRONG_WEIGHT=:WRONG_WEIGHT,");
            strSql.Append("WRONG_COUNT1=:WRONG_COUNT1,");
            strSql.Append("WRONG_WEIGHT1=:WRONG_WEIGHT1,");
            strSql.Append("WRONG_REASON1=:WRONG_REASON1,");
            strSql.Append("WRONG_COUNT2=:WRONG_COUNT2,");
            strSql.Append("WRONG_WEIGHT2=:WRONG_WEIGHT2,");
            strSql.Append("WRONG_REASON2=:WRONG_REASON2,");
            strSql.Append("WRONG_COUNT3=:WRONG_COUNT3,");
            strSql.Append("WRONG_WEIGHT3=:WRONG_WEIGHT3,");
            strSql.Append("WRONG_REASON3=:WRONG_REASON3,");
            strSql.Append("SUFACEDEFACTDES=:SUFACEDEFACTDES,");
            strSql.Append("REASON=:REASON,");
            strSql.Append("HEATID=:HEATID,");
            strSql.Append("TEST_ROLL_COUNT=:TEST_ROLL_COUNT,");
            strSql.Append("TEST_ROLL_WEIGHT=:TEST_ROLL_WEIGHT,");
            strSql.Append("BACK_FLAG=:BACK_FLAG,");
            strSql.Append("BACK_DATE=:BACK_DATE,");
            strSql.Append("ADD_BLOOM_COUNT=:ADD_BLOOM_COUNT,");
            strSql.Append("DIV_BLOOM_COUNT=:DIV_BLOOM_COUNT,");
            strSql.Append("PLAN_BLOOM_COUNT=:PLAN_BLOOM_COUNT,");
            strSql.Append("ADD_DIV_HEATID=:ADD_DIV_HEATID,");
            strSql.Append("ADD_HEATID1=:ADD_HEATID1,");
            strSql.Append("ADD_HEATID2=:ADD_HEATID2,");
            strSql.Append("ADD_BLOOM_COUNT2=:ADD_BLOOM_COUNT2,");
            strSql.Append("D_INSERT_TIME=:D_INSERT_TIME,");
            strSql.Append("C_UP_STATE=:C_UP_STATE");
            strSql.Append(" where MATERIALID=：MATERIALID");
            OracleParameter[] parameters = {
                    new OracleParameter(":GUID", OracleDbType.Varchar2,250),
                    new OracleParameter(":NAME", OracleDbType.Varchar2,250),                    
                    new OracleParameter(":STATUS", OracleDbType.Decimal,10),
                    new OracleParameter(":POSITION", OracleDbType.Varchar2,250),
                    new OracleParameter(":QASTATUS", OracleDbType.Decimal,10),
                    new OracleParameter(":QALEVEL", OracleDbType.Decimal,10),
                    new OracleParameter(":ORDERCONTRACTID", OracleDbType.Varchar2,250),
                    new OracleParameter(":PRODUCECONTRACTID", OracleDbType.Varchar2,250),
                    new OracleParameter(":SALESCONTRACTID", OracleDbType.Varchar2,250),
                    new OracleParameter(":CASTERID", OracleDbType.Varchar2,250),
                    new OracleParameter(":CASTING_NO", OracleDbType.Varchar2,250),
                    new OracleParameter(":CASTING_HEAT_CNT", OracleDbType.Decimal,10),
                    new OracleParameter(":PRE_STEELGRADEINDEX", OracleDbType.Varchar2,250),
                    new OracleParameter(":STEELGRADEINDEX", OracleDbType.Varchar2,250),
                    new OracleParameter(":CUT_STEELGRADEINDEX", OracleDbType.Varchar2,250),
                    new OracleParameter(":FINAL_STEELGRADEINDEX", OracleDbType.Varchar2,250),
                    new OracleParameter(":LENGTH", OracleDbType.Decimal,10),
                    new OracleParameter(":WIDTH", OracleDbType.Decimal,10),
                    new OracleParameter(":THICKNESS", OracleDbType.Decimal,10),
                    new OracleParameter(":CUR_SECTION_ID", OracleDbType.Varchar2,250),
                    new OracleParameter(":CUR_PILE_ID", OracleDbType.Varchar2,250),
                    new OracleParameter(":CUR_LAYER_ID", OracleDbType.Varchar2,250),
                    new OracleParameter(":CUR_SEQ_ID", OracleDbType.Decimal,10),
                    new OracleParameter(":CUR_BAY_ID", OracleDbType.Varchar2,250),
                    new OracleParameter(":DESTINATION", OracleDbType.Varchar2,250),
                    new OracleParameter(":HOT_SEND_FLAG", OracleDbType.Decimal,10),
                    new OracleParameter(":PROCESS_TYPE", OracleDbType.Decimal,10),
                    new OracleParameter(":PLAN_ORD_ID", OracleDbType.Varchar2,250),
                    new OracleParameter(":PRODUCE_DATE", OracleDbType.Date),
                    new OracleParameter(":FINISH_FLAG", OracleDbType.Decimal,10),
                    new OracleParameter(":FINISHEDTIME", OracleDbType.Date),
                    new OracleParameter(":BLOOM_COUNT", OracleDbType.Decimal,10),
                    new OracleParameter(":CAL_WEIGHT", OracleDbType.Decimal,10),
                    new OracleParameter(":RIGHT_COUNT", OracleDbType.Decimal,10),
                    new OracleParameter(":RIGHT_WEIGHT", OracleDbType.Decimal,10),
                    new OracleParameter(":WASTER_COUNT", OracleDbType.Decimal,10),
                    new OracleParameter(":WASTER_WEIGHT", OracleDbType.Decimal,10),
                    new OracleParameter(":WASTER_COUNT1", OracleDbType.Decimal,10),
                    new OracleParameter(":WASTER_WEIGHT1", OracleDbType.Decimal,10),
                    new OracleParameter(":WASTER_REASON1", OracleDbType.Varchar2,250),
                    new OracleParameter(":WASTER_COUNT2", OracleDbType.Decimal,10),
                    new OracleParameter(":WASTER_WEIGHT2", OracleDbType.Decimal,10),
                    new OracleParameter(":WASTER_REASON2", OracleDbType.Varchar2,250),
                    new OracleParameter(":WASTER_COUNT3", OracleDbType.Decimal,10),
                    new OracleParameter(":WASTER_WEIGHT3", OracleDbType.Decimal,10),
                    new OracleParameter(":WASTER_REASON3", OracleDbType.Varchar2,250),
                    new OracleParameter(":WRONG_COUNT", OracleDbType.Decimal,10),
                    new OracleParameter(":WRONG_WEIGHT", OracleDbType.Decimal,10),
                    new OracleParameter(":WRONG_COUNT1", OracleDbType.Decimal,10),
                    new OracleParameter(":WRONG_WEIGHT1", OracleDbType.Decimal,10),
                    new OracleParameter(":WRONG_REASON1", OracleDbType.Varchar2,250),
                    new OracleParameter(":WRONG_COUNT2", OracleDbType.Decimal,10),
                    new OracleParameter(":WRONG_WEIGHT2", OracleDbType.Decimal,10),
                    new OracleParameter(":WRONG_REASON2", OracleDbType.Varchar2,250),
                    new OracleParameter(":WRONG_COUNT3", OracleDbType.Decimal,10),
                    new OracleParameter(":WRONG_WEIGHT3", OracleDbType.Decimal,10),
                    new OracleParameter(":WRONG_REASON3", OracleDbType.Varchar2,250),
                    new OracleParameter(":SUFACEDEFACTDES", OracleDbType.Varchar2,250),
                    new OracleParameter(":REASON", OracleDbType.Varchar2,250),
                    new OracleParameter(":HEATID", OracleDbType.Varchar2,250),
                    new OracleParameter(":TEST_ROLL_COUNT", OracleDbType.Decimal,10),
                    new OracleParameter(":TEST_ROLL_WEIGHT", OracleDbType.Decimal,10),
                    new OracleParameter(":BACK_FLAG", OracleDbType.Decimal,10),
                    new OracleParameter(":BACK_DATE", OracleDbType.Date),
                    new OracleParameter(":ADD_BLOOM_COUNT", OracleDbType.Decimal,10),
                    new OracleParameter(":DIV_BLOOM_COUNT", OracleDbType.Decimal,10),
                    new OracleParameter(":PLAN_BLOOM_COUNT", OracleDbType.Decimal,10),
                    new OracleParameter(":ADD_DIV_HEATID", OracleDbType.Varchar2,250),
                    new OracleParameter(":ADD_HEATID1", OracleDbType.Varchar2,250),
                    new OracleParameter(":ADD_HEATID2", OracleDbType.Varchar2,250),
                    new OracleParameter(":ADD_BLOOM_COUNT2", OracleDbType.Decimal,10),
                    new OracleParameter(":D_INSERT_TIME", OracleDbType.Date),
                    new OracleParameter(":C_UP_STATE", OracleDbType.Varchar2,10),
                    new OracleParameter(":MATERIALID", OracleDbType.Varchar2,250)};
            parameters[0].Value = model.GUID;
            parameters[1].Value = model.NAME;            
            parameters[2].Value = model.STATUS;
            parameters[3].Value = model.POSITION;
            parameters[4].Value = model.QASTATUS;
            parameters[5].Value = model.QALEVEL;
            parameters[6].Value = model.ORDERCONTRACTID;
            parameters[7].Value = model.PRODUCECONTRACTID;
            parameters[8].Value = model.SALESCONTRACTID;
            parameters[9].Value = model.CASTERID;
            parameters[10].Value = model.CASTING_NO;
            parameters[11].Value = model.CASTING_HEAT_CNT;
            parameters[12].Value = model.PRE_STEELGRADEINDEX;
            parameters[13].Value = model.STEELGRADEINDEX;
            parameters[14].Value = model.CUT_STEELGRADEINDEX;
            parameters[15].Value = model.FINAL_STEELGRADEINDEX;
            parameters[16].Value = model.LENGTH;
            parameters[17].Value = model.WIDTH;
            parameters[18].Value = model.THICKNESS;
            parameters[19].Value = model.CUR_SECTION_ID;
            parameters[20].Value = model.CUR_PILE_ID;
            parameters[21].Value = model.CUR_LAYER_ID;
            parameters[22].Value = model.CUR_SEQ_ID;
            parameters[23].Value = model.CUR_BAY_ID;
            parameters[24].Value = model.DESTINATION;
            parameters[25].Value = model.HOT_SEND_FLAG;
            parameters[26].Value = model.PROCESS_TYPE;
            parameters[27].Value = model.PLAN_ORD_ID;
            parameters[28].Value = model.PRODUCE_DATE;
            parameters[29].Value = model.FINISH_FLAG;
            parameters[30].Value = model.FINISHEDTIME;
            parameters[31].Value = model.BLOOM_COUNT;
            parameters[32].Value = model.CAL_WEIGHT;
            parameters[33].Value = model.RIGHT_COUNT;
            parameters[34].Value = model.RIGHT_WEIGHT;
            parameters[35].Value = model.WASTER_COUNT;
            parameters[36].Value = model.WASTER_WEIGHT;
            parameters[37].Value = model.WASTER_COUNT1;
            parameters[38].Value = model.WASTER_WEIGHT1;
            parameters[39].Value = model.WASTER_REASON1;
            parameters[40].Value = model.WASTER_COUNT2;
            parameters[41].Value = model.WASTER_WEIGHT2;
            parameters[42].Value = model.WASTER_REASON2;
            parameters[43].Value = model.WASTER_COUNT3;
            parameters[44].Value = model.WASTER_WEIGHT3;
            parameters[45].Value = model.WASTER_REASON3;
            parameters[46].Value = model.WRONG_COUNT;
            parameters[47].Value = model.WRONG_WEIGHT;
            parameters[48].Value = model.WRONG_COUNT1;
            parameters[49].Value = model.WRONG_WEIGHT1;
            parameters[50].Value = model.WRONG_REASON1;
            parameters[51].Value = model.WRONG_COUNT2;
            parameters[52].Value = model.WRONG_WEIGHT2;
            parameters[53].Value = model.WRONG_REASON2;
            parameters[54].Value = model.WRONG_COUNT3;
            parameters[55].Value = model.WRONG_WEIGHT3;
            parameters[56].Value = model.WRONG_REASON3;
            parameters[57].Value = model.SUFACEDEFACTDES;
            parameters[58].Value = model.REASON;
            parameters[59].Value = model.HEATID;
            parameters[60].Value = model.TEST_ROLL_COUNT;
            parameters[61].Value = model.TEST_ROLL_WEIGHT;
            parameters[62].Value = model.BACK_FLAG;
            parameters[63].Value = model.BACK_DATE;
            parameters[64].Value = model.ADD_BLOOM_COUNT;
            parameters[65].Value = model.DIV_BLOOM_COUNT;
            parameters[66].Value = model.PLAN_BLOOM_COUNT;
            parameters[67].Value = model.ADD_DIV_HEATID;
            parameters[68].Value = model.ADD_HEATID1;
            parameters[69].Value = model.ADD_HEATID2;
            parameters[70].Value = model.ADD_BLOOM_COUNT2;
            parameters[71].Value = model.D_INSERT_TIME;
            parameters[72].Value = model.C_UP_STATE;
            parameters[73].Value = model.MATERIALID;

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

        #endregion  BasicMethod


        /// <summary>
		/// 保存送样信息
		/// </summary>
		public bool Del_Stove(ArrayList SQLStringList)
        {
            return DbHelperOra.ExecuteSqlTran(SQLStringList);
        }
    }
}

