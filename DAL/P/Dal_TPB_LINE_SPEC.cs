using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;
namespace DAL
{
    /// <summary>
    /// 数据访问类:TPB_LINE_SPEC
    /// </summary>
    public partial class Dal_TPB_LINE_SPEC
    {
        public Dal_TPB_LINE_SPEC()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string C_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TPB_LINE_SPEC");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)         };
            parameters[0].Value = C_ID;

            return DbHelperOra.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Mod_TPB_LINE_SPEC model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TPB_LINE_SPEC(");
            strSql.Append("C_STA_ID,C_PROD_CLASS,C_STL_GRD,C_SPEC,C_STD_CODE,N_LEVEL,C_REMARK,N_STATUS,C_EMP_ID,D_MOD_DT,D_START_DATE,D_END_DATE,C_PROD_NAME,C_PROD_KIND,C_STD_MIAN_ID,C_STA_CODE,C_STA_DESC,C_LEVEL)");
            strSql.Append(" values (");
            strSql.Append(":C_STA_ID,:C_PROD_CLASS,:C_STL_GRD,:C_SPEC,:C_STD_CODE,:N_LEVEL,:C_REMARK,:N_STATUS,:C_EMP_ID,:D_MOD_DT,:D_START_DATE,:D_END_DATE,:C_PROD_NAME,:C_PROD_KIND,:C_STD_MIAN_ID,:C_STA_CODE,:C_STA_DESC,:C_LEVEL)");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_STA_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PROD_CLASS", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STL_GRD", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SPEC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STD_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_LEVEL", OracleDbType.Decimal,3),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,200),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":D_START_DATE", OracleDbType.Date),
                    new OracleParameter(":D_END_DATE", OracleDbType.Date),
                    new OracleParameter(":C_PROD_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PROD_KIND", OracleDbType.Varchar2,100),

                    new OracleParameter(":C_STD_MIAN_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STA_CODE", OracleDbType.Varchar2,100),
                     new OracleParameter(":C_STA_DESC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_LEVEL", OracleDbType.Varchar2,100)
};
            parameters[0].Value = model.C_STA_ID;
            parameters[1].Value = model.C_PROD_CLASS;
            parameters[2].Value = model.C_STL_GRD;
            parameters[3].Value = model.C_SPEC;
            parameters[4].Value = model.C_STD_CODE;
            parameters[5].Value = model.N_LEVEL;
            parameters[6].Value = model.C_REMARK;
            parameters[7].Value = model.N_STATUS;
            parameters[8].Value = model.C_EMP_ID;
            parameters[9].Value = model.D_MOD_DT;
            parameters[10].Value = model.D_START_DATE;
            parameters[11].Value = model.D_END_DATE;
            parameters[12].Value = model.C_PROD_NAME;
            parameters[13].Value = model.C_PROD_KIND;

