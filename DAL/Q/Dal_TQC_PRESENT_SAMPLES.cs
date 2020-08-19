using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using System.Collections;
using MODEL;
namespace DAL
{
    /// <summary>
    /// 数据访问类:TQC_PRESENT_SAMPLES
    /// </summary>
    public partial class Dal_TQC_PRESENT_SAMPLES
    {
        public Dal_TQC_PRESENT_SAMPLES()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string C_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TQC_PRESENT_SAMPLES");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)          };
            parameters[0].Value = C_ID;

            return DbHelperOra.Exists(strSql.ToString(), parameters);
        }



        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Mod_TQC_PRESENT_SAMPLES model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TQC_PRESENT_SAMPLES(");
            strSql.Append(" C_BATCH_NO,C_TICK_NO,C_STL_GRD,C_SPEC,N_ENTRUST_TYPE,N_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT,C_EMP_ID_ZY,D_MOD_DT_ZY,C_EMP_ID_JS,D_MOD_DT_JS,C_EQ_NAME,C_EQ_NUMBER,C_EQ_CODE,N_SAMPLES_NUM,C_TICK_STATE,C_BC_SY,C_BZ_SY,C_BC_JY,C_BZ_JY)");
            strSql.Append(" values (");
            strSql.Append(" :C_BATCH_NO,:C_TICK_NO,:C_STL_GRD,:C_SPEC,:N_ENTRUST_TYPE,:N_STATUS,:C_REMARK,:C_EMP_ID,:D_MOD_DT,:C_EMP_ID_ZY,:D_MOD_DT_ZY,:C_EMP_ID_JS,:D_MOD_DT_JS,:C_EQ_NAME,:C_EQ_NUMBER,:C_EQ_CODE,:N_SAMPLES_NUM,:C_TICK_STATE,:C_BC_SY,:C_BZ_SY,:C_BC_JY,:C_BZ_JY)");
            OracleParameter[] parameters = {
                     new OracleParameter(":C_BATCH_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_TICK_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STL_GRD", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SPEC", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_ENTRUST_TYPE", OracleDbType.Decimal,1),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":C_EMP_ID_ZY", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT_ZY", OracleDbType.Date),
                    new OracleParameter(":C_EMP_ID_JS", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT_JS", OracleDbType.Date),
                    new OracleParameter(":C_EQ_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_EQ_NUMBER", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_EQ_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_SAMPLES_NUM", OracleDbType.Decimal,5),
                    new OracleParameter(":C_TICK_STATE", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_BC_SY", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_BZ_SY", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_BC_JY", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_BZ_JY", OracleDbType.Varchar2,10)
            };
            parameters[0].Value = model.C_BATCH_NO;
            parameters[1].Value = model.C_TICK_NO;
            parameters[2].Value = model.C_STL_GRD;
            parameters[3].Value = model.C_SPEC;
            parameters[4].Value = model.N_ENTRUST_TYPE;
            parameters[5].Value = model.N_STATUS;
            parameters[6].Value = model.C_REMARK;
            parameters[7].Value = model.C_EMP_ID;
            parameters[8].Value = model.D_MOD_DT;
            parameters[9].Value = model.C_EMP_ID_ZY;
            parameters[10].Value = model.D_MOD_DT_ZY;
            parameters[11].Value = model.C_EMP_ID_JS;
            parameters[12].Value = model.D_MOD_DT_JS;
            parameters[13].Value = model.C_EQ_NAME;
            parameters[14].Value = model.C_EQ_NUMBER;
            parameters[15].Value = model.C_EQ_CODE;
            parameters[16].Value = model.N_SAMPLES_NUM;
            parameters[17].Value = model.C_TICK_STATE;
            parameters[18].Value = model.C_BC_SY;
            parameters[19].Value = model.C_BZ_SY;
            parameters[20].Value = model.C_BC_JY;
            parameters[21].Value = model.C_BZ_JY;

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
        public bool Update(Mod_TQC_PRESENT_SAMPLES model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TQC_PRESENT_SAMPLES set ");
            strSql.Append("C_BATCH_NO=:C_BATCH_NO,");
            strSql.Append("C_TICK_NO=:C_TICK_NO,");
            strSql.Append("C_STL_GRD=:C_STL_GRD,");
            strSql.Append("C_SPEC=:C_SPEC,");
            strSql.Append("N_ENTRUST_TYPE=:N_ENTRUST_TYPE,");
            strSql.Append("N_STATUS=:N_STATUS,");
            strSql.Append("C_REMARK=:C_REMARK,");
            strSql.Append("C_EMP_ID=:C_EMP_ID,");
            strSql.Append("D_MOD_DT=:D_MOD_DT,");
            strSql.Append("C_EMP_ID_ZY=:C_EMP_ID_ZY,");
            strSql.Append("D_MOD_DT_ZY=:D_MOD_DT_ZY,");
            strSql.Append("C_EMP_ID_JS=:C_EMP_ID_JS,");
            strSql.Append("D_MOD_DT_JS=:D_MOD_DT_JS,");
            strSql.Append("C_EQ_NAME=:C_EQ_NAME,");
            strSql.Append("C_EQ_NUMBER=:C_EQ_NUMBER,");
            strSql.Append("C_EQ_CODE=:C_EQ_CODE,");
            strSql.Append("N_SAMPLES_NUM=:N_SAMPLES_NUM,");
            strSql.Append("C_TICK_STATE=:C_TICK_STATE,");
            strSql.Append("C_BC_SY=:C_BC_SY,");
            strSql.Append("C_BZ_SY=:C_BZ_SY,");
            strSql.Append("C_BC_JY=:C_BC_JY,");
            strSql.Append("C_BZ_JY=:C_BZ_JY");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_BATCH_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_TICK_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STL_GRD", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SPEC", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_ENTRUST_TYPE", OracleDbType.Decimal,1),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":C_EMP_ID_ZY", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT_ZY", OracleDbType.Date),
                    new OracleParameter(":C_EMP_ID_JS", OracleDbType.Varchar2,100),
                    new OracleParameter(":D_MOD_DT_JS", OracleDbType.Date),
                    new OracleParameter(":C_EQ_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_EQ_NUMBER", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_EQ_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_SAMPLES_NUM", OracleDbType.Decimal,5),
                    new OracleParameter(":C_TICK_STATE", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_BC_SY", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_BZ_SY", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_BC_JY", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_BZ_JY", OracleDbType.Varchar2,10),
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.C_BATCH_NO;
            parameters[1].Value = model.C_TICK_NO;
            parameters[2].Value = model.C_STL_GRD;
            parameters[3].Value = model.C_SPEC;
            parameters[4].Value = model.N_ENTRUST_TYPE;
            parameters[5].Value = model.N_STATUS;
            parameters[6].Value = model.C_REMARK;
            parameters[7].Value = model.C_EMP_ID;
            parameters[8].Value = model.D_MOD_DT;
            parameters[9].Value = model.C_EMP_ID_ZY;
            parameters[10].Value = model.D_MOD_DT_ZY;
            parameters[11].Value = model.C_EMP_ID_JS;
            parameters[12].Value = model.D_MOD_DT_JS;
            parameters[13].Value = model.C_EQ_NAME;
            parameters[14].Value = model.C_EQ_NUMBER;
            parameters[15].Value = model.C_EQ_CODE;
            parameters[16].Value = model.N_SAMPLES_NUM;
            parameters[17].Value = model.C_TICK_STATE;
            parameters[18].Value = model.C_BC_SY;
            parameters[19].Value = model.C_BZ_SY;
            parameters[20].Value = model.C_BC_JY;
            parameters[21].Value = model.C_BZ_JY;
            parameters[22].Value = model.C_ID;

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
            strSql.Append("delete from TQC_PRESENT_SAMPLES ");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)          };
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
            strSql.Append("delete from TQC_PRESENT_SAMPLES ");
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
        public Mod_TQC_PRESENT_SAMPLES GetModel(string C_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_BATCH_NO,C_TICK_NO,C_STL_GRD,C_SPEC,N_ENTRUST_TYPE,N_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT,C_EMP_ID_ZY,D_MOD_DT_ZY,C_EMP_ID_JS,D_MOD_DT_JS,C_EQ_NAME,C_EQ_NUMBER,C_EQ_CODE,N_SAMPLES_NUM,C_TICK_STATE,C_BC_SY,C_BZ_SY,C_BC_JY,C_BZ_JY from TQC_PRESENT_SAMPLES ");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)          };
            parameters[0].Value = C_ID;

            Mod_TQC_PRESENT_SAMPLES model = new Mod_TQC_PRESENT_SAMPLES();
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
        public Mod_TQC_PRESENT_SAMPLES DataRowToModel(DataRow row)
        {
            Mod_TQC_PRESENT_SAMPLES model = new Mod_TQC_PRESENT_SAMPLES();
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
                if (row["C_TICK_STATE"] != null)
                {
                    model.C_TICK_STATE = row["C_TICK_STATE"].ToString();
                }
                if (row["C_BC_SY"] != null)
                {
                    model.C_BC_SY = row["C_BC_SY"].ToString();
                }
                if (row["C_BZ_SY"] != null)
                {
                    model.C_BZ_SY = row["C_BZ_SY"].ToString();
                }
                if (row["C_BC_JY"] != null)
                {
                    model.C_BC_JY = row["C_BC_JY"].ToString();
                }
                if (row["C_BZ_JY"] != null)
                {
                    model.C_BZ_JY = row["C_BZ_JY"].ToString();
                }
            }
            return model;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_BATCH_NO,C_TICK_NO,C_STL_GRD,C_SPEC,N_ENTRUST_TYPE,N_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT,C_EMP_ID_ZY,D_MOD_DT_ZY,C_EMP_ID_JS,D_MOD_DT_JS,C_EQ_NAME,C_EQ_NUMBER,C_EQ_CODE,N_SAMPLES_NUM,C_TICK_STATE,C_BC_SY,C_BZ_SY,C_BC_JY,C_BZ_JY  ");
            strSql.Append(" FROM TQC_PRESENT_SAMPLES where N_ENTRUST_TYPE=1 and N_STATUS=1 ");
            strSql.Append(" order by  C_BATCH_NO,C_TICK_NO");

            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM TQC_PRESENT_SAMPLES ");
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
            strSql.Append(")AS Row, T.*  from TQC_PRESENT_SAMPLES T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 制样信息
        /// </summary>
        /// <param name="time_Start">开始时间</param>
        /// <param name="time_End">结束时间</param>
        /// <param name="strBatch">批号</param>
        /// <param name="str_PHYSICS_GROUP_ID">物理性能分组ID</param>
        /// <returns></returns>
        public DataSet GetList(string time_Start, string time_End, string strBatch, string str_PHYSICS_GROUP_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT TA.C_ID AS 取样主表主键, TA.C_BATCH_NO AS 批号, TA.C_TICK_NO AS 钩号, TB.C_STOVE AS 炉号, TA.C_STL_GRD AS 钢种, TA.C_SPEC AS 规格, TB.C_STD_CODE AS 执行标准, TO_CHAR(MAX(TA.D_MOD_DT_ZY), 'YYYY-MM-DD  HH24:MI:SS') AS 制样时间, TO_CHAR(MAX(TC.D_MOD_DT), 'YYYY-MM-DD HH24:MI:SS') AS 录入时间, MAX(TC.C_EMP_ID) AS C_EMP_ID,TA.C_TEMP AS 温度,TA.C_HUMIDITY AS 湿度,TA.C_EQ_NAME AS 设备信息,MAX(TA.C_BC) AS 班次, MAX(TA.C_BZ) AS 班组, DECODE(TA.C_CHECK_STATE,'0','初检','1','复检') AS 检验状态  FROM tqc_physics_result_main TA left JOIN trc_roll_main TB ON TA.C_BATCH_NO = TB.C_BATCH_NO  LEFT JOIN TQC_PHYSICS_RESULT TC ON TC.C_PRESENT_SAMPLES_ID = TA.C_ID WHERE TA.C_PHYSICS_GROUP_ID='" + str_PHYSICS_GROUP_ID + "' AND TA.C_IS_PD='0'  ");

            if (!string.IsNullOrEmpty(time_Start) && !string.IsNullOrEmpty(time_End))
            {
                strSql.Append(" AND TA.D_MOD_DT_ZY BETWEEN TO_DATE('" + time_Start + "','YYYY-MM-DD HH24:MI:SS') AND TO_DATE('" + time_End + "','YYYY-MM-DD HH24:MI:SS') ");
            }

            if (!string.IsNullOrEmpty(strBatch.Trim()))
            {
                strSql.Append(" and TA.C_BATCH_NO like '" + strBatch.Trim() + "%' ");
            }

            strSql.Append(" GROUP BY TA.C_BATCH_NO, TA.C_TICK_NO, TB.C_STOVE, TA.C_STL_GRD, TA.C_SPEC, TB.C_STD_CODE, TA.D_MOD_DT_ZY, TA.C_ID, ta.C_EQ_NAME,TA.C_TEMP,TA.C_HUMIDITY, TA.C_CHECK_STATE ORDER BY TA.C_BATCH_NO DESC,(case when instr(ta.C_TICK_NO, '-') > 0 then DECODE(substr(ta.C_TICK_NO, instr(ta.C_TICK_NO, '-') + 1), 'W', 999, 'T', '998') else to_number(ta.C_TICK_NO) end),to_number(case when instr(ta.C_TICK_NO, '-') > 0 then substr(ta.C_TICK_NO, 1, instr(ta.C_TICK_NO, '-') - 1) else ta.C_TICK_NO end) ASC ");

            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 制样信息
        /// </summary> 
        /// <param name="strBatch">批号</param> 
        /// <returns></returns>
        public DataSet GetList_Copy(string strBatch)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT  TA.C_BATCH_NO AS 批号,  TB.C_STOVE AS 炉号, TA.C_STL_GRD AS 钢种, TA.C_SPEC AS 规格, TB.C_STD_CODE AS 执行标准, TO_CHAR(MAX(TA.D_MOD_DT_ZY), 'YYYY-MM-DD  HH24:MI:SS') AS 制样时间,TA.C_TEMP AS 温度,TA.C_HUMIDITY AS 湿度, TA.C_EQ_NAME as 设备名称,TO_CHAR(MAX(TC.D_MOD_DT), 'YYYY-MM-DD HH24:MI:SS') AS 录入时间, MAX(TC.C_EMP_ID) AS C_EMP_ID,  DECODE(TA.C_CHECK_STATE,'0','初检','1','复检') AS 检验状态  FROM tqc_physics_result_main TA left JOIN trc_roll_main TB ON TA.C_BATCH_NO = TB.C_BATCH_NO  LEFT JOIN TQC_PHYSICS_RESULT TC ON TC.C_PRESENT_SAMPLES_ID = TA.C_ID WHERE  ta.c_stl_grd='LS'  ");

            if (!string.IsNullOrEmpty(strBatch.Trim()))
            {
                strSql.Append(" and TA.C_BATCH_NO like '" + strBatch.Trim() + "%' ");
            }

            strSql.Append(" GROUP BY TA.C_TEMP  ,TA.C_HUMIDITY ,TA.C_EQ_NAME, TA.C_BATCH_NO, TB.C_STOVE, TA.C_STL_GRD, TA.C_SPEC, TB.C_STD_CODE, TA.D_MOD_DT_ZY,    TA.C_CHECK_STATE ORDER BY TA.C_BATCH_NO DESC  ");
            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 制样信息
        /// </summary> 
        /// <param name="strBatchNo">批号 </param> 
        /// <returns></returns>
        public DataSet GetList_Batch(string strBatchNo)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select tq.* from (SELECT TA.C_ID AS 取样主表主键, TA.C_BATCH_NO AS 批号, TB.C_STOVE AS 炉号, TA.C_STL_GRD AS 钢种, TA.C_TICK_NO AS 钩号, TA.C_SPEC AS 规格, TB.C_STD_CODE AS 执行标准, TO_CHAR(TA.D_MOD_DT_ZY, 'YYYY-MM-DD  HH24:MI:SS') AS 制样时间, TO_CHAR(TC.D_MOD_DT, 'YYYY-MM-DD HH24:MI:SS') AS 录入时间, TC.C_EMP_ID AS C_EMP_ID,  DECODE(TA.C_CHECK_STATE, '0', '初检', '1', '复检') AS 检验状态 FROM tqc_physics_result_main TA left JOIN trc_roll_main TB  ON TA.C_BATCH_NO = TB.C_BATCH_NO LEFT JOIN TQC_PHYSICS_RESULT TC  ON TC.C_PRESENT_SAMPLES_ID = TA.C_ID  WHERE ta.c_stl_grd = 'LS'   AND TA.N_IS_LR = 0   and TA.C_BATCH_NO >'" + strBatchNo + "' order by ta.c_batch_no) tq where rownum<=9 ");

            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 制样信息
        /// </summary> 
        /// <param name="strBatch">批号</param> 
        /// <returns></returns>
        public DataSet GetList(string strBatch)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT  TA.C_BATCH_NO AS 批号, TA.C_TICK_NO AS 钩号,tc.c_std_code  as 执行标准,TA.C_STL_GRD  AS 钢种, TA.C_SPEC  AS 规格, to_char(TA.D_TRANST,'yyyy-mm-dd hh24:mi:ss') AS 添加时间，tb.c_name as 性能名称 ");
            strSql.Append(" FROM tqc_physics_result_main TA  JOIN TQB_PHYSICS_GROUP TB on  ta.c_physics_group_id=tb.c_id  join trc_roll_prodcut TC on ta.c_batch_no=tc.c_batch_no and ta.c_tick_no=tc.c_tick_no where 1=1");
            if (!string.IsNullOrEmpty(strBatch.Trim()))
            {
                strSql.Append(" and TA.C_BATCH_NO='" + strBatch.Trim() + "' ");
            }
            strSql.Append(" ORDER BY TA.C_BATCH_NO DESC,性能名称,to_number(TA.C_TICK_NO) ASC ");

            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        /// <param name="strBatchNo">批号</param>
        /// <param name="strStlGrd">钢种</param>
        /// <param name="strSpec">规格</param>
        /// <param name="strTickNo">钩号</param>
        /// <param name="strState">状态</param>
        /// <returns></returns>
		public DataSet Get_List(string strBatchNo, string strStlGrd, string strSpec, string strTickNo, string strState)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ta.c_id as 主键, decode(ta.N_ENTRUST_TYPE, 0, '未委托', 1, '已委托') as 状态, ta.c_batch_no as 批号, ta.c_tick_no as 钩号, ta.c_stl_grd as 钢种, ta.c_spec as 规格, ta.n_samples_num 取样数量,to_char(ta.D_MOD_DT,'yyyy-mm-dd hh24:mi:ss') as 操作时间,ta.C_EMP_ID ，ta.C_REMARK as 备注,decode(ta.C_TICK_STATE, 0, ' ', 1, '次钩',2,'首钩') as 钩号状态,TA.C_BC_SY AS 班次, TA.C_BZ_SY AS 班组  from TQC_PRESENT_SAMPLES ta WHERE ta.N_ENTRUST_TYPE IN(0, 1) ");
            if (strBatchNo.Trim() != "")
            {
                strSql.Append(" AND ta.c_batch_no like '" + strBatchNo + "%' ");
            }
            if (strStlGrd.Trim() != "")
            {
                strSql.Append(" AND ta.c_stl_grd like '" + strStlGrd + "%' ");
            }
            if (strSpec.Trim() != "")
            {
                strSql.Append(" AND ta.c_spec like '%" + strSpec + "%' ");
            }
            if (strTickNo.Trim() != "")
            {
                strSql.Append(" AND ta.c_tick_no = '" + strTickNo + "' ");
            }

            if (strState.Trim() != "-1")
            {
                strSql.Append(" AND ta.N_ENTRUST_TYPE ='" + strState + "' ");
            }

            strSql.Append(" order by ta.c_batch_no asc,ta.C_TICK_STATE desc,to_number(case when instr(ta.C_TICK_NO, '-') > 0 then substr(ta.C_TICK_NO, 1, instr(ta.C_TICK_NO, '-') - 1) else ta.C_TICK_NO end) asc");

            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList_CID(string c_id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_BATCH_NO,C_TICK_NO,C_STL_GRD,C_SPEC,N_ENTRUST_TYPE,N_STATUS,C_REMARK,C_EMP_ID,D_MOD_DT,C_EMP_ID_ZY,D_MOD_DT_ZY,C_EMP_ID_JS,D_MOD_DT_JS,C_EQ_NAME,C_EQ_NUMBER,C_EQ_CODE,N_SAMPLES_NUM  ");
            strSql.Append(" FROM TQC_PRESENT_SAMPLES where  C_ID='" + c_id + "'");

            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
		/// 保存送样信息
		/// </summary>
		public bool SaveSamp(ArrayList SQLStringList)
        {
            return DbHelperOra.ExecuteSqlTran(SQLStringList);
        }

        /// <summary>
        /// 检测送样状态
        /// </summary>
        /// <param name="c_id">检测主表主键</param>
        /// <param name="strState">委托状态   1-已委托；0-未委托；2-接收送样；3-制样</param>
        /// <returns></returns>
        public int Get_JS_Count(string c_id, string strState)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM TQC_PRESENT_SAMPLES ta");

            strSql.Append(" WHERE ta.C_ID='" + c_id + "' and ta.N_ENTRUST_TYPE ='" + strState + "' ");

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
        /// 获取记录总数
        /// </summary>
        /// <param name="C_BATCH_NO">批号</param>
        /// <param name="C_TICK_NO">钩号</param>
        /// <returns></returns>
        public int GetCountByBatchTichNo(string C_BATCH_NO, string C_TICK_NO)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM TQC_PRESENT_SAMPLES where C_BATCH_NO='" + C_BATCH_NO + "' and C_TICK_NO='" + C_TICK_NO + "' ");

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
    }
}

