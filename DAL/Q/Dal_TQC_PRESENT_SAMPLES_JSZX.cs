using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using System.Collections;
using MODEL;
namespace DAL
{
    /// <summary>
    /// 数据访问类:TQC_PRESENT_SAMPLES_JSZX
    /// </summary>
    public partial class Dal_TQC_PRESENT_SAMPLES_JSZX
    {
        public Dal_TQC_PRESENT_SAMPLES_JSZX()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string C_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TQC_PRESENT_SAMPLES_JSZX");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)         };
            parameters[0].Value = C_ID;

            return DbHelperOra.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Mod_TQC_PRESENT_SAMPLES_JSZX model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TQC_PRESENT_SAMPLES_JSZX(");
            strSql.Append("C_BATCH_NO,C_TICK_NO,C_STL_GRD,C_SPEC,N_ENTRUST_TYPE,N_STATUS,C_REMARK,C_EMP_ID_SY,D_MOD_DT_SY,C_EMP_ID_JS,D_MOD_DT_JS,C_EMP_ID_ZY,D_MOD_DT_ZY,C_EQ_NAME,C_EQ_NUMBER,C_EQ_CODE,N_SAMPLES_NUM,D_MOD_DT)");
            strSql.Append(" values (");
            strSql.Append(":C_BATCH_NO,:C_TICK_NO,:C_STL_GRD,:C_SPEC,:N_ENTRUST_TYPE,:N_STATUS,:C_REMARK,:C_EMP_ID_SY,:D_MOD_DT_SY,:C_EMP_ID_JS,:D_MOD_DT_JS,:C_EMP_ID_ZY,:D_MOD_DT_ZY,:C_EQ_NAME,:C_EQ_NUMBER,:C_EQ_CODE,:N_SAMPLES_NUM,:D_MOD_DT)");
            OracleParameter[] parameters = {
                     new OracleParameter(":C_BATCH_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_TICK_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STL_GRD", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SPEC", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_ENTRUST_TYPE", OracleDbType.Decimal,1),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_EMP_ID_SY", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT_SY", OracleDbType.Date),
                    new OracleParameter(":C_EMP_ID_JS", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT_JS", OracleDbType.Date),
                    new OracleParameter(":C_EMP_ID_ZY", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT_ZY", OracleDbType.Date),
                    new OracleParameter(":C_EQ_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_EQ_NUMBER", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_EQ_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_SAMPLES_NUM", OracleDbType.Decimal,5),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date)};
            parameters[0].Value = model.C_BATCH_NO;
            parameters[1].Value = model.C_TICK_NO;
            parameters[2].Value = model.C_STL_GRD;
            parameters[3].Value = model.C_SPEC;
            parameters[4].Value = model.N_ENTRUST_TYPE;
            parameters[5].Value = model.N_STATUS;
            parameters[6].Value = model.C_REMARK;
            parameters[7].Value = model.C_EMP_ID_SY;
            parameters[8].Value = model.D_MOD_DT_SY;
            parameters[9].Value = model.C_EMP_ID_JS;
            parameters[10].Value = model.D_MOD_DT_JS;
            parameters[11].Value = model.C_EMP_ID_ZY;
            parameters[12].Value = model.D_MOD_DT_ZY;
            parameters[13].Value = model.C_EQ_NAME;
            parameters[14].Value = model.C_EQ_NUMBER;
            parameters[15].Value = model.C_EQ_CODE;
            parameters[16].Value = model.N_SAMPLES_NUM;
            parameters[17].Value = model.D_MOD_DT;

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
        public bool Update(Mod_TQC_PRESENT_SAMPLES_JSZX model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TQC_PRESENT_SAMPLES_JSZX set ");
            strSql.Append("C_BATCH_NO=:C_BATCH_NO,");
            strSql.Append("C_TICK_NO=:C_TICK_NO,");
            strSql.Append("C_STL_GRD=:C_STL_GRD,");
            strSql.Append("C_SPEC=:C_SPEC,");
            strSql.Append("N_ENTRUST_TYPE=:N_ENTRUST_TYPE,");
            strSql.Append("N_STATUS=:N_STATUS,");
            strSql.Append("C_REMARK=:C_REMARK,");
            strSql.Append("C_EMP_ID_SY=:C_EMP_ID_SY,");
            strSql.Append("D_MOD_DT_SY=:D_MOD_DT_SY,");
            strSql.Append("C_EMP_ID_JS=:C_EMP_ID_JS,");
            strSql.Append("D_MOD_DT_JS=:D_MOD_DT_JS,");
            strSql.Append("C_EMP_ID_ZY=:C_EMP_ID_ZY,");
            strSql.Append("D_MOD_DT_ZY=:D_MOD_DT_ZY,");
            strSql.Append("C_EQ_NAME=:C_EQ_NAME,");
            strSql.Append("C_EQ_NUMBER=:C_EQ_NUMBER,");
            strSql.Append("C_EQ_CODE=:C_EQ_CODE,");
            strSql.Append("N_SAMPLES_NUM=:N_SAMPLES_NUM,");
            strSql.Append("D_MOD_DT=:D_MOD_DT");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_BATCH_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_TICK_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STL_GRD", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SPEC", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_ENTRUST_TYPE", OracleDbType.Decimal,1),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_EMP_ID_SY", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT_SY", OracleDbType.Date),
                    new OracleParameter(":C_EMP_ID_JS", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT_JS", OracleDbType.Date),
                    new OracleParameter(":C_EMP_ID_ZY", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT_ZY", OracleDbType.Date),
                    new OracleParameter(":C_EQ_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_EQ_NUMBER", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_EQ_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_SAMPLES_NUM", OracleDbType.Decimal,5),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.C_BATCH_NO;
            parameters[1].Value = model.C_TICK_NO;
            parameters[2].Value = model.C_STL_GRD;
            parameters[3].Value = model.C_SPEC;
            parameters[4].Value = model.N_ENTRUST_TYPE;
            parameters[5].Value = model.N_STATUS;
            parameters[6].Value = model.C_REMARK;
            parameters[7].Value = model.C_EMP_ID_SY;
            parameters[8].Value = model.D_MOD_DT_SY;
            parameters[9].Value = model.C_EMP_ID_JS;
            parameters[10].Value = model.D_MOD_DT_JS;
            parameters[11].Value = model.C_EMP_ID_ZY;
            parameters[12].Value = model.D_MOD_DT_ZY;
            parameters[13].Value = model.C_EQ_NAME;
            parameters[14].Value = model.C_EQ_NUMBER;
            parameters[15].Value = model.C_EQ_CODE;
            parameters[16].Value = model.N_SAMPLES_NUM;
            parameters[17].Value = model.D_MOD_DT;
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
        /// 更新一条数据
        /// </summary>
        public bool Update_Trans(Mod_TQC_PRESENT_SAMPLES_JSZX model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TQC_PRESENT_SAMPLES_JSZX set ");
            strSql.Append("C_BATCH_NO=:C_BATCH_NO,");
            strSql.Append("C_TICK_NO=:C_TICK_NO,");
            strSql.Append("C_STL_GRD=:C_STL_GRD,");
            strSql.Append("C_SPEC=:C_SPEC,");
            strSql.Append("N_ENTRUST_TYPE=:N_ENTRUST_TYPE,");
            strSql.Append("N_STATUS=:N_STATUS,");
            strSql.Append("C_REMARK=:C_REMARK,");
            strSql.Append("C_EMP_ID_SY=:C_EMP_ID_SY,");
            strSql.Append("D_MOD_DT_SY=:D_MOD_DT_SY,");
            strSql.Append("C_EMP_ID_JS=:C_EMP_ID_JS,");
            strSql.Append("D_MOD_DT_JS=:D_MOD_DT_JS,");
            strSql.Append("C_EMP_ID_ZY=:C_EMP_ID_ZY,");
            strSql.Append("D_MOD_DT_ZY=:D_MOD_DT_ZY,");
            strSql.Append("C_EQ_NAME=:C_EQ_NAME,");
            strSql.Append("C_EQ_NUMBER=:C_EQ_NUMBER,");
            strSql.Append("C_EQ_CODE=:C_EQ_CODE,");
            strSql.Append("N_SAMPLES_NUM=:N_SAMPLES_NUM,");
            strSql.Append("D_MOD_DT=:D_MOD_DT");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_BATCH_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_TICK_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STL_GRD", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SPEC", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_ENTRUST_TYPE", OracleDbType.Decimal,1),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_EMP_ID_SY", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT_SY", OracleDbType.Date),
                    new OracleParameter(":C_EMP_ID_JS", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT_JS", OracleDbType.Date),
                    new OracleParameter(":C_EMP_ID_ZY", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT_ZY", OracleDbType.Date),
                    new OracleParameter(":C_EQ_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_EQ_NUMBER", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_EQ_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_SAMPLES_NUM", OracleDbType.Decimal,5),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.C_BATCH_NO;
            parameters[1].Value = model.C_TICK_NO;
            parameters[2].Value = model.C_STL_GRD;
            parameters[3].Value = model.C_SPEC;
            parameters[4].Value = model.N_ENTRUST_TYPE;
            parameters[5].Value = model.N_STATUS;
            parameters[6].Value = model.C_REMARK;
            parameters[7].Value = model.C_EMP_ID_SY;
            parameters[8].Value = model.D_MOD_DT_SY;
            parameters[9].Value = model.C_EMP_ID_JS;
            parameters[10].Value = model.D_MOD_DT_JS;
            parameters[11].Value = model.C_EMP_ID_ZY;
            parameters[12].Value = model.D_MOD_DT_ZY;
            parameters[13].Value = model.C_EQ_NAME;
            parameters[14].Value = model.C_EQ_NUMBER;
            parameters[15].Value = model.C_EQ_CODE;
            parameters[16].Value = model.N_SAMPLES_NUM;
            parameters[17].Value = model.D_MOD_DT;
            parameters[18].Value = model.C_ID;

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
            strSql.Append("delete from TQC_PRESENT_SAMPLES_JSZX ");
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
            strSql.Append("delete from TQC_PRESENT_SAMPLES_JSZX ");
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
        public Mod_TQC_PRESENT_SAMPLES_JSZX GetModel(string C_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_BATCH_NO,C_TICK_NO,C_STL_GRD,C_SPEC,N_ENTRUST_TYPE,N_STATUS,C_REMARK,C_EMP_ID_SY,D_MOD_DT_SY,C_EMP_ID_JS,D_MOD_DT_JS,C_EMP_ID_ZY,D_MOD_DT_ZY,C_EQ_NAME,C_EQ_NUMBER,C_EQ_CODE,N_SAMPLES_NUM,D_MOD_DT from TQC_PRESENT_SAMPLES_JSZX ");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)         };
            parameters[0].Value = C_ID;

            Mod_TQC_PRESENT_SAMPLES_JSZX model = new Mod_TQC_PRESENT_SAMPLES_JSZX();
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
        public Mod_TQC_PRESENT_SAMPLES_JSZX GetModel_Trans(string C_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_BATCH_NO,C_TICK_NO,C_STL_GRD,C_SPEC,N_ENTRUST_TYPE,N_STATUS,C_REMARK,C_EMP_ID_SY,D_MOD_DT_SY,C_EMP_ID_JS,D_MOD_DT_JS,C_EMP_ID_ZY,D_MOD_DT_ZY,C_EQ_NAME,C_EQ_NUMBER,C_EQ_CODE,N_SAMPLES_NUM,D_MOD_DT from TQC_PRESENT_SAMPLES_JSZX ");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)         };
            parameters[0].Value = C_ID;

            Mod_TQC_PRESENT_SAMPLES_JSZX model = new Mod_TQC_PRESENT_SAMPLES_JSZX();
            DataSet ds = TransactionHelper.Query(strSql.ToString(), parameters);
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
        public Mod_TQC_PRESENT_SAMPLES_JSZX DataRowToModel(DataRow row)
        {
            Mod_TQC_PRESENT_SAMPLES_JSZX model = new Mod_TQC_PRESENT_SAMPLES_JSZX();
            if (row != null)
            {
                if (row["C_ID"] != null)
                {
                    model.C_ID = row["C_ID"].ToString();
                }
                if (row["C_BATCH_NO"] != null)
                {
                    model.C_BATCH_NO = row["C_BATCH_NO"].ToString();
                }
                if (row["C_TICK_NO"] != null)
                {
                    model.C_TICK_NO = row["C_TICK_NO"].ToString();
                }
                if (row["C_STL_GRD"] != null)
                {
                    model.C_STL_GRD = row["C_STL_GRD"].ToString();
                }
                if (row["C_SPEC"] != null)
                {
                    model.C_SPEC = row["C_SPEC"].ToString();
                }
                if (row["N_ENTRUST_TYPE"] != null && row["N_ENTRUST_TYPE"].ToString() != "")
                {
                    model.N_ENTRUST_TYPE = decimal.Parse(row["N_ENTRUST_TYPE"].ToString());
                }
                if (row["N_STATUS"] != null && row["N_STATUS"].ToString() != "")
                {
                    model.N_STATUS = decimal.Parse(row["N_STATUS"].ToString());
                }
                if (row["C_REMARK"] != null)
                {
                    model.C_REMARK = row["C_REMARK"].ToString();
                }
                if (row["C_EMP_ID_SY"] != null)
                {
                    model.C_EMP_ID_SY = row["C_EMP_ID_SY"].ToString();
                }
                if (row["D_MOD_DT_SY"] != null && row["D_MOD_DT_SY"].ToString() != "")
                {
                    model.D_MOD_DT_SY = DateTime.Parse(row["D_MOD_DT_SY"].ToString());
                }
                if (row["C_EMP_ID_JS"] != null)
                {
                    model.C_EMP_ID_JS = row["C_EMP_ID_JS"].ToString();
                }
                if (row["D_MOD_DT_JS"] != null && row["D_MOD_DT_JS"].ToString() != "")
                {
                    model.D_MOD_DT_JS = DateTime.Parse(row["D_MOD_DT_JS"].ToString());
                }
                if (row["C_EMP_ID_ZY"] != null)
                {
                    model.C_EMP_ID_ZY = row["C_EMP_ID_ZY"].ToString();
                }
                if (row["D_MOD_DT_ZY"] != null && row["D_MOD_DT_ZY"].ToString() != "")
                {
                    model.D_MOD_DT_ZY = DateTime.Parse(row["D_MOD_DT_ZY"].ToString());
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
                if (row["N_SAMPLES_NUM"] != null && row["N_SAMPLES_NUM"].ToString() != "")
                {
                    model.N_SAMPLES_NUM = decimal.Parse(row["N_SAMPLES_NUM"].ToString());
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
            strSql.Append("select C_ID,C_BATCH_NO,C_TICK_NO,C_STL_GRD,C_SPEC,N_ENTRUST_TYPE,N_STATUS,C_REMARK,C_EMP_ID_SY,D_MOD_DT_SY,C_EMP_ID_JS,D_MOD_DT_JS,C_EMP_ID_ZY,D_MOD_DT_ZY,C_EQ_NAME,C_EQ_NUMBER,C_EQ_CODE,N_SAMPLES_NUM,D_MOD_DT ");
            strSql.Append(" FROM TQC_PRESENT_SAMPLES_JSZX ");
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
            strSql.Append("select count(1) FROM TQC_PRESENT_SAMPLES_JSZX ");
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
            strSql.Append(")AS Row, T.*  from TQC_PRESENT_SAMPLES_JSZX T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 检测技术中心是否已接收
        /// </summary>
        /// <param name="c_present_samples_id">取样主表主键（tqc_present_samples）</param>
        /// <param name="strState">送样状态   0-未送样；1-保存明细；2-已送样；3-接收送样</param>
        /// <returns></returns>
        public int Get_Count(string c_present_samples_id, string N_ENTRUST_TYPE)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM tqc_present_samples_jszx ta");

            strSql.Append(" WHERE ta.C_ID='" + c_present_samples_id + "' and ta.N_ENTRUST_TYPE ='" + N_ENTRUST_TYPE + "' ");

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

        #endregion  ExtensionMethod
    }
}

