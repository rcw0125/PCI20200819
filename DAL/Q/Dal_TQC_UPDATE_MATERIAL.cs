using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;
namespace DAL
{
    /// <summary>
    /// 数据访问类:TQC_UPDATE_MATERIAL
    /// </summary>
    public partial class Dal_TQC_UPDATE_MATERIAL
    {
        public Dal_TQC_UPDATE_MATERIAL()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string C_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TQC_UPDATE_MATERIAL");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)         };
            parameters[0].Value = C_ID;

            return DbHelperOra.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Mod_TQC_UPDATE_MATERIAL model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TQC_UPDATE_MATERIAL(");
            strSql.Append("C_ROLL_PRODUCT_ID,C_TYPE,N_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT,N_WGT,N_WGT_DIFFERENCE,C_SFHG)");
            strSql.Append(" values (");
            strSql.Append(":C_ROLL_PRODUCT_ID,:C_TYPE,:N_STATUS,:C_REMARK,:C_EMP_ID,:D_MOD_DT,:N_WGT,:N_WGT_DIFFERENCE,:C_SFHG)");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ROLL_PRODUCT_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_TYPE", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":N_WGT", OracleDbType.Decimal,6),
                    new OracleParameter(":N_WGT_DIFFERENCE", OracleDbType.Decimal,6),
                    new OracleParameter(":C_SFHG", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.C_ROLL_PRODUCT_ID;
            parameters[1].Value = model.C_TYPE;
            parameters[2].Value = model.N_STATUS;
            parameters[3].Value = model.C_REMARK;
            parameters[4].Value = model.C_EMP_ID;
            parameters[5].Value = model.D_MOD_DT;
            parameters[6].Value = model.N_WGT;
            parameters[7].Value = model.N_WGT_DIFFERENCE;
            parameters[8].Value = model.C_SFHG;

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
		/// 增加一条数据
		/// </summary>
		public bool Add_Trans(Mod_TQC_UPDATE_MATERIAL model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TQC_UPDATE_MATERIAL(");
            strSql.Append("C_ROLL_PRODUCT_ID,C_TYPE,N_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT,N_WGT,N_WGT_DIFFERENCE,C_SFHG)");
            strSql.Append(" values (");
            strSql.Append(":C_ROLL_PRODUCT_ID,:C_TYPE,:N_STATUS,:C_REMARK,:C_EMP_ID,:D_MOD_DT,:N_WGT,:N_WGT_DIFFERENCE,:C_SFHG)");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ROLL_PRODUCT_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_TYPE", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":N_WGT", OracleDbType.Decimal,6),
                    new OracleParameter(":N_WGT_DIFFERENCE", OracleDbType.Decimal,6),
                    new OracleParameter(":C_SFHG", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.C_ROLL_PRODUCT_ID;
            parameters[1].Value = model.C_TYPE;
            parameters[2].Value = model.N_STATUS;
            parameters[3].Value = model.C_REMARK;
            parameters[4].Value = model.C_EMP_ID;
            parameters[5].Value = model.D_MOD_DT;
            parameters[6].Value = model.N_WGT;
            parameters[7].Value = model.N_WGT_DIFFERENCE;
            parameters[8].Value = model.C_SFHG;

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
        /// 更新一条数据
        /// </summary>
        public bool Update(Mod_TQC_UPDATE_MATERIAL model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TQC_UPDATE_MATERIAL set ");
            strSql.Append("C_ROLL_PRODUCT_ID=:C_ROLL_PRODUCT_ID,");
            strSql.Append("C_TYPE=:C_TYPE,");
            strSql.Append("N_STATUS=:N_STATUS,");
            strSql.Append("C_REMARK=:C_REMARK,");
            strSql.Append("C_EMP_ID=:C_EMP_ID,");
            strSql.Append("D_MOD_DT=:D_MOD_DT,");
            strSql.Append("N_WGT=:N_WGT,");
            strSql.Append("N_WGT_DIFFERENCE=:N_WGT_DIFFERENCE,");
            strSql.Append("C_SFHG=:C_SFHG");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ROLL_PRODUCT_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_TYPE", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":N_WGT", OracleDbType.Decimal,6),
                    new OracleParameter(":N_WGT_DIFFERENCE", OracleDbType.Decimal,6),
                    new OracleParameter(":C_SFHG", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.C_ROLL_PRODUCT_ID;
            parameters[1].Value = model.C_TYPE;
            parameters[2].Value = model.N_STATUS;
            parameters[3].Value = model.C_REMARK;
            parameters[4].Value = model.C_EMP_ID;
            parameters[5].Value = model.D_MOD_DT;
            parameters[6].Value = model.N_WGT;
            parameters[7].Value = model.N_WGT_DIFFERENCE;
            parameters[8].Value = model.C_SFHG;
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
        /// 更新一条数据
        /// </summary>
        public bool Update_Trans(Mod_TQC_UPDATE_MATERIAL model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TQC_UPDATE_MATERIAL set ");
            strSql.Append("C_ROLL_PRODUCT_ID=:C_ROLL_PRODUCT_ID,");
            strSql.Append("C_TYPE=:C_TYPE,");
            strSql.Append("N_STATUS=:N_STATUS,");
            strSql.Append("C_REMARK=:C_REMARK,");
            strSql.Append("C_EMP_ID=:C_EMP_ID,");
            strSql.Append("D_MOD_DT=:D_MOD_DT,");
            strSql.Append("N_WGT=:N_WGT,");
            strSql.Append("N_WGT_DIFFERENCE=:N_WGT_DIFFERENCE,");
            strSql.Append("C_SFHG=:C_SFHG");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ROLL_PRODUCT_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_TYPE", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":N_WGT", OracleDbType.Decimal,6),
                    new OracleParameter(":N_WGT_DIFFERENCE", OracleDbType.Decimal,6),
                    new OracleParameter(":C_SFHG", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.C_ROLL_PRODUCT_ID;
            parameters[1].Value = model.C_TYPE;
            parameters[2].Value = model.N_STATUS;
            parameters[3].Value = model.C_REMARK;
            parameters[4].Value = model.C_EMP_ID;
            parameters[5].Value = model.D_MOD_DT;
            parameters[6].Value = model.N_WGT;
            parameters[7].Value = model.N_WGT_DIFFERENCE;
            parameters[8].Value = model.C_SFHG;
            parameters[9].Value = model.C_ID;

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
        /// 删除一条数据
        /// </summary>
        public bool Delete(string C_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from TQC_UPDATE_MATERIAL ");
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
            strSql.Append("delete from TQC_UPDATE_MATERIAL ");
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
        public Mod_TQC_UPDATE_MATERIAL GetModel(string C_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_ROLL_PRODUCT_ID,C_TYPE,N_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT,N_WGT,N_WGT_DIFFERENCE,C_SFHG from TQC_UPDATE_MATERIAL ");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)         };
            parameters[0].Value = C_ID;

            Mod_TQC_UPDATE_MATERIAL model = new Mod_TQC_UPDATE_MATERIAL();
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
        public Mod_TQC_UPDATE_MATERIAL DataRowToModel(DataRow row)
        {
            Mod_TQC_UPDATE_MATERIAL model = new Mod_TQC_UPDATE_MATERIAL();
            if (row != null)
            {
                if (row["C_ID"] != null)
                {
                    model.C_ID = row["C_ID"].ToString();
                }
                if (row["C_ROLL_PRODUCT_ID"] != null)
                {
                    model.C_ROLL_PRODUCT_ID = row["C_ROLL_PRODUCT_ID"].ToString();
                }
                if (row["C_TYPE"] != null)
                {
                    model.C_TYPE = row["C_TYPE"].ToString();
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
                if (row["N_WGT"] != null && row["N_WGT"].ToString() != "")
                {
                    model.N_WGT = decimal.Parse(row["N_WGT"].ToString());
                }
                if (row["N_WGT_DIFFERENCE"] != null && row["N_WGT_DIFFERENCE"].ToString() != "")
                {
                    model.N_WGT_DIFFERENCE = decimal.Parse(row["N_WGT_DIFFERENCE"].ToString());
                }
                if (row["C_SFHG"] != null)
                {
                    model.C_SFHG = row["C_SFHG"].ToString();
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
            strSql.Append("select C_ID,C_ROLL_PRODUCT_ID,C_TYPE,N_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT,C_SFHG ");
            strSql.Append(" FROM TQC_UPDATE_MATERIAL ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList_Query(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select T2.C_LINEWH_NAME,T1.C_BATCH_NO,T1.C_TICK_NO,T1.C_STL_GRD,T1.C_STD_CODE,T1.N_WGT,T1.C_LINEWH_CODE,T1.C_MAT_CODE,T1.C_MAT_DESC,T.C_ID,T.C_ROLL_PRODUCT_ID,DECODE( T.C_TYPE,'0','已申请') typename,T.N_STATUS,T.C_REMARK,T.C_EMP_ID,T.D_MOD_DT  ");
            strSql.Append("  FROM TQC_UPDATE_MATERIAL T  LEFT JOIN TRC_ROLL_PRODCUT T1 ON T.C_ROLL_PRODUCT_ID=T1.C_ID  LEFT JOIN TPB_LINEWH T2 ON T1.C_LINEWH_CODE=T2.C_LINEWH_CODE WHERE T.N_STATUS=1 AND t.c_type='0' ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" AND T1.C_BATCH_NO LIKE '%" + strWhere + "%' ");
            }
            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList_CXXL(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select T2.C_LINEWH_NAME,T1.C_BATCH_NO,T1.C_TICK_NO,T1.C_STL_GRD,T1.C_STD_CODE,T1.N_WGT,T1.C_LINEWH_CODE,T1.C_MAT_CODE,T1.C_MAT_DESC,T.C_ID,T.C_ROLL_PRODUCT_ID,DECODE( T.C_TYPE,'0','已申请') typename,T.N_STATUS,T.C_REMARK,T.C_EMP_ID,T.D_MOD_DT  ");
            strSql.Append("  FROM TQC_UPDATE_MATERIAL T  LEFT JOIN TRC_ROLL_PRODCUT T1 ON T.C_ROLL_PRODUCT_ID=T1.C_ID  LEFT JOIN TPB_LINEWH T2 ON T1.C_LINEWH_CODE=T2.C_LINEWH_CODE WHERE T.N_STATUS=1 AND t.c_type='0' ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" AND T1.C_BATCH_NO = '" + strWhere + "' ");
            }
            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        /// <param name="begin">开始日期</param>
        /// <param name="end">结束日期</param>
        /// <param name="batchNo">批号</param>
        /// <param name="type">状态</param>
        /// <returns></returns>
        public DataSet GetList_Query_date(DateTime begin, DateTime end, string batchNo, string type, string strSta)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  T2.C_LINEWH_NAME,T1.C_BATCH_NO,T1.C_TICK_NO,T1.C_STL_GRD,T1.C_STD_CODE,T1.N_WGT,T1.C_LINEWH_CODE,T1.C_MAT_CODE,T1.C_MAT_DESC,T.C_ID,T.C_ROLL_PRODUCT_ID,DECODE( T.C_TYPE,'0','借料','1','还料申请','2','还料确认','3','质量确认','4','取样','5','修料申请') typename,T.N_STATUS,T.C_REMARK,T.C_EMP_ID,T.D_MOD_DT,T.N_WGT as WGT,T.N_WGT_DIFFERENCE,T.C_SFHG   FROM TQC_UPDATE_MATERIAL T  LEFT JOIN TRC_ROLL_PRODCUT T1 ON T.C_ROLL_PRODUCT_ID=T1.C_ID  LEFT JOIN TPB_LINEWH T2 ON T1.C_LINEWH_CODE=T2.C_LINEWH_CODE WHERE T.N_STATUS=1 ");
            if (begin != null && end != null)
            {
                strSql.Append("and t.D_MOD_DT between to_date('" + Convert.ToDateTime(begin) + "','yyyy-mm-dd hh24:mi:ss') and to_date('" + Convert.ToDateTime(end) + "','yyyy-mm-dd hh24:mi:ss') ");
            }
            if (batchNo.Trim() != "")
            {
                strSql.Append(" AND T1.C_BATCH_NO LIKE '%" + batchNo + "%' ");
            }
            if (type.Trim() != "")
            {
                strSql.Append(" AND (T.c_type = '" + type + "' OR T.c_type = '" + strSta + "' ) ");
            }
            strSql.Append(" ORDER BY T1.C_BATCH_NO,T1.C_TICK_NO,T.D_MOD_DT ");
            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        /// <param name="begin">开始日期</param>
        /// <param name="end">结束日期</param>
        /// <param name="batchNo">批号</param>
        /// <param name="stl">钢种</param>
        /// <param name="Type">修料状态</param>
        /// <returns></returns>
        public DataSet GetList_Query_date_log(DateTime begin, DateTime end, string batchNo, string stl,string Type)
        {
            string sql = @"select * from(SELECT T.修料状态,T.批号,
                           T.钩号,
                           T.钢种,
                           T.执行标准,
                           T.仓库名称,
                           T.仓库编码,
                           T.物料编码,
                           T.物料描述,
                           max(T.处置意见)AS 处置意见,
                           MAX(T.原重量) AS 原重量,
                           max(T.现重量) AS 现重量,
                           MAX(T.重量差) AS 重量差,
                           max(T.是否合格) AS 是否合格,
                           MIN(DECODE(T.TYPENAME, '修料申请', T.C_NAME, '')) AS 修料申请人主键,
                           MIN(DECODE(T.TYPENAME, '修料申请', T.操作时间, '')) AS 修料申请时间,
                           MIN(DECODE(T.TYPENAME, '借料', T.C_NAME, '')) AS 借料人主键,
                           MIN(DECODE(T.TYPENAME, '借料', T.操作时间, '')) AS 借料时间,
                           MIN(DECODE(T.TYPENAME, '取样', T.C_NAME, '')) AS 取样主键,
                           MIN(DECODE(T.TYPENAME, '取样', T.操作时间, '')) AS 取样时间,
                           MAX(DECODE(T.TYPENAME, '还料申请', T.C_NAME, '')) AS 还料申请人主键,
                           MAX(DECODE(T.TYPENAME, '还料申请', T.操作时间, '')) AS 还料申请时间,
                           MAX(DECODE(T.TYPENAME, '还料确认', T.C_NAME, '')) AS 还料确认人主键,
                           MAX(DECODE(T.TYPENAME, '还料确认', T.操作时间, '')) AS 还料确认时间 ,
                           MAX(DECODE(T.TYPENAME, '质量确认', T.C_NAME, '')) AS 质量确认人主键,
                           MAX(DECODE(T.TYPENAME, '质量确认', T.操作时间, '')) AS 质量确认时间 
                            FROM V_XL T where 1=1 ";
           
            if (batchNo.Trim() != "")
            {
                sql += @" AND T.批号 LIKE '%" + batchNo + "%' ";
            }
            if (stl.Trim() != "")
            {
                sql += @" AND T.钢种 LIKE '%" + stl + "%' ";
            }
            sql += @"GROUP BY T.修料状态,T.仓库名称,
                              T.批号,
                              T.钩号,
                              T.钢种,
                              T.执行标准,
                              T.仓库编码,
                              T.物料编码,
                              T.物料描述 )  where 1=1 ";
            if (begin != null && end != null)
            {
                sql += @"and to_date( 修料申请时间, 'yyyy-mm-dd hh24:mi:ss') between to_date('" + Convert.ToDateTime(begin) + "','yyyy-mm-dd hh24:mi:ss') and to_date('" + Convert.ToDateTime(end) + "','yyyy-mm-dd hh24:mi:ss') ";
            }
            if (Type.Trim() != "")
            {
                if (Type.Trim()== "未完成")
                {
                    sql += @" AND 修料状态 LIKE '%待修料%' ";
                }
                if (Type.Trim() == "已完成")
                {
                    sql += @" AND (修料状态 NOT LIKE ('%待修料%') OR 修料状态 IS NULL ) ";
                }
            }
            return DbHelperOra.Query(sql);
        }
        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM TQC_UPDATE_MATERIAL ");
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
            strSql.Append(")AS Row, T.*  from TQC_UPDATE_MATERIAL T ");
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
			parameters[0].Value = "TQC_UPDATE_MATERIAL";
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