            parameters[14].Value = model.C_STD_MIAN_ID;
            parameters[15].Value = model.C_STA_CODE;
            parameters[16].Value = model.C_STA_DESC;
            parameters[17].Value = model.C_LEVEL;



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
        public bool Update(Mod_TPB_LINE_SPEC model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TPB_LINE_SPEC set ");
            strSql.Append("C_STA_ID=:C_STA_ID,");
            strSql.Append("C_PROD_CLASS=:C_PROD_CLASS,");
            strSql.Append("C_STL_GRD=:C_STL_GRD,");
            strSql.Append("C_SPEC=:C_SPEC,");
            strSql.Append("C_STD_CODE=:C_STD_CODE,");
            strSql.Append("N_LEVEL=:N_LEVEL,");
            strSql.Append("C_REMARK=:C_REMARK,");
            strSql.Append("N_STATUS=:N_STATUS,");
            strSql.Append("C_EMP_ID=:C_EMP_ID,");
            strSql.Append("D_MOD_DT=:D_MOD_DT,");
            strSql.Append("D_START_DATE=:D_START_DATE,");
            strSql.Append("D_END_DATE=:D_END_DATE,");
            strSql.Append("C_PROD_NAME=:C_PROD_NAME,");
            strSql.Append("C_PROD_KIND=:C_PROD_KIND,");
            strSql.Append("C_STD_MIAN_ID=:C_STD_MIAN_ID,");
            strSql.Append("C_STA_CODE=:C_STA_CODE,");
            strSql.Append("C_STA_DESC=:C_STA_DESC,");
            strSql.Append("C_LEVEL=:C_LEVEL");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_STA_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PROD_CLASS", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STL_GRD", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SPEC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STD_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_LEVEL", OracleDbType.Decimal,3),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,200),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":D_START_DATE", OracleDbType.Date),
                    new OracleParameter(":D_END_DATE", OracleDbType.Date),
                    new OracleParameter(":C_PROD_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PROD_KIND", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STD_MIAN_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STA_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STA_DESC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_LEVEL", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.C_STA_ID;
            parameters[1].Value = model.C_PROD_CLASS;
            parameters[2].Value = model.C_STL_GRD;
            parameters[3].Value = model.C_SPEC;
            parameters[4].Value = model.C_STD_CODE;
            parameters[5].Value = model.N_LEVEL;
            parameters[6].Value = model.C_REMARK;
            parameters[7].Value = model.N_STATUS;
            parameters[8].Value = model.C_EMP_ID;
            parameters[9].Value = model.D_MOD_DT;
            parameters[10].Value = model.D_START_DATE;
            parameters[11].Value = model.D_END_DATE;
            parameters[12].Value = model.C_PROD_NAME;
            parameters[13].Value = model.C_PROD_KIND;
            parameters[14].Value = model.C_STD_MIAN_ID;
            parameters[15].Value = model.C_STA_CODE;
            parameters[16].Value = model.C_STA_DESC;
            parameters[17].Value = model.C_LEVEL;
            parameters[18].Value = model.C_ID;

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
            strSql.Append("delete from TPB_LINE_SPEC ");
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
            strSql.Append("delete from TPB_LINE_SPEC ");
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
		public Mod_TPB_LINE_SPEC GetModel(string C_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_STA_ID,C_PROD_CLASS,C_STL_GRD,C_SPEC,C_STD_CODE,N_LEVEL,C_REMARK,N_STATUS,C_EMP_ID,D_MOD_DT,D_START_DATE,D_END_DATE,C_PROD_NAME,C_PROD_KIND,C_STD_MIAN_ID,C_STA_CODE,C_STA_DESC,C_LEVEL from TPB_LINE_SPEC ");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)         };
            parameters[0].Value = C_ID;

            Mod_TPB_LINE_SPEC model = new Mod_TPB_LINE_SPEC();
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
        public Mod_TPB_LINE_SPEC DataRowToModel(DataRow row)
        {
            Mod_TPB_LINE_SPEC model = new Mod_TPB_LINE_SPEC();
            if (row != null)
            {
                if (row["C_ID"] != null)
                {
                    model.C_ID = row["C_ID"].ToString();
                }
                if (row["C_STA_ID"] != null)
                {
                    model.C_STA_ID = row["C_STA_ID"].ToString();
                }
                if (row["C_PROD_CLASS"] != null)
                {
                    model.C_PROD_CLASS = row["C_PROD_CLASS"].ToString();
                }
                if (row["C_STL_GRD"] != null)
                {
                    model.C_STL_GRD = row["C_STL_GRD"].ToString();
                }
                if (row["C_SPEC"] != null)
                {
                    model.C_SPEC = row["C_SPEC"].ToString();
                }
                if (row["C_STD_CODE"] != null)
                {
                    model.C_STD_CODE = row["C_STD_CODE"].ToString();
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
                if (row["C_PROD_NAME"] != null)
                {
                    model.C_PROD_NAME = row["C_PROD_NAME"].ToString();
                }
                if (row["C_PROD_KIND"] != null)
                {
                    model.C_PROD_KIND = row["C_PROD_KIND"].ToString();
                }
                if (row["C_STD_MIAN_ID"] != null)
                {
                    model.C_STD_MIAN_ID = row["C_STD_MIAN_ID"].ToString();
                }
                if (row["C_STA_CODE"] != null)
                {
                    model.C_STA_CODE = row["C_STA_CODE"].ToString();
                }
                if (row["C_STA_DESC"] != null)
                {
                    model.C_STA_DESC = row["C_STA_DESC"].ToString();
                }
                if (row["C_LEVEL"] != null)
                {
                    model.C_LEVEL = row["C_LEVEL"].ToString();
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
            strSql.Append("select C_ID,C_STA_ID,C_PROD_CLASS,C_STL_GRD,C_SPEC,C_STD_CODE,N_LEVEL,C_REMARK,N_STATUS,C_EMP_ID,D_MOD_DT,D_START_DATE,D_END_DATE,C_PROD_NAME,C_PROD_KIND,C_STD_MIAN_ID,C_STA_CODE,C_STA_DESC,C_LEVEL  ");
            strSql.Append(" FROM TPB_LINE_SPEC ");
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
            strSql.Append("select count(1) FROM TPB_LINE_SPEC ");
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
            strSql.Append(")AS Row, T.*  from TPB_LINE_SPEC T ");
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
        /// 根据规格获得产线
        /// </summary>
        public DataSet GetListBySTD(string grd, string std, string spec)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  C_ID");
            strSql.Append(" FROM TB_STA where N_STATUS=1 ");
            strSql.Append(" and C_PRO_ID in (select C_ID from TB_PRO where N_STATUS=1 and C_PRO_CODE='ZX')");
            strSql.Append(" and C_ID not in (select C_STA_ID from TPB_LINE_SPEC where N_STATUS=1 and c_stl_grd = '" + grd + "' and c_std_code = '" + std + "' and c_SPEC ='" + spec + "')");
            return DbHelperOra.Query(strSql.ToString());
        }


        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string grd, string std, string spec)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM TPB_LINE_SPEC where N_STATUS=1 ");
            strSql.Append(" and c_stl_grd = '" + grd + "' and c_std_code = '" + std + "' and c_SPEC = '" + spec + "'");
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
        /// 查询
        /// </summary>
        public DataSet GetList(string C_STL_GRD, string C_STD_CODE, string C_SPEC)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_STA_ID,C_PROD_CLASS,C_STL_GRD,C_SPEC,C_STD_CODE,N_LEVEL,C_REMARK,DECODE(N_STATUS,1,'启用','停用') N_STATUS,C_EMP_ID,D_MOD_DT,D_START_DATE,D_END_DATE,C_PROD_NAME,C_PROD_KIND,C_STD_MIAN_ID,C_STA_CODE,C_STA_DESC,C_LEVEL  ");
            strSql.Append(" FROM TPB_LINE_SPEC where N_STATUS=1 ");
            if (C_STL_GRD.Trim() != "")
            {
                strSql.Append("and C_STL_GRD='" + C_STL_GRD + "' ");
            }
            if (C_STD_CODE.Trim() != "")
            {
                strSql.Append("and C_STD_CODE='" + C_STD_CODE + "' ");
            }
            if (C_SPEC.Trim() != "")
            {
                strSql.Append("and C_SPEC='" + C_SPEC + "' ");
            }

            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 查询
        /// </summary>
        public DataSet GetSPECList(string C_STA_ID, string C_B_SPEC, string C_L_SPEC, string type)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select DISTINCT C_SPEC ,'' as N_TIME");
            strSql.Append(" FROM TPB_LINE_SPEC where N_STATUS=1 ");
            if (C_STA_ID.Trim() != "")
            {
                strSql.Append("and C_STA_ID='" + C_STA_ID + "' ");
            }
            if (C_B_SPEC.Trim() != "")
            {
                strSql.Append("and C_SPEC not in('" + C_B_SPEC + "') ");

            }
            if (C_L_SPEC.Trim() != "")
            {
                strSql.Append("and C_SPEC not in(select C_L_SPEC from TPB_CHANGESPEC_TIME where N_STATUS=1 AND C_STA_ID='" + C_STA_ID + "' AND C_B_SPEC ='" + C_B_SPEC + "'  )");
            }
            if (type.Trim() != "")
            {
                strSql.Append(" ORDER BY to_number(replace(C_SPEC, 'φ', ''))");
            }

            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 查询工位下规格
        /// </summary>
        /// <param name="C_STA_ID">工位</param>
        /// <param name="C_B_SPEC">已存在规格</param>
        /// <returns></returns>
        public DataSet GetSPECList(string C_STA_ID, string C_B_SPEC)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select DISTINCT C_SPEC ,'' as N_TIME");
            strSql.Append(" FROM TPB_LINE_SPEC where N_STATUS=1 ");
            if (C_STA_ID.Trim() != "")
            {
                strSql.Append("and C_STA_ID='" + C_STA_ID + "' ");
            }
            if (C_B_SPEC.Trim() != "")
            {
                strSql.Append("and to_number(replace(C_SPEC, 'φ', '')) >to_number(replace('" + C_B_SPEC + "', 'φ', '')) ");

            }
            strSql.Append(" ORDER BY to_number(replace(C_SPEC, 'φ', ''))");
            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 加载产线规格数据
        /// </summary>
        /// <param name="N_STATUS">状态</param>
        /// <param name="C_STA_ID">工位</param>
        public DataSet GetSpecListBySTA(int N_STATUS, string C_STA_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT T.C_ID,  T.C_STA_ID, T.C_SPEC,  T.C_REMARK,  T.N_STATUS,  T.C_EMP_ID,  T.D_MOD_DT,  T.D_START_DATE,  T.D_END_DATE,  T.C_STD_MIAN_ID FROM TPB_LINE_SPEC T WHERE T.N_STATUS='" + N_STATUS + "'  ");
            if (C_STA_ID.Trim() != "")
            {
                strSql.Append(" AND T.C_STA_ID= '" + C_STA_ID + "' ");
            }
            strSql.Append(" ORDER BY T.C_STA_ID,TO_NUMBER(REPLACE(T.C_SPEC,'φ','')) ");
            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 加载产线规格数据
        /// </summary>
        /// <param name="strGZ">钢种</param>
        /// <param name="strBZ">标准</param>
        /// <param name="strCX">产线</param>
        /// <param name="strLB">类型（轧线/开坯线）</param>
        /// <param name="strBZID">标准主键</param>
        public DataSet BindLineSpec(int status, string strGZ, string strBZ, string strCX, string strLB, string strBZID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT T.C_ID,  T.C_STA_ID,  T.C_PROD_CLASS,  T.C_STL_GRD,  T.C_SPEC,  T.C_STD_CODE,  T.N_LEVEL,  T.C_REMARK,  T.N_STATUS,  T.C_EMP_ID,  T.D_MOD_DT,  T.D_START_DATE,  T.D_END_DATE,  T.C_PROD_NAME,  T.C_PROD_KIND,  T.C_STD_MIAN_ID,  T.C_STA_CODE,  T.C_STA_DESC,  T.C_LEVEL FROM TPB_LINE_SPEC T WHERE T.N_STATUS='" + status + "'  ");
            if (strGZ.Trim() != "")
            {
                strSql.Append(" AND NVL(T.C_STL_GRD, ' ') LIKE '%" + strGZ + "%' ");
            }

            if (strBZ.Trim() != "")
            {
                strSql.Append(" AND NVL(T.C_STD_CODE, ' ') LIKE '%" + strBZ + "%' ");
            }
            if (strCX.Trim() != "")
            {
                strSql.Append(" AND T.C_STA_ID= '" + strCX + "' ");
            }
            if (strLB.Trim() != "")
            {
                strSql.Append(" AND T.C_PROD_CLASS= '" + strLB + "' ");
            }
            if (strBZID.Trim() != "")
            {
                strSql.Append(" AND T.C_STD_MIAN_ID= '" + strBZID + "' ");
            }
            strSql.Append(" ORDER BY T.C_STL_GRD,TO_NUMBER(REPLACE(T.C_SPEC,'φ','')) ");
            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string C_STL_GRD, string C_STD_CODE, string C_STA_ID, string C_PROD_CLASS, string C_STD_MIAN_ID, string C_SPEC)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TPB_LINE_SPEC");
            strSql.Append(" where N_STATUS=1 ");
            strSql.Append("AND C_STL_GRD=:C_STL_GRD ");
            strSql.Append("AND C_STD_CODE=:C_STD_CODE ");
            strSql.Append("AND C_STA_ID=:C_STA_ID ");
            strSql.Append("AND C_PROD_CLASS=:C_PROD_CLASS ");
            strSql.Append("AND C_STD_MIAN_ID=:C_STD_MIAN_ID ");
            strSql.Append("AND C_SPEC=:C_SPEC ");
            OracleParameter[] parameters = {
                     new OracleParameter(":C_STL_GRD", OracleDbType.Varchar2,100),
                      new OracleParameter(":C_STD_CODE",
OracleDbType.Varchar2,100),
                      new OracleParameter(":C_STA_ID",
OracleDbType.Varchar2,100),
                      new OracleParameter(":C_PROD_CLASS",
OracleDbType.Varchar2,100),
                      new OracleParameter(":C_STD_MIAN_ID",
OracleDbType.Varchar2,100),
                      new OracleParameter(":C_SPEC",
OracleDbType.Varchar2,100)
            };
            parameters[0].Value = C_STL_GRD;
            parameters[1].Value = C_STD_CODE;
            parameters[2].Value = C_STA_ID;
            parameters[3].Value = C_PROD_CLASS;
            parameters[4].Value = C_STD_MIAN_ID;
            parameters[5].Value = C_SPEC;
            return DbHelperOra.Exists(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 自动获取轧钢产线信息
        /// </summary>
        /// <param name="strSpec">规格</param>
        /// <param name="strIniID">方案主键</param>
        /// <param name="strGZ">钢种</param>
        /// <param name="strBZ">执行标准</param>
        /// <returns>产线信息表（单条数据 C_STA_ID /C_STA_CODE/C_STA_DESC）</returns>
        public DataTable GetLineByWhere(string strSpec, string strIniID, string strGZ, string strBZ)
        {

            string sql = "SELECT T.C_STA_ID, T.C_SPEC, B.C_STA_CODE, B.C_STA_DESC, B.N_SORT ,NVL((SELECT C.N_CAPACITY FROM TPB_STATION_CAPACITY C WHERE C.C_STA_ID = t.c_sta_id AND C.C_STL_GRD ='" + strGZ + "'  AND C.C_SPEC = T.C_SPEC AND ROWNUM=1 ),0) N_CAPACITY FROM TPB_LINE_SPEC T, TB_STA B WHERE    T.N_STATUS = 1 AND B.C_ID = T.C_STA_ID ";
            sql = sql + "   AND T.C_SPEC = '" + strSpec + "'";
            sql = sql + "   AND T.C_STA_ID IN ";
            sql = sql + "   (SELECT C.C_STA_ID FROM TPP_INITIALIZE_STA C WHERE C.C_INITIALIZE_ITEM_ID = '" + strIniID + "')";
            sql = sql + "   AND T.C_STA_ID NOT IN(SELECT A.C_STA_ID ";
            sql = sql + "   FROM TPB_N_GRD A ";
            sql = sql + "   WHERE A.C_STL_GRD = '" + strGZ + "'";
            sql = sql + "   AND A.C_STD_CODE = '" + strBZ + "') AND ROWNUM = 1 ORDER BY B.N_SORT";
            return DbHelperOra.Query(sql).Tables[0];


        }


        /// <summary>
        /// 获取订单钢种生产产线信息
        /// </summary>
        /// <param name="strGZ">钢种</param>
        /// <param name="ZXBZ">执行标准</param>
        /// <param name="strSpec">规格</param>
        /// <param name="strCX">产线</param>
        /// <returns>生产信息</returns>
        public DataTable GetSteelLine(string strGZ, string ZXBZ, string strSpec, string strCX)
        {

            string sql = "SELECT T.C_STA_ID, TA.C_STA_CODE, TA.C_STA_DESC, T.C_STL_GRD,  T.C_SPEC, T.N_CAPACITY, T.C_STD_CODE FROM TPB_STATION_CAPACITY T, TB_STA TA WHERE T.C_STA_ID = TA.C_ID  AND T.N_STATUS = 1  AND TA.N_STATUS = 1 ";
            sql = sql + "  AND T.C_STL_GRD = '" + strGZ + "'";
            sql = sql + "   AND T.C_SPEC = '" + strSpec + "'";
            if (strCX.Trim() != "")
            {
                sql = sql + "    AND TA.C_STA_DESC = '" + strCX + "'";
            }
            sql = sql + "   AND T.C_STA_ID IN  (SELECT C.C_STA_ID   FROM TPP_INITIALIZE_STA C )";
            sql = sql + "   AND T.C_STA_ID NOT IN(SELECT A.C_STA_ID  FROM TPB_N_GRD A  WHERE A.C_STL_GRD = T.C_STL_GRD  AND A.C_STA_ID = T.C_STA_ID AND A.N_STATUS = 1";
            sql = sql + "    AND A.C_STD_CODE = '" + ZXBZ + "') ";
            return DbHelperOra.Query(sql).Tables[0];


        }

        #endregion  ExtensionMethod
    }
}

