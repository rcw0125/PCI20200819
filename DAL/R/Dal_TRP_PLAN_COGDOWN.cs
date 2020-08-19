using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;
namespace DAL
{
    public partial class Dal_TRP_PLAN_COGDOWN
    {
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string C_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TRP_PLAN_COGDOWN");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)            };
            parameters[0].Value = C_ID;

            return DbHelperOra.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Mod_TRP_PLAN_COGDOWN model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TRP_PLAN_COGDOWN(");
            strSql.Append("C_ID,N_STATUS,C_INITIALIZE_ITEM_ID,C_ORDER_NO,N_WGT,C_MAT_CODE,C_MAT_NAME,C_TECH_PROT,C_SPEC,C_STL_GRD,C_STD_CODE,N_USER_LEV,N_STL_GRD_LEV,N_ORDER_LEV,C_QUALIRY_LEV,D_NEED_DT,D_DELIVERY_DT,D_DT,C_LINE_DESC,C_LINE_CODE,D_P_START_TIME,D_P_END_TIME,N_PROD_TIME,N_SORT,N_ROLL_PROD_WGT,C_ROLL_PROD_EMP_ID,C_STL_ROL_DT,N_PROD_WGT,N_WARE_WGT,N_WARE_OUT_WGT,N_FLAG,N_ISSUE_WGT,C_CUST_NO,C_CUST_NAME,C_SALE_CHANNEL,C_PACK,C_DESIGN_NO,N_GROUP_WGT,C_STA_ID,D_START_TIME,D_END_TIME,C_EMP_ID,D_MOD_DT,N_ROLL_WGT,N_MACH_WGT,C_CAST_NO,C_INITIALIZE_ID,N_UPLOADSTATUS,C_FREE1,C_FREE2,N_PW,N_LENTH,C_MATRL_CODE_SLAB,C_MATRL_NAME_SLAB,C_SLAB_SIZE,N_SLAB_LENGTH,N_SLAB_PW)");
            strSql.Append(" values (");
            strSql.Append(":C_ID,:N_STATUS,:C_INITIALIZE_ITEM_ID,:C_ORDER_NO,:N_WGT,:C_MAT_CODE,:C_MAT_NAME,:C_TECH_PROT,:C_SPEC,:C_STL_GRD,:C_STD_CODE,:N_USER_LEV,:N_STL_GRD_LEV,:N_ORDER_LEV,:C_QUALIRY_LEV,:D_NEED_DT,:D_DELIVERY_DT,:D_DT,:C_LINE_DESC,:C_LINE_CODE,:D_P_START_TIME,:D_P_END_TIME,:N_PROD_TIME,:N_SORT,:N_ROLL_PROD_WGT,:C_ROLL_PROD_EMP_ID,:C_STL_ROL_DT,:N_PROD_WGT,:N_WARE_WGT,:N_WARE_OUT_WGT,:N_FLAG,:N_ISSUE_WGT,:C_CUST_NO,:C_CUST_NAME,:C_SALE_CHANNEL,:C_PACK,:C_DESIGN_NO,:N_GROUP_WGT,:C_STA_ID,:D_START_TIME,:D_END_TIME,:C_EMP_ID,:D_MOD_DT,:N_ROLL_WGT,:N_MACH_WGT,:C_CAST_NO,:C_INITIALIZE_ID,:N_UPLOADSTATUS,:C_FREE1,:C_FREE2,:N_PW,:N_LENTH,:C_MATRL_CODE_SLAB,:C_MATRL_NAME_SLAB,:C_SLAB_SIZE,:N_SLAB_LENGTH,:N_SLAB_PW)");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
                    new OracleParameter(":C_INITIALIZE_ITEM_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ORDER_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":C_MAT_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MAT_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_TECH_PROT", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SPEC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STL_GRD", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STD_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_USER_LEV", OracleDbType.Decimal,5),
                    new OracleParameter(":N_STL_GRD_LEV", OracleDbType.Decimal,5),
                    new OracleParameter(":N_ORDER_LEV", OracleDbType.Decimal,5),
                    new OracleParameter(":C_QUALIRY_LEV", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_NEED_DT", OracleDbType.Date),
                    new OracleParameter(":D_DELIVERY_DT", OracleDbType.Date),
                    new OracleParameter(":D_DT", OracleDbType.Date),
                    new OracleParameter(":C_LINE_DESC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_LINE_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_P_START_TIME", OracleDbType.Date),
                    new OracleParameter(":D_P_END_TIME", OracleDbType.Date),
                    new OracleParameter(":N_PROD_TIME", OracleDbType.Decimal,5),
                    new OracleParameter(":N_SORT", OracleDbType.Decimal,5),
                    new OracleParameter(":N_ROLL_PROD_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":C_ROLL_PROD_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STL_ROL_DT", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_PROD_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":N_WARE_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":N_WARE_OUT_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":N_FLAG", OracleDbType.Decimal,5),
                    new OracleParameter(":N_ISSUE_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":C_CUST_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CUST_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SALE_CHANNEL", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PACK", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_DESIGN_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_GROUP_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":C_STA_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_START_TIME", OracleDbType.Date),
                    new OracleParameter(":D_END_TIME", OracleDbType.Date),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":N_ROLL_WGT", OracleDbType.Decimal,5),
                    new OracleParameter(":N_MACH_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":C_CAST_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_INITIALIZE_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_UPLOADSTATUS", OracleDbType.Decimal,1),
                    new OracleParameter(":C_FREE1", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_FREE2", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_PW", OracleDbType.Decimal,15),
                    new OracleParameter(":N_LENTH", OracleDbType.Decimal,15),
                    new OracleParameter(":C_MATRL_CODE_SLAB", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MATRL_NAME_SLAB", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SLAB_SIZE", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_SLAB_LENGTH", OracleDbType.Decimal,15),
                    new OracleParameter(":N_SLAB_PW", OracleDbType.Decimal,15)};
            parameters[0].Value = model.C_ID;
            parameters[1].Value = model.N_STATUS;
            parameters[2].Value = model.C_INITIALIZE_ITEM_ID;
            parameters[3].Value = model.C_ORDER_NO;
            parameters[4].Value = model.N_WGT;
            parameters[5].Value = model.C_MAT_CODE;
            parameters[6].Value = model.C_MAT_NAME;
            parameters[7].Value = model.C_TECH_PROT;
            parameters[8].Value = model.C_SPEC;
            parameters[9].Value = model.C_STL_GRD;
            parameters[10].Value = model.C_STD_CODE;
            parameters[11].Value = model.N_USER_LEV;
            parameters[12].Value = model.N_STL_GRD_LEV;
            parameters[13].Value = model.N_ORDER_LEV;
            parameters[14].Value = model.C_QUALIRY_LEV;
            parameters[15].Value = model.D_NEED_DT;
            parameters[16].Value = model.D_DELIVERY_DT;
            parameters[17].Value = model.D_DT;
            parameters[18].Value = model.C_LINE_DESC;
            parameters[19].Value = model.C_LINE_CODE;
            parameters[20].Value = model.D_P_START_TIME;
            parameters[21].Value = model.D_P_END_TIME;
            parameters[22].Value = model.N_PROD_TIME;
            parameters[23].Value = model.N_SORT;
            parameters[24].Value = model.N_ROLL_PROD_WGT;
            parameters[25].Value = model.C_ROLL_PROD_EMP_ID;
            parameters[26].Value = model.C_STL_ROL_DT;
            parameters[27].Value = model.N_PROD_WGT;
            parameters[28].Value = model.N_WARE_WGT;
            parameters[29].Value = model.N_WARE_OUT_WGT;
            parameters[30].Value = model.N_FLAG;
            parameters[31].Value = model.N_ISSUE_WGT;
            parameters[32].Value = model.C_CUST_NO;
            parameters[33].Value = model.C_CUST_NAME;
            parameters[34].Value = model.C_SALE_CHANNEL;
            parameters[35].Value = model.C_PACK;
            parameters[36].Value = model.C_DESIGN_NO;
            parameters[37].Value = model.N_GROUP_WGT;
            parameters[38].Value = model.C_STA_ID;
            parameters[39].Value = model.D_START_TIME;
            parameters[40].Value = model.D_END_TIME;
            parameters[41].Value = model.C_EMP_ID;
            parameters[42].Value = model.D_MOD_DT;
            parameters[43].Value = model.N_ROLL_WGT;
            parameters[44].Value = model.N_MACH_WGT;
            parameters[45].Value = model.C_CAST_NO;
            parameters[46].Value = model.C_INITIALIZE_ID;
            parameters[47].Value = model.N_UPLOADSTATUS;
            parameters[48].Value = model.C_FREE1;
            parameters[49].Value = model.C_FREE2;
            parameters[50].Value = model.N_PW;
            parameters[51].Value = model.N_LENTH;
            parameters[52].Value = model.C_MATRL_CODE_SLAB;
            parameters[53].Value = model.C_MATRL_NAME_SLAB;
            parameters[54].Value = model.C_SLAB_SIZE;
            parameters[55].Value = model.N_SLAB_LENGTH;
            parameters[56].Value = model.N_SLAB_PW;

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
        public bool Update(Mod_TRP_PLAN_COGDOWN model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TRP_PLAN_COGDOWN set ");
            strSql.Append("N_STATUS=:N_STATUS,");
            strSql.Append("C_INITIALIZE_ITEM_ID=:C_INITIALIZE_ITEM_ID,");
            strSql.Append("C_ORDER_NO=:C_ORDER_NO,");
            strSql.Append("N_WGT=:N_WGT,");
            strSql.Append("C_MAT_CODE=:C_MAT_CODE,");
            strSql.Append("C_MAT_NAME=:C_MAT_NAME,");
            strSql.Append("C_TECH_PROT=:C_TECH_PROT,");
            strSql.Append("C_SPEC=:C_SPEC,");
            strSql.Append("C_STL_GRD=:C_STL_GRD,");
            strSql.Append("C_STD_CODE=:C_STD_CODE,");
            strSql.Append("N_USER_LEV=:N_USER_LEV,");
            strSql.Append("N_STL_GRD_LEV=:N_STL_GRD_LEV,");
            strSql.Append("N_ORDER_LEV=:N_ORDER_LEV,");
            strSql.Append("C_QUALIRY_LEV=:C_QUALIRY_LEV,");
            strSql.Append("D_NEED_DT=:D_NEED_DT,");
            strSql.Append("D_DELIVERY_DT=:D_DELIVERY_DT,");
            strSql.Append("D_DT=:D_DT,");
            strSql.Append("C_LINE_DESC=:C_LINE_DESC,");
            strSql.Append("C_LINE_CODE=:C_LINE_CODE,");
            strSql.Append("D_P_START_TIME=:D_P_START_TIME,");
            strSql.Append("D_P_END_TIME=:D_P_END_TIME,");
            strSql.Append("N_PROD_TIME=:N_PROD_TIME,");
            strSql.Append("N_SORT=:N_SORT,");
            strSql.Append("N_ROLL_PROD_WGT=:N_ROLL_PROD_WGT,");
            strSql.Append("C_ROLL_PROD_EMP_ID=:C_ROLL_PROD_EMP_ID,");
            strSql.Append("C_STL_ROL_DT=:C_STL_ROL_DT,");
            strSql.Append("N_PROD_WGT=:N_PROD_WGT,");
            strSql.Append("N_WARE_WGT=:N_WARE_WGT,");
            strSql.Append("N_WARE_OUT_WGT=:N_WARE_OUT_WGT,");
            strSql.Append("N_FLAG=:N_FLAG,");
            strSql.Append("N_ISSUE_WGT=:N_ISSUE_WGT,");
            strSql.Append("C_CUST_NO=:C_CUST_NO,");
            strSql.Append("C_CUST_NAME=:C_CUST_NAME,");
            strSql.Append("C_SALE_CHANNEL=:C_SALE_CHANNEL,");
            strSql.Append("C_PACK=:C_PACK,");
            strSql.Append("C_DESIGN_NO=:C_DESIGN_NO,");
            strSql.Append("N_GROUP_WGT=:N_GROUP_WGT,");
            strSql.Append("C_STA_ID=:C_STA_ID,");
            strSql.Append("D_START_TIME=:D_START_TIME,");
            strSql.Append("D_END_TIME=:D_END_TIME,");
            strSql.Append("C_EMP_ID=:C_EMP_ID,");
            strSql.Append("D_MOD_DT=:D_MOD_DT,");
            strSql.Append("N_ROLL_WGT=:N_ROLL_WGT,");
            strSql.Append("N_MACH_WGT=:N_MACH_WGT,");
            strSql.Append("C_CAST_NO=:C_CAST_NO,");
            strSql.Append("C_INITIALIZE_ID=:C_INITIALIZE_ID,");
            strSql.Append("N_UPLOADSTATUS=:N_UPLOADSTATUS,");
            strSql.Append("C_FREE1=:C_FREE1,");
            strSql.Append("C_FREE2=:C_FREE2,");
            strSql.Append("N_PW=:N_PW,");
            strSql.Append("N_LENTH=:N_LENTH,");
            strSql.Append("C_MATRL_CODE_SLAB=:C_MATRL_CODE_SLAB,");
            strSql.Append("C_MATRL_NAME_SLAB=:C_MATRL_NAME_SLAB,");
            strSql.Append("C_SLAB_SIZE=:C_SLAB_SIZE,");
            strSql.Append("N_SLAB_LENGTH=:N_SLAB_LENGTH,");
            strSql.Append("N_SLAB_PW=:N_SLAB_PW");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
                    new OracleParameter(":C_INITIALIZE_ITEM_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ORDER_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":C_MAT_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MAT_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_TECH_PROT", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SPEC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STL_GRD", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STD_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_USER_LEV", OracleDbType.Decimal,5),
                    new OracleParameter(":N_STL_GRD_LEV", OracleDbType.Decimal,5),
                    new OracleParameter(":N_ORDER_LEV", OracleDbType.Decimal,5),
                    new OracleParameter(":C_QUALIRY_LEV", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_NEED_DT", OracleDbType.Date),
                    new OracleParameter(":D_DELIVERY_DT", OracleDbType.Date),
                    new OracleParameter(":D_DT", OracleDbType.Date),
                    new OracleParameter(":C_LINE_DESC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_LINE_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_P_START_TIME", OracleDbType.Date),
                    new OracleParameter(":D_P_END_TIME", OracleDbType.Date),
                    new OracleParameter(":N_PROD_TIME", OracleDbType.Decimal,5),
                    new OracleParameter(":N_SORT", OracleDbType.Decimal,5),
                    new OracleParameter(":N_ROLL_PROD_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":C_ROLL_PROD_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STL_ROL_DT", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_PROD_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":N_WARE_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":N_WARE_OUT_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":N_FLAG", OracleDbType.Decimal,5),
                    new OracleParameter(":N_ISSUE_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":C_CUST_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CUST_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SALE_CHANNEL", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PACK", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_DESIGN_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_GROUP_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":C_STA_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_START_TIME", OracleDbType.Date),
                    new OracleParameter(":D_END_TIME", OracleDbType.Date),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":N_ROLL_WGT", OracleDbType.Decimal,5),
                    new OracleParameter(":N_MACH_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":C_CAST_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_INITIALIZE_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_UPLOADSTATUS", OracleDbType.Decimal,1),
                    new OracleParameter(":C_FREE1", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_FREE2", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_PW", OracleDbType.Decimal,15),
                    new OracleParameter(":N_LENTH", OracleDbType.Decimal,15),
                    new OracleParameter(":C_MATRL_CODE_SLAB", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MATRL_NAME_SLAB", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SLAB_SIZE", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_SLAB_LENGTH", OracleDbType.Decimal,15),
                    new OracleParameter(":N_SLAB_PW", OracleDbType.Decimal,15),
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.N_STATUS;
            parameters[1].Value = model.C_INITIALIZE_ITEM_ID;
            parameters[2].Value = model.C_ORDER_NO;
            parameters[3].Value = model.N_WGT;
            parameters[4].Value = model.C_MAT_CODE;
            parameters[5].Value = model.C_MAT_NAME;
            parameters[6].Value = model.C_TECH_PROT;
            parameters[7].Value = model.C_SPEC;
            parameters[8].Value = model.C_STL_GRD;
            parameters[9].Value = model.C_STD_CODE;
            parameters[10].Value = model.N_USER_LEV;
            parameters[11].Value = model.N_STL_GRD_LEV;
            parameters[12].Value = model.N_ORDER_LEV;
            parameters[13].Value = model.C_QUALIRY_LEV;
            parameters[14].Value = model.D_NEED_DT;
            parameters[15].Value = model.D_DELIVERY_DT;
            parameters[16].Value = model.D_DT;
            parameters[17].Value = model.C_LINE_DESC;
            parameters[18].Value = model.C_LINE_CODE;
            parameters[19].Value = model.D_P_START_TIME;
            parameters[20].Value = model.D_P_END_TIME;
            parameters[21].Value = model.N_PROD_TIME;
            parameters[22].Value = model.N_SORT;
            parameters[23].Value = model.N_ROLL_PROD_WGT;
            parameters[24].Value = model.C_ROLL_PROD_EMP_ID;
            parameters[25].Value = model.C_STL_ROL_DT;
            parameters[26].Value = model.N_PROD_WGT;
            parameters[27].Value = model.N_WARE_WGT;
            parameters[28].Value = model.N_WARE_OUT_WGT;
            parameters[29].Value = model.N_FLAG;
            parameters[30].Value = model.N_ISSUE_WGT;
            parameters[31].Value = model.C_CUST_NO;
            parameters[32].Value = model.C_CUST_NAME;
            parameters[33].Value = model.C_SALE_CHANNEL;
            parameters[34].Value = model.C_PACK;
            parameters[35].Value = model.C_DESIGN_NO;
            parameters[36].Value = model.N_GROUP_WGT;
            parameters[37].Value = model.C_STA_ID;
            parameters[38].Value = model.D_START_TIME;
            parameters[39].Value = model.D_END_TIME;
            parameters[40].Value = model.C_EMP_ID;
            parameters[41].Value = model.D_MOD_DT;
            parameters[42].Value = model.N_ROLL_WGT;
            parameters[43].Value = model.N_MACH_WGT;
            parameters[44].Value = model.C_CAST_NO;
            parameters[45].Value = model.C_INITIALIZE_ID;
            parameters[46].Value = model.N_UPLOADSTATUS;
            parameters[47].Value = model.C_FREE1;
            parameters[48].Value = model.C_FREE2;
            parameters[49].Value = model.N_PW;
            parameters[50].Value = model.N_LENTH;
            parameters[51].Value = model.C_MATRL_CODE_SLAB;
            parameters[52].Value = model.C_MATRL_NAME_SLAB;
            parameters[53].Value = model.C_SLAB_SIZE;
            parameters[54].Value = model.N_SLAB_LENGTH;
            parameters[55].Value = model.N_SLAB_PW;
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

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from TRP_PLAN_COGDOWN ");
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
            strSql.Append("delete from TRP_PLAN_COGDOWN ");
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
        public Mod_TRP_PLAN_COGDOWN GetModel(string C_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from TRP_PLAN_COGDOWN ");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)            };
            parameters[0].Value = C_ID;

            Mod_TRP_PLAN_COGDOWN model = new Mod_TRP_PLAN_COGDOWN();
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
        public Mod_TRP_PLAN_COGDOWN DataRowToModel(DataRow row)
        {
            Mod_TRP_PLAN_COGDOWN model = new Mod_TRP_PLAN_COGDOWN();
            if (row != null)
            {
                if (row["C_ID"] != null)
                {
                    model.C_ID = row["C_ID"].ToString();
                }
                if (row["N_STATUS"] != null && row["N_STATUS"].ToString() != "")
                {
                    model.N_STATUS = decimal.Parse(row["N_STATUS"].ToString());
                }
                if (row["C_INITIALIZE_ITEM_ID"] != null)
                {
                    model.C_INITIALIZE_ITEM_ID = row["C_INITIALIZE_ITEM_ID"].ToString();
                }
                if (row["C_ORDER_NO"] != null)
                {
                    model.C_ORDER_NO = row["C_ORDER_NO"].ToString();
                }
                if (row["N_WGT"] != null && row["N_WGT"].ToString() != "")
                {
                    model.N_WGT = decimal.Parse(row["N_WGT"].ToString());
                }
                if (row["C_MAT_CODE"] != null)
                {
                    model.C_MAT_CODE = row["C_MAT_CODE"].ToString();
                }
                if (row["C_MAT_NAME"] != null)
                {
                    model.C_MAT_NAME = row["C_MAT_NAME"].ToString();
                }
                if (row["C_TECH_PROT"] != null)
                {
                    model.C_TECH_PROT = row["C_TECH_PROT"].ToString();
                }
                if (row["C_SPEC"] != null)
                {
                    model.C_SPEC = row["C_SPEC"].ToString();
                }
                if (row["C_STL_GRD"] != null)
                {
                    model.C_STL_GRD = row["C_STL_GRD"].ToString();
                }
                if (row["C_STD_CODE"] != null)
                {
                    model.C_STD_CODE = row["C_STD_CODE"].ToString();
                }
                if (row["N_USER_LEV"] != null && row["N_USER_LEV"].ToString() != "")
                {
                    model.N_USER_LEV = decimal.Parse(row["N_USER_LEV"].ToString());
                }
                if (row["N_STL_GRD_LEV"] != null && row["N_STL_GRD_LEV"].ToString() != "")
                {
                    model.N_STL_GRD_LEV = decimal.Parse(row["N_STL_GRD_LEV"].ToString());
                }
                if (row["N_ORDER_LEV"] != null && row["N_ORDER_LEV"].ToString() != "")
                {
                    model.N_ORDER_LEV = decimal.Parse(row["N_ORDER_LEV"].ToString());
                }
                if (row["C_QUALIRY_LEV"] != null)
                {
                    model.C_QUALIRY_LEV = row["C_QUALIRY_LEV"].ToString();
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
                if (row["C_LINE_DESC"] != null)
                {
                    model.C_LINE_DESC = row["C_LINE_DESC"].ToString();
                }
                if (row["C_LINE_CODE"] != null)
                {
                    model.C_LINE_CODE = row["C_LINE_CODE"].ToString();
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
                if (row["N_ROLL_PROD_WGT"] != null && row["N_ROLL_PROD_WGT"].ToString() != "")
                {
                    model.N_ROLL_PROD_WGT = decimal.Parse(row["N_ROLL_PROD_WGT"].ToString());
                }
                if (row["C_ROLL_PROD_EMP_ID"] != null)
                {
                    model.C_ROLL_PROD_EMP_ID = row["C_ROLL_PROD_EMP_ID"].ToString();
                }
                if (row["C_STL_ROL_DT"] != null)
                {
                    model.C_STL_ROL_DT = row["C_STL_ROL_DT"].ToString();
                }
                if (row["N_PROD_WGT"] != null && row["N_PROD_WGT"].ToString() != "")
                {
                    model.N_PROD_WGT = decimal.Parse(row["N_PROD_WGT"].ToString());
                }
                if (row["N_WARE_WGT"] != null && row["N_WARE_WGT"].ToString() != "")
                {
                    model.N_WARE_WGT = decimal.Parse(row["N_WARE_WGT"].ToString());
                }
                if (row["N_WARE_OUT_WGT"] != null && row["N_WARE_OUT_WGT"].ToString() != "")
                {
                    model.N_WARE_OUT_WGT = decimal.Parse(row["N_WARE_OUT_WGT"].ToString());
                }
                if (row["N_FLAG"] != null && row["N_FLAG"].ToString() != "")
                {
                    model.N_FLAG = decimal.Parse(row["N_FLAG"].ToString());
                }
                if (row["N_ISSUE_WGT"] != null && row["N_ISSUE_WGT"].ToString() != "")
                {
                    model.N_ISSUE_WGT = decimal.Parse(row["N_ISSUE_WGT"].ToString());
                }
                if (row["C_CUST_NO"] != null)
                {
                    model.C_CUST_NO = row["C_CUST_NO"].ToString();
                }
                if (row["C_CUST_NAME"] != null)
                {
                    model.C_CUST_NAME = row["C_CUST_NAME"].ToString();
                }
                if (row["C_SALE_CHANNEL"] != null)
                {
                    model.C_SALE_CHANNEL = row["C_SALE_CHANNEL"].ToString();
                }
                if (row["C_PACK"] != null)
                {
                    model.C_PACK = row["C_PACK"].ToString();
                }
                if (row["C_DESIGN_NO"] != null)
                {
                    model.C_DESIGN_NO = row["C_DESIGN_NO"].ToString();
                }
                if (row["N_GROUP_WGT"] != null && row["N_GROUP_WGT"].ToString() != "")
                {
                    model.N_GROUP_WGT = decimal.Parse(row["N_GROUP_WGT"].ToString());
                }
                if (row["C_STA_ID"] != null)
                {
                    model.C_STA_ID = row["C_STA_ID"].ToString();
                }
                if (row["D_START_TIME"] != null && row["D_START_TIME"].ToString() != "")
                {
                    model.D_START_TIME = DateTime.Parse(row["D_START_TIME"].ToString());
                }
                if (row["D_END_TIME"] != null && row["D_END_TIME"].ToString() != "")
                {
                    model.D_END_TIME = DateTime.Parse(row["D_END_TIME"].ToString());
                }
                if (row["C_EMP_ID"] != null)
                {
                    model.C_EMP_ID = row["C_EMP_ID"].ToString();
                }
                if (row["D_MOD_DT"] != null && row["D_MOD_DT"].ToString() != "")
                {
                    model.D_MOD_DT = DateTime.Parse(row["D_MOD_DT"].ToString());
                }
                if (row["N_ROLL_WGT"] != null && row["N_ROLL_WGT"].ToString() != "")
                {
                    model.N_ROLL_WGT = decimal.Parse(row["N_ROLL_WGT"].ToString());
                }
                if (row["N_MACH_WGT"] != null && row["N_MACH_WGT"].ToString() != "")
                {
                    model.N_MACH_WGT = decimal.Parse(row["N_MACH_WGT"].ToString());
                }
                if (row["C_CAST_NO"] != null)
                {
                    model.C_CAST_NO = row["C_CAST_NO"].ToString();
                }
                if (row["C_INITIALIZE_ID"] != null)
                {
                    model.C_INITIALIZE_ID = row["C_INITIALIZE_ID"].ToString();
                }
                if (row["N_UPLOADSTATUS"] != null && row["N_UPLOADSTATUS"].ToString() != "")
                {
                    model.N_UPLOADSTATUS = decimal.Parse(row["N_UPLOADSTATUS"].ToString());
                }
                if (row["C_FREE1"] != null)
                {
                    model.C_FREE1 = row["C_FREE1"].ToString();
                }
                if (row["C_FREE2"] != null)
                {
                    model.C_FREE2 = row["C_FREE2"].ToString();
                }
                if (row["N_PW"] != null && row["N_PW"].ToString() != "")
                {
                    model.N_PW = decimal.Parse(row["N_PW"].ToString());
                }
                if (row["N_LENTH"] != null && row["N_LENTH"].ToString() != "")
                {
                    model.N_LENTH = decimal.Parse(row["N_LENTH"].ToString());
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
            }
            return model;
        }



        /// <summary>
        /// 查询下发的开坯计划
        /// </summary>
        /// <param name="C_STA_ID">开坯工位主键</param>
        /// <param name="N_STATUS">状态</param>
        /// <param name="flag">是否组坯</param>
        /// <returns>开坯计划</returns>
        public DataSet GetList(string C_STA_ID, int N_STATUS, bool flag)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(@"select T.* from TRP_PLAN_COGDOWN t where C_STA_ID='" + C_STA_ID + "'");
            strSql.Append(" AND N_STATUS=" + N_STATUS);
            if (flag)
            {
                strSql.Append(" AND N_GROUP_WGT>0");
            }
            else
            {
                strSql.Append(" AND N_GROUP_WGT=0");
            }
            strSql.Append(" ORDER BY N_SORT, D_P_START_TIME ");
            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 查询下发的开坯计划
        /// </summary>
        /// <param name="C_STA_ID">开坯工位主键</param>
        /// <param name="N_STATUS">状态</param>
        /// <param name="flag">是否组坯</param>
        /// <param name="strStove">炉号</param>
        /// <returns>开坯计划</returns>
        public DataSet GetList(string C_STA_ID, int N_STATUS, bool flag, string strStove, string C_STL_GRD, string C_STD_CODE)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(@"select T.* from TRP_PLAN_COGDOWN t where C_STA_ID='" + C_STA_ID + "'");
            strSql.Append(" AND N_STATUS=" + N_STATUS);
            if (flag)
            {
                strSql.Append(" AND N_GROUP_WGT>0");
            }
            else
            {
                strSql.Append(" AND N_GROUP_WGT=0");
            }

            if (!string.IsNullOrEmpty(strStove))
            {
                strSql.Append(" AND t.C_CAST_NO like '%" + strStove + "%' ");
            }

            if (!string.IsNullOrEmpty(C_STL_GRD))
            {
                strSql.Append(" AND t.C_STL_GRD like '%" + C_STL_GRD + "%' ");
            }

            if (!string.IsNullOrEmpty(C_STD_CODE))
            {
                strSql.Append(" AND t.C_STD_CODE like '%" + C_STD_CODE + "%' ");
            }

            strSql.Append(" ORDER BY N_SORT, D_P_START_TIME ");
            return DbHelperOra.Query(strSql.ToString());
        }

        ///// <summary>
        ///// 撤回开坯计划
        ///// </summary>
        ///// <param name="C_ID"></param>
        //public void BackPlan(string C_ID)
        //{
        //    string sql = "select * from TRP_PLAN_COGDOWN t where t.C_ID='"+C_ID+ "' AND T.N_STATUS=1 AND T.N_GROUP_WGT=0 ";
        //    DATAT DbHelperOra.Query(sql.ToString());

        //}

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(@"SELECT TPC.C_ID,
                                         TPC.N_STATUS,
                                         ( SELECT TTT.C_ORDER_NO FROM TMO_ORDER TTT WHERE TTT.C_ID=  ( SELECT TT.C_ORDER_NO FROM TSP_PLAN_SMS TT WHERE TT.C_ID=TPC.C_ORDER_NO ) ) ORDER_NO,
                                         TPC.C_INITIALIZE_ITEM_ID,
                                         TPC.C_ORDER_NO,
                                         TPC.N_WGT,
                                         TPC.C_MAT_CODE,
                                         TPC.C_MAT_NAME,
                                         TPC.C_TECH_PROT,
                                         TPC.C_SPEC,
                                         TPC.C_STL_GRD,
                                         TPC.C_STD_CODE,
                                         TPC.N_USER_LEV,
                                         TPC.N_STL_GRD_LEV,
                                         TPC.N_ORDER_LEV,
                                         TPC.C_QUALIRY_LEV,
                                         TPC.D_NEED_DT,
                                         TPC.D_DELIVERY_DT,
                                         TPC.D_DT,
                                         TPC.C_LINE_DESC,
                                         TPC.C_LINE_CODE,
                                         TPC.D_P_START_TIME,
                                         TPC.D_P_END_TIME,
                                         TPC.N_PROD_TIME,
                                         TPC.N_SORT,
                                         TPC.N_ROLL_PROD_WGT,
                                         TPC.C_ROLL_PROD_EMP_ID,
                                         TPC.C_STL_ROL_DT,
                                         TPC.N_PROD_WGT,
                                         TPC.N_WARE_WGT,
                                         TPC.N_WARE_OUT_WGT,
                                         TPC.N_FLAG,
                                         TPC.N_ISSUE_WGT,
                                         TPC.C_CUST_NO,
                                         TPC.C_CUST_NAME,
                                         TPC.C_SALE_CHANNEL,
                                         TPC.C_PACK,
                                         TPC.C_DESIGN_NO,
                                         TPC.N_GROUP_WGT,
                                         TPC.C_STA_ID,
                                         TPC.D_START_TIME,
                                         TPC.D_END_TIME,
                                         TPC.C_EMP_ID,
                                         TPC.D_MOD_DT,
                                         TPC.N_ROLL_WGT,
                                         TPC.N_MACH_WGT,
                                         TPC.C_CAST_NO,
                                         TPC.C_INITIALIZE_ID,
                                         TPC.C_FREE1,
                                         TPC.C_FREE2,
                                          TPC.N_PW,
                                           TPC.N_LENTH,     
                                         TPC.C_SLAB_SIZE,
                                         TPC.N_SLAB_LENGTH,
                                        TPC.N_SLAB_PW,
                                        TPC.C_MATRL_CODE_SLAB,
                                        floor(TPC.N_WGT/4) S
                                     FROM TRP_PLAN_COGDOWN TPC ");

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
            strSql.Append("select count(1) FROM TRP_PLAN_COGDOWN ");
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
            strSql.Append(")AS Row, T.*  from TRP_PLAN_COGDOWN T ");
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
        /// 修改组批量
        /// </summary>
        /// <returns></returns>
        public int UpdateGroupWgt(string id, decimal wgt)
        {
            string sql = @"UPDATE TRP_PLAN_COGDOWN TPR
                                    SET TPR.N_GROUP_WGT=TPR.N_GROUP_WGT+:wgt
                                    WHERE TPR.C_ID=:id    ";

            OracleParameter[] parameters = {
                    new OracleParameter(":wgt", OracleDbType.Decimal,5),
                    new OracleParameter(":id", OracleDbType.Varchar2,100),
            };
            parameters[0].Value = wgt;
            parameters[1].Value = id;

            return TransactionHelper.ExecuteSql(sql, parameters);
        }

        /// <summary>
        /// 修改组批量(撤回)
        /// </summary>
        /// <returns></returns>
        public int BackOutGroupWgt(string id, decimal wgt)
        {
            string sql = @"UPDATE TRP_PLAN_COGDOWN TPR
                                    SET  TPR.N_GROUP_WGT=TPR.N_GROUP_WGT-:wgt
                                    WHERE TPR.C_ID=:id";

            OracleParameter[] parameters = {
                    new OracleParameter(":wgt", OracleDbType.Decimal,5),
                    new OracleParameter(":id", OracleDbType.Varchar2,100),
            };
            parameters[0].Value = wgt;
            parameters[1].Value = id;

            string sql2 = @"UPDATE TRP_PLAN_COGDOWN T SET T.N_GROUP_WGT = 0 WHERE T.C_ID = '" + id + "' AND T.N_GROUP_WGT < 0";
            TransactionHelper.ExecuteSql(sql2);

            return TransactionHelper.ExecuteSql(sql, parameters);
        }

        /// <summary>
        /// 计划完成
        /// </summary>
        /// <returns></returns>
        public int AccomplishPlan(string planID, int status)
        {
            int result = 0;
            var model = GetModel(planID);
            decimal? wgt = model.N_WGT;
            decimal? groupWgt = model.N_GROUP_WGT;
            if (wgt != null && groupWgt != null)
            {
                if (groupWgt >= wgt)
                {
                    string sql = "UPDATE TRP_PLAN_COGDOWN TPC  SET TPC.N_STATUS =" + status + "  WHERE TPC.C_ID = '" + planID + "' ";
                    result = DbHelperOra.ExecuteSql(sql);
                }
            }
            return result;
        }


        /// <summary>
        /// 计划未完成
        /// </summary>
        /// <returns></returns>
        public int UnAccomplishPlan(string planID, int status)
        {
            int result = 0;
            var model = GetModel(planID);
            decimal? wgt = model.N_WGT;
            decimal? groupWgt = model.N_GROUP_WGT;
            if (wgt != null && groupWgt != null)
            {
                if (groupWgt < wgt)
                {
                    string sql = "UPDATE TRP_PLAN_COGDOWN TPC  SET TPC.N_STATUS =" + status + "  WHERE TPC.C_ID = '" + planID + "' ";
                    result = DbHelperOra.ExecuteSql(sql);
                }
            }
            return result;
        }


        /// <summary>
        /// 获取生产顺序
        /// </summary>
        public int Get_Max_Sort()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select max(t.n_sort) FROM TRP_PLAN_COGDOWN t ");

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
    }
}
