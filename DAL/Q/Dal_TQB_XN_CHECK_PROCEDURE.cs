using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;
namespace DAL
{
    /// <summary>
    /// 数据访问类:TQB_XN_CHECK_PROCEDURE
    /// </summary>
    public partial class Dal_TQB_XN_CHECK_PROCEDURE
    {
        public Dal_TQB_XN_CHECK_PROCEDURE()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string C_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TQB_XN_CHECK_PROCEDURE");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)         };
            parameters[0].Value = C_ID;

            return DbHelperOra.Exists(strSql.ToString(), parameters);
        }
        /// <summary>
        /// 获取CODE最大值
        /// </summary>
        /// <returns></returns>
        public string GetList_MAX()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select MAX( substr( C_ID,5))as C_ID  ");
            strSql.Append(" FROM TQB_XN_CHECK_PROCEDURE where  1=1 ");

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
        /// 增加一条数据
        /// </summary>
        public bool Add(Mod_TQB_XN_CHECK_PROCEDURE model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TQB_XN_CHECK_PROCEDURE(");
            strSql.Append("C_ID,C_PHYSICS_GROUP_ID,C_NAME,N_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT,C_CODE,N_ORDER,C_DESC,C_DESC_ITEM)");
            strSql.Append(" values (");
            strSql.Append(":C_ID,:C_PHYSICS_GROUP_ID,:C_NAME,:N_STATUS,:C_REMARK,:C_EMP_ID,:D_MOD_DT,:C_CODE,:N_ORDER,:C_DESC,:C_DESC_ITEM)");
            OracleParameter[] parameters = {
                 new OracleParameter(":C_ID", OracleDbType.Varchar2,100),
                     new OracleParameter(":C_PHYSICS_GROUP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":C_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_ORDER", OracleDbType.Decimal,4),
                    new OracleParameter(":C_DESC", OracleDbType.Varchar2,100), 
                    new OracleParameter(":C_DESC_ITEM", OracleDbType.Varchar2,100)
            };
            parameters[0].Value = model.C_ID;
            parameters[1].Value = model.C_PHYSICS_GROUP_ID;
            parameters[2].Value = model.C_NAME;
            parameters[3].Value = model.N_STATUS;
            parameters[4].Value = model.C_REMARK;
            parameters[5].Value = model.C_EMP_ID;
            parameters[6].Value = model.D_MOD_DT;
            parameters[7].Value = model.C_CODE;
            parameters[8].Value = model.N_ORDER;
            parameters[9].Value = model.C_DESC;
            parameters[10].Value = model.C_DESC_ITEM;
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
        public bool Update(Mod_TQB_XN_CHECK_PROCEDURE model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TQB_XN_CHECK_PROCEDURE set ");
            strSql.Append("C_PHYSICS_GROUP_ID=:C_PHYSICS_GROUP_ID,");
            strSql.Append("C_NAME=:C_NAME,");
            strSql.Append("N_STATUS=:N_STATUS,");
            strSql.Append("C_REMARK=:C_REMARK,");
            strSql.Append("C_EMP_ID=:C_EMP_ID,");
            strSql.Append("D_MOD_DT=:D_MOD_DT,");
            strSql.Append("C_CODE=:C_CODE,");
            strSql.Append("N_ORDER=:N_ORDER,");
            strSql.Append("C_DESC=:C_DESC,");
            strSql.Append("C_DESC_ITEM=:C_DESC_ITEM");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_PHYSICS_GROUP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                     new OracleParameter(":C_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_ORDER", OracleDbType.Decimal,4),
                    new OracleParameter(":C_DESC", OracleDbType.Varchar2,100), 
                    new OracleParameter(":C_DESC_ITEM", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.C_PHYSICS_GROUP_ID;
            parameters[1].Value = model.C_NAME;
            parameters[2].Value = model.N_STATUS;
            parameters[3].Value = model.C_REMARK;
            parameters[4].Value = model.C_EMP_ID;
            parameters[5].Value = model.D_MOD_DT;
            parameters[6].Value = model.C_CODE;
            parameters[7].Value = model.N_ORDER; 
            parameters[8].Value = model.C_DESC;
            parameters[9].Value = model.C_DESC_ITEM;
            parameters[10].Value = model.C_ID;

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
            strSql.Append("delete from TQB_XN_CHECK_PROCEDURE ");
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
            strSql.Append("delete from TQB_XN_CHECK_PROCEDURE ");
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
        public Mod_TQB_XN_CHECK_PROCEDURE GetModel(string C_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_PHYSICS_GROUP_ID,C_NAME,N_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT,C_CODE,N_ORDER,C_DESC,C_DESC_ITEM from TQB_XN_CHECK_PROCEDURE ");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)         };
            parameters[0].Value = C_ID;

            Mod_TQB_XN_CHECK_PROCEDURE model = new Mod_TQB_XN_CHECK_PROCEDURE();
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
        public Mod_TQB_XN_CHECK_PROCEDURE DataRowToModel(DataRow row)
        {
            Mod_TQB_XN_CHECK_PROCEDURE model = new Mod_TQB_XN_CHECK_PROCEDURE();
            if (row != null)
            {
                if (row["C_ID"] != null)
                {
                    model.C_ID = row["C_ID"].ToString();
                }
                if (row["C_PHYSICS_GROUP_ID"] != null)
                {
                    model.C_PHYSICS_GROUP_ID = row["C_PHYSICS_GROUP_ID"].ToString();
                }
                if (row["C_NAME"] != null)
                {
                    model.C_NAME = row["C_NAME"].ToString();
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
                if (row["C_CODE"] != null)
                {
                    model.C_CODE = row["C_CODE"].ToString();
                }
                if (row["N_ORDER"] != null && row["N_ORDER"].ToString() != "")
                {
                    model.N_ORDER = decimal.Parse(row["N_ORDER"].ToString());
                }
                if (row["C_DESC"] != null)
                {
                    model.C_DESC = row["C_DESC"].ToString();
                }
                if (row["C_DESC_ITEM"] != null)
                {
                    model.C_DESC_ITEM = row["C_DESC_ITEM"].ToString();
                }
            }
            return model;
        }
        /// <summary>
		/// 获得数据列表-外键
		/// </summary>
		public DataSet GetList_ID(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ta.C_ID,ta.C_PHYSICS_GROUP_ID,ta.C_NAME,ta.N_STATUS,ta.C_REMARK,ta.C_EMP_ID,ta.D_MOD_DT,ta.N_ORDER,ta.C_DESC, tb.c_name as 性能名称 ,ta.C_DESC_ITEM ");
            strSql.Append("  FROM TQB_XN_CHECK_PROCEDURE ta join tqb_physics_group tb on ta.c_physics_group_id=tb.c_id where ta.N_STATUS=1 ");
            if (strWhere.Trim() != "全部")
            {
                strSql.Append(" and  ta.C_PHYSICS_GROUP_ID = '" + strWhere + "'");
            }
            strSql.Append(" order by ta.N_ORDER");
            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_PHYSICS_GROUP_ID,C_NAME,N_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT,N_ORDER ");
            strSql.Append(" FROM TQB_XN_CHECK_PROCEDURE ");
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
            strSql.Append("select count(1) FROM TQB_XN_CHECK_PROCEDURE ");
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
            strSql.Append(")AS Row, T.*  from TQB_XN_CHECK_PROCEDURE T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            return DbHelperOra.Query(strSql.ToString());
        }

        /*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			OracleParameter[] parameters = {
					new OracleParameter(":tblName", OracleDbType.Varchar2, 255),
					new OracleParameter(":fldName", OracleDbType.Varchar2, 255),
					new OracleParameter(":PageSize", OracleDbType.Number),
					new OracleParameter(":PageIndex", OracleDbType.Number),
					new OracleParameter(":IsReCount", OracleDbType.Clob),
					new OracleParameter(":OrderType", OracleDbType.Clob),
					new OracleParameter(":strWhere", OracleDbType.Varchar2,1000),
					};
			parameters[0].Value = "TQB_XN_CHECK_PROCEDURE";
			parameters[1].Value = "C_ID";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperOra.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

        #endregion  BasicMethod
        #region  ExtensionMethod

        #endregion  ExtensionMethod
    }
}

