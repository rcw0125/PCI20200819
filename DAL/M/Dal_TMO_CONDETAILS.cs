using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;
namespace DAL
{
    /// <summary>
    /// 数据访问类:TMO_CONDETAILS
    /// </summary>
    public partial class Dal_TMO_CONDETAILS
    {
        public Dal_TMO_CONDETAILS()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string C_NO)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TMO_CONDETAILS");
            strSql.Append(" where C_NO=:C_NO ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_NO", OracleDbType.Varchar2,100)         };
            parameters[0].Value = C_NO;

            return DbHelperOra.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Mod_TMO_CONDETAILS model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TMO_CONDETAILS(");
            strSql.Append("C_CON_NO,C_CON_NAME,C_AREA,C_MAT_CODE,C_MAT_NAME,C_TECH_PROT,C_SPEC,C_STL_GRD,C_AUXI,C_UNITIS,C_CUST_SQ,C_PRO_USE,D_NEED_DT,D_DELIVERY_DT,D_DT,C_FREE_TERM,C_EQUATION_FACTOR,N_NUM,N_WGT,N_NOTAX_UNITPRICE,N_TAX,N_NOMONEY,N_PRICETAX_SUM,N_DIS,N_AMOUNT_FAX,N_ITEM_DIS,N_NOTAX_NETPRICE,N_INCLUTAX_NETPRICE,C_CGC,C_CGAREA,C_CGADDR,C_ATSTATION,C_OTC,C_CURRENCY_TYPE,N_CELING_RATE,N_DC_NOTAX_UNITPRICE,N_DC_INCLUTAX_UNITPRICE,N_DC_AMOUNT_FAX,N_DC_PRICETAX_SUM,N_DELIVERY_ALLOWANCE,N_IS_DELIVERY_CLOSE,N_IS_OT_CLOSE,N_DIA,N_MACH_WGT,C_ISSUE_EMP_ID,C_PRD_EMP_ID,C_STD_CODE,C_DESIGN_NO,C_DESIGN_PROG,N_SLAB_MATCH_WGT,N_LINE_MATCH_WGT,N_SMS_PROD_WGT,C_SMS_PROD_EMP_ID,D_SMS_PROD_DT,N_ROLL_PROD_WGT,C_ROLL_PROD_EMP_ID,C_STL_ROL_DT,N_PROD_WGT,N_WARE_WGT,N_WARE_OUT_WGT,N_STATUS,N_FLAG,N_TYPE,N_EXEC_STATUS,C_PACK,N_USER_LEV,N_STL_GRD_LEV,N_ORDER_LEV,C_QUALIRY_LEV,C_XG_MODIFY,C_XG_MODEIFY_DT,C_LINE_NO,C_CCM_NO,C_REMARK,C_EMP_ID,C_EMP_NAME,D_MOD_DT,N_ISSUE_WGT,C_CUST_NO,C_CUST_NAME,C_SALE_CHANNEL,C_FREE_TERM2,C_SHIPVIA,C_PROD_NAME,C_PROD_KIND,C_LEV,C_ORDER_LEV,C_RH,C_LF,C_KP,N_HL_TIME,C_HL,N_DFP_HL_TIME,C_DFP_HL,C_XM,C_CGID,C_OTCID,N_PRICE2,C_EXTEND1,C_EXTEND2,C_EXTEND3,C_EXTEND4,D_SYS_DELIVERY_DT,C_CGMAN,C_CGMOBILE,C_DEPT_ID,C_SALE_EMP,C_APPROVER,D_APPROVER_DT)");
            strSql.Append(" values (");
            strSql.Append(":C_CON_NO,:C_CON_NAME,:C_AREA,:C_MAT_CODE,:C_MAT_NAME,:C_TECH_PROT,:C_SPEC,:C_STL_GRD,:C_AUXI,:C_UNITIS,:C_CUST_SQ,:C_PRO_USE,:D_NEED_DT,:D_DELIVERY_DT,:D_DT,:C_FREE_TERM,:C_EQUATION_FACTOR,:N_NUM,:N_WGT,:N_NOTAX_UNITPRICE,:N_TAX,:N_NOMONEY,:N_PRICETAX_SUM,:N_DIS,:N_AMOUNT_FAX,:N_ITEM_DIS,:N_NOTAX_NETPRICE,:N_INCLUTAX_NETPRICE,:C_CGC,:C_CGAREA,:C_CGADDR,:C_ATSTATION,:C_OTC,:C_CURRENCY_TYPE,:N_CELING_RATE,:N_DC_NOTAX_UNITPRICE,:N_DC_INCLUTAX_UNITPRICE,:N_DC_AMOUNT_FAX,:N_DC_PRICETAX_SUM,:N_DELIVERY_ALLOWANCE,:N_IS_DELIVERY_CLOSE,:N_IS_OT_CLOSE,:N_DIA,:N_MACH_WGT,:C_ISSUE_EMP_ID,:C_PRD_EMP_ID,:C_STD_CODE,:C_DESIGN_NO,:C_DESIGN_PROG,:N_SLAB_MATCH_WGT,:N_LINE_MATCH_WGT,:N_SMS_PROD_WGT,:C_SMS_PROD_EMP_ID,:D_SMS_PROD_DT,:N_ROLL_PROD_WGT,:C_ROLL_PROD_EMP_ID,:C_STL_ROL_DT,:N_PROD_WGT,:N_WARE_WGT,:N_WARE_OUT_WGT,:N_STATUS,:N_FLAG,:N_TYPE,:N_EXEC_STATUS,:C_PACK,:N_USER_LEV,:N_STL_GRD_LEV,:N_ORDER_LEV,:C_QUALIRY_LEV,:C_XG_MODIFY,:C_XG_MODEIFY_DT,:C_LINE_NO,:C_CCM_NO,:C_REMARK,:C_EMP_ID,:C_EMP_NAME,:D_MOD_DT,:N_ISSUE_WGT,:C_CUST_NO,:C_CUST_NAME,:C_SALE_CHANNEL,:C_FREE_TERM2,:C_SHIPVIA,:C_PROD_NAME,:C_PROD_KIND,:C_LEV,:C_ORDER_LEV,:C_RH,:C_LF,:C_KP,:N_HL_TIME,:C_HL,:N_DFP_HL_TIME,:C_DFP_HL,:C_XM,:C_CGID,:C_OTCID,:N_PRICE2,:C_EXTEND1,:C_EXTEND2,:C_EXTEND3,:C_EXTEND4,:D_SYS_DELIVERY_DT,:C_CGMAN,:C_CGMOBILE,:C_DEPT_ID,:C_SALE_EMP,:C_APPROVER,:D_APPROVER_DT)");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_CON_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CON_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_AREA", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MAT_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MAT_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_TECH_PROT", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SPEC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STL_GRD", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_AUXI", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_UNITIS", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CUST_SQ", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PRO_USE", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_NEED_DT", OracleDbType.Date),
                    new OracleParameter(":D_DELIVERY_DT", OracleDbType.Date),
                    new OracleParameter(":D_DT", OracleDbType.Date),
                    new OracleParameter(":C_FREE_TERM", OracleDbType.Varchar2,300),
                    new OracleParameter(":C_EQUATION_FACTOR", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_NUM", OracleDbType.Decimal,5),
                    new OracleParameter(":N_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":N_NOTAX_UNITPRICE", OracleDbType.Decimal,15),
                    new OracleParameter(":N_TAX", OracleDbType.Decimal,15),
                    new OracleParameter(":N_NOMONEY", OracleDbType.Decimal,15),
                    new OracleParameter(":N_PRICETAX_SUM", OracleDbType.Decimal,15),
                    new OracleParameter(":N_DIS", OracleDbType.Decimal,15),
                    new OracleParameter(":N_AMOUNT_FAX", OracleDbType.Decimal,15),
                    new OracleParameter(":N_ITEM_DIS", OracleDbType.Decimal,15),
                    new OracleParameter(":N_NOTAX_NETPRICE", OracleDbType.Decimal,15),
                    new OracleParameter(":N_INCLUTAX_NETPRICE", OracleDbType.Decimal,15),
                    new OracleParameter(":C_CGC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CGAREA", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CGADDR", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ATSTATION", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_OTC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CURRENCY_TYPE", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_CELING_RATE", OracleDbType.Decimal,15),
                    new OracleParameter(":N_DC_NOTAX_UNITPRICE", OracleDbType.Decimal,15),
                    new OracleParameter(":N_DC_INCLUTAX_UNITPRICE", OracleDbType.Decimal,15),
                    new OracleParameter(":N_DC_AMOUNT_FAX", OracleDbType.Decimal,15),
                    new OracleParameter(":N_DC_PRICETAX_SUM", OracleDbType.Decimal,15),
                    new OracleParameter(":N_DELIVERY_ALLOWANCE", OracleDbType.Decimal,15),
                    new OracleParameter(":N_IS_DELIVERY_CLOSE", OracleDbType.Decimal,1),
                    new OracleParameter(":N_IS_OT_CLOSE", OracleDbType.Decimal,1),
                    new OracleParameter(":N_DIA", OracleDbType.Decimal,15),
                    new OracleParameter(":N_MACH_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":C_ISSUE_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PRD_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STD_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_DESIGN_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_DESIGN_PROG", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_SLAB_MATCH_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":N_LINE_MATCH_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":N_SMS_PROD_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":C_SMS_PROD_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_SMS_PROD_DT", OracleDbType.Date),
                    new OracleParameter(":N_ROLL_PROD_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":C_ROLL_PROD_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STL_ROL_DT", OracleDbType.Date),
                    new OracleParameter(":N_PROD_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":N_WARE_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":N_WARE_OUT_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,2),
                    new OracleParameter(":N_FLAG", OracleDbType.Decimal,2),
                    new OracleParameter(":N_TYPE", OracleDbType.Decimal,2),
                    new OracleParameter(":N_EXEC_STATUS", OracleDbType.Decimal,2),
                    new OracleParameter(":C_PACK", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_USER_LEV", OracleDbType.Decimal,2),
                    new OracleParameter(":N_STL_GRD_LEV", OracleDbType.Decimal,2),
                    new OracleParameter(":N_ORDER_LEV", OracleDbType.Decimal,2),
                    new OracleParameter(":C_QUALIRY_LEV", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_XG_MODIFY", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_XG_MODEIFY_DT", OracleDbType.Date),
                    new OracleParameter(":C_LINE_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CCM_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,200),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_EMP_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":N_ISSUE_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":C_CUST_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CUST_NAME", OracleDbType.Varchar2,200),
                    new OracleParameter(":C_SALE_CHANNEL", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_FREE_TERM2", OracleDbType.Varchar2,300),
                    new OracleParameter(":C_SHIPVIA", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PROD_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PROD_KIND", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_LEV", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ORDER_LEV", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_RH", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_LF", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_KP", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_HL_TIME", OracleDbType.Decimal,10),
                    new OracleParameter(":C_HL", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_DFP_HL_TIME", OracleDbType.Decimal,10),
                    new OracleParameter(":C_DFP_HL", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_XM", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CGID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_OTCID", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_PRICE2", OracleDbType.Decimal,15),
                    new OracleParameter(":C_EXTEND1", OracleDbType.Varchar2,200),
                    new OracleParameter(":C_EXTEND2", OracleDbType.Varchar2,200),
                    new OracleParameter(":C_EXTEND3", OracleDbType.Varchar2,200),
                    new OracleParameter(":C_EXTEND4", OracleDbType.Varchar2,200),
                    new OracleParameter(":D_SYS_DELIVERY_DT", OracleDbType.Date),
                    new OracleParameter(":C_CGMAN", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CGMOBILE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_DEPT_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SALE_EMP", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_APPROVER", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_APPROVER_DT", OracleDbType.Date)};
            parameters[0].Value = model.C_CON_NO;
            parameters[1].Value = model.C_CON_NAME;
            parameters[2].Value = model.C_AREA;
            parameters[3].Value = model.C_MAT_CODE;
            parameters[4].Value = model.C_MAT_NAME;
            parameters[5].Value = model.C_TECH_PROT;
            parameters[6].Value = model.C_SPEC;
            parameters[7].Value = model.C_STL_GRD;
            parameters[8].Value = model.C_AUXI;
            parameters[9].Value = model.C_UNITIS;
            parameters[10].Value = model.C_CUST_SQ;
            parameters[11].Value = model.C_PRO_USE;
            parameters[12].Value = model.D_NEED_DT;
            parameters[13].Value = model.D_DELIVERY_DT;
            parameters[14].Value = model.D_DT;
            parameters[15].Value = model.C_FREE_TERM;
            parameters[16].Value = model.C_EQUATION_FACTOR;
            parameters[17].Value = model.N_NUM;
            parameters[18].Value = model.N_WGT;
            parameters[19].Value = model.N_NOTAX_UNITPRICE;
            parameters[20].Value = model.N_TAX;
            parameters[21].Value = model.N_NOMONEY;
            parameters[22].Value = model.N_PRICETAX_SUM;
            parameters[23].Value = model.N_DIS;
            parameters[24].Value = model.N_AMOUNT_FAX;
            parameters[25].Value = model.N_ITEM_DIS;
            parameters[26].Value = model.N_NOTAX_NETPRICE;
            parameters[27].Value = model.N_INCLUTAX_NETPRICE;
            parameters[28].Value = model.C_CGC;
            parameters[29].Value = model.C_CGAREA;
            parameters[30].Value = model.C_CGADDR;
            parameters[31].Value = model.C_ATSTATION;
            parameters[32].Value = model.C_OTC;
            parameters[33].Value = model.C_CURRENCY_TYPE;
            parameters[34].Value = model.N_CELING_RATE;
            parameters[35].Value = model.N_DC_NOTAX_UNITPRICE;
            parameters[36].Value = model.N_DC_INCLUTAX_UNITPRICE;
            parameters[37].Value = model.N_DC_AMOUNT_FAX;
            parameters[38].Value = model.N_DC_PRICETAX_SUM;
            parameters[39].Value = model.N_DELIVERY_ALLOWANCE;
            parameters[40].Value = model.N_IS_DELIVERY_CLOSE;
            parameters[41].Value = model.N_IS_OT_CLOSE;
            parameters[42].Value = model.N_DIA;
            parameters[43].Value = model.N_MACH_WGT;
            parameters[44].Value = model.C_ISSUE_EMP_ID;
            parameters[45].Value = model.C_PRD_EMP_ID;
            parameters[46].Value = model.C_STD_CODE;
            parameters[47].Value = model.C_DESIGN_NO;
            parameters[48].Value = model.C_DESIGN_PROG;
            parameters[49].Value = model.N_SLAB_MATCH_WGT;
            parameters[50].Value = model.N_LINE_MATCH_WGT;
            parameters[51].Value = model.N_SMS_PROD_WGT;
            parameters[52].Value = model.C_SMS_PROD_EMP_ID;
            parameters[53].Value = model.D_SMS_PROD_DT;
            parameters[54].Value = model.N_ROLL_PROD_WGT;
            parameters[55].Value = model.C_ROLL_PROD_EMP_ID;
            parameters[56].Value = model.C_STL_ROL_DT;
            parameters[57].Value = model.N_PROD_WGT;
            parameters[58].Value = model.N_WARE_WGT;
            parameters[59].Value = model.N_WARE_OUT_WGT;
            parameters[60].Value = model.N_STATUS;
            parameters[61].Value = model.N_FLAG;
            parameters[62].Value = model.N_TYPE;
            parameters[63].Value = model.N_EXEC_STATUS;
            parameters[64].Value = model.C_PACK;
            parameters[65].Value = model.N_USER_LEV;
            parameters[66].Value = model.N_STL_GRD_LEV;
            parameters[67].Value = model.N_ORDER_LEV;
            parameters[68].Value = model.C_QUALIRY_LEV;
            parameters[69].Value = model.C_XG_MODIFY;
            parameters[70].Value = model.C_XG_MODEIFY_DT;
            parameters[71].Value = model.C_LINE_NO;
            parameters[72].Value = model.C_CCM_NO;
            parameters[73].Value = model.C_REMARK;
            parameters[74].Value = model.C_EMP_ID;
            parameters[75].Value = model.C_EMP_NAME;
            parameters[76].Value = model.D_MOD_DT;
            parameters[77].Value = model.N_ISSUE_WGT;
            parameters[78].Value = model.C_CUST_NO;
            parameters[79].Value = model.C_CUST_NAME;
            parameters[80].Value = model.C_SALE_CHANNEL;
            parameters[81].Value = model.C_FREE_TERM2;
            parameters[82].Value = model.C_SHIPVIA;
            parameters[83].Value = model.C_PROD_NAME;
            parameters[84].Value = model.C_PROD_KIND;
            parameters[85].Value = model.C_LEV;
            parameters[86].Value = model.C_ORDER_LEV;
            parameters[87].Value = model.C_RH;
            parameters[88].Value = model.C_LF;
            parameters[89].Value = model.C_KP;
            parameters[90].Value = model.N_HL_TIME;
            parameters[91].Value = model.C_HL;
            parameters[92].Value = model.N_DFP_HL_TIME;
            parameters[93].Value = model.C_DFP_HL;
            parameters[94].Value = model.C_XM;
            parameters[95].Value = model.C_CGID;
            parameters[96].Value = model.C_OTCID;
            parameters[97].Value = model.N_PRICE2;
            parameters[98].Value = model.C_EXTEND1;
            parameters[99].Value = model.C_EXTEND2;
            parameters[100].Value = model.C_EXTEND3;
            parameters[101].Value = model.C_EXTEND4;
            parameters[102].Value = model.D_SYS_DELIVERY_DT;
            parameters[103].Value = model.C_CGMAN;
            parameters[104].Value = model.C_CGMOBILE;
            parameters[105].Value = model.C_DEPT_ID;
            parameters[106].Value = model.C_SALE_EMP;
            parameters[107].Value = model.C_APPROVER;
            parameters[108].Value = model.D_APPROVER_DT;


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
        public bool Update(Mod_TMO_CONDETAILS model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TMO_CONDETAILS set ");
            strSql.Append("C_CON_NO=:C_CON_NO,");
            strSql.Append("C_CON_NAME=:C_CON_NAME,");
            strSql.Append("C_AREA=:C_AREA,");
            strSql.Append("C_MAT_CODE=:C_MAT_CODE,");
            strSql.Append("C_MAT_NAME=:C_MAT_NAME,");
            strSql.Append("C_TECH_PROT=:C_TECH_PROT,");
            strSql.Append("C_SPEC=:C_SPEC,");
            strSql.Append("C_STL_GRD=:C_STL_GRD,");
            strSql.Append("C_AUXI=:C_AUXI,");
            strSql.Append("C_UNITIS=:C_UNITIS,");
            strSql.Append("C_CUST_SQ=:C_CUST_SQ,");
            strSql.Append("C_PRO_USE=:C_PRO_USE,");
            strSql.Append("D_NEED_DT=:D_NEED_DT,");
            strSql.Append("D_DELIVERY_DT=:D_DELIVERY_DT,");
            strSql.Append("D_DT=:D_DT,");
            strSql.Append("C_FREE_TERM=:C_FREE_TERM,");
            strSql.Append("C_EQUATION_FACTOR=:C_EQUATION_FACTOR,");
            strSql.Append("N_NUM=:N_NUM,");
            strSql.Append("N_WGT=:N_WGT,");
            strSql.Append("N_NOTAX_UNITPRICE=:N_NOTAX_UNITPRICE,");
            strSql.Append("N_TAX=:N_TAX,");
            strSql.Append("N_NOMONEY=:N_NOMONEY,");
            strSql.Append("N_PRICETAX_SUM=:N_PRICETAX_SUM,");
            strSql.Append("N_DIS=:N_DIS,");
            strSql.Append("N_AMOUNT_FAX=:N_AMOUNT_FAX,");
            strSql.Append("N_ITEM_DIS=:N_ITEM_DIS,");
            strSql.Append("N_NOTAX_NETPRICE=:N_NOTAX_NETPRICE,");
            strSql.Append("N_INCLUTAX_NETPRICE=:N_INCLUTAX_NETPRICE,");
            strSql.Append("C_CGC=:C_CGC,");
            strSql.Append("C_CGAREA=:C_CGAREA,");
            strSql.Append("C_CGADDR=:C_CGADDR,");
            strSql.Append("C_ATSTATION=:C_ATSTATION,");
            strSql.Append("C_OTC=:C_OTC,");
            strSql.Append("C_CURRENCY_TYPE=:C_CURRENCY_TYPE,");
            strSql.Append("N_CELING_RATE=:N_CELING_RATE,");
            strSql.Append("N_DC_NOTAX_UNITPRICE=:N_DC_NOTAX_UNITPRICE,");
            strSql.Append("N_DC_INCLUTAX_UNITPRICE=:N_DC_INCLUTAX_UNITPRICE,");
            strSql.Append("N_DC_AMOUNT_FAX=:N_DC_AMOUNT_FAX,");
            strSql.Append("N_DC_PRICETAX_SUM=:N_DC_PRICETAX_SUM,");
            strSql.Append("N_DELIVERY_ALLOWANCE=:N_DELIVERY_ALLOWANCE,");
            strSql.Append("N_IS_DELIVERY_CLOSE=:N_IS_DELIVERY_CLOSE,");
            strSql.Append("N_IS_OT_CLOSE=:N_IS_OT_CLOSE,");
            strSql.Append("N_DIA=:N_DIA,");
            strSql.Append("N_MACH_WGT=:N_MACH_WGT,");
            strSql.Append("C_ISSUE_EMP_ID=:C_ISSUE_EMP_ID,");
            strSql.Append("C_PRD_EMP_ID=:C_PRD_EMP_ID,");
            strSql.Append("C_STD_CODE=:C_STD_CODE,");
            strSql.Append("C_DESIGN_NO=:C_DESIGN_NO,");
            strSql.Append("C_DESIGN_PROG=:C_DESIGN_PROG,");
            strSql.Append("N_SLAB_MATCH_WGT=:N_SLAB_MATCH_WGT,");
            strSql.Append("N_LINE_MATCH_WGT=:N_LINE_MATCH_WGT,");
            strSql.Append("N_SMS_PROD_WGT=:N_SMS_PROD_WGT,");
            strSql.Append("C_SMS_PROD_EMP_ID=:C_SMS_PROD_EMP_ID,");
            strSql.Append("D_SMS_PROD_DT=:D_SMS_PROD_DT,");
            strSql.Append("N_ROLL_PROD_WGT=:N_ROLL_PROD_WGT,");
            strSql.Append("C_ROLL_PROD_EMP_ID=:C_ROLL_PROD_EMP_ID,");
            strSql.Append("C_STL_ROL_DT=:C_STL_ROL_DT,");
            strSql.Append("N_PROD_WGT=:N_PROD_WGT,");
            strSql.Append("N_WARE_WGT=:N_WARE_WGT,");
            strSql.Append("N_WARE_OUT_WGT=:N_WARE_OUT_WGT,");
            strSql.Append("N_STATUS=:N_STATUS,");
            strSql.Append("N_FLAG=:N_FLAG,");
            strSql.Append("N_TYPE=:N_TYPE,");
            strSql.Append("N_EXEC_STATUS=:N_EXEC_STATUS,");
            strSql.Append("C_PACK=:C_PACK,");
            strSql.Append("N_USER_LEV=:N_USER_LEV,");
            strSql.Append("N_STL_GRD_LEV=:N_STL_GRD_LEV,");
            strSql.Append("N_ORDER_LEV=:N_ORDER_LEV,");
            strSql.Append("C_QUALIRY_LEV=:C_QUALIRY_LEV,");
            strSql.Append("C_XG_MODIFY=:C_XG_MODIFY,");
            strSql.Append("C_XG_MODEIFY_DT=:C_XG_MODEIFY_DT,");
            strSql.Append("C_LINE_NO=:C_LINE_NO,");
            strSql.Append("C_CCM_NO=:C_CCM_NO,");
            strSql.Append("C_REMARK=:C_REMARK,");
            strSql.Append("C_EMP_ID=:C_EMP_ID,");
            strSql.Append("C_EMP_NAME=:C_EMP_NAME,");
            strSql.Append("D_MOD_DT=:D_MOD_DT,");
            strSql.Append("N_ISSUE_WGT=:N_ISSUE_WGT,");
            strSql.Append("C_CUST_NO=:C_CUST_NO,");
            strSql.Append("C_CUST_NAME=:C_CUST_NAME,");
            strSql.Append("C_SALE_CHANNEL=:C_SALE_CHANNEL,");
            strSql.Append("C_FREE_TERM2=:C_FREE_TERM2,");
            strSql.Append("C_SHIPVIA=:C_SHIPVIA,");
            strSql.Append("C_PROD_NAME=:C_PROD_NAME,");
            strSql.Append("C_PROD_KIND=:C_PROD_KIND,");
            strSql.Append("C_LEV=:C_LEV,");
            strSql.Append("C_ORDER_LEV=:C_ORDER_LEV,");
            strSql.Append("C_RH=:C_RH,");
            strSql.Append("C_LF=:C_LF,");
            strSql.Append("C_KP=:C_KP,");
            strSql.Append("N_HL_TIME=:N_HL_TIME,");
            strSql.Append("C_HL=:C_HL,");
            strSql.Append("N_DFP_HL_TIME=:N_DFP_HL_TIME,");
            strSql.Append("C_DFP_HL=:C_DFP_HL,");
            strSql.Append("C_XM=:C_XM,");
            strSql.Append("C_CGID=:C_CGID,");
            strSql.Append("C_OTCID=:C_OTCID,");
            strSql.Append("N_PRICE2=:N_PRICE2,");
            strSql.Append("C_EXTEND1=:C_EXTEND1,");
            strSql.Append("C_EXTEND2=:C_EXTEND2,");
            strSql.Append("C_EXTEND3=:C_EXTEND3,");
            strSql.Append("C_EXTEND4=:C_EXTEND4,");
            strSql.Append("D_SYS_DELIVERY_DT=:D_SYS_DELIVERY_DT,");
            strSql.Append("C_CGMAN=:C_CGMAN,");
            strSql.Append("C_CGMOBILE=:C_CGMOBILE,");
            strSql.Append("C_DEPT_ID=:C_DEPT_ID,");
            strSql.Append("C_SALE_EMP=:C_SALE_EMP,");
            strSql.Append("C_APPROVER=:C_APPROVER,");
            strSql.Append("D_APPROVER_DT=:D_APPROVER_DT");
            strSql.Append(" where C_NO=:C_NO ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_CON_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CON_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_AREA", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MAT_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MAT_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_TECH_PROT", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SPEC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STL_GRD", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_AUXI", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_UNITIS", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CUST_SQ", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PRO_USE", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_NEED_DT", OracleDbType.Date),
                    new OracleParameter(":D_DELIVERY_DT", OracleDbType.Date),
                    new OracleParameter(":D_DT", OracleDbType.Date),
                    new OracleParameter(":C_FREE_TERM", OracleDbType.Varchar2,300),
                    new OracleParameter(":C_EQUATION_FACTOR", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_NUM", OracleDbType.Decimal,5),
                    new OracleParameter(":N_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":N_NOTAX_UNITPRICE", OracleDbType.Decimal,15),
                    new OracleParameter(":N_TAX", OracleDbType.Decimal,15),
                    new OracleParameter(":N_NOMONEY", OracleDbType.Decimal,15),
                    new OracleParameter(":N_PRICETAX_SUM", OracleDbType.Decimal,15),
                    new OracleParameter(":N_DIS", OracleDbType.Decimal,15),
                    new OracleParameter(":N_AMOUNT_FAX", OracleDbType.Decimal,15),
                    new OracleParameter(":N_ITEM_DIS", OracleDbType.Decimal,15),
                    new OracleParameter(":N_NOTAX_NETPRICE", OracleDbType.Decimal,15),
                    new OracleParameter(":N_INCLUTAX_NETPRICE", OracleDbType.Decimal,15),
                    new OracleParameter(":C_CGC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CGAREA", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CGADDR", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ATSTATION", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_OTC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CURRENCY_TYPE", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_CELING_RATE", OracleDbType.Decimal,15),
                    new OracleParameter(":N_DC_NOTAX_UNITPRICE", OracleDbType.Decimal,15),
                    new OracleParameter(":N_DC_INCLUTAX_UNITPRICE", OracleDbType.Decimal,15),
                    new OracleParameter(":N_DC_AMOUNT_FAX", OracleDbType.Decimal,15),
                    new OracleParameter(":N_DC_PRICETAX_SUM", OracleDbType.Decimal,15),
                    new OracleParameter(":N_DELIVERY_ALLOWANCE", OracleDbType.Decimal,15),
                    new OracleParameter(":N_IS_DELIVERY_CLOSE", OracleDbType.Decimal,1),
                    new OracleParameter(":N_IS_OT_CLOSE", OracleDbType.Decimal,1),
                    new OracleParameter(":N_DIA", OracleDbType.Decimal,15),
                    new OracleParameter(":N_MACH_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":C_ISSUE_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PRD_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STD_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_DESIGN_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_DESIGN_PROG", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_SLAB_MATCH_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":N_LINE_MATCH_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":N_SMS_PROD_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":C_SMS_PROD_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_SMS_PROD_DT", OracleDbType.Date),
                    new OracleParameter(":N_ROLL_PROD_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":C_ROLL_PROD_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STL_ROL_DT", OracleDbType.Date),
                    new OracleParameter(":N_PROD_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":N_WARE_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":N_WARE_OUT_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,2),
                    new OracleParameter(":N_FLAG", OracleDbType.Decimal,2),
                    new OracleParameter(":N_TYPE", OracleDbType.Decimal,2),
                    new OracleParameter(":N_EXEC_STATUS", OracleDbType.Decimal,2),
                    new OracleParameter(":C_PACK", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_USER_LEV", OracleDbType.Decimal,2),
                    new OracleParameter(":N_STL_GRD_LEV", OracleDbType.Decimal,2),
                    new OracleParameter(":N_ORDER_LEV", OracleDbType.Decimal,2),
                    new OracleParameter(":C_QUALIRY_LEV", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_XG_MODIFY", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_XG_MODEIFY_DT", OracleDbType.Date),
                    new OracleParameter(":C_LINE_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CCM_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,200),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_EMP_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":N_ISSUE_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":C_CUST_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CUST_NAME", OracleDbType.Varchar2,200),
                    new OracleParameter(":C_SALE_CHANNEL", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_FREE_TERM2", OracleDbType.Varchar2,300),
                    new OracleParameter(":C_SHIPVIA", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PROD_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PROD_KIND", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_LEV", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ORDER_LEV", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_RH", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_LF", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_KP", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_HL_TIME", OracleDbType.Decimal,10),
                    new OracleParameter(":C_HL", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_DFP_HL_TIME", OracleDbType.Decimal,10),
                    new OracleParameter(":C_DFP_HL", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_XM", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CGID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_OTCID", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_PRICE2", OracleDbType.Decimal,15),
                    new OracleParameter(":C_EXTEND1", OracleDbType.Varchar2,200),
                    new OracleParameter(":C_EXTEND2", OracleDbType.Varchar2,200),
                    new OracleParameter(":C_EXTEND3", OracleDbType.Varchar2,200),
                    new OracleParameter(":C_EXTEND4", OracleDbType.Varchar2,200),
                    new OracleParameter(":D_SYS_DELIVERY_DT", OracleDbType.Date),
                    new OracleParameter(":C_CGMAN", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CGMOBILE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_DEPT_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SALE_EMP", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_APPROVER", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_APPROVER_DT", OracleDbType.Date),
                    new OracleParameter(":C_NO", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.C_CON_NO;
            parameters[1].Value = model.C_CON_NAME;
            parameters[2].Value = model.C_AREA;
            parameters[3].Value = model.C_MAT_CODE;
            parameters[4].Value = model.C_MAT_NAME;
            parameters[5].Value = model.C_TECH_PROT;
            parameters[6].Value = model.C_SPEC;
            parameters[7].Value = model.C_STL_GRD;
            parameters[8].Value = model.C_AUXI;
            parameters[9].Value = model.C_UNITIS;
            parameters[10].Value = model.C_CUST_SQ;
            parameters[11].Value = model.C_PRO_USE;
            parameters[12].Value = model.D_NEED_DT;
            parameters[13].Value = model.D_DELIVERY_DT;
            parameters[14].Value = model.D_DT;
            parameters[15].Value = model.C_FREE_TERM;
            parameters[16].Value = model.C_EQUATION_FACTOR;
            parameters[17].Value = model.N_NUM;
            parameters[18].Value = model.N_WGT;
            parameters[19].Value = model.N_NOTAX_UNITPRICE;
            parameters[20].Value = model.N_TAX;
            parameters[21].Value = model.N_NOMONEY;
            parameters[22].Value = model.N_PRICETAX_SUM;
            parameters[23].Value = model.N_DIS;
            parameters[24].Value = model.N_AMOUNT_FAX;
            parameters[25].Value = model.N_ITEM_DIS;
            parameters[26].Value = model.N_NOTAX_NETPRICE;
            parameters[27].Value = model.N_INCLUTAX_NETPRICE;
            parameters[28].Value = model.C_CGC;
            parameters[29].Value = model.C_CGAREA;
            parameters[30].Value = model.C_CGADDR;
            parameters[31].Value = model.C_ATSTATION;
            parameters[32].Value = model.C_OTC;
            parameters[33].Value = model.C_CURRENCY_TYPE;
            parameters[34].Value = model.N_CELING_RATE;
            parameters[35].Value = model.N_DC_NOTAX_UNITPRICE;
            parameters[36].Value = model.N_DC_INCLUTAX_UNITPRICE;
            parameters[37].Value = model.N_DC_AMOUNT_FAX;
            parameters[38].Value = model.N_DC_PRICETAX_SUM;
            parameters[39].Value = model.N_DELIVERY_ALLOWANCE;
            parameters[40].Value = model.N_IS_DELIVERY_CLOSE;
            parameters[41].Value = model.N_IS_OT_CLOSE;
            parameters[42].Value = model.N_DIA;
            parameters[43].Value = model.N_MACH_WGT;
            parameters[44].Value = model.C_ISSUE_EMP_ID;
            parameters[45].Value = model.C_PRD_EMP_ID;
            parameters[46].Value = model.C_STD_CODE;
            parameters[47].Value = model.C_DESIGN_NO;
            parameters[48].Value = model.C_DESIGN_PROG;
            parameters[49].Value = model.N_SLAB_MATCH_WGT;
            parameters[50].Value = model.N_LINE_MATCH_WGT;
            parameters[51].Value = model.N_SMS_PROD_WGT;
            parameters[52].Value = model.C_SMS_PROD_EMP_ID;
            parameters[53].Value = model.D_SMS_PROD_DT;
            parameters[54].Value = model.N_ROLL_PROD_WGT;
            parameters[55].Value = model.C_ROLL_PROD_EMP_ID;
            parameters[56].Value = model.C_STL_ROL_DT;
            parameters[57].Value = model.N_PROD_WGT;
            parameters[58].Value = model.N_WARE_WGT;
            parameters[59].Value = model.N_WARE_OUT_WGT;
            parameters[60].Value = model.N_STATUS;
            parameters[61].Value = model.N_FLAG;
            parameters[62].Value = model.N_TYPE;
            parameters[63].Value = model.N_EXEC_STATUS;
            parameters[64].Value = model.C_PACK;
            parameters[65].Value = model.N_USER_LEV;
            parameters[66].Value = model.N_STL_GRD_LEV;
            parameters[67].Value = model.N_ORDER_LEV;
            parameters[68].Value = model.C_QUALIRY_LEV;
            parameters[69].Value = model.C_XG_MODIFY;
            parameters[70].Value = model.C_XG_MODEIFY_DT;
            parameters[71].Value = model.C_LINE_NO;
            parameters[72].Value = model.C_CCM_NO;
            parameters[73].Value = model.C_REMARK;
            parameters[74].Value = model.C_EMP_ID;
            parameters[75].Value = model.C_EMP_NAME;
            parameters[76].Value = model.D_MOD_DT;
            parameters[77].Value = model.N_ISSUE_WGT;
            parameters[78].Value = model.C_CUST_NO;
            parameters[79].Value = model.C_CUST_NAME;
            parameters[80].Value = model.C_SALE_CHANNEL;
            parameters[81].Value = model.C_FREE_TERM2;
            parameters[82].Value = model.C_SHIPVIA;
            parameters[83].Value = model.C_PROD_NAME;
            parameters[84].Value = model.C_PROD_KIND;
            parameters[85].Value = model.C_LEV;
            parameters[86].Value = model.C_ORDER_LEV;
            parameters[87].Value = model.C_RH;
            parameters[88].Value = model.C_LF;
            parameters[89].Value = model.C_KP;
            parameters[90].Value = model.N_HL_TIME;
            parameters[91].Value = model.C_HL;
            parameters[92].Value = model.N_DFP_HL_TIME;
            parameters[93].Value = model.C_DFP_HL;
            parameters[94].Value = model.C_XM;
            parameters[95].Value = model.C_CGID;
            parameters[96].Value = model.C_OTCID;
            parameters[97].Value = model.N_PRICE2;
            parameters[98].Value = model.C_EXTEND1;
            parameters[99].Value = model.C_EXTEND2;
            parameters[100].Value = model.C_EXTEND3;
            parameters[101].Value = model.C_EXTEND4;
            parameters[102].Value = model.D_SYS_DELIVERY_DT;
            parameters[103].Value = model.C_CGMAN;
            parameters[104].Value = model.C_CGMOBILE;
            parameters[105].Value = model.C_DEPT_ID;
            parameters[106].Value = model.C_SALE_EMP;
            parameters[107].Value = model.C_APPROVER;
            parameters[108].Value = model.D_APPROVER_DT;
            parameters[109].Value = model.C_NO;

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
        public bool Delete(string C_NO)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from TMO_CONDETAILS ");
            strSql.Append(" where C_NO=:C_NO ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_NO", OracleDbType.Varchar2,100)         };
            parameters[0].Value = C_NO;

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
        public bool DeleteList(string C_NOlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from TMO_CONDETAILS ");
            strSql.Append(" where C_NO in (" + C_NOlist + ")  ");
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
        public Mod_TMO_CONDETAILS GetModel(string C_NO)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_NO,C_CON_NO,C_CON_NAME,C_AREA,C_MAT_CODE,C_MAT_NAME,C_TECH_PROT,C_SPEC,C_STL_GRD,C_AUXI,C_UNITIS,C_CUST_SQ,C_PRO_USE,D_NEED_DT,D_DELIVERY_DT,D_DT,C_FREE_TERM,C_EQUATION_FACTOR,N_NUM,N_WGT,N_NOTAX_UNITPRICE,N_TAX,N_NOMONEY,N_PRICETAX_SUM,N_DIS,N_AMOUNT_FAX,N_ITEM_DIS,N_NOTAX_NETPRICE,N_INCLUTAX_NETPRICE,C_CGC,C_CGAREA,C_CGADDR,C_ATSTATION,C_OTC,C_CURRENCY_TYPE,N_CELING_RATE,N_DC_NOTAX_UNITPRICE,N_DC_INCLUTAX_UNITPRICE,N_DC_AMOUNT_FAX,N_DC_PRICETAX_SUM,N_DELIVERY_ALLOWANCE,N_IS_DELIVERY_CLOSE,N_IS_OT_CLOSE,N_DIA,N_MACH_WGT,C_ISSUE_EMP_ID,C_PRD_EMP_ID,C_STD_CODE,C_DESIGN_NO,C_DESIGN_PROG,N_SLAB_MATCH_WGT,N_LINE_MATCH_WGT,N_SMS_PROD_WGT,C_SMS_PROD_EMP_ID,D_SMS_PROD_DT,N_ROLL_PROD_WGT,C_ROLL_PROD_EMP_ID,C_STL_ROL_DT,N_PROD_WGT,N_WARE_WGT,N_WARE_OUT_WGT,N_STATUS,N_FLAG,N_TYPE,N_EXEC_STATUS,C_PACK,N_USER_LEV,N_STL_GRD_LEV,N_ORDER_LEV,C_QUALIRY_LEV,C_XG_MODIFY,C_XG_MODEIFY_DT,C_LINE_NO,C_CCM_NO,C_REMARK,C_EMP_ID,C_EMP_NAME,D_MOD_DT,N_ISSUE_WGT,C_CUST_NO,C_CUST_NAME,C_SALE_CHANNEL,C_FREE_TERM2,C_SHIPVIA,C_PROD_NAME,C_PROD_KIND,C_LEV,C_ORDER_LEV,C_RH,C_LF,C_KP,N_HL_TIME,C_HL,N_DFP_HL_TIME,C_DFP_HL,C_XM,C_CGID,C_OTCID,N_PRICE2,C_EXTEND1,C_EXTEND2,C_EXTEND3,C_EXTEND4,D_SYS_DELIVERY_DT,C_CGMAN,C_CGMOBILE,C_DEPT_ID,C_SALE_EMP,C_APPROVER,D_APPROVER_DT from TMO_CONDETAILS ");
            strSql.Append(" where C_NO=:C_NO ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_NO", OracleDbType.Varchar2,100)         };
            parameters[0].Value = C_NO;

            Mod_TMO_CONDETAILS model = new Mod_TMO_CONDETAILS();
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
        public Mod_TMO_CONDETAILS DataRowToModel(DataRow row)
        {
            Mod_TMO_CONDETAILS model = new Mod_TMO_CONDETAILS();
            if (row != null)
            {
                if (row["C_NO"] != null)
                {
                    model.C_NO = row["C_NO"].ToString();
                }
                if (row["C_CON_NO"] != null)
                {
                    model.C_CON_NO = row["C_CON_NO"].ToString();
                }
                if (row["C_CON_NAME"] != null)
                {
                    model.C_CON_NAME = row["C_CON_NAME"].ToString();
                }
                if (row["C_AREA"] != null)
                {
                    model.C_AREA = row["C_AREA"].ToString();
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
                if (row["C_AUXI"] != null)
                {
                    model.C_AUXI = row["C_AUXI"].ToString();
                }
                if (row["C_UNITIS"] != null)
                {
                    model.C_UNITIS = row["C_UNITIS"].ToString();
                }
                if (row["C_CUST_SQ"] != null)
                {
                    model.C_CUST_SQ = row["C_CUST_SQ"].ToString();
                }
                if (row["C_PRO_USE"] != null)
                {
                    model.C_PRO_USE = row["C_PRO_USE"].ToString();
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
                if (row["C_FREE_TERM"] != null)
                {
                    model.C_FREE_TERM = row["C_FREE_TERM"].ToString();
                }
                if (row["C_EQUATION_FACTOR"] != null)
                {
                    model.C_EQUATION_FACTOR = row["C_EQUATION_FACTOR"].ToString();
                }
                if (row["N_NUM"] != null && row["N_NUM"].ToString() != "")
                {
                    model.N_NUM = decimal.Parse(row["N_NUM"].ToString());
                }
                if (row["N_WGT"] != null && row["N_WGT"].ToString() != "")
                {
                    model.N_WGT = decimal.Parse(row["N_WGT"].ToString());
                }
                if (row["N_NOTAX_UNITPRICE"] != null && row["N_NOTAX_UNITPRICE"].ToString() != "")
                {
                    model.N_NOTAX_UNITPRICE = decimal.Parse(row["N_NOTAX_UNITPRICE"].ToString());
                }
                if (row["N_TAX"] != null && row["N_TAX"].ToString() != "")
                {
                    model.N_TAX = decimal.Parse(row["N_TAX"].ToString());
                }
                if (row["N_NOMONEY"] != null && row["N_NOMONEY"].ToString() != "")
                {
                    model.N_NOMONEY = decimal.Parse(row["N_NOMONEY"].ToString());
                }
                if (row["N_PRICETAX_SUM"] != null && row["N_PRICETAX_SUM"].ToString() != "")
                {
                    model.N_PRICETAX_SUM = decimal.Parse(row["N_PRICETAX_SUM"].ToString());
                }
                if (row["N_DIS"] != null && row["N_DIS"].ToString() != "")
                {
                    model.N_DIS = decimal.Parse(row["N_DIS"].ToString());
                }
                if (row["N_AMOUNT_FAX"] != null && row["N_AMOUNT_FAX"].ToString() != "")
                {
                    model.N_AMOUNT_FAX = decimal.Parse(row["N_AMOUNT_FAX"].ToString());
                }
                if (row["N_ITEM_DIS"] != null && row["N_ITEM_DIS"].ToString() != "")
                {
                    model.N_ITEM_DIS = decimal.Parse(row["N_ITEM_DIS"].ToString());
                }
                if (row["N_NOTAX_NETPRICE"] != null && row["N_NOTAX_NETPRICE"].ToString() != "")
                {
                    model.N_NOTAX_NETPRICE = decimal.Parse(row["N_NOTAX_NETPRICE"].ToString());
                }
                if (row["N_INCLUTAX_NETPRICE"] != null && row["N_INCLUTAX_NETPRICE"].ToString() != "")
                {
                    model.N_INCLUTAX_NETPRICE = decimal.Parse(row["N_INCLUTAX_NETPRICE"].ToString());
                }
                if (row["C_CGC"] != null)
                {
                    model.C_CGC = row["C_CGC"].ToString();
                }
                if (row["C_CGAREA"] != null)
                {
                    model.C_CGAREA = row["C_CGAREA"].ToString();
                }
                if (row["C_CGADDR"] != null)
                {
                    model.C_CGADDR = row["C_CGADDR"].ToString();
                }
                if (row["C_ATSTATION"] != null)
                {
                    model.C_ATSTATION = row["C_ATSTATION"].ToString();
                }
                if (row["C_OTC"] != null)
                {
                    model.C_OTC = row["C_OTC"].ToString();
                }
                if (row["C_CURRENCY_TYPE"] != null)
                {
                    model.C_CURRENCY_TYPE = row["C_CURRENCY_TYPE"].ToString();
                }
                if (row["N_CELING_RATE"] != null && row["N_CELING_RATE"].ToString() != "")
                {
                    model.N_CELING_RATE = decimal.Parse(row["N_CELING_RATE"].ToString());
                }
                if (row["N_DC_NOTAX_UNITPRICE"] != null && row["N_DC_NOTAX_UNITPRICE"].ToString() != "")
                {
                    model.N_DC_NOTAX_UNITPRICE = decimal.Parse(row["N_DC_NOTAX_UNITPRICE"].ToString());
                }
                if (row["N_DC_INCLUTAX_UNITPRICE"] != null && row["N_DC_INCLUTAX_UNITPRICE"].ToString() != "")
                {
                    model.N_DC_INCLUTAX_UNITPRICE = decimal.Parse(row["N_DC_INCLUTAX_UNITPRICE"].ToString());
                }
                if (row["N_DC_AMOUNT_FAX"] != null && row["N_DC_AMOUNT_FAX"].ToString() != "")
                {
                    model.N_DC_AMOUNT_FAX = decimal.Parse(row["N_DC_AMOUNT_FAX"].ToString());
                }
                if (row["N_DC_PRICETAX_SUM"] != null && row["N_DC_PRICETAX_SUM"].ToString() != "")
                {
                    model.N_DC_PRICETAX_SUM = decimal.Parse(row["N_DC_PRICETAX_SUM"].ToString());
                }
                if (row["N_DELIVERY_ALLOWANCE"] != null && row["N_DELIVERY_ALLOWANCE"].ToString() != "")
                {
                    model.N_DELIVERY_ALLOWANCE = decimal.Parse(row["N_DELIVERY_ALLOWANCE"].ToString());
                }
                if (row["N_IS_DELIVERY_CLOSE"] != null && row["N_IS_DELIVERY_CLOSE"].ToString() != "")
                {
                    model.N_IS_DELIVERY_CLOSE = decimal.Parse(row["N_IS_DELIVERY_CLOSE"].ToString());
                }
                if (row["N_IS_OT_CLOSE"] != null && row["N_IS_OT_CLOSE"].ToString() != "")
                {
                    model.N_IS_OT_CLOSE = decimal.Parse(row["N_IS_OT_CLOSE"].ToString());
                }
                if (row["N_DIA"] != null && row["N_DIA"].ToString() != "")
                {
                    model.N_DIA = decimal.Parse(row["N_DIA"].ToString());
                }
                if (row["N_MACH_WGT"] != null && row["N_MACH_WGT"].ToString() != "")
                {
                    model.N_MACH_WGT = decimal.Parse(row["N_MACH_WGT"].ToString());
                }
                if (row["C_ISSUE_EMP_ID"] != null)
                {
                    model.C_ISSUE_EMP_ID = row["C_ISSUE_EMP_ID"].ToString();
                }
                if (row["C_PRD_EMP_ID"] != null)
                {
                    model.C_PRD_EMP_ID = row["C_PRD_EMP_ID"].ToString();
                }
                if (row["C_STD_CODE"] != null)
                {
                    model.C_STD_CODE = row["C_STD_CODE"].ToString();
                }
                if (row["C_DESIGN_NO"] != null)
                {
                    model.C_DESIGN_NO = row["C_DESIGN_NO"].ToString();
                }
                if (row["C_DESIGN_PROG"] != null)
                {
                    model.C_DESIGN_PROG = row["C_DESIGN_PROG"].ToString();
                }
                if (row["N_SLAB_MATCH_WGT"] != null && row["N_SLAB_MATCH_WGT"].ToString() != "")
                {
                    model.N_SLAB_MATCH_WGT = decimal.Parse(row["N_SLAB_MATCH_WGT"].ToString());
                }
                if (row["N_LINE_MATCH_WGT"] != null && row["N_LINE_MATCH_WGT"].ToString() != "")
                {
                    model.N_LINE_MATCH_WGT = decimal.Parse(row["N_LINE_MATCH_WGT"].ToString());
                }
                if (row["N_SMS_PROD_WGT"] != null && row["N_SMS_PROD_WGT"].ToString() != "")
                {
                    model.N_SMS_PROD_WGT = decimal.Parse(row["N_SMS_PROD_WGT"].ToString());
                }
                if (row["C_SMS_PROD_EMP_ID"] != null)
                {
                    model.C_SMS_PROD_EMP_ID = row["C_SMS_PROD_EMP_ID"].ToString();
                }
                if (row["D_SMS_PROD_DT"] != null && row["D_SMS_PROD_DT"].ToString() != "")
                {
                    model.D_SMS_PROD_DT = DateTime.Parse(row["D_SMS_PROD_DT"].ToString());
                }
                if (row["N_ROLL_PROD_WGT"] != null && row["N_ROLL_PROD_WGT"].ToString() != "")
                {
                    model.N_ROLL_PROD_WGT = decimal.Parse(row["N_ROLL_PROD_WGT"].ToString());
                }
                if (row["C_ROLL_PROD_EMP_ID"] != null)
                {
                    model.C_ROLL_PROD_EMP_ID = row["C_ROLL_PROD_EMP_ID"].ToString();
                }
                if (row["C_STL_ROL_DT"] != null && row["C_STL_ROL_DT"].ToString() != "")
                {
                    model.C_STL_ROL_DT = DateTime.Parse(row["C_STL_ROL_DT"].ToString());
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
                if (row["N_STATUS"] != null && row["N_STATUS"].ToString() != "")
                {
                    model.N_STATUS = decimal.Parse(row["N_STATUS"].ToString());
                }
                if (row["N_FLAG"] != null && row["N_FLAG"].ToString() != "")
                {
                    model.N_FLAG = decimal.Parse(row["N_FLAG"].ToString());
                }
                if (row["N_TYPE"] != null && row["N_TYPE"].ToString() != "")
                {
                    model.N_TYPE = decimal.Parse(row["N_TYPE"].ToString());
                }
                if (row["N_EXEC_STATUS"] != null && row["N_EXEC_STATUS"].ToString() != "")
                {
                    model.N_EXEC_STATUS = decimal.Parse(row["N_EXEC_STATUS"].ToString());
                }
                if (row["C_PACK"] != null)
                {
                    model.C_PACK = row["C_PACK"].ToString();
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
                if (row["C_XG_MODIFY"] != null)
                {
                    model.C_XG_MODIFY = row["C_XG_MODIFY"].ToString();
                }
                if (row["C_XG_MODEIFY_DT"] != null && row["C_XG_MODEIFY_DT"].ToString() != "")
                {
                    model.C_XG_MODEIFY_DT = DateTime.Parse(row["C_XG_MODEIFY_DT"].ToString());
                }
                if (row["C_LINE_NO"] != null)
                {
                    model.C_LINE_NO = row["C_LINE_NO"].ToString();
                }
                if (row["C_CCM_NO"] != null)
                {
                    model.C_CCM_NO = row["C_CCM_NO"].ToString();
                }
                if (row["C_REMARK"] != null)
                {
                    model.C_REMARK = row["C_REMARK"].ToString();
                }
                if (row["C_EMP_ID"] != null)
                {
                    model.C_EMP_ID = row["C_EMP_ID"].ToString();
                }
                if (row["C_EMP_NAME"] != null)
                {
                    model.C_EMP_NAME = row["C_EMP_NAME"].ToString();
                }
                if (row["D_MOD_DT"] != null && row["D_MOD_DT"].ToString() != "")
                {
                    model.D_MOD_DT = DateTime.Parse(row["D_MOD_DT"].ToString());
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
                if (row["C_FREE_TERM2"] != null)
                {
                    model.C_FREE_TERM2 = row["C_FREE_TERM2"].ToString();
                }
                if (row["C_SHIPVIA"] != null)
                {
                    model.C_SHIPVIA = row["C_SHIPVIA"].ToString();
                }
                if (row["C_PROD_NAME"] != null)
                {
                    model.C_PROD_NAME = row["C_PROD_NAME"].ToString();
                }
                if (row["C_PROD_KIND"] != null)
                {
                    model.C_PROD_KIND = row["C_PROD_KIND"].ToString();
                }
                if (row["C_LEV"] != null)
                {
                    model.C_LEV = row["C_LEV"].ToString();
                }
                if (row["C_ORDER_LEV"] != null)
                {
                    model.C_ORDER_LEV = row["C_ORDER_LEV"].ToString();
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
                if (row["C_CGID"] != null)
                {
                    model.C_CGID = row["C_CGID"].ToString();
                }
                if (row["C_OTCID"] != null)
                {
                    model.C_OTCID = row["C_OTCID"].ToString();
                }
                if (row["N_PRICE2"] != null && row["N_PRICE2"].ToString() != "")
                {
                    model.N_PRICE2 = decimal.Parse(row["N_PRICE2"].ToString());
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
                if (row["D_SYS_DELIVERY_DT"] != null && row["D_SYS_DELIVERY_DT"].ToString() != "")
                {
                    model.D_SYS_DELIVERY_DT = DateTime.Parse(row["D_SYS_DELIVERY_DT"].ToString());
                }
                if (row["C_CGMAN"] != null)
                {
                    model.C_CGMAN = row["C_CGMAN"].ToString();
                }
                if (row["C_CGMOBILE"] != null)
                {
                    model.C_CGMOBILE = row["C_CGMOBILE"].ToString();
                }
                if (row["C_DEPT_ID"] != null)
                {
                    model.C_DEPT_ID = row["C_DEPT_ID"].ToString();
                }
                if (row["C_SALE_EMP"] != null)
                {
                    model.C_SALE_EMP = row["C_SALE_EMP"].ToString();
                }
                if (row["C_APPROVER"] != null)
                {
                    model.C_APPROVER = row["C_APPROVER"].ToString();
                }
                if (row["D_APPROVER_DT"] != null && row["D_APPROVER_DT"].ToString() != "")
                {
                    model.D_APPROVER_DT = DateTime.Parse(row["D_APPROVER_DT"].ToString());
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
            strSql.Append("select C_NO,C_CON_NO,C_CON_NAME,C_AREA,C_MAT_CODE,C_MAT_NAME,C_TECH_PROT,C_SPEC,C_STL_GRD,C_AUXI,C_UNITIS,C_CUST_SQ,C_PRO_USE,D_NEED_DT,D_DELIVERY_DT,D_DT,C_FREE_TERM,C_EQUATION_FACTOR,N_NUM,N_WGT,N_NOTAX_UNITPRICE,N_TAX,N_NOMONEY,N_PRICETAX_SUM,N_DIS,N_AMOUNT_FAX,N_ITEM_DIS,N_NOTAX_NETPRICE,N_INCLUTAX_NETPRICE,C_CGC,C_CGAREA,C_CGADDR,C_ATSTATION,C_OTC,C_CURRENCY_TYPE,N_CELING_RATE,N_DC_NOTAX_UNITPRICE,N_DC_INCLUTAX_UNITPRICE,N_DC_AMOUNT_FAX,N_DC_PRICETAX_SUM,N_DELIVERY_ALLOWANCE,N_IS_DELIVERY_CLOSE,N_IS_OT_CLOSE,N_DIA,N_MACH_WGT,C_ISSUE_EMP_ID,C_PRD_EMP_ID,C_STD_CODE,C_DESIGN_NO,C_DESIGN_PROG,N_SLAB_MATCH_WGT,N_LINE_MATCH_WGT,N_SMS_PROD_WGT,C_SMS_PROD_EMP_ID,D_SMS_PROD_DT,N_ROLL_PROD_WGT,C_ROLL_PROD_EMP_ID,C_STL_ROL_DT,N_PROD_WGT,N_WARE_WGT,N_WARE_OUT_WGT,N_STATUS,N_FLAG,N_TYPE,N_EXEC_STATUS,C_PACK,N_USER_LEV,N_STL_GRD_LEV,N_ORDER_LEV,C_QUALIRY_LEV,C_XG_MODIFY,C_XG_MODEIFY_DT,C_LINE_NO,C_CCM_NO,C_REMARK,C_EMP_ID,C_EMP_NAME,D_MOD_DT,N_ISSUE_WGT,C_CUST_NO,C_CUST_NAME,C_SALE_CHANNEL,C_FREE_TERM2,C_SHIPVIA,C_PROD_NAME,C_PROD_KIND,C_LEV,C_ORDER_LEV,C_RH,C_LF,C_KP,N_HL_TIME,C_HL,N_DFP_HL_TIME,C_DFP_HL,C_XM,C_CGID,C_OTCID,N_PRICE2,C_EXTEND1,C_EXTEND2,C_EXTEND3,C_EXTEND4,D_SYS_DELIVERY_DT,C_CGMAN,C_CGMOBILE,C_DEPT_ID,C_SALE_EMP,C_APPROVER,D_APPROVER_DT ");
            strSql.Append(" FROM TMO_CONDETAILS ");
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
            strSql.Append("select count(1) FROM TMO_CONDETAILS ");
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
                strSql.Append("order by T.C_NO desc");
            }
            strSql.Append(")AS Row, T.*  from TMO_CONDETAILS T ");
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
        /// 变更订单明细状态
        /// </summary>
        public bool UpByNo(string C_NO)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TMO_CONDETAILS set N_EXEC_STATUS=1");
            strSql.Append(" where C_NO='"+ C_NO + "'");
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
        #endregion  ExtensionMethod
    }
}
