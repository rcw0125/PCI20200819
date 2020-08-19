using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;
namespace DAL
{
    /// <summary>
    /// 数据访问类:TQB_CHARACTER
    /// </summary>
    public partial class Dal_TQB_CHARACTER
    {
        public Dal_TQB_CHARACTER()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string C_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TQB_CHARACTER");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)         };
            parameters[0].Value = C_ID;

            return DbHelperOra.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Mod_TQB_CHARACTER model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TQB_CHARACTER(");
            strSql.Append("C_TYPE_ID,C_CODE,C_NAME,C_UNIT,C_DIGIT,C_BOOK_SHOW,C_FORMULA,C_QUANTITATIVE,N_STATUS,C_REMARK,C_EMP_ID,N_ORDER)");
            strSql.Append(" values (");
            strSql.Append(":C_TYPE_ID,:C_CODE,:C_NAME,:C_UNIT,:C_DIGIT,:C_BOOK_SHOW,:C_FORMULA,:C_QUANTITATIVE,:N_STATUS,:C_REMARK,:C_EMP_ID,:N_ORDER)");
            OracleParameter[] parameters = {

                    new OracleParameter(":C_TYPE_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_UNIT", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_DIGIT", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_BOOK_SHOW", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_FORMULA", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_QUANTITATIVE", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_ORDER", OracleDbType.Decimal,3)};

            parameters[0].Value = model.C_TYPE_ID;
            parameters[1].Value = model.C_CODE;
            parameters[2].Value = model.C_NAME;
            parameters[3].Value = model.C_UNIT;
            parameters[4].Value = model.C_DIGIT;
            parameters[5].Value = model.C_BOOK_SHOW;
            parameters[6].Value = model.C_FORMULA;
            parameters[7].Value = model.C_QUANTITATIVE;
            parameters[8].Value = model.N_STATUS;
            parameters[9].Value = model.C_REMARK;
            parameters[10].Value = model.C_EMP_ID;
            parameters[11].Value = model.N_ORDER;

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
        public bool Update(Mod_TQB_CHARACTER model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TQB_CHARACTER set ");
            strSql.Append("C_TYPE_ID=:C_TYPE_ID,");
            strSql.Append("C_CODE=:C_CODE,");
            strSql.Append("C_NAME=:C_NAME,");
            strSql.Append("C_UNIT=:C_UNIT,");
            strSql.Append("C_DIGIT=:C_DIGIT,");
            strSql.Append("C_BOOK_SHOW=:C_BOOK_SHOW,");
            strSql.Append("C_FORMULA=:C_FORMULA,");
            strSql.Append("C_QUANTITATIVE=:C_QUANTITATIVE,");
            strSql.Append("N_STATUS=:N_STATUS,");
            strSql.Append("C_REMARK=:C_REMARK,");
            strSql.Append("C_EMP_ID=:C_EMP_ID,");
            strSql.Append("D_MOD_DT=:D_MOD_DT,");
            strSql.Append("N_ORDER=:N_ORDER");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_TYPE_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_UNIT", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_DIGIT", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_BOOK_SHOW", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_FORMULA", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_QUANTITATIVE", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":N_ORDER", OracleDbType.Decimal,3),
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.C_TYPE_ID;
            parameters[1].Value = model.C_CODE;
            parameters[2].Value = model.C_NAME;
            parameters[3].Value = model.C_UNIT;
            parameters[4].Value = model.C_DIGIT;
            parameters[5].Value = model.C_BOOK_SHOW;
            parameters[6].Value = model.C_FORMULA;
            parameters[7].Value = model.C_QUANTITATIVE;
            parameters[8].Value = model.N_STATUS;
            parameters[9].Value = model.C_REMARK;
            parameters[10].Value = model.C_EMP_ID;
            parameters[11].Value = model.D_MOD_DT;
            parameters[12].Value = model.N_ORDER;
            parameters[13].Value = model.C_ID;
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
            strSql.Append("delete from TQB_CHARACTER ");
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
            strSql.Append("delete from TQB_CHARACTER ");
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
        public Mod_TQB_CHARACTER GetModel(string C_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_TYPE_ID,C_CODE,C_NAME,C_UNIT,C_DIGIT,C_BOOK_SHOW,C_FORMULA,C_QUANTITATIVE,N_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT,N_ORDER from TQB_CHARACTER ");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)         };
            parameters[0].Value = C_ID;

            Mod_TQB_CHARACTER model = new Mod_TQB_CHARACTER();
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
        public Mod_TQB_CHARACTER DataRowToModel(DataRow row)
        {
            Mod_TQB_CHARACTER model = new Mod_TQB_CHARACTER();
            if (row != null)
            {
                if (row["C_ID"] != null)
                {
                    model.C_ID = row["C_ID"].ToString();
                }
                if (row["C_TYPE_ID"] != null)
                {
                    model.C_TYPE_ID = row["C_TYPE_ID"].ToString();
                }
                if (row["C_CODE"] != null)
                {
                    model.C_CODE = row["C_CODE"].ToString();
                }
                if (row["C_NAME"] != null)
                {
                    model.C_NAME = row["C_NAME"].ToString();
                }
                if (row["C_UNIT"] != null)
                {
                    model.C_UNIT = row["C_UNIT"].ToString();
                }
                if (row["C_DIGIT"] != null)
                {
                    model.C_DIGIT = row["C_DIGIT"].ToString();
                }
                if (row["C_BOOK_SHOW"] != null)
                {
                    model.C_BOOK_SHOW = row["C_BOOK_SHOW"].ToString();
                }
                if (row["C_FORMULA"] != null)
                {
                    model.C_FORMULA = row["C_FORMULA"].ToString();
                }
                if (row["C_QUANTITATIVE"] != null)
                {
                    model.C_QUANTITATIVE = row["C_QUANTITATIVE"].ToString();
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
                if (row["N_ORDER"] != null && row["N_ORDER"].ToString() != "")
                {
                    model.N_ORDER = decimal.Parse(row["N_ORDER"].ToString());
                }
            }
            return model;
        }
        /// <summary>
		/// 获得数据列表_成分
		/// </summary>
		public DataSet GetList_JCSJ_CF(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  a.C_ID,a.C_TYPE_ID,a.C_CODE,a.C_NAME,a.C_UNIT,a.C_DIGIT,a.C_BOOK_SHOW,a.C_FORMULA,a.C_QUANTITATIVE,a.N_STATUS,a.C_REMARK,a.C_EMP_ID,a.D_MOD_DT,b.c_type_name ");
            strSql.Append(" FROM TQB_CHARACTER a inner join tqb_checktype  b on a.c_type_id=b.c_id where a.N_STATUS='1' and b.c_type_name='成分'");
            if (!string.IsNullOrEmpty(strWhere))
            {
                strSql.Append(" and a.C_NAME like '%" + strWhere + "%'");
            }
            strSql.Append(" order by a.c_code");
            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
		/// 获得数据列表_性能
		/// </summary>
		public DataSet GetList_JCSJ_XN(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  a.C_ID,a.C_TYPE_ID,a.C_CODE,a.C_NAME,a.C_UNIT,a.C_DIGIT,a.C_BOOK_SHOW,a.C_FORMULA,a.C_QUANTITATIVE,a.N_STATUS,a.C_REMARK,a.C_EMP_ID,a.D_MOD_DT,b.c_type_name ");
            strSql.Append(" FROM TQB_CHARACTER a inner join tqb_checktype  b on a.c_type_id=b.c_id where a.N_STATUS='1' and b.c_type_name='性能'");
            if (!string.IsNullOrEmpty(strWhere))
            {
                strSql.Append(" and a.C_NAME like '%" + strWhere + "%'");
            }
            strSql.Append(" order by a.c_code");
            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 获得数据列表_性能
        /// </summary>
        public DataSet GetList_JCSJ(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  a.C_ID,a.C_TYPE_ID,a.C_CODE,a.C_NAME,a.C_UNIT,a.C_DIGIT,a.C_BOOK_SHOW,a.C_FORMULA,a.C_QUANTITATIVE,a.N_STATUS,a.C_REMARK,a.C_EMP_ID,a.D_MOD_DT,b.c_type_name ");
            strSql.Append(" FROM TQB_CHARACTER a inner join tqb_checktype  b on a.c_type_id=b.c_id where a.N_STATUS='1' ");
            if (!string.IsNullOrEmpty(strWhere))
            {
                strSql.Append(" and a.C_NAME like '%" + strWhere + "%'");
            }
            strSql.Append(" order by a.c_code");
            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 查询基础数据名称
        /// </summary>
        public DataSet GetList_Name(string strWhere, string type)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select a.C_ID,a.C_CODE,a.C_NAME,a.N_STATUS,b.c_type_name ");
            strSql.Append(" FROM TQB_CHARACTER a inner join tqb_checktype  b on a.c_type_id=b.c_id  where  a.N_STATUS='1'  ");
            if (!string.IsNullOrEmpty(strWhere) && !string.IsNullOrEmpty(type))
            {
                strSql.Append(" and b.c_type_name='" + type + "'  and C_NAME='" + strWhere + "'");
            }

            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 查询基础数据名称
        /// </summary>
        public DataSet GetList_CODE(string type, string code)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select a.C_ID,a.C_CODE,a.C_NAME,a.N_STATUS,b.c_type_name ");
            strSql.Append(" FROM TQB_CHARACTER a inner join tqb_checktype  b on a.c_type_id=b.c_id  where  a.N_STATUS='1'  ");
            if (!string.IsNullOrEmpty(code) && !string.IsNullOrEmpty(type))
            {
                strSql.Append(" and b.c_type_name='" + type + "'  and a.C_CODE='" + code + "'");
            }
            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 查询基础数据名称
        /// </summary>
        public DataSet GetList_not_Name(string strWhere, string Name, string type)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select a.C_ID,a.C_CODE,a.C_NAME,a.N_STATUS,b.c_type_name ");
            strSql.Append("  FROM TQB_CHARACTER a inner join tqb_checktype  b on a.c_type_id=b.c_id  where  a.N_STATUS='1'     ");
            if (!string.IsNullOrEmpty(strWhere) && !string.IsNullOrEmpty(type) && !string.IsNullOrEmpty(Name))
            {
                strSql.Append(" and a.C_TYPE_ID='" + type + "' and C_NAME not in ('" + Name + "') and C_NAME='" + strWhere + "'");
            }
            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 根据类别获取项目代码和名称
        /// </summary>
        /// <param name="strLB">类别：成分/性能</param>
        /// <returns></returns>
        public DataSet GetItemByLB(string strLB)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT T.C_CODE, T.C_NAME, B.C_TYPE_NAME FROM TQB_CHARACTER T, TQB_CHECKTYPE B WHERE T.C_TYPE_ID = B.C_ID ");

            if (!string.IsNullOrEmpty(strLB))
            {
                strSql.Append("  AND B.C_TYPE_NAME = '" + strLB + "'");
            }
            strSql.Append("  ORDER BY T.C_CODE ");
            return DbHelperOra.Query(strSql.ToString());
        }


        /// <summary>
        /// 根据项目ID
        /// </summary>
        /// <param name="c_name">成分/性能 名称</param>
        /// <returns></returns>
        public string GetItemID(string c_name)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT Max(C_ID) FROM TQB_CHARACTER ");

            if (!string.IsNullOrEmpty(c_name))
            {
                strSql.Append("  where upper(C_NAME) = upper('" + c_name + "' ) ");
            }

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
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere, string c_type_id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  a.C_ID,a.C_TYPE_ID,a.C_CODE,a.C_NAME,a.C_UNIT,a.C_DIGIT,a.C_BOOK_SHOW,a.C_FORMULA,a.C_QUANTITATIVE,a.N_STATUS,a.C_REMARK,a.C_EMP_ID,a.D_MOD_DT,b.c_type_name,a.N_ORDER ");
            strSql.Append(" FROM TQB_CHARACTER a inner join tqb_checktype  b on a.c_type_id=b.c_id  where a.N_STATUS='1' ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" and a.C_NAME like '%" + strWhere + "%' ");
            }
            if (c_type_id.Trim() != "全部")
            {
                strSql.Append(" and a.c_type_id = '" + c_type_id + "'");
            }
            strSql.Append(" order by a.N_ORDER");
            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList_TYPE_ID(string C_TYPE_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID, C_NAME ,C_TYPE_ID ");
            strSql.Append(" FROM TQB_CHARACTER  ");
            if (C_TYPE_ID.Trim() != "")
            {
                strSql.Append(" and  C_TYPE_ID like '%" + C_TYPE_ID + "%' ");
            }
            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetTypeAndCharacter(string C_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  a.C_ID,a.C_NAME,b.C_ID as TypeID,b.C_TYPE_NAME ");
            strSql.Append(" FROM TQB_CHARACTER a inner join tqb_checktype  b on a.c_type_id=b.c_id ");
            strSql.Append(" where a.C_ID='" + C_ID + "'");

            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetCharacterNameList(string C_TYPE_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  a.C_NAME,a.C_ID ");
            strSql.Append(" FROM TQB_CHARACTER a where a.N_STATUS=1 and a.C_TYPE_ID='" + C_TYPE_ID + "' ");

            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetCharacterList(string C_CODE, string C_NAME)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  t.C_ID,t.C_TYPE_ID,t.C_CODE,t.C_NAME,t.C_UNIT, t.C_DIGIT,t.C_BOOK_SHOW,t.C_FORMULA,t.C_QUANTITATIVE,t.N_STATUS,t.C_REMARK,t.C_EMP_ID,t.D_MOD_DT");
            strSql.Append("  FROM TQB_CHARACTER t join  TQB_CHECKTYPE a on t.c_type_id=a.c_id where  a.c_type_name='性能' and t.N_STATUS='1' ");
            if (C_CODE.Trim() != "")
            {
                strSql.Append(" and t.C_CODE not in (" + C_CODE + ")");
            }
            if (C_NAME.Trim() != "")
            {
                strSql.Append(" and t.C_NAME like '%" + C_NAME + "%' ");
            }
            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM TQB_CHARACTER ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where C_TYPE_ID = '" + strWhere + "'");
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
            strSql.Append(")AS Row, T.*  from TQB_CHARACTER T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
		/// 获得数据列表_成分
		/// </summary>
		public DataSet GetList_CF(string C_NAME)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  a.C_ID,a.C_TYPE_ID,a.C_CODE,a.C_NAME,a.C_UNIT,a.C_DIGIT,a.C_BOOK_SHOW,a.C_FORMULA,a.C_QUANTITATIVE,a.N_STATUS,a.C_REMARK,a.C_EMP_ID,a.D_MOD_DT,b.c_type_name ");
            strSql.Append(" FROM TQB_CHARACTER a inner join tqb_checktype  b on a.c_type_id=b.c_id where a.N_STATUS='1' and b.c_type_name='成分'");
            if (!string.IsNullOrEmpty(C_NAME))
            {
                strSql.Append(" and upper(a.C_NAME) like upper('%" + C_NAME + "%') ");
            }
            strSql.Append(" order by a.c_code");
            return DbHelperOra.Query(strSql.ToString());
        }

        #endregion  BasicMethod
        #region  ExtensionMethod

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList_Max()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select MAX(C_CODE) max,max(n_order) as max_order ");
            strSql.Append(" FROM TQB_CHARACTER  ");
            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Mod_TQB_CHARACTER GetModel_ByCode(string C_CODE)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_TYPE_ID,C_CODE,C_NAME,C_UNIT,C_DIGIT,C_BOOK_SHOW,C_FORMULA,C_QUANTITATIVE,N_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT,N_ORDER from TQB_CHARACTER ");
            strSql.Append(" where C_CODE=:C_CODE ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_CODE", OracleDbType.Varchar2,100)         };
            parameters[0].Value = C_CODE;

            Mod_TQB_CHARACTER model = new Mod_TQB_CHARACTER();
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


        #endregion  ExtensionMethod
    }
}

