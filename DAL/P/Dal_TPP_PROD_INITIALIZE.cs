using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;
namespace DAL
{
	/// <summary>
	/// 数据访问类:TPP_PROD_INITIALIZE
	/// </summary>
	public partial class Dal_TPP_PROD_INITIALIZE
    {
		public Dal_TPP_PROD_INITIALIZE()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string C_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from TPP_PROD_INITIALIZE");
			strSql.Append(" where C_ID=:C_ID ");
			OracleParameter[] parameters = {
					new OracleParameter(":C_ID", OracleDbType.Varchar2,100)			};
			parameters[0].Value = C_ID;

			return DbHelperOra.Exists(strSql.ToString(),parameters);
		}


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Mod_TPP_PROD_INITIALIZE model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TPP_PROD_INITIALIZE(");
            strSql.Append("C_ISSUE,D_START_TIME,D_END_TIME,C_TYPE,C_YM,C_REMARK,C_EMP_ID)");
            strSql.Append(" values (");
            strSql.Append(":C_ISSUE,:D_START_TIME,:D_END_TIME,:C_TYPE,:C_YM,:C_REMARK,:C_EMP_ID)");
            OracleParameter[] parameters = {
                    
                    new OracleParameter(":C_ISSUE", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_START_TIME", OracleDbType.Date),
                    new OracleParameter(":D_END_TIME", OracleDbType.Date),
                    new OracleParameter(":C_TYPE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_YM", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,200),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.C_ISSUE;
            parameters[1].Value = model.D_START_TIME;
            parameters[2].Value = model.D_END_TIME;
            parameters[3].Value = model.C_TYPE;
            parameters[4].Value = model.C_YM;
            parameters[5].Value = model.C_REMARK;
            parameters[6].Value = model.C_EMP_ID; 

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
        public bool Update(Mod_TPP_PROD_INITIALIZE model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TPP_PROD_INITIALIZE set ");
            strSql.Append("C_ISSUE=:C_ISSUE,");
            strSql.Append("D_START_TIME=:D_START_TIME,");
            strSql.Append("D_END_TIME=:D_END_TIME,");
            strSql.Append("C_TYPE=:C_TYPE,");
            strSql.Append("C_YM=:C_YM,");
            strSql.Append("C_STATUS=:C_STATUS,");
            strSql.Append("C_REMARK=:C_REMARK,");
            strSql.Append("C_EMP_ID=:C_EMP_ID,");
            strSql.Append("D_MOD_DT=:D_MOD_DT");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ISSUE", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_START_TIME", OracleDbType.Date),
                    new OracleParameter(":D_END_TIME", OracleDbType.Date),
                    new OracleParameter(":C_TYPE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_YM", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STATUS", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,200),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.C_ISSUE;
            parameters[1].Value = model.D_START_TIME;
            parameters[2].Value = model.D_END_TIME;
            parameters[3].Value = model.C_TYPE;
            parameters[4].Value = model.C_YM;
            parameters[5].Value = model.C_STATUS;
            parameters[6].Value = model.C_REMARK;
            parameters[7].Value = model.C_EMP_ID;
            parameters[8].Value = model.D_MOD_DT;
            parameters[9].Value = model.C_ID;

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
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from TPP_PROD_INITIALIZE ");
			strSql.Append(" where C_ID=:C_ID ");
			OracleParameter[] parameters = {
					new OracleParameter(":C_ID", OracleDbType.Varchar2,100)			};
			parameters[0].Value = C_ID;

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
		/// 批量删除数据
		/// </summary>
		public bool DeleteList(string C_IDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from TPP_PROD_INITIALIZE ");
			strSql.Append(" where C_ID in ("+C_IDlist + ")  ");
			int rows=DbHelperOra.ExecuteSql(strSql.ToString());
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
        public Mod_TPP_PROD_INITIALIZE GetModel(string C_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  C_ID,C_ISSUE,D_START_TIME,D_END_TIME,C_TYPE,C_YM,C_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT from TPP_PROD_INITIALIZE  ");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)         };
            parameters[0].Value = C_ID;

            Mod_TPP_PROD_INITIALIZE model = new Mod_TPP_PROD_INITIALIZE();
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
        /// 通过期数获得实体
        /// </summary>
        /// <param name="C_ISSUE">期数</param>
        /// <returns></returns>
        public Mod_TPP_PROD_INITIALIZE GetModelByISSUE(string C_ISSUE)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  C_ID,C_ISSUE,D_START_TIME,D_END_TIME,C_TYPE,C_YM,C_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT from TPP_PROD_INITIALIZE  ");
            strSql.Append(" where C_ISSUE=:C_ISSUE ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ISSUE", OracleDbType.Varchar2,100)         };
            parameters[0].Value = C_ISSUE;

            Mod_TPP_PROD_INITIALIZE model = new Mod_TPP_PROD_INITIALIZE();
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
        public Mod_TPP_PROD_INITIALIZE DataRowToModel(DataRow row)
		{
			Mod_TPP_PROD_INITIALIZE model=new Mod_TPP_PROD_INITIALIZE();
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
                if (row["D_START_TIME"] != null && row["D_START_TIME"].ToString() != "")
                {
                    model.D_START_TIME = DateTime.Parse(row["D_START_TIME"].ToString());
                }
                if (row["D_END_TIME"] != null && row["D_END_TIME"].ToString() != "")
                {
                    model.D_END_TIME = DateTime.Parse(row["D_END_TIME"].ToString());
                }
                if (row["C_TYPE"] != null)
                {
                    model.C_TYPE = row["C_TYPE"].ToString();
                }
                if (row["C_YM"] != null)
                {
                    model.C_YM = row["C_YM"].ToString();
                }
                if (row["C_STATUS"] != null)
                {
                    model.C_STATUS = row["C_STATUS"].ToString();
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
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select C_ID,C_ISSUE,D_START_TIME,D_END_TIME,C_TYPE,C_YM,C_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT ");
			strSql.Append(" FROM TPP_PROD_INITIALIZE ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperOra.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM TPP_PROD_INITIALIZE ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
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




        #endregion  BasicMethod
        #region  ExtensionMethod
        /// <summary>
        /// 得到一个排产方案序号（废除）
        /// </summary>
        public string  GetMaxNum(string strDate)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT MAX(to_number(replace(t.c_prod_code,'" + strDate + "'))) MaxNo  FROM TPP_PROD_INITIALIZE t WHERE instr(t.c_prod_code,'" + strDate + "')>0 ");
            DataTable dt = DbHelperOra.Query(strSql.ToString()).Tables[0];
            if (dt.Rows.Count > 0)
            {
                return strDate + (Convert.ToInt32(dt.Rows[0]["MaxNo"].ToString().Trim()==""?"0": dt.Rows[0]["MaxNo"].ToString()) + 1).ToString();
            }
            else
            {
                return strDate+"1";
            }
        }

        /// <summary>
        /// 得到一个排产期数（废除）
        /// </summary>
        public string GetMaxIssue(string strDate)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT MAX(to_number(replace(t.C_ISSUE,'" + strDate + "'))) MaxNo  FROM TPP_PROD_INITIALIZE t WHERE instr(t.C_ISSUE,'" + strDate + "')>0 ");
            DataTable dt = DbHelperOra.Query(strSql.ToString()).Tables[0];
            if (dt.Rows.Count > 0)
            {
                return strDate + (Convert.ToInt32(dt.Rows[0]["MaxNo"].ToString()) + 1).ToString();
            }
            else
            {
                return strDate + "1";
            }
        }

        /// <summary>
        ///获取当前选择年月的排产方案数量
        /// </summary>
        /// <param name="YM">选择的年月</param>
        /// <param name="type">排产类型：月排产/旬排产</param>
        /// <returns>选择年月排产数量</returns>
        public int GetTheMonthNum(string YM,string type)
        {
            string sql = "SELECT COUNT(1) COU  FROM TPP_PROD_INITIALIZE T WHERE T.C_ISSUE LIKE '%"+ YM + "%'  AND T.C_TYPE = '"+type+"'";
            DataTable dt = DbHelperOra.Query(sql).Tables[0];
            if (dt.Rows.Count==1)
            {
                return Convert.ToInt32( dt.Rows[0]["COU"].ToString());
            }
            else
            {
                return 0;
            }
        }
        /// <summary>
        /// 根据年月加载档期信息
        /// </summary>
        /// <param name="YM">选择的年月</param>
        /// <param name="C_TYPE">选择的类型</param>
        public DataTable GetListByYM(string YM,string  C_TYPE)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  C_ID,C_ISSUE,D_START_TIME,D_END_TIME,C_TYPE,C_YM,C_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT from TPP_PROD_INITIALIZE  ");
            strSql.Append(" where 1=1 ");
            if (YM.Trim()!="")
            {
                strSql.Append(" AND C_YM='"+ YM + "' ");
               
              
            }
            if (C_TYPE.Trim() != "")
            {
                strSql.Append(" AND C_TYPE='"+ C_TYPE + "' ");


            }

            return DbHelperOra.Query(strSql.ToString()).Tables[0];
           
           
            
        }
       
        #endregion  ExtensionMethod
    }
}

