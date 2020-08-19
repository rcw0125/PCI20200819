using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;
namespace DAL
{
    /// <summary>
    /// 数据访问类:TPC_PLAN_ROLL
    /// </summary>
    public partial class Dal_TPC_PLAN_ROLL
    {
        public Dal_TPC_PLAN_ROLL()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string C_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TPC_PLAN_ROLL");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)         };
            parameters[0].Value = C_ID;

            return DbHelperOra.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Mod_TPC_PLAN_ROLL model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TPC_PLAN_ROLL(");
            strSql.Append("C_ID,N_STATUS,C_ORDER_ID,C_ORDER_NO,N_WGT,C_MAT_CODE,C_MAT_NAME,C_SPEC,C_STL_GRD,C_STD_CODE,N_USER_LEV,N_STL_GRD_LEV,C_ORDER_LEV,C_QUALIRY_LEV,D_NEED_DT,D_DELIVERY_DT,D_DT,C_LINE_DESC,C_LINE_CODE,D_P_START_TIME,D_P_END_TIME,N_PROD_TIME,N_SORT,N_ROLL_PROD_WGT,C_ROLL_PROD_EMP_ID,C_STL_ROL_DT,C_CUST_NO,C_CUST_NAME,C_PACK,C_DESIGN_NO,C_LINT_ID,D_START_TIME,D_END_TIME,C_EMP_ID,D_MOD_DT,N_MACH_WGT,C_FREE_TERM,C_FREE_TERM2,C_AREA,C_PCLX,C_RH,C_LF,C_KP,N_HL_TIME,C_HL,N_DFP_HL_TIME,C_DFP_HL,C_XM,C_ROUTE,N_DIAMETER,C_XM_YQ,N_JRL_WD,N_JRL_SJ)");
            strSql.Append(" values (");
            strSql.Append(":C_ID,:N_STATUS,:C_ORDER_ID,:C_ORDER_NO,:N_WGT,:C_MAT_CODE,:C_MAT_NAME,:C_SPEC,:C_STL_GRD,:C_STD_CODE,:N_USER_LEV,:N_STL_GRD_LEV,:C_ORDER_LEV,:C_QUALIRY_LEV,:D_NEED_DT,:D_DELIVERY_DT,:D_DT,:C_LINE_DESC,:C_LINE_CODE,:D_P_START_TIME,:D_P_END_TIME,:N_PROD_TIME,:N_SORT,:N_ROLL_PROD_WGT,:C_ROLL_PROD_EMP_ID,:C_STL_ROL_DT,:C_CUST_NO,:C_CUST_NAME,:C_PACK,:C_DESIGN_NO,:C_LINT_ID,:D_START_TIME,:D_END_TIME,:C_EMP_ID,:D_MOD_DT,:N_MACH_WGT,:C_FREE_TERM,:C_FREE_TERM2,:C_AREA,:C_PCLX,:C_RH,:C_LF,:C_KP,:N_HL_TIME,:C_HL,:N_DFP_HL_TIME,:C_DFP_HL,:C_XM,:C_ROUTE,:N_DIAMETER,:C_XM_YQ,:N_JRL_WD,:N_JRL_SJ)");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
                    new OracleParameter(":C_ORDER_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ORDER_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":C_MAT_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MAT_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SPEC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STL_GRD", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STD_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_USER_LEV", OracleDbType.Decimal,5),
                    new OracleParameter(":N_STL_GRD_LEV", OracleDbType.Decimal,5),
                    new OracleParameter(":C_ORDER_LEV", OracleDbType.Varchar2,100),
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
                    new OracleParameter(":N_ROLL_PROD_WGT", OracleDbType.Decimal,5),
                    new OracleParameter(":C_ROLL_PROD_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STL_ROL_DT", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CUST_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CUST_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PACK", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_DESIGN_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_LINT_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_START_TIME", OracleDbType.Date),
                    new OracleParameter(":D_END_TIME", OracleDbType.Date),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":N_MACH_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":C_FREE_TERM", OracleDbType.Varchar2,300),
                    new OracleParameter(":C_FREE_TERM2", OracleDbType.Varchar2,300),
                    new OracleParameter(":C_AREA", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PCLX", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_RH", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_LF", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_KP", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_HL_TIME", OracleDbType.Decimal,10),
                    new OracleParameter(":C_HL", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_DFP_HL_TIME", OracleDbType.Decimal,10),
                    new OracleParameter(":C_DFP_HL", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_XM", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_ROUTE", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_DIAMETER", OracleDbType.Decimal,4),
                    new OracleParameter(":C_XM_YQ", OracleDbType.Varchar2,1000),
                    new OracleParameter(":N_JRL_WD", OracleDbType.Decimal,10),
                    new OracleParameter(":N_JRL_SJ", OracleDbType.Decimal,10)};
            parameters[0].Value = model.C_ID;
            parameters[1].Value = model.N_STATUS;
            parameters[2].Value = model.C_ORDER_ID;
            parameters[3].Value = model.C_ORDER_NO;
            parameters[4].Value = model.N_WGT;
            parameters[5].Value = model.C_MAT_CODE;
            parameters[6].Value = model.C_MAT_NAME;
            parameters[7].Value = model.C_SPEC;
            parameters[8].Value = model.C_STL_GRD;
            parameters[9].Value = model.C_STD_CODE;
            parameters[10].Value = model.N_USER_LEV;
            parameters[11].Value = model.N_STL_GRD_LEV;
            parameters[12].Value = model.C_ORDER_LEV;
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
            parameters[26].Value = model.C_CUST_NO;
            parameters[27].Value = model.C_CUST_NAME;
            parameters[28].Value = model.C_PACK;
            parameters[29].Value = model.C_DESIGN_NO;
            parameters[30].Value = model.C_LINT_ID;
            parameters[31].Value = model.D_START_TIME;
            parameters[32].Value = model.D_END_TIME;
            parameters[33].Value = model.C_EMP_ID;
            parameters[34].Value = model.D_MOD_DT;
            parameters[35].Value = model.N_MACH_WGT;
            parameters[36].Value = model.C_FREE_TERM;
            parameters[37].Value = model.C_FREE_TERM2;
            parameters[38].Value = model.C_AREA;
            parameters[39].Value = model.C_PCLX;
            parameters[40].Value = model.C_RH;
            parameters[41].Value = model.C_LF;
            parameters[42].Value = model.C_KP;
            parameters[43].Value = model.N_HL_TIME;
            parameters[44].Value = model.C_HL;
            parameters[45].Value = model.N_DFP_HL_TIME;
            parameters[46].Value = model.C_DFP_HL;
            parameters[47].Value = model.C_XM;
            parameters[48].Value = model.C_ROUTE;
            parameters[49].Value = model.N_DIAMETER;
            parameters[50].Value = model.C_XM_YQ;
            parameters[51].Value = model.N_JRL_WD;
            parameters[52].Value = model.N_JRL_SJ;

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
        public bool Update(Mod_TPC_PLAN_ROLL model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TPC_PLAN_ROLL set ");
            strSql.Append("N_STATUS=:N_STATUS,");
            strSql.Append("C_ORDER_ID=:C_ORDER_ID,");
            strSql.Append("C_ORDER_NO=:C_ORDER_NO,");
            strSql.Append("N_WGT=:N_WGT,");
            strSql.Append("C_MAT_CODE=:C_MAT_CODE,");
            strSql.Append("C_MAT_NAME=:C_MAT_NAME,");
            strSql.Append("C_SPEC=:C_SPEC,");
            strSql.Append("C_STL_GRD=:C_STL_GRD,");
            strSql.Append("C_STD_CODE=:C_STD_CODE,");
            strSql.Append("N_USER_LEV=:N_USER_LEV,");
            strSql.Append("N_STL_GRD_LEV=:N_STL_GRD_LEV,");
            strSql.Append("C_ORDER_LEV=:C_ORDER_LEV,");
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
            strSql.Append("C_CUST_NO=:C_CUST_NO,");
            strSql.Append("C_CUST_NAME=:C_CUST_NAME,");
            strSql.Append("C_PACK=:C_PACK,");
            strSql.Append("C_DESIGN_NO=:C_DESIGN_NO,");
            strSql.Append("C_LINT_ID=:C_LINT_ID,");
            strSql.Append("D_START_TIME=:D_START_TIME,");
            strSql.Append("D_END_TIME=:D_END_TIME,");
            strSql.Append("C_EMP_ID=:C_EMP_ID,");
            strSql.Append("D_MOD_DT=:D_MOD_DT,");
            strSql.Append("N_MACH_WGT=:N_MACH_WGT,");
            strSql.Append("C_FREE_TERM=:C_FREE_TERM,");
            strSql.Append("C_FREE_TERM2=:C_FREE_TERM2,");
            strSql.Append("C_AREA=:C_AREA,");
            strSql.Append("C_PCLX=:C_PCLX,");
            strSql.Append("C_RH=:C_RH,");
            strSql.Append("C_LF=:C_LF,");
            strSql.Append("C_KP=:C_KP,");
            strSql.Append("N_HL_TIME=:N_HL_TIME,");
            strSql.Append("C_HL=:C_HL,");
            strSql.Append("N_DFP_HL_TIME=:N_DFP_HL_TIME,");
            strSql.Append("C_DFP_HL=:C_DFP_HL,");
            strSql.Append("C_XM=:C_XM,");
            strSql.Append("C_ROUTE=:C_ROUTE,");
            strSql.Append("N_DIAMETER=:N_DIAMETER,");
            strSql.Append("C_XM_YQ=:C_XM_YQ,");
            strSql.Append("N_JRL_WD=:N_JRL_WD,");
            strSql.Append("N_JRL_SJ=:N_JRL_SJ");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
                    new OracleParameter(":C_ORDER_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ORDER_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":C_MAT_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MAT_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SPEC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STL_GRD", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STD_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_USER_LEV", OracleDbType.Decimal,5),
                    new OracleParameter(":N_STL_GRD_LEV", OracleDbType.Decimal,5),
                    new OracleParameter(":C_ORDER_LEV", OracleDbType.Varchar2,100),
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
                    new OracleParameter(":N_ROLL_PROD_WGT", OracleDbType.Decimal,5),
                    new OracleParameter(":C_ROLL_PROD_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STL_ROL_DT", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CUST_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CUST_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PACK", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_DESIGN_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_LINT_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_START_TIME", OracleDbType.Date),
                    new OracleParameter(":D_END_TIME", OracleDbType.Date),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":N_MACH_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":C_FREE_TERM", OracleDbType.Varchar2,300),
                    new OracleParameter(":C_FREE_TERM2", OracleDbType.Varchar2,300),
                    new OracleParameter(":C_AREA", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PCLX", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_RH", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_LF", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_KP", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_HL_TIME", OracleDbType.Decimal,10),
                    new OracleParameter(":C_HL", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_DFP_HL_TIME", OracleDbType.Decimal,10),
                    new OracleParameter(":C_DFP_HL", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_XM", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_ROUTE", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_DIAMETER", OracleDbType.Decimal,4),
                    new OracleParameter(":C_XM_YQ", OracleDbType.Varchar2,1000),
                    new OracleParameter(":N_JRL_WD", OracleDbType.Decimal,10),
                    new OracleParameter(":N_JRL_SJ", OracleDbType.Decimal,10),
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.N_STATUS;
            parameters[1].Value = model.C_ORDER_ID;
            parameters[2].Value = model.C_ORDER_NO;
            parameters[3].Value = model.N_WGT;
            parameters[4].Value = model.C_MAT_CODE;
            parameters[5].Value = model.C_MAT_NAME;
            parameters[6].Value = model.C_SPEC;
            parameters[7].Value = model.C_STL_GRD;
            parameters[8].Value = model.C_STD_CODE;
            parameters[9].Value = model.N_USER_LEV;
            parameters[10].Value = model.N_STL_GRD_LEV;
            parameters[11].Value = model.C_ORDER_LEV;
            parameters[12].Value = model.C_QUALIRY_LEV;
            parameters[13].Value = model.D_NEED_DT;
            parameters[14].Value = model.D_DELIVERY_DT;
            parameters[15].Value = model.D_DT;
            parameters[16].Value = model.C_LINE_DESC;
            parameters[17].Value = model.C_LINE_CODE;
            parameters[18].Value = model.D_P_START_TIME;
            parameters[19].Value = model.D_P_END_TIME;
            parameters[20].Value = model.N_PROD_TIME;
            parameters[21].Value = model.N_SORT;
            parameters[22].Value = model.N_ROLL_PROD_WGT;
            parameters[23].Value = model.C_ROLL_PROD_EMP_ID;
            parameters[24].Value = model.C_STL_ROL_DT;
            parameters[25].Value = model.C_CUST_NO;
            parameters[26].Value = model.C_CUST_NAME;
            parameters[27].Value = model.C_PACK;
            parameters[28].Value = model.C_DESIGN_NO;
            parameters[29].Value = model.C_LINT_ID;
            parameters[30].Value = model.D_START_TIME;
            parameters[31].Value = model.D_END_TIME;
            parameters[32].Value = model.C_EMP_ID;
            parameters[33].Value = model.D_MOD_DT;
            parameters[34].Value = model.N_MACH_WGT;
            parameters[35].Value = model.C_FREE_TERM;
            parameters[36].Value = model.C_FREE_TERM2;
            parameters[37].Value = model.C_AREA;
            parameters[38].Value = model.C_PCLX;
            parameters[39].Value = model.C_RH;
            parameters[40].Value = model.C_LF;
            parameters[41].Value = model.C_KP;
            parameters[42].Value = model.N_HL_TIME;
            parameters[43].Value = model.C_HL;
            parameters[44].Value = model.N_DFP_HL_TIME;
            parameters[45].Value = model.C_DFP_HL;
            parameters[46].Value = model.C_XM;
            parameters[47].Value = model.C_ROUTE;
            parameters[48].Value = model.N_DIAMETER;
            parameters[49].Value = model.C_XM_YQ;
            parameters[50].Value = model.N_JRL_WD;
            parameters[51].Value = model.N_JRL_SJ;
            parameters[52].Value = model.C_ID;

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
            strSql.Append("delete from TPC_PLAN_ROLL ");
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
            strSql.Append("delete from TPC_PLAN_ROLL ");
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
        public Mod_TPC_PLAN_ROLL GetModel(string C_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,N_STATUS,C_ORDER_ID,C_ORDER_NO,N_WGT,C_MAT_CODE,C_MAT_NAME,C_SPEC,C_STL_GRD,C_STD_CODE,N_USER_LEV,N_STL_GRD_LEV,C_ORDER_LEV,C_QUALIRY_LEV,D_NEED_DT,D_DELIVERY_DT,D_DT,C_LINE_DESC,C_LINE_CODE,D_P_START_TIME,D_P_END_TIME,N_PROD_TIME,N_SORT,N_ROLL_PROD_WGT,C_ROLL_PROD_EMP_ID,C_STL_ROL_DT,C_CUST_NO,C_CUST_NAME,C_PACK,C_DESIGN_NO,C_LINT_ID,D_START_TIME,D_END_TIME,C_EMP_ID,D_MOD_DT,N_MACH_WGT,C_FREE_TERM,C_FREE_TERM2,C_AREA,C_PCLX,C_RH,C_LF,C_KP,N_HL_TIME,C_HL,N_DFP_HL_TIME,C_DFP_HL,C_XM,C_ROUTE,N_DIAMETER,C_XM_YQ,N_JRL_WD,N_JRL_SJ from TPC_PLAN_ROLL ");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)         };
            parameters[0].Value = C_ID;

            Mod_TPC_PLAN_ROLL model = new Mod_TPC_PLAN_ROLL();
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
        public Mod_TPC_PLAN_ROLL DataRowToModel(DataRow row)
        {
            Mod_TPC_PLAN_ROLL model = new Mod_TPC_PLAN_ROLL();
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
                if (row["C_ORDER_ID"] != null)
                {
                    model.C_ORDER_ID = row["C_ORDER_ID"].ToString();
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
                if (row["C_ORDER_LEV"] != null)
                {
                    model.C_ORDER_LEV = row["C_ORDER_LEV"].ToString();
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
                if (row["C_CUST_NO"] != null)
                {
                    model.C_CUST_NO = row["C_CUST_NO"].ToString();
                }
                if (row["C_CUST_NAME"] != null)
                {
                    model.C_CUST_NAME = row["C_CUST_NAME"].ToString();
                }
                if (row["C_PACK"] != null)
                {
                    model.C_PACK = row["C_PACK"].ToString();
                }
                if (row["C_DESIGN_NO"] != null)
                {
                    model.C_DESIGN_NO = row["C_DESIGN_NO"].ToString();
                }
                if (row["C_LINT_ID"] != null)
                {
                    model.C_LINT_ID = row["C_LINT_ID"].ToString();
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
                if (row["N_MACH_WGT"] != null && row["N_MACH_WGT"].ToString() != "")
                {
                    model.N_MACH_WGT = decimal.Parse(row["N_MACH_WGT"].ToString());
                }
                if (row["C_FREE_TERM"] != null)
                {
                    model.C_FREE_TERM = row["C_FREE_TERM"].ToString();
                }
                if (row["C_FREE_TERM2"] != null)
                {
                    model.C_FREE_TERM2 = row["C_FREE_TERM2"].ToString();
                }
                if (row["C_AREA"] != null)
                {
                    model.C_AREA = row["C_AREA"].ToString();
                }
                if (row["C_PCLX"] != null)
                {
                    model.C_PCLX = row["C_PCLX"].ToString();
                }
                if (row["C_RH"] != null)
                {
                    model.C_RH = row["C_RH"].ToString();
                }
                if (row["C_LF"] != null)
                {
                    model.C_LF = row["C_LF"].ToString();
                }
                if (row["C_KP"] != null)
                {
                    model.C_KP = row["C_KP"].ToString();
                }
                if (row["N_HL_TIME"] != null && row["N_HL_TIME"].ToString() != "")
                {
                    model.N_HL_TIME = decimal.Parse(row["N_HL_TIME"].ToString());
                }
                if (row["C_HL"] != null)
                {
                    model.C_HL = row["C_HL"].ToString();
                }
                if (row["N_DFP_HL_TIME"] != null && row["N_DFP_HL_TIME"].ToString() != "")
                {
                    model.N_DFP_HL_TIME = decimal.Parse(row["N_DFP_HL_TIME"].ToString());
                }
                if (row["C_DFP_HL"] != null)
                {
                    model.C_DFP_HL = row["C_DFP_HL"].ToString();
                }
                if (row["C_XM"] != null)
                {
                    model.C_XM = row["C_XM"].ToString();
                }
                if (row["C_ROUTE"] != null)
                {
                    model.C_ROUTE = row["C_ROUTE"].ToString();
                }
                if (row["N_DIAMETER"] != null && row["N_DIAMETER"].ToString() != "")
                {
                    model.N_DIAMETER = decimal.Parse(row["N_DIAMETER"].ToString());
                }
                if (row["C_XM_YQ"] != null)
                {
                    model.C_XM_YQ = row["C_XM_YQ"].ToString();
                }
                if (row["N_JRL_WD"] != null && row["N_JRL_WD"].ToString() != "")
                {
                    model.N_JRL_WD = decimal.Parse(row["N_JRL_WD"].ToString());
                }
                if (row["N_JRL_SJ"] != null && row["N_JRL_SJ"].ToString() != "")
                {
                    model.N_JRL_SJ = decimal.Parse(row["N_JRL_SJ"].ToString());
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
            strSql.Append("select C_ID,N_STATUS,C_ORDER_ID,C_ORDER_NO,N_WGT,C_MAT_CODE,C_MAT_NAME,C_SPEC,C_STL_GRD,C_STD_CODE,N_USER_LEV,N_STL_GRD_LEV,C_ORDER_LEV,C_QUALIRY_LEV,D_NEED_DT,D_DELIVERY_DT,D_DT,C_LINE_DESC,C_LINE_CODE,D_P_START_TIME,D_P_END_TIME,N_PROD_TIME,N_SORT,N_ROLL_PROD_WGT,C_ROLL_PROD_EMP_ID,C_STL_ROL_DT,C_CUST_NO,C_CUST_NAME,C_PACK,C_DESIGN_NO,C_LINT_ID,D_START_TIME,D_END_TIME,C_EMP_ID,D_MOD_DT,N_MACH_WGT,C_FREE_TERM,C_FREE_TERM2,C_AREA,C_PCLX,C_RH,C_LF,C_KP,N_HL_TIME,C_HL,N_DFP_HL_TIME,C_DFP_HL,C_XM,C_ROUTE,N_DIAMETER,C_XM_YQ,N_JRL_WD,N_JRL_SJ ");
            strSql.Append(" FROM TPC_PLAN_ROLL ");
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
            strSql.Append("select count(1) FROM TPC_PLAN_ROLL ");
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


        #endregion  BasicMethod
        #region  ExtensionMethod
        /// <summary>
        /// 查询轧钢计划
        /// </summary>
        /// <param name="C_LINT_ID">产线</param>
        /// <param name="N_STATUS">是否排产</param>
        /// <param name="C_ORDER_NO">订单号</param>
        /// <param name="C_STL_GRD">钢种</param>
        /// <param name="C_STD_CODE">执行标准</param>
        /// <param name="D_SPEC_MIN">规格最小</param>
        /// <param name="D_SPEC_MAX">规格最大</param>
        /// <param name="C_CUST_NAME">客户名称</param>
        /// <param name="C_JQ_MIN">交货日期最小</param>
        /// <param name="C_JQ_MAX">交货日期最大</param>
        /// <param name="C_DD_MIN">订单日期最小</param>
        /// <param name="C_DD_MAX">订单日期最大</param>
        /// <returns>轧钢计划</returns>
        public DataSet GetZGPlan(string C_LINT_ID, int? N_STATUS, string C_ORDER_NO, string C_STL_GRD, string C_STD_CODE, double? D_SPEC_MIN, double? D_SPEC_MAX, string C_CUST_NAME, string C_JQ_MIN, string C_JQ_MAX, string C_DD_MIN, string C_DD_MAX)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,N_STATUS,C_ORDER_ID,C_ORDER_NO,N_WGT,C_MAT_CODE,C_MAT_NAME,C_SPEC,C_STL_GRD,C_STD_CODE,N_USER_LEV,N_STL_GRD_LEV,C_ORDER_LEV,C_QUALIRY_LEV,D_NEED_DT,D_DELIVERY_DT,D_DT,C_LINE_DESC,C_LINE_CODE,D_P_START_TIME,D_P_END_TIME,N_PROD_TIME,N_SORT,N_ROLL_PROD_WGT,C_ROLL_PROD_EMP_ID,C_STL_ROL_DT,C_CUST_NO,C_CUST_NAME,C_PACK,C_DESIGN_NO,C_LINT_ID,D_START_TIME,D_END_TIME,C_EMP_ID,D_MOD_DT,N_MACH_WGT,C_FREE_TERM,C_FREE_TERM2,C_AREA,C_PCLX,C_RH,C_LF,C_KP,N_HL_TIME,C_HL,N_DFP_HL_TIME,C_DFP_HL,C_XM,C_ROUTE,N_DIAMETER,C_XM_YQ,N_JRL_WD,N_JRL_SJ ");
            strSql.Append(" FROM TPC_PLAN_ROLL T WHERE 1=1  ");

            if (C_LINT_ID.Trim() != "")
            {
                strSql.Append(" AND  C_LINT_ID='" + C_LINT_ID + "' ");
            }

            if (N_STATUS != null)
            {
                if (N_STATUS == 1)//已确认排产
                {
                    strSql.Append(" AND  N_STATUS=1 ");
                }
                if (N_STATUS == 0)//未确认完排产
                {
                    strSql.Append(" AND   N_STATUS=0 ");
                }
            }
            if (C_ORDER_NO.Trim() != "")
            {
                strSql.Append(" AND   C_ORDER_NO  LIKE '%" + C_ORDER_NO + "%'");
            }

            if (C_STL_GRD.Trim() != "")
            {
                strSql.Append(" AND   C_STL_GRD LIKE '%" + C_STL_GRD + "%'");
            }

            if (C_STD_CODE.Trim() != "")
            {
                strSql.Append(" AND   C_STD_CODE LIKE '%" + C_STD_CODE + "%'");
            }

            if (D_SPEC_MIN != null)
            {
                strSql.Append("   AND ((T.C_SPEC LIKE '%φ%' AND TO_NUMBER(REPLACE(T.C_SPEC, 'φ', '')) >= " + D_SPEC_MIN + ") OR  (T.C_SPEC LIKE '%*%' AND TO_NUMBER(GET_STRARRAYSTROFINDEX(T.C_SPEC, '*', 0)) >= " + D_SPEC_MIN + "))");
            }

            if (D_SPEC_MAX != null)
            {
                strSql.Append("   AND ((T.C_SPEC LIKE '%φ%' AND TO_NUMBER(REPLACE(T.C_SPEC, 'φ', '')) <= " + D_SPEC_MAX + ") OR  (T.C_SPEC LIKE '%*%' AND TO_NUMBER(GET_STRARRAYSTROFINDEX(T.C_SPEC, '*', 0)) <= " + D_SPEC_MAX + "))");
            }

            if (C_CUST_NAME.Trim() != "")
            {
                strSql.Append(" AND   C_CUST_NAME LIKE  '%" + C_CUST_NAME + "%'");
            }

            if (C_JQ_MIN.Trim() != "")
            {
                strSql.Append(" AND  D_DELIVERY_DT >=TO_DATE('" + C_JQ_MIN + "','yyyy-mm-dd hh24:mi:ss')");
            }
            if (C_JQ_MAX.Trim() != "")
            {
                strSql.Append("  AND  D_DELIVERY_DT >=TO_DATE('" + C_JQ_MAX + "','yyyy-mm-dd hh24:mi:ss')");
            }

            if (C_DD_MIN.Trim() != "")
            {
                strSql.Append(" AND  D_DT >=TO_DATE('" + C_DD_MIN + "','yyyy-mm-dd hh24:mi:ss')");
            }
            if (C_DD_MAX.Trim() != "")
            {
                strSql.Append("  AND  D_DT >=TO_DATE('" + C_DD_MAX + "','yyyy-mm-dd hh24:mi:ss')");
            }

            strSql.Append("  ORDER BY TO_NUMBER(REPLACE(T.C_SPEC, 'φ')), T.C_STL_GRD,T.C_STD_CODE, T.C_LINE_DESC");
            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 系统对轧钢计划重新划分产线
        /// </summary>
        /// <returns></returns>
        public string GetLine()
        {
            OracleParameter[] parameters = {
            new OracleParameter("P_MSG", OracleDbType.Varchar2,500)};
            parameters[0].Value = "失败";
            return DbHelperOra.RunProcedureOut("PKG_UPDATE_SORT.P_ZG_PLAN_LINE", parameters);
        }

       /// <summary>
       /// 手动调整产线
       /// </summary>
       /// <param name="P_ID">计划主键</param>
       /// <param name="LINE_ID">产线主键</param>
       /// <returns>成功1失败0</returns>
        public string GetLineByID(string P_ID,string LINE_ID )
        {
            OracleParameter[] parameters = {
            new OracleParameter("P_MSG", OracleDbType.Varchar2,500),
             new OracleParameter("P_ID", OracleDbType.Varchar2,50),
              new OracleParameter("P_LINE_NO", OracleDbType.Varchar2,50)
            };
            parameters[0].Value = "0";
            parameters[1].Value = P_ID;
            parameters[2].Value = LINE_ID;
            return DbHelperOra.RunProcedureOut("PKG_UPDATE_SORT.P_ZG_PLAN_LINE_BYID", parameters);
        }
        /// <summary>
        /// 获取轧钢计划中未维护机时产能的数据
        /// </summary>
        /// <returns></returns>
        public DataTable GetNJSCN()
        {
            string sql = @"SELECT DISTINCT T.C_STA_ID,
                T.C_LINE_DESC,
                T.C_STL_GRD,
                T.C_SPEC,
                T.N_MACH_WGT
  FROM TRP_PLAN_ROLL T
 WHERE T.N_STATUS = 0
   AND T.N_MACH_WGT = 0
   AND T.C_LINE_CODE IS NOT NULL
 ORDER BY T.C_STA_ID, TO_NUMBER(REPLACE(T.C_SPEC, 'φ', ''))";
            return DbHelperOra.Query(sql).Tables[0];
        }

      /// <summary>
      /// 维护计划轧钢机时产能
      /// </summary>
      /// <param name="P_LINT_ID">产线主键</param>
      /// <param name="P_STL_GRD">钢种</param>
      /// <param name="P_SPEC">规格</param>
      /// <param name="P_MACH_WGT">机时产能</param>
      /// <param name="P_SFGX">是否更新到机时产能基础表</param>
      /// <returns>是否成功1，0失败</returns>
        public string UpdatePlanJSCN(string P_LINT_ID, string P_STL_GRD,string P_SPEC,decimal P_MACH_WGT,string P_SFGX)
        {
            OracleParameter[] parameters = {
            new OracleParameter("P_MSG", OracleDbType.Varchar2,500),
             new OracleParameter("P_LINT_ID", OracleDbType.Varchar2,50),
              new OracleParameter("P_STL_GRD", OracleDbType.Varchar2,50),
             new OracleParameter("P_SPEC", OracleDbType.Varchar2,50),
              new OracleParameter("P_MACH_WGT", OracleDbType.Decimal),
             new OracleParameter("P_SFGX", OracleDbType.Varchar2,50)
            };
            parameters[0].Value = "0";
            parameters[1].Value = P_LINT_ID;
            parameters[2].Value = P_STL_GRD;
            parameters[3].Value = P_SPEC;
            parameters[4].Value = P_MACH_WGT;
            parameters[5].Value = P_SFGX;
            return DbHelperOra.RunProcedureOut("PKG_UPDATE_SORT.P_ZG_JSCN", parameters);
        }

        #endregion  ExtensionMethod
    }
}

