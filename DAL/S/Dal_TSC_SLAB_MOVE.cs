using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;
using System.Collections.Generic;

namespace DAL
{
    /// <summary>
    /// 数据访问类:TSC_SLAB_MOVE
    /// </summary>
    public partial class Dal_TSC_SLAB_MOVE
    {
        public Dal_TSC_SLAB_MOVE()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string C_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TSC_SLAB_MOVE");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)         };
            parameters[0].Value = C_ID;

            return DbHelperOra.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Mod_TSC_SLAB_MOVE model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TSC_SLAB_MOVE(");
            strSql.Append("C_MOVE_TYPE,C_SLAB_MAIN_ID,C_STA_ID,C_STOVE,C_STL_GRD,C_SPEC,N_LEN,C_STD_CODE,C_MAT_CODE,C_MAT_NAME,N_WGT,C_STOCK_CODE,C_STOCK_CODE_TO,C_AREA_CODE,C_KW_CODE,C_FLOOD_CODE,N_QUA,D_MOVE_DATE,C_MOVE_GROUP,C_MOVE_SHIFT,C_MOVE_EMP_ID,N_STATUS,C_REMARK,C_ZKDH,C_ZKDHID,C_BATCH_NO)");
            strSql.Append(" values (");
            strSql.Append(":C_MOVE_TYPE,:C_SLAB_MAIN_ID,:C_STA_ID,:C_STOVE,:C_STL_GRD,:C_SPEC,:N_LEN,:C_STD_CODE,:C_MAT_CODE,:C_MAT_NAME,:N_WGT,:C_STOCK_CODE,:C_STOCK_CODE_TO,:C_AREA_CODE,:C_KW_CODE,:C_FLOOD_CODE,:N_QUA,:D_MOVE_DATE,:C_MOVE_GROUP,:C_MOVE_SHIFT,:C_MOVE_EMP_ID,:N_STATUS,:C_REMARK,:C_ZKDH,:C_ZKDHID,:C_BATCH_NO)");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_MOVE_TYPE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SLAB_MAIN_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STA_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STOVE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STL_GRD", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SPEC", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_LEN", OracleDbType.Decimal,15),
                    new OracleParameter(":C_STD_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MAT_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MAT_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_WGT", OracleDbType.Decimal,10),
                    new OracleParameter(":C_STOCK_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STOCK_CODE_TO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_AREA_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_KW_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_FLOOD_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_QUA", OracleDbType.Decimal,5),
                    new OracleParameter(":D_MOVE_DATE", OracleDbType.Date),
                    new OracleParameter(":C_MOVE_GROUP", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MOVE_SHIFT", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MOVE_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_ZKDH", OracleDbType.Varchar2,20),
                    new OracleParameter(":C_ZKDHID", OracleDbType.Varchar2,20),
                    new OracleParameter(":C_BATCH_NO", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.C_MOVE_TYPE;
            parameters[1].Value = model.C_SLAB_MAIN_ID;
            parameters[2].Value = model.C_STA_ID;
            parameters[3].Value = model.C_STOVE;
            parameters[4].Value = model.C_STL_GRD;
            parameters[5].Value = model.C_SPEC;
            parameters[6].Value = model.N_LEN;
            parameters[7].Value = model.C_STD_CODE;
            parameters[8].Value = model.C_MAT_CODE;
            parameters[9].Value = model.C_MAT_NAME;
            parameters[10].Value = model.N_WGT;
            parameters[11].Value = model.C_STOCK_CODE;
            parameters[12].Value = model.C_STOCK_CODE_TO;
            parameters[13].Value = model.C_AREA_CODE;
            parameters[14].Value = model.C_KW_CODE;
            parameters[15].Value = model.C_FLOOD_CODE;
            parameters[16].Value = model.N_QUA;
            parameters[17].Value = model.D_MOVE_DATE;
            parameters[18].Value = model.C_MOVE_GROUP;
            parameters[19].Value = model.C_MOVE_SHIFT;
            parameters[20].Value = model.C_MOVE_EMP_ID;
            parameters[21].Value = model.N_STATUS;
            parameters[22].Value = model.C_REMARK;
            parameters[23].Value = model.C_ZKDH;
            parameters[24].Value = model.C_ZKDHID;
            parameters[25].Value = model.C_BATCH_NO;

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
        public bool Update(Mod_TSC_SLAB_MOVE model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TSC_SLAB_MOVE set ");
            strSql.Append("C_MOVE_TYPE=:C_MOVE_TYPE,");
            strSql.Append("C_SLAB_MAIN_ID=:C_SLAB_MAIN_ID,");
            strSql.Append("C_STA_ID=:C_STA_ID,");
            strSql.Append("C_STOVE=:C_STOVE,");
            strSql.Append("C_STL_GRD=:C_STL_GRD,");
            strSql.Append("C_SPEC=:C_SPEC,");
            strSql.Append("N_LEN=:N_LEN,");
            strSql.Append("C_STD_CODE=:C_STD_CODE,");
            strSql.Append("C_MAT_CODE=:C_MAT_CODE,");
            strSql.Append("C_MAT_NAME=:C_MAT_NAME,");
            strSql.Append("N_WGT=:N_WGT,");
            strSql.Append("C_STOCK_CODE=:C_STOCK_CODE,");
            strSql.Append("C_STOCK_CODE_TO=:C_STOCK_CODE_TO,");
            strSql.Append("C_AREA_CODE=:C_AREA_CODE,");
            strSql.Append("C_KW_CODE=:C_KW_CODE,");
            strSql.Append("C_FLOOD_CODE=:C_FLOOD_CODE,");
            strSql.Append("N_QUA=:N_QUA,");
            strSql.Append("D_MOVE_DATE=:D_MOVE_DATE,");
            strSql.Append("C_MOVE_GROUP=:C_MOVE_GROUP,");
            strSql.Append("C_MOVE_SHIFT=:C_MOVE_SHIFT,");
            strSql.Append("C_MOVE_EMP_ID=:C_MOVE_EMP_ID,");
            strSql.Append("N_STATUS=:N_STATUS,");
            strSql.Append("C_REMARK=:C_REMARK,");
            strSql.Append("C_ZKDH=:C_ZKDH,");
            strSql.Append("C_ZKDHID=:C_ZKDHID,");
            strSql.Append("C_BATCH_NO=:C_BATCH_NO");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_MOVE_TYPE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SLAB_MAIN_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STA_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STOVE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STL_GRD", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SPEC", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_LEN", OracleDbType.Decimal,15),
                    new OracleParameter(":C_STD_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MAT_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MAT_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_WGT", OracleDbType.Decimal,10),
                    new OracleParameter(":C_STOCK_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STOCK_CODE_TO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_AREA_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_KW_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_FLOOD_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_QUA", OracleDbType.Decimal,5),
                    new OracleParameter(":D_MOVE_DATE", OracleDbType.Date),
                    new OracleParameter(":C_MOVE_GROUP", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MOVE_SHIFT", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MOVE_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_ZKDH", OracleDbType.Varchar2,20),
                    new OracleParameter(":C_ZKDHID", OracleDbType.Varchar2,20),
                    new OracleParameter(":C_BATCH_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.C_MOVE_TYPE;
            parameters[1].Value = model.C_SLAB_MAIN_ID;
            parameters[2].Value = model.C_STA_ID;
            parameters[3].Value = model.C_STOVE;
            parameters[4].Value = model.C_STL_GRD;
            parameters[5].Value = model.C_SPEC;
            parameters[6].Value = model.N_LEN;
            parameters[7].Value = model.C_STD_CODE;
            parameters[8].Value = model.C_MAT_CODE;
            parameters[9].Value = model.C_MAT_NAME;
            parameters[10].Value = model.N_WGT;
            parameters[11].Value = model.C_STOCK_CODE;
            parameters[12].Value = model.C_STOCK_CODE_TO;
            parameters[13].Value = model.C_AREA_CODE;
            parameters[14].Value = model.C_KW_CODE;
            parameters[15].Value = model.C_FLOOD_CODE;
            parameters[16].Value = model.N_QUA;
            parameters[17].Value = model.D_MOVE_DATE;
            parameters[18].Value = model.C_MOVE_GROUP;
            parameters[19].Value = model.C_MOVE_SHIFT;
            parameters[20].Value = model.C_MOVE_EMP_ID;
            parameters[21].Value = model.N_STATUS;
            parameters[22].Value = model.C_REMARK;
            parameters[23].Value = model.C_ZKDH;
            parameters[24].Value = model.C_ZKDHID;
            parameters[25].Value = model.C_BATCH_NO;
            parameters[26].Value = model.C_ID;

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
            strSql.Append("delete from TSC_SLAB_MOVE ");
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
            strSql.Append("delete from TSC_SLAB_MOVE ");
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
        public Mod_TSC_SLAB_MOVE GetModel(string C_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_MOVE_TYPE,C_SLAB_MAIN_ID,C_STA_ID,C_STOVE,C_STL_GRD,C_SPEC,N_LEN,C_STD_CODE,C_MAT_CODE,C_MAT_NAME,N_WGT,C_STOCK_CODE,C_STOCK_CODE_TO,C_AREA_CODE,C_KW_CODE,C_FLOOD_CODE,N_QUA,D_MOVE_DATE,C_MOVE_GROUP,C_MOVE_SHIFT,C_MOVE_EMP_ID,N_STATUS,C_REMARK,C_ZKDH,C_ZKDHID,C_BATCH_NO from TSC_SLAB_MOVE ");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)         };
            parameters[0].Value = C_ID;

            Mod_TSC_SLAB_MOVE model = new Mod_TSC_SLAB_MOVE();
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
        public Mod_TSC_SLAB_MOVE DataRowToModel(DataRow row)
        {
            Mod_TSC_SLAB_MOVE model = new Mod_TSC_SLAB_MOVE();
            if (row != null)
            {
                if (row["C_ID"] != null)
                {
                    model.C_ID = row["C_ID"].ToString();
                }
                if (row["C_MOVE_TYPE"] != null)
                {
                    model.C_MOVE_TYPE = row["C_MOVE_TYPE"].ToString();
                }
                if (row["C_SLAB_MAIN_ID"] != null)
                {
                    model.C_SLAB_MAIN_ID = row["C_SLAB_MAIN_ID"].ToString();
                }
                if (row["C_STA_ID"] != null)
                {
                    model.C_STA_ID = row["C_STA_ID"].ToString();
                }
                if (row["C_STOVE"] != null)
                {
                    model.C_STOVE = row["C_STOVE"].ToString();
                }
                if (row["C_STL_GRD"] != null)
                {
                    model.C_STL_GRD = row["C_STL_GRD"].ToString();
                }
                if (row["C_SPEC"] != null)
                {
                    model.C_SPEC = row["C_SPEC"].ToString();
                }
                if (row["N_LEN"] != null && row["N_LEN"].ToString() != "")
                {
                    model.N_LEN = decimal.Parse(row["N_LEN"].ToString());
                }
                if (row["C_STD_CODE"] != null)
                {
                    model.C_STD_CODE = row["C_STD_CODE"].ToString();
                }
                if (row["C_MAT_CODE"] != null)
                {
                    model.C_MAT_CODE = row["C_MAT_CODE"].ToString();
                }
                if (row["C_MAT_NAME"] != null)
                {
                    model.C_MAT_NAME = row["C_MAT_NAME"].ToString();
                }
                if (row["N_WGT"] != null && row["N_WGT"].ToString() != "")
                {
                    model.N_WGT = decimal.Parse(row["N_WGT"].ToString());
                }
                if (row["C_STOCK_CODE"] != null)
                {
                    model.C_STOCK_CODE = row["C_STOCK_CODE"].ToString();
                }
                if (row["C_STOCK_CODE_TO"] != null)
                {
                    model.C_STOCK_CODE_TO = row["C_STOCK_CODE_TO"].ToString();
                }
                if (row["C_AREA_CODE"] != null)
                {
                    model.C_AREA_CODE = row["C_AREA_CODE"].ToString();
                }
                if (row["C_KW_CODE"] != null)
                {
                    model.C_KW_CODE = row["C_KW_CODE"].ToString();
                }
                if (row["C_FLOOD_CODE"] != null)
                {
                    model.C_FLOOD_CODE = row["C_FLOOD_CODE"].ToString();
                }
                if (row["N_QUA"] != null && row["N_QUA"].ToString() != "")
                {
                    model.N_QUA = decimal.Parse(row["N_QUA"].ToString());
                }
                if (row["D_MOVE_DATE"] != null && row["D_MOVE_DATE"].ToString() != "")
                {
                    model.D_MOVE_DATE = DateTime.Parse(row["D_MOVE_DATE"].ToString());
                }
                if (row["C_MOVE_GROUP"] != null)
                {
                    model.C_MOVE_GROUP = row["C_MOVE_GROUP"].ToString();
                }
                if (row["C_MOVE_SHIFT"] != null)
                {
                    model.C_MOVE_SHIFT = row["C_MOVE_SHIFT"].ToString();
                }
                if (row["C_MOVE_EMP_ID"] != null)
                {
                    model.C_MOVE_EMP_ID = row["C_MOVE_EMP_ID"].ToString();
                }
                if (row["N_STATUS"] != null && row["N_STATUS"].ToString() != "")
                {
                    model.N_STATUS = decimal.Parse(row["N_STATUS"].ToString());
                }
                if (row["C_REMARK"] != null)
                {
                    model.C_REMARK = row["C_REMARK"].ToString();
                }
                if (row["C_ZKDH"] != null)
                {
                    model.C_ZKDH = row["C_ZKDH"].ToString();
                }
                if (row["C_ZKDHID"] != null)
                {
                    model.C_ZKDHID = row["C_ZKDHID"].ToString();
                }
                if (row["C_BATCH_NO"] != null)
                {
                    model.C_BATCH_NO = row["C_BATCH_NO"].ToString();
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
            strSql.Append("select C_ID,C_MOVE_TYPE,C_SLAB_MAIN_ID,C_STA_ID,C_STOVE,C_STL_GRD,C_SPEC,N_LEN,C_STD_CODE,C_MAT_CODE,C_MAT_NAME,N_WGT,C_STOCK_CODE,C_STOCK_CODE_TO,C_AREA_CODE,C_KW_CODE,C_FLOOD_CODE,N_QUA,D_MOVE_DATE,C_MOVE_GROUP,C_MOVE_SHIFT,C_MOVE_EMP_ID,N_STATUS,C_REMARK,C_ZKDH,C_ZKDHID,C_BATCH_NO ");
            strSql.Append(" FROM TSC_SLAB_MOVE ");
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
            strSql.Append("select count(1) FROM TSC_SLAB_MOVE ");
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
        /// 更新钢坯调拨状态
        /// </summary>
        /// <param name="stove">炉号</param>
        /// <param name="grd">钢种</param>
        /// <param name="spec">规格</param>
        /// <param name="std">执行标准</param>
        /// <param name="matCode">物料编码</param>
        /// <param name="num">支数</param>
        /// <param name="slabwhCode">仓库</param>
        /// <param name="shift">班组</param>
        /// <param name="group">班次</param>
        /// <param name="strUserID">操作人ID</param>
        /// <param name="dtTime">操作时间</param>
        /// <param name="billet">钢坯列表</param>
        /// <returns></returns>
        public int UpdateMoveType(string stove, string grd, string spec, string std,
            string matCode, int num, string slabwhCode, string shift, string group, string strUserID, DateTime dtTime, out DataTable billet
            , string remark)
        {
            StringBuilder strSql = new StringBuilder();

            strSql.Append("SELECT * FROM TSC_SLAB_MAIN T  WHERE T.C_MOVE_TYPE='N' AND T.C_SLABWH_CODE IS NULL ");

            if (stove != null)
            {
                strSql.Append(" and T.C_STOVE='" + stove + "' ");
            }

            if (grd != null)
            {
                strSql.Append(" and T.C_STL_GRD='" + grd + "' ");
            }

            if (spec != null)
            {
                strSql.Append(" and T.C_SPEC='" + spec + "' ");
            }

            if (std != null)
            {
                strSql.Append(" and T.C_STD_CODE='" + std + "' ");
            }

            if (matCode != null)
            {
                strSql.Append(" and T.C_MAT_CODE='" + matCode + "' ");
            }

            strSql.Append(" AND  ROWNUM <=" + num + " ");


            DataTable slabDt = DbHelperOra.Query(strSql.ToString()).Tables[0];
            billet = slabDt;
            if (slabDt == null || slabDt.Rows.Count == 0)
                return 0;

            StringBuilder strSql_Up = new StringBuilder();
            strSql_Up.Append("UPDATE TSC_SLAB_MAIN TSM SET TSM.C_MOVE_TYPE='M',TSM.C_SLABWH_CODE='" + slabwhCode + "',TSM.D_WL_DATE=to_date('" + dtTime + "','yyyy-mm-dd hh24:mi:ss'),TSM.C_WL_SHIFT='" + shift + "',TSM.C_WL_GROUP='" + group + "',TSM.C_WL_EMP_ID='" + strUserID + "',TSM.C_REMARK='" + remark + "' ");

            strSql_Up.Append(" WHERE TSM.C_ID IN( ");
            if (slabDt != null && slabDt.Rows.Count > 0)
            {
                for (int i = 0; i < slabDt.Rows.Count; i++)
                {
                    if (i == slabDt.Rows.Count - 1)
                        strSql_Up.Append("'" + slabDt.Rows[i]["C_ID"] + "'");
                    else
                        strSql_Up.Append("'" + slabDt.Rows[i]["C_ID"] + "',");
                }
            }
            strSql_Up.Append(" ) ");

            return TransactionHelper.ExecuteSql(strSql_Up.ToString());
        }

        /// <summary>
        /// 获取分库记录
        /// </summary>
        /// <param name="strStaID">连铸工位ID</param>
        /// <param name="strStove">炉号</param>
        /// <param name="strTimeStart">开始时间</param>
        /// <param name="strTimeEnd">结束时间</param>
        /// <returns></returns>
        public DataSet Get_FK_Log(string strStaID, string strStove, string strTimeStart, string strTimeEnd)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT TB.C_STA_DESC, T.C_STOVE, T.C_STL_GRD, T.C_SPEC, T.N_LEN, T.C_STD_CODE, T.C_MAT_CODE, T.C_MAT_NAME, SUM(T.N_WGT) AS N_WGT, T.C_STOCK_CODE_TO, COUNT(1) AS N_QUA, T.D_MOVE_DATE, T.C_MOVE_GROUP, T.C_MOVE_SHIFT, TC.C_NAME ");

            strSql.Append(" FROM TSC_SLAB_MOVE T left JOIN TB_STA TB ON T.C_STA_ID = TB.C_ID INNER JOIN TS_USER TC ON TC.C_ID = T.C_MOVE_EMP_ID ");
            strSql.Append(" WHERE T.N_STATUS = 1 AND T.C_MOVE_TYPE = 'M' AND T.C_STOCK_CODE IS NULL ");

            if (strStove.Trim() != "")
            {
                strSql.Append(" AND T.C_STOVE like '" + strStove + "%' ");
            }

            if (strStaID.Trim() != "")
            {
                strSql.Append(" AND T.C_STA_ID = '" + strStaID + "' ");
            }

            if (strTimeStart.Trim() != "" && strTimeEnd.Trim() != "")
            {
                strSql.Append(" AND T.D_MOVE_DATE BETWEEN TO_DATE('" + strTimeStart + "', 'YYYY-MM-DD HH24:MI:SS') AND TO_DATE('" + strTimeEnd + "', 'YYYY-MM-DD HH24:MI:SS') ");
            }

            strSql.Append(" GROUP BY TB.C_STA_DESC, T.C_STOVE, T.C_STL_GRD, T.C_SPEC, T.N_LEN, T.C_STD_CODE, T.C_MAT_CODE, T.C_MAT_NAME, T.C_STOCK_CODE_TO, T.D_MOVE_DATE, T.C_MOVE_GROUP, T.C_MOVE_SHIFT, TC.C_NAME ");

            strSql.Append(" ORDER BY T.D_MOVE_DATE DESC ");

            return DbHelperOra.Query(strSql.ToString());
        }


        /// <summary>
        /// 获取入库记录
        /// </summary>
        /// <param name="strKW">库位编码</param>
        /// <param name="strStove">炉号</param>
        /// <param name="strTimeStart">开始时间</param>
        /// <param name="strTimeEnd">结束时间</param>
        /// <returns></returns>
        public DataSet Get_RK_Log(string strKW, string strStove, string strTimeStart, string strTimeEnd, string area)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT TB.C_STA_DESC, T.C_STOVE,T.C_BATCH_NO, T.C_STL_GRD, T.C_SPEC, T.N_LEN, T.C_STD_CODE, T.C_MAT_CODE, T.C_MAT_NAME, SUM(T.N_WGT) AS N_WGT, T.C_STOCK_CODE, T.C_STOCK_CODE_TO, COUNT(1) AS N_QUA, T.D_MOVE_DATE, T.C_MOVE_GROUP, T.C_MOVE_SHIFT, TC.C_NAME,T.C_AREA_CODE, T.C_KW_CODE, T.C_FLOOD_CODE, MAX(TSM.C_REMARK) AS C_REMARK, T.C_MOVE_GROUP C_GROUP , T.C_MOVE_SHIFT C_SHIFT,  (SELECT  MAX(OTS.C_SLABWH_NAME)  FROM TPB_SLABWH OTS  WHERE OTS.C_SLABWH_CODE = T.C_STOCK_CODE AND OTS.N_STATUS = 1) C_STOCK_CODE_NAME,  (SELECT  MAX(OTSA.C_SLABWH_AREA_NAME)  FROM TPB_SLABWH_AREA OTSA   WHERE OTSA.C_SLABWH_AREA_CODE = T.C_AREA_CODE   AND OTSA.N_STATUS = 1) C_AREA_CODE_NAME,   (SELECT  MAX(OTST.C_SLABWH_LOC_NAME) FROM TPB_SLABWH_LOC OTST   WHERE OTST.C_SLABWH_LOC_CODE = T.C_KW_CODE   AND OTST.N_STATUS = 1) C_KW_CODE_NAME, T.C_FLOOD_CODE  ");

            strSql.Append(" FROM TSC_SLAB_MOVE T left JOIN TB_STA TB ON T.C_STA_ID = TB.C_ID INNER JOIN TS_USER TC ON TC.C_ID = T.C_MOVE_EMP_ID LEFT JOIN TSC_SLAB_MAIN TSM ON TSM.C_ID=T.C_SLAB_MAIN_ID ");
            strSql.Append(" WHERE T.N_STATUS = 1 AND T.C_MOVE_TYPE = 'E' ");

            if (strStove.Trim() != "")
            {
                strSql.Append(" AND (T.C_STOVE like '" + strStove + "%' OR T.C_BATCH_NO like '" + strStove + "%') ");
            }

            if (strKW.Trim() != "")
            {
                strSql.Append(" AND T.C_STOCK_CODE = '" + strKW + "' ");
            }

            if (area.Trim() != "全部")
            {
                strSql.Append(" AND T.C_AREA_CODE = '" + area + "' ");
            }

            if (strTimeStart.Trim() != "" && strTimeEnd.Trim() != "")
            {
                strSql.Append(" AND T.D_MOVE_DATE BETWEEN TO_DATE('" + strTimeStart + "', 'YYYY-MM-DD HH24:MI:SS') AND TO_DATE('" + strTimeEnd + "', 'YYYY-MM-DD HH24:MI:SS') ");
            }

            strSql.Append(" GROUP BY TB.C_STA_DESC, T.C_STOVE,T.C_BATCH_NO, T.C_STL_GRD, T.C_SPEC, T.N_LEN, T.C_STD_CODE, T.C_MAT_CODE, T.C_MAT_NAME, T.C_STOCK_CODE, T.C_STOCK_CODE_TO, T.D_MOVE_DATE, T.C_MOVE_GROUP, T.C_MOVE_SHIFT, TC.C_NAME,T.C_AREA_CODE, T.C_KW_CODE, T.C_FLOOD_CODE, T.c_Remark ");

            strSql.Append(" ORDER BY T.D_MOVE_DATE DESC ");

            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 更新钢坯调拨状态
        /// </summary>
        /// <param name="stove">炉号</param>
        /// <param name="grd">钢种</param>
        /// <param name="spec">规格</param>
        /// <param name="std">执行标准</param>
        /// <param name="matCode">物料编码</param>
        /// <param name="num">支数</param>
        /// <param name="slabwhCode">仓库</param>
        /// <param name="shift">班组</param>
        /// <param name="group">班次</param>
        /// <param name="strUserID">操作人ID</param>
        /// <param name="dtTime">操作时间</param>
        /// <param name="billet">钢坯列表</param>
        /// <returns></returns>
        public int UpdateMoveType(string stove, string grd, string spec, string std,
            string matCode, int num, string slabwhCode, string area, string kw, string floor, string shift, string group, string strUserID, DateTime dtTime, string strZKDH, string strZKDHID, out DataTable billet, string kpBatch, string remark)
        {
            StringBuilder strSql = new StringBuilder();

            strSql.Append("SELECT * FROM TSC_SLAB_MAIN T  WHERE T.C_MOVE_TYPE='M' ");

            if (!string.IsNullOrEmpty(slabwhCode))
            {
                strSql.Append(" and T.C_SLABWH_CODE='" + slabwhCode + "' ");
            }

            if (!string.IsNullOrEmpty(stove))
            {
                strSql.Append(" and T.C_STOVE='" + stove + "' ");
            }

            if (!string.IsNullOrEmpty(kpBatch))
            {
                strSql.Append(" and T.C_BATCH_NO='" + kpBatch + "' ");
            }

            if (!string.IsNullOrEmpty(grd))
            {
                strSql.Append(" and T.C_STL_GRD='" + grd + "' ");
            }

            if (!string.IsNullOrEmpty(spec))
            {
                strSql.Append(" and T.C_SPEC='" + spec + "' ");
            }

            if (!string.IsNullOrEmpty(std))
            {
                strSql.Append(" and T.C_STD_CODE='" + std + "' ");
            }

            if (!string.IsNullOrEmpty(matCode))
            {
                strSql.Append(" and T.C_MAT_CODE='" + matCode + "' ");
            }

            if (!string.IsNullOrEmpty(strZKDH))
            {
                strSql.Append(" and T.C_ZKDH='" + strZKDH + "' ");
            }

            if (!string.IsNullOrEmpty(strZKDHID))
            {
                strSql.Append(" and T.C_ZKDHID='" + strZKDHID + "' ");
            }

            strSql.Append(" AND  ROWNUM <=" + num + " ");


            DataTable slabDt = DbHelperOra.Query(strSql.ToString()).Tables[0];
            billet = slabDt;
            if (slabDt == null || slabDt.Rows.Count == 0)
                return 0;

            string strKWType = Get_KW_Type(kw);//库位类型

            StringBuilder strSql_Up = new StringBuilder();

            if (strKWType == "缓冷坑")
            {
                strSql_Up.Append("UPDATE TSC_SLAB_MAIN TSM SET TSM.C_MOVE_TYPE='E',TSM.C_SLABWH_AREA_CODE='" + area + "',TSM.C_SLABWH_LOC_CODE='" + kw + "',TSM.C_SLABWH_TIER_CODE='" + floor + "',TSM.D_WE_DATE=to_date('" + dtTime + "','yyyy-mm-dd hh24:mi:ss'),TSM.C_WE_SHIFT='" + shift + "',TSM.C_WE_GROUP='" + group + "',TSM.C_WE_EMP_ID='" + strUserID + "',TSM.D_ESC_DATE=to_date('" + dtTime + "','yyyy-mm-dd hh24:mi:ss'),TSM.C_REMARK='" + remark + "'  ");
            }
            else
            {
                strSql_Up.Append("UPDATE TSC_SLAB_MAIN TSM SET TSM.C_MOVE_TYPE='E',TSM.C_SLABWH_AREA_CODE='" + area + "',TSM.C_SLABWH_LOC_CODE='" + kw + "',TSM.C_SLABWH_TIER_CODE='" + floor + "',TSM.D_WE_DATE=to_date('" + dtTime + "','yyyy-mm-dd hh24:mi:ss'),TSM.C_WE_SHIFT='" + shift + "',TSM.C_WE_GROUP='" + group + "',TSM.C_WE_EMP_ID='" + strUserID + "',TSM.C_REMARK='" + remark + "' ");
            }

            strSql_Up.Append(" WHERE TSM.C_ID IN( ");
            if (slabDt != null && slabDt.Rows.Count > 0)
            {
                for (int i = 0; i < slabDt.Rows.Count; i++)
                {
                    if (i == slabDt.Rows.Count - 1)
                        strSql_Up.Append("'" + slabDt.Rows[i]["C_ID"] + "'");
                    else
                        strSql_Up.Append("'" + slabDt.Rows[i]["C_ID"] + "',");
                }
            }
            strSql_Up.Append(" ) ");

            return TransactionHelper.ExecuteSql(strSql_Up.ToString());
        }


        /// <summary>
        /// 获取库位类型
        /// </summary>
        public string Get_KW_Type(string C_SLABWH_LOC_CODE)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select t.c_slabwh_type from TPB_SLABWH_LOC t where t.c_slabwh_loc_code='" + C_SLABWH_LOC_CODE + "' ");

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
        /// 更新需要调拨的钢坯状态
        /// </summary>
        /// <param name="stove">炉号</param>
        /// <param name="grd">钢种</param>
        /// <param name="spec">规格</param>
        /// <param name="std">执行标准</param>
        /// <param name="matCode">物料编码</param>
        /// <param name="num">支数</param>
        /// <param name="slabwhCode_OLD">原仓库</param>
        /// <param name="slabwhCode_NEW">新仓库</param>
        /// <param name="shift">班组</param>
        /// <param name="group">班次</param>
        /// <param name="strUserID">操作人ID</param>
        /// <param name="dtTime">操作时间</param>
        /// <param name="strZKDH">转库单号</param>
        /// <param name="strZKDHID">转库单号ID</param>
        /// <param name="billet">钢坯列表</param>
        /// <returns></returns>
        public int UpdateMoveType(string stove, string grd, string spec, string std,
            string matCode, int num, string slabwhCode_OLD, string slabwhCode_NEW, string kw, string shift, string group, string strUserID, DateTime dtTime, string strZKDH, string strZKDHID, out DataTable billet, string kpBatch, string remark)
        {
            StringBuilder strSql = new StringBuilder();

            strSql.Append("SELECT * FROM TSC_SLAB_MAIN T  WHERE T.C_MOVE_TYPE='E' AND T.C_SLABWH_CODE ='" + slabwhCode_OLD + "' ");

            if (!string.IsNullOrWhiteSpace(kw))
            {
                strSql.Append(" and T.C_SLABWH_LOC_CODE='" + kw + "' ");
            }

            if (!string.IsNullOrEmpty(stove))
            {
                strSql.Append(" and T.C_STOVE='" + stove + "' ");
            }

            if (!string.IsNullOrEmpty(kpBatch))
            {
                strSql.Append(" and T.C_BATCH_NO='" + kpBatch + "' ");
            }

            if (!string.IsNullOrEmpty(grd))
            {
                strSql.Append(" and T.C_STL_GRD='" + grd + "' ");
            }

            if (!string.IsNullOrEmpty(spec))
            {
                strSql.Append(" and T.C_SPEC='" + spec + "' ");
            }

            if (!string.IsNullOrEmpty(std))
            {
                strSql.Append(" and T.C_STD_CODE='" + std + "' ");
            }

            if (!string.IsNullOrEmpty(matCode))
            {
                strSql.Append(" and T.C_MAT_CODE='" + matCode + "' ");
            }

            strSql.Append(" AND  ROWNUM <=" + num + " ");


            DataTable slabDt = DbHelperOra.Query(strSql.ToString()).Tables[0];
            billet = slabDt;
            if (slabDt == null || slabDt.Rows.Count == 0)
                return 0;

            string strKWType = Get_KW_Type(slabDt.Rows[0]["C_SLABWH_LOC_CODE"].ToString());//库位类型

            StringBuilder strSql_Up = new StringBuilder();

            if (strKWType == "缓冷坑")
            {
                strSql_Up.Append("UPDATE TSC_SLAB_MAIN TSM SET TSM.C_MOVE_TYPE='M',TSM.C_SLABWH_CODE='" + slabwhCode_NEW + "',TSM.D_WL_DATE=to_date('" + dtTime + "','yyyy-mm-dd hh24:mi:ss'),TSM.C_WL_SHIFT='" + shift + "',TSM.C_WL_GROUP='" + group + "',TSM.C_WL_EMP_ID='" + strUserID + "',TSM.C_ZKDH='" + strZKDH + "',TSM.C_ZKDHID='" + strZKDHID + "',TSM.D_LSC_DATE=to_date('" + dtTime + "','yyyy-mm-dd hh24:mi:ss'),TSM.C_REMARK='" + remark + "' ");
            }
            else
            {
                strSql_Up.Append("UPDATE TSC_SLAB_MAIN TSM SET TSM.C_MOVE_TYPE='M',TSM.C_SLABWH_CODE='" + slabwhCode_NEW + "',TSM.D_WL_DATE=to_date('" + dtTime + "','yyyy-mm-dd hh24:mi:ss'),TSM.C_WL_SHIFT='" + shift + "',TSM.C_WL_GROUP='" + group + "',TSM.C_WL_EMP_ID='" + strUserID + "',TSM.C_ZKDH='" + strZKDH + "',TSM.C_ZKDHID='" + strZKDHID + "',TSM.C_REMARK='" + remark + "' ");
            }



            strSql_Up.Append(" WHERE TSM.C_ID IN( ");
            if (slabDt != null && slabDt.Rows.Count > 0)
            {
                for (int i = 0; i < slabDt.Rows.Count; i++)
                {
                    if (i == slabDt.Rows.Count - 1)
                        strSql_Up.Append("'" + slabDt.Rows[i]["C_ID"] + "'");
                    else
                        strSql_Up.Append("'" + slabDt.Rows[i]["C_ID"] + "',");
                }
            }
            strSql_Up.Append(" ) ");

            return TransactionHelper.ExecuteSql(strSql_Up.ToString());
        }


        /// <summary>
        /// 获取调拨记录
        /// </summary>
        /// <param name="slabwhCode">仓库代码</param>
        /// <param name="strStove">炉号</param>
        /// <param name="strTimeStart">开始时间</param>
        /// <param name="strTimeEnd">结束时间</param>
        /// <returns></returns>
        public DataSet Get_DB_Log(string slabwhCode, string strStove, string strTimeStart, string strTimeEnd)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT TB.C_STA_DESC, T.C_STOVE,T.C_BATCH_NO, T.C_STL_GRD, T.C_SPEC, T.N_LEN, T.C_STD_CODE, T.C_MAT_CODE, T.C_MAT_NAME, SUM(T.N_WGT) AS N_WGT, T.C_STOCK_CODE,T.C_STOCK_CODE_TO, COUNT(1) AS N_QUA, T.D_MOVE_DATE, T.C_MOVE_GROUP, T.C_MOVE_SHIFT, T.C_MOVE_GROUP  C_GROUP,T.C_MOVE_SHIFT C_SHIFT, TC.C_NAME,MAX(TSM.C_REMARK) AS C_REMARK ,(SELECT OTS.C_SLABWH_NAME  FROM TPB_SLABWH OTS WHERE OTS.C_SLABWH_CODE =  T.C_STOCK_CODE  AND OTS.N_STATUS = 1) C_STOCK_CODE_NAME, (SELECT OTS.C_SLABWH_NAME  FROM TPB_SLABWH OTS WHERE OTS.C_SLABWH_CODE = T.C_STOCK_CODE_TO  AND OTS.N_STATUS = 1) C_STOCK_CODE_TO_NAME ,  T.C_MOVE_GROUP  C_GROUP, T.C_MOVE_SHIFT C_SHIFT ");

            strSql.Append(" FROM TSC_SLAB_MOVE T left JOIN TB_STA TB ON T.C_STA_ID = TB.C_ID INNER JOIN TS_USER TC ON TC.C_ID = T.C_MOVE_EMP_ID LEFT JOIN TSC_SLAB_MAIN TSM ON TSM.C_ID=T.C_SLAB_MAIN_ID ");
            strSql.Append(" WHERE T.N_STATUS = 1 AND T.C_MOVE_TYPE = 'M' AND T.C_STOCK_CODE ='" + slabwhCode + "' and T.C_STOCK_CODE_TO is not null ");

            if (strStove.Trim() != "")
            {
                strSql.Append(" AND (T.C_STOVE like '" + strStove + "%' OR T.C_BATCH_NO like '" + strStove + "%') ");
            }

            if (strTimeStart.Trim() != "" && strTimeEnd.Trim() != "")
            {
                strSql.Append(" AND T.D_MOVE_DATE BETWEEN TO_DATE('" + strTimeStart + "', 'YYYY-MM-DD HH24:MI:SS') AND TO_DATE('" + strTimeEnd + "', 'YYYY-MM-DD HH24:MI:SS') ");
            }

            strSql.Append(" GROUP BY TB.C_STA_DESC, T.C_STOVE,T.C_BATCH_NO, T.C_STL_GRD, T.C_SPEC, T.N_LEN, T.C_STD_CODE, T.C_MAT_CODE, T.C_MAT_NAME,T.C_STOCK_CODE, T.C_STOCK_CODE_TO, T.D_MOVE_DATE, T.C_MOVE_GROUP, T.C_MOVE_SHIFT, TC.C_NAME,T.C_REMARK ");

            strSql.Append(" ORDER BY T.D_MOVE_DATE DESC ");

            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 获取出入库记录
        /// </summary>
        /// <param name="strTimeStart">开始时间</param>
        /// <param name="strTimeEnd">结束时间</param>
        /// <param name="strStove">炉号</param>
        /// <param name="strSTD">标准</param>
        /// <param name="strSTLGRD">钢种</param>
        /// <returns></returns>
        public DataSet Get_DB(string strTimeStart, string strTimeEnd, string strStove, string strSTD, string strSTLGRD)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT  T.C_STOVE as 炉号, T.C_BATCH_NO as 开坯号,  T.C_STL_GRD as 钢种,  COUNT(1) AS 支数, T.C_STD_CODE as 执行标准,decode(T.C_MOVE_TYPE, 'M', '转库', 'E', '入库', '其他') as 状态, (SELECT OTS.C_SLABWH_NAME FROM TPB_SLABWH OTS WHERE OTS.C_SLABWH_CODE = T.C_STOCK_CODE AND OTS.N_STATUS = 1)原仓库, (SELECT OTS.C_SLABWH_NAME FROM TPB_SLABWH OTS WHERE OTS.C_SLABWH_CODE = T.C_STOCK_CODE_TO AND OTS.N_STATUS = 1) 新仓库, T.C_SPEC as 规格,T.N_LEN as 长度,T.C_MAT_CODE as 物料编码,T.C_MAT_NAME as 物料描述,SUM(T.N_WGT) AS 重量,T.C_MOVE_GROUP C_GROUP,T.C_MOVE_SHIFT C_SHIFT,TC.C_NAME as 操作人员,to_char(T.D_MOVE_DATE,'YYYY-MM-DD HH24:MI:SS') as 操作时间,T.C_REMARK as 备注  ");
            strSql.Append(" FROM TSC_SLAB_MOVE T left JOIN TB_STA TB ON T.C_STA_ID = TB.C_ID INNER JOIN TS_USER TC ON TC.C_ID = T.C_MOVE_EMP_ID ");
            strSql.Append(" WHERE T.N_STATUS = 1  ");
            if (strTimeStart.Trim() != "" && strTimeEnd.Trim() != "")
            {
                strSql.Append(" AND T.D_MOVE_DATE BETWEEN TO_DATE('" + strTimeStart + "', 'YYYY-MM-DD HH24:MI:SS') AND TO_DATE('" + strTimeEnd + "', 'YYYY-MM-DD HH24:MI:SS') ");
            }
            if (strStove.Trim() != "")
            {
                strSql.Append(" AND (T.C_STOVE = '" + strStove + "' or T.C_BATCH_NO='" + strStove + "') ");
            }
            if (strSTD.Trim() != "")
            {
                strSql.Append(" AND T.C_STD_CODE like '%" + strSTD + "%' ");
            }
            if (strSTLGRD.Trim() != "")
            {
                strSql.Append(" AND upper(T.C_STL_GRD) like upper('%" + strSTLGRD + "%') ");
            }
            strSql.Append(" GROUP BY TB.C_STA_DESC, T.C_STOVE,T.C_BATCH_NO, T.C_STL_GRD, T.C_SPEC, T.N_LEN, T.C_STD_CODE, T.C_MAT_CODE, T.C_MAT_NAME,T.C_STOCK_CODE, T.C_STOCK_CODE_TO, T.D_MOVE_DATE, T.C_MOVE_GROUP, T.C_MOVE_SHIFT, TC.C_NAME,T.C_REMARK,t.C_MOVE_TYPE ");

            strSql.Append(" ORDER BY T.D_MOVE_DATE DESC ");

            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 根据转库单号获取model
        /// </summary>
        /// <param name="C_ZKDH">转库单号</param>
        /// <returns></returns>     
        public Mod_TSC_SLAB_MOVE GetModelbyDH(string C_ZKDH)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_MOVE_TYPE,C_SLAB_MAIN_ID,C_STA_ID,C_STOVE,C_STL_GRD,C_SPEC,N_LEN,C_STD_CODE,C_MAT_CODE,C_MAT_NAME,N_WGT,C_STOCK_CODE,C_STOCK_CODE_TO,C_AREA_CODE,C_KW_CODE,C_FLOOD_CODE,N_QUA,D_MOVE_DATE,C_MOVE_GROUP,C_MOVE_SHIFT,C_MOVE_EMP_ID,N_STATUS,C_REMARK,C_ZKDH, from TSC_SLAB_MOVE ");
            strSql.Append(" where C_ZKDH=:C_ZKDH ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ZKDH", OracleDbType.Varchar2,100)         };
            parameters[0].Value = C_ZKDH;

            Mod_TSC_SLAB_MOVE model = new Mod_TSC_SLAB_MOVE();
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
        /// 获取最大转库单号
        /// </summary>
        /// <returns></returns>
        public DataSet Get_Max_ZKDH()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT max(substr(T.C_ZKDH,3))as C_ZKDH,max(substr(T.C_ZKDHID,3))as C_ZKDHID FROM TSC_SLAB_MOVE T  ");

            return DbHelperOra.Query(strSql.ToString());
        }


        /// <summary>
        /// 更新装车状态
        /// </summary>
        /// <param name="stove">炉号</param>
        /// <param name="grd">钢种</param>
        /// <param name="spec">规格</param>
        /// <param name="std">执行标准</param>
        /// <param name="matCode">物料编码</param>
        /// <param name="num">支数</param>
        /// <param name="slabwhCode_OLD">原仓库</param>
        /// <param name="shift">班组</param>
        /// <param name="group">班次</param>
        /// <param name="strUserID">操作人ID</param>
        /// <param name="dtTime">操作时间</param>
        /// <param name="billet">钢坯列表</param>
        /// <returns></returns>
        public int UpdateLodingType(string stove, string grd, string spec, string std,
            string matCode, int num, string slabwhCode_OLD, string shift, string group, string strUserID, DateTime dtTime, out DataTable billet, string kpBatch, string remark)
        {
            StringBuilder strSql = new StringBuilder();

            strSql.Append("SELECT * FROM TSC_SLAB_MAIN T  WHERE T.C_MOVE_TYPE='E' AND T.C_SLABWH_CODE ='" + slabwhCode_OLD + "' ");

            if (!string.IsNullOrEmpty(stove))
            {
                strSql.Append(" and T.C_STOVE='" + stove + "' ");
            }

            if (!string.IsNullOrEmpty(grd))
            {
                strSql.Append(" and T.C_STL_GRD='" + grd + "' ");
            }

            if (!string.IsNullOrEmpty(spec))
            {
                strSql.Append(" and T.C_SPEC='" + spec + "' ");
            }

            if (!string.IsNullOrEmpty(std))
            {
                strSql.Append(" and T.C_STD_CODE='" + std + "' ");
            }

            if (!string.IsNullOrEmpty(matCode))
            {
                strSql.Append(" and T.C_MAT_CODE='" + matCode + "' ");
            }

            if (!string.IsNullOrEmpty(kpBatch))
            {
                strSql.Append(" and T.C_BATCH_NO='" + kpBatch + "' ");
            }

            strSql.Append(" AND  ROWNUM <=" + num + " ");


            DataTable slabDt = DbHelperOra.Query(strSql.ToString()).Tables[0];
            billet = slabDt;
            if (slabDt == null || slabDt.Rows.Count == 0)
                return 0;

            string strKWType = Get_KW_Type(slabDt.Rows[0]["C_SLABWH_LOC_CODE"].ToString());//库位类型

            StringBuilder strSql_Up = new StringBuilder();

            strSql_Up.Append("UPDATE TSC_SLAB_MAIN TSM SET TSM.C_WL_SHIFT='" + shift + "',TSM.C_WL_GROUP='" + group + "',TSM.C_WL_EMP_ID='" + strUserID + "',TSM.C_REMARK='" + remark + "',TSM.C_JUDGE_LEV_ZH_PEOPLE='1' ");

            strSql_Up.Append(" WHERE TSM.C_ID IN( ");
            if (slabDt != null && slabDt.Rows.Count > 0)
            {
                for (int i = 0; i < slabDt.Rows.Count; i++)
                {
                    if (i == slabDt.Rows.Count - 1)
                        strSql_Up.Append("'" + slabDt.Rows[i]["C_ID"] + "'");
                    else
                        strSql_Up.Append("'" + slabDt.Rows[i]["C_ID"] + "',");
                }
            }
            strSql_Up.Append(" ) ");

            return TransactionHelper.ExecuteSql(strSql_Up.ToString());
        }

        #endregion  BasicMethod
    }
}

