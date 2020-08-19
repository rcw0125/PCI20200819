using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;
using System.Collections.Generic;

namespace DAL
{
    /// <summary>
    /// 数据访问类:TPP_LGPC_LSB
    /// </summary>
    public partial class Dal_TPP_LGPC_LSB
    {
        public Dal_TPP_LGPC_LSB()
        { }
        #region  BasicMethod


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Mod_TPP_LGPC_LSB model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TPP_LGPC_LSB(");
            strSql.Append("C_ID,C_CCM_ID,C_CCM_CODE,N_GROUP,N_TOTAL_WGT,N_ZJCLS,N_ZJCLZL,N_MLZL,N_SORT,C_STL_GRD,N_PRODUCE_TIME,N_JSCN,C_BY1,C_BY2,C_BY3,C_RH,C_DFP_HL,C_HL,C_XM,N_ORDER_LS,D_DFPHL_START_TIME,D_DFPHL_END_TIME,D_KP_START_TIME,D_KP_END_TIME,D_HL_START_TIME,D_HL_END_TIME,D_PLAN_KY_TIME,C_PLAN_ROLL,D_ZZ_START_TIME,D_ZZ_END_TIME,D_XM_START_TIME,D_XM_END_TIME,C_STD_CODE,C_SLAB_TYPE,C_STL_GRD_TYPE,C_PROD_NAME,C_PROD_KIND,N_DFP_HL_TIME,N_HL_TIME,N_XM_TIME,N_GG,N_CCM_TIME,C_TJ_REMARK,C_TL,N_RH,N_TL,N_GZSL,C_REMARK,N_XM,N_DHL,N_HL,N_STATUS,D_P_START_TIME,D_P_END_TIME,N_DFP_RZ,N_RZP_RZ,C_RH_SFJS)");
            strSql.Append(" values (");
            strSql.Append(":C_ID,:C_CCM_ID,:C_CCM_CODE,:N_GROUP,:N_TOTAL_WGT,:N_ZJCLS,:N_ZJCLZL,:N_MLZL,:N_SORT,:C_STL_GRD,:N_PRODUCE_TIME,:N_JSCN,:C_BY1,:C_BY2,:C_BY3,:C_RH,:C_DFP_HL,:C_HL,:C_XM,:N_ORDER_LS,:D_DFPHL_START_TIME,:D_DFPHL_END_TIME,:D_KP_START_TIME,:D_KP_END_TIME,:D_HL_START_TIME,:D_HL_END_TIME,:D_PLAN_KY_TIME,:C_PLAN_ROLL,:D_ZZ_START_TIME,:D_ZZ_END_TIME,:D_XM_START_TIME,:D_XM_END_TIME,:C_STD_CODE,:C_SLAB_TYPE,:C_STL_GRD_TYPE,:C_PROD_NAME,:C_PROD_KIND,:N_DFP_HL_TIME,:N_HL_TIME,:N_XM_TIME,:N_GG,:N_CCM_TIME,:C_TJ_REMARK,:C_TL,:N_RH,:N_TL,:N_GZSL,:C_REMARK,:N_XM,:N_DHL,:N_HL,:N_STATUS,:D_P_START_TIME,:D_P_END_TIME,:N_DFP_RZ,:N_RZP_RZ,:C_RH_SFJS)");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CCM_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CCM_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_GROUP", OracleDbType.Decimal,4),
                    new OracleParameter(":N_TOTAL_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":N_ZJCLS", OracleDbType.Decimal,4),
                    new OracleParameter(":N_ZJCLZL", OracleDbType.Decimal,4),
                    new OracleParameter(":N_MLZL", OracleDbType.Decimal,15),
                    new OracleParameter(":N_SORT", OracleDbType.Decimal,10),
                    new OracleParameter(":C_STL_GRD", OracleDbType.Varchar2,500),
                    new OracleParameter(":N_PRODUCE_TIME", OracleDbType.Decimal,15),
                    new OracleParameter(":N_JSCN", OracleDbType.Decimal,4),
                    new OracleParameter(":C_BY1", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_BY2", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_BY3", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_RH", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_DFP_HL", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_HL", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_XM", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_ORDER_LS", OracleDbType.Decimal,4),
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
                    new OracleParameter(":C_STD_CODE", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_SLAB_TYPE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STL_GRD_TYPE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PROD_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PROD_KIND", OracleDbType.Varchar2,1000),
                    new OracleParameter(":N_DFP_HL_TIME", OracleDbType.Decimal,10),
                    new OracleParameter(":N_HL_TIME", OracleDbType.Decimal,10),
                    new OracleParameter(":N_XM_TIME", OracleDbType.Decimal,10),
                    new OracleParameter(":N_GG", OracleDbType.Decimal,10),
                    new OracleParameter(":N_CCM_TIME", OracleDbType.Decimal,10),
                    new OracleParameter(":C_TJ_REMARK", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_TL", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_RH", OracleDbType.Decimal,5),
                    new OracleParameter(":N_TL", OracleDbType.Decimal,5),
                    new OracleParameter(":N_GZSL", OracleDbType.Decimal,5),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,1000),
                    new OracleParameter(":N_XM", OracleDbType.Decimal,5),
                    new OracleParameter(":N_DHL", OracleDbType.Decimal,5),
                    new OracleParameter(":N_HL", OracleDbType.Decimal,5),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,5),
                    new OracleParameter(":D_P_START_TIME", OracleDbType.Date),
                    new OracleParameter(":D_P_END_TIME", OracleDbType.Date),
                    new OracleParameter(":N_DFP_RZ", OracleDbType.Decimal,5),
                    new OracleParameter(":N_RZP_RZ", OracleDbType.Decimal,5),
                    new OracleParameter(":C_RH_SFJS", OracleDbType.Varchar2,10)};
            parameters[0].Value = model.C_ID;
            parameters[1].Value = model.C_CCM_ID;
            parameters[2].Value = model.C_CCM_CODE;
            parameters[3].Value = model.N_GROUP;
            parameters[4].Value = model.N_TOTAL_WGT;
            parameters[5].Value = model.N_ZJCLS;
            parameters[6].Value = model.N_ZJCLZL;
            parameters[7].Value = model.N_MLZL;
            parameters[8].Value = model.N_SORT;
            parameters[9].Value = model.C_STL_GRD;
            parameters[10].Value = model.N_PRODUCE_TIME;
            parameters[11].Value = model.N_JSCN;
            parameters[12].Value = model.C_BY1;
            parameters[13].Value = model.C_BY2;
            parameters[14].Value = model.C_BY3;
            parameters[15].Value = model.C_RH;
            parameters[16].Value = model.C_DFP_HL;
            parameters[17].Value = model.C_HL;
            parameters[18].Value = model.C_XM;
            parameters[19].Value = model.N_ORDER_LS;
            parameters[20].Value = model.D_DFPHL_START_TIME;
            parameters[21].Value = model.D_DFPHL_END_TIME;
            parameters[22].Value = model.D_KP_START_TIME;
            parameters[23].Value = model.D_KP_END_TIME;
            parameters[24].Value = model.D_HL_START_TIME;
            parameters[25].Value = model.D_HL_END_TIME;
            parameters[26].Value = model.D_PLAN_KY_TIME;
            parameters[27].Value = model.C_PLAN_ROLL;
            parameters[28].Value = model.D_ZZ_START_TIME;
            parameters[29].Value = model.D_ZZ_END_TIME;
            parameters[30].Value = model.D_XM_START_TIME;
            parameters[31].Value = model.D_XM_END_TIME;
            parameters[32].Value = model.C_STD_CODE;
            parameters[33].Value = model.C_SLAB_TYPE;
            parameters[34].Value = model.C_STL_GRD_TYPE;
            parameters[35].Value = model.C_PROD_NAME;
            parameters[36].Value = model.C_PROD_KIND;
            parameters[37].Value = model.N_DFP_HL_TIME;
            parameters[38].Value = model.N_HL_TIME;
            parameters[39].Value = model.N_XM_TIME;
            parameters[40].Value = model.N_GG;
            parameters[41].Value = model.N_CCM_TIME;
            parameters[42].Value = model.C_TJ_REMARK;
            parameters[43].Value = model.C_TL;
            parameters[44].Value = model.N_RH;
            parameters[45].Value = model.N_TL;
            parameters[46].Value = model.N_GZSL;
            parameters[47].Value = model.C_REMARK;
            parameters[48].Value = model.N_XM;
            parameters[49].Value = model.N_DHL;
            parameters[50].Value = model.N_HL;
            parameters[51].Value = model.N_STATUS;
            parameters[52].Value = model.D_P_START_TIME;
            parameters[53].Value = model.D_P_END_TIME;
            parameters[54].Value = model.N_DFP_RZ;
            parameters[55].Value = model.N_RZP_RZ;
            parameters[56].Value = model.C_RH_SFJS;
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
        public bool Update(Mod_TPP_LGPC_LSB model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TPP_LGPC_LSB set ");
            strSql.Append("C_CCM_ID=:C_CCM_ID,");
            strSql.Append("C_CCM_CODE=:C_CCM_CODE,");
            strSql.Append("N_GROUP=:N_GROUP,");
            strSql.Append("N_TOTAL_WGT=:N_TOTAL_WGT,");
            strSql.Append("N_ZJCLS=:N_ZJCLS,");
            strSql.Append("N_ZJCLZL=:N_ZJCLZL,");
            strSql.Append("N_MLZL=:N_MLZL,");
            strSql.Append("N_SORT=:N_SORT,");
            strSql.Append("C_STL_GRD=:C_STL_GRD,");
            strSql.Append("N_PRODUCE_TIME=:N_PRODUCE_TIME,");
            strSql.Append("N_JSCN=:N_JSCN,");
            strSql.Append("C_BY1=:C_BY1,");
            strSql.Append("C_BY2=:C_BY2,");
            strSql.Append("C_BY3=:C_BY3,");
            strSql.Append("C_RH=:C_RH,");
            strSql.Append("C_DFP_HL=:C_DFP_HL,");
            strSql.Append("C_HL=:C_HL,");
            strSql.Append("C_XM=:C_XM,");
            strSql.Append("N_ORDER_LS=:N_ORDER_LS,");
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
            strSql.Append("C_STD_CODE=:C_STD_CODE,");
            strSql.Append("C_SLAB_TYPE=:C_SLAB_TYPE,");
            strSql.Append("C_STL_GRD_TYPE=:C_STL_GRD_TYPE,");
            strSql.Append("C_PROD_NAME=:C_PROD_NAME,");
            strSql.Append("C_PROD_KIND=:C_PROD_KIND,");
            strSql.Append("N_DFP_HL_TIME=:N_DFP_HL_TIME,");
            strSql.Append("N_HL_TIME=:N_HL_TIME,");
            strSql.Append("N_XM_TIME=:N_XM_TIME,");
            strSql.Append("N_GG=:N_GG,");
            strSql.Append("N_CCM_TIME=:N_CCM_TIME,");
            strSql.Append("C_TJ_REMARK=:C_TJ_REMARK,");
            strSql.Append("C_TL=:C_TL,");
            strSql.Append("N_RH=:N_RH,");
            strSql.Append("N_TL=:N_TL,");
            strSql.Append("N_GZSL=:N_GZSL,");
            strSql.Append("C_REMARK=:C_REMARK,");
            strSql.Append("N_XM=:N_XM,");
            strSql.Append("N_DHL=:N_DHL,");
            strSql.Append("N_HL=:N_HL,");
            strSql.Append("N_STATUS=:N_STATUS,");
            strSql.Append("D_P_START_TIME=:D_P_START_TIME,");
            strSql.Append("D_P_END_TIME=:D_P_END_TIME,");
            strSql.Append("N_DFP_RZ=:N_DFP_RZ,");
            strSql.Append("N_RZP_RZ=:N_RZP_RZ,");
            strSql.Append("C_RH_SFJS=:C_RH_SFJS ");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_CCM_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CCM_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_GROUP", OracleDbType.Decimal,4),
                    new OracleParameter(":N_TOTAL_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":N_ZJCLS", OracleDbType.Decimal,4),
                    new OracleParameter(":N_ZJCLZL", OracleDbType.Decimal,4),
                    new OracleParameter(":N_MLZL", OracleDbType.Decimal,15),
                    new OracleParameter(":N_SORT", OracleDbType.Decimal,10),
                    new OracleParameter(":C_STL_GRD", OracleDbType.Varchar2,500),
                    new OracleParameter(":N_PRODUCE_TIME", OracleDbType.Decimal,15),
                    new OracleParameter(":N_JSCN", OracleDbType.Decimal,4),
                    new OracleParameter(":C_BY1", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_BY2", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_BY3", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_RH", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_DFP_HL", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_HL", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_XM", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_ORDER_LS", OracleDbType.Decimal,4),
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
                    new OracleParameter(":C_STD_CODE", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_SLAB_TYPE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STL_GRD_TYPE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PROD_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PROD_KIND", OracleDbType.Varchar2,1000),
                    new OracleParameter(":N_DFP_HL_TIME", OracleDbType.Decimal,10),
                    new OracleParameter(":N_HL_TIME", OracleDbType.Decimal,10),
                    new OracleParameter(":N_XM_TIME", OracleDbType.Decimal,10),
                    new OracleParameter(":N_GG", OracleDbType.Decimal,10),
                    new OracleParameter(":N_CCM_TIME", OracleDbType.Decimal,10),
                    new OracleParameter(":C_TJ_REMARK", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_TL", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_RH", OracleDbType.Decimal,5),
                    new OracleParameter(":N_TL", OracleDbType.Decimal,5),
                    new OracleParameter(":N_GZSL", OracleDbType.Decimal,5),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,1000),
                    new OracleParameter(":N_XM", OracleDbType.Decimal,5),
                    new OracleParameter(":N_DHL", OracleDbType.Decimal,5),
                    new OracleParameter(":N_HL", OracleDbType.Decimal,5),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,5),
                    new OracleParameter(":D_P_START_TIME", OracleDbType.Date),
                    new OracleParameter(":D_P_END_TIME", OracleDbType.Date),
                    new OracleParameter(":N_DFP_RZ", OracleDbType.Decimal,5),
                    new OracleParameter(":N_RZP_RZ", OracleDbType.Decimal,5),
                new OracleParameter(":C_RH_SFJS", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.C_CCM_ID;
            parameters[1].Value = model.C_CCM_CODE;
            parameters[2].Value = model.N_GROUP;
            parameters[3].Value = model.N_TOTAL_WGT;
            parameters[4].Value = model.N_ZJCLS;
            parameters[5].Value = model.N_ZJCLZL;
            parameters[6].Value = model.N_MLZL;
            parameters[7].Value = model.N_SORT;
            parameters[8].Value = model.C_STL_GRD;
            parameters[9].Value = model.N_PRODUCE_TIME;
            parameters[10].Value = model.N_JSCN;
            parameters[11].Value = model.C_BY1;
            parameters[12].Value = model.C_BY2;
            parameters[13].Value = model.C_BY3;
            parameters[14].Value = model.C_RH;
            parameters[15].Value = model.C_DFP_HL;
            parameters[16].Value = model.C_HL;
            parameters[17].Value = model.C_XM;
            parameters[18].Value = model.N_ORDER_LS;
            parameters[19].Value = model.D_DFPHL_START_TIME;
            parameters[20].Value = model.D_DFPHL_END_TIME;
            parameters[21].Value = model.D_KP_START_TIME;
            parameters[22].Value = model.D_KP_END_TIME;
            parameters[23].Value = model.D_HL_START_TIME;
            parameters[24].Value = model.D_HL_END_TIME;
            parameters[25].Value = model.D_PLAN_KY_TIME;
            parameters[26].Value = model.C_PLAN_ROLL;
            parameters[27].Value = model.D_ZZ_START_TIME;
            parameters[28].Value = model.D_ZZ_END_TIME;
            parameters[29].Value = model.D_XM_START_TIME;
            parameters[30].Value = model.D_XM_END_TIME;
            parameters[31].Value = model.C_STD_CODE;
            parameters[32].Value = model.C_SLAB_TYPE;
            parameters[33].Value = model.C_STL_GRD_TYPE;
            parameters[34].Value = model.C_PROD_NAME;
            parameters[35].Value = model.C_PROD_KIND;
            parameters[36].Value = model.N_DFP_HL_TIME;
            parameters[37].Value = model.N_HL_TIME;
            parameters[38].Value = model.N_XM_TIME;
            parameters[39].Value = model.N_GG;
            parameters[40].Value = model.N_CCM_TIME;
            parameters[41].Value = model.C_TJ_REMARK;
            parameters[42].Value = model.C_TL;
            parameters[43].Value = model.N_RH;
            parameters[44].Value = model.N_TL;
            parameters[45].Value = model.N_GZSL;
            parameters[46].Value = model.C_REMARK;
            parameters[47].Value = model.N_XM;
            parameters[48].Value = model.N_DHL;
            parameters[49].Value = model.N_HL;
            parameters[50].Value = model.N_STATUS;
            parameters[51].Value = model.D_P_START_TIME;
            parameters[52].Value = model.D_P_END_TIME;
            parameters[53].Value = model.N_DFP_RZ;
            parameters[54].Value = model.N_RZP_RZ;
            parameters[55].Value = model.C_RH_SFJS;
            parameters[56].Value = model.C_ID;

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
            //该表无主键信息，请自定义主键/条件字段
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from TPP_LGPC_LSB ");
            strSql.Append(" where C_ID='" + C_ID + "'");
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
        public Mod_TPP_LGPC_LSB GetModel(string C_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_CCM_ID,C_CCM_CODE,N_GROUP,N_TOTAL_WGT,N_ZJCLS,N_ZJCLZL,N_MLZL,N_SORT,C_STL_GRD,N_PRODUCE_TIME,N_JSCN,C_BY1,C_BY2,C_BY3,C_RH,C_DFP_HL,C_HL,C_XM,N_ORDER_LS,D_DFPHL_START_TIME,D_DFPHL_END_TIME,D_KP_START_TIME,D_KP_END_TIME,D_HL_START_TIME,D_HL_END_TIME,D_PLAN_KY_TIME,C_PLAN_ROLL,D_ZZ_START_TIME,D_ZZ_END_TIME,D_XM_START_TIME,D_XM_END_TIME,C_STD_CODE,C_SLAB_TYPE,C_STL_GRD_TYPE,C_PROD_NAME,C_PROD_KIND,N_DFP_HL_TIME,N_HL_TIME,N_XM_TIME,N_GG,N_CCM_TIME,C_TJ_REMARK,C_TL,N_RH,N_TL,N_GZSL,C_REMARK,N_XM,N_DHL,N_HL,N_STATUS,D_P_START_TIME,D_P_END_TIME,N_DFP_RZ,N_RZP_RZ,C_RH_SFJS from TPP_LGPC_LSB ");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)            };
            parameters[0].Value = C_ID;

            Mod_TPP_LGPC_LSB model = new Mod_TPP_LGPC_LSB();
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
        public Mod_TPP_LGPC_LSB DataRowToModel(DataRow row)
        {
            Mod_TPP_LGPC_LSB model = new Mod_TPP_LGPC_LSB();
            if (row != null)
            {
                if (row["C_ID"] != null)
                {
                    model.C_ID = row["C_ID"].ToString();
                }
                if (row["C_CCM_ID"] != null)
                {
                    model.C_CCM_ID = row["C_CCM_ID"].ToString();
                }
                if (row["C_CCM_CODE"] != null)
                {
                    model.C_CCM_CODE = row["C_CCM_CODE"].ToString();
                }
                if (row["N_GROUP"] != null && row["N_GROUP"].ToString() != "")
                {
                    model.N_GROUP = decimal.Parse(row["N_GROUP"].ToString());
                }
                if (row["N_TOTAL_WGT"] != null && row["N_TOTAL_WGT"].ToString() != "")
                {
                    model.N_TOTAL_WGT = decimal.Parse(row["N_TOTAL_WGT"].ToString());
                }
                if (row["N_ZJCLS"] != null && row["N_ZJCLS"].ToString() != "")
                {
                    model.N_ZJCLS = decimal.Parse(row["N_ZJCLS"].ToString());
                }
                if (row["N_ZJCLZL"] != null && row["N_ZJCLZL"].ToString() != "")
                {
                    model.N_ZJCLZL = decimal.Parse(row["N_ZJCLZL"].ToString());
                }
                if (row["N_MLZL"] != null && row["N_MLZL"].ToString() != "")
                {
                    model.N_MLZL = decimal.Parse(row["N_MLZL"].ToString());
                }
                if (row["N_SORT"] != null && row["N_SORT"].ToString() != "")
                {
                    model.N_SORT = decimal.Parse(row["N_SORT"].ToString());
                }
                if (row["C_STL_GRD"] != null)
                {
                    model.C_STL_GRD = row["C_STL_GRD"].ToString();
                }
                if (row["N_PRODUCE_TIME"] != null && row["N_PRODUCE_TIME"].ToString() != "")
                {
                    model.N_PRODUCE_TIME = decimal.Parse(row["N_PRODUCE_TIME"].ToString());
                }
                if (row["N_JSCN"] != null && row["N_JSCN"].ToString() != "")
                {
                    model.N_JSCN = decimal.Parse(row["N_JSCN"].ToString());
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
                if (row["N_ORDER_LS"] != null && row["N_ORDER_LS"].ToString() != "")
                {
                    model.N_ORDER_LS = decimal.Parse(row["N_ORDER_LS"].ToString());
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
                if (row["C_STD_CODE"] != null)
                {
                    model.C_STD_CODE = row["C_STD_CODE"].ToString();
                }
                if (row["C_SLAB_TYPE"] != null)
                {
                    model.C_SLAB_TYPE = row["C_SLAB_TYPE"].ToString();
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
                if (row["N_DFP_HL_TIME"] != null && row["N_DFP_HL_TIME"].ToString() != "")
                {
                    model.N_DFP_HL_TIME = decimal.Parse(row["N_DFP_HL_TIME"].ToString());
                }
                if (row["N_HL_TIME"] != null && row["N_HL_TIME"].ToString() != "")
                {
                    model.N_HL_TIME = decimal.Parse(row["N_HL_TIME"].ToString());
                }
                if (row["N_XM_TIME"] != null && row["N_XM_TIME"].ToString() != "")
                {
                    model.N_XM_TIME = decimal.Parse(row["N_XM_TIME"].ToString());
                }
                if (row["N_GG"] != null && row["N_GG"].ToString() != "")
                {
                    model.N_GG = decimal.Parse(row["N_GG"].ToString());
                }
                if (row["N_CCM_TIME"] != null && row["N_CCM_TIME"].ToString() != "")
                {
                    model.N_CCM_TIME = decimal.Parse(row["N_CCM_TIME"].ToString());
                }
                if (row["C_TJ_REMARK"] != null)
                {
                    model.C_TJ_REMARK = row["C_TJ_REMARK"].ToString();
                }
                if (row["C_TL"] != null)
                {
                    model.C_TL = row["C_TL"].ToString();
                }
                if (row["N_RH"] != null && row["N_RH"].ToString() != "")
                {
                    model.N_RH = decimal.Parse(row["N_RH"].ToString());
                }
                if (row["N_TL"] != null && row["N_TL"].ToString() != "")
                {
                    model.N_TL = decimal.Parse(row["N_TL"].ToString());
                }
                if (row["N_GZSL"] != null && row["N_GZSL"].ToString() != "")
                {
                    model.N_GZSL = decimal.Parse(row["N_GZSL"].ToString());
                }
                if (row["C_REMARK"] != null)
                {
                    model.C_REMARK = row["C_REMARK"].ToString();
                }
                if (row["N_XM"] != null && row["N_XM"].ToString() != "")
                {
                    model.N_XM = decimal.Parse(row["N_XM"].ToString());
                }
                if (row["N_DHL"] != null && row["N_DHL"].ToString() != "")
                {
                    model.N_DHL = decimal.Parse(row["N_DHL"].ToString());
                }
                if (row["N_HL"] != null && row["N_HL"].ToString() != "")
                {
                    model.N_HL = decimal.Parse(row["N_HL"].ToString());
                }
                if (row["N_STATUS"] != null && row["N_STATUS"].ToString() != "")
                {
                    model.N_STATUS = decimal.Parse(row["N_STATUS"].ToString());
                }
                if (row["D_P_START_TIME"] != null && row["D_P_START_TIME"].ToString() != "")
                {
                    model.D_P_START_TIME = DateTime.Parse(row["D_P_START_TIME"].ToString());
                }
                if (row["D_P_END_TIME"] != null && row["D_P_END_TIME"].ToString() != "")
                {
                    model.D_P_END_TIME = DateTime.Parse(row["D_P_END_TIME"].ToString());
                }
                if (row["N_DFP_RZ"] != null && row["N_DFP_RZ"].ToString() != "")
                {
                    model.N_DFP_RZ = decimal.Parse(row["N_DFP_RZ"].ToString());
                }
                if (row["N_RZP_RZ"] != null && row["N_RZP_RZ"].ToString() != "")
                {
                    model.N_RZP_RZ = decimal.Parse(row["N_RZP_RZ"].ToString());
                }
                if (row["C_RH_SFJS"] != null)
                {
                    model.C_RH_SFJS = row["C_RH_SFJS"].ToString();
                }

            }
            return model;
        }



        /// <summary>
        /// 根据分组号得到该组序号最大的排序号
        /// </summary>
        /// <param name="N_GROUP">分组号</param>
        /// <returns></returns>
        public Mod_TPP_LGPC_LSB GetModelByGroup(int N_GROUP)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(@"SELECT C_ID,
       C_CCM_ID,
       C_CCM_CODE,
       N_GROUP,
       N_TOTAL_WGT,
       N_ZJCLS,
       N_ZJCLZL,
       N_MLZL,
       N_SORT,
       C_STL_GRD,N_PRODUCE_TIME,N_ORDER_LS,N_JSCN,C_BY1,C_BY2,C_BY3
  FROM TPP_LGPC_LSB T
 WHERE N_GROUP = " + N_GROUP);
            strSql.Append(" AND T.N_SORT =");
            strSql.Append("  (SELECT MAX(A.N_SORT) FROM TPP_LGPC_LSB A WHERE A.N_GROUP = " + N_GROUP);
            strSql.Append("   ) ");

            Mod_TPP_LGPC_LSB model = new Mod_TPP_LGPC_LSB();
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
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string C_CCM_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * ");
            strSql.Append(" FROM TPP_LGPC_LSB ");
            if (C_CCM_ID.Trim() != "")
            {
                strSql.Append(" where  C_CCM_ID='" + C_CCM_ID + "'");
            }

            strSql.Append(" ORDER BY  N_SORT, N_GROUP ");
            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 根据组号获取改组的浇次计划
        /// </summary>
        /// <param name="N_GROUP">组号</param>
        /// <param name="C_CCM_ID">连铸主键</param>
        /// <returns>浇次信息</returns>
        public DataSet GetListByGroup(int N_GROUP, string C_CCM_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * ");
            strSql.Append(" FROM TPP_LGPC_LSB where 1=1  ");
            if (N_GROUP.ToString().Trim() != "")
            {
                strSql.Append(" and   N_GROUP=" + N_GROUP);
            }
            if (C_CCM_ID.Trim() != "")
            {
                strSql.Append(" and  C_CCM_ID='" + C_CCM_ID + "'");
            }

            strSql.Append(" ORDER BY  N_SORT, N_GROUP ");
            return DbHelperOra.Query(strSql.ToString());
        }


        /// <summary>
        /// 分组获取排产订单总重、应排炉数
        /// </summary>
        /// <param name="C_CCM_ID">连铸</param>
        /// <returns></returns>
        public DataSet GetListGroup(string C_CCM_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(@"SELECT SUM(N_TOTAL_WGT) N_TOTAL_WGT, SUM(N_ORDER_LS) N_ORDER_LS
                  FROM(SELECT N_GROUP, N_TOTAL_WGT, N_ORDER_LS
                  FROM TPP_LGPC_LSB ");

            if (C_CCM_ID.Trim() != "")
            {
                strSql.Append(" where  C_CCM_ID='" + C_CCM_ID + "'");
            }

            strSql.Append("  GROUP BY N_GROUP, N_TOTAL_WGT, N_ORDER_LS) A ");
            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM TPP_LGPC_LSB ");
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
            strSql.Append(")AS Row, T.*  from TPP_LGPC_LSB T ");
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
        /// 删除临时表数据
        /// </summary>
        public bool Delete()
        {
            //该表无主键信息，请自定义主键/条件字段
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from TPP_LGPC_LSB ");
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
        /// 验证浇次排产，当前分组已排整浇次炉数-订单需排炉数
        /// </summary>
        /// <param name="N_GROUP">分组号</param>
        /// <returns>差比值</returns>
        public DataTable YZJC(int N_GROUP)
        {
            //差值为负数时需要补浇次，差比为正数时并大于整浇次重量时需要删除已排的浇次
            string sql = @"SELECT T.N_TOTAL_WGT 订单重量,
       SUM(T.N_ZJCLZL) 浇次总重量,
       (SUM(T.N_ZJCLS) - T.N_ORDER_LS) 差值,
       MIN(N_ZJCLZL) 整浇次重量,
       MIN(T.N_ZJCLS) 整浇次炉数
  FROM TPP_LGPC_LSB T
                           WHERE T.N_GROUP = " + N_GROUP;
            sql = sql + "  GROUP BY  N_GROUP, N_ORDER_LS, N_TOTAL_WGT ";
            return DbHelperOra.Query(sql.ToString()).Tables[0];
        }

        /// <summary>
        /// 根据组号，序号返回该浇次是当前分组的第几个浇次
        /// </summary>
        /// <param name="n_group">组号</param>
        /// <param name="n_sort">序号</param>
        /// <param name="C_CCM_ID">连铸主键</param>
        /// <returns>第几个浇次</returns>
        public DataTable GetXhByGroup(int n_group, decimal n_sort, string C_CCM_ID)
        {
            string sql = "SELECT NVL(SUM(T.N_ZJCLS),0) YPLS, (COUNT(1) + 1) N_NUM FROM TPP_LGPC_LSB T WHERE  t.n_group=" + n_group + " AND t.n_sort<" + n_sort + "AND t.C_CCM_ID='" + C_CCM_ID + "'";
            return DbHelperOra.Query(sql.ToString()).Tables[0];
        }

        public bool Update_OrderSort()
        {
            //  return true;

            string sql1 = "SELECT T.C_CCM_ID FROM TPP_LGPC_LSB T ";
            DataTable dtOrder = TransactionHelper.Query(sql1).Tables[0];
            if (dtOrder.Rows.Count > 0)
            {
                for (int i = 0; i < dtOrder.Rows.Count; i++)
                {
                    string sql2 = "SELECT ROWNUM RNO, T.C_ID, T.C_CCM_ID, T.C_CCM_CODE, T.N_GROUP, T.N_TOTAL_WGT, T.N_ZJCLS, T.N_ZJCLZL, T.N_MLZL, T.N_SORT, T.C_STL_GRD, T.N_PRODUCE_TIME, T.N_ORDER_LS, T.N_JSCN, T.C_BY1, T.C_BY2, T.C_BY3,C_RH,C_DFP_HL,C_HL,C_XM  FROM TPP_LGPC_LSB T WHERE T.C_CCM_ID = '" + dtOrder.Rows[i]["C_CCM_ID"].ToString() + "'  ";
                    DataTable dtByCCM = TransactionHelper.Query(sql2).Tables[0];

                    DataTable dtByCCM2 = dtByCCM.Copy();
                    dtByCCM2.Clear();
                    for (int j = 0; j < dtByCCM.Rows.Count; j++)
                    {
                        dtByCCM2.Rows.Add(dtByCCM.Rows[j].ItemArray);
                    }
                    dtByCCM2.DefaultView.Sort = "  ";//将选中的订单按照排产目标进行排序
                    dtByCCM2 = dtByCCM2.DefaultView.ToTable();//获取的需要初始化的表

                    DataRow[] dr = dtByCCM2.Select(" C_BY3='酱色' ");
                    if (dr.Length > 0)
                    {
                        for (int l = 0; l < dr.Length; l++)
                        {
                            if (dtByCCM2.Rows.Count > l * 4)
                            {

                            }
                        }
                    }

                    //int jcs = 0;
                    //for (int k  = 0; k  < dtByCCM2.Rows.Count; k ++)
                    //{

                    //}

                }
            }
            return true;
        }


        /// <summary>
        /// 重新刷新浇次顺序
        /// </summary>
        /// <param name="P_CCM_ID">连铸id</param>
        /// <returns></returns>
        public string ResetSort()
        {
            OracleParameter[] parameters = {
            new OracleParameter("P_MSG", OracleDbType.Varchar2,100)};
            parameters[0].Value = "失败！";
            return DbHelperOra.RunProcedureOut("PKG_UPDATE_SORT.P_UPDATE_SORT", parameters);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update_Trans(string C_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TPP_LGPC_LSB t set C_BY2='0' where T.C_ID in (" + C_ID + ") ");


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
        public bool Delete_Trans()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from TPP_LGPC_LSB t where t.c_id not in(select ta.c_fk from tpp_lgpc_lclsb ta where ta.c_fk is not null) and t.c_ccm_code<>'5#CC' ");

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
        /// 获取浇次列表
        /// </summary>
        /// <returns></returns>
        public DataSet Get_JC_List_Trans()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from tpp_lgpc_lsb t where t.c_ccm_code<>'5#CC' ");

            return DbHelperOra.Query(strSql.ToString());
        }

        #endregion  ExtensionMethod

        #region 炼钢计划排产

        /// <summary>
        /// 清空临时表数据
        /// </summary>
        /// <param name="C_CCM_ID"></param>
        /// <returns></returns>
        public bool DeletePlanByCCM(string C_CCM_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from TPP_LGPC_LSB ");
            strSql.Append(" where C_CCM_ID='" + C_CCM_ID + "'");
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
        /// 清空炉次临时表数据
        /// </summary>
        /// <returns></returns>
        public bool ClearTable(string C_CCM_ID,string C_IS_BXG)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from TPP_LGPC_LSB T WHERE  T.C_SLAB_TYPE='"+ C_IS_BXG + "' ");
            if (C_CCM_ID.Trim()!="")
            {
                strSql.Append(" AND T.C_CCM_ID='" + C_CCM_ID + "'  ");
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

        #endregion
    }
}

