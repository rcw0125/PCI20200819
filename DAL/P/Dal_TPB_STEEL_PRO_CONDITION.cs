using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;
namespace DAL
{
    /// <summary>
    /// 数据访问类:TPB_STEEL_PRO_CONDITION
    /// </summary>
    public partial class Dal_TPB_STEEL_PRO_CONDITION
    {
        public Dal_TPB_STEEL_PRO_CONDITION()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string C_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TPB_STEEL_PRO_CONDITION");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)          };
            parameters[0].Value = C_ID;

            return DbHelperOra.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Mod_TPB_STEEL_PRO_CONDITION model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TPB_STEEL_PRO_CONDITION(");
            strSql.Append("C_ID,C_STL_GRD_TYPE,C_STL_GRD_RANK,C_STL_GRD,C_STD_CODE,C_STL_SCRAP_TYPE,C_STL_SCRAP_FLIJ,C_GOUTE,C_TEASE_PERSON,C_ADV_PRO_REQUIRE,N_STATUS,C_EMP_ID,D_MOD_DT,C_REMARK,C_IS_BXG,N_GROUP,C_IS_DR)");
            strSql.Append(" values (");
            strSql.Append(":C_ID,:C_STL_GRD_TYPE,:C_STL_GRD_RANK,:C_STL_GRD,:C_STD_CODE,:C_STL_SCRAP_TYPE,:C_STL_SCRAP_FLIJ,:C_GOUTE,:C_TEASE_PERSON,:C_ADV_PRO_REQUIRE,:N_STATUS,:C_EMP_ID,:D_MOD_DT,:C_REMARK,:C_IS_BXG,:N_GROUP,:C_IS_DR)");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STL_GRD_TYPE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STL_GRD_RANK", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STL_GRD", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STD_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STL_SCRAP_TYPE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STL_SCRAP_FLIJ", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_GOUTE", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_TEASE_PERSON", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ADV_PRO_REQUIRE", OracleDbType.Varchar2,1000),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_IS_BXG", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_GROUP", OracleDbType.Decimal,4),
                    new OracleParameter(":C_IS_DR", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.C_ID;
            parameters[1].Value = model.C_STL_GRD_TYPE;
            parameters[2].Value = model.C_STL_GRD_RANK;
            parameters[3].Value = model.C_STL_GRD;
            parameters[4].Value = model.C_STD_CODE;
            parameters[5].Value = model.C_STL_SCRAP_TYPE;
            parameters[6].Value = model.C_STL_SCRAP_FLIJ;
            parameters[7].Value = model.C_GOUTE;
            parameters[8].Value = model.C_TEASE_PERSON;
            parameters[9].Value = model.C_ADV_PRO_REQUIRE;
            parameters[10].Value = model.N_STATUS;
            parameters[11].Value = model.C_EMP_ID;
            parameters[12].Value = model.D_MOD_DT;
            parameters[13].Value = model.C_REMARK;
            parameters[14].Value = model.C_IS_BXG;
            parameters[15].Value = model.N_GROUP;
            parameters[16].Value = model.C_IS_DR;
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
        public bool Update(Mod_TPB_STEEL_PRO_CONDITION model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TPB_STEEL_PRO_CONDITION set ");
            strSql.Append("C_STL_GRD_TYPE=:C_STL_GRD_TYPE,");
            strSql.Append("C_STL_GRD_RANK=:C_STL_GRD_RANK,");
            strSql.Append("C_STL_GRD=:C_STL_GRD,");
            strSql.Append("C_STD_CODE=:C_STD_CODE,");
            strSql.Append("C_STL_SCRAP_TYPE=:C_STL_SCRAP_TYPE,");
            strSql.Append("C_STL_SCRAP_FLIJ=:C_STL_SCRAP_FLIJ,");
            strSql.Append("C_GOUTE=:C_GOUTE,");
            strSql.Append("C_TEASE_PERSON=:C_TEASE_PERSON,");
            strSql.Append("C_ADV_PRO_REQUIRE=:C_ADV_PRO_REQUIRE,");
            strSql.Append("N_STATUS=:N_STATUS,");
            strSql.Append("C_EMP_ID=:C_EMP_ID,");
            strSql.Append("D_MOD_DT=:D_MOD_DT,");
            strSql.Append("C_REMARK=:C_REMARK,");
            strSql.Append("C_IS_BXG=:C_IS_BXG,");
            strSql.Append("N_GROUP=:N_GROUP,");
            strSql.Append("C_IS_DR=:C_IS_DR");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_STL_GRD_TYPE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STL_GRD_RANK", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STL_GRD", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STD_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STL_SCRAP_TYPE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STL_SCRAP_FLIJ", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_GOUTE", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_TEASE_PERSON", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ADV_PRO_REQUIRE", OracleDbType.Varchar2,1000),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_IS_BXG", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_GROUP", OracleDbType.Decimal,4),
                    new OracleParameter(":C_IS_DR", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.C_STL_GRD_TYPE;
            parameters[1].Value = model.C_STL_GRD_RANK;
            parameters[2].Value = model.C_STL_GRD;
            parameters[3].Value = model.C_STD_CODE;
            parameters[4].Value = model.C_STL_SCRAP_TYPE;
            parameters[5].Value = model.C_STL_SCRAP_FLIJ;
            parameters[6].Value = model.C_GOUTE;
            parameters[7].Value = model.C_TEASE_PERSON;
            parameters[8].Value = model.C_ADV_PRO_REQUIRE;
            parameters[9].Value = model.N_STATUS;
            parameters[10].Value = model.C_EMP_ID;
            parameters[11].Value = model.D_MOD_DT;
            parameters[12].Value = model.C_REMARK;
            parameters[13].Value = model.C_IS_BXG;
            parameters[14].Value = model.N_GROUP;
            parameters[15].Value = model.C_IS_DR;
            parameters[16].Value = model.C_ID;

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
            strSql.Append("delete from TPB_STEEL_PRO_CONDITION ");
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
            strSql.Append("delete from TPB_STEEL_PRO_CONDITION ");
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
        public Mod_TPB_STEEL_PRO_CONDITION GetModel(string C_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_STL_GRD_TYPE,C_STL_GRD_RANK,C_STL_GRD,C_STD_CODE,C_STL_SCRAP_TYPE,C_STL_SCRAP_FLIJ,C_GOUTE,C_TEASE_PERSON,C_ADV_PRO_REQUIRE,N_STATUS,C_EMP_ID,D_MOD_DT,C_REMARK,C_IS_BXG,N_GROUP,C_IS_DR from TPB_STEEL_PRO_CONDITION ");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)          };
            parameters[0].Value = C_ID;

            Mod_TPB_STEEL_PRO_CONDITION model = new Mod_TPB_STEEL_PRO_CONDITION();
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
        /// 修改混浇组号
        /// </summary>
        /// <param name="C_STL_GRD">钢种</param>
        /// <param name="C_STD_CODE"></param>
        /// <param name="N_GROUP"></param>
        /// <returns></returns>
        public bool UpdateGZ(string C_STL_GRD, string C_STD_CODE, int N_GROUP)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("UPDATE TPB_STEEL_PRO_CONDITION T SET T.N_GROUP= " + N_GROUP);
            strSql.Append(" where C_STL_GRD='" + C_STL_GRD + "' AND C_STD_CODE='" + C_STD_CODE + "'  AND N_STATUS=1 ");

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
        public Mod_TPB_STEEL_PRO_CONDITION GetModelByGZ(string C_STL_GRD, string C_STD_CODE)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_STL_GRD_TYPE,C_STL_GRD_RANK,C_STL_GRD,C_STD_CODE,C_STL_SCRAP_TYPE,C_STL_SCRAP_FLIJ,C_GOUTE,C_TEASE_PERSON,C_ADV_PRO_REQUIRE,N_STATUS,C_EMP_ID,D_MOD_DT,C_REMARK,C_IS_BXG,N_GROUP,C_IS_DR from TPB_STEEL_PRO_CONDITION ");
            strSql.Append(" where C_STL_GRD=:C_STL_GRD AND C_STD_CODE:=C_STD_CODE  AND N_STATUS=1 ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_STL_GRD", OracleDbType.Varchar2,100)  ,
              new OracleParameter(":C_STD_CODE", OracleDbType.Varchar2,100)};
            parameters[0].Value = C_STL_GRD;
            parameters[1].Value = C_STD_CODE;

            Mod_TPB_STEEL_PRO_CONDITION model = new Mod_TPB_STEEL_PRO_CONDITION();
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
        /// 根据计划钢种和标准获取对象实体
        /// </summary>
        /// <param name="C_STL_GRD">计划钢种</param>
        /// <param name="C_STD_CODE">计划标准</param>
        /// <returns></returns>
        public Mod_TPB_STEEL_PRO_CONDITION GetModel(string C_STL_GRD, string C_STD_CODE)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_STL_GRD_TYPE,C_STL_GRD_RANK,C_STL_GRD,C_STD_CODE,C_STL_SCRAP_TYPE,C_STL_SCRAP_FLIJ,C_GOUTE,C_TEASE_PERSON,C_ADV_PRO_REQUIRE,N_STATUS,C_EMP_ID,D_MOD_DT,C_REMARK,C_IS_BXG,N_GROUP,C_IS_DR from TPB_STEEL_PRO_CONDITION ");
            strSql.Append(" where C_STL_GRD=:C_STL_GRD AND C_STD_CODE=:C_STD_CODE and N_STATUS=1 ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_STL_GRD", OracleDbType.Varchar2,100) ,
                new OracleParameter(":C_STD_CODE", OracleDbType.Varchar2,100)         };
            parameters[0].Value = C_STL_GRD;
            parameters[1].Value = C_STD_CODE;

