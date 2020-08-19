using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using RV.MODEL;

namespace RV.DAL
{
    /// <summary>
    /// 数据访问类:TS_MODULE
    /// </summary>
    public partial class DalTS_MODULE
    {
        public DalTS_MODULE()
        { }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string C_MODULEID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TS_MODULE");
            strSql.Append(" where C_MODULEID=:C_MODULEID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_MODULEID", OracleDbType.Varchar2,20)            };
            parameters[0].Value = C_MODULEID;

            return DbHelperOra.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(ModTS_MODULE model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TS_MODULE(");
            strSql.Append("C_MODULEID,C_PARENTMODULEID,C_MODULENAME,C_ASSEMBLYNAME,C_MODULECLASS,C_DISABLE,N_ORDER,N_IMAGEINDEX,C_MODULE_TYPE,C_QUERY_STR,C_REMARK,C_EMP_ID)");
            strSql.Append(" values (");
            strSql.Append(":C_MODULEID,:C_PARENTMODULEID,:C_MODULENAME,:C_ASSEMBLYNAME,:C_MODULECLASS,:C_DISABLE,:N_ORDER,:N_IMAGEINDEX,:C_MODULE_TYPE,:C_QUERY_STR,:C_REMARK,:C_EMP_ID)");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_MODULEID", OracleDbType.Varchar2,20),
                    new OracleParameter(":C_PARENTMODULEID", OracleDbType.Varchar2,20),
                    new OracleParameter(":C_MODULENAME", OracleDbType.Varchar2,50),
                    new OracleParameter(":C_ASSEMBLYNAME", OracleDbType.Varchar2,255),
                    new OracleParameter(":C_MODULECLASS", OracleDbType.Varchar2,255),
                    new OracleParameter(":C_DISABLE", OracleDbType.Varchar2,50),
                    new OracleParameter(":N_ORDER", OracleDbType.Int16,3),
                    new OracleParameter(":N_IMAGEINDEX", OracleDbType.Int16,3),
                    new OracleParameter(":C_MODULE_TYPE", OracleDbType.Varchar2,2),
                    new OracleParameter(":C_QUERY_STR", OracleDbType.Varchar2,300),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,50),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,20)};
            parameters[0].Value = model.C_MODULEID;
            parameters[1].Value = model.C_PARENTMODULEID;
            parameters[2].Value = model.C_MODULENAME;
            parameters[3].Value = model.C_ASSEMBLYNAME;
            parameters[4].Value = model.C_MODULECLASS;
            parameters[5].Value = model.C_DISABLE;
            parameters[6].Value = model.N_ORDER;
            parameters[7].Value = model.N_IMAGEINDEX;
            parameters[8].Value = model.C_MODULE_TYPE;
            parameters[9].Value = model.C_QUERY_STR;
            parameters[10].Value = model.C_REMARK;
            parameters[11].Value = model.C_EMP_ID;

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
        public bool Update(ModTS_MODULE model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TS_MODULE set ");
            strSql.Append("C_PARENTMODULEID=:C_PARENTMODULEID,");
            strSql.Append("C_MODULENAME=:C_MODULENAME,");
            strSql.Append("C_ASSEMBLYNAME=:C_ASSEMBLYNAME,");
            strSql.Append("C_MODULECLASS=:C_MODULECLASS,");
            strSql.Append("C_DISABLE=:C_DISABLE,");
            strSql.Append("N_ORDER=:N_ORDER,");
            strSql.Append("N_IMAGEINDEX=:N_IMAGEINDEX,");
            strSql.Append("C_MODULE_TYPE=:C_MODULE_TYPE,");
            strSql.Append("C_QUERY_STR=:C_QUERY_STR,");
            strSql.Append("C_REMARK=:C_REMARK,");
            strSql.Append("C_EMP_ID=:C_EMP_ID,");
            strSql.Append("D_MOD_DT=:D_MOD_DT");
            strSql.Append(" where C_MODULEID=:C_MODULEID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_PARENTMODULEID", OracleDbType.Varchar2,20),
                    new OracleParameter(":C_MODULENAME", OracleDbType.Varchar2,50),
                    new OracleParameter(":C_ASSEMBLYNAME", OracleDbType.Varchar2,255),
                    new OracleParameter(":C_MODULECLASS", OracleDbType.Varchar2,255),
                    new OracleParameter(":C_DISABLE", OracleDbType.Varchar2,50),
                    new OracleParameter(":N_ORDER", OracleDbType.Int16,3),
                    new OracleParameter(":N_IMAGEINDEX", OracleDbType.Int16,3),
                    new OracleParameter(":C_MODULE_TYPE", OracleDbType.Varchar2,2),
                    new OracleParameter(":C_QUERY_STR", OracleDbType.Varchar2,300),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,50),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,20),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":C_MODULEID", OracleDbType.Varchar2,20)};
            parameters[0].Value = model.C_PARENTMODULEID;
            parameters[1].Value = model.C_MODULENAME;
            parameters[2].Value = model.C_ASSEMBLYNAME;
            parameters[3].Value = model.C_MODULECLASS;
            parameters[4].Value = model.C_DISABLE;
            parameters[5].Value = model.N_ORDER;
            parameters[6].Value = model.N_IMAGEINDEX;
            parameters[7].Value = model.C_MODULE_TYPE;
            parameters[8].Value = model.C_QUERY_STR;
            parameters[9].Value = model.C_REMARK;
            parameters[10].Value = model.C_EMP_ID;
            parameters[11].Value = model.D_MOD_DT;
            parameters[12].Value = model.C_MODULEID;

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
        public bool Delete(string C_MODULEID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from TS_MODULE ");
            strSql.Append(" where C_MODULEID=:C_MODULEID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_MODULEID", OracleDbType.Varchar2,20)            };
            parameters[0].Value = C_MODULEID;

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
        public bool DeleteList(string C_MODULEIDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from TS_MODULE ");
            strSql.Append(" where C_MODULEID in (" + C_MODULEIDlist + ")  ");
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
        public ModTS_MODULE GetModel(string C_MODULEID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_MODULEID,C_PARENTMODULEID,C_MODULENAME,C_ASSEMBLYNAME,C_MODULECLASS,C_DISABLE,N_ORDER,N_IMAGEINDEX,C_MODULE_TYPE,C_QUERY_STR,C_REMARK,C_EMP_ID,D_MOD_DT from TS_MODULE ");
            strSql.Append(" where C_MODULEID=:C_MODULEID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_MODULEID", OracleDbType.Varchar2,20)            };
            parameters[0].Value = C_MODULEID;

            ModTS_MODULE model = new ModTS_MODULE();
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
        public ModTS_MODULE GetModel(string C_PARENTMODULEID, int N_ORDER)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_MODULEID,C_PARENTMODULEID,C_MODULENAME,C_ASSEMBLYNAME,C_MODULECLASS,C_DISABLE,N_ORDER,N_IMAGEINDEX,C_MODULE_TYPE,C_QUERY_STR,C_REMARK,C_EMP_ID,D_MOD_DT from TS_MODULE ");
            strSql.Append(" where C_PARENTMODULEID=:C_PARENTMODULEID and N_ORDER=:N_ORDER ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_PARENTMODULEID", OracleDbType.Varchar2,20),
                    new OracleParameter(":N_ORDER", OracleDbType.Int16,3)            };
            parameters[0].Value = C_PARENTMODULEID;
            parameters[1].Value = N_ORDER;

            ModTS_MODULE model = new ModTS_MODULE();
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
        public ModTS_MODULE DataRowToModel(DataRow row)
        {
            ModTS_MODULE model = new ModTS_MODULE();
            if (row != null)
            {
                if (row["C_MODULEID"] != null)
                {
                    model.C_MODULEID = row["C_MODULEID"].ToString();
                }
                if (row["C_PARENTMODULEID"] != null)
                {
                    model.C_PARENTMODULEID = row["C_PARENTMODULEID"].ToString();
                }
                if (row["C_MODULENAME"] != null)
                {
                    model.C_MODULENAME = row["C_MODULENAME"].ToString();
                }
                if (row["C_ASSEMBLYNAME"] != null)
                {
                    model.C_ASSEMBLYNAME = row["C_ASSEMBLYNAME"].ToString();
                }
                if (row["C_MODULECLASS"] != null)
                {
                    model.C_MODULECLASS = row["C_MODULECLASS"].ToString();
                }
                if (row["C_DISABLE"] != null)
                {
                    model.C_DISABLE = row["C_DISABLE"].ToString();
                }
                if (row["N_ORDER"] != null)
                {
                    model.N_ORDER = decimal.Parse(row["N_ORDER"].ToString());
                }
                if (row["N_IMAGEINDEX"] != null && row["N_IMAGEINDEX"].ToString() != "")
                {
                    model.N_IMAGEINDEX = decimal.Parse(row["N_IMAGEINDEX"].ToString());
                }
                if (row["C_MODULE_TYPE"] != null)
                {
                    model.C_MODULE_TYPE = row["C_MODULE_TYPE"].ToString();
                }
                if (row["C_QUERY_STR"] != null)
                {
                    model.C_QUERY_STR = row["C_QUERY_STR"].ToString();
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
        public DataSet GetList(string strWhere, string strType)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_MODULEID,C_PARENTMODULEID,C_MODULENAME,C_ASSEMBLYNAME,C_MODULECLASS,C_DISABLE,N_ORDER,N_IMAGEINDEX,C_MODULE_TYPE,C_QUERY_STR,C_REMARK,C_EMP_ID,D_MOD_DT ");
            strSql.Append(" FROM TS_MODULE where  1=1 and C_MODULE_TYPE <> '3' ");

            if (strType == "1")
            {
                strSql.Append("  and C_DISABLE='1' ");
            }

            if (strWhere.Trim() != "")
            {
                strSql.Append(" and " + strWhere);
            }
            strSql.Append(" order by N_ORDER asc ");
            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得权限列表
        /// </summary>
        public DataSet GetList()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_MODULEID,C_PARENTMODULEID,C_MODULENAME");
            strSql.Append(" FROM TS_MODULE where  1=1 and C_DISABLE='1' ");

            strSql.Append(" order by N_ORDER asc ");
            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取权限菜单ID
        /// </summary>
        /// <param name="strID">子节点ID</param>
        /// <returns></returns>
        public DataSet Get_MenuID(string strID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT distinct t.C_MODULEID,t.n_order FROM ts_module t where t.c_module_type<>'3' START WITH C_MODULEID in (" + strID + ") CONNECT BY PRIOR C_PARENTMODULEID = C_MODULEID order by t.n_order");

            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM TS_MODULE ");
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
        /// 获取参数
        /// </summary>
        public string Get_CS(string C_MODULENAME, string C_MODULECLASS)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_QUERY_STR FROM TS_MODULE where C_MODULENAME='" + C_MODULENAME + "' and C_MODULECLASS='" + C_MODULECLASS + "' ");

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
		/// 获取最大主键
		/// </summary>
		public int GetMaxID()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select max(c_moduleid) FROM TS_MODULE where C_MODULE_TYPE <> '3' ");
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
		/// 获取最大排序号
		/// </summary>
		public int GetOrder(string strID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select max(N_ORDER) FROM TS_MODULE  where C_PARENTMODULEID=" + strID);
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
                strSql.Append("order by T.C_MODULEID desc");
            }
            strSql.Append(")AS Row, T.*  from TS_MODULE T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            return DbHelperOra.Query(strSql.ToString());
        }


        /// <summary>
        /// 更新菜单顺序
        /// </summary>
        /// <param name="str_ID_up"></param>
        /// <param name="str_ID_down"></param>
        /// <param name="order_up"></param>
        /// <param name="order_down"></param>
        /// <returns></returns>
        public int ResetOrder(string str_ID_up, string str_ID_down, int order_up, int order_down)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("begin ");
            strSql.Append("update TS_MODULE set N_ORDER=" + order_up + " where C_MODULEID='" + str_ID_down + "';");
            strSql.Append("update TS_MODULE set N_ORDER=" + order_down + " where C_MODULEID='" + str_ID_up + "';");
            strSql.Append(" end;");
            int rows = DbHelperOra.ExecuteSql(strSql.ToString());
            return rows;
        }


        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetMenuList(string strWhere, string strType, string strID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_MODULEID,C_PARENTMODULEID,C_MODULENAME,C_ASSEMBLYNAME,C_MODULECLASS,C_DISABLE,N_ORDER,N_IMAGEINDEX,C_MODULE_TYPE,C_QUERY_STR,C_REMARK,C_EMP_ID,D_MOD_DT ");
            strSql.Append(" FROM TS_MODULE where  1=1 and C_MODULE_TYPE <> '3' and  C_MODULEID in (" + strID + ") ");

            if (strType == "1")
            {
                strSql.Append("  and C_DISABLE='1' ");
            }

            if (strWhere.Trim() != "")
            {
                strSql.Append(" and " + strWhere);
            }
            strSql.Append(" order by N_ORDER asc ");
            return DbHelperOra.Query(strSql.ToString());
        }


        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(string c_parentmoduleid, string C_DISABLE)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update ts_module t set t.c_disable='" + C_DISABLE + "' where t.c_module_type=3 and t.c_parentmoduleid='" + c_parentmoduleid + "' ");

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
    }
}

