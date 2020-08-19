using MODEL;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DAL
{
    public partial class Dal_TRC_COGDOWN_PRODUCT_LOG
    {
        public Dal_TRC_COGDOWN_PRODUCT_LOG()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string C_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TRC_COGDOWN_PRODUCT_LOG");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)            };
            parameters[0].Value = C_ID;

            return DbHelperOra.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Mod_TRC_COGDOWN_PRODUCT_LOG model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TRC_COGDOWN_PRODUCT_LOG(");
            strSql.Append("C_BATCH_NO,N_QUA,N_WGT,C_TRC_COGDOWN_MAIN_ID,D_MOD_DT,C_EMP_ID,C_STA_ID,N_TYPE,C_SHIFT,C_GROUP,C_REMARK,C_SCRAP,C_SLAB_MAIN_ID,N_PLANQUA,N_PLANWGT)");
            strSql.Append(" values (");
            strSql.Append(":C_BATCH_NO,:N_QUA,:N_WGT,:C_TRC_COGDOWN_MAIN_ID,:D_MOD_DT,:C_EMP_ID,:C_STA_ID,:N_TYPE,:C_SHIFT,:C_GROUP,:C_REMARK,:C_SCRAP,:C_SLAB_MAIN_ID,:N_PLANQUA,:N_PLANWGT)");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_BATCH_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_QUA", OracleDbType.Decimal,15),
                    new OracleParameter(":N_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":C_TRC_COGDOWN_MAIN_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STA_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_TYPE", OracleDbType.Decimal,4),
                    new OracleParameter(":C_SHIFT", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_GROUP", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,200),
                    new OracleParameter(":C_SCRAP", OracleDbType.Decimal,15),
                    new OracleParameter(":C_SLAB_MAIN_ID", OracleDbType.Varchar2,3000),
                    new OracleParameter(":N_PLANQUA", OracleDbType.Decimal,15),
                    new OracleParameter(":N_PLANWGT", OracleDbType.Decimal,15),
            };
            parameters[0].Value = model.C_BATCH_NO;
            parameters[1].Value = model.N_QUA;
            parameters[2].Value = model.N_WGT;
            parameters[3].Value = model.C_TRC_COGDOWN_MAIN_ID;
            parameters[4].Value = model.D_MOD_DT;
            parameters[5].Value = model.C_EMP_ID;
            parameters[6].Value = model.C_STA_ID;
            parameters[7].Value = model.N_TYPE;
            parameters[8].Value = model.C_SHIFT;
            parameters[9].Value = model.C_GROUP;
            parameters[10].Value = model.C_REMARK;
            parameters[11].Value = model.C_SCRAP;
            parameters[12].Value = model.C_SLAB_MAIN_ID;
            parameters[13].Value = model.N_PLANQUA;
            parameters[14].Value = model.N_PLANWGT;

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
        public bool Update(Mod_TRC_COGDOWN_PRODUCT_LOG model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TRC_COGDOWN_PRODUCT_LOG set ");
            strSql.Append("C_BATCH_NO=:C_BATCH_NO,");
            strSql.Append("N_QUA=:N_QUA,");
            strSql.Append("N_WGT=:N_WGT,");
            strSql.Append("C_TRC_COGDOWN_MAIN_ID=:C_TRC_COGDOWN_MAIN_ID,");
            strSql.Append("D_MOD_DT=:D_MOD_DT,");
            strSql.Append("C_EMP_ID=:C_EMP_ID,");
            strSql.Append("C_STA_ID=:C_STA_ID,");
            strSql.Append("N_TYPE=:N_TYPE,");
            strSql.Append("C_SHIFT=:C_SHIFT,");
            strSql.Append("C_GROUP=:C_GROUP,");
            strSql.Append("C_REMARK=:C_REMARK,");
            strSql.Append("C_SCRAP=:C_SCRAP");
            strSql.Append("C_SLAB_MAIN_ID=:C_SLAB_MAIN_ID");        
            strSql.Append("N_PLANQUA=:N_PLANQUA,");
            strSql.Append("N_PLANWGT=:N_PLANWGT");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_BATCH_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_QUA", OracleDbType.Decimal,15),
                    new OracleParameter(":N_WGT", OracleDbType.Decimal,15),
                    new OracleParameter(":C_TRC_COGDOWN_MAIN_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STA_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_TYPE", OracleDbType.Decimal,4),
                    new OracleParameter(":C_SHIFT", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_GROUP", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,200),
                    new OracleParameter(":C_SCRAP", OracleDbType.Decimal,15),
                    new OracleParameter(":C_SLAB_MAIN_ID", OracleDbType.Varchar2,3000),
                    new OracleParameter(":N_PLANQUA", OracleDbType.Varchar2,200),
                    new OracleParameter(":N_PLANWGT", OracleDbType.Decimal,15),
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.C_BATCH_NO;
            parameters[1].Value = model.N_QUA;
            parameters[2].Value = model.N_WGT;
            parameters[3].Value = model.C_TRC_COGDOWN_MAIN_ID;
            parameters[4].Value = model.D_MOD_DT;
            parameters[5].Value = model.C_EMP_ID;
            parameters[6].Value = model.C_STA_ID;
            parameters[7].Value = model.N_TYPE;
            parameters[8].Value = model.C_SHIFT;
            parameters[9].Value = model.C_GROUP;
            parameters[10].Value = model.C_REMARK;
            parameters[11].Value = model.C_SCRAP;
            parameters[12].Value = model.C_SLAB_MAIN_ID;
            parameters[13].Value = model.N_PLANQUA;
            parameters[14].Value = model.N_PLANWGT;
            parameters[15].Value = model.C_ID;

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
            strSql.Append("delete from TRC_COGDOWN_PRODUCT_LOG ");
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
            strSql.Append("delete from TRC_COGDOWN_PRODUCT_LOG ");
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
        public Mod_TRC_COGDOWN_PRODUCT_LOG GetModel(string C_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_BATCH_NO,N_QUA,N_WGT,C_TRC_COGDOWN_MAIN_ID,D_MOD_DT,C_EMP_ID,C_STA_ID,N_TYPE,C_SHIFT,C_GROUP,C_REMARK,C_SCRAP,C_SLAB_MAIN_ID,N_PLANQUA,N_PLANWGT from TRC_COGDOWN_PRODUCT_LOG ");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)            };
            parameters[0].Value = C_ID;

            Mod_TRC_COGDOWN_PRODUCT_LOG model = new Mod_TRC_COGDOWN_PRODUCT_LOG();
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
        public Mod_TRC_COGDOWN_PRODUCT_LOG DataRowToModel(DataRow row)
        {
            Mod_TRC_COGDOWN_PRODUCT_LOG model = new Mod_TRC_COGDOWN_PRODUCT_LOG();
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
                if (row["N_QUA"] != null && row["N_QUA"].ToString() != "")
                {
                    model.N_QUA = decimal.Parse(row["N_QUA"].ToString());
                }
                if (row["N_WGT"] != null && row["N_WGT"].ToString() != "")
                {
                    model.N_WGT = decimal.Parse(row["N_WGT"].ToString());
                }
                if (row["C_TRC_COGDOWN_MAIN_ID"] != null)
                {
                    model.C_TRC_COGDOWN_MAIN_ID = row["C_TRC_COGDOWN_MAIN_ID"].ToString();
                }
                if (row["D_MOD_DT"] != null && row["D_MOD_DT"].ToString() != "")
                {
                    model.D_MOD_DT = DateTime.Parse(row["D_MOD_DT"].ToString());
                }
                if (row["C_EMP_ID"] != null)
                {
                    model.C_EMP_ID = row["C_EMP_ID"].ToString();
                }
                if (row["C_STA_ID"] != null)
                {
                    model.C_STA_ID = row["C_STA_ID"].ToString();
                }
                if (row["N_TYPE"] != null && row["N_TYPE"].ToString() != "")
                {
                    model.N_TYPE = decimal.Parse(row["N_TYPE"].ToString());
                }
                if (row["C_SHIFT"] != null)
                {
                    model.C_SHIFT = row["C_SHIFT"].ToString();
                }
                if (row["C_GROUP"] != null)
                {
                    model.C_GROUP = row["C_GROUP"].ToString();
                }
                if (row["C_REMARK"] != null)
                {
                    model.C_REMARK = row["C_REMARK"].ToString();
                }
                if (row["C_SCRAP"] != null && row["C_SCRAP"].ToString() != "")
                {
                    model.C_SCRAP = decimal.Parse(row["C_SCRAP"].ToString());
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
            strSql.Append("select C_ID,C_BATCH_NO,N_QUA,N_WGT,C_TRC_COGDOWN_MAIN_ID,D_MOD_DT,C_EMP_ID,C_STA_ID,N_TYPE,C_SHIFT,C_GROUP,C_REMARK,C_SCRAP,C_SLAB_MAIN_ID,N_PLANQUA,N_PLANWGT ");
            strSql.Append(" FROM TRC_COGDOWN_PRODUCT_LOG ");
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
            strSql.Append("select count(1) FROM TRC_COGDOWN_PRODUCT_LOG ");
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
            strSql.Append(")AS Row, T.*  from TRC_COGDOWN_PRODUCT_LOG T ");
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
					new OracleParameter(":PageSize", OracleDbType.Decimal),
					new OracleParameter(":PageIndex", OracleDbType.Decimal),
					new OracleParameter(":IsReCount", OracleType.Clob),
					new OracleParameter(":OrderType", OracleType.Clob),
					new OracleParameter(":strWhere", OracleDbType.Varchar2,1000),
					};
			parameters[0].Value = "TRC_COGDOWN_PRODUCT_LOG";
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