            Mod_TPB_STEEL_PRO_CONDITION model = new Mod_TPB_STEEL_PRO_CONDITION();
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
        public Mod_TPB_STEEL_PRO_CONDITION DataRowToModel(DataRow row)
        {
            Mod_TPB_STEEL_PRO_CONDITION model = new Mod_TPB_STEEL_PRO_CONDITION();
            if (row != null)
            {
                if (row["C_ID"] != null)
                {
                    model.C_ID = row["C_ID"].ToString();
                }
                if (row["C_STL_GRD_TYPE"] != null)
                {
                    model.C_STL_GRD_TYPE = row["C_STL_GRD_TYPE"].ToString();
                }
                if (row["C_STL_GRD_RANK"] != null)
                {
                    model.C_STL_GRD_RANK = row["C_STL_GRD_RANK"].ToString();
                }
                if (row["C_STL_GRD"] != null)
                {
                    model.C_STL_GRD = row["C_STL_GRD"].ToString();
                }
                if (row["C_STD_CODE"] != null)
                {
                    model.C_STD_CODE = row["C_STD_CODE"].ToString();
                }
                if (row["C_STL_SCRAP_TYPE"] != null)
                {
                    model.C_STL_SCRAP_TYPE = row["C_STL_SCRAP_TYPE"].ToString();
                }
                if (row["C_STL_SCRAP_FLIJ"] != null)
                {
                    model.C_STL_SCRAP_FLIJ = row["C_STL_SCRAP_FLIJ"].ToString();
                }
                if (row["C_GOUTE"] != null)
                {
                    model.C_GOUTE = row["C_GOUTE"].ToString();
                }
                if (row["C_TEASE_PERSON"] != null)
                {
                    model.C_TEASE_PERSON = row["C_TEASE_PERSON"].ToString();
                }
                if (row["C_ADV_PRO_REQUIRE"] != null)
                {
                    model.C_ADV_PRO_REQUIRE = row["C_ADV_PRO_REQUIRE"].ToString();
                }
                if (row["N_STATUS"] != null && row["N_STATUS"].ToString() != "")
                {
                    model.N_STATUS = decimal.Parse(row["N_STATUS"].ToString());
                }
                if (row["C_EMP_ID"] != null)
                {
                    model.C_EMP_ID = row["C_EMP_ID"].ToString();
                }
                if (row["D_MOD_DT"] != null && row["D_MOD_DT"].ToString() != "")
                {
                    model.D_MOD_DT = DateTime.Parse(row["D_MOD_DT"].ToString());
                }
                if (row["C_REMARK"] != null)
                {
                    model.C_REMARK = row["C_REMARK"].ToString();
                }
                if (row["C_IS_BXG"] != null)
                {
                    model.C_IS_BXG = row["C_IS_BXG"].ToString();
                }
                if (row["N_GROUP"] != null && row["N_GROUP"].ToString() != "")
                {
                    model.N_GROUP = decimal.Parse(row["N_GROUP"].ToString());
                }
                if (row["C_IS_DR"] != null)
                {
                    model.C_IS_DR = row["C_IS_DR"].ToString();
                }
            }
            return model;
        }
        /// <summary>
        /// 获得数据列表_条件模糊查询
        /// </summary>
        /// <param name="C_STL_GRD">钢种</param>
        /// <param name="C_STD_CODE">执行标准</param>
        /// <param name="C_IS_BXG">是否为不锈钢</param>
        /// <returns></returns>
        public DataSet GetList_Query(string C_IS_BXG, string C_STL_GRD, string C_STD_CODE)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * ");
            strSql.Append(" FROM TPB_STEEL_PRO_CONDITION where N_STATUS=1 ");
            if (C_IS_BXG.Trim() != "")
            {
                strSql.Append(" and  C_IS_BXG='" + C_IS_BXG + "' ");
            }

