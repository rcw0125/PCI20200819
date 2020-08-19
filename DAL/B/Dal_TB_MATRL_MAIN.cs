using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;
namespace DAL
{
    /// <summary>
    /// 数据访问类:TB_MATRL_MAIN
    /// </summary>
    public partial class Dal_TB_MATRL_MAIN
    {
        public Dal_TB_MATRL_MAIN()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string C_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TB_MATRL_MAIN");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)            };
            parameters[0].Value = C_ID;

            return DbHelperOra.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Mod_TB_MATRL_MAIN model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TB_MATRL_MAIN(");
            strSql.Append("C_MAT_CODE,C_MAT_NAME,C_MAT_GROUP_CODE,C_MAT_GROUP_NAME,C_PROD_KIND,C_PROD_NAME,C_STL_GRD,C_SPEC,C_EMP_ID,D_MOD_DT,N_THK,N_WTH,N_LTH,C_MAT_TYPE,C_CLS_TYPE,C_REMARK1,C_REMARK2,C_REMARK3,C_NC_PK,C_PK_INVCL,C_PK_INVBASDOC,C_PK_INVMANDOC,C_PK_PRODUCE,C_PK_MEASDOC,C_PK_TAXITEMS,C_INVSHORTNAME,N_ISGPS,C_IS_VISIBLE,C_FJLDW,N_HSL,C_ZJLDWMC,C_FJLDWMC)");
            strSql.Append(" values (");
            strSql.Append(":C_MAT_CODE,:C_MAT_NAME,:C_MAT_GROUP_CODE,:C_MAT_GROUP_NAME,:C_PROD_KIND,:C_PROD_NAME,:C_STL_GRD,:C_SPEC,:C_EMP_ID,:D_MOD_DT,:N_THK,:N_WTH,:N_LTH,:C_MAT_TYPE,:C_CLS_TYPE,:C_REMARK1,:C_REMARK2,:C_REMARK3,:C_NC_PK,:C_PK_INVCL,:C_PK_INVBASDOC,:C_PK_INVMANDOC,:C_PK_PRODUCE,:C_PK_MEASDOC,:C_PK_TAXITEMS,:C_INVSHORTNAME,:N_ISGPS,:C_IS_VISIBLE,:C_FJLDW,:N_HSL,:C_ZJLDWMC,:C_FJLDWMC)");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_MAT_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MAT_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MAT_GROUP_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MAT_GROUP_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PROD_KIND", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PROD_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STL_GRD", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SPEC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":N_THK", OracleDbType.Int16,5),
                    new OracleParameter(":N_WTH", OracleDbType.Int16,5),
                    new OracleParameter(":N_LTH", OracleDbType.Int16,5),
                    new OracleParameter(":C_MAT_TYPE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CLS_TYPE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_REMARK1", OracleDbType.Varchar2,200),
                    new OracleParameter(":C_REMARK2", OracleDbType.Varchar2,200),
                    new OracleParameter(":C_REMARK3", OracleDbType.Varchar2,200),
                    new OracleParameter(":C_NC_PK", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PK_INVCL", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PK_INVBASDOC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PK_INVMANDOC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PK_PRODUCE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PK_MEASDOC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PK_TAXITEMS", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_INVSHORTNAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_ISGPS", OracleDbType.Int16,1),
                    new OracleParameter(":C_IS_VISIBLE", OracleDbType.Int16,1),
                    new OracleParameter(":C_FJLDW", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_HSL", OracleDbType.Int16,15),
                    new OracleParameter(":C_ZJLDWMC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_FJLDWMC", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.C_ID;
            parameters[1].Value = model.C_MAT_CODE;
            parameters[2].Value = model.C_MAT_NAME;
            parameters[3].Value = model.C_MAT_GROUP_CODE;
            parameters[4].Value = model.C_MAT_GROUP_NAME;
            parameters[5].Value = model.C_PROD_KIND;
            parameters[6].Value = model.C_PROD_NAME;
            parameters[7].Value = model.C_STL_GRD;
            parameters[8].Value = model.C_SPEC;
            parameters[9].Value = model.C_EMP_ID;
            parameters[10].Value = model.D_MOD_DT;
            parameters[11].Value = model.N_THK;
            parameters[12].Value = model.N_WTH;
            parameters[13].Value = model.N_LTH;
            parameters[14].Value = model.C_MAT_TYPE;
            parameters[15].Value = model.C_CLS_TYPE;
            parameters[16].Value = model.C_REMARK1;
            parameters[17].Value = model.C_REMARK2;
            parameters[18].Value = model.C_REMARK3;
            parameters[19].Value = model.C_NC_PK;
            parameters[20].Value = model.C_PK_INVCL;
            parameters[21].Value = model.C_PK_INVBASDOC;
            parameters[22].Value = model.C_PK_INVMANDOC;
            parameters[23].Value = model.C_PK_PRODUCE;
            parameters[24].Value = model.C_PK_MEASDOC;
            parameters[25].Value = model.C_PK_TAXITEMS;
            parameters[26].Value = model.C_INVSHORTNAME;
            parameters[27].Value = model.N_ISGPS;
            parameters[28].Value = model.C_IS_VISIBLE;
            parameters[29].Value = model.C_FJLDW;
            parameters[30].Value = model.N_HSL;
            parameters[31].Value = model.C_ZJLDWMC;
            parameters[32].Value = model.C_FJLDWMC;

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
        public bool Update(Mod_TB_MATRL_MAIN model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TB_MATRL_MAIN set ");
            strSql.Append("C_MAT_CODE=:C_MAT_CODE,");
            strSql.Append("C_MAT_NAME=:C_MAT_NAME,");
            strSql.Append("C_MAT_GROUP_CODE=:C_MAT_GROUP_CODE,");
            strSql.Append("C_MAT_GROUP_NAME=:C_MAT_GROUP_NAME,");
            strSql.Append("C_PROD_KIND=:C_PROD_KIND,");
            strSql.Append("C_PROD_NAME=:C_PROD_NAME,");
            strSql.Append("C_STL_GRD=:C_STL_GRD,");
            strSql.Append("C_SPEC=:C_SPEC,");
            strSql.Append("C_EMP_ID=:C_EMP_ID,");
            strSql.Append("D_MOD_DT=:D_MOD_DT,");
            strSql.Append("N_THK=:N_THK,");
            strSql.Append("N_WTH=:N_WTH,");
            strSql.Append("N_LTH=:N_LTH,");
            strSql.Append("C_MAT_TYPE=:C_MAT_TYPE,");
            strSql.Append("C_CLS_TYPE=:C_CLS_TYPE,");
            strSql.Append("C_REMARK1=:C_REMARK1,");
            strSql.Append("C_REMARK2=:C_REMARK2,");
            strSql.Append("C_REMARK3=:C_REMARK3,");
            strSql.Append("C_NC_PK=:C_NC_PK,");
            strSql.Append("C_PK_INVCL=:C_PK_INVCL,");
            strSql.Append("C_PK_INVBASDOC=:C_PK_INVBASDOC,");
            strSql.Append("C_PK_INVMANDOC=:C_PK_INVMANDOC,");
            strSql.Append("C_PK_PRODUCE=:C_PK_PRODUCE,");
            strSql.Append("C_PK_MEASDOC=:C_PK_MEASDOC,");
            strSql.Append("C_PK_TAXITEMS=:C_PK_TAXITEMS,");
            strSql.Append("C_INVSHORTNAME=:C_INVSHORTNAME,");
            strSql.Append("N_ISGPS=:N_ISGPS,");
            strSql.Append("C_IS_VISIBLE=:C_IS_VISIBLE,");
            strSql.Append("C_FJLDW=:C_FJLDW,");
            strSql.Append("N_HSL=:N_HSL,");
            strSql.Append("C_ZJLDWMC=:C_ZJLDWMC,");
            strSql.Append("C_FJLDWMC=:C_FJLDWMC");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_MAT_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MAT_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MAT_GROUP_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MAT_GROUP_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PROD_KIND", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PROD_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STL_GRD", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SPEC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":N_THK", OracleDbType.Int16,5),
                    new OracleParameter(":N_WTH", OracleDbType.Int16,5),
                    new OracleParameter(":N_LTH", OracleDbType.Int16,5),
                    new OracleParameter(":C_MAT_TYPE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CLS_TYPE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_REMARK1", OracleDbType.Varchar2,200),
                    new OracleParameter(":C_REMARK2", OracleDbType.Varchar2,200),
                    new OracleParameter(":C_REMARK3", OracleDbType.Varchar2,200),
                    new OracleParameter(":C_NC_PK", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PK_INVCL", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PK_INVBASDOC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PK_INVMANDOC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PK_PRODUCE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PK_MEASDOC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PK_TAXITEMS", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_INVSHORTNAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_ISGPS", OracleDbType.Int16,1),
                    new OracleParameter(":C_IS_VISIBLE", OracleDbType.Int16,1),
                    new OracleParameter(":C_FJLDW", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_HSL", OracleDbType.Int16,15),
                    new OracleParameter(":C_ZJLDWMC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_FJLDWMC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.C_MAT_CODE;
            parameters[1].Value = model.C_MAT_NAME;
            parameters[2].Value = model.C_MAT_GROUP_CODE;
            parameters[3].Value = model.C_MAT_GROUP_NAME;
            parameters[4].Value = model.C_PROD_KIND;
            parameters[5].Value = model.C_PROD_NAME;
            parameters[6].Value = model.C_STL_GRD;
            parameters[7].Value = model.C_SPEC;
            parameters[8].Value = model.C_EMP_ID;
            parameters[9].Value = model.D_MOD_DT;
            parameters[10].Value = model.N_THK;
            parameters[11].Value = model.N_WTH;
            parameters[12].Value = model.N_LTH;
            parameters[13].Value = model.C_MAT_TYPE;
            parameters[14].Value = model.C_CLS_TYPE;
            parameters[15].Value = model.C_REMARK1;
            parameters[16].Value = model.C_REMARK2;
            parameters[17].Value = model.C_REMARK3;
            parameters[18].Value = model.C_NC_PK;
            parameters[19].Value = model.C_PK_INVCL;
            parameters[20].Value = model.C_PK_INVBASDOC;
            parameters[21].Value = model.C_PK_INVMANDOC;
            parameters[22].Value = model.C_PK_PRODUCE;
            parameters[23].Value = model.C_PK_MEASDOC;
            parameters[24].Value = model.C_PK_TAXITEMS;
            parameters[25].Value = model.C_INVSHORTNAME;
            parameters[26].Value = model.N_ISGPS;
            parameters[27].Value = model.C_IS_VISIBLE;
            parameters[28].Value = model.C_FJLDW;
            parameters[29].Value = model.N_HSL;
            parameters[30].Value = model.C_ZJLDWMC;
            parameters[31].Value = model.C_FJLDWMC;
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
        /// 删除一条数据
        /// </summary>
        public bool Delete(string C_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from TB_MATRL_MAIN ");
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
            strSql.Append("delete from TB_MATRL_MAIN ");
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
        public Mod_TB_MATRL_MAIN GetModel(string C_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_MAT_CODE,C_MAT_NAME,C_MAT_GROUP_CODE,C_MAT_GROUP_NAME,C_PROD_KIND,C_PROD_NAME,C_STL_GRD,C_SPEC,C_EMP_ID,D_MOD_DT,N_THK,N_WTH,N_LTH,C_MAT_TYPE,C_CLS_TYPE,C_REMARK1,C_REMARK2,C_REMARK3,C_NC_PK,C_PK_INVCL,C_PK_INVBASDOC,C_PK_INVMANDOC,C_PK_PRODUCE,C_PK_MEASDOC,C_PK_TAXITEMS,C_INVSHORTNAME,N_ISGPS,C_IS_VISIBLE,C_FJLDW,N_HSL,C_ZJLDWMC,C_FJLDWMC,C_PLANEMP,C_PK_PSID,C_SLAB_SIZE from TB_MATRL_MAIN ");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)            };
            parameters[0].Value = C_ID;

            Mod_TB_MATRL_MAIN model = new Mod_TB_MATRL_MAIN();
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
        public Mod_TB_MATRL_MAIN GetModel_Interface_Trans(string C_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_MAT_CODE,C_MAT_NAME,C_MAT_GROUP_CODE,C_MAT_GROUP_NAME,C_PROD_KIND,C_PROD_NAME,C_STL_GRD,C_SPEC,C_EMP_ID,D_MOD_DT,N_THK,N_WTH,N_LTH,C_MAT_TYPE,C_CLS_TYPE,C_REMARK1,C_REMARK2,C_REMARK3,C_NC_PK,C_PK_INVCL,C_PK_INVBASDOC,C_PK_INVMANDOC,C_PK_PRODUCE,C_PK_MEASDOC,C_PK_TAXITEMS,C_INVSHORTNAME,N_ISGPS,C_IS_VISIBLE,C_FJLDW,N_HSL,C_ZJLDWMC,C_FJLDWMC,C_PLANEMP,C_PK_PSID,C_SLAB_SIZE from TB_MATRL_MAIN ");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)            };
            parameters[0].Value = C_ID;

            Mod_TB_MATRL_MAIN model = new Mod_TB_MATRL_MAIN();
            DataSet ds = TransactionHelper.Query(strSql.ToString(), parameters);
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
        public Mod_TB_MATRL_MAIN DataRowToModel(DataRow row)
        {
            Mod_TB_MATRL_MAIN model = new Mod_TB_MATRL_MAIN();
            if (row != null)
            {
                if (row["C_ID"] != null)
                {
                    model.C_ID = row["C_ID"].ToString();
                }
                if (row["C_MAT_CODE"] != null)
                {
                    model.C_MAT_CODE = row["C_MAT_CODE"].ToString();
                }
                if (row["C_MAT_NAME"] != null)
                {
                    model.C_MAT_NAME = row["C_MAT_NAME"].ToString();
                }
                if (row["C_MAT_GROUP_CODE"] != null)
                {
                    model.C_MAT_GROUP_CODE = row["C_MAT_GROUP_CODE"].ToString();
                }
                if (row["C_MAT_GROUP_NAME"] != null)
                {
                    model.C_MAT_GROUP_NAME = row["C_MAT_GROUP_NAME"].ToString();
                }
                if (row["C_PROD_KIND"] != null)
                {
                    model.C_PROD_KIND = row["C_PROD_KIND"].ToString();
                }
                if (row["C_PROD_NAME"] != null)
                {
                    model.C_PROD_NAME = row["C_PROD_NAME"].ToString();
                }
                if (row["C_STL_GRD"] != null)
                {
                    model.C_STL_GRD = row["C_STL_GRD"].ToString();
                }
                if (row["C_SPEC"] != null)
                {
                    model.C_SPEC = row["C_SPEC"].ToString();
                }
                if (row["C_EMP_ID"] != null)
                {
                    model.C_EMP_ID = row["C_EMP_ID"].ToString();
                }
                if (row["D_MOD_DT"] != null && row["D_MOD_DT"].ToString() != "")
                {
                    model.D_MOD_DT = DateTime.Parse(row["D_MOD_DT"].ToString());
                }
                if (row["N_THK"] != null && row["N_THK"].ToString() != "")
                {
                    model.N_THK = decimal.Parse(row["N_THK"].ToString());
                }
                if (row["N_WTH"] != null && row["N_WTH"].ToString() != "")
                {
                    model.N_WTH = decimal.Parse(row["N_WTH"].ToString());
                }
                if (row["N_LTH"] != null && row["N_LTH"].ToString() != "")
                {
                    model.N_LTH = decimal.Parse(row["N_LTH"].ToString());
                }
                if (row["C_MAT_TYPE"] != null)
                {
                    model.C_MAT_TYPE = row["C_MAT_TYPE"].ToString();
                }
                if (row["C_CLS_TYPE"] != null)
                {
                    model.C_CLS_TYPE = row["C_CLS_TYPE"].ToString();
                }
                if (row["C_REMARK1"] != null)
                {
                    model.C_REMARK1 = row["C_REMARK1"].ToString();
                }
                if (row["C_REMARK2"] != null)
                {
                    model.C_REMARK2 = row["C_REMARK2"].ToString();
                }
                if (row["C_REMARK3"] != null)
                {
                    model.C_REMARK3 = row["C_REMARK3"].ToString();
                }
                if (row["C_NC_PK"] != null)
                {
                    model.C_NC_PK = row["C_NC_PK"].ToString();
                }
                if (row["C_PK_INVCL"] != null)
                {
                    model.C_PK_INVCL = row["C_PK_INVCL"].ToString();
                }
                if (row["C_PK_INVBASDOC"] != null)
                {
                    model.C_PK_INVBASDOC = row["C_PK_INVBASDOC"].ToString();
                }
                if (row["C_PK_INVMANDOC"] != null)
                {
                    model.C_PK_INVMANDOC = row["C_PK_INVMANDOC"].ToString();
                }
                if (row["C_PK_PRODUCE"] != null)
                {
                    model.C_PK_PRODUCE = row["C_PK_PRODUCE"].ToString();
                }
                if (row["C_PK_MEASDOC"] != null)
                {
                    model.C_PK_MEASDOC = row["C_PK_MEASDOC"].ToString();
                }
                if (row["C_PK_TAXITEMS"] != null)
                {
                    model.C_PK_TAXITEMS = row["C_PK_TAXITEMS"].ToString();
                }
                if (row["C_INVSHORTNAME"] != null)
                {
                    model.C_INVSHORTNAME = row["C_INVSHORTNAME"].ToString();
                }
                if (row["N_ISGPS"] != null && row["N_ISGPS"].ToString() != "")
                {
                    model.N_ISGPS = decimal.Parse(row["N_ISGPS"].ToString());
                }
                if (row["C_IS_VISIBLE"] != null && row["C_IS_VISIBLE"].ToString() != "")
                {
                    model.C_IS_VISIBLE = decimal.Parse(row["C_IS_VISIBLE"].ToString());
                }
                if (row["C_FJLDW"] != null)
                {
                    model.C_FJLDW = row["C_FJLDW"].ToString();
                }
                if (row["N_HSL"] != null && row["N_HSL"].ToString() != "")
                {
                    model.N_HSL = decimal.Parse(row["N_HSL"].ToString());
                }
                if (row["C_ZJLDWMC"] != null)
                {
                    model.C_ZJLDWMC = row["C_ZJLDWMC"].ToString();
                }
                if (row["C_FJLDWMC"] != null)
                {
                    model.C_FJLDWMC = row["C_FJLDWMC"].ToString();
                }
                if (row["C_PLANEMP"] != null)
                {
                    model.C_PLANEMP = row["C_PLANEMP"].ToString();
                }
                if (row["C_PK_PSID"] != null)
                {
                    model.C_PK_PSID = row["C_PK_PSID"].ToString();
                }
                if (row["C_SLAB_SIZE"] != null)
                {
                    model.C_SLAB_SIZE = row["C_SLAB_SIZE"].ToString();
                }



            }
            return model;
        }


        /// <summary>
        /// 获取连铸坯物料信息
        /// </summary>
        /// <param name="C_STL_GRD">钢种</param>
        /// <returns></returns>
        public DataSet GetListLZ(string C_STL_GRD)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT * FROM TB_MATRL_MAIN t  WHERE T.C_MAT_TYPE='6' AND T.C_ID LIKE '611%' OR T.C_ID LIKE '612%' OR T.C_ID LIKE '613%' ");

            if (C_STL_GRD.Trim() != "")
            {
                strSql.Append(" AND C_STL_GRD='" + C_STL_GRD + "' ");
            }
            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取热轧坯物料信息
        /// </summary>
        /// <param name="C_STL_GRD">钢种</param>
        /// <returns></returns>
        public DataSet GetListRZ(string C_STL_GRD)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT * FROM TB_MATRL_MAIN t  WHERE T.C_MAT_TYPE='6' AND T.C_ID LIKE '614%'  ");

            if (C_STL_GRD.Trim() != "")
            {
                strSql.Append(" AND C_STL_GRD='" + C_STL_GRD + "' ");
            }
            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 预测订单钢坯产品查询
        /// </summary>
        /// <param name="matCode">物流编码</param>
        /// <param name="stlGrd">钢种</param> 
        /// <returns></returns>
        public DataSet GetGP_StlGrd(string matCode, string stlGrd,string std )
        {
            StringBuilder strSql = new StringBuilder();
            strSql.AppendFormat(@"SELECT *
                                 FROM TB_MATRL_MAIN T
                                 inner join (SELECT A.C_STL_GRD,
                                  A.C_STD_CODE,
                                  A.C_ZYX1,
                                  A.C_ZYX2,
                                  B.C_IS_BXG
               FROM (SELECT distinct A.C_STL_GRD,
                                     A.C_STD_CODE,
                                     A.C_ZYX1,
                                     A.C_ZYX2
                       FROM TB_STD_CONFIG A
                      WHERE A.N_STATUS = 1) A
               LEFT JOIN (SELECT T.C_STL_GRD,
                                T.C_STD_CODE,
                                T.C_PROD_KIND,
                                T.C_PROD_NAME,
                                T.C_USES,
                                T.C_DELIVERY_STATE,
                                T.C_IS_BXG
                           FROM TQB_STD_MAIN T
                          WHERE T.N_STATUS = 1
                            AND T.N_IS_CHECK = 1) B
                 ON A.C_STL_GRD = B.C_STL_GRD
                AND A.C_STD_CODE = B.C_STD_CODE) M
                ON M.C_STL_GRD = T.C_STL_GRD
             WHERE  t.c_slab_size IS NOT NULL AND T.C_CLS_TYPE='N'AND T.C_MAT_NAME NOT LIKE '%来料%' AND T.C_MAT_NAME NOT LIKE '%封存%' 
               AND t.n_lth IS NOT NULL
               AND (T.C_ID LIKE '614%' ---热轧钢坯
                OR T.C_ID LIKE '611%' ---小方坯连铸坯
                OR T.C_ID LIKE '612%' ---不锈钢连铸坯
                OR T.C_ID LIKE '613%')  ");
            if (!string.IsNullOrEmpty(matCode))
            {
                strSql.AppendFormat(" and T.C_MAT_CODE like '%{0}%'", matCode);
            }
            if (!string.IsNullOrEmpty(stlGrd))
            {
                strSql.AppendFormat(" and T.C_STL_GRD like '%{0}%'", stlGrd);
            }
            if (!string.IsNullOrEmpty(std))
            {
                strSql.AppendFormat(" and T.C_STD_CODE like '%{0}%'", std);
            } 
            strSql.Append(" order by T.C_MAT_NAME, T.C_STL_GRD, T.C_SPEC");
            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_MAT_CODE,C_MAT_NAME,C_MAT_GROUP_CODE,C_MAT_GROUP_NAME,C_PROD_KIND,C_PROD_NAME,C_STL_GRD,C_SPEC,C_EMP_ID,D_MOD_DT,N_THK,N_WTH,N_LTH,C_MAT_TYPE,C_CLS_TYPE,C_REMARK1,C_REMARK2,C_REMARK3,C_NC_PK,C_PK_INVCL,C_PK_INVBASDOC,C_PK_INVMANDOC,C_PK_PRODUCE,C_PK_MEASDOC,C_PK_TAXITEMS,C_INVSHORTNAME,N_ISGPS,C_IS_VISIBLE,C_FJLDW,N_HSL,C_ZJLDWMC,C_FJLDWMC,C_PLANEMP,C_PK_PSID,C_SLAB_SIZE ");
            strSql.Append(" FROM TB_MATRL_MAIN ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList_DFPCD(string N_LTH)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT T.N_LTH,T.C_SLAB_SIZE FROM TB_MATRL_MAIN T WHERE T.C_MAT_TYPE='6'  AND T.C_SLAB_SIZE='280*325' AND T.N_LTH IS NOT NULL  ");
            if (N_LTH.Trim() != "")
            {
                strSql.Append(" and T.N_LTH='" + N_LTH + "' ");
            }
            strSql.Append(" GROUP BY T.N_LTH,T.C_SLAB_SIZE  ");
            strSql.Append(" ORDER BY T.C_SLAB_SIZE ");
            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList_RZPCD(string C_SLAB_SIZE)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT T.N_LTH,T.C_SLAB_SIZE FROM TB_MATRL_MAIN T WHERE T.C_MAT_TYPE='6'  AND T.C_SLAB_SIZE  not in('280*325') AND T.N_LTH IS NOT NULL  ");
            if (C_SLAB_SIZE.Trim() != "")
            {
                strSql.Append(" and T.C_SLAB_SIZE like '%" + C_SLAB_SIZE + "%' ");
            }
            strSql.Append(" GROUP BY T.N_LTH,T.C_SLAB_SIZE  ");
            strSql.Append(" ORDER BY T.C_SLAB_SIZE  ");

            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM TB_MATRL_MAIN ");
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
            strSql.Append(")AS Row, T.*  from TB_MATRL_MAIN T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            return DbHelperOra.Query(strSql.ToString());
        }
        #endregion  BasicMethod
        #region  BasicMethod2
        /// <summary>
        /// 获得数据列表_条件查询
        /// </summary>
        /// <param name="C_MAT_CODE">物料编码</param>
        /// <param name="C_MAT_NAME">物料描述</param>
        /// <param name="C_STL_GRD">钢种</param>
        /// <returns></returns>
        public DataSet GetList_Query(string C_MAT_CODE, string C_MAT_NAME, string C_STL_GRD, string C_SPEC, string mat_type)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_MAT_CODE,C_MAT_NAME,C_MAT_GROUP_CODE,C_MAT_GROUP_NAME,C_PROD_KIND,C_PROD_NAME,C_STL_GRD,C_SPEC,C_EMP_ID,D_MOD_DT,N_THK,N_WTH,N_LTH,C_MAT_TYPE,C_IS_VISIBLE,C_CLS_TYPE,C_REMARK1,C_REMARK2,C_REMARK3,C_NC_PK,C_PK_INVCL,C_PK_INVBASDOC,C_PK_INVMANDOC,C_PK_PRODUCE,C_PK_MEASDOC,C_PK_TAXITEMS,C_INVSHORTNAME,C_SLAB_SIZE ");
            strSql.Append(" FROM TB_MATRL_MAIN where  C_CLS_TYPE='N' AND  C_MAT_TYPE='" + mat_type + "'  ");

            if (C_MAT_CODE.Trim() != "")
            {
                strSql.Append(" and C_MAT_CODE like '%" + C_MAT_CODE + "%'");
            }
            if (C_MAT_NAME.Trim() != "")
            {
                strSql.Append(" and C_MAT_NAME like '%" + C_MAT_NAME + "%'");
            }
            if (C_STL_GRD.Trim() != "")
            {
                strSql.Append(" and C_STL_GRD like '%" + C_MAT_CODE + "%'");
            }
            if (C_SPEC.Trim() != "")
            {
                strSql.Append(" and C_SPEC like '%" + C_SPEC + "%'");
            }
            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取物料编码钢类
        /// </summary>
        /// <param name="c_mat_type">物料类别；材8/坯6</param>
        /// <returns></returns>
        public DataSet GetGl(int c_mat_type)
        {
            string strSql = "SELECT DISTINCT t.c_Prod_Name FROM tb_matrl_main t  WHERE T.C_CLS_TYPE='N' AND  t.c_mat_type=" + c_mat_type + " ORDER BY T.c_Prod_Name ";
            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 获取物料编码钢种
        /// </summary>
        /// <param name="c_mat_type"></param>
        /// <returns></returns>
        public DataSet GetGZ(int c_mat_type, string C_PROD_NAME)
        {
            string strSql = "SELECT DISTINCT t.C_STL_GRD FROM tb_matrl_main t  WHERE T.C_CLS_TYPE='N'  AND  t.c_mat_type=" + c_mat_type;
            if (C_PROD_NAME.Trim() != "")
            {
                strSql = strSql + "  AND T.C_PROD_NAME='" + C_PROD_NAME + "'";
            }
            strSql = strSql + "  ORDER BY T.C_STL_GRD ";
            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 获取改判用物料信息
        /// </summary>
        /// <param name="c_mat_code">物料编码</param>
        /// <param name="stl">钢种</param>
        /// <param name="std">执行标准</param>
        /// <param name="slab_size">规格</param>
        /// <param name="lth">定尺</param>
        /// <returns></returns>
        public DataSet GetGP_WL(string c_mat_code, string stl, string std, string slab_size, string lth, string type)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT tb.c_mat_code as 物料编码, TB.C_MAT_NAME AS 物料名称,TB.N_LTH AS 定尺, TB.C_STL_GRD AS 钢种,  TB.C_SLAB_SIZE AS 规格, TC.C_STD_CODE AS 执行标准, MAX(TD.C_ZYX1) AS 自由项1, MAX(TD.C_ZYX2) AS 自由项2 ");
            strSql.Append("  FROM TB_MATRL_MAIN TB   LEFT JOIN TQB_STD_MAIN TC ON TC.C_STL_GRD = TB.C_STL_GRD LEFT JOIN TB_STD_CONFIG TD ON TD.C_STD_CODE = TC.C_STD_CODE  AND TD.C_STL_GRD = TC.C_STL_GRD WHERE NVL(TC.N_STATUS, 1) = 1 AND NVL(TD.N_STATUS, 1) = 1 AND TB.C_MAT_TYPE='" + type + "'  ");
            if (!string.IsNullOrEmpty(c_mat_code))
            {
                strSql.Append("  AND Tb.c_mat_code='" + c_mat_code + "'");
            }
            if (!string.IsNullOrEmpty(stl))
            {
                strSql.Append("  AND TB.C_STL_GRD like '%" + stl + "%'");
            }
            if (!string.IsNullOrEmpty(std))
            {
                strSql.Append("  AND TC.C_STD_CODE like '%" + std + "%'");
            }
            if (!string.IsNullOrEmpty(slab_size))
            {
                strSql.Append("  AND Tb.C_SLAB_SIZE like '%" + slab_size + "%'");
            }
            if (!string.IsNullOrEmpty(lth))
            {
                strSql.Append("  AND Tb.N_LTH = '" + lth + "'");
            }
            strSql.Append(" GROUP BY tb.c_mat_code,  TB.C_MAT_NAME, TB.C_STL_GRD, TB.N_LTH, TB.C_SLAB_SIZE, TC.C_STD_CODE   ");
            strSql.Append(" order by tb.c_mat_code ");
            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        /// <param name="strMatCode">物料编码</param>
        /// <param name="strMatName">物料描述</param>
        /// <param name="strSTLGRD">钢种</param>
        /// <param name="strSpec">规格</param>
        /// <param name="strLen">定尺</param>
        /// <param name="C_MAT_TYPE">类别</param>
        /// <returns></returns>
        public DataSet GetListByWhere(string strMatCode, string strMatName, string strSTLGRD, string strSpec, string strLen, int C_MAT_TYPE)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_MAT_CODE,C_MAT_NAME,C_MAT_GROUP_CODE,C_MAT_GROUP_NAME,C_PROD_KIND,C_PROD_NAME,C_STL_GRD,C_SPEC,C_EMP_ID,D_MOD_DT,N_THK,N_WTH,N_LTH,C_MAT_TYPE,C_IS_VISIBLE,C_CLS_TYPE,C_REMARK1,C_REMARK2,C_REMARK3,C_NC_PK,C_PK_INVCL,C_PK_INVBASDOC,C_PK_INVMANDOC,C_PK_PRODUCE,C_PK_MEASDOC,C_PK_TAXITEMS,C_INVSHORTNAME,C_SLAB_SIZE ");
            strSql.Append(" FROM TB_MATRL_MAIN where C_CLS_TYPE='N'   ");
            if (!string.IsNullOrEmpty(strMatCode))
            {
                strSql.Append(" AND C_MAT_CODE ='" + strMatCode + "' ");
            }
            if (!string.IsNullOrEmpty(strMatName))
            {
                strSql.Append(" AND C_MAT_NAME LIKE '%" + strMatName + "%' ");
            }
            if (!string.IsNullOrEmpty(strSTLGRD))
            {
                strSql.Append(" AND C_STL_GRD LIKE '%" + strSTLGRD + "%' ");
            }
            if (!string.IsNullOrEmpty(strSpec))
            {
                strSql.Append(" AND C_SLAB_SIZE  LIKE '%" + strSpec + "%' ");
            }
            if (!string.IsNullOrEmpty(strLen))
            {
                strSql.Append(" AND N_LTH  LIKE '%" + strLen + "%' ");
            }
            strSql.Append(" and C_MAT_TYPE = " + C_MAT_TYPE);
            strSql.Append(" ORDER BY  C_MAT_CODE ");
            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得所有钢种
        /// </summary>
        public DataSet GetGZList()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select DISTINCT C_STL_GRD ");
            strSql.Append(" FROM TB_MATRL_MAIN ORDER BY C_STL_GRD ");

            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取所有物料编码信息
        /// </summary>
        /// <param name="C_MAT_CODE">物料编码</param>
        /// <param name="C_MAT_NAME">物料名称</param>
        /// <param name="C_STL_GRD">钢种</param>
        /// <param name="C_SPEC">规格</param>
        /// <returns></returns>
        public DataSet GetList_LCP(string C_MAT_CODE, string C_MAT_NAME, string C_STL_GRD, string C_SPEC)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT T.C_MAT_CODE AS 物料编码,T.C_MAT_NAME AS 物料名称,T.C_STL_GRD AS 钢种,T.C_SPEC AS 规格 FROM TB_MATRL_MAIN T where T.C_CLS_TYPE='N' ");

            if (C_MAT_CODE.Trim() != "")
            {
                strSql.Append(" and T.C_MAT_CODE like '" + C_MAT_CODE + "%'");
            }
            if (C_MAT_NAME.Trim() != "")
            {
                strSql.Append(" and T.C_MAT_NAME like '%" + C_MAT_NAME + "%'");
            }
            if (C_STL_GRD.Trim() != "")
            {
                strSql.Append(" and T.C_STL_GRD like '%" + C_STL_GRD + "%'");
            }
            if (C_SPEC.Trim() != "")
            {
                strSql.Append(" and T.C_SPEC like '%" + C_SPEC + "%'");
            }

            strSql.Append(" ORDER BY T.C_MAT_CODE "); return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取所有物料编码信息
        /// </summary>
        /// <param name="C_MAT_CODE">物料编码</param>
        /// <param name="C_MAT_NAME">物料名称</param>
        /// <param name="C_STL_GRD">钢种</param>
        /// <param name="C_SPEC">规格</param>
        /// <returns></returns>
        public DataSet GetList_WL_BZ(string C_MAT_CODE, string C_MAT_NAME, string C_STL_GRD, string C_SPEC)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT T.C_MAT_CODE AS 物料编码,T.C_MAT_NAME AS 物料名称,T.C_STL_GRD AS 钢种,T.C_SPEC AS 规格,tb.c_std_code as 执行标准 FROM TB_MATRL_MAIN T inner join tqb_std_main tb on t.c_stl_grd=tb.c_stl_grd where T.C_CLS_TYPE='N' and tb.n_is_check=1 and tb.n_status=1 AND T.C_MAT_TYPE=8 ");

            if (C_MAT_CODE.Trim() != "")
            {
                strSql.Append(" and T.C_MAT_CODE like '" + C_MAT_CODE + "%'");
            }
            if (C_MAT_NAME.Trim() != "")
            {
                strSql.Append(" and T.C_MAT_NAME like '%" + C_MAT_NAME + "%'");
            }
            if (C_STL_GRD.Trim() != "")
            {
                strSql.Append(" and T.C_STL_GRD like '%" + C_STL_GRD + "%'");
            }
            if (C_SPEC.Trim() != "")
            {
                strSql.Append(" and T.C_SPEC like '%" + C_SPEC + "%'");
            }

            strSql.Append(" ORDER BY T.C_MAT_CODE,tb.c_std_code,tb.c_stl_grd ");
            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 根据钢种规格获取物料编码
        /// </summary>
        /// <param name="C_STL_GRD">钢种</param>
        /// <param name="C_SPEC">规格（无长度）</param>
        /// <param name="N_THK">长度（mm）</param>
        /// <param name="C_TYPE">物料状态(1外购坯6钢坯8线材)</param>
        /// <param name="LGLX">炼钢路线</param>
        /// <param name="GPTYPE">大方坯连铸坯；小方坯连铸坯；热轧钢坯</param>
        /// <returns></returns>
        public DataSet GetGPWL(string C_STL_GRD, string C_SPEC, int? N_THK, string C_TYPE, string LGLX, string GPTYPE)
        {
            string strSql = " SELECT T.* FROM TB_MATRL_MAIN T WHERE T.C_CLS_TYPE='N'  AND T.C_STL_GRD = '" + C_STL_GRD + "' ";

            if (C_SPEC.Trim() != "")
            {
                strSql = strSql + "    AND INSTR(T.C_SPEC, '" + C_SPEC + "') > 0 ";
            }
            if (N_THK != null)
            {
                strSql = strSql + "   AND T.N_LTH =" + N_THK;
            }

            strSql = strSql + "   AND T.C_MAT_TYPE = '" + C_TYPE + "'  AND T.N_LTH IS NOT NULL  AND T.C_MAT_NAME NOT LIKE '%来料%' AND T.C_MAT_NAME NOT LIKE '%封存%' ";

            if (GPTYPE.Trim() == "大方坯连铸坯")
            {
                strSql = strSql + " AND   (T.C_ID LIKE '611%' OR T.C_ID LIKE '612%' OR T.C_ID LIKE '613%') AND  T.C_INVSHORTNAME ='大方坯'";

                if (LGLX.Trim() != "")
                {
                    strSql = strSql + " AND T.C_MAT_NAME LIKE '%" + LGLX + "%'";
                }
                else
                {
                    strSql = strSql + " AND T.C_MAT_NAME NOT LIKE '%(B%'";
                }
            }
            if (GPTYPE.Trim() == "小方坯连铸坯")
            {
                strSql = strSql + " AND   (T.C_ID LIKE '611%' OR T.C_ID LIKE '612%' OR T.C_ID LIKE '613%') AND  T.C_INVSHORTNAME <>'大方坯'";
            }
            if (GPTYPE.Trim() == "热轧钢坯")
            {
                strSql = strSql + " AND T.C_ID LIKE '614%' ";
                if (LGLX.Trim() != "")
                {
                    strSql = strSql + " AND T.C_MAT_NAME LIKE '%" + LGLX + "%'";
                }
                else
                {
                    strSql = strSql + " AND T.C_MAT_NAME NOT LIKE '%(B%'";
                }
            }

            strSql = strSql + " ORDER BY T.C_STL_GRD,  DECODE(T.N_LTH, 10700, 1, 10500, 2,9100,3, 6120, 4, 5850, 5, 6) , T.N_THK DESC ";
            return DbHelperOra.Query(strSql.ToString());

        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        /// <param name="C_PK_INVMANDOC">存货管理档案主键</param>
        /// <returns></returns>
        public Mod_TB_MATRL_MAIN GetMatModel(string C_PK_INVMANDOC)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_MAT_CODE,C_MAT_NAME,C_MAT_GROUP_CODE,C_MAT_GROUP_NAME,C_PROD_KIND,C_PROD_NAME,C_STL_GRD,C_SPEC,C_EMP_ID,D_MOD_DT,N_THK,N_WTH,N_LTH,C_MAT_TYPE,C_CLS_TYPE,C_REMARK1,C_REMARK2,C_REMARK3,C_NC_PK,C_PK_INVCL,C_PK_INVBASDOC,C_PK_INVMANDOC,C_PK_PRODUCE,C_PK_MEASDOC,C_PK_TAXITEMS,C_INVSHORTNAME,N_ISGPS,C_IS_VISIBLE,C_FJLDW,N_HSL,C_ZJLDWMC,C_FJLDWMC,C_PLANEMP,C_PK_PSID,C_SLAB_SIZE from TB_MATRL_MAIN ");
            strSql.Append(" where C_PK_INVMANDOC=:C_PK_INVMANDOC ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_PK_INVMANDOC", OracleDbType.Varchar2,100)};
            parameters[0].Value = C_PK_INVMANDOC;

            Mod_TB_MATRL_MAIN model = new Mod_TB_MATRL_MAIN();
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
        /// 获取物料编码，断面和定尺
        /// </summary>
        /// <param name="C_STL_GRD"></param>
        /// <returns></returns>
        public DataSet GetKPMatrlList(string C_STL_GRD)
        {

            string sql = @"SELECT  T.*
           FROM TB_MATRL_MAIN T
          WHERE T.C_ID LIKE '614%'
            AND T.C_MAT_TYPE = '6'
            AND T.N_LTH IS NOT NULL
            AND T.C_MAT_NAME NOT LIKE '%来料%'
            AND T.C_MAT_NAME NOT LIKE '%封存%'
            AND T.C_STL_GRD='" + C_STL_GRD + "' ";
            return DbHelperOra.Query(sql);
        }



        /// <summary>
        /// 获取所有物料编码信息
        /// </summary>
        /// <param name="C_MAT_CODE">物料编码</param>
        /// <param name="C_MAT_NAME">物料名称</param>
        /// <param name="C_STL_GRD">钢种</param>
        /// <param name="C_SLAB_SIZE">断面</param>
        /// <returns></returns>
        public DataSet Get_Slab_List(string C_MAT_CODE, string C_MAT_NAME, string C_STL_GRD, string C_SLAB_SIZE)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT T.C_MAT_CODE AS 物料编码,T.C_MAT_NAME AS 物料名称,T.C_STL_GRD AS 钢种,TB.C_STD_CODE AS 执行标准,T.C_SLAB_SIZE AS 断面,T.N_LTH AS 定尺,T.C_PK_INVBASDOC FROM TB_MATRL_MAIN T INNER JOIN TQB_STD_MAIN TB ON T.C_STL_GRD=TB.C_STL_GRD where T.C_CLS_TYPE='N' AND T.C_MAT_TYPE = '6' AND TB.N_IS_CHECK=1 AND TB.N_STATUS=1 ");

            if (C_MAT_CODE.Trim() != "")
            {
                strSql.Append(" and T.C_MAT_CODE like '" + C_MAT_CODE + "%'");
            }
            if (C_MAT_NAME.Trim() != "")
            {
                strSql.Append(" and T.C_MAT_NAME like '%" + C_MAT_NAME + "%'");
            }
            if (C_STL_GRD.Trim() != "")
            {
                strSql.Append(" and T.C_STL_GRD like '%" + C_STL_GRD + "%'");
            }
            if (C_SLAB_SIZE.Trim() != "")
            {
                strSql.Append(" and T.C_SLAB_SIZE like '%" + C_SLAB_SIZE + "%'");
            }

            strSql.Append(" ORDER BY T.C_MAT_CODE "); return DbHelperOra.Query(strSql.ToString());
        }

        #endregion  BasicMethod

        #region 获取热轧钢坯物料信息
        /// <summary>
        /// 获取热轧钢坯物料信息
        /// </summary>
        /// <param name="C_STL_GRD">钢种</param>
        /// <param name="C_SPEC">热轧坯规格</param>
        /// <param name="LX">工艺路线</param>
        /// <returns></returns>
        public DataTable GetKPMatral(string C_STL_GRD, string C_SPEC, string LX)
        {
            string sql = " SELECT * FROM tb_matrl_main  t WHERE t.c_id LIKE '614%' AND T.C_MAT_NAME LIKE '%" + LX + "%' AND  t.c_stl_grd='" + C_STL_GRD + "' AND t.c_spec='" + C_SPEC + "' ";
            return DbHelperOra.Query(sql).Tables[0];

        }



        /// <summary>
        ///  获取连铸物料编码，断面和定尺
        /// </summary>
        /// <param name="C_STL_GRD">钢种</param>
        /// <param name="wllj">热轧坯工艺路线</param>
        /// <param name="dfp">是否大方坯</param>
        /// <returns></returns>
        public DataSet GetLZPMatrlList(string C_STL_GRD, string wllj, string dfp)
        {

            string sql = @"SELECT   T.C_ID,'【'||t.c_stl_grd||'】'||T.C_MAT_NAME||'【'||T.C_SPEC||'】' WLMC
           FROM TB_MATRL_MAIN T
          WHERE ( T.C_ID LIKE '611%' OR  T.C_ID LIKE '612%' OR  T.C_ID LIKE '613%')
            AND T.C_MAT_TYPE = '6'";
            if (dfp == "Y")
            {
                sql = sql + @"  AND T.C_SLAB_SIZE='280*325'  ";
            }
            else
            {
                sql = sql + @"  AND T.C_SLAB_SIZE<>'280*325'  ";
            }

            sql = sql + @"   AND T.N_LTH IS NOT NULL
            AND T.C_MAT_NAME NOT LIKE '%来料%'
            AND T.C_MAT_NAME NOT LIKE '%封存%'
            AND T.C_MAT_NAME LIKE '%" + wllj + "%'";
            sql = sql + " AND T.C_STL_GRD='" + C_STL_GRD + "' ";
            return DbHelperOra.Query(sql);
        }


        /// <summary>
        ///  获取热轧坯物料编码，断面和定尺
        /// </summary>
        /// <param name="C_STL_GRD">钢种</param>
        /// <param name="wllj">热轧坯工艺路线</param>
        /// <returns></returns>
        public DataSet GetRZPMatrlList(string C_STL_GRD, string wllj)
        {

            string sql = @"SELECT  T.C_ID,'【'||t.c_stl_grd||'】'||T.C_MAT_NAME||'【'||T.C_SPEC||'】' WLMC
           FROM TB_MATRL_MAIN T
          WHERE T.C_ID LIKE '614%'
            AND T.C_MAT_TYPE = '6'
            AND T.N_LTH IS NOT NULL
            AND T.C_MAT_NAME NOT LIKE '%来料%'
            AND T.C_MAT_NAME NOT LIKE '%封存%'
            AND T.C_MAT_NAME LIKE '%" + wllj + "%'";
            sql = sql + " AND T.C_STL_GRD='" + C_STL_GRD + "' ";
            return DbHelperOra.Query(sql);
        }



        /// <summary>
        /// 同步物料编码
        /// </summary> 
        /// <returns></returns>
        public string JUDGE_MATRL()
        {
            OracleParameter[] parameters = {
            new OracleParameter("P_MSG", OracleDbType.Varchar2,100)};

            parameters[0].Value = "0";

            return DbHelperOra.RunProcedureOut("PKG_TB_MATRL_MAIN.P_TB_MATRL_MIAN", parameters);
        }
        /// <summary>
        /// 同步换算率
        /// </summary> 
        /// <returns></returns>
        public string JUDGE_MATRL_HSL()
        {
            OracleParameter[] parameters = {
            new OracleParameter("P_MSG", OracleDbType.Varchar2,100)};

            parameters[0].Value = "0";

            return DbHelperOra.RunProcedureOut("PKG_TB_MATRL_MAIN.UPDATE_SLAB_HSL", parameters);
        }
        #endregion



        #region 根据钢坯定尺维护表获取钢坯的物料信息
        /// <summary>
        /// 根据开坯断面和定尺查询连铸大方坯的物料信息
        /// </summary>
        /// <param name="C_STL_GRD">钢种</param>
        /// <param name="C_STD_CODE">执行标准</param>
        /// <param name="C_KP_SIZE">开坯断面</param>
        /// <param name="N_KP_LENTH">开坯定尺</param>
        /// <returns></returns>
        public DataTable GetCCMSlabByRZsLAB(string C_STL_GRD, string C_STD_CODE, string C_KP_SIZE, string N_KP_LENTH)
        {
            string sql = @"SELECT T.C_STL_GRD,
       T.C_STD_CODE,
       TB.C_MAT_CODE,
       TB.C_MAT_NAME,
       TB.C_SLAB_SIZE,
       TB.N_LTH,
       TB.N_HSL
  FROM TB_SLAB_MATRAL T
  LEFT JOIN TB_MATRL_MAIN TB
    ON T.C_MATRAL_CODE = TB.C_ID
  LEFT JOIN TB_MATRL_CONTRAST TC
    ON TB.C_SLAB_SIZE = TC.C_SLAB_SIZE
   AND TB.N_LTH = TC.N_SLAB_LENTH
 WHERE TB.C_MAT_NAME NOT LIKE '%封存%'
   AND TB.C_MAT_NAME NOT LIKE '%来料%'
   AND T.N_STATUS = 1
   AND TB.C_CLS_TYPE = 'N'
   AND TB.C_REMARK2>0
   AND TB.N_LTH IS NOT NULL
   AND T.C_STL_GRD = '" + C_STL_GRD + "' ";
            // sql = sql + "AND T.C_STD_CODE = '" + C_STD_CODE + "' ";
            if (C_STD_CODE.Contains("Q/XG") || C_STD_CODE.Contains("GB/T") || C_STD_CODE.Contains("Q/邢钢"))
            {
                C_STD_CODE = C_STD_CODE.Split('-')[0].Split('.')[0];
                sql = sql + " AND T.C_STD_CODE LIKE '" + C_STD_CODE + "%'";
            }
            else
            {
                sql = sql + "   AND T.C_STD_CODE = '" + C_STD_CODE + "'";
            }

            sql = sql + " AND TC.C_KP_SIZE = '" + C_KP_SIZE + "'   AND TC.N_KP_LENTH = '" + N_KP_LENTH + "'   AND SUBSTR(TB.C_ID, 0, 3) IN ('611', '612', '613')";

            return DbHelperOra.Query(sql).Tables[0];

        }

        /// <summary>
        /// 查询连铸坯物料信息(线材计划)
        /// </summary>
        /// <param name="C_STL_GRD">钢种</param>
        /// <param name="C_STD_CODE">执行标准</param>
        /// <param name="C_SLAB_SIZE">断面</param>
        ///  <param name="C_ROUTE_DESC">工艺路线</param>
        /// <returns></returns>
        public DataTable GetCCMSlab(string C_STL_GRD, string C_STD_CODE, string C_ROUTE_DESC, string C_SLAB_SIZE)
        {
            string sql = @"SELECT T.C_STL_GRD,
       T.C_STD_CODE,
T.C_ROUTE_DESC,
       TB.C_MAT_CODE,
       TB.C_MAT_NAME,
       TB.C_SLAB_SIZE,
       TB.N_LTH,
       TB.N_HSL
  FROM TB_SLAB_MATRAL T
  LEFT JOIN TB_MATRL_MAIN TB
    ON T.C_MATRAL_CODE = TB.C_ID
 WHERE TB.C_MAT_NAME NOT LIKE '%封存%'
   AND TB.C_MAT_NAME NOT LIKE '%来料%'
   AND T.N_STATUS = 1
  AND TB.C_REMARK2>0
AND TB.N_LTH IS NOT NULL
   AND TB.C_CLS_TYPE = 'N'
   AND SUBSTR(TB.C_ID, 0, 3) IN('611', '612', '613')";
            sql = sql + "  AND T.C_STL_GRD = '" + C_STL_GRD + "'";

            if (C_STD_CODE.Contains("Q/XG") || C_STD_CODE.Contains("GB/T") || C_STD_CODE.Contains("Q/邢钢"))
            {
                C_STD_CODE = C_STD_CODE.Split('-')[0].Split('.')[0];
                sql = sql + " AND T.C_STD_CODE LIKE '" + C_STD_CODE + "%'";
            }
            else
            {
                sql = sql + "   AND T.C_STD_CODE = '" + C_STD_CODE + "'";
            }

            // sql = sql + "   AND T.C_STD_CODE = '" + C_STD_CODE + "' ";
            if (C_SLAB_SIZE.Trim() != "")
            {
                sql = sql + "  AND TB.C_SLAB_SIZE = '" + C_SLAB_SIZE + "' ";
            }
            if (C_ROUTE_DESC.Trim()!="")
            {
                sql = sql + "  AND t.C_ROUTE_DESC = '" + C_ROUTE_DESC + "' ";
            }
            sql = sql + " ORDER BY DECODE(TB.N_LTH,9100,1,10500,2,10700,3,10900,4,10850,5,6120,6,7) ";

            return DbHelperOra.Query(sql).Tables[0];

        }

        /// <summary>
        /// 查询连铸坯物料信息(来料加工计划)
        /// </summary>
        /// <param name="C_STL_GRD">钢种</param>
        /// <param name="C_STD_CODE">执行标准</param>
        /// <param name="C_SLAB_SIZE">断面</param>
        ///  <param name="C_ROUTE_DESC">工艺路线</param>
        /// <returns></returns>
        public DataTable GetSlabLL(string C_STL_GRD, string C_STD_CODE, string C_ROUTE_DESC, string C_SLAB_SIZE)
        {

            string sql = @"SELECT T.C_STL_GRD,
       T.C_STD_CODE,
T.C_ROUTE_DESC,
       TB.C_MAT_CODE,
       TB.C_MAT_NAME,
       TB.C_SLAB_SIZE,
       TB.N_LTH,
       TB.N_HSL
  FROM TB_SLAB_MATRAL T
  LEFT JOIN TB_MATRL_MAIN TB
    ON T.C_MATRAL_CODE = TB.C_ID
 WHERE TB.C_MAT_NAME NOT LIKE '%封存%'
   AND TB.C_MAT_NAME  LIKE '%来料%'
   AND T.N_STATUS = 1
  AND TB.C_REMARK2>0
AND TB.N_LTH IS NOT NULL
   AND TB.C_CLS_TYPE = 'N'
   AND SUBSTR(TB.C_ID, 0, 3) IN('611', '612', '613')";
            sql = sql + "  AND T.C_STL_GRD = '" + C_STL_GRD + "'";

            if (C_STD_CODE.Contains("Q/XG") || C_STD_CODE.Contains("GB/T") || C_STD_CODE.Contains("Q/邢钢"))
            {
                C_STD_CODE = C_STD_CODE.Split('-')[0].Split('.')[0];
                sql = sql + " AND T.C_STD_CODE LIKE '" + C_STD_CODE + "%'";
            }
            else
            {
                sql = sql + "   AND T.C_STD_CODE = '" + C_STD_CODE + "'";
            }

            // sql = sql + "   AND T.C_STD_CODE = '" + C_STD_CODE + "' ";
            if (C_SLAB_SIZE.Trim() != "")
            {
                sql = sql + "  AND TB.C_SLAB_SIZE = '" + C_SLAB_SIZE + "' ";
            }
            if (C_ROUTE_DESC.Trim() != "")
            {
                sql = sql + "  AND t.C_ROUTE_DESC = '" + C_ROUTE_DESC + "' ";
            }
            sql = sql + " ORDER BY DECODE(TB.N_LTH,9100,1,10500,2,10700,3,10900,4,10850,5,6120,6,7) ";

            return DbHelperOra.Query(sql).Tables[0];
        }

        /// <summary>
        /// 根据连铸坯获取热轧坯钢坯信息
        /// </summary>
        /// <param name="C_STL_GRD">钢种</param>
        /// <param name="C_STD_CODE">执行标准</param>
        /// <param name="C_SLAB_SIZE">连铸坯断面</param>
        /// <param name="N_SLAB_LENTH">连铸坯定尺</param>
        /// <returns></returns>
        public DataTable GetRZSlab(string C_STL_GRD, string C_STD_CODE, string C_SLAB_SIZE, string N_SLAB_LENTH)
        {
            string sql = @"SELECT T.C_STL_GRD,
       T.C_STD_CODE,
       TB.C_MAT_CODE,
       TB.C_MAT_NAME,
       TB.C_SLAB_SIZE,
       TB.N_LTH,
       TB.N_HSL
  FROM TB_SLAB_MATRAL T
  LEFT JOIN TB_MATRL_MAIN TB
    ON T.C_MATRAL_CODE = TB.C_ID
  LEFT JOIN TB_MATRL_CONTRAST TC
    ON TB.C_SLAB_SIZE = TC.C_KP_SIZE
   AND TB.N_LTH = TC.N_KP_LENTH
 WHERE TB.C_MAT_NAME NOT LIKE '%封存%'
   AND TB.C_MAT_NAME NOT LIKE '%来料%'
   AND T.N_STATUS = 1
  AND TB.C_REMARK2>0
   AND TB.C_CLS_TYPE = 'N'
AND TB.N_LTH IS NOT NULL
   AND T.C_STL_GRD = '" + C_STL_GRD + "' ";
            //sql = sql + " AND T.C_STD_CODE = '" + C_STD_CODE + "' ";
            if (C_STD_CODE.Contains("Q/XG") || C_STD_CODE.Contains("GB/T") || C_STD_CODE.Contains("Q/邢钢"))
            {
                C_STD_CODE = C_STD_CODE.Split('-')[0].Split('.')[0];
                sql = sql + " AND T.C_STD_CODE LIKE '" + C_STD_CODE + "%'";
            }
            else
            {
                sql = sql + "   AND T.C_STD_CODE = '" + C_STD_CODE + "'";
            }

            sql = sql + " AND TC.C_SLAB_SIZE = '" + C_SLAB_SIZE + "'   AND TC.N_SLAB_LENTH = '" + N_SLAB_LENTH + "'   AND SUBSTR(TB.C_ID, 0, 3) IN ('614') ORDER BY DECODE(TB.C_SLAB_SIZE, '160*160', 1, 2)";
            return DbHelperOra.Query(sql).Tables[0];

        }

        /// <summary>
        /// 根据连铸坯获取热轧坯钢坯信息(来料加工)
        /// </summary>
        /// <param name="C_STL_GRD">钢种</param>
        /// <param name="C_STD_CODE">执行标准</param>
        /// <param name="C_SLAB_SIZE">连铸坯断面</param>
        /// <param name="N_SLAB_LENTH">连铸坯定尺</param>
        /// <returns></returns>
        public DataTable GetRZSlabLL(string C_STL_GRD, string C_STD_CODE, string C_SLAB_SIZE, string N_SLAB_LENTH)
        {
            string sql = @"SELECT T.C_STL_GRD,
       T.C_STD_CODE,
       TB.C_MAT_CODE,
       TB.C_MAT_NAME,
       TB.C_SLAB_SIZE,
       TB.N_LTH,
       TB.N_HSL
  FROM TB_SLAB_MATRAL T
  LEFT JOIN TB_MATRL_MAIN TB
    ON T.C_MATRAL_CODE = TB.C_ID
  LEFT JOIN TB_MATRL_CONTRAST TC
    ON TB.C_SLAB_SIZE = TC.C_KP_SIZE
   AND TB.N_LTH = TC.N_KP_LENTH
 WHERE TB.C_MAT_NAME NOT LIKE '%封存%'
   AND TB.C_MAT_NAME  LIKE '%来料%'
   AND T.N_STATUS = 1
  AND TB.C_REMARK2>0
   AND TB.C_CLS_TYPE = 'N'
AND TB.N_LTH IS NOT NULL
   AND T.C_STL_GRD = '" + C_STL_GRD + "' ";
            //sql = sql + " AND T.C_STD_CODE = '" + C_STD_CODE + "' ";
            if (C_STD_CODE.Contains("Q/XG") || C_STD_CODE.Contains("GB/T") || C_STD_CODE.Contains("Q/邢钢"))
            {
                C_STD_CODE = C_STD_CODE.Split('-')[0].Split('.')[0];
                sql = sql + " AND T.C_STD_CODE LIKE '" + C_STD_CODE + "%'";
            }
            else
            {
                sql = sql + "   AND T.C_STD_CODE = '" + C_STD_CODE + "'";
            }

            sql = sql + " AND TC.C_SLAB_SIZE = '" + C_SLAB_SIZE + "'   AND TC.N_SLAB_LENTH = '" + N_SLAB_LENTH + "'   AND SUBSTR(TB.C_ID, 0, 3) IN ('614') ORDER BY DECODE(TB.C_SLAB_SIZE, '160*160', 1, 2)";
            return DbHelperOra.Query(sql).Tables[0];

        }
        /// <summary>
        /// 验证物料是否可用
        /// </summary>
        /// <param name="C_MAT_CODE">物料编码</param>
        /// <returns></returns>
        public bool IsCanUse(string C_MAT_CODE)
        {
            string sql = @"SELECT COUNT(1)
  FROM TB_MATRL_MAIN T
 WHERE T.C_MAT_NAME NOT LIKE '%封存%'
   AND T.C_MAT_NAME NOT LIKE '%来料%'
   AND T.C_CLS_TYPE = 'N'
   AND T.C_REMARK2 > 0
   AND T.C_ID = '" + C_MAT_CODE + "'";
            object obj = DbHelperOra.GetSingle(sql);
            if (obj == null || Convert.ToInt32(obj) == 0)
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        #endregion


        #region 维护不锈钢修磨标准查询
        /// <summary>
        /// 查询代维护钢种规格
        /// </summary>
        /// <param name="C_STL_GRD">钢种</param>
        /// <param name="C_IS_BXG">是否不锈钢</param>
        /// <returns></returns>
        public DataTable GetMatral(string C_STL_GRD,string C_IS_BXG)
        {
            string sql = @"SELECT T.C_STL_GRD, T.C_SLAB_SIZE, T.N_LTH, A.C_IS_BXG
  FROM TB_MATRL_MAIN T
  LEFT JOIN(SELECT DISTINCT T.C_STL_GRD, T.C_IS_BXG
               FROM TQB_STD_MAIN T
              WHERE T.N_STATUS = 1
                AND T.N_IS_CHECK = 1) A
    ON T.C_STL_GRD = A.C_STL_GRD
 WHERE T.C_MAT_TYPE = '6'
   AND T.N_LTH IS NOT NULL
   AND T.C_MAT_NAME NOT LIKE '%来料%'
   AND T.C_MAT_NAME NOT LIKE '%封存%'";
            if (C_IS_BXG.Trim()!="")
            {
                sql = sql + "   AND A.C_IS_BXG = '" + C_IS_BXG + "'";
            }
            if (C_STL_GRD.Trim() != "")
            {
                sql = sql + "   AND T.C_STL_GRD LIKE  '%" + C_STL_GRD + "%'";
            }
            //sql = sql + "  AND(T.C_STL_GRD, T.C_SLAB_SIZE, T.N_LTH) NOT IN      (SELECT A.C_STL_GRD, A.C_SLAB_SIZE, A.N_LTH FROM TPB_BXGXMGZ A) ";
            sql = sql + "    ORDER BY T.C_STL_GRD, T.C_SLAB_SIZE, T.N_LTH";
            return DbHelperOra.Query(sql).Tables[0];
        }

        #endregion


        public DataTable GetWL(string C_STL_GRD,string C_SLAB_SIZE,string N_LTH)
        {
            String sql = @"SELECT T.*  FROM TB_MATRL_MAIN T WHERE T.C_MAT_TYPE = '6'";
            sql = sql + " AND T.C_STL_GRD = '"+ C_STL_GRD + "'";
            sql = sql + "   AND T.C_SLAB_SIZE = '"+ C_SLAB_SIZE + "'";
            sql = sql + "  AND T.N_LTH = '"+ N_LTH + "'";
            sql = sql + "  AND T.C_MAT_NAME NOT LIKE '%来料%'";
            sql = sql + "  AND T.C_MAT_NAME NOT LIKE '%封存%'";//T.N_HSL
            return DbHelperOra.Query(sql).Tables[0];
        }

    }
}

