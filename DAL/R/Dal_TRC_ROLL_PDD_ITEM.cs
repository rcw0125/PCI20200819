using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;

namespace DAL
{
    /// <summary>
    /// 数据访问类:TRC_ROLL_PDD_ITEM
    /// </summary>
    public partial class Dal_TRC_ROLL_PDD_ITEM
    {
        public Dal_TRC_ROLL_PDD_ITEM()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string C_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TRC_ROLL_PDD_ITEM");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)         };
            parameters[0].Value = C_ID;

            return DbHelperOra.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Mod_TRC_ROLL_PDD_ITEM model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TRC_ROLL_PDD_ITEM(");
            strSql.Append("C_YSDH,C_MATCODE,C_PCH,C_SX,C_ZCSL,C_FZCZL,C_FREE0,C_FREE1,C_FREE2,C_FREE3,C_FREE4,C_ID,D_INSERT,C_REMARK,N_STATUS,C_CK,C_MATDESC,C_SPEC,C_STL_GRD,C_NC_SL,C_NC_ZL,C_CAP_SL,C_CAP_ZL,C_RF_SL,C_RF_ZL,C_RF_SJ_SL,C_RF_SJ_ZL,C_NC_CAP_SL,C_NC_CAP_ZL,C_RF_CAP_SL,C_RF_CAP_ZL,C_CAP_SJ_SL,C_CAP_SJ_ZL)");
            strSql.Append(" values (");
            strSql.Append(":C_YSDH,:C_MATCODE,:C_PCH,:C_SX,:C_ZCSL,:C_FZCZL,:C_FREE0,:C_FREE1,:C_FREE2,:C_FREE3,:C_FREE4,:C_ID,:D_INSERT,:C_REMARK,:N_STATUS,:C_CK,:C_MATDESC,:C_SPEC,:C_STL_GRD,:C_NC_SL,:C_NC_ZL,:C_CAP_SL,:C_CAP_ZL,:C_RF_SL,:C_RF_ZL,:C_RF_SJ_SL,:C_RF_SJ_ZL,:C_NC_CAP_SL,:C_NC_CAP_ZL,:C_RF_CAP_SL,:C_RF_CAP_ZL,:C_CAP_SJ_SL,:C_CAP_SJ_ZL)");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_YSDH", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MATCODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PCH", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SX", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ZCSL", OracleDbType.Decimal,4),
                    new OracleParameter(":C_FZCZL", OracleDbType.Decimal,18),
                    new OracleParameter(":C_FREE0", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_FREE1", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_FREE2", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_FREE3", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_FREE4", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_INSERT", OracleDbType.Date),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,4),
                    new OracleParameter(":C_CK", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MATDESC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SPEC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STL_GRD", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_NC_SL", OracleDbType.Decimal,4),
                    new OracleParameter(":C_NC_ZL", OracleDbType.Decimal,18),
                    new OracleParameter(":C_CAP_SL", OracleDbType.Decimal,4),
                    new OracleParameter(":C_CAP_ZL", OracleDbType.Decimal,18),
                    new OracleParameter(":C_RF_SL", OracleDbType.Decimal,4),
                    new OracleParameter(":C_RF_ZL", OracleDbType.Decimal,18),
                    new OracleParameter(":C_RF_SJ_SL", OracleDbType.Decimal,4),
                    new OracleParameter(":C_RF_SJ_ZL", OracleDbType.Decimal,18),
                    new OracleParameter(":C_NC_CAP_SL", OracleDbType.Decimal,4),
                    new OracleParameter(":C_NC_CAP_ZL", OracleDbType.Decimal,18),
                    new OracleParameter(":C_RF_CAP_SL", OracleDbType.Decimal,4),
                    new OracleParameter(":C_RF_CAP_ZL", OracleDbType.Decimal,18),
                    new OracleParameter(":C_CAP_SJ_SL", OracleDbType.Decimal,4),
                    new OracleParameter(":C_CAP_SJ_ZL", OracleDbType.Decimal,18)};
            parameters[0].Value = model.C_YSDH;
            parameters[1].Value = model.C_MATCODE;
            parameters[2].Value = model.C_PCH;
            parameters[3].Value = model.C_SX;
            parameters[4].Value = model.C_ZCSL;
            parameters[5].Value = model.C_FZCZL;
            parameters[6].Value = model.C_FREE0;
            parameters[7].Value = model.C_FREE1;
            parameters[8].Value = model.C_FREE2;
            parameters[9].Value = model.C_FREE3;
            parameters[10].Value = model.C_FREE4;
            parameters[11].Value = model.C_ID;
            parameters[12].Value = model.D_INSERT;
            parameters[13].Value = model.C_REMARK;
            parameters[14].Value = model.N_STATUS;
            parameters[15].Value = model.C_CK;
            parameters[16].Value = model.C_MATDESC;
            parameters[17].Value = model.C_SPEC;
            parameters[18].Value = model.C_STL_GRD;
            parameters[19].Value = model.C_NC_SL;
            parameters[20].Value = model.C_NC_ZL;
            parameters[21].Value = model.C_CAP_SL;
            parameters[22].Value = model.C_CAP_ZL;
            parameters[23].Value = model.C_RF_SL;
            parameters[24].Value = model.C_RF_ZL;
            parameters[25].Value = model.C_RF_SJ_SL;
            parameters[26].Value = model.C_RF_SJ_ZL;
            parameters[27].Value = model.C_NC_CAP_SL;
            parameters[28].Value = model.C_NC_CAP_ZL;
            parameters[29].Value = model.C_RF_CAP_SL;
            parameters[30].Value = model.C_RF_CAP_ZL;
            parameters[31].Value = model.C_CAP_SJ_SL;
            parameters[32].Value = model.C_CAP_SJ_ZL;

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
        public bool Add_Trans(Mod_TRC_ROLL_PDD_ITEM model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TRC_ROLL_PDD_ITEM(");
            strSql.Append("C_YSDH,C_MATCODE,C_PCH,C_SX,C_ZCSL,C_FZCZL,C_FREE0,C_FREE1,C_FREE2,C_FREE3,C_FREE4,C_ID,D_INSERT,C_REMARK,N_STATUS,C_CK,C_MATDESC,C_SPEC,C_STL_GRD,C_NC_SL,C_NC_ZL,C_CAP_SL,C_CAP_ZL,C_RF_SL,C_RF_ZL,C_RF_SJ_SL,C_RF_SJ_ZL,C_NC_CAP_SL,C_NC_CAP_ZL,C_RF_CAP_SL,C_RF_CAP_ZL,C_CAP_SJ_SL,C_CAP_SJ_ZL)");
            strSql.Append(" values (");
            strSql.Append(":C_YSDH,:C_MATCODE,:C_PCH,:C_SX,:C_ZCSL,:C_FZCZL,:C_FREE0,:C_FREE1,:C_FREE2,:C_FREE3,:C_FREE4,:C_ID,:D_INSERT,:C_REMARK,:N_STATUS,:C_CK,:C_MATDESC,:C_SPEC,:C_STL_GRD,:C_NC_SL,:C_NC_ZL,:C_CAP_SL,:C_CAP_ZL,:C_RF_SL,:C_RF_ZL,:C_RF_SJ_SL,:C_RF_SJ_ZL,:C_NC_CAP_SL,:C_NC_CAP_ZL,:C_RF_CAP_SL,:C_RF_CAP_ZL,:C_CAP_SJ_SL,:C_CAP_SJ_ZL)");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_YSDH", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MATCODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PCH", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SX", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ZCSL", OracleDbType.Decimal,4),
                    new OracleParameter(":C_FZCZL", OracleDbType.Decimal,18),
                    new OracleParameter(":C_FREE0", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_FREE1", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_FREE2", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_FREE3", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_FREE4", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_INSERT", OracleDbType.Date),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,4),
                    new OracleParameter(":C_CK", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MATDESC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SPEC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STL_GRD", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_NC_SL", OracleDbType.Decimal,4),
                    new OracleParameter(":C_NC_ZL", OracleDbType.Decimal,18),
                    new OracleParameter(":C_CAP_SL", OracleDbType.Decimal,4),
                    new OracleParameter(":C_CAP_ZL", OracleDbType.Decimal,18),
                    new OracleParameter(":C_RF_SL", OracleDbType.Decimal,4),
                    new OracleParameter(":C_RF_ZL", OracleDbType.Decimal,18),
                    new OracleParameter(":C_RF_SJ_SL", OracleDbType.Decimal,4),
                    new OracleParameter(":C_RF_SJ_ZL", OracleDbType.Decimal,18),
                    new OracleParameter(":C_NC_CAP_SL", OracleDbType.Decimal,4),
                    new OracleParameter(":C_NC_CAP_ZL", OracleDbType.Decimal,18),
                    new OracleParameter(":C_RF_CAP_SL", OracleDbType.Decimal,4),
                    new OracleParameter(":C_RF_CAP_ZL", OracleDbType.Decimal,18),
                    new OracleParameter(":C_CAP_SJ_SL", OracleDbType.Decimal,4),
                    new OracleParameter(":C_CAP_SJ_ZL", OracleDbType.Decimal,18)};
            parameters[0].Value = model.C_YSDH;
            parameters[1].Value = model.C_MATCODE;
            parameters[2].Value = model.C_PCH;
            parameters[3].Value = model.C_SX;
            parameters[4].Value = model.C_ZCSL;
            parameters[5].Value = model.C_FZCZL;
            parameters[6].Value = model.C_FREE0;
            parameters[7].Value = model.C_FREE1;
            parameters[8].Value = model.C_FREE2;
            parameters[9].Value = model.C_FREE3;
            parameters[10].Value = model.C_FREE4;
            parameters[11].Value = model.C_ID;
            parameters[12].Value = model.D_INSERT;
            parameters[13].Value = model.C_REMARK;
            parameters[14].Value = model.N_STATUS;
            parameters[15].Value = model.C_CK;
            parameters[16].Value = model.C_MATDESC;
            parameters[17].Value = model.C_SPEC;
            parameters[18].Value = model.C_STL_GRD;
            parameters[19].Value = model.C_NC_SL;
            parameters[20].Value = model.C_NC_ZL;
            parameters[21].Value = model.C_CAP_SL;
            parameters[22].Value = model.C_CAP_ZL;
            parameters[23].Value = model.C_RF_SL;
            parameters[24].Value = model.C_RF_ZL;
            parameters[25].Value = model.C_RF_SJ_SL;
            parameters[26].Value = model.C_RF_SJ_ZL;
            parameters[27].Value = model.C_NC_CAP_SL;
            parameters[28].Value = model.C_NC_CAP_ZL;
            parameters[29].Value = model.C_RF_CAP_SL;
            parameters[30].Value = model.C_RF_CAP_ZL;
            parameters[31].Value = model.C_CAP_SJ_SL;
            parameters[32].Value = model.C_CAP_SJ_ZL;

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
        public bool Update(Mod_TRC_ROLL_PDD_ITEM model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TRC_ROLL_PDD_ITEM set ");
            strSql.Append("C_YSDH=:C_YSDH,");
            strSql.Append("C_MATCODE=:C_MATCODE,");
            strSql.Append("C_PCH=:C_PCH,");
            strSql.Append("C_SX=:C_SX,");
            strSql.Append("C_ZCSL=:C_ZCSL,");
            strSql.Append("C_FZCZL=:C_FZCZL,");
            strSql.Append("C_FREE0=:C_FREE0,");
            strSql.Append("C_FREE1=:C_FREE1,");
            strSql.Append("C_FREE2=:C_FREE2,");
            strSql.Append("C_FREE3=:C_FREE3,");
            strSql.Append("C_FREE4=:C_FREE4,");
            strSql.Append("D_INSERT=:D_INSERT,");
            strSql.Append("C_REMARK=:C_REMARK,");
            strSql.Append("N_STATUS=:N_STATUS,");
            strSql.Append("C_CK=:C_CK,");
            strSql.Append("C_MATDESC=:C_MATDESC,");
            strSql.Append("C_SPEC=:C_SPEC,");
            strSql.Append("C_STL_GRD=:C_STL_GRD,");
            strSql.Append("C_NC_SL=:C_NC_SL,");
            strSql.Append("C_NC_ZL=:C_NC_ZL,");
            strSql.Append("C_CAP_SL=:C_CAP_SL,");
            strSql.Append("C_CAP_ZL=:C_CAP_ZL,");
            strSql.Append("C_RF_SL=:C_RF_SL,");
            strSql.Append("C_RF_ZL=:C_RF_ZL,");
            strSql.Append("C_RF_SJ_SL=:C_RF_SJ_SL,");
            strSql.Append("C_RF_SJ_ZL=:C_RF_SJ_ZL,");
            strSql.Append("C_NC_CAP_SL=:C_NC_CAP_SL,");
            strSql.Append("C_NC_CAP_ZL=:C_NC_CAP_ZL,");
            strSql.Append("C_RF_CAP_SL=:C_RF_CAP_SL,");
            strSql.Append("C_RF_CAP_ZL=:C_RF_CAP_ZL,");
            strSql.Append("C_CAP_SJ_SL=:C_CAP_SJ_SL,");
            strSql.Append("C_CAP_SJ_ZL=:C_CAP_SJ_ZL");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_YSDH", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MATCODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PCH", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SX", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ZCSL", OracleDbType.Decimal,4),
                    new OracleParameter(":C_FZCZL", OracleDbType.Decimal,18),
                    new OracleParameter(":C_FREE0", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_FREE1", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_FREE2", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_FREE3", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_FREE4", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_INSERT", OracleDbType.Date),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,4),
                    new OracleParameter(":C_CK", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MATDESC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SPEC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STL_GRD", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_NC_SL", OracleDbType.Decimal,4),
                    new OracleParameter(":C_NC_ZL", OracleDbType.Decimal,18),
                    new OracleParameter(":C_CAP_SL", OracleDbType.Decimal,4),
                    new OracleParameter(":C_CAP_ZL", OracleDbType.Decimal,18),
                    new OracleParameter(":C_RF_SL", OracleDbType.Decimal,4),
                    new OracleParameter(":C_RF_ZL", OracleDbType.Decimal,18),
                    new OracleParameter(":C_RF_SJ_SL", OracleDbType.Decimal,4),
                    new OracleParameter(":C_RF_SJ_ZL", OracleDbType.Decimal,18),
                    new OracleParameter(":C_NC_CAP_SL", OracleDbType.Decimal,4),
                    new OracleParameter(":C_NC_CAP_ZL", OracleDbType.Decimal,18),
                    new OracleParameter(":C_RF_CAP_SL", OracleDbType.Decimal,4),
                    new OracleParameter(":C_RF_CAP_ZL", OracleDbType.Decimal,18),
                    new OracleParameter(":C_CAP_SJ_SL", OracleDbType.Decimal,4),
                    new OracleParameter(":C_CAP_SJ_ZL", OracleDbType.Decimal,18),
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.C_YSDH;
            parameters[1].Value = model.C_MATCODE;
            parameters[2].Value = model.C_PCH;
            parameters[3].Value = model.C_SX;
            parameters[4].Value = model.C_ZCSL;
            parameters[5].Value = model.C_FZCZL;
            parameters[6].Value = model.C_FREE0;
            parameters[7].Value = model.C_FREE1;
            parameters[8].Value = model.C_FREE2;
            parameters[9].Value = model.C_FREE3;
            parameters[10].Value = model.C_FREE4;
            parameters[11].Value = model.D_INSERT;
            parameters[12].Value = model.C_REMARK;
            parameters[13].Value = model.N_STATUS;
            parameters[14].Value = model.C_CK;
            parameters[15].Value = model.C_MATDESC;
            parameters[16].Value = model.C_SPEC;
            parameters[17].Value = model.C_STL_GRD;
            parameters[18].Value = model.C_NC_SL;
            parameters[19].Value = model.C_NC_ZL;
            parameters[20].Value = model.C_CAP_SL;
            parameters[21].Value = model.C_CAP_ZL;
            parameters[22].Value = model.C_RF_SL;
            parameters[23].Value = model.C_RF_ZL;
            parameters[24].Value = model.C_RF_SJ_SL;
            parameters[25].Value = model.C_RF_SJ_ZL;
            parameters[26].Value = model.C_NC_CAP_SL;
            parameters[27].Value = model.C_NC_CAP_ZL;
            parameters[28].Value = model.C_RF_CAP_SL;
            parameters[29].Value = model.C_RF_CAP_ZL;
            parameters[30].Value = model.C_CAP_SJ_SL;
            parameters[31].Value = model.C_CAP_SJ_ZL;
            parameters[32].Value = model.C_ID;

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
        public bool Update_Trans(Mod_TRC_ROLL_PDD_ITEM model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TRC_ROLL_PDD_ITEM set ");
            strSql.Append("C_YSDH=:C_YSDH,");
            strSql.Append("C_MATCODE=:C_MATCODE,");
            strSql.Append("C_PCH=:C_PCH,");
            strSql.Append("C_SX=:C_SX,");
            strSql.Append("C_ZCSL=:C_ZCSL,");
            strSql.Append("C_FZCZL=:C_FZCZL,");
            strSql.Append("C_FREE0=:C_FREE0,");
            strSql.Append("C_FREE1=:C_FREE1,");
            strSql.Append("C_FREE2=:C_FREE2,");
            strSql.Append("C_FREE3=:C_FREE3,");
            strSql.Append("C_FREE4=:C_FREE4,");
            strSql.Append("D_INSERT=:D_INSERT,");
            strSql.Append("C_REMARK=:C_REMARK,");
            strSql.Append("N_STATUS=:N_STATUS,");
            strSql.Append("C_CK=:C_CK,");
            strSql.Append("C_MATDESC=:C_MATDESC,");
            strSql.Append("C_SPEC=:C_SPEC,");
            strSql.Append("C_STL_GRD=:C_STL_GRD,");
            strSql.Append("C_NC_SL=:C_NC_SL,");
            strSql.Append("C_NC_ZL=:C_NC_ZL,");
            strSql.Append("C_CAP_SL=:C_CAP_SL,");
            strSql.Append("C_CAP_ZL=:C_CAP_ZL,");
            strSql.Append("C_RF_SL=:C_RF_SL,");
            strSql.Append("C_RF_ZL=:C_RF_ZL,");
            strSql.Append("C_RF_SJ_SL=:C_RF_SJ_SL,");
            strSql.Append("C_RF_SJ_ZL=:C_RF_SJ_ZL,");
            strSql.Append("C_NC_CAP_SL=:C_NC_CAP_SL,");
            strSql.Append("C_NC_CAP_ZL=:C_NC_CAP_ZL,");
            strSql.Append("C_RF_CAP_SL=:C_RF_CAP_SL,");
            strSql.Append("C_RF_CAP_ZL=:C_RF_CAP_ZL,");
            strSql.Append("C_CAP_SJ_SL=:C_CAP_SJ_SL,");
            strSql.Append("C_CAP_SJ_ZL=:C_CAP_SJ_ZL");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_YSDH", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MATCODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PCH", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SX", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ZCSL", OracleDbType.Decimal,4),
                    new OracleParameter(":C_FZCZL", OracleDbType.Decimal,18),
                    new OracleParameter(":C_FREE0", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_FREE1", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_FREE2", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_FREE3", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_FREE4", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_INSERT", OracleDbType.Date),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,4),
                    new OracleParameter(":C_CK", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MATDESC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SPEC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STL_GRD", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_NC_SL", OracleDbType.Decimal,4),
                    new OracleParameter(":C_NC_ZL", OracleDbType.Decimal,18),
                    new OracleParameter(":C_CAP_SL", OracleDbType.Decimal,4),
                    new OracleParameter(":C_CAP_ZL", OracleDbType.Decimal,18),
                    new OracleParameter(":C_RF_SL", OracleDbType.Decimal,4),
                    new OracleParameter(":C_RF_ZL", OracleDbType.Decimal,18),
                    new OracleParameter(":C_RF_SJ_SL", OracleDbType.Decimal,4),
                    new OracleParameter(":C_RF_SJ_ZL", OracleDbType.Decimal,18),
                    new OracleParameter(":C_NC_CAP_SL", OracleDbType.Decimal,4),
                    new OracleParameter(":C_NC_CAP_ZL", OracleDbType.Decimal,18),
                    new OracleParameter(":C_RF_CAP_SL", OracleDbType.Decimal,4),
                    new OracleParameter(":C_RF_CAP_ZL", OracleDbType.Decimal,18),
                    new OracleParameter(":C_CAP_SJ_SL", OracleDbType.Decimal,4),
                    new OracleParameter(":C_CAP_SJ_ZL", OracleDbType.Decimal,18),
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.C_YSDH;
            parameters[1].Value = model.C_MATCODE;
            parameters[2].Value = model.C_PCH;
            parameters[3].Value = model.C_SX;
            parameters[4].Value = model.C_ZCSL;
            parameters[5].Value = model.C_FZCZL;
            parameters[6].Value = model.C_FREE0;
            parameters[7].Value = model.C_FREE1;
            parameters[8].Value = model.C_FREE2;
            parameters[9].Value = model.C_FREE3;
            parameters[10].Value = model.C_FREE4;
            parameters[11].Value = model.D_INSERT;
            parameters[12].Value = model.C_REMARK;
            parameters[13].Value = model.N_STATUS;
            parameters[14].Value = model.C_CK;
            parameters[15].Value = model.C_MATDESC;
            parameters[16].Value = model.C_SPEC;
            parameters[17].Value = model.C_STL_GRD;
            parameters[18].Value = model.C_NC_SL;
            parameters[19].Value = model.C_NC_ZL;
            parameters[20].Value = model.C_CAP_SL;
            parameters[21].Value = model.C_CAP_ZL;
            parameters[22].Value = model.C_RF_SL;
            parameters[23].Value = model.C_RF_ZL;
            parameters[24].Value = model.C_RF_SJ_SL;
            parameters[25].Value = model.C_RF_SJ_ZL;
            parameters[26].Value = model.C_NC_CAP_SL;
            parameters[27].Value = model.C_NC_CAP_ZL;
            parameters[28].Value = model.C_RF_CAP_SL;
            parameters[29].Value = model.C_RF_CAP_ZL;
            parameters[30].Value = model.C_CAP_SJ_SL;
            parameters[31].Value = model.C_CAP_SJ_ZL;
            parameters[32].Value = model.C_ID;

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
            strSql.Append("delete from TRC_ROLL_PDD_ITEM ");
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
            strSql.Append("delete from TRC_ROLL_PDD_ITEM ");
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
        public Mod_TRC_ROLL_PDD_ITEM GetModel(string C_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_YSDH,C_MATCODE,C_PCH,C_SX,C_ZCSL,C_FZCZL,C_FREE0,C_FREE1,C_FREE2,C_FREE3,C_FREE4,C_ID,D_INSERT,C_REMARK,N_STATUS,C_CK,C_MATDESC,C_SPEC,C_STL_GRD,C_NC_SL,C_NC_ZL,C_CAP_SL,C_CAP_ZL,C_RF_SL,C_RF_ZL,C_RF_SJ_SL,C_RF_SJ_ZL,C_NC_CAP_SL,C_NC_CAP_ZL,C_RF_CAP_SL,C_RF_CAP_ZL,C_CAP_SJ_SL,C_CAP_SJ_ZL from TRC_ROLL_PDD_ITEM ");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)         };
            parameters[0].Value = C_ID;

            Mod_TRC_ROLL_PDD_ITEM model = new Mod_TRC_ROLL_PDD_ITEM();
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
        public Mod_TRC_ROLL_PDD_ITEM DataRowToModel(DataRow row)
        {
            Mod_TRC_ROLL_PDD_ITEM model = new Mod_TRC_ROLL_PDD_ITEM();
            if (row != null)
            {
                if (row["C_YSDH"] != null)
                {
                    model.C_YSDH = row["C_YSDH"].ToString();
                }
                if (row["C_MATCODE"] != null)
                {
                    model.C_MATCODE = row["C_MATCODE"].ToString();
                }
                if (row["C_PCH"] != null)
                {
                    model.C_PCH = row["C_PCH"].ToString();
                }
                if (row["C_SX"] != null)
                {
                    model.C_SX = row["C_SX"].ToString();
                }
                if (row["C_ZCSL"] != null && row["C_ZCSL"].ToString() != "")
                {
                    model.C_ZCSL = decimal.Parse(row["C_ZCSL"].ToString());
                }
                if (row["C_FZCZL"] != null && row["C_FZCZL"].ToString() != "")
                {
                    model.C_FZCZL = decimal.Parse(row["C_FZCZL"].ToString());
                }
                if (row["C_FREE0"] != null)
                {
                    model.C_FREE0 = row["C_FREE0"].ToString();
                }
                if (row["C_FREE1"] != null)
                {
                    model.C_FREE1 = row["C_FREE1"].ToString();
                }
                if (row["C_FREE2"] != null)
                {
                    model.C_FREE2 = row["C_FREE2"].ToString();
                }
                if (row["C_FREE3"] != null)
                {
                    model.C_FREE3 = row["C_FREE3"].ToString();
                }
                if (row["C_FREE4"] != null)
                {
                    model.C_FREE4 = row["C_FREE4"].ToString();
                }
                if (row["C_ID"] != null)
                {
                    model.C_ID = row["C_ID"].ToString();
                }
                if (row["D_INSERT"] != null && row["D_INSERT"].ToString() != "")
                {
                    model.D_INSERT = DateTime.Parse(row["D_INSERT"].ToString());
                }
                if (row["C_REMARK"] != null)
                {
                    model.C_REMARK = row["C_REMARK"].ToString();
                }
                if (row["N_STATUS"] != null && row["N_STATUS"].ToString() != "")
                {
                    model.N_STATUS = decimal.Parse(row["N_STATUS"].ToString());
                }
                if (row["C_CK"] != null)
                {
                    model.C_CK = row["C_CK"].ToString();
                }
                if (row["C_MATDESC"] != null)
                {
                    model.C_MATDESC = row["C_MATDESC"].ToString();
                }
                if (row["C_SPEC"] != null)
                {
                    model.C_SPEC = row["C_SPEC"].ToString();
                }
                if (row["C_STL_GRD"] != null)
                {
                    model.C_STL_GRD = row["C_STL_GRD"].ToString();
                }
                if (row["C_NC_SL"] != null && row["C_NC_SL"].ToString() != "")
                {
                    model.C_NC_SL = decimal.Parse(row["C_NC_SL"].ToString());
                }
                if (row["C_NC_ZL"] != null && row["C_NC_ZL"].ToString() != "")
                {
                    model.C_NC_ZL = decimal.Parse(row["C_NC_ZL"].ToString());
                }
                if (row["C_CAP_SL"] != null && row["C_CAP_SL"].ToString() != "")
                {
                    model.C_CAP_SL = decimal.Parse(row["C_CAP_SL"].ToString());
                }
                if (row["C_CAP_ZL"] != null && row["C_CAP_ZL"].ToString() != "")
                {
                    model.C_CAP_ZL = decimal.Parse(row["C_CAP_ZL"].ToString());
                }
                if (row["C_RF_SL"] != null && row["C_RF_SL"].ToString() != "")
                {
                    model.C_RF_SL = decimal.Parse(row["C_RF_SL"].ToString());
                }
                if (row["C_RF_ZL"] != null && row["C_RF_ZL"].ToString() != "")
                {
                    model.C_RF_ZL = decimal.Parse(row["C_RF_ZL"].ToString());
                }
                if (row["C_RF_SJ_SL"] != null && row["C_RF_SJ_SL"].ToString() != "")
                {
                    model.C_RF_SJ_SL = decimal.Parse(row["C_RF_SJ_SL"].ToString());
                }
                if (row["C_RF_SJ_ZL"] != null && row["C_RF_SJ_ZL"].ToString() != "")
                {
                    model.C_RF_SJ_ZL = decimal.Parse(row["C_RF_SJ_ZL"].ToString());
                }
                if (row["C_NC_CAP_SL"] != null && row["C_NC_CAP_SL"].ToString() != "")
                {
                    model.C_NC_CAP_SL = decimal.Parse(row["C_NC_CAP_SL"].ToString());
                }
                if (row["C_NC_CAP_ZL"] != null && row["C_NC_CAP_ZL"].ToString() != "")
                {
                    model.C_NC_CAP_ZL = decimal.Parse(row["C_NC_CAP_ZL"].ToString());
                }
                if (row["C_RF_CAP_SL"] != null && row["C_RF_CAP_SL"].ToString() != "")
                {
                    model.C_RF_CAP_SL = decimal.Parse(row["C_RF_CAP_SL"].ToString());
                }
                if (row["C_RF_CAP_ZL"] != null && row["C_RF_CAP_ZL"].ToString() != "")
                {
                    model.C_RF_CAP_ZL = decimal.Parse(row["C_RF_CAP_ZL"].ToString());
                }
                if (row["C_CAP_SJ_SL"] != null && row["C_CAP_SJ_SL"].ToString() != "")
                {
                    model.C_CAP_SJ_SL = decimal.Parse(row["C_CAP_SJ_SL"].ToString());
                }
                if (row["C_CAP_SJ_ZL"] != null && row["C_CAP_SJ_ZL"].ToString() != "")
                {
                    model.C_CAP_SJ_ZL = decimal.Parse(row["C_CAP_SJ_ZL"].ToString());
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
            strSql.Append("select C_YSDH,C_MATCODE,C_PCH,C_SX,C_ZCSL,C_FZCZL,C_FREE0,C_FREE1,C_FREE2,C_FREE3,C_FREE4,C_ID,D_INSERT,C_REMARK,N_STATUS,C_CK,C_MATDESC,C_SPEC,C_STL_GRD,C_NC_SL,C_NC_ZL,C_CAP_SL,C_CAP_ZL,C_RF_SL,C_RF_ZL,C_RF_SJ_SL,C_RF_SJ_ZL,C_NC_CAP_SL,C_NC_CAP_ZL,C_RF_CAP_SL,C_RF_CAP_ZL,C_CAP_SJ_SL,C_CAP_SJ_ZL ");
            strSql.Append(" FROM TRC_ROLL_PDD_ITEM ");
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
            strSql.Append("select count(1) FROM TRC_ROLL_PDD_ITEM ");
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
            strSql.Append(")AS Row, T.*  from TRC_ROLL_PDD_ITEM T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
		/// 获取最大盘点单号
		/// </summary>
		public string Get_Max_ID()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select max(t.C_ID) from TRC_ROLL_PDD_ITEM t ");

            object obj = DbHelperOra.GetSingle(strSql.ToString());
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
        /// 获得数据列表
        /// </summary>
        public DataSet Get_List(string c_ysdh)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_YSDH,C_MATCODE,C_PCH,C_SX,C_ZCSL,C_FZCZL,C_FREE0,C_FREE1,C_FREE2,C_FREE3,C_FREE4,C_ID,D_INSERT,C_REMARK,N_STATUS,C_CK,C_MATDESC,C_SPEC,C_STL_GRD,C_NC_SL,C_NC_ZL,C_CAP_SL,C_CAP_ZL,C_RF_SL,C_RF_ZL,C_RF_SJ_SL,C_RF_SJ_ZL,C_NC_CAP_SL,C_NC_CAP_ZL,C_RF_CAP_SL,C_RF_CAP_ZL,C_CAP_SJ_SL,C_CAP_SJ_ZL ");
            strSql.Append(" FROM TRC_ROLL_PDD_ITEM where c_ysdh='" + c_ysdh + "' ");

            return DbHelperOra.Query(strSql.ToString());
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Mod_TRC_ROLL_PDD_ITEM GetModel(string C_YSDH, string C_MATCODE, string C_PCH, string C_SX, string C_FREE1, string C_FREE2, string C_FREE3)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_YSDH,C_MATCODE,C_PCH,C_SX,C_ZCSL,C_FZCZL,C_FREE0,C_FREE1,C_FREE2,C_FREE3,C_FREE4,C_ID,D_INSERT,C_REMARK,N_STATUS,C_CK,C_MATDESC,C_SPEC,C_STL_GRD,C_NC_SL,C_NC_ZL,C_CAP_SL,C_CAP_ZL,C_RF_SL,C_RF_ZL,C_RF_SJ_SL,C_RF_SJ_ZL,C_NC_CAP_SL,C_NC_CAP_ZL,C_RF_CAP_SL,C_RF_CAP_ZL,C_CAP_SJ_SL,C_CAP_SJ_ZL from TRC_ROLL_PDD_ITEM ");
            strSql.Append(" where C_YSDH='"+ C_YSDH + "' and C_MATCODE='" + C_MATCODE + "' and C_PCH='" + C_PCH + "' and C_SX='" + C_SX + "' and C_FREE1='" + C_FREE1 + "' and C_FREE2='" + C_FREE2 + "' and C_FREE3='" + C_FREE3 + "' ");

            Mod_TRC_ROLL_PDD_ITEM model = new Mod_TRC_ROLL_PDD_ITEM();
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
    }
}