            if (C_STL_GRD.Trim() != "")
            {
                strSql.Append(" and C_STL_GRD like '%" + C_STL_GRD + "%' ");
            }
            if (C_STD_CODE.Trim() != "")
            {
                strSql.Append(" and C_STD_CODE like '%" + C_STD_CODE + "%' ");
            }
            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 获得数据列表_条件模糊查询
        /// </summary>
        /// <param name="C_STL_GRD">钢种</param>
        /// <param name="C_STD_CODE">执行标准</param>
        /// <param name="C_IS_BXG">是否为不锈钢</param>
        /// <returns></returns>
        public DataSet GetList_GZSCTJ(string C_IS_BXG, string C_STL_GRD, string C_STD_CODE)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT T.C_ID,T1.C_ROUTE_DESC, T1.C_ROUTE_TYPE, T.C_STL_GRD_TYPE, T.C_STL_GRD_RANK,T.C_STL_GRD,T.C_STD_CODE,T.C_STL_SCRAP_TYPE,T.C_STL_SCRAP_FLIJ,T.C_GOUTE,T.C_TEASE_PERSON,T.C_ADV_PRO_REQUIRE,T.N_STATUS,T.C_EMP_ID,T.D_MOD_DT,T.C_REMARK,T.C_IS_BXG,T.N_GROUP FROM TPB_STEEL_PRO_CONDITION T LEFT JOIN TQB_ROUTE T1 ON T1.N_STATUS = 1 AND T.C_STL_GRD = T1.C_STL_GRD AND T.C_STD_CODE = T1.C_STD_CODE WHERE T.N_STATUS = 1 ");
            if (C_IS_BXG.Trim() != "")
            {
                strSql.Append(" and  T.C_IS_BXG='" + C_IS_BXG + "' ");
            }

