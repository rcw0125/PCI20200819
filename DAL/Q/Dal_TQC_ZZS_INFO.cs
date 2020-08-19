using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;
namespace DAL
{
    /// <summary>
    /// 数据访问类:TQC_ZZS_INFO
    /// </summary>
    public partial class Dal_TQC_ZZS_INFO
    {
        public Dal_TQC_ZZS_INFO()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string C_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TQC_ZZS_INFO");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)         };
            parameters[0].Value = C_ID;

            return DbHelperOra.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Mod_TQC_ZZS_INFO model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TQC_ZZS_INFO(");
            strSql.Append("C_ID,C_FYDH,C_BATCH_NO,C_STOVE,C_SPEC,C_STL_GRD,C_STD_CODE,D_CKSJ,N_JZ,N_NUM,C_CH,C_PDF_NAME,C_PDF_PATCH,N_PRINT_NUM,C_ZSH,C_QZR,D_QZRQ,C_BY1,C_BY2,C_BY3,N_STATUS,C_REMARK)");
            strSql.Append(" values (");
            strSql.Append(":C_ID,:C_FYDH,:C_BATCH_NO,:C_STOVE,:C_SPEC,:C_STL_GRD,:C_STD_CODE,:D_CKSJ,:N_JZ,:N_NUM,:C_CH,:C_PDF_NAME,:C_PDF_PATCH,:N_PRINT_NUM,:C_ZSH,:C_QZR,:D_QZRQ,:C_BY1,:C_BY2,:C_BY3,:N_STATUS,:C_REMARK)");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_FYDH", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_BATCH_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STOVE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SPEC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STL_GRD", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STD_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_CKSJ", OracleDbType.Date),
                    new OracleParameter(":N_JZ", OracleDbType.Decimal,15),
                    new OracleParameter(":N_NUM", OracleDbType.Decimal,5),
                    new OracleParameter(":C_CH", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PDF_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PDF_PATCH", OracleDbType.Varchar2,200),
                    new OracleParameter(":N_PRINT_NUM", OracleDbType.Decimal,3),
                    new OracleParameter(":C_ZSH", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_QZR", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_QZRQ", OracleDbType.Date),
                    new OracleParameter(":C_BY1", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_BY2", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_BY3", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.C_ID;
            parameters[1].Value = model.C_FYDH;
            parameters[2].Value = model.C_BATCH_NO;
            parameters[3].Value = model.C_STOVE;
            parameters[4].Value = model.C_SPEC;
            parameters[5].Value = model.C_STL_GRD;
            parameters[6].Value = model.C_STD_CODE;
            parameters[7].Value = model.D_CKSJ;
            parameters[8].Value = model.N_JZ;
            parameters[9].Value = model.N_NUM;
            parameters[10].Value = model.C_CH;
            parameters[11].Value = model.C_PDF_NAME;
            parameters[12].Value = model.C_PDF_PATCH;
            parameters[13].Value = model.N_PRINT_NUM;
            parameters[14].Value = model.C_ZSH;
            parameters[15].Value = model.C_QZR;
            parameters[16].Value = model.D_QZRQ;
            parameters[17].Value = model.C_BY1;
            parameters[18].Value = model.C_BY2;
            parameters[19].Value = model.C_BY3;
            parameters[20].Value = model.N_STATUS;
            parameters[21].Value = model.C_REMARK;

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
        public bool Update(Mod_TQC_ZZS_INFO model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TQC_ZZS_INFO set ");
            strSql.Append("C_FYDH=:C_FYDH,");
            strSql.Append("C_BATCH_NO=:C_BATCH_NO,");
            strSql.Append("C_STOVE=:C_STOVE,");
            strSql.Append("C_SPEC=:C_SPEC,");
            strSql.Append("C_STL_GRD=:C_STL_GRD,");
            strSql.Append("C_STD_CODE=:C_STD_CODE,");
            strSql.Append("D_CKSJ=:D_CKSJ,");
            strSql.Append("N_JZ=:N_JZ,");
            strSql.Append("N_NUM=:N_NUM,");
            strSql.Append("C_CH=:C_CH,");
            strSql.Append("C_PDF_NAME=:C_PDF_NAME,");
            strSql.Append("C_PDF_PATCH=:C_PDF_PATCH,");
            strSql.Append("N_PRINT_NUM=:N_PRINT_NUM,");
            strSql.Append("C_ZSH=:C_ZSH,");
            strSql.Append("C_QZR=:C_QZR,");
            strSql.Append("D_QZRQ=:D_QZRQ,");
            strSql.Append("C_BY1=:C_BY1,");
            strSql.Append("C_BY2=:C_BY2,");
            strSql.Append("C_BY3=:C_BY3,");
            strSql.Append("N_STATUS=:N_STATUS,");
            strSql.Append("C_REMARK=:C_REMARK");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_FYDH", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_BATCH_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STOVE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SPEC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STL_GRD", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STD_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_CKSJ", OracleDbType.Date),
                    new OracleParameter(":N_JZ", OracleDbType.Decimal,15),
                    new OracleParameter(":N_NUM", OracleDbType.Decimal,5),
                    new OracleParameter(":C_CH", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PDF_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PDF_PATCH", OracleDbType.Varchar2,200),
                    new OracleParameter(":N_PRINT_NUM", OracleDbType.Decimal,3),
                    new OracleParameter(":C_ZSH", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_QZR", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_QZRQ", OracleDbType.Date),
                    new OracleParameter(":C_BY1", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_BY2", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_BY3", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.C_FYDH;
            parameters[1].Value = model.C_BATCH_NO;
            parameters[2].Value = model.C_STOVE;
            parameters[3].Value = model.C_SPEC;
            parameters[4].Value = model.C_STL_GRD;
            parameters[5].Value = model.C_STD_CODE;
            parameters[6].Value = model.D_CKSJ;
            parameters[7].Value = model.N_JZ;
            parameters[8].Value = model.N_NUM;
            parameters[9].Value = model.C_CH;
            parameters[10].Value = model.C_PDF_NAME;
            parameters[11].Value = model.C_PDF_PATCH;
            parameters[12].Value = model.N_PRINT_NUM;
            parameters[13].Value = model.C_ZSH;
            parameters[14].Value = model.C_QZR;
            parameters[15].Value = model.D_QZRQ;
            parameters[16].Value = model.C_BY1;
            parameters[17].Value = model.C_BY2;
            parameters[18].Value = model.C_BY3;
            parameters[19].Value = model.N_STATUS;
            parameters[20].Value = model.C_REMARK;
            parameters[21].Value = model.C_ID;

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
            strSql.Append("delete from TQC_ZZS_INFO ");
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
            strSql.Append("delete from TQC_ZZS_INFO ");
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
        public Mod_TQC_ZZS_INFO GetModel(string C_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_FYDH,C_BATCH_NO,C_STOVE,C_SPEC,C_STL_GRD,C_STD_CODE,D_CKSJ,N_JZ,N_NUM,C_CH,C_PDF_NAME,C_PDF_PATCH,N_PRINT_NUM,C_ZSH,C_QZR,D_QZRQ,C_BY1,C_BY2,C_BY3,N_STATUS,C_REMARK from TQC_ZZS_INFO ");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)         };
            parameters[0].Value = C_ID;

            Mod_TQC_ZZS_INFO model = new Mod_TQC_ZZS_INFO();
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
        public Mod_TQC_ZZS_INFO DataRowToModel(DataRow row)
        {
            Mod_TQC_ZZS_INFO model = new Mod_TQC_ZZS_INFO();
            if (row != null)
            {
                if (row["C_ID"] != null)
                {
                    model.C_ID = row["C_ID"].ToString();
                }
                if (row["C_FYDH"] != null)
                {
                    model.C_FYDH = row["C_FYDH"].ToString();
                }
                if (row["C_BATCH_NO"] != null)
                {
                    model.C_BATCH_NO = row["C_BATCH_NO"].ToString();
                }
                if (row["C_STOVE"] != null)
                {
                    model.C_STOVE = row["C_STOVE"].ToString();
                }
                if (row["C_SPEC"] != null)
                {
                    model.C_SPEC = row["C_SPEC"].ToString();
                }
                if (row["C_STL_GRD"] != null)
                {
                    model.C_STL_GRD = row["C_STL_GRD"].ToString();
                }
                if (row["C_STD_CODE"] != null)
                {
                    model.C_STD_CODE = row["C_STD_CODE"].ToString();
                }
                if (row["D_CKSJ"] != null && row["D_CKSJ"].ToString() != "")
                {
                    model.D_CKSJ = DateTime.Parse(row["D_CKSJ"].ToString());
                }
                if (row["N_JZ"] != null && row["N_JZ"].ToString() != "")
                {
                    model.N_JZ = decimal.Parse(row["N_JZ"].ToString());
                }
                if (row["N_NUM"] != null && row["N_NUM"].ToString() != "")
                {
                    model.N_NUM = decimal.Parse(row["N_NUM"].ToString());
                }
                if (row["C_CH"] != null)
                {
                    model.C_CH = row["C_CH"].ToString();
                }
                if (row["C_PDF_NAME"] != null)
                {
                    model.C_PDF_NAME = row["C_PDF_NAME"].ToString();
                }
                if (row["C_PDF_PATCH"] != null)
                {
                    model.C_PDF_PATCH = row["C_PDF_PATCH"].ToString();
                }
                if (row["N_PRINT_NUM"] != null && row["N_PRINT_NUM"].ToString() != "")
                {
                    model.N_PRINT_NUM = decimal.Parse(row["N_PRINT_NUM"].ToString());
                }
                if (row["C_ZSH"] != null)
                {
                    model.C_ZSH = row["C_ZSH"].ToString();
                }
                if (row["C_QZR"] != null)
                {
                    model.C_QZR = row["C_QZR"].ToString();
                }
                if (row["D_QZRQ"] != null && row["D_QZRQ"].ToString() != "")
                {
                    model.D_QZRQ = DateTime.Parse(row["D_QZRQ"].ToString());
                }
                if (row["C_BY1"] != null)
                {
                    model.C_BY1 = row["C_BY1"].ToString();
                }
                if (row["C_BY2"] != null)
                {
                    model.C_BY2 = row["C_BY2"].ToString();
                }
                if (row["C_BY3"] != null)
                {
                    model.C_BY3 = row["C_BY3"].ToString();
                }
                if (row["N_STATUS"] != null && row["N_STATUS"].ToString() != "")
                {
                    model.N_STATUS = decimal.Parse(row["N_STATUS"].ToString());
                }
                if (row["C_REMARK"] != null)
                {
                    model.C_REMARK = row["C_REMARK"].ToString();
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
            strSql.Append("select C_ID,C_FYDH,C_BATCH_NO,C_STOVE,C_SPEC,C_STL_GRD,C_STD_CODE,D_CKSJ,N_JZ,N_NUM,C_CH,C_PDF_NAME,C_PDF_PATCH,N_PRINT_NUM,C_ZSH,C_QZR,D_QZRQ,C_BY1,C_BY2,C_BY3,N_STATUS,C_REMARK ");
            strSql.Append(" FROM TQC_ZZS_INFO ");
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
            strSql.Append("select count(1) FROM TQC_ZZS_INFO ");
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
            strSql.Append(")AS Row, T.*  from TQC_ZZS_INFO T ");
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

