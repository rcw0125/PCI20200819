using System;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using MODEL;
using System.Collections.Generic;

namespace DAL
{
    /// <summary>
    /// 数据访问类:Dal_TRC_PLAN_REGROUND
    /// </summary>
    public partial class Dal_TRC_PLAN_REGROUND
    {
        public Dal_TRC_PLAN_REGROUND()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string C_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TRC_PLAN_REGROUND");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)            };
            parameters[0].Value = C_ID;

            return DbHelperOra.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Mod_TRC_PLAN_REGROUND model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TRC_PLAN_REGROUND(");
            strSql.Append("C_ID,C_BATCH_NO,C_STOVE,C_STL_GRD,C_MAT_CODE,C_MAT_NAME,C_SPEC,N_LEN,N_QUA,N_WGT,C_STD_CODE,C_SLAB_TYPE,N_STATUS,C_REMARK,C_XMGX,N_TOTALSTEP,D_QR_DATE,D_Q_DATE,N_QUA_VIRTUAL,C_SLABWH_CODE,C_SLABWH_AREA_CODE,C_SLABWH_LOC_CODE,C_SLABWH_TIER_CODE,C_XMGX_GRD,C_EXTEND16,C_EXTEND17,C_EXTEND18,C_SLABWH_XLLOC_CODE,C_EMP_CODE)");
            strSql.Append(" values (");
            strSql.Append(":C_ID,:C_BATCH_NO,:C_STOVE,:C_STL_GRD,:C_MAT_CODE,:C_MAT_NAME,:C_SPEC,:N_LEN,:N_QUA,:N_WGT,:C_STD_CODE,:C_SLAB_TYPE,:N_STATUS,:C_REMARK,:C_XMGX,:N_TOTALSTEP,:D_QR_DATE,:D_Q_DATE,:N_QUA_VIRTUAL,:C_SLABWH_CODE,:C_SLABWH_AREA_CODE,:C_SLABWH_LOC_CODE,:C_SLABWH_TIER_CODE,:C_XMGX_GRD,:C_EXTEND16,:C_EXTEND17,:C_EXTEND18,:C_SLABWH_XLLOC_CODE,:C_EMP_CODE)");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_BATCH_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STOVE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STL_GRD", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MAT_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MAT_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SPEC", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_LEN", OracleDbType.Decimal,5),
                    new OracleParameter(":N_QUA", OracleDbType.Decimal,5),
                    new OracleParameter(":N_WGT", OracleDbType.Decimal,5),
                    new OracleParameter(":C_STD_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SLAB_TYPE", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,2),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_XMGX", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_TOTALSTEP", OracleDbType.Decimal,2),
                    new OracleParameter(":D_QR_DATE", OracleDbType.Date),
                    new OracleParameter(":D_Q_DATE", OracleDbType.Date),
              new OracleParameter(":N_QUA_VIRTUAL", OracleDbType.Decimal,5),
                    new OracleParameter(":C_SLABWH_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SLABWH_AREA_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SLABWH_LOC_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SLABWH_TIER_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_XMGX_GRD", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_EXTEND16", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_EXTEND17", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_EXTEND18", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SLABWH_XLLOC_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_EMP_CODE", OracleDbType.Varchar2,100)
            };
            parameters[0].Value = model.C_ID;
            parameters[1].Value = model.C_BATCH_NO;
            parameters[2].Value = model.C_STOVE;
            parameters[3].Value = model.C_STL_GRD;
            parameters[4].Value = model.C_MAT_CODE;
            parameters[5].Value = model.C_MAT_NAME;
            parameters[6].Value = model.C_SPEC;
            parameters[7].Value = model.N_LEN;
            parameters[8].Value = model.N_QUA;
            parameters[9].Value = model.N_WGT;
            parameters[10].Value = model.C_STD_CODE;
            parameters[11].Value = model.C_SLAB_TYPE;
            parameters[12].Value = model.N_STATUS;
            parameters[13].Value = model.C_REMARK;
            parameters[14].Value = model.C_XMGX;
            parameters[15].Value = model.N_TOTALSTEP;
            parameters[16].Value = model.D_QR_DATE;
            parameters[17].Value = model.D_Q_DATE;
            parameters[18].Value = model.N_QUA_VIRTUAL;
            parameters[19].Value = model.C_SLABWH_CODE;
            parameters[20].Value = model.C_SLABWH_AREA_CODE;
            parameters[21].Value = model.C_SLABWH_LOC_CODE;
            parameters[22].Value = model.C_SLABWH_TIER_CODE;
            parameters[23].Value = model.C_XMGX_GRD;
            parameters[24].Value = model.C_EXTEND16;
            parameters[25].Value = model.C_EXTEND17;
            parameters[26].Value = model.C_EXTEND18;
            parameters[27].Value = model.C_SLABWH_XLLOC_CODE;
            parameters[28].Value = model.C_EMP_CODE;
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
        public bool Update(Mod_TRC_PLAN_REGROUND model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TRC_PLAN_REGROUND set ");
            strSql.Append("C_BATCH_NO=:C_BATCH_NO,");
            strSql.Append("C_STOVE=:C_STOVE,");
            strSql.Append("C_STL_GRD=:C_STL_GRD,");
            strSql.Append("C_MAT_CODE=:C_MAT_CODE,");
            strSql.Append("C_MAT_NAME=:C_MAT_NAME,");
            strSql.Append("C_SPEC=:C_SPEC,");
            strSql.Append("N_LEN=:N_LEN,");
            strSql.Append("N_QUA=:N_QUA,");
            strSql.Append("N_WGT=:N_WGT,");
            strSql.Append("C_STD_CODE=:C_STD_CODE,");
            strSql.Append("C_SLAB_TYPE=:C_SLAB_TYPE,");
            strSql.Append("N_STATUS=:N_STATUS,");
            strSql.Append("C_REMARK=:C_REMARK,");
            strSql.Append("C_XMGX=:C_XMGX,");
            strSql.Append("N_TOTALSTEP=:N_TOTALSTEP,");
            strSql.Append("D_QR_DATE=:D_QR_DATE,");
            strSql.Append("D_Q_DATE=:D_Q_DATE");
            strSql.Append("N_QUA_VIRTUAL=:N_QUA_VIRTUAL");
            strSql.Append("C_SLABWH_CODE=:C_SLABWH_CODE,");
            strSql.Append("C_SLABWH_AREA_CODE=:C_SLABWH_AREA_CODE,");
            strSql.Append("C_SLABWH_LOC_CODE=:C_SLABWH_LOC_CODE,");
            strSql.Append("C_SLABWH_TIER_CODE=:C_SLABWH_TIER_CODE");
            strSql.Append("C_XMGX_GRD=:C_XMGX_GRD");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_BATCH_NO", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STOVE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_STL_GRD", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MAT_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_MAT_NAME", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SPEC", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_LEN", OracleDbType.Decimal,5),
                    new OracleParameter(":N_QUA", OracleDbType.Decimal,5),
                    new OracleParameter(":N_WGT", OracleDbType.Decimal,5),
                    new OracleParameter(":C_STD_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SLAB_TYPE", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_STATUS", OracleDbType.Decimal,2),
                    new OracleParameter(":C_REMARK", OracleDbType.Varchar2,500),
                    new OracleParameter(":C_XMGX", OracleDbType.Varchar2,100),
                    new OracleParameter(":N_TOTALSTEP", OracleDbType.Decimal,2),
                    new OracleParameter(":D_QR_DATE", OracleDbType.Date),
                    new OracleParameter(":D_Q_DATE", OracleDbType.Date),
                    new OracleParameter(":N_QUA_VIRTUAL", OracleDbType.Decimal,5),
                                        new OracleParameter(":C_SLABWH_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SLABWH_AREA_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SLABWH_LOC_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_SLABWH_TIER_CODE", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_XMGX_GRD", OracleDbType.Varchar2,100),
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)};
            parameters[0].Value = model.C_BATCH_NO;
            parameters[1].Value = model.C_STOVE;
            parameters[2].Value = model.C_STL_GRD;
            parameters[3].Value = model.C_MAT_CODE;
            parameters[4].Value = model.C_MAT_NAME;
            parameters[5].Value = model.C_SPEC;
            parameters[6].Value = model.N_LEN;
            parameters[7].Value = model.N_QUA;
            parameters[8].Value = model.N_WGT;
            parameters[9].Value = model.C_STD_CODE;
            parameters[10].Value = model.C_SLAB_TYPE;
            parameters[11].Value = model.N_STATUS;
            parameters[12].Value = model.C_REMARK;
            parameters[13].Value = model.C_XMGX;
            parameters[14].Value = model.N_TOTALSTEP;
            parameters[15].Value = model.D_QR_DATE;
            parameters[16].Value = model.D_Q_DATE;
            parameters[17].Value = model.N_QUA_VIRTUAL;
            parameters[18].Value = model.C_SLABWH_CODE;
            parameters[19].Value = model.C_SLABWH_AREA_CODE;
            parameters[20].Value = model.C_SLABWH_LOC_CODE;
            parameters[21].Value = model.C_SLABWH_TIER_CODE;
            parameters[22].Value = model.C_XMGX_GRD;
            parameters[23].Value = model.C_ID;

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
            strSql.Append("delete from TRC_PLAN_REGROUND ");
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
            strSql.Append("delete from TRC_PLAN_REGROUND ");
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
        public Mod_TRC_PLAN_REGROUND GetModel(string C_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C_ID,C_BATCH_NO,C_STOVE,C_STL_GRD,C_MAT_CODE,C_MAT_NAME,C_SPEC,N_LEN,N_QUA,N_WGT,C_STD_CODE,C_SLAB_TYPE,N_STATUS,C_REMARK,C_XMGX,N_TOTALSTEP,D_QR_DATE,D_Q_DATE,N_QUA_VIRTUAL,C_SLABWH_CODE,C_SLABWH_AREA_CODE,C_SLABWH_LOC_CODE,C_SLABWH_TIER_CODE,C_XMGX_GRD,N_TYPE,C_EXTEND1,C_EXTEND2,C_EXTEND3,C_EXTEND4,C_EXTEND5,C_EXTEND11,C_EXTEND16,C_EXTEND17,C_EXTEND18,C_SLABWH_XLLOC_CODE,C_EMP_CODE     from TRC_PLAN_REGROUND ");
            strSql.Append(" where C_ID=:C_ID ");
            OracleParameter[] parameters = {
                    new OracleParameter(":C_ID", OracleDbType.Varchar2,100)            };
            parameters[0].Value = C_ID;

            Mod_TRC_PLAN_REGROUND model = new Mod_TRC_PLAN_REGROUND();
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
        public Mod_TRC_PLAN_REGROUND DataRowToModel(DataRow row)
        {
            Mod_TRC_PLAN_REGROUND model = new Mod_TRC_PLAN_REGROUND();
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
                if (row["C_STOVE"] != null)
                {
                    model.C_STOVE = row["C_STOVE"].ToString();
                }
                if (row["C_STL_GRD"] != null)
                {
                    model.C_STL_GRD = row["C_STL_GRD"].ToString();
                }
                if (row["C_MAT_CODE"] != null)
                {
                    model.C_MAT_CODE = row["C_MAT_CODE"].ToString();
                }
                if (row["C_MAT_NAME"] != null)
                {
                    model.C_MAT_NAME = row["C_MAT_NAME"].ToString();
                }
                if (row["C_SPEC"] != null)
                {
                    model.C_SPEC = row["C_SPEC"].ToString();
                }
                if (row["N_LEN"] != null && row["N_LEN"].ToString() != "")
                {
                    model.N_LEN = decimal.Parse(row["N_LEN"].ToString());
                }
                if (row["N_QUA"] != null && row["N_QUA"].ToString() != "")
                {
                    model.N_QUA = decimal.Parse(row["N_QUA"].ToString());
                }
                if (row["N_WGT"] != null && row["N_WGT"].ToString() != "")
                {
                    model.N_WGT = decimal.Parse(row["N_WGT"].ToString());
                }
                if (row["C_STD_CODE"] != null)
                {
                    model.C_STD_CODE = row["C_STD_CODE"].ToString();
                }
                if (row["C_SLAB_TYPE"] != null)
                {
                    model.C_SLAB_TYPE = row["C_SLAB_TYPE"].ToString();
                }
                if (row["N_STATUS"] != null && row["N_STATUS"].ToString() != "")
                {
                    model.N_STATUS = decimal.Parse(row["N_STATUS"].ToString());
                }
                if (row["C_REMARK"] != null)
                {
                    model.C_REMARK = row["C_REMARK"].ToString();
                }
                if (row["C_XMGX"] != null)
                {
                    model.C_XMGX = row["C_XMGX"].ToString();
                }
                if (row["N_TOTALSTEP"] != null && row["N_TOTALSTEP"].ToString() != "")
                {
                    model.N_TOTALSTEP = decimal.Parse(row["N_TOTALSTEP"].ToString());
                }
                if (row["D_QR_DATE"] != null && row["D_QR_DATE"].ToString() != "")
                {
                    model.D_QR_DATE = DateTime.Parse(row["D_QR_DATE"].ToString());
                }
                if (row["D_Q_DATE"] != null && row["D_Q_DATE"].ToString() != "")
                {
                    model.D_Q_DATE = DateTime.Parse(row["D_Q_DATE"].ToString());
                }
                if (row["N_QUA_VIRTUAL"] != null && row["N_QUA_VIRTUAL"].ToString() != "")
                {
                    model.N_QUA_VIRTUAL = decimal.Parse(row["N_QUA_VIRTUAL"].ToString());
                }
                if (row["C_SLABWH_CODE"] != null)
                {
                    model.C_SLABWH_CODE = row["C_SLABWH_CODE"].ToString();
                }
                if (row["C_SLABWH_AREA_CODE"] != null)
                {
                    model.C_SLABWH_AREA_CODE = row["C_SLABWH_AREA_CODE"].ToString();
                }
                if (row["C_SLABWH_LOC_CODE"] != null)
                {
                    model.C_SLABWH_LOC_CODE = row["C_SLABWH_LOC_CODE"].ToString();
                }
                if (row["C_SLABWH_TIER_CODE"] != null)
                {
                    model.C_SLABWH_TIER_CODE = row["C_SLABWH_TIER_CODE"].ToString();
                }
                if (row["C_XMGX_GRD"] != null)
                {
                    model.C_XMGX_GRD = row["C_XMGX_GRD"].ToString();
                }
                if (row["N_TYPE"] != null && row["N_TYPE"].ToString() != "")
                {
                    model.N_TYPE = decimal.Parse(row["N_TYPE"].ToString());
                }
                if (row["C_EXTEND1"] != null)
                {
                    model.C_EXTEND1 = row["C_EXTEND1"].ToString();
                }
                if (row["C_EXTEND2"] != null)
                {
                    model.C_EXTEND2 = row["C_EXTEND2"].ToString();
                }
                if (row["C_EXTEND3"] != null)
                {
                    model.C_EXTEND3 = row["C_EXTEND3"].ToString();
                }
                if (row["C_EXTEND4"] != null)
                {
                    model.C_EXTEND4 = row["C_EXTEND4"].ToString();
                }
                if (row["C_EXTEND4"] != null)
                {
                    model.C_EXTEND4 = row["C_EXTEND4"].ToString();
                }
                if (row["C_EXTEND5"] != null)
                {
                    model.C_EXTEND5 = row["C_EXTEND5"].ToString();
                }
                if (row["C_EXTEND11"] != null)
                {
                    model.C_EXTEND11 = row["C_EXTEND11"].ToString();
                }
                if (row["C_EXTEND16"] != null)
                {
                    model.C_EXTEND16 = row["C_EXTEND16"].ToString();
                }
                if (row["C_EXTEND17"] != null)
                {
                    model.C_EXTEND17 = row["C_EXTEND17"].ToString();
                }
                if (row["C_EXTEND18"] != null)
                {
                    model.C_EXTEND18 = row["C_EXTEND18"].ToString();
                }
                if (row["C_SLABWH_XLLOC_CODE"] != null)
                {
                    model.C_SLABWH_XLLOC_CODE = row["C_SLABWH_XLLOC_CODE"].ToString();
                }
                if (row["C_EMP_CODE"] != null)
                {
                    model.C_EMP_CODE = row["C_EMP_CODE"].ToString();
                }
            }
            return model;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            string sql = @"SELECT TPR.C_ID,
                             TPR.C_BATCH_NO,
                             TPR.C_STOVE,
                             TPR.C_STL_GRD,
                             TPR.C_MAT_CODE,
                             TPR.C_MAT_NAME,
                             TPR.C_SPEC,
                             TPR.N_LEN,
                             TPR.N_QUA,
                             TPR.N_WGT,
                             TPR.C_STD_CODE,
                             TPR.C_SLAB_TYPE,
                             TPR.N_STATUS,
                             TPR.C_REMARK,
                             TPR.C_XMGX,
                             TPR.N_TOTALSTEP,
                             TPR.D_QR_DATE,
                             TPR.D_Q_DATE,
                             TPR.N_QUA_VIRTUAL,
                             TPR.C_SLABWH_CODE,
                             TPR.C_SLABWH_AREA_CODE,
                             TPR.C_SLABWH_LOC_CODE,
                             TPR.C_SLABWH_TIER_CODE,
                             TPR.C_XMGX_GRD,
                             TPR.N_TYPE,
                             TPR.C_EXTEND1,
                             TPR.C_EXTEND2,
                             TPR.C_EXTEND3,
                             TPR.C_EXTEND4,
                             TPR.C_EXTEND5,
                             TPR.C_EXTEND11,
                             TPR.C_EXTEND16,
                             TPR.C_EXTEND17,
                             TPR.C_EXTEND18,
                             TPR.C_SLABWH_XLLOC_CODE,
                             TPR.C_EMP_CODE,
                             (SELECT TS.C_SLABWH_NAME FROM TPB_SLABWH TS WHERE TS.C_SLABWH_CODE = TPR.C_SLABWH_CODE AND TS.N_STATUS = 1) C_SLABWH_CODE_NAME,
                             (SELECT TSA.C_SLABWH_AREA_NAME FROM TPB_SLABWH_AREA TSA  WHERE TSA.C_SLABWH_AREA_CODE = TPR.C_SLABWH_AREA_CODE  AND TSA.N_STATUS = 1) C_SLABWH_AREA_CODE_NAME  ,
                             (SELECT TST.C_SLABWH_LOC_NAME FROM TPB_SLABWH_LOC TST WHERE TST.C_SLABWH_LOC_CODE = TPR.C_SLABWH_LOC_CODE AND TST.N_STATUS = 1) C_SLABWH_LOC_CODE_NAME ,
                            (SELECT MAX(TT.C_SLABWH_TIER_CODE) FROM TSC_SLAB_MAIN TT WHERE TT.C_SLABWH_LOC_CODE=TPR.C_SLABWH_LOC_CODE AND TT.C_MOVE_TYPE='E') MAXTIER,
                             TPR.C_SLABWH_TIER_CODE
                             FROM TRC_PLAN_REGROUND TPR";
            if (strWhere.Trim() != "")
            {
                sql += " where " + strWhere;
            }
            sql += " ORDER BY TPR.D_QR_DATE DESC ";
            return DbHelperOra.Query(sql);
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere, string[] arr)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(@"SELECT T.C_ID,
       T.C_BATCH_NO,
       T.C_STOVE,
       T.C_STL_GRD,
       T.C_MAT_CODE,
       T.C_MAT_NAME,
       T.C_SPEC,
       T.N_LEN,
       T.N_QUA,
       T.N_WGT,
       T.C_STD_CODE,
       T.C_SLAB_TYPE,
       T.N_STATUS,
       T.C_REMARK,
       T.C_XMGX,
       T.N_TOTALSTEP,
       T.D_QR_DATE,
       T.D_Q_DATE,
       T.N_QUA_VIRTUAL,
       T.C_SLABWH_CODE,
       T.C_SLABWH_AREA_CODE,
       T.C_SLABWH_LOC_CODE,
       T.C_SLABWH_TIER_CODE,
       T.C_XMGX_GRD,
       T.N_TYPE,
       T.C_EXTEND1,
       T.C_EXTEND2,
       T.C_EXTEND3,
       T.C_EXTEND4,
       T.C_EXTEND5,
       T.C_EXTEND6,
       T.C_EXTEND7,
       T.C_EXTEND8,
       T.C_EXTEND9,
       T.C_EXTEND10,
       T.C_EXTEND11,
       T.C_EXTEND16,
       T.C_EXTEND17,
       T.C_EXTEND18,
       T.C_EXTEND13,
       (SELECT MAX(TS.C_SLABWH_NAME)
          FROM TPB_SLABWH TS
         WHERE TS.C_SLABWH_CODE = T.C_SLABWH_CODE
           AND TS.N_STATUS = 1) C_SLABWH_CODE_NAME,
       (SELECT MAX(TSA.C_SLABWH_AREA_NAME)
          FROM TPB_SLABWH_AREA TSA
         WHERE TSA.C_SLABWH_AREA_CODE = T.C_SLABWH_AREA_CODE
           AND TSA.N_STATUS = 1) C_SLABWH_AREA_CODE_NAME,
       (SELECT MAX(TST.C_SLABWH_LOC_NAME)
          FROM TPB_SLABWH_LOC TST
         WHERE TST.C_SLABWH_LOC_CODE = T.C_SLABWH_LOC_CODE
           AND TST.N_STATUS = 1) C_SLABWH_LOC_CODE_NAME,
       C_SLABWH_TIER_CODE,
       (SELECT MAX(TT.C_SLABWH_TIER_CODE) FROM TSC_SLAB_MAIN TT WHERE TT.C_SLABWH_LOC_CODE=C_SLABWH_LOC_CODE AND TT.C_MOVE_TYPE='E') MAXTIER
  FROM TRC_PLAN_REGROUND  T ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }

            //if (arr != null && arr.Length > 0)
            //{
            //    strSql.Append(" AND  ( ");
            //    for (int i = 0; i < arr.Length; i++)
            //    {
            //        if (i == arr.Length - 1)
            //            strSql.Append(" C_SLABWH_CODE='" + arr[i] + "' ");
            //        else
            //            strSql.Append(" C_SLABWH_CODE='" + arr[i] + "'  OR ");
            //    }
            //    strSql.Append(" )  ");
            //}
            strSql.Append("  ORDER BY T.D_QR_DATE ");
            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetListXm(string strWhere, string[] arr)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(@"SELECT T.*,T.N_QUA-T.N AS NN
                                          FROM (SELECT TPR. C_ID,
                                                       TPR. C_BATCH_NO,
                                                       TPR. C_STOVE,
                                                       TPR. C_STL_GRD,
                                                       TPR. C_MAT_CODE,
                                                       TPR. C_MAT_NAME,
                                                       TPR. C_SPEC,
                                                       TPR. N_LEN,
                                                       TPR. N_QUA,
                                                       TPR. N_WGT,
                                                       TPR. C_STD_CODE,
                                                       TPR. C_SLAB_TYPE,
                                                       TPR. N_STATUS,
                                                       TPR. C_REMARK,
                                                       TPR. C_XMGX,
                                                       TPR. C_XMGX_GRD,
                                                       TPR. N_TOTALSTEP,
                                                       TPR. D_QR_DATE,
                                                       TPR. D_Q_DATE,
                                                       TPR. N_QUA_VIRTUAL,
                                                       TPR.C_SLABWH_CODE,
                                                       (SELECT TS.C_SLABWH_NAME FROM TPB_SLABWH TS WHERE TS.C_SLABWH_CODE = TPR.C_SLABWH_CODE AND TS.N_STATUS = 1) C_SLABWH_CODE_NAME,
                                    (SELECT TSA.C_SLABWH_AREA_NAME FROM TPB_SLABWH_AREA TSA  WHERE TSA.C_SLABWH_AREA_CODE = TPR.C_SLABWH_AREA_CODE  AND TSA.N_STATUS = 1) C_SLABWH_AREA_CODE_NAME,
                                   (SELECT TST.C_SLABWH_LOC_NAME FROM TPB_SLABWH_LOC TST WHERE TST.C_SLABWH_LOC_CODE = TPR.C_SLABWH_LOC_CODE AND TST.N_STATUS = 1) C_SLABWH_LOC_CODE_NAME ,
                                    TPR.C_SLABWH_TIER_CODE,
                                   (SELECT MAX(TT.C_SLABWH_TIER_CODE) FROM TSC_SLAB_MAIN TT WHERE TT.C_SLABWH_LOC_CODE=TPR.C_SLABWH_LOC_CODE AND TT.C_MOVE_TYPE='E') MAXTIER,
                                                       TPR.N_TYPE,
                                                       TPR.C_EXTEND1,
                                                       TPR.C_EXTEND2,
                                                       TPR.C_EXTEND3,
                                                       TPR.C_EXTEND4,
                                                       TPR.C_EXTEND5,
                                                       TPR.C_EXTEND6,
                                                       TPR.C_EXTEND7,
                                                       TPR.C_EXTEND8,
                                                       TPR.C_EXTEND9,
                                                       TPR.C_EXTEND10,
                                                       TPR.C_EXTEND11,
                                                       TPR.C_EXTEND12,
                                                       TPR.C_EXTEND16,
                                                       TPR.C_EXTEND17,
                                                       TPR.C_EXTEND18,
                                                       TPR.C_EXTEND13,
                                                       (SELECT COUNT(C_ID)
                                                                     FROM TRC_PLAN_REGROUND_ITEM TPRI
                                                                     WHERE TPRI.C_PLAN_REGROUND_ID = TPR.C_ID
                                                                     AND TPRI.N_STEPNAME = '修磨'
                                                                     AND TPRI.N_STATUS = 1) n
          FROM TRC_PLAN_REGROUND TPR) T
        WHERE T.n > 0");

            //if (arr != null && arr.Length > 0)
            //{
            //    strSql.Append(" AND  ( ");
            //    for (int i = 0; i < arr.Length; i++)
            //    {
            //        if (i == arr.Length - 1)
            //            strSql.Append(" T.C_SLABWH_CODE='" + arr[i] + "' ");
            //        else
            //            strSql.Append(" T.C_SLABWH_CODE='" + arr[i] + "'  OR ");
            //    }
            //    strSql.Append(" )  ");
            //}

            if (strWhere.Trim() != "")
            {
                strSql.Append(strWhere);
            }

            strSql.Append(" ORDER BY  T.D_QR_DATE DESC  ");

            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetListPw(string strWhere, string[] arr)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(@"SELECT T.*,T.N_QUA-T.N AS NN
                                          FROM (SELECT TPR. C_ID,
                                                       TPR. C_BATCH_NO,
                                                       TPR. C_STOVE,
                                                       TPR. C_STL_GRD,
                                                       TPR. C_MAT_CODE,
                                                       TPR. C_MAT_NAME,
                                                       TPR. C_SPEC,
                                                       TPR. N_LEN,
                                                       TPR. N_QUA,
                                                       TPR. N_WGT,
                                                       TPR. C_STD_CODE,
                                                       TPR. C_SLAB_TYPE,
                                                       TPR. N_STATUS,
                                                       TPR. C_REMARK,
                                                       TPR. C_XMGX,
                                                       TPR. C_XMGX_GRD,
                                                       TPR. N_TOTALSTEP,
                                                       TPR. D_QR_DATE,
                                                       TPR. D_Q_DATE,
                                                       TPR. N_QUA_VIRTUAL,
                                                       TPR.C_SLABWH_CODE,
                                                       TPR.N_TYPE,
                                                       TPR.C_EXTEND1,
                                                       TPR.C_EXTEND2,
                                                       TPR.C_EXTEND3,
                                                       TPR.C_EXTEND4,
                                                       TPR.C_EXTEND5,
                                                       TPR.C_EXTEND11,
   (SELECT TS.C_SLABWH_NAME FROM TPB_SLABWH TS WHERE TS.C_SLABWH_CODE = TPR.C_SLABWH_CODE AND TS.N_STATUS = 1) C_SLABWH_CODE_NAME,
                                    (SELECT TSA.C_SLABWH_AREA_NAME FROM TPB_SLABWH_AREA TSA  WHERE TSA.C_SLABWH_AREA_CODE = TPR.C_SLABWH_AREA_CODE  AND TSA.N_STATUS = 1) C_SLABWH_AREA_CODE_NAME,
                                   (SELECT TST.C_SLABWH_LOC_NAME FROM TPB_SLABWH_LOC TST WHERE TST.C_SLABWH_LOC_CODE = TPR.C_SLABWH_LOC_CODE AND TST.N_STATUS = 1) C_SLABWH_LOC_CODE_NAME ,
                                    TPR.C_SLABWH_TIER_CODE,
                                                       (SELECT COUNT(C_ID)
                                                                     FROM TRC_PLAN_REGROUND_ITEM TPRI
                                                                     WHERE TPRI.C_PLAN_REGROUND_ID = TPR.C_ID
                                                                     AND TPRI.N_STEPNAME = '抛丸探伤'
                                                                     AND TPRI.N_STATUS = 1) n
          FROM TRC_PLAN_REGROUND TPR) T
        WHERE T.n > 0");

            //if (arr != null && arr.Length > 0)
            //{
            //    strSql.Append(" AND  ( ");
            //    for (int i = 0; i < arr.Length; i++)
            //    {
            //        if (i == arr.Length - 1)
            //            strSql.Append(" T.C_SLABWH_CODE='" + arr[i] + "' ");
            //        else
            //            strSql.Append(" T.C_SLABWH_CODE='" + arr[i] + "'  OR ");
            //    }
            //    strSql.Append(" )  ");
            //}

            if (strWhere.Trim() != "")
            {
                strSql.Append(strWhere);
            }

            strSql.Append(" ORDER BY  T.D_QR_DATE DESC  ");

            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM TRC_PLAN_REGROUND ");
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
            strSql.Append(")AS Row, T.*  from TRC_PLAN_REGROUND T ");
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
        /// 获取可修磨钢坯
        /// </summary>
        /// <returns></returns>
        public DataSet GetWaitRegroudSlab(string[] slbwhCode, string sqlWhere)
        {
            List<OracleParameter> paras = new List<OracleParameter>();
            string sql = @"SELECT 
                                   TSM.C_BATCH_NO,
                                    TSM.C_STOVE,
                                    TSM.C_STL_GRD,
                                    TSM.C_SPEC,
                                    TSM.C_STA_CODE,
                                    COUNT(TSM.C_ID)N_QUA,
                                    MAX(TSM.N_WGT) N_WGT,
                                    TSM.N_LEN,
                                    TSM.C_MAT_CODE,
                                    TSM.C_MAT_NAME,
                                    TSM.C_STD_CODE,
                                    TSM.C_XMGX,
                                    TSM.C_SLABWH_CODE,
                                    TSM.C_SLABWH_AREA_CODE,
                                    TSM.C_SLABWH_LOC_CODE,
                                    CASE  TSM.C_ISXM WHEN 'N'  THEN '已修'  ELSE '未修' END  C_ISXM,
                                    CASE TSM.C_SLAB_STATUS WHEN 'N'  THEN '是'  ELSE '否' END C_SLAB_STATUS,
 (SELECT MAX(TS.C_SLABWH_NAME)
          FROM TPB_SLABWH TS
         WHERE TS.C_SLABWH_CODE = TSM.C_SLABWH_CODE
           AND TS.N_STATUS = 1) C_SLABWH_CODE_NAME,
       (SELECT MAX(TSA.C_SLABWH_AREA_NAME)
          FROM TPB_SLABWH_AREA TSA
         WHERE TSA.C_SLABWH_AREA_CODE = TSM.C_SLABWH_AREA_CODE
           AND TSA.N_STATUS = 1) C_SLABWH_AREA_CODE_NAME,
       (SELECT MAX(TST.C_SLABWH_LOC_NAME)
          FROM TPB_SLABWH_LOC TST
         WHERE TST.C_SLABWH_LOC_CODE = TSM.C_SLABWH_LOC_CODE
           AND TST.N_STATUS = 1) C_SLABWH_LOC_CODE_NAME,
                                    TSM.C_REMARK
                                    FROM TSC_SLAB_MAIN TSM
                                    WHERE  TSM.C_MOVE_TYPE='E'  ";

            sql += "   AND  ( ";

            for (int i = 0; i < slbwhCode.Length; i++)
            {
                if (i == slbwhCode.Length - 1)
                    sql += "  TSM.C_SLABWH_CODE='" + slbwhCode[i] + "'   ";
                else
                    sql += "  TSM.C_SLABWH_CODE='" + slbwhCode[i] + "' or  ";
            }

            sql += ")";

            if (!string.IsNullOrWhiteSpace(sqlWhere))
            {
                sql += sqlWhere;
            }

            sql += @"         GROUP BY TSM.C_BATCH_NO,TSM.C_STOVE,TSM.C_STL_GRD,TSM.C_SPEC,TSM.C_STA_CODE,TSM.N_LEN,TSM.C_MAT_CODE,TSM.C_MAT_NAME,TSM.C_STD_CODE,TSM.C_XMGX,TSM.C_REMARK,TSM.C_ISXM,TSM.C_SLAB_STATUS,TSM.C_SLABWH_CODE,TSM.C_SLABWH_AREA_CODE,TSM.C_SLABWH_CODE,TSM.C_SLABWH_LOC_CODE                                    ";
            sql += " ORDER BY TSM.C_STOVE DESC ";
            paras.Add(new OracleParameter() { ParameterName = ":slbwhCode", Value = slbwhCode });
            return DbHelperOra.Query(sql, paras.ToArray());
        }

        /// <summary>
        /// 获取可修磨钢坯明细
        /// </summary>
        /// <returns></returns>
        public DataSet GetWaitRegroudSlabs(string slbwhCode, string batchNo, string stove, string grd,
             string spec, string std, string matCode, string len, string factNum, string area, string loc, string isxm)
        {
            List<OracleParameter> paras = new List<OracleParameter>();
            string sql = @"SELECT * FROM TSC_SLAB_MAIN TSM
                                     WHERE   TSM.C_SLABWH_CODE = :slbwhCode
                                     AND TSM.C_MOVE_TYPE = 'E' ";
            paras.Add(new OracleParameter() { ParameterName = ":slbwhCode", Value = slbwhCode });

            if (!string.IsNullOrWhiteSpace(batchNo))
            {
                sql += "    AND TSM.C_BATCH_NO = :batchNo   ";
                paras.Add(new OracleParameter() { ParameterName = ":batchNo", Value = batchNo });
            }

            if (!string.IsNullOrWhiteSpace(stove))
            {
                sql += "    AND TSM.C_STOVE = :stove    ";
                paras.Add(new OracleParameter() { ParameterName = ":stove", Value = stove });
            }

            if (!string.IsNullOrWhiteSpace(grd))
            {
                sql += "    AND TSM.C_STL_GRD = :grd   ";
                paras.Add(new OracleParameter() { ParameterName = ":grd", Value = grd });
            }

            if (!string.IsNullOrWhiteSpace(area))
            {
                sql += "    AND TSM.C_SLABWH_AREA_CODE = :area   ";
                paras.Add(new OracleParameter() { ParameterName = ":area", Value = area });
            }

            if (!string.IsNullOrWhiteSpace(loc))
            {
                sql += "    AND TSM.C_SLABWH_LOC_CODE = :loc   ";
                paras.Add(new OracleParameter() { ParameterName = ":loc", Value = loc });
            }

            if (isxm == "Y")
            {
                sql += "    AND TSM.C_ISXM is null   ";
            }

            //if (!string.IsNullOrWhiteSpace(spec))
            //{
            //    sql += "    AND TSM.C_SPEC = :spec  ";
            //    paras.Add(new OracleParameter() { ParameterName = ":spec", Value = spec });
            //}

            //if (!string.IsNullOrWhiteSpace(std))
            //{
            //    sql += "    AND TSM.C_STD_CODE =:std   ";
            //    paras.Add(new OracleParameter() { ParameterName = ":std", Value = std });
            //}

            //if (!string.IsNullOrWhiteSpace(matCode))
            //{
            //    sql += "    AND TSM.C_MAT_CODE = :matCode   ";
            //    paras.Add(new OracleParameter() { ParameterName = ":matCode", Value = matCode });
            //}

            //if (!string.IsNullOrWhiteSpace(len))
            //{
            //    sql += "    AND TSM.N_LEN =:len   ";
            //    paras.Add(new OracleParameter() { ParameterName = ":len", Value = len });
            //}

            if (!string.IsNullOrWhiteSpace(factNum))
            {
                sql += "  AND ROWNUM<= :factNum  ";
                paras.Add(new OracleParameter() { ParameterName = ":factNum", Value = factNum });
            }

            return DbHelperOra.Query(sql, paras.ToArray());
        }

        /// <summary>
        /// 更新钢坯状态
        /// </summary>
        /// <returns></returns>
        public int UpdateSlabStatus(DataTable slabDt, string moveType, string oldMoveType, string store, string area, string kw, string floor)
        {
            List<OracleParameter> paras = new List<OracleParameter>();
            string sqlExec = @"  Update TSC_SLAB_MAIN TSM   SET TSM.C_MOVE_TYPE=:moveType ";
            paras.Add(new OracleParameter() { ParameterName = ":moveType", Value = moveType });

            sqlExec += "   WHERE   ( ";
            if (slabDt != null && slabDt.Rows.Count > 0)
            {
                for (int i = 0; i < slabDt.Rows.Count; i++)
                {
                    if (i == slabDt.Rows.Count - 1)
                        sqlExec += " TSM.C_ID= '" + slabDt.Rows[i]["C_ID"] + "'";
                    else
                        sqlExec += " TSM.C_ID= '" + slabDt.Rows[i]["C_ID"] + "' OR ";
                }
            }
            sqlExec += ")   AND TSM.C_MOVE_TYPE=:oldMoveType    ";

            paras.Add(new OracleParameter() { ParameterName = ":oldMoveType", Value = oldMoveType });

            int resultCount = TransactionHelper.ExecuteSql(sqlExec, paras.ToArray());
            return resultCount;
        }

        /// <summary>
        /// 更新钢坯状态
        /// </summary>
        /// <returns></returns>
        public int UpdateSlabStatus(string id, string moveType, string oldMoveType)
        {
            List<OracleParameter> paras = new List<OracleParameter>();
            string sqlExec = @"  Update TSC_SLAB_MAIN TSM  
                                                    SET TSM.C_MOVE_TYPE=:moveType , TSM.C_ISXM='N'  ";
            paras.Add(new OracleParameter() { ParameterName = ":moveType", Value = moveType });

            sqlExec += "   WHERE  TSM.C_ID ='" + id + "' ";

            sqlExec += "    AND TSM.C_MOVE_TYPE=:oldMoveType   ";

            paras.Add(new OracleParameter() { ParameterName = ":oldMoveType", Value = oldMoveType });

            int resultCount = TransactionHelper.ExecuteSql(sqlExec, paras.ToArray());
            return resultCount;
        }

        /// <summary>
        /// 更新钢坯状态
        /// </summary>
        /// <returns></returns>
        public int ElimSlabStatus(string id, string moveType, string oldMoveType, string remark, string slabCode)
        {
            List<OracleParameter> paras = new List<OracleParameter>();
            string sqlExec = @"  Update TSC_SLAB_MAIN TSM      SET TSM.C_MOVE_TYPE='" + moveType + "' , TSM.C_SLAB_STATUS='Y' ,TSM.C_REMARK='" + remark + "' ,TSM.C_SLABWH_CODE='" + slabCode + "' ";

            sqlExec += "   WHERE  TSM.C_ID ='" + id + "' ";

            sqlExec += "    AND TSM.C_MOVE_TYPE='" + oldMoveType + "'   ";

            int resultCount = TransactionHelper.ExecuteSql(sqlExec);
            return resultCount;
        }



        /// <summary>
        /// 获取修磨钢坯id
        /// </summary>
        /// <param name="id">主键</param>
        /// <returns></returns>
        public DataSet GetRegroundSlab(string id)
        {
            string sql = @"SELECT DISTINCT TPRI.C_SLAB_MAIN_ID  C_ID
                                    FROM TRC_PLAN_REGROUND_ITEM TPRI
                                 WHERE TPRI.C_PLAN_REGROUND_ID='" + id + "'";
            return DbHelperOra.Query(sql);
        }

        /// <summary>
        /// 获取修磨当前执行步骤信息
        /// </summary>
        /// <param name="id">主键</param>
        /// <param name="row">行数</param>
        /// <param name="type">类型 修磨 探伤抛丸</param>
        /// <returns></returns>
        public DataSet GetRegroundStep(string id, int row, string type)
        {
            string sql = @"   SELECT *
                                       FROM TRC_PLAN_REGROUND_ITEM TPRI
                                       WHERE TPRI.N_STEPNAME = '" + type + "' ";
            sql += " AND TPRI.N_STATUS = 1 ";
            sql += " AND TPRI.C_PLAN_REGROUND_ID = '" + id + "' ";
            sql += " AND ROWNUM<=" + row;
            return DbHelperOra.Query(sql);
        }

        /// <summary>
        /// 获取修磨当下一步骤信息
        /// </summary>
        /// <param name="id">钢坯主键</param>
        /// <param name="step">步骤</param>
        /// <returns></returns>
        public DataSet GetRegroundNextStep(string id, int step, string regroundID)
        {
            string sql = @"   SELECT * FROM TRC_PLAN_REGROUND_ITEM TPRI
                                       WHERE TPRI.C_SLAB_MAIN_ID='" + id + "' AND TPRI.C_PLAN_REGROUND_ID = '" + regroundID + "'    AND TPRI.N_STEP=" + step;
            return DbHelperOra.Query(sql);
        }

        /// <summary>
        /// 获取修磨操作记录
        /// </summary>
        /// <param name="status">状态 1修磨 2抛丸探伤</param>
        /// <param name="id"></param>
        /// <returns></returns>
        public DataSet GetRegroundHandler(int status, string id)
        {
            string sql = @"SELECT * FROM TRC_PLAN_REGROUND_HANDLER TPRH  LEFT JOIN TS_USER TU  ON TU.C_ACCOUNT=TPRH.C_EMP_NAME
                                    WHERE TPRH.N_STATUS=" + status;
            sql += @"       AND TPRH.C_REGROUND_ID ='" + id + "'    ORDER BY TPRH.D_DT ";
            return DbHelperOra.Query(sql);
        }

        /// <summary>
        /// 获取修磨操作记录
        /// </summary>
        /// <param name="status">状态 1修磨 2抛丸探伤</param>
        /// <param name="id"></param>
        /// <returns></returns>
        public DataSet GetRegroundHandler(string id)
        {
            string sql = @"SELECT TPRH.*
                                    , CASE TPRH.N_STATUS  WHEN 1 THEN    '修磨'    ELSE  '抛丸'   END AS  STATUS
                                    ,TPRH.C_EMP_NAME  C_EMP_ID
                                    FROM TRC_PLAN_REGROUND_HANDLER TPRH
                                    WHERE  TPRH.C_REGROUND_ID ='" + id + "'    ORDER BY TPRH.D_DT ";
            return DbHelperOra.Query(sql);
        }

        /// <summary>
        /// 更新修磨步骤状态
        /// </summary>
        /// <param name="id">主键</param>
        /// <param name="status">当前状态0闲置1正在处理2已处理</param>
        /// <returns></returns>
        public int UpdateRegroundStepStatus(string id, int status)
        {
            string sql = @"UPDATE  TRC_PLAN_REGROUND_ITEM TPRI
                                    SET TPRI.N_STATUS=" + status;
            sql += " WHERE TPRI.C_ID ='" + id + "' ";
            return TransactionHelper.ExecuteSql(sql);
        }

        /// <summary>
        /// 检查修磨工序是否全部完成
        /// </summary>
        /// <returns></returns>
        public bool CheckRegroundIsAllSet(string id)
        {
            string sql = @"SELECT COUNT(C_ID) FROM TRC_PLAN_REGROUND_ITEM TPRI
                                     WHERE TPRI.C_PLAN_REGROUND_ID= '" + id + "'  AND TPRI.N_STATUS!=2";
            int count = Convert.ToInt32(DbHelperOra.GetSingle(sql).ToString());
            if (count == 0)
                return true;
            else
                return false;
        }

        /// <summary>
        /// 更新修磨计划状态
        /// </summary>
        /// <returns></returns>
        public int UpdatePlanRegroundStatus(string id)
        {
            string sql = @" UPDATE TRC_PLAN_REGROUND TPR
                                     SET TPR.N_STATUS=1
                                     WHERE TPR.C_ID='" + id + "'";
            return DbHelperOra.ExecuteSql(sql);
        }

        /// <summary>
        /// 获取修磨工位信息
        /// </summary>
        /// <returns></returns>
        public DataSet GetStaInfo()
        {
            string sql = @"SELECT * FROM 
                                    TB_STA TS 
                                    WHERE TS.C_STA_CODE LIKE '%XM%'
                                    ORDER BY TS.N_SORT ";
            return DbHelperOra.Query(sql);
        }

        /// <summary>
        /// 获取抛丸工位信息
        /// </summary>
        /// <returns></returns>
        public DataSet GetStaInfo(int type)
        {
            string sql = @"SELECT * FROM 
                                    TB_STA TS 
                                    WHERE TS.C_STA_CODE LIKE '%PW%'
                                    ORDER BY TS.N_SORT ";
            return DbHelperOra.Query(sql);
        }


        /// <summary>
        /// 更新修磨计划
        /// </summary>
        /// <param name="id">组批表ID</param>
        /// <param name="putNum">入炉支数</param>
        /// <returns></returns>
        public int UpdatePlanSms(string stove, int putNum, decimal wgt, DateTime? start, DateTime? end, int type)
        {
            List<OracleParameter> paras = new List<OracleParameter>();
            decimal factWgt = putNum * wgt;
            string sql = @"UPDATE TSP_PLAN_SMS TRM 
                                    SET TRM.N_XM_WGT=TRM.N_XM_WGT" + (type == 1 ? "+" : "-") + ":wgt ";
            sql += "  ,TRM.D_XM_START_TIME=to_date('" + start.Value.Date.ToString("yyyyMMdd") + "','yyyy-mm-dd') ";
            sql += "   ,TRM.D_XM_END_TIME=to_date('" + end.Value.Date.ToString("yyyyMMdd") + "','yyyy-mm-dd')  ";
            sql += "  WHERE TRM.C_STOVE_NO=:id";
            paras.Add(new OracleParameter() { ParameterName = ":wgt", Value = factWgt });
            paras.Add(new OracleParameter() { ParameterName = ":id", Value = stove });
            return TransactionHelper.ExecuteSql(sql, paras.ToArray());
        }

        /// <summary>
        /// 删除修磨记录
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool DelRegroundHandler(string id)
        {
            string sql = @"DELETE TRC_PLAN_REGROUND_HANDLER T WHERE T.C_ID='" + id + "'";
            int rows = TransactionHelper.ExecuteSql(sql);
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
        /// 更新修磨工序
        /// </summary>
        /// <returns></returns>
        public bool UpdateRegroundProcedure(string id, string procedure, int num, int type)
        {
            string calcuate = type == 1 ? "+" : "-";
            string sql = "UPDATE TRC_PLAN_REGROUND TPR SET TPR." + procedure + " =TPR." + procedure + " " + calcuate + " " + num + " WHERE TPR.C_ID = '" + id + "'";
            int rows = TransactionHelper.ExecuteSql(sql);
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
        /// 更新修磨工序
        /// </summary>
        /// <returns></returns>
        public bool UpdateRegroundType(string id, int type)
        {
            string sql = "UPDATE TRC_PLAN_REGROUND TPR SET TPR.N_TYPE=" + type + " WHERE TPR.C_ID = '" + id + "'";
            int rows = TransactionHelper.ExecuteSql(sql);
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
        /// 剔除时修改计划支数
        /// </summary>
        /// <returns></returns>
        public bool ElimReground(string id, int num, string remark)
        {
            string sql = "UPDATE TRC_PLAN_REGROUND TPR SET     TPR.N_QUA=TPR.N_QUA-" + num + " , TPR.C_EXTEND11=TPR.C_EXTEND11+" + num + " ,TPR.C_REMARK='" + remark + "'  WHERE TPR.C_ID = '" + id + "'";
            int rows = TransactionHelper.ExecuteSql(sql);
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
        /// 剔除时删除子表记录
        /// </summary>
        /// <returns></returns>
        public bool ElimRegroundItem(string id, string slabID)
        {
            string sql = " DELETE TRC_PLAN_REGROUND_ITEM TPRI WHERE TPRI.C_PLAN_REGROUND_ID='" + id + "' AND TPRI.C_SLAB_MAIN_ID='" + slabID + "' ";
            int rows = TransactionHelper.ExecuteSql(sql);
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
        /// 修改修磨计划状态
        /// </summary>
        public void UpdateRegroundType()
        {
            string sql = @"UPDATE TRC_PLAN_REGROUND TPR
                           SET TPR.N_TYPE=2
                           WHERE TPR.C_EXTEND1>0 
                              OR TPR.C_EXTEND2>0
                              OR TPR.C_EXTEND3>0
                              OR TPR.C_EXTEND4>0
                              OR TPR.C_EXTEND5>0 ";
            DbHelperOra.ExecuteSql(sql);
            string sql2 = @"UPDATE TRC_PLAN_REGROUND TPR
                            SET TPR.N_TYPE=1
                            WHERE TPR.C_EXTEND1=0 
                               AND TPR.C_EXTEND2=0
                               AND TPR.C_EXTEND3=0
                               AND TPR.C_EXTEND4=0
                               AND TPR.C_EXTEND5=0 ";
            DbHelperOra.ExecuteSql(sql2);
        }

        /// <summary>
        /// 重置修磨标准支数
        /// </summary>
        public void ResetRegroundQua()
        {
            OracleParameter[] parameters = { };
            DbHelperOra.RunProcedure("RESET_REGROUND_QUA", parameters);
        }

        #endregion  ExtensionMethod
    }
}
