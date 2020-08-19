using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;
namespace DAL
{
    /// <summary>
    /// 数据访问类:TMD_DISPATCHDETAILS
    /// </summary>
    public partial class Dal_TMD_DISPATCHDETAILS
    {
        public Dal_TMD_DISPATCHDETAILS()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string C_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TMD_DISPATCHDETAILS");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)         };
            parameters[0].Value = C_ID;

            return DbHelperOra.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Mod_TMD_DISPATCHDETAILS model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TMD_DISPATCHDETAILS(");
            strSql.Append("C_ID,C_DISPATCH_ID,C_STOVE,C_BATCH_NO,C_TICK_NO,C_SLAB_NO,C_MAT_CODE,C_MAT_NAME,C_SPEC,C_STL_GRD,C_SEND_STOCK,C_QUALIRY_LEV,C_FREE_TERM,C_ELSENEED,N_COM_AMOUNT_WGT,N_WGT,C_EQUATION_FACTOR,N_OUT_STOCK_WGT,C_UNITIS,C_SEND_SITE,C_AOG_SITE,C_ORGO_CUST,C_CGC,N_IS_SEND_CLOSE,C_ORDER_TYPE,C_SEND_AREA,C_AREA,C_AU_UNITIS,C_CUSTFILE_ID,C_CUST_ID,C_REMARK,C_MZDATE,N_MWGT,N_PWGT,N_JWGT,N_MZTIME,N_PZTIME,C_EMP_ID,C_EMP_NAME,D_MOD_DT,C_CON_NO,C_PLAN_ID,C_PLAN_CODE,C_PK_NCID,C_NO,C_STD_CODE,C_JUDGE_LEV_ZH,C_PRODUCT_ID,C_FREE_TERM2,C_PACK,C_PZDATE)");
            strSql.Append(" values (");
            strSql.Append(":C_ID,:C_DISPATCH_ID,:C_STOVE,:C_BATCH_NO,:C_TICK_NO,:C_SLAB_NO,:C_MAT_CODE,:C_MAT_NAME,:C_SPEC,:C_STL_GRD,:C_SEND_STOCK,:C_QUALIRY_LEV,:C_FREE_TERM,:C_ELSENEED,:N_COM_AMOUNT_WGT,:N_WGT,:C_EQUATION_FACTOR,:N_OUT_STOCK_WGT,:C_UNITIS,:C_SEND_SITE,:C_AOG_SITE,:C_ORGO_CUST,:C_CGC,:N_IS_SEND_CLOSE,:C_ORDER_TYPE,:C_SEND_AREA,:C_AREA,:C_AU_UNITIS,:C_CUSTFILE_ID,:C_CUST_ID,:C_REMARK,:C_MZDATE,:N_MWGT,:N_PWGT,:N_JWGT,:N_MZTIME,:N_PZTIME,:C_EMP_ID,:C_EMP_NAME,:D_MOD_DT,:C_CON_NO,:C_PLAN_ID,:C_PLAN_CODE,:C_PK_NCID,:C_NO,:C_STD_CODE,:C_JUDGE_LEV_ZH,:C_PRODUCT_ID,:C_FREE_TERM2,:C_PACK,:C_PZDATE)");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_DISPATCH_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STOVE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_BATCH_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_TICK_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SLAB_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MAT_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MAT_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SPEC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STL_GRD", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SEND_STOCK", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_QUALIRY_LEV", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_FREE_TERM", OracleDbType.Varchar2,300),
                    new OracleParameter(":C_ELSENEED", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_COM_AMOUNT_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":N_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":C_EQUATION_FACTOR", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_OUT_STOCK_WGT", OracleDbType.Decimal,6),
                    new OracleParameter(":C_UNITIS", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SEND_SITE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_AOG_SITE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ORGO_CUST", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CGC", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_IS_SEND_CLOSE", OracleDbType.Decimal,1),
                    new OracleParameter(":C_ORDER_TYPE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SEND_AREA", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_AREA", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_AU_UNITIS", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CUSTFILE_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CUST_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_MZDATE", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_MWGT", OracleDbType.Decimal,15),
                    new OracleParameter(":N_PWGT", OracleDbType.Decimal,15),
                    new OracleParameter(":N_JWGT", OracleDbType.Decimal,15),
                    new OracleParameter(":N_MZTIME", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_PZTIME", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_EMP_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":C_CON_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PLAN_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PLAN_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PK_NCID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STD_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_JUDGE_LEV_ZH", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PRODUCT_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_FREE_TERM2", OracleDbType.Varchar2,300),
                    new OracleParameter(":C_PACK", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PZDATE", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.C_ID;
            parameters[1].Value = model.C_DISPATCH_ID;
            parameters[2].Value = model.C_STOVE;
            parameters[3].Value = model.C_BATCH_NO;
            parameters[4].Value = model.C_TICK_NO;
            parameters[5].Value = model.C_SLAB_NO;
            parameters[6].Value = model.C_MAT_CODE;
            parameters[7].Value = model.C_MAT_NAME;
            parameters[8].Value = model.C_SPEC;
            parameters[9].Value = model.C_STL_GRD;
            parameters[10].Value = model.C_SEND_STOCK;
            parameters[11].Value = model.C_QUALIRY_LEV;
            parameters[12].Value = model.C_FREE_TERM;
            parameters[13].Value = model.C_ELSENEED;
            parameters[14].Value = model.N_COM_AMOUNT_WGT;
            parameters[15].Value = model.N_WGT;
            parameters[16].Value = model.C_EQUATION_FACTOR;
            parameters[17].Value = model.N_OUT_STOCK_WGT;
            parameters[18].Value = model.C_UNITIS;
            parameters[19].Value = model.C_SEND_SITE;
            parameters[20].Value = model.C_AOG_SITE;
            parameters[21].Value = model.C_ORGO_CUST;
            parameters[22].Value = model.C_CGC;
            parameters[23].Value = model.N_IS_SEND_CLOSE;
            parameters[24].Value = model.C_ORDER_TYPE;
            parameters[25].Value = model.C_SEND_AREA;
            parameters[26].Value = model.C_AREA;
            parameters[27].Value = model.C_AU_UNITIS;
            parameters[28].Value = model.C_CUSTFILE_ID;
            parameters[29].Value = model.C_CUST_ID;
            parameters[30].Value = model.C_REMARK;
            parameters[31].Value = model.C_MZDATE;
            parameters[32].Value = model.N_MWGT;
            parameters[33].Value = model.N_PWGT;
            parameters[34].Value = model.N_JWGT;
            parameters[35].Value = model.N_MZTIME;
            parameters[36].Value = model.N_PZTIME;
            parameters[37].Value = model.C_EMP_ID;
            parameters[38].Value = model.C_EMP_NAME;
            parameters[39].Value = model.D_MOD_DT;
            parameters[40].Value = model.C_CON_NO;
            parameters[41].Value = model.C_PLAN_ID;
            parameters[42].Value = model.C_PLAN_CODE;
            parameters[43].Value = model.C_PK_NCID;
            parameters[44].Value = model.C_NO;
            parameters[45].Value = model.C_STD_CODE;
            parameters[46].Value = model.C_JUDGE_LEV_ZH;
            parameters[47].Value = model.C_PRODUCT_ID;
            parameters[48].Value = model.C_FREE_TERM2;
            parameters[49].Value = model.C_PACK;
            parameters[50].Value = model.C_PZDATE;

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
        public bool Update(Mod_TMD_DISPATCHDETAILS model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TMD_DISPATCHDETAILS set ");
            strSql.Append("C_DISPATCH_ID=:C_DISPATCH_ID,");
            strSql.Append("C_STOVE=:C_STOVE,");
            strSql.Append("C_BATCH_NO=:C_BATCH_NO,");
            strSql.Append("C_TICK_NO=:C_TICK_NO,");
            strSql.Append("C_SLAB_NO=:C_SLAB_NO,");
            strSql.Append("C_MAT_CODE=:C_MAT_CODE,");
            strSql.Append("C_MAT_NAME=:C_MAT_NAME,");
            strSql.Append("C_SPEC=:C_SPEC,");
            strSql.Append("C_STL_GRD=:C_STL_GRD,");
            strSql.Append("C_SEND_STOCK=:C_SEND_STOCK,");
            strSql.Append("C_QUALIRY_LEV=:C_QUALIRY_LEV,");
            strSql.Append("C_FREE_TERM=:C_FREE_TERM,");
            strSql.Append("C_ELSENEED=:C_ELSENEED,");
            strSql.Append("N_COM_AMOUNT_WGT=:N_COM_AMOUNT_WGT,");
            strSql.Append("N_WGT=:N_WGT,");
            strSql.Append("C_EQUATION_FACTOR=:C_EQUATION_FACTOR,");
            strSql.Append("N_OUT_STOCK_WGT=:N_OUT_STOCK_WGT,");
            strSql.Append("C_UNITIS=:C_UNITIS,");
            strSql.Append("C_SEND_SITE=:C_SEND_SITE,");
            strSql.Append("C_AOG_SITE=:C_AOG_SITE,");
            strSql.Append("C_ORGO_CUST=:C_ORGO_CUST,");
            strSql.Append("C_CGC=:C_CGC,");
            strSql.Append("N_IS_SEND_CLOSE=:N_IS_SEND_CLOSE,");
            strSql.Append("C_ORDER_TYPE=:C_ORDER_TYPE,");
            strSql.Append("C_SEND_AREA=:C_SEND_AREA,");
            strSql.Append("C_AREA=:C_AREA,");
            strSql.Append("C_AU_UNITIS=:C_AU_UNITIS,");
            strSql.Append("C_CUSTFILE_ID=:C_CUSTFILE_ID,");
            strSql.Append("C_CUST_ID=:C_CUST_ID,");
            strSql.Append("C_REMARK=:C_REMARK,");
            strSql.Append("C_MZDATE=:C_MZDATE,");
            strSql.Append("N_MWGT=:N_MWGT,");
            strSql.Append("N_PWGT=:N_PWGT,");
            strSql.Append("N_JWGT=:N_JWGT,");
            strSql.Append("N_MZTIME=:N_MZTIME,");
            strSql.Append("N_PZTIME=:N_PZTIME,");
            strSql.Append("C_EMP_ID=:C_EMP_ID,");
            strSql.Append("C_EMP_NAME=:C_EMP_NAME,");
            strSql.Append("D_MOD_DT=:D_MOD_DT,");
            strSql.Append("C_CON_NO=:C_CON_NO,");
            strSql.Append("C_PLAN_ID=:C_PLAN_ID,");
            strSql.Append("C_PLAN_CODE=:C_PLAN_CODE,");
            strSql.Append("C_PK_NCID=:C_PK_NCID,");
            strSql.Append("C_NO=:C_NO,");
            strSql.Append("C_STD_CODE=:C_STD_CODE,");
            strSql.Append("C_JUDGE_LEV_ZH=:C_JUDGE_LEV_ZH,");
            strSql.Append("C_PRODUCT_ID=:C_PRODUCT_ID,");
            strSql.Append("C_FREE_TERM2=:C_FREE_TERM2,");
            strSql.Append("C_PACK=:C_PACK,");
            strSql.Append("C_PZDATE=:C_PZDATE");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_DISPATCH_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STOVE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_BATCH_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_TICK_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SLAB_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MAT_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MAT_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SPEC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STL_GRD", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SEND_STOCK", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_QUALIRY_LEV", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_FREE_TERM", OracleDbType.Varchar2,300),
                    new OracleParameter(":C_ELSENEED", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_COM_AMOUNT_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":N_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":C_EQUATION_FACTOR", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_OUT_STOCK_WGT", OracleDbType.Decimal,6),
                    new OracleParameter(":C_UNITIS", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SEND_SITE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_AOG_SITE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ORGO_CUST", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CGC", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_IS_SEND_CLOSE", OracleDbType.Decimal,1),
                    new OracleParameter(":C_ORDER_TYPE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SEND_AREA", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_AREA", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_AU_UNITIS", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CUSTFILE_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CUST_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_MZDATE", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_MWGT", OracleDbType.Decimal,15),
                    new OracleParameter(":N_PWGT", OracleDbType.Decimal,15),
                    new OracleParameter(":N_JWGT", OracleDbType.Decimal,15),
                    new OracleParameter(":N_MZTIME", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_PZTIME", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_EMP_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":C_CON_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PLAN_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PLAN_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PK_NCID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STD_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_JUDGE_LEV_ZH", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PRODUCT_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_FREE_TERM2", OracleDbType.Varchar2,300),
                    new OracleParameter(":C_PACK", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PZDATE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.C_DISPATCH_ID;
            parameters[1].Value = model.C_STOVE;
            parameters[2].Value = model.C_BATCH_NO;
            parameters[3].Value = model.C_TICK_NO;
            parameters[4].Value = model.C_SLAB_NO;
            parameters[5].Value = model.C_MAT_CODE;
            parameters[6].Value = model.C_MAT_NAME;
            parameters[7].Value = model.C_SPEC;
            parameters[8].Value = model.C_STL_GRD;
            parameters[9].Value = model.C_SEND_STOCK;
            parameters[10].Value = model.C_QUALIRY_LEV;
            parameters[11].Value = model.C_FREE_TERM;
            parameters[12].Value = model.C_ELSENEED;
            parameters[13].Value = model.N_COM_AMOUNT_WGT;
            parameters[14].Value = model.N_WGT;
            parameters[15].Value = model.C_EQUATION_FACTOR;
            parameters[16].Value = model.N_OUT_STOCK_WGT;
            parameters[17].Value = model.C_UNITIS;
            parameters[18].Value = model.C_SEND_SITE;
            parameters[19].Value = model.C_AOG_SITE;
            parameters[20].Value = model.C_ORGO_CUST;
            parameters[21].Value = model.C_CGC;
            parameters[22].Value = model.N_IS_SEND_CLOSE;
            parameters[23].Value = model.C_ORDER_TYPE;
            parameters[24].Value = model.C_SEND_AREA;
            parameters[25].Value = model.C_AREA;
            parameters[26].Value = model.C_AU_UNITIS;
            parameters[27].Value = model.C_CUSTFILE_ID;
            parameters[28].Value = model.C_CUST_ID;
            parameters[29].Value = model.C_REMARK;
            parameters[30].Value = model.C_MZDATE;
            parameters[31].Value = model.N_MWGT;
            parameters[32].Value = model.N_PWGT;
            parameters[33].Value = model.N_JWGT;
            parameters[34].Value = model.N_MZTIME;
            parameters[35].Value = model.N_PZTIME;
            parameters[36].Value = model.C_EMP_ID;
            parameters[37].Value = model.C_EMP_NAME;
            parameters[38].Value = model.D_MOD_DT;
            parameters[39].Value = model.C_CON_NO;
            parameters[40].Value = model.C_PLAN_ID;
            parameters[41].Value = model.C_PLAN_CODE;
            parameters[42].Value = model.C_PK_NCID;
            parameters[43].Value = model.C_NO;
            parameters[44].Value = model.C_STD_CODE;
            parameters[45].Value = model.C_JUDGE_LEV_ZH;
            parameters[46].Value = model.C_PRODUCT_ID;
            parameters[47].Value = model.C_FREE_TERM2;
            parameters[48].Value = model.C_PACK;
            parameters[49].Value = model.C_PZDATE;
            parameters[50].Value = model.C_ID;

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
            strSql.Append("delete from TMD_DISPATCHDETAILS ");
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
            strSql.Append("delete from TMD_DISPATCHDETAILS ");
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
        public Mod_TMD_DISPATCHDETAILS GetModel(string C_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_DISPATCH_ID,C_STOVE,C_BATCH_NO,C_TICK_NO,C_SLAB_NO,C_MAT_CODE,C_MAT_NAME,C_SPEC,C_STL_GRD,C_SEND_STOCK,C_QUALIRY_LEV,C_FREE_TERM,C_ELSENEED,N_COM_AMOUNT_WGT,N_WGT,C_EQUATION_FACTOR,N_OUT_STOCK_WGT,C_UNITIS,C_SEND_SITE,C_AOG_SITE,C_ORGO_CUST,C_CGC,N_IS_SEND_CLOSE,C_ORDER_TYPE,C_SEND_AREA,C_AREA,C_AU_UNITIS,C_CUSTFILE_ID,C_CUST_ID,C_REMARK,C_MZDATE,N_MWGT,N_PWGT,N_JWGT,N_MZTIME,N_PZTIME,C_EMP_ID,C_EMP_NAME,D_MOD_DT,C_CON_NO,C_PLAN_ID,C_PLAN_CODE,C_PK_NCID,C_NO,C_STD_CODE,C_JUDGE_LEV_ZH,C_PRODUCT_ID,C_FREE_TERM2,C_PACK,C_PZDATE,C_ORDERPK,C_CUSTNO,N_FYZS,N_FYWGT,C_SEND_STOCK_PK,C_SEND_STOCK_CODE from TMD_DISPATCHDETAILS ");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)         };
            parameters[0].Value = C_ID;

            Mod_TMD_DISPATCHDETAILS model = new Mod_TMD_DISPATCHDETAILS();
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
        public Mod_TMD_DISPATCHDETAILS DataRowToModel(DataRow row)
        {
            Mod_TMD_DISPATCHDETAILS model = new Mod_TMD_DISPATCHDETAILS();
            if (row != null)
            {
                if (row["C_ID"] != null)
                {
                    model.C_ID = row["C_ID"].ToString();
                }
                if (row["C_DISPATCH_ID"] != null)
                {
                    model.C_DISPATCH_ID = row["C_DISPATCH_ID"].ToString();
                }
                if (row["C_STOVE"] != null)
                {
                    model.C_STOVE = row["C_STOVE"].ToString();
                }
                if (row["C_BATCH_NO"] != null)
                {
                    model.C_BATCH_NO = row["C_BATCH_NO"].ToString();
                }
                if (row["C_TICK_NO"] != null)
                {
                    model.C_TICK_NO = row["C_TICK_NO"].ToString();
                }
                if (row["C_SLAB_NO"] != null)
                {
                    model.C_SLAB_NO = row["C_SLAB_NO"].ToString();
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
                if (row["C_SEND_STOCK"] != null)
                {
                    model.C_SEND_STOCK = row["C_SEND_STOCK"].ToString();
                }
                if (row["C_QUALIRY_LEV"] != null)
                {
                    model.C_QUALIRY_LEV = row["C_QUALIRY_LEV"].ToString();
                }
                if (row["C_FREE_TERM"] != null)
                {
                    model.C_FREE_TERM = row["C_FREE_TERM"].ToString();
                }
                if (row["C_ELSENEED"] != null)
                {
                    model.C_ELSENEED = row["C_ELSENEED"].ToString();
                }
                if (row["N_COM_AMOUNT_WGT"] != null && row["N_COM_AMOUNT_WGT"].ToString() != "")
                {
                    model.N_COM_AMOUNT_WGT = decimal.Parse(row["N_COM_AMOUNT_WGT"].ToString());
                }
                if (row["N_WGT"] != null && row["N_WGT"].ToString() != "")
                {
                    model.N_WGT = decimal.Parse(row["N_WGT"].ToString());
                }
                if (row["C_EQUATION_FACTOR"] != null)
                {
                    model.C_EQUATION_FACTOR = row["C_EQUATION_FACTOR"].ToString();
                }
                if (row["N_OUT_STOCK_WGT"] != null && row["N_OUT_STOCK_WGT"].ToString() != "")
                {
                    model.N_OUT_STOCK_WGT = decimal.Parse(row["N_OUT_STOCK_WGT"].ToString());
                }
                if (row["C_UNITIS"] != null)
                {
                    model.C_UNITIS = row["C_UNITIS"].ToString();
                }
                if (row["C_SEND_SITE"] != null)
                {
                    model.C_SEND_SITE = row["C_SEND_SITE"].ToString();
                }
                if (row["C_AOG_SITE"] != null)
                {
                    model.C_AOG_SITE = row["C_AOG_SITE"].ToString();
                }
                if (row["C_ORGO_CUST"] != null)
                {
                    model.C_ORGO_CUST = row["C_ORGO_CUST"].ToString();
                }
                if (row["C_CGC"] != null)
                {
                    model.C_CGC = row["C_CGC"].ToString();
                }
                if (row["N_IS_SEND_CLOSE"] != null && row["N_IS_SEND_CLOSE"].ToString() != "")
                {
                    model.N_IS_SEND_CLOSE = decimal.Parse(row["N_IS_SEND_CLOSE"].ToString());
                }
                if (row["C_ORDER_TYPE"] != null)
                {
                    model.C_ORDER_TYPE = row["C_ORDER_TYPE"].ToString();
                }
                if (row["C_SEND_AREA"] != null)
                {
                    model.C_SEND_AREA = row["C_SEND_AREA"].ToString();
                }
                if (row["C_AREA"] != null)
                {
                    model.C_AREA = row["C_AREA"].ToString();
                }
                if (row["C_AU_UNITIS"] != null)
                {
                    model.C_AU_UNITIS = row["C_AU_UNITIS"].ToString();
                }
                if (row["C_CUSTFILE_ID"] != null)
                {
                    model.C_CUSTFILE_ID = row["C_CUSTFILE_ID"].ToString();
                }
                if (row["C_CUST_ID"] != null)
                {
                    model.C_CUST_ID = row["C_CUST_ID"].ToString();
                }
                if (row["C_REMARK"] != null)
                {
                    model.C_REMARK = row["C_REMARK"].ToString();
                }
                if (row["C_MZDATE"] != null)
                {
                    model.C_MZDATE = row["C_MZDATE"].ToString();
                }
                if (row["N_MWGT"] != null && row["N_MWGT"].ToString() != "")
                {
                    model.N_MWGT = decimal.Parse(row["N_MWGT"].ToString());
                }
                if (row["N_PWGT"] != null && row["N_PWGT"].ToString() != "")
                {
                    model.N_PWGT = decimal.Parse(row["N_PWGT"].ToString());
                }
                if (row["N_JWGT"] != null && row["N_JWGT"].ToString() != "")
                {
                    model.N_JWGT = decimal.Parse(row["N_JWGT"].ToString());
                }
                if (row["N_MZTIME"] != null)
                {
                    model.N_MZTIME = row["N_MZTIME"].ToString();
                }
                if (row["N_PZTIME"] != null)
                {
                    model.N_PZTIME = row["N_PZTIME"].ToString();
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
                if (row["C_CON_NO"] != null)
                {
                    model.C_CON_NO = row["C_CON_NO"].ToString();
                }
                if (row["C_PLAN_ID"] != null)
                {
                    model.C_PLAN_ID = row["C_PLAN_ID"].ToString();
                }
                if (row["C_PLAN_CODE"] != null)
                {
                    model.C_PLAN_CODE = row["C_PLAN_CODE"].ToString();
                }
                if (row["C_PK_NCID"] != null)
                {
                    model.C_PK_NCID = row["C_PK_NCID"].ToString();
                }
                if (row["C_NO"] != null)
                {
                    model.C_NO = row["C_NO"].ToString();
                }
                if (row["C_STD_CODE"] != null)
                {
                    model.C_STD_CODE = row["C_STD_CODE"].ToString();
                }
                if (row["C_JUDGE_LEV_ZH"] != null)
                {
                    model.C_JUDGE_LEV_ZH = row["C_JUDGE_LEV_ZH"].ToString();
                }
                if (row["C_PRODUCT_ID"] != null)
                {
                    model.C_PRODUCT_ID = row["C_PRODUCT_ID"].ToString();
                }
                if (row["C_FREE_TERM2"] != null)
                {
                    model.C_FREE_TERM2 = row["C_FREE_TERM2"].ToString();
                }
                if (row["C_PACK"] != null)
                {
                    model.C_PACK = row["C_PACK"].ToString();
                }
                if (row["C_PZDATE"] != null)
                {
                    model.C_PZDATE = row["C_PZDATE"].ToString();
                }
                if (row["C_ORDERPK"] != null)
                {
                    model.C_ORDERPK = row["C_ORDERPK"].ToString();
                }
                if (row["C_CUSTNO"] != null)
                {
                    model.C_CUSTNO = row["C_CUSTNO"].ToString();
                }
                if (row["N_FYZS"] != null && row["N_FYZS"].ToString() != "")
                {
                    model.N_FYZS = decimal.Parse(row["N_FYZS"].ToString());
                }
                if (row["N_FYWGT"] != null && row["N_FYWGT"].ToString() != "")
                {
                    model.N_FYWGT = decimal.Parse(row["N_FYWGT"].ToString());
                }
                if (row["C_SEND_STOCK_PK"] != null)
                {
                    model.C_SEND_STOCK_PK = row["C_SEND_STOCK_PK"].ToString();
                }
                if (row["C_SEND_STOCK_CODE"] != null)
                {
                    model.C_SEND_STOCK_CODE = row["C_SEND_STOCK_CODE"].ToString();
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
            strSql.Append("select C_ID,C_DISPATCH_ID,C_STOVE,C_BATCH_NO,C_TICK_NO,C_SLAB_NO,C_MAT_CODE,C_MAT_NAME,C_SPEC,C_STL_GRD,C_SEND_STOCK,C_QUALIRY_LEV,C_FREE_TERM,C_ELSENEED,N_COM_AMOUNT_WGT,N_WGT,C_EQUATION_FACTOR,N_OUT_STOCK_WGT,C_UNITIS,C_SEND_SITE,C_AOG_SITE,C_ORGO_CUST,C_CGC,N_IS_SEND_CLOSE,C_ORDER_TYPE,C_SEND_AREA,C_AREA,C_AU_UNITIS,C_CUSTFILE_ID,C_CUST_ID,C_REMARK,C_MZDATE,N_MWGT,N_PWGT,N_JWGT,N_MZTIME,N_PZTIME,C_EMP_ID,C_EMP_NAME,D_MOD_DT,C_CON_NO,C_PLAN_ID,C_PLAN_CODE,C_PK_NCID,C_NO,C_STD_CODE,C_JUDGE_LEV_ZH,C_PRODUCT_ID,C_FREE_TERM2,C_PACK,C_PZDATE,C_ORDERPK,C_CUSTNO,N_FYZS,N_FYWGT,C_SEND_STOCK_PK,C_SEND_STOCK_CODE ");
            strSql.Append(" FROM TMD_DISPATCHDETAILS ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where C_DISPATCH_ID='" + strWhere + "'");
            }
            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM TMD_DISPATCHDETAILS ");
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
            strSql.Append(")AS Row, T.*  from TMD_DISPATCHDETAILS T ");
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
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strTime1, string strTime2)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(@"select TA.合同号,
                            TA.客户,
                            TA.销售区域,
                            TA.签订日期,
                            TA.交货日期,
                            TA.发运方式,
                            TA.交货地址,
                            TA.物料编码,
                            TA.钢种,
                            TA.执行标准,
                            TA.规格,
                            TA.批号,
                            TA.件数,
                            TA.重量,
                            ta.开坯,
                            ta.修磨,
                            to_char(ta.发出时间,'yyyy-mm-dd hh24:mi:ss')as 发出时间,
                            to_char(tb.出库时间,'yyyy-mm-dd hh24:mi:ss')as 线材出库时间,
                            to_char(tb.线材质量判定入库时间,'yyyy-mm-dd hh24:mi:ss')as 线材质量判定入库时间,
                            round((tb.出库时间 - tb.线材质量判定入库时间) * 24) as 线材库存时间段,
                            to_char(tb.线材检验完成时间,'yyyy-mm-dd hh24:mi:ss')as 线材检验完成时间,
                            to_char(tb.线材报检时间,'yyyy-mm-dd hh24:mi:ss')as 线材报检时间,
                            round((tb.线材检验完成时间 - tb.线材报检时间) * 24) as 线材检验时间段,
                            to_char(tb.计划下达时间,'yyyy-mm-dd hh24:mi:ss')as 计划下达时间,
                            to_char(tb.轧制完工时间,'yyyy-mm-dd hh24:mi:ss')as 轧制完工时间,
                            round((tb.轧制完工时间 - tb.计划下达时间) * 24) as 线材轧制时间段,
                            to_char(tb.组坯时间,'yyyy-mm-dd hh24:mi:ss') as 钢坯出库时间,
                            to_char(tb.钢坯入库时间,'yyyy-mm-dd hh24:mi:ss')as 钢坯入库时间,
                            round((tb.组坯时间 - tb.钢坯入库时间) * 24) as 钢坯库存时间段,
                            to_char(tb.开坯计划下达时间,'yyyy-mm-dd hh24:mi:ss')as 开坯计划下达时间,
                            to_char(tb.开坯完工时间,'yyyy-mm-dd hh24:mi:ss')as 开坯完工时间,
                            round((tb.开坯完工时间 - tb.开坯计划下达时间) * 24) as 开坯时间段,
                            to_char(tb.修磨开始时间,'yyyy-mm-dd hh24:mi:ss')as 修磨开始时间,
                            to_char(tb.修磨完工时间,'yyyy-mm-dd hh24:mi:ss')as 修磨完工时间,
                            round((tb.修磨完工时间 - tb.修磨开始时间) * 24) as 修磨时间段,
                            to_char(tb.钢坯报检时间,'yyyy-mm-dd hh24:mi:ss') as 钢坯报检时间,
                            to_char(tb.钢坯判定时间,'yyyy-mm-dd hh24:mi:ss') as 钢坯判定时间,
                            round((tb.钢坯判定时间 - tb.钢坯报检时间) * 24 * 60) as 钢坯检验时间段
                            from V_SALE_ORDER ta
                            LEFT join v_sc_info tb
                            on ta.批号 = tb.C_BATCH_NO
                            and ta.发运单号 = tb.C_FYDH
                            and ta.钢种 = tb.C_STL_GRD
                            and ta.物料编码 = tb.C_MAT_CODE
                            AND TA.执行标准 = TB.C_STD_CODE
                            WHERE 1=1 ");

            if (!string.IsNullOrEmpty(strTime1) && !string.IsNullOrEmpty(strTime2))
            {
                strSql.Append(" and TA.发出时间 between to_date('" + strTime1 + "', 'yyyy-mm-dd hh24:mi:ss') and to_date('" + strTime2 + "', 'yyyy-mm-dd hh24:mi:ss') ");
            }

            strSql.Append(" ORDER BY TA.客户, TA.合同号, TA.批号, TA.发出时间 ");

            return DbHelperOra.Query(strSql.ToString());
        }


        #endregion  ExtensionMethod
    }
}
