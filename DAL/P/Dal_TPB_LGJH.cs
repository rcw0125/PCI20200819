using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;
namespace DAL
{
    /// <summary>
    /// 数据访问类:TPB_LGJH
    /// </summary>
    public partial class Dal_TPB_LGJH
    {
        public Dal_TPB_LGJH()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string C_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TPB_LGJH");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)         };
            parameters[0].Value = C_ID;

            return DbHelperOra.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Mod_TPB_LGJH model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TPB_LGJH(");
            strSql.Append("N_STATUS,C_EMP_ID,D_MOD_DT,C_REMARK,C_STD_CODE,C_STL_GRD,C_ZYX1,C_ZYX2,C_STEEL_SIGN,C_GRADE_GROUP_CODE,C_FLRST_FLAG,C_USE_FLAG,C_STEELGRADE_TYPE,C_NAME)");
            strSql.Append(" values (");
            strSql.Append(":N_STATUS,:C_EMP_ID,:D_MOD_DT,:C_REMARK,:C_STD_CODE,:C_STL_GRD,:C_ZYX1,:C_ZYX2,:C_STEEL_SIGN,:C_GRADE_GROUP_CODE,:C_FLRST_FLAG,:C_USE_FLAG,:C_STEELGRADE_TYPE,:C_NAME)");
            OracleParameter[] parameters = {

                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_STD_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STL_GRD", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ZYX1", OracleDbType.Varchar2,300),
                    new OracleParameter(":C_ZYX2", OracleDbType.Varchar2,300),
                    new OracleParameter(":C_STEEL_SIGN", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_GRADE_GROUP_CODE", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_FLRST_FLAG", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_USE_FLAG", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_STEELGRADE_TYPE", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_NAME", OracleDbType.Varchar2,100)};

            parameters[0].Value = model.N_STATUS;
            parameters[1].Value = model.C_EMP_ID;
            parameters[2].Value = model.D_MOD_DT;
            parameters[3].Value = model.C_REMARK;
            parameters[4].Value = model.C_STD_CODE;
            parameters[5].Value = model.C_STL_GRD;
            parameters[6].Value = model.C_ZYX1;
            parameters[7].Value = model.C_ZYX2;
            parameters[8].Value = model.C_STEEL_SIGN;
            parameters[9].Value = model.C_GRADE_GROUP_CODE;
            parameters[10].Value = model.C_FLRST_FLAG;
            parameters[11].Value = model.C_USE_FLAG;
            parameters[12].Value = model.C_STEELGRADE_TYPE;
            parameters[13].Value = model.C_NAME;

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
        public bool Update(Mod_TPB_LGJH model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TPB_LGJH set ");
            strSql.Append("N_STATUS=:N_STATUS,");
            strSql.Append("C_EMP_ID=:C_EMP_ID,");
            strSql.Append("D_MOD_DT=:D_MOD_DT,");
            strSql.Append("C_REMARK=:C_REMARK,");
            strSql.Append("C_STD_CODE=:C_STD_CODE,");
            strSql.Append("C_STL_GRD=:C_STL_GRD,");
            strSql.Append("C_ZYX1=:C_ZYX1,");
            strSql.Append("C_ZYX2=:C_ZYX2,");
            strSql.Append("C_STEEL_SIGN=:C_STEEL_SIGN,");
            strSql.Append("C_GRADE_GROUP_CODE=:C_GRADE_GROUP_CODE,");
            strSql.Append("C_FLRST_FLAG=:C_FLRST_FLAG,");
            strSql.Append("C_USE_FLAG=:C_USE_FLAG,");
            strSql.Append("C_STEELGRADE_TYPE=:C_STEELGRADE_TYPE,");
            strSql.Append("C_NAME=:C_NAME");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_STD_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STL_GRD", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ZYX1", OracleDbType.Varchar2,300),
                    new OracleParameter(":C_ZYX2", OracleDbType.Varchar2,300),
                    new OracleParameter(":C_STEEL_SIGN", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_GRADE_GROUP_CODE", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_FLRST_FLAG", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_USE_FLAG", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_STEELGRADE_TYPE", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.N_STATUS;
            parameters[1].Value = model.C_EMP_ID;
            parameters[2].Value = model.D_MOD_DT;
            parameters[3].Value = model.C_REMARK;
            parameters[4].Value = model.C_STD_CODE;
            parameters[5].Value = model.C_STL_GRD;
            parameters[6].Value = model.C_ZYX1;
            parameters[7].Value = model.C_ZYX2;
            parameters[8].Value = model.C_STEEL_SIGN;
            parameters[9].Value = model.C_GRADE_GROUP_CODE;
            parameters[10].Value = model.C_FLRST_FLAG;
            parameters[11].Value = model.C_USE_FLAG;
            parameters[12].Value = model.C_STEELGRADE_TYPE;
            parameters[13].Value = model.C_NAME;
            parameters[14].Value = model.C_ID;

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
            strSql.Append("delete from TPB_LGJH ");
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
            strSql.Append("delete from TPB_LGJH ");
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
        public Mod_TPB_LGJH GetModel(string C_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,N_STATUS,C_EMP_ID,D_MOD_DT,C_REMARK,C_STD_CODE,C_STL_GRD,C_ZYX1,C_ZYX2,C_STEEL_SIGN,C_GRADE_GROUP_CODE,C_FLRST_FLAG,C_USE_FLAG,C_STEELGRADE_TYPE,C_NAME from TPB_LGJH ");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)         };
            parameters[0].Value = C_ID;

            Mod_TPB_LGJH model = new Mod_TPB_LGJH();
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
        public Mod_TPB_LGJH DataRowToModel(DataRow row)
        {
            Mod_TPB_LGJH model = new Mod_TPB_LGJH();
            if (row != null)
            {
                if (row["C_ID"] != null)
                {
                    model.C_ID = row["C_ID"].ToString();
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
                if (row["C_REMARK"] != null)
                {
                    model.C_REMARK = row["C_REMARK"].ToString();
                }
                if (row["C_STD_CODE"] != null)
                {
                    model.C_STD_CODE = row["C_STD_CODE"].ToString();
                }
                if (row["C_STL_GRD"] != null)
                {
                    model.C_STL_GRD = row["C_STL_GRD"].ToString();
                }
                if (row["C_ZYX1"] != null)
                {
                    model.C_ZYX1 = row["C_ZYX1"].ToString();
                }
                if (row["C_ZYX2"] != null)
                {
                    model.C_ZYX2 = row["C_ZYX2"].ToString();
                }
                if (row["C_STEEL_SIGN"] != null)
                {
                    model.C_STEEL_SIGN = row["C_STEEL_SIGN"].ToString();
                }
                if (row["C_GRADE_GROUP_CODE"] != null)
                {
                    model.C_GRADE_GROUP_CODE = row["C_GRADE_GROUP_CODE"].ToString();
                }
                if (row["C_FLRST_FLAG"] != null)
                {
                    model.C_FLRST_FLAG = row["C_FLRST_FLAG"].ToString();
                }
                if (row["C_USE_FLAG"] != null)
                {
                    model.C_USE_FLAG = row["C_USE_FLAG"].ToString();
                }
                if (row["C_STEELGRADE_TYPE"] != null)
                {
                    model.C_STEELGRADE_TYPE = row["C_STEELGRADE_TYPE"].ToString();
                }
                if (row["C_NAME"] != null)
                {
                    model.C_NAME = row["C_NAME"].ToString();
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
            strSql.Append("select C_ID,N_STATUS,C_EMP_ID,D_MOD_DT,C_REMARK,C_STD_CODE,C_STL_GRD,C_ZYX1,C_ZYX2,C_STEEL_SIGN,C_GRADE_GROUP_CODE,C_FLRST_FLAG,C_USE_FLAG,C_STEELGRADE_TYPE,C_NAME ");
            strSql.Append(" FROM TPB_LGJH ");
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
            strSql.Append("select count(1) FROM TPB_LGJH ");
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
            strSql.Append(")AS Row, T.*  from TPB_LGJH T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取炼钢记号
        /// </summary>
        public string Get_LGJH(string V_ZYX1, string V_ZYX2, string V_ZL_TYPE, string V_RH_TYPE, string V_CC_TYPE)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT max(TA.C_STEEL_SIGN) FROM TPB_LGJH TA INNER JOIN TPB_LGGYK TB ON TA.C_STEEL_SIGN = TB.C_STEELGRADEINDEX WHERE TA.C_USE_FLAG = '0' AND TA.C_ZYX1 = '" + V_ZYX1 + "' AND TA.C_ZYX2 = '" + V_ZYX2 + "' AND TB.C_BOF_TYPE = '" + V_ZL_TYPE + "' AND TB.C_LF_TYPE IN('02', '04') AND TB.C_RH_TYPE = '" + V_RH_TYPE + "' AND TB.C_CASTER_TYPE = '" + V_CC_TYPE + "' ");

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
        /// 获取炼钢记号
        /// </summary>
        public string Get_LGJH(string V_ZYX1, string V_ZYX2, string V_ZL_TYPE, string V_LF_TYPE, string V_RH_TYPE, string V_CC_TYPE)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT max(TA.C_STEEL_SIGN) FROM TPB_LGJH TA INNER JOIN TPB_LGGYK TB ON TA.C_STEEL_SIGN = TB.C_STEELGRADEINDEX WHERE TA.C_USE_FLAG = '0' AND TA.C_ZYX1 = '" + V_ZYX1 + "' AND TA.C_ZYX2 = '" + V_ZYX2 + "' AND TB.C_BOF_TYPE = '" + V_ZL_TYPE + "' AND TB.C_LF_TYPE ='" + V_LF_TYPE + "' AND TB.C_RH_TYPE = '" + V_RH_TYPE + "' AND TB.C_CASTER_TYPE = '" + V_CC_TYPE + "' ");

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
        /// 获取炼钢记号
        /// </summary>
        public DataSet Get_LGJH_Count(string C_STD_CODE, string C_STL_GRD, string V_ZL_TYPE, string V_RH_TYPE, string V_CC_TYPE)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT TA.C_STEEL_SIGN FROM TPB_LGJH TA INNER JOIN TPB_LGGYK TB ON TA.C_STEEL_SIGN = TB.C_STEELGRADEINDEX WHERE TA.C_USE_FLAG = '0' AND TA.C_STD_CODE = '" + C_STD_CODE + "' AND TA.C_STL_GRD = '" + C_STL_GRD + "' AND TB.C_BOF_TYPE = '" + V_ZL_TYPE + "' AND TB.C_LF_TYPE IN('02', '04') AND TB.C_RH_TYPE = '" + V_RH_TYPE + "' AND TB.C_CASTER_TYPE = '" + V_CC_TYPE + "' ");

            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取炼钢记号
        /// </summary>
        public DataSet Get_LGJH_Count(string C_STD_CODE, string C_STL_GRD, string V_ZL_TYPE, string V_LF_TYPE, string V_RH_TYPE, string V_CC_TYPE)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT TA.C_STEEL_SIGN FROM TPB_LGJH TA INNER JOIN TPB_LGGYK TB ON TA.C_STEEL_SIGN = TB.C_STEELGRADEINDEX WHERE TA.C_USE_FLAG = '0' AND TA.C_STD_CODE = '" + C_STD_CODE + "' AND TA.C_STL_GRD = '" + C_STL_GRD + "' AND TB.C_BOF_TYPE = '" + V_ZL_TYPE + "' AND TB.C_LF_TYPE ='" + V_LF_TYPE + "' AND TB.C_RH_TYPE = '" + V_RH_TYPE + "' AND TB.C_CASTER_TYPE = '" + V_CC_TYPE + "' ");

            return DbHelperOra.Query(strSql.ToString());
        }


        /// <summary>
        /// 获取炼钢记号
        /// </summary>
        public DataSet Get_LGJH_Std(string C_STD_CODE, string C_STL_GRD,  string V_CC_TYPE)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT TA.C_STEEL_SIGN FROM TPB_LGJH TA INNER JOIN TPB_LGGYK TB ON TA.C_STEEL_SIGN = TB.C_STEELGRADEINDEX WHERE TA.C_USE_FLAG = '0' AND TA.C_STD_CODE = '" + C_STD_CODE + "' AND TA.C_STL_GRD = '" + C_STL_GRD + "' AND TB.C_CASTER_TYPE = '" + V_CC_TYPE + "' ");

            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取炼钢记号
        /// </summary>
        public DataSet Get_LGJH_Std(string C_STD_CODE, string C_STL_GRD, string V_ZL_TYPE, string V_RH_TYPE, string V_CC_TYPE)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT TA.C_STEEL_SIGN FROM TPB_LGJH TA INNER JOIN TPB_LGGYK TB ON TA.C_STEEL_SIGN = TB.C_STEELGRADEINDEX WHERE TA.C_USE_FLAG = '0' AND TA.C_STD_CODE = '" + C_STD_CODE + "' AND TA.C_STL_GRD = '" + C_STL_GRD + "' AND TB.C_BOF_TYPE = '" + V_ZL_TYPE + "' AND TB.C_LF_TYPE IN('02', '04') AND TB.C_RH_TYPE = '" + V_RH_TYPE + "' AND TB.C_CASTER_TYPE = '" + V_CC_TYPE + "' ");

            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取炼钢记号
        /// </summary>
        public DataSet Get_LGJH_Std(string C_STD_CODE, string C_STL_GRD, string V_ZL_TYPE, string V_LF_TYPE, string V_RH_TYPE, string V_CC_TYPE)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT TA.C_STEEL_SIGN FROM TPB_LGJH TA INNER JOIN TPB_LGGYK TB ON TA.C_STEEL_SIGN = TB.C_STEELGRADEINDEX WHERE TA.C_USE_FLAG = '0' AND TA.C_STD_CODE = '" + C_STD_CODE + "' AND TA.C_STL_GRD = '" + C_STL_GRD + "' AND TB.C_BOF_TYPE = '" + V_ZL_TYPE + "' AND TB.C_LF_TYPE ='" + V_LF_TYPE + "' AND TB.C_RH_TYPE = '" + V_RH_TYPE + "' AND TB.C_CASTER_TYPE = '" + V_CC_TYPE + "' ");

            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取炼钢记号
        /// </summary>
        public DataSet Get_LGJH_Std_No_RH(string C_STD_CODE, string C_STL_GRD, string V_ZL_TYPE, string V_CC_TYPE)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT TA.C_STEEL_SIGN FROM TPB_LGJH TA INNER JOIN TPB_LGGYK TB ON TA.C_STEEL_SIGN = TB.C_STEELGRADEINDEX WHERE TA.C_USE_FLAG = '0' AND TA.C_STD_CODE = '" + C_STD_CODE + "' AND TA.C_STL_GRD = '" + C_STL_GRD + "' AND TB.C_BOF_TYPE = '" + V_ZL_TYPE + "' AND TB.C_LF_TYPE IN('02', '04') AND TB.C_CASTER_TYPE = '" + V_CC_TYPE + "' ");

            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取炼钢记号
        /// </summary>
        public DataSet Get_LGJH_Std_No_RH(string C_STD_CODE, string C_STL_GRD, string V_ZL_TYPE, string V_LF_TYPE,string V_CC_TYPE)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT TA.C_STEEL_SIGN FROM TPB_LGJH TA INNER JOIN TPB_LGGYK TB ON TA.C_STEEL_SIGN = TB.C_STEELGRADEINDEX WHERE TA.C_USE_FLAG = '0' AND TA.C_STD_CODE = '" + C_STD_CODE + "' AND TA.C_STL_GRD = '" + C_STL_GRD + "' AND TB.C_BOF_TYPE = '" + V_ZL_TYPE + "' AND TB.C_LF_TYPE ='" + V_LF_TYPE + "' AND TB.C_CASTER_TYPE = '" + V_CC_TYPE + "' ");

            return DbHelperOra.Query(strSql.ToString());
        }

        #endregion  BasicMethod
    }
}

