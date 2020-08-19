using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;
namespace DAL
{
    /// <summary>
    /// 数据访问类:TPO_APS_CONFIG
    /// </summary>
    public partial class Dal_TPO_APS_CONFIG
    {
        public Dal_TPO_APS_CONFIG()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string C_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TPO_APS_CONFIG");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)            };
            parameters[0].Value = C_ID;

            return DbHelperOra.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Mod_TPO_APS_CONFIG model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TPO_APS_CONFIG(");
            strSql.Append("N_LZDHL,N_LZKP,N_DHLKP,N_KPXHL,N_KPZG,N_XHLZG,N_5LZZS,N_7LZZS,N_3LZZS,N_4LZZS,N_6LZZS,N_5LZZL,N_7LZZL,N_3LZZL,N_4LZZL,N_6LZZL,N_RHLS,N_HLGLS,N_HLGSJ,N_TGJSCL,N_BXGJSCL,N_1KPJSCL,N_2KPJSCL,N_KPL,N_XML)");
            strSql.Append(" values (");
            strSql.Append(":N_LZDHL,:N_LZKP,:N_DHLKP,:N_KPXHL,:N_KPZG,:N_XHLZG,:N_5LZZS,:N_7LZZS,:N_3LZZS,:N_4LZZS,:N_6LZZS,:N_5LZZL,:N_7LZZL,:N_3LZZL,:N_4LZZL,:N_6LZZL,:N_RHLS,:N_HLGLS,:N_HLGSJ,:N_TGJSCL,:N_BXGJSCL,:N_1KPJSCL,:N_2KPJSCL,:N_KPL,:N_XML)");
            OracleParameter[] parameters = {
                    new OracleParameter(":N_LZDHL", OracleDbType.Int16,5),
                    new OracleParameter(":N_LZKP", OracleDbType.Int16,5),
                    new OracleParameter(":N_DHLKP", OracleDbType.Int16,5),
                    new OracleParameter(":N_KPXHL", OracleDbType.Int16,5),
                    new OracleParameter(":N_KPZG", OracleDbType.Int16,5),
                    new OracleParameter(":N_XHLZG", OracleDbType.Int16,5),
                    new OracleParameter(":N_5LZZS", OracleDbType.Int16,5),
                    new OracleParameter(":N_7LZZS", OracleDbType.Int16,5),
                    new OracleParameter(":N_3LZZS", OracleDbType.Int16,5),
                    new OracleParameter(":N_4LZZS", OracleDbType.Int16,5),
                    new OracleParameter(":N_6LZZS", OracleDbType.Int16,5),
                    new OracleParameter(":N_5LZZL", OracleDbType.Int16,5),
                    new OracleParameter(":N_7LZZL", OracleDbType.Int16,5),
                    new OracleParameter(":N_3LZZL", OracleDbType.Int16,5),
                    new OracleParameter(":N_4LZZL", OracleDbType.Int16,5),
                    new OracleParameter(":N_6LZZL", OracleDbType.Int16,5),
                    new OracleParameter(":N_RHLS", OracleDbType.Int16,5),
                    new OracleParameter(":N_HLGLS", OracleDbType.Int16,5),
                    new OracleParameter(":N_HLGSJ", OracleDbType.Int16,5),
                    new OracleParameter(":N_TGJSCL", OracleDbType.Int16,5),
                    new OracleParameter(":N_BXGJSCL", OracleDbType.Int16,5),
                    new OracleParameter(":N_1KPJSCL", OracleDbType.Int16,5),
                    new OracleParameter(":N_2KPJSCL", OracleDbType.Int16,5),
                    new OracleParameter(":N_KPL", OracleDbType.Int16,5),
                    new OracleParameter(":N_XML", OracleDbType.Int16,5)};
            parameters[0].Value = model.N_LZDHL;
            parameters[1].Value = model.N_LZKP;
            parameters[2].Value = model.N_DHLKP;
            parameters[3].Value = model.N_KPXHL;
            parameters[4].Value = model.N_KPZG;
            parameters[5].Value = model.N_XHLZG;
            parameters[6].Value = model.N_5LZZS;
            parameters[7].Value = model.N_7LZZS;
            parameters[8].Value = model.N_3LZZS;
            parameters[9].Value = model.N_4LZZS;
            parameters[10].Value = model.N_6LZZS;
            parameters[11].Value = model.N_5LZZL;
            parameters[12].Value = model.N_7LZZL;
            parameters[13].Value = model.N_3LZZL;
            parameters[14].Value = model.N_4LZZL;
            parameters[15].Value = model.N_6LZZL;
            parameters[16].Value = model.N_RHLS;
            parameters[17].Value = model.N_HLGLS;
            parameters[18].Value = model.N_HLGSJ;
            parameters[19].Value = model.N_TGJSCL;
            parameters[20].Value = model.N_BXGJSCL;
            parameters[21].Value = model.N_1KPJSCL;
            parameters[22].Value = model.N_2KPJSCL;
            parameters[23].Value = model.N_KPL;
            parameters[24].Value = model.N_XML;

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
        public bool Update(Mod_TPO_APS_CONFIG model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TPO_APS_CONFIG set ");
            strSql.Append("N_LZDHL=:N_LZDHL,");
            strSql.Append("N_LZKP=:N_LZKP,");
            strSql.Append("N_DHLKP=:N_DHLKP,");
            strSql.Append("N_KPXHL=:N_KPXHL,");
            strSql.Append("N_KPZG=:N_KPZG,");
            strSql.Append("N_XHLZG=:N_XHLZG,");
            strSql.Append("N_5LZZS=:N_5LZZS,");
            strSql.Append("N_7LZZS=:N_7LZZS,");
            strSql.Append("N_3LZZS=:N_3LZZS,");
            strSql.Append("N_4LZZS=:N_4LZZS,");
            strSql.Append("N_6LZZS=:N_6LZZS,");
            strSql.Append("N_5LZZL=:N_5LZZL,");
            strSql.Append("N_7LZZL=:N_7LZZL,");
            strSql.Append("N_3LZZL=:N_3LZZL,");
            strSql.Append("N_4LZZL=:N_4LZZL,");
            strSql.Append("N_6LZZL=:N_6LZZL,");
            strSql.Append("N_RHLS=:N_RHLS,");
            strSql.Append("N_HLGLS=:N_HLGLS,");
            strSql.Append("N_HLGSJ=:N_HLGSJ,");
            strSql.Append("N_TGJSCL=:N_TGJSCL,");
            strSql.Append("N_BXGJSCL=:N_BXGJSCL,");
            strSql.Append("N_1KPJSCL=:N_1KPJSCL,");
            strSql.Append("N_2KPJSCL=:N_2KPJSCL,");
            strSql.Append("N_KPL=:N_KPL,");
            strSql.Append("N_XML=:N_XML");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":N_LZDHL", OracleDbType.Int16,5),
                    new OracleParameter(":N_LZKP", OracleDbType.Int16,5),
                    new OracleParameter(":N_DHLKP", OracleDbType.Int16,5),
                    new OracleParameter(":N_KPXHL", OracleDbType.Int16,5),
                    new OracleParameter(":N_KPZG", OracleDbType.Int16,5),
                    new OracleParameter(":N_XHLZG", OracleDbType.Int16,5),
                    new OracleParameter(":N_5LZZS", OracleDbType.Int16,5),
                    new OracleParameter(":N_7LZZS", OracleDbType.Int16,5),
                    new OracleParameter(":N_3LZZS", OracleDbType.Int16,5),
                    new OracleParameter(":N_4LZZS", OracleDbType.Int16,5),
                    new OracleParameter(":N_6LZZS", OracleDbType.Int16,5),
                    new OracleParameter(":N_5LZZL", OracleDbType.Int16,5),
                    new OracleParameter(":N_7LZZL", OracleDbType.Int16,5),
                    new OracleParameter(":N_3LZZL", OracleDbType.Int16,5),
                    new OracleParameter(":N_4LZZL", OracleDbType.Int16,5),
                    new OracleParameter(":N_6LZZL", OracleDbType.Int16,5),
                    new OracleParameter(":N_RHLS", OracleDbType.Int16,5),
                    new OracleParameter(":N_HLGLS", OracleDbType.Int16,5),
                    new OracleParameter(":N_HLGSJ", OracleDbType.Int16,5),
                    new OracleParameter(":N_TGJSCL", OracleDbType.Int16,5),
                    new OracleParameter(":N_BXGJSCL", OracleDbType.Int16,5),
                    new OracleParameter(":N_1KPJSCL", OracleDbType.Int16,5),
                    new OracleParameter(":N_2KPJSCL", OracleDbType.Int16,5),
                    new OracleParameter(":N_KPL", OracleDbType.Int16,5),
                    new OracleParameter(":N_XML", OracleDbType.Int16,5),
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.N_LZDHL;
            parameters[1].Value = model.N_LZKP;
            parameters[2].Value = model.N_DHLKP;
            parameters[3].Value = model.N_KPXHL;
            parameters[4].Value = model.N_KPZG;
            parameters[5].Value = model.N_XHLZG;
            parameters[6].Value = model.N_5LZZS;
            parameters[7].Value = model.N_7LZZS;
            parameters[8].Value = model.N_3LZZS;
            parameters[9].Value = model.N_4LZZS;
            parameters[10].Value = model.N_6LZZS;
            parameters[11].Value = model.N_5LZZL;
            parameters[12].Value = model.N_7LZZL;
            parameters[13].Value = model.N_3LZZL;
            parameters[14].Value = model.N_4LZZL;
            parameters[15].Value = model.N_6LZZL;
            parameters[16].Value = model.N_RHLS;
            parameters[17].Value = model.N_HLGLS;
            parameters[18].Value = model.N_HLGSJ;
            parameters[19].Value = model.N_TGJSCL;
            parameters[20].Value = model.N_BXGJSCL;
            parameters[21].Value = model.N_1KPJSCL;
            parameters[22].Value = model.N_2KPJSCL;
            parameters[23].Value = model.N_KPL;
            parameters[24].Value = model.N_XML;
            parameters[25].Value = model.C_ID;

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
        /// 删除数据
        /// </summary>
        public bool Delete()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from TPO_APS_CONFIG ");
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
        /// 删除一条数据
        /// </summary>
        public bool Delete(string C_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from TPO_APS_CONFIG ");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)            };
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
            strSql.Append("delete from TPO_APS_CONFIG ");
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
        public Mod_TPO_APS_CONFIG GetModel(string C_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,N_LZDHL,N_LZKP,N_DHLKP,N_KPXHL,N_KPZG,N_XHLZG,N_5LZZS,N_7LZZS,N_3LZZS,N_4LZZS,N_6LZZS,N_5LZZL,N_7LZZL,N_3LZZL,N_4LZZL,N_6LZZL,N_RHLS,N_HLGLS,N_HLGSJ,N_TGJSCL,N_BXGJSCL,N_1KPJSCL,N_2KPJSCL,N_KPL,N_XML from TPO_APS_CONFIG ");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)            };
            parameters[0].Value = C_ID;

            Mod_TPO_APS_CONFIG model = new Mod_TPO_APS_CONFIG();
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
        public Mod_TPO_APS_CONFIG DataRowToModel(DataRow row)
        {
            Mod_TPO_APS_CONFIG model = new Mod_TPO_APS_CONFIG();
            if (row != null)
            {
                if (row["C_ID"] != null)
                {
                    model.C_ID = row["C_ID"].ToString();
                }
                if (row["N_LZDHL"] != null && row["N_LZDHL"].ToString() != "")
                {
                    model.N_LZDHL = decimal.Parse(row["N_LZDHL"].ToString());
                }
                if (row["N_LZKP"] != null && row["N_LZKP"].ToString() != "")
                {
                    model.N_LZKP = decimal.Parse(row["N_LZKP"].ToString());
                }
                if (row["N_DHLKP"] != null && row["N_DHLKP"].ToString() != "")
                {
                    model.N_DHLKP = decimal.Parse(row["N_DHLKP"].ToString());
                }
                if (row["N_KPXHL"] != null && row["N_KPXHL"].ToString() != "")
                {
                    model.N_KPXHL = decimal.Parse(row["N_KPXHL"].ToString());
                }
                if (row["N_KPZG"] != null && row["N_KPZG"].ToString() != "")
                {
                    model.N_KPZG = decimal.Parse(row["N_KPZG"].ToString());
                }
                if (row["N_XHLZG"] != null && row["N_XHLZG"].ToString() != "")
                {
                    model.N_XHLZG = decimal.Parse(row["N_XHLZG"].ToString());
                }
                if (row["N_5LZZS"] != null && row["N_5LZZS"].ToString() != "")
                {
                    model.N_5LZZS = decimal.Parse(row["N_5LZZS"].ToString());
                }
                if (row["N_7LZZS"] != null && row["N_7LZZS"].ToString() != "")
                {
                    model.N_7LZZS = decimal.Parse(row["N_7LZZS"].ToString());
                }
                if (row["N_3LZZS"] != null && row["N_3LZZS"].ToString() != "")
                {
                    model.N_3LZZS = decimal.Parse(row["N_3LZZS"].ToString());
                }
                if (row["N_4LZZS"] != null && row["N_4LZZS"].ToString() != "")
                {
                    model.N_4LZZS = decimal.Parse(row["N_4LZZS"].ToString());
                }
                if (row["N_6LZZS"] != null && row["N_6LZZS"].ToString() != "")
                {
                    model.N_6LZZS = decimal.Parse(row["N_6LZZS"].ToString());
                }
                if (row["N_5LZZL"] != null && row["N_5LZZL"].ToString() != "")
                {
                    model.N_5LZZL = decimal.Parse(row["N_5LZZL"].ToString());
                }
                if (row["N_7LZZL"] != null && row["N_7LZZL"].ToString() != "")
                {
                    model.N_7LZZL = decimal.Parse(row["N_7LZZL"].ToString());
                }
                if (row["N_3LZZL"] != null && row["N_3LZZL"].ToString() != "")
                {
                    model.N_3LZZL = decimal.Parse(row["N_3LZZL"].ToString());
                }
                if (row["N_4LZZL"] != null && row["N_4LZZL"].ToString() != "")
                {
                    model.N_4LZZL = decimal.Parse(row["N_4LZZL"].ToString());
                }
                if (row["N_6LZZL"] != null && row["N_6LZZL"].ToString() != "")
                {
                    model.N_6LZZL = decimal.Parse(row["N_6LZZL"].ToString());
                }
                if (row["N_RHLS"] != null && row["N_RHLS"].ToString() != "")
                {
                    model.N_RHLS = decimal.Parse(row["N_RHLS"].ToString());
                }
                if (row["N_HLGLS"] != null && row["N_HLGLS"].ToString() != "")
                {
                    model.N_HLGLS = decimal.Parse(row["N_HLGLS"].ToString());
                }
                if (row["N_HLGSJ"] != null && row["N_HLGSJ"].ToString() != "")
                {
                    model.N_HLGSJ = decimal.Parse(row["N_HLGSJ"].ToString());
                }
                if (row["N_TGJSCL"] != null && row["N_TGJSCL"].ToString() != "")
                {
                    model.N_TGJSCL = decimal.Parse(row["N_TGJSCL"].ToString());
                }
                if (row["N_BXGJSCL"] != null && row["N_BXGJSCL"].ToString() != "")
                {
                    model.N_BXGJSCL = decimal.Parse(row["N_BXGJSCL"].ToString());
                }
                if (row["N_1KPJSCL"] != null && row["N_1KPJSCL"].ToString() != "")
                {
                    model.N_1KPJSCL = decimal.Parse(row["N_1KPJSCL"].ToString());
                }
                if (row["N_2KPJSCL"] != null && row["N_2KPJSCL"].ToString() != "")
                {
                    model.N_2KPJSCL = decimal.Parse(row["N_2KPJSCL"].ToString());
                }
                if (row["N_KPL"] != null && row["N_KPL"].ToString() != "")
                {
                    model.N_KPL = decimal.Parse(row["N_KPL"].ToString());
                }
                if (row["N_XML"] != null && row["N_XML"].ToString() != "")
                {
                    model.N_XML = decimal.Parse(row["N_XML"].ToString());
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
            strSql.Append("select C_ID,N_LZDHL,N_LZKP,N_DHLKP,N_KPXHL,N_KPZG,N_XHLZG,N_5LZZS,N_7LZZS,N_3LZZS,N_4LZZS,N_6LZZS,N_5LZZL,N_7LZZL,N_3LZZL,N_4LZZL,N_6LZZL,N_RHLS,N_HLGLS,N_HLGSJ,N_TGJSCL,N_BXGJSCL,N_1KPJSCL,N_2KPJSCL,N_KPL,N_XML ");
            strSql.Append(" FROM TPO_APS_CONFIG ");
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
            strSql.Append("select count(1) FROM TPO_APS_CONFIG ");
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
            strSql.Append(")AS Row, T.*  from TPO_APS_CONFIG T ");
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