            if (C_STL_GRD.Trim() != "")
            {
                strSql.Append(" and T.C_STL_GRD like '%" + C_STL_GRD + "%' ");
            }
            if (C_STD_CODE.Trim() != "")
            {
                strSql.Append(" and T.C_STD_CODE like '%" + C_STD_CODE + "%' ");
            }
            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * ");
            strSql.Append(" FROM TPB_STEEL_PRO_CONDITION ");
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
            strSql.Append("select count(1) FROM TPB_STEEL_PRO_CONDITION ");
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
            strSql.Append(")AS Row, T.*  from TPB_STEEL_PRO_CONDITION T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 判断钢种是否可以混浇
        /// </summary>
        /// <param name="c_stl_grd">原钢种</param>
        /// <param name="c_std_code">原执行标准</param>
        /// <param name="c_border_stl_grd">混浇钢种</param>
        /// <param name="c_border_std_code">混浇执行标准</param>
        /// <returns></returns>
        public int GetRecordCount(string c_stl_grd, string c_std_code, string c_border_stl_grd, string c_border_std_code)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from tpb_steel_pro_condition ta inner join tpb_border_grd tb on ta.c_id=tb.c_pro_condition_id where ta.c_stl_grd='" + c_stl_grd + "' and ta.c_std_code='" + c_std_code + "' and tb.c_border_stl_grd ='" + c_border_stl_grd + "' and tb.c_border_std_code='" + c_border_std_code + "' ");

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

        #region 验证钢种生产条件并获取钢种大类
        /// <summary>
        /// 匹配钢种生产条件是否维护
        /// </summary>
        /// <param name="C_STL_GRD">钢种</param>
        /// <param name="C_STD_CODE">执行标准</param>
        /// <returns>返回查询结果</returns>
        public DataTable GetSCTJ(string C_STL_GRD, string C_STD_CODE)
        {
            //Q/XG开头的标准不匹配年号
            string sql = @" SELECT T.C_STL_GRD_TYPE,T.N_GROUP
   FROM TPB_STEEL_PRO_CONDITION T
  WHERE   T.N_STATUS = 1 AND T.C_STL_GRD = '" + C_STL_GRD + "'";
            if (C_STD_CODE.Contains("Q/XG") || C_STD_CODE.Contains("GB/T") || C_STD_CODE.Contains("Q/邢钢"))
            {
                C_STD_CODE = C_STD_CODE.Split('-')[0].Split('.')[0];
                sql = sql + " AND T.C_STD_CODE LIKE '" + C_STD_CODE + "%'";
            }
            else
            {
                sql = sql + "   AND T.C_STD_CODE = '" + C_STD_CODE + "'";
            }
            return DbHelperOra.Query(sql).Tables[0];
        }


        #endregion
        /// <summary>
        /// 根据钢种执行标准分组查询数据
        /// </summary>
        /// <param name="grd"></param>
        /// <param name="std"></param>
        /// <param name="group"></param>
        /// <returns></returns>
        public DataSet GetList(string grd, string std, string group)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * ");
            strSql.Append(" FROM TPB_STEEL_PRO_CONDITION WHERE N_STATUS=1");
            if (grd.Trim() != "")
            {
                strSql.Append(" AND C_STL_GRD LIKE '%" + grd + "%'");
            }
            if (std.Trim() != "")
            {
                strSql.Append(" AND C_STD_CODE LIKE'%" + std + "%'");
            }
            if (group.Trim() != "")
            {
                strSql.Append(" AND N_GROUP='" + group + "'");
            }
            strSql.Append("ORDER BY N_GROUP");
            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 根据分组号查询数据
        /// </summary>
        /// <param name="group"></param>
        /// <returns></returns>
        public DataSet GetListbyGP(string group)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_STL_GRD,C_STD_CODE ");
            strSql.Append(" FROM TPB_STEEL_PRO_CONDITION WHERE N_STATUS=1");
            if (group.Trim() != "")
            {
                strSql.Append(" AND N_GROUP='" + group + "'");
            }
            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 变更可混浇
        /// </summary>
        /// <param name="group"></param>
        /// <returns></returns>
        public void UPKHJ(string grd,string std,string group)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("UPDATE TPB_STEEL_PRO_CONDITION SET N_GROUP='"+ group + "' ");
            strSql.Append(" WHERE C_STL_GRD='" + grd + "' and C_STD_CODE='" + std + "'  ");

            StringBuilder strSql1 = new StringBuilder();
            strSql1.Append("UPDATE tmo_order SET N_GROUP='" + group + "' ");
            strSql1.Append(" WHERE C_STL_GRD='" + grd + "' and C_STD_CODE='" + std + "'  ");

            StringBuilder strSql2 = new StringBuilder();
            strSql2.Append("UPDATE trp_plan_roll SET N_GROUP='" + group + "' ");
            strSql2.Append(" WHERE C_STL_GRD='" + grd + "' and C_STD_CODE='" + std + "'  ");

            StringBuilder strSql3 = new StringBuilder();
            strSql3.Append("UPDATE tsp_plan_sms SET N_GROUP='" + group + "' ");
            strSql3.Append(" WHERE C_STL_GRD='" + grd + "' and C_STD_CODE='" + std + "'  ");

            StringBuilder strSql4 = new StringBuilder();
            strSql4.Append("UPDATE tpp_lgpc_lclsb SET N_GROUP='" + group + "' ");
            strSql4.Append(" WHERE C_STL_GRD='" + grd + "' and C_STD_CODE='" + std + "'  ");


            DbHelperOra.ExecuteSql(strSql.ToString());
            DbHelperOra.ExecuteSql(strSql1.ToString());
            DbHelperOra.ExecuteSql(strSql2.ToString());
            DbHelperOra.ExecuteSql(strSql3.ToString());
            DbHelperOra.ExecuteSql(strSql4.ToString());
        }
        /// <summary>
        /// 验证可相邻生产
        /// </summary>
        /// <param name="C_STL_GRD1">上炉钢种</param>
        /// <param name="C_STD_CODE1">上炉标准</param>
        /// <param name="C_STL_GRD">本炉钢种</param>
        /// <param name="C_STD_CODE">本炉计划</param>
        /// <returns></returns>
        public DataTable GetBroder(string C_STL_GRD1, string C_STD_CODE1, string C_STL_GRD, string C_STD_CODE)
        {
            string sql = @"SELECT T.C_STL_GRD, T.C_STD_CODE, TB.C_BORDER_STL_GRD, TB.C_BORDER_STD_CODE
  FROM TPB_STEEL_PRO_CONDITION T
  LEFT JOIN TPB_BORDER_GRD TB
    ON T.C_ID = TB.C_PRO_CONDITION_ID
 WHERE T.N_STATUS = 1
   AND TB.N_STATUS = 1
   AND T.C_STL_GRD = '"+ C_STL_GRD1 + "'   AND T.C_STD_CODE = '"+C_STD_CODE1+"'   AND TB.C_BORDER_STL_GRD = '"+C_STL_GRD+"'   AND TB.C_BORDER_STD_CODE = '"+C_STD_CODE+"'";
            return DbHelperOra.Query(sql).Tables[0];

        }

    }
}

