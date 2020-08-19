using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;
namespace DAL
{
	/// <summary>
	/// 数据访问类:TRP_PLAN_ITEM_TEST
	/// </summary>
	public partial class Dal_TRP_PLAN_ITEM_TEST
    {
		public Dal_TRP_PLAN_ITEM_TEST()
		{}

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete_Trans()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from TRP_PLAN_ITEM_TEST t ");

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
        /// 增加一条数据
        /// </summary>
        public bool Add_Trans(Mod_TRP_PLAN_ITEM_TEST model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TRP_PLAN_ITEM_TEST(");
            strSql.Append("C_PLAN_ROLL_ID,N_STATUS,C_INITIALIZE_ITEM_ID,C_ORDER_NO,N_WGT,C_MAT_CODE,C_MAT_NAME,C_TECH_PROT,C_SPEC,C_STL_GRD,C_STD_CODE,N_USER_LEV,N_STL_GRD_LEV,N_ORDER_LEV,C_QUALIRY_LEV,D_NEED_DT,D_DELIVERY_DT,D_DT,C_LINE_DESC,C_LINE_CODE,D_P_START_TIME,D_P_END_TIME,N_PROD_TIME,N_SORT,N_ROLL_PROD_WGT,C_ROLL_PROD_EMP_ID,C_STL_ROL_DT,N_PROD_WGT,N_WARE_WGT,N_WARE_OUT_WGT,N_FLAG,N_ISSUE_WGT,C_CUST_NO,C_CUST_NAME,C_SALE_CHANNEL,C_PACK,C_DESIGN_NO,N_GROUP_WGT,C_STA_ID,D_START_TIME,D_END_TIME,C_EMP_ID,N_ROLL_WGT,N_MACH_WGT,C_CAST_NO,C_INITIALIZE_ID,C_FREE_TERM,C_FREE_TERM2,C_AREA,C_PCLX,C_SFHL,D_HL_START_TIME,D_HL_END_TIME,C_SFHL_D,D_DHL_START_TIME,D_DHL_END_TIME,C_SFKP,D_KP_START_TIME,D_KP_END_TIME,C_SFXM,D_XM_START_TIME,D_XM_END_TIME,N_UPLOADSTATUS,C_MATRL_CODE_SLAB,C_MATRL_NAME_SLAB,C_SLAB_SIZE,N_SLAB_LENGTH,N_SLAB_PW,D_CAN_ROLL_TIME,C_ROUTE,N_DIAMETER,C_XM_YQ,N_JRL_WD,N_JRL_SJ,C_STL_GRD_SLAB,C_STD_CODE_SLAB)");
            strSql.Append(" values (");
            strSql.Append(":C_PLAN_ROLL_ID,:N_STATUS,:C_INITIALIZE_ITEM_ID,:C_ORDER_NO,:N_WGT,:C_MAT_CODE,:C_MAT_NAME,:C_TECH_PROT,:C_SPEC,:C_STL_GRD,:C_STD_CODE,:N_USER_LEV,:N_STL_GRD_LEV,:N_ORDER_LEV,:C_QUALIRY_LEV,:D_NEED_DT,:D_DELIVERY_DT,:D_DT,:C_LINE_DESC,:C_LINE_CODE,:D_P_START_TIME,:D_P_END_TIME,:N_PROD_TIME,:N_SORT,:N_ROLL_PROD_WGT,:C_ROLL_PROD_EMP_ID,:C_STL_ROL_DT,:N_PROD_WGT,:N_WARE_WGT,:N_WARE_OUT_WGT,:N_FLAG,:N_ISSUE_WGT,:C_CUST_NO,:C_CUST_NAME,:C_SALE_CHANNEL,:C_PACK,:C_DESIGN_NO,:N_GROUP_WGT,:C_STA_ID,:D_START_TIME,:D_END_TIME,:C_EMP_ID,:N_ROLL_WGT,:N_MACH_WGT,:C_CAST_NO,:C_INITIALIZE_ID,:C_FREE_TERM,:C_FREE_TERM2,:C_AREA,:C_PCLX,:C_SFHL,:D_HL_START_TIME,:D_HL_END_TIME,:C_SFHL_D,:D_DHL_START_TIME,:D_DHL_END_TIME,:C_SFKP,:D_KP_START_TIME,:D_KP_END_TIME,:C_SFXM,:D_XM_START_TIME,:D_XM_END_TIME,:N_UPLOADSTATUS,:C_MATRL_CODE_SLAB,:C_MATRL_NAME_SLAB,:C_SLAB_SIZE,:N_SLAB_LENGTH,:N_SLAB_PW,:D_CAN_ROLL_TIME,:C_ROUTE,:N_DIAMETER,:C_XM_YQ,:N_JRL_WD,:N_JRL_SJ,:C_STL_GRD_SLAB,:C_STD_CODE_SLAB)");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_PLAN_ROLL_ID", OracleDbType.Varchar2,100),
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
                    new OracleParameter(":N_ROLL_PROD_WGT", OracleDbType.Decimal,5),
                    new OracleParameter(":C_ROLL_PROD_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STL_ROL_DT", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_PROD_WGT", OracleDbType.Decimal,5),
                    new OracleParameter(":N_WARE_WGT", OracleDbType.Decimal,5),
                    new OracleParameter(":N_WARE_OUT_WGT", OracleDbType.Decimal,5),
                    new OracleParameter(":N_FLAG", OracleDbType.Decimal,5),
                    new OracleParameter(":N_ISSUE_WGT", OracleDbType.Decimal,5),
                    new OracleParameter(":C_CUST_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CUST_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SALE_CHANNEL", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PACK", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_DESIGN_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_GROUP_WGT", OracleDbType.Decimal,5),
                    new OracleParameter(":C_STA_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_START_TIME", OracleDbType.Date),
                    new OracleParameter(":D_END_TIME", OracleDbType.Date),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_ROLL_WGT", OracleDbType.Decimal,5),
                    new OracleParameter(":N_MACH_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":C_CAST_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_INITIALIZE_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_FREE_TERM", OracleDbType.Varchar2,300),
                    new OracleParameter(":C_FREE_TERM2", OracleDbType.Varchar2,300),
                    new OracleParameter(":C_AREA", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PCLX", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_SFHL", OracleDbType.Varchar2,10),
                    new OracleParameter(":D_HL_START_TIME", OracleDbType.Date),
                    new OracleParameter(":D_HL_END_TIME", OracleDbType.Date),
                    new OracleParameter(":C_SFHL_D", OracleDbType.Varchar2,10),
                    new OracleParameter(":D_DHL_START_TIME", OracleDbType.Date),
                    new OracleParameter(":D_DHL_END_TIME", OracleDbType.Date),
                    new OracleParameter(":C_SFKP", OracleDbType.Varchar2,10),
                    new OracleParameter(":D_KP_START_TIME", OracleDbType.Date),
                    new OracleParameter(":D_KP_END_TIME", OracleDbType.Date),
                    new OracleParameter(":C_SFXM", OracleDbType.Varchar2,10),
                    new OracleParameter(":D_XM_START_TIME", OracleDbType.Date),
                    new OracleParameter(":D_XM_END_TIME", OracleDbType.Date),
                    new OracleParameter(":N_UPLOADSTATUS", OracleDbType.Decimal,1),
                    new OracleParameter(":C_MATRL_CODE_SLAB", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MATRL_NAME_SLAB", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SLAB_SIZE", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_SLAB_LENGTH", OracleDbType.Decimal,15),
                    new OracleParameter(":N_SLAB_PW", OracleDbType.Decimal,15),
                    new OracleParameter(":D_CAN_ROLL_TIME", OracleDbType.Date),
                    new OracleParameter(":C_ROUTE", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_DIAMETER", OracleDbType.Decimal,4),
                    new OracleParameter(":C_XM_YQ", OracleDbType.Varchar2,1000),
                    new OracleParameter(":N_JRL_WD", OracleDbType.Decimal,10),
                    new OracleParameter(":N_JRL_SJ", OracleDbType.Decimal,10),
                    new OracleParameter(":C_STL_GRD_SLAB", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STD_CODE_SLAB", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.C_PLAN_ROLL_ID;
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
            parameters[42].Value = model.N_ROLL_WGT;
            parameters[43].Value = model.N_MACH_WGT;
            parameters[44].Value = model.C_CAST_NO;
            parameters[45].Value = model.C_INITIALIZE_ID;
            parameters[46].Value = model.C_FREE_TERM;
            parameters[47].Value = model.C_FREE_TERM2;
            parameters[48].Value = model.C_AREA;
            parameters[49].Value = model.C_PCLX;
            parameters[50].Value = model.C_SFHL;
            parameters[51].Value = model.D_HL_START_TIME;
            parameters[52].Value = model.D_HL_END_TIME;
            parameters[53].Value = model.C_SFHL_D;
            parameters[54].Value = model.D_DHL_START_TIME;
            parameters[55].Value = model.D_DHL_END_TIME;
            parameters[56].Value = model.C_SFKP;
            parameters[57].Value = model.D_KP_START_TIME;
            parameters[58].Value = model.D_KP_END_TIME;
            parameters[59].Value = model.C_SFXM;
            parameters[60].Value = model.D_XM_START_TIME;
            parameters[61].Value = model.D_XM_END_TIME;
            parameters[62].Value = model.N_UPLOADSTATUS;
            parameters[63].Value = model.C_MATRL_CODE_SLAB;
            parameters[64].Value = model.C_MATRL_NAME_SLAB;
            parameters[65].Value = model.C_SLAB_SIZE;
            parameters[66].Value = model.N_SLAB_LENGTH;
            parameters[67].Value = model.N_SLAB_PW;
            parameters[68].Value = model.D_CAN_ROLL_TIME;
            parameters[69].Value = model.C_ROUTE;
            parameters[70].Value = model.N_DIAMETER;
            parameters[71].Value = model.C_XM_YQ;
            parameters[72].Value = model.N_JRL_WD;
            parameters[73].Value = model.N_JRL_SJ;
            parameters[74].Value = model.C_STL_GRD_SLAB;
            parameters[75].Value = model.C_STD_CODE_SLAB;

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
        /// 得到一个对象实体
        /// </summary>
        public Mod_TRP_PLAN_ITEM_TEST DataRowToModel(DataRow row)
        {
            Mod_TRP_PLAN_ITEM_TEST model = new Mod_TRP_PLAN_ITEM_TEST();
            if (row != null)
            {
                if (row["C_ID"] != null)
                {
                    model.C_ID = row["C_ID"].ToString();
                }
                if (row["C_PLAN_ROLL_ID"] != null)
                {
                    model.C_PLAN_ROLL_ID = row["C_PLAN_ROLL_ID"].ToString();
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
                if (row["C_SFHL"] != null)
                {
                    model.C_SFHL = row["C_SFHL"].ToString();
                }
                if (row["D_HL_START_TIME"] != null && row["D_HL_START_TIME"].ToString() != "")
                {
                    model.D_HL_START_TIME = DateTime.Parse(row["D_HL_START_TIME"].ToString());
                }
                if (row["D_HL_END_TIME"] != null && row["D_HL_END_TIME"].ToString() != "")
                {
                    model.D_HL_END_TIME = DateTime.Parse(row["D_HL_END_TIME"].ToString());
                }
                if (row["C_SFHL_D"] != null)
                {
                    model.C_SFHL_D = row["C_SFHL_D"].ToString();
                }
                if (row["D_DHL_START_TIME"] != null && row["D_DHL_START_TIME"].ToString() != "")
                {
                    model.D_DHL_START_TIME = DateTime.Parse(row["D_DHL_START_TIME"].ToString());
                }
                if (row["D_DHL_END_TIME"] != null && row["D_DHL_END_TIME"].ToString() != "")
                {
                    model.D_DHL_END_TIME = DateTime.Parse(row["D_DHL_END_TIME"].ToString());
                }
                if (row["C_SFKP"] != null)
                {
                    model.C_SFKP = row["C_SFKP"].ToString();
                }
                if (row["D_KP_START_TIME"] != null && row["D_KP_START_TIME"].ToString() != "")
                {
                    model.D_KP_START_TIME = DateTime.Parse(row["D_KP_START_TIME"].ToString());
                }
                if (row["D_KP_END_TIME"] != null && row["D_KP_END_TIME"].ToString() != "")
                {
                    model.D_KP_END_TIME = DateTime.Parse(row["D_KP_END_TIME"].ToString());
                }
                if (row["C_SFXM"] != null)
                {
                    model.C_SFXM = row["C_SFXM"].ToString();
                }
                if (row["D_XM_START_TIME"] != null && row["D_XM_START_TIME"].ToString() != "")
                {
                    model.D_XM_START_TIME = DateTime.Parse(row["D_XM_START_TIME"].ToString());
                }
                if (row["D_XM_END_TIME"] != null && row["D_XM_END_TIME"].ToString() != "")
                {
                    model.D_XM_END_TIME = DateTime.Parse(row["D_XM_END_TIME"].ToString());
                }
                if (row["N_UPLOADSTATUS"] != null && row["N_UPLOADSTATUS"].ToString() != "")
                {
                    model.N_UPLOADSTATUS = decimal.Parse(row["N_UPLOADSTATUS"].ToString());
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
                if (row["D_CAN_ROLL_TIME"] != null && row["D_CAN_ROLL_TIME"].ToString() != "")
                {
                    model.D_CAN_ROLL_TIME = DateTime.Parse(row["D_CAN_ROLL_TIME"].ToString());
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
                if (row["C_STL_GRD_SLAB"] != null)
                {
                    model.C_STL_GRD_SLAB = row["C_STL_GRD_SLAB"].ToString();
                }
                if (row["C_STD_CODE_SLAB"] != null)
                {
                    model.C_STD_CODE_SLAB = row["C_STD_CODE_SLAB"].ToString();
                }
            }
            return model;
        }


        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_PLAN_ROLL_ID,N_STATUS,C_INITIALIZE_ITEM_ID,C_ORDER_NO,N_WGT,C_MAT_CODE,C_MAT_NAME,C_TECH_PROT,C_SPEC,C_STL_GRD,C_STD_CODE,N_USER_LEV,N_STL_GRD_LEV,N_ORDER_LEV,C_QUALIRY_LEV,D_NEED_DT,D_DELIVERY_DT,D_DT,C_LINE_DESC,C_LINE_CODE,D_P_START_TIME,D_P_END_TIME,N_PROD_TIME,N_SORT,N_ROLL_PROD_WGT,C_ROLL_PROD_EMP_ID,C_STL_ROL_DT,N_PROD_WGT,N_WARE_WGT,N_WARE_OUT_WGT,N_FLAG,N_ISSUE_WGT,C_CUST_NO,C_CUST_NAME,C_SALE_CHANNEL,C_PACK,C_DESIGN_NO,N_GROUP_WGT,C_STA_ID,D_START_TIME,D_END_TIME,C_EMP_ID,D_MOD_DT,N_ROLL_WGT,N_MACH_WGT,C_CAST_NO,C_INITIALIZE_ID,C_FREE_TERM,C_FREE_TERM2,C_AREA,C_PCLX,C_SFHL,D_HL_START_TIME,D_HL_END_TIME,C_SFHL_D,D_DHL_START_TIME,D_DHL_END_TIME,C_SFKP,D_KP_START_TIME,D_KP_END_TIME,C_SFXM,D_XM_START_TIME,D_XM_END_TIME,N_UPLOADSTATUS,C_MATRL_CODE_SLAB,C_MATRL_NAME_SLAB,C_SLAB_SIZE,N_SLAB_LENGTH,N_SLAB_PW,D_CAN_ROLL_TIME,C_ROUTE,N_DIAMETER,C_XM_YQ,N_JRL_WD,N_JRL_SJ,C_STL_GRD_SLAB,C_STD_CODE_SLAB ");
            strSql.Append(" FROM TRP_PLAN_ITEM_TEST ");

            return DbHelperOra.Query(strSql.ToString());
        }
    }
}

