using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;
namespace DAL
{
	/// <summary>
	/// 数据访问类:TPB_REPLACE_GRD
	/// </summary>
	public partial class Dal_TPB_REPLACE_GRD
    {
		public Dal_TPB_REPLACE_GRD()
		{}
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string C_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TPB_REPLACE_GRD");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)         };
            parameters[0].Value = C_ID;

            return DbHelperOra.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Mod_TPB_REPLACE_GRD model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TPB_REPLACE_GRD(");
            strSql.Append("C_STL_GRD,C_REPLACE_GRD,N_LEVEL,C_REMARK,N_STATUS,C_EMP_ID,D_MOD_DT,D_START_DATE,D_END_DATE,C_STD_CODE,C_REPLACE_STD_CODE,N_SFXM,C_SFXM,C_SLAB_TYPE,C_SWL,C_STD_MAIN_ID,C_STD_MAIN_KDZ_ID,C_SL)");
            strSql.Append(" values (");
            strSql.Append(":C_STL_GRD,:C_REPLACE_GRD,:N_LEVEL,:C_REMARK,:N_STATUS,:C_EMP_ID,:D_MOD_DT,:D_START_DATE,:D_END_DATE,:C_STD_CODE,:C_REPLACE_STD_CODE,:N_SFXM,:C_SFXM,:C_SLAB_TYPE,:C_SWL,:C_STD_MAIN_ID,:C_STD_MAIN_KDZ_ID,:C_SL)");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_STL_GRD", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_REPLACE_GRD", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_LEVEL", OracleDbType.Decimal,3),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,200),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":D_START_DATE", OracleDbType.Date),
                    new OracleParameter(":D_END_DATE", OracleDbType.Date),
                    new OracleParameter(":C_STD_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_REPLACE_STD_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_SFXM", OracleDbType.Decimal,1),
                    new OracleParameter(":C_SFXM", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SLAB_TYPE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SWL", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STD_MAIN_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STD_MAIN_KDZ_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SL", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.C_STL_GRD;
            parameters[1].Value = model.C_REPLACE_GRD;
            parameters[2].Value = model.N_LEVEL;
            parameters[3].Value = model.C_REMARK;
            parameters[4].Value = model.N_STATUS;
            parameters[5].Value = model.C_EMP_ID;
            parameters[6].Value = model.D_MOD_DT;
            parameters[7].Value = model.D_START_DATE;
            parameters[8].Value = model.D_END_DATE;
            parameters[9].Value =  model.C_STD_CODE;
            parameters[10].Value = model.C_REPLACE_STD_CODE;
            parameters[11].Value = model.N_SFXM;
            parameters[12].Value = model.C_SFXM;
            parameters[13].Value = model.C_SLAB_TYPE;
            parameters[14].Value = model.C_SWL;
            parameters[15].Value = model.C_STD_MAIN_ID;
            parameters[16].Value = model.C_STD_MAIN_KDZ_ID;
            parameters[17].Value = model.C_SL;

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
		public bool Update(Mod_TPB_REPLACE_GRD model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TPB_REPLACE_GRD set ");
            strSql.Append("C_STL_GRD=:C_STL_GRD,");
            strSql.Append("C_REPLACE_GRD=:C_REPLACE_GRD,");
            strSql.Append("N_LEVEL=:N_LEVEL,");
            strSql.Append("C_REMARK=:C_REMARK,");
            strSql.Append("N_STATUS=:N_STATUS,");
            strSql.Append("C_EMP_ID=:C_EMP_ID,");
            strSql.Append("D_MOD_DT=:D_MOD_DT,");
            strSql.Append("D_START_DATE=:D_START_DATE,");
            strSql.Append("D_END_DATE=:D_END_DATE,");
            strSql.Append("C_STD_CODE=:C_STD_CODE,");
            strSql.Append("C_REPLACE_STD_CODE=:C_REPLACE_STD_CODE,");
            strSql.Append("N_SFXM=:N_SFXM,");
            strSql.Append("C_SFXM=:C_SFXM,");
            strSql.Append("C_SLAB_TYPE=:C_SLAB_TYPE,");
            strSql.Append("C_SWL=:C_SWL,");
            strSql.Append("C_STD_MAIN_ID=:C_STD_MAIN_ID,");
            strSql.Append("C_STD_MAIN_KDZ_ID=:C_STD_MAIN_KDZ_ID");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_STL_GRD", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_REPLACE_GRD", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_LEVEL", OracleDbType.Decimal,3),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,200),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":D_START_DATE", OracleDbType.Date),
                    new OracleParameter(":D_END_DATE", OracleDbType.Date),
                    new OracleParameter(":C_STD_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_REPLACE_STD_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_SFXM", OracleDbType.Decimal,1),
                    new OracleParameter(":C_SFXM", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SLAB_TYPE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SWL", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STD_MAIN_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STD_MAIN_KDZ_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.C_STL_GRD;
            parameters[1].Value = model.C_REPLACE_GRD;
            parameters[2].Value = model.N_LEVEL;
            parameters[3].Value = model.C_REMARK;
            parameters[4].Value = model.N_STATUS;
            parameters[5].Value = model.C_EMP_ID;
            parameters[6].Value = model.D_MOD_DT;
            parameters[7].Value = model.D_START_DATE;
            parameters[8].Value = model.D_END_DATE;
            parameters[9].Value = model.C_STD_CODE;
            parameters[10].Value = model.C_REPLACE_STD_CODE;
            parameters[11].Value = model.N_SFXM;
            parameters[12].Value = model.C_SFXM;
            parameters[13].Value = model.C_SLAB_TYPE;
            parameters[14].Value = model.C_SWL;
            parameters[15].Value = model.C_STD_MAIN_ID;
            parameters[16].Value = model.C_STD_MAIN_KDZ_ID;
            parameters[17].Value = model.C_ID;

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
            strSql.Append("delete from TPB_REPLACE_GRD ");
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
            strSql.Append("delete from TPB_REPLACE_GRD ");
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
        public Mod_TPB_REPLACE_GRD GetModel(string C_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_STL_GRD,C_REPLACE_GRD,N_LEVEL,C_REMARK,N_STATUS,C_EMP_ID,D_MOD_DT,D_START_DATE,D_END_DATE,C_STD_CODE,C_REPLACE_STD_CODE,N_SFXM,C_SFXM,C_SLAB_TYPE,C_SWL,C_STD_MAIN_ID,C_STD_MAIN_KDZ_ID from TPB_REPLACE_GRD ");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)         };
            parameters[0].Value = C_ID;

            Mod_TPB_REPLACE_GRD model = new Mod_TPB_REPLACE_GRD();
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
        public Mod_TPB_REPLACE_GRD DataRowToModel(DataRow row)
        {
            Mod_TPB_REPLACE_GRD model = new Mod_TPB_REPLACE_GRD();
            if (row != null)
            {
                if (row["C_ID"] != null)
                {
                    model.C_ID = row["C_ID"].ToString();
                }
                if (row["C_STL_GRD"] != null)
                {
                    model.C_STL_GRD = row["C_STL_GRD"].ToString();
                }
                if (row["C_REPLACE_GRD"] != null)
                {
                    model.C_REPLACE_GRD = row["C_REPLACE_GRD"].ToString();
                }
                if (row["N_LEVEL"] != null && row["N_LEVEL"].ToString() != "")
                {
                    model.N_LEVEL = decimal.Parse(row["N_LEVEL"].ToString());
                }
                if (row["C_REMARK"] != null)
                {
                    model.C_REMARK = row["C_REMARK"].ToString();
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
                if (row["D_START_DATE"] != null && row["D_START_DATE"].ToString() != "")
                {
                    model.D_START_DATE = DateTime.Parse(row["D_START_DATE"].ToString());
                }
                if (row["D_END_DATE"] != null && row["D_END_DATE"].ToString() != "")
                {
                    model.D_END_DATE = DateTime.Parse(row["D_END_DATE"].ToString());
                }
                if (row["C_STD_CODE"] != null)
                {
                    model.C_STD_CODE = row["C_STD_CODE"].ToString();
                }
                if (row["C_REPLACE_STD_CODE"] != null)
                {
                    model.C_REPLACE_STD_CODE = row["C_REPLACE_STD_CODE"].ToString();
                }
                if (row["N_SFXM"] != null && row["N_SFXM"].ToString() != "")
                {
                    model.N_SFXM = decimal.Parse(row["N_SFXM"].ToString());
                }
                if (row["C_SFXM"] != null)
                {
                    model.C_SFXM = row["C_SFXM"].ToString();
                }
                if (row["C_SLAB_TYPE"] != null)
                {
                    model.C_SLAB_TYPE = row["C_SLAB_TYPE"].ToString();
                }
                if (row["C_SWL"] != null)
                {
                    model.C_SWL = row["C_SWL"].ToString();
                }
                if (row["C_STD_MAIN_ID"] != null)
                {
                    model.C_STD_MAIN_ID = row["C_STD_MAIN_ID"].ToString();
                }
                if (row["C_STD_MAIN_KDZ_ID"] != null)
                {
                    model.C_STD_MAIN_KDZ_ID = row["C_STD_MAIN_KDZ_ID"].ToString();
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
            strSql.Append("select C_ID,C_STL_GRD,C_REPLACE_GRD,N_LEVEL,C_REMARK,N_STATUS,C_EMP_ID,D_MOD_DT,D_START_DATE,D_END_DATE,C_STD_CODE,C_REPLACE_STD_CODE,N_SFXM,C_SFXM,C_SLAB_TYPE,C_SWL,C_STD_MAIN_ID,C_STD_MAIN_KDZ_ID  ");
            strSql.Append(" FROM TPB_REPLACE_GRD ");
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
            strSql.Append("select count(1) FROM TPB_REPLACE_GRD ");
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
            strSql.Append(" SELECT ROW_Int16() OVER (");
            if (!string.IsNullOrEmpty(orderby.Trim()))
            {
                strSql.Append("order by T." + orderby);
            }
            else
            {
                strSql.Append("order by T.C_ID desc");
            }
            strSql.Append(")AS Row, T.*  from TPB_REPLACE_GRD T ");
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
        public DataSet GetList(string C_STL_GRD, string C_STD_CODE)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_STL_GRD,C_REPLACE_GRD,N_LEVEL,C_REMARK,N_STATUS,C_EMP_ID,D_MOD_DT,D_START_DATE,D_END_DATE,C_STD_CODE,C_REPLACE_STD_CODE,N_SFXM,C_SFXM,C_SLAB_TYPE,C_SWL,C_STD_MAIN_ID,C_STD_MAIN_KDZ_ID  ");
            strSql.Append(" FROM TPB_REPLACE_GRD where N_STATUS=1");
            if (C_STL_GRD.Trim() != "")
            {
                strSql.Append(" and C_STL_GRD='" + C_STL_GRD + "'");
            }
            if (C_STD_CODE.Trim() != "")
            {
                strSql.Append(" and C_STD_CODE='" + C_STD_CODE + "'");
            }

            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 同步可代轧钢坯钢种表的外键
        /// </summary>
        /// <returns></returns>
        public int TbStdMainID()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("UPDATE TPB_REPLACE_GRD T SET T.C_STD_MAIN_ID = (SELECT A.C_ID  FROM TQB_STD_MAIN A  WHERE A.C_STL_GRD = T.C_STL_GRD   AND A.C_STD_CODE = T.C_STD_CODE),  T.C_STD_MAIN_KDZ_ID =   (SELECT A.C_ID   FROM TQB_STD_MAIN A    WHERE A.C_STL_GRD = T.C_REPLACE_GRD AND A.C_STD_CODE = T.C_REPLACE_STD_CODE) ");

            return DbHelperOra.ExecuteSql(strSql.ToString());

        }



        /// <summary>
        /// 查询可代轧钢坯钢种数据
        /// </summary>
        /// <param name="strGZ">钢种</param>
        /// <param name="strBZ">标准</param>
        /// <param name="strDZGZ">可代轧钢种</param>
        /// <param name="strDZBZ">可代轧标准</param>
        /// <param name="iStatus">状态</param>
        /// <param name="strID">标准表主键</param>
        public DataSet BindKDZInfo(string strGZ, string strBZ, string strDZGZ, string strDZBZ, int iStatus, string gz,string bz)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_STL_GRD,C_REPLACE_GRD,N_LEVEL,C_REMARK,N_STATUS,C_EMP_ID,D_MOD_DT,D_START_DATE,D_END_DATE,C_STD_CODE,C_REPLACE_STD_CODE,N_SFXM,C_SFXM,C_SLAB_TYPE,C_SWL,C_STD_MAIN_ID,C_STD_MAIN_KDZ_ID,C_SL  ");
            strSql.Append(" FROM TPB_REPLACE_GRD where N_STATUS=1");
            if (strGZ.Trim() != "")
            {
                strSql.Append(" and C_STL_GRD LIKE '%" + strGZ + "%'");
            }
            if (strBZ.Trim() != "")
            {
                strSql.Append(" and C_STD_CODE LIKE '%" + strBZ + "%'");
            }

            if (strDZGZ.Trim() != "")
            {
                strSql.Append(" and C_REPLACE_GRD LIKE '%" + strDZGZ + "%'");
            }
            if (strDZBZ.Trim() != "")
            {
                strSql.Append(" and C_REPLACE_STD_CODE LIKE '%" + strDZBZ + "%'");
            }

            if (iStatus.ToString().Trim() != "")
            {
                strSql.Append(" and N_STATUS=" + iStatus );
            }

            if (gz.ToString().Trim() != "")
            {
                strSql.Append(" and C_STL_GRD='" + gz + "'");
            }

            if (bz.ToString().Trim() != "")
            {
                strSql.Append(" and C_STD_CODE='" + bz + "'");
            }
            return DbHelperOra.Query(strSql.ToString());
        }


        /// <summary>
        /// 根据钢种、执行标准获取可代轧的钢坯钢种和执行标准
        /// </summary>
        /// <param name="C_STL_GRD">钢种</param>
        /// <param name="C_STD_CODE">执行标准</param>
        /// <returns></returns>
        public DataTable BindDZSlab(string C_STL_GRD,string C_STD_CODE)
        {
            string sql = "SELECT T.C_REPLACE_GRD, T.C_REPLACE_STD_CODE  FROM TPB_REPLACE_GRD T WHERE T.N_STATUS = 1   AND T.C_STL_GRD = '"+ C_STL_GRD + "'   AND T.C_STD_CODE = '"+ C_STD_CODE + "'";
            return DbHelperOra.Query(sql).Tables[0];

        }
        #endregion  ExtensionMethod
    }
}

