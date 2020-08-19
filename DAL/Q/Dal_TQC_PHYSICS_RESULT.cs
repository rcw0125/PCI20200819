using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;
using System.Collections;

namespace DAL
{
    /// <summary>
    /// 数据访问类:TQC_PHYSICS_RESULT
    /// </summary>
    public partial class Dal_TQC_PHYSICS_RESULT
    {
        public Dal_TQC_PHYSICS_RESULT()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string C_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TQC_PHYSICS_RESULT");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)          };
            parameters[0].Value = C_ID;

            return DbHelperOra.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Mod_TQC_PHYSICS_RESULT model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TQC_PHYSICS_RESULT(");
            strSql.Append("C_PHYSICS_GROUP_ID,C_PRESENT_SAMPLES_ID,C_CHARACTER_ID,C_CHARACTER_CODE,C_CHARACTER_NAME,C_VALUE,N_STATUS,C_REMARK,C_EMP_ID,N_SPLIT,N_TYPE,C_CHECK_STATE,C_TICK_NO,C_GROUP)");
            strSql.Append(" values (");
            strSql.Append(":C_PHYSICS_GROUP_ID,:C_PRESENT_SAMPLES_ID,:C_CHARACTER_ID,:C_CHARACTER_CODE,:C_CHARACTER_NAME,:C_VALUE,:N_STATUS,:C_REMARK,:C_EMP_ID,:N_SPLIT,:N_TYPE,:C_CHECK_STATE,:C_TICK_NO,:C_GROUP)");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_PHYSICS_GROUP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PRESENT_SAMPLES_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CHARACTER_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CHARACTER_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CHARACTER_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_VALUE", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_SPLIT", OracleDbType.Decimal,1),
                    new OracleParameter(":N_TYPE", OracleDbType.Decimal,1),
                    new OracleParameter(":C_CHECK_STATE", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_TICK_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_GROUP", OracleDbType.Varchar2,10)};
            parameters[0].Value = model.C_PHYSICS_GROUP_ID;
            parameters[1].Value = model.C_PRESENT_SAMPLES_ID;
            parameters[2].Value = model.C_CHARACTER_ID;
            parameters[3].Value = model.C_CHARACTER_CODE;
            parameters[4].Value = model.C_CHARACTER_NAME;
            parameters[5].Value = model.C_VALUE;
            parameters[6].Value = model.N_STATUS;
            parameters[7].Value = model.C_REMARK;
            parameters[8].Value = model.C_EMP_ID;
            parameters[9].Value = model.N_SPLIT;
            parameters[10].Value = model.N_TYPE;
            parameters[11].Value = model.C_CHECK_STATE;
            parameters[12].Value = model.C_TICK_NO;
            parameters[13].Value = model.C_GROUP;

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
        public bool Add_Trans(Mod_TQC_PHYSICS_RESULT model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TQC_PHYSICS_RESULT(");
            strSql.Append("C_PHYSICS_GROUP_ID,C_PRESENT_SAMPLES_ID,C_CHARACTER_ID,C_CHARACTER_CODE,C_CHARACTER_NAME,C_VALUE,N_STATUS,C_REMARK,C_EMP_ID,N_SPLIT,N_TYPE,C_CHECK_STATE,C_TICK_NO,C_GROUP)");
            strSql.Append(" values (");
            strSql.Append(":C_PHYSICS_GROUP_ID,:C_PRESENT_SAMPLES_ID,:C_CHARACTER_ID,:C_CHARACTER_CODE,:C_CHARACTER_NAME,:C_VALUE,:N_STATUS,:C_REMARK,:C_EMP_ID,:N_SPLIT,:N_TYPE,:C_CHECK_STATE,:C_TICK_NO,:C_GROUP)");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_PHYSICS_GROUP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PRESENT_SAMPLES_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CHARACTER_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CHARACTER_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CHARACTER_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_VALUE", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_SPLIT", OracleDbType.Decimal,1),
                    new OracleParameter(":N_TYPE", OracleDbType.Decimal,1),
                    new OracleParameter(":C_CHECK_STATE", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_TICK_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_GROUP", OracleDbType.Varchar2,10)};
            parameters[0].Value = model.C_PHYSICS_GROUP_ID;
            parameters[1].Value = model.C_PRESENT_SAMPLES_ID;
            parameters[2].Value = model.C_CHARACTER_ID;
            parameters[3].Value = model.C_CHARACTER_CODE;
            parameters[4].Value = model.C_CHARACTER_NAME;
            parameters[5].Value = model.C_VALUE;
            parameters[6].Value = model.N_STATUS;
            parameters[7].Value = model.C_REMARK;
            parameters[8].Value = model.C_EMP_ID;
            parameters[9].Value = model.N_SPLIT;
            parameters[10].Value = model.N_TYPE;
            parameters[11].Value = model.C_CHECK_STATE;
            parameters[12].Value = model.C_TICK_NO;
            parameters[13].Value = model.C_GROUP;

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
        public bool Update(Mod_TQC_PHYSICS_RESULT model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TQC_PHYSICS_RESULT set ");
            strSql.Append("C_PHYSICS_GROUP_ID=:C_PHYSICS_GROUP_ID,");
            strSql.Append("C_PRESENT_SAMPLES_ID=:C_PRESENT_SAMPLES_ID,");
            strSql.Append("C_CHARACTER_ID=:C_CHARACTER_ID,");
            strSql.Append("C_CHARACTER_CODE=:C_CHARACTER_CODE,");
            strSql.Append("C_CHARACTER_NAME=:C_CHARACTER_NAME,");
            strSql.Append("C_VALUE=:C_VALUE,");
            strSql.Append("N_STATUS=:N_STATUS,");
            strSql.Append("C_REMARK=:C_REMARK,");
            strSql.Append("C_EMP_ID=:C_EMP_ID,");
            strSql.Append("D_MOD_DT=:D_MOD_DT,");
            strSql.Append("N_SPLIT=:N_SPLIT,");
            strSql.Append("N_TYPE=:N_TYPE,");
            strSql.Append("C_CHECK_STATE=:C_CHECK_STATE,");
            strSql.Append("C_TICK_NO=:C_TICK_NO,");
            strSql.Append("C_GROUP=:C_GROUP");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_PHYSICS_GROUP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PRESENT_SAMPLES_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CHARACTER_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CHARACTER_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_CHARACTER_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_VALUE", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":N_SPLIT", OracleDbType.Decimal,1),
                    new OracleParameter(":N_TYPE", OracleDbType.Decimal,1),
                    new OracleParameter(":C_CHECK_STATE", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_TICK_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_GROUP", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.C_PHYSICS_GROUP_ID;
            parameters[1].Value = model.C_PRESENT_SAMPLES_ID;
            parameters[2].Value = model.C_CHARACTER_ID;
            parameters[3].Value = model.C_CHARACTER_CODE;
            parameters[4].Value = model.C_CHARACTER_NAME;
            parameters[5].Value = model.C_VALUE;
            parameters[6].Value = model.N_STATUS;
            parameters[7].Value = model.C_REMARK;
            parameters[8].Value = model.C_EMP_ID;
            parameters[9].Value = model.D_MOD_DT;
            parameters[10].Value = model.N_SPLIT;
            parameters[11].Value = model.N_TYPE;
            parameters[12].Value = model.C_CHECK_STATE;
            parameters[13].Value = model.C_TICK_NO;
            parameters[14].Value = model.C_GROUP;
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
        public bool Delete(string C_PHYSICS_GROUP_ID, string C_PRESENT_SAMPLES_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from TQC_PHYSICS_RESULT ");
            strSql.Append(" where C_PHYSICS_GROUP_ID=:C_PHYSICS_GROUP_ID and C_PRESENT_SAMPLES_ID=:C_PRESENT_SAMPLES_ID ");
            OracleParameter[] parameters = {
                new OracleParameter(":C_PHYSICS_GROUP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PRESENT_SAMPLES_ID", OracleDbType.Varchar2,100)          };
            parameters[0].Value = C_PHYSICS_GROUP_ID;
            parameters[1].Value = C_PRESENT_SAMPLES_ID;

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
        public bool Delete_Trans(string C_PHYSICS_GROUP_ID, string C_PRESENT_SAMPLES_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from TQC_PHYSICS_RESULT ");
            strSql.Append(" where C_PHYSICS_GROUP_ID=:C_PHYSICS_GROUP_ID and C_PRESENT_SAMPLES_ID=:C_PRESENT_SAMPLES_ID ");
            OracleParameter[] parameters = {
                new OracleParameter(":C_PHYSICS_GROUP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_PRESENT_SAMPLES_ID", OracleDbType.Varchar2,100)          };
            parameters[0].Value = C_PHYSICS_GROUP_ID;
            parameters[1].Value = C_PRESENT_SAMPLES_ID;

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
        /// 批量删除数据
        /// </summary>
        public bool DeleteList(string C_IDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from TQC_PHYSICS_RESULT ");
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
        public Mod_TQC_PHYSICS_RESULT GetModel(string C_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_PHYSICS_GROUP_ID,C_PRESENT_SAMPLES_ID,C_CHARACTER_ID,C_CHARACTER_CODE,C_CHARACTER_NAME,C_VALUE,N_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT,N_SPLIT,N_TYPE,C_CHECK_STATE,C_TICK_NO,C_GROUP from TQC_PHYSICS_RESULT ");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)          };
            parameters[0].Value = C_ID;

            Mod_TQC_PHYSICS_RESULT model = new Mod_TQC_PHYSICS_RESULT();
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
        public Mod_TQC_PHYSICS_RESULT DataRowToModel(DataRow row)
        {
            Mod_TQC_PHYSICS_RESULT model = new Mod_TQC_PHYSICS_RESULT();
            if (row != null)
            {
                if (row["C_ID"] != null)
                {
                    model.C_ID = row["C_ID"].ToString();
                }
                if (row["C_PHYSICS_GROUP_ID"] != null)
                {
                    model.C_PHYSICS_GROUP_ID = row["C_PHYSICS_GROUP_ID"].ToString();
                }
                if (row["C_PRESENT_SAMPLES_ID"] != null)
                {
                    model.C_PRESENT_SAMPLES_ID = row["C_PRESENT_SAMPLES_ID"].ToString();
                }
                if (row["C_CHARACTER_ID"] != null)
                {
                    model.C_CHARACTER_ID = row["C_CHARACTER_ID"].ToString();
                }
                if (row["C_CHARACTER_CODE"] != null)
                {
                    model.C_CHARACTER_CODE = row["C_CHARACTER_CODE"].ToString();
                }
                if (row["C_CHARACTER_NAME"] != null)
                {
                    model.C_CHARACTER_NAME = row["C_CHARACTER_NAME"].ToString();
                }
                if (row["C_VALUE"] != null)
                {
                    model.C_VALUE = row["C_VALUE"].ToString();
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
                if (row["N_SPLIT"] != null && row["N_SPLIT"].ToString() != "")
                {
                    model.N_STATUS = decimal.Parse(row["N_SPLIT"].ToString());
                }
                if (row["N_TYPE"] != null && row["N_TYPE"].ToString() != "")
                {
                    model.N_TYPE = decimal.Parse(row["N_TYPE"].ToString());
                }
                if (row["C_CHECK_STATE"] != null)
                {
                    model.C_CHECK_STATE = row["C_CHECK_STATE"].ToString();
                }
                if (row["C_TICK_NO"] != null)
                {
                    model.C_TICK_NO = row["C_TICK_NO"].ToString();
                }
                if (row["C_GROUP"] != null)
                {
                    model.C_GROUP = row["C_GROUP"].ToString();
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
            strSql.Append("select C_ID,C_PHYSICS_GROUP_ID,C_PRESENT_SAMPLES_ID,C_CHARACTER_ID,C_CHARACTER_CODE,C_CHARACTER_NAME,C_VALUE,N_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT,N_SPLIT,N_TYPE,C_CHECK_STATE,C_TICK_NO,C_GROUP ");
            strSql.Append(" FROM TQC_PHYSICS_RESULT ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 按时间和批号获取物理性能详细信息
        /// </summary>
        /// <param name="P_CODE">物理分组编码</param>
        /// <param name="P_BATCH">批号</param>
        /// <param name="P_START">制样时间（最小）</param>
        /// <param name="P_END">制样时间（最大）</param>
        /// <param name="P_TYPE">类型 0未同步综合判定的数据；1所有数据</param>
        /// <returns></returns>
		public DataSet Get_List(string P_CODE, string P_BATCH, string P_START, string P_END, string P_TYPE)
        {
            OracleParameter[] parameters = {
                    new OracleParameter("P_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter("P_BATCH", OracleDbType.Varchar2,100),
                    new OracleParameter("P_START", OracleDbType.Varchar2,100),
                    new OracleParameter("P_END", OracleDbType.Varchar2,100),
                    new OracleParameter("P_TYPE", OracleDbType.Varchar2,1),
                    new OracleParameter("P_CUR", OracleDbType.RefCursor)};

            parameters[0].Value = P_CODE;
            parameters[1].Value = P_BATCH;
            parameters[2].Value = P_START;
            parameters[3].Value = P_END;
            parameters[4].Value = P_TYPE;
            parameters[5].Value = null;

            return DbHelperOra.RunProcedure("PKG_XN.P_ZY_XN_ITEMS", parameters, "ds");
        }

        /// <summary>
        /// 按时间和批号获取物理性能详细信息
        /// </summary>
        /// <param name="P_CODE">物理分组编码</param>
        /// <param name="P_BATCH">批号</param>
        /// <param name="P_START">制样时间（最小）</param>
        /// <param name="P_END">制样时间（最大）</param>
        /// <param name="P_TYPE">类型 0未同步综合判定的数据；1所有数据</param>
        /// <returns></returns>
		public DataSet Get_Result_List(string P_CODE, string P_BATCH, string P_START, string P_END, string P_TYPE, string P_STLGRD)
        {
            OracleParameter[] parameters = {
                    new OracleParameter("P_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter("P_BATCH", OracleDbType.Varchar2,100),
                    new OracleParameter("P_START", OracleDbType.Varchar2,100),
                    new OracleParameter("P_END", OracleDbType.Varchar2,100),
                    new OracleParameter("P_TYPE", OracleDbType.Varchar2,1),
                    new OracleParameter("P_STLGRD", OracleDbType.Varchar2,100),
                    new OracleParameter("P_CUR", OracleDbType.RefCursor)};

            parameters[0].Value = P_CODE;
            parameters[1].Value = P_BATCH;
            parameters[2].Value = P_START;
            parameters[3].Value = P_END;
            parameters[4].Value = P_TYPE;
            parameters[5].Value = P_STLGRD;
            parameters[6].Value = null;

            return DbHelperOra.RunProcedure("PKG_XN.P_XN_RESULT", parameters, "ds");
        }

        /// <summary>
        /// 按时间和批号获取物理性能修改信息
        /// </summary>
        /// <param name="P_CODE">物理分组编码</param>
        /// <param name="P_BATCH">批号</param>
        /// <param name="P_START">制样时间（最小）</param>
        /// <param name="P_END">制样时间（最大）</param>
        /// <param name="P_CHECK_STATE">检验状态；0-初检；1-复检；2-评审</param>
        /// <returns></returns>
		public DataSet Get_Log_List(string P_CODE, string P_BATCH, string P_START, string P_END, string P_CHECK_STATE)
        {
            OracleParameter[] parameters = {
                    new OracleParameter("P_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter("P_BATCH", OracleDbType.Varchar2,100),
                    new OracleParameter("P_START", OracleDbType.Varchar2,100),
                    new OracleParameter("P_END", OracleDbType.Varchar2,100),
                    new OracleParameter("P_CHECK_STATE", OracleDbType.Varchar2,100),
                    new OracleParameter("P_CUR", OracleDbType.RefCursor)};

            parameters[0].Value = P_CODE;
            parameters[1].Value = P_BATCH;
            parameters[2].Value = P_START;
            parameters[3].Value = P_END;
            parameters[4].Value = P_CHECK_STATE;
            parameters[5].Value = null;

            return DbHelperOra.RunProcedure("PKG_XN.P_XN_ITEMS_LOG", parameters, "ds");
        }

        /// <summary>
        /// 物理性能详细信息
        /// </summary>
        /// <param name="P_CODE">物理分组编码</param>
        /// <returns></returns>
        public DataSet Get_List(string P_CODE)
        {
            OracleParameter[] parameters = {
                    new OracleParameter("P_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter("P_CUR", OracleDbType.RefCursor)};

            parameters[0].Value = P_CODE;
            parameters[1].Value = null;

            return DbHelperOra.RunProcedure("PKG_XN.P_XN_ITEMS", parameters, "ds");
        }

        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM TQC_PHYSICS_RESULT ");
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
        /// 保存性能结果信息
        /// </summary>
        public bool SaveResult(ArrayList SQLStringList)
        {
            return DbHelperOra.ExecuteSqlTran(SQLStringList);
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet Get_XNList(string C_CODE, string C_PRESENT_SAMPLES_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT TM.C_CHARACTER_ID,TM.C_PHYSICS_GROUP_ID,TM.C_CODE,TM.C_NAME,TQ.C_VALUE,TM.N_ORDER  FROM(SELECT C_ID AS C_CHARACTER_ID, C_PHYSICS_GROUP_ID, C_CODE, C_NAME, N_ORDER FROM(SELECT TA.C_ID, TA.C_PHYSICS_GROUP_ID, TA.C_CODE, TA.C_NAME, TA.N_ORDER FROM TQB_XN_CHECK_PROCEDURE TA INNER JOIN TQB_PHYSICS_GROUP TB ON TA.C_PHYSICS_GROUP_ID = TB.C_ID WHERE TB.C_CODE = '" + C_CODE + "' AND TA.N_STATUS = 1 ORDER BY TA.N_ORDER) UNION ALL SELECT C_CHARACTER_ID, C_PHYSICS_GROUP_ID, C_CODE, C_NAME, N_ORDER FROM(SELECT TA.C_CHARACTER_ID, TA.C_PHYSICS_GROUP_ID, TC.C_CODE, TC.C_NAME, TO_NUMBER(nvl(TA.C_ORDER, 999)) as N_ORDER FROM TQB_PHYSICS_CONFIGURE TA INNER JOIN TQB_PHYSICS_GROUP TB ON TA.C_PHYSICS_GROUP_ID = TB.C_ID INNER JOIN TQB_CHARACTER TC ON TA.C_CHARACTER_ID = TC.C_ID WHERE TB.C_CODE = '" + C_CODE + "' AND TA.N_STATUS = 1 ORDER BY TO_NUMBER(nvl(TA.C_ORDER, 999)))) TM  LEFT JOIN(select tp.c_value, tp.c_character_id from TQC_PHYSICS_RESULT tp where tp.C_PRESENT_SAMPLES_ID = '" + C_PRESENT_SAMPLES_ID + "' ORDER BY TP.C_CHARACTER_CODE) TQ ON TM.C_CHARACTER_ID = TQ.C_CHARACTER_ID ORDER BY DECODE(SUBSTR(TM.C_CODE,1,1),'0','0','1'),TM.N_ORDER ");


            //strSql.Append("SELECT TM.C_CHARACTER_ID, TM.C_PHYSICS_GROUP_ID, TM.C_CODE, TM.C_NAME,TQ.C_VALUE  FROM(SELECT TA.C_CHARACTER_ID, TA.C_PHYSICS_GROUP_ID, TC.C_CODE, TC.C_NAME FROM TQB_PHYSICS_CONFIGURE TA INNER JOIN TQB_PHYSICS_GROUP TB ON TA.C_PHYSICS_GROUP_ID = TB.C_ID INNER JOIN TQB_CHARACTER TC ON TA.C_CHARACTER_ID = TC.C_ID WHERE TB.C_CODE = '" + C_CODE + "' AND TA.N_STATUS = 1 UNION ALL SELECT TA.C_ID, TA.C_PHYSICS_GROUP_ID, TA.C_CODE, TA.C_NAME FROM TQB_XN_CHECK_PROCEDURE TA INNER JOIN TQB_PHYSICS_GROUP TB ON TA.C_PHYSICS_GROUP_ID = TB.C_ID WHERE TB.C_CODE = '" + C_CODE + "' AND TA.N_STATUS = 1) TM  LEFT JOIN (select tp.c_value,tp.c_character_id from TQC_PHYSICS_RESULT tp where tp.C_PRESENT_SAMPLES_ID = '" + C_PRESENT_SAMPLES_ID + "') TQ ON TM.C_CHARACTER_ID = TQ.C_CHARACTER_ID ORDER BY TM.C_CODE,TM.C_CHARACTER_ID ");

            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet Get_XNAllList(string BatchNo)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" SELECT TM.C_CHARACTER_ID,TM.C_PHYSICS_GROUP_ID,TM.C_CODE,TM.C_NAME,TQ.C_VALUE,tq.c_tick_no FROM (SELECT TA.C_CHARACTER_ID,TA.C_PHYSICS_GROUP_ID,TC.C_CODE,TC.C_NAME FROM TQB_PHYSICS_CONFIGURE TA INNER JOIN TQB_PHYSICS_GROUP TB ON TA.C_PHYSICS_GROUP_ID = TB.C_ID INNER JOIN TQB_CHARACTER TC ON TA.C_CHARACTER_ID = TC.C_ID WHERE TA.N_STATUS = 1 ) TM JOIN (select tp.c_value, tp.c_character_id,tp.c_tick_no from TQC_PHYSICS_RESULT tp join tqc_physics_result_main t1 on tp.c_present_samples_id=t1.c_id where t1.c_batch_no = '" + BatchNo + "' and tp.c_value is not null ) TQ  ON TM.C_CHARACTER_ID = TQ.C_CHARACTER_ID ORDER BY TM.C_CODE, TM.C_CHARACTER_ID ");
            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet Get_XN(string C_PRESENT_SAMPLES_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" SELECT TM.C_CHARACTER_ID,TM.C_PHYSICS_GROUP_ID,TM.C_CODE,TM.C_NAME,TQ.C_VALUE,tq.c_tick_no FROM (SELECT TA.C_CHARACTER_ID,TA.C_PHYSICS_GROUP_ID,TC.C_CODE,TC.C_NAME FROM TQB_PHYSICS_CONFIGURE TA INNER JOIN TQB_PHYSICS_GROUP TB ON TA.C_PHYSICS_GROUP_ID = TB.C_ID INNER JOIN TQB_CHARACTER TC ON TA.C_CHARACTER_ID = TC.C_ID WHERE TA.N_STATUS = 1 UNION ALL SELECT TA.C_ID,TA.C_PHYSICS_GROUP_ID, TA.C_CODE, TA.C_NAME FROM TQB_XN_CHECK_PROCEDURE TA INNER JOIN TQB_PHYSICS_GROUP TB ON TA.C_PHYSICS_GROUP_ID = TB.C_ID WHERE TA.N_STATUS = 1) TM JOIN (select tp.c_value, tp.c_character_id,tp.c_tick_no from TQC_PHYSICS_RESULT tp join tqc_physics_result_main t1 on tp.c_present_samples_id=t1.c_id where tp.C_PRESENT_SAMPLES_ID = '" + C_PRESENT_SAMPLES_ID + "' ) TQ  ON TM.C_CHARACTER_ID = TQ.C_CHARACTER_ID ORDER BY TM.C_CODE, TM.C_CHARACTER_ID  ");
            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet Get_Character_List(string C_CODE)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT C_CHARACTER_ID, C_PHYSICS_GROUP_ID, C_CODE, C_NAME FROM(SELECT TA.C_ID AS C_CHARACTER_ID, TA.C_PHYSICS_GROUP_ID, TA.C_CODE, TA.C_NAME FROM TQB_XN_CHECK_PROCEDURE TA INNER JOIN TQB_PHYSICS_GROUP TB ON TA.C_PHYSICS_GROUP_ID = TB.C_ID WHERE TB.C_CODE = '" + C_CODE + "' AND TA.N_STATUS = 1 ORDER BY TA.N_ORDER) UNION ALL SELECT C_CHARACTER_ID, C_PHYSICS_GROUP_ID, C_CODE, C_NAME FROM(SELECT TA.C_CHARACTER_ID, TA.C_PHYSICS_GROUP_ID, TC.C_CODE, TC.C_NAME FROM TQB_PHYSICS_CONFIGURE TA INNER JOIN TQB_PHYSICS_GROUP TB ON TA.C_PHYSICS_GROUP_ID = TB.C_ID INNER JOIN TQB_CHARACTER TC ON TA.C_CHARACTER_ID = TC.C_ID WHERE TB.C_CODE = '" + C_CODE + "' AND TA.N_STATUS = 1 ORDER BY TO_NUMBER(TA.C_ORDER)) ");

            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 性能结果信息列表
        /// </summary>
        /// <param name="time_Start">开始时间</param>
        /// <param name="time_End">结束时间</param>
        /// <param name="strBatch">批号</param>
        /// <param name="str_PHYSICS_GROUP_ID">物理性能分组ID</param>
        /// <param name="C_CHECK_DEPMT">部门</param>
        /// <returns></returns>
        public DataSet Get_XN_List(string time_Start, string time_End, string strBatch, string C_CHECK_DEPMT)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT TA.C_ID AS 取样主表主键,TD.C_ID as 性能主键,TD.C_CODE AS 性能代码,TD.C_NAME as 性能名称,TA.C_BATCH_NO AS 批号,TA.C_TICK_NO AS 钩号,TB.C_STOVE AS 炉号,TA.C_STL_GRD AS 钢种,TA.C_SPEC AS 规格,TB.C_STD_CODE AS 执行标准,TO_CHAR(MAX(TA.D_MOD_DT_ZY), 'YYYY-MM-DD  HH24:MI:SS') AS 制样时间,TO_CHAR(MAX(TC.D_MOD_DT), 'YYYY-MM-DD HH24:MI:SS') AS 录入时间,MAX(TC.C_EMP_ID) AS C_EMP_ID,TA.C_EQ_NAME AS 设备信息,DECODE(TA.C_CHECK_STATE, '0', '初检', '1', '复检') AS 检验状态,decode(TA.C_IS_PD,'0','未判','1','已判','')as 判定状态  FROM tqc_physics_result_main TA  left JOIN trc_roll_main TB    ON TA.C_BATCH_NO = TB.C_BATCH_NO  left JOIN TQC_PHYSICS_RESULT TC ON TC.C_PRESENT_SAMPLES_ID = TA.C_ID left JOIN TQB_PHYSICS_GROUP TD ON TD.C_ID = TA.C_PHYSICS_GROUP_ID WHERE 1=1  ");

            if (!string.IsNullOrEmpty(time_Start) && !string.IsNullOrEmpty(time_End))
            {
                strSql.Append(" AND TA.D_MOD_DT_ZY BETWEEN TO_DATE('" + time_Start + "','YYYY-MM-DD HH24:MI:SS') AND TO_DATE('" + time_End + "','YYYY-MM-DD HH24:MI:SS') ");
            }

            if (!string.IsNullOrEmpty(strBatch.Trim()))
            {
                strSql.Append(" and TA.C_BATCH_NO='" + strBatch.Trim() + "' ");
            }
            if (!string.IsNullOrEmpty(C_CHECK_DEPMT.Trim()))
            {
                strSql.Append(" and td.C_CHECK_DEPMT='" + C_CHECK_DEPMT.Trim() + "' ");
            }
            strSql.Append(" GROUP BY TA.C_BATCH_NO, TA.C_TICK_NO, TB.C_STOVE, TA.C_STL_GRD, TA.C_SPEC, TB.C_STD_CODE, TA.C_ID, ta.C_EQ_NAME, TA.C_CHECK_STATE, TA.C_IS_PD, TD.C_NAME,TD.C_ID,TD.C_CODE ORDER BY TA.C_BATCH_NO DESC,TD.C_NAME,to_number(case when instr(ta.C_TICK_NO, '-') > 0 then substr(ta.C_TICK_NO, 1, instr(ta.C_TICK_NO, '-') - 1) else ta.C_TICK_NO end) ASC ");

            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 性能结果信息列表
        /// </summary>
        /// <param name="time_Start">开始时间</param>
        /// <param name="time_End">结束时间</param>
        /// <param name="strBatch">批号</param> 
        /// <returns></returns>
        public DataSet Get_XN_CWSX_List(string time_Start, string time_End, string strBatch)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT t2.C_PCINFO as 特殊信息 ,TA.C_ID AS 取样主表主键,TD.C_ID as 性能主键,TD.C_CODE AS 性能代码,TD.C_NAME as 性能名称,TA.C_BATCH_NO AS 批号,TA.C_TICK_NO AS 钩号,TB.C_STOVE AS 炉号,TA.C_STL_GRD AS 钢种,TA.C_SPEC AS 规格,TB.C_STD_CODE AS 执行标准,TO_CHAR(MAX(TA.D_MOD_DT_ZY), 'YYYY-MM-DD  HH24:MI:SS') AS 制样时间,TO_CHAR(MAX(TC.D_MOD_DT), 'YYYY-MM-DD HH24:MI:SS') AS 录入时间,MAX(TC.C_EMP_ID) AS C_EMP_ID,TA.C_EQ_NAME AS 设备信息,DECODE(TA.C_CHECK_STATE, '0', '初检', '1', '复检') AS 检验状态,decode(TA.C_IS_PD,'0','未判','1','已判','')as 判定状态 FROM tqc_physics_result_main TA join  (select t1.c_batch_no,t1.C_PCINFO from tqc_compre_roll t1  where t1.n_status=1 and t1.C_PCINFO='厂外时效' group by t1.c_batch_no,t1.C_PCINFO  )t2 on  t2.c_batch_no=ta.c_batch_no  INNER JOIN trc_roll_main TB    ON TA.C_BATCH_NO = TB.C_BATCH_NO  left JOIN TQC_PHYSICS_RESULT TC ON TC.C_PRESENT_SAMPLES_ID = TA.C_ID left JOIN TQB_PHYSICS_GROUP TD ON TD.C_ID = TA.C_PHYSICS_GROUP_ID WHERE 1=1   ");

            if (!string.IsNullOrEmpty(time_Start) && !string.IsNullOrEmpty(time_End))
            {
                strSql.Append(" AND (TC.D_MOD_DT BETWEEN TO_DATE('" + time_Start + "','YYYY-MM-DD HH24:MI:SS') AND TO_DATE('" + time_End + "','YYYY-MM-DD HH24:MI:SS')  or TC.D_MOD_DT is null) ");
            }
            if (!string.IsNullOrEmpty(strBatch.Trim()))
            {
                strSql.Append(" and TA.C_BATCH_NO='" + strBatch.Trim() + "' ");
            }
            strSql.Append(" GROUP BY t2.C_PCINFO, TA.C_BATCH_NO, TA.C_TICK_NO, TB.C_STOVE, TA.C_STL_GRD, TA.C_SPEC, TB.C_STD_CODE, TA.C_ID, ta.C_EQ_NAME, TA.C_CHECK_STATE, TA.C_IS_PD, TD.C_NAME,TD.C_ID,TD.C_CODE  ORDER BY TA.C_BATCH_NO DESC,TD.C_NAME,to_number(case when instr(ta.C_TICK_NO, '-') > 0 then substr(ta.C_TICK_NO, 1, instr(ta.C_TICK_NO, '-') - 1) else ta.C_TICK_NO end) ASC");

            return DbHelperOra.Query(strSql.ToString());
        }


        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int Get_Count(string C_PRESENT_SAMPLES_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from tqc_physics_result t where t.C_PRESENT_SAMPLES_ID='" + C_PRESENT_SAMPLES_ID + "' ");

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
        /// 获取厂外时效性能结果
        /// </summary>
        /// <param name="P_CODE">物理分组编码</param>
        /// <param name="P_BATCH">批号</param>
        /// <param name="P_START">制样时间（最小）</param>
        /// <param name="P_END">制样时间（最大）</param>
        /// <param name="P_TYPE">类型 0未同步综合判定的数据；1所有数据</param>
        /// <returns></returns>
		public DataSet Get_CWSX_List(string P_CODE, string P_BATCH, string P_START, string P_END, string P_TYPE)
        {
            OracleParameter[] parameters = {
                    new OracleParameter("P_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter("P_BATCH", OracleDbType.Varchar2,100),
                    new OracleParameter("P_START", OracleDbType.Varchar2,100),
                    new OracleParameter("P_END", OracleDbType.Varchar2,100),
                    new OracleParameter("P_TYPE", OracleDbType.Varchar2,1),
                    new OracleParameter("P_CUR", OracleDbType.RefCursor)};

            parameters[0].Value = P_CODE;
            parameters[1].Value = P_BATCH;
            parameters[2].Value = P_START;
            parameters[3].Value = P_END;
            parameters[4].Value = P_TYPE;
            parameters[5].Value = null;

            return DbHelperOra.RunProcedure("PKG_XN.P_CWSX_XN_ITEMS", parameters, "ds");
        }


        #endregion  BasicMethod
        #region  ExtensionMethod

        #endregion  ExtensionMethod
    }
}

