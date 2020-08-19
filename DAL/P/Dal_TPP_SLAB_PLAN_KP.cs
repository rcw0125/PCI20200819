using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;
namespace DAL
{
    /// <summary>
	/// 数据访问类:TPP_SLAB_PLAN_KP
	/// </summary>
	public partial class Dal_TPP_SLAB_PLAN_KP
    {
        public Dal_TPP_SLAB_PLAN_KP()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string C_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TPP_SLAB_PLAN_KP");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)         };
            parameters[0].Value = C_ID;

            return DbHelperOra.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Mod_TPP_SLAB_PLAN_KP model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TPP_SLAB_PLAN_KP(");
            strSql.Append("C_ID,C_STA_ID,C_PLAN_ID,C_STL_GRD,C_SPEC,N_LTH,C_STD_CODE,N_QTY,N_WGT,C_SPEC_KP,N_LTH_KP,D_PLAN_DT,D_PLAN_START,D_PLAN_END,N_STATUS,N_ACT_STATUS,C_EMP_ID,D_MOD_DT,C_REMARK,N_ACT_QTY)");
            strSql.Append(" values (");
            strSql.Append(":C_ID,:C_STA_ID,:C_PLAN_ID,:C_STL_GRD,:C_SPEC,:N_LTH,:C_STD_CODE,:N_QTY,:N_WGT,:C_SPEC_KP,:N_LTH_KP,:D_PLAN_DT,:D_PLAN_START,:D_PLAN_END,:N_STATUS,:N_ACT_STATUS,:C_EMP_ID,:D_MOD_DT,:C_REMARK,:N_ACT_QTY)");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STA_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PLAN_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STL_GRD", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SPEC", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_LTH", OracleDbType.Decimal,15),
                    new OracleParameter(":C_STD_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_QTY", OracleDbType.Decimal,5),
                    new OracleParameter(":N_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":C_SPEC_KP", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_LTH_KP", OracleDbType.Decimal,15),
                    new OracleParameter(":D_PLAN_DT", OracleDbType.Date),
                    new OracleParameter(":D_PLAN_START", OracleDbType.Date),
                    new OracleParameter(":D_PLAN_END", OracleDbType.Date),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
                    new OracleParameter(":N_ACT_STATUS", OracleDbType.Decimal,1),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,200),
                    new OracleParameter(":N_ACT_QTY", OracleDbType.Decimal,5)};
            parameters[0].Value = model.C_ID;
            parameters[1].Value = model.C_STA_ID;
            parameters[2].Value = model.C_PLAN_ID;
            parameters[3].Value = model.C_STL_GRD;
            parameters[4].Value = model.C_SPEC;
            parameters[5].Value = model.N_LTH;
            parameters[6].Value = model.C_STD_CODE;
            parameters[7].Value = model.N_QTY;
            parameters[8].Value = model.N_WGT;
            parameters[9].Value = model.C_SPEC_KP;
            parameters[10].Value = model.N_LTH_KP;
            parameters[11].Value = model.D_PLAN_DT;
            parameters[12].Value = model.D_PLAN_START;
            parameters[13].Value = model.D_PLAN_END;
            parameters[14].Value = model.N_STATUS;
            parameters[15].Value = model.N_ACT_STATUS;
            parameters[16].Value = model.C_EMP_ID;
            parameters[17].Value = model.D_MOD_DT;
            parameters[18].Value = model.C_REMARK;
            parameters[19].Value = model.N_ACT_QTY;

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
        public bool Update(Mod_TPP_SLAB_PLAN_KP model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TPP_SLAB_PLAN_KP set ");
            strSql.Append("C_STA_ID=:C_STA_ID,");
            strSql.Append("C_PLAN_ID=:C_PLAN_ID,");
            strSql.Append("C_STL_GRD=:C_STL_GRD,");
            strSql.Append("C_SPEC=:C_SPEC,");
            strSql.Append("N_LTH=:N_LTH,");
            strSql.Append("C_STD_CODE=:C_STD_CODE,");
            strSql.Append("N_QTY=:N_QTY,");
            strSql.Append("N_WGT=:N_WGT,");
            strSql.Append("C_SPEC_KP=:C_SPEC_KP,");
            strSql.Append("N_LTH_KP=:N_LTH_KP,");
            strSql.Append("D_PLAN_DT=:D_PLAN_DT,");
            strSql.Append("D_PLAN_START=:D_PLAN_START,");
            strSql.Append("D_PLAN_END=:D_PLAN_END,");
            strSql.Append("N_STATUS=:N_STATUS,");
            strSql.Append("N_ACT_STATUS=:N_ACT_STATUS,");
            strSql.Append("C_EMP_ID=:C_EMP_ID,");
            strSql.Append("D_MOD_DT=:D_MOD_DT,");
            strSql.Append("C_REMARK=:C_REMARK,");
            strSql.Append("N_ACT_QTY=:N_ACT_QTY");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_STA_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PLAN_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STL_GRD", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SPEC", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_LTH", OracleDbType.Decimal,15),
                    new OracleParameter(":C_STD_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_QTY", OracleDbType.Decimal,5),
                    new OracleParameter(":N_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":C_SPEC_KP", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_LTH_KP", OracleDbType.Decimal,15),
                    new OracleParameter(":D_PLAN_DT", OracleDbType.Date),
                    new OracleParameter(":D_PLAN_START", OracleDbType.Date),
                    new OracleParameter(":D_PLAN_END", OracleDbType.Date),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
                    new OracleParameter(":N_ACT_STATUS", OracleDbType.Decimal,1),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,200),
                    new OracleParameter(":N_ACT_QTY", OracleDbType.Decimal,5),
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.C_STA_ID;
            parameters[1].Value = model.C_PLAN_ID;
            parameters[2].Value = model.C_STL_GRD;
            parameters[3].Value = model.C_SPEC;
            parameters[4].Value = model.N_LTH;
            parameters[5].Value = model.C_STD_CODE;
            parameters[6].Value = model.N_QTY;
            parameters[7].Value = model.N_WGT;
            parameters[8].Value = model.C_SPEC_KP;
            parameters[9].Value = model.N_LTH_KP;
            parameters[10].Value = model.D_PLAN_DT;
            parameters[11].Value = model.D_PLAN_START;
            parameters[12].Value = model.D_PLAN_END;
            parameters[13].Value = model.N_STATUS;
            parameters[14].Value = model.N_ACT_STATUS;
            parameters[15].Value = model.C_EMP_ID;
            parameters[16].Value = model.D_MOD_DT;
            parameters[17].Value = model.C_REMARK;
            parameters[18].Value = model.N_ACT_QTY;
            parameters[19].Value = model.C_ID;

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
            strSql.Append("delete from TPP_SLAB_PLAN_KP ");
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
            strSql.Append("delete from TPP_SLAB_PLAN_KP ");
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
        public Mod_TPP_SLAB_PLAN_KP GetModel(string C_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_STA_ID,C_PLAN_ID,C_STL_GRD,C_SPEC,N_LTH,C_STD_CODE,N_QTY,N_WGT,C_SPEC_KP,N_LTH_KP,D_PLAN_DT,D_PLAN_START,D_PLAN_END,N_STATUS,N_ACT_STATUS,C_EMP_ID,D_MOD_DT,C_REMARK,N_ACT_QTY from TPP_SLAB_PLAN_KP ");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)         };
            parameters[0].Value = C_ID;

            Mod_TPP_SLAB_PLAN_KP model = new Mod_TPP_SLAB_PLAN_KP();
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
        public Mod_TPP_SLAB_PLAN_KP DataRowToModel(DataRow row)
        {
            Mod_TPP_SLAB_PLAN_KP model = new Mod_TPP_SLAB_PLAN_KP();
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
                if (row["C_PLAN_ID"] != null)
                {
                    model.C_PLAN_ID = row["C_PLAN_ID"].ToString();
                }
                if (row["C_STL_GRD"] != null)
                {
                    model.C_STL_GRD = row["C_STL_GRD"].ToString();
                }
                if (row["C_SPEC"] != null)
                {
                    model.C_SPEC = row["C_SPEC"].ToString();
                }
                if (row["N_LTH"] != null && row["N_LTH"].ToString() != "")
                {
                    model.N_LTH = decimal.Parse(row["N_LTH"].ToString());
                }
                if (row["C_STD_CODE"] != null)
                {
                    model.C_STD_CODE = row["C_STD_CODE"].ToString();
                }
                if (row["N_QTY"] != null && row["N_QTY"].ToString() != "")
                {
                    model.N_QTY = decimal.Parse(row["N_QTY"].ToString());
                }
                if (row["N_WGT"] != null && row["N_WGT"].ToString() != "")
                {
                    model.N_WGT = decimal.Parse(row["N_WGT"].ToString());
                }
                if (row["C_SPEC_KP"] != null)
                {
                    model.C_SPEC_KP = row["C_SPEC_KP"].ToString();
                }
                if (row["N_LTH_KP"] != null && row["N_LTH_KP"].ToString() != "")
                {
                    model.N_LTH_KP = decimal.Parse(row["N_LTH_KP"].ToString());
                }
                if (row["D_PLAN_DT"] != null && row["D_PLAN_DT"].ToString() != "")
                {
                    model.D_PLAN_DT = DateTime.Parse(row["D_PLAN_DT"].ToString());
                }
                if (row["D_PLAN_START"] != null && row["D_PLAN_START"].ToString() != "")
                {
                    model.D_PLAN_START = DateTime.Parse(row["D_PLAN_START"].ToString());
                }
                if (row["D_PLAN_END"] != null && row["D_PLAN_END"].ToString() != "")
                {
                    model.D_PLAN_END = DateTime.Parse(row["D_PLAN_END"].ToString());
                }
                if (row["N_STATUS"] != null && row["N_STATUS"].ToString() != "")
                {
                    model.N_STATUS = decimal.Parse(row["N_STATUS"].ToString());
                }
                if (row["N_ACT_STATUS"] != null && row["N_ACT_STATUS"].ToString() != "")
                {
                    model.N_ACT_STATUS = decimal.Parse(row["N_ACT_STATUS"].ToString());
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
                if (row["N_ACT_QTY"] != null && row["N_ACT_QTY"].ToString() != "")
                {
                    model.N_ACT_QTY = decimal.Parse(row["N_ACT_QTY"].ToString());
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
            strSql.Append("select C_ID,C_STA_ID,C_PLAN_ID,C_STL_GRD,C_SPEC,N_LTH,C_STD_CODE,N_QTY,N_WGT,C_SPEC_KP,N_LTH_KP,D_PLAN_DT,D_PLAN_START,D_PLAN_END,N_STATUS,N_ACT_STATUS,C_EMP_ID,D_MOD_DT,C_REMARK,N_ACT_QTY ");
            strSql.Append(" FROM TPP_SLAB_PLAN_KP ");
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
            strSql.Append("select count(1) FROM TPP_SLAB_PLAN_KP ");
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
            strSql.Append(")AS Row, T.*  from TPP_SLAB_PLAN_KP T ");
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

        #endregion  ExtensionMethod
    }
}
