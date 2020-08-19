using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;
namespace DAL
{
    public partial class Dal_TRC_COGDOWN_PRODUCT
    {
        public Dal_TRC_COGDOWN_PRODUCT()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string C_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TRC_COGDOWN_PRODUCT");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)            };
            parameters[0].Value = C_ID;

            return DbHelperOra.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Mod_TRC_COGDOWN_PRODUCT model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TRC_COGDOWN_PRODUCT(");
            strSql.Append("C_COGDOWN_ID,C_PLAN_ID,C_BATCH_NO,C_ORD_NO,C_STOVE,C_STA_ID,C_STA_CODE,C_STA_DESC,C_STL_GRD,C_STL_GRD_PRE,C_MAT_CODE,C_MAT_NAME,C_SPEC,N_LEN,N_QUA,N_WGT,C_STD_CODE,C_SLAB_TYPE,D_CCM_DATE,C_CCM_SHIFT,C_CCM_GROUP,C_CCM_EMP_ID,C_MOVE_TYPE,C_SC_STATE,D_ESC_DATE,D_LSC_DATE,C_QKP_STATE,C_KP_ID,C_CON_NO,C_CUS_NO,C_CUS_NAME,D_WL_DATE,C_WL_SHIFT,C_WL_GROUP,C_WL_EMP_ID,D_WE_DATE,C_WE_SHIFT,C_WE_GROUP,C_WE_EMP_ID,C_STOCK_STATE,C_MAT_TYPE,C_QGP_STATE,C_SLABWH_CODE,C_SLABWH_AREA_CODE,C_SLABWH_LOC_CODE,C_SLABWH_TIER_CODE,N_WGT_METER,C_QF_NAME,C_DESIGN_NO,C_ZRBM,C_IS_DEPOT,C_ISXM,C_XMGX,C_ISFREE,C_JUDGE_LEV_CF,C_JUDGE_LEV_XN,C_JUDGE_LEV_ZH,C_JUDGE_LEV_ZH_PEOPLE,D_JUDGE_DATE,C_IS_QR,C_QR_USER,D_QR_DATE,D_Q_DATE,C_SCUTCHEON,C_GP_TYPE,C_REMARK,D_START_DATE,D_END_DATE,C_COGDOWN_SHIFT,C_COGDOWN_GROUP,N_STATUS,C_COG_STA_ID,C_MOVE_SHIFT,C_MOVE_GROUP,C_MOVE_ID,C_MOVE_START,C_MOVE_END,N_IF_EXEC_STATUS,N_IF_EXEC_REMARK,C_ZYX1,C_ZYX2,C_EXTEND1,C_EXTEND2,C_EXTEND3,C_EXTEND4,C_EXTEND5,C_EXTEND6,C_EXTEND7,C_EXTEND8,C_EXTEND9,C_EXTEND10)");
            strSql.Append(" values (");
            strSql.Append(":C_COGDOWN_ID,:C_PLAN_ID,:C_BATCH_NO,:C_ORD_NO,:C_STOVE,:C_STA_ID,:C_STA_CODE,:C_STA_DESC,:C_STL_GRD,:C_STL_GRD_PRE,:C_MAT_CODE,:C_MAT_NAME,:C_SPEC,:N_LEN,:N_QUA,:N_WGT,:C_STD_CODE,:C_SLAB_TYPE,:D_CCM_DATE,:C_CCM_SHIFT,:C_CCM_GROUP,:C_CCM_EMP_ID,:C_MOVE_TYPE,:C_SC_STATE,:D_ESC_DATE,:D_LSC_DATE,:C_QKP_STATE,:C_KP_ID,:C_CON_NO,:C_CUS_NO,:C_CUS_NAME,:D_WL_DATE,:C_WL_SHIFT,:C_WL_GROUP,:C_WL_EMP_ID,:D_WE_DATE,:C_WE_SHIFT,:C_WE_GROUP,:C_WE_EMP_ID,:C_STOCK_STATE,:C_MAT_TYPE,:C_QGP_STATE,:C_SLABWH_CODE,:C_SLABWH_AREA_CODE,:C_SLABWH_LOC_CODE,:C_SLABWH_TIER_CODE,:N_WGT_METER,:C_QF_NAME,:C_DESIGN_NO,:C_ZRBM,:C_IS_DEPOT,:C_ISXM,:C_XMGX,:C_ISFREE,:C_JUDGE_LEV_CF,:C_JUDGE_LEV_XN,:C_JUDGE_LEV_ZH,:C_JUDGE_LEV_ZH_PEOPLE,:D_JUDGE_DATE,:C_IS_QR,:C_QR_USER,:D_QR_DATE,:D_Q_DATE,:C_SCUTCHEON,:C_GP_TYPE,:C_REMARK,:D_START_DATE,:D_END_DATE,:C_COGDOWN_SHIFT,:C_COGDOWN_GROUP,:N_STATUS,:C_COG_STA_ID,:C_MOVE_SHIFT,:C_MOVE_GROUP,:C_MOVE_ID,:C_MOVE_START,:C_MOVE_END,:N_IF_EXEC_STATUS,:N_IF_EXEC_REMARK,:C_ZYX1,:C_ZYX2,:C_EXTEND1,:C_EXTEND2,:C_EXTEND3,:C_EXTEND4,:C_EXTEND5,:C_EXTEND6,:C_EXTEND7,:C_EXTEND8,:C_EXTEND9,:C_EXTEND10)");
            OracleParameter[] parameters = {

                    new OracleParameter(":C_COGDOWN_ID", OracleDbType.Varchar2,100),
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
                    new OracleParameter(":N_LEN", OracleDbType.Decimal,15),
                    new OracleParameter(":N_QUA", OracleDbType.Decimal,5),
                    new OracleParameter(":N_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":C_STD_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SLAB_TYPE", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_CCM_DATE", OracleDbType.Varchar2,100),
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
                    new OracleParameter(":D_START_DATE", OracleDbType.Date),
                    new OracleParameter(":D_END_DATE", OracleDbType.Date),
                    new OracleParameter(":C_COGDOWN_SHIFT", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_COGDOWN_GROUP", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,2),
                    new OracleParameter(":C_COG_STA_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MOVE_SHIFT", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MOVE_GROUP", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MOVE_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MOVE_START", OracleDbType.Date),
                    new OracleParameter(":C_MOVE_END", OracleDbType.Date),
                    new OracleParameter(":N_IF_EXEC_STATUS", OracleDbType.Decimal,4),
                    new OracleParameter(":N_IF_EXEC_REMARK", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_ZYX1", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ZYX2", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_EXTEND1", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_EXTEND2", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_EXTEND3", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_EXTEND4", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_EXTEND5", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_EXTEND6", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_EXTEND7", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_EXTEND8", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_EXTEND9", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_EXTEND10", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.C_COGDOWN_ID;
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
            parameters[66].Value = model.D_START_DATE;
            parameters[67].Value = model.D_END_DATE;
            parameters[68].Value = model.C_COGDOWN_SHIFT;
            parameters[69].Value = model.C_COGDOWN_GROUP;
            parameters[70].Value = model.N_STATUS;
            parameters[71].Value = model.C_COG_STA_ID;
            parameters[72].Value = model.C_MOVE_SHIFT;
            parameters[73].Value = model.C_MOVE_GROUP;
            parameters[74].Value = model.C_MOVE_ID;
            parameters[75].Value = model.C_MOVE_START;
            parameters[76].Value = model.C_MOVE_END;
            parameters[77].Value = model.N_IF_EXEC_STATUS;
            parameters[78].Value = model.N_IF_EXEC_REMARK;
            parameters[79].Value = model.C_ZYX1;
            parameters[80].Value = model.C_ZYX2;
            parameters[81].Value = model.C_EXTEND1;
            parameters[82].Value = model.C_EXTEND2;
            parameters[83].Value = model.C_EXTEND3;
            parameters[84].Value = model.C_EXTEND4;
            parameters[85].Value = model.C_EXTEND5;
            parameters[86].Value = model.C_EXTEND6;
            parameters[87].Value = model.C_EXTEND7;
            parameters[88].Value = model.C_EXTEND8;
            parameters[89].Value = model.C_EXTEND9;
            parameters[90].Value = model.C_EXTEND10;

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
        public bool Update(Mod_TRC_COGDOWN_PRODUCT model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TRC_COGDOWN_PRODUCT set ");
            strSql.Append("C_COGDOWN_ID=:C_COGDOWN_ID,");
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
            strSql.Append("D_START_DATE=:D_START_DATE,");
            strSql.Append("D_END_DATE=:D_END_DATE,");
            strSql.Append("C_COGDOWN_SHIFT=:C_COGDOWN_SHIFT,");
            strSql.Append("C_COGDOWN_GROUP=:C_COGDOWN_GROUP,");
            strSql.Append("N_STATUS=:N_STATUS,");
            strSql.Append("C_COG_STA_ID=:C_COG_STA_ID,");
            strSql.Append("C_MOVE_SHIFT=:C_MOVE_SHIFT,");
            strSql.Append("C_MOVE_GROUP=:C_MOVE_GROUP,");
            strSql.Append("C_MOVE_ID=:C_MOVE_ID,");
            strSql.Append("C_MOVE_START=:C_MOVE_START,");
            strSql.Append("C_MOVE_END=:C_MOVE_END,");
            strSql.Append("N_IF_EXEC_STATUS=:N_IF_EXEC_STATUS,");
            strSql.Append("N_IF_EXEC_REMARK=:N_IF_EXEC_REMARK,");
            strSql.Append("C_ZYX1=:C_ZYX1,");
            strSql.Append("C_ZYX2=:C_ZYX2,");
            strSql.Append("C_EXTEND1=:C_EXTEND1,");
            strSql.Append("C_EXTEND2=:C_EXTEND2,");
            strSql.Append("C_EXTEND3=:C_EXTEND3,");
            strSql.Append("C_EXTEND4=:C_EXTEND4,");
            strSql.Append("C_EXTEND5=:C_EXTEND5,");
            strSql.Append("C_EXTEND6=:C_EXTEND6,");
            strSql.Append("C_EXTEND7=:C_EXTEND7,");
            strSql.Append("C_EXTEND8=:C_EXTEND8,");
            strSql.Append("C_EXTEND9=:C_EXTEND9,");
            strSql.Append("C_EXTEND10=:C_EXTEND10");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_COGDOWN_ID",  OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PLAN_ID",  OracleDbType.Varchar2,100),
                    new OracleParameter(":C_BATCH_NO",  OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ORD_NO",  OracleDbType.Varchar2,500),
                    new OracleParameter(":C_STOVE",  OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STA_ID",  OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STA_CODE",  OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STA_DESC",  OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STL_GRD",  OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STL_GRD_PRE",  OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MAT_CODE",  OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MAT_NAME",  OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SPEC",  OracleDbType.Varchar2,100),
                    new OracleParameter(":N_LEN", OracleDbType.Decimal,15),
                    new OracleParameter(":N_QUA", OracleDbType.Decimal,5),
                    new OracleParameter(":N_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":C_STD_CODE",  OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SLAB_TYPE",  OracleDbType.Varchar2,100),
                    new OracleParameter(":D_CCM_DATE",  OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CCM_SHIFT",  OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CCM_GROUP",  OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CCM_EMP_ID",  OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MOVE_TYPE",  OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SC_STATE",  OracleDbType.Varchar2,100),
                    new OracleParameter(":D_ESC_DATE", OracleDbType.Date),
                    new OracleParameter(":D_LSC_DATE", OracleDbType.Date),
                    new OracleParameter(":C_QKP_STATE",  OracleDbType.Varchar2,100),
                    new OracleParameter(":C_KP_ID",  OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CON_NO",  OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CUS_NO",  OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CUS_NAME",  OracleDbType.Varchar2,100),
                    new OracleParameter(":D_WL_DATE", OracleDbType.Date),
                    new OracleParameter(":C_WL_SHIFT",  OracleDbType.Varchar2,100),
                    new OracleParameter(":C_WL_GROUP",  OracleDbType.Varchar2,100),
                    new OracleParameter(":C_WL_EMP_ID",  OracleDbType.Varchar2,100),
                    new OracleParameter(":D_WE_DATE", OracleDbType.Date),
                    new OracleParameter(":C_WE_SHIFT",  OracleDbType.Varchar2,100),
                    new OracleParameter(":C_WE_GROUP",  OracleDbType.Varchar2,100),
                    new OracleParameter(":C_WE_EMP_ID",  OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STOCK_STATE",  OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MAT_TYPE",  OracleDbType.Varchar2,100),
                    new OracleParameter(":C_QGP_STATE",  OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SLABWH_CODE",  OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SLABWH_AREA_CODE",  OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SLABWH_LOC_CODE",  OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SLABWH_TIER_CODE",  OracleDbType.Varchar2,100),
                    new OracleParameter(":N_WGT_METER", OracleDbType.Decimal,5),
                    new OracleParameter(":C_QF_NAME",  OracleDbType.Varchar2,100),
                    new OracleParameter(":C_DESIGN_NO",  OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ZRBM",  OracleDbType.Varchar2,100),
                    new OracleParameter(":C_IS_DEPOT",  OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ISXM",  OracleDbType.Varchar2,100),
                    new OracleParameter(":C_XMGX",  OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ISFREE",  OracleDbType.Varchar2,100),
                    new OracleParameter(":C_JUDGE_LEV_CF",  OracleDbType.Varchar2,100),
                    new OracleParameter(":C_JUDGE_LEV_XN",  OracleDbType.Varchar2,100),
                    new OracleParameter(":C_JUDGE_LEV_ZH",  OracleDbType.Varchar2,100),
                    new OracleParameter(":C_JUDGE_LEV_ZH_PEOPLE",  OracleDbType.Varchar2,100),
                    new OracleParameter(":D_JUDGE_DATE", OracleDbType.Date),
                    new OracleParameter(":C_IS_QR",  OracleDbType.Varchar2,100),
                    new OracleParameter(":C_QR_USER",  OracleDbType.Varchar2,100),
                    new OracleParameter(":D_QR_DATE", OracleDbType.Date),
                    new OracleParameter(":D_Q_DATE", OracleDbType.Date),
                    new OracleParameter(":C_SCUTCHEON",  OracleDbType.Varchar2,100),
                    new OracleParameter(":C_GP_TYPE",  OracleDbType.Varchar2,100),
                    new OracleParameter(":C_REMARK",  OracleDbType.Varchar2,500),
                    new OracleParameter(":D_START_DATE", OracleDbType.Date),
                    new OracleParameter(":D_END_DATE", OracleDbType.Date),
                    new OracleParameter(":C_COGDOWN_SHIFT",  OracleDbType.Varchar2,100),
                    new OracleParameter(":C_COGDOWN_GROUP",  OracleDbType.Varchar2,100),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,2),
                    new OracleParameter(":C_COG_STA_ID",  OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MOVE_SHIFT",  OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MOVE_GROUP",  OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MOVE_ID",  OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MOVE_START", OracleDbType.Date),
                    new OracleParameter(":C_MOVE_END", OracleDbType.Date),
                    new OracleParameter(":N_IF_EXEC_STATUS", OracleDbType.Decimal,4),
                    new OracleParameter(":N_IF_EXEC_REMARK",  OracleDbType.Varchar2,500),
                    new OracleParameter(":C_ZYX1",  OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ZYX2",  OracleDbType.Varchar2,100),
                    new OracleParameter(":C_EXTEND1",  OracleDbType.Varchar2,100),
                    new OracleParameter(":C_EXTEND2",  OracleDbType.Varchar2,100),
                    new OracleParameter(":C_EXTEND3",  OracleDbType.Varchar2,100),
                    new OracleParameter(":C_EXTEND4",  OracleDbType.Varchar2,100),
                    new OracleParameter(":C_EXTEND5",  OracleDbType.Varchar2,100),
                    new OracleParameter(":C_EXTEND6",  OracleDbType.Varchar2,100),
                    new OracleParameter(":C_EXTEND7",  OracleDbType.Varchar2,100),
                    new OracleParameter(":C_EXTEND8",  OracleDbType.Varchar2,100),
                    new OracleParameter(":C_EXTEND9",  OracleDbType.Varchar2,100),
                    new OracleParameter(":C_EXTEND10",  OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ID",  OracleDbType.Varchar2,100)};
            parameters[0].Value = model.C_COGDOWN_ID;
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
            parameters[66].Value = model.D_START_DATE;
            parameters[67].Value = model.D_END_DATE;
            parameters[68].Value = model.C_COGDOWN_SHIFT;
            parameters[69].Value = model.C_COGDOWN_GROUP;
            parameters[70].Value = model.N_STATUS;
            parameters[71].Value = model.C_COG_STA_ID;
            parameters[72].Value = model.C_MOVE_SHIFT;
            parameters[73].Value = model.C_MOVE_GROUP;
            parameters[74].Value = model.C_MOVE_ID;
            parameters[75].Value = model.C_MOVE_START;
            parameters[76].Value = model.C_MOVE_END;
            parameters[77].Value = model.N_IF_EXEC_STATUS;
            parameters[78].Value = model.N_IF_EXEC_REMARK;
            parameters[79].Value = model.C_ZYX1;
            parameters[80].Value = model.C_ZYX2;
            parameters[81].Value = model.C_EXTEND1;
            parameters[82].Value = model.C_EXTEND2;
            parameters[83].Value = model.C_EXTEND3;
            parameters[84].Value = model.C_EXTEND4;
            parameters[85].Value = model.C_EXTEND5;
            parameters[86].Value = model.C_EXTEND6;
            parameters[87].Value = model.C_EXTEND7;
            parameters[88].Value = model.C_EXTEND8;
            parameters[89].Value = model.C_EXTEND9;
            parameters[90].Value = model.C_EXTEND10;
            parameters[91].Value = model.C_ID;

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
            strSql.Append("delete from TRC_COGDOWN_PRODUCT ");
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
        /// 批量删除数据
        /// </summary>
        public bool DeleteList(string C_IDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from TRC_COGDOWN_PRODUCT ");
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
        public Mod_TRC_COGDOWN_PRODUCT GetModel(string C_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_COGDOWN_ID,C_PLAN_ID,C_BATCH_NO,C_ORD_NO,C_STOVE,C_STA_ID,C_STA_CODE,C_STA_DESC,C_STL_GRD,C_STL_GRD_PRE,C_MAT_CODE,C_MAT_NAME,C_SPEC,N_LEN,N_QUA,N_WGT,C_STD_CODE,C_SLAB_TYPE,D_CCM_DATE,C_CCM_SHIFT,C_CCM_GROUP,C_CCM_EMP_ID,C_MOVE_TYPE,C_SC_STATE,D_ESC_DATE,D_LSC_DATE,C_QKP_STATE,C_KP_ID,C_CON_NO,C_CUS_NO,C_CUS_NAME,D_WL_DATE,C_WL_SHIFT,C_WL_GROUP,C_WL_EMP_ID,D_WE_DATE,C_WE_SHIFT,C_WE_GROUP,C_WE_EMP_ID,C_STOCK_STATE,C_MAT_TYPE,C_QGP_STATE,C_SLABWH_CODE,C_SLABWH_AREA_CODE,C_SLABWH_LOC_CODE,C_SLABWH_TIER_CODE,N_WGT_METER,C_QF_NAME,C_DESIGN_NO,C_ZRBM,C_IS_DEPOT,C_ISXM,C_XMGX,C_ISFREE,C_JUDGE_LEV_CF,C_JUDGE_LEV_XN,C_JUDGE_LEV_ZH,C_JUDGE_LEV_ZH_PEOPLE,D_JUDGE_DATE,C_IS_QR,C_QR_USER,D_QR_DATE,D_Q_DATE,C_SCUTCHEON,C_GP_TYPE,C_REMARK,D_START_DATE,D_END_DATE,C_COGDOWN_SHIFT,C_COGDOWN_GROUP,N_STATUS,C_COG_STA_ID,C_MOVE_SHIFT,C_MOVE_GROUP,C_MOVE_ID,C_MOVE_START,C_MOVE_END,N_IF_EXEC_STATUS,N_IF_EXEC_REMARK,C_ZYX1,C_ZYX2,C_EXTEND1,C_EXTEND2,C_EXTEND3,C_EXTEND4,C_EXTEND5,C_EXTEND6,C_EXTEND7,C_EXTEND8,C_EXTEND9,C_EXTEND10 from TRC_COGDOWN_PRODUCT ");
            strSql.Append(" where C_COGDOWN_ID=:C_ID and rownum=1 ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)            };
            parameters[0].Value = C_ID;

            Mod_TRC_COGDOWN_PRODUCT model = new Mod_TRC_COGDOWN_PRODUCT();
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
        public Mod_TRC_COGDOWN_PRODUCT DataRowToModel(DataRow row)
        {
            Mod_TRC_COGDOWN_PRODUCT model = new Mod_TRC_COGDOWN_PRODUCT();
            if (row != null)
            {
                if (row["C_ID"] != null)
                {
                    model.C_ID = row["C_ID"].ToString();
                }
                if (row["C_COGDOWN_ID"] != null)
                {
                    model.C_COGDOWN_ID = row["C_COGDOWN_ID"].ToString();
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
                if (row["D_CCM_DATE"] != null)
                {
                    model.D_CCM_DATE = row["D_CCM_DATE"].ToString();
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
                if (row["D_START_DATE"] != null && row["D_START_DATE"].ToString() != "")
                {
                    model.D_START_DATE = DateTime.Parse(row["D_START_DATE"].ToString());
                }
                if (row["D_END_DATE"] != null && row["D_END_DATE"].ToString() != "")
                {
                    model.D_END_DATE = DateTime.Parse(row["D_END_DATE"].ToString());
                }
                if (row["C_COGDOWN_SHIFT"] != null)
                {
                    model.C_COGDOWN_SHIFT = row["C_COGDOWN_SHIFT"].ToString();
                }
                if (row["C_COGDOWN_GROUP"] != null)
                {
                    model.C_COGDOWN_GROUP = row["C_COGDOWN_GROUP"].ToString();
                }
                if (row["N_STATUS"] != null && row["N_STATUS"].ToString() != "")
                {
                    model.N_STATUS = decimal.Parse(row["N_STATUS"].ToString());
                }
                if (row["C_COG_STA_ID"] != null)
                {
                    model.C_COG_STA_ID = row["C_COG_STA_ID"].ToString();
                }
                if (row["C_MOVE_SHIFT"] != null)
                {
                    model.C_MOVE_SHIFT = row["C_MOVE_SHIFT"].ToString();
                }
                if (row["C_MOVE_GROUP"] != null)
                {
                    model.C_MOVE_GROUP = row["C_MOVE_GROUP"].ToString();
                }
                if (row["C_MOVE_ID"] != null)
                {
                    model.C_MOVE_ID = row["C_MOVE_ID"].ToString();
                }
                if (row["C_MOVE_START"] != null && row["C_MOVE_START"].ToString() != "")
                {
                    model.C_MOVE_START = DateTime.Parse(row["C_MOVE_START"].ToString());
                }
                if (row["C_MOVE_END"] != null && row["C_MOVE_END"].ToString() != "")
                {
                    model.C_MOVE_END = DateTime.Parse(row["C_MOVE_END"].ToString());
                }
                if (row["N_IF_EXEC_STATUS"] != null && row["N_IF_EXEC_STATUS"].ToString() != "")
                {
                    model.N_IF_EXEC_STATUS = decimal.Parse(row["N_IF_EXEC_STATUS"].ToString());
                }
                if (row["N_IF_EXEC_REMARK"] != null)
                {
                    model.N_IF_EXEC_REMARK = row["N_IF_EXEC_REMARK"].ToString();
                }
                if (row["C_ZYX1"] != null)
                {
                    model.C_ZYX1 = row["C_ZYX1"].ToString();
                }
                if (row["C_ZYX2"] != null)
                {
                    model.C_ZYX2 = row["C_ZYX2"].ToString();
                }
                if (row["C_EXTEND1"] != null)
                {
                    model.C_EXTEND1 = row["C_EXTEND1"].ToString();
                }
                if (row["C_EXTEND2"] != null)
                {
                    model.C_EXTEND2 = row["C_EXTEND2"].ToString();
                }
                if (row["C_EXTEND3"] != null)
                {
                    model.C_EXTEND3 = row["C_EXTEND3"].ToString();
                }
                if (row["C_EXTEND4"] != null)
                {
                    model.C_EXTEND4 = row["C_EXTEND4"].ToString();
                }
                if (row["C_EXTEND5"] != null)
                {
                    model.C_EXTEND5 = row["C_EXTEND5"].ToString();
                }
                if (row["C_EXTEND6"] != null)
                {
                    model.C_EXTEND6 = row["C_EXTEND6"].ToString();
                }
                if (row["C_EXTEND7"] != null)
                {
                    model.C_EXTEND7 = row["C_EXTEND7"].ToString();
                }
                if (row["C_EXTEND8"] != null)
                {
                    model.C_EXTEND8 = row["C_EXTEND8"].ToString();
                }
                if (row["C_EXTEND9"] != null)
                {
                    model.C_EXTEND9 = row["C_EXTEND9"].ToString();
                }
                if (row["C_EXTEND10"] != null)
                {
                    model.C_EXTEND10 = row["C_EXTEND10"].ToString();
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
            strSql.Append("select C_ID,C_COGDOWN_ID,C_PLAN_ID,C_BATCH_NO,C_ORD_NO,C_STOVE,C_STA_ID,C_STA_CODE,C_STA_DESC,C_STL_GRD,C_STL_GRD_PRE,C_MAT_CODE,C_MAT_NAME,C_SPEC,N_LEN,N_QUA,N_WGT,C_STD_CODE,C_SLAB_TYPE,D_CCM_DATE,C_CCM_SHIFT,C_CCM_GROUP,C_CCM_EMP_ID,C_MOVE_TYPE,C_SC_STATE,D_ESC_DATE,D_LSC_DATE,C_QKP_STATE,C_KP_ID,C_CON_NO,C_CUS_NO,C_CUS_NAME,D_WL_DATE,C_WL_SHIFT,C_WL_GROUP,C_WL_EMP_ID,D_WE_DATE,C_WE_SHIFT,C_WE_GROUP,C_WE_EMP_ID,C_STOCK_STATE,C_MAT_TYPE,C_QGP_STATE,C_SLABWH_CODE,C_SLABWH_AREA_CODE,C_SLABWH_LOC_CODE,C_SLABWH_TIER_CODE,N_WGT_METER,C_QF_NAME,C_DESIGN_NO,C_ZRBM,C_IS_DEPOT,C_ISXM,C_XMGX,C_ISFREE,C_JUDGE_LEV_CF,C_JUDGE_LEV_XN,C_JUDGE_LEV_ZH,C_JUDGE_LEV_ZH_PEOPLE,D_JUDGE_DATE,C_IS_QR,C_QR_USER,D_QR_DATE,D_Q_DATE,C_SCUTCHEON,C_GP_TYPE,C_REMARK,D_START_DATE,D_END_DATE,C_COGDOWN_SHIFT,C_COGDOWN_GROUP,N_STATUS,C_COG_STA_ID,C_MOVE_SHIFT,C_MOVE_GROUP,C_MOVE_ID,C_MOVE_START,C_MOVE_END,N_IF_EXEC_STATUS,N_IF_EXEC_REMARK,C_ZYX1,C_ZYX2,C_EXTEND1,C_EXTEND2,C_EXTEND3,C_EXTEND4,C_EXTEND5,C_EXTEND6,C_EXTEND7,C_EXTEND8,C_EXTEND9,C_EXTEND10  ");
            strSql.Append(" FROM TRC_COGDOWN_PRODUCT ");
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
            strSql.Append("select count(1) FROM TRC_COGDOWN_PRODUCT ");
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
            strSql.Append(")AS Row, T.*  from TRC_COGDOWN_PRODUCT T ");
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
        /// 获取开坯实绩中间表数据
        /// </summary>
        /// <param name="batchNo"></param>
        /// <param name="status"></param>
        /// <param name="staID"></param>
        /// <returns></returns>
        public DataSet GetProductFact(string batchNo, int status, string staID)
        {
            string sql = @"SELECT  SUM(T.N_QUA)N_QUA,SUM(T.N_WGT)N_WGT FROM TSC_SLAB_MAIN T
                                    WHERE T.C_BATCH_NO='" + batchNo + "'  ";
            return DbHelperOra.Query(sql);
        }

        /// <summary>
        /// 获取开坯实绩中间表数据
        /// </summary>
        /// <param name="batchNo"></param>
        /// <param name="status"></param>
        /// <returns></returns>
        public DataSet GetProductFactGroup(string batchNo, int status, string staID)
        {
            string sql = @"SELECT SUM(T.N_QUA) N_QUA
                                    ,SUM(T.N_WGT) N_WGT
                                    ,C_MAT_CODE
                                    ,C_SLABWH_CODE
                                    ,C_MAT_TYPE
                                    FROM TSC_SLAB_MAIN T
                                     WHERE T.C_BATCH_NO = '" + batchNo + "'  ";

            sql += "  GROUP BY T.C_MAT_CODE,T.C_SLABWH_CODE,C_MAT_TYPE ";

            return DbHelperOra.Query(sql);
        }

        /// <summary>
        /// 获取开坯班次记录
        /// </summary>
        /// <returns></returns>
        public DataTable GetBcJl(string rqStart, string rqEnd, string shift, string prodLine)
        {
            string sql = @"SELECT 
                           (
                             SELECT TTT.C_ORDER_NO FROM TMO_ORDER TTT WHERE TTT.C_ID=
                               (
                                    SELECT TT.C_ORDER_NO FROM TSP_PLAN_SMS TT WHERE TT.C_ID=
                                       (SELECT T.C_ORDER_NO FROM TRP_PLAN_COGDOWN T WHERE T.C_ID=TCP.C_PLAN_ID)
                               )
                           )  C_ORDER_NO,
                           TCP.C_STL_GRD,
                           TCP.C_STD_CODE,
                           TCP.C_SPEC,
                           TCP.C_BATCH_NO,
                           TCP.C_STOVE,
                           TCP.C_COGDOWN_ID,
                           MAX(TCP.C_ZYX1)C_ZYX1,
                           MAX(TCP.C_ZYX2)C_ZYX2,
                           MAX(TCP.D_QR_DATE)D_QR_DATE,
                           MAX(TCP.D_START_DATE)D_START_DATE,
                           --(SELECT SUM(T.N_WGT) FROM TSC_SLAB_MAIN T WHERE T.C_STOVE=TCP.C_STOVE AND T.C_MOVE_TYPE='EX')CONSUME,
                           (SELECT NVL(SUM(T.N_WGT),'0') FROM TSC_SLAB_MAIN T WHERE T.C_BATCH_NO=TCP.C_BATCH_NO)YIELD
                           FROM TRC_COGDOWN_PRODUCT TCP
                           WHERE TCP.D_START_DATE>= TO_DATE('" + rqStart + "', 'yyyy-mm-dd hh24:mi:ss') ";
            sql += "  AND TCP.D_START_DATE <= TO_DATE('" + rqEnd + "', 'yyyy-mm-dd hh24:mi:ss') ";
            if (shift != "全部" && !string.IsNullOrWhiteSpace(shift))
                sql += " AND TCP.C_EXTEND1='" + shift + "' ";

            if (prodLine != "全部" && !string.IsNullOrWhiteSpace(prodLine))
                sql += " AND TCP.C_COG_STA_ID='" + prodLine + "' ";

            sql += "  GROUP BY TCP.C_STL_GRD,TCP.C_SPEC,TCP.C_BATCH_NO, TCP.C_STOVE,TCP.C_PLAN_ID,TCP.C_STD_CODE,TCP.C_COGDOWN_ID ";
            sql += "  ORDER BY TCP.C_BATCH_NO, TCP.C_STOVE  ";
            return DbHelperOra.Query(sql).Tables[0];
        }

        /// <summary>
        /// 获取开坯消耗
        /// </summary>
        /// <returns></returns>
        public DataTable GetConSume(DataTable dt)
        {
            string sql = @" SELECT T.C_COGDOWN_MAIN_ID,NVL( SUM(tt.n_wgt),'0') CONSUME
                            FROM TRC_COGDOWN_MAIN_ITEM T 
                            LEFT JOIN TSC_SLAB_MAIN  TT ON TT.C_ID=T.C_SLAB_MAIN_ID 
                             ";

            if (dt != null && dt.Rows.Count > 0)
            {
                sql += " WHERE  (";
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (i == dt.Rows.Count - 1)
                    {
                        sql += " T.C_COGDOWN_MAIN_ID='" + dt.Rows[i]["C_COGDOWN_ID"].ToString() + "' ";
                    }
                    else
                    {
                        sql += " T.C_COGDOWN_MAIN_ID='" + dt.Rows[i]["C_COGDOWN_ID"].ToString() + "' OR ";
                    }
                }
                sql += " ) ";
            }
            else
            {
                return new DataTable();
            }

            sql += " GROUP BY T.C_COGDOWN_MAIN_ID ";

            return DbHelperOra.Query(sql).Tables[0];
        }

        /// <summary>
        /// 获取产线
        /// </summary>
        /// <param name="codeLike">模糊查询产线编码字符串</param>
        /// <returns>获取工位表格</returns>
        public DataTable GetProdLine(string codeLike)
        {
            string sql = @" SELECT * FROM TB_STA T WHERE T.C_STA_CODE LIKE '" + codeLike + "' ";
            return DbHelperOra.Query(sql).Tables[0];
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Mod_TRC_COGDOWN_PRODUCT GetModelByCOGID(string C_COGDOWN_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_COGDOWN_ID,C_PLAN_ID,C_BATCH_NO,C_ORD_NO,C_STOVE,C_STA_ID,C_STA_CODE,C_STA_DESC,C_STL_GRD,C_STL_GRD_PRE,C_MAT_CODE,C_MAT_NAME,C_SPEC,N_LEN,N_QUA,N_WGT,C_STD_CODE,C_SLAB_TYPE,D_CCM_DATE,C_CCM_SHIFT,C_CCM_GROUP,C_CCM_EMP_ID,C_MOVE_TYPE,C_SC_STATE,D_ESC_DATE,D_LSC_DATE,C_QKP_STATE,C_KP_ID,C_CON_NO,C_CUS_NO,C_CUS_NAME,D_WL_DATE,C_WL_SHIFT,C_WL_GROUP,C_WL_EMP_ID,D_WE_DATE,C_WE_SHIFT,C_WE_GROUP,C_WE_EMP_ID,C_STOCK_STATE,C_MAT_TYPE,C_QGP_STATE,C_SLABWH_CODE,C_SLABWH_AREA_CODE,C_SLABWH_LOC_CODE,C_SLABWH_TIER_CODE,N_WGT_METER,C_QF_NAME,C_DESIGN_NO,C_ZRBM,C_IS_DEPOT,C_ISXM,C_XMGX,C_ISFREE,C_JUDGE_LEV_CF,C_JUDGE_LEV_XN,C_JUDGE_LEV_ZH,C_JUDGE_LEV_ZH_PEOPLE,D_JUDGE_DATE,C_IS_QR,C_QR_USER,D_QR_DATE,D_Q_DATE,C_SCUTCHEON,C_GP_TYPE,C_REMARK,D_START_DATE,D_END_DATE,C_COGDOWN_SHIFT,C_COGDOWN_GROUP,N_STATUS,C_COG_STA_ID,C_MOVE_SHIFT,C_MOVE_GROUP,C_MOVE_ID,C_MOVE_START,C_MOVE_END,N_IF_EXEC_STATUS,N_IF_EXEC_REMARK,C_ZYX1,C_ZYX2,C_EXTEND1,C_EXTEND2,C_EXTEND3,C_EXTEND4,C_EXTEND5,C_EXTEND6,C_EXTEND7,C_EXTEND8,C_EXTEND9,C_EXTEND10 from TRC_COGDOWN_PRODUCT ");
            strSql.Append(" where C_COGDOWN_ID=:C_COGDOWN_ID and rownum=1 ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_COGDOWN_ID", OracleDbType.Varchar2,100)            };
            parameters[0].Value = C_COGDOWN_ID;

            Mod_TRC_COGDOWN_PRODUCT model = new Mod_TRC_COGDOWN_PRODUCT();
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

        #endregion  ExtensionMethod
    }
}
