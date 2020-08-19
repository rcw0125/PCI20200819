using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;

namespace DAL
{
    /// <summary>
    /// 数据访问类:TQC_RESULT_MAIN_ZJB
    /// </summary>
    public partial class Dal_TQC_RESULT_MAIN_ZJB
    {
        public Dal_TQC_RESULT_MAIN_ZJB()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string C_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TQC_RESULT_MAIN_ZJB");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)         };
            parameters[0].Value = C_ID;

            return DbHelperOra.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Mod_TQC_RESULT_MAIN_ZJB model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TQC_RESULT_MAIN_ZJB(");
            strSql.Append("C_BATCH_NO,C_TICK_NO,C_STL_GRD,C_SPEC,C_EMP_ID,D_MOD_DT,C_EMP_ID_ZY,D_MOD_DT_ZY,C_EMP_ID_JS,D_MOD_DT_JS,C_PHYSICS_GROUP_ID,C_CHECK_STATE,N_RECHECK,N_STATUS,C_REMARK,C_DISPOSAL ,C_QRZT,C_ITEM_NAME)");
            strSql.Append(" values (");
            strSql.Append(":C_BATCH_NO,:C_TICK_NO,:C_STL_GRD,:C_SPEC,:C_EMP_ID,:D_MOD_DT,:C_EMP_ID_ZY,:D_MOD_DT_ZY,:C_EMP_ID_JS,:D_MOD_DT_JS,:C_PHYSICS_GROUP_ID,:C_CHECK_STATE,:N_RECHECK,:N_STATUS,:C_REMARK,:C_DISPOSAL ,:C_QRZT,:C_ITEM_NAME)");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_BATCH_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_TICK_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STL_GRD", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SPEC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":C_EMP_ID_ZY", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT_ZY", OracleDbType.Date),
                    new OracleParameter(":C_EMP_ID_JS", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT_JS", OracleDbType.Date),
                    new OracleParameter(":C_PHYSICS_GROUP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CHECK_STATE", OracleDbType.Varchar2,10),
                    new OracleParameter(":N_RECHECK", OracleDbType.Decimal,2),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_DISPOSAL", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_QRZT", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ITEM_NAME", OracleDbType.Varchar2,100)
                };
            parameters[0].Value = model.C_BATCH_NO;
            parameters[1].Value = model.C_TICK_NO;
            parameters[2].Value = model.C_STL_GRD;
            parameters[3].Value = model.C_SPEC;
            parameters[4].Value = model.C_EMP_ID;
            parameters[5].Value = model.D_MOD_DT;
            parameters[6].Value = model.C_EMP_ID_ZY;
            parameters[7].Value = model.D_MOD_DT_ZY;
            parameters[8].Value = model.C_EMP_ID_JS;
            parameters[9].Value = model.D_MOD_DT_JS;
            parameters[10].Value = model.C_PHYSICS_GROUP_ID;
            parameters[11].Value = model.C_CHECK_STATE;
            parameters[12].Value = model.N_RECHECK;
            parameters[13].Value = model.N_STATUS;
            parameters[14].Value = model.C_REMARK;
            parameters[15].Value = model.C_DISPOSAL;
            parameters[16].Value = model.C_QRZT;
            parameters[17].Value = model.C_ITEM_NAME;

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
        public bool Add_Trans(Mod_TQC_RESULT_MAIN_ZJB model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TQC_RESULT_MAIN_ZJB(");
            strSql.Append("C_BATCH_NO,C_TICK_NO,C_STL_GRD,C_SPEC,C_EMP_ID,D_MOD_DT,C_EMP_ID_ZY,D_MOD_DT_ZY,C_EMP_ID_JS,D_MOD_DT_JS,C_PHYSICS_GROUP_ID,C_CHECK_STATE,N_RECHECK,N_STATUS,C_REMARK,C_DISPOSAL ,C_QRZT,C_ITEM_NAME)");
            strSql.Append(" values (");
            strSql.Append(":C_BATCH_NO,:C_TICK_NO,:C_STL_GRD,:C_SPEC,:C_EMP_ID,:D_MOD_DT,:C_EMP_ID_ZY,:D_MOD_DT_ZY,:C_EMP_ID_JS,:D_MOD_DT_JS,:C_PHYSICS_GROUP_ID,:C_CHECK_STATE,:N_RECHECK,:N_STATUS,:C_REMARK,:C_DISPOSAL ,:C_QRZT,:C_ITEM_NAME)");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_BATCH_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_TICK_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STL_GRD", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SPEC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":C_EMP_ID_ZY", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT_ZY", OracleDbType.Date),
                    new OracleParameter(":C_EMP_ID_JS", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT_JS", OracleDbType.Date),
                    new OracleParameter(":C_PHYSICS_GROUP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CHECK_STATE", OracleDbType.Varchar2,10),
                    new OracleParameter(":N_RECHECK", OracleDbType.Decimal,2),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_DISPOSAL", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_QRZT", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ITEM_NAME", OracleDbType.Varchar2,100)
            };
            parameters[0].Value = model.C_BATCH_NO;
            parameters[1].Value = model.C_TICK_NO;
            parameters[2].Value = model.C_STL_GRD;
            parameters[3].Value = model.C_SPEC;
            parameters[4].Value = model.C_EMP_ID;
            parameters[5].Value = model.D_MOD_DT;
            parameters[6].Value = model.C_EMP_ID_ZY;
            parameters[7].Value = model.D_MOD_DT_ZY;
            parameters[8].Value = model.C_EMP_ID_JS;
            parameters[9].Value = model.D_MOD_DT_JS;
            parameters[10].Value = model.C_PHYSICS_GROUP_ID;
            parameters[11].Value = model.C_CHECK_STATE;
            parameters[12].Value = model.N_RECHECK;
            parameters[13].Value = model.N_STATUS;
            parameters[14].Value = model.C_REMARK;
            parameters[15].Value = model.C_DISPOSAL;
            parameters[16].Value = model.C_QRZT;
            parameters[17].Value = model.C_ITEM_NAME;

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
        public bool Update(Mod_TQC_RESULT_MAIN_ZJB model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TQC_RESULT_MAIN_ZJB set ");
            strSql.Append("C_BATCH_NO=:C_BATCH_NO,");
            strSql.Append("C_TICK_NO=:C_TICK_NO,");
            strSql.Append("C_STL_GRD=:C_STL_GRD,");
            strSql.Append("C_SPEC=:C_SPEC,");
            strSql.Append("C_EMP_ID=:C_EMP_ID,");
            strSql.Append("D_MOD_DT=:D_MOD_DT,");
            strSql.Append("C_EMP_ID_ZY=:C_EMP_ID_ZY,");
            strSql.Append("D_MOD_DT_ZY=:D_MOD_DT_ZY,");
            strSql.Append("C_EMP_ID_JS=:C_EMP_ID_JS,");
            strSql.Append("D_MOD_DT_JS=:D_MOD_DT_JS,");
            strSql.Append("C_PHYSICS_GROUP_ID=:C_PHYSICS_GROUP_ID,");
            strSql.Append("C_CHECK_STATE=:C_CHECK_STATE,");
            strSql.Append("N_RECHECK=:N_RECHECK,");
            strSql.Append("N_STATUS=:N_STATUS,");
            strSql.Append("C_REMARK=:C_REMARK,");
            strSql.Append("C_DISPOSAL=:C_DISPOSAL,");
            strSql.Append("C_QRZT=:C_QRZT,");
            strSql.Append("C_ITEM_NAME=:C_ITEM_NAME");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_BATCH_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_TICK_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STL_GRD", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SPEC", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":C_EMP_ID_ZY", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT_ZY", OracleDbType.Date),
                    new OracleParameter(":C_EMP_ID_JS", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT_JS", OracleDbType.Date),
                    new OracleParameter(":C_PHYSICS_GROUP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CHECK_STATE", OracleDbType.Varchar2,10),
                    new OracleParameter(":N_RECHECK", OracleDbType.Decimal,2),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_DISPOSAL", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_QRZT", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ITEM_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.C_BATCH_NO;
            parameters[1].Value = model.C_TICK_NO;
            parameters[2].Value = model.C_STL_GRD;
            parameters[3].Value = model.C_SPEC;
            parameters[4].Value = model.C_EMP_ID;
            parameters[5].Value = model.D_MOD_DT;
            parameters[6].Value = model.C_EMP_ID_ZY;
            parameters[7].Value = model.D_MOD_DT_ZY;
            parameters[8].Value = model.C_EMP_ID_JS;
            parameters[9].Value = model.D_MOD_DT_JS;
            parameters[10].Value = model.C_PHYSICS_GROUP_ID;
            parameters[11].Value = model.C_CHECK_STATE;
            parameters[12].Value = model.N_RECHECK;
            parameters[13].Value = model.N_STATUS;
            parameters[14].Value = model.C_REMARK;
            parameters[15].Value = model.C_DISPOSAL;
            parameters[16].Value = model.C_QRZT;
            parameters[17].Value = model.C_ITEM_NAME;
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
            strSql.Append("delete from TQC_RESULT_MAIN_ZJB ");
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
            strSql.Append("delete from TQC_RESULT_MAIN_ZJB ");
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
        public Mod_TQC_RESULT_MAIN_ZJB GetModel(string C_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_BATCH_NO,C_TICK_NO,C_STL_GRD,C_SPEC,C_EMP_ID,D_MOD_DT,C_EMP_ID_ZY,D_MOD_DT_ZY,C_EMP_ID_JS,D_MOD_DT_JS,C_PHYSICS_GROUP_ID,C_CHECK_STATE,N_RECHECK,N_STATUS,C_REMARK,C_DISPOSAL ,C_QRZT,C_ITEM_NAME from TQC_RESULT_MAIN_ZJB ");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)         };
            parameters[0].Value = C_ID;

            Mod_TQC_RESULT_MAIN_ZJB model = new Mod_TQC_RESULT_MAIN_ZJB();
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
        public Mod_TQC_RESULT_MAIN_ZJB DataRowToModel(DataRow row)
        {
            Mod_TQC_RESULT_MAIN_ZJB model = new Mod_TQC_RESULT_MAIN_ZJB();
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
                if (row["C_EMP_ID"] != null)
                {
                    model.C_EMP_ID = row["C_EMP_ID"].ToString();
                }
                if (row["D_MOD_DT"] != null && row["D_MOD_DT"].ToString() != "")
                {
                    model.D_MOD_DT = DateTime.Parse(row["D_MOD_DT"].ToString());
                }
                if (row["C_EMP_ID_ZY"] != null)
                {
                    model.C_EMP_ID_ZY = row["C_EMP_ID_ZY"].ToString();
                }
                if (row["D_MOD_DT_ZY"] != null && row["D_MOD_DT_ZY"].ToString() != "")
                {
                    model.D_MOD_DT_ZY = DateTime.Parse(row["D_MOD_DT_ZY"].ToString());
                }
                if (row["C_EMP_ID_JS"] != null)
                {
                    model.C_EMP_ID_JS = row["C_EMP_ID_JS"].ToString();
                }
                if (row["D_MOD_DT_JS"] != null && row["D_MOD_DT_JS"].ToString() != "")
                {
                    model.D_MOD_DT_JS = DateTime.Parse(row["D_MOD_DT_JS"].ToString());
                }
                if (row["C_PHYSICS_GROUP_ID"] != null)
                {
                    model.C_PHYSICS_GROUP_ID = row["C_PHYSICS_GROUP_ID"].ToString();
                }
                if (row["C_CHECK_STATE"] != null)
                {
                    model.C_CHECK_STATE = row["C_CHECK_STATE"].ToString();
                }
                if (row["N_RECHECK"] != null && row["N_RECHECK"].ToString() != "")
                {
                    model.N_RECHECK = decimal.Parse(row["N_RECHECK"].ToString());
                }
                if (row["N_STATUS"] != null && row["N_STATUS"].ToString() != "")
                {
                    model.N_STATUS = decimal.Parse(row["N_STATUS"].ToString());
                }
                if (row["C_REMARK"] != null)
                {
                    model.C_REMARK = row["C_REMARK"].ToString();
                }
                if (row["C_DISPOSAL"] != null)
                {
                    model.C_DISPOSAL = row["C_DISPOSAL"].ToString();
                }
                if (row["C_QRZT"] != null)
                {
                    model.C_QRZT = row["C_QRZT"].ToString();
                }
                if (row["C_ITEM_NAME"] != null)
                {
                    model.C_ITEM_NAME = row["C_ITEM_NAME"].ToString();
                }
            }
            return model;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(DateTime begin, DateTime end, string C_BATCH_NO,string TypeCode,string strSTATUS)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("  select T.C_ID,T.C_BATCH_NO,T1.C_CODE,T1.C_NAME,T.C_TICK_NO,T.C_STL_GRD,T.C_SPEC,T.C_EMP_ID,T.D_MOD_DT,T.C_EMP_ID_ZY,T.D_MOD_DT_ZY,T.C_EMP_ID_JS,T.D_MOD_DT_JS,T.C_PHYSICS_GROUP_ID,DECODE(T.C_CHECK_STATE,'0','初检','1','复检','2','评审') as C_CHECK_STATE,T.N_RECHECK,DECODE(T.N_STATUS,'0','已确认','1','未确认') as N_STATUS,T.C_REMARK,T.C_DISPOSAL,t.C_ITEM_NAME ,T.C_QRZT FROM TQC_RESULT_MAIN_ZJB T JOIN TQB_PHYSICS_GROUP T1 ON T.C_PHYSICS_GROUP_ID= T1.C_ID where T.N_STATUS='" + strSTATUS + "' ");
            if (begin != null && end != null)
            {
                strSql.Append(" and T.D_MOD_DT_ZY between to_date('" + Convert.ToDateTime(begin) + "','yyyy-mm-dd hh24:mi:ss') and to_date('" + Convert.ToDateTime(end) + "','yyyy-mm-dd hh24:mi:ss') ");
            }

            if (C_BATCH_NO.Trim() != "")
            {
                strSql.Append(" and T.C_BATCH_NO like '"+ C_BATCH_NO + "%' ");
            }
            if (TypeCode=="0")
            {
                strSql.Append("  AND t1.c_code NOT IN ('R17','R18','R19','R20') ");
            }
            if (TypeCode == "1")
            {
                strSql.Append("  AND t1.c_code  IN ('R17','R18','R19','R20') ");
            }

            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM TQC_RESULT_MAIN_ZJB ");
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
            strSql.Append(")AS Row, T.*  from TQC_RESULT_MAIN_ZJB T ");
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
			parameters[0].Value = "TQC_RESULT_MAIN_ZJB";
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

