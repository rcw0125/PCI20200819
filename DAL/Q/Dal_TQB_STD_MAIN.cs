using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;
namespace DAL
{
    /// <summary>
    /// 数据访问类:TQB_STD_MAIN
    /// </summary>
    public partial class Dal_TQB_STD_MAIN
    {
        public Dal_TQB_STD_MAIN()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string C_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TQB_STD_MAIN");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)          };
            parameters[0].Value = C_ID;

            return DbHelperOra.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Mod_TQB_STD_MAIN model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TQB_STD_MAIN(");
            strSql.Append("C_ID,C_STD_TYPE,C_STD_CODE,C_STD_DESC,C_STL_GRD,C_PROD_NAME,C_PROD_KIND,C_USES,n_EDIT_NUM,C_EDITION,C_IS_LF,C_IS_RH,C_IS_HL,C_IS_XM,C_IRON_REQUIRE,C_STOCK_REQUIRE,C_DELIVERY_STATE,C_PHYSICS_TIME,N_IS_CHECK,N_STATUS,C_REMARK,C_EMP_ID,C_IS_BXG)");
            strSql.Append(" values (");
            strSql.Append(":C_ID,:C_STD_TYPE,:C_STD_CODE,:C_STD_DESC,:C_STL_GRD,:C_PROD_NAME,:C_PROD_KIND,:C_USES,:n_EDIT_NUM,:C_EDITION,:C_IS_LF,:C_IS_RH,:C_IS_HL,:C_IS_XM,:C_IRON_REQUIRE,:C_STOCK_REQUIRE,:C_DELIVERY_STATE,:C_PHYSICS_TIME,:N_IS_CHECK,:N_STATUS,:C_REMARK,:C_EMP_ID,:C_IS_BXG)");
            OracleParameter[] parameters = {
                new OracleParameter(":C_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STD_TYPE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STD_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STD_DESC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STL_GRD", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PROD_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PROD_KIND", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_USES", OracleDbType.Varchar2,100),
                    new OracleParameter(":n_EDIT_NUM", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_EDITION", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_IS_LF", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_IS_RH", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_IS_HL", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_IS_XM", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_IRON_REQUIRE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STOCK_REQUIRE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_DELIVERY_STATE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PHYSICS_TIME", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_IS_CHECK", OracleDbType.Decimal,1),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                     new OracleParameter(":C_IS_BXG", OracleDbType.Varchar2,100)
            };
            parameters[0].Value = model.C_ID;
            parameters[1].Value = model.C_STD_TYPE;
            parameters[2].Value = model.C_STD_CODE;
            parameters[3].Value = model.C_STD_DESC;
            parameters[4].Value = model.C_STL_GRD;
            parameters[5].Value = model.C_PROD_NAME;
            parameters[6].Value = model.C_PROD_KIND;
            parameters[7].Value = model.C_USES;
            parameters[8].Value = model.N_EDIT_NUM;
            parameters[9].Value = model.C_EDITION;
            parameters[10].Value = model.C_IS_LF;
            parameters[11].Value = model.C_IS_RH;
            parameters[12].Value = model.C_IS_HL;
            parameters[13].Value = model.C_IS_XM;
            parameters[14].Value = model.C_IRON_REQUIRE;
            parameters[15].Value = model.C_STOCK_REQUIRE;
            parameters[16].Value = model.C_DELIVERY_STATE;
            parameters[17].Value = model.C_PHYSICS_TIME;
            parameters[18].Value = model.N_IS_CHECK;
            parameters[19].Value = model.N_STATUS;
            parameters[20].Value = model.C_REMARK;
            parameters[21].Value = model.C_EMP_ID;
            parameters[22].Value = model.C_IS_BXG;

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
        public bool Update(Mod_TQB_STD_MAIN model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TQB_STD_MAIN set ");
            strSql.Append("C_STD_TYPE=:C_STD_TYPE,");
            strSql.Append("C_STD_CODE=:C_STD_CODE,");
            strSql.Append("C_STD_DESC=:C_STD_DESC,");
            strSql.Append("C_STL_GRD=:C_STL_GRD,");
            strSql.Append("C_PROD_NAME=:C_PROD_NAME,");
            strSql.Append("C_PROD_KIND=:C_PROD_KIND,");
            strSql.Append("C_USES=:C_USES,");
            strSql.Append("n_EDIT_NUM=:n_EDIT_NUM,");
            strSql.Append("C_EDITION=:C_EDITION,");
            strSql.Append("C_IS_LF=:C_IS_LF,");
            strSql.Append("C_IS_RH=:C_IS_RH,");
            strSql.Append("C_IS_HL=:C_IS_HL,");
            strSql.Append("C_IS_XM=:C_IS_XM,");
            strSql.Append("C_IRON_REQUIRE=:C_IRON_REQUIRE,");
            strSql.Append("C_STOCK_REQUIRE=:C_STOCK_REQUIRE,");
            strSql.Append("C_DELIVERY_STATE=:C_DELIVERY_STATE,");
            strSql.Append("C_PHYSICS_TIME=:C_PHYSICS_TIME,");
            strSql.Append("N_IS_CHECK=:N_IS_CHECK,");
            strSql.Append("N_STATUS=:N_STATUS,");
            strSql.Append("C_REMARK=:C_REMARK,");
            strSql.Append("C_EMP_ID=:C_EMP_ID,");
            strSql.Append("D_MOD_DT=:D_MOD_DT,");
            strSql.Append("C_IS_BXG=:C_IS_BXG");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_STD_TYPE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STD_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STD_DESC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STL_GRD", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PROD_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PROD_KIND", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_USES", OracleDbType.Varchar2,100),
                    new OracleParameter(":n_EDIT_NUM", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_EDITION", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_IS_LF", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_IS_RH", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_IS_HL", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_IS_XM", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_IRON_REQUIRE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STOCK_REQUIRE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_DELIVERY_STATE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PHYSICS_TIME", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_IS_CHECK", OracleDbType.Decimal,1),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":C_IS_BXG", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.C_STD_TYPE;
            parameters[1].Value = model.C_STD_CODE;
            parameters[2].Value = model.C_STD_DESC;
            parameters[3].Value = model.C_STL_GRD;
            parameters[4].Value = model.C_PROD_NAME;
            parameters[5].Value = model.C_PROD_KIND;
            parameters[6].Value = model.C_USES;
            parameters[7].Value = model.N_EDIT_NUM;
            parameters[8].Value = model.C_EDITION;
            parameters[9].Value = model.C_IS_LF;
            parameters[10].Value = model.C_IS_RH;
            parameters[11].Value = model.C_IS_HL;
            parameters[12].Value = model.C_IS_XM;
            parameters[13].Value = model.C_IRON_REQUIRE;
            parameters[14].Value = model.C_STOCK_REQUIRE;
            parameters[15].Value = model.C_DELIVERY_STATE;
            parameters[16].Value = model.C_PHYSICS_TIME;
            parameters[17].Value = model.N_IS_CHECK;
            parameters[18].Value = model.N_STATUS;
            parameters[19].Value = model.C_REMARK;
            parameters[20].Value = model.C_EMP_ID;
            parameters[21].Value = model.D_MOD_DT;
            parameters[22].Value = model.C_IS_BXG;
            parameters[23].Value = model.C_ID;

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
            strSql.Append("delete from TQB_STD_MAIN ");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)          };
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
            strSql.Append("delete from TQB_STD_MAIN ");
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
        public Mod_TQB_STD_MAIN GetModel(string C_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_STD_TYPE,C_STD_CODE,C_STD_DESC,C_STL_GRD,C_PROD_NAME,C_PROD_KIND,C_USES,n_EDIT_NUM,C_EDITION,C_IS_LF,C_IS_RH,C_IS_HL,C_IS_XM,C_IRON_REQUIRE,C_STOCK_REQUIRE,C_DELIVERY_STATE,C_PHYSICS_TIME,N_IS_CHECK,N_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT,C_IS_BXG from TQB_STD_MAIN ");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)          };
            parameters[0].Value = C_ID;

            Mod_TQB_STD_MAIN model = new Mod_TQB_STD_MAIN();
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
        public Mod_TQB_STD_MAIN DataRowToModel(DataRow row)
        {
            Mod_TQB_STD_MAIN model = new Mod_TQB_STD_MAIN();
            if (row != null)
            {
                if (row["C_ID"] != null)
                {
                    model.C_ID = row["C_ID"].ToString();
                }
                if (row["C_STD_TYPE"] != null)
                {
                    model.C_STD_TYPE = row["C_STD_TYPE"].ToString();
                }
                if (row["C_STD_CODE"] != null)
                {
                    model.C_STD_CODE = row["C_STD_CODE"].ToString();
                }
                if (row["C_STD_DESC"] != null)
                {
                    model.C_STD_DESC = row["C_STD_DESC"].ToString();
                }
                if (row["C_STL_GRD"] != null)
                {
                    model.C_STL_GRD = row["C_STL_GRD"].ToString();
                }
                if (row["C_PROD_NAME"] != null)
                {
                    model.C_PROD_NAME = row["C_PROD_NAME"].ToString();
                }
                if (row["C_PROD_KIND"] != null)
                {
                    model.C_PROD_KIND = row["C_PROD_KIND"].ToString();
                }
                if (row["C_USES"] != null)
                {
                    model.C_USES = row["C_USES"].ToString();
                }
                if (row["N_EDIT_NUM"] != null && row["N_EDIT_NUM"].ToString() != "")
                {
                    model.N_EDIT_NUM = decimal.Parse(row["N_EDIT_NUM"].ToString());
                }
                if (row["C_EDITION"] != null)
                {
                    model.C_EDITION = row["C_EDITION"].ToString();
                }
                if (row["C_IS_LF"] != null)
                {
                    model.C_IS_LF = row["C_IS_LF"].ToString();
                }
                if (row["C_IS_RH"] != null)
                {
                    model.C_IS_RH = row["C_IS_RH"].ToString();
                }
                if (row["C_IS_HL"] != null)
                {
                    model.C_IS_HL = row["C_IS_HL"].ToString();
                }
                if (row["C_IS_XM"] != null)
                {
                    model.C_IS_XM = row["C_IS_XM"].ToString();
                }
                if (row["C_IRON_REQUIRE"] != null)
                {
                    model.C_IRON_REQUIRE = row["C_IRON_REQUIRE"].ToString();
                }
                if (row["C_STOCK_REQUIRE"] != null)
                {
                    model.C_STOCK_REQUIRE = row["C_STOCK_REQUIRE"].ToString();
                }
                if (row["C_DELIVERY_STATE"] != null)
                {
                    model.C_DELIVERY_STATE = row["C_DELIVERY_STATE"].ToString();
                }
                if (row["C_PHYSICS_TIME"] != null)
                {
                    model.C_PHYSICS_TIME = row["C_PHYSICS_TIME"].ToString();
                }
                if (row["N_IS_CHECK"] != null && row["N_IS_CHECK"].ToString() != "")
                {
                    model.N_IS_CHECK = decimal.Parse(row["N_IS_CHECK"].ToString());
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
                if (row["C_IS_BXG"] != null)
                {
                    model.C_IS_BXG = row["C_IS_BXG"].ToString();
                }
            }
            return model;
        }
        /// <summary>
        /// 获取标准列表
        /// </summary>              
        /// <param name="C_STL_GRD">钢种</param>
        /// <param name="C_IS_BXG">是否不锈钢</param>
        /// <returns></returns>
		public DataSet GetList_Type(string C_STL_GRD, string C_IS_BXG)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select distinct t.c_stl_grd from tqb_std_main t where t.n_status =1 and t.N_IS_CHECK=1   ");
            if (C_IS_BXG != "")
            {
                strSql.Append(" and t.C_IS_BXG  = '" + C_IS_BXG + "' ");
            }
            if (C_STL_GRD != "")
            {
                strSql.Append(" and t.c_stl_grd like '%" + C_STL_GRD + "%' ");
            }
            strSql.Append(" order by t.c_stl_grd");
            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 获取钢种执行标准
        /// </summary>              
        /// <param name="C_STL_GRD">钢种</param>
        /// <returns></returns>
        public DataSet GetList_STD(string C_STL_GRD)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select t.C_ID, t.C_STD_CODE from tqb_std_main t where 1=1  ");
            if (C_STL_GRD != "")
            {
                strSql.Append(" and t.c_stl_grd='" + C_STL_GRD + "' ");
            }
            strSql.Append(" order by t.C_STD_CODE");
            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 获取标准列表
        /// </summary>
        /// <param name="C_IS_BXG">是否为不锈钢</param>
        /// <param name="C_STL_GRD">钢种</param>
        /// <returns></returns>
        public DataSet GetList_Std(string C_IS_BXG, string C_STL_GRD)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  t.C_STD_CODE from tqb_std_main t where t.N_IS_CHECK=1 and N_STATUS=1  ");
            if (C_IS_BXG != "")
            {
                strSql.Append(" and t.C_IS_BXG='" + C_IS_BXG + "' ");
            }
            if (C_STL_GRD != "")
            {
                strSql.Append(" and t.c_stl_grd='" + C_STL_GRD + "' ");
            }
            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取标准列表
        /// </summary>      
        /// <param name="C_STD_CODE">标准代码</param>
        /// <param name="C_STL_GRD">钢种</param>
        /// <returns></returns>
        public DataSet GetList_ID(string C_STD_CODE, string C_STL_GRD)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  t.C_ID from tqb_std_main t where 1=1  ");

            if (C_STD_CODE != "")
            {
                strSql.Append(" and t.C_STD_CODE='" + C_STD_CODE + "' ");
            }

            if (C_STL_GRD != "")
            {
                strSql.Append(" and t.c_stl_grd='" + C_STL_GRD + "' ");
            }
            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        /// <param name="c_is_bxg">是否为不锈钢</param>
        /// <param name="is_check">是否审核</param>
        /// <param name="C_STD_TYPE">类型</param>
        /// <param name="C_STD_CODE">执行标准</param>
        /// <param name="C_STL_GRD">钢种</param>
        /// <returns></returns>
        public DataSet GetList(string c_is_bxg, int is_check, string C_STD_TYPE, string C_STD_CODE, string C_STL_GRD)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select a.C_ID,b.c_type_name,a.C_STD_TYPE,a.C_STD_CODE,a.C_STD_DESC,a.C_STL_GRD,a.C_PROD_NAME,a.C_PROD_KIND,a.C_USES,a.n_EDIT_NUM,a.C_EDITION,a.C_IS_LF,a.C_IS_RH,a.C_IS_HL,a.C_IS_XM,a.C_IRON_REQUIRE,a.C_STOCK_REQUIRE,a.C_DELIVERY_STATE,a.C_PHYSICS_TIME,DECODE(a.N_IS_CHECK,0,'未审核',1,'已审核') N_IS_CHECK,a.N_STATUS,a.C_REMARK,a.C_EMP_ID,a.D_MOD_DT,a.C_IS_BXG");
            strSql.Append(" FROM TQB_STD_MAIN a inner join tqb_std_type b on a.c_std_type=b.c_id where a.N_STATUS=1 and a.c_is_bxg='" + c_is_bxg + "'");
            strSql.Append(" and a.N_IS_CHECK= " + is_check + "");

            if (C_STD_TYPE != "全部")
            {
                strSql.Append(" and a.C_STD_TYPE= '" + C_STD_TYPE + "'");
            }
            if (C_STD_CODE != "")
            {
                strSql.Append(" and a.C_STD_CODE like '%" + C_STD_CODE + "%'");
            }
            if (C_STL_GRD != "")
            {
                strSql.Append(" and a.C_STL_GRD like  '%" + C_STL_GRD + "%'");
            }
            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得数据列表-
        /// </summary> 
        /// <param name="is_check">是否审核</param> 
        /// <param name="C_STD_CODE">执行标准</param>
        /// <param name="C_STL_GRD">钢种</param>
        /// <returns></returns>
        public DataSet GetList_GZ(int is_check, string C_STD_CODE, string C_STL_GRD)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select a.C_ID,b.c_type_name,a.C_STD_TYPE,a.C_STD_CODE,a.C_STD_DESC,a.C_STL_GRD,a.C_PROD_NAME,a.C_PROD_KIND,a.C_USES,a.n_EDIT_NUM,a.C_EDITION,a.C_IS_LF,a.C_IS_RH,a.C_IS_HL,a.C_IS_XM,a.C_IRON_REQUIRE,a.C_STOCK_REQUIRE,a.C_DELIVERY_STATE,a.C_PHYSICS_TIME,DECODE(a.N_IS_CHECK,0,'未审核',1,'已审核') N_IS_CHECK,a.N_STATUS,a.C_REMARK,a.C_EMP_ID,a.D_MOD_DT,a.C_IS_BXG");
            strSql.Append(" FROM TQB_STD_MAIN a inner join tqb_std_type b on a.c_std_type=b.c_id where a.N_STATUS=1 ");
            strSql.Append(" and a.N_IS_CHECK= " + is_check + "");

            if (C_STD_CODE != "")
            {
                strSql.Append(" and a.C_STD_CODE like '%" + C_STD_CODE + "%'");
            }
            if (C_STL_GRD != "")
            {
                strSql.Append(" and a.C_STL_GRD like  '%" + C_STL_GRD + "%'");
            }
            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 获得数据列表-
        /// </summary>  
        /// <param name="C_STD_CODE">执行标准</param>
        /// <param name="C_STL_GRD">钢种</param>
        /// <returns></returns>
        public DataSet GetList_QueryStdMatrl(string C_STD_CODE, string C_STL_GRD)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" select a.c_id,t.c_std_code,t.c_stl_grd,b.c_route_desc,a.c_mat_name,a.c_slab_size,a.N_LTH,c.c_zyx1,c.c_zyx2 ");
            strSql.Append(" from  tb_matrl_main a join tqb_std_main t on t.c_stl_grd=a.c_stl_grd join tqb_route b on t.c_std_code=b.c_std_code and t.c_stl_grd=b.c_stl_grd left join TB_STD_CONFIG c  on t.c_std_code=c.c_std_code and t.c_stl_grd=c.c_stl_grd  where a.c_mat_type='6' and t.n_is_check=1 and t.n_status=1  ");
            if (C_STD_CODE != "")
            {
                strSql.Append(" and t.C_STD_CODE like '%" + C_STD_CODE + "%'");
            }
            if (C_STL_GRD != "")
            {
                strSql.Append(" and t.C_STL_GRD like  '%" + C_STL_GRD + "%'");
            }
            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得数据列表-
        /// </summary>   
        /// <param name="C_STL_GRD">钢种</param>
        /// <returns></returns>
        public DataSet GetList_GroupStlGrd(string C_STL_GRD, string C_STD_CODE)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" SELECT T.C_STL_GRD, T.C_STD_CODE, T.C_ROUTE_DESC FROM TQB_ROUTE T WHERE T.N_STATUS = 1  AND T.C_ROUTE_DESC LIKE '%KP%'  "); 
            if (C_STL_GRD != "")
            {
                strSql.Append(" and t.C_STL_GRD like  '%" + C_STL_GRD + "%'");
            }
            if (C_STD_CODE != "")
            {
                strSql.Append(" and t.C_STD_CODE like  '%" + C_STD_CODE + "%'");
            }
            strSql.Append(" GROUP BY T.C_STL_GRD, T.C_STD_CODE, T.C_ROUTE_DESC ORDER BY T.C_STL_GRD ");
            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM TQB_STD_MAIN ");
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
            strSql.Append(")AS Row, T.*  from TQB_STD_MAIN T ");
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
        /// 获取可代轧钢种标准列表
        /// </summary>
        /// <param name="C_STD_CODE">标准代码</param>
        /// <param name="C_STL_GRD">钢种</param>
        /// <returns></returns>
        public DataSet GetListByGZ(string C_STL_GRD, string C_STD_CODE)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select a.C_STD_CODE,a.C_STL_GRD,'' as N_SFXM");
            strSql.Append(" FROM TQB_STD_MAIN a where  N_STATUS=1 and N_IS_CHECK=1 ");
            strSql.Append("and a.C_ID not in(select a.C_ID from TQB_STD_MAIN a,TPB_REPLACE_GRD b where (a.N_STATUS=1 and a.N_IS_CHECK=1 and b.N_STATUS=1) and (b.c_stl_grd='" + C_STL_GRD + "' and b.c_std_code='" + C_STD_CODE + "') and ( a.c_stl_grd = b.c_replace_grd and a.c_std_code = b.c_replace_std_code ) or (a.c_stl_grd='" + C_STL_GRD + "' and a.c_std_code='" + C_STD_CODE + "' ))");
            strSql.Append("ORDER BY a.C_STL_GRD");
            return DbHelperOra.Query(strSql.ToString());

        }
        /// <summary>
        /// 获取标准列表
        /// </summary>
        /// <param name="C_STD_CODE">标准代码</param>
        /// <param name="C_STL_GRD">钢种</param>
        /// <returns></returns>
        public DataSet GetList(string C_STD_CODE, string C_STL_GRD)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select a.C_ID,a.C_PROD_KIND,a.C_PROD_NAME,a.C_STD_CODE,a.C_STL_GRD ");
            strSql.Append(" FROM TQB_STD_MAIN a where  N_STATUS=1 and N_IS_CHECK=1 ");

            if (C_STD_CODE != "")
            {
                strSql.Append(" and a.C_STD_CODE like '%" + C_STD_CODE + "%'");
            }
            if (C_STL_GRD != "")
            {
                strSql.Append(" and a.C_STL_GRD like '%" + C_STL_GRD + "%'");
            }
            strSql.Append("ORDER BY a.C_STL_GRD");
            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 获取标准列表
        /// </summary>
        /// <param name="C_IS_BXG">是否为不锈钢</param>
        /// <param name="Type">标准类型</param>
        /// <param name="C_STD_CODE">执行标准</param>
        /// <param name="C_STL_GRD">钢种</param>
        /// <returns></returns>
        public DataSet GetList_GPDC(string C_IS_BXG, string Type, string C_STD_CODE, string C_STL_GRD)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select a.C_ID,a.C_PROD_KIND,a.C_PROD_NAME,a.C_STD_CODE,a.C_STL_GRD ");
            strSql.Append(" FROM TQB_STD_MAIN a where  a.N_STATUS=1 and a.N_IS_CHECK=1 ");
            if (!string.IsNullOrEmpty(C_IS_BXG))
            {
                strSql.Append(" AND a.C_IS_BXG='" + C_IS_BXG + "' ");
            }
            if (Type != "全部")
            {
                strSql.Append(" and a.C_STD_TYPE= '" + Type + "'");
            }
            if (C_STD_CODE != "")
            {
                strSql.Append(" and a.C_STD_CODE like '%" + C_STD_CODE + "%'");
            }
            if (C_STL_GRD != "")
            {
                strSql.Append(" and a.C_STL_GRD like '%" + C_STL_GRD + "%'");
            }
            strSql.Append("ORDER BY a.C_STL_GRD");
            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取标准列表
        /// </summary>
        /// <param name="C_IS_BXG">是否为不锈钢</param> 
        /// <param name="C_STD_CODE">执行标准</param>
        /// <param name="C_STL_GRD">钢种</param>
        /// <returns></returns>
        public DataSet GetList_GYLX(string C_IS_BXG, string C_STD_CODE, string C_STL_GRD)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT T.C_STL_GRD, T.C_ROUTE_TYPE,T.C_STD_CODE, T.C_SPEC, T.C_ROUTE_DESC,  (CASE  WHEN T.C_ROUTE_DESC LIKE '%KP%' OR T.C_ROUTE_DESC LIKE '%DHL%' THEN  CASE  WHEN T.C_ROUTE_DESC LIKE '%ZL>LF>CC%' THEN   '(BL)'  WHEN T.C_ROUTE_DESC LIKE '%ZL>LF>RH>CC%'  THEN  '(BLR)'   WHEN T.C_ROUTE_DESC LIKE '%ZL>RH>CC%' THEN  '(BR)'  ELSE  ''  END  ELSE   ''  END) AS KP  FROM TQB_ROUTE T  WHERE T.N_STATUS = 1 AND T.C_IS_BXG='" + C_IS_BXG + "' ");

            if (C_STD_CODE != "")
            {
                strSql.Append(" and t.C_STD_CODE like '%" + C_STD_CODE + "%'");
            }
            if (C_STL_GRD != "")
            {
                strSql.Append(" and t.C_STL_GRD like '%" + C_STL_GRD + "%'");
            }
            strSql.Append(" GROUP BY T.C_STL_GRD,T.C_ROUTE_TYPE, T.C_STD_CODE,T.C_SPEC, T.C_ROUTE_DESC");
            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取标准列表
        /// </summary>
        /// <param name="C_STD_CODE">标准代码</param>
        /// <param name="C_STL_GRD">钢种</param>
        /// <param name="C_MAT_CODE">物料编码</param>
        /// <param name="C_MAT_NAME">物料名称</param>
        /// <returns></returns>
        public DataSet GetList(string C_STD_CODE, string C_STL_GRD, string C_MAT_CODE, string C_MAT_NAME)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT TA.C_ID,TA.C_STD_CODE,TA.C_STL_GRD,TB.C_SPEC,TB.C_MAT_CODE,TB.C_MAT_NAME,TB.C_INVSHORTNAME FROM TQB_STD_MAIN TA INNER JOIN TB_MATRL_MAIN TB ON TA.C_STL_GRD=TB.C_STL_GRD  where TA.N_STATUS=1 and TA.N_IS_CHECK=1 AND TB.C_IS_VISIBLE='1' AND TB.C_MAT_TYPE='6' ");

            if (C_STD_CODE != "")
            {
                strSql.Append(" and TA.C_STD_CODE like '" + C_STD_CODE + "%'");
            }
            if (C_STL_GRD != "")
            {
                strSql.Append(" and TA.C_STL_GRD like '" + C_STL_GRD + "%'");
            }

            if (C_MAT_CODE != "")
            {
                strSql.Append(" and TB.C_MAT_CODE like '" + C_MAT_CODE + "%'");
            }
            if (C_MAT_NAME != "")
            {
                strSql.Append(" and TB.C_MAT_NAME like '" + C_MAT_NAME + "%'");
            }

            strSql.Append(" ORDER BY TA.C_STD_CODE,TA.C_STL_GRD,TB.C_SPEC,TB.C_MAT_CODE ");
            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取标准列表
        /// </summary>
        /// <param name="C_STD_CODE">标准代码</param>
        /// <param name="C_STL_GRD">钢种</param>
        /// <returns></returns>
        public DataSet GetGLList(string C_STL_GRD, string C_PROD_NAME, string C_STD_CODE)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select a.C_ID,a.C_PROD_KIND,a.C_PROD_NAME,a.C_STD_CODE,a.C_STL_GRD ");
            strSql.Append(" FROM TQB_STD_MAIN a where  a.N_STATUS=1 and a.N_IS_CHECK=1 ");
            strSql.Append(" AND nvl(a.C_PROD_NAME,'') LIKE '%" + C_PROD_NAME + "%' ");
            strSql.Append(" AND nvl(a.C_STL_GRD,'') LIKE '%" + C_STL_GRD + "%' ");
            strSql.Append(" AND nvl(a.C_STD_CODE,'') LIKE '%" + C_STD_CODE + "%' ");
            strSql.Append("ORDER BY a.C_PROD_NAME");
            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 获得所有钢类
        /// </summary>
        public DataSet GetPMList(string C_PROD_NAME)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select DISTINCT C_PROD_NAME");
            strSql.Append(" FROM TQB_STD_MAIN WHERE  N_STATUS=1 and N_IS_CHECK=1  ");
            strSql.Append(" AND nvl(C_PROD_NAME,'') LIKE '%" + C_PROD_NAME + "%' ");
            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 获得所有钢种
        /// </summary>
        public DataSet GetGZList(string grd)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select DISTINCT C_STL_GRD");
            strSql.Append(" FROM TQB_STD_MAIN WHERE N_STATUS=1 and N_IS_CHECK=1 ");
            strSql.Append(" AND C_STL_GRD like '%" + grd + "%' ");
            strSql.Append("ORDER BY C_STL_GRD");
            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取标准列表(可代轧钢种维护)
        /// </summary>
        /// <param name="C_STD_CODE">标准代码</param>
        /// <param name="C_STL_GRD">钢种</param>
        /// <param name="C_ID">主键</param>
        /// <returns></returns>
        public DataSet GetListKDZ(string C_STD_CODE, string C_STL_GRD, string C_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select a.C_ID,a.C_PROD_KIND,a.C_PROD_NAME,a.C_STD_CODE,a.C_STL_GRD ");
            strSql.Append(" FROM TQB_STD_MAIN a where  N_STATUS=1 and N_IS_CHECK=1 ");
            if (C_ID != "")
            {
                strSql.Append("AND A.C_ID <> '" + C_ID + "'");
                strSql.Append("AND A.C_ID NOT IN (SELECT NVL(T.C_STD_MAIN_KDZ_ID, 0) FROM TPB_REPLACE_GRD T WHERE T.C_STD_MAIN_ID = '" + C_ID + "'  AND T.n_Status=1)");
            }

            if (C_STD_CODE != "")
            {
                strSql.Append(" and a.C_STD_CODE like '%" + C_STD_CODE + "%'");
            }
            if (C_STL_GRD != "")
            {
                strSql.Append(" and a.C_STL_GRD like '%" + C_STL_GRD + "%'");
            }
            strSql.Append("ORDER BY a.C_STL_GRD");
            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 获得所有品种
        /// </summary>
        public DataSet GetPZList()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select DISTINCT C_PROD_KIND ");
            strSql.Append(" FROM TQB_STD_MAIN WHERE N_STATUS=1  ");
            strSql.Append("ORDER BY C_PROD_KIND");
            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 根据品种获得品名
        /// </summary>
        public DataSet GetPZList(string PZ)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select DISTINCT C_PROD_NAME ");
            strSql.Append(" FROM TQB_STD_MAIN  ");
            strSql.Append("WHERE N_STATUS=1 AND C_PROD_KIND='" + PZ + "'");
            strSql.Append("ORDER BY C_PROD_NAME");
            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 根据品名获得钢种
        /// </summary>
        public DataSet GetGZListByPM(string PM)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select DISTINCT C_STL_GRD ");
            strSql.Append(" FROM TQB_STD_MAIN  ");
            strSql.Append("WHERE N_STATUS=1 AND C_PROD_NAME='" + PM + "'");
            strSql.Append("ORDER BY C_STL_GRD");
            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 根据钢种获得执行标准
        /// </summary>
        public DataSet GetBZListByGZ(string GRD)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select DISTINCT C_STD_CODE ");
            strSql.Append(" FROM TQB_STD_MAIN  ");
            strSql.Append("WHERE N_STATUS=1 AND C_STL_GRD='" + GRD + "'");
            strSql.Append("ORDER BY C_STD_CODE");
            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 获取标准列表
        /// </summary>
        /// <param name="C_STD_CODE">标准代码</param>
        /// <param name="C_STL_GRD">钢种</param>
        /// <returns></returns>
        public DataSet GetList_TANK(string C_STD_CODE, string C_STL_GRD)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select a.C_ID,a.C_PROD_KIND,a.C_PROD_NAME,a.C_STD_CODE,a.C_STL_GRD  ");
            strSql.Append(" FROM TQB_STD_MAIN a where  a.N_STATUS=1 and a.N_IS_CHECK=1  ");
            strSql.Append(" AND a.c_std_code not in (select t.C_STD_CODE from TQB_RINSE_TANK_GRD t where t.N_STATUS=1 ) and a.c_stl_grd not in (select t.c_stl_grd from TQB_RINSE_TANK_GRD t where t.N_STATUS=1)  ");
            if (C_STD_CODE != "")
            {
                strSql.Append(" and a.C_STD_CODE like '%" + C_STD_CODE + "%'");
            }
            if (C_STL_GRD != "")
            {
                strSql.Append(" and a.C_STL_GRD like '%" + C_STL_GRD + "%'");
            }
            strSql.Append("ORDER BY a.C_STL_GRD");
            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 获取未维护工艺路线数据
        /// </summary>
        /// <returns></returns>
        public DataSet GetListByWWH()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select t.*, t.rowid from TQB_STD_MAIN t  WHERE t.n_Status=1 AND t.N_IS_CHECK=1  AND t.C_ID NOT IN (SELECT C_STD_ID FROM TQB_ROUTE WHERE N_STATUS=1 )");
            strSql.Append(" ORDER BY t.C_STL_GRD");
            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 获取未维护钢坯定尺数据
        /// </summary>
        /// <returns></returns>
        public DataSet GetListByWWHGPDC()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select t.*, t.rowid from TQB_STD_MAIN t  WHERE t.n_Status=1 AND t.N_IS_CHECK=1 AND t.C_ID  NOT IN (SELECT C_STD_MAIN_ID FROM TQB_STD_SPEC WHERE N_STATUS=1 )");
            strSql.Append(" ORDER BY t.C_STL_GRD");
            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 获取未维护铁水条件数据
        /// </summary>
        /// <returns></returns>
        public DataSet GetListByWWHTSTJ()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT * FROM TQB_STD_MAIN WHERE  n_Status=1 AND N_IS_CHECK=1 AND C_ID NOT IN(SELECT a.C_ID FROM TQB_STD_MAIN a,TQB_TSBZ_CF b WHERE  a.C_STL_GRD=b.c_stl_grd AND a.c_std_code=b.c_std_code AND a.n_Status=1 AND b.n_status=1 ) ");
            strSql.Append(" ORDER BY C_STL_GRD");
            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 获取未维护钢坯机时产能数据
        /// </summary>
        /// <returns></returns>
        public DataSet GetListByWWHGPCN()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT * FROM TQB_STD_MAIN WHERE  n_Status=1 AND N_IS_CHECK=1 AND C_ID NOT IN(SELECT a.C_ID FROM TQB_STD_MAIN a,TPB_SLAB_CAPACITY b WHERE  a.C_STL_GRD=b.c_stl_grd AND a.c_std_code=b.c_std_code AND a.n_Status=1 AND b.n_status=1 )");
            strSql.Append(" ORDER BY C_STL_GRD");
            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 获取未维护轧钢机时产能数据
        /// </summary>
        /// <returns></returns>
        public DataSet GetListByWWHZXCN()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT C_STL_GRD,c_spec FROM (SELECT a.C_SPEC,b.C_STL_GRD,a.c_Id FROM TQB_STD_SPEC a LEFT JOIN  TQB_STD_MAIN b ON a.c_std_main_id=b.c_id WHERE a.n_Status=1 AND b.n_Status=1 AND b.N_IS_CHECK=1) c WHERE c.c_id NOT IN(SELECT e.C_ID FROM(SELECT q.*,w.C_STL_GRD,w.c_Std_Code FROM TQB_STD_SPEC q LEFT JOIN  TQB_STD_MAIN w ON q.c_std_main_id=w.c_id WHERE q.n_Status=1 AND w.n_Status=1 AND w.N_IS_CHECK=1) e INNER JOIN TPB_STATION_CAPACITY f ON e.c_spec=f.c_Spec AND e.C_STL_GRD=f.c_stl_grd WHERE f.n_STATUS=1) GROUP BY C_STL_GRD, C_SPEC ");
            strSql.Append(" ORDER BY C_STL_GRD");
            return DbHelperOra.Query(strSql.ToString());
        }


        /// <summary>
        /// 根据钢种、自由项获取标准
        /// </summary>
        /// <param name="C_STL_GRD">钢种</param>
        /// <param name="zyx1">自由项1</param>
        /// <param name="zyx2">自由项2</param>
        /// <returns></returns>
        public Mod_TQB_STD_MAIN GetModel(string C_STL_GRD, string zyx1, string zyx2)
        {
            string strSql = "SELECT * FROM tqb_std_main t WHERE t.c_stl_grd='" + C_STL_GRD + "' AND (INSTR('" + zyx1 + "', t.c_std_code)>0 OR INSTR('" + zyx2 + "', t.c_std_code)>0)";

            Mod_TQB_STD_MAIN model = new Mod_TQB_STD_MAIN();
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
        /// 根据钢种、标准获取自由项（连接NC数据库）
        /// </summary>
        /// <param name="GZ">钢种</param>
        /// <param name="BZ">标准</param>
        /// <returns></returns>
        public DataTable GetZYX(string GZ, string BZ)
        {
            string strSql = @"SELECT CASE
         WHEN INSTR(BZ1, '协议') > 0 OR INSTR(BZ2, '普通要求') > 0 THEN
          BZ1
         ELSE
          BZ2
       END ZYX1,
       CASE
         WHEN INSTR(BZ2, '协议') > 0 OR INSTR(BZ1, '普通要求') > 0 THEN
          BZ1
         ELSE
          BZ2
       END ZYX2
  FROM(SELECT N.DOCNAME BZ1,
               CASE
                 WHEN INSTR(M.DOCLISTNAME, 'CPBZ') > 0 THEN
                  '" + GZ + "' || '~协议'  ELSE   '" + GZ + "' || '~普通要求'  END BZ2          FROM XGERP50.BD_DEFDOCLIST@CAP_ERP M, XGERP50.BD_DEFDOC@CAP_ERP N         WHERE M.PK_DEFDOCLIST = N.PK_DEFDOCLIST           AND(N.SEALFLAG = 'N' OR N.SEALFLAG IS NULL)           AND N.DOCNAME LIKE '" + GZ + "%'           AND REPLACE(N.DOCNAME, ' ', '') LIKE '%" + BZ + "')";
            return DbHelperOra.Query(strSql.ToString()).Tables[0];

        }

        /// <summary>
        /// 生成质量设计号
        /// </summary>
        /// <param name="P_STD_ID">执行标准主键</param>
        /// <returns></returns>
        public string Creat_Design(string P_STD_ID)
        {
            OracleParameter[] parameters = {
            new OracleParameter("P_STD_ID", OracleDbType.Varchar2,100),
            new OracleParameter("P_MSG", OracleDbType.Varchar2,100)};

            parameters[0].Value = P_STD_ID;
            parameters[1].Value = "失败";

            return DbHelperOra.RunProcedureOut("PKG_Q_DESIGN.P_DESIGN_MAIN", parameters);
        }

        /// <summary>
        /// 获取标准列表
        /// </summary>
        /// <param name="C_STD_CODE">标准代码</param>
        /// <param name="C_STL_GRD">钢种</param>
        /// <returns></returns>
        public DataSet Get_List(string C_STD_CODE, string C_STL_GRD)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select a.C_STD_CODE,a.C_STL_GRD,a.C_STD_DESC ");
            strSql.Append(" FROM TQB_STD_MAIN a where  N_STATUS=1 and N_IS_CHECK=1 ");

            if (C_STD_CODE != "")
            {
                strSql.Append(" and a.C_STD_CODE like '%" + C_STD_CODE + "%'");
            }
            if (C_STL_GRD != "")
            {
                strSql.Append(" and a.C_STL_GRD like '%" + C_STL_GRD + "%'");
            }
            strSql.Append("ORDER BY a.C_STL_GRD");
            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 查询生产标准数据是否维护
        /// </summary>
        /// <param name="C_IS_BXG">0碳钢1不锈钢</param>
        /// <param name="C_ROUTE_DESC">工艺路线是否维护N</param>
        /// <param name="C_STL_GRD_TYPE">钢种生产条件是否维护N</param>
        ///  <param name="C_STL_GRD">钢种</param>
        ///  <param name="C_STD_CODE">执行标准</param>
        /// <returns>查询结果</returns>
        public DataTable GetSCTJ(string C_IS_BXG, string C_ROUTE_DESC, string C_STL_GRD_TYPE, string C_STL_GRD, string C_STD_CODE)
        {
            string sql = @"SELECT T1.C_STL_GRD,
       T1.C_STD_CODE,
       T1.C_PROD_NAME,
       T1.C_PROD_KIND,
       T.C_STL_GRD_TYPE,
       T2.C_ROUTE_DESC,
       T1.C_IS_BXG
  FROM TQB_STD_MAIN T1
  LEFT JOIN (SELECT * FROM TPB_STEEL_PRO_CONDITION T WHERE T.N_STATUS = 1) T
    ON T1.C_STL_GRD = T.C_STL_GRD
   AND T1.C_STD_CODE = T.C_STD_CODE
  LEFT JOIN (SELECT * FROM TQB_ROUTE T WHERE T.N_STATUS = 1) T2
    ON T1.C_STL_GRD = T2.C_STL_GRD
   AND T1.C_STD_CODE = T2.C_STD_CODE
 WHERE T1.N_STATUS = 1
   AND T1.N_IS_CHECK = 1
   AND T1.C_IS_BXG = '" + C_IS_BXG + "'";
            if (C_ROUTE_DESC == "N")
            {
                sql = sql + " AND T2.C_ROUTE_DESC IS NULL ";
            }
            if (C_STL_GRD_TYPE == "N")
            {
                sql = sql + "  AND T.C_STL_GRD_TYPE IS NULL";
            }
            if (C_STL_GRD != "")
            {
                sql = sql + "  AND T.C_STL_GRD LIKE '%" + C_STL_GRD + "%'";
            }
            if (C_STD_CODE != "")
            {
                sql = sql + "  AND T.C_STD_CODE LIKE '%" + C_STD_CODE + "%'";
            }

            sql = sql + " ORDER BY  T1.C_STL_GRD,T1.C_STD_CODE,T1.C_PROD_NAME,T1.C_PROD_KIND";
            return DbHelperOra.Query(sql).Tables[0];
        }



        /// <summary>
        /// 查询生产标准数据是否维护
        /// </summary>
        ///  <param name="C_STL_GRD">钢种</param>
        ///  <param name="C_STD_CODE">执行标准</param>
        /// <returns>查询结果</returns>
        public DataTable GetSCTJ(string C_STL_GRD, string C_STD_CODE)
        {
            string sql = @"SELECT T1.C_STL_GRD,
       T1.C_STD_CODE,
       T1.C_PROD_NAME,
       T1.C_PROD_KIND,
       T.C_STL_GRD_TYPE,
       T2.C_ROUTE_DESC,
       T1.C_IS_BXG
  FROM TQB_STD_MAIN T1
  LEFT JOIN (SELECT * FROM TPB_STEEL_PRO_CONDITION T WHERE T.N_STATUS = 1) T
    ON T1.C_STL_GRD = T.C_STL_GRD
   AND T1.C_STD_CODE = T.C_STD_CODE
  LEFT JOIN (SELECT * FROM TQB_ROUTE T WHERE T.N_STATUS = 1) T2
    ON T1.C_STL_GRD = T2.C_STL_GRD
   AND T1.C_STD_CODE = T2.C_STD_CODE
 WHERE T1.N_STATUS = 1
   AND T1.N_IS_CHECK = 1  ";

            if (C_STL_GRD != "")
            {
                sql = sql + "  AND T.C_STL_GRD = '" + C_STL_GRD + "'";
            }
            if (C_STD_CODE != "")
            {
                sql = sql + "  AND T.C_STD_CODE = '" + C_STD_CODE + "'";
            }

            sql = sql + " ORDER BY  T1.C_STL_GRD,T1.C_STD_CODE,T1.C_PROD_NAME,T1.C_PROD_KIND";
            return DbHelperOra.Query(sql).Tables[0];
        }


        #endregion  ExtensionMethod

        #region lj
        /// <summary>
        /// 获取品种品名
        /// </summary>
        /// <param name="C_STL_GRD">钢种</param>
        /// <param name="C_STD_CODE">执行标准</param>
        /// <returns></returns>
        public DataTable GetProdType(string C_STL_GRD, string C_STD_CODE)
        {
            string sql = @"SELECT T.C_STD_CODE, T.C_STL_GRD, T.C_PROD_NAME, T.C_PROD_KIND,t.C_IS_BXG
  FROM TQB_STD_MAIN T
 WHERE T.N_IS_CHECK = 1
   AND T.N_STATUS = 1
   AND T.C_STL_GRD = '" + C_STL_GRD + "'   AND T.C_STD_CODE = '" + C_STD_CODE + "'";
            return DbHelperOra.Query(sql).Tables[0];

        }

        /// <summary>
        /// 获取质量设计号
        /// </summary>
        /// <param name="C_STL_GRD">钢种</param>
        /// <param name="C_STD_CODE">执行标准</param>
        /// <returns>质量设计号</returns>
        public string GetDESIGN_NO(string C_STL_GRD, string C_STD_CODE)
        {
            string sql = "SELECT MAX(T.C_DESIGN_NO) as C_DESIGN_NO  FROM TQB_DESIGN T, TQB_STD_MAIN TB WHERE T.C_STD_MAIN_ID = TB.C_ID   AND TB.N_STATUS = 1   AND TB.N_IS_CHECK = 1";
            sql = sql + "  AND TB.C_STL_GRD = '" + C_STL_GRD + "'";
            sql = sql + "  AND TB.C_STD_CODE = '" + C_STD_CODE + "'";
            try
            {
                return DbHelperOra.Query(sql).Tables[0].Rows[0]["C_DESIGN_NO"].ToString();
            }
            catch (Exception)
            {

                return "";
            }


        }
        #endregion
    }
}

