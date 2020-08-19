using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;
using System.Collections.Generic;

namespace DAL
{
    /// <summary>
    /// 数据访问类:TSC_SLAB_STACK
    /// </summary>
    public partial class Dal_TSC_SLAB_STACK
    {
        public Dal_TSC_SLAB_STACK()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string C_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TSC_SLAB_STACK");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)         };
            parameters[0].Value = C_ID;

            return DbHelperOra.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Mod_TSC_SLAB_STACK model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TSC_SLAB_STACK(");
            strSql.Append("C_SLAB_MAIN_ID,C_STA_ID,C_STOVE,C_STL_GRD,C_SPEC,N_LEN,C_STD_CODE,C_MAT_CODE,C_MAT_NAME,N_WGT,C_STOCK_CODE_OLD,C_AREA_CODE_OLD,C_KW_CODE_OLD,C_FLOOD_CODE_OLD,C_STOCK_CODE_NEW,C_AREA_CODE_NEW,C_KW_CODE_NEW,C_FLOOD_CODE_NEW,N_QUA,D_STACK_DATE,C_STACK_GROUP,C_STACK_SHIFT,C_STACK_EMP_ID,N_STATUS,C_REMARK,C_BATCH_NO)");
            strSql.Append(" values (");
            strSql.Append(":C_SLAB_MAIN_ID,:C_STA_ID,:C_STOVE,:C_STL_GRD,:C_SPEC,:N_LEN,:C_STD_CODE,:C_MAT_CODE,:C_MAT_NAME,:N_WGT,:C_STOCK_CODE_OLD,:C_AREA_CODE_OLD,:C_KW_CODE_OLD,:C_FLOOD_CODE_OLD,:C_STOCK_CODE_NEW,:C_AREA_CODE_NEW,:C_KW_CODE_NEW,:C_FLOOD_CODE_NEW,:N_QUA,:D_STACK_DATE,:C_STACK_GROUP,:C_STACK_SHIFT,:C_STACK_EMP_ID,:N_STATUS,:C_REMARK,:C_BATCH_NO)");
            OracleParameter[] parameters = {
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
                    new OracleParameter(":C_STOCK_CODE_OLD", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_AREA_CODE_OLD", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_KW_CODE_OLD", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_FLOOD_CODE_OLD", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STOCK_CODE_NEW", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_AREA_CODE_NEW", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_KW_CODE_NEW", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_FLOOD_CODE_NEW", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_QUA", OracleDbType.Decimal,5),
                    new OracleParameter(":D_STACK_DATE", OracleDbType.Date),
                    new OracleParameter(":C_STACK_GROUP", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STACK_SHIFT", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STACK_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_BATCH_NO", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.C_SLAB_MAIN_ID;
            parameters[1].Value = model.C_STA_ID;
            parameters[2].Value = model.C_STOVE;
            parameters[3].Value = model.C_STL_GRD;
            parameters[4].Value = model.C_SPEC;
            parameters[5].Value = model.N_LEN;
            parameters[6].Value = model.C_STD_CODE;
            parameters[7].Value = model.C_MAT_CODE;
            parameters[8].Value = model.C_MAT_NAME;
            parameters[9].Value = model.N_WGT;
            parameters[10].Value = model.C_STOCK_CODE_OLD;
            parameters[11].Value = model.C_AREA_CODE_OLD;
            parameters[12].Value = model.C_KW_CODE_OLD;
            parameters[13].Value = model.C_FLOOD_CODE_OLD;
            parameters[14].Value = model.C_STOCK_CODE_NEW;
            parameters[15].Value = model.C_AREA_CODE_NEW;
            parameters[16].Value = model.C_KW_CODE_NEW;
            parameters[17].Value = model.C_FLOOD_CODE_NEW;
            parameters[18].Value = model.N_QUA;
            parameters[19].Value = model.D_STACK_DATE;
            parameters[20].Value = model.C_STACK_GROUP;
            parameters[21].Value = model.C_STACK_SHIFT;
            parameters[22].Value = model.C_STACK_EMP_ID;
            parameters[23].Value = model.N_STATUS;
            parameters[24].Value = model.C_REMARK;
            parameters[25].Value = model.C_BATCH_NO;

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
        public bool Update(Mod_TSC_SLAB_STACK model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TSC_SLAB_STACK set ");
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
            strSql.Append("C_STOCK_CODE_OLD=:C_STOCK_CODE_OLD,");
            strSql.Append("C_AREA_CODE_OLD=:C_AREA_CODE_OLD,");
            strSql.Append("C_KW_CODE_OLD=:C_KW_CODE_OLD,");
            strSql.Append("C_FLOOD_CODE_OLD=:C_FLOOD_CODE_OLD,");
            strSql.Append("C_STOCK_CODE_NEW=:C_STOCK_CODE_NEW,");
            strSql.Append("C_AREA_CODE_NEW=:C_AREA_CODE_NEW,");
            strSql.Append("C_KW_CODE_NEW=:C_KW_CODE_NEW,");
            strSql.Append("C_FLOOD_CODE_NEW=:C_FLOOD_CODE_NEW,");
            strSql.Append("N_QUA=:N_QUA,");
            strSql.Append("D_STACK_DATE=:D_STACK_DATE,");
            strSql.Append("C_STACK_GROUP=:C_STACK_GROUP,");
            strSql.Append("C_STACK_SHIFT=:C_STACK_SHIFT,");
            strSql.Append("C_STACK_EMP_ID=:C_STACK_EMP_ID,");
            strSql.Append("N_STATUS=:N_STATUS,");
            strSql.Append("C_REMARK=:C_REMARK,");
            strSql.Append("C_BATCH_NO=:C_BATCH_NO");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
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
                    new OracleParameter(":C_STOCK_CODE_OLD", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_AREA_CODE_OLD", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_KW_CODE_OLD", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_FLOOD_CODE_OLD", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STOCK_CODE_NEW", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_AREA_CODE_NEW", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_KW_CODE_NEW", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_FLOOD_CODE_NEW", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_QUA", OracleDbType.Decimal,5),
                    new OracleParameter(":D_STACK_DATE", OracleDbType.Date),
                    new OracleParameter(":C_STACK_GROUP", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STACK_SHIFT", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STACK_EMP_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,1),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_BATCH_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.C_SLAB_MAIN_ID;
            parameters[1].Value = model.C_STA_ID;
            parameters[2].Value = model.C_STOVE;
            parameters[3].Value = model.C_STL_GRD;
            parameters[4].Value = model.C_SPEC;
            parameters[5].Value = model.N_LEN;
            parameters[6].Value = model.C_STD_CODE;
            parameters[7].Value = model.C_MAT_CODE;
            parameters[8].Value = model.C_MAT_NAME;
            parameters[9].Value = model.N_WGT;
            parameters[10].Value = model.C_STOCK_CODE_OLD;
            parameters[11].Value = model.C_AREA_CODE_OLD;
            parameters[12].Value = model.C_KW_CODE_OLD;
            parameters[13].Value = model.C_FLOOD_CODE_OLD;
            parameters[14].Value = model.C_STOCK_CODE_NEW;
            parameters[15].Value = model.C_AREA_CODE_NEW;
            parameters[16].Value = model.C_KW_CODE_NEW;
            parameters[17].Value = model.C_FLOOD_CODE_NEW;
            parameters[18].Value = model.N_QUA;
            parameters[19].Value = model.D_STACK_DATE;
            parameters[20].Value = model.C_STACK_GROUP;
            parameters[21].Value = model.C_STACK_SHIFT;
            parameters[22].Value = model.C_STACK_EMP_ID;
            parameters[23].Value = model.N_STATUS;
            parameters[24].Value = model.C_REMARK;
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
            strSql.Append("delete from TSC_SLAB_STACK ");
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
            strSql.Append("delete from TSC_SLAB_STACK ");
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
        public Mod_TSC_SLAB_STACK GetModel(string C_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_SLAB_MAIN_ID,C_STA_ID,C_STOVE,C_STL_GRD,C_SPEC,N_LEN,C_STD_CODE,C_MAT_CODE,C_MAT_NAME,N_WGT,C_STOCK_CODE_OLD,C_AREA_CODE_OLD,C_KW_CODE_OLD,C_FLOOD_CODE_OLD,C_STOCK_CODE_NEW,C_AREA_CODE_NEW,C_KW_CODE_NEW,C_FLOOD_CODE_NEW,N_QUA,D_STACK_DATE,C_STACK_GROUP,C_STACK_SHIFT,C_STACK_EMP_ID,N_STATUS,C_REMARK,C_BATCH_NO from TSC_SLAB_STACK ");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)         };
            parameters[0].Value = C_ID;

            Mod_TSC_SLAB_STACK model = new Mod_TSC_SLAB_STACK();
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
        public Mod_TSC_SLAB_STACK DataRowToModel(DataRow row)
        {
            Mod_TSC_SLAB_STACK model = new Mod_TSC_SLAB_STACK();
            if (row != null)
            {
                if (row["C_ID"] != null)
                {
                    model.C_ID = row["C_ID"].ToString();
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
                if (row["C_STOCK_CODE_OLD"] != null)
                {
                    model.C_STOCK_CODE_OLD = row["C_STOCK_CODE_OLD"].ToString();
                }
                if (row["C_AREA_CODE_OLD"] != null)
                {
                    model.C_AREA_CODE_OLD = row["C_AREA_CODE_OLD"].ToString();
                }
                if (row["C_KW_CODE_OLD"] != null)
                {
                    model.C_KW_CODE_OLD = row["C_KW_CODE_OLD"].ToString();
                }
                if (row["C_FLOOD_CODE_OLD"] != null)
                {
                    model.C_FLOOD_CODE_OLD = row["C_FLOOD_CODE_OLD"].ToString();
                }
                if (row["C_STOCK_CODE_NEW"] != null)
                {
                    model.C_STOCK_CODE_NEW = row["C_STOCK_CODE_NEW"].ToString();
                }
                if (row["C_AREA_CODE_NEW"] != null)
                {
                    model.C_AREA_CODE_NEW = row["C_AREA_CODE_NEW"].ToString();
                }
                if (row["C_KW_CODE_NEW"] != null)
                {
                    model.C_KW_CODE_NEW = row["C_KW_CODE_NEW"].ToString();
                }
                if (row["C_FLOOD_CODE_NEW"] != null)
                {
                    model.C_FLOOD_CODE_NEW = row["C_FLOOD_CODE_NEW"].ToString();
                }
                if (row["N_QUA"] != null && row["N_QUA"].ToString() != "")
                {
                    model.N_QUA = decimal.Parse(row["N_QUA"].ToString());
                }
                if (row["D_STACK_DATE"] != null && row["D_STACK_DATE"].ToString() != "")
                {
                    model.D_STACK_DATE = DateTime.Parse(row["D_STACK_DATE"].ToString());
                }
                if (row["C_STACK_GROUP"] != null)
                {
                    model.C_STACK_GROUP = row["C_STACK_GROUP"].ToString();
                }
                if (row["C_STACK_SHIFT"] != null)
                {
                    model.C_STACK_SHIFT = row["C_STACK_SHIFT"].ToString();
                }
                if (row["C_STACK_EMP_ID"] != null)
                {
                    model.C_STACK_EMP_ID = row["C_STACK_EMP_ID"].ToString();
                }
                if (row["N_STATUS"] != null && row["N_STATUS"].ToString() != "")
                {
                    model.N_STATUS = decimal.Parse(row["N_STATUS"].ToString());
                }
                if (row["C_REMARK"] != null)
                {
                    model.C_REMARK = row["C_REMARK"].ToString();
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
            strSql.Append("select C_ID,C_SLAB_MAIN_ID,C_STA_ID,C_STOVE,C_STL_GRD,C_SPEC,N_LEN,C_STD_CODE,C_MAT_CODE,C_MAT_NAME,N_WGT,C_STOCK_CODE_OLD,C_AREA_CODE_OLD,C_KW_CODE_OLD,C_FLOOD_CODE_OLD,C_STOCK_CODE_NEW,C_AREA_CODE_NEW,C_KW_CODE_NEW,C_FLOOD_CODE_NEW,N_QUA,D_STACK_DATE,C_STACK_GROUP,C_STACK_SHIFT,C_STACK_EMP_ID,N_STATUS,C_REMARK,C_BATCH_NO ");
            strSql.Append(" FROM TSC_SLAB_STACK ");
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
            strSql.Append("select count(1) FROM TSC_SLAB_STACK ");
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
            string matCode, int num, string slabwhCode, string area_OLD, string kw_OLD, string floor_OLD, string area, string kw, string floor, string shift, string group, string strUserID, DateTime dtTime, out DataTable billet, string kpBatch, string remark)
        {
            StringBuilder strSql = new StringBuilder();

            strSql.Append("SELECT * FROM TSC_SLAB_MAIN T  WHERE T.C_MOVE_TYPE='E' ");

            if (!string.IsNullOrEmpty(slabwhCode))
            {
                strSql.Append(" and T.C_SLABWH_CODE='" + slabwhCode + "' ");
            }

            if (!string.IsNullOrEmpty(area_OLD))
            {
                strSql.Append(" and T.C_SLABWH_AREA_CODE='" + area_OLD + "' ");
            }

            if (!string.IsNullOrEmpty(kw_OLD))
            {
                strSql.Append(" and T.C_SLABWH_LOC_CODE='" + kw_OLD + "' ");
            }

            if (!string.IsNullOrEmpty(floor_OLD))
            {
                strSql.Append(" and T.C_SLABWH_TIER_CODE='" + floor_OLD + "' ");
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

            StringBuilder strSql_Up = new StringBuilder();
            strSql_Up.Append("UPDATE TSC_SLAB_MAIN TSM SET TSM.C_SLABWH_AREA_CODE='" + area + "',TSM.C_SLABWH_LOC_CODE='" + kw + "',TSM.C_SLABWH_TIER_CODE='" + floor + "',TSM.D_STACK_DATE=to_date('" + dtTime + "','yyyy-mm-dd hh24:mi:ss'),TSM.C_STACK_SHIFT='" + shift + "',TSM.C_STACK_GROUP='" + group + "',TSM.C_STACK_USER='" + strUserID + "',TSM.C_REMARK='" + remark + "' ");

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
        /// 获取入库记录
        /// </summary>
        /// <param name="strKW">库位编码</param>
        /// <param name="strStove">炉号</param>
        /// <param name="strTimeStart">开始时间</param>
        /// <param name="strTimeEnd">结束时间</param>
        /// <param name="kwCode">库位</param>
        /// <returns></returns>
        public DataSet Get_DD_Log(string strKW, string strStove, string strTimeStart, string strTimeEnd, string kwCode)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT TB.C_STA_DESC, T.C_STOVE,T.C_BATCH_NO, T.C_STL_GRD, T.C_SPEC, T.N_LEN, T.C_STD_CODE, T.C_MAT_CODE, T.C_MAT_NAME, SUM(T.N_WGT) AS N_WGT, T.C_STOCK_CODE_OLD, T.C_AREA_CODE_OLD, T.C_KW_CODE_OLD, T.C_FLOOD_CODE_OLD, T.C_STOCK_CODE_NEW, T.C_AREA_CODE_NEW, T.C_KW_CODE_NEW, T.C_FLOOD_CODE_NEW, COUNT(1) AS N_QUA, T.D_STACK_DATE, T.C_STACK_GROUP, T.C_STACK_SHIFT, TC.C_NAME, (SELECT OTS.C_SLABWH_NAME FROM TPB_SLABWH OTS WHERE OTS.C_SLABWH_CODE= T.C_STOCK_CODE_OLD AND OTS.N_STATUS=1 )C_STOCK_CODE_OLD_NAME, (SELECT OTSA.C_SLABWH_AREA_NAME FROM TPB_SLABWH_AREA OTSA WHERE OTSA.C_SLABWH_AREA_CODE= T.C_AREA_CODE_OLD AND OTSA.N_STATUS=1)C_AREA_CODE_OLD_NAME, (SELECT OTST.C_SLABWH_LOC_NAME FROM TPB_SLABWH_LOC OTST WHERE OTST.C_SLABWH_LOC_CODE=  T.C_KW_CODE_OLD  AND  OTST.N_STATUS=1)C_KW_CODE_OLD_NAME, substr(T.C_FLOOD_CODE_OLD,-2,3)C_FLOOD_CODE_OLD_NAME, (SELECT NTS.C_SLABWH_NAME FROM TPB_SLABWH NTS WHERE NTS.C_SLABWH_CODE= T.C_STOCK_CODE_NEW  AND NTS.N_STATUS=1 )C_STOCK_CODE_NEW_NAME, (SELECT NTSA.C_SLABWH_AREA_NAME FROM TPB_SLABWH_AREA NTSA WHERE NTSA.C_SLABWH_AREA_CODE= T.C_AREA_CODE_NEW AND NTSA.N_STATUS=1)C_AREA_CODE_NEW_NAME,(SELECT NTST.C_SLABWH_LOC_NAME FROM TPB_SLABWH_LOC NTST WHERE NTST.C_SLABWH_LOC_CODE=  T.C_KW_CODE_NEW AND  NTST.N_STATUS=1)C_KW_CODE_NEW_NAME,  substr(T.C_FLOOD_CODE_NEW,-2,3)C_FLOOD_CODE_NEW_NAME, T.C_STACK_GROUP C_GROUP,   T.C_STACK_SHIFT C_SHIFT ,MAX(TSM.C_REMARK) AS C_REMARK");

            strSql.Append(" FROM TSC_SLAB_STACK T INNER JOIN TB_STA TB ON T.C_STA_ID = TB.C_ID INNER JOIN TS_USER TC ON TC.C_ID = T.C_STACK_EMP_ID LEFT JOIN TSC_SLAB_MAIN TSM ON TSM.C_ID=T.C_SLAB_MAIN_ID ");

            strSql.Append(" WHERE T.N_STATUS = 1 ");

            if (strStove.Trim() != "")
            {
                strSql.Append(" AND (T.C_STOVE like '" + strStove + "%' OR T.C_BATCH_NO like '" + strStove + "%') ");
            }

            if (strKW.Trim() != "")
            {
                strSql.Append(" AND T.C_STOCK_CODE_OLD = '" + strKW + "' ");
            }

            if (strTimeStart.Trim() != "" && strTimeEnd.Trim() != "")
            {
                strSql.Append(" AND T.D_STACK_DATE BETWEEN TO_DATE('" + strTimeStart + "', 'YYYY-MM-DD HH24:MI:SS') AND TO_DATE('" + strTimeEnd + "', 'YYYY-MM-DD HH24:MI:SS') ");
            }

            if (kwCode != null && kwCode.Trim() != "")
            {
                strSql.Append(" AND T.C_KW_CODE_NEW = '" + kwCode + "' ");
            }

            strSql.Append(" GROUP BY TB.C_STA_DESC, T.C_STOVE,T.C_BATCH_NO, T.C_STL_GRD, T.C_SPEC, T.N_LEN, T.C_STD_CODE, T.C_MAT_CODE, T.C_MAT_NAME, T.C_STOCK_CODE_OLD, T.C_AREA_CODE_OLD, T.C_KW_CODE_OLD, T.C_FLOOD_CODE_OLD, T.C_STOCK_CODE_NEW, T.C_AREA_CODE_NEW, T.C_KW_CODE_NEW, T.C_FLOOD_CODE_NEW, T.D_STACK_DATE, T.C_STACK_GROUP, T.C_STACK_SHIFT, TC.C_NAME,T.C_REMARK ");

            strSql.Append(" ORDER BY T.D_STACK_DATE DESC ");

            return DbHelperOra.Query(strSql.ToString());
        }
        /// <summary>
        /// 获取倒垛记录
        /// </summary>
        /// <param name="strTimeStart">开始时间</param>
        /// <param name="strTimeEnd">结束时间</param>
        /// <param name="strStove">炉号</param>
        /// <param name="strSTLGRD">钢种</param>
        /// <param name="strSTD">执行标准</param>
        /// <returns></returns>
        public DataSet Get_DD(string strTimeStart, string strTimeEnd, string strStove, string strSTLGRD, string strSTD)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT  T.C_STOVE as 炉号, T.C_BATCH_NO as 开坯号,  T.C_STL_GRD as 钢种, COUNT(1) AS 支数 , T.C_STD_CODE as 执行标准,    (SELECT OTS.C_SLABWH_NAME  FROM TPB_SLABWH OTS WHERE OTS.C_SLABWH_CODE = T.C_STOCK_CODE_OLD  AND OTS.N_STATUS = 1) as 原仓库,  (SELECT OTSA.C_SLABWH_AREA_NAME  FROM TPB_SLABWH_AREA OTSA WHERE OTSA.C_SLABWH_AREA_CODE = T.C_AREA_CODE_OLD  AND OTSA.N_STATUS = 1) as 原区域, (SELECT OTST.C_SLABWH_LOC_NAME  FROM TPB_SLABWH_LOC OTST  WHERE OTST.C_SLABWH_LOC_CODE = T.C_KW_CODE_OLD AND OTST.N_STATUS = 1) as 原库位,  substr(T.C_FLOOD_CODE_OLD, -2, 3) as 原层, (SELECT NTS.C_SLABWH_NAME  FROM TPB_SLABWH NTS WHERE NTS.C_SLABWH_CODE = T.C_STOCK_CODE_NEW AND NTS.N_STATUS = 1) as 新仓库, (SELECT NTSA.C_SLABWH_AREA_NAME  FROM TPB_SLABWH_AREA NTSA  WHERE NTSA.C_SLABWH_AREA_CODE = T.C_AREA_CODE_NEW  AND NTSA.N_STATUS = 1) as 新区域, (SELECT NTST.C_SLABWH_LOC_NAME FROM TPB_SLABWH_LOC NTST WHERE NTST.C_SLABWH_LOC_CODE = T.C_KW_CODE_NEW  AND NTST.N_STATUS = 1) as 新库位 , substr(T.C_FLOOD_CODE_NEW, -2, 3) as 新层, SUM(T.N_WGT) AS 重量, T.C_MAT_CODE as 物料编码, T.C_MAT_NAME as 物料描述,  T.C_SPEC as 规格, T.N_LEN as 长度 ,   to_char(T.D_STACK_DATE,'YYYY-MM-DD HH24:MI:SS') as 操作时间, T.C_STACK_GROUP as C_GROUP, T.C_STACK_SHIFT as C_SHIFT, TC.C_NAME as 操作人员,T.C_REMARK as  备注");

            strSql.Append(" FROM TSC_SLAB_STACK T INNER JOIN TB_STA TB ON T.C_STA_ID = TB.C_ID INNER JOIN TS_USER TC ON TC.C_ID = T.C_STACK_EMP_ID ");

            strSql.Append(" WHERE T.N_STATUS = 1 ");
            if (strTimeStart.Trim() != "" && strTimeEnd.Trim() != "")
            {
                strSql.Append(" AND T.D_STACK_DATE BETWEEN TO_DATE('" + strTimeStart + "', 'YYYY-MM-DD HH24:MI:SS') AND TO_DATE('" + strTimeEnd + "', 'YYYY-MM-DD HH24:MI:SS') ");
            }
            if (strStove.Trim() != "")
            {
                strSql.Append(" AND T.C_STOVE like '%" + strStove + "%' ");
            }
            if (strSTLGRD.Trim() != "")
            {
                strSql.Append(" AND upper(T.C_STL_GRD) like upper('%" + strSTLGRD + "%') ");
            }
            if (strSTD.Trim() != "")
            {
                strSql.Append(" AND T.C_STD_CODE like '%" + strSTD + "%' ");
            }
            strSql.Append(" GROUP BY TB.C_STA_DESC, T.C_STOVE,T.C_BATCH_NO, T.C_STL_GRD, T.C_SPEC, T.N_LEN, T.C_STD_CODE, T.C_MAT_CODE, T.C_MAT_NAME, T.C_STOCK_CODE_OLD, T.C_AREA_CODE_OLD, T.C_KW_CODE_OLD, T.C_FLOOD_CODE_OLD, T.C_STOCK_CODE_NEW, T.C_AREA_CODE_NEW, T.C_KW_CODE_NEW, T.C_FLOOD_CODE_NEW, T.D_STACK_DATE, T.C_STACK_GROUP, T.C_STACK_SHIFT, TC.C_NAME,T.C_REMARK ");

            strSql.Append(" ORDER BY T.D_STACK_DATE DESC ");

            return DbHelperOra.Query(strSql.ToString());
        }
        #endregion  BasicMethod
    }
}

