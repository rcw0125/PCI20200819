using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;
using System.Collections.Generic;

namespace DAL
{
    public class Dal_TRC_WARM_FURNACE
    {
        public Dal_TRC_WARM_FURNACE()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string C_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TRC_WARM_FURNACE");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)            };
            parameters[0].Value = C_ID;

            return DbHelperOra.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Mod_TRC_WARM_FURNACE model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TRC_WARM_FURNACE(");
            strSql.Append("C_BATCH_NO,N_QUA_JOIN,N_WGT_JOIN,C_TRC_ROLL_MAIN_ID,N_ROLL_STATE,D_MOD_DT,C_EMP_ID,C_STA_ID,C_SHIFT,C_GROUP,N_QUA_EXIT,N_WGT_EXIT,C_SLAB_MAIN_ID,C_STOVE,N_LEN,C_MAT_CODE,C_MAT_NAME)");
            strSql.Append(" values (");
            strSql.Append(":C_BATCH_NO,:N_QUA_JOIN,:N_WGT_JOIN,:C_TRC_ROLL_MAIN_ID,:N_ROLL_STATE,:D_MOD_DT,:C_EMP_ID,:C_STA_ID,:C_SHIFT,:C_GROUP,:N_QUA_EXIT,:N_WGT_EXIT,:C_SLAB_MAIN_ID,:C_STOVE,:N_LEN,:C_MAT_CODE,:C_MAT_NAME)");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_BATCH_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_QUA_JOIN", OracleDbType.Decimal,15),
                    new OracleParameter(":N_WGT_JOIN", OracleDbType.Decimal,15),
                    new OracleParameter(":C_TRC_ROLL_MAIN_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_ROLL_STATE", OracleDbType.Decimal,4),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STA_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SHIFT", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_GROUP", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_QUA_EXIT", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_WGT_EXIT", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SLAB_MAIN_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STOVE", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_LEN", OracleDbType.Decimal,5),
                    new OracleParameter(":C_MAT_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MAT_NAME", OracleDbType.Varchar2,100)
            };
            parameters[0].Value = model.C_BATCH_NO;
            parameters[1].Value = model.N_QUA_JOIN;
            parameters[2].Value = model.N_WGT_JOIN;
            parameters[3].Value = model.C_TRC_ROLL_MAIN_ID;
            parameters[4].Value = model.N_ROLL_STATE;
            parameters[5].Value = model.D_MOD_DT;
            parameters[6].Value = model.C_EMP_ID;
            parameters[7].Value = model.C_STA_ID;
            parameters[8].Value = model.C_SHIFT;
            parameters[9].Value = model.C_GROUP;
            parameters[10].Value = model.N_QUA_EXIT;
            parameters[11].Value = model.N_WGT_EXIT;
            parameters[12].Value = model.C_SLAB_MAIN_ID;
            parameters[13].Value = model.C_STOVE;
            parameters[14].Value = model.N_LEN;
            parameters[15].Value = model.C_MAT_CODE;
            parameters[16].Value = model.C_MAT_NAME;

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
        public bool Update(Mod_TRC_WARM_FURNACE model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TRC_WARM_FURNACE set ");
            strSql.Append("C_BATCH_NO=:C_BATCH_NO,");
            strSql.Append("N_QUA_JOIN=:N_QUA_JOIN,");
            strSql.Append("N_WGT_JOIN=:N_WGT_JOIN,");
            strSql.Append("C_TRC_ROLL_MAIN_ID=:C_TRC_ROLL_MAIN_ID,");
            strSql.Append("N_ROLL_STATE=:N_ROLL_STATE,");
            strSql.Append("D_MOD_DT=:D_MOD_DT,");
            strSql.Append("C_EMP_ID=:C_EMP_ID,");
            strSql.Append("C_STA_ID=:C_STA_ID");
            strSql.Append("C_SHIFT=:C_SHIFT");
            strSql.Append("C_GROUP=:C_GROUP");
            strSql.Append("N_QUA_EXIT=:N_QUA_EXIT");
            strSql.Append("N_WGT_EXIT=:N_WGT_EXIT");
            strSql.Append("C_SLAB_MAIN_ID=:C_SLAB_MAIN_ID");
            strSql.Append("C_STOVE=:C_STOVE,");
            strSql.Append("N_LEN=:N_LEN,");
            strSql.Append("C_MAT_CODE=:C_MAT_CODE,");
            strSql.Append("C_MAT_NAME=:C_MAT_NAME");
            strSql.Append(" where C_ID=:C_ID ");

            OracleParameter[] parameters = {
                    new OracleParameter(":C_BATCH_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_QUA_JOIN", OracleDbType.Decimal,15),
                    new OracleParameter(":N_WGT_JOIN", OracleDbType.Decimal,15),
                    new OracleParameter(":C_TRC_ROLL_MAIN_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_ROLL_STATE", OracleDbType.Decimal,4),
                    new OracleParameter(":D_MOD_DT", OracleDbType.Date),
                    new OracleParameter(":C_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STA_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SHIFT", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_GROUP", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_QUA_EXIT", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_WGT_EXIT", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SLAB_MAIN_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STOVE", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_LEN", OracleDbType.Decimal,5),
                    new OracleParameter(":C_MAT_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MAT_NAME", OracleDbType.Varchar2,100)
            };
            parameters[0].Value = model.C_BATCH_NO;
            parameters[1].Value = model.N_QUA_JOIN;
            parameters[2].Value = model.N_WGT_JOIN;
            parameters[3].Value = model.C_TRC_ROLL_MAIN_ID;
            parameters[4].Value = model.N_ROLL_STATE;
            parameters[5].Value = model.D_MOD_DT;
            parameters[6].Value = model.C_EMP_ID;
            parameters[7].Value = model.C_STA_ID;
            parameters[8].Value = model.C_ID;
            parameters[9].Value = model.C_SHIFT;
            parameters[10].Value = model.C_GROUP;
            parameters[11].Value = model.N_QUA_EXIT;
            parameters[12].Value = model.N_WGT_EXIT;
            parameters[13].Value = model.C_SLAB_MAIN_ID;
            parameters[14].Value = model.C_STOVE;
            parameters[15].Value = model.N_LEN;
            parameters[16].Value = model.C_MAT_CODE;
            parameters[17].Value = model.C_MAT_NAME;

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
            strSql.Append("delete from TRC_WARM_FURNACE ");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)            };
            parameters[0].Value = C_ID;

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
        public bool Del(string C_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" UPDATE TRC_WARM_FURNACE  SET N_STATUS = 1 ");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)            };
            parameters[0].Value = C_ID;

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
            strSql.Append("delete from TRC_WARM_FURNACE ");
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
        public Mod_TRC_WARM_FURNACE GetModel(string C_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_BATCH_NO,N_QUA_JOIN,N_WGT_JOIN,C_TRC_ROLL_MAIN_ID,N_ROLL_STATE,D_MOD_DT,C_EMP_ID,C_STA_ID,C_SHIFT,C_GROUP,N_QUA_EXIT,N_WGT_EXIT,C_SLAB_MAIN_ID,C_STOVE,N_LEN,C_MAT_CODE,C_MAT_NAME from TRC_WARM_FURNACE ");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)            };
            parameters[0].Value = C_ID;

            Mod_TRC_WARM_FURNACE model = new Mod_TRC_WARM_FURNACE();
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
        public Mod_TRC_WARM_FURNACE DataRowToModel(DataRow row)
        {
            Mod_TRC_WARM_FURNACE model = new Mod_TRC_WARM_FURNACE();
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
                if (row["N_QUA_JOIN"] != null && row["N_QUA_JOIN"].ToString() != "")
                {
                    model.N_QUA_JOIN = decimal.Parse(row["N_QUA_JOIN"].ToString());
                }
                if (row["N_WGT_JOIN"] != null && row["N_WGT_JOIN"].ToString() != "")
                {
                    model.N_WGT_JOIN = decimal.Parse(row["N_WGT_JOIN"].ToString());
                }
                if (row["C_TRC_ROLL_MAIN_ID"] != null)
                {
                    model.C_TRC_ROLL_MAIN_ID = row["C_TRC_ROLL_MAIN_ID"].ToString();
                }
                if (row["N_ROLL_STATE"] != null && row["N_ROLL_STATE"].ToString() != "")
                {
                    model.N_ROLL_STATE = decimal.Parse(row["N_ROLL_STATE"].ToString());
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
                if (row["C_SHIFT"] != null)
                {
                    model.C_SHIFT = row["C_SHIFT"].ToString();
                }
                if (row["C_GROUP"] != null)
                {
                    model.C_GROUP = row["C_GROUP"].ToString();
                }
                if (row["N_QUA_EXIT"] != null && row["N_QUA_EXIT"].ToString() != "")
                {
                    model.N_QUA_EXIT = decimal.Parse(row["N_QUA_EXIT"].ToString());
                }
                if (row["N_WGT_EXIT"] != null && row["N_WGT_EXIT"].ToString() != "")
                {
                    model.N_WGT_EXIT = decimal.Parse(row["N_WGT_EXIT"].ToString());
                }
                if (row["C_SLAB_MAIN_ID"] != null)
                {
                    model.C_SLAB_MAIN_ID = row["C_SLAB_MAIN_ID"].ToString();
                }
                if (row["C_STOVE"] != null)
                {
                    model.C_STOVE = row["C_STOVE"].ToString();
                }
                if (row["N_LEN"] != null && row["N_LEN"].ToString() != "")
                {
                    model.N_LEN = decimal.Parse(row["N_LEN"].ToString());
                }
                if (row["C_MAT_CODE"] != null)
                {
                    model.C_MAT_CODE = row["C_MAT_CODE"].ToString();
                }
                if (row["C_MAT_NAME"] != null)
                {
                    model.C_MAT_NAME = row["C_MAT_NAME"].ToString();
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
            strSql.Append("select C_ID,C_BATCH_NO,N_QUA_JOIN,N_WGT_JOIN,C_TRC_ROLL_MAIN_ID,N_ROLL_STATE,D_MOD_DT,C_EMP_ID,C_STA_ID,C_SHIFT,C_GROUP,N_QUA_EXIT,N_WGT_EXIT,C_SLAB_MAIN_ID,C_STOVE,N_LEN,C_MAT_CODE,C_MAT_NAME ");
            strSql.Append(" FROM TRC_WARM_FURNACE ");
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
            strSql.Append("select count(1) FROM TRC_WARM_FURNACE ");
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
            strSql.Append(")AS Row, T.*  from TRC_WARM_FURNACE T ");
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
        /// <summary>
        /// 获取出炉时间
        /// </summary>
        /// <returns></returns>
        public object GetOutTime(string id)
        {
            string sql = @"SELECT MAX(TWF.D_MOD_DT) FROM TRC_WARM_FURNACE TWF
                                    WHERE TWF.C_TRC_ROLL_MAIN_ID='" + id + "'  ";
            sql += "  AND TWF.N_ROLL_STATE = 3  ";
            return DbHelperOra.GetSingle(sql);
        }

        /// <summary>
        /// 获取钢种信息
        /// </summary>
        public DataTable GetSlabMainInfo(string id, out DataTable consumeDt)
        {
            string query1 = @"SELECT T.C_SLAB_MAIN_ID C_SLAB_MAIN_ID from TRC_ROLL_MAIN_ITEM t WHERE T.C_ROLL_MAIN_ID='" + id + "'";
            DataTable dt = DbHelperOra.Query(query1).Tables[0];
            DataTable dt2 = new DataTable();
            if (dt != null && dt.Rows.Count > 0)
            {
                string query2 = @"SELECT  T.C_MAT_CODE  
                                                           ,SUM(T.N_WGT)N_WGT
                                                           ,COUNT(T.C_ID)N_QUA
                                                           ,C_STOVE
                                                           ,T.C_STL_GRD
                                                           ,T.C_STD_CODE
                                                           ,T.C_BATCH_NO
                                                           ,MAX(T.c_slabwh_code) c_slabwh_code
                                                           ,MAX(T.C_ZYX1) C_ZYX1
                                                           ,MAX(T.C_ZYX2)C_ZYX2
                                                    FROM TSC_SLAB_MAIN  T where  1=1 
                                                   AND  ( ";
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (i == dt.Rows.Count - 1)
                        query2 += " T.C_ID='" + dt.Rows[i]["C_SLAB_MAIN_ID"].ToString() + "'";
                    else
                        query2 += "  T.C_ID= '" + dt.Rows[i]["C_SLAB_MAIN_ID"].ToString() + "' OR ";
                }
                query2 += " ) GROUP BY T.C_MAT_CODE,T.C_STOVE,T.C_STL_GRD,T.C_STD_CODE,T.C_BATCH_NO  ";
                dt2 = DbHelperOra.Query(query2).Tables[0];
            }
            consumeDt = dt;
            return dt2;
        }

        /// <summary>
        /// 消耗钢坯
        /// </summary>
        /// <returns></returns>
        public bool ConsumeSlab(DataTable consumeDt)
        {
            int rows = 0;
            if (consumeDt != null && consumeDt.Rows.Count > 0)
            {
                string query2 = @" UPDATE TSC_SLAB_MAIN T 
                                          SET T.C_MOVE_TYPE='EX'
                                          where  1=1 
                                          AND  ( ";
                for (int i = 0; i < consumeDt.Rows.Count; i++)
                {
                    if (i == consumeDt.Rows.Count - 1)
                        query2 += " T.C_ID='" + consumeDt.Rows[i]["C_SLAB_MAIN_ID"].ToString() + "'";
                    else
                        query2 += "  T.C_ID= '" + consumeDt.Rows[i]["C_SLAB_MAIN_ID"].ToString() + "' OR ";
                }
                query2 += " )  ";
                rows = DbHelperOra.ExecuteSql(query2);
            }
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
        /// 获取钢种信息
        /// </summary>
        public DataTable GetSlabMainInfoKp(string id)
        {
            string query1 = @"SELECT T.C_SLAB_MAIN_ID C_SLAB_MAIN_ID from TRC_COGDOWN_MAIN_ITEM t WHERE T.C_COGDOWN_MAIN_ID='" + id + "'";
            DataTable dt = DbHelperOra.Query(query1).Tables[0];
            DataTable dt2 = new DataTable();
            if (dt != null && dt.Rows.Count > 0)
            {
                string query2 = @"SELECT  T.C_MAT_CODE  
                                                           ,SUM(T.N_WGT)N_WGT
                                                           ,COUNT(T.C_ID)N_QUA
                                                           ,C_STOVE
                                                           ,T.C_STL_GRD
                                                           ,T.C_STD_CODE
                                                           ,T.C_BATCH_NO
                                                           ,MAX(T.C_ZYX1) C_ZYX1
                                                           ,MAX(T.C_ZYX2)C_ZYX2
                                                    FROM TSC_SLAB_MAIN  T where  1=1
                                                   AND  ( ";
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (i == dt.Rows.Count - 1)
                        query2 += " T.C_ID='" + dt.Rows[i]["C_SLAB_MAIN_ID"].ToString() + "'";
                    else
                        query2 += "  T.C_ID= '" + dt.Rows[i]["C_SLAB_MAIN_ID"].ToString() + "' OR ";
                }
                query2 += " ) GROUP BY T.C_MAT_CODE,T.C_STOVE,T.C_STL_GRD,T.C_STD_CODE,T.C_BATCH_NO  ";
                dt2 = DbHelperOra.Query(query2).Tables[0];
            }
            return dt2;
        }


        /// <summary>
        /// 更新加热炉轧制状态
        /// </summary>
        /// <param name="rollMainID"></param>
        /// <returns></returns>
        public int UpdateWarmFurnaceRolleState(string rollMainID, int newStatus, int oldStatus)
        {
            string sql = @"UPDATE TRC_WARM_FURNACE TWF  SET TWF.N_ROLL_STATE=" + newStatus + "   WHERE TWF.C_TRC_ROLL_MAIN_ID='" + rollMainID + "'   AND   TWF.N_ROLL_STATE=" + oldStatus + " ";
            return TransactionHelper.ExecuteSql(sql);
        }

        /// <summary>
        /// 更新加热炉轧制状态
        /// </summary>
        /// <param name="rollMainID"></param>
        /// <returns></returns>
        public int UpdateWarmFurnaceRolleStateTran(string rollMainID, int newStatus, int oldStatus)
        {
            string sql = @"UPDATE TRC_WARM_FURNACE TWF  SET TWF.N_ROLL_STATE=" + newStatus + "   WHERE TWF.C_TRC_ROLL_MAIN_ID='" + rollMainID + "'   AND   TWF.N_ROLL_STATE=" + oldStatus + " ";
            return TransactionHelper.ExecuteSql(sql);
        }

        /// <summary>
        /// 更新加热炉重量
        /// </summary>
        /// <param name="rollMainID"></param>
        /// <returns></returns>
        public int UpdateWarmFurnaceWgt(string rollMainID, decimal wgt)
        {
            string sql = @"UPDATE TRC_WARM_FURNACE TWF  SET TWF.N_WGT_JOIN=TWF.N_WGT_JOIN-" + wgt + "   WHERE TWF.C_TRC_ROLL_MAIN_ID='" + rollMainID + "' ";
            return TransactionHelper.ExecuteSql(sql);
        }

        /// <summary>
        /// 获取加热炉支数
        /// </summary>
        /// <param name="rollMainID"></param>
        /// <returns></returns>
        public int GetFurnaceCount(string rollMainID)
        {
            string sql = @"SELECT COUNT(C_ID) FROM TRC_WARM_FURNACE T
                           WHERE T.C_TRC_ROLL_MAIN_ID='" + rollMainID + "'";
            object obj = DbHelperOra.GetSingle(sql);
            return (int)obj;
        }

        #endregion  ExtensionMethod
    }
}
