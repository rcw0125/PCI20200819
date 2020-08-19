using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;
namespace DAL
{
    /// <summary>
	/// 数据访问类:TPC_ORDER_SEQ
	/// </summary>
	public partial class Dal_TPC_ORDER_SEQ
    {
        public Dal_TPC_ORDER_SEQ()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string C_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TPC_ORDER_SEQ");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)         };
            parameters[0].Value = C_ID;

            return DbHelperOra.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Mod_TPC_ORDER_SEQ model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TPC_ORDER_SEQ(");
            strSql.Append("C_ORD_ID,C_STD_ID,N_ORD_WGT,N_REMAIN_WGT,C_CCM_NO,C_CCM_DESC,C_PLANT_ID,C_PLANT_DESC,C_SLAB_SIZE,C_SLAB_LENGTH,N_SLAB_WGT,C_MATRL_NO,C_MATRL_NAME,C_MATRL_GRP_ID,C_MEASURE_TYPE,C_RECEIVE_TYPE,C_RECEIVE_EMP,C_RECEIVE_TIME,C_MATRL_NO_SLAB,C_MATRL_NAME_SLAB,C_MATRL_GRP_ID_SLAB,D_SMS_START,D_SMS_END,D_SRO_START,D_SRO_END,D_FIN_START,D_FIN_END,C_CLOSE_REASON,C_CLOSE_EMP,C_CLOSE_TIME,N_ORD_WGT_SCALE,N_SPEC_WIDTH,N_SPEC_HIGTH,C_CTRL_NO_LG,C_CTRL_NO_ZG,C_LG_CTRL_EMP,C_LG_CTRL_TIME,C_ZG_CTRL_EMP,C_ZG_CTRL_TIME,C_DESIGN_NO,C_ZG_BZ_EMP,C_ZG_BZ_TIME,C_ZG_SH_EMP,C_ZG_SH_TIME,N_REMAIN_SLAB_WGT,C_PC_ISSH,N_ZG_WGT,D_ZG_DATE,N_LG_WGT,D_LG_DATE,N_ZGDDL_WGT,D_ZGDDL_DATE,N_LGDDL_WGT,D_LGDDL_DATE,D_ZG_DATE_B,D_LG_DATE_B,C_MATRL_GRP_NAME,C_MATRL_GRP_NAME_SLAB,D_PLAN_PRODUCT_DATE,C_PLAN_PRODUCT_USER,D_PLAN_PRODUCT_MOD_TIME,C_PLAN_PRODUCT_STATE,D_PLAN_PRODUCT_SH_DATE,C_PLAN_PRODUCT_SH_USER,C_FINISH_TYPE,N_JSCL_WGT,N_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT)");
            strSql.Append(" values (");
            strSql.Append(":C_ORD_ID,:C_STD_ID,:N_ORD_WGT,:N_REMAIN_WGT,:C_CCM_NO,:C_CCM_DESC,:C_PLANT_ID,:C_PLANT_DESC,:C_SLAB_SIZE,:C_SLAB_LENGTH,:N_SLAB_WGT,:C_MATRL_NO,:C_MATRL_NAME,:C_MATRL_GRP_ID,:C_MEASURE_TYPE,:C_RECEIVE_TYPE,:C_RECEIVE_EMP,:C_RECEIVE_TIME,:C_MATRL_NO_SLAB,:C_MATRL_NAME_SLAB,:C_MATRL_GRP_ID_SLAB,:D_SMS_START,:D_SMS_END,:D_SRO_START,:D_SRO_END,:D_FIN_START,:D_FIN_END,:C_CLOSE_REASON,:C_CLOSE_EMP,:C_CLOSE_TIME,:N_ORD_WGT_SCALE,:N_SPEC_WIDTH,:N_SPEC_HIGTH,:C_CTRL_NO_LG,:C_CTRL_NO_ZG,:C_LG_CTRL_EMP,:C_LG_CTRL_TIME,:C_ZG_CTRL_EMP,:C_ZG_CTRL_TIME,:C_DESIGN_NO,:C_ZG_BZ_EMP,:C_ZG_BZ_TIME,:C_ZG_SH_EMP,:C_ZG_SH_TIME,:N_REMAIN_SLAB_WGT,:C_PC_ISSH,:N_ZG_WGT,:D_ZG_DATE,:N_LG_WGT,:D_LG_DATE,:N_ZGDDL_WGT,:D_ZGDDL_DATE,:N_LGDDL_WGT,:D_LGDDL_DATE,:D_ZG_DATE_B,:D_LG_DATE_B,:C_MATRL_GRP_NAME,:C_MATRL_GRP_NAME_SLAB,:D_PLAN_PRODUCT_DATE,:C_PLAN_PRODUCT_USER,:D_PLAN_PRODUCT_MOD_TIME,:C_PLAN_PRODUCT_STATE,:D_PLAN_PRODUCT_SH_DATE,:C_PLAN_PRODUCT_SH_USER,:C_FINISH_TYPE,:N_JSCL_WGT,:N_STATUS,:C_REMARK,:C_EMP_ID,:D_MOD_DT)");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ORD_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STD_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_ORD_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":N_REMAIN_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":C_CCM_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CCM_DESC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PLANT_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PLANT_DESC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SLAB_SIZE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SLAB_LENGTH", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_SLAB_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":C_MATRL_NO", OracleDbType.Varchar2,16),
                    new OracleParameter(":C_MATRL_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MATRL_GRP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MEASURE_TYPE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_RECEIVE_TYPE", OracleDbType.Varchar2,2),
                    new OracleParameter(":C_RECEIVE_EMP", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_RECEIVE_TIME", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MATRL_NO_SLAB", OracleDbType.Varchar2,16),
                    new OracleParameter(":C_MATRL_NAME_SLAB", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MATRL_GRP_ID_SLAB", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_SMS_START", OracleDbType.Date),
                    new OracleParameter(":D_SMS_END", OracleDbType.Date),
                    new OracleParameter(":D_SRO_START", OracleDbType.Date),
                    new OracleParameter(":D_SRO_END", OracleDbType.Date),
                    new OracleParameter(":D_FIN_START", OracleDbType.Date),
                    new OracleParameter(":D_FIN_END", OracleDbType.Date),
                    new OracleParameter(":C_CLOSE_REASON", OracleDbType.Varchar2,200),
                    new OracleParameter(":C_CLOSE_EMP", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CLOSE_TIME", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_ORD_WGT_SCALE", OracleDbType.Decimal,15),
                    new OracleParameter(":N_SPEC_WIDTH", OracleDbType.Decimal,15),
                    new OracleParameter(":N_SPEC_HIGTH", OracleDbType.Decimal,15),
                    new OracleParameter(":C_CTRL_NO_LG", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_CTRL_NO_ZG", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_LG_CTRL_EMP", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_LG_CTRL_TIME", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ZG_CTRL_EMP", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ZG_CTRL_TIME", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_DESIGN_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ZG_BZ_EMP", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ZG_BZ_TIME", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ZG_SH_EMP", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ZG_SH_TIME", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_REMAIN_SLAB_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":C_PC_ISSH", OracleDbType.Varchar2,1),
                    new OracleParameter(":N_ZG_WGT", OracleDbType.Decimal,10),
                    new OracleParameter(":D_ZG_DATE", OracleDbType.Date),
                    new OracleParameter(":N_LG_WGT", OracleDbType.Decimal,10),
                    new OracleParameter(":D_LG_DATE", OracleDbType.Date),
                    new OracleParameter(":N_ZGDDL_WGT", OracleDbType.Decimal,10),
                    new OracleParameter(":D_ZGDDL_DATE", OracleDbType.Date),
                    new OracleParameter(":N_LGDDL_WGT", OracleDbType.Decimal,10),
                    new OracleParameter(":D_LGDDL_DATE", OracleDbType.Date),
                    new OracleParameter(":D_ZG_DATE_B", OracleDbType.Date),
                    new OracleParameter(":D_LG_DATE_B", OracleDbType.Date),
                    new OracleParameter(":C_MATRL_GRP_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MATRL_GRP_NAME_SLAB", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_PLAN_PRODUCT_DATE", OracleDbType.Date),
                    new OracleParameter(":C_PLAN_PRODUCT_USER", OracleDbType.Varchar2,8),
                    new OracleParameter(":D_PLAN_PRODUCT_MOD_TIME", OracleDbType.Date),
                    new OracleParameter(":C_PLAN_PRODUCT_STATE", OracleDbType.Varchar2,8),
                    new OracleParameter(":D_PLAN_PRODUCT_SH_DATE", OracleDbType.Date),
                    new OracleParameter(":C_PLAN_PRODUCT_SH_USER", OracleDbType.Varchar2,8),
                    new OracleParameter(":C_FINISH_TYPE", OracleDbType.Varchar2,8),
                    new OracleParameter(":N_JSCL_WGT", OracleDbType.Decimal,10),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date)};
            parameters[0].Value = model.C_ORD_ID;
            parameters[1].Value = model.C_STD_ID;
            parameters[2].Value = model.N_ORD_WGT;
            parameters[3].Value = model.N_REMAIN_WGT;
            parameters[4].Value = model.C_CCM_NO;
            parameters[5].Value = model.C_CCM_DESC;
            parameters[6].Value = model.C_PLANT_ID;
            parameters[7].Value = model.C_PLANT_DESC;
            parameters[8].Value = model.C_SLAB_SIZE;
            parameters[9].Value =  model.C_SLAB_LENGTH;
            parameters[10].Value = model.N_SLAB_WGT;
            parameters[11].Value = model.C_MATRL_NO;
            parameters[12].Value = model.C_MATRL_NAME;
            parameters[13].Value = model.C_MATRL_GRP_ID;
            parameters[14].Value = model.C_MEASURE_TYPE;
            parameters[15].Value = model.C_RECEIVE_TYPE;
            parameters[16].Value = model.C_RECEIVE_EMP;
            parameters[17].Value = model.C_RECEIVE_TIME;
            parameters[18].Value = model.C_MATRL_NO_SLAB;
            parameters[19].Value = model.C_MATRL_NAME_SLAB;
            parameters[20].Value = model.C_MATRL_GRP_ID_SLAB;
            parameters[21].Value = model.D_SMS_START;
            parameters[22].Value = model.D_SMS_END;
            parameters[23].Value = model.D_SRO_START;
            parameters[24].Value = model.D_SRO_END;
            parameters[25].Value = model.D_FIN_START;
            parameters[26].Value = model.D_FIN_END;
            parameters[27].Value = model.C_CLOSE_REASON;
            parameters[28].Value = model.C_CLOSE_EMP;
            parameters[29].Value = model.C_CLOSE_TIME;
            parameters[30].Value = model.N_ORD_WGT_SCALE;
            parameters[31].Value = model.N_SPEC_WIDTH;
            parameters[32].Value = model.N_SPEC_HIGTH;
            parameters[33].Value = model.C_CTRL_NO_LG;
            parameters[34].Value = model.C_CTRL_NO_ZG;
            parameters[35].Value = model.C_LG_CTRL_EMP;
            parameters[36].Value = model.C_LG_CTRL_TIME;
            parameters[37].Value = model.C_ZG_CTRL_EMP;
            parameters[38].Value = model.C_ZG_CTRL_TIME;
            parameters[39].Value = model.C_DESIGN_NO;
            parameters[40].Value = model.C_ZG_BZ_EMP;
            parameters[41].Value = model.C_ZG_BZ_TIME;
            parameters[42].Value = model.C_ZG_SH_EMP;
            parameters[43].Value = model.C_ZG_SH_TIME;
            parameters[44].Value = model.N_REMAIN_SLAB_WGT;
            parameters[45].Value = model.C_PC_ISSH;
            parameters[46].Value = model.N_ZG_WGT;
            parameters[47].Value = model.D_ZG_DATE;
            parameters[48].Value = model.N_LG_WGT;
            parameters[49].Value = model.D_LG_DATE;
            parameters[50].Value = model.N_ZGDDL_WGT;
            parameters[51].Value = model.D_ZGDDL_DATE;
            parameters[52].Value = model.N_LGDDL_WGT;
            parameters[53].Value = model.D_LGDDL_DATE;
            parameters[54].Value = model.D_ZG_DATE_B;
            parameters[55].Value = model.D_LG_DATE_B;
            parameters[56].Value = model.C_MATRL_GRP_NAME;
            parameters[57].Value = model.C_MATRL_GRP_NAME_SLAB;
            parameters[58].Value = model.D_PLAN_PRODUCT_DATE;
            parameters[59].Value = model.C_PLAN_PRODUCT_USER;
            parameters[60].Value = model.D_PLAN_PRODUCT_MOD_TIME;
            parameters[61].Value = model.C_PLAN_PRODUCT_STATE;
            parameters[62].Value = model.D_PLAN_PRODUCT_SH_DATE;
            parameters[63].Value = model.C_PLAN_PRODUCT_SH_USER;
            parameters[64].Value = model.C_FINISH_TYPE;
            parameters[65].Value = model.N_JSCL_WGT;
            parameters[66].Value = model.N_STATUS;
            parameters[67].Value = model.C_REMARK;
            parameters[68].Value = model.C_EMP_ID;
            parameters[69].Value = model.D_MOD_DT;

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
        public bool Update(Mod_TPC_ORDER_SEQ model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TPC_ORDER_SEQ set ");
            strSql.Append("C_ORD_ID=:C_ORD_ID,");
            strSql.Append("C_STD_ID=:C_STD_ID,");
            strSql.Append("N_ORD_WGT=:N_ORD_WGT,");
            strSql.Append("N_REMAIN_WGT=:N_REMAIN_WGT,");
            strSql.Append("C_CCM_NO=:C_CCM_NO,");
            strSql.Append("C_CCM_DESC=:C_CCM_DESC,");
            strSql.Append("C_PLANT_ID=:C_PLANT_ID,");
            strSql.Append("C_PLANT_DESC=:C_PLANT_DESC,");
            strSql.Append("C_SLAB_SIZE=:C_SLAB_SIZE,");
            strSql.Append("C_SLAB_LENGTH=:C_SLAB_LENGTH,");
            strSql.Append("N_SLAB_WGT=:N_SLAB_WGT,");
            strSql.Append("C_MATRL_NO=:C_MATRL_NO,");
            strSql.Append("C_MATRL_NAME=:C_MATRL_NAME,");
            strSql.Append("C_MATRL_GRP_ID=:C_MATRL_GRP_ID,");
            strSql.Append("C_MEASURE_TYPE=:C_MEASURE_TYPE,");
            strSql.Append("C_RECEIVE_TYPE=:C_RECEIVE_TYPE,");
            strSql.Append("C_RECEIVE_EMP=:C_RECEIVE_EMP,");
            strSql.Append("C_RECEIVE_TIME=:C_RECEIVE_TIME,");
            strSql.Append("C_MATRL_NO_SLAB=:C_MATRL_NO_SLAB,");
            strSql.Append("C_MATRL_NAME_SLAB=:C_MATRL_NAME_SLAB,");
            strSql.Append("C_MATRL_GRP_ID_SLAB=:C_MATRL_GRP_ID_SLAB,");
            strSql.Append("D_SMS_START=:D_SMS_START,");
            strSql.Append("D_SMS_END=:D_SMS_END,");
            strSql.Append("D_SRO_START=:D_SRO_START,");
            strSql.Append("D_SRO_END=:D_SRO_END,");
            strSql.Append("D_FIN_START=:D_FIN_START,");
            strSql.Append("D_FIN_END=:D_FIN_END,");
            strSql.Append("C_CLOSE_REASON=:C_CLOSE_REASON,");
            strSql.Append("C_CLOSE_EMP=:C_CLOSE_EMP,");
            strSql.Append("C_CLOSE_TIME=:C_CLOSE_TIME,");
            strSql.Append("N_ORD_WGT_SCALE=:N_ORD_WGT_SCALE,");
            strSql.Append("N_SPEC_WIDTH=:N_SPEC_WIDTH,");
            strSql.Append("N_SPEC_HIGTH=:N_SPEC_HIGTH,");
            strSql.Append("C_CTRL_NO_LG=:C_CTRL_NO_LG,");
            strSql.Append("C_CTRL_NO_ZG=:C_CTRL_NO_ZG,");
            strSql.Append("C_LG_CTRL_EMP=:C_LG_CTRL_EMP,");
            strSql.Append("C_LG_CTRL_TIME=:C_LG_CTRL_TIME,");
            strSql.Append("C_ZG_CTRL_EMP=:C_ZG_CTRL_EMP,");
            strSql.Append("C_ZG_CTRL_TIME=:C_ZG_CTRL_TIME,");
            strSql.Append("C_DESIGN_NO=:C_DESIGN_NO,");
            strSql.Append("C_ZG_BZ_EMP=:C_ZG_BZ_EMP,");
            strSql.Append("C_ZG_BZ_TIME=:C_ZG_BZ_TIME,");
            strSql.Append("C_ZG_SH_EMP=:C_ZG_SH_EMP,");
            strSql.Append("C_ZG_SH_TIME=:C_ZG_SH_TIME,");
            strSql.Append("N_REMAIN_SLAB_WGT=:N_REMAIN_SLAB_WGT,");
            strSql.Append("C_PC_ISSH=:C_PC_ISSH,");
            strSql.Append("N_ZG_WGT=:N_ZG_WGT,");
            strSql.Append("D_ZG_DATE=:D_ZG_DATE,");
            strSql.Append("N_LG_WGT=:N_LG_WGT,");
            strSql.Append("D_LG_DATE=:D_LG_DATE,");
            strSql.Append("N_ZGDDL_WGT=:N_ZGDDL_WGT,");
            strSql.Append("D_ZGDDL_DATE=:D_ZGDDL_DATE,");
            strSql.Append("N_LGDDL_WGT=:N_LGDDL_WGT,");
            strSql.Append("D_LGDDL_DATE=:D_LGDDL_DATE,");
            strSql.Append("D_ZG_DATE_B=:D_ZG_DATE_B,");
            strSql.Append("D_LG_DATE_B=:D_LG_DATE_B,");
            strSql.Append("C_MATRL_GRP_NAME=:C_MATRL_GRP_NAME,");
            strSql.Append("C_MATRL_GRP_NAME_SLAB=:C_MATRL_GRP_NAME_SLAB,");
            strSql.Append("D_PLAN_PRODUCT_DATE=:D_PLAN_PRODUCT_DATE,");
            strSql.Append("C_PLAN_PRODUCT_USER=:C_PLAN_PRODUCT_USER,");
            strSql.Append("D_PLAN_PRODUCT_MOD_TIME=:D_PLAN_PRODUCT_MOD_TIME,");
            strSql.Append("C_PLAN_PRODUCT_STATE=:C_PLAN_PRODUCT_STATE,");
            strSql.Append("D_PLAN_PRODUCT_SH_DATE=:D_PLAN_PRODUCT_SH_DATE,");
            strSql.Append("C_PLAN_PRODUCT_SH_USER=:C_PLAN_PRODUCT_SH_USER,");
            strSql.Append("C_FINISH_TYPE=:C_FINISH_TYPE,");
            strSql.Append("N_JSCL_WGT=:N_JSCL_WGT,");
            strSql.Append("N_STATUS=:N_STATUS,");
            strSql.Append("C_REMARK=:C_REMARK,");
            strSql.Append("C_EMP_ID=:C_EMP_ID,");
            strSql.Append("D_MOD_DT=:D_MOD_DT");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ORD_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STD_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_ORD_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":N_REMAIN_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":C_CCM_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CCM_DESC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PLANT_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PLANT_DESC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SLAB_SIZE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SLAB_LENGTH", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_SLAB_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":C_MATRL_NO", OracleDbType.Varchar2,16),
                    new OracleParameter(":C_MATRL_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MATRL_GRP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MEASURE_TYPE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_RECEIVE_TYPE", OracleDbType.Varchar2,2),
                    new OracleParameter(":C_RECEIVE_EMP", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_RECEIVE_TIME", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MATRL_NO_SLAB", OracleDbType.Varchar2,16),
                    new OracleParameter(":C_MATRL_NAME_SLAB", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MATRL_GRP_ID_SLAB", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_SMS_START", OracleDbType.Date),
                    new OracleParameter(":D_SMS_END", OracleDbType.Date),
                    new OracleParameter(":D_SRO_START", OracleDbType.Date),
                    new OracleParameter(":D_SRO_END", OracleDbType.Date),
                    new OracleParameter(":D_FIN_START", OracleDbType.Date),
                    new OracleParameter(":D_FIN_END", OracleDbType.Date),
                    new OracleParameter(":C_CLOSE_REASON", OracleDbType.Varchar2,200),
                    new OracleParameter(":C_CLOSE_EMP", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CLOSE_TIME", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_ORD_WGT_SCALE", OracleDbType.Decimal,15),
                    new OracleParameter(":N_SPEC_WIDTH", OracleDbType.Decimal,15),
                    new OracleParameter(":N_SPEC_HIGTH", OracleDbType.Decimal,15),
                    new OracleParameter(":C_CTRL_NO_LG", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_CTRL_NO_ZG", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_LG_CTRL_EMP", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_LG_CTRL_TIME", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ZG_CTRL_EMP", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ZG_CTRL_TIME", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_DESIGN_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ZG_BZ_EMP", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ZG_BZ_TIME", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ZG_SH_EMP", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ZG_SH_TIME", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_REMAIN_SLAB_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":C_PC_ISSH", OracleDbType.Varchar2,1),
                    new OracleParameter(":N_ZG_WGT", OracleDbType.Decimal,10),
                    new OracleParameter(":D_ZG_DATE", OracleDbType.Date),
                    new OracleParameter(":N_LG_WGT", OracleDbType.Decimal,10),
                    new OracleParameter(":D_LG_DATE", OracleDbType.Date),
                    new OracleParameter(":N_ZGDDL_WGT", OracleDbType.Decimal,10),
                    new OracleParameter(":D_ZGDDL_DATE", OracleDbType.Date),
                    new OracleParameter(":N_LGDDL_WGT", OracleDbType.Decimal,10),
                    new OracleParameter(":D_LGDDL_DATE", OracleDbType.Date),
                    new OracleParameter(":D_ZG_DATE_B", OracleDbType.Date),
                    new OracleParameter(":D_LG_DATE_B", OracleDbType.Date),
                    new OracleParameter(":C_MATRL_GRP_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MATRL_GRP_NAME_SLAB", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_PLAN_PRODUCT_DATE", OracleDbType.Date),
                    new OracleParameter(":C_PLAN_PRODUCT_USER", OracleDbType.Varchar2,8),
                    new OracleParameter(":D_PLAN_PRODUCT_MOD_TIME", OracleDbType.Date),
                    new OracleParameter(":C_PLAN_PRODUCT_STATE", OracleDbType.Varchar2,8),
                    new OracleParameter(":D_PLAN_PRODUCT_SH_DATE", OracleDbType.Date),
                    new OracleParameter(":C_PLAN_PRODUCT_SH_USER", OracleDbType.Varchar2,8),
                    new OracleParameter(":C_FINISH_TYPE", OracleDbType.Varchar2,8),
                    new OracleParameter(":N_JSCL_WGT", OracleDbType.Decimal,10),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.C_ORD_ID;
            parameters[1].Value = model.C_STD_ID;
            parameters[2].Value = model.N_ORD_WGT;
            parameters[3].Value = model.N_REMAIN_WGT;
            parameters[4].Value = model.C_CCM_NO;
            parameters[5].Value = model.C_CCM_DESC;
            parameters[6].Value = model.C_PLANT_ID;
            parameters[7].Value = model.C_PLANT_DESC;
            parameters[8].Value = model.C_SLAB_SIZE;
            parameters[9].Value = model.C_SLAB_LENGTH;
            parameters[10].Value = model.N_SLAB_WGT;
            parameters[11].Value = model.C_MATRL_NO;
            parameters[12].Value = model.C_MATRL_NAME;
            parameters[13].Value = model.C_MATRL_GRP_ID;
            parameters[14].Value = model.C_MEASURE_TYPE;
            parameters[15].Value = model.C_RECEIVE_TYPE;
            parameters[16].Value = model.C_RECEIVE_EMP;
            parameters[17].Value = model.C_RECEIVE_TIME;
            parameters[18].Value = model.C_MATRL_NO_SLAB;
            parameters[19].Value = model.C_MATRL_NAME_SLAB;
            parameters[20].Value = model.C_MATRL_GRP_ID_SLAB;
            parameters[21].Value = model.D_SMS_START;
            parameters[22].Value = model.D_SMS_END;
            parameters[23].Value = model.D_SRO_START;
            parameters[24].Value = model.D_SRO_END;
            parameters[25].Value = model.D_FIN_START;
            parameters[26].Value = model.D_FIN_END;
            parameters[27].Value = model.C_CLOSE_REASON;
            parameters[28].Value = model.C_CLOSE_EMP;
            parameters[29].Value = model.C_CLOSE_TIME;
            parameters[30].Value = model.N_ORD_WGT_SCALE;
            parameters[31].Value = model.N_SPEC_WIDTH;
            parameters[32].Value = model.N_SPEC_HIGTH;
            parameters[33].Value = model.C_CTRL_NO_LG;
            parameters[34].Value = model.C_CTRL_NO_ZG;
            parameters[35].Value = model.C_LG_CTRL_EMP;
            parameters[36].Value = model.C_LG_CTRL_TIME;
            parameters[37].Value = model.C_ZG_CTRL_EMP;
            parameters[38].Value = model.C_ZG_CTRL_TIME;
            parameters[39].Value = model.C_DESIGN_NO;
            parameters[40].Value = model.C_ZG_BZ_EMP;
            parameters[41].Value = model.C_ZG_BZ_TIME;
            parameters[42].Value = model.C_ZG_SH_EMP;
            parameters[43].Value = model.C_ZG_SH_TIME;
            parameters[44].Value = model.N_REMAIN_SLAB_WGT;
            parameters[45].Value = model.C_PC_ISSH;
            parameters[46].Value = model.N_ZG_WGT;
            parameters[47].Value = model.D_ZG_DATE;
            parameters[48].Value = model.N_LG_WGT;
            parameters[49].Value = model.D_LG_DATE;
            parameters[50].Value = model.N_ZGDDL_WGT;
            parameters[51].Value = model.D_ZGDDL_DATE;
            parameters[52].Value = model.N_LGDDL_WGT;
            parameters[53].Value = model.D_LGDDL_DATE;
            parameters[54].Value = model.D_ZG_DATE_B;
            parameters[55].Value = model.D_LG_DATE_B;
            parameters[56].Value = model.C_MATRL_GRP_NAME;
            parameters[57].Value = model.C_MATRL_GRP_NAME_SLAB;
            parameters[58].Value = model.D_PLAN_PRODUCT_DATE;
            parameters[59].Value = model.C_PLAN_PRODUCT_USER;
            parameters[60].Value = model.D_PLAN_PRODUCT_MOD_TIME;
            parameters[61].Value = model.C_PLAN_PRODUCT_STATE;
            parameters[62].Value = model.D_PLAN_PRODUCT_SH_DATE;
            parameters[63].Value = model.C_PLAN_PRODUCT_SH_USER;
            parameters[64].Value = model.C_FINISH_TYPE;
            parameters[65].Value = model.N_JSCL_WGT;
            parameters[66].Value = model.N_STATUS;
            parameters[67].Value = model.C_REMARK;
            parameters[68].Value = model.C_EMP_ID;
            parameters[69].Value = model.D_MOD_DT;
            parameters[70].Value = model.C_ID;

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
            strSql.Append("delete from TPC_ORDER_SEQ ");
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
            strSql.Append("delete from TPC_ORDER_SEQ ");
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
        public Mod_TPC_ORDER_SEQ GetModel(string C_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_ORD_ID,C_STD_ID,N_ORD_WGT,N_REMAIN_WGT,C_CCM_NO,C_CCM_DESC,C_PLANT_ID,C_PLANT_DESC,C_SLAB_SIZE,C_SLAB_LENGTH,N_SLAB_WGT,C_MATRL_NO,C_MATRL_NAME,C_MATRL_GRP_ID,C_MEASURE_TYPE,C_RECEIVE_TYPE,C_RECEIVE_EMP,C_RECEIVE_TIME,C_MATRL_NO_SLAB,C_MATRL_NAME_SLAB,C_MATRL_GRP_ID_SLAB,D_SMS_START,D_SMS_END,D_SRO_START,D_SRO_END,D_FIN_START,D_FIN_END,C_CLOSE_REASON,C_CLOSE_EMP,C_CLOSE_TIME,N_ORD_WGT_SCALE,N_SPEC_WIDTH,N_SPEC_HIGTH,C_CTRL_NO_LG,C_CTRL_NO_ZG,C_LG_CTRL_EMP,C_LG_CTRL_TIME,C_ZG_CTRL_EMP,C_ZG_CTRL_TIME,C_DESIGN_NO,C_ZG_BZ_EMP,C_ZG_BZ_TIME,C_ZG_SH_EMP,C_ZG_SH_TIME,N_REMAIN_SLAB_WGT,C_PC_ISSH,N_ZG_WGT,D_ZG_DATE,N_LG_WGT,D_LG_DATE,N_ZGDDL_WGT,D_ZGDDL_DATE,N_LGDDL_WGT,D_LGDDL_DATE,D_ZG_DATE_B,D_LG_DATE_B,C_MATRL_GRP_NAME,C_MATRL_GRP_NAME_SLAB,D_PLAN_PRODUCT_DATE,C_PLAN_PRODUCT_USER,D_PLAN_PRODUCT_MOD_TIME,C_PLAN_PRODUCT_STATE,D_PLAN_PRODUCT_SH_DATE,C_PLAN_PRODUCT_SH_USER,C_FINISH_TYPE,N_JSCL_WGT,N_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT from TPC_ORDER_SEQ ");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)         };
            parameters[0].Value = C_ID;

            Mod_TPC_ORDER_SEQ model = new Mod_TPC_ORDER_SEQ();
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
        public Mod_TPC_ORDER_SEQ DataRowToModel(DataRow row)
        {
            Mod_TPC_ORDER_SEQ model = new Mod_TPC_ORDER_SEQ();
            if (row != null)
            {
                if (row["C_ID"] != null)
                {
                    model.C_ID = row["C_ID"].ToString();
                }
                if (row["C_ORD_ID"] != null)
                {
                    model.C_ORD_ID = row["C_ORD_ID"].ToString();
                }
                if (row["C_STD_ID"] != null)
                {
                    model.C_STD_ID = row["C_STD_ID"].ToString();
                }
                if (row["N_ORD_WGT"] != null && row["N_ORD_WGT"].ToString() != "")
                {
                    model.N_ORD_WGT = decimal.Parse(row["N_ORD_WGT"].ToString());
                }
                if (row["N_REMAIN_WGT"] != null && row["N_REMAIN_WGT"].ToString() != "")
                {
                    model.N_REMAIN_WGT = decimal.Parse(row["N_REMAIN_WGT"].ToString());
                }
                if (row["C_CCM_NO"] != null)
                {
                    model.C_CCM_NO = row["C_CCM_NO"].ToString();
                }
                if (row["C_CCM_DESC"] != null)
                {
                    model.C_CCM_DESC = row["C_CCM_DESC"].ToString();
                }
                if (row["C_PLANT_ID"] != null)
                {
                    model.C_PLANT_ID = row["C_PLANT_ID"].ToString();
                }
                if (row["C_PLANT_DESC"] != null)
                {
                    model.C_PLANT_DESC = row["C_PLANT_DESC"].ToString();
                }
                if (row["C_SLAB_SIZE"] != null)
                {
                    model.C_SLAB_SIZE = row["C_SLAB_SIZE"].ToString();
                }
                if (row["C_SLAB_LENGTH"] != null)
                {
                    model.C_SLAB_LENGTH = row["C_SLAB_LENGTH"].ToString();
                }
                if (row["N_SLAB_WGT"] != null && row["N_SLAB_WGT"].ToString() != "")
                {
                    model.N_SLAB_WGT = decimal.Parse(row["N_SLAB_WGT"].ToString());
                }
                if (row["C_MATRL_NO"] != null)
                {
                    model.C_MATRL_NO = row["C_MATRL_NO"].ToString();
                }
                if (row["C_MATRL_NAME"] != null)
                {
                    model.C_MATRL_NAME = row["C_MATRL_NAME"].ToString();
                }
                if (row["C_MATRL_GRP_ID"] != null)
                {
                    model.C_MATRL_GRP_ID = row["C_MATRL_GRP_ID"].ToString();
                }
                if (row["C_MEASURE_TYPE"] != null)
                {
                    model.C_MEASURE_TYPE = row["C_MEASURE_TYPE"].ToString();
                }
                if (row["C_RECEIVE_TYPE"] != null)
                {
                    model.C_RECEIVE_TYPE = row["C_RECEIVE_TYPE"].ToString();
                }
                if (row["C_RECEIVE_EMP"] != null)
                {
                    model.C_RECEIVE_EMP = row["C_RECEIVE_EMP"].ToString();
                }
                if (row["C_RECEIVE_TIME"] != null)
                {
                    model.C_RECEIVE_TIME = row["C_RECEIVE_TIME"].ToString();
                }
                if (row["C_MATRL_NO_SLAB"] != null)
                {
                    model.C_MATRL_NO_SLAB = row["C_MATRL_NO_SLAB"].ToString();
                }
                if (row["C_MATRL_NAME_SLAB"] != null)
                {
                    model.C_MATRL_NAME_SLAB = row["C_MATRL_NAME_SLAB"].ToString();
                }
                if (row["C_MATRL_GRP_ID_SLAB"] != null)
                {
                    model.C_MATRL_GRP_ID_SLAB = row["C_MATRL_GRP_ID_SLAB"].ToString();
                }
                if (row["D_SMS_START"] != null && row["D_SMS_START"].ToString() != "")
                {
                    model.D_SMS_START = DateTime.Parse(row["D_SMS_START"].ToString());
                }
                if (row["D_SMS_END"] != null && row["D_SMS_END"].ToString() != "")
                {
                    model.D_SMS_END = DateTime.Parse(row["D_SMS_END"].ToString());
                }
                if (row["D_SRO_START"] != null && row["D_SRO_START"].ToString() != "")
                {
                    model.D_SRO_START = DateTime.Parse(row["D_SRO_START"].ToString());
                }
                if (row["D_SRO_END"] != null && row["D_SRO_END"].ToString() != "")
                {
                    model.D_SRO_END = DateTime.Parse(row["D_SRO_END"].ToString());
                }
                if (row["D_FIN_START"] != null && row["D_FIN_START"].ToString() != "")
                {
                    model.D_FIN_START = DateTime.Parse(row["D_FIN_START"].ToString());
                }
                if (row["D_FIN_END"] != null && row["D_FIN_END"].ToString() != "")
                {
                    model.D_FIN_END = DateTime.Parse(row["D_FIN_END"].ToString());
                }
                if (row["C_CLOSE_REASON"] != null)
                {
                    model.C_CLOSE_REASON = row["C_CLOSE_REASON"].ToString();
                }
                if (row["C_CLOSE_EMP"] != null)
                {
                    model.C_CLOSE_EMP = row["C_CLOSE_EMP"].ToString();
                }
                if (row["C_CLOSE_TIME"] != null)
                {
                    model.C_CLOSE_TIME = row["C_CLOSE_TIME"].ToString();
                }
                if (row["N_ORD_WGT_SCALE"] != null && row["N_ORD_WGT_SCALE"].ToString() != "")
                {
                    model.N_ORD_WGT_SCALE = decimal.Parse(row["N_ORD_WGT_SCALE"].ToString());
                }
                if (row["N_SPEC_WIDTH"] != null && row["N_SPEC_WIDTH"].ToString() != "")
                {
                    model.N_SPEC_WIDTH = decimal.Parse(row["N_SPEC_WIDTH"].ToString());
                }
                if (row["N_SPEC_HIGTH"] != null && row["N_SPEC_HIGTH"].ToString() != "")
                {
                    model.N_SPEC_HIGTH = decimal.Parse(row["N_SPEC_HIGTH"].ToString());
                }
                if (row["C_CTRL_NO_LG"] != null)
                {
                    model.C_CTRL_NO_LG = row["C_CTRL_NO_LG"].ToString();
                }
                if (row["C_CTRL_NO_ZG"] != null)
                {
                    model.C_CTRL_NO_ZG = row["C_CTRL_NO_ZG"].ToString();
                }
                if (row["C_LG_CTRL_EMP"] != null)
                {
                    model.C_LG_CTRL_EMP = row["C_LG_CTRL_EMP"].ToString();
                }
                if (row["C_LG_CTRL_TIME"] != null)
                {
                    model.C_LG_CTRL_TIME = row["C_LG_CTRL_TIME"].ToString();
                }
                if (row["C_ZG_CTRL_EMP"] != null)
                {
                    model.C_ZG_CTRL_EMP = row["C_ZG_CTRL_EMP"].ToString();
                }
                if (row["C_ZG_CTRL_TIME"] != null)
                {
                    model.C_ZG_CTRL_TIME = row["C_ZG_CTRL_TIME"].ToString();
                }
                if (row["C_DESIGN_NO"] != null)
                {
                    model.C_DESIGN_NO = row["C_DESIGN_NO"].ToString();
                }
                if (row["C_ZG_BZ_EMP"] != null)
                {
                    model.C_ZG_BZ_EMP = row["C_ZG_BZ_EMP"].ToString();
                }
                if (row["C_ZG_BZ_TIME"] != null)
                {
                    model.C_ZG_BZ_TIME = row["C_ZG_BZ_TIME"].ToString();
                }
                if (row["C_ZG_SH_EMP"] != null)
                {
                    model.C_ZG_SH_EMP = row["C_ZG_SH_EMP"].ToString();
                }
                if (row["C_ZG_SH_TIME"] != null)
                {
                    model.C_ZG_SH_TIME = row["C_ZG_SH_TIME"].ToString();
                }
                if (row["N_REMAIN_SLAB_WGT"] != null && row["N_REMAIN_SLAB_WGT"].ToString() != "")
                {
                    model.N_REMAIN_SLAB_WGT = decimal.Parse(row["N_REMAIN_SLAB_WGT"].ToString());
                }
                if (row["C_PC_ISSH"] != null)
                {
                    model.C_PC_ISSH = row["C_PC_ISSH"].ToString();
                }
                if (row["N_ZG_WGT"] != null && row["N_ZG_WGT"].ToString() != "")
                {
                    model.N_ZG_WGT = decimal.Parse(row["N_ZG_WGT"].ToString());
                }
                if (row["D_ZG_DATE"] != null && row["D_ZG_DATE"].ToString() != "")
                {
                    model.D_ZG_DATE = DateTime.Parse(row["D_ZG_DATE"].ToString());
                }
                if (row["N_LG_WGT"] != null && row["N_LG_WGT"].ToString() != "")
                {
                    model.N_LG_WGT = decimal.Parse(row["N_LG_WGT"].ToString());
                }
                if (row["D_LG_DATE"] != null && row["D_LG_DATE"].ToString() != "")
                {
                    model.D_LG_DATE = DateTime.Parse(row["D_LG_DATE"].ToString());
                }
                if (row["N_ZGDDL_WGT"] != null && row["N_ZGDDL_WGT"].ToString() != "")
                {
                    model.N_ZGDDL_WGT = decimal.Parse(row["N_ZGDDL_WGT"].ToString());
                }
                if (row["D_ZGDDL_DATE"] != null && row["D_ZGDDL_DATE"].ToString() != "")
                {
                    model.D_ZGDDL_DATE = DateTime.Parse(row["D_ZGDDL_DATE"].ToString());
                }
                if (row["N_LGDDL_WGT"] != null && row["N_LGDDL_WGT"].ToString() != "")
                {
                    model.N_LGDDL_WGT = decimal.Parse(row["N_LGDDL_WGT"].ToString());
                }
                if (row["D_LGDDL_DATE"] != null && row["D_LGDDL_DATE"].ToString() != "")
                {
                    model.D_LGDDL_DATE = DateTime.Parse(row["D_LGDDL_DATE"].ToString());
                }
                if (row["D_ZG_DATE_B"] != null && row["D_ZG_DATE_B"].ToString() != "")
                {
                    model.D_ZG_DATE_B = DateTime.Parse(row["D_ZG_DATE_B"].ToString());
                }
                if (row["D_LG_DATE_B"] != null && row["D_LG_DATE_B"].ToString() != "")
                {
                    model.D_LG_DATE_B = DateTime.Parse(row["D_LG_DATE_B"].ToString());
                }
                if (row["C_MATRL_GRP_NAME"] != null)
                {
                    model.C_MATRL_GRP_NAME = row["C_MATRL_GRP_NAME"].ToString();
                }
                if (row["C_MATRL_GRP_NAME_SLAB"] != null)
                {
                    model.C_MATRL_GRP_NAME_SLAB = row["C_MATRL_GRP_NAME_SLAB"].ToString();
                }
                if (row["D_PLAN_PRODUCT_DATE"] != null && row["D_PLAN_PRODUCT_DATE"].ToString() != "")
                {
                    model.D_PLAN_PRODUCT_DATE = DateTime.Parse(row["D_PLAN_PRODUCT_DATE"].ToString());
                }
                if (row["C_PLAN_PRODUCT_USER"] != null)
                {
                    model.C_PLAN_PRODUCT_USER = row["C_PLAN_PRODUCT_USER"].ToString();
                }
                if (row["D_PLAN_PRODUCT_MOD_TIME"] != null && row["D_PLAN_PRODUCT_MOD_TIME"].ToString() != "")
                {
                    model.D_PLAN_PRODUCT_MOD_TIME = DateTime.Parse(row["D_PLAN_PRODUCT_MOD_TIME"].ToString());
                }
                if (row["C_PLAN_PRODUCT_STATE"] != null)
                {
                    model.C_PLAN_PRODUCT_STATE = row["C_PLAN_PRODUCT_STATE"].ToString();
                }
                if (row["D_PLAN_PRODUCT_SH_DATE"] != null && row["D_PLAN_PRODUCT_SH_DATE"].ToString() != "")
                {
                    model.D_PLAN_PRODUCT_SH_DATE = DateTime.Parse(row["D_PLAN_PRODUCT_SH_DATE"].ToString());
                }
                if (row["C_PLAN_PRODUCT_SH_USER"] != null)
                {
                    model.C_PLAN_PRODUCT_SH_USER = row["C_PLAN_PRODUCT_SH_USER"].ToString();
                }
                if (row["C_FINISH_TYPE"] != null)
                {
                    model.C_FINISH_TYPE = row["C_FINISH_TYPE"].ToString();
                }
                if (row["N_JSCL_WGT"] != null && row["N_JSCL_WGT"].ToString() != "")
                {
                    model.N_JSCL_WGT = decimal.Parse(row["N_JSCL_WGT"].ToString());
                }
                if (row["N_STATUS"] != null && row["N_STATUS"].ToString() != "")
                {
                    model.N_STATUS = decimal.Parse(row["N_STATUS"].ToString());
                }
                if (row["C_REMARK"] != null)
                {
                    model.C_REMARK = row["C_REMARK"].ToString();
                }
                if (row["C_EMP_ID"] != null)
                {
                    model.C_EMP_ID = row["C_EMP_ID"].ToString();
                }
                if (row["D_MOD_DT"] != null && row["D_MOD_DT"].ToString() != "")
                {
                    model.D_MOD_DT = DateTime.Parse(row["D_MOD_DT"].ToString());
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
            strSql.Append("select C_ID,C_ORD_ID,C_STD_ID,N_ORD_WGT,N_REMAIN_WGT,C_CCM_NO,C_CCM_DESC,C_PLANT_ID,C_PLANT_DESC,C_SLAB_SIZE,C_SLAB_LENGTH,N_SLAB_WGT,C_MATRL_NO,C_MATRL_NAME,C_MATRL_GRP_ID,C_MEASURE_TYPE,C_RECEIVE_TYPE,C_RECEIVE_EMP,C_RECEIVE_TIME,C_MATRL_NO_SLAB,C_MATRL_NAME_SLAB,C_MATRL_GRP_ID_SLAB,D_SMS_START,D_SMS_END,D_SRO_START,D_SRO_END,D_FIN_START,D_FIN_END,C_CLOSE_REASON,C_CLOSE_EMP,C_CLOSE_TIME,N_ORD_WGT_SCALE,N_SPEC_WIDTH,N_SPEC_HIGTH,C_CTRL_NO_LG,C_CTRL_NO_ZG,C_LG_CTRL_EMP,C_LG_CTRL_TIME,C_ZG_CTRL_EMP,C_ZG_CTRL_TIME,C_DESIGN_NO,C_ZG_BZ_EMP,C_ZG_BZ_TIME,C_ZG_SH_EMP,C_ZG_SH_TIME,N_REMAIN_SLAB_WGT,C_PC_ISSH,N_ZG_WGT,D_ZG_DATE,N_LG_WGT,D_LG_DATE,N_ZGDDL_WGT,D_ZGDDL_DATE,N_LGDDL_WGT,D_LGDDL_DATE,D_ZG_DATE_B,D_LG_DATE_B,C_MATRL_GRP_NAME,C_MATRL_GRP_NAME_SLAB,D_PLAN_PRODUCT_DATE,C_PLAN_PRODUCT_USER,D_PLAN_PRODUCT_MOD_TIME,C_PLAN_PRODUCT_STATE,D_PLAN_PRODUCT_SH_DATE,C_PLAN_PRODUCT_SH_USER,C_FINISH_TYPE,N_JSCL_WGT,N_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT ");
            strSql.Append(" FROM TPC_ORDER_SEQ ");
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
            strSql.Append("select count(1) FROM TPC_ORDER_SEQ ");
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
            strSql.Append(")AS Row, T.*  from TPC_ORDER_SEQ T ");
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

        #endregion  ExtensionMethod
    }
}
