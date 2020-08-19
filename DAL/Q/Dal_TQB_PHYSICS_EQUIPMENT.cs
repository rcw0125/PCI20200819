using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;
namespace DAL
{
    /// <summary>
    /// 数据访问类:TQB_PHYSICS_EQUIPMENT
    /// </summary>
    public partial class Dal_TQB_PHYSICS_EQUIPMENT
    {
        public Dal_TQB_PHYSICS_EQUIPMENT()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string C_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TQB_PHYSICS_EQUIPMENT");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)          };
            parameters[0].Value = C_ID;

            return DbHelperOra.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Mod_TQB_PHYSICS_EQUIPMENT model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TQB_PHYSICS_EQUIPMENT(");
            strSql.Append(" C_PHYSICS_GROUP_ID,C_EQ_NAME,C_EQ_NUMBER,C_EQ_CODE,N_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT)");
            strSql.Append(" values (");
            strSql.Append(" :C_PHYSICS_GROUP_ID,:C_EQ_NAME,:C_EQ_NUMBER,:C_EQ_CODE,:N_STATUS,:C_REMARK,:C_EMP_ID,:D_MOD_DT)");
            OracleParameter[] parameters = {
                     new OracleParameter(":C_PHYSICS_GROUP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_EQ_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_EQ_NUMBER", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_EQ_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date)};
            parameters[0].Value = model.C_PHYSICS_GROUP_ID;
            parameters[1].Value = model.C_EQ_NAME;
            parameters[2].Value = model.C_EQ_NUMBER;
            parameters[3].Value = model.C_EQ_CODE;
            parameters[4].Value = model.N_STATUS;
            parameters[5].Value = model.C_REMARK;
            parameters[6].Value = model.C_EMP_ID;
            parameters[7].Value = model.D_MOD_DT;

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
        public bool Update(Mod_TQB_PHYSICS_EQUIPMENT model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TQB_PHYSICS_EQUIPMENT set ");
            strSql.Append("C_PHYSICS_GROUP_ID=:C_PHYSICS_GROUP_ID,");
            strSql.Append("C_EQ_NAME=:C_EQ_NAME,");
            strSql.Append("C_EQ_NUMBER=:C_EQ_NUMBER,");
            strSql.Append("C_EQ_CODE=:C_EQ_CODE,");
            strSql.Append("N_STATUS=:N_STATUS,");
            strSql.Append("C_REMARK=:C_REMARK,");
            strSql.Append("C_EMP_ID=:C_EMP_ID,");
            strSql.Append("D_MOD_DT=:D_MOD_DT");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_PHYSICS_GROUP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_EQ_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_EQ_NUMBER", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_EQ_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.C_PHYSICS_GROUP_ID;
            parameters[1].Value = model.C_EQ_NAME;
            parameters[2].Value = model.C_EQ_NUMBER;
            parameters[3].Value = model.C_EQ_CODE;
            parameters[4].Value = model.N_STATUS;
            parameters[5].Value = model.C_REMARK;
            parameters[6].Value = model.C_EMP_ID;
            parameters[7].Value = model.D_MOD_DT;
            parameters[8].Value = model.C_ID;

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
            strSql.Append("delete from TQB_PHYSICS_EQUIPMENT ");
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
            strSql.Append("delete from TQB_PHYSICS_EQUIPMENT ");
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
        public Mod_TQB_PHYSICS_EQUIPMENT GetModel(string C_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_PHYSICS_GROUP_ID,C_EQ_NAME,C_EQ_NUMBER,C_EQ_CODE,N_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT from TQB_PHYSICS_EQUIPMENT ");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)          };
            parameters[0].Value = C_ID;

            Mod_TQB_PHYSICS_EQUIPMENT model = new Mod_TQB_PHYSICS_EQUIPMENT();
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
        public Mod_TQB_PHYSICS_EQUIPMENT DataRowToModel(DataRow row)
        {
            Mod_TQB_PHYSICS_EQUIPMENT model = new Mod_TQB_PHYSICS_EQUIPMENT();
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
                if (row["C_EQ_NAME"] != null)
                {
                    model.C_EQ_NAME = row["C_EQ_NAME"].ToString();
                }
                if (row["C_EQ_NUMBER"] != null)
                {
                    model.C_EQ_NUMBER = row["C_EQ_NUMBER"].ToString();
                }
                if (row["C_EQ_CODE"] != null)
                {
                    model.C_EQ_CODE = row["C_EQ_CODE"].ToString();
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
            }
            return model;
        }
        /// <summary>
		/// 根据设备名称获得数据列表
		/// </summary>
		public DataSet GetList(string C_EQ_NAME)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select a.C_ID,a.C_PHYSICS_GROUP_ID,a.C_EQ_NAME,a.C_EQ_NUMBER,a.C_EQ_CODE,a.N_STATUS,a.C_REMARK,a.C_EMP_ID,a.D_MOD_DT,t.C_NAME ");
            strSql.Append(" FROM TQB_PHYSICS_EQUIPMENT a join tqb_physics_group t on a.c_physics_group_id=t.c_id where a.n_status=1 ");
            if (C_EQ_NAME.Trim() != "")
            {
                strSql.Append(" and C_EQ_NAME like '%"+ C_EQ_NAME + "%'");
            }
            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        /// <param name="strWhere">外键</param>
        /// <returns></returns>
        public DataSet GetList_Fid(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select (T.C_EQ_NAME||'  |  '||T.C_EQ_NUMBER||'  |  '||T.C_EQ_CODE) as  C_EQ_NAME ");
            strSql.Append(" FROM TQB_PHYSICS_EQUIPMENT  t  where t.N_STATUS=1 ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" and C_PHYSICS_GROUP_ID = '" + strWhere + "'");
            }
            strSql.Append(" order by T.C_EQ_NAME ");

            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        /// <param name="strWhere">设备编号</param>
        /// <returns></returns>
        public DataSet GetList_Query(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_PHYSICS_GROUP_ID,C_EQ_NAME,C_EQ_NUMBER,C_EQ_CODE,N_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT ");
            strSql.Append(" FROM TQB_PHYSICS_EQUIPMENT  ");
            if (strWhere.Trim() != "")
            {
                strSql.Append("where C_EQ_CODE = '" + strWhere + "'");
            }
            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        /// <param name="C_PHYSICS_GROUP_ID">外键</param>
        /// <param name="C_EQ_NAME">设备名称</param>
        /// <returns></returns>
        public DataSet GetList_Number(string C_PHYSICS_GROUP_ID, string C_EQ_NAME)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  C_EQ_NUMBER  ");
            strSql.Append(" FROM TQB_PHYSICS_EQUIPMENT where 1=1 ");
            if (C_PHYSICS_GROUP_ID.Trim() != "")
            {
                strSql.Append(" and  C_PHYSICS_GROUP_ID = '" + C_PHYSICS_GROUP_ID + "'");
            }
            if (C_EQ_NAME.Trim() != "")
            {
                strSql.Append(" and  C_EQ_NAME = '" + C_EQ_NAME + "'");
            }
            strSql.Append(" group by C_EQ_NUMBER");
            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        /// <param name="C_PHYSICS_GROUP_ID">外键</param>
        /// <param name="C_EQ_NAME">设备名称</param>
        /// <param name="C_EQ_Number">设备编号</param>
        /// <returns></returns>
        public DataSet GetList_Code(string C_PHYSICS_GROUP_ID, string C_EQ_NAME,string C_EQ_Number)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  C_EQ_CODE  ");
            strSql.Append(" FROM TQB_PHYSICS_EQUIPMENT where 1=1 ");
            if (C_PHYSICS_GROUP_ID.Trim() != "")
            {
                strSql.Append(" and  C_PHYSICS_GROUP_ID = '" + C_PHYSICS_GROUP_ID + "'");
            }
            if (C_EQ_NAME.Trim() != "")
            {
                strSql.Append(" and  C_EQ_NAME = '" + C_EQ_NAME + "'");
            }
            if (C_EQ_Number.Trim() != "")
            {
                strSql.Append(" and  C_EQ_Number = '" + C_EQ_Number + "'");
            }
            strSql.Append(" group by C_EQ_CODE");
            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM TQB_PHYSICS_EQUIPMENT ");
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
            strSql.Append(")AS Row, T.*  from TQB_PHYSICS_EQUIPMENT T ");
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
			parameters[0].Value = "TQB_PHYSICS_EQUIPMENT";
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

