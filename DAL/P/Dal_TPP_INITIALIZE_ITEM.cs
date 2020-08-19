using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;
namespace DAL
{
    /// <summary>
    /// 数据访问类:TPP_INITIALIZE_ITEM
    /// </summary>
    public partial class Dal_TPP_INITIALIZE_ITEM
    {
        public Dal_TPP_INITIALIZE_ITEM()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string C_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TPP_INITIALIZE_ITEM");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)         };
            parameters[0].Value = C_ID;

            return DbHelperOra.Exists(strSql.ToString(), parameters);
        }


       /// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Mod_TPP_INITIALIZE_ITEM model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into TPP_INITIALIZE_ITEM(");
			strSql.Append("C_ISSUE,C_ITEM_NAME,C_GOAL,D_END_TIME,D_START_TIME,N_STATUS,C_REMARK,C_EMP_ID)");
			strSql.Append(" values (");
			strSql.Append(":C_ISSUE,:C_ITEM_NAME,:C_GOAL,:D_END_TIME,:D_START_TIME,:N_STATUS,:C_REMARK,:C_EMP_ID)");
			OracleParameter[] parameters = {
					
					new OracleParameter(":C_ISSUE", OracleDbType.Varchar2,100),
					new OracleParameter(":C_ITEM_NAME", OracleDbType.Varchar2,100),
					new OracleParameter(":C_GOAL", OracleDbType.Varchar2,200),
					new OracleParameter(":D_END_TIME", OracleDbType.Date),
					new OracleParameter(":D_START_TIME", OracleDbType.Date),
					new OracleParameter(":N_STATUS", OracleDbType.Decimal,2),
					new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
					new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100)};
			parameters[0].Value = model.C_ISSUE;
            parameters[1].Value = model.C_ITEM_NAME;
			parameters[2].Value = model.C_GOAL;
			parameters[3].Value = model.D_END_TIME;
			parameters[4].Value = model.D_START_TIME;
			parameters[5].Value = model.N_STATUS;
			parameters[6].Value = model.C_REMARK;
			parameters[7].Value = model.C_EMP_ID;

			int rows=DbHelperOra.ExecuteSql(strSql.ToString(),parameters);
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
		public bool Update(Mod_TPP_INITIALIZE_ITEM model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update TPP_INITIALIZE_ITEM set ");
			strSql.Append("C_ISSUE=:C_ISSUE,");
			strSql.Append("C_ITEM_NAME=:C_ITEM_NAME,");
			strSql.Append("C_GOAL=:C_GOAL,");
			strSql.Append("D_END_TIME=:D_END_TIME,");
			strSql.Append("D_START_TIME=:D_START_TIME,");
			strSql.Append("N_STATUS=:N_STATUS,");
			strSql.Append("C_REMARK=:C_REMARK,");
			strSql.Append("C_EMP_ID=:C_EMP_ID,");
			strSql.Append("D_MOD_DT=:D_MOD_DT");
			strSql.Append(" where C_ID=:C_ID ");
			OracleParameter[] parameters = {
					new OracleParameter(":C_ISSUE", OracleDbType.Varchar2,100),
					new OracleParameter(":C_ITEM_NAME", OracleDbType.Varchar2,100),
					new OracleParameter(":C_GOAL", OracleDbType.Varchar2,200),
					new OracleParameter(":D_END_TIME", OracleDbType.Date),
					new OracleParameter(":D_START_TIME", OracleDbType.Date),
					new OracleParameter(":N_STATUS", OracleDbType.Decimal,2),
					new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
					new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
					new OracleParameter(":D_MOD_DT", OracleDbType.Date),
					new OracleParameter(":C_ID", OracleDbType.Varchar2,100)};
			parameters[0].Value = model.C_ISSUE;
			parameters[1].Value = model.C_ITEM_NAME;
			parameters[2].Value = model.C_GOAL;
			parameters[3].Value = model.D_END_TIME;
			parameters[4].Value = model.D_START_TIME;
			parameters[5].Value = model.N_STATUS;
			parameters[6].Value = model.C_REMARK;
			parameters[7].Value = model.C_EMP_ID;
			parameters[8].Value = model.D_MOD_DT;
			parameters[9].Value = model.C_ID;

			int rows=DbHelperOra.ExecuteSql(strSql.ToString(),parameters);
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
            strSql.Append("delete from TPP_INITIALIZE_ITEM ");
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
            strSql.Append("delete from TPP_INITIALIZE_ITEM ");
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
        public Mod_TPP_INITIALIZE_ITEM GetModel(string C_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_ISSUE,C_ITEM_NAME,C_GOAL,D_END_TIME,D_START_TIME,N_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT  from TPP_INITIALIZE_ITEM ");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)         };
            parameters[0].Value = C_ID;

            Mod_TPP_INITIALIZE_ITEM model = new Mod_TPP_INITIALIZE_ITEM();
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
        public Mod_TPP_INITIALIZE_ITEM DataRowToModel(DataRow row)
        {
            Mod_TPP_INITIALIZE_ITEM model = new Mod_TPP_INITIALIZE_ITEM();
            if (row != null)
            {
                if (row["C_ID"] != null)
                {
                    model.C_ID = row["C_ID"].ToString();
                }
                if (row["C_ISSUE"] != null)
                {
                    model.C_ISSUE = row["C_ISSUE"].ToString();
                }
                if (row["C_ITEM_NAME"] != null)
                {
                    model.C_ITEM_NAME = row["C_ITEM_NAME"].ToString();
                }
                if (row["C_GOAL"] != null)
                {
                    model.C_GOAL = row["C_GOAL"].ToString();
                }
                if (row["D_END_TIME"] != null && row["D_END_TIME"].ToString() != "")
                {
                    model.D_END_TIME = DateTime.Parse(row["D_END_TIME"].ToString());
                }
                if (row["D_START_TIME"] != null && row["D_START_TIME"].ToString() != "")
                {
                    model.D_START_TIME = DateTime.Parse(row["D_START_TIME"].ToString());
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
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_ISSUE,C_ITEM_NAME,C_GOAL,D_END_TIME,D_START_TIME,N_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT  ");
            strSql.Append(" FROM TPP_INITIALIZE_ITEM ");
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
            strSql.Append("select count(1) FROM TPP_INITIALIZE_ITEM ");
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
            strSql.Append(")AS Row, T.*  from TPP_INITIALIZE_ITEM T ");
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
       /// 获取方案列表
       /// </summary>
       /// <param name="N_STATUS">方案状态</param>
       /// <param name="C_ISSUE">期号</param>
       /// <param name="C_ITEM_NAME">方案名称</param>
       /// <returns>方案列表</returns>
        public DataSet GetList(int? N_STATUS, string C_ISSUE, string C_ITEM_NAME)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT B.C_TYPE, T.C_ISSUE, T.C_ITEM_NAME, B.D_START_TIME, B.D_END_TIME, T.C_GOAL, DECODE(T.N_STATUS, 0, '待生效', 1, '已生效', '已失效') N_STATUS, T.C_ID, T.C_REMARK, T.C_EMP_ID, T.D_MOD_DT FROM TPP_INITIALIZE_ITEM T, TPP_PROD_INITIALIZE B WHERE  T.C_ISSUE = B.C_ISSUE   ");
           
            if (N_STATUS!=null)
            {
                strSql.Append(" AND T.N_STATUS=" + N_STATUS  );
            }
            if (C_ISSUE.Trim() != "")
            {
                strSql.Append(" AND T.C_ISSUE='" + C_ISSUE + "'");
            }
            if (C_ITEM_NAME.Trim() != "")
            {
                strSql.Append(" AND T.C_ITEM_NAME='" + C_ITEM_NAME + "'");
            }
            strSql.Append(" ORDER BY T.C_ITEM_NAME");
            return DbHelperOra.Query(strSql.ToString());
        }


        /// <summary>
        /// 获取方案列表
        /// </summary>
        /// <param name="N_STATUS">状态</param>
        /// <param name="type">类型</param>
        /// <param name="dt1">开始日期</param>
        /// <param name="dt2">结束日期</param>
        /// <returns></returns>
        public DataSet GetList(int? N_STATUS,string type, string  dt1, string  dt2)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT B.C_TYPE, T.C_ISSUE, T.C_ITEM_NAME, B.D_START_TIME, B.D_END_TIME, T.C_GOAL, DECODE(T.N_STATUS, 0, '待生效', 1, '已生效', '已失效') N_STATUS, T.C_ID, T.C_REMARK, T.C_EMP_ID, T.D_MOD_DT FROM TPP_INITIALIZE_ITEM T, TPP_PROD_INITIALIZE B WHERE  T.C_ISSUE = B.C_ISSUE   ");

            if (N_STATUS != null)
            {
                strSql.Append(" AND T.N_STATUS=" + N_STATUS);
            }
            if (type.Trim() != "")
            {
                strSql.Append(" AND B.C_TYPE='" + type + "'");
            }
            if (dt1.Trim()!="")
            {
                strSql.Append(" AND B.D_START_TIME>=to_date('" + dt1 + "','yyyy-mm-dd')");
            }
            if (dt2.Trim() != "")
            {
                strSql.Append(" AND B.D_END_TIME<=to_date('" + dt2 + "','yyyy-mm-dd')");
            }
            strSql.Append("  ORDER BY B.C_TYPE DESC, T.C_ISSUE ,T.D_MOD_DT ");
            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取方案列表
        /// </summary>
        /// <param name="C_ITEM_NAME">方案名称</param>
        /// <returns>方案列表</returns>
        public DataSet GetListByNAME(string C_ITEM_NAME)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  C_ID,C_ISSUE,C_ITEM_NAME,C_GOAL,D_END_TIME,D_START_TIME,DECODE(N_STATUS,0,'待生效',1,'已生效','已失效') N_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT  ");
            strSql.Append(" FROM TPP_INITIALIZE_ITEM WHERE 1=1");
            if (C_ITEM_NAME.Trim() != "")
            {
                strSql.Append(" AND C_ITEM_NAME='" + C_ITEM_NAME + "'");
            }
            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取新的方案号
        /// </summary>
        /// <param name="C_ISSUE">档期号</param>
        /// <returns>方案号</returns>
        public string  GetNewItemNameByIssue(string C_ISSUE)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select   MAX(TO_NUMBER(NVL(C_ITEM_NAME, TO_CHAR(SYSDATE, 'yymmdd') || '01')))+1  NO ");
            strSql.Append(" FROM TPP_INITIALIZE_ITEM WHERE 1=1");
            if (C_ISSUE.Trim() != "")
            {
                strSql.Append(" AND C_ISSUE='" + C_ISSUE + "'");
            }
            DataTable dt= DbHelperOra.Query(strSql.ToString()).Tables[0];
            string no = dt.Rows[0]["NO"].ToString();
            if (no.Trim()=="")
            {
                no = System.DateTime.Now.ToString("yyMMdd")+"01";
            }
            return no;
        }
        /// <summary>
        /// 获得期数
        /// </summary>
        public DataSet GetQSList()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select distinct C_ISSUE ");
            strSql.Append(" FROM TPP_INITIALIZE_ITEM WHERE 1=1");
            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 获得当前期数
        /// </summary>
        public DataSet GetQSListByTime(DateTime dateTime)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select distinct C_ISSUE ");
            strSql.Append(" FROM TPP_INITIALIZE_ITEM WHERE N_STATUS=1 AND D_END_TIME>to_date('" + dateTime + "','yyyy-mm-dd hh24:mi:ss') ");
            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 根据期数获取数据
        /// </summary>
        public DataSet GetListByQS(string qs)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * ");
            strSql.Append(" FROM TPP_INITIALIZE_ITEM WHERE C_ISSUE='"+qs+"'");
            return DbHelperOra.Query(strSql.ToString());
        }
        #endregion  ExtensionMethod
    }
}
